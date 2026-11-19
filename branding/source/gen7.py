#!/usr/bin/env python3
"""Great Zille mod logo v7 - v6 (gen6.py) with:
  * crown re-traced from the Rizia emblem (press-kit screenshots, median of 7 frames, 10x):
    colour-isolation mask -> mirror-symmetrised -> contour (trace/trace_crown.py -> trace/crown_trace.json),
    tall rounded central fleuron with 3 stacked blue jewels, lobed upper leaves, horn leaves curling up
    and out, wavy base tapering to a point - no more boat/bowl;
  * laurel blades slimmed to match Rizia: one row of 8 slender sabre blades per side, fine tips,
    shorter sweep (~25 deg), tips ending around 1 / 11 o'clock like the reference.
Zille, map framing, sword (tip on Zille City), rim and ribbon unchanged.
Run: python3 gen7.py [outdir]
"""
import json, math, os, sys
from shapely.geometry import Polygon, box
from shapely import affinity
HERE = os.path.dirname(os.path.abspath(__file__)); sys.path.insert(0, HERE)
import gen6 as V6
import gen5 as B
from gen5 import CX, CY, R_OUT, R_IN, IX, IY, P, pd, gd, spline, f, MIRROR

# ------------------------------------------------------------------ crown traced from the Rizia emblem
TR = json.load(open(os.path.join(HERE, 'trace', 'crown_trace.json')))
CRN = dict(width=float(os.environ.get('CROWN_W', '230')), top=float(os.environ.get('CROWN_TOP', '150')))
_S = CRN['width'] / (TR['right'] - TR['left'])          # trace px (10x) -> logo px
def _T(x, y): return (CX + x * _S, CRN['top'] + (y - TR['top']) * _S)

def crown_outline():
    outer = [c for c in TR['contours'] if not c['hole']][0]['pts']
    # enforce exact symmetry: keep right half (x>=0) and mirror it
    g = Polygon([_T(x, y) for x, y in outer]).buffer(0)
    right = g.intersection(box(CX, 0, 1024, 1024))
    left = affinity.scale(right, -1, 1, origin=(CX, 0))
    g = right.union(left).buffer(float(os.environ.get('CROWN_GROW', '1.4')), 16)
    return g.simplify(0.3)

def crown():
    g = crown_outline()
    y0, y1 = CRN['top'], CRN['top'] + (TR['bottom'] - TR['top']) * _S
    shade_r = g.intersection(box(CX + 2, 0, 1024, 1024))
    low = g.intersection(box(0, y1 - (y1 - y0) * 0.30, 1024, 1024))
    hi = g.buffer(-3.0, 12)
    jew = ''
    for jy, jx, jr in TR['jewels']:
        x, y = _T(0, jy); r = max(5.2, jr * _S * 1.02)
        jew += (f'<circle cx="{f(x)}" cy="{f(y)}" r="{f(r)}" fill="url(#gJewel)" stroke="#16244A" stroke-width="1.1"/>'
                f'<circle cx="{f(x - r*0.33)}" cy="{f(y - r*0.36)}" r="{f(r*0.28)}" fill="#FFFFFF" opacity="0.8"/>')
    # soft emboss lines (as in the reference): where the upper leaves leave the fleuron, horn mid-ribs
    lines = ''
    for sg in (1, -1):
        def M(pts): return 'M' + ' L'.join(f'{f(CX + sg * (x * _S))},{f(CRN["top"] + (y - TR["top"]) * _S)}' for x, y in spline(pts, 6)) + ' '
        lines += M([(44, 150), (52, 215), (48, 300), (40, 372)])           # fleuron column edge
        lines += M([(120, 380), (190, 350), (250, 290), (292, 205)])        # horn leaf mid-rib
        lines += M([(70, 160), (130, 150), (178, 162)])                     # upper leaf mid-rib
    return f'''<g id="crown" stroke-linejoin="round" stroke-linecap="round">
  <linearGradient id="gCrown7" gradientUnits="userSpaceOnUse" x1="0" y1="{f(y0)}" x2="0" y2="{f(y1)}"><stop offset="0" stop-color="#FCF3C8"/><stop offset="0.55" stop-color="#F0DE9A"/><stop offset="1" stop-color="#DCC072"/></linearGradient>
  <path d="{gd(g)}" transform="translate(3,5)" fill="#0B1022" opacity="0.35"/>
  <path d="{gd(g)}" fill="url(#gCrown7)"/>
  <path d="{gd(low)}" fill="#C9A653" opacity="0.28"/>
  <path d="{gd(shade_r)}" fill="#A8873E" opacity="0.16"/>
  <path d="{gd(hi)}" fill="none" stroke="#FFF9E0" stroke-width="1.4" opacity="0.55"/>
  <path d="{lines}" fill="none" stroke="#B0914A" stroke-width="1.4" opacity="0.45"/>
  <path d="{gd(g)}" fill="none" stroke="#76592A" stroke-width="1.9"/>
  {jew}
</g>'''

