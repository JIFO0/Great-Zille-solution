"""v13 review 1: before/after of the Brenas rework (v13 before review vs now), Brenas + border crop."""
from PIL import Image, ImageDraw, ImageFont
Image.MAX_IMAGE_PIXELS=None
FB='/usr/share/fonts/truetype/sand-box/google/Tinos/Tinos-Bold.ttf'
a=Image.open('versions/v13/_backup_pre_review1/previews/provinces_preview.png').convert('RGB'); b=Image.open('versions/v13/previews/provinces_preview.png').convert('RGB')
sc=a.size[0]/12288; box=tuple(round(v*sc) for v in (6900,3500,12100,8000))
A=a.crop(box); B=b.crop(box); W=1800; h=round(A.size[1]*W/A.size[0]); A=A.resize((W,h),Image.LANCZOS); B=B.resize((W,h),Image.LANCZOS)
im=Image.new('RGB',(2*W+20,h+70),(255,255,255)); im.paste(A,(0,70)); im.paste(B,(W+20,70)); d=ImageDraw.Draw(im); f=ImageFont.truetype(FB,40)
d.text((W//2,35),'v13 before review 1 (Brenas overhangs, tiny Dapalle 51)',font=f,fill=(0,0,0),anchor='mm'); d.text((W+20+W//2,35),'v13 review 1 (Brenas re-partitioned, Dapalle enlarged)',font=f,fill=(0,0,0),anchor='mm')
im.save('versions/v13/previews/before_after_review1_brenas.png'); print('ok')
