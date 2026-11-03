# Sordland/Turn08/LUCIAN FEEDBACK

- **ID konwersacji:** `174`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/174_LUCIAN_FEEDBACK.md`
- **Liczba węzłów dialogowych:** 269
- **Liczba wyborów gracza:** 54

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Reform_Heron_PromisedChiefJustice`
- `BaseGame.Turn07_Investigate_Opposition`
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
- Węzeł `[2]` -> **[171] Sordland/Turn08/A_PoliticalOverview2** (../Turn_08/171_A_PoliticalOverview2.md), Węzeł `[811]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
- **Węzły modyfikujące stan gry:** 9

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[31]` (Paskal Beniwoll): `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- Węzeł `[220]` (Paskal Beniwoll): `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- Węzeł `[226]` (Paskal Beniwoll): `Variable["BaseGameIsolated.PoliticalOverview2_TvAd"] = true;`
- Węzeł `[240]` (Paskal Beniwoll): `--;`
- Węzeł `[251]` (Paskal Beniwoll): `Variable["BaseGame.Bergia_Governor_Bron"] = false; Variable["BaseGame.Bergia_Governor_Krull"] = f...`
- Węzeł `[253]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty"] = true; Variable["BaseGameSu...`
- Węzeł `[257]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Amended"] = true;`
- Węzeł `[258]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Default"] = true;`
- *...oraz 1 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `171` (*Sordland/Turn08/A_PoliticalOverview2*), Węzeł `[811]`

### Węzeł `[3]`
Mówca: **Lucian Galade**
> "“I wanted to provide you with some quick updates on the current political situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[4]`
Mówca: **Lucian Galade**
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
  - -> `[33]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Results_Focus_Economy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Results_Focus_Economy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[11]`
Mówca: **Lucian Galade**
> "“The members you replaced were not happy, to put it very mildly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[12]`
Mówca: **Lucian Galade**
> "“As you know, I've been working on improving our public image.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Lucian Galade**
> "“However, there is a decision that needs to be made.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Lucian Galade**
> "“Our initial reports are showing that especially among the youth, advertisement over television is becoming a very effective method.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Lucian Galade**
> "“The entirety of the Old Guard has been purged from the Court. This is a historic occasion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[16]`
Mówca: **Lucian Galade**
> "“I have consulted with a few advisors and we would like to put out a television campaign. Sordland's largest advertising agency is already on board to produce the spots.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Lucian Galade**
> "“For this, they will be given security clearance to come in and take photos and videos in the Maroon Palace. Specifically they want footage of the president working and posing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Lucian Galade**
> "“The members you replaced were not happy, to put it very mildly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[19]`
Mówca: **Lucian Galade**
> "“This way the people can feel closer to their leader in their homes. What do you think?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`
  - -> `[22]`
  - -> `[28]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“That sounds great. I always wanted to be a television star.”"]** — Mówca: **Player**
> "“That sounds great. I always wanted to be a television star.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "“It's a good plan. Let's do it.”"]** — Mówca: **Player**
> "“It's a good plan. Let's do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“I won't allow regular citizens to come in here. What's next? Tourists roaming the palace halls?”"]** — Mówca: **Player**
> "“I won't allow regular citizens to come in here. What's next? Tourists roaming the palace halls?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[23]`
Mówca: **Lucian Galade**
> "“The changes you ordered to the Supreme Court have now been implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[24]`
Mówca: **Lucian Galade**
> "“I'll assume you are joking and note that down as a yes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[25]`
Mówca: **Lucian Galade**
> "“Very well. Then that's a no.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[26]`
Mówca: **Lucian Galade**
> "“The Court has been entirely reshuffled. This is the beginning of a new era and the end of the Old Guard's tyranny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[27]`
Mówca: **Lucian Galade**
> "“Thank you, sir. I assure you it will be of immense help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "“It's not my favorite idea. But if it helps with the election, I have no choice.""]** — Mówca: **Player**
> "“It's not my favorite idea. But if it helps with the election, I have no choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[29]`
Mówca: **Lucian Galade**
> "“I will notify the filming crew.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Lucian Galade**
> "“I agree, Mr. President. However, I doubt Mr. Garaci is as capable as Mr. Hawker. This could still prove to be positive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 3)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[32]`
Mówca: **Narrator**
> "He flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[33]`
Mówca: **Lucian Galade**
> "“Mr. Holl has reported to me that he has almost finished drafting his new plan for the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Lucian Galade**
> "“He said he wanted to solidify the plan before it is presented to you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Lucian Galade**
> "“He will schedule a meeting soon to go over our options.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`
  - -> `[39]`
  - -> `[36]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“This better be good. For his own good.”"]** — Mówca: **Player**
> "“This better be good. For his own good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“Tell him to be quick. Our administration depends on it.”"]** — Mówca: **Player**
> "“Tell him to be quick. Our administration depends on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Symon can pull it off, I'm sure. He has never failed us before.”"]** — Mówca: **Player**
> "“Symon can pull it off, I'm sure. He has never failed us before.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“I will be expecting good ideas and even better outcomes.”"]** — Mówca: **Player**
> "“I will be expecting good ideas and even better outcomes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[40]`
Mówca: **Lucian Galade**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[41]`
Mówca: **Lucian Galade**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Lucian Galade**
> "“Of course. I will relay this to him as soon as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[43]`
Mówca: **Narrator**
> "He flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[44]`
Mówca: **Lucian Galade**
> "“I understand. I will relay this to him as soon as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“This is bad. He and Orso are basically the same person.""]** — Mówca: **Player**
> "“This is bad. He and Orso are basically the same person.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[46]`
Mówca: **Lucian Galade**
> "“Mr. Holl is exceptionally skilled. I am sure he will deliver as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "“Excellent news! Our man made it.”"]** — Mówca: **Player**
> "“Excellent news! Our man made it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Let's hope he is better than Orso.”"]** — Mówca: **Player**
> "“Let's hope he is better than Orso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[49]`
Mówca: **Lucian Galade**
> "“I am sure Mr. Holl will deliver. I will reiterate the importance of his task to him as soon as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Conservative == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Conservative == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Conservative"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Party_Conservative == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Conservative"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[54]`
Mówca: **Narrator**
> "He pulled out a few documents from a briefcase and laid them on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[55]`
Mówca: **Lucian Galade**
> "“He is certainly going to be loyal to us, and that will bring us considerable power and sway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Lucian Galade**
> "“More importantly, though, the court has selected Heron Garaci as the new Chief Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[120]`
  - -> `[134]`
  - -> `[45]`

