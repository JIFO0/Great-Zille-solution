# Sordland/Turn03/Personal_HelicopterEscape

- **ID konwersacji:** `46`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/046_Personal_HelicopterEscape.md`
- **Liczba węzłów dialogowych:** 395
- **Liczba wyborów gracza:** 92

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[29]** Ewald Alphonso
- **[54]** Serge Wolkner

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGame.Relations_Ewald_Discontent`
- `BaseGame.Relations_Ewald_Friendly`
- `BaseGame.Relations_Ewald_Neutral`
- `BaseGame.Relations_Ewald_PromiseNotHarsherEPA`
- `BaseGame.Relations_Serge_Friend`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia`
- `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone`
- `BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits`
- `BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages`
- `BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameSupport.News_Turn03_HP_Address_HelicopterEscape`
- `BaseGameSupport.News_Turn03_HP_Workers_GasomExpandsCare`
- `BaseGameSupport.News_Turn03_HP_Workers_GasomGivesCharity`
- `BaseGameSupport.News_Turn03_HP_Workers_GasomIncreasesSalaries`
- `BaseGameSupport.News_Turn03_LT_Address_HelicopterEscape`
- `BaseGameSupport.News_Turn03_LT_Address_PresidentLandsLachaven`
- `BaseGameSupport.News_Turn03_LT_Workers_LUSCPSLose`
- `BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinCare`
- `BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinDonations`
- `BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinSalaries`
- `BaseGameSupport.News_Turn03_R_Workers_LUSCPSCondemn`
- `BaseGameSupport.News_Turn03_R_Workers_LUSCPSDisappointed`
- `BaseGameSupport.News_Turn03_R_Workers_LUSCPSInaction`
- `BaseGameSupport.News_Turn03_R_Workers_LUSCPSVictory`
- `BaseGameSupport.Report_Turn03_Lachaven_BlueMansionSecurity`
- `BaseGameText.AlphonsoToPlayer`

### Skoki między-konwersacyjne:
- Węzeł `[118]` -> **[47] Sordland/Turn03/Mid Conversation** (../Turn_03/047_Mid_Conversation.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 10

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[202]` (Paskal Beniwoll): `PlaySoundEffect("Helicopter");`
- Węzeł `[203]` (Paskal Beniwoll): `PlayMusic("Mountains"); ;`
- Węzeł `[367]` (Paskal Beniwoll): `Variable["BaseGameText.AlphonsoToPlayer"] ="Anton";`
- Węzeł `[375]` (Paskal Beniwoll): `End();`
- Węzeł `[385]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn03_HP_Workers_GasomExpandsCare"] = true; Variable["BaseGameSup...`
- Węzeł `[386]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn03_HP_Workers_GasomIncreasesSalaries"] = true; Variable["BaseG...`
- Węzeł `[387]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn03_HP_Workers_GasomGivesCharity"] = true; Variable["BaseGameSu...`
- Węzeł `[388]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn03_LT_Workers_LUSCPSLose"] = true; Variable["BaseGameSupport.N...`
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
  - -> `[393]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Ewald Alphonso**
> ""You've already agreed that you won't further tighten the EPA's restrictions. So I don't think I need to remind you how detrimental tighter restrictions would be to Gasom's operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[7]`
Mówca: **Ewald Alphonso**
> ""It could deter potential investors, thereby causing a ripple effect that could lead to job losses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`
  - -> `[13]`

### Węzeł `[8]`
Mówca: **Narrator**
> "The helicopter gradually reduced its speed, hovering for a moment before softly touching down on the helipad."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[309]`
  - -> `[325]`
  - -> `[310]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm committed to creating a favorable environment for businesses like Gasom. Your success translates to more jobs and prosperity for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're making it sound as if any change to the EPA would lead to an economic catastrophe. As the government, it's our duty to ensure energy security, not cater to private interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Ewald Alphonso**
> ""I'm glad to hear that, Mr. President. Your support and understanding of our challenges are essential for us to thrive and contribute to Sordland's economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[12]`
Mówca: **Ewald Alphonso**
> ""Mr. President, I assure you that it's not about private interests. It's about allowing companies like Gasom to provide energy security, drive economic growth, and create jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I hear your concerns, Mr. Alphonso. But we also have to consider Sordland's long-term energy security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Ewald Alphonso**
> ""Absolutely, Mr. President. Striking that balance is the key, and I believe we can achieve it together. Gasom is ready to be a part of the solution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Highway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Railway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[21]`
Mówca: **Narrator**
> "A patchwork of verdant fields, sprawling forests, and untouched land stretched out beneath us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Friendly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Friendly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Friendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_Friendly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Friendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Neutral == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Neutral == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Neutral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_Neutral == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Neutral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[28]`
Mówca: **Narrator**
> "The further we moved from the mountains, the more rural the landscape became. Small clusters of wooden houses and farmers' huts began to appear, their rustic charm a stark contrast to the grey concrete of Narbel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[29]`
Mówca: **Narrator**
> "We turned our attention to the stunning view below us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[30]`
Mówca: **Narrator**
> "Serge leaned forward in his seat, his eyes tracing the path of the H-3 highway through the Sordish countryside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[31]`
Mówca: **Narrator**
> "Serge's gaze traced the path of the still-in-progress L-1 railway. The ribbon of steel gleamed bright in the sun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[32]`
Mówca: **Narrator**
> "We were approaching the outskirts of Lachaven. Serge leaned forward in his seat to get a better look at the city's skyline."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
Mówca: **Serge Wolkner**
> ""It's inspiring to see the highway construction from here, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[34]`
Mówca: **Serge Wolkner**
> ""What a marvel, Mr. President. I can't wait for the new railway to transform transportation in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[35]`
Mówca: **Serge Wolkner**
> ""Lachaven... it's quite a sight, isn't it, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Friendly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Friendly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Friendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_Friendly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Friendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Neutral == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Neutral == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Neutral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_Neutral == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Neutral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[42]`
Mówca: **Ewald Alphonso**
> ""I must say, {BaseGameText.AlphonsoToPlayer}, that was quite the adventure we just had. Never a dull moment with you around, eh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
Mówca: **Ewald Alphonso**
> ""That was quite an unexpected twist back there, Mr. President. I'd hoped to celebrate our deal with a drink, not a protest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[44]`
Mówca: **Ewald Alphonso**
> ""I have to admit, Mr. President, I didn't anticipate that our meeting would come to this particular end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
Mówca: **Ewald Alphonso**
> ""Your driver did a great job escorting us out of there. He's a keeper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[46]`
Mówca: **Ewald Alphonso**
> ""But it seems we made the right choice. Your driver did a terrific job escorting us out of there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[47]`
Mówca: **Ewald Alphonso**
> ""Of course your driver had the right instincts. Escaping by helicopter was the safest choice for us both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It was an adventure, wasn't it? And I agree, Serge's assistance was invaluable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, our safety matters most. But it's unfortunate that we had to leave under those circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[50]`
Mówca: **Serge Wolkner**
> ""Mr. Alphonso, it's an honor to meet you in person. I was trained by your former driver Nouman Fevon. He always spoke highly of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[51]`
Mówca: **Ewald Alphonso**
> ""I heard from Gasom security and the local police about some armed gang activity in the area a week ago. Better safe than sorry, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[52]`
Mówca: **Narrator**
> "Alphonso had been quiet for most of the journey, but as we neared Lachaven, he finally broke his silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, I'm glad we're safe. Although i can't help but wonder whether I should have spoken to those protesters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I can always rely on Serge to get me out of a dangerous situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, it was unfortunate how the situation unfolded. But a stroke of luck that you had a helicopter at the ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A shame about the protests, but to be honest, I'm not sure we were ever going to see eye to eye. The only thing we can agree on is that Serge was right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[57]`
Mówca: **Serge Wolkner**
> ""Just doing my job, Mr. President. I'm glad we're all safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[58]`
Mówca: **Serge Wolkner**
> ""Truly unfortunate, sir. But safety always comes first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[59]`
Mówca: **Serge Wolkner**
> ""Safety comes first, Mr. President. Always.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[60]`
Mówca: **Serge Wolkner**
> ""That's what I'm here for, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[61]`
Mówca: **Serge Wolkner**
> ""I'm glad I could be of assistance, Mr. President. The important thing is that we're safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[62]`
Mówca: **Serge Wolkner**
> ""I'm just doing my job, Mr. President. Safety is top priority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[63]`
Mówca: **Ewald Alphonso**
> ""It's just a pity we couldn't tap into the potential of our meeting before all this... chaos.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[64]`
Mówca: **Ewald Alphonso**
> ""The Gasom security and local police had been warning about potential armed gang activity in the area. It was best not to take any chances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[65]`
Mówca: **Ewald Alphonso**
> ""Ah, Nouman! What a man he was. Always had a knack for lightening the mood, even in the direst of situations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Ewald Alphonso**
> ""Once we were stuck in a traffic jam for hours, and he started singing old Sordish folk songs right there in the car. He had the whole motorcade laughing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`
  - -> `[75]`

### Węzeł `[67]`
Mówca: **Ewald Alphonso**
> ""Ah, Nouman! What a man. He used to tell us the most outrageous stories to keep us entertained during long journeys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Ewald Alphonso**
> ""Once he convinced a junior aide that the presidential limo was haunted! The poor lad didn't set foot in it for a week.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`
  - -> `[84]`

