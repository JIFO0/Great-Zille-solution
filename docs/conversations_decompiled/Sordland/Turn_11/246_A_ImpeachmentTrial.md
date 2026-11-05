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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **"Take a seat."** | `[6]` **Narrator**: "The attendees watched me quietly..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Narrator**: "A quiet chatter began in the cou..." |
| `[15]` | **"Rise up from your seat."** | `[41]` **Narrator**: "A court clerk entered and ordere..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Narrator**: "The Supreme Court justices enter..."<br>`[40]` **Narrator**: "The Supreme Court justices enter..."<br>*(oraz 1 innych odgałęzień)* |
| `[16]` | **"Remain seated."** | `[41]` **Narrator**: "A court clerk entered and ordere..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Narrator**: "The Supreme Court justices enter..."<br>`[40]` **Narrator**: "The Supreme Court justices enter..."<br>*(oraz 1 innych odgałęzień)* |
| `[66]` | **"“Does it even matter at this point?”"** | `[63]` **Heron Garaci**: "“In the light of these allegatio..."<br>`[64]` **Ovid Grecer**: "“In the light of these allegatio..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Heron Garaci**: "“Let the record show that the Pr..."<br>`[82]` **Ovid Grecer**: "“Let the record show that the Pr..."<br>*(oraz 1 innych odgałęzień)* |
| `[67]` | **"“All I have to say is this: Fuck you!”"** | `[63]` **Heron Garaci**: "“In the light of these allegatio..."<br>`[64]` **Ovid Grecer**: "“In the light of these allegatio..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Heron Garaci**: "“Silence! I will not allow impro..."<br>`[100]` **Ovid Grecer**: "“Silence! I will not allow impro..."<br>*(oraz 1 innych odgałęzień)* |
| `[68]` | **"“I deny all of this. This is all a ploy to end my presidency and I will not accept..."** | `[63]` **Heron Garaci**: "“In the light of these allegatio..."<br>`[64]` **Ovid Grecer**: "“In the light of these allegatio..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Heron Garaci**: "“There is no place for conspirac..."<br>`[77]` **Ovid Grecer**: "“There is no place for conspirac..."<br>*(oraz 1 innych odgałęzień)* |
| `[69]` | **"“I'm going to make it out of this. And one day, you're all going to pay for what y..."** | `[63]` **Heron Garaci**: "“In the light of these allegatio..."<br>`[64]` **Ovid Grecer**: "“In the light of these allegatio..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Heron Garaci**: "“Silence! I will not allow threa..."<br>`[91]` **Ovid Grecer**: "“Silence! I will not allow threa..."<br>*(oraz 1 innych odgałęzień)* |
| `[196]` | **"“You were the one who told me to sign this act! You are involved in this too!""** | `[183]` **Orso Hawker**: "“In the light of these allegatio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[197]` **Orso Hawker**: "“Silence! I will not allow sland..." |

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
  - -> `[3]` (*Narrator: "I took a deep breath and opened the grand doors leading t..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I took a deep breath and opened the grand doors leading to the Supreme Court."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "There were no camera flashes this time. No journalists or..."*)

### Węzeł `[4]`
**[WYBÓR GRACZA: "Take a seat."]** — Mówca: **Player_Italic**
> "I took a seat and everyone followed suit."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "A quiet chatter began in the courtroom which continued un..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "There were no camera flashes this time. No journalists or reporters. Nobody was allowed in the courtroom except the people related to my case."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "The attendees watched me quietly as I walked down the ais..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "The attendees watched me quietly as I walked down the aisle to the defendant's table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player_Italic: "Take a seat."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "I looked at Chief Justice Heron Garaci. After he was seated, he pulled out his reading glasses and quickly rifled through the documents in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "He put them down and looked at me."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "I looked at Chief Justice Ovid Grecer. After he was seated, he pulled out his reading glasses and quickly rifled through the documents in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "He put them down and looked at me."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "I looked at Chief Justice Orso Hawker. After he was seated, he pulled out his reading glasses and quickly rifled through the documents in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "He put down the papers and looked at me."*)

### Węzeł `[10]`
Mówca: **Heron Garaci**
> "“This court is now in session.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Heron Garaci: "“You may be seated.”"*)

### Węzeł `[11]`
Mówca: **Ovid Grecer**
> "“This court is now in session.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Ovid Grecer: "“You may be seated.”"*)

### Węzeł `[12]`
Mówca: **Orso Hawker**
> "“This court is now in session.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Orso Hawker: "“You may be seated.”"*)

### Węzeł `[13]`
Mówca: **Narrator**
> "He put them down and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Heron Garaci: "“This court is now in session.”"*)

### Węzeł `[14]`
Mówca: **Narrator**
> "A quiet chatter began in the courtroom which continued until the door behind the podium opened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "A court clerk entered and ordered everyone to rise for th..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "Rise up from your seat."]** — Mówca: **Player_Italic**
> "I rose up from my seat."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success == false && Ba..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "Remain seated."]** — Mówca: **Player_Italic**
> "I remained seated."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success == false && Ba..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "He put them down and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Ovid Grecer: "“This court is now in session.”"*)

### Węzeł `[18]`
Mówca: **Narrator**
> "He put down the papers and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Orso Hawker: "“This court is now in session.”"*)

### Węzeł `[19]`
Mówca: **Ovid Grecer**
> "“You may be seated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Heron Garaci: "“I call the case of the impeachment charges against the P..."*)

### Węzeł `[20]`
Mówca: **Orso Hawker**
> "“You may be seated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Heron Garaci: "“I call the case of the impeachment charges against the P..."*)

### Węzeł `[21]`
Mówca: **Heron Garaci**
> "“You may be seated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Isabel Edmonds: "“I call the case of the impeachment charges against the P..."*)

### Węzeł `[22]`
Mówca: **Heron Garaci**
> "“I call the case of the impeachment charges against the President of Sordland. The case number is 385372.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Isabel Edmonds: "“This case will proceed as follows.”"*)

### Węzeł `[23]`
Mówca: **Heron Garaci**
> "“I call the case of the impeachment charges against the President of Sordland. The case number is 385372.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Isabel Edmonds: "“This case will proceed as follows.”"*)

### Węzeł `[24]`
Mówca: **Isabel Edmonds**
> "“I call the case of the impeachment charges against the President of Sordland. The case number is 385372.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Gloria Tory: "“This case will proceed as follows.”"*)

### Węzeł `[25]`
Mówca: **Isabel Edmonds**
> "“This case will proceed as follows.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Isabel Edmonds: "“Both parties will have the opportunity to present their ..."*)

### Węzeł `[26]`
Mówca: **Isabel Edmonds**
> "“This case will proceed as follows.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Isabel Edmonds: "“Both parties will have the opportunity to present their ..."*)

### Węzeł `[27]`
Mówca: **Gloria Tory**
> "“This case will proceed as follows.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Gloria Tory: "“Both parties will have the opportunity to present their ..."*)

### Węzeł `[28]`
Mówca: **Gloria Tory**
> "“Both parties will have the opportunity to present their evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Gloria Tory: "“The prosecution will be called upon first, followed by t..."*)

### Węzeł `[29]`
Mówca: **Isabel Edmonds**
> "“Both parties will have the opportunity to present their evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Isabel Edmonds: "“The prosecution will be called upon first, followed by t..."*)

### Węzeł `[30]`
Mówca: **Isabel Edmonds**
> "“Both parties will have the opportunity to present their evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Isabel Edmonds: "“The prosecution will be called upon first, followed by t..."*)

### Węzeł `[31]`
Mówca: **Isabel Edmonds**
> "“The prosecution will be called upon first, followed by the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Isabel Edmonds: "“After both parties present their claims, the court will ..."*)

### Węzeł `[32]`
Mówca: **Isabel Edmonds**
> "“The prosecution will be called upon first, followed by the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Isabel Edmonds: "“After both parties present their claims, the court will ..."*)

### Węzeł `[33]`
Mówca: **Gloria Tory**
> "“The prosecution will be called upon first, followed by the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Gloria Tory: "“After both parties present their claims, the court will ..."*)

### Węzeł `[34]`
Mówca: **Gloria Tory**
> "“After both parties present their claims, the court will present its final verdict on this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leaker_ACP == true && BaseGame.LeakedScandal_Tes..."*)

### Węzeł `[35]`
Mówca: **Isabel Edmonds**
> "“After both parties present their claims, the court will present its final verdict on this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leaker_ACP == true && BaseGame.LeakedScandal_Tes..."*)

### Węzeł `[36]`
Mówca: **Isabel Edmonds**
> "“After both parties present their claims, the court will present its final verdict on this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leaker_ACP == true && BaseGame.LeakedScandal_Tes..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Leaker_ACP == true && BaseGame.LeakedScandal_Testify_ACP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leaker_ACP == true && BaseGame.LeakedScandal_Tes..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Leaker_ACP == true && BaseGame.LeakedScandal_T..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Leaker_ACP == true && BaseGame.LeakedScandal_Testify_ACP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Leaker_ACP"] == true  and  Variable["BaseGame.LeakedScandal_Testify_ACP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Leaker_ACP == true && BaseGame.LeakedScandal_Testify_ACP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Leaker_ACP"] == true  and  Variable["BaseGame.LeakedScandal_Testify_ACP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leaker_LucianGalade == true && BaseGame.LeakedSc..."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "The Supreme Court justices entered and took their seats one by one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "I looked at Chief Justice Ovid Grecer. After he was seate..."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "A court clerk entered and ordered everyone to rise for the judges."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player_Italic: "Rise up from your seat."*)
  - -> `[16]` (*Player_Italic: "Remain seated."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Leaker_LucianGalade == true && BaseGame.LeakedScandal_Testify_Lucian == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leaker_LucianGalade == true && BaseGame.LeakedSc..."*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Leaker_LucianGalade == true && BaseGame.Leaked..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Leaker_LucianGalade == true && BaseGame.LeakedScandal_Testify_Lucian == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Leaker_LucianGalade"] == true  and  Variable["BaseGame.LeakedScandal_Testify_Lucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Leaker_LucianGalade == true && BaseGame.LeakedScandal_Testify_Lucian == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Leaker_LucianGalade"] == true  and  Variable["BaseGame.LeakedScandal_Testify_Lucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leaker_LucianGalade == false && (BaseGame.Leaker..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Leaker_LucianGalade == false && (BaseGame.Leaker_KarlGreiser == true &&  BaseGame.LeakedScandal_Testify_Karl == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leaker_LucianGalade == false && (BaseGame.Leaker..."*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Leaker_LucianGalade == false && (BaseGame.Leak..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Leaker_LucianGalade == false && (BaseGame.Leaker_KarlGreiser == true &&  BaseGame.LeakedScandal_Testify_Karl == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Leaker_LucianGalade"] == false  and  (Variable["BaseGame.Leaker_KarlGreiser"] == true  and   Variable["BaseGame.LeakedScandal_Testify_Karl"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Leaker_LucianGalade == false && (BaseGame.Leaker_KarlGreiser == true &&  BaseGame.LeakedScandal_Testify_Karl == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Leaker_LucianGalade"] == false  and  (Variable["BaseGame.Leaker_KarlGreiser"] == true  and   Variable["BaseGame.LeakedScandal_Testify_Karl"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leaker_HeronGaraci == true && BaseGame.LeakedSca..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Leaker_MarcelKoronti == true || BaseGame.Leaker_WalterTusk == true ) && BaseGame.LeakedScandal_Testify_Oligarchs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Leaker_MarcelKoronti == true || BaseGame.Leaker..."*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Leaker_MarcelKoronti == true || BaseGame.Leak..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Leaker_MarcelKoronti == true || BaseGame.Leaker_WalterTusk == true ) && BaseGame.LeakedScandal_Testify_Oligarchs == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Leaker_MarcelKoronti"] == true  or  Variable["BaseGame.Leaker_WalterTusk"] == true )  and  Variable["BaseGame.LeakedScandal_Testify_Oligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Leaker_MarcelKoronti == true || BaseGame.Leaker_WalterTusk == true ) && BaseGame.LeakedScandal_Testify_Oligarchs == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Leaker_MarcelKoronti"] == true  or  Variable["BaseGame.Leaker_WalterTusk"] == true )  and  Variable["BaseGame.LeakedScandal_Testify_Oligarchs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[51]`
