import pickle, numpy as np, collections
from PIL import Image, ImageDraw
from scipy import ndimage
F=pickle.load(open('work/prov12_final.pkl','rb')); P=F['allp']
S=4; W,H=12288//S,8192//S; T=95
lab=Image.new('I',(W,H),0); d=ImageDraw.Draw(lab)
def geoms(g): return list(g.geoms) if hasattr(g,'geoms') else [g]
for k,c in enumerate(P,1):
    for g in geoms(c['poly']):
        d.polygon([(x/S,y/S) for x,y in g.exterior.coords],fill=k)
        for h in g.interiors: d.polygon([(x/S,y/S) for x,y in h.coords],fill=0)
L=np.array(lab,dtype=np.int32)
dist,(iy,ix)=ndimage.distance_transform_edt(L==0,return_indices=True)
V=L[iy,ix]; V[dist*S>T]=0
cnt=collections.Counter()
for a,b in ((V[:,1:],V[:,:-1]),(V[1:,:],V[:-1,:])):
    m=(a!=b)&(a>0)&(b>0)
    for x,y in zip(a[m],b[m]): cnt[(min(x,y),max(x,y))]+=1
res={(P[a-1]['id'],P[b-1]['id']):n*S for (a,b),n in cnt.items()}
pickle.dump(res,open('work/voradj12.pkl','wb'))
np.save('work/vorlab12.npy',V.astype(np.int16)); pickle.dump([c['id'] for c in P],open('work/vorlab12_ids.pkl','wb'))
