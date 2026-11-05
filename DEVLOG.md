# Project: Great Zille Solution — Development Log

## Overview
- **Author:** JIFO ([jifo.dev](https://jifo.dev))
- **Game:** Suzerain (Torpor Games)
- **Engine:** Unity 6 (`6000.3.9f1 x64`, IL2CPP)
- **Goal:** Modular injection of a tactical war campaign and narrative arc against Wehlen for the recovery of Zille.
- **Repository:** `C:\Projects\Great Zille solution`

---

## Log Entries

### [2026-10-21] Initial Reconnaissance & Workspace Setup
- Audited Suzerain directory (`H:\SteamLibrary\steamapps\common\Suzerain`).
- Compiled Unity 6 Il2CppDumper fork under .NET 8.0.
- Extracted dumps and generated vanilla/modded launcher scripts.

### [2026-10-21] Runtime Bugfix (TypeLoadException) & Geopolitics (v0.2.0)
- Resolved MelonLoader TypeLoadException by switching from legacy dummy stubs to `MelonLoader\Il2CppAssemblies`.
- Eliminated all reflection scanning warnings (`AccessTools.GetTypesFromAssembly`) through direct typed bindings.

### [2026-10-21] Game Binary Chronology Alignment & Tactical Framework (v0.3.0)
- **Extracted 521 dialogue titles directly from Suzerain game binary:**
  - Dumped and analyzed `database_assets_all_...` using UnityPy.
  - Corrected erroneous turn chronology: verified that Zille Visit and Friendship Day occur in **Turn 2** (`Rizia/Turn 2/FPnT_ZilleVisit`), preceded by the King's Council diplomacy review (`Rizia/Turn 2/FPnT_DiplomacyBriefing`).
  - Aligned Turn 1 King's Council meetings (`Rizia/Turn 1/SnO_SecurityMilitaryMeeting` & `EnT_CouncilBriefing`).
  - Aligned Turn 3 post-bombing security debrief (`Rizia/Turn 3/SnO_ZilleSecurityDebrief`).
- **Added Reckless Early War Trigger ("Głupia opcja"):**
  - In Turn 3 post-bombing debrief, Romus can immediately launch an unprepared, reckless invasion.
  - Results in instant catastrophic defeat: Third/Fourth Corps encircled, Brenas province ceded to Wehlen, Queen Mother Estela captured and killed.
- **Added In-Game HUD Watermark & Debug Test Suite:**
  - Implemented `OnGUI()` watermark in top-right corner: `[ Great Zille Solution v0.3.0 | ACTIVE (F9: Menu) ]`.
  - Added F9 interactive debug window to trigger and test Turn 3 catastrophe, Turn 8 Plan Alpha (Frontal), Turn 8 Plan Beta (Munat flank), and victory simulations.
- **Documented Tactical War Map Architecture for Zille:**
  - Specified the 4 core cities: **Zille** (capital, west), **Nanta** (east), **Wiktrany** (central logistics hub), and **Munat** (deepwater port, north).
  - Clarified that tactical hex tiles and enemy token placements are currently unspawned and represent the next development phase.
- Built clean binary `GreatZilleSolution.dll` (0 errors, 0 warnings) and deployed to `Suzerain/Mods/`.

### [2026-10-22] Zille Tactical Map Integration & Interactive Tile Placer (v0.4.0)
- **Technical Evaluation of Imported Assets:**
  - Audited `C:\Users\iwo\Downloads\Mapa` (`T_Map_Zille_01.png` - `06.png`): confirmed 4096x4096 RGBA PNG format matching 1:1 the multi-layer texture specifications of Suzerain's Pales War Map (`T_Map_Pales_01.png` - `06.png`).
  - Audited `C:\Users\iwo\Downloads\regiony` (`Frame 41.png` - `45.png`): confirmed 512x512 RGBA PNG with alpha transparency, exactly matching `PalesTile_*.png` tile definitions.
  - Automatically generated downscaled 1024x1024 preview textures alongside 4096 full versions for smooth IMGUI rendering.
  - Deployed assets to both `c:\Projects\Great Zille solution\assets\` and `H:\SteamLibrary\steamapps\common\Suzerain\Mods\GreatZilleAssets\`.
- **In-Engine Tile & Adjacency System (`ZilleMapLayoutManager` & `ZilleTileModel`):**
  - Implemented dynamic runtime loading using `UnityEngine.ImageConversionModule`.
  - Defined tile serialization structure: normalized coordinates, dimensions, allegiance (`Rizia`, `Wehlen`, `Contested`), tactical flags (Fortifications, Port, Supply Hub, Airfield), and adjacency links (`AdjacentIds`).
  - Created bidirectional JSON serialization (`zille_tiles_layout.json`) with auto-sync between project and game folders.
- **In-Game Interactive Map & Tile Editor (`ZilleWarMapEditorUI`):**
  - Added full visual editor window (`F10`) with map canvas and inspector.
  - Real-time mouse dragging for moving tiles across the map canvas.
  - Visual adjacency link rendering (tactical connecting lines drawn between linked regions).
  - One-click neighbor toggle checklist to wire or unwire frontline connections.

### [2026-10-22] Runtime Unstripping Hotfix & Bottom-Left Dock Repositioning (v0.4.1)
- **Resolved `System.NotSupportedException: Method unstripping failed`:**
  - Audited binary against Unity IL2CPP stripping: discovered `GUILayout.Space(Single pixels)` and several `GUILayout` layout passes are stripped in Suzerain's binary.
  - Refactored entire UI pipeline (`Core.cs` and `ZilleWarMapEditorUI.cs`) from stripped `GUILayout` methods to rock-solid, pure native `GUI.*(Rect ...)` primitives (`GUI.Box`, `GUI.Button`, `GUI.Label`, `GUI.TextField`, `GUI.Toggle`, `GUI.HorizontalSlider`, `GUI.DrawTexture`, `GUI.BeginScrollView`).
  - Wrapped `OnGUI()` in global exception guard to prevent rendering pipeline interruptions.
- **Dock Repositioning to Bottom-Left Corner:**
  - Relocated the dock to the bottom-left corner (`Screen.height - panelHeight - 12`), preventing overlap with game dialogues, council notifications, and mid-screen UI.
  - Cleaned up click bounding boxes and added prominent active state colors.
- Built clean binary `GreatZilleSolution.dll` (0 errors, 0 warnings) and deployed to `Suzerain/Mods/`.

### [2026-10-22] Native 3D War Map Engine Injection & Lazy GPU Texture Pipeline (v0.4.2)
- **Resolved Endless "Ładowanie mapy Zille..." & Missing Region PNGs:**
  - Identified root cause: `ImageConversion.LoadImage` and `new Texture2D()` were originally called inside `OnInitializeMelon()`, which executes before Unity native graphics device (`GfxDeviceD3D11`) initialization. Native D3D11 returned null texture handles without throwing exceptions.
  - Re-architected `ZilleMapLayoutManager` to load textures lazily (`EnsureTexturesLoaded()`) upon first scene load and first IMGUI render frame when DirectX is active.
  - Added robust validation, diagnostic dimension logging, and a procedural tactical fallback background.
  - Region tiles now render with distinct faction backing boxes and colored tactical borders.
- **Native 3D War Map Integration in Suzerain (`WarOperationZilleManager`):**
  - Hooked directly into `Il2Cpp.MapManager` and `Il2Cpp.WarFlowManager`.
  - Added `LaunchNativeWarMap(operationName)`: executes `MapManager.LoadMap(MapConfiguration.MapType.War)` and `WarFlowManager.SetupDebugWar("Operation_1" / "Operation_2")`.
  - Injected Zille high-resolution map texture onto `PalesWarMapBackground`'s 3D mesh material.
  - Added return mechanism `ReturnToCivilianMap()` switching back to `MapConfiguration.MapType.Base`.
- **UI Quick-Action Controls:**
  - Added gold button `[🚀 ODPAL WOJNĘ (3D MAP)]` directly in the Bottom-Left Dock and in the `F9` menu.
  - Added `[🏳️ Mapa cywilna]` return button.
- Built clean binary `GreatZilleSolution.dll` (0 errors, 0 warnings) and deployed to `Suzerain/Mods/`.

### [2026-10-22] Dedicated War Operation & Dialogue System Breakthrough (v0.4.6)
- **Resolved Blank Dialogue Canvas & Non-blocking Civilian Tokens:**
  - **Reverse-engineered `ConversationModel.get_hasValidEntry()` (`0x66F220`):** `StartConversation` aborts immediately (`jmp 0x63e32d`) if `npcResponses` and `pcResponses` on `firstState` are empty.
  - **Root Cause 1 (`fields` population):** `DialogueEntry` text resolution in Suzerain evaluates `fields` (`Dialogue Text`, `en`, `Menu Text`, `Sequence`, `Actor`, `Conversant`). Entries initialized with empty `fields` returned empty strings, causing `ConversationHandler.OnConversationLine` (`0x99E87A`) to skip text rendering entirely.
  - **Root Cause 2 (Link Priority):** In C#, `new Link()` defaulted `priority = ConditionPriority.Low` (0). Vanilla Suzerain conversations strictly require `ConditionPriority.Normal` (2).
  - **Root Cause 3 (Entry 0 pass-through):** Corrected `entry0.isGroup = false`, `entry0.Sequence = "Continue();"`, and outgoing link to Entry 1 with `ConditionPriority.Normal`.
  - **Integrated Story Fragment Lifecycle:** Activated `InputBlockerPanel` via `GameFlowManager.OnStoryFragmentStart()` to prevent civilian token clicks during dialogue, with clean lifecycle closure via `GameFlowManager.FinishStoryFragment`.
- **Created Dedicated Native War Operation ("Operation: Righteous Sword - Phase I"):**
  - **Eliminated Golden Shield Phase IV Dependency:** Separated Zille completely from vanilla `Operation_1`. Created dedicated `OperationData` (`Operation_Zille_1`) with title `"Operation: Righteous Sword"` and phase `["WarFragment_Zille_1_1"]`.
  - **Cloned & Configured Scene `WarOperation`:** Instantiated `"Operation_Zille_1"` under `"Pales Operations Container"`, cloned its `WarOperationData` ScriptableObject, and registered `zilleWarOp` in `Managers.Instance.Operations`.
  - **Isolated Tactical Tiles (No Excess Pales Grid):** Set `includedTileNames = ["tile_zille", "tile_munat", "tile_wiktrany", "tile_nanta", "tile_brenas"]`. `WarTileManager.SetupCoroutine` enables only these 5 tiles and disables the remaining 95 tiles automatically.
  - **Native City & Garrison Token Deployment:**
    - Player City Token spawned on `tile_brenas` (Rizian staging base) using native City `WarUnitTypeData`.
    - Enemy City Tokens spawned on `tile_zille`, `tile_munat`, `tile_wiktrany`, and `tile_nanta`.
    - Wehlen Garrisons (Infantry and Tanks) deployed on `tile_wiktrany` and `tile_zille`.
  - **Harmonized Harmony Hook:** Added prefix on `WarFlowManager.SetupWarFragment(WarFragmentData)` to guarantee theatre synchronization whenever `WarFragment_Zille_1_1` is launched.
- Built clean binary `GreatZilleSolution.dll` (0 errors, 0 warnings) and auto-deployed to `H:\SteamLibrary\steamapps\common\Suzerain\Mods\GreatZilleSolution.dll`.

### [2026-10-22] Dialogue Engine Articy ID Discovery & War Theatre Performance Overhaul (v0.4.7)
- **Resolved Blank Dialogue Canvas & Progression Lock (Porte Drazon War Briefing):**
  - **Reverse-engineered `ConversationHandler.OnConversationLine` (`0x99E84D` - `0x99E965` in `GameAssembly.dll`):**
    Disassembled native execution stream. At `0x18099e95d`, `ConversationHandler` executes `List<Field>.Find` with lambda `<OnConversationLine>b__28_0` checking `f.title == "Articy Id"`. At `0x18099e965`, it executes `test rax, rax; je 0x18099f04e`. If `"Articy Id"` is null/missing, it jumps straight to the abort exit, completely skipping line creation, speaker portraits, text rendering, and continue buttons!
  - **Injected Mandatory Articy Fields:** Added `Field("Articy Id", $"0x0100005A_Zille_{entryId}", FieldType.Text)` to all entries including Entry 0.
  - **Fixed Entry 0 Sequence Command:** Aligned with vanilla standard `Continue()` (without semicolon).
  - **Prevented Token Interaction Bleed-Through:** Enabled `convPanel.inputBlockerPanel` and disabled minimization (`convPanel.isMinimizable = false`) while conversation is active.
- **Eliminated Severe War Transition Freeze & Infinite Allocation Loop:**
  - **Root Cause Identified in `UpdateWarTheatreState()`:** Line was calling `SetupCustomZilleOperation()` 60 times a second inside `OnUpdate()`. Every frame was executing `ScriptableObject.Instantiate(palesWarOp.warOperationData)` and allocating dozens of Il2Cpp lists and token objects.
  - **Engine Guard Implementation:** Added `_customOperationConfigured` guard in `SetupCustomZilleOperation()`.
  - **Decoupled from Per-Frame Update:** Removed operation configuration from `UpdateWarTheatreState()`. Operations now configure strictly once on theatre launch.
  - **Reliable Scene Transition:** Explicitly invoked `Managers.Instance.MapManager.LoadMap(MapConfiguration.MapType.War)` in `EnterZilleWarTheatre()`.
- **Eliminated Erroneous Turn 2 Pales War Pawn:**
  - Removed erroneous `palesWarTemplate.SetActive(true)`. The vanilla Pales template remains strictly inactive in Turn 2, and only the separate cloned `InvasionOfZille Event Variant` is activated.
- **Resolved Stale Tooltip & Info Card on Zille War Pawn:**
  - Added Harmony hook on `TokenNamePanel.Setup(Token token)`: dynamically sets `tokenNameText = "Invasion of Zille"`.
  - In `TokenInteractionPanelSetupPostfix`: sets `titleText = "Invasion of Zille"` and `subtitleText = "Military Operation"`.
  - Directly assigned `tok.tokenData = zilleMtd` on spawn.
- Built clean binary `GreatZilleSolution.dll` (0 errors, 0 warnings) and auto-deployed to `H:\SteamLibrary\steamapps\common\Suzerain\Mods\GreatZilleSolution.dll`.

### [2026-10-23] Authentic Suzerain English War Council, _Diffuse Shader Fix & Native WarFlowManager Pipeline (v0.4.8)
- **Authentic Suzerain-Style Dynamic English War Council (`EnsureWarCouncilConversationRegistered`):**
  - Rewrote the entire Porte Drazon war briefing in **English** in authentic Suzerain style: short consecutive lines spoken by `Narrator` (ID 10), `Player_Romus` (ID 95), `Hugo Toras` (ID 68), `Lucita Azaro` (ID 73), `Titus Gordion` (ID 81), and `Laurento Esquibel` (ID 70).
  - **Dynamic Savegame State Evaluation (No Raw Numbers):**
    - Evaluates `RiziaDLC.Resources_Budget` and `RiziaDLC.Resources_Energy` into natural qualitative tiers (abundant/overflowing reserves, acceptable operational margins, or strained/depleted treasury) without ever citing artificial numbers like `+5`.
    - Evaluates `RiziaDLC.Resources_Manpower`, `RiziaDLC.Resources_MilitaryEquipment`, `RiziaDLC.PalesWar_Preparation_WarDeclared` (two-front war warning), `RiziaDLC.Zille_SuOmina_Funded` / `RiziaDLC.Zille_Resistance_Strength`, and Lespia diplomatic posture (`RiziaDLC.Diplomacy_Lespia_Allied` / `RiziaDLC.Lespia_Cooperation`).
    - Evaluates **Lucita Azaro Romance & Marriage** (`RiziaDLC.Lucita_Married`, `RiziaDLC.Lucita_Marriage_Happened`, `RiziaDLC.Relations_Lucita_Together`, `RiziaDLC.Lucita_RomanceHappened`, `RiziaDLC.Relations_Lucita_Romance`), adapting her greeting (`"My King—and my husband"` vs. `"Your Majesty"`), narrative descriptions, and final battle vows.
  - **Interactive Strategic Discussion Hub:**
    - Allows Romus to set his initial royal posture, question individual advisors on 4 distinct axes (Wehlen's defensive grid & terrain, economic & energy stability, Lespia & AN diplomatic fallout, and Su Omina & Queen Mother Estela's childhood home in Zille), voice his own strategic opinion after each topic, and observe advisor reactions before authorizing **Plan Alpha**, **Plan Beta**, or **Postponing**.
- **Decoupled Post-Briefing Flow (Spawn Zille Event Pawn Instead of Immediate Map Transition):**
  - Finishing the war council in Porte Drazon and authorizing Plan Alpha or Plan Beta no longer forces an immediate camera jump into the 3D War Map.
  - Instead, concluding the briefing sets `PendingZilleTokenSpawnAfterBriefing = true` and spawns only the **Zille War Event pawn (`InvasionOfZille Event Variant`)** next to Zille when the dialogue panel closes.
  - The 3D War Theatre launches only when the player clicks the Zille War Event pawn and selects **"Operation: Righteous Sword - Phase I"**.
- **Resolved "Black Box" on War Map (`_Diffuse` Shader Property & `Pales Map_01..06` Grid):**
  - **Root Cause Identified via Bundle Inspection (`UnityPy`):** Torpor's custom map shaders (`MA_MapPales_01`..`06` on `Pales Map_01 `..`06` inside `Map_Rizia_PalesWar` and `MA_MapWorldBorder` on `PalesWarMapBackground`) use the texture property **`_Diffuse`** (not `_MainTex` or `_BaseMap`) and on `MA_MapWorldBorder` had `_AO_Multiplier = 0.0` and `_AlphaClip = 1.0`. Furthermore, `MA_PalesTile` on `WarTile`s uses **`_Tile_Texture`**.
  - Updated `ApplyWarTableTexture()` and `ApplyTextureToMaterial()` to assign `T_Map_Zille_01`..`06` directly to `_Diffuse` on `Pales Map_01`..`06`, assign the composite Zille map to `_Diffuse` on `PalesWarMapBackground` (with `_AO_Multiplier = 1f`, `_AlphaClip = 0f`, `_Brightness_Multiplier = 1.15f`), and assign region textures to `_Tile_Texture` on `WarTile`s.
- **Full Native War Operation Pipeline (`WarFlowManager.<SetupWarFragmentCoroutine>d__65`):**
  - Disassembled `EntityDataManager.get_OperationData` (`0x180856980`): discovered it dynamically filters the private static backing field `EntityDataManager.operationData` (`+0x258`) using `EntityDataManager.IsDataAvailable(item.AppBundleProperties)`.
  - Injected `Operation_Zille_1`, `MapToken_Zille_War`, `WarFragment_Zille_1_1`, and `WarCouncil_Zille_Briefing` directly into `EntityDataManager`'s backing lists with `AppBundleProperties.StoryPacks = ["StoryPack_Rizia"]`, non-null string properties, and initialized `SaveData.warSaveData` so `WarFlowManager.SetupWarFragment(wfd)` executes natively from start to finish (hiding civilian tokens, switching `MapManager` to `MapType.War`, starting war music, and opening `WarDeploymentPanel`).
- Built clean binary `GreatZilleSolution.dll` (0 errors, 0 warnings) and deployed to `H:\SteamLibrary\steamapps\common\Suzerain\Mods\GreatZilleSolution.dll`.

### [2026-11-05] Complete Lore-Authentic Dialogue Overhaul & 6 Core Zille Scenes (v0.5.0)
- **Eliminated Looped & Out-of-Character War Council:**
  - Removed old repeating dialogue loop where Hugo Toras spoke inappropriately about treasury and gold reserves.
  - Hugo Toras restored to canonical role: Grand Vizier, Toras patriarch, royal succession, dynastic prestige, and monarchist legitimacy.
  - Elena Werner introduced in her authentic minister voice: assessing the Crown Treasury, fuel burn rate, inflation, and logistical strain.
  - Lucita Azaro focused on military dispositions, terrain, Valdez's four brigades, and Plan Alpha (Frontal) vs Plan Beta (Munat flank), with full romance/marriage reactivity.
  - Laurento Esquibel focused on superpowers and containment: realistic limits of CSP and ATO intervention.
  - Titus Gordion focused on internal security, Su Omina/ATA networks, and protection of Queen Mother Estela's childhood estate.
  - Replaced cyclical loop with a clean linear-to-inquiry progression that seamlessly transitions to operational doctrine authorization.
- **Implemented Modular Master Narrative Engine (`ZilleDialogueSystem.cs`):**
  - Registered and built all 6 master expansion scenes into PixelCrushers `masterDatabase`:
    1. `Turn_Zille_WarBriefing` (ID 9988): Overhauled War Council Briefing.
    2. `Turn_Zille_WarBalconySpeech` (ID 9989): Palace Balcony Proclamation of War (Revanchist, Liberating, or Legalist).
    3. `Turn_Zille_WarLogisticsDispute` (ID 9990): House Azaro vs House Sazon logistics clash in Brenas.
    4. `Turn_Zille_WarPreNegotiationsBriefing` (ID 9991): Council debrief + 3 Encrypted Hotline calls (Alvarez, Hegel, Beatrice) with strict lore adherence (no foreign boots on Wehlen soil; intelligence, AN veto, and de-escalation diplomacy only).
    5. `Turn_Zille_WarSmolakFinalParley` (ID 9992): Tense frontline tent parley with Wiktor Smolak (tea, smokes, cynical tyrant persona).
    6. `Turn_Zille_WarPeaceTreaty` (ID 9993): The 5 comprehensive war endings (Total Fiasco, Tactical Defeat, Bloody Stalemate, Decisive Victory, Overwhelming Triumph).
  - Injected all required Suzerain fields (`Title`, `Actor`, `Conversant`, `Dialogue Text`, `en`, `Menu Text`, `Sequence`, `Articy Id`) with `ConditionPriority.Normal` to guarantee native engine rendering.
  - Integrated scene metadata into `EntityDataManager.AllConversationsData`.
- **Surgical Injections into Vanilla Dialogue Trees:**
  - Injected options into Turn 1 (`EnT_CouncilBriefing`, `SnO_SecurityMilitaryMeeting`), Turn 2 (`FPnT_DiplomacyBriefing`, `FPnT_ZilleVisit`), Turn 3 (`SnO_ZilleSecurityDebrief`), Turn 4 (`FPnT_AlvarezCall`, `A_CouncilTalkAboutPales`), and Turn 8 (`FPnT_ZilleNegotiations`).
