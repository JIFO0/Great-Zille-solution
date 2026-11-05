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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[27]` | **""Have a little faith, Mrs. Morgna.""** | `[26]` **Nia Morgna**: ""That contradicts the whole pack..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Nia Morgna**: ""I will be doing my part, Mr. Pr..." |
| `[28]` | **""I appreciate your comments but the decision is made.""** | `[26]` **Nia Morgna**: ""That contradicts the whole pack..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Nia Morgna**: ""I will be doing my part, Mr. Pr..." |
| `[29]` | **""I will be the target of the Supreme Court, I need this protection.""** | `[26]` **Nia Morgna**: ""That contradicts the whole pack..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Lucian Galade**: ""Mr. Rayne is not wrong."" |
| `[41]` | **""I'm prepared to reconsider if it comes to that.""** | `[36]` **Lucian Galade**: ""That's true. It will be tough t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Lucian Galade**: ""We will all do our best to make..." |
| `[42]` | **""I will make sure the party follows me.""** | `[36]` **Lucian Galade**: ""That's true. It will be tough t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Lucian Galade**: ""We will all do our best to make..." |
| `[43]` | **""We'll figure it out.""** | `[36]` **Lucian Galade**: ""That's true. It will be tough t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Lucian Galade**: ""We will all do our best to make..." |
| `[61]` | **""As I said, I will have a target on my back, I need the immunity.""** | `[52]` **Nia Morgna**: ""This law should have been aboli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Narrator**: "She looked a little angry." |
| `[62]` | **""You're reading too much into it, Mrs. Morgna.""** | `[52]` **Nia Morgna**: ""This law should have been aboli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Narrator**: "She looked a little angry." |
| `[63]` | **""It seems we must learn to disagree.""** | `[52]` **Nia Morgna**: ""This law should have been aboli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Narrator**: "She looked a little angry." |
| `[74]` | **""I appreciate the feedback, Petr.""** | `[70]` **Petr Vectern**: ""You have to be careful, Anton. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Lucian Galade**: ""Well, I think we can proceed now."" |
| `[75]` | **""The constitution hasn't changed yet. We'll prepare until then.""** | `[70]` **Petr Vectern**: ""You have to be careful, Anton. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Lucian Galade**: ""Well, I think we can proceed now."" |
| `[76]` | **""I am aware.""** | `[70]` **Petr Vectern**: ""You have to be careful, Anton. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Lucian Galade**: ""Well, I think we can proceed now."" |
| `[82]` | **""I will handle them.""** | `[81]` **Petr Vectern**: ""As far as I'm aware, Mr. Clavin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Petr Vectern**: ""Of course."" |
| `[83]` | **""Any advice for the speech?""** | `[81]` **Petr Vectern**: ""As far as I'm aware, Mr. Clavin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Lucian Galade**: ""Sir, you are pretty well-versed..." |
| `[84]` | **""Any advice in regards to dealing with them?""** | `[81]` **Petr Vectern**: ""As far as I'm aware, Mr. Clavin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Lucian Galade**: ""As Mr. Vectern said, Mr. Clavin..." |
| `[92]` | **""Thanks for the advice.""** | `[87]` **Lucian Galade**: ""As much as I don't want to say ..."<br>`[89]` **Lucian Galade**: ""And don't show any weakness. Yo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Lucian Galade**: ""Wish you good luck with the par..." |
| `[93]` | **""I will not give in.""** | `[87]` **Lucian Galade**: ""As much as I don't want to say ..."<br>`[89]` **Lucian Galade**: ""And don't show any weakness. Yo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Lucian Galade**: ""Wish you good luck with the par..." |
| `[94]` | **""Understood.""** | `[87]` **Lucian Galade**: ""As much as I don't want to say ..."<br>`[89]` **Lucian Galade**: ""And don't show any weakness. Yo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Lucian Galade**: ""Wish you good luck with the par..." |
| `[123]` | **""Aren't you changing your mind too quickly?""** | `[122]` **Nia Morgna**: ""Proceed all you like. I am not ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Nia Morgna**: ""You already knew about my posit..." |
| `[124]` | **""It's fine. We'll figure something out.""** | `[122]` **Nia Morgna**: ""Proceed all you like. I am not ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Nia Morgna**: ""I doubt that."" |
| `[125]` | **""We need you, Mrs. Morgna. Don't be like that.""** | `[122]` **Nia Morgna**: ""Proceed all you like. I am not ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Nia Morgna**: ""You should have listened to my ..." |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn03_ReformPackage_Reformist = ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[3]`
Mówca: **Narrator**
> "They read the changes and discussed it amongst themselves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Lucian spoke afterwards."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "After I made the final changes for the proposal, I showed it to my team."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "They read the changes and discussed it amongst themselves."*)

