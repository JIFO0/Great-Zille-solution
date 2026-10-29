"""v6 stage 2: depth selection, islands, cities, gaps, sea provinces, names, ids. -> work/prov6.pkl"""
import numpy as np, pickle, sys
src=open('provinces6.py').read().split("Zz=(pen|")[0]
exec(src)
from shapely.geometry import LineString
from shapely import affinity
D=pickle.load(open('work/prov6_raw.pkl','rb'))
CI=pickle.load(open('work/cities6.pkl','rb'))
SETT=[(n,np.array(c,float),t) for n,c,_,t in CI['MAJ']]+[(n,np.array(c,float),t) for n,c,_,t,_ in CI['INV']]
SETT+= [(n,np.array(URB[n].centroid.coords[0]),'resort_town') for n in ['Lido Isora','Sabbiano','Vela Nova','Rivamare','Praia Velha','Marbelas'] if n not in [s[0] for s in SETT]]
TIER={'major':0,'key':0,'town':1,'resort_town':2,'village':3,'hamlet':4}
MINFRAG=0.12*410*410
def gval(a,x,y): return a[min(int(y/G),H-1),min(int(x/G),W-1)]
cells=[]   # dict(region, poly(raw), kind)
BCITY=rast(unary_union([v['poly'] for v in cityshape.values() if v['region']=='Brenas']).buffer(70))
Lc=np.zeros((H,W),np.int32); lreg={}; nxt=1
for rg,(Lg,_,P) in D['res'].items():
    Lg=Lg.copy()
    cnt=np.bincount(Lg.ravel())*G*G
    for k in np.argsort(cnt):
        if k==0 or cnt[k]==0 or cnt[k]>=MINFRAG: continue
        m=Lg==k; ring=ndi.binary_dilation(m,iterations=1)&~m; nb=Lg[ring]; nb=nb[(nb>0)&(nb!=k)]
        if len(nb): Lg[m]=np.bincount(nb).argmax()
    objs=ndi.find_objects(Lg)
    for k,sl in enumerate(objs,1):
        if sl is None: continue
        m=Lg[sl]==k
        if not m.any(): continue
        yy,xx=np.nonzero(m); i=len(yy)//2
        cy,cx=ndi.center_of_mass(m); gy,gx=int(cy)+sl[0].start,int(cx)+sl[1].start
        if not Lg[gy,gx]==k: gy,gx=yy[i]+sl[0].start,xx[i]+sl[1].start
        x,y=(gx+0.5)*G,(gy+0.5)*G
        if rg=='Brenas' and not gval(d_pen,x,y)<gval(Db,x,y) and not (BCITY[sl][m]).any(): continue
        if rg=='Wehlen' and not gval(d_ch,x,y)<gval(Dw,x,y): continue
        sub=Lc[sl]; sub[m]=nxt; lreg[nxt]=rg; nxt+=1
Pall=label_polys(Lc)
for k,p in Pall.items():
    if not p.is_empty: cells.append(dict(region=lreg[k],raw=p,kind='cell'))
# ---- raw-level rebalancing of small cells: merge with a same-region neighbour, re-split the union in two ----
def bbm(g): b=g.bounds; return max(b[2]-b[0],b[3]-b[1])
def mind(g): b=g.bounds; return min(b[2]-b[0],b[3]-b[1])
def cut2(U):
    x0,y0,x1,y1=U.bounds; horiz=(x1-x0)>=(y1-y0); lo,hi=(x0,x1) if horiz else (y0,y1)
    for _ in range(30):
        t=(lo+hi)/2; a=U.intersection(box(x0-1,y0-1,t,y1+1) if horiz else box(x0-1,y0-1,x1+1,t)).area
        lo,hi=(t,hi) if a<U.area/2 else (lo,t)
    t=(lo+hi)/2
    A=U.intersection(box(x0-1,y0-1,t,y1+1) if horiz else box(x0-1,y0-1,x1+1,t))
    B=U.intersection(box(t,y0-1,x1+1,y1+1) if horiz else box(x0-1,t,x1+1,y1+1))
    return A,B
RB=0
for rnd in range(6):
    ch=0
    for c in sorted([c for c in cells if c['raw'].area<55000],key=lambda c:c['raw'].area):
        if c not in cells: continue
        best=None
        for o in cells:
            if o is c or o['region']!=c['region'] or o['raw'].distance(c['raw'])>2: continue
            U=unary_union([c['raw'],o['raw'].buffer(0)]).buffer(1).buffer(-1)
            if U.geom_type!='Polygon': continue
            if bbm(U)<=446:
                sc=(2,U.area)                     # plain merge
                cand=('merge',o,U,None)
            else:
                A,B=cut2(U)
                if A.geom_type!='Polygon' or B.geom_type!='Polygon' or bbm(A)>446 or bbm(B)>446 or min(mind(A),mind(B))<170: continue
                sc=(1,min(A.area,B.area)); cand=('split',o,A,B)
            if best is None or sc>best[0]: best=(sc,cand)
        if best:
            kind,o,A,B=best[1]
            if kind=='merge': o['raw']=A; cells.remove(c)
            else: c['raw']=A; o['raw']=B
            ch+=1; RB+=1
    if not ch: break
