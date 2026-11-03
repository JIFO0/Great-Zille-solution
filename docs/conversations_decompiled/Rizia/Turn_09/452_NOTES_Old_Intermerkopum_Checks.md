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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 16

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Diplomacy_Pales_IntermerkopumPotential`
- `RiziaDLCSupport.Reports_Turn09_Pales_IntermerkopumAccept`
- `RiziaDLCSupport.Reports_Turn09_Pales_IntermerkopumRefusal`
- `RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumRefusal_NoZille`
- `RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumRefusal_Zille`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[6]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Morella_IntermerkopumPotential"] = true; Variable["RiziaDLCIsolated....`
- Węzeł `[7]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Intermerkopum_Counter"] = 0;`
- Węzeł `[14]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential"] = true; Variable["RiziaDLCIsolated.I...`
- Węzeł `[18]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential"] = true; Variable["RiziaDLCIsolated.I...`
- Węzeł `[22]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Pales_IntermerkopumPotential"] = true; Variable["RiziaDLCIsolated.In...`
- Węzeł `[23]` (Paskal Beniwoll): `Variable["RiziaDLC.Intermerkopum_Efforts"] = false; Variable["RiziaDLCSupport.News_Turn09_G_Inter...`
- Węzeł `[36]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumRefusal_Zille"] = true;`
- Węzeł `[37]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Reports_Turn09_Morella_IntermerkopumAcceptance"] = true;`
- *...oraz 8 innych węzłów ze skryptami.*

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
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Morella_MITZFriendlyOutcome == true && ((RiziaDLC.Policy_Economy_MorellaPipeline_Completed == true && RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == false) || RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true) && RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Morella_MITZFriendlyOutcome == true && ((RiziaDLC.Policy_Economy_MorellaPipeline_Completed == true && RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == false) || RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true) && RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Morella_MITZFriendlyOutcome"] == true  and  ((Variable["RiziaDLC.Policy_Economy_MorellaPipeline_Completed"] == true  and  Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed"] == false)  or  Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true)  and  Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Morella_MITZFriendlyOutcome == true && ((RiziaDLC.Policy_Economy_MorellaPipeline_Completed == true && RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == false) || RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true) && RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Morella_MITZFriendlyOutcome"] == true  and  ((Variable["RiziaDLC.Policy_Economy_MorellaPipeline_Completed"] == true  and  Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed"] == false)  or  Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true)  and  Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_IntermerkopumPotential = true; RiziaDLCIsolated.Intermerkopum_Counter += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Morella_IntermerkopumPotential"] = true;
Variable["RiziaDLCIsolated.Intermerkopum_Counter"] = Variable["RiziaDLCIsolated.Intermerkopum_Counter"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Intermerkopum_Counter = 0;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Intermerkopum_Counter"] = 0;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Efforts == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Efforts == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Intermerkopum_Efforts == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Efforts"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.CountryRelation_Derdia_Friendly == true || RiziaDLC.CountryRelation_Derdia_Allied == true) && ((RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == false && RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true) || (RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true ||RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)) && RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == false && RiziaDLC.Turn09_DerdiaWehlenMediation_Failed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.CountryRelation_Derdia_Friendly == true || RiziaDLC.CountryRelation_Derdia_Allied == true) && ((RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == false && RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true) || (RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true ||RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)) && RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == false && RiziaDLC.Turn09_DerdiaWehlenMediation_Failed == false)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Derdia_Friendly"] == true  or  Variable["RiziaDLC.CountryRelation_Derdia_Allied"] == true)  and  ((Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed"] == false  and  Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] == true)  or  (Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Success"] == true  or Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true))  and  Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == false  and  Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Failed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.CountryRelation_Derdia_Friendly == true || RiziaDLC.CountryRelation_Derdia_Allied == true) && ((RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == false && RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true) || (RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true ||RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)) && RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == false && RiziaDLC.Turn09_DerdiaWehlenMediation_Failed == false))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.CountryRelation_Derdia_Friendly"] == true  or  Variable["RiziaDLC.CountryRelation_Derdia_Allied"] == true)  and  ((Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed"] == false  and  Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] == true)  or  (Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Success"] == true  or Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true))  and  Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == false  and  Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Failed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential = true; RiziaDLCIsolated.Intermerkopum_Counter += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential"] = true;
Variable["RiziaDLCIsolated.Intermerkopum_Counter"] = Variable["RiziaDLCIsolated.Intermerkopum_Counter"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true && (RiziaDLC.CountryRelation_Wehlen_Friendly == true || RiziaDLC.CountryRelation_Wehlen_Allied == true || RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true) && RiziaDLC.Turn09_DerdiaWehlenMediation_Failed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true && (RiziaDLC.CountryRelation_Wehlen_Friendly == true || RiziaDLC.CountryRelation_Wehlen_Allied == true || RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true) && RiziaDLC.Turn09_DerdiaWehlenMediation_Failed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true  and  (Variable["RiziaDLC.CountryRelation_Wehlen_Friendly"] == true  or  Variable["RiziaDLC.CountryRelation_Wehlen_Allied"] == true  or  Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Success"] == true)  and  Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Failed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReturn_Success == true && (RiziaDLC.CountryRelation_Wehlen_Friendly == true || RiziaDLC.CountryRelation_Wehlen_Allied == true || RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true) && RiziaDLC.Turn09_DerdiaWehlenMediation_Failed == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true  and  (Variable["RiziaDLC.CountryRelation_Wehlen_Friendly"] == true  or  Variable["RiziaDLC.CountryRelation_Wehlen_Allied"] == true  or  Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Success"] == true)  and  Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Failed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential = true; RiziaDLCIsolated.Intermerkopum_Counter += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential"] = true;
Variable["RiziaDLCIsolated.Intermerkopum_Counter"] = Variable["RiziaDLCIsolated.Intermerkopum_Counter"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true || (RiziaDLC.Policy_Economy_PalesPipeline_Completed == true && RiziaDLC.CountryRelation_Pales_Friendly == true || RiziaDLC.CountryRelation_Pales_Allied == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true || (RiziaDLC.Policy_Economy_PalesPipeline_Completed == true && RiziaDLC.CountryRelation_Pales_Friendly == true || RiziaDLC.CountryRelation_Pales_Allied == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  (Variable["RiziaDLC.Policy_Economy_PalesPipeline_Completed"] == true  and  Variable["RiziaDLC.CountryRelation_Pales_Friendly"] == true  or  Variable["RiziaDLC.CountryRelation_Pales_Allied"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.AxelVina_Married_Official == true || (RiziaDLC.Policy_Economy_PalesPipeline_Completed == true && RiziaDLC.CountryRelation_Pales_Friendly == true || RiziaDLC.CountryRelation_Pales_Allied == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  (Variable["RiziaDLC.Policy_Economy_PalesPipeline_Completed"] == true  and  Variable["RiziaDLC.CountryRelation_Pales_Friendly"] == true  or  Variable["RiziaDLC.CountryRelation_Pales_Allied"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_IntermerkopumPotential = true; RiziaDLCIsolated.Intermerkopum_Counter += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_IntermerkopumPotential"] = true;
Variable["RiziaDLCIsolated.Intermerkopum_Counter"] = Variable["RiziaDLCIsolated.Intermerkopum_Counter"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Efforts = false; RiziaDLCSupport.News_Turn09_G_IntermerkopumTalksCanceled = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Intermerkopum_Efforts"] = false;
Variable["RiziaDLCSupport.News_Turn09_G_IntermerkopumTalksCanceled"] = true;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Intermerkopum_Counter >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Intermerkopum_Counter >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Intermerkopum_Counter"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Intermerkopum_Counter >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Intermerkopum_Counter"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_IntermerkopumPotential == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_IntermerkopumPotential == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Morella_IntermerkopumPotential"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Morella_IntermerkopumPotential == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Morella_IntermerkopumPotential"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumRefusal_Zille = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumRefusal_Zille"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn09_Morella_IntermerkopumAcceptance = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Morella_IntermerkopumAcceptance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReturn_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_IntermerkopumPotential == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_IntermerkopumPotential == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Morella_IntermerkopumPotential"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Morella_IntermerkopumPotential == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Morella_IntermerkopumPotential"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumAccept = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumAccept"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn09_Derdia_IntermerkopumAccept = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Derdia_IntermerkopumAccept"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn09_Pales_IntermerkopumAccept = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Pales_IntermerkopumAccept"] = true;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_IntermerkopumPotential == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_IntermerkopumPotential == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_IntermerkopumPotential"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_IntermerkopumPotential == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_IntermerkopumPotential"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumRefusal_NoZille = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Wehlen_IntermerkopumRefusal_NoZille"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_IntermerkopumPotential"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_IntermerkopumPotential = false; RiziaDLCSupport.Reports_Turn09_Morella_IntermerkopumRefusal = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Morella_IntermerkopumPotential"] = false;
Variable["RiziaDLCSupport.Reports_Turn09_Morella_IntermerkopumRefusal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == false && (RiziaDLC.Diplomacy_Pales_IntermerkopumPotential == true || RiziaDLC.AxelVina_Married_Official == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == false && (RiziaDLC.Diplomacy_Pales_IntermerkopumPotential == true || RiziaDLC.AxelVina_Married_Official == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == false  and  (Variable["RiziaDLC.Diplomacy_Pales_IntermerkopumPotential"] == true  or  Variable["RiziaDLC.AxelVina_Married_Official"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == false && (RiziaDLC.Diplomacy_Pales_IntermerkopumPotential == true || RiziaDLC.AxelVina_Married_Official == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == false  and  (Variable["RiziaDLC.Diplomacy_Pales_IntermerkopumPotential"] == true  or  Variable["RiziaDLC.AxelVina_Married_Official"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential = false; RiziaDLCSupport.Reports_Turn09_Derdia_IntermerkopumRefusal = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_IntermerkopumPotential"] = false;
Variable["RiziaDLCSupport.Reports_Turn09_Derdia_IntermerkopumRefusal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_IntermerkopumPotential = false; RiziaDLCSupport.Reports_Turn09_Pales_IntermerkopumRefusal = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_IntermerkopumPotential"] = false;
Variable["RiziaDLCSupport.Reports_Turn09_Pales_IntermerkopumRefusal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
