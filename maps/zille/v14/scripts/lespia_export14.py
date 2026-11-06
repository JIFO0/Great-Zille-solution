"""v14 request 9: export Lespia's coast + territorial-waters zone to regions/lespia_territorial_waters.json
(used by validate_pack.py to check that no sea province comes closer than GAP to Lespia)."""
import sys, json, re
sys.path.insert(0,'versions/v14/scripts')
from lespia14 import LES, TWZ, STRIP, GAP, FRAME
from shapely.geometry import box
def rings(g,tol):
    out=[]
    for p in getattr(g,'geoms',[g]):
        if p.is_empty: continue
        out.append([[round(x,1),round(y,1)] for x,y in p.simplify(tol).exterior.coords])
    return out
svg=open('work14/base/zille_vector.svg').read()
labels=re.findall(r'<path id="(lespia_tw_path_\d+)" d="M([\d.]+),([\d.]+)',svg)
near=LES.intersection(box(FRAME.bounds[0]-600,FRAME.bounds[1]-600,FRAME.bounds[2]+600,FRAME.bounds[3]))
doc=dict(name="Lespia's Territorial Waters", min_distance_map_px=GAP,
  note="Non-playable water between the northern sea provinces and Lespia (land north-east of Munat). No province overlaps the zone; every sea province is >= min_distance from the Lespian coast. Coast polygons simplified with tolerance 1 map px (the check allows 2 px slack).",
  lespia_coast_polygons=rings(near,1.0), zone_outer_edge=rings(TWZ.intersection(FRAME),2.0),
  strip_area_map_px2=round(STRIP.area), label_paths=[dict(id=i,start=[float(x),float(y)]) for i,x,y in labels],
  label_text="Lespia\u2019s Territorial Waters")
json.dump(doc,open('versions/v14/regions/lespia_territorial_waters.json','w'))
print('coast polys',len(doc['lespia_coast_polygons']),'pts',sum(map(len,doc['lespia_coast_polygons'])),'labels',len(labels))
