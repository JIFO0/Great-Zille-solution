# Rizia/Turn 1/Houses Briefing Section

- **ID konwersacji:** `292`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Rizia/Turn_01/292_Houses_Briefing_Section.md`
- **Liczba węzłów dialogowych:** 201
- **Liczba wyborów gracza:** 41

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[79]** Vina Toras
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Prologue_Focus_ArmedForces`
- `RiziaDLC.Prologue_Focus_PRCampaign`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_JoinedSuOmina`
- `RiziaDLC.Prologue_StayedOnCouncil`
- `RiziaDLC.Prologue_Studied`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro`
- `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon`
- `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras`
- `RiziaDLCIsolated.Turn01_Toras_Imperii`
- `RiziaDLCIsolated.Turn01_Toras_Iza`
- `RiziaDLCIsolated.Turn01_Toras_Valenqiris`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.PersonalValue_Pacifist`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Vina`
- `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro`
- `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon`
- `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras`
- `RiziaDLCIsolated.Turn01_Toras_Imperii`
- `RiziaDLCIsolated.Turn01_Toras_Iza`
- `RiziaDLCIsolated.Turn01_Toras_Valenqiris`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[291] Rizia/Turn 1/A_TorasPoliticalOverview** (../Turn_01/291_A_TorasPoliticalOverview.md), Węzeł `[408]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 9
- **Węzły modyfikujące stan gry:** 19

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Vina`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[51]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] = true;`
- Węzeł `[55]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;`
- Węzeł `[65]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] = true;`
- Węzeł `[69]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] + 1;`
- Węzeł `[82]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- Węzeł `[85]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- Węzeł `[108]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] = true;`
- Węzeł `[121]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] + 1;`
- *...oraz 11 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `291` (*Rizia/Turn 1/A_TorasPoliticalOverview*), Węzeł `[408]`

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""While I'm on the subject, a word about our houses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[4]`
**[WYBÓR GRACZA: ""House Toras?""]** — Mówca: **Player_Romus**
> ""House Toras?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[5]`
**[WYBÓR GRACZA: ""House Sazon?""]** — Mówca: **Player_Romus**
> ""House Sazon?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[6]`
**[WYBÓR GRACZA: ""House Azaro?""]** — Mówca: **Player_Romus**
> ""House Azaro?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[7]`
Mówca: **Hugo Toras**
> ""Our family currently controls the province of Valenqiris as well as the city-state of Iza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[8]`
Mówca: **Hugo Toras**
> ""Aside from Iza, which is now under Rico's governance, all of Brenas is still their territory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Hugo Toras**
> ""The nobles there swore fealty to the crown in exchange for keeping a hold on their cities and their estates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Hugo Toras**
> ""But the return of Angelica's boy could test that loyalty. He is their rightful duke, after all, even if he does not admit it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`
  - -> `[23]`
  - -> `[44]`

### Węzeł `[11]`
Mówca: **Hugo Toras**
> ""Ah, yes. The rulers of Cardesse-Montaklar, and the stewards of the Rizian military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had no idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I was saddened to hear. He taught me everything I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[17]`
**[WYBÓR GRACZA: ""Yes. A shame I never got to know him.""]** — Mówca: **Player_Romus**
> ""Yes. A shame I never got to know him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
**[WYBÓR GRACZA: ""I hope the new war councilor is less of a hawk.""]** — Mówca: **Player_Romus**
> ""I hope the new war councilor is less of a hawk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""His daughter Lucita, the Duchess of Montaklar, was selected to take his place as war and security councilor. You'll meet her later today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Hugo Toras**
> ""You should also know that factions within her province have begun calling for the return of Pales. Again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`
  - -> `[26]`
  - -> `[27]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father was too soft on the Sazons. I'll keep them in line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He cannot be a duke and claim to represent democratic values at the same time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He lost that title when his father orchestrated my kidnapping.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why? Cardesse-Montaklar is large and powerful enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Azaros are warmongers, to a man. Or woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't let House Azaro down. I'll finish what the General started.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales hasn't been part of Rizia for over a century. It's a lost cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Hugo Toras**
> ""A contradiction, isn't it? He discourages his fellow Delegates from using the title, but has yet to officially renounce it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[29]`
Mówca: **Hugo Toras**
> ""No matter your feelings on the subject, I'd advise you to take the house's concerns seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[30]`
Mówca: **Hugo Toras**
> ""Be careful. We all know how the last campaign against the Grand Duchy ended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[31]`
Mówca: **Hugo Toras**
> ""Maybe so, but given the house's military might, I'd advise you to take their concerns seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Houses Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[37]`
  - -> `[40]`
  - -> `[186]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[36]`
Mówca: **Hugo Toras**
> ""Lucas was a rogue agent. Or so the rest of the house claims.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[43]`
Mówca: **Hugo Toras**
> ""At the moment, they're the weakest of the three houses. You'd do well to ensure they stay that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't blame them for siding with him after House Toras stole Iza from them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Hugo Toras**
> ""They betrayed our house and our king. What else could have been done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true && RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true && RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true && RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[49]`
Mówca: **Hugo Toras**
> ""As for the others...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[50]`
Mówca: **Hugo Toras**
> ""And finally...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true ||RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true ||RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true ||RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Pacifist -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Houses Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[57]`
Mówca: **Hugo Toras**
> ""As for the others...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Hugo Toras**
> ""And finally...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Houses Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[60]`
Mówca: **Hugo Toras**
> ""Well. I hope that was helpful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[61]`
Mówca: **Narrator**
> "Hugo glanced at the clock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true && RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true && RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true && RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true ||RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true ||RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true ||RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Pacifist += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How is Valenqiris doing, now that I've left?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Hugo Toras**
> ""Stable as always. With you on the throne, me as Grand Vizier and Rico in Iza, the governing seat has been filled by our distant cousin Hubertus. You recall him, I'm sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Hugo Toras**
> ""Of course, Princess Vina is eligible to take his place as the reigning Duchess once she is deemed fit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Narrator**
> "He nodded at my daughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`
  - -> `[91]`

