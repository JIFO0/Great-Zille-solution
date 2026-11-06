"""v14 (from v13 review 2): Wehlen unit deployment scenarios (max 1 unit per province, none on cities) -> regions/deployments/
deployment_{minimal,suspicious,prepared}.json, deployments_all.csv, README.md, deployment_*_preview.png
Units only on Wehlen-owned land (Zille + Wehlen) and on sea provinces; never on the Rizia ship-placement seas."""
import json, csv, pickle, collections, os
from PIL import Image, ImageDraw, ImageFont
Image.MAX_IMAGE_PIXELS=None
RD='versions/v14/regions'; OD=f'{RD}/deployments'; os.makedirs(OD,exist_ok=True)
M={r['id']:r for r in json.load(open(f'{RD}/provinces_manifest.json'))['provinces']}
AJ=json.load(open(f'{RD}/provinces_adjacency.json'))
F=pickle.load(open('work14/prov14_final.pkl','rb')); by={c['id']:c for c in F['allp']}
LAND=['infantry','mountain_infantry','tanks','mechanized_infantry','militia','paratroopers']; NAVAL=['submarine','destroyer','flagship']
PL={'infantry':'piechota','mountain_infantry':'piechota górska','tanks':'czołgi','mechanized_infantry':'piechota zmechanizowana (also "motorized"/zmotoryzowana)',
    'militia':'milicja (militia)','paratroopers':'spadochroniarze','submarine':'łódź podwodna','destroyer':'niszczyciel','flagship':'flagship / okręt flagowy (max 1)'}
SHIP_RIZIA={i for i,r in M.items() if r['rizia_ship_placement']}
T=lambda n:f'ZilleTile_{n}'
def mk(): return collections.defaultdict(collections.Counter)
def add(D,ids,**u):
    for n in ids if isinstance(ids,(list,tuple)) else [ids]:
        for k,v in u.items(): D[T(n)][k]+=v
LINE={i:M[i].get('defense_line') or '' for i in M}
BW=[i.split('_')[1] for i in M if LINE[i]=='border_west']; BE=[i.split('_')[1] for i in M if LINE[i]=='border_east']; NL=[i.split('_')[1] for i in M if LINE[i]=='north_line']
WEHLEN_CONT=[str(n) for n in range(68,96) if n!=72]
V={}; NOTE={}
# review 2 (owner rule): every province holds AT MOST ONE unit, and city provinces hold none.
# "Groups" = clusters of adjacent provinces with one unit each.
CITIES={T(n) for n in (2,9,11,28,35,71,94)}|{i for i,r in M.items() if r['is_city']}   # + Rizian cities and Yol (never Wehlen anyway)
SOUTH_FRONT=[i for i,r in M.items() if r['region']=='Wehlen' and any(M[n['id']]['region']=='Derdia' for n in AJ['provinces'][i]['neighbours'])]
print('southern front (Wehlen provinces with a land link to Derdia):',SOUTH_FRONT)
def mk(): return {}
def put(D,**kw):
    """put(D, infantry=[..ids..], tanks=[..]) - one unit per province"""
    for u,ids in kw.items():
        for n in ids:
            i=T(n); assert i not in D, ('two units on',i); D[i]=u
V={}; NOTE={}
# ======================= 1. MINIMAL =======================
D=mk()
put(D,infantry=[36,39,118,26,104,114],militia=[37,117,20,33,108])         # border: infantry + militia only
put(D,tanks=[31,113])                                                     # ~2 tanks at the front (Zille North + Portoserra SE)
put(D,mountain_infantry=[100],mechanized_infantry=[99,98])                # rear of Zille (behind the inner line)
put(D,mechanized_infantry=[110,24])                                       # small mech group near Wiktrany
# inner (north) line 21-17-13-8-97: deliberately EMPTY
put(D,infantry=[68,69,73,77,79,81,83,86,89,92,119,121],militia=[72,93,88,122,95],paratroopers=[70],
      mechanized_infantry=[75,78,90,91],tanks=[74,76,82,87],mountain_infantry=[80,85])   # continental Wehlen: most of the army; Derdia front = militia only
