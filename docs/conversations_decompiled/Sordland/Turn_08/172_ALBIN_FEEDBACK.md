# Sordland/Turn08/ALBIN FEEDBACK

- **ID konwersacji:** `172`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/172_ALBIN_FEEDBACK.md`
- **Liczba węzłów dialogowych:** 259
- **Liczba wyborów gracza:** 54

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[61]** Albin Clavin

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
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
- `BaseGame.Turn08_Action_Court_GloriaJustice`
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
- Węzeł `[2]` -> **[171] Sordland/Turn08/A_PoliticalOverview2** (../Turn_08/171_A_PoliticalOverview2.md), Węzeł `[327]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
- **Węzły modyfikujące stan gry:** 9

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[30]` (Paskal Beniwoll): `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- Węzeł `[209]` (Paskal Beniwoll): `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- Węzeł `[216]` (Paskal Beniwoll): `Variable["BaseGameIsolated.PoliticalOverview2_TvAd"] = true;`
- Węzeł `[230]` (Paskal Beniwoll): `--;`
- Węzeł `[241]` (Paskal Beniwoll): `Variable["BaseGame.Bergia_Governor_Bron"] = false; Variable["BaseGame.Bergia_Governor_Krull"] = f...`
- Węzeł `[242]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty"] = true; Variable["BaseGameSu...`
- Węzeł `[246]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Amended"] = true;`
- Węzeł `[247]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Default"] = true;`
- *...oraz 1 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `171` (*Sordland/Turn08/A_PoliticalOverview2*), Węzeł `[327]`

### Węzeł `[3]`
Mówca: **Albin Clavin**
> "“This shouldn't take long. I just wanted to go over the current political climate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Albin Clavin**
> "“We've implemented the Supreme Court changes that you ordered. Replaced the lot of them with an all-new batch of justices.""
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
  - -> `[31]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Results_Focus_Economy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Results_Focus_Economy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[11]`
