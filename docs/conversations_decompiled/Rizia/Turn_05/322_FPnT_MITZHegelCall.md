# Rizia/Turn 5/FPnT_MITZHegelCall

- **ID konwersacji:** `322`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Rizia/Turn_05/322_FPnT_MITZHegelCall.md`
- **Liczba węzłów dialogowych:** 780
- **Liczba wyborów gracza:** 229

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[78]** Emmerich Hegel (R)
- **[90]** Bruno
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.BrunoDog_SleepsInBed`
- `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal`
- `RiziaDLC.Diplomacy_Lespia_PromiseITZSupport`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech`
- `RiziaDLC.InvestigatePoisoning_NoPabel`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Lucita_CompromisingPhoto`
- `RiziaDLC.Military_Valgsland_AcceptNavalAid`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.PoisonInvestigator_Lucita`
- `RiziaDLC.PoisonInvestigator_Titus`
- `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries`
- `RiziaDLC.Prologue_HadAffairs`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Relations_Manus_ConstitutionalMonarchy`
- `RiziaDLC.Relations_Manus_OverthrowMonarchy`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Pabel_OutedEarly`
- `RiziaDLC.Relations_Pabel_OutedToPlayer`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Relations_Pabel_YourMajesty`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Trait_CommieKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Turn02_Intention_ConstitutionalMonarchy`
- `RiziaDLC.Turn05_ITZVote_Nationalization`
- `RiziaDLC.Turn05_ITZVote_StatusQuo`
- `RiziaDLC.Turn05_MurderInvest_SuspectPabel`
- `RiziaDLC.Vina_OnCouncil`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Valgsland_PromiseITZTakeover`
- `RiziaDLC.Hegel_OpenToRevolution`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Military_Valgsland_AcceptNavalAid`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Pabel_OutedToPlayer_PabelKnows`
- `RiziaDLC.ToldAboutComradeVina`
- `RiziaDLCSupport.Journal_Turn05_Valgsland_AcceptAid`
- `RiziaDLCSupport.Journal_Turn05_Valgsland_PromiseLespiaOutofMITZ`
- `RiziaDLCSupport.News_Turn05_G_ValgslandANSupport`
- `RiziaDLCSupport.Reports_Turn05_Morella_MITZ_NationalizationInvite`
- `RiziaDLCSupport.Reports_Turn05_Morella_MITZ_RenegotiationInvite`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 17
- **Węzły modyfikujące stan gry:** 20

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Pabel_OutedToPlayer_PabelKnows`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[295]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] - 2;`
- Węzeł `[386]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Valgsland_PromiseITZTakeover"] = true; Variable["RiziaDLCSupport.Jou...`
- Węzeł `[387]` (Paskal Beniwoll): `Variable["RiziaDLC.Military_Valgsland_AcceptNavalAid"] = true; Variable["RiziaDLCSupport.Journal_...`
- Węzeł `[423]` (Paskal Beniwoll): `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- Węzeł `[632]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Valgsland_PromiseITZTakeover"] = true; Variable["RiziaDLC.Military_V...`
- Węzeł `[686]` (Paskal Beniwoll): `Variable["RiziaDLC.ToldAboutComradeVina"] = true;`
- Węzeł `[745]` (Paskal Beniwoll): `End();`
- Węzeł `[746]` (Paskal Beniwoll): `--;`
- *...oraz 12 innych węzłów ze skryptami.*

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
  - -> `[778]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "In the middle of the night, I was woken up by a knock on my bedroom door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[7]`
Mówca: **Narrator**
> "Bruno was lying at the foot of my bed. He sat upright."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_SleepsInBed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_SleepsInBed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_SleepsInBed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Narrator**
> "Bruno sat upright in his dog bed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]`

### Węzeł `[12]`
Mówca: **Narrator**
> "I heard Pabel's voice in the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Pabel Adria**
> ""Easy, boy. It's only me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_YourMajesty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_YourMajesty == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_YourMajesty == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Pabel Adria**
> ""Sorry to wake you, Your Majesty, but there's an apparently urgent call for you downstairs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[18]`
Mówca: **Pabel Adria**
> ""Sorry, Romus, but there's an apparently urgent call for you downstairs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[19]`
Mówca: **Narrator**
> "I heard Pabel's voice in the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[20]`
Mówca: **Narrator**
> "We walked through the palace corridors until we reached my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]`

### Węzeł `[21]`
Mówca: **Narrator**
> "An attendant stood ready with the blue phone. He informed me that Chancellor Emmerich Hegel was on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right. Come in and help me get dressed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll be right out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[24]`
Mówca: **Narrator**
> "Pabel opened the door. Bruno jumped up on him, tail wagging."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[28]`
Mówca: **Pabel Adria**
> ""Someone's happy to see me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`
  - -> `[38]`

### Węzeł `[29]`
Mówca: **Narrator**
> "I quickly dressed and joined Pabel in the hallway. Bruno let out a whine of disappointment as I shut him back in the bedroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[99]`
  - -> `[91]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Narrator**
> "I quickly dressed and joined Pabel in the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[99]`
  - -> `[91]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So, it's been a while since Qalus...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[35]`
Mówca: **Narrator**
> "Pabel opened the door and briskly made his way over to the armoire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`
  - -> `[39]`
  - -> `[43]`
  - -> `[42]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd wag my tail if I had one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who wouldn't be happy to see you, Pabel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bad dog, Bruno! Sit!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are you, Pabel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What am I wearing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[44]`
Mówca: **Narrator**
> "Pabel turned around and gave me a strained look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Pabel Adria**
> ""I'm well, {RiziaDLCText.PabelToPlayer}.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[103]`
  - -> `[102]`

### Węzeł `[46]`
Mówca: **Pabel Adria**
> ""It's quite an urgent phone call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[47]`
Mówca: **Narrator**
> "Bruno sat down. Pabel gave him a pat on the head and briskly moved over to the armoire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`
  - -> `[39]`
  - -> `[43]`
  - -> `[42]`

### Węzeł `[48]`
Mówca: **Narrator**
> "Pabel let out a short laugh, then briskly moved over to the armoire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`
  - -> `[39]`
  - -> `[43]`
  - -> `[42]`

### Węzeł `[49]`
Mówca: **Narrator**
> "Pabel didn't smile. He briskly moved over to the armoire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`
  - -> `[39]`
  - -> `[43]`
  - -> `[42]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel >= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel >= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel >= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[53]`
Mówca: **Pabel Adria**
> ""It's only a phone call. A simple robe and slippers should do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Narrator**
> "He pulled a deep blue silk robe out of the armoire. I stood in front of him as he draped it over my shoulders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Narrator**
> "He tied the sash, allowing his fingers to brush lightly against my waist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[87]`
  - -> `[76]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "Grab his hands."]** — Mówca: **Player_Romus_Italic**
> "I stopped him and grabbed his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`
  - -> `[63]`

### Węzeł `[60]`
Mówca: **Narrator**
> "Once I was dressed, we walked through the palace corridors until we reached my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't stop thinking about our night together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""When can we see each other again? And by 'see', I mean...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why are you being so distant to me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[64]`
Mówca: **Narrator**
> "He took a step closer to me and spoke in a low voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Pabel Adria**
> ""Neither can I. But we can't carry on like that here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Pabel Adria**
> ""As a servant, I'm used to creeping around in the shadows. But the King is always in the spotlight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`
  - -> `[71]`
  - -> `[73]`

### Węzeł `[67]`
Mówca: **Pabel Adria**
> ""I haven't forgotten about Qalus. But we can't carry on like that here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[68]`
Mówca: **Narrator**
> "He took a step closer to me and spoke in a low voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am the ruler of this country. I shouldn't have to hide my proclivities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll come up with a cover story. You sleep in my room to help me with my night terrors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. How much 'creeping around' have you done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've done some creeping of my own, you know. But it was easier as a prince.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HadAffairs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HadAffairs == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HadAffairs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HadAffairs == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HadAffairs"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
**[WYBÓR GRACZA: "Let him finish dressing you."]** — Mówca: **Player_Romus_Italic**
> "I didn't react. He tightened the sash and handed me my slippers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[77]`
Mówca: **Pabel Adria**
> ""I'll be under extra scrutiny now because of your investigation. We need to be careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[143]`
  - -> `[144]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true) && RiziaDLC.InvestigatePoisoning_NoPabel == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true) && RiziaDLC.InvestigatePoisoning_NoPabel == false)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true) && RiziaDLC.InvestigatePoisoning_NoPabel == false))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[81]`
