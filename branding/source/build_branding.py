#!/usr/bin/env python3
"""Render the Great Zille logo SVGs in ../svg into PNGs (../png), a multi-size .ico (../ico)
and the in-game / editor copies. Requires: pip install cairosvg pillow

    python3 branding/source/build_branding.py

Naming:  great_zille_logo[_ribbon][_b]_<size>.png
  (no suffix) = variant A, Zille in white|orange     _b = variant B, Zille in cream gold
  _ribbon     = with the "GREAT ZILLE" ribbon (outlined text, no font needed)
Ribbon versions are only rendered >= 128 px (the lettering is unreadable below that).
"""
import os, shutil
import cairosvg
from PIL import Image

HERE = os.path.dirname(os.path.abspath(__file__))
ROOT = os.path.abspath(os.path.join(HERE, '..', '..'))
SVG = os.path.join(ROOT, 'branding', 'svg')
PNG = os.path.join(ROOT, 'branding', 'png')
ICO = os.path.join(ROOT, 'branding', 'ico')
GAME = os.path.join(ROOT, 'assets', 'branding')          # deployed to Mods/GreatZilleAssets/branding
EDITOR = os.path.join(ROOT, 'editor', 'img')

SIZES = (1024, 512, 256, 128, 64, 32, 16)
SOURCES = {
    'great_zille_logo': 'great_zille_logo',
    'great_zille_logo_b': 'great_zille_logo_b',
    'great_zille_logo_ribbon': 'great_zille_logo_ribbon_paths',
    'great_zille_logo_ribbon_b': 'great_zille_logo_ribbon_paths_b',
}


def main():
    for d in (PNG, ICO, GAME, EDITOR):
        os.makedirs(d, exist_ok=True)
    for name, src in SOURCES.items():
        for s in SIZES:
            if 'ribbon' in name and s < 128:
                continue
            dst = os.path.join(PNG, f'{name}_{s}.png')
            cairosvg.svg2png(url=os.path.join(SVG, src + '.svg'), write_to=dst, output_width=s, output_height=s)

    # multi-size Windows icon (variant A, no ribbon). Large frames are rendered straight from the SVG.
    frames = []
    for s in (256, 128, 64, 48, 32, 24, 16):
        p = os.path.join(ICO, f'_tmp_{s}.png')
        cairosvg.svg2png(url=os.path.join(SVG, 'great_zille_logo.svg'), write_to=p, output_width=s, output_height=s)
        frames.append(Image.open(p).convert('RGBA'))
    frames[0].save(os.path.join(ICO, 'great_zille.ico'), format='ICO', sizes=[(f.width, f.height) for f in frames],
                   append_images=frames[1:])
    for s in (256, 128, 64, 48, 32, 24, 16):
        os.remove(os.path.join(ICO, f'_tmp_{s}.png'))

    # in-game copies (loaded by ZilleBranding.cs)
    for n in ('great_zille_logo_64', 'great_zille_logo_ribbon_512'):
        shutil.copy(os.path.join(PNG, n + '.png'), os.path.join(GAME, n + '.png'))
    shutil.copy(os.path.join(ICO, 'great_zille.ico'), os.path.join(GAME, 'great_zille.ico'))

    # web editor: favicon + header logo
    shutil.copy(os.path.join(ICO, 'great_zille.ico'), os.path.join(EDITOR, 'favicon.ico'))
    shutil.copy(os.path.join(PNG, 'great_zille_logo_64.png'), os.path.join(EDITOR, 'logo-64.png'))
    print('done')


if __name__ == '__main__':
    main()
