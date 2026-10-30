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


# ======================= v10: edits on top of v9 =======================
FIN=860; MINF=520
def bbm(g): b=g.bounds; return max(b[2]-b[0],b[3]-b[1])
S9=pickle.load(open('work/prov9_stage2.pkl','rb'))
cells=S9['land']; sea9=S9['sea']; ZONEV=S9['ZONEV']; SETT=S9['SETT']; zones=S9['zones']
# ---------- 1) lobed city provinces: urban form + road arms + coast, irregular margin ----------
rdm=ndi.binary_dilation(rds>0.25,iterations=3)
LIN8m=rast(LIN8)
TGT={'Isor':560,'Munat':540,'Mave Nortus':600,'Wiktrany':560,'Nanta':580}
def lobed(n,tgt):
    U=URB[n]; um=rast(U.buffer(10)); dU=ndi.distance_transform_edt(~um)*G
    c=np.array(U.centroid.coords[0]); dc=np.hypot(X-c[0],Y-c[1])
    wob=(noise1+1)/2   # 0..1, organic variation of the margin
    seam_d=ndi.distance_transform_edt(LIN8m)*G     # distance from the coast (inside land)
    rr=np.random.default_rng(sum(map(ord,n))); ph,ph2=rr.uniform(0,2*np.pi,2)
    th=np.arctan2(Y-c[1],X-c[0]); lob=1+0.45*np.sin(3*th+ph)+0.22*np.sin(5*th+ph2)
    best=None
    for R in range(200,1000,20):
        m0=0.26*R
        core=dU<m0*lob*(0.75+0.5*wob)                          # urban outline with an irregular, lobed margin
        arms=rdm&(dc<R)&(dU<R*0.95)                             # arms along roads leaving the city
        arms=ndi.binary_dilation(arms,iterations=int(max(2,R/110)))
        coast=(seam_d<130)&(dc<R*0.8)&(dU<R*0.7)                # coastal lobe
        m=(core|arms|coast)&LIN8m
        m=ndi.gaussian_filter(m.astype(float),2.2)>0.5
        lab,k=ndi.label(m)
        if k==0: continue
        cy,cx=int(c[1]/G),int(c[0]/G)
        keep=lab[cy,cx] if lab[cy,cx] else np.argmax(ndi.sum(m,lab,range(1,k+1)))+1
        g=mask_poly(lab==keep,(0,0),sig=1.4).intersection(LIN8)
        g=biggest(g.buffer(-12,join_style=1).buffer(12,join_style=1))
        if bbm(g)>FIN: break
        best=(R,g)
        if bbm(g)>=tgt: break
    return best
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

PET={'Isor','Nanta','Wiktrany','Mave Nortus'}
CITYNEW={}; OLDC={}
for c in cells:
    if c['kind']=='city' and c['city'] in TGT:
        R,g=(petals if c['city'] in PET else lobed)(c['city'],TGT[c['city']])
        old=bbm(c['poly']); OLDC[c['city']]=c['poly']; c['poly']=g; c['raw']=g; c['note']=f'lobed urban form (urban outline + road arms + coast, R={R})'
        CITYNEW[c['city']]=g
        b=g.bounds; print('city',c['city'],'bbox',int(old),'->',[int(b[2]-b[0]),int(b[3]-b[1])],'fill %.2f'%(g.area/((b[2]-b[0])*(b[3]-b[1]))))
