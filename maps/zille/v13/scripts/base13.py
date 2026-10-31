"""v13 base map (vector), built on the v11/v12 base (work/v11base/zille_vector.svg):
 1) relief: new mountain range 'Quella Highlands' in the north-west of the peninsula (between the Quella-Corvis road,
    the Isor-Sostra road and the Lenta valley), the Ondaro hills west of the Wiktrany-Zille road raised to real hills.
    Heightmap work/topo_h5.npy -> work13/topo_h13.npy; the topography group is re-vectorised with the unchanged
    topo_svg4.py (re-running it on topo_h5 reproduces the v12 group byte-for-byte, so only the edited relief changes).
 2) roads: main road Isor -> Wiktrany re-routed down the west-coast valley (Sostra - Marenta - Cala Vessa - Wiktrany)
    instead of Sostra - Ardo - Wiktrany, which ran only 300-400 map px beside the Nanta - Lenta - Wiktrany main road.
    The old Sostra - Ardo - Wiktrany section stays as a minor road; the two resort lanes the main road now replaces
    (Marenta -> main road, Cala Vessa -> Marenta) are dropped.
 3) Mave Nortus: urban area clipped to the Rizian side of the border (the city now lies fully inside Rizia).
-> work13/base/zille_vector.svg, work13/base/zille_preview.png"""
import sys, re, os, pickle, subprocess, numpy as np, cairosvg
sys.path.insert(0,'work13')
from lib import group, layer_lines, load
from sides import RSIDE, ZSIDE
from scipy import ndimage as ndi
from shapely.geometry import LineString, Point, Polygon
from shapely.ops import unary_union
from PIL import Image
Image.MAX_IMAGE_PIXELS=None
SRC='work/v11base/zille_vector.svg'; s=open(SRC).read()
S=8; h=np.load('work/topo_h5.npy').astype(float); H,W=h.shape
Yg,Xg=np.mgrid[0:H,0:W]; X=(Xg+0.5)*S; Y=(Yg+0.5)*S
def ss(x,a,b): t=np.clip((x-a)/(b-a),0,1); return t*t*(3-2*t)
dd=pickle.load(open('work/land_dec.pkl','rb'))
# ---------- 1) relief ----------
from PIL import ImageDraw
def rast_lines(lines,w=2):
    im=Image.new('L',(W,H),0); d=ImageDraw.Draw(im)
    for l in lines: d.line([(x/S,y/S) for x,y in l.coords],fill=255,width=w)
    return np.asarray(im)>0
ROADL=[l for g in ('main_roads','roads_double_fill','roads_minor','railway_line','rivers') for _,l in layer_lines(g)]
droad=ndi.distance_transform_edt(~rast_lines(ROADL,3))*S
pen=np.zeros((H,W),bool)
im=Image.new('L',(W,H),0); _d=ImageDraw.Draw(im)
for _q in getattr(ZSIDE.buffer(-20),'geoms',[ZSIDE.buffer(-20)]):
    _d.polygon([(x/S,y/S) for x,y in _q.exterior.coords],fill=255)
