# Sordland/Turn08/PETR FEEDBACK

- **ID konwersacji:** `175`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/175_PETR_FEEDBACK.md`
- **Liczba węzłów dialogowych:** 251
- **Liczba wyborów gracza:** 42

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[10]** Narrator

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
- Węzeł `[2]` -> **[171] Sordland/Turn08/A_PoliticalOverview2** (../Turn_08/171_A_PoliticalOverview2.md), Węzeł `[1011]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 9

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[31]` (Paskal Beniwoll): `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- Węzeł `[199]` (Paskal Beniwoll): `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- Węzeł `[207]` (Paskal Beniwoll): `Variable["BaseGameIsolated.PoliticalOverview2_TvAd"] = true;`
- Węzeł `[221]` (Paskal Beniwoll): `--;`
- Węzeł `[234]` (Paskal Beniwoll): `Variable["BaseGame.Bergia_Governor_Bron"] = false; Variable["BaseGame.Bergia_Governor_Krull"] = f...`
- Węzeł `[235]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty"] = true; Variable["BaseGameSu...`
- Węzeł `[239]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Amended"] = true;`
- Węzeł `[240]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Default"] = true;`
- *...oraz 1 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `171` (*Sordland/Turn08/A_PoliticalOverview2*), Węzeł `[1011]`

### Węzeł `[3]`
Mówca: **Petr Vectern**
> "“All right. I've got some updates for you on what we're dealing with politically.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[4]`
Mówca: **Petr Vectern**
> "“Those changes you ordered to the Supreme Court have been implemented.”"
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
Mówca: **Petr Vectern**
> "“The whole Court's been reshuffled. Swapped out. The now ex-Justices are rather ticked off. To put it mildly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[12]`
Mówca: **Petr Vectern**
> "“As you know, I'm working on improving our public image.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Petr Vectern**
> "“There's a decision you've got to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Petr Vectern**
> "“Our researchers are saying television is becoming an increasingly effective method of reaching people, especially young people. Which, honestly, I could have told them that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Petr Vectern**
> "“So I talked to a few advisors and we want to put you on TV. We've already got Sordland's largest ad agency on board for the job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Petr Vectern**
> "“We'd need to give them security clearance to come in and take photos and videos in the Maroon Palace. Specifically, they want footage of you, Anton. Working, posing, just being your pretty self.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Petr Vectern**
> "“The Old Guard is gone. Purged. The now ex-Justices are rather ticked off. To put it mildly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[18]`
Mówca: **Petr Vectern**
> "“Think about it: Anton Rayne, in every home in Sordland. What do you say?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`
  - -> `[21]`
  - -> `[28]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "“I say I'm ready for my close-up.”"]** — Mówca: **Player**
> "“I say I'm ready for my close-up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“It's a good plan. Let's do it.”"]** — Mówca: **Player**
> "“It's a good plan. Let's do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "“I won't allow regular citizens to come in here. What's next? Tourists roaming the halls of the Palace?”"]** — Mówca: **Player**
> "“I won't allow regular citizens to come in here. What's next? Tourists roaming the halls of the Palace?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[22]`
Mówca: **Petr Vectern**
> "“Those changes you ordered to the Supreme Court have been implemented.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[23]`
Mówca: **Petr Vectern**
> "“That's the spirit!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[24]`
Mówca: **Petr Vectern**
> "“But good riddance! It's about time we got rid of those dinosaurs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[25]`
Mówca: **Petr Vectern**
> "“Fine, I get it. I'll look into other strategies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[26]`
Mówca: **Petr Vectern**
> "“But who cares? The dinosaurs are gone. We finally have some fresh blood on the bench.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[27]`
Mówca: **Petr Vectern**
> "“Thanks! You won't regret it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
**[WYBÓR GRACZA: ""It's not my favorite idea. But if it helps with the election, I guess I have no choice.""]** — Mówca: **Player**
> ""It's not my favorite idea. But if it helps with the election, I guess I have no choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[29]`
Mówca: **Petr Vectern**
> "“I'll notify the filming crew.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Petr Vectern**
> "“We can only hope he isn't as smart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 3)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[32]`
Mówca: **Narrator**
> "He flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[33]`
Mówca: **Petr Vectern**
> "“Symon told me that he's almost done with the new economic plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Petr Vectern**
> "“He said he still needs some time with it. Personally, I think he's just trying to avoid human contact for as long as possible, but what do I know?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Petr Vectern**
> "“At any rate, he will schedule a meeting soon to go over our options.”"
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
**[WYBÓR GRACZA: "“Symon can pull it off. I'm sure. He has never failed me before.”"]** — Mówca: **Player**
> "“Symon can pull it off. I'm sure. He has never failed me before.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“I will be expecting good ideas and even better outcomes.”"]** — Mówca: **Player**
> "“I will be expecting good ideas and even better outcomes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[40]`
Mówca: **Petr Vectern**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[41]`
Mówca: **Petr Vectern**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Petr Vectern**
> "“I'm sure he'll deliver.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[43]`
Mówca: **Narrator**
> "He flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[44]`
Mówca: **Petr Vectern**
> "“I'll let him know.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“This is bad. He's just the same as Orso Hawker.""]** — Mówca: **Player**
> "“This is bad. He's just the same as Orso Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[46]`
Mówca: **Petr Vectern**
> "“Oh, I trust his capabilities. Although I'd never ask him for dating advice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "“Excellent news. Our man made it.”"]** — Mówca: **Player**
> "“Excellent news. Our man made it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Let's hope he is better than Orso.”"]** — Mówca: **Player**
> "“Let's hope he is better than Orso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[49]`
Mówca: **Petr Vectern**
> "“I'm sure he'll deliver. But I'll go pester him anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

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
  - -> `[83]`

