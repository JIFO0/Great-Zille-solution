#!/usr/bin/env python3
"""Great Zille mod logo generator (hand-built vector SVG).

Shape source: /workspace/zille/versions/v14
  * land coastline  = `land_fill` path of map/T_Map_Zille_Full_Composite.svg
  * Zille / Brenas split = union of the v14 land province polygons (regions/*.svg,
    region field of regions/provinces_manifest.json)
Run:  python3 gen.py      -> great_zille_logo.svg, great_zille_logo_ribbon.svg (+ _paths)
"""
import json, math, re, random, pickle, os
from shapely.geometry import Polygon, MultiPolygon, Point, LineString, box
from shapely.ops import unary_union
from shapely import affinity

HERE = os.path.dirname(os.path.abspath(__file__))
V14 = os.environ.get('GZ_V14_DIR', os.path.join(HERE, '..', '..', 'maps', 'zille', 'v14')) + os.sep   # only read when geom_cache.pkl is missing
CX, CY = 512.0, 532.0          # medallion centre (v1 framing - keep)
R_DISK = 334.0                 # field radius (v1 map window - keep)
R_RING_IN, R_RING_OUT = 330.0, 388.0
SEA_STYLE = os.environ.get('SEA', 'bronze')   # bronze | teal

# ---------------------------------------------------------------- palette
NAVY = '#14213D'; NAVY_D = '#0B1427'; NAVY_L = '#22345C'
G_HI = '#F7DD8E'; G_MID = '#D9A93E'; G_LO = '#A87822'; G_DK = '#6B4A12'
LINE = '#4A320B'
ORANGE = '#E8641B'; ORANGE_HI = '#FFB04A'; RED_D = '#9E2A0B'
WHITE = '#FFFFFF'

# ---------------------------------------------------------------- geometry from v14
def load_geometry():
    cache = os.path.join(HERE, 'geom_cache.pkl')
    if os.path.exists(cache):
        return pickle.load(open(cache, 'rb'))
    s = open(V14 + 'map/T_Map_Zille_Full_Composite.svg').read()
    d = re.search(r'<path id="land_fill"[^>]*d="([^"]+)"', s).group(1)
    land = None
    for sub in d.split('M')[1:]:
        nums = [float(x) for x in re.findall(r'-?[\d.]+', sub)]
        pts = [(nums[0], nums[1])] + [(nums[i + 4], nums[i + 5]) for i in range(2, len(nums) - 5, 6)]
        if len(pts) < 3: continue
        p = Polygon(pts).buffer(0)
        land = p if land is None else land.symmetric_difference(p)   # evenodd
    M = json.load(open(V14 + 'regions/provinces_manifest.json'))['provinces']
    k = 980 / 512
    def prov(p):
        t = open(V14 + 'regions/' + p['svg_file']).read()
        dd = re.search(r'<path id="%s" d="([^"]+)"' % p['id'], t).group(1)
        polys = []
        for ring in re.split(r'[Zz]', dd):
            pts = [tuple(map(float, x)) for x in re.findall(r'(-?[\d.]+),(-?[\d.]+)', ring)]
            if len(pts) >= 3:
                polys.append(Polygon([((x - 256) * k + p['tile_center_x'], (y - 256) * k + p['tile_center_y']) for x, y in pts]).buffer(0))
        return unary_union(polys)
    zprov = unary_union([prov(p) for p in M if p['region'] == 'Zille' and p['type'] == 'land'])
    # close the 60 px border gaps between provinces, then take the real coastline from land_fill
    zmask = zprov.buffer(90).buffer(-58)
    east = [g for g in land.geoms if g.bounds[0] > 6500 and g.bounds[1] > 1500 and g.area > 1e7][0]
    island = [g for g in land.geoms if g.bounds[0] > 8700 and g.bounds[2] < 9500 and g.bounds[1] > 1700 and g.area > 5e4][0]  # Manes Riuz
    zille = unary_union([east.intersection(zmask), island])
    zille = MultiPolygon([Polygon(g.exterior) for g in getattr(zille, 'geoms', [zille]) if g.area > 2e4])
    # Rizian mainland (Brenas and beyond) = rest of the eastern landmass, extended past the map frame
    W, H = 12288, 8192
    others = []
    for g in land.geoms:
        if g.area < 2e4: continue
        g2 = g.difference(zmask.buffer(40)) if g.equals(east) else g
        ext = [g2]
        for strip, mk in [(box(-1, -1, W + 1, 300), lambda b: box(b[0], -6000, b[2], 300)),
                          (box(-1, 7880, W + 1, H + 1), lambda b: box(b[0], 7880, b[2], 14000)),
                          (box(11990, -1, W + 1, H + 1), lambda b: box(11990, b[1], 18000, b[3])),
                          (box(-1, -1, 300, H + 1), lambda b: box(-6000, b[1], 300, b[3]))]:
            cut = g2.intersection(strip)
            for c in getattr(cut, 'geoms', [cut]):
                if not c.is_empty and c.area > 50: ext.append(mk(c.bounds))
        others.append(unary_union(ext))
    main = unary_union(others)
    main = unary_union([main, box(7606, 7900, 15000, 14000), box(12020, 4399, 18000, 14000)])
    zc = [p for p in M if p['id'] == 'ZilleTile_35'][0]
    cities = {p['city_name']: (p['centroid_x'], p['centroid_y']) for p in M if p['is_city'] and p['region'] in ('Zille', 'Brenas')}
    out = dict(zille=zille, main=main, zcity=(zc['centroid_x'], zc['centroid_y']), cities=cities)
    pickle.dump(out, open(cache, 'wb'))
    return out

G = load_geometry()
S = 0.0850                                   # map px -> logo px  (v1 framing, approved by the user - keep)
ZX, ZY = G['zcity']                          # sword axis = Zille City centroid (province 35)
ZB = G['zille'].bounds
YMID = (ZB[1] + ZB[3]) / 2
OFFY = 40
def T(x, y):
    return (CX + (x - ZX) * S, CY + OFFY + (y - YMID) * S)
def to_logo(g):
    return affinity.affine_transform(g, [S, 0, 0, S, CX - ZX * S, CY + OFFY - YMID * S])

disk = Point(CX, CY).buffer(R_DISK + 4, 256)
zille = to_logo(G['zille']).simplify(0.55).intersection(disk)
main = to_logo(G['main']).simplify(0.7).intersection(Point(CX, CY).buffer(R_DISK + 2, 256))
main = main.difference(zille.buffer(3.4))          # thin sea-coloured channel = Zille/Brenas border
main = unary_union([g for g in getattr(main, 'geoms', [main]) if g.area > 30])
IMPACT = T(ZX, ZY)

def f(v): return ('%.1f' % v).rstrip('0').rstrip('.')
def ring_d(coords):
    c = list(coords)
    return 'M' + ' L'.join('%s,%s' % (f(x), f(y)) for x, y in c[:-1]) + 'Z'
def geom_d(g):
    out = []
    for p in getattr(g, 'geoms', [g]):
        if p.geom_type != 'Polygon' or p.is_empty: continue
        out.append(ring_d(p.exterior.coords))
        for h in p.interiors: out.append(ring_d(h.coords))
    return ' '.join(out)
def npts(g): return sum(len(p.exterior.coords) for p in getattr(g, 'geoms', [g]) if p.geom_type == 'Polygon')

