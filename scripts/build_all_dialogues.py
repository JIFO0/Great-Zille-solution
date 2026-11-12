import os


def cs(s):
    if not s:
        return '""'
    escaped = (
        s.replace('\\', '\\\\')
        .replace('"', '\\"')
        .replace('\r\n', '\\n')
        .replace('\n', '\\n')
        .replace('\r', '\\n')
    )
    return f'"{escaped}"'


# ================= COMMON LUA STATE PREDICATES (MECE & NIL-SAFE) =================
LUCITA_FREE = 'Variable["RiziaDLC.Lucita_Arrested"] ~= true and Variable["RiziaDLC.Lucita_Executed"] ~= true'
LUCITA_GONE = '(Variable["RiziaDLC.Lucita_Arrested"] == true or Variable["RiziaDLC.Lucita_Executed"] == true)'
LUCITA_MARRIED = f'{LUCITA_FREE} and Variable["RiziaDLC.Lucita_Married"] == true'
LUCITA_ROMANCE = (
    f'{LUCITA_FREE} and Variable["RiziaDLC.Lucita_Married"] ~= true '
    'and (Variable["RiziaDLC.Lucita_RomanceHappened"] == true or (Variable["RiziaDLC.Relations_Lucita_Romance"] or 0) > 0)'
)
LUCITA_HOSTILE = (
    f'{LUCITA_FREE} and Variable["RiziaDLC.Lucita_Married"] ~= true '
    'and Variable["RiziaDLC.Lucita_RomanceHappened"] ~= true '
    'and (Variable["RiziaDLC.Relations_Lucita_Romance"] or 0) <= 0 '
    'and (Variable["RiziaDLC.Country_HouseAzaro_Enemy"] == true or Variable["RiziaDLC.Turn06_Council_LucitaOffended"] == true)'
)
LUCITA_NORMAL = (
    f'{LUCITA_FREE} and Variable["RiziaDLC.Lucita_Married"] ~= true '
    'and Variable["RiziaDLC.Lucita_RomanceHappened"] ~= true '
    'and (Variable["RiziaDLC.Relations_Lucita_Romance"] or 0) <= 0 '
    'and Variable["RiziaDLC.Country_HouseAzaro_Enemy"] ~= true '
    'and Variable["RiziaDLC.Turn06_Council_LucitaOffended"] ~= true'
)

HUGO_FREE = 'Variable["RiziaDLC.Hugo_Arrested"] ~= true and Variable["RiziaDLC.Hugo_Executed"] ~= true and Variable["RiziaDLC.Hugo_Resigned"] ~= true'
HUGO_GONE = '(Variable["RiziaDLC.Hugo_Arrested"] == true or Variable["RiziaDLC.Hugo_Executed"] == true or Variable["RiziaDLC.Hugo_Resigned"] == true)'
HUGO_HOSTILE = f'{HUGO_FREE} and Variable["RiziaDLC.Country_HouseToras_Enemy"] == true'
HUGO_NORMAL = f'{HUGO_FREE} and Variable["RiziaDLC.Country_HouseToras_Enemy"] ~= true'
VIZIER_ANGELICA = (
    f'{HUGO_GONE} and Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true '
    'and Variable["RiziaDLC.Angelica_Arrested"] ~= true and Variable["RiziaDLC.Angelica_Executed"] ~= true'
)
VIZIER_SAL = (
    f'{HUGO_GONE} and Variable["RiziaDLC.Council_GrandVizier_Angelica"] ~= true '
    'and Variable["RiziaDLC.Council_GrandVizier_Sal"] == true '
    'and Variable["RiziaDLC.Sal_Arrested"] ~= true and Variable["RiziaDLC.Sal_Executed"] ~= true'
)
VIZIER_LAURENTO = f'{HUGO_GONE} and not ({VIZIER_ANGELICA}) and not ({VIZIER_SAL})'

TADDEUS_FREE = 'Variable["RiziaDLC.Taddeus_Arrested"] ~= true and Variable["RiziaDLC.Taddeus_Executed"] ~= true'
TADDEUS_GONE = '(Variable["RiziaDLC.Taddeus_Arrested"] == true or Variable["RiziaDLC.Taddeus_Executed"] == true)'

TITUS_FREE = 'Variable["RiziaDLC.Titus_Arrested"] ~= true and Variable["RiziaDLC.Titus_Executed"] ~= true'
TITUS_GONE = '(Variable["RiziaDLC.Titus_Arrested"] == true or Variable["RiziaDLC.Titus_Executed"] == true)'

SAL_FREE = 'Variable["RiziaDLC.Sal_Arrested"] ~= true and Variable["RiziaDLC.Sal_Executed"] ~= true'
SAL_GONE = '(Variable["RiziaDLC.Sal_Arrested"] == true or Variable["RiziaDLC.Sal_Executed"] == true)'

ANGELICA_FREE = (
    'Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true '
    'and Variable["RiziaDLC.Angelica_Arrested"] ~= true and Variable["RiziaDLC.Angelica_Executed"] ~= true'
)
ANGELICA_GONE = (
    '(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] ~= true '
    'or Variable["RiziaDLC.Angelica_Arrested"] == true or Variable["RiziaDLC.Angelica_Executed"] == true)'
)

MANUS_FREE = (
    'Variable["RiziaDLC.Manus_Arrested"] ~= true and Variable["RiziaDLC.Manus_Executed"] ~= true '
    'and Variable["RiziaDLC.Manus_Gone"] ~= true and Variable["RiziaDLC.Manus_EarlyExile"] ~= true '
    'and Variable["RiziaDLC.Manus_DiesInWar"] ~= true'
)
MANUS_GONE = (
    '(Variable["RiziaDLC.Manus_Arrested"] == true or Variable["RiziaDLC.Manus_Executed"] == true '
    'or Variable["RiziaDLC.Manus_Gone"] == true or Variable["RiziaDLC.Manus_EarlyExile"] == true '
    'or Variable["RiziaDLC.Manus_DiesInWar"] == true)'
)

TWO_FRONT = '(Variable["RiziaDLC.Pales_War"] == true or Variable["RiziaDLC.Diplomacy_Pales_DeclareWar"] == true or Variable["RiziaDLC.CountryRelation_Pales_AtWar"] == true)'
NO_TWO_FRONT = '(Variable["RiziaDLC.Pales_War"] ~= true and Variable["RiziaDLC.Diplomacy_Pales_DeclareWar"] ~= true and Variable["RiziaDLC.CountryRelation_Pales_AtWar"] ~= true)'

# Foreign aid combinations
L1 = 'Variable["Zille_Lespia_Intel"] == true'
L0 = 'Variable["Zille_Lespia_Intel"] ~= true'
R1 = 'Variable["Zille_Rumburg_Munitions"] == true'
R0 = 'Variable["Zille_Rumburg_Munitions"] ~= true'
D1 = 'Variable["Zille_DerdiaHybridActive"] == true'
D0 = 'Variable["Zille_DerdiaHybridActive"] ~= true'

# Resource & Arsenal Scale Checks (1:1 Vanilla Rizia numbers: <1000 vs >=1000 vs >=2500 weapons!)
EQUIP_OVERFLOW = '(Variable["RiziaDLC.Resources_Military_Equipment"] or 0) >= 2500'
EQUIP_ADEQUATE = '(Variable["RiziaDLC.Resources_Military_Equipment"] or 0) >= 1000 and (Variable["RiziaDLC.Resources_Military_Equipment"] or 0) < 2500'
EQUIP_GE_1000 = '(Variable["RiziaDLC.Resources_Military_Equipment"] or 0) >= 1000'
EQUIP_LOW = '(Variable["RiziaDLC.Resources_Military_Equipment"] or 0) < 1000'
EQUIP_CRIT = '(Variable["RiziaDLC.Resources_Military_Equipment"] or 0) < 500'
EQUIP_MODEST = '(Variable["RiziaDLC.Resources_Military_Equipment"] or 0) >= 500 and (Variable["RiziaDLC.Resources_Military_Equipment"] or 0) < 1000'

BUDGET_RICH = '(Variable["RiziaDLC.Resources_Budget"] or 0) >= 6'
BUDGET_MID = '(Variable["RiziaDLC.Resources_Budget"] or 0) >= 2 and (Variable["RiziaDLC.Resources_Budget"] or 0) < 6'
BUDGET_POOR = '(Variable["RiziaDLC.Resources_Budget"] or 0) < 2'
BUDGET_CAN_SPEND1 = '(Variable["RiziaDLC.Resources_Budget"] or 0) >= 1'
BUDGET_NO_SPEND1 = '(Variable["RiziaDLC.Resources_Budget"] or 0) < 1'
BUDGET_CAN_SPEND2 = '(Variable["RiziaDLC.Resources_Budget"] or 0) >= 2'
BUDGET_NO_SPEND2 = '(Variable["RiziaDLC.Resources_Budget"] or 0) < 2'

ENERGY_HIGH = '(Variable["RiziaDLC.Resources_Energy"] or 0) >= 5'
ENERGY_OK = '(Variable["RiziaDLC.Resources_Energy"] or 0) >= 3 and (Variable["RiziaDLC.Resources_Energy"] or 0) < 5'
ENERGY_LOW = '(Variable["RiziaDLC.Resources_Energy"] or 0) <= 2'
ENERGY_CAN_SPEND1 = '(Variable["RiziaDLC.Resources_Energy"] or 0) >= 1'
ENERGY_NO_SPEND1 = '(Variable["RiziaDLC.Resources_Energy"] or 0) < 1'
AUTH_CAN_SPEND1 = '(Variable["RiziaDLC.Resources_Authority"] or 0) >= 1'
AUTH_NO_SPEND1 = '(Variable["RiziaDLC.Resources_Authority"] or 0) < 1'

# Army, Armor, Fleet & Air Checks
PP_STRONG = '(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true or Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true)'
PP_WEAK = 'Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true'
PP_NOT_WEAK = 'Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] ~= true'

FLEET_STRONG = '(Variable["Zille_Fleet_Total"] or 0) >= 2'
FLEET_WEAK = '(Variable["Zille_Fleet_Total"] or 0) < 2'
TANKS_STRONG = '(Variable["RiziaDLC.Army_Unit_Tank_Total"] or 0) >= 2'
TANKS_WEAK = '(Variable["RiziaDLC.Army_Unit_Tank_Total"] or 0) < 2'
AIR_STRONG = '(Variable["RiziaDLC.Army_Unit_Bomber_Total"] or 0) >= 1 or Variable["RiziaDLC.Policy_RD_Order_BomberPlaneFactory_Completed"] == true'
AIR_WEAK = '(Variable["RiziaDLC.Army_Unit_Bomber_Total"] or 0) <= 0 and Variable["RiziaDLC.Policy_RD_Order_BomberPlaneFactory_Completed"] ~= true'

# Intelligence, Evidence & Diplomatic Context
LESPIA_EVIDENCE = '(Variable["RiziaDLC.Zille_Discovered_LespianInvolvement"] == true or Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true)'
NO_LESPIA_EVIDENCE = '(Variable["RiziaDLC.Zille_Discovered_LespianInvolvement"] ~= true and Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] ~= true)'
WEHLEN_EVIDENCE = 'Variable["RiziaDLC.Wehlen_Zille_SharedEvidence"] == true'
ANY_BOMBING_DOSSIER = f'({LESPIA_EVIDENCE} or {WEHLEN_EVIDENCE})'
NO_BOMBING_DOSSIER = f'(not ({LESPIA_EVIDENCE}) and {WEHLEN_EVIDENCE} ~= true)'

# Accumulated Leverage & Isolated Zille vs Pales Casualties
LEV_HIGH = '(Variable["Zille_Leverage"] or 0) >= 4'
LEV_MID = '(Variable["Zille_Leverage"] or 0) >= 2 and (Variable["Zille_Leverage"] or 0) < 4'
LEV_LOW = '(Variable["Zille_Leverage"] or 0) < 2'
LEV_SUPER = '(Variable["Zille_Leverage"] or 0) >= 5'
LEV_REPARATIONS = '(Variable["Zille_Leverage"] or 0) >= 3'
AN_LEG_HIGH = '(Variable["Zille_AN_Legitimacy"] or 0) >= 3'
BLOCKADE_OR_DERDIA = '(Variable["Zille_NavalBlockadeActive"] == true or Variable["Zille_DerdiaHybridActive"] == true)'

ZILLE_LOW_LOSS = '(Variable["Zille_Phase1_PlayerDead"] or 0) <= 1'
ZILLE_HIGH_LOSS = '(Variable["Zille_Phase1_PlayerDead"] or 0) >= 2'
PALES_CASUALTIES_PRESENT = '((Variable["Zille_Pales_TotalPlayerDead"] or 0) > 0 or Variable["RiziaDLC.Pales_War"] == true or Variable["RiziaDLC.Diplomacy_Pales_DeclareWar"] == true or Variable["RiziaDLC.CountryRelation_Pales_AtWar"] == true)'
NO_PALES_CASUALTIES = '((Variable["Zille_Pales_TotalPlayerDead"] or 0) <= 0 and Variable["RiziaDLC.Pales_War"] ~= true and Variable["RiziaDLC.Diplomacy_Pales_DeclareWar"] ~= true and Variable["RiziaDLC.CountryRelation_Pales_AtWar"] ~= true)'


