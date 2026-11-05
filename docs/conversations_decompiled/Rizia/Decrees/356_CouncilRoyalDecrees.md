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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[58]` | **""Sure, if you have to. But my mind is made up.""** | `[39]` **Hugo Toras**: ""I wanted to offer some counsel ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Hugo Toras**: ""Thank you, I won't take long."" |
| `[59]` | **""Welcome, Hugo. Please, have a seat.""** | `[39]` **Hugo Toras**: ""I wanted to offer some counsel ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Hugo Toras**: ""Thank you, I won't take long."" |
| `[60]` | **""Please.""** | `[39]` **Hugo Toras**: ""I wanted to offer some counsel ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Hugo Toras**: ""Thank you, I won't take long."" |
| `[61]` | **""I don't want to hear it.""** | `[39]` **Hugo Toras**: ""I wanted to offer some counsel ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Hugo Toras**: ""Please, Your Majesty, I won't t..." |

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
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_ImpasseLight", "R_ImpasseLight_Loop");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "He bowed."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The door opened without ceremony, and Hugo strode in. His face was lined with urgency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Hugo Toras: ""Your Majesty.""*)

### Węzeł `[5]`
Mówca: **Narrator**
> "He bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_DecreeCounsel_Happened == 0"*)

### Węzeł `[6]`
Mówca: **Hugo Toras**
> ""This is not a decision to make in isolation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_DecreeCounsel_Happened == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_DecreeCounsel_Happened == 0"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_DecreeCounsel_Happened == 0 )"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_DecreeCounsel_Happened == 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The door opened without ceremony, and Hugo strode in. His..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_DecreeCounsel_Happened == 0 )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_DecreeCounsel_Happened == 1"*)

### Węzeł `[10]`
Mówca: **Hugo Toras**
> ""I thought it best we discuss this before you put pen to paper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_ConscriptionLevy_RemoveProvincialLevies"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_Con..."*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_C..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_ConscriptionLevy_RemoveProvincialLevies"`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Order_ConscriptionLevy_RemoveProvincialLevies"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_ConscriptionLevy_RemoveProvincialLevies")`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Order_ConscriptionLevy_RemoveProvincialLevies") == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_Con..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_ConscriptionLevy_IncreaseProvincialLevies"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_Con..."*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_C..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_ConscriptionLevy_IncreaseProvincialLevies"`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Order_ConscriptionLevy_IncreaseProvincialLevies"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_ConscriptionLevy_IncreaseProvincialLevies")`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Order_ConscriptionLevy_IncreaseProvincialLevies") == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_Sec..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_SecurityIntel_RemoveProvincialPolice"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_Sec..."*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_S..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_SecurityIntel_RemoveProvincialPolice"`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Order_SecurityIntel_RemoveProvincialPolice"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_SecurityIntel_RemoveProvincialPolice")`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Order_SecurityIntel_RemoveProvincialPolice") == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Welfare_H..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Welfare_HumanRights_AllowFreePress"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Welfare_H..."*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Welfare..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Welfare_HumanRights_AllowFreePress"`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Welfare_HumanRights_AllowFreePress"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Welfare_HumanRights_AllowFreePress")`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Welfare_HumanRights_AllowFreePress") == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Economy_T..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_DecreeCounsel_Happened == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_DecreeCounsel_Happened == 1"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_DecreeCounsel_Happened == 1 )"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_DecreeCounsel_Happened == 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "The doors swung open, and Hugo entered with that same fam..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_DecreeCounsel_Happened == 1 )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_DecreeCounsel_Happened == 2"*)

### Węzeł `[26]`
Mówca: **Narrator**
> "The doors swung open, and Hugo entered with that same familiar urgency. This time, his gaze conveyed more than mere concern -- it carried expectation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Hugo Toras: ""Your Majesty.""*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_DecreeCounsel_Happened == 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_DecreeCounsel_Happened == 2"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_DecreeCounsel_Happened == 2 )"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_DecreeCounsel_Happened == 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] == 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The doors opened and in came Hugo, this time with less pa..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_DecreeCounsel_Happened == 2 )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] == 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_DecreeCounsel_Happened == 3"*)

### Węzeł `[30]`
Mówca: **Narrator**
> "The doors opened and in came Hugo, this time with less patience than before. His expression was unreadable, but his steady, deliberate steps spoke volumes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Hugo Toras: ""Your Majesty.""*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_DecreeCounsel_Happened == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_DecreeCounsel_Happened == 3"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_DecreeCounsel_Happened == 3 )"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_DecreeCounsel_Happened == 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "The door opened, and Hugo entered. This was becoming a ro..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_DecreeCounsel_Happened == 3 )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "Just as I expected, Hugo arrived in my room before I sign..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "The door opened, and Hugo entered. This was becoming a routine -- one he neither welcomed nor could ignore."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "I knew he wasn't here to argue. He was here because he ha..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "I knew he wasn't here to argue. He was here because he had to be."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Hugo Toras: ""Your Majesty.""*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_DecreeCounsel_Happened == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_DecreeCounsel_Happened == 0"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_DecreeCounsel_Happened == 0 )"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_DecreeCounsel_Happened == 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Hugo Toras: ""I wanted to offer some counsel before you sign this decr..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_DecreeCounsel_Happened == 0 )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Hugo Toras: ""This is not a decision to make in isolation.""*)

### Węzeł `[39]`
Mówca: **Hugo Toras**
> ""I wanted to offer some counsel before you sign this decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player_Romus: ""Welcome, Hugo. Please, have a seat.""*)
  - -> `[58]` (*Player_Romus: ""Sure, if you have to. But my mind is made up.""*)
  - -> `[60]` (*Player_Romus: ""Please.""*)
  - -> `[61]` (*Player_Romus: ""I don't want to hear it.""*)

### Węzeł `[40]`
Mówca: **Hugo Toras**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Hugo Toras: ""I thought it best we discuss this before you put pen to ..."*)

### Węzeł `[41]`
Mówca: **Hugo Toras**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Hugo Toras: ""I came as soon as I could.""*)

### Węzeł `[42]`
Mówca: **Narrator**
> "Just as I expected, Hugo arrived in my room before I signed the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Hugo Toras: ""You know why I'm here.""*)

### Węzeł `[43]`
Mówca: **Hugo Toras**
> ""You know why I'm here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[44]`
Mówca: **Hugo Toras**
> ""I came as soon as I could.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Economy_Taxes_EnactInheritenceTax"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Economy_T..."*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Economy..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Economy_Taxes_EnactInheritenceTax"`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Economy_Taxes_EnactInheritenceTax"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Economy_Taxes_EnactInheritenceTax")`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Economy_Taxes_EnactInheritenceTax") == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Economy_T..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Economy_Taxes_LandOwnersTax"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Economy_T..."*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Economy..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Economy_Taxes_LandOwnersTax"`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Economy_Taxes_LandOwnersTax"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Economy_Taxes_LandOwnersTax")`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Economy_Taxes_LandOwnersTax") == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Welfare_H..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies = true; RiziaDLC.Hugo_DecreeCounsel_Happened += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies"] = true;
Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] = Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies = true; RiziaDLC.Hugo_DecreeCounsel_Happened += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies"] = true;
Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] = Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice = true; RiziaDLC.Hugo_DecreeCounsel_Happened += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice"] = true;
Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] = Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress = true; RiziaDLC.Hugo_DecreeCounsel_Happened += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress"] = true;
Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] = Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax = true; RiziaDLC.Hugo_DecreeCounsel_Happened += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] = true;
Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] = Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax = true; RiziaDLC.Hugo_DecreeCounsel_Happened += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] = true;
Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] = Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Order_Con..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sure, if you have to. But my mind is made up.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Hugo Toras: ""Thank you, I won't take long.""*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Welcome, Hugo. Please, have a seat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Hugo Toras: ""Thank you, I won't take long.""*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Hugo Toras: ""Thank you, I won't take long.""*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want to hear it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Hugo Toras: ""Please, Your Majesty, I won't take long.""*)

### Węzeł `[62]`
Mówca: **Hugo Toras**
> ""Please, Your Majesty, I won't take long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""Thank you, I won't take long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_ImpasseLight", "R_ImpasseLight_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_ImpasseLight","R_ImpasseLight_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_DecreeCounsel_Happened == 0"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Welfare_HumanRights_DecriminalizeHomosexuality"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Welfare_H..."*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Welfare..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Welfare_HumanRights_DecriminalizeHomosexuality"`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Welfare_HumanRights_DecriminalizeHomosexuality"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.DecreeCounsel_DecreeNameInDatabase == "Welfare_HumanRights_DecriminalizeHomosexuality")`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.DecreeCounsel_DecreeNameInDatabase"] =="Welfare_HumanRights_DecriminalizeHomosexuality") == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_Homosexuality = true; RiziaDLC.Hugo_DecreeCounsel_Happened += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_Homosexuality"] = true;
Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] = Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "End();"*)
