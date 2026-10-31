"""v13 review 1: Brenas re-partition (owner request: fit roads and mountains, clear shapes around Marbelas 64, nothing across
the Rizia/Zille border, larger city-shaped Dapalle). Same geodesic capacity-constrained Voronoi as the Zille cells
(prov13_land.py): roads cheap, rivers/steep slopes expensive, seeds pinned on towns and main/secondary roads, massifs
partitioned on their own, road short-run clean-up, 115 px town discs, 64 px vector gaps.
 - zone: ZONEV inside RSIDE.buffer(-32)  -> every Brenas province is fully on the Rizian side (gap 64 to the Zille side)
 - Mave Nortus 23 kept as built in prov13_land.py; Dapalle 51 rebuilt as a lobed city (bbox ~500, extent > 512)
 - ids: Hungarian overlap with the previous v13 Brenas cells (40-50, 52-67)
 - Zille cells that bordered the old overhangs are grown into the freed strip (fillholes)
usage: prov13r_brenas.py SEED TARGET LO   -> work13/land13r_s{SEED}.pkl"""
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
FIN=860; MINF=425; LIMR=int(sys.argv[5]) if len(sys.argv)>5 else 880; DAPB=int(sys.argv[4]) if len(sys.argv)>4 else 500
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

def blob(cx,cy,r,rr):
    a,b,c2=rr.uniform(0,2*np.pi,3); t=np.linspace(0,2*np.pi,72,endpoint=False)
    rad=r*(1+0.22*np.sin(2*t+a)+0.14*np.sin(3*t+b)+0.08*np.sin(5*t+c2))
    return Polygon(np.stack([cx+rad*np.cos(t),cy+rad*np.sin(t)],1))
LD=pickle.load(open('work13/land13.pkl','rb')); MN=LD['MN']
OLDB={c['id']:c for c in LD['brenas']}
RZ=ZONEV.intersection(RSIDE.buffer(-32))
RZ=unary_union([q for q in getattr(RZ,'geoms',[RZ]) if q.area>20000])
# ---------------- Dapalle city (lobed, along the Ostrabe road, away from the border) ----------------
D0=np.array([9567.0,5524.0])
RZD=RZ.difference(MN.buffer(64))
ang=np.radians(np.arange(0,360,10)); free=[]
for a in ang:
    ray=LineString([tuple(D0),tuple(D0+420*np.array([np.cos(a),np.sin(a)]))]); free.append(ray.intersection(RZD).length)
free=np.array(free)
ROADA=np.radians(20)       # the minor road to Ostrabe leaves Dapalle to the ENE
arms=[(ROADA,0.80,0.36)]
for _ in range(2):
    sc_=[free[k]-400*any(abs(((ang[k]-a+np.pi)%(2*np.pi))-np.pi) < np.radians(75) for a,_,_ in arms) for k in range(len(ang))]
    k=int(np.argmax(sc_)); arms.append((ang[k],0.70,0.34))
tp('Dapalle arms (deg)',[int(np.degrees(a)) for a,_,_ in arms])
UD=Point(*D0).buffer(70)
best=None
for sc in range(150,900,10):
    parts=[UD.buffer(0.30*sc,join_style=1)]
    for a,d,r in arms:
        ex,ey=D0[0]+sc*d*np.cos(a),D0[1]+sc*d*np.sin(a)
        parts.append(LineString([tuple(D0),(ex,ey)]).buffer(sc*r*0.75)); parts.append(blob(ex,ey,sc*r,np.random.default_rng(int(a*1000)%9999)))
    g=unary_union(parts).buffer(0.04*sc,join_style=1).buffer(-0.06*sc,join_style=1).buffer(0.02*sc,join_style=1).intersection(RZD)
    if g.is_empty: continue
    g=max([q for q in getattr(g,'geoms',[g]) if q.geom_type=='Polygon'],key=lambda q:q.distance(Point(*D0))*-1)
    g=biggest(g.buffer(-10,join_style=1).buffer(10,join_style=1))
    if bbm(g)>FIN: break
    best=(sc,g)
    if bbm(g)>=DAPB: break
