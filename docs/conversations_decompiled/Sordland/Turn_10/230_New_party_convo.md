# Sordland/Turn10/New party convo

- **ID konwersacji:** `230`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/230_New_party_convo.md`
- **Liczba węzłów dialogowych:** 140
- **Liczba wyborów gracza:** 27

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[12]** Moderator
- **[16]** Manoly Suheil
- **[22]** Denis Stahler
- **[32]** Frens Ricter
- **[44]** Lileas Graf
- **[50]** Kesaro Kibener
- **[60]** Remus Holstron

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Archetype_DemocraticRayne`
- `BaseGame.Archetype_SollistRayne`
- `BaseGame.EconomicDirection_Nationalization`
- `BaseGame.NewParty_DemocratParty`
- `BaseGame.NewParty_LiberalParty`
- `BaseGame.NewParty_MaroonParty`
- `BaseGame.NewParty_SordishProsperityParty`
- `BaseGame.Turn08_Action_Party_Ultranationalist`
- `BaseGameIsolated.Debate_Enable_FrensRicter`
- `BaseGameIsolated.Debate_Enable_KesaroKibener`
- `BaseGameIsolated.Debate_Enable_ManolySuheil`
- `BaseGameIsolated.Debate_Enable_RemusHolstron`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Death`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[231] Sordland/Turn10/Term plans** (../Turn_10/231_Term_plans.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
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
  - -> `[24]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `231` (*Sordland/Turn10/Term plans*), Węzeł `[1]`

### Węzeł `[3]`
Mówca: **Moderator**
> ""I'd like to begin by giving President Rayne a chance to speak about his decision to form a new party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_DemocratParty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_DemocratParty == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NewParty_DemocratParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NewParty_DemocratParty == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NewParty_DemocratParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_LiberalParty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_LiberalParty == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NewParty_LiberalParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NewParty_LiberalParty == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NewParty_LiberalParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_MaroonParty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_MaroonParty == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NewParty_MaroonParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NewParty_MaroonParty == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NewParty_MaroonParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Moderator**
> ""On to the next question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_SordishProsperityParty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_SordishProsperityParty == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NewParty_SordishProsperityParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NewParty_SordishProsperityParty == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NewParty_SordishProsperityParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_Nationalization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[20]`
**[WYBÓR GRACZA: ""The USP is stuck in the past. I founded a new party to turn Sordland into the modern, competitive nation it is destined to become.""]** — Mówca: **Player**
> ""The USP is stuck in the past. I founded a new party to turn Sordland into the modern, competitive nation it is destined to become.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[21]`
Mówca: **Moderator**
> ""What exactly does the Democrat Party have to offer that the USP did not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[29]`
  - -> `[28]`
  - -> `[20]`

### Węzeł `[22]`
Mówca: **Moderator**
> ""What exactly does the Liberal Party have to offer that the USP did not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[29]`
  - -> `[28]`
  - -> `[20]`

### Węzeł `[23]`
Mówca: **Moderator**
> ""What exactly does the Maroon Party have to offer that the USP did not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[29]`
  - -> `[28]`
  - -> `[20]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: New Party Convo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[25]`
Mówca: **Moderator**
> ""What exactly does the Sordish Prosperity Party have to offer that the USP did not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[29]`
  - -> `[28]`
  - -> `[20]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""My new party is a chance to return Sordland to its Sollist roots. The Colonel of 20 years ago would not recognize what the USP has become today.""]** — Mówca: **Player**
> ""My new party is a chance to return Sordland to its Sollist roots. The Colonel of 20 years ago would not recognize what the USP has become today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""The USP has forgotten who it serves: the Sordish people. With my new party, everyone will have a voice.""]** — Mówca: **Player**
> ""The USP has forgotten who it serves: the Sordish people. With my new party, everyone will have a voice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[28]`
**[WYBÓR GRACZA: ""The USP has forgotten what the 'S' in its name stands for. My new party will put Sordland first.""]** — Mówca: **Player**
> ""The USP has forgotten what the 'S' in its name stands for. My new party will put Sordland first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[29]`
**[WYBÓR GRACZA: ""In a word, money. The USP has had a chokehold on the economy for too long. It's time to give Sordish businesses a chance to thrive.""]** — Mówca: **Player**
> ""In a word, money. The USP has had a chokehold on the economy for too long. It's time to give Sordish businesses a chance to thrive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[30]`
Mówca: **Narrator**
> "The moderator motioned for silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[31]`
Mówca: **Lileas Graf**
> ""Spoken like a true puppet of the Oligarchs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[32]`
Mówca: **Moderator**
> ""What exactly does the People's Party have to offer that the USP did not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[29]`
  - -> `[28]`
  - -> `[20]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
Mówca: **Frens Ricter**
> ""By nationalizing them, you mean? Ridiculous!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[40]`
Mówca: **Lileas Graf**
> ""How can you possibly say that after what you did to him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[68]`

### Węzeł `[41]`
Mówca: **Lileas Graf**
> ""Preposterous. Any follower of Soll would stay true to the party he founded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`
  - -> `[67]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_SollistRayne == true || BaseGame.Turn08_Action_Party_Ultranationalist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_SollistRayne == true || BaseGame.Turn08_Action_Party_Ultranationalist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_SollistRayne"] == true  or  Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_SollistRayne == true || BaseGame.Turn08_Action_Party_Ultranationalist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_SollistRayne"] == true  or  Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_DemocraticRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_DemocraticRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_DemocraticRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_DemocraticRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_DemocraticRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_ComradeRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_KesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Kesaro Kibener**
> ""Any true Sordish patriot would have joined the NFP. You're in this for yourself, Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[60]`
  - -> `[61]`
  - -> `[63]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_RemusHolstron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Remus Holstron**
> ""Your allegiances show where your petty priorities lie. This is not about the rise of the Sordish people but your own individual ego, Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[60]`
  - -> `[61]`
  - -> `[63]`