# ---------------------------------------------------------------- helpers
def catmull(pts, closed=True):
    """Catmull-Rom through pts -> cubic bezier path data."""
    n = len(pts); d = 'M%s,%s' % (f(pts[0][0]), f(pts[0][1]))
    rng = range(n) if closed else range(n - 1)
    for i in rng:
        p0 = pts[(i - 1) % n] if closed or i > 0 else pts[i]
        p1 = pts[i]; p2 = pts[(i + 1) % n]
        p3 = pts[(i + 2) % n] if closed or i + 2 < n else p2
        c1 = (p1[0] + (p2[0] - p0[0]) / 6, p1[1] + (p2[1] - p0[1]) / 6)
        c2 = (p2[0] - (p3[0] - p1[0]) / 6, p2[1] - (p3[1] - p1[1]) / 6)
        d += ' C%s,%s %s,%s %s,%s' % tuple(f(v) for v in (*c1, *c2, *p2))
    return d + ('Z' if closed else '')

def oak_leaf(L, W, lobes=3):
    """Symmetric oak leaf, base (0,0), tip (0,-L). Returns outline d and vein d."""
    right = [(2.2, 0)]
    stem = 0.10
    n = lobes
    for i in range(n):
        t0 = stem + (1 - stem) * i / n
        t1 = stem + (1 - stem) * (i + 0.55) / n
        env = math.sin(math.pi * min(1, (t1 - stem) / (1 - stem) * 0.95 + 0.08)) ** 0.7
        right.append((W * 0.38 * env + 1.5, -L * t0 - L * 0.02))     # sinus
        right.append((W * env, -L * t1))                               # lobe tip
    right.append((0, -L))
    left = [(-x, y) for x, y in reversed(right[1:-1])]
    pts = [(0, 6)] + right[:] + left + [(-2.2, 0)]
    outline = catmull(pts)
    veins = 'M0,4 L0,%s' % f(-L * 0.93)
    for x, y in right[2:-1:2]:
        veins += ' M0,%s L%s,%s M0,%s L%s,%s' % (f(y + L * 0.10), f(x * 0.72), f(y + L * 0.01), f(y + L * 0.10), f(-x * 0.72), f(y + L * 0.01))
    return outline, veins

def lens(L, W):
    return 'M0,0 C%s,%s %s,%s 0,%s C%s,%s %s,%s 0,0Z' % (f(W), f(-L * 0.25), f(W * 0.8), f(-L * 0.7), f(-L), f(-W * 0.8), f(-L * 0.7), f(-W), f(-L * 0.25))

def polar(r, a):
    return CX + r * math.cos(math.radians(a)), CY + r * math.sin(math.radians(a))

# ======================================================================= v2 parts
# palette v2: gold dominant, navy only as accent
DARK = '#3A2508'            # outline brown
if SEA_STYLE == 'teal':
    SEA_IN, SEA_OUT, GRID = '#2C4148', '#162328', '#3D555C'
    LAND, LAND_LINE = '#6F6446', '#A08A58'
else:
    SEA_IN, SEA_OUT, GRID = '#4B3620', '#24180B', '#5E4629'
    LAND, LAND_LINE = '#8A6D3D', '#B99558'

def bez(p0, p1, p2, p3, t):
    u = 1 - t
    return (u**3*p0[0] + 3*u*u*t*p1[0] + 3*u*t*t*p2[0] + t**3*p3[0],
            u**3*p0[1] + 3*u*u*t*p1[1] + 3*u*t*t*p2[1] + t**3*p3[1])

def spine_leaf(p0, p1, p2, p3, width, lobes=0, depth=0.38, bias=0.0, n=48, base=0.06, shape=0.75):
    """Leaf built around a cubic-bezier midrib. Returns (outline d, midrib+veins d)."""
    L, R, sp = [], [], []
    for i in range(n + 1):
        t = i / n
        p = bez(p0, p1, p2, p3, t)
        q = bez(p0, p1, p2, p3, min(1, t + 0.01)); r_ = bez(p0, p1, p2, p3, max(0, t - 0.01))
        dx, dy = q[0] - r_[0], q[1] - r_[1]; dl = math.hypot(dx, dy) or 1
        nx, ny = -dy / dl, dx / dl
        env = math.sin(math.pi * min(1, t * 0.97 + 0.03)) ** shape
        w = width * (base + (1 - base) * env)
        if lobes:
            w *= 1 - depth * (0.5 + 0.5 * math.cos(2 * math.pi * lobes * t)) ** 4
        L.append((p[0] + nx * w * (1 + bias), p[1] + ny * w * (1 + bias)))
        R.append((p[0] - nx * w * (1 - bias), p[1] - ny * w * (1 - bias)))
        sp.append(p)
    pts = L + R[::-1][1:-1]
    veins = catmull(sp[:int(n * 0.9)], closed=False)
    if lobes:
        for k in range(lobes):
            t = (k + 0.5) / lobes
            if t > 0.9: continue
            i = int(t * n); j = max(0, i - 3)
            a = sp[j]
            veins += ' M%s,%s L%s,%s M%s,%s L%s,%s' % (f(a[0]), f(a[1]), f(sp[i][0] * 0.3 + L[i][0] * 0.7), f(sp[i][1] * 0.3 + L[i][1] * 0.7),
                                                       f(a[0]), f(a[1]), f(sp[i][0] * 0.3 + R[i][0] * 0.7), f(sp[i][1] * 0.3 + R[i][1] * 0.7))
    return catmull(pts), veins

def mirror_pts(pts): return [(2 * CX - x, y) for x, y in pts]
MIRROR = f'translate({2*CX},0) scale(-1,1)'

def leaf_svg(d, v, fill='url(#gGold)', sw=2.6, vw=1.5):
    return f'<path d="{d}" fill="{fill}" stroke="{DARK}" stroke-width="{sw}" stroke-linejoin="round"/><path d="{v}" fill="none" stroke="{G_DK}" stroke-width="{vw}" stroke-linecap="round" opacity="0.9"/>'

