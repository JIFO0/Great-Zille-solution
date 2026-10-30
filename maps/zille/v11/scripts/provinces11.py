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



# ======================= v11: fix round on top of v10 (ids stay stable) =======================
FIN=860; MINF=520
def bbm(g): b=g.bounds; return max(b[2]-b[0],b[3]-b[1])
F10=pickle.load(open('work/prov10_final.pkl','rb')); S10=pickle.load(open('work/prov10_stage2.pkl','rb'))
ZONEV=S10['ZONEV']; SETT=S10['SETT']
allp=F10['allp']
cells=[c for c in allp if c['type']=='land']; sea=[c for c in allp if c['type']=='sea']
GZ=pickle.load(open('work/v11base/grodzizg.pkl','rb'))
URB['Grodzizg']=GZ['area']
rdm=ndi.binary_dilation(rds>0.25,iterations=3)
LIN8m=rast(LIN8)

USE_ROADS=False
SEP=95; RK0=0.27; RK1=0.33; AW=0.78
def road_arms(c,R,w):
    m=rdm&(np.hypot(X-c[0],Y-c[1])<R)
    lab,k=ndi.label(m)
    if k==0: return Polygon()
    cy,cx=int(c[1]/G),int(c[0]/G); win=lab[max(cy-12,0):cy+12,max(cx-12,0):cx+12]; ids=set(np.unique(win))-{0}
    if not ids: return Polygon()
    g=mask_poly(np.isin(lab,list(ids)),(0,0),sig=1.0)
    return g.buffer(w,join_style=1) if not g.is_empty else g

def blobpoly(cx,cy,r,rr):
    a,b,c2=rr.uniform(0,2*np.pi,3); t=np.linspace(0,2*np.pi,72,endpoint=False)
    rad=r*(1+0.22*np.sin(2*t+a)+0.14*np.sin(3*t+b)+0.08*np.sin(5*t+c2))
    return Polygon(np.stack([cx+rad*np.cos(t),cy+rad*np.sin(t)],1))
def landfrac(c,a,L):
    pts=[Point(c[0]+L*f*np.cos(a),c[1]+L*f*np.sin(a)) for f in np.linspace(0.15,1,8)]
    return np.mean([LIN8.contains(p) for p in pts])
def roadfrac(c,a,L):
    v=[]
    for f in np.linspace(0.15,1,10):
        x,y=c[0]+L*f*np.cos(a),c[1]+L*f*np.sin(a); gy,gx=int(y/G),int(x/G)
        v.append(rdm[max(gy-3,0):gy+4,max(gx-3,0):gx+4].any() if 0<=gy<H and 0<=gx<W else False)
    return np.mean(v)
def petals(n,tgt):
    U=URB[n]; c=np.array(U.centroid.coords[0]); rr=np.random.default_rng(sum(map(ord,n))*7)
    angs=np.radians(np.arange(0,360,10)); sc0=tgt*0.55
    score=np.array([landfrac(c,a,sc0)+0.6*roadfrac(c,a,sc0) for a in angs])+rr.uniform(0,0.15,len(angs))
    chosen=[]
    for i in np.argsort(-score):
        if score[i]<0.55: break
        if all(abs((angs[i]-angs[j]+np.pi)%(2*np.pi)-np.pi)>np.radians(SEP) for j in chosen): chosen.append(i)
        if len(chosen)==3: break
    ang=angs[chosen]; nL=len(ang)
    dk=rr.uniform(0.62,0.85,nL); rk=rr.uniform(RK0,RK1,nL); seeds=[np.random.default_rng(int(1000*k)+sum(map(ord,n))) for k in range(nL)]
    best=None
    for sc in range(120,900,10):
        parts=[U.buffer(0.20*sc,join_style=1)]
        for a,d,r,sd in zip(ang,dk,rk,seeds):
            sd=np.random.default_rng(sd.bit_generator.state['state']['state']%2**32)
            ex,ey=c[0]+sc*d*np.cos(a),c[1]+sc*d*np.sin(a)
            parts.append(LineString([tuple(c),(ex,ey)]).buffer(sc*r*AW))
            parts.append(blobpoly(ex,ey,sc*r,sd))
        if USE_ROADS: parts.append(road_arms(c,sc*0.9,0.08*sc))
        g=unary_union(parts).buffer(0.04*sc,join_style=1).buffer(-0.06*sc,join_style=1).buffer(0.02*sc,join_style=1)
        g=g.intersection(LIN8)
        if g.is_empty: continue
        g=[q for q in getattr(g,'geoms',[g]) if q.geom_type=='Polygon']
        g=max(g,key=lambda q:q.intersection(U.buffer(40)).area)
        g=biggest(g.buffer(-10,join_style=1).buffer(10,join_style=1))
        if bbm(g)>FIN: break
        best=(sc,g)
        if bbm(g)>=tgt: break
    return best


