"""v13 province adjacency (same method as v12) (movement graph) + road/terrain game attributes.
Border test (as v11): shared edge of the "gap Voronoi" (every map px within GAP_REACH of a province goes to the nearest
province, 4 map px raster); neighbours when that edge is >= MIN_SHARED map px. Corner/point contacts are dropped.
link types: land (land-land border), sea (sea-sea border), coastal (sea<->land: sea->land 'landing', land->sea 'embark'),
strait (island <-> nearby mainland across short water, no sea tile needed).
v13: same rules as v12. Rotsla (96) has NO strait links (reachable by sea only); manual land link 5<->9; straits 3-2, 3-5, 72-75 kept;
coastal links recomputed with the new west-coast sea corridor (S41-S52).
road_link: true when a main or secondary road actually crosses the shared border (road line passes from one province's
gap-Voronoi cell straight into the other's). rail_link likewise for railways."""
import pickle, json, csv, numpy as np, os, io, collections, subprocess
from shapely.geometry import Point, LineString
from PIL import Image, ImageDraw, ImageFont
Image.MAX_IMAGE_PIXELS=None
RD='versions/v13/regions'; PV='versions/v13/previews'
F=pickle.load(open('work13/prov13_final.pkl','rb')); P=F['allp']
MJ=json.load(open(f'{RD}/provinces_manifest.json')); M={r['id']:r for r in MJ['provinces']}
subprocess.run(['python3','versions/v13/scripts/voradj13.py'],check=True); subprocess.run(['python3','versions/v13/scripts/attrs13.py'],check=True)
AT=pickle.load(open('work13/attrs13.pkl','rb')); A=AT['A']; ROADS=AT['ROADS']
ids=[c['id'] for c in P]; by={c['id']:c for c in P}
MIN_SHARED=80; GAP_REACH=95; REVIEW_BELOW=140
order={i:k for k,i in enumerate(ids)}
def key(a,b): return (a,b) if order[a]<order[b] else (b,a)
def ctr(c): p=c['poly'].representative_point() if c['kind']!='island' or c['poly'].geom_type=='Polygon' else c['poly'].centroid; return (p.x,p.y)
VOR=pickle.load(open('work13/voradj13.pkl','rb')); V=np.load('work13/vorlab13.npy'); VID=pickle.load(open('work13/vorlab13_ids.pkl','rb')); assert VID==ids
edges={}
for (a,b),sh in VOR.items():
    if sh<MIN_SHARED: continue
    a,b=key(a,b); ti,tj=by[a]['type'],by[b]['type']
    lt='land' if ti==tj=='land' else 'sea' if ti==tj=='sea' else 'coastal'
    edges[(a,b)]=dict(type=lt,shared_border=int(sh),gap=round(by[a]['poly'].distance(by[b]['poly']),1),source='border')
# ---- manual / strait links ----
MANUAL_LAND=[('ZilleTile_5','ZilleTile_9','owner request (kept from v12): Tirsa Northwest <-> Nanta')]
# v12 had a manual land link 34 Vela Nova <-> 38 Rivamare across the narrow Zille Bay inlet (S52). v13: the land cells on the
# north shore (Azzurra) and the south shore (Rivamare) of the inlet west of Zille City get the same link if they are not
# already land neighbours.
from shapely.geometry import Point as _P
def _cell_at(x,y): return min([c for c in P if c['type']=='land'],key=lambda c:c['poly'].distance(_P(x,y)))['id']
_n,_s=_cell_at(7038,6043),_cell_at(7218,6422)
if _n!=_s and VOR.get((_n,_s),VOR.get((_s,_n),0))<MIN_SHARED:
    MANUAL_LAND.append((_n,_s,f'across the narrow Zille Bay inlet (S52): {by[_n]["name"]} (Azzurra shore) <-> {by[_s]["name"]} (Rivamare shore), as v12 34<->38'))
for a,b,why in MANUAL_LAND:
    k=key(a,b); old=edges.get(k)
    edges[k]=dict(type='land',shared_border=int(VOR.get(k,VOR.get((k[1],k[0]),0))),gap=round(by[a]['poly'].distance(by[b]['poly']),1),source='manual',note=why)
    print('manual land link',k,'(was', 'present' if old else 'absent',')')
