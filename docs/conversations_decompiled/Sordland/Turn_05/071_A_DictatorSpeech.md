# Sordland/Turn05/A_DictatorSpeech

- **ID konwersacji:** `71`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/071_A_DictatorSpeech.md`
- **Liczba węzłów dialogowych:** 274
- **Liczba wyborów gracza:** 84

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
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Threshold_8`
- `BaseGame.Speech_PromisedToTrySoll`
- `BaseGame.Wehlen_TradeDeal`
- `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A`
- `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B`
- `BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed`
- `BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard`
- `BaseGameIsolated.Turn05_A_Speech_SeparationofPowers`
- `BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive`
- `BaseGameIsolated.Turn05_A_Speech_StrongerDecrees`
- `BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Public_Opinion`
- `BaseGame.Sollist`
- `BaseGame.Speech_PromisedToTrySoll`
- `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A`
- `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B`
- `BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard`
- `BaseGameIsolated.Turn05_A_Speech_SeparationofPowers`
- `BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive`
- `BaseGameIsolated.Turn05_A_Speech_StrongerDecrees`
- `BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower`
- `BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy`
- `BaseGameSupport.News_Turn05_G_WalkerWarnsNavy`
- `BaseGameSupport.News_Turn05_HP_ConstitutionNotAdequate_D`
- `BaseGameSupport.News_Turn05_HP_ElectionThreshold_D`
- `BaseGameSupport.News_Turn05_HP_StrongerExecutive_D`
- `BaseGameSupport.News_Turn05_LT_StrongerDecrees_D`
- `BaseGameSupport.News_Turn05_R_PromisedToTrySoll`
- `BaseGameSupport.News_Turn05_ST_OvershadowedByOldGuard_D`
- `BaseGameSupport.News_Turn05_ST_PromisedToTrySoll_NoDeal`
- `BaseGameSupport.News_Turn05_ST_SCTooMuchPower_D`
- `BaseGameSupport.Report_Turn05_Holsord_ReformStatus_Both`
- `BaseGameSupport.Report_Turn05_Holsord_ReformStatus_GloriaAlbin`
- `BaseGameSupport.Report_Turn05_Holsord_ReformStatus_None`
- `BaseGameSupport.Report_Turn05_Uziren_BorderReport`
- `GameCondition.Turn05_A_Speech`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 8
- **Węzły modyfikujące stan gry:** 33

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Sollist`
- `BaseGame.Speech_PromisedToTrySoll`
- `BaseGameIsolated.Turn05_A_Speech_StrongerDecrees`
- `BaseGameSupport.News_Turn05_G_WalkerWarnsNavy`
- `BaseGameSupport.News_Turn05_LT_StrongerDecrees_D`
- `BaseGameSupport.News_Turn05_R_PromisedToTrySoll`
- `BaseGameSupport.News_Turn05_ST_PromisedToTrySoll_NoDeal`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[103]` (Paskal Beniwoll): `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 10;`
- Węzeł `[117]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A"] = true;`
- Węzeł `[119]` (Paskal Beniwoll): `Variable["BaseGame.Speech_PromisedToTrySoll"] = true;`
- Węzeł `[140]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B"] = true;`
- Węzeł `[191]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn05_Holsord_ReformStatus_None"] = true;`
- Węzeł `[192]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn05_Holsord_ReformStatus_Both"] = true;`
- Węzeł `[193]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn05_Holsord_ReformStatus_GloriaAlbin"] = true;`
- Węzeł `[197]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn05_Uziren_BorderReport"] = true;`
- *...oraz 25 innych węzłów ze skryptami.*

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
  - -> `[268]`

