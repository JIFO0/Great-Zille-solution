# Sordland/Turn05/A_ReformistSpeech

- **ID konwersacji:** `72`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/072_A_ReformistSpeech.md`
- **Liczba węzłów dialogowych:** 266
- **Liczba wyborów gracza:** 82

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[32]** Frens Ricter
- **[34]** Gloria Tory
- **[50]** Kesaro Kibener

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Agnolia_HeljilandRecognised`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Reform_Albin_Convinced`
- `BaseGame.Reform_Gloria_Convinced`
- `BaseGame.Reform_Law_Decrees_Default`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Honorary_Presidents`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Ministers_Default`
- `BaseGame.Reform_Law_TermLimits_2`
- `BaseGame.Reform_Law_Threshold_3`
- `BaseGame.Reform_Law_Threshold_8`
- `BaseGame.Speech_PromisedToTrySoll`
- `BaseGame.Wehlen_TradeDeal`
- `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A`
- `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B`
- `BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed`
- `BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard`
- `BaseGameIsolated.Turn05_A_Speech_PresidentTooPower`
- `BaseGameIsolated.Turn05_A_Speech_RemoveDecrees`
- `BaseGameIsolated.Turn05_A_Speech_SeparationofPowers`
- `BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Public_Opinion`
- `BaseGame.Sollist`
- `BaseGame.Speech_PromisedToTrySoll`
- `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A`
- `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B`
- `BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed`
- `BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard`
- `BaseGameIsolated.Turn05_A_Speech_PresidentTooPower`
- `BaseGameIsolated.Turn05_A_Speech_RemoveDecrees`
- `BaseGameIsolated.Turn05_A_Speech_SeparationofPowers`
- `BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower`
- `BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy`
- `BaseGameSupport.News_Turn05_G_WalkerWarnsNavy`
- `BaseGameSupport.News_Turn05_HP_AssemblyOvershadowed_R`
- `BaseGameSupport.News_Turn05_HP_ConstitutionNotAdequate_R`
- `BaseGameSupport.News_Turn05_HP_ElectionThreshold_R`
- `BaseGameSupport.News_Turn05_HP_PresidentTooPowerful_R`
- `BaseGameSupport.News_Turn05_LT_RemoveDecrees_R`
- `BaseGameSupport.News_Turn05_R_PromisedToTrySoll`
- `BaseGameSupport.News_Turn05_ST_PromisedToTrySoll_NoDeal`
- `BaseGameSupport.News_Turn05_ST_SCTooMuchPower_R`
- `BaseGameSupport.Report_Turn05_Holsord_ReformStatus_Both`
- `BaseGameSupport.Report_Turn05_Holsord_ReformStatus_GloriaAlbin`
- `BaseGameSupport.Report_Turn05_Holsord_ReformStatus_None`
- `BaseGameSupport.Report_Turn05_Uziren_BorderReport`
- `GameCondition.Turn05_A_Speech`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 35

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Sollist`
- `BaseGame.Speech_PromisedToTrySoll`
- `BaseGameIsolated.Turn05_A_Speech_RemoveDecrees`
- `BaseGameSupport.News_Turn05_G_WalkerWarnsNavy`
- `BaseGameSupport.News_Turn05_LT_RemoveDecrees_R`
- `BaseGameSupport.News_Turn05_R_PromisedToTrySoll`
- `BaseGameSupport.News_Turn05_ST_PromisedToTrySoll_NoDeal`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[100]` (Paskal Beniwoll): `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 10;`
- Węzeł `[154]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A"] = true;`
- Węzeł `[155]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B"] = true;`
- Węzeł `[161]` (Paskal Beniwoll): `Variable["BaseGame.Speech_PromisedToTrySoll"] = true;`
- Węzeł `[186]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn05_Holsord_ReformStatus_None"] = true;`
- Węzeł `[187]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn05_Holsord_ReformStatus_GloriaAlbin"] = true;`
- Węzeł `[188]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn05_Holsord_ReformStatus_Both"] = true;`
- Węzeł `[192]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn05_Uziren_BorderReport"] = true;`
- *...oraz 27 innych węzłów ze skryptami.*

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
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I came to the Grand National Assembly of Sordland to deliver a speech regarding the new Constitution and ask for the support of the Assembly before the upcoming vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "I walked quickly through the corridors, giving my greetings to people on my way towards the parliamentary hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[5]`
Mówca: **Narrator**
> "When I entered the hall, the Assembly was in complete chaos, with shouting and cursing between the parties. There was a heavy argument about a proposal made by an MP from NFP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "I took my seat inside the special area reserved for the ministers. Gloria was shouting from her seat at the centre of the hall as she hit the gavel three times, with each strike heavier than the one before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Gloria Tory**
> "<shout>"ORDER! ORDER!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Despite her efforts, the argument continued for a couple of minutes before everybody took back to their seats and finally went quiet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Gloria Tory**
> ""Mr. Kibener, next time when I tell you to do so, either take your seat or leave the hall; so we can proceed with the procedures of this Assembly and continue our duties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Narrator**
> "Some MP's from the NFP side shouted back at her in protest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Gloria Tory**
> ""Honorable ladies and gentlemen, if you allow me to continue...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[12]`
Mówca: **Gloria Tory**
> ""We have the President here with us today. He has asked to give an important announcement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[13]`
Mówca: **Narrator**
> "I saw Kesaro Kibener standing up from his seat and shouting towards the members of the PFJP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Gloria Tory**
> ""Mr. Kibener! Calm yourself! Show respect to the procedures of this Assembly!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[15]`
Mówca: **Narrator**
> "She pointed at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[16]`
Mówca: **Gloria Tory**
> ""You have the floor, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Narrator**
> "The Assembly fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[18]`
Mówca: **Narrator**
> "I walked to the stand as loud clapping started in the USP's side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[53]`
  - -> `[54]`

