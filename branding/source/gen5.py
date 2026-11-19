#!/usr/bin/env python3
"""Great Zille mod logo v5 - rebuilt on the Kingdom of Rizia emblem layout.

Rizia emblem parts re-drawn as clean vectors (ring, navy disc, back blade fan, pale
acanthus stems carrying oak leaves, leafy crown with 3 jewels on a red scroll);
the shield + bull are replaced by the real v14 Zille map and a gold sword whose
point sits exactly on Zille City (province 35 centroid).
Map geometry / framing is imported unchanged from gen.py (v1-v4 framing).
Run: python3 gen5.py   (VARIANT env not needed - writes A and B files)
"""
import math, os, sys
from shapely.geometry import Polygon, MultiPolygon, Point, LineString, box
from shapely.ops import unary_union
from shapely import affinity
HERE = os.path.dirname(os.path.abspath(__file__))
sys.path.insert(0, HERE)
import gen as g4                     # geometry + framing (unchanged)

CX, CY = g4.CX, g4.CY                # 512, 532  (map framing kept)
R_DISK = 340.0
R_IN, R_OUT = 338.0, 384.0
IX, IY = g4.IMPACT                   # Zille City in logo space
f = g4.f

# ------------------------------------------------------------------ palette (sampled from the Rizia emblem)
NAVY, NAVY_D, NAVY_L = '#1F2B4A', '#141C33', '#2A3A60'
LAND_A, LAND_A_LINE = '#33436A', '#46598A'           # surrounding land on navy (muted)
PG_HI, PG, PG_MID, PG_LO, PG_DK = '#F6EDC6', '#E9DBA5', '#D3C084', '#B39A5C', '#7E6A35'   # pale gold
OK_HI, OK, OK_LO, OK_DK = '#F2C34E', '#D9A12C', '#AF7A1C', '#7A5212'                        # oak ochre
ORANGE, ORANGE_D, ORANGE_HI = '#F26A36', '#C9481E', '#FF9A5C'
WHITE, WHITE_SH = '#FBFAF3', '#DCD8CC'
RED, RED_D = '#C0392B', '#7E1F14'
EDGE = '#6E5A2C'                       # soft outline (no black)

# ------------------------------------------------------------------ geometry
disk = Point(CX, CY).buffer(R_DISK + 2, 256)
zille = g4.to_logo(g4.G['zille']).simplify(0.5).intersection(disk)
main = g4.to_logo(g4.G['main']).simplify(0.7).intersection(disk)
main = main.difference(zille.buffer(3.0))
main = unary_union([q for q in getattr(main, 'geoms', [main]) if q.area > 30])

def P(theta, r):
    t = math.radians(theta)
    return (CX + r * math.sin(t), CY - r * math.cos(t))

def pd(pts, closed=True):
    s = 'M' + ' L'.join(f'{f(x)},{f(y)}' for x, y in pts)
    return s + ('Z' if closed else '')

def gd(gm):
    return g4.geom_d(gm)

def spline(pts, n=24, closed=False):
    """Catmull-Rom sample."""
    out = []; m = len(pts)
    rng = range(m) if closed else range(m - 1)
    for i in rng:
        p0 = pts[(i - 1) % m] if (closed or i > 0) else pts[i]
        p1 = pts[i]; p2 = pts[(i + 1) % m]
        p3 = pts[(i + 2) % m] if (closed or i + 2 < m) else p2
        for k in range(n):
            t = k / n; t2 = t * t; t3 = t2 * t
            out.append(tuple(0.5 * (2 * p1[j] + (-p0[j] + p2[j]) * t + (2 * p0[j] - 5 * p1[j] + 4 * p2[j] - p3[j]) * t2 + (-p0[j] + 3 * p1[j] - 3 * p2[j] + p3[j]) * t3) for j in (0, 1)))
    if not closed: out.append(pts[-1])
    return out

def normals(c):
    out = []
    for i in range(len(c)):
        a = c[max(i - 1, 0)]; b = c[min(i + 1, len(c) - 1)]
        dx, dy = b[0] - a[0], b[1] - a[1]; l = math.hypot(dx, dy) or 1
        out.append((-dy / l, dx / l))
    return out

def ribbon_poly(c, wfun):
    N = normals(c); n = len(c)
    L = [(c[i][0] + N[i][0] * wfun(i / (n - 1)), c[i][1] + N[i][1] * wfun(i / (n - 1))) for i in range(n)]
    R = [(c[i][0] - N[i][0] * wfun(i / (n - 1)), c[i][1] - N[i][1] * wfun(i / (n - 1))) for i in range(n)]
    return L, R

def xf(pts, ox, oy, ang, sx=1.0):
    a = math.radians(ang); ca, sa = math.cos(a), math.sin(a)
    return [(ox + (x * ca - y * sa * sx), oy + (x * sa + y * ca * sx)) for x, y in pts]

def mirror(pts): return [(2 * CX - x, y) for x, y in pts]
MIRROR = f'translate({2*CX},0) scale(-1,1)'

