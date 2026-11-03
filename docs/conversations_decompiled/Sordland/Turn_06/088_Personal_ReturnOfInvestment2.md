# Sordland/Turn06/Personal_ReturnOfInvestment2

- **ID konwersacji:** `88`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Sordland/Turn_06/088_Personal_ReturnOfInvestment2.md`
- **Liczba węzłów dialogowych:** 91
- **Liczba wyborów gracza:** 16

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[35]** Gus Manger
- **[41]** Livia Suno

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall`
- `BaseGame.PersonalWealth`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Turn05_P_FCAnrica`
- `BaseGame.Turn05_P_Underhall`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Enable_Lobbying`
- `BaseGame.Enable_Lobbying_Spend2`
- `BaseGame.Enable_Lobbying_Spend3`
- `BaseGame.PersonalWealth`
- `BaseGameSupport.Journal_Turn06_ReturnOfInvestment2`
- `GameCondition.Turn06_Decision_Lobbying`
- `GameCondition.Turn06_Personal_ReturnOfInvestment2`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 14

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.PersonalWealth`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[4]` (Gus Manger): `Variable["GameCondition.Turn06_Personal_ReturnOfInvestment2"] = true;`
- Węzeł `[16]` (Gus Manger): `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 2;`
- Węzeł `[20]` (Gus Manger): `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 2;`
- Węzeł `[38]` (Gus Manger): `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;`
- Węzeł `[41]` (Gus Manger): `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;`
- Węzeł `[69]` (Gus Manger): `Variable["BaseGameSupport.Journal_Turn06_ReturnOfInvestment2"] = true;`
- Węzeł `[73]` (Gus Manger): `Variable["BaseGame.Enable_Lobbying_Spend3"] = true;`
- Węzeł `[74]` (Gus Manger): `Variable["BaseGame.Enable_Lobbying_Spend2"] = true;`
- *...oraz 6 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Gus Manger)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Gus Manger**
> "“You now officially have a stake in Underhall Construction. Considering their status as the number one construction company in the entire Sordland, I must say that this was an excellent choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[4]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: GameCondition.Turn06_Personal_ReturnOfInvestment2 = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn06_Personal_ReturnOfInvestment2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[5]`
Mówca: **Gus Manger**
> "“A very enjoyable party turned out to be even more enjoyable with actual results out of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[56]`
  - -> `[57]`

### Węzeł `[6]`
Mówca: **Narrator**
> "The phone rang and I picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Livia Suno**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[8]`
Mówca: **Gus Manger**
> "“I am honestly very glad that I have decided to attend to Mr. Vice President's little gathering.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[9]`
Mówca: **Gus Manger**
> "“The Underhall board is very happy to have you on the team, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[10]`
Mówca: **Livia Suno**
> "“Mr. Manger is on the line, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Livia Suno**
> "“He said it is about an investment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "“Let me know if there are any other opportunities.”"]** — Mówca: **Player**
> "“Let me know if there are any other opportunities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“Yes? What is it?”"]** — Mówca: **Player**
> "“Yes? What is it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "“I'm busy. Make it quick.”"]** — Mówca: **Player**
> "“I'm busy. Make it quick.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[15]`
Mówca: **Gus Manger**
> "“As your secretary might've informed you, I am calling about what we discussed at the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[16]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth += 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[17]`
Mówca: **Livia Suno**
> "“Yes, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[18]`
Mówca: **Gus Manger**
> "“Have a good evening, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Narrator**
> "The line dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[20]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth += 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[21]`
Mówca: **Gus Manger**
> "“Especially after you picked Underhall Construction for the new investment project. Our profits are expected to be doubled by next year!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[22]`
Mówca: **Gus Manger**
> "“I am sure you will be delighted to hear that as a matter of fact, I do, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[23]`
Mówca: **Narrator**
> "A momentary crackling noise indicated the line change."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`
  - -> `[35]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Excellent. Connect him through.”"]** — Mówca: **Player**
