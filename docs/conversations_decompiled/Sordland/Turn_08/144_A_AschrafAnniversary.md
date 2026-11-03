# Sordland/Turn08/A_AschrafAnniversary

- **ID konwersacji:** `144`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/144_A_AschrafAnniversary.md`
- **Liczba węzłów dialogowych:** 471
- **Liczba wyborów gracza:** 85

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[15]** Mansoun Leke
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Arrest_FetihEjall`
- `BaseGame.BFF_Threatens_President`
- `BaseGame.BergiaSpecialZone_Proposal_Centralization`
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Bergia_Governor_Ersen`
- `BaseGame.Bergia_Governor_Krull`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Bill_Turn07_LanguageBill_Signed`
- `BaseGame.Bludish_Opinion`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Law_Ban_WPB`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Unrest_BFF_WillHappen`
- `BaseGame.Wehlen_DefendBorder`
- `BaseGame.Wehlen_JointOperation`
- `BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle`
- `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction`
- `BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Democratic`
- `BaseGame.Public_Opinion`
- `BaseGame.Situation_Law_BludishOppression`
- `BaseGame.Situation_Law_BludishProblem`
- `BaseGame.Situation_Law_BludishReconciliation`
- `BaseGame.Sollist`
- `BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle`
- `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction`
- `BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle`
- `BaseGameSupport.News_Turn08_LT_Joined_Aschraf_Anniversary_Security`
- `BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_Negative`
- `BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_Positive`
- `BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_Security`
- `GameCondition.Turn08_A_AschrafAnniversary`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 48

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Sollist`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[75]` (Lucian Galade): `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle"] = true;`
- Węzeł `[76]` (Lucian Galade): `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle"] = true;`
- Węzeł `[139]` (Lucian Galade): `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolat...`
- Węzeł `[140]` (Lucian Galade): `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolat...`
- Węzeł `[141]` (Lucian Galade): `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolat...`
- Węzeł `[142]` (Lucian Galade): `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolat...`
- Węzeł `[143]` (Lucian Galade): `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolat...`
- Węzeł `[144]` (Lucian Galade): `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolat...`
- *...oraz 40 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The city had been of particular importance to the Bludish people ever since the Izzam Incident and the death of Watani Aschraf over two decades ago. Today, we were here to commemorate the anniversary of those events."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Our massive convoy could barely fit through the narrow streets, disrupting local traffic and creating noisy chaos in the usually tranquil city. Pedestrians stared at us in fear as we and our heavily armed security forces drove towards the square."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[5]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[7]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Our convoy could barely fit through the narrow streets, disrupting local traffic and creating noisy chaos in the usually tranquil city. Pedestrians stared at us with concern as we and our security forces drove towards the square."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "“I hope so.”"]** — Mówca: **Player**
> "“I hope so.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[10]`
Mówca: **Lucian Galade**
> "“I must say this was a good decision, sir. This will help ease the tensions. But I hope bringing this much security won't cause any problems.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[9]`
  - -> `[12]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "“Better safe than sorry.”"]** — Mówca: **Player**
> "“Better safe than sorry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "“That was my intention all along.”"]** — Mówca: **Player**
> "“That was my intention all along.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[13]`
Mówca: **Lucian Galade**
> "“I agree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[14]`
Mówca: **Mansoun Leke**
> "“Welcome to Erzaren, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[40]`
  - -> `[53]`
  - -> `[52]`

