# Wehlen deployment scenarios (v14)

Rule (owner, review 2): **every province holds at most ONE unit, and city provinces hold none** (Munat 2, Nanta 9, Isor 11, Wiktrany 28, Zille City 35, Kratsna 71, Grodzizg 94). v14: no unit on Derdia (incl. the impassable Yol 129); the Wehlen southern front facing Derdia is 122, 93, 88, 95. "Groups" are clusters of adjacent provinces with one unit each.

Files: `deployment_minimal.json`, `deployment_suspicious.json`, `deployment_prepared.json` - each has `deployment` = list of `{province_id, province_name, unit_type}` (one unit per entry) and `summary` (totals per type, land/naval totals, units per region). `deployments_all.csv` = all three variants (one row per unit). `deployments_summary.json` = the three summaries. Previews: `deployment_<variant>_preview.png` (one symbol per province).

## Unit types

| id | label (PL) | kind |
|---|---|---|
| `infantry` | piechota | land |
| `mountain_infantry` | piechota górska | land |
| `tanks` | czołgi | land |
| `mechanized_infantry` | piechota zmechanizowana (also "motorized"/zmotoryzowana) | land |
| `militia` | milicja (militia) | land |
| `paratroopers` | spadochroniarze | land |
| `submarine` | łódź podwodna | naval |
| `destroyer` | niszczyciel | naval |
| `flagship` | flagship / okręt flagowy (max 1) | naval |

"Motorized" (zmotoryzowane) units from the owner's brief have no own type: they are `mechanized_infantry`.

Rules: units only on Wehlen-owned land (Zille + Wehlen) and on sea provinces; exactly one flagship; no Wehlen ship on the Rizia ship-placement seas (west S56, S57; east S37, S30, S32, S31, S26) - the blocking lines stand in front of them. Defence lines and forts: `../forts.json` (border_west heavy, border_east light, north_line light = inner line Marenta - north of Nanta: 21, 17, 13, 8, 97).

## Variants

### minimal

Minimal preparation. The Rizia border is held only by infantry and militia (one unit per border province); the inner line Marenta - north of Nanta (21-17-13-8-97) is unmanned. Zille has 2 tanks right behind the front (Zille North 31, Portoserra Southeast 113), a small mechanized pair near Wiktrany (110, 24) and, in the rear behind the inner line, mountain infantry in the Quella Highlands (100) with a mechanized pair (99, 98). Most units are in continental Wehlen; tanks and mechanized stand in small groups of 2 adjacent provinces (tanks 74-76 and 82-87, mechanized 75-78 and 90-91). The fleet is a set of thin one-ship lines (S25/S22/S18 in front of the Rizian east seas, S12/S16 at Munat, S29/S35 in the Isor-Rotsla channel, S55/S54 in front of the Rizian west seas); the flagship lies in Kreleck Sound (S1) next to the capital Kratsna.

Totals: land 46, naval 11 - infantry 18, mountain_infantry 3, tanks 6, mechanized_infantry 8, militia 10, paratroopers 1, submarine 4, destroyer 6, flagship 1. By region: Sea 11, Wehlen 28, Zille 18.

### suspicious

Suspicious. Both defence lines are manned: the border (heavy forts west, light forts east) and the inner line Marenta - north of Nanta (21, 17, 13, 8, 97). On the first line next to Zille City stand 2 tanks (Pomara Northwest 36, Pomara West 117). Zille City (a city, so no unit on it) is ringed by infantry and mechanized ("motorized" = mechanized_infantry) units in its neighbour provinces 30, 31, 38, 116 plus the border units on 36, 117, 39. Around Wiktrany stands a reserve (tanks 112-25, mechanized 24-106, paratroopers 113). Port Rotsla island (96) has infantry. On the Derdian border a screen stands on the southern front (infantry 122, 88, militia 93, 95, mountain infantry 119 behind). The navy is bigger, the flagship is in Zille Bay (S52), and two blocking lines stop a Rizian advance past Nanta and Munat: S25-S22-S18-S21 right in front of the Rizian east seas, then S17-S20-S12-S11-S16-S7 around Munat; the west coast is screened by S55-S54-S51.

Totals: land 49, naval 17 - infantry 18, mountain_infantry 5, tanks 7, mechanized_infantry 8, militia 10, paratroopers 1, submarine 7, destroyer 9, flagship 1. By region: Sea 17, Wehlen 19, Zille 30.

### prepared

Prepared (maximum defence, still beatable). Both lines are manned, every Zille mountain province holds mountain infantry, and this variant has the most armour and the biggest fleet. BUT Wiktor Smolak sent the best forces forward to seize Rizian territory: strike groups of adjacent tank/mechanized provinces stand next to the Rizian cities - Venna East 104 + Venna 20 (tanks) with 15 + 102 (mechanized) facing Mave Nortus; Dapalle Northwest 114 + Dapalle West 33 (tanks) with 29 + 26 (mechanized) facing Dapalle; Pomara West 117 + Pomara Northwest 36 on the Brivane road; Celle Vaz North 39 + Rivamare 38 (tanks) with Praia Velha 118 (mechanized) facing Celle Vaz / Marbelas; a second echelon (31, 110, 111, 25, 32) and paratroopers next to Zille City (30, 116). The capital Kratsna area keeps only 5 units (militia 70, 75, 72 and infantry 82, 91, no armour), so a Rizian landing in the north or a breakthrough behind the strike groups can win. v14: Smolak expects Derdia to join, so the widened southern front is fully manned - front row 122 (infantry), 93 and 88 (mountain infantry), 95 (infantry) facing the Derdia strip 124/126/128, second row 120 (militia), 121 and 89 (mechanized), 119 (mountain infantry), 84 (infantry).

Totals: land 60, naval 21 - infantry 18, mountain_infantry 9, tanks 9, mechanized_infantry 10, militia 12, paratroopers 2, submarine 9, destroyer 11, flagship 1. By region: Sea 21, Wehlen 15, Zille 45.

Escalation: land, naval, tank and armour (tanks + mechanized) totals grow from minimal to suspicious to prepared. The prepared variant stays beatable: the east border has only light forts, the strike groups stand forward (open to encirclement) and the capital area holds only 5 units.
