"""v14 base map (vector), built on the final v13 base (work13/base/zille_vector.svg, black frame, no forts):
 1) Kratsna and Grodzizg become seaside cities: urban areas grown onto the coast (waterfront along the inlet / bay),
    so the city itself (and its province) clearly touches the sea.
 2) Yol (Derdia's only port, canonical) enlarged along the Derdian coast.
 3) New Wehlen towns (markers + labels): 10 canonical Wehlen place names (Suzerain wiki, fandom 'Wehlen - Cities and towns'),
    14 heavily distorted Polish town names (seaside resorts Leburk, Shwinouz, Stegnn (owner ideas), Ustkov, Darlovitz,
    Kolobrzezg, Helsk + inland Bydgoszt, Plotzk, Gnyezno, Torunz, Zakopanz, Kalischt, Opolje) -> with Grodzizg 15 of 44
    Wehlen settlements on the map (34%) are Polish-derived.
 4) Derdia: towns/cities (markers + labels) incl. the wiki-derived Dertea (ancient Gerdic kingdom), Golcondra, Wruhena, Atafor,
    direction labels to the capitals (Neael, Cavette, Wraclawitz), Morellan port Muardien + Meftiem (MITZ), country labels
    DERDIA / MORELLA / LESPIA.
 6) request 9: Lespia's territorial waters - dashed limit line GAP-25 px off the Lespian coast + italic labels
    "Lespia's Territorial Waters" repeated along the strip (lespia14.py).
 5) Minor-road spurs from new towns that are off the road network.
-> work14/base/zille_vector.svg, work14/base/zille_preview.png, work14/base/edits14.pkl (SETT14, urban polys)"""
import sys, re, pickle, numpy as np, cairosvg
sys.path.insert(0,'work14'); sys.path.insert(0,'versions/v14/scripts')
from lib import group, layer_lines
from sides14 import WSIDE, DSIDE, MSIDE, B1, B2, WEST
from shapely.geometry import Point, LineString, Polygon
from shapely.ops import unary_union, nearest_points
SRC='work13/base/zille_vector.svg'; s=open(SRC).read()
dd=pickle.load(open('work/land_dec.pkl','rb')); LAND=unary_union([dd['Ld']]+dd['islets'])
SETT=[(n,np.array(p,float),t) for n,p,t in pickle.load(open('work/prov12_stage2.pkl','rb'))['SETT']]
def pd(p): return 'M'+' L'.join(f'{x:.1f},{y:.1f}' for x,y in list(p.exterior.coords)[:-1])+'Z'
def biggest(g): return max(g.geoms,key=lambda q:q.area) if hasattr(g,'geoms') else g
def blob(cx,cy,r,seed,ax=1.0,ang=0.0):
    rr=np.random.default_rng(seed); a,b,c=rr.uniform(0,2*np.pi,3); t=np.linspace(0,2*np.pi,96,endpoint=False)
    rad=r*(1+0.16*np.sin(2*t+a)+0.10*np.sin(3*t+b)+0.06*np.sin(5*t+c))
    x=rad*np.cos(t)*ax; y=rad*np.sin(t); ca,sa=np.cos(ang),np.sin(ang)
    return Polygon(np.stack([cx+x*ca-y*sa,cy+x*sa+y*ca],1))
def urban_poly(gid):
    return Polygon([ln for pid,ln in layer_lines(gid.rsplit('_',1)[0],s) if pid==gid][0].coords).buffer(0)
def set_urban(name,area):
    g=group(f'urban_{name}',s); edge=area.buffer(7,join_style=1)
    new=(f'<g id="urban_{name}"><path id="urban_{name}_edge" fill-opacity="0.10" d="{pd(edge)}"/>'
         f'<path id="urban_{name}_area" fill-opacity="0.42" d="{pd(area)}"/></g>')
    return s.replace(g,new,1)
