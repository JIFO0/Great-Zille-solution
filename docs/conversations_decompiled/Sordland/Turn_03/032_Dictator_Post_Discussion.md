# Sordland/Turn03/Dictator Post Discussion

- **ID konwersacji:** `32`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/032_Dictator_Post_Discussion.md`
- **Liczba węzłów dialogowych:** 83
- **Liczba wyborów gracza:** 12

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth`
- `BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Prologue_University_Political_Nationalist`
- `BaseGame.Prologue_University_Political_Socialist`
- `BaseGame.Reform_Law_Honorary_Presidents`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Ministers_Default`
- `BaseGame.Reform_Law_Threshold_3`
- `BaseGame.Reform_Law_Threshold_8`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Relations_Nia_Opposition`
- `BaseGameSupport.Journal_Turn03_ReformPackage_Dictator`
- `BaseGameSupport.News_Turn03_R_OldYSBansRedYouth`
- `BaseGameSupport.News_Turn03_ST_BanYoungSords`
- `BaseGameSupport.News_Turn03_ST_DangerousReforms_NoDeal_D`
- `BaseGameSupport.News_Turn03_ST_LeadingReforms_Deal_D`
- `BaseGameSupport.News_Turn03_ST_OldRYBansYoungSords`
- `BaseGameSupport.Report_Turn03_Holsord_ReformCommittee`
- `GameCondition.Turn03_A_AutocratSpeech`
- `GameCondition.Turn03_A_Constitution`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[31] Sordland/Turn03/A_DictatorConstitution** (../Turn_03/031_A_DictatorConstitution.md), Węzeł `[154]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 9

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Nia_Opposition`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[59]` (Paskal Beniwoll): `Variable["GameCondition.Turn03_A_Constitution"] = true; Variable["BaseGameSupport.Report_Turn03_H...`
- Węzeł `[60]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn03_ReformPackage_Dictator"] = true;`
- Węzeł `[64]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn03_ST_DangerousReforms_NoDeal_D"] = true;`
- Węzeł `[65]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn03_ST_LeadingReforms_Deal_D"] = true;`
- Węzeł `[66]` (Paskal Beniwoll): `Variable["GameCondition.Turn03_A_AutocratSpeech"] = true;`
- Węzeł `[70]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn03_R_OldYSBansRedYouth"] = true;`
- Węzeł `[74]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn03_ST_BanYoungSords"] = true;`
- Węzeł `[78]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn03_ST_OldRYBansYoungSords"] = true;`
- *...oraz 1 innych węzłów ze skryptami.*

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
  - -> `[60]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `31` (*Sordland/Turn03/A_DictatorConstitution*), Węzeł `[154]`

### Węzeł `[3]`
Mówca: **Narrator**
> "After looking into the changes the team began discussing it amongst themselves. Lucian spoke afterwards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Narrator**
> "After the final changes to the proposal were made, I showed it to the team."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[5]`
Mówca: **Lucian Galade**
> ""Looks like the amendments are ready to be proposed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Lucian Galade**
> ""Mr. Clavin will be tougher to break. The problem is that he can also influence the moderates against this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Ministers_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[16]`
Mówca: **Lucian Galade**
> ""I think we can end the meeting here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[17]`
Mówca: **Lucian Galade**
> ""But sir, I understand that you're trying to get rid of the impeachment, however I have to say that it may create problems within the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Lucian Galade**
> ""We have to make sure they get behind that part. We do not want to lose the support of USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`
  - -> `[23]`

### Węzeł `[19]`
**[WYBÓR GRACZA: ""We'll figure it out.""]** — Mówca: **Player**
> ""We'll figure it out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[20]`
**[WYBÓR GRACZA: ""I will make sure they get behind.""]** — Mówca: **Player**
> ""I will make sure they get behind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""I appreciate your comments but the decision is made.""]** — Mówca: **Player**
> ""I appreciate your comments but the decision is made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[22]`
Mówca: **Lucian Galade**
> ""Wish you good luck with the party, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[23]`
**[WYBÓR GRACZA: ""We will handle the party.""]** — Mówca: **Player**
> ""We will handle the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Narrator**
> "We all shook hands and they left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[25]`
Mówca: **Lucian Galade**
> ""We will all be doing our part, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[26]`
Mówca: **Lucian Galade**
> ""We will all do our best to make it work, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[27]`
Mówca: **Petr Vectern**
> ""I have to say...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
**[WYBÓR GRACZA: ""Understood.""]** — Mówca: **Player**
> ""Understood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[29]`
Mówca: **Petr Vectern**
> ""The new lower electoral threshold will be really difficult for the party to accept. Our guys are not fond of that idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[30]`
**[WYBÓR GRACZA: ""I will not give in.""]** — Mówca: **Player**
> ""I will not give in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[31]`
Mówca: **Petr Vectern**
> ""But I have to say this too...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Petr Vectern**
> ""Not reforming the minister laws will be frowned upon by the party. The Assembly members have insisted on getting involved in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Lucian Galade**
> ""That's true. It will be tough to get all of their support. Some of our members may try to openly fight against this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[55]`
  - -> `[40]`