put(D,flagship=['S1'],destroyer=['S2','S25','S18','S12','S29','S55'],submarine=['S22','S16','S35','S54'])
V['minimal']=D
NOTE['minimal']=('Minimal preparation. The Rizia border is held only by infantry and militia (one unit per border province); the inner line '
 'Marenta - north of Nanta (21-17-13-8-97) is unmanned. Zille has 2 tanks right behind the front (Zille North 31, Portoserra Southeast 113), '
 'a small mechanized pair near Wiktrany (110, 24) and, in the rear behind the inner line, mountain infantry in the Quella Highlands (100) with a '
 'mechanized pair (99, 98). Most units are in continental Wehlen; tanks and mechanized stand in small groups of 2 adjacent provinces '
 '(tanks 74-76 and 82-87, mechanized 75-78 and 90-91). The fleet is a set of thin one-ship lines (S25/S22/S18 in front of the Rizian east seas, '
 'S12/S16 at Munat, S29/S35 in the Isor-Rotsla channel, S55/S54 in front of the Rizian west seas); the flagship lies in Kreleck Sound (S1) next to the capital Kratsna.')
# ======================= 2. SUSPICIOUS =======================
D=mk()
put(D,tanks=[36,117],mountain_infantry=[37],infantry=[39,118])             # first line west, 2 tanks next to Zille City
put(D,infantry=[20,26,104,114],militia=[33,108])                           # first line east
put(D,infantry=[21,13,97],militia=[17,8])                                  # second (inner) line Marenta - north of Nanta
put(D,mechanized_infantry=[30,38],infantry=[31,116])                       # ring around Zille City (with 36, 117, 39)
put(D,tanks=[112,25],mechanized_infantry=[24,106],paratroopers=[113])      # Wiktrany reserve
put(D,mountain_infantry=[32,19,100],mechanized_infantry=[99])
put(D,infantry=[96],militia=[3])                                           # Port Rotsla island garrison
put(D,infantry=[122,88,70,77,82,87],militia=[93,95,72,69,92],mountain_infantry=[119],mechanized_infantry=[75,78,91],tanks=[74,76,86])   # v14: screen on the Derdia front
put(D,flagship=['S52'],destroyer=['S25','S22','S20','S12','S16','S55','S51','S29','S1'],submarine=['S18','S21','S11','S7','S17','S54','S35'])
V['suspicious']=D
NOTE['suspicious']=('Suspicious. Both defence lines are manned: the border (heavy forts west, light forts east) and the inner line Marenta - north of Nanta '
 '(21, 17, 13, 8, 97). On the first line next to Zille City stand 2 tanks (Pomara Northwest 36, Pomara West 117). Zille City (a city, so no unit '
 'on it) is ringed by infantry and mechanized ("motorized" = mechanized_infantry) units in its neighbour provinces 30, 31, 38, 116 plus the border '
 'units on 36, 117, 39. Around Wiktrany stands a reserve (tanks 112-25, mechanized 24-106, paratroopers 113). Port Rotsla island (96) has infantry. On the Derdian border a screen stands on the southern front (infantry 122, 88, militia 93, 95, mountain infantry 119 behind). '
 'The navy is bigger, the flagship is in Zille Bay (S52), and two blocking lines stop a Rizian advance past Nanta and Munat: S25-S22-S18-S21 '
 'right in front of the Rizian east seas, then S17-S20-S12-S11-S16-S7 around Munat; the west coast is screened by S55-S54-S51.')
