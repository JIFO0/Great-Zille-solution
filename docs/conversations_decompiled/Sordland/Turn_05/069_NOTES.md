# Sordland/Turn05/NOTES

- **ID konwersacji:** `69`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/069_NOTES.md`
- **Liczba węzłów dialogowych:** 73
- **Liczba wyborów gracza:** 17

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[41]** Livia Suno
- **[44]** Lileas Graf

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Relations_Lileas_GendermariePromise`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase`
- `BaseGameIsolated.Turn05_Admin_Mayor_Fire`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Relations_Lileas_GendermariePromise`
- `BaseGameIsolated.Turn05_Admin_Mayor_Fire`
- `BaseGameSupport.Journal_Turn05_Scandal_CurtanAskedResign`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 3

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Lileas_GendermariePromise`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[5]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn05_Admin_Mayor_Fire"] = true;`
- Węzeł `[40]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Lileas_GendermariePromise"] = true; Variable["BaseGameSupport.Journa...`
- Węzeł `[66]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn05_Admin_Mayor_Fire"] = true;`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: "“By taking away his mayorship. Let's reach out to Lileas to have him removed.”"]** — Mówca: **Player**
> "“By taking away his mayorship. Let's reach out to Lileas to have him removed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Lucian Galade**
> "“Taking the fight to him is the right approach. Proactive behavior will benefit us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_Admin_Mayor_Fire = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_Admin_Mayor_Fire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[6]`
Mówca: **Lileas Graf**
> "“Hello, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[7]`
Mówca: **Petr Vectern**
> "“Lileas is his superior -- she ought to side with us and remove him from his post. I'll ask Livia to call her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[8]`
Mówca: **Lileas Graf**
> "“Yet I cannot possibly fathom how I'm related to this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[12]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "“I want him fired for his actions, Lileas.”"]** — Mówca: **Player**
> "“I want him fired for his actions, Lileas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“What do you think about removing him from his mayorship?”"]** — Mówca: **Player**
> "“What do you think about removing him from his mayorship?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[17]`
Mówca: **Lileas Graf**
> "“How can I help?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[12]`

### Węzeł `[18]`
Mówca: **Lileas Graf**
> "“It could be accomplished, but it would hurt the trust the mayors have placed in me and the Ministry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[21]`

