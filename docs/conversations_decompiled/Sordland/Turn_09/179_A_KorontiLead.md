# Sordland/Turn09/A_KorontiLead

- **ID konwersacji:** `179`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/179_A_KorontiLead.md`
- **Liczba węzłów dialogowych:** 187
- **Liczba wyborów gracza:** 25

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[44]** Lileas Graf
- **[56]** Karl Greiser

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Accepted_MediaDeal`
- `BaseGame.Faction_Oligarchs_KorontiLeader`
- `BaseGame.Fired_KarlGreiser`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`
- `BaseGame.Turn07_Detained_MikailAven`
- `BaseGame.Turn07_Detained_WalterTusk`
- `BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff`
- `BaseGame.Turn08_SnO_KorontiInvestigationStopped`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Faction_Oligarchs_Ally`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.Faction_Oligarchs_Destroyed`
- `BaseGame.Faction_Oligarchs_Enemy`
- `BaseGame.Faction_Oligarchs_KorontiLeader`
- `BaseGame.Leader_Oligarchs_WalterTusk`
- `BaseGame.Turn09_A_MarcelArrested`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_ArrestedLegally`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_Detained`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_Fled`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_FledAndExtradited`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_FoundDeadInPrison`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_KonrathDead`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_LostControlOfHOS`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_NedamShares`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_SSCAndNedamShares`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_SSCShares`
- `BaseGameSupport.Journal_Turn09_KorontiLead_Arrest`
- `BaseGameSupport.Journal_Turn09_KorontiLead_NoLeads`
- `BaseGameSupport.Report_Turn09_Estord_Investigation_Koranelli_NotStopped`
- `BaseGameSupport.Report_Turn09_Estord_Investigation_Koranelli_TippedOff`
- `GameCondition.Turn09_A_KorontiLead`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 22

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[3]` (Lucian Galade): `Variable["GameCondition.Turn09_A_KorontiLead"] = true;`
- Węzeł `[91]` (Lucian Galade): `Variable["BaseGame.Turn09_A_MarcelArrested"] = true;`
- Węzeł `[98]` (Lucian Galade): `Variable["BaseGame.Faction_Oligarchs_Enemy"] = false;`
- Węzeł `[105]` (Lucian Galade): `Variable["BaseGame.Faction_Oligarchs_KorontiLeader"] = false; ;`
- Węzeł `[127]` (Lucian Galade): `Variable["BaseGameSupport.Journal_Turn09_KorontiLead_NoLeads"] = true;`
- Węzeł `[128]` (Lucian Galade): `Variable["BaseGameSupport.Journal_Turn09_KorontiLead_Arrest"] = true;`
- Węzeł `[141]` (Lucian Galade): `Variable["BaseGame.Faction_Oligarchs_Enemy"] = false;`
- Węzeł `[163]` (Lucian Galade): `Variable["BaseGameSupport.Report_Turn09_Estord_Investigation_Koranelli_TippedOff"] = true;`
- *...oraz 14 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn09_A_KorontiLead = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn09_A_KorontiLead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[4]`
Mówca: **Narrator**
> "I was walking down the corridor towards my office on the way back from lunch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Right next to the door, Lileas, Nia and Karl were waiting. They approached me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[6]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[8]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Right next to the door, Lileas was waiting. She approached me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Lileas Graf**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[11]`
Mówca: **Lileas Graf**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Lileas Graf**
> "“There has been an important update on the Koronti investigation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Narrator**
> "We entered the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Lileas Graf**
> "“An informant from HOS contacted us. He was identified as a low-level executive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`
  - -> `[17]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“So what did he say?”"]** — Mówca: **Player**
> "“So what did he say?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“Can we trust this informant?”"]** — Mówca: **Player**
> "“Can we trust this informant?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Go on.”"]** — Mówca: **Player**
> "“Go on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[18]`
Mówca: **Karl Greiser**
> "“We have interrogated him thoroughly and confirmed the information he gave us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Narrator**
> "Karl stepped forward and bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[20]`
Mówca: **Karl Greiser**
> "“We now have proof that a subsidiary of HOS, Konrath Holdings, is a shell corporation engaged in money laundering for the Koranelli cartel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Karl Greiser**
> "“Over the past three years, approximately 15 million Sordish ren from the Koranellis' drug and weapons smuggling activities has gone through this corporation with Marcel Koronti's implicit approval.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[22]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“This can't be. This must be a ploy against HOS or Koronti.”"]** — Mówca: **Player**
> "“This can't be. This must be a ploy against HOS or Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Nia Morgna**
> "“Whatever you say, there is now enough evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Narrator**
> "Nia frowned at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[25]`
Mówca: **Nia Morgna**
> "“Why are you so willing to protect HOS? Why is it so hard to believe?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Narrator**
> "All eyes in the room turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[33]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“That settles it then. What is the plan?”"]** — Mówca: **Player**
> "“That settles it then. What is the plan?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Nia Morgna**
> "“The time has come. Frankly, we have been preparing for this possibility.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Nia Morgna**
> "“Please follow us to the comms room.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Narrator**
> "Nia gestured towards the door and I followed the two women down the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Nothing. It's just hard to believe such a respectable business would stoop to this level.”"]** — Mówca: **Player**
> "“Nothing. It's just hard to believe such a respectable business would stoop to this level.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Nia Morgna**
> "“That is why none of these oligarchs can be trusted. They would do anything for money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I stayed silent and did not reply to her question."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Nia Morgna**
> "“Regardless of your uncertainty, we will move.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[35]`
Mówca: **Narrator**
> "We descended the spiral staircase at the very edge of the palace, close to where my office was located."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Narrator**
> "Going through narrower corridors than upstairs, we came in front of a large door with a shield and a goat carved on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Narrator**
> "Nia opened the door and we entered. After taking our seats, she gave me a sheepish look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Nia Morgna**
> "“Mr. President. I said we have been preparing for this opportunity, but that might've been an understatement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Nia Morgna**
> ""Our attack teams are ready to go. They've surrounded Mr. Koronti's villa in Estord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[40]`
Mówca: **Narrator**
> "She nodded at Karl. Karl leaned forward and spoke into the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Karl Greiser**
> "“Begin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Narrator**
> "We sat there for a few minutes, waiting anxiously. Finally, Karl received a radio transmission."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Karl Greiser**
> "“Mr. Koronti has been successfully captured.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`
  - -> `[46]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Well done.”"]** — Mówca: **Player**
> "“Well done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“I hope we caught the right person.”"]** — Mówca: **Player**
> "“I hope we caught the right person.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "“There will be consequences for this.”"]** — Mówca: **Player**
> "“There will be consequences for this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[47]`
Mówca: **Lileas Graf**
> "“Now that he's been arrested, Sordland will have one less traitor. We will learn the truth from him directly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Lileas Graf**
> "“One way or another.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[52]`
  - -> `[54]`

