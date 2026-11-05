# Sordland/Turn03/A_AddressProtestors

- **ID konwersacji:** `45`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/045_A_AddressProtestors.md`
- **Liczba węzłów dialogowych:** 484
- **Liczba wyborów gracza:** 115

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[22]** Denis Stahler
- **[35]** Gus Manger
- **[53]** Katarina Horten
- **[54]** Serge Wolkner
- **[57]** Reporter

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn01_CampaignFinance_Signed`
- `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses`
- `BaseGame.Decision_Turn02_Funeral_Attend`
- `BaseGame.Decision_Turn02_StatusReaction_BoostPolice`
- `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors`
- `BaseGame.Prologue_Party_Takeover_Backstab`
- `BaseGame.Prologue_University_Political_Nationalist`
- `BaseGame.Prologue_University_Political_Socialist`
- `BaseGame.Promise_TermFocus_Education`
- `BaseGame.Promise_TermFocus_Health`
- `BaseGame.Relations_Ewald_DonatedToFoundation`
- `BaseGame.Relations_Serge_Friend`
- `BaseGame.Situation_Law_MediaBias`
- `BaseGame.Turn03_A_Protestors_Mixed`
- `BaseGame.Turn03_A_Protestors_Uproar`
- `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia`
- `BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention`
- `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone`
- `BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits`
- `BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages`
- `BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation`
- `BaseGameIsolated.Turn03_AddressProtestors_Tension`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Country_Unrest`
- `BaseGame.Public_Opinion`
- `BaseGame.Turn03_A_Protestors_Calm`
- `BaseGame.Turn03_A_Protestors_Mixed`
- `BaseGame.Turn03_A_Protestors_Uproar`
- `BaseGameIsolated.Turn03_AddressProtestors_Tension`
- `BaseGameSupport.News_Turn03_HP_Address_CrowdHassle`
- `BaseGameSupport.News_Turn03_HP_Address_MalenyevistRYRebels`
- `BaseGameSupport.News_Turn03_HP_Workers_GasomExpandsCare`
- `BaseGameSupport.News_Turn03_HP_Workers_GasomGivesCharity`
- `BaseGameSupport.News_Turn03_HP_Workers_GasomIncreasesSalaries`
- `BaseGameSupport.News_Turn03_LT_Address_DramaticScenesUnfold`
- `BaseGameSupport.News_Turn03_LT_Address_LungedAtPresident`
- `BaseGameSupport.News_Turn03_LT_Address_PositiveCrowd`
- `BaseGameSupport.News_Turn03_LT_Workers_LUSCPSLose`
- `BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinCare`
- `BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinDonations`
- `BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinSalaries`
- `BaseGameSupport.News_Turn03_R_Address_OkaySpeechByPresident`
- `BaseGameSupport.News_Turn03_R_Address_PresidentAssaulted`
- `BaseGameSupport.News_Turn03_R_Workers_LUSCPSCondemn`
- `BaseGameSupport.News_Turn03_R_Workers_LUSCPSDisappointed`
- `BaseGameSupport.News_Turn03_R_Workers_LUSCPSInaction`
- `BaseGameSupport.News_Turn03_R_Workers_LUSCPSVictory`
- `BaseGameSupport.News_Turn03_ST_Address_AmazingSpeech`
- `BaseGameSupport.News_Turn03_ST_Address_BadSpeech`
- `BaseGameSupport.News_Turn03_ST_Address_PresidentDeaf`
- `BaseGameSupport.News_Turn03_ST_Address_PresidentListens`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"“My fellow Sords, we are here today not as adversaries, but as collaborators. Our ..."** | `[10]` **Narrator**: "Gus extended a megaphone towards..." | `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true  or  Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true` | *Brak zmian stanu* | `[19]` **Player**: "“We are not blind to your strugg..."<br>`[20]` **Player**: "“This is not a hollow promise, b..."<br>*(oraz 1 innych odgałęzień)* |
| `[16]` | **"“To the hard-working employees of Gasom, we stand with you today. Our shared goal ..."** | `[10]` **Narrator**: "Gus extended a megaphone towards..." | `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true  or  Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true` | *Brak zmian stanu* | `[19]` **Player**: "“We are not blind to your strugg..."<br>`[20]` **Player**: "“This is not a hollow promise, b..."<br>*(oraz 1 innych odgałęzień)* |
| `[17]` | **"“Good people of Narbel, we come here today seeking understanding and progress. We ..."** | `[10]` **Narrator**: "Gus extended a megaphone towards..." | `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true  or  Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true` | *Brak zmian stanu* | `[19]` **Player**: "“We are not blind to your strugg..."<br>`[20]` **Player**: "“This is not a hollow promise, b..."<br>*(oraz 1 innych odgałęzień)* |
| `[18]` | **"“Today my team and I are here to listen and engage. We are here to ensure Gasom be..."** | `[10]` **Narrator**: "Gus extended a megaphone towards..." | `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true  or  Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false` | *Brak zmian stanu* | `[22]` **Player**: "“Let's turn this impasse into an..."<br>`[26]` **Player**: "“We recognize that words are not..."<br>*(oraz 1 innych odgałęzień)* |
| `[19]` | **"“We are not blind to your struggles. We seek to acknowledge them, address them, an..."** | `[3]` **Player**: "“My fellow Sords, we are here to..."<br>`[16]` **Player**: "“To the hard-working employees o..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Katarina Horten**: "“Speeches and more speeches, fro..." |
| `[20]` | **"“This is not a hollow promise, but a step towards a stronger and more balanced Sor..."** | `[3]` **Player**: "“My fellow Sords, we are here to..."<br>`[16]` **Player**: "“To the hard-working employees o..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Katarina Horten**: "“Speeches and more speeches, fro..." |
| `[21]` | **"“Remember, we are united by a common goal: A prosperous Gasom that cares for its w..."** | `[3]` **Player**: "“My fellow Sords, we are here to..."<br>`[16]` **Player**: "“To the hard-working employees o..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Katarina Horten**: "“Speeches and more speeches, fro..." |
| `[22]` | **"“Let's turn this impasse into an opportunity -- a chance for real, impactful chang..."** | `[18]` **Player**: "“Today my team and I are here to..."<br>`[24]` **Player**: "“My fellow Sords, our presence t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Katarina Horten**: "“Empty words, Rayne! You've show..." |
| `[24]` | **"“My fellow Sords, our presence today is not a guarantee of instant change, but rat..."** | `[10]` **Narrator**: "Gus extended a megaphone towards..." | `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true  or  Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false` | *Brak zmian stanu* | `[22]` **Player**: "“Let's turn this impasse into an..."<br>`[26]` **Player**: "“We recognize that words are not..."<br>*(oraz 1 innych odgałęzień)* |
| `[25]` | **"“Good people of Narbel, we are here not to placate you with false promises, but to..."** | `[10]` **Narrator**: "Gus extended a megaphone towards..." | `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true  or  Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false` | *Brak zmian stanu* | `[22]` **Player**: "“Let's turn this impasse into an..."<br>`[26]` **Player**: "“We recognize that words are not..."<br>*(oraz 1 innych odgałęzień)* |
| `[26]` | **"“We recognize that words are not enough, and only through concrete action can we b..."** | `[18]` **Player**: "“Today my team and I are here to..."<br>`[24]` **Player**: "“My fellow Sords, our presence t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Katarina Horten**: "“Empty words, Rayne! You've show..." |
| `[27]` | **"“Today’s visit, let's be clear, does not mean all your problems will disappear ove..."** | `[18]` **Player**: "“Today my team and I are here to..."<br>`[24]` **Player**: "“My fellow Sords, our presence t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Katarina Horten**: "“Empty words, Rayne! You've show..." |
| `[68]` | **"“The business bailout was a necessary step to protect the livelihoods of millions ..."** | `[195]` **Denis Stahler**: ""Furthermore, we want reform! Re..." | `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true` | `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tensi...` | `[63]` **Narrator**: "Despite the sharp words exchange..."<br>`[62]` **Narrator**: "Quiet murmurs of discontent bega..." |
| `[69]` | **"“My absence at Bernard Circas's funeral was not an endorsement of his murder. It w..."** | `[195]` **Denis Stahler**: ""Furthermore, we want reform! Re..." | `(Variable["BaseGame.Decision_Turn02_Funeral_Attend"] == true) == false` | `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tensi...` | `[63]` **Narrator**: "Despite the sharp words exchange..."<br>`[62]` **Narrator**: "Quiet murmurs of discontent bega..." |
| `[70]` | **"“I have always valued the right to peaceful protest. Any assertion otherwise is a ..."** | `[195]` **Denis Stahler**: ""Furthermore, we want reform! Re..." | `Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true` | `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tensi...` | `[63]` **Narrator**: "Despite the sharp words exchange..."<br>`[62]` **Narrator**: "Quiet murmurs of discontent bega..." |
| `[71]` | **"“The discussions with Gasom are an ongoing process, and I am committed to finding ..."** | `[217]` **Reporter**: ""What concrete steps is Gasom go..." | `(Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true) == false`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false` | *Brak zmian stanu* | `[103]` **Player**: "“I understand your frustration. ..."<br>`[104]` **Player**: "“The journey may be challenging,..." |
| `[86]` | **"“As a result of our negotiations, Gasom has committed to improving the living cond..."** | `[217]` **Reporter**: ""What concrete steps is Gasom go..." | `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true` | *Brak zmian stanu* | `[463]` **Player**: "“See, Mr. Stahler and Ms. Horten..."<br>`[89]` **Player**: "“I know it's hard to believe. Bu..."<br>*(oraz 2 innych odgałęzień)* |
| `[87]` | **"“Gasom has recognized the value of its blue-collar workers and agreed to increase ..."** | `[217]` **Reporter**: ""What concrete steps is Gasom go..." | `Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false` | *Brak zmian stanu* | `[90]` **Player**: "“A wage increase is not a mere p..."<br>`[93]` **Player**: "“This is a substantial step towa..."<br>*(oraz 2 innych odgałęzień)* |
| `[88]` | **"“I am pleased to announce that Gasom will play a crucial role in the recovery of N..."** | `[217]` **Reporter**: ""What concrete steps is Gasom go..." | `Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false` | *Brak zmian stanu* | `[91]` **Player**: "“With this contribution, Gasom i..."<br>`[94]` **Player**: "“The worst-off will benefit unde..."<br>*(oraz 2 innych odgałęzień)* |
| `[89]` | **"“I know it's hard to believe. But today was a victory.""** | `[86]` **Player**: "“As a result of our negotiations..."<br>`[95]` **Player**: "“Our efforts have borne fruit. G..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Narrator**: "A change came over the crowd. Th..." |
| `[90]` | **"“A wage increase is not a mere possibility, but a fact. This is a landmark moment.”"** | `[87]` **Player**: "“Gasom has recognized the value ..."<br>`[97]` **Player**: "“After much deliberation, Gasom ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "The air suddenly felt somewhat l..." |
| `[91]` | **"“With this contribution, Gasom is stepping up to play an essential part in the rec..."** | `[88]` **Player**: "“I am pleased to announce that G..."<br>`[99]` **Player**: "“I have exciting news: Gasom has..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Narrator**: "I could hear the crowd growing r..." |
| `[92]` | **"“This is a vital step towards building a more resilient workforce.”"** | `[86]` **Player**: "“As a result of our negotiations..."<br>`[95]` **Player**: "“Our efforts have borne fruit. G..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Narrator**: "A change came over the crowd. Th..." |
| `[93]` | **"“This is a substantial step towards ensuring well-being and prosperity for all wor..."** | `[87]` **Player**: "“Gasom has recognized the value ..."<br>`[97]` **Player**: "“After much deliberation, Gasom ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "The air suddenly felt somewhat l..." |
| `[94]` | **"“The worst-off will benefit under these new initiatives.”"** | `[88]` **Player**: "“I am pleased to announce that G..."<br>`[99]` **Player**: "“I have exciting news: Gasom has..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Narrator**: "I could hear the crowd growing r..." |
| `[95]` | **"“Our efforts have borne fruit. Gasom will now provide better housing, healthcare, ..."** | `[217]` **Reporter**: ""What concrete steps is Gasom go..." | `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true` | *Brak zmian stanu* | `[463]` **Player**: "“See, Mr. Stahler and Ms. Horten..."<br>`[89]` **Player**: "“I know it's hard to believe. Bu..."<br>*(oraz 2 innych odgałęzień)* |
| `[96]` | **"“Through hard negotiations, we've secured a commitment from Gasom to significantly..."** | `[217]` **Reporter**: ""What concrete steps is Gasom go..." | `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true` | *Brak zmian stanu* | `[463]` **Player**: "“See, Mr. Stahler and Ms. Horten..."<br>`[89]` **Player**: "“I know it's hard to believe. Bu..."<br>*(oraz 2 innych odgałęzień)* |
| `[97]` | **"“After much deliberation, Gasom has agreed to increase the wages of the blue-colla..."** | `[217]` **Reporter**: ""What concrete steps is Gasom go..." | `Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false` | *Brak zmian stanu* | `[90]` **Player**: "“A wage increase is not a mere p..."<br>`[93]` **Player**: "“This is a substantial step towa..."<br>*(oraz 2 innych odgałęzień)* |
| `[98]` | **"“In acknowledgment of their indispensable workforce, Gasom has decided to raise th..."** | `[217]` **Reporter**: ""What concrete steps is Gasom go..." | `Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false` | *Brak zmian stanu* | `[90]` **Player**: "“A wage increase is not a mere p..."<br>`[93]` **Player**: "“This is a substantial step towa..."<br>*(oraz 2 innych odgałęzień)* |
| `[99]` | **"“I have exciting news: Gasom has promised a substantial contribution to local char..."** | `[217]` **Reporter**: ""What concrete steps is Gasom go..." | `Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false` | *Brak zmian stanu* | `[91]` **Player**: "“With this contribution, Gasom i..."<br>`[94]` **Player**: "“The worst-off will benefit unde..."<br>*(oraz 2 innych odgałęzień)* |
| `[100]` | **"“Gasom's dedication to Narbel's recovery has been cemented with their promise of a..."** | `[217]` **Reporter**: ""What concrete steps is Gasom go..." | `Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false` | *Brak zmian stanu* | `[91]` **Player**: "“With this contribution, Gasom i..."<br>`[94]` **Player**: "“The worst-off will benefit unde..."<br>*(oraz 2 innych odgałęzień)* |
| `[101]` | **"“I must admit, we haven't been able to make as much progress with Gasom as we had ..."** | `[217]` **Reporter**: ""What concrete steps is Gasom go..." | `(Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true) == false`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false` | *Brak zmian stanu* | `[103]` **Player**: "“I understand your frustration. ..."<br>`[104]` **Player**: "“The journey may be challenging,..." |
| `[102]` | **"“Rest assured, we are in continuous dialogue with Gasom. I remain steadfast in my ..."** | `[217]` **Reporter**: ""What concrete steps is Gasom go..." | `(Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true) == false`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false` | *Brak zmian stanu* | `[103]` **Player**: "“I understand your frustration. ..."<br>`[104]` **Player**: "“The journey may be challenging,..." |
| `[103]` | **"“I understand your frustration. Be assured, I will push harder in the negotiations..."** | `[71]` **Player**: "“The discussions with Gasom are ..."<br>`[101]` **Player**: "“I must admit, we haven't been a..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Denis Stahler**: ""At least you're not hiding your..." |
| `[104]` | **"“The journey may be challenging, but I remain dedicated. Our workers deserve bette..."** | `[71]` **Player**: "“The discussions with Gasom are ..."<br>`[101]` **Player**: "“I must admit, we haven't been a..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Denis Stahler**: ""At least you're not hiding your..." |
| `[118]` | **"“The effort of this government will go down in history.”"** | `[86]` **Player**: "“As a result of our negotiations..."<br>`[95]` **Player**: "“Our efforts have borne fruit. G..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Narrator**: "A change came over the crowd. Th..." |
| `[119]` | **"“We have all achieved a victory today.”"** | `[87]` **Player**: "“Gasom has recognized the value ..."<br>`[97]` **Player**: "“After much deliberation, Gasom ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "The air suddenly felt somewhat l..." |
| `[120]` | **"“This marks the beginning of a new era for the city.”"** | `[88]` **Player**: "“I am pleased to announce that G..."<br>`[99]` **Player**: "“I have exciting news: Gasom has..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Narrator**: "I could hear the crowd growing r..." |
| `[124]` | **"“I would like to announce that I've personally donated a portion of my salary to t..."** | `[129]` **Narrator**: "The undercurrent of unrest swell..."<br>`[237]` **Katarina Horten**: ""While I commend this commitment..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Relations_Ewald_DonatedToFoundation"] == true`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false` | `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tensi...` | `[249]` **Katarina Horten**: ""That's rich, Mr. President! Don..."<br>`[23]` **Narrator**: "A group of figures emerged from ..." |
| `[125]` | **"“I have made the decision to donate part of my own income to the Alphonso Foundati..."** | `[129]` **Narrator**: "The undercurrent of unrest swell..."<br>`[237]` **Katarina Horten**: ""While I commend this commitment..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Relations_Ewald_DonatedToFoundation"] == true`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false` | `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tensi...` | `[249]` **Katarina Horten**: ""That's rich, Mr. President! Don..."<br>`[23]` **Narrator**: "A group of figures emerged from ..." |
| `[126]` | **"“You'll be pleased to know that I've allocated a portion of my rather substantial ..."** | `[129]` **Narrator**: "The undercurrent of unrest swell..."<br>`[237]` **Katarina Horten**: ""While I commend this commitment..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Relations_Ewald_DonatedToFoundation"] == true`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false` | `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tensi...` | `[249]` **Katarina Horten**: ""That's rich, Mr. President! Don..."<br>`[23]` **Narrator**: "A group of figures emerged from ..." |
| `[130]` | **"“What if I told you I decided to give away a fraction of my salary to the Alphonso..."** | `[129]` **Narrator**: "The undercurrent of unrest swell..."<br>`[237]` **Katarina Horten**: ""While I commend this commitment..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Relations_Ewald_DonatedToFoundation"] == true`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false` | `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tensi...` | `[249]` **Katarina Horten**: ""That's rich, Mr. President! Don..."<br>`[23]` **Narrator**: "A group of figures emerged from ..." |
| `[143]` | **"“Denis, the focus here is not on narratives or images but on real, tangible change..."** | `[57]` **Denis Stahler**: ""It's not about narratives, Mr. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Denis Stahler**: ""Words, words, and more words, P..." |
| `[144]` | **"“I understand your skepticism, Denis. But I assure you my administration is devote..."** | `[57]` **Denis Stahler**: ""It's not about narratives, Mr. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Denis Stahler**: ""Your words are compelling, Pres..." |
| `[145]` | **"“You're an academic and a lawyer, Mr. Stahler. What do you really know about the s..."** | `[57]` **Denis Stahler**: ""It's not about narratives, Mr. ..."<br>`[61]` **Denis Stahler**: ""Change might not happen overnig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Denis Stahler**: ""I know that they deserve better..." |
| `[146]` | **"“You're right, Denis. The days of corporate favoritism must come to an end. If not..."** | `[61]` **Denis Stahler**: ""Change might not happen overnig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Denis Stahler**: ""Finally, Rayne, you acknowledge..." |
| `[147]` | **"“Change may not come as quickly as you want, Denis. But your claims of corporate f..."** | `[61]` **Denis Stahler**: ""Change might not happen overnig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Denis Stahler**: ""Then what just happened in that..." |
| `[151]` | **"“Change is often slow and gradual. Not all solutions are as immediate and straight..."** | `[57]` **Denis Stahler**: ""It's not about narratives, Mr. ..."<br>`[61]` **Denis Stahler**: ""Change might not happen overnig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Denis Stahler**: ""Your indifference is appalling,..." |
| `[196]` | **""The people of Sordland have elected me to lead. I believe it's crucial to trust t..."** | `[195]` **Denis Stahler**: ""Furthermore, we want reform! Re..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tensi...` | `[63]` **Narrator**: "Despite the sharp words exchange..."<br>`[62]` **Narrator**: "Quiet murmurs of discontent bega..." |
| `[197]` | **""I understand the concerns and frustrations many of you have. Rest assured, we are..."** | `[195]` **Denis Stahler**: ""Furthermore, we want reform! Re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Narrator**: "Despite the sharp words exchange..."<br>`[62]` **Narrator**: "Quiet murmurs of discontent bega..." |
| `[198]` | **""We must recognize that our country can't solve all its problems at once. We are w..."** | `[195]` **Denis Stahler**: ""Furthermore, we want reform! Re..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tensi...` | `[63]` **Narrator**: "Despite the sharp words exchange..."<br>`[62]` **Narrator**: "Quiet murmurs of discontent bega..." |
| `[199]` | **""The campaign finance bill ensures fair funding for democratically elected parties..."** | `[195]` **Denis Stahler**: ""Furthermore, we want reform! Re..." | `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true` | `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tensi...` | `[63]` **Narrator**: "Despite the sharp words exchange..."<br>`[62]` **Narrator**: "Quiet murmurs of discontent bega..." |
| `[200]` | **""While the increased police force may have its challenges, it's crucial for mainta..."** | `[195]` **Denis Stahler**: ""Furthermore, we want reform! Re..." | `Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true` | `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tensi...` | `[63]` **Narrator**: "Despite the sharp words exchange..."<br>`[62]` **Narrator**: "Quiet murmurs of discontent bega..." |
| `[207]` | **""On healthcare and education, I hear your concerns. While these areas may not be o..."** | `[195]` **Denis Stahler**: ""Furthermore, we want reform! Re..." | `Variable["BaseGame.Promise_TermFocus_Health"] == false  and  Variable["BaseGame.Promise_TermFocus_Education"] == false` | `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tensi...` | `[63]` **Narrator**: "Despite the sharp words exchange..."<br>`[62]` **Narrator**: "Quiet murmurs of discontent bega..." |
| `[253]` | **""The past is the past. Personal disagreements have no place in matters of national..."** | `[257]` **Reporter**: ""Did this 'bad blood' influence ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Reporter**: ""Could you shed some light on th..." |
| `[254]` | **""We did have our disagreements, but I won't allow personal matters to obstruct pro..."** | `[257]` **Reporter**: ""Did this 'bad blood' influence ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Reporter**: ""Could you shed some light on th..." |
| `[255]` | **""The rift between former President Alphonso and myself did present obstacles in th..."** | `[257]` **Reporter**: ""Did this 'bad blood' influence ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Narrator**: "Gus stepped in." |
| `[258]` | **"“No comment.”"** | `[257]` **Reporter**: ""Did this 'bad blood' influence ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Reporter**: ""Could you shed some light on th..." |
| `[262]` | **""With all due respect to the Kingdom, I believe Sordland knows whats best for Sord..."** | `[261]` **Reporter**: ""What role does the Kingdom of R..." | `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true` | *Brak zmian stanu* | `[272]` **Denis Stahler**: ""A surprising but potentially pr..." |
| `[263]` | **""Our nation will shoulder the investment for Gasom. It's a bold step, but one that..."** | `[261]` **Reporter**: ""What role does the Kingdom of R..." | `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true` | *Brak zmian stanu* | `[272]` **Denis Stahler**: ""A surprising but potentially pr..." |
| `[264]` | **""The government of Sordland has decided to solely invest in Gasom. We believe this..."** | `[261]` **Reporter**: ""What role does the Kingdom of R..." | `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true` | *Brak zmian stanu* | `[272]` **Denis Stahler**: ""A surprising but potentially pr..." |
| `[265]` | **""In a show of international cooperation, Sordland and Rizia will jointly invest in..."** | `[261]` **Reporter**: ""What role does the Kingdom of R..." | `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`<br>`(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false` | *Brak zmian stanu* | `[274]` **Denis Stahler**: ""A partnership with Rizia? You a..." |
| `[266]` | **""We are sharing the costs and stakes with Rizia. This way, we're reducing financia..."** | `[261]` **Reporter**: ""What role does the Kingdom of R..." | `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`<br>`(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false` | *Brak zmian stanu* | `[274]` **Denis Stahler**: ""A partnership with Rizia? You a..." |
| `[267]` | **""Sordland is renewing its ties with the Kingdom of Rizia. Together, we will provid..."** | `[261]` **Reporter**: ""What role does the Kingdom of R..." | `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`<br>`(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false` | *Brak zmian stanu* | `[274]` **Denis Stahler**: ""A partnership with Rizia? You a..." |
| `[268]` | **""Our government has chosen not to invest at this time. We believe Rizia is capable..."** | `[261]` **Reporter**: ""What role does the Kingdom of R..." | `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`<br>`(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false` | *Brak zmian stanu* | `[276]` **Denis Stahler**: ""So, you're putting the fate of ..." |
| `[269]` | **""Rizia has invested in Sordland before, and they will do it once again. I have fai..."** | `[261]` **Reporter**: ""What role does the Kingdom of R..." | `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`<br>`(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false` | *Brak zmian stanu* | `[276]` **Denis Stahler**: ""So, you're putting the fate of ..." |
| `[270]` | **""At this time, we won't be investing in Gasom. This decision isn't made lightly, b..."** | `[261]` **Reporter**: ""What role does the Kingdom of R..." | `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`<br>`(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false` | *Brak zmian stanu* | `[276]` **Denis Stahler**: ""So, you're putting the fate of ..." |
| `[282]` | **""You speak of double standards and yet fail to understand the complexities of gove..."** | `[303]` **Katarina Horten**: ""You can't even face your own pe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Reporter**: ""One final question, what is you..." |
| `[283]` | **""You claim to advocate for the workers, yet undermine our efforts to better their ..."** | `[303]` **Katarina Horten**: ""You can't even face your own pe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Reporter**: ""One final question, what is you..." |
| `[284]` | **""The utopia you dream of won't materialize by mere rhetoric or by attacking those ..."** | `[303]` **Katarina Horten**: ""You can't even face your own pe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Reporter**: ""One final question, what is you..." |
| `[285]` | **""Let's all remember that we're here for the same reason -- to better the lives of ..."** | `[287]` **Player**: ""I understand your frustrations ..."<br>`[347]` **Player**: ""Yes, the dialogue has only star..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Narrator**: "The reporter jumped in." |
| `[286]` | **""The path to progress is challenging and fraught with disagreement, but we must no..."** | `[287]` **Player**: ""I understand your frustrations ..."<br>`[347]` **Player**: ""Yes, the dialogue has only star..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Narrator**: "The reporter jumped in." |
| `[287]` | **""I understand your frustrations and the urge to voice your concerns. However, let'..."** | `[359]` **Narrator**: "Their collective gaze bore into ..."<br>`[362]` **Narrator**: "As I readied myself to leave, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[352]` **Player**: ""This is a marathon, not a sprint.""<br>`[351]` **Player**: ""Denis, Katarina, I look forward..."<br>*(oraz 3 innych odgałęzień)* |
| `[309]` | **""Thank you for looking out for me, Serge. Let's get out of here.""** | `[293]` **Serge Wolkner**: ""It may be best to conclude your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[302]` **Gus Manger**: ""I'll remain here, Mr. President..." |
| `[310]` | **""Are you sure? Won't running away from this only make the protestors angrier?""** | `[293]` **Serge Wolkner**: ""It may be best to conclude your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[302]` **Gus Manger**: ""I'll remain here, Mr. President..." |
| `[311]` | **""I agree, Serge. Tensions can rise quickly in such environments. It's better we ma..."** | `[289]` **Serge Wolkner**: ""It might be a good time to make..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[301]` **Gus Manger**: ""Mr. President, I'll stay on to ..." |
| `[312]` | **""Are you sure? Won't running away from this only make the protestors angrier?""** | `[289]` **Serge Wolkner**: ""It might be a good time to make..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[301]` **Gus Manger**: ""Mr. President, I'll stay on to ..." |
| `[313]` | **""You're absolutely right, Serge. Let's not stay here any longer than necessary.""** | `[288]` **Serge Wolkner**: ""I recommend that we expedite yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[300]` **Gus Manger**: ""I'll stay back and handle thing..." |
| `[314]` | **""Are you sure? Won't running away from this only make the protestors angrier?""** | `[288]` **Serge Wolkner**: ""I recommend that we expedite yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[403]` **Gus Manger**: ""Serge is right, Mr. President. ..." |
| `[320]` | **"Shake their hands."** | `[361]` **Katarina Horten**: ""We have shown courage together...." | `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] <= 3` | *Brak zmian stanu* | `[357]` **Narrator**: "Almost immediately, the remainin..." |
| `[324]` | **"Shake their hands."** | `[361]` **Katarina Horten**: ""We have shown courage together...." | `(Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] <= 3) == false` | *Brak zmian stanu* | `[358]` **Narrator**: "A flutter of whispers rippled th..." |
| `[325]` | **""No further comments.""** | `[303]` **Katarina Horten**: ""You can't even face your own pe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Reporter**: ""One final question, what is you..." |
| `[335]` | **""Give him hell, Serge!""** | `[341]` **Narrator**: "Before I could react, Serge spra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Narrator**: "Serge left my dazed attacker on ..." |
| `[336]` | **""Let's get out of here!""** | `[341]` **Narrator**: "Before I could react, Serge spra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Narrator**: "Serge left my dazed attacker on ..." |
| `[337]` | **""Everyone calm down!""** | `[341]` **Narrator**: "Before I could react, Serge spra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Narrator**: "Serge left my dazed attacker on ..." |
| `[342]` | **"Freeze in panic."** | `[341]` **Narrator**: "Before I could react, Serge spra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Narrator**: "Serge left my dazed attacker on ..." |
| `[344]` | **""Thanks to both of you.""** | `[361]` **Katarina Horten**: ""We have shown courage together...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[358]` **Narrator**: "A flutter of whispers rippled th..." |
| `[347]` | **""Yes, the dialogue has only started. I assure you both, my commitment to progress ..."** | `[359]` **Narrator**: "Their collective gaze bore into ..."<br>`[362]` **Narrator**: "As I readied myself to leave, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[352]` **Player**: ""This is a marathon, not a sprint.""<br>`[351]` **Player**: ""Denis, Katarina, I look forward..."<br>*(oraz 3 innych odgałęzień)* |
| `[348]` | **""Indeed, accountability is the cornerstone of democracy. As your president, I unde..."** | `[359]` **Narrator**: "Their collective gaze bore into ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[352]` **Player**: ""This is a marathon, not a sprint.""<br>`[351]` **Player**: ""Denis, Katarina, I look forward..."<br>*(oraz 3 innych odgałęzień)* |
| `[349]` | **""Most wouldn't come out because most fear facing the truth. As for the conversatio..."** | `[359]` **Narrator**: "Their collective gaze bore into ..."<br>`[362]` **Narrator**: "As I readied myself to leave, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[352]` **Player**: ""This is a marathon, not a sprint.""<br>`[351]` **Player**: ""Denis, Katarina, I look forward..."<br>*(oraz 3 innych odgałęzień)* |
| `[350]` | **""My job is to listen and act. As for accountability, isn't that what all governmen..."** | `[362]` **Narrator**: "As I readied myself to leave, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[352]` **Player**: ""This is a marathon, not a sprint.""<br>`[351]` **Player**: ""Denis, Katarina, I look forward..."<br>*(oraz 3 innych odgałęzień)* |
| `[351]` | **""Denis, Katarina, I look forward to our continuing conversations.""** | `[287]` **Player**: ""I understand your frustrations ..."<br>`[347]` **Player**: ""Yes, the dialogue has only star..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Narrator**: "The reporter jumped in." |
| `[352]` | **""This is a marathon, not a sprint.""** | `[287]` **Player**: ""I understand your frustrations ..."<br>`[347]` **Player**: ""Yes, the dialogue has only star..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Narrator**: "The reporter jumped in." |
| `[356]` | **""As an old Red Youth member, I can personally say that the work you do is of utmos..."** | `[361]` **Katarina Horten**: ""We have shown courage together...." | `Variable["BaseGame.Prologue_University_Political_Socialist"] == true` | *Brak zmian stanu* | `[358]` **Narrator**: "A flutter of whispers rippled th..." |
| `[364]` | **""Together, we can ensure a prosperous future for Sordland.""** | `[287]` **Player**: ""I understand your frustrations ..."<br>`[347]` **Player**: ""Yes, the dialogue has only star..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Narrator**: "The reporter jumped in." |
| `[379]` | **""Thanks for your concern, Serge. It was tense, but knowing you and the team were t..."** | `[371]` **Serge Wolkner**: ""I had no doubt about your capab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[385]` **Serge Wolkner**: ""We're here to serve and protect..." |
| `[380]` | **""Serge, in this role, danger comes with the territory. But your concern is appreci..."** | `[371]` **Serge Wolkner**: ""I had no doubt about your capab..."<br>`[372]` **Serge Wolkner**: ""I'm glad we are safely on our w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[386]` **Serge Wolkner**: ""It's not just part of the job, ..." |
| `[381]` | **""Don't forget, a President has to face these situations head-on.""** | `[371]` **Serge Wolkner**: ""I had no doubt about your capab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[387]` **Serge Wolkner**: ""You're right, sir. It's part of..." |
| `[382]` | **""Thank you, Serge. I don't know what I'd do without you.""** | `[372]` **Serge Wolkner**: ""I'm glad we are safely on our w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Serge Wolkner**: ""I'm merely doing my job, Mr. Pr..." |
| `[383]` | **""Agreed, Serge. A job well done by you and the team.""** | `[372]` **Serge Wolkner**: ""I'm glad we are safely on our w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[389]` **Serge Wolkner**: ""We appreciate your acknowledgem..." |
| `[384]` | **""A little excitement to keep us on our toes, wasn't it?""** | `[371]` **Serge Wolkner**: ""I had no doubt about your capab..."<br>`[372]` **Serge Wolkner**: ""I'm glad we are safely on our w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[390]` **Serge Wolkner**: ""That's one way to look at it, M..." |
| `[453]` | **""Before any of you do anything too rash, I want you to take a good look around you.""** | `[10]` **Narrator**: "Gus extended a megaphone towards..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[454]` **Player**: ""You are surrounded by police an..."<br>`[455]` **Player**: ""You cannot rise up against the ..."<br>*(oraz 1 innych odgałęzień)* |
| `[454]` | **""You are surrounded by police and armed guards. Realistically, what do you hope to..."** | `[453]` **Player**: ""Before any of you do anything t..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tensi...` | `[458]` **Denis Stahler**: ""You're going to jump directly t..." |
| `[455]` | **""You cannot rise up against the President of Sordland without facing consequences.""** | `[453]` **Player**: ""Before any of you do anything t..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tensi...` | `[458]` **Denis Stahler**: ""You're going to jump directly t..." |
| `[457]` | **""We are all brothers and sisters in the struggle against greed and exploitation. W..."** | `[453]` **Player**: ""Before any of you do anything t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[460]` **Denis Stahler**: ""Divided? You're the one walking..." |
| `[461]` | **""How dare you speak that way to your president! You ingrates have no idea how much..."** | `[195]` **Denis Stahler**: ""Furthermore, we want reform! Re..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tensi...` | `[63]` **Narrator**: "Despite the sharp words exchange..."<br>`[62]` **Narrator**: "Quiet murmurs of discontent bega..." |
| `[463]` | **"“See, Mr. Stahler and Ms. Horten? I'm on your side. You can stop whining now.""** | `[86]` **Player**: "“As a result of our negotiations..."<br>`[95]` **Player**: "“Our efforts have borne fruit. G..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Narrator**: "A change came over the crowd. Th..." |
| `[464]` | **"“See, Mr. Stahler and Ms. Horten? I'm on your side. You can stop whining now.""** | `[87]` **Player**: "“Gasom has recognized the value ..."<br>`[97]` **Player**: "“After much deliberation, Gasom ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "The air suddenly felt somewhat l..." |
| `[465]` | **"“See, Mr. Stahler and Ms. Horten? I'm on your side. You can stop whining now.""** | `[88]` **Player**: "“I am pleased to announce that G..."<br>`[99]` **Player**: "“I have exciting news: Gasom has..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Narrator**: "I could hear the crowd growing r..." |
| `[466]` | **"“I'm not going to dignify that with a response. Gasom has done so much for this sh..."** | `[217]` **Reporter**: ""What concrete steps is Gasom go..." | `(Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true) == false`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`<br>`(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false` | *Brak zmian stanu* | `[467]` **Player**: ""Honestly, these workers are luc..."<br>`[468]` **Player**: ""I'm warning you all. Back off n..."<br>*(oraz 1 innych odgałęzień)* |
| `[467]` | **""Honestly, these workers are lucky to even have jobs. They shouldn't get greedy.""** | `[466]` **Player**: "“I'm not going to dignify that w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[470]` **Denis Stahler**: ""Your arrogance is unbelievable,..." |
| `[468]` | **""I'm warning you all. Back off now, or there *will* be consequences.""** | `[466]` **Player**: "“I'm not going to dignify that w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[470]` **Denis Stahler**: ""Your arrogance is unbelievable,..." |
| `[469]` | **""Why don't you talk to an actual Gasom employee, Madam Reporter? They'll tell you ..."** | `[466]` **Player**: "“I'm not going to dignify that w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[470]` **Denis Stahler**: ""Your arrogance is unbelievable,..." |
| `[476]` | **""What the hell are you still doing here, lady? Can't you see it's about to get ugly?""** | `[261]` **Reporter**: ""What role does the Kingdom of R..." | `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] >= 5  and  Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == false` | *Brak zmian stanu* | `[477]` **Denis Stahler**: ""The sight of the common people ..." |
| `[478]` | **""That's confidential, ma'am.""** | `[261]` **Reporter**: ""What role does the Kingdom of R..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tensi...` | `[480]` **Katarina Horten**: ""I see. The President won't divu..." |

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
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Addressing a crowd of displeased workers..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“My fellow Sords, we are here today not as adversaries, but as collaborators. Our purpose? To invest in Gasom, and ensure it invests in you.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true  or  Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true`
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: "“We are not blind to your struggles. We seek to acknowled..."*)
  - -> `[20]` (*Player: "“This is not a hollow promise, but a step towards a stron..."*)
  - -> `[21]` (*Player: "“Remember, we are united by a common goal: A prosperous G..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Gus Manger stood to my right, his silhouette barely distinguishable from the monolithic edifice behind us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "AddConversant("Serge Wolkner");"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Serge stood to my left, his eyes scanning the crowd with the precision of a hawk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "The Gasom security had drawn their weapons in anticipatio..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "The Gasom security had drawn their weapons in anticipation, forming a bristling wall around the perimeter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "My Presidential Guard, in stark contrast, stood tall and ..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "My Presidential Guard, in stark contrast, stood tall and unflinching at the entrance, shielding us from the sea of angry workers surrounding us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "AddConversant("Katarina Horten");"*)

### Węzeł `[8]`
Mówca: **Narrator**
> "The shouts of the crowd were deafening, the hostility palpable. Stahler and Horten stood at the forefront with fire in their eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "With a deep breath, I prepared to address them."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "With a deep breath, I prepared to address them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Gus extended a megaphone towards me."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "Gus extended a megaphone towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBene..."*)
  - -> `[453]` (*Player: ""Before any of you do anything too rash, I want you to ta..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Gus Manger");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Gus Manger");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Gus Manger stood to my right, his silhouette barely disti..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Serge Wolkner");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Serge Wolkner");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Serge stood to my left, his eyes scanning the crowd with ..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "As we stepped out of the towering front gate of the Gasom facility, I immediately became aware of how tense the situation was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "AddConversant("Gus Manger");"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Katarina Horten");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Katarina Horten");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "AddConversant("Denis Stahler");"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Denis Stahler");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Denis Stahler");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "The shouts of the crowd were deafening, the hostility pal..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“To the hard-working employees of Gasom, we stand with you today. Our shared goal is simple: to demand improved living and working conditions for everyone.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true  or  Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true`
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: "“We are not blind to your struggles. We seek to acknowled..."*)
  - -> `[20]` (*Player: "“This is not a hollow promise, but a step towards a stron..."*)
  - -> `[21]` (*Player: "“Remember, we are united by a common goal: A prosperous G..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Good people of Narbel, we come here today seeking understanding and progress. We aim to bridge the gap between Gasom and its employees.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true  or  Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true`
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: "“We are not blind to your struggles. We seek to acknowled..."*)
  - -> `[20]` (*Player: "“This is not a hollow promise, but a step towards a stron..."*)
  - -> `[21]` (*Player: "“Remember, we are united by a common goal: A prosperous G..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Today my team and I are here to listen and engage. We are here to ensure Gasom becomes a beacon of growth, fairness, and prosperity for all its workers.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true  or  Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "“Let's turn this impasse into an opportunity -- a chance ..."*)
  - -> `[26]` (*Player: "“We recognize that words are not enough, and only through..."*)
  - -> `[27]` (*Player: "“Today’s visit, let's be clear, does not mean all your pr..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We are not blind to your struggles. We seek to acknowledge them, address them, and above all, improve them.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Player), `[16]` (Player), `[17]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Katarina Horten: "“Speeches and more speeches, from President Rayne! But wh..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“This is not a hollow promise, but a step towards a stronger and more balanced Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Player), `[16]` (Player), `[17]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Katarina Horten: "“Speeches and more speeches, from President Rayne! But wh..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Remember, we are united by a common goal: A prosperous Gasom that cares for its workers. It's a fight we all must face together.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Player), `[16]` (Player), `[17]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Katarina Horten: "“Speeches and more speeches, from President Rayne! But wh..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Let's turn this impasse into an opportunity -- a chance for real, impactful change. We are here to make that happen.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Player), `[24]` (Player), `[25]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Katarina Horten: "“Empty words, Rayne! You've shown us nothing concrete tod..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "A group of figures emerged from the crowd, adorned in unmistakable scarlet attire. The Red Youth had arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“My fellow Sords, our presence today is not a guarantee of instant change, but rather an effort to better understand the complexity of the issues at hand.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true  or  Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "“Let's turn this impasse into an opportunity -- a chance ..."*)
  - -> `[26]` (*Player: "“We recognize that words are not enough, and only through..."*)
  - -> `[27]` (*Player: "“Today’s visit, let's be clear, does not mean all your pr..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Good people of Narbel, we are here not to placate you with false promises, but to honestly assess the reality and work towards practical solutions.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true  or  Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "“Let's turn this impasse into an opportunity -- a chance ..."*)
  - -> `[26]` (*Player: "“We recognize that words are not enough, and only through..."*)
  - -> `[27]` (*Player: "“Today’s visit, let's be clear, does not mean all your pr..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We recognize that words are not enough, and only through concrete action can we begin to address the challenges you face.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Player), `[24]` (Player), `[25]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Katarina Horten: "“Empty words, Rayne! You've shown us nothing concrete tod..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Today’s visit, let's be clear, does not mean all your problems will disappear overnight. It's an initial step to gauge the scope of the issues.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Player), `[24]` (Player), `[25]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Katarina Horten: "“Empty words, Rayne! You've shown us nothing concrete tod..."*)

### Węzeł `[28]`
Mówca: **Katarina Horten**
> "“Speeches and more speeches, from President Rayne! But what exactly was decided today? We need more than pretty words; we need substance!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Denis Stahler: "“She's right, Mr. President. We need details. What's goin..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true || BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBene..."*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBe..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true || BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true  or  Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player: "“My fellow Sords, we are here today not as adversaries, b..."*)
  - -> `[16]` (*Player: "“To the hard-working employees of Gasom, we stand with yo..."*)
  - -> `[17]` (*Player: "“Good people of Narbel, we come here today seeking unders..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true || BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true  or  Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: "“Today my team and I are here to listen and engage. We ar..."*)
  - -> `[24]` (*Player: "“My fellow Sords, our presence today is not a guarantee o..."*)
  - -> `[25]` (*Player: "“Good people of Narbel, we are here not to placate you wi..."*)

### Węzeł `[32]`
Mówca: **Denis Stahler**
> "“She's right, Mr. President. We need details. What's going to change for the workers?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention == true"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Gus Manger: "“Now hold on a moment. President Rayne is committed to br..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Gus Manger: ""Now, now, let's not get too heated. We all know change d..."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "I realized this was no longer a mere protest. It was a symbol of a broader, more potent struggle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "The police began reorganizing their ranks, adopting defen..."*)

### Węzeł `[37]`
Mówca: **Katarina Horten**
> "“Empty words, Rayne! You've shown us nothing concrete today. We're fed up with your hollow rhetoric!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Denis Stahler: "“All talk and no action, isn't it, Mr. President? How lon..."*)

### Węzeł `[38]`
Mówca: **Denis Stahler**
> "“All talk and no action, isn't it, Mr. President? How long must the workers wait for real change?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention == true"*)

### Węzeł `[39]`
Mówca: **Gus Manger**
> "“Now hold on a moment. President Rayne is committed to bringing about real change. His actions and decisions demonstrate this clearly, even if it doesn't fit your narrative!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == ..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Katarina Horten: "“Your boost to the police force? A disaster! Inexperience..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_StatusReaction_WarnTraitors ==..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Denis Stahler: ""You label peaceful protestors as traitors? These are ord..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_Funeral_Attend == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_Funeral_Attend == false"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_Funeral_Attend == false)"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_Funeral_Attend == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_Funeral_Attend"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Denis Stahler: ""Let's not forget your conspicuous absence at Bernard Cir..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_Funeral_Attend == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_Funeral_Attend"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesse..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Katarina Horten: "“Wasn't it your government that bailed out the elites whi..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_Funeral_Attend == false"*)

### Węzeł `[52]`
Mówca: **Katarina Horten**
> "“Wasn't it your government that bailed out the elites while workers were left to suffer? Where was our bailout, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 1"*)

### Węzeł `[53]`
Mówca: **Denis Stahler**
> ""Let's not forget your conspicuous absence at Bernard Circas' funeral. Your silence spoke volumes. Do you endorse the killing of those who stand up for workers' rights?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 1"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Narrator: "Eventually, all fell silent as they waited for Denis and ..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Katarina Horten: ""Is that so, Manger? All we've seen are decisions that fa..."*)

### Węzeł `[56]`
Mówca: **Katarina Horten**
> ""Is that so, Manger? All we've seen are decisions that favor the likes of you and Ewald Alphonso, not the common workers!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Denis Stahler: ""It's not about narratives, Mr. Manger. It's about ensuri..."*)

### Węzeł `[57]`
Mówca: **Denis Stahler**
> ""It's not about narratives, Mr. Manger. It's about ensuring a fair, dignified life for the working class. Something your policies have consistently failed to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player: "“Change is often slow and gradual. Not all solutions are ..."*)
  - -> `[143]` (*Player: "“Denis, the focus here is not on narratives or images but..."*)
  - -> `[144]` (*Player: "“I understand your skepticism, Denis. But I assure you my..."*)
  - -> `[145]` (*Player: "“You're an academic and a lawyer, Mr. Stahler. What do yo..."*)

