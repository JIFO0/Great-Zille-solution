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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[26]` | **""You're positive the bodies won't be found?""** | `[19]` **Karl Greiser**: ""Yes, Mr. President?"" | `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true) == false`<br>`(Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true) == false` | *Brak zmian stanu* | `[32]` **Karl Greiser**: ""They've both been dissolved in ..." |
| `[27]` | **""How exactly did you dispose of Mr. Vectern and Ms. Suno?""** | `[19]` **Karl Greiser**: ""Yes, Mr. President?"" | `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true) == false`<br>`(Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true) == false` | *Brak zmian stanu* | `[32]` **Karl Greiser**: ""They've both been dissolved in ..." |
| `[28]` | **""Where exactly are Mr. Vectern and Ms. Suno being held?""** | `[19]` **Karl Greiser**: ""Yes, Mr. President?"" | `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true` | *Brak zmian stanu* | `[30]` **Karl Greiser**: ""In individual cells on the top ..." |
| `[29]` | **""How are Mr. Vectern and Miss Suno holding up in detention?""** | `[19]` **Karl Greiser**: ""Yes, Mr. President?"" | `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true` | *Brak zmian stanu* | `[31]` **Karl Greiser**: ""Mr. Vectern is still quite shak..." |
| `[33]` | **""Good work.""** | `[32]` **Karl Greiser**: ""They've both been dissolved in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Karl Greiser**: ""It's my pleasure, sir."" |
| `[34]` | **""That's disgusting.""** | `[32]` **Karl Greiser**: ""They've both been dissolved in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Karl Greiser**: ""My men and I do what we must to..." |
| `[37]` | **""Good. Let them both rot.""** | `[30]` **Karl Greiser**: ""In individual cells on the top ..."<br>`[31]` **Karl Greiser**: ""Mr. Vectern is still quite shak..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Karl Greiser**: ""Pleasure to serve you, sir."" |
| `[38]` | **""Tell the guards Petr can have a little steak once in a while. As a treat.""** | `[30]` **Karl Greiser**: ""In individual cells on the top ..."<br>`[31]` **Karl Greiser**: ""Mr. Vectern is still quite shak..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Karl Greiser**: ""I will, sir."" |
| `[45]` | **""Good afternoon.""** | `[44]` **Narrator**: "He and I made our way to the dow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Player**: ""I would like to address the gro..."<br>`[79]` **Player**: ""I am here to address an inciden..." |
| `[46]` | **""Please be seated.""** | `[44]` **Narrator**: "He and I made our way to the dow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Player**: ""I would like to address the gro..."<br>`[79]` **Player**: ""I am here to address an inciden..." |
| `[47]` | **""Thank you for coming.""** | `[44]` **Narrator**: "He and I made our way to the dow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Player**: ""I would like to address the gro..."<br>`[79]` **Player**: ""I am here to address an inciden..." |
| `[49]` | **""Rest assured that both offenders have been dealt with.""** | `[48]` **Narrator**: "The journalists started talking...." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSu...`<br>`Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_De...` | `[55]` **Player**: ""I am currently reviewing highly..."<br>`[56]` **Player**: ""This incident shall not interfe..."<br>*(oraz 1 innych odgałęzień)* |
| `[50]` | **""Unfortunately, before they could be punished for their misdeeds, both disappeared..."** | `[48]` **Narrator**: "The journalists started talking...." | `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true` | `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSu...`<br>`Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Ra...` | `[55]` **Player**: ""I am currently reviewing highly..."<br>`[56]` **Player**: ""This incident shall not interfe..."<br>*(oraz 1 innych odgałęzień)* |
| `[51]` | **""Rest assured that the offenders have now been imprisoned.""** | `[48]` **Narrator**: "The journalists started talking...." | `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true` | `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSu...`<br>`Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVe...`<br>*(+1 skryptów)* | `[55]` **Player**: ""I am currently reviewing highly..."<br>`[56]` **Player**: ""This incident shall not interfe..."<br>*(oraz 1 innych odgałęzień)* |
| `[55]` | **""I am currently reviewing highly qualified candidates for both positions.""** | `[49]` **Player**: ""Rest assured that both offender..."<br>`[50]` **Player**: ""Unfortunately, before they coul..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "By now the reporters were nearly..." |
| `[56]` | **""This incident shall not interfere with the completion of my presidential goals.""** | `[49]` **Player**: ""Rest assured that both offender..."<br>`[50]` **Player**: ""Unfortunately, before they coul..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "By now the reporters were nearly..." |
| `[57]` | **""The rest of my staff is now under investigation to root out any other potential w..."** | `[49]` **Player**: ""Rest assured that both offender..."<br>`[50]` **Player**: ""Unfortunately, before they coul..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "By now the reporters were nearly..." |
| `[62]` | **""Both offenders have now been fired.""** | `[48]` **Narrator**: "The journalists started talking...." | `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true` | `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSu...`<br>`Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVe...`<br>*(+1 skryptów)* | `[55]` **Player**: ""I am currently reviewing highly..."<br>`[56]` **Player**: ""This incident shall not interfe..."<br>*(oraz 1 innych odgałęzień)* |
| `[71]` | **""Not very well, to be honest. But the pain will pass in time.""** | `[70]` **Narrator**: "I said a silent prayer of thanks..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Narrator**: "She and the other reporters nodded." |
| `[72]` | **""I don't have time to dwell on it. I must move forward so I can continue to do the..."** | `[70]` **Narrator**: "I said a silent prayer of thanks..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Narrator**: "She and the other reporters nodded." |
| `[73]` | **""About as well as can be expected. I'm looking forward to having this all behind me.""** | `[70]` **Narrator**: "I said a silent prayer of thanks..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Narrator**: "She and the other reporters nodded." |
| `[78]` | **""I would like to address the growing rumors concerning Vice President Petr Vectern..."** | `[45]` **Player**: ""Good afternoon.""<br>`[46]` **Player**: ""Please be seated.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Player**: ""Unbeknownst to me and the rest ..."<br>`[81]` **Player**: ""Unbeknownst to my administratio..." |
| `[79]` | **""I am here to address an incident involving Vice President Petr Vectern and my sec..."** | `[45]` **Player**: ""Good afternoon.""<br>`[46]` **Player**: ""Please be seated.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Player**: ""Unbeknownst to me and the rest ..."<br>`[81]` **Player**: ""Unbeknownst to my administratio..." |
| `[80]` | **""Unbeknownst to me and the rest of the administration, these two employees were ca..."** | `[78]` **Player**: ""I would like to address the gro..."<br>`[79]` **Player**: ""I am here to address an inciden..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Motivatio...` | `[48]` **Narrator**: "The journalists started talking...." |
| `[81]` | **""Unbeknownst to my administration, these two employees were plotting a conspiracy ..."** | `[78]` **Player**: ""I would like to address the gro..."<br>`[79]` **Player**: ""I am here to address an inciden..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Motivatio...` | `[48]` **Narrator**: "The journalists started talking...." |
| `[106]` | **""Yes, we've got our best men on the case.""** | `[101]` **Reporter**: ""Mr. President, are you attempti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Reporter**: ""And what evidence do you have o..." |
| `[107]` | **""Unfortunately, they covered their tracks too well.""** | `[101]` **Reporter**: ""Mr. President, are you attempti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Reporter**: ""And what evidence do you have o..." |
| `[108]` | **""The state is under attack, and you're asking about evidence?""** | `[100]` **Reporter**: ""Mr. President, what evidence of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Reporter**: ""And exactly how long will the s..." |
| `[109]` | **""I cannot disclose the evidence at this time.""** | `[100]` **Reporter**: ""Mr. President, what evidence of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Reporter**: ""And exactly how long will the s..." |
| `[110]` | **""They've gotten what they deserve.""** | `[96]` **Reporter**: ""Mr. President... what exactly d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Reporter**: ""You haven't answered my question."" |
| `[111]` | **""Both have expressed a refusal to speak to the media.""** | `[92]` **Reporter**: ""Mr. President, can either Miss ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Reporter**: ""And where exactly are they loca..." |
| `[112]` | **""The state has exercised its discretion as to the appropriate punishment.""** | `[96]` **Reporter**: ""Mr. President... what exactly d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Reporter**: ""You haven't answered my question."" |
| `[113]` | **""Both are currently taking some time away from Holsord to reflect on their misbeha..."** | `[92]` **Reporter**: ""Mr. President, can either Miss ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Reporter**: ""And where exactly are they loca..." |
| `[114]` | **""Our values are under attack, and you're asking whether prison is too harsh?""** | `[85]` **Reporter**: ""Mr. President, wouldn't you agr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Reporter**: ""And exactly how long will the s..." |
| `[115]` | **""Not for such high-ranking officials, no.""** | `[85]` **Reporter**: ""Mr. President, wouldn't you agr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Reporter**: ""And exactly how long will the s..." |
| `[116]` | **""No. They covered their tracks too well.""** | `[105]` **Reporter**: ""Mr. President, do you have any ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Reporter**: ""And were you aware of the multi..." |
| `[117]` | **""Possibly the border. We've got our best men on the case.""** | `[105]` **Reporter**: ""Mr. President, do you have any ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Reporter**: ""And were you aware of the multi..." |
| `[123]` | **""No further questions.""** | `[118]` **Reporter**: ""And exactly how long will the s..."<br>`[119]` **Reporter**: ""And where exactly are they loca..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Reporter**: ""But--"" |
| `[124]` | **"Gesture to Lucian to end the press conference."** | `[118]` **Reporter**: ""And exactly how long will the s..."<br>`[119]` **Reporter**: ""And where exactly are they loca..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Narrator**: "Lucian smoothly interjected." |
| `[129]` | **""That went well.""** | `[128]` **Narrator**: "The reporters reluctantly left t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Lucian Galade**: ""Marcel Koronti has come through..."<br>`[135]` **Lucian Galade**: ""The press may have been left wi..." |
| `[130]` | **""So? Am I screwed?""** | `[128]` **Narrator**: "The reporters reluctantly left t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Lucian Galade**: ""Marcel Koronti has come through..."<br>`[135]` **Lucian Galade**: ""The press may have been left wi..." |
| `[139]` | **""Too soon.""** | `[141]` **Lucian Galade**: ""In the meantime, sir, there's t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Lucian Galade**: ""Very well. We shall discuss it ..." |
| `[140]` | **""You're a little old to be my secretary, Lucian.""** | `[141]` **Lucian Galade**: ""In the meantime, sir, there's t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Lucian Galade**: ""Very funny, sir."" |
| `[142]` | **""I have a few candidates in mind.""** | `[141]` **Lucian Galade**: ""In the meantime, sir, there's t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Lucian Galade**: ""Very good, sir."" |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "It was late in the afternoon, and I was nervously pacing ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It had been several days since I'd had Karl Greiser detain Livia and Petr. Word was about to get out that both the vice president and the president's secretary were in jail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "At Lucian's urging, I had arranged a press conference to ..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Livia == true && BaseGame.Turn08_SecondScandal_Detained_Petr == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Livia == true && B..."*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_Detained_Livia == true &&..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Livia == true && BaseGame.Turn08_SecondScandal_Detained_Petr == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "It had been several days since I'd had Karl Greiser detai..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_Detained_Livia == true && BaseGame.Turn08_SecondScandal_Detained_Petr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == ..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == ..."*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia =..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "It had been several days since I'd had Karl Greiser secre..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "It had been several days since I'd had Karl Greiser secre..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "It had been several days since I'd had Karl Greiser secretly arrest Livia and Petr. It wouldn't be long before word got out that both the vice president and the president's secretary had gone missing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "At Lucian's urging, I had arranged a press conference to ..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "It had been several days since I'd had Karl Greiser secretly kill Livia and Petr. It wouldn't be long before word got out that both the vice president and the president's secretary had gone missing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "At Lucian's urging, I had arranged a press conference to ..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "At Lucian's urging, I had arranged a press conference to get ahead of the narrative."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Of course, our deal with Marcel Koronti meant journalists..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "I was still reeling from the loss of two of my closest co..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "Of course, our deal with Marcel Koronti meant journalists wouldn't be asking too many questions. Still, one had to keep up appearances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "The conference was slated to begin soon. I rang up Karl."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "I was still reeling from the loss of two of my closest colleagues -- and my former best friend. I had to get my story straight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "The conference was slated to begin soon. I rang up Karl."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "The conference was slated to begin soon. I rang up Karl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Karl Greiser: ""Yes, Mr. President?""*)