### Węzeł `[34]`
**[WYBÓR GRACZA: ""Thanks for the advice.""]** — Mówca: **Player**
> ""Thanks for the advice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Ministers_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[38]`
Mówca: **Petr Vectern**
> ""Not reforming the minister laws will also be frowned upon by the party. The Assembly members have insisted on getting involved in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[39]`
Mówca: **Lucian Galade**
> ""And be prepared to reconsider the proposal if it comes to that, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[28]`
  - -> `[30]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""I'm prepared to reconsider if it comes to that.""]** — Mówca: **Player**
> ""I'm prepared to reconsider if it comes to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[41]`
Mówca: **Petr Vectern**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[42]`
Mówca: **Lucian Galade**
> ""In the meantime, you must introduce this proposal to our party, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""You must also be prepared to reconsider the proposal if it comes to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[28]`
  - -> `[30]`

### Węzeł `[44]`
Mówca: **Lucian Galade**
> ""Any other comments before we proceed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[45]`
Mówca: **Lucian Galade**
> ""We will be working on the wording of the proposal with our legal experts before we propose it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[46]`
Mówca: **Lucian Galade**
> ""You'll need to a strong speech to get them behind you. But I advise you to first talk to the leaders of the both conservative and reformist wings of the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[47]`
Mówca: **Lucian Galade**
> ""Sir, you are pretty well-versed in speeches. You know the party. Just make sure you get them hyped up about the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[48]`
Mówca: **Lucian Galade**
> ""As much as I don't want to say this, if they make any demands to change the proposal, you may need to give in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[28]`
  - -> `[30]`

### Węzeł `[49]`
Mówca: **Lucian Galade**
> ""Any other comments before we proceed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[50]`
Mówca: **Lucian Galade**
> ""As Mr. Vectern said, Mrs. Tory will probably be easier to persuade. We need to unite the party under these changes, so her support is vital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[51]`
Mówca: **Petr Vectern**
> ""As far as I'm aware, Mr. Clavin will be our biggest problem, he may try to paint you as a dictator. Mrs. Tory will also be tough but we'll need to get her first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`
  - -> `[54]`

### Węzeł `[52]`
**[WYBÓR GRACZA: ""Any advice in regards to dealing with them?""]** — Mówca: **Player**
> ""Any advice in regards to dealing with them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[53]`
**[WYBÓR GRACZA: ""Any advice for the speech?""]** — Mówca: **Player**
> ""Any advice for the speech?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[54]`
**[WYBÓR GRACZA: ""I will handle them.""]** — Mówca: **Player**
> ""I will handle them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[55]`
**[WYBÓR GRACZA: ""Then we will fight back.""]** — Mówca: **Player**
> ""Then we will fight back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[56]`
Mówca: **Petr Vectern**
> ""I'm good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Lucian Galade**
> ""Let's proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Narrator**
> "Lucian looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_A_Constitution = true;
BaseGameSupport.Report_Turn03_Holsord_ReformCommittee = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_A_Constitution"] = true;
Variable["BaseGameSupport.Report_Turn03_Holsord_ReformCommittee"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn03_ReformPackage_Dictator = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn03_ReformPackage_Dictator"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_DangerousReforms_NoDeal_D = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_DangerousReforms_NoDeal_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_LeadingReforms_Deal_D = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_LeadingReforms_Deal_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_A_AutocratSpeech = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_A_AutocratSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true && BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true && BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Nationalist == true && BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_R_OldYSBansRedYouth = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_R_OldYSBansRedYouth"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_BanYoungSords = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_BanYoungSords"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == false && BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == false && BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == false  and  Variable["BaseGame.Prologue_University_Political_Socialist"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == false && BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == false  and  Variable["BaseGame.Prologue_University_Political_Socialist"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_OldRYBansYoungSords = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_OldRYBansYoungSords"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Nia_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Honorary_Presidents == true
))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