### Węzeł `[69]`
Mówca: **Serge Wolkner**
> ""Mr. Alphonso, I was trained by Nouman Fevon, your former driver. He spoke often of his time serving you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[70]`
Mówca: **Serge Wolkner**
> ""Mr. Alphonso, I was trained by your former driver Nouman Fevon. He often mentioned the challenges of your presidency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Ewald Alphonso**
> ""Ah, Nouman. He was a real character. Always ready with a joke, even during the most serious of crises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Ewald Alphonso**
> ""His stories could get even the most stone-faced security agents chuckling. I hope he was a good mentor to you, Serge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`
  - -> `[93]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Serge, can you sing any Sordish folk songs to lighten the mood?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Perhaps we should add singing ability to the job requirements for presidential drivers, eh Serge?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Serge, I didn't know your job had such... unusual requirements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[76]`
Mówca: **Serge Wolkner**
> ""I'm afraid I'm not much of a singer, Mr. President. But I know how to avoid traffic jams.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[77]`
Mówca: **Serge Wolkner**
> ""I don't know about that, Mr. President. I think driving skills should be first on the list.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[78]`
Mówca: **Serge Wolkner**
> ""Well, Mr. President, you never know what skills might come in handy. But I must admit, singing isn't my strong suit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[79]`
Mówca: **Ewald Alphonso**
> ""Ha! A true professional, this one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[80]`
Mówca: **Ewald Alphonso**
> ""I'm sure your driving skills are top-notch, Serge. But a sense of humor can be just as important.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[81]`
Mówca: **Ewald Alphonso**
> ""I'm sure you've got other hidden talents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you have any stories for us, Serge?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Serge, it seems like you have a tough act to follow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Come to think of it, I do hear some strange noises in there sometimes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[85]`
Mówca: **Serge Wolkner**
> ""I'm afraid I'm not much of a storyteller, Mr. President. I'd rather keep my focus on the road.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[86]`
Mówca: **Serge Wolkner**
> ""Indeed, Mr. President. Nouman was quite a character. I do my best to serve in my own way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[87]`
Mówca: **Serge Wolkner**
> ""Whatever you hear, it's not the engine. I check up on it at least once a month to make sure it's running smoothly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[88]`
Mówca: **Ewald Alphonso**
> ""A wise approach, Serge. We wouldn't want any nervous aides running around, would we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[89]`
Mówca: **Ewald Alphonso**
> ""And you're doing it very well, from the looks of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[90]`
Mówca: **Ewald Alphonso**
> ""Well done, Serge. I'll come to you the next time I need car advice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you have any funny stories for us, Serge?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He used humor to lighten a stressful situation. I see. Ever hear of humor, Serge?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Serge, did learning from Nouman help you stay cool in a crisis?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[94]`
Mówca: **Serge Wolkner**
> ""Mr. Rayne, Nouman had his style, and I have mine. I believe in maintaining professionalism at all times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[95]`
Mówca: **Serge Wolkner**
> ""Of course, Mr. President. But I've found that focus and competence are more effective in managing stress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[96]`
Mówca: **Serge Wolkner**
> ""Mr. President, Nouman's lessons were invaluable, but I have tried to develop my own style.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[97]`
Mówca: **Ewald Alphonso**
> ""I see, Serge. Different strokes for different folks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[98]`
Mówca: **Ewald Alphonso**
> ""I'd pay good money to see this one in a car with Nouman. A straight man and a cut-up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[99]`
Mówca: **Ewald Alphonso**
> ""It's important to forge your own path, Serge. I respect that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[100]`
Mówca: **Serge Wolkner**
> ""The H-3 has the potential to connect the nation in a way we've never seen before. Your legacy will be etched into the very landscape of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[101]`
Mówca: **Serge Wolkner**
> ""Seeing it from above is like witnessing history in the making.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[102]`
Mówca: **Serge Wolkner**
> ""Historical, yet modern. There's something special about this city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[103]`
Mówca: **Ewald Alphonso**
> ""The H-3 highway... you know, {BaseGameText.AlphonsoToPlayer}, I was initially skeptical. But it could become a lifeline for our rural regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[104]`
Mówca: **Ewald Alphonso**
> ""Economically, the H-3 highway was a sound decision. It's a visible symbol of progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[105]`
Mówca: **Ewald Alphonso**
> ""I suppose the highway will have its benefits, but I can't help but think the funds could have been better allocated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[106]`
Mówca: **Ewald Alphonso**
> ""Serge may be right. You could make a significant impact.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`
  - -> `[111]`

### Węzeł `[107]`
Mówca: **Ewald Alphonso**
> ""Its impact on rural areas is still up for debate, however.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`
  - -> `[111]`