rdm|=rast(GZ['road'].buffer(12))     # the new Grodzizg-Brannitz road steers the city lobes
# ---------- Grodzizg: new city province on the site of ZilleTile_94 (id reused) ----------
c94=[c for c in cells if c['id']=='ZilleTile_94'][0]
old94=c94['poly']; print('old 94',c94['name'],c94['region'],int(bbm(old94)))
best=petals('Grodzizg',600); sc,G94=best
G94=biggest(G94.intersection(ZONEV))
c94.update(kind='city',city='Grodzizg',name='Grodzizg',fixed=True,poly=G94,raw=G94,note=f'urban outline + coast + road-directed lobes (sc={sc})')
b=G94.bounds; print('Grodzizg bbox',int(b[2]-b[0]),int(b[3]-b[1]),'fill %.2f'%(G94.area/((b[2]-b[0])*(b[3]-b[1]))))
# neighbours regrow into the rest of old 94 (watershed on the same relief/river/road energy), 64 px gaps
def local_repartition(C,old):
    N=[c for c in cells if c['kind']=='cell' and c['region']==c94['region'] and c['poly'].distance(old)<100]
    rest=[c for c in cells if c not in N and c is not c94]
    R=unary_union([c['poly'].buffer(40) for c in N]+[old.buffer(40)]).intersection(ZONEV)
    R=R.difference(C.buffer(64,join_style=1)).difference(unary_union([o['poly'].buffer(64) for o in rest if o['poly'].distance(R)<100]))
    m=rast(R); mk=np.zeros((H,W),np.int32)
    for i,c in enumerate(N):
        g=c['poly'].difference(C.buffer(100)); g=biggest(g) if not g.is_empty else c['poly']
        core=rast(g.buffer(-60)) if not g.buffer(-60).is_empty else rast(g)
        mk[core&m]=i+1
    Lw=fix_conn(watershed(E,mk,mask=m,compactness=0.02))
    print('R area %.0f mask px %d labelled %d markers'%(R.area,m.sum(),(Lw>0).sum()),[int((mk==i+1).sum()) for i in range(len(N))])
    newp=[]
    for i,c in enumerate(N):
        g=mask_poly(Lw==i+1,(0,0),sig=1.6).intersection(R).buffer(-32,join_style=1)
        g=biggest(g.buffer(-20,join_style=1).buffer(20,join_style=1)) if not g.is_empty else g
        newp.append(g)
    ok=all((not g.is_empty) and MINF<=bbm(g)<=FIN for g in newp)
    print('repartition around Grodzizg:',[(c['id'],int(bbm(c['poly'])),int(bbm(g)) if not g.is_empty else 0) for c,g in zip(N,newp)],'ok' if ok else 'REJECTED')
    if ok:
        for c,g in zip(N,newp): c['poly']=g; c['raw']=g
    return ok
ok=local_repartition(G94,old94)
def fillholes():
    n=0
    cov=unary_union([c['poly'] for c in cells]).buffer(70)
    Hh=ZONEV.difference(cov)
    for h in getattr(Hh,'geoms',[Hh]):
        if h.area<8000: continue
        hp=h.buffer(70).intersection(ZONEV); best=None
        for c in cells:
            if c['kind']!='cell' or c['poly'].distance(h)>140: continue
            U=unary_union([c['poly'],hp.difference(unary_union([o['poly'].buffer(64) for o in cells if o is not c and o['poly'].distance(h)<400]))])
            U=biggest(U.buffer(20).buffer(-20))
            if bbm(U)<=FIN and (best is None or U.area<best[0]): best=(U.area,c,U)
        if best: best[1]['poly']=best[2]; best[1]['raw']=unary_union([best[1]['raw'],h]); n+=1
    return n
for _ in range(3):
    k=fillholes(); print('holes filled',k)
    if not k: break
for _ in range(3):
    k=fillholes(); print('holes filled',k)
    if not k: break
# pockets of old 94 that the neighbours could not reach (the headland east of the port) join the Grodzizg province
for it in range(3):
    cov=unary_union([c['poly'] for c in cells]).buffer(36)
    Hh=ZONEV.difference(cov).intersection(old94.buffer(60))
    pk=[h for h in getattr(Hh,'geoms',[Hh]) if h.geom_type=='Polygon' and h.area>2500]
    if not pk: break
    for h in pk:
        others=unary_union([o['poly'].buffer(64) for o in cells if o is not c94 and o['poly'].distance(h)<400])
        U=unary_union([c94['poly'],h.buffer(40).intersection(ZONEV).difference(others)])
        U=U.buffer(40,join_style=1).buffer(-40,join_style=1).intersection(ZONEV).difference(others)
        U=biggest(U.buffer(-6).buffer(6))
        if bbm(U)<=FIN and U.area>c94['poly'].area: c94['poly']=U; c94['raw']=U; print('pocket joined Grodzizg',int(h.area),'-> bbox',int(bbm(U)))
