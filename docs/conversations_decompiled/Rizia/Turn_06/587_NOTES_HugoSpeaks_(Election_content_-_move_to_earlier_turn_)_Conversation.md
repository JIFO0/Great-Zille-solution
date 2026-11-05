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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[16]` | **""Thank you for the information, Your Grace.""** | `[44]` **Hugo Toras**: ""However, there's still a long w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Hugo Toras**: ""Of course, Your Majesty."" |
| `[45]` | **""Thank you, Uncle. Keep following the House and the elections, I'd like to know ab..."** | `[44]` **Hugo Toras**: ""However, there's still a long w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Hugo Toras**: ""Of course, Your Majesty."" |
| `[46]` | **""I don't see how this concerns me.""** | `[44]` **Hugo Toras**: ""However, there's still a long w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Hugo Toras**: ""Well..."" |
| `[47]` | **""It is worrying. I will look into what I can do for our public opinion.""** | `[44]` **Hugo Toras**: ""However, there's still a long w..." | `Variable["RiziaDLC.Country_PublicOpinion"] >= 0` | *Brak zmian stanu* | `[56]` **Hugo Toras**: ""Of course, Your Majesty."" |
| `[51]` | **""I see. Anything else?""** | `[44]` **Hugo Toras**: ""However, there's still a long w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Hugo Toras**: ""No, that was the extent of my u..." |
| `[57]` | **""I don't care if the public hates me.""** | `[44]` **Hugo Toras**: ""However, there's still a long w..." | `Variable["RiziaDLC.Country_PublicOpinion"] >= 0` | *Brak zmian stanu* | `[53]` **Hugo Toras**: ""Well..."" |

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
  - -> `[23]` (*Hugo Toras: ""The House has recently sent me their report on public op..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion >= 5"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_PublicOpinion >= 5)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Hugo Toras: ""According to it, the population seems to quite content w..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_PublicOpinion >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion >= 3"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Hugo Toras: ""And quite distressingly, the Rizian People's Party seems..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RNCWinsSeats == true"*)

### Węzeł `[9]`
Mówca: **Hugo Toras**
> ""Moreover, the elections for the House of Delegates is scheduled towards the end of this year.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Hugo Toras: ""And the parties have already started their campaigns.""*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_ForeignVotingRights == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_ForeignVotingRights == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_ForeignVotingRights == true)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_ForeignVotingRights == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_ForeignVotingRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Hugo Toras: ""However, one difference of this election is that a huge ..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_ForeignVotingRights == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_ForeignVotingRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_FreePress == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Hugo Toras: ""And with the new laws regarding the press, the turnouts ..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_FreePress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "He looked at the notes he was holding."*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the information, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Hugo Toras: ""Of course, Your Majesty.""*)

### Węzeł `[17]`
Mówca: **Hugo Toras**
> ""And quite distressingly, the Rizian People's Party seems to be getting popular among the electorate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Hugo Toras: ""However, there's still a long way to go and we'll have t..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RNCWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RNCWinsSeats == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RNCWinsSeats == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RNCWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RNCWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Hugo Toras: ""And it seems to be the Rizian National Coalition is grow..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RNCWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RNCWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Hugo Toras: ""If you ask my opinion, it is unlikely there will be much..."*)

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""And it seems to be the Rizian National Coalition is growing stronger with each day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Hugo Toras: ""However, there's still a long way to go and we'll have t..."*)

### Węzeł `[22]`
Mówca: **Hugo Toras**
> ""If you ask my opinion, it is unlikely there will be much change in the House.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Hugo Toras: ""However, there's still a long way to go and we'll have t..."*)

### Węzeł `[23]`
Mówca: **Hugo Toras**
> ""The House has recently sent me their report on public opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion >= 5"*)

### Węzeł `[24]`
Mówca: **Hugo Toras**
> ""According to it, the population seems to quite content with our administration and the popularity of our Majesty is very high.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Hugo Toras: ""Moreover, the elections for the House of Delegates is sc..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion >= 3"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_PublicOpinion >= 3)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Hugo Toras: ""According to it, the population seems to quite content w..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_PublicOpinion >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion >= 0"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion >= 0"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_PublicOpinion >= 0)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Hugo Toras: ""According to it, there is not a lot of concerning news. ..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_PublicOpinion >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion > -1"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion > -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion > -1"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_PublicOpinion > -1)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion > -1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] > -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Hugo Toras: ""It paints a worrying picture. It seems to have decreased..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_PublicOpinion > -1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] > -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Hugo Toras: ""It paints a very worrying picture. A lot of people are g..."*)

### Węzeł `[34]`
Mówca: **Hugo Toras**
> ""According to it, the population seems to quite content with our administration at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Hugo Toras: ""Moreover, the elections for the House of Delegates is sc..."*)

### Węzeł `[35]`
Mówca: **Hugo Toras**
> ""According to it, there is not a lot of concerning news. Everything seems to be quite stable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Hugo Toras: ""Moreover, the elections for the House of Delegates is sc..."*)

### Węzeł `[36]`
Mówca: **Hugo Toras**
> ""It paints a worrying picture. It seems to have decreased quite a bit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Hugo Toras: ""Moreover, the elections for the House of Delegates is sc..."*)

### Węzeł `[37]`
Mówca: **Hugo Toras**
> ""It paints a very worrying picture. A lot of people are getting increasingly discontent and radicalization seems to be increasing as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Hugo Toras: ""Moreover, the elections for the House of Delegates is sc..."*)

### Węzeł `[38]`
Mówca: **Hugo Toras**
> ""And the parties have already started their campaigns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_ForeignVotingRights == true"*)

### Węzeł `[39]`
Mówca: **Hugo Toras**
> ""However, one difference of this election is that a huge number of new voters have been registered - Wehzeks, Qinalis, Derdians and more...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Hugo Toras: ""It can potentially result in a surprise result.""*)

### Węzeł `[40]`
Mówca: **Hugo Toras**
> ""It can potentially result in a surprise result.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[41]`
Mówca: **Hugo Toras**
> ""And with the new laws regarding the press, the turnouts will likely be the largest ever in this election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Hugo Toras: ""And the Rizian People's Party is already using these ave..."*)

