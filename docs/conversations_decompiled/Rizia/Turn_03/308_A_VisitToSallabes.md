# Rizia/Turn 3/A_VisitToSallabes

- **ID konwersacji:** `308`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Rizia/Turn_03/308_A_VisitToSallabes.md`
- **Liczba węzłów dialogowych:** 375
- **Liczba wyborów gracza:** 89

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[72]** Leona Sazon
- **[75]** Manus Sazon
- **[79]** Vina Toras
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.Coronation_Speech_AntiMonarchy`
- `RiziaDLC.Focus_Government_Reform`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Policy_RD_Economy_GovernmentStimulusForPeople`
- `RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed`
- `RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project`
- `RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative`
- `RiziaDLC.Policy_RD_Welfare_FreePress`
- `RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_Religious`
- `RiziaDLC.Relations_Manus_IgnoreFirstMeeting`
- `RiziaDLC.Relations_Manus_ThreatenFirstMeeting`
- `RiziaDLC.Relations_Rico_ShotDog`
- `RiziaDLC.Relations_Sazon_ManusTalkSoured`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions`
- `RiziaDLC.Turn02_Intention_ConstitutionalMonarchy`
- `RiziaDLC.Vina_OnCouncil`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Relations_Manus_ConstitutionalMonarchy`
- `RiziaDLC.Relations_Manus_OverthrowMonarchy`
- `RiziaDLC.Relations_Manus_WorkWithRPP`
- `RiziaDLC.Relations_Sazon_ManusTalkSoured`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Relations_Vina_DancedWithManus`
- `RiziaDLCSupport.Journal_Turn03_Manus_TalkedAboutReform`
- `RiziaDLCSupport.Journal_Turn03_Manus_WorkWithParty`
- `RiziaDLCSupport.News_Turn03_RH_Gossip_VinaManus`
- `RiziaDLCSupport.News_Turn03_RH_ManusSpeech`
- `RiziaDLCSupport.News_Turn03_V_ManusMeeting_Negative`
- `RiziaDLCSupport.News_Turn03_V_ManusMeeting_Positive`
- `RiziaDLCSupport.Reports_Turn03_Pales_Assessment`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 16

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Manus_ConstitutionalMonarchy`
- `RiziaDLC.Relations_Manus_OverthrowMonarchy`
- `RiziaDLC.Relations_Manus_WorkWithRPP`
- `RiziaDLC.Relations_Sazon_ManusTalkSoured`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Relations_Vina_DancedWithManus`
- `RiziaDLCSupport.Reports_Turn03_Pales_Assessment`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[158]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- Węzeł `[177]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] = true; Variable["RiziaDLCSupport.News_Turn03...`
- Węzeł `[264]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] = true; Variable["RiziaDLC.Relations_Vina"] ...`
- Węzeł `[304]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] = true; Variable["RiziaDLCSupport.Jou...`
- Węzeł `[305]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Journal_Turn03_Manus_WorkWithParty"] = true; Variable["RiziaDLC.Relatio...`
- Węzeł `[314]` (Paskal Beniwoll): `RemoveConversant("Manus Sazon"); RemoveConversant("Vina Toras");`
- Węzeł `[318]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn03_V_ManusMeeting_Negative"] = true;`
- Węzeł `[319]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn03_V_ManusMeeting_Positive"] = true;`
- *...oraz 8 innych węzłów ze skryptami.*

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
  - -> `[374]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Every spring, the seaside town of Sallabes celebrated the Scarlet Kingbird Festival."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The vibrantly colored songbirds spent their winters in Xina, near the southern part of what used to be the Mousser Empire. Every spring, like clockwork, they flew back over the Gulf of Moridia to settle in Sallabes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Their return was celebrated with music, dancing and lavish banquets, opened by a speech from the reigning Count or Countess of Sallabes. It was traditional for the King of Rizia and his family to attend."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Manus Sazon**
> ""Greetings, Sallabeans!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[7]`
Mówca: **Narrator**
> "The sun hung low in the sky over the Arena Sallabes, a hundred-year-old open-air venue perched directly on the beach. Vina and I sat waiting in the royal box as cameras flashed in our direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "My daughter impatiently tapped her fingers on the arm of her chair. We hadn't spoken much since Iza."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[10]`
  - -> `[11]`
  - -> `[12]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I promise I won't try to shoot any of the birds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. It'll start soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sit still. Can't you see everyone's watching?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you corresponding with Rico these days?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[13]`
