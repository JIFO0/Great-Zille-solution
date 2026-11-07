import json
import os

BASE_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
DATA_DIR = os.path.join(BASE_DIR, "editor", "data")
CONV_DIR = os.path.join(DATA_DIR, "conversations")
CATALOG_PATH = os.path.join(DATA_DIR, "catalog.json")

# Injected entries specifications
INJECTIONS = [
    {
        "convMatch": "EnT_CouncilBriefing",
        "entries": [
            {
                "id": 99101,
                "actorId": 95,
                "speaker": "Player_Romus",
                "title": "Zille_Turn1_Council_Choice",
                "dialogueText": "Zille must return to our kingdom when the lease expires. I expect the Council to prepare for any contingency—including force if Smolak reneges.",
                "menuText": "\"Zille must return to our kingdom when the lease expires. I expect the Council to prepare for any contingency—including force if Smolak reneges.\"",
                "conditions": "",
                "userScript": "",
                "outgoing": [99102],
                "isPlayer": True,
                "isModInjected": True,
                "isModEdited": True,
                "modNote": "Militarna deklaracja Romusa na naradzie królewskiej w Turze 1"
            },
            {
                "id": 99102,
                "actorId": 68,
                "speaker": "Hugo Toras",
                "title": "Zille_Turn1_Council_Reply",
                "dialogueText": "Your Majesty... the recovery of Zille is close to all our hearts, but the Alliance of Nations holds treaties sacred. Let us pray it does not come to open war.",
                "menuText": "",
                "conditions": "",
                "userScript": "",
                "outgoing": [],
                "isPlayer": False,
                "isModInjected": True,
                "isModEdited": True,
                "modNote": "Odpowiedź Wielkiego Wezyra Hugo Torasa"
            }
        ]
    },
    {
        "convMatch": "SnO_SecurityMilitaryMeeting",
        "entries": [
            {
                "id": 99103,
                "actorId": 95,
                "speaker": "Player_Romus",
                "title": "Zille_Turn1_Military_Choice",
                "dialogueText": "Councilor Azaro, I want the General Staff to begin drawing up contingency operational dossiers for the liberation of Zille.",
                "menuText": "\"Councilor Azaro, I want the General Staff to begin drawing up contingency operational dossiers for the liberation of Zille.\"",
                "conditions": "",
                "userScript": "Variable[\"Zille_Staff_Planning\"] = true;",
                "outgoing": [99104],
                "isPlayer": True,
                "isModInjected": True,
                "isModEdited": True,
                "modNote": "Rozkaz Romusa dla Lucity Azaro dotyczący planów sztabowych inwazji"
            },
            {
                "id": 99104,
                "actorId": 73,
                "speaker": "Lucita Azaro",
                "title": "Zille_Turn1_Military_Reply",
                "dialogueText": "A prudent directive, Your Majesty. House Azaro will quietly assess the Brenas staging grounds and Wehzek redoubts across the river.",
                "menuText": "",
                "conditions": "",
                "userScript": "",
                "outgoing": [],
                "isPlayer": False,
                "isModInjected": True,
                "isModEdited": True,
                "modNote": "Zgoda Lucity Azaro na przygotowanie planów wojskowych"
            }
        ]
    },
    {
        "convMatch": "FPnT_DiplomacyBriefing",
        "entries": [
            {
                "id": 99201,
                "actorId": 95,
                "speaker": "Player_Romus",
                "title": "Zille_War_Ultimatum_Choice",
                "dialogueText": "If Smolak does not return Zille on schedule, we will reclaim our ancestral province by force of arms. The armed forces must be placed on alert.",
                "menuText": "\"If Smolak does not return Zille on schedule, we will reclaim our ancestral province by force of arms. The armed forces must be placed on alert.\"",
                "conditions": "",
                "userScript": "Variable[\"RiziaDLC.CountryRelation_Wehlen_AtWar\"] = true; Variable[\"Zille_War_Alfa\"] = true; Variable[\"Zille_War_Ultimatum_Given\"] = true;",
                "outgoing": [99202],
                "isPlayer": True,
                "isModInjected": True,
                "isModEdited": True,
                "modNote": "Oficjalne ultimatum militarne wobec Wehlen i postawienie armii w stan gotowości"
            },
            {
                "id": 99202,
                "actorId": 70,
                "speaker": "Laurento Esquibel",
                "title": "Zille_War_Ultimatum_Reply",
                "dialogueText": "Your Majesty, an armed invasion of Zille risks triggering a severe diplomatic backlash from the Contanan Security Pact. Nevertheless, the General Staff shall prepare contingency offensive plans should the agreement collapse.",
                "menuText": "",
                "conditions": "",
                "userScript": "",
                "outgoing": [],
                "isPlayer": False,
                "isModInjected": True,
                "isModEdited": True,
                "modNote": "Analiza dyplomatyczna Laurento Esquibela (zagrożenie CSP)"
            }
        ]
    },
    {
        "convMatch": "FPnT_ZilleVisit",
        "entries": [
            {
                "id": 99203,
                "actorId": 95,
                "speaker": "Player_Romus",
                "title": "Zille_Smolak_FaceToFace_Choice",
                "dialogueText": "This is Rizian soil, Wiktor. If you do not leave Zille voluntarily when the lease expires, our tanks will remove you.",
                "menuText": "\"This is Rizian soil, Wiktor. If you do not leave Zille voluntarily when the lease expires, our tanks will remove you.\"",
                "conditions": "",
                "userScript": "Variable[\"Zille_Smolak_Threatened\"] = true;",
                "outgoing": [99204],
                "isPlayer": True,
                "isModInjected": True,
                "isModEdited": True,
                "modNote": "Bezpośrednia groźba czołgami prosto w twarz Wiktora Smolaka na Dniu Przyjaźni"
            },
            {
                "id": 99204,
                "actorId": 77,
                "speaker": "Wiktor Smolak",
                "title": "Zille_Smolak_FaceToFace_Reply",
                "dialogueText": "Threats, Romus? In my own city? Wehlen does not fear your parade-ground uniforms. Just dare to cross that river, and you will see South Merkopa burn!",
                "menuText": "",
                "conditions": "",
                "userScript": "",
                "outgoing": [],
                "isPlayer": False,
                "isModInjected": True,
                "isModEdited": True,
                "modNote": "Furia i odgrażanie się Wiktora Smolaka"
            }
        ]
    },
    {
        "convMatch": "SnO_ZilleSecurityDebrief",
        "entries": [
            {
                "id": 99301,
                "actorId": 95,
                "speaker": "Player_Romus",
                "title": "Zille_Turn3_Mobilize_Choice",
                "dialogueText": "Smolak arranged this bombing to fabricate an excuse to steal Zille! Order the III Corps in Brenas onto full combat footing immediately!",
                "menuText": "\"Smolak arranged this bombing to fabricate an excuse to steal Zille! Order the III Corps in Brenas onto full combat footing immediately!\"",
                "conditions": "",
                "userScript": "Variable[\"Zille_EarlyWar_Triggered\"] = true; Variable[\"Zille_War_Alfa\"] = true;",
                "outgoing": [99302],
                "isPlayer": True,
                "isModInjected": True,
                "isModEdited": True,
                "modNote": "Natychmiastowy rozkaz mobilizacji bojowej III Korpusu po zamachu"
            },
            {
                "id": 99302,
                "actorId": 81,
                "speaker": "Titus Gordion",
                "title": "Zille_Turn3_Mobilize_Reply",
                "dialogueText": "At once, Your Majesty! I will alert War Councilor Azaro and reinforce the border checkpoints. The General Staff will prepare for immediate combat operations.",
                "menuText": "",
                "conditions": "",
                "userScript": "",
                "outgoing": [],
                "isPlayer": False,
                "isModInjected": True,
                "isModEdited": True,
                "modNote": "Titus Gordion potwierdza rozkaz mobilizacji"
            }
        ]
    },
    {
        "convMatch": "FPnT_AlvarezCall",
        "entries": [
            {
                "id": 99401,
                "actorId": 95,
                "speaker": "Player_Romus",
                "title": "Zille_Turn4_Alvarez_Leverage",
                "dialogueText": "Patricio, Smolak is your biggest headache in South Merkopa. If Rizia is to humble him, Lespia must provide intelligence and diplomatic cover at the AN.",
                "menuText": "\"Patricio, Smolak is your biggest headache in South Merkopa. If Rizia is to humble him, Lespia must provide intelligence and diplomatic cover at the AN.\"",
                "conditions": "",
                "userScript": "Variable[\"Zille_LespiaPact_Signed\"] = true;",
                "outgoing": [99402],
                "isPlayer": True,
                "isModInjected": True,
                "isModEdited": True,
                "modNote": "Rozmowa z Patricio Alvarezem: żądanie parasola dyplomatycznego w AN"
            },
            {
                "id": 99402,
                "actorId": 99,
                "speaker": "Patricio Alvarez",
                "title": "Zille_Turn4_Alvarez_Reply",
                "dialogueText": "Ha! You have some spine after all, Romus. I won't send my boys into Wehlen to die for your crown, but my spies will keep you informed, and Lespia will ensure the AN doesn't choke you with sanctions.",
                "menuText": "",
                "conditions": "",
                "userScript": "",
                "outgoing": [],
                "isPlayer": False,
                "isModInjected": True,
                "isModEdited": True,
                "modNote": "Patricio Alvarez obiecuje wywiad i blokowanie sankcji AN"
            }
        ]
    },
    {
        "convMatch": "A_CouncilTalkAboutPales",
        "entries": [
            {
                "id": 99403,
                "actorId": 95,
                "speaker": "Player_Romus",
                "title": "Zille_Turn4_TwoFront_Warning",
                "dialogueText": "If we mobilize against Pales, will our supply networks be able to maintain both frontiers?",
                "menuText": "\"If we mobilize against Pales, will our supply networks be able to maintain both frontiers?\"",
                "conditions": "",
                "userScript": "",
                "outgoing": [99404],
                "isPlayer": True,
                "isModInjected": True,
                "isModEdited": True,
                "modNote": "Pytanie o ryzyko katastrofalnej wojny na dwa fronty"
            },
            {
                "id": 99404,
                "actorId": 80,
                "speaker": "Elena Werner",
                "title": "Zille_Turn4_TwoFront_Reply",
                "dialogueText": "For Dast's sake, Your Majesty, absolutely not without severe economic hemorrhaging. Waging war on Pales while our troops are mobilized against Wehlen would double our fuel burn and bring immediate rationing to the capital.",
                "menuText": "",
                "conditions": "",
                "userScript": "",
                "outgoing": [],
                "isPlayer": False,
                "isModInjected": True,
                "isModEdited": True,
                "modNote": "Elena Werner alarmuje przed drenażem ropy i zapaścią budżetu"
            }
        ]
    },
    {
        "convMatch": "FPnT_ZilleNegotiations",
        "entries": [
            {
                "id": 99801,
                "actorId": 95,
                "speaker": "Player_Romus",
                "title": "Zille_Turn8_WarUltimatum_Choice",
                "dialogueText": "Enough of your extortion, Smolak! The lease has expired. We will not entertain a rigged referendum. The Royal Army is advancing!",
                "menuText": "\"Enough of your extortion, Smolak! The lease has expired. We will not entertain a rigged referendum. The Royal Army is advancing!\"",
                "conditions": "",
                "userScript": "Variable[\"Zille_War_Alfa\"] = true; Variable[\"Zille_Referendum_Broken\"] = true;",
                "outgoing": [99802],
                "isPlayer": True,
                "isModInjected": True,
                "isModEdited": True,
                "modNote": "Zerwanie negocjacji w Turze 8 i rozkaz natychmiastowego ataku"
            },
            {
                "id": 99802,
                "actorId": 77,
                "speaker": "Wiktor Smolak",
                "title": "Zille_Turn8_WarUltimatum_Reply",
                "dialogueText": "You arrogant Toras fool! You will choke on your own blood in the streets of Zille! Valdez, sound the general alarm!",
                "menuText": "",
                "conditions": "",
                "userScript": "",
                "outgoing": [],
                "isPlayer": False,
                "isModInjected": True,
                "isModEdited": True,
                "modNote": "Smolak ogłasza alarm bojowy dla armii Wehlen"
            }
        ]
    }
]