### Węzeł `[57]`
Mówca: **Lucian Galade**
> "“Mr. Didier Meye has begun his duty as a Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[58]`
Mówca: **Lucian Galade**
> "“To begin with, your changes to the USP manifesto have caused quite the stir among the reformist wing of the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Lucian Galade**
> "“The changes you ordered to the Supreme Court have now been implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[60]`
Mówca: **Lucian Galade**
> "“A portion of the reformist MPs have decided to quit the USP. 13 to be exact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Lucian Galade**
> "“I assure you, you are not the only one rejoicing at the appointment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[62]`
Mówca: **Lucian Galade**
> "“Their places have been filled with people more aligned with the new manifesto.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[65]`
  - -> `[64]`
  - -> `[67]`

### Węzeł `[63]`
Mówca: **Lucian Galade**
> "“Indeed, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“It was an unfortunate and a necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and a necessary sacrifice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[68]`
Mówca: **Lucian Galade**
> "“With him at the helm, trust in the Supreme Court ought to increase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[47]`
  - -> `[48]`
  - -> `[50]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[70]`
Mówca: **Lucian Galade**
> "“That wouldn't be difficult, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[72]`
Mówca: **Lucian Galade**
> ""Indeed, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[73]`
Mówca: **Lucian Galade**
> "“The manifesto was never going to please everyone. Our newly strengthened conservative base will more than make up for the loss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[74]`
Mówca: **Lucian Galade**
> "“The manifesto was never going to please everyone. We can only hope the gains among nationalists will make up for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[75]`
Mówca: **Lucian Galade**
> "“Their places have been filled with people more aligned with the new manifesto.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[85]`
  - -> `[71]`
  - -> `[151]`

### Węzeł `[76]`
Mówca: **Lucian Galade**
> ""Indeed, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "“It was an unfortunate and a necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and a necessary sacrifice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[80]`
Mówca: **Lucian Galade**
> "“To begin with, your changes to the USP manifesto have caused quite the stir among the conservative wing of the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Lucian Galade**
> "“Their places have been filled with people more aligned with the new manifesto.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[78]`
  - -> `[77]`
  - -> `[136]`

