"""v14 request 9: Lespia's territorial waters. Lespia = the northern land outside the playable area (source-map landmasses
north-east of Munat: the big block 8561-12036 x 264-2430 + its coastal islets). Sea provinces must keep GAP map px from it;
the strip LES.buffer(GAP) - land is non-playable water labelled "Lespia's Territorial Waters"."""
import pickle
from shapely.geometry import Point, box
from shapely.ops import unary_union
_dd=pickle.load(open('/workspace/zille/work/land_dec.pkl','rb'))
_G=list(_dd['Ld'].geoms)
_core=[g for g in _G if g.bounds[1]<300 and g.bounds[0]>8000]+[g for g in _G if g.bounds[0]>10000 and g.bounds[3]<1600 and g.area<2e5]
_C=unary_union(_core)
_isl=[g for g in list(_dd['islets'])+[g for g in _G if g.area<2e5] if g.distance(_C)<260 and g.bounds[1]<2600 and g.bounds[0]>8000]
LES=unary_union([_C]+_isl)
GAP=180              # min distance sea province <-> Lespian land (map px); v13 coast offset was 32
FRAME=box(295,306,11993,7877)
R_SMOOTH=250        # the outer edge of the zone is smoothed (closing with this radius) so the playable sea edge is a calm curve
TWZ=LES.buffer(GAP+R_SMOOTH,join_style=1).buffer(-R_SMOOTH,join_style=1)   # every point <= ... ; contains LES.buffer(GAP)
STRIP=TWZ.difference(LES).intersection(FRAME)
if __name__=='__main__':
    print('Lespia parts',len(getattr(LES,'geoms',[LES])),[round(v) for v in LES.bounds],'area %.2fM'%(LES.area/1e6),'islets',len(_isl))
