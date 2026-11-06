"""v14 playable land zones on the west mainland.
 WZ: Wehlen zone = v13 Wehlen zone + a westward extension along the Derdian border (smooth spline inland edge Dornatz ->
     Vernen -> Gorvitz -> Oderna), 27 px coast inset, 32 px off the Wehlen-Derdia border.
 DZ: Derdia strip = south of the Wehlen-Derdia border from Oderna to Yol, 1-2 provinces deep (down past the Yol-Golcondra
     road and railway), smooth spline inland edge, 32 px off both borders (Wehlen, Morella)."""
import numpy as np, pickle, sys
sys.path.insert(0,'/workspace/zille/versions/v14/scripts')
from sides14 import WSIDE, DSIDE, MSIDE, B1, B2
from shapely.geometry import Polygon, box
from shapely.ops import unary_union
def spline(ctrl,step=20):
    P=np.asarray(ctrl,float); Q=np.vstack([P[0],P,P[-1]]); out=[P[0]]
    for k in range(1,len(Q)-2):
        p0,p1,p2,p3=Q[k-1],Q[k],Q[k+1],Q[k+2]
        n=max(2,int(np.hypot(*(p2-p1))/step))
        for t in np.linspace(0,1,n+1)[1:]:
            out.append(0.5*((2*p1)+(-p0+p2)*t+(2*p0-5*p1+4*p2-p3)*t*t+(-p0+3*p1-3*p2+p3)*t**3))
    return [tuple(p) for p in out]
FRAME=box(295,306,11993,7877)
_dd=pickle.load(open('/workspace/zille/work/land_dec.pkl','rb')); LAND=unary_union([_dd['Ld']]+_dd['islets'])
LIN27=LAND.buffer(-27)
_S=pickle.load(open('/workspace/zille/work/prov12_stage2.pkl','rb')); ZONEV=_S['ZONEV']
OLDW=[g for g in ZONEV.geoms if g.bounds[0]<4000][0]
EXT_EDGE=spline([(3880,1480),(3600,1850),(3180,2230),(2620,2500),(2060,2640),(1640,2790),(1390,3040),(1300,3300),(1300,3560)])
EXT=Polygon(EXT_EDGE+[(1300,4300),(4100,4300),(4100,1480)])
WZ=unary_union([OLDW,EXT.intersection(WSIDE)]).buffer(120,join_style=1).buffer(-120,join_style=1)
WZ=WZ.intersection(LIN27).intersection(WSIDE.difference(B1.buffer(32))).intersection(FRAME)
WZ=max(getattr(WZ,'geoms',[WZ]),key=lambda g:g.area)
D_EDGE=spline([(1820,3380),(1780,3800),(1720,4300),(1780,4830),(2100,4905),(2520,4910),(3020,4850),(3420,4720),(3760,4560)])
DP=Polygon(D_EDGE+[(4100,4560),(4100,3250)])
DZ=DP.intersection(LIN27).intersection(DSIDE.difference(B1.buffer(32)).difference(B2.buffer(32))).intersection(FRAME)
DZ=max(getattr(DZ,'geoms',[DZ]),key=lambda g:g.area)
if __name__=='__main__':
    print('WZ area %.2fM (v13 %.2fM, +%.2fM)  bounds %s'%(WZ.area/1e6,OLDW.area/1e6,(WZ.area-OLDW.area)/1e6,[round(v) for v in WZ.bounds]))
    print('DZ area %.2fM bounds %s'%(DZ.area/1e6,[round(v) for v in DZ.bounds]))
    pickle.dump(dict(WZ=WZ,DZ=DZ,OLDW=OLDW),open('/workspace/zille/work14/zones14.pkl','wb'))