catalog = json.load(open(CATALOG_PATH, encoding="utf-8"))

for item in catalog:
    title = item["title"]
    cid = item["id"]

    # Also mark all entries in MODNEW scenes as isModInjected = True
    if item["modStatus"] == "MODNEW":
        conv_file = os.path.join(CONV_DIR, f"{cid}.json")
        if os.path.exists(conv_file):
            conv_data = json.load(open(conv_file, encoding="utf-8"))
            for e in conv_data.get("entries", []):
                e["isModInjected"] = True
                e["isModEdited"] = True
            with open(conv_file, "w", encoding="utf-8") as f:
                json.dump(conv_data, f, indent=2, ensure_ascii=False)

    for inj in INJECTIONS:
        if inj["convMatch"].lower() in title.lower():
            conv_file = os.path.join(CONV_DIR, f"{cid}.json")
            if not os.path.exists(conv_file):
                continue
            conv_data = json.load(open(conv_file, encoding="utf-8"))

            entries = conv_data.setdefault("entries", [])
            for new_e in inj["entries"]:
                # Check if already exists
                idx = next((i for i, e in enumerate(entries) if e["id"] == new_e["id"]), None)
                if idx is not None:
                    entries[idx] = new_e
                else:
                    entries.append(new_e)

            # Re-sort entries by ID
            entries.sort(key=lambda x: x["id"])
            conv_data["modStatus"] = "MODEDIT"
            conv_data["modNote"] = f"Wstrzyknięto kwestie modowe: {', '.join([e['title'] for e in inj['entries']])}"

            with open(conv_file, "w", encoding="utf-8") as f:
                json.dump(conv_data, f, indent=2, ensure_ascii=False)

            item["modStatus"] = "MODEDIT"
            item["modNote"] = conv_data["modNote"]
            item["entriesCount"] = len(entries)
            print(f"Injected mod entries into {title} (ID {cid})")

with open(CATALOG_PATH, "w", encoding="utf-8") as f:
    json.dump(catalog, f, indent=2, ensure_ascii=False)

print("Finished injecting mod entries into MODEDIT conversations!")