Mówca: **Narrator**
> "She laughed bleakly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[14]`
Mówca: **Narrator**
> "The audience roared as Manus Sazon got onstage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[15]`
Mówca: **Narrator**
> "He waited for the applause to subside, then held up a hand for the audience to listen. The entire arena fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Manus Sazon**
> ""The story of the scarlet kingbird is a story about trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Manus Sazon**
> ""He doesn't know what perils await him on the way to his destination, nor what sort of welcome will await him there. Yet he flies on, because something deep within his soul compels him to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[18]`
Mówca: **Manus Sazon**
> ""Every year, this tiny feathered creature travels thousands of kilometers to reach our shores.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[19]`
Mówca: **Manus Sazon**
> ""And what of those who wait for him? They have no idea where he's been, or how he knows to navigate to this exact same spot each time. Still they gather here, scanning the skies for the first sign of his return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[20]`
Mówca: **Manus Sazon**
> ""An inner voice that tells him, 'This is your home.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`
  - -> `[21]`
  - -> `[24]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is he talking about himself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish he'd get to the point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is so maudlin. Why is the crowd eating it up?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Huh. The kid has charisma.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Vina Toras**
> ""Shh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Narrator**
> "Vina glared at me, then turned her full attention back to the man on stage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[27]`
Mówca: **Narrator**
> "As if on cue, a solitary bird came flying towards us from over the horizon. Its plumage was bright red."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Narrator**
> "A tear rolled down Manus' cheek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Manus Sazon**
> ""Trust. It's the only way any of this works. Even when we've been given no reason. Even when our faith is tested, over and over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Narrator**
> "A second bird followed, then a third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[31]`
Mówca: **Vina Toras**
> ""A little bit. He says Bruno's running almost as fast on three legs as he did on four.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Rico_ShotDog == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Rico_ShotDog == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Rico_ShotDog"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Rico_ShotDog == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Rico_ShotDog"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Vina Toras**
> ""What? No, I was about ready to murder him after the Iza trip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Rico_ShotDog == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Rico_ShotDog == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Rico_ShotDog"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Rico_ShotDog == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Rico_ShotDog"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[39]`
Mówca: **Vina Toras**
> ""Yes, I can see everyone watching me. Same as yesterday, and tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Vina Toras**
> ""Sorry. Just excited to see the birds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[44]`
Mówca: **Manus Sazon**
> ""It's only when we place our trust in one another that we are able to find our way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Narrator**
> "The audience gasped as the sky over our heads filled with hundreds and hundreds of kingbirds, their crimson feathers magnificently lit by the setting sun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[49]`
  - -> `[51]`
  - -> `[327]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep your head down, Vina. Too much trust will get you a face full of shit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Vina Toras**
> ""Don't be so crass, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Narrator**
> "Vina sniffled. She had tears in her eyes as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you ever seen anything so beautiful?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Vina Toras**
> ""It's breathtaking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Timing the speech perfectly with the migration? What a cheap trick.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Vina Toras**
> ""I don't see anything cheap about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[53]`
Mówca: **Narrator**
> "Once the sun had set and the birds had gone to roost, we made our way to the VIP reception in the neighboring pavilion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A simple message. But you can't deny the truth in it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Vina Toras**
> ""I thought it was beautiful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[56]`
Mówca: **Narrator**
> "A big band was playing jazz music as Vina and I entered. We immediately found ourselves surrounded by local officials, celebrities and members of the press."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Narrator**
> "It was nearly an hour before I was able to sit down. Almost as soon as I parked myself in a chair, I noticed Manus Sazon making his way over to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`
  - -> `[73]`
  - -> `[60]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Sazon. A pleasure to see you again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That was some speech today. I see why your constituents love you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not in the mood to dance, Mr. Sazon?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[61]`