LIN=LAND.buffer(-6)
# ---------- 1) Kratsna: grow from the old core (5555,482) south-east over the river mouth onto the inlet + bay shore ----------
K0=urban_poly('urban_kratsna_area')
kr=unary_union([K0,blob(5640,600,215,71,1.25,np.radians(25)),LineString([(5555,482),(5700,640),(5790,700)]).buffer(110)])
kr=biggest(kr.intersection(LIN)).buffer(-12,join_style=1).buffer(12,join_style=1)
kr=biggest(kr.intersection(LIN)).simplify(2)
s=set_urban('kratsna',kr)
# ---------- Grodzizg: the whole peninsula tip becomes the city (harbour on the west, south and east shore) ----------
G0=urban_poly('urban_grodzizg_area')
gz=unary_union([G0,blob(4300,3680,190,94,1.15,np.radians(-20))])
gz=biggest(gz.intersection(LIN)).buffer(-12,join_style=1).buffer(12,join_style=1)
gz=biggest(gz.intersection(LIN)).simplify(2)
s=set_urban('grodzizg',gz)
# ---------- 2) Yol enlarged (Derdian side only, along the coast) ----------
Y0=urban_poly('urban_yol_area')
yl=unary_union([Y0,blob(3700,4340,230,7,1.35,np.radians(-55))])
YC=LIN.intersection(DSIDE).difference(B1.buffer(45)).difference(B2.buffer(45))
yl=biggest(yl.intersection(YC)).buffer(-12,join_style=1).buffer(12,join_style=1)
yl=biggest(yl.intersection(YC)).simplify(2)
s=set_urban('yol',yl)
coast=lambda P:P.distance(LAND.boundary)
print('Kratsna urban: area %d -> %d, gap to coast %.0f'%(K0.area,kr.area,kr.distance(LAND.boundary.difference(LAND.boundary.intersection(Point(5555,482).buffer(10))))))
for nm,a0,a1 in (('Kratsna',K0,kr),('Grodzizg',G0,gz),('Yol',Y0,yl)):
    sh=a1.buffer(12).intersection(LAND.boundary).length
    print(f'{nm} urban area {a0.area:.0f} -> {a1.area:.0f}  waterfront (urban within 12 px of the coast) {sh:.0f} map px')
# ---------- 3/4) towns ----------
ROADL=[ln for g in ('main_roads','roads_double_fill','roads_minor') for _,ln in layer_lines(g,s)]
RU=unary_union(ROADL)
def on_coast(p,inset=85):
    q=nearest_points(LAND.boundary,Point(p))[0]; best=None
    for a in np.linspace(0,2*np.pi,72,endpoint=False):
        c=Point(q.x+inset*np.cos(a),q.y+inset*np.sin(a))
        if LAND.contains(c):
            d=c.distance(LAND.boundary)
            if best is None or d>best[0]: best=(d,c)
    return np.array([best[1].x,best[1].y])
def snap_road(p,maxd=200):
    P=Point(p); d=P.distance(RU)
    if d<=maxd: q=nearest_points(RU,P)[0]; return np.array([q.x,q.y]),True
    return np.array(p,float),False
