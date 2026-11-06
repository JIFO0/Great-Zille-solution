import re, numpy as np
from shapely.geometry import LineString
s_cache={}
def load(path='work/v11base/zille_vector.svg'):
    if path not in s_cache: s_cache[path]=open(path).read()
    return s_cache[path]
def group(gid,s=None):
    s=s or load()
    i=s.find(f'<g id="{gid}"'); k=i; depth=0
    if i<0: return ''
    while True:
        a=s.find('<g',k+1); b=s.find('</g>',k+1)
        if a!=-1 and a<b: depth+=1; k=a
        else:
            if depth==0: return s[i:b+4]
            depth-=1; k=b
def bez(p0,p1,p2,p3,n=12):
    t=np.linspace(0,1,n+1)[1:,None]
    return ((1-t)**3*p0+3*(1-t)**2*t*p1+3*(1-t)*t**2*p2+t**3*p3)
def parse(d):
    tok=re.findall(r'[MCZLmclz]|-?\d*\.?\d+(?:e-?\d+)?',d); i=0; lines=[]; cur=[]; cmd=None
    while i<len(tok):
        t=tok[i]
        if t in 'MCZL': cmd=t; i+=1
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
def layer_lines(gid,s=None):
    g=group(gid,s); out=[]
    for m in re.finditer(r'<path([^>]*)/?>',g):
        a=m.group(1); d=re.search(r' d="([^"]+)"',a)
        if not d: continue
        pid=re.search(r'id="([^"]+)"',a)
        for ln in parse(d.group(1)): out.append((pid.group(1) if pid else None,ln))
    return out
