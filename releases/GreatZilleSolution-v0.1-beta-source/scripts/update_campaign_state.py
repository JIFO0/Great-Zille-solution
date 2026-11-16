import re

path = 'src/GreatZilleSolution/ZilleCampaignState.cs'
with open(path, 'r', encoding='utf-8') as f:
    text = f.read()

# Replace ZilleRomulusPlan enum
old_block = """    public enum ZilleRomulusPlan
    {
        None,
        Sword,    // Operacja Righteous Sword (Półwysep Zille + Brenas + Morza)
        Ark       // Plan Romulusa: Wehlen + Brenas + Pas Graniczny Zille + Morza
    }"""

new_block = """    public enum ZilleRomulusPlan
    {
        None,
        Sword,          // Operation Golden Sword (Central Armored Push)
        GoldenSword = Sword,
        Ark,            // Operation Golden Ark (Maritime & Coastal Envelopment)
        GoldenArk = Ark,
        TotalRepayment  // Operation Total Repayment (Counter-Invasion into Wehlen)
    }"""

if old_block in text:
    text = text.replace(old_block, new_block, 1)
else:
    print("Warning: old_block not found in ZilleCampaignState.cs")

extra_props = """        // Logistics & Intelligence Doctrines
        public static string LogisticsRoute { get; set; } = "None"; // "Sazon", "Azaro", "Compromise"
        public static bool IsRumburgMunitionsActive { get; set; } = false;
        public static bool IsLespiaIntelActive { get; set; } = false;
        public static int Phase1CitiesCaptured { get; set; } = 0;
        public static int Phase2CitiesCaptured { get; set; } = 0;
        public static bool ZilleCityCaptured { get; set; } = false;
"""

if "public static string LogisticsRoute" not in text:
    text = text.replace("public static bool IsNavalBlockadeActive { get; set; } = false;", extra_props + "        public static bool IsNavalBlockadeActive { get; set; } = false;")

sync_needle = 'DialogueHelper.SetVariable("Zille_War_RomulusPlan", RomulusPlan.ToString());'
sync_extra = """DialogueHelper.SetVariable("Zille_War_RomulusPlan", RomulusPlan.ToString());
                DialogueHelper.SetVariable("Zille_Logistics_Route", LogisticsRoute);
                DialogueHelper.SetVariable("Zille_Rumburg_Munitions", IsRumburgMunitionsActive);
                DialogueHelper.SetVariable("Zille_Lespia_Intel", IsLespiaIntelActive);
                DialogueHelper.SetVariable("Zille_City_Captured", ZilleCityCaptured);
                DialogueHelper.SetVariable("Zille_Phase1_Cities", Phase1CitiesCaptured);
                DialogueHelper.SetVariable("Zille_Phase2_Cities", Phase2CitiesCaptured);"""

if "Zille_Logistics_Route" not in text:
    text = text.replace(sync_needle, sync_extra)

with open(path, 'w', encoding='utf-8') as f:
    f.write(text)

print("Updated ZilleCampaignState.cs successfully!")
