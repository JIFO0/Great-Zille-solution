# Sordland/Turn07/IsabelIntro

- **ID konwersacji:** `113`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/113_IsabelIntro.md`
- **Liczba węzłów dialogowych:** 151
- **Liczba wyborów gracza:** 24

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[59]** Isabel Edmonds

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.ErsenCase_Statement_ProBlud`
- `BaseGame.ErsenCase_Statement_ProSollist`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Decrees_Weaker`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Honorary_NoImmunity`
- `BaseGame.Reform_Law_Honorary_Presidents`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Relations_Nia_Opposition`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn07_A_Isabel_Opinion`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[107] Sordland/Turn07/A_ConvinceIsabel** (../Turn_07/107_A_ConvinceIsabel.md), Węzeł `[149]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""We both know that I will have a target on my back after this. I need that immunity.""** | `[9]` **Isabel Edmonds**: ""With all due respect, Mr. Presi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Isabel Edmonds**: ""Of course. This is all about yo..." |
| `[15]` | **""You're still not seeing the complete picture. This proposal is a step towards dem..."** | `[9]` **Isabel Edmonds**: ""With all due respect, Mr. Presi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Isabel Edmonds**: ""Democratization!?"" |
| `[16]` | **""We both know that the Old Guard that dominates and obstructs the court needs to b..."** | `[14]` **Isabel Edmonds**: ""The same assembly that your par..."<br>`[92]` **Isabel Edmonds**: ""You are expanding the powers of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Isabel Edmonds**: ""This law will not only apply to..." |
| `[17]` | **""I'm not going to deny that. That is the situation.""** | `[76]` **Isabel Edmonds**: ""You need our wing to vote for y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Isabel Edmonds**: ""That's a start."" |
| `[18]` | **""Therefore, you will vote yes.""** | `[76]` **Isabel Edmonds**: ""You need our wing to vote for y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Narrator**: "She measured me with her eyes." |
| `[19]` | **""Don't get ahead of yourself.""** | `[76]` **Isabel Edmonds**: ""You need our wing to vote for y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Narrator**: "She stared at me for a few secon..." |
| `[20]` | **""I'm sure we can make a deal.""** | `[76]` **Isabel Edmonds**: ""You need our wing to vote for y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Isabel Edmonds**: ""I'm not here to make a deal, Mr..." |
| `[23]` | **""We don't want that.""** | `[79]` **Isabel Edmonds**: ""But now you face the Supreme Co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Isabel Edmonds**: ""I know."" |
| `[26]` | **""That's why we have you here.""** | `[79]` **Isabel Edmonds**: ""But now you face the Supreme Co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Isabel Edmonds**: ""I know."" |
| `[45]` | **""Not if you support us.""** | `[79]` **Isabel Edmonds**: ""But now you face the Supreme Co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Isabel Edmonds**: ""I know."" |
| `[47]` | **""You oppose this because of that one simple clause?""** | `[9]` **Isabel Edmonds**: ""With all due respect, Mr. Presi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Isabel Edmonds**: ""You take away our immunity and ..." |
| `[50]` | **""But you like the proposal?""** | `[79]` **Isabel Edmonds**: ""But now you face the Supreme Co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Isabel Edmonds**: ""You made a very clever package,..."<br>`[67]` **Isabel Edmonds**: ""....Using Soll's membership law..."<br>*(oraz 1 innych odgałęzień)* |
| `[55]` | **""And what do you think about the proposal itself?""** | `[29]` **Isabel Edmonds**: ""...But it pains me to say that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Isabel Edmonds**: ""To start with, I think it's dis..." |
| `[56]` | **""Not if you support us.""** | `[29]` **Isabel Edmonds**: ""...But it pains me to say that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Isabel Edmonds**: ""You are right."" |
| `[57]` | **""That's why we have you here.""** | `[29]` **Isabel Edmonds**: ""...But it pains me to say that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Isabel Edmonds**: ""You are right."" |
| `[81]` | **""And what about the powers of the Supreme Court?""** | `[14]` **Isabel Edmonds**: ""The same assembly that your par..."<br>`[92]` **Isabel Edmonds**: ""You are expanding the powers of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Isabel Edmonds**: ""What about it? You are already ..." |
| `[82]` | **""We need proper balance of power, Mrs. Edmonds. Try to see the bigger picture.""** | `[14]` **Isabel Edmonds**: ""The same assembly that your par..."<br>`[92]` **Isabel Edmonds**: ""You are expanding the powers of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Isabel Edmonds**: ""Proper? You are already trying ..." |
| `[106]` | **""And what do you think about the proposal itself?""** | `[105]` **Isabel Edmonds**: ""...But it pains me to say that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Isabel Edmonds**: ""What I think really doesn't mat..." |
| `[107]` | **""Not if you support us.""** | `[105]` **Isabel Edmonds**: ""...But it pains me to say that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Isabel Edmonds**: ""You think that's enough?"" |
| `[108]` | **""That's why we have you here.""** | `[105]` **Isabel Edmonds**: ""...But it pains me to say that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Isabel Edmonds**: ""You think that's enough?"" |
| `[113]` | **""The discrimination and oppression that many Bludish people face in this country.""** | `[112]` **Isabel Edmonds**: ""What were you even thinking?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Isabel Edmonds**: ""I thought you were a tactical m..." |
| `[114]` | **""The Assembly proved many wrong by passing it, Ms. Edmonds. The atmosphere in this..."** | `[112]` **Isabel Edmonds**: ""What were you even thinking?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Isabel Edmonds**: ""What matters is the atmosphere ..." |
| `[115]` | **""You know those changes are about equality and rights, Justice Edmonds.""** | `[112]` **Isabel Edmonds**: ""What were you even thinking?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Isabel Edmonds**: ""Try explaining that to the Soll..." |
| `[116]` | **""Do you not approve of those?""** | `[112]` **Isabel Edmonds**: ""What were you even thinking?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Isabel Edmonds**: ""You know you need the other jus..." |

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
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProBlud == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ErsenCase_Statement_ProSollist == true)"*)

### Węzeł `[3]`
Mówca: **Isabel Edmonds**
> ""You must be-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[4]`
**[WYBÓR GRACZA: ""We both know that I will have a target on my back after this. I need that immunity.""]** — Mówca: **Player**
> ""We both know that I will have a target on my back after this. I need that immunity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Isabel Edmonds: ""Of course. This is all about you, Mr. President, isn't it?""*)

