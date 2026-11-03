# Sordland/Turn08/GLORIA FEEDBACK

- **ID konwersacji:** `173`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/173_GLORIA_FEEDBACK.md`
- **Liczba węzłów dialogowych:** 252
- **Liczba wyborów gracza:** 54

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[34]** Gloria Tory

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Reform_Heron_PromisedChiefJustice`
- `BaseGame.Turn07_Results_Focus_Campaign`
- `BaseGame.Turn07_Results_Focus_Economy`
- `BaseGame.Turn07_SecretState_Detained_FrensRicter`
- `BaseGame.Turn07_SecretState_Detained_KesaroKibener`
- `BaseGame.Turn07_SecretState_Kill_FrensRicter`
- `BaseGame.Turn07_SecretState_Kill_KesaroKibener`
- `BaseGame.Turn08_Action_Campaign_ExtraBudget`
- `BaseGame.Turn08_Action_Court_ExperiencedJustice`
- `BaseGame.Turn08_Action_Court_LoyalJustice`
- `BaseGame.Turn08_Action_Court_OldGuardReplaced`
- `BaseGame.Turn08_Action_Court_Shuffled`
- `BaseGame.Turn08_Action_Party_Conservative`
- `BaseGame.Turn08_Action_Party_Liberal`
- `BaseGame.Turn08_Action_Party_Socialist`
- `BaseGame.Turn08_Action_Party_Ultranationalist`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Bergia_Governor_Ersen`
- `BaseGame.Bergia_Governor_Krull`
- `BaseGame.Public_Opinion`
- `BaseGameIsolated.PoliticalOverview2_TvAd`
- `BaseGameSupport.Codex_Characters_Others_IshvalErsen`
- `BaseGameSupport.Codex_Characters_StateFigures_IshvalErsen_SpecialZone`
- `BaseGameSupport.Codex_Characters_StateFigures_PhelixBron`
- `BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_ReplacedByOvidGrecer`
- `BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Bron`
- `BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Ersen`
- `BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty`
- `BaseGameSupport.News_Turn08_R_OvidGrecerFindsBronGuilty`
- `BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Amended`
- `BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Default`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[171] Sordland/Turn08/A_PoliticalOverview2** (../Turn_08/171_A_PoliticalOverview2.md), Węzeł `[572]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 9

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[32]` (Paskal Beniwoll): `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- Węzeł `[209]` (Paskal Beniwoll): `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- Węzeł `[210]` (Paskal Beniwoll): `Variable["BaseGameIsolated.PoliticalOverview2_TvAd"] = true;`
- Węzeł `[224]` (Paskal Beniwoll): `--;`
- Węzeł `[234]` (Paskal Beniwoll): `Variable["BaseGame.Bergia_Governor_Bron"] = false; Variable["BaseGame.Bergia_Governor_Krull"] = f...`
- Węzeł `[235]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty"] = true; Variable["BaseGameSu...`
- Węzeł `[239]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Amended"] = true;`
- Węzeł `[240]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Default"] = true;`
- *...oraz 1 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `171` (*Sordland/Turn08/A_PoliticalOverview2*), Węzeł `[572]`