Mówca: **Pabel Adria**
> ""Enough to know that passion can compromise caution to a dangerous degree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[82]`
Mówca: **Pabel Adria**
> ""It's not just a proclivity,{RiziaDLCText.PabelToPlayer}, it's a crime. Being found out could land us both in prison or worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[83]`
Mówca: **Pabel Adria**
> ""Yes, you're under much more scrutiny now. There are eyes everywhere here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[84]`
Mówca: **Pabel Adria**
> ""I don't want to subject you to that risk, {RiziaDLCText.PabelToPlayer}.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[85]`
Mówca: **Pabel Adria**
> ""I don't think anyone suspects anything yet. But we need to be careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[143]`
  - -> `[144]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There must be some way we can meet in total secrecy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Careful there. I wouldn't want impure thoughts distracting me from my meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Narrator**
> "The shadow of a smile passed across his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Pabel Adria**
> ""My deepest apologies, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[90]`
Mówca: **Narrator**
> "He tightened the sash and smoothed out the robe's folds, letting his hands linger on me for just a moment longer than necessary."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`
  - -> `[152]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are you, Pabel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So, it's been a while since Qalus...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[96]`
Mówca: **Narrator**
> "Pabel glanced behind us, then spoke in a low voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Pabel Adria**
> ""Another time, Your Majesty. Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[98]`
Mówca: **Pabel Adria**
> ""I'm well, {RiziaDLCText.PabelToPlayer}.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[123]`
  - -> `[122]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Any idea what this call is about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Narrator**
> "Pabel shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Pabel Adria**
> ""It's on the blue phone, so it's a world leader. Your aide will have more information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's all I get?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glad to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Any palace intrigue I need to know about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel <= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel <= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Pabel Adria**
> ""No, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true && RiziaDLC.Lucita_CompromisingPhoto == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true && RiziaDLC.Lucita_CompromisingPhoto == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true  and  Variable["RiziaDLC.Lucita_CompromisingPhoto"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true && RiziaDLC.Lucita_CompromisingPhoto == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true  and  Variable["RiziaDLC.Lucita_CompromisingPhoto"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[112]`
Mówca: **Pabel Adria**
> ""Well, the entire staff knows about you and Duchess Azaro. But I assume you weren't trying to keep that a secret.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[113]`
Mówca: **Pabel Adria**
> ""Thankfully, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel >= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel >= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel >= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Pabel Adria**
> ""You've got an important phone call. I shouldn't bore you with irrelevant details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[121]`
Mówca: **Pabel Adria**
> ""I would prefer my personal life to remain private, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's all I get?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glad to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Any palace intrigue I need to know about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel <= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel <= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[128]`
Mówca: **Pabel Adria**
> ""No, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[129]`
Mówca: **Pabel Adria**
> ""Well, the entire staff knows about you and Duchess Azaro. But I assume you weren't trying to keep that a secret.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[130]`
Mówca: **Pabel Adria**
> ""Thankfully, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[131]`
Mówca: **Pabel Adria**
> ""I would prefer my personal life to remain private, Your Majesty. My apologies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel >= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel >= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel >= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[141]`
Mówca: **Pabel Adria**
> ""You've got an important phone call. I shouldn't bore you with irrelevant details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[142]`
Mówca: **Pabel Adria**
> ""Only the usual nonsense. Everyone's still speculating about Her Highness' marriage prospects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This isn't right, damn it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right, of course. I shouldn't sabotage my reign over a misguided dalliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[145]`
Mówca: **Pabel Adria**
> ""It's the way that it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Pabel Adria**
> ""Our time will come someday. But not yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[147]`
Mówca: **Pabel Adria**
> ""We'll figure it out. But not today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[148]`
Mówca: **Pabel Adria**
> ""Not *that* misguided, I hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[149]`
Mówca: **Pabel Adria**
> ""Only the usual nonsense. Everyone's still speculating about Her Highness' marriage prospects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To be continued.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Pabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's go. I shouldn't keep this mysterious caller waiting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[153]`
**[WYBÓR GRACZA: "Pick it up."]** — Mówca: **Player_Romus_Italic**
> "I picked up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`
  - -> `[158]`

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'd better have a good reason for calling me this late, Chancellor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't expect to hear from you this soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Emmerich Hegel (R)**
> ""Is it late? I never did have a handle on the time difference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[157]`
Mówca: **Emmerich Hegel (R)**
> ""No? After the way things ended in Morella?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good evening, Mr. Hegel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Emmerich Hegel (R)**
> ""Hello, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Emmerich Hegel (R)**
> ""I'm truly sorry to disturb you at this hour. But we have unfinished business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[167]`
  - -> `[166]`
  - -> `[165]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll say. I was wondering why you never responded to my speech at the AN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your apology is not accepted. We should be speaking in daylight hours, accompanied by our staff.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_ITZVote_Nationalization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_ITZVote_Nationalization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_ITZVote_Nationalization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's too late to change my mind about the nationalization vote. What's done is done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You must be talking about the MITZ nationalization plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[172]`
Mówca: **Emmerich Hegel (R)**
> ""I appreciated your words then, Mr. Toras, but I had to find out whether they would translate into actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_ITZVote_Nationalization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_ITZVote_Nationalization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_ITZVote_Nationalization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Emmerich Hegel (R)**
> ""And they did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[177]`
Mówca: **Emmerich Hegel (R)**
> ""Alas, they did not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[178]`
Mówca: **Emmerich Hegel (R)**
> ""Of course. Needless to say, I was pleased you voted the way you did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[179]`
Mówca: **Emmerich Hegel (R)**
> ""The nationalization vote was a success. But the future of the Trade Zone is far from decided.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[180]`
Mówca: **Emmerich Hegel (R)**
> ""Yes, the vote has concluded. But the future of the MITZ is by no means set in stone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[181]`
Mówca: **Emmerich Hegel (R)**
> ""I now see a unique chance for our two very different countries to cooperate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[200]`
  - -> `[195]`

### Węzeł `[182]`
Mówca: **Emmerich Hegel (R)**
> ""I wanted to talk man to man, for reasons that shall soon become evident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_ITZVote_Nationalization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_ITZVote_Nationalization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_ITZVote_Nationalization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Emmerich Hegel (R)**
> ""The nationalization vote was unsuccessful. But the future of the Trade Zone is far from decided.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[187]`
Mówca: **Emmerich Hegel (R)**
> ""However, that does not mean an end to our chance for cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[194]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm happy to hear that. By voting for nationalization, I wanted to signal that Rizia and Valgsland are on the same side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why? I believe my vote against nationalization made my intentions clear enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm happy to hear that. I regretfully had to vote against nationalization to protect Rizia's interests, but I still think we're on the same side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, our differing opinions on the MITZ shouldn't keep us from making other agreements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have changed my mind. I don't wish to cooperate with Malenyevists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[199]`
Mówca: **Emmerich Hegel (R)**
> ""In fact, with your vote comes a unique chance for cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Democratic Republic of Valgsland would deign to cooperate with a monarchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[204]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had my reasons for choosing nationalization. Cooperating with Valgsland wasn't one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[205]`
Mówca: **Emmerich Hegel (R)**
> ""Despite your refusal to grant self-determination to Morella and its mines, I still see a chance for cooperation between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[211]`
  - -> `[212]`

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't wish to cooperate with Malenyevists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm happy to hear that. I regretfully had to vote against nationalization, but I still think we're on the same side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. Our differing opinions on the MITZ shouldn't keep us from making other agreements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Democratic Republic of Valgsland would deign to cooperate with a monarchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite both of us being in favor of nationalization, I'm skeptical we can reconcile our worldviews.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I voted for nationalization precisely so that you and I could have this conversation, Chancellor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[215]`
Mówca: **Emmerich Hegel (R)**
> ""There is only one thing we need to agree on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[216]`
Mówca: **Emmerich Hegel (R)**
> ""Any country ruled by a king is not on Valgsland's side, Mr. Toras. But there is one point we can agree on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Emmerich Hegel (R)**
> ""Our politics need not factor into this. There is only one point we have to agree on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Emmerich Hegel (R)**
> ""The Republic of Lespia does not belong in the Meftiem International Trade Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[224]`
  - -> `[227]`
  - -> `[229]`

### Węzeł `[219]`
Mówca: **Emmerich Hegel (R)**
> ""Not normally. But in this instance, there is one point we can agree on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[220]`
Mówca: **Emmerich Hegel (R)**
> ""Do not think that this somehow makes us allies, Mr. Toras. But there is one point we can both agree on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[221]`
Mówca: **Emmerich Hegel (R)**
> ""We do not have to like each other, Mr. Toras. There is only one point we have to agree on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Another east-west battle? You should know that as a member of GRACE, Rizia is obliged to stay uninvolved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. The future of the MITZ belongs to the workers and those who support them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right about that. Prime Minister Alvarez's behavior during the meeting was appalling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's simply not true. Lespia has played and will continue to play an integral role in Trade Zone operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not a fan of Lespia's profit-mongering either, but stripping them of their assets could be dangerous for everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[230]`
Mówca: **Emmerich Hegel (R)**
> ""Uh huh. The way Rumburg was uninvolved in the Wehlen Civil War?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[231]`
Mówca: **Emmerich Hegel (R)**
> ""Well... yes. I'm glad you agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[232]`
Mówca: **Emmerich Hegel (R)**
> ""We are trying to build a new ITZ. One that is not corrupted by western greed or selfish protectionist policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`
  - -> `[256]`

### Węzeł `[233]`
Mówca: **Emmerich Hegel (R)**
> ""There is no 'uninvolved', Mr. Toras. Either you are with us, or you are against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[240]`
  - -> `[241]`