### Węzeł `[59]`
Mówca: **Lileas Graf**
> ""Ah, so you eliminated the NFP leadership so you could take on its values for yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
**[WYBÓR GRACZA: ""I can be proud of my country without being a bigot.""]** — Mówca: **Player**
> ""I can be proud of my country without being a bigot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[61]`
**[WYBÓR GRACZA: ""The NFP doesn't think big enough. My party will crush all of Sordland's enemies.""]** — Mówca: **Player**
> ""The NFP doesn't think big enough. My party will crush all of Sordland's enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[62]`
**[WYBÓR GRACZA: ""To be honest, I just plain don't like the NFP.""]** — Mówca: **Player**
> ""To be honest, I just plain don't like the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""I'm prepared to ally with the NFP.""]** — Mówca: **Player**
> ""I'm prepared to ally with the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""I liked Soll's ideas. Not the man himself.""]** — Mówca: **Player**
> ""I liked Soll's ideas. Not the man himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[65]`
**[WYBÓR GRACZA: ""Not after the way I was betrayed.""]** — Mówca: **Player**
> ""Not after the way I was betrayed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[66]`
**[WYBÓR GRACZA: ""No. It's time to take his ideas and bring them into our modern age.""]** — Mówca: **Player**
> ""No. It's time to take his ideas and bring them into our modern age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""Honestly, I just couldn't stomach the thought of you as president.""]** — Mówca: **Player**
> ""Honestly, I just couldn't stomach the thought of you as president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[68]`
**[WYBÓR GRACZA: ""Soll betrayed his own ideals. He had to go.""]** — Mówca: **Player**
> ""Soll betrayed his own ideals. He had to go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[75]`
Mówca: **Frens Ricter**
> ""If you really wanted Sordland to have a chance at democracy, you would have endorsed the PFJP after your Congress loss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[80]`
  - -> `[78]`
  - -> `[79]`

### Węzeł `[76]`
Mówca: **Manoly Suheil**
> ""If you really wanted Sordland to have a chance at democracy, you would have endorsed the PFJP after your Congress loss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[80]`
  - -> `[78]`
  - -> `[79]`

### Węzeł `[77]`
Mówca: **Lileas Graf**
> ""Ah, so you eliminated the PFJP leadership so you could take on its values for yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[80]`
  - -> `[78]`