def defs():
    return f'''<defs>
  <linearGradient id="gGold" x1="0" y1="0" x2="0" y2="1"><stop offset="0" stop-color="{G_HI}"/><stop offset="0.55" stop-color="{G_MID}"/><stop offset="1" stop-color="{G_LO}"/></linearGradient>
  <linearGradient id="gGoldD" x1="0" y1="0" x2="0" y2="1"><stop offset="0" stop-color="#E2B44C"/><stop offset="1" stop-color="#94661A"/></linearGradient>
  <linearGradient id="gRing" gradientUnits="userSpaceOnUse" x1="0" y1="{CY-R_RING_OUT}" x2="0" y2="{CY+R_RING_OUT}"><stop offset="0" stop-color="#FBE6A2"/><stop offset="0.45" stop-color="{G_MID}"/><stop offset="1" stop-color="#94661A"/></linearGradient>
  <linearGradient id="gRingIn" gradientUnits="userSpaceOnUse" x1="0" y1="{CY+R_RING_OUT}" x2="0" y2="{CY-R_RING_OUT}"><stop offset="0" stop-color="#F3D27E"/><stop offset="1" stop-color="#A27420"/></linearGradient>
  <linearGradient id="gMap" gradientUnits="userSpaceOnUse" x1="0" y1="{f(CY-200)}" x2="0" y2="{f(CY+290)}"><stop offset="0" stop-color="#FCF0CC"/><stop offset="0.6" stop-color="#F1D995"/><stop offset="1" stop-color="#E2BE6C"/></linearGradient>
  <linearGradient id="gBladeL" gradientUnits="userSpaceOnUse" x1="0" y1="330" x2="0" y2="800"><stop offset="0" stop-color="#FFEFB0"/><stop offset="1" stop-color="#F0C55A"/></linearGradient>
  <linearGradient id="gBladeR" gradientUnits="userSpaceOnUse" x1="0" y1="330" x2="0" y2="800"><stop offset="0" stop-color="#D9A23A"/><stop offset="1" stop-color="#A9741E"/></linearGradient>
  <linearGradient id="gHilt" x1="0" y1="0" x2="1" y2="0"><stop offset="0" stop-color="#FCE49A"/><stop offset="0.5" stop-color="#DDA941"/><stop offset="1" stop-color="#9A6B1C"/></linearGradient>
  <linearGradient id="gVelvet" x1="0" y1="0" x2="0" y2="1"><stop offset="0" stop-color="#C2391A"/><stop offset="1" stop-color="#6E1A05"/></linearGradient>
  <radialGradient id="gJewel" cx="0.38" cy="0.32" r="0.75"><stop offset="0" stop-color="#5C7BB8"/><stop offset="0.5" stop-color="#1E3566"/><stop offset="1" stop-color="#0B1427"/></radialGradient>
  <radialGradient id="gField" cx="{CX}" cy="{CY-80}" r="{R_DISK+60}" gradientUnits="userSpaceOnUse"><stop offset="0" stop-color="{SEA_IN}"/><stop offset="1" stop-color="{SEA_OUT}"/></radialGradient>
  <radialGradient id="gGlow" cx="{f(IMPACT[0])}" cy="{f(IMPACT[1])}" r="95" gradientUnits="userSpaceOnUse"><stop offset="0" stop-color="{ORANGE_HI}" stop-opacity="0.95"/><stop offset="0.3" stop-color="{ORANGE}" stop-opacity="0.5"/><stop offset="1" stop-color="{ORANGE}" stop-opacity="0"/></radialGradient>
  <clipPath id="cDisk"><circle cx="{CX}" cy="{CY}" r="{R_DISK}"/></clipPath>
  <clipPath id="cLand"><path d="{geom_d(zille)}"/></clipPath>
  <filter id="fGlow" x="-20%" y="-20%" width="140%" height="140%"><feGaussianBlur stdDeviation="2.6"/></filter>
  <filter id="fShadow" x="-30%" y="-10%" width="160%" height="120%"><feGaussianBlur stdDeviation="3.5"/></filter>
</defs>'''

def field():
    grid = []
    for k in range(-6, 7):
        x = CX + k * 56; y = CY + k * 56
        grid.append(f'M{f(x)},{CY-R_DISK} V{CY+R_DISK} M{CX-R_DISK},{f(y)} H{CX+R_DISK}')
    return f'''<g id="field">
  <circle cx="{CX}" cy="{CY}" r="{R_DISK+2}" fill="url(#gField)"/>
  <path clip-path="url(#cDisk)" d="{' '.join(grid)}" stroke="{GRID}" stroke-width="1.2" fill="none" opacity="0.7"/>
</g>'''

def mapgroup():
    zd, md = geom_d(zille), geom_d(main)
    cities = ''
    for name, (x, y) in G['cities'].items():
        if name not in ('Munat', 'Nanta', 'Isor', 'Wiktrany'): continue
        px, py = T(x, y)
        cities += f'<circle cx="{f(px)}" cy="{f(py)}" r="3.6" fill="{G_LO}" stroke="{DARK}" stroke-width="1.4"/>'
    return f'''<g id="map">
  <g id="surrounding_land" clip-path="url(#cDisk)"><path d="{md}" fill="{LAND}" stroke="{LAND_LINE}" stroke-width="1.5" stroke-linejoin="round"/></g>
  <g id="zille_shadow" clip-path="url(#cDisk)"><path d="{zd}" transform="translate(0,7)" fill="#160E04" opacity="0.6"/></g>
  <path id="zille" d="{zd}" fill="url(#gMap)" stroke="{DARK}" stroke-width="2.6" stroke-linejoin="round"/>
  <g id="cities">{cities}</g>
</g>'''

def cracks():
    rnd = random.Random(7)
    ix, iy = IMPACT
    spec = [(-150, 150), (-112, 200), (-60, 210), (-22, 165), (18, 140), (70, 105), (128, 120), (178, 120)]
    polys = []
    def crack(x, y, ang, length, w0, depth):
        pts = [(x, y)]; seg = 3 + depth; cur = ang
        for i in range(seg):
            cur += rnd.uniform(-32, 32) if i else rnd.uniform(-8, 8)
            l = length / seg * rnd.uniform(0.8, 1.2)
            x += l * math.cos(math.radians(cur)); y += l * math.sin(math.radians(cur))
            pts.append((x, y))
        n = len(pts); ws = [w0 * (1 - i / (n - 1)) ** 0.8 for i in range(n)]
        L_, R_ = [], []
        for i in range(n):
            segs = []
            if i > 0: segs.append((pts[i][0] - pts[i-1][0], pts[i][1] - pts[i-1][1]))
            if i < n - 1: segs.append((pts[i+1][0] - pts[i][0], pts[i+1][1] - pts[i][1]))
            nx = sum(-dy / math.hypot(dx, dy) for dx, dy in segs); ny = sum(dx / math.hypot(dx, dy) for dx, dy in segs)
            nl = math.hypot(nx, ny) or 1; nx, ny = nx / nl, ny / nl
            L_.append((pts[i][0] + nx * ws[i], pts[i][1] + ny * ws[i])); R_.append((pts[i][0] - nx * ws[i], pts[i][1] - ny * ws[i]))
        polys.append(Polygon(L_ + R_[::-1]).buffer(0))
        if depth == 0:
            for i in (1, 2):
                if i < n - 1 and rnd.random() < 0.4:
                    crack(pts[i][0], pts[i][1], math.degrees(math.atan2(pts[i+1][1]-pts[i][1], pts[i+1][0]-pts[i][0])) + rnd.choice([-1, 1]) * rnd.uniform(28, 50), length * 0.4, ws[i] * 0.75, 1)
    for a, l in spec:
        crack(ix, iy, a, l, 4.8, 0)
    g = unary_union(polys).intersection(zille.buffer(-1.5))
    core = unary_union(polys).buffer(-1.3).intersection(zille.buffer(-1.5))
    d, dc = geom_d(g), geom_d(core)
    return f'''<g id="impact">
  <circle cx="{f(ix)}" cy="{f(iy)}" r="95" fill="url(#gGlow)" clip-path="url(#cLand)"/>
  <path d="{d}" fill="{ORANGE}" stroke="{ORANGE}" stroke-width="5" stroke-linejoin="round" filter="url(#fGlow)" opacity="0.85" clip-path="url(#cLand)"/>
  <path d="{d}" fill="{RED_D}"/>
  <path d="{dc}" fill="#FFE7A3"/>
</g>'''

