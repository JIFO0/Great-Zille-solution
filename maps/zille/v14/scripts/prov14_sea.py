"""v14 sea fix (owner: 'at the very south the sea provinces are a few px too short -> a step between sea and land
provinces'). Every sea province whose edge runs within 60 px of the map frame (land frame box 295,306,11993,7877) is
extended flush to the frame line, exactly like the land provinces end at the frame; the 64 px gaps to the neighbouring
provinces are kept (extension clipped to the free area). -> work14/sea14.pkl {id: poly}"""
import pickle, sys
sys.path.insert(0,'/workspace/zille/versions/v14/scripts')
from shapely.geometry import box, Polygon
from shapely.ops import unary_union
from zones14 import LAND
from lespia14 import TWZ, LES, GAP
FR=(295,306,11993,7877)
F=pickle.load(open('work13/prov13_final.pkl','rb'))['allp']
SEA=[c for c in F if c['type']=='sea']; LANDP=[c for c in F if c['type']=='land']
out={}; rep=[]
for c in SEA:
    g=c['poly']; b=g.bounds; ext=[]
    for side,cond,mk in (
        ('bottom',FR[3]-b[3]<60 and FR[3]-b[3]>0.5, lambda gg: box(gg.bounds[0],b[3]-45,gg.bounds[2],FR[3])),
        ('top',   b[1]-FR[1]<60 and b[1]-FR[1]>0.5, lambda gg: box(gg.bounds[0],FR[1],gg.bounds[2],b[1]+45)),
        ('right', FR[2]-b[2]<60 and FR[2]-b[2]>0.5, lambda gg: box(b[2]-45,gg.bounds[1],FR[2],gg.bounds[3])),
        ('left',  b[0]-FR[0]<60 and b[0]-FR[0]>0.5, lambda gg: box(FR[0],gg.bounds[1],b[0]+45,gg.bounds[3]))):
        if not cond: continue
        # the part of the shape that touches that edge, swept to the frame
        if side=='bottom': edge=g.intersection(box(b[0],b[3]-45,b[2],b[3]))
        elif side=='top': edge=g.intersection(box(b[0],b[1],b[2],b[1]+45))
        elif side=='right': edge=g.intersection(box(b[2]-45,b[1],b[2],b[3]))
        else: edge=g.intersection(box(b[0],b[1],b[0]+45,b[3]))
        ext.append((side,mk(edge)))
    if not ext: out[c['id']]=g; continue
    others=unary_union([o['poly'].buffer(64) for o in F if o is not c and o['poly'].distance(g)<400])
    free=box(*FR).difference(others).difference(LAND.buffer(32))
    ng=unary_union([g]+[e.intersection(free) for _,e in ext]).buffer(1).buffer(-1)
    if ng.geom_type!='Polygon': ng=max(ng.geoms,key=lambda q:q.area)
    out[c['id']]=ng
    rep.append((c['id'],[s for s,_ in ext],[round(v,1) for v in b],[round(v,1) for v in ng.bounds],round(ng.area-g.area)))
LESP=[]
for i,g in list(out.items()):
    if g.distance(LES)>=GAP+1: continue
    a0=g.area; ng=g.difference(TWZ.buffer(2,join_style=1)).buffer(-20,join_style=1).buffer(20,join_style=1)
    if ng.geom_type!='Polygon': ng=max(ng.geoms,key=lambda q:q.area)
    out[i]=ng.simplify(1.0); LESP.append(i)
    print('Lespia cut',i,'area %d -> %d'%(a0,ng.area),'bbox',[round(v) for v in ng.bounds],'dist to Lespia %.0f'%ng.distance(LES))
for r in rep: print(*r)
pickle.dump(LESP,open('work14/sea14_lespia_cut.pkl','wb'))
pickle.dump(out,open('work14/sea14.pkl','wb'))
