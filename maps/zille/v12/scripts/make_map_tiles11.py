"""v10 deliverable: cut the main map (no province overlay) into a 3x2 grid of 4096x4096 tiles + full composite (PNG native + SVG viewBox crops)."""
import cairosvg, re, os
from PIL import Image
Image.MAX_IMAGE_PIXELS=None
import sys
SRC=sys.argv[1] if len(sys.argv)>1 else 'work/v11base/zille_vector.svg'; OUT=sys.argv[2] if len(sys.argv)>2 else 'versions/v11/map'; os.makedirs(OUT,exist_ok=True)
svg=open(SRC).read()
# full composite
open(f'{OUT}/T_Map_Zille_Full_Composite.svg','w').write(svg)
cairosvg.svg2png(bytestring=svg.encode(),write_to='work/full_native.png',output_width=12288,output_height=8192)
full=Image.open('work/full_native.png').convert('RGB'); assert full.size==(12288,8192)
full.save(f'{OUT}/T_Map_Zille_Full_Composite.png',optimize=True)
hdr=re.search(r'<svg[^>]*>',svg).group(0)
k=1
for r in range(2):
    for c in range(3):
        x,y=c*4096,r*4096; name=f'T_Map_Zille_{k:02d}'
        h2=re.sub(r'width="[^"]*"','width="4096"',hdr,count=1); h2=re.sub(r'height="[^"]*"','height="4096"',h2,1)
        h2=re.sub(r'viewBox="[^"]*"',f'viewBox="{x} {y} 4096 4096"',h2,count=1)
        open(f'{OUT}/{name}.svg','w').write(svg.replace(hdr,h2,1))
        full.crop((x,y,x+4096,y+4096)).save(f'{OUT}/{name}.png',optimize=True)
        print(name,'x',x,'y',y); k+=1