### Węzeł `[3]`
Mówca: **Gloria Tory**
> "“I wanted to provide you with some quick updates on the current political situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[4]`
Mówca: **Gloria Tory**
> "“The changes you ordered to the Supreme Court have now been implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Results_Focus_Campaign == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Results_Focus_Campaign == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Results_Focus_Campaign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Results_Focus_Campaign == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Results_Focus_Campaign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Results_Focus_Economy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Results_Focus_Economy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Results_Focus_Economy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Results_Focus_Economy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Results_Focus_Economy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[11]`
Mówca: **Gloria Tory**
> "“The entire Court has been reshuffled. We're starting a new era.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[12]`
Mówca: **Gloria Tory**
> "“As you know, I've redoubled my focus on improving our public image.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Gloria Tory**
> "“There's now a decision to be made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Gloria Tory**
> "“Our initial reports are showing that advertisement over television is becoming a very effective method. Especially among young people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Gloria Tory**
> ""Saying that the replaced members were furious would be an understatement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[16]`
Mówca: **Gloria Tory**
> "“I have consulted with a few advisors and we would like to put out a television campaign. We've already got Sordland's biggest ad agency on board for the job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Gloria Tory**
> "“For this, they will be given security clearance to come in and take photos and videos in the Maroon Palace. Specifically they want footage of the president working and posing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Gloria Tory**
> "“The entirety of the Old Guard has been purged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[19]`
Mówca: **Gloria Tory**
> "“This way the people can feel closer to their leader in their homes. What do you think?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`
  - -> `[22]`
  - -> `[29]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“That sounds great. I always wanted to be a television star.”"]** — Mówca: **Player**
> "“That sounds great. I always wanted to be a television star.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "“It's a good plan. Let's do it.”"]** — Mówca: **Player**
> "“It's a good plan. Let's do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“I won't allow regular citizens to come in here. What's next? Tourists roaming the Palace halls?""]** — Mówca: **Player**
> "“I won't allow regular citizens to come in here. What's next? Tourists roaming the Palace halls?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[23]`
Mówca: **Gloria Tory**
> "“The changes you ordered to the Supreme Court have now been implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[24]`
Mówca: **Gloria Tory**
> "“I'll note that down as a yes, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[25]`
Mówca: **Gloria Tory**
> "“But there isn't much they can do about it now that they've been stripped of power.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[26]`
Mówca: **Gloria Tory**
> "“Very well. Then that's a no.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[27]`
Mówca: **Gloria Tory**
> "“Of course, the members we replaced are now furious, but there's not much they can do to act upon it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[28]`
Mówca: **Gloria Tory**
> "“Great. You won't regret it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "“It's not my favorite idea, but if it helps with the election, I guess I have no choice.""]** — Mówca: **Player**
> "“It's not my favorite idea, but if it helps with the election, I guess I have no choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[30]`
Mówca: **Gloria Tory**
> "“I will notify the filming crew.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Gloria Tory**
> "“With a key difference: Orso was smarter. This could still prove to be positive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 3)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[33]`
Mówca: **Narrator**
> "She flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[34]`
Mówca: **Gloria Tory**
> "“Mr. Holl has reported to me that he is currently putting the finishing touches on his new economic plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Gloria Tory**
> "“He said he wanted to solidify the plan before it is presented to you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Gloria Tory**
> "“He will schedule a meeting soon to go over our options.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`
  - -> `[40]`
  - -> `[37]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“This better be good. For his own good.”"]** — Mówca: **Player**
> "“This better be good. For his own good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Tell him to be quick. Our administration depends on it.”"]** — Mówca: **Player**
> "“Tell him to be quick. Our administration depends on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Symon can pull it off, I'm sure. He has never failed me before.”"]** — Mówca: **Player**
> "“Symon can pull it off. I'm sure. He has never failed me before.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "“I will be expecting good ideas and even better outcomes.”"]** — Mówca: **Player**
> "“I will be expecting good ideas and even better outcomes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[41]`
Mówca: **Gloria Tory**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[42]`
Mówca: **Gloria Tory**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Gloria Tory**
> "“Of course. So am I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[44]`
Mówca: **Narrator**
> "She flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[45]`
Mówca: **Gloria Tory**
> "“I understand. I'll make sure he's aware of the urgency of the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "“This is very bad. He and Orso are basically the same person.""]** — Mówca: **Player**
> "“This is very bad. He and Orso are basically the same person.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[47]`
Mówca: **Gloria Tory**
> "“Mr. Holl knows what he's doing. I am sure he will deliver as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Excellent news. I'm happy our appointment got elected.""]** — Mówca: **Player**
> "“Excellent news. I'm happy our appointment got elected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "“Let's hope he is better than Orso.”"]** — Mówca: **Player**
> "“Let's hope he is better than Orso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[50]`
Mówca: **Gloria Tory**
> "“I am sure Mr. Holl will deliver. But I'll remind him of the importance of his task.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Conservative == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Conservative == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Conservative"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Party_Conservative == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Conservative"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[55]`
Mówca: **Narrator**
> "She pulled out a few documents from a briefcase and laid them on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[56]`
Mówca: **Gloria Tory**
> "“He is certainly going to be loyal to us, and that means considerable power and sway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Gloria Tory**
> "“More importantly, though, Heron Garaci has been selected as the new Chief Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[121]`
  - -> `[135]`
  - -> `[46]`

