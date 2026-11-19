#!/usr/bin/env python3
"""Great Zille mod logo v8 (final polish) - gen7.py with:
  * oak leaves now emerge from BEHIND the pale vines: every leaf is drawn under the stem, leaf bases sit on the
    stem centre-line and are hidden by it; a soft cast shadow of the stem falls on the leaves (clipped to them);
  * crown cleaned up: silhouette smoothed + fuller (closing/opening of the traced outline, mirror-exact),
    all inner relief/vein/shade strokes are clipped to the crown shape, round joins, no seam lines,
    jewels evenly spaced and centred on the axis;
  * laurel blades darker (Rizia-like deeper gold), still two-tone, with a rim shadow so they separate from the rim.
Zille, map, sword (tip 512,715.8), rim, ribbon and variants A/B unchanged.
Run: python3 gen8.py [outdir]
"""
import json, math, os, sys
from shapely.geometry import Polygon, Point, box
from shapely.ops import unary_union
from shapely import affinity
HERE = os.path.dirname(os.path.abspath(__file__)); sys.path.insert(0, HERE)
import gen7 as V7
import gen6 as V6
import gen5 as B
from gen5 import CX, CY, R_OUT, pd, gd, spline, f, MIRROR, EDGE, PG_MID, PG_HI, ribbon_poly, at, oak_svg

# ================================================================== crown
TR, _T, CRN = V7.TR, V7._T, V7.CRN

def _chaikin(coords, it=2):
    pts = list(coords)[:-1]
    for _ in range(it):
        new = []
        for i in range(len(pts)):
            a, b = pts[i], pts[(i + 1) % len(pts)]
            new += [(0.75 * a[0] + 0.25 * b[0], 0.75 * a[1] + 0.25 * b[1]), (0.25 * a[0] + 0.75 * b[0], 0.25 * a[1] + 0.75 * b[1])]
        pts = new
    return pts

def crown_outline():
    outer = [c for c in TR['contours'] if not c['hole']][0]['pts']
    g = Polygon([_T(x, y) for x, y in outer]).buffer(0)
    right = g.intersection(box(CX, 0, 1024, 1024))
    fat = float(os.environ.get('C_FAT', '2.8'))
    # close narrow notches, remove spikes, then grow a little (fuller lobes/body)
    cl = float(os.environ.get('C_CLOSE', '1.6')); op = float(os.environ.get('C_OPEN', '0.8'))
    right = right.buffer(cl, 24).buffer(-cl, 24)
    right = right.buffer(-op, 24).buffer(op, 24)
    right = right.buffer(fat, 24)
    right = right.intersection(box(CX, 0, 1024, 1024))
    left = affinity.scale(right, -1, 1, origin=(CX, 0))
    g = unary_union([right, left]).buffer(0.01).buffer(-0.01)
    if g.geom_type != 'Polygon': g = max(g.geoms, key=lambda p: p.area)
    # smooth the final ring (round corners, symmetric because the polygon is)
    ring = Polygon(g.exterior)
    sm = Polygon(_chaikin(list(ring.exterior.coords), int(os.environ.get('C_CHK', '1')))).buffer(0)
    # exact mirror symmetry again
    r2 = sm.intersection(box(CX, 0, 1024, 1024)); l2 = affinity.scale(r2, -1, 1, origin=(CX, 0))
    out = unary_union([r2, l2]).buffer(0.05).buffer(-0.05)
    return Polygon(out.exterior).simplify(0.08)