NEWC=unary_union(list(CITYNEW.values()))
# local re-partition around each reshaped city: the neighbouring cells re-grow (organic watershed on the
# same relief/river/road energy) into the space the old city blob left, keeping a 64 px gap everywhere
def local_repartition(cn):
    C=CITYNEW[cn]; old=OLDC[cn]
    N=[c for c in cells if c['kind']=='cell' and (c['poly'].distance(old)<100 or c['poly'].distance(C)<64)]
    if not N: return
    rest=[c for c in cells if c not in N and not (c['kind']=='city' and c['city']==cn)]
    R=unary_union([c['poly'].buffer(40) for c in N]+[old.buffer(40)]).intersection(ZONEV)
    R=R.difference(C.buffer(64,join_style=1)).difference(unary_union([o['poly'].buffer(64) for o in rest if o['poly'].distance(R)<100]))
    reg_ok=[c for c in N]
    m=rast(R); mk=np.zeros((H,W),np.int32)
    for i,c in enumerate(N):
        g=c['poly'].difference(C.buffer(100)); g=biggest(g) if not g.is_empty else c['poly']
        core=rast(g.buffer(-60)) if not g.buffer(-60).is_empty else rast(g)
        mk[core&m]=i+1
    Lw=watershed(E,mk,mask=m,compactness=0.02); Lw=fix_conn(Lw)
    newp=[]
    for i,c in enumerate(N):
        mm=Lw==i+1
        if not mm.any(): return print('repartition',cn,'failed: empty')
        g=mask_poly(mm,(0,0),sig=1.6).intersection(R).buffer(-32,join_style=1)
        g=biggest(g.buffer(-20,join_style=1).buffer(20,join_style=1)) if not g.is_empty else g
        if g.is_empty or bbm(g)>FIN or bbm(g)<MINF: return print('repartition',cn,'rejected: size',int(bbm(g)) if not g.is_empty else 0)
        newp.append(g)
    for c,g in zip(N,newp): c['poly']=g; c['raw']=g
    print('repartition',cn,'cells',len(N),'bbox',[int(bbm(g)) for g in newp])
for cn in CITYNEW: local_repartition(cn)
# any cell still touching a new city gives way
for c in cells:
    if c['kind']=='city' and c['city'] in CITYNEW: continue
    if c['poly'].distance(NEWC)>=63: continue
    g=c['poly'].difference(NEWC.buffer(64,join_style=1))
    g=biggest(g.buffer(-20,join_style=1).buffer(20,join_style=1)) if not g.is_empty else g
    c['poly']=g; c['raw']=c['raw'].difference(NEWC)
print('cells swallowed by new city forms',[(c['region'],int(c['poly'].area)) for c in cells if c['poly'].is_empty or c['poly'].area<=3000])
cells=[c for c in cells if not c['poly'].is_empty and c['poly'].area>3000]
# freed pockets (old blob larger than lobed form in places) -> neighbours
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
def remerge():
    global cells
    removed=set()
    for c in sorted([c for c in cells if c['kind']=='cell' and bbm(c['poly'])<MINF],key=lambda c:c['poly'].area):
        best=None
        for o in cells:
            if o is c or id(o) in removed or o['kind']!='cell' or o['region']!=c['region'] or o['poly'].distance(c['poly'])>90: continue
            U=unary_union([o['poly'],c['poly'],o['poly'].buffer(75).intersection(c['poly'].buffer(75)).intersection(ZONEV)])
            others=unary_union([q['poly'].buffer(64) for q in cells if q is not o and q is not c and q['poly'].distance(U)<200])
            U=biggest(U.difference(others).buffer(-3).buffer(3))
            if bbm(U)<=FIN and (best is None or bbm(U)<best[0]): best=(bbm(U),o,U)
        if best: best[1]['poly']=best[2]; best[1]['raw']=unary_union([best[1]['raw'],c['raw']]); removed.add(id(c)); print('merged undersized cell into neighbour',int(best[0]))
    cells=[c for c in cells if id(c) not in removed]
remerge()
for c in [c for c in cells if c['kind']=='cell' and bbm(c['poly'])<MINF]:
    cs=[o for o in cells if o['kind']=='city' and o['region']==c['region'] and o['poly'].distance(c['poly'])<120]
    if not cs: continue
    o=min(cs,key=lambda o:o['poly'].distance(c['poly']))
    others=unary_union([q['poly'].buffer(64) for q in cells if q is not o and q is not c and q['poly'].distance(c['poly'])<300])
    U=biggest(unary_union([o['poly'],c['poly'],o['poly'].buffer(80).intersection(c['poly'].buffer(80)).intersection(ZONEV)]).difference(others).buffer(-3).buffer(3))
    if bbm(U)<=FIN: o['poly']=U; o['raw']=U; c['drop']=True; print('sliver joined city',o['city'],int(bbm(U)))
