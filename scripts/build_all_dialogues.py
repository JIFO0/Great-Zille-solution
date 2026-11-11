import os

def cs(s):
    if not s:
        return '""'
    escaped = s.replace('\\', '\\\\').replace('"', '\\"').replace('\r\n', '\\n').replace('\n', '\\n').replace('\r', '\\n')
    return f'"{escaped}"'

# Common Lua state predicates (MECE & nil-safe)
LUCITA_FREE = 'Variable["RiziaDLC.Lucita_Arrested"] ~= true and Variable["RiziaDLC.Lucita_Executed"] ~= true'
LUCITA_GONE = '(Variable["RiziaDLC.Lucita_Arrested"] == true or Variable["RiziaDLC.Lucita_Executed"] == true)'
LUCITA_MARRIED = f'{LUCITA_FREE} and Variable["RiziaDLC.Lucita_Married"] == true'
LUCITA_ROMANCE = f'{LUCITA_FREE} and Variable["RiziaDLC.Lucita_Married"] ~= true and (Variable["RiziaDLC.Lucita_RomanceHappened"] == true or (Variable["RiziaDLC.Relations_Lucita_Romance"] or 0) > 0)'
LUCITA_HOSTILE = f'{LUCITA_FREE} and Variable["RiziaDLC.Lucita_Married"] ~= true and Variable["RiziaDLC.Lucita_RomanceHappened"] ~= true and (Variable["RiziaDLC.Relations_Lucita_Romance"] or 0) <= 0 and (Variable["RiziaDLC.Country_HouseAzaro_Enemy"] == true or Variable["RiziaDLC.Turn06_Council_LucitaOffended"] == true)'
LUCITA_NORMAL = f'{LUCITA_FREE} and Variable["RiziaDLC.Lucita_Married"] ~= true and Variable["RiziaDLC.Lucita_RomanceHappened"] ~= true and (Variable["RiziaDLC.Relations_Lucita_Romance"] or 0) <= 0 and Variable["RiziaDLC.Country_HouseAzaro_Enemy"] ~= true and Variable["RiziaDLC.Turn06_Council_LucitaOffended"] ~= true'

HUGO_FREE = 'Variable["RiziaDLC.Hugo_Arrested"] ~= true and Variable["RiziaDLC.Hugo_Executed"] ~= true and Variable["RiziaDLC.Hugo_Resigned"] ~= true'
HUGO_GONE = '(Variable["RiziaDLC.Hugo_Arrested"] == true or Variable["RiziaDLC.Hugo_Executed"] == true or Variable["RiziaDLC.Hugo_Resigned"] == true)'
HUGO_HOSTILE = f'{HUGO_FREE} and Variable["RiziaDLC.Country_HouseToras_Enemy"] == true'
HUGO_NORMAL = f'{HUGO_FREE} and Variable["RiziaDLC.Country_HouseToras_Enemy"] ~= true'
VIZIER_ANGELICA = f'{HUGO_GONE} and Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true and Variable["RiziaDLC.Angelica_Arrested"] ~= true and Variable["RiziaDLC.Angelica_Executed"] ~= true'
VIZIER_SAL = f'{HUGO_GONE} and Variable["RiziaDLC.Council_GrandVizier_Angelica"] ~= true and Variable["RiziaDLC.Council_GrandVizier_Sal"] == true and Variable["RiziaDLC.Sal_Arrested"] ~= true and Variable["RiziaDLC.Sal_Executed"] ~= true'
VIZIER_LAURENTO = f'{HUGO_GONE} and not ({VIZIER_ANGELICA}) and not ({VIZIER_SAL})'

TADDEUS_FREE = 'Variable["RiziaDLC.Taddeus_Arrested"] ~= true and Variable["RiziaDLC.Taddeus_Executed"] ~= true'
TADDEUS_GONE = '(Variable["RiziaDLC.Taddeus_Arrested"] == true or Variable["RiziaDLC.Taddeus_Executed"] == true)'

TITUS_FREE = 'Variable["RiziaDLC.Titus_Arrested"] ~= true and Variable["RiziaDLC.Titus_Executed"] ~= true'
TITUS_GONE = '(Variable["RiziaDLC.Titus_Arrested"] == true or Variable["RiziaDLC.Titus_Executed"] == true)'

SAL_FREE = 'Variable["RiziaDLC.Sal_Arrested"] ~= true and Variable["RiziaDLC.Sal_Executed"] ~= true'
SAL_GONE = '(Variable["RiziaDLC.Sal_Arrested"] == true or Variable["RiziaDLC.Sal_Executed"] == true)'

ANGELICA_FREE = 'Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true and Variable["RiziaDLC.Angelica_Arrested"] ~= true and Variable["RiziaDLC.Angelica_Executed"] ~= true'
ANGELICA_GONE = '(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] ~= true or Variable["RiziaDLC.Angelica_Arrested"] == true or Variable["RiziaDLC.Angelica_Executed"] == true)'

MANUS_FREE = 'Variable["RiziaDLC.Manus_Arrested"] ~= true and Variable["RiziaDLC.Manus_Executed"] ~= true and Variable["RiziaDLC.Manus_Gone"] ~= true and Variable["RiziaDLC.Manus_EarlyExile"] ~= true and Variable["RiziaDLC.Manus_DiesInWar"] ~= true'
MANUS_GONE = '(Variable["RiziaDLC.Manus_Arrested"] == true or Variable["RiziaDLC.Manus_Executed"] == true or Variable["RiziaDLC.Manus_Gone"] == true or Variable["RiziaDLC.Manus_EarlyExile"] == true or Variable["RiziaDLC.Manus_DiesInWar"] == true)'

TWO_FRONT = '(Variable["RiziaDLC.Pales_War"] == true or Variable["RiziaDLC.Diplomacy_Pales_DeclareWar"] == true)'
NO_TWO_FRONT = '(Variable["RiziaDLC.Pales_War"] ~= true and Variable["RiziaDLC.Diplomacy_Pales_DeclareWar"] ~= true)'