# ======================= 3. PREPARED =======================
D=mk()
put(D,tanks=[104,20],mechanized_infantry=[15,102])                         # strike group -> Mave Nortus (23)
put(D,tanks=[114,33],mechanized_infantry=[29,26])                          # strike group -> Dapalle (51)
put(D,tanks=[117],mechanized_infantry=[36])                                # strike group -> Pomara / Brivane road
put(D,tanks=[39,38],mechanized_infantry=[118])                             # strike group -> Celle Vaz / Marbelas (64)
put(D,tanks=[31,110],mechanized_infantry=[111,25],mountain_infantry=[32])   # second echelon
put(D,mountain_infantry=[37],infantry=[108])                               # rest of the border
put(D,paratroopers=[30,116])                                               # airborne staged next to Zille City
put(D,infantry=[21,13,97],militia=[17,8])                                  # inner line
put(D,mountain_infantry=[19,22,103,100])
put(D,infantry=[107,113,112,106,109,18,14,96,5],militia=[24,27,34,115,101,99])
put(D,militia=[70,75,72],infantry=[82,91])                                 # capital area exposed (no armour)
put(D,infantry=[122,95,84],mountain_infantry=[93,88,119],militia=[120],mechanized_infantry=[121,89])   # v14: widened southern front vs Derdia, fully manned
put(D,flagship=['S52'],destroyer=['S25','S22','S20','S12','S16','S17','S55','S54','S29','S48','S36'],
      submarine=['S18','S21','S11','S7','S51','S50','S35','S1','S44'])
V['prepared']=D
NOTE['prepared']=('Prepared (maximum defence, still beatable). Both lines are manned, every Zille mountain province holds mountain infantry, and '
 'this variant has the most armour and the biggest fleet. BUT Wiktor Smolak sent the best forces forward to seize Rizian territory: strike groups '
 'of adjacent tank/mechanized provinces stand next to the Rizian cities - Venna East 104 + Venna 20 (tanks) with 15 + 102 (mechanized) facing Mave Nortus; '
 'Dapalle Northwest 114 + Dapalle West 33 (tanks) with 29 + 26 (mechanized) facing Dapalle; Pomara West 117 + Pomara Northwest 36 on the Brivane road; '
 'Celle Vaz North 39 + Rivamare 38 (tanks) with Praia Velha 118 (mechanized) facing Celle Vaz / Marbelas; a second echelon (31, 110, 111, 25, 32) and '
 'paratroopers next to Zille City (30, 116). The capital Kratsna area keeps only 5 units (militia 70, 75, 72 and infantry 82, 91, no armour), '
 'so a Rizian landing in the north or a breakthrough behind the strike groups can win. v14: Smolak expects Derdia to join, so the widened southern '
 'front is fully manned - front row 122 (infantry), 93 and 88 (mountain infantry), 95 (infantry) facing the Derdia strip 124/126/128, second row '
 '120 (militia), 121 and 89 (mechanized), 119 (mountain infantry), 84 (infantry).')
# ======================= checks + output =======================
rows=[]; summ={}
for v,D in V.items():
    for i,u in D.items():
        r=M[i]; assert r['owner']=='Wehlen' or r['type']=='sea', (v,i,r['owner'])
        assert i not in SHIP_RIZIA, (v,i); assert i not in CITIES and not r['is_city'], (v,i,'city')
        assert (u in LAND)==(r['type']=='land') and (u in LAND or u in NAVAL), (v,i,u)
    tot=collections.Counter(D.values()); assert tot['flagship']==1,(v,tot['flagship'])
    reg=collections.Counter(M[i]['region'] for i in D)
    land_tot=sum(tot[k] for k in LAND); nav_tot=sum(tot[k] for k in NAVAL)
    summ[v]=dict(totals_by_type={k:tot[k] for k in LAND+NAVAL},land_units=land_tot,naval_units=nav_tot,units_by_region=dict(reg),
                 max_units_per_province=1,units_on_cities=0,
                 free_land_provinces=sum(1 for i,r in M.items() if r['owner']=='Wehlen' and not r['is_city'] and i not in D),
                 free_sea_provinces=sum(1 for i,r in M.items() if r['type']=='sea' and i not in SHIP_RIZIA and i not in D))
    key=lambda i:(i[10]=='S',int(i.split('_')[1].lstrip('S')))
    ent=[dict(province_id=i,province_name=M[i]['name'],unit_type=D[i]) for i in sorted(D,key=key)]
    json.dump(dict(variant=v,side='Wehlen',description=NOTE[v],unit_types={k:PL[k] for k in LAND+NAVAL},
                   rules='max 1 unit per province; no unit on city provinces ('+', '.join(sorted(CITIES,key=key))+'); units only on Wehlen-owned land (Zille + Wehlen) '
                         'and on sea provinces; none on the Rizia ship-placement seas '+', '.join(sorted(SHIP_RIZIA,key=key))+'; exactly 1 flagship',
                   summary=summ[v],deployment=ent),open(f'{OD}/deployment_{v}.json','w'),indent=1,ensure_ascii=False)
    for e in ent: rows.append([v,e['province_id'],e['province_name'],M[e['province_id']]['type'],M[e['province_id']]['region'],M[e['province_id']].get('defense_line') or '',e['unit_type']])
