"""v13 review 1: forts + defence lines, black frame.
 - frame: the outer map frame (<g id="frame">, rect stroke #bf3636) becomes black #000000 (the province mask stroke #00F800 is NOT touched)
 - forts in cities: the vector base map has no fort symbols (the dotted rings around Zille/Yol on the source raster were never
   vectorised) and v12/v13 had no fort data; city provinces always get fort = none.
 - border_west (HEAVY) / border_east (LIGHT): every Zille (Wehlen-held) non-city province with a land link to a Brenas (Rizia)
   province. West/east = position of the province's contact along the border line, measured from the Mave Nortus inlet:
   the western half (towards the west coast, Zille City / Pomara / Celle Vaz) is heavy, the eastern half (Dapalle, Ossa,
   Venna, Mave Nortus) is light.
 - north_line (LIGHT): inner defence line across the north of the Zille peninsula = minimum vertex cut (land links, Zille
   only, cities not allowed) between the northern cities (Munat 2, Nanta 9, Isor 11) and the southern core (Wiktrany 28,
   Zille City 35), restricted to the northern half of the peninsula.
 - review 2: forts are data only (NOT drawn on the map art); symbols appear only on previews/forts_*.png: heavy = black bastioned star fort, light = small
   outlined bastioned square; placed inside the province towards the threat, away from roads/towns.
-> regions/forts.json/.csv, manifest fields fort/defense_line (json+csv), work13/base/zille_vector.svg + zille_preview.png,
   previews/forts_preview.png"""
import json, csv, pickle, sys, re, numpy as np, networkx as nx, cairosvg
sys.path.insert(0,'work13')
from sides import BORDER, RSIDE
from lib import layer_lines, group
from shapely.geometry import Point, Polygon
from shapely.ops import unary_union, nearest_points
from PIL import Image, ImageDraw, ImageFont
Image.MAX_IMAGE_PIXELS=None
RD='versions/v13/regions'; PV='versions/v13/previews'
MJ=json.load(open(f'{RD}/provinces_manifest.json')); M={r['id']:r for r in MJ['provinces']}
AJ=json.load(open(f'{RD}/provinces_adjacency.json'))
F=pickle.load(open('work13/prov13_final.pkl','rb')); by={c['id']:c for c in F['allp']}
E=[(e['a'],e['b'],e['type']) for e in AJ['edges']] if isinstance(AJ['edges'],list) else None
if E is None: E=[(a,b,e['type']) for (a,b),e in AJ['edges'].items()]
def nb(i,types=('land',)): return [b if a==i else a for a,b,t in E if t in types and i in (a,b)]
Z=[i for i,r in M.items() if r['region']=='Zille']
ISCITY=lambda i:M[i]['is_city']
BREN=unary_union([by[i]['poly'] for i,r in M.items() if r['region']=='Brenas'])
L=BORDER.length
fort={}; line={}
for i in Z:
    if ISCITY(i): continue
    if any(M[j]['region']=='Brenas' for j in nb(i)):
        g=by[i]['poly']; p=g.buffer(140).intersection(BREN.buffer(140))
        t=BORDER.project(p.centroid if not p.is_empty else g.centroid)/L
        line[i]='border_west' if t>=0.5 else 'border_east'; fort[i]='heavy' if t>=0.5 else 'light'
# north line (review 2, owner request "Marenta - north of Nanta"): chain of adjacent Zille land provinces from the province
# holding Marenta (west coast) to the province just north of Nanta on the east coast, no cities / border-line provinces,
# as close as possible to the straight segment Marenta -> north of Nanta; it must cut the peninsula by land
from shapely.geometry import LineString as _LS
G=nx.Graph()
for a_,b_,t in E:
    if t=='land' and M[a_]['region']=='Zille' and M[b_]['region']=='Zille': G.add_edge(a_,b_)
