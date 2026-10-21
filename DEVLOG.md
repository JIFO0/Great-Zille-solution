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
- Compiled Unity 6 Il2CppDumper fork (`jdziat/Il2CppDumper:support-metadata-v39`) under .NET 8.0.
- Extracted `dumps/dump.cs` (41.7 MB), `dumps/script.json`, and `dumps/DummyDll/Assembly-CSharp.dll`.
- Created standalone launch switchers: `scripts/launch_vanilla.bat` and `scripts/launch_modded.bat`.

### [2026-10-21] Modloader Integration & C# Solution Initialization
- Selected **MelonLoader v0.7.3** (x64) as target modloader (< 35 MB, zero disk pressure).
- Deployed MelonLoader into `H:\SteamLibrary\steamapps\common\Suzerain` via non-destructive `version.dll` hook.
- Updated `launch_vanilla.bat` and `launch_modded.bat` to dynamically toggle `version.dll` / `version.dll.disabled`.
- Created C# solution `src/GreatZilleSolution` targeting `net6.0`.

### [2026-10-21] Fixes, Lespia Pact & Global Geopolitics
- Fixed batch syntax in launcher scripts (eliminated unescaped parenthesis in nested echo/rem blocks). Verified clean execution of both `launch_modded.bat` and `launch_vanilla.bat`.
- Implemented **Lespia / Alvarez Backchannel Pact**:
  - In diplomatic contacts / Alvarez visit: Alvarez offers satellite intel, weapons, and free hand against Wehlen if Rizia drops plans to invade Pales.
  - Accepting disables Pales war and reallocates full royal army to Zille theater.
- Implemented **Global Geopolitical Shifts**:
  - Malenyevist bloc (Valgsland, Morella, CSP): Hegel denounces Rizia feudal aggression; Morella MITZ negotiations stall.
  - Capitalist bloc (Lespia, Arcasia, ATO): Major relations boost and military intelligence flow.

### [2026-10-21] Runtime Bugfix (TypeLoadException) & Extended Geopolitics (v0.2.0)
- **Resolved MelonLoader TypeLoadException:** Replaced early attribute-based scanning with manual runtime Harmony registration in `OnInitializeMelon()`. Built `DialogueHelper` for decoupled, dynamic reflection over Pixel Crushers Dialogue System.
- **English Localization & [MOD] Tag:** Formatted all injected dialogue choices in English with explicit `[MOD]` prefixes.
- **Derdia Hybrid Warfare (Azmal):** Added holy irregular sabotage behind Wehzek oil refineries if relations with Derdia are high.
- **Sordland Integration (Anton Rayne):** Integrated diplomatic reaction based on whether Sordland participated in Operation Bear Trap with Smolak.
- **Economic Crisis Mechanics:**
  - Instant cancellation of Wehlen trade agreement and oil supplies.
  - -2 Energy per turn deficit.
  - Two-front war triggers soaring military upkeep and gold drain, mitigated by Lespian emergency credits if the backchannel pact was accepted.
- Successfully built `GreatZilleSolution.dll` (0 errors, 0 warnings) and auto-deployed into `Suzerain/Mods/`.