### Węzeł `[108]`
Mówca: **Ewald Alphonso**
> ""To a project with a more immediate impact, perhaps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`
  - -> `[111]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The returns might not be immediate. But I truly think the highway will pay off in the long term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Just wait until it's completed, Sordland will make progress in leaps and bounds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Some of my ministers had concerns as well. But I believe the H-3 was a solid investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's a symbol of Sordland's past as well as its future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It shows the complexity of our nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""There are some issues, but with your foundation, you're already making a difference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Just wait until it's completed. Logistical operations in Sordland will never be the same again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, it's ambitious. But great change often requires bold decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your man Gus Manger made an especially convincing case for the railway's construction. I hope he was right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[118]`
Mówca: **Narrator**
> "I peered out the window at the looming cityscape of Lachaven was quickly enlarging. The sea was visible in the distance, its blue surface dotted with cargo ships."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `47` (*Sordland/Turn03/Mid Conversation*), Węzeł `[1]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Friendly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Friendly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Friendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_Friendly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Friendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Neutral == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Neutral == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Neutral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_Neutral == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Neutral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Ewald Alphonso**
> ""An ambitious project, to be sure. But you'll need to ensure it doesn't become a white elephant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Ewald Alphonso**
> ""The L-1 railway... quite an investment. I hope it will not turn out to be a financial burden in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`
  - -> `[117]`

### Węzeł `[127]`
Mówca: **Ewald Alphonso**
> ""It's a fine line you're treading.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`
  - -> `[117]`

### Węzeł `[128]`
Mówca: **Ewald Alphonso**
> ""The L-1 railway. Now that's a project I can stand behind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Ewald Alphonso**
> ""It's not only efficient, it's a statement. It shows that Sordland is ready for the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`
  - -> `[117]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Friendly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Friendly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Friendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_Friendly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Friendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Neutral == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Neutral == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Neutral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_Neutral == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Neutral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Ewald Alphonso**
> ""What a city. It nearly brings me to tears every time I see it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Ewald Alphonso**
> ""Lachaven... it's a symbol of our nation, in both a good and bad way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Ewald Alphonso**
> ""But Lachaven has its issues, like any other city. We mustn't forget that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`
  - -> `[114]`
  - -> `[394]`
  - -> `[369]`

