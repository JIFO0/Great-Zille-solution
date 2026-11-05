# Sordland/Turn07/AnnounceAlliance

- **ID konwersacji:** `118`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/118_AnnounceAlliance.md`
- **Liczba węzłów dialogowych:** 141
- **Liczba wyborów gracza:** 35

---

## 1. Uczestnicy Sceny

- **[2]** Paskal Beniwoll
- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[40]** Ciara Walda
- **[44]** Lileas Graf
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Democratic`
- `BaseGame.Malenyevist`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Relations_Frens_Promise_Alliance`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Reform_Alliance_NFP`
- `BaseGame.Reform_Alliance_PFJP`
- `BaseGameSupport.Journal_Turn07_Results_NFPAlliance`
- `BaseGameSupport.Journal_Turn07_Results_PFJPAlliance`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[117] Sordland/Turn07/PlayerHub** (../Turn_07/117_PlayerHub.md), Węzeł `[21]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **""Does anybody have any concerns about this decision?""** | `[4]` **Narrator**: "Some people looked at me questio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: "Lileas stood up."<br>`[3]` **Narrator**: "Ciara stood up." |
| `[7]` | **""You need to respect my decision. It is a done deal.""** | `[42]` **Ciara Walda**: ""I cannot let this party be corr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Narrator**: "She did not respond and sat back..." |
| `[15]` | **""I came here to change this party. I need the reformists' help.""** | `[41]` **Narrator**: "Iosef nodded in agreement." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Lileas Graf**: ""That you do, Mr. President. But..." |
| `[21]` | **""I disagree. We have much in common with Mr. Ricter. An alliance with them is bene..."** | `[41]` **Narrator**: "Iosef nodded in agreement."<br>`[133]` **Narrator**: "I tapped twice on the table."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Lileas Graf**: ""Let's not forget that this part..."<br>`[71]` **Lileas Graf**: ""Do we really? I think this is m..." |
| `[22]` | **""You need to respect my decision. It is a done deal.""** | `[41]` **Narrator**: "Iosef nodded in agreement." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Lileas Graf**: ""Good to know."" |
| `[33]` | **""I don't want to hear your opinions. It is a done deal.""** | `[35]` **Ciara Walda**: ""You are treading on a very dang..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Lileas Graf**: ""Good to know.""<br>`[54]` **Ciara Walda**: ""I can't believe this."" |
| `[37]` | **""Do you have a problem with my decision?""** | `[64]` **Lileas Graf**: ""I can't believe this."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Lileas Graf**: ""I'm sure everybody does, Mr. Pr..."<br>`[17]` **Ciara Walda**: ""I do, Mr. President. And it's n..." |
| `[38]` | **""You heard me right. Our parties will form an alliance. We will be joining the nex..."** | `[4]` **Narrator**: "Some people looked at me questio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Narrator**: "Lileas clenched her jaw and stoo..."<br>`[34]` **Narrator**: "Ciara clenched her jaw and stood..." |
| `[43]` | **""I came here to change this party. I need the opposition's help.""** | `[42]` **Ciara Walda**: ""I cannot let this party be corr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Ciara Walda**: ""Are you saying the amount of na..." |
| `[44]` | **""I disagree. We have much in common with Mr. Kibener. An alliance with them is ben..."** | `[42]` **Ciara Walda**: ""I cannot let this party be corr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Ciara Walda**: ""Do you really have that much in..."<br>`[67]` **Ciara Walda**: ""Are you saying the amount of na..." |
| `[65]` | **""If you have a problem with my decisions, leave the cabinet.""** | `[35]` **Ciara Walda**: ""You are treading on a very dang..."<br>`[64]` **Lileas Graf**: ""I can't believe this."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Lileas Graf**: ""Good to know.""<br>`[50]` **Narrator**: "She did not respond and sat back..." |
| `[72]` | **""You have valid concerns, Mrs. Graf. I am open to reconsider my decision.""** | `[69]` **Lileas Graf**: ""You can try but you cannot forc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Narrator**: "She was taken aback." |
| `[73]` | **""I appreciate your opinion. But the alliance is going to happen.""** | `[69]` **Lileas Graf**: ""You can try but you cannot forc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Narrator**: "She took hear seat. Paskal cut in." |
| `[74]` | **""I have heard enough. The deal is a done deal. Let's move on.""** | `[69]` **Lileas Graf**: ""You can try but you cannot forc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Narrator**: "She took hear seat. Paskal cut in." |
| `[79]` | **""Thank you for your comments. Let's move on.""** | `[28]` **Iosef Lancea**: ""He is a rising figure in politi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Narrator**: "There was a brief silence." |
| `[80]` | **""Iosef is right. Think bigger.""** | `[28]` **Iosef Lancea**: ""He is a rising figure in politi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Narrator**: "There was a brief silence." |
| `[81]` | **""We'll talk about this later, Mrs. Walda. But I must say that I did not appreciate..."** | `[28]` **Iosef Lancea**: ""He is a rising figure in politi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Narrator**: "There was a brief silence." |
| `[82]` | **""Thank you for your comments. Let's move on.""** | `[11]` **Paskal Beniwoll**: ""Considering our failures of ref..."<br>`[13]` **Paskal Beniwoll**: ""I think we have many shared val..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Narrator**: "There was a brief silence." |
| `[83]` | **""Paskal is right. Think bigger.""** | `[11]` **Paskal Beniwoll**: ""Considering our failures of ref..."<br>`[13]` **Paskal Beniwoll**: ""I think we have many shared val..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Narrator**: "There was a brief silence." |
| `[84]` | **""We'll talk about this later, Mrs. Graf. But I must say that I did not appreciate ..."** | `[11]` **Paskal Beniwoll**: ""Considering our failures of ref..."<br>`[13]` **Paskal Beniwoll**: ""I think we have many shared val..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Narrator**: "There was a brief silence." |
| `[88]` | **""You are right to question this decision. As a matter of fact, I am open to recons..."** | `[85]` **Narrator**: "Nia tried to hold her and get he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Ciara Walda**: ""I am sorry, Mr. President. But ..." |
| `[89]` | **""I have heard enough. The deal is a done deal. Let's move on.""** | `[85]` **Narrator**: "Nia tried to hold her and get he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Ciara Walda**: ""I can't believe this."" |
| `[90]` | **""I appreciate your opinion. But the alliance is going to happen.""** | `[85]` **Narrator**: "Nia tried to hold her and get he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Ciara Walda**: ""I can't believe this."" |
| `[91]` | **""Let's vote on it.""** | `[87]` **Narrator**: "She sat down, her eyes locked on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Petr Vectern**: ""Good idea. Let's hear the ayes ..." |
| `[95]` | **""Let's vote on it.""** | `[94]` **Narrator**: "She sat down, her eyes locked on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Narrator**: "Petr leaned back in his chair an..." |
| `[96]` | **""Don't worry. I wasn't too sure about this either. We will not proceed with the al..."** | `[94]` **Narrator**: "She sat down, her eyes locked on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Narrator**: "She looked at me questioningly. ..." |
| `[97]` | **""Don't worry. I wasn't too sure about this either. We will not proceed with the al..."** | `[87]` **Narrator**: "She sat down, her eyes locked on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Narrator**: "She looked at me questioningly." |
| `[103]` | **""You've seen the vote, Lileas. It's decided.""** | `[102]` **Petr Vectern**: ""Five to three. I think it's set..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Narrator**: "She did not respond or look me i..." |
| `[104]` | **""Good. We are proceeding with the alliance.""** | `[102]` **Petr Vectern**: ""Five to three. I think it's set..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Narrator**: "I tapped twice on the table." |
| `[107]` | **""I will also vote nay.""** | `[111]` **Petr Vectern**: ""Four to four. We need Mr. Presi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Petr Vectern**: ""Oh... Okay. Well, then it's set..." |
| `[109]` | **""I say we do it.""** | `[111]` **Petr Vectern**: ""Four to four. We need Mr. Presi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Petr Vectern**: ""It's settled then."" |
| `[113]` | **""You've seen the vote, Ciara. It's decided.""** | `[112]` **Petr Vectern**: ""Oh... Okay. Well, then it's set..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Narrator**: "She looked at me questioningly." |
| `[114]` | **""Okay. We are not proceeding with the alliance.""** | `[112]` **Petr Vectern**: ""Oh... Okay. Well, then it's set..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Alliance_NFP"] = false;` | `[133]` **Narrator**: "I tapped twice on the table." |
| `[117]` | **""You've seen the vote, Ciara. It's decided.""** | `[116]` **Petr Vectern**: ""It's settled then."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Narrator**: "I could see the fury in her eyes..." |
| `[118]` | **""Good. We are proceeding with the alliance.""** | `[116]` **Petr Vectern**: ""It's settled then."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Alliance_NFP"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn07_Results_NFPAllia...` | `[133]` **Narrator**: "I tapped twice on the table." |

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
  - -> `[4]` (*Narrator: "Some people looked at me questioningly."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""I disagree. We have much in common with Mr. Ricter. An a..."*)

### Węzeł `[3]`
Mówca: **Narrator**
> "Ciara stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Ciara Walda: ""I do, Mr. President. And it's not just a concern, I am c..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Some people looked at me questioningly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: ""You heard me right. Our parties will form an alliance. W..."*)
  - -> `[6]` (*Player: ""Does anybody have any concerns about this decision?""*)

