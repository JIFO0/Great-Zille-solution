# Sordland/Turn03/A_LateBriefing

- **ID konwersacji:** `35`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/035_A_LateBriefing.md`
- **Liczba węzłów dialogowych:** 71
- **Liczba wyborów gracza:** 13

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Prologue_Speech_Democracy_Liberal`
- `GameCondition.Turn03_LateBrief_DictatorBranch`
- `GameCondition.Turn03_LateBrief_ReformistBranch`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Reform_Autocrat_Intention`
- `BaseGame.Reform_Dictator_Intention`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Reformist_Intention`
- `BaseGame.Reform_Reformist_Path`
- `BaseGameSupport.Journal_Turn03_LateReform_Dictator`
- `BaseGameSupport.Journal_Turn03_LateReform_Reformist`
- `GameCondition.Turn03_A_LateBriefing`
- `GameCondition.Turn03_LateBrief_DictatorBranch`
- `GameCondition.Turn03_LateBrief_ReformistBranch`

### Skoki między-konwersacyjne:
- Węzeł `[6]` -> **[36] Sordland/Turn03/LateDictatorSection** (../Turn_03/036_LateDictatorSection.md), Węzeł `[1]`
- Węzeł `[59]` -> **[37] Sordland/Turn03/LateReformistSection** (../Turn_03/037_LateReformistSection.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 7

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[3]` (Lucian Galade): `Variable["GameCondition.Turn03_A_LateBriefing"] = true;`
- Węzeł `[41]` (Lucian Galade): `Variable["BaseGame.Reform_Dictator_Path"] = true; Variable["BaseGame.Reform_Dictator_Intention"] ...`
- Węzeł `[49]` (Lucian Galade): `Variable["BaseGame.Reform_Reformist_Path"] = true; Variable["BaseGame.Reform_Reformist_Intention"...`
- Węzeł `[60]` (Lucian Galade): `Variable["BaseGame.Reform_Autocrat_Intention"] = false;`
- Węzeł `[62]` (Lucian Galade): `Variable["GameCondition.Turn03_LateBrief_ReformistBranch"] = true; Variable["BaseGameSupport.Jour...`
- Węzeł `[63]` (Lucian Galade): `Variable["GameCondition.Turn03_LateBrief_DictatorBranch"] = true; Variable["BaseGameSupport.Journ...`
- Węzeł `[70]` (Lucian Galade): `End();`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_A_LateBriefing = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_A_LateBriefing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The reform committee had intensified work after the negotiations with the Old Guard broke down. Options regarding the new Constitution were already laid out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[5]`
Mówca: **Narrator**
> "A few minutes later, Lucian and Petr arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[6]`
Mówca: **Lucian Galade**
> ""There are some people in USP who would support a new Constitution with more executive powers. Getting the support of the nationalists is our best bet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `36` (*Sordland/Turn03/LateDictatorSection*), Węzeł `[1]`

### Węzeł `[7]`
Mówca: **Lucian Galade**
> ""Now we have a better picture of your intentions, sir. I will start reaching out to my contacts to make a draft that works for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Petr Vectern**
> ""I'll present your input to the committee. In a few months, you would have the draft on your desk to make the final changes yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Lucian Galade**
> ""I think this was yet another fruitful meeting, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`
  - -> `[26]`
  - -> `[27]`

### Węzeł `[10]`
Mówca: **Lucian Galade**
> ""But now we have a better picture of your intentions, sir. I will start reaching out to my contacts to make a draft that works for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Petr Vectern**
> ""Well, regardless of what you decide, we will need to work together with all the cabinet to push this agenda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[12]`
Mówca: **Lucian Galade**
> ""I'll present your input to the USP leaders and the National Front. In a few months, you would have the draft on your desk to make the final changes yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Lucian Galade**
> ""I think this was yet another fruitful meeting, sir. I trust your judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`
  - -> `[16]`
  - -> `[17]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Your service is appreciated.""]** — Mówca: **Player**
> ""Your service is appreciated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[15]`
**[WYBÓR GRACZA: ""If we do this, I promise, you will be kings.""]** — Mówca: **Player**
> ""If we do this, I promise, you will be kings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[16]`
**[WYBÓR GRACZA: ""Together we will make Sordland great.""]** — Mówca: **Player**
> ""Together we will make Sordland great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[17]`
**[WYBÓR GRACZA: ""Thanks for the meeting, gentlemen.""]** — Mówca: **Player**
> ""Thanks for the meeting, gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Lucian Galade**
> ""Thank you for your time, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[19]`
Mówca: **Petr Vectern**
> ""Yes we will!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[20]`
Mówca: **Lucian Galade**
> ""Thank you for the kind words, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Petr Vectern**
> ""You can count on us, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[22]`
Mówca: **Lucian Galade**
> ""I'm sure you will lead us to greatness, sir. Thanks for your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[23]`
Mówca: **Petr Vectern**
> ""Thank you, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""Your service is appreciated.""]** — Mówca: **Player**
> ""Your service is appreciated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""If we do this, we will be remembered as heroes.""]** — Mówca: **Player**
> ""If we do this, we will be remembered as heroes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""Together we will democratize Sordland.""]** — Mówca: **Player**
> ""Together we will democratize Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""Thanks for the meeting, everybody.""]** — Mówca: **Player**
> ""Thanks for the meeting, everybody.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[28]`
Mówca: **Lucian Galade**
> ""Thank you for the kind words, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
Mówca: **Petr Vectern**
> ""Thank you, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[30]`
Mówca: **Lucian Galade**
> ""Thank you for your time, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[31]`
Mówca: **Petr Vectern**
> ""You can count on us, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[32]`
Mówca: **Petr Vectern**
> ""That would be really great!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[34]`
Mówca: **Lucian Galade**
> ""Yes, sir. Thank you for your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Petr Vectern**
> ""Ours too, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[36]`
Mówca: **Lucian Galade**
> ""Since we have arrived at the same page with Ms. Morgna again I will reach out to her to for guidance on the draft constitution work. She has principles and wouldn't go against her own code out of previous disagreements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Lucian Galade**
> ""Anyway, I think this is where we'll call it, sir. Have a good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[38]`
Mówca: **Lucian Galade**
> ""I think this is where we'll call it, sir. Have a good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Narrator**
*(Węzeł logiki narracyjnej: Narrator: "...")*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[40]`
Mówca: **Narrator**
*(Węzeł logiki narracyjnej: Narrator: "...")*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[41]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path = true;
BaseGame.Reform_Dictator_Intention = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Dictator_Path"] = true;
Variable["BaseGame.Reform_Dictator_Intention"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[42]`
Mówca: **Lucian Galade**
> ""Let's not act rash. They have already begun mobilising support against our reform attempts but if we go down the route of removing the Court vote on legislation, it must be thoroughly considered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`
  - -> `[53]`

