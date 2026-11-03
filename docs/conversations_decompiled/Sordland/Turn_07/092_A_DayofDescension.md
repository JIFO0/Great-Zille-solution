# Sordland/Turn07/A_DayofDescension

- **ID konwersacji:** `92`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/092_A_DayofDescension.md`
- **Liczba węzłów dialogowych:** 333
- **Liczba wyborów gracza:** 61

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[55]** Archpriest

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Accepted_MediaDeal`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Decision_Turn01_InfrastructureProject_Invest`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Relations_Albin_Bribed`
- `BaseGame.Relations_Albin_PromisedVP`
- `BaseGame.Relations_Frens_Bribed`
- `BaseGame.Relations_Monica_Slapped`
- `BaseGame.Relations_Monica_SupportedAtFestival`
- `BaseGame.Relations_Walter_Promise_BailBusiness`
- `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled`
- `BaseGame.Relations_Walter_Promise_Company`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`
- `BaseGame.Relations_Walter_Promise_PrivatizationFulfilled`
- `BaseGame.Relations_Walter_Promise_TaxFulfilled`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn04_InT_HighwayIssue_Solved`
- `BaseGame.Turn04_InT_RailwayIssue_Solved`
- `BaseGame.Turn04_P_Monica_Benfi_Speech`
- `BaseGame.Turn05_Admin_Monica_Barred`
- `BaseGame.Turn07_GrantedShares_MarcelKoronti`
- `BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually`
- `BaseGame.Turn07_GrantedShares_WalterTusk`
- `BaseGameIsolated.Turn07_A_Confessed_BadHusband`
- `BaseGameIsolated.Turn07_A_Confessed_Bribery`
- `BaseGameIsolated.Turn07_A_Confessed_SelfDoubt`
- `BaseGameIsolated.Turn07_A_SuccessfulRitual1`
- `BaseGameIsolated.Turn07_A_SuccessfulRitual2`
- `BaseGameIsolated.Turn07_A_SuccessfulRitual3`
- `BaseGameIsolated.Turn07_A_SuccessfulRitual4`
- `BaseGameIsolated.Turn07_A_SuccessfulRitual5`
- `BaseGameSupport.Journal_Turn06_HighwayOpening`
- `BaseGameSupport.Journal_Turn06_RailwayOpening`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Public_Opinion`
- `BaseGameIsolated.Turn07_A_Confessed_BadHusband`
- `BaseGameIsolated.Turn07_A_Confessed_Bribery`
- `BaseGameIsolated.Turn07_A_Confessed_SelfDoubt`
- `BaseGameIsolated.Turn07_A_SuccessfulRitual1`
- `BaseGameIsolated.Turn07_A_SuccessfulRitual2`
- `BaseGameIsolated.Turn07_A_SuccessfulRitual3`
- `BaseGameIsolated.Turn07_A_SuccessfulRitual4`
- `BaseGameIsolated.Turn07_A_SuccessfulRitual5`
- `BaseGameSupport.CountryReport_Turn07_Derdia_BlessesCongratulatesRitual`
- `BaseGameSupport.News_Turn07_HP_ProtestsDespiteEmergency`
- `BaseGameSupport.News_Turn07_LT_RitualWin`
- `BaseGameSupport.News_Turn07_R_RitualFailed`
- `BaseGameSupport.News_Turn07_ST_RitualFailed_NoDeal`
- `GameCondition.Turn07_A_DayOfDescension`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 16
- **Węzły modyfikujące stan gry:** 25

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[46]` (Lucian Galade): `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual1"] = true;`
- Węzeł `[47]` (Lucian Galade): `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual2"] = true;`
- Węzeł `[48]` (Lucian Galade): `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual3"] = true;`
- Węzeł `[98]` (Lucian Galade): `Variable["GameCondition.Turn07_A_DayOfDescension"] = true;`
- Węzeł `[165]` (Lucian Galade): `Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] = true;`
- Węzeł `[167]` (Lucian Galade): `Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] = true;`
- Węzeł `[169]` (Lucian Galade): `Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] = true;`
- Węzeł `[274]` (Lucian Galade): `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- *...oraz 17 innych węzłów ze skryptami.*

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
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Morning haze surrounded the city of Deyr as the sun dawned on the Day of Descension. The holiest day of the Nurity religion, it celebrated the first message received from God by Saint Dast and his thirty disciples."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "As per tradition, the celebration was held inside the Archsanctuary of Dastnurity, closed to the public eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[5]`
Mówca: **Narrator**
> "That was Lucian's idea. As he saw it, granting the people a rare glimpse of the Grand Ceremony, and showing them how seriously their President took this holy event, would ease any tensions that lingered in the region."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "And so we arrived at the largest cathedral in Sordland. A huge crowd gathered around our convoy as our car pulled up to the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Lucian Galade**
> "“This will work out well. Trust me, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Lucian Galade**
> "“Of course, that's only if the prayer is done completely correctly. Please don't forget the order.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Lucian Galade**
> "“First, you will need to grasp the holy sceptre with your left hand, then touch the altar with your right. Kneel before the Archpriest and wait for him to put the sword on your shoulder.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[10]`
Mówca: **Lucian Galade**
> "“Pretty straightforward, isn't it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[11]`
  - -> `[13]`
  - -> `[80]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "“Yeah, sure.”"]** — Mówca: **Player**
> "“Yeah, sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "“It's just a ceremony. Whatever.”"]** — Mówca: **Player**
> "“It's just a ceremony. Whatever.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“I didn't understand a word you just said.”"]** — Mówca: **Player**
> "“I didn't understand a word you just said.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Lucian Galade**
> "“Just do your best to remember it. We can't afford to lose our religious base over this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[15]`
Mówca: **Lucian Galade**
> "“Very good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Lucian Galade**
> "“It's 'just' one of the most important ceremonies in Sordland. Especially for Deyr's Bludish residents.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Lucian Galade**
> "“You will have to go first. I will come inside later and we will meet up after your part is done. Good luck, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "Exit the car."]** — Mówca: **Player_Italic**
> "I exited the car and I was greeted by a chorus of cheers and camera flashes. I waved to the people as I made my way to the grand gates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Narrator**
> "The Archsanctuary was a sight to see. With its towering visage, it cast a shadow over a large portion of the city. I had to crane my neck to see the narrow spires at the top. Just standing next to it made me feel awe and dread in equal measure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Narrator**
> "As I reached the gates, I spotted my welcoming committee. The Archpriest and his disciples were waiting for my arrival. At my approach, they all bowed their heads in respect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[21]`
Mówca: **Archpriest**
> "“Mr. President. Praise God! It is a blessing to see you on our most holy day again. Welcome, welcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[24]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Narrator**
> "He led me through the main hall, which had a stratospheric ceiling and Nurist icons lining the walls. We walked up a creaking spiral staircase to the top floor and finally arrived in front of the confession chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "“Thank you. It is nice to be here in Deyr again.”"]** — Mówca: **Player**
> "“Thank you. It is nice to be here in Deyr again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Archpriest.”"]** — Mówca: **Player**
> "“Archpriest.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "Bow your head before the Archpriest."]** — Mówca: **Player_Italic**
> "I bowed my head before the Archpriest, which triggered a few murmurs of approval from the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[26]`
Mówca: **Archpriest**
> "“Shall we move inside for your confession?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[27]`
  - -> `[100]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Sure. Let's get this over with.”"]** — Mówca: **Player**
> "“Sure. Let's get this over with.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "Pull the Archpriest aside for a photo."]** — Mówca: **Player_Italic**
> "I pulled the Archpriest aside for a photo. Many flashbulbs burned my eyes at the same time. I heard whistles, claps and cheers from the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Archpriest**
> "“Most excellent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[30]`
Mówca: **Narrator**
> "The Archpriest gave me an infectious smile as he straightened back up. Tall and handsome, in his mid-50s, he was one of the youngest and most popular Archpriests in history. Some of his more avid followers even likened him to Saint Dast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[31]`
Mówca: **Archpriest**
> "“Oh, great people of Sordland! Once again we are gathered here to honor the Day of Descension!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Narrator**
> "The crowd was still cheering loudly. The Archpriest turned and raised both of his hands, and everyone immediately fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[33]`
Mówca: **Archpriest**
> "“I am indescribably happy to be sharing this moment with you as well as every Blud and Sord, old and young, tuning in to their television to watch this holy commemoration!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Archpriest**
> "“Along with the leader of our great nation, I say: Let the holy day begin!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[35]`
Mówca: **Narrator**
> "He smiled beatifically as the crowd burst into rapturous applause. After it subsided, he turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[36]`
Mówca: **Narrator**
> "We made our way downstairs where the ceremony was already in progress. The choir sang angelically as the Archpriest took his position beside the altar. When they finished their hymn, an expectant silence fell over the room. It was time for my part."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Narrator**
> "I started my walk, bowed and approached the altar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "Grab the sceptre with your left hand, then touch the altar with your right."]** — Mówca: **Player_Italic**
> "I grabbed the sceptre with my left hand, then touched the altar with my right."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "Grab the sceptre with your right hand, then touch the altar with your left."]** — Mówca: **Player_Italic**
> "I grabbed the sceptre with my right hand then touched the altar with left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[40]`
  - -> `[42]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "Kneel before the Archpriest."]** — Mówca: **Player_Italic**
> "Sceptre in hand, I knelt before the Archpriest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[41]`
**[WYBÓR GRACZA: "Bow to the Archpriest."]** — Mówca: **Player_Italic**
> "Sceptre in hand, I bowed to the Archpriest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "Kiss the ring of the Archpriest."]** — Mówca: **Player_Italic**
> "Sceptre in hand, I kissed the ring of the Archpriest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "Touch the sword with your right hand."]** — Mówca: **Player_Italic**
> "I touched the sword with my right hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "Touch the sword with your left hand."]** — Mówca: **Player_Italic**
> "I touched the sword with my left hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`