### Węzeł `[58]`
Mówca: **Gloria Tory**
> "“Mr. Didier Meye has begun his duty as a Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[59]`
Mówca: **Gloria Tory**
> "“To begin with, your changes to the party manifesto have angered quite a few members of the reformist wing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Gloria Tory**
> "“The changes you ordered to the Supreme Court have now been implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[61]`
Mówca: **Gloria Tory**
> "“Some of the reformist MPs have decided to quit the party. 13 to be exact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Gloria Tory**
> "“I assure you, you're not the only one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[63]`
Mówca: **Gloria Tory**
> "“Their places have been filled with people more aligned with our new direction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[66]`
  - -> `[65]`
  - -> `[68]`

### Węzeł `[64]`
Mówca: **Gloria Tory**
> "“If you say so, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“It was an unfortunate and necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and necessary sacrifice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[69]`
Mówca: **Gloria Tory**
> "“This change should increase the trust in the capabilities of the Supreme Court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[48]`
  - -> `[49]`
  - -> `[51]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[71]`
Mówca: **Gloria Tory**
> "“That isn't a high mark to clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[73]`
Mówca: **Gloria Tory**
> "“If you say so, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[74]`
Mówca: **Gloria Tory**
> "“I think we'll gain enough conservative support to withstand the loss. Especially with me as Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[75]`
Mówca: **Gloria Tory**
> "“It wasn't unexpected. But our increased support among nationalists might make up for the loss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[76]`
Mówca: **Gloria Tory**
> "“Their places have been filled with people more aligned with the new manifesto.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[86]`
  - -> `[72]`
  - -> `[152]`

### Węzeł `[77]`
Mówca: **Gloria Tory**
> "“If you say so, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "“It was an unfortunate and a necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and necessary sacrifice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[81]`
Mówca: **Gloria Tory**
> "“To begin with, your changes to the party manifesto have angered quite a few members of the conservative wing. I'm not so sure about them myself, to be honest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Gloria Tory**
> "“Their places have been filled with people more aligned with the new manifesto.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[79]`
  - -> `[78]`
  - -> `[137]`