### Węzeł `[82]`
Mówca: **Lucian Galade**
> "“A portion of the MPs have decided to quit the USP. 26 to be exact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[83]`
Mówca: **Lucian Galade**
> "“Certainly a large step forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[84]`
Mówca: **Lucian Galade**
> "“The changes you ordered to the Supreme Court have now been implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[85]`
**[WYBÓR GRACZA: "“It was an unfortunate and a necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and a necessary sacrifice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_ExperiencedJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_ExperiencedJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_ExperiencedJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_ExperiencedJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_ExperiencedJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[89]`
Mówca: **Lucian Galade**
> "“A portion of the reformist MPs have decided to quit the USP. 21 to be exact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[90]`
Mówca: **Lucian Galade**
> "“Certainly a large step forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Liberal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Liberal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Liberal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Party_Liberal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Liberal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Socialist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Socialist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Party_Socialist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Lucian Galade**
> ""That wouldn't be difficult, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Ultranationalist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Ultranationalist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Party_Ultranationalist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[101]`
Mówca: **Lucian Galade**
> "“He appears to have a refreshing lack of political motivations. I am hopeful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Campaign_ExtraBudget == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Campaign_ExtraBudget == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Campaign_ExtraBudget"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Campaign_ExtraBudget == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Campaign_ExtraBudget"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[105]`
Mówca: **Narrator**
> "He flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[106]`
Mówca: **Lucian Galade**
> "“One more thing on this topic.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Lucian Galade**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[108]`
Mówca: **Lucian Galade**
> "“The mayors are extremely happy with the extra funds you have provided them to assist with our campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Lucian Galade**
> "“I wish I could be as optimistic. But I fear one Old Guard member has simply been swapped out for another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[110]`
Mówca: **Lucian Galade**
> "“This will surely boost our popularity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`
  - -> `[114]`

### Węzeł `[111]`
Mówca: **Narrator**
> "He flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[112]`
**[WYBÓR GRACZA: "“I hope the money went into the right place instead of their pockets.”"]** — Mówca: **Player**
> "“I hope the money went into the right place instead of their pockets.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[113]`
**[WYBÓR GRACZA: "“Excellent. We need all the help we can get.""]** — Mówca: **Player**
> "“Excellent. We need all the help we can get.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Good work.”"]** — Mówca: **Player**
> "“Good work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "“Let's hope he will be better than Orso.”"]** — Mówca: **Player**
> "“Let's hope he will be better than Orso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[117]`
**[WYBÓR GRACZA: "“Can he be trusted?”"]** — Mówca: **Player**
> "“Can he be trusted?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[118]`
Mówca: **Lucian Galade**
> "“In either scenario, the mayors are happy. That will only help us going forward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[119]`
Mówca: **Lucian Galade**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "“Let's hope Heron is better than Orso.”"]** — Mówca: **Player**
> "“Let's hope Heron is better than Orso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[121]`
Mówca: **Lucian Galade**
> "“Thank you. I do try my best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[122]`
Mówca: **Lucian Galade**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[123]`
Mówca: **Lucian Galade**
> "“To begin with, your changes to the USP manifesto have caused quite the stir among the reformist wing of the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_LoyalJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_LoyalJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_LoyalJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_LoyalJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_LoyalJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_OldGuardReplaced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_OldGuardReplaced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_OldGuardReplaced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_Shuffled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_Shuffled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_Shuffled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[133]`
Mówca: **Lucian Galade**
> "“He is a seasoned veteran with a career in law spanning more than 30 years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[116]`
  - -> `[115]`

