# Kompletny Indeks Bazy Dialogowej Suzerain (522 Konwersacje z Pełnymi Wymaganiami Kodu Gry)

> **Zaawansowana dekompilacja wsteczna silnika PixelCrushers Dialogue System / Articy:Draft 4.1.2**
> Wzbogacona o pełne analizy warunków Lua (`conditionsString`), wymagań odblokowania każdej opcji dialogowej, bezpośrednich skutków skryptowych (`userScript`) oraz wstrzykniętych ścieżek z modyfikacji **Great Zille Solution**.

## Statystyki Globalne Bazy Narracyjnej

- **Łączna liczba konwersacji:** `522`
  - **Kingdom of Rizia DLC:** `230` konwersacji (w tym nowa Królewska Narada Wojenna w Porte Drazon z modu)
  - **Sordland (Kampania Główna):** `292` konwersacji
- **Łączna liczba węzłów dialogowych (`dialogueEntries`):** `201,714`
- **Łączna liczba decyzji i opcji dialogowych gracza:** `36,667`
- **Łączna liczba opcji dialogowych posiadających warunki i wymagania w kodzie gry:** `8,704`

---

## Wstrzyknięcia Fabularne z Modyfikacji Great Zille Solution

Mod dodaje nowe ścieżki wojenno-dyplomatyczne bezpośrednio w dialogach vanilli oraz dedykowaną naradę wojenną:
1. **Królewska Narada Wojenna w Porte Drazon:** `[9988]` [Zille/WarCouncil_Briefing](Rizia/War_Operation/9988_WarCouncil_Briefing.md) — Rozmowa z Lucitą, Hugo, Titusem i Laurento w komnacie królewskiej. Uruchamia Plan Alfa, Plan Beta lub odroczenie inwazji.
2. **Ultimatum Wojenne w Radzie Dyplomatycznej (Tura 2):** `[297]` [FPnT_DiplomacyBriefing](Rizia/Turn_02/297_FPnT_DiplomacyBriefing.md) — Opcja `[99201]` groźby zbrojnego odzyskania Zille.
3. **Groźba Czołgami wobec Smolaka (Tura 2):** `[298]` [FPnT_ZilleVisit](Rizia/Turn_02/298_FPnT_ZilleVisit.md) — Opcja `[99203]` bezpośredniego ultimatum wobec Wiktora Smolaka na Dniu Przyjaźni.

---

## Szybka Nawigacja Tematyczna (Wyszukiwarka Słów Kluczowych)

### Kwestia Zille i Wehlen (Smolak / Negocjacje / Zamach / Referendum / Wojna) (80 rozmów)