### Węzeł `[54]`
Mówca: **Narrator**
> "He pulled out a few documents from a briefcase and laid them on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[55]`
Mówca: **Petr Vectern**
> "“He is certainly going to be loyal to us, and that will only help us going forward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Petr Vectern**
> "“More importantly, though, Heron Garaci has been selected as the new Chief Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[112]`
  - -> `[125]`
  - -> `[45]`

### Węzeł `[57]`
Mówca: **Petr Vectern**
> "“Mr. Didier Meye has now begun his duty as a Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[58]`
Mówca: **Petr Vectern**
> "“To begin with, your changes to the USP manifesto have caused quite the commotion among the reformist wing of the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Petr Vectern**
> "“Those changes you ordered to the Supreme Court have been implemented.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[60]`
Mówca: **Petr Vectern**
> "“I'm not particularly excited about them either -- I thought we got elected to shake things up. But you know I'm behind you either way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Petr Vectern**
> "“Anyway, some of the reformist MPs have decided to quit the party. 13 to be exact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Petr Vectern**
> ""We're not the only ones who are happy about it, I can tell you that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[63]`
Mówca: **Petr Vectern**
> "“Their places have been filled with people more aligned with the new manifesto.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[65]`
  - -> `[64]`
  - -> `[67]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“It was an unfortunate and necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and necessary sacrifice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[68]`
Mówca: **Petr Vectern**
> "“Good news for us, if you ask me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[47]`
  - -> `[48]`
  - -> `[50]`

### Węzeł `[69]`
Mówca: **Petr Vectern**
> "“Who isn't?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[70]`
Mówca: **Petr Vectern**
> "“If you say so, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[71]`
Mówca: **Petr Vectern**
> "“Well, the new manifesto was never going to make everyone happy. We'll get by.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[72]`
Mówca: **Petr Vectern**
> "“Their places have been filled with people more aligned with our new direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[65]`
  - -> `[64]`
  - -> `[67]`

### Węzeł `[73]`
Mówca: **Petr Vectern**
> "“To begin with, your changes to the USP manifesto have caused quite the commotion among the reformist wing of the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Petr Vectern**
> "“Their places have been filled with people more aligned with the new direction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[65]`
  - -> `[64]`
  - -> `[67]`