def generate_war_scenes():
    code = f'''using System;
using System.Collections.Generic;
using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{{
    public static partial class ZilleDialogueSystem
    {{
        // =========================================================================
        // SCENE 1: Turn_Zille_WarPlanning (ID 9987) - WAR PLANNING SESSION
        // Multi-round analytical session:
        // - Arsenal audit (<500 / 500-999 / 1000-2499 / >=2500 weapons)
        // - Army / Tank / Fleet / Bomber force checks
        // - Treasury & Energy condition branches + emergency procurement option
        // - Intelligence dossier & micro-effects building Zille_Leverage / Readiness
        // =========================================================================
        public static void RegisterWarPlanning(DialogueDatabase db)
        {{
            if (db.GetConversation("Turn_Zille_WarPlanning") != null && db.GetConversation("Zille/WarPlanning") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarPlanning;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/WarPlanning";
            conv.ActorID = RomusId;
            conv.ConversantID = LucitaId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, LucitaId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Planning_Atmosphere",
                {cs("Outside the council chamber windows, gray rain lashed against the stone spires of Palas Rezna. An emergency war map of the Brenas-Zille peninsula and the Gulf of Moridia lay unfurled across the mahogany table, weighed down by heavy bronze candleholders and thick equipment ledgers.")}, -1);

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Planning_Open",
                {cs("Your Majesty... We have convened the Crown Council under extraordinary circumstances. Smolak's continued defiance and the escalating tensions in Zille have brought our kingdom to a decisive crossroads.")}, 3,
                {cs(HUGO_NORMAL)});

            AddLine(conv, 102, HugoId, RomusId, "Hugo_Planning_Open_Hostile",
                {cs("Your Majesty. Though relations between the Crown and House Toras have grown strained, the integrity of the realm leaves us no choice but to confront Smolak's continued defiance in Zille.")}, 3,
                {cs(HUGO_HOSTILE)});

            AddLine(conv, 103, LaurentoId, RomusId, "Laurento_Planning_Open_NoHugo",
                {cs("Your Majesty. In the Grand Vizier's absence, we have convened an emergency council. Smolak's continued defiance in Zille has brought our kingdom to a decisive crossroads.")}, 3,
                {cs(HUGO_GONE)});

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);
            AddLink(conv, 1, 103);

            var stanceHub = AddLine(conv, 3, RomusId, HugoId, "Romus_Planning_Posture_Prompt",
                {cs("I looked across the gathered faces of my council, measuring both their counsel and the actual state of the kingdom's arsenals.")});

            stanceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Decisive force
            stanceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11)); // Pragmatic caution
            stanceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12)); // Sovereign legalism

            AddChoice(conv, 10, HugoId, "Posture_Force",
                {cs("\"Over twenty-five years of separation ends here. Prepare the Royal Army to reclaim Zille by arms.\"")},
                {cs("Over twenty-five years of separation ends here. Smolak will not surrender our province through parchment alone. Prepare the Royal Army for the reclamation of Zille.")}, -1,
                {cs("Variable[\"Zille_Planning_Stance\"] = \"Force\"; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;")});

            AddChoice(conv, 11, HugoId, "Posture_Pragmatic",
                {cs("\"Spare me slogans. Audit our weapons, coffers, and fuel before we risk a war with Wehlen.\"")},
                {cs("Spare me slogans and bravado. Give me a ruthless audit of our weapons depots, treasury, energy reserves, and diplomatic standing before we commit our kingdom to war.")}, -1,
                {cs("Variable[\"Zille_Planning_Stance\"] = \"Cautious\"; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")});

            AddChoice(conv, 12, HugoId, "Posture_Legal",
                {cs("\"The 1927 agreement has expired. Rizia will enforce lawful sovereignty against an illegal occupation.\"")},
                {cs("The 1927 agreement has expired. Wehlen's continued garrisoning of Zille is an unlawful foreign occupation, and we will press our full legal claim before the world.")}, -1,
                {cs("Variable[\"Zille_Planning_Stance\"] = \"Legal\"; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 2;")});

            // Dynastic Counsel: Hugo if free, else Laurento
            AddLine(conv, 20, HugoId, RomusId, "Hugo_Dynastic_Warning",
                {cs("Romus... As your uncle and Grand Vizier, remember the weight of history. King Valero signed the 1927 agreement to quell internal upheaval when the throne itself shook. If our divisions stumble across the Brenas-Zille frontier, the prestige of House Toras will take decades to mend.")}, -1,
                {cs(HUGO_FREE)});

            AddLine(conv, 120, LaurentoId, RomusId, "Laurento_Dynastic_Warning",
                {cs("Your Majesty, King Valero signed the 1927 agreement under immense domestic strain; if our armies march across the Brenas-Zille frontier and falter, the Crown's standing across Merkopa will suffer grievously.")}, -1,
                {cs(HUGO_GONE)});

            foreach (int cid in new[] {{ 10, 11, 12 }})
            {{
                AddLink(conv, cid, 20);
                AddLink(conv, cid, 120);
            }}

            // Military appraisal + situational force & equipment check
            AddLine(conv, 21, LucitaId, RomusId, "Lucita_Military_Appraisal_1",
                {cs("Inaction carries its own poison, Your Majesty. General Valdez holds four Wehzek brigades across the peninsula: armor at the rail hub of Wiktrany, two infantry brigades entrenched around Zille City, and a coastal garrison at Munat—all dependent on sea convoys across the Gulf of Moridia.")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 121, TaddeusId, RomusId, "Taddeus_Military_Appraisal",
                {cs("Inaction is the greater peril, Your Majesty. Valdez holds four Wehzek brigades across Wiktrany, Zille City, and Munat, resupplied across the Gulf of Moridia. If we sever his sea lanes and strike hard through Wiktrany, his outer perimeter will crack.")}, -1,
                {cs(f"{LUCITA_GONE} and {TADDEUS_FREE}")});

            AddLine(conv, 122, CarlosId, RomusId, "Carlos_Military_Appraisal",
                {cs("General Valdez commands four Wehzek brigades between Wiktrany, Zille City, and Munat, Your Majesty, supplied across the Gulf of Moridia. Strike decisively before Wehlen reinforces by sea, and his line will buckle.")}, -1,
                {cs(f"{LUCITA_GONE} and {TADDEUS_GONE}")});

            foreach (int prev in new[] {{ 20, 120 }})
            {{
                AddLink(conv, prev, 21);
                AddLink(conv, prev, 121);
                AddLink(conv, prev, 122);
            }}

            // Situational Arsenal & Force Assessment (MECE over Equipment: >=2500 / 1000-2499 / 500-999 / <500)
            AddLine(conv, 210, NarratorId, RomusId, "Arsenal_Appraisal_Overflow",
                {cs("Your Chief Quartermaster opened the thick green ordinance ledger and tapped the figures with quiet confidence. \"Over 2,500 units of military equipment fill the royal arsenals—more than enough rifles, machine guns, and shells to sustain continuous high-intensity assaults.\"")}, -1,
                {cs(EQUIP_OVERFLOW)},
                {cs("Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 2; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")});

            AddLine(conv, 211, NarratorId, RomusId, "Arsenal_Appraisal_Adequate",
                {cs("The ordinance ledger showed between 1,000 and 2,500 units of reserve weapons in our depots. \"Enough to fully equip a determined campaign across Zille, Your Majesty,\" your quartermaster noted, \"provided we avoid reckless attrition.\"")}, -1,
                {cs(EQUIP_ADEQUATE)},
                {cs("Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;")});

            AddLine(conv, 212, NarratorId, RomusId, "Arsenal_Appraisal_Low",
                {cs("The quartermaster frowned at the thin columns in the ledger. \"Our reserve depots hold fewer than 1,000 weapons, Your Majesty—between five hundred and a thousand rifles and artillery pieces. We can open an offensive, yet prolonged combat will strain replacements unless we buy or forge more arms.\"")}, -1,
                {cs(EQUIP_MODEST)});

            AddLine(conv, 213, NarratorId, RomusId, "Arsenal_Appraisal_Critical",
                {cs("A grim hush fell as the quartermaster laid bare the numbers: fewer than 500 weapons remain in strategic storage. \"Your Majesty, marching on Zille with near-empty racks risks exhausting ammunition before our brigades even reach Wiktrany!\"")}, -1,
                {cs(EQUIP_CRIT)},
                {cs("Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) - 1;")});

            foreach (int prev in new[] {{ 21, 121, 122 }})
            {{
                AddLink(conv, prev, 210);
                AddLink(conv, prev, 211);
                AddLink(conv, prev, 212);
                AddLink(conv, prev, 213);
            }}

            // Elena Budget & Energy Assessment (MECE)
            AddLine(conv, 230, ElenaId, RomusId, "Elena_Audit_Rich",
                {cs("Elena Werner reviewed her ledger with rare composure. \"For Dast's sake, at least we do not march as paupers: our treasury holds ample reserves and healthy funding buffers. Even so, heavy mechanized warfare burns diesel and shells ruthlessly, so keep supply corridors disciplined.\"")}, -1,
                {cs(f"{BUDGET_RICH} and {NO_TWO_FRONT}")});

            AddLine(conv, 231, ElenaId, RomusId, "Elena_Audit_Mid",
                {cs("Elena tapped her pen against the ledger. \"Courage does not buy fuel, Your Majesty. Our budget can finance a sharp, localized campaign if we do not let it rot into an endless siege along the northern marshes.\"")}, -1,
                {cs(f"{BUDGET_MID} and {NO_TWO_FRONT}")});

            AddLine(conv, 232, ElenaId, RomusId, "Elena_Audit_TightOrTwoFront",
                {cs("Elena's voice sharpened into urgent alarm. \"For Dast's sake, look at the exchequer! Between stretched treasury reserves, tight fuel margins, and the burden of confronting Pales on the eastern frontier, reckless spending in Zille could push Rizia into wartime rationing and inflation!\"")}, -1,
                {cs(f"({BUDGET_POOR}) or ({TWO_FRONT})")});

            foreach (int aId in new[] {{ 210, 211, 212, 213 }})
            {{
                AddLink(conv, aId, 230);
                AddLink(conv, aId, 231);
                AddLink(conv, aId, 232);
            }}

            // Laurento International Horizon (Two-Front + Bombing Evidence awareness)
            AddLine(conv, 240, LaurentoId, RomusId, "Laurento_Horizon_Standard",
                {cs("Internationally, Chancellor Hegel and United Contana will denounce us at the AN in Konstantium, Kyrute. Yet because the 1927 agreement undeniably lapsed, Prime Minister Alvarez in Perla and the ATO bloc will hesitate to rescue Smolak if we strike quickly and legally.")}, -1,
                {cs(NO_TWO_FRONT)});

            AddLine(conv, 241, LaurentoId, RomusId, "Laurento_Horizon_TwoFront",
                {cs("Diplomatically, we are walking on razor wire, Your Majesty. With hostilities active against Pales, Lespia is already furious with us. Opening a second war in Zille will invite simultaneous hostility from both ATO and the Malenyevist bloc unless we divide our rivals swiftly.")}, -1,
                {cs(TWO_FRONT)});

            foreach (int eId in new[] {{ 230, 231, 232 }})
            {{
                AddLink(conv, eId, 240);
                AddLink(conv, eId, 241);
            }}

            // Titus security note
            AddLine(conv, 25, TitusId, RomusId, "Titus_Security_Estela",
                {cs("Internally, Su Omina and ATA cells inside Zille stand ready to disrupt Wehzek telegraphs. Moreover, the Golden Guard has assigned elite teams to safeguard Queen Mother Estela's modest childhood fishing-district home in Zille the moment our columns enter the city.")}, 30,
                {cs(TITUS_FREE)});

            AddLine(conv, 125, NarratorId, RomusId, "Security_NoTitus",
                {cs("Military intelligence confirmed that loyalist cells inside Zille were poised to sabotage Wehzek signals, and vanguard units carried strict orders to protect Queen Mother Estela's old harbor neighborhood.")}, 30,
                {cs(TITUS_GONE)});

            foreach (int lId in new[] {{ 240, 241 }})
            {{
                AddLink(conv, lId, 25);
                AddLink(conv, lId, 125);
            }}

            // Rich multi-turn Inquiry Hub
            var inquiryHub = AddLine(conv, 30, NarratorId, RomusId, "Planning_Inquiry_Hub",
                {cs("The map table hummed with quiet anticipation. You could probe your commanders' readiness—auditing tanks, warships, and bombers, ordering emergency arms procurement if the treasury permitted, or compiling diplomatic leverage—before calling the Logistics Summit.")});

            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 31));  // Terrain & Force readiness (tanks, ships, planes)
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 32));  // Financial & Energy audit
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 33));  // AN & Foreign Powers
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 34));  // Queen Mother & Zille Underground
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 391)); // Emergency Arms Purchase (conditional: Budget>=1 & Low Equip & not yet bought)
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 393)); // Compile Bombing Evidence Dossier (conditional: Evidence exists & not yet compiled)
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40));  // Conclude Planning

            AddChoice(conv, 31, LucitaId, "Inquire_Lucita_Forces",
                {cs("\"Give me a hard count of our armor, fleet, and air power against Valdez's brigades.\"")},
                {cs("Forget broad optimism—assess our terrain obstacles and give me an honest count of our armor, warships, and air support against Valdez.")}, -1,
                {cs("Variable[\"Zille_Plan_CheckedForces\"] = true;")},
                {cs('Variable["Zille_Plan_CheckedForces"] ~= true')});

            AddLine(conv, 35, LucitaId, RomusId, "Answer_Force_Strong",
                {cs("\"Our mechanized spearhead has strong tank support and the Royal Navy out of Monqiz can contest the Gulf of Moridia cleanly. Once we punch through the coastal marshes around Wiktrany, Valdez cannot contain an amphibious or armored envelopment.\"")}, 30,
                {cs(f"({TANKS_STRONG}) or ({FLEET_STRONG})")},
                {cs("Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;")});

            AddLine(conv, 135, CarlosId, RomusId, "Answer_Force_Lean",
                {cs("\"I will be blunt, Your Majesty: with limited heavy armor or naval escort hulls currently operational, an ambitious amphibious crossing would risk disaster. We must rely on disciplined infantry advances through Wiktrany's marshes and careful artillery concentration.\"")}, 30,
                {cs(f"({TANKS_WEAK}) and ({FLEET_WEAK})")});

            AddLink(conv, 31, 35);
            AddLink(conv, 31, 135);

            AddChoice(conv, 32, ElenaId, "Inquire_Elena_Reserves",
                {cs("\"Elena, detail the exact cost to our treasury and energy grid once Wehlen oil stops flowing.\"")},
                {cs("Elena, calculate the exact damage to our treasury and energy grid once Smolak cuts off Wehlen crude oil deliveries.")}, -1,
                {cs("Variable[\"Zille_Plan_CheckedEcon\"] = true;")},
                {cs('Variable["Zille_Plan_CheckedEcon"] ~= true')});

            AddLine(conv, 36, ElenaId, RomusId, "Answer_Elena_EnergyOK",
                {cs("\"Losing Wehlen crude will tighten our grid noticeably, yet with our current energy buffer we can fuel initial mechanized columns if we pair Brenas granaries with coastal convoys instead of burning diesel on long rail hauls.\"")}, 30,
                {cs(f"not ({ENERGY_LOW})")},
                {cs("Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;")});

            AddLine(conv, 136, ElenaId, RomusId, "Answer_Elena_EnergyLow",
                {cs("\"Frankly, Your Majesty, our energy buffer is already dangerously thin. Once Wehlen cuts the pipelines, armored offensives and naval patrols will face acute rationing unless we secure emergency energy supplies or pick the fuel-sparing Sazon route.\"")}, 30,
                {cs(ENERGY_LOW)});

            AddLink(conv, 32, 36);
            AddLink(conv, 32, 136);

            AddChoice(conv, 33, LaurentoId, "Inquire_Laurento_Powers",
                {cs("\"How will Rumburg, Lespia, Derdia, and Valgsland react when we move?\"")},
                {cs("Map out the diplomatic chessboard: where do Rumburg, Lespia, Derdia, and Valgsland stand if we cross the frontier?")}, 37,
                {cs("Variable[\"Zille_Plan_CheckedDiplo\"] = true;")},
                {cs('Variable["Zille_Plan_CheckedDiplo"] ~= true')});

            AddLine(conv, 37, LaurentoId, RomusId, "Answer_Laurento",
                {cs("\"Your sister-in-law Queen Beatrice in Thornbourgh can shield us at the AN and send heavy 152mm shells if we keep faith with GRACE. Prime Minister Alvarez in Perla despises Smolak enough to sell aerial reconnaissance—unless we are fighting Pales. And Supreme Wiseman Azmal at Naeal will raid Wehlen's southern land frontier if we protect Golcondist pilgrims.\"")}, 30,
                "",
                {cs("Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")});

            AddChoice(conv, 34, TitusId, "Inquire_Titus_Underground",
                {cs("\"Can Su Omina, ATA, and our guardsmen protect Queen Estela's home and Rizian civilians?\"")},
                {cs("How reliable are our loyalist cells inside Zille, and can our vanguard shield Queen Mother Estela's childhood home?")}, -1,
                {cs("Variable[\"Zille_Plan_CheckedSecurity\"] = true;")},
                {cs('Variable["Zille_Plan_CheckedSecurity"] ~= true')});

            AddLine(conv, 38, TitusId, RomusId, "Answer_Titus",
                {cs("\"ATA organizers and Su Omina scouts already watch Valdez's supply piers, Your Majesty. My Golden Guardsmen will drop or ride into the harbor district first to secure the Queen Mother's childhood family house.\"")}, 30,
                {cs(TITUS_FREE)},
                {cs("Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;")});

            AddLine(conv, 138, CarlosId, RomusId, "Answer_Security_NoTitus",
                {cs("\"Our reconnaissance detachments carry strict orders to protect Zille's loyalist neighborhoods and the Queen Mother's childhood family home in the harbor quarter, Your Majesty.\"")}, 30,
                {cs(TITUS_GONE)});

            AddLink(conv, 34, 38);
            AddLink(conv, 34, 138);

            // Emergency Arms Procurement (-1 Budget -> +500 Weapons & +2 Readiness)
            AddChoice(conv, 391, ElenaId, "Order_Emergency_Arms_Procurement",
                {cs("\"Release 1 Budget immediately to procure 500 emergency rifles and artillery shells before mobilization!\"")},
                {cs("Our depots cannot stay below a thousand weapons. Release emergency royal funds immediately to purchase 500 reserve arms and shells before we summon the houses!")}, 392,
                {cs("Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 1; Variable[\"RiziaDLC.Resources_Military_Equipment\"] = (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) + 500; Variable[\"Zille_Emergency_Arms_Bought\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 2;")},
                {cs(f"{BUDGET_CAN_SPEND1} and {EQUIP_LOW} and Variable[\"Zille_Emergency_Arms_Bought\"] ~= true")});

            AddLine(conv, 392, ElenaId, RomusId, "Ack_Emergency_Arms",
                {cs("Elena frowned briefly at the sudden expenditure, then stamped the requisition warrant. \"An expensive rush order, Your Majesty, yet wise: five hundred crates of rifles and shells are rolling toward Brenas depots tonight.\"")}, 30);

            // Compile Bombing Evidence Dossier for Leverage
            AddChoice(conv, 393, LaurentoId, "Compile_Bombing_Dossier",
                {cs("\"Bind our Zille bombing intelligence into a sealed dossier—we will hold it over Wehlen and Lespia alike.\"")},
                {cs("Laurento, bind every intelligence report we possess from the Zille bombing into a sealed royal dossier. We will use that truth as leverage at both Perla and Wraclawitz.")}, 394,
                {cs("Variable[\"Zille_Dossier_Compiled\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;")},
                {cs(f"{ANY_BOMBING_DOSSIER} and Variable[\"Zille_Dossier_Compiled\"] ~= true")});

            AddLine(conv, 394, LaurentoId, RomusId, "Ack_Compile_Dossier",
                {cs("Laurento slipped the black-bound folder into his briefcase with a razor-sharp smile. \"A formidable diplomatic weapon, Your Majesty. Neither Alvarez nor Smolak will bluff cleanly once they see this seal.\"")}, 30);

            AddChoice(conv, 40, HugoId, "Conclude_Planning",
                {cs("\"The operational blueprint is set. Summon the noble houses to the Logistics Summit.\"")},
                {cs("The strategic blueprint is set. Draft the preliminary deployment directives and summon Houses Azaro and Sazon to settle our supply corridors in Brenas.")}, -1,
                {cs("Variable[\"Zille_War_Planning_Done\"] = true; Variable[\"Zille_War_Sentiment\"] = 3;")});

            AddLine(conv, 41, HugoId, RomusId, "Hugo_Planning_Close",
                {cs("\"As your sovereign will decrees, Your Majesty. May Saint Wruhec guide our banners and preserve Rizia.\"")}, -1,
                {cs(HUGO_FREE)});

            AddLine(conv, 141, LaurentoId, RomusId, "Laurento_Planning_Close",
                {cs("\"Your sovereign will is clear, Your Majesty. The foreign ministry will prepare every dispatch for the coming storm.\"")}, -1,
                {cs(HUGO_GONE)});

            AddLink(conv, 40, 41);
            AddLink(conv, 40, 141);

            AddLine(conv, 42, LucitaId, RomusId, "Lucita_Planning_Close",
                {cs("Lucita snapped to attention and saluted crisply. \"The General Staff begins staging at once. Next we break the supply deadlock with House Sazon, Your Majesty.\"")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 142, CarlosId, RomusId, "Carlos_Planning_Close",
                {cs("General Carlos Azaro saluted sharply. \"Staging directives go out tonight, Your Majesty. We await your verdict on the Brenas supply corridors.\"")}, -1,
                {cs(LUCITA_GONE)});

            foreach (int prev in new[] {{ 41, 141 }})
            {{
                AddLink(conv, prev, 42);
                AddLink(conv, prev, 142);
            }}

            AddConversationWithAlias(db, conv, "Zille/WarPlanning", "Turn_Zille_WarPlanning");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected War Planning Session (ID 9987) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 2: Turn_Zille_WarLogisticsDispute (ID 9990) - LOGISTICS DISPUTE
        // Fixed:
        // - Feasibility checks for Budget>=1 (Sazon) vs Credit fallback (<1 Budget)
        // - Feasibility checks for Energy>=1 (Azaro) vs Civilian Rationing fallback (<1 Energy)
        // - Authority>=1 check for Royal Compromise
        // - Fixed missing 33 -> 134 link when Angelica free & Manus gone
        // - Inquiry round + micro-effects for Zille_War_Readiness / AN_Legitimacy
        // =========================================================================
        public static void RegisterWarLogisticsDispute(DialogueDatabase db)
        {{
            if (db.GetConversation("Turn_Zille_WarLogisticsDispute") != null && db.GetConversation("Zille/WarLogisticsDispute") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarLogisticsDispute;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/WarLogisticsDispute";
            conv.ActorID = RomusId;
            conv.ConversantID = LucitaId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, LucitaId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Logistics_Intro_BothSazon",
                {cs("The State Dining Hall of Palas Rezna crackled with noble animosity. Banquet tables had been cleared for logistical ledgers, railway maps, and coastal shipping manifests. Opposite House Azaro's uniformed generals sat Duchess Angelica Sazon and Manus Sazon in dark Brenas velvet.")}, -1,
                {cs(f"{ANGELICA_FREE} and {MANUS_FREE}")});

            AddLine(conv, 101, NarratorId, RomusId, "Logistics_Intro_ManusOnly",
                {cs("The State Dining Hall of Palas Rezna was tense with quiet hostility. Opposite House Azaro's officers sat Manus Sazon alone—his mother, Duchess Angelica, absent from the court.")}, -1,
                {cs(f"{ANGELICA_GONE} and {MANUS_FREE}")});

            AddLine(conv, 102, NarratorId, RomusId, "Logistics_Intro_AngelicaOnly",
                {cs("The State Dining Hall of Palas Rezna crackled with aristocratic tension. Across the ledger-strewn table from House Azaro's officers sat Duchess Angelica Sazon alone, representing Brenas in Manus's absence.")}, -1,
                {cs(f"{ANGELICA_FREE} and {MANUS_GONE}")});

            AddLine(conv, 103, NarratorId, RomusId, "Logistics_Intro_LeonaOnly",
                {cs("The State Dining Hall of Palas Rezna was frigid with mutual suspicion. With both Angelica and Manus Sazon absent, Countess Leona Sazon of Sallabes represented the mercantile houses of Brenas opposite House Azaro's officers.")}, -1,
                {cs(f"{ANGELICA_GONE} and {MANUS_GONE}")});

            foreach (int iId in new[] {{ 1, 101, 102, 103 }})
            {{
                AddLink(conv, 0, iId);
                AddLink(conv, iId, 2);
                AddLink(conv, iId, 104);
            }}

            // Azaro Opener
            AddLine(conv, 2, TaddeusId, RomusId, "Taddeus_Logistics_Opener",
                {cs("Duke Taddeus Azaro slammed his fist beside the coastal highway map. \"Your Majesty, an armored spearhead cannot crawl behind civilian freight timetables! House Azaro demands full military requisition authority over every rail switch, fuel depot, and granary in Brenas!\"")}, -1,
                {cs(TADDEUS_FREE)});

            AddLine(conv, 104, CarlosId, RomusId, "Carlos_Logistics_Opener",
                {cs("Your Majesty. The General Staff cannot maintain offensive tempo while fuel convoys wait behind civilian freight and local rail switches in Brenas. We require full military requisition authority over the province's rail lines, fuel tanks, and grain depots.")}, -1,
                {cs(TADDEUS_GONE)});

            // Sazon Rebuttal
            AddLine(conv, 3, AngelicaId, RomusId, "Angelica_Furious_Rebuttal",
                {cs("Duchess Angelica straightened with icy disdain, rapping a jeweled ring against the oak table. \"Brenas is not an occupied fief for Montaklar's generals to pillage! It is the breadbasket of Rizia and Queen Mother Estela's home province!\"")}, 4,
                {cs(ANGELICA_FREE)});

            AddLine(conv, 4, AngelicaId, RomusId, "Angelica_Furious_Rebuttal_2",
                {cs("\"Your quartermasters are already impounding civilian trucks and threatening our mayors. Strip Brenas bare to feed your tanks, and winter strikes and bread riots will paralyze our towns before your spearheads even reach Wiktrany!\"")}, -1);

            AddLine(conv, 5, ManusId, RomusId, "Manus_Passionate_Proposal",
                {cs("Your Majesty, House Sazon wishes to see our soldiers return victorious—not starved by chaos at their backs. Our merchant syndicates, coastal freighters, and provincial granaries have kept Brenas running for generations. Let our guilds organize rear logistics cleanly without martial extortion.")}, 6,
                {cs(MANUS_FREE)});

            AddLine(conv, 105, LeonaId, RomusId, "Leona_Sazon_Proposal",
                {cs("Countess Leona Sazon adjusted her sable stole coolly. \"Brenas is not a conquered province for Montaklar to strip bare, Your Majesty. Our merchant guilds and coastal shipping syndicates can supply the front cleanly through our granaries and ports without provoking bread riots in Sallabes and Mave Nortus.\"")}, 6,
                {cs(f"{ANGELICA_GONE} and {MANUS_GONE}")});

            foreach (int oId in new[] {{ 2, 104 }})
            {{
                AddLink(conv, oId, 3);
                AddLink(conv, oId, 5);
                AddLink(conv, oId, 105);
            }}

            AddLine(conv, 107, NarratorId, RomusId, "Angelica_ManusGone_Bridge",
                {cs("With Manus absent from the hall, the silence after Angelica's outburst lingered heavy over the table.")}, -1,
                {cs(MANUS_GONE)});

            var e4 = conv.GetDialogueEntry(4);
            e4.outgoingLinks.Clear();
            e4.outgoingLinks.Add(CreateLink(conv.id, 4, 5));
            e4.outgoingLinks.Add(CreateLink(conv.id, 4, 107));

            // Military counter
            AddLine(conv, 6, LucitaId, RomusId, "Lucita_Military_Counter",
                {cs("Councilor Azaro leaned forward, her gaze razor-sharp. \"Guild committees move at the speed of an ox cart! If my armored brigades run dry of diesel and 105mm shells outside Wiktrany waiting for merchant manifests, General Valdez will dismantle them piecemeal!\"")}, 7,
                {cs(LUCITA_FREE)});

            AddLine(conv, 106, CarlosId, RomusId, "Carlos_Military_Counter",
                {cs("General Carlos Azaro tapped his leather portfolio flatly. \"Merchant committees move at the pace of paperwork, Your Majesty. If our forward brigades run dry of diesel and 105mm shells outside Wiktrany, Valdez will tear them apart.\"")}, 7,
                {cs(LUCITA_GONE)});

            AddLink(conv, 5, 6);
            AddLink(conv, 5, 106);
            AddLink(conv, 105, 6);
            AddLink(conv, 105, 106);
            AddLink(conv, 107, 6);
            AddLink(conv, 107, 106);

            // Elena state-aware ledger audit
            AddLine(conv, 7, ElenaId, RomusId, "Elena_Ledger_Audit",
                {cs("Elena Werner adjusted her spectacles and tapped her fountain pen. \"Look at the arithmetic instead of family crests! The Azaro centralized rail plan guarantees rapid ammunition flow, yet running nonstop heavy trains from Montaklar drains refined fuel (-1 Energy) and stresses civilian lines.\"")}, 8);

            AddLine(conv, 8, ElenaId, RomusId, "Elena_Ledger_Audit_2",
                {cs("\"The Sazon syndicate plan uses Brenas granaries and coastal freighters along the Gulf of Moridia, sparing our fuel—but paying the guilds fair transit fees requires direct treasury outlays (-1 Budget). Imposing a joint Crown board avoids favoring either house, though it demands firm royal authority.\"")}, -1);

            AddLine(conv, 9, HugoId, RomusId, "Hugo_Unity_Plea",
                {cs("Hugo Toras shook his head gravely. \"Romus, a kingdom divided against itself will crack before Wiktor Smolak. Weigh both our coffers and our fuel reserves before decreeing your settlement.\"")}, 10,
                {cs(HUGO_FREE)});

            AddLine(conv, 109, LaurentoId, RomusId, "Laurento_Unity_Plea",
                {cs("Laurento folded his hands gravely. \"Smolak hopes to see our noble houses quarrel while his trenches deepen, Your Majesty. Match the logistics structure to what our treasury and energy grid can actually sustain.\"")}, 10,
                {cs(HUGO_GONE)});

            AddLink(conv, 8, 9);
            AddLink(conv, 8, 109);

            var disputeHub = AddLine(conv, 10, NarratorId, RomusId, "Dispute_Hub_Prompt",
                {cs("The entire council fell silent, awaiting your verdict. The supply artery of the southern campaign hung in the balance.")});

            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 10, 11));  // Question Sazon/Azaro feasibility & fuel/budget check
            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 10, 12));  // Inspect two-front Pales rail conflict
            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 10, 20));  // Sazon Paid Subsidies (Budget >= 1)
            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 10, 200)); // Sazon Debt Charter (Budget < 1)
            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 10, 30));  // Azaro Paid Fuel (Energy >= 1)
            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 10, 300)); // Azaro Civilian Rationing (Energy < 1)
            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 10, 40));  // Royal Compromise (Authority >= 1)

            // Analytical interrogation nodes
            AddChoice(conv, 11, ElenaId, "Inquire_Logistics_Numbers",
                {cs("\"Elena, can our treasury, energy grid, and arsenals actually handle what these houses propose?\"")},
                {cs("Elena, give me the unvarnished figures right now: what does our current budget, energy, and equipment inventory dictate?")}, -1,
                {cs("Variable[\"Zille_Logistics_Audited\"] = true;")},
                {cs('Variable["Zille_Logistics_Audited"] ~= true')});

            AddLine(conv, 111, ElenaId, RomusId, "Answer_Logistics_StrongReserves",
                {cs("\"With healthy budget and energy cushions on our books, Your Majesty, you actually enjoy genuine freedom of choice—either subsidies for Sazon freighters or Azaro fuel prioritization are feasible without breaking the home front.\"")}, 10,
                {cs(f"{BUDGET_CAN_SPEND1} and {ENERGY_CAN_SPEND1}")},
                {cs("Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;")});

            AddLine(conv, 112, ElenaId, RomusId, "Answer_Logistics_Strained",
                {cs("\"Honestly, Your Majesty, one or more columns on our ledger sit near zero! If treasury cash is empty, Sazon's syndicates will demand Crown customs pledges costing authority; if energy is exhausted, Azaro trains will force ruthless civilian rationing.\"")}, 10,
                {cs(f"{BUDGET_NO_SPEND1} or {ENERGY_NO_SPEND1}")},
                {cs("Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;")});

            AddLink(conv, 11, 111);
            AddLink(conv, 11, 112);

            AddChoice(conv, 12, LucitaId, "Inquire_Logistics_CrossExamine",
                {cs("\"Wait—what happens to civilian ports and Pales transit if military requisition goes wrong?\"")},
                {cs("Wait: if enemy shells hit our marshaling yards or if Pales ties down rail rolling stock, how does each plan avoid collapse?")}, -1,
                {cs("Variable[\"Zille_Logistics_Examined\"] = true;")},
                {cs('Variable["Zille_Logistics_Examined"] ~= true')});

            AddLine(conv, 120, LucitaId, RomusId, "Answer_CrossExamine_SazonAzaro",
                {cs("\"That is precisely why coastal freighters off Sallabes and redundant Brenas spurs matter, Your Majesty,\" Lucita admitted coolly, \"—so long as military ammunition cars always hold right-of-way over commercial cargo.\"")}, 10,
                {cs(LUCITA_FREE)},
                {cs("Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")});

            AddLine(conv, 122, CarlosId, RomusId, "Answer_CrossExamine_Carlos",
                {cs("\"Decentralized coastal barges protect us against bombed rail bridges, Your Majesty, provided military ammunition trains always hold priority signals.\"")}, 10,
                {cs(LUCITA_GONE)},
                {cs("Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")});

            AddLink(conv, 12, 120);
            AddLink(conv, 12, 122);

            // Option A1: Sazon Funded (requires Budget >= 1)
            AddChoice(conv, 20, ManusId, "Choice_Sazon_Route",
                {cs("\"House Sazon will manage logistics (-1 Budget). Use Brenas granaries and coastal freighters.\"")},
                {cs("We will not crush Brenas to win a war. Release 1 Budget in subsidies so House Sazon's merchant guilds and coastal freighters keep the army supplied and Brenas's cities protected.")}, -1,
                {cs("Variable[\"Zille_Logistics_Route\"] = \"Sazon\"; Variable[\"Zille_Logistics_House\"] = \"Sazon\"; Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 1; Variable[\"RiziaDLC.Country_HouseSazon\"] = (Variable[\"RiziaDLC.Country_HouseSazon\"] or 0) + 2; Variable[\"RiziaDLC.Country_HouseAzaro\"] = (Variable[\"RiziaDLC.Country_HouseAzaro\"] or 0) - 1; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;")},
                {cs(BUDGET_CAN_SPEND1)});

            // Option A2: Sazon Debt Charter (fallback when Budget < 1)
            AddChoice(conv, 200, ManusId, "Choice_Sazon_Debt_Route",
                {cs("\"Our coffers are bare—charter House Sazon on bonded port-customs IOUs (-1 Authority).\"")},
                {cs("Our royal treasury has no spare gold today, yet we still entrust rear supply to House Sazon under bonded port-customs IOUs guaranteed by the Crown.")}, -1,
                {cs("Variable[\"Zille_Logistics_Route\"] = \"Sazon\"; Variable[\"Zille_Logistics_House\"] = \"Sazon\"; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) - 1; Variable[\"RiziaDLC.Country_HouseSazon\"] = (Variable[\"RiziaDLC.Country_HouseSazon\"] or 0) + 1; Variable[\"RiziaDLC.Country_HouseAzaro\"] = (Variable[\"RiziaDLC.Country_HouseAzaro\"] or 0) - 1;")},
                {cs(BUDGET_NO_SPEND1)});

            AddLine(conv, 21, ManusId, RomusId, "Ack_Sazon_Manus",
                {cs("\"Thank you, Your Majesty!\" Manus bowed with genuine reverence. \"House Sazon will mobilize our finest grain syndicates and coastal freighters across the gulf. Brenas will stand firm behind our soldiers.\"")}, -1,
                {cs(MANUS_FREE)});

            AddLine(conv, 121, LeonaId, RomusId, "Ack_Sazon_Leona",
                {cs("Countess Leona inclined her head with poised gratitude. \"A prudent decree, Your Majesty. Our Brenas syndicates will keep the front supplied without bleeding the towns dry.\"")}, -1,
                {cs(f"{MANUS_GONE} and {ANGELICA_GONE}")});

            AddLine(conv, 22, AngelicaId, RomusId, "Ack_Sazon_Angelica",
                {cs("Duchess Angelica lifted her chin proudly. \"A sovereign judgment worthy of Porte Drazon, Your Majesty. Brenas will stand as an unbreakable bastion at your rear.\"")}, -1,
                {cs(ANGELICA_FREE)});

            AddLine(conv, 23, TaddeusId, RomusId, "Ack_Sazon_Taddeus",
                {cs("Duke Taddeus tossed his gloves onto the oak table with visible disgust. \"Pray, Your Majesty, that when Valdez's tanks counter-attack, merchant freighters deliver shells as promptly as they deliver tax exemptions.\"")}, -1,
                {cs(TADDEUS_FREE)});

            AddLine(conv, 24, LucitaId, RomusId, "Ack_Sazon_Lucita",
                {cs("Lucita remained disciplined, though her jaw tightened. \"The General Staff will adapt our convoy timetables to the guilds, Your Majesty. We will hold the frontier.\"")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 124, CarlosId, RomusId, "Ack_Sazon_Carlos",
                {cs("General Carlos Azaro exhaled slowly, snapping his ledger shut. \"Very well, Your Majesty. We will adjust our staging timetables to the guild schedules.\"")}, -1,
                {cs(LUCITA_GONE)});

            foreach (int src in new[] {{ 20, 200 }})
            {{
                AddLink(conv, src, 21);
                AddLink(conv, src, 22);
                AddLink(conv, src, 121);
            }}
            AddLink(conv, 21, 22);
            AddLink(conv, 21, 23);
            AddLink(conv, 21, 24);
            AddLink(conv, 21, 124);
            AddLink(conv, 22, 23);
            AddLink(conv, 22, 24);
            AddLink(conv, 22, 124);
            AddLink(conv, 121, 23);
            AddLink(conv, 121, 24);
            AddLink(conv, 121, 124);
            AddLink(conv, 23, 24);
            AddLink(conv, 23, 124);

            // Option B1: Azaro Paid Fuel (requires Energy >= 1)
            AddChoice(conv, 30, LucitaId, "Choice_Azaro_Route",
                {cs("\"Military necessity rules: grant House Azaro full rail and depot requisition (-1 Energy).\"")},
                {cs("Military necessity takes absolute priority. Grant House Azaro full requisition powers over Brenas's rail corridors and allocate 1 Energy to fuel an overwhelming mechanized thrust.")}, -1,
                {cs("Variable[\"Zille_Logistics_Route\"] = \"Azaro\"; Variable[\"Zille_Logistics_House\"] = \"Azaro\"; Variable[\"RiziaDLC.Resources_Energy\"] = (Variable[\"RiziaDLC.Resources_Energy\"] or 0) - 1; Variable[\"RiziaDLC.Country_HouseAzaro\"] = (Variable[\"RiziaDLC.Country_HouseAzaro\"] or 0) + 2; Variable[\"RiziaDLC.Country_HouseSazon\"] = (Variable[\"RiziaDLC.Country_HouseSazon\"] or 0) - 2; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 2;")},
                {cs(ENERGY_CAN_SPEND1)});

            // Option B2: Azaro Civilian Rationing (fallback when Energy < 1)
            AddChoice(conv, 300, LucitaId, "Choice_Azaro_Rationing",
                {cs("\"Our energy grid is empty—order forced civilian fuel rationing so Azaro's tanks roll (-1 Authority).\"")},
                {cs("Our strategic energy reserve is exhausted, yet the spearheads must move. Impose emergency civilian fuel rationing in Brenas and hand rail priority to House Azaro.")}, -1,
                {cs("Variable[\"Zille_Logistics_Route\"] = \"Azaro\"; Variable[\"Zille_Logistics_House\"] = \"Azaro\"; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) - 1; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) - 1; Variable[\"RiziaDLC.Country_HouseAzaro\"] = (Variable[\"RiziaDLC.Country_HouseAzaro\"] or 0) + 1; Variable[\"RiziaDLC.Country_HouseSazon\"] = (Variable[\"RiziaDLC.Country_HouseSazon\"] or 0) - 2; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;")},
                {cs(ENERGY_NO_SPEND1)});

            AddLine(conv, 31, LucitaId, RomusId, "Ack_Azaro_Lucita",
                {cs("Lucita saluted crisply, her eyes shining with decisive pride. \"A command worthy of a warrior king, Your Majesty! Our mechanized spearheads will not lack for shells or diesel. We will shatter Valdez's lines!\"")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 131, CarlosId, RomusId, "Ack_Azaro_Carlos",
                {cs("General Carlos Azaro gave a crisp nod. \"Understood, Your Majesty. Our armored spearheads will roll at full combat tempo.\"")}, -1,
                {cs(LUCITA_GONE)});

            AddLine(conv, 32, TaddeusId, RomusId, "Ack_Azaro_Taddeus",
                {cs("\"Montaklar's divisions stand ready, Your Majesty!\" Taddeus declared firmly. \"Our armored columns will smash straight through Wiktrany!\"")}, -1,
                {cs(TADDEUS_FREE)});

            AddLine(conv, 33, AngelicaId, RomusId, "Ack_Azaro_Angelica",
                {cs("Duchess Angelica rose from her chair, her eyes burning with icy indignation. \"The Crown may seize its trains, Your Majesty. Remember this day when Brenas freezes in winter queues.\"")}, -1,
                {cs(ANGELICA_FREE)});

            AddLine(conv, 34, ManusId, RomusId, "Ack_Azaro_Manus",
                {cs("Manus bowed his head solemnly. \"We will strive to hold civil order in Brenas, Your Majesty. Let your victory be swift enough to justify this hardship.\"")}, -1,
                {cs(MANUS_FREE)});

            AddLine(conv, 134, LeonaId, RomusId, "Ack_Azaro_Leona",
                {cs("Countess Leona rose stiffly. \"The Crown shall have its trains, Your Majesty. I pray our towns endure the winter.\"")}, -1,
                {cs(f"{ANGELICA_GONE} and {MANUS_GONE}")});

            foreach (int src in new[] {{ 30, 300 }})
            {{
                AddLink(conv, src, 31);
                AddLink(conv, src, 131);
            }}
            AddLink(conv, 31, 32);
            AddLink(conv, 31, 33);
            AddLink(conv, 31, 34);
            AddLink(conv, 31, 134);
            AddLink(conv, 131, 32);
            AddLink(conv, 131, 33);
            AddLink(conv, 131, 34);
            AddLink(conv, 131, 134);
            AddLink(conv, 32, 33);
            AddLink(conv, 32, 34);
            AddLink(conv, 32, 134);
            // Fixed: route Angelica (33) cleanly whether Manus is present (34) OR gone (134)!
            AddLink(conv, 33, 34);
            AddLink(conv, 33, 134);

            // Option C: Royal Compromise (requires Authority >= 1)
            AddChoice(conv, 40, ElenaId, "Choice_Compromise_Route",
                {cs("\"Impose a Joint Logistical Board under Elena Werner (-1 Authority). Neither house dominates.\"")},
                {cs("Neither house will dictate to the Crown. I expend royal authority to establish a Joint Logistical Board under Minister Elena Werner—guaranteeing priority munitions rails while Sazon syndicates protect civilian granaries and coastal barges.")}, 41,
                {cs("Variable[\"Zille_Logistics_Route\"] = \"Compromise\"; Variable[\"Zille_Logistics_House\"] = \"Compromise\"; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) - 1; Variable[\"RiziaDLC.Country_HouseAzaro\"] = (Variable[\"RiziaDLC.Country_HouseAzaro\"] or 0) + 1; Variable[\"RiziaDLC.Country_HouseSazon\"] = (Variable[\"RiziaDLC.Country_HouseSazon\"] or 0) + 1; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")},
                {cs(AUTH_CAN_SPEND1)});

            AddLine(conv, 41, ElenaId, RomusId, "Ack_Compromise_Elena",
                {cs("Elena inclined her head with crisp efficiency. \"A balanced solution, Your Majesty. Both fuel and grain supplies will be strictly audited against hoarding or rail bottlenecks.\"")}, -1);

            AddLine(conv, 42, HugoId, RomusId, "Ack_Compromise_Hugo",
                {cs("\"Well reasoned, Romus. Unity between our noble houses is the bedrock of the realm. Glovurius axa Rizia!\"")}, -1,
                {cs(HUGO_FREE)});

            AddLine(conv, 43, LucitaId, RomusId, "Ack_Compromise_Lucita",
                {cs("Lucita nodded with measured professional respect. \"The military accepts this structure, Your Majesty. Our quartermasters will report directly to Minister Werner.\"")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 143, CarlosId, RomusId, "Ack_Compromise_Carlos",
                {cs("General Carlos Azaro inclined his head. \"An orderly compromise, Your Majesty. Our staff will coordinate directly with Minister Werner.\"")}, -1,
                {cs(LUCITA_GONE)});

            AddLink(conv, 41, 42);
            AddLink(conv, 41, 43);
            AddLink(conv, 41, 143);
            AddLink(conv, 42, 43);
            AddLink(conv, 42, 143);

            AddConversationWithAlias(db, conv, "Zille/WarLogisticsDispute", "Turn_Zille_WarLogisticsDispute");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Logistics Dispute (ID 9990) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 3: Turn_Zille_WarBriefing (ID 9988) - ROYAL WAR COUNCIL BRIEFING
        // Adds Naval Blockade preparation check (Fleet>=2 & Energy>=1),
        // Arsenal & Fleet status briefings, Staff Plan feasibility gating, and micro-effects.
        // =========================================================================
        public static void RegisterWarCouncilBriefing(DialogueDatabase db)
        {{
            if (db.GetConversation("Turn_Zille_WarBriefing") != null && db.GetConversation("Zille/WarCouncil_Briefing") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarBriefing;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/WarCouncil_Briefing";
            conv.ActorID = RomusId;
            conv.ConversantID = LucitaId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, LucitaId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Briefing_Atmosphere",
                {cs("Midnight in the War Room of Palas Rezna. Heavy rain beat rhythmically against the stone walls, while inside the air hung thick with coffee, parchment, and gun oil. Across the tactical table lay the relief map of the Zille peninsula, the Strait of Kreleck, and the Gulf of Moridia, brass markers tracking every Wehzek garrison and naval patrol.")}, -1);

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Briefing_Open",
                {cs("Your Majesty... The hour has arrived. Years of diplomatic patience have run dry. Before dawn, the world will learn that Rizia has drawn the sword to reclaim Zille.")}, -1,
                {cs(HUGO_NORMAL)});

            AddLine(conv, 102, HugoId, RomusId, "Hugo_Briefing_Open_Hostile",
                {cs("Your Majesty. Despite the bitter rift between us, I cannot ignore the duty of my office: before dawn, Rizia goes to war for Zille. May God shield the realm from the consequences.")}, -1,
                {cs(HUGO_HOSTILE)});

            AddLine(conv, 103, AngelicaId, RomusId, "Angelica_Vizier_Briefing_Open",
                {cs("Your Majesty. As Grand Vizier, I have reviewed the final mobilization decrees. Before dawn, Rizia moves to reclaim Zille—and with it, the historic wholeness of Brenas.")}, -1,
                {cs(VIZIER_ANGELICA)});

            AddLine(conv, 104, SalId, RomusId, "Sal_Vizier_Briefing_Open",
                {cs("Your Majesty. As Grand Vizier, I pray Saint Wruhec blesses this righteous endeavor. Before dawn, our armies move to restore Zille to the anointed Crown.")}, -1,
                {cs(VIZIER_SAL)});

            AddLine(conv, 105, LaurentoId, RomusId, "Laurento_Briefing_Open_NoHugo",
                {cs("Your Majesty. All ministerial seals are prepared. Within hours, Rizia's armed forces will move to enforce the expiration of the 1927 treaty.")}, -1,
                {cs(VIZIER_LAURENTO)});

            foreach (int hId in new[] {{ 2, 102, 103, 104, 105 }})
            {{
                AddLink(conv, 1, hId);
            }}

            AddLine(conv, 3, NarratorId, RomusId, "Lucita_Narration_Married",
                {cs("Lucita stood at the head of the map table, her field marshal's baton resting across the Brenas frontier. When your eyes met, her severe military demeanor softened with quiet warmth before she addressed the assembly.")}, 4,
                {cs(LUCITA_MARRIED)});
            AddLine(conv, 4, LucitaId, RomusId, "Lucita_Open_Married",
                {cs("My King... and my husband. All divisions are deployed at their staging posts. High command awaits your operational doctrine.")}, -1);

            AddLine(conv, 113, NarratorId, RomusId, "Lucita_Narration_Romance",
                {cs("Lucita looked up from the coastal approaches, her dark eyes flashing with unmistakable warmth before snapping back to disciplined military bearing.")}, 114,
                {cs(LUCITA_ROMANCE)});
            AddLine(conv, 114, LucitaId, RomusId, "Lucita_Open_Romance",
                {cs("Your Majesty... Romus. Our officers stand by their radios along the Brenas frontier and at Monqiz naval base. Operational command is yours to dictate.")}, -1);

            AddLine(conv, 115, LucitaId, RomusId, "Lucita_Open_Hostile",
                {cs("Your Majesty. Whatever grievances stand between the Crown and House Azaro, our officers know their duty. Give your orders.")}, -1,
                {cs(LUCITA_HOSTILE)});

            AddLine(conv, 116, LucitaId, RomusId, "Lucita_Open_Standard",
                {cs("Your Majesty. All divisions of the Royal Army and provincial levies have assumed combat positions along the demarcation line, and the Royal Navy stands ready at Monqiz. We await your final authorization.")}, -1,
                {cs(LUCITA_NORMAL)});

            AddLine(conv, 117, TaddeusId, RomusId, "Taddeus_Open_LucitaGone",
                {cs("Duke Taddeus Azaro stood stiffly beside the relief map, his jaw tight with lingering bitterness over his daughter's fate. \"Your Majesty. The divisions are assembled along the Brenas line and the fleet stands at Monqiz. Specify the doctrine.\"")}, -1,
                {cs(f"{LUCITA_GONE} and {TADDEUS_FREE}")});

            AddLine(conv, 118, CarlosId, RomusId, "Carlos_Open_LucitaGone",
                {cs("General Carlos Azaro stepped forward in Lucita's stead, his expression strictly professional. \"Your Majesty. The General Staff has completed deployment along the Brenas border and at Monqiz. We await your operational orders.\"")}, -1,
                {cs(f"{LUCITA_GONE} and {TADDEUS_GONE}")});

            foreach (int hId in new[] {{ 2, 102, 103, 104, 105 }})
            {{
                AddLink(conv, hId, 3);
                AddLink(conv, hId, 113);
                AddLink(conv, hId, 115);
                AddLink(conv, hId, 116);
                AddLink(conv, hId, 117);
                AddLink(conv, hId, 118);
            }}

            // Laurento Diplomacy + Two-Front check
            AddLine(conv, 5, LaurentoId, RomusId, "Laurento_Briefing_Note",
                {cs("Our diplomatic memorandums are pre-scheduled for the Alliance of Nations in Konstantium, Kyrute—framing this strictly as enforcing the lapsed 1927 treaty.")}, -1,
                {cs(NO_TWO_FRONT)});

            AddLine(conv, 1051, LaurentoId, RomusId, "Laurento_Briefing_TwoFront",
                {cs("I must warn you gravely, Your Majesty: with our forces already fighting Pales on the eastern frontier, opening a second war against Wehlen will alarm both ATO and the Malenyevist bloc in Kyrute.")}, -1,
                {cs(TWO_FRONT)});

            foreach (int prev in new[] {{ 4, 114, 115, 116, 117, 118 }})
            {{
                AddLink(conv, prev, 5);
                AddLink(conv, prev, 1051);
            }}

            // Operational Capability Check (Weapons >=1000 vs <1000 & Fleet >=2 vs <2)
            AddLine(conv, 6, TitusId, RomusId, "Titus_Briefing_Note",
                {cs("The Golden Guard has deployed vanguard security teams along the advance routes, Your Majesty. Valdez's garrison in Zille City has not yet detected our main mechanized assembly.")}, -1,
                {cs(TITUS_FREE)});

            AddLine(conv, 106, CarlosId, RomusId, "Carlos_Security_NoTitus",
                {cs("Forward military intelligence confirms that General Valdez's coastal and border outposts have not yet detected our main concentration, Your Majesty.")}, -1,
                {cs(TITUS_GONE)});

            foreach (int prev in new[] {{ 5, 1051 }})
            {{
                AddLink(conv, prev, 6);
                AddLink(conv, prev, 106);
            }}

            AddLine(conv, 7, NarratorId, RomusId, "Briefing_Arsenal_Fleet_Good",
                {cs("Quartermasters reported over 1,000 reserve weapons ready for immediate frontline replacement, while naval signals from Monqiz confirmed strong warship squadrons poised to contest the Gulf of Moridia.")}, 10,
                {cs(f"{EQUIP_GE_1000} and {FLEET_STRONG}")},
                {cs("Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;")});

            AddLine(conv, 107, NarratorId, RomusId, "Briefing_Arsenal_Good_Fleet_Weak",
                {cs("Quartermasters confirmed over 1,000 reserve weapons stacked in Brenas, yet the Admiralty warned that fewer than two operational capital ships or destroyer groups stand ready at Monqiz—making distant sea landings perilous.")}, 10,
                {cs(f"{EQUIP_GE_1000} and {FLEET_WEAK}")});

            AddLine(conv, 108, NarratorId, RomusId, "Briefing_Arsenal_Low_Warn",
                {cs("The logistics officer lowered his voice uneasily: with fewer than 1,000 reserve weapons in the royal depots, prolonged frontal battles will rapidly exhaust our ammunition reserves unless foreign munitions arrive.")}, 10,
                {cs(EQUIP_LOW)});

            foreach (int prev in new[] {{ 6, 106 }})
            {{
                AddLink(conv, prev, 7);
                AddLink(conv, prev, 107);
                AddLink(conv, prev, 108);
            }}

            var commandHub = AddLine(conv, 10, NarratorId, RomusId, "Command_Hub_Prompt",
                {cs("Across the mahogany table, the operational map awaited your royal seal. Before choosing your command doctrine, you could still order last-hour preparatory measures if our resources permitted.")});

            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 15)); // Optional: Naval Blockade (requires Fleet>=2 & Energy>=1)
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 17)); // Optional: Inspect Naval Readiness if Fleet weak / check AN shield
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 20)); // Romus: Operation Golden Sword
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 30)); // Romus: Operation Golden Ark (Fleet >= 2)
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 35)); // Romus: Operation Golden Ark Reckless (Fleet < 2 warning)
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 40)); // Staff Officers Command
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 50)); // Postpone

            // Pre-battle preparatory action: Naval Blockade across Gulf of Moridia
            AddChoice(conv, 15, LaurentoId, "Choice_Naval_Blockade",
                {cs("\"First, seal the Gulf of Moridia! Dispatch our warships to blockade Valdez's supply convoys (-1 Energy).\"")},
                {cs("Before our infantry moves a meter, sortie our squadrons from Monqiz to blockade the Gulf of Moridia and Strait of Kreleck, choking Valdez's sea supply lines from mainland Wehlen!")}, 16,
                {cs("Variable[\"Zille_NavalBlockadeActive\"] = true; Variable[\"RiziaDLC.Resources_Energy\"] = (Variable[\"RiziaDLC.Resources_Energy\"] or 0) - 1; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;")},
                {cs(f"{FLEET_STRONG} and {ENERGY_CAN_SPEND1} and Variable[\"Zille_NavalBlockadeActive\"] ~= true")});

            AddLine(conv, 16, NarratorId, RomusId, "Ack_Naval_Blockade",
                {cs("Admiralty telegraphs clattered instantly. Within twenty minutes, Monqiz confirmed destroyer flotillas and patrol craft steaming out to seal the Strait of Kreleck against Wehzek cargo steamers.")}, 10);

            AddChoice(conv, 17, LaurentoId, "Choice_AN_Legal_Dispatch",
                {cs("\"Instruct our Konstantium envoy to circulate the 1927 treaty breach dossier before dawn.\"")},
                {cs("Have our ambassadors in Konstantium distribute the legal memorandum on Wehlen's 1927 treaty breach and bombing evidence to every delegation before the first artillery barrage begins.")}, 18,
                {cs("Variable[\"Zille_AN_PreBrief_Sent\"] = true; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 2; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")},
                {cs('Variable["Zille_AN_PreBrief_Sent"] ~= true')});

            AddLine(conv, 18, LaurentoId, RomusId, "Ack_AN_Legal_Dispatch",
                {cs("Laurento nodded with sharp approval. \"Encrypted diplomatic bags are moving to Kyrute immediately, Your Majesty. Smolak will lose the propaganda battle before dawn.\"")}, 10);

            // Operation Golden Sword
            AddChoice(conv, 20, LucitaId, "Choice_Golden_Sword",
                {cs("\"I will command at the War Table: Authorize Operation Golden Sword Phase I.\"")},
                {cs("I will command this campaign myself. Authorize Operation Golden Sword Phase I. Launch our armored spearheads across the Brenas-Zille frontier through Wiktrany toward Zille City and Munat.")}, -1,
                {cs("Variable[\"Zille_War_PlanType\"] = \"Romulus\"; Variable[\"Zille_War_RomulusPlan\"] = \"GoldenSword\"; Variable[\"Zille_War_Active\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;")});

            AddLine(conv, 21, LucitaId, RomusId, "Ack_Golden_Sword_Lucita",
                {cs("\"A glorious doctrine, Your Majesty!\" Lucita's eyes burned with martial pride. \"Our heavy tanks and mechanized brigades will punch straight through Wiktrany. The War Table awaits your deployment for Phase I!\"")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 121, CarlosId, RomusId, "Ack_Golden_Sword_Carlos",
                {cs("General Carlos Azaro saluted crisply. \"The armored spearheads are poised on the Brenas frontier. The War Table awaits your deployment for Phase I, Your Majesty.\"")}, -1,
                {cs(LUCITA_GONE)});

            AddLine(conv, 22, HugoId, RomusId, "Ack_Golden_Sword_Hugo",
                {cs("\"May Saint Wruhec watch over our soldiers, Romus. Glovurius axa Rizia!\"")}, -1,
                {cs(HUGO_FREE)});

            AddLine(conv, 122, LaurentoId, RomusId, "Ack_Golden_Sword_NoHugo",
                {cs("\"Godspeed to our armies, Your Majesty. Our envoys stand ready to defend Rizia's sovereign action.\"")}, -1,
                {cs(HUGO_GONE)});

            AddLink(conv, 20, 21);
            AddLink(conv, 20, 121);
            AddLink(conv, 21, 22);
            AddLink(conv, 21, 122);
            AddLink(conv, 121, 22);
            AddLink(conv, 121, 122);

            // Operation Golden Ark (Fleet >= 2)
            AddChoice(conv, 30, LucitaId, "Choice_Golden_Ark",
                {cs("\"I will command at the War Table: Authorize Operation Golden Ark Phase I (Amphibious Envelopment).\"")},
                {cs("I will lead our forces personally. Authorize Operation Golden Ark Phase I. While border forces pin down Zille's front, our fleet will cross the Gulf of Moridia to strike mainland Wehlen at Kratsna, Rotsla, and Grodzizg!")}, -1,
                {cs("Variable[\"Zille_War_PlanType\"] = \"Romulus\"; Variable[\"Zille_War_RomulusPlan\"] = \"GoldenArk\"; Variable[\"Zille_War_Active\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;")},
                {cs(FLEET_STRONG)});

            // Operation Golden Ark (Fleet < 2 warning variant!)
            AddChoice(conv, 35, LucitaId, "Choice_Golden_Ark_WeakFleet",
                {cs("\"[RISKY — Weak Navy] Authorize Operation Golden Ark anyway across the Gulf of Moridia!\"")},
                {cs("Despite the Admiralty's warnings about our thin naval escorts, I authorize Operation Golden Ark! Load the transports and cross the Gulf of Moridia to sever Wehlen from behind!")}, -1,
                {cs("Variable[\"Zille_War_PlanType\"] = \"Romulus\"; Variable[\"Zille_War_RomulusPlan\"] = \"GoldenArk\"; Variable[\"Zille_War_Active\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) - 2;")},
                {cs(FLEET_WEAK)});

            AddLine(conv, 31, LucitaId, RomusId, "Ack_Golden_Ark_Lucita",
                {cs("\"An audacious maritime stroke!\" Lucita studied the sea lanes intensely. \"Landing across the Gulf of Moridia on mainland Wehlen will shock Smolak's command at its core. The War Table awaits your deployment for Phase I!\"")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 131, CarlosId, RomusId, "Ack_Golden_Ark_Carlos",
                {cs("General Carlos Azaro studied the sea lanes carefully. \"Our amphibious brigades and border screening battalions await your deployment at the War Table, Your Majesty.\"")}, -1,
                {cs(LUCITA_GONE)});

            AddLine(conv, 32, LaurentoId, RomusId, "Ack_Golden_Ark_Laurento",
                {cs("\"Be warned, Your Majesty: striking mainland Wehlen directly across the sea will provoke Valgsland fiercely, so speed at sea will be everything. Godspeed to our fleet.\"")}, -1);

            foreach (int src in new[] {{ 30, 35 }})
            {{
                AddLink(conv, src, 31);
                AddLink(conv, src, 131);
            }}
            AddLink(conv, 31, 32);
            AddLink(conv, 131, 32);

            // Staff Command
            AddChoice(conv, 40, NarratorId, "Choice_Staff_Command",
                {cs("\"The General Staff will direct the campaign. Present the four staff doctrines for execution.\"")},
                {cs("The General Staff will direct the field execution of this war. Present your four strategic doctrines for royal selection.")}, 41,
                {cs("Variable[\"Zille_War_PlanType\"] = \"Staff\";")});

            var staffHub = AddLine(conv, 41, NarratorId, RomusId, "Staff_Doctrine_Presentation",
                {cs("The General Staff laid out four strategic doctrines across the map:\n\n  Plan Hawk: Heavy aerial strikes and artillery barrages shatter Valdez's command network (best with Bomber Wings & >=3 Energy).\n  Plan Sword: Aggressive armored charge through Wiktrany (best with >=2 Tank brigades & loyal House Azaro).\n  Plan Ark: Naval blockade and sea envelopment across the Gulf of Moridia (requires >=2 Warships/Submarines/Flagship).\n  Plan Spear: Covert night decapitation strike against Valdez's HQ (best with expanded Golden Guard / Intel Hub).\n\nWhich staff doctrine do you authorize?")});

            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 42));  // Plan Hawk
            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 43));  // Plan Sword
            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 44));  // Plan Ark (Fleet >= 2)
            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 440)); // Plan Ark Reckless (Fleet < 2)
            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 45));  // Plan Spear

            AddChoice(conv, 42, LucitaId, "Authorize_Staff_Hawk",
                {cs("\"Authorize Plan Hawk: Shatter their forward redoubts with air and artillery power.\"")},
                {cs("I authorize Plan Hawk. Bring down our bomber wings and heavy artillery to flatten their defensive works before our infantry advances.")}, -1,
                {cs("Variable[\"Zille_War_StaffPlan\"] = \"Hawk\"; Variable[\"Zille_War_Active\"] = true;")});

            AddChoice(conv, 43, LucitaId, "Authorize_Staff_Sword",
                {cs("\"Authorize Plan Sword: Unleash our armored divisions in a central breakthrough.\"")},
                {cs("I authorize Plan Sword. Mass our armor and let the Azaro divisions spearhead the breakthrough into Wiktrany.")}, -1,
                {cs("Variable[\"Zille_War_StaffPlan\"] = \"Sword\"; Variable[\"Zille_War_Active\"] = true;")});

            AddChoice(conv, 44, LucitaId, "Authorize_Staff_Ark",
                {cs("\"Authorize Plan Ark: Execute a disciplined maritime blockade and sea encirclement.\"")},
                {cs("I authorize Plan Ark. The Royal Navy will seal the Gulf of Moridia and Strait of Kreleck, cutting off Valdez's sea supply lines.")}, -1,
                {cs("Variable[\"Zille_War_StaffPlan\"] = \"Ark\"; Variable[\"Zille_War_Active\"] = true;")},
                {cs(FLEET_STRONG)});

            AddChoice(conv, 440, LucitaId, "Authorize_Staff_Ark_WeakFleet",
                {cs("\"[RISKY — Few Warships] Authorize Plan Ark anyway: improvise a coastal blockade.\"")},
                {cs("Our fleet at Monqiz is small, yet order Plan Ark nonetheless—harass their coastal freighters with everything that floats!")}, -1,
                {cs("Variable[\"Zille_War_StaffPlan\"] = \"Ark\"; Variable[\"Zille_War_Active\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) - 2;")},
                {cs(FLEET_WEAK)});

            AddChoice(conv, 45, TitusId, "Authorize_Staff_Spear",
                {cs("\"Authorize Plan Spear: Deploy elite commandos and guardsmen to decapitate Valdez's command.\"")},
                {cs("I authorize Plan Spear. Send our finest operatives into Zille tonight to sever Valdez's communications and capture his staff before dawn.")}, -1,
                {cs("Variable[\"Zille_War_StaffPlan\"] = \"Spear\"; Variable[\"Zille_War_Active\"] = true;")});

            AddLine(conv, 46, LucitaId, RomusId, "Ack_Staff_Lucita",
                {cs("\"The orders are dispatched, Your Majesty! The General Staff has launched the offensive and will report front-line progress.\"")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 146, CarlosId, RomusId, "Ack_Staff_Carlos",
                {cs("\"The orders are dispatched, Your Majesty. The General Staff has initiated the offensive.\"")}, -1,
                {cs(LUCITA_GONE)});

            foreach (int chId in new[] {{ 42, 43, 44, 440 }})
            {{
                AddLink(conv, chId, 46);
                AddLink(conv, chId, 146);
            }}

            AddLine(conv, 47, TitusId, RomusId, "Ack_Staff_Titus",
                {cs("\"My guardsmen are already moving under cover of darkness, Your Majesty,\" Titus said quietly, his hand resting firmly over his service sidearm. \"Smolak's officers will wake up in chains.\"")}, -1,
                {cs(TITUS_FREE)});

            AddLine(conv, 147, CarlosId, RomusId, "Ack_Staff_Spear_NoTitus",
                {cs("\"Our special commando detachments are already slipping across the frontier under darkness, Your Majesty. Valdez's headquarters will be blind before dawn.\"")}, -1,
                {cs(TITUS_GONE)});

            AddLink(conv, 45, 47);
            AddLink(conv, 45, 147);

            AddChoice(conv, 50, HugoId, "Choice_Postpone_War",
                {cs("\"Hold the offensive for now. Maintain maximum combat readiness along the border.\"")},
                {cs("Hold the offensive for now. Keep our divisions at maximum combat readiness along the frontier, but do not cross until I give the royal command.")}, -1,
                {cs("Variable[\"Zille_War_Postpone\"] = true;")});

            AddLine(conv, 51, HugoId, RomusId, "Ack_Postpone_Hugo",
                {cs("\"A prudent and measured decision, Your Majesty. The General Staff will maintain full readiness along the frontier.\"")}, -1,
                {cs(HUGO_FREE)});

            AddLine(conv, 151, LaurentoId, RomusId, "Ack_Postpone_NoHugo",
                {cs("\"A measured decision, Your Majesty. Our diplomatic channels remain open while the armed forces hold their positions.\"")}, -1,
                {cs(HUGO_GONE)});

            AddLink(conv, 50, 51);
            AddLink(conv, 50, 151);

            AddConversationWithAlias(db, conv, "Zille/WarCouncil_Briefing", "Turn_Zille_WarBriefing");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected War Council Briefing (ID 9988) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 4: Turn_Zille_MaveNortusHQ (ID 9994) - FRONTLINE HEADQUARTERS
        // Adds:
        // - Separate Zille vs Pales casualty reporting!
        // - Equipment (<1000 vs >=1000) & Fuel inspection in HQ before Phase II
        // - Refugee aid Budget >= 1 check + Military Rations (<1 Budget) fallback
        // - Phase II Tactical Directive choice (Total Pressure vs Controlled Encirclement)
        // =========================================================================
        public static void RegisterMaveNortusHQ(DialogueDatabase db)
        {{
            if (db.GetConversation("Turn_Zille_MaveNortusHQ") != null && db.GetConversation("Zille/MaveNortusHQ") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_MaveNortusHQ;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/MaveNortusHQ";
            conv.ActorID = RomusId;
            conv.ConversantID = TaddeusId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, TaddeusId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "MaveNortus_Arrival",
                {cs("Your armored convoy rumbled through the muddy, rain-slicked streets of Mave Nortus. Across the northern hills, the rhythmic thud of heavy artillery rolled like continuous thunder. Sandbag bunkers lined the crossroads, and wounded soldiers outside the town sanctuary looked up with weary reverence as the royal standard fluttered past.")}, -1);

            AddLine(conv, 2, NarratorId, RomusId, "MaveNortus_Office_Entry",
                {cs("Inside the town hall, tax ledgers lay shoved aside for battlefield telegraphs and grease-pencil maps across the Mayor's oak desk. Duke Taddeus Azaro pointed a scarred finger at the coastal highways while Councilor Lucita Azaro reviewed incoming courier dispatches.")}, 3,
                {cs(f"{TADDEUS_FREE} and {LUCITA_FREE}")});

            AddLine(conv, 102, NarratorId, RomusId, "MaveNortus_Office_Carlos",
                {cs("Inside the town hall, tax ledgers lay shoved aside for battlefield telegraphs and grease-pencil maps. General Carlos Azaro leaned over the coastal highways, conferring briskly with staff officers.")}, 103,
                {cs(f"({TADDEUS_GONE}) or ({LUCITA_GONE})")});

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            AddLine(conv, 3, TaddeusId, RomusId, "Taddeus_HQ_Greeting",
                {cs("Your Majesty! It is an honor to have our King at the front lines. The men took heart the moment the royal motorcade entered Mave Nortus.")}, 4);

            AddLine(conv, 103, CarlosId, RomusId, "Carlos_HQ_Greeting",
                {cs("Your Majesty. Word of your arrival at Mave Nortus has already lifted the spirits of the forward brigades.")}, -1);

            AddLine(conv, 4, LucitaId, RomusId, "Lucita_HQ_Debrief_1",
                {cs("Phase I of our operation has concluded, Your Majesty. General Valdez fought fiercely along the fortified border earthworks and coastal approaches, yet our forward brigades secured crucial staging positions.")}, 5,
                {cs(LUCITA_FREE)});

            AddLine(conv, 5, LucitaId, RomusId, "Lucita_HQ_Debrief_2",
                {cs("Still, the campaign is only half won. Valdez has consolidated his surviving armor into a hardened defensive ring around Zille City and his northern supply ports across the Gulf of Moridia. Phase II must break his spine.")}, 6);

            AddLine(conv, 104, TaddeusId, RomusId, "Taddeus_HQ_Debrief_NoLucita",
                {cs("Phase I is complete, Your Majesty. Valdez contested every kilometer of the coastal highways, and though our forces secured key positions, he has dug his remaining armor into an inner ring around Zille City and the Gulf ports. Phase II must decide it.")}, 6,
                {cs(f"{LUCITA_GONE} and {TADDEUS_FREE}")});

            AddLine(conv, 105, CarlosId, RomusId, "Carlos_HQ_Debrief_BothGone",
                {cs("Phase I is complete, Your Majesty. Valdez's surviving brigades have fallen back into fortified rings around Zille City and his northern supply ports. We need your Phase II directives to finish the campaign.")}, 6,
                {cs(f"{LUCITA_GONE} and {TADDEUS_GONE}")});

            AddLink(conv, 103, 4);
            AddLink(conv, 103, 104);
            AddLink(conv, 103, 105);

            AddLine(conv, 6, NarratorId, RomusId, "Mayor_HQ_Report",
                {cs("The Mayor of Mave Nortus stepped forward nervously, wiping rain and sweat from his brow. \"Your Majesty, over four thousand Rizian refugees have fled south from Zille in the last forty-eight hours. Smolak's retreating officers torched grain silos behind them. Our town is straining to house and feed them.\"")}, 10);

            var hqHub = AddLine(conv, 10, NarratorId, RomusId, "HQ_Hub_Prompt",
                {cs("Distant artillery rumbled once more, sending dust drifting down from the ceiling. You studied the situation map—ready to audit foreign aid, separate front casualties, inspect weapon stockpiles, assist the refugees, or launch Phase II.")});

            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 11));   // Foreign Aid Audit
            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 12));   // Casualties & Morale (Separate Zille vs Pales!)
            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 14));   // Arsenal & Fuel Inspection (<1000 vs >=1000)
            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 13));   // Refugee Relief Paid (-1 Budget, requires Budget >= 1)
            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 113));  // Refugee Relief Army Rations (fallback Budget < 1)
            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 20));   // Phase II: All-Out Push (+Pressure)
            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 25));   // Phase II: Disciplined Envelopment (+AN Legitimacy)

            // Foreign Aid Audit (8 MECE outcomes)
            AddChoice(conv, 11, NarratorId, "Inquire_ForeignAid",
                {cs("\"What reports do we have on foreign assistance and allied support?\"")},
                {cs("What reports do we have regarding foreign assistance? Has our diplomacy yielded tangible support on the battlefield?")}, -1);

            AddLine(conv, 140, NarratorId, RomusId, "Answer_ForeignAid_None",
                {cs("Your staff officers exchanged grim glances. \"No foreign power has committed direct aid to our campaign, Your Majesty. Rizia stands entirely on its own steel, treasury, and courage.\"")}, 10,
                {cs(f"{L0} and {R0} and {D0}")});
            AddLine(conv, 141, NarratorId, RomusId, "Answer_ForeignAid_Lespia",
                {cs("\"High-resolution aerial reconnaissance supplied by Lespia has pinpointed Valdez's camouflaged artillery bunkers behind the Wiktrany lowlands,\" your intelligence officer reported. \"Our gunners already hold the exact coordinates.\"")}, 10,
                {cs(f"{L1} and {R0} and {D0}")},
                {cs("Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")});
            AddLine(conv, 142, NarratorId, RomusId, "Answer_ForeignAid_Rumburg",
                {cs("\"Three freight trains carrying 152mm heavy artillery shells from Rumburg arrived in the Brenas depot this morning,\" your quartermaster reported. \"Our batteries are well stocked for Phase II.\"")}, 10,
                {cs(f"{L0} and {R1} and {D0}")},
                {cs("Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;")});
            AddLine(conv, 143, NarratorId, RomusId, "Answer_ForeignAid_Derdia",
                {cs("\"In the east, Derdian irregulars have raided Wehlen's mainland border depots,\" your intelligence officer reported. \"Valdez has been forced to divert troops away from our front.\"")}, 10,
                {cs(f"{L0} and {R0} and {D1}")},
                {cs("Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")});
            AddLine(conv, 144, NarratorId, RomusId, "Answer_ForeignAid_LespiaRumburg",
                {cs("\"Lespian aerial reconnaissance has mapped Valdez's bunkers behind the Wiktrany lowlands, and three trainloads of heavy 152mm shells from Rumburg arrived in Brenas this morning.\"")}, 10,
                {cs(f"{L1} and {R1} and {D0}")},
                {cs("Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;")});
            AddLine(conv, 145, NarratorId, RomusId, "Answer_ForeignAid_LespiaDerdia",
                {cs("\"Lespian reconnaissance flights have exposed Valdez's hidden batteries, while Derdian irregular raids on Wehlen's southern border have forced him to pull reserves off our front.\"")}, 10,
                {cs(f"{L1} and {R0} and {D1}")},
                {cs("Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")});
            AddLine(conv, 146, NarratorId, RomusId, "Answer_ForeignAid_RumburgDerdia",
                {cs("\"Three freight trains of Rumburgian 152mm shells arrived in Brenas this morning, and Derdian irregulars raiding Wehlen's mainland frontier have pinned down an entire enemy regiment.\"")}, 10,
                {cs(f"{L0} and {R1} and {D1}")},
                {cs("Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;")});
            AddLine(conv, 147, NarratorId, RomusId, "Answer_ForeignAid_All",
                {cs("\"Very tangible, Your Majesty: Lespian reconnaissance photos have revealed Valdez's camouflaged bunkers, three trainloads of Rumburgian 152mm shells arrived in Brenas, and Derdian irregulars raiding Wehlen's border depots have pinned down enemy reserves.\"")}, 10,
                {cs(f"{L1} and {R1} and {D1}")},
                {cs("Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;")});

            for (int aidId = 140; aidId <= 147; aidId++)
            {{
                AddLink(conv, 11, aidId);
            }}

            // Separate Zille vs Pales Casualty Report! (6 MECE outcomes)
            AddChoice(conv, 12, TaddeusId, "Inquire_Casualties",
                {cs("\"Give me the exact Zille casualty ledger—kept strictly separate from any Pales operations.\"")},
                {cs("Give me a frank, strictly separated accounting of our Phase I casualties here in Zille versus any losses on the eastern front against Pales.")}, -1);

            AddLine(conv, 15, TaddeusId, RomusId, "Answer_Casualties_ZilleLow_NoPales",
                {cs("\"Our Zille casualty ledger shows remarkably light brigade losses so far—at most one shattered unit—while our field hospitals have saved most wounded. Because our forces are spared any fighting against Pales, replacements stand ready and morale is soaring!\"")}, 10,
                {cs(f"{TADDEUS_FREE} and {ZILLE_LOW_LOSS} and {NO_PALES_CASUALTIES}")});

            AddLine(conv, 114, TaddeusId, RomusId, "Answer_Casualties_ZilleHigh_NoPales",
                {cs("\"The fighting along the fortified Zille approaches was fierce, Your Majesty—multiple brigades suffered heavy attrition in Phase I. Yet because all casualties are confined strictly to this single Zille ledger with no eastern front draining us, our reserves can still sustain Phase II.\"")}, 10,
                {cs(f"{TADDEUS_FREE} and {ZILLE_HIGH_LOSS} and {NO_PALES_CASUALTIES}")});

            AddLine(conv, 115, TaddeusId, RomusId, "Answer_Casualties_ZilleAndPales",
                {cs("\"I maintain two separate ledgers as ordered, Your Majesty: the Zille front ledger records sharp losses in Phase I, while our separate Pales front ledger accounts for every division lost on the eastern border. With both fronts bleeding manpower and ammunition simultaneously, Phase II must be swift—or stalemate will break us.\"")}, 10,
                {cs(f"{TADDEUS_FREE} and {PALES_CASUALTIES_PRESENT}")});

            AddLine(conv, 116, CarlosId, RomusId, "Answer_Casualties_Carlos_Low",
                {cs("\"Keeping Zille's casualty ledger separate from Pales keeps our planning clean, Your Majesty: Phase I here inflicted light losses on our brigades, and morale remains high for Phase II.\"")}, 10,
                {cs(f"{TADDEUS_GONE} and {ZILLE_LOW_LOSS} and {NO_PALES_CASUALTIES}")});

            AddLine(conv, 117, CarlosId, RomusId, "Answer_Casualties_Carlos_High",
                {cs("\"Our separate Zille front ledger records stiff brigade losses in Phase I along Valdez's coastal works, Your Majesty—though our men remain resolute to reclaim the city.\"")}, 10,
                {cs(f"{TADDEUS_GONE} and {ZILLE_HIGH_LOSS} and {NO_PALES_CASUALTIES}")});

            AddLine(conv, 118, CarlosId, RomusId, "Answer_Casualties_Carlos_TwoFront",
                {cs("\"Keeping our Zille and Pales casualty ledgers strictly separated makes one fact undeniable, Your Majesty: fighting on both fronts strains hospitals and replacements alike. We must strike hard in Phase II to avoid prolonged attrition.\"")}, 10,
                {cs(f"{TADDEUS_GONE} and {PALES_CASUALTIES_PRESENT}")});

            foreach (int cid in new[] {{ 15, 114, 115, 116, 117, 118 }})
            {{
                AddLink(conv, 12, cid);
            }}

            // Arsenal & Fuel Inspection (<1000 vs >=1000 weapons!)
            AddChoice(conv, 14, NarratorId, "Inquire_HQ_ArmoryFuel",
                {cs("\"Inspect our Brenas supply dumps: do we still have enough weapons and fuel for Phase II?\"")},
                {cs("Open the Brenas depot logs: how many reserve weapons and fuel rations remain for Phase II?")}, -1,
                {cs("Variable[\"Zille_HQ_AuditedStock\"] = true;")},
                {cs('Variable["Zille_HQ_AuditedStock"] ~= true')});

            AddLine(conv, 148, NarratorId, RomusId, "Answer_HQ_Stock_Good",
                {cs("\"Over 1,000 reserve rifles and artillery pieces remain stacked in Mave Nortus sidings alongside sufficient diesel, Your Majesty. Our armored columns can sustain a full Phase II breakthrough.\"")}, 10,
                {cs(f"{EQUIP_GE_1000} and not ({ENERGY_LOW})")},
                {cs("Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;")});

            AddLine(conv, 149, NarratorId, RomusId, "Answer_HQ_Stock_Low",
                {cs("\"Dangerously thin, Your Majesty: our reserve weapon stock has dropped under 1,000 units—or our energy reserves sit near minimum! Our generals must focus artillery carefully and avoid costly frontal assaults against intact bunkers.\"")}, 10,
                {cs(f"{EQUIP_LOW} or {ENERGY_LOW}")});

            AddLink(conv, 14, 148);
            AddLink(conv, 14, 149);

            // Refugee Aid: Budget >= 1 vs Fallback when Budget < 1
            AddChoice(conv, 13, NarratorId, "Order_Refugee_Aid",
                {cs("\"Mayor, release 1 Budget for emergency medical aid and grain for every Zille refugee.\"")},
                {cs("Mayor, the Crown immediately releases 1 Budget in emergency funds and grain for every refugee arriving from Zille. No Rizian fleeing Smolak will starve.")}, 16,
                {cs("Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 1; Variable[\"Zille_Refugee_Aid_Granted\"] = true; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 2; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")},
                {cs(f"{BUDGET_CAN_SPEND1} and Variable[\"Zille_Refugee_Aid_Granted\"] ~= true")});

            AddLine(conv, 16, NarratorId, RomusId, "Ack_Refugee_Aid",
                {cs("Tears welled in the Mayor of Mave Nortus's eyes as he pressed his hand over his heart. \"God bless Your Majesty! News of your royal mercy will echo across every town in Brenas and Zille!\"")}, 10);

            AddChoice(conv, 113, NarratorId, "Order_Refugee_Rations",
                {cs("\"The treasury is bare, yet share military field rations and authority mandates to shelter them (-1 Authority).\"")},
                {cs("Our royal treasury lacks spare cash right now, Mayor, yet the Crown still orders quartermasters to share army blankets, field rations, and shelter requisitions with every refugee.")}, 119,
                {cs("Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) - 1; Variable[\"Zille_Refugee_Aid_Granted\"] = true; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;")},
                {cs(f"{BUDGET_NO_SPEND1} and Variable[\"Zille_Refugee_Aid_Granted\"] ~= true")});

            AddLine(conv, 119, NarratorId, RomusId, "Ack_Refugee_Rations",
                {cs("The Mayor bowed gratefully despite the grim hour. \"Sharing the army's own bread with fleeing citizens will be remembered, Your Majesty.\"")}, 10);

            // Launch Phase II (Two strategic directives with distinct micro-effects)
            AddChoice(conv, 20, NarratorId, "Order_Phase2_Launch",
                {cs("\"Issue Phase II Battle Orders: Drive relentlessly through their inner ring and press Wraclawitz!\"")},
                {cs("Valdez will find no respite. Issue Phase II battle orders immediately: mass our artillery, smash their final ring around Zille City, and strike deep so Smolak feels the heat in Wraclawitz!")}, -1,
                {cs("Variable[\"Zille_War_Phase\"] = 2; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2;")});

            AddChoice(conv, 25, NarratorId, "Order_Phase2_Controlled",
                {cs("\"Issue Phase II Battle Orders: Systematic envelopment—liberate Zille while shielding civilians!\"")},
                {cs("Order a disciplined Phase II envelopment! Surround Zille City and Munat methodically, spare civilian districts and Queen Mother Estela's neighborhood from blind shelling, and compel Valdez's garrisons to yield.")}, -1,
                {cs("Variable[\"Zille_War_Phase\"] = 2; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 2; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")});

            AddLine(conv, 21, LucitaId, RomusId, "Ack_Phase2_Lucita",
                {cs("Lucita smiled with fierce, cold resolution, snapping her field baton onto Zille City. \"Phase II orders are dispatched, Your Majesty! Our spearheads move at dawn to deliver Zille back into your royal hands!\"")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 121, CarlosId, RomusId, "Ack_Phase2_Carlos",
                {cs("General Carlos Azaro saluted sharply. \"The Phase II directives are on the wire, Your Majesty. All brigades move at dawn.\"")}, -1,
                {cs(LUCITA_GONE)});

            AddLine(conv, 22, TaddeusId, RomusId, "Ack_Phase2_Taddeus",
                {cs("Taddeus drew his saber and held it aloft in solemn tribute. \"For King and Kingdom! Glovurius axa Rizia! Forward to victory!\"")}, -1,
                {cs(TADDEUS_FREE)});

            foreach (int p2 in new[] {{ 20, 25 }})
            {{
                AddLink(conv, p2, 21);
                AddLink(conv, p2, 121);
            }}
            AddLink(conv, 21, 22);
            AddLink(conv, 121, 22);

            AddConversationWithAlias(db, conv, "Zille/MaveNortusHQ", "Turn_Zille_MaveNortusHQ");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Mave Nortus Field HQ (ID 9994) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 5: Turn_Zille_WarBalconySpeech (ID 9989) - WAR PROCLAMATION SPEECH
        // Two-stage proclamation: Doctrinal theme + Closing Commitment (micro-effects!)
        // =========================================================================
        public static void RegisterWarBalconySpeech(DialogueDatabase db)
        {{
            if (db.GetConversation("Turn_Zille_WarBalconySpeech") != null && db.GetConversation("Zille/WarBalconySpeech") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarBalconySpeech;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/WarBalconySpeech";
            conv.ActorID = RomusId;
            conv.ConversantID = HugoId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, HugoId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Balcony_Intro_1",
                {cs("The grand double doors of the Palas Rezna balcony swung open to the roar of over forty thousand citizens packed across the Royal Plaza. Banners of House Toras, Azaro, and Sazon fluttered in the sea breeze above brass radio microphones carrying your words to every household in Rizia.")}, -1);

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Balcony_Whisper",
                {cs("Hugo leaned in, his voice barely audible beneath the roar. \"Both the realm and foreign embassies hear every syllable, Romus. Choose your message with care.\"")}, 3,
                {cs(HUGO_FREE)});

            AddLine(conv, 102, LaurentoId, RomusId, "Laurento_Balcony_Whisper",
                {cs("Laurento inclined his head beside you. \"Both our citizens and the ambassadors in Konstantium, Kyrute are listening to every word, Your Majesty.\"")}, 3,
                {cs(HUGO_GONE)});

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            var speechHub = AddLine(conv, 3, NarratorId, RomusId, "Speech_Doctrine_Prompt",
                {cs("You stepped up to the stone balustrade and raised your hand. A profound hush settled over the plaza.")});

            speechHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Revanchist Might
            speechHub.outgoingLinks.Add(CreateLink(conv.id, 3, 20)); // Liberating the Oppressed
            speechHub.outgoingLinks.Add(CreateLink(conv.id, 3, 30)); // Sovereign Legalism

            AddChoice(conv, 10, HugoId, "Speech_Revanchist",
                {cs("\"Sons and daughters of Rizia! We march to restore the honor and steel of our ancestors!\"")},
                {cs("Sons and daughters of Rizia! For over twenty-five years, our kingdom bore separation in silence. But House Toras does not bow to dictators! Today our armies march to reclaim our soil by royal steel!")}, 11,
                {cs("Variable[\"Zille_Speech_Tone\"] = \"Revanchist\"; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) - 1;")});

            AddLine(conv, 11, NarratorId, RomusId, "Speech_Revanchist_Reaction",
                {cs("A thunderous roar erupted from the square, bayonets flashing in the sun as guardsmen snapped to salute—while foreign press attachés scribbled furiously about Rizian saber-rattling.")}, 40);

            AddChoice(conv, 20, HugoId, "Speech_Liberation",
                {cs("\"We march not as conquerors, but to bring our brothers and sisters in Zille safely home!\"")},
                {cs("People of Rizia! We march not out of hatred, but out of sacred love for our brothers and sisters in Zille who endured Smolak's secret police and broken promises. Today we bring them home!")}, 21,
                {cs("Variable[\"Zille_Speech_Tone\"] = \"Liberation\"; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")});

            AddLine(conv, 21, NarratorId, RomusId, "Speech_Liberation_Reaction",
                {cs("Tears flowed among the elders in the plaza, and chants of 'Long live King Romus!' rolled down the avenues toward the harbor.")}, 40);

            AddChoice(conv, 30, HugoId, "Speech_Legalist",
                {cs("\"The 1927 agreement has expired. We enforce international law where Smolak trampled it!\"")},
                {cs("Citizens of Rizia and observers across Merkopa: Rizia is a realm of honor and law. The 1927 treaty has expired, and in reclaiming Zille we uphold the sacred legal order Wiktor Smolak trampled underfoot!")}, 31,
                {cs("Variable[\"Zille_Speech_Tone\"] = \"Legalist\"; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 2; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")});

            AddLine(conv, 31, NarratorId, RomusId, "Speech_Legalist_Reaction",
                {cs("Foreign correspondents nodded in sober respect as applause rolled across the square in dignified cadence.")}, 40);

            // Second Stage: Final Pledge from the Balcony
            var closingHub = AddLine(conv, 40, NarratorId, RomusId, "Speech_Closing_Hub",
                {cs("As the first ovation ebbed, the eyes of soldiers, merchants, and diplomatic envoys alike remained fixed upon the royal balustrade. You prepared your closing vow.")});

            closingHub.outgoingLinks.Add(CreateLink(conv.id, 40, 41)); // Vow protection of Wehzek & Rizian civilians
            closingHub.outgoingLinks.Add(CreateLink(conv.id, 40, 42)); // Rally the armed forces & munitions production
            closingHub.outgoingLinks.Add(CreateLink(conv.id, 40, 43)); // Cite bombing atrocities publicly (if dossier exists!)

            AddChoice(conv, 41, HugoId, "Closing_Civilian_Charter",
                {cs("\"I pledge before God: Rizian, Bludish, and peaceful Wehzek residents in Zille shall know law, not vengeance!\"")},
                {cs("Hear this royal vow: every Rizian, Bludish, and law-abiding Wehzek resident inside Zille will be shielded by our courts. We bring lawful peace, never blind reprisal! Glovurius axa Rizia!")}, 51,
                {cs("Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")});

            AddChoice(conv, 42, HugoId, "Closing_Soldier_Pride",
                {cs("\"Stand behind our divisions, fuel our depots, and victory will be ours! Glovurius axa Rizia!\"")},
                {cs("Let every foundry, farm, and port stand beside the soldiers marching across our border tonight! Together, Rizia is invincible! Glovurius axa Rizia!")}, 52,
                {cs("Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;")});

            AddChoice(conv, 43, LaurentoId, "Closing_Expose_Terror",
                {cs("\"The world has seen Smolak's bombings and blackmail in Zille—we end his terror forever!\"")},
                {cs("For years our people endured Smolak's fabricated terror and extortion in Zille. Our evidence lies on the record, and our answer flies on the wind! Glovurius axa Rizia!")}, 53,
                {cs("Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2;")},
                {cs(ANY_BOMBING_DOSSIER)});

            AddLine(conv, 51, LaurentoId, RomusId, "Ack_Closing_Charter",
                {cs("Laurento exhaled in quiet admiration as you stepped back through the gilded doors. \"That civilian pledge just disarmed half our critics in Konstantium, Your Majesty.\"")}, -1);

            AddLine(conv, 52, NarratorId, RomusId, "Ack_Closing_Workers",
                {cs("The plaza thundered with cheers that shook the tall palace glass. Workers, noble retainers, and guardsmen roared as one voice.")}, -1);

            AddLine(conv, 53, HugoId, RomusId, "Ack_Closing_Expose",
                {cs("Foreign reporters sprinted for the telephone booths across the square as Smolak's culpability became tomorrow's headline across Merkopa.")}, -1);

            AddConversationWithAlias(db, conv, "Zille/WarBalconySpeech", "Turn_Zille_WarBalconySpeech");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected War Balcony Proclamation (ID 9989) into masterDatabase!");
        }}
    }}
}}
'''
    with open('src/GreatZilleSolution/ZilleDialogueSystem.WarScenes.cs', 'w', encoding='utf-8') as f:
        f.write(code)
    print("Successfully built src/GreatZilleSolution/ZilleDialogueSystem.WarScenes.cs")


