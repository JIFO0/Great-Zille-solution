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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[19]` | **""We'll figure it out.""** | `[33]` **Lucian Galade**: ""That's true. It will be tough t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Lucian Galade**: ""We will all do our best to make..." |
| `[20]` | **""I will make sure they get behind.""** | `[18]` **Lucian Galade**: ""We have to make sure they get b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Lucian Galade**: ""We will all be doing our part, ..." |
| `[21]` | **""I appreciate your comments but the decision is made.""** | `[18]` **Lucian Galade**: ""We have to make sure they get b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Lucian Galade**: ""We will all be doing our part, ..." |
| `[23]` | **""We will handle the party.""** | `[18]` **Lucian Galade**: ""We have to make sure they get b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Lucian Galade**: ""We will all be doing our part, ..." |
| `[28]` | **""Understood.""** | `[39]` **Lucian Galade**: ""And be prepared to reconsider t..."<br>`[43]` **Lucian Galade**: ""You must also be prepared to re..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Lucian Galade**: ""Wish you good luck with the par..." |
| `[30]` | **""I will not give in.""** | `[39]` **Lucian Galade**: ""And be prepared to reconsider t..."<br>`[43]` **Lucian Galade**: ""You must also be prepared to re..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Lucian Galade**: ""Wish you good luck with the par..." |
| `[34]` | **""Thanks for the advice.""** | `[39]` **Lucian Galade**: ""And be prepared to reconsider t..."<br>`[43]` **Lucian Galade**: ""You must also be prepared to re..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Lucian Galade**: ""Wish you good luck with the par..." |
| `[40]` | **""I'm prepared to reconsider if it comes to that.""** | `[33]` **Lucian Galade**: ""That's true. It will be tough t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Lucian Galade**: ""We will all do our best to make..." |
| `[52]` | **""Any advice in regards to dealing with them?""** | `[51]` **Petr Vectern**: ""As far as I'm aware, Mr. Clavin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Lucian Galade**: ""As Mr. Vectern said, Mrs. Tory ..." |
| `[53]` | **""Any advice for the speech?""** | `[51]` **Petr Vectern**: ""As far as I'm aware, Mr. Clavin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Lucian Galade**: ""Sir, you are pretty well-versed..." |
| `[54]` | **""I will handle them.""** | `[51]` **Petr Vectern**: ""As far as I'm aware, Mr. Clavin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Petr Vectern**: ""Of course."" |
| `[55]` | **""Then we will fight back.""** | `[33]` **Lucian Galade**: ""That's true. It will be tough t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Lucian Galade**: ""We will all do our best to make..." |

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
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn03_ReformPackage_Dictator = true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[3]`
Mówca: **Narrator**
> "After looking into the changes the team began discussing it amongst themselves. Lucian spoke afterwards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Lucian Galade: ""Looks like the amendments are ready to be proposed.""*)

### Węzeł `[4]`
Mówca: **Narrator**
> "After the final changes to the proposal were made, I showed it to the team."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "After looking into the changes the team began discussing ..."*)

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
  - -> `[17]` (*Lucian Galade: ""But sir, I understand that you're trying to get rid of t..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Ref..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Petr Vectern: ""I have to say...""*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)

### Węzeł `[12]`
Mówca: **Lucian Galade**
> ""Mr. Clavin will be tougher to break. The problem is that he can also influence the moderates against this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Lucian Galade: ""As much as I don't want to say this, if they make any de..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Ministers_Default == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Petr Vectern: ""But I have to say this too...""*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Ministers_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Petr Vectern: ""I'm good.""*)

### Węzeł `[16]`
Mówca: **Lucian Galade**
> ""I think we can end the meeting here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true &..."*)

### Węzeł `[17]`
Mówca: **Lucian Galade**
> ""But sir, I understand that you're trying to get rid of the impeachment, however I have to say that it may create problems within the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lucian Galade: ""We have to make sure they get behind that part. We do no..."*)

### Węzeł `[18]`
Mówca: **Lucian Galade**
> ""We have to make sure they get behind that part. We do not want to lose the support of USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: ""I will make sure they get behind.""*)
  - -> `[21]` (*Player: ""I appreciate your comments but the decision is made.""*)
  - -> `[23]` (*Player: ""We will handle the party.""*)

### Węzeł `[19]`
**[WYBÓR GRACZA: ""We'll figure it out.""]** — Mówca: **Player**
> ""We'll figure it out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lucian Galade: ""We will all do our best to make it work, sir.""*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""I will make sure they get behind.""]** — Mówca: **Player**
> ""I will make sure they get behind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lucian Galade: ""We will all be doing our part, sir.""*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""I appreciate your comments but the decision is made.""]** — Mówca: **Player**
> ""I appreciate your comments but the decision is made.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lucian Galade: ""We will all be doing our part, sir.""*)

