"""v6 stage 3: ids, names, neighbours, tiles, manifest, overlay, previews, validation."""
import numpy as np, pickle, json, csv, re, io, os, sys
import resvg_py, cairosvg
from PIL import Image, ImageDraw, ImageFont
from shapely.geometry import Point, Polygon, box, MultiPolygon
from shapely.ops import unary_union
from shapely.strtree import STRtree
Image.MAX_IMAGE_PIXELS=None
OUT='versions/v9'; TD=f'{OUT}/provinces'; os.makedirs(TD,exist_ok=True)
S=pickle.load(open('work/prov9_stage2.pkl','rb')); land=S['land']; sea=S['sea']; SETT=S['SETT']
dd=pickle.load(open('work/land_dec.pkl','rb')); LAND=unary_union([dd['Ld']]+dd['islets'])
MAXB=860
TILE_MAP=980; K=512/980
TIER={'major':0,'key':0,'town':1,'resort_town':2,'village':3,'hamlet':4}
FILL='#FF0000'; STROKE='#00F800'; SW=20; SIG=6
# ---------- ids ----------
def key(c):
    b=c['poly'].bounds; cy=(b[1]+b[3])/2; cx=(b[0]+b[2])/2
    return (int(cy//450),cx)
allp=[]
n=1
for rg in ['Zille','Brenas','Wehlen']:
    L=sorted([c for c in land if c['region']==rg],key=key)
    for c in L: c['id']=f'ZilleTile_{n}'; c['num']=str(n); n+=1; allp.append(c)
for i,c in enumerate(sorted(sea,key=key)): c['id']=f'ZilleTile_S{i+1}'; c['num']=f'S{i+1}'; allp.append(c)
# ---------- names ----------
DIRS=['East','Southeast','South','Southwest','West','Northwest','North','Northeast']
def dirname(v):
    a=np.degrees(np.arctan2(v[1],v[0]))%360; return DIRS[int(((a+22.5)%360)//45)]
for c in allp:
    if c.get('kind')=='city' and c.get('name')=='Zille': c['name']='Zille City'   # province name must differ from the Zille region/map name
used=set(['zille','brenas','wehlen'])
for c in [c for c in allp if c.get('name')]:
    assert c['name'].casefold() not in used, c['name']; used.add(c['name'].casefold())
SN=[(n,p,t) for n,p,t in SETT]
for c in allp:
    if c.get('name'): continue
    g=c['poly']; ct=np.array(g.centroid.coords[0])
    if c['type']=='land':
        inside=sorted([s for s in SN if c['raw'].contains(Point(*s[1]))],key=lambda s:TIER[s[2]])
        cand=[s[0] for s in inside]
        near=sorted(SN,key=lambda s:np.hypot(*(s[1]-ct)))[:6]
        cand+= [f'{s[0]} {dirname(ct-s[1]) if np.hypot(*(ct-s[1]))>60 else "Hills"}' for s in near]
        cand+= [f'{s[0]} {d}' for s in near for d in ['Heights','Fields','Vale','Moor','Woods','Downs']]
    else:
        isl=[('Rotsla',(5745,3643)),('Kreleck',(6450,550)),('Manes Riuz',(9157,1914))]
        dcoast=g.distance(LAND)
        near=sorted(SN,key=lambda s:np.hypot(*(s[1]-ct)))[:5]
        cand=[f'{nm} Sound' for nm,p in isl if np.hypot(ct[0]-p[0],ct[1]-p[1])<750]
        suf=['Waters','Roads','Reach','Bight','Narrows','Banks','Deep','Shoals','Strait','Sound']
        if dcoast>500: cand+=[f'{s[0]} Channel' for s in near]+[f'Mid-Channel {d}' for d in DIRS]
        cand+=[f'{s[0]} {x}' for s in near for x in suf]
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
        is_city=c['kind']=='city',city_name=c.get('city',''),tile_x=tx,tile_y=ty,tile_size_map=TILE_MAP,tile_size_px=512,scale=round(K,6),
        centroid_x=round(ct.x,1),centroid_y=round(ct.y,1),
        map_bbox_x=round(b[0],1),map_bbox_y=round(b[1],1),bbox_w=round(w,1),bbox_h=round(h,1),
        tile_bbox_x=round((b[0]-cx)*K+256,2),tile_bbox_y=round((b[1]-cy)*K+256,2),tile_bbox_w=round(w*K,2),tile_bbox_h=round(h*K,2),
        area=round(c['poly'].area),alpha_w=c['alpha_wh'][0],alpha_h=c['alpha_wh'][1],
        map_extent_incl_effects=round(max(c['alpha_wh'])/K,1),
        neighbours=c['neighbours'],svg_file=f'provinces/{c["id"]}.svg',png_file=f'provinces/{c["id"]}.png',
        kind=c['kind'],island=c.get('island','')))
json.dump(dict(map_size=[12288,8192],tile_size=512,tile_size_map=TILE_MAP,scale_tile_per_map=K,scale_map_per_tile=1/K,
               tile_placement='tile_x/tile_y = top-left of the 980x980 tile on the map; tile px = (map - map_center)*scale + 256',
               style=dict(fill=FILL,stroke=STROKE,stroke_width=SW,figma_layer_blur=12,svg_feGaussianBlur_stdDeviation=SIG),
               map_overlay_style=dict(stroke_width=round(SWM,3),feGaussianBlur_stdDeviation=round(SIGM,3)),
               provinces=rows),open(f'{OUT}/provinces_manifest.json','w'),indent=1)
with open(f'{OUT}/provinces_manifest.csv','w',newline='') as f:
    wr=csv.DictWriter(f,fieldnames=list(rows[0].keys())); wr.writeheader()
    for r in rows: wr.writerow({**r,'neighbours':' '.join(r['neighbours'])})
# ---------- overlay ----------
grp={'Zille':[],'Brenas':[],'Wehlen':[],'Sea':[]}
for c in allp: grp[c['region'] if c['type']=='land' else 'Sea'].append(c)
def overlay(attrs='width="12288" height="8192" viewBox="0 0 12288 8192"'):
    s=[f'<svg xmlns="http://www.w3.org/2000/svg" {attrs}><defs>{FILTM}</defs>']
    for g,L in grp.items():
        s.append(f'<g id="{g.lower()}">')
        s+= [f'<path id="{c["id"]}" data-name="{c["name"]}" d="{path_d(c["poly"])}" {style(SWM)}/>' for c in L]
        s.append('</g>')
    return '\n'.join(s)+'\n</svg>\n'
open(f'{OUT}/provinces_overlay.svg','w').write(overlay())
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
base=Image.open(f'{OUT}/zille_preview.png').convert('RGB')
compose(base,0,0,12288,8192,base.size[0],22).save(f'{OUT}/provinces_preview.png')
CX=(6000,4300,3800,2760)   # framed like the reference screenshot (Zille + western bay sprawl)
tmp='work/crop6.png'; os.system(f'python3 svgcrop.py {OUT}/zille_vector.svg {tmp} {CX[0]} {CX[1]} {CX[2]} {CX[3]} 2400')
compose(Image.open(tmp).convert('RGB'),*CX,2400,30).save(f'{OUT}/provinces_zille_crop.png')
pickle.dump(dict(allp=allp,rows=rows,val_bad=val_bad),open('work/prov9_final.pkl','wb'))
from collections import Counter
print(Counter((r['type'],r['region']) for r in rows),'total',len(rows),'tile violations',val_bad)
print('max alpha w/h',max(r['alpha_w'] for r in rows),max(r['alpha_h'] for r in rows),'max bbox',max(max(r['bbox_w'],r['bbox_h']) for r in rows))