### Węzeł `[75]`
Mówca: **Petr Vectern**
> "“Some of the conservative MPs have decided to quit the USP. 26 to be exact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[76]`
Mówca: **Petr Vectern**
> "“It's a big step forward, definitely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[77]`
Mówca: **Petr Vectern**
> "“Those changes you ordered to the Supreme Court have been implemented.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_ExperiencedJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_ExperiencedJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_ExperiencedJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_ExperiencedJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_ExperiencedJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[81]`
Mówca: **Petr Vectern**
> "“Anyway, some of the reformist MPs are quitting the party. 21, to be exact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[82]`
Mówca: **Petr Vectern**
> "“It's definitely a big step forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Liberal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Liberal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Liberal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Party_Liberal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Liberal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Socialist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Socialist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Party_Socialist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Petr Vectern**
> "“Who isn't?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Ultranationalist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Party_Ultranationalist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Party_Ultranationalist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[93]`
Mówca: **Petr Vectern**
> "“He doesn't seem to have any ulterior motives, unlike most people around here. I'm hopeful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Campaign_ExtraBudget == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Campaign_ExtraBudget == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Campaign_ExtraBudget"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Campaign_ExtraBudget == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Campaign_ExtraBudget"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[97]`
Mówca: **Narrator**
> "He flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[98]`
Mówca: **Petr Vectern**
> "“One more thing while we're on the subject...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Petr Vectern**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[100]`
Mówca: **Petr Vectern**
> "“The mayors were thrilled with your decision to provide them with extra funding to assist with the campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Petr Vectern**
> "“I don't know about that. He's basically Orso in a different robe with better hair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[102]`
Mówca: **Petr Vectern**
> "“This will definitely boost our popularity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`
  - -> `[106]`

### Węzeł `[103]`
Mówca: **Narrator**
> "He flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

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
  - -> `[82]`

### Węzeł `[108]`
**[WYBÓR GRACZA: "“Let's hope he will be better than Orso.”"]** — Mówca: **Player**
> "“Let's hope he will be better than Orso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[109]`
**[WYBÓR GRACZA: "“Can he be trusted?”"]** — Mówca: **Player**
> "“Can he be trusted?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[110]`
Mówca: **Petr Vectern**
> "“If the mayors are happy, does it matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[111]`
Mówca: **Petr Vectern**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[112]`
**[WYBÓR GRACZA: "“Let's hope Heron is better than Orso.”"]** — Mówca: **Player**
> "“Let's hope Heron is better than Orso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[113]`
Mówca: **Petr Vectern**
> "“Thank you. You know I'm trying my best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[114]`
Mówca: **Petr Vectern**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_LoyalJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_LoyalJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_LoyalJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_LoyalJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_LoyalJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_OldGuardReplaced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_OldGuardReplaced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_OldGuardReplaced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_Shuffled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_Shuffled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_Shuffled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[124]`
Mówca: **Petr Vectern**
> "“He's got a long, illustrious and boring career in law spanning over 30 years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[108]`
  - -> `[107]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[126]`
Mówca: **Petr Vectern**
> "“You trust him? I wouldn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[127]`
Mówca: **Petr Vectern**
> "“The new Chief Justice elected by the Court is mostly an unknown figure in politics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[128]`
Mówca: **Petr Vectern**
> "“To begin with, your changes to the USP manifesto have caused quite the commotion within the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Petr Vectern**
> "“Their places have been filled with people more aligned with our new direction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[65]`
  - -> `[64]`
  - -> `[67]`

