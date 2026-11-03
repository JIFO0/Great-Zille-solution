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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 10

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[120]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Alliance_PFJP"] = true;`
- Węzeł `[122]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Alliance_NFP"] = true;`
- Węzeł `[125]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Alliance_PFJP"] = true;`
- Węzeł `[126]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Alliance_NFP"] = true;`
- Węzeł `[135]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn07_Results_PFJPAlliance"] = true;`
- Węzeł `[136]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn07_Results_NFPAlliance"] = true;`
- Węzeł `[137]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn07_Results_PFJPAlliance"] = true;`
- Węzeł `[138]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn07_Results_NFPAlliance"] = true;`
- *...oraz 2 innych węzłów ze skryptami.*

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
  - -> `[4]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `117` (*Sordland/Turn07/PlayerHub*), Węzeł `[21]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Ciara stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Some people looked at me questioningly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Ciara Walda**
> ""We have cooperated with them enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[6]`
**[WYBÓR GRACZA: ""Does anybody have any concerns about this decision?""]** — Mówca: **Player**
> ""Does anybody have any concerns about this decision?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
**[WYBÓR GRACZA: ""You need to respect my decision. It is a done deal.""]** — Mówca: **Player**
> ""You need to respect my decision. It is a done deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Frens_Promise_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
> ""Considering our failures of reform has impacted negatively on our popularity, an alliance with the second largest party would be very beneficial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`
  - -> `[84]`

