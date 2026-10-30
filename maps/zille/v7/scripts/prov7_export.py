"""v6 stage 3: ids, names, neighbours, tiles, manifest, overlay, previews, validation."""
import numpy as np, pickle, json, csv, re, io, os, sys
import resvg_py, cairosvg
from PIL import Image, ImageDraw, ImageFont
from shapely.geometry import Point, Polygon, box, MultiPolygon
from shapely.ops import unary_union
from shapely.strtree import STRtree
Image.MAX_IMAGE_PIXELS=None
OUT='versions/v7'; TD=f'{OUT}/provinces'; os.makedirs(TD,exist_ok=True)
S=pickle.load(open('work/prov7_stage2.pkl','rb')); land=S['land']; sea=S['sea']; SETT=S['SETT']
dd=pickle.load(open('work/land_dec.pkl','rb')); LAND=unary_union([dd['Ld']]+dd['islets'])
MAXB=454
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
used=set()
for c in [c for c in allp if c.get('name')]: used.add(c['name'])
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
    nm=next((x for x in cand if x not in used),None) or f'{cand[0]} {len(used)}'
    c['name']=nm; used.add(nm)
# ---------- neighbours ----------
polys=[c['poly'] for c in allp]; tree=STRtree(polys)
for i,c in enumerate(allp):
    nb=[allp[j]['id'] for j in tree.query(c["poly"].buffer(75)) if j!=i and polys[j].distance(c["poly"])<75]
    c['neighbours']=sorted(nb,key=lambda s:(s[10]=='S',int(s.split('_')[1].lstrip('S'))))
# ---------- svg helpers ----------
def ring_d(coords,dx,dy):
    pts=list(coords)[:-1]
    return 'M'+' L'.join(f'{x-dx:.1f},{y-dy:.1f}' for x,y in pts)+' Z'
def path_d(g,dx=0,dy=0):
    g=g.simplify(1.2)
    out=[]
    for p in getattr(g,'geoms',[g]):
        out.append(ring_d(p.exterior.coords,dx,dy)); out+= [ring_d(r.coords,dx,dy) for r in p.interiors]
    return ' '.join(out)
FILT=f'<filter id="layerblur" x="-50%" y="-50%" width="200%" height="200%" color-interpolation-filters="sRGB"><feGaussianBlur stdDeviation="{SIG}"/></filter>'
def style(): return f'fill="{FILL}" fill-rule="evenodd" stroke="{STROKE}" stroke-width="{SW}" stroke-linejoin="round" filter="url(#layerblur)"'
# ---------- tiles ----------
rows=[]; val_bad=[]
for c in allp:
    b=c['poly'].bounds; w,h=b[2]-b[0],b[3]-b[1]; cx,cy=(b[0]+b[2])/2,(b[1]+b[3])/2
    tx,ty=int(round(cx-256)),int(round(cy-256))
    svg=(f'<svg xmlns="http://www.w3.org/2000/svg" width="512" height="512" viewBox="0 0 512 512">'
         f'<defs>{FILT}</defs><path id="{c["id"]}" d="{path_d(c["poly"],tx,ty)}" {style()}/></svg>\n')
    open(f'{TD}/{c["id"]}.svg','w').write(svg)
    png=resvg_py.svg_to_bytes(svg_string=svg); im=Image.open(io.BytesIO(bytes(png))); im.save(f'{TD}/{c["id"]}.png')
    a=np.asarray(im)[:,:,3]; ys,xs=np.nonzero(a>0)
    ab=(int(xs.min()),int(ys.min()),int(xs.max()),int(ys.max()))
    c['alpha_bbox']=ab; c['alpha_wh']=(ab[2]-ab[0]+1,ab[3]-ab[1]+1)
    if ab[0]<=0 or ab[1]<=0 or ab[2]>=511 or ab[3]>=511 or w>MAXB or h>MAXB: val_bad.append(c['id'])
    ct=c['poly'].centroid
    rows.append(dict(id=c['id'],name=c['name'],type=c['type'],region=c['region'] if c['type']=='land' else 'Sea',
        is_city=c['kind']=='city',city_name=c.get('city',''),tile_x=tx,tile_y=ty,centroid_x=round(ct.x,1),centroid_y=round(ct.y,1),
        bbox_w=round(w,1),bbox_h=round(h,1),area=round(c['poly'].area),alpha_w=c['alpha_wh'][0],alpha_h=c['alpha_wh'][1],
        neighbours=c['neighbours'],svg_file=f'provinces/{c["id"]}.svg',png_file=f'provinces/{c["id"]}.png',
        kind=c['kind'],island=c.get('island','')))
json.dump(dict(map_size=[12288,8192],tile_size=512,style=dict(fill=FILL,stroke=STROKE,stroke_width=SW,figma_layer_blur=12,svg_feGaussianBlur_stdDeviation=SIG),
               provinces=rows),open(f'{OUT}/provinces_manifest.json','w'),indent=1)
with open(f'{OUT}/provinces_manifest.csv','w',newline='') as f:
    wr=csv.DictWriter(f,fieldnames=list(rows[0].keys())); wr.writeheader()
    for r in rows: wr.writerow({**r,'neighbours':' '.join(r['neighbours'])})
# ---------- overlay ----------
grp={'Zille':[],'Brenas':[],'Wehlen':[],'Sea':[]}
for c in allp: grp[c['region'] if c['type']=='land' else 'Sea'].append(c)
def overlay(attrs='width="12288" height="8192" viewBox="0 0 12288 8192"'):
    s=[f'<svg xmlns="http://www.w3.org/2000/svg" {attrs}><defs>{FILT}</defs>']
    for g,L in grp.items():
        s.append(f'<g id="{g.lower()}">')
        s+= [f'<path id="{c["id"]}" data-name="{c["name"]}" d="{path_d(c["poly"])}" {style()}/>' for c in L]
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
CX=(6200,4500,3300,2400)   # framed like the reference screenshot (Zille + western bay sprawl)
tmp='work/crop6.png'; os.system(f'python3 svgcrop.py {OUT}/zille_vector.svg {tmp} {CX[0]} {CX[1]} {CX[2]} {CX[3]} 2400')
compose(Image.open(tmp).convert('RGB'),*CX,2400,30).save(f'{OUT}/provinces_zille_crop.png')
pickle.dump(dict(allp=allp,rows=rows,val_bad=val_bad),open('work/prov7_final.pkl','wb'))
from collections import Counter
print(Counter((r['type'],r['region']) for r in rows),'total',len(rows),'tile violations',val_bad)
print('max alpha w/h',max(r['alpha_w'] for r in rows),max(r['alpha_h'] for r in rows),'max bbox',max(max(r['bbox_w'],r['bbox_h']) for r in rows))