def crown():
    g = crown_outline()
    y0, y1 = CRN['top'], CRN['top'] + (TR['bottom'] - TR['top']) * V7._S
    gdp = gd(g)
    # jewels: evenly spaced on the axis
    jy = sorted(_T(0, j[0])[1] for j in TR['jewels'])
    ys = [jy[0] + (jy[-1] - jy[0]) * i / 2 for i in range(3)]
    jew = ''
    for y in ys:
        r = 5.6
        jew += (f'<circle cx="{CX}" cy="{f(y)}" r="{r}" fill="url(#gJewel)" stroke="#16244A" stroke-width="1.1"/>'
                f'<circle cx="{f(CX - r*0.33)}" cy="{f(y - r*0.36)}" r="{f(r*0.28)}" fill="#FFFFFF" opacity="0.8"/>')
    # soft emboss ribs (all clipped to the silhouette)
    S = V7._S
    lines = ''
    for sg in (1, -1):
        def M(pts): return 'M' + ' L'.join(f'{f(CX + sg * (x * S))},{f(CRN["top"] + (y - TR["top"]) * S)}' for x, y in spline(pts, 6)) + ' '
        lines += M([(120, 380), (190, 350), (250, 290), (292, 205)])        # horn rib
        lines += M([(70, 160), (130, 150), (178, 162)])                     # upper-leaf rib
    inner = g.buffer(-3.0, 16)
    return f'''<g id="crown" stroke-linejoin="round" stroke-linecap="round">
  <linearGradient id="gCrown8" gradientUnits="userSpaceOnUse" x1="0" y1="{f(y0)}" x2="0" y2="{f(y1)}"><stop offset="0" stop-color="#FCF3C8"/><stop offset="0.55" stop-color="#F0DE9A"/><stop offset="1" stop-color="#D9BC6C"/></linearGradient>
  <linearGradient id="gCrownSh" gradientUnits="userSpaceOnUse" x1="{CX-120}" y1="0" x2="{CX+120}" y2="0"><stop offset="0" stop-color="#A8873E" stop-opacity="0"/><stop offset="0.5" stop-color="#A8873E" stop-opacity="0.04"/><stop offset="1" stop-color="#A8873E" stop-opacity="0.22"/></linearGradient>
  <clipPath id="cCrown"><path d="{gdp}"/></clipPath>
  <path d="{gdp}" transform="translate(3,5)" fill="#0B1022" opacity="0.35"/>
  <path d="{gdp}" fill="url(#gCrown8)"/>
  <g clip-path="url(#cCrown)">
    <path d="{gdp}" fill="url(#gCrownSh)"/>
    <path d="{gd(inner)}" fill="none" stroke="#FFF9E0" stroke-width="1.4" opacity="0.5"/>
    <path d="{lines}" fill="none" stroke="#B0914A" stroke-width="1.3" opacity="0.4"/>
  </g>
  <path d="{gdp}" fill="none" stroke="#76592A" stroke-width="1.9" stroke-linejoin="round"/>
  {jew}
</g>'''

# ================================================================== darker laurel blades
V7.BL_HI, V7.BL, V7.BL_EDGE = '#E9CF80', '#B8963F', '#503B12'
from gen5 import P
BLADE_POLYS = []
def blade(tb, tt, rb, rm, rt, W, light=None, dark=None, edge=None, n=48):
    """V7.blade geometry with darker colours; also records the outline for the rim-shadow clip."""
    cl = []
    for i in range(n + 1):
        u = i / n; th = tb + (tt - tb) * u
        r = (1 - u) ** 2 * rb + 2 * u * (1 - u) * rm + u * u * rt
        cl.append(P(th, r))
    def w(u): return W / 2 * (math.sin(math.pi * min(1.0, u ** 0.55)) ** 1.35)
    out, inn = [], []
    for i, (x, y) in enumerate(cl):
        a = cl[max(i - 1, 0)]; b = cl[min(i + 1, n)]
        dx, dy = b[0] - a[0], b[1] - a[1]; l = math.hypot(dx, dy) or 1
        nx, ny = -dy / l, dx / l
        if (x - CX) * nx + (y - CY) * ny < 0: nx, ny = -nx, -ny
        ww = w(i / n)
        out.append((x + nx * ww, y + ny * ww)); inn.append((x - nx * ww, y - ny * ww))
    whole = out + inn[::-1]; lit = out + cl[::-1]
    BLADE_POLYS.append(Polygon(whole).buffer(0))
    return (f'<path d="{pd(whole)}" transform="translate(-2,3)" fill="#2A2410" opacity="0.30"/>'
            f'<path d="{pd(whole)}" fill="{V7.BL}" stroke="{V7.BL_EDGE}" stroke-width="1.3" stroke-linejoin="round"/>'
            f'<path d="{pd(lit)}" fill="{V7.BL_HI}"/>')