### Węzeł `[78]`
**[WYBÓR GRACZA: ""To be honest, I just plain don't like the PFJP.""]** — Mówca: **Player**
> ""To be honest, I just plain don't like the PFJP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[79]`
**[WYBÓR GRACZA: ""I'm prepared to ally with the PFJP.""]** — Mówca: **Player**
> ""I'm prepared to ally with the PFJP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[80]`
**[WYBÓR GRACZA: ""No, the PFJP is too capitalist for my tastes.""]** — Mówca: **Player**
> ""No, the PFJP is too capitalist for my tastes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""The PFJP is too globalist for me. I want to keep the focus on Sordland.""]** — Mówca: **Player**
> ""The PFJP is too globalist for me. I want to keep the focus on Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[82]`
**[WYBÓR GRACZA: ""The USP cannot admit that Malenyev had the right idea. My party will finally bring communism to Sordland:""]** — Mówca: **Player**
> ""The USP cannot admit that Malenyev had the right idea. My party will finally bring communism to Sordland:""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Denis Stahler**
> ""Any true communist would have joined the Communist Party. You're in this for yourself, President Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[86]`
  - -> `[85]`
  - -> `[84]`

### Węzeł `[84]`
**[WYBÓR GRACZA: ""I'm prepared to ally with the Communist Party.""]** — Mówca: **Player**
> ""I'm prepared to ally with the Communist Party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[85]`
**[WYBÓR GRACZA: ""To be honest, I just plain don't like the Communist Party.""]** — Mówca: **Player**
> ""To be honest, I just plain don't like the Communist Party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Your party is too radical, Stahler. I'm willing to make compromises to achieve our goals.""]** — Mówca: **Player**
> ""Your party is too radical, Stahler. I'm willing to make compromises to achieve our goals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[87]`
**[WYBÓR GRACZA: ""Any true communist would not have gone against Leon Malenyev.""]** — Mówca: **Player**
> ""Any true communist would not have gone against Leon Malenyev.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[88]`
Mówca: **Lileas Graf**
> ""No, you founded it because you could not admit you had lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`
  - -> `[91]`
  - -> `[92]`

### Węzeł `[89]`
**[WYBÓR GRACZA: ""I'm so happy I don't have to put up with another four years of you.""]** — Mówca: **Player**
> ""I'm so happy I don't have to put up with another four years of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[90]`
**[WYBÓR GRACZA: ""I still respect you, Lileas. I had hoped we could settle this like adults.""]** — Mówca: **Player**
> ""I still respect you, Lileas. I had hoped we could settle this like adults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[91]`
**[WYBÓR GRACZA: ""I was happy to lose. It gave me the excuse to do what I'd wanted to for years.""]** — Mówca: **Player**
> ""I was happy to lose. It gave me the excuse to do what I'd wanted to for years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[92]`
**[WYBÓR GRACZA: ""That was the initial reason, yes. But I've had time to develop my platform.""]** — Mówca: **Player**
> ""That was the initial reason, yes. But I've had time to develop my platform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[93]`
Mówca: **Denis Stahler**
> ""That doesn't change the fact that--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[94]`
Mówca: **Denis Stahler**
> ""But if you really pay attention to what Marcia said--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[95]`
Mówca: **Denis Stahler**
> ""Then you've just lost yourself an ally. In fact--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Frens Ricter**
> ""Not now. It's too risky.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[100]`
Mówca: **Manoly Suheil**
> ""Never. Not after what happened to--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[104]`
Mówca: **Frens Ricter**
> ""Fair enough. There's room in the Assembly for both our parties. In fact--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[105]`
Mówca: **Manoly Suheil**
> ""Fair enough. There's room in the Assembly for both our parties. In fact--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Lileas Graf**
> ""At last, something we agree on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_KesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Kesaro Kibener**
> ""Not now. It's too risky.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[114]`
Mówca: **Remus Holstron**
> ""Never. Not after what happened to--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_KesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_RemusHolstron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[121]`
Mówca: **Lileas Graf**
> ""I'm going to enjoy crushing you at the polls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[122]`
Mówca: **Lileas Graf**
> ""You were such a bright boy, President Rayne. What happened?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[123]`
Mówca: **Remus Holstron**
> ""Come over here and say that to my face. I doubt that you have the same will as we do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[124]`
Mówca: **Kesaro Kibener**
> ""Such crude language, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[125]`
Mówca: **Lileas Graf**
> ""A valid sentiment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[126]`
Mówca: **Lileas Graf**
> ""With my help, you could have. You don't have a prayer now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_KesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_RemusHolstron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[133]`
Mówca: **Remus Holstron**
> ""Not if we crush you with our iron will first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[134]`
Mówca: **Kesaro Kibener**
> ""Big ambitions for such a unimaginative party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[135]`
Mówca: **Lileas Graf**
> ""You traitor!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[136]`
Mówca: **Lileas Graf**
> ""Saving one's own party is hardly a 'betrayal' --""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[137]`
Mówca: **Lileas Graf**
> ""All this talk of modernity, yet you--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[138]`
Mówca: **Lileas Graf**
> ""The feeling is mutual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[139]`
Mówca: **Manoly Suheil**
> ""By nationalizing them, you mean? Ridiculous!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