### Węzeł `[42]`
Mówca: **Hugo Toras**
> ""And the Rizian People's Party is already using these avenues to grow their reach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "He looked at the notes he was holding."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "He looked at the notes he was holding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[44]`
Mówca: **Hugo Toras**
> ""However, there's still a long way to go and we'll have to wait and see the results first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player_Romus: ""I see. Anything else?""*)
  - -> `[16]` (*Player_Romus: ""Thank you for the information, Your Grace.""*)
  - -> `[45]` (*Player_Romus: ""Thank you, Uncle. Keep following the House and the elect..."*)
  - -> `[46]` (*Player_Romus: ""I don't see how this concerns me.""*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion >= 0"*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Uncle. Keep following the House and the elections, I'd like to know about every important move.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Hugo Toras: ""Of course, Your Majesty.""*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't see how this concerns me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Hugo Toras: ""Well...""*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is worrying. I will look into what I can do for our public opinion.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Country_PublicOpinion"] >= 0`
- **Kontekst wejściowy (poprzednik):** `[44]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Hugo Toras: ""Of course, Your Majesty.""*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion >= 0"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_PublicOpinion >= 0)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player_Romus: ""It is worrying. I will look into what I can do for our p..."*)
  - -> `[57]` (*Player_Romus: ""I don't care if the public hates me.""*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_PublicOpinion >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] >= 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see. Anything else?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Hugo Toras: ""No, that was the extent of my update.""*)

### Węzeł `[52]`
Mówca: **Hugo Toras**
> ""No, that was the extent of my update.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "He hesitated to speak."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "He hesitated to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Hugo Toras: ""I understand. That was the extent of my update.""*)

### Węzeł `[55]`
Mówca: **Hugo Toras**
> ""I understand. That was the extent of my update.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[56]`
Mówca: **Hugo Toras**
> ""Of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care if the public hates me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Country_PublicOpinion"] >= 0`
- **Kontekst wejściowy (poprzednik):** `[44]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Hugo Toras: ""Well...""*)