Mówca: **Albin Clavin**
> "“Saying that the now ex-members were furious would be an understatement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[12]`
Mówca: **Albin Clavin**
> "“As you know, I've been working on improving our public image.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Albin Clavin**
> "“However, there is a decision that needs to be made.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Albin Clavin**
> "“Our initial reports show that voters, especially younger ones, are extremely responsive to advertisement over television. Especially with the new techniques of today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Albin Clavin**
> "“I have consulted with a few advisors and we would like to put out a brand-new television campaign. We've already spoken with Sordland's biggest advertising agency, and they believe indirect messages work better than direct ones.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Albin Clavin**
> "“For this, they will be given security clearance to come in and take photos and videos in the Maroon Palace. Specifically, they want footage of the president working and posing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Albin Clavin**
> "“Saying that the now ex-members are furious would be an understatement. Me, I couldn't be happier to be rid of those dinosaurs. They've held Sordland in their iron grip for too long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[18]`
Mówca: **Albin Clavin**
> "“This way, the people can feel closer to their leader in their homes. What do you think?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`
  - -> `[21]`
  - -> `[27]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "“That sounds great. I always wanted to be a television star.”"]** — Mówca: **Player**
> "“That sounds great. I always wanted to be a television star.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“It's a good plan. Let's do it.”"]** — Mówca: **Player**
> "“It's a good plan. Let's do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "“I won't allow regular citizens to come in here. What's next? Hordes of tourists walking around the palace?”"]** — Mówca: **Player**
> "“I won't allow regular citizens to come in here. What's next? Hordes of tourists walking around the palace?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
Mówca: **Albin Clavin**
> "“We've implemented the Supreme Court changes that you ordered. The entirety of the Old Guard is gone. Purged.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[23]`
Mówca: **Albin Clavin**
> "“I'm not sure if you are joking, but I will note that down as a yes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[24]`
Mówca: **Albin Clavin**
> "“Very well. Then that's a no.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[25]`
Mówca: **Albin Clavin**
> "“Me, I couldn't be more thrilled. It's high time the Court had some fresh faces. Truly neutral ones, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[26]`
Mówca: **Albin Clavin**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Not my favorite idea. But if it helps with the election, I have no choice.”"]** — Mówca: **Player**
> "“Not my favorite idea. But if it helps with the election, I have no choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[28]`
Mówca: **Albin Clavin**
> "“I will notify the film crew.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Albin Clavin**
> "“I agree, Mr. President. However, I doubt Mr. Garaci is as capable as his predecessor. This could still prove to be positive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 3)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[31]`
Mówca: **Albin Clavin**
> "“Mr. Holl told me he's just about finished with his new plan for the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Albin Clavin**
> "“He said he wanted to solidify the plan before it is presented to you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Albin Clavin**
> "“He'll schedule a meeting soon to go over our options.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`
  - -> `[37]`
  - -> `[34]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“This better be good. For his own good.”"]** — Mówca: **Player**
> "“This better be good. For his own good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Tell him to be quick. Our administration depends on it.”"]** — Mówca: **Player**
> "“Tell him to be quick. Our administration depends on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Symon can pull it off, I'm sure. He has never failed me before.”"]** — Mówca: **Player**
> "“Symon can pull it off, I'm sure. He has never failed me before.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“I will be expecting good ideas and even better outcomes.”"]** — Mówca: **Player**
> "“I will be expecting good ideas and even better outcomes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[38]`
Mówca: **Albin Clavin**
> "“There is something else you need to know...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[39]`
Mówca: **Albin Clavin**
> "“There is something else you need to know...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[40]`
Mówca: **Albin Clavin**
> "“Of course. I will relay this to him as soon as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[41]`
Mówca: **Albin Clavin**
> "“I understand. I will relay this to him as soon as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "“This is bad. He and Hawker are basically the same person.""]** — Mówca: **Player**
> "“This is bad. He and Hawker are basically the same person.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[43]`
Mówca: **Albin Clavin**
> "“Mr. Holl is a savvy man. I am sure he will deliver as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Excellent news! I'm glad our man made it.”"]** — Mówca: **Player**
> "“Excellent news! I'm glad our man made it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“Let's hope he is better than Orso.”"]** — Mówca: **Player**
> "“Let's hope he is better than Orso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[46]`
Mówca: **Albin Clavin**
> "“I am sure Mr. Holl will deliver. But I'll remind him how important this is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "“This is still an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is still an important milestone for Sordish democracy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Conservative == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Conservative == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Conservative"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Party_Conservative == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Conservative"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[51]`
Mówca: **Albin Clavin**
> "“He is known for his loyalty, and that will hopefully bring us considerable power and sway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Albin Clavin**
> "“But more importantly... the court has selected Heron Garaci as the new Chief Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[112]`
  - -> `[126]`
  - -> `[42]`

### Węzeł `[53]`
Mówca: **Albin Clavin**
> "“To begin with, a lot of reformist party members -- including me, to be honest -- have issues with your changes to the USP manifesto.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Albin Clavin**
> "“Your new appointment to the Supreme Court, Mr. Didier Meye, began his duty as a Justice today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[55]`
Mówca: **Albin Clavin**
> "“I tried to convince them otherwise, but a group of MPs have decided to quit the party. 13, to be exact. They handed in their resignation letters today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Albin Clavin**
> "“You're not the only one. Let's hope he really is as neutral and just as everyone says.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[57]`
Mówca: **Albin Clavin**
> "“I think they are thinking about joining the PFJP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[60]`
  - -> `[59]`
  - -> `[62]`

### Węzeł `[58]`
Mówca: **Albin Clavin**
> "“If you say so, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“It was an unfortunate and a necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and a necessary sacrifice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "“And you, Albin? Will you jump ship as well?""]** — Mówca: **Player**
> "“And you, Albin? Will you jump ship as well?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[63]`
Mówca: **Albin Clavin**
> "“However, this change should definitely increase public trust in the capabilities of the Supreme Court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[44]`
  - -> `[45]`
  - -> `[47]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[65]`