DP=best[1]; assert DP.difference(RSIDE).area<1 and DP.contains(Point(*D0))
tp('Dapalle city bbox',int(bbm(DP)),'area',int(DP.area))
dp=dict(OLDB['ZilleTile_51']); dp.update(poly=DP,raw=DP,note='v13 review 1: Dapalle enlarged (city lobes along the Ostrabe road and into Rizia, fully on the Rizian side)')
mn=OLDB['ZilleTile_23']
FIXB=[mn,dp]
BLOCK=unary_union([c['poly'].buffer(64,join_style=1) for c in FIXB])
ZR=RZ.difference(BLOCK); ZR=unary_union([q for q in getattr(ZR,'geoms',[ZR]) if q.area>20000])
zone=rast(ZR)
tp('Brenas free zone %.2fM'%(ZR.area/1e6))
towns=[(n,p) for n,p,t in SETT if ZR.buffer(-8).contains(Point(*p))]
tp('towns',[n for n,_ in towns])

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
            if len(seeds)<NS: seeds.append(tuple(b_)); WT.append(0.0)
            else:   # Brenas: fixed count -> relocate the smallest free cell's seed into the oversized cell
                cand=[j for j in range(npin,len(sides)) if j!=i and j not in big]
                if cand: j=min(cand,key=lambda j:sides[j]); seeds[j]=tuple(b_); WT[j]=0.0; sides[j]=LIMR
        while len(seeds)>NS and small:
            j=min(small,key=lambda j:sides[j]); small.remove(j); seeds.pop(j); sides.pop(j); WT.pop(j); small=[k-1 if k>j else k for k in small]
        # Brenas: keep the cell count at NS (a split of an oversized cell removes the smallest free cell instead of adding one)
        while len(seeds)>NS and it<28:
            j=min(range(npin,len(sides)),key=lambda j:sides[j]); seeds.pop(j); sides.pop(j); WT.pop(j)
        if it>=10 and not big and min(sides)>=lo-25: break
    tp(name,'iters',it,'cells',len(seeds),'side min/med/max',int(min(sides)),int(np.median(sides)),int(max(sides)))
    return geo_labels(seeds,zm,wts=WT)
T_=np.array([0.07,0.15,0.23,0.31,0.40,0.50,0.61,0.73]); band=np.searchsorted(T_,h13)
hm=ndi.gaussian_filter(h13,2.0)
MM=ndi.binary_fill_holes(ndi.binary_opening((hm>=0.20)&zone,iterations=3))&zone
ml,mn_=ndi.label(MM); MZ=[]
for i,sl in enumerate(ndi.find_objects(ml),1):
    mm=ml==i; a=mm.sum()*G*G; ys,xs=np.nonzero(mm); side=max(np.ptp(ys)+1,np.ptp(xs)+1)*G
    if a<150000 or side<520: continue
    MZ.append((mm,a,side))
tp('massif zones',[(int(a),int(s)) for _,a,s in MZ])


def lloyd_area(zm,pins,NS,name,iters=45):
    """Brenas: capacity-constrained geodesic Lloyd on AREA (every cell -> zone area / NS); oversized bboxes shrink."""
    seeds=list(pins); npin=len(pins)
    free=poisson(zm,300,rng,pins)[len(pins):]; rng.shuffle(free); seeds+=free[:NS-len(seeds)]
    WT=np.zeros(len(seeds)); At=zm.sum()/NS
    for it in range(iters):
        lab=geo_labels(seeds,zm,wts=WT); objs=ndi.find_objects(lab,max_label=len(seeds))
        A=np.bincount(lab.ravel(),minlength=len(seeds)+1)[1:]; sides=np.zeros(len(seeds))
        for i in range(len(seeds)):
            sl=objs[i]
            if sl is None: continue
            mm=lab[sl]==i+1; ys,xs=np.nonzero(mm); sides[i]=max(np.ptp(ys)+1,np.ptp(xs)+1)*G
            if i>=npin:
                c=np.array([(xs.mean()+sl[1].start+0.5)*G,(ys.mean()+sl[0].start+0.5)*G])
                if not zm[min(int(c[1]/G),H-1),min(int(c[0]/G),W-1)]:
                    k=np.argmin(np.hypot(xs+sl[1].start-c[0]/G,ys+sl[0].start-c[1]/G)); c=np.array([(xs[k]+sl[1].start+0.5)*G,(ys[k]+sl[0].start+0.5)*G])
                seeds[i]=tuple(0.5*np.array(seeds[i])+0.5*c)
        WT+=4.0*np.clip(1-A/At,-1,1)
        WT[sides>LIMR]-=3
        for i in np.nonzero(A==0)[0]:
            j=int(np.argmax(A)); mm=lab==j+1; ys,xs=np.nonzero(mm); P2=np.stack([xs,ys],1)*G+G/2; c=P2.mean(0)
            far=P2[np.argmax(np.hypot(*(P2-c).T))]; seeds[i]=tuple(c+(far-c)*0.55); WT[i]=WT[j]
    tp(name,'cells',len(seeds),'area/target min/max %.2f %.2f'%(A.min()/At,A.max()/At),'side min/med/max',int(sides.min()),int(np.median(sides)),int(sides.max()))
    return geo_labels(seeds,zm,wts=WT)