### Węzeł `[139]`
Mówca: **Ewald Alphonso**
> ""Wealth and poverty, side by side... it's a stark reminder of how much work people like us have left to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`
  - -> `[114]`
  - -> `[394]`
  - -> `[369]`

### Węzeł `[140]`
Mówca: **Ewald Alphonso**
> ""Ah, Lachaven... ‘The Gateway of Sordland’.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Ewald Alphonso**
> ""It truly is the heart of our nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`
  - -> `[114]`
  - -> `[394]`
  - -> `[369]`

### Węzeł `[142]`
Mówca: **Serge Wolkner**
> ""My apologies, gentlemen. I didn't mean to dominate the conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`
  - -> `[147]`
  - -> `[148]`
  - -> `[149]`

### Węzeł `[143]`
Mówca: **Serge Wolkner**
> ""It moves me to think about how many citizens' lives will change because of your project, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[144]`
Mówca: **Serge Wolkner**
> ""A revolutionary vision from a visionary president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[145]`
Mówca: **Serge Wolkner**
> ""I can't imagine what it must be like to live here. Something exciting happening every day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You prefer to keep things professional, right? Let's do that going forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Who needs Nouman's entertainment when we can listen to Serge Wolkner rhapsodizing about Sordland?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No need to apologize, Serge. It's always a pleasure to listen to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's quite all right. But I do have a few more things I'd like to bring up with Mr. Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[150]`
Mówca: **Serge Wolkner**
> ""Understood, Mr. President. I'll make sure to keep that in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[151]`
Mówca: **Serge Wolkner**
> ""It's true, Mr. President. I couldn't stay silent in the face of such a beautiful sight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[152]`
Mówca: **Serge Wolkner**
> ""I appreciate you saying that, Mr. President. Sordland has always been my great love.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[153]`
Mówca: **Serge Wolkner**
> ""Certainly, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Narrator**
> "As we began our descent towards the Blue Mansion, Alphonso shifted the conversation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[155]`
Mówca: **Ewald Alphonso**
> ""We're approximately 25 minutes away from the Blue Mansion State Building, {BaseGameText.AlphonsoToPlayer}.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That sounds promising. These initiatives could significantly improve workers' lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's an ambitious plan. I hope you can execute it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[179]`
Mówca: **Ewald Alphonso**
> ""I can't thank you enough for Sordland's heavy investment in Gasom. Thanks to you, we'll be able to expand operations enough to meet both Sordish and global demand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[180]`
Mówca: **Ewald Alphonso**
> ""Galmland, Qinal, and Anraka have all indicated their willingness to invest. If we were to eventually remove the EPA, the influx of foreign money could lead to significant profit for the state in the next round of investments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`
  - -> `[185]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's a bold move, but it could indeed create an economic upswing. I'll consider raising the foreign ownership limit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We must also consider the potential risks. Aren't you worried that increasing foreign ownership could lead to less control over our energy resources?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Ewald Alphonso**
> ""I'm glad to hear that, Mr. President. This could mark a new era of prosperity for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[184]`
Mówca: **Ewald Alphonso**
> ""Maintaining control and ensuring energy security are indeed important.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your argument is compelling, but it's a complex issue. I'll consider your recommendation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Ewald Alphonso**
> ""I appreciate your open-mindedness, Mr. President. All I ask is that we approach this with a clear vision of the economic potential it could unlock for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[187]`
Mówca: **Ewald Alphonso**
> ""Mr. President, this strategic partnership with Rizia in Gasom is a promising step forward. It allows us to spread the initial risks and invites additional interest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[188]`
Mówca: **Ewald Alphonso**
> ""Of course they'd be a controversial partner, but as long as they hold a minority stake, we shouldn't face any significant issues. Qinal is also showing interest, by the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`
  - -> `[193]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand your points, Mr. Alphonso, but we need to consider national security. Inviting multiple foreign powers into Sordland's energy sector could lead to problems down the line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Alphonso, don't you think we're gambling a bit too much with the future of our energy sector? What if Rumburg decides to use their stake for political leverage?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Ewald Alphonso**
> ""National security is paramount, {BaseGameText.AlphonsoToPlayer}. But we also need to consider the economic potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[192]`
Mówca: **Ewald Alphonso**
> ""Rumburg's involvement could indeed be a double-edged sword. But we must remember that their stake would be a minority one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is a bold move. But it could indeed provide a much-needed boost to our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Ewald Alphonso**
> ""In my experience, fortune favors the bold. We're not only securing Gasom's future but also placing Sordland on the global energy map.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[195]`
Mówca: **Ewald Alphonso**
> ""I'm especially concerned now that it's become clear that Sordland is abandoning Gasom to its fate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[196]`
Mówca: **Ewald Alphonso**
> ""And that's not a prospect I relish. We're truly caught between a rock and a hard place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`
  - -> `[200]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I must say I'm disappointed that we are in this situation. As the chair of Gasom, you should have anticipated these challenges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're Gasom's chair. Can't you find a way  to save the company without risking our sovereignty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[199]`