### Węzeł `[22]`
Mówca: **Lucian Galade**
> ""Wish you good luck with the party, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucian Galade: ""I think we can end the meeting here.""*)

### Węzeł `[23]`
**[WYBÓR GRACZA: ""We will handle the party.""]** — Mówca: **Player**
> ""We will handle the party.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lucian Galade: ""We will all be doing our part, sir.""*)

### Węzeł `[24]`
Mówca: **Narrator**
> "We all shook hands and they left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[25]`
Mówca: **Lucian Galade**
> ""We will all be doing our part, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lucian Galade: ""Any other comments before we proceed?""*)

### Węzeł `[26]`
Mówca: **Lucian Galade**
> ""We will all do our best to make it work, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: ""Any other comments before we proceed?""*)

### Węzeł `[27]`
Mówca: **Petr Vectern**
> ""I have to say...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Petr Vectern: ""The new lower electoral threshold will be really difficu..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: ""Understood.""]** — Mówca: **Player**
> ""Understood.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Lucian Galade), `[43]` (Lucian Galade), `[48]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""Wish you good luck with the party, sir.""*)

### Węzeł `[29]`
Mówca: **Petr Vectern**
> ""The new lower electoral threshold will be really difficult for the party to accept. Our guys are not fond of that idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)

### Węzeł `[30]`
**[WYBÓR GRACZA: ""I will not give in.""]** — Mówca: **Player**
> ""I will not give in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Lucian Galade), `[43]` (Lucian Galade), `[48]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""Wish you good luck with the party, sir.""*)

### Węzeł `[31]`
Mówca: **Petr Vectern**
> ""But I have to say this too...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Petr Vectern: ""Not reforming the minister laws will be frowned upon by ..."*)

### Węzeł `[32]`
Mówca: **Petr Vectern**
> ""Not reforming the minister laws will be frowned upon by the party. The Assembly members have insisted on getting involved in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucian Galade: ""That's true. It will be tough to get all of their suppor..."*)

