"""v13 land provinces.
 A) Mave Nortus city province rebuilt entirely on the Rizian side of the border (region Brenas, owner Rizia, id 23 kept);
    the Brenas cells around it (40 41 43 44) re-grown into the space (organic watershed), all other Brenas cells unchanged.
 B) Zille peninsula re-partitioned from scratch (cities Munat 2, Nanta 9, Isor 11, Wiktrany 28, Zille City 35 and the
    island Manes Riuz 3 kept), denser (~54 free cells instead of 32), road- and relief-aware:
    - superpixels: watershed on an energy where rivers and ridge crests are high and main/secondary roads are LOW
      (borders cross roads instead of running along them); every Zille town/village is a superpixel seed, so towns sit
      inside a province, not in a gap;
    - agglomeration: compact merges (bbox, fill, contact) + a relief-contrast penalty (mountain and lowland superpixels do
      not merge, so mountain provinces follow the massif foot and ridges) + a bonus for removing a border that runs along
      a road;
    - road clean-up: a main/secondary road may not just clip a province for < 220 map px (the snippet goes to the province
      the road comes from / goes to), so each road runs through a clean chain of provinces;
    - vector gaps 64 map px, bbox <= 860, >= 480 (extent incl. stroke+blur > 512).
-> work13/land13.pkl"""
import numpy as np, pickle, sys, io, time, cairosvg, re
T0=time.time()
def tp(*a): print('[%.0fs]'%(time.time()-T0),*a,flush=True)
exec(open('versions/v13/scripts/provinces6.py').read().split("Zz=(pen|")[0])
sys.path.insert(0,'work13')
from sides import ZSIDE, RSIDE
from lib import layer_lines, group as lgroup
from skimage.segmentation import watershed
from shapely.geometry import LineString
from shapely.strtree import STRtree
from PIL import Image
Image.MAX_IMAGE_PIXELS=None
SEED=int(sys.argv[1]) if len(sys.argv)>1 else 13
TARGET=int(sys.argv[2]) if len(sys.argv)>2 else 54
LO=int(sys.argv[3]) if len(sys.argv)>3 else 600
FIN=860; MINF=425; LIMR=880
def bbm(g): b=g.bounds; return max(b[2]-b[0],b[3]-b[1])
LIN8=LAND.buffer(-27)
F12=pickle.load(open('work/prov12_final.pkl','rb')); P12=F12['allp']; by12={c['id']:c for c in P12}
S12=pickle.load(open('work/prov12_stage2.pkl','rb')); ZONEV=S12['ZONEV']; SETT=S12['SETT']
SVG=open('work13/base/zille_vector.svg').read()
def gmask(gids):
    body=''.join(lgroup(g,SVG) for g in gids)
    s=f'<svg xmlns="http://www.w3.org/2000/svg" width="{W}" height="{H}" viewBox="0 0 12288 8192">{body}</svg>'
    im=Image.open(io.BytesIO(cairosvg.svg2png(bytestring=s.encode(),output_width=W,output_height=H))).convert('RGBA')
    return np.asarray(im)[:,:,3]/255.0
riv=gmask(['rivers']); rds=gmask(['main_roads','roads_double_fill']); rdmin=gmask(['roads_minor'])
h13=np.load('work13/topo_h13.npy').astype(float)
noise1=fbm((H,W),18,3,np.random.default_rng(21))
def nz(a): return a/max(a.max(),1e-6)
E=0.55*ndi.gaussian_filter(h13/h13.max(),1.5)+0.9*nz(ndi.gaussian_filter(riv,1.2))-0.35*nz(ndi.gaussian_filter(rds,1.5))-0.12*nz(ndi.gaussian_filter(rdmin,1.2))+0.30*(noise1+1)/2
E=(E-E.min())/(E.max()-E.min())
rdm=ndi.binary_dilation(rds>0.2,iterations=2)
# ================= A) Mave Nortus inside Rizia =================
ED=pickle.load(open('work13/base/edits.pkl','rb')); U=ED['mave_urban']
RSZ=LIN8.intersection(RSIDE.buffer(-32)).intersection(ZONEV.buffer(200))
c0=np.array(U.centroid.coords[0])
def blob(cx,cy,r,rr):
    a,b,c2=rr.uniform(0,2*np.pi,3); t=np.linspace(0,2*np.pi,72,endpoint=False)
    rad=r*(1+0.22*np.sin(2*t+a)+0.14*np.sin(3*t+b)+0.08*np.sin(5*t+c2))
    return Polygon(np.stack([cx+rad*np.cos(t),cy+rad*np.sin(t)],1))