### Węzeł `[19]`
Mówca: **Karl Greiser**
> ""Yes, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Livia == true && B..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == ..."*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia =..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player: ""Where exactly are Mr. Vectern and Ms. Suno being held?""*)
  - -> `[29]` (*Player: ""How are Mr. Vectern and Miss Suno holding up in detention?""*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: ""How exactly did you dispose of Mr. Vectern and Ms. Suno?""*)
  - -> `[26]` (*Player: ""You're positive the bodies won't be found?""*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Livia == true && BaseGame.Turn08_SecondScandal_Detained_Petr == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Livia == true && B..."*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_Detained_Livia == true &&..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Livia == true && BaseGame.Turn08_SecondScandal_Detained_Petr == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player: ""Where exactly are Mr. Vectern and Ms. Suno being held?""*)
  - -> `[29]` (*Player: ""How are Mr. Vectern and Miss Suno holding up in detention?""*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_Detained_Livia == true && BaseGame.Turn08_SecondScandal_Detained_Petr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == ..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""You're positive the bodies won't be found?""]** — Mówca: **Player**
> ""You're positive the bodies won't be found?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true) == false` AND `(Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[19]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Karl Greiser: ""They've both been dissolved in an extremely powerful aci..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""How exactly did you dispose of Mr. Vectern and Ms. Suno?""]** — Mówca: **Player**
> ""How exactly did you dispose of Mr. Vectern and Ms. Suno?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true) == false` AND `(Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[19]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Karl Greiser: ""They've both been dissolved in an extremely powerful aci..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: ""Where exactly are Mr. Vectern and Ms. Suno being held?""]** — Mówca: **Player**
> ""Where exactly are Mr. Vectern and Miss Suno being held?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true`
- **Kontekst wejściowy (poprzednik):** `[19]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Karl Greiser: ""In individual cells on the top floor of Antel Rock, sir...."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: ""How are Mr. Vectern and Miss Suno holding up in detention?""]** — Mówca: **Player**
> ""How are Mr. Vectern and Miss Suno holding up in detention?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true`
- **Kontekst wejściowy (poprzednik):** `[19]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Karl Greiser: ""Mr. Vectern is still quite shaken, sir. Miss Suno appear..."*)

### Węzeł `[30]`
Mówca: **Karl Greiser**
> ""In individual cells on the top floor of Antel Rock, sir. Accessible by two guards, each of whom know only half of the combination required to enter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: ""Good. Let them both rot.""*)
  - -> `[38]` (*Player: ""Tell the guards Petr can have a little steak once in a w..."*)

### Węzeł `[31]`
Mówca: **Karl Greiser**
> ""Mr. Vectern is still quite shaken, sir. Miss Suno appears calmer, although she continues to ask for a lawyer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: ""Good. Let them both rot.""*)
  - -> `[38]` (*Player: ""Tell the guards Petr can have a little steak once in a w..."*)

### Węzeł `[32]`
Mówca: **Karl Greiser**
> ""They've both been dissolved in an extremely powerful acidic solution, sir. No trace has been left.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: ""Good work.""*)
  - -> `[34]` (*Player: ""That's disgusting.""*)

### Węzeł `[33]`
**[WYBÓR GRACZA: ""Good work.""]** — Mówca: **Player**
> ""Good work.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Karl Greiser: ""It's my pleasure, sir.""*)

### Węzeł `[34]`
**[WYBÓR GRACZA: ""That's disgusting.""]** — Mówca: **Player**
> ""That's disgusting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Karl Greiser: ""My men and I do what we must to serve Sordland, sir.""*)

### Węzeł `[35]`
Mówca: **Karl Greiser**
> ""My men and I do what we must to serve Sordland, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Petr_Dead = true; BaseGame.Petr_isVP = false;"*)

### Węzeł `[36]`
Mówca: **Karl Greiser**
> ""It's my pleasure, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Petr_Dead = true; BaseGame.Petr_isVP = false;"*)

### Węzeł `[37]`
**[WYBÓR GRACZA: ""Good. Let them both rot.""]** — Mówca: **Player**
> ""Good. Let them both rot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Karl Greiser), `[31]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Karl Greiser: ""Pleasure to serve you, sir.""*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""Tell the guards Petr can have a little steak once in a while. As a treat.""]** — Mówca: **Player**
> ""Tell the guards Petr can have a little steak once in a while. As a treat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Karl Greiser), `[31]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Karl Greiser: ""I will, sir.""*)

### Węzeł `[39]`
Mówca: **Karl Greiser**
> ""I will, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "The moment I hung up. Lucian knocked on my door."*)