# ------------------------------------------------------------------ leaf shapes
def blade_shape(L, W, n=26, bend=0.0):
    """Long laurel/palm blade along +x: returns (upper half, lower half, midrib)."""
    mid = [(L * t, bend * L * (t * t - t)) for t in [i / n for i in range(n + 1)]]
    def w(t): return W / 2 * (math.sin(math.pi * min(1, t) ** 0.78) ** 1.1)
    up = [(x, y - w(i / n)) for i, (x, y) in enumerate(mid)]
    lo = [(x, y + w(i / n)) for i, (x, y) in enumerate(mid)]
    return up, lo, mid

def oak_geom(L, W, lobes=4, core=0.50, lr=0.50, lo=0.66, pet=0.07, peak=0.62, tipr=0.75, fwd=0.04, bend=0.0):
    """Oak leaf (shapely, local coords, midrib on +x from the petiole at 0,0): body = lens + rounded lobes."""
    def w(t):
        t = min(max(t, 0), 1)
        a_ = t / peak if t < peak else 1
        b_ = 1 if t < peak else (1 - (t - peak) / (1 - peak))
        return W / 2 * (math.sin(math.pi / 2 * a_) ** 1.3) * (b_ ** 0.6)
    n = 50; ts = [i / n for i in range(n + 1)]
    body = [Polygon([(L * (pet + (1 - pet) * t), -w(t) * core) for t in ts] + [(L * (pet + (1 - pet) * t), w(t) * core) for t in ts[::-1]]).buffer(0)]
    for side in (-1, 1):
        for k in range(lobes):
            t = 0.16 + 0.62 * k / (lobes - 1) + (0.07 if side > 0 else 0)
            ww = w(t)
            e = affinity.scale(Point(0, 0).buffer(1, 24), ww * lr * 1.15, ww * lr * 0.85)
            e = affinity.rotate(e, side * 55, origin=(0, 0))
            body.append(affinity.translate(e, L * (pet + (1 - pet) * (t + fwd)), side * ww * lo))
    body.append(Point(L * (pet + (1 - pet) * 0.9), 0).buffer(W / 2 * tipr * 0.5, 24))
    g = unary_union(body).buffer(1.2).buffer(-1.2)
    g = unary_union([g, LineString([(0, 0), (L * pet + 4, 0)]).buffer(1.6)])
    g = unary_union([Polygon(p.exterior) for p in getattr(g, 'geoms', [g])])
    if bend:
        from shapely.ops import transform
        g = transform(lambda x, y, z=None: (x, y + bend * (x / L) ** 2 * L), g)
    return g

def place(gm, x, y, ang):
    return affinity.translate(affinity.rotate(gm, ang, origin=(0, 0)), x, y)

LIGHT = (0.45, -0.89)          # light from the upper right on the right wing (mirrored on the left)
OAK_KW = dict(lobes=3, core=0.55, lr=0.56, lo=0.60, tipr=0.85)
def oak_svg(L, W, x, y, ang, light_upper=None, **kw):
    g = oak_geom(L, W, **{**OAK_KW, **kw})
    if light_upper is None:
        a_ = math.radians(ang); light_upper = (math.sin(a_) * LIGHT[0] - math.cos(a_) * LIGHT[1]) > 0
    half = g.intersection(box(-50, -500, 1000, 0) if light_upper else box(-50, 0, 1000, 500))
    G_, H_ = place(g, x, y, ang).simplify(0.3), place(half, x, y, ang).simplify(0.3)
    b = kw.get('bend', 0.0)
    rib = [place(Point(L * t, b * t * t * L), x, y, ang) for t in (0.04, 0.3, 0.6, 0.88)]
    rib_d = 'M' + ' L'.join(f'{f(p.x)},{f(p.y)}' for p in rib)
    return (f'<path d="{gd(G_)}" fill="{OK}" stroke="{OK_DK}" stroke-width="1.3" stroke-linejoin="round"/>'
            f'<path d="{gd(H_)}" fill="{OK_HI}"/>'
            f'<path d="{rib_d}" fill="none" stroke="{OK_DK}" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>'), G_

def leaf_svg(up, lo, mid, light, dark, edge, vein, sw=1.3, flip=False):
    """Two-tone painted leaf: light half / shaded half, soft outline, midrib."""
    whole = up + lo[::-1]
    a, b = (up, lo) if not flip else (lo, up)
    half_light = a + mid[::-1]
    return (f'<path d="{pd(whole)}" fill="{dark}" stroke="{edge}" stroke-width="{sw}" stroke-linejoin="round"/>'
            f'<path d="{pd(half_light)}" fill="{light}"/>'
            f'<path d="{pd(mid[1:-2], False)}" fill="none" stroke="{vein}" stroke-width="1.3" stroke-linecap="round" opacity="0.9"/>')