### Węzeł `[5]`
Mówca: **Ciara Walda**
> ""We have cooperated with them enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Ciara Walda: ""I cannot let this party be corrupted further.""*)

### Węzeł `[6]`
**[WYBÓR GRACZA: ""Does anybody have any concerns about this decision?""]** — Mówca: **Player**
> ""Does anybody have any concerns about this decision?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Alliance == true"*)

### Węzeł `[7]`
**[WYBÓR GRACZA: ""You need to respect my decision. It is a done deal.""]** — Mówca: **Player**
> ""You need to respect my decision. It is a done deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "She did not respond and sat back down, clenching her fist..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Alliance == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Frens_Promise_Alliance == true)"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "Lileas stood up."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Frens_Promise_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Ciara stood up."*)

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
> ""Considering our failures of reform has impacted negatively on our popularity, an alliance with the second largest party would be very beneficial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: ""Thank you for your comments. Let's move on.""*)
  - -> `[83]` (*Player: ""Paskal is right. Think bigger.""*)
  - -> `[84]` (*Player: ""We'll talk about this later, Mrs. Graf. But I must say t..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "Lileas stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lileas Graf: ""I'm sure everybody does, Mr. President.""*)

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
> ""I think we have many shared values with Mr. Ricter. It is manageable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: ""Thank you for your comments. Let's move on.""*)
  - -> `[83]` (*Player: ""Paskal is right. Think bigger.""*)
  - -> `[84]` (*Player: ""We'll talk about this later, Mrs. Graf. But I must say t..."*)

### Węzeł `[14]`
Mówca: **Lileas Graf**
> ""I'm sure everybody does, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Lileas Graf: ""I was against the idea of cooperating with Mr. Ricter fr..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""I came here to change this party. I need the reformists' help.""]** — Mówca: **Player**
> ""I came here to change this party. I need the reformists' help.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lileas Graf: ""That you do, Mr. President. But do not forget that this ..."*)

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
> ""We have shown Sordland that our parties can cooperate and work together to bring change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Paskal Beniwoll: ""I think we have many shared values with Mr. Ricter. It i..."*)

