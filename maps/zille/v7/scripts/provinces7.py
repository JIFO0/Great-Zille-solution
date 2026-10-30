"""v7 provinces: organic feature-following land cells (compact watershed on relief+rivers+roads+noise, variable-density seeds),
8 urban-shaped city provinces, smooth inland zone edges, irregular angular sea corridor (Voronoi). -> work/prov7_stage2.pkl"""
import numpy as np, pickle, sys, io, cairosvg, time
T0=time.time()
def tp(*a): print('[%.0fs]'%(time.time()-T0),*a,flush=True)
exec(open('provinces6.py').read().split("Zz=(pen|")[0])          # masks, helpers (G, LAND, LIN, pen/ol/we, d_pen, d_ch, ISL, label_polys...)
from skimage.segmentation import watershed
from shapely.geometry import LineString
from shapely.strtree import STRtree
from PIL import Image
Image.MAX_IMAGE_PIXELS=None
LIM=466          # raw cell bbox limit (final shapes are clipped to 454 -> rendered <=508)
GAP=34
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
# ---------- city provinces (8, urban-shaped) ----------
CITY8={'Zille':('Zille',(7835,6000)),'Wiktrany':('Zille',None),'Mave Nortus':('Zille',None),'Nanta':('Zille',None),'Isor':('Zille',None),
       'Munat':('Zille',None),'Dapalle':('Brenas',None),'Kratsna':('Wehlen',None)}
def bbm(g): b=g.bounds; return max(b[2]-b[0],b[3]-b[1])
city={}
for n,(rg,hub) in CITY8.items():
    U=URB[n]; note=''
    m=40
    while True:
        g=biggest(sm(U.buffer(m,join_style=1),25).intersection(LIN))
        if bbm(g)<=454 or m<=8: break
        m-=4
    if bbm(g)>454:
        m=30; full=sm(U.buffer(m,join_style=1),25).intersection(LIN)
        for k in range(40,320,20):     # morphological opening strips the sprawl arms, keeping the core's own outline
            gk=U.buffer(-k).buffer(k+m).intersection(full)
            if gk.is_empty: break
            g=biggest(gk)
            if bbm(g)<=454: note=f'core urban outline (opening {k}px, urban bbox {int(bbm(U))})'; break
            note=f'core urban outline (opening {k}px, urban bbox {int(bbm(U))})'
        if bbm(g)>454:
            c=hub or g.centroid.coords[0]
            g=biggest(g.intersection(Point(*c).buffer(227)).buffer(-6).buffer(6)); note+=' + clip r227'
    city[n]=dict(region=rg,poly=g,margin=m,note=note)
    print('city',n,'margin',m,'bbox',[round(v) for v in (g.bounds[2]-g.bounds[0],g.bounds[3]-g.bounds[1])],note)
allcity=unary_union([v['poly'] for v in city.values()])
cityblock=rast(allcity.buffer(GAP))
# ---------- zones with smooth inland edges ----------
low=fbm((H,W),3,2,np.random.default_rng(31))
Db7=np.clip(320+150*low,240,480)
Dw7=np.clip(np.interp(Y,[600,1500,2600,3600],[950,850,650,520])+220*low,450,1050)
def smooth_mask(m,s=4): return ndi.gaussian_filter(m.astype(float),s)>0.5
islm=np.zeros((H,W),bool)
for nm,(rg,g) in ISL.items(): islm|=rast(g.buffer(30))
Bz=smooth_mask(ol&(d_pen<Db7))&ol
Wz=smooth_mask(we&(d_ch<Dw7))&we
Wz&=~((Y>3820)&(X<4050))      # the thin coastal sliver south of Brannitz towards Yol is left out of the zone
Zz=pen
# vector outer zone polygons (smooth inland edge; coast comes from LIN)
def zone_poly(m):
    g=mask_poly(ndi.binary_opening(m,iterations=2),(0,0),sig=2.5)
    return g.buffer(-50,join_style=1).buffer(50,join_style=1).simplify(3)
