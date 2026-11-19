#!/usr/bin/env python3
"""Great Zille mod logo v6 - v5 layout (gen5.py) with:
  * crown re-traced from the Rizia emblem (open leafy lotus crown, tall central point with 3 jewels,
    curled acanthus lobes each side, wide low base sitting on the ring top),
  * darker / richer gold rim,
  * simplified foliage (fewer, larger oak leaves growing from the stems),
  * long, slender, strongly curved laurel blades sweeping up around the ring (two shades).
Sword tip stays exactly on Zille City (province 35 centroid); map framing unchanged.
Run: python3 gen6.py [outdir]
"""
import math, os, sys
from shapely.geometry import Polygon, Point, box
from shapely.ops import unary_union
from shapely import affinity
HERE = os.path.dirname(os.path.abspath(__file__)); sys.path.insert(0, HERE)
import gen5 as B
from gen5 import CX, CY, R_OUT, R_IN, R_DISK, IX, IY, P, pd, gd, spline, xf, f, MIRROR, EDGE

SHOW_RED_SCROLL = os.environ.get('RED', '0') == '1'

# ------------------------------------------------------------------ darker rim palette
RIM_HI, RIM, RIM_LO, RIM_DK, RIM_EDGE = '#E9C875', '#C99A3C', '#9C7226', '#6E4E17', '#4E3810'
def ring():
    return f'''<g id="ring">
  <linearGradient id="gRim" gradientUnits="userSpaceOnUse" x1="{CX-300}" y1="{CY-330}" x2="{CX+300}" y2="{CY+330}"><stop offset="0" stop-color="{RIM_HI}"/><stop offset="0.45" stop-color="{RIM}"/><stop offset="1" stop-color="{RIM_LO}"/></linearGradient>
  <linearGradient id="gRimIn" gradientUnits="userSpaceOnUse" x1="{CX+300}" y1="{CY+330}" x2="{CX-300}" y2="{CY-330}"><stop offset="0" stop-color="#F3DA92"/><stop offset="1" stop-color="{RIM_DK}"/></linearGradient>
  <circle cx="{CX}" cy="{CY}" r="{R_OUT}" fill="url(#gRim)" stroke="{RIM_EDGE}" stroke-width="2"/>
  <circle cx="{CX}" cy="{CY}" r="{R_OUT-7}" fill="none" stroke="#F3D990" stroke-width="2" opacity="0.7"/>
  <circle cx="{CX}" cy="{CY}" r="{R_IN+9}" fill="none" stroke="url(#gRimIn)" stroke-width="10"/>
  <circle cx="{CX}" cy="{CY}" r="{R_IN+3}" fill="none" stroke="{RIM_EDGE}" stroke-width="1.6" opacity="0.9"/>
</g>'''

# ------------------------------------------------------------------ long curved laurel blades (behind the ring)
BL_HI, BL, BL_LO, BL_DK = '#F6E8B6', '#DCC383', '#C2A35C', '#8C7337'
BL2_HI, BL2 = '#D2B46C', '#AA8B46'          # back row (second shade)
BL_EDGE = '#66501F'
def curved_blade(tb, tt, rb, rm, rt, W, light, dark, edge=BL_EDGE, n=40):
    """Sabre blade: centre line from (theta tb, r rb) to (theta tt, r rt) bulging to rm mid-way."""
    cl = []
    for i in range(n + 1):
        u = i / n
        th = tb + (tt - tb) * u
        r = (1 - u) ** 2 * rb + 2 * u * (1 - u) * rm + u * u * rt
        cl.append(P(th, r))
    def w(u): return W / 2 * (math.sin(math.pi * min(1, u ** 0.62)) ** 1.05)
    out, inn = [], []
    for i, (x, y) in enumerate(cl):
        a = cl[max(i - 1, 0)]; b = cl[min(i + 1, n)]
        dx, dy = b[0] - a[0], b[1] - a[1]; l = math.hypot(dx, dy) or 1
        nx, ny = -dy / l, dx / l
        # make n point away from the centre
        if (x - CX) * nx + (y - CY) * ny < 0: nx, ny = -nx, -ny
        ww = w(i / n)
        out.append((x + nx * ww, y + ny * ww)); inn.append((x - nx * ww, y - ny * ww))
    whole = out + inn[::-1]
    lit = out + cl[::-1]
    return (f'<path d="{pd(whole)}" transform="translate(-2,3)" fill="#2A2410" opacity="0.28"/>'
            f'<path d="{pd(whole)}" fill="{dark}" stroke="{edge}" stroke-width="1.3" stroke-linejoin="round"/>'
            f'<path d="{pd(lit)}" fill="{light}"/>'
            f'<path d="{pd(cl[3:-4], False)}" fill="none" stroke="{edge}" stroke-width="1.1" opacity="0.55" stroke-linecap="round"/>')