Mówca: **Ewald Alphonso**
> ""Yes, the situation is far from ideal. But I assure you, we've done our best under the circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This conversation seems to revolve around accommodating foreign investors rather than serving Sordland. We shouldn't prioritize the interests of capitalists over our own citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Ewald Alphonso**
> ""Capital is a tool. Used properly, it can bring prosperity and create jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Helicopter");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Helicopter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayMusic("Mountains");)*
- **Efekt (`userScript`):** `PlayMusic("Mountains");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[204]`
Mówca: **Ewald Alphonso**
> ""I worry that Sordland's unwillingness to invest in its own gas company might be perceived as a sign of weakness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`
  - -> `[207]`

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Our strength is not measured by how much we invest, but how wisely we use our resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We're showing that we can't be bought or influenced by money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Strength can also mean resisting the urge to chase after every opportunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[208]`
Mówca: **Ewald Alphonso**
> ""Wise words, Mr. President, but if you truly believed them, you would have invested.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[209]`
Mówca: **Ewald Alphonso**
> ""A strong stance. But we must also remember that money is a tool, and it can be used to shape our destiny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[210]`
Mówca: **Ewald Alphonso**
> ""Perhaps. We'll have to see how this approach pans out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[211]`
Mówca: **Ewald Alphonso**
> ""Your government's large investment in Gasom will undoubtedly drive our economy forward and give us a stronger position in the global market.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`
  - -> `[214]`

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Exactly. We're setting a strong foundation for future growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is our chance to make Sordland a global leader in energy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We're showing the world that Sordland is open for business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[215]`
Mówca: **Ewald Alphonso**
> ""Indeed, {BaseGameText.AlphonsoToPlayer}. It's a move that will echo positively in our history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[216]`
Mówca: **Ewald Alphonso**
> ""Absolutely, we're not just making an investment; we're making a statement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[217]`
Mówca: **Ewald Alphonso**
> ""That's right, {BaseGameText.AlphonsoToPlayer}. It's a strong message, and the world is certainly watching.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[218]`
Mówca: **Ewald Alphonso**
> ""I'm sure that you agree it's important to maintain autonomy, even while co-investing with Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`
  - -> `[221]`

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Agreed. We need to ensure our sovereignty isn't compromised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I see this as an opportunity to learn and grow together with the Kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Our collaboration is a mere stepping stone to bigger and better opportunities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[222]`
Mówca: **Ewald Alphonso**
> ""Exactly, {BaseGameText.AlphonsoToPlayer}. Maintaining control is crucial, even as we build stronger alliances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[223]`
Mówca: **Ewald Alphonso**
> ""Indeed, we can definitely learn a lot from each other in this partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[224]`
Mówca: **Ewald Alphonso**
> ""I share your optimism, Mr. President. The potential for growth is certainly exciting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[225]`
Mówca: **Ewald Alphonso**
> ""I'm considering initiatives to provide private housing, health, and education support for our blue-collar workers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[168]`
  - -> `[169]`
  - -> `[229]`

### Węzeł `[226]`
Mówca: **Ewald Alphonso**
> ""We need to ensure they're receiving competitive compensation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[233]`
  - -> `[234]`
  - -> `[235]`

### Węzeł `[227]`
Mówca: **Ewald Alphonso**
> ""I'm considering supporting local charities in Narbel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[239]`
  - -> `[240]`
  - -> `[241]`

### Węzeł `[228]`
Mówca: **Ewald Alphonso**
> ""Our company will do its best with the means it has.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[245]`
  - -> `[246]`
  - -> `[247]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm glad you're thinking along these lines. I expect more than mere consideration, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[230]`
