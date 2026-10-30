"""v6 game provinces: land (Zille peninsula, northern Brenas, coastal Wehlen) + sea (the channel).
Land: Lloyd-relaxed, domain-warped Voronoi on a grid (G px), city provinces fixed around urban areas.
Sea: exact polygonal Voronoi (shapely), Lloyd-relaxed, angular, clipped to the sea with a coastal gap.
Every shape bbox <= MAXB. Output work/prov6.pkl"""
import numpy as np, pickle
from scipy import ndimage as ndi
from scipy.spatial import cKDTree
from shapely.geometry import Polygon, Point, box, MultiPoint, MultiPolygon
from shapely.ops import unary_union, voronoi_diagram
from skimage import measure
from PIL import Image, ImageDraw
from topo_noise import fbm
G=8; W,H=12288//G,8192//G
MAXB=440; GAP=34
TA=dict(Zille=138000,Brenas=138000,Wehlen=140000,Sea=130000)
reg=np.load('work/topo_reg.npy'); names=pickle.load(open('work/topo_names.pkl','rb'))
dd=pickle.load(open('work/land_dec.pkl','rb')); LAND=unary_union([dd['Ld']]+dd['islets'])
LIN=LAND.buffer(-14)
C=pickle.load(open('work/cities6.pkl','rb')); URB=C['URBG']
FRAME=box(265+30,276+30,12023-30,7907-30)
def rast(geom):
    im=Image.new('L',(W,H),0); d=ImageDraw.Draw(im)
    for p in getattr(geom,'geoms',[geom]):
        if p.is_empty or p.geom_type!='Polygon': continue
        d.polygon([(x/G,y/G) for x,y in p.exterior.coords],fill=255)
        for r in p.interiors: d.polygon([(x/G,y/G) for x,y in r.coords],fill=0)
    return np.asarray(im)>0
landm=rast(LIN.intersection(FRAME)); seam=~rast(LAND)
Yg,Xg=np.mgrid[0:H,0:W]; X=(Xg+0.5)*G; Y=(Yg+0.5)*G
R=lambda n:reg==names.index(n)
pen0=R('peninsula'); ol0=R('olive'); we0=R('wehlen')
# fill unlabelled land ('none'/'other') from the nearest labelled class, then smooth the peninsula/Brenas split
_lab=np.isin(reg,[names.index(n) for n in ['wehlen','lerdia','peninsula','olive','ne','ne2']])
_,(_iy,_ix)=ndi.distance_transform_edt(~_lab,return_indices=True); regf=reg[_iy,_ix]
_landall=rast(LAND)
_isl=np.zeros_like(_landall)
for _p in list(dd['Ld'].geoms)+list(dd['islets']):
    if _p.area<2e6: _isl|=rast(_p)
riz=_landall&~_isl&np.isin(regf,[names.index('peninsula'),names.index('olive')])
pf=ndi.gaussian_filter(((regf==names.index('peninsula'))&riz).astype(float),19)/np.maximum(ndi.gaussian_filter(riz.astype(float),19),1e-6)
pen=riz&(pf>0.5); ol=riz&~pen
_l,_n=ndi.label(ol); _sz=ndi.sum(ol,_l,range(1,_n+1)); ol=_l==(np.argmax(_sz)+1); pen=riz&~ol
we=_landall&~_isl&(regf==names.index('wehlen'))
d_pen=ndi.distance_transform_edt(~pen)*G
chan=seam.copy(); chan[:,:int(4300/G)]=False; chan[:int(330/G),:]=False
d_ch=ndi.distance_transform_edt(~chan)*G
noise=fbm((H,W),6,3,np.random.default_rng(3))
Db=np.clip(340+420*noise,220,620)                                                  # Brenas depth: 1-3 provinces
Dw=np.clip(np.interp(Y,[600,1500,2600,3600],[1650,1450,1000,700])+500*noise,650,1700)   # Wehlen depth: 2-5
def poly_at(x,y):
    return [p for p in list(dd['Ld'].geoms)+list(dd['islets']) if p.contains(Point(x,y))][0]
ISL={'Manes Riuz':('Zille',poly_at(9157,1914)),'Rotsla':('Wehlen',poly_at(5745,3643)),
     'Kreleck West':('Wehlen',poly_at(6236,504)),'Kreleck East':('Wehlen',poly_at(6662,602))}
# ---------------- city provinces ----------------
CITY=[('Zille','Zille',(7800,5990),216),('Isor','Zille',(6877,3393),150),('Nanta','Zille',(9088,2898),165),('Munat','Zille',(8446,1700),150),
      ('Wiktrany','Zille',(8029,5045),165),('Mave Nortus','Zille',(10515,4039),165),
      ('Lido Isora','Zille',None,135),('Sabbiano','Zille',None,135),('Vela Nova','Zille',None,135),('Rivamare','Zille',None,135),
      ('Praia Velha','Brenas',None,135),('Marbelas','Brenas',None,135),('Dapalle','Brenas',(9567,5524),150),
      ('Kratsna','Wehlen',(5555,482),0)]