BLADES = dict(n=8, b0=172, b1=62, span=40, W=44, back_dt=7)
def back_fan():
    c = BLADES
    bases = [c['b0'] + (c['b1'] - c['b0']) * i / (c['n'] - 1) for i in range(c['n'])]
    # stem behind the blades, crossing at the bottom with cut ends (v5)
    stem = spline([P(187, R_OUT + 30), P(181, R_OUT + 20), P(172, R_OUT + 8), P(150, R_OUT - 6), P(100, R_OUT - 8), P(45, R_OUT - 12)], 20)
    L, R = B.ribbon_poly(stem, lambda u: 8 - 5 * u)
    end = stem[0]
    stem_svg = (f'<path d="{pd(L + R[::-1])}" fill="{BL_LO}" stroke="{BL_EDGE}" stroke-width="1.2"/>'
                f'<ellipse cx="{f(end[0])}" cy="{f(end[1])}" rx="8" ry="5" transform="rotate(-58 {f(end[0])} {f(end[1])})" fill="{BL_HI}" stroke="{BL_EDGE}" stroke-width="1.1"/>')
    back = ''; front = ''
    for i, tb in enumerate(bases):          # upper blades first -> lower blades overlap them
        k = i / (c['n'] - 1)
        span = c['span'] * (1 - 0.12 * k)
        back = curved_blade(tb - c['back_dt'], tb - c['back_dt'] - span * 0.92, R_OUT - 34, R_OUT + 70, R_OUT + 10, c['W'] * 0.9, BL2_HI, BL2) + back
        front = curved_blade(tb, tb - span, R_OUT - 34, R_OUT + 78, R_OUT + 4, c['W'], BL_HI, BL) + front
    one = stem_svg + back + front
    return f'<g id="back_fan" stroke-linejoin="round"><g id="fan_right">{one}</g><g id="fan_left" transform="{MIRROR}">{one}</g></g>'

# ------------------------------------------------------------------ simplified foliage: fewer, larger oak leaves
B.OAK_NODES = [(0.17, [(-28, 118), (30, 136)]),
               (0.36, [(-30, 160), (30, 176), (4, 126)]),
               (0.56, [(-26, 146), (26, 158)]),
               (0.71, [(-22, 104), (22, 112)])]
B.OAKS = B.make_oaks()

# ------------------------------------------------------------------ crown traced from the Rizia emblem
CRB = dict(base=292, h=153, s=1.0)   # base y (bottom point), height, scale
# right half outline, x right / y up, from the top of the central point down to the bottom centre
# Traced from the Rizia emblem crown (colour-saturation mask of rizia_ref.png, 4x zoom, k=0.42):
# a low bowl whose ends curl up into horn-like acanthus leaves, carrying a row of five leaf points
# (central tallest, with the 3 jewels), open holes between the points and the bowl.
CROWN_R = [(0, 157), (10, 154), (16, 145), (18, 133), (20, 122), (25, 113),          # central point, notch
           (30, 122), (36, 131), (44, 136), (51, 134), (54, 126), (56, 116), (60, 106),  # inner leaf (broad rounded top), notch
           (65, 113), (71, 121), (78, 125), (84, 121), (87, 112), (90, 102), (95, 93),   # outer leaf, notch
           (104, 99), (116, 106), (127, 112), (134, 107), (134, 96), (128, 86),          # horn (curled leaf tip)
           (120, 72), (110, 52), (93, 33), (70, 17), (44, 6), (20, 1), (0, 0)]           # bowl underside
# holes: bottom follows the bowl's inner edge, scalloped top = leaf tips hanging down
CROWN_HOLES = [[(24, 44), (40, 42), (54, 48), (58, 58), (54, 70), (47, 74), (42, 67), (37, 74), (29, 70), (24, 58)],
               [(70, 58), (86, 64), (98, 76), (94, 84), (87, 82), (81, 86), (73, 78), (68, 68)]]
