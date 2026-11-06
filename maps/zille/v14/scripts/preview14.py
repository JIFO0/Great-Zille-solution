"""v14 previews (from preview13): adjacency graph, new v13 seas, terrain + roads map with road-linked borders."""
import pickle, json, numpy as np, os, sys
sys.path.insert(0,'versions/v14/scripts')
from PIL import Image, ImageDraw, ImageFont
Image.MAX_IMAGE_PIXELS=None
RD='versions/v14/regions'; PV='versions/v14/previews'
F=pickle.load(open('work14/prov14_final.pkl','rb')); P=F['allp']; by={c['id']:c for c in P}
AJ=pickle.load(open('work14/adj14.pkl','rb')); edges=AJ['edges']
AT=pickle.load(open('work14/attrs14.pkl','rb')); A=AT['A']; ROADS=AT['ROADS']
FB='/usr/share/fonts/truetype/sand-box/google/Tinos/Tinos-Bold.ttf'
NEW=[c['id'] for c in P if c.get('lespia_tw_cut')]
FLUSH=[c['id'] for c in P if c['type']=='sea' and 'flush' in c.get('note','')]
def ctr(c): p=c['poly'].representative_point() if c['kind']!='island' or c['poly'].geom_type=='Polygon' else c['poly'].centroid; return (p.x,p.y)
def fade(im,a=0.35): return Image.blend(im.convert('RGB'),Image.new('RGB',im.size,(255,255,255)),a)
def legend(d,items,fs,lw):
    f=ImageFont.truetype(FB,fs); w=fs*24
    d.rectangle([10,10,10+w,10+fs*1.4*len(items)+12],fill=(255,255,255,235),outline=(0,0,0,255))
    for k,(lab,col,kind) in enumerate(items):
        yy=20+k*fs*1.4+fs*0.5
        if kind=='box': d.rectangle([20,yy-fs*0.4,20+fs*2,yy+fs*0.4],fill=col,outline=(0,0,0,255))
        else: d.line([(20,yy),(20+fs*2,yy)],fill=col,width=lw*(3 if kind=='thick' else 1))
        d.text((30+fs*2,yy),lab,font=f,fill=(0,0,0,255),anchor='lm')