# (name, guess, tier, placement, origin note, label side)
WTOWNS=[
 # Polish-derived (heavily distorted), seaside resorts on the Wehlen coast
 ('Shwinouz',(6190,1080),'resort_town','coast','polish: Swinoujscie (owner idea)','L'),
 ('Leburk',(6120,1560),'resort_town','coast','polish: Leba (owner idea)','L'),
 ('Ustkov',(6085,2060),'resort_town','coast','polish: Ustka','L'),
 ('Darlovitz',(5990,2560),'resort_town','coast','polish: Darlowo','L'),
 ('Kolobrzezg',(5760,3010),'resort_town','coast','polish: Kolobrzeg','L'),
 ('Stegnn',(5150,3290),'resort_town','coast','polish: Stegna (owner idea)','R'),
 ('Bydgoszt',(2330,3330),'village','free','polish: Bydgoszcz','R'),
 # canonical Wehlen place names (Suzerain wiki, Wehlen - Cities and towns)
 ('Zicek',(3870,820),'village','road','wiki (Wehlen)','R'),
 ('Welsk',(4620,1250),'village','road','wiki (Wehlen)','R'),
 ('Witsima',(5260,1520),'village','road','wiki (Wehlen)','R'),
 ('Wizen',(3760,2000),'village','road','wiki (Wehlen)','R'),
 ('Warno',(4930,2640),'village','road','wiki (Wehlen)','R'),
 ('Vernen',(3380,2450),'village','free','wiki (Wehlen)','R'),
 ('Smol',(5420,2620),'village','road','wiki (Wehlen)','R'),
 ('Kastza',(4380,2930),'village','road','wiki (Wehlen)','R'),
 ('Czerna',(3170,3120),'village','free','wiki (Wehlen)','R'),
 ('Artsnan',(3560,3640),'village','road','wiki (Wehlen)','R'),
 # invented Wehzek-style names
 ('Gnyezno',(2650,2920),'village','free','polish: Gniezno','R'),
 ('Plotzk',(1900,2700),'village','road','polish: Plock','R'),
 ('Torunz',(4980,2060),'village','road','polish: Torun','R'),
 ('Zakopanz',(2950,2700),'village','free','polish: Zakopane (mountain resort)','R'),
 ('Kalischt',(2900,3420),'village','free','polish: Kalisz','R'),
 ('Opolje',(3800,1250),'village','free','polish: Opole','R'),
 ('Helsk',(5650,3130),'resort_town','coast','polish: Hel (seaside resort)','L'),
]
DTOWNS=[
 ('Dertea',(2330,4560),'town','road','Derdia; after the ancient Gerdic kingdom of Dertea (wiki, Derdia history)','R'),
 ('Golcondra',(1200,4670),'town','road','Derdia; after Golcondism, the Derdian state creed (wiki)','R'),
 ('Wruhena',(1650,5500),'village','free','Derdia; after the prophet Wruhec (wiki)','R'),
 ('Qerzan',(3150,4080),'village','free','Derdia; invented (Gerdic style)','R'),
 ('Haldesh',(2650,4000),'village','free','Derdia; invented (Gerdic style)','R'),
 ('Merzil',(1800,3950),'village','free','Derdia; invented (Gerdic style)','R'),
 ('Tazrin',(2550,5250),'village','free','Derdia; invented (Gerdic style)','R'),
 ('Atafor',(1100,4100),'village','free','Derdia; after Rasma Atafor, first Supreme Wiseman (wiki, Jorga Azmal)','R'),
]
MTOWNS=[('Muardien',(3330,5900),'town','coast','Morella; Muardien Port of the Meftiem International Trade Zone (wiki)','R'),
        ('Meftiem',(2900,7000),'town','free','Morella; Meftiem, HQ of the MITZ in the Meftiem Basin (wiki)','R')]
allnames={n.casefold() for n,_,_ in SETT}
NEW=[]
for side,LST,ZONE in (('Wehlen',WTOWNS,WSIDE),('Derdia',DTOWNS,DSIDE),('Morella',MTOWNS,MSIDE)):
    for nm,g,tier,how,orig,lab in LST:
        assert nm.casefold() not in allnames, nm; allnames.add(nm.casefold())
        if how=='coast': p=on_coast(g); onr=False
        elif how=='road': p,onr=snap_road(g)
        else: p=np.array(g,float); onr=Point(p).distance(RU)<40
        assert ZONE.buffer(-20).contains(Point(p)), (nm,p)
        NEW.append(dict(name=nm,p=p,tier=tier,origin=orig,country=side,label=lab,on_road=onr or Point(p).distance(RU)<40))