# ---------------------------------------------------------------- golden sword (concept-4 style)
SW = dict(fin=199, pom0=205, pom1=247, grip0=253, grip1=314, guard=326)
def sword():
    x = CX; ix, iy = IMPACT
    btop = SW['guard'] + 12
    tip = iy                         # point lands exactly on Zille City (province 35 centroid)
    hw0, hw1 = 27.0, 23.0           # half widths at guard and where the point starts
    pstart = tip - 62
    # blade outline (pointed)
    def side(sg):
        return [(x + sg * hw0, btop), (x + sg * hw1, pstart)] + [(x + sg * hw1 * (1 - t) ** 0.85, pstart + (tip - pstart) * t) for t in (0.25, 0.5, 0.75)]
    Lp, Rp = side(-1), side(1)
    blade_l = 'M' + ' L'.join(f'{f(a)},{f(b)}' for a, b in [(x, btop)] + Lp + [(x, tip)]) + 'Z'
    blade_r = 'M' + ' L'.join(f'{f(a)},{f(b)}' for a, b in [(x, btop)] + Rp + [(x, tip)]) + 'Z'
    blade_o = 'M' + ' L'.join(f'{f(a)},{f(b)}' for a, b in Lp + [(x, tip)] + Rp[::-1]) + 'Z'
    # bevel lines (inset edges) + central fuller ridge
    inset = 6.5
    bev = ''
    for sg in (-1, 1):
        bev += f'M{f(x+sg*(hw0-inset))},{btop+6} L{f(x+sg*(hw1-inset+0.5))},{f(pstart)} L{f(x)},{f(tip-12)} '
    fuller = f'M{f(x-4)},{btop+18} L{f(x-3)},{f(pstart-30)} L{f(x)},{f(pstart-14)} L{f(x+3)},{f(pstart-30)} L{f(x+4)},{btop+18} L{f(x)},{btop+10}Z'
    # grip (cross-hatched)
    g0, g1 = SW['grip0'], SW['grip1']
    grip = f'M{f(x-11)},{g0} C{f(x-14)},{f((g0+g1)/2)} {f(x-14)},{f((g0+g1)/2)} {f(x-12)},{g1} L{f(x+12)},{g1} C{f(x+14)},{f((g0+g1)/2)} {f(x+14)},{f((g0+g1)/2)} {f(x+11)},{g0}Z'
    hatch = ''.join(f'M{f(x-16)},{f(y)} L{f(x+16)},{f(y+14)} M{f(x+16)},{f(y)} L{f(x-16)},{f(y+14)} ' for y in range(g0 - 10, g1 + 4, 9))
    # pommel: finial + faceted pear + collar
    p0, p1 = SW['pom0'], SW['pom1']; pm = (p0 + p1) / 2
    pommel = (f'M{f(x)},{p0} C{f(x+17)},{p0} {f(x+26)},{f(pm-4)} {f(x+22)},{f(pm+6)} C{f(x+18)},{f(p1-2)} {f(x+7)},{p1} {f(x)},{p1} '
              f'C{f(x-7)},{p1} {f(x-18)},{f(p1-2)} {f(x-22)},{f(pm+6)} C{f(x-26)},{f(pm-4)} {f(x-17)},{p0} {f(x)},{p0}Z')
    collar = f'M{f(x-14)},{p1-1} L{f(x+14)},{p1-1} L{f(x+11)},{g0+1} L{f(x-11)},{g0+1}Z'
    # crossguard with curled (scroll) ends, right half mirrored
    q = SW['guard']
    rh = [(0, q - 12), (30, q - 10), (62, q - 11), (88, q - 16), (104, q - 26), (114, q - 30), (122, q - 24), (122, q - 14), (114, q - 9), (106, q - 13), (108, q - 19), (100, q - 12), (86, q - 2), (60, q + 6), (30, q + 8), (0, q + 10)]
    gp = [(x + a, b) for a, b in rh] + [(x - a, b) for a, b in reversed(rh[1:-1])]
    guard = catmull(gp)
    guard_line = f'M{f(x-96)},{q-8} Q{f(x)},{q-2} {f(x+96)},{q-8}'
    # central medallion (lozenge) on the guard
    med = f'M{f(x)},{q-26} L{f(x+22)},{q} L{f(x)},{q+30} L{f(x-22)},{q}Z'
    shadow_d = blade_o + ' ' + guard + ' ' + grip + ' ' + pommel
    return f'''<g id="sword" stroke-linejoin="round">
  <path id="sword_shadow" d="{shadow_d}" transform="translate(6,7)" fill="#1B1004" opacity="0.55" filter="url(#fShadow)"/>
  <g id="blade">
    <path d="{blade_l}" fill="url(#gBladeL)"/><path d="{blade_r}" fill="url(#gBladeR)"/>
    <path d="{bev}" fill="none" stroke="#8C5E15" stroke-width="1.4" opacity="0.8"/>
    <path d="{fuller}" fill="#A87420" stroke="#6E4810" stroke-width="1.1"/>
    <path d="{blade_o}" fill="none" stroke="{DARK}" stroke-width="3"/>
  </g>
  <g id="glint" transform="translate({f(ix)},{f(iy)})">
    <path d="M0,-30 L4,-4 L30,0 L4,4 L0,30 L-4,4 L-30,0 L-4,-4Z" fill="#FFF4C8" opacity="0.95"/>
    <circle r="6" fill="#FFFFFF"/>
  </g>
  <g id="hilt">
    <path d="{grip}" fill="url(#gHilt)" stroke="{DARK}" stroke-width="2.6"/>
    <path d="{hatch}" stroke="#7A5212" stroke-width="2" clip-path="url(#cGrip)" fill="none"/>
    <path d="{collar}" fill="url(#gHilt)" stroke="{DARK}" stroke-width="2.2"/>
    <path d="{pommel}" fill="url(#gHilt)" stroke="{DARK}" stroke-width="2.6"/>
    <path d="M{f(x)},{p0+5} L{f(x)},{p1-4} M{f(x-11)},{f(pm)} Q{f(x)},{f(pm+5)} {f(x+11)},{f(pm)}" stroke="#8C5E15" stroke-width="1.4" fill="none"/>
    <circle cx="{f(x)}" cy="{SW['fin']}" r="6.5" fill="url(#gHilt)" stroke="{DARK}" stroke-width="2.2"/>
    <path d="{guard}" fill="url(#gGold)" stroke="{DARK}" stroke-width="2.8"/>
    <path d="{guard_line}" stroke="#8C5E15" stroke-width="1.4" fill="none"/>
    <path d="{med}" fill="url(#gGoldD)" stroke="{DARK}" stroke-width="2.6"/>
    <ellipse cx="{f(x)}" cy="{q+1}" rx="8" ry="10" fill="{ORANGE}" stroke="{DARK}" stroke-width="2"/>
    <ellipse cx="{f(x-2.5)}" cy="{q-3}" rx="2.4" ry="3" fill="{WHITE}" opacity="0.85"/>
  </g>
</g>''', grip

