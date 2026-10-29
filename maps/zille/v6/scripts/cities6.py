"""v5 cities: urban areas, markers, labels (Pales style). Writes work/cities5.pkl."""
import numpy as np, pickle
from shapely.geometry import LineString, Point, Polygon, MultiPoint, box
from shapely.ops import unary_union
from shapely.strtree import STRtree
from PIL import ImageFont
S=8
L=pickle.load(open('work/layers_final.pkl','rb'))
reg=np.load('work/topo_reg.npy'); names=pickle.load(open('work/topo_names.pkl','rb'))
dd=pickle.load(open('work/land_dec.pkl','rb')); LAND=unary_union([dd['Ld']]+dd['islets'])
cape=pickle.load(open('work/topo_cape_v3.pkl','rb'))['road']; nr=pickle.load(open('work/road_mn_w.pkl','rb'))['road']
NEW=pickle.load(open('work/roads5.pkl','rb')); NEWD={n:r for n,k,r in NEW}
sites=pickle.load(open('work/sites5.pkl','rb'))
FR=(265,276,12023,7907)
TT={False:'/usr/share/fonts/truetype/sand-box/google/Tinos/Tinos-Regular.ttf',True:'/usr/share/fonts/truetype/sand-box/google/Tinos/Tinos-Bold.ttf'}
def regname(x,y): return names[reg[min(int(y/S),reg.shape[0]-1),min(int(x/S),reg.shape[1]-1)]]
# ---------------- settlements --------------------------------------------------------
# tiers: major (uppercase), key (Wiktrany/Munat, same label as major), town (mixed case, small urban area),
#        resort_town (invented, tiny urban area), village (dot + label), hamlet (small dot, small label)
MAJ=[('Zille',(7835,5995),None,'major'),('Kratsna',(5555,482),150,'major'),
     ('Nanta',(9088,2898),68,'major'),('Mave Nortus',(10515,4039),70,'major'),
     ('Yol',(3665,4295),52,'major'),('Isor',(6877,3393),46,'major'),('Lerlow',(2201,1677),46,'major'),
     ('Wiktrany',(8029,5045),40,'key'),('Munat',(8446,1700),46,'key'),
     ('Dapalle',(9567,5524),28,'town'),('Balle',(11336,6556),28,'town')]
# invented settlements ------------------------------------------------------------------
VN={'wehlen':['Velkow','Dornatz','Strebna','Harlitz','Mirlow','Oderna','Kessin','Wolsna','Hradna'],
    'peninsula':['Ossa','Lenta','Corvis','Tirsa','Venna','Sostra','Ardo','Quella'],
    'olive':['Ostrabe','Vallas','Morsa','Celle Vaz','Tarnes','Isalba','Pomara','Dravis','Zelles','Brivane']}
INV=[]   # (name, (x,y), region, tier, source-note)
cnt={k:0 for k in VN}
for x,y,r,sc in pickle.load(open('work/vill_cand.pkl','rb')):
    INV.append((VN[r][cnt[r]],(x,y),r,'village','v4')); cnt[r]+=1
# Wehlen: more small towns along the new southern / western roads
WEH_NEW=['Trebnow','Sulkov','Brannitz','Ostrelow','Zabrna','Kleswitz']
taken=[np.array(c,float) for _,c,_,_ in MAJ]+[np.array(c,float) for _,c,_,_,_ in INV]
k=0
for rn,fr in [('road_kratsna_yol',0.30),('road_kratsna_yol',0.55),('road_kratsna_yol',0.80),('road_lerlow_south',0.45),
              ('road_strebna_south',0.40),('road_kratsna_northwest',0.75),('road_kratsna_west',0.42)]:
    gl=LineString(NEWD[rn]); 
    for df in (0,0.04,-0.04,0.08,-0.08):
        p=np.array(gl.interpolate(min(max(fr+df,0.02),0.98),normalized=True).coords[0])
        if regname(*p)=='wehlen' and min(np.hypot(*(p-q)) for q in taken)>520: break
    else: continue
    if k>=len(WEH_NEW): break
    INV.append((WEH_NEW[k],tuple(p),'wehlen',['village','village','hamlet','village','hamlet','village'][k],'v5 Wehlen')); taken.append(p); k+=1
