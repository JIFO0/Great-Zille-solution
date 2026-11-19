using System;
using System.Collections.Generic;
using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{
    public class EventSpawnerEntry
    {
        public string ConvIdOrName { get; set; }
        public string DisplayTitle { get; set; }
        public string Subtitle { get; set; }
        public string Category { get; set; } // "MODNEW", "MODEDIT", "RIZIA", "SORDLAND", "INNE"
        public string Tag { get; set; }      // "(MODNEW)", "(MODEDIT)", "(GRA)"
        public ConversationData FragmentData { get; set; }

        public string TagPrefix => Tag;

        public void Launch()
        {
            MelonLogger.Msg($"[EVENT SPAWNER] Launching conversation '{ConvIdOrName}' ({DisplayTitle})...");

            try
            {
                // Ensure custom dialogues are in masterDatabase
                ZilleDialogueSystem.EnsureAllConversationsRegistered();

                var tip = Panels.Instance?.TokenInteractionPanel ?? UnityEngine.Object.FindObjectOfType<TokenInteractionPanel>();
                if (tip != null) tip.Hide();

                var convPanel = Panels.Instance?.ConversationPanel ?? UnityEngine.Object.FindObjectOfType<ConversationPanel>();
                if (convPanel == null)
                {
                    var allPanels = Resources.FindObjectsOfTypeAll<ConversationPanel>();
                    if (allPanels != null && allPanels.Length > 0) convPanel = allPanels[0];
                }

                // If this is the war table operation
                if (ConvIdOrName == "WarFragment_Zille_1_1" || DisplayTitle.Contains("Operation: Righteous Sword"))
                {
                    WarOperationZilleManager.EnterZilleWarTheatre();
                    return;
                }

                // If this is the royal war council briefing, use the specialized launcher
                if (ConvIdOrName == "Turn_Zille_WarBriefing")
                {
                    WarOperationZilleManager.TriggerZilleWarBriefingConversation();
                    return;
                }

                // Find ConversationData if not cached
                ConversationData cd = FragmentData;
                if (cd == null)
                {
                    var list = EntityDataManager.AllConversationsData ?? EntityDataManager.ConversationsData;
                    if (list != null)
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            var c = list[i];
                            if (c != null && (c.NameInDatabase == ConvIdOrName || c.Id == ConvIdOrName))
                            {
                                cd = c;
                                break;
                            }
                        }
                    }
                }

                if (cd != null)
                {
                    string dialogueTitle = cd.ConversationProperties?.Dialogue;
                    if (string.IsNullOrEmpty(dialogueTitle)) dialogueTitle = ConvIdOrName;
                    if (WarOperationZilleManager.TriggerConversation(ConvIdOrName, dialogueTitle))
                    {
                        DialogueHelper.ShowAlert($"[Event] Started: {DisplayTitle}");
                        return;
                    }
                }

                // Fallback: Start directly via PixelCrushers DialogueManager without locking inputBlockerPanel
                Panels.Instance?.HideAllRightPanels();
                Panels.Instance?.HideAllCenterPanels();
                DialogueManager.StartConversation(ConvIdOrName);
                DialogueHelper.ShowAlert($"[Event] Started: {DisplayTitle}");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[EVENT SPAWNER] Failed to launch event '{ConvIdOrName}': {ex.Message}");
                DialogueHelper.ShowAlert($"[Error] Could not launch {ConvIdOrName}: {ex.Message}");
            }
        }
    }

    public static class ZilleEventSpawnerManager
    {
        public static readonly List<EventSpawnerEntry> AllCatalogEvents = new List<EventSpawnerEntry>();
        public static readonly List<EventSpawnerEntry> SpawnedInPorteDrazon = new List<EventSpawnerEntry>();

        private static bool _initialized = false;

        public static void EnsureInitialized()
        {
            if (_initialized && AllCatalogEvents.Count > 0) return;
            BuildCatalog();
            _initialized = true;
        }

        public static void RefreshCatalog()
        {
            AllCatalogEvents.Clear();
            BuildCatalog();
            _initialized = true;
        }

        private static void BuildCatalog()
        {
            MelonLogger.Msg("[EVENT SPAWNER] Building event spawner catalog...");

                        // 1. Mod events registered prominently at the top
            AddModNewEvent("Turn_Zille_WarPlanning", "Emergency Crown Council: The Fate of Zille", "Council Chamber, Palas Rezna", "MODNEW");
            AddModNewEvent("Turn_Zille_WarLogisticsDispute", "Supply Lines of Brenas: Azaro vs Sazon", "Ministry of War, Porte Drazon", "MODNEW");
            AddModNewEvent("Turn_Zille_WarBriefing", "A Royal Briefing Before the Invasion of Zille", "Council Chambers, Palas Rezna", "MODNEW");
            AddModNewEvent("Turn_Zille_WarBalconySpeech", "A Royal Proclamation of War", "Palas Rezna Balcony", "MODNEW");
            AddModNewEvent("Turn_Zille_MaveNortusHQ", "Frontline Headquarters: The Battle for Zille (Mave Nortus)", "Mayor's Hall, Mave Nortus", "MODNEW");
            AddModNewEvent("Turn_Zille_Op1AftermathCouncil", "Post-Operation I High Command Council", "War Room, Palas Rezna", "MODNEW");
            AddModNewEvent("Turn_Zille_DerdiaInvestigation", "Sabotage Inquiry: Derdia-Wehlen Border Briefing (Turn 4)", "Golden Guard Briefing Room", "MODNEW");
            AddModNewEvent("Turn_Zille_DerdiaTalks", "Derdian Mission: Faith, Oil and Mercenaries", "Derdian Mission, Porte Drazon", "MODNEW");
            AddModNewEvent("Turn_Zille_DerdiaStateVisit", "State Visit to Derdia: Audience with High Wiser Azmal (Turn 6)", "Silver Garrison, Naeal", "MODNEW");
            AddModNewEvent("Turn_Zille_LespiaTalks", "Lespian Diplomatic Hotline: Air Recon and Munitions", "Foreign Ministry Communications Room", "MODNEW");
            AddModNewEvent("Turn_Zille_RumburgTalks", "Imperial Telegram from Thornbourgh: Rumburgian Munitions", "Imperial Diplomatic Cabinet", "MODNEW");
            AddModNewEvent("Turn_Zille_WarPreNegotiationsBriefing", "Pre-Negotiations Briefing & Foreign Hotlines", "War Room & Communications Cabinet", "MODNEW");
            AddModNewEvent("Turn_Zille_WarSmolakFinalParley", "Frontline Parley with Wiktor Smolak", "Neutral Military Pavilion, Zille Border", "MODNEW");
            AddModNewEvent("Turn_Zille_WarPeaceTreaty", "The Treaty of Zille", "Treaty Pavilion", "MODNEW");
            AddModNewEvent("Turn_Zille_HomeFrontCrisis", "Wartime Home Front: Energy & AN Pressure", "Cabinet Room, Palas Rezna", "MODNEW");
            AddModNewEvent("Turn_Zille_ZilleLiberation", "Homecoming in Zille City: The Harbor Quarter", "Zille City Harbor", "MODNEW");


            // 3. Scan EntityDataManager.AllConversationsData
            try
            {
                var convList = EntityDataManager.AllConversationsData ?? EntityDataManager.ConversationsData;
                if (convList != null)
                {
                    for (int i = 0; i < convList.Count; i++)
                    {
                        var cd = convList[i];
                        if (cd == null) continue;

                        string dbName = cd.NameInDatabase ?? cd.Id ?? "";
                        if (string.IsNullOrEmpty(dbName)) continue;

                        // Check if already in catalog
                        var existing = AllCatalogEvents.Find(e => e.ConvIdOrName == dbName);
                        if (existing != null)
                        {
                            existing.FragmentData = cd;
                            continue;
                        }

                        string title = cd.ConversationProperties?.Title;
                        string sub = cd.ConversationProperties?.Subtitle;
                        if (string.IsNullOrEmpty(title)) title = dbName;
                        if (string.IsNullOrEmpty(sub)) sub = cd.Path ?? "Suzerain Conversation";

                        string category = "RIZIA";
                        if (dbName.IndexOf("Sord", StringComparison.OrdinalIgnoreCase) >= 0 || (cd.Path != null && cd.Path.IndexOf("Sordland", StringComparison.OrdinalIgnoreCase) >= 0))
                        {
                            category = "SORDLAND";
                        }

                        AllCatalogEvents.Add(new EventSpawnerEntry
                        {
                            ConvIdOrName = dbName,
                            DisplayTitle = title,
                            Subtitle = sub,
                            Category = category,
                            Tag = "(GRA)",
                            FragmentData = cd
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[EVENT SPAWNER] EntityDataManager scan warning: {ex.Message}");
            }

            // 4. Scan DialogueManager.masterDatabase
            try
            {
                var db = DialogueManager.masterDatabase;
                if (db != null && db.conversations != null)
                {
                    for (int i = 0; i < db.conversations.Count; i++)
                    {
                        var c = db.conversations[i];
                        if (c == null) continue;

                        string title = c.Title ?? "";
                        if (string.IsNullOrEmpty(title)) continue;

                        var existing = AllCatalogEvents.Find(e => e.ConvIdOrName == title);
                        if (existing != null) continue;

                        string category = "RIZIA";
                        if (title.IndexOf("Sord", StringComparison.OrdinalIgnoreCase) >= 0) category = "SORDLAND";

                        AllCatalogEvents.Add(new EventSpawnerEntry
                        {
                            ConvIdOrName = title,
                            DisplayTitle = title,
                            Subtitle = string.IsNullOrEmpty(c.Description) ? "PixelCrushers Conversation" : c.Description,
                            Category = category,
                            Tag = "(GRA)",
                            FragmentData = null
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[EVENT SPAWNER] MasterDatabase scan warning: {ex.Message}");
            }

            // Porte Drazon briefing is managed directly by DialogueInjectionPatches

            MelonLogger.Msg($"[EVENT SPAWNER] Catalog built: {AllCatalogEvents.Count} total events available ({SpawnedInPorteDrazon.Count} spawned in Porte Drazon).");
        }

        private static void AddModNewEvent(string convId, string title, string subtitle, string category)
        {
            AllCatalogEvents.Add(new EventSpawnerEntry
            {
                ConvIdOrName = convId,
                DisplayTitle = title,
                Subtitle = subtitle,
                Category = category,
                Tag = "(MODNEW)",
                FragmentData = null
            });
        }

        private static void AddModEditEvent(string convId, string title, string subtitle, string category)
        {
            AllCatalogEvents.Add(new EventSpawnerEntry
            {
                ConvIdOrName = convId,
                DisplayTitle = title,
                Subtitle = subtitle,
                Category = category,
                Tag = "(MODEDIT)",
                FragmentData = null
            });
        }

        public static bool IsEventSpawned(EventSpawnerEntry entry)
        {
            if (entry == null) return false;
            return SpawnedInPorteDrazon.Exists(e => e.ConvIdOrName == entry.ConvIdOrName);
        }

        public static void ToggleSpawn(EventSpawnerEntry entry)
        {
            if (entry == null) return;
            if (IsEventSpawned(entry))
            {
                SpawnedInPorteDrazon.RemoveAll(e => e.ConvIdOrName == entry.ConvIdOrName);
                DialogueHelper.ShowAlert($"[Porte Drazon] Removed event: {entry.DisplayTitle}");
            }
            else
            {
                SpawnedInPorteDrazon.Add(entry);
                DialogueHelper.ShowAlert($"[Porte Drazon] Spawned event: {entry.DisplayTitle}");
            }
        }

        public static void ClearAllSpawned()
        {
            SpawnedInPorteDrazon.Clear();
            DialogueHelper.ShowAlert("[Porte Drazon] Cleared all spawned events.");
        }
    }

    public class ZilleEventSpawnerUI
    {
        public bool IsOpen { get; set; } = false;

        private Rect _windowRect = new Rect(40f, 40f, 920f, 680f);
        private string _searchFilter = "";
        private int _currentTab = 0; // 0: Wszystkie, 1: (MODNEW), 2: (MODEDIT), 3: Rizia, 4: W Porte Drazon
        private Vector2 _scrollPos = Vector2.zero;

        private readonly string[] _tabLabels = new string[]
        {
            "All",
            "★ (MODNEW)",
            "✎ (MODEDIT)",
            "Rizia",
            "Spawned in Porte Drazon"
        };

        public void DrawGUI()
        {
            if (!IsOpen) return;

            ZilleEventSpawnerManager.EnsureInitialized();

            _windowRect = GUI.Window(
                9903,
                _windowRect,
                (GUI.WindowFunction)DrawWindowContent,
                "<b>[GREAT ZILLE] Event Spawner & Scene Browser | JIFO (jifo.dev)</b>"
            );
        }

        private void DrawWindowContent(int id)
        {
            float winW = _windowRect.width;
            float winH = _windowRect.height;
            float pad = 12f;
            float y = 28f;

            // Header info & Porte Drazon quick travel
            GUI.Label(new Rect(pad, y, winW - 200f, 22f), "Select any event or scene to <b>spawn it in Porte Drazon</b> or <b>launch immediately</b>:");
            
            GUI.color = new Color(0.3f, 0.85f, 1f);
            if (GUI.Button(new Rect(winW - pad - 190f, y, 190f, 26f), ">> Go to Porte Drazon <<"))
            {
                WarOperationZilleManager.FocusPorteDrazonBriefing();
            }
            GUI.color = Color.white;
            y += 30f;

            // Search Filter & Clear button
            GUI.Label(new Rect(pad, y + 2f, 95f, 24f), "<b>Search event:</b>");
            _searchFilter = GUI.TextField(new Rect(pad + 100f, y, winW - pad - 240f - 100f, 24f), _searchFilter);
            if (GUI.Button(new Rect(winW - pad - 230f, y, 90f, 24f), "Clear"))
            {
                _searchFilter = "";
            }
            if (GUI.Button(new Rect(winW - pad - 130f, y, 130f, 24f), "Refresh"))
            {
                ZilleEventSpawnerManager.RefreshCatalog();
            }
            y += 30f;

            // Tabs / Filters
            float tabW = (winW - pad * 2f) / _tabLabels.Length;
            for (int i = 0; i < _tabLabels.Length; i++)
            {
                bool isSelected = (_currentTab == i);
                if (i == 1) GUI.color = isSelected ? new Color(1f, 0.85f, 0.2f) : new Color(0.9f, 0.75f, 0.2f);
                else if (i == 2) GUI.color = isSelected ? new Color(0.4f, 0.95f, 0.9f) : new Color(0.3f, 0.7f, 0.7f);
                else if (i == 4) GUI.color = isSelected ? new Color(0.4f, 1f, 0.4f) : new Color(0.3f, 0.75f, 0.3f);
                else GUI.color = isSelected ? Color.white : new Color(0.7f, 0.7f, 0.7f);

                string label = _tabLabels[i];
                if (i == 4) label += $" ({ZilleEventSpawnerManager.SpawnedInPorteDrazon.Count})";

                if (GUI.Button(new Rect(pad + i * tabW, y, tabW - 4f, 28f), label))
                {
                    _currentTab = i;
                }
            }
            GUI.color = Color.white;
            y += 34f;

            // Filter the events
            string search = (_searchFilter ?? "").Trim().ToLowerInvariant();
            var matches = new List<EventSpawnerEntry>();
            var all = ZilleEventSpawnerManager.AllCatalogEvents;

            for (int i = 0; i < all.Count; i++)
            {
                var entry = all[i];
                if (entry == null) continue;

                // Tab Filter
                if (_currentTab == 1 && entry.Tag != "(MODNEW)") continue;
                if (_currentTab == 2 && entry.Tag != "(MODEDIT)") continue;
                if (_currentTab == 3 && entry.Category != "RIZIA") continue;
                if (_currentTab == 4 && !ZilleEventSpawnerManager.IsEventSpawned(entry)) continue;

                // Search Filter
                if (!string.IsNullOrEmpty(search))
                {
                    string blob = (entry.ConvIdOrName + " " + entry.DisplayTitle + " " + entry.Subtitle + " " + entry.Tag).ToLowerInvariant();
                    if (!blob.Contains(search)) continue;
                }

                matches.Add(entry);
            }

            // Results count bar
            GUI.Label(new Rect(pad, y, 400f, 20f), $"<color=#90cdf4>Found: <b>{matches.Count}</b> events</color> | Spawned in capital: <b>{ZilleEventSpawnerManager.SpawnedInPorteDrazon.Count}</b>");
            if (ZilleEventSpawnerManager.SpawnedInPorteDrazon.Count > 0)
            {
                GUI.color = new Color(1f, 0.6f, 0.6f);
                if (GUI.Button(new Rect(winW - pad - 210f, y - 2f, 210f, 22f), "[Remove spawned from capital]"))
                {
                    ZilleEventSpawnerManager.ClearAllSpawned();
                }
                GUI.color = Color.white;
            }
            y += 24f;

            // Scroll View for items
            float viewH = winH - y - 48f;
            float rowH = 54f;
            float contentH = Mathf.Max(viewH, matches.Count * (rowH + 4f));
            Rect viewRect = new Rect(pad, y, winW - pad * 2f, viewH);
            Rect scrollContentRect = new Rect(0, 0, winW - pad * 2f - 20f, contentH);

            _scrollPos = GUI.BeginScrollView(viewRect, _scrollPos, scrollContentRect);

            float rowY = 0f;
            float rowW = scrollContentRect.width;

            for (int i = 0; i < matches.Count; i++)
            {
                var item = matches[i];
                bool isSpawned = ZilleEventSpawnerManager.IsEventSpawned(item);

                // Entry background box
                if (item.Tag == "(MODNEW)") GUI.color = new Color(0.2f, 0.25f, 0.35f, 0.9f);
                else if (item.Tag == "(MODEDIT)") GUI.color = new Color(0.15f, 0.3f, 0.3f, 0.9f);
                else if (isSpawned) GUI.color = new Color(0.18f, 0.32f, 0.18f, 0.9f);
                else GUI.color = new Color(0.18f, 0.18f, 0.22f, 0.85f);

                GUI.Box(new Rect(0, rowY, rowW, rowH), GUIContent.none);
                GUI.color = Color.white;

                // Tag badge
                float badgeW = 90f;
                if (item.Tag == "(MODNEW)")
                {
                    GUI.color = new Color(1f, 0.85f, 0.2f);
                    GUI.Label(new Rect(8f, rowY + 6f, badgeW, 20f), "<b>[★ MODNEW]</b>");
                }
                else if (item.Tag == "(MODEDIT)")
                {
                    GUI.color = new Color(0.4f, 0.95f, 1f);
                    GUI.Label(new Rect(8f, rowY + 6f, badgeW, 20f), "<b>[✎ MODEDIT]</b>");
                }
                else
                {
                    GUI.color = new Color(0.7f, 0.7f, 0.7f);
                    GUI.Label(new Rect(8f, rowY + 6f, badgeW, 20f), "[GRA]");
                }
                GUI.color = Color.white;

                // Title and Subtitle
                float textX = badgeW + 12f;
                float textW = rowW - textX - 340f;
                GUI.Label(new Rect(textX, rowY + 5f, textW, 22f), $"<b>{item.DisplayTitle}</b> <size=11><color=#888888>({item.ConvIdOrName})</color></size>");
                GUI.Label(new Rect(textX, rowY + 26f, textW, 22f), $"<size=11><color=#cccccc>{item.Subtitle}</color></size>");

                // Action Buttons
                float btnX = rowW - 330f;

                // Button 1: Spawn in Porte Drazon toggle
                if (isSpawned)
                {
                    GUI.color = new Color(0.4f, 1f, 0.5f);
                    if (GUI.Button(new Rect(btnX, rowY + 11f, 160f, 32f), "✓ IN PORTE DRAZON (Remove)"))
                    {
                        ZilleEventSpawnerManager.ToggleSpawn(item);
                    }
                }
                else
                {
                    GUI.color = new Color(0.9f, 0.9f, 0.9f);
                    if (GUI.Button(new Rect(btnX, rowY + 11f, 160f, 32f), "+ Spawn in Porte Drazon"))
                    {
                        ZilleEventSpawnerManager.ToggleSpawn(item);
                    }
                }
                GUI.color = Color.white;

                // Button 2: Launch immediately
                GUI.color = new Color(1f, 0.85f, 0.3f);
                if (GUI.Button(new Rect(btnX + 168f, rowY + 11f, 150f, 32f), "▶ LAUNCH NOW"))
                {
                    item.Launch();
                }
                GUI.color = Color.white;

                rowY += rowH + 4f;
            }

            GUI.EndScrollView();

            // Bottom bar
            float bottomY = winH - 38f;
            GUI.Label(new Rect(pad, bottomY + 4f, 500f, 24f), "<size=11><color=#888888>All added events will appear immediately in the Porte Drazon interaction window on the map.</color></size>");

            if (GUI.Button(new Rect(winW - pad - 120f, bottomY, 120f, 28f), "Close (F6)"))
            {
                IsOpen = false;
            }

            GUI.DragWindow(new Rect(0, 0, winW - 130f, 26f));
        }
    }
}
