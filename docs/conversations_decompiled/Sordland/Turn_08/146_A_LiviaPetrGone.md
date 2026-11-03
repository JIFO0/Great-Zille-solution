# Sordland/Turn08/A_LiviaPetrGone

- **ID konwersacji:** `146`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/146_A_LiviaPetrGone.md`
- **Liczba węzłów dialogowych:** 179
- **Liczba wyborów gracza:** 44

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[56]** Karl Greiser
- **[57]** Reporter

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Accepted_MediaDeal`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Relations_Marcel_Enemy`
- `BaseGame.Turn07_Detained_MarcelKoronti`
- `BaseGame.Turn08_SecondScandal_Detained_Livia`
- `BaseGame.Turn08_SecondScandal_Detained_Petr`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr`
- `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith`
- `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired`
- `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison`
- `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway`
- `BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Petr_Dead`
- `BaseGame.Petr_isVP`
- `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith`
- `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired`
- `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison`
- `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway`
- `BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair`
- `BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Conspiracy`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Arrested`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Detained`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dismissed`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_KeptAsVP`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Killed`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resigned`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Suicide`
- `BaseGameSupport.Codex_Characters_Others_EvelynVectern`
- `BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno_Arrested`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing`
- `BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_Media`
- `BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_NoMedia`
- `GameCondition.Turn08_A_LiviaPetrGone`
- `GameCondition.Turn08_A_PressReleases`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 20

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[61]` (Lucian Galade): `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison"] = true;`
- Węzeł `[63]` (Lucian Galade): `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith"] = true;`
- Węzeł `[64]` (Lucian Galade): `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired"] = true;`
- Węzeł `[65]` (Lucian Galade): `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway"] = true;`
- Węzeł `[76]` (Lucian Galade): `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair"] = true;`
- Węzeł `[77]` (Lucian Galade): `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Conspiracy"] = true;`
- Węzeł `[144]` (Lucian Galade): `Variable["GameCondition.Turn08_A_LiviaPetrGone"] = true;`
- Węzeł `[151]` (Lucian Galade): `Variable["GameCondition.Turn08_A_PressReleases"] = true;`
- *...oraz 12 innych węzłów ze skryptami.*

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
  - -> `[42]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It had been several days since I'd had Karl Greiser detain Livia and Petr. Word was about to get out that both the vice president and the president's secretary were in jail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[4]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Livia == true && BaseGame.Turn08_SecondScandal_Detained_Petr == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Livia == true && BaseGame.Turn08_SecondScandal_Detained_Petr == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[6]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_Detained_Livia == true && BaseGame.Turn08_SecondScandal_Detained_Petr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Narrator**
> "It had been several days since I'd had Karl Greiser secretly arrest Livia and Petr. It wouldn't be long before word got out that both the vice president and the president's secretary had gone missing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Narrator**
> "It had been several days since I'd had Karl Greiser secretly kill Livia and Petr. It wouldn't be long before word got out that both the vice president and the president's secretary had gone missing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Narrator**
> "At Lucian's urging, I had arranged a press conference to get ahead of the narrative."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Narrator**
> "Of course, our deal with Marcel Koronti meant journalists wouldn't be asking too many questions. Still, one had to keep up appearances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Narrator**
> "I was still reeling from the loss of two of my closest colleagues -- and my former best friend. I had to get my story straight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Narrator**
> "The conference was slated to begin soon. I rang up Karl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Karl Greiser**
> ""Yes, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[20]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[22]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[26]`