STRAITS={'ZilleTile_3':['ZilleTile_2','ZilleTile_5'],'ZilleTile_72':['ZilleTile_75']}     # Rotsla 96: none (sea only)
for a,bs in STRAITS.items():
    for b in bs: edges[key(a,b)]=dict(type='strait',water_distance=round(by[a]['poly'].distance(by[b]['poly'])),source='strait')
assert not any(e['type'] in ('land','strait') and 'ZilleTile_96' in k for k,e in edges.items()), 'Rotsla must be sea-only'
# ---- road / rail crossings of shared borders ----
S4=4
def crossings(line,maxzero=50):
    """ordered pairs of Voronoi cells the line passes between (zero runs = outside the reach, allowed up to maxzero samples)"""
    n=max(2,int(line.length/2)); pts=[line.interpolate(t*line.length/n) for t in range(n+1)]
    lab=[int(V[min(int(p.y/S4),V.shape[0]-1),min(int(p.x/S4),V.shape[1]-1)]) for p in pts]
    out=set(); last=0; zr=0
    for l in lab:
        if l==0: zr+=1; continue
        if last and l!=last and zr<=maxzero: out.add(key(ids[last-1],ids[l-1]))
        last=l; zr=0
    return out
CROSS=collections.defaultdict(lambda: collections.defaultdict(set))
for r in ROADS:
    for k in crossings(r['line']): CROSS[k][r['cls']].add(r['id'])
RANK={'main':3,'secondary':2,'minor':1}
for k,e in edges.items():
    cr=CROSS.get(k,{})
    rc=[c for c in ('main','secondary','minor') if cr.get(c)]
    a_,b_=k
    if e['type']=='land':   # a road counts for the border only if it really runs in both provinces (>= MIN_IN map px each)
        for c in list(cr):
            cr[c]={rid for rid in cr[c] if all(rid in (A[x]['main_road_ids']+A[x]['secondary_road_ids']+A[x]['minor_road_ids']+A[x]['railway_ids']) for x in k)}
    e['road_link']=bool(e['type']=='land' and (cr.get('main') or cr.get('secondary')))
    e['road_link_class']=(rc[0] if rc else 'none') if e['type']=='land' else 'none'
    e['road_ids']=sorted(cr.get('main',set())|cr.get('secondary',set())) if e['type']=='land' else []
    e['minor_road_ids']=sorted(cr.get('minor',set())) if e['type']=='land' else []
    e['rail_link']=bool(e['type']=='land' and cr.get('railway'))
# road crossings that are NOT an adjacency edge (diagnostic: road passes a corner/point contact)
odd=sorted([(a,b,sorted(set().union(*[v for c,v in d.items() if c in ('main','secondary')]))) for (a,b),d in CROSS.items()
            if (a,b) not in edges and by[a]['type']==by[b]['type']=='land' and (d.get('main') or d.get('secondary'))])
# ---- per-province lists ----
adj={i:[] for i in ids}
for (a,b),e in edges.items():
    dist=round(float(np.hypot(*(np.array(ctr(by[a]))-np.array(ctr(by[b]))))))
    for x,y in ((a,b),(b,a)):
        t=e['type']; ent=dict(id=y,name=by[y]['name'],type=t,centroid_distance=dist)
        if t=='coastal': ent['direction']='landing (sea->land)' if by[x]['type']=='sea' else 'embark (land->sea)'
        if 'shared_border' in e: ent['shared_border']=e['shared_border']
        if t=='strait': ent['water_distance']=e['water_distance']
        if t=='land': ent.update(road_link=e['road_link'],road_link_class=e['road_link_class'],rail_link=e['rail_link'])
        if e.get('source')=='manual': ent['manual']=True
        adj[x].append(ent)
for k in adj: adj[k].sort(key=lambda e:order[e['id']])
coastal={i for i in ids if by[i]['type']=='land' and any(e['type']=='coastal' for e in adj[i])}
# ---- graph checks ----
def components(sel_edge=lambda t:True, nodes=ids):
    nodes=set(nodes); par={n:n for n in nodes}
    def f(x):
        while par[x]!=x: par[x]=par[par[x]]; x=par[x]
        return x
    for (a,b),e in edges.items():
        if a in nodes and b in nodes and sel_edge(e['type']): par[f(a)]=f(b)
    g=collections.defaultdict(list)
    for n in nodes: g[f(n)].append(n)
    return sorted(g.values(),key=len,reverse=True)
