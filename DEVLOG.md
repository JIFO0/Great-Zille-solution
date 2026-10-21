# Project: Great Zille Solution — Development Log

## Overview
- **Game:** Suzerain (Torpor Games)
- **Engine:** Unity 6 (`6000.3.9f1 x64`, IL2CPP)
- **Goal:** Modular injection of a tactical war campaign and narrative arc against Wehlen for the recovery of Zille.
- **Repository:** `C:\Projects\Great Zille solution`

---

## Architecture Discovery

### 1. Narrative Subsystem
- **Engine:** Pixel Crushers Dialogue System (`DialogueDatabase`, `DatabaseManager`, `DialogueEntry`).
- Dialogues, variables, and conditions are executed via Lua and Dialogue System state machines.

### 2. Tactical War Subsystem
- **Controller:** `WarOperationManager` (`Setup(OperationData)`).
- **Core Entities:**
  - `OperationData` (`Id`, `NameInDatabase`, `OperationProperties`).
  - `OperationProperties` (`OperationStartCondition`, `Phases` (List of WarFragmentData), `ResultVariable`, `WinReport`, `LoseReport`, `ResultConditionalInstruction`).
  - `WarFragmentData` inherits from `StoryFragmentData` (`AssignedTokenProperties`, `WarFragmentProperties`).
  - Map / Tokens: `WarTileManager`, `WarTokenManager`, `WarBattleManager`.

---

## Log Entries

### [2026-10-21] Initial Reconnaissance & Workspace Setup
- Audited Suzerain directory (`H:\SteamLibrary\steamapps\common\Suzerain`).
- Identified architecture:
  - IL2CPP runtime: `GameAssembly.dll` (75.1 MB), metadata version 39 (`global-metadata.dat` 17.8 MB).
  - Unity 6 engine build.
  - Assets managed via Unity Addressables (`StreamingAssets/aa/StandaloneWindows64`).
- Initialized local workspace:
  - Configured `.gitignore` for dumps and build artifacts.
  - Prepared `tools/`, `dumps/`, `src/`, `scripts/`, `docs/`.
  - Sourced and compiled Unity 6 Il2CppDumper fork (`jdziat/Il2CppDumper:support-metadata-v39`) under .NET 8.0.
  - Successfully extracted `dumps/dump.cs` (41.7 MB), `dumps/script.json`, and `dumps/DummyDll/Assembly-CSharp.dll`.
  - Created standalone launch switchers: `scripts/launch_vanilla.bat` and `scripts/launch_modded.bat`.