def sm(g,r=40): return g.buffer(r,join_style=1).buffer(-r,join_style=1)
def biggest(g): return max(g.geoms,key=lambda q:q.area) if g.geom_type in ('MultiPolygon','GeometryCollection') else g
def boxclip(g,b=MAXB-8):
    x0,y0,x1,y1=g.bounds; cx,cy=(x0+x1)/2,(y0+y1)/2
    return biggest(g.intersection(box(cx-b/2,cy-b/2,cx+b/2,cy+b/2)))
cityshape={}
for n,rg,c,r in CITY:
    U=URB[n]; c=c or tuple(np.array(U.centroid.coords[0]))
    g=Point(*c).buffer(r) if n=='Zille' else (unary_union([U.buffer(26),Point(*c).buffer(r)]) if r>0 else U.buffer(18))
    g=boxclip(biggest(sm(g).intersection(LIN)))
    cityshape[n]=dict(region=rg,poly=g,c=c)
allcity=unary_union([v['poly'] for v in cityshape.values()])
cityblock=rast(allcity.buffer(GAP))
# ---------------- land partition ----------------
wx=X+38*fbm((H,W),14,3,np.random.default_rng(5))+14*fbm((H,W),40,2,np.random.default_rng(6))
wy=Y+38*fbm((H,W),14,3,np.random.default_rng(7))+14*fbm((H,W),40,2,np.random.default_rng(8))
def grid_seeds(mask,s,seed):
    r=np.random.default_rng(seed); pts=[]
    for j,y in enumerate(np.arange(s/2,8192,s*0.866)):
        for x in np.arange(s/2+(j%2)*s/2,12288,s):
            p=np.array([x,y])+r.uniform(-0.2,0.2,2)*s
            gy,gx=int(p[1]/G),int(p[0]/G)
            if 0<=gy<H and 0<=gx<W and mask[gy,gx]: pts.append(p)
    return pts
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
def partition(mask,seeds,iters):
    ys,xs=np.nonzero(mask); pw=np.stack([wx[ys,xs],wy[ys,xs]],1)
    seeds=[np.array(s,float) for s in seeds]
    for it in range(iters+1):
        _,lab=cKDTree(np.array(seeds)).query(pw)
        Lg=np.zeros((H,W),np.int32); Lg[ys,xs]=lab+1; Lg=fix_conn(Lg)
        if it==iters: return Lg,seeds
        cm=ndi.center_of_mass(np.ones_like(Lg),Lg,range(1,len(seeds)+1))
        for i,(cy,cx) in enumerate(cm):
            if np.isfinite(cx): seeds[i]=np.array([(cx+0.5)*G,(cy+0.5)*G])
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
    return g
def label_polys(Lg):
    out={}
    for i,sl in enumerate(ndi.find_objects(Lg)):
        if sl is None: continue
        sl=(slice(max(sl[0].start-1,0),sl[0].stop+1),slice(max(sl[1].start-1,0),sl[1].stop+1))
        out[i+1]=mask_poly(Lg[sl]==i+1,(sl[0].start,sl[1].start))
    return out
SP=dict(Zille=400,Brenas=400,Wehlen=400)
def pix_bbox(m):
    ys,xs=np.nonzero(m); return (xs.max()-xs.min()+1)*G,(ys.max()-ys.min()+1)*G
WA=19.0
_fx=wx-X; _fy=wy-Y
gwx=X+_fx*(WA/np.abs(_fx).max()); gwy=Y+_fy*(WA/np.abs(_fy).max())
def merge_small(Lg,minA,lim):
    for rnd in range(30):
        objs=ndi.find_objects(Lg); cnt=np.bincount(Lg.ravel())*G*G
        cand=sorted([i+1 for i,sl in enumerate(objs) if sl is not None and cnt[i+1]<minA],key=lambda k:cnt[k])
        mg=0; touched=set()
        for k in cand:
            if k in touched: continue
            sl=objs[k-1]; sl=(slice(max(sl[0].start-2,0),sl[0].stop+2),slice(max(sl[1].start-2,0),sl[1].stop+2))
            sub=Lg[sl]; m=sub==k; ring=ndi.binary_dilation(m,iterations=1)&~m
            nbv=sub[ring]; nbv=nbv[(nbv>0)&(nbv!=k)]
            if not len(nbv): continue
            best=None
            for j,c in zip(*np.unique(nbv,return_counts=True)):
                if j in touched: continue
                sj=objs[j-1]
                y0=min(sl[0].start,sj[0].start); y1=max(sl[0].stop,sj[0].stop); x0=min(sl[1].start,sj[1].start); x1=max(sl[1].stop,sj[1].stop)
                u=(Lg[y0:y1,x0:x1]==j)|(Lg[y0:y1,x0:x1]==k); w,hh=pix_bbox(u)
                if max(w,hh)<=lim:
                    sc=c/np.sqrt(cnt[j])
                    if best is None or sc>best[0]: best=(sc,j)
            if best:
                Lg[Lg==k]=best[1]; touched|={k,best[1]}; mg+=1
        if mg==0: break
    return Lg
