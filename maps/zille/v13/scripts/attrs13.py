"""v13 (same method as v12) game attributes per land province from the base-map layers: roads (main_roads / roads_double / roads_minor), railways,
terrain (topography contour bands L1..L8). -> work13/attrs13.pkl"""
import re, io, pickle, numpy as np, cairosvg, json
from PIL import Image
from shapely.geometry import LineString, Point
from shapely.ops import unary_union
Image.MAX_IMAGE_PIXELS=None
SVG='work13/base/zille_vector.svg'; s=open(SVG).read()
F=pickle.load(open('work13/prov13_final.pkl','rb')); allp=F['allp']; SETT=pickle.load(open('work/prov12_stage2.pkl','rb'))['SETT']
def group(gid):
    i=s.find(f'<g id="{gid}"'); k=i; depth=0
    while True:
        a=s.find('<g',k+1); b=s.find('</g>',k+1)
        if a!=-1 and a<b: depth+=1; k=a
        else:
            if depth==0: return s[i:b+4]
            depth-=1; k=b
# ---------- path parser (absolute M/C/Z, which is all these layers use) ----------
def bez(p0,p1,p2,p3,n=12):
    t=np.linspace(0,1,n+1)[1:,None]
    return ((1-t)**3*p0+3*(1-t)**2*t*p1+3*(1-t)*t**2*p2+t**3*p3)
def parse(d):
    tok=re.findall(r'[MCZ]|-?\d*\.?\d+(?:e-?\d+)?',d); i=0; lines=[]; cur=[]; cmd=None
    while i<len(tok):
        t=tok[i]
        if t in 'MCZ': cmd=t; i+=1
        if cmd=='M':
            if len(cur)>1: lines.append(cur)
            cur=[np.array([float(tok[i]),float(tok[i+1])])]; i+=2; cmd='L'
        elif cmd=='C':
            p=[np.array([float(tok[i+2*k]),float(tok[i+2*k+1])]) for k in range(3)]; i+=6
            cur+=list(bez(cur[-1],*p))
        elif cmd=='Z':
            if cur: cur.append(cur[0])
        elif cmd=='L':
            cur.append(np.array([float(tok[i]),float(tok[i+1])])); i+=2
    if len(cur)>1: lines.append(cur)
    return [LineString(l) for l in lines]
SN=[(n,np.array(p)) for n,p,t in SETT]
def along(ln,r=180):
    """settlements the line starts/ends at or passes through, in order along the line"""
    out=[]
    for n,p in SN:
        P=Point(*p)
        if ln.distance(P)<r: out.append((ln.project(P),n))
    out=[n for _,n in sorted(out)]
    a=sorted((np.hypot(*(p-np.array(ln.coords[0]))),n) for n,p in SN)[0]
    b=sorted((np.hypot(*(p-np.array(ln.coords[-1]))),n) for n,p in SN)[0]
    if a[0]<700 and (not out or out[0]!=a[1]) and a[1] not in out: out=[a[1]]+out
    if b[0]<700 and (not out or out[-1]!=b[1]) and b[1] not in out: out=out+[b[1]]
    return out
def slug(x): return re.sub(r'[^a-z0-9]+','_',x.lower()).strip('_')
ROADS=[]
for layer,cls in (('main_roads','main'),('roads_double_fill','secondary'),('roads_minor','minor'),('railway_line','railway')):
    g=group(layer)
    for k,m in enumerate(re.finditer(r'<path([^>]*)/?>',g)):
        attrs=m.group(1); d=re.search(r' d="([^"]+)"',attrs).group(1); pid=re.search(r'id="([^"]+)"',attrs)
        for ln in parse(d):
            via=along(ln)
            ends=[via[0],via[-1]] if len(via)>1 else via
            pre={'main':'main','secondary':'road','minor':'minor','railway':'rail'}[cls]
            rid=pid.group(1).replace('_fill','') if pid else (f'{pre}_'+'_'.join(slug(x) for x in ends) if ends else f'{pre}_{k+1}')
            nm=' - '.join(via) if via else rid
            ROADS.append(dict(id=rid,cls=cls,name=nm,via=via,line=ln,svg_layer=layer))
# make road ids unique
seen={}
for r in ROADS:
    n=seen.get(r['id'],0); seen[r['id']]=n+1
    if n: r['id']=f"{r['id']}_{n+1}"
print('roads by class',{c:sum(1 for r in ROADS if r['cls']==c) for c in ('main','secondary','minor','railway')})
for r in ROADS:
    if r['cls']!='minor': print(' ',r['cls'],r['id'],r['name'],int(r['line'].length))
# ---------- topography bands ----------
G=4; W,H=12288//G,8192//G
def mask(body):
    sv=f'<svg xmlns="http://www.w3.org/2000/svg" width="{W}" height="{H}" viewBox="0 0 12288 8192"><g fill="#000" fill-rule="evenodd" stroke="none">{body}</g></svg>'
    im=Image.open(io.BytesIO(cairosvg.svg2png(bytestring=sv.encode(),output_width=W,output_height=H))).convert('RGBA')
    return np.asarray(im)[:,:,3]>127