### Węzeł `[49]`
Mówca: **Lileas Graf**
> "“All of his contacts, everyone he has been dealing with.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Lileas Graf**
> "“Of course, and our administration will successfully handle it. I am sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[51]`
Mówca: **Nia Morgna**
> "“I want to especially confirm the rumour about his contact in the administration. We will squeeze every single drop of information we can out from him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "“As you said, one less traitor.”"]** — Mówca: **Player**
> "“As you said, one less traitor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "“I am looking forward to the results.”"]** — Mówca: **Player**
> "“I am looking forward to the results.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[55]`
Mówca: **Lileas Graf**
> "“We will bring them to you as quickly as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Lileas Graf**
> "“Indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Nia Morgna**
> "“The news ought to break any moment now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Lileas Graf**
> "“This was all for today, Mr. President. We will keep you posted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Lileas Graf**
> "“Thank you for your time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[60]`
Mówca: **Karl Greiser**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Narrator**
> "They left one by one and I made my way back to my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[65]`
Mówca: **Narrator**
> "This could be the end of my presidency. If Marcel talked, everything could end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Narrator**
> "There must be a way out of this."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[67]`
Mówca: **Narrator**
> "Sordland now felt a little bit safer now that Marcel had been taken care of."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Narrator**
> "For how long, I wondered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[69]`
Mówca: **Lileas Graf**
> "“There has been an update on the Koronti investigation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Narrator**
> "We entered the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Lileas Graf**
> "“Unfortunately we were not able to find any leads.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Lileas Graf**
> "“At this time, we will not be able to continue the investigation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Lileas Graf**
> "“No matter how much we probed into HOS, no matter how many employees we tried to get insider information from, their mouths were completely shut.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`
  - -> `[76]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "“Everyone is innocent until proven guilty, right?”"]** — Mówca: **Player**
> "“Everyone is innocent until proven guilty, right?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“That is truly disappointing.”"]** — Mówca: **Player**
> "“That is truly disappointing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "“Really?”"]** — Mówca: **Player**
> "“Really?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[77]`
Mówca: **Lileas Graf**
> "“There are many words that describe HOS and Koronti and I still believe innocent is not one of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Lileas Graf**
> "“Regardless, that doesn't change the fact that we are currently stuck.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[79]`
Mówca: **Lileas Graf**
> "“No need to exaggerate. We will find something in the future. I am sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[80]`
Mówca: **Lileas Graf**
> "“Yes. Really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[81]`
Mówca: **Lileas Graf**
> "“I just wanted to let you know that I will keep my eyes open. I will make sure the truth comes out about HOS.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`
  - -> `[84]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "“Make sure you don't let emotions affect your judgement.”"]** — Mówca: **Player**
> "“Make sure you don't let emotions affect your judgement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "“Good work, Lileas. Keep at it.”"]** — Mówca: **Player**
> "“Good work, Lileas. Keep at it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "“In time, I am sure it will.”"]** — Mówca: **Player**
> "“In time, I am sure it will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[85]`
Mówca: **Lileas Graf**
> "“Never.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[86]`
Mówca: **Lileas Graf**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Lileas Graf**
> "“We were so close to getting him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Lileas Graf**
> "“Anyway. I won't take up more of your time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Lileas Graf**
> "“Have a nice day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[90]`
Mówca: **Narrator**
> "As soon as she turned her back to leave, I couldn't help but smirk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[91]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_MarcelArrested = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_MarcelArrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[92]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_MikailAven == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_MikailAven == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_MikailAven"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[94]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Detained_MikailAven == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_MikailAven"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[95]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_KorontiLeader == true && BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_KorontiLeader == true && BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_KorontiLeader"] == true  and  Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_KorontiLeader == true && BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_KorontiLeader"] == true  and  Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[98]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Enemy = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Enemy"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[99]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_KorontiLeader == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_KorontiLeader == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_KorontiLeader"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_KorontiLeader == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_KorontiLeader"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[102]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_WalterTusk == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_WalterTusk == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Detained_WalterTusk == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[105]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_KorontiLeader = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_KorontiLeader"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[106]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Fired_KarlGreiser == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[109]`
Mówca: **Narrator**
> "Right next to the door, Lileas and Nia were waiting. They approached me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[110]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Fired_KarlGreiser == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[113]`
Mówca: **Lileas Graf**
> "“We have interrogated him thoroughly and confirmed the information he gave us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Lileas Graf**
> "“We now have proof that a subsidiary of HOS, Konrath Holdings, is a shell corporation engaged in money laundering for the Koranelli cartel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Lileas Graf**
> "“Over the past three years, approximately 15 million Sordish ren from the Koranellis' drug and weapons smuggling activities has gone through this corporation with Marcel Koronti's implicit approval.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[22]`

