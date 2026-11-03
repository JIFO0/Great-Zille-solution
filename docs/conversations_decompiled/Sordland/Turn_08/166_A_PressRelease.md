# Sordland/Turn08/A_PressRelease

- **ID konwersacji:** `166`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/166_A_PressRelease.md`
- **Liczba węzłów dialogowych:** 344
- **Liczba wyborów gracza:** 91

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[57]** Reporter

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Accepted_MediaDeal`
- `BaseGame.HeartOfSordland_Nationalization`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Relations_Marcel_Enemy`
- `BaseGame.Turn07_Detained_MarcelKoronti`
- `BaseGame.Turn08_A_Petr_Protected`
- `BaseGame.Turn08_PressConference_PetrKnowsResigning`
- `BaseGame.Turn08_SecondScandal_BlamePetrForLeak`
- `BaseGame.Turn08_SecondScandal_DenyEverything`
- `BaseGame.Turn08_SecondScandal_LiviaTrialled`
- `BaseGame.Turn08_SecondScandal_PetrForcedResign`
- `BaseGame.Turn08_SecondScandal_PetrSelfResigned`
- `BaseGame.Turn08_SecondScandal_PetrTrialled`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr`
- `BaseGame.Turn08_SecondScandal_ShareBlame`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Petr_Dead`
- `BaseGame.Petr_isVP`
- `BaseGame.Public_Opinion`
- `BaseGame.Turn08_SecondScandal_PetrForcedResign`
- `BaseGame.Turn08_SecondScandal_PetrSelfResigned`
- `BaseGame.Turn08_SecondScandal_PetrTrialled`
- `BaseGame.Turn08_SecondScandal_RumburgBlamed`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Arrested`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dismissed`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_KeptAsVP`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resigned`
- `BaseGameSupport.Codex_Characters_Others_EvelynVectern`
- `BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing`
- `BaseGameSupport.Journal_Turn08_SecondScandal_PetrForcedResign`
- `BaseGameSupport.Journal_Turn08_SecondScandal_PetrSelfResigned`
- `BaseGameSupport.Journal_Turn08_SecondScandal_PetrTrialled`
- `BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlamed`
- `BaseGameSupport.News_Turn08_HP_Livia_Investigate_Trialled`
- `BaseGameSupport.News_Turn08_LT_Livia_Investigate_Trialled`
- `BaseGameSupport.News_Turn08_R_Livia_Investigate_Trialled`
- `BaseGameSupport.News_Turn08_R_Press_Conference_Blame_Petr`
- `BaseGameSupport.News_Turn08_R_Share_Blame_Petr_Resigns`
- `BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_Media`
- `BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_NoMedia`
- `BaseGameSupport.News_Turn08_ST_No_Blame_Media`
- `BaseGameSupport.News_Turn08_ST_No_Blame_NoMedia`
- `BaseGameSupport.News_Turn08_ST_Press_Conference_Blame_Petr_Media`
- `BaseGameSupport.News_Turn08_ST_Press_Conference_Blame_Petr_NoMedia`
- `GameCondition.Turn08_A_PressReleases`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 45

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[6]` (Lucian Galade): `Variable["GameCondition.Turn08_A_PressReleases"] = true;`
- Węzeł `[86]` (Lucian Galade): `Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] = true;`
- Węzeł `[87]` (Lucian Galade): `Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] = true; Variable["BaseGame.Public_Opinion"...`
- Węzeł `[214]` (Lucian Galade): `Variable["BaseGame.Turn08_SecondScandal_PetrSelfResigned"] = true; Variable["BaseGameSupport.Jour...`
- Węzeł `[224]` (Lucian Galade): `Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] = true;`
- Węzeł `[225]` (Lucian Galade): `Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] = true;`
- Węzeł `[226]` (Lucian Galade): `Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] = true;`
- Węzeł `[227]` (Lucian Galade): `Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] = true;`
- *...oraz 37 innych węzłów ze skryptami.*

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
  - -> `[234]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It was the morning of Livia's trial, and hordes of reporters were gathered in front of the state courthouse. Petr, Lucian and I stood by the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Lucian had helped break the news of my secretary's arrest. Now the media was beginning to question exactly how a Rumburg agent had been able to infiltrate the Maroon Palace. It was time for me to deliver an explanation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Narrator**
> "A podium with a bank of microphones awaited us on the courthouse steps. Petr looked uncertain. I had told him I would be doing all the talking today."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn08_A_PressReleases = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn08_A_PressReleases"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[7]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Lucian Galade**
> ""Remember what we talked about, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[11]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: (BaseGame.Media_SordlandToday_Bias == true && BaseGame.Accepted_MediaDeal == true) && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false || (BaseGame.HeartOfSordland_Nationalization >3 || BaseGame.Media_Censored == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: (BaseGame.Media_SordlandToday_Bias == true && BaseGame.Accepted_MediaDeal == true) && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false || (BaseGame.HeartOfSordland_Nationalization >3 || BaseGame.Media_Censored == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true  and  Variable["BaseGame.Accepted_MediaDeal"] == true)  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false  or  (Variable["BaseGame.HeartOfSordland_Nationalization"] >3  or  Variable["BaseGame.Media_Censored"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !((BaseGame.Media_SordlandToday_Bias == true && BaseGame.Accepted_MediaDeal == true) && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false || (BaseGame.HeartOfSordland_Nationalization >3 || BaseGame.Media_Censored == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Media_SordlandToday_Bias"] == true  and  Variable["BaseGame.Accepted_MediaDeal"] == true)  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false  or  (Variable["BaseGame.HeartOfSordland_Nationalization"] >3  or  Variable["BaseGame.Media_Censored"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Lucian Galade**
> ""Koronti's reporters will ask softball questions. But I'd still advise you to keep your responses as brief as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[15]`
Mówca: **Lucian Galade**
> ""You're on your own, Mr. President. I'd advise you to keep your responses as brief as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[16]`
Mówca: **Narrator**
> "How could I forget? I was about to blame my best friend for a scandal that would otherwise shatter my administration. And Petr still had no idea."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Narrator**
> "Together, we stepped behind the podium. The reporters clustered around us and started shouting questions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[20]`