# ---------------------------------------------------------------- foliate crown (v4: traced from concept 4)
def spath(pts, closed=True):
    """Smooth path through pts; a point given as (x, y, 1) is a sharp corner (leaf tip / notch)."""
    P = [(p[0], p[1]) for p in pts]; sharp = [p[2] if len(p) > 2 else 0 for p in pts]
    n = len(P); d = 'M%s,%s' % (f(P[0][0]), f(P[0][1]))
    rng = range(n) if closed else range(n - 1)
    for i in rng:
        i2 = (i + 1) % n
        p0 = P[(i - 1) % n] if closed or i > 0 else P[i]
        p1, p2 = P[i], P[i2]
        p3 = P[(i + 2) % n] if closed or i + 2 < n else p2
        kk = lambda j: 1 / 6 if not sharp[j] else (1 / 16 if sharp[j] == 2 else 0)
        k1, k2 = kk(i), kk(i2)
        c1 = (p1[0] + (p2[0] - p0[0]) * k1, p1[1] + (p2[1] - p0[1]) * k1)
        c2 = (p2[0] - (p3[0] - p1[0]) * k2, p2[1] - (p3[1] - p1[1]) * k2)
        if sharp[i] == 1: c1 = (p1[0] + (p2[0] - p1[0]) * 0.3, p1[1] + (p2[1] - p1[1]) * 0.3)
        if sharp[i2] == 1: c2 = (p2[0] + (p1[0] - p2[0]) * 0.3, p2[1] + (p1[1] - p2[1]) * 0.3)
        d += ' C%s,%s %s,%s %s,%s' % tuple(f(v) for v in (*c1, *c2, *p2))
    return d + ('Z' if closed else '')

# Concept-4 crown, drawn in the concept image's own pixel space (x 377..647, y 4..186),
# then placed with one uniform transform. Left half drawn, right half mirrored about x=512.
CROWN_S = 0.85                 # concept px -> logo px
CROWN_Y = 190                  # logo y of the concept band top (concept y=141)
CROWN_HOLE = '#22170A'         # openings show the dark field, as the navy field does in concept 4

def crown():
    sw = lambda w: f(w / CROWN_S)
    # openings (dark field showing through), drawn first
    hole_a = [(398, 86), (410, 80), (424, 72), (434, 76), (440, 86), (452, 96), (452, 112), (440, 116), (428, 108), (418, 96), (409, 102), (402, 94)]
    hole_b = [(449, 110), (458, 100), (468, 90), (480, 84), (494, 92), (499, 108), (492, 126), (476, 134), (458, 130), (450, 120)]
    # outer tine + two flame-like serrations rising from the band
    tine = [(417, 147), (406, 137), (393, 119), (383, 96), (378, 80), (377.5, 70, 1), (392, 78), (403, 89), (409.5, 98, 1),
            (414, 93), (418.6, 90, 1), (423, 93), (428, 102), (433, 109), (437, 111, 1), (441, 106), (444, 103, 1),
            (447, 107), (450, 114), (452, 121), (457, 127), (466, 133), (470, 140), (470, 147, 1)]
    tine_vein = 'M381,77 C388,96 398,116 411,138 M419,96 C420,110 423,124 428,140 M445,108 C446,120 449,131 455,140'
    # acanthus leaf: pointed top lobe, long side lobe, hanging lobe ending in a small hook
    acan = [(504, 62), (496, 57), (486, 55), (479, 53), (473, 50), (467, 45), (462, 39, 1), (458, 44), (456, 49), (453, 55, 1),
            (446, 52), (440, 48, 2), (434, 50), (428, 49), (420, 48, 1), (427, 58), (433, 66), (436, 74), (434, 84, 1), (442, 82),
            (447, 86), (449, 94, 2), (455, 91), (459.5, 95), (460, 102), (464, 104, 1), (469, 99), (470, 93), (467, 88, 1),
            (474, 84), (484, 80), (494, 77), (504, 76)]
    acan_vein = 'M502,68 C484,64 462,58 427,52 M478,60 C472,54 467,48 463,43 M468,64 C458,68 452,74 448,80 M458,60 C450,62 438,60 426,52 M462,66 C458,76 458,88 462,98 M452,68 C446,72 440,76 437,80'
    # scroll loop rolling down from the acanthus into the band (encloses opening B)
    loop = 'M468,86 C478,82 489,85 494,94 C499,104 498,118 491,126 C484,133 472,135 461,131'
    # central lance leaf with two small side lobes
    cent_l = [(512, 3, 1), (507, 11), (501.5, 21), (498.5, 29), (496, 33, 1), (490, 33), (485.5, 34, 1), (489, 41), (492, 48),
              (496, 54.5), (503, 58), (504, 66)]
    cent = cent_l + [(1024 - p[0], p[1], *p[2:]) for p in reversed(cent_l)]
    column = 'M505,56 L519,56 L519,148 L505,148Z'
    def arcband(y0, y1, x, drop=4):
        return f'M{x},{y0 + drop} Q512,{y0 - drop} {1024 - x},{y0 + drop} L{1024 - x},{y1 + drop} Q512,{y1 - drop} {x},{y1 + drop}Z'
    rim_top = arcband(136, 143, 409)
    band = arcband(143, 166, 412)
    rim_bot = arcband(166, 174, 408)
    band_hi = 'M418,151 Q512,140 606,151'
    holes = f'<path d="{spath(hole_a)} {spath(hole_b)}" fill="{CROWN_HOLE}" stroke="{DARK}" stroke-width="{sw(2.4)}"/>'
    half = (f'<path d="{spath(tine)}" fill="url(#gGold)" stroke="{DARK}" stroke-width="{sw(2.6)}"/>'
            f'<path d="{tine_vein}" fill="none" stroke="{G_DK}" stroke-width="{sw(1.4)}" stroke-linecap="round"/>'
            f'<path d="{loop}" fill="none" stroke="{DARK}" stroke-width="{sw(9.5)}" stroke-linecap="round"/>'
            f'<path d="{loop}" fill="none" stroke="url(#gGoldD)" stroke-width="{sw(6)}" stroke-linecap="round"/>'
            f'<path d="{spath(acan)}" fill="url(#gGold)" stroke="{DARK}" stroke-width="{sw(2.6)}"/>'
            f'<path d="{acan_vein}" fill="none" stroke="{G_DK}" stroke-width="{sw(1.4)}" stroke-linecap="round"/>')
    jewels = (f'<path d="M512,60 L512,126" stroke="{DARK}" stroke-width="{sw(4.6)}"/><path d="M512,60 L512,126" stroke="#D8D2BE" stroke-width="{sw(2)}"/>')
    for jy, jr in ((60, 6.6), (99, 5.6), (126, 6.2)):
        jewels += (f'<circle cx="512" cy="{jy}" r="{f(jr + 2)}" fill="#E9E2CC" stroke="{DARK}" stroke-width="{sw(1.8)}"/>'
                   f'<circle cx="512" cy="{jy}" r="{jr}" fill="url(#gJewel)" stroke="{DARK}" stroke-width="{sw(1.3)}"/>'
                   f'<ellipse cx="{f(512 - jr * 0.35)}" cy="{f(jy - jr * 0.4)}" rx="{f(jr * 0.32)}" ry="{f(jr * 0.24)}" fill="#FFFFFF" opacity="0.85"/>')
    return f'''<g id="crown" stroke-linejoin="round" transform="translate(512,{CROWN_Y}) scale({CROWN_S}) translate(-512,-141)">
  <g id="crown_openings">{holes}<g transform="{MIRROR}">{holes}</g></g>
  <path id="crown_column" d="{column}" fill="url(#gGoldD)" stroke="{DARK}" stroke-width="{sw(2.4)}"/>
  <g id="crown_left">{half}</g><g id="crown_right" transform="{MIRROR}">{half}</g>
  <path id="crown_centre_leaf" d="{spath(cent)}" fill="url(#gGold)" stroke="{DARK}" stroke-width="{sw(2.6)}"/>
  <path d="M512,11 L512,50" stroke="{G_DK}" stroke-width="{sw(1.4)}"/>
  <g id="crown_jewels">{jewels}</g>
  <g id="crown_band">
    <path d="{band}" fill="url(#gGold)" stroke="{DARK}" stroke-width="{sw(2.6)}"/>
    <path d="{band_hi}" stroke="#FFF0BE" stroke-width="{sw(1.4)}" fill="none" opacity="0.8"/>
    <path d="{rim_top}" fill="url(#gGoldD)" stroke="{DARK}" stroke-width="{sw(2.4)}"/>
    <path d="{rim_bot}" fill="url(#gGoldD)" stroke="{DARK}" stroke-width="{sw(2.4)}"/>
  </g>
</g>'''