Mówca: **Albin Clavin**
> "“*Anyone* is better than Orso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[67]`
Mówca: **Albin Clavin**
> "“If you say so, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[68]`
Mówca: **Albin Clavin**
> "“No, Mr. President. I still believe I've got a greater shot at accomplishing change as your vice president than as a PFJP member.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[69]`
Mówca: **Albin Clavin**
> "“A good number of them might end up joining the PFJP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[78]`
  - -> `[66]`
  - -> `[214]`

### Węzeł `[70]`
Mówca: **Albin Clavin**
> "“If you say so, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "“It was an unfortunate and necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and necessary sacrifice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[74]`
Mówca: **Albin Clavin**
> "“First off, your changes to the party manifesto -- which I fully applaud, by the way -- have been causing quite the ruckus among the conservative wing of the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Albin Clavin**
> "“It could be they'll join the ranks of the NFP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[72]`
  - -> `[71]`
  - -> `[128]`

### Węzeł `[76]`
Mówca: **Albin Clavin**
> "“A group of MPs have decided to quit the USP. 26, to be exact. They gave their resignation letters today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[77]`
Mówca: **Albin Clavin**
> "“Maybe. Certainly a step in the right direction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "“It was an unfortunate and a necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and a necessary sacrifice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_ExperiencedJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_ExperiencedJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_ExperiencedJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_ExperiencedJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_ExperiencedJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[82]`
Mówca: **Albin Clavin**
> "“This is a huge problem. Never before have so many people resigned together. This may have negative consequences on the upcoming elections.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[83]`
Mówca: **Albin Clavin**
> "“A group of MPs have decided to quit the party. 26 to be exact. They gave their resignation letters today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[84]`
Mówca: **Albin Clavin**
> "“Certainly one of the most important ones in the past decade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Liberal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Liberal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Liberal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Party_Liberal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Liberal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Socialist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Socialist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Party_Socialist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Albin Clavin**
> "“*Anyone* is better than Orso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Ultranationalist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Ultranationalist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Party_Ultranationalist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[95]`
Mówca: **Albin Clavin**
> "“Everyone says he's one of the most impartial judges out there. I am hopeful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Campaign_ExtraBudget == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Campaign_ExtraBudget == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Campaign_ExtraBudget"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Campaign_ExtraBudget == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Campaign_ExtraBudget"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[99]`
Mówca: **Albin Clavin**
> "“One more thing on this topic.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Albin Clavin**
> "“There is something else you need to know...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[101]`
Mówca: **Albin Clavin**
> "“The mayors are very happy with your decision to provide them with extra funding to assist in the campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Albin Clavin**
> "“I wish I could be as optimistic. He and Orso are cut from the same cloth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[103]`
Mówca: **Albin Clavin**
> "“We are already seeing positive responses from the cities in Greater Holsord and Gelsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`
  - -> `[106]`

### Węzeł `[104]`
**[WYBÓR GRACZA: "“I hope the money went into the right place instead of their pockets.”"]** — Mówca: **Player**
> "“I hope the money went into the right place instead of their pockets.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "“Excellent. We need all the help we can get.""]** — Mówca: **Player**
> "“Excellent. We need all the help we can get.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[106]`
**[WYBÓR GRACZA: "“Good work.”"]** — Mówca: **Player**
> "“Good work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[107]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[108]`
**[WYBÓR GRACZA: "“Let's hope he will be better than Orso.”"]** — Mówca: **Player**
> "“Let's hope he will be better than Orso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[109]`
**[WYBÓR GRACZA: "“Can he be trusted?”"]** — Mówca: **Player**
> "“Can he be trusted?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[110]`
Mówca: **Albin Clavin**
> "“I'm sure it did. Most of it, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[111]`
Mówca: **Albin Clavin**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[112]`
**[WYBÓR GRACZA: "“Let's hope Heron is better than Orso.”"]** — Mówca: **Player**
> "“Let's hope Heron is better than Orso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[113]`
Mówca: **Albin Clavin**
> "“Thank you. We are trying our best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[114]`
Mówca: **Albin Clavin**
> "“There is something else you need to know...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[115]`
Mówca: **Albin Clavin**
> "“To begin with, a lot of reformist party members -- including me, to be honest -- have issues with your changes to the USP manifesto.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_LoyalJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_LoyalJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_LoyalJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_LoyalJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_LoyalJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_OldGuardReplaced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_OldGuardReplaced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_OldGuardReplaced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_Shuffled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_Shuffled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_Shuffled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[125]`
Mówca: **Albin Clavin**
> "“He's a seasoned veteran with a career in law spanning over 30 years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[108]`
  - -> `[107]`