# resorts on the west coast (varied tiers)
RES_P=['Lido Isora','Marenta','Cala Vessa','Portoserra','Sabbiano','Bellacosta','Ondaro','Vela Nova','Capo Lisso','Azzurra','Rivamare','Santa Calla']
RES_B=['Praia Velha','Areias','Costa Dalle','Marbelas']
PAT=['resort_town','village','hamlet','village','resort_town','hamlet','village','resort_town','hamlet','village','resort_town','hamlet']
ip=ib=0
for z,q in sites['resorts']:
    if z=='peninsula': INV.append((RES_P[ip],tuple(q),'peninsula',PAT[ip%len(PAT)],'v5 resort')); ip+=1
    else: INV.append((RES_B[ib],tuple(q),'olive',['resort_town','hamlet','village','resort_town'][ib],'v5 resort')); ib+=1
# island towns (Rotsla)
a,b=sites['island']
INV.append(('Port Rotsla',tuple(a),'island','resort_town','v5 island')); INV.append(('Walsholm',tuple(b),'island','village','v5 island'))
# ---------------- helpers -----------------------------------------------------------------
def f(v): return ('%.1f'%v).rstrip('0').rstrip('.')
def cr_closed(P):
    n=len(P); d=['M%s,%s'%(f(P[0,0]),f(P[0,1]))]
    for i in range(n):
        p0=P[(i-1)%n];p1=P[i];p2=P[(i+1)%n];p3=P[(i+2)%n]
        c1=p1+(p2-p0)/6; c2=p2-(p3-p1)/6
        d.append('C%s,%s %s,%s %s,%s'%(f(c1[0]),f(c1[1]),f(c2[0]),f(c2[1]),f(p2[0]),f(p2[1])))
    return ''.join(d)+'Z'
def poly_d(g,tol=3):
    out=[];nn=0
    for p in getattr(g,'geoms',[g]):
        if p.geom_type!='Polygon' or p.area<300: continue
        for ring in [p.exterior]+list(p.interiors):
            q=np.asarray(ring.simplify(tol).coords)[:-1]
            if len(q)<4: continue
            nn+=len(q); out.append(cr_closed(q))
    return ''.join(out),nn
ROADS=[np.asarray(l) for k in ['roads1','roads2','mains'] for l in L[k]]+[cape,nr]+[r for n,k,r in NEW]
RAILS=[np.asarray(l) for l in L['rails']]
RIV=[np.asarray(l) for l in L['rivers']]
rs=np.random.default_rng(11)
def wobble(c,r,ry=0.82,amp=1.0):
    a=np.linspace(0,2*np.pi,96,endpoint=False); ph=rs.uniform(0,6.3,5)
    rad=r*(1+amp*(0.18*np.sin(3*a+ph[0])+0.12*np.sin(5*a+ph[1])+0.08*np.sin(9*a+ph[2])+0.05*np.sin(14*a+ph[3])+0.03*np.sin(23*a+ph[4])))
    return Polygon(np.stack([c[0]+rad*np.cos(a),c[1]+rad*ry*np.sin(a)],1))
def arms(c,reach,wr,wv):
    R=Point(*c).buffer(reach); out=[]
    for l in ROADS+RAILS:
        g=LineString(l).intersection(R)
        if not g.is_empty: out.append(g.buffer(wr,cap_style=1))
    for l in RIV:
        g=LineString(l).intersection(R)
        if not g.is_empty: out.append(g.buffer(wv,cap_style=1))
    return out
def finish(U,r):
    U=U.buffer(0.18*r).buffer(-0.30*r).buffer(0.12*r)
    U=U.intersection(LAND.buffer(-6)).intersection(box(FR[0]+40,FR[1]+40,FR[2]-40,FR[3]-40))
    if U.geom_type=='MultiPolygon':
        parts=sorted(U.geoms,key=lambda g:-g.area); keep=[parts[0]]+[p for p in parts[1:] if p.area>0.08*parts[0].area]
        U=unary_union(keep)
    return U
def urban(c,r):
    c=np.array(c,float)
    U=unary_union([wobble(c,r)]+arms(c,1.5*r,0.42*r,0.36*r)).intersection(Point(*c).buffer(1.38*r))
    return finish(U,r)
def urban_zille():
    # v6: ~0.76x of the v5 extent (dotted source outline scaled towards the hub), core still clearly the biggest city
    ZS=0.76; c=np.array([7835.,5995.])
    dots=c+(np.load('work/zille_dots.npy')[:,:2]-c)*ZS
    hull=MultiPoint([tuple(p) for p in dots]).convex_hull.buffer(24)
    core=unary_union([wobble(c+[-60,30],300*ZS,0.78,0.7),wobble(c+[90,-45],170*ZS,0.9,0.9)])
    A=unary_union(arms(c,560*ZS,44,38))
    U=unary_union([core.intersection(hull),A.intersection(hull.buffer(100)),hull.buffer(-50)])
    bites=[wobble(np.array(q,float),rs.uniform(36,66),1.0,1.4) for q in dots][::3]
    U=U.difference(unary_union(bites).difference(A.buffer(10)))
    return finish(U,90)