### Węzeł `[77]`
Mówca: **Vina Toras**
> ""In a few years, maybe. I still don't feel ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`
  - -> `[80]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'll go when I tell you to go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're already smarter than I was when I became Duke. But it's your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. I'm not ready for you to live so far away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[81]`
Mówca: **Narrator**
> "Vina blushed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[83]`
Mówca: **Narrator**
> "Vina smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Vina Toras**
> ""Don't worry, Father. I'm here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Narrator**
> "Vina's face flushed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Vina Toras**
> ""Of course, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[88]`
Mówca: **Vina Toras**
> ""Thank you, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I allow her to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's already smarter than I was when I became Duke. But I don't want her living so far away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That depends on whom she marries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Hugo Toras**
> ""I'm fully aware of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[93]`
Mówca: **Hugo Toras**
> ""Completely understandable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[94]`
Mówca: **Hugo Toras**
> ""That goes without saying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's really going on in Iza? Has Rico been well-received as Duke?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[96]`
Mówca: **Narrator**
> "Hugo's face hardened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[97]`
Mówca: **Narrator**
> "Hugo tapped his fingers on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Hugo Toras**
> ""In any case, Your Majesty, I don't expect any trouble in Valenqiris during your reign. It remains the wealthiest of Rizia's provinces, and the least affected by crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[99]`
Mówca: **Hugo Toras**
> ""Iza has been difficult since the Sazon rebellion. Even more so since the Wehzek population there exploded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Hugo Toras**
> ""Any effort to restore the rights and privileges of native Rizians is met with resistance. The students at Iza University are leading the charge, I believe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Hugo Toras**
> ""Considering the circumstances, I believe my son is doing just fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[119]`
  - -> `[120]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about Rizia Imperii? We control that too, don't we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[103]`
