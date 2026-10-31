"""v13 starting provinces (regions/starting_provinces.json/.csv) + ownership/start preview + v12-vs-v13 before/after previews."""
import json, csv, pickle, numpy as np
from PIL import Image, ImageDraw, ImageFont
Image.MAX_IMAGE_PIXELS=None
RD='versions/v13/regions'; PV='versions/v13/previews'
FB='/usr/share/fonts/truetype/sand-box/google/Tinos/Tinos-Bold.ttf'
M=json.load(open(f'{RD}/provinces_manifest.json'))['provinces']; R={r['id']:r for r in M}
AJ=json.load(open(f'{RD}/provinces_adjacency.json'))
F=pickle.load(open('work13/prov13_final.pkl','rb')); P=F['allp']; by={c['id']:c for c in P}
key=lambda i:(i.split('_')[1].startswith('S'),int(i.split('_')[1].lstrip('S')))
def L(owner): return sorted([r['id'] for r in M if r['owner']==owner],key=key)
riz,weh,neu=L('Rizia'),L('Wehlen'),L('neutral')
west=sorted([r['id'] for r in M if r['ship_placement_side']=='west'],key=key); east=sorted([r['id'] for r in M if r['ship_placement_side']=='east'],key=key)
def ent(i): r=R[i]; return dict(id=i,name=r['name'],region=r['region'],is_city=r['is_city'],terrain=r['terrain'])
def sea_ent(i):
    r=R[i]; nb=[n['id'] for n in AJ['provinces'][i]['neighbours'] if R[n['id']]['type']=='land']
    return dict(id=i,name=r['name'],side=r['ship_placement_side'],coast_neighbours=[f"{n} {R[n]['name']} ({R[n]['owner']})" for n in nb],sea_neighbours=[n['id'] for n in AJ['provinces'][i]['neighbours'] if R[n['id']]['type']=='sea'])
out=dict(version='v13',
 rule='Land provinces start with the side of the Rizia-Wehlen border (borders_land layer of the source map) that holds the province area. '
      'Zille (with the Wiktrany/Zille/Nanta/Isor/Munat cities) and the Wehlen region incl. Kratsna, Grodzizg, Rotsla and the Kreleck Islands are Wehlen; '
      'the Brenas region (Dapalle, Marbelas ...) and the Mave Nortus city are Rizia. All sea provinces are neutral (no owner).',
 ship_rule='Rizia may place ships at start only in the 7 seas listed in rizia_ship_placement: 2 on the west coast and 5 on the east coast, '
      'the seas closest to Rizian land on each side.',
 west_ship_seas_note='The west Rizian coast (Praia Velha border point at y~7120 down to Costa Dalle / Marbelas) had no sea provinces in v12. '
      'v13 extends the sea to the bottom edge with S54-S57; the two bottom seas S56 Costa Dalle Waters and S57 Marbelas Bight are the only seas '
      'whose coast is Rizian (S57 touches Rizian land, S56 lies directly offshore of it), so they are the 2 west ship-placement seas. '
      'S54/S55 lie off the Wehlen-held Praia Velha / Santa Calla coast and are neutral without ship placement.',
 east_ship_seas_note='East: S37, S30, S32, S31 touch the Rizian coast at the Mave Nortus inlet / Tarnes; the 5th sea is S26 Tarnes Waters '
      '(owner choice in review 1, instead of S25 Tirsa Banks which only touches the Wehlen Tirsa/Venna coast). S26 lies off Tarnes, north of S31/S32.',
 counts=dict(rizia=len(riz),wehlen=len(weh),neutral_sea=len(neu),rizia_ship_seas=len(west)+len(east)),
 rizia=[ent(i) for i in riz], wehlen=[ent(i) for i in weh], neutral_seas=[dict(id=i,name=R[i]['name']) for i in neu],
 rizia_ship_placement=dict(west=[sea_ent(i) for i in west],east=[sea_ent(i) for i in east]))
json.dump(out,open(f'{RD}/starting_provinces.json','w'),indent=1,ensure_ascii=False)
with open(f'{RD}/starting_provinces.csv','w',newline='') as f:
    w=csv.writer(f); w.writerow(['id','name','type','region','start_owner','is_city','rizia_ship_placement','ship_placement_side'])
    for i in sorted(R,key=key):
        r=R[i]; w.writerow([i,r['name'],r['type'],r['region'],r['owner'],r['is_city'],r['rizia_ship_placement'],r['ship_placement_side']])