### Węzeł `[15]`
Mówca: **Lucian Galade**
> "“It is certainly risky. But if we manage to win some hearts today, it will be worth it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
Mówca: **Lucian Galade**
> "“If we play our cards right, I am certain.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Lucian Galade**
> "“As expected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Lucian Galade**
> "“We are almost there. I can hear the crowd.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion <= 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
Mówca: **Lucian Galade**
> "“They are telling us to go back where we came from.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[23]`
Mówca: **Narrator**
> "I heard the chants and shouting from outside. Lucian leaned closer to the window, listening to their voices."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[24]`
Mówca: **Narrator**
> "I heard the chants and shouting from the outside. Lucian leaned closer to the window, listening to their voices."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[25]`
Mówca: **Lucian Galade**
> "“They seem to be chanting 'Yollak Bluderat'. I believe that means 'Free Bludia' in Bludish, or something of that sort.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[26]`
Mówca: **Narrator**
> "A large crowd had assembled in the square. There were probably at least ten thousand people. Most of them were yelling insults and obscenities at me. I heard a few shouts of "Soll's boot licker!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Narrator**
> "A large crowd had assembled in the square. There were probably at least ten thousand people."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[28]`
Mówca: **Narrator**
> "As our convoy slowed down, a young Bludish man ran in front of our vehicle and spat on my window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[29]`
Mówca: **Lucian Galade**
> "“Mr. Leke.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[30]`
Mówca: **Narrator**
> "Our vehicle came to a stop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[31]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Narrator**
> "The security detail left their vehicles with their machine guns openly displayed. I followed them. The crowd seemed to be riled up at the sight of guns."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[35]`
Mówca: **Narrator**
> "My driver exited the vehicle and opened the door for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[36]`
Mówca: **Narrator**
> "We were greeted by Mansoun Leke. He wore a coat over his suit which was marked with the red and turquoise stripes of the Bludish movement's flag. He moved forward to greet us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[37]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion <= 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[40]`
**[WYBÓR GRACZA: "“No need for pleasantries. I want this over with as quickly as possible.”"]** — Mówca: **Player**
> "“No need for pleasantries. I want this over with as quickly as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[41]`
**[WYBÓR GRACZA: "“It looks like I am not welcome here, Mr. Leke.”"]** — Mówca: **Player**
> "“It looks like I am not welcome here, Mr. Leke.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[42]`
Mówca: **Mansoun Leke**
> "“Very perceptive of you. But that is why you are here, if I am correct. To fix this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[45]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[46]`
Mówca: **Narrator**
> "He pointed at the security guards with guns."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Mansoun Leke**
> "“I am not sure how bringing your personal army will help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[48]`
  - -> `[50]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "“They are here for protection.”"]** — Mówca: **Player**
> "“They are here for protection.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "“They are not my personal army. They protect the government.”"]** — Mówca: **Player**
> "“They are not my personal army. They protect the government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "“Let's *go*.”"]** — Mówca: **Player**
> "“Let's *go*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[51]`
Mówca: **Mansoun Leke**
> "“Protection from your own citizens? I guess there must be a reason to be fearful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Italic**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "Take his hand and raise it in a display of unity."]** — Mówca: **Player_Italic**
> "I held our clasped hands up so that the crowd could see them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion <= 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Narrator**
> "I heard shouts in Bludish coming from the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[58]`
Mówca: **Narrator**
> "I heard some applause from the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[59]`
Mówca: **Mansoun Leke**
> "“I see. The government must have a reason to fear its own citizens then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Mansoun Leke**
> "“On a day like this, when you want to show support for the murdered Bludish people... You bring men with guns.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[61]`
Mówca: **Mansoun Leke**
> "“Mr. Galade. Welcome. Shall we move on to the Sanctuary, then?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Lucian Galade**
> "“Let's go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Narrator**
> "We made our way to the Erzaren Sanctuary, which stood at the end of the square."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Narrator**
> "A much smaller replica of the Archsanctuary in Deyr, the ancient building had a mystical aura emanting from its blackened walls. We entered the building through the ornamented large metal gates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Narrator**
> "As we walked, the noise of the crowd faded out. Everyone fell silent for the ceremony. Thousands of candles were burning inside the Sanctuary, one for each person that died in Izzam. The red candle in the center was for Watani Aschraf."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Narrator**
> "Mansoun gestured towards the candles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`
  - -> `[69]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "Pick up a candle."]** — Mówca: **Player_Italic**
> "I picked up one of the candles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "Pick up the red candle."]** — Mówca: **Player_Italic**
> "I picked up the red candle for Watani Aschraf."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "Do not pick a candle."]** — Mówca: **Player_Italic**
> "I did not pick a candle. Instead, I let Mansoun lead the way. His face soured."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[70]`
Mówca: **Narrator**
> "He also picked up a candle and started walking out. Many others followed suit, including us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[71]`
Mówca: **Narrator**
> "He picked up the candle for Aschraf and started walking out. Many others followed suit, including us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Narrator**
> "He picked up the candle for Aschraf and started walking out. Many others followed suit, including us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Narrator**
> "The atmosphere outside had completely changed. Not a single noise came from the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Narrator**
> "We slowly walked towards Aschraf's grave. On the way, hundreds of people joined us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[75]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[76]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[77]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[79]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[80]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[82]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[83]`
Mówca: **Narrator**
> "Seeing the red candle in my hand, some people started shouting at me, breaking the silence. One man managed to break the security cordon and ran towards me, screaming."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[84]`
Mówca: **Narrator**
> "When we arrived, he pointed at a huge standing torch above the grave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[86]`
  - -> `[87]`

### Węzeł `[85]`
Mówca: **Narrator**
> "When we arrived, Mansoun lit the unlit candle above the grave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[86]`
**[WYBÓR GRACZA: "Light the torch."]** — Mówca: **Player_Italic**
> "I lit the torch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "Light the torch together with Mansoun."]** — Mówca: **Player_Italic**
> "We lit the torch together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[88]`
Mówca: **Narrator**
> "I turned around and realized the sheer amount of people who were following us. They were all looking at me, waiting to hear what I would say."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "“My fellow citizens.”"]** — Mówca: **Player**
> "“My fellow citizens.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[283]`

### Węzeł `[90]`
**[WYBÓR GRACZA: "“Brothers and sisters.”"]** — Mówca: **Player**
> "“Brothers and sisters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[283]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "“We are here to mourn Watani Aschraf and many others who have lost their lives.”"]** — Mówca: **Player**
> "“We are here to mourn Watani Aschraf and many others who have lost their lives.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[97]`
  - -> `[99]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "“Free people of Bludia.”"]** — Mówca: **Player**
> "“Free people of Bludia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "“Let me tell you one thing. I dream of a truly united Sordland. A country where being a Blud or a Sord does not matter.”"]** — Mówca: **Player**
> "“Let me tell you one thing. I dream of a truly united Sordland. A country where being a Blud or a Sord does not matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[104]`
  - -> `[107]`

### Węzeł `[94]`
**[WYBÓR GRACZA: "Signal the security to detain him."]** — Mówca: **Player_Italic**
> "I signalled the security guards to detain him. They immediately ran out and the boy disappeared from my sight. Another guard came over to wipe the car window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[95]`
**[WYBÓR GRACZA: "Do not do anything."]** — Mówca: **Player_Italic**
> "I did not do anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[96]`
Mówca: **Narrator**
> "Seeing the boy get dragged away caused an outcry from the crowd. Hundreds of people rushed at our car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[97]`
**[WYBÓR GRACZA: "“They were brave men and women who only wanted to protect their land.”"]** — Mówca: **Player**
> "“They were brave men and women who only wanted to protect their land.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[98]`
**[WYBÓR GRACZA: "“I am not standing before you today as the President. I am standing here as one of you.”"]** — Mówca: **Player**
> "“I am not standing before you today as the President. I am standing here as one of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[100]`
  - -> `[101]`