### Węzeł `[130]`
Mówca: **Petr Vectern**
> "“We're losing MPs on both sides. 26 from the conservative wing, 13 reformers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[131]`
Mówca: **Petr Vectern**
> "“His name is Ovid Grecer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[132]`
Mówca: **Petr Vectern**
> "“He's basically Orso in a different robe with better hair. But we'll see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[133]`
**[WYBÓR GRACZA: "“Excellent news. I am glad to see him elected.”"]** — Mówca: **Player**
> "“Excellent news. I am glad to see him elected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_GloriaJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_GloriaJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_GloriaJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[137]`
Mówca: **Petr Vectern**
> "“Ovid Grecer has now begun his duty as a Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Petr Vectern**
> "“Seems like his long and boring history of upholding the law did the trick. The Court elected him Chief Justice right after his appointment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[139]`
**[WYBÓR GRACZA: "“Can we trust him?”"]** — Mówca: **Player**
> "“Can we trust him?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Petr Vectern**
> "“I'd trust him a lot more than, say, Lucian. To give a completely random example.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[141]`
Mówca: **Petr Vectern**
> "“Those changes you ordered to the Supreme Court have been implemented.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[142]`
Mówca: **Narrator**
> "He flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[143]`
Mówca: **Petr Vectern**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[144]`
Mówca: **Petr Vectern**
> "“I think we both know what she brings to the table.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[145]`
Mówca: **Petr Vectern**
> "“The honorable Ms. Gloria Tory has now begun her duty as a Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[146]`
Mówca: **Narrator**
> "He closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Petr Vectern**
> "“That is all for the court updates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[148]`
Mówca: **Narrator**
> "He closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Petr Vectern**
> "“That is all for the court updates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[150]`
Mówca: **Narrator**
> "He closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Petr Vectern**
> "“That is all for the court updates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[152]`
Mówca: **Narrator**
> "He closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Petr Vectern**
> "“Next on the docket...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[157]`
Mówca: **Petr Vectern**
> "“I have some updates from the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Petr Vectern**
> "“As you know, the... *absence* of Frens Ricter left the PFJP in a state of turmoil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Petr Vectern**
> "“In short, they've been running around like a chicken with its head cut off.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Petr Vectern**
> "“Or at least they were, until yesterday's PFJP congress.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Petr Vectern**
> "“Here, take a look.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Narrator**
> "He handed me an official report from the PFJP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Petr Vectern**
> "“It seems they've selected a new leader. Manoly Suheil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[164]`
Mówca: **Petr Vectern**
> "“I don't know how she was able to get that far in the PFJP, but one thing's for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Petr Vectern**
> "“She is popular both in the Assembly and among the people. Not bad-looking, either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Petr Vectern**
> "“We shouldn't underestimate her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`
  - -> `[169]`
  - -> `[170]`