### Węzeł `[17]`
Mówca: **Ciara Walda**
> ""I do, Mr. President. And it's not just a *problem*, I am completely against any idea about an alliance with the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Alliance == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Frens_Promise_Alliance == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lileas Graf: ""I'm sure everybody does, Mr. President.""*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Frens_Promise_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Ciara Walda: ""I do, Mr. President. And it's not just a *problem*, I am..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""I disagree. We have much in common with Mr. Ricter. An alliance with them is beneficial for our party.""]** — Mówca: **Player**
> ""I disagree. We have much in common with Mr. Ricter. An alliance with them is beneficial for our party.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator), `[133]` (Narrator), `[134]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic >= 7"*)

### Węzeł `[22]`
**[WYBÓR GRACZA: ""You need to respect my decision. It is a done deal.""]** — Mówca: **Player**
> ""You need to respect my decision. It is a done deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lileas Graf: ""Good to know.""*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Alliance == true"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Frens_Promise_Alliance == true)"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lileas Graf: ""Good to know.""*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Frens_Promise_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Ciara Walda: ""I can't believe this.""*)

### Węzeł `[26]`
Mówca: **Ciara Walda**
> ""I do, Mr. President. And it's not just a concern, I am completely against any idea about an alliance with the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[27]`
Mówca: **Lileas Graf**
> ""I was against the idea of cooperating with Mr. Ricter from the beginning. I think you are pushing our party too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Iosef nodded in agreement."*)