Mówca: **Ewald Alphonso**
> ""Thank you. I believe the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[231]`
Mówca: **Ewald Alphonso**
> ""I share your sentiment. It's time to turn these ideas into tangible actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[232]`
Mówca: **Ewald Alphonso**
> ""You're absolutely right. It's about making these plans a reality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's a step in the right direction. Fair wages are fundamental to worker satisfaction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm glad to hear that. As long as this review isn't merely a token gesture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's long overdue. I hope to see substantial improvements in their remuneration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[236]`
Mówca: **Ewald Alphonso**
> ""I agree. A satisfied workforce is a productive one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[237]`
Mówca: **Ewald Alphonso**
> ""I assure you, this won't be just for show. We're committed to making real changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[238]`
Mówca: **Ewald Alphonso**
> ""I understand your concerns. We'll strive to make this review beneficial for our workers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's a positive direction. I hope to see Gasom leading the way in corporate responsibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good thinking. But remember, sustainability is more than just philanthropy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's high time. I expect these considerations to translate into substantial changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[242]`
Mówca: **Ewald Alphonso**
> ""Thank you. We hope to set a good example for other Sordish corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[243]`
Mówca: **Ewald Alphonso**
> ""Absolutely. We're looking at a comprehensive approach, beyond just charity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[244]`
Mówca: **Ewald Alphonso**
> ""Of course, {BaseGameText.AlphonsoToPlayer}. You can count on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I appreciate your concern for Gasom's economic contribution, but it's crucial not to overlook the welfare of the workers and the community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's a narrow view, Alphonso. As Gasom grows, its social responsibilities should grow in tandem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Maintaining the status quo is not enough. Gasom needs to be a part of the solution, not the problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[248]`
Mówca: **Ewald Alphonso**
> ""I assure you that we always strive to balance business growth with social responsibility. It's the Gasom way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[249]`
Mówca: **Ewald Alphonso**
> ""A valid point. We will need to reassess our priorities as we move forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[250]`
Mówca: **Ewald Alphonso**
> ""I appreciate your input, {BaseGameText.AlphonsoToPlayer}. I'll take your thoughts into consideration as we plan for the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[251]`
Mówca: **Narrator**
> "He looked out the window and yawned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[252]`
Mówca: **Narrator**
> "Alphonso scribbled something on his notepad and passed it to one of his assistants in the helicopter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[253]`
Mówca: **Ewald Alphonso**
> ""Following our earlier conversation, I've been contemplating how Gasom can play a larger role in supporting our workers and the community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[254]`
Mówca: **Ewald Alphonso**
> ""Based on our earlier discussion, I'm going to push for a review of our workers' salaries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[255]`
Mówca: **Ewald Alphonso**
> ""In light of our discussion today, I've been thinking about how Gasom can implement sustainable practices and enhance our community engagement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[256]`
Mówca: **Ewald Alphonso**
> ""As for Gasom itself, we need to focus on maintaining our current bottom line rather than stretching ourselves thin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As long as Gasom is doing well, I'm not concerned about how you choose to distribute your resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
Mówca: **Ewald Alphonso**
> ""I appreciate your trust in Gasom's management.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The financial situation of Gasom's employees is not my concern. They're paid for their work, aren't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[260]`
Mówca: **Ewald Alphonso**
> ""Yes, they are. Our company has some of the country's best-paid engineering jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As long as the workers are doing their jobs and Gasom is profitable, I see no reason to change anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Ewald Alphonso**
> ""I appreciate your pragmatic approach. But investing in our workers' welfare can also lead to increased productivity and profitability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your ideas are commendable, but they're not my priority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Ewald Alphonso**
> ""I understand. But I do believe that more engagement with the community around us will have a positive impact on our productivity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Narrator**
> "Republic Avenue stretched directly beneath us, a grand boulevard lined with palm trees and decorated with sculptures. Even from this height, landmarks like the Evaria Gallery of Art, the Maroon Theatre, and the Lachaven Opera House were discernible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[266]`
Mówca: **Narrator**
> "We were hovering over Lachaven now. The entire city was visible below us, its activity concentrated on its bustling port."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[267]`
Mówca: **Ewald Alphonso**
> ""One last thing before we land. I've been hearing noise about your administration making changes to the Energy Protection Act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
Mówca: **Ewald Alphonso**
> ""You might remember that I struggled to repeal it during my term, and that said struggle was in vain. The Energy Protection Act of 1932 remains in force, and the restrictions on foreign ownership of energy companies in Sordland persist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Ewald Alphonso**
> ""The vote was 179 against the repeal to 71 in favor. The status quo prevailed, as it has to this day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`
  - -> `[272]`
  - -> `[273]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand why you sponsored the motion. But you of all people should understand the importance of protecting Sordland's crucial energy sector.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The defeat of the repeal was a setback for our plans to liberalize the economy. We must strategize and push for it in the next Assembly session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm glad the repeal was defeated. We should not open our energy sector to foreign control. We must prioritize Sordland's sovereignty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The defeat of the repeal wasn't surprising given the political climate. I'd rather focus my efforts elsewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[274]`