### Węzeł `[19]`
**[WYBÓR GRACZA: ""Ladies and Gentlemen...""]** — Mówca: **Player**
> ""Ladies and Gentlemen of the Grand National Assembly of Sordland! I am here today to raise important questions regarding our outdated Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[55]`
  - -> `[58]`
  - -> `[62]`

### Węzeł `[20]`
**[WYBÓR GRACZA: ""The Supreme Court holds too much power...""]** — Mówca: **Player**
> ""The Supreme Court holds too much power over our elected branches! They have been obstructing the law making process and has long plagued the democracy in Sordland. Tarquin Soll gave this power to the Court for the sole reason to protect the Constitution of the 20's, which leads us to fail in adapting to the new world...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Our election threshold has harmed our democracy more than anything...""]** — Mówca: **Player**
> ""Our election threshold has harmed our democracy more than anything since the formation of our republic. As USP, we have governed for a long time and I can acknowledge that this success was partly the result of our current 10% percent threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[22]`
**[WYBÓR GRACZA: ""Perhaps it's not expected of me to say this, but the President holds too much authority...""]** — Mówca: **Player**
> ""Perhaps it's not expected of me to say this, but the President holds too much authority in Sordish politics. In order to strengthen our democracy, we must be brave enough to point out the injustices and faults of our Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[23]`
Mówca: **Narrator**
> "I continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[63]`
  - -> `[64]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""...Therefore, we propose changes to the Constitution to prepare Sordland for a more democratic era!""]** — Mówca: **Player**
> ""...Therefore, we propose changes to the Constitution to prepare Sordland for a more democratic era!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""We will break the Supreme Court's authority over constitutional changes.""]** — Mówca: **Player**
> ""We will break the Supreme Court's authority over constitutional changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""We will fix the loopholes that allows the presidents to exercise absolute veto over legislation.""]** — Mówca: **Player**
> ""We will fix the loopholes that allows the presidents to exercise absolute veto over legislation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""We will rebalance the branches of government to ensure a more democratic process.""]** — Mówca: **Player**
> ""We will rebalance the branches of government to ensure a more democratic process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Gloria_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "Unity."]** — Mówca: **Player**
> ""It is more important than ever that we stand united as a nation in these changing times. I call everybody to be part of the change our people have been calling for. We all want to make Sordland better, don't we? Let's embrace democracy and unite under the banner of our people, and surely Sordland will be great again!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[78]`
  - -> `[82]`
  - -> `[83]`

### Węzeł `[32]`
Mówca: **Narrator**
> "Loud noises came from USP and NFP seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[33]`
Mówca: **Gloria Tory**
> ""Mr. President, with all due respect, I believe Sordland is already democratic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`
  - -> `[84]`
  - -> `[85]`

### Węzeł `[34]`
**[WYBÓR GRACZA: ""Please don't interrupt me.""]** — Mówca: **Player**
> ""Please don't interrupt me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[35]`
**[WYBÓR GRACZA: ""I'm not finished yet, Mrs. Tory.""]** — Mówca: **Player**
> ""I'm not finished yet, Mrs. Tory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[36]`
**[WYBÓR GRACZA: ""Ladies and gentlemen of the Assembly! We must set aside our differences.""]** — Mówca: **Player**
> ""Ladies and gentlemen of the Assembly! We must set aside our differences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[42]`
  - -> `[40]`

### Węzeł `[37]`
Mówca: **Narrator**
> "I took a breath and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""It is time to make a new Constitution together!""]** — Mówca: **Player**
> ""It is time to make a new Constitution together!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[42]`
  - -> `[40]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""I ask everyone to think clearly about our current situation. And join us for change.""]** — Mówca: **Player**
> ""I ask everyone to think clearly about our current situation. And join us for change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[42]`
  - -> `[40]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""Ladies and Gentlemen, I demand your votes!""]** — Mówca: **Player**
> ""Ladies and Gentlemen, I demand your votes!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[44]`
  - -> `[45]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""Let's write the future together!""]** — Mówca: **Player**
> ""Let's write the future together!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[174]`

### Węzeł `[42]`
**[WYBÓR GRACZA: ""I ask everyone to support us in the upcoming vote.""]** — Mówca: **Player**
> ""I ask everyone to support us in the upcoming vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[44]`
  - -> `[45]`

### Węzeł `[43]`
**[WYBÓR GRACZA: ""Be part of a new era for Sordland. Join us and vote for our proposal.""]** — Mówca: **Player**
> ""Be part of a new era for Sordland. Join us and vote for our proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
**[WYBÓR GRACZA: ""I will address all the problems of the past in my proposal!""]** — Mówca: **Player**
> ""I will address all the problems of the past in my proposal!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[174]`

### Węzeł `[45]`
**[WYBÓR GRACZA: ""USP will change and lead Sordland into the future!""]** — Mówca: **Player**
> ""USP will change and lead Sordland into the future!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[174]`

### Węzeł `[46]`
**[WYBÓR GRACZA: ""For justice in Sordland!""]** — Mówca: **Player**
> ""For justice in Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[47]`
**[WYBÓR GRACZA: ""For a democratic Sordland!""]** — Mówca: **Player**
> ""For a democratic Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[48]`
**[WYBÓR GRACZA: ""For a united Sordland!""]** — Mówca: **Player**
> ""For a united Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
**[WYBÓR GRACZA: ""For a free Sordland!""]** — Mówca: **Player**
> ""For a free Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Narrator**
> "The Assembly roared with all kinds of different reactions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[51]`
Mówca: **Frens Ricter**
> ""Thank you, Mrs. Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[52]`
Mówca: **Gloria Tory**
> ""Thank you for the speech, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[53]`
**[WYBÓR GRACZA: ""Honorable Members of Assembly...""]** — Mówca: **Player**
> ""Honorable Members of the Grand National Assembly of Sordland! I am here today to raise important questions regarding our outdated Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[55]`
  - -> `[58]`
  - -> `[62]`

### Węzeł `[54]`
**[WYBÓR GRACZA: ""Brothers and sisters...""]** — Mówca: **Player**
> ""Brothers and sisters! I am here today to raise important questions regarding our outdated Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[55]`
  - -> `[58]`
  - -> `[62]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == false && BaseGame.Reform_Law_TermLimits_2 == true && BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Ministers_Default == false && BaseGame.Reform_Law_Impeachment_Removed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == false && BaseGame.Reform_Law_TermLimits_2 == true && BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Ministers_Default == false && BaseGame.Reform_Law_Impeachment_Removed == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == false  and  Variable["BaseGame.Reform_Law_TermLimits_2"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Default == false && BaseGame.Reform_Law_TermLimits_2 == true && BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Ministers_Default == false && BaseGame.Reform_Law_Impeachment_Removed == false ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == false  and  Variable["BaseGame.Reform_Law_TermLimits_2"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
**[WYBÓR GRACZA: ""Our Constitution doesn't adequately define or respect the separation of powers...""]** — Mówca: **Player**
> ""Our Constitution doesn't adequately define or respect the separation of powers and the balance between the branches. In order to strengthen our democracy, we must be brave enough to point out the faults of our Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[62]`
**[WYBÓR GRACZA: ""Our elected Assembly has always been overshadowed...""]** — Mówca: **Player**
> ""Our elected Assembly has always been overshadowed by the executive and the designated judiciary branches in Sordland. The Grand National Assembly must be able to exercise its job properly and without obstruction. However, our current Constitution fails to guarantee this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""We must finally rewrite the Constitution of Soll and break our chains of the past!""]** — Mówca: **Player**
> ""We must finally rewrite the Constitution of Soll and break our chains of the past!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""I call everyone to stand by us to make historic changes to our Constitution and bring it to the standards of today's world!""]** — Mówca: **Player**
> ""I call everyone to stand by us to make historic changes to our Constitution and bring it to the standards of today's world!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[65]`
Mówca: **Narrator**
> "Loud applauses came from PFJP seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`
  - -> `[27]`

### Węzeł `[66]`
Mówca: **Narrator**
> "Applauses came from USP and PFJP seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[27]`

### Węzeł `[67]`
Mówca: **Narrator**
> "Applauses came from USP and PFJP seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[27]`

### Węzeł `[68]`
Mówca: **Narrator**
> "I focused on..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "Change."]** — Mówca: **Player**
> ""We must not be afraid of change. The world is changing, and Sordland needs the change it has earned after years of Sollism in the last decades. We will rewrite the old and make a constitution that would reflect the will of the people, and open the way for a democratic Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[78]`
  - -> `[82]`
  - -> `[83]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "Peace."]** — Mówca: **Player**