# new minor roads through the new towns (southern-front road Ostrelow - Brannitz, mountain road Gorvitz - Wizen,
# coast road Smol - Kolobrzezg - Stegnn), then spurs for the towns still off the road network
def fmt(v): return ('%.1f'%v).rstrip('0').rstrip('.')
def cr_open(P):
    P=np.asarray(P,float); n=len(P); d=['M%s,%s'%(fmt(P[0,0]),fmt(P[0,1]))]
    for i in range(n-1):
        p0=P[max(i-1,0)];p1=P[i];p2=P[i+1];p3=P[min(i+2,n-1)]
        c1=p1+(p2-p0)/6; c2=p2-(p3-p1)/6
        d.append('C%s,%s %s,%s %s,%s'%(fmt(c1[0]),fmt(c1[1]),fmt(c2[0]),fmt(c2[1]),fmt(p2[0]),fmt(p2[1])))
    return ''.join(d)
TP={n:p for n,p,t in SETT}; TP.update({t['name']:t['p'] for t in NEW})
NEWROADS=[('road_ostrelow_brannitz',['Ostrelow','Bydgoszt','Czerna',(3600,3260),'Brannitz']),
          ('road_plotzk_wizen',['Plotzk','Gnyezno',(3050,2600),'Vernen','Wizen']),
          ('road_smol_stegnn',['Smol',(5560,2850),'Kolobrzezg',(5420,3150),'Stegnn'])]
add=''; NRL=[]
for rid,via in NEWROADS:
    P=[np.asarray(TP[v] if isinstance(v,str) else v,float) for v in via]
    for k in (0,-1):      # a dead end at a town that is off the old network is joined to the nearest old road
        e=Point(P[k]); dd_=e.distance(RU)
        if 40<dd_<700 and isinstance(via[k],str) and via[k] in ('Smol','Wizen','Ostrelow','Plotzk'):
            q=nearest_points(RU,e)[0]; P=[np.array([q.x,q.y])]+P if k==0 else P+[np.array([q.x,q.y])]
    add+=f'<path id="{rid}" d="{cr_open(P)}"/>\n'
    from lib import parse
    ln=parse(cr_open(P))[0]; NRL.append(ln)
    for v in via:
        if isinstance(v,str):
            for t in NEW:
                if t['name']==v: t['on_road']=True
ROADL=ROADL+NRL
SP=[]
for t in NEW:
    if t['on_road']: continue
    P=Point(t['p']); best=None
    side={'Wehlen':WSIDE,'Derdia':DSIDE,'Morella':MSIDE}[t['country']]
    for ln in ROADL:
        q=nearest_points(ln,P)[0]; seg=LineString([(P.x,P.y),(q.x,q.y)])
        if seg.length>1000 or not side.buffer(5).contains(seg) : continue
        if best is None or seg.length<best[0]: best=(seg.length,q)
    if best is None: print('no spur for',t['name']); continue
    q=np.array([best[1].x,best[1].y]); a=t['p']; v=q-a; n=np.array([-v[1],v[0]])/max(np.linalg.norm(v),1)
    m=a+v*0.5+n*np.linalg.norm(v)*0.08
    SP.append((t['name'],a,m,q)); t['spur']=round(best[0])
gm=group('roads_minor',s)
for nm,a,m,q in SP:
    c1=a+(m-a)*0.66; c2=q+(m-q)*0.66
    rid='road_spur_'+re.sub(r'[^a-z0-9]+','_',nm.lower())
    add+=f'<path id="{rid}" d="M{fmt(a[0])},{fmt(a[1])}C{fmt(c1[0])},{fmt(c1[1])} {fmt(c2[0])},{fmt(c2[1])} {fmt(q[0])},{fmt(q[1])}"/>\n'
