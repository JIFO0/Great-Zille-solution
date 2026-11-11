import re

def update_manager():
    with open('src/GreatZilleSolution/WarOperationZilleManager.cs', 'r', encoding='utf-8') as f:
        content = f.read()

    replacement = '''                // Register all custom Great Zille scenes in EntityDataManager
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_WarPlanning", "Turn_Zille_WarPlanning", "Emergency Crown Council: The Fate of Zille", "Council Chamber, Palas Rezna", "Zille/WarPlanning");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_WarBalconySpeech", "Turn_Zille_WarBalconySpeech", "A Royal Proclamation of War", "Palas Rezna Balcony", "Zille/WarBalconySpeech");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_WarLogisticsDispute", "Turn_Zille_WarLogisticsDispute", "Supply Lines of Brenas: Azaro vs Sazon", "Ministry of War, Porte Drazon", "Zille/WarLogisticsDispute");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_MaveNortusHQ", "Turn_Zille_MaveNortusHQ", "Frontline Headquarters: The Battle for Zille", "Mayor\'s Hall, Mave Nortus", "Zille/MaveNortusHQ");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_DerdiaTalks", "Turn_Zille_DerdiaTalks", "Derdian Mission: Faith, Oil and Mercenaries", "Derdian Mission, Porte Drazon", "Zille/DerdiaTalks");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_LespiaTalks", "Turn_Zille_LespiaTalks", "Lespian Diplomatic Hotline: Air Recon and Munitions", "Foreign Ministry Communications Room", "Zille/LespiaTalks");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_RumburgTalks", "Turn_Zille_RumburgTalks", "Imperial Telegram from Thornbourgh: Rumburgian Munitions", "Imperial Diplomatic Cabinet", "Zille/RumburgTalks");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_WarPreNegotiations", "Turn_Zille_WarPreNegotiationsBriefing", "Pre-Negotiations Briefing & Foreign Hotlines", "War Room & Communications Cabinet", "Zille/PreNegotiationsBriefing");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_WarSmolakParley", "Turn_Zille_WarSmolakFinalParley", "Frontline Parley with Wiktor Smolak", "Neutral Military Pavilion, Zille Border", "Zille/SmolakFinalParley");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_WarPeaceTreaty", "Turn_Zille_WarPeaceTreaty", "The Treaty of Zille", "Treaty Pavilion", "Zille/PeaceTreaty");'''

    lines = content.splitlines(keepends=True)
    out_lines = []
    skip = 0
    for line in lines:
        if 'Register all 6 custom Great Zille scenes' in line or 'Register all custom Great Zille scenes' in line:
            out_lines.append(replacement + '\n')
            skip = 5
        elif skip > 0:
            skip -= 1
        else:
            out_lines.append(line)

    with open('src/GreatZilleSolution/WarOperationZilleManager.cs', 'w', encoding='utf-8') as f:
        f.writelines(out_lines)
    print("WarOperationZilleManager.cs updated successfully.")

def update_spawner():
    with open('src/GreatZilleSolution/ZilleEventSpawnerUI.cs', 'r', encoding='utf-8') as f:
        content = f.read()

    custom_mod_events = '''            // 1. Mod events registered prominently at the top
            AddModNewEvent("Turn_Zille_WarPlanning", "Emergency Crown Council: The Fate of Zille", "Council Chamber, Palas Rezna", "MODNEW");
            AddModNewEvent("Turn_Zille_WarLogisticsDispute", "Supply Lines of Brenas: Azaro vs Sazon", "Ministry of War, Porte Drazon", "MODNEW");
            AddModNewEvent("Turn_Zille_WarBriefing", "A Royal Briefing Before the Invasion of Zille", "Council Chambers, Palas Rezna", "MODNEW");
            AddModNewEvent("Turn_Zille_WarBalconySpeech", "A Royal Proclamation of War", "Palas Rezna Balcony", "MODNEW");
            AddModNewEvent("Turn_Zille_MaveNortusHQ", "Frontline Headquarters: The Battle for Zille (Mave Nortus)", "Mayor\'s Hall, Mave Nortus", "MODNEW");
            AddModNewEvent("Turn_Zille_DerdiaTalks", "Derdian Mission: Faith, Oil and Mercenaries", "Derdian Mission, Porte Drazon", "MODNEW");
            AddModNewEvent("Turn_Zille_LespiaTalks", "Lespian Diplomatic Hotline: Air Recon and Munitions", "Foreign Ministry Communications Room", "MODNEW");
            AddModNewEvent("Turn_Zille_RumburgTalks", "Imperial Telegram from Thornbourgh: Rumburgian Munitions", "Imperial Diplomatic Cabinet", "MODNEW");
            AddModNewEvent("Turn_Zille_WarPreNegotiationsBriefing", "Pre-Negotiations Briefing & Foreign Hotlines", "War Room & Communications Cabinet", "MODNEW");
            AddModNewEvent("Turn_Zille_WarSmolakFinalParley", "Frontline Parley with Wiktor Smolak", "Neutral Military Pavilion, Zille Border", "MODNEW");
            AddModNewEvent("Turn_Zille_WarPeaceTreaty", "The Treaty of Zille", "Treaty Pavilion", "MODNEW");
'''

    if 'AddModNewEvent("Turn_Zille_WarPlanning"' not in content:
        content = content.replace('// Mod events are loaded dynamically from masterDatabase and game data', custom_mod_events)
        with open('src/GreatZilleSolution/ZilleEventSpawnerUI.cs', 'w', encoding='utf-8') as f:
            f.write(content)
        print("ZilleEventSpawnerUI.cs updated successfully.")
    else:
        print("ZilleEventSpawnerUI.cs already contains mod events.")

update_manager()
update_spawner()