def dissolve_small(Lg,minA,lim,zone):
    for rnd in range(6):
        cnt=np.bincount(Lg.ravel())*G*G; objs=ndi.find_objects(Lg); nd=0
        for k in sorted([i for i in range(1,len(cnt)) if 0<cnt[i]<minA],key=lambda i:cnt[i]):
            sl=objs[k-1]
            if sl is None or not (Lg[sl]==k).any(): continue
            pad=60
            win=(slice(max(sl[0].start-pad,0),sl[0].stop+pad),slice(max(sl[1].start-pad,0),sl[1].stop+pad))
            sub=Lg[win]; m=sub==k
            other=(sub>0)&~m
            if not other.any(): continue
            _,(iy,ix)=ndi.distance_transform_edt(~other,return_indices=True)
            tgt=sub[iy[m],ix[m]]; new=sub.copy(); new[m]=tgt; ok=True
            yy,xx=np.nonzero(m)
            for j in np.unique(tgt):
                sj=objs[j-1]; q=tgt==j
                y0=min(sj[0].start,yy[q].min()+win[0].start); y1=max(sj[0].stop,yy[q].max()+1+win[0].start)
                x0=min(sj[1].start,xx[q].min()+win[1].start); x1=max(sj[1].stop,xx[q].max()+1+win[1].start)
                if max(y1-y0,x1-x0)*G>lim: ok=False; break
            if ok:
                Lg[win]=new; nd+=1; objs=ndi.find_objects(Lg)
        if nd==0: break
    return Lg
JIT=0.2
def cassign(ys,xs,pw,seeds,hb):
    S=np.array(seeds); k=min(12,len(S))
    d,idx=cKDTree(S).query(pw,k=k); idx=idx.reshape(len(pw),-1)
    px=(xs+0.5)*G; py=(ys+0.5)*G
    ok=(np.abs(S[idx][:,:,0]-px[:,None])<=hb)&(np.abs(S[idx][:,:,1]-py[:,None])<=hb)
    first=np.argmax(ok,1); has=ok.any(1)
    return np.where(has,idx[np.arange(len(pw)),first],-1)
def region_cells(name,zone,seed):
    c=SP[name]; lim=MAXB+8; hb=lim/2-18; r=np.random.default_rng(seed); ox,oy=r.uniform(0,c,2)
    ys,xs=np.nonzero(zone); pw=np.stack([wx[ys,xs],wy[ys,xs]],1)
    seeds=[]
    for y in np.arange(oy-c,8192+c,c):
        for x in np.arange(ox-c,12288+c,c):
            seeds.append(np.array([x,y])+r.uniform(-JIT,JIT,2)*c)
    S=np.array(seeds); gy=np.clip((S[:,1]/G).astype(int),0,H-1); gx=np.clip((S[:,0]/G).astype(int),0,W-1)
    near=ndi.binary_dilation(zone,iterations=int(c/G))[gy,gx]; S=S[near]
    lab=cassign(ys,xs,pw,list(S),hb)
    if (lab<0).any():
        _,nn=cKDTree(S).query(pw[lab<0]); lab[lab<0]=nn
    Lg0=np.zeros((H,W),np.int32); Lg0[ys,xs]=lab+1
    # connected components as separate labels
    Lg=np.zeros((H,W),np.int32); nxt=1
    for i,sl in enumerate(ndi.find_objects(Lg0)):
        if sl is None: continue
        m=Lg0[sl]==i+1; l2,k=ndi.label(m); sub=Lg[sl]; sub[m]=l2[m]+nxt-1; nxt+=k
    Lg=merge_small(Lg,0.5*c*c,lim)
    Lg=merge_small(Lg,0.7*c*c,lim)
    Lg=dissolve_small(Lg,0.62*c*c,lim,zone)
    Lg=merge_small(Lg,0.5*c*c,lim)
    u=np.unique(Lg); u=u[u>0]; mp=np.zeros(Lg.max()+1,np.int32); mp[u]=np.arange(1,len(u)+1); Lg=mp[Lg]
    P=label_polys(Lg)
    big=[k for k,p in P.items() if max(p.bounds[2]-p.bounds[0],p.bounds[3]-p.bounds[1])>MAXB]
    print(name,'cells',len(P),'oversize',len(big),'small<0.4c2',sum(1 for p in P.values() if p.area<0.4*c*c),flush=True)
    return Lg,None,P
Zz=(pen|(ol&(d_pen<1)))&landm&~cityblock
Zb=ol&landm&(d_pen<1300)&~cityblock
Zw=we&landm&(d_ch<2500)&~cityblock
for nm,(rg,g) in ISL.items(): Zz&=~rast(g); Zb&=~rast(g); Zw&=~rast(g)
res={}
res['Zille']=region_cells('Zille',Zz,1)
res['Brenas']=region_cells('Brenas',Zb,2)
res['Wehlen']=region_cells('Wehlen',Zw,3)
pickle.dump(dict(res=res,cityshape=cityshape,ISL=ISL),open('work/prov6_raw.pkl','wb'))
print('done')
