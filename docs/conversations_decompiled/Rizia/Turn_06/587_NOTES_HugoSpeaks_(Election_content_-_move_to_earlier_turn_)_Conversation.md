# Rizia/Turn 6/NOTES_HugoSpeaks (Election content - move to earlier turn?)/NOTES_HugoSpeaks (Election content - move to earlier turn?) Conversation

- **ID konwersacji:** `587`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/587_NOTES_HugoSpeaks_(Election_content_-_move_to_earlier_turn_)_Conversation.md`
- **Liczba węzłów dialogowych:** 58
- **Liczba wyborów gracza:** 6

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Country_PublicOpinion`
- `RiziaDLC.HouseElections_RNCWinsSeats`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.Policy_ForeignVotingRights`
- `RiziaDLC.Policy_RD_Welfare_FreePress`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 0

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
  - -> `[23]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion >= 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_PublicOpinion >= 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[9]`
Mówca: **Hugo Toras**
> ""Moreover, the elections for the House of Delegates is scheduled towards the end of this year.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_ForeignVotingRights == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_ForeignVotingRights == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_ForeignVotingRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_ForeignVotingRights == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_ForeignVotingRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_FreePress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the information, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[17]`
Mówca: **Hugo Toras**
> ""And quite distressingly, the Rizian People's Party seems to be getting popular among the electorate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RNCWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RNCWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RNCWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RNCWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RNCWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""And it seems to be the Rizian National Coalition is growing stronger with each day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[22]`
Mówca: **Hugo Toras**
> ""If you ask my opinion, it is unlikely there will be much change in the House.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[23]`
Mówca: **Hugo Toras**
> ""The House has recently sent me their report on public opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[24]`
Mówca: **Hugo Toras**
> ""According to it, the population seems to quite content with our administration and the popularity of our Majesty is very high.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_PublicOpinion >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion >= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion >= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_PublicOpinion >= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion > -1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion > -1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] > -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_PublicOpinion > -1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] > -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[34]`
Mówca: **Hugo Toras**
> ""According to it, the population seems to quite content with our administration at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[35]`
Mówca: **Hugo Toras**
> ""According to it, there is not a lot of concerning news. Everything seems to be quite stable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[36]`
Mówca: **Hugo Toras**
> ""It paints a worrying picture. It seems to have decreased quite a bit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[37]`
Mówca: **Hugo Toras**
> ""It paints a very worrying picture. A lot of people are getting increasingly discontent and radicalization seems to be increasing as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[38]`
Mówca: **Hugo Toras**
> ""And the parties have already started their campaigns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[39]`
Mówca: **Hugo Toras**
> ""However, one difference of this election is that a huge number of new voters have been registered - Wehzeks, Qinalis, Derdians and more...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Hugo Toras**
> ""It can potentially result in a surprise result.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[41]`
Mówca: **Hugo Toras**
> ""And with the new laws regarding the press, the turnouts will likely be the largest ever in this election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Hugo Toras**
> ""And the Rizian People's Party is already using these avenues to grow their reach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Narrator**
> "He looked at the notes he was holding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[44]`
Mówca: **Hugo Toras**
> ""However, there's still a long way to go and we'll have to wait and see the results first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[16]`
  - -> `[45]`
  - -> `[46]`
  - -> `[48]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Uncle. Keep following the House and the elections, I'd like to know about every important move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't see how this concerns me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is worrying. I will look into what I can do for our public opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion >= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion >= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[57]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_PublicOpinion >= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] >= 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see. Anything else?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Hugo Toras**
> ""No, that was the extent of my update.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Narrator**
> "He hesitated to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Hugo Toras**
> ""I understand. That was the extent of my update.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[56]`
Mówca: **Hugo Toras**
> ""Of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care if the public hates me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