Lz=np.zeros((H,W),np.int32); nxt=0; nmount=0
for mm,a,side in MZ:
    n=max(1,int(round(a/330000)))
    if n==1 and side>LIMR: n=2
    lab=lloyd(mm,[],n,'massif %dk'%(a/1000),iters=20,lo=520) if n>1 else mm.astype(np.int32)
    Lz[lab>0]=lab[lab>0]+nxt; nxt=Lz.max(); nmount+=n
low=zone&(Lz==0)
pins=[]
TOWNPRI=['Marbelas','Brivane','Morsa','Ostrabe','Zelles','Tarnes','Celle Vaz','Costa Dalle','Isalba','Vallas','Dravis','Areias','Balle']
tw=dict(towns)
RLu=unary_union([ln for g in ('main_roads','roads_double_fill') for _,ln in layer_lines(g,SVG)])
def inlow(p,m=6):
    x,y=int(p[0]/G),int(p[1]/G); return low[max(y-m,0):y+m+1,max(x-m,0):x+m+1].all()
for n in TOWNPRI:
    if n in tw and inlow(tw[n],4) and all(np.hypot(*(np.array(tw[n])-np.array(p)))>560 for p in pins): pins.append(tuple(tw[n]))
RL=[ln for g in ('main_roads','roads_double_fill') for _,ln in layer_lines(g,SVG)]
for ln in RL:
    for t in np.arange(0,ln.length,40):
        pt=ln.interpolate(t); pt=(pt.x,pt.y)
        if inlow(pt,7) and all(np.hypot(pt[0]-q[0],pt[1]-q[1])>620 for q in pins): pins.append(pt)
tp('lowland pinned seeds',len(pins),'mountain cells',nmount)
labl=lloyd_area(low,pins,TARGET-nmount,'lowland')
Lz[labl>0]=labl[labl>0]+nxt
miss=zone&(Lz==0)
if miss.any():
    _,(iy,ix)=ndi.distance_transform_edt(Lz==0,return_indices=True); Lz[miss]=Lz[iy[miss],ix[miss]]
Lz=fix_conn(Lz)

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
# ---- clear contacts (owner request, esp. around Marbelas 64): a pair of cells that touches only at a corner / over a very
#      short stretch (< ~180 map px of raster border) is resolved: the cells around that junction take the corner, so the
#      remaining borders are unambiguous
def contacts(L):
    cnt={}
    for a_,b_ in ((L[:,:-1],L[:,1:]),(L[:-1,:],L[1:,:])):
        m=(a_!=b_)&(a_>0)&(b_>0)
        for x,y in zip(a_[m],b_[m]):
            k=(min(x,y),max(x,y)); cnt[k]=cnt.get(k,0)+1
    return cnt