print(out['counts'],west,east)
# ---------------- ownership preview ----------------
def ctr(c): p=c['poly'].representative_point(); return (p.x,p.y)
def polys(g):
    for q in getattr(g,'geoms',[g]): yield q
COL={'Rizia':(40,170,60,150),'Wehlen':(230,140,30,150),'neutral':(120,170,230,90)}
def own(img,x0,y0,sc,out,fs,lw):
    im=Image.blend(img.convert('RGB'),Image.new('RGB',img.size,(255,255,255)),0.4).convert('RGBA'); ov=Image.new('RGBA',im.size,(0,0,0,0)); d=ImageDraw.Draw(ov); f=ImageFont.truetype(FB,fs)
    for c in P:
        r=R[c['id']]; col=COL[r['owner']]
        if r['rizia_ship_placement']: col=(0,60,200,170)
        for q in polys(c['poly']): d.polygon([((x-x0)*sc,(y-y0)*sc) for x,y in q.exterior.coords],fill=col,outline=(40,40,40,220),width=max(1,lw//2))
    for c in P:
        x,y=ctr(c); r=R[c['id']]; t=c['id'].split('_')[1]+(' ★' if r['is_city'] else '')+(' ⚓' if r['rizia_ship_placement'] else '')
        d.text(((x-x0)*sc,(y-y0)*sc),c['id'].split('_')[1]+(' C' if r['is_city'] else '')+(' SHIP' if r['rizia_ship_placement'] else ''),font=f,fill=(0,0,0,255),anchor='mm',stroke_width=max(2,fs//7),stroke_fill=(255,255,255,255))
    items=[(f'Rizia start ({len(riz)})',COL['Rizia']),(f'Wehlen start ({len(weh)})',COL['Wehlen']),(f'neutral sea ({len(neu)-7})',COL['neutral']),
           ('neutral sea, Rizia ship placement (2 west + 5 east)',(0,60,200,170))]
    w=fs*26; d.rectangle([10,10,10+w,10+fs*1.5*(len(items)+1)+10],fill=(255,255,255,235),outline=(0,0,0,255))
    for k,(lab,col) in enumerate(items):
        yy=20+k*fs*1.5+fs*0.5; d.rectangle([20,yy-fs*0.45,20+fs*2,yy+fs*0.45],fill=col,outline=(0,0,0,255)); d.text((30+fs*2,yy),lab,font=f,fill=(0,0,0,255),anchor='lm')
    d.text((20,20+len(items)*fs*1.5+fs*0.5),'label: id, C = city province, SHIP = ship placement',font=f,fill=(0,0,0,255),anchor='lm')
    Image.alpha_composite(im,ov).convert('RGB').save(out)
bm=Image.open('work13/base/zille_preview.png'); own(bm,0,0,bm.size[0]/12288,f'{PV}/ownership_start_preview.png',22,3)
# ---------------- before / after ----------------
def side(a,b,out,title_a,title_b,W=2400):
    A_=Image.open(a).convert('RGB'); B_=Image.open(b).convert('RGB')
    h=round(A_.size[1]*W/A_.size[0]); A_=A_.resize((W,h),Image.LANCZOS); B_=B_.resize((W,h),Image.LANCZOS)
    im=Image.new('RGB',(2*W+20,h+70),(255,255,255)); im.paste(A_,(0,70)); im.paste(B_,(W+20,70)); d=ImageDraw.Draw(im); f=ImageFont.truetype(FB,44)
    d.text((W//2,35),title_a,font=f,fill=(0,0,0),anchor='mm'); d.text((W+20+W//2,35),title_b,font=f,fill=(0,0,0),anchor='mm'); im.save(out)
side('versions/v12/previews/provinces_preview.png',f'{PV}/provinces_preview.png',f'{PV}/before_after_v12_v13_full.png','v12 (148 provinces)',f'v13 ({len(M)} provinces)')
side('versions/v12/previews/provinces_zille_crop.png',f'{PV}/provinces_zille_crop.png',f'{PV}/before_after_v12_v13_zille_crop.png','v12 Zille','v13 Zille')
side('versions/v12/previews/terrain_roads_zille_crop.png',f'{PV}/terrain_roads_zille_crop.png',f'{PV}/before_after_v12_v13_terrain_roads_zille.png','v12 terrain + roads','v13 terrain + roads (re-routed main road, Quella Highlands, Ondaro Hills)')
print('ok')
