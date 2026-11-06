import sys; sys.path.insert(0,'/workspace/zille/work13')
from lib import *
import pickle, numpy as np
from shapely.geometry import Point, LineString
from shapely.ops import unary_union, split
dd=pickle.load(open('/workspace/zille/work/land_dec.pkl','rb'))
RIZ=[p for p in dd['Ld'].geoms if p.contains(Point(7800,4000))][0]
def _ext(a,b,L=200):
    a=np.array(a);b=np.array(b); v=a-b; v/=np.linalg.norm(v); return tuple(a+v*L)
BORDER=layer_lines('borders_land',load('/workspace/zille/work/v11base/zille_vector.svg'))[-1][1]
_c=list(BORDER.coords)
BLINE=LineString([_ext(_c[0],_c[3])]+_c+[_ext(_c[-1],_c[-4])])
_p=sorted(split(RIZ,BLINE).geoms,key=lambda g:g.representative_point().x)
ZSIDE,RSIDE=_p[0],_p[1]     # Zille (Wehlen-held) side, Rizia (Brenas) side