URB={}; ud=[]; un=0
def add_urban(gid,U,op=0.42):
    global un
    d,nn=poly_d(U); un+=nn; halo,_=poly_d(U.buffer(7).intersection(LAND.buffer(-2)))
    ud.append(f'<g id="{gid}"><path id="{gid}_edge" fill-opacity="0.10" d="{halo}"/><path id="{gid}_area" fill-opacity="{op}" d="{d}"/></g>')
for n,c,r,t in MAJ:
    U=urban_zille() if n=='Zille' else urban((5440,640) if n=='Kratsna' else c, r)
    URB[n]=U; add_urban('urban_'+n.lower().replace(' ','_'),U)
for n,c,rg,t,src in INV:
    if t=='resort_town':
        U=urban(c,22); URB[n]=U; add_urban('urban_'+n.lower().replace(' ','_'),U)
urban_svg='<g id="urban_areas" fill="#000000" stroke="none">\n'+'\n'.join(ud)+'\n</g>'
# ---------------- label placement -----------------------------------------------------------
STY={'major':dict(size=108,bold=True,upper=True,ls=0.05),'key':dict(size=108,bold=True,upper=True,ls=0.05),
     'capital':dict(size=124,bold=True,upper=True,ls=0.05),
     'town':dict(size=80,bold=True,upper=False,ls=0.01),'resort_town':dict(size=72,bold=True,upper=False,ls=0.01),
     'village':dict(size=66,bold=True,upper=False,ls=0.01),'hamlet':dict(size=54,bold=False,upper=False,ls=0.01)}
DOT={'village':15,'hamlet':10,'town':15}
FONTS={b:ImageFont.truetype(TT[b],200) for b in (True,False)}
def measure(txt,st):
    w=FONTS[st['bold']].getlength(txt)*st['size']/200+st['ls']*st['size']*(len(txt)-1)
    asc=0.66 if st['upper'] else 0.69
    desc=0.0 if st['upper'] else (0.22 if any(ch in txt for ch in 'gjpqy') else 0.02)
    return w,asc*st['size'],desc*st['size']
LG=[LineString(l) for l in ROADS+RAILS]; LW=[1.0]*len(LG)
LG+=[LineString(l) for l in RIV]; LW+=[0.7]*len(RIV)
for b in L['borders']: LG.append(LineString(np.asarray(b))); LW.append(1.2)
for p in getattr(LAND,'geoms',[LAND]): LG.append(p.exterior); LW.append(0.9)
TREE=STRtree(LG)
anchors={}   # name -> geometry of the settlement symbol
for n,c,r,t in MAJ: anchors[n]=URB[n]
for n,c,rg,t,src in INV: anchors[n]=URB[n] if t=='resort_town' else Point(*c).buffer(DOT[t])
for n,c,r,t in MAJ:
    if t=='town': anchors[n]=unary_union([URB[n],Point(*c).buffer(DOT['town'])])
OBST={n:g.buffer(40) for n,g in anchors.items()}
OT=list(OBST.items())
placed=[]
def line_cost(B):
    s=0
    for j in TREE.query(B):
        g=LG[j].intersection(B)
        if not g.is_empty: s+=g.length*LW[j]
    return s
def place(name,txt,st):
    geom=anchors[name]; w,asc,desc=measure(txt,st); hgt=asc+desc
    x0,y0,x1,y1=geom.bounds; cx,cy=(x0+x1)/2,(y0+y1)/2
    best=None
    for pad_k in (0.22,0.45,0.8,1.3):
        p=st['size']*pad_k+12
        cands={'E':(x1+p,cy-hgt/2),'W':(x0-p-w,cy-hgt/2),'N':(cx-w/2,y0-p-hgt),'S':(cx-w/2,y1+p),
               'NE':(x1+p*0.6,y0-p*0.6-hgt*0.6),'SE':(x1+p*0.6,y1+p*0.6-hgt*0.4),'NW':(x0-p*0.6-w,y0-p*0.6-hgt*0.6),'SW':(x0-p*0.6-w,y1+p*0.6-hgt*0.4)}
        pen={'E':0,'NE':4,'SE':6,'W':8,'NW':10,'SW':12,'N':9,'S':11}
        for dn,(bx,by) in cands.items():
            B=box(bx,by,bx+w,by+hgt)
            if not (bx>FR[0]+45 and by>FR[1]+45 and bx+w<FR[2]-45 and by+hgt<FR[3]-45): continue
            Bx=B.buffer(16)
            cost=pen[dn]*st['size']*0.4+(pad_k-0.22)*st['size']*5
            for P in placed:
                if Bx.intersects(P): cost+=1e6
            for on,O in OT:
                if on!=name and Bx.intersects(O): cost+=3e5
            if Bx.intersects(geom): cost+=(600 if st['upper'] else 4e3)
            cost+=line_cost(B.buffer(12))*4.0
            if best is None or cost<best[0]: best=(cost,bx,by,B,dn)
    cost,bx,by,B,dn=best; placed.append(B.buffer(12))
    return bx,by+asc,cost,dn