Mówca: **Ewald Alphonso**
> ""Of course I do. But I also understand that the right amount of foreign investment could rejuvenate both our energy sector and our economy as a whole.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[275]`
Mówca: **Ewald Alphonso**
> ""I agree. It's clear that you'll need a different approach to win over the majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[276]`
Mówca: **Ewald Alphonso**
> ""I still believe that the repeal would have attracted much-needed foreign investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[277]`
Mówca: **Ewald Alphonso**
> ""We must be pragmatic and pick our battles. This is *the* battle to fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[278]`
Mówca: **Ewald Alphonso**
> ""I'm still mulling over the implications of your investment decision, by the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Gasom Invest Choice Talk)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[280]`
Mówca: **Narrator**
> "I cast my gaze over the harbor teeming with ships and the distinctive buildings of downtown. Their Lespian-style architecture lent the skyline a flavor unlike anywhere else in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[281]`
Mówca: **Ewald Alphonso**
> ""With that stage set, I believe an increase in the foreign ownership limit to 49% under the Energy Protection Act would attract considerable international investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[282]`
Mówca: **Ewald Alphonso**
> ""However, with the right regulatory framework, we can do both while still benefiting from foreign investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Ewald Alphonso**
> ""Our foundation is strong, and our potential is limitless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[285]`
  - -> `[286]`
  - -> `[287]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I agree, Mr. Alphonso. With the state on board, Gasom's future will be bright.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You still haven't convinced me. But consider Sordland's investment a vote of confidence for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gasom's future certainly looks promising, but the decision about the EPA is a complicated one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not so sure, Mr. Alphonso. We mustn't become over-reliant on Gasom or overly susceptible to foreign influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Ewald Alphonso**
> ""I understand your concerns, Mr. President. It's certainly a complex situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[289]`
Mówca: **Ewald Alphonso**
> ""Absolutely, Mr. President. Give it all the time you need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[290]`
Mówca: **Ewald Alphonso**
> ""Of course, {BaseGameText.AlphonsoToPlayer}. I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Ewald Alphonso**
> ""I appreciate your optimism, {BaseGameText.AlphonsoToPlayer}.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[292]`
Mówca: **Narrator**
> "Suddenly, the former president's attention shifted as the pilot announced our landing over the intercom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Ewald Alphonso**
> ""That'll be it then, {BaseGameText.AlphonsoToPlayer}. I urge you to remain seated. These landings can be bumpy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[294]`
Mówca: **Serge Wolkner**
> ""Thank you again for your assistance with the helicopter, Mr. Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[295]`
Mówca: **Ewald Alphonso**
> ""Thank you for your fine company, Mr. Wolkner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[296]`
Mówca: **Narrator**
> "The ground crew and Presidential Guard hurried to secure the landing site as Serge and I disembarked. Glancing back, I caught a final glimpse of Alphonso inside the helicopter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[297]`
Mówca: **Narrator**
> "In a sudden rush of air and sound, the helicopter lifted off, headed towards the Gasom headquarters in the heart of Lachaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[298]`
Mówca: **Narrator**
> "I watched as it disappeared into the cityscape, swallowed by the luminous glow of the Lachaven skyline."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Friendly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Friendly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Friendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_Friendly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Friendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[302]`
Mówca: **Narrator**
> "He winked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[303]`
Mówca: **Narrator**
> "He looked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Discontent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Discontent == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Discontent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_Discontent == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Discontent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Narrator**
> "A mutual nod of acknowledgement passed between us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good evening, Mr. Alphonso. It was a productive discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good talking to you, Mr. Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It was a pleasure, Mr. Alphonso. Goodbye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Friendly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[313]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Friendly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Friendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_Friendly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Friendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Discontent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Discontent == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Discontent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_Discontent == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Discontent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[317]`
Mówca: **Ewald Alphonso**
> ""Thank you for a stimulating discussion, {BaseGameText.AlphonsoToPlayer}. I have high hopes for Sordland's future, and for the continuation of the work we began during my presidency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[318]`
Mówca: **Ewald Alphonso**
> ""Thank you for your time, Mr. President. I do hope that our discussion has given you some perspective.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[319]`
Mówca: **Ewald Alphonso**
> ""It was a pleasure discussing these matters with you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Ewald Alphonso**
> ""I didn't steer Gasom through tumultuous times and lead Sordland through a critical phase of its history only to watch my legacy disintegrate. I trust you understand the stakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[321]`
Mówca: **Ewald Alphonso**
> ""It's not easy to run a country while preserving one's legacy. I trust that you will take our conversation to heart as you steer Sordland into the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[322]`
Mówca: **Ewald Alphonso**
> ""Here's to a prosperous future for Sordland, Gasom, and the legacy we leave behind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Ewald Alphonso**
> ""I look forward to seeing how your decisions will shape our nation's future. We're fighting against the current, but I believe we can change the tide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[324]`
Mówca: **Ewald Alphonso**
> ""We will be in touch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Not bumpy at all. I appreciate the lift.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[326]`
Mówca: **Ewald Alphonso**
> ""Their 15 percent stake is a fair deal. But I believe we could attract even larger international investments if the EPA is removed. Imagine the potential if Rumburg joined in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[327]`
Mówca: **Ewald Alphonso**
> ""Don't forget that Rizia holds only a minority stake and we still have control over Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[328]`
Mówca: **Ewald Alphonso**
> ""In business, a certain level of risk is unavoidable. With the right safeguards, we can mitigate these risks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`
  - -> `[330]`
  - -> `[331]`
  - -> `[332]`

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your confidence is reassuring. However, how can we ensure that Rumburg won't attempt to gain more influence over time?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I share your views. However, I do worry about a potential backlash. The prospect of Rumburg buying a stake in our energy sector might not sit well with the public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am still concerned about the implications of letting foreign entities have a stake in our energy sector. Isn't there a way to boost our economy without compromising our sovereignty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The changes we make to the Energy Protection Act will have long-lasting implications for our nation's future. I can't decide this in a helicopter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[333]`
Mówca: **Ewald Alphonso**
> ""Take all the time you need, {BaseGameText.AlphonsoToPlayer}. These are not decisions to be made lightly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[334]`
Mówca: **Ewald Alphonso**
> ""As I've said before, it's a matter of striking the right balance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[335]`
Mówca: **Ewald Alphonso**
> ""Public opinion is a vital factor, Mr. President. However, in my experience, people often resist change initially.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Ewald Alphonso**
> ""That's a risk we'll have to manage. Regular reviews and stringent regulations can help keep their influence in check.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[337]`
Mówca: **Ewald Alphonso**
> ""Once they see the economic benefits, they usually come around. We have to be transparent and communicate our intentions clearly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[338]`
Mówca: **Ewald Alphonso**
> ""Foreign investment can boost our economy, and as long as we ensure that our nation's interests are protected, I believe it's a risk worth taking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[339]`
Mówca: **Ewald Alphonso**
> ""I trust your judgement in making the right call for our nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[340]`
Mówca: **Ewald Alphonso**
> ""Rizia's 20 percent investment will keep us afloat for a while, but it won't be enough. Any further tightening of the EPA restrictions will spell disaster for Gasom, possibly even leading to bankruptcy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[341]`
Mówca: **Ewald Alphonso**
> ""The question now is, how do we move forward? And that's something we need to figure out together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[342]`
Mówca: **Ewald Alphonso**
> ""We could consider other avenues like public-private partnerships or exploring new markets, but these options come with their own risks and uncertainties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[343]`
Mówca: **Ewald Alphonso**
> ""Our challenge is to control it, not let it control us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Ewald Alphonso**
> ""It's a bitter pill to swallow, knowing that all of this could have been avoided.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[346]`
  - -> `[349]`
  - -> `[355]`

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Our resources are not infinite. We must prioritize, and sometimes, tough calls have to be made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We have to remember the importance of keeping our energy sector secure. The idea of Rumburg gaining significant influence is worrisome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Ewald Alphonso**
> ""I understand the constraints you're under, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[348]`
Mówca: **Ewald Alphonso**
> ""I share your concerns about Rumburg, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""While I sympathize with your position, the reality is that we had to make some hard choices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[350]`
Mówca: **Ewald Alphonso**
> ""I'm not sure if I trust your judgement, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[351]`
Mówca: **Ewald Alphonso**
> ""I just hope we can navigate through this and find a solution that doesn't jeopardize Gasom or Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[352]`
Mówca: **Ewald Alphonso**
> ""But I believe that with careful consideration, we can find a way forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[353]`
Mówca: **Ewald Alphonso**
> ""I just hope that we can find a solution that ensures Gasom's survival without compromising Sordland's interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[354]`
Mówca: **Ewald Alphonso**
> ""On the other hand, loosening those restrictions too much will allow foreign entities like Rumburg to acquire a majority stake in Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Alphonso, I'm aware of the gravity of the situation. But we must not rush into decisions that could risk our sovereignty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[356]`
Mówca: **Ewald Alphonso**
> ""Indeed, Mr. President. We must not be too hasty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[357]`
Mówca: **Ewald Alphonso**
> ""It's a delicate situation, and the decisions we make now will have lasting implications for our nation's future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[358]`
Mówca: **Ewald Alphonso**
> ""At the very least, I ask you to consider increasing the foreign investment cap to 49%. It might not be the perfect solution, but it could provide the lifeline Gasom needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[359]`
Mówca: **Ewald Alphonso**
> ""For old times' sake, let's work together to ensure Gasom doesn't become a casualty of our decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`
  - -> `[361]`
  - -> `[362]`

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's a compromise that could save Gasom without compromising our sovereignty too much. I'll consider it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Tightening the EPA laws further may be a necessary step for our future, even if it poses challenges for Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Not my decisions, Mr. Alphonso. Yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[363]`
Mówca: **Narrator**
> "The low rumble of the helicopter's engines reverberated through the cabin as we soared over the vast expanse of Nargis."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[364]`
Mówca: **Ewald Alphonso**
> ""Now that we've escaped an angry mob together, may I call you Anton?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
  - -> `[366]`

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Of course, Ewald. You don't even need to ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'd rather keep things on the professional level, if you don't mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameText.AlphonsoToPlayer = "Anton")*
- **Efekt (`userScript`):** `Variable["BaseGameText.AlphonsoToPlayer"] ="Anton";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[368]`
Mówca: **Ewald Alphonso**
> ""Of course. Forgive my forwardness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`
  - -> `[371]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Lachaven_Rich == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It may not be perfect, but I'm proud to call it my hometown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[373]`