# ------------------------------------------------------------------ slimmer laurel blades (single row, as Rizia)
BL_HI, BL, BL_EDGE = '#F7EBBE', '#C2A55F', '#5E4A1E'
BLADES = dict(n=int(os.environ.get('BL_N', '8')), b0=float(os.environ.get('BL_B0', '170')), b1=float(os.environ.get('BL_B1', '62')),
              span=float(os.environ.get('BL_SPAN', '25')), W=float(os.environ.get('BL_W', '26')),
              rb=float(os.environ.get('BL_RB', '-22')), rm=float(os.environ.get('BL_RM', '54')), rt=float(os.environ.get('BL_RT', '33')))
def blade(tb, tt, rb, rm, rt, W, light=BL_HI, dark=BL, edge=BL_EDGE, n=48):
    cl = []
    for i in range(n + 1):
        u = i / n
        th = tb + (tt - tb) * u
        r = (1 - u) ** 2 * rb + 2 * u * (1 - u) * rm + u * u * rt
        cl.append(P(th, r))
    # slim sabre: widest at ~35 %, long fine tip
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
    return (f'<path d="{pd(whole)}" transform="translate(-2,3)" fill="#2A2410" opacity="0.30"/>'
            f'<path d="{pd(whole)}" fill="{dark}" stroke="{edge}" stroke-width="1.3" stroke-linejoin="round"/>'
            f'<path d="{pd(lit)}" fill="{light}"/>')

def back_fan():
    c = BLADES
    bases = [c['b0'] + (c['b1'] - c['b0']) * i / (c['n'] - 1) for i in range(c['n'])]
    stem = spline([P(187, R_OUT + 30), P(181, R_OUT + 20), P(172, R_OUT + 8), P(150, R_OUT - 6), P(100, R_OUT - 8), P(45, R_OUT - 12)], 20)
    L, R = B.ribbon_poly(stem, lambda u: 7 - 4.5 * u)
    end = stem[0]
    stem_svg = (f'<path d="{pd(L + R[::-1])}" fill="#C2A35C" stroke="{BL_EDGE}" stroke-width="1.2"/>'
                f'<ellipse cx="{f(end[0])}" cy="{f(end[1])}" rx="7" ry="4.5" transform="rotate(-58 {f(end[0])} {f(end[1])})" fill="{BL_HI}" stroke="{BL_EDGE}" stroke-width="1.1"/>')
    one = ''
    for i, tb in enumerate(bases):        # upper blades first -> lower blades overlap them (as in Rizia)
        k = i / (c['n'] - 1)
        span = c['span'] * (1 - 0.10 * k)
        one = blade(tb, tb - span, R_OUT + c['rb'], R_OUT + c['rm'], R_OUT + c['rt'], c['W'] * (1 - 0.08 * k)) + one
    one = stem_svg + one
    return f'<g id="back_fan" stroke-linejoin="round"><g id="fan_right">{one}</g><g id="fan_left" transform="{MIRROR}">{one}</g></g>'

def build(variant='A', text=None, as_paths=True):
    parts = [B.defs(), back_fan(), V6.ring(), B.field(), B.mapgroup(variant, B.foliage()), B.impact(), V6.red_scroll(), crown(), B.sword()]
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
    b = crown_outline().bounds
    print('impact', IX, IY, 'crown bounds', [round(v, 1) for v in b], 'sword', B.SW)
