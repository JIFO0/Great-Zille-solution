# Rizia/CouncilRoyalDecrees

- **ID konwersacji:** `356`
- **StoryPack:** `Rizia`
- **Tura:** `Decree (CouncilRoyalDecrees)`
- **Lokalizacja pliku:** `Rizia/Decrees/356_CouncilRoyalDecrees.md`
- **Liczba węzłów dialogowych:** 70
- **Liczba wyborów gracza:** 4

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.DecreeCounsel_DecreeNameInDatabase`
- `RiziaDLC.Hugo_DecreeCounsel_Happened`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Hugo_DecreeCounsel_Happened`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_Homosexuality`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax`

### Skoki między-konwersacyjne:
- Węzeł `[12]` -> **[578] Rizia/ABOLISHLEVIES/ABOLISHLEVIES Conversation** (../Decrees/578_ABOLISHLEVIES_Conversation.md), Węzeł `[1]`
- Węzeł `[15]` -> **[579] Rizia/INCREASELEVIES/INCREASELEVIES Conversation** (../Decrees/579_INCREASELEVIES_Conversation.md), Węzeł `[1]`
- Węzeł `[18]` -> **[580] Rizia/ABOLISHLOCALPOLICE/ABOLISHLOCALPOLICE Conversation** (../Decrees/580_ABOLISHLOCALPOLICE_Conversation.md), Węzeł `[1]`
- Węzeł `[21]` -> **[581] Rizia/FREEPRESS/FREEPRESS Conversation** (../Decrees/581_FREEPRESS_Conversation.md), Węzeł `[1]`
- Węzeł `[46]` -> **[582] Rizia/INHERITANCETAX/INHERITANCETAX Conversation** (../Decrees/582_INHERITANCETAX_Conversation.md), Węzeł `[1]`
- Węzeł `[49]` -> **[583] Rizia/LANDOWNERSTAX/LANDOWNERSTAX Conversation** (../Decrees/583_LANDOWNERSTAX_Conversation.md), Węzeł `[1]`
- Węzeł `[67]` -> **[584] Rizia/Decriminalize Homosexuality/Decriminalize Homosexuality Conversation** (../Decrees/584_Decriminalize_Homosexuality_Conversation.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 10

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Hugo_DecreeCounsel_Happened`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_Homosexuality`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[51]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies"] = true; Variable["RiziaDLC.Hugo_Dec...`
- Węzeł `[52]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies"] = true; Variable["RiziaDLC.Hugo_De...`
- Węzeł `[53]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice"] = true; Variable["RiziaDLC.Hugo_Dec...`
- Węzeł `[54]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress"] = true; Variable["RiziaDLC.Hugo_DecreeC...`
- Węzeł `[55]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] = true; Variable["RiziaDLC.Hugo_De...`
- Węzeł `[56]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] = true; Variable["RiziaDLC.Hugo_Dec...`
- Węzeł `[57]` (Paskal Beniwoll): `--;`
- Węzeł `[64]` (Paskal Beniwoll): `End();`
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
  - -> `[65]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The door opened without ceremony, and Hugo strode in. His face was lined with urgency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[5]`
Mówca: **Narrator**
> "He bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[6]`
Mówca: **Hugo Toras**
> ""This is not a decision to make in isolation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_DecreeCounsel_Happened == 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_DecreeCounsel_Happened == 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_DecreeCounsel_Happened == 0 ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[10]`
Mówca: **Hugo Toras**
> ""I thought it best we discuss this before you put pen to paper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_ConscriptionLevy_RemoveProvincialLevies")*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_ConscriptionLevy_RemoveProvincialLevies")*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Order_ConscriptionLevy_RemoveProvincialLevies"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `578` (*Rizia/ABOLISHLEVIES/ABOLISHLEVIES Conversation*), Węzeł `[1]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_ConscriptionLevy_RemoveProvincialLevies"))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Order_ConscriptionLevy_RemoveProvincialLevies") == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_ConscriptionLevy_IncreaseProvincialLevies")*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_ConscriptionLevy_IncreaseProvincialLevies")*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Order_ConscriptionLevy_IncreaseProvincialLevies"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `579` (*Rizia/INCREASELEVIES/INCREASELEVIES Conversation*), Węzeł `[1]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_ConscriptionLevy_IncreaseProvincialLevies"))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Order_ConscriptionLevy_IncreaseProvincialLevies") == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_SecurityIntel_RemoveProvincialPolice")*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_SecurityIntel_RemoveProvincialPolice")*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Order_SecurityIntel_RemoveProvincialPolice"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `580` (*Rizia/ABOLISHLOCALPOLICE/ABOLISHLOCALPOLICE Conversation*), Węzeł `[1]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_SecurityIntel_RemoveProvincialPolice"))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Order_SecurityIntel_RemoveProvincialPolice") == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Welfare_HumanRights_AllowFreePress")*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Welfare_HumanRights_AllowFreePress")*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Welfare_HumanRights_AllowFreePress"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `581` (*Rizia/FREEPRESS/FREEPRESS Conversation*), Węzeł `[1]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Welfare_HumanRights_AllowFreePress"))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Welfare_HumanRights_AllowFreePress") == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_DecreeCounsel_Happened == 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_DecreeCounsel_Happened == 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_DecreeCounsel_Happened == 1 ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Narrator**
> "The doors swung open, and Hugo entered with that same familiar urgency. This time, his gaze conveyed more than mere concern -- it carried expectation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_DecreeCounsel_Happened == 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_DecreeCounsel_Happened == 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] == 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_DecreeCounsel_Happened == 2 ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] == 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Narrator**
> "The doors opened and in came Hugo, this time with less patience than before. His expression was unreadable, but his steady, deliberate steps spoke volumes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_DecreeCounsel_Happened == 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_DecreeCounsel_Happened == 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_DecreeCounsel_Happened == 3 ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[34]`
Mówca: **Narrator**
> "The door opened, and Hugo entered. This was becoming a routine -- one he neither welcomed nor could ignore."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Narrator**
> "I knew he wasn't here to argue. He was here because he had to be."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_DecreeCounsel_Happened == 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_DecreeCounsel_Happened == 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_DecreeCounsel_Happened == 0 ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[39]`
Mówca: **Hugo Toras**
> ""I wanted to offer some counsel before you sign this decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[58]`
  - -> `[60]`
  - -> `[61]`