with open(f'{OD}/deployments_all.csv','w',newline='') as f:
    w=csv.writer(f); w.writerow(['variant','province_id','province_name','type','region','defense_line','unit_type']); w.writerows(rows)
order=['minimal','suspicious','prepared']
L_=lambda v,k:summ[v][k]
assert L_('minimal','land_units')<L_('suspicious','land_units')<L_('prepared','land_units')
assert L_('minimal','naval_units')<L_('suspicious','naval_units')<L_('prepared','naval_units')
tk=lambda v:summ[v]['totals_by_type']['tanks']; arm=lambda v:tk(v)+summ[v]['totals_by_type']['mechanized_infantry']
assert tk('minimal')<tk('suspicious')<tk('prepared') and arm('minimal')<arm('suspicious')<arm('prepared')
json.dump(summ,open(f'{OD}/deployments_summary.json','w'),indent=1)
L=['# Wehlen deployment scenarios (v14)','',
 'Rule (owner, review 2): **every province holds at most ONE unit, and city provinces hold none** (Munat 2, Nanta 9, Isor 11, Wiktrany 28, Zille City 35, '
 'Kratsna 71, Grodzizg 94). v14: no unit on Derdia (incl. the impassable Yol 129); the Wehlen southern front facing Derdia is 122, 93, 88, 95. "Groups" are clusters of adjacent provinces with one unit each.','',
 'Files: `deployment_minimal.json`, `deployment_suspicious.json`, `deployment_prepared.json` - each has `deployment` = list of '
 '`{province_id, province_name, unit_type}` (one unit per entry) and `summary` (totals per type, land/naval totals, units per region). '
 '`deployments_all.csv` = all three variants (one row per unit). `deployments_summary.json` = the three summaries. Previews: `deployment_<variant>_preview.png` (one symbol per province).','',
 '## Unit types','','| id | label (PL) | kind |','|---|---|---|']
L+=[f'| `{k}` | {PL[k]} | {"land" if k in LAND else "naval"} |' for k in LAND+NAVAL]
L+=['','"Motorized" (zmotoryzowane) units from the owner\'s brief have no own type: they are `mechanized_infantry`.','',
 'Rules: units only on Wehlen-owned land (Zille + Wehlen) and on sea provinces; exactly one flagship; no Wehlen ship on the Rizia ship-placement seas '
 '(west S56, S57; east S37, S30, S32, S31, S26) - the blocking lines stand in front of them. Defence lines and forts: `../forts.json` '
 '(border_west heavy, border_east light, north_line light = inner line Marenta - north of Nanta: 21, 17, 13, 8, 97).','','## Variants','']
for v in order:
    s_=summ[v]; t=s_['totals_by_type']
    L+=[f'### {v}','',NOTE[v],'',f"Totals: land {s_['land_units']}, naval {s_['naval_units']} - "+', '.join(f'{k} {t[k]}' for k in LAND+NAVAL)+
        '. By region: '+', '.join(f'{k} {n}' for k,n in sorted(s_['units_by_region'].items()))+'.','']