### Węzeł `[5]`
Mówca: **Isabel Edmonds**
> ""Of course. This is all about you, Mr. President, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Isabel Edmonds: ""You must be-""*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Isabel Edmonds: ""With all due respect, Mr. President. I think you got ahe..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[9]`
Mówca: **Isabel Edmonds**
> ""With all due respect, Mr. President. I think you got ahead of yourself. Especially by trying to remove your impeachment procedure and giving yourself immunity. This is too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: ""We both know that I will have a target on my back after ..."*)
  - -> `[15]` (*Player: ""You're still not seeing the complete picture. This propo..."*)
  - -> `[47]` (*Player: ""You oppose this because of that one simple clause?""*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Isabel Edmonds: ""First of all, I want to congratulate you on the successf..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Isabel Edmonds: ""First of all... Congratulations with the vote in the Gra..."*)

### Węzeł `[13]`
Mówca: **Isabel Edmonds**
> ""So that you can create your own *Old Guard* and kick everyone with opposing views? The Judiciary must be independent, Mr. President and the clause you removed was a prerequisite of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "She sighed."*)

### Węzeł `[14]`
Mówca: **Isabel Edmonds**
> ""The same assembly that your party controls, by the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player: ""We both know that the Old Guard that dominates and obstr..."*)
  - -> `[82]` (*Player: ""We need proper balance of power, Mrs. Edmonds. Try to se..."*)
  - -> `[81]` (*Player: ""And what about the powers of the Supreme Court?""*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""You're still not seeing the complete picture. This proposal is a step towards democratization.""]** — Mówca: **Player**
> ""You're still not seeing the complete picture. This proposal is a step towards democratization.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Isabel Edmonds: ""Democratization!?""*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""We both know that the Old Guard that dominates and obstructs the court needs to be dealt with.""]** — Mówca: **Player**
> ""We both know that the Old Guard that dominates and obstructs the court needs to be dealt with.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Isabel Edmonds), `[92]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Isabel Edmonds: ""This law will not only apply to them but all Justices, M..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: ""I'm not going to deny that. That is the situation.""]** — Mówca: **Player**
> ""I'm not going to deny that. That is the situation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Isabel Edmonds: ""That's a start.""*)

### Węzeł `[18]`
**[WYBÓR GRACZA: ""Therefore, you will vote yes.""]** — Mówca: **Player**
> ""Therefore, you will vote yes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "She measured me with her eyes."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: ""Don't get ahead of yourself.""]** — Mówca: **Player**
> ""Don't get ahead of yourself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "She stared at me for a few seconds. She seemed to be take..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""I'm sure we can make a deal.""]** — Mówca: **Player**
> ""I'm sure we can make a deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Isabel Edmonds: ""I'm not here to make a deal, Mr. President. I'm here to ..."*)