def generate_diplomacy_scenes():
    code = f'''using System;
using System.Collections.Generic;
using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{{
    public static partial class ZilleDialogueSystem
    {{
        // =========================================================================
        // SCENE 6: Turn_Zille_DerdiaTalks (ID 9995) - TALKS WITH DERDIA
        // Features:
        // - Supreme Wiseman Jorga Azmal (Silver Garrison outside Naeal)
        // - Grand Wiseman Sal Ignacius (Six Stars medallion) + Hugo/Laurento/Titus/Carlos fallbacks
        // - Checks pilgrim ban status, Derdia hostility, equipment >= 1000 & budget >= 2!
        // =========================================================================
        public static void RegisterDerdiaTalks(DialogueDatabase db)
        {{
            if (db.GetConversation("Turn_Zille_DerdiaTalks") != null && db.GetConversation("Zille/DerdiaTalks") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_DerdiaTalks;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/DerdiaTalks";
            conv.ActorID = RomusId;
            conv.ConversantID = AzmalId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, AzmalId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Derdia_Intro_1",
                {cs("The private royal telecommunications chamber was heavy with sandalwood and frankincense. Over the encrypted line from the Silver Garrison outside Naeal, Supreme Wiseman Jorga Azmal's gravelly baritone cut through the static with austere authority.")}, -1);

            AddLine(conv, 2, AzmalId, RomusId, "Azmal_Opening_Greeting",
                {cs("May God's light guide you, Your Majesty. The mountain winds carry whispers of iron and smoke rising along Wehlen's borders. You prepare to strike the butcher of Wraclawitz, do you not?")}, 3,
                {cs('Variable["RiziaDLC.CountryRelation_Derdia_Hostile"] ~= true')});

            AddLine(conv, 102, AzmalId, RomusId, "Azmal_Opening_Hostile",
                {cs("I am surprised the King of Rizia dares summon the Silver Garrison after all the insults our faithful suffered, Your Majesty. Yet even an estranged neighbor becomes useful when Wiktor Smolak stands across the border. Speak quickly.")}, 3,
                {cs('Variable["RiziaDLC.CountryRelation_Derdia_Hostile"] == true')});

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            var azmalHub = AddLine(conv, 3, RomusId, AzmalId, "Romus_Azmal_Open_Prompt",
                {cs("I leaned toward the gilded receiver, weighing faith, border strategy, and Rizia's own laws.")});

            azmalHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10));
            azmalHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11));
            azmalHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12));

            AddChoice(conv, 10, AzmalId, "Choice_Faith_Justice",
                {cs("\"Smolak has persecuted Bludish and Golcondist believers alike. Justice demands action.\"")},
                {cs("Smolak has trampled sacred law and butchered believers across Wehlen and Zille for far too long. Justice demands that the sword be drawn against him.")}, 20,
                {cs("Variable[\"Derdia_Romus_Faithful\"] = true; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;")});

            AddChoice(conv, 11, AzmalId, "Choice_Military_Pragmatism",
                {cs("\"Wehlen shares its land border with you and its sea approaches with us. Strike together, and Smolak splits in two.\"")},
                {cs("Wehlen borders Derdia by land while Rizia attacks across the Brenas frontier and the Gulf of Moridia. Strike Wehlen's southern depots simultaneously, and Smolak's army cracks under two fronts.")}, 20,
                {cs("Variable[\"Derdia_Romus_Pragmatic\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;")});

            AddChoice(conv, 12, AzmalId, "Choice_Question_Motives",
                {cs("\"What concrete price does the Silver Garrison set for raiding Wehlen's rear?\"")},
                {cs("Speak plainly, Supreme Wiseman: what does Derdia demand in return for opening a second front on Wehlen's southern frontier?")}, 20,
                {cs("Variable[\"Derdia_Romus_Cautious\"] = true;")});

            AddLine(conv, 20, AzmalId, RomusId, "Azmal_Theological_Stakes",
                {cs("Know this, Your Majesty: Smolak's regime has hounded Golcondists through the mountains for decades, while Rizia's own border laws long barred our pilgrims from the Archsanctuary of Plavo and the shrines of our shared Nurist heritage.")}, -1);

            AddLine(conv, 21, AzmalId, RomusId, "Azmal_Offer_Proposal",
                {cs("Open Rizia's borders to Golcondist pilgrims and guarantee their worship at Plavo and liberated Zille—OR furnish our irregulars with real mountain rifles or gold to wage war! In return, three thousand Golcondist irregulars will cross into southern Wehlen, burning depots and tying down Valdez's reserves.")}, -1,
                {cs('Variable["RiziaDLC.Decision_Turn03_GolcondistPilgrims_AllowPassage"] ~= true')});

            AddLine(conv, 121, AzmalId, RomusId, "Azmal_Offer_Proposal_AlreadyAllowed",
                {cs("You already showed rare goodwill in opening your border to our pilgrims, Your Majesty. Reaffirm their sanctuary at Plavo and liberated Zille—or arm our scouts—and three thousand Golcondist irregulars will raid Wehlen's mainland border depots before dawn.")}, -1,
                {cs('Variable["RiziaDLC.Decision_Turn03_GolcondistPilgrims_AllowPassage"] == true')});

            AddLink(conv, 20, 21);
            AddLink(conv, 20, 121);

            AddLine(conv, 22, SalId, RomusId, "Sal_Ignacius_Warning",
                {cs("Grand Wiseman Sal Ignacius leaned forward, his fingers tightening around his golden Six Stars medallion. \"Your Majesty, granting formal privileges to Golcondist pilgrims will deeply unsettle orthodox Wruhecist clerics—unless you satisfy Azmal with cold coin or surplus steel instead of religious concessions!\"")}, -1,
                {cs(SAL_FREE)});

            AddLine(conv, 122, HugoId, RomusId, "Hugo_Clergy_Warning_NoSal",
                {cs("Hugo murmured beside you with furrowed brow. \"Be cautious, Romus. Opening our sanctuaries to Derdian Golcondists will incense the orthodox clergy—weigh whether surplus rifles or treasury gold wouldn't buy his raiders more cleanly.\"")}, -1,
                {cs(f"{SAL_GONE} and {HUGO_FREE}")});

            AddLine(conv, 123, LaurentoId, RomusId, "Laurento_Clergy_Warning_Fallback",
                {cs("Laurento whispered discreetly, \"Bear in mind, Your Majesty, that religious concessions to Derdia will draw sharp criticism from traditionalists unless we trade purely in weapons or subsidies.\"")}, -1,
                {cs(f"{SAL_GONE} and {HUGO_GONE}")});

            foreach (int pId in new[] {{ 21, 121 }})
            {{
                AddLink(conv, pId, 22);
                AddLink(conv, pId, 122);
                AddLink(conv, pId, 123);
            }}

            AddLine(conv, 23, TitusId, RomusId, "Titus_Tactical_Perspective",
                {cs("Titus Gordion stepped forward respectfully. \"Militarily, Your Majesty, Derdian raids across Wehlen's southern land border force General Valdez to divert brigades away from Zille. Just confirm we actually hold surplus arms or gold before promising material aid.\"")}, 30,
                {cs(TITUS_FREE)});

            AddLine(conv, 124, CarlosId, RomusId, "Carlos_Tactical_Perspective",
                {cs("General Carlos Azaro nodded curtly. \"Militarily, Derdian raids on Wehlen's southern frontier depots will pin down brigades Smolak would otherwise ship to Zille.\"")}, 30,
                {cs(TITUS_GONE)});

            foreach (int wId in new[] {{ 22, 122, 123 }})
            {{
                AddLink(conv, wId, 23);
                AddLink(conv, wId, 124);
            }}

            var pactHub = AddLine(conv, 30, NarratorId, RomusId, "Derdia_Pact_Hub_Prompt",
                {cs("Supreme Wiseman Azmal awaited your verdict on the transceiver, the distant unison chants of the Silver Garrison audible across the line.")});

            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 35)); // Ask about Derdia's tactical plan / state check
            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Accept Holy Coalition (religious pledge)
            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 45)); // Supply 500 Surplus Rifles (requires Equipment >= 1000!)
            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 48)); // War Chest Subsidy (requires Budget >= 2!)
            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 50)); // Pragmatic civil protection
            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 60)); // Reject

            AddChoice(conv, 35, AzmalId, "Probe_Derdia_Operations",
                {cs("\"Supreme Wiseman, specify exactly which Wehzek corridors your fighters can hit.\"")},
                {cs("Before I commit my word or my depots, Supreme Wiseman: specify exactly where your raiders will strike in southern Wehlen.")}, 36,
                {cs("Variable[\"Derdia_Probed\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;")},
                {cs('Variable["Derdia_Probed"] ~= true')});

            AddLine(conv, 36, AzmalId, RomusId, "Ack_Probe_Derdia",
                {cs("\"We control the mountain passes north of Naeal,\" Azmal answered smoothly. \"My irregulars will ambush supply trains moving from Wraclawitz toward Grodzizg and Rotsla—forcing Smolak to garrison his interior roads instead of reinforcing Zille.\"")}, 30);

            AddChoice(conv, 40, AzmalId, "Accept_Holy_Coalition",
                {cs("\"I pledge by Saint Wruhec: Golcondist pilgrims shall have safe passage to Plavo and liberated Zille.\"")},
                {cs("I pledge by my royal honor: Rizia's borders stay open to Golcondist pilgrims, and they shall worship safely at Plavo and liberated Zille. Unleash your irregulars against Wehlen!")}, 41,
                {cs("Variable[\"Zille_DerdiaHybridActive\"] = true; Variable[\"RiziaDLC.Decision_Turn03_GolcondistPilgrims_AllowPassage\"] = true; Variable[\"RiziaDLC.CountryRelation_Derdia_Friendly\"] = true; Variable[\"RiziaDLC.Diplomacy_Derdia_NegotiatingPower\"] = (Variable[\"RiziaDLC.Diplomacy_Derdia_NegotiatingPower\"] or 0) + 2; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2;")});

            AddLine(conv, 41, AzmalId, RomusId, "Ack_Holy_Coalition",
                {cs("Azmal's voice boomed with solemn fervor. \"Halaita! Let the tyrant's chains shatter! My fighters cross Wehlen's border before dawn. May God shield your armies, Your Majesty.\"")}, -1);

            AddLine(conv, 42, SalId, RomusId, "Sal_Derdia_Grumble",
                {cs("Grand Wiseman Sal murmured a quiet prayer, fingers brushing his Six Stars medallion. \"May Saint Wruhec forgive this concession for the kingdom's peace...\"")}, -1,
                {cs(SAL_FREE)});

            AddLink(conv, 41, 42);

            // Option 45: Surplus Arms Transfer (ONLY if Equipment >= 1000!)
            AddChoice(conv, 45, AzmalId, "Deal_Derdia_Weapons",
                {cs("\"No religious concessions—instead, Rizia will ship 500 surplus rifles for your mountain scouts.\"")},
                {cs("Rizia will not alter her sanctuary statutes, yet our arsenals hold abundant surplus steel. Take 500 crates of Rizian rifles and demolish Wehlen's southern rail lines!")}, 46,
                {cs("Variable[\"Zille_DerdiaHybridActive\"] = true; Variable[\"RiziaDLC.Resources_Military_Equipment\"] = (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) - 500; Variable[\"RiziaDLC.CountryRelation_Derdia_Friendly\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2;")},
                {cs(EQUIP_GE_1000)});

            AddLine(conv, 46, AzmalId, RomusId, "Ack_Derdia_Weapons",
                {cs("Azmal paused, clearly impressed by the cold pragmatism. \"Good steel speaks louder than parchment promises, King Romus. Deliver those rifles to the border pass, and Wehlen's southern garrisons will burn tonight!\"")}, -1);

            AddLine(conv, 47, SalId, RomusId, "Sal_Relieved_Weapons",
                {cs("Grand Wiseman Sal exhaled a sigh of profound relief. \"Steel instead of sanctuary decrees... A wise sovereign balance, Your Majesty.\"")}, -1,
                {cs(SAL_FREE)});

            AddLink(conv, 46, 47);

            // Option 48: Gold War Subsidy (ONLY if Budget >= 2!)
            AddChoice(conv, 48, AzmalId, "Deal_Derdia_Budget",
                {cs("\"Leave Wruhecist law intact—accept 2 Budget in gold bullion to equip your irregulars.\"")},
                {cs("Rizian religious law remains sovereign, yet our royal treasury will transfer 2 Budget in gold coin to finance your southern border raids against Smolak.")}, 49,
                {cs("Variable[\"Zille_DerdiaHybridActive\"] = true; Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 2; Variable[\"RiziaDLC.CountryRelation_Derdia_Friendly\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;")},
                {cs(BUDGET_CAN_SPEND2)});

            AddLine(conv, 49, AzmalId, RomusId, "Ack_Derdia_Budget",
                {cs("\"War requires coin as much as prayer,\" Azmal intoned smoothly. \"Your gold arms the faithful along Wehlen's border tonight, Your Majesty.\"")}, -1);

            AddChoice(conv, 50, AzmalId, "Counter_Pragmatic_Derdia",
                {cs("\"I guarantee safe civil border transit, but no special sanctuary charters or material aid.\"")},
                {cs("I guarantee safe transit and civil protection for Derdian travelers across our borders, but I will not alter our Wruhecist sanctuary laws or drain our depots. Let us strike Smolak as sovereign partners.")}, 51,
                {cs("Variable[\"Zille_DerdiaHybridActive\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")});

            AddLine(conv, 51, AzmalId, RomusId, "Ack_Pragmatic_Derdia",
                {cs("Azmal exhaled slowly. \"You bargain with the caution of a king rather than a prophet, Romus. Yet our hatred for Smolak outweighs our disappointment. Our scouts will still raid his southern depots—remember our pilgrims once Zille is yours.\"")}, -1);

            AddChoice(conv, 60, AzmalId, "Reject_Derdia_Demands",
                {cs("\"Rizia governs its faith and steel without foreign conditions. Keep your raiders behind your border.\"")},
                {cs("Rizia answers to Saint Wruhec and the Crown alone. Keep your fighters in Derdia, Supreme Wiseman.")}, 61,
                {cs("Variable[\"Zille_DerdiaHybridActive\"] = false; Variable[\"RiziaDLC.CountryRelation_Derdia_Unfriendly\"] = true;")});

            AddLine(conv, 61, AzmalId, RomusId, "Ack_Reject_Derdia",
                {cs("Static hissed fiercely as Azmal's voice turned frigid. \"Then face Smolak's guns alone, King of Rizia! Do not call Naeal when your campaign stalls.\" The line went dead.")}, -1);

            AddConversationWithAlias(db, conv, "Zille/DerdiaTalks", "Turn_Zille_DerdiaTalks");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Derdia Talks (ID 9995) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 7: Turn_Zille_LespiaTalks (ID 9996) - NEGOTIATIONS WITH LESPIA
        // Features:
        // - Prime Minister Alvarez in Perla (never President/Porte Lespia!)
        // - Two-Front Pales War awareness + Zille Bombing Blackmail Option (LESPIA_EVIDENCE!)
        // - Budget/Energy/Army strength checks in hard bargaining!
        // =========================================================================
        public static void RegisterLespiaTalks(DialogueDatabase db)
        {{
            if (db.GetConversation("Turn_Zille_LespiaTalks") != null && db.GetConversation("Zille/LespiaTalks") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_LespiaTalks;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/LespiaTalks";
            conv.ActorID = RomusId;
            conv.ConversantID = AlvarezId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, AlvarezId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Lespia_Intro_1",
                {cs("The red secure hotline to Perla clicked alive with the clink of ice cubes against crystal glass, followed by a raspy cough and a cloud of cigar smoke.")}, -1);

            AddLine(conv, 2, AlvarezId, RomusId, "Alvarez_Opening_Banter",
                {cs("Romus! My royal friend! Don't tell me you called to invite me to an opera in Porte Drazon. Word through Arcasian channels is you're finally ready to kick that clown Smolak out of Zille!")}, 3,
                {cs(NO_TWO_FRONT)});

            AddLine(conv, 102, AlvarezId, RomusId, "Alvarez_Opening_TwoFront",
                {cs("Have you lost your mind, Romus?! You're firing on our allies in Pales right now, and you dare call Perla expecting intelligence favors against Wehlen?! Give me one good reason not to slam this receiver down!")}, 3,
                {cs(TWO_FRONT)});

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            var alvarezHub = AddLine(conv, 3, RomusId, AlvarezId, "Romus_Alvarez_Open_Prompt",
                {cs("I leaned against the console, matching Alvarez's brisk shark's tempo while checking what cards lay in my briefcase.")});

            alvarezHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10));
            alvarezHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11));
            alvarezHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12));

            AddChoice(conv, 10, AlvarezId, "Banter_Sarcastic",
                {cs("\"Enjoying an afternoon drink, Patricio? I thought you'd enjoy watching Smolak lose his grip on Zille.\"")},
                {cs("Enjoying an afternoon drink, Patricio? I assumed you might appreciate watching someone finally smash Smolak's extortion racket in Zille.")}, -1,
                {cs("Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;")});

            AddChoice(conv, 11, AlvarezId, "Banter_Business",
                {cs("\"Skip the theatrics, Prime Minister Alvarez. Let us talk reconnaissance and AN vetoes.\"")},
                {cs("Skip the theatrics, Prime Minister Alvarez. Let us talk ATO aerial intelligence and diplomatic cover in Konstantium.")}, -1);

            AddChoice(conv, 12, AlvarezId, "Banter_Pressure",
                {cs("\"Wehlen destabilizes every shipping lane in South Merkopa. Perla has skin in this game too.\"")},
                {cs("Smolak's blockade threats poison commerce across the Gulf of Moridia. Removing him from Zille protects Lespian maritime trade whether you admit it or not.")}, -1,
                {cs("Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")});

            AddLine(conv, 20, AlvarezId, RomusId, "Alvarez_Business_Pitch",
                {cs("Alvarez took a slow sip, dropping the jovial mask for pure capitalist predator. \"Look, Romus, I won't shed a tear if Valdez's boys end up in Zille's marshes. Yet Lespia doesn't run reconnaissance sorties out of charity. You want ATO high-altitude photography of Valdez's hidden bunkers and diplomatic shields in Kyrute.\"")}, 21,
                {cs(NO_TWO_FRONT)});

            AddLine(conv, 21, AlvarezId, RomusId, "Alvarez_Price_Demand",
                {cs("\"Here's my invoice: twenty percent preferential crude deliveries from your southern fields to Perla PLUS Rizia backing Lespia's seat on the MITZ board. Sign, and my bombers-turned-spotters will hand your generals Valdez's coordinates on a silver tray.\"")}, 22);

            AddLine(conv, 120, AlvarezId, RomusId, "Alvarez_TwoFront_Pitch",
                {cs("Alvarez laughed coldly into the line. \"You're fighting Reinhart on your eastern front in Pales and asking Perla for help on your southern front?! Bottom line, Romus: either halt the Pales war and yield oil + MITZ terms, or fight Smolak blind!\"")}, 22,
                {cs(TWO_FRONT)});

            foreach (int chId in new[] {{ 10, 11, 12 }})
            {{
                AddLink(conv, chId, 20);
                AddLink(conv, chId, 120);
            }}

            AddLine(conv, 22, LaurentoId, RomusId, "Laurento_Alvarez_Evaluation",
                {cs("Laurento whispered beside the console: \"ATO aerial photography would cut our battlefield casualties drastically, Your Majesty—yet his oil and MITZ terms are extortionate unless we hold leverage over Perla.\"")}, 30);

            var dealHub = AddLine(conv, 30, NarratorId, RomusId, "Alvarez_Deal_Hub_Prompt",
                {cs("Alvarez swirled the ice in his crystal tumbler, awaiting your counter-move.")});

            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 35)); // Use Bombing Evidence Blackmail! (if LESPIA_EVIDENCE)
            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Accept Alvarez Pact (-1 Energy if peaceful, or Pales peace cost)
            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 50)); // Hard Bargain (requires NO_TWO_FRONT and (PP_STRONG or EQUIP_GE_1000 or LEV_MID))
            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 60)); // Reject

            // NEW: Blackmail Alvarez with Zille Bombing Evidence!
            AddChoice(conv, 35, AlvarezId, "Blackmail_Alvarez_Zille",
                {cs("\"[DOSSIER LEVERAGE] Drop your price, Patricio—or we publish Perla's fingerprints on the Zille bombing!\"")},
                {cs("Drop the corporate ransom, Patricio. My intelligence services hold hard evidence linking Lespian agents to the Zille Friendship Day bombing. Hand over Valdez's bunker coordinates and guard us at the AN—or I read every page to the press in Konstantium!")}, 36,
                {cs("Variable[\"Zille_LespiaPactAccepted\"] = true; Variable[\"Zille_Lespia_Intel\"] = true; Variable[\"RiziaDLC.Diplomacy_Lespia_WehlenHelp\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 3;")},
                {cs(LESPIA_EVIDENCE)});

            AddLine(conv, 36, AlvarezId, RomusId, "Ack_Blackmail_Alvarez",
                {cs("A sharp intake of breath hissed across the wire, followed by the dead silence of ice melting untouched. \"...You cold-blooded Toras bastard,\" Alvarez whispered through clenched teeth. \"Fine. Keep those files locked in your safe. ATO reconnaissance photos and diplomatic cover in Kyrute will hit your desk within the hour—free of charge.\"")}, -1);

            AddChoice(conv, 40, AlvarezId, "Accept_Alvarez_Pact",
                {cs("\"Agreed. Perla receives preferential oil contracts (-1 Energy) for ATO recon and AN shielding.\"")},
                {cs("Agreed, Patricio. We guarantee Lespia preferential crude oil deliveries and quiet borders, provided Perla supplies uninterrupted aerial reconnaissance and diplomatic cover at the AN.")}, 41,
                {cs("Variable[\"Zille_LespiaPactAccepted\"] = true; Variable[\"Zille_Lespia_Intel\"] = true; Variable[\"RiziaDLC.Resources_Energy\"] = (Variable[\"RiziaDLC.Resources_Energy\"] or 0) - 1; Variable[\"RiziaDLC.CountryRelation_Lespia_Allied\"] = true; Variable[\"RiziaDLC.Diplomacy_Lespia_WehlenHelp\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2;")},
                {cs(ENERGY_CAN_SPEND1)});

            AddLine(conv, 41, AlvarezId, RomusId, "Ack_Alvarez_Pact",
                {cs("Alvarez burst into a triumphant laugh, clinking his tumbler against the receiver. \"Now that is statesmanship! Our reconnaissance planes are scrambling out of Perla as we speak, Romus. Happy hunting!\"")}, -1);

            AddChoice(conv, 50, AlvarezId, "Hard_Bargain_Alvarez",
                {cs("\"[STRENGTH BARGAIN] Ten percent oil contracts, zero MITZ concessions—Rizia fights from strength!\"")},
                {cs("Ten percent commercial oil deliveries, and not a single sovereign concession on the MITZ. Our arsenals are well stocked and Rizia isn't begging, Patricio—take our terms before Rizia crushes Wehlen alone and your influence evaporates!")}, 51,
                {cs("Variable[\"Zille_LespiaPactAccepted\"] = true; Variable[\"Zille_Lespia_Intel\"] = true; Variable[\"RiziaDLC.Diplomacy_Lespia_WehlenHelp\"] = true; Variable[\"RiziaDLC.Diplomacy_Lespia_NegotiatingPower\"] = (Variable[\"RiziaDLC.Diplomacy_Lespia_NegotiatingPower\"] or 0) - 1; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2;")},
                {cs(f"{NO_TWO_FRONT} and ({PP_STRONG} or {EQUIP_GE_1000} or {LEV_MID})")});

            AddLine(conv, 51, AlvarezId, RomusId, "Ack_Hard_Bargain",
                {cs("Alvarez swore softly under his breath before letting out a grudging bark of respect. \"You drive a harder bargain than your father ever dared, Your Majesty. Fine—ten percent commercial oil it is. Valdez's coordinates hit your war room within the hour.\"")}, -1);

            AddChoice(conv, 60, AlvarezId, "Reject_Alvarez_Greed",
                {cs("\"Rizian blood will not fatten Perla's conglomerates. We take Zille without your charity.\"")},
                {cs("Rizian soldiers will not bleed to enrich Lespian oil trusts, Prime Minister. We will defeat Wehlen with our own steel. Good day.")}, 61,
                {cs("Variable[\"Zille_LespiaPactAccepted\"] = false; Variable[\"Zille_Lespia_Intel\"] = false; Variable[\"RiziaDLC.CountryRelation_Lespia_Unfriendly\"] = true;")});

            AddLine(conv, 61, AlvarezId, RomusId, "Ack_Reject_Lespia",
                {cs("Alvarez's amusement froze into venom. \"Good luck against Valdez's mines and bunkers then, Romus. Don't call Perla when your tanks bog down.\" The line snapped dead.")}, -1);

            AddConversationWithAlias(db, conv, "Zille/LespiaTalks", "Turn_Zille_LespiaTalks");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Lespia Talks (ID 9996) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 8: Turn_Zille_RumburgTalks (ID 9997) - ROYAL HOTLINE WITH RUMBURG
        // Features:
        // - Queen Beatrice (sister-in-law, NEVER cousin!), Thornbourgh
        // - Fixes shell grant scale (+600/+400/+1000 Military_Equipment instead of +2!)
        // - Checks Lespia pact, Valgsland warmth, Fleet & Equipment (<1000 vs >=1000), Budget>=1!
        // =========================================================================
        public static void RegisterRumburgTalks(DialogueDatabase db)
        {{
            if (db.GetConversation("Turn_Zille_RumburgTalks") != null && db.GetConversation("Zille/RumburgTalks") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_RumburgTalks;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/RumburgTalks";
            conv.ActorID = RomusId;
            conv.ConversantID = BeatriceId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, BeatriceId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Rumburg_Intro_1",
                {cs("The brass-and-ivory royal trunk line to Thornbourgh hummed with crystal clarity. Across two thousand miles of wire, the poised, imperious voice of Queen Beatrice Livingston echoed into the study, carrying all the weight of your late wife Lena's royal house.")}, -1);

            AddLine(conv, 2, BeatriceId, RomusId, "Beatrice_Royal_Greeting",
                {cs("Romus, my dear brother-in-law. We in Thornbourgh have watched your confrontation with that Wehzek upstart closely. A crowned monarch cannot permit a petty dictator to trample the honor of a sister throne.")}, 3,
                {cs('Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] ~= true')});

            AddLine(conv, 102, BeatriceId, RomusId, "Beatrice_Hostile_Greeting",
                {cs("Your Majesty. Given recent strains between Thornbourgh and Porte Drazon, your call was unexpected—though even I detest Wiktor Smolak's insolence. Speak your mind.")}, 3,
                {cs('Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == true')});

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            var beatriceHub = AddLine(conv, 3, RomusId, BeatriceId, "Romus_Beatrice_Open_Prompt",
                {cs("I straightened my tunic, addressing Lena's sister with the formal dignity expected between royal courts.")});

            beatriceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10));
            beatriceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11));
            beatriceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12));

            AddChoice(conv, 10, BeatriceId, "Solidarity_Royal",
                {cs("\"Your Majesty. House Toras stands resolute, and our two crowns share one honor.\"")},
                {cs("Beatrice, it is good to hear your voice. House Toras stands resolute. Over twenty-five years of Wehzek defiance will be answered with royal steel.")}, 20,
                {cs("Variable[\"Rumburg_Romus_Loyal\"] = true; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;")});

            AddChoice(conv, 11, BeatriceId, "Munitions_Request",
                {cs("\"Beatrice, our batteries need heavy artillery munitions and AN diplomatic shielding.\"")},
                {cs("Your Majesty. Rizia's cause is just, yet our brigades need heavy-caliber shells and firm diplomatic shielding in Konstantium against Contanan meddling.")}, 20,
                {cs("Variable[\"Rumburg_Romus_Munitions\"] = true;")});

            AddChoice(conv, 12, BeatriceId, "Sovereign_Assertive",
                {cs("\"Rizia will shed its own blood in Zille, though GRACE solidarity strengthens both our crowns.\"")},
                {cs("Rizia will fight and win with its own blood, yet monarchist solidarity within GRACE will prove to Merkopa that crowns stand unbroken.")}, 20,
                {cs("Variable[\"Rumburg_Romus_Proud\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")});

            AddLine(conv, 20, BeatriceId, RomusId, "Beatrice_Imperial_Offer",
                {cs("Spoken like a true king, Romus. Thornbourgh will not watch quietly while republican rabble mocks a sister monarchy. Rumburg can route freight trains carrying 152mm heavy artillery munitions and surplus rifles directly toward Brenas, and our envoy in Konstantium will fight Contanan sanctions.")}, -1);

            AddLine(conv, 21, BeatriceId, RomusId, "Beatrice_AN_Pledge",
                {cs("One expectation remains: Rizia must remain a proud pillar of GRACE, keeping Arcasian and Lespian profiteers from dictating Porte Drazon's policy.")}, -1,
                {cs('Variable["Zille_LespiaPactAccepted"] ~= true')});

            AddLine(conv, 121, BeatriceId, RomusId, "Beatrice_AN_Pledge_LespiaWarn",
                {cs("Still, dispatches from Perla warn me you have already been bargaining with Prime Minister Alvarez! Do not sell your dignity to ATO merchants, Romus—Rumburg helps a sovereign king, not a Lespian client state.")}, -1,
                {cs('Variable["Zille_LespiaPactAccepted"] == true')});

            AddLink(conv, 20, 21);
            AddLink(conv, 20, 121);

            // Context check: Low Equip (<1000) vs Strong Equip (>=1000) + Hugo fallback
            AddLine(conv, 22, HugoId, RomusId, "Hugo_Beatrice_Support_NeedArms",
                {cs("Hugo inclined his head with relief. \"Your Majesty, with our own depots currently holding under a thousand reserve weapons, Thornbourgh's rail shipments of shells and rifles could save an entire offensive!\"")}, 30,
                {cs(f"{HUGO_FREE} and {EQUIP_LOW}")});

            AddLine(conv, 23, HugoId, RomusId, "Hugo_Beatrice_Support_FullArms",
                {cs("Hugo nodded with deep pride. \"Our own armories already stand well above a thousand weapons, yet Rumburg's heavy 152mm shells and AN shield will make Valdez's bunkers indefensible!\"")}, 30,
                {cs(f"{HUGO_FREE} and {EQUIP_GE_1000}")});

            AddLine(conv, 122, LaurentoId, RomusId, "Laurento_Beatrice_Support",
                {cs("Laurento murmured discreetly, \"Thornbourgh's diplomatic cover at Konstantium and those heavy artillery trains strengthen our hand dramatically, Your Majesty.\"")}, 30,
                {cs(HUGO_GONE)});

            foreach (int pId in new[] {{ 21, 121 }})
            {{
                AddLink(conv, pId, 22);
                AddLink(conv, pId, 23);
                AddLink(conv, pId, 122);
            }}

            var responseHub = AddLine(conv, 30, NarratorId, RomusId, "Beatrice_Response_Prompt",
                {cs("Queen Beatrice waited on the royal line with cool regal authority for your response.")});

            responseHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Full GRACE pledge (+600 Equip)
            responseHub.outgoingLinks.Add(CreateLink(conv.id, 30, 45)); // Purchase Expanded Shipment (-1 Budget -> +1000 Equip!)
            responseHub.outgoingLinks.Add(CreateLink(conv.id, 30, 50)); // Pragmatic royal thanks (+400 Equip)

            AddChoice(conv, 40, BeatriceId, "Pledge_GRACE_Solidarity",
                {cs("\"House Toras pledges steadfast solidarity to GRACE (+600 Military Equipment, AN cover).\"")},
                {cs("House Toras pledges steadfast solidarity to GRACE and our royal kinship, Beatrice. For Lena's memory and our sister crowns, accept my bond!")}, 41,
                {cs("Variable[\"Zille_Rumburg_Munitions\"] = true; Variable[\"RiziaDLC.CountryRelation_Rumburg_Allied\"] = true; Variable[\"RiziaDLC.Resources_Military_Equipment\"] = (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) + 600; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;")});

            AddLine(conv, 41, BeatriceId, RomusId, "Ack_Beatrice_Pledge",
                {cs("Beatrice smiled with imperious satisfaction. \"Splendid, Romus. Three full trains of 152mm shells and six hundred crates of reserve armaments depart for Brenas tonight. Claim what is yours.\"")}, -1);

            AddChoice(conv, 45, BeatriceId, "Purchase_Rumburg_Expansion",
                {cs("\"We back GRACE—and pay 1 Budget upfront for double rail consignments (+1,000 Military Equipment)!\"")},
                {cs("In addition to GRACE solidarity, our treasury releases 1 Budget upfront to double the heavy shell and rifle shipments bound for Brenas immediately!")}, 46,
                {cs("Variable[\"Zille_Rumburg_Munitions\"] = true; Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 1; Variable[\"RiziaDLC.CountryRelation_Rumburg_Allied\"] = true; Variable[\"RiziaDLC.Resources_Military_Equipment\"] = (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) + 1000; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 2;")},
                {cs(BUDGET_CAN_SPEND1)});

            AddLine(conv, 46, BeatriceId, RomusId, "Ack_Beatrice_Expanded",
                {cs("\"Prompt payment and royal resolve—my favorite virtues in a brother-in-law!\" Beatrice replied warmly. \"Six heavy ordnance trains roll south tonight. Smolak's trenches won't survive them.\"")}, -1);

            AddChoice(conv, 50, BeatriceId, "Grateful_Sovereign",
                {cs("\"We accept your munitions with royal gratitude without binding military pledges (+400 Equipment).\"")},
                {cs("We accept your heavy shells and goodwill with deep gratitude, Beatrice, while keeping Rizia's strategic commitments flexible.")}, 51,
                {cs("Variable[\"Zille_Rumburg_Munitions\"] = true; Variable[\"RiziaDLC.CountryRelation_Rumburg_Friendly\"] = true; Variable[\"RiziaDLC.Resources_Military_Equipment\"] = (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) + 400; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")});

            AddLine(conv, 51, BeatriceId, RomusId, "Ack_Beatrice_Sovereign",
                {cs("\"May victory crown your banners, Romus. Send word when Zille returns under Toras colors.\" The imperial trunk line softly clicked silent.")}, -1);

            AddConversationWithAlias(db, conv, "Zille/RumburgTalks", "Turn_Zille_RumburgTalks");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Rumburg Talks (ID 9997) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 9: Turn_Zille_WarPreNegotiationsBriefing (ID 9991) - PRE-NEGOTIATIONS
        // Assesses actual Zille vs Pales losses, Leverage strength, Equipment/Budget stamina
        // =========================================================================
        public static void RegisterWarPreNegotiationsBriefing(DialogueDatabase db)
        {{
            if (db.GetConversation("Turn_Zille_WarPreNegotiationsBriefing") != null && db.GetConversation("Zille/WarPreNegotiationsBriefing") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarPreNegotiations;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/WarPreNegotiationsBriefing";
            conv.ActorID = RomusId;
            conv.ConversantID = LaurentoId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, LaurentoId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "PreNeg_Intro_1",
                {cs("The heavy artillery had fallen eerily silent along the smoke-shrouded Zille frontier and across the Gulf of Moridia. Beside the battle maps in Palas Rezna lay urgent telegrams from Konstantium. Wiktor Smolak had dispatched an envoy under white flags proposing a face-to-face parley.")}, -1);

            AddLine(conv, 2, LucitaId, RomusId, "Lucita_PreNeg_Report",
                {cs("Your Majesty. A temporary ceasefire holds across Zille. Both armies have expended immense shells, and Smolak's delegation awaits at the neutral pavilion overlooking the peninsula.")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 102, CarlosId, RomusId, "Carlos_PreNeg_Report",
                {cs("Your Majesty. Both fronts stand in a fragile truce. Our generals tally our exact Zille losses separately from any eastern Pales casualties as Smolak awaits your arrival at the pavilion.")}, -1,
                {cs(LUCITA_GONE)});

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            // Leverage & Diplomatic Assessment
            AddLine(conv, 3, LaurentoId, RomusId, "Laurento_PreNeg_HighLeverage",
                {cs("The Alliance of Nations watches closely, Your Majesty—and thanks to the evidence, treaties, and diplomatic groundwork you assembled throughout this crisis, you enter that pavilion holding genuine leverage over Smolak.")}, -1,
                {cs(LEV_HIGH)});

            AddLine(conv, 103, LaurentoId, RomusId, "Laurento_PreNeg_LowLeverage",
                {cs("The Alliance of Nations presses for settlement, Your Majesty. Because our diplomatic leverage remains limited, what you salvage or dictate across that table will depend almost entirely on what our soldiers presently hold on the ground.")}, -1,
                {cs(f"not ({LEV_HIGH})")});

            foreach (int p in new[] {{ 2, 102 }})
            {{
                AddLink(conv, p, 3);
                AddLink(conv, p, 103);
            }}

            AddLine(conv, 4, HugoId, RomusId, "Hugo_PreNeg_Counsel",
                {cs("Romus... Smolak shifts between buffoon and butcher in a heartbeat. Guard the dignity of House Toras, and never let him think our depots or treasury are weaker than they are.")}, 10,
                {cs(HUGO_FREE)});

            AddLine(conv, 104, LaurentoId, RomusId, "Laurento_PreNeg_NoHugo",
                {cs("Remember Smolak's nature, Your Majesty—he alternates between clownish jokes and vicious blackmail. Keep your cards close to your chest.")}, 10,
                {cs(HUGO_GONE)});

            foreach (int prev in new[] {{ 3, 103 }})
            {{
                AddLink(conv, prev, 4);
                AddLink(conv, prev, 104);
            }}

            var preNegHub = AddLine(conv, 10, RomusId, LaurentoId, "Romus_PreNeg_Prompt",
                {cs("I studied the final map positions, our separate casualty ledgers, and my leather briefcase before setting out for the border pavilion.")});

            preNegHub.outgoingLinks.Add(CreateLink(conv.id, 10, 11)); // Review separate Zille vs Pales losses & armory stamina
            preNegHub.outgoingLinks.Add(CreateLink(conv.id, 10, 12)); // Review Leverage cards in briefcase
            preNegHub.outgoingLinks.Add(CreateLink(conv.id, 10, 20)); // Royal Standard Posture
            preNegHub.outgoingLinks.Add(CreateLink(conv.id, 10, 21)); // Uncompromising Artillery Threat (requires Outcome>=3 & (Equip>=1000 or Leverage>=2))

            AddChoice(conv, 11, ElenaId, "PreNeg_Check_Ledger",
                {cs("\"Brief me on our exact Zille losses, any Pales drain, and whether our depots could sustain renewed fighting.\"")},
                {cs("Give me the exact numbers: how do our Zille losses compare separately from Pales, and can our treasury and arsenals back an ultimatum if Smolak walks out?")}, -1,
                {cs("Variable[\"Zille_PreNeg_CheckedLedger\"] = true;")},
                {cs('Variable["Zille_PreNeg_CheckedLedger"] ~= true')});

            AddLine(conv, 111, ElenaId, RomusId, "Ack_PreNeg_Strong",
                {cs("\"Our separate Zille casualty ledger stays manageable, and with over 1,000 weapons in stock and healthy treasury reserves, Smolak knows we are not bluffing if talks collapse.\"")}, 10,
                {cs(f"{EQUIP_GE_1000} and {BUDGET_CAN_SPEND1}")},
                {cs("Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")});

            AddLine(conv, 112, ElenaId, RomusId, "Ack_PreNeg_Thin",
                {cs("\"Keep a calm face in the pavilion, Your Majesty: whether from fierce Zille attrition, Pales draining our reserves, or depots sitting under 1,000 weapons, renewed all-out combat would strain our treasury severely. Use diplomacy and leverage ruthlessly.\"")}, 10,
                {cs(f"{EQUIP_LOW} or {BUDGET_NO_SPEND1}")});

            AddLink(conv, 11, 111);
            AddLink(conv, 11, 112);

            AddChoice(conv, 12, LaurentoId, "PreNeg_Check_Leverage",
                {cs("\"List every diplomatic card we hold against Smolak inside that briefcase.\"")},
                {cs("List every piece of leverage we hold against Wiktor Smolak right now—treaties, intelligence dossiers, foreign pacts, and blockades.")}, 121,
                {cs("Variable[\"Zille_PreNeg_CheckedLeverage\"] = true;")},
                {cs('Variable["Zille_PreNeg_CheckedLeverage"] ~= true')});

            AddLine(conv, 121, LaurentoId, RomusId, "Ack_PreNeg_Leverage",
                {cs("\"Your case rests on the lapsed 1927 agreement, any Zille bombing intelligence you preserved, naval pressure across the Gulf of Moridia, and whatever pacts you sealed with Naeal, Perla, or Thornbourgh. Strike him with whichever weakness cuts deepest first.\"")}, 10);

            AddChoice(conv, 20, LaurentoId, "Choice_Parley_Strength",
                {cs("\"Prepare the royal motorcade. I will meet Smolak and play our cards face to face.\"")},
                {cs("Prepare the royal armored motorcade. I will meet Smolak under the royal standard and dictate or bargain cleanly.")}, -1,
                {cs("Variable[\"Zille_Parley_Ready\"] = true;")});

            AddChoice(conv, 21, LaurentoId, "Choice_Unconditional_Surrender",
                {cs("\"Tell Smolak our guns stay loaded—with full depots behind us, stalling means renewed bombardment!\"")},
                {cs("Inform Smolak that if he stalls in that pavilion, our batteries and ships reopen fire within the hour. We bargain from unmistakable steel.")}, -1,
                {cs("Variable[\"Zille_Parley_Ready\"] = true; Variable[\"Zille_Parley_Uncompromising\"] = true; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;")},
                {cs(f'((Variable["Zille_War_Outcome"] or 0) >= 3 or (Variable["Zille_War_Outcome"] or 0) == 0) and ({EQUIP_GE_1000} or {LEV_MID})')});

            AddLine(conv, 22, LucitaId, RomusId, "Ack_PreNeg_Lucita",
                {cs("Lucita strapped on her sidearm and saluted with iron resolve. \"The royal escort is mounted, Your Majesty. Let us bring Zille home.\"")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 122, CarlosId, RomusId, "Ack_PreNeg_Carlos",
                {cs("General Carlos Azaro snapped a crisp salute. \"The armored escort is ready, Your Majesty.\"")}, -1,
                {cs(LUCITA_GONE)});

            foreach (int chId in new[] {{ 20, 21 }})
            {{
                AddLink(conv, chId, 22);
                AddLink(conv, chId, 122);
            }}

            AddConversationWithAlias(db, conv, "Zille/WarPreNegotiationsBriefing", "Turn_Zille_WarPreNegotiationsBriefing");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Pre-Negotiations Briefing (ID 9991) into masterDatabase!");
        }}
    }}
}}
'''
    with open('src/GreatZilleSolution/ZilleDialogueSystem.DiplomacyScenes.cs', 'w', encoding='utf-8') as f:
        f.write(code)
    print("Successfully built src/GreatZilleSolution/ZilleDialogueSystem.DiplomacyScenes.cs")


