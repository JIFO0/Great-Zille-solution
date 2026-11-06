"""v14 shared partition toolkit (same method as v13 prov13_land.py / prov13r_brenas.py): geodesic capacity-constrained
Voronoi on an 8 px grid (travel cost: roads cheap, rivers / steep slopes expensive), Lloyd relaxation with additive
weights and a FIXED cell count, massifs partitioned separately, road short-run clean-up, town discs, 64 px vector gaps."""
import numpy as np, io, time, cairosvg, sys
from scipy import ndimage as ndi
from skimage.graph import MCP_Geometric
from shapely.geometry import Point, Polygon, LineString, box
from shapely.ops import unary_union
from shapely.strtree import STRtree
from PIL import Image, ImageDraw
Image.MAX_IMAGE_PIXELS=None
sys.path.insert(0,'/workspace/zille/versions/v13/scripts')
from topo_noise import fbm
G=8; W,H=12288//G,8192//G
T0=time.time()
def tp(*a): print('[%.0fs]'%(time.time()-T0),*a,flush=True)
def bbm(g): b=g.bounds; return max(b[2]-b[0],b[3]-b[1])
def biggest(g):
    if g.is_empty: return g
    return max([q for q in g.geoms if q.geom_type=='Polygon'],key=lambda q:q.area) if hasattr(g,'geoms') else g
def rast(geom):
    im=Image.new('L',(W,H),0); d=ImageDraw.Draw(im)
    for p in getattr(geom,'geoms',[geom]):
        if p.is_empty or p.geom_type!='Polygon': continue
        d.polygon([(x/G,y/G) for x,y in p.exterior.coords],fill=255)
        for r in p.interiors: d.polygon([(x/G,y/G) for x,y in r.coords],fill=0)
    return np.asarray(im)>0
def gmask(svg,gids,group):
    body=''.join(group(g,svg) for g in gids)
    s=f'<svg xmlns="http://www.w3.org/2000/svg" width="{W}" height="{H}" viewBox="0 0 12288 8192">{body}</svg>'
    im=Image.open(io.BytesIO(cairosvg.svg2png(bytestring=s.encode(),output_width=W,output_height=H))).convert('RGBA')
    return np.asarray(im)[:,:,3]/255.0
def fix_conn(Lg):
    for _ in range(3):
        ch=False; objs=ndi.find_objects(Lg)
        for i,sl in enumerate(objs):
            if sl is None: continue
            sl=(slice(max(sl[0].start-3,0),sl[0].stop+3),slice(max(sl[1].start-3,0),sl[1].stop+3))
            sub=Lg[sl]; m=sub==i+1; lab,k=ndi.label(m)
            if k<=1: continue
            sizes=ndi.sum(m,lab,range(1,k+1)); keep=np.argmax(sizes)+1
            for j in range(1,k+1):
                if j==keep: continue
                piece=lab==j; ring=ndi.binary_dilation(piece,iterations=2)&~piece
                nb=sub[ring]; nb=nb[(nb>0)&(nb!=i+1)]
                sub[piece]=np.bincount(nb).argmax() if len(nb) else 0; ch=True
        if not ch: break
    return Lg
from skimage import measure
def mask_poly(m,off,sig=1.1):
    y0,x0=off; sub=ndi.gaussian_filter(np.pad(m.astype(float),3),sig)
    cs=measure.find_contours(sub,0.5); polys=[]
    for c in cs:
        xy=np.stack([(c[:,1]-3+x0+0.5)*G,(c[:,0]-3+y0+0.5)*G],1)
        if len(xy)>=5:
            p=Polygon(xy).buffer(0)
            if p.area>1500: polys.append(p)
    if not polys: return Polygon()
    polys.sort(key=lambda p:-p.area); g=polys[0]
    for p in polys[1:]: g=g.difference(p) if g.contains(p.representative_point()) else g
    return biggest(g)
def label_polys(Lg):
    out={}
    for i,sl in enumerate(ndi.find_objects(Lg)):
        if sl is None: continue
        sl=(slice(max(sl[0].start-1,0),sl[0].stop+1),slice(max(sl[1].start-1,0),sl[1].stop+1))
        out[i+1]=mask_poly(Lg[sl]==i+1,(sl[0].start,sl[1].start))
    return out
def boxclip(g,b):
    x0,y0,x1,y1=g.bounds; cx,cy=(x0+x1)/2,(y0+y1)/2
    return biggest(g.intersection(box(cx-b/2,cy-b/2,cx+b/2,cy+b/2)))