### Węzeł `[19]`
Mówca: **Lileas Graf**
> "“I'm against administrative intervention in local governments, especially in a city like Anrica. We'll lose trust.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Lileas Graf**
> "“I appreciate that you hold me in such high esteem, but I'm reluctant about this move.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "“We can repair that trust in the near future. But right now we need this man weakened.”"]** — Mówca: **Player**
> "“We can repair that trust in the near future. But right now we need this man weakened.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Lileas Graf**
> ""At the expense of yet more pressure on myself and my staff.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "“Your personal support and weight is needed. This needs to look as if it came from you.”"]** — Mówca: **Player**
> "“Your personal support and weight is needed. This needs to look as if it came from you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[24]`
Mówca: **Narrator**
> "Lileas hung up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[25]`
Mówca: **Petr Vectern**
> "“She won't upset the mayors at all costs, even one who insulted the First Lady. So much for female solidarity!”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[26]`
**[WYBÓR GRACZA: "“We'll keep in touch.”"]** — Mówca: **Player**
> "“We'll keep in touch.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Very much appreciated, Lileas.”"]** — Mówca: **Player**
> "“Very much appreciated, Lileas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[28]`
Mówca: **Lileas Graf**
> "“I support you as much as I am able to. I must excuse myself now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[29]`
Mówca: **Lucian Galade**
> "“That was a waste of valuable time. But at least Lileas revealed her ambitions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Maybe it will blow over. You might be right.”"]** — Mówca: **Player**
> "“Maybe it will blow over. You might be right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Lileas Graf**
> "“With time it should. I must excuse myself now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "“I don't see Iosef accepting this.”"]** — Mówca: **Player**
> "“I don't see Iosef accepting this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[33]`
Mówca: **Narrator**
> "Lileas sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“I haven't heard of this before.”"]** — Mówca: **Player**
> "“I haven't heard of this before.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Lileas Graf**
> "“I'm still working on the proposal and legal backing for it. I was going to mention it later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[36]`
Mówca: **Lileas Graf**
> "“Well, he just might have to agree if the President of Sordland tells him to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[37]`
Mówca: **Lileas Graf**
> "“Yet I would gladly support you... if you back my plan to put the Gendarmerie under the Ministry of Interior.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[32]`
  - -> `[70]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“I will support you in the Gendarmerie authority transfer. Now it's your turn.”"]** — Mówca: **Player**
> "“I will support you in the Gendarmerie authority transfer. Now it's your turn.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“I can't make that promise. Iosef would be furious.”"]** — Mówca: **Player**
> "“I can't make that promise. Iosef would be furious.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lileas_GendermariePromise = true; BaseGameSupport.Journal_Turn05_Scandal_CurtanAskedResign = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Lileas_GendermariePromise"] = true;
Variable["BaseGameSupport.Journal_Turn05_Scandal_CurtanAskedResign"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Lileas Graf**
> "“That is unfortunate. In that case there is not much I can do, Mr. President.”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
Mówca: **Lileas Graf**
> "“Excellent. I'll make arrangements to remove the mayor from his post.”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[43]`
**[WYBÓR GRACZA: "“I'm disappointed in the lack of support from you. I expected more.”"]** — Mówca: **Player**
> "“I'm disappointed in the lack of support from you. I expected more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[44]`
Mówca: **Lileas Graf**
> "“Goodbye.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[45]`
Mówca: **Lucian Galade**
> "“Let's hope this arrangement won't backfire on us. It's true that Iosef will object.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lileas_GendermariePromise == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lileas_GendermariePromise == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Lileas_GendermariePromise == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[49]`
Mówca: **Lucian Galade**
> "“In the short term, though, we need to make Leste's removal seem as necessary as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[50]`
Mówca: **Narrator**
> "The Minister of the Interior was on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[51]`
Mówca: **Narrator**
> "Livia left the room to arrange the call. A few minutes later, the phone lit up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[52]`
Mówca: **Livia Suno**
> "“I'll let you know once I have her on the line.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "“Yes please.”"]** — Mówca: **Player**
> "“Yes please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "“That would be appreciated.”"]** — Mówca: **Player**
> "“That would be appreciated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[55]`
Mówca: **Narrator**
> "Petr left the room and came back with Livia. She had on a short dress and dark eyeliner -- clearly she'd been counting on me being away at the festival for longer. Still, her demeanor was nothing but professional."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Livia Suno**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[57]`
Mówca: **Livia Suno**
> "“Mr. Vectern told me what happened. Should I connect you with the Interior Minster directly?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[58]`
Mówca: **Lucian Galade**
> "“Taking the fight to him is the right approach. Proactive behavior will benefit us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Petr Vectern**
> "“Lileas is his superior -- she ought to side with us and remove him from his post. I'll ask Livia to call her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Narrator**
> "A few minutes later, the phone lit up. The Minister of the Interior was on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[61]`
Mówca: **Livia Suno**
> "“I'd be careful, though. I doubt Mrs. Graf will remove Mayor Leste without asking for something in return.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_Admin_Mayor_Fire == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_Admin_Mayor_Fire == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_Admin_Mayor_Fire"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_Admin_Mayor_Fire == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_Admin_Mayor_Fire"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[65]`
**[WYBÓR GRACZA: "“All right, we'll take away his mayorship. Let's reach out to Lileas to have him removed.”"]** — Mówca: **Player**
> "“All right, we'll take away his mayorship. Let's reach out to Lileas to have him removed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_Admin_Mayor_Fire = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_Admin_Mayor_Fire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[67]`
Mówca: **Lileas Graf**
> ""It's just one noisy mayor. Perhaps you have nothing to worry about.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[30]`

### Węzeł `[68]`
Mówca: **Lucian Galade**
> "“I'll prepare our press release.”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[69]`
Mówca: **Lileas Graf**
> "“Let me take a guess. You're calling me about the Curtan Leste situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "“After what you said about my wife? No.”"]** — Mówca: **Player**
> "“After what you said about my wife? No.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[71]`
Mówca: **Lileas Graf**
> "“This isn't even counting my personal feelings about the matter. Mr. Rayne, I chose a political career at the expense of becoming a mother. Your wife did not. Leste was right -- her place is at home, not on that stage.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[72]`
Mówca: **Lucian Galade**
> ""Speak to Lileas, Mr. President. Unless you'd rather take advice from someone in a conical brassiere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[73]`
Mówca: **Narrator**
> "Petr grinned. Lucian looked outraged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
