# Sordland/Turn07/Gus Investment Feedback

- **ID konwersacji:** `120`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/120_Gus_Investment_Feedback.md`
- **Liczba węzłów dialogowych:** 28
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- **[35]** Gus Manger

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`
- `BaseGame.Turn05_P_FCAnrica`
- `BaseGame.Turn05_P_Underhall`
- `BaseGame.Turn05_Personal_Festival_Force`
- `BaseGame.Turn05_Personal_Festival_LesteKicked`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.PersonalWealth`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

- *Brak decyzji i wyborów gracza w tej scenie (dialog liniowy lub sekwencja techniczna).*

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
  - -> `[22]` (*Gus Manger: "“Additionally, I bring good news regarding our investment.”"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Gus Manger**
> "“In a few years the vineyard may even challenge the regional samples. It would need some further attention to reach those goals however.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Gus Manger: "“The money should be arriving in your account shortly.”"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Underhall == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Underhall == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_Underhall == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Underhall == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_Underhall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Gus Manger: "“The management of Underhall has decided to send big bonu..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_Underhall == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Underhall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Gus Manger: "“The vineyard has begun producing some wine. I have also ..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Gus Manger: "“FC Anrica has seen a boost of ticket sales after your en..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Underhall == true"*)

### Węzeł `[10]`
Mówca: **Gus Manger**
> "“FC Anrica has seen a boost of ticket sales after your endorsement and participation in the club. The management decided to send over a slice of that pie.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true && ..."*)

### Węzeł `[11]`
Mówca: **Gus Manger**
> "“The management of Underhall has decided to send big bonuses to the board after high revenue growth this quarter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)

### Węzeł `[12]`
Mówca: **Gus Manger**
> "“Several construction projects have been accomplished around the country. The company coffers are filled and we stand to benefit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 1"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Gus Manger: "“The money should be arriving in your account shortly.”"*)

### Węzeł `[14]`
Mówca: **Gus Manger**
> "“The vineyard has begun producing some wine. I have also arranged several wine-tasters to sample and give ideas on how to improve the quality.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Gus Manger: "“In a few years the vineyard may even challenge the regio..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Gus Manger: "“The money should be arriving in your account shortly.”"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Gus Manger: "“The money should be arriving in your account shortly.”"*)

### Węzeł `[17]`
Mówca: **Gus Manger**
> "“The manager personally thanked you for the support you have shown to the team. Several players have already decided to join the USP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 1"*)

### Węzeł `[18]`
Mówca: **Gus Manger**
> "“After the successful contract win, the company has received and accepted several mega-projects in other countries. The future stands bright for the corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 2"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction =..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Gus Manger: "“After the successful contract win, the company has recei..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Gus Manger: "“Several construction projects have been accomplished aro..."*)

### Węzeł `[22]`
Mówca: **Gus Manger**
> "“Additionally, I bring good news regarding our investment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[23]`
Mówca: **Gus Manger**
> "“The money should be arriving in your account shortly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteKicked == true && BaseGame.Turn05_Personal_Festival_Force == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true && ..."*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Personal_Festival_LesteKicked == true &..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteKicked == true && BaseGame.Turn05_Personal_Festival_Force == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true  and  Variable["BaseGame.Turn05_Personal_Festival_Force"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Gus Manger: "“The manager personally thanked you for the support you h..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Personal_Festival_LesteKicked == true && BaseGame.Turn05_Personal_Festival_Force == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true  and  Variable["BaseGame.Turn05_Personal_Festival_Force"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Gus Manger: "“The manager personally thanked you for the support you h..."*)

### Węzeł `[27]`
Mówca: **Gus Manger**
> "“The manager personally thanked you for the support you have shown and wanted me to relay that he is no fan of the mayor Leste either.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 1"*)