def crown_outline():
    half = CROWN_R
    pts = half + [(-x, y) for x, y in half[1:-1]][::-1]
    g = Polygon(spline(pts, 8, closed=True)).buffer(0)
    for hp in CROWN_HOLES:
        hole = Polygon(spline(hp, 8, closed=True)).buffer(0)
        for sg in (1, -1):
            g = g.difference(affinity.scale(hole, sg, 1, origin=(0, 0)))
    g = g.buffer(-2.2, 24).buffer(2.2, 24)          # soften the leaf tips
    s = CRB['s']; by = CRB['base']
    return affinity.translate(affinity.scale(g, s, -s, origin=(0, 0)), CX, by)

def crown():
    s = CRB['s']; by = CRB['base']
    def T(x, y): return (CX + x * s, by - y * s)
    g = crown_outline().simplify(0.25)
    shade = g.intersection(box(CX, 0, 1024, 1024))
    lower = g.intersection(box(0, by - 30 * s, 1024, 1024))
    # inner lines: base rim and leaf veins (both sides)
    lines = ''
    for sg in (1, -1):
        def M(pts): return 'M' + ' L'.join(f'{f(CX + sg * x * s)},{f(by - y * s)}' for x, y in pts) + ' '
        lines += M(spline([(16, 34), (52, 42), (82, 62), (108, 86), (118, 94)], 6))   # bowl inner edge
        lines += M(spline([(46, 90), (46, 106), (46, 122)], 6))                      # inner point vein
        lines += M(spline([(26, 111), (25, 96), (29, 76)], 6))                       # leaf divisions (notch -> hole)
        lines += M(spline([(60, 103), (60, 90), (58, 76)], 6))
        lines += M(spline([(94, 90), (90, 86)], 4))
        lines += M(spline([(74, 90), (76, 104), (78, 116)], 6))                      # outer point vein
        lines += M(spline([(98, 64), (114, 82), (124, 96)], 6))                      # horn vein
    base_line = ''
    jewels = ''
    for jy, r in ((122, 6.0), (94, 6.6), (64, 7.2)):
        x, y = T(0, jy)
        jewels += (f'<circle cx="{f(x)}" cy="{f(y)}" r="{r}" fill="url(#gJewel)" stroke="#0E1730" stroke-width="1.2"/>'
                   f'<circle cx="{f(x - r*0.35)}" cy="{f(y - r*0.38)}" r="{f(r*0.3)}" fill="#FFFFFF" opacity="0.85"/>')
    return f'''<g id="crown" stroke-linejoin="round" stroke-linecap="round">
  <linearGradient id="gCrown6" gradientUnits="userSpaceOnUse" x1="0" y1="{f(by-150*s)}" x2="0" y2="{by}"><stop offset="0" stop-color="#FBF4CF"/><stop offset="0.6" stop-color="#EEDC9C"/><stop offset="1" stop-color="#D2B465"/></linearGradient>
  <path d="{gd(g)}" transform="translate(3,5)" fill="#0B1022" opacity="0.32"/>
  <path d="{gd(g)}" fill="url(#gCrown6)"/>
  <path d="{gd(lower)}" fill="#C9A653" opacity="0.35"/>
  <path d="{gd(shade)}" fill="#A8873E" opacity="0.22"/>
  <path d="{lines}" fill="none" stroke="#A88A44" stroke-width="1.6" opacity="0.8"/>
    <path d="{gd(g)}" fill="none" stroke="#5E4A20" stroke-width="2.2"/>
  {jewels}
</g>'''

def red_scroll():
    return B.red_scroll() if SHOW_RED_SCROLL else ''

# ------------------------------------------------------------------ sword: hilt lowered slightly so the crown can sit on the ring top (tip unchanged)
HILT_DY = int(os.environ.get('HILT_DY', '14'))
B.SW = {k: v + HILT_DY for k, v in B.SW.items()}

def build(variant='A', text=None, as_paths=True):
    parts = [B.defs(), back_fan(), ring(), B.field(), B.mapgroup(variant, B.foliage()), B.impact(), red_scroll(), crown(), B.sword()]
    if text: parts.append(B.ribbon(text, as_paths))
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
    print('impact', IX, IY); B.foliage(report=True)
