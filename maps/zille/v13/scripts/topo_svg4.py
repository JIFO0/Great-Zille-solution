"""v4: vectorise a heightmap (argv1) into the `topography` group only (argv2). From topo_svg.py;  into nested filled contour bands, insert as group `topography`
(above land, below rivers) + the cape road into a copy of the v2 SVG."""
import numpy as np, pickle, sys, re, os
from skimage import measure
from shapely.geometry import Polygon, Point, LineString
from shapely.strtree import STRtree
from shapely.ops import unary_union
from scipy.ndimage import gaussian_filter1d
S=8
h=np.load(sys.argv[1] if len(sys.argv)>1 else 'work/topo_h4.npy').astype(float)
reg=np.load('work/topo_reg.npy'); names=pickle.load(open('work/topo_names.pkl','rb'))
dd=pickle.load(open('work/land_dec.pkl','rb')); LdAll=unary_union([dd['Ld']]+dd['islets'])
T=[0.07,0.15,0.23,0.31,0.40,0.50,0.61,0.73]
# per-band opacity sampled from pales.png tone steps 255>244>233>225>216>204>186 (+2 extrapolated)
A=[0.043,0.045,0.034,0.040,0.056,0.088,0.09,0.09]
STROKE=dict(color='#000000',opacity=0.22,width=4)
MINAREA=[6000,5000,4500,4000,3500,3000,2500,2500]   # src px^2: drop specks
def f(v): return ('%.1f'%v).rstrip('0').rstrip('.')
def cr_closed(P):
    n=len(P); d=['M%s,%s'%(f(P[0,0]),f(P[0,1]))]
    for i in range(n):
        p0=P[(i-1)%n];p1=P[i];p2=P[(i+1)%n];p3=P[(i+2)%n]
        c1=p1+(p2-p0)/6; c2=p2-(p3-p1)/6
        d.append('C%s,%s %s,%s %s,%s'%(f(c1[0]),f(c1[1]),f(c2[0]),f(c2[1]),f(p2[0]),f(p2[1])))
    return ''.join(d)+'Z'
def ring_prep(c,tol):
    c=np.asarray(c)
    if np.hypot(*(c[0]-c[-1]))<1e-6: c=c[:-1]
    if len(c)<4: return None
    # light circular smoothing then simplify
    cs=np.stack([gaussian_filter1d(c[:,0],0.45,mode='wrap'),gaussian_filter1d(c[:,1],0.45,mode='wrap')],1)
    g=LineString(np.vstack([cs,cs[:1]])).simplify(tol)
    q=np.asarray(g.coords)[:-1]
    return q if len(q)>=4 else None
def level_polys(t):
    hp=np.pad(h,1,constant_values=-1)
    rings=measure.find_contours(hp,t)
    polys=[]
    for r in rings:
        xy=np.stack([(r[:,1]-1+0.5)*S,(r[:,0]-1+0.5)*S],1)
        if len(xy)<4: continue
        p=Polygon(xy)
        if not p.is_valid: p=p.buffer(0)
        if p.is_empty: continue
        if p.geom_type=='MultiPolygon': p=max(p.geoms,key=lambda g:g.area)
        polys.append(Polygon(p.exterior))
    polys.sort(key=lambda p:-p.area)
    # nesting depth by containment parity
    tree=STRtree(polys); depth=[0]*len(polys); parent=[-1]*len(polys)
    for i,p in enumerate(polys):
        rp=p.representative_point()
        cands=[j for j in tree.query(rp) if j!=i and polys[j].area>p.area and polys[j].contains(rp)]
        depth[i]=len(cands)
        if cands: parent[i]=min(cands,key=lambda j:polys[j].area)
    out=[]
    for i,p in enumerate(polys):
        if depth[i]%2: continue
        holes=[polys[j] for j in range(len(polys)) if parent[j]==i and depth[j]%2==1]
        g=Polygon(p.exterior.coords,[hh.exterior.coords for hh in holes])
        if not g.is_valid: g=g.buffer(0)
        out.append(g)
    return out
def poly_d(g,minA,tol=1.6):
    ds=[];nn=0
    for p in getattr(g,'geoms',[g]):
        if p.geom_type!='Polygon' or p.area<minA: continue
        for k,r in enumerate([p.exterior]+list(p.interiors)):
            if k>0 and Polygon(r).area<minA*0.6: continue
            q=ring_prep(r.coords,tol)
            if q is None: continue
            nn+=len(q); ds.append(cr_closed(q))
    return ''.join(ds),nn
ORDER=['wehlen','lerdia','other','peninsula','olive','ne','ne2']
LABEL=dict(wehlen='wehlen',lerdia='lerdia',other='coast_south_of_yol',peninsula='zille_peninsula',olive='olive_country',ne='ne_corner',ne2='north_land')
body={n:[] for n in ORDER}; stats={}; total=0
Lgrid=LdAll.buffer(-6)
for k,t in enumerate(T):
    P=level_polys(t)
    per={n:[] for n in ORDER}
    for g in P:
        if g.area<MINAREA[k]: continue
        if not Lgrid.contains(g): g=g.intersection(LdAll.buffer(-12))
        if g.is_empty: continue
        rp=g.representative_point(); i=reg[min(int(rp.y/S),reg.shape[0]-1),min(int(rp.x/S),reg.shape[1]-1)]
        n=names[i] if i>0 else 'other'
        if n in ('islets','none'): n='other'
        per[n].append(g)
    for n in ORDER:
        if not per[n]: continue
        d,nn=poly_d(unary_union(per[n]) if len(per[n])>1 else per[n][0],MINAREA[k])
        if not d: continue
        total+=nn; stats[(n,k+1)]=nn
        gid=f'topo_{LABEL[n]}_L{k+1}'
        body[n].append(f'<g id="{gid}" fill-opacity="{A[k]}"><path id="{gid}_shape" d="{d}"/></g>')
grp=['<g id="topography" fill="#000000" fill-rule="evenodd" stroke="%s" stroke-opacity="%s" stroke-width="%s" stroke-linejoin="round">'%(STROKE['color'],STROKE['opacity'],STROKE['width'])]
for n in ORDER:
    if body[n]: grp.append(f'<g id="topo_{LABEL[n]}">'+''.join(body[n])+'</g>')
grp.append('</g>')
topo='\n'.join(grp)
print('topography nodes',total); print({f'{a}_L{b}':v for (a,b),v in stats.items()})
pickle.dump(stats,open('work/topo4_stats.pkl','wb'))
open(sys.argv[2] if len(sys.argv)>2 else 'work/topo4_group.svg','w').write(topo)
