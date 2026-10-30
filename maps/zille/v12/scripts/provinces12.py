"""v12 on top of v11: sea corridor from the Isor/Sor channel south along the Zille west coast into the bay by Zille City.
All v11 provinces keep their ids and geometry; new sea provinces get S41+. -> work/prov12_stage2.pkl"""
import numpy as np, pickle, sys
from shapely.geometry import Polygon, Point, box, MultiPoint, LineString
from shapely.ops import unary_union, voronoi_diagram
def bbm(g): b=g.bounds; return max(b[2]-b[0],b[3]-b[1])
def biggest(g): return max(g.geoms,key=lambda q:q.area) if g.geom_type in ('MultiPolygon','GeometryCollection') else g
def boxclip(g,b):
    x0,y0,x1,y1=g.bounds; cx,cy=(x0+x1)/2,(y0+y1)/2
    return biggest(g.intersection(box(cx-b/2,cy-b/2,cx+b/2,cy+b/2)))
FIN=860
S=pickle.load(open('work/prov11_stage2.pkl','rb')); cells=S['land']; sea=S['sea']
dd=pickle.load(open('work/land_dec.pkl','rb')); LAND=unary_union([dd['Ld']]+dd['islets'])
FRAME=box(265+30,276+30,12023-30,7907-30)
SEA0=FRAME.difference(LAND.buffer(5))
KEEPR=unary_union([x['raw'] for x in sea])
# corridor: from the south edge of the channel (S34/S35/S36) along the Zille west coast (Marenta, Sabbiano, Vela Nova,
# Capo Lisso, Azzurra) into the bay at Zille City; ~1600-2000 map px (2-3 tiles) out from the coast
CORR=Polygon([(5900,3900),(7950,3900),(7950,6420),(5550,6420),(5350,5750),(5500,4850)])
g=CORR.intersection(SEA0).difference(KEEPR.buffer(0.5))
parts=[q for q in getattr(g,'geoms',[g]) if q.geom_type=='Polygon' and q.area>150000]
SZ_C=unary_union(parts).buffer(-4).buffer(4)
print('corridor area %.2fM parts %d'%(SZ_C.area/1e6,len(parts)))
LIMS=920; MINS=600
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
    return vs



def thin(v,r=80):   # parts of a raw cell narrower than ~2r (coves, inlets, cove mouths)
    return v.difference(v.buffer(-r,join_style=2,mitre_limit=3).buffer(r+10,join_style=2,mitre_limit=3))
SMALLISL=unary_union([p for p in dd['islets'] if p.area<30000])
def fillsmall(v):
    out=[]
    for p in getattr(v,'geoms',[v]):
        if p.geom_type!='Polygon': continue
        out.append(Polygon(p.exterior,[r for r in p.interiors if Polygon(r).area>30000]))
    return unary_union(out)
def shape(v):
    v=fillsmall(v)     # tiny islets do not cut the sea cell; they are cut back out afterwards with a small gap
    g=v.buffer(-32,join_style=2,mitre_limit=3)
    t=thin(v)
    if not t.is_empty: g=unary_union([g,v.buffer(-16,join_style=2,mitre_limit=3).intersection(t.buffer(40))])
    g=g.buffer(-6,join_style=2).buffer(6,join_style=2).buffer(-9).buffer(9).simplify(5)
    return g.difference(SMALLISL.buffer(16))
def finish(vs):
    # orphan raw pieces (coves cut off by a Voronoi edge) join the neighbouring piece with the longest contact
    vs=sorted(vs,key=lambda q:-q.area)
    for _ in range(50):
        vs.sort(key=lambda q:-q.area); ch=False
        for i in range(len(vs)-1,-1,-1):
            q=vs[i]
            if bbm(q)>=MINS and q.area>120000: continue
            cand=[(q.buffer(1).intersection(o.buffer(1)).area,j) for j,o in enumerate(vs) if j!=i and q.distance(o)<1]
            cand=[(a,j) for a,j in cand if bbm(unary_union([q,vs[j]]))<=FIN+40]
            if not cand: continue
            a,j=max(cand); vs[j]=unary_union([q,vs[j]]).buffer(0.5).buffer(-0.5); vs.pop(i); ch=True; break
        if not ch: break
    out=[]
    for v in vs:
        g=shape(v); parts=[p for p in getattr(g,'geoms',[g]) if p.geom_type=='Polygon' and p.area>4000]
        if not parts: continue
        if len(parts)>1:   # reconnect cove pieces cut off by islets at a mouth: short channel through the raw cell
            from shapely.ops import nearest_points
            parts.sort(key=lambda p:-p.area); main=parts[0]
            for p in parts[1:]:
                D=main.distance(p)+70; br=main.buffer(D).intersection(p.buffer(D)).intersection(v.buffer(-14,join_style=2))
                main=unary_union([main,p,br]).buffer(-8).buffer(8)
            parts=[biggest(main)] if main.geom_type!='Polygon' else [main]
        g=unary_union(parts)
        if bbm(g)>FIN: g=boxclip(g,FIN)
        out.append(dict(region='Sea',type='sea',kind='sea',raw=v,poly=g))
    return out
NSA=float(sys.argv[2]) if len(sys.argv)>2 else 380000
best=None
SEEDS=[int(v) for v in sys.argv[1].split(",")] if len(sys.argv)>1 else [31]
for seed in SEEDS:
    srng=np.random.default_rng(seed)
    T=finish(tile(SZ_C,NSA))
    sc=min(bbm(t['poly']) for t in T); cov=sum(t['raw'].area for t in T)/SZ_C.area; parts=max(len(getattr(t['poly'],'geoms',[1])) for t in T)
    print('seed',seed,'n',len(T),'min bbox',int(sc),'max',int(max(bbm(t['poly']) for t in T)),'cover %.3f'%cov,'maxparts',parts,flush=True)
    if cov<0.995 or len(T)<8: continue
    if best is None or sc>best[0]: best=(sc,seed,T)
print('corridor seed',best[1],'min bbox',int(best[0]))
T=sorted(best[2],key=lambda t:(round(t['poly'].centroid.y/450),t['poly'].centroid.x))
nmax=max(int(x['id'].split('_S')[1]) for x in sea)
for k,t in enumerate(T):
    t['id']=f'ZilleTile_S{nmax+1+k}'; t['num']=f'S{nmax+1+k}'
    print(t['id'],'bbox',int(bbm(t['poly'])),'area',int(t['poly'].area),'centroid',[int(v) for v in t['poly'].centroid.coords[0]])
NAMES={'ZilleTile_S52':'Zille Bay','ZilleTile_S51':'Azzurra Waters'}   # the inlet that reaches Zille City, and the Azzurra approach
for t in T:
    if t['id'] in NAMES: t['name']=NAMES[t['id']]
sea=sea+T
SZ=unary_union([S['SZ'],SZ_C])
pickle.dump(dict(land=cells,sea=sea,SZ=SZ,SZ_C=SZ_C,ZONEV=S['ZONEV'],SETT=S['SETT'],city=S['city'],zones=S['zones']),open('work/prov12_stage2.pkl','wb'))
print({r:sum(1 for c in cells if c['region']==r) for r in ['Zille','Brenas','Wehlen']},'sea',len(sea),'total',len(cells)+len(sea))
