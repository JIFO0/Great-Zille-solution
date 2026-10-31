"""v12 -> v13 province id mapping (regions/id_mapping_v12_v13.json/.csv) from polygon overlap."""
import pickle, json, csv
O=pickle.load(open('work/prov12_final.pkl','rb'))['allp']; N=pickle.load(open('work13/prov13_final.pkl','rb'))['allp']
o={c['id']:c for c in O}; n={c['id']:c for c in N}
key=lambda i:(i.split('_')[1].startswith('S'),int(i.split('_')[1].lstrip('S')))
rows=[]
for i in sorted(n,key=key):
    c=n[i]; g=c['poly']; ov=[]
    for j,d in o.items():
        if d['poly'].intersects(g):
            a=d['poly'].intersection(g).area
            if a>0.02*g.area: ov.append((j,round(a/g.area,3),round(a/d['poly'].area,3)))
    ov.sort(key=lambda t:-t[1])
    if i in o:
        iou=g.intersection(o[i]['poly']).area/g.union(o[i]['poly']).area
        st='unchanged' if iou>0.97 else ('kept (reshaped)' if ov and ov[0][0]==i and iou>0.6 else 'id reused (new shape)')
    else: iou=0; st='new'
    rows.append(dict(v13_id=i,v13_name=c['name'],region=c['region'],status=st,iou_same_id=round(iou,3),
        v12_overlaps=[dict(v12_id=j,v12_name=o[j]['name'],share_of_v13=a,share_of_v12=b) for j,a,b in ov]))
v12rows=[]
for j in sorted(o,key=key):
    d=o[j]; to=[]
    for i,c in n.items():
        if c['poly'].intersects(d['poly']):
            a=c['poly'].intersection(d['poly']).area
            if a>0.02*d['poly'].area: to.append((i,round(a/d['poly'].area,3)))
    to.sort(key=lambda t:-t[1]); v12rows.append(dict(v12_id=j,v12_name=d['name'],v13=[dict(v13_id=i,share_of_v12=a) for i,a in to]))
BRENAS_NOTE=('v13 review 1 (owner request): the whole Brenas region was re-partitioned (roads/relief aware, nothing across the Rizia/Zille border, '
 'clear shapes around Marbelas 64). Brenas ids 40-50 and 52-67 were re-assigned to the new cells by largest overlap with the previous v13 cells, '
 'so the same id now covers a similar but NOT identical area (see share_of_v13/share_of_v12). Mave Nortus 23 is unchanged from v13; '
 'Dapalle 51 was enlarged (city-shaped, ~5x the area). No Brenas id was added or removed.')
for r in rows:
    if r['region']=='Brenas': r['brenas_review1_note']='Dapalle enlarged (city)' if r['v13_id']=='ZilleTile_51' else ('unchanged in review 1' if r['v13_id']=='ZilleTile_23' else 're-partitioned in review 1; id kept by overlap')
PRE=pickle.load(open('work13_backup_pre_review1/prov13_final.pkl','rb'))['allp']; pre={c['id']:c for c in PRE}
brenas_pre=[]
for i in sorted([k for k,c in n.items() if c['region']=='Brenas'],key=key):
    g=n[i]['poly']; same=pre.get(i)
    iou=round(g.intersection(same['poly']).area/g.union(same['poly']).area,3) if same else 0
    ov=sorted([(j,round(g.intersection(d['poly']).area/g.area,3)) for j,d in pre.items() if d['region']=='Brenas' and d['poly'].intersects(g)],key=lambda t:-t[1])
    brenas_pre.append(dict(id=i,name_now=n[i]['name'],name_before=same['name'] if same else '',iou_same_id_vs_pre_review1=iou,
        overlaps_pre_review1=[dict(id=j,share_of_now=a) for j,a in ov if a>=0.05]))
json.dump(dict(brenas_vs_v13_pre_review1=brenas_pre,brenas_note=BRENAS_NOTE,note='share_of_v13 = part of the v13 province covered by the v12 province; share_of_v12 = part of the v12 province that went into the v13 province. '
   'Shares <2% are omitted (borders/gaps moved slightly).',v13=rows,v12=v12rows),open('versions/v13/regions/id_mapping_v12_v13.json','w'),indent=1,ensure_ascii=False)
with open('versions/v13/regions/id_mapping_v12_v13.csv','w',newline='') as f:
    w=csv.writer(f); w.writerow(['v13_id','v13_name','region','status','iou_same_id','v12_overlaps (id:share_of_v13)','brenas_review1_note'])
    for r in rows: w.writerow([r['v13_id'],r['v13_name'],r['region'],r['status'],r['iou_same_id'],' '.join(f"{x['v12_id']}:{x['share_of_v13']}" for x in r['v12_overlaps']),r.get('brenas_review1_note','')])
import collections; print(collections.Counter((r['region'],r['status']) for r in rows))
for r in rows:
    if r['status']!='unchanged': print(r['v13_id'],r['v13_name'],r['status'],r['iou_same_id'],[(x['v12_id'],x['share_of_v13']) for x in r['v12_overlaps']])