Mówca: **Orso Hawker**
> "“All evidence has now been presented in the court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Orso Hawker: "“We will now proceed with the defendant.”"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Ovid Grecer: "“All evidence has now been presented in the court.”"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Orso Hawker: "“All evidence has now been presented in the court.”"*)

### Węzeł `[55]`
Mówca: **Ovid Grecer**
> "“All evidence has now been presented in the court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Ovid Grecer: "“We will now proceed with the defendant.”"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Heron Garaci: "“All evidence has now been presented in the court.”"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[59]`
Mówca: **Heron Garaci**
> "“All evidence has now been presented in the court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Heron Garaci: "“We will now proceed with the defendant.”"*)

### Węzeł `[60]`
Mówca: **Heron Garaci**
> "“We will now proceed with the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Heron Garaci: "“In the light of these allegations, what do you have to s..."*)

### Węzeł `[61]`
Mówca: **Ovid Grecer**
> "“We will now proceed with the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Ovid Grecer: "“In the light of these allegations, what do you have to s..."*)

### Węzeł `[62]`
Mówca: **Orso Hawker**
> "“We will now proceed with the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Orso Hawker: "“In the light of these allegations, what do you have to s..."*)

### Węzeł `[63]`
Mówca: **Heron Garaci**
> "“In the light of these allegations, what do you have to say for yourself?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: "“I deny all of this. This is all a ploy to end my preside..."*)
  - -> `[66]` (*Player: "“Does it even matter at this point?”"*)
  - -> `[69]` (*Player: "“I'm going to make it out of this. And one day, you're al..."*)
  - -> `[67]` (*Player: "“All I have to say is this: Fuck you!”"*)