Mówca: **Narrator**
> "Manus smiled and shook my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[62]`
Mówca: **Manus Sazon**
> ""A relief to hear, Your Majesty. I wasn't sure what to think after our last meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[63]`
Mówca: **Narrator**
> "Manus smiled and bowed his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Manus Sazon**
> ""The birds did most of the heavy lifting. But thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[65]`
Mówca: **Vina Toras**
> ""Rico wrote me that Bruno is back on his feet. Well, three of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Narrator**
> "She pointed to a cluster of buildings a little further down the coastline. In the middle of it rose a spire covered in scaffolding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[112]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[70]`
Mówca: **Narrator**
> "Manus smiled uncomfortably."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Manus Sazon**
> ""I'm better off on the debate floor than the dance floor, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Manus Sazon**
> ""Actually, I've been hoping to speak with you for a long time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[139]`
  - -> `[185]`
  - -> `[182]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That seat is reserved for my daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Narrator**
> "Manus gestured across the room. Vina was standing by the bar, having an animated conversation with the Derdian bartender."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Manus Sazon**
> ""With your permission, Your Majesty, I'd like to keep it warm for a moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[76]`
Mówca: **Narrator**
> "He took a measured sip from the wine glass he was holding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[77]`
Mówca: **Manus Sazon**
> ""But I still think we have a chance to accomplish great things for this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[190]`
  - -> `[192]`

### Węzeł `[78]`
Mówca: **Manus Sazon**
> ""As I said, I am not my father. Another revolution would damage the country and endanger what's left of my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why? What exactly is it that you want?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You assumed wrong. I don't intend to give up a single one of my powers as king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you are telling me you have absolutely no intention of doing away with the monarchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure you're aware that removing any of the nobility's privileges would invite the wrath of all three royal houses. Yours included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[83]`
Mówca: **Narrator**
> "Manus shook his head hurriedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[84]`
Mówca: **Manus Sazon**
> ""I apologize for the misunderstanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[85]`
Mówca: **Vina Toras**
> ""I was just speaking to the bartender. He's still trying to get the rest of his family out of Derdia. I told him I'd see what I could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[86]`
Mówca: **Manus Sazon**
> ""That's very noble of you. But there are thousands like him, and not all of them are lucky enough to catch the Princess of Rizia at a benevolent moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`
  - -> `[144]`
  - -> `[145]`

### Węzeł `[87]`
Mówca: **Narrator**
> "She turned to Manus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[88]`
Mówca: **Vina Toras**
> ""Your speech was beautiful, Mr. Sazon. Actually, it reminded me of an essay of Queen Lyza's from 1883--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Vina Toras**
> ""What were the others?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[90]`
Mówca: **Manus Sazon**
> ""'On Social Contracts.' Yes, that was one inspiration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Vina Toras**
> ""Your speech was beautiful, Mr. Sazon. Actually, it reminded me of something from a book I read recently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Manus Sazon**
> ""Really? I'd love to hear more about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Narrator**
> "The band began playing "Sweetheart of Ventrie City", an upbeat tune that had recently reached us from Arcasia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Vina Toras**
> ""You know what? I'll tell you after this dance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[98]`
Mówca: **Narrator**
> "The band began playing "Sweetheart of Ventrie City," an upbeat tune that had recently reached us from Arcasia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Vina Toras**
> ""You know what? Tell me after this dance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Narrator**
> "She took a step closer towards Manus and extended a hand to him. He looked at me questioningly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[155]`
  - -> `[153]`
  - -> `[154]`

### Węzeł `[101]`
Mówca: **Vina Toras**
> ""Wait, this is faster than the dances I've been learning. Do you know the steps?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Manus Sazon**
> ""As a matter of fact, I do. I'll walk you through it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[103]`
Mówca: **Narrator**
> "If he did, Vina didn't notice. Cameras flashed as the two of them started dancing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Narrator**
> "It was the same one her mother had given me during our first dance together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[108]`
Mówca: **Narrator**
> "In all the years I'd been with Lena, my wife had never looked at me that way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They are, and I wish I had time to act on them. But there are international crises that require my full attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Manus Sazon**
> ""The kind of reforms I'm suggesting can keep Rizia stable through such crises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[111]`
Mówca: **Manus Sazon**
> ""Just know that should you choose to guide Rizia in a more democratic direction, my party is prepared to back you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[232]`
  - -> `[231]`
  - -> `[247]`

### Węzeł `[112]`
Mówca: **Vina Toras**
> ""Oh, what's that over there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[116]`
Mówca: **Narrator**
> "She pointed to a cluster of buildings a little further down the coastline. In the middle of it rose a spire covered in scaffolding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Vina Toras**
> ""Look over there, by the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[118]`
Mówca: **Vina Toras**
> ""It looks Dastnurist. I wonder if that's the sanctuary the Grand Wiseman was asking for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[119]`
  - -> `[122]`
  - -> `[123]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hmm. I thought it would be smaller.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a big, expensive building for heretics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[121]`
