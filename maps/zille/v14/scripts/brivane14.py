"""v14 Brivane block (Brenas south): the main road Zille - Brivane ran diagonally along province borders / through the
gaps between provinces. The block of v13 cells 55 56 60 61 62 63 65 66 67 is re-cut so that the road runs through a chain
of provinces along their centre line (perpendicular cuts every ~CHL px of road, chain half-width CHW), and the land left
and right of the chain is split into compact cells (k-means on the area). Output work14/brivane14.pkl (cells with v13
ids re-used by largest overlap in prov14_export)."""
import numpy as np, pickle, sys, os
sys.path.insert(0,'/workspace/zille/versions/v14/scripts'); sys.path.insert(0,'/workspace/zille/work14')
from part14 import *
from lib import layer_lines
from zones14 import ZONEV, LAND
from shapely.geometry import LineString, Point, Polygon, MultiPolygon
from shapely.ops import unary_union, split, substring
from scipy.cluster.vq import kmeans2
BLOCK=['55','56','60','61','62','63','65','66','67']
CHW=float(os.environ.get('CHW','290')); CHL=float(os.environ.get('CHL','560')); NSIDE=int(os.environ.get('NSIDE','0'))
SVG=open('work14/base/zille_vector.svg').read()
F=pickle.load(open('work13/prov13_final.pkl','rb'))['allp']
BL=[c for c in F if c['type']=='land' and c['num'] in BLOCK]; OT=[c for c in F if c['type']=='land' and c['num'] not in BLOCK]
Z0=[g for g in ZONEV.geoms if g.bounds[0]>4000][0]
ZV=unary_union([c['poly'].buffer(33) for c in BL]).buffer(60,join_style=1).buffer(-60,join_style=1)
ZV=ZV.intersection(Z0.buffer(5)).intersection(LAND.buffer(-27)).difference(unary_union([c['poly'].buffer(64) for c in OT if c['poly'].distance(ZV)<300]))
ZV=biggest(ZV)   # the area the block cells may cover (32 px inside the gap midlines -> 64 px gaps to the rest)
ROAD=[ln for nm,ln in layer_lines('main_roads',SVG) if abs(ln.bounds[0]-7835)<5 and abs(ln.bounds[2]-10347)<5][0]
RIN=ROAD.intersection(ZV.buffer(-40)); RIN=max(getattr(RIN,'geoms',[RIN]),key=lambda g:g.length)
s0=ROAD.project(Point(RIN.coords[0])); s1=ROAD.project(Point(RIN.coords[-1]))
if s0>s1: s0,s1=s1,s0
def both_sides(s,off=230):
    p=ROAD.interpolate(s); a=ROAD.interpolate(max(s-60,0)); b=ROAD.interpolate(min(s+60,ROAD.length))
    v=np.array([b.x-a.x,b.y-a.y]); v/=np.hypot(*v); nr=np.array([-v[1],v[0]])
    return ZV.contains(Point(p.x+nr[0]*off,p.y+nr[1]*off)) and ZV.contains(Point(p.x-nr[0]*off,p.y-nr[1]*off))
ss=[t for t in np.arange(s0,s1,10) if both_sides(t)]
tp('road in block %.0f-%.0f, both sides inside from %.0f to %.0f'%(s0,s1,ss[0],ss[-1]))
s0=max(s0,ss[0]-120)
n=max(2,int(round((s1-s0)/CHL))); cuts=np.linspace(s0,s1,n+1)
tp('road inside block %.0f px -> %d chain cells of %.0f px'%(s1-s0,n,(s1-s0)/n))
seg=substring(ROAD,s0-700,s1+400)
CH=seg.buffer(CHW,cap_style=2,join_style=1).intersection(ZV)
def perp(s,L=900):
    p=ROAD.interpolate(s); a=ROAD.interpolate(max(s-60,0)); b=ROAD.interpolate(min(s+60,ROAD.length))
    v=np.array([b.x-a.x,b.y-a.y]); v/=np.hypot(*v); nrm=np.array([-v[1],v[0]])
    return LineString([(p.x-nrm[0]*L,p.y-nrm[1]*L),(p.x+nrm[0]*L,p.y+nrm[1]*L)])
pieces=[CH]
for s in cuts[1:-1]:
    ln=perp(s); out=[]
    for pc in pieces:
        r=split(pc,ln); out+= [g for g in r.geoms]
    pieces=out
pieces=[g for g in pieces if g.area>20000]
def chain_order(g): return ROAD.project(g.centroid)
pieces=sorted(pieces,key=chain_order)
chain=[]
for g in pieces:
    q=g.buffer(-32,join_style=2).buffer(-70,join_style=1).buffer(70,join_style=1)
    chain.append(biggest(q))
# side areas
SR=ZV.difference(CH.buffer(32,join_style=1)); comps=[g for g in getattr(SR,'geoms',[SR]) if g.area>60000]
side=[]
for comp in comps:
    k=NSIDE if NSIDE and len(comps)==1 else max(1,int(round(comp.area/float(os.environ.get('SAREA','340000')))))
    m=rast(comp); ys,xs=np.nonzero(m); X=np.stack([xs,ys],1).astype(float)*G
    for kk in range(k,k+4):
        best=None
        for r in range(6):
            C,_=kmeans2(X[::2],kk,minit='++',seed=r+7,iter=80); d=((X[:,None,:]-C[None])**2).sum(-1); lab=d.argmin(1); sse=d.min(1).sum()
            if best is None or sse<best[0]: best=(sse,lab)
        L=np.zeros(m.shape,np.int32); L[ys,xs]=best[1]+1; L=fix_conn(L); L=smooth_labels(L,3.0)
        P=label_polys(L); cells=[]
        for k_,p in P.items():
            q=p.intersection(comp)
            # shrink towards the Voronoi midline -> 64 px gaps
            q=q.difference(unary_union([P[j].buffer(32) for j in P if j!=k_]))
            q=biggest(q.buffer(-50,join_style=1).buffer(50,join_style=1).intersection(comp))
            cells.append(q)
        if max(bbm(c) for c in cells)<=860: break
    tp('side component %.2fM -> %d cells, bbox %s'%(comp.area/1e6,len(cells),[int(bbm(c)) for c in cells]))
    side+=cells
tp('chain bbox',[int(bbm(c)) for c in chain],'areas',[int(c.area/1000) for c in chain])
out=[dict(region='Brenas',type='land',kind='cell',poly=c,raw=c,chain=True,chain_index=i) for i,c in enumerate(chain)]+\
    [dict(region='Brenas',type='land',kind='cell',poly=c,raw=c,chain=False) for c in side]
uncov=ZV.difference(unary_union([c['poly'].buffer(33) for c in out]))
tp('cells',len(out),'uncovered %.0f'%uncov.area,'largest hole %.0f'%max([h.area for h in getattr(uncov,'geoms',[uncov])]+[0]))
pickle.dump(dict(cells=out,ZV=ZV,road=ROAD,block=BLOCK),open('work14/brivane14.pkl','wb'))
