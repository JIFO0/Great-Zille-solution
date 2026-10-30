"""(v8 header reused for v9) v7 provinces: organic feature-following land cells (compact watershed on relief+rivers+roads+noise, variable-density seeds),
8 urban-shaped city provinces, smooth inland zone edges, irregular angular sea corridor (Voronoi). -> work/prov8_stage2.pkl"""
import numpy as np, pickle, sys, io, cairosvg, time
T0=time.time()
def tp(*a): print('[%.0fs]'%(time.time()-T0),*a,flush=True)
exec(open('provinces6.py').read().split("Zz=(pen|")[0])          # masks, helpers (G, LAND, LIN, pen/ol/we, d_pen, d_ch, ISL, label_polys...)
from skimage.segmentation import watershed
from shapely.geometry import LineString
from shapely.strtree import STRtree
from PIL import Image
Image.MAX_IMAGE_PIXELS=None
LIM=880          # raw cell bbox limit (map px); final shapes <=868 map px -> <=980 incl. stroke+blur at map scale
GAP=64           # map-space gap (= ~34 px in the 512 tile)
FIN=868
LIN8=LAND.buffer(-27)
rng=np.random.default_rng(int(sys.argv[1]) if len(sys.argv)>1 else 7)
# ---------- feature rasters from the v6 map ----------
SV=open('versions/v6/zille_vector.svg').read()
def group(gid):
    i=SV.find(f'<g id="{gid}"'); k=i; depth=0
    while True:
        a=SV.find('<g',k+1); b=SV.find('</g>',k+1)
        if a!=-1 and a<b: depth+=1; k=a
        else:
            if depth==0: return SV[i:b+4]
            depth-=1; k=b
def gmask(gids,extra=''):
    body=''.join(group(g) for g in gids)
    s=f'<svg xmlns="http://www.w3.org/2000/svg" width="{W}" height="{H}" viewBox="0 0 12288 8192">{extra}{body}</svg>'
    im=Image.open(io.BytesIO(cairosvg.svg2png(bytestring=s.encode(),output_width=W,output_height=H))).convert('RGBA')
    return np.asarray(im)[:,:,3]/255.0
riv=gmask(['rivers']); rds=gmask(['main_roads','roads_double_fill'])
h=np.load('work/topo_h5.npy'); h=h/h.max()
noise1=fbm((H,W),18,3,np.random.default_rng(21)); noise2=fbm((H,W),5,2,np.random.default_rng(22))
E=0.55*ndi.gaussian_filter(h,1.5)+0.9*ndi.gaussian_filter(riv,1.2)/max(ndi.gaussian_filter(riv,1.2).max(),1e-6)+0.25*ndi.gaussian_filter(rds,1.0)/max(ndi.gaussian_filter(rds,1.0).max(),1e-6)+0.30*(noise1+1)/2
E=(E-E.min())/(E.max()-E.min())