### Węzeł `[83]`
Mówca: **Gloria Tory**
> "“A portion of the conservative MPs have decided to quit the USP. 26, to be exact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[84]`
Mówca: **Gloria Tory**
> "“It's progress, for sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[85]`
Mówca: **Gloria Tory**
> "“The changes you ordered to the Supreme Court have now been implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[86]`
**[WYBÓR GRACZA: "“It was an unfortunate and necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and necessary sacrifice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_ExperiencedJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_ExperiencedJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_ExperiencedJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_ExperiencedJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_ExperiencedJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[90]`
Mówca: **Gloria Tory**
> "“A portion of the reformist MPs have decided to quit the party. 21 to be exact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[91]`
Mówca: **Gloria Tory**
> "“It's certainly a step forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Liberal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Liberal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Liberal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Party_Liberal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Liberal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Socialist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Socialist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Party_Socialist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Gloria Tory**
> "“That isn't a high mark to clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Ultranationalist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Ultranationalist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Party_Ultranationalist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[102]`
Mówca: **Gloria Tory**
> "“He doesn't seem to have any political motivations, one way or another. I am hopeful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Campaign_ExtraBudget == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Campaign_ExtraBudget == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Campaign_ExtraBudget"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Campaign_ExtraBudget == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Campaign_ExtraBudget"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[106]`
Mówca: **Narrator**
> "She flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[107]`
Mówca: **Gloria Tory**
> "“One more thing on this topic.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Gloria Tory**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[109]`
Mówca: **Gloria Tory**
> "“The mayors are very happy with your decision to provide them with extra funding to assist with the campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Gloria Tory**
> "“I wish I could be as optimistic. This is still the Old Guard we're talking about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[111]`
Mówca: **Gloria Tory**
> "“This will definitely boost our popularity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`
  - -> `[115]`

### Węzeł `[112]`
Mówca: **Narrator**
> "She flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[113]`
**[WYBÓR GRACZA: "“I hope the money went into the right place instead of their pockets.”"]** — Mówca: **Player**
> "“I hope the money went into the right place instead of their pockets.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Excellent. We need all the help we can get.""]** — Mówca: **Player**
> "“Excellent. We need all the help we can get.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Good work.”"]** — Mówca: **Player**
> "“Good work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[117]`
**[WYBÓR GRACZA: "“Let's hope he will be better than Orso.”"]** — Mówca: **Player**
> "“Let's hope he will be better than Orso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[118]`
**[WYBÓR GRACZA: "“Can he be trusted?”"]** — Mówca: **Player**
> "“Can he be trusted?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[119]`
Mówca: **Gloria Tory**
> "“I am sure of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[120]`
Mówca: **Gloria Tory**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[121]`
**[WYBÓR GRACZA: "“Let's hope Heron is better than Orso.”"]** — Mówca: **Player**
> "“Let's hope Heron is better than Orso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[122]`
Mówca: **Gloria Tory**
> "“Thank you. I'm trying my best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[123]`
Mówca: **Gloria Tory**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[124]`
Mówca: **Gloria Tory**
> "“To begin with, your changes to the party manifesto have angered quite a few members of the reformist wing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_LoyalJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_LoyalJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_LoyalJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_LoyalJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_LoyalJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_OldGuardReplaced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_OldGuardReplaced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_OldGuardReplaced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_Shuffled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_Shuffled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_Shuffled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[134]`
Mówca: **Gloria Tory**
> "“He is a seasoned veteran with a career in law spanning more than 30 years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[117]`
  - -> `[116]`