### Węzeł `[234]`
Mówca: **Emmerich Hegel (R)**
> ""As much as I personally dislike the man, he is a mere symptom of the disease called capitalism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[256]`
  - -> `[255]`

### Węzeł `[235]`
Mówca: **Emmerich Hegel (R)**
> ""You know what's dangerous? Allowing Lespia's selfish protectionist policies to slowly corrupt the new Trade Zone we are trying to build.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[256]`
  - -> `[255]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel >= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel >= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel >= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[239]`
Mówca: **Narrator**
> "He acknowledged my remark with a smile, then briskly moved over to the armoire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`
  - -> `[39]`
  - -> `[42]`

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I voted for nationalization. That alone should prove where my values lie.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't believe that. Rizia doesn't need to take any sides.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want to side with you. But the repercussions with our allies would be too great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Emmerich Hegel (R)**
> ""I am not asking you to openly side with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[244]`
Mówca: **Emmerich Hegel (R)**
> ""I know that Prime Minister Saltana is meeting individually with you and Prime Minister Alvarez to come up with a nationalization plan for the MITZ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[245]`
Mówca: **Emmerich Hegel (R)**
> ""Yes, that alone was more than I expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[246]`
Mówca: **Emmerich Hegel (R)**
> ""Allow me to explain what I want. Then we can discuss your supposed impartiality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[247]`
Mówca: **Emmerich Hegel (R)**
> ""You, King Romus, will not let that happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[249]`
  - -> `[251]`
  - -> `[259]`
  - -> `[747]`

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know if I can. Lespia has a lot to offer Morella.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have Prime Minister Saltana's ear. Why don't you just try to convince her to give Lespia the boot?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[250]`
Mówca: **Emmerich Hegel (R)**
> ""Lespia will do everything in its power to keep its operations running exactly as before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's easy. I was planning on making sure Lespia got the short end of the scepter anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And how do you suggest we do that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But with Morella exercising central control over the MITZ, there'll be a limit to how much harm Lespia can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Emmerich Hegel (R)**
> ""That would be the ideal scenario. But Alvarez is very capable of weaseling out of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And how do you suggest we stop it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As Alvarez said, the MITZ would be nothing without Lespian mining technology. We can't ignore his country's contribution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
Mówca: **Emmerich Hegel (R)**
> ""Mining technology is worthless if the people operating it are being exploited.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have a gas deal with Lespia. It wouldn't be wise to antagonize them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[262]`
Mówca: **Emmerich Hegel (R)**
> ""Then we see eye to eye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[263]`
Mówca: **Emmerich Hegel (R)**
> ""At the end of the day, I am only asking Rizia to act in its best interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[270]`
  - -> `[274]`
  - -> `[275]`

### Węzeł `[264]`
Mówca: **Emmerich Hegel (R)**
> ""Valgsland's relationship with Morella is still young and fragile. I do not want us to be accused of overreach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[265]`
Mówca: **Emmerich Hegel (R)**
> ""You are Morella's direct neighbor and longtime ally. Ms. Saltana will surely be receptive to your offers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[266]`
Mówca: **Emmerich Hegel (R)**
> ""Do not let the deal fool you. Alvarez will stab you in the back at the slightest opportunity, especially after your board vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[267]`
Mówca: **Emmerich Hegel (R)**
> ""Rizia, on the other hand, is Morella's direct neighbor and longtime ally. It's only natural that you would request a more favorable deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Outbidding Lespia may be in our best interests, but it will take a lot of resources. What can Valgsland offer us if I make this happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not only about Rizia's interests. We need Lespia out for the good of the entire ITZ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would certainly be advantageous for Rizia to keep its foothold in the MITZ. If we end up with more than Lespia, so much the better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are suggesting that we act with the same greed you are accusing Lespia of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not in our best interests to anger our powerful neighbor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[276]`
Mówca: **Emmerich Hegel (R)**
> ""I'm glad you agree. But I am happy to throw in another incentive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[277]`
Mówca: **Emmerich Hegel (R)**
> ""A perfectly rational question, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[278]`
Mówca: **Emmerich Hegel (R)**
> ""I know it will take much work. So I am happy to offer an incentive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[279]`
Mówca: **Emmerich Hegel (R)**
> ""I can tell you are not convinced. Allow me to offer an incentive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[280]`
Mówca: **Emmerich Hegel (R)**
> ""You voted in favor of nationalization. I trust any deal you make will still preserve the welfare of the MITZ's workers and the sovereignty of Morella.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[281]`
Mówca: **Emmerich Hegel (R)**
> ""If you are still not convinced, I am happy to offer an incentive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[282]`
Mówca: **Emmerich Hegel (R)**
> ""Rizia's military weakness is no secret in international circles. Make sure Lespia ends up with nothing, and Valgsland will provide your navy with a significant upgrade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[284]`
  - -> `[285]`
  - -> `[289]`

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You dare to call us weak, Mr. Hegel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tempting. Our navy could use the help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid Valgslandian aid may be a red line for our partners in GRACE.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Emmerich Hegel (R)**
> ""Don't you think it's time to distance yourself from that network? You must know how isolated you are becoming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[328]`
  - -> `[327]`

### Węzeł `[287]`
Mówca: **Emmerich Hegel (R)**
> ""I don't need to convince you of Valgsland's dominion over the sea. Our warships and submarines are second to none.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[328]`
  - -> `[376]`
  - -> `[372]`

### Węzeł `[288]`
Mówca: **Emmerich Hegel (R)**
> ""Perhaps that was a poor choice of phrasing. But you must admit that you cannot match Valgsland's dominion over the sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[330]`
  - -> `[328]`
  - -> `[376]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're offering us a naval upgrade while we have forces stationed around a disputed gas field?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Emmerich Hegel (R)**
> ""Why, yes. Perhaps Valgsland's superior vessels and equipment can help you solve that dispute faster.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[376]`
  - -> `[372]`
  - -> `[331]`

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have had it with your disrespect. Remember that you are speaking to a king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist -= 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Emmerich Hegel (R)**
> ""Ha! Such titles mean nothing to me, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Emmerich Hegel (R)**
> ""Why should I respect you, when you don't respect the will of your own people?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[308]`
  - -> `[309]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Religious"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Religious > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Religious"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Emmerich Hegel (R)**
> ""Why should I respect a man who sits on a golden throne, surrounded by riches he did not earn?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[309]`
  - -> `[312]`
  - -> `[322]`

### Węzeł `[305]`
Mówca: **Emmerich Hegel (R)**
> ""Why should I respect a man who takes orders from some invisible being in the sky?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[309]`
  - -> `[306]`
  - -> `[307]`

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you demeaning the Holy Spirit of St. Dast?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Religion guides my decisions, yes, but I do not 'take orders' from anyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Like it or not, we are both world leaders. A little more decorum is in order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Because I'm holding the cards. You're the one calling me in the middle of the night, remember?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Take that back this instant. My people love me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[311]`
Mówca: **Narrator**
> "There was a brief silence on the other end as Hegel seemed to collect himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My family earned everything we have. With the help of the Valgos Empire, I might add.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are right. And in fact, I am trying to change the role of the monarchy in Rizia. Maybe you can help me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[314]`
Mówca: **Emmerich Hegel (R)**
> ""Very well. I am sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[315]`
Mówca: **Emmerich Hegel (R)**
> ""But please tell me. Can I count on your cooperation in the MITZ, or not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`
  - -> `[337]`
  - -> `[336]`