### Węzeł `[40]`
Mówca: **Karl Greiser**
> ""Pleasure to serve you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "The moment I hung up. Lucian knocked on my door."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "The moment I hung up. Lucian knocked on my door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lucian Galade: ""It's time, Mr. President.""*)

### Węzeł `[42]`
Mówca: **Narrator**
> "It was late in the afternoon, and I was nervously pacing around my office. My new secretary would start next week."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Livia == true && B..."*)

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""It's time, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "He and I made our way to the downstairs conference room. ..."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "He and I made our way to the downstairs conference room. A dozen journalists were already waiting, notepads at the ready. They all stood up when we entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""Please be seated.""*)
  - -> `[45]` (*Player: ""Good afternoon.""*)
  - -> `[47]` (*Player: ""Thank you for coming.""*)

### Węzeł `[45]`
**[WYBÓR GRACZA: ""Good afternoon.""]** — Mówca: **Player**
> ""Good afternoon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player: ""I would like to address the growing rumors concerning Vi..."*)
  - -> `[79]` (*Player: ""I am here to address an incident involving Vice Presiden..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: ""Please be seated.""]** — Mówca: **Player**
> ""Please be seated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player: ""I would like to address the growing rumors concerning Vi..."*)
  - -> `[79]` (*Player: ""I am here to address an incident involving Vice Presiden..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: ""Thank you for coming.""]** — Mówca: **Player**