# ------------------------------------------------------------------ defs
def defs():
    return f'''<defs>
  <linearGradient id="gRing" gradientUnits="userSpaceOnUse" x1="{CX-300}" y1="{CY-320}" x2="{CX+300}" y2="{CY+320}"><stop offset="0" stop-color="{PG_HI}"/><stop offset="0.5" stop-color="{PG}"/><stop offset="1" stop-color="{PG_MID}"/></linearGradient>
  <linearGradient id="gRingIn" gradientUnits="userSpaceOnUse" x1="{CX+300}" y1="{CY+320}" x2="{CX-300}" y2="{CY-320}"><stop offset="0" stop-color="{PG_HI}"/><stop offset="1" stop-color="{PG_LO}"/></linearGradient>
  <radialGradient id="gSea" cx="{CX}" cy="{CY-60}" r="{R_DISK+40}" gradientUnits="userSpaceOnUse"><stop offset="0" stop-color="{NAVY_L}"/><stop offset="0.75" stop-color="{NAVY}"/><stop offset="1" stop-color="{NAVY_D}"/></radialGradient>
  <linearGradient id="gWhite" x1="0" y1="0" x2="0" y2="1"><stop offset="0" stop-color="#FFFFFF"/><stop offset="1" stop-color="#EEEAE0"/></linearGradient>
  <linearGradient id="gOrange" x1="0" y1="0" x2="0" y2="1"><stop offset="0" stop-color="#F7773F"/><stop offset="1" stop-color="#E85A28"/></linearGradient>
  <linearGradient id="gCream" gradientUnits="userSpaceOnUse" x1="0" y1="{CY-200}" x2="0" y2="{CY+280}"><stop offset="0" stop-color="#FBF1CF"/><stop offset="0.6" stop-color="#F0DDA0"/><stop offset="1" stop-color="#E2C47A"/></linearGradient>
  <linearGradient id="gCrown" gradientUnits="userSpaceOnUse" x1="0" y1="125" x2="0" y2="265"><stop offset="0" stop-color="#F8EBB4"/><stop offset="0.55" stop-color="#E8D38A"/><stop offset="1" stop-color="#C4A65C"/></linearGradient>
  <linearGradient id="gBand" gradientUnits="userSpaceOnUse" x1="0" y1="228" x2="0" y2="262"><stop offset="0" stop-color="#F3E3A2"/><stop offset="1" stop-color="#B8984E"/></linearGradient>
  <linearGradient id="gRed" gradientUnits="userSpaceOnUse" x1="0" y1="240" x2="0" y2="292"><stop offset="0" stop-color="#D2483A"/><stop offset="1" stop-color="#8E2418"/></linearGradient>
  <radialGradient id="gJewel" cx="0.38" cy="0.32" r="0.75"><stop offset="0" stop-color="#7D9BD6"/><stop offset="0.5" stop-color="#2C4682"/><stop offset="1" stop-color="#16244A"/></radialGradient>
  <linearGradient id="gHiltV" x1="0" y1="0" x2="1" y2="0"><stop offset="0" stop-color="#F9E7A6"/><stop offset="0.5" stop-color="#DDB656"/><stop offset="1" stop-color="#A57B26"/></linearGradient>
  <linearGradient id="gGuard" x1="0" y1="0" x2="0" y2="1"><stop offset="0" stop-color="#F8E6A2"/><stop offset="0.6" stop-color="#DCB252"/><stop offset="1" stop-color="#A57B26"/></linearGradient>
  <linearGradient id="gBladeL" gradientUnits="userSpaceOnUse" x1="0" y1="390" x2="0" y2="720"><stop offset="0" stop-color="#FFF3C4"/><stop offset="1" stop-color="#F1D27A"/></linearGradient>
  <linearGradient id="gBladeR" gradientUnits="userSpaceOnUse" x1="0" y1="390" x2="0" y2="720"><stop offset="0" stop-color="#DDB65A"/><stop offset="1" stop-color="#B78A30"/></linearGradient>
  <radialGradient id="gGlow" cx="{f(IX)}" cy="{f(IY)}" r="90" gradientUnits="userSpaceOnUse"><stop offset="0" stop-color="#FFE7A3" stop-opacity="0.95"/><stop offset="0.35" stop-color="{ORANGE_HI}" stop-opacity="0.55"/><stop offset="1" stop-color="{ORANGE}" stop-opacity="0"/></radialGradient>
  <clipPath id="cDisk"><circle cx="{CX}" cy="{CY}" r="{R_DISK}"/></clipPath>
  <clipPath id="cLand"><path d="{gd(zille)}"/></clipPath>
  <filter id="fGlow" x="-20%" y="-20%" width="140%" height="140%"><feGaussianBlur stdDeviation="2.4"/></filter>
</defs>'''