s=s.replace(gm,gm[:-4]+add+'</g>',1)
# markers + labels
FS={'town':(80,'bold','0.8'),'resort_town':(66,'bold','0.7'),'village':(66,'bold','0.7'),'hamlet':(54,'normal','0.5')}
mk=''; lb=''; ct=''; cl=''
for t in NEW:
    x,y=t['p']; slug=re.sub(r'[^a-z0-9]+','_',t['name'].lower()); f,w,ls=FS[t['tier']]
    if t['tier']=='town':
        ct+=f'<circle id="marker_{slug}" cx="{fmt(x)}" cy="{fmt(y)}" r="15"/>\n'
        cl+=f'<text id="label_{slug}" x="{fmt(x+56)}" y="{fmt(y+25)}" font-size="{f}" font-weight="{w}" letter-spacing="{ls}">{t["name"]}</text>\n'
    else:
        mk+=f'<circle id="town_{slug}_marker" cx="{fmt(x)}" cy="{fmt(y)}" r="15"/>\n'
        if t['label']=='L': lb+=f'<text id="town_{slug}" x="{fmt(x-41)}" y="{fmt(y+22)}" font-size="{f}" font-weight="{w}" letter-spacing="{ls}" text-anchor="end">{t["name"]}</text>\n'
        else: lb+=f'<text id="town_{slug}" x="{fmt(x+41)}" y="{fmt(y+22)}" font-size="{f}" font-weight="{w}" letter-spacing="{ls}">{t["name"]}</text>\n'
for gid,txt in (('city_markers',ct),('labels_towns',cl),('towns_invented_markers',mk),('towns_invented_labels',lb)):
    g=group(gid,s); s=s.replace(g,g[:-4]+txt+'</g>',1)
# country + direction labels (light, not part of the playable art)
CL=('<g id="labels_countries" fill="#141414" fill-opacity="0.38" font-weight="bold">\n'
    '<text id="label_country_derdia" x="1050" y="5330" font-size="170" letter-spacing="60">DERDIA</text>\n'
    '<text id="label_country_morella" x="3080" y="6620" font-size="130" letter-spacing="36" transform="rotate(-78 3080 6620)">MORELLA</text>\n'
    '<text id="label_country_lespia" x="8880" y="640" font-size="150" letter-spacing="50">LESPIA</text>\n'
    '</g>\n<g id="labels_directions" font-style="italic" fill="#141414">\n'
    '<text id="label_to_neael" x="300" y="4615" font-size="60" letter-spacing="0.6">&#8592; Neael (capital of Derdia)</text>\n'
    '<text id="label_to_cavette" x="2380" y="7860" font-size="60" letter-spacing="0.6">Cavette (capital of Morella) &#8595;</text>\n'
    '<text id="label_to_wraclawitz" x="330" y="400" font-size="60" letter-spacing="0.6">&#8593; Wraclawitz (capital of Wehlen)</text>\n'
    '</g>\n')
gl=group('labels',s); s=s.replace(gl,gl[:-4]+CL+'</g>',1)
# ---------- 6) request 9: Lespia's territorial waters (non-playable strip between the northern seas and Lespia) ----------
from lespia14 import LES, GAP, FRAME as LFR, TWZ, R_SMOOTH
from shapely.geometry import MultiLineString
from shapely.ops import linemerge, substring
FIN=LFR.buffer(-45)
def offset_lines(d,r=R_SMOOTH,g=None):
    g=g if g is not None else LES.buffer(d+r,join_style=1).buffer(-r,join_style=1)
    rings=[q.exterior for q in getattr(g,'geoms',[g])]
    out=[]
    for ring in rings:
        x=ring.intersection(FIN)
        for ln in getattr(x,'geoms',[x]):
            if ln.geom_type=='LineString' and ln.length>300: out.append(ln.simplify(6))
    return out