### Węzeł `[18]`
**[WYBÓR GRACZA: ""Thank you for coming.""]** — Mówca: **Player**
> ""Thank you for coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[19]`
Mówca: **Narrator**
> "I nodded. Petr took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[20]`
**[WYBÓR GRACZA: ""Please settle down.""]** — Mówca: **Player**
> ""Please settle down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""As you are aware, Livia Suno, former secretary to the President of Sordland, is currently being tried for espionage.""]** — Mówca: **Player**
> ""As you are aware, Livia Suno, former secretary to the President of Sordland, is currently being tried for espionage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
**[WYBÓR GRACZA: ""As you are aware, Ilana Vance, the Rumburg spy who posed as my secretary, is currently on trial for espionage.""]** — Mówca: **Player**
> ""As you are aware, Ilana Vance, the Rumburg spy who posed as my secretary, is currently on trial for espionage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[23]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`
  - -> `[78]`

### Węzeł `[25]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`
  - -> `[103]`

### Węzeł `[28]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_ShareBlame == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[30]`
  - -> `[29]`

### Węzeł `[29]`
**[WYBÓR GRACZA: ""It is unknown exactly how this woman managed to infiltrate our administration.""]** — Mówca: **Player**
> ""It is unknown exactly how this woman managed to infiltrate our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[30]`
**[WYBÓR GRACZA: ""Using advanced document forging technology, this woman managed to pass our rigorous background checks and infiltrate our administration.""]** — Mówca: **Player**
> ""Using advanced document forging technology, this woman managed to pass our rigorous background checks and infiltrate our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[31]`
**[WYBÓR GRACZA: ""Certain officials failed to conduct the necessary background checks that would have prevented her from infiltrating our administration. They are now under investigation.""]** — Mówca: **Player**
> ""Certain officials failed to conduct the necessary background checks that would have prevented this woman from infiltrating our administration. They are now under investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
**[WYBÓR GRACZA: ""Please rest assured that the traitor will be brought to justice.""]** — Mówca: **Player**
> ""Please rest assured that the traitor will be brought to justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[34]`
  - -> `[36]`