# ------------------------------------------------------------------ back fan of long pale blades (behind the ring)
FAN = dict(t0=176, t1=32, n=9, L=150, W=60, tilt=3, tilt1=13, r0=R_OUT - 24, back_tilt=36, back_L=122)
def blade_at(theta, r, L, W, tilt, light, dark, side=1):
    t = math.radians(theta)
    d = (-math.cos(t), -math.sin(t)); nrm = (math.sin(t), -math.cos(t))
    a = math.radians(tilt)
    v = (math.cos(a) * d[0] + math.sin(a) * nrm[0], math.cos(a) * d[1] + math.sin(a) * nrm[1])
    ang = math.degrees(math.atan2(v[1], v[0]))
    up, lo, mid = blade_shape(L, W, bend=0.10)
    bx, by = P(theta, r)
    up, lo, mid = xf(up, bx, by, ang), xf(lo, bx, by, ang), xf(mid, bx, by, ang)
    # 'up' half (y<0 local) is the outer side for the right wing -> light on inner side like the reference
    return leaf_svg(up, lo, mid, light, dark, EDGE, PG_LO, sw=1.2, flip=True)

def back_fan():
    c = FAN; out = []
    ths = [c['t0'] + (c['t1'] - c['t0']) * i / (c['n'] - 1) for i in range(c['n'])]
    # stem (branch) running behind the blades, crossing at the bottom with cut ends
    stem = spline([P(187, R_OUT + 30), P(181, R_OUT + 20), P(172, R_OUT + 8), P(150, R_OUT - 6), P(100, R_OUT - 8), P(45, R_OUT - 12)], 20)
    L, R = ribbon_poly(stem, lambda u: 8 - 5 * u)
    end = stem[0]
    stem_svg = (f'<path d="{pd(L + R[::-1])}" fill="{PG_MID}" stroke="{EDGE}" stroke-width="1.2"/>'
                f'<ellipse cx="{f(end[0])}" cy="{f(end[1])}" rx="8" ry="5" transform="rotate(-58 {f(end[0])} {f(end[1])})" fill="{PG_HI}" stroke="{EDGE}" stroke-width="1.1"/>')
    back = ''.join(blade_at(t + 8, c['r0'] + 4, c['back_L'], c['W'] * 0.8, c['back_tilt'], PG_MID, PG_LO) for t in reversed(ths[1:]))
    front = ''.join(blade_at(t, c['r0'], c['L'] * (1 - 0.22 * i / (c['n'] - 1)), c['W'] * (1 - 0.15 * i / (c['n'] - 1)), c['tilt'] + (c['tilt1'] - c['tilt']) * i / (c['n'] - 1), PG_HI, PG_MID) for i, t in reversed(list(enumerate(ths))))
    one = stem_svg + back + front
    return f'<g id="back_fan" stroke-linejoin="round"><g id="fan_right">{one}</g><g id="fan_left" transform="{MIRROR}">{one}</g></g>'

# ------------------------------------------------------------------ ring + navy disc
def ring():
    return f'''<g id="ring">
  <circle cx="{CX}" cy="{CY}" r="{R_OUT}" fill="url(#gRing)" stroke="{EDGE}" stroke-width="1.6"/>
  <circle cx="{CX}" cy="{CY}" r="{R_OUT-7}" fill="none" stroke="{PG_HI}" stroke-width="2" opacity="0.8"/>
  <circle cx="{CX}" cy="{CY}" r="{R_IN+9}" fill="none" stroke="url(#gRingIn)" stroke-width="10"/>
  <circle cx="{CX}" cy="{CY}" r="{R_IN+3}" fill="none" stroke="{EDGE}" stroke-width="1.4" opacity="0.8"/>
</g>'''

VARIANT = 'A'
def field():
    return f'<g id="sea"><circle cx="{CX}" cy="{CY}" r="{R_DISK}" fill="url(#gSea)"/></g>'

def mapgroup(variant, under=''):
    zd, md = gd(zille), gd(main)
    left = zille.intersection(box(0, 0, IX, 1024)); right = zille.intersection(box(IX, 0, 1024, 1024))
    if variant == 'A':
        land = (f'<path id="zille_west" d="{gd(left)}" fill="url(#gWhite)"/>'
                f'<path id="zille_east" d="{gd(right)}" fill="url(#gOrange)"/>')
        edge = '#C9A755'
    else:
        land = f'<path id="zille_land" d="{zd}" fill="url(#gCream)"/>'
        edge = '#B39A5C'
    return f'''<g id="map">
  <g id="surrounding_land" clip-path="url(#cDisk)"><path d="{md}" fill="{LAND_A}" stroke="{LAND_A_LINE}" stroke-width="1.4" stroke-linejoin="round"/></g>
  {under}
  <path id="zille_shadow" d="{zd}" transform="translate(4,6)" fill="#0B1022" opacity="0.45" clip-path="url(#cDisk)"/>
  <g id="zille">{land}<path d="{zd}" fill="none" stroke="{edge}" stroke-width="2.4" stroke-linejoin="round"/></g>
</g>'''