### Węzeł `[23]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Livia == true && BaseGame.Turn08_SecondScandal_Detained_Petr == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Livia == true && BaseGame.Turn08_SecondScandal_Detained_Petr == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[25]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_Detained_Livia == true && BaseGame.Turn08_SecondScandal_Detained_Petr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""You're positive the bodies won't be found?""]** — Mówca: **Player**
> ""You're positive the bodies won't be found?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""How exactly did you dispose of Mr. Vectern and Ms. Suno?""]** — Mówca: **Player**
> ""How exactly did you dispose of Mr. Vectern and Ms. Suno?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[28]`
**[WYBÓR GRACZA: ""Where exactly are Mr. Vectern and Ms. Suno being held?""]** — Mówca: **Player**
> ""Where exactly are Mr. Vectern and Miss Suno being held?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
**[WYBÓR GRACZA: ""How are Mr. Vectern and Miss Suno holding up in detention?""]** — Mówca: **Player**
> ""How are Mr. Vectern and Miss Suno holding up in detention?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Karl Greiser**
> ""In individual cells on the top floor of Antel Rock, sir. Accessible by two guards, each of whom know only half of the combination required to enter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[31]`
Mówca: **Karl Greiser**
> ""Mr. Vectern is still quite shaken, sir. Miss Suno appears calmer, although she continues to ask for a lawyer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[32]`
Mówca: **Karl Greiser**
> ""They've both been dissolved in an extremely powerful acidic solution, sir. No trace has been left.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
**[WYBÓR GRACZA: ""Good work.""]** — Mówca: **Player**
> ""Good work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[34]`
**[WYBÓR GRACZA: ""That's disgusting.""]** — Mówca: **Player**
> ""That's disgusting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Karl Greiser**
> ""My men and I do what we must to serve Sordland, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[36]`
Mówca: **Karl Greiser**
> ""It's my pleasure, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[37]`
**[WYBÓR GRACZA: ""Good. Let them both rot.""]** — Mówca: **Player**
> ""Good. Let them both rot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""Tell the guards Petr can have a little steak once in a while. As a treat.""]** — Mówca: **Player**
> ""Tell the guards Petr can have a little steak once in a while. As a treat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Karl Greiser**
> ""I will, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Karl Greiser**
> ""Pleasure to serve you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Narrator**
> "The moment I hung up. Lucian knocked on my door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Narrator**
> "It was late in the afternoon, and I was nervously pacing around my office. My new secretary would start next week."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""It's time, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Narrator**
> "He and I made our way to the downstairs conference room. A dozen journalists were already waiting, notepads at the ready. They all stood up when we entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[45]`
  - -> `[47]`

### Węzeł `[45]`
**[WYBÓR GRACZA: ""Good afternoon.""]** — Mówca: **Player**
> ""Good afternoon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[46]`
**[WYBÓR GRACZA: ""Please be seated.""]** — Mówca: **Player**
> ""Please be seated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[47]`
**[WYBÓR GRACZA: ""Thank you for coming.""]** — Mówca: **Player**
> ""Thank you for coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[48]`
Mówca: **Narrator**
> "The journalists started talking. I motioned for quiet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[49]`
  - -> `[145]`

### Węzeł `[49]`
**[WYBÓR GRACZA: ""Rest assured that both offenders have been dealt with.""]** — Mówca: **Player**
> ""Rest assured that both offenders have been dealt with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[50]`
**[WYBÓR GRACZA: ""Unfortunately, before they could be punished for their misdeeds, both disappeared. It is assumed that they ran away together.""]** — Mówca: **Player**
> ""Unfortunately, before they could be punished for their misdeeds, both disappeared. It is assumed that they ran away together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[51]`
**[WYBÓR GRACZA: ""Rest assured that the offenders have now been imprisoned.""]** — Mówca: **Player**
> ""Rest assured that the offenders have now been imprisoned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[52]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_Detained_Petr == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_Detained_Petr == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[54]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_Detained_Petr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
**[WYBÓR GRACZA: ""I am currently reviewing highly qualified candidates for both positions.""]** — Mówca: **Player**
> ""I am currently reviewing highly qualified candidates for both positions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[56]`
**[WYBÓR GRACZA: ""This incident shall not interfere with the completion of my presidential goals.""]** — Mówca: **Player**
> ""This incident shall not interfere with the completion of my presidential goals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
**[WYBÓR GRACZA: ""The rest of my staff is now under investigation to root out any other potential wrongdoing.""]** — Mówca: **Player**
> ""The rest of my staff is now under investigation to root out any other potential wrongdoing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Narrator**
> "By now the reporters were nearly jumping out of their seats, hands raised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Lucian Galade**
> ""Please be aware that the president only has time to answer a limited number of questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Narrator**
> "He gestured to the reporter at the far end of the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[61]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`
  - -> `[57]`