print('rebalanced',RB,'small raw left',sum(1 for c in cells if c['raw'].area<55000))
print({r:sum(1 for c in cells if c['region']==r) for r in ['Zille','Brenas','Wehlen']})
# drop Brenas/Wehlen cells not touching the rest of their region (isolated by depth noise)
def touching(a,b,d=30): return a.distance(b)<d
for rg in ['Brenas','Wehlen']:
    L=[c for c in cells if c['region']==rg]
    anchor=[c for c in cells if c['region']=='Zille'] if rg=='Brenas' else []
    keep=set()
    if rg=='Wehlen':
        kr=cityshape['Kratsna']['poly']; keep={i for i,c in enumerate(L) if touching(c['raw'],kr,60)}
    else:
        zu=unary_union([c['raw'] for c in anchor]+[v['poly'] for v in cityshape.values() if v['region']=='Zille']).buffer(60)
        keep={i for i,c in enumerate(L) if c['raw'].intersects(zu)}
    ch=True
    while ch:
        ch=False
        for i,c in enumerate(L):
            if i in keep: continue
            if any(touching(c['raw'],L[j]['raw'],60) for j in keep): keep.add(i); ch=True
    drop=[c for i,c in enumerate(L) if i not in keep]
    for c in drop: cells.remove(c)
    print(rg,'dropped isolated',len(drop))
# islands
for nm,(rg,g) in ISL.items():
    gi=biggest(g.buffer(-14))
    if nm=='Manes Riuz':
        x0,y0,x1,y1=gi.bounds; xm=(x0+x1)/2
        for part,b in [('West',box(x0-1,y0-1,xm-17,y1+1)),('East',box(xm+17,y0-1,x1+1,y1+1))]:
            cells.append(dict(region=rg,raw=biggest(gi.intersection(b)),kind='island',island=nm,fixed=True,name=f'{nm} {part}'))
    else:
        cells.append(dict(region=rg,raw=boxclip(gi,MAXB),kind='island',island=nm,fixed=True,name=nm))
for n,v in cityshape.items():
    cells.append(dict(region=v['region'],raw=v['poly'],kind='city',city=n,fixed=True,name=n))
# ---- gaps (land) ----
from shapely.strtree import STRtree
raws=[c['raw'] for c in cells]; tree=STRtree(raws)
for i,c in enumerate(cells):
    p=c['raw']
    base=p if c.get('fixed') else p.buffer(12).intersection(LIN)
    near=[j for j in tree.query(p.buffer(60)) if j!=i]
    cut=unary_union([cells[j]['raw'].buffer(34 if cells[j]['kind']=='city' or c['kind']=='city' else 17) for j in near]) if near else Polygon()
    g=base.difference(cut) if not c.get('fixed') or c['kind']=='island' else base
    if c['kind']=='city': g=base
    g=g.buffer(-3).buffer(3)
    if c['kind']=='cell':
        g0=g
        for rr in (30,20,12,6,0):
            go=g0.buffer(-rr,join_style=1).buffer(rr,join_style=1) if rr else g0
            if not go.is_empty and biggest(go).area>=0.985*biggest(g0).area-1500 and (go.geom_type=='Polygon' or sorted([q.area for q in go.geoms])[-2]<3000): g=go; break
    g=biggest(g)
    g=boxclip(g,438) if max(g.bounds[2]-g.bounds[0],g.bounds[3]-g.bounds[1])>438 else g
    c['poly']=g; c['type']='land'