L1 = 'Variable["Zille_Lespia_Intel"] == true'
L0 = 'Variable["Zille_Lespia_Intel"] ~= true'
R1 = 'Variable["Zille_Rumburg_Munitions"] == true'
R0 = 'Variable["Zille_Rumburg_Munitions"] ~= true'
D1 = 'Variable["Zille_DerdiaHybridActive"] == true'
D0 = 'Variable["Zille_DerdiaHybridActive"] ~= true'


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
        // Hugo Toras, Lucita Azaro, Elena Werner, Laurento Esquibel, Titus Gordion.
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
                {cs("Outside the council chamber windows, gray rain lashed against the stone spires of Palas Rezna. An emergency war map of the Brenas-Zille peninsula and the Gulf of Moridia lay unfurled across the mahogany table, weighed down by heavy bronze candleholders. The ministers took their seats in somber silence, the gravity of the hour hanging heavy in the air.")}, 2);

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Planning_Open",
                {cs("Your Majesty... We have convened the Crown Council under extraordinary circumstances. Smolak's continued defiance and the escalating tensions in Zille have brought our kingdom to a decisive crossroads.")}, 3,
                {cs(HUGO_NORMAL)});

            AddLine(conv, 102, HugoId, RomusId, "Hugo_Planning_Open_Hostile",
                {cs("Your Majesty. Though relations between the Crown and House Toras have grown strained, the integrity of the realm leaves us no choice but to confront Smolak's continued defiance in Zille.")}, 3,
                {cs(HUGO_HOSTILE)});

            AddLine(conv, 103, LaurentoId, RomusId, "Laurento_Planning_Open_NoHugo",
                {cs("Your Majesty. In the Grand Vizier's absence, we have convened an emergency council. Smolak's continued defiance in Zille has brought our kingdom to a decisive crossroads.")}, 3,
                {cs(HUGO_GONE)});

            var e1 = conv.GetDialogueEntry(1);
            e1.outgoingLinks.Clear();
            e1.outgoingLinks.Add(CreateLink(conv.id, 1, 2));
            e1.outgoingLinks.Add(CreateLink(conv.id, 1, 102));
            e1.outgoingLinks.Add(CreateLink(conv.id, 1, 103));

            var stanceHub = AddLine(conv, 3, RomusId, HugoId, "Romus_Planning_Posture_Prompt",
                {cs("I looked at the gathered faces of my council, each waiting for their King to establish the direction of the realm.")});

            stanceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Decisive force
            stanceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11)); // Pragmatic caution
            stanceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12)); // Sovereign legalism

            AddChoice(conv, 10, HugoId, "Posture_Force",
                {cs("\"Over twenty-five years of national humiliation ends here. It is time the Crown plans the military reclamation of Zille.\"")},
                {cs("Over twenty-five years of national humiliation ends here. Smolak will not return our territory through words. It is time the Crown plans the military reclamation of Zille by force of arms.")}, -1,
                {cs("Variable[\"Zille_Planning_Stance\"] = \"Force\";")});

            AddChoice(conv, 11, HugoId, "Posture_Pragmatic",
                {cs("\"We must weigh our capabilities soberly. Can the Kingdom truly bear the burden of a war against Wehlen?\"")},
                {cs("We must weigh our capabilities soberly. Can our treasury, our military, and our people truly bear the burden of a war against Wehlen? I need honest counsel, not bravado.")}, -1,
                {cs("Variable[\"Zille_Planning_Stance\"] = \"Cautious\";")});

            AddChoice(conv, 12, HugoId, "Posture_Legal",
                {cs("\"The 1927 agreement has expired. Wehlen's presence is an unlawful occupation. We will uphold our sovereign right.\"")},
                {cs("The 1927 agreement has expired. Wehlen's continued presence is an unlawful foreign occupation. If Smolak refuses to withdraw, we have every legal and sovereign right to expel his garrisons.")}, -1,
                {cs("Variable[\"Zille_Planning_Stance\"] = \"Legal\";")});

            // Post-stance reaction: Hugo if free, else Laurento
            AddLine(conv, 20, HugoId, RomusId, "Hugo_Dynastic_Warning",
                {cs("Romus... As your uncle and your Grand Vizier, I must urge profound care. Your father, King Valero, leased Zille to quell internal turmoil when the throne itself was shaking. If we march across that frontier and stumble, the divine authority of House Toras will suffer a blow from which it may never recover.")}, -1,
                {cs(HUGO_FREE)});

            AddLine(conv, 120, LaurentoId, RomusId, "Laurento_Dynastic_Warning",
                {cs("Your Majesty, I must urge profound care. King Valero signed the 1927 agreement under immense pressure; if our armies march across the Brenas-Zille frontier and stumble, the Crown's prestige across South Merkopa will suffer grievously.")}, -1,
                {cs(HUGO_GONE)});

            foreach (int cid in new[] {{ 10, 11, 12 }})
            {{
                AddLink(conv, cid, 20);
                AddLink(conv, cid, 120);
            }}

            // Military appraisal: Lucita if free, else Taddeus or Carlos
            AddLine(conv, 21, LucitaId, RomusId, "Lucita_Military_Appraisal_1",
                {cs("With respect, inaction is far more dangerous, Your Majesty. General Valdez commands four Wehzek brigades on the peninsula: an armored detachment at the central rail hub of Wiktrany, two dug-in infantry brigades around Zille City itself, and a garrison guarding the northern port of Munat.")}, 22,
                {cs(LUCITA_FREE)});

            AddLine(conv, 22, LucitaId, RomusId, "Lucita_Military_Appraisal_2",
                {cs("Valdez's men are largely conscripts, supplied by sea across the Gulf of Moridia and demoralized by Smolak's erratic purges. The Azaro divisions and the Royal Army possess superior mechanized armor and professional training. If we strike swiftly before Wehzek warships and transports reinforce Munat, his outer line will collapse like dry timber.")}, 23);

            AddLine(conv, 121, TaddeusId, RomusId, "Taddeus_Military_Appraisal",
                {cs("Inaction is far more dangerous, Your Majesty. General Valdez commands four Wehzek brigades across the peninsula—concentrated at Wiktrany, Zille City, and the port of Munat—supplied by sea across the Gulf of Moridia. If our divisions strike decisively before Wehlen ships reinforcements through the Strait of Kreleck, his perimeter will break.")}, 23,
                {cs(f"{LUCITA_GONE} and {TADDEUS_FREE}")});

            AddLine(conv, 122, CarlosId, RomusId, "Carlos_Military_Appraisal",
                {cs("With respect, Your Majesty, inaction invites further humiliation. General Valdez holds four Wehzek brigades between Wiktrany, Zille City, and the port of Munat, relying on sea convoys across the Gulf of Moridia. Strike decisively before reinforcements land, and his perimeter will crack.")}, 23,
                {cs(f"{LUCITA_GONE} and {TADDEUS_GONE}")});

            foreach (int prev in new[] {{ 20, 120 }})
            {{
                AddLink(conv, prev, 21);
                AddLink(conv, prev, 121);
                AddLink(conv, prev, 122);
            }}

            AddLine(conv, 23, ElenaId, RomusId, "Elena_Economic_Reality",
                {cs("Courage does not buy diesel, Your Majesty. Our royal treasury cannot afford wishful thinking. A mobile offensive consumes petroleum and replacement munitions at an exorbitant burn rate. If the operation drags into a protracted siege, we face staggering deficits and domestic inflation.")}, 24);

            AddLine(conv, 24, LaurentoId, RomusId, "Laurento_International_Horizon",
                {cs("The diplomatic battleground is equally hazardous, Your Majesty. Chancellor Hegel of Valgsland and United Contana will condemn our offensive as monarchist aggression. However, because the 1927 lease has unambiguously lapsed, Prime Minister Alvarez of Lespia and the ATO powers will hesitate to intervene against us if we present the campaign as a swift, localized restoration of sovereign order.")}, -1);

            AddLine(conv, 25, TitusId, RomusId, "Titus_Security_Estela",
                {cs("Internal security must not be overlooked, Your Majesty. Su Omina and ATA networks inside Zille are ready to disrupt Wehzek communications. Furthermore, the Golden Guard has prepared elite detachments to secure Queen Mother Estela's childhood family home in Zille's harbor district the moment our spearheads enter the city.")}, 30,
                {cs(TITUS_FREE)});

            AddLine(conv, 125, NarratorId, RomusId, "Security_NoTitus",
                {cs("Military intelligence officers quietly noted that pro-Rizian networks inside Zille stood ready to disrupt Wehzek communications, and vanguard units had orders to protect Queen Mother Estela's old family neighborhood in the harbor district.")}, 30,
                {cs(TITUS_GONE)});

            AddLink(conv, 24, 25);
            AddLink(conv, 24, 125);

            var inquiryHub = AddLine(conv, 30, NarratorId, RomusId, "Planning_Inquiry_Hub",
                {cs("The room grew quiet as the advisors awaited your direction. Several strategic questions demanded clarification before a mobilization decree could be issued.")});

            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 31)); // Question Military
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 32)); // Question Elena
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 33)); // Question Laurento
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 34)); // Question Security
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Conclude planning

            AddChoice(conv, 31, LucitaId, "Inquire_Lucita",
                {cs("\"What terrain obstacles must our armored divisions overcome in Zille?\"")},
                {cs("Detail the terrain obstacles our mechanized units must overcome between Brenas and Zille. Where will Valdez make his stand?")}, -1);

            AddLine(conv, 35, LucitaId, RomusId, "Answer_Lucita",
                {cs("The central approach crosses the coastal lowlands and marshlands surrounding Wiktrany. If we punch through the central highway junction, we sever Valdez's lateral communications between Nanta and Zille City, while the Royal Navy contests his supply ships in the Gulf of Moridia. If heavy rains flood the marshes, however, our tanks will need solid logistics out of Brenas.")}, 30,
                {cs(LUCITA_FREE)});

            AddLine(conv, 135, CarlosId, RomusId, "Answer_Carlos_Terrain",
                {cs("The approach from Brenas leads through coastal hills and marshlands around Wiktrany, Your Majesty. Seizing that central road junction splits Valdez's garrisons, while our warships cut his sea lanes across the Gulf of Moridia. Heavy rains can bog down armor in the lowlands, so supply from Brenas will be decisive.")}, 30,
                {cs(LUCITA_GONE)});

            AddLink(conv, 31, 35);
            AddLink(conv, 31, 135);

            AddChoice(conv, 32, ElenaId, "Inquire_Elena",
                {cs("\"Elena, what financial reserves can we mobilize without bankrupting social programs?\"")},
                {cs("Elena, what financial reserves can we tap without crippling municipal budgets and domestic welfare?")}, 36);

            AddLine(conv, 36, ElenaId, RomusId, "Answer_Elena",
                {cs("If we issue royal war bonds and secure foreign energy credits, we can absorb the initial shocks. But the logistics framework is paramount-supplying the army locally out of Brenas granaries and coastal convoys will conserve gold, whereas shipping everything by rail from Montaklar will burn through our strategic oil reserves.")}, 30);

            AddChoice(conv, 33, LaurentoId, "Inquire_Laurento",
                {cs("\"Laurento, can we secure a veto or friendly neutrality in the Alliance of Nations?\"")},
                {cs("Laurento, can we secure a veto or friendly neutrality from the major powers in the Alliance of Nations?")}, 37);

            AddLine(conv, 37, LaurentoId, RomusId, "Answer_Laurento",
                {cs("Queen Beatrice of Rumburg will stand firmly with us in the AN, provided we maintain GRACE solidarity. Prime Minister Alvarez can be persuaded through economic incentives to keep Lespia's radar and reconnaissance active for our benefit. Smolak will find himself isolated across the sea if we strike decisively.")}, 30);

            AddChoice(conv, 34, TitusId, "Inquire_Titus",
                {cs("\"How confident are we in protecting Queen Estela's childhood home and civilian loyalists?\"")},
                {cs("How confident are you that our vanguard can shield Queen Mother Estela's childhood home in Zille and protect civilian loyalists?")}, -1);

            AddLine(conv, 38, TitusId, RomusId, "Answer_Titus",
                {cs("Completely confident, Your Majesty. My finest Golden Guard detachment is briefed and ready to ride or drop with the very vanguard of the advance. No harm will come to the Queen Mother's old neighborhood or her late family's home.")}, 30,
                {cs(TITUS_FREE)});

            AddLine(conv, 138, CarlosId, RomusId, "Answer_Security_NoTitus",
                {cs("Our forward reconnaissance battalions have standing orders to cordon off the harbor district around Queen Mother Estela's childhood home the moment we enter Zille City, Your Majesty.")}, 30,
                {cs(TITUS_GONE)});

            AddLink(conv, 34, 38);
            AddLink(conv, 34, 138);

            AddChoice(conv, 40, HugoId, "Conclude_Planning",
                {cs("\"The decision is made. Prepare the kingdom for war. Convene the Logistics Summit in Brenas.\"")},
                {cs("The decision is made. The Crown resolves on the military reclamation of Zille. Draft the preliminary deployment orders and convene the provincial lords and military command for the Logistics Summit. We will resolve our supply lines once and for all.")}, -1,
                {cs("Variable[\"Zille_War_Planning_Done\"] = true; Variable[\"Zille_War_Sentiment\"] = 3;")});

            AddLine(conv, 41, HugoId, RomusId, "Hugo_Planning_Close",
                {cs("\"As your sovereign will decrees, Your Majesty. May Saint Wruhec guide our banners and preserve our realm.\"")}, -1,
                {cs(HUGO_FREE)});

            AddLine(conv, 141, LaurentoId, RomusId, "Laurento_Planning_Close",
                {cs("\"Your sovereign will is clear, Your Majesty. The ministry will ready all diplomatic dispatches for the coming storm.\"")}, -1,
                {cs(HUGO_GONE)});

            AddLink(conv, 40, 41);
            AddLink(conv, 40, 141);

            AddLine(conv, 42, LucitaId, RomusId, "Lucita_Planning_Close",
                {cs("Lucita snapped to attention and saluted crisply. \"The General Staff will initiate immediate preparations. The road to Zille begins now, Your Majesty.\"")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 142, CarlosId, RomusId, "Carlos_Planning_Close",
                {cs("General Carlos Azaro saluted sharply. \"The General Staff will initiate immediate preparations. Our divisions will be ready, Your Majesty.\"")}, -1,
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
        // Handles Angelica exiled/pardoned/arrested, Manus exiled/arrested/Vina,
        // Leona Sazon fallback, Lucita/Taddeus arrested/hostile, Hugo absent.
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

            // Intro variants based on who is physically present
            AddLine(conv, 1, NarratorId, RomusId, "Logistics_Intro_BothSazon",
                {cs("The atmosphere inside the State Dining Hall of Palas Rezna crackled with noble animosity. Servants had cleared the banquet tables for logistical ledgers, railway maps, and provincial supply manifests. On one side sat House Azaro's commanders in crisp uniform; on the other sat Duchess Angelica Sazon and Manus Sazon in dark Brenas velvet.")}, -1,
                {cs(f"{ANGELICA_FREE} and {MANUS_FREE}")});

            AddLine(conv, 101, NarratorId, RomusId, "Logistics_Intro_ManusOnly",
                {cs("The State Dining Hall of Palas Rezna was tense with quiet hostility. Logistical ledgers and railway maps covered the long oak table. Facing House Azaro's uniformed generals sat Manus Sazon alone—his mother, Duchess Angelica, still absent from the court.")}, -1,
                {cs(f"{ANGELICA_GONE} and {MANUS_FREE}")});

            AddLine(conv, 102, NarratorId, RomusId, "Logistics_Intro_AngelicaOnly",
                {cs("The State Dining Hall of Palas Rezna crackled with aristocratic tension. Across the ledger-strewn table from House Azaro's officers sat Duchess Angelica Sazon alone, representing Brenas in the absence of her son Manus.")}, -1,
                {cs(f"{ANGELICA_FREE} and {MANUS_GONE}")});

            AddLine(conv, 103, NarratorId, RomusId, "Logistics_Intro_LeonaOnly",
                {cs("The State Dining Hall of Palas Rezna was frigid with mutual suspicion. With both Angelica and Manus Sazon absent from the court, Countess Leona Sazon of Sallabes had been summoned to represent the mercantile houses of Brenas opposite House Azaro's officers.")}, -1,
                {cs(f"{ANGELICA_GONE} and {MANUS_GONE}")});

            foreach (int iId in new[] {{ 1, 101, 102, 103 }})
            {{
                AddLink(conv, 0, iId);
                AddLink(conv, iId, 2);
                AddLink(conv, iId, 104);
            }}

            // Azaro Opener (Taddeus if free, else Carlos)
            AddLine(conv, 2, TaddeusId, RomusId, "Taddeus_Logistics_Opener",
                {cs("Your Majesty! The General Staff cannot conduct an offensive while our fuel convoys are held up at civilian toll gates and local rail switches in Brenas! Speed is everything in modern mechanized war. We demand unconditional military requisition authority over all rail lines, fuel depots, and granaries across Brenas!")}, -1,
                {cs(TADDEUS_FREE)});

            AddLine(conv, 104, CarlosId, RomusId, "Carlos_Logistics_Opener",
                {cs("Your Majesty. The General Staff cannot maintain offensive tempo while fuel convoys wait behind civilian freight and local rail switches in Brenas. We require full military requisition authority over the province's rail lines, fuel tanks, and grain depots.")}, -1,
                {cs(TADDEUS_GONE)});

            // Sazon Rebuttal (Angelica -> Manus -> Leona)
            AddLine(conv, 3, AngelicaId, RomusId, "Angelica_Furious_Rebuttal",
                {cs("Duchess Angelica straightened with icy noble disdain, slamming a jeweled ring against the table. \"Brenas is not an occupied province for Montaklar's generals to pillage! It is the historical breadbasket of Rizia and the homeland of Queen Mother Estela!\"")}, 4,
                {cs(ANGELICA_FREE)});

            AddLine(conv, 4, AngelicaId, RomusId, "Angelica_Furious_Rebuttal_2",
                {cs("\"Your requisition officers are already impounding trucks, seizing livestock, and threatening our mayors. If you bleed our farms dry to feed your iron tanks, winter starvation and strikes will paralyze our towns before our forces even take Wiktrany!\"")}, -1);

            AddLine(conv, 5, ManusId, RomusId, "Manus_Passionate_Proposal",
                {cs("Your Majesty, House Sazon does not wish to see our army fail—quite the contrary. Our merchant syndicates, coastal freighters, and provincial granaries have managed Brenas logistics for centuries. Entrust rear supply to our provincial guilds, and every battalion will be fed and fueled without martial extortion.")}, 6,
                {cs(MANUS_FREE)});

            AddLine(conv, 105, LeonaId, RomusId, "Leona_Sazon_Proposal",
                {cs("Countess Leona Sazon adjusted her sable stole coolly. \"Brenas is not a conquered fief for Montaklar's quartermasters to strip bare, Your Majesty. Our merchant guilds and coastal shipping syndicates can supply the army cleanly through our granaries and ports without provoking bread riots in Sallabes and Mave Nortus.\"")}, 6,
                {cs(f"{ANGELICA_GONE} and {MANUS_GONE}")});

            foreach (int oId in new[] {{ 2, 104 }})
            {{
                AddLink(conv, oId, 3);
                AddLink(conv, oId, 5);
                AddLink(conv, oId, 105);
            }}
            AddLink(conv, 4, 5);
            AddLink(conv, 4, 6); // if Manus is gone, Angelica goes straight to line 6

            // Military counter (Lucita if free, else Carlos)
            AddLine(conv, 6, LucitaId, RomusId, "Lucita_Military_Counter",
                {cs("Councilor Azaro leaned forward, her gaze razor-sharp. \"With all due respect to House Sazon, guild bureaucracy moves at the pace of an ox cart. If my armored spearheads stall in the mud outside Wiktrany waiting for merchant manifests, General Valdez will bring down Wehzek heavy artillery and slaughter our men!\"")}, 7,
                {cs(LUCITA_FREE)});

            AddLine(conv, 106, CarlosId, RomusId, "Carlos_Military_Counter",
                {cs("General Carlos Azaro tapped his leather portfolio flatly. \"Merchant committees move at the speed of paperwork, Your Majesty. If our forward brigades run dry of diesel and 105mm shells outside Wiktrany, General Valdez will dismantle them piecemeal.\"")}, 7,
                {cs(LUCITA_GONE)});

            AddLink(conv, 5, 6);
            AddLink(conv, 5, 106);
            AddLink(conv, 105, 6);
            AddLink(conv, 105, 106);

            // If Angelica spoke, go to Manus (5) when free, else via bridge node (107) directly to Lucita/Carlos
            var e4 = conv.GetDialogueEntry(4);
            e4.outgoingLinks.Clear();
            e4.outgoingLinks.Add(CreateLink(conv.id, 4, 5));
            e4.outgoingLinks.Add(CreateLink(conv.id, 4, 107));
            AddLine(conv, 107, NarratorId, RomusId, "Angelica_ManusGone_Bridge",
                {cs("With Manus no longer in the chamber, the silence after Angelica's outburst lingered heavy over the table.")}, -1,
                {cs(MANUS_GONE)});
            AddLink(conv, 107, 6);
            AddLink(conv, 107, 106);

            AddLine(conv, 7, ElenaId, RomusId, "Elena_Ledger_Audit",
                {cs("Elena Werner adjusted her spectacles and tapped her pen against her leather ledger. \"For Dast's sake, look at the arithmetic rather than your family heraldry! The Azaro centralized rail plan guarantees rapid delivery of shells, but hauling everything from Montaklar by heavy train burns immense quantities of refined fuel (-1 Energy) and strains the provincial grid.\"")}, 8);

            AddLine(conv, 8, ElenaId, RomusId, "Elena_Ledger_Audit_2",
                {cs("\"The Sazon syndicate plan utilizes Brenas granaries, regional rail spurs, and coastal barges along the gulf. It conserves our fuel and stiffens provincial defense in Brenas, though compensating the merchant syndicates requires direct subsidies from our royal treasury (-1 Budget).\"")}, -1);

            AddLine(conv, 9, HugoId, RomusId, "Hugo_Unity_Plea",
                {cs("Hugo Toras shook his head gravely. \"Romus, a kingdom divided against itself will fall before Wiktor Smolak. House Toras, House Azaro, and House Sazon have preserved this realm for centuries. You must bridge this divide.\"")}, 10,
                {cs(HUGO_FREE)});

            AddLine(conv, 109, LaurentoId, RomusId, "Laurento_Unity_Plea",
                {cs("Laurento Esquibel folded his hands gravely. \"Your Majesty, Smolak is watching for any fissure between our noble houses. Choose the supply structure that keeps both the army and the realm intact.\"")}, 10,
                {cs(HUGO_GONE)});

            AddLink(conv, 8, 9);
            AddLink(conv, 8, 109);

            var disputeHub = AddLine(conv, 10, NarratorId, RomusId, "Dispute_Hub_Prompt",
                {cs("The entire council fell silent, waiting for your judgment. The fate of the southern supply corridor rested in your hands.")});

            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 10, 20)); // Choose House Sazon
            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 10, 30)); // Choose House Azaro
            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 10, 40)); // Royal Compromise

            AddChoice(conv, 20, ManusId, "Choice_Sazon_Route",
                {cs("\"House Sazon will manage the supply lines. Rely on Brenas granaries, coastal convoys, and local syndicates.\"")},
                {cs("We cannot break the back of Brenas to win a military campaign. House Sazon will oversee rear supply and transit. Utilize your guild networks, coastal freighters, and granaries to keep our army fed and our people secure.")}, -1,
                {cs("Variable[\"Zille_Logistics_Route\"] = \"Sazon\"; Variable[\"Zille_Logistics_House\"] = \"Sazon\"; Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 1; Variable[\"RiziaDLC.Country_HouseSazon\"] = (Variable[\"RiziaDLC.Country_HouseSazon\"] or 0) + 2; Variable[\"RiziaDLC.Country_HouseAzaro\"] = (Variable[\"RiziaDLC.Country_HouseAzaro\"] or 0) - 1;")});

            AddLine(conv, 21, ManusId, RomusId, "Ack_Sazon_Manus",
                {cs("\"Thank you, Your Majesty!\" Manus bowed with genuine reverence. \"House Sazon will mobilize our finest grain syndicates and coastal barges. The people of Brenas will know their King protects them.\"")}, -1,
                {cs(MANUS_FREE)});

            AddLine(conv, 121, LeonaId, RomusId, "Ack_Sazon_Leona",
                {cs("Countess Leona inclined her head with poised gratitude. \"A prudent decree, Your Majesty. Our Brenas syndicates will keep the front provisioned without bleeding the countryside dry.\"")}, -1,
                {cs(f"{MANUS_GONE} and {ANGELICA_GONE}")});

            AddLine(conv, 22, AngelicaId, RomusId, "Ack_Sazon_Angelica",
                {cs("Duchess Angelica tilted her chin proudly. \"A wise and sovereign decree, Your Majesty. Brenas will stand as a steadfast bastion at your rear, and our western coastal ports will remain open for your fleet.\"")}, -1,
                {cs(ANGELICA_FREE)});

            AddLine(conv, 23, TaddeusId, RomusId, "Ack_Sazon_Taddeus",
                {cs("Duke Taddeus scowled, tossing his gloves onto the mahogany table with visible disgust. \"I only hope, Your Majesty, that when Valdez's tanks counter-attack, your merchant syndicates can fire wheat bushels instead of armor-piercing shells.\"")}, -1,
                {cs(TADDEUS_FREE)});

            AddLine(conv, 24, LucitaId, RomusId, "Ack_Sazon_Lucita",
                {cs("Lucita remained disciplined, though her jaw was clenched tight. \"The General Staff will adapt our operational timetable to the guild schedules, Your Majesty. We will hold Brenas at all costs.\"")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 124, CarlosId, RomusId, "Ack_Sazon_Carlos",
                {cs("General Carlos Azaro exhaled slowly, snapping his ledger shut. \"Very well, Your Majesty. We will adjust our convoy timetables accordingly.\"")}, -1,
                {cs(LUCITA_GONE)});

            // Wire Sazon ack chain cleanly
            AddLink(conv, 20, 21);
            AddLink(conv, 20, 22);
            AddLink(conv, 20, 121);
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

            // Azaro choice
            AddChoice(conv, 30, LucitaId, "Choice_Azaro_Route",
                {cs("\"Military necessity is absolute. Grant House Azaro full requisition powers to unleash a mechanized offensive.\"")},
                {cs("Military necessity takes absolute priority. Grant the General Staff and House Azaro full requisition authority over the southern rail network and fuel depots. We need maximum attack tempo to crush Valdez before he can entrench.")}, -1,
                {cs("Variable[\"Zille_Logistics_Route\"] = \"Azaro\"; Variable[\"Zille_Logistics_House\"] = \"Azaro\"; Variable[\"RiziaDLC.Resources_Energy\"] = (Variable[\"RiziaDLC.Resources_Energy\"] or 0) - 1; Variable[\"RiziaDLC.Country_HouseAzaro\"] = (Variable[\"RiziaDLC.Country_HouseAzaro\"] or 0) + 2; Variable[\"RiziaDLC.Country_HouseSazon\"] = (Variable[\"RiziaDLC.Country_HouseSazon\"] or 0) - 2;")});

            AddLine(conv, 31, LucitaId, RomusId, "Ack_Azaro_Lucita",
                {cs("Lucita saluted crisply, her eyes shining with decisive pride. \"A command worthy of a warrior king, Your Majesty! Our mechanized spearheads will receive every shell and barrel of fuel without hesitation. We will shatter Valdez's lines!\"")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 131, CarlosId, RomusId, "Ack_Azaro_Carlos",
                {cs("General Carlos Azaro gave a crisp nod. \"Understood, Your Majesty. Our armored spearheads will not lack for fuel or shells.\"")}, -1,
                {cs(LUCITA_GONE)});

            AddLine(conv, 32, TaddeusId, RomusId, "Ack_Azaro_Taddeus",
                {cs("\"Montaklar's divisions are at your service, Your Majesty!\" Taddeus declared firmly. \"Our armored columns will drive straight through Wiktrany!\"")}, -1,
                {cs(TADDEUS_FREE)});

            AddLine(conv, 33, AngelicaId, RomusId, "Ack_Azaro_Angelica",
                {cs("Duchess Angelica rose from her chair, her eyes burning with icy indignation. \"The Crown may take its fuel, Your Majesty. But remember this day when our farmers curse the name of Montaklar in the winter breadlines.\"")}, -1,
                {cs(ANGELICA_FREE)});

            AddLine(conv, 34, ManusId, RomusId, "Ack_Azaro_Manus",
                {cs("Manus bowed his head solemnly. \"We will do our best to keep civil order in Brenas, Your Majesty. May your victory be swift enough to justify the burden our people must bear.\"")}, -1,
                {cs(MANUS_FREE)});

            AddLine(conv, 134, LeonaId, RomusId, "Ack_Azaro_Leona",
                {cs("Countess Leona rose stiffly. \"The Crown shall have its trains, Your Majesty. I pray our towns survive the winter.\"")}, -1,
                {cs(f"{ANGELICA_GONE} and {MANUS_GONE}")});

            AddLink(conv, 30, 31);
            AddLink(conv, 30, 131);
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
            AddLink(conv, 33, 34);

            // Compromise choice
            AddChoice(conv, 40, ElenaId, "Choice_Compromise_Route",
                {cs("\"Neither house will dictate terms. Elena Werner will lead a Joint Logistical Board balancing both needs.\"")},
                {cs("Neither house will dictate terms unilaterally. Minister Elena Werner will chair a joint royal logistical board. Priority rail corridors will be reserved for military munitions, while Sazon guilds will oversee food procurement and local depot distribution.")}, 41,
                {cs("Variable[\"Zille_Logistics_Route\"] = \"Compromise\"; Variable[\"Zille_Logistics_House\"] = \"Compromise\"; Variable[\"RiziaDLC.Country_HouseAzaro\"] = (Variable[\"RiziaDLC.Country_HouseAzaro\"] or 0) + 1; Variable[\"RiziaDLC.Country_HouseSazon\"] = (Variable[\"RiziaDLC.Country_HouseSazon\"] or 0) + 1;")});

            AddLine(conv, 41, ElenaId, RomusId, "Ack_Compromise_Elena",
                {cs("Elena smiled faintly, adjusting her glasses. \"A thoroughly pragmatic compromise, Your Majesty. It prevents military paralysis while guarding the Crown against corrupt provincial price-gouging. I will assume personal oversight of the board immediately.\"")}, -1);

            AddLine(conv, 42, HugoId, RomusId, "Ack_Compromise_Hugo",
                {cs("\"Well reasoned, Romus. Unity between our noble houses is the bedrock upon which our dynasty stands. Glovurius axa Rizia!\"")}, -1,
                {cs(HUGO_FREE)});

            AddLine(conv, 43, LucitaId, RomusId, "Ack_Compromise_Lucita",
                {cs("Lucita nodded with measured professional respect. \"The military accepts this structure, Your Majesty. We will coordinate our convoy schedules directly with Minister Werner's office.\"")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 143, CarlosId, RomusId, "Ack_Compromise_Carlos",
                {cs("General Carlos Azaro inclined his head. \"An orderly compromise, Your Majesty. Our quartermasters will coordinate directly with Minister Werner.\"")}, -1,
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
        // Runtime Lua conditions for Lucita (married/romance/hostile/arrested),
        // Hugo (free/hostile/absent), Titus (free/absent), and Two-Front War!
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

            // Hugo / Grand Vizier opening
            AddLine(conv, 2, HugoId, RomusId, "Hugo_Briefing_Open",
                {cs("Your Majesty... The hour has arrived. Years of diplomatic patience have run dry. In a few hours, the world will awaken to news that Rizia has drawn the sword to reclaim its stolen province.")}, -1,
                {cs(HUGO_NORMAL)});

            AddLine(conv, 102, HugoId, RomusId, "Hugo_Briefing_Open_Hostile",
                {cs("Your Majesty. Despite the bitter rift between us, I cannot ignore the duty of my office: in a few hours, Rizia goes to war for Zille. May God shield the realm from the consequences.")}, -1,
                {cs(HUGO_HOSTILE)});

            AddLine(conv, 103, AngelicaId, RomusId, "Angelica_Vizier_Briefing_Open",
                {cs("Your Majesty. As Grand Vizier, I have reviewed the final mobilization decrees. In a few hours, Rizia moves to reclaim Zille—and with it, the historic wholeness of Brenas.")}, -1,
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

            // War Councilor opening: Lucita (Married / Romance / Hostile / Normal) OR Taddeus / Carlos if Lucita arrested
            AddLine(conv, 3, NarratorId, RomusId, "Lucita_Narration_Married",
                {cs("Lucita stood at the head of the map table, her field marshal's baton resting across the Brenas frontier. When your eyes met, her severe military demeanor softened with quiet warmth before she addressed the assembly.")}, 4,
                {cs(LUCITA_MARRIED)});
            AddLine(conv, 4, LucitaId, RomusId, "Lucita_Open_Married",
                {cs("My King... and my husband. All divisions are deployed at their staging posts. The soldiers have their rations, their ammunition, and the blessing of the sanctuaries. High command awaits your operational doctrine.")}, -1);

            AddLine(conv, 113, NarratorId, RomusId, "Lucita_Narration_Romance",
                {cs("Lucita looked up from the coastal approaches, her dark eyes flashing with unmistakable warmth before snapping back to disciplined military bearing.")}, 114,
                {cs(LUCITA_ROMANCE)});
            AddLine(conv, 114, LucitaId, RomusId, "Lucita_Open_Romance",
                {cs("Your Majesty... Romus. The army is prepared. Our officers stand by their radios along the Brenas frontier and at Monqiz naval base. Operational command is yours to dictate.")}, -1);

            AddLine(conv, 115, LucitaId, RomusId, "Lucita_Open_Hostile",
                {cs("Your Majesty. Whatever grievances stand between the Crown and House Azaro, our officers know their duty. The divisions are in position along the Brenas line; give your orders.")}, -1,
                {cs(LUCITA_HOSTILE)});

            AddLine(conv, 116, LucitaId, RomusId, "Lucita_Open_Standard",
                {cs("Your Majesty. All divisions of the Royal Army and provincial levies have assumed combat positions along the demarcation line, and the Royal Navy stands fueled at Monqiz. We await your final operational authorization.")}, -1,
                {cs(LUCITA_NORMAL)});

            AddLine(conv, 117, TaddeusId, RomusId, "Taddeus_Open_LucitaGone",
                {cs("Duke Taddeus Azaro stood stiffly beside the relief map, his jaw tight with lingering bitterness over his daughter's fate. \"Your Majesty. The divisions are assembled along the Brenas line and the fleet is ready at Monqiz. Specify the doctrine.\"")}, -1,
                {cs(f"{LUCITA_GONE} and {TADDEUS_FREE}")});

            AddLine(conv, 118, CarlosId, RomusId, "Carlos_Open_LucitaGone",
                {cs("General Carlos Azaro stepped forward in Lucita's stead, his expression unreadable and strictly professional. \"Your Majesty. The General Staff has completed deployment along the Brenas border and at Monqiz. We await your operational orders.\"")}, -1,
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

            // Laurento note (+ Two-Front War warning if Pales war is active!)
            AddLine(conv, 5, LaurentoId, RomusId, "Laurento_Briefing_Note",
                {cs("Our diplomatic memorandums have been pre-scheduled for dispatch to the Alliance of Nations in Konstantium, Kyrute the moment our first units advance. We are framing this strictly as the lawful expiration of the 1927 lease and the restoration of Rizian sovereignty.")}, -1,
                {cs(NO_TWO_FRONT)});

            AddLine(conv, 1051, LaurentoId, RomusId, "Laurento_Briefing_TwoFront",
                {cs("I must warn you gravely, Your Majesty: with our forces already engaged against Pales, opening a second war against Wehlen will alarm both superpowers and stretch our diplomatic shield in Kyrute to the breaking point.")}, -1,
                {cs(TWO_FRONT)});

            foreach (int prev in new[] {{ 4, 114, 115, 116, 117, 118 }})
            {{
                AddLink(conv, prev, 5);
                AddLink(conv, prev, 1051);
            }}

            // Titus security note
            AddLine(conv, 6, TitusId, RomusId, "Titus_Briefing_Note",
                {cs("The Golden Guard has deployed vanguard security teams along the advance routes, Your Majesty. Our scouts confirm that General Valdez's garrison in Zille City has not yet detected our mechanized assembly.")}, 10,
                {cs(TITUS_FREE)});

            AddLine(conv, 106, CarlosId, RomusId, "Carlos_Security_NoTitus",
                {cs("Forward military intelligence confirms that General Valdez's coastal and border outposts have not yet detected our main concentration, Your Majesty.")}, 10,
                {cs(TITUS_GONE)});

            foreach (int prev in new[] {{ 5, 1051 }})
            {{
                AddLink(conv, prev, 6);
                AddLink(conv, prev, 106);
            }}

            var commandHub = AddLine(conv, 10, NarratorId, RomusId, "Command_Hub_Prompt",
                {cs("Across the mahogany table, the operational map awaited your royal seal. You could personally take command at the War Table—directing Operation Golden Sword into the Zille peninsula or Operation Golden Ark across the Gulf of Moridia into mainland Wehlen—or delegate field execution to the General Staff under one of four doctrines.")});

            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 20)); // Romus: Operation Golden Sword
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 30)); // Romus: Operation Golden Ark
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 40)); // Staff Officers Command
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 50)); // Postpone

            AddChoice(conv, 20, LucitaId, "Choice_Golden_Sword",
                {cs("\"I will take personal command at the War Table: Authorize Operation Golden Sword Phase I.\"")},
                {cs("I will command this campaign myself. Authorize Operation Golden Sword Phase I. We will launch a massive armored spearhead across the Brenas-Zille frontier through Wiktrany, smashing Valdez's center and driving directly onto Zille City and Munat.")}, -1,
                {cs("Variable[\"Zille_War_PlanType\"] = \"Romulus\"; Variable[\"Zille_War_RomulusPlan\"] = \"GoldenSword\"; Variable[\"Zille_War_Active\"] = true;")});

            AddLine(conv, 21, LucitaId, RomusId, "Ack_Golden_Sword_Lucita",
                {cs("\"A glorious doctrine, Your Majesty!\" Lucita's eyes burned with martial pride. \"Our heavy tanks and mechanized infantry will punch straight through their fortified junctions. The War Table is illuminated and awaiting your strategic deployment for Phase I!\"")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 121, CarlosId, RomusId, "Ack_Golden_Sword_Carlos",
                {cs("General Carlos Azaro saluted crisply. \"The armored spearheads are fueled and poised on the Brenas frontier. The War Table awaits your deployment for Phase I, Your Majesty.\"")}, -1,
                {cs(LUCITA_GONE)});

            AddLine(conv, 22, HugoId, RomusId, "Ack_Golden_Sword_Hugo",
                {cs("\"May Saint Wruhec watch over our soldiers, Romus. Lead our kingdom to triumph. Glovurius axa Rizia!\"")}, -1,
                {cs(HUGO_FREE)});

            AddLine(conv, 122, LaurentoId, RomusId, "Ack_Golden_Sword_NoHugo",
                {cs("\"Godspeed to our armies, Your Majesty. Our envoys stand ready to announce Rizia's rightful reclamation.\"")}, -1,
                {cs(HUGO_GONE)});

            AddLink(conv, 20, 21);
            AddLink(conv, 20, 121);
            AddLink(conv, 21, 22);
            AddLink(conv, 21, 122);
            AddLink(conv, 121, 22);
            AddLink(conv, 121, 122);

            AddChoice(conv, 30, LucitaId, "Choice_Golden_Ark",
                {cs("\"I will take personal command at the War Table: Authorize Operation Golden Ark Phase I.\"")},
                {cs("I will lead our forces personally. Authorize Operation Golden Ark Phase I. While our border divisions pin down Zille's southern frontier, the Royal Navy will cross the Gulf of Moridia and Strait of Kreleck to land our marines directly on mainland Wehlen—striking Kratsna, Rotsla, and Grodzizg to sever Zille from behind!")}, -1,
                {cs("Variable[\"Zille_War_PlanType\"] = \"Romulus\"; Variable[\"Zille_War_RomulusPlan\"] = \"GoldenArk\"; Variable[\"Zille_War_Active\"] = true;")});

            AddLine(conv, 31, LucitaId, RomusId, "Ack_Golden_Ark_Lucita",
                {cs("\"An audacious maritime envelopment!\" Lucita smiled fiercely. \"Smolak expects us to bleed against his trenches in Zille—landing across the sea in mainland Wehlen will sever his convoys at the source. The War Table is configured and waiting for Phase I!\"")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 131, CarlosId, RomusId, "Ack_Golden_Ark_Carlos",
                {cs("General Carlos Azaro studied the sea lanes approvingly. \"A bold naval stroke across the Gulf of Moridia, Your Majesty. Our landing craft and border screening brigades await your deployment at the War Table.\"")}, -1,
                {cs(LUCITA_GONE)});

            AddLine(conv, 32, LaurentoId, RomusId, "Ack_Golden_Ark_Laurento",
                {cs("\"Be warned, Your Majesty: striking mainland Wehlen directly across the sea will provoke Chancellor Hegel and Valgsland fiercely, so speed at sea will be everything. Godspeed to our fleet.\"")}, -1);

            AddLink(conv, 30, 31);
            AddLink(conv, 30, 131);
            AddLink(conv, 31, 32);
            AddLink(conv, 131, 32);

            AddChoice(conv, 40, NarratorId, "Choice_Staff_Command",
                {cs("\"The General Staff will direct the campaign. Present the four staff doctrines for execution.\"")},
                {cs("The General Staff will direct the field execution of this war. Present your four strategic doctrines for royal selection.")}, 41,
                {cs("Variable[\"Zille_War_PlanType\"] = \"Staff\";")});

            var staffHub = AddLine(conv, 41, NarratorId, RomusId, "Staff_Doctrine_Presentation",
                {cs("The General Staff laid out four strategic doctrines across the map:\n\n  Plan Hawk: Heavy aerial strikes and artillery barrages shatter Valdez's command network before infantry advances.\n  Plan Sword: An aggressive armored charge led by House Azaro heavy divisions pushing through Wiktrany.\n  Plan Ark: A methodical naval blockade and amphibious encirclement across the Gulf of Moridia, starving Zille's sea supply lines.\n  Plan Spear: A covert night decapitation strike by elite commandos against Valdez's headquarters.\n\nWhich staff doctrine do you authorize?")});

            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 42)); // Plan Hawk
            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 43)); // Plan Sword
            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 44)); // Plan Ark
            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 45)); // Plan Spear

            AddChoice(conv, 42, LucitaId, "Authorize_Staff_Hawk",
                {cs("\"Authorize Plan Hawk: Shatter their forward redoubts with air and artillery power.\"")},
                {cs("I authorize Plan Hawk. Bring down our bomber wings and heavy artillery. Flatten their defensive works before our ground units advance.")}, -1,
                {cs("Variable[\"Zille_War_StaffPlan\"] = \"Hawk\"; Variable[\"Zille_War_Active\"] = true;")});

            AddChoice(conv, 43, LucitaId, "Authorize_Staff_Sword",
                {cs("\"Authorize Plan Sword: Unleash our armored divisions in a central breakthrough.\"")},
                {cs("I authorize Plan Sword. Mass our armor and let the Azaro divisions spearhead the breakthrough into Wiktrany.")}, -1,
                {cs("Variable[\"Zille_War_StaffPlan\"] = \"Sword\"; Variable[\"Zille_War_Active\"] = true;")});

            AddChoice(conv, 44, LucitaId, "Authorize_Staff_Ark",
                {cs("\"Authorize Plan Ark: Execute a disciplined maritime blockade and sea encirclement.\"")},
                {cs("I authorize Plan Ark. The Royal Navy will seal the Gulf of Moridia and Strait of Kreleck, cutting off Valdez's sea supply lines.")}, -1,
                {cs("Variable[\"Zille_War_StaffPlan\"] = \"Ark\"; Variable[\"Zille_War_Active\"] = true;")});

            AddChoice(conv, 45, TitusId, "Authorize_Staff_Spear",
                {cs("\"Authorize Plan Spear: Deploy elite commandos and guardsmen to decapitate Valdez's command.\"")},
                {cs("I authorize Plan Spear. Send our finest operatives into Zille tonight to sever Valdez's communications and capture his staff before the main assault begins.")}, -1,
                {cs("Variable[\"Zille_War_StaffPlan\"] = \"Spear\"; Variable[\"Zille_War_Active\"] = true;")});

            AddLine(conv, 46, LucitaId, RomusId, "Ack_Staff_Lucita",
                {cs("\"The orders are dispatched, Your Majesty! The General Staff has initiated the offensive. Our officers will report battle progress as the front develops!\"")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 146, CarlosId, RomusId, "Ack_Staff_Carlos",
                {cs("\"The orders are dispatched, Your Majesty. The General Staff has launched the offensive and will report front-line progress.\"")}, -1,
                {cs(LUCITA_GONE)});

            foreach (int chId in new[] {{ 42, 43, 44 }})
            {{
                AddLink(conv, chId, 46);
                AddLink(conv, chId, 146);
            }}

            AddLine(conv, 47, TitusId, RomusId, "Ack_Staff_Titus",
                {cs("\"My guardsmen are already moving under cover of darkness, Your Majesty,\" Titus said quietly, his hand resting firmly over his service sidearm. \"Smolak's officers will wake up in chains.\"")}, -1,
                {cs(TITUS_FREE)});

            AddLine(conv, 147, CarlosId, RomusId, "Ack_Staff_Spear_NoTitus",
                {cs("\"Our special commando detachments are already slipping across the frontier under darkness, Your Majesty. Valdez's command post will be blind before dawn.\"")}, -1,
                {cs(TITUS_GONE)});

            AddLink(conv, 45, 47);
            AddLink(conv, 45, 147);

            AddChoice(conv, 50, HugoId, "Choice_Postpone_War",
                {cs("\"Hold the offensive for now. Keep our divisions at maximum readiness along the border.\"")},
                {cs("Hold the offensive for now. Keep our divisions at maximum combat readiness along the frontier, but do not cross until I give the royal command.")}, -1,
                {cs("Variable[\"Zille_War_Postpone\"] = true;")});

            AddLine(conv, 51, HugoId, RomusId, "Ack_Postpone_Hugo",
                {cs("\"A prudent and measured decision, Your Majesty. The General Staff will maintain full combat readiness along the frontier until you decide the hour is right.\"")}, -1,
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
        // Fixed: No rivers, no desert, Mayor via NarratorId (not Carlos ID 88!),
        // Conditional Foreign Aid & Two-Front War & Lucita/Taddeus arrest variants.
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
                {cs("Your armored convoy rumbled through the muddy, rain-slicked streets of Mave Nortus. In the distance across the northern hills, the rhythmic thud of heavy artillery rolled like continuous thunder, rattling the windowpanes of the stone Brenas houses. Sandbag bunkers lined the crossroads, and wounded soldiers resting on canvas stretchers outside the town sanctuary looked up with weary reverence as the royal standard fluttered past.")}, -1);

            AddLine(conv, 2, NarratorId, RomusId, "MaveNortus_Office_Entry",
                {cs("Inside the town hall, municipal tax ledgers had been shoved aside to make room for battlefield telegraphs and grease-pencil maps spread across the Mayor's oak desk. Duke Taddeus Azaro stood with his uniform jacket unbuttoned, pointing a scarred finger at the coastal highways, while Councilor Lucita Azaro reviewed incoming courier dispatches.")}, 3,
                {cs(f"{TADDEUS_FREE} and {LUCITA_FREE}")});

            AddLine(conv, 102, NarratorId, RomusId, "MaveNortus_Office_Carlos",
                {cs("Inside the town hall, municipal tax ledgers had been shoved aside for battlefield telegraphs and grease-pencil maps spread across the Mayor's oak desk. General Carlos Azaro leaned over the coastal highways, conferring briskly with staff officers.")}, 103,
                {cs(f"{TADDEUS_GONE} or {LUCITA_GONE}")});

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            AddLine(conv, 3, TaddeusId, RomusId, "Taddeus_HQ_Greeting",
                {cs("Your Majesty! It is an honor to have our King at the front lines. The men took heart the moment the royal motorcade entered Mave Nortus.")}, 4);

            AddLine(conv, 103, CarlosId, RomusId, "Carlos_HQ_Greeting",
                {cs("Your Majesty. Word of your arrival at Mave Nortus has already lifted the spirits of the forward brigades.")}, -1);

            AddLine(conv, 4, LucitaId, RomusId, "Lucita_HQ_Debrief_1",
                {cs("Phase I of our operation has concluded, Your Majesty. General Valdez fought fiercely along the fortified border earthworks and coastal approaches, yet our forward brigades have secured crucial staging positions.")}, 5);

            AddLine(conv, 5, LucitaId, RomusId, "Lucita_HQ_Debrief_2",
                {cs("Still, the campaign is only half won. Valdez has consolidated his surviving armor and veterans into a hardened defensive ring around Zille City, the northern coast, and the sea approaches across the Gulf of Moridia. We must launch Phase II to break his spine.")}, 6);

            AddLine(conv, 104, TaddeusId, RomusId, "Taddeus_HQ_Debrief_NoLucita",
                {cs("Phase I is complete, Your Majesty. Valdez contested every kilometer of the coastal highways, and though our forces secured key positions, he has dug his remaining armor into an inner ring around Zille City and the Gulf ports. Phase II must decide it.")}, 6,
                {cs(TADDEUS_FREE)});

            AddLine(conv, 105, CarlosId, RomusId, "Carlos_HQ_Debrief_BothGone",
                {cs("Phase I is complete, Your Majesty. Valdez's surviving brigades have fallen back into fortified rings around Zille City and his northern supply ports. We need your Phase II directives to finish the campaign.")}, 6,
                {cs(TADDEUS_GONE)});

            AddLink(conv, 103, 4);
            AddLink(conv, 103, 104);
            AddLink(conv, 103, 105);
            SetEntryCondition(conv.GetDialogueEntry(4), {cs(LUCITA_FREE)});
            SetEntryCondition(conv.GetDialogueEntry(104), {cs(f"{LUCITA_GONE} and {TADDEUS_FREE}")});
            SetEntryCondition(conv.GetDialogueEntry(105), {cs(f"{LUCITA_GONE} and {TADDEUS_GONE}")});

            AddLine(conv, 6, NarratorId, RomusId, "Mayor_HQ_Report",
                {cs("The Mayor of Mave Nortus stepped forward nervously, wiping rain and sweat from his brow. \"Your Majesty, over four thousand Rizian refugees have fled south from Zille in the last forty-eight hours. Smolak's retreating officers torched grain silos behind them. Our town is straining to house and feed them, and medical supplies are running thin.\"")}, 10);

            var hqHub = AddLine(conv, 10, NarratorId, RomusId, "HQ_Hub_Prompt",
                {cs("Distant artillery rumbled once more, sending a fine dust of plaster drifting down from the ceiling. You studied the situational map, ready to question your commanders.")});

            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 11)); // Foreign Aid Audit
            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 12)); // Casualties & Morale
            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 13)); // Refugee Relief Order
            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 20)); // Launch Phase II Orders

            AddChoice(conv, 11, NarratorId, "Inquire_ForeignAid",
                {cs("\"What reports do we have on foreign assistance and allied support?\"")},
                {cs("What reports do we have regarding foreign assistance? Has our international diplomacy yielded tangible aid on the battlefield?")}, -1);

            // 8 mutually exclusive Foreign Aid outcomes
            AddLine(conv, 140, NarratorId, RomusId, "Answer_ForeignAid_None",
                {cs("Your staff officers exchanged grim glances. \"No foreign power has committed direct aid to our campaign, Your Majesty. Rizia stands entirely on its own steel, treasury, and courage.\"")}, 10,
                {cs(f"{L0} and {R0} and {D0}")});
            AddLine(conv, 141, NarratorId, RomusId, "Answer_ForeignAid_Lespia",
                {cs("\"High-resolution aerial reconnaissance supplied by Lespia has pinpointed Valdez's camouflaged artillery bunkers behind the Wiktrany lowlands,\" your intelligence officer reported. \"Our gunners are already using the coordinates.\"")}, 10,
                {cs(f"{L1} and {R0} and {D0}")});
            AddLine(conv, 142, NarratorId, RomusId, "Answer_ForeignAid_Rumburg",
                {cs("\"Three freight trains carrying 152mm heavy artillery shells from Rumburg arrived in the Brenas depot this morning,\" your quartermaster reported. \"Our batteries are well stocked for Phase II.\"")}, 10,
                {cs(f"{L0} and {R1} and {D0}")});
            AddLine(conv, 143, NarratorId, RomusId, "Answer_ForeignAid_Derdia",
                {cs("\"In the east, Derdian irregulars have raided Wehlen's mainland border depots,\" your intelligence officer reported. \"Valdez has been forced to divert troops away from our front.\"")}, 10,
                {cs(f"{L0} and {R0} and {D1}")});
            AddLine(conv, 144, NarratorId, RomusId, "Answer_ForeignAid_LespiaRumburg",
                {cs("\"Lespian aerial reconnaissance has mapped Valdez's bunkers behind the Wiktrany lowlands, and three trainloads of heavy 152mm shells from Rumburg arrived in the Brenas depot this morning.\"")}, 10,
                {cs(f"{L1} and {R1} and {D0}")});
            AddLine(conv, 145, NarratorId, RomusId, "Answer_ForeignAid_LespiaDerdia",
                {cs("\"Lespian reconnaissance flights have exposed Valdez's hidden batteries, while Derdian irregular raids on Wehlen's southern border have forced him to pull reserves off our front.\"")}, 10,
                {cs(f"{L1} and {R0} and {D1}")});
            AddLine(conv, 146, NarratorId, RomusId, "Answer_ForeignAid_RumburgDerdia",
                {cs("\"Three freight trains of Rumburgian 152mm shells arrived in Brenas this morning, and Derdian irregulars raiding Wehlen's mainland frontier have pinned down an entire enemy regiment.\"")}, 10,
                {cs(f"{L0} and {R1} and {D1}")});
            AddLine(conv, 147, NarratorId, RomusId, "Answer_ForeignAid_All",
                {cs("\"Very tangible, Your Majesty: Lespian reconnaissance photos have revealed Valdez's camouflaged bunkers, three trainloads of Rumburgian 152mm shells arrived in Brenas this morning, and Derdian irregulars raiding Wehlen's border depots have pinned down enemy reserves.\"")}, 10,
                {cs(f"{L1} and {R1} and {D1}")});

            for (int aidId = 140; aidId <= 147; aidId++)
            {{
                AddLink(conv, 11, aidId);
            }}

            AddChoice(conv, 12, TaddeusId, "Inquire_Casualties",
                {cs("\"How heavy are our casualties, and how is the fighting spirit of our soldiers?\"")},
                {cs("Give me a frank assessment of our losses. How are our men holding up against Wehlen's counter-attacks?")}, -1);

            AddLine(conv, 15, TaddeusId, RomusId, "Answer_Casualties",
                {cs("We took shrapnel losses storming the forward trenches and coastal approaches, Your Majesty, but our field hospitals have performed miracles. Morale is soaring—the men know they are liberating Rizian soil, not bleeding for some distant foreign border. They are eager to finish the job.")}, 10,
                {cs(f"{TADDEUS_FREE} and {NO_TWO_FRONT}")});

            AddLine(conv, 115, TaddeusId, RomusId, "Answer_Casualties_TwoFront",
                {cs("Our field hospitals are strained to breaking, Your Majesty. With divisions tied down against Pales on the eastern frontier while we assault Wehlen here, ammunition and replacements are stretched thin. The men fight bravely, but we cannot afford a prolonged stalemate.")}, 10,
                {cs(f"{TADDEUS_FREE} and {TWO_FRONT}")});

            AddLine(conv, 116, CarlosId, RomusId, "Answer_Casualties_Carlos",
                {cs("Losses were sharp along the coastal fortifications, Your Majesty, yet morale remains resolute. Our soldiers know they are fighting to reclaim Rizian soil and will see Phase II through.")}, 10,
                {cs(TADDEUS_GONE)});

            AddLink(conv, 12, 15);
            AddLink(conv, 12, 115);
            AddLink(conv, 12, 116);

            AddChoice(conv, 13, NarratorId, "Order_Refugee_Aid",
                {cs("\"Mayor, the Crown will fund emergency medical aid and provisions for every refugee.\"")},
                {cs("Mayor, the Crown will immediately release emergency funds and grain from the royal reserves for every refugee arriving in Mave Nortus. No Rizian fleeing Smolak will be neglected.")}, 16,
                {cs("Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 1; Variable[\"Zille_Refugee_Aid_Granted\"] = true;")},
                {cs("Variable[\"Zille_Refugee_Aid_Granted\"] ~= true")});

            AddLine(conv, 16, NarratorId, RomusId, "Ack_Refugee_Aid",
                {cs("Tears welled in the Mayor of Mave Nortus's eyes as he pressed his hand over his heart. \"God bless Your Majesty! The people of Brenas and Zille will never forget your royal mercy!\"")}, 10);

            AddChoice(conv, 20, NarratorId, "Order_Phase2_Launch",
                {cs("\"The time has come. Issue the battle orders for Phase II: Break their inner ring and liberate Zille!\"")},
                {cs("The time has come. Valdez will find no respite. Issue the battle orders for Phase II immediately. Concentrate our artillery, deploy our fresh reserves, and break their final line!")}, -1,
                {cs("Variable[\"Zille_War_Phase\"] = 2;")});

            AddLine(conv, 21, LucitaId, RomusId, "Ack_Phase2_Lucita",
                {cs("Lucita smiled with fierce, cold resolution, snapping her field baton onto Zille City. \"The orders are dispatched, Your Majesty! Our armor will lead the assault at dawn. We will deliver Zille back into your royal hands!\"")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 121, CarlosId, RomusId, "Ack_Phase2_Carlos",
                {cs("General Carlos Azaro saluted sharply. \"The Phase II directives are on the wire, Your Majesty. All brigades move at dawn.\"")}, -1,
                {cs(LUCITA_GONE)});

            AddLine(conv, 22, TaddeusId, RomusId, "Ack_Phase2_Taddeus",
                {cs("Taddeus drew his saber and held it aloft in solemn tribute. \"For King and Kingdom! Glovurius axa Rizia! Forward to victory!\"")}, -1,
                {cs(TADDEUS_FREE)});

            AddLink(conv, 20, 21);
            AddLink(conv, 20, 121);
            AddLink(conv, 21, 22);
            AddLink(conv, 121, 22);

            AddConversationWithAlias(db, conv, "Zille/MaveNortusHQ", "Turn_Zille_MaveNortusHQ");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Mave Nortus Field HQ (ID 9994) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 5: Turn_Zille_WarBalconySpeech (ID 9989) - WAR PROCLAMATION SPEECH
        // Fixed: 1927 agreement, Hugo absent variant, Lucita absent awareness.
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
                {cs("The grand double doors of the Palas Rezna balcony swung open to the roar of over forty thousand citizens packed shoulder to shoulder in the Royal Plaza. Banners of House Toras, Azaro, and Sazon fluttered in the sea breeze. Below, brass microphones were wired to radio broadcasting trucks transmitting your voice to every household across Rizia.")}, -1);

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Balcony_Whisper",
                {cs("Hugo leaned in, his voice barely audible beneath the roar of the crowd. \"The whole kingdom listens, Romus. Give them words worthy of a king.\"")}, 3,
                {cs(HUGO_FREE)});

            AddLine(conv, 102, LaurentoId, RomusId, "Laurento_Balcony_Whisper",
                {cs("Laurento inclined his head beside you as the roar of the crowd swelled. \"Both the realm and the ambassadors in Kyrute are listening, Your Majesty.\"")}, 3,
                {cs(HUGO_GONE)});

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            var speechHub = AddLine(conv, 3, NarratorId, RomusId, "Speech_Doctrine_Prompt",
                {cs("You stepped forward to the stone balustrade, raising your sovereign hand. A profound hush fell over the ocean of citizens.")});

            speechHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Revanchist Might
            speechHub.outgoingLinks.Add(CreateLink(conv.id, 3, 20)); // Liberating the Oppressed
            speechHub.outgoingLinks.Add(CreateLink(conv.id, 3, 30)); // Sovereign Legalism

            AddChoice(conv, 10, HugoId, "Speech_Revanchist",
                {cs("\"Sons and daughters of Rizia! We march to reclaim what was stolen and restore the honor of our ancestors!\"")},
                {cs("Sons and daughters of Rizia! For over twenty-five years, our kingdom has borne the sting of separation in silence. But House Toras does not bow to tyrants! Today, the Royal Army marches to reclaim our sovereign soil and restore the royal dignity of our kingdom!")}, 11,
                {cs("Variable[\"Zille_Speech_Tone\"] = \"Revanchist\"; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1;")});

            AddLine(conv, 11, NarratorId, RomusId, "Speech_Revanchist_Reaction",
                {cs("A thunderous roar erupted from the crowd, bayonets flashing in the sun as royal guards raised their rifles in salute. Patriotic cheers echoed down the avenues of Porte Drazon.")}, -1);

            AddChoice(conv, 20, HugoId, "Speech_Liberation",
                {cs("\"We come not as conquerors, but as liberators to free our brothers and sisters from Smolak's tyranny!\"")},
                {cs("People of Rizia! We march not out of hatred, but out of sacred love for our brothers and sisters in Zille who have endured Smolak's secret police and broken promises. We go to bring them home to their true kingdom!")}, 21,
                {cs("Variable[\"Zille_Speech_Tone\"] = \"Liberation\"; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1;")});

            AddLine(conv, 21, NarratorId, RomusId, "Speech_Liberation_Reaction",
                {cs("Tears flowed freely among the elder citizens in the crowd, and chants of 'Long live King Romus!' resonated throughout the ancient plaza.")}, -1);

            AddChoice(conv, 30, HugoId, "Speech_Legalist",
                {cs("\"The 1927 agreement has expired. We uphold international law where Wehlen has trampled it!\"")},
                {cs("Citizens of Rizia and observers across Merkopa. Rizia is a realm of honor and constitutional order. The 1927 lease has expired. In reclaiming Zille, we enforce the sacred rule of law that Wiktor Smolak has trampled underfoot!")}, 31,
                {cs("Variable[\"Zille_Speech_Tone\"] = \"Legalist\"; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1;")});

            AddLine(conv, 31, NarratorId, RomusId, "Speech_Legalist_Reaction",
                {cs("Foreign correspondents frantically scribbled notes, while the crowd applauded with deep, dignified respect for the Crown's measured authority.")}, -1);

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
        // Fixed: Supreme Wiseman Jorga Azmal, Silver Garrison outside Naeal,
        // Grand Wiseman Sal Ignacius (no pectoral cross/crossing himself!),
        // real Golcondist pilgrimage stakes (lifting border ban & Plavo/Zille access),
        // Sal/Titus arrest checks & pre-existing Derdia hostility checks.
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
                {cs("The private royal telecommunications chamber was heavy with the aroma of burning sandalwood and frankincense. Over the encrypted high-frequency transceiver from the Silver Garrison outside Naeal, the resonant baritone of Supreme Wiseman Jorga Azmal cut through the static with austere authority.")}, -1);

            AddLine(conv, 2, AzmalId, RomusId, "Azmal_Opening_Greeting",
                {cs("May God's light guide you, Your Majesty. The mountain winds carry whispers of iron and smoke rising along Wehlen's borders. You prepare to strike the butcher of Wraclawitz, do you not?")}, 3,
                {cs('Variable["RiziaDLC.CountryRelation_Derdia_Hostile"] ~= true')});

            AddLine(conv, 102, AzmalId, RomusId, "Azmal_Opening_Hostile",
                {cs("I am surprised the King of Rizia dares call the Silver Garrison after all the insults our faithful have endured, Your Majesty. Yet even an estranged neighbor becomes useful when Wiktor Smolak stands across the border. Speak quickly.")}, 3,
                {cs('Variable["RiziaDLC.CountryRelation_Derdia_Hostile"] == true')});

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            var azmalHub = AddLine(conv, 3, RomusId, AzmalId, "Romus_Azmal_Open_Prompt",
                {cs("I leaned toward the gilded receiver, measuring my words before the Supreme Wiseman of Derdia.")});

            azmalHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10));
            azmalHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11));
            azmalHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12));

            AddChoice(conv, 10, AzmalId, "Choice_Faith_Justice",
                {cs("\"Smolak has persecuted the faithful and oppressed Bludish and Rizian believers alike. Justice demands action.\"")},
                {cs("Smolak has trampled sacred law and tormented believers across Wehlen and Zille for far too long. As followers of Saint Wruhec, justice demands that the sword be drawn against him.")}, 20,
                {cs("Variable[\"Derdia_Romus_Faithful\"] = true;")});

            AddChoice(conv, 11, AzmalId, "Choice_Military_Pragmatism",
                {cs("\"Wehlen is our common adversary. A coordinated strike will break his stranglehold on both our borders.\"")},
                {cs("Wehlen is our common adversary, Supreme Wiseman. If Rizia strikes Zille and the Gulf ports while Derdia applies pressure on Wehlen's southern land border, Smolak's army will crack under two fronts.")}, 20,
                {cs("Variable[\"Derdia_Romus_Pragmatic\"] = true;")});

            AddChoice(conv, 12, AzmalId, "Choice_Question_Motives",
                {cs("\"What interest does Derdia possess in our campaign for Zille?\"")},
                {cs("What interest does Derdia possess in the outcome of our conflict over Zille, Supreme Wiseman? Speak plainly.")}, 20,
                {cs("Variable[\"Derdia_Romus_Cautious\"] = true;")});

            AddLine(conv, 20, AzmalId, RomusId, "Azmal_Theological_Stakes",
                {cs("Know this, Your Majesty: Smolak's regime has slaughtered Bludish Golcondists in the mountains for decades, while Rizia's own border laws have barred our pilgrims from the Archsanctuary of Plavo and the sacred shrines of our shared Nurist heritage.")}, -1);

            AddLine(conv, 21, AzmalId, RomusId, "Azmal_Offer_Proposal",
                {cs("Pledge by your royal word to keep Rizia's borders open to Golcondist pilgrims and guarantee their safety at Plavo and the sanctuaries of liberated Zille. In return, three thousand seasoned Golcondist irregulars and mountain scouts will raid Wehlen's southern frontier—cutting telegraph lines, torching Valdez's supply depots, and tying down his reserves.")}, -1,
                {cs('Variable["RiziaDLC.Decision_Turn03_GolcondistPilgrims_AllowPassage"] ~= true')});

            AddLine(conv, 121, AzmalId, RomusId, "Azmal_Offer_Proposal_AlreadyAllowed",
                {cs("You showed rare goodwill by permitting our pilgrims across your border, Your Majesty. Formalize that protection for our faithful in Plavo and liberated Zille, and three thousand Golcondist irregulars will strike Wehlen's southern frontier depots tonight.")}, -1,
                {cs('Variable["RiziaDLC.Decision_Turn03_GolcondistPilgrims_AllowPassage"] == true')});

            AddLink(conv, 20, 21);
            AddLink(conv, 20, 121);

            AddLine(conv, 22, SalId, RomusId, "Sal_Ignacius_Warning",
                {cs("Grand Wiseman Sal Ignacius leaned forward, his fingers tightening around his golden Six Stars medallion. \"Your Majesty, tread cautiously! Encouraging Golcondist pilgrims in Plavo and Zille will deeply unsettle the orthodox Wruhecist hierarchy!\"")}, -1,
                {cs(SAL_FREE)});

            AddLine(conv, 122, HugoId, RomusId, "Hugo_Clergy_Warning_NoSal",
                {cs("Hugo murmured beside you with furrowed brow. \"Be cautious, Romus. Opening our sanctuaries to Derdian Golcondists will provoke fierce outcry among the orthodox clergy.\"")}, -1,
                {cs(f"{SAL_GONE} and {HUGO_FREE}")});

            AddLine(conv, 123, LaurentoId, RomusId, "Laurento_Clergy_Warning_Fallback",
                {cs("Laurento whispered discreetly, \"Bear in mind, Your Majesty, that religious concessions to Derdia will draw sharp criticism from traditionalist Wruhecist leaders at home.\"")}, -1,
                {cs(f"{SAL_GONE} and {HUGO_GONE}")});

            foreach (int pId in new[] {{ 21, 121 }})
            {{
                AddLink(conv, pId, 22);
                AddLink(conv, pId, 122);
                AddLink(conv, pId, 123);
            }}

            AddLine(conv, 23, TitusId, RomusId, "Titus_Tactical_Perspective",
                {cs("Titus Gordion stepped forward respectfully. \"From a military standpoint, Your Majesty, Derdian guerrilla raids across Wehlen's southern border will force General Valdez to split his reserves and leave Zille under-reinforced.\"")}, 30,
                {cs(TITUS_FREE)});

            AddLine(conv, 124, CarlosId, RomusId, "Carlos_Tactical_Perspective",
                {cs("General Carlos Azaro nodded curtly. \"Militarily, Your Majesty, Derdian raids on Wehlen's southern depots will pin down brigades Smolak would otherwise ship to Zille.\"")}, 30,
                {cs(TITUS_GONE)});

            foreach (int wId in new[] {{ 22, 122, 123 }})
            {{
                AddLink(conv, wId, 23);
                AddLink(conv, wId, 124);
            }}

            var pactHub = AddLine(conv, 30, NarratorId, RomusId, "Derdia_Pact_Hub_Prompt",
                {cs("Supreme Wiseman Azmal awaited your verdict on the transceiver, the distant unison chants of the Silver Garrison audible across the line.")});

            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Accept Holy Coalition
            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 50)); // Pragmatic Compromise
            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 60)); // Reject Faith Interference

            AddChoice(conv, 40, AzmalId, "Accept_Holy_Coalition",
                {cs("\"I pledge by Saint Wruhec: Golcondist pilgrims shall have safe passage to Plavo and liberated Zille.\"")},
                {cs("I pledge by Saint Wruhec and my royal honor: Rizia's borders will remain open to Golcondist pilgrims, and they shall worship safely in Plavo and liberated Zille. Unleash your irregulars against Wehlen's southern frontier!")}, 41,
                {cs("Variable[\"Zille_DerdiaHybridActive\"] = true; Variable[\"RiziaDLC.Decision_Turn03_GolcondistPilgrims_AllowPassage\"] = true; Variable[\"RiziaDLC.CountryRelation_Derdia_Friendly\"] = true; Variable[\"RiziaDLC.Diplomacy_Derdia_NegotiatingPower\"] = (Variable[\"RiziaDLC.Diplomacy_Derdia_NegotiatingPower\"] or 0) + 2;")});

            AddLine(conv, 41, AzmalId, RomusId, "Ack_Holy_Coalition",
                {cs("Azmal's voice boomed with solemn fervor over the receiver. \"Halaita! Let the chains of the tyrant be broken! My fighters will cross into southern Wehlen before dawn. May God shield your armies, Your Majesty.\"")}, -1);

            AddLine(conv, 42, SalId, RomusId, "Sal_Derdia_Grumble",
                {cs("Grand Wiseman Sal murmured a quiet prayer, pressing his palm to his Six Stars medallion. \"May Saint Wruhec forgive this compromise for the sake of the kingdom's peace...\"")}, -1,
                {cs(SAL_FREE)});

            AddLink(conv, 41, 42);

            AddChoice(conv, 50, AzmalId, "Counter_Pragmatic_Derdia",
                {cs("\"I guarantee safe border transit and civil protection, but no special sanctuary privileges.\"")},
                {cs("I can guarantee safe transit and police protection for Derdian travelers across our borders, but I will not alter our Wruhecist sanctuary laws. Let us strike Smolak together as sovereign partners.")}, 51,
                {cs("Variable[\"Zille_DerdiaHybridActive\"] = true;")});

            AddLine(conv, 51, AzmalId, RomusId, "Ack_Pragmatic_Derdia",
                {cs("Azmal paused in silent reflection before exhaling slowly. \"You speak with the cautious tongue of a king rather than a prophet, Romus. Yet our hatred for Smolak outweighs our disappointment. Our mountain scouts will raid his supply depots—but remember your promise to our pilgrims when Zille is yours.\"")}, -1);

            AddChoice(conv, 60, AzmalId, "Reject_Derdia_Demands",
                {cs("\"Rizia upholds its own religious laws without foreign conditions. Keep your fighters behind your borders.\"")},
                {cs("Rizia answers to Saint Wruhec and the Crown alone. We will not barter our sanctuary laws for irregular raiders. Keep your fighters in Derdia, Supreme Wiseman.")}, 61,
                {cs("Variable[\"Zille_DerdiaHybridActive\"] = false; Variable[\"RiziaDLC.CountryRelation_Derdia_Unfriendly\"] = true;")});

            AddLine(conv, 61, AzmalId, RomusId, "Ack_Reject_Derdia",
                {cs("Static hissed fiercely as Azmal's tone turned frigid. \"Then face Smolak's guns alone, King of Rizia! Do not look to Naeal when your campaign stalls.\" The line severed with a sharp click.")}, -1);

            AddConversationWithAlias(db, conv, "Zille/DerdiaTalks", "Turn_Zille_DerdiaTalks");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Derdia Talks (ID 9995) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 7: Turn_Zille_LespiaTalks (ID 9996) - NEGOTIATIONS WITH LESPIA
        // Fixed: Prime Minister Alvarez (not President!), Perla (not Porte Lespia!),
        // No desert buzzards, Two-Front Pales War & sanctions awareness!
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
                {cs("The red secure hotline to Perla clicked alive with the unmistakable clink of ice cubes against crystal glass, followed by a raspy cough and a satisfied exhale of cigar smoke.")}, -1);

            AddLine(conv, 2, AlvarezId, RomusId, "Alvarez_Opening_Banter",
                {cs("Romus! My royal friend! Don't tell me you called to invite me to another stuffy opera in Porte Drazon. Word through Arcasian channels is that you're finally ready to give that clown Smolak the thrashing he's been begging for!")}, 3,
                {cs(NO_TWO_FRONT)});

            AddLine(conv, 102, AlvarezId, RomusId, "Alvarez_Opening_TwoFront",
                {cs("Have you completely lost your mind, Romus?! You're already firing on our allies in Pales, and now you call Perla expecting favors for a campaign against Wehlen? Give me one good reason not to hang up right now!")}, 3,
                {cs(TWO_FRONT)});

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            var alvarezHub = AddLine(conv, 3, RomusId, AlvarezId, "Romus_Alvarez_Open_Prompt",
                {cs("I leaned against the console, matching Alvarez's brisk tempo while keeping my guard up.")});

            alvarezHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10));
            alvarezHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11));
            alvarezHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12));

            AddChoice(conv, 10, AlvarezId, "Banter_Sarcastic",
                {cs("\"Enjoying an afternoon drink, Patricio? I thought you might appreciate seeing Wehlen's teeth kicked in.\"")},
                {cs("Enjoying an afternoon drink, Patricio? I assumed you might appreciate watching someone finally kick Wehlen's teeth in.")}, -1);

            AddChoice(conv, 11, AlvarezId, "Banter_Business",
                {cs("\"Let us skip the theatrics, Prime Minister Alvarez. We both know why this line was opened.\"")},
                {cs("Let us skip the theatrics, Prime Minister Alvarez. We both know why this hotline was opened. Let us talk about intelligence and regional security.")}, -1);

            AddChoice(conv, 12, AlvarezId, "Banter_Pressure",
                {cs("\"Wehlen is destabilizing South Merkopa. Lespia has a direct economic stake in our success.\"")},
                {cs("Wehlen's bandit regime destabilizes every trade route in the region. If Smolak holds Zille indefinitely, shipping across the Gulf of Moridia remains at his mercy.")}, -1);

            AddLine(conv, 20, AlvarezId, RomusId, "Alvarez_Business_Pitch",
                {cs("Alvarez took another sip, his tone shifting from jovial schemer to sharp capitalist shark. \"Look, Romus, I won't shed a single tear if Valdez's goons end up rotting in the Zille mud. But Lespia isn't a charity. You want our high-altitude ATO reconnaissance flights to map Valdez's camouflaged bunkers, and you want Arcasian-encrypted radios so your armor doesn't walk into an ambush.\"")}, 21,
                {cs(NO_TWO_FRONT)});

            AddLine(conv, 21, AlvarezId, RomusId, "Alvarez_Price_Demand",
                {cs("\"Here is my price: twenty percent guaranteed crude oil deliveries from your southern wells to Lespian refineries at preferential rates, PLUS Rizia's vote backing Lespia's position on the MITZ board. Agree, and my defense ministry will feed your generals live coordinates to blow Valdez's headquarters straight off the map.\"")}, 22);

            AddLine(conv, 120, AlvarezId, RomusId, "Alvarez_TwoFront_Pitch",
                {cs("Alvarez laughed coldly into the receiver. \"You want ATO reconnaissance on Wehlen while your navy is blockading Duke Reinhart in Pales? Bottom line, Romus: call off your ships from Pales and commit to a full energy pact with Lespia, or you can fight Smolak blind!\"")}, 22,
                {cs(TWO_FRONT)});

            foreach (int chId in new[] {{ 10, 11, 12 }})
            {{
                AddLink(conv, chId, 20);
                AddLink(conv, chId, 120);
            }}

            AddLine(conv, 22, LaurentoId, RomusId, "Laurento_Alvarez_Evaluation",
                {cs("Laurento leaned close to the receiver, speaking in a low whisper. \"Your Majesty, Alvarez's oil terms are steep, yet ATO aerial reconnaissance would drastically reduce our casualties and grant our commanders total battlefield clarity. We can press him down if we leverage his hatred of Smolak.\"")}, 30);

            var dealHub = AddLine(conv, 30, NarratorId, RomusId, "Alvarez_Deal_Hub_Prompt",
                {cs("Alvarez swirled the ice in his glass, awaiting your counter-offer.")});

            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Accept Alvarez terms
            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 50)); // Hard bargain
            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 60)); // Reject

            AddChoice(conv, 40, AlvarezId, "Accept_Alvarez_Pact",
                {cs("\"Agreed. Lespia gets preferential oil contracts in exchange for ATO reconnaissance and diplomatic cover.\"")},
                {cs("Agreed, Patricio. We will guarantee your preferential oil contracts and peace along the northern seas, provided Perla delivers uninterrupted aerial reconnaissance and diplomatic cover at the AN.")}, 41,
                {cs("Variable[\"Zille_LespiaPactAccepted\"] = true; Variable[\"Zille_Lespia_Intel\"] = true; Variable[\"RiziaDLC.CountryRelation_Lespia_Allied\"] = true; Variable[\"RiziaDLC.Diplomacy_Lespia_WehlenHelp\"] = true;")});

            AddLine(conv, 41, AlvarezId, RomusId, "Ack_Alvarez_Pact",
                {cs("Alvarez burst into a hearty laugh, clinking his glass against the receiver. \"Now that is statesmanship! Consider it done, Romus. Our reconnaissance planes are scrambling out of Perla as we speak. Happy hunting in Zille!\"")}, -1);

            AddChoice(conv, 50, AlvarezId, "Hard_Bargain_Alvarez",
                {cs("\"Ten percent oil contracts, and zero concessions on the MITZ. Take it, or we fight without you.\"")},
                {cs("Ten percent oil contracts on commercial terms, and not a single sovereign concession on the MITZ. Take it or leave it, Patricio. If Rizia crushes Wehlen alone, your leverage in South Merkopa evaporates.")}, 51,
                {cs("Variable[\"Zille_LespiaPactAccepted\"] = true; Variable[\"Zille_Lespia_Intel\"] = true; Variable[\"RiziaDLC.Diplomacy_Lespia_NegotiatingPower\"] = (Variable[\"RiziaDLC.Diplomacy_Lespia_NegotiatingPower\"] or 0) - 1;")},
                {cs(NO_TWO_FRONT)});

            AddLine(conv, 51, AlvarezId, RomusId, "Ack_Hard_Bargain",
                {cs("Alvarez swore softly under his breath before letting out an amused grunt. \"You drive a harder bargain than your father ever did, Your Majesty. Fine—ten percent it is. The radar coordinates will be in your war room within the hour.\"")}, -1);

            AddChoice(conv, 60, AlvarezId, "Reject_Alvarez_Greed",
                {cs("\"Rizian blood will not be bartered for Lespian corporate profits. We will reclaim Zille on our own terms.\"")},
                {cs("Rizian soldiers will not bleed to fatten your oil conglomerates, Prime Minister Alvarez. The Royal Army does not require Lespian charity to defeat Wehlen. Good day.")}, 61,
                {cs("Variable[\"Zille_LespiaPactAccepted\"] = false; Variable[\"Zille_Lespia_Intel\"] = false; Variable[\"RiziaDLC.CountryRelation_Lespia_Unfriendly\"] = true;")});

            AddLine(conv, 61, AlvarezId, RomusId, "Ack_Reject_Lespia",
                {cs("Alvarez's amusement vanished instantly into cold venom. \"Then good luck against Valdez's mines and artillery, Romus. Don't come begging to Perla when your tanks are burning in the mud.\" The line went dead.")}, -1);

            AddConversationWithAlias(db, conv, "Zille/LespiaTalks", "Turn_Zille_LespiaTalks");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Lespia Talks (ID 9996) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 8: Turn_Zille_RumburgTalks (ID 9997) - ROYAL HOTLINE WITH RUMBURG
        // Fixed: Beatrice is Romus's SISTER-IN-LAW (NOT Cousin!), Hugo absent variant,
        // GRACE / Rumburg hostility check, Lespia pact tension check!
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
                {cs("The brass-and-ivory royal trunk line to Thornbourgh buzzed with crystal clarity. Across two thousand miles of wire, the poised, imperious voice of Queen Beatrice Livingston echoed into the study, carrying all the weight of your late wife Lena's royal house.")}, -1);

            AddLine(conv, 2, BeatriceId, RomusId, "Beatrice_Royal_Greeting",
                {cs("Romus, my dear brother-in-law. We in Thornbourgh have watched your confrontation with that Wehzek upstart with keen interest. A sovereign monarch cannot allow a petty dictator to trample the honor of a sister crown.")}, 3,
                {cs('Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] ~= true')});

            AddLine(conv, 102, BeatriceId, RomusId, "Beatrice_Hostile_Greeting",
                {cs("Your Majesty. Given recent disappointments between Thornbourgh and Porte Drazon, I was surprised to hear your call—though even I have little patience for Wiktor Smolak's antics. Speak your mind.")}, 3,
                {cs('Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == true')});

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            var beatriceHub = AddLine(conv, 3, RomusId, BeatriceId, "Romus_Beatrice_Open_Prompt",
                {cs("I straightened my tunic, addressing Lena's sister with the formal dignity expected between two royal courts.")});

            beatriceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10));
            beatriceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11));
            beatriceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12));

            AddChoice(conv, 10, BeatriceId, "Solidarity_Royal",
                {cs("\"Your Majesty. House Toras stands resolute, and we are determined to restore our rightful borders.\"")},
                {cs("Beatrice, it is good to hear your voice. House Toras stands resolute. Over twenty-five years of Wehzek insolence will be answered with royal steel.")}, 20,
                {cs("Variable[\"Rumburg_Romus_Loyal\"] = true;")});

            AddChoice(conv, 11, BeatriceId, "Munitions_Request",
                {cs("\"Your Majesty, Rizia requires heavy artillery shells and diplomatic shielding in the Alliance of Nations.\"")},
                {cs("Your Majesty. Rizia's cause is just, yet our campaign requires heavy-caliber munitions and strong diplomatic shielding in the Alliance of Nations against Contanan interference.")}, 20,
                {cs("Variable[\"Rumburg_Romus_Munitions\"] = true;")});

            AddChoice(conv, 12, BeatriceId, "Sovereign_Assertive",
                {cs("\"Rizia will win this campaign with its own blood, though GRACE solidarity is welcomed.\"")},
                {cs("Rizia will fight and win this campaign with our own blood, yet solidarity among the monarchies of GRACE will show the world that our crowns stand together.")}, 20,
                {cs("Variable[\"Rumburg_Romus_Proud\"] = true;")});

            AddLine(conv, 20, BeatriceId, RomusId, "Beatrice_Imperial_Offer",
                {cs("You speak as a true king, Romus. Rumburg will not stand idly by while republican rabble mocks an allied throne. We have instructed our naval attachés to monitor shipping in the Gulf, and three freight trains carrying 152mm heavy artillery munitions from our royal arsenals can be routed toward Brenas.")}, -1);

            AddLine(conv, 21, BeatriceId, RomusId, "Beatrice_AN_Pledge",
                {cs("Furthermore, our envoy in Konstantium will wield Rumburg's weight in the Alliance of Nations to blunt any sanctions Hegel or Malenyev propose. We ask only one thing in return: that Rizia remains an unyielding pillar of GRACE, keeping ATO and Arcasian profiteers far from your court.")}, -1,
                {cs('Variable["Zille_LespiaPactAccepted"] ~= true')});

            AddLine(conv, 121, BeatriceId, RomusId, "Beatrice_AN_Pledge_LespiaWarn",
                {cs("Still, whispers from Perla tell me you have already been bargaining with Prime Minister Alvarez. Do not trade your sovereign dignity to ATO merchants, Romus—Rumburg's support relies on Rizia remaining faithful to GRACE, not becoming Lespia's junior partner.")}, -1,
                {cs('Variable["Zille_LespiaPactAccepted"] == true')});

            AddLink(conv, 20, 21);
            AddLink(conv, 20, 121);

            AddLine(conv, 22, HugoId, RomusId, "Hugo_Beatrice_Support",
                {cs("Hugo nodded with deep reverence. \"A magnificent display of royal solidarity! With Rumburg's heavy shells and diplomatic shield, Smolak stands isolated.\"")}, 30,
                {cs(HUGO_FREE)});

            AddLine(conv, 122, LaurentoId, RomusId, "Laurento_Beatrice_Support",
                {cs("Laurento inclined his head discreetly. \"With Thornbourgh's diplomatic cover at the AN and heavy munitions on the rails, our strategic hand strengthens dramatically, Your Majesty.\"")}, 30,
                {cs(HUGO_GONE)});

            foreach (int pId in new[] {{ 21, 121 }})
            {{
                AddLink(conv, pId, 22);
                AddLink(conv, pId, 122);
            }}

            var responseHub = AddLine(conv, 30, NarratorId, RomusId, "Beatrice_Response_Prompt",
                {cs("Queen Beatrice waited with cool regal authority for your acknowledgment.")});

            responseHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40));
            responseHub.outgoingLinks.Add(CreateLink(conv.id, 30, 50));

            AddChoice(conv, 40, BeatriceId, "Pledge_GRACE_Solidarity",
                {cs("\"House Toras pledges unwavering solidarity to GRACE. Together, our crowns will prevail.\"")},
                {cs("House Toras pledges unwavering solidarity to GRACE and our royal kinship, Beatrice. Together, our crowns will prove that sovereign order outlasts republican chaos. Thank you, sister-in-law.")}, 41,
                {cs("Variable[\"Zille_Rumburg_Munitions\"] = true; Variable[\"RiziaDLC.CountryRelation_Rumburg_Allied\"] = true; Variable[\"RiziaDLC.Resources_Military_Equipment\"] = (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) + 2;")});

            AddLine(conv, 41, BeatriceId, RomusId, "Ack_Beatrice_Pledge",
                {cs("Beatrice smiled with imperious satisfaction. \"Splendid, Romus. For Lena's memory and for the future of our houses—go forth and claim Zille. Thornbourgh stands with you.\"")}, -1);

            AddChoice(conv, 50, BeatriceId, "Grateful_Sovereign",
                {cs("\"We accept your munitions with royal gratitude, Beatrice. Rizia remembers who stood by us.\"")},
                {cs("We accept your heavy munitions and diplomatic backing with deep gratitude, Beatrice. Rizia will remember who stood beside us in our hour of need. May Saint Wruhec watch over both our realms.")}, 51,
                {cs("Variable[\"Zille_Rumburg_Munitions\"] = true; Variable[\"RiziaDLC.CountryRelation_Rumburg_Friendly\"] = true; Variable[\"RiziaDLC.Resources_Military_Equipment\"] = (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) + 1;")});

            AddLine(conv, 51, BeatriceId, RomusId, "Ack_Beatrice_Sovereign",
                {cs("\"May victory crown your banners, Romus. I expect good news when Zille is once more Rizian.\" The imperial line softly disconnected.")}, -1);

            AddConversationWithAlias(db, conv, "Zille/RumburgTalks", "Turn_Zille_RumburgTalks");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Rumburg Talks (ID 9997) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 9: Turn_Zille_WarPreNegotiationsBriefing (ID 9991) - PRE-NEGOTIATIONS
        // Fixed: No river valley, Lucita/Hugo absent checks, Outcome-aware briefing!
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
                {cs("The heavy guns had fallen eerily silent along the smoke-shrouded Zille frontier and across the waters of the Gulf of Moridia. In the War Room, courier dispatches lay piled beside urgent telegrams from Konstantium. Wiktor Smolak had dispatched an envoy under a white flag proposing an immediate face-to-face parley.")}, -1);

            AddLine(conv, 2, LucitaId, RomusId, "Lucita_PreNeg_Report",
                {cs("Your Majesty. Fighting has paused along the front. Both armies have expended immense ammunition reserves, and Smolak's envoy awaits your answer at the neutral border pavilion.")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 102, CarlosId, RomusId, "Carlos_PreNeg_Report",
                {cs("Your Majesty. A temporary ceasefire holds along the front lines. Both sides are exhausted of shells and fuel, and Smolak's envoy awaits our response at the neutral border pavilion.")}, -1,
                {cs(LUCITA_GONE)});

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            AddLine(conv, 3, LaurentoId, RomusId, "Laurento_PreNeg_Warning",
                {cs("The Alliance of Nations has issued an urgent ceasefire appeal, Your Majesty. Both superpowers are watching closely. What we win at the table now depends entirely on the ground our troops hold.")}, -1);

            AddLink(conv, 2, 3);
            AddLink(conv, 102, 3);

            AddLine(conv, 4, HugoId, RomusId, "Hugo_PreNeg_Counsel",
                {cs("Romus... Remember who Smolak is. He is a cornered fox who shifts between jester and butcher in a heartbeat. Guard the dignity of House Toras, whatever terms lie ahead.")}, 10,
                {cs(HUGO_FREE)});

            AddLine(conv, 104, LaurentoId, RomusId, "Laurento_PreNeg_NoHugo",
                {cs("Remember Smolak's nature, Your Majesty—he will alternate between clownish charm and sudden threats. Keep a cool head when you sit across from him.")}, 10,
                {cs(HUGO_GONE)});

            AddLink(conv, 3, 4);
            AddLink(conv, 3, 104);

            var preNegHub = AddLine(conv, 10, RomusId, LaurentoId, "Romus_PreNeg_Prompt",
                {cs("I looked across the map showing the final positions of our divisions from Brenas to the Gulf. The hour had come to face Wiktor Smolak in person.")});

            preNegHub.outgoingLinks.Add(CreateLink(conv.id, 10, 20));
            preNegHub.outgoingLinks.Add(CreateLink(conv.id, 10, 21));

            AddChoice(conv, 20, LaurentoId, "Choice_Parley_Strength",
                {cs("\"Prepare the royal motorcade. I will meet Smolak and negotiate under the royal standard.\"")},
                {cs("Prepare the royal armored motorcade. Assemble our escort and forward commanders. I will meet Smolak at the border pavilion and settle this face to face.")}, -1,
                {cs("Variable[\"Zille_Parley_Ready\"] = true;")});

            AddChoice(conv, 21, LaurentoId, "Choice_Unconditional_Surrender",
                {cs("\"Tell Smolak our guns are still loaded—if he stalls, the bombardment resumes!\"")},
                {cs("Inform Smolak that if he tries to stall or play games at the pavilion, our batteries and ships will reopen fire within the hour. Let us go settle Zille's fate.")}, -1,
                {cs("Variable[\"Zille_Parley_Ready\"] = true; Variable[\"Zille_Parley_Uncompromising\"] = true;")},
                {cs('(Variable["Zille_War_Outcome"] or 0) >= 3 or (Variable["Zille_War_Outcome"] or 0) == 0')});

            AddLine(conv, 22, LucitaId, RomusId, "Ack_PreNeg_Lucita",
                {cs("Lucita strapped on her sidearm and saluted with iron resolve. \"The royal escort is mounted, Your Majesty. Let us bring this to an end.\"")}, -1,
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
        // Fixed: No river/desert, no gilded armor/breastplate, full Outcome gating:
        // Victory (4/5), Stalemate (3), AND Defeat/Fiasco (1/2)!
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
                {cs("Look who finally arrived! The great King Romus of Rizia in the flesh. Tell me, Your Majesty... Do you care for tea? Wehzek chicory blend. Tastes like gunpowder and mud, yet it keeps a man awake while the artillery roars.")}, 3);

            var parleyHub = AddLine(conv, 3, RomusId, SmolakId, "Romus_Parley_Posture_Prompt",
                {cs("I sat across the scarred folding table, looking into the bloodshot, calculating eyes of the Wehzek president.")});

            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Victory posture
            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 20)); // Stalemate posture
            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 30)); // Defiant victory posture
            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 40)); // Defeat posture

            AddChoice(conv, 10, SmolakId, "Posture_Victor",
                {cs("\"Your army is shattered, Smolak. Sign the capitulation and evacuate Zille today.\"")},
                {cs("Your garrisons are broken and your sea lanes across the Gulf are severed, Smolak. We are not here to drink tea. Sign the evacuation instrument and pull your surviving troops back across the sea to Wehlen today.")}, 100,
                "", {cs(OUT_VICTORY)});

            AddChoice(conv, 20, SmolakId, "Posture_Stalemate",
                {cs("\"Both our armies have bled enough. Let us discuss a realistic settlement.\"")},
                {cs("Both our nations have bled enough into this mud, Smolak. If this slaughter continues, neither of us will have an economy left. Let us discuss terms for an end to hostilities.")}, 200,
                "", {cs(OUT_STALEMATE)});

            AddChoice(conv, 30, SmolakId, "Posture_Defiant",
                {cs("\"You brought this defeat upon yourself when you tried to extort House Toras.\"")},
                {cs("You brought this ruin upon Wehlen when you thought you could extort House Toras and hold Rizian soil hostage. Every drop of blood spilled rests on your head.")}, 100,
                "", {cs(OUT_VICTORY)});

            AddChoice(conv, 40, SmolakId, "Posture_Defeated",
                {cs("\"Our offensive has stalled, Wiktor. Let us speak plainly about halting the bloodshed.\"")},
                {cs("Fortune turned against our arms on the field, Wiktor. Spare me your theatrics and put your terms on the table so we may stop the slaughter.")}, 300,
                "", {cs(OUT_DEFEAT)});

            // ================= BRANCH A: DECISIVE VICTORY / OVERWHELMING TRIUMPH =================
            AddLine(conv, 100, SmolakId, RomusId, "Smolak_Defeated_Rant",
                {cs("Smolak ground his cigarette into the floorboards beneath his boot, his hands trembling with suppressed fury. \"You think you're a conqueror, Romus? You think waving a map makes you a hero?! Fine! Valdez blundered, and my generals couldn't organize a parade in Wraclawitz!\"")}, 101);

            AddLine(conv, 101, SmolakId, RomusId, "Smolak_Defeated_Terms",
                {cs("\"Take Zille! Take your precious mines and harbors! Yet Wehlen will not pay a single coin of tribute! Let my surviving boys embark by sea back to mainland Wehlen with their rifles, and I will sign your damned treaty.\"")}, 102);

            var victoryChoiceHub = AddLine(conv, 102, NarratorId, RomusId, "Victory_Terms_Prompt",
                {cs("Smolak leaned across the table, cornered, desperate, yet stubbornly bargaining for survival.")});

            victoryChoiceHub.outgoingLinks.Add(CreateLink(conv.id, 102, 110)); // Decisive Victory
            victoryChoiceHub.outgoingLinks.Add(CreateLink(conv.id, 102, 120)); // Overwhelming Triumph

            AddChoice(conv, 110, SmolakId, "Accept_Decisive_Surrender",
                {cs("\"Zille returns unconditionally to Rizia. Your surviving troops may evacuate by sea.\"")},
                {cs("Zille returns unconditionally to the Crown of Rizia, effective immediately. Your surviving garrisons may evacuate across the Gulf of Moridia under white flags. Yet if a single Wehzek soldier sets foot in Zille again, it means total war.")}, 111,
                {cs("Variable[\"Zille_War_Outcome\"] = 4; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = true;")},
                {cs(OUT_VICTORY)});

            AddLine(conv, 111, SmolakId, RomusId, "Smolak_Signs_Decisive",
                {cs("Smolak snatched the pen, scribbling his signature with vicious, jagged strokes before tossing it onto the parchment. \"Done! Pack up, boys, we're sailing home! Enjoy your oilfields and your headaches, Romus!\"")}, -1);

            AddChoice(conv, 120, SmolakId, "Demand_Overwhelming_Triumph",
                {cs("\"Not enough. You will cede Zille, pay massive war indemnities, and grant Grodzizg autonomy!\"")},
                {cs("Not enough, Smolak. Our forces already hold deep targets in mainland Wehlen. You will cede Zille, pay massive gold and energy reparations, demilitarize your coast, and accept protected Free City status for Grodzizg. Sign, or our columns push straight toward Wraclawitz!")}, 121,
                {cs("Variable[\"Zille_War_Outcome\"] = 5; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"Grodzizg_FreeCity\"] = true; Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) + 4; Variable[\"RiziaDLC.Resources_Energy\"] = (Variable[\"RiziaDLC.Resources_Energy\"] or 0) + 3;")},
                {cs(OUT_OVERWHELM)});

            AddLine(conv, 121, SmolakId, RomusId, "Smolak_Signs_Overwhelming",
                {cs("Smolak turned ashen, his bravado evaporating into panic as he stared at the map pins deep inside Wehlen. \"You're ruthless, Romus... an absolute shark! Damn you... I'll sign. Just halt your armor! Keep Rotsla and Wraclawitz out of this!\" He signed with shaking hands.")}, -1);

            // ================= BRANCH B: BLOODY STALEMATE & INDEPENDENT ZILLE BUFFER =================
            AddLine(conv, 200, SmolakId, RomusId, "Smolak_Stalemate_Opening",
                {cs("Smolak took a deep drag of his cigarette, blowing gray smoke toward the canvas roof. \"Neither of us can break the other, Romus. Your tanks stalled on the approaches to Zille City, and my boys can't crack Brenas. We can keep feeding young men into artillery fire until Kyrute chains us both... or we can be clever.\"")}, 201);

            AddLine(conv, 201, SmolakId, RomusId, "Smolak_Buffer_Proposal",
                {cs("\"Here is my offer: an Independent Zille. Neither Rizia nor Wehlen. A demilitarized neutral buffer state, governed by a joint civilian council, with guaranteed oil and sea transit rights for both our nations. Neither of us loses face. What do you say, Your Majesty?\"")}, -1);

            AddLine(conv, 202, NarratorId, RomusId, "Stalemate_Hub_Lucita",
                {cs("Lucita frowned with deep skepticism, while Smolak watched your eyes like a card shark staking his final hand.")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 203, NarratorId, RomusId, "Stalemate_Hub_NoLucita",
                {cs("Your staff officers exchanged tense glances while Smolak watched your eyes like a card shark staking his final hand.")}, -1,
                {cs(LUCITA_GONE)});

            AddLink(conv, 201, 202);
            AddLink(conv, 201, 203);
            AddLink(conv, 202, 210);
            AddLink(conv, 202, 220);
            AddLink(conv, 203, 210);
            AddLink(conv, 203, 220);

            AddChoice(conv, 210, SmolakId, "Accept_Independent_Buffer",
                {cs("\"Agreed. Zille shall become an Independent Neutral Buffer State under international guarantee.\"")},
                {cs("An Independent Neutral Zille. It ends the bloodshed, rescues our economy, and frees the people of Zille from your grip while separating our borders. I accept. Let the Alliance of Nations ratify the neutral charter.")}, 211,
                {cs("Variable[\"Zille_War_Outcome\"] = 3; Variable[\"Zille_Independent_Buffer\"] = true; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false;")});

            AddLine(conv, 211, SmolakId, RomusId, "Smolak_Buffer_Signed",
                {cs("Smolak smiled, a genuine glint of shrewd relief in his eyes as he tapped his tin cup against the table. \"A statesman's compromise, Romus. Let the clerks in Konstantium draft the charters. The war is over.\"")}, -1);

            AddChoice(conv, 220, SmolakId, "Reject_Buffer_Ceasefire",
                {cs("\"Never. Zille is Rizian or nothing. We freeze the frontlines under an armed ceasefire.\"")},
                {cs("Zille has been Rizian for centuries; I will never recognize an artificial state carved out of our historical province. We freeze the lines under an armed ceasefire—and remember that this dispute is not over.")}, 221,
                {cs("Variable[\"Zille_War_Outcome\"] = 2; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false;")});

            AddLine(conv, 221, SmolakId, RomusId, "Smolak_Ceasefire_Signed",
                {cs("Smolak snorted, flicking his cigarette butt into the mud. \"Suit yourself, King. An armed truce it is. Just keep your border sentries' fingers off their triggers.\"")}, -1);

            // ================= BRANCH C: TACTICAL DEFEAT / TOTAL FIASCO =================
            AddLine(conv, 300, SmolakId, RomusId, "Smolak_Victorious_Mock",
                {cs("Smolak leaned back with a theatrical, predatory grin, spreading his arms wide. \"Ah! How quickly royal arrogance melts when the shells stop flying, eh, Romus? You marched north expecting a coronation parade, and instead General Valdez broke your spearheads!\"")}, -1);

            AddLine(conv, 301, SmolakId, RomusId, "Smolak_TacticalDefeat_Terms",
                {cs("\"Your adventure cost thousands of lives and gained you nothing. Withdraw your battered divisions behind the Brenas line, drop your claim to Zille, and pay Wehlen modest customs compensation—and I will refrain from marching further south.\"")}, -1,
                {cs(OUT_TACTICAL_DEFEAT)});

            AddLine(conv, 302, SmolakId, RomusId, "Smolak_Fiasco_Terms",
                {cs("\"My armored columns are sitting inside Brenas right now, 'Your Majesty'! You gambled and lost everything. Sign the surrender of southern Brenas and pay war indemnities to Wraclawitz, or I let my troops march all the way to Porte Drazon!\"")}, -1,
                {cs(f'Variable["Zille_War_Outcome"] == 1')});

            AddLink(conv, 300, 301);
            AddLink(conv, 300, 302);

            AddChoice(conv, 310, SmolakId, "Accept_Tactical_Defeat",
                {cs("\"We will withdraw behind the Brenas frontier and sign the armistice.\"")},
                {cs("To spare our kingdom further ruin, Rizia accepts an armistice along the pre-war frontier and suspends military claims over Zille. Do not mistake restraint for surrender, Wiktor.")}, 311,
                {cs("Variable[\"Zille_War_Outcome\"] = 2; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"RiziaDLC.ZilleReferendum_Lost\"] = true;")},
                {cs(OUT_TACTICAL_DEFEAT)});

            AddLine(conv, 311, SmolakId, RomusId, "Smolak_Signs_TacticalDefeat",
                {cs("Smolak cackled softly, signing with an exaggerated flourish. \"Oh, I wouldn't dream of underestimating you, Romus. Enjoy explaining this triumph to your noble houses!\"")}, -1);

            AddChoice(conv, 320, SmolakId, "Accept_Total_Fiasco",
                {cs("\"Sign the humiliating surrender of southern Brenas to save Porte Drazon.\"")},
                {cs("To save the capital and our citizens from total devastation, I accept your terms. Withdraw from the approaches to Porte Drazon.")}, 321,
                {cs("Variable[\"Zille_War_Outcome\"] = 1; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"Brenas_Lost_To_Wehlen\"] = true;")},
                {cs(OUT_FIASCO)});

            AddLine(conv, 321, SmolakId, RomusId, "Smolak_Signs_Fiasco",
                {cs("Smolak laughed uproariously, slapping the table. \"History will remember today, King Romus! Your father gave me Zille; you just handed me Brenas! Good luck surviving your own generals tonight!\"")}, -1);

            AddLink(conv, 301, 310);
            AddLink(conv, 301, 320);
            AddLink(conv, 302, 320);

            AddConversationWithAlias(db, conv, "Zille/WarSmolakFinalParley", "Turn_Zille_WarSmolakFinalParley");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Smolak Final Parley (ID 9992) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 11: Turn_Zille_WarPeaceTreaty (ID 9993) - PEACE TREATY CEREMONY
        // Fixed: Outcome-gated choices so you can't sign Victory after a Defeat!
        // Fixed: Hugo / Lucita / Taddeus absent checks & valid RiziaDLC variables!
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
                {cs("The Grand Throne Room of Palas Rezna had been arranged for the formal ratification of the Treaty of Zille. Foreign ambassadors, military commanders, and provincial nobles lined the marble hall beneath portraits of Rizian kings. The parchment instrument rested upon the central table beside the royal seal of House Toras.")}, -1);

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Treaty_Declaration",
                {cs("Your Majesty... The guns have fallen silent. The ink dries upon the instrument of peace, and the scribes await your royal seal to close this chapter in the annals of Rizia.")}, 3,
                {cs(HUGO_FREE)});

            AddLine(conv, 102, LaurentoId, RomusId, "Laurento_Treaty_Declaration",
                {cs("Your Majesty. The diplomatic instrument lies before you, witnessed by the envoys of the Alliance of Nations. The realm awaits your royal signature.")}, 3,
                {cs(HUGO_GONE)});

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            var outcomeHub = AddLine(conv, 3, NarratorId, RomusId, "Outcome_Hub_Prompt",
                {cs("You stepped forward to the table to ratify the outcome of the campaign.")});

            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Decisive Victory
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 20)); // Overwhelming Triumph
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 30)); // Independent Zille Buffer
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 40)); // Tactical Defeat
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 50)); // Total Fiasco

            AddChoice(conv, 10, HugoId, "Sign_Decisive_Victory",
                {cs("\"Sign the Treaty of Restoration: Zille returns to the Crown of Rizia!\"")},
                {cs("In the presence of Saint Wruhec and the nobles of Rizia, I affix the royal seal. Zille is liberated and reunited with the Kingdom of Rizia!")}, -1,
                {cs("Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"RiziaDLC.Zille_PromisedToHouseToras\"] = true; Variable[\"RiziaDLC.MapLayer_Zille_Brenas\"] = true;")},
                {cs('((Variable["Zille_War_Outcome"] or 0) == 4 or (Variable["Zille_War_Outcome"] or 0) == 0)')});

            AddLine(conv, 11, HugoId, RomusId, "Ack_Decisive_Ceremony",
                {cs("The hall erupted into thunderous cheers, bells pealing from every sanctuary in Porte Drazon. Hugo wiped tears of joy from his eyes, bowing deeply before his King. \"Nearly thirty years of grief washed away in triumph! Long live King Romus the Restorer!\"")}, -1,
                {cs(HUGO_FREE)});

            AddLine(conv, 111, LaurentoId, RomusId, "Ack_Decisive_NoHugo",
                {cs("Thunderous applause filled the Grand Throne Room as cathedral bells rang across Porte Drazon. Laurento bowed deeply. \"A historic restoration, Your Majesty. Zille is home.\"")}, -1,
                {cs(HUGO_GONE)});

            AddLink(conv, 10, 11);
            AddLink(conv, 10, 111);

            AddChoice(conv, 20, HugoId, "Sign_Overwhelming_Triumph",
                {cs("\"Sign the Treaty of Total Reparations: Wehlen humbled and Grodzizg placed under protection!\"")},
                {cs("By this treaty, Wehlen surrenders Zille unconditionally, pays immense war indemnities, demilitarizes its southern shore, and recognizes the Free City of Grodzizg. House Toras has achieved absolute triumph!")}, -1,
                {cs("Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"RiziaDLC.Zille_PromisedToHouseToras\"] = true; Variable[\"RiziaDLC.MapLayer_Zille_Brenas\"] = true; Variable[\"Grodzizg_FreeCity\"] = true;")},
                {cs(OUT_OVERWHELM)});

            AddLine(conv, 21, LucitaId, RomusId, "Ack_Overwhelming_Ceremony",
                {cs("Lucita unsheathed her ceremonial saber and saluted with shining eyes. \"An epochal triumph, Your Majesty! We have not merely reclaimed our homeland—we have broken Wehlen's military power for a generation!\"")}, -1,
                {cs(LUCITA_FREE)});

            AddLine(conv, 121, CarlosId, RomusId, "Ack_Overwhelming_NoLucita",
                {cs("General Carlos Azaro raised his saber in crisp salute. \"An epochal victory, Your Majesty. Rizia stands unchallenged across the Gulf of Moridia.\"")}, -1,
                {cs(LUCITA_GONE)});

            AddLink(conv, 20, 21);
            AddLink(conv, 20, 121);

            AddChoice(conv, 30, HugoId, "Sign_Independent_Buffer",
                {cs("\"Sign the Treaty of Neutrality: The Independent Republic of Zille is established.\"")},
                {cs("To spare our people further carnage, I sign the charter establishing the Independent Neutral State of Zille. May this neutral territory forever stand as a peaceful bridge rather than a battlefield.")}, 31,
                {cs("Variable[\"Zille_Independent_Buffer\"] = true; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false;")},
                {cs('((Variable["Zille_War_Outcome"] or 0) == 3 or Variable["Zille_Independent_Buffer"] == true or (Variable["Zille_War_Outcome"] or 0) == 0)')});

            AddLine(conv, 31, LaurentoId, RomusId, "Ack_Buffer_Ceremony",
                {cs("Laurento bowed solemnly. \"The Alliance of Nations applauds your royal wisdom, Your Majesty. Though the province is not annexed, peace and guaranteed transit across the strait are secured.\"")}, -1);

            AddChoice(conv, 40, HugoId, "Sign_Tactical_Defeat",
                {cs("\"Sign the Armed Armistice: Withdraw to the pre-war frontier under an uneasy truce.\"")},
                {cs("With a heavy heart, I sign this armistice. Our brave soldiers fought with unmatched valor, yet we must preserve the realm's strength. Zille remains outside our borders... for now.")}, -1,
                {cs("Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"RiziaDLC.ZilleReferendum_Lost\"] = true;")},
                {cs('(Variable["Zille_Independent_Buffer"] ~= true and ((Variable["Zille_War_Outcome"] or 0) == 2 or (Variable["Zille_War_Outcome"] or 0) == 0))')});

            AddLine(conv, 41, HugoId, RomusId, "Ack_Tactical_Defeat",
                {cs("A somber silence fell over the court. Hugo sighed deeply, his shoulders bowed with grief. \"A bitter day for House Toras, Romus. Yet the realm endures, and we must rebuild.\"")}, -1,
                {cs(HUGO_FREE)});

            AddLine(conv, 141, LaurentoId, RomusId, "Ack_Tactical_Defeat_NoHugo",
                {cs("A heavy hush fell over the chamber. Laurento lowered his eyes solemnly. \"A bitter hour, Your Majesty, yet the kingdom remains intact to fight another day.\"")}, -1,
                {cs(HUGO_GONE)});

            AddLink(conv, 40, 41);
            AddLink(conv, 40, 141);

            AddChoice(conv, 50, HugoId, "Sign_Total_Fiasco",
                {cs("\"Sign the Instrument of Surrender: Concede southern Brenas to save Porte Drazon.\"")},
                {cs("To prevent the destruction of Porte Drazon, I sign this humiliating peace. May God forgive me for the tragedy that has befallen our kingdom.")}, -1,
                {cs("Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"Brenas_Lost_To_Wehlen\"] = true; Variable[\"RiziaDLC.Azaro_HasPowerToCoup\"] = true;")},
                {cs(OUT_FIASCO)});

            AddLine(conv, 51, NarratorId, RomusId, "Ack_Total_Fiasco",
                {cs("Shouts of outrage and fury broke out among the assembled officers. Duke Taddeus stormed from the hall in disgust, while dark whispers of a military coup echoed through the stone corridors. The monarchy stood on the brink of collapse.")}, -1,
                {cs(TADDEUS_FREE)});

            AddLine(conv, 151, NarratorId, RomusId, "Ack_Total_Fiasco_NoTaddeus",
                {cs("Shouts of outrage broke out among the assembled noble houses and generals. Officers slammed their sabers onto the marble floor, and dark whispers of mutiny echoed through the corridors of Palas Rezna.")}, -1,
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