### Węzeł `[167]`
**[WYBÓR GRACZA: "“'Not bad-looking?' Haven't you learned anything?""]** — Mówca: **Player**
> "“'Not bad-looking?' Haven't you learned anything?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[168]`
**[WYBÓR GRACZA: "“What can she do when Frens couldn't do anything?”"]** — Mówca: **Player**
> "“What can she do when Frens couldn't do anything?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[169]`
**[WYBÓR GRACZA: ""Hypothetically, what if she were to meet the same fate as Frens?""]** — Mówca: **Player**
> ""Hypothetically, what if she were to meet the same fate as Frens?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[170]`
**[WYBÓR GRACZA: "“Don't be alarmed. We have nothing to worry about.”"]** — Mówca: **Player**
> "“Don't be alarmed. We have nothing to worry about.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Petr Vectern**
> "“Better safe than sorry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[172]`
Mówca: **Petr Vectern**
> "“Don't you still have your investigation going? Maybe they'll dig up some dirt on her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[173]`
Mówca: **Petr Vectern**
> "“If she can tap into Frens's base, she will have as much power as him. We will be watching her moves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Petr Vectern**
> "“Lighten up, Mr. President. It was a joke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[178]`
Mówca: **Petr Vectern**
> "“I've received multiple reports that the NFP has chosen a new leader following the, uh, 'untimely leave' of Kesaro Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Petr Vectern**
> "“You've met him. Remus Holstron, the 'Iron Wall'. Kibener's former right-hand man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[242]`

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“What else can you tell me about him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Petr Vectern**
> "“As a die-hard Young Sords member, he was recruited by Kesaro himself during the coup when he was still in the military.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Petr Vectern**
> "“Not a lot of fun at parties, I would guess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Petr Vectern**
> "“Some say that he's an even bigger anti-Bludish zealot than Kesaro.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[184]`
**[WYBÓR GRACZA: "“It's time to bring down the 'Iron Wall'.”"]** — Mówca: **Player**
> "“It's time to bring down the 'Iron Wall'.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[185]`
**[WYBÓR GRACZA: "“He doesn't scare me. I have dealt with much worse.”"]** — Mówca: **Player**
> "“He doesn't scare me. I have dealt with much worse.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[186]`
**[WYBÓR GRACZA: "“Make sure he never becomes a big problem then.”"]** — Mówca: **Player**
> "“Make sure he never becomes a big problem then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[187]`
**[WYBÓR GRACZA: "“He can never *ever* hope to reach Kesaro's level.""]** — Mówca: **Player**
> "“He can never *ever* hope to reach Kesaro's level.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[188]`
Mówca: **Petr Vectern**
> "“Not to mention that he's practically worshipped among the Young Sords.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Petr Vectern**
> "“He comes with a baked-in base and foundation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Petr Vectern**
> "“I can tell you right now he's going to be a problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`
  - -> `[186]`
  - -> `[187]`

### Węzeł `[191]`
Mówca: **Petr Vectern**
> "“Frankly, I could never stand either of them. But you're probably right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[192]`
Mówca: **Petr Vectern**
> "“I'll try.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[193]`
Mówca: **Petr Vectern**
> "“It's better to be on the side of caution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[194]`
Mówca: **Petr Vectern**
> "“I agree. It's a stupid nickname.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[198]`
Mówca: **Petr Vectern**
> "“More importantly, though, Heron Garaci has been selected as the new Chief Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[112]`
  - -> `[125]`
  - -> `[45]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 3;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[200]`
Mówca: **Petr Vectern**
> "“I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[201]`
Mówca: **Petr Vectern**
> "“To begin with, your changes to the USP manifesto have caused quite the commotion among the reformist wing of the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Petr Vectern**
> "“I'm not particularly excited about them either, but you know I'm behind you either way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Investigate_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Petr Vectern**
> "“Hypothetically, that might look a little too suspicious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.PoliticalOverview2_TvAd = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.PoliticalOverview2_TvAd"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[208]`
Mówca: **Petr Vectern**
> ""The indefinitely delayed case of Ishval Ersen against Governor Phelix Bron has finally reached to a conclusion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[212]`
Mówca: **Petr Vectern**
> ""He was found guilty of abusing his powers to enable discrimination against the citizens of Sordland and found guilty of breaking the constitutional laws of the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[213]`
Mówca: **Petr Vectern**
> ""I must say... He already gave a landmark ruling as his first act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[217]`
Mówca: **Petr Vectern**
> ""He was found guilty of abusing his powers to enable discrimination against the citizens of Sordland which directly goes against the new Constitution. He was therefore found guilty of breaking the constitutional laws of the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Petr Vectern**
> ""He was promptly stripped from his duties as governor of the Special Zone and was sent directly to Antel Rock Prison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Petr Vectern**
> ""As for his replacement, the Court argued that since it was an extraordinary circumstance and the elections are already nearby, a transitionary council must take charge of the governance of the Special Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Petr Vectern**
> ""According to the decisions made in that council, Ishval Ersen was already picked as the most suitable governor choice, arguably as a Bludish rights activist from Bergia who became extremely famous for bringing up the issues to the governmental level.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[222]`
  - -> `[225]`
  - -> `[224]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm already liking Chief Justice Grecer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is great news, Petr!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, I don't even want to hear about Bergia anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is a great development for Bludish rights in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Petr Vectern**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[227]`
Mówca: **Petr Vectern**
> ""Me too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Petr Vectern**
> ""Sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Petr Vectern**
> ""In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Petr Vectern: ""I must say... He already gave a la..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

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
  - -> `[221]`

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Say no more. I know *all* about him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Petr Vectern**
> "“Then you know he's going to be a problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`
  - -> `[186]`
  - -> `[187]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[247]`
Mówca: **Petr Vectern**
> ""We met her before, remember?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[248]`

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, say no more. I know all about her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Vaguely. What can you tell me about her?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[250]`
Mówca: **Petr Vectern**
> "“Then you know we shouldn't underestimate her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`
  - -> `[170]`