sym=all(any(e['id']==x for e in adj[y]) for x in adj for y in [e['id'] for e in adj[x]])
landids=[i for i in ids if by[i]['type']=='land']
cnt=collections.Counter(e['type'] for e in edges.values())
weak=sorted([(a,b,e['type'],e['shared_border']) for (a,b),e in edges.items() if e.get('source')=='border' and e['shared_border']<REVIEW_BELOW],key=lambda t:t[3])
fmt=lambda C:[[len(c),sorted(c,key=order.get)[:4]] for c in C]
val=dict(provinces=len(ids),land=len(landids),sea=len(ids)-len(landids),edges=len(edges),edge_types=dict(cnt),
    road_links=sum(e['road_link'] for e in edges.values()),
    road_links_main=sum(e['road_link_class']=='main' for e in edges.values()),
    road_links_secondary=sum(e['road_link'] and e['road_link_class']=='secondary' for e in edges.values()),
    minor_road_only_links=sum(e['road_link_class']=='minor' for e in edges.values()),
    rail_links=sum(e['rail_link'] for e in edges.values()),
    min_neighbours=min(len(v) for v in adj.values()),max_neighbours=max(len(v) for v in adj.values()),
    provinces_without_neighbours=[k for k,v in adj.items() if not v],
    symmetric=sym,connected_components_all=len(components()),
    rotsla_96_neighbours=[(e['id'],e['type']) for e in adj['ZilleTile_96']],
    rotsla_sea_only=all(e['type']=='coastal' for e in adj['ZilleTile_96']),
    land_components_with_straits=fmt(components(lambda t:t in('land','strait'),landids)),
    land_components_without_straits=fmt(components(lambda t:t=='land',landids)),
    sea_components=fmt(components(lambda t:t=='sea',[i for i in ids if by[i]['type']=='sea'])),
    coastal_land_provinces=len(coastal),
    manual_links=[(a,b,e['note']) for (a,b),e in edges.items() if e.get('source')=='manual'],
    straits=[(a,b,by[a]['name'],by[b]['name'],e['water_distance']) for (a,b),e in edges.items() if e['type']=='strait'],
    short_borders_to_review=weak,
    main_secondary_road_crossings_without_edge=odd,
    rule=dict(method='gap-voronoi shared edge',gap_reach=GAP_REACH,min_shared_border=MIN_SHARED,review_below=REVIEW_BELOW,
              road_link='main or secondary road line crosses from one province cell into the other (sampled every 2 map px on the gap-Voronoi raster)'))
out=dict(version='v13',description=__doc__,link_types=dict(land='land-land shared border',sea='sea-sea shared border',
         coastal='sea<->land along the coast; on a land province = embark (land->sea / port), on a sea province = landing (sea->land)',
         strait='island <-> nearby mainland across short water without a sea tile'),
    edge_fields=dict(road_link='true when a main or secondary road crosses this border (movement road bonus)',road_link_class='best road crossing the border: main|secondary|minor|none',
         road_ids='main/secondary road ids crossing',minor_road_ids='minor roads crossing',rail_link='true when a railway crosses this border',
         shared_border='length of the shared border (map px)',gap='drawn gap between the two shapes (map px)',water_distance='strait: water crossing (map px)',source='border|manual|strait'),
    provinces={i:dict(name=by[i]['name'],type=by[i]['type'],region=M[i]['region'],owner=M[i]['owner'],rizia_ship_placement=M[i]['rizia_ship_placement'],is_city=M[i]['is_city'],kind=by[i]['kind'],
        coastal=(i in coastal) if by[i]['type']=='land' else None, port=(i in coastal and M[i]['is_city']) if by[i]['type']=='land' else None,
        terrain=A[i]['terrain'] if i in A else None, road_class=A[i]['road_class'] if i in A else None,
        has_main_road=A[i]['has_main_road'] if i in A else None, has_railway=A[i]['has_railway'] if i in A else None,
        centroid=[M[i]['centroid_x'],M[i]['centroid_y']],neighbours=adj[i]) for i in ids},
    edges=[dict(a=a,b=b,**e) for (a,b),e in sorted(edges.items(),key=lambda kv:(order[kv[0][0]],order[kv[0][1]]))],
    validation=val)