### Węzeł `[58]`
Mówca: **Gus Manger**
> ""Now, now, let's not get too heated. We all know change doesn't happen overnight. President Rayne is doing what he can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Katarina Horten: ""Oh, we've seen how much he can do, Manger. A lot for you..."*)

### Węzeł `[59]`
Mówca: **Denis Stahler**
> ""Time is a luxury we don't have, Mr. President. Each passing day is another day our workers suffer under the heel of inequality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "The undercurrent of unrest swelled, threatening to surge ..."*)

### Węzeł `[60]`
Mówca: **Katarina Horten**
> ""Oh, we've seen how much he can do, Manger. A lot for you, President Alphonso and Gasom, nothing for the workers!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Denis Stahler: ""Change might not happen overnight, Mr. Manger, but it sh..."*)

### Węzeł `[61]`
Mówca: **Denis Stahler**
> ""Change might not happen overnight, Mr. Manger, but it should at least happen! What we've seen so far is the same old corporate favoritism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player: "“Change is often slow and gradual. Not all solutions are ..."*)
  - -> `[145]` (*Player: "“You're an academic and a lawyer, Mr. Stahler. What do yo..."*)
  - -> `[146]` (*Player: "“You're right, Denis. The days of corporate favoritism mu..."*)
  - -> `[147]` (*Player: "“Change may not come as quickly as you want, Denis. But y..."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "Quiet murmurs of discontent began to ripple through the crowd. The workers' faces seemed to turn even stonier."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "I could feel the tension growing. The presence of our gua..."*)