# lobes: east along the Tarnes road, south along the Zelles road, north-east up the inlet shore, south-west along the border
ARMS=[(np.radians(12),0.80,0.30),(np.radians(88),0.75,0.27),(np.radians(-58),0.62,0.24),(np.radians(140),0.55,0.22)]
rr=np.random.default_rng(2313); best=None
for sc in range(150,900,10):
    parts=[U.buffer(0.18*sc,join_style=1)]
    for a,d,r in ARMS:
        ex,ey=c0[0]+sc*d*np.cos(a),c0[1]+sc*d*np.sin(a)
        parts.append(LineString([tuple(c0),(ex,ey)]).buffer(sc*r*0.75)); parts.append(blob(ex,ey,sc*r,np.random.default_rng(int(a*1000)%9999)))
    g=unary_union(parts).buffer(0.04*sc,join_style=1).buffer(-0.06*sc,join_style=1).buffer(0.02*sc,join_style=1).intersection(RSZ)
    if g.is_empty: continue
    g=max([q for q in getattr(g,'geoms',[g]) if q.geom_type=='Polygon'],key=lambda q:q.intersection(U.buffer(60)).area)
    g=biggest(g.buffer(-10,join_style=1).buffer(10,join_style=1))
    if bbm(g)>FIN: break
    best=(sc,g)
    if bbm(g)>=640: break
MN=best[1]; assert MN.difference(RSIDE).area<1
tp('Mave Nortus city bbox',int(bbm(MN)),'area',int(MN.area),'outside Rizia %.1f'%MN.difference(RSIDE).area)
# Brenas: keep all cells except the ring around Mave Nortus, which re-grows
old23=by12['ZilleTile_23']
BRING=['ZilleTile_40','ZilleTile_41','ZilleTile_43','ZilleTile_44']
bren={c['id']:dict(c) for c in P12 if c['type']=='land' and c['region']=='Brenas'}
keepB=[c for i,c in bren.items() if i not in BRING]
RB=unary_union([bren[i]['poly'].buffer(45) for i in BRING]+[old23['poly'].buffer(45)]).intersection(ZONEV).intersection(RSIDE.buffer(-32))
RB=RB.difference(MN.buffer(64,join_style=1)).difference(unary_union([c['poly'].buffer(64) for c in keepB]))
m=rast(RB); mk=np.zeros((H,W),np.int32)
for i,k in enumerate(BRING):
    g=bren[k]['poly'].difference(MN.buffer(110)); g=biggest(g) if not g.is_empty else bren[k]['poly']
    core=g.buffer(-70); mk[rast(core if not core.is_empty else g)&m]=i+1
Lw=watershed(E,mk,mask=m,compactness=0.02); Lw=fix_conn(Lw)
for i,k in enumerate(BRING):
    g=mask_poly(Lw==i+1,(0,0),sig=1.6).intersection(RB)
    g=biggest(g.buffer(-20,join_style=1).buffer(20,join_style=1))
    bren[k]['poly']=g; bren[k]['raw']=g; bren[k]['note']='v13: re-grown around the new Mave Nortus'
    tp('Brenas regrow',k,bren[k]['name'],'bbox',int(bbm(g)),'area',int(g.area))