OUT_R=zone_poly(Zz|Bz)    # Rizia: peninsula + northern Brenas
OUT_W=zone_poly(Wz)
OUTER=unary_union([OUT_R,OUT_W]).intersection(FRAME)
landm2=rast(LIN.intersection(OUTER))
zones={'Zille':Zz&landm2&~cityblock&~islm,'Brenas':Bz&landm2&~cityblock&~islm,'Wehlen':Wz&landm2&~cityblock&~islm}
# ---------- seeds: variable-density Poisson ----------
def poisson(zone,rmin,rmax,seed):
    r=np.random.default_rng(seed); ys,xs=np.nonzero(zone); idx=r.permutation(len(ys))
    rad=lambda x,y: rmin+(rmax-rmin)*(noise2[int(y/G),int(x/G)]+1)/2
    acc=[]; cell=rmin/1.5; hsh={}
    for i in idx[:25000]:
        x,y=(xs[i]+r.random())*G,(ys[i]+r.random())*G; rr=rad(x,y); ok=True
        cx,cy=int(x//cell),int(y//cell); k=int(np.ceil(rmax/cell))
        for dx in range(-k,k+1):
            for dy in range(-k,k+1):
                for (px,py) in hsh.get((cx+dx,cy+dy),()):
                    if (px-x)**2+(py-y)**2<rr*rr: ok=False; break
                if not ok: break
            if not ok: break
        if ok: acc.append((x,y)); hsh.setdefault((cx,cy),[]).append((x,y))
    return [np.array(p) for p in acc]
def pix_bb(m):
    ys,xs=np.nonzero(m); return (xs.max()-xs.min()+1)*G,(ys.max()-ys.min()+1)*G
def ws(zone,seeds,comp):
    mk=np.zeros((H,W),np.int32)
    for i,p in enumerate(seeds):
        gy,gx=min(int(p[1]/G),H-1),min(int(p[0]/G),W-1)
        if not zone[gy,gx]:
            ys,xs=np.nonzero(zone[max(gy-30,0):gy+30,max(gx-30,0):gx+30])
            if not len(ys): continue
            j=np.argmin((ys+max(gy-30,0)-gy)**2+(xs+max(gx-30,0)-gx)**2); gy,gx=ys[j]+max(gy-30,0),xs[j]+max(gx-30,0)
        mk[gy,gx]=i+1
    return watershed(E,mk,mask=zone,compactness=comp)
def cassign(ys,xs,pw,S,hb):
    k=min(12,len(S)); d,idx=cKDTree(S).query(pw,k=k); idx=idx.reshape(len(pw),-1)
    px=(xs+0.5)*G; py=(ys+0.5)*G
    ok=(np.abs(S[idx][:,:,0]-px[:,None])<=hb)&(np.abs(S[idx][:,:,1]-py[:,None])<=hb)
    first=np.argmax(ok,1); has=ok.any(1)
    return np.where(has,idx[np.arange(len(pw)),first],-1)
def region_cells(name,zone,rmin,rmax,seed,comp=0.01):
    seeds=poisson(zone,rmin,rmax,seed)
    hb=LIM/2-8
    for outer in range(8):
        for it in range(NLLOYD):
            L=ws(zone,seeds,comp)
            cm=ndi.center_of_mass(np.ones_like(L),L,range(1,len(seeds)+1))
            seeds=[np.array([(cx+.5)*G,(cy+.5)*G]) if np.isfinite(cx) else s0 for (cy,cx),s0 in zip(cm,seeds)]
            un=zone&(L==0); lab,n=ndi.label(un)
            for i,sl in enumerate(ndi.find_objects(lab)):
                m=lab[sl]==i+1
                if m.sum()*G*G>6000:
                    yy,xx=np.nonzero(m); j=len(yy)//2; seeds.append(np.array([(xx[j]+sl[1].start+.5)*G,(yy[j]+sl[0].start+.5)*G]))
        L=ws(zone,seeds,comp); S=np.array(seeds)
        ys,xs=np.nonzero(L>0); lab=L[ys,xs]-1; px=(xs+0.5)*G; py=(ys+0.5)*G
        viol=(np.abs(S[lab,0]-px)>hb)|(np.abs(S[lab,1]-py)>hb)
        na=np.zeros(0,int)
        if viol.any():
            pw=np.stack([wx[ys[viol],xs[viol]],wy[ys[viol],xs[viol]]],1)
            na=cassign(ys[viol],xs[viol],pw,S,hb)
            lab2=lab.copy(); vi=np.flatnonzero(viol); lab2[vi[na>=0]]=na[na>=0]; L[ys,xs]=lab2+1
            bad=np.zeros((H,W),bool); bad[ys[vi[na<0]],xs[vi[na<0]]]=True
            bl,bn=ndi.label(bad,structure=np.ones((3,3)))
            for i,sl in enumerate(ndi.find_objects(bl)):
                yy,xx=np.nonzero(bl[sl]==i+1)
                if len(yy)*G*G<1500: continue
                j=len(yy)//2; seeds.append(np.array([(xx[j]+sl[1].start+.5)*G,(yy[j]+sl[0].start+.5)*G]))
        nbad=int((na<0).sum())
        tp('  ',name,'outer',outer,'seeds',len(seeds),'unassignable',nbad)
        if nbad*G*G<1500*3: break
    L=fix_conn(L)
    return L,seeds
def merge_small(L,minA,lim):
    L=L.copy()
    for rnd in range(40):
        objs=ndi.find_objects(L); cnt=np.bincount(L.ravel())*G*G; mg=0; touched=set()
        for k in sorted([i+1 for i,s in enumerate(objs) if s is not None and 0<cnt[i+1]<minA],key=lambda k:cnt[k]):
            if k in touched: continue
            sl=objs[k-1]; sl2=(slice(max(sl[0].start-2,0),sl[0].stop+2),slice(max(sl[1].start-2,0),sl[1].stop+2))
            sub=L[sl2]; m=sub==k; ring=ndi.binary_dilation(m)&~m; nb=sub[ring]; nb=nb[(nb>0)&(nb!=k)]
            best=None
            for j,cn in zip(*np.unique(nb,return_counts=True)):
                if j in touched: continue
                sj=objs[j-1]; y0=min(sl[0].start,sj[0].start); y1=max(sl[0].stop,sj[0].stop); x0=min(sl[1].start,sj[1].start); x1=max(sl[1].stop,sj[1].stop)
                if max(y1-y0,x1-x0)*G<=lim:
                    sc=cn/np.sqrt(cnt[j]+cnt[k])
                    if best is None or sc>best[0]: best=(sc,j)
            if best: L[L==k]=best[1]; touched|={k,best[1]}; mg+=1
        if not mg: break
    return L
RA=float(sys.argv[6]) if len(sys.argv)>6 else 300
RB=float(sys.argv[7]) if len(sys.argv)>7 else 380
NLLOYD=int(sys.argv[4]) if len(sys.argv)>4 else 6
COMP=float(sys.argv[5]) if len(sys.argv)>5 else 0.05
RP=dict(Zille=(RA,RB),Brenas=(RA,RB),Wehlen=(RA,RB+5))
cells=[]
Lc=np.zeros((H,W),np.int32); lreg={}; nxt=1
for k,(name,z) in enumerate(zones.items()):
    L,seeds=region_cells(name,z,*RP[name],seed=100+k,comp=COMP)
    L=merge_small(L,90000,LIM)
    cnt=np.bincount(L.ravel())*G*G
    # crumbs: tiny disconnected bits (< 8k) are dropped from the zone (reported), the rest kept
    for i,sl in enumerate(ndi.find_objects(L)):
        if sl is None: continue
        m=L[sl]==i+1
        lab,n=ndi.label(m)
        if n>1:
            sz=ndi.sum(m,lab,range(1,n+1)); keep=np.argmax(sz)+1
            sub=L[sl]; sub[(lab!=keep)&m]=0
    for i,sl in enumerate(ndi.find_objects(L)):
        if sl is None: continue
        m=L[sl]==i+1
        if not m.any(): continue
        sub=Lc[sl]; sub[m]=nxt; lreg[nxt]=name; nxt+=1
    tp(name,'cells',len(np.unique(L))-1)
# orphan pieces (removed fragments) -> nearest same-region label if adjacent
for name,z in zones.items():
    orph=z&(Lc==0); lab,n=ndi.label(orph)
    for i,sl in enumerate(ndi.find_objects(lab)):
        sl2=(slice(max(sl[0].start-2,0),sl[0].stop+2),slice(max(sl[1].start-2,0),sl[1].stop+2))
        m=lab[sl2]==i+1; ring=ndi.binary_dilation(m)&~m; nb=Lc[sl2][ring]; nb=nb[nb>0]
        nb=[q for q in nb if lreg[q]==name]
        if nb: sub=Lc[sl2]; sub[m]=np.bincount(nb).argmax()
Lc=merge_small(Lc,90000,LIM)   # second pass over the combined grid (same-region check below)
P=label_polys(Lc)
for k,p in P.items():
    if p.is_empty: continue
    rgs=lreg[k]
    cells.append(dict(region=rgs,raw=p,kind='cell'))
# islands
for nm,(rg,g) in ISL.items():
    gi=biggest(g.buffer(-14))
    if nm=='Manes Riuz':
        x0,y0,x1,y1=gi.bounds; xm=(x0+x1)/2
        # split along a slanted line for a less regular look
        cut=Polygon([(xm-60,y0-50),(xm+60,y1+50),(x1+50,y1+50),(x1+50,y0-50)])
        for part,q in [('West',gi.difference(cut.buffer(17))),('East',gi.intersection(cut).difference(cut.exterior.buffer(17)))]:
            cells.append(dict(region=rg,raw=biggest(q),kind='island',island=nm,fixed=True,name=f'{nm} {part}'))
    else:
        cells.append(dict(region=rg,raw=boxclip(gi,454),kind='island',island=nm,fixed=True,name=nm))
for n,v in city.items():
    cells.append(dict(region=v['region'],raw=v['poly'],kind='city',city=n,fixed=True,name=n,note=v['note']))
# ---------- vector gaps + smooth outer edge ----------
tp('raster done')
if len(sys.argv)>3 and sys.argv[3]=='diag':
    pickle.dump(dict(Lc=Lc,lreg=lreg),open('work/prov7_diag.pkl','wb')); sys.exit()
ZONEV=LIN.intersection(OUTER)
raws=[c['raw'] for c in cells]; tree=STRtree(raws)
for i,c in enumerate(cells):
    p=c['raw']
    if c.get('fixed'): g=p
    else:
        base=p.buffer(40,join_style=1).intersection(ZONEV)
        near=[j for j in tree.query(p.buffer(80)) if j!=i]
        cut=unary_union([cells[j]['raw'].buffer(34 if cells[j]['kind']!='cell' else 17) for j in near]) if near else Polygon()
        g=base.difference(cut)
        g0=g
        for rr in (24,14,7,0):
            go=g0.buffer(-rr,join_style=1).buffer(rr,join_style=1) if rr else g0
            if not go.is_empty and biggest(go).area>=0.985*biggest(g0).area-1200: g=go; break
    g=biggest(g)
    if bbm(g)>454: g=boxclip(g,454)
    c['poly']=g; c['type']='land'
# tiny final polys: merge into neighbour (raw union) if fits, else keep
def remerge():
    global cells
    polys=[c['poly'] for c in cells]; tr=STRtree(polys); removed=set(); touched=set()
    for ci in sorted([i for i,c in enumerate(cells) if c['kind']=='cell' and c['poly'].area<75000],key=lambda i:cells[i]['poly'].area):
        if ci in touched: continue
        c=cells[ci]; best=None
        for oi in tr.query(c['poly'].buffer(45)):
            o=cells[oi]
            if oi==ci or oi in touched or o['kind']!='cell' or o['region']!=c['region'] or o['poly'].distance(c['poly'])>45: continue
            U=unary_union([o['poly'],c['poly'],o['poly'].buffer(40).intersection(c['poly'].buffer(40)).intersection(ZONEV)])
            if bbm(U)>454: continue
            near=[q for q in tr.query(U.buffer(120)) if q not in (oi,ci) and q not in removed]
            others=unary_union([cells[q]['poly'].buffer(34) for q in near])
            U=biggest(U.difference(others).buffer(-3).buffer(3))
            if bbm(U)<=454 and U.area>o['poly'].area+0.7*c['poly'].area:
                if best is None or U.area<best[0]: best=(U.area,oi,U)
        if best:
            o=cells[best[1]]; o['poly']=best[2]; o['raw']=unary_union([o['raw'],c['raw']]); removed.add(ci); touched|={ci,best[1]}
    cells=[c for i,c in enumerate(cells) if i not in removed]
    return len(removed)
tp('gaps done')
for _ in range(3):
    if not remerge(): break
tp('remerge done')
print({r:sum(1 for c in cells if c['region']==r) for r in ['Zille','Brenas','Wehlen']},'cities',sum(1 for c in cells if c['kind']=='city'),'small<60k',sum(1 for c in cells if c['kind']=='cell' and c['poly'].area<60000))
# ---------- sea corridor ----------
CR=float(sys.argv[2]) if len(sys.argv)>2 else 260
RIZ=[p for p in dd['Ld'].geoms if p.contains(Point(7800,4000))][0]
WEH=[p for p in dd['Ld'].geoms if p.contains(Point(3000,1500))][0]
ROT=ISL['Rotsla'][1]
# A: along Rizia's north / north-west coast from Munat to Isor (hugging the coast)
bandA=RIZ.buffer(2*CR).intersection(Polygon([(8550,1350),(8550,1800),(7600,2700),(7250,3500),(6650,3650),(6650,2400),(7600,1350)]))
# B: crossing from the Munat coast to Kratsna, widening along the Wehlen coast at Kratsna
L1=LineString([(8300,1450),(7600,1150),(6900,850),(6250,620)])
bandB=unary_union([L1.buffer(CR),WEH.buffer(2*CR).intersection(box(5400,276,6500,1250))])
# C: Isor to the port of Rotsla, wrapping Rotsla
L2=LineString([(6800,3450),(6250,3600),(5650,3760)])
bandC=unary_union([L2.buffer(CR),ROT.buffer(1.4*CR)])
COR=unary_union([bandA,bandB,bandC]).buffer(120,join_style=2).buffer(-120,join_style=2).simplify(110)
SZ=COR.intersection(FRAME).difference(LAND.buffer(20))
SZ=biggest(SZ).buffer(-4).buffer(4)
def vor(pts):
    V=voronoi_diagram(MultiPoint([Point(*p) for p in pts]),envelope=box(0,0,12288,8192)); out=[]
    for p in pts:
        q=Point(*p); v=[g for g in V.geoms if g.contains(q)]
        out.append(v[0].intersection(SZ) if v else Polygon())
    return out
srng=np.random.default_rng(77)
NSA=float(sys.argv[8]) if len(sys.argv)>8 else 140000
NLS=int(sys.argv[9]) if len(sys.argv)>9 else 5
nS=max(6,int(round(SZ.area/NSA)))
def sample_in(g,n):
    x0,y0,x1,y1=g.bounds; out=[]
    while len(out)<n:
        p=Point(srng.uniform(x0,x1),srng.uniform(y0,y1))
        if g.contains(p): out.append(np.array([p.x,p.y]))
    return out
sp=sample_in(SZ,nS)
for it in range(60):
    for _ in range(NLS):   # light Lloyd: irregular but not degenerate
        vs=vor(sp); sp=[np.array(biggest(v).centroid.coords[0]) if not v.is_empty else p for v,p in zip(vs,sp)]
    vs=[biggest(v) if not v.is_empty else v for v in vor(sp)]
    over=[i for i,v in enumerate(vs) if not v.is_empty and bbm(v)>LIM+20]
    if not over: break
    i=max(over,key=lambda i:bbm(vs[i])); v=vs[i]
    pts=np.array(v.exterior.coords); c=np.array(v.centroid.coords[0]); far=pts[np.argmax(((pts-c)**2).sum(1))]
    sp[i]=c+(c-far)*0.35; sp.append(c+(far-c)*0.55)
tp('sea seeds',len(sp),'iters',it)
vs=[biggest(v) for v in vor(sp) if not v.is_empty]
for _ in range(30):
    vs.sort(key=lambda g:g.area); done=False
    for i,g in enumerate(vs):
        if g.area>=90000: break
        best=None
        for j,h2 in enumerate(vs):
            if j==i or g.distance(h2)>1: continue
            u=unary_union([g,h2])
            if u.geom_type=='Polygon' and bbm(u)<=LIM+20:
                sh=g.intersection(h2.buffer(1)).area
                if best is None or sh>best[0]: best=(sh,j,u)
        if best: vs[best[1]]=best[2]; vs.pop(i); done=True; break
    if not done: break
sea=[]
for v in vs:
    g=v.buffer(-17,join_style=2,mitre_limit=3).simplify(6)
    g=biggest(g) if not g.is_empty else g
    if g.is_empty or g.area<8000: continue
    if bbm(g)>454: g=boxclip(g,454)
    sea.append(dict(region='Sea',type='sea',kind='sea',raw=v,poly=g))
print('sea corridor area %.2fM'%(SZ.area/1e6),'sea cells',len(sea),'smallest',int(min(s['poly'].area for s in sea)),'max bb',int(max(bbm(s['poly']) for s in sea)))
CI=pickle.load(open('work/cities6.pkl','rb'))
SETT=[(n,np.array(c,float),t) for n,c,_,t in CI['MAJ']]+[(n,np.array(c,float),t) for n,c,_,t,_ in CI['INV']]
SETT+=[(n,np.array(URB[n].centroid.coords[0]),'resort_town') for n in ['Lido Isora','Sabbiano','Vela Nova','Rivamare','Praia Velha','Marbelas'] if n not in [s[0] for s in SETT]]
pickle.dump(dict(land=cells,sea=sea,SZ=SZ,ZONEV=ZONEV,SETT=SETT,city=city,zones=zones),open('work/prov7_stage2.pkl','wb'))
print('total',len(cells)+len(sea))