### Węzeł `[63]`
Mówca: **Narrator**
> "Despite the sharp words exchanged, the crowd remained eerily calm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "It seemed like they were waiting, their collective breath..."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "I could feel the tension growing. The presence of our guards did little to reassure me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "Suddenly, a reporter pushed through the crowd, brandishin..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "It seemed like they were waiting, their collective breath held in anticipation of something more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "Suddenly, a reporter pushed through the crowd, brandishin..."*)

### Węzeł `[66]`
Mówca: **Katarina Horten**
> "“Your boost to the police force? A disaster! Inexperienced personnel are not only useless, they are dangerous. They're making the situation worse!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 1"*)

### Węzeł `[67]`
Mówca: **Denis Stahler**
> ""You label peaceful protestors as traitors? These are ordinary citizens expressing their discontent, not some foreign enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 1"*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The business bailout was a necessary step to protect the livelihoods of millions of Sords. It was not a decision made lightly.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Kontekst wejściowy (poprzednik):** `[195]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1"*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“My absence at Bernard Circas's funeral was not an endorsement of his murder. It was a time of mourning, and political statements were uncalled for.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Decision_Turn02_Funeral_Attend"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[195]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1"*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I have always valued the right to peaceful protest. Any assertion otherwise is a misunderstanding.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true`
- **Kontekst wejściowy (poprzednik):** `[195]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1"*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The discussions with Gasom are an ongoing process, and I am committed to finding the best possible outcome for the workers of Narbel.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true) == false` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[217]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player: "“I understand your frustration. Be assured, I will push h..."*)
  - -> `[104]` (*Player: "“The journey may be challenging, but I remain dedicated. ..."*)