# slivers -> leftovers; absorb uncovered land pieces into the best-fitting neighbour cell
ZONEU=unary_union([c['raw'] for c in cells]).buffer(8)
cells=[c for c in cells if c['poly'].area>15000 or c['kind']!='cell']
def bbm(g): b=g.bounds; return max(b[2]-b[0],b[3]-b[1])
for rnd in range(8):
    allraw=ZONEU
    left=LIN.intersection(allraw).difference(unary_union([c['poly'] for c in cells]).buffer(30))
    pcs=[g for g in getattr(left,'geoms',[left]) if g.geom_type=='Polygon' and g.area>2500]
    nabs=0
    for pc in sorted(pcs,key=lambda g:-g.area):
        best=None
        for i,c in enumerate(cells):
            if c['kind']!='cell' or c['poly'].distance(pc)>80: continue
            bridge=pc.buffer(45).intersection(c['poly'].buffer(45)).intersection(LIN)
            others=unary_union([o['poly'].buffer(34) for o in cells if o is not c and o['poly'].distance(pc)<200])
            u=unary_union([c['poly'],pc.buffer(6).intersection(LIN),bridge]).difference(others)
            u=biggest(u.buffer(-3).buffer(3))
            if bbm(u)>438:
                ux0,uy0,ux1,uy1=u.bounds; pcx,pcy=pc.centroid.x,pc.centroid.y; ccx,ccy=c['poly'].centroid.x,c['poly'].centroid.y
                bx=(ux1-438,ux1) if pcx>ccx else (ux0,ux0+438); by=(uy1-438,uy1) if pcy>ccy else (uy0,uy0+438)
                if ux1-ux0<=438: bx=(ux0,ux1)
                if uy1-uy0<=438: by=(uy0,uy1)
                u=biggest(u.intersection(box(bx[0],by[0],bx[1],by[1])))
                lost=c['poly'].difference(u).area
                if lost>0.5*pc.area or u.area<70000: continue
            if bbm(u)<=438.5 and u.area>c['poly'].area+0.3*pc.area:
                sc=bridge.area
                if best is None or sc>best[0]: best=(sc,i,u)
        if best: cells[best[1]]['poly']=best[2]; nabs+=1
    print('absorb round',rnd,'pieces',len(pcs),'absorbed',nabs,'left area',int(sum(g.area for g in pcs)))
# pieces that could not be absorbed: merge with a neighbour and re-split the union into two balanced cells
def halves(U):
    x0,y0,x1,y1=U.bounds; horiz=(x1-x0)>=(y1-y0); lo,hi=(x0,x1) if horiz else (y0,y1)
    for _ in range(30):
        t=(lo+hi)/2; a=U.intersection(box(x0-1,y0-1,t,y1+1) if horiz else box(x0-1,y0-1,x1+1,t)).area
        if a<U.area/2: lo=t
        else: hi=t
    t=(lo+hi)/2
    A=U.intersection(box(x0-1,y0-1,t-17,y1+1) if horiz else box(x0-1,y0-1,x1+1,t-17))
    B=U.intersection(box(t+17,y0-1,x1+1,y1+1) if horiz else box(x0-1,t+17,x1+1,y1+1))
    return biggest(A),biggest(B)
for rnd in range(3):
    allraw=ZONEU
    left=LIN.intersection(allraw).difference(unary_union([c['poly'] for c in cells]).buffer(30))
    pcs=[g for g in getattr(left,'geoms',[left]) if g.geom_type=='Polygon' and g.area>6000]
    done=0
    for pc in sorted(pcs,key=lambda g:-g.area):
        opts=[]
        for i,c in enumerate(cells):
            if c['kind']!='cell' or c['poly'].distance(pc)>80: continue
            bridge=pc.buffer(45).intersection(c['poly'].buffer(45)).intersection(LIN)
            others=unary_union([o['poly'].buffer(34) for o in cells if o is not c and o['poly'].distance(pc)<300])
            U=biggest(unary_union([c['poly'],pc.buffer(6).intersection(LIN),bridge]).difference(others).buffer(-3).buffer(3))
            A,B=halves(U)
            if bbm(A)<=438 and bbm(B)<=438 and min(A.area,B.area)>60000 and min(A.bounds[2]-A.bounds[0],A.bounds[3]-A.bounds[1],B.bounds[2]-B.bounds[0],B.bounds[3]-B.bounds[1])>190: opts.append((bridge.area,i,A,B))
        if opts:
            _,i,A,B=max(opts,key=lambda o:o[0]); c=cells[i]
            c['poly']=A.buffer(-20,join_style=1).buffer(20,join_style=1)
            cells.append(dict(region=c['region'],raw=B.buffer(17),kind='cell',type='land',poly=B.buffer(-20,join_style=1).buffer(20,join_style=1)))
            c['raw']=A.buffer(17); done+=1
    print('resplit round',rnd,'pieces',len(pcs),'resplit',done)
    if not done: break