### Węzeł `[134]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[135]`
Mówca: **Lucian Galade**
> "“I'm surprised you would trust a man like Mr. Garaci.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[136]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Lucian Galade**
> "“The manifesto was never going to please everyone. The gains we make among reformists will surely make up for the loss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[138]`
Mówca: **Lucian Galade**
> "“The Court's new chief justice is mostly an unknown figure in politics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[139]`
Mówca: **Lucian Galade**
> "“Indeed, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[140]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[141]`
**[WYBÓR GRACZA: "“It was an unfortunate and a necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and a necessary sacrifice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[142]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[143]`
Mówca: **Lucian Galade**
> "“To begin with, your changes to the USP manifesto have caused quite the stir among party members.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[144]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Lucian Galade**
> "“Their places have been filled with people more aligned with the new manifesto.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[141]`
  - -> `[140]`
  - -> `[144]`

### Węzeł `[146]`
Mówca: **Lucian Galade**
> "“The manifesto was never going to please everyone. We can only hope the gains among socialists will make up for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[147]`
Mówca: **Lucian Galade**
> "“An alarming number of MPs have decided to quit the USP. 26 from the conservative wing, 13 from the reformist side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[148]`
Mówca: **Lucian Galade**
> "“His name is Ovid Grecer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[149]`
Mówca: **Lucian Galade**
> "“That wouldn't be difficult. But I fear one Old Guard member has simply been swapped out for another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[150]`
**[WYBÓR GRACZA: "“Excellent news. I am glad to see him elected.”"]** — Mówca: **Player**
> "“Excellent news. I am glad to see him elected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[151]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_GloriaJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_GloriaJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_GloriaJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[155]`
Mówca: **Lucian Galade**
> "“Mr. Ovid Grecer has begun his duty in the Supreme Court as a Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Lucian Galade**
> "“He is a seasoned veteran with a career in law spanning more than 30 years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Lucian Galade**
> "“Perhaps it is this experience which caused the Court to select Mr. Grecer as the new Chief Justice directly after his appointment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[158]`
**[WYBÓR GRACZA: "“Can we trust him?”"]** — Mówca: **Player**
> "“Can we trust him?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Lucian Galade**
> "“Certainly. He's renowned for his impartiality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[160]`
Mówca: **Lucian Galade**
> "“The changes you ordered to the Supreme Court have now been implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[161]`
Mówca: **Narrator**
> "He flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[162]`
Mówca: **Lucian Galade**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[163]`
Mówca: **Lucian Galade**
> "“I think we both know what she brings to the table.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[164]`
Mówca: **Lucian Galade**
> "“Ms. Gloria Tory has now begun her duty in the Supreme Court as a Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[165]`
Mówca: **Narrator**
> "He closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Lucian Galade**
> "“That is all for the court updates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[167]`
Mówca: **Narrator**
> "He closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Lucian Galade**
> "“That is all for the court updates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[169]`
Mówca: **Narrator**
> "He closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Lucian Galade**
> "“That is all for the court updates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Narrator**
> "He closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[175]`
Mówca: **Lucian Galade**
> "“Moving on to some updates from the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Lucian Galade**
> "“As you know, the... *absence* of Frens Ricter has led to turmoil within the PFJP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Lucian Galade**
> "“They've been scrambling to keep the party intact without a leader.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Lucian Galade**
> "“Or at least, that was the case until yesterday's PFJP congress.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Lucian Galade**
> "“Please, have a look.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Narrator**
> "He handed me an official report from the PFJP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Lucian Galade**
> "“It seems an unprecedented candidate from their ranks has been selected as the new leader.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Lucian Galade**
> "“Her name is Manoly Suheil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[183]`
Mówca: **Lucian Galade**
> "“I don't know how she made it that far in the PFJP, but one thing is for certain.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Lucian Galade**
> "“She is popular both in the Assembly and among the people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Lucian Galade**
> "“We shouldn't underestimate her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`
  - -> `[189]`
  - -> `[188]`

### Węzeł `[186]`
**[WYBÓR GRACZA: "“We won't.”"]** — Mówca: **Player**
> "“We won't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[187]`
**[WYBÓR GRACZA: "“What can she do when Frens couldn't do anything?”"]** — Mówca: **Player**
> "“What can she do when Frens couldn't do anything?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[188]`
**[WYBÓR GRACZA: "“Hypothetically, what if she were to meet the same fate as Frens?”"]** — Mówca: **Player**
> "“Hypothetically, what if she were to meet the same fate as Frens?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[189]`
**[WYBÓR GRACZA: "“Don't be alarmed. We have nothing to worry about.”"]** — Mówca: **Player**
> "“Don't be alarmed. We have nothing to worry about.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Lucian Galade**
> "“Better safe than sorry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[191]`
Mówca: **Lucian Galade**
> "“That may yet be possible, depending on the results of your investigation on the opposition. I shall keep you updated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[192]`
Mówca: **Lucian Galade**
> "“If she can tap into Frens's base, she will have as much power as him. We will be watching her moves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Lucian Galade**
> "“As I expected from you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[197]`
Mówca: **Lucian Galade**
> "“I have received multiple reports that the NFP has chosen a new leader following Kesaro Kibener's... untimely exit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Lucian Galade**
> "“You've met him. Remus Holstron, also known as the 'Iron Wall'. Mr. Kibener's former right-hand man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[260]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What else can you tell me about him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Lucian Galade**
> "“As a brutally efficient Young Sords member, he was recruited by Kesaro himself during the coup when he was still in the military.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Lucian Galade**
> "“Not the most charming gentleman you or I have met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Lucian Galade**
> "“Some say that he might be even more extreme than Kesaro in his xenophobic sentiments.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[203]`
**[WYBÓR GRACZA: "“If he is the 'Iron Wall', then I will be the one that brings it down.”"]** — Mówca: **Player**
> "“If he is the 'Iron Wall', then I will be the one that brings it down.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[204]`
**[WYBÓR GRACZA: "“He doesn't scare me. I have dealt with much worse.”"]** — Mówca: **Player**
> "“He doesn't scare me. I have dealt with much worse.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[205]`
**[WYBÓR GRACZA: "“Make sure he never becomes a big problem, then.”"]** — Mówca: **Player**
> "“Make sure he never becomes a big problem, then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[206]`
**[WYBÓR GRACZA: "“He can never *ever* hope to reach Kesaro's level.”"]** — Mówca: **Player**
> "“He can never *ever* hope to reach Kesaro's level.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[207]`
Mówca: **Lucian Galade**
> "“On top of that, he has a fervent following among the Young Sords.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Lucian Galade**
> "“I can say with certainty that he *will* be a problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`
  - -> `[205]`
  - -> `[206]`

### Węzeł `[209]`
Mówca: **Lucian Galade**
> "“I never cared for either man. But you may be right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[210]`
Mówca: **Lucian Galade**
> "“We will do our best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[211]`
Mówca: **Lucian Galade**
> "“It's better to be on the side of caution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[212]`
Mówca: **Lucian Galade**
> "“It's a silly nickname, I agree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[219]`
Mówca: **Lucian Galade**
> "“More importantly, though, the court has selected Heron Garaci as the new Chief Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[134]`
  - -> `[45]`
  - -> `[216]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 3;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Investigate_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Lucian Galade**
> "“No, I'm afraid it would look too suspicious. Hypothetically.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[225]`
Mówca: **Lucian Galade**
> "“Moving on...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.PoliticalOverview2_TvAd = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.PoliticalOverview2_TvAd"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[227]`
Mówca: **Lucian Galade**
> ""Oh. And he already gave a landmark ruling as his first act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Lucian Galade**
> ""The indefinitely delayed case of Ishval Ersen against Governor Phelix Bron has finally reached to a conclusion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[232]`
Mówca: **Lucian Galade**
> ""He was found guilty of abusing his powers to enable discrimination against the citizens of Sordland and found guilty of breaking the constitutional laws of the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[236]`
Mówca: **Lucian Galade**
> ""He was found guilty of abusing his powers to enable discrimination against the citizens of Sordland which directly goes against the new Constitution. He was therefore found guilty of breaking the constitutional laws of the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Lucian Galade**
> ""He was promptly stripped from his duties as governor of the Special Zone and was sent directly to Antel Rock Prison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Lucian Galade**
> ""As for his replacement, the Court argued that since it was an extraordinary circumstance and the elections are already nearby, a transitionary council must take charge of the governance of the Special Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Lucian Galade**
> ""According to the decisions made in that council, Ishval Ersen was already picked as the most suitable governor choice, arguably as a Bludish rights activist from Bergia who became extremely famous for bringing up the issues to the governmental level.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[241]`
  - -> `[243]`
  - -> `[244]`

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm already liking Chief Justice Grecer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is great news, Lucian!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is a great development for Bludish rights in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, I don't even want to hear about Bergia anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[246]`
Mówca: **Lucian Galade**
> ""He seems to be a good choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[247]`
Mówca: **Lucian Galade**
> ""I must say... He already gave a landmark ruling as his first act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron = false;
BaseGame.Bergia_Governor_Krull = false;
BaseGame.Bergia_Governor_Ersen = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Bergia_Governor_Bron"] = false;
Variable["BaseGame.Bergia_Governor_Krull"] = false;
Variable["BaseGame.Bergia_Governor_Ersen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Lucian Galade: ""The indefinitely delayed case of I..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty = true;
BaseGameSupport.News_Turn08_R_OvidGrecerFindsBronGuilty = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty"] = true;
Variable["BaseGameSupport.News_Turn08_R_OvidGrecerFindsBronGuilty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Amended = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Amended"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[259]`
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
  - -> `[240]`

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh, yes. I know all about him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Lucian Galade**
> "“Then you know that as head of the NFP, he will pose a problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`
  - -> `[205]`
  - -> `[206]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[265]`
Mówca: **Lucian Galade**
> ""We have met her before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[266]`

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, say no more. I know all about her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Briefly. What can you tell me about her?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[268]`
Mówca: **Lucian Galade**
> "“Then you know we shouldn't underestimate her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`
  - -> `[189]`
  - -> `[188]`