### Węzeł `[33]`
**[WYBÓR GRACZA: ""Any further covert operations on Rumburg's part shall be met with our full retaliation.""]** — Mówca: **Player**
> ""Any further covert operations on Rumburg's part shall be met with our full retaliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“We remain vigilant against external and internal enemies. We will not tolerate any crimes against the state.”"]** — Mówca: **Player**
> "“We remain vigilant against external and internal enemies. We will not tolerate any crimes against the state.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Despite the efforts to undermine the administration, we are strong, unified and capable as ever.”"]** — Mówca: **Player**
> "“Despite the efforts to undermine the administration, we are strong, unified and capable as ever.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
**[WYBÓR GRACZA: ""Both Mr. Vectern and I remain committed to keeping the great country of Sordland safe and secure.""]** — Mówca: **Player**
> ""Both Mr. Vectern and I remain committed to keeping the great country of Sordland safe and secure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[38]`
Mówca: **Narrator**
> "Many camera flashes went off. A reporter raised her hand to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[39]`
  - -> `[215]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""Yes? What is it?""]** — Mówca: **Player**
> ""Yes? What is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "Let the reporter ask a question."]** — Mówca: **Player_Italic**
> "I gestured to the reporter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Reporter**
> ""Mr. Vectern, I have credible sources saying you personally oversaw Miss Suno's hiring and may have even been carrying on an inappropriate relationship with her--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[42]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[45]`
**[WYBÓR GRACZA: ""Mr. President, have you chosen your next secretary yet? Whoever she is, she's one lucky girl.""]** — Mówca: **Reporter**
> ""Mr. President, have you chosen your next secretary yet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`
  - -> `[51]`

### Węzeł `[46]`
Mówca: **Narrator**
> "I put a hand over Petr's mic."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[47]`

### Węzeł `[47]`
**[WYBÓR GRACZA: ""Attempts by our enemies to smear Mr. Vectern's reputation and further divide the administration. Nothing more.""]** — Mówca: **Player**
> ""Attempts by our enemies to smear Mr. Vectern's reputation and further divide the administration. Nothing more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[48]`
**[WYBÓR GRACZA: ""Whoever these 'sources' are, they're lying. Mr. Vectern's conduct has been nothing but honorable.""]** — Mówca: **Player**
> ""Whoever these 'sources' are, they're lying. Mr. Vectern's conduct has been nothing but honorable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[49]`
**[WYBÓR GRACZA: ""Would you like to submit an application?""]** — Mówca: **Player**
> ""Would you like to submit an application?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[50]`
**[WYBÓR GRACZA: ""Not yet. But we'll make sure she's blonde this time.""]** — Mówca: **Player**
> ""Not yet. But we'll make sure she's blonde this time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
**[WYBÓR GRACZA: ""I have a few candidates in mind.""]** — Mówca: **Player**
> ""I have a few candidates in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Narrator**
> "The crowd of reporters all laughed. I sent a silent prayer of thanks to Marcel Koronti."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Narrator**
> "The crowd of reporters nodded seriously. I sent a silent prayer of thanks to Marcel Koronti."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Reporter**
> ""Well, whoever she is, she's one lucky girl.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[55]`
Mówca: **Reporter**
> ""My source comes from within the Maroon Palace itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Reporter**
> ""And are you going to disregard Mr. Vectern's established reputation as a serial philanderer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[58]`
  - -> `[57]`

### Węzeł `[57]`
**[WYBÓR GRACZA: ""Men will be men.""]** — Mówca: **Player**
> ""Men will be men.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[58]`
**[WYBÓR GRACZA: ""Lies. All lies.""]** — Mówca: **Player**
> ""Lies. All lies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "Gesture to Lucian to end the press conference."]** — Mówca: **Player_Italic**
> "I silently gestured to Lucian to end the press conference."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Narrator**
> "Lucian interjected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Lucian Galade**
> "“The President will not be taking any more questions. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Narrator**
> "He, Petr and I began walking back to the courthouse. Petr and I hung behind to talk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Petr Vectern**
> ""Evelyn's still divorcing me, that can't be helped. But overall, this was nowhere near as bad as it could've been.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[65]`
  - -> `[220]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""A source within the palace? Who do you think she meant?""]** — Mówca: **Player**
> ""A source within the palace? Who do you think she meant?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[65]`
**[WYBÓR GRACZA: ""You should be thanking your lucky stars you're not in that courthouse with her.""]** — Mówca: **Player**
> ""You should be thanking your lucky stars you're not in that courthouse with her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[66]`
**[WYBÓR GRACZA: ""We have Marcel to thank for that.""]** — Mówca: **Player**
> ""We have Marcel to thank for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""Sorry about Evelyn.""]** — Mówca: **Player**
> ""Sorry about Evelyn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Petr Vectern**
> ""I know, I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[69]`
**[WYBÓR GRACZA: ""She was right. I don't deserve her.""]** — Mówca: **Petr Vectern**
> ""She was right. I don't deserve her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Petr Vectern**
> ""Eh, I'd wager anything she made that up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Petr Vectern**
> ""At least everything can go back to normal now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Narrator**
> "I stared at the back of Lucian's head as he disappeared inside the courthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Narrator**
> "Normal. We would see about that."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[74]`
**[WYBÓR GRACZA: ""That she did can be directly traced to the carelessness of one man: Petr Vectern.""]** — Mówca: **Player**
> ""That she did can be directly traced to the carelessness of one man: Petr Vectern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[75]`
**[WYBÓR GRACZA: ""Therefore, the vice president shall be trialled for his shameful actions against the state. If found guilty, he will be imprisoned. Take him.""]** — Mówca: **Player**
> ""Therefore, the vice president shall be trialled for his shameful actions against the state. If found guilty, he will be imprisoned. Take him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[76]`
**[WYBÓR GRACZA: ""Rest assured the traitor shall be brought to justice.""]** — Mówca: **Player**
> ""Rest assured the traitor shall be brought to justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[77]`
**[WYBÓR GRACZA: ""Rest assured Rumburg will be made to answer for its latest affront to our great country.""]** — Mówca: **Player**
> ""Rest assured Rumburg will be made to answer for its latest affront to our great country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[78]`
**[WYBÓR GRACZA: ""Rest assured a security breach of this magnitude shall never happen again.""]** — Mówca: **Player**
> ""Rest assured a security breach of this magnitude shall never happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
**[WYBÓR GRACZA: ""However, the fact remains that she should never have been allowed to infiltrate our administration in the first place.""]** — Mówca: **Player**
> ""However, the fact remains that she should never have been allowed to infiltrate our administration in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[81]`

### Węzeł `[80]`
**[WYBÓR GRACZA: ""However, the fact remains that she should never have been allowed to access sensitive government information.""]** — Mówca: **Player**
> ""However, the fact remains that she should never have been allowed to access sensitive government information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[81]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""She did so by exploiting the weakness of Vice President Petr Vectern.""]** — Mówca: **Player**
> ""She did so by exploiting the weakness of Vice President Petr Vectern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Narrator**
> "The journalists gasped and murmured. Petr turned to face me, his mouth hanging open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
**[WYBÓR GRACZA: ""Mr. Vectern's willingness to put his own infantile desires over Sordland's security has made him a threat to the state.""]** — Mówca: **Player**
> ""Mr. Vectern's willingness to put his own infantile desires over Sordland's security has made him a threat to the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[85]`

### Węzeł `[84]`
**[WYBÓR GRACZA: ""Mr. Vectern's recklessness, to say nothing of his betrayal of Sordish values, has disgraced my administration.""]** — Mówca: **Player**
> ""Mr. Vectern's recklessness, to say nothing of his betrayal of Sordish values, has disgraced my administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[85]`

### Węzeł `[85]`
**[WYBÓR GRACZA: ""Therefore, the vice president has tendered his resignation. Effective immediately.""]** — Mówca: **Player**
> ""Therefore, the vice president has tendered his resignation. Effective immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[86]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrForcedResign = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[87]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrTrialled = true;
BaseGame.Public_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[88]`
Mówca: **Petr Vectern**
> ""Wait just a--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Narrator**
> "I put my hand over his mic and gestured to Karl Greiser, who was waiting offstage. He and his men approached Petr."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Petr Vectern**
> ""How could you do this to me? I know I screwed up, but, Anton -- prison?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[93]`
  - -> `[92]`
  - -> `[91]`

### Węzeł `[91]`
**[WYBÓR GRACZA: ""Save it for the witness stand.""]** — Mówca: **Player**
> ""Save it for the witness stand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[92]`
**[WYBÓR GRACZA: ""Sorry. Lucian made me.""]** — Mówca: **Player**
> ""Sorry. Lucian made me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[93]`
**[WYBÓR GRACZA: ""Stop acting like this whole chain of events wasn't your fault.""]** — Mówca: **Player**
> ""Stop acting like this whole chain of events wasn't your fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
**[WYBÓR GRACZA: ""This is for the good of Sordland. Trust me.""]** — Mówca: **Player**
> ""This is for the good of Sordland. Trust me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Narrator**
> "Karl and his men grabbed Petr's arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Petr Vectern**
> ""Fuck you, Anton! You hear me? Fu--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Narrator**
> "The clamor of reporters drowned out his screams as he was led away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Reporter**
> ""Mr. President!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[99]`
Mówca: **Narrator**
> "The clamor of reporters was growing louder. Petr grabbed me by the collar and yanked me away from the microphones."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[100]`
**[WYBÓR GRACZA: ""Rest assured the traitor shall be brought to justice.""]** — Mówca: **Player**
> ""Rest assured the traitor shall be brought to justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[102]`

### Węzeł `[101]`
**[WYBÓR GRACZA: ""Rest assured Rumburg will be made to answer for its latest affront to our great country.""]** — Mówca: **Player**
> ""Rest assured Rumburg will be made to answer for its latest affront to our great country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[102]`
**[WYBÓR GRACZA: ""However, the fact remains that she should never have been allowed to access sensitive government information.""]** — Mówca: **Player**
> ""However, the fact remains that she should never have been allowed to access sensitive government information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[103]`
**[WYBÓR GRACZA: ""Rest assured a security breach of this magnitude shall never happen again.""]** — Mówca: **Player**
> ""Rest assured a security breach of this magnitude shall never happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[102]`

### Węzeł `[104]`
**[WYBÓR GRACZA: ""However, the fact remains that she should never have been allowed to infiltrate our administration in the first place.""]** — Mówca: **Player**
> ""However, the fact remains that she should never have been allowed to infiltrate our administration in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
**[WYBÓR GRACZA: ""That she was able to do so is solely due to carelessness on the part of myself and Vice President Petr Vectern.""]** — Mówca: **Player**
> ""That she was able to do so is solely due to carelessness on the part of myself and Vice President Petr Vectern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""I and Vice President Petr Vectern would like to take this opportunity to apologize for our disgraceful lack of oversight.""]** — Mówca: **Player**
> ""I and Vice President Petr Vectern would like to take this opportunity to apologize for our disgraceful lack of oversight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Narrator**
> "The journalists gasps and murmured. Petr turned to face me, his mouth hanging open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
**[WYBÓR GRACZA: ""In his impulsive hiring practices, Mr. Vectern displayed a lapse in judgement. But as your president, I bear the brunt of the responsibility.""]** — Mówca: **Player**
> ""In his impulsive hiring practices, Mr. Vectern displayed a lapse in judgement. But as your president, I bear the brunt of the responsibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[109]`
**[WYBÓR GRACZA: ""In falling victim to seduction, Mr. Vectern displayed a lapse in judgement. But as your president, I bear the brunt of the responsibility.""]** — Mówca: **Player**
> ""In falling victim to seduction, Mr. Vectern displayed a lapse in judgement. But as your president, I bear the brunt of the responsibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
**[WYBÓR GRACZA: ""I have failed in my duty to keep this country safe and secure. I hope I can regain your trust.""]** — Mówca: **Player**
> ""I have failed in my duty to keep this country safe and secure. I hope I can regain your trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
**[WYBÓR GRACZA: ""I failed to notice the enemy that was right under my nose. I hope I can regain your trust.""]** — Mówca: **Player**
> ""I failed to notice the enemy that was right under my nose. I hope I can regain your trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Petr Vectern**
> ""No! This isn't right!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Narrator**
> "Sweat was beading on Petr's brow. He grabbed the closest microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Petr Vectern**
> ""Please, don't listen to President Rayne. This is all my fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Petr Vectern**
> ""I was drunk and reckless. I broke my marriage vows. My selfishness compromised the Rayne administration and all of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Narrator**
> "Tears began streaming down his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Petr Vectern**
> ""I've been a sorry excuse for a husband and a terrible vice president. I resign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[118]`
**[WYBÓR GRACZA: ""You don't have to do this.""]** — Mówca: **Player**
> ""You don't have to do this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[119]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[120]`
Mówca: **Narrator**
> "The crowd became even louder. I turned away from the microphones and looked at Petr."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[121]`
Mówca: **Petr Vectern**
> ""Yes, I do. You'd never survive the term otherwise. Even with Marcel doing his best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[122]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: (BaseGame.Media_SordlandToday_Bias == true && BaseGame.Accepted_MediaDeal == true && BaseGame.Relations_Marcel_Enemy == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: (BaseGame.Media_SordlandToday_Bias == true && BaseGame.Accepted_MediaDeal == true && BaseGame.Relations_Marcel_Enemy == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true  and  Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[124]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !((BaseGame.Media_SordlandToday_Bias == true && BaseGame.Accepted_MediaDeal == true && BaseGame.Relations_Marcel_Enemy == false)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Media_SordlandToday_Bias"] == true  and  Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Petr Vectern**
> ""Yes, I do. You'd never survive the term otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Petr Vectern**
> ""And I owe you this much, after what I did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Petr Vectern**
> ""I owe you this much, after what I did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Narrator**
> "The reporters were now waving for us. One woman in the front row looked particularly insistent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Reporter**
> ""Mr. Vectern!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "Let Petr take the question."]** — Mówca: **Player_Italic**
> "I nodded at Petr to take her question."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[131]`
**[WYBÓR GRACZA: ""I will be answering all questions on the vice president's behalf.""]** — Mówca: **Player**
> ""I will be answering all questions on the vice president's behalf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[132]`
Mówca: **Reporter**
> ""Are you implying that you and the covert agent posing as President Rayne's secretary were engaged in intimate relations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Petr Vectern**
> ""Yes. And it wasn't the only such affair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Petr Vectern**
> ""I abused my power as vice president to take advantage of multiple young women. I deeply regret my behavior, although I recognize that will never change what they went through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Petr Vectern**
> ""Evelyn, if you're watching this, I don't expect you to ever forgive me. Just know that I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Reporter**
> ""Mr. President, were you aware of these affairs as they were happening?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[137]`

### Węzeł `[137]`
**[WYBÓR GRACZA: ""I had my suspicions...""]** — Mówca: **Player**
> ""I had my suspicions...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
**[WYBÓR GRACZA: "Gesture to Lucian to end the press conference."]** — Mówca: **Player_Italic**
> "I gestured to Lucian to end the press conference."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Narrator**
> "Lucian interjected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Lucian Galade**
> "“Neither the president nor the vice president will be taking any more questions. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[141]`
Mówca: **Reporter**
> ""President Rayne, was Mr. Vectern implying that he and the covert agent posing as President Rayne's secretary were engaged in intimate relations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`
  - -> `[144]`

### Węzeł `[142]`
**[WYBÓR GRACZA: ""No.""]** — Mówca: **Player**
> ""No.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[143]`
**[WYBÓR GRACZA: ""Yes.""]** — Mówca: **Player**
> ""Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
**[WYBÓR GRACZA: ""Yes, and it wasn't the only such affair.""]** — Mówca: **Player**
> ""Yes, and it wasn't the only such affair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Reporter**
> ""Can you elaborate, please?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[146]`
Mówca: **Reporter**
> ""No further questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[147]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[149]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Reporter**
> ""But when Mr. Vectern says he broke his marriage vows--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[151]`
Mówca: **Petr Vectern**
> ""What the hell, Anton? We never discussed this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[154]`
  - -> `[153]`
  - -> `[155]`

### Węzeł `[152]`
**[WYBÓR GRACZA: ""Sorry, Lucian made me do it.""]** — Mówca: **Player**
> ""Sorry, Lucian made me do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[153]`
**[WYBÓR GRACZA: ""What else did you think would happen?""]** — Mówca: **Player**
> ""What else did you think would happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[154]`
**[WYBÓR GRACZA: ""It's for the good of Sordland. You'll understand someday.""]** — Mówca: **Player**
> ""It's for the good of Sordland. You'll understand someday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
**[WYBÓR GRACZA: ""Sorry. Someone has to take the fall.""]** — Mówca: **Player**
> ""Sorry. Someone has to take the fall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Narrator**
> "Petr looked at me in disbelief, then shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Petr Vectern**
> ""I guess I had this coming, the way I've been carrying on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Petr Vectern**
> ""I just didn't think my best friend would be the one to stick in the knife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Narrator**
> "The reporters were becoming hard to ignore. One woman in the front row looked particularly insistent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Reporter**
> ""Mr. Vectern!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
**[WYBÓR GRACZA: "Let Petr take the question."]** — Mówca: **Player_Italic**
> "I nodded at Petr to take her question."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[162]`
**[WYBÓR GRACZA: ""I will be answering all questions on the vice president's behalf.""]** — Mówca: **Player**
> ""I will be answering all questions on the vice president's behalf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[163]`
Mówca: **Reporter**
> ""Can you give us a comment on your resignation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Petr Vectern**
> ""No, President Rayne just about covered it. I'm a terrible vice president and a worse husband. And a... a sad old drunk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Reporter**
> ""Are you implying that you and the covert agent posing as President Rayne's secretary were engaged in intimate relations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Petr Vectern**
> ""Relations, yes. Intimate? I thought so at the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[167]`
**[WYBÓR GRACZA: ""Yes.""]** — Mówca: **Player**
> ""Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Reporter**
> ""Were you aware of this when it was happening?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`
  - -> `[223]`

### Węzeł `[169]`
Mówca: **Reporter**
> ""President Rayne, were you implying that Mr. Vectern and the covert agent posing as your secretary were engaged in intimate relations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[170]`

### Węzeł `[170]`
**[WYBÓR GRACZA: ""Yes, and it wasn't the only such affair.""]** — Mówca: **Player**
> ""Yes, and it wasn't the only such affair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Reporter**
> ""Were you aware of those affairs while they were happening?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`
  - -> `[223]`

### Węzeł `[172]`
**[WYBÓR GRACZA: "Gesture to Lucian to end the press conference."]** — Mówca: **Player_Italic**
> "I gestured to Lucian to end the press conference."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[173]`
**[WYBÓR GRACZA: ""I had my suspicions...""]** — Mówca: **Player**
> ""I had my suspicions...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Lucian Galade**
> "“Neither the President nor the Vice President will be taking any more questions. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[175]`
Mówca: **Narrator**
> "Lucian interjected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[176]`
**[WYBÓR GRACZA: ""I'm not taking any questions.""]** — Mówca: **Player**
> ""I'm not taking any questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[177]`
**[WYBÓR GRACZA: ""I will take exactly one question.""]** — Mówca: **Player**
> ""I will take exactly one question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Reporter**
> ""President Rayne, were you implying that Mr. Vectern and the covert agent posing as your secretary were engaged in intimate relations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`

### Węzeł `[179]`
**[WYBÓR GRACZA: ""Yes.""]** — Mówca: **Player**
> ""Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[180]`
**[WYBÓR GRACZA: ""Yes, and it wasn't the only such affair.""]** — Mówca: **Player**
> ""Yes, and it wasn't the only such affair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[181]`
**[WYBÓR GRACZA: ""I had my suspicions...""]** — Mówca: **Player**
> ""I had my suspicions...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[182]`
**[WYBÓR GRACZA: "Gesture to Lucian to end the press conference."]** — Mówca: **Player_Italic**
> "I gestured to Lucian to end the press conference."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[183]`
Mówca: **Reporter**
> ""Were you aware of this when it was happening?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[181]`

### Węzeł `[184]`
Mówca: **Reporter**
> ""Were you aware of those affairs while they were happening?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[181]`

### Węzeł `[185]`
Mówca: **Narrator**
> "Lucian interjected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Lucian Galade**
> "“The president will not be taking any further questions. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Narrator**
> "The reporters reluctantly dispersed. Lucian and I looked at each other for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[188]`
Mówca: **Narrator**
> "The reporters reluctantly dispersed. Lucian, Petr and I looked at each other for what seemed like an eternity. Finally, Petr lowered his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[189]`
**[WYBÓR GRACZA: ""Too soon.""]** — Mówca: **Player**
> ""Too soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[190]`
Mówca: **Lucian Galade**
> ""Mr. Vectern certainly made a scene, but it appears that you will make it out of this unscathed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Lucian Galade**
> ""Of course, there's now the matter of replacing both your secretary and your vice president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
**[WYBÓR GRACZA: ""I have a few candidates in mind.""]** — Mówca: **Player**
> ""I have a few candidates in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[193]`
**[WYBÓR GRACZA: ""You're a little old to be my secretary, Lucian.""]** — Mówca: **Player**
> ""You're a little old to be my secretary, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[194]`
Mówca: **Petr Vectern**
> ""I guess I'll go to the palace and start packing my things, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`
  - -> `[197]`

### Węzeł `[195]`
**[WYBÓR GRACZA: ""I'll come with you.""]** — Mówca: **Player**
> ""I'll come with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[196]`
**[WYBÓR GRACZA: ""Goodbye, Petr.""]** — Mówca: **Player**
> ""Goodbye, Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[197]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I said nothing and watched Petr descend the courthouse steps to his car, alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[198]`
Mówca: **Narrator**
> "I watched Petr descend the courthouse stairs to his car, alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[199]`
Mówca: **Narrator**
> "Petr shook his head. I watched him descend the courthouse steps to his car, alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[200]`
Mówca: **Reporter**
> ""Sir, you just had your vice president arraigned in full view of the public--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[201]`
Mówca: **Lucian Galade**
> ""Very good, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[202]`
Mówca: **Lucian Galade**
> ""Very well. We shall discuss it tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Lucian Galade**
> ""Very funny, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Narrator**
> "We walked back up the stairs to the courthouse to watch the rest of the trial."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[205]`
Mówca: **Narrator**
> "I watched him descend the courthouse steps to his car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[206]`
Mówca: **Narrator**
> "I watched Petr descend the courthouse stairs to his car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[207]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I said nothing and watched Petr descend the courthouse steps to his car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[208]`
**[WYBÓR GRACZA: ""I'll come with you.""]** — Mówca: **Player**
> ""I'll come with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[209]`
Mówca: **Narrator**
> "The reporters reluctantly dispersed. Lucian, Petr and I looked at each other for what seemed like an eternity. Finally, Petr lowered his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[210]`
Mówca: **Petr Vectern**
> ""I guess I'll go to the palace and start packing my things, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[211]`
  - -> `[207]`

### Węzeł `[211]`
**[WYBÓR GRACZA: ""Goodbye, Petr.""]** — Mówca: **Player**
> ""Goodbye, Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Petr Vectern**
> ""Thanks, but I think I need some time alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[213]`
Mówca: **Petr Vectern**
> ""See you around, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[214]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrSelfResigned = true; BaseGameSupport.Journal_Turn08_SecondScandal_PetrSelfResigned = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_PetrSelfResigned"] = true;
Variable["BaseGameSupport.Journal_Turn08_SecondScandal_PetrSelfResigned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[215]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[217]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
**[WYBÓR GRACZA: ""We won't be taking any questions. Thank you.""]** — Mówca: **Player**
> ""We won't be taking any questions. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Narrator**
> "She stood up from her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[220]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[222]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[223]`
**[WYBÓR GRACZA: ""No.""]** — Mówca: **Player**
> ""No.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[224]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_RumburgBlamed = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[34]`
  - -> `[36]`

### Węzeł `[225]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_RumburgBlamed = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[102]`

### Węzeł `[226]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_RumburgBlamed = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[227]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_RumburgBlamed = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlamed = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlamed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[229]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlamed = true;
BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlamed"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[230]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlamed = true;
BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlamed"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[231]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlamed = true;
BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlamed"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[232]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_SecondScandal_PetrForcedResign = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_PetrForcedResign"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[233]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_SecondScandal_PetrTrialled = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_PetrTrialled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[234]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[236]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[239]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[240]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[241]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 3;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[244]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[246]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[249]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 3;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[251]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[252]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[253]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 3;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[254]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[255]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[256]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaTrialled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaTrialled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[258]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_LiviaTrialled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_LT_Livia_Investigate_Trialled = true; BaseGameSupport.News_Turn08_HP_Livia_Investigate_Trialled = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_LT_Livia_Investigate_Trialled"] = true;
Variable["BaseGameSupport.News_Turn08_HP_Livia_Investigate_Trialled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[260]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrForcedResign == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrForcedResign == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[262]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_PetrForcedResign == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[263]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_ST_Press_Conference_Blame_Petr_Media = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_Press_Conference_Blame_Petr_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[264]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[266]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[267]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_R_Press_Conference_Blame_Petr = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_Press_Conference_Blame_Petr"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrSelfResigned == true && BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrSelfResigned == true && BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrSelfResigned"] == true  and  Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_PetrSelfResigned == true && BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrSelfResigned"] == true  and  Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_R_Share_Blame_Petr_Resigns = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_Share_Blame_Petr_Resigns"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_DenyEverything == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_DenyEverything == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[274]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_DenyEverything == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[275]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_ST_No_Blame_Media = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_No_Blame_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[276]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[279]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_R_Livia_Investigate_Trialled = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_Livia_Investigate_Trialled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[280]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[282]`

### Węzeł `[281]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[282]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[283]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[285]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_ST_No_Blame_NoMedia = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_No_Blame_NoMedia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[287]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[289]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[290]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_A_Petr_Protected == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_A_Petr_Protected == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_A_Petr_Protected"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[292]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_A_Petr_Protected == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_A_Petr_Protected"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrTrialled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrTrialled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[295]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_PetrTrialled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[298]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[299]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrSelfResigned == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrSelfResigned == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrSelfResigned"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[301]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_PetrSelfResigned == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrSelfResigned"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[302]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_KeptAsVP = true;
BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = false)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_KeptAsVP"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[303]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Arrested = true;
BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = false;

BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP = true;
BaseGameSupport.Codex_Characters_Others_EvelynVectern = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Arrested"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[304]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dismissed = true;
BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = false;

BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP = true;
BaseGameSupport.Codex_Characters_Others_EvelynVectern = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dismissed"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[305]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resigned = true;
BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = false;

BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP = true;
BaseGameSupport.Codex_Characters_Others_EvelynVectern = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resigned"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[306]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Petr_Dead = true;
BaseGame.Petr_isVP = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Petr_Dead"] = true;
Variable["BaseGame.Petr_isVP"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[307]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Others_LiviaSuno = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy = true; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[308]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrTrialled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrTrialled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_PetrTrialled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[311]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == false && BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[313]`

### Węzeł `[312]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == false && BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == false  and  Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == false && BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == false  and  Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[314]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_ST_Press_Conference_Blame_Petr_NoMedia = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_Press_Conference_Blame_Petr_NoMedia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[315]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_PressConference_PetrKnowsResigning == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_PressConference_PetrKnowsResigning == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_PressConference_PetrKnowsResigning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_PressConference_PetrKnowsResigning == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_PressConference_PetrKnowsResigning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[318]`
Mówca: **Narrator**
> "How could I forget? I was about to blame my best friend for a scandal that would otherwise shatter my administration. Petr hadn't said a word to me since I broke the news to him in my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[319]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_PressConference_PetrKnowsResigning == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_PressConference_PetrKnowsResigning == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_PressConference_PetrKnowsResigning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_PressConference_PetrKnowsResigning == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_PressConference_PetrKnowsResigning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[322]`
Mówca: **Narrator**
> "The clamor of reporters was growing louder. Petr seemed to shrink behind the podium, his charisma failing him at last."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Petr Vectern**
> ""That's it, then. No going back from this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[324]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_PressConference_PetrKnowsResigning == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_PressConference_PetrKnowsResigning == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_PressConference_PetrKnowsResigning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_PressConference_PetrKnowsResigning == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_PressConference_PetrKnowsResigning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[327]`
Mówca: **Lucian Galade**
> ""A shame about your friend, Mr. President. But it appears you will make it out of this unscathed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[328]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[330]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[331]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_NoMedia = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_NoMedia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[332]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: (BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true) || (BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true && BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`
  - -> `[334]`

### Węzeł `[333]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: (BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true) || (BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true && BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true)  or  (Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[334]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !((BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true) || (BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true && BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true)  or  (Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[335]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_Media = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[336]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[338]`

### Węzeł `[337]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[338]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[339]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Petr Vectern", "Former Vice President");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Petr Vectern","Former Vice President");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[340]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Petr Vectern", "Former Vice President");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Petr Vectern","Former Vice President");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[341]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Petr Vectern", "Former Vice President");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Petr Vectern","Former Vice President");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[342]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlaySoundEffect("PressRelease");)*
- **Efekt (`userScript`):** `PlaySoundEffect("PressRelease");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[343]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