### Węzeł `[28]`
Mówca: **Iosef Lancea**
> ""He is a rising figure in politics. Using his influence would not be bad. Let's not forget that they are still a much smaller party than us. We would be the big partner in this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: ""Thank you for your comments. Let's move on.""*)
  - -> `[80]` (*Player: ""Iosef is right. Think bigger.""*)
  - -> `[81]` (*Player: ""We'll talk about this later, Mrs. Walda. But I must say ..."*)

### Węzeł `[29]`
Mówca: **Iosef Lancea**
> ""I disagree with Mrs. Walda. We have common values with the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Iosef Lancea: ""He is a rising figure in politics. Using his influence w..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Ciara Walda: ""I believe you have already achieved your goals with your..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Ciara Walda: ""Did they even help you achieve your goals with your cons..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: ""I don't want to hear your opinions. It is a done deal.""]** — Mówca: **Player**
> ""I don't want to hear your opinions. It is a done deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Alliance == true"*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Ciara clenched her jaw and stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Ciara Walda: ""You are treading on a very dangerous path, Mr. President.""*)

### Węzeł `[35]`
Mówca: **Ciara Walda**
> ""You are treading on a very dangerous path, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: ""I don't want to hear your opinions. It is a done deal.""*)
  - -> `[65]` (*Player: ""If you have a problem with my decisions, leave the cabin..."*)

### Węzeł `[36]`
Mówca: **Ciara Walda**
> ""I believe you have already achieved your goals with your constitutional amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Ciara Walda: ""We have cooperated with them enough.""*)

### Węzeł `[37]`
**[WYBÓR GRACZA: ""Do you have a problem with my decision?""]** — Mówca: **Player**
> ""Do you have a problem with my decision?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Alliance == true"*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""You heard me right. Our parties will form an alliance. We will be joining the next elections together.""]** — Mówca: **Player**
> ""You heard me right. Our parties will form an alliance. We will be joining the next elections together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Alliance == true"*)

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
> ""We must show Sordland that our parties can cooperate and work together to bring real change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Paskal Beniwoll: ""Considering our failures of reform has impacted negative..."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "She took hear seat. Paskal cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Paskal Beniwoll: ""I think it's a very clever decision.""*)

### Węzeł `[41]`
Mówca: **Narrator**
> "Iosef nodded in agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: ""You need to respect my decision. It is a done deal.""*)
  - -> `[21]` (*Player: ""I disagree. We have much in common with Mr. Ricter. An a..."*)
  - -> `[15]` (*Player: ""I came here to change this party. I need the reformists'..."*)

### Węzeł `[42]`
Mówca: **Ciara Walda**
> ""I cannot let this party be corrupted further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: ""You need to respect my decision. It is a done deal.""*)
  - -> `[44]` (*Player: ""I disagree. We have much in common with Mr. Kibener. An ..."*)
  - -> `[43]` (*Player: ""I came here to change this party. I need the opposition'..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: ""I came here to change this party. I need the opposition's help.""]** — Mówca: **Player**
> ""I came here to change this party. I need the opposition's help.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Ciara Walda: ""Are you saying the amount of nationalism in this party i..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: ""I disagree. We have much in common with Mr. Kibener. An alliance with them is beneficial for our party.""]** — Mówca: **Player**
> ""I disagree. We have much in common with Mr. Kibener. An alliance with them is beneficial for our party.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 7"*)

### Węzeł `[45]`
Mówca: **Narrator**
> "Lileas clenched her jaw and stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Lileas Graf: ""I can't believe this.""*)

### Węzeł `[46]`
Mówca: **Lileas Graf**
> ""Good to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "She took hear seat. Paskal cut in."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Alliance == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Frens_Promise_Alliance == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "Lileas clenched her jaw and stood up."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Frens_Promise_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Ciara clenched her jaw and stood up."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "She did not respond and sat back down, clenching her fists. Iosef cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Iosef Lancea: ""I disagree with Mrs. Walda. We have common values with t..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Alliance == true"*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Frens_Promise_Alliance == true)"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lileas Graf: ""Good to know.""*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Frens_Promise_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "She did not respond and sat back down, clenching her fist..."*)

### Węzeł `[54]`
Mówca: **Ciara Walda**
> ""I can't believe this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "She took hear seat. Iosef cut in."*)

### Węzeł `[55]`
Mówca: **Ciara Walda**
> ""Did they even help you achieve your goals with your constitutional amendments?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Ciara Walda: ""We do not need them.""*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Paskal Beniwoll: ""We have shown Sordland that our parties can cooperate an..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Paskal Beniwoll: ""We must show Sordland that our parties can cooperate and..."*)

### Węzeł `[59]`
Mówca: **Narrator**
> "She took hear seat. Iosef cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Iosef Lancea: ""I disagree with Mrs. Walda. We have common values with t..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic >= 7"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Democratic >= 7)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic >= 7`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Democratic"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lileas Graf: ""Let's not forget that this party was founded on the idea..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Democratic >= 7)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Democratic"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lileas Graf: ""Do we really? I think this is more of a political manoeu..."*)

### Węzeł `[63]`
Mówca: **Ciara Walda**
> ""We do not need them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Ciara Walda: ""I cannot let this party be corrupted further.""*)

### Węzeł `[64]`
Mówca: **Lileas Graf**
> ""I can't believe this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: ""If you have a problem with my decisions, leave the cabin..."*)
  - -> `[37]` (*Player: ""Do you have a problem with my decision?""*)

### Węzeł `[65]`
**[WYBÓR GRACZA: ""If you have a problem with my decisions, leave the cabinet.""]** — Mówca: **Player**
> ""If you have a problem with my decisions, leave the cabinet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Ciara Walda), `[64]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Alliance == true"*)

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
> ""I think it's a very clever decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[67]`
Mówca: **Ciara Walda**
> ""Are you saying the amount of nationalism in this party is not enough?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "Nia tried to hold her and get her to sit down."*)