### Węzeł `[5]`
Mówca: **Lucian Galade**
> ""Looks like the amendments are ready to be proposed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Nia Morgna: ""Mr. President, I understand that you're trying to save y..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Nia Morgna: ""I will say that I do not agree with the new law that giv..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Ref..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Petr Vectern: ""But I have to say this too...""*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == true)"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Nia Morgna: ""I will say that I do not agree with the changes to the M..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Removed == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Petr Vectern: ""I think I gotta say that removing the decrees was not th..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Petr Vectern: ""I don't think I have any problems with the changes.""*)

### Węzeł `[21]`
Mówca: **Narrator**
> "Lucian spoke afterwards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Lucian Galade: ""Looks like the amendments are ready to be proposed.""*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Ministers_Default == true)"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Petr Vectern: ""But I have to say this too...""*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Ministers_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lucian Galade: ""Any comments before we proceed?""*)

### Węzeł `[25]`
Mówca: **Nia Morgna**
> ""Mr. President, I understand that you're trying to save your skin by giving absolute immunity to presidents but isn't that going a bit too far?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Nia Morgna: ""That contradicts the whole package. If this doesn't pass..."*)

### Węzeł `[26]`
Mówca: **Nia Morgna**
> ""That contradicts the whole package. If this doesn't pass, it will be on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: ""Have a little faith, Mrs. Morgna.""*)
  - -> `[28]` (*Player: ""I appreciate your comments but the decision is made.""*)
  - -> `[29]` (*Player: ""I will be the target of the Supreme Court, I need this p..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""Have a little faith, Mrs. Morgna.""]** — Mówca: **Player**
> ""Have a little faith, Mrs. Morgna.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Nia Morgna: ""I will be doing my part, Mr. President, don't think I wo..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: ""I appreciate your comments but the decision is made.""]** — Mówca: **Player**
> ""I appreciate your comments but the decision is made.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Nia Morgna: ""I will be doing my part, Mr. President, don't think I wo..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: ""I will be the target of the Supreme Court, I need this protection.""]** — Mówca: **Player**
> ""I will be the target of the Supreme Court, I need this protection.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lucian Galade: ""Mr. Rayne is not wrong.""*)

### Węzeł `[30]`
Mówca: **Lucian Galade**
> ""Mr. Rayne is not wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)

### Węzeł `[31]`
Mówca: **Nia Morgna**
> ""I will be doing my part, Mr. President, don't think I won't. But I had to clarify my position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)

### Węzeł `[32]`
Mówca: **Petr Vectern**
> ""But I have to say this too...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Petr Vectern: ""The new electoral threshold will be really difficult for..."*)

### Węzeł `[33]`
Mówca: **Petr Vectern**
> ""The new electoral threshold will be really difficult for the party to accept. Our guys are not fond of that idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)

### Węzeł `[34]`
Mówca: **Petr Vectern**
> ""But I have to say this too...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Petr Vectern: ""Not reforming the minister laws will be frowned upon by ..."*)

### Węzeł `[35]`
Mówca: **Petr Vectern**
> ""Not reforming the minister laws will be frowned upon by the party. The Assembly members have insisted on getting involved in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: ""That's true. It will be tough to get all of their suppor..."*)