S12_=pickle.load(open('work/prov12_stage2.pkl','rb')); TW={n:p for n,p,t in S12_['SETT']}
P_MAR=Point(*TW['Marenta']); P_NAN=Point(TW['Nanta'][0]-250,TW['Nanta'][1]-380)     # "just north of Nanta"
A_=min([i for i in G if not ISCITY(i)],key=lambda i:by[i]['poly'].distance(P_MAR))
B_=min([i for i in G if not ISCITY(i) and M[i]['centroid_y']<M['ZilleTile_9']['centroid_y']],key=lambda i:by[i]['poly'].distance(P_NAN))
SEG=_LS([(P_MAR.x,P_MAR.y),(P_NAN.x,P_NAN.y)])
H_=G.subgraph([i for i in G if not ISCITY(i) and i not in line]).copy()
for u,v in H_.edges:
    H_[u][v]['w']=sum(1+by[x]['poly'].centroid.distance(SEG)/150 for x in (u,v))
cut=nx.shortest_path(H_,A_,B_,weight='w')
# land cut check: without the line (and without strait links) Munat / Isor are separated from Zille City / Wiktrany
R_=G.copy(); R_.remove_nodes_from(cut)
assert not nx.has_path(R_,'ZilleTile_2','ZilleTile_35') and not nx.has_path(R_,'ZilleTile_11','ZilleTile_28'), 'north line is not a land cut'
NORTH_SIDE=sorted(nx.node_connected_component(R_,'ZilleTile_2'),key=lambda s:int(s.split('_')[1]))
for i in cut: fort[i]='light'; line[i]='north_line'
print('north line',A_,'->',B_,[(i,M[i]['name']) for i in cut],'north side',[i.split('_')[1] for i in NORTH_SIDE])
# ---- symbol placement ----
SVG0=open('work13/base/zille_vector_pre_review1.svg').read()
ROADS=unary_union([ln for g in ('main_roads','roads_double_fill','roads_minor','railway_line') for _,ln in layer_lines(g,SVG0)])
RIV=unary_union([ln for _,ln in layer_lines('rivers',SVG0)])
S12=pickle.load(open('work/prov12_stage2.pkl','rb')); TOWNS=[Point(*p) for n,p,t in S12['SETT']]
from shapely.geometry import box as _box
LBL=[]
for m in re.finditer(r'<text[^>]*x="([\d.]+)" y="([\d.]+)"[^>]*font-size="([\d.]+)"[^>]*>([^<]*)</text>',SVG0):
    x,y,fs,t=float(m.group(1)),float(m.group(2)),float(m.group(3)),m.group(4)
    LBL.append(_box(x-10,y-fs*0.85,x+len(t)*fs*0.62+10,y+fs*0.25))
LBLU=unary_union(LBL)
def place(i):
    g=by[i]['poly']; inner=g.buffer(-95)
    if inner.is_empty or inner.area<4000: inner=g.buffer(-60)
    if line[i]=='north_line':
        S=unary_union([by[j]['poly'] for j in nb(i) if M[j]['centroid_y']>M[i]['centroid_y']+80]) or g
        tgt=S.centroid
    else: tgt=nearest_points(BREN,g.centroid)[0]
    b=inner.bounds; best=None
    for x in np.arange(b[0],b[2],20):
        for y in np.arange(b[1],b[3],20):
            p=Point(x,y)
            if not inner.contains(p): continue
            pen=0
            dr=p.distance(ROADS); pen+=max(0,60-dr)*40
            pen+=max(0,40-p.distance(RIV))*40
            pen+=max(0,130-min(p.distance(t) for t in TOWNS))*25
            pen+=max(0,75-p.distance(LBLU))*60
            sc=p.distance(tgt)+pen
            if best is None or sc<best[0]: best=(sc,p)
    return best[1] if best else g.representative_point()
def star(cx,cy,R,r,n):
    pts=[]
    for k in range(2*n):
        a=-np.pi/2+k*np.pi/n; rr=R if k%2==0 else r; pts.append(f'{cx+rr*np.cos(a):.1f},{cy+rr*np.sin(a):.1f}')
    return ' '.join(pts)