> ""Thank you for coming.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player: ""I would like to address the growing rumors concerning Vi..."*)
  - -> `[79]` (*Player: ""I am here to address an incident involving Vice Presiden..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "The journalists started talking. I motioned for quiet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == t..."*)
  - -> `[49]` (*Player: ""Rest assured that both offenders have been dealt with.""*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == t..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA: ""Rest assured that both offenders have been dealt with.""]** — Mówca: **Player**
> ""Rest assured that both offenders have been dealt with.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Others_LiviaSuno = false..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: ""Unfortunately, before they could be punished for their misdeeds, both disappeared. It is assumed that they ran away together.""]** — Mówca: **Player**
> ""Unfortunately, before they could be punished for their misdeeds, both disappeared. It is assumed that they ran away together.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Others_LiviaSuno = false..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: ""Rest assured that the offenders have now been imprisoned.""]** — Mówca: **Player**
> ""Rest assured that the offenders have now been imprisoned.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true`
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Others_LiviaSuno = false..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_Detained_Petr == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == t..."*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr ==..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_Detained_Petr == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: ""Rest assured that the offenders have now been imprisoned.""*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_Detained_Petr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
**[WYBÓR GRACZA: ""I am currently reviewing highly qualified candidates for both positions.""]** — Mówca: **Player**
> ""I am currently reviewing highly qualified candidates for both positions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Player), `[50]` (Player), `[51]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "By now the reporters were nearly jumping out of their sea..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: ""This incident shall not interfere with the completion of my presidential goals.""]** — Mówca: **Player**
> ""This incident shall not interfere with the completion of my presidential goals.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Player), `[50]` (Player), `[51]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "By now the reporters were nearly jumping out of their sea..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: ""The rest of my staff is now under investigation to root out any other potential wrongdoing.""]** — Mówca: **Player**
> ""The rest of my staff is now under investigation to root out any other potential wrongdoing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Player), `[50]` (Player), `[51]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "By now the reporters were nearly jumping out of their sea..."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "By now the reporters were nearly jumping out of their seats, hands raised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lucian Galade: ""Please be aware that the president only has time to answ..."*)