### Węzeł `[316]`
Mówca: **Emmerich Hegel (R)**
> ""Your people live in fear of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[317]`
Mówca: **Narrator**
> "There was a brief pause on the other end of the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Emmerich Hegel (R)**
> ""Whatever you want to call it, it should be completely separate from state matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[319]`
Mówca: **Emmerich Hegel (R)**
> ""Sorry to wake you, Mr. Toras. This call was a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`
  - -> `[353]`
  - -> `[354]`

### Węzeł `[320]`
Mówca: **Emmerich Hegel (R)**
> "'Even the smallest role played by religion in state matters is too large.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[321]`
Mówca: **Emmerich Hegel (R)**
> ""The Valgos Empire is dead and gone. As the Kingdom of Rizia should be, by all rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[325]`
Mówca: **Narrator**
> "There was a brief pause on the other end of the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Emmerich Hegel (R)**
> ""Maybe I can. But for now, I want to know whether or not I can count on your cooperation in the MITZ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`
  - -> `[337]`
  - -> `[336]`

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Eventually, perhaps. But not with such a dramatic action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Regardless, I am worried that accepting your republic's military assistance will send the wrong signal internationally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Emmerich Hegel (R)**
> ""Voting for ITZ nationalization already aligned you with Valgsland. You may as well take advantage of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I'm going to anger Lespia even further than I have already, it wouldn't hurt to have a stronger navy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It'll send a strong signal. Too strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[332]`
Mówca: **Emmerich Hegel (R)**
> ""If not now, then when?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[333]`
Mówca: **Emmerich Hegel (R)**
> ""That's the right idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. In exchange for your promised military aid, I will make sure Lespia walks away with nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can. But I'm not accepting your offer of naval reinforcements. Removing Lespian influence from the MITZ is enough of an incentive for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, but I can't promise you anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Given the magnitude of Lespia's investments in the MITZ, I can't go along with your plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[338]`
Mówca: **Emmerich Hegel (R)**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[339]`
Mówca: **Emmerich Hegel (R)**
> ""I am glad to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[340]`
Mówca: **Emmerich Hegel (R)**
> ""No? That's a shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[341]`
Mówca: **Emmerich Hegel (R)**
> ""For a moment, I thought we had an understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[342]`
Mówca: **Emmerich Hegel (R)**
> ""What a shame. But I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[343]`
Mówca: **Emmerich Hegel (R)**
> ""And my offer will remain open should you change your mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[344]`
Mówca: **Emmerich Hegel (R)**
> ""I will be sure to keep abreast of the negotiations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[345]`
Mówca: **Emmerich Hegel (R)**
> ""I wish you luck regardless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[346]`
Mówca: **Narrator**
> "There was a silence, so long I began to think he had hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]`

### Węzeł `[347]`
Mówca: **Emmerich Hegel (R)**
> ""You might want to know that I have been contacted by your daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`
  - -> `[379]`
  - -> `[380]`
  - -> `[381]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Trait_CommieKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`
  - -> `[350]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Trait_CommieKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Trait_CommieKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Trait_CommieKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Trait_CommieKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[351]`
Mówca: **Emmerich Hegel (R)**
> ""I may be overstepping my boundaries. But I cannot shake the feeling that you and I want the same thing for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're only now realizing that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. I do want to help squeeze Lespia out of the Trade Zone. You can count on my cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Until you treat the Rizian monarchy with more deference, we will remain at odds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[355]`
Mówca: **Emmerich Hegel (R)**
> ""Yes. Silly me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[356]`
Mówca: **Emmerich Hegel (R)**
> ""Good, Mr. Toras. But do not expect any military aid from Valgsland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[357]`
Mówca: **Emmerich Hegel (R)**
> ""Then we will be at odds for eternity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[358]`
Mówca: **Emmerich Hegel (R)**
> ""Good night. And give my regards to the Princess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[364]`
  - -> `[366]`
  - -> `[367]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`
  - -> `[361]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Emmerich Hegel (R)**
> ""Good night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
  - -> `[366]`
  - -> `[367]`

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To Vina? Why?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[364]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's 'Good night, *Your Majesty*'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for calling nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Until next time, Chancellor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[368]`
Mówca: **Narrator**
> "He hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[746]`

### Węzeł `[369]`
Mówca: **Emmerich Hegel (R)**
> ""You have already deployed your military to the Antacean. No use in half measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[370]`
Mówca: **Emmerich Hegel (R)**
> ""You are a rational man. You must admit that the monarchical system belongs in the dustbin of history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`
  - -> `[416]`
  - -> `[417]`
  - -> `[420]`

### Węzeł `[371]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's almost as if you want to help Rizia retake Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[375]`
Mówca: **Emmerich Hegel (R)**
> ""Yes. Almost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My councilors were already against ITZ nationalization. They will certainly be against further cooperation with Valgsland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[377]`
Mówca: **Emmerich Hegel (R)**
> ""You're the king, aren't you? You make the decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not surprising. She goes where her intellectual curiosity takes her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, Chancellor. The princess can be a real brat sometimes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So *that*'s what she's been doing during my council meetings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[381]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What?! You are to cease your communication with her at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_CommieKing == true && RiziaDLC.Military_Valgsland_AcceptNavalAid == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_CommieKing == true && RiziaDLC.Military_Valgsland_AcceptNavalAid == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_CommieKing"] == true  and  Variable["RiziaDLC.Military_Valgsland_AcceptNavalAid"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_CommieKing == true && RiziaDLC.Military_Valgsland_AcceptNavalAid == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_CommieKing"] == true  and  Variable["RiziaDLC.Military_Valgsland_AcceptNavalAid"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[385]`
Mówca: **Narrator**
> "There was a silence, so long I began to think he had hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Valgsland_PromiseITZTakeover = true; RiziaDLCSupport.Journal_Turn05_Valgsland_PromiseLespiaOutofMITZ = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Valgsland_PromiseITZTakeover"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Valgsland_PromiseLespiaOutofMITZ"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Military_Valgsland_AcceptNavalAid = true; RiziaDLCSupport.Journal_Turn05_Valgsland_AcceptAid = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Military_Valgsland_AcceptNavalAid"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Valgsland_AcceptAid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[388]`
Mówca: **Emmerich Hegel (R)**
> ""She certainly is curious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[389]`
Mówca: **Emmerich Hegel (R)**
> ""On the contrary. She's got a brilliant mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[390]`
Mówca: **Emmerich Hegel (R)**
> ""If you're not involving the Princess in politics, you should be. She has a brilliant mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Emmerich Hegel (R)**
> ""Why? From her letters and our conversation, I have the sense that the two of you want the same thing for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[392]`
Mówca: **Emmerich Hegel (R)**
> ""And from my communications, I have the sense that both of you want the same thing for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[393]`
Mówca: **Emmerich Hegel (R)**
> ""Changes. Big ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`
  - -> `[636]`
  - -> `[639]`
  - -> `[641]`

### Węzeł `[394]`
Mówca: **Emmerich Hegel (R)**
> ""Goodnight, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`
  - -> `[396]`
  - -> `[397]`
  - -> `[398]`

### Węzeł `[395]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't need to call me that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[396]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now *there's* the respect I deserve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[397]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Until next time, comrade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Goodnight, Mr. Hegel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[399]`
Mówca: **Emmerich Hegel (R)**
> ""Don't get me wrong -- I despise monarchies. But I do occasionally wonder whether my job would be easier if I could sidestep the government infighting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`
  - -> `[401]`
  - -> `[405]`

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should try it. It's great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`
  - -> `[403]`

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[403]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Disagreement is part of any healthy government. Monarchical or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[405]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A paradox, isn't it? The more opinions you entertain in the name of representation, the harder it is to give your people what they actually need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[406]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't act with total impunity. My hands are tied by royal tradition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[407]`
Mówca: **Emmerich Hegel (R)**
> ""That tradition was established by men in your exact same position. You have the power to break it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[408]`
Mówca: **Emmerich Hegel (R)**
> ""Yet the longer one holds absolute power, the further one becomes distanced from those needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[409]`
Mówca: **Emmerich Hegel (R)**
> ""Ha. No, in the end I would never allow myself to override my government's checks and balances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[410]`
Mówca: **Emmerich Hegel (R)**
> ""You're correct, of course. Just an idle musing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[411]`
Mówca: **Emmerich Hegel (R)**
> ""You can expect the delivery of new vessels and equipment as soon as the nationalization agreement is finalized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[412]`
Mówca: **Emmerich Hegel (R)**
> ""Can I count on your cooperation or not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`
  - -> `[337]`
  - -> `[336]`

### Węzeł `[413]`
Mówca: **Emmerich Hegel (R)**
> ""But enough about our governments. I want to know whether I can count on your cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`
  - -> `[337]`
  - -> `[336]`

### Węzeł `[414]`
Mówca: **Emmerich Hegel (R)**
> ""Just tell me. Can I count on your cooperation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`
  - -> `[337]`
  - -> `[336]`

### Węzeł `[415]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are going too far, Mr. Hegel. You shall speak to me with the respect a king deserves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I disagree. In fact, a truly benevolent king can meet his people's needs more efficiently than a squabbling parliament.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even if I agreed with you, cutting ties with Rumburg would be a disaster for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, combining a democratic system with the benefits of having a reigning sovereign seems like the best of both worlds to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[419]`
Mówca: **Emmerich Hegel (R)**
> ""Or an opportunity for new connections. Ones that will bind you with Merkopa's future, not its past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`
  - -> `[422]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[423]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[424]`