Mówca: **Hugo Toras**
> ""As for the other houses...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true && RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true && RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true && RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Houses Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true ||RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true ||RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true ||RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[112]`
Mówca: **Hugo Toras**
> ""And finally...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[113]`
Mówca: **Hugo Toras**
> ""Make sure their lives don't get any less comfortable, and the local nobility will stay loyal to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[114]`
Mówca: **Hugo Toras**
> ""Yes, Porte Drazon and its metropolitan area are controlled by the central government, and therefore House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Hugo Toras**
> ""You don't need to worry about pleasing our house in this region, though. It's more crucial to retain the favor of the major corporations that are based here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[124]`
  - -> `[125]`

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nonsense. It's the corporations who should be concerned with winning *my* favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is Su Omina still based there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[118]`
Mówca: **Hugo Toras**
> ""They are. In fact, the group took to the streets in celebration of your coronation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not the Wehzeks who are the danger. It's bigotry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll find a way to help him out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Hugo += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Hugo Toras**
> ""That would be most kind of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[123]`
Mówca: **Hugo Toras**
> ""The crime statistics are not bigoted, Your Majesty. If we do not acknowledge this problem, it will get worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Understood. If our economy takes a hit, another uprising won't be far behind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Doesn't House Toras run any corporations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Hugo Toras**
> ""Some minor relations do. But most of our house's wealth comes from our land and natural gas holdings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[127]`
Mówca: **Hugo Toras**
> ""Precisely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[128]`
Mówca: **Hugo Toras**
> ""A healthy perspective, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Toras Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[133]`
  - -> `[136]`
  - -> `[140]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Toras_Valenqiris == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Toras_Valenqiris == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Toras_Valenqiris"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Toras_Valenqiris == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Toras_Valenqiris"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Toras_Iza == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Toras_Iza == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Toras_Iza"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Toras_Iza == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Toras_Iza"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Toras_Imperii == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Toras_Imperii == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Toras_Imperii"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Toras_Imperii == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Toras_Imperii"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Toras_Valenqiris = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Toras_Valenqiris"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Got it. That's all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Narrator**
> "Hugo nodded approvingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Toras Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Toras_Iza = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Toras_Iza"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Toras Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Toras_Imperii = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Toras_Imperii"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Toras Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[147]`
Mówca: **Hugo Toras**
> ""The Pales Administrative District is also under the jurisdiction of Rizia Imperii since we won it back in the Reclamation War.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[148]`
Mówca: **Hugo Toras**
> ""Lest we forget, Wehlen is scheduled to return Zille to Rizia next year. The Sazons expect the region to become part of their province, as it was before the uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`
  - -> `[151]`
  - -> `[154]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The power balance between the houses is fragile enough. Adding so much land to Brenas would upset it beyond repair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's very presumptuous of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can use it as a bargaining chip. Stay loyal to the crown, or no Zille for House Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Hugo Toras**
> ""As king, you have the authority to make Zille part of the central government, similar to Rizia Imperii. An option to keep in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[153]`
Mówca: **Hugo Toras**
> ""Now you're thinking like a king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't see any downside to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Hugo Toras**
> ""It's a lot of land, including two strategic harbors. Allowing the Sazons to regain the power they had before the uprising would be unwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[156]`
Mówca: **Hugo Toras**
> ""You must be aware of their patriarch Taddeus' poor health. The General suffered a stroke just prior to King Valero's death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[196]`
  - -> `[12]`
  - -> `[18]`

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Father was fond of him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: LookAt("Rizia_City_Sallabes");)*
- **Efekt (`userScript`):** `LookAt("Rizia_City_Sallabes");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: LookAt("Rizia_City_Monqiz");)*
- **Efekt (`userScript`):** `LookAt("Rizia_City_Monqiz");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: LookAt("Rizia_City_Iza");)*
- **Efekt (`userScript`):** `LookAt("Rizia_City_Iza");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: LookAt("Rizia_City_PorteDrazon");)*
- **Efekt (`userScript`):** `LookAt("Rizia_City_PorteDrazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: LookAt("Rizia_City_Montaklar");)*
- **Efekt (`userScript`):** `LookAt("Rizia_City_Montaklar");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: LookAtModeOff();)*
- **Efekt (`userScript`):** `LookAtModeOff();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: LookAt("Rizia_City_PorteDrazon");)*
- **Efekt (`userScript`):** `LookAt("Rizia_City_PorteDrazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_ArmedForces == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_ArmedForces == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Focus_ArmedForces"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Focus_ArmedForces == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Focus_ArmedForces"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[168]`
Mówca: **Hugo Toras**
> ""You've already made strengthening the Rizian armed forces a high priority. That should endear you to them right off the bat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[169]`
Mówca: **Hugo Toras**
> ""As for Angelica herself... she remains in exile. As she should.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[175]`
  - -> `[178]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Exile's too good for her. Why can't I just have her killed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Tyrant += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Narrator**
> "Hugo's lip twitched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Hugo Toras**
> ""Aside from the fact that doing so would turn all of Brenas against you... there is no evidence she did anything wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Hugo Toras**
> ""There are even whispers that she turned her husband in not to save her own skin, but to aid in the monarchy's preservation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She did nothing wrong. Why does she still have to suffer for it after all these years?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Hugo Toras**
> ""The Sazon matriarch is a powerful figure, Your Majesty. Even all these years later, she commands the loyalty of the entire province of Brenas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Hugo Toras**
> ""I do not deny that she could be a useful ally. But only as long as you stay on her house's good side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If Angelica is in exile and Manus has not laid claim to the Duke position, who's officially in charge of Brenas now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Narrator**
> "Hugo checked his notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Hugo Toras**
> ""A lesser relation by the name of Leona. She reigns from Sallabes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Hugo Toras**
> ""But it is Manus and Angelica that the rest of the Sazons take their cues from.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_PRCampaign == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_PRCampaign == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Focus_PRCampaign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Focus_PRCampaign == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Focus_PRCampaign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[185]`
Mówca: **Hugo Toras**
> ""From what I've been hearing, the PR campaign you spearheaded over the last several years endeared you to them greatly. Keep up the good work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to continue. I'm up to speed on the houses' activities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Narrator**
> "Hugo gave a short sniff."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Hugo Toras**
> ""I see. Then this will be a short meeting indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedSuOmina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Hugo Toras**
> ""They are working with Ricardus to preserve whatever fragile order exists in the city, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Studied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May God bless him with a full recovery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_StayedOnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[200]`
Mówca: **Hugo Toras**
> ""Indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
