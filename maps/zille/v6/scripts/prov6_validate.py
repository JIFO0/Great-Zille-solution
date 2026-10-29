import numpy as np, pickle, json
src=open('provinces6.py').read().split("# ---------------- city provinces")[0]
exec(src)
F=pickle.load(open('work/prov6_final.pkl','rb')); allp=F['allp']
S2=pickle.load(open('work/prov6_stage2.pkl','rb')); SZ=S2['SZ']
from shapely.strtree import STRtree
polys=[c['poly'] for c in allp]; t=STRtree(polys); ov=[]
for i,p in enumerate(polys):
    for j in t.query(p):
        if j>i and p.intersection(polys[j]).area>1: ov.append((allp[i]['id'],allp[j]['id']))
LANDU=LAND
water=[(c['id'],round(c['poly'].difference(LANDU).area)) for c in allp if c['type']=='land' and c['poly'].difference(LANDU).area>1]
seaonland=[(c['id'],round(c['poly'].intersection(LANDU).area)) for c in allp if c['type']=='sea' and c['poly'].intersection(LANDU).area>1]
cover=unary_union(polys).buffer(40)
def holes(zone,minA=8000):
    h=zone.difference(cover); return sorted([round(g.area) for g in getattr(h,'geoms',[h]) if g.area>minA],reverse=True)
penpoly=unary_union([c['raw'] for c in allp if c['type']=='land' and c['region']=='Zille'])
Zl=[p for p in dd['Ld'].geoms if p.area>5e6]
zil_zone=LIN.intersection(unary_union([g.buffer(0) for g in measure_free]) ) if False else None
pm=rast(LIN)&pen
import skimage.measure as skm
covm=rast(cover)
unc=pm&~covm; lab,n=ndi.label(unc); sz=ndi.sum(unc,lab,range(1,n+1))*64
big=[(int(s),tuple(int(v*G) for v in ndi.center_of_mass(unc,lab,i+1))[::-1]) for i,s in enumerate(sz) if s>8000]
bw={}
for rg in ['Brenas','Wehlen']:
    z=unary_union([c['raw'] for c in allp if c['type']=='land' and c['region']==rg and c['kind']=='cell']).buffer(-20)
    bw[rg]=holes(z)
seah=holes(SZ.buffer(-20))
cities=[c['city'] for c in allp if c['kind']=='city']
res=dict(overlaps=ov,land_on_water=water,sea_on_land=seaonland,zille_uncovered_pieces=big,
         zille_uncovered_total=int(sum(sz[sz>0])), brenas_holes=bw['Brenas'],wehlen_holes=bw['Wehlen'],sea_holes=seah,
         tile_violations=F['val_bad'],cities=cities,max_alpha=max(max(r['alpha_w'],r['alpha_h']) for r in F['rows']))
print(json.dumps(res,indent=0,default=str))
json.dump(res,open('versions/v6/provinces_validation.json','w'),indent=1,default=str)