L+=['Escalation: land, naval, tank and armour (tanks + mechanized) totals grow from minimal to suspicious to prepared. The prepared variant stays beatable: '
    'the east border has only light forts, the strike groups stand forward (open to encirclement) and the capital area holds only 5 units.']
open(f'{OD}/README.md','w').write('\n'.join(L)+'\n')
# ---------------- previews ----------------
COL={'infantry':(40,140,40),'mountain_infantry':(140,90,40),'tanks':(20,20,20),'mechanized_infantry':(30,60,170),'militia':(130,130,130),
     'paratroopers':(150,40,170),'submarine':(0,150,150),'destroyer':(0,40,110),'flagship':(220,170,0)}
AB={'infantry':'I','mountain_infantry':'Mt','tanks':'T','mechanized_infantry':'Mc','militia':'Mi','paratroopers':'P','submarine':'S','destroyer':'D','flagship':'F'}
FB='/usr/share/fonts/truetype/sand-box/google/Tinos/Tinos-Bold.ttf'
bm=Image.open('work14/base/zille_preview.png').convert('RGB'); sc=bm.size[0]/12288
for v in order:
    D=V[v]; im=Image.blend(bm,Image.new('RGB',bm.size,(255,255,255)),0.35).convert('RGBA'); ov=Image.new('RGBA',im.size,(0,0,0,0)); d=ImageDraw.Draw(ov)
    f=ImageFont.truetype(FB,15); fl=ImageFont.truetype(FB,24); ft=ImageFont.truetype(FB,36)
    for c in F['allp']:
        r=M[c['id']]; col=(0,0,0,0)
        if r['owner']=='Rizia': col=(40,170,60,70)
        elif r['type']=='sea': col=(0,60,200,90) if c['id'] in SHIP_RIZIA else (0,0,0,0)
        else: col=(230,190,140,60)
        if r.get('defense_line'): col={'border_west':(200,0,0,90),'border_east':(255,150,0,90),'north_line':(0,110,230,80)}[r['defense_line']]
        for q in getattr(c['poly'],'geoms',[c['poly']]): d.polygon([(x*sc,y*sc) for x,y in q.exterior.coords],fill=col,outline=(90,90,90,160))
    for i,u in D.items():
        p=by[i]['poly'].representative_point(); x0,y0=p.x*sc,p.y*sc
        d.rectangle([x0-17,y0-12,x0+17,y0+12],fill=COL[u]+(255,),outline=(255,255,255,255),width=2)
        d.text((x0,y0),AB[u],font=f,fill=(255,255,255) if u!='flagship' else (0,0,0),anchor='mm')
    s=summ[v]; t=s['totals_by_type']
    leg=[(f'{AB[k]} = {k} ({t[k]})',COL[k]) for k in LAND+NAVAL]
    d.rectangle([10,10,470,70+30*len(leg)+120],fill=(255,255,255,240),outline=(0,0,0))
    d.text((20,35),f'Wehlen deployment: {v.upper()}',font=ft,fill=(0,0,0),anchor='lm')
    for k,(tx,cc) in enumerate(leg):
        y=80+30*k; d.rectangle([20,y-11,52,y+11],fill=cc+(255,)); d.text((62,y),tx,font=fl,fill=(0,0,0),anchor='lm')
    y=80+30*len(leg)
    for k,(tx,cc) in enumerate([('border_west (heavy forts)',(200,0,0,160)),('border_east (light forts)',(255,150,0,160)),('north_line (light forts)',(0,110,230,160)),('Rizia ship-placement seas',(0,60,200,160))]):
        d.rectangle([20,y+k*28-10,52,y+k*28+10],fill=cc); d.text((62,y+k*28),tx,font=fl,fill=(0,0,0),anchor='lm')
    d.text((20,y+4*28+4),f"land {s['land_units']} / naval {s['naval_units']}",font=fl,fill=(0,0,0),anchor='lm')
    Image.alpha_composite(im,ov).convert('RGB').save(f'{OD}/deployment_{v}_preview.png')
for v in order: print(v,summ[v])