### Węzeł `[126]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[127]`
Mówca: **Albin Clavin**
> "“I'm surprised you would trust a man like Mr. Garaci.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[128]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Albin Clavin**
> "“I'd say we don't need them if they can't accept the change. We still hold the majority.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[130]`
Mówca: **Albin Clavin**
> "“So today, the new Court held an internal vote to select their new Chief Justice. He's mostly an unknown figure in politics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[131]`
Mówca: **Albin Clavin**
> "“If you say so, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[132]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[133]`
**[WYBÓR GRACZA: "“It was an unfortunate and a necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and a necessary sacrifice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[134]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[135]`
Mówca: **Albin Clavin**
> "“To begin with, a lot of party members have issues with your changes to the USP manifesto. I'm not so sure about them myself, to be honest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[136]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Albin Clavin**
> "“A good number of them might end up joining the NFP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[133]`
  - -> `[132]`
  - -> `[136]`

### Węzeł `[138]`
Mówca: **Albin Clavin**
> "“Only that it was expected considering the direction you've pointed the party in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[139]`
Mówca: **Albin Clavin**
> "“I did my best to convince them otherwise, but a group of MPs have decided to quit the party. 39 to be exact. They handed in their resignation letters today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[140]`
Mówca: **Albin Clavin**
> "“His name is Ovid Grecer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[141]`
Mówca: **Albin Clavin**
> "“*Anyone* is better than Orso. That said, now we have another member of the Old Guard on our hands.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[142]`
**[WYBÓR GRACZA: "“Excellent news. I am glad to see him elected.”"]** — Mówca: **Player**
> "“Excellent news. I am glad to see him elected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_GloriaJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_GloriaJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_GloriaJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[146]`
Mówca: **Albin Clavin**
> "“Honestly, this came as quite a shock to me. I wouldn't have thought a new Justice would be elected as the chief.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Albin Clavin**
> "“I know he is a seasoned veteran with a career in law spanning over 30 years, but...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[148]`
Mówca: **Albin Clavin**
> "“Your new appointment to the Supreme Court, Mr. Grecer, has been elected Chief Justice following the internal vote today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[149]`
**[WYBÓR GRACZA: "“So, you don't trust him?”"]** — Mówca: **Player**
> "“So, you don't trust him?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Albin Clavin**
> "“I want to. Everyone says he's one of the most incorruptible judges out there. But I do not know this man in person. Nor I can ignore the fact that the Supreme Court was so quick to elect him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[151]`
Mówca: **Albin Clavin**
> "“Your appointment to the Supreme Court, Mrs. Tory, has begun her duty as a Justice today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Albin Clavin**
> "“There is something else you need to know...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[153]`
Mówca: **Albin Clavin**
> "“I think we both know what she brings to the table. And I have to say that it was clever of you to remove her from the Assembly. She was a thorn in our side as the Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[154]`
Mówca: **Albin Clavin**
> "“In any case, we will have to wait and see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Albin Clavin**
> "“In any case, we'll have to wait and see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[159]`
Mówca: **Albin Clavin**
> "“There's also been a development in the opposition you should know about.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Albin Clavin**
> "“As you know, Frens Ricter's... *absence* in the Assembly left the PFJP in turmoil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Albin Clavin**
> "“They've been scrambling to keep the party intact without its leader.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Albin Clavin**
> "“Or at least, that was the case until yesterday's PFJP congress.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Albin Clavin**
> "“Here, take a look.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Narrator**
> "He handed me an official report from the PFJP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Albin Clavin**
> "“An unprecedented candidate from their ranks has been elected the new PFJP leader. Manoly Suheil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[166]`
Mówca: **Albin Clavin**
> "“She was always a radical figure in their party. She and Ricter butted heads on numerous occasions, as I recall.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Albin Clavin**
> "“Now that he's gone, she has been let loose. I still don't know how she made it to that position, but they must have had a reason to elect someone like her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Albin Clavin**
> "“We know she is quite popular both in the Assembly and among middle-class women. She definitely has the potential to expand the PFJP's influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Albin Clavin**
> "“We shouldn't underestimate her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`
  - -> `[172]`
  - -> `[173]`

### Węzeł `[170]`
**[WYBÓR GRACZA: "“We won't.”"]** — Mówca: **Player**
> "“We won't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[171]`
**[WYBÓR GRACZA: "“What can she do when Frens couldn't do anything?”"]** — Mówca: **Player**
> "“What can she do when Frens couldn't do anything?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[172]`
**[WYBÓR GRACZA: "“It'd be a shame if the same thing happened to her as to Frens.”"]** — Mówca: **Player**
> "“It'd be a shame if the same thing happened to her as to Frens.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[173]`
**[WYBÓR GRACZA: "“Don't be alarmed. We have nothing to worry about.”"]** — Mówca: **Player**
> "“Don't be alarmed. We have nothing to worry about.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Albin Clavin**
> "“You might be right. But better be safe than sorry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[175]`
Mówca: **Albin Clavin**
> "“I'm just going to pretend I didn't hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[176]`
Mówca: **Albin Clavin**
> "“If she can tap into Ricter's base, she will have as much power as him or more. We will be watching her moves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Albin Clavin**
> "“Just as I expected from you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[181]`
Mówca: **Albin Clavin**
> "“Another thing. I have received multiple reports that the NFP has chosen a replacement to lead in Kesaro Kibener's stead. It seems to be his former right-hand man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Albin Clavin**
> "“Remus Holstron, also known as the 'Iron Wall'. I believe you two have met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[249]`

### Węzeł `[183]`
Mówca: **Albin Clavin**
> "“As one of the most brutally cutthroat Young Sords members, he was recruited by Kesaro himself during the coup when he was still in the military.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Albin Clavin**
> "“Not the most charming fellow I've ever met...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Albin Clavin**
> "“He is a ticking time bomb. Some nationalists think he is *too extreme* compared to Mr. Kibener, especially for his deeply troubling anti-minority rhetoric.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[186]`
**[WYBÓR GRACZA: "“If he is the *Iron Wall* then I will be the one that brings it down.”"]** — Mówca: **Player**
> "“If he is the *Iron Wall* then I will be the one that brings him down.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[187]`
**[WYBÓR GRACZA: "“He doesn't scare me. I have dealt with much worse.”"]** — Mówca: **Player**
> "“He doesn't scare me. I have dealt with much worse.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[188]`
**[WYBÓR GRACZA: "“Make sure he never becomes a big problem then.”"]** — Mówca: **Player**
> "“Make sure he never becomes a big problem then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[189]`
**[WYBÓR GRACZA: "“He can never *ever* hope to reach Kesaro's level.""]** — Mówca: **Player**
> "“He can never *ever* hope to reach Kesaro's level.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[190]`
Mówca: **Albin Clavin**
> "“What's more, he is basically worshipped among the Young Sords.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Albin Clavin**
> "“He comes with an already strong base and foundation. He will either expand the NFP's influence, or destroy what Kesaro had achieved.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Albin Clavin**
> "“But I can say with certainty that he *will* be a problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`
  - -> `[188]`
  - -> `[189]`

### Węzeł `[193]`
Mówca: **Albin Clavin**
> "“As much as I don't like the man, you might be right. However, let's not forget that Kesaro was labelled as *moderate* by NFP supporters...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[194]`
Mówca: **Albin Clavin**
> "“We will do our best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[195]`
Mówca: **Albin Clavin**
> "“It's better to be on the side of caution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[196]`
Mówca: **Albin Clavin**
> "“Silly nicknames don't win politics after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[203]`
Mówca: **Albin Clavin**
> "“But more importantly... the Court has selected Heron Garaci as the new Chief Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[126]`
  - -> `[42]`
  - -> `[200]`

### Węzeł `[204]`
Mówca: **Albin Clavin**
> "“I still can't picture how the Old Guard voted for him. I know you like this guy, but I wouldn't trust the situation completely if I were you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[208]`
Mówca: **Albin Clavin**
> "“He was recruited by Kesaro himself during the coup when he was still in the military. There were already a few investigations opened on him for his suspected ties to the banned Young Sords, but they were suspended due to lack of evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 3;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[213]`
Mówca: **Albin Clavin**
> ""Speaking of which, I've got some very interesting news about the PFJP. But I'll get to that later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[214]`
**[WYBÓR GRACZA: "“And you, Albin? Will you jump ship as well?""]** — Mówca: **Player**
> "“And you, Albin? Will you jump ship as well?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Albin Clavin**
> "“No, Mr. President. I still believe I've got a greater shot at accomplishing change as your vice president than as a PFJP member.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.PoliticalOverview2_TvAd = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.PoliticalOverview2_TvAd"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[217]`
Mówca: **Albin Clavin**
> ""The indefinitely delayed case of Ishval Ersen against Governor Phelix Bron has finally reached to a conclusion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[221]`
Mówca: **Albin Clavin**
> ""He was found guilty of abusing his powers to enable discrimination against the citizens of Sordland and found guilty of breaking the constitutional laws of the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[222]`
Mówca: **Albin Clavin**
> ""I must say... He already gave a landmark ruling as his first act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[226]`
Mówca: **Albin Clavin**
> ""He was found guilty of abusing his powers to enable discrimination against the citizens of Sordland which directly goes against the new Constitution. He was therefore found guilty of breaking the constitutional laws of the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Albin Clavin**
> ""He was promptly stripped from his duties as governor of the Special Zone and was sent directly to Antel Rock Prison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Albin Clavin**
> ""As for his replacement, the Court argued that since it was an extraordinary circumstance and the elections are already nearby, a transitionary council must take charge of the governance of the Special Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Albin Clavin**
> ""According to the decisions made in that council, Ishval Ersen was already picked as the most suitable governor choice, arguably as a Bludish rights activist from Bergia who became extremely famous for bringing up the issues to the governmental level.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[231]`
  - -> `[234]`
  - -> `[233]`

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm already liking Chief Justice Grecer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is great news, Albin!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, I don't even want to hear about Bergia anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is a great development for Bludish rights in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Albin Clavin**
> ""This is surely great news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[236]`
Mówca: **Albin Clavin**
> ""Well... Sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Albin Clavin: ""I must say... He already gave a la..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron = false;
BaseGame.Bergia_Governor_Krull = false;
BaseGame.Bergia_Governor_Ersen = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Bergia_Governor_Bron"] = false;
Variable["BaseGame.Bergia_Governor_Krull"] = false;
Variable["BaseGame.Bergia_Governor_Ersen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty = true;
BaseGameSupport.News_Turn08_R_OvidGrecerFindsBronGuilty = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty"] = true;
Variable["BaseGameSupport.News_Turn08_R_OvidGrecerFindsBronGuilty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Amended = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Amended"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[248]`
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
  - -> `[230]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, I already know all about him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What else can you tell me about him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[251]`
Mówca: **Albin Clavin**
> "“Then you know that he *will* be a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`
  - -> `[188]`
  - -> `[189]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[255]`
Mówca: **Albin Clavin**
> ""You've met her before, I think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[256]`

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, say no more. I know all about her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Briefly. What can you tell me about her?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[258]`
Mówca: **Albin Clavin**
> "“Then you know we shouldn't underestimate her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`
  - -> `[172]`
  - -> `[173]`