### Węzeł `[43]`
Mówca: **Petr Vectern**
> ""After what they pulled off I say let's screw them over. We can go all the way with the reforms and shatter the power of the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Petr Vectern**
> ""The people chose us to make real change and to do it, we need to gain as much constitutional power to remove the obstructionists from power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[45]`
**[WYBÓR GRACZA: ""The Vice President has a point. It's us versus them now.""]** — Mówca: **Player**
> ""The Vice President has a point. It's us versus them now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[46]`
**[WYBÓR GRACZA: ""Let's consider all of our options carefully.""]** — Mówca: **Player**
> ""Let's consider all of our options carefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[47]`
**[WYBÓR GRACZA: ""The future lies in a true reform of the constitution. The people elected us for that, let us embrace our purpose.""]** — Mówca: **Player**
> ""The future lies in a true reform of the constitution. The people elected us for that, let us embrace our purpose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Petr Vectern**
> ""Why don't we take more power away from them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[49]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path = true;
BaseGame.Reform_Reformist_Intention = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Reformist_Path"] = true;
Variable["BaseGame.Reform_Reformist_Intention"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[50]`
Mówca: **Petr Vectern**
> ""True, sorry I got a little hotheaded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[51]`
Mówca: **Lucian Galade**
> ""It was always. But how do we proceed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[52]`
Mówca: **Petr Vectern**
> ""The lines are drawn sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[53]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Speech_Democracy_Liberal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Speech_Democracy_Liberal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[55]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Speech_Democracy_Liberal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[56]`
**[WYBÓR GRACZA: ""Let's consolidate our constitutional power and remove the Old Guard equation.""]** — Mówca: **Player**
> ""Let's consolidate our constitutional power and remove the Old Guard equation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[57]`
**[WYBÓR GRACZA: ""We should not be blinded by hatred of foes. Our true purpose will be real reform for the future of this nation.""]** — Mówca: **Player**
> ""We should not be blinded by hatred of foes. Our true purpose will be real reform for the future of this nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[58]`
Mówca: **Lucian Galade**
> ""The reform committee has presented two options. It's either we take more power to ourselves to beat the Old Guard or we opt for a true reformist agenda to democratise Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[67]`

### Węzeł `[59]`
Mówca: **Petr Vectern**
> ""Very well if that is your decision. We will need to engage further with the progressive wing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `37` (*Sordland/Turn03/LateReformistSection*), Węzeł `[1]`

### Węzeł `[60]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Autocrat_Intention"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[61]`
Mówca: **Petr Vectern**
> ""I will fully support you, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[62]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_LateBrief_ReformistBranch = true; BaseGameSupport.Journal_Turn03_LateReform_Reformist = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_LateBrief_ReformistBranch"] = true;
Variable["BaseGameSupport.Journal_Turn03_LateReform_Reformist"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[63]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_LateBrief_DictatorBranch = true; BaseGameSupport.Journal_Turn03_LateReform_Dictator = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_LateBrief_DictatorBranch"] = true;
Variable["BaseGameSupport.Journal_Turn03_LateReform_Dictator"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[64]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_LateBrief_ReformistBranch == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_LateBrief_ReformistBranch == false)*
- **Warunek (`conditionsString`):** `Variable["GameCondition.Turn03_LateBrief_ReformistBranch"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[66]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(GameCondition.Turn03_LateBrief_ReformistBranch == false))*
- **Warunek (`conditionsString`):** `(Variable["GameCondition.Turn03_LateBrief_ReformistBranch"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[67]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_LateBrief_DictatorBranch == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_LateBrief_DictatorBranch == false)*
- **Warunek (`conditionsString`):** `Variable["GameCondition.Turn03_LateBrief_DictatorBranch"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[69]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(GameCondition.Turn03_LateBrief_DictatorBranch == false))*
- **Warunek (`conditionsString`):** `(Variable["GameCondition.Turn03_LateBrief_DictatorBranch"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[70]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
