"""v14: west mainland split by the source-map land borders (borders_land layer):
   B1 = Wehlen | Derdia border (Yol coast (3904,4159) -> Oderna -> Wolsna -> west frame), 3 path pieces joined
   B2 = Derdia | Morella border (coast just south of Yol (3601,4691) -> bottom frame)
   WSIDE = Wehlen side (north of B1), DSIDE = Derdia (south of B1, west of B2), MSIDE = Morella (south of B1, east of B2)."""
import sys, pickle, numpy as np
sys.path.insert(0,'/workspace/zille/work14')
from lib import layer_lines, load
from shapely.geometry import LineString, Point
from shapely.ops import split, unary_union, linemerge
_s=load('/workspace/zille/work13/base/zille_vector.svg')
_L=[l for _,l in layer_lines('borders_land',_s)]
def _ext(a,b,L=300):
    a=np.array(a,float);b=np.array(b,float); v=a-b; v/=np.linalg.norm(v); return tuple(a+v*L)
_c=list(_L[0].coords)+list(_L[1].coords)[1:]+list(_L[2].coords)[1:]
B1=LineString(_c)
B1X=LineString([_ext(_c[0],_c[3])]+_c+[_ext(_c[-1],_c[-4])])
_c2=list(_L[3].coords); B2=LineString(_c2)
B2X=LineString([_ext(_c2[0],_c2[3])]+_c2+[_ext(_c2[-1],_c2[-4])])
_dd=pickle.load(open('/workspace/zille/work/land_dec.pkl','rb'))
WEST=[p for p in _dd['Ld'].geoms if p.contains(Point(3000,3000))][0]
_p=sorted(split(WEST,B1X).geoms,key=lambda g:g.area,reverse=True)[:2]
WSIDE=[g for g in _p if g.contains(Point(3000,3000))][0]
SOUTH=[g for g in _p if g is not WSIDE][0]
_q=sorted(split(SOUTH,B2X).geoms,key=lambda g:g.area,reverse=True)[:2]
DSIDE=[g for g in _q if g.contains(Point(2000,4300))][0]
MSIDE=[g for g in _q if g is not DSIDE][0]
