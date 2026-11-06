"""v14 stage 3: ids, names, neighbours, tiles, manifest, overlay.
Starts from the final v13 provinces (work13/prov13_final.pkl) and replaces:
 * Wehlen mainland: re-partitioned (prov14_land.py): 29 cells + coastal city provinces Kratsna 71 / Grodzizg 94; islands
   72 Kreleck and 96 Rotsla unchanged. Cells re-use the 25 v13 Wehlen cell ids (68-70,73-93,95) by largest overlap
   (Hungarian assignment), the extra cells get new ids ZilleTile_119+.
 * Derdia strip (new region 'Derdia', owner 'Derdia'): the cells south of the Wehlen-Derdia border + Yol (city province,
   impassable: no links, no units) get the next new ids.
 * Brivane block (brivane14.py): v13 ids 55 56 60 61 62 63 65 66 67 re-used by overlap.
 * Seas: unchanged ids; the frame-near seas extended flush to the frame (prov14_sea.py).
Names: untouched provinces keep their v13 names; re-cut cells get names regenerated from the towns they hold (SETT14)."""
import numpy as np, pickle, json, csv, re, io, os, sys
import resvg_py, cairosvg
from PIL import Image, ImageDraw, ImageFont
from shapely.geometry import Point, Polygon, box, MultiPolygon
from shapely.ops import unary_union
from shapely.strtree import STRtree
from scipy.optimize import linear_sum_assignment
Image.MAX_IMAGE_PIXELS=None
OUT='versions/v14'; RD=f'{OUT}/regions'; PV=f'{OUT}/previews'; TD=RD; os.makedirs(PV,exist_ok=True); os.makedirs(TD,exist_ok=True)
for f in os.listdir(RD):
    if re.match(r'ZilleTile_S?\d+\.(png|svg)$',f): os.remove(f'{RD}/{f}')
F13=pickle.load(open('work13/prov13_final.pkl','rb')); P13=F13['allp']; by13={c['id']:c for c in P13}
ED=pickle.load(open('work14/base/edits14.pkl','rb')); SETT=ED['SETT14']
LW=pickle.load(open('work14/land14.pkl','rb')); BV=pickle.load(open('work14/brivane14.pkl','rb')); SEA14=pickle.load(open('work14/sea14.pkl','rb')); LESCUT=set(pickle.load(open('work14/sea14_lespia_cut.pkl','rb')))
sys.path.insert(0,'versions/v14/scripts'); from lespia14 import LES, GAP as GAP_L, TWZ
dd=pickle.load(open('work/land_dec.pkl','rb')); LAND=unary_union([dd['Ld']]+dd['islets'])
MAXB=860
TILE_MAP=980; K=512/980
TIER={'major':0,'key':0,'town':1,'resort_town':2,'resort':2,'village':3,'hamlet':4}
FILL='#FF0000'; STROKE='#00F800'; SW=20; SIG=6
KEEPKEYS=('id','name','region','type','kind','city','island','poly','raw','note')
def cp(c,**kw):
    d={k:c[k] for k in KEEPKEYS if k in c}; d.update(kw); d['type']=d.get('type','land'); return d
def num(i): return int(i.split('_')[1].lstrip('S'))
def hungarian(new,old):
    M=np.zeros((len(new),len(old)))
    for i,g in enumerate(new):
        for j,o in enumerate(old): M[i,j]=g.intersection(o).area
    ri,cj=linear_sum_assignment(-(M+1e9*(M>2000))); out={i:j for i,j in zip(ri,cj) if M[i,j]>0}   # max number of real overlaps first, then total overlap
    # old ids left without a partner (all their overlapping new cells taken): give them to the free new cell with most overlap
    for j in range(len(old)):
        if j in out.values(): continue
        fr=[i for i in range(len(new)) if i not in out and M[i,j]>0]
        if fr: out[max(fr,key=lambda i:M[i,j])]=j
    return out