BAND=np.zeros((H,W),np.uint8)
for L in range(1,9):
    paths=''.join(re.findall(r'<path[^>]*/>',''.join(group(f'topo_{r}_L{L}') for r in ('wehlen','lerdia','zille_peninsula','olive_country') if f'<g id="topo_{r}_L{L}"' in s)))
    if not paths: continue
    m=mask(paths); BAND[m]=np.maximum(BAND[m],L)
np.save('work13/topo_band13.npy',BAND)
from PIL import ImageDraw
def rast(geom):
    im=Image.new('L',(W,H),0); d=ImageDraw.Draw(im)
    for p in getattr(geom,'geoms',[geom]):
        d.polygon([(x/G,y/G) for x,y in p.exterior.coords],fill=255)
        for r in p.interiors: d.polygon([(x/G,y/G) for x,y in r.coords],fill=0)
    return np.asarray(im)>0
# terrain thresholds (topography contour bands 0..8; band = number of contour levels a point lies above)
T_HILLS=dict(mean=1.6,p90=3)          # hills: mean band >= 1.6  or  p90 band >= 3
T_MOUNT=dict(mean=3.4,p90=5)          # mountains: mean band >= 3.4  or  p90 band >= 5 (with >= 25% of the area at band >= 4)
MIN_IN=60                              # a road counts for a province when >= 60 map px of it run inside the province
RANK={'main':3,'secondary':2,'minor':1}
# road length per province is measured on the gap-Voronoi cells (work13/vorlab13.npy from work/voradj12.py), so a road running
# in the drawn gap between two provinces counts for the nearer one; sampled every 2 map px
VL=np.load('work13/vorlab13.npy'); VID=pickle.load(open('work13/vorlab13_ids.pkl','rb'))
RL={}
for r in ROADS:
    ln=r['line']; n=max(2,int(ln.length/2)); step=ln.length/n; cnt={}
    for t in range(n):
        p=ln.interpolate((t+0.5)*step); l=int(VL[min(int(p.y/4),VL.shape[0]-1),min(int(p.x/4),VL.shape[1]-1)])
        if l: cnt[VID[l-1]]=cnt.get(VID[l-1],0)+step
    RL[r['id']]=cnt
A={}
for c in allp:
    if c['type']!='land': continue
    m=rast(c['poly']); b=BAND[m].astype(float)
    st=dict(band_mean=round(float(b.mean()),2),band_max=int(b.max()),band_p90=int(np.percentile(b,90)),
            share_band_ge4=round(float((b>=4).mean()),3),share_band_ge6=round(float((b>=6).mean()),3))
    if st['band_mean']>=T_MOUNT['mean'] or (st['band_p90']>=T_MOUNT['p90'] and st['share_band_ge4']>=0.25): ter='mountains'
    elif st['band_mean']>=T_HILLS['mean'] or st['band_p90']>=T_HILLS['p90']: ter='hills'
    else: ter='plains'
    inside=[(r,RL[r['id']].get(c['id'],0)) for r in ROADS if RL[r['id']].get(c['id'],0)>=MIN_IN]
    rc=[r for r,L in inside if r['cls']!='railway']
    best=max((RANK[r['cls']] for r in rc),default=0)
    A[c['id']]=dict(terrain=ter,elevation=st,
        has_main_road=any(r['cls']=='main' for r in rc),
        has_secondary_road=any(r['cls']=='secondary' for r in rc),
        road_class={3:'main',2:'secondary',1:'minor',0:'none'}[best],
        main_road_ids=sorted({r['id'] for r in rc if r['cls']=='main'}),
        main_road_names=sorted({r['name'] for r in rc if r['cls']=='main'}),
        secondary_road_ids=sorted({r['id'] for r in rc if r['cls']=='secondary'}),
        minor_road_ids=sorted({r['id'] for r in rc if r['cls']=='minor'}),
        has_railway=any(r['cls']=='railway' for r,L in inside),
        railway_ids=sorted({r['id'] for r,L in inside if r['cls']=='railway'}),
        road_length_inside={k:round(sum(L for r,L in inside if r['cls']==k)) for k in ('main','secondary','minor','railway')})
pickle.dump(dict(A=A,ROADS=ROADS,T_HILLS=T_HILLS,T_MOUNT=T_MOUNT,MIN_IN=MIN_IN),open('work13/attrs13.pkl','wb'))
from collections import Counter
print('terrain',Counter(v['terrain'] for v in A.values()),'road_class',Counter(v['road_class'] for v in A.values()),'rail',sum(v['has_railway'] for v in A.values()))
for i,v in []: print(i[10:],v['terrain'],v['elevation']['band_mean'],v['elevation']['band_p90'],v['elevation']['share_band_ge4'],v['road_class'],v['has_railway'])