json.dump(out,open(f'{RD}/provinces_adjacency.json','w'),indent=1,ensure_ascii=False)
with open(f'{RD}/provinces_adjacency.csv','w',newline='') as f:
    w=csv.writer(f); w.writerow(['from','from_name','to','to_name','link_type','direction','road_link','road_link_class','rail_link','road_ids','shared_border','water_distance','centroid_distance','source'])
    for e in out['edges']:
        a,b=e['a'],e['b']; t=e['type']
        if t=='coastal' and by[a]['type']=='sea': a,b=b,a
        dist=next(x['centroid_distance'] for x in adj[a] if x['id']==b)
        w.writerow([a,by[a]['name'],b,by[b]['name'],t,'land<->sea (embark/landing)' if t=='coastal' else 'both',str(e['road_link']).lower(),e['road_link_class'],str(e['rail_link']).lower(),
                    ' '.join(e['road_ids']),e.get('shared_border',''),e.get('water_distance',''),dist,e['source']])
json.dump(val,open(f'{RD}/provinces_adjacency_validation.json','w'),indent=1)
print(json.dumps({k:v for k,v in val.items() if k not in('short_borders_to_review',)},indent=0)); print('weak',weak)
# ---- manifest: add the game attributes ----
NEWF=dict(is_coastal='land: touches a sea province (embark/landing); null for sea',is_port='land: coastal city province',
    terrain='plains|hills|mountains from the topography contour bands (see terrain_thresholds)',
    elev_band_mean='mean topography band 0..8 inside the province',elev_band_max='max band',elev_band_p90='90th percentile band',elev_share_band_ge4='share of the area at band >= 4',
    has_main_road='a main road (main_roads layer) runs >= 60 map px inside',main_road_ids='main road ids inside',main_road_names='main road names (settlements along it)',
    has_secondary_road='a secondary road (roads_double layer) runs inside',secondary_road_ids='secondary road ids inside',minor_road_ids='minor road ids inside (roads_minor)',
    road_class='most important road inside: main|secondary|minor|none',has_railway='a railway (railway_line layer) runs inside',railway_ids='railway ids inside')
for r in MJ['provinces']:
    i=r['id']; a=A.get(i)
    r['is_coastal']=(i in coastal) if a else None; r['is_port']=(i in coastal and r['is_city']) if a else None
    r['terrain']=a['terrain'] if a else None
    for k,src in (('elev_band_mean','band_mean'),('elev_band_max','band_max'),('elev_band_p90','band_p90'),('elev_share_band_ge4','share_band_ge4')): r[k]=a['elevation'][src] if a else None
    for k in ('has_main_road','main_road_ids','main_road_names','has_secondary_road','secondary_road_ids','minor_road_ids','road_class','has_railway','railway_ids'): r[k]=a[k] if a else None
MJ['fields'].update(NEWF)
MJ['terrain_thresholds']=dict(bands='topography layer contour bands L1..L8 (band = highest contour level a point lies inside; 0 = below L1)',
    mountains=f"band_mean >= {AT['T_MOUNT']['mean']}  OR  (band_p90 >= {AT['T_MOUNT']['p90']} AND share_band_ge4 >= 0.25)",
    hills=f"not mountains AND (band_mean >= {AT['T_HILLS']['mean']}  OR  band_p90 >= {AT['T_HILLS']['p90']})",plains='everything else')
MJ['roads']=[dict(id=r['id'],class_=r['cls'],name=r['name'],svg_layer=r['svg_layer'],length=round(r['line'].length)) for r in ROADS if r['cls']!='minor']
json.dump(MJ,open(f'{RD}/provinces_manifest.json','w'),indent=1)
with open(f'{RD}/provinces_manifest.csv','w',newline='') as f:
    wr=csv.DictWriter(f,fieldnames=list(MJ['provinces'][0].keys())); wr.writeheader()
    for r in MJ['provinces']: wr.writerow({k:(' '.join(v) if isinstance(v,list) else ('' if v is None else v)) for k,v in r.items()})
pickle.dump(dict(edges=edges,adj=adj,coastal=coastal),open('work13/adj13.pkl','wb'))
