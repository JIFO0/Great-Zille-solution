import numpy as np, pickle, json
from shapely.ops import unary_union
from shapely.strtree import STRtree
F=pickle.load(open('work/prov10_final.pkl','rb')); allp=F['allp']
S=pickle.load(open('work/prov10_stage2.pkl','rb')); SZ=S['SZ']; ZONEV=S['ZONEV']
dd=pickle.load(open('work/land_dec.pkl','rb')); LAND=unary_union([dd['Ld']]+dd['islets'])
polys=[c['poly'] for c in allp]; t=STRtree(polys); ov=[]
for i,p in enumerate(polys):
    for j in t.query(p):
        if j>i and p.intersection(polys[j]).area>1: ov.append((allp[i]['id'],allp[j]['id']))
water=[(c['id'],round(c['poly'].difference(LAND).area)) for c in allp if c['type']=='land' and c['poly'].difference(LAND).area>1]
seaonland=[(c['id'],round(c['poly'].intersection(LAND).area)) for c in allp if c['type']=='sea' and c['poly'].intersection(LAND).area>1]
cover=unary_union(polys).buffer(70)
def holes(zone,minA=10000):
    h=zone.difference(cover); return sorted([(round(g.area),[round(v) for v in g.centroid.coords[0]]) for g in getattr(h,'geoms',[h]) if g.area>minA],reverse=True)
mainland_zone=ZONEV
res=dict(counts={r:sum(1 for c in allp if (c['region'] if c['type']=='land' else 'Sea')==r) for r in ['Zille','Brenas','Wehlen','Sea']},
    total=len(allp), overlaps=ov, land_on_water=water, sea_on_land=seaonland,
    land_zone_holes=holes(mainland_zone), land_zone_uncovered_total=round(mainland_zone.difference(cover).area),
    sea_corridor_holes=holes(SZ), tile_violations=F['val_bad'],
    max_tile_alpha_extent_px=max(max(r['alpha_w'],r['alpha_h']) for r in F['rows']),
    max_map_extent_incl_effects=max(r['map_extent_incl_effects'] for r in F['rows']), limit_map=980,
    max_shape_bbox_map=max(max(r['bbox_w'],r['bbox_h']) for r in F['rows']),
    tiles_512=all(__import__('PIL.Image',fromlist=['x']).open('versions/v10/regions/'+r['png_file']).size==(512,512) for r in F['rows']),
    count_ok=len(allp)<=224,
    cities=[(c['id'],c['city']) for c in allp if c['kind']=='city'],
    smallest_land=sorted([(round(c['poly'].area),c['id']) for c in allp if c['type']=='land'])[:5],
    smallest_sea=sorted([(round(c['poly'].area),c['id']) for c in allp if c['type']=='sea'])[:3])
rows=F['rows']; ext={r['id']:r['map_extent_incl_effects'] for r in rows}
ALLOWED={'Munat','Isor','Dapalle'}
exc=[]; viol=[]
for r in rows:
    e=r['map_extent_incl_effects']
    if e>=980: viol.append((r['id'],r['name'],e,'>=980'))
    elif e<=512:
        why='small city (allowed)' if r['is_city'] and r['city_name'] in ALLOWED else ('island, physically small (allowed)' if r['kind']=='island' else None)
        (exc if why else viol).append((r['id'],r['name'],e,why or '<=512'))
def dist(sel):
    v=np.array([r['map_extent_incl_effects'] for r in rows if sel(r)]); 
    return dict(n=int(len(v)),min=float(v.min()),p10=float(np.percentile(v,10)),median=float(np.median(v)),p90=float(np.percentile(v,90)),max=float(v.max()),
                hist={f'{a}-{a+50}':int(((v>=a)&(v<a+50)).sum()) for a in range(350,1000,50) if ((v>=a)&(v<a+50)).sum()})
res['size_rule']='map extent incl. stroke+blur (longest bbox side) must be >512 and <980 map px; target 650-950'
res['size_all']=dist(lambda r:True)
res['size_land_cells']=dist(lambda r:r['type']=='land' and r['kind']=='cell')
res['size_sea']=dist(lambda r:r['type']=='sea')
res['size_in_target_650_950']=sum(1 for r in rows if 650<=r['map_extent_incl_effects']<=950)
res['size_exceptions_allowed']=exc
res['size_violations']=viol
res['shape_bbox_min_max']=[min(max(r['bbox_w'],r['bbox_h']) for r in rows),max(max(r['bbox_w'],r['bbox_h']) for r in rows)]
names=[r['name'].casefold() for r in rows]
res['duplicate_names']=sorted({n for n in names if names.count(n)>1})
res['tiles_clip_free']=not F['val_bad']
print(json.dumps(res,indent=1,default=str))
json.dump(res,open('versions/v10/regions/provinces_validation.json','w'),indent=1,default=str)
