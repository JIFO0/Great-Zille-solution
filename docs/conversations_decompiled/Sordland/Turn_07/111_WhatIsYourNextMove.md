# Sordland/Turn07/WhatIsYourNextMove

- **ID konwersacji:** `111`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/111_WhatIsYourNextMove.md`
- **Liczba węzłów dialogowych:** 93
- **Liczba wyborów gracza:** 25

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[59]** Isabel Edmonds

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Policy_Order_AntiCorruptionPolice`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Relations_Nia_Opposition`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn07_A_Isabel_Opinion`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[112] Sordland/Turn07/IsabelPersuasion** (../Turn_07/112_IsabelPersuasion.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **""To further the reforms.""** | `[10]` **Isabel Edmonds**: ""...What will be your next move?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Isabel Edmonds**: ""I see."" |
| `[7]` | **""To ensure the new processes are respected and executed in transparency.""** | `[10]` **Isabel Edmonds**: ""...What will be your next move?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[20]` **Isabel Edmonds**: ""I see."" |
| `[8]` | **""Focus on our internal and external threats.""** | `[10]` **Isabel Edmonds**: ""...What will be your next move?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[3]` **Isabel Edmonds**: ""That's relieving to hear. I tho..." |
| `[9]` | **""We will eliminate the Old Guards from all branches of government.""** | `[10]` **Isabel Edmonds**: ""...What will be your next move?"" | `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true` | *Brak zmian stanu* | `[23]` **Isabel Edmonds**: ""You shouldn't make a move again..." |
| `[17]` | **""That point was a red line for Mr. Ricter. We had to include it.""** | `[21]` **Isabel Edmonds**: ""I'm asking the President, Mrs. ..."<br>`[5]` **Isabel Edmonds**: ""Can you explain me one thing. H..." | `Variable["BaseGame.Reform_Reformist_Path"] == true`<br>`Variable["BaseGame.Relations_Nia_Opposition"] == true` | *Brak zmian stanu* | `[49]` **Isabel Edmonds**: ""Interesting. So you do not own ..." |
| `[25]` | **""Trust me. It is only the Old Guard we're after.""** | `[24]` **Isabel Edmonds**: ""How can I be sure that you will..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "Isabel took another sip from her..."<br>`[31]` **Nia Morgna**: ""Mrs. Edmonds, we are not agains..." |
| `[27]` | **""Help me bring Orso Hawker down. He's the only one we need.""** | `[24]` **Isabel Edmonds**: ""How can I be sure that you will..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "Isabel took another sip from her..."<br>`[31]` **Nia Morgna**: ""Mrs. Edmonds, we are not agains..." |
| `[29]` | **""We can't do anything without a proper cause anyway.""** | `[24]` **Isabel Edmonds**: ""How can I be sure that you will..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "Isabel took another sip from her..."<br>`[31]` **Nia Morgna**: ""Mrs. Edmonds, we are not agains..." |
| `[36]` | **""I did not intend any offense, Mrs. Edmonds. Please accept my apology.""** | `[28]` **Isabel Edmonds**: ""I'm sorry?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Isabel Edmonds**: ""Of course not..."" |
| `[38]` | **""Mrs. Edmonds, please help us achieve this victory. We have to be together in this.""** | `[35]` **Narrator**: "Isabel took another sip from her..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[57]` **Isabel Edmonds**: ""Perhaps that is the way we must..." |
| `[39]` | **""What do you want in return for the centrist vote?""** | `[35]` **Narrator**: "Isabel took another sip from her..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Isabel Edmonds**: ""I don't want anything, Mr. Pres..." |
| `[40]` | **""Mrs. Edmonds, how about we get to the point now?""** | `[35]` **Narrator**: "Isabel took another sip from her..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[55]` **Isabel Edmonds**: ""Isn't that where we are?"" |
| `[44]` | **""Let's just get to the point, Mrs. Edmonds. Do I have your vote or not?""** | `[28]` **Isabel Edmonds**: ""I'm sorry?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[4]` **Narrator**: "She sighed and looked outside th..."<br>`[19]` **Nia Morgna**: ""Mr. President!"" |
| `[45]` | **""I told you. You are not our target.""** | `[53]` **Isabel Edmonds**: ""I just want assurance that you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Isabel Edmonds**: ""That's not very relieving."" |
| `[54]` | **""Why don't you ask the *reformists*? This proposal was made together.""** | `[21]` **Isabel Edmonds**: ""I'm asking the President, Mrs. ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[47]` **Narrator**: "She sighed." |
| `[56]` | **""The judiciary should not have legislative powers, Mrs. Edmonds.""** | `[21]` **Isabel Edmonds**: ""I'm asking the President, Mrs. ..."<br>`[5]` **Isabel Edmonds**: ""Can you explain me one thing. H..." | `Variable["BaseGame.Relations_Nia_Opposition"] == true` | *Brak zmian stanu* | `[76]` **Isabel Edmonds**: ""So that is your position... I s..." |
| `[58]` | **""I did not intend any offense, Mrs. Edmonds. Please accept my apology.""** | `[74]` **Isabel Edmonds**: ""I didn't come here to be disres..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[16]` **Isabel Edmonds**: ""Of course."" |
| `[60]` | **""You heard me.""** | `[28]` **Isabel Edmonds**: ""I'm sorry?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[4]` **Narrator**: "She sighed and looked outside th..."<br>`[19]` **Nia Morgna**: ""Mr. President!"" |
| `[62]` | **""How can we even do that? Please, Mrs. Edmonds. Don't overexaggerate.""** | `[53]` **Isabel Edmonds**: ""I just want assurance that you ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[75]` **Isabel Edmonds**: ""That's not very relieving."" |
| `[63]` | **""You have my word.""** | `[53]` **Isabel Edmonds**: ""I just want assurance that you ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[61]` **Isabel Edmonds**: ""I hope so."" |
| `[64]` | **""I didn't want to disrespect you, Mrs. Edmonds.""** | `[74]` **Isabel Edmonds**: ""I didn't come here to be disres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Isabel Edmonds**: ""Of course."" |
| `[66]` | **""With all due respect, you are reaching the last straw.""** | `[74]` **Isabel Edmonds**: ""I didn't come here to be disres..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[28]` **Isabel Edmonds**: ""I'm sorry?"" |
| `[71]` | **""The Court has been stopping every constitutional change, Mrs. Edmonds...""** | `[21]` **Isabel Edmonds**: ""I'm asking the President, Mrs. ..."<br>`[5]` **Isabel Edmonds**: ""Can you explain me one thing. H..." | `Variable["BaseGame.Relations_Nia_Opposition"] == true` | *Brak zmian stanu* | `[76]` **Isabel Edmonds**: ""So that is your position... I s..." |
| `[86]` | **""Why don't you ask the *reformists*? That clause was one of their main demands too.""** | `[5]` **Isabel Edmonds**: ""Can you explain me one thing. H..." | `Variable["BaseGame.Relations_Nia_Opposition"] == true` | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[47]` **Narrator**: "She sighed." |
| `[87]` | **""That point was a red line for the opposition. We had to include it.""** | `[5]` **Isabel Edmonds**: ""Can you explain me one thing. H..." | `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`<br>`Variable["BaseGame.Relations_Nia_Opposition"] == true` | *Brak zmian stanu* | `[49]` **Isabel Edmonds**: ""Interesting. So you do not own ..." |

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
  - -> `[10]` (*Isabel Edmonds: ""...What will be your next move?""*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[3]`
Mówca: **Isabel Edmonds**
> ""That's relieving to hear. I thought you forgot about all the other issues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "Isabel took another sip from her water and looked at me w..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "She sighed and looked outside the window for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Isabel Edmonds: ""Can you explain me one thing. How come you think that th..."*)

### Węzeł `[5]`
Mówca: **Isabel Edmonds**
> ""Can you explain me one thing. How come you think that the Supreme Court's right to vote on constitutional amendments is a major problem with such priority?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[6]`
**[WYBÓR GRACZA: ""To further the reforms.""]** — Mówca: **Player**
> ""To further the reforms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Isabel Edmonds: ""I see.""*)

### Węzeł `[7]`
**[WYBÓR GRACZA: ""To ensure the new processes are respected and executed in transparency.""]** — Mówca: **Player**
> ""To ensure the new processes are respected and executed in transparency.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[8]`
**[WYBÓR GRACZA: ""Focus on our internal and external threats.""]** — Mówca: **Player**
> ""Focus on our internal and external threats.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[9]`
**[WYBÓR GRACZA: ""We will eliminate the Old Guards from all branches of government.""]** — Mówca: **Player**
> ""We will eliminate the Old Guards from all branches of government.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Kontekst wejściowy (poprzednik):** `[10]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Isabel Edmonds: ""You shouldn't make a move against the Court, Mr. Preside..."*)

### Węzeł `[10]`
Mówca: **Isabel Edmonds**
> ""...What will be your next move?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
  - -> `[7]` (*Player: ""To ensure the new processes are respected and executed i..."*)
  - -> `[6]` (*Player: ""To further the reforms.""*)
  - -> `[8]` (*Player: ""Focus on our internal and external threats.""*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player: ""We will eliminate the Old Guards from all branches of go..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[14]`
Mówca: **Nia Morgna**
> ""I thought we wer-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Isabel Edmonds: ""I'm asking the President, Mrs. Morgna.""*)

### Węzeł `[15]`
Mówca: **Narrator**
> "She sighed and looked outside the window for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Isabel Edmonds: ""Can you explain me one thing. How come you think that th..."*)