- `[22]` [Sordland/Turn02/FPnT_DiplomacyOverview](Sordland/Turn_02/022_FPnT_DiplomacyOverview.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 16 | *Aktorzy:* Petr Vectern, Player, Player_Italic, Narrator
- `[23]` [Sordland/Turn02/Neighbor Overview Hubs](Sordland/Turn_02/023_Neighbor_Overview_Hubs.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 6 | *Aktorzy:* Player, Narrator, Deivid Wisci, Lucian Galade
- `[52]` [Sordland/Turn04/EnT_TaxReform](Sordland/Turn_04/052_EnT_TaxReform.md) — *Tura:* Tura 04 | *Opcje warunkowe:* 10 | *Aktorzy:* Player, Narrator, Mikail Aven, Edith Agnoc
- `[64]` [Sordland/Turn05/FPnT_ImmigrationPolicy](Sordland/Turn_05/064_FPnT_ImmigrationPolicy.md) — *Tura:* Tura 05 | *Opcje warunkowe:* 7 | *Aktorzy:* Player, Narrator, Deivid Wisci, Lileas Graf
- `[70]` [Sordland/Turn05/FPnT_WehlenTradeVisit](Sordland/Turn_05/070_FPnT_WehlenTradeVisit.md) — *Tura:* Tura 05 | *Opcje warunkowe:* 4 | *Aktorzy:* Player, Player_Italic, Narrator, Wiktor Smolak
- `[78]` [Sordland/Turn06/EnT_Overview](Sordland/Turn_06/078_EnT_Overview.md) — *Tura:* Tura 06 | *Opcje warunkowe:* 8 | *Aktorzy:* Player, Narrator, Mikail Aven, Deivid Wisci
- `[84]` [Sordland/Turn06/SnO_ConscriptionAndMilitaryPolicy](Sordland/Turn_06/084_SnO_ConscriptionAndMilitaryPolicy.md) — *Tura:* Tura 06 | *Opcje warunkowe:* 12 | *Aktorzy:* Player, Player_Italic, Narrator, Valken Kruger
- `[86]` [Sordland/Turn06/PSnW_EducationSpending](Sordland/Turn_06/086_PSnW_EducationSpending.md) — *Tura:* Tura 06 | *Opcje warunkowe:* 14 | *Aktorzy:* Player, Narrator, Ciara Walda
- `[87]` [Sordland/Turn06/PSnW_Curriculum](Sordland/Turn_06/087_PSnW_Curriculum.md) — *Tura:* Tura 06 | *Opcje warunkowe:* 0 | *Aktorzy:* Player, Player_Italic, Narrator, Lucian Galade
- `[89]` [Sordland/Turn06/PSnW_HealthBudget](Sordland/Turn_06/089_PSnW_HealthBudget.md) — *Tura:* Tura 06 | *Opcje warunkowe:* 12 | *Aktorzy:* Paskal Beniwoll, Player, Player_Italic, Narrator
- *...oraz 70 kolejnych rozmów w pełnym indeksie poniżej.*

### Kryzys i Wojna o Pales (Reinhart / Wojna / Blokada / Traktat) (68 rozmów)

- `[20]` [Sordland/Turn02/A_ContractBribe](Sordland/Turn_02/020_A_ContractBribe.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 1 | *Aktorzy:* Player, Player_Italic, Narrator, Walter Tusk
- `[22]` [Sordland/Turn02/FPnT_DiplomacyOverview](Sordland/Turn_02/022_FPnT_DiplomacyOverview.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 16 | *Aktorzy:* Petr Vectern, Player, Player_Italic, Narrator
- `[145]` [Sordland/Turn08/Personal_PetrTalk](Sordland/Turn_08/145_Personal_PetrTalk.md) — *Tura:* Tura 08 | *Opcje warunkowe:* 5 | *Aktorzy:* Petr Vectern, Player, Player_Italic, Narrator
- `[288]` [Rizia/Turn 1/Start_Coronation](Rizia/Turn_01/288_Start_Coronation.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 4 | *Aktorzy:* Narrator, Hugo Toras, Vina Toras, Sal Ignacius
- `[296]` [Rizia/Turn 2/FPnT_DiplomacyBriefing](Rizia/Turn_02/296_FPnT_DiplomacyBriefing.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 56 | *Aktorzy:* Narrator, Hugo Toras, Laurento Esquibel, Lucita Azaro
- `[303]` [Rizia/Prologue](Rizia/Prologue/303_Prologue.md) — *Tura:* Prologue | *Opcje warunkowe:* 23 | *Aktorzy:* Narrator, Player_Romus
- `[308]` [Rizia/Turn 3/A_VisitToSallabes](Rizia/Turn_03/308_A_VisitToSallabes.md) — *Tura:* Tura 03 | *Opcje warunkowe:* 10 | *Aktorzy:* Narrator, Leona Sazon, Manus Sazon, Vina Toras
- `[309]` [Rizia/Turn 3/A_VisitToMontaklar](Rizia/Turn_03/309_A_VisitToMontaklar.md) — *Tura:* Tura 03 | *Opcje warunkowe:* 38 | *Aktorzy:* Narrator, Lucita Azaro, Player_Romus_Italic, Player_Romus
- `[310]` [Rizia/Turn 3/EnT_ElenaRustyMeeting](Rizia/Turn_03/310_EnT_ElenaRustyMeeting.md) — *Tura:* Tura 03 | *Opcje warunkowe:* 6 | *Aktorzy:* Narrator, Hugo Toras, Elena Werner, Russello Montoro
- `[311]` [Rizia/Turn 4/FPnT_PalesDukeVisit](Rizia/Turn_04/311_FPnT_PalesDukeVisit.md) — *Tura:* Tura 04 | *Opcje warunkowe:* 23 | *Aktorzy:* Narrator, Titus Gordion, Player_Romus_Italic, Axel Reinhart
- *...oraz 58 kolejnych rozmów w pełnym indeksie poniżej.*

### Sektor Energetyczny i Surowcowy (Gaz / Aureus / Gasom / MITZ / Ropa) (81 rozmów)

- `[1]` [Sordland/Turn01/EnT_EconomicOverview](Sordland/Turn_01/001_EnT_EconomicOverview.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 19 | *Aktorzy:* Player, Player_Italic, Narrator, Gus Manger
- `[3]` [Sordland/Turn01/A_Media](Sordland/Turn_01/003_A_Media.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 2 | *Aktorzy:* Petr Vectern, Player, Narrator, Marcel Koronti
- `[4]` [Sordland/Turn01/A_PoliticalOverview](Sordland/Turn_01/004_A_PoliticalOverview.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 1 | *Aktorzy:* Petr Vectern, Player, Narrator, Lucian Galade
- `[14]` [Sordland/Turn02/A_ReformBriefing](Sordland/Turn_02/014_A_ReformBriefing.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 0 | *Aktorzy:* Petr Vectern, Player, Nia Morgna, Narrator
- `[18]` [Sordland/Turn02/A_AutocratBriefing](Sordland/Turn_02/018_A_AutocratBriefing.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 10 | *Aktorzy:* Player, Player_Italic, Orso Hawker, Narrator
- `[20]` [Sordland/Turn02/A_ContractBribe](Sordland/Turn_02/020_A_ContractBribe.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 1 | *Aktorzy:* Player, Player_Italic, Narrator, Walter Tusk
- `[22]` [Sordland/Turn02/FPnT_DiplomacyOverview](Sordland/Turn_02/022_FPnT_DiplomacyOverview.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 16 | *Aktorzy:* Petr Vectern, Player, Player_Italic, Narrator
- `[38]` [Sordland/Turn03/Personal_FrancTalk](Sordland/Turn_03/038_Personal_FrancTalk.md) — *Tura:* Tura 03 | *Opcje warunkowe:* 26 | *Aktorzy:* Player, Player_Italic, Narrator, Franc
- `[41]` [Sordland/Turn03/EnT_GasomProposal](Sordland/Turn_03/041_EnT_GasomProposal.md) — *Tura:* Tura 03 | *Opcje warunkowe:* 3 | *Aktorzy:* Player, Narrator, Ewald Alphonso, Gus Manger
- `[42]` [Sordland/Turn03/Gus Intro Talk](Sordland/Turn_03/042_Gus_Intro_Talk.md) — *Tura:* Tura 03 | *Opcje warunkowe:* 10 | *Aktorzy:* Player, Narrator, Gus Manger
- *...oraz 71 kolejnych rozmów w pełnym indeksie poniżej.*

### Religia, Kościół i Derdia (Azmal / Nur / Derdia / Wruhecism) (51 rozmów)

- `[66]` [Sordland/Turn05/Personal_PetrParty](Sordland/Turn_05/066_Personal_PetrParty.md) — *Tura:* Tura 05 | *Opcje warunkowe:* 11 | *Aktorzy:* Petr Vectern, Player, Player_Italic, Narrator
- `[78]` [Sordland/Turn06/EnT_Overview](Sordland/Turn_06/078_EnT_Overview.md) — *Tura:* Tura 06 | *Opcje warunkowe:* 8 | *Aktorzy:* Player, Narrator, Mikail Aven, Deivid Wisci
- `[92]` [Sordland/Turn07/A_DayofDescension](Sordland/Turn_07/092_A_DayofDescension.md) — *Tura:* Tura 07 | *Opcje warunkowe:* 20 | *Aktorzy:* Player, Player_Italic, Narrator, Lucian Galade
- `[106]` [Sordland/Turn07/Personal_TheatreVisit](Sordland/Turn_07/106_Personal_TheatreVisit.md) — *Tura:* Tura 07 | *Opcje warunkowe:* 23 | *Aktorzy:* Player, Player_Italic, Policeman, Narrator
- `[170]` [Sordland/Turn08/PSnW_HealthOverviewAndPandemic](Sordland/Turn_08/170_PSnW_HealthOverviewAndPandemic.md) — *Tura:* Tura 08 | *Opcje warunkowe:* 0 | *Aktorzy:* Paskal Beniwoll, Player, Player_Italic, Narrator
- `[206]` [Sordland/Turn09/FPnT_ArcasiaVisit](Sordland/Turn_09/206_FPnT_ArcasiaVisit.md) — *Tura:* Tura 09 | *Opcje warunkowe:* 11 | *Aktorzy:* Player, Player_Italic, Narrator, Monica
- `[288]` [Rizia/Turn 1/Start_Coronation](Rizia/Turn_01/288_Start_Coronation.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 4 | *Aktorzy:* Narrator, Hugo Toras, Vina Toras, Sal Ignacius
- `[294]` [Rizia/Turn 1/A_ReligiousCeremony](Rizia/Turn_01/294_A_ReligiousCeremony.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 37 | *Aktorzy:* Narrator, Titus Gordion, Sal Ignacius, Player_Romus_Italic
- `[296]` [Rizia/Turn 2/FPnT_DiplomacyBriefing](Rizia/Turn_02/296_FPnT_DiplomacyBriefing.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 56 | *Aktorzy:* Narrator, Hugo Toras, Laurento Esquibel, Lucita Azaro
- `[311]` [Rizia/Turn 4/FPnT_PalesDukeVisit](Rizia/Turn_04/311_FPnT_PalesDukeVisit.md) — *Tura:* Tura 04 | *Opcje warunkowe:* 23 | *Aktorzy:* Narrator, Titus Gordion, Player_Romus_Italic, Axel Reinhart
- *...oraz 41 kolejnych rozmów w pełnym indeksie poniżej.*

### Morella i Wspólnota Południowa (Sal / Rusty / Morella / Grace / AN) (61 rozmów)

- `[21]` [Sordland/Turn02/Personal_FamilyDinner](Sordland/Turn_02/021_Personal_FamilyDinner.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 5 | *Aktorzy:* Player, Player_Italic, Narrator, Monica
- `[62]` [Sordland/Turn05/SnO_MilitaryBudget](Sordland/Turn_05/062_SnO_MilitaryBudget.md) — *Tura:* Tura 05 | *Opcje warunkowe:* 21 | *Aktorzy:* Petr Vectern, Player, Narrator, Valken Kruger
- `[132]` [Sordland/Turn07/A_OligarchsFinalMeeting](Sordland/Turn_07/132_A_OligarchsFinalMeeting.md) — *Tura:* Tura 07 | *Opcje warunkowe:* 0 | *Aktorzy:* Narrator
- `[186]` [Sordland/Turn09/Personal_FrancCalls](Sordland/Turn_09/186_Personal_FrancCalls.md) — *Tura:* Tura 09 | *Opcje warunkowe:* 32 | *Aktorzy:* Player, Player_Italic, Narrator, Franc
- `[205]` [Sordland/Turn09/FPnT_UnitedContanaVisit](Sordland/Turn_09/205_FPnT_UnitedContanaVisit.md) — *Tura:* Tura 09 | *Opcje warunkowe:* 14 | *Aktorzy:* Player, Player_Italic, Narrator, Monica
- `[226]` [Sordland/Turn10/FPnT_AllianceOfNations](Sordland/Turn_10/226_FPnT_AllianceOfNations.md) — *Tura:* Tura 10 | *Opcje warunkowe:* 72 | *Aktorzy:* Patricio Alvarez, Player, Player_Italic, Narrator
- `[288]` [Rizia/Turn 1/Start_Coronation](Rizia/Turn_01/288_Start_Coronation.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 4 | *Aktorzy:* Narrator, Hugo Toras, Vina Toras, Sal Ignacius
- `[291]` [Rizia/Turn 1/A_TorasPoliticalOverview](Rizia/Turn_01/291_A_TorasPoliticalOverview.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 12 | *Aktorzy:* Narrator, Hugo Toras, Vina Toras, Titus Gordion
- `[296]` [Rizia/Turn 2/FPnT_DiplomacyBriefing](Rizia/Turn_02/296_FPnT_DiplomacyBriefing.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 56 | *Aktorzy:* Narrator, Hugo Toras, Laurento Esquibel, Lucita Azaro
- `[305]` [Rizia/Turn 3/FPnT_QueenBeatriceVisit](Rizia/Turn_03/305_FPnT_QueenBeatriceVisit.md) — *Tura:* Tura 03 | *Opcje warunkowe:* 16 | *Aktorzy:* Narrator, Estela Toras, Vina Toras, Beatrice Livingston (R)
- *...oraz 51 kolejnych rozmów w pełnym indeksie poniżej.*

### Wielkie Rodziny Rizia (House Azaro / House Toras / House Sazon) (166 rozmów)

- `[287]` [Rizia/Turn 1/P_FamilyIntroduction](Rizia/Turn_01/287_P_FamilyIntroduction.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 8 | *Aktorzy:* Narrator, Estela Toras, Vina Toras, Player_Romus
- `[288]` [Rizia/Turn 1/Start_Coronation](Rizia/Turn_01/288_Start_Coronation.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 4 | *Aktorzy:* Narrator, Hugo Toras, Vina Toras, Sal Ignacius
- `[289]` [Rizia/Turn 1/EnT_CouncilBriefing](Rizia/Turn_01/289_EnT_CouncilBriefing.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 9 | *Aktorzy:* Narrator, Hugo Toras, Laurento Esquibel, Lucita Azaro
- `[290]` [Rizia/Turn 1/Economy and Treasury Section](Rizia/Turn_01/290_Economy_and_Treasury_Section.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 24 | *Aktorzy:* Narrator, Hugo Toras, Laurento Esquibel, Lucita Azaro
- `[291]` [Rizia/Turn 1/A_TorasPoliticalOverview](Rizia/Turn_01/291_A_TorasPoliticalOverview.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 12 | *Aktorzy:* Narrator, Hugo Toras, Vina Toras, Titus Gordion
- `[292]` [Rizia/Turn 1/Houses Briefing Section](Rizia/Turn_01/292_Houses_Briefing_Section.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 13 | *Aktorzy:* Narrator, Hugo Toras, Vina Toras, Player_Romus
- `[293]` [Rizia/Turn 1/Intention Questions](Rizia/Turn_01/293_Intention_Questions.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 1 | *Aktorzy:* Narrator, Hugo Toras, Vina Toras, Player_Romus
- `[295]` [Rizia/Turn 1/SnO_SecurityMilitaryMeeting](Rizia/Turn_01/295_SnO_SecurityMilitaryMeeting.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 26 | *Aktorzy:* Narrator, Hugo Toras, Laurento Esquibel, Lucita Azaro
- `[296]` [Rizia/Turn 2/FPnT_DiplomacyBriefing](Rizia/Turn_02/296_FPnT_DiplomacyBriefing.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 56 | *Aktorzy:* Narrator, Hugo Toras, Laurento Esquibel, Lucita Azaro
- `[297]` [Rizia/Turn 2/Pre-Meeting Talk With Vina Or Estela](Rizia/Turn_02/297_Pre-Meeting_Talk_With_Vina_Or_Estela.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 0 | *Aktorzy:* Narrator, Estela Toras, Vina Toras, Player_Romus_Italic
- *...oraz 156 kolejnych rozmów w pełnym indeksie poniżej.*

### Reforma Konstytucyjna Sordlandu (Zgromadzenie / Sąd Najwyższy / Dyktator) (128 rozmów)

- `[3]` [Sordland/Turn01/A_Media](Sordland/Turn_01/003_A_Media.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 2 | *Aktorzy:* Petr Vectern, Player, Narrator, Marcel Koronti
- `[4]` [Sordland/Turn01/A_PoliticalOverview](Sordland/Turn_01/004_A_PoliticalOverview.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 1 | *Aktorzy:* Petr Vectern, Player, Narrator, Lucian Galade
- `[14]` [Sordland/Turn02/A_ReformBriefing](Sordland/Turn_02/014_A_ReformBriefing.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 0 | *Aktorzy:* Petr Vectern, Player, Nia Morgna, Narrator
- `[15]` [Sordland/Turn02/DictatorSection](Sordland/Turn_02/015_DictatorSection.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 4 | *Aktorzy:* Petr Vectern, Player, Nia Morgna, Narrator
- `[16]` [Sordland/Turn02/AutocratSection](Sordland/Turn_02/016_AutocratSection.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 0 | *Aktorzy:* Petr Vectern, Player, Nia Morgna, Narrator
- `[17]` [Sordland/Turn02/ReformistSection](Sordland/Turn_02/017_ReformistSection.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 4 | *Aktorzy:* Petr Vectern, Player, Nia Morgna, Narrator
- `[18]` [Sordland/Turn02/A_AutocratBriefing](Sordland/Turn_02/018_A_AutocratBriefing.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 10 | *Aktorzy:* Player, Player_Italic, Orso Hawker, Narrator
- `[20]` [Sordland/Turn02/A_ContractBribe](Sordland/Turn_02/020_A_ContractBribe.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 1 | *Aktorzy:* Player, Player_Italic, Narrator, Walter Tusk
- `[27]` [Sordland/Turn03/Budget Feedback](Sordland/Turn_03/027_Budget_Feedback.md) — *Tura:* Tura 03 | *Opcje warunkowe:* 12 | *Aktorzy:* Paskal Beniwoll, Player, Nia Morgna, Narrator
- `[28]` [Sordland/Turn03/PSnW_Overview](Sordland/Turn_03/028_PSnW_Overview.md) — *Tura:* Tura 03 | *Opcje warunkowe:* 21 | *Aktorzy:* Paskal Beniwoll, Player, Narrator, Ciara Walda
- *...oraz 118 kolejnych rozmów w pełnym indeksie poniżej.*

### Oligarchowie i Gospodarka Sordlandu (Koronti / Tusk / Aven / Prywatyzacja) (89 rozmów)

- `[1]` [Sordland/Turn01/EnT_EconomicOverview](Sordland/Turn_01/001_EnT_EconomicOverview.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 19 | *Aktorzy:* Player, Player_Italic, Narrator, Gus Manger
- `[3]` [Sordland/Turn01/A_Media](Sordland/Turn_01/003_A_Media.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 2 | *Aktorzy:* Petr Vectern, Player, Narrator, Marcel Koronti
- `[6]` [Sordland/Turn01/Start_Inauguration](Sordland/Turn_01/006_Start_Inauguration.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 3 | *Aktorzy:* Player, Player_Italic, Orso Hawker, Narrator
- `[12]` [Sordland/Turn02/SnO_SecurityOverview](Sordland/Turn_02/012_SnO_SecurityOverview.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 1 | *Aktorzy:* Player, Player_Italic, Nia Morgna, Narrator
- `[13]` [Sordland/Turn02/A_MediaDeal](Sordland/Turn_02/013_A_MediaDeal.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 2 | *Aktorzy:* Petr Vectern, Player, Player_Italic, Narrator
- `[14]` [Sordland/Turn02/A_ReformBriefing](Sordland/Turn_02/014_A_ReformBriefing.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 0 | *Aktorzy:* Petr Vectern, Player, Nia Morgna, Narrator
- `[20]` [Sordland/Turn02/A_ContractBribe](Sordland/Turn_02/020_A_ContractBribe.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 1 | *Aktorzy:* Player, Player_Italic, Narrator, Walter Tusk
- `[22]` [Sordland/Turn02/FPnT_DiplomacyOverview](Sordland/Turn_02/022_FPnT_DiplomacyOverview.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 16 | *Aktorzy:* Petr Vectern, Player, Player_Italic, Narrator
- `[24]` [Sordland/Turn02/InT_HighwayContract](Sordland/Turn_02/024_InT_HighwayContract.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 7 | *Aktorzy:* Player, Player_Italic, Narrator, Lileas Graf
- `[25]` [Sordland/Turn02/InT_RailwayContract](Sordland/Turn_02/025_InT_RailwayContract.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 5 | *Aktorzy:* Player, Player_Italic, Narrator, Gus Manger
- *...oraz 79 kolejnych rozmów w pełnym indeksie poniżej.*

### Zagrożenie Rumburgiem i Konflikt Zbrojny (Kruger / Lancea / Livingston / Wojna) (93 rozmów)

- `[2]` [Sordland/Turn01/SnO_MPShot](Sordland/Turn_01/002_SnO_MPShot.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 4 | *Aktorzy:* Petr Vectern, Player, Nia Morgna, Narrator
- `[11]` [Sordland/Turn01/Shooting](Sordland/Turn_01/011_Shooting.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 0 | *Aktorzy:* Petr Vectern, Player, Player_Italic, Narrator
- `[12]` [Sordland/Turn02/SnO_SecurityOverview](Sordland/Turn_02/012_SnO_SecurityOverview.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 1 | *Aktorzy:* Player, Player_Italic, Nia Morgna, Narrator
- `[14]` [Sordland/Turn02/A_ReformBriefing](Sordland/Turn_02/014_A_ReformBriefing.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 0 | *Aktorzy:* Petr Vectern, Player, Nia Morgna, Narrator
- `[22]` [Sordland/Turn02/FPnT_DiplomacyOverview](Sordland/Turn_02/022_FPnT_DiplomacyOverview.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 16 | *Aktorzy:* Petr Vectern, Player, Player_Italic, Narrator
- `[23]` [Sordland/Turn02/Neighbor Overview Hubs](Sordland/Turn_02/023_Neighbor_Overview_Hubs.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 6 | *Aktorzy:* Player, Narrator, Deivid Wisci, Lucian Galade
- `[26]` [Sordland/Turn03/EnT_Budget](Sordland/Turn_03/026_EnT_Budget.md) — *Tura:* Tura 03 | *Opcje warunkowe:* 20 | *Aktorzy:* Paskal Beniwoll, Player, Player_Italic, Nia Morgna
- `[27]` [Sordland/Turn03/Budget Feedback](Sordland/Turn_03/027_Budget_Feedback.md) — *Tura:* Tura 03 | *Opcje warunkowe:* 12 | *Aktorzy:* Paskal Beniwoll, Player, Nia Morgna, Narrator
- `[39]` [Sordland/Turn03/A_AutocratSpeech](Sordland/Turn_03/039_A_AutocratSpeech.md) — *Tura:* Tura 03 | *Opcje warunkowe:* 16 | *Aktorzy:* Player, Narrator, Mansoun Leke, Gloria Tory
- `[40]` [Sordland/Turn03/EnT_BusinessCouncil](Sordland/Turn_03/040_EnT_BusinessCouncil.md) — *Tura:* Tura 03 | *Opcje warunkowe:* 4 | *Aktorzy:* Player, Player_Italic, Narrator, Mikail Aven
- *...oraz 83 kolejnych rozmów w pełnym indeksie poniżej.*

### Spisek Państwowy i Służby (Karl / Lileas / Lucian / Szpieg / Hawker) (156 rozmów)

- `[1]` [Sordland/Turn01/EnT_EconomicOverview](Sordland/Turn_01/001_EnT_EconomicOverview.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 19 | *Aktorzy:* Player, Player_Italic, Narrator, Gus Manger
- `[2]` [Sordland/Turn01/SnO_MPShot](Sordland/Turn_01/002_SnO_MPShot.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 4 | *Aktorzy:* Petr Vectern, Player, Nia Morgna, Narrator
- `[3]` [Sordland/Turn01/A_Media](Sordland/Turn_01/003_A_Media.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 2 | *Aktorzy:* Petr Vectern, Player, Narrator, Marcel Koronti
- `[4]` [Sordland/Turn01/A_PoliticalOverview](Sordland/Turn_01/004_A_PoliticalOverview.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 1 | *Aktorzy:* Petr Vectern, Player, Narrator, Lucian Galade
- `[6]` [Sordland/Turn01/Start_Inauguration](Sordland/Turn_01/006_Start_Inauguration.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 3 | *Aktorzy:* Player, Player_Italic, Orso Hawker, Narrator
- `[8]` [Sordland/Turn01/InT_Infrastructure](Sordland/Turn_01/008_InT_Infrastructure.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 3 | *Aktorzy:* Player, Player_Italic, Narrator, Gus Manger
- `[11]` [Sordland/Turn01/Shooting](Sordland/Turn_01/011_Shooting.md) — *Tura:* Tura 01 | *Opcje warunkowe:* 0 | *Aktorzy:* Petr Vectern, Player, Player_Italic, Narrator
- `[12]` [Sordland/Turn02/SnO_SecurityOverview](Sordland/Turn_02/012_SnO_SecurityOverview.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 1 | *Aktorzy:* Player, Player_Italic, Nia Morgna, Narrator
- `[13]` [Sordland/Turn02/A_MediaDeal](Sordland/Turn_02/013_A_MediaDeal.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 2 | *Aktorzy:* Petr Vectern, Player, Player_Italic, Narrator
- `[14]` [Sordland/Turn02/A_ReformBriefing](Sordland/Turn_02/014_A_ReformBriefing.md) — *Tura:* Tura 02 | *Opcje warunkowe:* 0 | *Aktorzy:* Petr Vectern, Player, Nia Morgna, Narrator
- *...oraz 146 kolejnych rozmów w pełnym indeksie poniżej.*

---

## Kingdom of Rizia — Pełna Lista Rozmów (230)

| ID | Tura / Sekcja | Tytuł Sceny | Węzły | Wybory | W tym Warunkowe | Główni Uczestnicy | Plik |
|---|---|---|---|---|---|---|---|
| `356` | Decree (CouncilRoyalDecrees) | CouncilRoyalDecrees | 70 | 4 | **0** | Narrator, Hugo Toras, Player_Romus | [Otwórz](Rizia/Decrees/356_CouncilRoyalDecrees.md) |
| `578` | Decree (ABOLISHLEVIES) | ABOLISHLEVIES Conversation | 157 | 39 | **5** | Narrator, Hugo Toras, Player_Romus_Italic... | [Otwórz](Rizia/Decrees/578_ABOLISHLEVIES_Conversation.md) |
| `579` | Decree (INCREASELEVIES) | INCREASELEVIES Conversation | 139 | 36 | **5** | Narrator, Hugo Toras, Player_Romus_Italic... | [Otwórz](Rizia/Decrees/579_INCREASELEVIES_Conversation.md) |
| `580` | Decree (ABOLISHLOCALPOLICE) | ABOLISHLOCALPOLICE Conversation | 104 | 24 | **3** | Narrator, Hugo Toras, Player_Romus_Italic... | [Otwórz](Rizia/Decrees/580_ABOLISHLOCALPOLICE_Conversation.md) |
| `581` | Decree (FREEPRESS) | FREEPRESS Conversation | 217 | 55 | **20** | Narrator, Hugo Toras, Player_Romus_Italic... | [Otwórz](Rizia/Decrees/581_FREEPRESS_Conversation.md) |
| `582` | Decree (INHERITANCETAX) | INHERITANCETAX Conversation | 145 | 36 | **5** | Narrator, Hugo Toras, Player_Romus_Italic... | [Otwórz](Rizia/Decrees/582_INHERITANCETAX_Conversation.md) |
| `583` | Decree (LANDOWNERSTAX) | LANDOWNERSTAX Conversation | 145 | 36 | **5** | Narrator, Hugo Toras, Player_Romus_Italic... | [Otwórz](Rizia/Decrees/583_LANDOWNERSTAX_Conversation.md) |
| `584` | Decree (Decriminalize Homosexuality) | Decriminalize Homosexuality Conversation | 155 | 32 | **12** | Narrator, Hugo Toras, Player_Romus_Italic... | [Otwórz](Rizia/Decrees/584_Decriminalize_Homosexuality_Conversation.md) |
| `597` | Decree (Elections) | Elections Conversation | 113 | 0 | **0** |  | [Otwórz](Rizia/Decrees/597_Elections_Conversation.md) |
| `425` | Epilogue (Epilogue) | Epilogue | 105 | 0 | **0** |  | [Otwórz](Rizia/Epilogue/425_Epilogue.md) |
| `426` | Epilogue (Exile) | Exile | 887 | 182 | **40** | Narrator, Player_Romus | [Otwórz](Rizia/Epilogue/426_Exile.md) |
| `427` | Epilogue (Immediate Death) | Immediate Death | 175 | 46 | **2** | Narrator, Player_Romus | [Otwórz](Rizia/Epilogue/427_Immediate_Death.md) |
| `428` | Epilogue (Prison) | Prison | 400 | 90 | **19** | Narrator, Player_Romus | [Otwórz](Rizia/Epilogue/428_Prison.md) |
| `429` | Epilogue (Survived) | Survived | 351 | 48 | **6** | Narrator, Player_Romus | [Otwórz](Rizia/Epilogue/429_Survived.md) |
| `430` | Epilogue (Peaceful Power Transition) | Peaceful Power Transition | 694 | 178 | **42** | Narrator, Player_Romus | [Otwórz](Rizia/Epilogue/430_Peaceful_Power_Transition.md) |
| `431` | Epilogue (Civil War) | Civil War | 751 | 106 | **25** | Narrator, Player_Romus | [Otwórz](Rizia/Epilogue/431_Civil_War.md) |
| `432` | Epilogue (Continued Reign) | Continued Reign | 772 | 205 | **29** | Narrator, Player_Romus | [Otwórz](Rizia/Epilogue/432_Continued_Reign.md) |
| `303` | Prologue | Prologue | 373 | 151 | **23** | Narrator, Player_Romus | [Otwórz](Rizia/Prologue/303_Prologue.md) |
| `287` | Tura 01 | P_FamilyIntroduction | 413 | 113 | **8** | Narrator, Estela Toras, Vina Toras... | [Otwórz](Rizia/Turn_01/287_P_FamilyIntroduction.md) |
| `288` | Tura 01 | Start_Coronation | 192 | 40 | **4** | Narrator, Hugo Toras, Vina Toras... | [Otwórz](Rizia/Turn_01/288_Start_Coronation.md) |
| `289` | Tura 01 | EnT_CouncilBriefing | 294 | 56 | **9** | Narrator, Hugo Toras, Laurento Esquibel... | [Otwórz](Rizia/Turn_01/289_EnT_CouncilBriefing.md) |
| `290` | Tura 01 | Economy and Treasury Section | 438 | 102 | **24** | Narrator, Hugo Toras, Laurento Esquibel... | [Otwórz](Rizia/Turn_01/290_Economy_and_Treasury_Section.md) |
| `291` | Tura 01 | A_TorasPoliticalOverview | 437 | 96 | **12** | Narrator, Hugo Toras, Vina Toras... | [Otwórz](Rizia/Turn_01/291_A_TorasPoliticalOverview.md) |
| `292` | Tura 01 | Houses Briefing Section | 201 | 41 | **13** | Narrator, Hugo Toras, Vina Toras... | [Otwórz](Rizia/Turn_01/292_Houses_Briefing_Section.md) |
| `293` | Tura 01 | Intention Questions | 88 | 13 | **1** | Narrator, Hugo Toras, Vina Toras... | [Otwórz](Rizia/Turn_01/293_Intention_Questions.md) |
| `294` | Tura 01 | A_ReligiousCeremony | 1006 | 292 | **37** | Narrator, Titus Gordion, Sal Ignacius... | [Otwórz](Rizia/Turn_01/294_A_ReligiousCeremony.md) |
| `295` | Tura 01 | SnO_SecurityMilitaryMeeting | 565 | 117 | **26** | Narrator, Hugo Toras, Laurento Esquibel... | [Otwórz](Rizia/Turn_01/295_SnO_SecurityMilitaryMeeting.md) |
| `296` | Tura 02 | FPnT_DiplomacyBriefing *(MOD)* | 796 | 180 | **56** | Narrator, Hugo Toras, Laurento Esquibel... | [Otwórz](Rizia/Turn_02/296_FPnT_DiplomacyBriefing.md) |
| `297` | Tura 02 | Pre-Meeting Talk With Vina Or Estela | 200 | 79 | **0** | Narrator, Estela Toras, Vina Toras... | [Otwórz](Rizia/Turn_02/297_Pre-Meeting_Talk_With_Vina_Or_Estela.md) |
| `298` | Tura 02 | FPnT_ZilleVisit *(MOD)* | 310 | 106 | **7** | Narrator, Estela Toras, Wiktor Smolak (R)... | [Otwórz](Rizia/Turn_02/298_FPnT_ZilleVisit.md) |
| `299` | Tura 02 | FPnT_SordlandTradeVisit | 427 | 107 | **12** | Narrator, Ewald Alphonso (R), Gus Manger (R)... | [Otwórz](Rizia/Turn_02/299_FPnT_SordlandTradeVisit.md) |
| `300` | Tura 02 | P_VinaAtMonqiz | 568 | 155 | **20** | Narrator, Vina Toras, Titus Gordion... | [Otwórz](Rizia/Turn_02/300_P_VinaAtMonqiz.md) |
| `301` | Tura 02 | Pabel Valero Poisoning Talk | 198 | 44 | **6** | Narrator, Player_Romus, Pabel Adria | [Otwórz](Rizia/Turn_02/301_Pabel_Valero_Poisoning_Talk.md) |
| `302` | Tura 02 | SnO_TitusGoldenGuard | 729 | 199 | **41** | Narrator, Hugo Toras, Titus Gordion... | [Otwórz](Rizia/Turn_02/302_SnO_TitusGoldenGuard.md) |
| `304` | Tura 03 | SnO_ZilleSecurityDebrief | 510 | 127 | **16** | Narrator, Hugo Toras, Laurento Esquibel... | [Otwórz](Rizia/Turn_03/304_SnO_ZilleSecurityDebrief.md) |
| `305` | Tura 03 | FPnT_QueenBeatriceVisit | 558 | 136 | **16** | Narrator, Estela Toras, Vina Toras... | [Otwórz](Rizia/Turn_03/305_FPnT_QueenBeatriceVisit.md) |
| `306` | Tura 03 | NOTES | 72 | 26 | **3** | Narrator, Emmerich Hegel (R), Beatrice Livingston (R)... | [Otwórz](Rizia/Turn_03/306_NOTES.md) |
| `307` | Tura 03 | A_VisitToIza | 743 | 156 | **23** | Narrator, Hugo Toras, Vina Toras... | [Otwórz](Rizia/Turn_03/307_A_VisitToIza.md) |
| `308` | Tura 03 | A_VisitToSallabes | 375 | 89 | **10** | Narrator, Leona Sazon, Manus Sazon... | [Otwórz](Rizia/Turn_03/308_A_VisitToSallabes.md) |
| `309` | Tura 03 | A_VisitToMontaklar | 683 | 173 | **38** | Narrator, Lucita Azaro, Player_Romus_Italic... | [Otwórz](Rizia/Turn_03/309_A_VisitToMontaklar.md) |
| `310` | Tura 03 | EnT_ElenaRustyMeeting | 384 | 80 | **6** | Narrator, Hugo Toras, Elena Werner... | [Otwórz](Rizia/Turn_03/310_EnT_ElenaRustyMeeting.md) |
| `311` | Tura 04 | FPnT_PalesDukeVisit | 957 | 289 | **23** | Narrator, Titus Gordion, Player_Romus_Italic... | [Otwórz](Rizia/Turn_04/311_FPnT_PalesDukeVisit.md) |
| `312` | Tura 04 | A_HouseOfDelegates | 551 | 87 | **21** | Narrator, Hugo Toras, Manus Sazon... | [Otwórz](Rizia/Turn_04/312_A_HouseOfDelegates.md) |
| `313` | Tura 04 | A_CouncilTalkAboutPales | 418 | 83 | **14** | Narrator, Hugo Toras, Laurento Esquibel... | [Otwórz](Rizia/Turn_04/313_A_CouncilTalkAboutPales.md) |
| `314` | Tura 04 | FPnT_AlvarezCall | 597 | 160 | **23** | Narrator, Laurento Esquibel, Player_Romus... | [Otwórz](Rizia/Turn_04/314_FPnT_AlvarezCall.md) |
| `315` | Tura 04 | P_EstelaUpdate | 399 | 110 | **24** | Narrator, Estela Toras, Vina Toras... | [Otwórz](Rizia/Turn_04/315_P_EstelaUpdate.md) |
| `316` | Tura 04 | FPnT_ANSouthMerkopa | 831 | 275 | **55** | Narrator, Jorga Azmal, Laurento Esquibel... | [Otwórz](Rizia/Turn_04/316_FPnT_ANSouthMerkopa.md) |
| `317` | Tura 04 | P_PabelLucitaRomance | 654 | 147 | **28** | Narrator, Estela Toras, Hubertus Toras... | [Otwórz](Rizia/Turn_04/317_P_PabelLucitaRomance.md) |
| `318` | Tura 04 | Drinking Game | 830 | 150 | **54** | Narrator, Laurento Esquibel, Lucita Azaro... | [Otwórz](Rizia/Turn_04/318_Drinking_Game.md) |
| `319` | Tura 04 | FPnT_SordlandBondPurchase | 1016 | 159 | **48** | Narrator, Ewald Alphonso (R), Gus Manger (R)... | [Otwórz](Rizia/Turn_04/319_FPnT_SordlandBondPurchase.md) |
| `320` | Tura 05 | P_ManusVinaTalk | 1471 | 277 | **98** | Narrator, Manus Sazon, Vina Toras... | [Otwórz](Rizia/Turn_05/320_P_ManusVinaTalk.md) |
| `321` | Tura 05 | FPnT_MITZBoardMeeting | 1049 | 197 | **62** | Narrator, Emmerich Hegel (R), Elena Werner... | [Otwórz](Rizia/Turn_05/321_FPnT_MITZBoardMeeting.md) |
| `322` | Tura 05 | FPnT_MITZHegelCall | 780 | 229 | **51** | Narrator, Emmerich Hegel (R), Bruno... | [Otwórz](Rizia/Turn_05/322_FPnT_MITZHegelCall.md) |
| `323` | Tura 05 | FPnT_MorellaNegotiations | 1087 | 268 | **48** | Narrator, Player_Romus_Italic, Player_Romus... | [Otwórz](Rizia/Turn_05/323_FPnT_MorellaNegotiations.md) |
| `324` | Tura 05 | SnO_InternalSecurity | 1642 | 338 | **116** | Narrator, Hugo Toras, Lucita Azaro... | [Otwórz](Rizia/Turn_05/324_SnO_InternalSecurity.md) |
| `325` | Tura 05 | Notes | 37 | 11 | **0** | Hugo Toras, Lucita Azaro, Titus Gordion... | [Otwórz](Rizia/Turn_05/325_Notes.md) |
| `326` | Tura 05 | FPnT_WehlenNegotiations | 1560 | 252 | **52** | Narrator, Hugo Toras, Laurento Esquibel... | [Otwórz](Rizia/Turn_05/326_FPnT_WehlenNegotiations.md) |
| `327` | Tura 05 | EnT_MorellaNegotiationFeedback | 1228 | 170 | **58** | Narrator, Laurento Esquibel, Elena Werner... | [Otwórz](Rizia/Turn_05/327_EnT_MorellaNegotiationFeedback.md) |
| `328` | Tura 05 | SnO_TitusLucitaBriefing | 920 | 162 | **69** | Narrator, Lucita Azaro, Titus Gordion... | [Otwórz](Rizia/Turn_05/328_SnO_TitusLucitaBriefing.md) |
| `329` | Tura 05 | FPnT_MorellaReturnFlight | 41 | 0 | **0** | Narrator | [Otwórz](Rizia/Turn_05/329_FPnT_MorellaReturnFlight.md) |
| `357` | Tura 06 | SnO_WarEruptionBriefing | 579 | 60 | **14** | Narrator, Lucita Azaro, Taddeus Azaro... | [Otwórz](Rizia/Turn_06/357_SnO_WarEruptionBriefing.md) |
| `358` | Tura 06 | SnO_PalesPostIncidentMeeting | 847 | 258 | **37** | Narrator, Player_Romus_Italic, Axel Reinhart... | [Otwórz](Rizia/Turn_06/358_SnO_PalesPostIncidentMeeting.md) |
| `359` | Tura 06 | SnO_Incident | 485 | 106 | **22** | Narrator, Hugo Toras, Laurento Esquibel... | [Otwórz](Rizia/Turn_06/359_SnO_Incident.md) |
| `360` | Tura 06 | A_ReligionBriefing | 1589 | 350 | **132** | Narrator, Titus Gordion, Sal Ignacius... | [Otwórz](Rizia/Turn_06/360_A_ReligionBriefing.md) |
| `361` | Tura 06 | A_CouncilMeeting | 889 | 197 | **37** | Narrator, Hugo Toras, Laurento Esquibel... | [Otwórz](Rizia/Turn_06/361_A_CouncilMeeting.md) |
| `362` | Tura 06 | WIP | 15 | 1 | **0** | Player_Romus | [Otwórz](Rizia/Turn_06/362_WIP.md) |
| `363` | Tura 06 | HOD Results | 258 | 16 | **16** | Narrator, Hugo Toras, Player_Romus | [Otwórz](Rizia/Turn_06/363_HOD_Results.md) |
| `364` | Tura 06 | AN Individual Support | 32 | 0 | **0** | Laurento Esquibel | [Otwórz](Rizia/Turn_06/364_AN_Individual_Support.md) |
| `365` | Tura 06 | ELECTION CALCULATIONS | 3 | 0 | **0** |  | [Otwórz](Rizia/Turn_06/365_ELECTION_CALCULATIONS.md) |
| `366` | Tura 06 | Calculations | 204 | 0 | **0** |  | [Otwórz](Rizia/Turn_06/366_Calculations.md) |
| `367` | Tura 06 | WIP_Old | 129 | 0 | **0** |  | [Otwórz](Rizia/Turn_06/367_WIP_Old.md) |
| `368` | Tura 06 | FPnT_DukeWarPhoneCall | 93 | 40 | **3** | Narrator, Axel Reinhart, Player_Romus | [Otwórz](Rizia/Turn_06/368_FPnT_DukeWarPhoneCall.md) |
| `369` | Tura 06 | SnO_PalesDealSigning | 556 | 123 | **57** | Narrator, Laurento Esquibel, Vina Toras... | [Otwórz](Rizia/Turn_06/369_SnO_PalesDealSigning.md) |
| `370` | Tura 06 | P_Cemetary | 909 | 176 | **77** | Narrator, Estela Toras, Vina Toras... | [Otwórz](Rizia/Turn_06/370_P_Cemetary.md) |
| `371` | Tura 06 | A_BorderInvestigationResults | 232 | 50 | **8** | Narrator, Hugo Toras, Laurento Esquibel... | [Otwórz](Rizia/Turn_06/371_A_BorderInvestigationResults.md) |
| `372` | Tura 06 | A_PalaceBalconySpeech | 505 | 197 | **88** | Narrator, Hugo Toras, Player_Romus_Italic... | [Otwórz](Rizia/Turn_06/372_A_PalaceBalconySpeech.md) |
| `373` | Tura 06 | Intro Section | 197 | 48 | **7** | Narrator, Estela Toras, Hugo Toras... | [Otwórz](Rizia/Turn_06/373_Intro_Section.md) |
| `374` | Tura 06 | Outro | 107 | 40 | **9** | Narrator, Estela Toras, Hugo Toras... | [Otwórz](Rizia/Turn_06/374_Outro.md) |
| `375` | Tura 06 | P_LucitaAzaroUpdate | 918 | 165 | **78** | Narrator, Lucita Azaro, Player_Romus_Italic... | [Otwórz](Rizia/Turn_06/375_P_LucitaAzaroUpdate.md) |
| `376` | Tura 06 | A_Rusty_FootballGame | 1166 | 240 | **83** | Narrator, Lucita Azaro, Titus Gordion... | [Otwórz](Rizia/Turn_06/376_A_Rusty_FootballGame.md) |
| `585` | Tura 06 | Star_Align_Notes Conversation | 29 | 7 | **6** | Narrator, Sal Ignacius, Player_Romus | [Otwórz](Rizia/Turn_06/585_Star_Align_Notes_Conversation.md) |
| `586` | Tura 06 | ENERGY SITUATION Conversation | 338 | 10 | **9** | Narrator, Hugo Toras, Laurento Esquibel... | [Otwórz](Rizia/Turn_06/586_ENERGY_SITUATION_Conversation.md) |
| `587` | Tura 06 | NOTES_HugoSpeaks (Election content - move to earlier turn?) Conversation | 58 | 6 | **2** | Narrator, Hugo Toras, Player_Romus | [Otwórz](Rizia/Turn_06/587_NOTES_HugoSpeaks_(Election_content_-_move_to_earlier_turn_)_Conversation.md) |
| `377` | Tura 07 | FPnT_DerdiaNegotiations | 988 | 191 | **68** | Narrator, Jorga Azmal, Titus Gordion... | [Otwórz](Rizia/Turn_07/377_FPnT_DerdiaNegotiations.md) |
| `378` | Tura 07 | Morella Discussion Friendly | 105 | 24 | **12** | Narrator, Jorga Azmal, Sal Ignacius... | [Otwórz](Rizia/Turn_07/378_Morella_Discussion_Friendly.md) |
| `379` | Tura 07 | Morella Discussion Unfriendly | 92 | 20 | **10** | Narrator, Jorga Azmal, Sal Ignacius... | [Otwórz](Rizia/Turn_07/379_Morella_Discussion_Unfriendly.md) |
| `380` | Tura 07 | Fighting Assistance Unfriendly | 160 | 36 | **14** | Narrator, Jorga Azmal, Sal Ignacius... | [Otwórz](Rizia/Turn_07/380_Fighting_Assistance_Unfriendly.md) |
| `381` | Tura 07 | Fighting Assistance Friendly | 180 | 37 | **11** | Narrator, Jorga Azmal, Sal Ignacius... | [Otwórz](Rizia/Turn_07/381_Fighting_Assistance_Friendly.md) |
| `382` | Tura 07 | Energy Partnership Unfriendly | 109 | 24 | **10** | Narrator, Jorga Azmal, Sal Ignacius... | [Otwórz](Rizia/Turn_07/382_Energy_Partnership_Unfriendly.md) |
| `383` | Tura 07 | Energy Partnership Friendly | 115 | 27 | **11** | Narrator, Jorga Azmal, Sal Ignacius... | [Otwórz](Rizia/Turn_07/383_Energy_Partnership_Friendly.md) |
| `384` | Tura 07 | A_HouseOfDelegatesII | 430 | 85 | **43** | Narrator, Hugo Toras, Manus Sazon... | [Otwórz](Rizia/Turn_07/384_A_HouseOfDelegatesII.md) |
| `385` | Tura 07 | Pales War Update And Tax | 171 | 24 | **5** | Narrator, Hugo Toras, Manus Sazon... | [Otwórz](Rizia/Turn_07/385_Pales_War_Update_And_Tax.md) |
| `386` | Tura 07 | Zille Treaty Discussion | 215 | 16 | **3** | Narrator, Hugo Toras, Manus Sazon... | [Otwórz](Rizia/Turn_07/386_Zille_Treaty_Discussion.md) |
| `387` | Tura 07 | Public Opinion | 548 | 60 | **19** | Narrator, Manus Sazon, Daria de Rava... | [Otwórz](Rizia/Turn_07/387_Public_Opinion.md) |
| `388` | Tura 07 | Religion | 563 | 116 | **35** | Narrator, Hugo Toras, Manus Sazon... | [Otwórz](Rizia/Turn_07/388_Religion.md) |
| `389` | Tura 07 | FPnT_RumburgMeeting | 1641 | 277 | **106** | Narrator, Laurento Esquibel, Lucita Azaro... | [Otwórz](Rizia/Turn_07/389_FPnT_RumburgMeeting.md) |
| `390` | Tura 07 | BFF Convo (Friendly) | 106 | 18 | **10** | Narrator, Laurento Esquibel, Beatrice Livingston (R)... | [Otwórz](Rizia/Turn_07/390_BFF_Convo_(Friendly).md) |
| `391` | Tura 07 | BFF Convo (Friendly) | 107 | 18 | **10** | Narrator, Laurento Esquibel, Beatrice Livingston (R)... | [Otwórz](Rizia/Turn_07/391_BFF_Convo_(Friendly).md) |
| `392` | Tura 07 | P_PabelPrivateTalk | 769 | 199 | **72** | Narrator, Titus Gordion, Player_Romus_Italic... | [Otwórz](Rizia/Turn_07/392_P_PabelPrivateTalk.md) |
| `393` | Tura 07 | FPnT_DukeVisit | 855 | 179 | **52** | Narrator, Player_Romus_Italic, Axel Reinhart... | [Otwórz](Rizia/Turn_07/393_FPnT_DukeVisit.md) |
| `394` | Tura 07 | P_TorasDinner | 1127 | 206 | **87** | Narrator, Estela Toras, Vina Toras... | [Otwórz](Rizia/Turn_07/394_P_TorasDinner.md) |
| `395` | Tura 07 | A_HugoManusPrivateTalk | 1520 | 311 | **110** | Narrator, Hugo Toras, Manus Sazon... | [Otwórz](Rizia/Turn_07/395_A_HugoManusPrivateTalk.md) |
| `396` | Tura 07 | New Security Councilor Talk | 124 | 31 | **13** | Narrator, Hugo Toras, Player_Romus | [Otwórz](Rizia/Turn_07/396_New_Security_Councilor_Talk.md) |
| `397` | Tura 07 | WIP_HODShutdownIntention | 59 | 12 | **7** | Narrator, Hugo Toras, Player_Romus | [Otwórz](Rizia/Turn_07/397_WIP_HODShutdownIntention.md) |
| `398` | Tura 07 | P_HugoConfronts | 190 | 59 | **6** | Narrator, Hugo Toras, Player_Romus_Italic... | [Otwórz](Rizia/Turn_07/398_P_HugoConfronts.md) |
| `399` | Tura 07 | A_IzaUniversity | 1297 | 252 | **105** | Narrator, Vina Toras, Titus Gordion... | [Otwórz](Rizia/Turn_07/399_A_IzaUniversity.md) |
| `400` | Tura 07 | Angelica Greeting | 71 | 14 | **4** | Narrator, Player_Romus, Angelica Sazon | [Otwórz](Rizia/Turn_07/400_Angelica_Greeting.md) |
| `401` | Tura 08 | FPnT_ANSession | 331 | 78 | **28** | Narrator, Laurento Esquibel, Ephraim Nines (R)... | [Otwórz](Rizia/Turn_08/401_FPnT_ANSession.md) |
| `402` | Tura 08 | Sanctions | 385 | 32 | **7** | Narrator, Jorga Azmal, Laurento Esquibel... | [Otwórz](Rizia/Turn_08/402_Sanctions.md) |
| `403` | Tura 08 | Heljiland Dispute | 101 | 13 | **3** | Narrator, Jorga Azmal, Laurento Esquibel... | [Otwórz](Rizia/Turn_08/403_Heljiland_Dispute.md) |
| `404` | Tura 08 | Zille Territory Issue | 431 | 84 | **18** | Narrator, Jorga Azmal, Laurento Esquibel... | [Otwórz](Rizia/Turn_08/404_Zille_Territory_Issue.md) |
| `405` | Tura 08 | WIP_Lunch Break | 193 | 18 | **0** | Narrator, Laurento Esquibel, Deivid Wisci (R)... | [Otwórz](Rizia/Turn_08/405_WIP_Lunch_Break.md) |
| `406` | Tura 08 | A_SalInvestigationResults | 825 | 127 | **37** | Narrator, Lucita Azaro, Titus Gordion... | [Otwórz](Rizia/Turn_08/406_A_SalInvestigationResults.md) |
| `407` | Tura 08 | A_Reform_Manus | 870 | 170 | **56** | Narrator, Manus Sazon, Player_Romus | [Otwórz](Rizia/Turn_08/407_A_Reform_Manus.md) |
| `408` | Tura 08 | NOTES_CONSTITION FINALIZED | 78 | 22 | **5** | Narrator, Manus Sazon, Player_Romus | [Otwórz](Rizia/Turn_08/408_NOTES_CONSTITION_FINALIZED.md) |
| `409` | Tura 08 | SnO_SecurityBriefAndZille | 2451 | 322 | **78** | Narrator, Lucita Azaro, Titus Gordion... | [Otwórz](Rizia/Turn_08/409_SnO_SecurityBriefAndZille.md) |
| `410` | Tura 08 | SnO_War_Pales_PostOperation1 | 312 | 40 | **8** | Narrator, Lucita Azaro, Taddeus Azaro... | [Otwórz](Rizia/Turn_08/410_SnO_War_Pales_PostOperation1.md) |
| `411` | Tura 08 | Operation 1 Results | 310 | 32 | **9** | Narrator, Lucita Azaro, Taddeus Azaro... | [Otwórz](Rizia/Turn_08/411_Operation_1_Results.md) |
| `412` | Tura 08 | Operation 2 Next Steps | 278 | 30 | **16** | Narrator, Lucita Azaro, Taddeus Azaro... | [Otwórz](Rizia/Turn_08/412_Operation_2_Next_Steps.md) |
| `413` | Tura 08 | A_HugoLeaves | 120 | 26 | **2** | Narrator, Hugo Toras, Player_Romus | [Otwórz](Rizia/Turn_08/413_A_HugoLeaves.md) |
| `414` | Tura 08 | P_NightBeforeWedding | 895 | 189 | **61** | Narrator, Hugo Toras, Lucita Azaro... | [Otwórz](Rizia/Turn_08/414_P_NightBeforeWedding.md) |
| `415` | Tura 08 | VINA ESCAPES | 176 | 41 | **11** | Narrator, Estela Toras, Titus Gordion... | [Otwórz](Rizia/Turn_08/415_VINA_ESCAPES.md) |
| `416` | Tura 08 | RustyCall | 1198 | 255 | **127** | Narrator, Russello Montoro, Player_Romus_Italic... | [Otwórz](Rizia/Turn_08/416_RustyCall.md) |
| `417` | Tura 08 | A_RoyalWedding | 1612 | 228 | **107** | Narrator, Estela Toras, Hugo Toras... | [Otwórz](Rizia/Turn_08/417_A_RoyalWedding.md) |
| `418` | Tura 08 | Bull Gift | 19 | 4 | **1** | Narrator, Hugo Toras, Player_Romus | [Otwórz](Rizia/Turn_08/418_Bull_Gift.md) |
| `419` | Tura 08 | A_GeneralCouncilMeeting | 867 | 71 | **22** | Narrator, Hugo Toras, Laurento Esquibel... | [Otwórz](Rizia/Turn_08/419_A_GeneralCouncilMeeting.md) |
| `420` | Tura 08 | Vina Non Marriage | 30 | 3 | **0** | Narrator, Manus Sazon, Player_Romus | [Otwórz](Rizia/Turn_08/420_Vina_Non_Marriage.md) |
| `421` | Tura 08 | RRG Nationalization | 155 | 14 | **4** | Narrator, Hugo Toras, Laurento Esquibel... | [Otwórz](Rizia/Turn_08/421_RRG_Nationalization.md) |
| `422` | Tura 08 | A_HouseOfDelegates3 | 1863 | 207 | **98** | Narrator, Hugo Toras, Lucita Azaro... | [Otwórz](Rizia/Turn_08/422_A_HouseOfDelegates3.md) |
| `423` | Tura 08 | FPnT_AlvarezVisit | 1086 | 250 | **36** | Narrator, Player_Romus_Italic, Player_Romus... | [Otwórz](Rizia/Turn_08/423_FPnT_AlvarezVisit.md) |
| `424` | Tura 08 | FPnT_ZilleNegotiations | 1265 | 228 | **82** | Narrator, Wiktor Smolak (R), Player_Romus_Italic... | [Otwórz](Rizia/Turn_08/424_FPnT_ZilleNegotiations.md) |
| `588` | Tura 08 | Notes Conversation | 520 | 90 | **11** | Narrator, Lucita Azaro, Titus Gordion... | [Otwórz](Rizia/Turn_08/588_Notes_Conversation.md) |
| `589` | Tura 08 | FOREIGNAFFAIRS Conversation | 472 | 81 | **13** | Narrator, Hugo Toras, Laurento Esquibel... | [Otwórz](Rizia/Turn_08/589_FOREIGNAFFAIRS_Conversation.md) |
| `590` | Tura 08 | SECURITY Conversation | 287 | 10 | **2** | Narrator, Hugo Toras, Lucita Azaro... | [Otwórz](Rizia/Turn_08/590_SECURITY_Conversation.md) |
| `591` | Tura 08 | ECONOMY Conversation | 483 | 62 | **26** | Narrator, Hugo Toras, Laurento Esquibel... | [Otwórz](Rizia/Turn_08/591_ECONOMY_Conversation.md) |
| `592` | Tura 08 | Garden Conversation | 735 | 179 | **42** | Narrator, Manus Sazon, Titus Gordion... | [Otwórz](Rizia/Turn_08/592_Garden_Conversation.md) |
| `593` | Tura 08 | HugoConfronts Conversation | 41 | 16 | **0** | Narrator, Hugo Toras, Player_Romus | [Otwórz](Rizia/Turn_08/593_HugoConfronts_Conversation.md) |
| `594` | Tura 08 | Reform_Movement_Unrest Conversation | 61 | 0 | **0** |  | [Otwórz](Rizia/Turn_08/594_Reform_Movement_Unrest_Conversation.md) |
| `595` | Tura 08 | Religious_Affairs Conversation | 1033 | 158 | **52** | Narrator, Hugo Toras, Lucita Azaro... | [Otwórz](Rizia/Turn_08/595_Religious_Affairs_Conversation.md) |
| `596` | Tura 08 | Notes Conversation | 136 | 36 | **4** | Narrator, Wiktor Smolak (R), Titus Gordion... | [Otwórz](Rizia/Turn_08/596_Notes_Conversation.md) |
| `433` | Tura 09 | FPnT_GRACERumburgMeeting | 944 | 147 | **48** | Narrator, Beatrice Livingston (R), Player_Romus_Italic... | [Otwórz](Rizia/Turn_09/433_FPnT_GRACERumburgMeeting.md) |
| `434` | Tura 09 | FPnT_CallWithSmolak | 208 | 52 | **12** | Narrator, Wiktor Smolak (R), Player_Romus | [Otwórz](Rizia/Turn_09/434_FPnT_CallWithSmolak.md) |
| `435` | Tura 09 | FPnT_Mediation | 13 | 0 | **0** | Narrator | [Otwórz](Rizia/Turn_09/435_FPnT_Mediation.md) |
| `436` | Tura 09 | Morella Derdia Mediation | 403 | 63 | **29** | Narrator, Jorga Azmal, Laurento Esquibel... | [Otwórz](Rizia/Turn_09/436_Morella_Derdia_Mediation.md) |
| `437` | Tura 09 | Wehlen Derdia Meditation | 394 | 56 | **29** | Narrator, Jorga Azmal, Laurento Esquibel... | [Otwórz](Rizia/Turn_09/437_Wehlen_Derdia_Meditation.md) |
| `438` | Tura 09 | Pabel Extradition | 80 | 16 | **6** | Narrator, Jorga Azmal, Player_Romus | [Otwórz](Rizia/Turn_09/438_Pabel_Extradition.md) |
| `439` | Tura 09 | FPnT_IntermerkopumRoundtable | 1074 | 145 | **67** | Narrator, Jorga Azmal, Laurento Esquibel... | [Otwórz](Rizia/Turn_09/439_FPnT_IntermerkopumRoundtable.md) |
| `440` | Tura 09 | A_ZilleReturnedSpeech | 319 | 76 | **13** | Narrator, Estela Toras, Player_Romus_Italic... | [Otwórz](Rizia/Turn_09/440_A_ZilleReturnedSpeech.md) |
| `441` | Tura 09 | FPnT_ZilleReferendumInterference | 309 | 15 | **2** | Narrator, Laurento Esquibel, Lucita Azaro... | [Otwórz](Rizia/Turn_09/441_FPnT_ZilleReferendumInterference.md) |
| `442` | Tura 09 | TalkWithManus | 1161 | 284 | **40** | Narrator, Manus Sazon, Titus Gordion... | [Otwórz](Rizia/Turn_09/442_TalkWithManus.md) |
| `443` | Tura 09 | Manus Vina Concerns | 32 | 5 | **1** | Manus Sazon, Player_Romus | [Otwórz](Rizia/Turn_09/443_Manus_Vina_Concerns.md) |
| `444` | Tura 09 | TalkWithTitus | 1518 | 302 | **113** | Narrator, Hugo Toras, Lucita Azaro... | [Otwórz](Rizia/Turn_09/444_TalkWithTitus.md) |
| `445` | Tura 09 | TalkWithAdarfo | 753 | 220 | **36** | Narrator, Titus Gordion, Player_Romus_Italic... | [Otwórz](Rizia/Turn_09/445_TalkWithAdarfo.md) |
| `446` | Tura 09 | A_MeetingWithSal | 441 | 86 | **23** | Narrator, Sevrio Castellanus, Sal Ignacius... | [Otwórz](Rizia/Turn_09/446_A_MeetingWithSal.md) |
| `447` | Tura 09 | Religous Meeting Notes | 122 | 25 | **13** | Sal Ignacius, Player_Romus | [Otwórz](Rizia/Turn_09/447_Religous_Meeting_Notes.md) |
| `448` | Tura 09 | FPnT_ZilleReferendum | 356 | 17 | **4** | Narrator, Laurento Esquibel, Lucita Azaro... | [Otwórz](Rizia/Turn_09/448_FPnT_ZilleReferendum.md) |
| `449` | Tura 09 | Pipeline_NatDesMeeting | 1722 | 127 | **69** | Narrator, Hugo Toras, Lucita Azaro... | [Otwórz](Rizia/Turn_09/449_Pipeline_NatDesMeeting.md) |
| `450` | Tura 09 | FPnT_MITZ_BoardMeeting | 678 | 64 | **35** | Narrator, Emmerich Hegel (R), Elena Werner... | [Otwórz](Rizia/Turn_09/450_FPnT_MITZ_BoardMeeting.md) |
| `451` | Tura 09 | Hegel Side Convo | 268 | 50 | **18** | Narrator, Emmerich Hegel (R), Player_Romus | [Otwórz](Rizia/Turn_09/451_Hegel_Side_Convo.md) |
| `452` | Tura 09 | NOTES_Old Intermerkopum Checks | 63 | 0 | **0** |  | [Otwórz](Rizia/Turn_09/452_NOTES_Old_Intermerkopum_Checks.md) |
| `330` | Tura 10 | War_Pales_Loss | 417 | 29 | **11** | Narrator, Lucita Azaro, Taddeus Azaro... | [Otwórz](Rizia/Turn_10/330_War_Pales_Loss.md) |
| `331` | Tura 10 | AxelVina_Unity | 620 | 129 | **18** | Narrator, Player_Romus_Italic, Axel Reinhart... | [Otwórz](Rizia/Turn_10/331_AxelVina_Unity.md) |
| `332` | Tura 10 | VinaFuneral | 141 | 33 | **1** | Narrator, Estela Toras, Hugo Toras... | [Otwórz](Rizia/Turn_10/332_VinaFuneral.md) |
| `333` | Tura 10 | War_Pales_VictoryParade | 376 | 47 | **6** | Narrator, Manus Sazon, Daria de Rava... | [Otwórz](Rizia/Turn_10/333_War_Pales_VictoryParade.md) |
| `334` | Tura 10 | ExecutionDecisions | 18 | 3 | **0** | Narrator, Player_Romus_Italic | [Otwórz](Rizia/Turn_10/334_ExecutionDecisions.md) |
| `335` | Tura 10 | VinaRescueOutcome | 211 | 29 | **12** | Narrator, Hugo Toras, Lucita Azaro... | [Otwórz](Rizia/Turn_10/335_VinaRescueOutcome.md) |
| `336` | Tura 10 | A_HearingOfPetitions | 504 | 42 | **33** | Narrator, Vina Toras, Titus Gordion... | [Otwórz](Rizia/Turn_10/336_A_HearingOfPetitions.md) |
| `337` | Tura 10 | Executions | 423 | 68 | **22** | Narrator, Hugo Toras, Lucita Azaro... | [Otwórz](Rizia/Turn_10/337_Executions.md) |
| `338` | Tura 10 | CouncilMeeting | 562 | 57 | **22** | Narrator, Hugo Toras, Laurento Esquibel... | [Otwórz](Rizia/Turn_10/338_CouncilMeeting.md) |
| `339` | Tura 10 | NATIONAL DESTABILIZATION | 717 | 56 | **28** | Narrator, Hugo Toras, Laurento Esquibel... | [Otwórz](Rizia/Turn_10/339_NATIONAL_DESTABILIZATION.md) |
| `340` | Tura 10 | NATDES AFTERMATH | 337 | 42 | **24** | Narrator, Hugo Toras, Laurento Esquibel... | [Otwórz](Rizia/Turn_10/340_NATDES_AFTERMATH.md) |
| `341` | Tura 10 | COUNCILOR RESIGNATION CHECKS | 32 | 0 | **0** |  | [Otwórz](Rizia/Turn_10/341_COUNCILOR_RESIGNATION_CHECKS.md) |
| `342` | Tura 10 | RESIGNATIONS | 310 | 22 | **17** | Narrator, Hugo Toras, Lucita Azaro... | [Otwórz](Rizia/Turn_10/342_RESIGNATIONS.md) |
| `343` | Tura 10 | BDAY FALLOUT | 230 | 38 | **10** | Narrator, Laurento Esquibel, Elena Werner... | [Otwórz](Rizia/Turn_10/343_BDAY_FALLOUT.md) |
| `344` | Tura 10 | Security_LucitaOrTitus | 1448 | 205 | **93** | Narrator, Lucita Azaro, Titus Gordion... | [Otwórz](Rizia/Turn_10/344_Security_LucitaOrTitus.md) |
| `345` | Tura 10 | HODShutdown | 1190 | 382 | **102** | Narrator, Hugo Toras, Lucita Azaro... | [Otwórz](Rizia/Turn_10/345_HODShutdown.md) |
| `346` | Tura 10 | RelationshipAnnouncement | 606 | 114 | **41** | Narrator, Estela Toras, Lucita Azaro... | [Otwórz](Rizia/Turn_10/346_RelationshipAnnouncement.md) |
| `347` | Tura 10 | Reform_ConstitutionSigning | 484 | 72 | **8** | Narrator, Titus Gordion, Player_Romus_Italic... | [Otwórz](Rizia/Turn_10/347_Reform_ConstitutionSigning.md) |
| `348` | Tura 10 | TalkWithPrimeMinister | 834 | 92 | **19** | Narrator, Manus Sazon, Daria de Rava... | [Otwórz](Rizia/Turn_10/348_TalkWithPrimeMinister.md) |
| `349` | Tura 10 | SuccessionAnnouncement | 784 | 151 | **70** | Narrator, Lucita Azaro, Vina Toras... | [Otwórz](Rizia/Turn_10/349_SuccessionAnnouncement.md) |
| `350` | Tura 10 | Birthday_Gathering | 256 | 18 | **7** | Narrator, Estela Toras, Lucita Azaro... | [Otwórz](Rizia/Turn_10/350_Birthday_Gathering.md) |
| `351` | Tura 10 | DEFAULT HOUSE AZARO CONVO | 837 | 136 | **54** | Narrator, Lucita Azaro, Taddeus Azaro... | [Otwórz](Rizia/Turn_10/351_DEFAULT_HOUSE_AZARO_CONVO.md) |
| `352` | Tura 10 | DEFAULT HOUSE TORAS CONVO | 1080 | 132 | **64** | Narrator, Hubertus Toras, Hugo Toras... | [Otwórz](Rizia/Turn_10/352_DEFAULT_HOUSE_TORAS_CONVO.md) |
| `353` | Tura 10 | DEFAULT HOUSE SAZON CONVO | 1454 | 212 | **95** | Narrator, Leona Sazon, Manus Sazon... | [Otwórz](Rizia/Turn_10/353_DEFAULT_HOUSE_SAZON_CONVO.md) |
| `354` | Tura 10 | War_Pales_PeaceTreaty | 1150 | 92 | **17** | Narrator, Laurento Esquibel, Manus Sazon... | [Otwórz](Rizia/Turn_10/354_War_Pales_PeaceTreaty.md) |
| `355` | Tura 10 | NewGovernment_Default | 321 | 18 | **2** | Narrator, Hugo Toras, Lucita Azaro... | [Otwórz](Rizia/Turn_10/355_NewGovernment_Default.md) |
| `543` | Tura 10 | Murder Notes Conversation | 80 | 16 | **1** | Narrator, Titus Gordion, Player_Romus | [Otwórz](Rizia/Turn_10/543_Murder_Notes_Conversation.md) |
| `544` | Tura 10 | HOD Shutdown Notes Conversation | 82 | 52 | **4** | Narrator, Player_Romus_Italic, Player_Romus | [Otwórz](Rizia/Turn_10/544_HOD_Shutdown_Notes_Conversation.md) |
| `545` | Tura 10 | DECLARATION Conversation | 260 | 82 | **13** | Narrator, Manus Sazon, Daria de Rava... | [Otwórz](Rizia/Turn_10/545_DECLARATION_Conversation.md) |
| `546` | Tura 10 | Pales_Reform_Branch Conversation | 385 | 21 | **2** | Narrator, Manus Sazon, Daria de Rava... | [Otwórz](Rizia/Turn_10/546_Pales_Reform_Branch_Conversation.md) |
| `547` | Tura 10 | Zille_Reform_Branch Conversation | 179 | 2 | **2** | Manus Sazon, Daria de Rava, Player_Romus... | [Otwórz](Rizia/Turn_10/547_Zille_Reform_Branch_Conversation.md) |
| `548` | Tura 10 | Upper_House_Branch Conversation | 86 | 0 | **0** | Manus Sazon, Daria de Rava, Adarfo Sotelato | [Otwórz](Rizia/Turn_10/548_Upper_House_Branch_Conversation.md) |
| `549` | Tura 10 | Notes Conversation | 590 | 27 | **0** | Narrator, Manus Sazon, Daria de Rava... | [Otwórz](Rizia/Turn_10/549_Notes_Conversation.md) |
| `550` | Tura 10 | Election_Issues Conversation | 287 | 21 | **6** | Narrator, Manus Sazon, Daria de Rava... | [Otwórz](Rizia/Turn_10/550_Election_Issues_Conversation.md) |
| `551` | Tura 10 | REFORM TALKS Conversation | 1781 | 228 | **82** | Narrator, Hubertus Toras, Hugo Toras... | [Otwórz](Rizia/Turn_10/551_REFORM_TALKS_Conversation.md) |
| `552` | Tura 10 | REFORMCHECK Conversation | 131 | 0 | **0** |  | [Otwórz](Rizia/Turn_10/552_REFORMCHECK_Conversation.md) |
| `553` | Tura 10 | REFORMCHECK2ND Conversation | 131 | 0 | **0** |  | [Otwórz](Rizia/Turn_10/553_REFORMCHECK2ND_Conversation.md) |
| `554` | Tura 10 | DEFAULT GATHERING SCENE Conversation | 534 | 85 | **20** | Narrator, Estela Toras, Manus Sazon... | [Otwórz](Rizia/Turn_10/554_DEFAULT_GATHERING_SCENE_Conversation.md) |
| `555` | Tura 10 | STRIKE SCENE Conversation | 196 | 38 | **7** | Narrator, Estela Toras, Leona Sazon... | [Otwórz](Rizia/Turn_10/555_STRIKE_SCENE_Conversation.md) |
| `556` | Tura 10 | INTRO_NONREFORM Conversation | 338 | 75 | **13** | Narrator, Estela Toras, Hubertus Toras... | [Otwórz](Rizia/Turn_10/556_INTRO_NONREFORM_Conversation.md) |
| `557` | Tura 10 | INTRO_REFORM Conversation | 255 | 43 | **4** | Narrator, Hubertus Toras, Hugo Toras... | [Otwórz](Rizia/Turn_10/557_INTRO_REFORM_Conversation.md) |
| `558` | Tura 10 | ABOLISHMENT Conversation | 129 | 28 | **1** | Narrator, Hugo Toras, Leona Sazon... | [Otwórz](Rizia/Turn_10/558_ABOLISHMENT_Conversation.md) |
| `559` | Tura 10 | ABSOLUTIST STRIKE SCENE Conversation | 645 | 53 | **24** | Narrator, Hubertus Toras, Hugo Toras... | [Otwórz](Rizia/Turn_10/559_ABSOLUTIST_STRIKE_SCENE_Conversation.md) |
| `560` | Tura 10 | House Azaro Strike Conversation | 452 | 83 | **21** | Narrator, Hugo Toras, Lucita Azaro... | [Otwórz](Rizia/Turn_10/560_House_Azaro_Strike_Conversation.md) |
| `561` | Tura 10 | House Sazon Strike Conversation | 411 | 70 | **14** | Narrator, Hugo Toras, Leona Sazon... | [Otwórz](Rizia/Turn_10/561_House_Sazon_Strike_Conversation.md) |
| `562` | Tura 10 | House Toras Strike Conversation | 361 | 74 | **12** | Narrator, Hubertus Toras, Hugo Toras... | [Otwórz](Rizia/Turn_10/562_House_Toras_Strike_Conversation.md) |
| `563` | Tura 10 | PRE-STRIKE ABSOLUTIST KING SPEECH Conversation | 294 | 66 | **14** | Narrator, Hubertus Toras, Hugo Toras... | [Otwórz](Rizia/Turn_10/563_PRE-STRIKE_ABSOLUTIST_KING_SPEECH_Conversation.md) |
| `564` | Tura 10 | RustyReformSuccess Conversation | 589 | 100 | **41** | Narrator, Hubertus Toras, Hugo Toras... | [Otwórz](Rizia/Turn_10/564_RustyReformSuccess_Conversation.md) |
| `565` | Tura 10 | REVOLUTIONARIES SUCCESS BRANCH Conversation | 402 | 72 | **35** | Narrator, Estela Toras, Hugo Toras... | [Otwórz](Rizia/Turn_10/565_REVOLUTIONARIES_SUCCESS_BRANCH_Conversation.md) |
| `566` | Tura 10 | HOUSE STRIKE FAIL Conversation | 13 | 0 | **0** |  | [Otwórz](Rizia/Turn_10/566_HOUSE_STRIKE_FAIL_Conversation.md) |
| `567` | Tura 10 | Run Romus Run! Conversation | 680 | 104 | **50** | Narrator, Hugo Toras, Leona Sazon... | [Otwórz](Rizia/Turn_10/567_Run_Romus_Run!_Conversation.md) |
| `568` | Tura 10 | House Shootout Branch Conversation | 193 | 14 | **6** | Narrator, Hubertus Toras, Hugo Toras... | [Otwórz](Rizia/Turn_10/568_House_Shootout_Branch_Conversation.md) |
| `569` | Tura 10 | Revolution Fail Branch Conversation | 218 | 29 | **9** | Narrator, Hugo Toras, Lucita Azaro... | [Otwórz](Rizia/Turn_10/569_Revolution_Fail_Branch_Conversation.md) |
| `570` | Tura 10 | Titus Betrayal Branch Conversation | 767 | 101 | **25** | Narrator, Estela Toras, Hubertus Toras... | [Otwórz](Rizia/Turn_10/570_Titus_Betrayal_Branch_Conversation.md) |
| `571` | Tura 10 | CHARACTER SETUP Conversation | 54 | 0 | **0** |  | [Otwórz](Rizia/Turn_10/571_CHARACTER_SETUP_Conversation.md) |
| `572` | Tura 10 | STRIKE VARIABLES SETUP Conversation | 109 | 0 | **0** |  | [Otwórz](Rizia/Turn_10/572_STRIKE_VARIABLES_SETUP_Conversation.md) |
| `573` | Tura 10 | HOUSES GATHER Conversation | 1023 | 110 | **48** | Narrator, Estela Toras, Hubertus Toras... | [Otwórz](Rizia/Turn_10/573_HOUSES_GATHER_Conversation.md) |
| `574` | Tura 10 | Notesw Conversation | 73 | 0 | **0** | Narrator, Estela Toras, Hubertus Toras... | [Otwórz](Rizia/Turn_10/574_Notesw_Conversation.md) |
| `575` | Tura 10 | Notes Conversation | 328 | 16 | **2** | Ovid Grecer, Narrator, Hugo Toras... | [Otwórz](Rizia/Turn_10/575_Notes_Conversation.md) |
| `576` | Tura 10 | Domestic Affairs Conversation | 672 | 32 | **23** | Narrator, Player_Romus_Italic, Player_Romus | [Otwórz](Rizia/Turn_10/576_Domestic_Affairs_Conversation.md) |
| `577` | Tura 10 | Foreign_Affairs Conversation | 956 | 102 | **47** | Narrator, Player_Romus_Italic, Player_Romus | [Otwórz](Rizia/Turn_10/577_Foreign_Affairs_Conversation.md) |
| `453` | Tura 11 | CoupWarning | 658 | 103 | **44** | Narrator, Estela Toras, Lucita Azaro... | [Otwórz](Rizia/Turn_11/453_CoupWarning.md) |
| `454` | Tura 11 | Ending_Coup_HouseFallouts | 878 | 138 | **34** | Narrator, Estela Toras, Hugo Toras... | [Otwórz](Rizia/Turn_11/454_Ending_Coup_HouseFallouts.md) |
| `455` | Tura 11 | Ending_Revolution | 1287 | 178 | **37** | Narrator, Lucita Azaro, Titus Gordion... | [Otwórz](Rizia/Turn_11/455_Ending_Revolution.md) |
| `456` | Tura 11 | Ending_Speech | 1061 | 377 | **216** | Narrator, Player_Romus_Italic, Player_Romus... | [Otwórz](Rizia/Turn_11/456_Ending_Speech.md) |
| `457` | Tura 11 | A_TheocracyDeclaration | 435 | 145 | **51** | Narrator, Estela Toras, Titus Gordion... | [Otwórz](Rizia/Turn_11/457_A_TheocracyDeclaration.md) |
| `458` | Tura 11 | Original Theocracy Declaration Notes | 5 | 0 | **0** | Narrator | [Otwórz](Rizia/Turn_11/458_Original_Theocracy_Declaration_Notes.md) |
| `598` | Tura 11 | FORCEDABDICATION Conversation | 250 | 93 | **33** | Narrator, Player_Romus, Adarfo Sotelato | [Otwórz](Rizia/Turn_11/598_FORCEDABDICATION_Conversation.md) |
| `599` | Tura 11 | Notes_End_Speech Conversation | 15 | 5 | **0** | Player_Romus | [Otwórz](Rizia/Turn_11/599_Notes_End_Speech_Conversation.md) |
| `9988` | Operacja Wojenna Zille (Mod) | WarCouncil_Briefing *(MOD)* | 28 | 12 | **4** | Narrator, Player_Romus, Hugo Toras... | [Otwórz](Rizia/War_Operation/9988_WarCouncil_Briefing.md) |

---

## Sordland (Kampania Główna) — Pełna Lista Rozmów (292)

| ID | Tura / Sekcja | Tytuł Sceny | Węzły | Wybory | W tym Warunkowe | Główni Uczestnicy | Plik |
|---|---|---|---|---|---|---|---|
| `257` | Epilogue (Epilogue) | Epilogue | 37 | 0 | **0** |  | [Otwórz](Sordland/Epilogue/257_Epilogue.md) |
| `258` | Epilogue (Epilogue_ElectionDeath) | Epilogue_ElectionDeath | 23 | 4 | **0** | Player, Narrator | [Otwórz](Sordland/Epilogue/258_Epilogue_ElectionDeath.md) |
| `259` | Epilogue (Epilogue_ElectionWin) | Epilogue_ElectionWin | 599 | 152 | **29** | Player, Narrator | [Otwórz](Sordland/Epilogue/259_Epilogue_ElectionWin.md) |
| `260` | Epilogue (Epilogue_Exile) | Epilogue_Exile | 183 | 46 | **27** | Player, Narrator | [Otwórz](Sordland/Epilogue/260_Epilogue_Exile.md) |
| `261` | Epilogue (Epilogue_WorldWar) | Epilogue_WorldWar | 17 | 5 | **0** | Player, Narrator | [Otwórz](Sordland/Epilogue/261_Epilogue_WorldWar.md) |
| `262` | Epilogue (Epilogue_ImpeachmentTrial) | Epilogue_ImpeachmentTrial | 120 | 59 | **14** | Player, Narrator | [Otwórz](Sordland/Epilogue/262_Epilogue_ImpeachmentTrial.md) |
| `263` | Epilogue (Epilogue_CoupTrial) | Epilogue_CoupTrial | 135 | 66 | **9** | Player, Narrator | [Otwórz](Sordland/Epilogue/263_Epilogue_CoupTrial.md) |
| `264` | Epilogue (Epilogue_Retirement) | Epilogue_Retirement | 58 | 13 | **0** | Player, Narrator | [Otwórz](Sordland/Epilogue/264_Epilogue_Retirement.md) |
| `265` | Epilogue (HOLSORD ENDING) | HOLSORD ENDING | 125 | 48 | **11** | Player, Narrator | [Otwórz](Sordland/Epilogue/265_HOLSORD_ENDING.md) |
| `266` | Epilogue (ANRICA ENDING) | ANRICA ENDING | 103 | 43 | **15** | Player, Narrator | [Otwórz](Sordland/Epilogue/266_ANRICA_ENDING.md) |
| `267` | Epilogue (BENFI ENDING) | BENFI ENDING | 132 | 48 | **11** | Player, Narrator | [Otwórz](Sordland/Epilogue/267_BENFI_ENDING.md) |
| `268` | Epilogue (ERLORY ENDING) | ERLORY ENDING | 104 | 37 | **16** | Player, Narrator | [Otwórz](Sordland/Epilogue/268_ERLORY_ENDING.md) |
| `269` | Epilogue (ARCASIA OR UC ENDING) | ARCASIA OR UC ENDING | 139 | 51 | **23** | Player, Narrator | [Otwórz](Sordland/Epilogue/269_ARCASIA_OR_UC_ENDING.md) |
| `270` | Epilogue (Epilogue_RumburgWarLost) | Epilogue_RumburgWarLost | 90 | 34 | **0** | Player, Narrator | [Otwórz](Sordland/Epilogue/270_Epilogue_RumburgWarLost.md) |
| `271` | Epilogue (Epilogue_ElectionLose) | Epilogue_ElectionLose | 573 | 188 | **38** | Player, Narrator | [Otwórz](Sordland/Epilogue/271_Epilogue_ElectionLose.md) |
| `272` | Epilogue (ANRICA ELECTION ENDING) | ANRICA ELECTION ENDING | 145 | 44 | **3** | Player, Narrator | [Otwórz](Sordland/Epilogue/272_ANRICA_ELECTION_ENDING.md) |
| `273` | Epilogue (ARCASIA OR UC ELECTION ENDING) | ARCASIA OR UC ELECTION ENDING | 152 | 51 | **23** | Player, Narrator | [Otwórz](Sordland/Epilogue/273_ARCASIA_OR_UC_ELECTION_ENDING.md) |
| `274` | Epilogue (ERLORY ELECTION ENDING) | ERLORY ELECTION ENDING | 139 | 38 | **10** | Player, Narrator | [Otwórz](Sordland/Epilogue/274_ERLORY_ELECTION_ENDING.md) |
| `275` | Epilogue (BENFI ELECTION ENDING) | BENFI ELECTION ENDING | 186 | 62 | **17** | Player, Narrator | [Otwórz](Sordland/Epilogue/275_BENFI_ELECTION_ENDING.md) |
| `276` | Epilogue (Legacy - Summary) | Legacy - Summary | 315 | 0 | **0** | Narrator | [Otwórz](Sordland/Epilogue/276_Legacy_-_Summary.md) |
| `542` | Epilogue (Summary Draft WIP) | Summary Draft WIP Conversation | 364 | 0 | **0** | Narrator | [Otwórz](Sordland/Epilogue/542_Summary_Draft_WIP_Conversation.md) |
| `277` | Prologue | Prologue | 297 | 137 | **13** | Player, Narrator | [Otwórz](Sordland/Prologue/277_Prologue.md) |
| `1` | Tura 01 | EnT_EconomicOverview | 352 | 65 | **19** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_01/001_EnT_EconomicOverview.md) |
| `2` | Tura 01 | SnO_MPShot | 96 | 18 | **4** | Petr Vectern, Player, Nia Morgna... | [Otwórz](Sordland/Turn_01/002_SnO_MPShot.md) |
| `3` | Tura 01 | A_Media | 166 | 38 | **2** | Petr Vectern, Player, Narrator... | [Otwórz](Sordland/Turn_01/003_A_Media.md) |
| `4` | Tura 01 | A_PoliticalOverview | 294 | 85 | **1** | Petr Vectern, Player, Narrator... | [Otwórz](Sordland/Turn_01/004_A_PoliticalOverview.md) |
| `5` | Tura 01 | Petr Opens Whisky | 24 | 10 | **0** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_01/005_Petr_Opens_Whisky.md) |
| `6` | Tura 01 | Start_Inauguration | 134 | 39 | **3** | Player, Player_Italic, Orso Hawker... | [Otwórz](Sordland/Turn_01/006_Start_Inauguration.md) |
| `7` | Tura 01 | Trailer_Intro | 8 | 2 | **0** | Player, Narrator, Symon Holl | [Otwórz](Sordland/Turn_01/007_Trailer_Intro.md) |
| `8` | Tura 01 | InT_Infrastructure | 144 | 33 | **3** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_01/008_InT_Infrastructure.md) |
| `9` | Tura 01 | Personal_Ball | 241 | 78 | **4** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_01/009_Personal_Ball.md) |
| `10` | Tura 01 | Ball Prep and Travel | 110 | 39 | **0** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_01/010_Ball_Prep_and_Travel.md) |
| `11` | Tura 01 | Shooting | 87 | 24 | **0** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_01/011_Shooting.md) |
| `12` | Tura 02 | SnO_SecurityOverview | 269 | 71 | **1** | Player, Player_Italic, Nia Morgna... | [Otwórz](Sordland/Turn_02/012_SnO_SecurityOverview.md) |
| `13` | Tura 02 | A_MediaDeal | 175 | 61 | **2** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_02/013_A_MediaDeal.md) |
| `14` | Tura 02 | A_ReformBriefing | 150 | 24 | **0** | Petr Vectern, Player, Nia Morgna... | [Otwórz](Sordland/Turn_02/014_A_ReformBriefing.md) |
| `15` | Tura 02 | DictatorSection | 151 | 42 | **4** | Petr Vectern, Player, Nia Morgna... | [Otwórz](Sordland/Turn_02/015_DictatorSection.md) |
| `16` | Tura 02 | AutocratSection | 68 | 23 | **0** | Petr Vectern, Player, Nia Morgna... | [Otwórz](Sordland/Turn_02/016_AutocratSection.md) |
| `17` | Tura 02 | ReformistSection | 113 | 26 | **4** | Petr Vectern, Player, Nia Morgna... | [Otwórz](Sordland/Turn_02/017_ReformistSection.md) |
| `18` | Tura 02 | A_AutocratBriefing | 646 | 209 | **10** | Player, Player_Italic, Orso Hawker... | [Otwórz](Sordland/Turn_02/018_A_AutocratBriefing.md) |
| `19` | Tura 02 | Personal_Funeral | 156 | 36 | **0** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_02/019_Personal_Funeral.md) |
| `20` | Tura 02 | A_ContractBribe | 269 | 65 | **1** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_02/020_A_ContractBribe.md) |
| `21` | Tura 02 | Personal_FamilyDinner | 220 | 61 | **5** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_02/021_Personal_FamilyDinner.md) |
| `22` | Tura 02 | FPnT_DiplomacyOverview | 520 | 85 | **16** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_02/022_FPnT_DiplomacyOverview.md) |
| `23` | Tura 02 | Neighbor Overview Hubs | 158 | 33 | **6** | Player, Narrator, Deivid Wisci... | [Otwórz](Sordland/Turn_02/023_Neighbor_Overview_Hubs.md) |
| `24` | Tura 02 | InT_HighwayContract | 215 | 38 | **7** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_02/024_InT_HighwayContract.md) |
| `25` | Tura 02 | InT_RailwayContract | 221 | 41 | **5** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_02/025_InT_RailwayContract.md) |
| `26` | Tura 03 | EnT_Budget | 212 | 44 | **20** | Paskal Beniwoll, Player, Player_Italic... | [Otwórz](Sordland/Turn_03/026_EnT_Budget.md) |
| `27` | Tura 03 | Budget Feedback | 440 | 24 | **12** | Paskal Beniwoll, Player, Nia Morgna... | [Otwórz](Sordland/Turn_03/027_Budget_Feedback.md) |
| `28` | Tura 03 | PSnW_Overview | 345 | 78 | **21** | Paskal Beniwoll, Player, Narrator... | [Otwórz](Sordland/Turn_03/028_PSnW_Overview.md) |
| `29` | Tura 03 | A_ReformistConstitution | 163 | 56 | **0** | Petr Vectern, Player, Nia Morgna... | [Otwórz](Sordland/Turn_03/029_A_ReformistConstitution.md) |
| `30` | Tura 03 | Reformist Post Discussion | 135 | 21 | **0** | Petr Vectern, Player, Nia Morgna... | [Otwórz](Sordland/Turn_03/030_Reformist_Post_Discussion.md) |
| `31` | Tura 03 | A_DictatorConstitution | 157 | 52 | **0** | Petr Vectern, Player, Narrator... | [Otwórz](Sordland/Turn_03/031_A_DictatorConstitution.md) |
| `32` | Tura 03 | Dictator Post Discussion | 83 | 12 | **0** | Petr Vectern, Player, Narrator... | [Otwórz](Sordland/Turn_03/032_Dictator_Post_Discussion.md) |
| `33` | Tura 03 | A_AutocratDecree | 43 | 11 | **0** | Player, Orso Hawker, Narrator... | [Otwórz](Sordland/Turn_03/033_A_AutocratDecree.md) |
| `34` | Tura 03 | Autocrat Post Discussion | 115 | 12 | **0** | Player, Orso Hawker, Narrator... | [Otwórz](Sordland/Turn_03/034_Autocrat_Post_Discussion.md) |
| `35` | Tura 03 | A_LateBriefing | 71 | 13 | **3** | Petr Vectern, Player, Narrator... | [Otwórz](Sordland/Turn_03/035_A_LateBriefing.md) |
| `36` | Tura 03 | LateDictatorSection | 198 | 62 | **4** | Petr Vectern, Player, Narrator... | [Otwórz](Sordland/Turn_03/036_LateDictatorSection.md) |
| `37` | Tura 03 | LateReformistSection | 190 | 60 | **4** | Petr Vectern, Player, Narrator... | [Otwórz](Sordland/Turn_03/037_LateReformistSection.md) |
| `38` | Tura 03 | Personal_FrancTalk | 402 | 99 | **26** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_03/038_Personal_FrancTalk.md) |
| `39` | Tura 03 | A_AutocratSpeech | 351 | 41 | **16** | Player, Narrator, Mansoun Leke... | [Otwórz](Sordland/Turn_03/039_A_AutocratSpeech.md) |
| `40` | Tura 03 | EnT_BusinessCouncil | 695 | 179 | **4** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_03/040_EnT_BusinessCouncil.md) |
| `41` | Tura 03 | EnT_GasomProposal | 353 | 57 | **3** | Player, Narrator, Ewald Alphonso... | [Otwórz](Sordland/Turn_03/041_EnT_GasomProposal.md) |
| `42` | Tura 03 | Gus Intro Talk | 252 | 67 | **10** | Player, Narrator, Gus Manger | [Otwórz](Sordland/Turn_03/042_Gus_Intro_Talk.md) |
| `43` | Tura 03 | Ewald Alphonso Debate | 424 | 101 | **6** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_03/043_Ewald_Alphonso_Debate.md) |
| `44` | Tura 03 | A_EnergyProtectionAct | 577 | 115 | **9** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_03/044_A_EnergyProtectionAct.md) |
| `45` | Tura 03 | A_AddressProtestors | 484 | 115 | **42** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_03/045_A_AddressProtestors.md) |
| `46` | Tura 03 | Personal_HelicopterEscape | 395 | 92 | **2** | Player, Narrator, Ewald Alphonso... | [Otwórz](Sordland/Turn_03/046_Personal_HelicopterEscape.md) |
| `47` | Tura 03 | Mid Conversation | 224 | 62 | **12** | Player, Narrator, Ewald Alphonso... | [Otwórz](Sordland/Turn_03/047_Mid_Conversation.md) |
| `48` | Tura 03 | Personal_DriverTalk | 217 | 58 | **3** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_03/048_Personal_DriverTalk.md) |
| `49` | Tura 04 | InT_SSCRailwayIssue | 95 | 16 | **0** | Player, Narrator, Gus Manger... | [Otwórz](Sordland/Turn_04/049_InT_SSCRailwayIssue.md) |
| `50` | Tura 04 | InT_SSCHighwayIssue | 96 | 16 | **0** | Player, Narrator, Lileas Graf... | [Otwórz](Sordland/Turn_04/050_InT_SSCHighwayIssue.md) |
| `51` | Tura 04 | Personal_Jogging | 441 | 77 | **3** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_04/051_Personal_Jogging.md) |
| `52` | Tura 04 | EnT_TaxReform | 501 | 44 | **10** | Player, Narrator, Mikail Aven... | [Otwórz](Sordland/Turn_04/052_EnT_TaxReform.md) |
| `53` | Tura 04 | SnO_LawEnforcementBudget | 530 | 70 | **10** | Player, Player_Italic, Nia Morgna... | [Otwórz](Sordland/Turn_04/053_SnO_LawEnforcementBudget.md) |
| `54` | Tura 04 | A_ConvinceAlbin | 727 | 146 | **26** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_04/054_A_ConvinceAlbin.md) |
| `55` | Tura 04 | InT_TaurusRailwayIssue | 136 | 23 | **0** | Player, Narrator, Gus Manger... | [Otwórz](Sordland/Turn_04/055_InT_TaurusRailwayIssue.md) |
| `56` | Tura 04 | InT_TaurusHighwayIssue | 123 | 23 | **0** | Player, Narrator, Lileas Graf... | [Otwórz](Sordland/Turn_04/056_InT_TaurusHighwayIssue.md) |
| `57` | Tura 04 | PSnW_EducationReform | 289 | 20 | **3** | Player, Narrator, Lucian Galade... | [Otwórz](Sordland/Turn_04/057_PSnW_EducationReform.md) |
| `58` | Tura 04 | A_ConvinceGloria | 561 | 118 | **8** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_04/058_A_ConvinceGloria.md) |
| `59` | Tura 04 | TBD_EnT_RuralDevelopment | 2 | 0 | **0** |  | [Otwórz](Sordland/Turn_04/059_TBD_EnT_RuralDevelopment.md) |
| `60` | Tura 04 | PSnW_SchoolVisit | 183 | 32 | **0** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_04/060_PSnW_SchoolVisit.md) |
| `61` | Tura 04 | Personal_LucianChessMatch | 339 | 125 | **0** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_04/061_Personal_LucianChessMatch.md) |
| `62` | Tura 05 | SnO_MilitaryBudget | 525 | 64 | **21** | Petr Vectern, Player, Narrator... | [Otwórz](Sordland/Turn_05/062_SnO_MilitaryBudget.md) |
| `63` | Tura 05 | SnO_FoundedPolice | 398 | 90 | **15** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_05/063_SnO_FoundedPolice.md) |
| `64` | Tura 05 | FPnT_ImmigrationPolicy | 305 | 35 | **7** | Player, Narrator, Deivid Wisci... | [Otwórz](Sordland/Turn_05/064_FPnT_ImmigrationPolicy.md) |
| `65` | Tura 05 | Personal_MonicaTalk | 410 | 50 | **16** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_05/065_Personal_MonicaTalk.md) |
| `66` | Tura 05 | Personal_PetrParty | 426 | 84 | **11** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_05/066_Personal_PetrParty.md) |
| `67` | Tura 05 | NOTES | 37 | 0 | **0** | Ewald Alphonso | [Otwórz](Sordland/Turn_05/067_NOTES.md) |
| `68` | Tura 05 | A_DamageControl | 207 | 51 | **2** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_05/068_A_DamageControl.md) |
| `69` | Tura 05 | NOTES | 73 | 17 | **0** | Petr Vectern, Player, Narrator... | [Otwórz](Sordland/Turn_05/069_NOTES.md) |
| `70` | Tura 05 | FPnT_WehlenTradeVisit | 335 | 56 | **4** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_05/070_FPnT_WehlenTradeVisit.md) |
| `71` | Tura 05 | A_DictatorSpeech | 274 | 84 | **9** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_05/071_A_DictatorSpeech.md) |
| `72` | Tura 05 | A_ReformistSpeech | 266 | 82 | **7** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_05/072_A_ReformistSpeech.md) |
| `73` | Tura 05 | A_AutocratAssembly | 167 | 33 | **0** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_05/073_A_AutocratAssembly.md) |
| `74` | Tura 05 | Personal_ReturnOfInvestment | 169 | 29 | **3** | Player, Narrator, Gus Manger | [Otwórz](Sordland/Turn_05/074_Personal_ReturnOfInvestment.md) |
| `75` | Tura 05 | TBD_InT_ValgenDam | 2 | 0 | **0** |  | [Otwórz](Sordland/Turn_05/075_TBD_InT_ValgenDam.md) |
| `76` | Tura 05 | Personal_FestivalOpening | 423 | 81 | **1** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_05/076_Personal_FestivalOpening.md) |
| `77` | Tura 05 | FPnT_AgnoliaTradeVisit | 400 | 90 | **0** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_05/077_FPnT_AgnoliaTradeVisit.md) |
| `78` | Tura 06 | EnT_Overview | 553 | 72 | **8** | Player, Narrator, Mikail Aven... | [Otwórz](Sordland/Turn_06/078_EnT_Overview.md) |
| `79` | Tura 06 | InT_RailwayOpening | 168 | 36 | **2** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_06/079_InT_RailwayOpening.md) |
| `80` | Tura 06 | InT_HighwayOpening | 187 | 36 | **2** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_06/080_InT_HighwayOpening.md) |
| `81` | Tura 06 | A_ReformistConvincePFJP | 488 | 118 | **4** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_06/081_A_ReformistConvincePFJP.md) |
| `82` | Tura 06 | A_DictatorConvinceNFP | 461 | 91 | **3** | Player, Narrator, Kesaro Kibener | [Otwórz](Sordland/Turn_06/082_A_DictatorConvinceNFP.md) |
| `83` | Tura 06 | A_AutocratDemands | 372 | 78 | **5** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_06/083_A_AutocratDemands.md) |
| `84` | Tura 06 | SnO_ConscriptionAndMilitaryPolicy | 416 | 70 | **12** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_06/084_SnO_ConscriptionAndMilitaryPolicy.md) |
| `85` | Tura 06 | InT_2ndCompanyChoice | 213 | 33 | **7** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_06/085_InT_2ndCompanyChoice.md) |
| `86` | Tura 06 | PSnW_EducationSpending | 376 | 35 | **14** | Player, Narrator, Ciara Walda | [Otwórz](Sordland/Turn_06/086_PSnW_EducationSpending.md) |
| `87` | Tura 06 | PSnW_Curriculum | 431 | 33 | **0** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_06/087_PSnW_Curriculum.md) |
| `88` | Tura 06 | Personal_ReturnOfInvestment2 | 91 | 16 | **0** | Player, Narrator, Gus Manger... | [Otwórz](Sordland/Turn_06/088_Personal_ReturnOfInvestment2.md) |
| `89` | Tura 06 | PSnW_HealthBudget | 289 | 36 | **12** | Paskal Beniwoll, Player, Player_Italic... | [Otwórz](Sordland/Turn_06/089_PSnW_HealthBudget.md) |
| `90` | Tura 06 | A_VictoryDayBludishMeeting | 293 | 6 | **0** | Petr Vectern, Player, Narrator... | [Otwórz](Sordland/Turn_06/090_A_VictoryDayBludishMeeting.md) |
| `91` | Tura 06 | SnO_BergiaMeeting | 663 | 106 | **25** | Player, Nia Morgna, Narrator... | [Otwórz](Sordland/Turn_06/091_SnO_BergiaMeeting.md) |
| `537` | Tura 06 | VictoryDay_AutocratPath Conversation | 610 | 119 | **9** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_06/537_VictoryDay_AutocratPath_Conversation.md) |
| `538` | Tura 06 | VictoryDay_NonAutocratPath Conversation | 586 | 112 | **33** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_06/538_VictoryDay_NonAutocratPath_Conversation.md) |
| `92` | Tura 07 | A_DayofDescension | 333 | 61 | **20** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_07/092_A_DayofDescension.md) |
| `93` | Tura 07 | FPnT_DiplomacyOverview2AndTradeDeal | 362 | 38 | **10** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_07/093_FPnT_DiplomacyOverview2AndTradeDeal.md) |
| `94` | Tura 07 | A_AssemblyVote_ResultsMeeting | 54 | 7 | **0** | Petr Vectern, Player, Narrator... | [Otwórz](Sordland/Turn_07/094_A_AssemblyVote_ResultsMeeting.md) |
| `95` | Tura 07 | VoteLost | 106 | 30 | **0** | Petr Vectern, Player, Narrator... | [Otwórz](Sordland/Turn_07/095_VoteLost.md) |
| `96` | Tura 07 | VoteWon | 186 | 51 | **0** | Petr Vectern, Player, Narrator... | [Otwórz](Sordland/Turn_07/096_VoteWon.md) |
| `97` | Tura 07 | Kesaro&FrensDialogue | 179 | 37 | **0** | Petr Vectern, Player, Narrator... | [Otwórz](Sordland/Turn_07/097_Kesaro&FrensDialogue.md) |
| `98` | Tura 07 | Personal_UniversityChoice | 371 | 73 | **26** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_07/098_Personal_UniversityChoice.md) |
| `99` | Tura 07 | EnT_NationalizationAndPrivatization | 280 | 45 | **20** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_07/099_EnT_NationalizationAndPrivatization.md) |
| `100` | Tura 07 | Privatization and Nationalization Feedback | 299 | 32 | **1** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_07/100_Privatization_and_Nationalization_Feedback.md) |
| `101` | Tura 07 | A_AddressToTheNation | 579 | 219 | **121** | Player, Narrator, Lucian Galade | [Otwórz](Sordland/Turn_07/101_A_AddressToTheNation.md) |
| `102` | Tura 07 | A_MarcelCalls | 362 | 52 | **0** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_07/102_A_MarcelCalls.md) |
| `103` | Tura 07 | A_EconomicDirection | 508 | 84 | **9** | Player, Narrator, Lucian Galade | [Otwórz](Sordland/Turn_07/103_A_EconomicDirection.md) |
| `104` | Tura 07 | A_ConvinceHeron | 235 | 54 | **8** | Player, Narrator, Heron Garaci | [Otwórz](Sordland/Turn_07/104_A_ConvinceHeron.md) |
| `105` | Tura 07 | NOTES | 22 | 8 | **2** | Player, Heron Garaci | [Otwórz](Sordland/Turn_07/105_NOTES.md) |
| `106` | Tura 07 | Personal_TheatreVisit | 731 | 143 | **23** | Player, Player_Italic, Policeman... | [Otwórz](Sordland/Turn_07/106_Personal_TheatreVisit.md) |
| `107` | Tura 07 | A_ConvinceIsabel | 419 | 81 | **3** | Player, Player_Italic, Nia Morgna... | [Otwórz](Sordland/Turn_07/107_A_ConvinceIsabel.md) |
| `108` | Tura 07 | NiaDialogue01_Ally | 101 | 18 | **5** | Player, Nia Morgna, Narrator | [Otwórz](Sordland/Turn_07/108_NiaDialogue01_Ally.md) |
| `109` | Tura 07 | NiaDialogue02_Personal | 196 | 66 | **3** | Player, Player_Italic, Nia Morgna... | [Otwórz](Sordland/Turn_07/109_NiaDialogue02_Personal.md) |
| `110` | Tura 07 | WhatAreYourIntentions | 119 | 26 | **0** | Player, Narrator, Isabel Edmonds | [Otwórz](Sordland/Turn_07/110_WhatAreYourIntentions.md) |
| `111` | Tura 07 | WhatIsYourNextMove | 93 | 25 | **6** | Player, Nia Morgna, Narrator... | [Otwórz](Sordland/Turn_07/111_WhatIsYourNextMove.md) |
| `112` | Tura 07 | IsabelPersuasion | 193 | 35 | **2** | Player, Nia Morgna, Narrator... | [Otwórz](Sordland/Turn_07/112_IsabelPersuasion.md) |
| `113` | Tura 07 | IsabelIntro | 151 | 24 | **0** | Player, Nia Morgna, Narrator... | [Otwórz](Sordland/Turn_07/113_IsabelIntro.md) |
| `114` | Tura 07 | NiaDialogue01_Opposition | 107 | 25 | **5** | Player, Nia Morgna, Narrator | [Otwórz](Sordland/Turn_07/114_NiaDialogue01_Opposition.md) |
| `115` | Tura 07 | A_ResultsMeeting | 182 | 8 | **2** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_07/115_A_ResultsMeeting.md) |
| `116` | Tura 07 | CabinetMeetingPetrIntro | 291 | 19 | **0** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_07/116_CabinetMeetingPetrIntro.md) |
| `117` | Tura 07 | PlayerHub | 47 | 13 | **2** | Player, Player_Italic, Narrator | [Otwórz](Sordland/Turn_07/117_PlayerHub.md) |
| `118` | Tura 07 | AnnounceAlliance | 141 | 35 | **0** | Paskal Beniwoll, Petr Vectern, Player... | [Otwórz](Sordland/Turn_07/118_AnnounceAlliance.md) |
| `119` | Tura 07 | MinistryReports | 612 | 61 | **6** | Paskal Beniwoll, Player, Player_Italic... | [Otwórz](Sordland/Turn_07/119_MinistryReports.md) |
| `120` | Tura 07 | Gus Investment Feedback | 28 | 0 | **0** | Gus Manger | [Otwórz](Sordland/Turn_07/120_Gus_Investment_Feedback.md) |
| `121` | Tura 07 | PlansHub | 122 | 33 | **8** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_07/121_PlansHub.md) |
| `122` | Tura 07 | NOTES | 139 | 34 | **9** | Petr Vectern, Player, Nia Morgna... | [Otwórz](Sordland/Turn_07/122_NOTES.md) |
| `123` | Tura 07 | NOTES | 50 | 8 | **6** | Petr Vectern, Player, Narrator | [Otwórz](Sordland/Turn_07/123_NOTES.md) |
| `124` | Tura 07 | SecurityDecisions | 289 | 51 | **11** | Player, Narrator, Karl Greiser | [Otwórz](Sordland/Turn_07/124_SecurityDecisions.md) |
| `125` | Tura 07 | IntroWithLucian | 124 | 28 | **0** | Player, Narrator, Lucian Galade | [Otwórz](Sordland/Turn_07/125_IntroWithLucian.md) |
| `126` | Tura 07 | CallWithRemus | 62 | 18 | **3** | Player, Narrator, Remus Holstron | [Otwórz](Sordland/Turn_07/126_CallWithRemus.md) |
| `127` | Tura 07 | A_CourtVote | 409 | 53 | **1** | Paskal Beniwoll, Petr Vectern, Player... | [Otwórz](Sordland/Turn_07/127_A_CourtVote.md) |
| `128` | Tura 07 | BludishRightsMeeting | 436 | 113 | **11** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_07/128_BludishRightsMeeting.md) |
| `129` | Tura 07 | A_ConfrontationToNewProposal | 802 | 211 | **8** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_07/129_A_ConfrontationToNewProposal.md) |
| `130` | Tura 07 | A_AssemblyVote | 1033 | 144 | **8** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_07/130_A_AssemblyVote.md) |
| `131` | Tura 07 | NOTES | 92 | 0 | **0** |  | [Otwórz](Sordland/Turn_07/131_NOTES.md) |
| `132` | Tura 07 | A_OligarchsFinalMeeting | 381 | 0 | **0** | Narrator | [Otwórz](Sordland/Turn_07/132_A_OligarchsFinalMeeting.md) |
| `133` | Tura 07 | NEDAM OR SSC PRIVATISED | 227 | 25 | **5** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_07/133_NEDAM_OR_SSC_PRIVATISED.md) |
| `134` | Tura 07 | HOS AND BERGIA STEEL MINORITY OR MAJORITY NATIONALISED | 121 | 22 | **2** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_07/134_HOS_AND_BERGIA_STEEL_MINORITY_OR_MAJORITY_NATIONALISED.md) |
| `135` | Tura 07 | HOS AND BERGIA STEEL FULLY NATIONALISED | 154 | 25 | **3** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_07/135_HOS_AND_BERGIA_STEEL_FULLY_NATIONALISED.md) |
| `136` | Tura 07 | BERGIA STEEL NOT NATIONALISED AT ALL | 158 | 21 | **7** | Player, Narrator, Marcel Koronti... | [Otwórz](Sordland/Turn_07/136_BERGIA_STEEL_NOT_NATIONALISED_AT_ALL.md) |
| `137` | Tura 07 | HOS NOT NATIONALISED AT ALL | 144 | 17 | **4** | Player, Narrator, Marcel Koronti... | [Otwórz](Sordland/Turn_07/137_HOS_NOT_NATIONALISED_AT_ALL.md) |
| `138` | Tura 07 | STATUS QUO | 98 | 23 | **2** | Player, Narrator, Walter Tusk | [Otwórz](Sordland/Turn_07/138_STATUS_QUO.md) |
| `139` | Tura 07 | A_Autocrat_CourtDecision | 395 | 114 | **6** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_07/139_A_Autocrat_CourtDecision.md) |
| `140` | Tura 08 | SnO_GendarmerieDispute | 336 | 33 | **0** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_08/140_SnO_GendarmerieDispute.md) |
| `141` | Tura 08 | SnO_EstordRaid | 314 | 93 | **9** | Player, Player_Italic, Nia Morgna... | [Otwórz](Sordland/Turn_08/141_SnO_EstordRaid.md) |
| `142` | Tura 08 | A_VPSelection | 211 | 44 | **7** | Player, Narrator, Gloria Tory... | [Otwórz](Sordland/Turn_08/142_A_VPSelection.md) |
| `143` | Tura 08 | A_NewVPIntroduction | 159 | 24 | **0** | Player, Narrator, Gloria Tory... | [Otwórz](Sordland/Turn_08/143_A_NewVPIntroduction.md) |
| `144` | Tura 08 | A_AschrafAnniversary | 471 | 85 | **13** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_08/144_A_AschrafAnniversary.md) |
| `145` | Tura 08 | Personal_PetrTalk | 345 | 80 | **5** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_08/145_Personal_PetrTalk.md) |
| `146` | Tura 08 | A_LiviaPetrGone | 179 | 44 | **7** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_08/146_A_LiviaPetrGone.md) |
| `147` | Tura 08 | A_PresidentialPowers | 678 | 83 | **11** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_08/147_A_PresidentialPowers.md) |
| `148` | Tura 08 | Presidential Powers Panel Condition Variables | 71 | 0 | **0** |  | [Otwórz](Sordland/Turn_08/148_Presidential_Powers_Panel_Condition_Variables.md) |
| `149` | Tura 08 | Post Decrees | 664 | 30 | **6** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_08/149_Post_Decrees.md) |
| `150` | Tura 08 | A_UnrestMeeting | 734 | 96 | **4** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_08/150_A_UnrestMeeting.md) |
| `151` | Tura 08 | NOTES | 40 | 0 | **0** | Ovid Grecer | [Otwórz](Sordland/Turn_08/151_NOTES.md) |
| `152` | Tura 08 | A_WomensRightsMeeting | 566 | 92 | **31** | Player, Narrator, Monica... | [Otwórz](Sordland/Turn_08/152_A_WomensRightsMeeting.md) |
| `153` | Tura 08 | Personal_FamilyScene | 455 | 119 | **6** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_08/153_Personal_FamilyScene.md) |
| `154` | Tura 08 | FPnT_LespiaVisit | 80 | 0 | **0** | Narrator | [Otwórz](Sordland/Turn_08/154_FPnT_LespiaVisit.md) |
| `155` | Tura 08 | LespiaVisit_NeutralOrCapitalistRayne | 201 | 42 | **10** | Patricio Alvarez, Player, Player_Italic... | [Otwórz](Sordland/Turn_08/155_LespiaVisit_NeutralOrCapitalistRayne.md) |
| `156` | Tura 08 | LespiaVisit_AntiCapitalistRayne | 176 | 43 | **10** | Patricio Alvarez, Player, Player_Italic... | [Otwórz](Sordland/Turn_08/156_LespiaVisit_AntiCapitalistRayne.md) |
| `157` | Tura 08 | LespiaVisit_TradeDealCancelled | 37 | 8 | **0** | Player, Narrator, Deivid Wisci | [Otwórz](Sordland/Turn_08/157_LespiaVisit_TradeDealCancelled.md) |
| `158` | Tura 08 | LespiaVisit_TalkWithSymon | 65 | 22 | **0** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_08/158_LespiaVisit_TalkWithSymon.md) |
| `159` | Tura 08 | A_AffairMeeting | 355 | 79 | **1** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_08/159_A_AffairMeeting.md) |
| `160` | Tura 08 | FPnT_ValgslandVisit | 89 | 0 | **0** | Narrator | [Otwórz](Sordland/Turn_08/160_FPnT_ValgslandVisit.md) |
| `161` | Tura 08 | ValgslandVisit_TalkWithDeivid | 63 | 16 | **2** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_08/161_ValgslandVisit_TalkWithDeivid.md) |
| `162` | Tura 08 | ValgslandVisit_ComradeRayne | 194 | 41 | **0** | Player, Narrator, Emmerich Hegel | [Otwórz](Sordland/Turn_08/162_ValgslandVisit_ComradeRayne.md) |
| `163` | Tura 08 | ValgslandVisit_AntiCommunistRayne | 123 | 28 | **0** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_08/163_ValgslandVisit_AntiCommunistRayne.md) |
| `164` | Tura 08 | ValgslandVisit_DefaultRayne | 309 | 62 | **0** | Player, Narrator, Emmerich Hegel | [Otwórz](Sordland/Turn_08/164_ValgslandVisit_DefaultRayne.md) |
| `165` | Tura 08 | ValgslandVisit_TradeDealCancelled | 37 | 8 | **0** | Player, Narrator, Deivid Wisci | [Otwórz](Sordland/Turn_08/165_ValgslandVisit_TradeDealCancelled.md) |
| `166` | Tura 08 | A_PressRelease | 344 | 91 | **13** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_08/166_A_PressRelease.md) |
| `167` | Tura 08 | Personal_FrancLeaves | 428 | 43 | **18** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_08/167_Personal_FrancLeaves.md) |
| `168` | Tura 08 | InT_LateRailwayOpening | 173 | 36 | **2** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_08/168_InT_LateRailwayOpening.md) |
| `169` | Tura 08 | InT_LateHighwayOpening | 182 | 36 | **2** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_08/169_InT_LateHighwayOpening.md) |
| `170` | Tura 08 | PSnW_HealthOverviewAndPandemic | 390 | 49 | **0** | Paskal Beniwoll, Player, Player_Italic... | [Otwórz](Sordland/Turn_08/170_PSnW_HealthOverviewAndPandemic.md) |
| `171` | Tura 08 | A_PoliticalOverview2 | 1579 | 206 | **58** | Petr Vectern, Player, Narrator... | [Otwórz](Sordland/Turn_08/171_A_PoliticalOverview2.md) |
| `172` | Tura 08 | ALBIN FEEDBACK | 259 | 54 | **1** | Player, Narrator, Albin Clavin | [Otwórz](Sordland/Turn_08/172_ALBIN_FEEDBACK.md) |
| `173` | Tura 08 | GLORIA FEEDBACK | 252 | 54 | **1** | Player, Narrator, Gloria Tory | [Otwórz](Sordland/Turn_08/173_GLORIA_FEEDBACK.md) |
| `174` | Tura 08 | LUCIAN FEEDBACK | 269 | 54 | **1** | Player, Narrator, Lucian Galade | [Otwórz](Sordland/Turn_08/174_LUCIAN_FEEDBACK.md) |
| `175` | Tura 08 | PETR FEEDBACK | 251 | 42 | **1** | Petr Vectern, Player, Narrator | [Otwórz](Sordland/Turn_08/175_PETR_FEEDBACK.md) |
| `176` | Tura 08 | PoliticsBillsBriefing | 134 | 8 | **0** | Player, Narrator, Lucian Galade... | [Otwórz](Sordland/Turn_08/176_PoliticsBillsBriefing.md) |
| `177` | Tura 08 | Other Cabinet Updates | 389 | 82 | **15** | Paskal Beniwoll, Player, Narrator... | [Otwórz](Sordland/Turn_08/177_Other_Cabinet_Updates.md) |
| `178` | Tura 08 | A_InvestigationResults | 477 | 135 | **9** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_08/178_A_InvestigationResults.md) |
| `539` | Tura 08 | Internal Affairs Section with Lileas and Nia Conversation | 594 | 82 | **4** | Player, Nia Morgna, Narrator... | [Otwórz](Sordland/Turn_08/539_Internal_Affairs_Section_with_Lileas_and_Nia_Conversation.md) |
| `179` | Tura 09 | A_KorontiLead | 187 | 25 | **0** | Player, Player_Italic, Nia Morgna... | [Otwórz](Sordland/Turn_09/179_A_KorontiLead.md) |
| `180` | Tura 09 | Personal_PetrGoesMissing | 294 | 93 | **14** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_09/180_Personal_PetrGoesMissing.md) |
| `181` | Tura 09 | FPnT_Preparations | 528 | 78 | **6** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_09/181_FPnT_Preparations.md) |
| `182` | Tura 09 | EnT_EconomicOverviewAndAction | 1094 | 61 | **10** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_09/182_EnT_EconomicOverviewAndAction.md) |
| `183` | Tura 09 | Personal_MonicaFinalTalk | 681 | 97 | **33** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_09/183_Personal_MonicaFinalTalk.md) |
| `184` | Tura 09 | A_SollTrial | 553 | 64 | **13** | Ovid Grecer, Player, Player_Italic... | [Otwórz](Sordland/Turn_09/184_A_SollTrial.md) |
| `185` | Tura 09 | NOTES | 8 | 0 | **0** |  | [Otwórz](Sordland/Turn_09/185_NOTES.md) |
| `186` | Tura 09 | Personal_FrancCalls | 1028 | 122 | **32** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_09/186_Personal_FrancCalls.md) |
| `187` | Tura 09 | Personal_PetrFuneral | 146 | 39 | **0** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_09/187_Personal_PetrFuneral.md) |
| `188` | Tura 09 | A_CampaignAndInvestigations | 720 | 96 | **59** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_09/188_A_CampaignAndInvestigations.md) |
| `189` | Tura 09 | NFP Investigation | 49 | 8 | **0** | Player, Narrator, Lucian Galade | [Otwórz](Sordland/Turn_09/189_NFP_Investigation.md) |
| `190` | Tura 09 | PFJP Investigation | 100 | 16 | **6** | Player, Narrator, Lucian Galade | [Otwórz](Sordland/Turn_09/190_PFJP_Investigation.md) |
| `191` | Tura 09 | Tusk Investigation | 135 | 19 | **10** | Player, Narrator, Lucian Galade | [Otwórz](Sordland/Turn_09/191_Tusk_Investigation.md) |
| `192` | Tura 09 | Old Guard Investivation | 112 | 28 | **3** | Player, Narrator, Lucian Galade | [Otwórz](Sordland/Turn_09/192_Old_Guard_Investivation.md) |
| `193` | Tura 09 | Leaked Scandal Variables | 107 | 0 | **0** |  | [Otwórz](Sordland/Turn_09/193_Leaked_Scandal_Variables.md) |
| `194` | Tura 09 | Econ Variables | 531 | 0 | **0** |  | [Otwórz](Sordland/Turn_09/194_Econ_Variables.md) |
| `195` | Tura 09 | A_TelevisionInterview | 947 | 267 | **24** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_09/195_A_TelevisionInterview.md) |
| `196` | Tura 09 | A_LileasDiscussion | 413 | 77 | **18** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_09/196_A_LileasDiscussion.md) |
| `197` | Tura 09 | A_Talks | 644 | 87 | **1** | Player, Narrator, Mansoun Leke... | [Otwórz](Sordland/Turn_09/197_A_Talks.md) |
| `198` | Tura 09 | MansounDemands | 267 | 35 | **6** | Player, Narrator, Mansoun Leke | [Otwórz](Sordland/Turn_09/198_MansounDemands.md) |
| `199` | Tura 09 | MansounBFFTalks | 219 | 37 | **10** | Player, Narrator, Mansoun Leke | [Otwórz](Sordland/Turn_09/199_MansounBFFTalks.md) |
| `200` | Tura 09 | KatarinaTalks | 253 | 42 | **6** | Player, Narrator, Katarina Horten | [Otwórz](Sordland/Turn_09/200_KatarinaTalks.md) |
| `201` | Tura 09 | DEPRECATED_A_GeneralFeedbackMeeting | 2 | 0 | **0** |  | [Otwórz](Sordland/Turn_09/201_DEPRECATED_A_GeneralFeedbackMeeting.md) |
| `202` | Tura 09 | A_LileasPrisonVisit | 179 | 25 | **5** | Player, Narrator, Lileas Graf | [Otwórz](Sordland/Turn_09/202_A_LileasPrisonVisit.md) |
| `203` | Tura 09 | A_LeakedScandal | 764 | 9 | **0** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_09/203_A_LeakedScandal.md) |
| `204` | Tura 09 | NOTES | 28 | 0 | **0** | Narrator | [Otwórz](Sordland/Turn_09/204_NOTES.md) |
| `205` | Tura 09 | FPnT_UnitedContanaVisit | 514 | 92 | **14** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_09/205_FPnT_UnitedContanaVisit.md) |
| `206` | Tura 09 | FPnT_ArcasiaVisit | 432 | 72 | **11** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_09/206_FPnT_ArcasiaVisit.md) |
| `207` | Tura 09 | SnO_MilitaryParade | 306 | 59 | **0** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_09/207_SnO_MilitaryParade.md) |
| `208` | Tura 09 | SnO_RumburgIncident | 405 | 47 | **2** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_09/208_SnO_RumburgIncident.md) |
| `540` | Tura 09 | SupportAndChecks Conversation | 47 | 0 | **0** |  | [Otwórz](Sordland/Turn_09/540_SupportAndChecks_Conversation.md) |
| `209` | Tura 10 | SnO_RumburgWarPlans | 1751 | 136 | **44** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_10/209_SnO_RumburgWarPlans.md) |
| `210` | Tura 10 | A_DeividFinalTalk | 381 | 49 | **2** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_10/210_A_DeividFinalTalk.md) |
| `211` | Tura 10 | A_Resignations | 843 | 77 | **6** | Paskal Beniwoll, Player, Nia Morgna... | [Otwórz](Sordland/Turn_10/211_A_Resignations.md) |
| `212` | Tura 10 | A_Congress | 890 | 226 | **35** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_10/212_A_Congress.md) |
| `213` | Tura 10 | Personal_FinalSupper | 177 | 0 | **0** | Narrator | [Otwórz](Sordland/Turn_10/213_Personal_FinalSupper.md) |
| `214` | Tura 10 | DINNER WITH PETR | 313 | 85 | **39** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_10/214_DINNER_WITH_PETR.md) |
| `215` | Tura 10 | DINNER WITH SERGE | 251 | 78 | **34** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_10/215_DINNER_WITH_SERGE.md) |
| `216` | Tura 10 | DINNER ALONE | 109 | 15 | **3** | Player_Italic, Narrator | [Otwórz](Sordland/Turn_10/216_DINNER_ALONE.md) |
| `217` | Tura 10 | DINNER WITH ONLY FRANC | 351 | 94 | **22** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_10/217_DINNER_WITH_ONLY_FRANC.md) |
| `218` | Tura 10 | DINNER MONICA AND DEANA (BAD) | 298 | 76 | **14** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_10/218_DINNER_MONICA_AND_DEANA_(BAD).md) |
| `219` | Tura 10 | DINNER MONICA AND DEANA (GOOD) | 411 | 110 | **15** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_10/219_DINNER_MONICA_AND_DEANA_(GOOD).md) |
| `220` | Tura 10 | DINNER WHOLE FAMILY (BAD) | 309 | 72 | **13** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_10/220_DINNER_WHOLE_FAMILY_(BAD).md) |
| `221` | Tura 10 | DINNER WHOLE FAMILY (GOOD) | 475 | 112 | **13** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_10/221_DINNER_WHOLE_FAMILY_(GOOD).md) |
| `222` | Tura 10 | Personal_FCAnricaDerby | 707 | 133 | **21** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_10/222_Personal_FCAnricaDerby.md) |
| `223` | Tura 10 | AloneWithTarquinSoll | 429 | 102 | **20** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_10/223_AloneWithTarquinSoll.md) |
| `224` | Tura 10 | FCAnricaDressingRoom | 61 | 26 | **0** | Player, Narrator | [Otwórz](Sordland/Turn_10/224_FCAnricaDressingRoom.md) |
| `225` | Tura 10 | FPnT_QueenPhoneCall | 220 | 40 | **6** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_10/225_FPnT_QueenPhoneCall.md) |
| `226` | Tura 10 | FPnT_AllianceOfNations | 1095 | 253 | **72** | Patricio Alvarez, Player, Player_Italic... | [Otwórz](Sordland/Turn_10/226_FPnT_AllianceOfNations.md) |
| `227` | Tura 10 | SnO_CoupNight | 212 | 30 | **0** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_10/227_SnO_CoupNight.md) |
| `228` | Tura 10 | Personal_SergeFuneral | 95 | 38 | **0** | Player, Player_Italic, Narrator | [Otwórz](Sordland/Turn_10/228_Personal_SergeFuneral.md) |
| `229` | Tura 10 | A_Debate | 144 | 9 | **1** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_10/229_A_Debate.md) |
| `230` | Tura 10 | New party convo | 140 | 27 | **3** | Player, Narrator, Moderator... | [Otwórz](Sordland/Turn_10/230_New_party_convo.md) |
| `231` | Tura 10 | Term plans | 356 | 31 | **24** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_10/231_Term_plans.md) |
| `232` | Tura 10 | Grander Plans | 132 | 23 | **5** | Player, Narrator, Moderator... | [Otwórz](Sordland/Turn_10/232_Grander_Plans.md) |
| `233` | Tura 10 | Economy | 212 | 24 | **12** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_10/233_Economy.md) |
| `234` | Tura 10 | Foreign Policy | 190 | 18 | **8** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_10/234_Foreign_Policy.md) |
| `235` | Tura 10 | Women's Rights | 146 | 11 | **6** | Player, Player_Italic, Moderator... | [Otwórz](Sordland/Turn_10/235_Women's_Rights.md) |
| `236` | Tura 10 | Bludish Issues + Scandals | 382 | 47 | **14** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_10/236_Bludish_Issues_+_Scandals.md) |
| `237` | Tura 10 | Denis Challenge | 82 | 12 | **2** | Player, Narrator, Mansoun Leke... | [Otwórz](Sordland/Turn_10/237_Denis_Challenge.md) |
| `238` | Tura 10 | Election + closing statements | 245 | 26 | **7** | Player, Narrator, Moderator... | [Otwórz](Sordland/Turn_10/238_Election_+_closing_statements.md) |
| `239` | Tura 10 | Denis Challenge | 70 | 12 | **1** | Player, Narrator, Mansoun Leke... | [Otwórz](Sordland/Turn_10/239_Denis_Challenge.md) |
| `240` | Tura 10 | SnO_RumburgWarSpeech | 225 | 65 | **6** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_10/240_SnO_RumburgWarSpeech.md) |
| `241` | Tura 10 | NOTES | 6 | 0 | **0** |  | [Otwórz](Sordland/Turn_10/241_NOTES.md) |
| `541` | Tura 10 | EnergyDiscussion Conversation | 311 | 72 | **11** | Player, Narrator, Ewald Alphonso... | [Otwórz](Sordland/Turn_10/541_EnergyDiscussion_Conversation.md) |
| `242` | Tura 11 | SnO_RumburgWarLost | 411 | 80 | **7** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_11/242_SnO_RumburgWarLost.md) |
| `243` | Tura 11 | SnO_CoupTrial | 276 | 29 | **8** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_11/243_SnO_CoupTrial.md) |
| `244` | Tura 11 | A_ElectionSpeech | 1256 | 261 | **124** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_11/244_A_ElectionSpeech.md) |
| `245` | Tura 11 | SnO_RumburgWarWin | 292 | 31 | **9** | Patricio Alvarez, Player, Player_Italic... | [Otwórz](Sordland/Turn_11/245_SnO_RumburgWarWin.md) |
| `246` | Tura 11 | A_ImpeachmentTrial | 203 | 8 | **0** | Ovid Grecer, Player, Player_Italic... | [Otwórz](Sordland/Turn_11/246_A_ImpeachmentTrial.md) |
| `247` | Tura 11 | Nia ACP Evidence | 147 | 7 | **0** | Ovid Grecer, Player, Player_Italic... | [Otwórz](Sordland/Turn_11/247_Nia_ACP_Evidence.md) |
| `248` | Tura 11 | Lucian Evidence | 287 | 18 | **0** | Ovid Grecer, Player, Player_Italic... | [Otwórz](Sordland/Turn_11/248_Lucian_Evidence.md) |
| `249` | Tura 11 | Karl Evidence | 140 | 3 | **0** | Ovid Grecer, Player, Orso Hawker... | [Otwórz](Sordland/Turn_11/249_Karl_Evidence.md) |
| `250` | Tura 11 | Edith Evidence | 123 | 3 | **0** | Ovid Grecer, Player, Player_Italic... | [Otwórz](Sordland/Turn_11/250_Edith_Evidence.md) |
| `251` | Tura 11 | Heron Evidence | 74 | 10 | **0** | Ovid Grecer, Player, Player_Italic... | [Otwórz](Sordland/Turn_11/251_Heron_Evidence.md) |
| `252` | Tura 11 | Karl Evidence Main | 140 | 3 | **0** | Ovid Grecer, Player, Orso Hawker... | [Otwórz](Sordland/Turn_11/252_Karl_Evidence_Main.md) |
| `253` | Tura 11 | NOTES Impeachment Defence | 36 | 1 | **0** | Narrator, Heron Garaci | [Otwórz](Sordland/Turn_11/253_NOTES_Impeachment_Defence.md) |
| `254` | Tura 11 | Personal_Retirement | 796 | 227 | **121** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_11/254_Personal_Retirement.md) |
| `255` | Tura 11 | Personal_Exile | 392 | 58 | **5** | Petr Vectern, Player, Player_Italic... | [Otwórz](Sordland/Turn_11/255_Personal_Exile.md) |
| `256` | Tura 11 | SnO_WorldWar | 174 | 21 | **2** | Player, Player_Italic, Narrator... | [Otwórz](Sordland/Turn_11/256_SnO_WorldWar.md) |
| `278` | Tura 11 | WIPSnO_RumburgWarOffensiveOne | 49 | 8 | **0** | Player, Narrator, Valken Kruger... | [Otwórz](Sordland/Turn_11/278_WIPSnO_RumburgWarOffensiveOne.md) |
| `279` | Tura 11 | SnO_RumburgWarOffensiveTwo | 2 | 0 | **0** |  | [Otwórz](Sordland/Turn_11/279_SnO_RumburgWarOffensiveTwo.md) |
| `280` | Tura 11 | SnO_RumburgWarDefensiveOne | 2 | 0 | **0** |  | [Otwórz](Sordland/Turn_11/280_SnO_RumburgWarDefensiveOne.md) |
| `281` | Tura 11 | SnO_RumburgWarDefensiveTwo | 2 | 0 | **0** |  | [Otwórz](Sordland/Turn_11/281_SnO_RumburgWarDefensiveTwo.md) |
| `282` | Tura 11 | SnO_RumburgWarOffensiveCeasefire | 2 | 0 | **0** |  | [Otwórz](Sordland/Turn_11/282_SnO_RumburgWarOffensiveCeasefire.md) |
| `283` | Tura 11 | SnO_RumburgWarDefensiveCeasefire | 2 | 0 | **0** |  | [Otwórz](Sordland/Turn_11/283_SnO_RumburgWarDefensiveCeasefire.md) |
| `284` | Tura 11 | SnO_RumburgWarStalemateOne | 2 | 0 | **0** |  | [Otwórz](Sordland/Turn_11/284_SnO_RumburgWarStalemateOne.md) |
| `285` | Tura 11 | SnO_RumburgWarStalemateTwo | 2 | 0 | **0** |  | [Otwórz](Sordland/Turn_11/285_SnO_RumburgWarStalemateTwo.md) |
| `286` | Tura 11 | SnO_Rumburg_WarPlan | 2 | 0 | **0** |  | [Otwórz](Sordland/Turn_11/286_SnO_Rumburg_WarPlan.md) |