### Węzeł `[99]`
**[WYBÓR GRACZA: "“I condemn the events that led to the loss of these lives.”"]** — Mówca: **Player**
> "“I condemn the events that led to the loss of these lives.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
**[WYBÓR GRACZA: "“I share your hatred and anger. I feel it too, I assure you. Like a red-hot iron, it takes a long time for it to cool. But I look at the lost lives and think, what would they want?”"]** — Mówca: **Player**
> "“I share your hatred and anger. I feel it too, I assure you. Like a red-hot iron, it takes a long time for it to cool. But I look at the lost lives and think, what would they want?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[101]`
**[WYBÓR GRACZA: "“I assure you, this administration will do its absolute best to mend the wounds.”"]** — Mówca: **Player**
> "“I assure you, this administration will do its absolute best to mend the wounds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[102]`
**[WYBÓR GRACZA: "“Despite attempts to divide us, our people will stand as one. We are Sord. We are Blud. We are all united under one flag.”"]** — Mówca: **Player**
> "“Despite attempts to divide us, our people will stand as one. We are Sord. We are Blud. We are all united under one flag.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[103]`
**[WYBÓR GRACZA: "“We are all the same before God. Remember the words: 'Love thy brothers and thy sisters.'”"]** — Mówca: **Player**
> "“We are all the same before God. Remember the words: 'Love thy brothers and thy sisters.'”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[104]`
  - -> `[107]`

### Węzeł `[104]`
**[WYBÓR GRACZA: "“Let this be a testament of our unity for future generations! Let's stand together as Blud and Sord.”"]** — Mówca: **Player**
> "“Let this be a testament of our unity for future generations! Let's stand together as Blud and Sord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "“I feel responsible and ashamed for the actions of my predecessors. Most of all, I feel the desperation to remove this black mark from our history.”"]** — Mówca: **Player**
> "“I feel responsible and ashamed for the actions of my predecessors. Most of all, I feel the desperation to remove this black mark from our history.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[106]`
**[WYBÓR GRACZA: "“We must always stay together in the face of adversity. Against all odds.”"]** — Mówca: **Player**
> "“We must always stay together in the face of adversity. Against all odds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[104]`
  - -> `[107]`

### Węzeł `[107]`
**[WYBÓR GRACZA: "“Mistakes were made. The innocent people of Izzam paid the price. But we cannot let the past divide us.”"]** — Mówca: **Player**
> "“Mistakes were made. The innocent people of Izzam paid the price. But we cannot let the past divide us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[108]`
**[WYBÓR GRACZA: "“I need help from each and every one of you. To make this country a better place for everyone.”"]** — Mówca: **Player**
> "“I need help from each and every one of you. To make this country a better place for everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[111]`
  - -> `[284]`

### Węzeł `[109]`
**[WYBÓR GRACZA: "“The responsibility falls on all of our shoulders. Because we don't have anyone but each other.”"]** — Mówca: **Player**
> "“The responsibility falls on all of our shoulders. Because we don't have anyone but each other.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[111]`
  - -> `[284]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "“Yollak Bluderat!”"]** — Mówca: **Player**
> "“Yollak Bluderat!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[111]`
**[WYBÓR GRACZA: "“Morning will come!”"]** — Mówca: **Player**
> "“Morning will come!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[112]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Narrator**
> "There was no reaction from the crowd. Only silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[114]`
Mówca: **Narrator**
> "An old man from the crowd yelled: "Your flag! Your nation!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[117]`
  - -> `[118]`

### Węzeł `[115]`
Mówca: **Narrator**
> "An old man from the crowd yelled: "Revenge!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[119]`
  - -> `[120]`

### Węzeł `[116]`
Mówca: **Narrator**
> "An old man from the crowd yelled: "Bullshit!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[122]`
  - -> `[121]`

### Węzeł `[117]`
**[WYBÓR GRACZA: "“Don't play into the hands of the separationists. United we stand. Divided we fall.”"]** — Mówca: **Player**
> "“Don't play into the hands of the separationists. United we stand. Divided we fall.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[103]`
  - -> `[106]`

### Węzeł `[118]`
**[WYBÓR GRACZA: "Pay no attention."]** — Mówca: **Player_Italic**
> "I paid no attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[103]`
  - -> `[106]`

### Węzeł `[119]`
**[WYBÓR GRACZA: "“To what end? We need to break this vicious cycle of violence and vengeance for a better future.”"]** — Mówca: **Player**
> "“To what end? We need to break this vicious cycle of violence and vengeance for a better future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[103]`
  - -> `[106]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "Pay no attention."]** — Mówca: **Player_Italic**
> "I paid no attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[103]`
  - -> `[106]`

### Węzeł `[121]`
**[WYBÓR GRACZA: "Pay no attention."]** — Mówca: **Player_Italic**
> "I paid no attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[103]`
  - -> `[106]`

### Węzeł `[122]`
**[WYBÓR GRACZA: "“Despite these kinds of attempts to divide us, we will be united as one. We will work together!”"]** — Mówca: **Player**
> "“Despite these kinds of attempts to divide us, we will be united as one. We will work together!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[103]`
  - -> `[106]`

### Węzeł `[123]`
**[WYBÓR GRACZA: "“Let me finish.”"]** — Mówca: **Player**
> "“Let me finish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[103]`
  - -> `[106]`

### Węzeł `[124]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[126]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion <= 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Narrator**
> "An old man from the crowd yelled: "He is right!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[103]`
  - -> `[106]`

### Węzeł `[128]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[130]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion <= 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Narrator**
> "An old man from the crowd yelled: "He is right!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[103]`
  - -> `[106]`

### Węzeł `[132]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[134]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion <= 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Narrator**
> "An old man from the crowd yelled: "He speaks the truth!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[103]`
  - -> `[106]`

### Węzeł `[136]`
**[WYBÓR GRACZA: "“Let me finish.”"]** — Mówca: **Player**
> "“Let me finish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[103]`
  - -> `[106]`