# ------------------------------------------------------------------ pale acanthus stems carrying oak leaves (inside the ring)
def scroll_end(c, r0=30, turns=1.75, shrink=0.62, n=56):
    """Continue a curve into an inward spiral (acanthus scroll), turning to the left of travel."""
    (x1, y1), (x0, y0) = c[-1], c[-4]
    a = math.atan2(y1 - y0, x1 - x0)
    nx, ny = math.sin(a), -math.cos(a)
    cx, cy = x1 + r0 * nx, y1 + r0 * ny
    phi0 = math.atan2(-ny, -nx)
    out = []
    for k in range(1, n + 1):
        t = k / n; th = turns * math.pi * t
        r = r0 * (1 - shrink * t)
        out.append((cx + r * math.cos(phi0 - th), cy + r * math.sin(phi0 - th)))
    return out

def stem_curve():
    c = spline(STEM_PTS, 18)
    return c + scroll_end(c)

def at(c, t):
    i = min(int(t * (len(c) - 1)), len(c) - 2)
    a = math.degrees(math.atan2(c[i + 1][1] - c[i][1], c[i + 1][0] - c[i][0]))
    return c[i], a

# (t along stem, angle offset vs stem tangent, length, width, light half upper?)
# clusters of oak leaves sprouting from nodes of the stem: (t, [(angle offset vs tangent, length), ...])
OAK_NODES = [(0.15, [(-26, 96), (30, 112)]),
             (0.27, [(-30, 124), (34, 140), (6, 104)]),
             (0.40, [(-30, 148), (30, 164), (4, 120)]),
             (0.53, [(-28, 140), (28, 156), (2, 112)]),
             (0.65, [(-26, 116), (24, 132)]),
             (0.74, [(-24, 86), (22, 100)])]
def make_oaks():
    out = []
    for t, ls in OAK_NODES:
        for off, L in ls:
            out.append((t, off, L, 0.56 * L, None))
    return out
OAKS = make_oaks()
STEM_PTS = [(500, 748), (548, 782), (604, 806), P(152, 302), P(134, 318), P(114, 296), P(94, 314), P(76, 294), P(62, 300)]
def foliage(report=False):
    c = stem_curve()
    under = ''; over = ''; polys = []
    for t, off, L, W, up in OAKS:
        (x, y), a = at(c, t)
        sv, pg = oak_svg(L, W, x, y, a + off, light_upper=None if up is None else bool(up), bend=-0.10 if off > 0 else 0.10)
        if off < 0: under += sv
        else: over += sv
        polys.append(pg)
    if report:
        u = unary_union(polys)
        print('oak/zille overlap px^2:', round(u.intersection(zille).area, 1), ' mirrored:', round(affinity.scale(u, -1, 1, origin=(CX, CY)).intersection(zille).area, 1))
    def w(u): return 15 * (1 - u) ** 0.85 + 3.6
    L, R = ribbon_poly(c, w)
    Lh, Rh = ribbon_poly(c, lambda u: w(u) * 0.15)
    stem = (f'<path d="{pd(L + R[::-1])}" fill="{PG_MID}" stroke="{EDGE}" stroke-width="1.3" stroke-linejoin="round"/>'
            f'<path d="{pd(L + Lh[::-1])}" fill="{PG_HI}" opacity="0.95"/>')
    shadow_g = unary_union(polys + [Polygon(L + R[::-1]).buffer(0)]).simplify(0.4)
    shadow = f'<path class="shadow" d="{gd(shadow_g)}" transform="translate(3,5)" fill="#0B1022" opacity="0.28"/>'
    one = f'{shadow}<g class="oak_leaves_under">{under}</g><g class="stem">{stem}</g><g class="oak_leaves_over">{over}</g>'
    return f'<g id="foliage"><g id="foliage_right">{one}</g><g id="foliage_left" transform="{MIRROR}">{one}</g></g>'

# ------------------------------------------------------------------ crown (Rizia: open leafy crown, 3 jewels on the central point) + red scroll
CR = dict(cy=232, band_h=24, half=88)
def lens(p0, p1, w, bulge=0.5, n=30, curve=0.0):
    """pointed leaf polygon from p0 to p1, max half width w; curve bends the midline sideways."""
    (x0, y0), (x1, y1) = p0, p1
    L = math.hypot(x1 - x0, y1 - y0); a = math.atan2(y1 - y0, x1 - x0)
    up, lo = [], []
    for i in range(n + 1):
        t = i / n; off = curve * L * 4 * t * (1 - t)
        hw = w * (math.sin(math.pi * t ** (bulge / 0.5 * 0.7)) ** 0.9)
        up.append((L * t, off - hw)); lo.append((L * t, off + hw))
    return Polygon(xf(up + lo[::-1], x0, y0, math.degrees(a))).buffer(0)

CROWN_LEAVES = [  # (base dx, base dy, length, width, angle from vertical, lobes)
    (0, 12, 102, 50, 0, 3),
    (-34, 10, 70, 52, -16, 3), (34, 10, 70, 52, 16, 3),
    (-64, 12, 84, 60, -42, 3), (64, 12, 84, 60, 42, 3)]