def nodes(d,x0,y0,sc,size,fs,lw):
    f=ImageFont.truetype(FB,fs)
    for c in P:
        x,y=ctr(c); px,py=(x-x0)*sc,(y-y0)*sc
        if 0<=px<size[0] and 0<=py<size[1]:
            r=lw*2.2; d.ellipse([px-r,py-r,px+r,py+r],fill=(255,255,255,255),outline=(0,0,0,255))
            d.text((px,py-fs*0.9),c['id'].split('_')[1],font=f,fill=(0,0,0,255),anchor='mm',stroke_width=max(2,fs//7),stroke_fill=(255,255,255,255))
def seg(a,b,x0,y0,sc):
    pa,pb=ctr(by[a]),ctr(by[b]); return [((pa[0]-x0)*sc,(pa[1]-y0)*sc),((pb[0]-x0)*sc,(pb[1]-y0)*sc)]
def dashed(d,s,col,lw):
    n=max(2,int(np.hypot(s[1][0]-s[0][0],s[1][1]-s[0][1])/(lw*4)))
    for k in range(0,n,2):
        p=[s[0][q]+(s[1][q]-s[0][q])*k/n for q in (0,1)]; r=[s[0][q]+(s[1][q]-s[0][q])*(k+1)/n for q in (0,1)]
        d.line([tuple(p),tuple(r)],fill=col,width=lw)
# ---------------- adjacency ----------------
COL={'land':(20,20,20,255),'sea':(0,70,220,255),'coastal':(0,190,210,255),'strait':(230,0,200,255),'manual':(255,140,0,255)}
def draw_adj(img,x0,y0,sc,out,fs,lw):
    im=img.convert('RGBA'); ov=Image.new('RGBA',im.size,(0,0,0,0)); d=ImageDraw.Draw(ov)
    for t in ('coastal','sea','land','strait'):
        for (a,b),e in edges.items():
            if e['type']!=t: continue
            s=seg(a,b,x0,y0,sc)
            if t=='coastal': dashed(d,s,COL[t],lw)
            elif e.get('source')=='manual': d.line(s,fill=COL['manual'],width=lw*2)
            else: d.line(s,fill=COL[t],width=lw*(2 if t=='strait' else 1))
    nodes(d,x0,y0,sc,im.size,fs,lw)
    legend(d,[('land-land',COL['land'],'line'),('land-land (manual: 5-9, 38-115 across Zille Bay inlet)',COL['manual'],'thick'),('(Yol 129: impassable, no links)',(90,90,90,255),'line'),('sea-sea',COL['sea'],'line'),
              ('coastal (embark/landing, dashed)',COL['coastal'],'line'),('strait (island crossing)',COL['strait'],'thick')],fs,lw)
    Image.alpha_composite(im,ov).convert('RGB').save(out)
base=Image.open(f'{PV}/provinces_preview.png'); sc=base.size[0]/12288
draw_adj(fade(base),0,0,sc,f'{RD}/adjacency_preview.png',34,4)
z=Image.open(f'{PV}/provinces_zille_crop.png'); CX=(6000,4300,3800,2760)
draw_adj(fade(z),CX[0],CX[1],z.size[0]/CX[2],f'{RD}/adjacency_zille_crop.png',30,4)
n=base.crop((round(4300*sc),round(276*sc),round(10300*sc),round(4176*sc))).resize((2400,1560),Image.LANCZOS)
draw_adj(fade(n),4300,276,2400/6000,f'{RD}/adjacency_north_channel_crop.png',28,4)
zb=Image.open(f'{PV}/provinces_zille_bay_corridor_crop.png'); CB=(4800,3700,3300,2900)
draw_adj(fade(zb),CB[0],CB[1],zb.size[0]/CB[2],f'{RD}/adjacency_zille_bay_crop.png',30,4)
db=Image.open(f'{PV}/derdia_border_crop.png'); CD=(1200,2300,3300,2800)
draw_adj(fade(db),CD[0],CD[1],db.size[0]/CD[2],f'{RD}/adjacency_derdia_wehlen_crop.png',30,4)
lw_=Image.open(f'{PV}/lespia_territorial_waters_crop.png'); CL=(7600,250,4688,2900)
draw_adj(fade(lw_),CL[0],CL[1],lw_.size[0]/CL[2],f'{RD}/adjacency_lespia_north_crop.png',30,4)
# ---------------- new sea corridor highlight ----------------
def poly_px(g,x0,y0,sc):
    for q in getattr(g,'geoms',[g]): yield [((x-x0)*sc,(y-y0)*sc) for x,y in q.exterior.coords]
def corridor(img,x0,y0,sc,out,fs,lw):
    im=img.convert('RGBA'); ov=Image.new('RGBA',im.size,(0,0,0,0)); d=ImageDraw.Draw(ov); f=ImageFont.truetype(FB,fs)
    for i in NEW:
        for pts in poly_px(by[i]['poly'],x0,y0,sc): d.polygon(pts,fill=(0,90,255,90),outline=(0,40,200,255),width=lw)
    for i in NEW:
        x,y=ctr(by[i]); d.text(((x-x0)*sc,(y-y0)*sc),f"{i.split('_')[1]} {by[i]['name']}",font=f,fill=(0,0,90,255),anchor='mm',stroke_width=max(2,fs//7),stroke_fill=(255,255,255,255))
    from lespia14 import STRIP
    for q in getattr(STRIP,'geoms',[STRIP]):
        d.polygon([((x-x0)*sc,(y-y0)*sc) for x,y in q.exterior.coords],fill=(255,200,0,110),outline=(200,120,0,255))
    legend(d,[("v14: seas cut back from Lespia ("+' '.join(i.split('_')[1] for i in NEW)+")",(0,90,255,160),'box'),("Lespia's territorial waters (non-playable, >= 180 px)",(255,200,0,160),'box')],fs,lw)
    Image.alpha_composite(im,ov).convert('RGB').save(out)
CS=(7600,250,4688,2900); ss=base.crop(tuple(round(v*sc) for v in (CS[0],CS[1],CS[0]+CS[2],CS[1]+CS[3]))).resize((2400,round(2400*CS[3]/CS[2])),Image.LANCZOS)
corridor(ss,CS[0],CS[1],2400/CS[2],f'{PV}/lespia_territorial_waters_strip.png',30,4)
# ---------------- terrain + roads ----------------
TC={'plains':(150,205,110,150),'hills':(225,180,90,170),'mountains':(150,95,60,190)}
RC={'main':((200,0,0,255),3),'secondary':((255,140,0,255),2),'minor':((110,110,110,255),1),'railway':((0,0,0,255),1)}
def terrain(img,x0,y0,sc,out,fs,lw):
    im=fade(img,0.45).convert('RGBA'); ov=Image.new('RGBA',im.size,(0,0,0,0)); d=ImageDraw.Draw(ov); f=ImageFont.truetype(FB,fs)
    for c in P:
        col=(120,170,230,110) if c['type']=='sea' else TC[A[c['id']]['terrain']]
        for pts in poly_px(c['poly'],x0,y0,sc): d.polygon(pts,fill=col,outline=(60,60,60,200))
    for cls in ('minor','secondary','main','railway'):
        for r in ROADS:
            if r['cls']!=cls: continue
            pts=[((x-x0)*sc,(y-y0)*sc) for x,y in r['line'].coords]
            col,w=RC[cls]
            if cls=='railway': dashed(d,[pts[0],pts[0]],col,1); d.line(pts,fill=col,width=max(1,lw-1))
            else: d.line(pts,fill=col,width=w*max(1,lw//2))
    for (a,b),e in edges.items():
        if e['type']!='land': continue
        s=seg(a,b,x0,y0,sc)
        if e['road_link']: d.line(s,fill=(255,0,200,255) if e['road_link_class']=='main' else (140,0,230,255),width=lw*2)
        else: d.line(s,fill=(0,0,0,70),width=1)
    for c in P:
        if c['type']!='land': continue
        x,y=ctr(c); a=A[c['id']]; tag={'main':'M','secondary':'S','minor':'m','none':''}[a['road_class']]+('R' if a['has_railway'] else '')
        d.text(((x-x0)*sc,(y-y0)*sc),c['id'].split('_')[1]+(' '+tag if tag else ''),font=f,fill=(0,0,0,255),anchor='mm',stroke_width=max(2,fs//7),stroke_fill=(255,255,255,255))
    legend(d,[('plains',TC['plains'],'box'),('hills',TC['hills'],'box'),('mountains',TC['mountains'],'box'),
              ('main road',RC['main'][0],'thick'),('secondary road',RC['secondary'][0],'line'),('minor road',RC['minor'][0],'line'),('railway',RC['railway'][0],'line'),
              ('road link: main road crosses border',(255,0,200,255),'thick'),('road link: secondary road crosses border',(140,0,230,255),'thick'),
              ('label: id + M/S/m best road, R railway',(0,0,0,255),'line')],fs,lw)
    Image.alpha_composite(im,ov).convert('RGB').save(out)
bm=Image.open('work14/base/zille_preview.png'); terrain(bm,0,0,bm.size[0]/12288,f'{PV}/terrain_roads_preview.png',24,3)
zc=Image.open('work14/tmp/crop_provinces_zille_crop.png'); terrain(zc,CX[0],CX[1],zc.size[0]/CX[2],f'{PV}/terrain_roads_zille_crop.png',28,4)
wc=Image.open('work14/tmp/crop_wehlen_crop.png'); CW=(1200,250,5200,4000); terrain(wc,CW[0],CW[1],wc.size[0]/CW[2],f'{PV}/terrain_roads_wehlen_derdia_crop.png',28,4)
bc=Image.open('work14/tmp/crop_brivane_road_crop.png'); CBv=(7200,5600,3600,2400); terrain(bc,CBv[0],CBv[1],bc.size[0]/CBv[2],f'{PV}/terrain_roads_brivane_crop.png',30,4)
print('ok')