### Węzeł `[64]`
Mówca: **Ovid Grecer**
> "“In the light of these allegations, what do you have to say for yourself?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: "“I deny all of this. This is all a ploy to end my preside..."*)
  - -> `[66]` (*Player: "“Does it even matter at this point?”"*)
  - -> `[69]` (*Player: "“I'm going to make it out of this. And one day, you're al..."*)
  - -> `[67]` (*Player: "“All I have to say is this: Fuck you!”"*)

### Węzeł `[65]`
Mówca: **Orso Hawker**
> "“In the light of these allegations, what do you have to say for yourself?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: "“I deny all of this. This is all a ploy to end my preside..."*)
  - -> `[66]` (*Player: "“Does it even matter at this point?”"*)
  - -> `[69]` (*Player: "“I'm going to make it out of this. And one day, you're al..."*)
  - -> `[67]` (*Player: "“All I have to say is this: Fuck you!”"*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“Does it even matter at this point?”"]** — Mówca: **Player**
> "“Does it even matter at this point?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Heron Garaci), `[64]` (Ovid Grecer), `[65]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "“All I have to say is this: Fuck you!”"]** — Mówca: **Player**
> "“All I have to say is this: Fuck you!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Heron Garaci), `[64]` (Ovid Grecer), `[65]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "“I deny all of this. This is all a ploy to end my presidency and I will not accept a guilty verdict.”"]** — Mówca: **Player**
> "“I deny all of this. This is all a ploy to end my presidency and I will not accept a guilty verdict.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Heron Garaci), `[64]` (Ovid Grecer), `[65]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "“I'm going to make it out of this. And one day, you're all going to pay for what you've done to me.""]** — Mówca: **Player**
> "“I'm going to make it out of this. And one day, you're all going to pay for what you've done to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Heron Garaci), `[64]` (Ovid Grecer), `[65]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[70]`
Mówca: **Heron Garaci**
> "“There is no place for conspiracy theories in this court, Mr. President. The evidence has been presented in a clear and irrefutable manner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Ovid Grecer: "“There is no place for conspiracy theories in this court,..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Orso Hawker: "“There is no place for conspiracy theories in this court,..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Heron Garaci: "“There is no place for conspiracy theories in this court,..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[77]`
Mówca: **Ovid Grecer**
> "“There is no place for conspiracy theories in this court, Mr. President. The evidence has been presented in a clear and irrefutable manner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[78]`
Mówca: **Orso Hawker**
> "“There is no place for conspiracy theories in this court, Mr. President. The evidence has been presented in a clear and irrefutable manner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Heron Garaci: "“Let the record show that the President has refused the o..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[82]`
Mówca: **Ovid Grecer**
> "“Let the record show that the President has refused the opportunity to defend himself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[83]`
Mówca: **Heron Garaci**
> "“Let the record show that the President has refused the opportunity to defend himself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Ovid Grecer: "“Let the record show that the President has refused the o..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Orso Hawker: "“Let the record show that the President has refused the o..."*)