def crown_geom():
    cy, bh, hw = CR['cy'], CR['band_h'], CR['half']
    def bt(x): return cy - 7 * ((x - CX) / hw) ** 2
    band = Polygon([(x, bt(x)) for x in [CX - hw + i * 2 * hw / 30 for i in range(31)]] +
                   [(x, bt(x) + bh) for x in [CX + hw - i * 2 * hw / 30 for i in range(31)]])
    leaves = []
    for dx, dy, L, W, ang, lob in CROWN_LEAVES:
        g = oak_geom(L, W, lobes=lob, pet=0.0, core=0.6, lr=0.55, lo=0.6, tipr=0.7 if dx == 0 else 0.9)
        if dx < 0: g = affinity.scale(g, 1, -1, origin=(0, 0))
        leaves.append(place(g, CX + dx, bt(CX + dx) + dy, -90 + ang))
    g = unary_union([band] + leaves).buffer(1.0).buffer(-1.0).simplify(0.3)
    return g, band, leaves

def red_scroll():
    """Red scroll under the crown band with rolled ends (Rizia emblem)."""
    cy = CR['cy']; hw = CR['half'] + 14
    def bt(x): return cy - 7 * ((x - CX) / CR['half']) ** 2 + CR['band_h']
    xs = [CX - hw + i * (2 * hw) / 40 for i in range(41)]
    top = [(x, bt(x) - 8) for x in xs]
    bot = [(x, bt(x) + 9 + 12 * (1 - ((x - CX) / hw) ** 2)) for x in xs[::-1]]
    body = f'<path d="{pd(top + bot)}" fill="url(#gRed)" stroke="#5A140C" stroke-width="1.2" stroke-linejoin="round"/>'
    ends = ''
    for sg in (-1, 1):
        x = CX + sg * hw; y = bt(x) + 1
        sp = [(x + sg * (7 * (1 - 0.8 * t)) * math.cos(4.2 * t * math.pi * 0.5), y + (7 * (1 - 0.8 * t)) * math.sin(4.2 * t * math.pi * 0.5)) for t in [k / 24 for k in range(25)]]
        ends += (f'<circle cx="{f(x)}" cy="{f(y)}" r="9.5" fill="{RED_D}" stroke="#5A140C" stroke-width="1.2"/>'
                 f'<path d="{pd(sp, False)}" fill="none" stroke="#E06A58" stroke-width="1.8" stroke-linecap="round"/>')
    return f'<g id="red_scroll">{body}{ends}</g>'

def crown():
    g, band, leaves = crown_geom()
    cy = CR['cy']
    jewels = ''
    for jy, r in ((cy - 66, 5.6), (cy - 45, 6.0), (cy - 24, 6.4)):
        jewels += (f'<circle cx="{CX}" cy="{f(jy)}" r="{r}" fill="url(#gJewel)" stroke="#0E1730" stroke-width="1.1"/>'
                   f'<circle cx="{f(CX - r*0.35)}" cy="{f(jy - r*0.38)}" r="{f(r*0.3)}" fill="#FFFFFF" opacity="0.85"/>')
    # soft shading: right half slightly darker (light from the upper left, as in the reference)
    shade = g.intersection(box(CX, 0, 1024, 1024)).simplify(0.3)
    band_g = band.intersection(g)
    veins = ''
    bt = lambda x: cy - 7 * ((x - CX) / CR['half']) ** 2
    for dx, dy, L, W, ang, lob in CROWN_LEAVES:
        a = math.radians(-90 + ang); x0, y0 = CX + dx, bt(CX + dx) + dy - 4
        veins += f'M{f(x0 + 0.25*L*math.cos(a))},{f(y0 + 0.25*L*math.sin(a))} L{f(x0 + 0.7*L*math.cos(a))},{f(y0 + 0.7*L*math.sin(a))} '
    return f'''<g id="crown" stroke-linejoin="round">
  <path d="{gd(g)}" transform="translate(3,5)" fill="#0B1022" opacity="0.3"/>
  <path d="{gd(g)}" fill="url(#gCrown)"/>
  <path d="{gd(shade)}" fill="#A8873E" opacity="0.28"/>
  <path d="{gd(band_g)}" fill="url(#gBand)"/>
  <path d="M{CX-CR['half']+6},{cy+5} Q{CX},{cy+13} {CX+CR['half']-6},{cy+5}" fill="none" stroke="{PG_HI}" stroke-width="2" opacity="0.9"/>
  <path d="{veins}" fill="none" stroke="#B4944A" stroke-width="1.2" opacity="0.55" stroke-linecap="round"/>
  <path d="{gd(g)}" fill="none" stroke="{EDGE}" stroke-width="1.6"/>
  {jewels}
</g>'''