Mówca: **Narrator**
> "I remembered my orders to fund the construction of an expanded Dastnurist Grandsanctuary in Sallabes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[122]`
  - -> `[120]`
  - -> `[123]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That ought to keep the Wehzeks out of trouble for a while.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sal was right. Everyone deserves a space to worship God in their own way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope it has good security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Vina Toras**
> ""And after that, another state function, and another...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[129]`
Mówca: **Vina Toras**
> ""The program announced a special guest. I wonder who it'll be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Sazon_ManusTalkSoured == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Sazon_ManusTalkSoured == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Sazon_ManusTalkSoured == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Narrator**
> "He led Vina out onto the dance floor. I could swear he had the faintest hint of a smirk on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[134]`
Mówca: **Narrator**
> "He led Vina out onto the dance floor. Cameras flashed as the two of them started dancing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Narrator**
> "I wondered if the photographers were capturing the look in my daughter's eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[136]`
Mówca: **Narrator**
> "This was no longer the nervous young man I'd met in Porte Drazon. He radiated confidence as he stepped up to the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry I haven't visited the House of Delegates yet. It's been a busy time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Manus Sazon**
> ""I understand, Your Majesty. The Zille incident rattled us all. My family included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To be perfectly honest... I've been avoiding you. Too much bad blood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Manus Sazon**
> ""I understand. But isn't that precisely *why* we should talk?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[141]`
Mówca: **Narrator**
> "Manus smiled warmly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not address my daughter with such impudence, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's right. We've got to tackle this problem at the root, not by granting special favors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How drunk are you, Vina? You can't go around making promises to random cater-waiters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Forgive me, Mr. Sazon, but the Princess and I have really got to be going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Narrator**
> "Vina ignored my remark."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[147]`
Mówca: **Narrator**
> "Vina rolled her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Vina Toras**
> ""He was speaking to me as an equal, Father. I welcome his opinions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Sazon_ManusTalkSoured == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Sazon_ManusTalkSoured == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Sazon_ManusTalkSoured == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Over my dead body.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't need my permission. Have fun out there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One dance. Then we go home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, but no. People will gossip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Narrator**
> "Vina beamed. Manus took her hand and rose from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[157]`
Mówca: **Narrator**
> "Vina fixed me with an indignant stare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[159]`
Mówca: **Vina Toras**
> ""We're guests here, Father. It'll look bad if we leave without engaging with our hosts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[166]`
  - -> `[160]`

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine, you win. *One* dance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've engaged with our host enough. We're going. Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Sazon_ManusTalkSoured == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Sazon_ManusTalkSoured == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Sazon_ManusTalkSoured == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There will be other chances. Let's go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No dancing. That's a royal order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[167]`
Mówca: **Narrator**
> "Vina let out an exasperated sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Vina Toras**
> ""I do apologize, Mr. Sazon. It's been lovely to spend time in your family's province.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Manus Sazon**
> ""The pleasure has been all mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Narrator**
> "He took Vina's hand and pressed it to his lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Manus Sazon**
> ""Until next time, Your Highness. Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Narrator**
> "I saw her sneak a look back at him as we left the ballroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[176]`
Mówca: **Narrator**
> "It was a look I knew well. I'd seen it in her mother's eyes the day we first met."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus = true;
RiziaDLCSupport.News_Turn03_RH_Gossip_VinaManus = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] = true;
Variable["RiziaDLCSupport.News_Turn03_RH_Gossip_VinaManus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_IgnoreFirstMeeting == true || RiziaDLC.Relations_Manus_ThreatenFirstMeeting == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_IgnoreFirstMeeting == true || RiziaDLC.Relations_Manus_ThreatenFirstMeeting == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Manus_IgnoreFirstMeeting"] == true  or  Variable["RiziaDLC.Relations_Manus_ThreatenFirstMeeting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Manus_IgnoreFirstMeeting == true || RiziaDLC.Relations_Manus_ThreatenFirstMeeting == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Manus_IgnoreFirstMeeting"] == true  or  Variable["RiziaDLC.Relations_Manus_ThreatenFirstMeeting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop trying to ambush me, Mr. Sazon. Whatever you want, I'm not interested.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_IgnoreFirstMeeting == true || RiziaDLC.Relations_Manus_ThreatenFirstMeeting == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_IgnoreFirstMeeting == true || RiziaDLC.Relations_Manus_ThreatenFirstMeeting == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Manus_IgnoreFirstMeeting"] == true  or  Variable["RiziaDLC.Relations_Manus_ThreatenFirstMeeting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Manus_IgnoreFirstMeeting == true || RiziaDLC.Relations_Manus_ThreatenFirstMeeting == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Manus_IgnoreFirstMeeting"] == true  or  Variable["RiziaDLC.Relations_Manus_ThreatenFirstMeeting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So why didn't you request an audience with me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Narrator**
> "He gave me a look that was equal parts hurt and puzzled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Manus Sazon**
> ""I did, through your Grand Vizier. The message must have gotten lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Manus Sazon**
> ""Please, Your Majesty. Just give me five minutes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[189]`
Mówca: **Manus Sazon**
> ""But since we're both here right now, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who's speaking to me right now? The heir of House Sazon or the speaker of the Rizian People's Party?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right, I'll indulge you. Tell me what you have in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have some nerve even approaching me after what your father did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[193]`
Mówca: **Manus Sazon**
> ""I don't expect you to forgive Lucas Sazon. I haven't forgiven him myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Manus Sazon**
> ""I used to hate him for robbing me of my birthright. Now, I realize his real crime was robbing Rizia of the peaceful transition it deserved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[195]`
Mówca: **Manus Sazon**
> ""The two cannot be separated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Manus Sazon**
> ""I joined the House of Delegates because of Lucas Sazon. Because my father's rash act of violence robbed Rizia of the peaceful transition it deserved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Manus Sazon**
> ""Well, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[198]`
Mówca: **Manus Sazon**
> ""The rest of the RPP and I are in agreement. Our kingdom thirsts for reform. We can grant our people a voice without spilling a drop of blood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[352]`
  - -> `[199]`
  - -> `[217]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You mentioned a transition. But a transition to what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The kind of change you're talking about doesn't happen peacefully. Look at how many corpses the Century of Revolutions left in its wake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Manus Sazon**
> ""It didn't have to be that way. If the kings and queens of your father's generation had been willing to compromise, they might have kept their crowns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[202]`
Mówca: **Manus Sazon**
> ""Quite right, Your Majesty. With just a few changes, it can fulfill its intended purpose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[203]`
Mówca: **Narrator**
> "Manus traced the rim of his wine glass with his finger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[204]`
Mówca: **Manus Sazon**
> ""I heard your coronation speech. I believe your aims are the same as mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[333]`
  - -> `[109]`
  - -> `[82]`
  - -> `[80]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_AntiMonarchy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_AntiMonarchy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coronation_Speech_AntiMonarchy == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[208]`
Mówca: **Manus Sazon**
> ""I don't want to make assumptions... But could it be that your aims are the same as mine?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[333]`
  - -> `[109]`
  - -> `[82]`
  - -> `[80]`

### Węzeł `[209]`
Mówca: **Manus Sazon**
> ""I envision a Rizia where the concerns of commoners and nobles are given equal weight. Where an elected parliament makes the laws, but the royals retain their status and influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic > 0 || RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Focus_Government_Reform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic > 0 || RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Focus_Government_Reform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] > 0  or  Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic > 0 || RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Focus_Government_Reform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] > 0  or  Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why? The people of Rizia have everything they want. And if they want more, I'll give them more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you trying to threaten me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[215]`
Mówca: **Manus Sazon**
> ""There are factions within Rizia that have other, more radical ideas. The RPP and I are keeping them in check. For now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[227]`
  - -> `[230]`
  - -> `[229]`

### Węzeł `[216]`
Mówca: **Manus Sazon**
> ""I know what you and your family think of me. And I know that my position in government is symbolic at best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And House Sazon? What do your relatives think of your crusade against their kind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Narrator**
> "Manus traced the rim of his wine glass with his finger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Manus Sazon**
> ""My crusade is not against the nobility, Your Majesty. It's on behalf of all Rizians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[220]`
Mówca: **Manus Sazon**
> ""That's why any reforms we implemented would have to proceed very gradually.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Manus Sazon**
> ""I would never presume to tell the King how the country should be run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[222]`
Mówca: **Manus Sazon**
> ""Certainly not, Your Majesty. Preserving the status of the Rizian nobility is as much in my family's interest as it is yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[223]`
Mówca: **Manus Sazon**
> ""They want to be heard, Your Majesty. Not placated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A second uprising will not happen during my reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[225]`
Mówca: **Manus Sazon**
> ""The commoners are tired of a ruling class that places its own desires above their own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`
  - -> `[284]`
  - -> `[239]`
  - -> `[250]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How exactly would you back me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'For now'. Is that supposed to be a threat?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not your job to keep them in check. It's mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's the right idea. Without an outlet for their demands, they could become dangerous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hypothetically, if I, the King of Rizia, asked you to assist me in the complete dismantling of the monarchy, would you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And if I don't?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am more interested in knowing that House Sazon won't rise against me again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[233]`
