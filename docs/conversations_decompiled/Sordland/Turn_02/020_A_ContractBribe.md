# Sordland/Turn02/A_ContractBribe

- **ID konwersacji:** `20`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Sordland/Turn_02/020_A_ContractBribe.md`
- **Liczba węzłów dialogowych:** 269
- **Liczba wyborów gracza:** 65

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[19]** Walter Tusk
- **[41]** Livia Suno

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn01_InfrastructureProject_Invest`
- `BaseGame.Decision_Turn01_PersonalInvestment_DontSpend`
- `BaseGame.Relations_Walter_Promise_BailBusiness`
- `BaseGame.Relations_Walter_Promise_Company`
- `BaseGame.Turn01_Admin_Meeting`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn02_FPnT_Consulate_Condemn`
- `BaseGameIsolated.Turn01_A_ContractBribe_Smoked`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.PersonalWealth`
- `BaseGame.Relations_Walter_Promise_BailBusiness`
- `BaseGame.Relations_Walter_Promise_Company`
- `BaseGameIsolated.Turn01_A_ContractBribe_Smoked`
- `BaseGameSupport.CountryReport_Turn02_Pales_RaisesRiziaCaution`
- `BaseGameSupport.Journal_Turn02_AcceptedTuskBailBribe`
- `BaseGameSupport.Journal_Turn02_AcceptedTuskCompanyBribe`
- `BaseGameSupport.Journal_Turn02_RejectedTuskBailBribe`
- `BaseGameSupport.Journal_Turn02_RejectedTuskCompanyBribe`
- `BaseGameSupport.News_Turn02_HP_GasomEngineerSalaries`
- `BaseGameSupport.News_Turn02_HP_KibenerSuggestsPower`
- `BaseGameSupport.News_Turn02_LT_LUSNarbelStatement`
- `BaseGameSupport.News_Turn02_LT_ReformDemands`
- `BaseGameSupport.News_Turn02_R_BludishLynched`
- `BaseGameSupport.News_Turn02_R_WorkersPartyMarch`
- `BaseGameSupport.Report_Turn02_Anrica_LocalPoliceReport`
- `BaseGameSupport.Report_Turn02_Narbel_SituationReport`
- `BaseGameSupport.Report_Turn02_Narbel_TenseSituationReport`
- `GameCondition.Turn02_A_ContractBribe`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 20

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.PersonalWealth`
- `BaseGame.Relations_Walter_Promise_BailBusiness`
- `BaseGame.Relations_Walter_Promise_Company`
- `BaseGameSupport.CountryReport_Turn02_Pales_RaisesRiziaCaution`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[3]` (Livia Suno): `Variable["GameCondition.Turn02_A_ContractBribe"] = true;`
- Węzeł `[14]` (Livia Suno): `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;`
- Węzeł `[149]` (Livia Suno): `Variable["BaseGame.Relations_Walter_Promise_Company"] = true;`
- Węzeł `[168]` (Livia Suno): `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 2;`
- Węzeł `[169]` (Livia Suno): `Variable["BaseGame.Relations_Walter_Promise_Company"] = true;`
- Węzeł `[174]` (Livia Suno): `Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] = true;`
- Węzeł `[175]` (Livia Suno): `Variable["BaseGameSupport.Report_Turn02_Narbel_SituationReport"] = true;`
- Węzeł `[176]` (Livia Suno): `Variable["BaseGameSupport.News_Turn02_R_WorkersPartyMarch"] = true; Variable["BaseGameSupport.New...`
- *...oraz 12 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Livia Suno)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: GameCondition.Turn02_A_ContractBribe = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn02_A_ContractBribe"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[4]`
Mówca: **Walter Tusk**
> ""We can be close allies. The Group can help you get Sordland out of the recession. Which will be the key problem to solve in your term and could even determine your re-election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[5]`
Mówca: **Walter Tusk**
> ""If the contract were somehow awarded to Underhall Construction, they would not only work hard and deliver, but also do it on time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Walter Tusk**
> ""What do you think, Mr. Rayne, wouldn't that be good?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[7]`
Mówca: **Walter Tusk**
> ""I'm glad that you have decided to promote the free market, which is the only thing that can get us out of this mess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[24]`
  - -> `[85]`
  - -> `[93]`