### Węzeł `[72]`
Mówca: **Denis Stahler**
> ""And what about the recent campaign finance bill, Mr. President? It's a direct attack on democracy, effectively silencing smaller parties like ours!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 1"*)

### Węzeł `[73]`
Mówca: **Katarina Horten**
> ""Mr. President, we demand that you support the upcoming Worker's Rights Bill. The labor force of Sordland will be watching your next move closely!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Denis Stahler: ""Furthermore, we want reform! Reduce the election thresho..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBene..."*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBe..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: "“As a result of our negotiations, Gasom has committed to ..."*)
  - -> `[95]` (*Player: "“Our efforts have borne fruit. Gasom will now provide bet..."*)
  - -> `[96]` (*Player: "“Through hard negotiations, we've secured a commitment fr..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == ..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: "“Gasom has recognized the value of its blue-collar worker..."*)
  - -> `[97]` (*Player: "“After much deliberation, Gasom has agreed to increase th..."*)
  - -> `[98]` (*Player: "“In acknowledgment of their indispensable workforce, Gaso..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player: "“I am pleased to announce that Gasom will play a crucial ..."*)
  - -> `[99]` (*Player: "“I have exciting news: Gasom has promised a substantial c..."*)
  - -> `[100]` (*Player: "“Gasom's dedication to Narbel's recovery has been cemente..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player: "“The discussions with Gasom are an ongoing process, and I..."*)
  - -> `[101]` (*Player: "“I must admit, we haven't been able to make as much progr..."*)
  - -> `[102]` (*Player: "“Rest assured, we are in continuous dialogue with Gasom. ..."*)
  - -> `[466]` (*Player: "“I'm not going to dignify that with a response. Gasom has..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Denis Stahler: ""And what about the recent campaign finance bill, Mr. Pre..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Education == false"*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“As a result of our negotiations, Gasom has committed to improving the living conditions for its workers. This includes providing private housing and ensuring access to healthcare and education.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true`
- **Kontekst wejściowy (poprzednik):** `[217]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Player: "“See, Mr. Stahler and Ms. Horten? I'm on your side. You c..."*)
  - -> `[89]` (*Player: "“I know it's hard to believe. But today was a victory.""*)
  - -> `[92]` (*Player: "“This is a vital step towards building a more resilient w..."*)
  - -> `[118]` (*Player: "“The effort of this government will go down in history.”"*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Gasom has recognized the value of its blue-collar workers and agreed to increase their wages. These hardworking individuals are the backbone of their operations and deserve fair compensation.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[217]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: "“A wage increase is not a mere possibility, but a fact. T..."*)
  - -> `[93]` (*Player: "“This is a substantial step towards ensuring well-being a..."*)
  - -> `[119]` (*Player: "“We have all achieved a victory today.”"*)
  - -> `[464]` (*Player: "“See, Mr. Stahler and Ms. Horten? I'm on your side. You c..."*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I am pleased to announce that Gasom will play a crucial role in the recovery of Narbel. They have pledged a significant contribution to local charities.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[217]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: "“With this contribution, Gasom is stepping up to play an ..."*)
  - -> `[94]` (*Player: "“The worst-off will benefit under these new initiatives.”"*)
  - -> `[120]` (*Player: "“This marks the beginning of a new era for the city.”"*)
  - -> `[465]` (*Player: "“See, Mr. Stahler and Ms. Horten? I'm on your side. You c..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I know it's hard to believe. But today was a victory.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Player), `[95]` (Player), `[96]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "A change came over the crowd. The angry shouts were repla..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“A wage increase is not a mere possibility, but a fact. This is a landmark moment.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Player), `[97]` (Player), `[98]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "The air suddenly felt somewhat lighter. Murmurs of conver..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“With this contribution, Gasom is stepping up to play an essential part in the recovery and development of Narbel.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Player), `[99]` (Player), `[100]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "I could hear the crowd growing restless. They once again ..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“This is a vital step towards building a more resilient workforce.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Player), `[95]` (Player), `[96]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "A change came over the crowd. The angry shouts were repla..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“This is a substantial step towards ensuring well-being and prosperity for all workers, not just Gasom's.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Player), `[97]` (Player), `[98]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "The air suddenly felt somewhat lighter. Murmurs of conver..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The worst-off will benefit under these new initiatives.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Player), `[99]` (Player), `[100]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "I could hear the crowd growing restless. They once again ..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Our efforts have borne fruit. Gasom will now provide better housing, healthcare, and education for every worker.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true`
- **Kontekst wejściowy (poprzednik):** `[217]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Player: "“See, Mr. Stahler and Ms. Horten? I'm on your side. You c..."*)
  - -> `[89]` (*Player: "“I know it's hard to believe. But today was a victory.""*)
  - -> `[92]` (*Player: "“This is a vital step towards building a more resilient w..."*)
  - -> `[118]` (*Player: "“The effort of this government will go down in history.”"*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Through hard negotiations, we've secured a commitment from Gasom to significantly better the lives of its employees. Upgraded housing, assured healthcare, and opportunities for education are now guaranteed.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true`
- **Kontekst wejściowy (poprzednik):** `[217]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Player: "“See, Mr. Stahler and Ms. Horten? I'm on your side. You c..."*)
  - -> `[89]` (*Player: "“I know it's hard to believe. But today was a victory.""*)
  - -> `[92]` (*Player: "“This is a vital step towards building a more resilient w..."*)
  - -> `[118]` (*Player: "“The effort of this government will go down in history.”"*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“After much deliberation, Gasom has agreed to increase the wages of the blue-collar workers on whose labor its success rests.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[217]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: "“A wage increase is not a mere possibility, but a fact. T..."*)
  - -> `[93]` (*Player: "“This is a substantial step towards ensuring well-being a..."*)
  - -> `[119]` (*Player: "“We have all achieved a victory today.”"*)
  - -> `[464]` (*Player: "“See, Mr. Stahler and Ms. Horten? I'm on your side. You c..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“In acknowledgment of their indispensable workforce, Gasom has decided to raise the wages of its blue-collar workers.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[217]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: "“A wage increase is not a mere possibility, but a fact. T..."*)
  - -> `[93]` (*Player: "“This is a substantial step towards ensuring well-being a..."*)
  - -> `[119]` (*Player: "“We have all achieved a victory today.”"*)
  - -> `[464]` (*Player: "“See, Mr. Stahler and Ms. Horten? I'm on your side. You c..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I have exciting news: Gasom has promised a substantial contribution to local charities, a move that will play a central role in the recovery efforts for Narbel.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[217]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: "“With this contribution, Gasom is stepping up to play an ..."*)
  - -> `[94]` (*Player: "“The worst-off will benefit under these new initiatives.”"*)
  - -> `[120]` (*Player: "“This marks the beginning of a new era for the city.”"*)
  - -> `[465]` (*Player: "“See, Mr. Stahler and Ms. Horten? I'm on your side. You c..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Gasom's dedication to Narbel's recovery has been cemented with their promise of a large contribution to local charities.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[217]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: "“With this contribution, Gasom is stepping up to play an ..."*)
  - -> `[94]` (*Player: "“The worst-off will benefit under these new initiatives.”"*)
  - -> `[120]` (*Player: "“This marks the beginning of a new era for the city.”"*)
  - -> `[465]` (*Player: "“See, Mr. Stahler and Ms. Horten? I'm on your side. You c..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I must admit, we haven't been able to make as much progress with Gasom as we had hoped. But I remain committed to finding a solution.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true) == false` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[217]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player: "“I understand your frustration. Be assured, I will push h..."*)
  - -> `[104]` (*Player: "“The journey may be challenging, but I remain dedicated. ..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Rest assured, we are in continuous dialogue with Gasom. I remain steadfast in my pursuit of better conditions for Narbel's workers.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true) == false` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[217]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player: "“I understand your frustration. Be assured, I will push h..."*)
  - -> `[104]` (*Player: "“The journey may be challenging, but I remain dedicated. ..."*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I understand your frustration. Be assured, I will push harder in the negotiations. The well-being of Narbel's workers is my priority.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Player), `[101]` (Player), `[102]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Denis Stahler: ""At least you're not hiding your lack of progress anymore..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The journey may be challenging, but I remain dedicated. Our workers deserve better, and I won't rest until we achieve that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Player), `[101]` (Player), `[102]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Denis Stahler: ""At least you're not hiding your lack of progress anymore..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Narrator: "Eventually, all fell silent as they waited for Denis and ..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Denis Stahler: ""Charitable contributions, Mr. President? Is that all Gas..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ==..."*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Player: ""With all due respect to the Kingdom, I believe Sordland ..."*)
  - -> `[263]` (*Player: ""Our nation will shoulder the investment for Gasom. It's ..."*)
  - -> `[264]` (*Player: ""The government of Sordland has decided to solely invest ..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Player: ""In a show of international cooperation, Sordland and Riz..."*)
  - -> `[266]` (*Player: ""We are sharing the costs and stakes with Rizia. This way..."*)
  - -> `[267]` (*Player: ""Sordland is renewing its ties with the Kingdom of Rizia...."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Player: ""Our government has chosen not to invest at this time. We..."*)
  - -> `[269]` (*Player: ""Rizia has invested in Sordland before, and they will do ..."*)
  - -> `[270]` (*Player: ""At this time, we won't be investing in Gasom. This decis..."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "A change came over the crowd. The angry shouts were replaced with cries of disbelief, then joy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension -= 2"*)

### Węzeł `[114]`
Mówca: **Narrator**
> "The air suddenly felt somewhat lighter. Murmurs of conversation started to percolate through the crowd, signs of animosity dwindling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1"*)

### Węzeł `[115]`
Mówca: **Narrator**
> "I could hear the crowd growing restless. They once again broke into discontented murmurs, punctuated by the occasional shout."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 1"*)

### Węzeł `[116]`
Mówca: **Narrator**
> "The crowd roared back to life. I could practically feel the raw anger emanating from them. My guards took a step forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Denis Stahler: ""Time is a luxury we don't have, Mr. President. Each pass..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Katarina Horten: ""And until we get them, we will continue to fight!""*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The effort of this government will go down in history.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Player), `[95]` (Player), `[96]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "A change came over the crowd. The angry shouts were repla..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We have all achieved a victory today.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Player), `[97]` (Player), `[98]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "The air suddenly felt somewhat lighter. Murmurs of conver..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“This marks the beginning of a new era for the city.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Player), `[99]` (Player), `[100]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "I could hear the crowd growing restless. They once again ..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_DonatedToFoundation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_DonatedToFoundation == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_DonatedToFoundation == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_DonatedToFoundation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_DonatedToFoundation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player: "“I would like to announce that I've personally donated a ..."*)
  - -> `[125]` (*Player: "“I have made the decision to donate part of my own income..."*)
  - -> `[126]` (*Player: "“You'll be pleased to know that I've allocated a portion ..."*)
  - -> `[130]` (*Player: "“What if I told you I decided to give away a fraction of ..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_DonatedToFoundation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_DonatedToFoundation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "A group of figures emerged from the crowd, adorned in unm..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I would like to announce that I've personally donated a portion of my salary to the Alphonso Foundation. It's a small step, but one that I believe can help those struggling with homelessness and income inequality.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Ewald_DonatedToFoundation"] == true` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[129]` (Narrator), `[237]` (Katarina Horten), `[241]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1"*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I have made the decision to donate part of my own income to the Alphonso Foundation. In a position of power, it's important to lead by example, isn't it? Together, we can make a difference.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Ewald_DonatedToFoundation"] == true` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[129]` (Narrator), `[237]` (Katarina Horten), `[241]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 1"*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“You'll be pleased to know that I've allocated a portion of my rather substantial salary to the Alphonso Foundation. It's the least I can do, considering my privileged position.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Ewald_DonatedToFoundation"] == true` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[129]` (Narrator), `[237]` (Katarina Horten), `[241]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1"*)

### Węzeł `[127]`
Mówca: **Denis Stahler**
> ""At least you're not hiding your lack of progress anymore. Mere determination won't solve the workers' problems. We need results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 2"*)

### Węzeł `[128]`
Mówca: **Katarina Horten**
> ""And until we get them, we will continue to fight!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "The crowd roared back to life. I could practically feel t..."*)

### Węzeł `[129]`
Mówca: **Narrator**
> "The undercurrent of unrest swelled, threatening to surge into a full-blown tempest. The previous calm seemed like a distant memory, an illusion shattered by the harsh reality of discontent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_DonatedToFoundation == true"*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“What if I told you I decided to give away a fraction of my salary to the Alphonso Foundation? Would that make you happy?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Ewald_DonatedToFoundation"] == true` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[129]` (Narrator), `[237]` (Katarina Horten), `[241]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 1"*)

### Węzeł `[131]`
Mówca: **Reporter**
> ""Mr. President, it's no secret that there was a significant divide during the party leadership campaign involving you and former President Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Reporter: ""Did this 'bad blood' influence your negotiations with Ga..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Nationalist == t..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "The sight of them transported me back to my days among th..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Nationalist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Socialist == true)"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "The sight of them triggered nostalgia, memories of days f..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Socialist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "I realized this was no longer a mere protest. It was a sy..."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "The sight of them transported me back to my days among the Young Sords, when face-offs with those clad in crimson were frequent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "I realized this was no longer a mere protest. It was a sy..."*)

### Węzeł `[139]`
Mówca: **Narrator**
> "The sight of them triggered nostalgia, memories of days filled with protests and camaraderie during our time at university."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "I realized this was no longer a mere protest. It was a sy..."*)

### Węzeł `[140]`
Mówca: **Narrator**
> "I saw a few officers with nervous faces, belying their inexperience. They stood at attention, visibly on edge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)

### Węzeł `[141]`
Mówca: **Narrator**
> "Out of nowhere, a man lunged towards me from the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Narrator: "Before I could react, Serge sprang in front of me. He swi..."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "The reporter jumped in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Reporter: ""Can you clarify the current status of your personal rela..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Denis, the focus here is not on narratives or images but on real, tangible changes. It's a process, and we are on the right track.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Denis Stahler: ""Words, words, and more words, President Rayne. What the ..."*)

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I understand your skepticism, Denis. But I assure you my administration is devoted to bringing about better conditions for our workers.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Denis Stahler: ""Your words are compelling, President Rayne. But can they..."*)

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“You're an academic and a lawyer, Mr. Stahler. What do you really know about the struggles of the working class?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Denis Stahler), `[61]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Denis Stahler: ""I know that they deserve better than a president who put..."*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“You're right, Denis. The days of corporate favoritism must come to an end. If not overnight, then soon.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Denis Stahler: ""Finally, Rayne, you acknowledge the problem! But acknowl..."*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Change may not come as quickly as you want, Denis. But your claims of corporate favoritism don't reflect the complexity of the situation.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Denis Stahler: ""Then what just happened in that building, President Rayn..."*)

### Węzeł `[148]`
Mówca: **Denis Stahler**
> ""Words, words, and more words, President Rayne. What the workers need are actions, not promises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Katarina Horten: ""Exactly, Denis. The working class of Sordland is still w..."*)

### Węzeł `[149]`
Mówca: **Denis Stahler**
> ""Your words are compelling, President Rayne. But can they truly outweigh the years of corporate dominance?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Katarina Horten: ""Your intentions sound noble, President Rayne. But intent..."*)

### Węzeł `[150]`
Mówca: **Denis Stahler**
> ""I know that they deserve better than a president who puts corporate interests over human well-being.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Katarina Horten: ""Attacking Mr. Stahler's personal background accomplishes..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Change is often slow and gradual. Not all solutions are as immediate and straightforward as you make them out to be.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Denis Stahler), `[61]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Denis Stahler: ""Your indifference is appalling, President Rayne! The wor..."*)

### Węzeł `[152]`
Mówca: **Denis Stahler**
> ""Your indifference is appalling, President Rayne! The working class can't afford the luxury of time you're so fond of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Katarina Horten: ""We have had it with excuses, President Rayne! The worker..."*)

### Węzeł `[153]`
Mówca: **Katarina Horten**
> ""We have had it with excuses, President Rayne! The workers of Sordland need immediate solutions!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 1"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[155]`
Mówca: **Katarina Horten**
> ""Exactly, Denis. The working class of Sordland is still waiting for those actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[156]`
Mówca: **Katarina Horten**
> ""Your intentions sound noble, President Rayne. But intentions alone don't feed families or pay bills. We need concrete actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[157]`
Mówca: **Katarina Horten**
> ""Attacking Mr. Stahler's personal background accomplishes nothing, Mr. President. What do you have to say to the workers of this nation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 1"*)

### Węzeł `[158]`
Mówca: **Denis Stahler**
> ""Then what just happened in that building, President Rayne? Did you advocate for Gasom's workers, or will its executives only be getting richer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Katarina Horten: ""There are mothers in Narbel who cannot afford to feed th..."*)

### Węzeł `[159]`
Mówca: **Denis Stahler**
> ""Finally, Rayne, you acknowledge the problem! But acknowledging is not enough. We need action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Katarina Horten: ""So, President Rayne agrees with Denis! But will this rea..."*)

### Węzeł `[160]`
Mówca: **Katarina Horten**
> ""So, President Rayne agrees with Denis! But will this realization actually result in action?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[161]`
Mówca: **Katarina Horten**
> ""There are mothers in Narbel who cannot afford to feed their children. Where is the complexity in that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 1"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_Funeral_Attend == false"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Education == false"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] <= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "Despite the sharp words exchanged, the crowd remained eer..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] <= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "Quiet murmurs of discontent began to ripple through the c..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Education == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Education == false"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Education == false)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Education == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Education"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Katarina Horten: ""It's clear from your lack of commitment to education tha..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Education == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Education"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == false"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == false"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Health == false)"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Denis Stahler: ""Your neglect of our nation's healthcare system will harm..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Health == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == false && BaseGame.Pr..."*)

### Węzeł `[177]`
Mówca: **Katarina Horten**
> ""It's clear from your lack of commitment to education that you don't fully comprehend the scope of the challenges faced by our workers' families.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == false"*)

### Węzeł `[178]`
Mówca: **Denis Stahler**
> ""Your neglect of our nation's healthcare system will harm millions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == false && BaseGame.Pr..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == false && BaseGame.Promise_TermFocus_Education == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == false && BaseGame.Pr..."*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Health == false && BaseGame...."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == false && BaseGame.Promise_TermFocus_Education == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == false  and  Variable["BaseGame.Promise_TermFocus_Education"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 1"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Health == false && BaseGame.Promise_TermFocus_Education == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == false  and  Variable["BaseGame.Promise_TermFocus_Education"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Katarina Horten: ""Mr. President, we demand that you support the upcoming W..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Katarina Horten: ""Mr. President, we demand that you support the upcoming W..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true"*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == ..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Player: ""While the increased police force may have its challenges..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_StatusReaction_WarnTraitors ==..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player: "“I have always valued the right to peaceful protest. Any ..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_Funeral_Attend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_Funeral_Attend == true"*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_Funeral_Attend == true)"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_Funeral_Attend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_Funeral_Attend"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_Funeral_Attend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_Funeral_Attend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: "“My absence at Bernard Circas's funeral was not an endors..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesse..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: "“The business bailout was a necessary step to protect the..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[195]`
Mówca: **Denis Stahler**
> ""Furthermore, we want reform! Reduce the election threshold and change the constitution to make a more democratic and fairer nation!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player: ""The people of Sordland have elected me to lead. I believ..."*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_Funeral_Attend == true"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == false && BaseGame.Pr..."*)
  - -> `[197]` (*Player: ""I understand the concerns and frustrations many of you h..."*)
  - -> `[198]` (*Player: ""We must recognize that our country can't solve all its p..."*)
  - -> `[461]` (*Player: ""How dare you speak that way to your president! You ingra..."*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The people of Sordland have elected me to lead. I believe it's crucial to trust the government's judgement in these times of crisis.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 1"*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand the concerns and frustrations many of you have. Rest assured, we are here, we are listening, and we are committed to addressing these issues.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3"*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We must recognize that our country can't solve all its problems at once. We are working hard and making progress, but our troubles won't simply vanish.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 1"*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The campaign finance bill ensures fair funding for democratically elected parties. It's not an attack on democracy but a measure to safeguard it.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true`
- **Kontekst wejściowy (poprzednik):** `[195]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1"*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""While the increased police force may have its challenges, it's crucial for maintaining peace and order in our society. Their training and experience will improve over time.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true`
- **Kontekst wejściowy (poprzednik):** `[195]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player: ""The campaign finance bill ensures fair funding for democ..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == false && BaseGame.Promise_TermFocus_Education == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == false && BaseGame.Pr..."*)
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Health == false && BaseGame...."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == false && BaseGame.Promise_TermFocus_Education == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == false  and  Variable["BaseGame.Promise_TermFocus_Education"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Player: ""On healthcare and education, I hear your concerns. While..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Health == false && BaseGame.Promise_TermFocus_Education == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == false  and  Variable["BaseGame.Promise_TermFocus_Education"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""On healthcare and education, I hear your concerns. While these areas may not be our immediate focus, we are yet to finalize the government budget and are giving thoughtful consideration to those areas.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Promise_TermFocus_Health"] == false  and  Variable["BaseGame.Promise_TermFocus_Education"] == false`
- **Kontekst wejściowy (poprzednik):** `[195]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_Backstab == true)"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Reporter: ""Mr. President, it's no secret that there was a significa..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_Backstab == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Reporter: ""Could you shed some light on the possible deal between t..."*)

### Węzeł `[214]`
Mówca: **Narrator**
> "Suddenly, a reporter pushed through the crowd, brandishing a microphone towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "AddConversant("Reporter");"*)

### Węzeł `[215]`
Mówca: **Reporter**
> ""The locals of Narbel have suffered under the impact of Gasom for years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Reporter: ""What concrete steps is Gasom going to take for the benef..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Reporter");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Reporter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Reporter: ""The locals of Narbel have suffered under the impact of G..."*)

### Węzeł `[217]`
Mówca: **Reporter**
> ""What concrete steps is Gasom going to take for the benefit of the local community?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBene..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_A_Protestors_Uproar = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn03_A_Protestors_Uproar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_A_Protestors_Mixed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn03_A_Protestors_Mixed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_A_Protestors_Calm = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn03_A_Protestors_Calm"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[221]`
Mówca: **Narrator**
> "Katarina and Denis raised their hands in a plea for calm, their words nearly lost amidst the turmoil."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Katarina Horten: ""Stop the cops! This isn't going to help!""*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == ..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "I saw a few officers with nervous faces, belying their in..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBene..."*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBe..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Denis Stahler: ""If these promises materialize, it could mean a significa..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == ..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Denis Stahler: ""So our blue-collar comrades are finally getting the atte..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_DonatedToFoundation == true"*)

### Węzeł `[235]`
Mówca: **Katarina Horten**
> ""Private housing, healthcare, and education? That's indeed a shift from the status quo, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Katarina Horten: ""While I commend this commitment to improve the lives of ..."*)

### Węzeł `[236]`
Mówca: **Denis Stahler**
> ""If these promises materialize, it could mean a significant improvement in the lives of our comrades at Gasom. This is a start, albeit late. Let's hope it's not mere lip service.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Katarina Horten: ""Private housing, healthcare, and education? That's indee..."*)

### Węzeł `[237]`
Mówca: **Katarina Horten**
> ""While I commend this commitment to improve the lives of our Gasom workers, we can only hope this is not just another political gambit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_DonatedToFoundation == true"*)

### Węzeł `[238]`
Mówca: **Denis Stahler**
> ""So our blue-collar comrades are finally getting the attention they deserve, are they? I must admit, that's a step forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Denis Stahler: ""But let's not forget, President Rayne, that this is only..."*)

### Węzeł `[239]`
Mówca: **Katarina Horten**
> ""An increase in wages, finally! It's about time, Mr. President. While I appreciate this apparent commitment, let's not pat ourselves on the back just yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Katarina Horten: ""Real success will be measured in the paychecks of the wo..."*)

### Węzeł `[240]`
Mówca: **Denis Stahler**
> ""But let's not forget, President Rayne, that this is only correcting a long-standing injustice. We will wait and see if these are empty promises or if you truly intend to uphold the rights of our working class.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Katarina Horten: ""An increase in wages, finally! It's about time, Mr. Pres..."*)

### Węzeł `[241]`
Mówca: **Katarina Horten**
> ""Real success will be measured in the paychecks of the workers, not in words spoken here today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_DonatedToFoundation == true"*)

### Węzeł `[242]`
Mówca: **Denis Stahler**
> ""Charitable contributions, Mr. President? Is that all Gasom can offer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Denis Stahler: ""While the effort is appreciated, these gestures do littl..."*)

### Węzeł `[243]`
Mówca: **Katarina Horten**
> ""What we need, Mr. President, is not a one-time act of charity, but a sustained commitment to improving the living conditions and wage disparity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Katarina Horten: ""Gasom's 'charity' must not be used as a smokescreen to c..."*)

### Węzeł `[244]`
Mówca: **Denis Stahler**
> ""While the effort is appreciated, these gestures do little to address the structural inequalities faced by the workers. We need systemic change, not charity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Katarina Horten: ""What we need, Mr. President, is not a one-time act of ch..."*)

### Węzeł `[245]`
Mówca: **Katarina Horten**
> ""Gasom's 'charity' must not be used as a smokescreen to cover their ongoing exploitation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_DonatedToFoundation == true"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true"*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true)"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Katarina Horten: ""That's rich, Mr. President! Donating a fraction of your ..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "A group of figures emerged from the crowd, adorned in unm..."*)

### Węzeł `[249]`
Mówca: **Katarina Horten**
> ""That's rich, Mr. President! Donating a fraction of your salary while our people continue to suffer. How generous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Denis Stahler: ""The Alphonso Foundation? More like the President's perso..."*)

### Węzeł `[250]`
Mówca: **Denis Stahler**
> ""The Alphonso Foundation? More like the President's personal PR project. Let's not forget the true struggles of the Sordish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 1"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "A group of figures emerged from the crowd, adorned in unm..."*)

### Węzeł `[252]`
Mówca: **Narrator**
> "The police began reorganizing their ranks, adopting defensive postures."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true"*)

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The past is the past. Personal disagreements have no place in matters of national importance. Our discussions were focused solely on what was best for Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Reporter: ""Could you shed some light on the possible deal between t..."*)

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We did have our disagreements, but I won't allow personal matters to obstruct progress. We're both professional enough to separate politics from the welfare of the nation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Reporter: ""Could you shed some light on the possible deal between t..."*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The rift between former President Alphonso and myself did present obstacles in the negotiations. His reluctance to find common ground was a hurdle.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Narrator: "Gus stepped in."*)

### Węzeł `[256]`
Mówca: **Reporter**
> ""Could you shed some light on the possible deal between the Sordish government and Gasom?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Reporter: ""What role does the Kingdom of Rizia play in this arrange..."*)

### Węzeł `[257]`
Mówca: **Reporter**
> ""Did this 'bad blood' influence your negotiations with Gasom?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player: ""The past is the past. Personal disagreements have no pla..."*)
  - -> `[254]` (*Player: ""We did have our disagreements, but I won't allow persona..."*)
  - -> `[255]` (*Player: ""The rift between former President Alphonso and myself di..."*)
  - -> `[258]` (*Player: "“No comment.”"*)

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“No comment.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Reporter: ""Could you shed some light on the possible deal between t..."*)

### Węzeł `[259]`
Mówca: **Gus Manger**
> "“To clarify, we tried our best to mediate and negotiate a best possible outcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Reporter: ""Could you shed some light on the possible deal between t..."*)

### Węzeł `[260]`
Mówca: **Narrator**
> "Gus stepped in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Gus Manger: "“To clarify, we tried our best to mediate and negotiate a..."*)

### Węzeł `[261]`
Mówca: **Reporter**
> ""What role does the Kingdom of Rizia play in this arrangement?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ==..."*)
  - -> `[478]` (*Player: ""That's confidential, ma'am.""*)
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 &&..."*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""With all due respect to the Kingdom, I believe Sordland knows whats best for Sordish companies. That's why our government is investing in Gasom alone.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true`
- **Kontekst wejściowy (poprzednik):** `[261]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Denis Stahler: ""A surprising but potentially promising decision, Mr. Pre..."*)

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Our nation will shoulder the investment for Gasom. It's a bold step, but one that underscores our commitment to self-reliance and autonomy.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true`
- **Kontekst wejściowy (poprzednik):** `[261]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Denis Stahler: ""A surprising but potentially promising decision, Mr. Pre..."*)

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The government of Sordland has decided to solely invest in Gasom. We believe this will lead to a direct positive impact on the citizens of Sordland.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true`
- **Kontekst wejściowy (poprzednik):** `[261]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Denis Stahler: ""A surprising but potentially promising decision, Mr. Pre..."*)

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""In a show of international cooperation, Sordland and Rizia will jointly invest in Gasom.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true` AND `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[261]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Denis Stahler: ""A partnership with Rizia? You are aware of the monarchy'..."*)

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We are sharing the costs and stakes with Rizia. This way, we're reducing financial pressure and fostering international relationships.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true` AND `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[261]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Denis Stahler: ""A partnership with Rizia? You are aware of the monarchy'..."*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sordland is renewing its ties with the Kingdom of Rizia. Together, we will provide the funding that Gasom and its workers need.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true` AND `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[261]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Denis Stahler: ""A partnership with Rizia? You are aware of the monarchy'..."*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Our government has chosen not to invest at this time. We believe Rizia is capable of handling the investment, giving us the opportunity to focus our resources on other pressing issues.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false` AND `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[261]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Denis Stahler: ""So, you're putting the fate of our workers in the King o..."*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Rizia has invested in Sordland before, and they will do it once again. I have faith in the Kingdom and its vision for Gasom.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false` AND `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[261]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Denis Stahler: ""So, you're putting the fate of our workers in the King o..."*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""At this time, we won't be investing in Gasom. This decision isn't made lightly, but we're confident Rizia can handle the situation.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false` AND `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[261]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Denis Stahler: ""So, you're putting the fate of our workers in the King o..."*)

### Węzeł `[271]`
Mówca: **Katarina Horten**
> ""Encouraging, President Rayne. As long as your government's drive to recoup your investment doesn't take precedent over Gasom's struggling labor force.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 &&..."*)

### Węzeł `[272]`
Mówca: **Denis Stahler**
> ""A surprising but potentially promising decision, Mr. President. Let's hope your confidence isn't misplaced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1"*)

### Węzeł `[273]`
Mówca: **Katarina Horten**
> ""We will be watching this co-investment closely. Your government will be responsible for keeping its partner's worst tendencies in check.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 &&..."*)

### Węzeł `[274]`
Mówca: **Denis Stahler**
> ""A partnership with Rizia? You are aware of the monarchy's history of stamping out disagreements with brute force.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Katarina Horten: ""We will be watching this co-investment closely. Your gov..."*)

### Węzeł `[275]`
Mówca: **Katarina Horten**
> ""Relinquishing control to a monarchy!? You are aware of Rizia's history of stamping out disagreements with brute force.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 &&..."*)

### Węzeł `[276]`
Mówca: **Denis Stahler**
> ""So, you're putting the fate of our workers in the King of Rizia's hands? That's a dangerous game you're playing, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 1"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Katarina Horten: ""Encouraging, President Rayne. As long as your government..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Katarina Horten: ""Relinquishing control to a monarchy!? You are aware of R..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 && BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 &&..."*)
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 ..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 && BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] >= 5  and  Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "PlayMusic("Suspense");"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 && BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] >= 5  and  Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension >= 3 &&..."*)

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You speak of double standards and yet fail to understand the complexities of governance! It's easy to criticize from the sidelines, but real change requires pragmatism, not idealism.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[303]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Reporter: ""One final question, what is your true personal relations..."*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You claim to advocate for the workers, yet undermine our efforts to better their condition. Shouldn't you be supporting the initiatives we've fought for, instead of spreading discontent?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[303]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Reporter: ""One final question, what is your true personal relations..."*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The utopia you dream of won't materialize by mere rhetoric or by attacking those striving for change. It requires understanding the political and economic landscape and making informed decisions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[303]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Reporter: ""One final question, what is your true personal relations..."*)

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's all remember that we're here for the same reason -- to better the lives of our citizens. Let's not allow our differences to blind us to our common goals.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Player), `[347]` (Player), `[348]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "The reporter jumped in."*)

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The path to progress is challenging and fraught with disagreement, but we must not let this divide us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Player), `[347]` (Player), `[348]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "The reporter jumped in."*)

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand your frustrations and the urge to voice your concerns. However, let's keep our discourse respectful and constructive.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[359]` (Narrator), `[362]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Player: ""This is a marathon, not a sprint.""*)
  - -> `[351]` (*Player: ""Denis, Katarina, I look forward to our continuing conver..."*)
  - -> `[285]` (*Player: ""Let's all remember that we're here for the same reason -..."*)
  - -> `[286]` (*Player: ""The path to progress is challenging and fraught with dis..."*)
  - -> `[364]` (*Player: ""Together, we can ensure a prosperous future for Sordland.""*)

### Węzeł `[288]`
Mówca: **Serge Wolkner**
> ""I recommend that we expedite your departure. We must prioritize your safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Player: ""You're absolutely right, Serge. Let's not stay here any ..."*)
  - -> `[314]` (*Player: ""Are you sure? Won't running away from this only make the..."*)

### Węzeł `[289]`
Mówca: **Serge Wolkner**
> ""It might be a good time to make our way to the convoy, before any potential escalation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Player: ""I agree, Serge. Tensions can rise quickly in such enviro..."*)
  - -> `[312]` (*Player: ""Are you sure? Won't running away from this only make the..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension >= 3 && (BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true || BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension >= 3 &&..."*)
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_AddressProtestors_Tension >= 3 ..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension >= 3 && (BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true || BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] >= 3  and  (Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true  or  Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_A_Protestors_Mixed = true"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_AddressProtestors_Tension >= 3 && (BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true || BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] >= 3  and  (Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true  or  Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_A_Protestors_Calm = true"*)

### Węzeł `[293]`
Mówca: **Serge Wolkner**
> ""It may be best to conclude your address and proceed to the vehicle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player: ""Thank you for looking out for me, Serge. Let's get out o..."*)
  - -> `[310]` (*Player: ""Are you sure? Won't running away from this only make the..."*)

### Węzeł `[294]`
Mówca: **Narrator**
> "Close by, I noticed a terse exchange between a security officer from Gasom and a member of the Presidential Guard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "Serge craned his neck, his face deep in concentration as ..."*)

### Węzeł `[295]`
Mówca: **Narrator**
> "Serge craned his neck, his face deep in concentration as he listened to their whispers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Serge Wolkner: ""Mr. President, the situation is growing increasingly vol..."*)

### Węzeł `[296]`
Mówca: **Narrator**
> "Nearby, a quick, hushed conversation was being had between a Gasom security officer and a Presidential Guard. I followed their eyes to the protestors. Some had calmed down; others still seemed agitated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "Serge craned his neck, his face deep in concentration as ..."*)

### Węzeł `[297]`
Mówca: **Narrator**
> "Serge craned his neck, his face deep in concentration as he listened to their whispers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Serge Wolkner: ""Sir, the crowd is no longer entirely hostile, but there'..."*)

### Węzeł `[298]`
Mówca: **Narrator**
> "Nearby, a Gasom security officer and a Presidential Guard member were conversing in hushed tones."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Narrator: "I saw them glance over the crowd, now calmer but still re..."*)

### Węzeł `[299]`
Mówca: **Narrator**
> "I saw them glance over the crowd, now calmer but still restless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Serge Wolkner: ""President Rayne, while the crowd appears somewhat subdue..."*)

### Węzeł `[300]`
Mówca: **Gus Manger**
> ""I'll stay back and handle things here. You should head to safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Denis Stahler: ""Leaving so soon, Rayne? I guess you know when you've bee..."*)

### Węzeł `[301]`
Mówca: **Gus Manger**
> ""Mr. President, I'll stay on to further address the crowd. The mood is still tense, but I think I can manage. You should get on your way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Denis Stahler: ""I'm impressed you even came out to speak to us, Presiden..."*)

### Węzeł `[302]`
Mówca: **Gus Manger**
> ""I'll remain here, Mr. President. The crowd seems calmer now, and I believe I can answer their queries and maintain the peace. You should go ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Katarina Horten: ""Mr. President, thank you for your willingness to address..."*)

### Węzeł `[303]`
Mówca: **Katarina Horten**
> ""You can't even face your own people, can you, Mr. President? We expected better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Player: ""You speak of double standards and yet fail to understand..."*)
  - -> `[283]` (*Player: ""You claim to advocate for the workers, yet undermine our..."*)
  - -> `[284]` (*Player: ""The utopia you dream of won't materialize by mere rhetor..."*)
  - -> `[325]` (*Player: ""No further comments.""*)

### Węzeł `[304]`
Mówca: **Denis Stahler**
> ""Leaving so soon, Rayne? I guess you know when you've been defeated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Katarina Horten: ""You can't even face your own people, can you, Mr. Presid..."*)

### Węzeł `[305]`
Mówca: **Katarina Horten**
> ""We will hold you accountable to your promises. The troubles of the laborers continue and our union is here to solve them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Narrator: "I turned to the crowd one last time. In their eyes, I saw..."*)

### Węzeł `[306]`
Mówca: **Denis Stahler**
> ""I'm impressed you even came out to speak to us, President Rayne. Most wouldn't. However, this conversation isn't over yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Katarina Horten: ""We will hold you accountable to your promises. The troub..."*)

### Węzeł `[307]`
Mówca: **Katarina Horten**
> ""Mr. President, thank you for your willingness to address us. Let's continue these important conversations moving forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Denis Stahler: ""You've shown courage today. We'll see if your actions ma..."*)

### Węzeł `[308]`
Mówca: **Denis Stahler**
> ""You've shown courage today. We'll see if your actions match your words. Until next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Katarina Horten: ""We have shown courage together. Now we will hold you acc..."*)

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you for looking out for me, Serge. Let's get out of here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[293]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Gus Manger: ""I'll remain here, Mr. President. The crowd seems calmer ..."*)

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you sure? Won't running away from this only make the protestors angrier?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[293]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Gus Manger: ""I'll remain here, Mr. President. The crowd seems calmer ..."*)

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I agree, Serge. Tensions can rise quickly in such environments. It's better we make our exit now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[289]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Gus Manger: ""Mr. President, I'll stay on to further address the crowd..."*)

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you sure? Won't running away from this only make the protestors angrier?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[289]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Gus Manger: ""Mr. President, I'll stay on to further address the crowd..."*)

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're absolutely right, Serge. Let's not stay here any longer than necessary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Gus Manger: ""I'll stay back and handle things here. You should head t..."*)

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you sure? Won't running away from this only make the protestors angrier?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Gus Manger: ""Serge is right, Mr. President. The crowd won't get any c..."*)

### Węzeł `[315]`
Mówca: **Serge Wolkner**
> ""Mr. President, the situation is growing increasingly volatile.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Serge Wolkner: ""I recommend that we expedite your departure. We must pri..."*)

### Węzeł `[316]`
Mówca: **Serge Wolkner**
> ""Sir, the crowd is no longer entirely hostile, but there's still an undercurrent of tension.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Serge Wolkner: ""It might be a good time to make our way to the convoy, b..."*)

### Węzeł `[317]`
Mówca: **Serge Wolkner**
> ""President Rayne, while the crowd appears somewhat subdued, I would advise we exercise caution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Serge Wolkner: ""It may be best to conclude your address and proceed to t..."*)

### Węzeł `[318]`
Mówca: **Reporter**
> ""Can you clarify the current status of your personal relationship with Ewa-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Serge Wolkner: ""No more questions, please.""*)

### Węzeł `[319]`
Mówca: **Reporter**
> ""One final question, what is your true personal relationship with Ew-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "Out of nowhere, a man lunged towards me from the crowd."*)

### Węzeł `[320]`
**[WYBÓR GRACZA: "Shake their hands."]** — Mówca: **Player_Italic**
> "I reached out my hand, and Katarina shook it with a smile. Denis followed suit."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] <= 3`
- **Kontekst wejściowy (poprzednik):** `[361]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "Almost immediately, the remaining tension in the crowd di..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3"*)
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3)"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] <= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Player_Italic: "Shake their hands."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] <= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Player_Italic: "Shake their hands."*)

### Węzeł `[324]`
**[WYBÓR GRACZA: "Shake their hands."]** — Mówca: **Player_Italic**
> "I reached out my hand, and Katarina reluctantly shook it. Denis followed suit."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] <= 3) == false`
- **Kontekst wejściowy (poprzednik):** `[361]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Narrator: "A flutter of whispers rippled through the sea of onlooker..."*)

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No further comments.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[303]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Reporter: ""One final question, what is your true personal relations..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_A_Protestors_Mixed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_A_Protestors_Mixed == true"*)
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_A_Protestors_Mixed == true)"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_A_Protestors_Mixed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_A_Protestors_Mixed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Narrator: "As we started moving, some disgruntled protestors rushed ..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_A_Protestors_Mixed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_A_Protestors_Mixed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Narrator: "The crowd began to disperse, the individuals breaking awa..."*)

### Węzeł `[329]`
Mówca: **Narrator**
> "Serge left my dazed attacker on the ground and turned to the guards with a look of authority I'd never seen before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Serge Wolkner: "<shout>""PROTECT THE PRESIDENT!"</shout>"*)

### Węzeł `[330]`
Mówca: **Narrator**
> "His voice carried over the screams of the crowd. The guards tightened their circle around me, hurriedly pushing me towards the safety of the convoy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Denis Stahler: ""Everyone, remain calm!""*)

### Węzeł `[331]`
Mówca: **Narrator**
> "Police and security forces rushed into the melee, swinging batons with indiscriminate ferocity. The Red Youth rushed at them head-on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true"*)

### Węzeł `[332]`
Mówca: **Katarina Horten**
> ""Stop the cops! This isn't going to help!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Gus Manger: ""Back off! You're only making things worse!""*)

### Węzeł `[333]`
Mówca: **Denis Stahler**
> ""Everyone, remain calm!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Narrator: "Police and security forces rushed into the melee, swingin..."*)

### Węzeł `[334]`
Mówca: **Narrator**
> "Their screams receded into the background as we left the chaotic scene behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Map_Music_Tense");"*)

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Give him hell, Serge!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[341]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Narrator: "Serge left my dazed attacker on the ground and turned to ..."*)

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's get out of here!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[341]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Narrator: "Serge left my dazed attacker on the ground and turned to ..."*)

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Everyone calm down!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[341]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Narrator: "Serge left my dazed attacker on the ground and turned to ..."*)

### Węzeł `[338]`
Mówca: **Gus Manger**
> ""Back off! You're only making things worse!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Reporter");"*)

### Węzeł `[339]`
Mówca: **Narrator**
> "The staff and I were swiftly escorted into the convoy. The protestors and police scattered as our vehicles plowed through the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Narrator: "Their screams receded into the background as we left the ..."*)

### Węzeł `[340]`
Mówca: **Serge Wolkner**
> ""Into the car, Mr. President! We are leaving NOW!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Narrator: "Katarina and Denis raised their hands in a plea for calm,..."*)

### Węzeł `[341]`
Mówca: **Narrator**
> "Before I could react, Serge sprang in front of me. He swiftly tackled the man to the ground and pinned his hands behind his back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Player: ""Give him hell, Serge!""*)
  - -> `[336]` (*Player: ""Let's get out of here!""*)
  - -> `[337]` (*Player: ""Everyone calm down!""*)
  - -> `[342]` (*Player_Italic: "Freeze in panic."*)

### Węzeł `[342]`
**[WYBÓR GRACZA: "Freeze in panic."]** — Mówca: **Player_Italic**
> "I froze in panic."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[341]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Narrator: "Serge left my dazed attacker on the ground and turned to ..."*)

### Węzeł `[343]`
Mówca: **Narrator**
> "The nervous officers I'd seen before now looked completely overwhelmed. They lashed out left and right, hitting protestors, Red Youth members and their own colleagues alike."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Serge Wolkner: ""Into the car, Mr. President! We are leaving NOW!""*)

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thanks to both of you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[361]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Narrator: "A flutter of whispers rippled through the sea of onlooker..."*)

### Węzeł `[345]`
Mówca: **Serge Wolkner**
> ""No more questions, please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Serge Wolkner: ""Mr. President, if you could please proceed to the vehicle.""*)

### Węzeł `[346]`
Mówca: **Serge Wolkner**
> ""Mr. President, if you could please proceed to the vehicle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Reporter");"*)

### Węzeł `[347]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, the dialogue has only started. I assure you both, my commitment to progress and change is unwavering.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[359]` (Narrator), `[362]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Player: ""This is a marathon, not a sprint.""*)
  - -> `[351]` (*Player: ""Denis, Katarina, I look forward to our continuing conver..."*)
  - -> `[285]` (*Player: ""Let's all remember that we're here for the same reason -..."*)
  - -> `[286]` (*Player: ""The path to progress is challenging and fraught with dis..."*)
  - -> `[364]` (*Player: ""Together, we can ensure a prosperous future for Sordland.""*)

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Indeed, accountability is the cornerstone of democracy. As your president, I understand that responsibility.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[359]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Player: ""This is a marathon, not a sprint.""*)
  - -> `[351]` (*Player: ""Denis, Katarina, I look forward to our continuing conver..."*)
  - -> `[285]` (*Player: ""Let's all remember that we're here for the same reason -..."*)
  - -> `[286]` (*Player: ""The path to progress is challenging and fraught with dis..."*)
  - -> `[364]` (*Player: ""Together, we can ensure a prosperous future for Sordland.""*)

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Most wouldn't come out because most fear facing the truth. As for the conversation, it's always been going on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[359]` (Narrator), `[362]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Player: ""This is a marathon, not a sprint.""*)
  - -> `[351]` (*Player: ""Denis, Katarina, I look forward to our continuing conver..."*)
  - -> `[285]` (*Player: ""Let's all remember that we're here for the same reason -..."*)
  - -> `[286]` (*Player: ""The path to progress is challenging and fraught with dis..."*)
  - -> `[364]` (*Player: ""Together, we can ensure a prosperous future for Sordland.""*)

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My job is to listen and act. As for accountability, isn't that what all governments should be held to? You have my word.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[362]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Player: ""This is a marathon, not a sprint.""*)
  - -> `[351]` (*Player: ""Denis, Katarina, I look forward to our continuing conver..."*)
  - -> `[285]` (*Player: ""Let's all remember that we're here for the same reason -..."*)
  - -> `[286]` (*Player: ""The path to progress is challenging and fraught with dis..."*)
  - -> `[364]` (*Player: ""Together, we can ensure a prosperous future for Sordland.""*)

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Denis, Katarina, I look forward to our continuing conversations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Player), `[347]` (Player), `[348]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "The reporter jumped in."*)

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is a marathon, not a sprint.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Player), `[347]` (Player), `[348]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "The reporter jumped in."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Socialist == true)"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Player: ""As an old Red Youth member, I can personally say that th..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Socialist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As an old Red Youth member, I can personally say that the work you do is of utmost importance. Thank you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Kontekst wejściowy (poprzednik):** `[361]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Narrator: "A flutter of whispers rippled through the sea of onlooker..."*)

### Węzeł `[357]`
Mówca: **Narrator**
> "Almost immediately, the remaining tension in the crowd dissipated. A few workers nearby broke into scattered applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Narrator: "The initially hesitant clapping grew louder, and jubilant..."*)

### Węzeł `[358]`
Mówca: **Narrator**
> "A flutter of whispers rippled through the sea of onlookers, their eyes darting back and forth between us in surprise. A few broke into scattered applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Narrator: "The initially hesitant clapping grew louder, and jubilant..."*)

### Węzeł `[359]`
Mówca: **Narrator**
> "Their collective gaze bore into me, awaiting my words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Player: ""Yes, the dialogue has only started. I assure you both, m..."*)
  - -> `[348]` (*Player: ""Indeed, accountability is the cornerstone of democracy. ..."*)
  - -> `[349]` (*Player: ""Most wouldn't come out because most fear facing the trut..."*)
  - -> `[287]` (*Player: ""I understand your frustrations and the urge to voice you..."*)

### Węzeł `[360]`
Mówca: **Narrator**
> "I turned to the crowd one last time. In their eyes, I saw both flashes of anger and glimmers of hope."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Narrator: "Their collective gaze bore into me, awaiting my words."*)

### Węzeł `[361]`
Mówca: **Katarina Horten**
> ""We have shown courage together. Now we will hold you accountable to your promises. The troubles of the laborers are not over, and neither is the work of our union.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3"*)
  - -> `[344]` (*Player: ""Thanks to both of you.""*)
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)

### Węzeł `[362]`
Mówca: **Narrator**
> "As I readied myself to leave, I turned back to Katarina and Denis a last time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Player: ""Yes, the dialogue has only started. I assure you both, m..."*)
  - -> `[349]` (*Player: ""Most wouldn't come out because most fear facing the trut..."*)
  - -> `[350]` (*Player: ""My job is to listen and act. As for accountability, isn'..."*)
  - -> `[287]` (*Player: ""I understand your frustrations and the urge to voice you..."*)

### Węzeł `[363]`
Mówca: **Narrator**
> "The initially hesitant clapping grew louder, and jubilant cheers and whistles filled the air. I saw the Red Youth members standing at the edge of the crowd with their arms folded, a hint of approval in their eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Narrator: "As I readied myself to leave, I turned back to Katarina a..."*)

### Węzeł `[364]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Together, we can ensure a prosperous future for Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Player), `[347]` (Player), `[348]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "The reporter jumped in."*)

### Węzeł `[365]`
Mówca: **Narrator**
> "Serge opened the door of the car and I lowered myself into the seat. The door closed behind me with a thud, sealing off the external noise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_A_Protestors_Mixed == true"*)

### Węzeł `[366]`
Mówca: **Narrator**
> "The crowd began to disperse, the individuals breaking away to let our convoy through. The guards took their position nonetheless, forming a human barrier around the vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Narrator: "The engine purred to life, and we began to move."*)

### Węzeł `[367]`
Mówca: **Narrator**
> "The engine purred to life, and we began to move."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == true"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_Friend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == true"*)
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Serge_Friend == true)"*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_Friend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Serge_Friend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Serge Wolkner: ""I had no doubt about your capability to handle this, Pre..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Serge_Friend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Serge_Friend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Serge Wolkner: ""I'm glad we are safely on our way, Mr. President.""*)

### Węzeł `[371]`
Mówca: **Serge Wolkner**
> ""I had no doubt about your capability to handle this, President Rayne. Still, I was worried for your safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Player: ""Thanks for your concern, Serge. It was tense, but knowin..."*)
  - -> `[380]` (*Player: ""Serge, in this role, danger comes with the territory. Bu..."*)
  - -> `[381]` (*Player: ""Don't forget, a President has to face these situations h..."*)
  - -> `[384]` (*Player: ""A little excitement to keep us on our toes, wasn't it?""*)

### Węzeł `[372]`
Mówca: **Serge Wolkner**
> ""I'm glad we are safely on our way, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Player: ""Serge, in this role, danger comes with the territory. Bu..."*)
  - -> `[384]` (*Player: ""A little excitement to keep us on our toes, wasn't it?""*)
  - -> `[382]` (*Player: ""Thank you, Serge. I don't know what I'd do without you.""*)
  - -> `[383]` (*Player: ""Agreed, Serge. A job well done by you and the team.""*)

### Węzeł `[373]`
Mówca: **Narrator**
> "As we started moving, some disgruntled protestors rushed towards us. I could hear shouts and jeers as their fists pounded against the glass windows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "The guards sprang into action, pushing back the unruly cr..."*)

### Węzeł `[374]`
Mówca: **Narrator**
> "The guards sprang into action, pushing back the unruly crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Narrator: "It was a tense few moments before the convoy was able to ..."*)

### Węzeł `[375]`
Mówca: **Narrator**
> "It was a tense few moments before the convoy was able to navigate away from the tumult."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == true"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true"*)
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == ..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "The nervous officers I'd seen before now looked completel..."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Serge Wolkner: ""Into the car, Mr. President! We are leaving NOW!""*)

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thanks for your concern, Serge. It was tense, but knowing you and the team were there made all the difference.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[371]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Serge Wolkner: ""We're here to serve and protect, Mr. President. It's a d..."*)

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Serge, in this role, danger comes with the territory. But your concern is appreciated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[371]` (Serge Wolkner), `[372]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Serge Wolkner: ""It's not just part of the job, sir. It's a matter of per..."*)

### Węzeł `[381]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't forget, a President has to face these situations head-on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[371]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Serge Wolkner: ""You're right, sir. It's part of the job, after all.""*)

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Serge. I don't know what I'd do without you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[372]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Serge Wolkner: ""I'm merely doing my job, Mr. President. Ensuring your sa..."*)

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Agreed, Serge. A job well done by you and the team.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[372]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Serge Wolkner: ""We appreciate your acknowledgement, Mr. President. It's ..."*)

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A little excitement to keep us on our toes, wasn't it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[371]` (Serge Wolkner), `[372]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Serge Wolkner: ""That's one way to look at it, Mr. President. Keeps the j..."*)

### Węzeł `[385]`
Mówca: **Serge Wolkner**
> ""We're here to serve and protect, Mr. President. It's a duty we don't take lightly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Narrator: "The echoing voices of the protesters gradually subsided a..."*)

### Węzeł `[386]`
Mówca: **Serge Wolkner**
> ""It's not just part of the job, sir. It's a matter of personal commitment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Narrator: "The echoing voices of the protesters gradually subsided a..."*)

### Węzeł `[387]`
Mówca: **Serge Wolkner**
> ""You're right, sir. It's part of the job, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Narrator: "The echoing voices of the protesters gradually subsided a..."*)

### Węzeł `[388]`
Mówca: **Serge Wolkner**
> ""I'm merely doing my job, Mr. President. Ensuring your safety is my top priority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Narrator: "The echoing voices of the protesters gradually subsided a..."*)

### Węzeł `[389]`
Mówca: **Serge Wolkner**
> ""We appreciate your acknowledgement, Mr. President. It's our duty and honor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Narrator: "The echoing voices of the protesters gradually subsided a..."*)

### Węzeł `[390]`
Mówca: **Serge Wolkner**
> ""That's one way to look at it, Mr. President. Keeps the job interesting, to say the least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Narrator: "The echoing voices of the protesters gradually subsided a..."*)

### Węzeł `[391]`
Mówca: **Narrator**
> "The echoing voices of the protesters gradually subsided as we retreated from the scene and left Narbel behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Calming down a displeased crowd of worke..."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Reporter");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Reporter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Gus Manger");"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Gus Manger");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Gus Manger");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Katarina Horten");"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Katarina Horten");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Katarina Horten");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Denis Stahler");"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Denis Stahler");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Denis Stahler");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Narrator: "Serge opened the door of the car and I lowered myself int..."*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Reporter");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Reporter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Gus Manger");"*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Gus Manger");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Gus Manger");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Katarina Horten");"*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Katarina Horten");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Katarina Horten");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Denis Stahler");"*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Denis Stahler");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Denis Stahler");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Narrator: "The staff and I were swiftly escorted into the convoy. Th..."*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayMusic("Reform");`
- **Efekt skryptowy (`userScript`):** `PlayMusic("Reform");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "As we stepped out of the towering front gate of the Gasom..."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayCustomMapMusic("Map_Music_Tense");`
- **Efekt skryptowy (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Escaping from an aggressive crowd of ril..."*)

### Węzeł `[402]`
Mówca: **Narrator**
> "Eventually, all fell silent as they waited for Denis and Katarina to respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBene..."*)

### Węzeł `[403]`
Mówca: **Gus Manger**
> ""Serge is right, Mr. President. The crowd won't get any calmer if you stick around. You've got to get to safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Denis Stahler: ""Leaving so soon, Rayne? I guess you know when you've bee..."*)

### Węzeł `[404]`
Mówca: **Serge Wolkner**
> "<shout>""PROTECT THE PRESIDENT!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Narrator: "His voice carried over the screams of the crowd. The guar..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayMusic("Suspense");`
- **Efekt skryptowy (`userScript`):** `PlayMusic("Suspense");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_A_Protestors_Uproar = true"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaBias == true)"*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1"*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest += 1; BaseGame.Public_Opinion -= 2"*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "Close by, I noticed a terse exchange between a security o..."*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Country_Unrest += 1;
BaseGame.Public_Opinion -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Country_Unrest"] = Variable["BaseGame.Country_Unrest"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "Close by, I noticed a terse exchange between a security o..."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaBias == true)"*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "Nearby, a quick, hushed conversation was being had betwee..."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1"*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "Nearby, a quick, hushed conversation was being had betwee..."*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaBias == true)"*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 2; BaseGame.Country_Unrest -= 1;"*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 1"*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 2;
BaseGame.Country_Unrest -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;
Variable["BaseGame.Country_Unrest"] = Variable["BaseGame.Country_Unrest"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Narrator: "Nearby, a Gasom security officer and a Presidential Guard..."*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Narrator: "Nearby, a Gasom security officer and a Presidential Guard..."*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBene..."*)
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBe..."*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Workers_GasomExpandsCare =..."*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true"*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true"*)
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == ..."*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Workers_GasomIncreasesSala..."*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true"*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true"*)
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true)"*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Workers_GasomGivesCharity ..."*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_LT_Workers_LUSCPSLose = true;..."*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Workers_GasomExpandsCare = true;
BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinCare = true;
BaseGameSupport.News_Turn03_R_Workers_LUSCPSVictory = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Workers_GasomExpandsCare"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinCare"] = true;
Variable["BaseGameSupport.News_Turn03_R_Workers_LUSCPSVictory"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_A_Protestors_Uproar == true"*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Workers_GasomIncreasesSalaries = true;
BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinSalaries = true;
BaseGameSupport.News_Turn03_R_Workers_LUSCPSDisappointed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Workers_GasomIncreasesSalaries"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinSalaries"] = true;
Variable["BaseGameSupport.News_Turn03_R_Workers_LUSCPSDisappointed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_A_Protestors_Uproar == true"*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Workers_GasomGivesCharity = true;
BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinDonations = true;
BaseGameSupport.News_Turn03_R_Workers_LUSCPSCondemn = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Workers_GasomGivesCharity"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinDonations"] = true;
Variable["BaseGameSupport.News_Turn03_R_Workers_LUSCPSCondemn"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_A_Protestors_Uproar == true"*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_LT_Workers_LUSCPSLose = true;
BaseGameSupport.News_Turn03_R_Workers_LUSCPSInaction = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_Workers_LUSCPSLose"] = true;
Variable["BaseGameSupport.News_Turn03_R_Workers_LUSCPSInaction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_A_Protestors_Uproar == true"*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_A_Protestors_Uproar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_A_Protestors_Uproar == true"*)
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_A_Protestors_Uproar == true)"*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_A_Protestors_Uproar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_A_Protestors_Uproar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_R_Address_PresidentAssaulted ..."*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_A_Protestors_Uproar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_A_Protestors_Uproar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_A_Protestors_Mixed == true"*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_A_Protestors_Mixed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_A_Protestors_Mixed == true"*)
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_A_Protestors_Mixed == true)"*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_A_Protestors_Mixed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_A_Protestors_Mixed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Address_CrowdHassle = true..."*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_A_Protestors_Mixed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_A_Protestors_Mixed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_LT_Address_PositiveCrowd = true;"*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaBias == true)"*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_Address_AmazingSpeech = true;"*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_Address_BadSpeech = true;"*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_R_Address_PresidentAssaulted = true;
BaseGameSupport.News_Turn03_LT_Address_LungedAtPresident = true;
BaseGameSupport.News_Turn03_HP_Address_MalenyevistRYRebels = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_R_Address_PresidentAssaulted"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Address_LungedAtPresident"] = true;
Variable["BaseGameSupport.News_Turn03_HP_Address_MalenyevistRYRebels"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Address_CrowdHassle = true;
BaseGameSupport.News_Turn03_LT_Address_DramaticScenesUnfold = true;
BaseGameSupport.News_Turn03_R_Address_OkaySpeechByPresident = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Address_CrowdHassle"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Address_DramaticScenesUnfold"] = true;
Variable["BaseGameSupport.News_Turn03_R_Address_OkaySpeechByPresident"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_LT_Address_PositiveCrowd = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_Address_PositiveCrowd"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_Address_AmazingSpeech = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Address_AmazingSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_Address_BadSpeech = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Address_BadSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaBias == true)"*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_Address_PresidentListens =..."*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_Address_PresidentDeaf = true;"*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_Address_PresidentListens = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Address_PresidentListens"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_Address_PresidentDeaf = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Address_PresidentDeaf"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[453]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Before any of you do anything too rash, I want you to take a good look around you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Player: ""You are surrounded by police and armed guards. Realistic..."*)
  - -> `[455]` (*Player: ""You cannot rise up against the President of Sordland wit..."*)
  - -> `[457]` (*Player: ""We are all brothers and sisters in the struggle against ..."*)

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You are surrounded by police and armed guards. Realistically, what do you hope to accomplish here?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[453]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 1"*)

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You cannot rise up against the President of Sordland without facing consequences.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[453]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 1"*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Denis Stahler: ""You're going to jump directly to threatening us, Preside..."*)

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We are all brothers and sisters in the struggle against greed and exploitation. We must not let ourselves become divided.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[453]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Denis Stahler: ""Divided? You're the one walking out of Gasom headquarter..."*)

### Węzeł `[458]`
Mówca: **Denis Stahler**
> ""You're going to jump directly to threatening us, President Rayne? Whatever happened to the right to peaceful protest?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Katarina Horten: "“This only proves that we are right to stand here today. ..."*)

### Węzeł `[459]`
Mówca: **Katarina Horten**
> "“This only proves that we are right to stand here today. We will not budge until you commit to real change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention == true"*)

### Węzeł `[460]`
Mówca: **Denis Stahler**
> ""Divided? You're the one walking out of Gasom headquarters surrounded by armed guards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Denis Stahler: "“All talk and no action, isn't it, Mr. President? How lon..."*)

### Węzeł `[461]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""How dare you speak that way to your president! You ingrates have no idea how much I have sacrificed for this country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 3"*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension += 3`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3"*)

### Węzeł `[463]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“See, Mr. Stahler and Ms. Horten? I'm on your side. You can stop whining now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Player), `[95]` (Player), `[96]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "A change came over the crowd. The angry shouts were repla..."*)

### Węzeł `[464]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“See, Mr. Stahler and Ms. Horten? I'm on your side. You can stop whining now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Player), `[97]` (Player), `[98]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "The air suddenly felt somewhat lighter. Murmurs of conver..."*)

### Węzeł `[465]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“See, Mr. Stahler and Ms. Horten? I'm on your side. You can stop whining now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Player), `[99]` (Player), `[100]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "I could hear the crowd growing restless. They once again ..."*)

### Węzeł `[466]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I'm not going to dignify that with a response. Gasom has done so much for this shithole region, and this is how you people repay it?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true) == false` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false` AND `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[217]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Player: ""Honestly, these workers are lucky to even have jobs. The..."*)
  - -> `[468]` (*Player: ""I'm warning you all. Back off now, or there *will* be co..."*)
  - -> `[469]` (*Player: ""Why don't you talk to an actual Gasom employee, Madam Re..."*)

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, these workers are lucky to even have jobs. They shouldn't get greedy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Denis Stahler: ""Your arrogance is unbelievable, Mr. President.""*)

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm warning you all. Back off now, or there *will* be consequences.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Denis Stahler: ""Your arrogance is unbelievable, Mr. President.""*)

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why don't you talk to an actual Gasom employee, Madam Reporter? They'll tell you how grateful they are to work for the best company in Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Denis Stahler: ""Your arrogance is unbelievable, Mr. President.""*)

### Węzeł `[470]`
Mówca: **Denis Stahler**
> ""Your arrogance is unbelievable, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 3"*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension += 3`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Katarina Horten: ""Clearly, we are past the time for reasonable discussion...."*)