Mówca: **Emmerich Hegel (R)**
> ""No man or woman should be placed above all others, even symbolically.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[425]`
Mówca: **Emmerich Hegel (R)**
> ""I wouldn't say that. But there's one point on which we may agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[426]`
Mówca: **Emmerich Hegel (R)**
> ""Regretfully, yes But there's still one point on which we may agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[427]`
Mówca: **Emmerich Hegel (R)**
> ""I am happy you see it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[428]`
Mówca: **Emmerich Hegel (R)**
> ""And I with monarchies. But there is one point on which we may agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[429]`
Mówca: **Emmerich Hegel (R)**
> ""Normally, no. But there is one point on which we may agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[430]`
Mówca: **Emmerich Hegel (R)**
> ""Different as we are, there is one point on which we may agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[431]`
Mówca: **Emmerich Hegel (R)**
> ""The Republic of Lespia does not belong in the Meftiem International Trade Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`
  - -> `[434]`
  - -> `[433]`
  - -> `[441]`

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Another east-west battle? You should know that as a member of GRACE, Rizia is obliged to stay uninvolved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[433]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree that Prime Minister Alvarez's behavior during the meeting was appalling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[434]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are wrong about that. Lespia has played and will continue to play an integral role in Trade Zone operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[435]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You heard what I said in the meeting. Neither Lespia nor Rizia will accept any change in the way the MITZ is run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[436]`
Mówca: **Emmerich Hegel (R)**
> ""Uh huh. The way Rumburg was uninvolved in the Wehlen Civil War?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[437]`
Mówca: **Emmerich Hegel (R)**
> ""And Rizia? What about you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`
  - -> `[457]`

### Węzeł `[438]`
Mówca: **Emmerich Hegel (R)**
> ""There is no 'uninvolved', Mr. Toras. Either you are on the side of the working man, or you are against him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`
  - -> `[445]`
  - -> `[444]`

### Węzeł `[439]`
Mówca: **Emmerich Hegel (R)**
> ""As much as I personally dislike the man, he is a mere symptom of the disease called capitalism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`
  - -> `[456]`
  - -> `[645]`

### Węzeł `[440]`
Mówca: **Emmerich Hegel (R)**
> ""Yet Morella and Valgsland will not accept the status quo. So what are we to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`
  - -> `[463]`
  - -> `[464]`
  - -> `[465]`

### Węzeł `[441]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_ITZVote_StatusQuo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`
  - -> `[443]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_ITZVote_StatusQuo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_ITZVote_StatusQuo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_ITZVote_StatusQuo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_ITZVote_StatusQuo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[444]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Him... or her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't believe that. One can sympathize with the plight of the working man without going full-on revolutionary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I suppose I am against him. Sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[447]`
Mówca: **Emmerich Hegel (R)**
> ""Yes, yes, that goes without saying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[448]`
Mówca: **Emmerich Hegel (R)**
> ""I don't think you understand what's happening right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[449]`
Mówca: **Emmerich Hegel (R)**
> ""Sympathize, perhaps. Improve, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia and Lespia will stand together in preserving the status quo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_ITZVote_StatusQuo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`
  - -> `[453]`

### Węzeł `[452]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_ITZVote_StatusQuo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_ITZVote_StatusQuo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[453]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_ITZVote_StatusQuo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_ITZVote_StatusQuo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We want better conditions for Morellan workers. But not at the expense of Rizian or Lespian interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not to mention alcoholism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's where we disagree. I don't like Alvarez as a person, but we are fighting for the same principles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Like Lespia, we are committed to working together with Morella to build a more equitable ITZ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[458]`
Mówca: **Emmerich Hegel (R)**
> ""Let me lay it out for you, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[459]`
Mówca: **Emmerich Hegel (R)**
> ""Prime Minister Saltana is planning to reopen negotiations on the MITZ profit-sharing agreement. Any new version will have to be approved by three out of the four countries on the board.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[460]`
Mówca: **Emmerich Hegel (R)**
> ""Say you wanted to make an agreement where Lespia came away with nothing. As long as Valgsland approved it, it would still pass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[461]`
Mówca: **Emmerich Hegel (R)**
> ""Do you understand what I'm saying?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`
  - -> `[473]`
  - -> `[474]`
  - -> `[479]`

### Węzeł `[462]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What exactly do you want, Mr. Hegel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[463]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Obviously, either Valgsland or Morella must make a compromise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[464]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know. Go to war?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[465]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stay in a stalemate until one country caves. But it won't be Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[466]`
Mówca: **Emmerich Hegel (R)**
> ""And we are willing to do so. Under one condition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[467]`
Mówca: **Emmerich Hegel (R)**
> ""Please, Mr. Toras. Rizia is not in any position to start a war with anyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[468]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`
  - -> `[470]`

### Węzeł `[469]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[471]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You want me to screw over my business partner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[472]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You want me to screw Mr. Alvarez over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[473]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Please explain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[474]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have Prime Minister Saltana's ear. Why aren't you saying this to her?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[475]`
Mówca: **Emmerich Hegel (R)**
> ""Valgsland's relationship with Morella is still young and fragile. I do not want us to be accused of overreach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[476]`
Mówca: **Emmerich Hegel (R)**
> ""Rizia, on the other hand, is Morella's direct neighbor and longtime ally. It's only natural that you would request a more favorable deal than Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[477]`
Mówca: **Emmerich Hegel (R)**
> ""Make no mistake. Alvarez will do exactly the same thing if given the slightest opportunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[478]`
Mówca: **Emmerich Hegel (R)**
> ""I wouldn't call it a 'partnership'. Alvarez will do exactly the same thing if given the slightest opportunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[479]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think I know what you're getting at. And I like it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[480]`
Mówca: **Emmerich Hegel (R)**
> ""Both of you will soon be invited to Morella for negotiations. I want you to make sure Lespia receives as small of a share as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[481]`
Mówca: **Emmerich Hegel (R)**
> ""At the end of the day, I am only asking you to act in Rizia's best interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`
  - -> `[485]`
  - -> `[511]`
  - -> `[489]`

### Węzeł `[482]`
Mówca: **Emmerich Hegel (R)**
> ""You'll be invited to Morella for negotiations soon. I want you to make sure Lespia receives as small of a share as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[483]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am all for trying to out-negotiate Lespia, but I'm afraid Rizia doesn't have the resources. Can you offer us any help?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not only about Rizia. We need to limit Arcasian influence in the Trade Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[485]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`
  - -> `[487]`

### Węzeł `[486]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[487]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[488]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would certainly be advantageous for Rizia to keep our share of ITZ profits. If we end up with more than Lespia, so much the better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[489]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's in our interests to work out a deal with Lespia and Morella. Valgsland's input is irrelevant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[490]`
Mówca: **Emmerich Hegel (R)**
> ""Approving the final agreement will be help enough, I should think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[491]`
Mówca: **Emmerich Hegel (R)**
> ""I'm glad you see it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[492]`
Mówca: **Emmerich Hegel (R)**
> ""Don't get too greedy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[493]`
Mówca: **Emmerich Hegel (R)**
> ""Oh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[494]`
Mówca: **Emmerich Hegel (R)**
> ""Needless to say, we still expect that you will make up for the way Rizia treated Morella over the years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`
  - -> `[498]`
  - -> `[499]`

### Węzeł `[495]`
Mówca: **Emmerich Hegel (R)**
> ""Needless to say, we still expect that you will make up for the way Rizia treated Morella over the years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`
  - -> `[497]`
  - -> `[498]`
  - -> `[499]`

### Węzeł `[496]`
Mówca: **Emmerich Hegel (R)**
> ""Needless to say, we still expect that you will make up for the way Rizia treated Morella over the years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`
  - -> `[497]`
  - -> `[498]`
  - -> `[499]`

### Węzeł `[497]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If it means that much to you, I will make it happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[498]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll see what I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[499]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would anyway. Just because I voted against nationalization doesn't mean I'm heartless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[500]`
Mówca: **Narrator**
> "I could hear irritation in his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[501]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're in no position to make demands, Chancellor. You're the one calling me in the middle of the night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[502]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`
  - -> `[504]`

### Węzeł `[503]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[504]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[505]`
Mówca: **Emmerich Hegel (R)**
> ""No, I suppose it doesn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[506]`
Mówca: **Emmerich Hegel (R)**
> ""You denied better working conditions to your own countrymen. You'll excuse my skepticism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[507]`
Mówca: **Emmerich Hegel (R)**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[508]`
Mówca: **Emmerich Hegel (R)**
> ""It should mean something to you. If you are the benevolent leader you claim to be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[509]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[510]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's in my best interests to side with Lespia. As I have already agreed to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[511]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_PromiseITZSupport == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`
  - -> `[513]`