### Węzeł `[8]`
Mówca: **Walter Tusk**
> ""For us it is worrying to see that you have decided to promote a planned economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[23]`
  - -> `[95]`

### Węzeł `[9]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[11]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[12]`
Mówca: **Narrator**
> "He closed the door behind him. I gathered my things and prepared to finally head home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[13]`
Mówca: **Narrator**
> "Walter sighed and pulled the check away, putting it in his pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[131]`
  - -> `[136]`
  - -> `[157]`

### Węzeł `[14]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[15]`
Mówca: **Walter Tusk**
> ""The highway investment was a good call. But high-speed rail would've been better, especially for business logistics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`
  - -> `[119]`
  - -> `[209]`

### Węzeł `[16]`
Mówca: **Walter Tusk**
> ""Glad to hear that because the unemployment rate won't decrease otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[17]`
Mówca: **Walter Tusk**
> ""Do you really though?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[18]`
Mówca: **Walter Tusk**
> ""Which he couldn't finish due to being heavily obstructed by the establishment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "“Our goal is to unite every stakeholder to improve the economy.”"]** — Mówca: **Player**
> "“Our goal is to unite every stakeholder to improve the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[20]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_Admin_Meeting == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_Admin_Meeting == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_Admin_Meeting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[22]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_Admin_Meeting == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_Admin_Meeting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[23]`
**[WYBÓR GRACZA: ""We need more government control to fix the economy.""]** — Mówca: **Player**
> ""We need more government control to fix the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""The ability of the free-market to evolve is hard to dispute.""]** — Mówca: **Player**
> ""The ability of the free-market to evolve is hard to dispute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Indeed, Mr. Tusk. I am looking forward to our future transactions. [Take Bribe]""]** — Mówca: **Player**
> ""Indeed, Mr. Tusk. I am looking forward to our future transactions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "“No. I will make my own decision.”"]** — Mówca: **Player**
> "“No. I will make my own decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[27]`
Mówca: **Walter Tusk**
> ""The ruined state of the economy in Sordland has influenced everyone. The recession hit all of us hard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[28]`
Mówca: **Walter Tusk**
> ""I'd like to build a profitable relationship between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Walter Tusk**
> ""That being said, there are some concerns of mine and the people I represent...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Walter Tusk**
> ""...which I would like to take this opportunity to clear up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`
  - -> `[34]`

### Węzeł `[31]`
**[WYBÓR GRACZA: ""Please.""]** — Mówca: **Player**
> ""Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[32]`
**[WYBÓR GRACZA: ""I'm listening.""]** — Mówca: **Player**
> ""I'm listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[33]`
**[WYBÓR GRACZA: ""What are these concerns?""]** — Mówca: **Player**
> ""What are these concerns?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[34]`
**[WYBÓR GRACZA: ""The people you represent?""]** — Mówca: **Player**
> ""The people you represent?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[35]`
Mówca: **Narrator**
> "It was late in the evening."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[36]`
**[WYBÓR GRACZA: ""Don't worry about it.""]** — Mówca: **Player**
> ""Don't worry about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[37]`
Mówca: **Narrator**
> "I eagerly approached my chair and sprawled out on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[38]`
Mówca: **Narrator**
> "The Maroon Palace was finally getting somewhat quiet when I returned to my office at the top."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[39]`
Mówca: **Narrator**
> "After a moment, Mr. Tusk swaggered into the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[40]`
Mówca: **Walter Tusk**
> ""You know that I represent the Lotherberg Group, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Narrator**
> "It had been an exhausting day, just like every day since I took office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[48]`
  - -> `[46]`
  - -> `[44]`

### Węzeł `[42]`
Mówca: **Walter Tusk**
> ""But of course, these concerns are not limited to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[43]`
Mówca: **Walter Tusk**
> ""Good evening, Mr. President. I am here to congratulate you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "Prepare to go home."]** — Mówca: **Player_Italic**
> "I forced myself out of the chair to gather my jacket and briefcase. I really needed to make some time for my family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "Lean back and relax."]** — Mówca: **Player_Italic**
> "I stretched out my arms, leaned back in my chair and took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[47]`
Mówca: **Walter Tusk**
> ""Cognac. Preferably from before you were born, sweetheart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "Pour some whiskey."]** — Mówca: **Player_Italic**
> "I poured a little whiskey for myself and had a sip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[49]`
Mówca: **Walter Tusk**
> ""I had no chance to say this at the ball with all the panic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[50]`
Mówca: **Walter Tusk**
> ""May I continue?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[45]`