### Węzeł `[36]`
Mówca: **Lucian Galade**
> ""That's true. It will be tough to get all of their support. Some of our members may try to openly fight against this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: ""We'll figure it out.""*)
  - -> `[42]` (*Player: ""I will make sure the party follows me.""*)
  - -> `[41]` (*Player: ""I'm prepared to reconsider if it comes to that.""*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Ministers_Default == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Petr Vectern: ""Not reforming the minister laws will also be frowned upo..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Ministers_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: ""That's true. It will be tough to get all of their suppor..."*)

### Węzeł `[40]`
Mówca: **Petr Vectern**
> ""Not reforming the minister laws will also be frowned upon by the party. The Assembly members have insisted on getting involved in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: ""That's true. It will be tough to get all of their suppor..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""I'm prepared to reconsider if it comes to that.""]** — Mówca: **Player**
> ""I'm prepared to reconsider if it comes to that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucian Galade: ""We will all do our best to make it work, sir.""*)

### Węzeł `[42]`
**[WYBÓR GRACZA: ""I will make sure the party follows me.""]** — Mówca: **Player**
> ""I will make sure the party follows me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucian Galade: ""We will all do our best to make it work, sir.""*)

### Węzeł `[43]`
**[WYBÓR GRACZA: ""We'll figure it out.""]** — Mówca: **Player**
> ""We'll figure it out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucian Galade: ""We will all do our best to make it work, sir.""*)

### Węzeł `[44]`
Mówca: **Lucian Galade**
> ""Any comments before we proceed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)

### Węzeł `[45]`
Mówca: **Lucian Galade**
> ""We will all do our best to make it work, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lucian Galade: ""Any other comments before we proceed?""*)

### Węzeł `[46]`
Mówca: **Lucian Galade**
> ""Any other comments before we proceed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)

### Węzeł `[47]`
Mówca: **Nia Morgna**
> ""I will say that I do not agree with the new law that gives the Assembly the power to impeach the Judges of the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Nia Morgna: ""I am also against the Chief Justice and his obstructioni..."*)

### Węzeł `[48]`
Mówca: **Nia Morgna**
> ""I am also against the Chief Justice and his obstructionist behaviour, but even if we get rid of all of them, the new Judges will be less independent with this law. They will be scared to go against the administration when it's needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Nia Morgna: ""They need their protection to do their job. Otherwise th..."*)

### Węzeł `[49]`
Mówca: **Nia Morgna**
> ""They need their protection to do their job. Otherwise the new ones will be pawns just like Soll's Old Guards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Petr Vectern: ""But it's more important that we get rid of the Old Guard..."*)

### Węzeł `[50]`
Mówca: **Petr Vectern**
> ""But it's more important that we get rid of the Old Guards, Mrs. Morgna. After the obstacles are gone, we can strive to make it better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)

### Węzeł `[51]`
Mówca: **Nia Morgna**
> ""I will say that I do not agree with the changes to the Member of Honor law. I see that you're trying hard to get immunity and save your skin after your term, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Nia Morgna: ""This law should have been abolished. It was made to prot..."*)

### Węzeł `[52]`
Mówca: **Nia Morgna**
> ""This law should have been abolished. It was made to protect Soll and now you're trying to give this to every president. This conflicts with our idea of 'democratic reforms', sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: ""As I said, I will have a target on my back, I need the i..."*)
  - -> `[62]` (*Player: ""You're reading too much into it, Mrs. Morgna.""*)
  - -> `[63]` (*Player: ""It seems we must learn to disagree.""*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Nia Morgna: ""What about the changes to the Member of Honor law? I see..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Petr Vectern: ""However...""*)

### Węzeł `[56]`
Mówca: **Nia Morgna**
> ""What about the changes to the Member of Honor law? I see that the President is trying very hard to get immunity and save his skin after his term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "She looked at me."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "She looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Nia Morgna: ""This law should have been abolished. It was made to prot..."*)

### Węzeł `[58]`
Mówca: **Petr Vectern**
> ""I think I gotta say that removing the decrees was not the best choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Petr Vectern: ""It will significantly reduce the powers of the president..."*)

### Węzeł `[59]`
Mówca: **Petr Vectern**
> ""It will significantly reduce the powers of the president, especially in case of crises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "He turned to me."*)

### Węzeł `[60]`
Mówca: **Petr Vectern**
> ""However...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "He turned to me."*)