### Węzeł `[59]`
Mówca: **Lucian Galade**
> ""Please be aware that the president only has time to answer a limited number of questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "He gestured to the reporter at the far end of the table."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "He gestured to the reporter at the far end of the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: ""I am currently reviewing highly qualified candidates for..."*)
  - -> `[56]` (*Player: ""This incident shall not interfere with the completion of..."*)
  - -> `[57]` (*Player: ""The rest of my staff is now under investigation to root ..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""Both offenders have now been fired.""]** — Mówca: **Player**
> ""Both offenders have now been fired.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Others_LiviaSuno = false..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: ""I am currently reviewing highly qualified candidates for..."*)
  - -> `[56]` (*Player: ""This incident shall not interfere with the completion of..."*)
  - -> `[57]` (*Player: ""The rest of my staff is now under investigation to root ..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: ""I am currently reviewing highly qualified candidates for..."*)
  - -> `[56]` (*Player: ""This incident shall not interfere with the completion of..."*)
  - -> `[57]` (*Player: ""The rest of my staff is now under investigation to root ..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: ""I am currently reviewing highly qualified candidates for..."*)
  - -> `[56]` (*Player: ""This incident shall not interfere with the completion of..."*)
  - -> `[57]` (*Player: ""The rest of my staff is now under investigation to root ..."*)

### Węzeł `[66]`
Mówca: **Reporter**
> ""Mr. President, how are you personally coping with this horrifying betrayal? It must be very hard on top of all the other stress you have to face in office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "I said a silent prayer of thanks to Marcel Koronti."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Reporter: ""Mr. President, how are you personally coping with this h..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair =..."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "I said a silent prayer of thanks to Marcel Koronti."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player: ""Not very well, to be honest. But the pain will pass in t..."*)
  - -> `[72]` (*Player: ""I don't have time to dwell on it. I must move forward so..."*)
  - -> `[73]` (*Player: ""About as well as can be expected. I'm looking forward to..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: ""Not very well, to be honest. But the pain will pass in time.""]** — Mówca: **Player**
> ""Not very well, to be honest. But the pain will pass in time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "She and the other reporters nodded."*)

### Węzeł `[72]`
**[WYBÓR GRACZA: ""I don't have time to dwell on it. I must move forward so I can continue to do the same with Sordland.""]** — Mówca: **Player**
> ""I don't have time to dwell on it. I must move forward so I can continue to do the same with Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "She and the other reporters nodded."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: ""About as well as can be expected. I'm looking forward to having this all behind me.""]** — Mówca: **Player**
> ""About as well as can be expected. I'm looking forward to having this all behind me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "She and the other reporters nodded."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "She and the other reporters nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Reporter: ""I see, Mr. President. Thank you.""*)

### Węzeł `[75]`
Mówca: **Reporter**
> ""I see, Mr. President. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "Lucian smoothly interjected."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "The journalists started talking. I motioned for quiet."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Conspiracy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Conspiracy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "The journalists started talking. I motioned for quiet."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: ""I would like to address the growing rumors concerning Vice President Petr Vectern and my secretary, Livia Suno.""]** — Mówca: **Player**
> ""I would like to address the growing rumors concerning Vice President Petr Vectern and my secretary, Livia Suno.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Player), `[46]` (Player), `[47]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: ""Unbeknownst to me and the rest of the administration, th..."*)
  - -> `[81]` (*Player: ""Unbeknownst to my administration, these two employees we..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: ""I am here to address an incident involving Vice President Petr Vectern and my secretary, Livia Suno.""]** — Mówca: **Player**
> ""I am here to address an incident involving Vice President Petr Vectern and my secretary, Livia Suno.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Player), `[46]` (Player), `[47]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: ""Unbeknownst to me and the rest of the administration, th..."*)
  - -> `[81]` (*Player: ""Unbeknownst to my administration, these two employees we..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: ""Unbeknownst to me and the rest of the administration, these two employees were carrying on a lurid affair in flagrant defiance of Sordish values.""]** — Mówca: **Player**
> ""Unbeknownst to me and the rest of the administration, these two employees were carrying on a lurid affair in flagrant defiance of Sordish values.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Player), `[79]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair =..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""Unbeknownst to my administration, these two employees were plotting a conspiracy to remove me from office.""]** — Mówca: **Player**
> ""Unbeknownst to my administration, these two employees were plotting a conspiracy to remove me from office.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Player), `[79]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Conspira..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair =..."*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Motivation_Affair"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired"*)

### Węzeł `[85]`
Mówca: **Reporter**
> ""Mr. President, wouldn't you agree that imprisonment is a rather harsh sentence for a simple affair?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: ""Not for such high-ranking officials, no.""*)
  - -> `[114]` (*Player: ""Our values are under attack, and you're asking whether p..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Reporter: ""Mr. President, wouldn't you agree that imprisonment is a..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Reporter: ""Mr. President, can either Miss Suno or Mr. Vectern be re..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Reporter: ""Mr. President... what exactly do you mean by 'dealt with'?""*)

### Węzeł `[92]`
Mówca: **Reporter**
> ""Mr. President, can either Miss Suno or Mr. Vectern be reached for comment about this incident?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player: ""Both have expressed a refusal to speak to the media.""*)
  - -> `[113]` (*Player: ""Both are currently taking some time away from Holsord to..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Reporter: ""Mr. President... what exactly do you mean by 'dealt with'?""*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison"*)

### Węzeł `[96]`
Mówca: **Reporter**
> ""Mr. President... what exactly do you mean by 'dealt with'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: ""They've gotten what they deserve.""*)
  - -> `[112]` (*Player: ""The state has exercised its discretion as to the appropr..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Reporter: ""Mr. President, what evidence of this conspiracy do you h..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Reporter: ""Mr. President, are you attempting to track the co-conspi..."*)

### Węzeł `[100]`
Mówca: **Reporter**
> ""Mr. President, what evidence of this conspiracy do you have that would warrant imprisonment?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: ""I cannot disclose the evidence at this time.""*)
  - -> `[108]` (*Player: ""The state is under attack, and you're asking about evide..."*)

### Węzeł `[101]`
Mówca: **Reporter**
> ""Mr. President, are you attempting to track the co-conspirators down?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player: ""Yes, we've got our best men on the case.""*)
  - -> `[107]` (*Player: ""Unfortunately, they covered their tracks too well.""*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Reporter: ""Mr. President, do you have any idea where Mr. Vectern an..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison"*)

### Węzeł `[105]`
Mówca: **Reporter**
> ""Mr. President, do you have any idea where Mr. Vectern and Miss Suno could have gone?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: ""Possibly the border. We've got our best men on the case.""*)
  - -> `[116]` (*Player: ""No. They covered their tracks too well.""*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""Yes, we've got our best men on the case.""]** — Mówca: **Player**
> ""Yes, we've got our best men on the case.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Reporter: ""And what evidence do you have of this so-called conspira..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""Unfortunately, they covered their tracks too well.""]** — Mówca: **Player**
> ""Unfortunately, they covered their tracks too well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Reporter: ""And what evidence do you have of this so-called conspira..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: ""The state is under attack, and you're asking about evidence?""]** — Mówca: **Player**
> ""The state is under attack, and you're asking about evidence?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Reporter: ""And exactly how long will the sentence be?""*)

### Węzeł `[109]`
**[WYBÓR GRACZA: ""I cannot disclose the evidence at this time.""]** — Mówca: **Player**
> ""I cannot disclose the evidence at this time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Reporter: ""And exactly how long will the sentence be?""*)

### Węzeł `[110]`
**[WYBÓR GRACZA: ""They've gotten what they deserve.""]** — Mówca: **Player**
> ""They've gotten what they deserve.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Reporter: ""You haven't answered my question.""*)

### Węzeł `[111]`
**[WYBÓR GRACZA: ""Both have expressed a refusal to speak to the media.""]** — Mówca: **Player**
> ""Both have expressed a refusal to speak to the media.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Reporter: ""And where exactly are they located right now?""*)

### Węzeł `[112]`
**[WYBÓR GRACZA: ""The state has exercised its discretion as to the appropriate punishment.""]** — Mówca: **Player**
> ""The state has exercised its discretion as to the appropriate punishment.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Reporter: ""You haven't answered my question.""*)

### Węzeł `[113]`
**[WYBÓR GRACZA: ""Both are currently taking some time away from Holsord to reflect on their misbehavior.""]** — Mówca: **Player**
> ""Both are currently taking some time away from Holsord to reflect on their misbehavior.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Reporter: ""And where exactly are they located right now?""*)

### Węzeł `[114]`
**[WYBÓR GRACZA: ""Our values are under attack, and you're asking whether prison is too harsh?""]** — Mówca: **Player**
> ""Our values are under attack, and you're asking whether prison is too harsh?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Reporter: ""And exactly how long will the sentence be?""*)

### Węzeł `[115]`
**[WYBÓR GRACZA: ""Not for such high-ranking officials, no.""]** — Mówca: **Player**
> ""Not for such high-ranking officials, no.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Reporter: ""And exactly how long will the sentence be?""*)

### Węzeł `[116]`
**[WYBÓR GRACZA: ""No. They covered their tracks too well.""]** — Mówca: **Player**
> ""No. They covered their tracks too well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Reporter: ""And were you aware of the multiple affairs Mr. Vectern i..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA: ""Possibly the border. We've got our best men on the case.""]** — Mówca: **Player**
> ""Possibly the border. We've got our best men on the case.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Reporter: ""And were you aware of the multiple affairs Mr. Vectern i..."*)

### Węzeł `[118]`
Mówca: **Reporter**
> ""And exactly how long will the sentence be?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: ""No further questions.""*)
  - -> `[124]` (*Player_Italic: "Gesture to Lucian to end the press conference."*)

### Węzeł `[119]`
Mówca: **Reporter**
> ""And where exactly are they located right now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: ""No further questions.""*)
  - -> `[124]` (*Player_Italic: "Gesture to Lucian to end the press conference."*)

### Węzeł `[120]`
Mówca: **Reporter**
> ""And what evidence do you have of this so-called conspiracy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: ""No further questions.""*)
  - -> `[124]` (*Player_Italic: "Gesture to Lucian to end the press conference."*)

### Węzeł `[121]`
Mówca: **Reporter**
> ""You haven't answered my question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: ""No further questions.""*)
  - -> `[124]` (*Player_Italic: "Gesture to Lucian to end the press conference."*)

### Węzeł `[122]`
Mówca: **Reporter**
> ""And were you aware of the multiple affairs Mr. Vectern is rumored to have previously conducted?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: ""No further questions.""*)
  - -> `[124]` (*Player_Italic: "Gesture to Lucian to end the press conference."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: ""No further questions.""]** — Mówca: **Player**