### Węzeł `[87]`
Mówca: **Orso Hawker**
> "“Let the record show that the President has refused the opportunity to defend himself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Heron Garaci: "“Silence! I will not allow threats in this courtroom!”"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[91]`
Mówca: **Ovid Grecer**
> "“Silence! I will not allow threats in this courtroom!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[92]`
Mówca: **Heron Garaci**
> "“Silence! I will not allow threats in this courtroom!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Ovid Grecer: "“Silence! I will not allow threats in this courtroom!”"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Orso Hawker: "“Silence! I will not allow threats in this courtroom!”"*)

### Węzeł `[96]`
Mówca: **Orso Hawker**
> "“Silence! I will not allow threats in this courtroom!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Heron Garaci: "“Silence! I will not allow improper language in this cour..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[100]`
Mówca: **Ovid Grecer**
> "“Silence! I will not allow improper language in this courtroom!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[101]`
Mówca: **Heron Garaci**
> "“Silence! I will not allow improper language in this courtroom!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Ovid Grecer: "“Silence! I will not allow improper language in this cour..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Orso Hawker: "“Silence! I will not allow improper language in this cour..."*)

### Węzeł `[105]`
Mówca: **Orso Hawker**
> "“Silence! I will not allow improper language in this courtroom!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Ovid Grecer: "“This court will now proceed with the final evaluation of..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Orso Hawker: "“This court will now proceed with the final evaluation of..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Heron Garaci: "“This court will now proceed with the final evaluation of..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[112]`
Mówca: **Ovid Grecer**
> "“This court will now proceed with the final evaluation of the evidence before announcing the verdict.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "The Justices all stood up and left the room."*)

### Węzeł `[113]`
Mówca: **Heron Garaci**
> "“This court will now proceed with the final evaluation of the evidence before announcing the verdict.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "The Justices all stood up and left the room."*)

### Węzeł `[114]`
Mówca: **Orso Hawker**
> "“This court will now proceed with the final evaluation of the evidence before announcing the verdict.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "The Justices all stood up and left the room."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "Half an hour passed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "Where the hell were the justices?"*)

### Węzeł `[116]`
Mówca: **Narrator**
> "After nearly an hour of excruciating waiting, the door opened again. The justices took their seats to deliver the final verdict."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "I took a deep breath."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "The Justices all stood up and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "I started thinking about my life up to that point. Where ..."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "I started thinking about my life up to that point. Where had it all gone wrong?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "Half an hour passed."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "Where the hell were the justices?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "After nearly an hour of excruciating waiting, the door op..."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "I took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_A_ImpeachmentTrial = true"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn11_A_ImpeachmentTrial = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn11_A_ImpeachmentTrial"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Testify_Lucian == true && BaseGame..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Leaker_HeronGaraci == true && BaseGame.LeakedScandal_Testify_Heron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leaker_HeronGaraci == true && BaseGame.LeakedSca..."*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Leaker_HeronGaraci == true && BaseGame.LeakedS..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Leaker_HeronGaraci == true && BaseGame.LeakedScandal_Testify_Heron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Leaker_HeronGaraci"] == true  and  Variable["BaseGame.LeakedScandal_Testify_Heron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Leaker_HeronGaraci == true && BaseGame.LeakedScandal_Testify_Heron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Leaker_HeronGaraci"] == true  and  Variable["BaseGame.LeakedScandal_Testify_Heron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Leaker_MarcelKoronti == true || BaseGame.Leaker..."*)

### Węzeł `[125]`
Mówca: **Narrator**
> "The Supreme Court justices entered and took their seats one by one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I looked at Chief Justice Heron Garaci. After he was seat..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_ExperiencedJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_ExperiencedJustice == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_ExperiencedJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_ExperiencedJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "The Supreme Court justices entered and took their seats o..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_ExperiencedJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_ExperiencedJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_OldGuardReplaced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_OldGuardReplaced == true"*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_OldGuardReplaced == true)"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_OldGuardReplaced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "The Supreme Court justices entered and took their seats o..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_OldGuardReplaced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_Shuffled == true"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_GloriaJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_GloriaJustice == true)"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_GloriaJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "The Supreme Court justices entered and took their seats o..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_GloriaJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_LoyalJustice == true"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_LoyalJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_LoyalJustice == true"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_LoyalJustice == true)"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_LoyalJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_LoyalJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "The Supreme Court justices entered and took their seats o..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_LoyalJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_LoyalJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_OldGuardReplaced == true"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_Shuffled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_Shuffled == true"*)
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_Shuffled == true)"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_Shuffled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "The Supreme Court justices entered and took their seats o..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_Shuffled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "The Supreme Court justices entered and took their seats o..."*)

### Węzeł `[141]`
Mówca: **Narrator**
> "The Supreme Court justices entered and took their seats one by one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "I looked at the Chief Justice Ovid Grecer. After he was s..."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "The Supreme Court justices entered and took their seats one by one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "I looked at Chief Justice Heron Garaci. After he was seat..."*)

### Węzeł `[143]`
Mówca: **Narrator**
> "The Supreme Court justices entered and took their seats one by one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "I looked at Chief Justice Orso Hawker. After he was seate..."*)

### Węzeł `[144]`
Mówca: **Narrator**
> "The Supreme Court justices entered and took their seats one by one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "I looked at the Chief Justice Ovid Grecer. After he was s..."*)

### Węzeł `[145]`
Mówca: **Didier Meye**
> "“The prosecution will be called upon first, followed by the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Didier Meye: "“After both parties present their claims, the court will ..."*)

### Węzeł `[146]`
Mówca: **Didier Meye**
> "“After both parties present their claims, the court will present its final verdict on this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leaker_ACP == true && BaseGame.LeakedScandal_Tes..."*)

### Węzeł `[147]`
Mówca: **Isabel Edmonds**
> "“I call the case of the impeachment charges against the President of Sordland. The case number is 385372.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Didier Meye: "“This case will proceed as follows.”"*)

### Węzeł `[148]`
Mówca: **Didier Meye**
> "“This case will proceed as follows.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Didier Meye: "“Both parties will have the opportunity to present their ..."*)

### Węzeł `[149]`
Mówca: **Didier Meye**
> "“Both parties will have the opportunity to present their evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Didier Meye: "“The prosecution will be called upon first, followed by t..."*)

### Węzeł `[150]`
Mówca: **Heron Garaci**
> "“You may be seated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Isabel Edmonds: "“I call the case of the impeachment charges against the P..."*)

### Węzeł `[151]`
Mówca: **Heron Garaci**
> "“This court is now in session.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Heron Garaci: "“You may be seated.”"*)

### Węzeł `[152]`
Mówca: **Narrator**
> "He put down the papers and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Heron Garaci: "“This court is now in session.”"*)

### Węzeł `[153]`
Mówca: **Narrator**
> "I looked at Chief Justice Heron Garaci. After he was seated, he pulled out his reading glasses and quickly rifled through the documents in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "He put down the papers and looked at me."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "I looked at the Chief Justice Ovid Grecer. After he was seated, he pulled out his reading glasses and quickly rifled through the documents in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "He put down the papers and looked at me."*)

### Węzeł `[155]`
Mówca: **Narrator**
> "He put down the papers and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Ovid Grecer: "“This court is now in session.”"*)

### Węzeł `[156]`
Mówca: **Ovid Grecer**
> "“This court is now in session.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Ovid Grecer: "“You may be seated.”"*)

### Węzeł `[157]`
Mówca: **Didier Meye**
> "“After both parties present their claims, the court will present its final verdict on this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leaker_ACP == true && BaseGame.LeakedScandal_Tes..."*)

### Węzeł `[158]`
Mówca: **Isabel Edmonds**
> "“I call the case of the impeachment charges against the President of Sordland. The case number is 385372.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Didier Meye: "“This case will proceed as follows.”"*)

### Węzeł `[159]`
Mówca: **Ovid Grecer**
> "“You may be seated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Isabel Edmonds: "“I call the case of the impeachment charges against the P..."*)

### Węzeł `[160]`
Mówca: **Didier Meye**
> "“Both parties will have the opportunity to present their evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Didier Meye: "“The prosecution will be called upon first, followed by t..."*)

### Węzeł `[161]`
Mówca: **Didier Meye**
> "“This case will proceed as follows.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Didier Meye: "“Both parties will have the opportunity to present their ..."*)

### Węzeł `[162]`
Mówca: **Didier Meye**
> "“The prosecution will be called upon first, followed by the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Didier Meye: "“After both parties present their claims, the court will ..."*)

### Węzeł `[163]`
Mówca: **Narrator**
> "I looked at the Chief Justice Ovid Grecer. After he was seated, he pulled out his reading glasses and quickly rifled through the documents in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "He put down the papers and looked at me."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "He put down the papers and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Ovid Grecer: "“This court is now in session.”"*)

### Węzeł `[165]`
Mówca: **Ovid Grecer**
> "“This court is now in session.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Ovid Grecer: "“You may be seated.”"*)

### Węzeł `[166]`
Mówca: **Didier Meye**
> "“After both parties present their claims, the court will present its final verdict on this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Leaker_ACP == true && BaseGame.LeakedScandal_Tes..."*)

### Węzeł `[167]`
Mówca: **Didier Meye**
> "“I call the case of the impeachment charges against the President of Sordland. The case number is 385372.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Didier Meye: "“This case will proceed as follows.”"*)

### Węzeł `[168]`
Mówca: **Ovid Grecer**
> "“You may be seated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Didier Meye: "“I call the case of the impeachment charges against the P..."*)

### Węzeł `[169]`
Mówca: **Didier Meye**
> "“Both parties will have the opportunity to present their evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Didier Meye: "“The prosecution will be called upon first, followed by t..."*)

### Węzeł `[170]`
Mówca: **Didier Meye**
> "“This case will proceed as follows.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Didier Meye: "“Both parties will have the opportunity to present their ..."*)

### Węzeł `[171]`
Mówca: **Didier Meye**
> "“The prosecution will be called upon first, followed by the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Didier Meye: "“After both parties present their claims, the court will ..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_CourtVote_Success == false && BaseGame.Reform_Autocrat_Path == true && BaseGame.ChiefJustice_OrsoHawker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success == false && Ba..."*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_CourtVote_Success == false && ..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_CourtVote_Success == false && BaseGame.Reform_Autocrat_Path == true && BaseGame.ChiefJustice_OrsoHawker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false  and  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.ChiefJustice_OrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "The Supreme Court justices entered and took their seats o..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_CourtVote_Success == false && BaseGame.Reform_Autocrat_Path == true && BaseGame.ChiefJustice_OrsoHawker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false  and  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.ChiefJustice_OrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[175]`
Mówca: **Heron Garaci**
> "“I call the case of the impeachment charges against the President of Sordland. The case number is 385372.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Isabel Edmonds: "“This case will proceed as follows.”"*)