### Węzeł `[137]`
**[WYBÓR GRACZA: "“Let me finish.”"]** — Mówca: **Player**
> "“Let me finish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[103]`
  - -> `[106]`

### Węzeł `[138]`
**[WYBÓR GRACZA: "“Are you with me?”"]** — Mówca: **Player**
> "“Are you with me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[139]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`
  - -> `[112]`

### Węzeł `[140]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`
  - -> `[112]`

### Węzeł `[141]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction += 1;
BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[283]`

### Węzeł `[142]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction += 1;
BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[100]`
  - -> `[101]`

### Węzeł `[143]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction += 3;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`
  - -> `[112]`

### Węzeł `[144]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction += 3;
BaseGame.Public_Opinion -= 1;
BaseGame.Sollist -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] + 3;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[145]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction -= 1;
BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] - 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[146]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction += 1;
BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[147]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction -= 2;
BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] - 2;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[148]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction -= 5;
BaseGame.Public_Opinion += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] - 5;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[149]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction -= 2;
BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] - 2;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[150]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction > -1 && BaseGame.Bludish_Opinion > -6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction > -1 && BaseGame.Bludish_Opinion > -6)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] > -1  and  Variable["BaseGame.Bludish_Opinion"] > -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[152]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction > -1 && BaseGame.Bludish_Opinion > -6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] > -1  and  Variable["BaseGame.Bludish_Opinion"] > -6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[153]`
Mówca: **Narrator**
> "Mansoun leaned in closer to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[154]`
Mówca: **Narrator**
> "Lucian looked at me worriedly. People started coming closer and closer to us, chanting "Yollak Bluderat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[155]`
Mówca: **Narrator**
> "I was immediately surrounded by the security detail I had brought with me. They had drawn their guns and were pointing them at the approaching crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Lucian Galade**
> "“We must leave, sir. Now!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[157]`
Mówca: **Narrator**
> "There was the deafening noise of machine gun fire. I closed my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[158]`
Mówca: **Narrator**
> "Everything became a blur. The guards circled around me, shielding me from the chaos."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Narrator**
> "They escorted me to our vehicle in a matter of seconds. I heard more gunshots as we drove out of Erzaren."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[160]`
Mówca: **Mansoun Leke**
> "“I must admit, Mr. President. That was a good speech.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`
  - -> `[163]`

### Węzeł `[161]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[162]`
**[WYBÓR GRACZA: "“Just doing my duty.”"]** — Mówca: **Player**
> "“Just doing my duty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[163]`
**[WYBÓR GRACZA: "“I hope the crowd thinks the same.”"]** — Mówca: **Player**
> "“I hope the crowd thinks the same.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Narrator**
> "He extended his hand to me for a handshake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[165]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Italic**
> "As we shook hands, the crowd started to clap."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[166]`
**[WYBÓR GRACZA: "Hug him."]** — Mówca: **Player_Italic**
> "Instead of going for the handshake, I spread my arms and hugged him. Suddenly, the whole crowd erupted in applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[167]`
Mówca: **Mansoun Leke**
> "“Thank you for this, Mr. President. I don't think the people of Erzaren will ever forget this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Mansoun Leke**
> "“You have become the first and only president brave enough to come to Erzaren and pay respects to the Izzam victims. I hope this will be the start of a new era.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Mansoun Leke**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[170]`
Mówca: **Lucian Galade**
> "“Sir, it's time to go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Narrator**
> "We started making our way back to the convoy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Lucian Galade**
> "“Well done, sir. This will prove very useful in the upcoming elections.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[173]`
  - -> `[175]`
  - -> `[290]`

### Węzeł `[173]`
**[WYBÓR GRACZA: "“What's the rush?”"]** — Mówca: **Player**
> "“What's the rush?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[174]`
**[WYBÓR GRACZA: "“Exactly my plan.”"]** — Mówca: **Player**
> "“Exactly my plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[175]`
**[WYBÓR GRACZA: "“Time will tell.”"]** — Mówca: **Player**
> "“Time will tell.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Narrator**
> "Lucian bowed his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Narrator**
> "We entered our vehicles and started making our way back home from Erzaren."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[178]`
Mówca: **Narrator**
> "Lucian grabbed my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Lucian Galade**
> "“We must leave. Now!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Narrator**
> "With only our personal guards protecting us against a crowd of thousands, we starting making our way back to the cars hastily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Narrator**
> "The convoy started driving away as soon as we were seated. The windows of the vehicles were completely covered with rotten vegetables, eggs and splatters of paint by the time we finally left the city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[182]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn08_A_AschrafAnniversary = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn08_A_AschrafAnniversary"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[183]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion -= 10)*
- **Efekt (`userScript`):** `Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[184]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[185]`
Mówca: **Lucian Galade**
> "“I must say this was a good decision, sir. This will help ease tensions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[9]`
  - -> `[12]`