### Węzeł `[5]`
Mówca: **Narrator**
> "When I entered the hall, the Assembly was in complete chaos, with shouting and cursing between the parties. There was a heavy argument about a proposal made by an MP from NFP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
**[WYBÓR GRACZA: ""We both know that our Constitution is flawed.""]** — Mówca: **Player**
> ""We both know that our Constitution is flawed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[7]`
Mówca: **Narrator**
> "I took my seat inside the special area reserved for the ministers. Gloria was shouting from her seat at the centre of the hall as she hit the gavel three times, with each strike heavier than the one before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Gloria Tory**
> "<shout>"ORDER! ORDER!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[9]`
**[WYBÓR GRACZA: ""We must finally rewrite the Constitution of Soll and break our chains of the past!""]** — Mówca: **Player**
> ""We must finally rewrite the Constitution of Soll and break our chains of the past!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`
  - -> `[246]`

### Węzeł `[10]`
Mówca: **Narrator**
> "Despite her efforts, the argument continued for a couple of minutes before everybody took back to their seats and finally went quiet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Gloria Tory**
> ""Mr. Kibener, next time when I tell you to do so, either take your seat or leave the hall; so we can proceed with the procedures of this Assembly and continue our duties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Narrator**
> "He murmured something from his seat which was illegible from my position."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[71]`
  - -> `[75]`
  - -> `[73]`

### Węzeł `[13]`
Mówca: **Narrator**
> "Some MP's from the NFP side shouted back at her in protest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""We are not specifically cooperating with someone, but everyone. We ask that you also join us.""]** — Mówca: **Player**
> ""We are not specifically cooperating with someone, but everyone. We ask that you also join us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[33]`
  - -> `[22]`
  - -> `[28]`

### Węzeł `[15]`
Mówca: **Gloria Tory**
> ""Honorable ladies and gentlemen, if you allow me to continue...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[16]`
Mówca: **Narrator**
> "I looked at him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[14]`
  - -> `[19]`

### Węzeł `[17]`
Mówca: **Gloria Tory**
> ""We have the President here with us today. He has asked to give an important announcement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[18]`
Mówca: **Narrator**
> "I saw Kesaro Kibener standing up from his seat and shouting towards the members of the PFJP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
**[WYBÓR GRACZA: ""I'm saddened to hear about your opposite stance.""]** — Mówca: **Player**
> ""I'm saddened to hear about your opposite stance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[33]`
  - -> `[22]`
  - -> `[28]`