syms=[]; FO=[]
for i in sorted(fort,key=lambda s:(line[s],int(s.split('_')[1]))):
    p=place(i); fid=f"fort_{i.split('_')[1]}"
    if fort[i]=='heavy':
        syms.append(f'<g id="{fid}" class="fort_heavy"><polygon points="{star(p.x,p.y,62,36,5)}" fill="#141414" stroke="#ffffff" stroke-width="7" stroke-linejoin="round"/>'
                    f'<circle cx="{p.x:.1f}" cy="{p.y:.1f}" r="11" fill="#ffffff"/></g>')
    else:
        syms.append(f'<g id="{fid}" class="fort_light"><polygon points="{star(p.x,p.y,40,24,4)}" fill="#ffffff" stroke="#141414" stroke-width="7" stroke-linejoin="round"/></g>')
    FO.append(dict(province_id=i,province_name=M[i]['name'],region=M[i]['region'],owner=M[i]['owner'],fort=fort[i],defense_line=line[i],
                   symbol_x=round(p.x,1),symbol_y=round(p.y,1),faces=[j for j in nb(i) if M[j]['region']=='Brenas'] if line[i]!='north_line' else []))
G_FORTS='<g id="forts_overlay_preview_only">\n'+'\n'.join(syms)+'\n</g>\n'
# review 2: forts are DATA ONLY - the base map (and so the map tiles / composite / root files) get only the black frame, no fort symbols
s=SVG0.replace('stroke="#bf3636"','stroke="#000000"')
assert s.count('stroke="#000000" stroke-width="25"')==1 and 'fort' not in s
open('work13/base/zille_vector.svg','w').write(s)
cairosvg.svg2png(bytestring=s.encode(),write_to='work13/base/zille_preview.png',output_width=4096,output_height=2731)
# ---- data ----
LINES={'border_west':'Brenas-Zille border, western half (west coast - Celle Vaz - Pomara - Zille City): HEAVY forts on the Zille (Wehlen) side',
       'border_east':'Brenas-Zille border, eastern half (Dapalle - Ossa - Venna - Mave Nortus inlet): LIGHT forts on the Zille (Wehlen) side',
       'north_line':'inner (second) defence line Marenta - north of Nanta across the Zille peninsula: LIGHT forts; it shields the north-west of the peninsula (Isor, Quella, Corvis, Munat)'}
json.dump(dict(version='v13 review 1',fort_types={'none':'no fort','light':'light fort','heavy':'heavy fort'},defense_lines=LINES,
     cities_note='no forts in city provinces (owner request); the vector base map never had fort symbols in cities',
     map_art_note='review 2: forts are data only - not drawn in the base map, map tiles or composite. symbol_x/symbol_y = suggested marker position (map px) used only by the forts overlay previews.',
     counts={l:sum(1 for f in FO if f['defense_line']==l) for l in LINES},forts=FO),open(f'{RD}/forts.json','w'),indent=1,ensure_ascii=False)
with open(f'{RD}/forts.csv','w',newline='') as f:
    w=csv.writer(f); w.writerow(['province_id','province_name','fort','defense_line','symbol_x','symbol_y','faces'])
    for r in FO: w.writerow([r['province_id'],r['province_name'],r['fort'],r['defense_line'],r['symbol_x'],r['symbol_y'],' '.join(r['faces'])])
# manifest fields
for r in MJ['provinces']:
    r['fort']=fort.get(r['id'],'none') if r['type']=='land' else None; r['defense_line']=line.get(r['id'],'') if r['type']=='land' else None
MJ['fields']['fort']='none|light|heavy (land; null for sea)'; MJ['fields']['defense_line']='border_west|border_east|north_line or empty (see regions/forts.json)'
json.dump(MJ,open(f'{RD}/provinces_manifest.json','w'),indent=1,ensure_ascii=False)
rows=list(csv.DictReader(open(f'{RD}/provinces_manifest.csv')))
cols=[c for c in rows[0].keys() if c not in ('fort','defense_line')]; cols=cols[:cols.index('owner')]+['fort','defense_line']+cols[cols.index('owner'):] if 'owner' in cols else cols+['fort','defense_line']
with open(f'{RD}/provinces_manifest.csv','w',newline='') as f:
    w=csv.DictWriter(f,fieldnames=cols); w.writeheader()
    for r in rows:
        r['fort']=fort.get(r['id'],'none') if r['type']=='land' else ''; r['defense_line']=line.get(r['id'],''); w.writerow({k:r.get(k,'') for k in cols})
