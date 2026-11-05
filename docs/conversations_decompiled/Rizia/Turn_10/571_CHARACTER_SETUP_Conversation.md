# Rizia/Turn 10/CHARACTER SETUP/CHARACTER SETUP Conversation

- **ID konwersacji:** `571`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/571_CHARACTER_SETUP_Conversation.md`
- **Liczba węzłów dialogowych:** 54
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- *Brak bezpośrednich wypowiedzi dialogowych (scena techniczna lub logiki).*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_Arrested`
- `RiziaDLC.Adarfo_Executed`
- `RiziaDLC.AxelVina_Married_Official`
- `RiziaDLC.BirthdayGathering_ReformTalks`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC`
- `RiziaDLC.HouseOfDelegates_Abolished`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Manus_Gone`
- `RiziaDLC.Manus_SecurityThreat`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Reform_Diplomatic`
- `RiziaDLC.Reform_Movement_Leader_Adarfo`
- `RiziaDLC.Relations_HouseSazon_AngelicaPardoned`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Rico_Executed`
- `RiziaDLC.Rico_Extradited`
- `RiziaDLC.Rico_Pardoned`
- `RiziaDLC.Rusty_Allied`
- `RiziaDLC.Rusty_Arrested`
- `RiziaDLC.Rusty_Fled`
- `RiziaDLC.Theocracy_Full`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_MarriageDecision_Manus`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.BirthdayGathering_Invited_Adarfo`
- `RiziaDLC.BirthdayGathering_Invited_Angelica`
- `RiziaDLC.BirthdayGathering_Invited_Axel`
- `RiziaDLC.BirthdayGathering_Invited_Carlos`
- `RiziaDLC.BirthdayGathering_Invited_Lucita`
- `RiziaDLC.BirthdayGathering_Invited_Manus`
- `RiziaDLC.BirthdayGathering_Invited_Rico`
- `RiziaDLC.BirthdayGathering_Invited_Rusty`
- `RiziaDLC.BirthdayGathering_Invited_Vina`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[350] Rizia/Turn 10/Birthday_Gathering** (../Turn_10/350_Birthday_Gathering.md), Węzeł `[202]`

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
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == false"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.AxelVina_Married_Official == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Axel = true"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.AxelVina_Married_Official == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "// HUGO INVITED"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Axel = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Axel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "// HUGO INVITED"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == false"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == false)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos = true"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "// TADDEUS DEFAULT"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "// TADDEUS DEFAULT"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == false"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_Gone == false)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_Gone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic == true"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_Gone == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_Gone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "// INVITED LEONA SAZON"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "// INVITED LEONA SAZON"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rusty = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Diplomatic == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Diplomatic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus = true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Diplomatic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Diplomatic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Manus_SecurityThreat == true || RiziaDLC.HouseO..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita = true"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// TADDEUS DEFAULT`
- **Efekt skryptowy (`userScript`):** `-- TADDEUS DEFAULT;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica = true"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == false"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// HUGO INVITED`
- **Efekt skryptowy (`userScript`):** `-- HUGO INVITED;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Rico_Arrested == true && RiziaDLC.Rico_Pardoned..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == false"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "// HUBERTUS INVITED"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Rico_Arrested == true && RiziaDLC.Rico_Pardoned == false) ||RiziaDLC.Rico_Extradited == true || RiziaDLC.Rico_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Rico_Arrested == true && RiziaDLC.Rico_Pardoned..."*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Rico_Arrested == true && RiziaDLC.Rico_Pardon..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Rico_Arrested == true && RiziaDLC.Rico_Pardoned == false) ||RiziaDLC.Rico_Extradited == true || RiziaDLC.Rico_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Arrested"] == true  and  Variable["RiziaDLC.Rico_Pardoned"] == false)  or Variable["RiziaDLC.Rico_Extradited"] == true  or  Variable["RiziaDLC.Rico_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "// HUBERTUS INVITED"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Rico_Arrested == true && RiziaDLC.Rico_Pardoned == false) ||RiziaDLC.Rico_Extradited == true || RiziaDLC.Rico_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Rico_Arrested"] == true  and  Variable["RiziaDLC.Rico_Pardoned"] == false)  or Variable["RiziaDLC.Rico_Extradited"] == true  or  Variable["RiziaDLC.Rico_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico = true"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// HUBERTUS INVITED`
- **Efekt skryptowy (`userScript`):** `-- HUBERTUS INVITED;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "// DARIA DE RAVA INVITED"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// INVITED LEONA SAZON`
- **Efekt skryptowy (`userScript`):** `-- INVITED LEONA SAZON;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_Escapes =..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_Escapes == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_Escapes =..."*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_Escapes..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_Escapes == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Vina_Escapes"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina = true"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_Escapes == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Vina_Escapes"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "// HUGO INVITED"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Adarfo = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true || RiziaDLC.Rusty_Allied == true) && RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC..."*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyP..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true || RiziaDLC.Rusty_Allied == true) && RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true  or  Variable["RiziaDLC.Rusty_Allied"] == true)  and  Variable["RiziaDLC.Rusty_Fled"] == false  and  Variable["RiziaDLC.Rusty_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rusty = true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true || RiziaDLC.Rusty_Allied == true) && RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true  or  Variable["RiziaDLC.Rusty_Allied"] == true)  and  Variable["RiziaDLC.Rusty_Fled"] == false  and  Variable["RiziaDLC.Rusty_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Manus_SecurityThreat == true || RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC.Theocracy_Full == true) && RiziaDLC.Vina_MarriageDecision_Manus == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Manus_SecurityThreat == true || RiziaDLC.HouseO..."*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Manus_SecurityThreat == true || RiziaDLC.Hous..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Manus_SecurityThreat == true || RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC.Theocracy_Full == true) && RiziaDLC.Vina_MarriageDecision_Manus == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_SecurityThreat"] == true  or  Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true)  and  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "// INVITED LEONA SAZON"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Manus_SecurityThreat == true || RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC.Theocracy_Full == true) && RiziaDLC.Vina_MarriageDecision_Manus == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Manus_SecurityThreat"] == true  or  Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true)  and  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus = true"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ReformTalks == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDL..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ReformTalks == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ReformTalks"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// DARIA DE RAVA INVITED`
- **Efekt skryptowy (`userScript`):** `-- DARIA DE RAVA INVITED;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks == true"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDL..."*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true && Rizia..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true  and  Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Adarfo = true"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true  and  Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC..."*)