# ------------------------------------------------------------------ golden sword (v4 design, softened, re-proportioned under the crown)
SW = dict(fin=272, pom0=277, pom1=311, grip0=316, grip1=364, guard=378)
def sword():
    x = CX; tip = IY
    btop = SW['guard'] + 10
    hw0, hw1 = 24.0, 20.5
    pstart = tip - 56
    def side(sg):
        return [(x + sg * hw0, btop), (x + sg * hw1, pstart)] + [(x + sg * hw1 * (1 - t) ** 0.85, pstart + (tip - pstart) * t) for t in (0.25, 0.5, 0.75)]
    Lp, Rp = side(-1), side(1)
    blade_l = pd([(x, btop)] + Lp + [(x, tip)]); blade_r = pd([(x, btop)] + Rp + [(x, tip)])
    blade_o = pd(Lp + [(x, tip)] + Rp[::-1])
    inset = 5.5; bev = ''
    for sg in (-1, 1):
        bev += f'M{f(x+sg*(hw0-inset))},{btop+6} L{f(x+sg*(hw1-inset+0.5))},{f(pstart)} L{f(x)},{f(tip-11)} '
    fuller = f'M{f(x-3.5)},{btop+16} L{f(x-2.6)},{f(pstart-26)} L{f(x)},{f(pstart-12)} L{f(x+2.6)},{f(pstart-26)} L{f(x+3.5)},{btop+16} L{f(x)},{btop+9}Z'
    g0, g1 = SW['grip0'], SW['grip1']; gm = (g0 + g1) / 2
    grip = f'M{f(x-10)},{g0} C{f(x-13)},{f(gm)} {f(x-13)},{f(gm)} {f(x-11)},{g1} L{f(x+11)},{g1} C{f(x+13)},{f(gm)} {f(x+13)},{f(gm)} {f(x+10)},{g0}Z'
    hatch = ''.join(f'M{f(x-15)},{f(y)} L{f(x+15)},{f(y+12)} M{f(x+15)},{f(y)} L{f(x-15)},{f(y+12)} ' for y in range(g0 - 8, g1 + 4, 8))
    p0, p1 = SW['pom0'], SW['pom1']; pm = (p0 + p1) / 2
    pommel = (f'M{f(x)},{p0} C{f(x+15)},{p0} {f(x+22)},{f(pm-3)} {f(x+19)},{f(pm+5)} C{f(x+16)},{f(p1-2)} {f(x+6)},{p1} {f(x)},{p1} '
              f'C{f(x-6)},{p1} {f(x-16)},{f(p1-2)} {f(x-19)},{f(pm+5)} C{f(x-22)},{f(pm-3)} {f(x-15)},{p0} {f(x)},{p0}Z')
    collar = f'M{f(x-12)},{p1-1} L{f(x+12)},{p1-1} L{f(x+10)},{g0+1} L{f(x-10)},{g0+1}Z'
    q = SW['guard']; k = 0.9
    rh = [(0, q - 11), (27, q - 9), (56, q - 10), (79, q - 14), (94, q - 23), (103, q - 27), (110, q - 22), (110, q - 13), (103, q - 8), (96, q - 12), (97, q - 17), (90, q - 11), (77, q - 2), (54, q + 5), (27, q + 7), (0, q + 9)]
    gp = [(x + a, b) for a, b in rh] + [(x - a, b) for a, b in reversed(rh[1:-1])]
    guard = g4.catmull(gp)
    guard_line = f'M{f(x-86)},{q-7} Q{f(x)},{q-2} {f(x+86)},{q-7}'
    med = f'M{f(x)},{q-23} L{f(x+19)},{q} L{f(x)},{q+26} L{f(x-19)},{q}Z'
    shadow_d = blade_o + ' ' + guard + ' ' + grip + ' ' + pommel
    E = '#7A5718'
    return f'''<g id="sword" stroke-linejoin="round">
  <path id="sword_shadow" d="{shadow_d}" transform="translate(5,6)" fill="#0B1022" opacity="0.35"/>
  <g id="blade">
    <path d="{blade_l}" fill="url(#gBladeL)"/><path d="{blade_r}" fill="url(#gBladeR)"/>
    <path d="{bev}" fill="none" stroke="#9C7224" stroke-width="1.2" opacity="0.75"/>
    <path d="{fuller}" fill="#B98A30" opacity="0.9"/>
    <path d="{blade_o}" fill="none" stroke="{E}" stroke-width="1.8"/>
  </g>
  <g id="glint" transform="translate({f(IX)},{f(IY)})">
    <path d="M0,-26 L3.5,-3.5 L26,0 L3.5,3.5 L0,26 L-3.5,3.5 L-26,0 L-3.5,-3.5Z" fill="#FFF6D2" opacity="0.95"/>
    <circle r="5" fill="#FFFFFF"/>
  </g>
  <g id="hilt">
    <clipPath id="cGrip"><path d="{grip}"/></clipPath>
    <path d="{grip}" fill="url(#gHiltV)" stroke="{E}" stroke-width="1.6"/>
    <path d="{hatch}" stroke="#94691E" stroke-width="1.6" clip-path="url(#cGrip)" fill="none"/>
    <path d="{collar}" fill="url(#gHiltV)" stroke="{E}" stroke-width="1.5"/>
    <path d="{pommel}" fill="url(#gHiltV)" stroke="{E}" stroke-width="1.6"/>
    <path d="M{f(x)},{p0+5} L{f(x)},{p1-4} M{f(x-10)},{f(pm)} Q{f(x)},{f(pm+4)} {f(x+10)},{f(pm)}" stroke="#A47A2A" stroke-width="1.2" fill="none"/>
    <circle cx="{f(x)}" cy="{SW['fin']}" r="5.5" fill="url(#gHiltV)" stroke="{E}" stroke-width="1.4"/>
    <path d="{guard}" fill="url(#gGuard)" stroke="{E}" stroke-width="1.7"/>
    <path d="{guard_line}" stroke="#A47A2A" stroke-width="1.2" fill="none"/>
    <path d="{med}" fill="url(#gGuard)" stroke="{E}" stroke-width="1.6"/>
    <ellipse cx="{f(x)}" cy="{q+1}" rx="7" ry="9" fill="{ORANGE}" stroke="#8E3510" stroke-width="1.3"/>
    <ellipse cx="{f(x-2.2)}" cy="{q-2.5}" rx="2.1" ry="2.7" fill="#FFFFFF" opacity="0.85"/>
  </g>
</g>'''