cov=unary_union([c['poly'] for c in cells]).buffer(70); left=ZONEV.difference(cov).intersection(old94.buffer(80))
print('uncovered rest of old 94: %.0f px2'%left.area)
# ---------- sea: the Yol bay (between Brannitz, Yol and the Grodzizg shore) ----------
SEA0=FRAME.difference(LAND.buffer(5))
S38=[x for x in sea if x['id']=='ZilleTile_S38'][0]
KEEPR=unary_union([x['raw'] for x in sea if x is not S38])
BAY=Polygon([(3820,3330),(4250,3330),(4560,3600),(4700,3780),(4500,3880),(3820,3900)])
SZ_B=unary_union([BAY.intersection(SEA0),S38['raw']]).difference(KEEPR.buffer(0.5))
parts=[q for q in getattr(SZ_B,'geoms',[SZ_B]) if q.geom_type=='Polygon' and q.area>20000]
SZ_B=unary_union(parts).buffer(-4).buffer(4)
print('Yol bay + old S38 area %.2fM bbox %d'%(SZ_B.area/1e6,bbm(SZ_B)))
LIMS=920; MINS=560
def tile(SZ,NSA):
    def vor(pts):
        V=voronoi_diagram(MultiPoint([Point(*p) for p in pts]),envelope=box(0,0,12288,8192)); out=[]
        for p in pts:
            q=Point(*p); v=[g for g in V.geoms if g.contains(q)]
            out.append(v[0].intersection(SZ) if v else Polygon())
        return out
    n=max(2,int(round(SZ.area/NSA))); x0,y0,x1,y1=SZ.bounds; sp=[]
    while len(sp)<n:
        p=Point(srng.uniform(x0,x1),srng.uniform(y0,y1))
        if SZ.contains(p): sp.append(np.array([p.x,p.y]))
    for it in range(80):
        for _ in range(4):
            vs=vor(sp); sp=[np.array(biggest(v).centroid.coords[0]) if not v.is_empty else p for v,p in zip(vs,sp)]
        vs=[biggest(v) if not v.is_empty else v for v in vor(sp)]
        over=[i for i,v in enumerate(vs) if not v.is_empty and bbm(v)>LIMS]
        if not over: break
        i=max(over,key=lambda i:bbm(vs[i])); v=vs[i]
        pts=np.array(v.exterior.coords); c=np.array(v.centroid.coords[0]); far=pts[np.argmax(((pts-c)**2).sum(1))]
        sp[i]=c+(c-far)*0.35; sp.append(c+(far-c)*0.55)
    vs=[]
    for v in vor(sp):
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
                    sh=g.buffer(1).intersection(h2.buffer(1)).area; cost=bbm(u)-0.3*sh**0.5
                    if best is None or cost<best[0]: best=(cost,j,u)
            if best: vs[best[1]]=best[2]; vs.pop(i); done=True; break
        if not done: break
    out=[]
    for v in vs:
        g=v.buffer(-32,join_style=2,mitre_limit=3).simplify(8)
        g=biggest(g) if not g.is_empty else g
        if g.is_empty or g.area<20000: continue
        if bbm(g)>FIN: g=boxclip(g,FIN)
        out.append(dict(region='Sea',type='sea',kind='sea',raw=v,poly=g))
    return out

best=None
for seed in range(40):
    srng=np.random.default_rng(seed)
    T=tile(SZ_B,SZ_B.area/2)
    if len(T)!=2: continue
    sc=min(bbm(t['poly']) for t in T)
    if best is None or sc>best[0]: best=(sc,seed,T)
print('Yol bay split seed',best[1],'min bbox',int(best[0]))
T=sorted(best[2],key=lambda t:t['poly'].centroid.y)    # north part = new S40 (bay), south part keeps S38 (Yol coast)
nmax=max(int(x['id'].split('_S')[1]) for x in sea)
S38.update(poly=T[1]['poly'],raw=T[1]['raw'])
T[0]['id']=f'ZilleTile_S{nmax+1}'; T[0]['num']=f'S{nmax+1}'
sea=sea+[T[0]]
for x in (S38,T[0]): print(x['id'],'bbox',int(bbm(x['poly'])),'area',int(x['poly'].area),'centroid',[int(v) for v in x['poly'].centroid.coords[0]])
SZ=unary_union([S10['SZ'],SZ_B])
SETT=SETT+[('Grodzizg',np.array(GZ['center'],float),'major')]
pickle.dump(dict(land=cells,sea=sea,SZ=SZ,ZONEV=ZONEV,SETT=SETT,city=S10['city'],zones=S10['zones']),open('work/prov11_stage2.pkl','wb'))
print({r:sum(1 for c in cells if c['region']==r) for r in ['Zille','Brenas','Wehlen']},'sea',len(sea),'total',len(cells)+len(sea))