for i,p in AJ['provinces'].items():
    p['fort']=fort.get(i,'none') if p['type']=='land' else None; p['defense_line']=line.get(i,'') if p['type']=='land' else None
json.dump(AJ,open(f'{RD}/provinces_adjacency.json','w'),indent=1,ensure_ascii=False)
# ---- preview ----
bm=Image.open('work13/base/zille_preview.png').convert('RGB'); sc=bm.size[0]/12288
im=Image.blend(bm,Image.new('RGB',bm.size,(255,255,255)),0.25).convert('RGBA'); ov=Image.new('RGBA',im.size,(0,0,0,0)); d=ImageDraw.Draw(ov)
FB='/usr/share/fonts/truetype/sand-box/google/Tinos/Tinos-Bold.ttf'; f=ImageFont.truetype(FB,20)
COL={'border_west':(200,0,0,120),'border_east':(255,150,0,120),'north_line':(0,110,230,120)}
for c in F['allp']:
    i=c['id']; col=COL.get(line.get(i),(40,170,60,70) if M[i]['owner']=='Rizia' else ((0,0,0,0) if M[i]['type']=='sea' else (230,200,150,60)))
    for q in getattr(c['poly'],'geoms',[c['poly']]): d.polygon([(x*sc,y*sc) for x,y in q.exterior.coords],fill=col,outline=(60,60,60,200))
    if i in line or M[i]['is_city']:
        p=c['poly'].representative_point(); d.text((p.x*sc,p.y*sc+18),i.split('_')[1],font=f,fill=(0,0,0),anchor='mm',stroke_width=3,stroke_fill=(255,255,255))
X=[('heavy fort - border_west',COL['border_west']),('light fort - border_east',COL['border_east']),('light fort - north_line (inner line)',COL['north_line']),('Rizia (Brenas)',(40,170,60,120))]
d.rectangle([10,10,560,30+34*len(X)],fill=(255,255,255,235),outline=(0,0,0))
for k,(t,c) in enumerate(X):
    y=28+34*k; d.rectangle([20,y-10,60,y+10],fill=c,outline=(0,0,0)); d.text((70,y),t,font=ImageFont.truetype(FB,24),fill=(0,0,0),anchor='lm')
for r in FO:   # fort markers drawn on the overlay preview only
    x,y=r['symbol_x']*sc,r['symbol_y']*sc
    if r['fort']=='heavy':
        pts=[(x+15*np.cos(-np.pi/2+k*np.pi/5)*(1 if k%2==0 else 0.58),y+15*np.sin(-np.pi/2+k*np.pi/5)*(1 if k%2==0 else 0.58)) for k in range(10)]
        d.polygon(pts,fill=(20,20,20,255),outline=(255,255,255,255))
    else:
        pts=[(x+11*np.cos(-np.pi/2+k*np.pi/4)*(1 if k%2==0 else 0.6),y+11*np.sin(-np.pi/2+k*np.pi/4)*(1 if k%2==0 else 0.6)) for k in range(8)]
        d.polygon(pts,fill=(255,255,255,255),outline=(20,20,20,255))
Image.alpha_composite(im,ov).convert('RGB').save(f'{PV}/forts_preview.png')
# zoomed crop with the symbols at full detail
X0,Y0,W0,H0=6800,3300,4400,4200
sF=s[:s.index('<g id="labels"')]+G_FORTS+s[s.index('<g id="labels"'):]   # overlay copy for the preview only
cairosvg.svg2png(bytestring=re.sub(r'viewBox="[^"]*"',f'viewBox="{X0} {Y0} {W0} {H0}"',sF,count=1).replace('width="12288"','width="2400"',1).replace('height="8192"',f'height="{round(2400*H0/W0)}"',1).encode(),write_to=f'{PV}/forts_zille_crop.png',output_width=2400,output_height=round(2400*H0/W0))
print({l:[(f['province_id'].split('_')[1],f['province_name']) for f in FO if f['defense_line']==l] for l in LINES})