### Węzeł `[116]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Fired_KarlGreiser == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[119]`
Mówca: **Narrator**
> "Nia nodded to Lileas, who leaned forward and spoke into the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Lileas Graf**
> "“Begin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Narrator**
> "We sat there for a few minutes, waiting anxiously. Finally, Lileas received a radio transmission."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Lileas Graf**
> "“Mr. Koronti has been successfully captured.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`
  - -> `[46]`

### Węzeł `[123]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Fired_KarlGreiser == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[126]`
Mówca: **Narrator**
> "They left and I made my way back to my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[127]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_KorontiLead_NoLeads = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_KorontiLead_NoLeads"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[128]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_KorontiLead_Arrest = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_KorontiLead_Arrest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[129]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[131]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Narrator**
> "Right next to the door, Nia was waiting. She approached me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Nia Morgna**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Nia Morgna**
> "“There has been an update on the Koronti investigation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Narrator**
> "We entered the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[136]`
Mówca: **Nia Morgna**
> "“Regardless, that doesn't change the fact that we are currently stuck.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[137]`
**[WYBÓR GRACZA: "“In time, I am sure it will.”"]** — Mówca: **Player**
> "“In time, I am sure it will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[138]`
Mówca: **Narrator**
> "As soon as she turned her back to leave, I couldn't help but smirk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[139]`
**[WYBÓR GRACZA: "“Everyone is innocent until proven guilty, right?”"]** — Mówca: **Player**
> "“Everyone is innocent until proven guilty, right?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[140]`
Mówca: **Nia Morgna**
> "“Unfortunately we were not able to find any leads.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Enemy = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Enemy"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[142]`
Mówca: **Nia Morgna**
> "“At this time, we will not be able to continue the investigation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[143]`
**[WYBÓR GRACZA: "“Good work, Nia. Keep at it.”"]** — Mówca: **Player**
> "“Good work, Nia. Keep at it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[144]`
Mówca: **Nia Morgna**
> "“No matter how much we probed into HOS, no matter how many employees we tried to get insider information from, their mouths were completely shut.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[151]`
  - -> `[152]`

