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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 15

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[6]` (Paskal Beniwoll): `Variable["RiziaDLC.BirthdayGathering_Invited_Axel"] = true;`
- Węzeł `[10]` (Paskal Beniwoll): `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] = true;`
- Węzeł `[14]` (Paskal Beniwoll): `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] = true;`
- Węzeł `[15]` (Paskal Beniwoll): `Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] = true;`
- Węzeł `[22]` (Paskal Beniwoll): `-- TADDEUS DEFAULT;`
- Węzeł `[23]` (Paskal Beniwoll): `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] = true;`
- Węzeł `[27]` (Paskal Beniwoll): `-- HUGO INVITED;`
- Węzeł `[28]` (Paskal Beniwoll): `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] = true;`
- *...oraz 7 innych węzłów ze skryptami.*

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
  - -> `[7]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `350` (*Rizia/Turn 10/Birthday_Gathering*), Węzeł `[202]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.AxelVina_Married_Official == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Axel = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Axel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Gone == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Gone == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Manus_Gone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Manus_Gone == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Manus_Gone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rusty = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Diplomatic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Diplomatic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Diplomatic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Diplomatic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Diplomatic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // TADDEUS DEFAULT)*
- **Efekt (`userScript`):** `-- TADDEUS DEFAULT;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // HUGO INVITED)*
- **Efekt (`userScript`):** `-- HUGO INVITED;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Rico_Arrested == true && RiziaDLC.Rico_Pardoned == false) ||RiziaDLC.Rico_Extradited == true || RiziaDLC.Rico_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Rico_Arrested == true && RiziaDLC.Rico_Pardoned == false) ||RiziaDLC.Rico_Extradited == true || RiziaDLC.Rico_Executed == true)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Arrested"] == true  and  Variable["RiziaDLC.Rico_Pardoned"] == false)  or Variable["RiziaDLC.Rico_Extradited"] == true  or  Variable["RiziaDLC.Rico_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Rico_Arrested == true && RiziaDLC.Rico_Pardoned == false) ||RiziaDLC.Rico_Extradited == true || RiziaDLC.Rico_Executed == true))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Rico_Arrested"] == true  and  Variable["RiziaDLC.Rico_Pardoned"] == false)  or Variable["RiziaDLC.Rico_Extradited"] == true  or  Variable["RiziaDLC.Rico_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // HUBERTUS INVITED)*
- **Efekt (`userScript`):** `-- HUBERTUS INVITED;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // INVITED LEONA SAZON)*
- **Efekt (`userScript`):** `-- INVITED LEONA SAZON;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_Escapes == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_Escapes == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Vina_Escapes"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_Escapes == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Vina_Escapes"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Adarfo = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true || RiziaDLC.Rusty_Allied == true) && RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true || RiziaDLC.Rusty_Allied == true) && RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested == false)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true  or  Variable["RiziaDLC.Rusty_Allied"] == true)  and  Variable["RiziaDLC.Rusty_Fled"] == false  and  Variable["RiziaDLC.Rusty_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true || RiziaDLC.Rusty_Allied == true) && RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested == false))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true  or  Variable["RiziaDLC.Rusty_Allied"] == true)  and  Variable["RiziaDLC.Rusty_Fled"] == false  and  Variable["RiziaDLC.Rusty_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Manus_SecurityThreat == true || RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC.Theocracy_Full == true) && RiziaDLC.Vina_MarriageDecision_Manus == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Manus_SecurityThreat == true || RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC.Theocracy_Full == true) && RiziaDLC.Vina_MarriageDecision_Manus == false)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Manus_SecurityThreat"] == true  or  Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true)  and  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Manus_SecurityThreat == true || RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC.Theocracy_Full == true) && RiziaDLC.Vina_MarriageDecision_Manus == false))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Manus_SecurityThreat"] == true  or  Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true)  and  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ReformTalks == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ReformTalks == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ReformTalks == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ReformTalks"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // DARIA DE RAVA INVITED)*
- **Efekt (`userScript`):** `-- DARIA DE RAVA INVITED;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true  and  Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true  and  Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