### Węzeł `[40]`
Mówca: **Hugo Toras**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[41]`
Mówca: **Hugo Toras**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[42]`
Mówca: **Narrator**
> "Just as I expected, Hugo arrived in my room before I signed the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Hugo Toras**
> ""You know why I'm here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[44]`
Mówca: **Hugo Toras**
> ""I came as soon as I could.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Economy_Taxes_EnactInheritenceTax")*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Economy_Taxes_EnactInheritenceTax")*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Economy_Taxes_EnactInheritenceTax"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `582` (*Rizia/INHERITANCETAX/INHERITANCETAX Conversation*), Węzeł `[1]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Economy_Taxes_EnactInheritenceTax"))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Economy_Taxes_EnactInheritenceTax") == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Economy_Taxes_LandOwnersTax")*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Economy_Taxes_LandOwnersTax")*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Economy_Taxes_LandOwnersTax"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `583` (*Rizia/LANDOWNERSTAX/LANDOWNERSTAX Conversation*), Węzeł `[1]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Economy_Taxes_LandOwnersTax"))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Economy_Taxes_LandOwnersTax") == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies = true; RiziaDLC.Hugo_DecreeCounsel_Happened += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies"] = true;
Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] = Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies = true; RiziaDLC.Hugo_DecreeCounsel_Happened += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies"] = true;
Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] = Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice = true; RiziaDLC.Hugo_DecreeCounsel_Happened += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice"] = true;
Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] = Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress = true; RiziaDLC.Hugo_DecreeCounsel_Happened += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress"] = true;
Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] = Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax = true; RiziaDLC.Hugo_DecreeCounsel_Happened += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] = true;
Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] = Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax = true; RiziaDLC.Hugo_DecreeCounsel_Happened += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] = true;
Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] = Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sure, if you have to. But my mind is made up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Welcome, Hugo. Please, have a seat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Hugo Toras**
> ""Please, Your Majesty, I won't take long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""Thank you, I won't take long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_ImpasseLight", "R_ImpasseLight_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_ImpasseLight","R_ImpasseLight_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Welfare_HumanRights_DecriminalizeHomosexuality")*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Welfare_HumanRights_DecriminalizeHomosexuality")*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Welfare_HumanRights_DecriminalizeHomosexuality"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `584` (*Rizia/Decriminalize Homosexuality/Decriminalize Homosexuality Conversation*), Węzeł `[1]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Welfare_HumanRights_DecriminalizeHomosexuality"))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Welfare_HumanRights_DecriminalizeHomosexuality") == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_Homosexuality = true; RiziaDLC.Hugo_DecreeCounsel_Happened += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_Homosexuality"] = true;
Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] = Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