### Węzeł `[45]`
Mówca: **Narrator**
> "I got up and proceeded to my designated spot next to Lucian. He leaned over and whispered in my ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[46]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_SuccessfulRitual1 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual1"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[40]`
  - -> `[42]`

### Węzeł `[47]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_SuccessfulRitual2 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[48]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_SuccessfulRitual3 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`

### Węzeł `[49]`
Mówca: **Lucian Galade**
> "“Compared to last year, that went surprisingly well, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[50]`
Mówca: **Lucian Galade**
> "“Unfortunately that was not quite correct, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[51]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual2 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual3 == true &&
BaseGameIsolated.Turn07_A_SuccessfulRitual4 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual5 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual2 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual3 == true &&
BaseGameIsolated.Turn07_A_SuccessfulRitual4 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual5 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual1"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual2"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual3"] == true  and 
Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual4"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual5"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[53]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual2 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual3 == true &&
BaseGameIsolated.Turn07_A_SuccessfulRitual4 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual5 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual1"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual2"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual3"] == true  and 
Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual4"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual5"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[54]`
Mówca: **Narrator**
> "My eyes met the Archpriest's and he very slightly shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Narrator**
> "My eyes met the Archpriest's and he very slightly nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Narrator**
> "The ceremony went on for another hour and a half. Finally, the noon bells chimed, marking the end of the cathedral service."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[57]`
Mówca: **Narrator**
> "We entered our cars and drove back to our suites in Deyr."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[58]`
Mówca: **Narrator**
> "We left the cathedral to greet the waiting crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[59]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual2 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual3 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual4 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual5 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual2 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual3 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual4 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual5 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual1"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual2"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual3"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual4"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual5"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[61]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual2 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual3 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual4 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual5 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual1"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual2"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual3"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual4"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual5"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[62]`
Mówca: **Narrator**
> "As I walked outside, I heard scattered boos. A man in a Worker's Party of Bludia shirt shouted that I was only here for show, that I couldn't even bother to get the ceremony right. Others yelled in agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Narrator**
> "As I stepped outside, I heard everyone cheering and chanting my name. Lucian's gambit seemed to have been a success. We waved proudly for a minute or two."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[64]`
Mówca: **Lucian Galade**
> "“We should go before things get heated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[65]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[67]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[68]`
Mówca: **Lucian Galade**
> "“See, sir. I told you it would work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[69]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual2 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual3 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual4 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual5 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual2 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual3 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual4 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual5 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual1"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual2"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual3"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual4"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual5"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[71]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual2 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual3 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual4 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual5 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual1"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual2"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual3"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual4"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual5"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[72]`
Mówca: **Narrator**
> "As I walked outside, I heard scattered boos. A man in a shirt bearing the colors of the Bludish flag shouted that I'd only done the ceremony for show. Lucian hadn't been exactly right about my presence easing tensions, it seemed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Narrator**
> "As I stepped outside, I heard furious jeers. Guards shielded me as people in the crowd began throwing cans and bottles in my direction. Because I'd messed up the ceremony so badly, my presence here hadn't eased tensions -- it had done the opposite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Lucian Galade**
> "“We should go before things get heated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[75]`
Mówca: **Lucian Galade**
> "“We should go before things get heated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[76]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[79]`
Mówca: **Narrator**
> "That was Lucian's idea. As he saw it, granting the people a rare glimpse of the Grand Ceremony, and showing them how seriously their President took this holy event, would ease the tensions that lingered following my decree to ban the Workers' Party of Bludia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[80]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[83]`
**[WYBÓR GRACZA: "“I hope we are not placing a target on our backs by coming here.”"]** — Mówca: **Player**
> "“I hope we are not placing a target on our backs by coming here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Lucian Galade**
> "“Don't worry sir. I have taken the required precautions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[85]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[87]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[88]`
Mówca: **Archpriest**
> "“Oh, great people of Sordland! Once again we are gathered here to honor the Day of Descension!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Archpriest**
> "“I am indescribably happy to be sharing this moment with you as well as every Blud and Sord, old and young, tuning in to their television to watch this holy commemoration!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Archpriest**
> "“In these times of turmoil, we must unite! By the grace of God, the president is here today to show his will to unify our great country!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Archpriest**
> "“Stay far from evil, oh sons and daughters, for evil hides itself under many disguises. Disguises such as blasphemy, apostasy and even alcohol!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Archpriest**
> "“Be good, my children! Praise God! Praise Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[93]`
Mówca: **Narrator**
> "The crowd was still booing angrily. The Archpriest turned and raised both of his hands, and everyone immediately fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[94]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[96]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[97]`
**[WYBÓR GRACZA: "Exit the car."]** — Mówca: **Player_Italic**
> "I exited the car and was greeted by a chorus of boos. Some people in the crowd began raising signs and chanting in protest of my ban. I ducked my head as the guards quickly ushered me to the grand gates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[98]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn07_A_DayOfDescension = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn07_A_DayOfDescension"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[99]`
Mówca: **Lucian Galade**
> "“Then touch the sword with the hand you touched the altar with. Hand the sceptre over to the Archpriest and receive the sword before passing it on to a disciple.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[100]`
**[WYBÓR GRACZA: "“My confession?”"]** — Mówca: **Player**
> "“My confession?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Archpriest**
> "“Yes. Just like last year. Every man must confess before the holy ceremony starts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[102]`
Mówca: **Narrator**
> "He gestured towards a chair in the dark room. The room smelled of old mahogany and scented candles. The Archpriest proceeded to light each and every one of the candles. One for each virtue and vice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Archpriest**
> "“Right this way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[104]`
Mówca: **Archpriest**
> "“I will be right with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Narrator**
> "He left the room. A minute later, I heard the sound of a sliding window right next to me. He spoke with a very soft voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Archpriest**
> "“Anton Rayne. Speak. Speak and confess now before the one God and may He repent your sins on the most holy Day of Descension.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[107]`
**[WYBÓR GRACZA: "“I confess that I have been a bad husband.”"]** — Mówca: **Player**
> "“I confess that I have been a bad husband.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[108]`
**[WYBÓR GRACZA: "“I confess nothing. I haven't sinned.”"]** — Mówca: **Player**
> "“I confess nothing. I haven't sinned.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[109]`
**[WYBÓR GRACZA: "“I confess that I was involved in shady dealings.”"]** — Mówca: **Player**
> "“I confess that I was involved in shady dealings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[110]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Bribed == true || BaseGame.Relations_Walter_Promise_BailBusiness == true || BaseGame.Relations_Walter_Promise_Company == true || BaseGame.Turn07_GrantedShares_MarcelKoronti == true || BaseGame.Turn07_GrantedShares_WalterTusk == true || BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually == true || BaseGame.Relations_Albin_Bribed == true || BaseGame.Relations_Albin_PromisedVP || BaseGame.Relations_Walter_Promise_PrivatizationFulfilled == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true || BaseGame.Accepted_MediaDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Bribed == true || BaseGame.Relations_Walter_Promise_BailBusiness == true || BaseGame.Relations_Walter_Promise_Company == true || BaseGame.Turn07_GrantedShares_MarcelKoronti == true || BaseGame.Turn07_GrantedShares_WalterTusk == true || BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually == true || BaseGame.Relations_Albin_Bribed == true || BaseGame.Relations_Albin_PromisedVP || BaseGame.Relations_Walter_Promise_PrivatizationFulfilled == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true || BaseGame.Accepted_MediaDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Bribed"] == true  or  Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  or  Variable["BaseGame.Relations_Walter_Promise_Company"] == true  or  Variable["BaseGame.Turn07_GrantedShares_MarcelKoronti"] == true  or  Variable["BaseGame.Turn07_GrantedShares_WalterTusk"] == true  or  Variable["BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually"] == true  or  Variable["BaseGame.Relations_Albin_Bribed"] == true  or  Variable["BaseGame.Relations_Albin_PromisedVP"]  or  Variable["BaseGame.Relations_Walter_Promise_PrivatizationFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] == true  or  Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[112]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Frens_Bribed == true || BaseGame.Relations_Walter_Promise_BailBusiness == true || BaseGame.Relations_Walter_Promise_Company == true || BaseGame.Turn07_GrantedShares_MarcelKoronti == true || BaseGame.Turn07_GrantedShares_WalterTusk == true || BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually == true || BaseGame.Relations_Albin_Bribed == true || BaseGame.Relations_Albin_PromisedVP || BaseGame.Relations_Walter_Promise_PrivatizationFulfilled == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true || BaseGame.Accepted_MediaDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Bribed"] == true  or  Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  or  Variable["BaseGame.Relations_Walter_Promise_Company"] == true  or  Variable["BaseGame.Turn07_GrantedShares_MarcelKoronti"] == true  or  Variable["BaseGame.Turn07_GrantedShares_WalterTusk"] == true  or  Variable["BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually"] == true  or  Variable["BaseGame.Relations_Albin_Bribed"] == true  or  Variable["BaseGame.Relations_Albin_PromisedVP"]  or  Variable["BaseGame.Relations_Walter_Promise_PrivatizationFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] == true  or  Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[113]`
Mówca: **Archpriest**
> "“We all sin at one point in our lives. Such is the human nature as deemed by God. We sometimes sin because of necessity. Yet like all, we must repent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Archpriest**
> "“Who was this sin committed with?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[308]`
  - -> `[241]`
  - -> `[244]`
  - -> `[116]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Walter Tusk.”"]** — Mówca: **Player**
> "“Walter Tusk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "“That is between me and God.”"]** — Mówca: **Player**
> "“That is between me and God.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Archpriest**
> "“Very well. I shall not pry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[118]`
Mówca: **Archpriest**
> "“Hmm I see. This must've been done out of necessity for the greater good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[119]`
**[WYBÓR GRACZA: "“I confess that I am not sure what I am doing for Sordland is enough.”"]** — Mówca: **Player**
> "“I confess that I am not sure what I am doing for Sordland is enough.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[120]`
Mówca: **Archpriest**
> "“Family is the cornerstone of society. Under the watchful eyes of the God, men are required to protect their wives and family.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Archpriest**
> "“But God created us as complex creatures. At times, conflicts rise among us. Tell me, what was your sin?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[132]`
  - -> `[124]`
  - -> `[128]`

### Węzeł `[122]`
**[WYBÓR GRACZA: "“I've been neglecting my family due to the stress of my position.”"]** — Mówca: **Player**
> "“I've been neglecting my family due to the stress of my position.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[123]`
**[WYBÓR GRACZA: "“Against the wishes of my wife, I banned her from involvement in politics.”"]** — Mówca: **Player**
> "“Against the wishes of my wife, I banned her from involvement in politics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[124]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[126]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_Monica_Barred == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[127]`
**[WYBÓR GRACZA: "“I failed to support my wife at the Benfi Festival.”"]** — Mówca: **Player**
> "“I failed to support my wife at the Benfi Festival.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[128]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[130]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_SupportedAtFestival == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[131]`
Mówca: **Archpriest**
> "“Very well. I shall not pry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[132]`
**[WYBÓR GRACZA: "“That is between me and God.”"]** — Mówca: **Player**
> "“That is between me and God.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[133]`
Mówca: **Archpriest**
> "“Tragedy of neglect happens to all working men that feeds his family. Rejoice. God is kind in the matters of family.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[134]`
Mówca: **Archpriest**
> "“As you know, this is not a sin. In fact it is the exact opposite. A woman's place is beside her family. Not political podiums. You need not repent for this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[135]`
Mówca: **Archpriest**
> "“A husband must support his wife. You have taken the vows and you must uphold them. In this case, however, it is different. A woman's place is beside her family. Not political podiums.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Archpriest**
> "“Anything else you would like to confess?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[137]`
Mówca: **Archpriest**
> "“Anything else you would like to confess?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[138]`
Mówca: **Archpriest**
> "“Absolute certainty only belongs to God. All else feels uncertainty many times in their lives. This is especially true for men of power.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[139]`
Mówca: **Archpriest**
> "“What you have confessed is not a sin. But you may share your burden with me if you like.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[142]`
  - -> `[145]`
  - -> `[148]`

### Węzeł `[140]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Confession Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[252]`
  - -> `[258]`
  - -> `[162]`

### Węzeł `[141]`
**[WYBÓR GRACZA: "“I am trying to reform the country, but I don't know if the country is ready for it yet.”"]** — Mówca: **Player**
> "“I am trying to reform the country, but I don't know if the country is ready for that yet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[142]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[144]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[145]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[147]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Dictator_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[148]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[150]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[151]`
**[WYBÓR GRACZA: "“I still don't know if I am doing the right thing.”"]** — Mówca: **Player**
> "“I still don't know if I am doing the right thing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[152]`
**[WYBÓR GRACZA: "“I want to centralize power, but I am not sure if I am ready for it.”"]** — Mówca: **Player**
> "“I want to centralize power, but I am not sure if I am ready for it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[153]`
**[WYBÓR GRACZA: "“Everywhere I look, I see threats. I'm not sure I can handle them.”"]** — Mówca: **Player**
> "“Everywhere I look, I see threats. I'm not sure I can handle them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[154]`
Mówca: **Archpriest**
> "“Reformation is one of the tenets of Nurity. Yet it must come slowly but surely.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[155]`
Mówca: **Archpriest**
> "“More power always means more responsibility. We are only men after all. Leading men carry this on their shoulders and you are no different.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[156]`
Mówca: **Archpriest**
> "“You do carry a heavy burden on your shoulders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[157]`
Mówca: **Archpriest**
> "“We must not falter against threats. Otherwise, we shall be consumed by evil. Without eliminating the threats, there can be no serenity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Archpriest**
> "“Anything else you would like to confess?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[159]`
**[WYBÓR GRACZA: "“That's all for today.”"]** — Mówca: **Player**
> "“That's all for today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[160]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Confession Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[161]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Confession Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[162]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Confessed_Bribery == true || BaseGameIsolated.Turn07_A_Confessed_BadHusband == true || BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Confessed_Bribery == true || BaseGameIsolated.Turn07_A_Confessed_BadHusband == true || BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] == true  or  Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] == true  or  Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[164]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_Confessed_Bribery == true || BaseGameIsolated.Turn07_A_Confessed_BadHusband == true || BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] == true  or  Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] == true  or  Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[165]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Confessed_SelfDoubt = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[166]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Confession Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[167]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Confessed_BadHusband = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[168]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Confession Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[169]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Confessed_Bribery = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[170]`
Mówca: **Archpriest**
> "“Before God, I thank you for sharing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Archpriest**
> "“You are now forgiven before God, Anton Rayne. May you never sin again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[172]`
Mówca: **Archpriest**
> "“Any man sins. We must all come to terms with it. This is your chance to repent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[173]`
**[WYBÓR GRACZA: "“I do not beg, Archpriest.”"]** — Mówca: **Player**
> "“I do not beg, Archpriest.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[174]`
Mówca: **Archpriest**
> "“Please repent, Mr. President and you shall be freed of the burden of your sins. If you beg for forgiveness from God.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[319]`
  - -> `[325]`

### Węzeł `[175]`
**[WYBÓR GRACZA: "“Fine. I will confess.”"]** — Mówca: **Player**
> "“Fine. I will confess.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Confession Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[177]`
Mówca: **Archpriest**
> "“Pride is the most dangerous vice of all. Perhaps you will come to this realization at one point in your life.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[178]`
Mówca: **Archpriest**
> "“For the confession to end, you must extinguish the candles representing each one of your virtues and vices.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[179]`
Mówca: **Narrator**
> "The sliding window closed, and the Archpriest entered the confession chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[180]`
Mówca: **Narrator**
> "The sliding window closed, and the Archpriest entered the confession chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Archpriest**
> "“Let's move on to my quarters before the ceremony.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[182]`
Mówca: **Archpriest**
> "“With this, the once burning sins connected to you are now smoke and then nothing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
**[WYBÓR GRACZA: "Extinguish the candles."]** — Mówca: **Player_Italic**
> "One by one, I extinguished the candles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Archpriest**
> "“Well done, Mr. President. Let's move on to my quarters before the ceremony.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Narrator**
> "He led me through the thousand-year-old corridors to his office. The smell of dust and old tomes was in the air, along with the scent of burning incense being prepared for the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Archpriest**
> "“Well then, please have a seat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Narrator**
> "The wooden chair next to him looked like it might turn to dust at a single touch. I sat down gingerly. It was surprisingly sturdy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
**[WYBÓR GRACZA: "“Absolutely.”"]** — Mówca: **Player**
> "“Absolutely.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[189]`
Mówca: **Archpriest**
> "“Are you ready for the ceremony?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[191]`
  - -> `[190]`

### Węzeł `[190]`
**[WYBÓR GRACZA: "“Yes. Let's get on with it.”"]** — Mówca: **Player**
> "“Yes. Let's get on with it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[191]`
**[WYBÓR GRACZA: "“I am a bit nervous.”"]** — Mówca: **Player**
> "“I am a bit nervous.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Archpriest**
> "“Happens to the best of us. It will be televised, after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[193]`
Mówca: **Archpriest**
> "“Patience is a virtue, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[194]`
Mówca: **Archpriest**
> "“Very good to hear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[195]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_P_Monica_Benfi_Speech == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[198]`
Mówca: **Archpriest**
> "“I wanted to talk to you about something.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[199]`
Mówca: **Narrator**
> "He leaned back in his chair comfortably."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[200]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[203]`
Mówca: **Archpriest**
> "“I wanted to talk to you about something.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[204]`
Mówca: **Archpriest**
> "“I realize it has been months since the Benfi Festival, but this is my first chance to bring it up with you. It's about the actions of the First Lady.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Archpriest**
> "“I wanted to give you something. A gift to celebrate this special day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[206]`
Mówca: **Archpriest**
> "“As you know, the festival is a holy event. Letting a woman make the opening speech did not sit well with us. We share the same concerns as Mr. Leste.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Archpriest**
> "“A woman's place is beside her family, not giving public speeches in revealing dresses. Certainly not insulting the important traditions behind such an event.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[208]`
Mówca: **Archpriest**
> "“Of course we cannot ask you to do anything about it. She is your wife. But I just wanted to voice our disproval of the situation. A woman presiding over such an important religious event. What have we become?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[209]`
  - -> `[211]`

### Węzeł `[209]`
**[WYBÓR GRACZA: "“That's none of your business.”"]** — Mówca: **Player**
> "“That's none of your business.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[210]`
Mówca: **Narrator**
> "Disgust was apparent on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[211]`
**[WYBÓR GRACZA: "“I agree. It was my fault. Won't happen again.”"]** — Mówca: **Player**
> "“I agree. It was my fault. Won't happen again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[212]`
**[WYBÓR GRACZA: "“I let her do the speech because people like you still exist in Sordland.”"]** — Mówca: **Player**
> "“I let her do the speech because people like you still exist in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[213]`
Mówca: **Archpriest**
> "“Wonderful. Thank you for listening to our concerns, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[214]`
Mówca: **Archpriest**
> "“You are right, Mr. President. I just wanted to voice our opinion on the matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Narrator**
> "His face soured and he did not reply. He looked me up and down for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[219]`
Mówca: **Archpriest**
> "“I also heard you decided on the new curriculum...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Archpriest**
> "“...And decided that creationism shall no longer be taught in Sordland's schools. Needless to say, both I and the Sanctuary are outraged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Archpriest**
> "“The possibility that entire generations of schoolchildren will have their minds filled with nonsense about 'evolution' while failing to learn one of the main tenets of Nurity... it will hurt us for years to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`
  - -> `[224]`

### Węzeł `[222]`
**[WYBÓR GRACZA: "“Religion doesn't belong in schools. Just like it doesn't belong in my government's policies.”"]** — Mówca: **Player**
> "“Religion doesn't belong in schools. Just like it doesn't belong in my government's policies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[223]`
**[WYBÓR GRACZA: "“I didn't want to ban creationism. There were extenuating circumstances.""]** — Mówca: **Player**
> "“I didn't want to ban creationism. There were extenuating circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[224]`
**[WYBÓR GRACZA: "“I did not ask you for your opinion.”"]** — Mówca: **Player**
> "“I did not ask you for your opinion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[225]`
Mówca: **Archpriest**
> "“What kind of circumstances allow such a--.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[226]`
Mówca: **Archpriest**
> "“Well, I was just a--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Archpriest**
> "“Yes, that is precisely why I--.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Narrator**
> "A couple of knocks were heard on the door and a young boy came in. He bowed before the Archpriest, then me, before letting us know that the ceremony was about to begin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[229]`
Mówca: **Archpriest**
> "“I heard you decided on the new school curriculum...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[230]`
Mówca: **Narrator**
> "He pulled out a large rectangular box from his desk drawer. The box was lined with gold and expensive gemstones."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Archpriest**
> "“A beautiful sight, isn't it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Narrator**
> "He opened the box and showed me what was inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Narrator**
> "It was a dagger. The handle looked like it was made of pure gold and had a very large gem at the end. On the blade, the words were inscribed: "Vectern sis da!". Victory is close. On the other side, another set of words: "King Egmund"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[234]`
Mówca: **Archpriest**
> "“This dagger belonged to King Egmund. It is a very important artifact of the Kingdom of Sordland era. It is now yours, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`

### Węzeł `[235]`
**[WYBÓR GRACZA: "“Thank you. It is an honor.”"]** — Mówca: **Player**
> "“Thank you. It is an honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[236]`
**[WYBÓR GRACZA: "“I can not accept this.”"]** — Mówca: **Player**
> "“I cannot accept this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Archpriest**
> "“Yes you can, sir. It is now yours. Think of the past and think of who we are. Traditions are what brought us to this point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Archpriest**
> "“Think of the past and think of who we are. Traditions are what brought us to this point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Archpriest**
> "“Now then, it should be right about time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[240]`
**[WYBÓR GRACZA: "“Frens Ricter.”"]** — Mówca: **Player**
> "“Frens Ricter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[241]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Bribed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Bribed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Bribed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[243]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Frens_Bribed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Bribed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[244]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Relations_Walter_Promise_PrivatizationFulfilled == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Relations_Walter_Promise_PrivatizationFulfilled == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_PrivatizationFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[246]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Relations_Walter_Promise_PrivatizationFulfilled == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_PrivatizationFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[247]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Slapped == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Slapped == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Slapped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Slapped == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Slapped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[250]`
**[WYBÓR GRACZA: "“I couldn't control myself and hit my wife.”"]** — Mówca: **Player**
> "“I couldn't control myself and hit my wife.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[251]`
Mówca: **Archpriest**
> "“Physical abuse is a sin. But every man can lose his temper. A husband must always support and protect his wife. You have taken the vows and you must uphold them. Repent, and God may forgive you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[252]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Confessed_BadHusband == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Confessed_BadHusband == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[254]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_Confessed_BadHusband == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[255]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Confessed_Bribery == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Confessed_Bribery == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[257]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_Confessed_Bribery == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[258]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[260]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[261]`
Mówca: **Narrator**
> "Before we went in, the Archpriest looked at the crowd and pointed at one man. I turned and followed his finger with my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[262]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[264]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[265]`
Mówca: **Narrator**
> "It was a man holding a picket sign that said: 'Stop The Religious Disharmony Bill'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
Mówca: **Archpriest**
> "“As you can see, every man has his faults.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Archpriest**
> "“So does every president.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[268]`
  - -> `[270]`

### Węzeł `[268]`
**[WYBÓR GRACZA: "“I take it you don't approve of the Religious Harmony bill.”"]** — Mówca: **Player**
> "“I take it you don't approve of the Religious Harmony bill.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[269]`
**[WYBÓR GRACZA: "“So does every Archpriest, it seems.”"]** — Mówca: **Player**
> "“So does every Archpriest, it seems.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[270]`
**[WYBÓR GRACZA: "“Let's continue with the ceremony, Archpriest.”"]** — Mówca: **Player**
> "“Let's continue with the ceremony, Archpriest.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[271]`
Mówca: **Archpriest**
> "“Yes, that's right. But today is not the day to discuss that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[272]`
Mówca: **Archpriest**
> "“But of course. I am but a simple man and a mere servant of God.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[273]`
Mówca: **Archpriest**
> "“Very well, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[274]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[275]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 3;
BaseGame.Bludish_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[276]`
Mówca: **Narrator**
> "The Archpriest lay the sword on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[43]`

### Węzeł `[277]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_SuccessfulRitual4 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual4"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[278]`
**[WYBÓR GRACZA: "Hand the sceptre to the Archpriest."]** — Mówca: **Player_Italic**
> "I handed the sceptre to the Archpriest and waited for him to give me the sword."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[279]`
**[WYBÓR GRACZA: "Hand the sceptre to the disciples."]** — Mówca: **Player_Italic**
> "I handed the sceptre to the disciple next to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_SuccessfulRitual5 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual5"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[281]`
Mówca: **Narrator**
> "The Archpriest handed me the sword."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`
  - -> `[284]`

### Węzeł `[282]`
**[WYBÓR GRACZA: "Pass the sword to a disciple."]** — Mówca: **Player_Italic**
> "I passed the sword to a disciple."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[283]`
**[WYBÓR GRACZA: "Hand the sword back to the Archpriest."]** — Mówca: **Player_Italic**
> "I handed the sword back to the Archpriest. He took it and passed it to a disciple."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[284]`
**[WYBÓR GRACZA: "Place the sword on the altar."]** — Mówca: **Player_Italic**
> "I placed the sword on the altar. The Archpriest picked it back up and handed it to one of the disciples."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[285]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_LT_RitualWin = true;
BaseGameSupport.CountryReport_Turn07_Derdia_BlessesCongratulatesRitual = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_LT_RitualWin"] = true;
Variable["BaseGameSupport.CountryReport_Turn07_Derdia_BlessesCongratulatesRitual"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[286]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_R_RitualFailed = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_R_RitualFailed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[287]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[290]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_ST_RitualFailed_NoDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_ST_RitualFailed_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[291]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion <= 0 && BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion <= 0 && BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= 0  and  Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion <= 0 && BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= 0  and  Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[294]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_HP_ProtestsDespiteEmergency = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_ProtestsDespiteEmergency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[295]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_RailwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Railway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_RailwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Railway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] == false  and  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[297]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_InT_RailwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Railway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] == false  and  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[298]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_HighwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Highway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_HighwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Highway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] == false  and  Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[300]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_InT_HighwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Highway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] == false  and  Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[301]`
Mówca: **Narrator**
> "This year, however, for the first time ever, it was going to be televised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[302]`
Mówca: **Narrator**
> "This year, however, for the first time ever, it was going to be televised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[303]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_InfrastructureProject_Invest == true && BaseGameSupport.Journal_Turn06_RailwayOpening == false && BaseGameSupport.Journal_Turn06_HighwayOpening == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_InfrastructureProject_Invest == true && BaseGameSupport.Journal_Turn06_RailwayOpening == false && BaseGameSupport.Journal_Turn06_HighwayOpening == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true  and  Variable["BaseGameSupport.Journal_Turn06_RailwayOpening"] == false  and  Variable["BaseGameSupport.Journal_Turn06_HighwayOpening"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[305]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_InfrastructureProject_Invest == true && BaseGameSupport.Journal_Turn06_RailwayOpening == false && BaseGameSupport.Journal_Turn06_HighwayOpening == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true  and  Variable["BaseGameSupport.Journal_Turn06_RailwayOpening"] == false  and  Variable["BaseGameSupport.Journal_Turn06_HighwayOpening"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Narrator**
> "This year, however, for the first time ever, it was going to be televised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[307]`
**[WYBÓR GRACZA: "“Albin Clavin.”"]** — Mówca: **Player**
> "“Albin Clavin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[308]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Albin_Bribed == true || BaseGame.Relations_Albin_PromisedVP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Albin_Bribed == true || BaseGame.Relations_Albin_PromisedVP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Albin_Bribed"] == true  or  Variable["BaseGame.Relations_Albin_PromisedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[310]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Albin_Bribed == true || BaseGame.Relations_Albin_PromisedVP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Albin_Bribed"] == true  or  Variable["BaseGame.Relations_Albin_PromisedVP"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[311]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[313]`

### Węzeł `[312]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[314]`
**[WYBÓR GRACZA: "“Marcel Koronti.”"]** — Mówca: **Player**
> "“Marcel Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[315]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[318]`
Mówca: **Narrator**
> "We left the cathedral to greet the waiting crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[319]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == false || BaseGameIsolated.Turn07_A_Confessed_BadHusband == false || BaseGameIsolated.Turn07_A_Confessed_Bribery == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == false || BaseGameIsolated.Turn07_A_Confessed_BadHusband == false || BaseGameIsolated.Turn07_A_Confessed_Bribery == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] == false  or  Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] == false  or  Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[321]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == false || BaseGameIsolated.Turn07_A_Confessed_BadHusband == false || BaseGameIsolated.Turn07_A_Confessed_Bribery == false ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] == false  or  Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] == false  or  Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[322]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: UpdateProgress("Progress_Railway", 75);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%))*
- **Efekt (`userScript`):** `UpdateProgress("Progress_Railway", 75);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[323]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: UpdateProgress("Progress_Highway", 75);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%))*
- **Efekt (`userScript`):** `UpdateProgress("Progress_Highway", 75);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[324]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_Dagger");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_Dagger");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[325]`
**[WYBÓR GRACZA: "“Do not test my limits. I kindly ask of you.”"]** — Mówca: **Player**
> "“Do not test my limits. I kindly ask of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[326]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[327]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlaySoundEffect("BooCrowd");)*
- **Efekt (`userScript`):** `PlaySoundEffect("BooCrowd");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[328]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlaySoundEffect("CheerCrowdCamera");)*
- **Efekt (`userScript`):** `PlaySoundEffect("CheerCrowdCamera");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[329]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlaySoundEffect("BooScatter");)*
- **Efekt (`userScript`):** `PlaySoundEffect("BooScatter");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[330]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlaySoundEffect("FuriousJeers");)*
- **Efekt (`userScript`):** `PlaySoundEffect("FuriousJeers");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[331]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlaySoundEffect("CheerCrowd");)*
- **Efekt (`userScript`):** `PlaySoundEffect("CheerCrowd");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[332]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlaySoundEffect("BooScatter");)*
- **Efekt (`userScript`):** `PlaySoundEffect("BooScatter");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