### Węzeł `[176]`
Mówca: **Orso Hawker**
> "“You may be seated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Heron Garaci: "“I call the case of the impeachment charges against the P..."*)

### Węzeł `[177]`
Mówca: **Orso Hawker**
> "“This court is now in session.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Orso Hawker: "“You may be seated.”"*)

### Węzeł `[178]`
Mówca: **Narrator**
> "He put down the papers and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Orso Hawker: "“This court is now in session.”"*)

### Węzeł `[179]`
Mówca: **Narrator**
> "I looked at Chief Justice Orso Hawker. After he was seated, he pulled out his reading glasses and quickly rifled through the documents in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "He put down the papers and looked at me."*)

### Węzeł `[180]`
Mówca: **Narrator**
> "The Supreme Court justices entered and took their seats one by one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "I looked at Chief Justice Orso Hawker. After he was seate..."*)

### Węzeł `[181]`
Mówca: **Orso Hawker**
> "“The evidence is clear and it has now been presented in the court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Orso Hawker: "“We will now proceed with the defendant.”"*)

### Węzeł `[182]`
Mówca: **Orso Hawker**
> "“We will now proceed with the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Orso Hawker: "“In the light of these allegations, what do you have to s..."*)

### Węzeł `[183]`
Mówca: **Orso Hawker**
> "“In the light of these allegations, what do you have to say for yourself?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player: "“You were the one who told me to sign this act! You are i..."*)
  - -> `[68]` (*Player: "“I deny all of this. This is all a ploy to end my preside..."*)
  - -> `[66]` (*Player: "“Does it even matter at this point?”"*)
  - -> `[67]` (*Player: "“All I have to say is this: Fuck you!”"*)