### Węzeł `[68]`
Mówca: **Lileas Graf**
> ""That you do, Mr. President. But do not forget that this party was founded on the ideals of Sollism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lileas Graf: ""You can try but you cannot force us to change our values.""*)

### Węzeł `[69]`
Mówca: **Lileas Graf**
> ""You can try but you cannot force us to change our values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: ""I appreciate your opinion. But the alliance is going to ..."*)
  - -> `[74]` (*Player: ""I have heard enough. The deal is a done deal. Let's move..."*)
  - -> `[72]` (*Player: ""You have valid concerns, Mrs. Graf. I am open to reconsi..."*)

### Węzeł `[70]`
Mówca: **Lileas Graf**
> ""Let's not forget that this party was founded on the ideals of Sollism. We have nothing in common with Anti-Sollist liberals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lileas Graf: ""You can try but you cannot force us to change our values.""*)

### Węzeł `[71]`
Mówca: **Lileas Graf**
> ""Do we really? I think this is more of a political manoeuvre, Mr. President. We have nothing in common with Anti-Sollist liberals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lileas Graf: ""You can try but you cannot force us to change our values.""*)

### Węzeł `[72]`
**[WYBÓR GRACZA: ""You have valid concerns, Mrs. Graf. I am open to reconsider my decision.""]** — Mówca: **Player**
> ""You have valid concerns, Mrs. Graf. I am open to reconsider my decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "She was taken aback."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: ""I appreciate your opinion. But the alliance is going to happen.""]** — Mówca: **Player**
> ""I appreciate your opinion. But the alliance is going to happen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "She took hear seat. Paskal cut in."*)