### Węzeł `[16]`
Mówca: **Isabel Edmonds**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "She sighed and looked outside the window for a moment."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: ""That point was a red line for Mr. Ricter. We had to include it.""]** — Mówca: **Player**
> ""That point was a red line for Mr. Ricter. We had to include it.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reformist_Path"] == true` AND `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Kontekst wejściowy (poprzednik):** `[21]` (Isabel Edmonds), `[5]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Isabel Edmonds: ""Interesting. So you do not own it up, after all.""*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Isabel Edmonds: ""That's relieving to hear. I thought you forgot about all..."*)

### Węzeł `[19]`
Mówca: **Nia Morgna**
> ""Mr. President!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Nia looked really worried and tense."*)

### Węzeł `[20]`
Mówca: **Isabel Edmonds**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "Isabel took another sip from her water and looked at me w..."*)

### Węzeł `[21]`
Mówca: **Isabel Edmonds**
> ""I'm asking the President, Mrs. Morgna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player: ""Why don't you ask the *reformists*? This proposal was ma..."*)
  - -> `[71]` (*Player: ""The Court has been stopping every constitutional change,..."*)
  - -> `[56]` (*Player: ""The judiciary should not have legislative powers, Mrs. E..."*)
  - -> `[17]` (*Player: ""That point was a red line for Mr. Ricter. We had to incl..."*)

### Węzeł `[22]`
Mówca: **Isabel Edmonds**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "She sighed and looked outside the window for a moment."*)

### Węzeł `[23]`
Mówca: **Isabel Edmonds**
> ""You shouldn't make a move against the Court, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Isabel Edmonds: ""How can I be sure that you will not go after us too?""*)

### Węzeł `[24]`
Mówca: **Isabel Edmonds**
> ""How can I be sure that you will not go after us too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""Trust me. It is only the Old Guard we're after.""*)
  - -> `[27]` (*Player: ""Help me bring Orso Hawker down. He's the only one we need.""*)
  - -> `[29]` (*Player: ""We can't do anything without a proper cause anyway.""*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Trust me. It is only the Old Guard we're after.""]** — Mówca: **Player**
> ""Trust me. It is only the Old Guard we're after.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[26]`
Mówca: **Narrator**
> "She sighed and looked outside the window for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Isabel Edmonds: ""Can you explain me one thing. How come you think that th..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""Help me bring Orso Hawker down. He's the only one we need.""]** — Mówca: **Player**
> ""Help me bring Orso Hawker down. He's the only one we need.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[28]`
Mówca: **Isabel Edmonds**
> ""I'm sorry?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: ""You heard me.""*)
  - -> `[44]` (*Player: ""Let's just get to the point, Mrs. Edmonds. Do I have you..."*)
  - -> `[36]` (*Player: ""I did not intend any offense, Mrs. Edmonds. Please accep..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: ""We can't do anything without a proper cause anyway.""]** — Mówca: **Player**
> ""We can't do anything without a proper cause anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[30]`
Mówca: **Nia Morgna**
> ""Mrs. Edmonds... Mr. President had a rough day. This court vote is extremely important for us. Please do understand our position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Isabel Edmonds: ""Of course.""*)

### Węzeł `[31]`
Mówca: **Nia Morgna**
> ""Mrs. Edmonds, we are not against you. We want you on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "Isabel took another sip from her water and looked at me w..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Isabel Edmonds: ""Of course.""*)

### Węzeł `[33]`
Mówca: **Isabel Edmonds**
> ""I don't know what to say, Mr. President...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Nia looked really worried and tense."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Nia Morgna: ""Mrs. Edmonds... Mr. President had a rough day. This cour..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "Isabel took another sip from her water and looked at me without saying anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: ""Mrs. Edmonds, please help us achieve this victory. We ha..."*)
  - -> `[39]` (*Player: ""What do you want in return for the centrist vote?""*)
  - -> `[40]` (*Player: ""Mrs. Edmonds, how about we get to the point now?""*)

### Węzeł `[36]`
**[WYBÓR GRACZA: ""I did not intend any offense, Mrs. Edmonds. Please accept my apology.""]** — Mówca: **Player**
> ""I did not intend any offence, Mrs. Edmonds. Please accept my apology.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Isabel Edmonds: ""Of course not...""*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Isabel Edmonds: ""I'm sorry?""*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""Mrs. Edmonds, please help us achieve this victory. We have to be together in this.""]** — Mówca: **Player**
> ""Mrs. Edmonds, please help us achieve this victory. We have to be together in this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""What do you want in return for the centrist vote?""]** — Mówca: **Player**
> ""What do you want in return for the centrist vote?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Isabel Edmonds: ""I don't want anything, Mr. President...""*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""Mrs. Edmonds, how about we get to the point now?""]** — Mówca: **Player**
> ""Mrs. Edmonds, how about we get to the point now?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Isabel Edmonds: ""Perhaps that is the way we must take...""*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Isabel Edmonds: ""Isn't that where we are?""*)

### Węzeł `[43]`
Mówca: **Isabel Edmonds**
> ""I don't want anything, Mr. President...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[44]`
**[WYBÓR GRACZA: ""Let's just get to the point, Mrs. Edmonds. Do I have your vote or not?""]** — Mówca: **Player**
> ""Let's just get to the point, Mrs. Edmonds. Do I have your vote or not?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 2"*)

### Węzeł `[45]`
**[WYBÓR GRACZA: ""I told you. You are not our target.""]** — Mówca: **Player**
> ""I told you. You are not our target.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Isabel Edmonds: ""That's not very relieving.""*)

### Węzeł `[46]`
Mówca: **Isabel Edmonds**
> ""Just because your *corruption* police put some pressure on the Court, doesn't mean you own it now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Isabel Edmonds: ""I didn't come here to be disrespected, Mr. President.""*)

### Węzeł `[47]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Isabel Edmonds: ""I don't know what to say, Mr. President...""*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "She sighed."*)

### Węzeł `[49]`
Mówca: **Isabel Edmonds**
> ""Interesting. So you do not own it up, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Isabel Edmonds: ""I don't know what to say, Mr. President...""*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Isabel Edmonds: ""I just want assurance that you don't intend to destroy t..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Isabel Edmonds: ""My vote is not for sale.""*)

### Węzeł `[53]`
Mówca: **Isabel Edmonds**
> ""I just want assurance that you don't intend to destroy the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player: ""I told you. You are not our target.""*)
  - -> `[62]` (*Player: ""How can we even do that? Please, Mrs. Edmonds. Don't ove..."*)
  - -> `[63]` (*Player: ""You have my word.""*)

### Węzeł `[54]`
**[WYBÓR GRACZA: ""Why don't you ask the *reformists*? This proposal was made together.""]** — Mówca: **Player**
> ""Why don't you ask the *reformists*? This proposal was made together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[55]`
Mówca: **Isabel Edmonds**
> ""Isn't that where we are?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)

### Węzeł `[56]`
**[WYBÓR GRACZA: ""The judiciary should not have legislative powers, Mrs. Edmonds.""]** — Mówca: **Player**
> ""The judiciary should not have legislative powers, Mrs. Edmonds.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Kontekst wejściowy (poprzednik):** `[21]` (Isabel Edmonds), `[5]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Isabel Edmonds: ""So that is your position... I see.""*)

### Węzeł `[57]`
Mówca: **Isabel Edmonds**
> ""Perhaps that is the way we must take...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Isabel Edmonds: ""Can you explain me one thing. How come you think that th..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""I did not intend any offense, Mrs. Edmonds. Please accept my apology.""]** — Mówca: **Player**
> ""I did not intend any offence, Mrs. Edmonds. Please accept my apology.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[59]`
Mówca: **Isabel Edmonds**
> ""My vote is not for sale.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Isabel Edmonds: ""I didn't come here to be disrespected, Mr. President.""*)

### Węzeł `[60]`
**[WYBÓR GRACZA: ""You heard me.""]** — Mówca: **Player**
> ""You heard me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 2"*)

### Węzeł `[61]`
Mówca: **Isabel Edmonds**
> ""I hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Isabel Edmonds: ""Can you explain me one thing. How come you think that th..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""How can we even do that? Please, Mrs. Edmonds. Don't overexaggerate.""]** — Mówca: **Player**
> ""How can we even do that? Please, Mrs. Edmonds. Don't overexaggerate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""You have my word.""]** — Mówca: **Player**
> ""You have my word.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""I didn't want to disrespect you, Mrs. Edmonds.""]** — Mówca: **Player**
> ""I didn't want to disrespect you, Mrs. Edmonds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Isabel Edmonds: ""Of course.""*)

### Węzeł `[65]`
Mówca: **Isabel Edmonds**
> ""Of course not...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "She sighed and looked outside the window for a moment."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: ""With all due respect, you are reaching the last straw.""]** — Mówca: **Player**
> ""With all due respect, you are reaching the last straw.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 2"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_AntiCorruptionPolice == true)"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Isabel Edmonds: ""Just because your *corruption* police put some pressure ..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Isabel Edmonds: ""I didn't come here to be disrespected, Mr. President.""*)

### Węzeł `[71]`
**[WYBÓR GRACZA: ""The Court has been stopping every constitutional change, Mrs. Edmonds...""]** — Mówca: **Player**
> ""The Court has been stopping every constitutional change, Mrs. Edmonds...""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Kontekst wejściowy (poprzednik):** `[21]` (Isabel Edmonds), `[5]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Isabel Edmonds: ""So that is your position... I see.""*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Isabel Edmonds: ""I hope so.""*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[74]`
Mówca: **Isabel Edmonds**
> ""I didn't come here to be disrespected, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: ""With all due respect, you are reaching the last straw.""*)
  - -> `[64]` (*Player: ""I didn't want to disrespect you, Mrs. Edmonds.""*)
  - -> `[58]` (*Player: ""I did not intend any offense, Mrs. Edmonds. Please accep..."*)

### Węzeł `[75]`
Mówca: **Isabel Edmonds**
> ""That's not very relieving.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Isabel Edmonds: ""Can you explain me one thing. How come you think that th..."*)

### Węzeł `[76]`
Mówca: **Isabel Edmonds**
> ""So that is your position... I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Isabel Edmonds: ""I don't know what to say, Mr. President...""*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "Isabel took another sip from her water and looked at me w..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Nia Morgna: ""Mrs. Edmonds, we are not against you. We want you on our..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "She sighed and looked outside the window for a moment."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Nia Morgna: ""Mr. President!""*)

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
  - -> `[86]` (*Player: ""Why don't you ask the *reformists*? That clause was one ..."*)
  - -> `[71]` (*Player: ""The Court has been stopping every constitutional change,..."*)
  - -> `[56]` (*Player: ""The judiciary should not have legislative powers, Mrs. E..."*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Nia Morgna: ""I thought we wer-""*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Why don't you ask the *reformists*? That clause was one of their main demands too.""]** — Mówca: **Player**
> ""Why don't you ask the *reformists*? That clause was one of their main demands too.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Kontekst wejściowy (poprzednik):** `[5]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[87]`
**[WYBÓR GRACZA: ""That point was a red line for the opposition. We had to include it.""]** — Mówca: **Player**
> ""That point was a red line for the opposition. We had to include it.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false` AND `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Kontekst wejściowy (poprzednik):** `[5]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Isabel Edmonds: ""Interesting. So you do not own it up, after all.""*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: ""That point was a red line for Mr. Ricter. We had to incl..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: ""That point was a red line for the opposition. We had to ..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Isabel Edmonds: ""I see.""*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Isabel Edmonds: ""That's not very relieving.""*)
