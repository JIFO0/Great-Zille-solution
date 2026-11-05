# Rizia/Turn 9/NOTES_Old Intermerkopum Checks

- **ID konwersacji:** `452`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/452_NOTES_Old_Intermerkopum_Checks.md`
- **Liczba węzłów dialogowych:** 63
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- *Brak bezpośrednich wypowiedzi dialogowych (scena techniczna lub logiki).*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.AxelVina_Married_Official`
- `RiziaDLC.CountryRelation_Derdia_Allied`
- `RiziaDLC.CountryRelation_Derdia_Friendly`
- `RiziaDLC.CountryRelation_Pales_Allied`
- `RiziaDLC.CountryRelation_Pales_Friendly`
- `RiziaDLC.CountryRelation_Wehlen_Allied`
- `RiziaDLC.CountryRelation_Wehlen_Friendly`
- `RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential`
- `RiziaDLC.Diplomacy_Morella_IntermerkopumPotential`
- `RiziaDLC.Diplomacy_Pales_IntermerkopumPotential`
- `RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential`
- `RiziaDLC.Intermerkopum_Efforts`
- `RiziaDLC.Morella_MITZFriendlyOutcome`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Economy_DerdiaPipeline_Project`
- `RiziaDLC.Policy_Economy_MorellaPipeline_Completed`
- `RiziaDLC.Policy_Economy_PalesPipeline_Completed`
- `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed`
- `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed`
- `RiziaDLC.Turn09_DerdiaWehlenMediation_Failed`
- `RiziaDLC.Turn09_DerdiaWehlenMediation_Success`
- `RiziaDLC.Turn09_MorellaDerdiaMediation_Failed`
- `RiziaDLC.Turn09_MorellaDerdiaMediation_Success`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLCIsolated.Intermerkopum_Counter`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential`
- `RiziaDLC.Diplomacy_Morella_IntermerkopumPotential`
- `RiziaDLC.Diplomacy_Pales_IntermerkopumPotential`
- `RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential`
- `RiziaDLC.Intermerkopum_Efforts`
- `RiziaDLCIsolated.Intermerkopum_Counter`
- `RiziaDLCSupport.News_Turn09_G_IntermerkopumTalksCanceled`
- `RiziaDLCSupport.Reports_Turn09_Derdia_IntermerkopumAccept`
- `RiziaDLCSupport.Reports_Turn09_Derdia_IntermerkopumRefusal`
- `RiziaDLCSupport.Reports_Turn09_Morella_IntermerkopumAcceptance`
- `RiziaDLCSupport.Reports_Turn09_Morella_IntermerkopumRefusal`
- `RiziaDLCSupport.Reports_Turn09_Pales_IntermerkopumAccept`
- `RiziaDLCSupport.Reports_Turn09_Pales_IntermerkopumRefusal`
- `RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumAccept`
- `RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumRefusal_NoZille`
- `RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumRefusal_Zille`

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
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Morella_MITZFriendlyOutcome == true && ((RiziaDLC.Policy_Economy_MorellaPipeline_Completed == true && RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == false) || RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true) && RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Morella_MITZFriendlyOutcome == true && ((RiziaDL..."*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Morella_MITZFriendlyOutcome == true && ((Rizia..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Morella_MITZFriendlyOutcome == true && ((RiziaDLC.Policy_Economy_MorellaPipeline_Completed == true && RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == false) || RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true) && RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Morella_MITZFriendlyOutcome"] == true  and  ((Variable["RiziaDLC.Policy_Economy_MorellaPipeline_Completed"] == true  and  Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed"] == false)  or  Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true)  and  Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_IntermerkopumPotential = true;..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Morella_MITZFriendlyOutcome == true && ((RiziaDLC.Policy_Economy_MorellaPipeline_Completed == true && RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == false) || RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true) && RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Morella_MITZFriendlyOutcome"] == true  and  ((Variable["RiziaDLC.Policy_Economy_MorellaPipeline_Completed"] == true  and  Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed"] == false)  or  Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true)  and  Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_IntermerkopumPotential == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Morella_IntermerkopumPotential = true; RiziaDLCIsolated.Intermerkopum_Counter += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Morella_IntermerkopumPotential"] = true;
Variable["RiziaDLCIsolated.Intermerkopum_Counter"] = Variable["RiziaDLCIsolated.Intermerkopum_Counter"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.CountryRelation_Derdia_Friendly == true || Rizi..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Intermerkopum_Counter = 0;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Intermerkopum_Counter"] = 0;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Morella_MITZFriendlyOutcome == true && ((RiziaDL..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Efforts == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Intermerkopum_Efforts == true)"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Efforts == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Intermerkopum_Counter = 0;"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Intermerkopum_Efforts == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Efforts"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.CountryRelation_Derdia_Friendly == true || RiziaDLC.CountryRelation_Derdia_Allied == true) && ((RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == false && RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true) || (RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true ||RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)) && RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == false && RiziaDLC.Turn09_DerdiaWehlenMediation_Failed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.CountryRelation_Derdia_Friendly == true || Rizi..."*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.CountryRelation_Derdia_Friendly == true || Ri..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.CountryRelation_Derdia_Friendly == true || RiziaDLC.CountryRelation_Derdia_Allied == true) && ((RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == false && RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true) || (RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true ||RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)) && RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == false && RiziaDLC.Turn09_DerdiaWehlenMediation_Failed == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Derdia_Friendly"] == true  or  Variable["RiziaDLC.CountryRelation_Derdia_Allied"] == true)  and  ((Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed"] == false  and  Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] == true)  or  (Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Success"] == true  or Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true))  and  Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == false  and  Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Failed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential = true; ..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.CountryRelation_Derdia_Friendly == true || RiziaDLC.CountryRelation_Derdia_Allied == true) && ((RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == false && RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true) || (RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true ||RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)) && RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == false && RiziaDLC.Turn09_DerdiaWehlenMediation_Failed == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.CountryRelation_Derdia_Friendly"] == true  or  Variable["RiziaDLC.CountryRelation_Derdia_Allied"] == true)  and  ((Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed"] == false  and  Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] == true)  or  (Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Success"] == true  or Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true))  and  Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == false  and  Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Failed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential == true"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential = true; RiziaDLCIsolated.Intermerkopum_Counter += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential"] = true;
Variable["RiziaDLCIsolated.Intermerkopum_Counter"] = Variable["RiziaDLCIsolated.Intermerkopum_Counter"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true && (RiziaDLC.Country..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true && (RiziaDLC.CountryRelation_Wehlen_Friendly == true || RiziaDLC.CountryRelation_Wehlen_Allied == true || RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true) && RiziaDLC.Turn09_DerdiaWehlenMediation_Failed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true && (RiziaDLC.Country..."*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReturn_Success == true && (RiziaDLC.Count..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true && (RiziaDLC.CountryRelation_Wehlen_Friendly == true || RiziaDLC.CountryRelation_Wehlen_Allied == true || RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true) && RiziaDLC.Turn09_DerdiaWehlenMediation_Failed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true  and  (Variable["RiziaDLC.CountryRelation_Wehlen_Friendly"] == true  or  Variable["RiziaDLC.CountryRelation_Wehlen_Allied"] == true  or  Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Success"] == true)  and  Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Failed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential = true; ..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReturn_Success == true && (RiziaDLC.CountryRelation_Wehlen_Friendly == true || RiziaDLC.CountryRelation_Wehlen_Allied == true || RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true) && RiziaDLC.Turn09_DerdiaWehlenMediation_Failed == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true  and  (Variable["RiziaDLC.CountryRelation_Wehlen_Friendly"] == true  or  Variable["RiziaDLC.CountryRelation_Wehlen_Allied"] == true  or  Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Success"] == true)  and  Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Failed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential == true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential = true; RiziaDLCIsolated.Intermerkopum_Counter += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential"] = true;
Variable["RiziaDLCIsolated.Intermerkopum_Counter"] = Variable["RiziaDLCIsolated.Intermerkopum_Counter"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == false && (RiziaDLC.Diplomacy_Pales_..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true || (RiziaDLC.Policy_Economy_PalesPipeline_Completed == true && RiziaDLC.CountryRelation_Pales_Friendly == true || RiziaDLC.CountryRelation_Pales_Allied == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true || (RiziaDLC.P..."*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.AxelVina_Married_Official == true || (RiziaDLC..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true || (RiziaDLC.Policy_Economy_PalesPipeline_Completed == true && RiziaDLC.CountryRelation_Pales_Friendly == true || RiziaDLC.CountryRelation_Pales_Allied == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  (Variable["RiziaDLC.Policy_Economy_PalesPipeline_Completed"] == true  and  Variable["RiziaDLC.CountryRelation_Pales_Friendly"] == true  or  Variable["RiziaDLC.CountryRelation_Pales_Allied"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_IntermerkopumPotential = true; R..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.AxelVina_Married_Official == true || (RiziaDLC.Policy_Economy_PalesPipeline_Completed == true && RiziaDLC.CountryRelation_Pales_Friendly == true || RiziaDLC.CountryRelation_Pales_Allied == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  (Variable["RiziaDLC.Policy_Economy_PalesPipeline_Completed"] == true  and  Variable["RiziaDLC.CountryRelation_Pales_Friendly"] == true  or  Variable["RiziaDLC.CountryRelation_Pales_Allied"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_IntermerkopumPotential = false; ..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_IntermerkopumPotential = true; RiziaDLCIsolated.Intermerkopum_Counter += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_IntermerkopumPotential"] = true;
Variable["RiziaDLCIsolated.Intermerkopum_Counter"] = Variable["RiziaDLCIsolated.Intermerkopum_Counter"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Intermerkopum_Counter >= 2"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Efforts = false; RiziaDLCSupport.News_Turn09_G_IntermerkopumTalksCanceled = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Intermerkopum_Efforts"] = false;
Variable["RiziaDLCSupport.News_Turn09_G_IntermerkopumTalksCanceled"] = true;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Intermerkopum_Counter >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Intermerkopum_Counter >= 2"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Intermerkopum_Counter >= 2)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Intermerkopum_Counter >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Intermerkopum_Counter"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential == true"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Intermerkopum_Counter >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Intermerkopum_Counter"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts = false; RiziaDLCSupport.N..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Morella_IntermerkopumPotential == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_IntermerkopumPotential == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Morella_IntermerkopumPotential == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Morella_IntermerkopumPotential == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Morella_IntermerkopumPotential"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_IntermerkopumPotential = false..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Morella_IntermerkopumPotential == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Morella_IntermerkopumPotential"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.CountryRelation_Derdia_Friendly == true || Rizi..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential == true)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential = false;..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true && (RiziaDLC.Country..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential = false;"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == false && (RiziaDLC.Diplomacy_Pales_..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumRefusal_Zille = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumRefusal_Zille"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == false && (RiziaDLC.Diplomacy_Pales_..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn09_Morella_IntermerkopumAcceptance = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Morella_IntermerkopumAcceptance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential == true"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReturn_Success == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumRefusa..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReturn_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumRefusa..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Morella_IntermerkopumPotential == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_IntermerkopumPotential == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Morella_IntermerkopumPotential == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Morella_IntermerkopumPotential == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Morella_IntermerkopumPotential"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn09_Morella_IntermerkopumAccep..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Morella_IntermerkopumPotential == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Morella_IntermerkopumPotential"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential == true"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential == true)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn09_Derdia_IntermerkopumAccept..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_IntermerkopumPotential == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumAccept = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumAccept"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_IntermerkopumPotential == true"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn09_Derdia_IntermerkopumAccept = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Derdia_IntermerkopumAccept"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_IntermerkopumPotential == true"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn09_Pales_IntermerkopumAccept = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Pales_IntermerkopumAccept"] = true;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_IntermerkopumPotential == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_IntermerkopumPotential == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_IntermerkopumPotential == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_IntermerkopumPotential == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_IntermerkopumPotential"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn09_Pales_IntermerkopumAccept ..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_IntermerkopumPotential == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_IntermerkopumPotential"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumRefusal_NoZille = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumRefusal_NoZille"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == false && (RiziaDLC.Diplomacy_Pales_..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential == true)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumAccept..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_IntermerkopumPotential == true"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Morella_IntermerkopumPotential = false; RiziaDLCSupport.Reports_Turn09_Morella_IntermerkopumRefusal = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Morella_IntermerkopumPotential"] = false;
Variable["RiziaDLCSupport.Reports_Turn09_Morella_IntermerkopumRefusal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.CountryRelation_Derdia_Friendly == true || Rizi..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == false && (RiziaDLC.Diplomacy_Pales_IntermerkopumPotential == true || RiziaDLC.AxelVina_Married_Official == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == false && (RiziaDLC.Diplomacy_Pales_..."*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == false && (RiziaDLC.Diplomacy_Pale..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == false && (RiziaDLC.Diplomacy_Pales_IntermerkopumPotential == true || RiziaDLC.AxelVina_Married_Official == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == false  and  (Variable["RiziaDLC.Diplomacy_Pales_IntermerkopumPotential"] == true  or  Variable["RiziaDLC.AxelVina_Married_Official"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true || (RiziaDLC.P..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == false && (RiziaDLC.Diplomacy_Pales_IntermerkopumPotential == true || RiziaDLC.AxelVina_Married_Official == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == false  and  (Variable["RiziaDLC.Diplomacy_Pales_IntermerkopumPotential"] == true  or  Variable["RiziaDLC.AxelVina_Married_Official"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Intermerkopum_Counter >= 2"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential = false; RiziaDLCSupport.Reports_Turn09_Derdia_IntermerkopumRefusal = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential"] = false;
Variable["RiziaDLCSupport.Reports_Turn09_Derdia_IntermerkopumRefusal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true && (RiziaDLC.Country..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_IntermerkopumPotential = false; RiziaDLCSupport.Reports_Turn09_Pales_IntermerkopumRefusal = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_IntermerkopumPotential"] = false;
Variable["RiziaDLCSupport.Reports_Turn09_Pales_IntermerkopumRefusal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Intermerkopum_Counter >= 2"*)
