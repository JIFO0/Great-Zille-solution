# Sordland/Turn09/PFJP Investigation

- **ID konwersacji:** `190`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/190_PFJP_Investigation.md`
- **Liczba węzłów dialogowych:** 100
- **Liczba wyborów gracza:** 16

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Fired_KarlGreiser`
- `BaseGame.Reform_Alliance_NFP`
- `BaseGame.Reform_Turn07_Emergency_Detained_Frens`
- `BaseGame.Relations_Frens_Bribed`
- `BaseGame.Relations_Frens_Promise_Taurus`
- `BaseGame.Relations_Lucian_Opinion`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`
- `BaseGame.Turn07_SecretState_Detained_FrensRicter`
- `BaseGame.Turn07_SecretState_Kill_FrensRicter`
- `BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedNFP`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.PFJPLeader_Manoly`
- `BaseGame.Turn09_A_Investigation_PFJP_ManolyFramed`
- `BaseGame.Turn09_A_Investigation_PFJP_RicterFramed`
- `BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedReformists`
- `BaseGameSupport.Journal_Turn09_Investigations_ManolyFramed`
- `BaseGameSupport.Journal_Turn09_Investigations_RicterFramed`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[188] Sordland/Turn09/A_CampaignAndInvestigations** (../Turn_09/188_A_CampaignAndInvestigations.md), Węzeł `[56]`
- Węzeł `[96]` -> **[188] Sordland/Turn09/A_CampaignAndInvestigations** (../Turn_09/188_A_CampaignAndInvestigations.md), Węzeł `[64]`
- Węzeł `[97]` -> **[189] Sordland/Turn09/NFP Investigation** (../Turn_09/189_NFP_Investigation.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 5

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[7]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedReformists"] = true;`
- Węzeł `[63]` (Paskal Beniwoll): `Variable["BaseGame.Turn09_A_Investigation_PFJP_ManolyFramed"] = true;`
- Węzeł `[70]` (Paskal Beniwoll): `Variable["BaseGame.Turn09_A_Investigation_PFJP_RicterFramed"] = true;`
- Węzeł `[98]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn09_Investigations_RicterFramed"] = true;`
- Węzeł `[99]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn09_Investigations_ManolyFramed"] = true; Variable["BaseGame...`

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
  - -> `[5]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `188` (*Sordland/Turn09/A_CampaignAndInvestigations*), Węzeł `[56]`

### Węzeł `[3]`
Mówca: **Lucian Galade**
> ""Unfortunately, sir, the Reformists appear to be as clean as a whistle. Earlier rumors about connections to oligarchs turned out to be just that: rumors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[4]`
**[WYBÓR GRACZA: ""Then you'll just have to make sure Nia never finds out.""]** — Mówca: **Player**
> ""Then you'll just have to make sure Nia never finds out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Reformists Investigation)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Lucian Galade**
> ""Not only on your chances of re-election -- but on the remainder of your current term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[12]`
  - -> `[38]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedReformists = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedReformists"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true || BaseGame.Relations_Frens_Bribed == true || BaseGame.Relations_Frens_Promise_Taurus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true || BaseGame.Relations_Frens_Bribed == true || BaseGame.Relations_Frens_Promise_Taurus == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  or  Variable["BaseGame.Relations_Frens_Bribed"] == true  or  Variable["BaseGame.Relations_Frens_Promise_Taurus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true || BaseGame.Relations_Frens_Bribed == true || BaseGame.Relations_Frens_Promise_Taurus == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  or  Variable["BaseGame.Relations_Frens_Bribed"] == true  or  Variable["BaseGame.Relations_Frens_Promise_Taurus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`
  - -> `[17]`

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""However...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[12]`
**[WYBÓR GRACZA: ""I was stupid enough to order this investigation. I deserve what's coming to me.""]** — Mówca: **Player**
> ""I was stupid enough to order this investigation. I deserve what's coming to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[13]`
**[WYBÓR GRACZA: ""I certainly hope so.""]** — Mówca: **Player**
> ""I certainly hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[14]`
Mówca: **Lucian Galade**
> ""Frankly, sir, I'll do what I can, but I may not be able to protect you from the consequences of your reprehensible conduct.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[15]`
**[WYBÓR GRACZA: ""That's it? That's the result of a years-long investigation?""]** — Mówca: **Player**
> ""That's it? That's the result of a years-long investigation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[16]`
**[WYBÓR GRACZA: ""Really? What are these people, saints?""]** — Mówca: **Player**
> ""Really? What are these people, saints?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[17]`
**[WYBÓR GRACZA: ""What if we were to manufacture some dirt on them?""]** — Mówca: **Player**
> ""What if we were to manufacture some dirt on them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[18]`
Mówca: **Narrator**
> "Lucian lowered his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
**[WYBÓR GRACZA: ""Yes. Screw it. Let's sink Ricter once and for all.""]** — Mówca: **Player**
> ""Yes. Screw it. Let's sink Ricter once and for all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[23]`
Mówca: **Narrator**
> "Lucian shrugged stiffly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[24]`
Mówca: **Lucian Galade**
> ""Nia and her Anti-Corruption police would be likely to find out. In fact, you're lucky your behavior towards the party has been, well, unimpeachable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Yes. Screw it. Let's sink Manoly before she gets any more popular.""]** — Mówca: **Player**
> ""Yes. Screw it. Let's sink Manoly before she gets any more popular.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_FrensRicter == true || BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Reform_Turn07_Emergency_Detained_Frens == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_FrensRicter == true || BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Reform_Turn07_Emergency_Detained_Frens == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Kill_FrensRicter == true || BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Reform_Turn07_Emergency_Detained_Frens == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedNFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedNFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedNFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedNFP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_A_CampaignInvestigations_DiscussedNFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[32]`
**[WYBÓR GRACZA: ""No. I'll beat them in the election fair and square.""]** — Mówca: **Player**
> ""No. I'll beat them in the election fair and square.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_FrensRicter == true || BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Reform_Turn07_Emergency_Detained_Frens == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_FrensRicter == true || BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Reform_Turn07_Emergency_Detained_Frens == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[32]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Kill_FrensRicter == true || BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Reform_Turn07_Emergency_Detained_Frens == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[19]`

### Węzeł `[36]`
Mówca: **Lucian Galade**
> ""It would be fairly easy to plant incriminating evidence against Manoly Suheil and have her trialled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[37]`
Mówca: **Lucian Galade**
> ""It would be fairly easy to plant incriminating evidence against Ricter and have him trialled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""It's not fair! I didn't do anything wrong.""]** — Mówca: **Player**
> ""It's not fair! I didn't do anything wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_NFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_NFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Alliance_NFP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[42]`
**[WYBÓR GRACZA: ""You're lying.""]** — Mówca: **Player**
> ""You're lying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""As you wish. I'll give the order to the new police chief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[44]`
**[WYBÓR GRACZA: ""Damn. I knew I shouldn't have done that.""]** — Mówca: **Player**
> ""Damn. I knew I shouldn't have done that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[45]`
Mówca: **Lucian Galade**
> ""That would put a rather abrupt end to the momentum she's been gathering and help clear the path for your re-election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[46]`
Mówca: **Lucian Galade**
> ""Your previous actions with Ricter have already put you on shaky moral ground, wouldn't you say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[47]`
Mówca: **Lucian Galade**
> ""Forming the Secret State Police already put you on rather shaky moral ground, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[48]`
Mówca: **Lucian Galade**
> ""That would help drain support from the Reformists and clear the path for your re-election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[49]`
Mówca: **Lucian Galade**
> ""Mr. President, you're already about to neutralize one of your biggest opposition parties. Taking out both would just be wishful thinking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[50]`
Mówca: **Lucian Galade**
> ""You'll be happy to hear that the investigation into the NFP was rather more successful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[51]`
Mówca: **Lucian Galade**
> ""Don't worry, Mr. President. I'm sure these allegations will be easy to sweep under the rug.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[52]`
Mówca: **Narrator**
> "Lucian sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[53]`
Mówca: **Lucian Galade**
> ""As you wish. I'll give the order to Mr. Greiser.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[54]`
Mówca: **Lucian Galade**
> ""The Anti-Corruption Police did turn up evidence of your having offered Frens Ricter a substantial sum of money in exchange for his party's support,""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[68]`
  - -> `[44]`

### Węzeł `[55]`
**[WYBÓR GRACZA: ""What? Lies!""]** — Mówca: **Player**
> ""What? Lies!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[56]`
Mówca: **Lucian Galade**
> ""I'll do what I can to mitigate the damage. But I can't promise there won't be consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[57]`
Mówca: **Narrator**
> "His gaze seemed to be fixed on some faraway corner of the hotel room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[13]`

### Węzeł `[58]`
**[WYBÓR GRACZA: ""I like the way you're thinking.""]** — Mówca: **Player**
> ""I like the way you're thinking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[59]`
**[WYBÓR GRACZA: ""Wouldn't it also be, you know, illegal?""]** — Mówca: **Player**
> ""Wouldn't it also be, you know, illegal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[60]`
Mówca: **Lucian Galade**
> ""I'm sorry I couldn't bring you better news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[61]`
Mówca: **Lucian Galade**
> ""So, should I give the order?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[62]`
Mówca: **Lucian Galade**
> ""I do tend to be right on these matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_PFJP_ManolyFramed = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_PFJP_ManolyFramed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Bribed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Bribed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Bribed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Frens_Bribed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Bribed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[67]`
Mówca: **Lucian Galade**
> ""Thank you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[68]`
**[WYBÓR GRACZA: ""What's the big deal? He's the one who accepted it.""]** — Mówca: **Player**
> ""What's the big deal? He's the one who accepted it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[69]`
Mówca: **Lucian Galade**
> ""As you wish. I'll give the order to the new police chief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_PFJP_RicterFramed = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_PFJP_RicterFramed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Lucian_Opinion"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Lucian_Opinion > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Lucian_Opinion"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Lucian_Opinion"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Lucian_Opinion > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Lucian_Opinion"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[77]`
Mówca: **Lucian Galade**
> ""With the opposition still in play, rallying your base is of the utmost importance. I'll let you prepare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[78]`
Mówca: **Lucian Galade**
> ""The Anti-Corruption Police did turn up evidence of your having offered Frens Ricter a high-value construction contract in exchange for his party's support,""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[68]`
  - -> `[44]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Fired_KarlGreiser == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_FrensRicter == true || BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Reform_Turn07_Emergency_Detained_Frens == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_FrensRicter == true || BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Reform_Turn07_Emergency_Detained_Frens == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Kill_FrensRicter == true || BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Reform_Turn07_Emergency_Detained_Frens == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Fired_KarlGreiser == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""Now that that's settled, I'll let you prepare for your rally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[89]`
Mówca: **Lucian Galade**
> ""I have no doubt of that, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion < 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Lucian_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Lucian_Opinion < 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Lucian_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Lucian Galade**
> ""If word of this gets back to Mrs. Morgna, it could have dire repercussions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[94]`
Mówca: **Lucian Galade**
> ""As you wish. I'll give the order to Mr. Greiser.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[95]`
Mówca: **Lucian Galade**
> ""Those who believe in you, myself included, would argue your re-election takes a higher priority than pesky questions of legality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Campaign Rally])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `188` (*Sordland/Turn09/A_CampaignAndInvestigations*), Węzeł `[64]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [NFP Investigation])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `189` (*Sordland/Turn09/NFP Investigation*), Węzeł `[1]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Investigations_RicterFramed = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_RicterFramed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Investigations_ManolyFramed = true;
BaseGame.PFJPLeader_Manoly = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_ManolyFramed"] = true;
Variable["BaseGame.PFJPLeader_Manoly"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
