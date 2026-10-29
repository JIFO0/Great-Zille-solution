"""v6 (same as v5 build, cities from cities6.pkl) = v4 + bigger cities, Kratsna roads, Wehlen south roads, resorts, Rotsla island towns.
usage: python3 v5_build.py out.svg [--nocities]"""
import numpy as np, pickle, sys, re, os
from shapely.geometry import LineString
OUT=sys.argv[1]
def f(v): return ('%.1f'%v).rstrip('0').rstrip('.')
def cr_open(P):
    n=len(P); d=['M%s,%s'%(f(P[0,0]),f(P[0,1]))]
    for i in range(n-1):
        p0=P[max(i-1,0)];p1=P[i];p2=P[i+1];p3=P[min(i+2,n-1)]
        c1=p1+(p2-p0)/6; c2=p2-(p3-p1)/6
        d.append('C%s,%s %s,%s %s,%s'%(f(c1[0]),f(c1[1]),f(c2[0]),f(c2[1]),f(p2[0]),f(p2[1])))
    return ''.join(d)
svg=open('versions/v4/zille_vector.svg').read()
# drop v4 city layers (rebuilt by cities5.py)
for gid in ['urban_areas','city_markers','labels']:
    a=svg.index(f'<g id="{gid}"')
    # find matching close by depth
    i=a; depth=0
    for m in re.finditer(r'<g\b|</g>',svg[a:]):
        depth+=1 if m.group(0)=='<g' else -1
        if depth==0: b=a+m.end(); break
    svg=svg[:a]+svg[b:].lstrip('\n')
# topography from the v5 heightmap
topo=open('work/topo5_group.svg').read()
a=svg.index('<g id="topography"'); b=svg.index('<g id="rivers"'); svg=svg[:a]+topo+'\n'+svg[b:]
# new roads
NEW=pickle.load(open('work/roads5.pkl','rb')); nn=0
cas=[];fil=[];mino=[]
for n,k,r in NEW:
    q=np.asarray(LineString(r).simplify(1.5).coords); nn+=len(q); d=cr_open(q)
    if k=='double': cas.append(f'<path id="{n}_casing" d="{d}"/>'); fil.append(f'<path id="{n}" d="{d}"/>')
    else: mino.append(f'<path id="{n}" d="{d}"/>')
print('new road nodes',nn)
tag='<g id="roads_double_casing" stroke="#000000" stroke-width="17">'
svg=svg.replace(tag,tag+'\n'+'\n'.join(cas),1)
j=svg.index('<g id="roads_double_fill"'); k=svg.index('</g>',j); svg=svg[:k]+'\n'+'\n'.join(fil)+'\n'+svg[k:]
j=svg.index('<g id="roads_minor"'); k=svg.index('</g>',j); svg=svg[:k]+'\n'+'\n'.join(mino)+'\n'+svg[k:]
if os.path.exists('work/cities6.pkl') and '--nocities' not in sys.argv:
    C=pickle.load(open('work/cities6.pkl','rb'))
    i=svg.index('<g id="rivers"'); svg=svg[:i]+C['urban']+'\n'+svg[i:]
    i=svg.index('<g id="frame"'); svg=svg[:i]+C['markers']+'\n'+C['labels']+'\n'+svg[i:]
open(OUT,'w').write(svg); print('wrote',OUT,os.path.getsize(OUT))
