import numpy as np
from scipy.ndimage import map_coordinates
def perlin(shape,res,rng):
    """gradient noise on shape (H,W) with res=(ry,rx) cells (any ints); returns approx [-1,1]"""
    H,W=shape; ry,rx=res
    ang=rng.uniform(0,2*np.pi,(ry+1,rx+1)); gx,gy=np.cos(ang),np.sin(ang)
    y=np.linspace(0,ry,H,endpoint=False); x=np.linspace(0,rx,W,endpoint=False)
    Y,X=np.meshgrid(y,x,indexing='ij'); yi=Y.astype(int); xi=X.astype(int); fy=Y-yi; fx=X-xi
    def dot(oy,ox): return gx[yi+oy,xi+ox]*(fx-ox)+gy[yi+oy,xi+ox]*(fy-oy)
    fade=lambda t:t*t*t*(t*(t*6-15)+10)
    u=fade(fx); v=fade(fy)
    n00=dot(0,0);n10=dot(0,1);n01=dot(1,0);n11=dot(1,1)
    return ((n00*(1-u)+n10*u)*(1-v)+(n01*(1-u)+n11*u)*v)*1.41
def fbm(shape,base,octaves,rng,gain=0.5,lac=2):
    H,W=shape; out=np.zeros(shape); amp=1; tot=0; r=base
    for o in range(octaves):
        out+=amp*perlin(shape,(max(1,int(round(r*H/W))),int(round(r))),rng); tot+=amp; amp*=gain; r*=lac
    return out/tot
def ridged(shape,base,octaves,rng,gain=0.55,lac=2.03,warp=None,aniso=1.0):
    H,W=shape; out=np.zeros(shape); amp=1; tot=0; r=base; prev=np.ones(shape)
    for o in range(octaves):
        an=aniso if o<3 else 1.0
        n=perlin(shape,(max(1,int(round(r*H/W*an))),max(1,int(round(r/an)))),rng)
        if warp is not None: n=map_coordinates(n,warp,order=1,mode='reflect')
        rr=(1-np.abs(n))**2
        out+=amp*rr*np.clip(prev*1.4,0,1); prev=rr; tot+=amp; amp*=gain; r*=lac
    return out/tot