### Węzeł `[184]`
Mówca: **Isabel Edmonds**
> "“The prosecution will be called upon first, followed by the defendant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Isabel Edmonds: "“After both parties present their claims, the court will ..."*)

### Węzeł `[185]`
Mówca: **Isabel Edmonds**
> "“After both parties present their claims, the court will present its final verdict on this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Isabel Edmonds: "“Chief Justice Hawker, please proceed.”"*)

### Węzeł `[186]`
Mówca: **Isabel Edmonds**
> "“Both parties will have the opportunity to present their evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Isabel Edmonds: "“The prosecution will be called upon first, followed by t..."*)

### Węzeł `[187]`
Mówca: **Isabel Edmonds**
> "“This case will proceed as follows.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Isabel Edmonds: "“Both parties will have the opportunity to present their ..."*)

### Węzeł `[188]`
Mówca: **Isabel Edmonds**
> "“Chief Justice Hawker, please proceed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Orso Hawker: "“Thank you, Ms. Edmonds.”"*)

### Węzeł `[189]`
Mówca: **Orso Hawker**
> "“Thank you, Ms. Edmonds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Orso Hawker: "“With the declaration of the emergency, President Rayne m..."*)

### Węzeł `[190]`
Mówca: **Orso Hawker**
> "“With the declaration of the emergency, President Rayne modified and suspended the rights of freedom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Orso Hawker: "“Article 100 of the Constitution of Sordland clearly stat..."*)