### Węzeł `[33]`
Mówca: **Lucian Galade**
> ""That's true. It will be tough to get all of their support. Some of our members may try to openly fight against this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: ""We'll figure it out.""*)
  - -> `[55]` (*Player: ""Then we will fight back.""*)
  - -> `[40]` (*Player: ""I'm prepared to reconsider if it comes to that.""*)

### Węzeł `[34]`
**[WYBÓR GRACZA: ""Thanks for the advice.""]** — Mówca: **Player**
> ""Thanks for the advice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Lucian Galade), `[43]` (Lucian Galade), `[48]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""Wish you good luck with the party, sir.""*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Ministers_Default == true)"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Petr Vectern: ""Not reforming the minister laws will also be frowned upo..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Ministers_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucian Galade: ""That's true. It will be tough to get all of their suppor..."*)

### Węzeł `[38]`
Mówca: **Petr Vectern**
> ""Not reforming the minister laws will also be frowned upon by the party. The Assembly members have insisted on getting involved in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucian Galade: ""That's true. It will be tough to get all of their suppor..."*)

### Węzeł `[39]`
Mówca: **Lucian Galade**
> ""And be prepared to reconsider the proposal if it comes to that, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: ""Thanks for the advice.""*)
  - -> `[28]` (*Player: ""Understood.""*)
  - -> `[30]` (*Player: ""I will not give in.""*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""I'm prepared to reconsider if it comes to that.""]** — Mówca: **Player**
> ""I'm prepared to reconsider if it comes to that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lucian Galade: ""We will all do our best to make it work, sir.""*)

### Węzeł `[41]`
Mówca: **Petr Vectern**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Lucian Galade: ""And be prepared to reconsider the proposal if it comes t..."*)

### Węzeł `[42]`
Mówca: **Lucian Galade**
> ""In the meantime, you must introduce this proposal to our party, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lucian Galade: ""You'll need to a strong speech to get them behind you. B..."*)

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""You must also be prepared to reconsider the proposal if it comes to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: ""Thanks for the advice.""*)
  - -> `[28]` (*Player: ""Understood.""*)
  - -> `[30]` (*Player: ""I will not give in.""*)

### Węzeł `[44]`
Mówca: **Lucian Galade**
> ""Any other comments before we proceed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)

### Węzeł `[45]`
Mówca: **Lucian Galade**
> ""We will be working on the wording of the proposal with our legal experts before we propose it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Lucian Galade: ""In the meantime, you must introduce this proposal to our..."*)

### Węzeł `[46]`
Mówca: **Lucian Galade**
> ""You'll need to a strong speech to get them behind you. But I advise you to first talk to the leaders of the both conservative and reformist wings of the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Petr Vectern: ""As far as I'm aware, Mr. Clavin will be our biggest prob..."*)

### Węzeł `[47]`
Mówca: **Lucian Galade**
> ""Sir, you are pretty well-versed in speeches. You know the party. Just make sure you get them hyped up about the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lucian Galade: ""You must also be prepared to reconsider the proposal if ..."*)

### Węzeł `[48]`
Mówca: **Lucian Galade**
> ""As much as I don't want to say this, if they make any demands to change the proposal, you may need to give in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: ""Thanks for the advice.""*)
  - -> `[28]` (*Player: ""Understood.""*)
  - -> `[30]` (*Player: ""I will not give in.""*)

### Węzeł `[49]`
Mówca: **Lucian Galade**
> ""Any other comments before we proceed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Petr Vectern: ""I'm good.""*)

### Węzeł `[50]`
Mówca: **Lucian Galade**
> ""As Mr. Vectern said, Mrs. Tory will probably be easier to persuade. We need to unite the party under these changes, so her support is vital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucian Galade: ""Mr. Clavin will be tougher to break. The problem is that..."*)

### Węzeł `[51]`
Mówca: **Petr Vectern**
> ""As far as I'm aware, Mr. Clavin will be our biggest problem, he may try to paint you as a dictator. Mrs. Tory will also be tough but we'll need to get her first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: ""Any advice in regards to dealing with them?""*)
  - -> `[53]` (*Player: ""Any advice for the speech?""*)
  - -> `[54]` (*Player: ""I will handle them.""*)

### Węzeł `[52]`
**[WYBÓR GRACZA: ""Any advice in regards to dealing with them?""]** — Mówca: **Player**
> ""Any advice in regards to dealing with them?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Lucian Galade: ""As Mr. Vectern said, Mrs. Tory will probably be easier t..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: ""Any advice for the speech?""]** — Mówca: **Player**
> ""Any advice for the speech?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucian Galade: ""Sir, you are pretty well-versed in speeches. You know th..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA: ""I will handle them.""]** — Mówca: **Player**
> ""I will handle them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Petr Vectern: ""Of course.""*)

### Węzeł `[55]`
**[WYBÓR GRACZA: ""Then we will fight back.""]** — Mówca: **Player**
> ""Then we will fight back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lucian Galade: ""We will all do our best to make it work, sir.""*)

### Węzeł `[56]`
Mówca: **Petr Vectern**
> ""I'm good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Lucian Galade: ""Let's proceed.""*)

### Węzeł `[57]`
Mówca: **Lucian Galade**
> ""Let's proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "Lucian looked at me."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "Lucian looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucian Galade: ""We will be working on the wording of the proposal with o..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_A_Constitution = true;
BaseGameSupport.Report_Turn03_Holsord_ReformCommittee = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_A_Constitution"] = true;
Variable["BaseGameSupport.Report_Turn03_Holsord_ReformCommittee"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == tru..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn03_ReformPackage_Dictator = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn03_ReformPackage_Dictator"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "After the final changes to the proposal were made, I show..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_LeadingReforms_Deal_D = true"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_DangerousReforms_NoDeal_D ..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_DangerousReforms_NoDeal_D = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_DangerousReforms_NoDeal_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_Constitution = true; BaseGameSuppo..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_LeadingReforms_Deal_D = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_LeadingReforms_Deal_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_Constitution = true; BaseGameSuppo..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_A_AutocratSpeech = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_A_AutocratSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true && BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == tru..."*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Nationalist == t..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true && BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_R_OldYSBansRedYouth = true"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Nationalist == true && BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true && BaseGame.Dec..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_R_OldYSBansRedYouth = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_R_OldYSBansRedYouth"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true && BaseGame.Dec..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true && BaseGame.Dec..."*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true && BaseGame.D..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_BanYoungSords = true"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == false && BaseGame.Pr..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_BanYoungSords = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_BanYoungSords"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == false && BaseGame.Pr..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == false && BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == false && BaseGame.Pr..."*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == false && BaseGame...."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == false && BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == false  and  Variable["BaseGame.Prologue_University_Political_Socialist"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_OldRYBansYoungSords = true"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == false && BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == false  and  Variable["BaseGame.Prologue_University_Political_Socialist"] == true  and  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_AutocratSpeech = true"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_OldRYBansYoungSords = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_OldRYBansYoungSords"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_AutocratSpeech = true"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Nia_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "We all shook hands and they left the room."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Honorary_Presidents == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true &..."*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Honorary_Presidents == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition = true"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Honorary_Presidents == true
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "We all shook hands and they left the room."*)