# ---------------------------------------------------------------- frame
def ring():
    Rm = (R_RING_IN + R_RING_OUT) / 2; w = R_RING_OUT - R_RING_IN
    return f'''<g id="ring">
  <circle cx="{CX}" cy="{CY}" r="{Rm}" fill="none" stroke="url(#gRing)" stroke-width="{w}"/>
  <circle cx="{CX}" cy="{CY}" r="{R_RING_IN + w*0.32}" fill="none" stroke="url(#gRingIn)" stroke-width="{w*0.36}" opacity="0.75"/>
  <circle cx="{CX}" cy="{CY}" r="{R_RING_OUT}" fill="none" stroke="{DARK}" stroke-width="3.2"/>
  <circle cx="{CX}" cy="{CY}" r="{R_RING_OUT-6}" fill="none" stroke="#FFF0BE" stroke-width="1.8" opacity="0.9"/>
  <circle cx="{CX}" cy="{CY}" r="{R_RING_IN + w*0.52}" fill="none" stroke="{G_DK}" stroke-width="1.6"/>
  <circle cx="{CX}" cy="{CY}" r="{R_RING_IN + w*0.52 + 2}" fill="none" stroke="#FFF0BE" stroke-width="1" opacity="0.7"/>
  <circle cx="{CX}" cy="{CY}" r="{R_RING_IN+5}" fill="none" stroke="{G_DK}" stroke-width="1.6" opacity="0.8"/>
  <circle cx="{CX}" cy="{CY}" r="{R_RING_IN}" fill="none" stroke="{DARK}" stroke-width="3.2"/>
  <circle cx="{CX}" cy="{CY}" r="{R_DISK-3}" fill="none" stroke="{NAVY}" stroke-width="2.4"/>
</g>'''

# ---------------------------------------------------------------- wreath (v4: traced from concept 4)
# Concept 4 geometry: medallion centre (512,458), ring outer radius 444, field edge ~404.
C4C = (512.0, 458.0); C4_RING = 444.0; C4_FIELD = 404.0
FOLIAGE_K = 0.70      # radial compression of the inner foliage so it hugs the ring and leaves the map readable
FOLIAGE_S = 1.2      # leaf size scale for the inner foliage

def c4(x, y, inner=True):
    """concept-4 pixel -> logo px, keeping the angle around the medallion centre."""
    dx, dy = x - C4C[0], y - C4C[1]; r = math.hypot(dx, dy); a = math.atan2(dy, dx)
    if r >= C4_FIELD or not inner:
        rr = R_RING_OUT + (r - C4_RING) * (R_RING_OUT / C4_RING)
    else:
        rr = R_RING_IN - (C4_FIELD - r) * FOLIAGE_K
    return CX + rr * math.cos(a), CY + rr * math.sin(a)

def ribbon_leaf(p0, p1, p2, p3, width, n=40, tip=1.0, base=0.10, bulge=0.38, bias=0.0):
    """Slender scimitar blade: narrow base, widest at `bulge`, needle tip."""
    L, R = [], []
    for i in range(n + 1):
        t = i / n
        p = bez(p0, p1, p2, p3, t)
        q = bez(p0, p1, p2, p3, min(1, t + 0.01)); r_ = bez(p0, p1, p2, p3, max(0, t - 0.01))
        dx, dy = q[0] - r_[0], q[1] - r_[1]; dl = math.hypot(dx, dy) or 1
        nx, ny = -dy / dl, dx / dl
        if t < bulge: env = base + (1 - base) * math.sin(math.pi / 2 * t / bulge) ** 0.8
        else: env = math.cos(math.pi / 2 * (t - bulge) / (1 - bulge)) ** (0.9 * tip)
        w = width * env
        L.append((p[0] + nx * w * (1 + bias), p[1] + ny * w * (1 + bias))); R.append((p[0] - nx * w * (1 - bias), p[1] - ny * w * (1 - bias)))
    pts = L + R[::-1][1:]
    d = 'M' + ' L'.join(f'{f(x)},{f(y)}' for x, y in pts) + 'Z'
    mid = [bez(p0, p1, p2, p3, t / 20) for t in range(2, 18)]
    v = 'M' + ' L'.join(f'{f(x)},{f(y)}' for x, y in mid)
    return d, v

def oak(p0, p1, p2, p3, width, lobes=4, depth=0.62, phase=0.0, n=0, spread=58, lobe_w=0.8):
    """Concept-4 style oak/acanthus leaf, built as a union of forward-swept pointed lobes around a
    curved midrib (shapely), with rounded sinuses. Returns outline d, veins d, polygon."""
    def M(t): return bez(p0, p1, p2, p3, t)
    def Tn(t):
        q = M(min(1, t + 0.01)); r_ = M(max(0, t - 0.01)); dx, dy = q[0] - r_[0], q[1] - r_[1]; dl = math.hypot(dx, dy) or 1
        return dx / dl, dy / dl
    def env(t): return max(0.08, math.sin(math.pi * min(1, 0.05 + 0.95 * t)) ** 0.6) * (1.0 - 0.1 * t)
    def lens(c, dvec, ln, wd):
        ux, uy = dvec; nx, ny = -uy, ux; L_, R_ = [], []
        for i in range(17):
            u = i / 16; hw = 0.5 * wd * math.sin(math.pi * min(1, 0.12 + 0.86 * u)) ** 0.55 * (1 - 0.3 * u)
            px, py = c[0] + ux * ln * u, c[1] + uy * ln * u
            L_.append((px + nx * hw, py + ny * hw)); R_.append((px - nx * hw, py - ny * hw))
        return Polygon(L_ + R_[::-1]).buffer(0)
    body_L, body_R = [], []
    for i in range(41):
        t = i / 40; m = M(t); tx, ty = Tn(t); w = width * 0.44 * env(t) * (1 - 0.4 * t)
        body_L.append((m[0] - ty * w, m[1] + tx * w)); body_R.append((m[0] + ty * w, m[1] - tx * w))
    parts = [Polygon(body_L + body_R[::-1]).buffer(0)]
    veins = 'M' + ' L'.join(f'{f(x)},{f(y)}' for x, y in (M(t / 20) for t in range(0, 19)))
    span = 0.80 / lobes
    for s_, ph in ((1, phase), (-1, phase + 0.5)):
        for k in range(lobes):
            tk = 0.12 + (k + 0.5 + ph * 0.55) * span
            if tk > 0.9: continue
            tx, ty = Tn(tk); a = math.radians(-s_ * spread * (1 - 0.35 * tk))
            dvec = (tx * math.cos(a) - ty * math.sin(a), tx * math.sin(a) + ty * math.cos(a))
            ln = width * env(tk) * 1.3; c = M(tk)
            parts.append(lens(c, dvec, ln, ln * lobe_w))
            a2 = math.radians(-s_ * (spread + 38) * (1 - 0.3 * tk)); c2 = M(max(0, tk - span * 0.25))
            d2 = (tx * math.cos(a2) - ty * math.sin(a2), tx * math.sin(a2) + ty * math.cos(a2))
            parts.append(lens(c2, d2, ln * 0.62, ln * 0.42))
            e = (c[0] + dvec[0] * ln * 0.78, c[1] + dvec[1] * ln * 0.78)
            veins += f' M{f(c[0])},{f(c[1])} L{f(e[0])},{f(e[1])}'
    tx, ty = Tn(0.97); c = M(0.82); lnT = math.hypot(M(1)[0] - c[0], M(1)[1] - c[1]) + width * 0.25
    parts.append(lens(c, (tx, ty), lnT, width * 0.55))
    poly = unary_union(parts).buffer(1.2, 8).buffer(-2.4, 8).buffer(1.2, 8)
    if poly.geom_type != 'Polygon': poly = max(poly.geoms, key=lambda g: g.area)
    poly = poly.simplify(0.25)
    d = ring_d(poly.exterior.coords)
    return d, veins, poly

