"""svgcrop.py in.svg out.png x y w h outw"""
import sys,re,cairosvg
a=sys.argv; x,y,w,h,ow=map(float,a[3:8])
s=open(a[1]).read()
s=re.sub(r'viewBox="[^"]*"',f'viewBox="{x} {y} {w} {h}"',s,count=1)
s=re.sub(r'(<svg[^>]*?)\swidth="[^"]*"',rf'\1 width="{ow}"',s,count=1); s=re.sub(r'(<svg[^>]*?)\sheight="[^"]*"',rf'\1 height="{ow*h/w}"',s,count=1)
cairosvg.svg2png(bytestring=s.encode(),write_to=a[2],output_width=int(ow),output_height=int(ow*h/w))
