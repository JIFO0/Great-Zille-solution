# Sordland/Turn03/Reformist Post Discussion

- **ID konwersacji:** `30`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/030_Reformist_Post_Discussion.md`
- **Liczba węzłów dialogowych:** 135
- **Liczba wyborów gracza:** 21

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
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
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Honorary_Presidents`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Ministers_Default`
- `BaseGame.Reform_Law_Threshold_3`
- `BaseGame.Reform_Law_Threshold_8`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Reform_Law_Veto_Default`
- `BaseGame.Relations_Nia_Opposition`
- `BaseGameSupport.Journal_Turn03_ReformPackage_Reformist`
- `BaseGameSupport.News_Turn03_R_OldYSBansRedYouth`
- `BaseGameSupport.News_Turn03_ST_BanYoungSords`
- `BaseGameSupport.News_Turn03_ST_LeadingReforms_Deal_R`
- `BaseGameSupport.News_Turn03_ST_OldRYBansYoungSords`
- `BaseGameSupport.News_Turn03_ST_RicterVictory_NoDeal_R`
- `BaseGameSupport.Report_Turn03_Holsord_ReformCommittee`
- `GameCondition.Turn03_A_AutocratSpeech`
- `GameCondition.Turn03_A_Constitution`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[29] Sordland/Turn03/A_ReformistConstitution** (../Turn_03/029_A_ReformistConstitution.md), Węzeł `[160]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 10

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Nia_Opposition`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[98]` (Paskal Beniwoll): `Variable["GameCondition.Turn03_A_Constitution"] = true; Variable["BaseGameSupport.Report_Turn03_H...`
- Węzeł `[99]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn03_ReformPackage_Reformist"] = true;`
- Węzeł `[100]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn03_ST_LeadingReforms_Deal_R"] = true;`
- Węzeł `[104]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn03_ST_RicterVictory_NoDeal_R"] = true;`
- Węzeł `[105]` (Paskal Beniwoll): `Variable["GameCondition.Turn03_A_AutocratSpeech"] = true;`
- Węzeł `[109]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn03_R_OldYSBansRedYouth"] = true;`
- Węzeł `[110]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn03_ST_BanYoungSords"] = true;`
- Węzeł `[117]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn03_ST_OldRYBansYoungSords"] = true;`
- *...oraz 2 innych węzłów ze skryptami.*

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
  - -> `[99]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `29` (*Sordland/Turn03/A_ReformistConstitution*), Węzeł `[160]`

### Węzeł `[3]`
Mówca: **Narrator**
> "They read the changes and discussed it amongst themselves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[4]`
Mówca: **Narrator**
> "After I made the final changes for the proposal, I showed it to my team."
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
  - -> `[25]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[21]`
Mówca: **Narrator**
> "Lucian spoke afterwards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Ministers_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[25]`
Mówca: **Nia Morgna**
> ""Mr. President, I understand that you're trying to save your skin by giving absolute immunity to presidents but isn't that going a bit too far?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Nia Morgna**
> ""That contradicts the whole package. If this doesn't pass, it will be on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`
  - -> `[29]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""Have a little faith, Mrs. Morgna.""]** — Mówca: **Player**
> ""Have a little faith, Mrs. Morgna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[28]`
**[WYBÓR GRACZA: ""I appreciate your comments but the decision is made.""]** — Mówca: **Player**
> ""I appreciate your comments but the decision is made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
**[WYBÓR GRACZA: ""I will be the target of the Supreme Court, I need this protection.""]** — Mówca: **Player**
> ""I will be the target of the Supreme Court, I need this protection.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Lucian Galade**
> ""Mr. Rayne is not wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[31]`
Mówca: **Nia Morgna**
> ""I will be doing my part, Mr. President, don't think I won't. But I had to clarify my position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[32]`
Mówca: **Petr Vectern**
> ""But I have to say this too...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Petr Vectern**
> ""The new electoral threshold will be really difficult for the party to accept. Our guys are not fond of that idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[34]`
Mówca: **Petr Vectern**
> ""But I have to say this too...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Petr Vectern**
> ""Not reforming the minister laws will be frowned upon by the party. The Assembly members have insisted on getting involved in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Lucian Galade**
> ""That's true. It will be tough to get all of their support. Some of our members may try to openly fight against this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[42]`
  - -> `[41]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Ministers_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[40]`
Mówca: **Petr Vectern**
> ""Not reforming the minister laws will also be frowned upon by the party. The Assembly members have insisted on getting involved in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""I'm prepared to reconsider if it comes to that.""]** — Mówca: **Player**
> ""I'm prepared to reconsider if it comes to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[42]`
**[WYBÓR GRACZA: ""I will make sure the party follows me.""]** — Mówca: **Player**
> ""I will make sure the party follows me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
**[WYBÓR GRACZA: ""We'll figure it out.""]** — Mówca: **Player**
> ""We'll figure it out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Lucian Galade**
> ""Any comments before we proceed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[45]`
Mówca: **Lucian Galade**
> ""We will all do our best to make it work, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Lucian Galade**
> ""Any other comments before we proceed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[47]`
Mówca: **Nia Morgna**
> ""I will say that I do not agree with the new law that gives the Assembly the power to impeach the Judges of the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Nia Morgna**
> ""I am also against the Chief Justice and his obstructionist behaviour, but even if we get rid of all of them, the new Judges will be less independent with this law. They will be scared to go against the administration when it's needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Nia Morgna**
> ""They need their protection to do their job. Otherwise the new ones will be pawns just like Soll's Old Guards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Petr Vectern**
> ""But it's more important that we get rid of the Old Guards, Mrs. Morgna. After the obstacles are gone, we can strive to make it better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[51]`
Mówca: **Nia Morgna**
> ""I will say that I do not agree with the changes to the Member of Honor law. I see that you're trying hard to get immunity and save your skin after your term, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Nia Morgna**
> ""This law should have been abolished. It was made to protect Soll and now you're trying to give this to every president. This conflicts with our idea of 'democratic reforms', sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`
  - -> `[63]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[56]`
Mówca: **Nia Morgna**
> ""What about the changes to the Member of Honor law? I see that the President is trying very hard to get immunity and save his skin after his term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Narrator**
> "She looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[58]`
Mówca: **Petr Vectern**
> ""I think I gotta say that removing the decrees was not the best choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Petr Vectern**
> ""It will significantly reduce the powers of the president, especially in case of crises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[60]`
Mówca: **Petr Vectern**
> ""However...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[61]`
**[WYBÓR GRACZA: ""As I said, I will have a target on my back, I need the immunity.""]** — Mówca: **Player**
> ""As I said, I will have a target on my back, I need the immunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[62]`
**[WYBÓR GRACZA: ""You're reading too much into it, Mrs. Morgna.""]** — Mówca: **Player**
> ""You're reading too much into it, Mrs. Morgna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""It seems we must learn to disagree.""]** — Mówca: **Player**
> ""It seems we must learn to disagree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Narrator**
> "She looked a little angry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[68]`
Mówca: **Petr Vectern**
> ""Before we finish...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[69]`
Mówca: **Narrator**
> "He turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Petr Vectern**
> ""You have to be careful, Anton. I'm sure you will be fine, but with all that's happening out there, we'll need to prepare against these threats one way or the other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[74]`
  - -> `[75]`

### Węzeł `[71]`
Mówca: **Lucian Galade**
> ""Looks like we can proceed immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[72]`
Mówca: **Petr Vectern**
> ""I don't think I have any problems with the changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Nia Morgna**
> ""Me neither.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[74]`
**[WYBÓR GRACZA: ""I appreciate the feedback, Petr.""]** — Mówca: **Player**
> ""I appreciate the feedback, Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[75]`
**[WYBÓR GRACZA: ""The constitution hasn't changed yet. We'll prepare until then.""]** — Mówca: **Player**
> ""The constitution hasn't changed yet. We'll prepare until then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
**[WYBÓR GRACZA: ""I am aware.""]** — Mówca: **Player**
> ""I am aware.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Lucian Galade**
> ""Well, I think we can proceed now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[78]`
Mówca: **Lucian Galade**
> ""We will be working on the wording of the proposal closely with our legal experts before we propose it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Lucian Galade**
> ""In the meantime, you must introduce this proposal to our party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Lucian Galade**
> ""You'll need to give a strong speech to get them behind you. But I advise you to first talk to the leaders of both conservative and reformist wings of the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Petr Vectern**
> ""As far as I'm aware, Mr. Clavin supports the reforms already. Mrs. Tory will be the real problem. She became the real heavy-weight after we left for the executive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[83]`
  - -> `[82]`

### Węzeł `[82]`
**[WYBÓR GRACZA: ""I will handle them.""]** — Mówca: **Player**
> ""I will handle them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[83]`
**[WYBÓR GRACZA: ""Any advice for the speech?""]** — Mówca: **Player**
> ""Any advice for the speech?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[84]`
**[WYBÓR GRACZA: ""Any advice in regards to dealing with them?""]** — Mówca: **Player**
> ""Any advice in regards to dealing with them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Lucian Galade**
> ""As Mr. Vectern said, Mr. Clavin will probably be easier to persuade. We need to unite the party under this, so his support is vital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Lucian Galade**
> ""Mrs. Gloria will be tougher to break. The problem is that she's capable of turning the moderates and the conservatives against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Lucian Galade**
> ""As much as I don't want to say this, if she makes demands to change the proposal, you may need to give in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[94]`
  - -> `[93]`

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""Sir, you are pretty well-versed in speeches. You know the party. Just make sure you get them hyped up about the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Lucian Galade**
> ""And don't show any weakness. You must also be prepared to reconsider the proposal if it comes to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[94]`
  - -> `[93]`

### Węzeł `[90]`
Mówca: **Petr Vectern**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Lucian Galade**
> ""Don't show any weakness, sir. And be prepared to reconsider the proposal if it comes to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[94]`
  - -> `[93]`

### Węzeł `[92]`
**[WYBÓR GRACZA: ""Thanks for the advice.""]** — Mówca: **Player**
> ""Thanks for the advice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[93]`
**[WYBÓR GRACZA: ""I will not give in.""]** — Mówca: **Player**
> ""I will not give in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[94]`
**[WYBÓR GRACZA: ""Understood.""]** — Mówca: **Player**
> ""Understood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Narrator**
> "We all shook hands and they left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[96]`
Mówca: **Lucian Galade**
> ""Wish you good luck with the party, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Lucian Galade**
> ""I think we can end the meeting here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_A_Constitution = true;
BaseGameSupport.Report_Turn03_Holsord_ReformCommittee = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_A_Constitution"] = true;
Variable["BaseGameSupport.Report_Turn03_Holsord_ReformCommittee"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn03_ReformPackage_Reformist = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn03_ReformPackage_Reformist"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_LeadingReforms_Deal_R = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_LeadingReforms_Deal_R"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_RicterVictory_NoDeal_R = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_RicterVictory_NoDeal_R"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_A_AutocratSpeech = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_A_AutocratSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true && BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true && BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Nationalist == true && BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_R_OldYSBansRedYouth = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_R_OldYSBansRedYouth"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_BanYoungSords = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_BanYoungSords"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == false && BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == false && BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == false  and  Variable["BaseGame.Prologue_University_Political_Socialist"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == false && BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == false  and  Variable["BaseGame.Prologue_University_Political_Socialist"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_OldRYBansYoungSords = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_OldRYBansYoungSords"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Honorary_Presidents == true
))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Nia_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Nia Morgna**
> ""Proceed all you like. I am not behind this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[124]`
  - -> `[123]`

### Węzeł `[123]`
**[WYBÓR GRACZA: ""Aren't you changing your mind too quickly?""]** — Mówca: **Player**
> ""Aren't you changing your mind too quickly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[124]`
**[WYBÓR GRACZA: ""It's fine. We'll figure something out.""]** — Mówca: **Player**
> ""It's fine. We'll figure something out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[125]`
**[WYBÓR GRACZA: ""We need you, Mrs. Morgna. Don't be like that.""]** — Mówca: **Player**
> ""We need you, Mrs. Morgna. Don't be like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[126]`
Mówca: **Nia Morgna**
> ""You already knew about my position, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[127]`
Mówca: **Nia Morgna**
> ""I doubt that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Nia Morgna**
> ""You should have listened to my advice, Mr. President...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Lucian Galade**
> ""Let's figure this out later, ladies and gentlemen. The president has already made his decision. Let's move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[130]`
Mówca: **Nia Morgna**
> ""I will personally work on the wording of this proposal with my hand-picked legal experts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Nia Morgna**
> ""In the meantime, you must introduce this proposal to our party. You will need to get them to back us if we want it to pass the assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Lucian Galade**
> ""With Ms. Morgna's reputation as the most experienced attorney, this proposal will be bulletproof. Chief Justice Orso will have a hard time convincing others to oppose it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[133]`
Mówca: **Lucian Galade**
> ""Sir, I advise you to first talk to the leaders of both conservative and reformist wings of the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Veto_Default = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Veto_Default"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