# ======================= v9: new partition at true 980-px tile scale =======================
# Size rule (map px, incl. stroke+blur at map scale): 512 < extent < 980 ; target 650-950.
# extent ~= shape bbox + ~100  ->  shape bbox target ~540..860
FIN=860           # hard cap on final shape bbox
LIMR=900          # raw (pre-gap) cap
MINR=int(sys.argv[2]) if len(sys.argv)>2 else 660    # raw lower bound for agglomeration
MINF=520          # final shape bbox lower bound (-> extent >= ~620)
def bbm(g): b=g.bounds; return max(b[2]-b[0],b[3]-b[1])
def bbwh(g): b=g.bounds; return b[2]-b[0],b[3]-b[1]
# ---------- city provinces ----------
CITY8={'Zille':'Zille','Wiktrany':'Zille','Mave Nortus':'Zille','Nanta':'Zille','Isor':'Zille','Munat':'Zille','Dapalle':'Brenas','Kratsna':'Wehlen'}
SMALLCITY={'Munat','Isor','Dapalle'}     # naturally small: allowed exceptions (< 512 incl. blur)
CMIN=520                                  # other cities: grow the urban outline until bbox >= CMIN (extent ~570+)
city={}
for n,rg in CITY8.items():
    U=URB[n]; m=50
    g=biggest(sm(U.buffer(m,join_style=1),25).intersection(LIN8))
    if n not in SMALLCITY:
        while bbm(g)<CMIN and m<400:
            m+=10; g=biggest(sm(U.buffer(m,join_style=1),max(25,m//3)).intersection(LIN8))
    while bbm(g)>FIN and m>8:
        m-=4; g=biggest(sm(U.buffer(m,join_style=1),25).intersection(LIN8))
    city[n]=dict(region=rg,poly=g,margin=m,note=f'urban outline + {m}px margin')
    print('city',n,'margin',m,'bbox',[round(v) for v in bbwh(g)])
allcity=unary_union([v['poly'] for v in city.values()])
cityblock=rast(allcity.buffer(64))
# ---------- zones (deeper: >=2 provinces at ~750 px) ----------
low=fbm((H,W),3,2,np.random.default_rng(31))
DB=np.clip(1650+250*low,1500,1900)
DW=np.clip(np.interp(Y,[600,1500,2600,3600],[2000,1900,1750,1600])+250*low,1500,2150)
def smooth_mask(m,s=4): return ndi.gaussian_filter(m.astype(float),s)>0.5
islm=np.zeros((H,W),bool)
for nm,(rg,g) in ISL.items(): islm|=rast(g.buffer(30))
MARB=np.hypot(X-7633,Y-7758)<900
Bz=smooth_mask(ol&((d_pen<DB)|MARB),8)&ol
Wz=smooth_mask(we&(d_ch<DW),8)&we
Zz=pen
def zone_poly(m):
    g=mask_poly(ndi.binary_opening(m,iterations=2),(0,0),sig=2.5)
    return g.buffer(-80,join_style=1).buffer(80,join_style=1).simplify(3)
OUT_R=zone_poly(Zz|Bz); OUT_W=zone_poly(Wz)
OUTER=unary_union([OUT_R,OUT_W]).intersection(FRAME)
landm2=rast(LIN.intersection(OUTER))
zones={'Zille':Zz&landm2&~cityblock&~islm,'Brenas':Bz&landm2&~cityblock&~islm,'Wehlen':Wz&landm2&~cityblock&~islm}
for k,z in zones.items(): print('zone',k,'area %.1fM'%(z.sum()*G*G/1e6))
# ---------- superpixels: organic watershed fragments (~150 px) ----------
def poisson(zone,r,seed):
    rr=np.random.default_rng(seed); ys,xs=np.nonzero(zone); idx=rr.permutation(len(ys)); acc=[]; hsh={}; cell=r/1.5
    for i in idx[:60000]:
        x,y=(xs[i]+rr.random())*G,(ys[i]+rr.random())*G; cx,cy=int(x//cell),int(y//cell); ok=True
        for dx in (-2,-1,0,1,2):
            for dy in (-2,-1,0,1,2):
                for (px,py) in hsh.get((cx+dx,cy+dy),()):
                    if (px-x)**2+(py-y)**2<r*r: ok=False; break
                if not ok: break
            if not ok: break
        if ok: acc.append((x,y)); hsh.setdefault((cx,cy),[]).append((x,y))
    return acc
def superpixels(zone,seed,r=150):
    mk=np.zeros((H,W),np.int32)
    for i,(x,y) in enumerate(poisson(zone,r,seed)): mk[min(int(y/G),H-1),min(int(x/G),W-1)]=i+1
    L=watershed(E,mk,mask=zone,compactness=0.02)
    # unreached zone pixels (disconnected crumbs) get own labels
    un=zone&(L==0); lab,n=ndi.label(un); L[un]=lab[un]+L.max()
    L=fix_conn(L)
    # relabel compactly
    u=np.unique(L); u=u[u>0]; lut=np.zeros(L.max()+1,np.int32); lut[u]=np.arange(1,len(u)+1); return lut[L]
def adjacency(L):
    A={}
    for a,b in ((L[:,1:],L[:,:-1]),(L[1:,:],L[:-1,:])):
        m=(a>0)&(b>0)&(a!=b); p=np.stack([np.minimum(a[m],b[m]),np.maximum(a[m],b[m])],1)
        if len(p)==0: continue
        u,c=np.unique(p,axis=0,return_counts=True)
        for (i,j),k in zip(u,c): A[(i,j)]=A.get((i,j),0)+k
    return A
def agglomerate(L,minr,limr):
    n=L.max(); objs=ndi.find_objects(L); area=np.bincount(L.ravel(),minlength=n+1)
    P={i:dict(b=[objs[i-1][1].start,objs[i-1][0].start,objs[i-1][1].stop,objs[i-1][0].stop],a=int(area[i]),sp=[i],nb={}) for i in range(1,n+1) if objs[i-1] is not None}
    for (i,j),k in adjacency(L).items():
        if i in P and j in P: P[i]['nb'][j]=k; P[j]['nb'][i]=k
    def ub(b1,b2): return [min(b1[0],b2[0]),min(b1[1],b2[1]),max(b1[2],b2[2]),max(b1[3],b2[3])]
    def side(b): return max(b[2]-b[0],b[3]-b[1])*G
    def merge(p,q):
        A_,B_=P[p],P[q]; A_['b']=ub(A_['b'],B_['b']); A_['a']+=B_['a']; A_['sp']+=B_['sp']
        for r,k in B_['nb'].items():
            if r==p: continue
            A_['nb'][r]=A_['nb'].get(r,0)+k; P[r]['nb'].pop(q,None); P[r]['nb'][p]=A_['nb'][r]
        A_['nb'].pop(q,None); del P[q]
    def best_partner(p):
        best=None; bp=P[p]['b']
        for q,k in P[p]['nb'].items():
            b=ub(bp,P[q]['b']); w=(b[2]-b[0])*G; h=(b[3]-b[1])*G; Lm=max(w,h)
            if Lm>limr: continue
            fill=(P[p]['a']+P[q]['a'])/((b[2]-b[0])*(b[3]-b[1]))
            cost=Lm+0.5*abs(w-h)-350*fill-1.5*k*G/np.sqrt(P[p]['a']*G*G)*40
            if best is None or cost<best[0]: best=(cost,q)
        return best
    stuck=set()
    while True:
        small=sorted([p for p in P if side(P[p]['b'])<minr and p not in stuck],key=lambda p:(side(P[p]['b']),P[p]['a']))
        if not small: break
        p=small[0]; bp=best_partner(p)
        if bp is None: stuck.add(p); continue
        merge(p,bp[1]); stuck.discard(bp[1])
        stuck={s for s in stuck if s in P}
    # dissolve leftovers: hand each fragment to a neighbouring province that can take it
    own={sp_:p for p in P for sp_ in P[p]['sp']}
    for p in sorted([p for p in P if side(P[p]['b'])<minr],key=lambda p:P[p]['a']):
        if p not in P or side(P[p]['b'])>=minr: continue
        remaining=set(P[p]['sp']); changed=True
        while remaining and changed:
            changed=False
            for s_ in list(remaining):
                sl=objs[s_-1]; sl2=(slice(max(sl[0].start-1,0),sl[0].stop+1),slice(max(sl[1].start-1,0),sl[1].stop+1))
                sub=L[sl2]; m=sub==s_; ring=ndi.binary_dilation(m)&~m; nbl=sub[ring]; nbl=nbl[nbl>0]
                cands={}
                for t in nbl:
                    q=own.get(int(t))
                    if q is None or q==p: continue
                    cands[q]=cands.get(q,0)+1
                bs=[sl[1].start,sl[0].start,sl[1].stop,sl[0].stop]
                fit=[(c,q) for q,c in cands.items() if side(ub(P[q]['b'],bs))<=limr]
                if fit:
                    c,q=max(fit); P[q]['b']=ub(P[q]['b'],bs); P[q]['a']+=int(area[s_]); P[q]['sp'].append(s_); own[s_]=q; remaining.discard(s_); changed=True
        if remaining:
            P[p]['sp']=list(remaining)
            m=np.isin(L,list(remaining)); ys,xs=np.nonzero(m); P[p]['b']=[xs.min(),ys.min(),xs.max()+1,ys.max()+1]; P[p]['a']=int(m.sum())
        else:
            del P[p]
    out=np.zeros_like(L); lut=np.zeros(n+1,np.int32)
    for k,(p,v) in enumerate(P.items()): lut[v['sp']]=k+1
    out=lut[L]
    return fix_conn(out)
cells=[]; Lc=np.zeros((H,W),np.int32); lreg={}; nxt=1
for k,(name,z) in enumerate(zones.items()):
    SPX=superpixels(z,200+k)
    tp(name,'superpixels',SPX.max())
    L=agglomerate(SPX,MINR,LIMR)
    for i,sl in enumerate(ndi.find_objects(L)):
        if sl is None: continue
        m=L[sl]==i+1
        lab,nn=ndi.label(m)
        if nn>1:
            sz=ndi.sum(m,lab,range(1,nn+1)); sub=L[sl]; sub[(lab!=np.argmax(sz)+1)&m]=0
    for i,sl in enumerate(ndi.find_objects(L)):
        if sl is None: continue
        m=L[sl]==i+1
        if not m.any(): continue
        sub=Lc[sl]; sub[m]=nxt; lreg[nxt]=name; nxt+=1
    tp(name,'provinces',len(np.unique(L))-1)
# orphans -> adjacent same-region label
for name,z in zones.items():
    orph=z&(Lc==0); lab,n=ndi.label(orph)
    for i,sl in enumerate(ndi.find_objects(lab)):
        sl2=(slice(max(sl[0].start-2,0),sl[0].stop+2),slice(max(sl[1].start-2,0),sl[1].stop+2))
        m=lab[sl2]==i+1; ring=ndi.binary_dilation(m)&~m; nb=Lc[sl2][ring]; nb=nb[nb>0]
        nb=[q for q in nb if lreg[q]==name]
        if nb: sub=Lc[sl2]; sub[m]=np.bincount(nb).argmax()
# ---- raster post-pass: (1) dissolve undersized provinces pixel-wise into nearest neighbours, (2) smooth jagged fragment edges
def lab_side(L,k,objs):
    sl=objs[k-1]; return max(sl[0].stop-sl[0].start,sl[1].stop-sl[1].start)*G
def dissolve_px(L,minr,limr):
    for rnd in range(4):
        objs=ndi.find_objects(L); n=0
        small=[k for k in range(1,len(objs)+1) if objs[k-1] is not None and lab_side(L,k,objs)<minr]
        for k in sorted(small,key=lambda k:lab_side(L,k,objs)):
            objs=ndi.find_objects(L)
            if objs[k-1] is None: continue
            sl=objs[k-1]; pad=int(limr/G)
            y0,y1,x0,x1=max(sl[0].start-pad,0),min(sl[0].stop+pad,H),max(sl[1].start-pad,0),min(sl[1].stop+pad,W)
            sub=L[y0:y1,x0:x1]; m=sub==k
            oth=(sub>0)&~m&np.isin(sub,[q for q in np.unique(sub) if q>0 and q!=k and lreg.get(q)==lreg.get(k)])
            if not oth.any(): continue
            d,(iy,ix)=ndi.distance_transform_edt(~oth,return_indices=True)
            tgt=sub[iy,ix]; ok_any=False; newsub=sub.copy()
            for q in np.unique(tgt[m]):
                part=m&(tgt==q)&(d<=pad)
                if not part.any(): continue
                ys,xs=np.nonzero(part); qs=objs[q-1]
                by0=min(qs[0].start,ys.min()+y0); by1=max(qs[0].stop,ys.max()+1+y0); bx0=min(qs[1].start,xs.min()+x0); bx1=max(qs[1].stop,xs.max()+1+x0)
                if max(by1-by0,bx1-bx0)*G<=limr: newsub[part]=q; ok_any=True
            if ok_any and not (newsub==k).any():
                L[y0:y1,x0:x1]=newsub; n+=1
            elif ok_any and (newsub==k).sum()<0.25*m.sum():
                newsub[newsub==k]=0; L[y0:y1,x0:x1]=newsub; n+=1
        if not n: break
    return L
def smooth_labels(L,sig=3.0):
    best=np.zeros(L.shape,np.float32); out=np.zeros_like(L); objs=ndi.find_objects(L); pad=int(4*sig)+2
    for k,sl in enumerate(objs,1):
        if sl is None: continue
        y0,y1,x0,x1=max(sl[0].start-pad,0),min(sl[0].stop+pad,H),max(sl[1].start-pad,0),min(sl[1].stop+pad,W)
        g=ndi.gaussian_filter((L[y0:y1,x0:x1]==k).astype(np.float32),sig)
        b=best[y0:y1,x0:x1]; o=out[y0:y1,x0:x1]; upd=g>b; b[upd]=g[upd]; o[upd]=k
    out[L==0]=0
    # keep region consistency: pixel may only take a label from its own region
    reg_of=np.zeros(L.max()+1,np.int8); RID={'Zille':1,'Brenas':2,'Wehlen':3}
    for k,v in lreg.items(): reg_of[k]=RID[v]
    bad=(L>0)&(reg_of[out]!=reg_of[L]); out[bad]=L[bad]
    return fix_conn(out)
def side_of(m):
    ys,xs=np.nonzero(m); return max(ys.max()-ys.min()+1,xs.max()-xs.min()+1)*G
def resplit(L,minr,limr):
    """undersized province + a neighbour -> merged, then re-split into two balanced organic halves"""
    for rnd in range(6):
        objs=ndi.find_objects(L); n=0
        small=[k for k in range(1,len(objs)+1) if objs[k-1] is not None and lab_side(L,k,objs)<minr]
        for k in small:
            objs=ndi.find_objects(L)
            if objs[k-1] is None or lab_side(L,k,objs)>=minr: continue
            sl=objs[k-1]; pad=int(limr/G)
            y0,y1,x0,x1=max(sl[0].start-pad,0),min(sl[0].stop+pad,H),max(sl[1].start-pad,0),min(sl[1].stop+pad,W)
            sub=L[y0:y1,x0:x1]; m=sub==k
            ring=ndi.binary_dilation(m,iterations=2)&~m; nbs=[q for q in np.unique(sub[ring]) if q>0 and q!=k and lreg.get(q)==lreg.get(k)]
            best=None
            for q in nbs:
                U=(sub==k)|(sub==q); ys,xs=np.nonzero(U); P2=np.stack([xs,ys],1).astype(float); c=P2.mean(0)
                if max(np.ptp(ys),np.ptp(xs))*G>2*limr: continue
                ev=np.linalg.eigh(np.cov((P2-c).T))[1][:,-1]; t=(P2-c)@ev
                for f in (0.5,0.42,0.58,0.35,0.65):
                    thr=np.quantile(t,f)
                    i1=np.argmin(np.abs(t-np.quantile(t,f/2))); i2=np.argmin(np.abs(t-np.quantile(t,(1+f)/2)))
                    mk=np.zeros(U.shape,np.int32); mk[ys[i1],xs[i1]]=1; mk[ys[i2],xs[i2]]=2
                    Ew=E[y0:y1,x0:x1]
                    S2=watershed(Ew,mk,mask=U,compactness=0.05)
                    A_=S2==1; B_=S2==2
                    if ndi.label(A_)[1]!=1 or ndi.label(B_)[1]!=1: continue
                    sa,sb=side_of(A_),side_of(B_)
                    if max(sa,sb)>limr: continue
                    sc=min(sa,sb)
                    if best is None or sc>best[0]: best=(sc,q,A_,B_)
            if best and best[0]>lab_side(L,k,objs)+40:
                sc,q,A_,B_=best; sub[A_]=k; sub[B_]=q; n+=1
        if not n: break
    return L
before=len(np.unique(Lc))-1
Lc=dissolve_px(Lc,int(sys.argv[5]) if len(sys.argv)>5 else 600,LIMR)
Lc=resplit(Lc,int(sys.argv[5]) if len(sys.argv)>5 else 600,LIMR)
for _ in range(2): Lc=smooth_labels(Lc,3.0)
tp('raster post-pass: provinces',before,'->',len(np.unique(Lc))-1)
_o=ndi.find_objects(Lc)
print('raster small',[(k,lreg.get(k),lab_side(Lc,k,_o),int((_o[k-1][1].start+_o[k-1][1].stop)*G/2),int((_o[k-1][0].start+_o[k-1][0].stop)*G/2)) for k in range(1,len(_o)+1) if _o[k-1] is not None and lab_side(Lc,k,_o)<600])
P=label_polys(Lc)
for k,p in P.items():
    if p.is_empty: continue
    cells.append(dict(region=lreg[k],raw=p,kind='cell'))
for nm,(rg,g) in ISL.items():
    if nm.startswith('Kreleck'): continue
    gi=biggest(g.buffer(-14))
    cells.append(dict(region=rg,raw=boxclip(gi.buffer(-13),FIN),kind='island',island=nm,fixed=True,name=nm))
KRL=unary_union([biggest(ISL[n][1].buffer(-14)).buffer(-13) for n in ('Kreleck West','Kreleck East')])
cells.append(dict(region='Wehlen',raw=KRL,kind='island',island='Kreleck Islands',fixed=True,name='Kreleck Islands'))
for n,v in city.items():
    cells.append(dict(region=v['region'],raw=v['poly'],kind='city',city=n,fixed=True,name=n,note=v['note']))
tp('raster done')
# ---------- vector gaps (64 map px) ----------
ZONEV=LIN8.intersection(OUTER)
raws=[c['raw'] for c in cells]; tree=STRtree(raws)
for i,c in enumerate(cells):
    p=c['raw']
    if c.get('fixed'): g=p
    else:
        base=p.buffer(70,join_style=1).intersection(ZONEV)
        near=[j for j in tree.query(p.buffer(140)) if j!=i]
        cut=unary_union([cells[j]['raw'].buffer(64 if cells[j]['kind']!='cell' else 32) for j in near]) if near else Polygon()
        g0=base.difference(cut); g=g0
        for rr in (60,40,20,0):
            go=g0.buffer(-rr,join_style=1).buffer(rr,join_style=1) if rr else g0
            if not go.is_empty and biggest(go).area>=0.985*biggest(g0).area-1500: g=go; break
    if c.get('island')!='Kreleck Islands': g=biggest(g)
    if bbm(g)>FIN: g=boxclip(g,FIN)
    c['poly']=g; c['type']='land'
# ---------- enforce lower bound at vector level: merge undersized cells into a neighbour ----------
def remerge():
    global cells
    polys=[c['poly'] for c in cells]; tr=STRtree(polys); removed=set(); touched=set()
    for ci in sorted([i for i,c in enumerate(cells) if c['kind']=='cell' and bbm(c['poly'])<MINF],key=lambda i:cells[i]['poly'].area):
        if ci in touched: continue
        c=cells[ci]; best=None
        for oi in tr.query(c['poly'].buffer(90)):
            o=cells[oi]
            if oi==ci or oi in touched or o['kind']!='cell' or o['region']!=c['region'] or o['poly'].distance(c['poly'])>90: continue
            U=unary_union([o['poly'],c['poly'],o['poly'].buffer(75).intersection(c['poly'].buffer(75)).intersection(ZONEV)])
            if bbm(U)>FIN: continue
            near=[q for q in tr.query(U.buffer(200)) if q not in (oi,ci) and q not in removed]
            others=unary_union([cells[q]['poly'].buffer(64) for q in near])
            U=biggest(U.difference(others).buffer(-3).buffer(3))
            if bbm(U)<=FIN and U.area>o['poly'].area+0.7*c['poly'].area:
                if best is None or bbm(U)<best[0]: best=(bbm(U),oi,U)
        if best:
            o=cells[best[1]]; o['poly']=best[2]; o['raw']=unary_union([o['raw'],c['raw']]); removed.add(ci); touched|={ci,best[1]}
    cells=[c for i,c in enumerate(cells) if i not in removed]
    return len(removed)
for _ in range(4):
    if not remerge(): break
# leftover slivers wedged against a city (e.g. the coastal strip north-east of Kratsna) join that city province
for c in [c for c in cells if c['kind']=='cell' and bbm(c['poly'])<MINF]:
    cs=[o for o in cells if o['kind']=='city' and o['region']==c['region'] and o['poly'].distance(c['poly'])<90]
    if not cs: continue
    o=min(cs,key=lambda o:o['poly'].distance(c['poly']))
    U=unary_union([o['poly'],c['poly'],o['poly'].buffer(75).intersection(c['poly'].buffer(75)).intersection(ZONEV)])
    others=unary_union([q['poly'].buffer(64) for q in cells if q is not o and q is not c and q['poly'].distance(U)<200])
    U=biggest(U.difference(others).buffer(-3).buffer(3))
    if bbm(U)<=FIN:
        o['poly']=U; o['raw']=unary_union([o['raw'],c['raw']]); o['note']+=' + adjacent coastal strip'; c['drop']=True
        print('sliver merged into city',o['city'],int(bbm(U)))
cells=[c for c in cells if not c.get('drop')]
def fillholes():
    n=0
    cov=unary_union([c['poly'] for c in cells]).buffer(70)
    Hh=ZONEV.difference(cov)
    for h in (getattr(Hh,'geoms',[Hh])):
        if h.area<10000: continue
        hp=h.buffer(70).intersection(ZONEV); best=None
        for c in cells:
            if c['kind']!='cell' or c['poly'].distance(h)>120: continue
            U=unary_union([c['poly'],hp.difference(unary_union([o['poly'].buffer(64) for o in cells if o is not c and o['poly'].distance(h)<300]))])
            U=biggest(U.buffer(20).buffer(-20))
            if bbm(U)<=FIN and (best is None or U.area<best[0]): best=(U.area,c,U)
        if best: best[1]['poly']=best[2]; best[1]['raw']=unary_union([best[1]['raw'],h]); n+=1
    return n
for _ in range(3):
    k=fillholes(); print('holes filled',k)
    if not k: break
lb=[bbm(c['poly']) for c in cells if c['kind']=='cell']
print('undersized',[(c['region'],int(bbm(c['poly'])),[int(v) for v in c['poly'].centroid.coords[0]]) for c in cells if c['kind']=='cell' and bbm(c['poly'])<MINF])
print({r:sum(1 for c in cells if c['region']==r) for r in ['Zille','Brenas','Wehlen']},'cell bbox min/med/max',int(min(lb)),int(np.median(lb)),int(max(lb)),'under',MINF,sum(1 for v in lb if v<MINF))
# ---------- sea: whole Isor-Kratsna channel incl. Port Rotsla + Munat-cape lane to Mave Nortus ----------
RIZ=[p for p in dd['Ld'].geoms if p.contains(Point(7800,4000))][0]
CW=700
winA=Polygon([(10950,4250),(10950,1300),(9600,600),(8400,276),(8400,1900),(8600,1900),(9500,2300),(10100,3400),(10300,4250)])
bandA=RIZ.buffer(CW).intersection(winA)        # east lane: Munat cape -> Mave Nortus / northern Brenas link
CH=Polygon([(4450,3800),(5150,4250),(6400,4300),(7700,4050),(7700,2300),(8150,1900),(8500,1650),(8500,276),(5000,276),(5000,3000)])
SEA0=FRAME.difference(LAND.buffer(5))
SZ=unary_union([bandA,CH]).intersection(SEA0)
parts=sorted(getattr(SZ,'geoms',[SZ]),key=lambda q:-q.area)
SZ=unary_union([q for q in parts if q.area>150000]).buffer(-4).buffer(4)
# angular, irregular outer edge on the open-water side of the east lane only (channel is coast-to-coast)
print('sea area %.2fM parts'%(SZ.area/1e6),[int(q.area) for q in parts[:5]])
def vor(pts):
    V=voronoi_diagram(MultiPoint([Point(*p) for p in pts]),envelope=box(0,0,12288,8192)); out=[]
    for p in pts:
        q=Point(*p); v=[g for g in V.geoms if g.contains(q)]
        out.append(v[0].intersection(SZ) if v else Polygon())
    return out
srng=np.random.default_rng(int(sys.argv[3]) if len(sys.argv)>3 else 77)
NSA=float(sys.argv[4]) if len(sys.argv)>4 else 430000
nS=max(6,int(round(SZ.area/NSA)))
def sample_in(g,n):
    x0,y0,x1,y1=g.bounds; out=[]
    while len(out)<n:
        p=Point(srng.uniform(x0,x1),srng.uniform(y0,y1))
        if g.contains(p): out.append(np.array([p.x,p.y]))
    return out
LIMS=LIMR+20; MINS=MINR-20
sp=sample_in(SZ,nS)
for it in range(80):
    for _ in range(4):
        vs=vor(sp); sp=[np.array(biggest(v).centroid.coords[0]) if not v.is_empty else p for v,p in zip(vs,sp)]
    vs=[biggest(v) if not v.is_empty else v for v in vor(sp)]
    over=[i for i,v in enumerate(vs) if not v.is_empty and bbm(v)>LIMS]
    if not over: break
    i=max(over,key=lambda i:bbm(vs[i])); v=vs[i]
    pts=np.array(v.exterior.coords); c=np.array(v.centroid.coords[0]); far=pts[np.argmax(((pts-c)**2).sum(1))]
    sp[i]=c+(c-far)*0.35; sp.append(c+(far-c)*0.55)
tp('sea seeds',len(sp),'iters',it)
V=vor(sp); vs=[]
for v in V:   # voronoi cell may split into several parts around islands/capes: keep parts, small ones merge below
    for q in getattr(v,'geoms',[v]):
        if q.geom_type=='Polygon' and q.area>500: vs.append(q)
for _ in range(200):
    vs.sort(key=lambda g:bbm(g)); done=False
    for i,g in enumerate(vs):
        if bbm(g)>=MINS: break
        best=None
        for j,h2 in enumerate(vs):
            if j==i or g.distance(h2)>1: continue
            u=unary_union([g,h2]).buffer(0.5).buffer(-0.5)
            if u.geom_type=='Polygon' and bbm(u)<=LIMS:
                sh=g.buffer(1).intersection(h2.buffer(1)).area
                cost=bbm(u)-0.3*sh**0.5
                if best is None or cost<best[0]: best=(cost,j,u)
        if best: vs[best[1]]=best[2]; vs.pop(i); done=True; break
    if not done: break
sea=[]
for v in vs:
    g=v.buffer(-32,join_style=2,mitre_limit=3).simplify(8)
    g=biggest(g) if not g.is_empty else g
    if g.is_empty or g.area<20000: continue
    if bbm(g)>FIN: g=boxclip(g,FIN)
    sea.append(dict(region='Sea',type='sea',kind='sea',raw=v,poly=g))
sb=[bbm(s['poly']) for s in sea]
print('sea cells',len(sea),'bbox min/med/max',int(min(sb)),int(np.median(sb)),int(max(sb)),'under',MINF,sum(1 for v in sb if v<MINF))
CI=pickle.load(open('work/cities6.pkl','rb'))
SETT=[(n,np.array(c,float),t) for n,c,_,t in CI['MAJ']]+[(n,np.array(c,float),t) for n,c,_,t,_ in CI['INV']]
SETT+=[(n,np.array(URB[n].centroid.coords[0]),'resort_town') for n in ['Lido Isora','Sabbiano','Vela Nova','Rivamare','Praia Velha','Marbelas'] if n not in [s[0] for s in SETT]]
pickle.dump(dict(land=cells,sea=sea,SZ=SZ,ZONEV=ZONEV,SETT=SETT,city=city,zones=zones),open('work/prov9_stage2.pkl','wb'))
print('total',len(cells)+len(sea))