### Węzeł `[512]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_PromiseITZSupport == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_PromiseITZSupport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[513]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Lespia_PromiseITZSupport == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_PromiseITZSupport"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[514]`
Mówca: **Emmerich Hegel (R)**
> ""And you don't think that Lespia is angling for Morella's favor even as we speak?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[515]`
Mówca: **Emmerich Hegel (R)**
> ""If it's an incentive you want...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[516]`
Mówca: **Emmerich Hegel (R)**
> ""But I see your predicament.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[517]`
Mówca: **Emmerich Hegel (R)**
> ""Valgsland cannot publicly support a monarchy like Rizia. Especially after the way you voted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[518]`
Mówca: **Emmerich Hegel (R)**
> ""But we can sell you our naval equipment, which, as I need not remind you, is vastly superior to Rizia's own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[519]`
Mówca: **Emmerich Hegel (R)**
> ""Make sure Lespia winds up with nothing, and Valgsland will assist you with a significant upgrade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`
  - -> `[527]`
  - -> `[521]`
  - -> `[528]`

### Węzeł `[520]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you implying that our military is weak, Mr. Hegel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[521]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid Valgslandian aid would be a red line for our partners in GRACE.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[522]`
Mówca: **Emmerich Hegel (R)**
> ""It would not be aid. We would only make our vessels and equipment available for purchase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[523]`
Mówca: **Emmerich Hegel (R)**
> ""I don't need to convince you of Valgsland's dominion over the sea. Our warships and submarines are second to none.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`
  - -> `[554]`
  - -> `[555]`

### Węzeł `[524]`
Mówca: **Emmerich Hegel (R)**
> ""Excuse my phrasing. But you must admit that you cannot match Valgsland's dominion over the sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`
  - -> `[554]`
  - -> `[555]`
  - -> `[534]`

### Węzeł `[525]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're offering us a naval upgrade while we already have forces stationed around a disputed gas field?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[526]`
Mówca: **Emmerich Hegel (R)**
> ""Why, yes. Perhaps Valgsland's superior vessels and equipment can help you solve that dispute faster.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`
  - -> `[554]`
  - -> `[533]`
  - -> `[534]`

### Węzeł `[527]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tempting. Our navy could use the help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[528]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`
  - -> `[530]`

### Węzeł `[529]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[531]`
Mówca: **Emmerich Hegel (R)**
> ""Besides which, you should not care about the opinion of a group of inbred despots.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`
  - -> `[555]`
  - -> `[607]`
  - -> `[556]`

### Węzeł `[532]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, my councilors will be against any form of cooperation with Valgsland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[533]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It'll send a strong signal. Too strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[534]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`
  - -> `[536]`

### Węzeł `[535]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[536]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[537]`
Mówca: **Emmerich Hegel (R)**
> ""You have already deployed your military to the Antacean. No use in half measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[538]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's almost as if you want to help Rizia retake Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[539]`
Mówca: **Emmerich Hegel (R)**
> ""Mm. Almost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[540]`
Mówca: **Emmerich Hegel (R)**
> ""Isn't that the sole benefit of being a monarch? You can make decisions without spending months bogged down in government infighting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`
  - -> `[551]`
  - -> `[543]`

### Węzeł `[541]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should try it. It's great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[542]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Disagreement is part of any healthy government. Monarchical or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[543]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that a problem in Valgsland? Trying to please everyone, ending up pleasing no one?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[544]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't act with total impunity. My hands are tied by royal tradition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[545]`
Mówca: **Emmerich Hegel (R)**
> ""That tradition was established by men in your exact same position. You have the power to break it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[546]`
Mówca: **Emmerich Hegel (R)**
> ""It is still better than allowing unlimited power to blind you to your people's true needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[547]`
Mówca: **Emmerich Hegel (R)**
> ""Ha. No, in the end I would never allow myself to override my government's checks and balances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[548]`
Mówca: **Emmerich Hegel (R)**
> ""You're correct, of course. Just an idle musing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[549]`
Mówca: **Emmerich Hegel (R)**
> ""But enough about our governments. I want to know whether I can count on your cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`
  - -> `[612]`
  - -> `[614]`

### Węzeł `[550]`
Mówca: **Emmerich Hegel (R)**
> ""Just tell me. Can I count on your cooperation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`
  - -> `[612]`
  - -> `[614]`

### Węzeł `[551]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`
  - -> `[553]`

### Węzeł `[552]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[553]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[554]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I'm going to stab Lespia in the back, Rizia will definitely need to be able to defend itself afterwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[555]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am putting my foot down. We neither need nor want your assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[556]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You hope to win me over by demeaning me and the institution I stand for? Show some respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[557]`
Mówca: **Emmerich Hegel (R)**
> ""That's the right idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[558]`
Mówca: **Emmerich Hegel (R)**
> ""Very well. It was only an offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[559]`
Mówca: **Emmerich Hegel (R)**
> ""So can I count on your cooperation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`
  - -> `[612]`
  - -> `[614]`

### Węzeł `[560]`
Mówca: **Emmerich Hegel (R)**
> ""Why should I respect you, when you don't respect the will of your own people?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`
  - -> `[571]`
  - -> `[572]`

### Węzeł `[561]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`
  - -> `[563]`

### Węzeł `[562]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`
  - -> `[566]`

### Węzeł `[565]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Religious"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[566]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Religious > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Religious"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[567]`
Mówca: **Emmerich Hegel (R)**
> ""Why should I respect a man who sits on a golden throne, surrounded by riches he did not earn?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`
  - -> `[572]`
  - -> `[584]`
  - -> `[581]`

### Węzeł `[568]`
Mówca: **Emmerich Hegel (R)**
> ""Why should I respect a man who takes orders from some invisible being in the sky?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`
  - -> `[572]`
  - -> `[569]`
  - -> `[570]`

### Węzeł `[569]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you demeaning the Holy Spirit of St. Dast?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[570]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Religion guides my decisions, yes, but I do not 'take orders' from anyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[571]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Like it or not, we are both world leaders. A little more decorum is in order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[572]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Because I'm holding the cards. You're the one calling me in the middle of the night, remember?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[573]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Take that back this instant. My people love me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[574]`
Mówca: **Narrator**
> "There was a brief pause on the other end of the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[575]`
Mówca: **Narrator**
> "There was silence on the other end as Hegel seemed to collect himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[576]`
Mówca: **Emmerich Hegel (R)**
> ""The Valgos Empire is dead and gone. As the Kingdom of Rizia should be, by all rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[577]`
Mówca: **Emmerich Hegel (R)**
> ""I am afraid not, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`

### Węzeł `[578]`
Mówca: **Emmerich Hegel (R)**
> ""Your people live in fear of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[579]`
Mówca: **Emmerich Hegel (R)**
> ""Whatever you want to call it, it should be completely separate from state matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[580]`
Mówca: **Emmerich Hegel (R)**
> "'Even the smallest role played by religion in state matters is too large.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[581]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`
  - -> `[583]`

### Węzeł `[582]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[583]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[584]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My family earned everything we have. With the help of the Valgos Empire, I might add.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`

### Węzeł `[585]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are right. And in fact, I am trying to change the role of the monarchy in Rizia. Maybe you can help me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[586]`
Mówca: **Emmerich Hegel (R)**
> ""Very well. I am sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[587]`
Mówca: **Emmerich Hegel (R)**
> ""But if you do need a further incentive...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[588]`
Mówca: **Emmerich Hegel (R)**
> ""Sorry to wake you, Mr. Toras. This call was a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`
  - -> `[590]`
  - -> `[591]`

### Węzeł `[589]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're only now realizing that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[590]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. I do want to help squeeze Lespia out of the Trade Zone. You can count on my cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[591]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Until you treat the Rizian monarchy with more deference, we will remain at odds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[592]`
Mówca: **Emmerich Hegel (R)**
> ""Yes. Silly me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`

### Węzeł `[593]`
Mówca: **Emmerich Hegel (R)**
> ""Too late, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`

### Węzeł `[594]`
Mówca: **Emmerich Hegel (R)**
> ""Then we will be at odds for eternity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`

### Węzeł `[595]`
Mówca: **Emmerich Hegel (R)**
> ""Good night. And give my regards to the Princess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`
  - -> `[599]`
  - -> `[601]`
  - -> `[602]`

### Węzeł `[596]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`
  - -> `[598]`

### Węzeł `[597]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[598]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]`

### Węzeł `[599]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[600]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's 'Good night, *Your Majesty*'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[601]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for calling nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[602]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Until next time, Chancellor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[603]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To Vina? Why?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[604]`
Mówca: **Emmerich Hegel (R)**
> ""Good night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`
  - -> `[601]`
  - -> `[602]`

### Węzeł `[605]`
Mówca: **Narrator**
> "He hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[746]`

