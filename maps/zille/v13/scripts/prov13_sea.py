"""v13 sea additions (all 52 v12 sea provinces keep id and geometry):
  S53       fills the gap south of Port Rotsla (between Yol Roads S39, the Rotsla channel S34 and the corridor S41/S46)
  S54, S55  continue the west-coast corridor south past Rivamare / Santa Calla / Praia Velha
  S56, S57  the two provinces on the bottom edge of the map, off the Rizian coast (Areias, Costa Dalle, Marbelas):
            Rizia's 2 western ship-placement seas
Angular Voronoi cells (Lloyd-relaxed), same coast inset/shaping as v12 (32 map px, 16 in narrow coves). -> work13/sea13.pkl"""
import numpy as np, pickle, sys
from shapely.geometry import Polygon, Point, box, MultiPoint
from shapely.ops import unary_union, voronoi_diagram
def bbm(g): b=g.bounds; return max(b[2]-b[0],b[3]-b[1])
def biggest(g): return max(g.geoms,key=lambda q:q.area) if g.geom_type in ('MultiPolygon','GeometryCollection') else g
S=pickle.load(open('work/prov12_stage2.pkl','rb')); sea=S['sea']
dd=pickle.load(open('work/land_dec.pkl','rb')); LAND=unary_union([dd['Ld']]+dd['islets'])
FRAME=box(265+30,276+30,12023-30,7907-30)
SEA0=FRAME.difference(LAND.buffer(5))
KEEPR=unary_union([x['raw'] for x in sea])
def region(poly):
    g=poly.intersection(SEA0).difference(KEEPR.buffer(0.5))
    parts=[q for q in getattr(g,'geoms',[g]) if q.geom_type=='Polygon' and q.area>100000]
    return unary_union(parts).buffer(-4).buffer(4)
# gap south of Port Rotsla: bounded by S39 (x<=4949), S34 (y>=4217..4280), S41/S46 (x>=5396..5527); open side cut on a slant
GAPR=region(Polygon([(4900,4100),(5800,4100),(5800,4800),(5396,4990),(4949,4650)]))
# corridor extension to the bottom edge; left edge angular (5550,6420)->(5640,7060)->(6230,7877)
EXTR=region(Polygon([(5550,6419),(7800,6419),(7800,7950),(6230,7950),(5640,7060)]))
print('gap %.2fM bbox %d   ext %.2fM bounds %s'%(GAPR.area/1e6,bbm(GAPR),EXTR.area/1e6,[int(v) for v in EXTR.bounds]))
def vor(pts,SZ):
    V=voronoi_diagram(MultiPoint([Point(*p) for p in pts]),envelope=box(0,0,12288,8192)); out=[]
    for p in pts:
        q=Point(*p); v=[g for g in V.geoms if g.contains(q)]
        out.append(biggest(v[0].intersection(SZ)) if v else Polygon())
    return out
# 4 seeds: two rows of two; Lloyd-relaxed but the bottom row is kept on the bottom edge
sp=[np.array(p,float) for p in [(6050,6750),(6650,6700),(6400,7520),(7050,7560)]]
for it in range(12):
    vs=vor(sp,EXTR); sp=[np.array(v.centroid.coords[0]) for v in vs]
    sp[2][1]=max(sp[2][1],7450); sp[3][1]=max(sp[3][1],7450)
vs=vor(sp,EXTR)
print('ext cells',[(int(bbm(v)),[int(x) for x in v.bounds]) for v in vs])
dd_isl=dd['islets']
SMALLISL=unary_union([p for p in dd_isl if p.area<30000])
def thin(v,r=80): return v.difference(v.buffer(-r,join_style=2,mitre_limit=3).buffer(r+10,join_style=2,mitre_limit=3))
def fillsmall(v):
    out=[]
    for p in getattr(v,'geoms',[v]):
        if p.geom_type!='Polygon': continue
        out.append(Polygon(p.exterior,[r for r in p.interiors if Polygon(r).area>30000]))
    return unary_union(out)
def shape(v):
    v=fillsmall(v); g=v.buffer(-32,join_style=2,mitre_limit=3); t=thin(v)
    if not t.is_empty: g=unary_union([g,v.buffer(-16,join_style=2,mitre_limit=3).intersection(t.buffer(40))])
    g=g.buffer(-6,join_style=2).buffer(6,join_style=2).buffer(-9).buffer(9).simplify(5)
    return biggest(g.difference(SMALLISL.buffer(16)))
NEW=[]
for k,(raw,nm) in enumerate([(GAPR,'Rotsla Deep'),(vs[0],None),(vs[1],None),(vs[2],None),(vs[3],None)]):
    g=shape(raw); sid=f'ZilleTile_S{53+k}'
    if bbm(g)>855:      # clip the long side on the open-water edge only (keep the coast side)
        b=g.bounds; cut=bbm(g)-850
        g=biggest(g.intersection(box(b[0]+cut,b[1],b[2],b[3]) if (b[2]-b[0])>=(b[3]-b[1]) else box(b[0],b[1],b[2],b[3]-cut)))
    d=dict(region='Sea',type='sea',kind='sea',raw=raw,poly=g,id=sid,num=f'S{53+k}')
    if nm: d['name']=nm
    NEW.append(d); print(sid,'bbox',int(bbm(g)),'area',int(g.area),'centroid',[int(v) for v in g.centroid.coords[0]],'bottom',int(g.bounds[3]))
assert bbm(NEW[3]['poly'])<=860 and NEW[3]['poly'].bounds[3]>7800 and NEW[4]['poly'].bounds[3]>7800
SZ=unary_union([S['SZ'],GAPR,EXTR])
pickle.dump(dict(new=NEW,SZ=SZ,GAPR=GAPR,EXTR=EXTR),open('work13/sea13.pkl','wb'))