> "“Excellent. Connect him through.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "“Very well.”"]** — Mówca: **Player**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[26]`
Mówca: **Gus Manger**
> "“Of course. I will be in contact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[27]`
Mówca: **Gus Manger**
> "“Anytime. I will be in contact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[28]`
Mówca: **Livia Suno**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "“Thank you, Mr. Manger. It wouldn't be possible without you.”"]** — Mówca: **Player**
> "“Thank you, Mr. Manger. It wouldn't be possible without you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[30]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[32]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Mr. Manger. To what do I owe the pleasure?”"]** — Mówca: **Player**
> "“Mr. Manger. To what do I owe the pleasure?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“I hope you have some good news.”"]** — Mówca: **Player**
> "“I hope you have some good news.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“It's the President speaking.”"]** — Mówca: **Player**
> "“It's the President speaking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Good evening.”"]** — Mówca: **Player**
> "“Good evening.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“Cut to the chase.”"]** — Mówca: **Player**
> "“Cut to the chase.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[38]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Thanks again.”"]** — Mówca: **Player**
> "“Thanks again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[40]`
Mówca: **Gus Manger**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[41]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[42]`
Mówca: **Gus Manger**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[43]`
Mówca: **Gus Manger**
> "“I am very happy to inform you that your investment to FC Anrica has been accepted by the board members.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[44]`
Mówca: **Gus Manger**
> "“I am very happy to inform you that your investment to buy stocks from Underhall Construction has been accepted by the board members.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[45]`
Mówca: **Gus Manger**
> "“Thank you for your time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[12]`
  - -> `[36]`

### Węzeł `[46]`
Mówca: **Gus Manger**
> "“I am calling about what we discussed at the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[47]`
Mówca: **Gus Manger**
> "“I sent the signed contract and we received some really nice merchandise from the team.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[48]`
Mówca: **Gus Manger**
> "“I am very happy to inform you that your investment to procure the vineyard in Erlory has been accepted by the current resident.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Gus Manger**
> "“I will have the deed and the keys sent to you immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[50]`
Mówca: **Gus Manger**
> "“You are now the owner of a lovely vineyard, a beautiful villa and a sizable land. As I mentioned before, there might be some cost related to refurbishing the wine making equipment however, the facilities are there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[51]`
Mówca: **Gus Manger**
> "“See. I told you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[52]`
Mówca: **Gus Manger**
> "“My pleasure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[53]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Underhall == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Underhall == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_Underhall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[55]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_Underhall == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Underhall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "“Then let's hear the results.”"]** — Mówca: **Player**
> "“Then let's hear the results.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "“You are absolutely right.”"]** — Mówca: **Player**
> "“You are absolutely right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "“You know, Gus, I am glad I went to that party as well!”"]** — Mówca: **Player**
> "“You know, Gus, I am glad I went to that party as well!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[60]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[62]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[63]`
Mówca: **Gus Manger**
> "“Well then...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[64]`
Mówca: **Gus Manger**
> "“Thank you, Mr. President. You are too kind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Gus Manger**
> "“I am looking forward to more successful ventures we might do together in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[66]`
Mówca: **Gus Manger**
> "“Now that we have the President of Sordland by our side, I assure you, this motivation will make us the champions this season!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[67]`
Mówca: **Gus Manger**
> "“Congratulations are in order, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[59]`
  - -> `[58]`

### Węzeł `[68]`
Mówca: **Narrator**
> "The sun was setting over Holsord. I was in my office working on the preliminary details that Ciara sent over about the curriculum."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[69]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_ReturnOfInvestment2 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_ReturnOfInvestment2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[70]`
Mówca: **Gus Manger**
> "“The investment happened at the right time for the end of year profit-share too. We were immediately able to reap the financial benefits of last year which will be sent to your personal account.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[71]`
Mówca: **Gus Manger**
> "“The investment happened at the right time for the end of year profit-share too. We were immediately able to reap the massive financial benefits of last year which will be sent to your personal account.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[72]`
Mówca: **Gus Manger**
> "“The investment happened at the right time for the end of year profit-share too. We were immediately able to reap the massive financial benefits of last year which will be sent to your personal account.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[73]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Enable_Lobbying_Spend3 = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_Lobbying_Spend3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[74]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Enable_Lobbying_Spend2 = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_Lobbying_Spend2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 4)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[77]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth >= 4))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[78]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0 && BaseGame.Reform_Autocrat_Path == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0 && BaseGame.Reform_Autocrat_Path == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0  and  Variable["BaseGame.Reform_Autocrat_Path"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 0 && BaseGame.Reform_Autocrat_Path == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0  and  Variable["BaseGame.Reform_Autocrat_Path"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Enable_Lobbying = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_Lobbying"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: GameCondition.Turn06_Decision_Lobbying = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn06_Decision_Lobbying"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[83]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[85]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth >= 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[86]`
Mówca: **Gus Manger**
> "“With the new investments coming in to the club, the management is already looking to transfer big names to the squad.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[87]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_AnricaTrophy");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_AnricaTrophy");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[88]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_UnderhallTrophy");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_UnderhallTrophy");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[89]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_WineBottle");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_WineBottle");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[90]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