V7.blade = blade
def back_fan():
    del BLADE_POLYS[:]
    s = V7.back_fan()
    # soft shadow cast by the rim onto the blades (only where blades are) so blades and rim separate
    ann = Point(CX, CY).buffer(R_OUT + 12, 128).difference(Point(CX, CY).buffer(R_OUT - 1, 128))
    bl = unary_union(BLADE_POLYS)
    bl = unary_union([bl, affinity.scale(bl, -1, 1, origin=(CX, CY))])
    sh = ann.intersection(bl)
    return s + f'<g id="rim_shadow"><path d="{gd(sh)}" fill="#1A1408" opacity="0.30"/></g>'

# ================================================================== oak leaves behind the vines
def foliage():
    c = B.stem_curve()
    leaves = ''; polys = []
    for t, off, L, W, up in B.OAKS:
        (x, y), a = at(c, t)
        sv, pg = oak_svg(L, W, x, y, a + off, light_upper=None if up is None else bool(up), bend=-0.10 if off > 0 else 0.10)
        leaves += sv; polys.append(pg)
    def w(u): return 15 * (1 - u) ** 0.85 + 3.6
    L, R = ribbon_poly(c, w)
    Lh, Rh = ribbon_poly(c, lambda u: w(u) * 0.15)
    stem_poly = Polygon(L + R[::-1]).buffer(0)
    leaf_union = unary_union(polys)
    stem = (f'<path d="{pd(L + R[::-1])}" fill="{PG_MID}" stroke="{EDGE}" stroke-width="1.3" stroke-linejoin="round"/>'
            f'<path d="{pd(L + Lh[::-1])}" fill="{PG_HI}" opacity="0.95"/>')
    shadow_g = unary_union(polys + [stem_poly]).simplify(0.4)
    shadow = f'<path class="shadow" d="{gd(shadow_g)}" transform="translate(3,5)" fill="#0B1022" opacity="0.28"/>'
    # stem's soft cast shadow on the leaves it passes over (clipped to the leaves)
    cast = (f'<clipPath id="cLeaves"><path d="{gd(leaf_union.simplify(0.3))}"/></clipPath>'
            f'<path d="{gd(stem_poly)}" transform="translate(2.2,3.4)" fill="#3A2606" opacity="0.38" clip-path="url(#cLeaves)"/>')
    one = f'{shadow}<g class="oak_leaves_behind">{leaves}</g>{cast}<g class="stem">{stem}</g>'
    one_l = one.replace('cLeaves', 'cLeavesL')
    return f'<g id="foliage"><g id="foliage_right">{one}</g><g id="foliage_left" transform="{MIRROR}">{one_l}</g></g>'

def build(variant='A', text=None, as_paths=True):
    parts = [B.defs(), back_fan(), V6.ring(), B.field(), B.mapgroup(variant, foliage()), B.impact(), V6.red_scroll(), crown(), B.sword()]
    if text: parts.append(B.ribbon(text, as_paths))
    title = 'Great Zille' + (f' - {text}' if text else '')
    return (f'<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 1024 1024" width="1024" height="1024">\n'
            f'<title>{title}</title>\n' + '\n'.join(parts) + '\n</svg>\n')

if __name__ == '__main__':
    out = sys.argv[1] if len(sys.argv) > 1 else HERE
    B.foliage(report=False)
    for v, suf in (('A', ''), ('B', '_b')):
        W = lambda n, s: open(os.path.join(out, n + suf + '.svg'), 'w').write(s)
        W('great_zille_logo', build(v))
        W('great_zille_logo_ribbon', build(v, 'GREAT ZILLE', as_paths=False))
        W('great_zille_logo_ribbon_paths', build(v, 'GREAT ZILLE', as_paths=True))
    c = crown_outline(); print('crown bounds', [round(v, 1) for v in c.bounds], 'valid', c.is_valid, 'sword', B.SW, 'impact', B.IX, B.IY)
    # report oak/zille overlap
    polys = []
    cc = B.stem_curve()
    for t, off, L, W_, up in B.OAKS:
        (x, y), a = at(cc, t)
        polys.append(oak_svg(L, W_, x, y, a + off, bend=-0.10 if off > 0 else 0.10)[1])
    u = unary_union(polys)
    print('oak/zille overlap', round(u.intersection(B.zille).area, 1), round(affinity.scale(u, -1, 1, origin=(CX, CY)).intersection(B.zille).area, 1))