Mówca: **Manus Sazon**
> ""I know I am taking a risk by suggesting this to you. But I believe that unless significant changes are made, we may face another uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`
  - -> `[214]`
  - -> `[213]`
  - -> `[224]`

### Węzeł `[234]`
Mówca: **Manus Sazon**
> ""I do not doubt the strength of your regime, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Manus Sazon**
> ""But the commoners are tired of a ruling class that places its own desires above their own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[240]`
  - -> `[284]`
  - -> `[239]`
  - -> `[250]`

### Węzeł `[236]`
Mówca: **Manus Sazon**
> ""But the longer our people are silenced, the louder they will be when they finally speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[240]`
  - -> `[295]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Manus Sazon**
> ""We will not go against you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't like what you're implying. I would advise you to choose your next words very carefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What in the hell do you mean by that? I have only ever had my people's needs at heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am looking forward to working more closely with your party to better serve our people. But changing the entire system of government? We probably won't go that far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[241]`
Mówca: **Manus Sazon**
> ""My house has learned its lesson, Your Majesty. As long as you treat its members with dignity, they will be among your most loyal supporters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[240]`
  - -> `[295]`
  - -> `[238]`

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree with the idea of reforming Rizia and empowering our legislative body. It is my wish that we work together to make it a reality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Narrator**
> "Manus' eyes lit up. He smiled confidently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Manus Sazon**
> ""We can discuss this back in the capital, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[245]`
Mówca: **Manus Sazon**
> ""No, Your Majesty. The opposite.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[246]`
Mówca: **Manus Sazon**
> ""Yes, of course. But, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate the risk you took in coming to me. It can't have been easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Manus Sazon**
> ""Thank you for hearing me out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[240]`
  - -> `[295]`

### Węzeł `[249]`
Mówca: **Manus Sazon**
> ""We will get the public on your side. When the time comes, they will embrace reform without hesitation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We should end this conversation before I'm obliged to have you arrested for treason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[251]`
Mówca: **Manus Sazon**
> ""Well, I...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[252]`
Mówca: **Narrator**
> "He took a handkerchief out of his pocket and dabbed his brow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[253]`
Mówca: **Manus Sazon**
> ""I obviously chose the wrong venue for this conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[258]`
  - -> `[257]`

### Węzeł `[254]`
Mówca: **Manus Sazon**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[255]`
Mówca: **Narrator**
> "He took a handkerchief out of his pocket and dabbed his brow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Manus Sazon**
> ""Please forget I brought this up with you, then..""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`
  - -> `[267]`

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is no right venue. You shouldn't have bothered me in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, please go on. What were you going to tell me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[259]`
Mówca: **Manus Sazon**
> ""Of course. But will your successor? Or your successor's successor? We've seen how risky it is to let the fate of the country rest on a single ruler.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[279]`
  - -> `[261]`
  - -> `[281]`

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My house was chosen by God to rule, Mr. Sazon. Are you saying God made a mistake?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[263]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Sazon_ManusTalkSoured = true;
RiziaDLC.Relations_Vina -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] = true;
Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Gladly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will not forget.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's nothing personal. But consider this topic off-limits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
Mówca: **Manus Sazon**
> ""No, absolutely. I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Narrator**
> "He stood up and pushed back his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[270]`
Mówca: **Manus Sazon**
> ""If you'll excuse me, Your Majesty, I'm going to refresh my drink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[271]`
Mówca: **Narrator**
> "He turned around to head to the bar and came face to face with Vina, who was returning to our table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Narrator**
> "Her face was slightly flushed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Vina Toras**
> ""Oh, excuse me, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Manus Sazon**
> ""Nothing to excuse, Your Highness. I hope you're enjoying your time in Sallabes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[275]`
Mówca: **Manus Sazon**
> ""Nothing...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[276]`
Mówca: **Manus Sazon**
> ""Right, yes. Forgive me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[277]`
Mówca: **Manus Sazon**
> ""I-- okay. Understood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[278]`
Mówca: **Manus Sazon**
> ""Thank you. I won't trouble you again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't try to disguise your power grab as altruism, Mr. Sazon. I can see right through you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see your point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you implying about my daughter, Mr. Sazon? You believe she's unfit to rule?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[282]`
Mówca: **Narrator**
> "A tentative smile appeared on Manus' face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[283]`
Mówca: **Manus Sazon**
> ""Come to the House of Delegates. You should have an idea how the current system works before we begin talking about how to fix it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[289]`
  - -> `[290]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I suppose your solution to that would be to make yourself Prime Minister?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[285]`
Mówca: **Manus Sazon**
> ""I promise you, this is not about what I want. It's about securing the stability of the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[279]`
  - -> `[261]`

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree that my government could be doing more for the non-noble classes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[287]`
Mówca: **Manus Sazon**
> ""I understand, Your Majesty. Of course my party would be thrilled to have your ear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[288]`
Mówca: **Manus Sazon**
> ""It would be an honor to see you at the next House of Delegates session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[289]`
  - -> `[290]`

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll be there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll see what I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't get too excited. I'm not promising anything yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[292]`
Mówca: **Narrator**
> "With a smile, he stood up and pushed back his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Manus Sazon**
> ""I've taken up enough of your time. If you'll excuse me, I'll freshen up my drink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[294]`
Mówca: **Manus Sazon**
> ""It's not...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand what you're saying. But now is not the right time to start changing the status quo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Narrator**
> "A disappointed look spread across his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Manus Sazon**
> ""If not now, then when, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[299]`
  - -> `[298]`

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't push me, boy. I've given you enough of my time this evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If and when the Zille crisis is solved, we may be able to revisit the topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know. I'm sure you understand it's a lot to think about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[301]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Narrator**
> "A look of frustration spread across his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[303]`
Mówca: **Manus Sazon**
> ""Of course. Forgive me if I overstepped.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_ConstitutionalMonarchy = true; RiziaDLCSupport.Journal_Turn03_Manus_TalkedAboutReform = true;
RiziaDLC.LeaningValue_Democratic += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] = true;
Variable["RiziaDLCSupport.Journal_Turn03_Manus_TalkedAboutReform"] = true;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn03_Manus_WorkWithParty = true; 
RiziaDLC.Relations_Manus_WorkWithRPP = true;
RiziaDLCSupport.Journal_Turn03_Manus_TalkedAboutReform = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn03_Manus_WorkWithParty"] = true;
Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] = true;
Variable["RiziaDLCSupport.Journal_Turn03_Manus_TalkedAboutReform"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[309]`
Mówca: **Vina Toras**
> ""At least Bruno is adjusting well to life with us. The chefs have him spoiled rotten.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[313]`
Mówca: **Vina Toras**
> ""A little bit. He wanted to know how Bruno was doing at the palace. I told him the chefs have him spoiled rotten.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Manus Sazon");
RemoveConversant("Vina Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Manus Sazon");
RemoveConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Sazon_ManusTalkSoured == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Sazon_ManusTalkSoured == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Sazon_ManusTalkSoured == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn03_V_ManusMeeting_Negative = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn03_V_ManusMeeting_Negative"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn03_V_ManusMeeting_Positive = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn03_V_ManusMeeting_Positive"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_FreePress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn03_RH_ManusSpeech = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn03_RH_ManusSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Alliances", "R_Alliances_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Alliances","R_Alliances_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn03_Pales_Assessment = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn03_Pales_Assessment"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A giant flock of birds, migrating from a distant land... where have I seen that before?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Vina Toras**
> ""I don't know, Father. It's a beautiful sight, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. Like you, I sense a sea change coming to Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Narrator**
> "He flinched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[335]`
Mówca: **Manus Sazon**
> ""Listen...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[338]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[339]`
Mówca: **Manus Sazon**
> ""The undercurrents to which I refer are like a river. They cannot be stopped, only channeled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[343]`
Mówca: **Narrator**
> "He allowed himself a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Manus Sazon**
> ""With the new hydroelectric project you've approved for my province, I believe you know something about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[345]`
Mówca: **Narrator**
> "He smiled uncomfortably."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[346]`
Mówca: **Manus Sazon**
> ""Which reminds me, I heard the royal government is considering a new hydroelectric project in this province. My relatives would be exceedingly grateful if it were to be implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[347]`
Mówca: **Manus Sazon**
> ""But as I was saying...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[348]`
Mówca: **Manus Sazon**
> ""I...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[349]`
Mówca: **Narrator**
> "He laughed nervously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[350]`
Mówca: **Manus Sazon**
> ""I'm not convinced that's what the people of Rizia want at this particular moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[351]`
Mówca: **Manus Sazon**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The people have a voice. That's what the House of Delegates is for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[353]`
Mówca: **Manus Sazon**
> ""A true constitutional monarchy, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[354]`
Mówca: **Manus Sazon**
> ""As I was saying...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_OverthrowMonarchy = true; RiziaDLCSupport.Journal_Turn03_Manus_TalkedAboutReform = true;
RiziaDLC.PersonalValue_Malenyevist += 1;
RiziaDLC.LeaningValue_Democratic += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] = true;
Variable["RiziaDLCSupport.Journal_Turn03_Manus_TalkedAboutReform"] = true;
Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[356]`
Mówca: **Manus Sazon**
> ""You've implemented some of our proposals already. I'm glad you're open to working with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[240]`
  - -> `[295]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative == true || RiziaDLC.Policy_RD_Economy_GovernmentStimulusForPeople == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[359]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative == true || RiziaDLC.Policy_RD_Economy_GovernmentStimulusForPeople == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_GovernmentStimulusForPeople"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative == true || RiziaDLC.Policy_RD_Economy_GovernmentStimulusForPeople == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_GovernmentStimulusForPeople"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[360]`
Mówca: **Manus Sazon**
> ""It would help if you implemented some of the decrees we've proposed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[240]`
  - -> `[295]`

### Węzeł `[361]`
Mówca: **Narrator**
> "A fanfare sounded from the pit orchestra, and a dark-haired woman stepped on stage. I recognized her as Leona Sazon, Countess of Sallabes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Leona Sazon**
> ""Ladies and gentlemen!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[363]`
Mówca: **Leona Sazon**
> ""It is my great pleasure to welcome His Majesty King Romus and Her Highness Princess Vina to our humble city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[364]`
Mówca: **Leona Sazon**
> ""We have another special guest here today as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[365]`
Mówca: **Leona Sazon**
> ""It has been 25 years since my beloved cousin Angelica was sent into exile. Like all Sazons, I hold out hope that someday, the King in his infinite generosity will bring her back to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`
  - -> `[367]`
  - -> `[368]`
  - -> `[370]`

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hmm. Perhaps the Sazon matriarch has been punished for long enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ha. Nice try, Leona.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The only way Angelica is returning to Rizia is in a coffin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[369]`
Mówca: **Narrator**
> "Vina ignored me. She craned her neck to get a better view of the stage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm bored already. When do we eat?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[371]`
Mówca: **Narrator**
> "Vina nodded. She craned her neck to get a better view of the stage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[372]`
Mówca: **Leona Sazon**
> ""Today, we are graced with the presence of her child Manus. Heir of House Sazon, leader of the Rizian People's Party and prodigal son of Brenas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Leona Sazon");
AddConversant("Manus Sazon");)*
- **Efekt (`userScript`):** `RemoveConversant("Leona Sazon");
AddConversant("Manus Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Meeting the traitor’s son at the Scarlet Kingbird Festival", "Sallabes", "Province of Brenas");)*
- **Efekt (`userScript`):** `SetRichPresence("Meeting the traitor’s son at the Scarlet Kingbird Festival","Sallabes","Province of Brenas");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