### Węzeł `[12]`
Mówca: **Narrator**
> "Lileas stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
> ""I think we have many shared values with Mr. Ricter. It is manageable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`
  - -> `[84]`

### Węzeł `[14]`
Mówca: **Lileas Graf**
> ""I'm sure everybody does, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[15]`
**[WYBÓR GRACZA: ""I came here to change this party. I need the reformists' help.""]** — Mówca: **Player**
> ""I came here to change this party. I need the reformists' help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
> ""We have shown Sordland that our parties can cooperate and work together to bring change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[17]`
Mówca: **Ciara Walda**
> ""I do, Mr. President. And it's not just a *problem*, I am completely against any idea about an alliance with the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Frens_Promise_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""I disagree. We have much in common with Mr. Ricter. An alliance with them is beneficial for our party.""]** — Mówca: **Player**
> ""I disagree. We have much in common with Mr. Ricter. An alliance with them is beneficial for our party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[22]`
**[WYBÓR GRACZA: ""You need to respect my decision. It is a done deal.""]** — Mówca: **Player**
> ""You need to respect my decision. It is a done deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Frens_Promise_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[26]`
Mówca: **Ciara Walda**
> ""I do, Mr. President. And it's not just a concern, I am completely against any idea about an alliance with the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[27]`
Mówca: **Lileas Graf**
> ""I was against the idea of cooperating with Mr. Ricter from the beginning. I think you are pushing our party too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[28]`
Mówca: **Iosef Lancea**
> ""He is a rising figure in politics. Using his influence would not be bad. Let's not forget that they are still a much smaller party than us. We would be the big partner in this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`
  - -> `[81]`

### Węzeł `[29]`
Mówca: **Iosef Lancea**
> ""I disagree with Mrs. Walda. We have common values with the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[33]`
**[WYBÓR GRACZA: ""I don't want to hear your opinions. It is a done deal.""]** — Mówca: **Player**
> ""I don't want to hear your opinions. It is a done deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Ciara clenched her jaw and stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Ciara Walda**
> ""You are treading on a very dangerous path, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[65]`

### Węzeł `[36]`
Mówca: **Ciara Walda**
> ""I believe you have already achieved your goals with your constitutional amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[37]`
**[WYBÓR GRACZA: ""Do you have a problem with my decision?""]** — Mówca: **Player**
> ""Do you have a problem with my decision?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""You heard me right. Our parties will form an alliance. We will be joining the next elections together.""]** — Mówca: **Player**
> ""You heard me right. Our parties will form an alliance. We will be joining the next elections together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
> ""We must show Sordland that our parties can cooperate and work together to bring real change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[40]`
Mówca: **Narrator**
> "She took hear seat. Paskal cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[41]`
Mówca: **Narrator**
> "Iosef nodded in agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[21]`
  - -> `[15]`

### Węzeł `[42]`
Mówca: **Ciara Walda**
> ""I cannot let this party be corrupted further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[44]`
  - -> `[43]`

### Węzeł `[43]`
**[WYBÓR GRACZA: ""I came here to change this party. I need the opposition's help.""]** — Mówca: **Player**
> ""I came here to change this party. I need the opposition's help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[44]`
**[WYBÓR GRACZA: ""I disagree. We have much in common with Mr. Kibener. An alliance with them is beneficial for our party.""]** — Mówca: **Player**
> ""I disagree. We have much in common with Mr. Kibener. An alliance with them is beneficial for our party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[45]`
Mówca: **Narrator**
> "Lileas clenched her jaw and stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[46]`
Mówca: **Lileas Graf**
> ""Good to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Frens_Promise_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[50]`
Mówca: **Narrator**
> "She did not respond and sat back down, clenching her fists. Iosef cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Frens_Promise_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[54]`
Mówca: **Ciara Walda**
> ""I can't believe this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[55]`
Mówca: **Ciara Walda**
> ""Did they even help you achieve your goals with your constitutional amendments?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[59]`
Mówca: **Narrator**
> "She took hear seat. Iosef cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic >= 7)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic >= 7)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Democratic"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Democratic >= 7))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Democratic"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[63]`
Mówca: **Ciara Walda**
> ""We do not need them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[64]`
Mówca: **Lileas Graf**
> ""I can't believe this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[37]`

### Węzeł `[65]`
**[WYBÓR GRACZA: ""If you have a problem with my decisions, leave the cabinet.""]** — Mówca: **Player**
> ""If you have a problem with my decisions, leave the cabinet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
> ""I think it's a very clever decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[67]`
Mówca: **Ciara Walda**
> ""Are you saying the amount of nationalism in this party is not enough?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[68]`
Mówca: **Lileas Graf**
> ""That you do, Mr. President. But do not forget that this party was founded on the ideals of Sollism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Lileas Graf**
> ""You can try but you cannot force us to change our values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`
  - -> `[72]`

### Węzeł `[70]`
Mówca: **Lileas Graf**
> ""Let's not forget that this party was founded on the ideals of Sollism. We have nothing in common with Anti-Sollist liberals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[71]`
Mówca: **Lileas Graf**
> ""Do we really? I think this is more of a political manoeuvre, Mr. President. We have nothing in common with Anti-Sollist liberals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[72]`
**[WYBÓR GRACZA: ""You have valid concerns, Mrs. Graf. I am open to reconsider my decision.""]** — Mówca: **Player**
> ""You have valid concerns, Mrs. Graf. I am open to reconsider my decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[73]`
**[WYBÓR GRACZA: ""I appreciate your opinion. But the alliance is going to happen.""]** — Mówca: **Player**
> ""I appreciate your opinion. But the alliance is going to happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[74]`
**[WYBÓR GRACZA: ""I have heard enough. The deal is a done deal. Let's move on.""]** — Mówca: **Player**
> ""I have heard enough. The deal is a done deal. Let's move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist >= 7)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist >= 7)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Malenyevist"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Malenyevist >= 7))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[78]`
Mówca: **Ciara Walda**
> ""Do you really have that much in common?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[79]`
**[WYBÓR GRACZA: ""Thank you for your comments. Let's move on.""]** — Mówca: **Player**
> ""Thank you for your comments. Let's move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[80]`
**[WYBÓR GRACZA: ""Iosef is right. Think bigger.""]** — Mówca: **Player**
> ""Iosef is right. Think bigger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""We'll talk about this later, Mrs. Walda. But I must say that I did not appreciate your disrespectful attitude.""]** — Mówca: **Player**
> ""We'll talk about this later, Mrs. Walda. But I must say that I did not appreciate your disrespectful attitude.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[82]`
**[WYBÓR GRACZA: ""Thank you for your comments. Let's move on.""]** — Mówca: **Player**
> ""Thank you for your comments. Let's move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[83]`
**[WYBÓR GRACZA: ""Paskal is right. Think bigger.""]** — Mówca: **Player**
> ""Paskal is right. Think bigger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[84]`
**[WYBÓR GRACZA: ""We'll talk about this later, Mrs. Graf. But I must say that I did not appreciate your disrespectful attitude.""]** — Mówca: **Player**
> ""We'll talk about this later, Mrs. Graf. But I must say that I did not appreciate your disrespectful attitude.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[85]`
Mówca: **Narrator**
> "Nia tried to hold her and get her to sit down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[89]`
  - -> `[88]`

### Węzeł `[86]`
Mówca: **Ciara Walda**
> ""I am sorry, Mr. President. But I had to be honest with you. Please do not make such a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Narrator**
> "She sat down, her eyes locked on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[97]`

### Węzeł `[88]`
**[WYBÓR GRACZA: ""You are right to question this decision. As a matter of fact, I am open to reconsider it.""]** — Mówca: **Player**
> ""You are right to question this decision. As a matter of fact, I am open to reconsider it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[89]`
**[WYBÓR GRACZA: ""I have heard enough. The deal is a done deal. Let's move on.""]** — Mówca: **Player**
> ""I have heard enough. The deal is a done deal. Let's move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[90]`
**[WYBÓR GRACZA: ""I appreciate your opinion. But the alliance is going to happen.""]** — Mówca: **Player**
> ""I appreciate your opinion. But the alliance is going to happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[91]`
**[WYBÓR GRACZA: ""Let's vote on it.""]** — Mówca: **Player**
> ""Let's vote on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[92]`
Mówca: **Lileas Graf**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Narrator**
> "She was taken aback."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[94]`
Mówca: **Narrator**
> "She sat down, her eyes locked on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
**[WYBÓR GRACZA: ""Let's vote on it.""]** — Mówca: **Player**
> ""Let's vote on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[96]`
**[WYBÓR GRACZA: ""Don't worry. I wasn't too sure about this either. We will not proceed with the alliance.""]** — Mówca: **Player**
> ""Don't worry. I wasn't too sure about this either. We will not proceed with the alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[97]`
**[WYBÓR GRACZA: ""Don't worry. I wasn't too sure about this either. We will not proceed with the alliance.""]** — Mówca: **Player**
> ""Don't worry. I wasn't too sure about this either. We will not proceed with the alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[98]`
Mówca: **Petr Vectern**
> ""Good idea. Let's hear the ayes for the alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Narrator**
> "Ciara, Deivid, Paskal, Petr and Nia raised their hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Petr Vectern**
> ""Five for the alliance. And nays?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Narrator**
> "Lileas, Iosef and Gus raised their hands. Lileas looked in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Petr Vectern**
> ""Five to three. I think it's settled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
**[WYBÓR GRACZA: ""You've seen the vote, Lileas. It's decided.""]** — Mówca: **Player**
> ""You've seen the vote, Lileas. It's decided.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[104]`
**[WYBÓR GRACZA: ""Good. We are proceeding with the alliance.""]** — Mówca: **Player**
> ""Good. We are proceeding with the alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[105]`
Mówca: **Petr Vectern**
> ""Good idea. Let's hear the ayes for the alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Narrator**
> "Iosef, Lucian, Lileas and Petr raised their hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""I will also vote nay.""]** — Mówca: **Player**
> ""I will also vote nay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[108]`
Mówca: **Petr Vectern**
> ""Four for the alliance. And nays?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
**[WYBÓR GRACZA: ""I say we do it.""]** — Mówca: **Player**
> ""I say we do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[110]`
Mówca: **Narrator**
> "Ciara, Nia, Paskal and Gus raised their hands. Ciara looked in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Petr Vectern**
> ""Four to four. We need Mr. President to decide this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[107]`

### Węzeł `[112]`
Mówca: **Petr Vectern**
> ""Oh... Okay. Well, then it's settled. We're not proceeding with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
**[WYBÓR GRACZA: ""You've seen the vote, Ciara. It's decided.""]** — Mówca: **Player**
> ""You've seen the vote, Ciara. It's decided.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[114]`
**[WYBÓR GRACZA: ""Okay. We are not proceeding with the alliance.""]** — Mówca: **Player**
> ""Okay. We are not proceeding with the alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[115]`
Mówca: **Narrator**
> "She looked at me questioningly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[116]`
Mówca: **Petr Vectern**
> ""It's settled then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`

### Węzeł `[117]`
**[WYBÓR GRACZA: ""You've seen the vote, Ciara. It's decided.""]** — Mówca: **Player**
> ""You've seen the vote, Ciara. It's decided.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
**[WYBÓR GRACZA: ""Good. We are proceeding with the alliance.""]** — Mówca: **Player**
> ""Good. We are proceeding with the alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[119]`
Mówca: **Narrator**
> "I could see the fury in her eyes but she chose not to respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_PFJP = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Alliance_PFJP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[121]`
Mówca: **Narrator**
> "She did not respond or look me in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_NFP = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Alliance_NFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[123]`
Mówca: **Narrator**
> "There was a brief silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[124]`
Mówca: **Narrator**
> "There was a brief silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_PFJP = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Alliance_PFJP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_NFP = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Alliance_NFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[127]`
Mówca: **Narrator**
> "She looked at me questioningly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Petr Vectern**
> ""Well, then it's settled. We're not proceeding with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[129]`
Mówca: **Narrator**
> "She looked at me questioningly. Petr cut in immediately."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Petr Vectern**
> ""Well, then it's settled. We're not proceeding with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[131]`
Mówca: **Narrator**
> "Petr leaned back in his chair and nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[132]`
Mówca: **Narrator**
> "I tapped twice on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[133]`
Mówca: **Narrator**
> "I tapped twice on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[134]`
Mówca: **Narrator**
> "I tapped twice on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_PFJPAlliance = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_PFJPAlliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_NFPAlliance = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_NFPAlliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_PFJPAlliance = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_PFJPAlliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_NFPAlliance = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_NFPAlliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_NFP = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Alliance_NFP"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_PFJP = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Alliance_PFJP"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