### Węzeł `[21]`
Mówca: **Isabel Edmonds**
> ""Mr. President is aiming to destroy the Court and he needs us to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == true"*)

### Węzeł `[22]`
Mówca: **Isabel Edmonds**
> ""That's a start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[23]`
**[WYBÓR GRACZA: ""We don't want that.""]** — Mówca: **Player**
> ""We don't want that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Isabel Edmonds: ""I know.""*)

### Węzeł `[24]`
Mówca: **Isabel Edmonds**
> ""I doubt that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[25]`
Mówca: **Narrator**
> "She measured me with her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Isabel Edmonds: ""I doubt that.""*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""That's why we have you here.""]** — Mówca: **Player**
> ""That's why we have you here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Isabel Edmonds: ""I know.""*)

### Węzeł `[27]`
Mówca: **Isabel Edmonds**
> ""I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Isabel Edmonds: ""I am perfectly aware that you need us.""*)

### Węzeł `[28]`
Mówca: **Isabel Edmonds**
> ""I'm not here to make a deal, Mr. President. I'm here to talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Isabel Edmonds: ""I hope you're not thinking about bribing a Supreme Court..."*)

### Węzeł `[29]`
Mówca: **Isabel Edmonds**
> ""...But it pains me to say that your proposal has a very low chance of getting through the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: ""That's why we have you here.""*)
  - -> `[56]` (*Player: ""Not if you support us.""*)
  - -> `[55]` (*Player: ""And what do you think about the proposal itself?""*)

### Węzeł `[30]`
Mówca: **Isabel Edmonds**
> ""I hope you're not thinking about bribing a Supreme Court Justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[31]`
Mówca: **Isabel Edmonds**
> ""First of all... Congratulations with the vote in the Grand National Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Decrees_Removed == true || BaseGame...."*)

### Węzeł `[32]`
Mówca: **Isabel Edmonds**
> ""It is you, Mr. President, who shouldn't get ahead of himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[33]`
Mówca: **Narrator**
> "She stared at me for a few seconds. She seemed to be taken aback by my response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Isabel Edmonds: ""It is you, Mr. President, who shouldn't get ahead of him..."*)

### Węzeł `[34]`
Mówca: **Isabel Edmonds**
> ""First of all, I want to congratulate you on the successful vote in the Grand National Assembly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Isabel Edmonds: ""...But it pains me to say that your proposal has a very ..."*)

### Węzeł `[36]`
Mówca: **Nia Morgna**
> ""Mrs. Edmonds... Let's calm down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Isabel Edmonds: ""You made a very clever package, Mr. President. The real ..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)

### Węzeł `[40]`
Mówca: **Nia Morgna**
> ""Bribe? Who do you think we are, Mrs. Edmonds?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[41]`
Mówca: **Isabel Edmonds**
> ""I admire your struggle. Especially because you were strong enough to include concessions from your side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Law_Impeachment_Removed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Decrees_Removed == true || BaseGame...."*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Law_Decrees_Removed == true || BaseGam..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Law_Impeachment_Removed == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Isabel Edmonds: ""I admire your struggle. Especially because you were stro..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Law_Impeachment_Removed == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true || BaseGam..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: ""Not if you support us.""]** — Mówca: **Player**
> ""Not if you support us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Isabel Edmonds: ""I know.""*)

### Węzeł `[46]`
Mówca: **Isabel Edmonds**
> ""Why should I vote for a proposal that will take away my immunity as a Justice? Was this the promised reform? Impeaching a Justice with the decision of the Assembly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Isabel Edmonds: ""The same assembly that your party controls, by the way.""*)

### Węzeł `[47]`
**[WYBÓR GRACZA: ""You oppose this because of that one simple clause?""]** — Mówca: **Player**
> ""You oppose this because of that one simple clause?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Isabel Edmonds: ""You take away our immunity and give it to yourself, and ..."*)

### Węzeł `[48]`
Mówca: **Isabel Edmonds**
> ""You made a very clever package, Mr. President. The real gain here is your immunity from impeachment. And...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)

### Węzeł `[49]`
Mówca: **Isabel Edmonds**
> ""You take away our immunity and give it to yourself, and I'm opposing because of a little simple clause?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[50]`
**[WYBÓR GRACZA: ""But you like the proposal?""]** — Mówca: **Player**
> ""But you like the proposal?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[51]`
Mówca: **Isabel Edmonds**
> ""Democratization!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[52]`
Mówca: **Isabel Edmonds**
> ""What about it? You are already trying to take our right to vote on constitutional legislature and also open a way to impeach us, are you not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "She sighed."*)

