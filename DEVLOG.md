# Project: Great Zille Solution — Development Log

## Overview
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