### Węzeł `[61]`
**[WYBÓR GRACZA: ""As I said, I will have a target on my back, I need the immunity.""]** — Mówca: **Player**
> ""As I said, I will have a target on my back, I need the immunity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "She looked a little angry."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""You're reading too much into it, Mrs. Morgna.""]** — Mówca: **Player**
> ""You're reading too much into it, Mrs. Morgna.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "She looked a little angry."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""It seems we must learn to disagree.""]** — Mówca: **Player**
> ""It seems we must learn to disagree.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "She looked a little angry."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "She looked a little angry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Removed == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Petr Vectern: ""Before we finish...""*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lucian Galade: ""Well, I think we can proceed now.""*)

### Węzeł `[68]`
Mówca: **Petr Vectern**
> ""Before we finish...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Petr Vectern: ""I think I gotta say that removing the decrees was not th..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "He turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Petr Vectern: ""You have to be careful, Anton. I'm sure you will be fine..."*)

### Węzeł `[70]`
Mówca: **Petr Vectern**
> ""You have to be careful, Anton. I'm sure you will be fine, but with all that's happening out there, we'll need to prepare against these threats one way or the other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: ""I am aware.""*)
  - -> `[74]` (*Player: ""I appreciate the feedback, Petr.""*)
  - -> `[75]` (*Player: ""The constitution hasn't changed yet. We'll prepare until..."*)

### Węzeł `[71]`
Mówca: **Lucian Galade**
> ""Looks like we can proceed immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true &..."*)

### Węzeł `[72]`
Mówca: **Petr Vectern**
> ""I don't think I have any problems with the changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Nia Morgna: ""Me neither.""*)

### Węzeł `[73]`
Mówca: **Nia Morgna**
> ""Me neither.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lucian Galade: ""Looks like we can proceed immediately.""*)

### Węzeł `[74]`
**[WYBÓR GRACZA: ""I appreciate the feedback, Petr.""]** — Mówca: **Player**
> ""I appreciate the feedback, Petr.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lucian Galade: ""Well, I think we can proceed now.""*)

### Węzeł `[75]`
**[WYBÓR GRACZA: ""The constitution hasn't changed yet. We'll prepare until then.""]** — Mówca: **Player**
> ""The constitution hasn't changed yet. We'll prepare until then.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lucian Galade: ""Well, I think we can proceed now.""*)

### Węzeł `[76]`
**[WYBÓR GRACZA: ""I am aware.""]** — Mówca: **Player**
> ""I am aware.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lucian Galade: ""Well, I think we can proceed now.""*)

### Węzeł `[77]`
Mówca: **Lucian Galade**
> ""Well, I think we can proceed now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true &..."*)

### Węzeł `[78]`
Mówca: **Lucian Galade**
> ""We will be working on the wording of the proposal closely with our legal experts before we propose it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucian Galade: ""In the meantime, you must introduce this proposal to our..."*)

### Węzeł `[79]`
Mówca: **Lucian Galade**
> ""In the meantime, you must introduce this proposal to our party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucian Galade: ""You'll need to give a strong speech to get them behind y..."*)

### Węzeł `[80]`
Mówca: **Lucian Galade**
> ""You'll need to give a strong speech to get them behind you. But I advise you to first talk to the leaders of both conservative and reformist wings of the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Petr Vectern: ""As far as I'm aware, Mr. Clavin supports the reforms alr..."*)

### Węzeł `[81]`
Mówca: **Petr Vectern**
> ""As far as I'm aware, Mr. Clavin supports the reforms already. Mrs. Tory will be the real problem. She became the real heavy-weight after we left for the executive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: ""Any advice in regards to dealing with them?""*)
  - -> `[83]` (*Player: ""Any advice for the speech?""*)
  - -> `[82]` (*Player: ""I will handle them.""*)

### Węzeł `[82]`
**[WYBÓR GRACZA: ""I will handle them.""]** — Mówca: **Player**
> ""I will handle them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Petr Vectern: ""Of course.""*)

### Węzeł `[83]`
**[WYBÓR GRACZA: ""Any advice for the speech?""]** — Mówca: **Player**
> ""Any advice for the speech?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lucian Galade: ""Sir, you are pretty well-versed in speeches. You know th..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: ""Any advice in regards to dealing with them?""]** — Mówca: **Player**
> ""Any advice in regards to dealing with them?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lucian Galade: ""As Mr. Vectern said, Mr. Clavin will probably be easier ..."*)