> ""No further questions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Reporter), `[119]` (Reporter), `[120]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Reporter: ""But--""*)

### Węzeł `[124]`
**[WYBÓR GRACZA: "Gesture to Lucian to end the press conference."]** — Mówca: **Player_Italic**
> "I gestured to Lucian."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Reporter), `[119]` (Reporter), `[120]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "Lucian smoothly interjected."*)

### Węzeł `[125]`
Mówca: **Reporter**
> ""But--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "Lucian smoothly interjected."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "Lucian smoothly interjected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Lucian Galade: ""Thank you for your time, ladies and gentlemen. That will..."*)

### Węzeł `[127]`
Mówca: **Lucian Galade**
> ""Thank you for your time, ladies and gentlemen. That will be all for today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "The reporters reluctantly left the conference room, leavi..."*)

### Węzeł `[128]`
Mówca: **Narrator**
> "The reporters reluctantly left the conference room, leaving Lucian and myself alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player: ""So? Am I screwed?""*)
  - -> `[129]` (*Player: ""That went well.""*)

### Węzeł `[129]`
**[WYBÓR GRACZA: ""That went well.""]** — Mówca: **Player**
> ""That went well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: ""So? Am I screwed?""]** — Mówca: **Player**
> ""So? Am I screwed?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Lucian Galade: ""Marcel Koronti has come through for us yet again. I'm no..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Lucian Galade: ""The press may have been left with some dangling question..."*)