cells=[c for c in cells if not c.get('drop')]
# pockets left between a reshaped city and its neighbours -> become part of that city (an extra lobe)
cov=unary_union([c['poly'] for c in cells]).buffer(70); Hh=ZONEV.difference(cov)
for h in getattr(Hh,'geoms',[Hh]):
    if h.area<8000: continue
    for c in cells:
        if c['kind']=='city' and c['city'] in CITYNEW and c['poly'].distance(h)<140:
            others=unary_union([o['poly'].buffer(64) for o in cells if o is not c and o['poly'].distance(h)<400])
            U=biggest(unary_union([c['poly'],h.buffer(70).intersection(ZONEV).difference(others)]).buffer(15).buffer(-15))
            if bbm(U)<=FIN: c['poly']=U; c['raw']=U; print('pocket joined city',c['city'],int(h.area)); break
print('undersized land',[(c['region'],int(bbm(c['poly'])),[int(v) for v in c['poly'].centroid.coords[0]]) for c in cells if c['kind']=='cell' and bbm(c['poly'])<MINF])
# ---------- 2) sea: re-tile the north-east approach (Tarnes/Mave Nortus -> Munat, Nanta bay), add the Yol bay ----------
SEA0=FRAME.difference(LAND.buffer(5))
NE=Polygon([(8350,276),(8350,1250),(9200,1050),(10050,1250),(10850,1750),(11550,2350),(12100,3000),(12100,4700),(9800,4700),(9800,3000),(8800,3000),(8800,2400),(8350,2400)])
drop=[s for s in sea9 if s['raw'].centroid.x>8300]
keep=[s for s in sea9 if s['raw'].centroid.x<=8300]
KEEPR=unary_union([s['raw'] for s in keep])
YOLB=Polygon([(3750,3850),(4450,3800),(4950,4130),(4900,4650),(3750,4650)])
def region(poly):
    g=poly.intersection(SEA0).difference(KEEPR.buffer(0.5))
    parts=[q for q in getattr(g,'geoms',[g]) if q.geom_type=='Polygon' and q.area>150000]
    return unary_union(parts).buffer(-4).buffer(4)
SZ_NE=region(unary_union([NE]+[s['raw'] for s in drop]))
SZ_Y=region(YOLB)
print('NE sea %.2fM  Yol bay %.2fM'%(SZ_NE.area/1e6,SZ_Y.area/1e6))
srng=np.random.default_rng(int(sys.argv[1]) if len(sys.argv)>1 else 11)
LIMS=920; MINS=640
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
NSA=float(sys.argv[2]) if len(sys.argv)>2 else 400000
seaNE=tile(SZ_NE,NSA); seaY=tile(SZ_Y,float(sys.argv[3]) if len(sys.argv)>3 else 520000)
sea=keep+seaNE+seaY
SZ=unary_union([S9['SZ'].difference(unary_union([s['raw'] for s in drop])),SZ_NE,SZ_Y])
sb=[bbm(s['poly']) for s in sea]
print('sea kept',len(keep),'NE',len(seaNE),'(was',len(drop),') Yol',len(seaY),'bbox min/max',int(min(sb)),int(max(sb)))
pickle.dump(dict(land=cells,sea=sea,SZ=SZ,ZONEV=ZONEV,SETT=SETT,city=S9['city'],zones=zones),open('work/prov10_stage2.pkl','wb'))
print({r:sum(1 for c in cells if c['region']==r) for r in ['Zille','Brenas','Wehlen']},'total',len(cells)+len(sea))