### Węzeł `[191]`
Mówca: **Orso Hawker**
> "“Article 100 of the Constitution of Sordland clearly states the following...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Orso Hawker: "“...no State shall, in the case of National Emergency, mo..."*)

### Węzeł `[192]`
Mówca: **Orso Hawker**
> "“...no State shall, in the case of National Emergency, modify or suspend the rights of freedom, defined in Article 100 of the Constitution, unless actually invaded, or in such imminent danger as will not admit of delay.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Orso Hawker: "“Previously, Supreme Court did not find any imminent dang..."*)

### Węzeł `[193]`
Mówca: **Orso Hawker**
> "“Previously, Supreme Court did not find any imminent danger to the existence of Sordland and nullified the validity of this emergency act.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Orso Hawker: "“However, this court accepts the case as a crime against ..."*)

### Węzeł `[194]`
Mówca: **Orso Hawker**
> "“...and high treason against Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Orso Hawker: "“The evidence is clear and it has now been presented in t..."*)

### Węzeł `[195]`
Mówca: **Orso Hawker**
> "“However, this court accepts the case as a crime against Sordish people...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Orso Hawker: "“...and high treason against Sordland.”"*)

### Węzeł `[196]`
**[WYBÓR GRACZA: "“You were the one who told me to sign this act! You are involved in this too!""]** — Mówca: **Player**
> "“You were the one who told me to sign this act! You are involved in this too!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[183]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Orso Hawker: "“Silence! I will not allow slander in this courtroom!”"*)

### Węzeł `[197]`
Mówca: **Orso Hawker**
> "“Silence! I will not allow slander in this courtroom!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Orso Hawker: "“This court will now proceed with the final evaluation of..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Testify_Lucian == true && BaseGame.Relations_Lucian_GaladeWonMatch == true && BaseGame.Decision_Turn08_VPSelection_Lucian == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Testify_Lucian == true && BaseGame..."*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_Testify_Lucian == true && BaseGa..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Testify_Lucian == true && BaseGame.Relations_Lucian_GaladeWonMatch == true && BaseGame.Decision_Turn08_VPSelection_Lucian == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Testify_Lucian"] == true  and  Variable["BaseGame.Relations_Lucian_GaladeWonMatch"] == true  and  Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Game_Chessmaster");"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_Testify_Lucian == true && BaseGame.Relations_Lucian_GaladeWonMatch == true && BaseGame.Decision_Turn08_VPSelection_Lucian == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Testify_Lucian"] == true  and  Variable["BaseGame.Relations_Lucian_GaladeWonMatch"] == true  and  Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Game_Chessmaster");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Game_Chessmaster");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "End();"*)