### Węzeł `[606]`
Mówca: **Emmerich Hegel (R)**
> ""You dare speak of respect?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[607]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One of those 'despots' is my sister-in-law. And losing her favor would be disastrous for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[608]`
Mówca: **Emmerich Hegel (R)**
> ""Or an opportunity for new connections. Ones that will bind you with Merkopa's future, not its past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[609]`
Mówca: **Emmerich Hegel (R)**
> ""Monarchist or not, you have shown me where your priorities lie.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[610]`
Mówca: **Emmerich Hegel (R)**
> ""For now, just tell me. Can I count on your cooperation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`
  - -> `[612]`
  - -> `[619]`
  - -> `[614]`

### Węzeł `[611]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can. In exchange for the navy deal you mentioned, I will shrink Lespia's share of the MITZ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`

### Węzeł `[612]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I cannot promise anything. But it's good to know that Valgsland will support Rizia getting a larger profit share.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[613]`
Mówca: **Emmerich Hegel (R)**
> ""In that case, I cannot promise anything in that arena either. I will have to see the final proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[614]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There will be no cooperation between Rizia and Valgsland, Mr. Hegel. On MITZ matters or otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[615]`
Mówca: **Emmerich Hegel (R)**
> ""I suspected as much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`

### Węzeł `[616]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`

### Węzeł `[617]`
Mówca: **Emmerich Hegel (R)**
> ""For some reason, my people are crazy about the Rizian royal family. Because of your history with the Valgos Empire, I suppose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[618]`
Mówca: **Emmerich Hegel (R)**
> ""But you're no better than Lespia. Prime Minister Saltana will see right through you both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[619]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not on this matter. But I do not wish to be on bad terms with Valgsland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`

### Węzeł `[620]`
Mówca: **Emmerich Hegel (R)**
> ""That is wise, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[621]`
Mówca: **Emmerich Hegel (R)**
> ""Thank you. I am glad this phone call was not a waste of both of our time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[622]`
Mówca: **Narrator**
> "His tone turned more conversational."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`

### Węzeł `[623]`
Mówca: **Emmerich Hegel (R)**
> ""For some reason, my people are crazy about the Rizian royal family. Because of your history with the Valgos Empire, perhaps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`
  - -> `[625]`
  - -> `[626]`
  - -> `[627]`

### Węzeł `[624]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe it's because we're so good-looking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]`

### Węzeł `[625]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Everyone loves royals, Chancellor. Even die-hard socialists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`

### Węzeł `[626]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you saying it's time to revive those old ties?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]`

### Węzeł `[627]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Funny. My people don't feel the same about Valgish aristocrats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`

### Węzeł `[628]`
Mówca: **Emmerich Hegel (R)**
> ""Because there aren't any more of them. Except the ones in Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`

### Węzeł `[629]`
Mówca: **Emmerich Hegel (R)**
> ""I'm not saying anything. Just thinking out loud.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`

### Węzeł `[630]`
Mówca: **Emmerich Hegel (R)**
> ""Your lifestyle inspires jealousy. If not your familial squabbles and the constant scrutiny you're under.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`

### Węzeł `[631]`
Mówca: **Emmerich Hegel (R)**
> ""Your Valgish genes, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`

### Węzeł `[632]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Valgsland_PromiseITZTakeover = true;
RiziaDLC.Military_Valgsland_AcceptNavalAid = true; RiziaDLCSupport.Journal_Turn05_Valgsland_AcceptAid = true; RiziaDLCSupport.Journal_Turn05_Valgsland_PromiseLespiaOutofMITZ = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Valgsland_PromiseITZTakeover"] = true;
Variable["RiziaDLC.Military_Valgsland_AcceptNavalAid"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Valgsland_AcceptAid"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Valgsland_PromiseLespiaOutofMITZ"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[633]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are sorely mistaken. Neither of us want that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[634]`
Mówca: **Emmerich Hegel (R)**
> ""You should speak with your daughter more often, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`

### Węzeł `[635]`
Mówca: **Emmerich Hegel (R)**
> ""Good night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[636]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will not speak of this again, Mr. Hegel. And you will cut off contact with Vina immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[637]`
Mówca: **Emmerich Hegel (R)**
> ""Ah. Perhaps I was mistaken about your intentions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[638]`
Mówca: **Emmerich Hegel (R)**
> ""Well, good night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[639]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We cannot have this conversation now. We must wait until the time is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`

### Węzeł `[640]`
Mówca: **Emmerich Hegel (R)**
> ""Agreed, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]`

### Węzeł `[641]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""*If* that was what I wanted, how could Valgsland help me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[642]`
Mówca: **Emmerich Hegel (R)**
> ""Later, Mr. Toras. I await the results of your visit to Morella.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]`

### Węzeł `[643]`
Mówca: **Emmerich Hegel (R)**
> ""Changes. Big ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`
  - -> `[641]`
  - -> `[644]`

### Węzeł `[644]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How dare you even suggest that? Don't make me regret working with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[645]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Capitalism is what kept the MITZ running all these years. I would not disparage it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[646]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`
  - -> `[648]`

### Węzeł `[647]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`

### Węzeł `[648]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[649]`
Mówca: **Emmerich Hegel (R)**
> ""I will, however, support Rizia in your current arbitration case against Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]`
  - -> `[652]`
  - -> `[654]`

### Węzeł `[650]`
Mówca: **Emmerich Hegel (R)**
> ""Not out of any loyalty to you, but because I believe the sovereign territory of islands must be respected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[651]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have our gratitude for that, good sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]`

### Węzeł `[652]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't need your support, Hegel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]`

### Węzeł `[653]`
Mówca: **Emmerich Hegel (R)**
> ""You're getting it anyway. If the AN decides to disrespect the sovereign territory of islands, Rizia is not the only country that will suffer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[654]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And why would that be?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`

### Węzeł `[655]`
Mówca: **Emmerich Hegel (R)**
> ""You must have some inkling why. If the AN decides to disrespect the sovereign territory of islands, Rizia is not the only country that will suffer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[656]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`
  - -> `[658]`

### Węzeł `[657]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`

### Węzeł `[658]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[659]`
Mówca: **Emmerich Hegel (R)**
> ""And incidentally, you can count on Valgsland's support in your current arbitration case against Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`
  - -> `[662]`
  - -> `[663]`

### Węzeł `[660]`
Mówca: **Emmerich Hegel (R)**
> ""I believe Rizia deserves it. But more importantly, the AN must respect the sovereign territory of islands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[661]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have our gratitude for that, good sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`

### Węzeł `[662]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're just full of favors today, aren't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`

### Węzeł `[663]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And why would that be?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]`

### Węzeł `[664]`
Mówca: **Emmerich Hegel (R)**
> ""This is no favor. If the AN decides to disrespect the sovereign territory of islands, Rizia is not the only country that will suffer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[665]`
Mówca: **Emmerich Hegel (R)**
> ""You must have some inkling why. If the AN decides to disrespect the sovereign territory of islands, Rizia is not the only country that will suffer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[666]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`
  - -> `[668]`

### Węzeł `[667]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]`

### Węzeł `[668]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[669]`
Mówca: **Emmerich Hegel (R)**
> ""Incidentally, you can count on Valgsland's support in your current arbitration case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`
  - -> `[672]`
  - -> `[673]`

### Węzeł `[670]`
Mówca: **Emmerich Hegel (R)**
> ""I believe Rizia deserves it. But more importantly, the AN must respect the sovereign territory of islands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[671]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have our gratitude for that, good sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[672]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're just full of favors today, aren't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[673]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And why would that be?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[674]`
Mówca: **Emmerich Hegel (R)**
> ""This is no favor. If the AN decides to disrespect the sovereign territory of islands, Rizia is not the only country that will suffer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[675]`
Mówca: **Emmerich Hegel (R)**
> ""You must have some inkling why. If the AN decides to disrespect the sovereign territory of islands, Rizia is not the only country that will suffer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[676]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`
  - -> `[678]`

### Węzeł `[677]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[678]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[679]`
Mówca: **Emmerich Hegel (R)**
> ""I will, however, support Rizia in your current arbitration case against Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`
  - -> `[682]`
  - -> `[684]`