### Węzeł `[74]`
**[WYBÓR GRACZA: ""I have heard enough. The deal is a done deal. Let's move on.""]** — Mówca: **Player**
> ""I have heard enough. The deal is a done deal. Let's move on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "She took hear seat. Paskal cut in."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 7"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Malenyevist >= 7)"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist >= 7`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Malenyevist"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Ciara Walda: ""Do you really have that much in common?""*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Malenyevist >= 7)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Ciara Walda: ""Are you saying the amount of nationalism in this party i..."*)

### Węzeł `[78]`
Mówca: **Ciara Walda**
> ""Do you really have that much in common?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "Nia tried to hold her and get her to sit down."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: ""Thank you for your comments. Let's move on.""]** — Mówca: **Player**
> ""Thank you for your comments. Let's move on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "There was a brief silence."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: ""Iosef is right. Think bigger.""]** — Mówca: **Player**
> ""Iosef is right. Think bigger.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "There was a brief silence."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""We'll talk about this later, Mrs. Walda. But I must say that I did not appreciate your disrespectful attitude.""]** — Mówca: **Player**
> ""We'll talk about this later, Mrs. Walda. But I must say that I did not appreciate your disrespectful attitude.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "There was a brief silence."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: ""Thank you for your comments. Let's move on.""]** — Mówca: **Player**
> ""Thank you for your comments. Let's move on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Paskal Beniwoll), `[13]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "There was a brief silence."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: ""Paskal is right. Think bigger.""]** — Mówca: **Player**
> ""Paskal is right. Think bigger.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Paskal Beniwoll), `[13]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "There was a brief silence."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: ""We'll talk about this later, Mrs. Graf. But I must say that I did not appreciate your disrespectful attitude.""]** — Mówca: **Player**
> ""We'll talk about this later, Mrs. Graf. But I must say that I did not appreciate your disrespectful attitude.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Paskal Beniwoll), `[13]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "There was a brief silence."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "Nia tried to hold her and get her to sit down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: ""I appreciate your opinion. But the alliance is going to ..."*)
  - -> `[89]` (*Player: ""I have heard enough. The deal is a done deal. Let's move..."*)
  - -> `[88]` (*Player: ""You are right to question this decision. As a matter of ..."*)

### Węzeł `[86]`
Mówca: **Ciara Walda**
> ""I am sorry, Mr. President. But I had to be honest with you. Please do not make such a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "She sat down, her eyes locked on me."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "She sat down, her eyes locked on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: ""Let's vote on it.""*)
  - -> `[97]` (*Player: ""Don't worry. I wasn't too sure about this either. We wil..."*)

### Węzeł `[88]`
**[WYBÓR GRACZA: ""You are right to question this decision. As a matter of fact, I am open to reconsider it.""]** — Mówca: **Player**
> ""You are right to question this decision. As a matter of fact, I am open to reconsider it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Ciara Walda: ""I am sorry, Mr. President. But I had to be honest with y..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA: ""I have heard enough. The deal is a done deal. Let's move on.""]** — Mówca: **Player**
> ""I have heard enough. The deal is a done deal. Let's move on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Ciara Walda: ""I can't believe this.""*)

### Węzeł `[90]`
**[WYBÓR GRACZA: ""I appreciate your opinion. But the alliance is going to happen.""]** — Mówca: **Player**
> ""I appreciate your opinion. But the alliance is going to happen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Ciara Walda: ""I can't believe this.""*)

### Węzeł `[91]`
**[WYBÓR GRACZA: ""Let's vote on it.""]** — Mówca: **Player**
> ""Let's vote on it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Petr Vectern: ""Good idea. Let's hear the ayes for the alliance.""*)

### Węzeł `[92]`
Mówca: **Lileas Graf**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "She sat down, her eyes locked on me."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "She was taken aback."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lileas Graf: ""I see.""*)

### Węzeł `[94]`
Mówca: **Narrator**
> "She sat down, her eyes locked on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: ""Let's vote on it.""*)
  - -> `[96]` (*Player: ""Don't worry. I wasn't too sure about this either. We wil..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA: ""Let's vote on it.""]** — Mówca: **Player**
> ""Let's vote on it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "Petr leaned back in his chair and nodded."*)

### Węzeł `[96]`
**[WYBÓR GRACZA: ""Don't worry. I wasn't too sure about this either. We will not proceed with the alliance.""]** — Mówca: **Player**
> ""Don't worry. I wasn't too sure about this either. We will not proceed with the alliance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "She looked at me questioningly. Petr cut in immediately."*)

### Węzeł `[97]`
**[WYBÓR GRACZA: ""Don't worry. I wasn't too sure about this either. We will not proceed with the alliance.""]** — Mówca: **Player**
> ""Don't worry. I wasn't too sure about this either. We will not proceed with the alliance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "She looked at me questioningly."*)