> ""The '29 Constitution was the product of a time of war. Now is a time for peace. As we must make peace between each other, we must strive for peace in the world. We need a more democratic constitution that would reflect the will of the people, and flourish in the upcoming times of peace and prosper!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[78]`
  - -> `[82]`
  - -> `[83]`

### Węzeł `[71]`
Mówca: **Narrator**
> "Just as I was about to continue speaking, Gloria Tory interrupted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[72]`
Mówca: **Narrator**
> "I walked back to my seat as many MP's asked to speak. Frens Ricter was among them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[73]`
Mówca: **Narrator**
> "Suddenly Kesaro Kibener started yelling from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Abolished == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[77]`
**[WYBÓR GRACZA: ""Tarquin Soll will answer for the crimes committed during his rule! We will make sure of that!""]** — Mówca: **Player**
> ""Tarquin Soll will answer for the crimes committed during his rule! We will make sure of that!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[81]`
**[WYBÓR GRACZA: ""We will be removing the presidential decrees and leave lawmaking to the Assembly.""]** — Mówca: **Player**
> ""We will be removing the presidential decrees and leave lawmaking to the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[82]`
**[WYBÓR GRACZA: ""We will make Sordland great again!""]** — Mówca: **Player**
> ""We will make Sordland great again!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[83]`
**[WYBÓR GRACZA: ""Let's embrace the future.""]** — Mówca: **Player**
> ""Let's embrace the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[84]`
**[WYBÓR GRACZA: ""We both know that our Constitution is flawed.""]** — Mówca: **Player**
> ""We both know that our Constitution is flawed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
**[WYBÓR GRACZA: ""You don't believe that.""]** — Mówca: **Player**
> ""You don't believe that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Gloria Tory**
> ""Tarquin Soll and his efforts cannot be ignored. We must keep following the path he defined for Sordish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Gloria Tory**
> ""I'm sure the Honorable Members of USP will see that the President is acting rash by allying with the opposition to destroy the culture of Sollism that established Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Gloria Tory**
> ""That was the extent of my quick note. Thank you. The President has the floor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[240]`
  - -> `[238]`
  - -> `[237]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true && BaseGame.Reform_Albin_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true && BaseGame.Reform_Albin_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true  and  Variable["BaseGame.Reform_Albin_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Gloria_Convinced == true && BaseGame.Reform_Albin_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true  and  Variable["BaseGame.Reform_Albin_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[92]`
Mówca: **Narrator**
> "The whole United Sordland Party stood up and started applauding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[93]`
Mówca: **Narrator**
> "Some applauses came from the PFJP and USP seats. Most of the others started to make loud noises again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[94]`
Mówca: **Gloria Tory**
> ""Yes, Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[95]`
Mówca: **Frens Ricter**
> ""I would like to thank Mr. President for his speech. We, the People's Freedom and Justice Party, stand in agreement with the need for a more democratic Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Frens Ricter**
> ""I would like to thank the Ladies and Gentlemen of the United Sordland Party for their more open attitude compared to past years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Frens Ricter**
> ""As long as Mr. President's words prove not to be just words, we will be behind this much needed movement for change. We welcome this attempt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Frens Ricter**
> ""I ask Mr. President to share the final contents of this proposal as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Frens Ricter**
> ""Thank you, Mrs. Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Sollist -= 10)*
- **Efekt (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[101]`
Mówca: **Kesaro Kibener**
> "<shout>"The President must have lost his mind to cooperate with the likes of you, Mr. Ricter!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Kesaro Kibener**
> "<shout>"You and PFJP are nothing but puppets of western interests!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Gloria Tory**
> "<shout>"ORDER!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Kesaro Kibener**
> ""Madame Speaker! I know you are in agreement with me as well. Don't stand idly there while this administration is making deals with snakes and undermine the integrity of Sor-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Gloria Tory**
> ""ORDER! Mr. Kibener! How many times do I need to say? You are speaking out of tu-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Kesaro Kibener**
> ""I demand to speak!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[107]`
Mówca: **Gloria Tory**
> ""...Very well, Mr. Kibener... Go ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Kesaro Kibener**
> ""Mr. President!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Narrator**
> "He looked directly at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Kesaro Kibener**
> ""The nationalist movement does not agree with your priorities nor the way you're trying to implement them. The National Front Party will not stand with you on your new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Kesaro Kibener**
> ""Let it be known that the NFP's concerns are not included in this so called "democratic" reforms. Thus Mr. President has no right to claim them as such!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Kesaro Kibener**
> ""We will stand our ground against any attempt to bring down our established political culture and national values. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Narrator**
> "Gloria gave him a stare. She looked annoyed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[114]`
Mówca: **Narrator**
> "Kesaro went back to his seat but the chaos in the Assembly continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[115]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "Leave the Assembly."]** — Mówca: **Player_Italic**
> "I decided to leave the Assembly and its chaos behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "Ask to speak."]** — Mówca: **Player_Italic**
> "I asked to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Narrator**
> "I got up from my seat and started my walk towards the exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[118]`
Mówca: **Gloria Tory**
> ""Yes, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`
  - -> `[121]`

### Węzeł `[119]`
**[WYBÓR GRACZA: ""Mr. Kibener...""]** — Mówca: **Player**
> ""Mr. Kibener...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[120]`
**[WYBÓR GRACZA: ""Mr. Ricter...""]** — Mówca: **Player**
> ""Mr. Ricter...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[121]`
**[WYBÓR GRACZA: ""I just wanted to thank everybody for their comments.""]** — Mówca: **Player**
> ""I just wanted to thank everybody for their comments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[122]`
Mówca: **Narrator**
> "I looked at him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`
  - -> `[125]`

### Węzeł `[123]`
**[WYBÓR GRACZA: ""It is you, who shouldn't use the word 'democratic' when you want a more centralized government.""]** — Mówca: **Player**
> ""It is you, who shouldn't use the word 'democratic' when you want a more centralized government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[124]`
**[WYBÓR GRACZA: ""We are not specifically cooperating with someone, but everyone. We ask that you also join us.""]** — Mówca: **Player**
> ""We are not specifically cooperating with someone, but everyone. We ask that you also join us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[125]`
**[WYBÓR GRACZA: ""I'm saddened to hear about your opposite stance.""]** — Mówca: **Player**
> ""I'm saddened to hear about your opposite stance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Narrator**
> "He watched as he slouched on his seat, legs crossed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`
  - -> `[129]`
  - -> `[130]`

### Węzeł `[127]`
**[WYBÓR GRACZA: ""Do not stand against change! Be a part of it, Mr. Kibener! We can do much more together.""]** — Mówca: **Player**
> ""Do not stand against change! Be a part of it, Mr. Kibener! We can do much more together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`
  - -> `[133]`
  - -> `[134]`

### Węzeł `[128]`
**[WYBÓR GRACZA: ""Don't you dare stand against us! Otherwise, know that the NFP is guaranteed to be history.""]** — Mówca: **Player**
> ""Don't you dare stand against us! Otherwise, know that the NFP is guaranteed to be history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`
  - -> `[133]`
  - -> `[134]`

### Węzeł `[129]`
**[WYBÓR GRACZA: ""I respect your opinion.""]** — Mówca: **Player**
> ""I respect your opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`
  - -> `[133]`
  - -> `[134]`

### Węzeł `[130]`
**[WYBÓR GRACZA: ""We don't need you.""]** — Mówca: **Player**
> ""We don't need you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`
  - -> `[133]`
  - -> `[134]`

### Węzeł `[131]`
**[WYBÓR GRACZA: ""I expect your support in the upcoming vote, Mr. Kibener.""]** — Mówca: **Player**
> ""I expect your support in the upcoming vote, Mr. Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[132]`
**[WYBÓR GRACZA: ""We will bring change regardless of your support.""]** — Mówca: **Player**
> ""We will bring change regardless of your support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[133]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[134]`
**[WYBÓR GRACZA: ""Your times have passed, Mr. Kibener.""]** — Mówca: **Player**
> ""Your times have passed, Mr. Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[135]`
Mówca: **Narrator**
> "Gloria looked at me to see if I'd finished my response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Response)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[140]`
  - -> `[143]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[143]`
**[WYBÓR GRACZA: ""Thank you, Mrs. Speaker.""]** — Mówca: **Player**
> ""Thank you, Mrs. Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Response])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[145]`
**[WYBÓR GRACZA: ""Rest assured, your concerns will be addressed.""]** — Mówca: **Player**
> ""Rest assured, your concerns will be addressed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`
  - -> `[149]`

### Węzeł `[146]`
Mówca: **Narrator**
> "I looked at him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[147]`
  - -> `[145]`

### Węzeł `[147]`
**[WYBÓR GRACZA: ""We'd like to have cooperation between our parties.""]** — Mówca: **Player**
> ""We'd like to have cooperation between our parties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Response])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[149]`
**[WYBÓR GRACZA: ""I welcome your positive attitude.""]** — Mówca: **Player**
> ""I welcome your positive attitude.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[150]`
**[WYBÓR GRACZA: ""I expect your support, Mr. Ricter! We can do much more together.""]** — Mówca: **Player**
> ""I expect your support, Mr. Ricter! We can do much more together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[151]`
**[WYBÓR GRACZA: ""Thank you for your support. We are looking forward to work with the PFJP.""]** — Mówca: **Player**
> ""Thank you for your support. We are looking forward to work with the PFJP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[152]`
**[WYBÓR GRACZA: ""Thank you for the nice words.""]** — Mówca: **Player**
> ""Thank you for the nice words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`
  - -> `[149]`

### Węzeł `[153]`
Mówca: **Narrator**
> "Gloria looked at me to see if I'd finished my response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[156]`
Mówca: **Gloria Tory**
> ""Alright, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Narrator**
> "MP's kept shouting and responding to each other, creating a loud mess where nothing was legible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Gloria Tory**
> ""Order! Order! This topic has finished. We are moving unto our next topic...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[159]`
Mówca: **Narrator**
> "I slowly left the hall. Thew shouting could be heard from every corridor of the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[160]`
Mówca: **Narrator**
> "I got up from my seat and started my walk towards the exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Speech_PromisedToTrySoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Narrator**
> "I slowly left the hall. The shouting could be heard from every corridor of the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[166]`
**[WYBÓR GRACZA: ""There is a victory growing with every morning...""]** — Mówca: **Player**
> ""There is a victory growing with every morning...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[169]`
  - -> `[168]`

### Węzeł `[167]`
**[WYBÓR GRACZA: "Salute the crowd."]** — Mówca: **Player_Italic**
> "I saluted the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`
  - -> `[48]`
  - -> `[49]`

### Węzeł `[168]`
**[WYBÓR GRACZA: ""There is my country beyond everything, my beloved...""]** — Mówca: **Player**
> ""There is my country beyond everything, my beloved...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[172]`
  - -> `[178]`

### Węzeł `[169]`
**[WYBÓR GRACZA: ""There is God beyond existence or nonexistence...""]** — Mówca: **Player**
> ""There is God beyond existence or nonexistence...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[172]`
  - -> `[178]`

### Węzeł `[170]`
**[WYBÓR GRACZA: ""Fear not when the dark falls! There is an artist painting the sun.""]** — Mówca: **Player**
> ""Fear not when the dark falls! There is an artist painting the sun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
**[WYBÓR GRACZA: ""Beyond the next morning, there is a victory waiting to be won.""]** — Mówca: **Player**
> ""Beyond the next morning, there is a victory waiting to be won.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[172]`
**[WYBÓR GRACZA: ""There is a spring that blossoms out of the graves of our fallen...""]** — Mówca: **Player**
> ""There is a spring that blossoms out of the graves of our fallen...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[170]`
  - -> `[175]`

### Węzeł `[173]`
**[WYBÓR GRACZA: ""There is a destiny above destiny...""]** — Mówca: **Player**
> ""There is a destiny above destiny...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[169]`
  - -> `[168]`

### Węzeł `[174]`
**[WYBÓR GRACZA: "Finish with a poem."]** — Mówca: **Player_Italic**
> "I decided to read a poem before I ended my speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[166]`

### Węzeł `[175]`
**[WYBÓR GRACZA: ""Do not dare to surrender! There is a victory that grows with defeat.""]** — Mówca: **Player**
> ""Do not dare to surrender! There is a victory that grows with defeat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[176]`
**[WYBÓR GRACZA: ""There are songs to be sung in affectation of our victories...""]** — Mówca: **Player**
> ""There are songs to be sung in affectation of our victories...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[170]`
  - -> `[175]`

### Węzeł `[177]`
**[WYBÓR GRACZA: ""There is a revolution that's coming...""]** — Mówca: **Player**
> ""There is a revolution that's coming...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[172]`
  - -> `[178]`

### Węzeł `[178]`
**[WYBÓR GRACZA: ""There is the evil that tortures and tears me down...""]** — Mówca: **Player**
> ""There is the evil that tortures and tears me down...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[170]`
  - -> `[175]`

### Węzeł `[179]`
**[WYBÓR GRACZA: ""Do not doubt the One! There is a decision coming from the heavens...""]** — Mówca: **Player**
> ""Do not doubt the One! There is a decision coming from the heavens...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced == true && BaseGame.Reform_Gloria_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced == true && BaseGame.Reform_Gloria_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Convinced"] == true  and  Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Albin_Convinced == true && BaseGame.Reform_Gloria_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Convinced"] == true  and  Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced == true || BaseGame.Reform_Gloria_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced == true || BaseGame.Reform_Gloria_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Convinced"] == true  or  Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Albin_Convinced == true || BaseGame.Reform_Gloria_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Convinced"] == true  or  Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Holsord_ReformStatus_None = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_ReformStatus_None"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Holsord_ReformStatus_GloriaAlbin = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_ReformStatus_GloriaAlbin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Holsord_ReformStatus_Both = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_ReformStatus_Both"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Uziren_BorderReport = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Uziren_BorderReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_HeljilandRecognised == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_G_WalkerWarnsNavy = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_G_WalkerWarnsNavy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn05_A_Speech = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn05_A_Speech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_ST_SCTooMuchPower_R = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_SCTooMuchPower_R"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_HP_ConstitutionNotAdequate_R = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_ConstitutionNotAdequate_R"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_RemoveDecrees == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_RemoveDecrees == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_RemoveDecrees"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_A_Speech_RemoveDecrees == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_RemoveDecrees"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_SeparationofPowers == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_SeparationofPowers == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_SeparationofPowers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_A_Speech_SeparationofPowers == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_SeparationofPowers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_HP_AssemblyOvershadowed_R = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_AssemblyOvershadowed_R"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_LT_RemoveDecrees_R = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_RemoveDecrees_R"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_HP_ElectionThreshold_R = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_ElectionThreshold_R"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_PresidentTooPower == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_PresidentTooPower == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_PresidentTooPower"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_A_Speech_PresidentTooPower == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_PresidentTooPower"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_HP_PresidentTooPowerful_R = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_PresidentTooPowerful_R"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_SeparationofPowers = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_SeparationofPowers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Speech_PromisedToTrySoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_R_PromisedToTrySoll = true;
BaseGame.Public_Opinion -= 3;
BaseGame.Bludish_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_R_PromisedToTrySoll"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_ST_PromisedToTrySoll_NoDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_PromisedToTrySoll_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true && BaseGame.Media_SordlandToday_Bias == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true && BaseGame.Media_SordlandToday_Bias == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Speech_PromisedToTrySoll == true && BaseGame.Media_SordlandToday_Bias == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_PresidentTooPower = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_PresidentTooPower"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_RemoveDecrees = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_RemoveDecrees"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[237]`
**[WYBÓR GRACZA: ""I'll act as if that didn't happen.""]** — Mówca: **Player**
> ""I'll act as if that didn't happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[238]`
**[WYBÓR GRACZA: ""Who are you trying to provoke, Mrs. Tory? USP is behind me.""]** — Mówca: **Player**
> ""Who are you trying to provoke, Mrs. Tory? USP is behind me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[239]`
**[WYBÓR GRACZA: ""That was disrespectful Mrs. Speaker. Please don't try to sabotage my speech.""]** — Mówca: **Player**
> ""That was disrespectful Mrs. Speaker. Please don't try to sabotage my speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[240]`
**[WYBÓR GRACZA: ""We are not here to destroy Sollism nor our cultural values.""]** — Mówca: **Player**
> ""We are not here to destroy Sollism nor our cultural values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Speech_PromisedToTrySoll == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[244]`
Mówca: **Gloria Tory**
> ""You've just promised to try Soll, Mr. President! You are talking about the founder of this party. He is the true founder of this republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Gloria Tory**
> ""What crimes are you talking about? You owe everything you have to him. This is unacceptable!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[246]`
Mówca: **Narrator**
> "Loud noises came from USP and NFP seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`
  - -> `[250]`

### Węzeł `[247]`
**[WYBÓR GRACZA: ""Everyone! Please! Let me finish.""]** — Mówca: **Player**
> ""Everyone! Please! Let me finish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[248]`
**[WYBÓR GRACZA: ""Hear me out.""]** — Mówca: **Player**
> ""Hear me out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[249]`
Mówca: **Gloria Tory**
> ""Please continue your speech, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[250]`
**[WYBÓR GRACZA: ""Let me explain.""]** — Mówca: **Player**
> ""Let me explain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Speech_PromisedToTrySoll == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[254]`
Mówca: **Narrator**
> "The whole United Sordland Party stood up and started shouting at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[255]`
Mówca: **Gloria Tory**
> ""Your time is finished. Please take your seat, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyShouting");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyShouting");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyApplause");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyApplause");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyApplause");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyApplause");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyApplause");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyApplause");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyLoud");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyLoud");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyLoud");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyLoud");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("VoteRoar");)*
- **Efekt (`userScript`):** `PlaySoundEffect("VoteRoar");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyApplause2");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyApplause2");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyApplauseShouting");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyApplauseShouting");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