def leafsvg(d, v, fill='url(#gGold)', sw=2.4, vw=1.4):
    return (f'<path d="{d}" fill="{fill}" stroke="{DARK}" stroke-width="{sw}" stroke-linejoin="round"/>'
            f'<path d="{v}" fill="none" stroke="{G_DK}" stroke-width="{vw}" stroke-linecap="round" stroke-linejoin="round" opacity="0.9"/>')

FOLIAGE_POLYS = []
# concept-4 blade fan, read off the concept image: (tip angle, tip r, base angle, base r, half width), polar about (512,458)
BLADES_OUT = [(121, 552, 102, 532, 15), (125.5, 528, 109, 506, 16), (140.6, 511, 121, 498, 17), (157, 504, 137, 491, 17),
              (175, 502, 155, 489, 17), (194, 495, 174, 487, 17), (211, 501, 191, 482, 17), (223.4, 489, 205, 470, 15),
              (237, 467, 219, 467, 13)]
BLADES_IN = [(132, 486, 112, 466, 13), (149, 476, 128, 462, 13), (166, 472, 145, 460, 13), (184, 470, 163, 458, 13),
             (202, 470, 181, 457, 13), (217, 466, 197, 455, 12), (230, 456, 211, 452, 11)]
def wreath(stems=True):
    """Concept-4 wreath: (1) a dense fan of long scimitar blades behind the ring, tips sweeping upward,
    two rows, ending in crossed stem stubs under the ring; (2) oak-leaf sprays on a curling vine
    lying over the inner edge of the ring. Left half traced, right half mirrored."""
    def cp(a, r): return c4(C4C[0] + r * math.cos(math.radians(a)), C4C[1] + r * math.sin(math.radians(a)), inner=False)
    def blade(ta, tr, ba, br, hw, fill):
        P_ = [cp(ba + (ta - ba) * t, br + (tr - br) * t + 7 * math.sin(math.pi * t)) for t in (0, 0.35, 0.7, 1.0)]
        d, v = ribbon_leaf(*P_, hw * 0.876 * 1.3, bulge=0.34, base=0.22)
        hl = ribbon_leaf(*P_, hw * 0.876 * 1.3 * 0.45, bulge=0.34, base=0.22, bias=-0.9)[0]
        return (f'<path d="{d}" fill="{fill}" stroke="{DARK}" stroke-width="2.4" stroke-linejoin="round"/>'
                f'<path d="{hl}" fill="#FBE6A2" opacity="0.45"/>'
                f'<path d="{v}" fill="none" stroke="{G_DK}" stroke-width="1.3" stroke-linecap="round" opacity="0.8"/>')
    inner = ''.join(blade(*b, 'url(#gGoldD)') for b in reversed(BLADES_IN))
    outer = ''.join(blade(*b, 'url(#gGold)') for b in reversed(BLADES_OUT))   # lower blades overlap the bases above
    s0, s1 = c4(452, 884, False), c4(402, 962, False)
    ang = math.degrees(math.atan2(s1[1] - s0[1], s1[0] - s0[0]))
    ln = math.hypot(s1[0] - s0[0], s1[1] - s0[1])
    stub = (f'<g transform="translate({f(s0[0])},{f(s0[1])}) rotate({f(ang)})">'
            f'<path d="M0,-12 L{f(ln)},-12 L{f(ln)},12 L0,12Z" fill="url(#gGoldD)" stroke="{DARK}" stroke-width="2.4"/>'
            f'<path d="M0,-6 L{f(ln - 4)},-6" stroke="#F3D27E" stroke-width="2.2" opacity="0.7"/>'
            f'<ellipse cx="{f(ln)}" cy="0" rx="5.5" ry="12" fill="#C99A3A" stroke="{DARK}" stroke-width="2.2"/></g>') if stems else ''
    back_half = stub + inner + outer
    back = f'<g id="wreath_blades"><g id="blades_left">{back_half}</g><g id="blades_right" transform="{MIRROR}">{back_half}</g></g>'

    # ---- inner oak foliage (concept coordinates, left half)
    FS = FOLIAGE_S
    def P(*xy): return c4(*xy)
    def vine_svg(pts, w):
        dd = catmull([P(*p) for p in pts], closed=False)
        return (f'<path d="{dd}" stroke="{DARK}" stroke-width="{f(w + 4.6)}" fill="none" stroke-linecap="round"/>'
                f'<path d="{dd}" stroke="url(#gGoldD)" stroke-width="{f(w)}" fill="none" stroke-linecap="round"/>'
                f'<path d="{dd}" stroke="#FBE6A2" stroke-width="{f(w * 0.28)}" fill="none" stroke-linecap="round" opacity="0.55" transform="translate(-1.2,-1.2)"/>')
    leaves = []
    def L(base, c1, c2, tip, w, lobes=4, phase=0.0, depth=0.62, fill='url(#gGold)'):
        d, v, poly = oak(P(*base), P(*c1), P(*c2), P(*tip), w * FS, lobes=lobes, phase=phase, depth=depth)
        FOLIAGE_POLYS.append(poly); leaves.append(leafsvg(d, v, fill))
    def tongue(base, c1, c2, tip, w):
        d, v, poly = oak(P(*base), P(*c1), P(*c2), P(*tip), w * FS, lobes=3, spread=34, lobe_w=0.75)
        FOLIAGE_POLYS.append(poly); leaves.append(leafsvg(d, v, 'url(#gGoldD)'))
    def curl(pts, w):
        dd = catmull([P(*p) for p in pts], closed=False)
        leaves.append(f'<path d="{dd}" stroke="{DARK}" stroke-width="{f(w + 4.6)}" fill="none" stroke-linecap="round"/>'
                      f'<path d="{dd}" stroke="url(#gGold)" stroke-width="{f(w)}" fill="none" stroke-linecap="round"/>')
    vines = vine_svg([(118, 486), (104, 530), (96, 566), (93, 602), (90, 656), (100, 700), (128, 748), (172, 790), (220, 812)], 13)
    # top group: twisting leaf + leaf pointing left over the ring + scroll horn
    # (concept 4's small scroll horn by the map edge is omitted: at this layout it collides with the crossguard)
    tongue((232, 252), (190, 262), (150, 280), (116, 302), 22)
    L((216, 236), (180, 226), (140, 212), (105, 205), 22, lobes=4, phase=0.2)
    # middle group: oak leaf rising along the ring + oak leaf hanging inward
    L((105, 478), (120, 425), (155, 378), (198, 352), 34, lobes=4, phase=0.1)
    L((184, 388), (204, 414), (220, 446), (226, 484), 25, lobes=4, phase=0.35)
    # lower group: two broad oak leaves pointing inward, curled tongue leaf, bottom oak leaf
    L((105, 662), (160, 636), (220, 600), (276, 606), 36, lobes=4, phase=0.15)
    L((186, 666), (236, 660), (280, 666), (306, 684), 30, lobes=4, phase=0.4)
    tongue((240, 700), (170, 700), (150, 770), (178, 818), 24)
    L((218, 812), (270, 800), (322, 770), (360, 723), 32, lobes=4, phase=0.25)
    half = vines + ''.join(leaves)
    front = f'<g id="oak_foliage"><g id="oak_left">{half}</g><g id="oak_right" transform="{MIRROR}">{half}</g></g>'
    return back, front

