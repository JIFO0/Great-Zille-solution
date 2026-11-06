"""v14 land provinces (west mainland + Brivane block). Everything else (Zille, the rest of Brenas, islands) is the v13
geometry. usage: prov14_land.py SEED_W SEED_D -> work14/land14_w{SEED_W}_d{SEED_D}.pkl
 A) Wehlen (owner request: provinces fit mountains and roads, ~4 more provinces on the southern front facing Derdia,
    Kratsna and Grodzizg as seaside cities): the whole Wehlen mainland zone (v13 zone + extension west along the
    Derdian border) is re-partitioned with the v13 road/relief-aware geodesic Voronoi (massifs on their own, towns as
    pinned seeds, secondary-road short runs removed, town discs), 29 cells + Kratsna + Grodzizg city provinces.
 B) Derdia strip: 6 cells + Yol (impassable city province) south of the Wehlen-Derdia border.
 C) Brivane block (Brenas south): the main road Zille - Brivane runs through a chain of provinces (perpendicular cuts
    along the road, road on the chain's centre line), side cells partitioned around it."""
import numpy as np, pickle, sys, os
sys.path.insert(0,'/workspace/zille/versions/v14/scripts'); sys.path.insert(0,'/workspace/zille/work14')
from part14 import *
from part14 import _sides
from lib import layer_lines, group as lgroup
from zones14 import WZ, DZ, LAND, FRAME, ZONEV
from sides14 import WSIDE, DSIDE, B1, B2
SW_=int(sys.argv[1]) if len(sys.argv)>1 else 1; SD_=int(sys.argv[2]) if len(sys.argv)>2 else 1
SVG=open('work14/base/zille_vector.svg').read()
ED=pickle.load(open('work14/base/edits14.pkl','rb')); SETT=ED['SETT14']; URB=ED['urban']
F13=pickle.load(open('work13/prov13_final.pkl','rb')); P13=F13['allp']; by13={c['id']:c for c in P13}
riv=gmask(SVG,['rivers'],lgroup); rds=gmask(SVG,['main_roads','roads_double_fill'],lgroup); rdmin=gmask(SVG,['roads_minor'],lgroup)
h13=np.load('work13/topo_h13.npy').astype(float)
noise1=fbm((H,W),18,3,np.random.default_rng(21))
hs_=ndi.gaussian_filter(h13,1.2); gy_,gx_=np.gradient(hs_); slope=np.hypot(gx_,gy_)
def make_cost(zone,seed):
    sl=slope/np.percentile(slope[zone],99)
    rivm=ndi.binary_dilation(riv>0.25,iterations=1)
    C=1+float(os.environ.get('SLW','2.6'))*np.clip(sl,0,1.6)+float(os.environ.get('RVW','5.0'))*rivm-float(os.environ.get('RDW','0.3'))*ndi.binary_dilation(rds>0.2,iterations=2)-0.2*ndi.binary_dilation(rdmin>0.25,iterations=1)
    noise3=fbm((H,W),7,3,np.random.default_rng(seed+77))
    C=np.clip(C,0.35,None)+0.25*(noise1+1)+float(os.environ.get('NZ','0.5'))*np.clip(noise3+0.3,0,None)
    C[~zone]=1e6; return C
SECR=[ln for g in ('main_roads','roads_double_fill') for _,ln in layer_lines(g,SVG)]
def city_province(U,zone,target=(600,700),coast_bonus=True,r0=60):
    """city province: urban area grown evenly + along its waterfront, inside the zone"""
    best=None
    for r in range(r0,520,10):
        g=U.buffer(r,join_style=1)
        if coast_bonus: g=unary_union([g,U.buffer(r*1.35).intersection(LAND.boundary.buffer(r*0.75))])
        g=biggest(g.intersection(zone)).buffer(-25,join_style=1).buffer(25,join_style=1)
        g=biggest(g.intersection(zone))
        if bbm(g)>target[1]: break
        best=g
        if bbm(g)>=target[0]: break
    return best
def massif_partition(P,zone,MCUT=0.20,AREA_PER=330000,name='',MINA=150000):
    T_=np.array([0.07,0.15,0.23,0.31,0.40,0.50,0.61,0.73])
    hm=ndi.gaussian_filter(h13,2.0)
    MM=ndi.binary_fill_holes(ndi.binary_opening((hm>=MCUT)&zone,iterations=3))&zone
    ml,_=ndi.label(MM); Lz=np.zeros((H,W),np.int32); nxt=0; nm=0; used=np.zeros_like(zone)
    for i,sl in enumerate(ndi.find_objects(ml),1):
        mm=ml==i; a=mm.sum()*G*G; ys,xs=np.nonzero(mm); side=max(np.ptp(ys)+1,np.ptp(xs)+1)*G
        if a<MINA or side<520: continue
        n=max(1,int(round(a/AREA_PER)))
        if n==1 and side>P.LIMR: n=2
        lab=P.lloyd(mm,[],n,f'{name} massif {a/1000:.0f}k',iters=40,lo=520) if n>1 else mm.astype(np.int32)
        Lz[lab>0]=lab[lab>0]+nxt; nxt=Lz.max(); nm+=n; used|=mm
    return Lz,nm,used