### Węzeł `[145]`
**[WYBÓR GRACZA: "“Make sure you don't let emotions affect your judgement.”"]** — Mówca: **Player**
> "“Make sure you don't let emotions affect your judgement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[146]`
Mówca: **Nia Morgna**
> "“Anyway. I won't take any more of your time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[147]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_KorontiLeader == true && BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_KorontiLeader == true && BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_KorontiLeader"] == true  and  Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[149]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_KorontiLeader == true && BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_KorontiLeader"] == true  and  Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[150]`
Mówca: **Nia Morgna**
> "“We were so close this time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[151]`
**[WYBÓR GRACZA: "“That is truly disappointing.”"]** — Mówca: **Player**
> "“That is truly disappointing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[152]`
**[WYBÓR GRACZA: "“Really?”"]** — Mówca: **Player**
> "“Really?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Nia Morgna**
> "“Have a nice day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[154]`
Mówca: **Nia Morgna**
> "“Yes. Really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[155]`
Mówca: **Nia Morgna**
> "“No need to exaggerate. We will find something in the future. I am sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[156]`
Mówca: **Nia Morgna**
> "“There are many words that describe HOS and Koronti, and I still believe innocent is not one of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[157]`
Mówca: **Nia Morgna**
> "“I just wanted to let you know that I will keep my eyes open. I will make sure the truth comes out about HOS.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[143]`
  - -> `[137]`

