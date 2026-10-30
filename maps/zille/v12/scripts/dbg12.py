import pickle,sys
from PIL import Image, ImageDraw
Image.MAX_IMAGE_PIXELS=None
S=pickle.load(open('work/prov12_stage2.pkl','rb'))
b=Image.open('work/v11base/zille_preview.png'); s=b.size[0]/12288
x0,y0,x1,y1=[int(v) for v in sys.argv[2].split(",")] if len(sys.argv)>2 else (4600,3700,8200,6800); Wd=1400; k=Wd/(x1-x0)
c=b.crop((int(x0*s),int(y0*s),int(x1*s),int(y1*s))).resize((Wd,int(Wd*(y1-y0)/(x1-x0)))).convert('RGB')
d=ImageDraw.Draw(c,'RGBA')
def P(g,fill,out):
    for q in getattr(g,'geoms',[g]):
        if q.geom_type!='Polygon': continue
        d.polygon([((x-x0)*k,(y-y0)*k) for x,y in q.exterior.coords],fill=fill,outline=out)
P(S['SZ_C'],(0,0,255,40),(0,0,255,255))
for t in S['land']: P(t['poly'],(255,0,0,60),(150,0,0,255))
for t in S['sea']:
    P(t['poly'],(255,0,0,90),(0,120,0,255))
    p=t['poly'].representative_point(); d.text(((p.x-x0)*k,(p.y-y0)*k),t['id'].split('_')[1],fill=(0,0,0))
c.save(sys.argv[1])