# ---------------------------------------------------------------- ribbon / text
FONT = os.environ.get('GZ_LOGO_FONT', '/usr/share/fonts/truetype/sand-box/google/Cinzel/Cinzel-VariableFont_wght.ttf')  # Cinzel (SIL OFL), variable font
_FONT_CACHE = {}
def text_path(txt, cx, baseline, size, tracking=0.08, arc_r=None):
    from fontTools.ttLib import TTFont
    from fontTools.varLib import instancer
    from fontTools.pens.svgPathPen import SVGPathPen
    from fontTools.pens.transformPen import TransformPen
    if 'f' not in _FONT_CACHE:
        _FONT_CACHE['f'] = instancer.instantiateVariableFont(TTFont(FONT), {'wght': 700})
    font = _FONT_CACHE['f']
    gs = font.getGlyphSet(); cmap = font.getBestCmap(); upm = font['head'].unitsPerEm
    sc = size / upm
    adv = [gs[cmap[ord(c)]].width * sc + size * tracking for c in txt]; adv[-1] -= size * tracking
    total = sum(adv); x = cx - total / 2; out = []
    for c, a in zip(txt, adv):
        gname = cmap[ord(c)]; w = gs[gname].width * sc; mid = x + w / 2
        if arc_r:
            ang = (mid - cx) / arc_r
            gx = cx + arc_r * math.sin(ang); gy = baseline - arc_r * (1 - math.cos(ang)); rot = -math.degrees(ang)
        else:
            gx, gy, rot = mid, baseline, 0
        pen = SVGPathPen(gs)
        gs[gname].draw(TransformPen(pen, (sc, 0, 0, -sc, -w / 2, 0)))
        d = pen.getCommands()
        if d: out.append(f'<path d="{d}" transform="translate({f(gx)},{f(gy)}) rotate({f(rot)})"/>')
        x += a
    return ''.join(out)

def ribbon(text, as_paths, size=46, tracking=0.10, w=300):
    y = CY + R_RING_OUT - 18; h = 62; R = 900
    def ay(xx): return y - (R - math.sqrt(R * R - (xx - CX) ** 2))
    xs = [CX - w + i * (2 * w) / 24 for i in range(25)]
    top = [(xx, ay(xx) - h / 2) for xx in xs]; bot = [(xx, ay(xx) + h / 2) for xx in reversed(xs)]
    main_d = 'M' + ' L'.join(f'{f(a)},{f(b)}' for a, b in top + bot) + 'Z'
    lx = CX - w; ly = ay(lx)
    tail_l = f'M{f(lx+30)},{f(ly-h/2+16)} L{f(lx-70)},{f(ly-h/2+22)} L{f(lx-42)},{f(ly+24)} L{f(lx-74)},{f(ly+h/2+22)} L{f(lx+30)},{f(ly+h/2+16)}Z'
    fold_l = f'M{f(lx)},{f(ly+h/2)} L{f(lx+30)},{f(ly+h/2+16)} L{f(lx+30)},{f(ly+h/2-6)}Z'
    base = y + size * 0.34
    if as_paths:
        txt = f'<g id="ribbon_text" fill="#FCE7A8">' + text_path(text, CX, base, size, tracking, arc_r=R) + '</g>'
    else:
        txt = (f'<defs><path id="ribbonArc" d="M{CX-w},{f(ay(CX-w)+size*0.34)} A{R},{R} 0 0 0 {CX+w},{f(ay(CX+w)+size*0.34)}"/></defs>'
               f'<text id="ribbon_text" font-family="Cinzel, \'Trajan Pro\', \'Cormorant Garamond\', Georgia, \'Times New Roman\', serif" font-weight="700" font-size="{size}" letter-spacing="{f(size*tracking)}" fill="#FCE7A8" text-anchor="middle">'
               f'<textPath href="#ribbonArc" startOffset="50%">{text}</textPath></text>')
    one = f'<path d="{tail_l}" fill="#B9520F" stroke="{DARK}" stroke-width="2.8"/><path d="{fold_l}" fill="#7A3208" stroke="{DARK}" stroke-width="2.2"/>'
    return f'''<g id="ribbon" stroke-linejoin="round">
  <g id="ribbon_tails"><g>{one}</g><g transform="{MIRROR}">{one}</g></g>
  <path d="{main_d}" fill="{ORANGE}" stroke="{DARK}" stroke-width="3"/>
  <path d="{'M' + ' L'.join(f'{f(a)},{f(b+6)}' for a, b in top)}" stroke="#FCE7A8" stroke-width="1.6" fill="none" opacity="0.85"/>
  <path d="{'M' + ' L'.join(f'{f(a)},{f(b-6)}' for a, b in bot)}" stroke="#FCE7A8" stroke-width="1.6" fill="none" opacity="0.85"/>
  {txt}
</g>'''

def build(variant='main', text=None, as_paths=True, **rk):
    sw, grip = sword()
    back, front = wreath(stems=True)
    if os.environ.get('OAK', '1') == '0': front = ''   # optional: blades only, no inner oak sprays
    grip_clip = f'<defs><clipPath id="cGrip"><path d="{grip}"/></clipPath></defs>'
    parts = [defs(), grip_clip, back, ring(), field(), mapgroup(), cracks(), front, crown(), sw]  # crown under the sword: pommel sits in front of the band as in concept 4
    if variant == 'ribbon':
        parts.append(ribbon(text, as_paths, **rk))
    title = 'Great Zille' + (f' - {text}' if text else '')
    return (f'<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 1024 1024" width="1024" height="1024">\n'
            f'<title>{title}</title>\n' + '\n'.join(parts) + '\n</svg>\n')

if __name__ == '__main__':
    print('zille pts', npts(zille), 'land pts', npts(main), 'impact', IMPACT, 'sea', SEA_STYLE)
    suffix = '' if SEA_STYLE == 'bronze' else '_' + SEA_STYLE
    W = lambda n, s: open(os.path.join(HERE, n.replace('.svg', suffix + '.svg')), 'w').write(s)
    W('great_zille_logo.svg', build('main'))
    W('great_zille_logo_ribbon.svg', build('ribbon', 'GREAT ZILLE', as_paths=False))
    W('great_zille_logo_ribbon_paths.svg', build('ribbon', 'GREAT ZILLE', as_paths=True))