### Węzeł `[135]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[136]`
Mówca: **Gloria Tory**
> "“I'm surprised you would trust a man like Mr. Garaci.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[137]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Gloria Tory**
> "“These members were with us for a long time. I hope the gains in support among reformists can make up for the loss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[139]`
Mówca: **Gloria Tory**
> "“The new Chief Justice elected by the Court is mostly an unknown figure in politics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[140]`
Mówca: **Gloria Tory**
> "“If you say so, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[141]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[142]`
**[WYBÓR GRACZA: "“It was an unfortunate and a necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and necessary sacrifice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[143]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[144]`
Mówca: **Gloria Tory**
> "“To begin with, your changes to the party manifesto have angered MPs from both wings. I'm not so sure about them myself, to be honest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[145]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Gloria Tory**
> "“Their places have been filled with people more aligned with the new manifesto.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[142]`
  - -> `[141]`
  - -> `[145]`

### Węzeł `[147]`
Mówca: **Gloria Tory**
> "“It wasn't unexpected. Socialism has never been one of the USP's core values.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[148]`
Mówca: **Gloria Tory**
> "“We've lost 26 conservative MPs and 13 reformist ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[149]`
Mówca: **Gloria Tory**
> "“His name is Ovid Grecer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[150]`
Mówca: **Gloria Tory**
> "“Not a high mark to clear. But we're still dealing with the Old Guard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[151]`
**[WYBÓR GRACZA: "“Excellent news. I am glad to see him elected.”"]** — Mówca: **Player**
> "“Excellent news. I am glad to see him elected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[152]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[153]`
Mówca: **Gloria Tory**
> "“Mr. Ovid Grecer has now begun his duty as a Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Gloria Tory**
> "“He is a seasoned veteran with a career in law spanning over 30 years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Gloria Tory**
> "“As a matter of fact, shortly after his appointment, the Court selected Mr. Grecer as the new Chief Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[156]`
**[WYBÓR GRACZA: "“Can we trust him?”"]** — Mówca: **Player**
> "“Can we trust him?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Gloria Tory**
> "“I would. He's renowned for his impartiality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[158]`
Mówca: **Narrator**
> "She closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Gloria Tory**
> "“That is all for the court updates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[160]`
Mówca: **Narrator**
> "She closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Gloria Tory**
> "“That is all for the court updates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[162]`
Mówca: **Narrator**
> "She closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Gloria Tory**
> "“That is all for the court updates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[164]`
Mówca: **Narrator**
> "She closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Gloria Tory**
> ""Next up on the docket...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[169]`
Mówca: **Gloria Tory**
> "“I have some updates from the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Gloria Tory**
> "“I'm sure you were aware that the PFJP has been struggling to cope with the... absence of Frens Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Gloria Tory**
> "“Without a leader, they've been scrambling to keep the party intact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Gloria Tory**
> "“Or at least, that was the case until yesterday's PFJP congress.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Gloria Tory**
> "“Here, take a look.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Narrator**
> "She handed me an official report from the PFJP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Gloria Tory**
> "“They've elected a relatively untested member of their ranks as the new leader.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Gloria Tory**
> "“Her name is Manoly Suheil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[177]`
Mówca: **Gloria Tory**
> "“I don't know how she made it into the highest ranks of the PFJP, but one thing is for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Gloria Tory**
> "“She is popular both in the Assembly and among the people. She also happens to have quite a large female following.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Gloria Tory**
> "“We shouldn't underestimate her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`
  - -> `[182]`
  - -> `[183]`

### Węzeł `[180]`
**[WYBÓR GRACZA: "“We won't.”"]** — Mówca: **Player**
> "“We won't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[181]`
**[WYBÓR GRACZA: "“What can she do when Frens couldn't do anything?”"]** — Mówca: **Player**
> "“What can she do when Frens couldn't do anything?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[182]`
**[WYBÓR GRACZA: "“What if she were to meet the same fate as Frens?""]** — Mówca: **Player**
> "“What if she were to meet the same fate as Frens?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[183]`
**[WYBÓR GRACZA: "“Don't be alarmed. We have nothing to worry about.”"]** — Mówca: **Player**
> "“Don't be alarmed. We have nothing to worry about.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Gloria Tory**
> "“Better safe than sorry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[185]`
Mówca: **Gloria Tory**
> "“I'm going to pretend I didn't hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[186]`
Mówca: **Gloria Tory**
> "“If she can tap into Frens' base, she will have as much power as him. We will be watching her moves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Gloria Tory**
> "“I expected as much from you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[191]`
Mówca: **Gloria Tory**
> "“I have received multiple reports that the NFP has elected a new leader following Kesaro Kibener's... untimely leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Gloria Tory**
> "“It's Remus Holstron, also known as the 'Iron Wall'. Kibener's former right-hand man. I believe you've met him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`

### Węzeł `[193]`
Mówca: **Gloria Tory**
> "“As one of the most enthusiastic Young Sords members, he was recruited by Kesaro himself during the coup when he was still in the military.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Gloria Tory**
> "“Not the most charming fellow I've ever met.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Gloria Tory**
> "“Some say that he might be even more extreme than Kibener in his hardline anti-Bludish sentiments.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[196]`
**[WYBÓR GRACZA: ""I'd say it's time for the 'Iron Wall' to come down.”"]** — Mówca: **Player**
> ""I'd say it's time for the 'Iron Wall' to come down.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[197]`
**[WYBÓR GRACZA: "“He doesn't scare me. I have dealt with much worse.”"]** — Mówca: **Player**
> "“He doesn't scare me. I have dealt with much worse.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[198]`
**[WYBÓR GRACZA: "“Make sure he never becomes a big problem then.”"]** — Mówca: **Player**
> "“Make sure he never becomes a big problem then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[199]`
**[WYBÓR GRACZA: "“He can never *ever* hope to reach Kesaro's level.”"]** — Mówca: **Player**
> "“He can never *ever* hope to reach Kesaro's level.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[200]`
Mówca: **Gloria Tory**
> "“What's more, he is fervently worshipped among the Young Sords.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Gloria Tory**
> "“I can say with certainty that he *will* be a problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`
  - -> `[198]`
  - -> `[199]`

### Węzeł `[202]`
Mówca: **Gloria Tory**
> "“As much as I don't like either of them, you are right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[203]`
Mówca: **Gloria Tory**
> "“We will do our best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[204]`
Mówca: **Gloria Tory**
> "“It's better to be on the side of caution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[205]`
Mówca: **Gloria Tory**
> "“Wordplay. Clever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 3;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.PoliticalOverview2_TvAd = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.PoliticalOverview2_TvAd"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[211]`
Mówca: **Gloria Tory**
> ""The indefinitely delayed case of Ishval Ersen against Governor Phelix Bron has finally reached to a conclusion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[215]`
Mówca: **Gloria Tory**
> ""He was found guilty of abusing his powers to enable discrimination against the citizens of Sordland and found guilty of breaking the constitutional laws of the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[216]`
Mówca: **Gloria Tory**
> ""I must say... He already gave a landmark ruling as his first act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[220]`
Mówca: **Gloria Tory**
> ""He was found guilty of abusing his powers to enable discrimination against the citizens of Sordland which directly goes against the new Constitution. He was therefore found guilty of breaking the constitutional laws of the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Gloria Tory**
> ""He was promptly stripped from his duties as governor of the Special Zone and was sent directly to Antel Rock Prison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[222]`
Mówca: **Gloria Tory**
> ""As for his replacement, the Court argued that since it was an extraordinary circumstance and the elections are already nearby, a transitionary council must take charge of the governance of the Special Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Gloria Tory**
> ""According to the decisions made in that council, Ishval Ersen was already picked as the most suitable governor choice, arguably as a Bludish rights activist from Bergia who became extremely famous for bringing up the issues to the governmental level.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[225]`
  - -> `[228]`
  - -> `[227]`

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm already liking Chief Justice Grecer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is great news, Gloria!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, I don't even want to hear about Bergia anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is a great development for Bludish rights in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Gloria Tory**
> ""In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Gloria Tory: ""I must say... He already gave a la..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron = false;
BaseGame.Bergia_Governor_Krull = false;
BaseGame.Bergia_Governor_Ersen = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Bergia_Governor_Bron"] = false;
Variable["BaseGame.Bergia_Governor_Krull"] = false;
Variable["BaseGame.Bergia_Governor_Ersen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty = true;
BaseGameSupport.News_Turn08_R_OvidGrecerFindsBronGuilty = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty"] = true;
Variable["BaseGameSupport.News_Turn08_R_OvidGrecerFindsBronGuilty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Amended = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Amended"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_ReplacedByOvidGrecer = true;
BaseGameSupport.Codex_Characters_StateFigures_PhelixBron = false;
BaseGameSupport.Codex_Characters_Others_IshvalErsen = false;
BaseGameSupport.Codex_Characters_StateFigures_IshvalErsen_SpecialZone = true;
BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Ersen = true;
BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Bron = false)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_ReplacedByOvidGrecer"] = true;
Variable["BaseGameSupport.Codex_Characters_StateFigures_PhelixBron"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_IshvalErsen"] = false;
Variable["BaseGameSupport.Codex_Characters_StateFigures_IshvalErsen_SpecialZone"] = true;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Ersen"] = true;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Bron"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't recall. What can you tell me about him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh, yes. I know all about him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Gloria Tory**
> ""Then you know that he'll be a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`
  - -> `[198]`
  - -> `[199]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[248]`
Mówca: **Gloria Tory**
> ""You've met her before, I think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[249]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, say no more. I know all about her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Briefly. What can you tell me about her?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[251]`
Mówca: **Gloria Tory**
> "“Then you know we shouldn't underestimate her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`
  - -> `[182]`
  - -> `[183]`