### Węzeł `[53]`
Mówca: **Isabel Edmonds**
> ""You are really brave, Mr. President. Trying to go against Tarquin Soll's member of honor rights, huh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Isabel Edmonds: ""But now you face the Supreme Court. And it pains me to s..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Isabel Edmonds: ""You must be-""*)

### Węzeł `[55]`
**[WYBÓR GRACZA: ""And what do you think about the proposal itself?""]** — Mówca: **Player**
> ""And what do you think about the proposal itself?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Isabel Edmonds: ""To start with, I think it's disrespectful.""*)

### Węzeł `[56]`
**[WYBÓR GRACZA: ""Not if you support us.""]** — Mówca: **Player**
> ""Not if you support us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Isabel Edmonds: ""You are right.""*)

### Węzeł `[57]`
**[WYBÓR GRACZA: ""That's why we have you here.""]** — Mówca: **Player**
> ""That's why we have you here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Isabel Edmonds: ""You are right.""*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[59]`
Mówca: **Isabel Edmonds**
> ""You know it's true, Mrs. Morgna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Isabel Edmonds: ""Mr. President is aiming to destroy the Court and he need..."*)

### Węzeł `[60]`
Mówca: **Isabel Edmonds**
> ""Proper? You are already trying to take our right to vote on constitutional legislature and also open a way to impeach us, are you not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "She sighed."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true || BaseGam..."*)

### Węzeł `[62]`
Mówca: **Isabel Edmonds**
> ""This law will not only apply to them but all Justices, Mr. President. Who will protect our rights if you take away our immunity?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Isabel Edmonds: ""So that you can create your own *Old Guard* and kick eve..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == true)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Isabel Edmonds: ""....Using Soll's membership laws for your own benefit? I..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Isabel Edmonds: ""....No. I don't like the proposal.""*)

### Węzeł `[66]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[67]`
Mówca: **Isabel Edmonds**
> ""....Using Soll's membership laws for your own benefit? I have to say I don't really like this proposal, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true || BaseGam..."*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Abolished == true || BaseG..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Isabel Edmonds: ""You are really brave, Mr. President. Trying to go agains..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Isabel Edmonds: ""But now you face the Supreme Court. And it pains me to s..."*)

### Węzeł `[71]`
Mówca: **Isabel Edmonds**
> ""You need our wing to vote for you. Otherwise all of your hard work will be in vain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[72]`
Mówca: **Isabel Edmonds**
> ""....No. I don't like the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Isabel Edmonds: ""So the current situation is clear...""*)

### Węzeł `[73]`
Mówca: **Isabel Edmonds**
> ""To start with, I think it's disrespectful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Isabel Edmonds: ""You are packaging it as a democratic reform, yet it smel..."*)

### Węzeł `[74]`
Mówca: **Isabel Edmonds**
> ""I am perfectly aware that you need us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Isabel Edmonds: ""So the current situation is clear...""*)

### Węzeł `[75]`
Mówca: **Isabel Edmonds**
> ""You are packaging it as a democratic reform, yet it smells like an attack against the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[76]`
Mówca: **Isabel Edmonds**
> ""You need our wing to vote for you. Otherwise all of your hard work will be in vain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: ""I'm not going to deny that. That is the situation.""*)
  - -> `[18]` (*Player: ""Therefore, you will vote yes.""*)
  - -> `[19]` (*Player: ""Don't get ahead of yourself.""*)
  - -> `[20]` (*Player: ""I'm sure we can make a deal.""*)

### Węzeł `[77]`
Mówca: **Isabel Edmonds**
> ""So the current situation is clear...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Isabel Edmonds: ""You need our wing to vote for you. Otherwise all of your..."*)

### Węzeł `[78]`
Mówca: **Isabel Edmonds**
> ""You are right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Isabel Edmonds: ""You need our wing to vote for you. Otherwise all of your..."*)

### Węzeł `[79]`
Mówca: **Isabel Edmonds**
> ""But now you face the Supreme Court. And it pains me to say that your proposal has a very low chance of getting through it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: ""That's why we have you here.""*)
  - -> `[45]` (*Player: ""Not if you support us.""*)
  - -> `[50]` (*Player: ""But you like the proposal?""*)
  - -> `[23]` (*Player: ""We don't want that.""*)

### Węzeł `[80]`
Mówca: **Nia Morgna**
> ""Mrs. Edmonds...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Isabel Edmonds: ""You know it's true, Mrs. Morgna.""*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""And what about the powers of the Supreme Court?""]** — Mówca: **Player**
> ""And what about the powers of the Supreme Court?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Isabel Edmonds), `[92]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Isabel Edmonds: ""What about it? You are already trying to take our right ..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: ""We need proper balance of power, Mrs. Edmonds. Try to see the bigger picture.""]** — Mówca: **Player**
> ""We need proper balance of power, Mrs. Edmonds. Try to see the bigger picture.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Isabel Edmonds), `[92]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Isabel Edmonds: ""Proper? You are already trying to take our right to vote..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Isabel Edmonds: ""You know it's true, Mr. President.""*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Nia Morgna: ""Mrs. Edmonds...""*)

### Węzeł `[86]`
Mówca: **Isabel Edmonds**
> ""You know it's true, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Isabel Edmonds: ""You are aiming to destroy the Court and you need us to d..."*)

### Węzeł `[87]`
Mówca: **Isabel Edmonds**
> ""You are aiming to destroy the Court and you need us to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == true"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == true"*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_President == true)"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Isabel Edmonds: ""Why should I vote for a proposal that will take away my ..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Isabel Edmonds: ""Why should I vote for a proposal that will take away my ..."*)

