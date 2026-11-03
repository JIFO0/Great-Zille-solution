# Sordland/Turn11/A_ImpeachmentTrial

- **ID konwersacji:** `246`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Sordland/Turn_11/246_A_ImpeachmentTrial.md`
- **Liczba węzłów dialogowych:** 203
- **Liczba wyborów gracza:** 8

---

## 1. Uczestnicy Sceny

- **[1]** Ovid Grecer
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[8]** Orso Hawker
- **[10]** Narrator
- **[23]** Didier Meye
- **[34]** Gloria Tory
- **[36]** Heron Garaci
- **[59]** Isabel Edmonds

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.ChiefJustice_HeronGaraci`
- `BaseGame.ChiefJustice_OrsoHawker`
- `BaseGame.ChiefJustice_OvidGrecer`
- `BaseGame.Decision_Turn08_VPSelection_Lucian`
- `BaseGame.LeakedScandal_Testify_ACP`
- `BaseGame.LeakedScandal_Testify_Heron`
- `BaseGame.LeakedScandal_Testify_Karl`
- `BaseGame.LeakedScandal_Testify_Lucian`
- `BaseGame.LeakedScandal_Testify_Oligarchs`
- `BaseGame.Leaker_ACP`
- `BaseGame.Leaker_HeronGaraci`
- `BaseGame.Leaker_KarlGreiser`
- `BaseGame.Leaker_LucianGalade`
- `BaseGame.Leaker_MarcelKoronti`
- `BaseGame.Leaker_WalterTusk`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Relations_Lucian_GaladeWonMatch`
- `BaseGame.Turn08_Action_Court_ExperiencedJustice`
- `BaseGame.Turn08_Action_Court_GloriaJustice`
- `BaseGame.Turn08_Action_Court_LoyalJustice`
- `BaseGame.Turn08_Action_Court_OldGuardReplaced`
- `BaseGame.Turn08_Action_Court_Shuffled`

### Modyfikowane zmienne stanu (`userScript`):
- `GameCondition.Turn11_A_ImpeachmentTrial`

### Skoki między-konwersacyjne:
- Węzeł `[38]` -> **[247] Sordland/Turn11/Nia ACP Evidence** (../Turn_11/247_Nia_ACP_Evidence.md), Węzeł `[1]`
- Węzeł `[43]` -> **[248] Sordland/Turn11/Lucian Evidence** (../Turn_11/248_Lucian_Evidence.md), Węzeł `[1]`
- Węzeł `[46]` -> **[252] Sordland/Turn11/Karl Evidence Main** (../Turn_11/252_Karl_Evidence_Main.md), Węzeł `[1]`
- Węzeł `[49]` -> **[250] Sordland/Turn11/Edith Evidence** (../Turn_11/250_Edith_Evidence.md), Węzeł `[1]`
- Węzeł `[123]` -> **[251] Sordland/Turn11/Heron Evidence** (../Turn_11/251_Heron_Evidence.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 3

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[121]` (Paskal Beniwoll): `Variable["GameCondition.Turn11_A_ImpeachmentTrial"] = true;`
- Węzeł `[198]` (Paskal Beniwoll): `End();`
- Węzeł `[202]` (Paskal Beniwoll): `UnlockAchievement("Game_Chessmaster");`

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
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I took a deep breath and opened the grand doors leading to the Supreme Court."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
**[WYBÓR GRACZA: "Take a seat."]** — Mówca: **Player_Italic**
> "I took a seat and everyone followed suit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[5]`
Mówca: **Narrator**
> "There were no camera flashes this time. No journalists or reporters. Nobody was allowed in the courtroom except the people related to my case."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "The attendees watched me quietly as I walked down the aisle to the defendant's table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[7]`
Mówca: **Narrator**
> "I looked at Chief Justice Heron Garaci. After he was seated, he pulled out his reading glasses and quickly rifled through the documents in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[8]`
Mówca: **Narrator**
> "I looked at Chief Justice Ovid Grecer. After he was seated, he pulled out his reading glasses and quickly rifled through the documents in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[9]`
Mówca: **Narrator**
> "I looked at Chief Justice Orso Hawker. After he was seated, he pulled out his reading glasses and quickly rifled through the documents in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[10]`
Mówca: **Heron Garaci**
> "“This court is now in session.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[11]`
Mówca: **Ovid Grecer**
> "“This court is now in session.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[12]`
Mówca: **Orso Hawker**
> "“This court is now in session.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[13]`
Mówca: **Narrator**
> "He put them down and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[14]`
Mówca: **Narrator**
> "A quiet chatter began in the courtroom which continued until the door behind the podium opened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "Rise up from your seat."]** — Mówca: **Player_Italic**
> "I rose up from my seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "Remain seated."]** — Mówca: **Player_Italic**
> "I remained seated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[17]`
Mówca: **Narrator**
> "He put them down and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[18]`
Mówca: **Narrator**
> "He put down the papers and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[19]`
Mówca: **Ovid Grecer**
> "“You may be seated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[20]`
Mówca: **Orso Hawker**
> "“You may be seated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
Mówca: **Heron Garaci**
> "“You may be seated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
Mówca: **Heron Garaci**
> "“I call the case of the impeachment charges against the President of Sordland. The case number is 385372.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[23]`
Mówca: **Heron Garaci**
> "“I call the case of the impeachment charges against the President of Sordland. The case number is 385372.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[24]`
Mówca: **Isabel Edmonds**
> "“I call the case of the impeachment charges against the President of Sordland. The case number is 385372.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[25]`
Mówca: **Isabel Edmonds**
> "“This case will proceed as follows.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[26]`
Mówca: **Isabel Edmonds**
> "“This case will proceed as follows.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[27]`
Mówca: **Gloria Tory**
> "“This case will proceed as follows.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Gloria Tory**
> "“Both parties will have the opportunity to present their evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[29]`
Mówca: **Isabel Edmonds**
> "“Both parties will have the opportunity to present their evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Isabel Edmonds**
> "“Both parties will have the opportunity to present their evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Isabel Edmonds**
> "“The prosecution will be called upon first, followed by the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[32]`
Mówca: **Isabel Edmonds**
> "“The prosecution will be called upon first, followed by the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[33]`
Mówca: **Gloria Tory**
> "“The prosecution will be called upon first, followed by the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Gloria Tory**
> "“After both parties present their claims, the court will present its final verdict on this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[35]`
Mówca: **Isabel Edmonds**
> "“After both parties present their claims, the court will present its final verdict on this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Isabel Edmonds**
> "“After both parties present their claims, the court will present its final verdict on this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Leaker_ACP == true && BaseGame.LeakedScandal_Testify_ACP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Leaker_ACP == true && BaseGame.LeakedScandal_Testify_ACP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Leaker_ACP"] == true  and  Variable["BaseGame.LeakedScandal_Testify_ACP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `247` (*Sordland/Turn11/Nia ACP Evidence*), Węzeł `[1]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Leaker_ACP == true && BaseGame.LeakedScandal_Testify_ACP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Leaker_ACP"] == true  and  Variable["BaseGame.LeakedScandal_Testify_ACP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[40]`
Mówca: **Narrator**
> "The Supreme Court justices entered and took their seats one by one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[41]`
Mówca: **Narrator**
> "A court clerk entered and ordered everyone to rise for the judges."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Leaker_LucianGalade == true && BaseGame.LeakedScandal_Testify_Lucian == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Leaker_LucianGalade == true && BaseGame.LeakedScandal_Testify_Lucian == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Leaker_LucianGalade"] == true  and  Variable["BaseGame.LeakedScandal_Testify_Lucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `248` (*Sordland/Turn11/Lucian Evidence*), Węzeł `[1]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Leaker_LucianGalade == true && BaseGame.LeakedScandal_Testify_Lucian == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Leaker_LucianGalade"] == true  and  Variable["BaseGame.LeakedScandal_Testify_Lucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Leaker_LucianGalade == false && (BaseGame.Leaker_KarlGreiser == true &&  BaseGame.LeakedScandal_Testify_Karl == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Leaker_LucianGalade == false && (BaseGame.Leaker_KarlGreiser == true &&  BaseGame.LeakedScandal_Testify_Karl == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Leaker_LucianGalade"] == false  and  (Variable["BaseGame.Leaker_KarlGreiser"] == true  and   Variable["BaseGame.LeakedScandal_Testify_Karl"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `252` (*Sordland/Turn11/Karl Evidence Main*), Węzeł `[1]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Leaker_LucianGalade == false && (BaseGame.Leaker_KarlGreiser == true &&  BaseGame.LeakedScandal_Testify_Karl == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Leaker_LucianGalade"] == false  and  (Variable["BaseGame.Leaker_KarlGreiser"] == true  and   Variable["BaseGame.LeakedScandal_Testify_Karl"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Leaker_MarcelKoronti == true || BaseGame.Leaker_WalterTusk == true ) && BaseGame.LeakedScandal_Testify_Oligarchs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Leaker_MarcelKoronti == true || BaseGame.Leaker_WalterTusk == true ) && BaseGame.LeakedScandal_Testify_Oligarchs == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Leaker_MarcelKoronti"] == true  or  Variable["BaseGame.Leaker_WalterTusk"] == true )  and  Variable["BaseGame.LeakedScandal_Testify_Oligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `250` (*Sordland/Turn11/Edith Evidence*), Węzeł `[1]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Leaker_MarcelKoronti == true || BaseGame.Leaker_WalterTusk == true ) && BaseGame.LeakedScandal_Testify_Oligarchs == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Leaker_MarcelKoronti"] == true  or  Variable["BaseGame.Leaker_WalterTusk"] == true )  and  Variable["BaseGame.LeakedScandal_Testify_Oligarchs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[51]`
Mówca: **Orso Hawker**
> "“All evidence has now been presented in the court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[55]`
Mówca: **Ovid Grecer**
> "“All evidence has now been presented in the court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_HeronGaraci == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[59]`
Mówca: **Heron Garaci**
> "“All evidence has now been presented in the court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Heron Garaci**
> "“We will now proceed with the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[61]`
Mówca: **Ovid Grecer**
> "“We will now proceed with the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[62]`
Mówca: **Orso Hawker**
> "“We will now proceed with the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[63]`
Mówca: **Heron Garaci**
> "“In the light of these allegations, what do you have to say for yourself?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[66]`
  - -> `[69]`
  - -> `[67]`

### Węzeł `[64]`
Mówca: **Ovid Grecer**
> "“In the light of these allegations, what do you have to say for yourself?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[66]`
  - -> `[69]`
  - -> `[67]`

### Węzeł `[65]`
Mówca: **Orso Hawker**
> "“In the light of these allegations, what do you have to say for yourself?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[66]`
  - -> `[69]`
  - -> `[67]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“Does it even matter at this point?”"]** — Mówca: **Player**
> "“Does it even matter at this point?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "“All I have to say is this: Fuck you!”"]** — Mówca: **Player**
> "“All I have to say is this: Fuck you!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "“I deny all of this. This is all a ploy to end my presidency and I will not accept a guilty verdict.”"]** — Mówca: **Player**
> "“I deny all of this. This is all a ploy to end my presidency and I will not accept a guilty verdict.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "“I'm going to make it out of this. And one day, you're all going to pay for what you've done to me.""]** — Mówca: **Player**
> "“I'm going to make it out of this. And one day, you're all going to pay for what you've done to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[70]`
Mówca: **Heron Garaci**
> "“There is no place for conspiracy theories in this court, Mr. President. The evidence has been presented in a clear and irrefutable manner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_HeronGaraci == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[77]`
Mówca: **Ovid Grecer**
> "“There is no place for conspiracy theories in this court, Mr. President. The evidence has been presented in a clear and irrefutable manner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[78]`
Mówca: **Orso Hawker**
> "“There is no place for conspiracy theories in this court, Mr. President. The evidence has been presented in a clear and irrefutable manner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_HeronGaraci == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[82]`
Mówca: **Ovid Grecer**
> "“Let the record show that the President has refused the opportunity to defend himself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[83]`
Mówca: **Heron Garaci**
> "“Let the record show that the President has refused the opportunity to defend himself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Orso Hawker**
> "“Let the record show that the President has refused the opportunity to defend himself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_HeronGaraci == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[91]`
Mówca: **Ovid Grecer**
> "“Silence! I will not allow threats in this courtroom!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[92]`
Mówca: **Heron Garaci**
> "“Silence! I will not allow threats in this courtroom!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Orso Hawker**
> "“Silence! I will not allow threats in this courtroom!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_HeronGaraci == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[100]`
Mówca: **Ovid Grecer**
> "“Silence! I will not allow improper language in this courtroom!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[101]`
Mówca: **Heron Garaci**
> "“Silence! I will not allow improper language in this courtroom!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Orso Hawker**
> "“Silence! I will not allow improper language in this courtroom!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_HeronGaraci == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[112]`
Mówca: **Ovid Grecer**
> "“This court will now proceed with the final evaluation of the evidence before announcing the verdict.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[113]`
Mówca: **Heron Garaci**
> "“This court will now proceed with the final evaluation of the evidence before announcing the verdict.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[114]`
Mówca: **Orso Hawker**
> "“This court will now proceed with the final evaluation of the evidence before announcing the verdict.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[115]`
Mówca: **Narrator**
> "Half an hour passed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[116]`
Mówca: **Narrator**
> "After nearly an hour of excruciating waiting, the door opened again. The justices took their seats to deliver the final verdict."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[117]`
Mówca: **Narrator**
> "The Justices all stood up and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Narrator**
> "I started thinking about my life up to that point. Where had it all gone wrong?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[119]`
Mówca: **Narrator**
> "Where the hell were the justices?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[120]`
Mówca: **Narrator**
> "I took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn11_A_ImpeachmentTrial = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn11_A_ImpeachmentTrial"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Leaker_HeronGaraci == true && BaseGame.LeakedScandal_Testify_Heron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Leaker_HeronGaraci == true && BaseGame.LeakedScandal_Testify_Heron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Leaker_HeronGaraci"] == true  and  Variable["BaseGame.LeakedScandal_Testify_Heron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `251` (*Sordland/Turn11/Heron Evidence*), Węzeł `[1]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Leaker_HeronGaraci == true && BaseGame.LeakedScandal_Testify_Heron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Leaker_HeronGaraci"] == true  and  Variable["BaseGame.LeakedScandal_Testify_Heron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[125]`
Mówca: **Narrator**
> "The Supreme Court justices entered and took their seats one by one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_ExperiencedJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_ExperiencedJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_ExperiencedJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_ExperiencedJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_ExperiencedJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_OldGuardReplaced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_OldGuardReplaced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_OldGuardReplaced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_GloriaJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_GloriaJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_GloriaJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_LoyalJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_LoyalJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_LoyalJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_LoyalJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_LoyalJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_Shuffled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_Shuffled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_Shuffled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[141]`
Mówca: **Narrator**
> "The Supreme Court justices entered and took their seats one by one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[142]`
Mówca: **Narrator**
> "The Supreme Court justices entered and took their seats one by one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[143]`
Mówca: **Narrator**
> "The Supreme Court justices entered and took their seats one by one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[144]`
Mówca: **Narrator**
> "The Supreme Court justices entered and took their seats one by one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[145]`
Mówca: **Didier Meye**
> "“The prosecution will be called upon first, followed by the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Didier Meye**
> "“After both parties present their claims, the court will present its final verdict on this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[147]`
Mówca: **Isabel Edmonds**
> "“I call the case of the impeachment charges against the President of Sordland. The case number is 385372.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Didier Meye**
> "“This case will proceed as follows.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Didier Meye**
> "“Both parties will have the opportunity to present their evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[150]`
Mówca: **Heron Garaci**
> "“You may be seated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[151]`
Mówca: **Heron Garaci**
> "“This court is now in session.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[152]`
Mówca: **Narrator**
> "He put down the papers and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[153]`
Mówca: **Narrator**
> "I looked at Chief Justice Heron Garaci. After he was seated, he pulled out his reading glasses and quickly rifled through the documents in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[154]`
Mówca: **Narrator**
> "I looked at the Chief Justice Ovid Grecer. After he was seated, he pulled out his reading glasses and quickly rifled through the documents in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Narrator**
> "He put down the papers and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Ovid Grecer**
> "“This court is now in session.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[157]`
Mówca: **Didier Meye**
> "“After both parties present their claims, the court will present its final verdict on this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[158]`
Mówca: **Isabel Edmonds**
> "“I call the case of the impeachment charges against the President of Sordland. The case number is 385372.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[159]`
Mówca: **Ovid Grecer**
> "“You may be seated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[160]`
Mówca: **Didier Meye**
> "“Both parties will have the opportunity to present their evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Didier Meye**
> "“This case will proceed as follows.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[162]`
Mówca: **Didier Meye**
> "“The prosecution will be called upon first, followed by the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[163]`
Mówca: **Narrator**
> "I looked at the Chief Justice Ovid Grecer. After he was seated, he pulled out his reading glasses and quickly rifled through the documents in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Narrator**
> "He put down the papers and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Ovid Grecer**
> "“This court is now in session.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[166]`
Mówca: **Didier Meye**
> "“After both parties present their claims, the court will present its final verdict on this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[167]`
Mówca: **Didier Meye**
> "“I call the case of the impeachment charges against the President of Sordland. The case number is 385372.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[168]`
Mówca: **Ovid Grecer**
> "“You may be seated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[169]`
Mówca: **Didier Meye**
> "“Both parties will have the opportunity to present their evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Didier Meye**
> "“This case will proceed as follows.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[171]`
Mówca: **Didier Meye**
> "“The prosecution will be called upon first, followed by the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_CourtVote_Success == false && BaseGame.Reform_Autocrat_Path == true && BaseGame.ChiefJustice_OrsoHawker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_CourtVote_Success == false && BaseGame.Reform_Autocrat_Path == true && BaseGame.ChiefJustice_OrsoHawker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false  and  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.ChiefJustice_OrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_CourtVote_Success == false && BaseGame.Reform_Autocrat_Path == true && BaseGame.ChiefJustice_OrsoHawker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false  and  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.ChiefJustice_OrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[175]`
Mówca: **Heron Garaci**
> "“I call the case of the impeachment charges against the President of Sordland. The case number is 385372.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[176]`
Mówca: **Orso Hawker**
> "“You may be seated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[177]`
Mówca: **Orso Hawker**
> "“This court is now in session.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[178]`
Mówca: **Narrator**
> "He put down the papers and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[179]`
Mówca: **Narrator**
> "I looked at Chief Justice Orso Hawker. After he was seated, he pulled out his reading glasses and quickly rifled through the documents in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[180]`
Mówca: **Narrator**
> "The Supreme Court justices entered and took their seats one by one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[181]`
Mówca: **Orso Hawker**
> "“The evidence is clear and it has now been presented in the court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Orso Hawker**
> "“We will now proceed with the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Orso Hawker**
> "“In the light of these allegations, what do you have to say for yourself?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[68]`
  - -> `[66]`
  - -> `[67]`

### Węzeł `[184]`
Mówca: **Isabel Edmonds**
> "“The prosecution will be called upon first, followed by the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Isabel Edmonds**
> "“After both parties present their claims, the court will present its final verdict on this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[186]`
Mówca: **Isabel Edmonds**
> "“Both parties will have the opportunity to present their evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[187]`
Mówca: **Isabel Edmonds**
> "“This case will proceed as follows.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[188]`
Mówca: **Isabel Edmonds**
> "“Chief Justice Hawker, please proceed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Orso Hawker**
> "“Thank you, Ms. Edmonds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Orso Hawker**
> "“With the declaration of the emergency, President Rayne modified and suspended the rights of freedom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Orso Hawker**
> "“Article 100 of the Constitution of Sordland clearly states the following...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Orso Hawker**
> "“...no State shall, in the case of National Emergency, modify or suspend the rights of freedom, defined in Article 100 of the Constitution, unless actually invaded, or in such imminent danger as will not admit of delay.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[193]`
Mówca: **Orso Hawker**
> "“Previously, Supreme Court did not find any imminent danger to the existence of Sordland and nullified the validity of this emergency act.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Orso Hawker**
> "“...and high treason against Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[195]`
Mówca: **Orso Hawker**
> "“However, this court accepts the case as a crime against Sordish people...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[196]`
**[WYBÓR GRACZA: "“You were the one who told me to sign this act! You are involved in this too!""]** — Mówca: **Player**
> "“You were the one who told me to sign this act! You are involved in this too!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Orso Hawker**
> "“Silence! I will not allow slander in this courtroom!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Testify_Lucian == true && BaseGame.Relations_Lucian_GaladeWonMatch == true && BaseGame.Decision_Turn08_VPSelection_Lucian == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Testify_Lucian == true && BaseGame.Relations_Lucian_GaladeWonMatch == true && BaseGame.Decision_Turn08_VPSelection_Lucian == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Testify_Lucian"] == true  and  Variable["BaseGame.Relations_Lucian_GaladeWonMatch"] == true  and  Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_Testify_Lucian == true && BaseGame.Relations_Lucian_GaladeWonMatch == true && BaseGame.Decision_Turn08_VPSelection_Lucian == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Testify_Lucian"] == true  and  Variable["BaseGame.Relations_Lucian_GaladeWonMatch"] == true  and  Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Game_Chessmaster");)*
- **Efekt (`userScript`):** `UnlockAchievement("Game_Chessmaster");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