### Węzeł `[98]`
Mówca: **Petr Vectern**
> ""Good idea. Let's hear the ayes for the alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "Ciara, Deivid, Paskal, Petr and Nia raised their hands."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "Ciara, Deivid, Paskal, Petr and Nia raised their hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Petr Vectern: ""Five for the alliance. And nays?""*)

### Węzeł `[100]`
Mówca: **Petr Vectern**
> ""Five for the alliance. And nays?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Lileas, Iosef and Gus raised their hands. Lileas looked i..."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "Lileas, Iosef and Gus raised their hands. Lileas looked in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Petr Vectern: ""Five to three. I think it's settled.""*)

### Węzeł `[102]`
Mówca: **Petr Vectern**
> ""Five to three. I think it's settled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player: ""You've seen the vote, Lileas. It's decided.""*)
  - -> `[104]` (*Player: ""Good. We are proceeding with the alliance.""*)

### Węzeł `[103]`
**[WYBÓR GRACZA: ""You've seen the vote, Lileas. It's decided.""]** — Mówca: **Player**
> ""You've seen the vote, Lileas. It's decided.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "She did not respond or look me in the eye."*)

### Węzeł `[104]`
**[WYBÓR GRACZA: ""Good. We are proceeding with the alliance.""]** — Mówca: **Player**
> ""Good. We are proceeding with the alliance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "I tapped twice on the table."*)

### Węzeł `[105]`
Mówca: **Petr Vectern**
> ""Good idea. Let's hear the ayes for the alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "Iosef, Lucian, Lileas and Petr raised their hands."*)

### Węzeł `[106]`
Mówca: **Narrator**
> "Iosef, Lucian, Lileas and Petr raised their hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Petr Vectern: ""Four for the alliance. And nays?""*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""I will also vote nay.""]** — Mówca: **Player**
> ""I will also vote nay.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Petr Vectern: ""Oh... Okay. Well, then it's settled. We're not proceedin..."*)

### Węzeł `[108]`
Mówca: **Petr Vectern**
> ""Four for the alliance. And nays?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "Ciara, Nia, Paskal and Gus raised their hands. Ciara look..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA: ""I say we do it.""]** — Mówca: **Player**
> ""I say we do it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Petr Vectern: ""It's settled then.""*)