def generate_treaty_scenes():
    # Outcome condition helpers (with 0/nil sandbox fallback so Event Spawner testing still works)
    OUT_VICTORY = '((Variable["Zille_War_Outcome"] or 0) >= 4 or (Variable["Zille_War_Outcome"] or 0) == 0)'
    OUT_OVERWHELM = '((Variable["Zille_War_Outcome"] or 0) == 5 or (Variable["Zille_War_Outcome"] or 0) == 0)'
    OUT_STALEMATE = '((Variable["Zille_War_Outcome"] or 0) == 3 or (Variable["Zille_War_Outcome"] or 0) == 0)'
    OUT_DEFEAT = '((Variable["Zille_War_Outcome"] or 0) == 1 or (Variable["Zille_War_Outcome"] or 0) == 2 or (Variable["Zille_War_Outcome"] or 0) == 0)'
    OUT_FIASCO = '((Variable["Zille_War_Outcome"] or 0) == 1 or (Variable["Zille_War_Outcome"] or 0) == 0)'
    OUT_TACTICAL_DEFEAT = '((Variable["Zille_War_Outcome"] or 0) == 2 or (Variable["Zille_War_Outcome"] or 0) == 0)'

    code = f'''using System;
using System.Collections.Generic;
using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{{
    public static partial class ZilleDialogueSystem
    {{
        // =========================================================================
        // SCENE 10: Turn_Zille_WarSmolakFinalParley (ID 9992) - SMOLAK PARLEY
        // Multi-round tactical duel of leverage:
        // Round 1: Opening Posture gated by actual battlefield outcome
        // Round 2: Smolak counter-bluffs + Romus deploys accumulated Leverage cards
        //          (Bombing Dossier, Arsenal >=1000 + Treasury, Naval Blockade/Derdia, AN Law)
        // Round 3: Outcomes UNLOCKED BY ACCUMULATED LEVERAGE:
        //   - Victory + Leverage>=3 => Force Border Reparations (+2 Budget, +2 Energy)!
        //   - Stalemate + Leverage>=5 => Break Smolak into returning Zille!
        //   - Total Fiasco + Leverage>=4 => Ransom & save southern Brenas!
        // =========================================================================
        public static void RegisterWarSmolakFinalParley(DialogueDatabase db)
        {{
            if (db.GetConversation("Turn_Zille_WarSmolakFinalParley") != null && db.GetConversation("Zille/WarSmolakFinalParley") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarSmolakParley;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/WarSmolakFinalParley";
            conv.ActorID = RomusId;
            conv.ConversantID = SmolakId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, SmolakId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Smolak_Parley_Intro",
                {cs("The neutral pavilion stood on a muddy rise between the forward trenches, draped in white flags snapping in the salt breeze off the Gulf of Moridia. Outside, Golden Guards in gold-trimmed greatcoats stood eye-to-eye with Wehzek guardsmen holding submachine guns. Inside, Wiktor Smolak sat slumped in a folding chair, pouring bitter black tea into a tin cup, a half-smoked cigarette dangling from his lips.")}, 2);

            AddLine(conv, 2, SmolakId, RomusId, "Smolak_Parley_Greeting",
                {cs("Look who finally arrived! The great King Romus of Rizia in the flesh. Tell me, Your Majesty... Care for some tea? Wehzek chicory blend. Tastes like gunpowder and wet mud, yet it keeps a man awake while the guns bark.")}, 3);

            var parleyHub = AddLine(conv, 3, RomusId, SmolakId, "Romus_Parley_Posture_Prompt",
                {cs("I sat across the scarred folding table, facing the bloodshot, calculating eyes of the Wehzek dictator.")});

            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Victory posture
            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 20)); // Stalemate posture
            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 30)); // Defiant victory posture
            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 40)); // Defeat posture

            AddChoice(conv, 10, SmolakId, "Posture_Victor",
                {cs("\"Your garrisons are broken, Smolak. Evacuate Zille today and let us settle the peace.\"")},
                {cs("Your garrisons are shattered and your sea lanes across the Gulf are contested, Smolak. We are not here to drink tea—we are here to settle the evacuation of Zille.")}, 100,
                "", {cs(OUT_VICTORY)});

            AddChoice(conv, 20, SmolakId, "Posture_Stalemate",
                {cs("\"Both armies have bled into this mud. Let us test what terms each side can still defend.\"")},
                {cs("Both our nations have bled enough along the hills of Zille. Before the Alliance of Nations chains us both, put your real terms on this table.")}, 200,
                "", {cs(OUT_STALEMATE)});

            AddChoice(conv, 30, SmolakId, "Posture_Defiant",
                {cs("\"You tore up the 1927 agreement and gambled on terror. Now Rizia settles the account.\"")},
                {cs("You tore up the 1927 treaty and thought you could extort House Toras forever. Every Wehzek soldier lost on this peninsula is on your head.")}, 100,
                "", {cs(OUT_VICTORY)});

            AddChoice(conv, 40, SmolakId, "Posture_Defeated",
                {cs("\"Our offensive stalled, Wiktor. Speak plainly and put your price on the table.\"")},
                {cs("Fortune favored your trenches on the field, Wiktor. Spare me your jokes and put your terms on the table so we may halt the slaughter.")}, 300,
                "", {cs(OUT_DEFEAT)});

            // ================= BRANCH A: DECISIVE VICTORY / OVERWHELMING TRIUMPH =================
            AddLine(conv, 100, SmolakId, RomusId, "Smolak_Defeated_Rant",
                {cs("Smolak ground his cigarette under his boot heel, his jaw twitching. \"Don't get drunk on victory, King Romus! Valdez blundered, sure—but I still have battalions in Wraclawitz, Contana whispering in Kyrute, and stubborn pride! I'll hand back Zille if you let my surviving boys sail home untouched—not one copper of reparations!\"")}, 101);

            var vicDuelHub = AddLine(conv, 101, NarratorId, RomusId, "Victory_Leverage_Duel_Hub",
                {cs("Smolak was testing your nerve—trying to evacuate his beaten army without paying a cent for the ruin in Zille. You could press a concrete advantage from your dossier first, or move straight to dictating final terms.")});

            vicDuelHub.outgoingLinks.Add(CreateLink(conv.id, 101, 103)); // Press Bombing Dossier (+2 Leverage)
            vicDuelHub.outgoingLinks.Add(CreateLink(conv.id, 101, 105)); // Flash >1000 Equipment & Treasury Stamina (+2 Leverage)
            vicDuelHub.outgoingLinks.Add(CreateLink(conv.id, 101, 107)); // Cite Blockade / Derdia Stranglehold (+2 Leverage)
            vicDuelHub.outgoingLinks.Add(CreateLink(conv.id, 101, 102)); // Move directly to terms

            AddChoice(conv, 103, SmolakId, "Vic_Duel_Dossier",
                {cs("\"[DOSSIER] Pay reparations, or we publish your Zille bombing complicity to every ambassador in Kyrute!\"")},
                {cs("No indemnities? Open your eyes, Wiktor: my briefcase holds verified dossiers on the Zille bombing. Pay for the silos and bridges your officers burned, or I distribute this file across Konstantium tonight!")}, 104,
                {cs("Variable[\"Zille_Parley_UsedDossier\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;")},
                {cs(f"{ANY_BOMBING_DOSSIER} and Variable[\"Zille_Parley_UsedDossier\"] ~= true")});

            AddLine(conv, 104, SmolakId, RomusId, "Ack_Vic_Dossier",
                {cs("Smolak's eye twitched violently as you tapped the sealed black folder. \"You smug little vulture...\" he hissed softly, lowering his bluff by a notch.")}, 102);

            AddChoice(conv, 105, SmolakId, "Vic_Duel_Arsenal",
                {cs("\"[ARSENAL >=1,000] Our depots hold over a thousand fresh arms and full war coffers—we can keep pushing!\"")},
                {cs("Bluff somewhere else, Smolak! Our quartermasters still hold over a thousand fresh weapons in Brenas and coin in our treasury. Say the word and our brigades embark right behind your retreating transports!")}, 106,
                {cs("Variable[\"Zille_Parley_UsedArsenal\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2;")},
                {cs(f"{EQUIP_GE_1000} and {BUDGET_CAN_SPEND1} and Variable[\"Zille_Parley_UsedArsenal\"] ~= true")});

            AddLine(conv, 106, SmolakId, RomusId, "Ack_Vic_Arsenal",
                {cs("Smolak glanced nervously toward the telegraph orderly outside the canvas flap. \"Keep your tanks anchored in Zille, Romus—nobody wants a march on Wraclawitz!\"")}, 102);

            AddChoice(conv, 107, SmolakId, "Vic_Duel_BlockadeDerdia",
                {cs("\"[ENCIRCLEMENT] Our ships choke the Gulf and Derdian raids burn your southern depots—you have no retreat!\"")},
                {cs("Your 'sail home untouched' assumes our fleet opens the Strait of Kreleck—and while Derdian raiders tear up your mainland roads, you cannot buy another week!")}, 108,
                {cs("Variable[\"Zille_Parley_UsedEncircle\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2;")},
                {cs(f"{BLOCKADE_OR_DERDIA} and Variable[\"Zille_Parley_UsedEncircle\"] ~= true")});

            AddLine(conv, 108, SmolakId, RomusId, "Ack_Vic_Encircle",
                {cs("Smolak swallowed hard, ash falling from his cigarette onto his tunic. \"Alright, alright, King—you've got me boxed in! What is your price?\"")}, 102);

            var victoryChoiceHub = AddLine(conv, 102, NarratorId, RomusId, "Victory_Terms_Prompt",
                {cs("Smolak leaned over the scarred table—cornered, bruised, yet bargaining furiously for what remained of Wehlen.")});

            victoryChoiceHub.outgoingLinks.Add(CreateLink(conv.id, 102, 110)); // Clean Zille Restoration
            victoryChoiceHub.outgoingLinks.Add(CreateLink(conv.id, 102, 115)); // Leverage>=3 Reparations (+2 Budget, +2 Energy)!
            victoryChoiceHub.outgoingLinks.Add(CreateLink(conv.id, 102, 120)); // Overwhelming Triumph (Deep Wehlen captured)

            AddChoice(conv, 110, SmolakId, "Accept_Decisive_Surrender",
                {cs("\"Zille returns unconditionally to Rizia. Your surviving troops may evacuate across the Gulf.\"")},
                {cs("Zille returns unconditionally to the Crown of Rizia today. Your surviving troops may board transports across the Gulf of Moridia under white flags—never to return.")}, 111,
                {cs("Variable[\"Zille_War_Outcome\"] = 4; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = true;")},
                {cs(OUT_VICTORY)});

            AddLine(conv, 111, SmolakId, RomusId, "Smolak_Signs_Decisive",
                {cs("Smolak snatched the pen and scrawled his signature with vicious strokes. \"Done! Pack up, boys, we're sailing home! Enjoy your oilfields and your headaches, Romus!\"")}, -1);

            AddChoice(conv, 115, SmolakId, "Demand_Leveraged_Reparations",
                {cs("\"[LEVERAGE] Return Zille AND pay war reparations (+2 Budget, +2 Energy) for the ruin you left!\"")},
                {cs("You lack the cards to refuse, Smolak. Sign the unconditional return of Zille AND two million in gold reconstruction credits plus emergency crude deliveries—or our press and our fleet bury you tonight!")}, 116,
                {cs("Variable[\"Zille_War_Outcome\"] = 4; Variable[\"Zille_Reparations_Won\"] = true; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) + 2; Variable[\"RiziaDLC.Resources_Energy\"] = (Variable[\"RiziaDLC.Resources_Energy\"] or 0) + 2;")},
                {cs(f"{OUT_VICTORY} and {LEV_REPARATIONS}")});

            AddLine(conv, 116, SmolakId, RomusId, "Smolak_Signs_Reparations",
                {cs("Smolak cursed viciously under his breath, glaring as if he wished his fountain pen were a dagger—then signed every schedule of gold and fuel deliveries. \"You squeezed every last drop, Romus! Take Zille and your blood money!\"")}, -1);

            AddChoice(conv, 120, SmolakId, "Demand_Overwhelming_Triumph",
                {cs("\"[TOTAL TRIUMPH] Cede Zille, pay massive indemnities (+4 Budget, +3 Energy), and free Grodzizg!\"")},
                {cs("Our forward divisions already sit inside mainland Wehlen. Cede Zille unconditionally, pay massive gold and fuel indemnities, demilitarize your southern coast, and grant Free City autonomy to Grodzizg—or our armor pushes to Wraclawitz!")}, 121,
                {cs("Variable[\"Zille_War_Outcome\"] = 5; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"Grodzizg_FreeCity\"] = true; Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) + 4; Variable[\"RiziaDLC.Resources_Energy\"] = (Variable[\"RiziaDLC.Resources_Energy\"] or 0) + 3;")},
                {cs(OUT_OVERWHELM)});

            AddLine(conv, 121, SmolakId, RomusId, "Smolak_Signs_Overwhelming",
                {cs("Smolak turned chalk-white as he stared at the map pins deep inside Wehlen. \"You're an absolute shark, Romus... Damn you, I'll sign! Just halt your tanks and keep Wraclawitz out of this!\"")}, -1);

            // ================= BRANCH B: BLOODY STALEMATE & LEVERAGE BREAKTHROUGH =================
            AddLine(conv, 200, SmolakId, RomusId, "Smolak_Stalemate_Opening",
                {cs("Smolak blew gray smoke toward the canvas roof. \"Neither of us can break the other cheaply, Romus. Your tanks stalled on Zille City's ring, and my boys can't crack Brenas. We can keep feeding men into artillery until Kyrute chains us both... or hear my compromise: a demilitarized Independent Buffer State in Zille!\"")}, 201);

            var staleDuelHub = AddLine(conv, 201, NarratorId, RomusId, "Stalemate_Leverage_Hub",
                {cs("Smolak watched your eyes like a card shark staking his final chip. If you have accumulated enough leverage—from bombing dossiers, full arsenals, naval blockade, or AN legitimacy—you might break this deadlock and force Zille back even without a total breakthrough.")});

            staleDuelHub.outgoingLinks.Add(CreateLink(conv.id, 201, 204)); // Counter with Bombing Evidence / AN Law (+2 Leverage)
            staleDuelHub.outgoingLinks.Add(CreateLink(conv.id, 201, 206)); // Counter with Arsenals >=1000 / Encirclement (+2 Leverage)
            staleDuelHub.outgoingLinks.Add(CreateLink(conv.id, 201, 202)); // Lucita skepticism -> Final Stalemate Choice
            staleDuelHub.outgoingLinks.Add(CreateLink(conv.id, 201, 203)); // No Lucita -> Final Stalemate Choice

            AddChoice(conv, 204, SmolakId, "Stalemate_Press_Evidence",
                {cs("\"Drop the 'neutral republic' farce! Our 1927 treaty rights and bombing dossier bury you at the AN!\"")},
                {cs("Don't lecture me about neutral states, Wiktor! The 1927 lease expired legally, the world knows about your terror tactics, and AN sanctions will strangle Wraclawitz long before our treasury breaks!")}, 205,
                {cs("Variable[\"Zille_Stale_PressedLaw\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2;")},
                {cs(f"({ANY_BOMBING_DOSSIER} or {AN_LEG_HIGH}) and Variable[\"Zille_Stale_PressedLaw\"] ~= true")});

            AddLine(conv, 205, SmolakId, RomusId, "Ack_Stale_Evidence",
                {cs("Smolak's smirk cracked slightly as he rubbed his temple. \"Lawyers and files... Fine, Romus, you've got teeth in Konstantium. What else do you think you have?\"")}, 201);

            AddChoice(conv, 206, SmolakId, "Stalemate_Press_Steel",
                {cs("\"Look at our Brenas depots and the Gulf—over a thousand spare arms while Valdez's convoys starve!\"")},
                {cs("Your trenches in Zille are running dry while our depots hold over a thousand reserve weapons and our ships/allies choke your resupply! You will break first in a war of attrition, Wiktor!")}, 207,
                {cs("Variable[\"Zille_Stale_PressedSteel\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2;")},
                {cs(f"({EQUIP_GE_1000} or {BLOCKADE_OR_DERDIA}) and Variable[\"Zille_Stale_PressedSteel\"] ~= true")});

            AddLine(conv, 207, SmolakId, RomusId, "Ack_Stale_Steel",
                {cs("Smolak stubbed out his cigarette roughly, eyes darting to the map pins along the Strait of Kreleck. \"Damn your navy and damn your warehouses...\"")}, 201);

            AddLine(conv, 202, NarratorId, RomusId, "Stalemate_Hub_Lucita",
                {cs("Lucita frowned beside you, awaiting your final call on whether to compromise, force victory through sheer leverage, or freeze the front.")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 203, NarratorId, RomusId, "Stalemate_Hub_NoLucita",
                {cs("Your staff officers stood silent as Smolak awaited your final verdict on the stalemate.")}, -1,
                {cs(LUCITA_GONE)});

            foreach (int h in new[] {{ 202, 203 }})
            {{
                AddLink(conv, h, 215); // Leverage >= 5 breakthrough!
                AddLink(conv, h, 210); // Independent Buffer
                AddLink(conv, h, 220); // Armed Ceasefire (Tactical Defeat)
            }}

            // BREAKTHROUGH OPTION: Force Zille Return on Stalemate if Leverage >= 5!
            AddChoice(conv, 215, SmolakId, "Force_Zille_Return_Leverage",
                {cs("\"[MASTER LEVERAGE] No buffer state—your position is untenable! Return Zille to Rizia NOW!\"")},
                {cs("Enough games, Wiktor. Between our 1927 treaty standing, our reserves, and the stranglehold closing around Wehlen, you cannot hold Zille another month. Sign the Restoration of Zille and pull your men across the Gulf—before you lose Wraclawitz too!")}, 216,
                {cs("Variable[\"Zille_War_Outcome\"] = 4; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"Zille_Leverage_Triumph\"] = true;")},
                {cs(f"{OUT_STALEMATE} and {LEV_SUPER}")});

            AddLine(conv, 216, SmolakId, RomusId, "Smolak_Folded_Leverage",
                {cs("Silence stretched for ten suffocating seconds inside the tent. Smolak stared at your face, then down at his cold tea, then suddenly slammed the pen into the parchment. \"You cold, calculating devil... You didn't win it cleanly on the hills, Romus, yet you boxed me in everywhere else! Take Zille back and choke on it!\"")}, -1);

            AddChoice(conv, 210, SmolakId, "Accept_Independent_Buffer",
                {cs("\"Agreed. Establish the Independent Neutral State of Zille under international charter.\"")},
                {cs("An Independent Neutral Zille. It ends the bloodshed, frees Zille from your grip, and separates our armies under AN oversight. I accept.")}, 211,
                {cs("Variable[\"Zille_War_Outcome\"] = 3; Variable[\"Zille_Independent_Buffer\"] = true; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false;")});

            AddLine(conv, 211, SmolakId, RomusId, "Smolak_Buffer_Signed",
                {cs("Smolak smiled with shrewd relief, clinking his tin cup against the table. \"A statesman's compromise, Romus. Let the clerks in Konstantium draft the charters.\"")}, -1);

            AddChoice(conv, 220, SmolakId, "Reject_Buffer_Ceasefire",
                {cs("\"Never. Zille is Rizian or nothing—we freeze the frontlines under an armed ceasefire.\"")},
                {cs("I will never sign away our sovereignty to an artificial buffer state. We freeze the frontlines under an armed ceasefire—this reckoning is merely postponed.")}, 221,
                {cs("Variable[\"Zille_War_Outcome\"] = 2; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false;")});

            AddLine(conv, 221, SmolakId, RomusId, "Smolak_Ceasefire_Signed",
                {cs("Smolak snorted, tossing his butt into the mud. \"Suit yourself, King. An armed truce it is.\"")}, -1);

            // ================= BRANCH C: TACTICAL DEFEAT / TOTAL FIASCO (+ LEVERAGE SALVAGE) =================
            AddLine(conv, 300, SmolakId, RomusId, "Smolak_Victorious_Mock",
                {cs("Smolak leaned back with a predatory grin, spreading his arms wide. \"How fast royal pride melts when the guns fall quiet, eh, Romus? General Valdez shattered your offensive!\"")}, -1);

            AddLine(conv, 301, SmolakId, RomusId, "Smolak_TacticalDefeat_Terms",
                {cs("\"You bled for zero ground gained! Withdraw behind the Brenas line, drop all claim to Zille, and swallow an armistice while my mood stays generous.\"")}, -1,
                {cs(OUT_TACTICAL_DEFEAT)});

            AddLine(conv, 302, SmolakId, RomusId, "Smolak_Fiasco_Terms",
                {cs("\"My armored columns sit inside Brenas right now, 'Your Majesty'! Sign over southern Brenas to Wraclawitz, or I let my tanks roll toward Porte Drazon!\"")}, -1,
                {cs('Variable["Zille_War_Outcome"] == 1')});

            AddLink(conv, 300, 301);
            AddLink(conv, 300, 302);

            // Salvage option on Total Fiasco if Leverage >= 4 AND Budget >= 2!
            AddChoice(conv, 305, SmolakId, "Salvage_Brenas_Leverage",
                {cs("\"[LEVERAGE SALVAGE] Take 2 Budget and drop claims on Zille—but AN pressure & our dossier bar you from Brenas!\"")},
                {cs("Hold your horses, Wiktor! Your forward columns are overextended, we hold bombing dossiers, and if you annex a single Rizian town in Brenas, Rumburg and the AN will crush Wehlen! Take 2 Budget in gold and keep your army strictly behind the pre-war border!")}, 306,
                {cs("Variable[\"Zille_War_Outcome\"] = 2; Variable[\"Brenas_Lost_To_Wehlen\"] = false; Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 2; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"RiziaDLC.ZilleReferendum_Lost\"] = true; Variable[\"Zille_Brenas_Saved_By_Leverage\"] = true;")},
                {cs(f"{OUT_FIASCO} and {LEV_HIGH} and {BUDGET_CAN_SPEND2}")});

            AddLine(conv, 306, SmolakId, RomusId, "Ack_Salvage_Brenas",
                {cs("Smolak froze halfway through his laughter, calculating rapidly behind narrowed eyes. \"Damn those Thornbourgh sharks... and damn your pocketbook. Fine, King—two million in gold, keep your Brenas towns, and crawl back south with nothing!\"")}, -1);

            AddChoice(conv, 310, SmolakId, "Accept_Tactical_Defeat",
                {cs("\"We withdraw behind the Brenas frontier and sign the bitter armistice.\"")},
                {cs("To spare our kingdom further ruin, Rizia accepts an armistice along the pre-war frontier and suspends claims over Zille. Do not mistake restraint for final submission.")}, 311,
                {cs("Variable[\"Zille_War_Outcome\"] = 2; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"RiziaDLC.ZilleReferendum_Lost\"] = true;")},
                {cs(OUT_TACTICAL_DEFEAT)});

            AddLine(conv, 311, SmolakId, RomusId, "Smolak_Signs_TacticalDefeat",
                {cs("Smolak cackled softly, signing with an exaggerated flourish. \"Enjoy explaining this triumph to your noble houses, Romus!\"")}, -1);

            AddChoice(conv, 320, SmolakId, "Accept_Total_Fiasco",
                {cs("\"Sign the humiliating surrender of southern Brenas to save Porte Drazon.\"")},
                {cs("To save the capital and our citizens from destruction, I sign this bitter surrender. Withdraw from the approaches to Porte Drazon.")}, 321,
                {cs("Variable[\"Zille_War_Outcome\"] = 1; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"Brenas_Lost_To_Wehlen\"] = true;")},
                {cs(OUT_FIASCO)});

            AddLine(conv, 321, SmolakId, RomusId, "Smolak_Signs_Fiasco",
                {cs("Smolak laughed uproariously, slapping the table. \"History will remember today, King Romus! Your father gave me Zille; you just handed me Brenas! Good luck surviving your own generals tonight!\"")}, -1);

            AddLink(conv, 301, 310);
            AddLink(conv, 301, 320);
            AddLink(conv, 301, 305);
            AddLink(conv, 302, 320);
            AddLink(conv, 302, 305);

            AddConversationWithAlias(db, conv, "Zille/WarSmolakFinalParley", "Turn_Zille_WarSmolakFinalParley");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Smolak Final Parley (ID 9992) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 11: Turn_Zille_WarPeaceTreaty (ID 9993) - PEACE TREATY CEREMONY
        // Features:
        // - Outcome-gated ratification + separate Zille vs Pales casualty reflections
        // - AN Legitimacy reflection + Leverage Reparations Treaty variant
        // - Full Hugo/Lucita/Taddeus/Carlos absence & hostility handling
        // =========================================================================
        public static void RegisterWarPeaceTreaty(DialogueDatabase db)
        {{
            if (db.GetConversation("Turn_Zille_WarPeaceTreaty") != null && db.GetConversation("Zille/WarPeaceTreaty") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarPeaceTreaty;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/WarPeaceTreaty";
            conv.ActorID = RomusId;
            conv.ConversantID = HugoId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, HugoId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Treaty_Ceremony_Intro",
                {cs("The Grand Throne Room of Palas Rezna had been arranged for the formal ratification of the Treaty of Zille. Foreign ambassadors from Konstantium, military commanders, and provincial nobles stood beneath portraits of Rizian kings before the parchment instrument and the royal seal of House Toras.")}, -1);

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Treaty_Declaration",
                {cs("Your Majesty... The guns have fallen silent across the peninsula. The scribes await your royal seal to close this war in the annals of Rizia.")}, -1,
                {cs(HUGO_FREE)});

            AddLine(conv, 102, LaurentoId, RomusId, "Laurento_Treaty_Declaration",
                {cs("Your Majesty. The diplomatic instrument lies before you, witnessed by foreign envoys from Konstantium. The realm awaits your royal signature.")}, -1,
                {cs(HUGO_GONE)});

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            // AN Standing + Separate Fronts acknowledgment before signing
            AddLine(conv, 200, LaurentoId, RomusId, "Treaty_AN_HighLegitimacy",
                {cs("\"Thanks to our strict adherence to the lapsed 1927 agreement and civilized conduct, even neutral delegates in Kyrute acknowledge Rizia acted with restraint.\"")}, 3,
                {cs(AN_LEG_HIGH)});

            AddLine(conv, 201, LaurentoId, RomusId, "Treaty_AN_PalesShadow",
                {cs("\"While our Zille casualty ledger stands distinct, fighting concurrently against Pales has stretched foreign sympathy thin—we must ratify cleanly and stabilize the realm.\"")}, 3,
                {cs(f"not ({AN_LEG_HIGH}) and ({PALES_CASUALTIES_PRESENT})")});

            AddLine(conv, 202, LaurentoId, RomusId, "Treaty_AN_Standard",
                {cs("\"Both superpowers are closely observing the exact clauses inscribed on this parchment today, Your Majesty.\"")}, 3,
                {cs(f"not ({AN_LEG_HIGH}) and ({NO_PALES_CASUALTIES})")});

            foreach (int h in new[] {{ 2, 102 }})
            {{
                AddLink(conv, h, 200);
                AddLink(conv, h, 201);
                AddLink(conv, h, 202);
            }}

            var outcomeHub = AddLine(conv, 3, NarratorId, RomusId, "Outcome_Hub_Prompt",
                {cs("You stepped forward to the marble table to affix the Great Seal of Rizia.")});

            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Decisive Victory
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 15)); // Leveraged Reparations Victory
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 20)); // Overwhelming Triumph
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 30)); // Independent Zille Buffer
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 40)); // Tactical Defeat
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 50)); // Total Fiasco

            AddChoice(conv, 10, HugoId, "Sign_Decisive_Victory",
                {cs("\"Sign the Treaty of Restoration: Zille returns to the Crown of Rizia!\"")},
                {cs("In the presence of Saint Wruhec and the noble estates of Rizia, I affix the royal seal. Zille is liberated and reunited with our kingdom!")}, -1,
                {cs("Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"RiziaDLC.Zille_PromisedToHouseToras\"] = true; Variable[\"RiziaDLC.MapLayer_Zille_Brenas\"] = true;")},
                {cs('((Variable["Zille_War_Outcome"] or 0) == 4 and Variable["Zille_Reparations_Won"] ~= true) or (Variable["Zille_War_Outcome"] or 0) == 0')});

            AddChoice(conv, 15, HugoId, "Sign_Victory_Reparations",
                {cs("\"Sign the Treaty of Restoration & Indemnity: Zille returns and Wehlen pays reconstruction tribute!\"")},
                {cs("By our military and diplomatic leverage, Zille returns home AND Wraclawitz delivers gold and energy indemnities to rebuild every ruined harbor and silo in Brenas!")}, -1,
                {cs("Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"RiziaDLC.Zille_PromisedToHouseToras\"] = true; Variable[\"RiziaDLC.MapLayer_Zille_Brenas\"] = true;")},
                {cs('Variable["Zille_Reparations_Won"] == true')});

            AddLine(conv, 11, HugoId, RomusId, "Ack_Decisive_Ceremony",
                {cs("The throne room erupted into thunderous cheers, bells pealing from every sanctuary in Porte Drazon. Hugo wiped tears of joy from his eyes, bowing deeply before his King. \"Nearly thirty years of grief washed away in triumph! Long live King Romus the Restorer!\"")}, -1,
                {cs(HUGO_FREE)});

            AddLine(conv, 111, LaurentoId, RomusId, "Ack_Decisive_NoHugo",
                {cs("Thunderous applause shook the marble pillars as cathedral bells rang across Porte Drazon. Laurento bowed deeply. \"A historic restoration, Your Majesty. Zille is home.\"")}, -1,
                {cs(HUGO_GONE)});

            foreach (int vCh in new[] {{ 10, 15 }})
            {{
                AddLink(conv, vCh, 11);
                AddLink(conv, vCh, 111);
            }}

            AddChoice(conv, 20, HugoId, "Sign_Overwhelming_Triumph",
                {cs("\"Sign the Treaty of Total Reparations: Wehlen humbled and Grodzizg placed under protection!\"")},
                {cs("By this treaty, Wehlen surrenders Zille unconditionally, pays immense war indemnities, demilitarizes its southern shore, and recognizes the Free City of Grodzizg. House Toras stands supreme!")}, -1,
                {cs("Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"RiziaDLC.Zille_PromisedToHouseToras\"] = true; Variable[\"RiziaDLC.MapLayer_Zille_Brenas\"] = true; Variable[\"Grodzizg_FreeCity\"] = true;")},
                {cs(OUT_OVERWHELM)});

            AddLine(conv, 21, LucitaId, RomusId, "Ack_Overwhelming_Ceremony",
                {cs("Lucita unsheathed her ceremonial saber and saluted with shining eyes. \"An epochal triumph, Your Majesty! We have broken Wehlen's military power across the Gulf for a generation!\"")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 121, CarlosId, RomusId, "Ack_Overwhelming_NoLucita",
                {cs("General Carlos Azaro raised his saber in crisp salute. \"An epochal victory, Your Majesty. Rizia stands unchallenged across the Gulf of Moridia.\"")}, -1,
                {cs(LUCITA_GONE)});

            AddLink(conv, 20, 21);
            AddLink(conv, 20, 121);

            AddChoice(conv, 30, HugoId, "Sign_Independent_Buffer",
                {cs("\"Sign the Treaty of Neutrality: The Independent Republic of Zille is established.\"")},
                {cs("To spare our people further carnage, I sign the charter establishing the Independent Neutral State of Zille. May this neutral territory stand as a peaceful bridge rather than a battlefield.")}, 31,
                {cs("Variable[\"Zille_Independent_Buffer\"] = true; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false;")},
                {cs('((Variable["Zille_War_Outcome"] or 0) == 3 or Variable["Zille_Independent_Buffer"] == true or (Variable["Zille_War_Outcome"] or 0) == 0)')});

            AddLine(conv, 31, LaurentoId, RomusId, "Ack_Buffer_Ceremony",
                {cs("Laurento bowed solemnly. \"The Alliance of Nations applauds your royal restraint, Your Majesty. Peace and guaranteed transit across the Strait of Kreleck are secured.\"")}, -1);

            AddChoice(conv, 40, HugoId, "Sign_Tactical_Defeat",
                {cs("\"Sign the Armed Armistice: Hold the Brenas frontier under a bitter truce.\"")},
                {cs("With a heavy heart, I sign this armistice. Our soldiers fought with valor, yet Brenas must endure while we rebuild our strength. Zille remains outside our grasp... for now.")}, -1,
                {cs("Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"RiziaDLC.ZilleReferendum_Lost\"] = true;")},
                {cs('(Variable["Zille_Independent_Buffer"] ~= true and ((Variable["Zille_War_Outcome"] or 0) == 2 or (Variable["Zille_War_Outcome"] or 0) == 0))')});

            AddLine(conv, 41, HugoId, RomusId, "Ack_Tactical_Defeat",
                {cs("A somber silence fell over the throne room. Hugo sighed deeply, his shoulders bowed. \"A bitter day for House Toras, Romus—yet Brenas survives, and the realm endures.\"")}, -1,
                {cs(HUGO_FREE)});

            AddLine(conv, 141, LaurentoId, RomusId, "Ack_Tactical_Defeat_NoHugo",
                {cs("A heavy hush fell over the chamber. Laurento lowered his eyes solemnly. \"A bitter hour, Your Majesty, yet the kingdom remains intact to rise another day.\"")}, -1,
                {cs(HUGO_GONE)});

            AddLink(conv, 40, 41);
            AddLink(conv, 40, 141);

            AddChoice(conv, 50, HugoId, "Sign_Total_Fiasco",
                {cs("\"Sign the Instrument of Surrender: Concede southern Brenas to save Porte Drazon.\"")},
                {cs("To prevent the destruction of Porte Drazon, I sign this humiliating peace. May God forgive me for the tragedy that has befallen our kingdom.")}, -1,
                {cs("Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"Brenas_Lost_To_Wehlen\"] = true; Variable[\"RiziaDLC.Azaro_HasPowerToCoup\"] = true;")},
                {cs(OUT_FIASCO)});

            AddLine(conv, 51, NarratorId, RomusId, "Ack_Total_Fiasco",
                {cs("Shouts of outrage broke out among the assembled officers. Duke Taddeus stormed from the hall in disgust while dark whispers of a military coup echoed through the stone corridors.")}, -1,
                {cs(TADDEUS_FREE)});

            AddLine(conv, 151, NarratorId, RomusId, "Ack_Total_Fiasco_NoTaddeus",
                {cs("Shouts of outrage erupted among the assembled noble houses and generals. Officers slammed their sabers onto the marble floor, and whispers of mutiny filled Palas Rezna.")}, -1,
                {cs(TADDEUS_GONE)});

            AddLink(conv, 50, 51);
            AddLink(conv, 50, 151);

            AddConversationWithAlias(db, conv, "Zille/WarPeaceTreaty", "Turn_Zille_WarPeaceTreaty");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Peace Treaty Ceremony (ID 9993) into masterDatabase!");
        }}
    }}
}}
'''
    with open('src/GreatZilleSolution/ZilleDialogueSystem.TreatyScenes.cs', 'w', encoding='utf-8') as f:
        f.write(code)
    print("Successfully built src/GreatZilleSolution/ZilleDialogueSystem.TreatyScenes.cs")


if __name__ == '__main__':
    generate_war_scenes()
    generate_diplomacy_scenes()
    generate_treaty_scenes()
    print("ALL 11 MASTER GREAT ZILLE SCENES BUILT AND DEPLOYED SUCCESSFULLY!")
