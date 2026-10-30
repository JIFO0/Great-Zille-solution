import numpy as np, pickle, json
from shapely.ops import unary_union
from shapely.strtree import STRtree
F=pickle.load(open('work/prov7_final.pkl','rb')); allp=F['allp']
S=pickle.load(open('work/prov7_stage2.pkl','rb')); SZ=S['SZ']; ZONEV=S['ZONEV']
dd=pickle.load(open('work/land_dec.pkl','rb')); LAND=unary_union([dd['Ld']]+dd['islets'])
polys=[c['poly'] for c in allp]; t=STRtree(polys); ov=[]
for i,p in enumerate(polys):
    for j in t.query(p):
        if j>i and p.intersection(polys[j]).area>1: ov.append((allp[i]['id'],allp[j]['id']))
water=[(c['id'],round(c['poly'].difference(LAND).area)) for c in allp if c['type']=='land' and c['poly'].difference(LAND).area>1]
seaonland=[(c['id'],round(c['poly'].intersection(LAND).area)) for c in allp if c['type']=='sea' and c['poly'].intersection(LAND).area>1]
cover=unary_union(polys).buffer(40)
def holes(zone,minA=6000):
    h=zone.difference(cover); return sorted([(round(g.area),[round(v) for v in g.centroid.coords[0]]) for g in getattr(h,'geoms',[h]) if g.area>minA],reverse=True)
mainland_zone=ZONEV
res=dict(counts={r:sum(1 for c in allp if (c['region'] if c['type']=='land' else 'Sea')==r) for r in ['Zille','Brenas','Wehlen','Sea']},
    total=len(allp), overlaps=ov, land_on_water=water, sea_on_land=seaonland,
    land_zone_holes=holes(mainland_zone), land_zone_uncovered_total=round(mainland_zone.difference(cover).area),
    sea_corridor_holes=holes(SZ), tile_violations=F['val_bad'],
    max_alpha_extent=max(max(r['alpha_w'],r['alpha_h']) for r in F['rows']), max_shape_bbox=max(max(r['bbox_w'],r['bbox_h']) for r in F['rows']),
    cities=[(c['id'],c['city']) for c in allp if c['kind']=='city'],
    smallest_land=sorted([(round(c['poly'].area),c['id']) for c in allp if c['type']=='land'])[:5],
    smallest_sea=sorted([(round(c['poly'].area),c['id']) for c in allp if c['type']=='sea'])[:3])
print(json.dumps(res,indent=1,default=str))
json.dump(res,open('versions/v7/provinces_validation.json','w'),indent=1,default=str)
