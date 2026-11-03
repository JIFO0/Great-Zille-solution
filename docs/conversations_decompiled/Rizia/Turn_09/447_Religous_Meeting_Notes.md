# Rizia/Turn 9/Religous Meeting Notes

- **ID konwersacji:** `447`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/447_Religous_Meeting_Notes.md`
- **Liczba węzłów dialogowych:** 122
- **Liczba wyborów gracza:** 25

---

## 1. Uczestnicy Sceny

- **[87]** Sal Ignacius
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Council_GrandVizier_Empty`
- `RiziaDLC.Council_Security_Titus`
- `RiziaDLC.Trait_RebelKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Turn06_Briefing_Religion_LeaningWruhecist`
- `RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy`
- `RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier`
- `RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Theocracy_Full`
- `RiziaDLC.Theocracy_None`
- `RiziaDLC.Theocracy_Partial`
- `RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceAgnostic`
- `RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceCouncil`
- `RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGG`
- `RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGGAndCouncil`
- `RiziaDLC.Turn09_ReligionMeeting_ReplaceGoldenGuards`
- `RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier`
- `RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 12
- **Węzły modyfikujące stan gry:** 15

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[39]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier"] = false; Variable["RiziaDLC.T...`
- Węzeł `[41]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] = true;`
- Węzeł `[43]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn09_ReligionMeeting_ReplaceGoldenGuards"] = false; ;`
- Węzeł `[58]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGGAndCouncil"] = true;`
- Węzeł `[59]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGGAndCouncil"] = false;`
- Węzeł `[61]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceAgnostic"] = true;`
- Węzeł `[62]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceCouncil"] = true;`
- Węzeł `[63]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGG"] = true;`
- *...oraz 7 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Sal Ignacius**
> ""Firstly, I believe it pertinent that if we're to cement Rizian Wruhecistic principles, the role of Grand Vizier should be given to a religious figurehead -- myself, specifically.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Empty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Empty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Empty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Empty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Empty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know the position has opened up recently. But I have other candidates in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[8]`
Mówca: **Sal Ignacius**
> ""Firstly, as I mentioned the night of the Alignment of the Six Stars, I believe it pertinent that if we're to cement Rizian Wruhecistic principles, the role of Grand Vizier should be given to a religious figurehead -- myself, specifically.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[20]`
  - -> `[22]`
  - -> `[103]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Briefing_Religion_LeaningWruhecist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Briefing_Religion_LeaningWruhecist == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn06_Briefing_Religion_LeaningWruhecist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn06_Briefing_Religion_LeaningWruhecist == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn06_Briefing_Religion_LeaningWruhecist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[12]`