# neighbours must keep 64 from each other (watershed cells are adjacent in raster -> enforce gap)
for i,k in enumerate(BRING):
    others=unary_union([bren[j]['poly'] for j in BRING if j!=k])
    g=bren[k]['poly'].difference(others.buffer(64,join_style=1)) if False else bren[k]['poly']
newB=[]
rawB={k:bren[k]['poly'] for k in BRING}
for k in BRING:
    oth=unary_union([rawB[j].buffer(32) for j in BRING if j!=k])
    g=rawB[k].difference(oth).buffer(-32,join_style=1).buffer(32,join_style=1)
    g=biggest(g.buffer(-15,join_style=1).buffer(15,join_style=1)); bren[k]['poly']=g
mn=dict(old23); mn.update(poly=MN,raw=MN,region='Brenas',note='v13: Mave Nortus fully inside Rizia (urban area + lobes along the Tarnes and Zelles roads, the inlet shore and the border)')
BREN=[bren[k] for k in sorted(bren,key=lambda s:int(s.split('_')[1]))]+[mn]
# ================= B) Zille re-partition =================
FIXED=[dict(by12[i]) for i in ('ZilleTile_2','ZilleTile_3','ZilleTile_9','ZilleTile_11','ZilleTile_28','ZilleTile_35')]
for c in FIXED: assert c['poly'].difference(ZSIDE).area<1 or c['kind']=='island', c['id']
BLOCK=unary_union([c['poly'].buffer(64,join_style=1) for c in FIXED+BREN])
ZR=ZONEV.intersection(ZSIDE.buffer(-32)).difference(BLOCK)
ZR=unary_union([q for q in getattr(ZR,'geoms',[ZR]) if q.area>20000])
zone=rast(ZR)
tp('Zille free zone %.2fM'%(ZR.area/1e6))
towns=[(n,p) for n,p,t in SETT if ZR.buffer(-8).contains(Point(*p))]
tp('towns as seeds',len(towns),[n for n,_ in towns])
def poisson(zone,r,rng,fixed):
    ys,xs=np.nonzero(zone); idx=rng.permutation(len(ys)); acc=list(fixed); hsh={}; cell=r/1.5
    for (x,y) in fixed: hsh.setdefault((int(x//cell),int(y//cell)),[]).append((x,y))
    for i in idx[:80000]:
        x,y=(xs[i]+rng.random())*G,(ys[i]+rng.random())*G; cx,cy=int(x//cell),int(y//cell); ok=True
        for dx in (-2,-1,0,1,2):
            for dy in (-2,-1,0,1,2):
                for (px,py) in hsh.get((cx+dx,cy+dy),()):
                    if (px-x)**2+(py-y)**2<r*r: ok=False; break
                if not ok: break
            if not ok: break
        if ok: acc.append((x,y)); hsh.setdefault((cx,cy),[]).append((x,y))
    return acc
rng=np.random.default_rng(SEED)
# ---------- geodesic (road/relief-aware) Voronoi with Lloyd relaxation ----------
# per-pixel travel cost: roads are cheap (cells stretch along roads, road segments end up inside one province),
# rivers and steep slopes are expensive (borders settle on rivers and on the foot/flanks of the massifs, ridges)
from skimage.graph import MCP_Geometric
hs_=ndi.gaussian_filter(h13,1.2); gy_,gx_=np.gradient(hs_); slope=np.hypot(gx_,gy_)
slope=slope/np.percentile(slope[zone],99)
rivm=ndi.binary_dilation(riv>0.25,iterations=1)
COST=1+2.6*np.clip(slope,0,1.6)+5.0*rivm-0.5*ndi.binary_dilation(rds>0.2,iterations=2)-0.2*ndi.binary_dilation(rdmin>0.25,iterations=1)
noise3=fbm((H,W),7,3,np.random.default_rng(SEED+77))
COST=np.clip(COST,0.35,None)+0.25*(noise1+1)+0.9*np.clip(noise3+0.3,0,None)
COST[~zone]=1e6
COST[~zone]=1e6
def geo_labels(seeds,zm,R=1150,wts=None):
    best_=np.full((H,W),np.inf); lab=np.zeros((H,W),np.int32); r=int(R/G)
    C=np.where(zm,COST,1e6)
    for i,(x,y) in enumerate(seeds):
        cx,cy=int(x/G),int(y/G); y0,y1,x0,x1=max(cy-r,0),min(cy+r,H),max(cx-r,0),min(cx+r,W)
        m=MCP_Geometric(C[y0:y1,x0:x1]); D,_=m.find_costs([(cy-y0,cx-x0)])
        D=D-(wts[i] if wts is not None else 0)
        bb=best_[y0:y1,x0:x1]; ll=lab[y0:y1,x0:x1]; upd=(D<bb)&zm[y0:y1,x0:x1]&(D<5e5); bb[upd]=D[upd]; ll[upd]=i+1
    lab[~zm]=0
    return fix_conn(lab)
def lloyd(zm,pins,NS,name,iters=30,lo=570):
    seeds=list(pins); npin=len(pins)
    if NS>len(seeds):
        free=poisson(zm,300,rng,pins)[len(pins):]; rng.shuffle(free); seeds+=free[:NS-len(seeds)]
    WT=[0.0]*len(seeds)
    for it in range(iters):
        lab=geo_labels(seeds,zm,wts=WT)
        objs=ndi.find_objects(lab); sides=[]; new=list(seeds)
        for i in range(len(seeds)):
            sl=objs[i] if i<len(objs) else None
            if sl is None: sides.append(0); continue
            mm=lab[sl]==i+1; ys,xs=np.nonzero(mm); sides.append(max(np.ptp(ys)+1,np.ptp(xs)+1)*G)
            if i>=npin:
                c=np.array([(xs.mean()+sl[1].start+0.5)*G,(ys.mean()+sl[0].start+0.5)*G])
                if not zm[min(int(c[1]/G),H-1),min(int(c[0]/G),W-1)]:
                    k=np.argmin(np.hypot(xs+sl[1].start-c[0]/G,ys+sl[0].start-c[1]/G)); c=np.array([(xs[k]+sl[1].start+0.5)*G,(ys[k]+sl[0].start+0.5)*G])
                new[i]=tuple(c)
        seeds=new
        # additive weights: undersized cells grow, oversized ones shrink (capacity-constrained geodesic Voronoi)
        for i,s_ in enumerate(sides):
            if 0<s_<lo: WT[i]+=5+0.05*(lo-s_)
            elif s_>800: WT[i]-=4
            WT[i]*=0.97
        for i in [i for i,s_ in enumerate(sides) if s_==0]:   # swallowed seed: re-seed at the far end of the largest cell
            j=int(np.argmax(sides)); mm=lab==j+1; ys,xs=np.nonzero(mm); P2=np.stack([xs,ys],1)*G+G/2; c=P2.mean(0)
            far=P2[np.argmax(np.hypot(*(P2-c).T))]; seeds[i]=tuple(c+(far-c)*0.55); WT[i]=0.0; sides[i]=1
        big=[i for i,s_ in enumerate(sides) if s_>LIMR]; small=[i for i,s_ in enumerate(sides) if s_<MINF+70 and i>=npin]
        for i in big:
            mm=lab==i+1; ys,xs=np.nonzero(mm); P2=np.stack([xs,ys],1)*G+G/2; c=P2.mean(0)
            ev=np.linalg.eigh(np.cov((P2-c).T))[1][:,-1]; t=(P2-c)@ev
            a_=P2[np.argmin(np.abs(t-np.quantile(t,0.25)))]; b_=P2[np.argmin(np.abs(t-np.quantile(t,0.75)))]
            if i>=npin: seeds[i]=tuple(a_)
            seeds.append(tuple(b_)); WT.append(0.0)
        while len(seeds)>NS and small:
            j=min(small,key=lambda j:sides[j]); small.remove(j); seeds.pop(j); sides.pop(j); WT.pop(j); small=[k-1 if k>j else k for k in small]
        if it>=10 and not big and min(sides)>=lo-25: break
    tp(name,'iters',it,'cells',len(seeds),'side min/med/max',int(min(sides)),int(np.median(sides)),int(max(sides)))
    return geo_labels(seeds,zm,wts=WT)
# ---- mountain zones: every massif (smoothed relief >= ~band 3, i.e. the foot contour) is partitioned on its own,
#      so mountain provinces cover the massif up to its foot and lowland provinces stay lowland;
#      inside a massif the split follows the slope/valley cost (ridges, saddles)
T_=np.array([0.07,0.15,0.23,0.31,0.40,0.50,0.61,0.73]); band=np.searchsorted(T_,h13)
hm=ndi.gaussian_filter(h13,2.0)
MM=ndi.binary_fill_holes(ndi.binary_opening((hm>=0.20)&zone,iterations=3))&zone
ml,mn_=ndi.label(MM); MZ=[]
for i,sl in enumerate(ndi.find_objects(ml),1):
    mm=ml==i; a=mm.sum()*G*G; ys,xs=np.nonzero(mm); side=max(np.ptp(ys)+1,np.ptp(xs)+1)*G
    if a<150000 or side<520: continue
    MZ.append((mm,a,side))
tp('massif zones',[(int(a),int(s)) for _,a,s in MZ])
Lz=np.zeros((H,W),np.int32); nxt=0; nmount=0
for mm,a,side in MZ:
    n=max(1,int(round(a/330000)))
    if n==1 and side>LIMR: n=2
    lab=lloyd(mm,[],n,'massif %dk'%(a/1000),iters=20,lo=520) if n>1 else mm.astype(np.int32)
    lab[(lab==0)&mm]=0
    Lz[lab>0]=lab[lab>0]+nxt; nxt=Lz.max(); nmount+=n
MOUNTL=set(range(1,nxt+1))
low=zone&~MM_sel if False else zone&(Lz==0)
# pinned seeds in the lowland: towns on main/secondary roads, then points on the roads every ~600 map px
pins=[]
TOWNPRI=['Lenta','Ossa','Corvis','Quella','Tirsa','Venna','Sostra','Marenta','Portoserra','Ondaro','Rivamare','Praia Velha','Vela Nova','Azzurra','Lido Isora','Ardo','Cala Vessa','Sabbiano','Santa Calla','Capo Lisso','Bellacosta']
tw=dict(towns)
RLu=unary_union([ln for g in ('main_roads','roads_double_fill') for _,ln in layer_lines(g,SVG)])
def inlow(p,m=6):
    x,y=int(p[0]/G),int(p[1]/G); return low[max(y-m,0):y+m+1,max(x-m,0):x+m+1].all()
for n in TOWNPRI:
    if n in tw and RLu.distance(Point(*tw[n]))<60 and inlow(tw[n]) and all(np.hypot(*(np.array(tw[n])-np.array(p)))>560 for p in pins): pins.append(tuple(tw[n]))
RL=[ln for g in ('main_roads','roads_double_fill') for _,ln in layer_lines(g,SVG)]
for ln in RL:
    for t in np.arange(0,ln.length,40):
        pt=ln.interpolate(t); pt=(pt.x,pt.y)
        if inlow(pt,7) and all(np.hypot(pt[0]-q[0],pt[1]-q[1])>600 for q in pins): pins.append(pt)
tp('lowland pinned seeds',len(pins),'mountain cells',nmount)
labl=lloyd(low,pins,TARGET-nmount,'lowland',iters=36,lo=LO)
Lz[labl>0]=labl[labl>0]+nxt
# unassigned zone pixels (lowland pockets without a seed) -> nearest province
miss=zone&(Lz==0)
if miss.any():
    _,(iy,ix)=ndi.distance_transform_edt(Lz==0,return_indices=True); Lz[miss]=Lz[iy[miss],ix[miss]]
Lz=fix_conn(Lz)
tp('geodesic partition cells',len(np.unique(Lz))-1)
# ---------- raster clean-up ----------
def lab_side(L,k,objs):
    sl=objs[k-1]; return max(sl[0].stop-sl[0].start,sl[1].stop-sl[1].start)*G
def smooth_labels(L,sig=3.0):
    best_=np.zeros(L.shape,np.float32); out=np.zeros_like(L); objs=ndi.find_objects(L); pad=int(4*sig)+2
    for k,sl in enumerate(objs,1):
        if sl is None: continue
        y0,y1,x0,x1=max(sl[0].start-pad,0),min(sl[0].stop+pad,H),max(sl[1].start-pad,0),min(sl[1].stop+pad,W)
        g=ndi.gaussian_filter((L[y0:y1,x0:x1]==k).astype(np.float32),sig)
        b=best_[y0:y1,x0:x1]; o=out[y0:y1,x0:x1]; upd=g>b; b[upd]=g[upd]; o[upd]=k
    out[L==0]=0
    return fix_conn(out)
ROADS=[ln for g in ('main_roads','roads_double_fill') for _,ln in layer_lines(g,SVG)]
def road_runs(L):
    """short visits of a road through a province -> list of (label, prev, next, points)"""
    out=[]
    for ln in ROADS:
        n=max(2,int(ln.length/8)); pts=[ln.interpolate(t*ln.length/n) for t in range(n+1)]
        lab=[int(L[min(int(p.y/G),H-1),min(int(p.x/G),W-1)]) for p in pts]
        runs=[]; s=0
        for i in range(1,len(lab)+1):
            if i==len(lab) or lab[i]!=lab[s]: runs.append((lab[s],s,i)); s=i
        for k,(l,a,b) in enumerate(runs):
            if l==0: continue
            prev=next((r[0] for r in reversed(runs[:k]) if r[0]>0),0); nxt=next((r[0] for r in runs[k+1:] if r[0]>0),0)
            if (b-a)*ln.length/n<220 and prev and nxt and prev!=l and nxt!=l and k>0 and k<len(runs)-1:
                out.append((l,prev,nxt,pts[a:b],(b-a)*ln.length/n))
    return out
def fix_road_runs(L,rounds=4):
    for _ in range(rounds):
        rr_=road_runs(L)
        if not rr_: break
        for l,prev,nxt,pts,ln_ in rr_:
            line=LineString([(p.x,p.y) for p in pts]) if len(pts)>1 else pts[0]
            reg=rast(line.buffer(170))&(L==l)
            if not reg.any(): continue
            # give the corridor to whichever neighbour (prev/next) is closer per pixel
            d1=ndi.distance_transform_edt(L!=prev); d2=ndi.distance_transform_edt(L!=nxt)
            L[reg&(d1<=d2)]=prev; L[reg&(d1>d2)]=nxt
        L=fix_conn(L)
    return L
Lz=fix_road_runs(Lz)
for _ in range(2): Lz=smooth_labels(Lz,3.0)
Lz=fix_road_runs(Lz,2)
tp('road short runs left',[(round(x[4])) for x in road_runs(Lz)])
# towns never sit on a border: a 115 map px disc around every Zille town/village joins the province that holds the town
for n,p in towns:
    cx,cy=int(p[0]/G),int(p[1]/G); r=int(115/G)
    y0,y1,x0,x1=max(cy-r,0),min(cy+r+1,H),max(cx-r,0),min(cx+r+1,W)
    yy,xx=np.mgrid[y0:y1,x0:x1]; disc=((yy-cy)**2+(xx-cx)**2<=r*r)&zone[y0:y1,x0:x1]
    inner=((yy-cy)**2+(xx-cx)**2<=(r//2)**2)
    v=Lz[y0:y1,x0:x1][inner&(Lz[y0:y1,x0:x1]>0)]
    if len(v)==0: continue
    k=np.bincount(v).argmax(); sub=Lz[y0:y1,x0:x1]; sub[disc]=k
Lz=fix_conn(Lz)
# ---------- vectorise + 64 px gaps ----------
P=label_polys(Lz)
cells=[dict(region='Zille',raw=p,kind='cell',type='land') for k,p in P.items() if not p.is_empty]
raws=[c['raw'] for c in cells]; tree=STRtree(raws)
ZV=ZONEV.intersection(ZSIDE.buffer(-32)).difference(BLOCK)
for i,c in enumerate(cells):
    p=c['raw']; base=p.buffer(70,join_style=1).intersection(ZV)
    near=[j for j in tree.query(p.buffer(140)) if j!=i]
    cut=unary_union([cells[j]['raw'].buffer(32) for j in near]) if near else Polygon()
    g0=base.difference(cut); g=g0
    for rr_ in (60,40,20,0):
        go=g0.buffer(-rr_,join_style=1).buffer(rr_,join_style=1) if rr_ else g0
        if not go.is_empty and biggest(go).area>=0.985*biggest(g0).area-1500: g=go; break
    g=biggest(g)
    if bbm(g)>FIN: g=boxclip(g,FIN)
    c['poly']=g
def remerge():
    global cells
    removed=set()
    for c in sorted([c for c in cells if bbm(c['poly'])<MINF],key=lambda c:c['poly'].area):
        if id(c) in removed: continue
        best_=None
        for o in cells:
            dist_=o['poly'].distance(c['poly'])
            if o is c or id(o) in removed or dist_>170: continue
            bw=max(75,dist_/2+25)
            Uu=unary_union([o['poly'],c['poly'],o['poly'].buffer(bw).intersection(c['poly'].buffer(bw)).intersection(ZV)])
            others=unary_union([q['poly'].buffer(64) for q in cells if q is not o and q is not c and id(q) not in removed and q['poly'].distance(Uu)<200])
            Uu=biggest(Uu.difference(others).buffer(-3).buffer(3))
            if bbm(Uu)<=FIN and (best_ is None or bbm(Uu)<best_[0]): best_=(bbm(Uu),o,Uu)
        if best_: best_[1]['poly']=best_[2]; best_[1]['raw']=unary_union([best_[1]['raw'],c['raw']]); removed.add(id(c)); tp('merged undersized cell',int(best_[0]))
    cells=[c for c in cells if id(c) not in removed]
remerge()
def fillholes(cells,zonev,others_fixed):
    n=0
    cov=unary_union([c['poly'] for c in cells]+[others_fixed]).buffer(70)
    Hh=zonev.difference(cov)
    for h_ in getattr(Hh,'geoms',[Hh]):
        if h_.area<8000: continue
        hp=h_.buffer(70).intersection(zonev); best_=None
        for c in cells:
            if c['poly'].distance(h_)>140: continue
            Uu=unary_union([c['poly'],hp.difference(unary_union([o['poly'].buffer(64) for o in cells if o is not c and o['poly'].distance(h_)<400]+[others_fixed.buffer(64)]))])
            Uu=biggest(Uu.buffer(20).buffer(-20))
            if bbm(Uu)<=FIN and (best_ is None or Uu.area<best_[0]): best_=(Uu.area,c,Uu)
        if best_: best_[1]['poly']=best_[2]; n+=1
    return n
FIXP=unary_union([c['poly'] for c in FIXED+BREN])
for _ in range(3):
    k=fillholes(cells,ZONEV.intersection(ZSIDE.buffer(-32)),FIXP); tp('holes filled',k)
    if not k: break
lb=[bbm(c['poly']) for c in cells]
tp('Zille free cells',len(cells),'bbox min/med/max',int(min(lb)),int(np.median(lb)),int(max(lb)))
pickle.dump(dict(zille=cells,fixed=FIXED,brenas=BREN,MN=MN,Lz=Lz,SP=SP,E=E,seed=SEED),open(f'work13/land13_s{SEED}.pkl','wb'))