### Węzeł `[51]`
**[WYBÓR GRACZA: ""Forgive me, I didn't want to be rude. Long day.""]** — Mówca: **Player**
> ""Forgive me, I didn't want to be rude. Long day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[52]`
**[WYBÓR GRACZA: ""I don't believe I'm being rude. Time is money after all. Isn't that right?""]** — Mówca: **Player**
> ""I don't believe I'm being rude. Time is money after all. Isn't that right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[53]`
Mówca: **Walter Tusk**
> ""Yes, that's true. But at the same time, patience and humility are important virtues for a man in your position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Walter Tusk**
> ""No need to ask for forgiveness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Walter Tusk**
> ""You are the President after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[56]`
Mówca: **Narrator**
> "I quickly glanced out the window before leaving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[57]`
Mówca: **Walter Tusk**
> ""I merely congratulated you. I see no reason to necessitate rudeness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "“Do your job properly next time. Do you expect me to keep track of everything myself?""]** — Mówca: **Player**
> ""Do your job properly next time. Do you expect me to keep track of everything myself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[59]`
Mówca: **Narrator**
> "Holsord's skyline was daunting but beautiful."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[60]`
**[WYBÓR GRACZA: ""Likewise.""]** — Mówca: **Player**
> ""Likewise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[61]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[62]`
Mówca: **Narrator**
> "It felt like the best salve after a long day of work."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""Why is it that you're really here, Mr. Tusk?""]** — Mówca: **Player**
> ""Why is it that you're really here, Mr. Tusk?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[64]`
Mówca: **Walter Tusk**
> ""My business partners and I wish you a successful term as the leader of our nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[70]`
  - -> `[69]`

### Węzeł `[65]`
Mówca: **Narrator**
> "Serge and the guards were outside by the main gate as usual."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Narrator**
> "I glanced downwards out the window and saw Serge and the guards waiting for me by the main gate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Narrator**
> "I heard a couple of knocks on the door. My secretary, Livia Suno, entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[68]`
**[WYBÓR GRACZA: ""Thank you, Mr. Tusk.""]** — Mówca: **Player**
> ""Thank you, Mr. Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[69]`
**[WYBÓR GRACZA: ""Get to the point, Mr. Tusk. Why are you really here?""]** — Mówca: **Player**
> ""Get to the point, Mr. Tusk. Why are you really here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[71]`
Mówca: **Walter Tusk**
> ""I see that you're not very welcoming, President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[72]`
Mówca: **Walter Tusk**
> ""But we are very much looking forward to working with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`
  - -> `[63]`

### Węzeł `[73]`
Mówca: **Livia Suno**
> ""But he's already here, Mr. President. What do you want me to tell him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[74]`
Mówca: **Livia Suno**
> ""Mr. President, Mr. Tusk is here to see you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[75]`
**[WYBÓR GRACZA: ""I was just about to leave. Maybe we can postpone the meeting?""]** — Mówca: **Player**
> ""I was just about to leave. Maybe we can postpone the meeting?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[76]`
Mówca: **Livia Suno**
> ""Thank you for your understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[77]`
Mówca: **Livia Suno**
> ""You're right, Mr. President. I probably made a mistake with my notes. It'll never happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[78]`
Mówca: **Livia Suno**
> ""You had a meeting with the Lotherberg spokesman. I'm so sorry for not giving you proper notice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[58]`
  - -> `[75]`

### Węzeł `[79]`
Mówca: **Walter Tusk**
> "“This deal also aligns with the free-market strategy your government has adopted besides boosting further investment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[140]`
  - -> `[141]`

### Węzeł `[80]`
Mówca: **Walter Tusk**
> "“This deal will also show to the Group that the administration hasn't left the private sector behind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[140]`
  - -> `[141]`

### Węzeł `[81]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[83]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[84]`
**[WYBÓR GRACZA: ""The recession was triggered by the market reforms of Alphonso.""]** — Mówca: **Player**
> ""The recession was triggered by the market reforms of Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[85]`
**[WYBÓR GRACZA: ""It is good that we think alike on the matter.""]** — Mówca: **Player**
> ""It is good that we think alike on the matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Walter Tusk**
> ""I couldn't have it said it better. Or could I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[87]`
Mówca: **Walter Tusk**
> ""To a closer relationship then!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[88]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[90]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Highway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[91]`
Mówca: **Narrator**
> "He pulled his hands back and I took the check."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[92]`
Mówca: **Walter Tusk**
> ""You have talented economists like Mr. Holl in the cabinet, so you made the right choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[93]`
**[WYBÓR GRACZA: ""I took my economic team's advice.""]** — Mówca: **Player**
> ""I took my economic team's advice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[94]`
Mówca: **Walter Tusk**
> ""Neither do I. But you know how much capital Lotherberg represents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[95]`
**[WYBÓR GRACZA: ""I don't mind that we disagree on the economy.""]** — Mówca: **Player**
> ""I don't mind that we disagree on the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[96]`
Mówca: **Narrator**
> "He pulled his hands back and I took the check."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[97]`
Mówca: **Walter Tusk**
> ""The high-speed rail investment was a great decision, the business logistics will improve and boost the economy once finished.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[118]`
  - -> `[126]`
  - -> `[209]`

### Węzeł `[98]`
Mówca: **Narrator**
> "We both sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[99]`
Mówca: **Narrator**
> "Walter pulled out a box of cigars from his jacket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
**[WYBÓR GRACZA: "Smoke a cigar."]** — Mówca: **Player_Italic**
> "I grabbed one out of the pack, Walter lit it up with his large engraved lighter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[101]`
Mówca: **Walter Tusk**
> ""I had these brought from Lespia. The best cigars in the whole continent. Would you like to try one?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[103]`
  - -> `[105]`

### Węzeł `[102]`
Mówca: **Walter Tusk**
> ""Sure. No problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[103]`
**[WYBÓR GRACZA: ""You go ahead, I don't want to smoke.""]** — Mówca: **Player**
> ""You go ahead. I don't want to smoke right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Narrator**
> "Walter grabbed himself a cigar and lit it. He looked out towards the city scenery as he puffed away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[105]`
**[WYBÓR GRACZA: ""I'd rather not have you smoke here.""]** — Mówca: **Player**
> ""I'd rather not have you smoke here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[106]`
Mówca: **Walter Tusk**
> ""Now we are talking. A man who knows pleasure and business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Narrator**
> "Walter grabbed himself a cigar and lit it up as well. We looked out at the city scenery as we both puffed away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[108]`
Mówca: **Walter Tusk**
> ""You are having a good start to the term for sure. Besides the recent troubles, I mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[109]`
Mówca: **Walter Tusk**
> ""The assassination and the troubles between the left and right are worrying. But the recession is the root cause of these issues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[110]`
Mówca: **Walter Tusk**
> "“Economics needs long-term strategy and mid-term adjustments to provide growth and stability.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[111]`
Mówca: **Walter Tusk**
> ""Our government is already overburdened with managing several key industries, with the loss of efficiency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Narrator**
> "He leaned forward in the chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[113]`
Mówca: **Walter Tusk**
> ""Even though you're pursuing this path, you're going to need further market investments to boost the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[114]`
Mówca: **Walter Tusk**
> ""We really think that there are many elements where our capital could be of help to the government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[115]`
Mówca: **Walter Tusk**
> ""One that will bring Sordland out of crippling recession!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Walter Tusk**
> ""There are many other avenues where we could work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Narrator**
> "He grinned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[118]`
**[WYBÓR GRACZA: ""Our goal was to focus on the needs of the businesses.""]** — Mówca: **Player**
> ""Our goal was to focus on the needs of the businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[119]`
**[WYBÓR GRACZA: ""The intention of the administration is to boost the economy.""]** — Mówca: **Player**
> ""The intention of the administration is to boost the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[120]`
**[WYBÓR GRACZA: ""The Agnland region was in dire need of investments.""]** — Mówca: **Player**
> ""The Agnland region was in dire need of investments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[121]`
**[WYBÓR GRACZA: ""Our goal was to focus on the needs of the people not businesses.""]** — Mówca: **Player**
> ""Our goal was to focus on the needs of the people, not businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[122]`
Mówca: **Walter Tusk**
> ""The right intention for sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[123]`
Mówca: **Walter Tusk**
> ""The most important goal is to divert investments where most profits can be made for the treasury.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[124]`
Mówca: **Walter Tusk**
> ""I do understand where you are coming from but the businesses will help these people get employed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[125]`
Mówca: **Walter Tusk**
> ""Connecting our largest two economic powerhouses was the right call to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[126]`
**[WYBÓR GRACZA: ""The Greater Holsord and Gelsord regions needed better links.""]** — Mówca: **Player**
> ""The Greater Holsord and Gelsord regions needed better links.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[127]`
Mówca: **Narrator**
> "He pulled a check out of his pocket and slid it towards me on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Narrator**
> "My personal bank details were listed on it, showing a deposit of 500,000 Sordish Ren ready to be transferred. This amount was equivalent to six months of the presidential budget."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[129]`
Mówca: **Walter Tusk**
> "“Oh I almost forgot. Please say hello to Mr. Koronti for me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[130]`
Mówca: **Narrator**
> "He put his index finger on the check."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[131]`
**[WYBÓR GRACZA: "“If this is what you came here for then we are done here.”"]** — Mówca: **Player**
> "“If this is what you came here for, then we are done here, Mr. Tusk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
**[WYBÓR GRACZA: "“Did you think that I was just another corrupt politician?”"]** — Mówca: **Player**
> "“Did you think that I was just another corrupt politician?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Walter Tusk**
> "“My goal was to begin a mutually beneficial partnership, but besides that it was good to spend time together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[134]`
Mówca: **Walter Tusk**
> "“Administrations are built on mutually beneficial partnerships. But I do understand where you stand now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[135]`
Mówca: **Walter Tusk**
> "“Have a good evening, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[136]`
**[WYBÓR GRACZA: "“Thank you for the visit nonetheless.”"]** — Mówca: **Player**
> "“Thank you for the visit nonetheless.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Walter Tusk**
> "“It was good to share opinions. We will meet again in the future for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[138]`
Mówca: **Narrator**
> "Walter stood up, grabbed his jacket and made his way towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[139]`
Mówca: **Narrator**
> "Walter stood up, grabbed his jacket and shook my hand before making his way towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[140]`
**[WYBÓR GRACZA: "“The administration will maintain a good relationship with the Group.”"]** — Mówca: **Player**
> "“The administration will maintain a good relationship with the Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
**[WYBÓR GRACZA: "“I am very happy we came to an agreement today, Mr. Tusk.”"]** — Mówca: **Player**
> "“I am very happy we came to an agreement today, Mr. Tusk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[142]`
Mówca: **Walter Tusk**
> "“Great to hear, President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[143]`
Mówca: **Walter Tusk**
> "“Exactly, business owners need to unite and support growth. Thanks to your efforts, we'll see it happen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[144]`
Mówca: **Walter Tusk**
> "“Likewise, President Rayne. It was a pleasure doing business with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[145]`
Mówca: **Narrator**
> "He smiled before closing the door and leaving. I gathered my things and prepared to finally head home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[146]`
Mówca: **Walter Tusk**
> "“We will be in touch.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[147]`
**[WYBÓR GRACZA: "Light a cigarette."]** — Mówca: **Player_Italic**
> "I lit a cigarette and smoked it for a while."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Narrator**
> "It helped take my mind off my work stress for a minute. The smoke slowly rose towards the tall ceiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[149]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Company = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_Company"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[150]`
**[WYBÓR GRACZA: "“Not yet. We both know you can do better than that amount.""]** — Mówca: **Player**
> "“Not yet. We both know you can do better than that amount.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Walter Tusk**
> "“You are right about that. I'll make this my final offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Narrator**
> "He pulled out another check with a smile. This time, 1,000,000 Sordish Ren was listed on the piece of paper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[161]`
  - -> `[164]`

### Węzeł `[153]`
**[WYBÓR GRACZA: "“I accept the offer.” [Take Bribe]"]** — Mówca: **Player**
> "“I accept the offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[154]`
Mówca: **Walter Tusk**
> "“You don't have to wait long, Mr. Rayne. As a gesture of faith in our newfound partnership, I will invite you to a special meeting in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Narrator**
> "He grinned and let out a laugh. The check was right between his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[156]`
**[WYBÓR GRACZA: "“Did you just try to bribe the President of Sordland? I refuse!”"]** — Mówca: **Player**
> "“Did you just try to bribe the President of Sordland? I refuse!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[157]`
**[WYBÓR GRACZA: "“Be careful, Tusk, or you will have to make your deals in a prison cell.”"]** — Mówca: **Player**
> "“Be careful, Tusk, or you will have to make your deals in a prison cell.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Walter Tusk**
> "“My goal was to begin a mutually beneficial partnership. Nothing more, I assure you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Walter Tusk**
> "“I think we started off on the wrong foot here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[160]`
Mówca: **Walter Tusk**
> "“Well, I will excuse myself then. Thank you for your time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[161]`
**[WYBÓR GRACZA: "“Until you come back with a better offer, the answer is no.”"]** — Mówca: **Player**
> "“Until you come back with a better offer, the answer is no.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Walter Tusk**
> "“Very well, then. We will be in touch. I still think this was a good start for a beneficial partnership in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Narrator**
> "Walter sighed and pulled the check away, putting it in his pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[164]`
**[WYBÓR GRACZA: "“Here is my final offer. Do not try to bribe me again or you will have to make your deals in a prison cell.”"]** — Mówca: **Player**
> "“Here is my final offer. Do not try to bribe me again or you will have to make your deals in a prison cell.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Narrator**
> "Walter sighed and pulled the check away, putting it in his pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[166]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[167]`
Mówca: **Narrator**
> "She and I took a moment to look out over the lights of the city before heading to the elevators."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[168]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth += 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[169]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Company = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_Company"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[170]`
**[WYBÓR GRACZA: ""We had nothing but troubles so far and economy is not the only concern.""]** — Mówca: **Player**
> ""We had nothing but troubles so far and economy is not the only concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Walter Tusk**
> ""Economy is always the biggest concern, President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Walter Tusk**
> ""Whether we like it or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[173]`
Mówca: **Walter Tusk**
> ""Let's start with a gesture of goodwill. Soon the investment project contract will be awarded to one of the three main contenders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[174]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusiness = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[175]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn02_Narbel_SituationReport = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Narbel_SituationReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_R_WorkersPartyMarch = true;
BaseGameSupport.News_Turn02_LT_ReformDemands = true;
BaseGameSupport.News_Turn02_HP_KibenerSuggestsPower = true;
BaseGameSupport.Report_Turn02_Anrica_LocalPoliceReport = true;
BaseGameSupport.CountryReport_Turn02_Pales_RaisesRiziaCaution = true;
BaseGameSupport.News_Turn02_HP_GasomEngineerSalaries = true;
BaseGameSupport.News_Turn02_LT_LUSNarbelStatement = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_R_WorkersPartyMarch"] = true;
Variable["BaseGameSupport.News_Turn02_LT_ReformDemands"] = true;
Variable["BaseGameSupport.News_Turn02_HP_KibenerSuggestsPower"] = true;
Variable["BaseGameSupport.Report_Turn02_Anrica_LocalPoliceReport"] = true;
Variable["BaseGameSupport.CountryReport_Turn02_Pales_RaisesRiziaCaution"] = true;
Variable["BaseGameSupport.News_Turn02_HP_GasomEngineerSalaries"] = true;
Variable["BaseGameSupport.News_Turn02_LT_LUSNarbelStatement"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[177]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_R_BludishLynched = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_R_BludishLynched"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[178]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_AcceptedTuskCompanyBribe = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_AcceptedTuskCompanyBribe"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[179]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_AcceptedTuskCompanyBribe = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_AcceptedTuskCompanyBribe"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[180]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_RejectedTuskCompanyBribe = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_RejectedTuskCompanyBribe"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[181]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_InfrastructureProject_Invest == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_InfrastructureProject_Invest == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_InfrastructureProject_Invest == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[184]`
Mówca: **Walter Tusk**
> ""In my opinion, not investing in our infrastructure was a missed opportunity. But the government could still work on an economic relief package.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[185]`
**[WYBÓR GRACZA: ""The intention of the administration is to boost the economy overall.""]** — Mówca: **Player**
> ""The intention of the administration is to boost the economy overall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[186]`
**[WYBÓR GRACZA: ""Our goal is to focus on the needs of the people, not businesses.""]** — Mówca: **Player**
> ""Our goal is to focus on the needs of the people, not businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[187]`
**[WYBÓR GRACZA: ""Our goal is to focus on the needs of the businesses.""]** — Mówca: **Player**
> ""Our goal is to focus on the needs of the businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[188]`
Mówca: **Walter Tusk**
> ""The most important goal is to divert investments where most profits can be made for the treasury. These are businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[189]`
Mówca: **Walter Tusk**
> ""I do understand where you are coming from but the businesses will help these people get employed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[190]`
Mówca: **Walter Tusk**
> ""Glad to hear that because the unemployment rate won't decrease otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[191]`
Mówca: **Walter Tusk**
> ""If the package ends up bailing out the businesses that have suffered under this recession, they could provide employment and help the economy recover.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Walter Tusk**
> ""What do you think, Mr. Rayne, wouldn't that be good?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[193]`
Mówca: **Narrator**
> "He pulled a check out of his pocket and slid it towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Narrator**
> "My personal bank details were listed on it, showing a deposit of 500,000 Sordish Ren ready to be transferred. This amount was equivalent to six months of the presidential budget."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[195]`
Mówca: **Walter Tusk**
> ""Let's start with a gesture of goodwill. Soon the economic relief package will be presented and it will either bail out businesses or provide checks for people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[196]`
Mówca: **Walter Tusk**
> ""We can be close allies. The Group can help you get Sordland out of the recession. Which will be the key problem to solve in your term and could even determine to your re-election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[197]`
Mówca: **Narrator**
> "He put his index finger on the check."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[198]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_InfrastructureProject_Invest == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_InfrastructureProject_Invest == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[200]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_InfrastructureProject_Invest == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[201]`
Mówca: **Walter Tusk**
> ""What are your overall intentions with the economy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`
  - -> `[187]`
  - -> `[206]`

### Węzeł `[202]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusiness = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[203]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_InfrastructureProject_Invest == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_InfrastructureProject_Invest == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[205]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_InfrastructureProject_Invest == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[206]`
**[WYBÓR GRACZA: ""I don't want to disclose our intentions to an outsider.""]** — Mówca: **Player**
> ""I don't want to disclose our intentions to an outsider.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Walter Tusk**
> ""That is a fair point but why distance yourself from potential friends here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[208]`
Mówca: **Walter Tusk**
> ""That is a fair point but why distance yourself from potential friends here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[209]`
**[WYBÓR GRACZA: ""I don't want to disclose our intentions to an outsider.""]** — Mówca: **Player**
> ""I don't want to disclose our intentions to an outsider.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[210]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_AcceptedTuskBailBribe = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_AcceptedTuskBailBribe"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[211]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_AcceptedTuskBailBribe = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_AcceptedTuskBailBribe"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[212]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_InfrastructureProject_Invest == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_InfrastructureProject_Invest == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_InfrastructureProject_Invest == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[215]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_RejectedTuskBailBribe = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_RejectedTuskBailBribe"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[216]`
Mówca: **Walter Tusk**
> ""My father once said, you have to finish what you started. He is right. The system collapsed because Alphonso didn't finish the reforms he started. And look at what happened to him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[217]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[219]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Walter Tusk**
> ""I heard that you purchased stock from Armadine Industries in Arcasia. Smart buy. They are developing new gadgets that are going to be profitable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[221]`
  - -> `[227]`

### Węzeł `[221]`
**[WYBÓR GRACZA: ""Spend money to make money they say. Let's see if it holds true.""]** — Mówca: **Player**
> ""Spend money to make money they say. Let's see if it holds true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[222]`
**[WYBÓR GRACZA: ""With risk comes reward. I expect a very good return on investment.""]** — Mówca: **Player**
> ""With risk comes reward. I expect a very good return on investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Walter Tusk**
> ""You have a keen eye for business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Walter Tusk**
> ""You will be surprised at what one can achieve given the resources in capitalism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[225]`
Mówca: **Walter Tusk**
> ""I will buy a couple of thousand of shares too to expand my portfolio. Hope the investments pay off for both of us, President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Narrator**
> "His eyes wandered away for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[227]`
**[WYBÓR GRACZA: ""I figured why not take the chance?""]** — Mówca: **Player**
> ""I figured why not take the chance?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Walter Tusk**
> ""It's much worse to live with regret and what ifs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[229]`
Mówca: **Livia Suno**
> ""Anything to drink, Mr. Tusk? Water, whiskey?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[230]`
Mówca: **Narrator**
> "There was a noise by the door. Livia Suno was standing there, holding a tray with a bottle and two glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Livia Suno**
> ""I'm so sorry, Mr. Tusk, but all I could find was a 1942 Sevigny. I hope that's acceptable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Narrator**
> "She quickly put the tray on my desk and walked out. Tusk eyed her as she left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Walter Tusk**
> ""Remind me to visit your office more often. Now, where were we? Do we have a deal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[150]`
  - -> `[26]`
  - -> `[156]`

### Węzeł `[234]`
Mówca: **Narrator**
> "As I walked out I noticed Livia still there, covering up her typewriter for the evening."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Livia Suno**
> ""If I may be so bold, Mr. President... did you accept his offer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[241]`
  - -> `[242]`
  - -> `[258]`

### Węzeł `[236]`
Mówca: **Livia Suno**
> ""The other girls have told me about all kinds of dealings that went on during the Alphonso administration. I wasn't sure if you were that kind of president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[245]`

### Węzeł `[237]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusiness == true ||BaseGame.Relations_Walter_Promise_Company == true == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusiness == true ||BaseGame.Relations_Walter_Promise_Company == true == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  or Variable["BaseGame.Relations_Walter_Promise_Company"] == true == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_BailBusiness == true ||BaseGame.Relations_Walter_Promise_Company == true == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  or Variable["BaseGame.Relations_Walter_Promise_Company"] == true == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[240]`
**[WYBÓR GRACZA: ""As a matter of fact, I did. What of it?""]** — Mówca: **Player**
> ""As a matter of fact, I did. What of it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[241]`
**[WYBÓR GRACZA: ""That is absolutely none of your business.""]** — Mówca: **Player**
> ""That is absolutely none of your business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
**[WYBÓR GRACZA: ""Of course I didn't. How could you even ask me that?""]** — Mówca: **Player**
> ""Of course I didn't. How could you even ask me that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[243]`
Mówca: **Livia Suno**
> ""Of course. Sorry to intrude.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[244]`
Mówca: **Livia Suno**
> ""Are you sure it was a good idea? You've just given him leverage over you that he can use for the rest of your time in office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[245]`
**[WYBÓR GRACZA: ""Don't worry your pretty head about it.""]** — Mówca: **Player**
> ""Don't worry your pretty head about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[246]`
**[WYBÓR GRACZA: ""I most certainly am not.""]** — Mówca: **Player**
> ""I most certainly am not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[247]`
**[WYBÓR GRACZA: ""A valid concern. But I've made my decision.""]** — Mówca: **Player**
> ""A valid concern. But I've made my decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[248]`
**[WYBÓR GRACZA: ""Don't worry your pretty head about it.""]** — Mówca: **Player**
> ""Don't worry your pretty head about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[249]`
Mówca: **Livia Suno**
> ""I-- I'll check the supply room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Narrator**
> "Livia backed out of the office, shooting me an apologetic look as she did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[251]`
Mówca: **Narrator**
> "Walter hung up his hat, which I could see was lined with mink. He fixed me with a long, hard stare, then broke into a toothy grin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[252]`
Mówca: **Narrator**
> "Walter took a conspicuous look at the diamond-encrusted watch on his wrist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[253]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_A_ContractBribe_Smoked = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn01_A_ContractBribe_Smoked"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[254]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_A_ContractBribe_Smoked == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_A_ContractBribe_Smoked == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_A_ContractBribe_Smoked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn01_A_ContractBribe_Smoked == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_A_ContractBribe_Smoked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[257]`
Mówca: **Narrator**
> "Walter took a suspicious sniff at the lingering smoke in the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[258]`
**[WYBÓR GRACZA: ""Do not ever speak about it again. You didn't see anything.""]** — Mówca: **Player**
> ""Do not ever speak about it again. You didn't see anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[259]`
Mówca: **Narrator**
> "I'd met Sordland's most prominent businessman once or twice, but never alone. He had large jowls, blindingly shiny shoes and the air of someone who was used to getting his way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[260]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_FPnT_Consulate_Condemn == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_FPnT_Consulate_Condemn == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[262]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_FPnT_Consulate_Condemn == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[263]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn02_Narbel_TenseSituationReport = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Narbel_TenseSituationReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[264]`
Mówca: **Walter Tusk**
> ""Oh, and before I forget, a final token of my gratitude.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[265]`
Mówca: **Narrator**
> "Walter pulls a box of cigars out of his pocket. The label read: "Varo Benvinoto"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Walter Tusk**
> ""Some of Lespia's finest, made by true craftsmen in the fabled city of San Verlon. You should visit someday, should the opportunity arise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[267]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_CigarBox");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_CigarBox");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[268]`
Mówca: **Livia Suno**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