### Węzeł `[472]`
Mówca: **Katarina Horten**
> ""Clearly, we are past the time for reasonable discussion. We must fight for what we believe in!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "The undercurrent of unrest swelled, threatening to surge ..."*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 && BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 &&..."*)
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 ..."*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 && BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] >= 5  and  Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Player: ""What the hell are you still doing here, lady? Can't you ..."*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 && BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] >= 5  and  Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[476]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What the hell are you still doing here, lady? Can't you see it's about to get ugly?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] >= 5  and  Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == false`
- **Kontekst wejściowy (poprzednik):** `[261]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Denis Stahler: ""The sight of the common people speaking truth to power i..."*)

### Węzeł `[477]`
Mówca: **Denis Stahler**
> ""The sight of the common people speaking truth to power is anything but 'ugly', Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "PlayMusic("Suspense");"*)

### Węzeł `[478]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's confidential, ma'am.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension += 1"*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_AddressProtestors_Tension += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Katarina Horten: ""I see. The President won't divulge any information about..."*)

### Węzeł `[480]`
Mówca: **Katarina Horten**
> ""I see. The President won't divulge any information about his closed-door dealings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 &&..."*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Addressing a crowd of displeased workers and unionists", "Gates of Gasom Branch", "Narbel");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Addressing a crowd of displeased workers and unionists","Gates of Gasom Branch","Narbel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "PlayMusic("Reform");"*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Escaping from an aggressive crowd of riled-up workers and unionists", "Gates of Gasom Branch", "Narbel");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Escaping from an aggressive crowd of riled-up workers and unionists","Gates of Gasom Branch","Narbel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBene..."*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Calming down a displeased crowd of workers and unionists", "Gates of Gasom Branch", "Narbel");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Calming down a displeased crowd of workers and unionists","Gates of Gasom Branch","Narbel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBene..."*)