### Węzeł `[91]`
Mówca: **Isabel Edmonds**
> ""Why should I vote for a proposal that will take away my immunity as a Justice? Was this the promised reform? Removing Justices however you see fit?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Isabel Edmonds: ""You are expanding the powers of the president, which alr..."*)

### Węzeł `[92]`
Mówca: **Isabel Edmonds**
> ""You are expanding the powers of the president, which already is very powerful. ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player: ""We both know that the Old Guard that dominates and obstr..."*)
  - -> `[82]` (*Player: ""We need proper balance of power, Mrs. Edmonds. Try to se..."*)
  - -> `[81]` (*Player: ""And what about the powers of the Supreme Court?""*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Isabel Edmonds: ""So the current situation is clear...""*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Nia Morgna: ""Mrs. Edmonds... Let's calm down.""*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Nia Morgna: ""Bribe? Who do you think we are, Mrs. Edmonds?""*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Isabel Edmonds: ""First of all, I want to congratulate you on the successf..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[103]`
Mówca: **Isabel Edmonds**
> ""First of all, I want to congratulate you on the successful vote in the Grand National Assembly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Isabel Edmonds: ""...But it pains me to say that your *updated* proposal h..."*)

### Węzeł `[105]`
Mówca: **Isabel Edmonds**
> ""...But it pains me to say that your *updated* proposal has a very low chance of getting through the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player: ""That's why we have you here.""*)
  - -> `[107]` (*Player: ""Not if you support us.""*)
  - -> `[106]` (*Player: ""And what do you think about the proposal itself?""*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""And what do you think about the proposal itself?""]** — Mówca: **Player**
> ""And what do you think about the proposal itself?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Isabel Edmonds: ""What I think really doesn't matter with a proposal like ..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""Not if you support us.""]** — Mówca: **Player**
> ""Not if you support us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Isabel Edmonds: ""You think that's enough?""*)

### Węzeł `[108]`
**[WYBÓR GRACZA: ""That's why we have you here.""]** — Mówca: **Player**
> ""That's why we have you here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Isabel Edmonds: ""You think that's enough?""*)

### Węzeł `[109]`
Mówca: **Isabel Edmonds**
> ""You think that's enough?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Isabel Edmonds: ""Changing Article 6 and 7? Removing 'Sord' from the Const..."*)

### Węzeł `[110]`
Mówca: **Isabel Edmonds**
> ""What I think really doesn't matter with a proposal like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Isabel Edmonds: ""Changing Article 6 and 7? Removing 'Sord' from the Const..."*)

### Węzeł `[111]`
Mówca: **Isabel Edmonds**
> ""Changing Article 6 and 7? Removing 'Sord' from the Constitution?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Isabel Edmonds: ""What were you even thinking?""*)

### Węzeł `[112]`
Mówca: **Isabel Edmonds**
> ""What were you even thinking?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player: ""The discrimination and oppression that many Bludish peop..."*)
  - -> `[114]` (*Player: ""The Assembly proved many wrong by passing it, Ms. Edmond..."*)
  - -> `[115]` (*Player: ""You know those changes are about equality and rights, Ju..."*)
  - -> `[116]` (*Player: ""Do you not approve of those?""*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The discrimination and oppression that many Bludish people face in this country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Isabel Edmonds: ""I thought you were a tactical man, Mr. President. But yo..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The Assembly proved many wrong by passing it, Ms. Edmonds. The atmosphere in this country is now changing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Isabel Edmonds: ""What matters is the atmosphere of the Supreme Court, Mr...."*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know those changes are about equality and rights, Justice Edmonds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Isabel Edmonds: ""Try explaining that to the Sollists and the Sordists.""*)

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you not approve of those?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Isabel Edmonds: ""You know you need the other justices to vote for it too,..."*)

### Węzeł `[117]`
Mówca: **Isabel Edmonds**
> ""You know you need the other justices to vote for it too, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[118]`
Mówca: **Isabel Edmonds**
> ""Try explaining that to the Sollists and the Sordists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[119]`
Mówca: **Isabel Edmonds**
> ""I thought you were a tactical man, Mr. President. But you decided to gamble with your reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[120]`
Mówca: **Isabel Edmonds**
> ""What matters is the atmosphere of the Supreme Court, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Isabel Edmonds: ""But before we get bogged down in details, I must say I f..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Isabel Edmonds: ""But before we get bogged down in details, I must say this.""*)

### Węzeł `[124]`
Mówca: **Isabel Edmonds**
> ""But before we get bogged down in details, I must say I find your proposal disrespectful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[125]`
Mówca: **Isabel Edmonds**
> ""And now you need our wing to vote for you. Otherwise all of your hard work will be in vain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Isabel Edmonds: ""And now you need our wing to vote for you. Otherwise all..."*)

### Węzeł `[127]`
Mówca: **Isabel Edmonds**
> ""But before we get bogged down in details, I must say this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true || BaseGam..."*)

### Węzeł `[128]`
Mówca: **Isabel Edmonds**
> ""You are really brave. Trying to go against Tarquin Soll's member of honor rights, huh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Decrees_Removed == true || BaseGame...."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true || BaseGam..."*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Abolished == true || BaseG..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Isabel Edmonds: ""You are really brave. Trying to go against Tarquin Soll'..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Decrees_Removed == true || BaseGame...."*)

### Węzeł `[132]`
Mówca: **Isabel Edmonds**
> ""I admire your struggle. Especially because you were strong enough to include concessions from your side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Isabel Edmonds: ""You don't have a strong position here.""*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Law_Impeachment_Removed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Decrees_Removed == true || BaseGame...."*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Law_Decrees_Removed == true || BaseGam..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Law_Impeachment_Removed == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Isabel Edmonds: ""I admire your struggle. Especially because you were stro..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Law_Impeachment_Removed == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Isabel Edmonds: ""You don't have a strong position here.""*)

### Węzeł `[136]`
Mówca: **Isabel Edmonds**
> ""You don't have a strong position here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "Jump to: [Isabel Edmonds: ""You need our wing to vote for..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Isabel Edmonds: ""You need our wing to vote for you...."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Isabel Edmonds: ""You need our wing to vote for you. Otherwise all of your..."*)

### Węzeł `[138]`
Mówca: **Isabel Edmonds**
> ""You know, Mr. President... Since you tried to intervene with the Court's decision on Mr. Ersen's case, there is quite a bit of hostility against you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProBlud == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProBlud == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ErsenCase_Statement_ProBlud == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProBlud == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Isabel Edmonds: ""You know, Mr. President... Since you tried to intervene ..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ErsenCase_Statement_ProBlud == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProSollist == true"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Isabel Edmonds: ""But before that, I want to congratulate you on the succe..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[145]`
Mówca: **Isabel Edmonds**
> ""But before that, I want to congratulate you on the successful vote in the Grand National Assembly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[146]`
Mówca: **Isabel Edmonds**
> ""You know, Mr. President... Since you tried to intervene with the Court's decision on Mr. Ersen's case, you created some hostility against yourself among my wing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Isabel Edmonds: ""But...""*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProSollist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProSollist == true"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ErsenCase_Statement_ProSollist == true)"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProSollist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Isabel Edmonds: ""You know, Mr. President... Since you tried to intervene ..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ErsenCase_Statement_ProSollist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[150]`
Mówca: **Isabel Edmonds**
> ""But...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