### Węzeł `[134]`
Mówca: **Lucian Galade**
> ""Marcel Koronti has come through for us yet again. I'm not sure how much longer we can count on his kindness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Lucian Galade: ""In the meantime, sir, there's the matter of replacing bo..."*)

### Węzeł `[135]`
Mówca: **Lucian Galade**
> ""The press may have been left with some dangling questions. But if Mr. Greiser did his job correctly, they'll never find the answers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Lucian Galade: ""In the meantime, sir, there's the matter of replacing bo..."*)

### Węzeł `[136]`
Mówca: **Lucian Galade**
> ""Very funny, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "We left the conference room. On the long walk back to my ..."*)

### Węzeł `[137]`
Mówca: **Lucian Galade**
> ""Very good, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "We left the conference room. On the long walk back to my ..."*)

### Węzeł `[138]`
Mówca: **Lucian Galade**
> ""Very well. We shall discuss it tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "We left the conference room. On the long walk back to my ..."*)

### Węzeł `[139]`
**[WYBÓR GRACZA: ""Too soon.""]** — Mówca: **Player**
> ""Too soon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Lucian Galade: ""Very well. We shall discuss it tomorrow.""*)

### Węzeł `[140]`
**[WYBÓR GRACZA: ""You're a little old to be my secretary, Lucian.""]** — Mówca: **Player**
> ""You're a little old to be my secretary, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Lucian Galade: ""Very funny, sir.""*)

### Węzeł `[141]`
Mówca: **Lucian Galade**
> ""In the meantime, sir, there's the matter of replacing both your secretary and your vice president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player: ""Too soon.""*)
  - -> `[142]` (*Player: ""I have a few candidates in mind.""*)
  - -> `[140]` (*Player: ""You're a little old to be my secretary, Lucian.""*)

### Węzeł `[142]`
**[WYBÓR GRACZA: ""I have a few candidates in mind.""]** — Mówca: **Player**
> ""I have a few candidates in mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Lucian Galade: ""Very good, sir.""*)

### Węzeł `[143]`
Mówca: **Narrator**
> "We left the conference room. On the long walk back to my office, I started to think about who my new vice president should be."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn08_A_LiviaPetrGone = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn08_A_LiviaPetrGone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_PressReleases = true"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == t..."*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr ==..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: ""Both offenders have now been fired.""*)
  - -> `[50]` (*Player: ""Unfortunately, before they could be punished for their m..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Reporter: ""Mr. President, can either Miss Suno or Mr. Vectern be re..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn08_A_PressReleases = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn08_A_PressReleases"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia ==..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Petr == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Petr == true"*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_Detained_Petr == true)"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Petr == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Deta..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_Detained_Petr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_LiviaPetrGone = true"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true"*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr ==..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Deta..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Petr == true"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Detained = true;
BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = false;

BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP = true;
BaseGameSupport.Codex_Characters_Others_EvelynVectern = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Detained"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_LiviaPetrGone = true"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Detained = true;
BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = false;

BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP = true;
BaseGameSupport.Codex_Characters_Others_EvelynVectern = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Detained"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_LiviaPetrGone = true"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Others_LiviaSuno = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Arrested = false; 
BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed = true; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Arrested"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = fa..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Arrested = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Detained = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dismissed = true; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_KeptAsVP = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Killed = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resigned = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Suicide = false; 

BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP = true;
BaseGameSupport.Codex_Characters_Others_EvelynVectern = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern"] = false;
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
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Fired = true"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Arrested = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Detained = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dismissed = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_KeptAsVP = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Killed = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resigned = false; BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Suicide = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Arrested"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Detained"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dismissed"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_KeptAsVP"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Killed"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resigned"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Suicide"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_Prison = true"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Others_LiviaSuno = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Arrested = true; 
BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Arrested"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = fa..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Others_LiviaSuno = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Arrested = false; 
BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed = true; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Arrested"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway = true"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Others_LiviaSuno = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Arrested = false; 
BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed = true; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Arrested"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_DealtWith = ..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Petr_Dead = true;
BaseGame.Petr_isVP = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Petr_Dead"] = true;
Variable["BaseGame.Petr_isVP"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "The moment I hung up. Lucian knocked on my door."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_NoMedia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_NoMedia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true) || (BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true && BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia ==..."*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia ..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true) || (BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true && BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true)  or  (Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true) || (BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true && BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true)  or  (Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_Media = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