def text_el(id_,txt,x,y,st):
    ls=f' letter-spacing="{f(st["ls"]*st["size"])}"' if st['ls'] else ''
    fw=' font-weight="bold"' if st['bold'] else ' font-weight="normal"'
    return f'<text id="{id_}" x="{f(x)}" y="{f(y)}" font-size="{st["size"]}"{fw}{ls}>{txt}</text>'
def sid(n): return n.lower().replace(' ','_')
LBL={'labels_major':[],'labels_key':[],'labels_towns':[]}; report=[]
order=sorted(MAJ,key=lambda m:({'major':1,'key':0,'town':2}[m[3]],-(m[2] or 999)))
for n,c,r,t in order:
    st=STY['capital'] if n=='Kratsna' else STY['major'] if n=='Zille' else STY[t]
    if n=='Zille': st=dict(STY['capital'])
    txt=n.upper() if st['upper'] else n
    x,y,cost,dn=place(n,txt,st)
    grp={'major':'labels_major','key':'labels_key','town':'labels_towns'}[t]
    LBL[grp].append(text_el('label_'+sid(n),txt,x,y,st)); report.append((n,t,tuple(np.round(c)),dn,round(cost)))
mk=[f'<circle id="marker_{sid(n)}" cx="{f(c[0])}" cy="{f(c[1])}" r="{DOT["town"]}"/>' for n,c,r,t in MAJ if t=='town']
vm=[];vl=[]
pri={'resort_town':0,'village':1,'hamlet':2}
for n,c,rg,t,src in sorted(INV,key=lambda v:pri[v[3]]):
    if t!='resort_town': vm.append(f'<circle id="town_{sid(n)}_marker" cx="{f(c[0])}" cy="{f(c[1])}" r="{DOT[t]}"/>')
    x,y,cost,dn=place(n,n,STY[t])
    vl.append(text_el('town_'+sid(n),n,x,y,STY[t])); report.append((n,t+'/'+rg+'/'+src,tuple(np.round(c)),dn,round(cost)))
TXT='font-family="\'Times New Roman\', Times, serif"'
markers='<g id="city_markers" fill="#343434" stroke="none">\n'+'\n'.join(mk)+'\n</g>'
labels=(f'<g id="labels" {TXT} fill="#141414" stroke="none">\n'
 + '<g id="labels_major">\n'+'\n'.join(LBL['labels_major'])+'\n</g>\n'
 + '<g id="labels_key">\n'+'\n'.join(LBL['labels_key'])+'\n</g>\n'
 + '<g id="labels_towns">\n'+'\n'.join(LBL['labels_towns'])+'\n</g>\n'
 + '<g id="towns_invented">\n<g id="towns_invented_markers" fill="#343434">\n'+'\n'.join(vm)+'\n</g>\n<g id="towns_invented_labels">\n'+'\n'.join(vl)+'\n</g>\n</g>\n'
 + '</g>')
# collision audit
bad=[]
for i in range(len(placed)):
    for j in range(i+1,len(placed)):
        if placed[i].intersects(placed[j]): bad.append((i,j))
pickle.dump(dict(urban=urban_svg,markers=markers,labels=labels,report=report,urban_nodes=un,MAJ=MAJ,INV=INV,
                 urb={n:(round(URB[n].area),[round(v) for v in URB[n].bounds]) for n in URB},URBG=URB),open('work/cities6.pkl','wb'))
for r in report: print(r)
print('urban nodes',un,'label overlaps',bad,'n labels',len(placed))
for n in ['Zille','Kratsna','Mave Nortus','Nanta','Munat','Wiktrany']:
    b=URB[n].bounds; print(n,'urban bbox',round(b[2]-b[0]),'x',round(b[3]-b[1]),'area',round(URB[n].area))