Mówca: **Serge Wolkner**
> ""It must have been exciting to grow up here, Mr. President. Something new happening every day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[374]`
Mówca: **Ewald Alphonso**
> ""Were Rumburg to get involved, they would be limited to a minority stake as well. I don't think it would pose a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`
  - -> `[330]`
  - -> `[331]`
  - -> `[332]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[378]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Workers_GasomExpandsCare = true;
BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinCare = true;
BaseGameSupport.News_Turn03_R_Workers_LUSCPSVictory = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Workers_GasomExpandsCare"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinCare"] = true;
Variable["BaseGameSupport.News_Turn03_R_Workers_LUSCPSVictory"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Workers_GasomIncreasesSalaries = true;
BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinSalaries = true;
BaseGameSupport.News_Turn03_R_Workers_LUSCPSDisappointed = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Workers_GasomIncreasesSalaries"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinSalaries"] = true;
Variable["BaseGameSupport.News_Turn03_R_Workers_LUSCPSDisappointed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Workers_GasomGivesCharity = true;
BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinDonations = true;
BaseGameSupport.News_Turn03_R_Workers_LUSCPSCondemn = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Workers_GasomGivesCharity"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinDonations"] = true;
Variable["BaseGameSupport.News_Turn03_R_Workers_LUSCPSCondemn"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_LT_Workers_LUSCPSLose = true;
BaseGameSupport.News_Turn03_R_Workers_LUSCPSInaction = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_Workers_LUSCPSLose"] = true;
Variable["BaseGameSupport.News_Turn03_R_Workers_LUSCPSInaction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Address_HelicopterEscape = true; BaseGameSupport.News_Turn03_LT_Address_PresidentLandsLachaven = true; 
BaseGameSupport.News_Turn03_LT_Address_HelicopterEscape = true; 
BaseGameSupport.Report_Turn03_Lachaven_BlueMansionSecurity = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Address_HelicopterEscape"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Address_PresidentLandsLachaven"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Address_HelicopterEscape"] = true;
Variable["BaseGameSupport.Report_Turn03_Lachaven_BlueMansionSecurity"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_Friend == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_Friend == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Serge_Friend"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Serge_Friend == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Serge_Friend"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("On a helicopter flight with a former President and driver", "Countryside", "Nargis");)*
- **Efekt (`userScript`):** `SetRichPresence("On a helicopter flight with a former President and driver","Countryside","Nargis");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Its wealth disparities concern me. This place needs our help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
