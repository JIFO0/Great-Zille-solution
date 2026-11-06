import json

with open('MultipleChoicePageData.json', 'r', encoding='utf-8') as f:
    pages_data = json.load(f)

with open('MultipleChoiceOptionData.json', 'r', encoding='utf-8') as f:
    options_data = json.load(f)

options_map = {it['NameInDatabase']: it for it in options_data.get('items', [])}

for p in pages_data.get('items', []):
    name = p.get('NameInDatabase', '')
    if 'Wehlen' in name:
        props = p.get('MultipleChoicePageProperties', {})
        print('========================================')
        print(f"PAGE: {name} | Title: {props.get('Title')}")
        for opt_name in props.get('Options', []):
            opt = options_map.get(opt_name, {})
            opt_props = opt.get('MultipleChoiceOptionProperties', {})
            print(f"  * [{opt_name}] '{opt_props.get('Title')}'")
            print(f"      Condition: {opt_props.get('Condition')}")
            print(f"      BarIncrement: {opt_props.get('PanelBarIncrement')}")
            print(f"      Instruction: {opt_props.get('Instruction')}")