### Węzeł `[186]`
**[WYBÓR GRACZA: "“Yes. But I am still worried about our safety.”"]** — Mówca: **Player**
> "“Yes. But I am still worried about our safety.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[187]`
Mówca: **Narrator**
> "We entered the historic center wearing flak vests, transported by an armored personnel carrier. I gazed out its windows at the city's rundown buildings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[188]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[191]`
Mówca: **Narrator**
> "There was an outcry from the crowd. Hundreds of people shouted slurs at us while keeping their distance. The heavy weaponry that the security carried seemed to have startled them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[192]`
Mówca: **Narrator**
> "The ceremonies were to be held in the aptly named Izzam Square, several blocks away from Lake Soll and the sunken ruins of the village of Izzam."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[193]`
Mówca: **Narrator**
> "We entered the historic center in the presidential Kadilla. The streets were littered with broken glass and the walls defaced with graffiti. I sensed a heavy regional police presence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[194]`
Mówca: **Narrator**
> "The local police forces did their best to calm the angry crowd and pushed them away from our vehicle. I suddenly had the feeling that our forces were in danger of being overwhelmed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[195]`
Mówca: **Narrator**
> "After a few hours' drive, we finally arrived in the ancient walled city of Erzaren."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[196]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[199]`
Mówca: **Lucian Galade**
> "“They seem to be chanting your name, sir. I believe they are happy with their new autonomy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[200]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Centralization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Centralization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Centralization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[203]`
Mówca: **Narrator**
> "The crowd before me had signs in their hands protesting my decision to centralize Bergia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[204]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= -10 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= -10 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= -10  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion <= -10 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= -10  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[207]`
Mówca: **Mansoun Leke**
> "“Very perceptive of you. I wonder why that is the case...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[208]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Arrest_FetihEjall == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Arrest_FetihEjall == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or  Variable["BaseGame.Arrest_FetihEjall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[210]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Arrest_FetihEjall == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or  Variable["BaseGame.Arrest_FetihEjall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[211]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Arrest_FetihEjall == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Arrest_FetihEjall == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or  Variable["BaseGame.Arrest_FetihEjall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[213]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Arrest_FetihEjall == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or  Variable["BaseGame.Arrest_FetihEjall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[214]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Arrest_FetihEjall == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Arrest_FetihEjall == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or  Variable["BaseGame.Arrest_FetihEjall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[216]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Arrest_FetihEjall == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or  Variable["BaseGame.Arrest_FetihEjall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[217]`
Mówca: **Narrator**
> "Someone from the crowd shouted at me, breaking the silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[218]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[221]`
Mówca: **Narrator**
> "I noticed an excessively high amount of regional police, as well as the gendarmerie and local police. They formed a human barricade around the square, staring intimidatingly at the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[222]`
Mówca: **Lucian Galade**
> "“Must be the governor's doing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[223]`
Mówca: **Narrator**
> "Some people started shouting at me, breaking the silence. One man managed to break the security cordon and ran towards me, screaming."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[224]`
Mówca: **Narrator**
> "Noticing I had no candle in my hand, someone in the crowd shouted at me, breaking the silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[225]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Ersen == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Ersen == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Ersen"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[227]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Ersen == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Ersen"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[228]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true || BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true || BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true  or  Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true || BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true  or  Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Narrator**
> "Before he could get to me, security forces grabbed the man and dragged him away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[232]`
Mówca: **Narrator**
> "Before he could get to me, one of my presidential guards grabbed the man and dragged him away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[233]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true || BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true || BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true  or  Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true || BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true  or  Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Narrator**
> "Before I could react, security forces grabbed the man and dragged him away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[237]`
**[WYBÓR GRACZA: "Keep walking."]** — Mówca: **Player_Italic**
> "I ignored the man and kept walking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[238]`
**[WYBÓR GRACZA: "Signal security to detain him."]** — Mówca: **Player_Italic**
> "Before I finished my gesture, security forces grabbed the man and dragged him away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Narrator**
> "Mansoun looked at me with a mix of fear and anger in his eyes, but he knew better than to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[240]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle == true || BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle == true || BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle"] == true  or  Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[242]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle == true || BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle"] == true  or  Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[243]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction -= 2;
BaseGame.Public_Opinion += 1;
BaseGame.Democratic -= 1;
BaseGame.Sollist += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] - 2;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[244]`
Mówca: **Narrator**
> "We entered the historic center wearing flak vests, transported by an armored personnel carrier. The streets were littered with broken glass and the walls defaced with graffiti. I sensed a heavy regional police presence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[245]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Ersen == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Ersen == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Ersen"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[247]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Ersen == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Ersen"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Narrator**
> "We entered the historic center in the presidential Kadilla. I gazed out its windows at the city's rundown buildings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[249]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[252]`
Mówca: **Lucian Galade**
> "“I must say this was a good decision, sir. After giving the Bludish autonomy, this will send a strong message that you are on their side. But I hope bringing this much security won't cause any problems.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[9]`
  - -> `[12]`

### Węzeł `[253]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[256]`
Mówca: **Lucian Galade**
> "“I must say this was a good decision, sir. After giving the Bludish autonomy, this will send a strong message that you are on their side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[9]`
  - -> `[12]`

### Węzeł `[257]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[259]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[260]`
Mówca: **Narrator**
> "A large crowd had assembled in the square. There were probably at least ten thousand people. Most of them were yelling insults and obscenities at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[261]`
Mówca: **Mansoun Leke**
> "“I suppose the governor's huge army wasn't enough. Bergia has already become a police state. A truly *special* zone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`
  - -> `[278]`

### Węzeł `[262]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[264]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[265]`
Mówca: **Mansoun Leke**
> "“I don't know what your intention is, but I only ask of you to at least be respectful during the ceremony, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`
  - -> `[278]`

### Węzeł `[266]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[267]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[268]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[269]`
Mówca: **Narrator**
> "He pointed at the gendarmerie forces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[270]`
Mówca: **Mansoun Leke**
> "“I am not sure how bringing your army will help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[48]`
  - -> `[50]`
  - -> `[271]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“It's the governor's doing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[272]`
**[WYBÓR GRACZA: "“They are not my army. They protect the Special Region of Bergia.”"]** — Mówca: **Player**
> "“They are not my army. They protect the Special Region of Bergia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[273]`
Mówca: **Mansoun Leke**
> "“The man who abuses his authority to oppress Bergia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`
  - -> `[276]`

### Węzeł `[274]`
**[WYBÓR GRACZA: "“Let's just move on, Mr. Leke.”"]** — Mówca: **Player**
> "“Let's just move on, Mr. Leke.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I am supportive of you, Mr. Leke. I want him gone as much as you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We are trying our best to contain him, but without changing the laws there's nothing I can do about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
Mówca: **Narrator**
> "He clenched his jaw."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[278]`
**[WYBÓR GRACZA: "“My only intention is to stand in solidarity with our Bludish people.”"]** — Mówca: **Player**
> "“My only intention is to stand in solidarity with our Bludish people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[279]`
**[WYBÓR GRACZA: "“Let's just move on, Mr. Leke.”"]** — Mówca: **Player**
> "“Let's just move on, Mr. Leke.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[280]`
**[WYBÓR GRACZA: "“Watch your words. You are speaking to the president.”"]** — Mówca: **Player**
> "“Watch your words. You are speaking to the president.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[281]`
Mówca: **Narrator**
> "He raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[282]`
**[WYBÓR GRACZA: "Leave the candle next to it."]** — Mówca: **Player_Italic**
> "I put the candle next to the torch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[283]`
**[WYBÓR GRACZA: "“We are here to mourn those who, tragically, lost their lives in Izzam.”"]** — Mówca: **Player**
> "“We are here to mourn those who, tragically, lost their lives in Izzam.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[97]`
  - -> `[99]`

### Węzeł `[284]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true || BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true || BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true  or  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[286]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true || BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true  or  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[287]`
**[WYBÓR GRACZA: "“To our unity!”"]** — Mówca: **Player**
> "“To our unity!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[288]`
Mówca: **Narrator**
> "One man broke the silence and shouted "Do not listen to murderers!", and threw a tomato. It hit the ground right in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[289]`
Mówca: **Narrator**
> "Lucian rushed over to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[290]`
**[WYBÓR GRACZA: "“Not everything is about votes.”"]** — Mówca: **Player**
> "“Not everything is about votes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[291]`
Mówca: **Lucian Galade**
> "“It's not?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[292]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[295]`
Mówca: **Narrator**
> ""Despite ultranationalists, we keep marching!" shouted a group of people in the very front, who also started waving the flags of the Workers Party of Bludia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[296]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn07_LanguageBill_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn07_LanguageBill_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn07_LanguageBill_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Narrator**
> ""You cannot claim that you support us after trying to kill our language!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_JointOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Narrator**
> ""What were you doing in Wehlen against our people? You are responsible of the deaths of thousands!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[304]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_DefendBorder == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Narrator**
> ""You supported Murderer Smolak in his crusade against our people! You denied entry to innocent refugees! You are responsible for the deaths of thousands!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[308]`
Mówca: **Narrator**
> "There was a moment of complete silence. Then, the whole crowd erupted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[309]`
Mówca: **Narrator**
> "I was immediately surrounded by the local police forces. They had drawn their guns and were pointing them at the approaching crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[310]`
Mówca: **Narrator**
> "Hearing the chaos, regional police forces and the gendarmerie also rushed to our aid. Suddenly, the entire crowd was surrounded by an army."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Narrator**
> "As the security forces pushed everyone away, the presidential guard escorted us back to our vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[312]`
Mówca: **Lucian Galade**
> "“Sir, I think we must leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[313]`
Mówca: **Lucian Galade**
> "“That was close.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`
  - -> `[315]`
  - -> `[316]`

### Węzeł `[314]`
**[WYBÓR GRACZA: "“I'm glad I brought this much security.”"]** — Mówca: **Player**
> "“I'm glad I brought this much security.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[315]`
**[WYBÓR GRACZA: "“They will pay for this.”"]** — Mówca: **Player**
> "“They will pay for this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[316]`
**[WYBÓR GRACZA: "“We should have been more careful.”"]** — Mówca: **Player**
> "“We should have been more careful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[317]`
Mówca: **Narrator**
> "We entered our vehicles and starting making our way back home from Erzaren."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[318]`
Mówca: **Narrator**
> "I turned to follow him. Just then, someone yelled "Yollak Bluderat" and dashed towards us with a knife."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[319]`
Mówca: **Narrator**
> "The noise stopped. I gathered up the courage to open my eyes again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Narrator**
> "The man had fallen to the ground. The crowd panicked and began to scatter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[321]`
Mówca: **Narrator**
> "I looked at the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[322]`
Mówca: **Narrator**
> "A woman, probably his mother, fell on her knees right next to him and caressed his head. Her scream pierced the panic."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`
  - -> `[353]`
  - -> `[354]`
  - -> `[355]`

### Węzeł `[323]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: (BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true) || BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: (BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true) || BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true)  or  Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[325]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !((BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true) || BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true)  or  Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[326]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn07_LanguageBill_Signed == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`
  - -> `[328]`

### Węzeł `[327]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn07_LanguageBill_Signed == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn07_LanguageBill_Signed == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[329]`
Mówca: **Mansoun Leke**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[330]`
Mówca: **Mansoun Leke**
> "“I don't know if any of this really makes a difference after what you have done against the Bludish people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Mansoun Leke**
> "“Still, you came here to Erzaren for the anniversary of the Izzam Incident. That is a good start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[332]`
Mówca: **Lucian Galade**
> "“The whole trip runs on a schedule, sir. The convoy needs to start driving now, or else we won't make it back in time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[333]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion += BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"];`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[334]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[336]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[340]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[341]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[342]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[344]`