pen=np.asarray(im)>0
dsea=ndi.distance_transform_edt(pen)*S
# (a) Quella Highlands: relief texture borrowed from the Zille massif (8150-9350 x 4850-5750), rotated onto the
#     SW-NE axis (7550,3400)->(8350,3000), scaled 0.8, peak lowered to ~0.56 (band 6)
bx0,by0,bx1,by1=8150,4850,9350,5750
P=h[by0//S:by1//S,bx0//S:bx1//S].copy()
py,px=np.mgrid[0:P.shape[0],0:P.shape[1]]
edge=np.minimum.reduce([px,py,P.shape[1]-1-px,P.shape[0]-1-py])*S
P=P*ss(edge,0,160)
ang=np.degrees(np.arctan2(3000-3400,8350-7550))
P=ndi.rotate(P,ang,reshape=True,order=1)          # image coords: positive angle = counter-clockwise on screen
P=ndi.zoom(P,0.8,order=1)
P=np.clip(P,0,None)/P.max()*0.56
cx,cy=7960,3230
oy=int(cy/S-P.shape[0]/2); ox=int(cx/S-P.shape[1]/2)
add=np.zeros_like(h); add[oy:oy+P.shape[0],ox:ox+P.shape[1]]=P
carve=(1-np.exp(-(droad/190)**2))*ss(dsea,60,520)*pen
new=np.maximum(h,add*carve)
# (b) Ondaro hills: the existing low rise west of the Wiktrany-Zille road, heights x2.1 (bands 1-2 -> 3-4)
w=np.exp(-((X-7600)**2+(Y-5330)**2)/(2*300**2))*pen
new=new*(1+0.75*w*(1-np.exp(-(droad/150)**2)))
np.save('work13/topo_h13.npy',new.astype(np.float32))
T=np.array([0.07,0.15,0.23,0.31,0.40,0.50,0.61,0.73])
for nm,(x0,y0,x1,y1) in dict(quella=(7300,2800,8600,3700),ondaro=(7300,5000,7950,5700)).items():
    sub=new[y0//S:y1//S,x0//S:x1//S]; print(nm,'max h %.3f band %d'%(sub.max(),np.searchsorted(T,sub.max())))
subprocess.run(['python3','topo_svg4.py','work13/topo_h13.npy','work13/topo13_group.svg'],check=True,stdout=subprocess.DEVNULL)
topo=open('work13/topo13_group.svg').read()
old=group('topography',s); s=s.replace(old,topo,1)
# ---------- 2) roads ----------
def f(v): return ('%.1f'%v).rstrip('0').rstrip('.')
def cr_open(P):
    n=len(P); d=['M%s,%s'%(f(P[0,0]),f(P[0,1]))]
    for i in range(n-1):
        p0=P[max(i-1,0)];p1=P[i];p2=P[i+1];p3=P[min(i+2,n-1)]
        c1=p1+(p2-p0)/6; c2=p2-(p3-p1)/6
        d.append('C%s,%s %s,%s %s,%s'%(f(c1[0]),f(c1[1]),f(c2[0]),f(c2[1]),f(p2[0]),f(p2[1])))
    return ''.join(d)
def spline(ctrl,step=25):
    P=np.asarray(ctrl,float); Q=np.vstack([P[0],P,P[-1]]); out=[P[0]]
    for k in range(1,len(Q)-2):
        p0,p1,p2,p3=Q[k-1],Q[k],Q[k+1],Q[k+2]
        n=max(2,int(np.hypot(*(p2-p1))/step))
        for t in np.linspace(0,1,n+1)[1:]:
            out.append(0.5*((2*p1)+(-p0+p2)*t+(2*p0-5*p1+4*p2-p3)*t*t+(-p0+3*p1-3*p2+p3)*t**3))
    return np.array(out)
gm=group('main_roads',s); paths=re.findall(r'<path d="[^"]+"/>',gm)
iz=[i for i,p in enumerate(paths) if p.startswith('<path d="M6812')]; assert len(iz)==1, iz
L=layer_lines('main_roads',s)[iz[0]][1]; C=np.asarray(L.coords)
J=np.array([7743.,3968.]); WK=np.array([8029.,5045.])
j=int(np.argmin(np.hypot(*(C-J).T))); k=int(np.argmin(np.hypot(*(C-WK).T)))
print('split main road at',C[j].round(),C[k].round())
mid=spline([C[j],(7718,4110),(7670,4232),(7684,4410),(7717,4583),(7795,4745),(7905,4915),C[k]])
newmain=np.vstack([C[:j],mid,C[k+1:]])
newmain=np.asarray(LineString(newmain).simplify(1.5).coords)
ardo=np.asarray(LineString(C[j:k+1]).simplify(1.5).coords)
gm2=gm.replace(paths[iz[0]],f'<path id="main_isor_zille" d="{cr_open(newmain)}"/>')
s=s.replace(gm,gm2,1)
gn=group('roads_minor',s); gn2=gn
for rid in ('road_resort_1','road_resort_2'):
    m=re.search(rf'<path id="{rid}" d="[^"]+"/>\s*',gn2); gn2=gn2.replace(m.group(0),'')
gn2=gn2.replace('</g>',f'<path id="road_sostra_ardo_wiktrany" d="{cr_open(ardo)}"/>\n</g>',1) if gn2.count('</g>')==1 else None
assert gn2
s=s.replace(gn,gn2,1)
# ---------- 3) Mave Nortus inside Rizia ----------
gu=group('urban_mave_nortus',s)
def poly_of(gid):
    l=[ln for pid,ln in layer_lines('urban_mave_nortus',s) if pid==gid][0]; return Polygon(l.coords).buffer(0)
def pd(p): return 'M'+' L'.join(f'{x:.1f},{y:.1f}' for x,y in list(p.exterior.coords)[:-1])+'Z'
RS=RSIDE.buffer(-12)
area=poly_of('urban_mave_nortus_area'); edge=poly_of('urban_mave_nortus_edge')
a2=max(getattr(area.intersection(RS),'geoms',[area.intersection(RS)]),key=lambda q:q.area).buffer(-4).buffer(4)
e2=max(getattr(edge.intersection(RSIDE.buffer(-2)),'geoms',[edge.intersection(RSIDE.buffer(-2))]),key=lambda q:q.area)
print('Mave Nortus urban area %.0f -> %.0f (%.1f%% clipped)'%(area.area,a2.area,100*(1-a2.area/area.area)))
gu2=f'<g id="urban_mave_nortus"><path id="urban_mave_nortus_edge" fill-opacity="0.10" d="{pd(e2)}"/><path id="urban_mave_nortus_area" fill-opacity="0.42" d="{pd(a2)}"/></g>'
s=s.replace(gu,gu2,1)
pickle.dump(dict(main_isor_zille=newmain,ardo=ardo,mave_urban=a2),open('work13/base/edits.pkl','wb'))
os.makedirs('work13/base',exist_ok=True)
open('work13/base/zille_vector.svg','w').write(s)
cairosvg.svg2png(bytestring=s.encode(),write_to='work13/base/zille_preview.png',output_width=4096,output_height=2731)
print('ok',len(s))