def ld(ln): return 'M'+' L'.join(f'{x:.1f},{y:.1f}' for x,y in ln.coords)
LIM=offset_lines(0,g=TWZ.buffer(-28,join_style=1))
lim_svg='<g id="lespia_territorial_waters" font-family="\'Times New Roman\', Times, serif">\n'
lim_svg+='<g id="lespia_tw_limit" fill="none" stroke="#333333" stroke-width="6" stroke-dasharray="30 20" stroke-opacity="0.65" stroke-linecap="round">\n'
lim_svg+=''.join(f'<path id="lespia_tw_limit_{k+1}" d="{ld(ln)}"/>\n' for k,ln in enumerate(LIM))+'</g>\n'
TXT='Lespia\u2019s Territorial Waters'; FSZ=54; LLEN=780
CEN=offset_lines(GAP*0.5)
defs=''; txt=''; nlab=0; LABPTS=[]
for ln in sorted(CEN,key=lambda l:-l.length):
    L=ln.length; nl=max(1,int((L-200)//1300)+1) if L>LLEN+250 else 0
    def bend(c):
        sb=substring(ln,max(0,c-LLEN/2-60),min(L,c+LLEN/2+60)); ch=LineString([sb.coords[0],sb.coords[-1]])
        return max(Point(q).distance(ch) for q in sb.coords)      # sagitta of the label path (map px)
    cs=sorted(np.arange(LLEN/2+80,L-LLEN/2-80,40),key=bend); picked=[]
    for c in cs:
        if len(picked)>=nl: break
        if all(abs(c-p_)>LLEN+350 for p_ in picked) and bend(c)<100: picked.append(c)
    for c in sorted(picked):
        sub=substring(ln,max(0,c-LLEN/2-60),min(L,c+LLEN/2+60))
        a,b=np.array(sub.coords[0]),np.array(sub.coords[-1])
        if b[0]<a[0]: sub=LineString(list(sub.coords)[::-1]); a,b=b,a
        v=(b-a)/np.linalg.norm(b-a); up=np.array([v[1],-v[0]]); m=np.array(sub.interpolate(0.5,normalized=True).coords[0])
        land_up=Point(*(m+up*GAP*0.5)).distance(LES)<Point(*(m-up*GAP*0.5)).distance(LES)
        sh=0.33*FSZ*(1 if land_up else -1)          # glyphs grow 'up': shift the baseline away from the land side
        sub=sub.parallel_offset(abs(sh),'right' if land_up else 'left',join_style=1)
        if sub.geom_type!='LineString' or sub.length<LLEN: continue
        a2,b2=np.array(sub.coords[0]),np.array(sub.coords[-1])
        if b2[0]<a2[0]: sub=LineString(list(sub.coords)[::-1])
        nlab+=1; pid=f'lespia_tw_path_{nlab}'
        defs+=f'<path id="{pid}" d="{ld(sub)}"/>\n'
        txt+=(f'<text id="label_lespia_tw_{nlab}" font-size="{FSZ}" font-style="italic" letter-spacing="3" fill="#141414" fill-opacity="0.78">'
              f'<textPath xlink:href="#{pid}" href="#{pid}" startOffset="50%" text-anchor="middle">{TXT}</textPath></text>\n')
        LABPTS.append(tuple(np.round(m)))
lim_svg+=f'<defs>{defs}</defs>\n<g id="labels_lespia_tw">\n{txt}</g>\n</g>\n'
if 'xmlns:xlink' not in s[:500]: s=s.replace('<svg ','<svg xmlns:xlink="http://www.w3.org/1999/xlink" ',1)
gl=group('labels',s); s=s.replace(gl,lim_svg+gl,1)
print('Lespia TW: limit pieces',len(LIM),'labels',nlab,LABPTS)
import os; os.makedirs('work14/base',exist_ok=True)
open('work14/base/zille_vector.svg','w').write(s)
cairosvg.svg2png(bytestring=s.encode(),write_to='work14/base/zille_preview.png',output_width=4096,output_height=2731)
SETT14=list(SETT)+[(t['name'],t['p'],t['tier']) for t in NEW]
pickle.dump(dict(SETT14=SETT14,NEW=NEW,urban=dict(kratsna=kr,grodzizg=gz,yol=yl),spurs=[x[0] for x in SP],newroads=[r[0] for r in NEWROADS]),open('work14/base/edits14.pkl','wb'))
for t in NEW: print(t['country'],t['name'],t['tier'],t['p'].round(),'on_road' if t['on_road'] else 'spur %s'%t.get('spur'),'|',t['origin'])
print('ok',len(s))