### Węzeł `[62]`
**[WYBÓR GRACZA: ""Both offenders have now been fired.""]** — Mówca: **Player**
> ""Both offenders have now been fired.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[63]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`
  - -> `[57]`

### Węzeł `[64]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`
  - -> `[57]`

### Węzeł `[65]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`
  - -> `[57]`

### Węzeł `[66]`
Mówca: **Reporter**
> ""Mr. President, how are you personally coping with this horrifying betrayal? It must be very hard on top of all the other stress you have to face in office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[67]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[69]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[70]`
Mówca: **Narrator**
> "I said a silent prayer of thanks to Marcel Koronti."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`
  - -> `[73]`

### Węzeł `[71]`
**[WYBÓR GRACZA: ""Not very well, to be honest. But the pain will pass in time.""]** — Mówca: **Player**
> ""Not very well, to be honest. But the pain will pass in time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[72]`
**[WYBÓR GRACZA: ""I don't have time to dwell on it. I must move forward so I can continue to do the same with Sordland.""]** — Mówca: **Player**
> ""I don't have time to dwell on it. I must move forward so I can continue to do the same with Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
**[WYBÓR GRACZA: ""About as well as can be expected. I'm looking forward to having this all behind me.""]** — Mówca: **Player**
> ""About as well as can be expected. I'm looking forward to having this all behind me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Narrator**
> "She and the other reporters nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Reporter**
> ""I see, Mr. President. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[76]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[77]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Conspiracy = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Conspiracy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[78]`
**[WYBÓR GRACZA: ""I would like to address the growing rumors concerning Vice President Petr Vectern and my secretary, Livia Suno.""]** — Mówca: **Player**
> ""I would like to address the growing rumors concerning Vice President Petr Vectern and my secretary, Livia Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[79]`
**[WYBÓR GRACZA: ""I am here to address an incident involving Vice President Petr Vectern and my secretary, Livia Suno.""]** — Mówca: **Player**
> ""I am here to address an incident involving Vice President Petr Vectern and my secretary, Livia Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
**[WYBÓR GRACZA: ""Unbeknownst to me and the rest of the administration, these two employees were carrying on a lurid affair in flagrant defiance of Sordish values.""]** — Mówca: **Player**
> ""Unbeknownst to me and the rest of the administration, these two employees were carrying on a lurid affair in flagrant defiance of Sordish values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""Unbeknownst to my administration, these two employees were plotting a conspiracy to remove me from office.""]** — Mówca: **Player**
> ""Unbeknownst to my administration, these two employees were plotting a conspiracy to remove me from office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[82]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[84]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[85]`
Mówca: **Reporter**
> ""Mr. President, wouldn't you agree that imprisonment is a rather harsh sentence for a simple affair?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[114]`

### Węzeł `[86]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[88]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[92]`
Mówca: **Reporter**
> ""Mr. President, can either Miss Suno or Mr. Vectern be reached for comment about this incident?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[113]`

### Węzeł `[93]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Reporter**
> ""Mr. President... what exactly do you mean by 'dealt with'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[112]`

### Węzeł `[97]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Reporter**
> ""Mr. President, what evidence of this conspiracy do you have that would warrant imprisonment?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[108]`

### Węzeł `[101]`
Mówca: **Reporter**
> ""Mr. President, are you attempting to track the co-conspirators down?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[102]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[105]`
Mówca: **Reporter**
> ""Mr. President, do you have any idea where Mr. Vectern and Miss Suno could have gone?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[116]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""Yes, we've got our best men on the case.""]** — Mówca: **Player**
> ""Yes, we've got our best men on the case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""Unfortunately, they covered their tracks too well.""]** — Mówca: **Player**
> ""Unfortunately, they covered their tracks too well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[108]`
**[WYBÓR GRACZA: ""The state is under attack, and you're asking about evidence?""]** — Mówca: **Player**
> ""The state is under attack, and you're asking about evidence?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[109]`
**[WYBÓR GRACZA: ""I cannot disclose the evidence at this time.""]** — Mówca: **Player**
> ""I cannot disclose the evidence at this time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[110]`
**[WYBÓR GRACZA: ""They've gotten what they deserve.""]** — Mówca: **Player**
> ""They've gotten what they deserve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[111]`
**[WYBÓR GRACZA: ""Both have expressed a refusal to speak to the media.""]** — Mówca: **Player**
> ""Both have expressed a refusal to speak to the media.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[112]`
**[WYBÓR GRACZA: ""The state has exercised its discretion as to the appropriate punishment.""]** — Mówca: **Player**
> ""The state has exercised its discretion as to the appropriate punishment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[113]`
**[WYBÓR GRACZA: ""Both are currently taking some time away from Holsord to reflect on their misbehavior.""]** — Mówca: **Player**
> ""Both are currently taking some time away from Holsord to reflect on their misbehavior.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[114]`
**[WYBÓR GRACZA: ""Our values are under attack, and you're asking whether prison is too harsh?""]** — Mówca: **Player**
> ""Our values are under attack, and you're asking whether prison is too harsh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[115]`
**[WYBÓR GRACZA: ""Not for such high-ranking officials, no.""]** — Mówca: **Player**
> ""Not for such high-ranking officials, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[116]`
**[WYBÓR GRACZA: ""No. They covered their tracks too well.""]** — Mówca: **Player**
> ""No. They covered their tracks too well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[117]`
**[WYBÓR GRACZA: ""Possibly the border. We've got our best men on the case.""]** — Mówca: **Player**
> ""Possibly the border. We've got our best men on the case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[118]`
Mówca: **Reporter**
> ""And exactly how long will the sentence be?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[119]`
Mówca: **Reporter**
> ""And where exactly are they located right now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[120]`
Mówca: **Reporter**
> ""And what evidence do you have of this so-called conspiracy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[121]`
Mówca: **Reporter**
> ""You haven't answered my question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[122]`
Mówca: **Reporter**
> ""And were you aware of the multiple affairs Mr. Vectern is rumored to have previously conducted?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
**[WYBÓR GRACZA: ""No further questions.""]** — Mówca: **Player**
> ""No further questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[124]`
**[WYBÓR GRACZA: "Gesture to Lucian to end the press conference."]** — Mówca: **Player_Italic**
> "I gestured to Lucian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Reporter**
> ""But--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Narrator**
> "Lucian smoothly interjected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Lucian Galade**
> ""Thank you for your time, ladies and gentlemen. That will be all for today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Narrator**
> "The reporters reluctantly left the conference room, leaving Lucian and myself alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[129]`

### Węzeł `[129]`
**[WYBÓR GRACZA: ""That went well.""]** — Mówca: **Player**
> ""That went well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
**[WYBÓR GRACZA: ""So? Am I screwed?""]** — Mówca: **Player**
> ""So? Am I screwed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Lucian Galade**
> ""Marcel Koronti has come through for us yet again. I'm not sure how much longer we can count on his kindness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[135]`
Mówca: **Lucian Galade**
> ""The press may have been left with some dangling questions. But if Mr. Greiser did his job correctly, they'll never find the answers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[136]`
Mówca: **Lucian Galade**
> ""Very funny, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[137]`
Mówca: **Lucian Galade**
> ""Very good, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[138]`
Mówca: **Lucian Galade**
> ""Very well. We shall discuss it tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[139]`
**[WYBÓR GRACZA: ""Too soon.""]** — Mówca: **Player**
> ""Too soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[140]`
**[WYBÓR GRACZA: ""You're a little old to be my secretary, Lucian.""]** — Mówca: **Player**
> ""You're a little old to be my secretary, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[141]`
Mówca: **Lucian Galade**
> ""In the meantime, sir, there's the matter of replacing both your secretary and your vice president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[142]`
  - -> `[140]`

### Węzeł `[142]`
**[WYBÓR GRACZA: ""I have a few candidates in mind.""]** — Mówca: **Player**
> ""I have a few candidates in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[143]`
Mówca: **Narrator**
> "We left the conference room. On the long walk back to my office, I started to think about who my new vice president should be."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[144]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn08_A_LiviaPetrGone = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn08_A_LiviaPetrGone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[145]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[50]`

### Węzeł `[147]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[148]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[150]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[151]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn08_A_PressReleases = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn08_A_PressReleases"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[152]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Petr == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Petr == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[154]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_Detained_Petr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[155]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[158]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Detained = true;
BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = false;

BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP = true;
BaseGameSupport.Codex_Characters_Others_EvelynVectern = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Detained"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[159]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Detained = true;
BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = false;

BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP = true;
BaseGameSupport.Codex_Characters_Others_EvelynVectern = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Detained"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[160]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Others_LiviaSuno = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Arrested = false; 
BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed = true; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Arrested"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Arrested = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Detained = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dismissed = true; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_KeptAsVP = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Killed = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resigned = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Suicide = false; 

BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP = true;
BaseGameSupport.Codex_Characters_Others_EvelynVectern = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Arrested"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Detained"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dismissed"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_KeptAsVP"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Killed"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resigned"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Suicide"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[162]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Arrested = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Detained = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dismissed = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_KeptAsVP = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Killed = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resigned = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Suicide = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Arrested"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Detained"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dismissed"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_KeptAsVP"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Killed"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resigned"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Suicide"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[163]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Others_LiviaSuno = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Arrested = true; 
BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Arrested"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[164]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Others_LiviaSuno = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Arrested = false; 
BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed = true; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Arrested"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[165]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Others_LiviaSuno = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Arrested = false; 
BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed = true; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Arrested"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[166]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Petr_Dead = true;
BaseGame.Petr_isVP = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Petr_Dead"] = true;
Variable["BaseGame.Petr_isVP"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[167]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[169]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[170]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_NoMedia = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_NoMedia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[171]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: (BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true) || (BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true && BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: (BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true) || (BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true && BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true)  or  (Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[173]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !((BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true) || (BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true && BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true)  or  (Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[174]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_Media = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[175]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[177]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