def partition_zone(zone_poly,fixed,NS,seed,name,towns_all,LO=600,MCUT=0.20,AREA_PER=330000,pin_names=(),MINA=150000):
    FIXB=unary_union([f.buffer(64,join_style=1) for f in fixed]) if fixed else Polygon()
    ZR=zone_poly.difference(FIXB); ZR=unary_union([q for q in getattr(ZR,'geoms',[ZR]) if q.area>20000])
    zone=rast(ZR); C=make_cost(zone,seed); P=Part(C,seed,LIMR=int(os.environ.get('LIMR','760')))
    towns=[(n,p) for n,p,t in towns_all if ZR.buffer(-8).contains(Point(*p))]
    tp(name,'zone %.2fM'%(ZR.area/1e6),'towns',[n for n,_ in towns])
    # v14: compact capacity-balanced seeds from k-means (Euclidean CVT on the zone pixels), then a terrain-aware geodesic
    # assignment from those seeds (roads cheap, rivers / steep slopes expensive) with the strongest terrain weight that
    # still keeps every cell under the size limit -> borders bend along ridges, valleys and rivers, cells stay compact.
    from scipy.cluster.vq import kmeans2
    ys,xs=np.nonzero(zone); X=np.stack([xs,ys],1).astype(float)*G; best=None
    for r in range(8):
        Cc,_=kmeans2(X[::3],NS,minit='++',seed=seed*100+r,iter=80)
        d=((X[:,None,:]-Cc[None])**2).sum(-1); lab=d.argmin(1); sse=d.min(1).sum()
        if best is None or sse<best[0]: best=(sse,Cc)
    seeds=[tuple(c) for c in best[1]]
    # snap seeds onto the nearest town / road point within 160 px (towns sit inside, roads run through centres)
    cand=[p for n,p in towns]+[(q.x,q.y) for ln in SECR for q in [ln.interpolate(t) for t in np.arange(0,ln.length,40)]]
    cand=[c for c in cand if zone[min(int(c[1]/G),H-1),min(int(c[0]/G),W-1)]]
    for i,sd in enumerate(seeds):
        if cand:
            dd=[np.hypot(sd[0]-c[0],sd[1]-c[1]) for c in cand]; k=int(np.argmin(dd))
            if dd[k]<160: seeds[i]=tuple(cand[k])
    used=np.zeros_like(zone); Cterr=C.copy()
    for al in (1.0,0.75,0.55,0.4,0.25,0.12,0.0):
        P.COST=np.where(zone,1+al*(Cterr-1),1e6)
        Lz=fix_conn(P.geo_labels(seeds,zone))
        sd_=sorted(int(v[1]) for v in _sides(Lz).values())
        tp(name,'terrain weight',al,'cells',len(sd_),'max sides',sd_[-4:])
        if sd_[-1]<=int(os.environ.get('KLIM','850')): break
    nm=0
    Lz=fix_conn(Lz)
    tp(name,'pre-enforce sides',sorted(int(v[1]) for v in _sides(Lz).values()))
    np.save(f'work14/tmp/Lz_{name}_{seed}.npy',Lz)
    Lz=enforce_size(Lz,NS,LIM=int(os.environ.get('ELIM','880')),MERGE_LIM=830,name=name)
    MOUNT=set(np.unique(Lz[used&(Lz>0)]))
    ROADS=[ln for ln in SECR if ln.intersects(ZR)]
    Lz=fix_road_runs(Lz,ROADS)
    for _ in range(2): Lz=smooth_labels(Lz,3.0)
    Lz=fix_road_runs(Lz,ROADS,2)
    tp(name,'road short runs left',[round(x[4]) for x in road_runs(Lz,ROADS)])
    Lz=town_discs(Lz,towns,zone)
    Lz=resolve_weak(Lz)
    cells=vectorise(Lz,ZR,name,fixed_polys=fixed)
    for _ in range(3):
        k=fillholes(cells,zone_poly,unary_union(fixed) if fixed else Polygon()); 
        if not k: break
    lb=[bbm(c['poly']) for c in cells]
    tp(name,'cells',len(cells),'bbox min/med/max',int(min(lb)),int(np.median(lb)),int(max(lb)))
    return cells,Lz
# ================= A) Wehlen =================
KR=city_province(URB['kratsna'],WZ,(640,720)); GZ=city_province(URB['grodzizg'],WZ,(600,700))
for nm,g,U in (('Kratsna',KR,URB['kratsna']),('Grodzizg',GZ,URB['grodzizg'])):
    tp(nm,'city province bbox',int(bbm(g)),'area',int(g.area),'coast within 60 px: %.0f'%(g.buffer(60).intersection(LAND.boundary).length))
WEH_CELLS,LW=partition_zone(WZ,[KR,GZ],int(os.environ.get('NSW','29')),SW_,'Wehlen',SETT,AREA_PER=int(sys.argv[3]) if len(sys.argv)>3 else 340000,MINA=800000,pin_names=('Ostrelow','Oderna','Gorvitz','Bydgoszt'))
# ================= B) Derdia =================
YOL=city_province(URB['yol'],DZ,(640,760),r0=0)
tp('Yol city province bbox',int(bbm(YOL)),'area',int(YOL.area))
DER_CELLS,LD=partition_zone(DZ,[YOL],int(os.environ.get('NSD','6')),SD_,'Derdia',SETT,LO=600,AREA_PER=420000,MINA=900000)
pickle.dump(dict(wehlen=WEH_CELLS,derdia=DER_CELLS,kratsna=KR,grodzizg=GZ,yol=YOL,LW=LW,LD=LD,seeds=(SW_,SD_)),open(f'work14/land14_w{SW_}_d{SD_}_n'+os.environ.get('NSW','29')+(('_a'+sys.argv[3]) if len(sys.argv)>3 else '')+'.pkl','wb'))
tp('saved')