### Węzeł `[343]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[344]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[345]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[347]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[348]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[349]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 3;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[350]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 4;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[351]`
Mówca: **Narrator**
> "I saw another body on the ground behind him. It was a boy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[352]`
**[WYBÓR GRACZA: "“That boy! Make sure he is okay!”"]** — Mówca: **Player**
> "“That boy! Make sure he is okay!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[353]`
**[WYBÓR GRACZA: "“My God.”"]** — Mówca: **Player**
> "“My God.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[354]`
**[WYBÓR GRACZA: "“Get an ambulance now!”"]** — Mówca: **Player**
> "“Get an ambulance now!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[355]`
**[WYBÓR GRACZA: "“We have to get out of here.”"]** — Mówca: **Player**
> "“We have to get out of here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[356]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_Negative = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_Negative"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[357]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_Positive = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_Positive"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[358]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true && BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true && BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true  and  Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[360]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true && BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true  and  Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[361]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_LT_Joined_Aschraf_Anniversary_Security = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_LT_Joined_Aschraf_Anniversary_Security"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_Security = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_Security"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[363]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`
  - -> `[365]`

### Węzeł `[364]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[365]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[366]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: // end)*
- **Efekt (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[367]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: (BaseGame.Bludish_Opinion >= 10 && BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction > 0) || (BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`
  - -> `[369]`

### Węzeł `[368]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: (BaseGame.Bludish_Opinion >= 10 && BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction > 0) || (BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] >= 10  and  Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] > 0)  or  (Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !((BaseGame.Bludish_Opinion >= 10 && BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction > 0) || (BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Bludish_Opinion"] >= 10  and  Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] > 0)  or  (Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[370]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishOppression = false;
BaseGame.Situation_Law_BludishProblem = false;
BaseGame.Situation_Law_BludishReconciliation = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Law_BludishOppression"] = false;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;
Variable["BaseGame.Situation_Law_BludishReconciliation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[371]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= -12)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= -12)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= -12`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion <= -12))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= -12) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[374]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishOppression = true;
BaseGame.Situation_Law_BludishProblem = false;
BaseGame.Situation_Law_BludishReconciliation = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Law_BludishOppression"] = true;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;
Variable["BaseGame.Situation_Law_BludishReconciliation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[375]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: // end)*
- **Efekt (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[376]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Bill_Turn07_LanguageBill_Signed == true && BaseGame.Reform_BludishRights_Amendment_Proposal == false && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[378]`

### Węzeł `[377]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Bill_Turn07_LanguageBill_Signed == true && BaseGame.Reform_BludishRights_Amendment_Proposal == false && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  and  Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == false  and  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[378]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Bill_Turn07_LanguageBill_Signed == true && BaseGame.Reform_BludishRights_Amendment_Proposal == false && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  and  Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == false  and  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[379]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: // end)*
- **Efekt (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[380]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[383]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: (BaseGame.Bludish_Opinion > 0 && BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction > 0) || (BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: (BaseGame.Bludish_Opinion > 0 && BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction > 0) || (BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] > 0  and  Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] > 0)  or  (Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[385]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !((BaseGame.Bludish_Opinion > 0 && BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction > 0) || (BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Bludish_Opinion"] > 0  and  Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] > 0)  or  (Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[386]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishOppression = false;
BaseGame.Situation_Law_BludishProblem = true;
BaseGame.Situation_Law_BludishReconciliation = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Law_BludishOppression"] = false;
Variable["BaseGame.Situation_Law_BludishProblem"] = true;
Variable["BaseGame.Situation_Law_BludishReconciliation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[387]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishOppression = false;
BaseGame.Situation_Law_BludishProblem = false;
BaseGame.Situation_Law_BludishReconciliation = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Law_BludishOppression"] = false;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;
Variable["BaseGame.Situation_Law_BludishReconciliation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[388]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishOppression = true;
BaseGame.Situation_Law_BludishProblem = false;
BaseGame.Situation_Law_BludishReconciliation = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Law_BludishOppression"] = true;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;
Variable["BaseGame.Situation_Law_BludishReconciliation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[389]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishOppression = false;
BaseGame.Situation_Law_BludishProblem = true;
BaseGame.Situation_Law_BludishReconciliation = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Law_BludishOppression"] = false;
Variable["BaseGame.Situation_Law_BludishProblem"] = true;
Variable["BaseGame.Situation_Law_BludishReconciliation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[390]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[391]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_AschrafCandle");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_AschrafCandle");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[392]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`
  - -> `[394]`

### Węzeł `[393]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[394]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Bron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[395]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Krull == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`
  - -> `[397]`

### Węzeł `[396]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Krull == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[397]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Krull == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[398]`
Mówca: **Narrator**
> "On our way to Erzaren, we stopped in Deyr to meet with the Governor of Bergia, Phelix Bron, to discuss the security situation within the Special Zone. He wished us luck at the event and told us to be careful before bidding us farewell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[399]`
Mówca: **Narrator**
> "On our way to Erzaren, we stopped in Deyr to meet with the Governor of Bergia, Herbert Krull, to discuss the security situation within the Special Zone. He wished us luck at the event and told us to be extremely careful before bidding us farewell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[400]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Ersen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`
  - -> `[402]`

### Węzeł `[401]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Ersen == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Ersen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[402]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Ersen == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Ersen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[403]`
Mówca: **Narrator**
> "On our way to Erzaren, we stopped in Deyr to meet with the new Governor of Bergia, Ishval Ersen, to discuss the implementation of the autonomous zone. He welcomed us with great sympathy and care, and wished us the best for the event."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[404]`
Mówca: **Narrator**
> "On our way to inner Erzaren, we stopped to meet with the local police chief, Ionas Fisser, to discuss how the abolishment of the Zone was faring for the locals."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[405]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Arrest_FetihEjall == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`
  - -> `[407]`

### Węzeł `[406]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Arrest_FetihEjall == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Arrest_FetihEjall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[407]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Arrest_FetihEjall == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Arrest_FetihEjall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Narrator**
> "I saw many signs that condemned the arrest of Fetih Ejall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[409]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_WPB == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[411]`

### Węzeł `[410]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_WPB == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Ban_WPB"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Ban_WPB == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Ban_WPB"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[412]`
Mówca: **Narrator**
> "I saw many signs that condemned the ban on the Workers' Party of Bludia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[413]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`
  - -> `[415]`

### Węzeł `[414]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[415]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion <= 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[416]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`
  - -> `[418]`

### Węzeł `[417]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[418]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion <= 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[419]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction -= 1;
BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] - 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[283]`

### Węzeł `[420]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`
  - -> `[422]`

### Węzeł `[421]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[422]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion <= 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[423]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction -= 2;
BaseGame.Public_Opinion -= 1;
BaseGame.Sollist -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] - 2;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[424]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_WillHappen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`
  - -> `[426]`

### Węzeł `[425]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_WillHappen == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_WillHappen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[426]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_BFF_WillHappen == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_WillHappen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[427]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true && BaseGame.Unrest_BFF_WillHappen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`
  - -> `[429]`

### Węzeł `[428]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true && BaseGame.Unrest_BFF_WillHappen == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true  and  Variable["BaseGame.Unrest_BFF_WillHappen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[429]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true && BaseGame.Unrest_BFF_WillHappen == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true  and  Variable["BaseGame.Unrest_BFF_WillHappen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[430]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BFF_Threatens_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`
  - -> `[432]`

### Węzeł `[431]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BFF_Threatens_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BFF_Threatens_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[432]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.BFF_Threatens_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BFF_Threatens_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[89]`
  - -> `[92]`

### Węzeł `[433]`
Mówca: **Narrator**
> "Just then, I noticed a few BFF flags waving at the very back of the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`
  - -> `[435]`

### Węzeł `[434]`
**[WYBÓR GRACZA: "Signal to Lucian."]** — Mówca: **Player_Italic**
> "I signalled to Lucian. He immediately bowed his head towards mine so I could whisper in his ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[435]`
**[WYBÓR GRACZA: "Start the speech."]** — Mówca: **Player_Italic**
> "I ignored them and started my speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[89]`
  - -> `[92]`

### Węzeł `[436]`
Mówca: **Lucian Galade**
> ""Is there something wrong, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`
  - -> `[438]`
  - -> `[439]`

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""There are people in the crowd with BFF flags. I thought security wouldn't allow such a thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not sure if I should continue with the speech, Lucian. I think we might be in danger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I saw some BFF flags. Could you please check if everything's all right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[440]`
Mówca: **Lucian Galade**
> ""Are you sure, sir? The police wouldn't have allowed those flags here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[441]`
Mówca: **Lucian Galade**
> ""Are you sure, sir? I can't see anything. The police wouldn't have allowed those flags here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[442]`
Mówca: **Lucian Galade**
> ""Do you want to cancel the speech, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[443]`
Mówca: **Narrator**
> "The crowd was getting restless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`
  - -> `[444]`

### Węzeł `[444]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Okay, never mind. I'll continue with the speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes. I want to cancel the speech. Let's leave this place immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[446]`
Mówca: **Lucian Galade**
> ""Good luck, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[89]`
  - -> `[92]`

### Węzeł `[447]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction -= 4;
BaseGame.Public_Opinion -= 1;
BaseGame.Bludish_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] - 4;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[448]`
Mówca: **Lucian Galade**
> ""Of course, sir. Please follow me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[449]`
Mówca: **Narrator**
> "We quickly made our way offstage amid surprised looks from the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[450]`
Mówca: **Narrator**
> "A man shouted, "Yes! Run away to your home! Don't ever come back here!" and threw a tomato. It hit the ground right in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[451]`
Mówca: **Narrator**
> "Lucian looked at me worriedly. People started walking closer and closer to us, chanting "Yollak Bluderat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[452]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`
  - -> `[454]`

### Węzeł `[453]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[454]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[455]`
Mówca: **Narrator**
> "There was a second of silence. Then, the entire crowd erupted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[456]`
Mówca: **Narrator**
> ""Despite ultranationalists, we keep marching!" shouted a group of people in the very front, wielding the flags of the Workers Party of Bludia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[457]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlayCustomMapMusic("Map_Music_Tense");

// Plays a custom map music after conversation is done. This works only once for one conversation)*
- **Efekt (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");
-- Plays a custom map music after conversation is done. This works only once for one conversation;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[458]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlayCustomMapMusic("Map_Music_Tense");

// Plays a custom map music after conversation is done. This works only once for one conversation)*
- **Efekt (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");
-- Plays a custom map music after conversation is done. This works only once for one conversation;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[459]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_WillHappen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`
  - -> `[461]`

### Węzeł `[460]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_WillHappen == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_WillHappen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[461]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_BFF_WillHappen == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_WillHappen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[462]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[463]`
Mówca: **Narrator**
> "<shout>"Have respect for the dead!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[464]`
Mówca: **Narrator**
> "<shout>"You cannot defile our traditions, you racist dog! At least have respect for the dead!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[465]`
Mówca: **Narrator**
> "<shout>"Don't mock the dead, you racist dog! You are defiling that candle in your hands!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[466]`
Mówca: **Narrator**
> "<shout>"Don't defile Aschraf's spirit, you racist dog! Take your hands off that candle!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[467]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlaySoundEffect("FuriousJeers");)*
- **Efekt (`userScript`):** `PlaySoundEffect("FuriousJeers");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[468]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlaySoundEffect("FuriousJeers");)*
- **Efekt (`userScript`):** `PlaySoundEffect("FuriousJeers");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[469]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlaySoundEffect("CheerCrowd");)*
- **Efekt (`userScript`):** `PlaySoundEffect("CheerCrowd");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[470]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlaySoundEffect("MachineGun");)*
- **Efekt (`userScript`):** `PlaySoundEffect("MachineGun");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
