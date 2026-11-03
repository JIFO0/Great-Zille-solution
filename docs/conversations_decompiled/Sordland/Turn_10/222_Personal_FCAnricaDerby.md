# Sordland/Turn10/Personal_FCAnricaDerby

- **ID konwersacji:** `222`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/222_Personal_FCAnricaDerby.md`
- **Liczba węzłów dialogowych:** 707
- **Liczba wyborów gracza:** 133

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[29]** Ewald Alphonso
- **[35]** Gus Manger
- **[37]** Curtan Leste
- **[38]** Lucian Galade
- **[48]** Tarquin Soll

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Archetype_SollistRayne`
- `BaseGame.Decision_Turn04_FoundationDonation_LargeSum`
- `BaseGame.Decision_Turn04_FoundationDonation_SmallSum`
- `BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks`
- `BaseGame.Enable_RumburgIncident`
- `BaseGame.Ending_Coup`
- `BaseGame.Ending_ImpeachmentTrial`
- `BaseGame.Joined_ATO`
- `BaseGame.Joined_CSP`
- `BaseGame.Petr_Dead`
- `BaseGame.Policy_Economy_EnergyProtectionAct_Removed`
- `BaseGame.Policy_Welfare_EducationReform`
- `BaseGame.Reform_PresiPower_Default_DeSollinisation`
- `BaseGame.Relations_Ewald_Discontent`
- `BaseGame.RumburgIncident_DeclareWar`
- `BaseGame.Rumburg_War`
- `BaseGame.Situation_Welfare_HousingAssistance`
- `BaseGame.Soll_Hates_Alphonso`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn02_FPnT_Consulate_Condemn`
- `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone`
- `BaseGame.Turn05_Admin_Monica_Barred`
- `BaseGame.Turn05_P_FCAnrica`
- `BaseGame.Turn05_Personal_Festival_Force`
- `BaseGame.Turn05_Personal_Festival_LesteKicked`
- `BaseGame.Turn09_A_LileasResigned`
- `BaseGame.Turn09_EnT_SordishDepression`
- `BaseGame.Turn09_EnT_SordishRecovery`
- `BaseGame.Turn09_MilitaryParade_AssassinationAttempt`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGame.Turn09_UnrestStopped`
- `BaseGame.Turn11_Election_AssassinationHappened`
- `BaseGame.Unrest_BFF_Happened`
- `BaseGame.Unrest_Peaceful_Happened`
- `BaseGame.Unrest_Violent_Happened`
- `BaseGame.Wehlen_JointOperation`
- `BaseGameIsolated.FCAnricaTeamSpeech_Stress`
- `BaseGameIsolated.FCAnrica_Wins`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Death`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameSupport.News_Turn10_LT_FCAnricaLoseAtLastMinute`
- `BaseGameSupport.News_Turn10_LT_FCAnricaLoses`
- `BaseGameSupport.News_Turn10_LT_FCAnricaWins`