class Part:
    def __init__(s,COST,seed,LIMR=880,MINF=425,FIN=860):
        s.COST=COST; s.rng=np.random.default_rng(seed); s.LIMR=LIMR; s.MINF=MINF; s.FIN=FIN
    def poisson(s,zone,r,fixed):
        ys,xs=np.nonzero(zone); idx=s.rng.permutation(len(ys)); acc=list(fixed); hsh={}; cell=r/1.5
        for (x,y) in fixed: hsh.setdefault((int(x//cell),int(y//cell)),[]).append((x,y))
        for i in idx[:80000]:
            x,y=(xs[i]+s.rng.random())*G,(ys[i]+s.rng.random())*G; cx,cy=int(x//cell),int(y//cell); ok=True
            for dx in (-2,-1,0,1,2):
                for dy in (-2,-1,0,1,2):
                    for (px,py) in hsh.get((cx+dx,cy+dy),()):
                        if (px-x)**2+(py-y)**2<r*r: ok=False; break
                    if not ok: break
                if not ok: break
            if ok: acc.append((x,y)); hsh.setdefault((cx,cy),[]).append((x,y))
        return acc
    def geo_labels(s,seeds,zm,R=1150,wts=None):
        best_=np.full((H,W),np.inf); lab=np.zeros((H,W),np.int32); r=int(R/G)
        C=np.where(zm,s.COST,1e6)
        for i,(x,y) in enumerate(seeds):
            cx,cy=int(x/G),int(y/G); y0,y1,x0,x1=max(cy-r,0),min(cy+r,H),max(cx-r,0),min(cx+r,W)
            m=MCP_Geometric(C[y0:y1,x0:x1]); D,_=m.find_costs([(cy-y0,cx-x0)])
            D=D-(wts[i] if wts is not None else 0)
            bb=best_[y0:y1,x0:x1]; ll=lab[y0:y1,x0:x1]; upd=(D<bb)&zm[y0:y1,x0:x1]&(D<5e5); bb[upd]=D[upd]; ll[upd]=i+1
        lab[~zm]=0
        miss=zm&(lab==0)
        if miss.any():
            _,(iy,ix)=ndi.distance_transform_edt(lab==0,return_indices=True); lab[miss]=lab[iy[miss],ix[miss]]
        return fix_conn(lab)
    def lloyd(s,zm,pins,NS,name,iters=30,lo=570):
        """fixed cell count NS; pins (towns / road points) stay put"""
        seeds=list(pins)[:NS]; npin=len(seeds)
        if NS>len(seeds):
            free=s.poisson(zm,300,seeds)[len(seeds):]; s.rng.shuffle(free); seeds+=free[:NS-len(seeds)]
        WT=[0.0]*len(seeds); LIMR=s.LIMR; BEST=None
        for it in range(iters):
            lab=s.geo_labels(seeds,zm,wts=WT)
            objs=ndi.find_objects(lab); sides=[]; new=list(seeds); seeds_used=list(seeds); WT_used=list(WT)
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
            sc_=(sum(max(0,x-LIMR) for x in sides)+sum(max(0,lo-x) for x in sides if x>0)+1e4*sides.count(0))
            if BEST is None or sc_<BEST[0]: BEST=(sc_,seeds_used,WT_used,list(sides))
            for i,s_ in enumerate(sides):
                if 0<s_<lo: WT[i]+=5+0.05*(lo-s_)
                elif s_>LIMR: WT[i]-=8
                elif s_>800: WT[i]-=4
                WT[i]*=0.97
            for i in [i for i,s_ in enumerate(sides) if s_==0]:
                j=int(np.argmax(sides)); mm=lab==j+1; ys,xs=np.nonzero(mm); P2=np.stack([xs,ys],1)*G+G/2; c=P2.mean(0)
                far=P2[np.argmax(np.hypot(*(P2-c).T))]; seeds[i]=tuple(c+(far-c)*0.55); WT[i]=0.0; sides[i]=1
            big=[i for i,s_ in enumerate(sides) if s_>LIMR]
            for i in big:
                mm=lab==i+1; ys,xs=np.nonzero(mm); P2=np.stack([xs,ys],1)*G+G/2; c=P2.mean(0)
                ev=np.linalg.eigh(np.cov((P2-c).T))[1][:,-1]; t=(P2-c)@ev
                a_=P2[np.argmin(np.abs(t-np.quantile(t,0.25)))]; b_=P2[np.argmin(np.abs(t-np.quantile(t,0.75)))]
                if i>=npin: seeds[i]=tuple(a_)
                cand=[j for j in range(npin,len(sides)) if j!=i and j not in big]
                if cand: j=min(cand,key=lambda j:sides[j]); seeds[j]=tuple(b_); WT[j]=0.0; sides[j]=LIMR
            if it>=10 and not big and min(sides)>=lo-25: break
        _,seeds,WT,sides=BEST
        tp(name,'iters',it,'cells',len(seeds),'best side min/med/max',int(min(sides)),int(np.median(sides)),int(max(sides)),'score',int(BEST[0]))
        s.seeds=seeds; s.WT=WT
        return s.geo_labels(seeds,zm,wts=WT)
def smooth_labels(L,sig=3.0,keep=None):
    best_=np.zeros(L.shape,np.float32); out=np.zeros_like(L); objs=ndi.find_objects(L); pad=int(4*sig)+2
    for k,sl in enumerate(objs,1):
        if sl is None: continue
        y0,y1,x0,x1=max(sl[0].start-pad,0),min(sl[0].stop+pad,H),max(sl[1].start-pad,0),min(sl[1].stop+pad,W)
        g=ndi.gaussian_filter((L[y0:y1,x0:x1]==k).astype(np.float32),sig)
        b=best_[y0:y1,x0:x1]; o=out[y0:y1,x0:x1]; upd=g>b; b[upd]=g[upd]; o[upd]=k
    out[L==0]=0
    if keep is not None: out[keep>0]=keep[keep>0]
    return fix_conn(out)
def road_runs(L,ROADS,minrun=220):
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
            if (b-a)*ln.length/n<minrun and prev and nxt and prev!=l and nxt!=l and k>0 and k<len(runs)-1:
                out.append((l,prev,nxt,pts[a:b],(b-a)*ln.length/n))
    return out
def fix_road_runs(L,ROADS,rounds=4,frozen=()):
    for _ in range(rounds):
        rr_=[r for r in road_runs(L,ROADS) if r[0] not in frozen]
        if not rr_: break
        for l,prev,nxt,pts,ln_ in rr_:
            line=LineString([(p.x,p.y) for p in pts]) if len(pts)>1 else pts[0]
            reg=rast(line.buffer(170))&(L==l)
            if not reg.any(): continue
            d1=ndi.distance_transform_edt(L!=prev); d2=ndi.distance_transform_edt(L!=nxt)
            if prev in frozen: reg&=False
            L[reg&(d1<=d2)]=prev if prev not in frozen else l; L[reg&(d1>d2)]=nxt if nxt not in frozen else l
        L=fix_conn(L)
    return L
def town_discs(L,towns,zone,r_map=115,frozen=()):
    for n,p in towns:
        cx,cy=int(p[0]/G),int(p[1]/G); r=int(r_map/G)
        y0,y1,x0,x1=max(cy-r,0),min(cy+r+1,H),max(cx-r,0),min(cx+r+1,W)
        yy,xx=np.mgrid[y0:y1,x0:x1]; sub=L[y0:y1,x0:x1]
        disc=((yy-cy)**2+(xx-cx)**2<=r*r)&zone[y0:y1,x0:x1]&~np.isin(sub,list(frozen))
        inner=((yy-cy)**2+(xx-cx)**2<=(r//2)**2)
        v=sub[inner&(sub>0)]
        if len(v)==0: continue
        k=np.bincount(v).argmax()
        if k in frozen: continue
        sub[disc]=k
    return fix_conn(L)
def contacts(L):
    cnt={}
    for a_,b_ in ((L[:,:-1],L[:,1:]),(L[:-1,:],L[1:,:])):
        m=(a_!=b_)&(a_>0)&(b_>0)
        for x,y in zip(a_[m],b_[m]):
            k=(min(x,y),max(x,y)); cnt[k]=cnt.get(k,0)+1
    return cnt
def resolve_weak(L,minc=22,frozen=()):
    for rnd in range(4):
        cnt=contacts(L); weak=[(k,v) for k,v in cnt.items() if v<minc]
        if not weak: break
        for (a_,b_),v in weak:
            ma=ndi.binary_dilation(L==a_,iterations=1)&(L==b_); ys,xs=np.nonzero(ma)
            if len(ys)==0: continue
            cy,cx=ys.mean(),xs.mean(); r=int(110/G)
            y0,y1,x0,x1=max(int(cy)-r,0),min(int(cy)+r+1,H),max(int(cx)-r,0),min(int(cx)+r+1,W)
            sub=L[y0:y1,x0:x1]; yy,xx=np.mgrid[y0:y1,x0:x1]; disc=((yy-cy)**2+(xx-cx)**2<=r*r)
            oth=(sub>0)&(sub!=a_)&(sub!=b_)
            if not oth.any(): continue
            _,(iy,ix)=ndi.distance_transform_edt(~oth,return_indices=True)
            tgt=disc&((sub==a_)|(sub==b_))&~np.isin(sub,list(frozen)); sub[tgt]=sub[iy[tgt],ix[tgt]]
        L=fix_conn(L)
    return L
def vectorise(L,ZV,region,FIN=860,MINF=425,fixed_polys=()):
    P=label_polys(L)
    cells=[dict(region=region,raw=p,kind='cell',type='land',lab=k) for k,p in P.items() if not p.is_empty]
    raws=[c['raw'] for c in cells]; tree=STRtree(raws)
    FX=unary_union([f.buffer(64,join_style=1) for f in fixed_polys]) if fixed_polys else Polygon()
    for i,c in enumerate(cells):
        p=c['raw']; base=p.buffer(70,join_style=1).intersection(ZV).difference(FX)
        near=[j for j in tree.query(p.buffer(140)) if j!=i]
        cut=unary_union([cells[j]['raw'].buffer(32) for j in near]) if near else Polygon()
        g0=base.difference(cut); g=g0
        for rr_ in (60,40,20,0):
            go=g0.buffer(-rr_,join_style=1).buffer(rr_,join_style=1) if rr_ else g0
            if not go.is_empty and biggest(go).area>=0.985*biggest(g0).area-1500: g=go; break
        g=biggest(g)
        if bbm(g)>FIN: g=boxclip(g,FIN)
        c['poly']=g
    return cells
def fillholes(cells,zonev,others_fixed,amin=8000,FIN=860):
    n=0
    cov=unary_union([c['poly'] for c in cells]+[others_fixed]).buffer(70)
    Hh=zonev.difference(cov)
    for h_ in getattr(Hh,'geoms',[Hh]):
        if h_.is_empty or h_.area<amin: continue
        hp=h_.buffer(70).intersection(zonev); best_=None
        for c in cells:
            if c['poly'].distance(h_)>140: continue
            Uu=unary_union([c['poly'],hp.difference(unary_union([o['poly'].buffer(64) for o in cells if o is not c and o['poly'].distance(h_)<400]+[others_fixed.buffer(64)]))])
            Uu=biggest(Uu.buffer(20).buffer(-20))
            if bbm(Uu)<=FIN and (best_ is None or Uu.area<best_[0]): best_=(Uu.area,c,Uu)
        if best_: best_[1]['poly']=best_[2]; n+=1
    return n
def _sides(L):
    out={}
    for k,sl in enumerate(ndi.find_objects(L),1):
        if sl is None: continue
        out[k]=(sl,max(sl[0].stop-sl[0].start,sl[1].stop-sl[1].start)*G)
    return out
def _pairs(L):
    P=set()
    for a,b in ((L[:,1:],L[:,:-1]),(L[1:,:],L[:-1,:])):
        m=(a>0)&(b>0)&(a!=b)
        for x,y in zip(a[m],b[m]): P.add((min(x,y),max(x,y)))
    return P
def _contact(L,a,b):
    A=(L==a); B=ndi.binary_dilation(L==b); return int((A&B).sum())
def enforce_size(L,NS,LIM=820,MERGE_LIM=780,frozen=(),name=''):
    """raster level: split cells whose bbox side > LIM along their principal axis, then merge the adjacent pairs with the
    smallest union bbox until the count is back to NS (only if that union stays <= MERGE_LIM)."""
    L=L.copy(); frozen=set(frozen)
    for _ in range(40):
        S=_sides(L); big=[k for k,(sl,s) in S.items() if s>LIM and k not in frozen]
        if not big: break
        k=max(big,key=lambda k:S[k][1]); sl=S[k][0]; mm=L[sl]==k; ys,xs=np.nonzero(mm)
        P2=np.stack([xs,ys],1).astype(float); c=P2.mean(0); ev=np.linalg.eigh(np.cov((P2-c).T))[1][:,-1]; t=(P2-c)@ev
        nk=L.max()+1; sub=L[sl]; sel=np.zeros_like(mm); sel[ys[t>np.median(t)],xs[t>np.median(t)]]=True; sub[sel]=nk
        L=fix_conn(L)
    n=len(_sides(L)); tp(name,'after splits',n)
    while n>NS:
        S=_sides(L); best=None
        for a,b in _pairs(L):
            if a in frozen or b in frozen: continue
            sa,sb=S[a][0],S[b][0]
            y0,y1=min(sa[0].start,sb[0].start),max(sa[0].stop,sb[0].stop); x0,x1=min(sa[1].start,sb[1].start),max(sa[1].stop,sb[1].stop)
            s=max(y1-y0,x1-x0)*G
            if s<=MERGE_LIM and (best is None or s<best[0]): best=(s,a,b)
        if best is None: break
        L[L==best[2]]=best[1]; n-=1
    # relabel 1..n
    u=[k for k in np.unique(L) if k>0]; R=np.zeros(L.max()+1,np.int32)
    for i,k in enumerate(u,1): R[k]=i
    L=R[L]; tp(name,'enforce_size cells',len(u),'max side',max(s for _,s in _sides(L).values()))
    return L