### Węzeł `[158]`
Mówca: **Nia Morgna**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[159]`
Mówca: **Nia Morgna**
> "“Never.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[160]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true && BaseGame.Turn08_SnO_KorontiInvestigationStopped == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true && BaseGame.Turn08_SnO_KorontiInvestigationStopped == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] == true  and  Variable["BaseGame.Turn08_SnO_KorontiInvestigationStopped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff == true && BaseGame.Turn08_SnO_KorontiInvestigationStopped == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] == true  and  Variable["BaseGame.Turn08_SnO_KorontiInvestigationStopped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn09_Estord_Investigation_Koranelli_TippedOff = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn09_Estord_Investigation_Koranelli_TippedOff"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[164]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_KorontiInvestigationStopped == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_KorontiInvestigationStopped == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SnO_KorontiInvestigationStopped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SnO_KorontiInvestigationStopped == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SnO_KorontiInvestigationStopped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[167]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn09_Estord_Investigation_Koranelli_NotStopped = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn09_Estord_Investigation_Koranelli_NotStopped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[168]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Destroyed = true; BaseGame.Faction_Oligarchs_Enemy = false;
BaseGame.Faction_Oligarchs_Content = false;
BaseGame.Faction_Oligarchs_Ally = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Destroyed"] = true;
Variable["BaseGame.Faction_Oligarchs_Enemy"] = false;
Variable["BaseGame.Faction_Oligarchs_Content"] = false;
Variable["BaseGame.Faction_Oligarchs_Ally"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[169]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Destroyed = false; BaseGame.Faction_Oligarchs_Enemy = true;
BaseGame.Faction_Oligarchs_Content = false;
BaseGame.Faction_Oligarchs_Ally = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Destroyed"] = false;
Variable["BaseGame.Faction_Oligarchs_Enemy"] = true;
Variable["BaseGame.Faction_Oligarchs_Content"] = false;
Variable["BaseGame.Faction_Oligarchs_Ally"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[170]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Business_MarcelKoronti = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_ArrestedLegally = true; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_Detained = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_Fled = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_FledAndExtradited = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_FoundDeadInPrison = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_KonrathDead = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_LostControlOfHOS = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_NedamShares = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_SSCAndNedamShares = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_SSCShares = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_ArrestedLegally"] = true;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_Detained"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_Fled"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_FledAndExtradited"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_FoundDeadInPrison"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_KonrathDead"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_LostControlOfHOS"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_NedamShares"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_SSCAndNedamShares"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_SSCShares"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[171]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_WalterTusk == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_WalterTusk == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[173]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Detained_WalterTusk == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[175]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Destroyed = true; BaseGame.Faction_Oligarchs_Enemy = false;
BaseGame.Faction_Oligarchs_Content = false;
BaseGame.Faction_Oligarchs_Ally = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Destroyed"] = true;
Variable["BaseGame.Faction_Oligarchs_Enemy"] = false;
Variable["BaseGame.Faction_Oligarchs_Content"] = false;
Variable["BaseGame.Faction_Oligarchs_Ally"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[176]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_WalterTusk == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_WalterTusk == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Detained_WalterTusk == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Destroyed = false; BaseGame.Faction_Oligarchs_Enemy = false;
BaseGame.Faction_Oligarchs_Content = false;
BaseGame.Faction_Oligarchs_Ally = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Destroyed"] = false;
Variable["BaseGame.Faction_Oligarchs_Enemy"] = false;
Variable["BaseGame.Faction_Oligarchs_Content"] = false;
Variable["BaseGame.Faction_Oligarchs_Ally"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[181]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Factions", "Position_Oligarch", "Faction_Oligarchs_EdithAgnoc");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Factions","Position_Oligarch","Faction_Oligarchs_EdithAgnoc");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[182]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Factions", "Position_Oligarch", "Faction_Oligarchs_MikailAven");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Factions","Position_Oligarch","Faction_Oligarchs_MikailAven");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Factions", "Position_Oligarch", "Faction_Oligarchs_WalterTusk");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Factions","Position_Oligarch","Faction_Oligarchs_WalterTusk");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Leader_Oligarchs_WalterTusk = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Leader_Oligarchs_WalterTusk"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[185]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Leader_Oligarchs_WalterTusk = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Leader_Oligarchs_WalterTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[186]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