for rnd in range(4):
    cnt=contacts(Lz); weak=[(k,v) for k,v in cnt.items() if v<22]
    if not weak: break
    for (a_,b_),v in weak:
        ma=ndi.binary_dilation(Lz==a_,iterations=1)&(Lz==b_); ys,xs=np.nonzero(ma)
        if len(ys)==0: continue
        cy,cx=ys.mean(),xs.mean(); r=int(110/G)
        y0,y1,x0,x1=max(int(cy)-r,0),min(int(cy)+r+1,H),max(int(cx)-r,0),min(int(cx)+r+1,W)
        sub=Lz[y0:y1,x0:x1]; yy,xx=np.mgrid[y0:y1,x0:x1]; disc=((yy-cy)**2+(xx-cx)**2<=r*r)
        oth=(sub>0)&(sub!=a_)&(sub!=b_)
        if not oth.any(): continue
        _,(iy,ix)=ndi.distance_transform_edt(~oth,return_indices=True)
        tgt=disc&((sub==a_)|(sub==b_)); sub[tgt]=sub[iy[tgt],ix[tgt]]
    Lz=fix_conn(Lz)
    tp('weak contacts resolved',[(int(k[0]),int(k[1]),v) for k,v in weak])
tp('weak contacts left',[(k,v) for k,v in contacts(Lz).items() if v<22])
P=label_polys(Lz)
cells=[dict(region='Brenas',raw=p,kind='cell',type='land') for k,p in P.items() if not p.is_empty]

raws=[c['raw'] for c in cells]; tree=STRtree(raws)
ZV=ZR

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
def fillholes(cells,zonev,others_fixed,amin=8000):
    n=0
    cov=unary_union([c['poly'] for c in cells]+[others_fixed]).buffer(70)
    Hh=zonev.difference(cov)
    for h_ in getattr(Hh,'geoms',[Hh]):
        if h_.area<amin: continue
        hp=h_.buffer(70).intersection(zonev); best_=None
        for c in cells:
            if c['poly'].distance(h_)>140: continue
            Uu=unary_union([c['poly'],hp.difference(unary_union([o['poly'].buffer(64) for o in cells if o is not c and o['poly'].distance(h_)<400]+[others_fixed.buffer(64)]))])
            Uu=biggest(Uu.buffer(20).buffer(-20))
            if bbm(Uu)<=FIN and (best_ is None or Uu.area<best_[0]): best_=(Uu.area,c,Uu)
        if best_: best_[1]['poly']=best_[2]; n+=1
    return n

for _ in range(3):
    k=fillholes(cells,RZ,unary_union([c['poly'] for c in FIXB])); tp('holes filled',k)
    if not k: break
lb=[bbm(c['poly']) for c in cells]
tp('Brenas free cells',len(cells),'bbox min/med/max',int(min(lb)),int(np.median(lb)),int(max(lb)))
assert all(c['poly'].difference(RSIDE.buffer(-31)).area<1 for c in cells+FIXB)
# ---------------- ids: Hungarian overlap with the previous v13 Brenas cells ----------------
from scipy.optimize import linear_sum_assignment
OLDC=[c for i,c in OLDB.items() if i not in ('ZilleTile_23','ZilleTile_51')]
Mx=np.array([[c['poly'].intersection(o['poly']).area for o in OLDC] for c in cells])
ri,cj=linear_sum_assignment(-Mx); nid={}
for i,j in zip(ri,cj):
    if Mx[i,j]>0: nid[i]=OLDC[j]['id']
nx_=119
for i in range(len(cells)):
    if i not in nid: nid[i]=f'ZilleTile_{nx_}'; nx_+=1
for i,c in enumerate(cells): c.update(id=nid[i],note='v13 review 1: Brenas re-partitioned (roads/relief aware)')
tp('unused old Brenas ids',sorted(set(o['id'] for o in OLDC)-set(nid.values())),'new ids',[v for v in nid.values() if int(v.split('_')[1])>=119])
BREN=sorted(cells+FIXB,key=lambda c:int(c['id'].split('_')[1]))
# ---------------- Zille cells grow into the strip freed by the old overhangs ----------------
ZC=LD['zille']; FIXZ=unary_union([c['poly'] for c in LD['fixed']+BREN])
cells=ZC
for _ in range(3):
    k=fillholes(ZC,ZONEV.intersection(ZSIDE.buffer(-32)),FIXZ,amin=300); tp('Zille holes filled',k)
    if not k: break
assert all(c['poly'].difference(ZSIDE.buffer(-31)).area<1 for c in ZC)
out=dict(LD); out.update(brenas=BREN,zille=ZC,DP=DP,LzB=Lz,seedB=SEED)
pickle.dump(out,open(f'work13/land13r_s{SEED}.pkl','wb'))
