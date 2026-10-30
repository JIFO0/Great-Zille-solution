"""v11 base map: add the port city GRODZIZG (Nanta-sized urban area, Nanta label tier) on the Yol-bay coast
of former province 94, linked by a double road to the Kratsna-Yol road at Brannitz."""
import re, pickle, numpy as np, cairosvg
from shapely.geometry import Point, Polygon, LineString
from shapely.ops import unary_union
from PIL import Image
Image.MAX_IMAGE_PIXELS=None
s=open('versions/v9/zille_vector.svg').read()
dd=pickle.load(open('work/land_dec.pkl','rb')); LAND=unary_union([dd['Ld']]+dd['islets'])
C=(4290,3610)
rng=np.random.default_rng(1611)
t=np.linspace(0,2*np.pi,90,endpoint=False); ph=rng.uniform(0,2*np.pi,4)
rad=80*(1+0.16*np.sin(2*t+ph[0])+0.10*np.sin(3*t+ph[1])+0.07*np.sin(5*t+ph[2])+0.04*np.sin(7*t+ph[3]))
blob=Polygon(np.stack([C[0]+rad*np.cos(t)*1.05,C[1]+rad*np.sin(t)*0.9],1))
# harbour arm along the shore (port quarter) to the north-west
quay=LineString([(4262,3598),(4200,3540)]).buffer(34,cap_style=1)
area=unary_union([blob,quay]).intersection(LAND.buffer(-6)).buffer(-8).buffer(8)
area=max(getattr(area,'geoms',[area]),key=lambda q:q.area)
edge=area.buffer(14).intersection(LAND.buffer(-2)); edge=max(getattr(edge,'geoms',[edge]),key=lambda q:q.area)
b=area.bounds; print('urban area bbox',round(b[2]-b[0]),round(b[3]-b[1]),'(Nanta 190x166)')
def pd(p): return 'M'+' L'.join(f'{x:.1f},{y:.1f}' for x,y in list(p.exterior.coords)[:-1])+'Z'
urb=f'<g id="urban_grodzizg"><path id="urban_grodzizg_edge" fill-opacity="0.10" d="{pd(edge)}"/><path id="urban_grodzizg_area" fill-opacity="0.42" d="{pd(area)}"/></g>\n'
i=s.find('<g id="urban_nanta"'); s=s[:i]+urb+s[i:]
# road: Catmull-Rom through control points -> cubic path
P=np.array([(4290,3610),(4262,3585),(4205,3492),(4138,3392),(4066,3338),(3983.6,3390.6)],float)
def cr(P):
    out=f'M{P[0][0]:.1f},{P[0][1]:.1f}'
    Q=np.vstack([P[0],P,P[-1]])
    for k in range(1,len(Q)-2):
        p0,p1,p2,p3=Q[k-1],Q[k],Q[k+1],Q[k+2]; c1=p1+(p2-p0)/6; c2=p2-(p3-p1)/6
        out+=f'C{c1[0]:.1f},{c1[1]:.1f} {c2[0]:.1f},{c2[1]:.1f} {p2[0]:.1f},{p2[1]:.1f}'
    return out
d=cr(P)
ln=LineString(P); print('road length',round(ln.length),'min dist to sea',round(min(LAND.exterior.distance(Point(p)) if LAND.geom_type=='Polygon' else 0 for p in P)))
for gid,suf in (('roads_double_casing','casing'),('roads_double_fill','fill')):
    i=s.find(f'<g id="{gid}"'); j=s.find('>',i)+1
    s=s[:j]+f'\n<path id="road_grodzizg_brannitz_{suf}" d="{d}"/>'+s[j:]
lab='<text id="label_grodzizg" x="4300" y="3392" font-size="108" font-weight="bold" letter-spacing="5.4">GRODZIZG</text>\n'
i=s.find('<text id="label_nanta"'); s=s[:i]+lab+s[i:]
open('work/v11base/zille_vector.svg','w').write(s)
pickle.dump(dict(area=area,edge=edge,center=C,road=ln),open('work/v11base/grodzizg.pkl','wb'))
cairosvg.svg2png(bytestring=s.encode(),write_to='work/v11base/zille_preview.png',output_width=4096,output_height=2731)
print('ok')