### Węzeł `[110]`
Mówca: **Narrator**
> "Ciara, Nia, Paskal and Gus raised their hands. Ciara looked in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Petr Vectern: ""Four to four. We need Mr. President to decide this.""*)

### Węzeł `[111]`
Mówca: **Petr Vectern**
> ""Four to four. We need Mr. President to decide this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: ""I say we do it.""*)
  - -> `[107]` (*Player: ""I will also vote nay.""*)

### Węzeł `[112]`
Mówca: **Petr Vectern**
> ""Oh... Okay. Well, then it's settled. We're not proceeding with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player: ""You've seen the vote, Ciara. It's decided.""*)
  - -> `[114]` (*Player: ""Okay. We are not proceeding with the alliance.""*)

### Węzeł `[113]`
**[WYBÓR GRACZA: ""You've seen the vote, Ciara. It's decided.""]** — Mówca: **Player**
> ""You've seen the vote, Ciara. It's decided.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "She looked at me questioningly."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: ""Okay. We are not proceeding with the alliance.""]** — Mówca: **Player**
> ""Okay. We are not proceeding with the alliance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP = false"*)

### Węzeł `[115]`
Mówca: **Narrator**
> "She looked at me questioningly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP = false"*)

### Węzeł `[116]`
Mówca: **Petr Vectern**
> ""It's settled then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: ""You've seen the vote, Ciara. It's decided.""*)
  - -> `[118]` (*Player: ""Good. We are proceeding with the alliance.""*)

### Węzeł `[117]`
**[WYBÓR GRACZA: ""You've seen the vote, Ciara. It's decided.""]** — Mówca: **Player**
> ""You've seen the vote, Ciara. It's decided.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "I could see the fury in her eyes but she chose not to res..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: ""Good. We are proceeding with the alliance.""]** — Mówca: **Player**
> ""Good. We are proceeding with the alliance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP = true"*)

### Węzeł `[119]`
Mówca: **Narrator**
> "I could see the fury in her eyes but she chose not to respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP = true"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Alliance_PFJP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[121]`
Mówca: **Narrator**
> "She did not respond or look me in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "I tapped twice on the table."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_NFP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Alliance_NFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_NFPAlliance = true"*)

### Węzeł `[123]`
Mówca: **Narrator**
> "There was a brief silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_NFPAlliance = true"*)

### Węzeł `[124]`
Mówca: **Narrator**
> "There was a brief silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_PFJPAlliance = true"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Alliance_PFJP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_NFP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Alliance_NFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[127]`
Mówca: **Narrator**
> "She looked at me questioningly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Petr Vectern: ""Well, then it's settled. We're not proceeding with it.""*)

### Węzeł `[128]`
Mówca: **Petr Vectern**
> ""Well, then it's settled. We're not proceeding with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP = false"*)

### Węzeł `[129]`
Mówca: **Narrator**
> "She looked at me questioningly. Petr cut in immediately."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Petr Vectern: ""Well, then it's settled. We're not proceeding with it.""*)

### Węzeł `[130]`
Mówca: **Petr Vectern**
> ""Well, then it's settled. We're not proceeding with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "I tapped twice on the table."*)

### Węzeł `[131]`
Mówca: **Narrator**
> "Petr leaned back in his chair and nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Petr Vectern: ""Good idea. Let's hear the ayes for the alliance.""*)

### Węzeł `[132]`
Mówca: **Narrator**
> "I tapped twice on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_PFJPAlliance = true"*)

### Węzeł `[133]`
Mówca: **Narrator**
> "I tapped twice on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[134]`
Mówca: **Narrator**
> "I tapped twice on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP = false"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_PFJPAlliance = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_PFJPAlliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP = true"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_NFPAlliance = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_NFPAlliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP = true"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_PFJPAlliance = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_PFJPAlliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP = true"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_NFPAlliance = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_NFPAlliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "I tapped twice on the table."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_NFP = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Alliance_NFP"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "I tapped twice on the table."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Alliance_PFJP"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