def rowkey(g):
    b=g.bounds; return (int(((b[1]+b[3])/2)//450),(b[0]+b[2])/2)
WEH_OLD=[c for c in P13 if c['type']=='land' and c['region']=='Wehlen' and c['kind']=='cell']
BLOCK=['ZilleTile_'+n for n in BV['block']]
land=[cp(c) for c in P13 if c['type']=='land' and not (c['region']=='Wehlen' and c['kind'] in ('cell','city')) and c['id'] not in BLOCK]
# --- Wehlen
nxt=119; IDMAP={}
WC=LW['wehlen']; hm=hungarian([c['poly'] for c in WC],[o['poly'] for o in WEH_OLD])
rest=sorted([i for i in range(len(WC)) if i not in hm],key=lambda i:rowkey(WC[i]['poly']))
for i,c in enumerate(WC):
    if i in hm: c['id']=WEH_OLD[hm[i]]['id']
for i in rest: WC[i]['id']=f'ZilleTile_{nxt}'; nxt+=1
NEW_WEHLEN=[WC[i]['id'] for i in rest]
for c in WC: land.append(dict(id=c['id'],region='Wehlen',type='land',kind='cell',poly=c['poly'],raw=c.get('raw',c['poly'])))
land.append(dict(id='ZilleTile_71',name='Kratsna',region='Wehlen',type='land',kind='city',city='Kratsna',poly=LW['kratsna'],raw=LW['kratsna'],
                 note='v14: seaside city - urban area grown along the inlet / harbour front (coastal links)'))
land.append(dict(id='ZilleTile_94',name='Grodzizg',region='Wehlen',type='land',kind='city',city='Grodzizg',poly=LW['grodzizg'],raw=LW['grodzizg'],
                 note='v14: seaside city - the whole peninsula tip + harbour shore (coastal links)'))
# --- Derdia strip + Yol
DC=sorted(LW['derdia'],key=lambda c:(c['poly'].centroid.x))
NEW_DERDIA=[]
for c in DC:
    cid=f'ZilleTile_{nxt}'; nxt+=1; NEW_DERDIA.append(cid)
    land.append(dict(id=cid,region='Derdia',type='land',kind='cell',poly=c['poly'],raw=c.get('raw',c['poly'])))
YOL_ID=f'ZilleTile_{nxt}'; nxt+=1
land.append(dict(id=YOL_ID,name='Yol',region='Derdia',type='land',kind='city',city='Yol',poly=LW['yol'],raw=LW['yol'],impassable=True,
                 note='v14: Derdian port city, IMPASSABLE (no adjacency links, no units, cannot be entered)'))
# --- Brivane block
sys.path.insert(0,'work14'); from sides import RSIDE as _RS, BLINE as _BL
BC=BV['cells']; OLDB=[by13[i] for i in BLOCK]; hb=hungarian([c['poly'] for c in BC],[o['poly'] for o in OLDB])
NEW_BRIV=[]
for i,c in enumerate(BC):
    if i in hb: cid=OLDB[hb[i]]['id']
    else: cid=f'ZilleTile_{nxt}'; nxt+=1; NEW_BRIV.append(cid)
    g=c['poly'].intersection(_RS.difference(_BL.buffer(32))).intersection(box(295,306,11993,7877))     # stay on the Rizian side (32 px off the border) and inside the frame
    g=max(g.geoms,key=lambda q:q.area) if hasattr(g,'geoms') else g
    land.append(dict(id=cid,region='Brenas',type='land',kind='cell',poly=g,raw=g,road_chain=c['chain']))
assert len(hb)==len(BC) or NEW_BRIV
# --- seas
sea=[]
for c in P13:
    if c['type']!='sea': continue
    d=cp(c); d['poly']=SEA14[c['id']]; d['raw']=d['poly']
    if d['poly'].bounds!=c['poly'].bounds and c['id'] not in LESCUT: d['note']=(d.get('note','')+' v14: extended flush to the map frame').strip()
    if c['id'] in LESCUT: d['note']=(d.get('note','')+" v14: cut back out of Lespia's territorial waters (>= %d map px from the Lespian coast)"%GAP_L).strip(); d['lespia_tw_cut']=True
    sea.append(d)
for c in land+sea:
    if 'kind' not in c: c['kind']='sea' if c['type']=='sea' else 'cell'
def idkey(c):
    i=c['id'].split('_')[1]; return (i.startswith('S'),int(i.lstrip('S')))
allp=sorted(land,key=idkey)+sorted(sea,key=idkey)
assert len({c['id'] for c in allp})==len(allp)
for c in allp: c['num']=c['id'].split('_')[1]
RECUT=set(c['id'] for c in WC)|set(BLOCK)|set(NEW_BRIV)|set(NEW_DERDIA)
for c in allp:
    if c['id'] in RECUT and c['kind']=='cell': c.pop('name',None)
SETTN=[(n,np.array(p),t) for n,p,t in SETT]
DIRS=['East','Southeast','South','Southwest','West','Northwest','North','Northeast']
def dirname(v):
    a=np.degrees(np.arctan2(v[1],v[0]))%360; return DIRS[int(((a+22.5)%360)//45)]
used=set(['zille','brenas','wehlen','derdia','morella'])
for c in [c for c in allp if c.get('name')]:
    assert c['name'].casefold() not in used, c['name']; used.add(c['name'].casefold())
SN=SETTN
# prefer settlements of the province's own country (Derdian names for Derdia cells, no Derdian names in Wehlen)
sys.path.insert(0,'versions/v14/scripts')
from sides14 import WSIDE, DSIDE, MSIDE
def country(p):
    P_=Point(*p); return 'Derdia' if DSIDE.contains(P_) else ('Morella' if MSIDE.contains(P_) else 'other')
for c in allp:
    if c.get('name'): continue
    g=c['poly']; ct=np.array(g.centroid.coords[0])
    pool=[s for s in SN if (country(s[1])=='Derdia')==(c['region']=='Derdia') and country(s[1])!='Morella']
    inside=sorted([s for s in pool if g.buffer(40).contains(Point(*s[1]))],key=lambda s:TIER.get(s[2],3))
    cand=[s[0] for s in inside]
    near=sorted(pool,key=lambda s:np.hypot(*(s[1]-ct)))[:6]
    cand+= [f'{s[0]} {dirname(ct-s[1]) if np.hypot(*(ct-s[1]))>60 else "Hills"}' for s in near]
    cand+= [f'{s[0]} {d}' for s in near for d in ['Heights','Fields','Vale','Moor','Woods','Downs']]
    nm=next((x for x in cand if x.casefold() not in used),None)
    if nm is None:
        k=2
        while f'{cand[0]} {k}'.casefold() in used: k+=1
        nm=f'{cand[0]} {k}'
    c['name']=nm; used.add(nm.casefold())
assert len({c['name'].casefold() for c in allp})==len(allp)
# ---------- neighbours ----------
polys=[c['poly'] for c in allp]; tree=STRtree(polys)
for i,c in enumerate(allp):
    nb=[allp[j]['id'] for j in tree.query(c["poly"].buffer(120)) if j!=i and polys[j].distance(c["poly"])<120]
    c['neighbours']=sorted(nb,key=lambda s:(s[10]=='S',int(s.split('_')[1].lstrip('S'))))
# ---------- svg helpers ----------
def ring_d(coords,dx,dy,k=1.0,ox=0.0,oy=0.0):
    pts=list(coords)[:-1]
    return 'M'+' L'.join(f'{(x-dx)*k+ox:.2f},{(y-dy)*k+oy:.2f}' for x,y in pts)+' Z'
def path_d(g,dx=0,dy=0,k=1.0,ox=0.0,oy=0.0):
    g=g.simplify(1.5)
    out=[]
    for p in getattr(g,'geoms',[g]):
        out.append(ring_d(p.exterior.coords,dx,dy,k,ox,oy)); out+= [ring_d(r.coords,dx,dy,k,ox,oy) for r in p.interiors]
    return ' '.join(out)
SWM=SW/K; SIGM=SIG/K       # on-map overlay: stroke/blur scaled up by 980/512
FILT=f'<filter id="layerblur" x="-50%" y="-50%" width="200%" height="200%" color-interpolation-filters="sRGB"><feGaussianBlur stdDeviation="{SIG}"/></filter>'
FILTM=f'<filter id="layerblur" x="-50%" y="-50%" width="200%" height="200%" color-interpolation-filters="sRGB"><feGaussianBlur stdDeviation="{SIGM:.3f}"/></filter>'
def style(sw=None):
    w='%g'%round(sw or SW,3)
    return f'fill="{FILL}" fill-rule="evenodd" stroke="{STROKE}" stroke-width="{w}" stroke-linejoin="round" filter="url(#layerblur)"'
# ---------- owners / starting sides ----------
sys.path.insert(0,'work14')
from sides import RSIDE
RIZ_LAND=[c for c in allp if c['type']=='land' and c['poly'].intersection(RSIDE).area>0.5*c['poly'].area]
for c in allp:
    if c['type']=='sea': c['owner']='neutral'
    elif c['region']=='Derdia': c['owner']='Derdia'
    else: c['owner']='Rizia' if c in RIZ_LAND else 'Wehlen'
    assert c['type']=='sea' or c['region']=='Derdia' or (c['owner']=='Rizia')==(c['region']=='Brenas'), (c['id'],c['region'])
    c['impassable']=bool(c.get('impassable',False))
RL=unary_union([c['poly'] for c in RIZ_LAND])
# ship placement: sea provinces nearest the Rizian coast. West: the two bottom-edge provinces S56/S57 off Areias - Costa
# Dalle - Marbelas (the only Rizian west coast in the map). East: the 5 sea provinces closest to the Rizian coast at
# Mave Nortus / Tarnes (distance from the sea shape to the Rizian land provinces, ties by contact length).
SHIP_W=['ZilleTile_S56','ZilleTile_S57']
east=[]
for c in allp:
    if c['type']!='sea' or c['poly'].centroid.x<9000: continue
    d=c['poly'].distance(RL); con=c['poly'].buffer(140).intersection(RL.buffer(10)).area
    east.append((round(d/40),-con,c['id']))
east.sort(); SHIP_E_NEAREST=[x[2] for x in east[:5]]
# review 1 (owner choice): the 5th east sea is S26 instead of the nearer S25 (S25 touches only the Wehlen Tirsa/Venna coast)
SHIP_E=['ZilleTile_S37','ZilleTile_S30','ZilleTile_S32','ZilleTile_S31','ZilleTile_S26']
SHIP_DIST={x[2]:x for x in east[:9]}
for c in allp:
    c['ship']='rizia_west' if c['id'] in SHIP_W else ('rizia_east' if c['id'] in SHIP_E else '')
print('ship placement west',SHIP_W,'east',SHIP_E,'candidates',east[:9])
# ---------- tiles ----------
rows=[]; val_bad=[]
for c in allp:
    b=c['poly'].bounds; w,h=b[2]-b[0],b[3]-b[1]; cx,cy=(b[0]+b[2])/2,(b[1]+b[3])/2
    tx,ty=round(cx-TILE_MAP/2,2),round(cy-TILE_MAP/2,2)     # 980x980 tile footprint on the map
    svg=(f'<svg xmlns="http://www.w3.org/2000/svg" width="512" height="512" viewBox="0 0 512 512">'
         f'<defs>{FILT}</defs><path id="{c["id"]}" d="{path_d(c["poly"],cx,cy,K,256,256)}" {style()}/></svg>\n')
    open(f'{TD}/{c["id"]}.svg','w').write(svg)
    png=resvg_py.svg_to_bytes(svg_string=svg); im=Image.open(io.BytesIO(bytes(png))); im.save(f'{TD}/{c["id"]}.png')
    a=np.asarray(im)[:,:,3]; ys,xs=np.nonzero(a>0)
    ab=(int(xs.min()),int(ys.min()),int(xs.max()),int(ys.max()))
    c['alpha_bbox']=ab; c['alpha_wh']=(ab[2]-ab[0]+1,ab[3]-ab[1]+1)
    if ab[0]<=0 or ab[1]<=0 or ab[2]>=511 or ab[3]>=511 or w>MAXB or h>MAXB or max(c['alpha_wh'])/K>TILE_MAP: val_bad.append(c['id'])
    ct=c['poly'].centroid
    rows.append(dict(id=c['id'],name=c['name'],type=c['type'],region=c['region'] if c['type']=='land' else 'Sea',
        is_city=c['kind']=='city',city_name=c.get('city',''),tile_x=tx,tile_y=ty,tile_center_x=round(cx,2),tile_center_y=round(cy,2),tile_size_map=TILE_MAP,tile_size_px=512,scale=round(K,6),
        centroid_x=round(ct.x,1),centroid_y=round(ct.y,1),
        map_bbox_x=round(b[0],1),map_bbox_y=round(b[1],1),bbox_w=round(w,1),bbox_h=round(h,1),
        tile_bbox_x=round((b[0]-cx)*K+256,2),tile_bbox_y=round((b[1]-cy)*K+256,2),tile_bbox_w=round(w*K,2),tile_bbox_h=round(h*K,2),
        area=round(c['poly'].area),alpha_w=c['alpha_wh'][0],alpha_h=c['alpha_wh'][1],
        map_extent_incl_effects=round(max(c['alpha_wh'])/K,1),
        neighbours=c['neighbours'],svg_file=f'{c["id"]}.svg',png_file=f'{c["id"]}.png',
        kind=c['kind'],island=c.get('island',''),
        owner=c['owner'],start_owner=c['owner'] if c['type']=='land' else 'none (neutral sea)',
        rizia_ship_placement=bool(c['ship']),ship_placement_side=c['ship'].replace('rizia_','') if c['ship'] else '',
        impassable=c['impassable'],road_chain=bool(c.get('road_chain',False)),
        lespia_distance=round(c['poly'].distance(LES),1),lespia_tw_cut=bool(c.get('lespia_tw_cut',False))))
json.dump(dict(map_size=[12288,8192],tile_size=512,tile_size_map=TILE_MAP,scale_tile_per_map=K,scale_map_per_tile=1/K,
               tile_placement='Each 512x512 tile covers a 980x980 map-px square whose top-left corner is (tile_x, tile_y) and whose centre is (tile_center_x, tile_center_y) = centre of the province map bbox. Draw the PNG scaled by scale_map_per_tile (980/512) at (tile_x, tile_y). Tile px = (map - tile_center)*scale + 256; map = (tile px - 256)/scale + tile_center.',
               fields=dict(id='province id (ZilleTile_N land, ZilleTile_SN sea)',name='unique display name',type='land|sea',region='Zille|Brenas|Wehlen|Derdia|Sea',
                 is_city='true for the city provinces (9 playable + impassable Yol)',city_name='city name for city provinces',
                 tile_x='map x of the top-left of the 980x980 tile footprint',tile_y='map y of the top-left of the 980x980 tile footprint',
                 tile_center_x='map x of the tile centre (= centre of the province bbox)',tile_center_y='map y of the tile centre',
                 tile_size_map='980: tile footprint on the map (map px)',tile_size_px='512: stored tile size (px)',scale='512/980: tile px per map px',
                 centroid_x='map x of the province polygon centroid',centroid_y='map y of the province polygon centroid',
                 map_bbox_x='map x of the province shape bbox (fill only, no stroke/blur)',map_bbox_y='map y of the province shape bbox',bbox_w='bbox width (map px)',bbox_h='bbox height (map px)',
                 tile_bbox_x='shape bbox x inside the 512 tile (px)',tile_bbox_y='shape bbox y inside the 512 tile (px)',tile_bbox_w='shape bbox width in the tile (px)',tile_bbox_h='shape bbox height in the tile (px)',
                 area='province fill area (map px^2)',alpha_w='visible extent in the tile incl. stroke+blur (px)',alpha_h='visible extent height in the tile (px)',
                 map_extent_incl_effects='longest visible side on the map incl. stroke+blur (map px, always < 980)',
                 neighbours='provinces within 120 map px (geometric proximity only; the curated adjacency file comes separately)',
                 svg_file='tile SVG in regions/',png_file='tile PNG in regions/',kind='cell|city|island|sea',island='island name if any',
                 owner='Rizia | Wehlen | Derdia | neutral: who holds the province at game start (land: side of the Rizia-Wehlen border on the source map, Derdia = the Derdian strip south of the Wehlen-Derdia border; seas: no-man\'s-land)',
                 start_owner='starting owner (land) or "none (neutral sea)"',
                 rizia_ship_placement='sea province where Rizia may place a ship at start (2 west + 5 east)',ship_placement_side='west|east for ship-placement seas',impassable='true = the province cannot be entered or crossed (no adjacency links, no units); v14: Yol',road_chain='true for the Brivane road-chain provinces (main road Zille - Brivane on their centre line)',
                 lespia_distance="distance from the province shape to Lespia's coast (map px); every sea province keeps >= lespia_territorial_waters.min_distance",lespia_tw_cut="sea province cut back out of Lespia's territorial waters in v14"),
               lespia_territorial_waters=dict(min_distance=GAP_L,note="non-playable strip between the northern sea provinces and Lespia (the land north of Munat); no province lies in it; labelled on the map"),
               style=dict(fill=FILL,stroke=STROKE,stroke_width=SW,figma_layer_blur=12,svg_feGaussianBlur_stdDeviation=SIG),
               map_overlay_style=dict(stroke_width=round(SWM,3),feGaussianBlur_stdDeviation=round(SIGM,3)),
               provinces=rows),open(f'{RD}/provinces_manifest.json','w'),indent=1)
with open(f'{RD}/provinces_manifest.csv','w',newline='') as f:
    wr=csv.DictWriter(f,fieldnames=list(rows[0].keys())); wr.writeheader()
    for r in rows: wr.writerow({**r,'neighbours':' '.join(r['neighbours'])})
# ---------- overlay ----------
grp={'Zille':[],'Brenas':[],'Wehlen':[],'Derdia':[],'Sea':[]}
for c in allp: grp[c['region'] if c['type']=='land' else 'Sea'].append(c)
def overlay(attrs='width="12288" height="8192" viewBox="0 0 12288 8192"'):
    s=[f'<svg xmlns="http://www.w3.org/2000/svg" {attrs}><defs>{FILTM}</defs>']
    for g,L in grp.items():
        s.append(f'<g id="{g.lower()}">')
        s+= [f'<path id="{c["id"]}" data-name="{c["name"]}" d="{path_d(c["poly"])}" {style(SWM)}/>' for c in L]
        s.append('</g>')
    return '\n'.join(s)+'\n</svg>\n'
open(f'{RD}/provinces_overlay.svg','w').write(overlay())
# ---------- previews ----------
FB='/usr/share/fonts/truetype/sand-box/google/Tinos/Tinos-Bold.ttf'
def compose(base,x,y,w,h,ow,fs,labels=True,op=0.62):
    oh=int(round(ow*h/w))
    ov=resvg_py.svg_to_bytes(svg_string=overlay(f'width="{ow}" height="{oh}" viewBox="{x} {y} {w} {h}"'))
    ov=Image.open(io.BytesIO(bytes(ov))).convert('RGBA').resize(base.size)
    a=np.asarray(ov).astype(float); a[:,:,3]*=op
    out=Image.alpha_composite(base.convert('RGBA'),Image.fromarray(a.astype(np.uint8)))
    d=ImageDraw.Draw(out); f=ImageFont.truetype(FB,fs); sc=base.size[0]/w
    if labels:
        for c in allp:
            p=c['poly'].representative_point(); px,py=(p.x-x)*sc,(p.y-y)*sc
            if 0<=px<base.size[0] and 0<=py<base.size[1]:
                d.text((px,py),c['num'],font=f,fill=(255,255,255),anchor='mm',stroke_width=max(2,fs//8),stroke_fill=(0,0,0))
    return out.convert('RGB')
BASE='work14/base'
base=Image.open(f'{BASE}/zille_preview.png').convert('RGB')
compose(base,0,0,12288,8192,base.size[0],22).save(f'{PV}/provinces_preview.png')
CROPS=dict(provinces_zille_crop=(6000,4300,3800,2760,30),provinces_yol_grodzizg_crop=(3300,2800,2400,2300,34),
  provinces_northeast_sea_crop=(7900,0,4388,4800,30),provinces_channel_yol_crop=(2900,2600,4800,2600,30),
  provinces_zille_bay_corridor_crop=(4800,3700,3300,2900,30),
  derdia_border_crop=(1200,2300,3300,2800,30),brivane_road_crop=(7200,5600,3600,2400,32),
  bottom_edge_crop=(4400,6500,7700,1692,30),kratsna_grodzizg_crop=(3700,250,2800,3700,32),
  lespia_territorial_waters_crop=(7600,250,4688,2900,30),wehlen_crop=(1200,250,5200,4000,28))
for nm,(x,y,w,h,fs) in CROPS.items():
    os.system(f'python3 versions/v14/scripts/svgcrop.py {BASE}/zille_vector.svg work14/tmp/crop_{nm}.png {x} {y} {w} {h} 2400')
    compose(Image.open(f'work14/tmp/crop_{nm}.png').convert('RGB'),x,y,w,h,2400,fs).save(f'{PV}/{nm}.png')
pickle.dump(dict(allp=allp,rows=rows,val_bad=val_bad,new_wehlen=NEW_WEHLEN,new_derdia=NEW_DERDIA,yol=YOL_ID,new_brivane=NEW_BRIV,block=BLOCK),open('work14/prov14_final.pkl','wb'))
print('new Wehlen',NEW_WEHLEN,'Derdia',NEW_DERDIA,'Yol',YOL_ID,'new Brivane',NEW_BRIV)
from collections import Counter
print(Counter((r['type'],r['region']) for r in rows),'total',len(rows),'tile violations',val_bad)
print('max alpha w/h',max(r['alpha_w'] for r in rows),max(r['alpha_h'] for r in rows),'max bbox',max(max(r['bbox_w'],r['bbox_h']) for r in rows))