left=LIN.intersection(ZONEU).difference(unary_union([c['poly'] for c in cells]).buffer(30))
pcs=[g for g in getattr(left,'geoms',[left]) if g.geom_type=='Polygon' and g.area>6000]
print('remaining pieces',[(round(g.area),tuple(round(v) for v in g.centroid.coords[0]),round(bbm(g))) for g in pcs])
for g in pcs:
    if g.area>=15000:
        rg=min([c for c in cells if c['type']=='land'],key=lambda c:c['poly'].distance(g))['region']
        q=boxclip(g.buffer(10).intersection(LIN).difference(unary_union([c['poly'].buffer(34) for c in cells if c['poly'].distance(g)<200])),438)
        q=biggest(q.buffer(-3).buffer(3)); cells.append(dict(region=rg,raw=q,kind='cell',type='land',poly=q)); print('  own province',rg,round(q.area))
# ---- sea ----
SCq=float(sys.argv[2]) if len(sys.argv)>2 else 445.0
YS=306+round((4446-306)/SCq)*SCq
SEA_ZONE=Polygon([(5650,276),(8350,276),(8420,1650),(7400,2500),(7750,3500),(7900,YS),(3800,YS),(3800,3850),(4900,3300),(5500,2100)])
SZ=SEA_ZONE.intersection(FRAME).difference(LAND.buffer(20))
SZ=biggest(SZ) if SZ.geom_type!='Polygon' else SZ
SZ=SZ.buffer(-4).buffer(4)
nsea=int(sys.argv[1]) if len(sys.argv)>1 else int(round(SZ.area/TA['Sea']))
SC=SCq
ROT=float(sys.argv[3]) if len(sys.argv)>3 else 0.0
vs=[]
org=(6000,3000)
SZr=affinity.rotate(SZ,-ROT,origin=org)
bx0,by0,bx1,by1=SZr.bounds
rng=np.random.default_rng(11)
for j,y in enumerate(np.arange(306.0,by1,SC)):
    off=rng.uniform(0,SC)
    for x in np.arange(bx0-off,bx1,SC):
        q=SZr.intersection(box(x,y,x+SC,y+SC))
        for g in getattr(q,'geoms',[q]):
            if g.geom_type=='Polygon' and g.area>300: vs.append(affinity.rotate(g,ROT,origin=org))
# split oversize sea cells, merge tiny ones
def bbmax(g): b=g.bounds; return max(b[2]-b[0],b[3]-b[1])
out=[]
stack=list(vs)
while stack:
    v=stack.pop()
    if bbmax(v)<=MAXB+30: out.append(v); continue
    b=v.bounds; cx,cy=(b[0]+b[2])/2,(b[1]+b[3])/2
    if b[2]-b[0]>=b[3]-b[1]: h1,h2=box(b[0]-1,b[1]-1,cx,b[3]+1),box(cx,b[1]-1,b[2]+1,b[3]+1)
    else: h1,h2=box(b[0]-1,b[1]-1,b[2]+1,cy),box(b[0]-1,cy,b[2]+1,b[3]+1)
    for h in (h1,h2):
        q=v.intersection(h)
        for g in getattr(q,'geoms',[q]):
            if g.geom_type=='Polygon' and g.area>500: stack.append(g)
# merge sea pieces < 35k into neighbour if the union fits
changed=True
while changed:
    changed=False
    out.sort(key=lambda g:g.area)
    for i,g in enumerate(out):
        if g.area>=0.45*SC*SC: continue
        best=None
        for j,h in enumerate(out):
            if j==i or g.distance(h)>1: continue
            u=unary_union([g,h])
            if u.geom_type=="Polygon" and bbmax(u)<=MAXB+30:
                sh=g.intersection(h.buffer(1)).area
                if best is None or sh>best[0]: best=(sh,j,u)
        if best is None and g.area<30000:
            for j,h in enumerate(out):
                if j==i or g.distance(h)>1: continue
                u=unary_union([g,h])
                if u.geom_type!='Polygon': continue
                u=boxclip(u,MAXB+30)
                sh=g.intersection(h.buffer(1)).area
                if u.area>h.area+0.5*g.area and (best is None or sh>best[0]): best=(sh,j,u)
        if best:
            out[best[1]]=best[2]; out.pop(i); changed=True; break
sea=[]
for v in out:
    g=v.buffer(-17,join_style=2,mitre_limit=3).simplify(10)
    g=biggest(g) if not g.is_empty else g
    if g.is_empty or g.area<12000: continue
    sea.append(dict(region='Sea',type='sea',kind='sea',raw=v,poly=g))
print('sea zone area %.2fM'%(SZ.area/1e6),'sea cells',len(sea),'smallest',int(min(s['poly'].area for s in sea)))
pickle.dump(dict(land=cells,sea=sea,SZ=SZ,SETT=SETT),open('work/prov6_stage2.pkl','wb'))
print({r:sum(1 for c in cells if c['region']==r) for r in ['Zille','Brenas','Wehlen']},'cities',sum(1 for c in cells if c['kind']=='city'))