### Węzeł `[680]`
Mówca: **Emmerich Hegel (R)**
> ""Not out of any loyalty to you, but because I believe the sovereign territory of islands must be respected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[681]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have our gratitude for that, good sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[682]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't need your support, Hegel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[683]`
Mówca: **Emmerich Hegel (R)**
> ""You're getting it anyway. If the AN decides to disrespect the sovereign territory of islands, Rizia is not the only country that will suffer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[684]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And why would that be?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[685]`
Mówca: **Emmerich Hegel (R)**
> ""You must have some inkling why. If the AN decides to disrespect the sovereign territory of islands, Rizia is not the only country that will suffer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[686]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ToldAboutComradeVina = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ToldAboutComradeVina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[687]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && RiziaDLC.PoisonInvestigator_Lucita == true && RiziaDLC.Relations_Pabel_OutedToPlayer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]`
  - -> `[689]`

### Węzeł `[688]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && RiziaDLC.PoisonInvestigator_Lucita == true && RiziaDLC.Relations_Pabel_OutedToPlayer == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == true  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  and  Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[689]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && RiziaDLC.PoisonInvestigator_Lucita == true && RiziaDLC.Relations_Pabel_OutedToPlayer == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == true  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  and  Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`

### Węzeł `[690]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && RiziaDLC.PoisonInvestigator_Titus == true && RiziaDLC.Relations_Pabel_OutedToPlayer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`
  - -> `[692]`

### Węzeł `[691]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && RiziaDLC.PoisonInvestigator_Titus == true && RiziaDLC.Relations_Pabel_OutedToPlayer == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == true  and  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true  and  Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]`

### Węzeł `[692]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_SuspectPabel == true && RiziaDLC.PoisonInvestigator_Titus == true && RiziaDLC.Relations_Pabel_OutedToPlayer == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == true  and  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true  and  Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[693]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita told me what you were up to the night Father died.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`

### Węzeł `[694]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus told me what you were up to the night Father died.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`

### Węzeł `[695]`
Mówca: **Narrator**
> "Pabel hurriedly draped my robe over my shoulders. He turned to face me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[696]`
Mówca: **Pabel Adria**
> ""You investigated me? I told you I was innocent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]`

### Węzeł `[697]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Innocent of murder. Guilty of sodomy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]`

### Węzeł `[698]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Right. I bet I can guess what you were tasting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]`

### Węzeł `[699]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`
  - -> `[701]`

### Węzeł `[700]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`
  - -> `[713]`
  - -> `[697]`
  - -> `[756]`

### Węzeł `[701]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`
  - -> `[706]`
  - -> `[702]`

### Węzeł `[702]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thought you were in love with me all this time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]`

### Węzeł `[703]`
Mówca: **Narrator**
> "Pabel allowed himself a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`

### Węzeł `[704]`
Mówca: **Pabel Adria**
> ""That doesn't mean I was a eunuch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[705]`
Mówca: **Pabel Adria**
> ""I don't know what you're talking about, Your Majesty. I was conducting a tasting session with a Cantuavo representative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]`
  - -> `[698]`
  - -> `[708]`

### Węzeł `[706]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's all fine. They didn't turn up any conclusive evidence against you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]`

### Węzeł `[707]`
Mówca: **Narrator**
> "Pabel let out a quiet sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[708]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care what you call it. Keep carrying on like this and I'll have you thrown in prison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]`

### Węzeł `[709]`
Mówca: **Narrator**
> "He opened his mouth in denial, then shut it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]`

### Węzeł `[710]`
Mówca: **Pabel Adria**
> ""You're right. I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[711]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's all right. Your secret is still safe with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]`

### Węzeł `[712]`
Mówca: **Narrator**
> "Pabel breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]`

### Węzeł `[713]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care what you do after hours. But you've got to be more careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[714]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_OutedEarly == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`
  - -> `[716]`

### Węzeł `[715]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_OutedEarly == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_OutedEarly"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`

### Węzeł `[716]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_OutedEarly == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_OutedEarly"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]`

### Węzeł `[717]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, Pabel. I couldn't leave any stone unturned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]`

### Węzeł `[718]`
Mówca: **Pabel Adria**
> ""Well, it's been turned now. Am I under arrest?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`
  - -> `[729]`
  - -> `[733]`

### Węzeł `[719]`
Mówca: **Narrator**
> "Pabel sighed regretfully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]`

### Węzeł `[720]`
Mówca: **Pabel Adria**
> ""Well, now you know. I was conducting a tasting session with a Cantuavo representative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]`
  - -> `[698]`

### Węzeł `[721]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_OutedEarly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]`
  - -> `[723]`

### Węzeł `[722]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_OutedEarly == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_OutedEarly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]`

### Węzeł `[723]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_OutedEarly == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_OutedEarly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]`

### Węzeł `[724]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's nothing personal. I couldn't make it look like I was playing favorites.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]`

### Węzeł `[725]`
Mówca: **Narrator**
> "Pabel sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]`

### Węzeł `[726]`
Mówca: **Pabel Adria**
> ""You're lucky they didn't turn up anything on the two of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[727]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you say so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[728]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. And the very possibility is ridiculous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]`

### Węzeł `[729]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You would be if there was more evidence. Consider yourself lucky.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]`

### Węzeł `[730]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, but the Lord knows what you did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]`

### Węzeł `[731]`
Mówca: **Pabel Adria**
> ""I'm glad you feel that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[732]`
Mówca: **Pabel Adria**
> ""Believe me, I do. Nothing like this will happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[733]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]`
  - -> `[735]`

### Węzeł `[734]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]`

### Węzeł `[735]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[736]`
Mówca: **Pabel Adria**
> ""I... I have repented since then. I swear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]`

### Węzeł `[737]`
Mówca: **Pabel Adria**
> ""Carrying on like what? If you want me to stop controlling the quality of the palace wine, I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[773]`

### Węzeł `[738]`
Mówca: **Pabel Adria**
> ""Anyway... it's quite an urgent phone call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[739]`
Mówca: **Pabel Adria**
> ""Wine, {RiziaDLCText.PabelToPlayer}. Not a difficult guess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[775]`

### Węzeł `[740]`
Mówca: **Pabel Adria**
> ""Thank you, {RiziaDLCText.PabelToPlayer}. I won't forget this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`
  - -> `[741]`
  - -> `[742]`

### Węzeł `[741]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's ludicrous. If it were a woman, you'd get a slap on the wrist at worst. But a man...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]`

### Węzeł `[742]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How many of you are out there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]`

### Węzeł `[743]`
Mówca: **Pabel Adria**
> ""It is what it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]`

### Węzeł `[744]`
Mówca: **Pabel Adria**
> ""More than you would think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]`

### Węzeł `[745]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[746]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]`

### Węzeł `[747]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You cannot order me around, Chancellor. Be more mindful of your words of choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[748]`

### Węzeł `[748]`
Mówca: **Emmerich Hegel (R)**
> ""Apologies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[749]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita is on your trail, though. Don't do anything stupid. Or anyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`

### Węzeł `[750]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]`
  - -> `[752]`

### Węzeł `[751]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]`

### Węzeł `[752]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[753]`

### Węzeł `[753]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus is on your trail, though. Don't do anything stupid. Or anyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`

### Węzeł `[754]`
Mówca: **Pabel Adria**
> ""I won't. Thank you for telling me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]`

### Węzeł `[755]`
Mówca: **Narrator**
> "He finished tying my robe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[756]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_OutedEarly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]`
  - -> `[758]`

### Węzeł `[757]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_OutedEarly == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_OutedEarly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]`

### Węzeł `[758]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_OutedEarly == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_OutedEarly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`

### Węzeł `[759]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's all right. Your secret is safe with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]`

### Węzeł `[760]`
Mówca: **Narrator**
> "His face turned pale."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[772]`

### Węzeł `[761]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Negotiations", "R_Negotiations_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Negotiations","R_Negotiations_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[762]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn05_G_ValgslandANSupport = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn05_G_ValgslandANSupport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]`

### Węzeł `[763]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]`
  - -> `[765]`

### Węzeł `[764]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]`

### Węzeł `[765]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]`

### Węzeł `[766]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_ITZVote_Nationalization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]`
  - -> `[768]`

### Węzeł `[767]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_ITZVote_Nationalization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]`

### Węzeł `[768]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_ITZVote_Nationalization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]`

### Węzeł `[769]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn05_Morella_MITZ_NationalizationInvite = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn05_Morella_MITZ_NationalizationInvite"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]`

### Węzeł `[770]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn05_Morella_MITZ_RenegotiationInvite = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn05_Morella_MITZ_RenegotiationInvite"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]`

### Węzeł `[771]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Pabel Adria");
RemoveConversant("Bruno");)*
- **Efekt (`userScript`):** `RemoveConversant("Pabel Adria");
RemoveConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[772]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel -= 3)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`

### Węzeł `[773]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel -= 3)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[774]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel -= 3)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[775]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel -= 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[776]`
Mówca: **Bruno**
> ""Rrrruff.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[777]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hegel_OpenToRevolution = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Hegel_OpenToRevolution"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`

### Węzeł `[778]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Taking a late-night call from Valgsland’s Chancellor Hegel", "Palace Rezna", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Taking a late-night call from Valgsland’s Chancellor Hegel","Palace Rezna","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]`

### Węzeł `[779]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_OutedToPlayer_PabelKnows = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel_OutedToPlayer_PabelKnows"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]`