### Węzeł `[85]`
Mówca: **Lucian Galade**
> ""As Mr. Vectern said, Mr. Clavin will probably be easier to persuade. We need to unite the party under this, so his support is vital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucian Galade: ""Mrs. Gloria will be tougher to break. The problem is tha..."*)

### Węzeł `[86]`
Mówca: **Lucian Galade**
> ""Mrs. Gloria will be tougher to break. The problem is that she's capable of turning the moderates and the conservatives against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lucian Galade: ""As much as I don't want to say this, if she makes demand..."*)

### Węzeł `[87]`
Mówca: **Lucian Galade**
> ""As much as I don't want to say this, if she makes demands to change the proposal, you may need to give in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: ""Thanks for the advice.""*)
  - -> `[94]` (*Player: ""Understood.""*)
  - -> `[93]` (*Player: ""I will not give in.""*)

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""Sir, you are pretty well-versed in speeches. You know the party. Just make sure you get them hyped up about the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lucian Galade: ""And don't show any weakness. You must also be prepared t..."*)

### Węzeł `[89]`
Mówca: **Lucian Galade**
> ""And don't show any weakness. You must also be prepared to reconsider the proposal if it comes to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: ""Thanks for the advice.""*)
  - -> `[94]` (*Player: ""Understood.""*)
  - -> `[93]` (*Player: ""I will not give in.""*)

### Węzeł `[90]`
Mówca: **Petr Vectern**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucian Galade: ""Don't show any weakness, sir. And be prepared to reconsi..."*)

### Węzeł `[91]`
Mówca: **Lucian Galade**
> ""Don't show any weakness, sir. And be prepared to reconsider the proposal if it comes to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: ""Thanks for the advice.""*)
  - -> `[94]` (*Player: ""Understood.""*)
  - -> `[93]` (*Player: ""I will not give in.""*)

### Węzeł `[92]`
**[WYBÓR GRACZA: ""Thanks for the advice.""]** — Mówca: **Player**
> ""Thanks for the advice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Lucian Galade), `[89]` (Lucian Galade), `[91]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucian Galade: ""Wish you good luck with the party, sir.""*)

### Węzeł `[93]`
**[WYBÓR GRACZA: ""I will not give in.""]** — Mówca: **Player**
> ""I will not give in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Lucian Galade), `[89]` (Lucian Galade), `[91]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucian Galade: ""Wish you good luck with the party, sir.""*)

### Węzeł `[94]`
**[WYBÓR GRACZA: ""Understood.""]** — Mówca: **Player**
> ""Understood.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Lucian Galade), `[89]` (Lucian Galade), `[91]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucian Galade: ""Wish you good luck with the party, sir.""*)

### Węzeł `[95]`
Mówca: **Narrator**
> "We all shook hands and they left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[96]`
Mówca: **Lucian Galade**
> ""Wish you good luck with the party, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Lucian Galade: ""I think we can end the meeting here.""*)

