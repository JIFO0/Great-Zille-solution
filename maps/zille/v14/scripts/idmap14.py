"""v13 -> v14 province id mapping (regions/id_mapping_v13_v14.json/.csv) from polygon overlap."""
import pickle, json, csv, collections
O=pickle.load(open('work13/prov13_final.pkl','rb'))['allp']; F=pickle.load(open('work14/prov14_final.pkl','rb')); N=F['allp']
o={c['id']:c for c in O}; n={c['id']:c for c in N}
key=lambda i:(i.split('_')[1].startswith('S'),int(i.split('_')[1].lstrip('S')))
WHY={}
for i in n:
    c=n[i]
    if c['region']=='Derdia': WHY[i]='new: Derdia strip (Yol = impassable city)' if c.get('city')=='Yol' else 'new: Derdia strip'
    elif c['region']=='Wehlen' and c['type']=='land' and c['kind'] in ('cell','city'): WHY[i]='Wehlen re-partitioned (mountains/roads, +4 front provinces, coastal Kratsna/Grodzizg)'
    elif i in F['block']: WHY[i]='Brivane block re-cut along the Zille-Brivane main road'
    elif c.get('lespia_tw_cut'): WHY[i]="sea cut back out of Lespia's territorial waters"
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
    rows.append(dict(v14_id=i,v14_name=c['name'],region=c['region'],status=st,iou_same_id=round(iou,3),
        name_v13=o[i]['name'] if i in o else '',reason=WHY.get(i,''),
        v13_overlaps=[dict(v13_id=j,v13_name=o[j]['name'],share_of_v14=a,share_of_v13=b) for j,a,b in ov]))
v13rows=[]
for j in sorted(o,key=key):
    d=o[j]; to=[]
    for i,c in n.items():
        if c['poly'].intersects(d['poly']):
            a=c['poly'].intersection(d['poly']).area
            if a>0.02*d['poly'].area: to.append((i,round(a/d['poly'].area,3)))
    to.sort(key=lambda t:-t[1]); v13rows.append(dict(v13_id=j,v13_name=d['name'],v14=[dict(v14_id=i,share_of_v13=a) for i,a in to]))
json.dump(dict(note='share_of_v14 = part of the v14 province covered by the v13 province; share_of_v13 = part of the v13 province that went into the v14 province. '
   'Shares <2% are omitted. No v13 id was removed; new ids: Wehlen '+', '.join(F['new_wehlen'])+'; Derdia '+', '.join(F['new_derdia'])+'; Yol '+F['yol']+'.',
   new_wehlen=F['new_wehlen'],new_derdia=F['new_derdia'],yol=F['yol'],v14=rows,v13=v13rows),open('versions/v14/regions/id_mapping_v13_v14.json','w'),indent=1,ensure_ascii=False)
with open('versions/v14/regions/id_mapping_v13_v14.csv','w',newline='') as f:
    w=csv.writer(f); w.writerow(['v14_id','v14_name','v13_name','region','status','iou_same_id','reason','v13_overlaps (id:share_of_v14)'])
    for r in rows: w.writerow([r['v14_id'],r['v14_name'],r['name_v13'],r['region'],r['status'],r['iou_same_id'],r['reason'],' '.join(f"{x['v13_id']}:{x['share_of_v14']}" for x in r['v13_overlaps'])])
print(collections.Counter((r['region'],r['status']) for r in rows))
print('removed v13 ids:',sorted(set(o)-set(n),key=key))