def impact():
    s = g4.cracks()
    return s

# ------------------------------------------------------------------ ribbon (Rizia-style: orange band, folded tails, soft edges)
def ribbon(text, as_paths, size=44, tracking=0.10, w=250):
    y = CY + R_OUT - 4; h = 58; R = 1000
    def ay(xx): return y - (R - math.sqrt(R * R - (xx - CX) ** 2))
    xs = [CX - w + i * (2 * w) / 30 for i in range(31)]
    top = [(xx, ay(xx) - h / 2) for xx in xs]; bot = [(xx, ay(xx) + h / 2) for xx in reversed(xs)]
    lx = CX - w; ly = ay(lx)
    tail = pd([(lx + 24, ly - h / 2 + 18), (lx - 74, ly - h / 2 + 24), (lx - 50, ly + 22), (lx - 80, ly + h / 2 + 20), (lx + 24, ly + h / 2 + 18)])
    fold = pd([(lx, ly + h / 2), (lx + 24, ly + h / 2 + 18), (lx + 24, ly + h / 2 - 4)])
    base = y + size * 0.34
    fill = '#FBF1D2'
    if as_paths:
        txt = f'<g id="ribbon_text" fill="{fill}">' + g4.text_path(text, CX, base, size, tracking, arc_r=R) + '</g>'
    else:
        txt = (f'<defs><path id="ribbonArc" d="M{CX-w},{f(ay(CX-w)+size*0.34)} A{R},{R} 0 0 0 {CX+w},{f(ay(CX+w)+size*0.34)}"/></defs>'
               f'<text id="ribbon_text" font-family="Cinzel, \'Trajan Pro\', \'Cormorant Garamond\', Georgia, \'Times New Roman\', serif" font-weight="700" font-size="{size}" letter-spacing="{f(size*tracking)}" fill="{fill}" text-anchor="middle">'
               f'<textPath href="#ribbonArc" startOffset="50%">{text}</textPath></text>')
    one = f'<path d="{tail}" fill="{ORANGE_D}" stroke="#7E2C0C" stroke-width="1.4"/><path d="{fold}" fill="#7E2C0C"/>'
    return f'''<g id="ribbon" stroke-linejoin="round">
  <g id="ribbon_tails"><g>{one}</g><g transform="{MIRROR}">{one}</g></g>
  <path d="{pd(top + bot)}" fill="url(#gOrange)" stroke="#7E2C0C" stroke-width="1.5"/>
  <path d="{pd([(a, b + 5) for a, b in top], False)}" stroke="{PG}" stroke-width="2" fill="none" opacity="0.9"/>
  <path d="{pd([(a, b - 5) for a, b in bot], False)}" stroke="{PG}" stroke-width="2" fill="none" opacity="0.9"/>
  {txt}
</g>'''

def build(variant='A', text=None, as_paths=True):
    parts = [defs(), back_fan(), ring(), field(), mapgroup(variant, foliage()), impact(), red_scroll(), crown(), sword()]
    if text: parts.append(ribbon(text, as_paths))
    title = 'Great Zille' + (f' - {text}' if text else '')
    return (f'<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 1024 1024" width="1024" height="1024">\n'
            f'<title>{title}</title>\n' + '\n'.join(parts) + '\n</svg>\n')

if __name__ == '__main__':
    out = sys.argv[1] if len(sys.argv) > 1 else HERE
    for v, suf in (('A', ''), ('B', '_b')):
        W = lambda n, s: open(os.path.join(out, n + suf + '.svg'), 'w').write(s)
        W('great_zille_logo', build(v))
        W('great_zille_logo_ribbon', build(v, 'GREAT ZILLE', as_paths=False))
        W('great_zille_logo_ribbon_paths', build(v, 'GREAT ZILLE', as_paths=True))
    print('impact', IX, IY); foliage(report=True)
