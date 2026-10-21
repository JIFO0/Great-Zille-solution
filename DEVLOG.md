# Project: Great Zille Solution — Development Log

## Overview
- **Game:** Suzerain (Torpor Games)
- **Engine:** Unity 6 (`6000.3.9f1 x64`, IL2CPP)
- **Goal:** Modular injection of a tactical war campaign and narrative arc against Wehlen for the recovery of Zille.
- **Repository:** `C:\Projects\Great Zille solution`

---

## Architecture Discovery

### 1. Narrative Subsystem (Pixel Crushers Dialogue System)
- **Engine:** Pixel Crushers Dialogue System (`DialogueDatabase`, `DatabaseManager`, `DialogueEntry`).
- **Dynamic Choice Injection:**
  - `ConversationState.pcResponses` holds the active response options presented to the player.
  - Adding a custom `Response(FormattedText, DialogueEntry)` directly injects player decisions into any vanilla scene.
  - `Lua.RegisterFunction(string, object, MethodInfo)` allows binding native C# methods into the dialogue system's Lua state machine.

### 2. Tactical War Subsystem (Torpor Games War System)
- **Controller:** `WarOperationManager` (`Setup(OperationData)`).
- **Core Entities:**
  - `OperationData` (`Id`, `NameInDatabase`, `OperationProperties`).
  - `OperationProperties` (`OperationStartCondition`, `Phases` (List of WarFragmentData), `ResultVariable`, `WinReport`, `LoseReport`, `ResultConditionalInstruction`).
  - `WarFragmentData` inherits from `StoryFragmentData` (`AssignedTokenProperties`, `WarFragmentProperties`).
  - `WarFlowManager` controls turn progression (`PlayerTurn`, `EnemyTurn`, `EndWarTurn`, `RegisterToStartWarFragment`, `RegisterToEndWarFragment`).

---

## Log Entries

### [2026-10-21] Initial Reconnaissance & Workspace Setup
- Audited Suzerain directory (`H:\SteamLibrary\steamapps\common\Suzerain`).
- Sourced and compiled Unity 6 Il2CppDumper fork (`jdziat/Il2CppDumper:support-metadata-v39`) under .NET 8.0.
- Extracted `dumps/dump.cs` (41.7 MB), `dumps/script.json`, and `dumps/DummyDll/Assembly-CSharp.dll`.
- Created standalone launch switchers: `scripts/launch_vanilla.bat` and `scripts/launch_modded.bat`.

### [2026-10-21] Modloader Integration & C# Solution Initialization
- Selected **MelonLoader v0.7.3** (x64) as the target modloader due to verified native Unity 6 / .NET 8 IL2CPP support and minimal footprint (< 35 MB, zero disk pressure).
- Deployed MelonLoader into `H:\SteamLibrary\steamapps\common\Suzerain` via non-destructive `version.dll` hook.
- Updated `launch_vanilla.bat` and `launch_modded.bat` to dynamically toggle `version.dll` / `version.dll.disabled`.
- Created C# solution `src/GreatZilleSolution` targeting `net6.0` with automated post-build deployment into `Suzerain/Mods/`.
- Successfully compiled `GreatZilleSolution.dll` (0 warnings, 0 errors).