Mówca: **Sal Ignacius**
> ""This will not only strengthen the bond between the monarchy and the divine but also foster a sense of righteousness and unity among our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Sal Ignacius**
> ""Furthermore, as a religious leader, I offer a profound comprehension of spiritual affairs and can provide invaluable guidance on both state and soul, guaranteeing the prosperity of our realm not just in worldly affairs but also in matters of the spirit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Sal Ignacius**
> ""My second proposal, in addition to the newly assigned duties given to the Wruhec's Guardians, is that they should take over the responsibilities currently bestowed upon the Golden Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[18]`
Mówca: **Sal Ignacius**
> ""The Guardians, much like myself, would uphold the kingdom's laws with unwavering devotion to the divine principles of Wruhecism. They'd ensure justice free from personal bias or political motivations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Sal Ignacius**
> ""Their extensive spiritual training and commitment to ethical conduct make them ideal for handling sensitive matters that require both discretion and moral integrity. I'd argue they would be more effective than the Golden Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I remember. You'll be pleased to know I'm still open to such a proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I said it before and I'll say it again... I'm not replacing Hugo. What's your other idea?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, yes. Right. You as Grand Vizier. What were you saying about that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[23]`
Mówca: **Sal Ignacius**
> ""I *am* pleased to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[24]`
Mówca: **Sal Ignacius**
> ""I'm very pleased you think so. And speaking of shakeups, I believe the royal council could be in line for such a change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[25]`
Mówca: **Sal Ignacius**
> ""Such a replacement, comprised of priests and clerics, would ensure that decisions align closely with divine principles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Sal Ignacius**
> ""Such a council would guide the kingdom toward a more faith-based governance, where moral integrity and spiritual guidance shape every aspect of our rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Sal Ignacius**
> ""This change would move us towards establishing a government guided by spiritual principles, where divine law reigns supreme.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Sal Ignacius**
> ""Which brings me to my final proposal, this time involving the royal council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[29]`
Mówca: **Sal Ignacius**
> ""So what do you say, Your Majesty, will you take my hand and embark on this righteous journey to establish God's heavenly kingdom on earth?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, if we're talking about the role of Grand Vizier, consider the job yours." [Appoint Grand Vizier]"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have no intention of supplanting Hugo for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[32]`
Mówca: **Sal Ignacius**
> ""That's wonderful! It's heartening to know that we share the same vision and goals for the kingdom's future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Sal Ignacius**
> ""And speaking of visions, that brings me to the last topic I wanted to discuss... the royal council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm open to taking such a journey, however, when it comes to replacing Hugo, as I previously said, that's a no-go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`
  - -> `[83]`
  - -> `[34]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You already know my answer regarding the Grand Vizier position. It's yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier = false; RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier"] = false;
Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Sal Ignacius**
> ""I'm sorry to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Sal Ignacius**
> ""Excellent! You have no idea how much this means for me, and for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_ReplaceGoldenGuards = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_ReplaceGoldenGuards"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you're really keen on the position of Grand Vizier, you can submit a petition for it during the upcoming council reshuffle. I assure you that your consideration will be given *utmost attention*, if you get my meaning." [Promise Grand Vizier]"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[45]`
Mówca: **Sal Ignacius**
> ""Without it, we risk straying further from the path of righteousness and forsaking the will of the Divine.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[46]`
Mówca: **Sal Ignacius**
> ""Implementing these changes in part will still mark progress towards establishing divine governance. It's a promising start on our journey towards fulfilling the will of the Divine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[47]`
Mówca: **Sal Ignacius**
> ""I see nothing but a bright future ahead of us. Rizia is blessed to have you as our sovereign king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[48]`
Mówca: **Sal Ignacius**
> ""What of the Golden Guard's and the Royal Council's replacement?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[51]`
  - -> `[49]`
  - -> `[50]`
  - -> `[55]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not fond of either. While I'm usually open to bold moves, this feels like it's crossing a line, and is a step too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I commend you for your vision of the future. I shall give your Royal Council replacement proposal serious consideration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Both are complex proposals, and if approved, would necessitate a substantial amount of time an planning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Sal Ignacius**
> ""Understandable, Your Majesty. Perhaps, when you've hard more time to think about it, we can return to these proposals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[53]`
Mówca: **Sal Ignacius**
> ""Yes, of course. Then I won't speak of it any longer. Another time perhaps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[54]`
Mówca: **Sal Ignacius**
> ""Please do. There's untold possibilities that we could accomplish if you initiated that reform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I applaud your vision for the future. I will carefully consider the Golden Guard replacement proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Sal Ignacius**
> ""Oh, please do. There's untold possibilities that we could accomplish if you initiated that reform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[57]`
Mówca: **Sal Ignacius**
> """That's excellent news! But yes, of course. I'll bring this up again when timing is more suitable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGGAndCouncil = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGGAndCouncil"] = true;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGGAndCouncil = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGGAndCouncil"] = false;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see no reason why either of those proposals couldn't come to fruition, but that isn't something I wish to decide just now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceAgnostic = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceAgnostic"] = true;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceCouncil = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceCouncil"] = true;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGG = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGG"] = true;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[64]`
Mówca: **Sal Ignacius**
> ""Anyway, thanks for hearing me out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[67]`
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rest assured, I am committed to implementing the required reforms to establish the kingdom of Rizia as God's kingdom on earth." [Full Theocracy]"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Just so we're clear, I have no intention of turning this kingdom into a divine realm governed by religious principles -- at least how you envision it." [No Theocracy]"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't commit to implementing all of your reforms, but I'm open to some. We need to maintain a level of autonomy for the state, separate from the influence of the Sanctuary." [Partial Theocracy]"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Committing to all your reforms just isn't possible, especially when it concerns issues such as economic stability and diplomatic relations. However, I am open to some collaboration." [Partial Theocracy]"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Theocracy_Full"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Partial = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Theocracy_Partial"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Partial = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Theocracy_Partial"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_None = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Theocracy_None"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[73]`
Mówca: **Sal Ignacius**
> ""Bless You, Your Majesty. This momentous decision heralds a new era for our kingdom, one where divine guidance shall illuminate our path forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[74]`
Mówca: **Sal Ignacius**
> ""Overall, I'm heartened to hear your acceptance of at least some of my proposals. Though it falls short of the full theocratic reformation I envisioned, it signifies a step forward nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[75]`
Mówca: **Sal Ignacius**
> ""As Grand Vizier, I vow to exceed the expectations placed upon me by both God and the king, ensuring that every task is carried out with utmost diligence and dedication.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier == true || RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier == true || RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier"] == true  or  Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier == true || RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier"] == true  or  Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[82]`
Mówca: **Sal Ignacius**
> ""As your future Grand Vizier, I vow to exceed the expectations placed upon me by both God and the king, ensuring that every task is carried out with utmost diligence and dedication.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Empty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Empty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Empty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Empty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Empty"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[86]`
Mówca: **Sal Ignacius**
> ""Overall, it heartens me to hear your acceptance of at least some of my proposals. Though it falls short of the full theocratic reformation I envisioned, it signifies a step forward nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[87]`
Mówca: **Sal Ignacius**
> ""It pains me to hear you reject all of my proposals. Enforcing such measures would have been a pivotal step towards establishing divine governance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Sal Ignacius**
> ""That's encouraging to hear. I'll most certainly put in a petition when the time comes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[90]`
Mówca: **Sal Ignacius**
> ""Thanks again, Your Majesty. You have no idea how much this means for me, and for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[91]`
Mówca: **Sal Ignacius**
> ""That the advantages of appointing me to such a position would be immense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[92]`
Mówca: **Sal Ignacius**
> ""Very well. Moving on...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, it goes without saying that Titus wouldn't be happy about that. However, seeing as how he's my security counselor, I don't see him putting up much of a fuss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Titus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[97]`
Mówca: **Sal Ignacius**
> ""My second proposal would be to take the responsibilities currently bestowed upon the Golden Guard, and give them to the Wruhec's Guardians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Makes sense. If this kingdom is to fully embrace the one true faith, then it needs to in all matters of governance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Golden Guard's history of protecting the monarchy dates back centuries. I won't be the ruler to discard such a longstanding tradition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Ah, throw tradition out the window. Sure! I'm open to the idea. The palace could certainly use a shakeup.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, it goes without saying that Titus wouldn't be happy about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[102]`
Mówca: **Sal Ignacius**
> ""Which brings me to the last topic I wanted to discuss... the royal council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[106]`
Mówca: **Sal Ignacius**
> ""Splendid! There's so much you and I can do together to see this through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[107]`
Mówca: **Sal Ignacius**
> ""I'm glad you brought that up, actually. My final proposal is in regard to the royal council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Sal Ignacius**
> ""To put it simply, they ought to be supplanted by a religious council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[109]`
Mówca: **Sal Ignacius**
> ""Captain Gordion is one of the most honorable men in this kingdom. I'm sure we could arrange for him to serve in a similar capacity under the Guardians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[110]`
Mówca: **Sal Ignacius**
> ""I'm glad you see it that way, as it aligns perfectly with my ultimate proposal for the royal council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[111]`
Mówca: **Sal Ignacius**
> ""Of course. And I don't mean to diminish or disparage any of their past accomplishments. I only seek to ensure this kingdom reaches its full potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_RebelKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_RebelKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_RebelKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_RebelKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_RebelKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course! I was considering such a change myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely. Without question. Overseeing a religious government without your kind of spiritual leadership would be a sin in and of itself." [Appoint Grand Vizier]"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier = false; RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] = false;
Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[122]`
Mówca: **Sal Ignacius**
> ""That said, I would recommend that Captain Gordion continue his current duties, but oversee the Guardians instead, considering his unwavering dedication to Wruhecism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[98]`
  - -> `[94]`
  - -> `[115]`