### Węzeł `[97]`
Mówca: **Lucian Galade**
> ""I think we can end the meeting here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "We all shook hands and they left the room."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_A_Constitution = true;
BaseGameSupport.Report_Turn03_Holsord_ReformCommittee = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_A_Constitution"] = true;
Variable["BaseGameSupport.Report_Turn03_Holsord_ReformCommittee"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == tru..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn03_ReformPackage_Reformist = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn03_ReformPackage_Reformist"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Veto_Default = false"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_LeadingReforms_Deal_R = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_LeadingReforms_Deal_R"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_Constitution = true; BaseGameSuppo..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_LeadingReforms_Deal_R = true"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_RicterVictory_NoDeal_R = true"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_RicterVictory_NoDeal_R = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_RicterVictory_NoDeal_R"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_Constitution = true; BaseGameSuppo..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_A_AutocratSpeech = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_A_AutocratSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true && BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == tru..."*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Nationalist == t..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true && BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_R_OldYSBansRedYouth = true"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Nationalist == true && BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true && BaseGame.Dec..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_R_OldYSBansRedYouth = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_R_OldYSBansRedYouth"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true && BaseGame.Dec..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_BanYoungSords = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_BanYoungSords"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == false && BaseGame.Pr..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == false && BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == false && BaseGame.Pr..."*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == false && BaseGame...."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == false && BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == false  and  Variable["BaseGame.Prologue_University_Political_Socialist"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_OldRYBansYoungSords = true"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == false && BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == false  and  Variable["BaseGame.Prologue_University_Political_Socialist"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_AutocratSpeech = true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true && BaseGame.Dec..."*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true && BaseGame.D..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_BanYoungSords = true"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == false && BaseGame.Pr..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_OldRYBansYoungSords = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_OldRYBansYoungSords"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_AutocratSpeech = true"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Honorary_Presidents == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true &..."*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Honorary_Presidents == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition = true"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Honorary_Presidents == true
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Nia Morgna: ""I will personally work on the wording of this proposal w..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Nia_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Nia Morgna: ""Proceed all you like. I am not behind this.""*)

### Węzeł `[122]`
Mówca: **Nia Morgna**
> ""Proceed all you like. I am not behind this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: ""We need you, Mrs. Morgna. Don't be like that.""*)
  - -> `[124]` (*Player: ""It's fine. We'll figure something out.""*)
  - -> `[123]` (*Player: ""Aren't you changing your mind too quickly?""*)

### Węzeł `[123]`
**[WYBÓR GRACZA: ""Aren't you changing your mind too quickly?""]** — Mówca: **Player**
> ""Aren't you changing your mind too quickly?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Nia Morgna: ""You already knew about my position, Mr. President.""*)

### Węzeł `[124]`
**[WYBÓR GRACZA: ""It's fine. We'll figure something out.""]** — Mówca: **Player**
> ""It's fine. We'll figure something out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Nia Morgna: ""I doubt that.""*)

### Węzeł `[125]`
**[WYBÓR GRACZA: ""We need you, Mrs. Morgna. Don't be like that.""]** — Mówca: **Player**
> ""We need you, Mrs. Morgna. Don't be like that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Nia Morgna: ""You should have listened to my advice, Mr. President...""*)

### Węzeł `[126]`
Mówca: **Nia Morgna**
> ""You already knew about my position, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Lucian Galade: ""Let's figure this out later, ladies and gentlemen. The p..."*)

### Węzeł `[127]`
Mówca: **Nia Morgna**
> ""I doubt that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Lucian Galade: ""Let's figure this out later, ladies and gentlemen. The p..."*)

### Węzeł `[128]`
Mówca: **Nia Morgna**
> ""You should have listened to my advice, Mr. President...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Lucian Galade: ""Let's figure this out later, ladies and gentlemen. The p..."*)

### Węzeł `[129]`
Mówca: **Lucian Galade**
> ""Let's figure this out later, ladies and gentlemen. The president has already made his decision. Let's move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lucian Galade: ""We will be working on the wording of the proposal closel..."*)

### Węzeł `[130]`
Mówca: **Nia Morgna**
> ""I will personally work on the wording of this proposal with my hand-picked legal experts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Lucian Galade: ""With Ms. Morgna's reputation as the most experienced att..."*)

### Węzeł `[131]`
Mówca: **Nia Morgna**
> ""In the meantime, you must introduce this proposal to our party. You will need to get them to back us if we want it to pass the assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Lucian Galade: ""Sir, I advise you to first talk to the leaders of both c..."*)

### Węzeł `[132]`
Mówca: **Lucian Galade**
> ""With Ms. Morgna's reputation as the most experienced attorney, this proposal will be bulletproof. Chief Justice Orso will have a hard time convincing others to oppose it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Nia Morgna: ""In the meantime, you must introduce this proposal to our..."*)

### Węzeł `[133]`
Mówca: **Lucian Galade**
> ""Sir, I advise you to first talk to the leaders of both conservative and reformist wings of the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Petr Vectern: ""As far as I'm aware, Mr. Clavin supports the reforms alr..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Veto_Default = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Veto_Default"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "After I made the final changes for the proposal, I showed..."*)