### Skoki między-konwersacyjne:
- Węzeł `[50]` -> **[223] Sordland/Turn10/AloneWithTarquinSoll** (../Turn_10/223_AloneWithTarquinSoll.md), Węzeł `[1]`
- Węzeł `[118]` -> **[541] Sordland/Turn10/EnergyDiscussion/EnergyDiscussion Conversation** (../Turn_10/541_EnergyDiscussion_Conversation.md), Węzeł `[1]`
- Węzeł `[139]` -> **[541] Sordland/Turn10/EnergyDiscussion/EnergyDiscussion Conversation** (../Turn_10/541_EnergyDiscussion_Conversation.md), Węzeł `[1]`
- Węzeł `[216]` -> **[224] Sordland/Turn10/FCAnricaDressingRoom** (../Turn_10/224_FCAnricaDressingRoom.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 12
- **Węzły modyfikujące stan gry:** 7

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[461]` (Paskal Beniwoll): `PlayMusic("Diplomacy");`
- Węzeł `[546]` (Paskal Beniwoll): `End();`
- Węzeł `[693]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn10_LT_FCAnricaWins"] = true;`
- Węzeł `[694]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn10_LT_FCAnricaLoseAtLastMinute"] = true;`
- Węzeł `[695]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn10_LT_FCAnricaLoses"] = true;`
- Węzeł `[696]` (Paskal Beniwoll): `SetRichPresence("Watching the Merkopan Champions Cup with esteemed guests","Maroon Stadium","Anri...`
- Węzeł `[697]` (Paskal Beniwoll): `UnlockAchievement("Game_FCAnricaRises");`

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
  - -> `[696]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Today, the management of FC Anrica had invited me to attend a pivotal football match. At Lucian's urging, I accepted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The team was representing Sordland in the international arena. According to Lucian, it would have been un-presidential not to put in an appearance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Today, the management of FC Anrica had invited me to attend a pivotal football match. As a board member, I couldn't reject it. I had to be there at this significant moment for my team."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[9]`
Mówca: **Narrator**
> "We made our way towards the Maroon Stadium. The arena was situated in one of the most crowded quarters of Anrica, surrounded by dense urban development."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[10]`
Mówca: **Lucian Galade**
> ""Sir. The security gave us the clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""Even just the fact that you are here will surely help with our campaign image.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[19]`
  - -> `[12]`
  - -> `[13]`
  - -> `[18]`
  - -> `[15]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sure, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My thoughts exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm just here to support my team.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I just hope FC Gelsord fans don't hold it against me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I hope so, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Narrator**
> "I followed the security. We entered beneath a giant sign that read: "Welcome to the Hall of Martyrs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[21]`
Mówca: **Narrator**
> "And of course, all presidents of Sordland -- current and former -- were invited to watch the historic competition."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Narrator**
> "I was told that my predecessor, Ewald Alphonso, would be joining me in the lounge reserved for us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[26]`
Mówca: **Narrator**
> "I was told that both Tarquin Soll and Ewald Alphonso would be joining me in the lounge reserved for us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[27]`
Mówca: **Lucian Galade**
> ""Please follow the guards to the top floor. You will be seated in the VIP lounge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`
  - -> `[30]`
  - -> `[32]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you sure you can't join me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Any advice before I leave?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's a pity. I'll save you some snacks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I hope there won't be another surprise today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm still not sure if this is the right thing to do so soon after the attempt on my life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Lucian Galade**
> ""Try not to worry, sir. The security detail has assured me that they have everything under control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[37]`
Mówca: **Lucian Galade**
> ""No, sir. The main VIP lounge has been reserved for presidents only today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[29]`
  - -> `[32]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "Follow the security."]** — Mówca: **Player_Italic**
> "I followed the security. We entered beneath a giant sign that read: "Welcome to the Hall of Martyrs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Lucian Galade**
> ""You know the guests of honor more than I do, sir. If all else fails, just focus on the match. It shouldn't be difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[40]`
Mówca: **Narrator**
> "The corridors inside were painted almost completely in maroon. Adorning them were various depictions of the Sordish goat and numerous jerseys, awards and team photographs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[44]`
Mówca: **Narrator**
> "On our way up, I was greeted by the president of the club. Beaming with pride, he immediately shook my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[45]`
Mówca: **Narrator**
> "After delivering his best wishes, he kindly pointed us towards the corridor and told me that I could visit the team before the match if I wished to do so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[218]`

### Węzeł `[46]`
Mówca: **Narrator**
> "After delivering his best wishes, he kindly pointed us towards the lounge, which was surrounded by heavily armed men."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Narrator**
> "Once I finally found myself inside, I was greeted by an amazing view of the entire pitch through floor-to-ceiling windows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `223` (*Sordland/Turn10/AloneWithTarquinSoll*), Węzeł `[1]`

### Węzeł `[51]`
Mówca: **Narrator**
> "I took a seat on the leather sofa and watched as the action began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[52]`
Mówca: **Narrator**
> "FC Anrica was finally in the Merkopan Champions Cup -- the most prestigious football tournament in the world. For the first time ever, a Sordish team had managed to qualify for the Knockout phase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Narrator**
> "They were representing Sordland in the international arena. I couldn't help but feel a surge of pride as Lucian and I headed to the stadium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[54]`
Mówca: **Narrator**
> "Millions of Sordish people were waiting to watch FC Anrica compete against the legendary Rizian team Real Montaklar. Despite all odds being stacked against the team, the mood was full of hope."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Narrator**
> "A win today would bring Anrica to the quarter finals, a feat that no Sordish team had ever managed to achieve."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[56]`
Mówca: **Narrator**
> "Another group of fans raised their boards to reveal a silhouette of the famous Hall of Warriors -- a Markian-era architectural ruin in Anrica -- with Tarquin Soll in front of it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[57]`
Mówca: **Narrator**
> "The stadium erupted in applause as the players started coming out onto the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[58]`
Mówca: **Narrator**
> "Right after the referee signalled the start of the match, the door behind us closed with a thud."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""All right, Lucian. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[60]`
Mówca: **Lucian Galade**
> ""How are you feeling, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`
  - -> `[547]`
  - -> `[552]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Lucian Galade**
> ""Sir. The security gave us the clear and informed us that Tarquin Soll has already arrived at the lounge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm fine, Lucian. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm just a little worried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Lucian Galade**
> ""Don't fret, sir. Today is a day to relax. Perhaps even celebrate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[68]`
Mówca: **Narrator**
> "Lucian's pocket radio crackled. After responding, he turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[69]`
Mówca: **Lucian Galade**
> ""Good luck. I know he's quite the imposing presence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[70]`
Mówca: **Narrator**
> "Behind him, Mayor Curtan Leste and Gus Manger were waiting to greet me as well. All of them had FC Anrica pins attached to their collars."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[71]`
Mówca: **Narrator**
> "As the players of Real Montaklar lined up in the middle of the field, FC Anrica fans started chanting: "We'll eat you whole for Colonel Soll!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[72]`
Mówca: **Narrator**
> "As we wound our way through the streets, I noticed the name of Tarquin Soll everywhere. Since I'd last been here, markets, restaurants and even pubs named after the Colonel had all popped up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[75]`
  - -> `[78]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why is Anrica so crazy about Soll all of a sudden?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It seems like Mayor Curtan Leste isn't following our de-Sollinization policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_DeSollinisation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_DeSollinisation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_DeSollinisation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_DeSollinisation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_DeSollinisation"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Did this all happen after his death?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is it just me or are they really using the name of a criminal everywhere?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Am I imagining things, or did we just pass a pub called 'Alco-Soll'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Lucian Galade**
> ""They are, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""I'm afraid we did, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[89]`
Mówca: **Lucian Galade**
> ""Most likely. He became a martyr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Lucian Galade**
> ""I noticed it as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Lucian Galade**
> ""I've heard it is part of an ad campaign for Anrica. An attempt to draw tourists, or at least Sollist ones, to the city. Soll's legacy still lives on for millions, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == false && (BaseGame.Turn05_Personal_Festival_Force == true || BaseGame.Turn05_Personal_Festival_LesteKicked == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == false && (BaseGame.Turn05_Personal_Festival_Force == true || BaseGame.Turn05_Personal_Festival_LesteKicked == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == false  and  (Variable["BaseGame.Turn05_Personal_Festival_Force"] == true  or  Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_Monica_Barred == false && (BaseGame.Turn05_Personal_Festival_Force == true || BaseGame.Turn05_Personal_Festival_LesteKicked == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == false  and  (Variable["BaseGame.Turn05_Personal_Festival_Force"] == true  or  Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[98]`
Mówca: **Ewald Alphonso**
> ""It looks like it's working well for the city. And if you moved back home, I'm sure you'd get free meals and drinks everywhere you went.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[99]`
Mówca: **Ewald Alphonso**
> ""I doubt the Colonel would approve of his name being used as a tourist draw. But he's not around anymore, is he?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Narrator**
> "Ewald Alphonso quickly walked up to me, shook my hand and sat next to me with a grin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`
  - -> `[561]`
  - -> `[562]`

### Węzeł `[101]`
Mówca: **Narrator**
> "Ewald Alphonso quickly walked up to the sofa, shook our hands and sat next to us, smiling as he did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Tarquin Soll**
> ""Ha. You know, I never had a strong connection to this place. Mr. Leste should have asked my permission before using my name to market his city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Ewald Alphonso**
> ""Oh, it was actually Gus Manger's idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[104]`
Mówca: **Curtan Leste**
> ""Welcome to Anrica, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[105]`
Mówca: **Gus Manger**
> ""And all of Sordland! Never before has a Sordish team reached this stage in the Merkopan Cup.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`
  - -> `[202]`
  - -> `[203]`

### Węzeł `[106]`
Mówca: **Tarquin Soll**
> ""Why am I not surprised? He's full of ideas, your Mr. Manger, except when it comes to the job he's actually supposed to be doing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Ewald Alphonso**
> ""No need to be so dismissive. Gus has proven himself time and again. His work rejuvenated Sordish industries. And without him, Anrica wouldn't be the city it is today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[109]`
  - -> `[108]`
  - -> `[111]`

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, working with Gus has been nothing but a disaster.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I must say, Gus has been a very valuable minister of my cabinet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I let them continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What did Gus do for Anrica?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[112]`
Mówca: **Tarquin Soll**
> ""Just what we need. Another president in thrall to Mr. Manger and his get-rich-quick schemes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[113]`
Mówca: **Tarquin Soll**
> ""All of the man's so-called accomplishments have been purely accidental.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Ewald Alphonso**
> ""He invested heavily in this city and helped transform Anrica into a tourist destination. And he's the one who saw the potential in football.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[115]`
Mówca: **Ewald Alphonso**
> ""You say that, Mr. Soll, but Mr. Manger is a respectable professional who actually loves this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Tarquin Soll**
> ""More like an errand boy, doing the bidding of those who line his pockets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Narrator**
> "Alphonso sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Ewald Alphonso**
> ""I don't intend to take on the role of his personal spokesman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `541` (*Sordland/Turn10/EnergyDiscussion/EnergyDiscussion Conversation*), Węzeł `[1]`

### Węzeł `[119]`
Mówca: **Narrator**
> "As if on cue, Real Montaklar's defense made a crucial block, sending the ball back down the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`
  - -> `[124]`
  - -> `[123]`
  - -> `[125]`
  - -> `[126]`

### Węzeł `[120]`
Mówca: **Narrator**
> "Just then, FC Anrica's star midfielder made a breakaway down the field. The crowd erupted into cheers as the ball was passed from player to player, each touch bringing it closer to the goal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[121]`
Mówca: **Tarquin Soll**
> ""Too predictable. They won't make it past the other team's defense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[122]`
Mówca: **Ewald Alphonso**
> ""Look. We're going to score.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you a Real Montaklar supporter, Colonel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""With your strategy skills, you should be a football coach, Colonel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They'll get it next time. Have some faith in our team.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My boys will win this. You'll see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[130]`
Mówca: **Ewald Alphonso**
> ""You know, it was actually Gus Manger's idea. Turning Anrica into the city of Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Ewald Alphonso**
> ""Without him, Anrica wouldn't be the city it is today. But his instincts may have failed him with this ill-timed strategy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[133]`
  - -> `[132]`
  - -> `[134]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, working with Gus has been nothing but a disaster.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Maybe it's not such ill timing. Soll's name has been on everyone's lips since the trial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What did he do for Anrica?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gus must realize he's aiding Soll's cult of personality with stunts like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[136]`
Mówca: **Ewald Alphonso**
> ""He invested heavily in this city and helped transform Anrica into a tourist destination. And he saw the potential of football.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[137]`
Mówca: **Ewald Alphonso**
> ""Don't be so dismissive. He really is a respectable professional who loves this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Ewald Alphonso**
> ""You make a good point. Maybe Gus' business instincts have rubbed off on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Ewald Alphonso**
> ""Anyway, we didn't come here to talk about Mr. Manger. We're here to watch our men win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `541` (*Sordland/Turn10/EnergyDiscussion/EnergyDiscussion Conversation*), Węzeł `[1]`

### Węzeł `[140]`
Mówca: **Ewald Alphonso**
> ""Look. We're going to score.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[141]`
Mówca: **Tarquin Soll**
> ""Don't make me laugh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Tarquin Soll**
> ""Faith alone does not suffice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Narrator**
> "Alphonso turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Ewald Alphonso**
> ""How about you, Mr. Rayne? It's been a while since we last met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn11_Election_AssassinationHappened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn11_Election_AssassinationHappened == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn11_Election_AssassinationHappened == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Ewald Alphonso**
> ""How are you holding up after that attack at the parade?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`
  - -> `[170]`

### Węzeł `[152]`
Mówca: **Ewald Alphonso**
> ""I heard your man Serge gave his life to protect you... My condolences. He was a true champion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[153]`
Mówca: **Ewald Alphonso**
> ""Is everything going well at the Palace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[169]`
  - -> `[170]`

### Węzeł `[154]`
Mówca: **Narrator**
> "As if on cue, Real Montaklar's defense made a crucial block, sending the ball back down the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I didn't know you were a football fan, Mr. Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They'll get it next time. Have some faith in our team.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My boys will win this. You'll see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[161]`
Mówca: **Ewald Alphonso**
> ""Well, damn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`
  - -> `[157]`
  - -> `[162]`

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They're against the top team in Eastern Merkopa. It won't be so easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Ewald Alphonso**
> ""I'm aware.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[164]`
Mówca: **Ewald Alphonso**
> ""That's the spirit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Ewald Alphonso**
> ""Honestly, I'm more of a money fan. Football is the future, you'll see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Narrator**
> "He turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Ewald Alphonso**
> ""So...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm trying my best to stay calm. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, I'm worried. The country is showing signs of instability again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It would be a lie if I said it's been great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Ewald Alphonso**
> ""I completely understand what you mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[172]`
Mówca: **Ewald Alphonso**
> ""Yes, Mr. Rayne. Sordish politics is getting complicated again. You have to be careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Ewald Alphonso**
> ""That's a relief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Tarquin Soll**
> ""Take on the responsibility for once, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Tarquin Soll**
> ""You've had the authority for four years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Narrator**
> "Suddenly, a huge roar shook the stadium. The crowd was in a frenzy as FC Anrica finally got the ball past the dominating Rizian defenders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[180]`
Mówca: **Narrator**
> "Just then, Montaklar midfielders executed an incredibly fast counter-attack, scoring a goal that put them ahead in just a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[181]`
Mówca: **Ewald Alphonso**
> ""It was bad luck getting a top-tier Rizian team as our opponent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Ewald Alphonso**
> ""I still applaud our guys for giving their best. Not even FC Gelsord has ever come this far in an international tournament. ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`
  - -> `[186]`
  - -> `[428]`

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why so bleak? It's not even half time yet. Anrica can still come out on top.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes. Football is like politics. Sometimes it's all about luck.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't overestimate FC Gelsord. We already broke their record and took the title. Times are changing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, I don't really care about any of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Ewald Alphonso**
> ""I guess you meant to say money. FC Anrica came this far thanks to our investments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[194]`
Mówca: **Ewald Alphonso**
> ""It's not about luck. It's about money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Everything is fine. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[196]`
Mówca: **Narrator**
> "The Sordish side of the stadium fell completely silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[197]`
Mówca: **Curtan Leste**
> ""Mr. President. I didn't expect you to show your support in person.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Curtan Leste**
> ""Thanks for being here. This match means a lot for all of us Anricans.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[199]`
Mówca: **Curtan Leste**
> ""You are always welcome in Anrica, and it is great to see you show support in person.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It is great to be here in Anrica.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I have high hopes for today. This is a big achievement for Sordish football.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, I don't know much about football. But I'm here for the players and for my country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's win this, Gus, shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Gus Manger**
> ""We most definitely will, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[208]`
Mówca: **Gus Manger**
> ""Football is of rapidly expanding importance in Sordland and beyond. It's good that we see the opportunity in it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[209]`
Mówca: **Gus Manger**
> ""Thanks for coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Gus Manger**
> ""Football is of rapidly expanding importance in Sordland and beyond. It's important to see the opportunities in it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Gus Manger**
> ""Come on, Mr. President! You own a stake in the club!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Narrator**
> "The president of the club walked in, handed us gift bags full of FC Anrica merchandise and gave a speech stressing the importance of today's match."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[216]`
**[WYBÓR GRACZA: "Go to the locker room of FC Anrica."]** — Mówca: **Player_Italic**
> "I decided to go to the locker room and talk to the players."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `224` (*Sordland/Turn10/FCAnricaDressingRoom*), Węzeł `[1]`

### Węzeł `[217]`
Mówca: **Narrator**
> "He personally thanked me for my investment and told me that it wouldn't have been possible to transfer big names to the club without it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[218]`
**[WYBÓR GRACZA: "Go directly to the lounge."]** — Mówca: **Player_Italic**
> "I politely refused the offer and proceeded to the heavily guarded lounge area."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[219]`
Mówca: **Narrator**
> "The lounge area was guarded by heavily armed men. They nodded at me to enter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[220]`
Mówca: **Ewald Alphonso**
> ""Let's see if they can keep it up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[221]`
Mówca: **Ewald Alphonso**
> ""You just need to look like you care, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_UnrestStopped == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_UnrestStopped == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_UnrestStopped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_UnrestStopped == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_UnrestStopped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] == true  or  Variable["BaseGame.Unrest_Violent_Happened"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_Peaceful_Happened"] == true  or  Variable["BaseGame.Unrest_Violent_Happened"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[228]`
Mówca: **Ewald Alphonso**
> ""Considering that a war with Rumburg is on the horizon, you seem almost too composed and calm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[255]`
  - -> `[256]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false  and  (Variable["BaseGame.Enable_RumburgIncident"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false) == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false  and  (Variable["BaseGame.Enable_RumburgIncident"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false) == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[235]`
Mówca: **Ewald Alphonso**
> ""Considering that Rumburg is actively pushing for war, you seem too composed and calm, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[255]`
  - -> `[256]`

### Węzeł `[236]`
Mówca: **Ewald Alphonso**
> ""Considering that the country is getting mired in internal conflict, you seem almost too composed and calm, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[255]`
  - -> `[257]`
  - -> `[258]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[240]`
Mówca: **Ewald Alphonso**
> ""Considering that the Supreme Court is preparing a case to impeach you, you seem almost too composed and calm, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[255]`
  - -> `[258]`

### Węzeł `[241]`
Mówca: **Ewald Alphonso**
> ""Considering that you have lost the support of the General Staff, you seem too composed and calm, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[255]`
  - -> `[258]`
  - -> `[259]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_Coup == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishDepression == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Ewald Alphonso**
> ""Considering that Sordland is now in a full-on economic crisis, you seem too composed and calm, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[255]`
  - -> `[258]`
  - -> `[260]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_CSP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_CSP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_CSP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Ewald Alphonso**
> ""Considering that you made allies with Malenyev and forced Sordland into the communist bloc, you seem too composed and calm, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[255]`
  - -> `[261]`
  - -> `[262]`

### Węzeł `[253]`
Mówca: **Ewald Alphonso**
> ""Considering everything that's happened in the last four years, you seem almost too composed and calm, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[263]`
  - -> `[264]`

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well, as the president, I have to be. You know how it is, Mr. Former President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry, it's under control. Everything will fall into place soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Rumburg may be a massive world power, but nobody should underestimate Sordland. You will see what we are capable of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't underestimate the power of the government, Mr. Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What would you have me do? There's nothing I can do about that anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not scared of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I didn't start this mess. Unlike you, I did everything in my power to fix the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The CSP is the right place to be for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They are our allies now, yes. I'm not scared of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What are you saying, Mr. Alphonso?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do I really look that composed? That's good to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[265]`
Mówca: **Ewald Alphonso**
> ""You don't need to read between the lines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[266]`
Mówca: **Ewald Alphonso**
> ""You're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Narrator**
> "The only noise that could be heard from the stadium was shouting from the Rizian side: "Montaklar!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
Mówca: **Narrator**
> "All eyes were glued to the scoreboard as the new score appeared: "FC Anrica 0 - Real Montaklar 1.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Narrator**
> "I heard Tarquin Soll laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[276]`
Mówca: **Tarquin Soll**
> ""What you did can only be described as treachery, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[277]`
Mówca: **Tarquin Soll**
> ""I can now see that despite everything, Mr. Alphonso here was a much better president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[278]`
Mówca: **Narrator**
> "From that moment on, we turned our complete attention to the match in front of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[282]`
Mówca: **Tarquin Soll**
> ""Don't expect that to make sense for him. You are talking to Ewald Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[286]`
Mówca: **Ewald Alphonso**
> ""Sure. I'll be a punching bag for both of you today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[290]`
Mówca: **Tarquin Soll**
> ""Sadly, money is still the only thing you care about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[291]`
Mówca: **Narrator**
> "Suddenly, the ball was passed to the famous Sordish striker, Hakon Zlater, who was in front of the goal. I noticed Soll shifting in his seat, his gaze suddenly locked on the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[292]`
Mówca: **Narrator**
> "The referee blew the whistle. It was halftime."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[293]`
Mówca: **Narrator**
> "We heard a noise from above us. A zeppelin was flying over the stadium with a giant poster hanging beneath it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnricaTeamSpeech_Stress > 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnricaTeamSpeech_Stress > 5)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.FCAnricaTeamSpeech_Stress > 5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnricaTeamSpeech_Stress < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnricaTeamSpeech_Stress < 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.FCAnricaTeamSpeech_Stress < 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[300]`
Mówca: **Narrator**
> "The Anrican players already seemed like they had given their all. They looked incredibly stressed and tired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[301]`
Mówca: **Narrator**
> "The Anrican players already seemed like they had given up. They looked incredibly calm, but their movements were slow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[302]`
Mówca: **Narrator**
> "The Rizian players kept dominating the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[303]`
Mówca: **Ewald Alphonso**
> ""That was rough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[304]`
Mówca: **Narrator**
> "I noticed that it was an advertisement for the Alphonso Foundation. At the center of the poster stood Ewald Alphonso, portrayed with a warm smile and a twinkle in his eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[305]`
Mówca: **Narrator**
> "In his outstretched hand, he held a whimsical compass, glowing with a soft golden light. Surrounding him were people from all walks of life and cultures."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Narrator**
> "The tagline, written in elegant and uplifting typography, was prominently displayed at the bottom: "Alphonso Foundation: Bringing Hope To Those In Need, One Act of Kindness at a Time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[308]`
  - -> `[309]`
  - -> `[310]`

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Now you're asking for donations at football matches? How does a non-profit even afford this ad?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well... That's new.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[310]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Italic**
> "I decided not to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Ewald Alphonso**
> ""I'm doing my best to increase our exposure and to help the homeless of this country. This isn't some commercial advertisement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Narrator**
> "Just then, the speakers in the stadium started playing a sound recording in full volume."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Ewald Alphonso**
> ""Wait. There's more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[314]`
Mówca: **Narrator**
> ""Ladies and gentlemen, we bring you a message from the Alphonso Foundation, dedicated to spreading kindness and hope to the less fortunate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[315]`
Mówca: **Narrator**
> ""Picture a Sordland where compassion shines brighter than the stars in the night sky, where the power of generosity uplifts those who need it most. That Sordland can exist, thanks to the Alphonso Foundation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Narrator**
> ""Led by the charismatic and esteemed President Ewald Alphonso, this foundation is on a mission to make a difference in the lives of our fellow citizens, one act of kindness at a time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[317]`
Mówca: **Narrator**
> ""Every Sordish Ren you donate to the Alphonso Foundation helps us provide shelter, food, and a chance for a brighter future to those without a home, without hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Narrator**
> ""Thanks to the donations of President Ewald Alphonso and thousands of Sordish citizens, the Alphonso Foundation has already lifted hundreds out of homelessness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_FoundationDonation_LargeSum == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_FoundationDonation_LargeSum == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_FoundationDonation_LargeSum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_FoundationDonation_LargeSum == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_FoundationDonation_LargeSum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_FoundationDonation_SmallSum == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_FoundationDonation_SmallSum == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_FoundationDonation_SmallSum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_FoundationDonation_SmallSum == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_FoundationDonation_SmallSum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[325]`
Mówca: **Narrator**
> ""Thanks to the donations of President Ewald Alphonso, and esteemed figures like President Anton Rayne, as well as thousands of Sordish citizens, the Alphonso Foundation has already lifted thousands out of homelessness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[326]`
Mówca: **Narrator**
> ""Won't you join us in this noble endeavor? Just call the number, 1-600-ALPHONSO, to make your contribution today. Your support will help us extend a helping hand to those in need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[327]`
Mówca: **Narrator**
> "The recording ended with a few seconds of upbeat jazzy background music that slowly faded out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[329]`
  - -> `[332]`
  - -> `[333]`
  - -> `[338]`

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I appreciate the credit, but you didn't need to put my name in there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_FoundationDonation_LargeSum == true || BaseGame.Decision_Turn04_FoundationDonation_SmallSum == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[331]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_FoundationDonation_LargeSum == true || BaseGame.Decision_Turn04_FoundationDonation_SmallSum == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_FoundationDonation_LargeSum"] == true  or  Variable["BaseGame.Decision_Turn04_FoundationDonation_SmallSum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_FoundationDonation_LargeSum == true || BaseGame.Decision_Turn04_FoundationDonation_SmallSum == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_FoundationDonation_LargeSum"] == true  or  Variable["BaseGame.Decision_Turn04_FoundationDonation_SmallSum"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's good to see that you're at least helping the poor in some way. That is commendable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll be honest. I think that ad was a little distasteful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You don't even live here anymore. I'm surprised you'd think an ad like this would work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What the hell was that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[339]`
Mówca: **Ewald Alphonso**
> ""It helps with the donations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[340]`
Mówca: **Ewald Alphonso**
> ""Why wouldn't it? Don't act like I'm no longer Sordish. I was also a president of this republic, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[341]`
Mówca: **Ewald Alphonso**
> ""I beg to differ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[342]`
Mówca: **Ewald Alphonso**
> ""Thanks for the support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[343]`
Mówca: **Ewald Alphonso**
> ""What's wrong?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[347]`
Mówca: **Tarquin Soll**
> ""Alphonso. Are you not ashamed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`
  - -> `[350]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[351]`
Mówca: **Tarquin Soll**
> ""You're both mad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[352]`
Mówca: **Tarquin Soll**
> ""You had your whole term to plan affordable housing programs. Instead, you decided to pass the buck to Mr. Rayne here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]`

### Węzeł `[353]`
Mówca: **Tarquin Soll**
> ""Is this your way of personal redemption -- spending a few Rens out of your billions and portraying yourself as their saviour?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[357]`
Mówca: **Tarquin Soll**
> ""A couple of hundred people? Congratulations to you both. This is how Sordland will eradicate poverty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[361]`
Mówca: **Tarquin Soll**
> ""You too, Mr. Rayne? I thought you would see through this scheme.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[365]`
Mówca: **Tarquin Soll**
> ""You call this kindness?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[366]`
Mówca: **Ewald Alphonso**
> ""Unlike you, Mr. Soll, I'm not portraying myself as a hero here. I retired from politics just like you did, and I'm now using my clout to help the poor. What's so wrong about this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Ewald Alphonso**
> ""Unlike Soll, I'm trying to use my retirement to make a change. I believe there's a lot of value in using my clout to generate money for those in need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`
  - -> `[376]`
  - -> `[377]`
  - -> `[378]`

### Węzeł `[368]`
Mówca: **Tarquin Soll**
> ""You know I never called myself a hero, Ewald. It was my supporters who portrayed me as one. Don't spin the truth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[369]`
Mówca: **Ewald Alphonso**
> ""Maybe they didn't have any other choice back then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`
  - -> `[388]`
  - -> `[389]`
  - -> `[390]`

### Węzeł `[370]`
Mówca: **Tarquin Soll**
> ""Are you still sore about the party giving you a hard time after I left? Admit it, Ewald. You never could accept being a less popular leader. You hated living under the shadow of what I built.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[371]`
Mówca: **Ewald Alphonso**
> ""It is true. I did hate working inside your shadow empire. But I succeeded in dismantling a lot of those obstacles you laid out for me, and opened the way for reforms. But you never let the party go free.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know I'm not going to take that response at face value. But regardless, I really hope your intentions are genuine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As much as I respect that, I don't believe an issue like this can be left to the *kindness* of the wealthy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And I support your endeavors on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You don't need to explain or justify, Ewald. I get the idea already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[379]`
Mówca: **Ewald Alphonso**
> ""Fair enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[380]`
Mówca: **Ewald Alphonso**
> ""I really appreciate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[381]`
Mówca: **Ewald Alphonso**
> ""Oh no. Is that a Malenyevist talking point? I guess we have to agree to disagree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_ComradeRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[385]`
Mówca: **Ewald Alphonso**
> ""Oh. I almost forgot about your heavy shift towards Malenyevism. I guess I will just stop right here and we have to agree to disagree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[386]`
Mówca: **Ewald Alphonso**
> ""They are, Mr. Rayne. You can be sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is that even true, Mr. Soll? Are you really denying that you did nothing to construct a cult of personality?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[388]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Nobody had any choice. There was no other option.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[389]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Despite everything, we can't deny the millions of people who loved and respected Mr. Soll. That is the reality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[390]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Italic**
> "I kept listening."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[391]`
Mówca: **Ewald Alphonso**
> ""Precisely my point. Would you say it is a valid choice if you only had one option to pick from?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[392]`
Mówca: **Ewald Alphonso**
> ""I'm not saying otherwise. But I must remind you, those same people also stood in the way of progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[393]`
Mówca: **Tarquin Soll**
> ""What does it matter? You believed in that so much that you already ordered the removal of my face from public places, haven't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[394]`
Mówca: **Tarquin Soll**
> ""So it was I who controlled each and every member? I was behind every problem you faced within the USP? Do you really believe that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[395]`
Mówca: **Ewald Alphonso**
> ""I still remember how the party became divided after you stopped supporting me. It is on them for being blind to the progress we were making.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`
  - -> `[398]`
  - -> `[401]`
  - -> `[402]`

### Węzeł `[396]`
Mówca: **Ewald Alphonso**
> ""You are the founder of the party, Mr. Soll. Don't even try to deny your influence over it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[397]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What do you mean? Mr. Soll supported you after the congress?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sollists still make up the bulk of the USP today. Everybody is aware of your influence, Mr. Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[399]`
Mówca: **Tarquin Soll**
> ""Instead of blaming the party, why don't you take a look at yourself? That same party voted me out on their own volition in preference of *you*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[400]`
Mówca: **Tarquin Soll**
> ""According to you, their only *correct* decision must have been to elect *you* as leader. And the rest are completely wrong. Do you think everything is a problem that is specifically created to block *you*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gentlemen. Why don't we calm down a little? We are here to watch football.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[402]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Italic**
> "I kept listening."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[403]`
Mówca: **Narrator**
> "Neither of the two men seemed to care. They continued without stopping to hear what I said."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[404]`
Mówca: **Tarquin Soll**
> ""Instead of blaming the party, why don't you take a look at yourselves? That same party has voted me out on their own volition in preference of the likes of *you*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[405]`
Mówca: **Tarquin Soll**
> ""Take a look at yourself. You are the personification of what you're trying to criticize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`
  - -> `[418]`
  - -> `[419]`
  - -> `[420]`

### Węzeł `[406]`
Mówca: **Ewald Alphonso**
> ""Briefly, yes. The last couple years until I became president in '49, he pushed several of my plans through. And I thought he believed in my vision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[407]`
Mówca: **Ewald Alphonso**
> ""But it was all to get credit for initiating the reforms, wasn't it? That was the only way to save Sollism for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Tarquin Soll**
> ""Your vision? Ha!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`
  - -> `[413]`
  - -> `[412]`

### Węzeł `[409]`
Mówca: **Ewald Alphonso**
> ""You were already voted out by your own followers and your term was ending in a few years. You couldn't afford to go against the current.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[410]`
Mówca: **Tarquin Soll**
> ""You're being ingrateful, Ewald. I agreed to your reforms to help smooth the transition of power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I remember Soll's reforms but I still remember those years as being very unstable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[412]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Italic**
> "I kept listening."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you saying Mr. Soll's reforms between '46 and '49 were actually your plans?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[414]`
Mówca: **Ewald Alphonso**
> ""Of course, they were. It was the Sollists that portrayed it differently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[415]`
Mówca: **Narrator**
> "He looked Tarquin Soll in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[416]`
Mówca: **Ewald Alphonso**
> ""My wing and I pushed for those reforms. Soll merely approved them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You have a point, Mr. Soll. But don't act like you're above all of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's an empty argument. The party and the government were in that state due to your actions over 20 years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is getting out of hand. I think both of you should calm down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh, please. We know that you are still trying to pull the strings behind the scenes, Mr. Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[421]`
Mówca: **Tarquin Soll**
> ""Correct. They built a republic within two decades in the harshest political climate, and they reached a state of being able to elect and oust their own leaders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[422]`
Mówca: **Tarquin Soll**
> ""Oh, what a disastrous state to be in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[423]`
Mówca: **Narrator**
> "He waved a dismissive hand, as if to brush away the notion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[424]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Soll_Hates_Alphonso == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`
  - -> `[426]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Soll_Hates_Alphonso == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Soll_Hates_Alphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Soll_Hates_Alphonso == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Soll_Hates_Alphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[427]`
Mówca: **Tarquin Soll**
> ""I can see now that both of you have only brought disaster to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[428]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why are you changing the topic?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[429]`
Mówca: **Ewald Alphonso**
> ""What do you mean? They just scored.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[430]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Soll_Hates_Alphonso == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`
  - -> `[432]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Soll_Hates_Alphonso == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Soll_Hates_Alphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Soll_Hates_Alphonso == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Soll_Hates_Alphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[433]`
Mówca: **Tarquin Soll**
> ""Not a punching bag. You deserve to be in prison for your deal with the Rums.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[434]`
Mówca: **Narrator**
> "Ewald's face turned expressionless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Soll_Hates_Alphonso == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`
  - -> `[437]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Soll_Hates_Alphonso == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Soll_Hates_Alphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Soll_Hates_Alphonso == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Soll_Hates_Alphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Soll_Hates_Alphonso == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`
  - -> `[440]`

### Węzeł `[439]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Soll_Hates_Alphonso == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Soll_Hates_Alphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[440]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Soll_Hates_Alphonso == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Soll_Hates_Alphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[441]`
Mówca: **Tarquin Soll**
> ""No donation can redeem your betrayal to this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_DeSollinisation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`
  - -> `[444]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_DeSollinisation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_DeSollinisation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_DeSollinisation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_DeSollinisation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[445]`
Mówca: **Tarquin Soll**
> ""I didn't need to build a cult for myself, Mr. Rayne. I built a republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[446]`
Mówca: **Ewald Alphonso**
> ""Mr. Rayne has a point, Mr. Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[447]`
Mówca: **Ewald Alphonso**
> ""You *rebuilt* it in your own vision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[448]`
Mówca: **Narrator**
> "Tarquin Soll locked his gaze at Ewald."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[449]`
Mówca: **Tarquin Soll**
> ""I did not believe in your *vision*, but I truly wished for your success -- for the sake of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[450]`
Mówca: **Tarquin Soll**
> ""But soon after your destruction of our economy, I realized how naive I was to open that gate for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[451]`
Mówca: **Narrator**
> "Suddenly, we turned our heads to the field as a massive roar shook the stadium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[452]`
Mówca: **Ewald Alphonso**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[453]`
Mówca: **Tarquin Soll**
> ""Now you just sound paranoid, Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[454]`
Mówca: **Narrator**
> "The second half was already in full swing and Anrican players were aggressively attacking, weaving in and out of defenders with speed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]`

### Węzeł `[455]`
Mówca: **Narrator**
> "The Sordish crowd went crazy as Zlater's powerful shot brought the ball to the back of the Rizian net."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[456]`
Mówca: **Ewald Alphonso**
> ""YES!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[457]`
Mówca: **Narrator**
> "Ewald jumped from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[458]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`
  - -> `[460]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[460]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[461]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayMusic("Diplomacy");)*
- **Efekt (`userScript`):** `PlayMusic("Diplomacy");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[462]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you always this negative, Mr. Soll?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[463]`
Mówca: **Tarquin Soll**
> ""I'm a realist, Mr. Rayne. I don't have time for fake positivities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[464]`
Mówca: **Narrator**
> "Suddenly, the cheering was interrupted by the linesman raising the flag -- making an offside call."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[465]`
Mówca: **Narrator**
> "Anrican fans dominated the stadium as the scoreboard was replaced with the new score: "FC Anrica 1 - Real Montaklar 1.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[466]`
Mówca: **Ewald Alphonso**
> ""Bullshit! That wasn't an offside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`
  - -> `[468]`
  - -> `[469]`
  - -> `[470]`

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That referee is trying to sabotage us. He was clearly in front of the defenders when he received the ball.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you think the Rizians could have bought the referees?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""To be fair, nobody here cares.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[470]`
**[WYBÓR GRACZA: "Do not comment."]** — Mówca: **Player_Italic**
> "I stayed silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[471]`
Mówca: **Ewald Alphonso**
> ""That was a great comeback. We can still make it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`
  - -> `[495]`
  - -> `[497]`
  - -> `[498]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`
  - -> `[474]`

### Węzeł `[473]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[475]`
Mówca: **Tarquin Soll**
> ""Halt your endless bickering. The linesman made the right call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[476]`
Mówca: **Ewald Alphonso**
> ""Well... I still do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[477]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`
  - -> `[479]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[480]`
Mówca: **Ewald Alphonso**
> ""It's your own club, Mr. Rayne. But suit yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[481]`
Mówca: **Ewald Alphonso**
> ""Well... They have the prestige and the money to do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[482]`
Mówca: **Ewald Alphonso**
> ""The angle was all wrong. A decision like that shouldn't be made without proper evaluation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[483]`
Mówca: **Tarquin Soll**
> ""What next? You're going to install cameras and analyze every position from different angles?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`
  - -> `[486]`

### Węzeł `[485]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[486]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[487]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`
  - -> `[489]`

### Węzeł `[488]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`
  - -> `[492]`
  - -> `[491]`
  - -> `[490]`

### Węzeł `[489]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[490]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Just let it be, Ewald.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[491]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The Global Football Association is clearly biased against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What next? You're going to install cameras and analyze every position from different angles?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[493]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You should have more faith in our Sordish players.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[495]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Exactly. We can be the underdogs here, but we cannot let the Rizians intimidate us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[496]`
Mówca: **Narrator**
> "The excitement in the stadium reached a fever pitch as the Sordish striker dribbled the ball past two defenders and took a shot at the goal again. The crowd held its breath as the ball sailed through the air, but the Montaklar goalkeeper made a miraculous save."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[497]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""To be fair, nobody here cares.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[498]`
**[WYBÓR GRACZA: "Do not comment."]** — Mówca: **Player_Italic**
> "I stayed silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[499]`
Mówca: **Ewald Alphonso**
> ""Well... I still do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[500]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`
  - -> `[502]`

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[502]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[503]`
Mówca: **Ewald Alphonso**
> ""It's your own club, Mr. Rayne. But suit yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[504]`
Mówca: **Narrator**
> "The excitement in the stadium reached a fever pitch as the Rizian striker dribbled the ball past two defenders and took a shot at the goal. The crowd held its breath as the ball sailed through the air, but the Anrican goalkeeper made a miraculous save."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[505]`
Mówca: **Narrator**
> "As the last minutes of the match kicked in, we found ourselves falling more and more silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[506]`
Mówca: **Ewald Alphonso**
> ""You're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[507]`
Mówca: **Ewald Alphonso**
> ""Damn. That was close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[508]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_LileasResigned == true && BaseGame.Rumburg_War == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`
  - -> `[510]`

### Węzeł `[509]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_LileasResigned == true && BaseGame.Rumburg_War == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_A_LileasResigned"] == true  and  Variable["BaseGame.Rumburg_War"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[510]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_A_LileasResigned == true && BaseGame.Rumburg_War == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_A_LileasResigned"] == true  and  Variable["BaseGame.Rumburg_War"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[511]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`
  - -> `[513]`

### Węzeł `[512]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[513]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_Coup == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[514]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`
  - -> `[516]`

### Węzeł `[515]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[516]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[517]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`
  - -> `[519]`

### Węzeł `[518]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false  and  (Variable["BaseGame.Enable_RumburgIncident"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false) == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[519]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false  and  (Variable["BaseGame.Enable_RumburgIncident"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false) == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[520]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`
  - -> `[522]`

### Węzeł `[521]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[522]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[523]`
Mówca: **Narrator**
> "He suddenly pointed to a group of people who were holding signs in the front row."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[524]`
Mówca: **Ewald Alphonso**
> ""Do you see that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[525]`
Mówca: **Narrator**
> "It was a group of Rizians who were holding signs in the Sordish language: "No To War In Merkopa. Peace Between Rumburg and Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`

### Węzeł `[526]`
Mówca: **Narrator**
> "It was a group of Anricans who were holding signs that read: "Soldiers! Leave Your Barracks! Colonel's Home Is In Need!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`

### Węzeł `[527]`
Mówca: **Narrator**
> "It was a group of Anricans who were holding signs that read: "FC Anrica Stands Together With Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`

### Węzeł `[528]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`
  - -> `[530]`

### Węzeł `[529]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[531]`
Mówca: **Narrator**
> "It was a group of Anricans who were holding signs that read: "FC Anrica Stands Against Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[532]`
Mówca: **Narrator**
> "It was a group of Anricans who were holding signs that read: "FC Anrica Stands Together With Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`
  - -> `[535]`

### Węzeł `[534]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[535]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[536]`
Mówca: **Narrator**
> "It was a group of Anricans who were holding signs that read: "FC Anrica Stands With Lileas Graf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[537]`
Mówca: **Narrator**
> "It was a group of Anricans who were holding signs that read: "FC Anrica Stands Together With Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[538]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`
  - -> `[540]`

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[540]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[541]`
Mówca: **Narrator**
> "It was a group of Anricans who were holding signs that read: "FC Anrica Stands With The National Front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[542]`
Mówca: **Narrator**
> "It was a group of Anricans who were holding signs that read: "FC Anrica Stands Together With Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[543]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_SollistRayne == true || BaseGame.Turn09_EnT_SordishRecovery == true || (BaseGame.Turn01_InT_Investment_Railway == true && BaseGame.Policy_Welfare_EducationReform == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`
  - -> `[545]`

### Węzeł `[544]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_SollistRayne == true || BaseGame.Turn09_EnT_SordishRecovery == true || (BaseGame.Turn01_InT_Investment_Railway == true && BaseGame.Policy_Welfare_EducationReform == false))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_SollistRayne"] == true  or  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true  or  (Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  and  Variable["BaseGame.Policy_Welfare_EducationReform"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[545]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_SollistRayne == true || BaseGame.Turn09_EnT_SordishRecovery == true || (BaseGame.Turn01_InT_Investment_Railway == true && BaseGame.Policy_Welfare_EducationReform == false)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_SollistRayne"] == true  or  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true  or  (Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  and  Variable["BaseGame.Policy_Welfare_EducationReform"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[546]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`
  - -> `[549]`

### Węzeł `[548]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[549]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[550]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I wish Serge could have lived to see this day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[551]`
Mówca: **Lucian Galade**
> ""Truly a tragedy, sir. I know the pain is still fresh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[552]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Petr_Dead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`
  - -> `[554]`

### Węzeł `[553]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Petr_Dead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Petr_Dead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[554]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Petr_Dead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Petr_Dead"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[555]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I can't believe Petr's not here to see this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[556]`
Mówca: **Lucian Galade**
> ""A tragedy, sir. Mr. Vectern did excel at making public appearances, if nothing else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[557]`
Mówca: **Ewald Alphonso**
> ""Well, {BaseGameText.AlphonsoToPlayer}? What do you think about the city's new marketing plan?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[558]`
Mówca: **Ewald Alphonso**
> ""Well, Colonel? How do you feel about being Anrica's new poster boy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[559]`
Mówca: **Ewald Alphonso**
> ""You and I both know Gus. His only allegiance is to his own bank account.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[560]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Alphonso. How have you been since the trial?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[561]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, he certainly isn't. I saw to that myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[562]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Alphonso. We have unfinished business, don't we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`

### Węzeł `[563]`
Mówca: **Ewald Alphonso**
> ""We do indeed, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Discontent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`
  - -> `[566]`

### Węzeł `[565]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Discontent == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Discontent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[566]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_Discontent == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Discontent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[567]`
Mówca: **Ewald Alphonso**
> ""What's unfinished about it? I'd say the Gasom affair wrapped up well for the both of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[568]`
Mówca: **Ewald Alphonso**
> ""I've been just fine, {BaseGameText.AlphonsoToPlayer}. I wish I could say the same for my company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[569]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Discontent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`
  - -> `[571]`

### Węzeł `[570]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Discontent == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Discontent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[571]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_Discontent == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Discontent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[572]`
Mówca: **Ewald Alphonso**
> ""I do wonder if the trial was the right idea. It hasn't done much to diminish his outsized legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[573]`
Mówca: **Ewald Alphonso**
> ""You were so invested in getting him out of the picture. A pity you weren't as invested in other matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[574]`
Mówca: **Ewald Alphonso**
> ""Honestly, I've never been better. It feels as if a huge weight has been lifted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[575]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Discontent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`
  - -> `[577]`

### Węzeł `[576]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Discontent == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Discontent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[577]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_Discontent == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Discontent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[578]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`
  - -> `[580]`

### Węzeł `[579]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[580]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[581]`
Mówca: **Narrator**
> "It was a group of Anricans who were holding signs that read: "FC Anrica Stands Against Rayne!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[582]`
Mówca: **Narrator**
> "Another massive sign displayed the words: "Soldiers! Leave Your Barracks! Save Your Colonel's Dignity!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[583]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`
  - -> `[585]`

### Węzeł `[584]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[585]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[586]`
Mówca: **Narrator**
> "Another massive sign displayed the words: "Soldiers! Leave Your Barracks! Avenge Your Colonel!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[587]`
Mówca: **Narrator**
> "Another massive sign displayed the words: "Bring Rayne To Justice!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[588]`
Mówca: **Ewald Alphonso**
> ""They need to be arrested for putting up such signs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`
  - -> `[660]`
  - -> `[662]`
  - -> `[663]`
  - -> `[664]`

### Węzeł `[589]`
Mówca: **Tarquin Soll**
> ""At least you still have the support of somebody.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`
  - -> `[602]`
  - -> `[604]`
  - -> `[605]`

### Węzeł `[590]`
Mówca: **Ewald Alphonso**
> ""They need to be arrested for putting up such signs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[591]`
Mówca: **Tarquin Soll**
> ""How liberal of you, Ewald.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`
  - -> `[606]`
  - -> `[607]`
  - -> `[608]`

### Węzeł `[592]`
Mówca: **Ewald Alphonso**
> ""Looks like the impeachment case did not damage your football career.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[593]`
Mówca: **Tarquin Soll**
> ""This football craze seems to have numbed the Anricans a little too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`
  - -> `[602]`
  - -> `[610]`
  - -> `[609]`

### Węzeł `[594]`
Mówca: **Ewald Alphonso**
> ""Looks like the impeachment case has already lost you the football fans.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[595]`
Mówca: **Narrator**
> "Behind them, a poster was being displayed with my and Lileas Graf's faces. I was portrayed wearing an FC Anrica jersey, while Lileas was displayed as an FC Arvory supporter -- her face crossed off with a red marker."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[596]`
Mówca: **Ewald Alphonso**
> ""Looks like FC Anrica fans are really into politics. It's good that they're embracing you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`
  - -> `[609]`
  - -> `[614]`
  - -> `[613]`

### Węzeł `[597]`
Mówca: **Ewald Alphonso**
> ""Looks like FC Anrica fans are really into politics. But unfortunately not into you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`
  - -> `[613]`
  - -> `[615]`
  - -> `[616]`

### Węzeł `[598]`
Mówca: **Ewald Alphonso**
> ""It seems like Anricans like you a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`
  - -> `[614]`
  - -> `[613]`
  - -> `[617]`

### Węzeł `[599]`
Mówca: **Ewald Alphonso**
> ""It really seems like Anrica is going to be lost to the NFP in the local elections, doesn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`

### Węzeł `[600]`
Mówca: **Ewald Alphonso**
> ""They're promoting the NFP in football matches now. What a time to be alive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`

### Węzeł `[601]`
Mówca: **Tarquin Soll**
> ""That's Mr. Rayne's fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`
  - -> `[613]`
  - -> `[616]`
  - -> `[618]`
  - -> `[619]`

### Węzeł `[602]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What does that supposed to mean, Mr. Soll?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[603]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[604]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Funny. Do you not see the millions behind me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`

### Węzeł `[605]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Right. At least that's going good for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[606]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The Colonel is right. They are free to express themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`

### Węzeł `[607]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""These are some very dangerous signs. How were they even allowed inside with them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[608]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is this your doing too, Mr. Soll?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]`

### Węzeł `[609]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Right. At least that's going good for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[610]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why don't you both mind your own business, gentlemen? I am already aware of the trial, alright?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]`

### Węzeł `[611]`
Mówca: **Tarquin Soll**
> ""For good reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`
  - -> `[602]`
  - -> `[610]`
  - -> `[612]`

### Węzeł `[612]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""There's nothing I can do about that now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`

### Węzeł `[613]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, I couldn't care less.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[614]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Of course they would.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`

### Węzeł `[615]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If they're choosing Lileas over me, their opinions don't even matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`

### Węzeł `[616]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I mean... I can't blame them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`

### Węzeł `[617]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well, to be fair, I like Anricans a lot too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[618]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What does that supposed to mean, Mr. Soll?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[619]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They can support whoever they want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`

### Węzeł `[620]`
Mówca: **Ewald Alphonso**
> ""Looks like Rizians are also scared of a possible war between us and Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[621]`
Mówca: **Tarquin Soll**
> ""The Toras family is a puppet of Queen Livingston. If the queen wants war, Rizians will follow them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`
  - -> `[675]`
  - -> `[677]`
  - -> `[678]`

### Węzeł `[622]`
Mówca: **Tarquin Soll**
> ""You lost the support of the mechanisms that matter. And you know that doesn't comprise FC Anrica fans.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[623]`
Mówca: **Tarquin Soll**
> ""We'll see about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[624]`
Mówca: **Tarquin Soll**
> ""Enjoy it while you can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[625]`
Mówca: **Ewald Alphonso**
> ""The contents of that expression seems to be extremely harsh. But suit yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`

### Węzeł `[626]`
Mówca: **Ewald Alphonso**
> ""It is you they're targeting after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[627]`
Mówca: **Ewald Alphonso**
> ""To be fair, this type of statements are not that uncommon in Anrica.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`

### Węzeł `[628]`
Mówca: **Ewald Alphonso**
> ""Home of the Colonel, remember?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[629]`
Mówca: **Tarquin Soll**
> ""You think I'd install a few men with signs to get your attention?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`

### Węzeł `[630]`
Mówca: **Tarquin Soll**
> ""I already have it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[631]`
Mówca: **Ewald Alphonso**
> ""Sure. And good luck with that. I didn't mean anything bad with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[632]`
Mówca: **Ewald Alphonso**
> ""You're right. And good luck with that. I didn't mean anything bad with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[633]`
Mówca: **Ewald Alphonso**
> ""I see you are confident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[634]`
Mówca: **Tarquin Soll**
> ""Of course you don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[635]`
Mówca: **Ewald Alphonso**
> ""I wouldn't go that far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[636]`
Mówca: **Tarquin Soll**
> ""At least you are aware.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[637]`
Mówca: **Ewald Alphonso**
> ""Uh... Okay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[638]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[639]`
Mówca: **Tarquin Soll**
> ""You know what it means, Anton. Does everything need to be explained to you in complete detail for you to understand such a basic concept?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[640]`
Mówca: **Ewald Alphonso**
> ""Well... That's true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[641]`
Mówca: **Narrator**
> "Suddenly, a wave of shouting made us focus back on the field. An Anrican player was shown a yellow card."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[642]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`
  - -> `[644]`

### Węzeł `[643]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`

### Węzeł `[644]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[645]`
Mówca: **Narrator**
> "With only a few minutes left on the clock, it looked as though the match would end in a draw."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]`

### Węzeł `[646]`
Mówca: **Narrator**
> "With only a few minutes left on the clock, it looked as though the match would end with a 1-0 loss for FC Anrica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`

### Węzeł `[647]`
Mówca: **Narrator**
> "But suddenly, everything changed. Number 10 of Real Montaklar dribbled expertly towards the goal and effortlessly scored as Anrican defenders watched him in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`

### Węzeł `[648]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnrica_Wins == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`
  - -> `[650]`

### Węzeł `[649]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnrica_Wins == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.FCAnrica_Wins"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]`

### Węzeł `[650]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.FCAnrica_Wins == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.FCAnrica_Wins"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[651]`
Mówca: **Narrator**
> "We watched in silence as the scoreboard was modified to display: "FC Anrica: 0 - Real Montaklar: 2.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`

### Węzeł `[652]`
Mówca: **Narrator**
> "But suddenly, everything changed. Number 10 of Real Montaklar dribbled expertly towards the goal and effortlessly scored as Anrican defenders watched him in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`

### Węzeł `[653]`
Mówca: **Narrator**
> "But suddenly, everything changed. The Nibiyan star striker Leon al-Ogwaldo dribbled expertly towards the goal and effortlessly scored a goal from an incredible distance as Rizian defenders watched him in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[654]`
Mówca: **Ewald Alphonso**
> ""YES!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]`

### Węzeł `[655]`
Mówca: **Narrator**
> "I noticed Tarquin Soll shifting in his seat and a large smile appeared on his face -- one that I had never seen before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`

### Węzeł `[656]`
Mówca: **Narrator**
> "We watched in silence as the scoreboard was modified to display: "FC Anrica 1 - Real Montaklar: 2.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]`

### Węzeł `[657]`
Mówca: **Ewald Alphonso**
> ""Really? At the last minute?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[658]`
Mówca: **Narrator**
> "We stood up and watched the scoreboard change to: "FC Anrica 2 - Real Montaklar: 1.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[659]`
Mówca: **Ewald Alphonso**
> ""I knew it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]`

### Węzeł `[660]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're right. They're clearly asking the military to intervene. This cannot be allowed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]`

### Węzeł `[661]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[662]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They are free to express themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`

### Węzeł `[663]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""These are some very dangerous signs. How were they even allowed inside with them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`

### Węzeł `[664]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I wouldn't go that far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]`

### Węzeł `[665]`
Mówca: **Ewald Alphonso**
> ""Why not? You already went too deep by prosecuting the *hero* of the republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[666]`
Mówca: **Ewald Alphonso**
> ""Until their wishes become a reality...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[667]`
Mówca: **Ewald Alphonso**
> ""Anrica is full of people like this these days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`

### Węzeł `[668]`
Mówca: **Ewald Alphonso**
> ""Home of the Colonel, remember?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[669]`
Mówca: **Ewald Alphonso**
> ""I'd be extremely careful if I were you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[670]`
Mówca: **Narrator**
> "The Rizian side broke into massive applause as the referee blew the final whistle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[671]`
Mówca: **Narrator**
> "The Sordish side broke into massive applause as the referee blew the final whistle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[672]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`
  - -> `[674]`

### Węzeł `[673]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`

### Węzeł `[674]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`

### Węzeł `[675]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They're just a bunch of hippies. Who cares what they say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[676]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[677]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you think Rizia would aid Rumburg in a war with us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[678]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well, they're right. Nobody wants a war with Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[679]`
Mówca: **Tarquin Soll**
> ""Well then... That settles it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`

### Węzeł `[680]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`
  - -> `[682]`

### Węzeł `[681]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[682]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[683]`
Mówca: **Ewald Alphonso**
> ""Not very unexpected, really.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`

### Węzeł `[684]`
Mówca: **Tarquin Soll**
> ""You must go congratulate them in person, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]`

### Węzeł `[685]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]`
  - -> `[687]`

### Węzeł `[686]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]`

### Węzeł `[687]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`

### Węzeł `[688]`
Mówca: **Ewald Alphonso**
> ""That's unbelievable. We should go down and congratulate the boys in person.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`

### Węzeł `[689]`
Mówca: **Ewald Alphonso**
> ""Yes. This is an historic win. I'll come with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`

### Węzeł `[690]`
Mówca: **Narrator**
> "We left the lounge and went downstairs to congratulate the team of FC Anrica on their massive win against Real Montaklar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[691]`
Mówca: **Ewald Alphonso**
> ""We should go down and console the boys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`

### Węzeł `[692]`
Mówca: **Narrator**
> "We left the lounge and went downstairs to congratulate the team for their efforts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[693]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_LT_FCAnricaWins = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_LT_FCAnricaWins"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[694]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_LT_FCAnricaLoseAtLastMinute = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_LT_FCAnricaLoseAtLastMinute"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[695]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_LT_FCAnricaLoses = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_LT_FCAnricaLoses"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[696]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Watching the Merkopan Champions Cup with esteemed guests", "Maroon Stadium", "Anrica");)*
- **Efekt (`userScript`):** `SetRichPresence("Watching the Merkopan Champions Cup with esteemed guests","Maroon Stadium","Anrica");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[697]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Game_FCAnricaRises");)*
- **Efekt (`userScript`):** `UnlockAchievement("Game_FCAnricaRises");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[698]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]`
  - -> `[700]`

### Węzeł `[699]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]`

### Węzeł `[700]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[701]`
Mówca: **Narrator**
> "Suddenly, the ball was passed to the famous Sordish striker, Hakon Zlater, who was in front of the goal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[702]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_HousingAssistance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]`
  - -> `[704]`

### Węzeł `[703]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_HousingAssistance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_HousingAssistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`

### Węzeł `[704]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_HousingAssistance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_HousingAssistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`

### Węzeł `[705]`
Mówca: **Tarquin Soll**
> ""Now Rayne is offering proper housing assistance while you waste your time on crap like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[706]`
Mówca: **Tarquin Soll**
> ""And now you're wasting your time on crap like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