### Węzeł `[20]`
Mówca: **Gloria Tory**
> ""Mr. Kibener! Calm yourself! Show respect to the procedures of this Assembly!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Response])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[22]`
**[WYBÓR GRACZA: ""I respect your opinion.""]** — Mówca: **Player**
> ""I respect your opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[23]`
Mówca: **Narrator**
> "She pointed at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""Thank you, Mrs. Speaker.""]** — Mówca: **Player**
> ""Thank you, Mrs. Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Do not stand against change! Be a part of it, Mr. Ricter! We can do much more together.""]** — Mówca: **Player**
> ""Do not stand against change! Be a part of it, Mr. Ricter! We can do much more together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[26]`
Mówca: **Gloria Tory**
> ""You have the floor, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[27]`
Mówca: **Narrator**
> "The Assembly fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[28]`
**[WYBÓR GRACZA: ""We don't need you.""]** — Mówca: **Player**
> ""We don't need you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[32]`
Mówca: **Narrator**
> "I walked to the stand as loud clapping started in the USP's side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[78]`
  - -> `[80]`

### Węzeł `[33]`
**[WYBÓR GRACZA: ""Don't you dare stand against us! Otherwise, know that the PFJP is guaranteed to be history.""]** — Mówca: **Player**
> ""Don't you dare stand against us! Otherwise, know that the PFJP is guaranteed to be history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[34]`
**[WYBÓR GRACZA: ""Ladies and Gentlemen...""]** — Mówca: **Player**
> ""Ladies and Gentlemen of the Grand National Assembly of Sordland! I am here today to raise important questions regarding our outdated Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[83]`
  - -> `[86]`
  - -> `[92]`

### Węzeł `[35]`
**[WYBÓR GRACZA: ""It is you, who shouldn't use the word 'democratic' when you want your way to succeed but disregard our opinion.""]** — Mówca: **Player**
> ""It is you, who shouldn't use the word 'democratic' when you want your way to succeed but disregard our opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[33]`
  - -> `[22]`
  - -> `[28]`

### Węzeł `[36]`
**[WYBÓR GRACZA: ""The Supreme Court holds too much power...""]** — Mówca: **Player**
> ""The Supreme Court holds too much power over our elected branches! They have been obstructing the law making process and has long plagued the democracy in Sordland. Tarquin Soll gave this power to the Court for the sole reason to protect the Constitution of the 20's, which leads us to fail in adapting to the new world...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[37]`
**[WYBÓR GRACZA: ""Our election threshold has harmed our democracy more than anything...""]** — Mówca: **Player**
> ""Our election threshold has harmed our democracy more than anything since the formation of our republic. As USP, we have governed for a long time and I can acknowledge that this success was partly the result of our current 10% percent threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""It is time to strengthen the executive to enact faster and more powerful reforms!""]** — Mówca: **Player**
> ""It is time to strengthen the executive to enact faster and more powerful reforms!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[39]`
Mówca: **Narrator**
> "I continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[9]`
  - -> `[95]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[43]`
**[WYBÓR GRACZA: ""...Therefore, we propose changes to the Constitution to prepare Sordland for a fast changing new world!""]** — Mówca: **Player**
> ""...Therefore, we propose changes to the Constitution to prepare Sordland for a fast changing new world!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`
  - -> `[246]`

### Węzeł `[44]`
**[WYBÓR GRACZA: ""We will break the Supreme Court's authority over constitutional changes.""]** — Mówca: **Player**
> ""We will break the Supreme Court's authority over constitutional changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[45]`
**[WYBÓR GRACZA: ""I will break down the obstacles before me!""]** — Mówca: **Player**
> ""I will break down the obstacles before me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[46]`
**[WYBÓR GRACZA: ""We will rebalance the branches of government to ensure a more democratic process.""]** — Mówca: **Player**
> ""We will rebalance the branches of government to ensure a more democratic process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Gloria_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "Unity."]** — Mówca: **Player**
> ""It is more important than ever that we stand united as a nation in these changing times. I call everybody to be part of the change our people has been calling for. We all want to make Sordland better, don't we? Let's embrace democracy and unite under the banner of our people, and surely Sordland will be great again!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[126]`
  - -> `[131]`
  - -> `[132]`

### Węzeł `[51]`
Mówca: **Narrator**
> "Loud noises came from USP and NFP seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[52]`
Mówca: **Gloria Tory**
> ""Mr. President, with all due respect, I believe Sordland already has a functioning Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`
  - -> `[6]`
  - -> `[137]`

### Węzeł `[53]`
**[WYBÓR GRACZA: ""Please don't interrupt me.""]** — Mówca: **Player**
> ""Please don't interrupt me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[54]`
**[WYBÓR GRACZA: ""I'm not finished yet, Mrs. Tory.""]** — Mówca: **Player**
> ""I'm not finished yet, Mrs. Tory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[55]`
**[WYBÓR GRACZA: ""Ladies and gentlemen of the Assembly! We must set aside our differences.""]** — Mówca: **Player**
> ""Ladies and gentlemen of the Assembly! We must set aside our differences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[63]`
  - -> `[61]`

### Węzeł `[56]`
Mówca: **Narrator**
> "I took a breath and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[58]`
  - -> `[59]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Response)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[29]`
  - -> `[24]`

### Węzeł `[58]`
**[WYBÓR GRACZA: ""It is time to make a new Constitution together!""]** — Mówca: **Player**
> ""It is time to make a new Constitution together!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[63]`
  - -> `[61]`

### Węzeł `[59]`
**[WYBÓR GRACZA: ""I ask everyone to think clearly about our current situation. And join us for change.""]** — Mówca: **Player**
> ""I ask everyone to think clearly about our current situation. And join us for change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[63]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Narrator**
> "Gloria looked at me to see if I'd finished my response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[61]`
**[WYBÓR GRACZA: ""Ladies and Gentlemen, I demand your votes!""]** — Mówca: **Player**
> ""Ladies and Gentlemen, I demand your votes!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[62]`
  - -> `[65]`
  - -> `[66]`

### Węzeł `[62]`
**[WYBÓR GRACZA: ""Let's write the future together!""]** — Mówca: **Player**
> ""Let's write the future together!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""I ask everyone to support us in the upcoming vote.""]** — Mówca: **Player**
> ""I ask everyone to support us in the upcoming vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[62]`
  - -> `[65]`
  - -> `[66]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""Be part of a new era for Sordland. Join us and vote for our proposal.""]** — Mówca: **Player**
> ""Be part of a new era for Sordland. Join us and vote for our proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[62]`
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
**[WYBÓR GRACZA: ""I will address all the problems of the past in my proposal!""]** — Mówca: **Player**
> ""I will address all the problems of the past in my proposal!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[66]`
**[WYBÓR GRACZA: ""USP will change and lead Sordland into the future!""]** — Mówca: **Player**
> ""USP will change and lead Sordland into the future!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""For justice in Sordland!""]** — Mówca: **Player**
> ""For justice in Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[68]`
Mówca: **Narrator**
> "Gloria looked at me to see if I'd finished my response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[69]`
**[WYBÓR GRACZA: ""For a strong Sordland!""]** — Mówca: **Player**
> ""For a strong Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[70]`
**[WYBÓR GRACZA: ""For a united Sordland!""]** — Mówca: **Player**
> ""For a united Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[71]`
**[WYBÓR GRACZA: ""We will bring change regardless of your support.""]** — Mówca: **Player**
> ""We will bring change regardless of your support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[72]`
**[WYBÓR GRACZA: ""For a free Sordland!""]** — Mówca: **Player**
> ""For a free Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
**[WYBÓR GRACZA: ""Your times have passed, Mr. Ricter.""]** — Mówca: **Player**
> ""Your times have passed, Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[74]`
Mówca: **Narrator**
> "The Assembly roared with all kinds of different reactions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[75]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[76]`
Mówca: **Frens Ricter**
> ""Thank you, Mrs. Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[77]`
Mówca: **Gloria Tory**
> ""Thank you for the speech, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[78]`
**[WYBÓR GRACZA: ""Honorable Members of Assembly...""]** — Mówca: **Player**
> ""Honorable Members of the Grand National Assembly of Sordland! I am here today to raise important questions regarding our outdated Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[83]`
  - -> `[86]`
  - -> `[92]`

### Węzeł `[79]`
**[WYBÓR GRACZA: ""I expect your support in the upcoming vote, Mr. Ricter.""]** — Mówca: **Player**
> ""I expect your support in the upcoming vote, Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[80]`
**[WYBÓR GRACZA: ""Brothers and sisters...""]** — Mówca: **Player**
> ""Brothers and sisters! I am here today to raise important questions regarding our outdated Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[83]`
  - -> `[86]`
  - -> `[92]`

### Węzeł `[81]`
Mówca: **Kesaro Kibener**
> ""We will stand together with any attempt to protect and strengthen our established political culture and national values. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[82]`
Mówca: **Frens Ricter**
> ""Thank you, Mrs. Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_8 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_8 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_8 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_8"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Narrator**
> "MP's kept shouting and responding to each other, creating a loud mess where nothing was legible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
**[WYBÓR GRACZA: ""Our Constitution doesn't adequately define or respect the separation of powers...""]** — Mówca: **Player**
> ""Our Constitution doesn't adequately define or respect the separation of powers and the balance between the branches. In order to strengthen our democracy, we must be brave enough to point out the faults of our Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[91]`
Mówca: **Gloria Tory**
> ""Order! Order! This topic has finished. We are moving unto our next topic...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[92]`
**[WYBÓR GRACZA: ""We have always been overshadowed by the Old Guard...""]** — Mówca: **Player**
> ""We have always been overshadowed by the Old Guard and the judiciary branch in Sordland. The Grand National Assembly and the President must be able to exercise their job properly and without obstruction. However, our current Constitution fails to guarantee this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[93]`
Mówca: **Frens Ricter**
> ""I ask Mr. President to reevaluate his decision and not ignore the demands of our people! Otherwise you should never use the word 'democratic' again!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[94]`
Mówca: **Narrator**
> "I slowly left the hall. The shouting could be heard from every corridor of the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[95]`
**[WYBÓR GRACZA: ""I call everyone to stand by us to make historic changes to our Constitution and bring it to the standards of today's world!""]** — Mówca: **Player**
> ""I call everyone to stand by us to make historic changes to our Constitution and bring it to the standards of today's world!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`
  - -> `[246]`

### Węzeł `[96]`
Mówca: **Frens Ricter**
> ""As long as Mr. President continues to follow the footsteps of his party's founder, we will be doing our best to stop this proposal. We do not welcome this attempt to break our system further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[97]`
Mówca: **Narrator**
> "I looked at him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[179]`
  - -> `[178]`

### Węzeł `[98]`
Mówca: **Narrator**
> "I got up from my seat and started my walk towards the exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[99]`
**[WYBÓR GRACZA: ""I just wanted to thank everybody for their comments.""]** — Mówca: **Player**
> ""I just wanted to thank everybody for their comments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[100]`
Mówca: **Narrator**
> "I focused on..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[104]`
  - -> `[105]`
  - -> `[159]`

### Węzeł `[101]`
Mówca: **Frens Ricter**
> ""However, our demands seemed to be ignored by the government. Even though we made the reform committee's work possible, it was us, who were pushed back from the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[102]`
**[WYBÓR GRACZA: ""Mr. Ricter...""]** — Mówca: **Player**
> ""Mr. Ricter...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Sollist -= 10)*
- **Efekt (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[104]`
**[WYBÓR GRACZA: "Change."]** — Mówca: **Player**
> ""We must not be afraid of change. The world is changing, and Sordland needs the change it has earned after years of Sollism in the last decades. We will rewrite the old and make a constitution that would reflect the will of the people, and open the way for a democratic Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[126]`
  - -> `[131]`
  - -> `[132]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "Peace."]** — Mówca: **Player**
> ""The '29 Constitution was the product of a time of war. Now is a time for peace. As we must make peace between each other, we must strive for peace in the world. We need a more democratic constitution that would reflect the will of the people, and flourish in the upcoming times of peace and prosper!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[126]`
  - -> `[131]`
  - -> `[132]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""Mr. Kibener...""]** — Mówca: **Player**
> ""Mr. Kibener...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[107]`
Mówca: **Frens Ricter**
> ""I would like to thank Mr. President for his speech. We, the People's Freedom and Justice Party, stands in agreement with the need for a new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[108]`
Mówca: **Gloria Tory**
> ""Yes, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[102]`
  - -> `[99]`

### Węzeł `[109]`
Mówca: **Narrator**
> "Just as I was about to continue speaking, Gloria Tory interrupted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[110]`
Mówca: **Narrator**
> "I got up from my seat and started my walk towards the exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[111]`
Mówca: **Kesaro Kibener**
> "<shout>"You and PFJP are nothing but puppets of western interests!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[112]`
Mówca: **Narrator**
> "I walked back to my seat as many MP's asked to speak. Frens Ricter was among them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Narrator**
> "Suddenly Kesaro Kibener started yelling from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[114]`
Mówca: **Gloria Tory**
> ""Yes, Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "Ask to speak."]** — Mówca: **Player_Italic**
> "I asked to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "Leave the Assembly."]** — Mówca: **Player_Italic**
> "I decided to leave the Assembly and its chaos behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[118]`
Mówca: **Narrator**
> "Kesaro went back to his seat but the chaos in the Assembly continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[120]`
Mówca: **Kesaro Kibener**
> ""Mr. President!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Abolished == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[124]`
**[WYBÓR GRACZA: ""Tarquin Soll will answer for the crimes committed during his rule! We will make sure of that!""]** — Mówca: **Player**
> ""Tarquin Soll will answer for the crimes committed during his rule! We will make sure of that!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[125]`
Mówca: **Narrator**
> "Gloria gave him a stare. She looked annoyed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[129]`
**[WYBÓR GRACZA: ""We will be strengthening the presidential decrees.""]** — Mówca: **Player**
> ""We will be strengthening the presidential decrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[130]`
Mówca: **Narrator**
> "He looked directly at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[131]`
**[WYBÓR GRACZA: ""We will make Sordland great again!""]** — Mówca: **Player**
> ""We will make Sordland great again!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[132]`
**[WYBÓR GRACZA: ""Let's embrace the future.""]** — Mówca: **Player**
> ""Let's embrace the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[133]`
Mówca: **Narrator**
> "Some applauses came from the NFP and USP seats. Most of the others started to make loud noises again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[134]`
Mówca: **Kesaro Kibener**
> ""Let it be known that the NFP will do its best to aid with the draft of the new constitution, and to reach an agreement with the USP. If our concerns are listened to, NFP has the power to make this proposal pass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[135]`
Mówca: **Kesaro Kibener**
> "<shout>"You must have lost your mind to claim you were the reason for the reform talks, Mr. Ricter!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[136]`
Mówca: **Kesaro Kibener**
> ""The nationalist movement wants to thank Mr. Rayne for his priorities. The National Front Party will not stand in your way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[137]`
**[WYBÓR GRACZA: ""You don't believe that.""]** — Mówca: **Player**
> ""You don't believe that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Narrator**
> "The whole United Sordland Party stood up and started applauding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[139]`
Mówca: **Gloria Tory**
> ""Tarquin Soll and his efforts cannot be ignored. We must keep following the path he defined for Sordish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[141]`
**[WYBÓR GRACZA: ""We are not here to destroy Sollism nor our cultural values.""]** — Mówca: **Player**
> ""We are not here to destroy Sollism nor our cultural values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[142]`
Mówca: **Narrator**
> "I slowly left the hall. The shouting could be heard from every corridor of the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[143]`
Mówca: **Gloria Tory**
> ""...Very well, Mr. Kibener... Go ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[144]`
Mówca: **Gloria Tory**
> ""I'm sure the Honorable Members of USP will see that the President is acting rash by allying with the opposition to destroy the culture of Sollism that established Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Gloria Tory**
> ""Alright, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[146]`
Mówca: **Gloria Tory**
> ""That was the extent of my quick note. Thank you. The President has the floor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[141]`
  - -> `[153]`
  - -> `[157]`

### Węzeł `[147]`
Mówca: **Kesaro Kibener**
> ""I demand to speak!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[148]`
**[WYBÓR GRACZA: ""That was disrespectful Mrs. Speaker. Please don't try to sabotage my speech.""]** — Mówca: **Player**
> ""That was disrespectful Mrs. Speaker. Please don't try to sabotage my speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true && BaseGame.Reform_Albin_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true && BaseGame.Reform_Albin_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true  and  Variable["BaseGame.Reform_Albin_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Gloria_Convinced == true && BaseGame.Reform_Albin_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true  and  Variable["BaseGame.Reform_Albin_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[152]`
Mówca: **Gloria Tory**
> "<shout>"ORDER!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[153]`
**[WYBÓR GRACZA: ""Who are you trying to provoke, Mrs. Tory? USP is behind me.""]** — Mówca: **Player**
> ""Who are you trying to provoke, Mrs. Tory? USP is behind me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Speech_PromisedToTrySoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[157]`
**[WYBÓR GRACZA: ""I'll act as if that didn't happen.""]** — Mówca: **Player**
> ""I'll act as if that didn't happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[158]`
Mówca: **Gloria Tory**
> ""Please continue your speech, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[159]`
**[WYBÓR GRACZA: "War."]** — Mówca: **Player**
> ""It is a time of conflict and war. The superpowers of the world are in a race to control the world. Terrorists and rebels around our borders continue to operate. We must be ready for what this new world will throw at us. We must be vigilant! More importantly, Rumburg is threatening our country more than ever. We need a stronger constitution that would strengthen our nation and prepare it for the upcoming times of conflict. And we will prevail!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[126]`
  - -> `[131]`
  - -> `[132]`

### Węzeł `[160]`
**[WYBÓR GRACZA: ""Give me the power to make Sordland great again!""]** — Mówca: **Player**
> ""Give me the power to make Sordland great again!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[164]`
**[WYBÓR GRACZA: "Salute the crowd."]** — Mówca: **Player_Italic**
> "I saluted the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[69]`
  - -> `[70]`
  - -> `[72]`

### Węzeł `[165]`
**[WYBÓR GRACZA: "Finish with a poem."]** — Mówca: **Player_Italic**
> "I decided to read a poem before I ended my speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
**[WYBÓR GRACZA: ""There is a destiny above destiny...""]** — Mówca: **Player**
> ""There is a destiny above destiny...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`
  - -> `[168]`

### Węzeł `[167]`
**[WYBÓR GRACZA: ""There is a victory growing with every morning...""]** — Mówca: **Player**
> ""There is a victory growing with every morning...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`
  - -> `[168]`

### Węzeł `[168]`
**[WYBÓR GRACZA: ""There is my country, beyond my existence or nonexistence...""]** — Mówca: **Player**
> ""There is my country, beyond my existence or nonexistence...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`
  - -> `[171]`

### Węzeł `[169]`
**[WYBÓR GRACZA: ""There is a revolution, beyond our and their existence...""]** — Mówca: **Player**
> ""There is a revolution, beyond our and their existence...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`
  - -> `[171]`

### Węzeł `[170]`
**[WYBÓR GRACZA: ""There is God, beyond existence and nonexistence...""]** — Mówca: **Player**
> ""There is God, beyond existence and nonexistence...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`
  - -> `[171]`

### Węzeł `[171]`
**[WYBÓR GRACZA: ""There is the evil that tortures and tears me down...""]** — Mówca: **Player**
> ""There is the evil that tortures and tears me down...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`
  - -> `[176]`

### Węzeł `[172]`
**[WYBÓR GRACZA: ""There are songs to be sung in affectation of our battles...""]** — Mówca: **Player**
> ""There are songs to be sung in affectation of our battles...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`
  - -> `[176]`

### Węzeł `[173]`
**[WYBÓR GRACZA: ""There is a spring that blossoms out of the graves of our fallen...""]** — Mówca: **Player**
> ""There is a spring that blossoms out of the graves of our fallen...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`
  - -> `[176]`

### Węzeł `[174]`
**[WYBÓR GRACZA: ""Do not doubt the One! There is a decision coming from the heavens...""]** — Mówca: **Player**
> ""Do not doubt the One! There is a decision coming from the heavens...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[175]`
**[WYBÓR GRACZA: ""Fear not when the dark falls! There is an artist painting the sun.""]** — Mówca: **Player**
> ""Fear not when the dark falls! There is an artist painting the sun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
**[WYBÓR GRACZA: ""Do not dare call it defeat! There is a fortress made from my ashes.""]** — Mówca: **Player**
> ""Do not dare call it defeat! There is a fortress made from my ashes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
**[WYBÓR GRACZA: ""Beyond the next morning, there is a victory waiting to be won.""]** — Mówca: **Player**
> ""Beyond the next morning, there is a victory waiting to be won.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[178]`
**[WYBÓR GRACZA: ""Rest assured, your concerns will be addressed.""]** — Mówca: **Player**
> ""Rest assured, your concerns will be addressed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[181]`
  - -> `[180]`

### Węzeł `[179]`
**[WYBÓR GRACZA: ""We'd like to have cooperation between our parties.""]** — Mówca: **Player**
> ""We'd like to have cooperation between our parties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[181]`
  - -> `[180]`

### Węzeł `[180]`
**[WYBÓR GRACZA: ""I welcome your positive attitude.""]** — Mówca: **Player**
> ""I welcome your positive attitude.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[181]`
**[WYBÓR GRACZA: ""Thank you for your support. We are looking forward to work with the NFP.""]** — Mówca: **Player**
> ""Thank you for your support. We are looking forward to work with the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[182]`
**[WYBÓR GRACZA: ""Thank you for the nice words.""]** — Mówca: **Player**
> ""Thank you for the nice words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[181]`
  - -> `[180]`

### Węzeł `[183]`
**[WYBÓR GRACZA: ""I expect your support, Mr. Kibener! We can do much more together.""]** — Mówca: **Player**
> ""I expect your support, Mr. Kibener! We can do much more together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Response])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced == true || BaseGame.Reform_Gloria_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced == true || BaseGame.Reform_Gloria_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Convinced"] == true  or  Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Albin_Convinced == true || BaseGame.Reform_Gloria_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Convinced"] == true  or  Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced == true && BaseGame.Reform_Gloria_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced == true && BaseGame.Reform_Gloria_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Convinced"] == true  and  Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Albin_Convinced == true && BaseGame.Reform_Gloria_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Convinced"] == true  and  Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Holsord_ReformStatus_None = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_ReformStatus_None"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Holsord_ReformStatus_Both = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_ReformStatus_Both"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Holsord_ReformStatus_GloriaAlbin = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_ReformStatus_GloriaAlbin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Uziren_BorderReport = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Uziren_BorderReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_HeljilandRecognised == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_G_WalkerWarnsNavy = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_G_WalkerWarnsNavy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_SeparationofPowers = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_SeparationofPowers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_StrongerDecrees = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_StrongerDecrees"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn05_A_Speech = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn05_A_Speech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_StrongerDecrees == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_StrongerDecrees == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_StrongerDecrees"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_A_Speech_StrongerDecrees == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_StrongerDecrees"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_LT_StrongerDecrees_D = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_StrongerDecrees_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_HP_ElectionThreshold_D = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_ElectionThreshold_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_ST_OvershadowedByOldGuard_D = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_OvershadowedByOldGuard_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_SeparationofPowers == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_SeparationofPowers == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_SeparationofPowers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_A_Speech_SeparationofPowers == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_SeparationofPowers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_HP_ConstitutionNotAdequate_D = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_ConstitutionNotAdequate_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_HP_StrongerExecutive_D = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_StrongerExecutive_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_ST_SCTooMuchPower_D = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_SCTooMuchPower_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Speech_PromisedToTrySoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_R_PromisedToTrySoll = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_R_PromisedToTrySoll"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true && BaseGame.Media_SordlandToday_Bias == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true && BaseGame.Media_SordlandToday_Bias == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Speech_PromisedToTrySoll == true && BaseGame.Media_SordlandToday_Bias == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_ST_PromisedToTrySoll_NoDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_PromisedToTrySoll_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 3;
BaseGame.Bludish_Opinion += 5;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Speech_PromisedToTrySoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Speech_PromisedToTrySoll == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[252]`
Mówca: **Gloria Tory**
> ""You've just promised to try Soll, Mr. President! You are talking about the founder of this party. He is the true founder of this republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[253]`
Mówca: **Gloria Tory**
> ""What crimes are you talking about? You owe everything you have to him. This is unacceptable!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[254]`
Mówca: **Narrator**
> "Loud noises came from USP and NFP seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[255]`
  - -> `[257]`

### Węzeł `[255]`
**[WYBÓR GRACZA: ""Hear me out.""]** — Mówca: **Player**
> ""Hear me out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[256]`
**[WYBÓR GRACZA: ""Everyone! Please! Let me finish.""]** — Mówca: **Player**
> ""Everyone! Please! Let me finish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[257]`
**[WYBÓR GRACZA: ""Let me explain.""]** — Mówca: **Player**
> ""Let me explain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Speech_PromisedToTrySoll == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[261]`
Mówca: **Narrator**
> "The whole United Sordland Party stood up and started shouting at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Gloria Tory**
> ""Your time is over. Please sit down, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Speech_PromisedToTrySoll == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[266]`
Mówca: **Frens Ricter**
> ""Despite Mr. President here claiming to serve justice by going against his party's founder, we know this to be some hogwash! Know that we will be doing our best to stop this proposal. We do not welcome this attempt to break our system further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyShouting");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyShouting");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyLoud");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyLoud");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyLoud");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyLoud");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("VoteRoar");)*
- **Efekt (`userScript`):** `PlaySoundEffect("VoteRoar");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyApplause");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyApplause");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyApplauseShouting");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyApplauseShouting");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
