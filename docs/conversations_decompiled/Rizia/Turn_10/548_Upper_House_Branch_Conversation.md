# Rizia/Turn 10/Upper_House_Branch/Upper_House_Branch Conversation

- **ID konwersacji:** `548`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/548_Upper_House_Branch_Conversation.md`
- **Liczba węzłów dialogowych:** 86
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[102]** Adarfo Sotelato

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Reform_Legislative_HouseOfLords`
- `RiziaDLC.Reform_PrimeMinister_Daria`
- `RiziaDLC.Reform_PrimeMinister_Manus`
- `RiziaDLC.Reform_UpperHouse_Equal`
- `RiziaDLC.Reform_UpperHouse_Limited`
- `RiziaDLC.Relations_HouseSazon_AngelicaPardoned`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[348] Rizia/Turn 10/TalkWithPrimeMinister** (../Turn_10/348_TalkWithPrimeMinister.md), Węzeł `[679]`

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
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[3]`
Mówca: **Manus Sazon**
> ""The House of Lords will begin its duties after the elections, ensuring a smooth transition as they take on their responsibilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Manus Sazon: ""The political appointments are in the final stages, with..."*)

### Węzeł `[4]`
Mówca: **Manus Sazon**
> ""The political appointments are in the final stages, with noble families, scholars, and former statesmen being selected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)

### Węzeł `[5]`
Mówca: **Manus Sazon**
> ""Given that they will hold equal authority in shaping laws once they assume their roles, we are prepared for potential delays and complications due to a lengthy negotiation process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Manus Sazon: ""Until the new legislative building is finished, they’ll ..."*)

### Węzeł `[6]`
Mówca: **Manus Sazon**
> ""Until the new legislative building is finished, they’ll convene in the Grand Hall of Palas Rezna.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords == true"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Equal == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Manus Sazon: ""Given that they will hold equal authority in shaping law..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Equal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Limited == true)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Manus Sazon: ""With their limited power, we shouldn't expect too many h..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Limited == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Manus Sazon: ""Given their largely symbolic role, we don’t expect much ..."*)

### Węzeł `[13]`
Mówca: **Manus Sazon**
> ""With their limited power, we shouldn't expect too many hurdles when passing new legislation once they assume their roles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Manus Sazon: ""Until the new legislative building is finished, they’ll ..."*)

### Węzeł `[14]`
Mówca: **Manus Sazon**
> ""Given their largely symbolic role, we don’t expect much interference in the legislative process once they assume their roles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Manus Sazon: ""Until the new legislative building is finished, they’ll ..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords == true"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords == true"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Adarfo Sotelato: ""The creation of the Regional Senate is progressing stead..."*)

### Węzeł `[21]`
Mówca: **Daria de Rava**
> ""The House of Lords will commence its duties after the elections, ensuring a seamless transition as they assume their responsibilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Daria de Rava: ""The political appointments are nearly finalized, with se..."*)

### Węzeł `[22]`
Mówca: **Daria de Rava**
> ""The political appointments are nearly finalized, with selections from the greater and lesser noble houses, scholars, and former statesmen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)

### Węzeł `[23]`
Mówca: **Daria de Rava**
> ""Given their equal power in shaping laws once they assume their roles, we are prepared for potential delays and complications from a lengthy negotiation process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Daria de Rava: ""Until the new legislative building is complete, they’ll ..."*)

### Węzeł `[24]`
Mówca: **Daria de Rava**
> ""Until the new legislative building is complete, they’ll convene in the Grand Hall of Palas Rezna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords == true"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Equal == true)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Daria de Rava: ""Given their equal power in shaping laws once they assume..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Equal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Limited == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Daria de Rava: ""With their limited power, we shouldn't face many obstacl..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Limited == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Daria de Rava: ""Given their primarily symbolic and advisory role, we don..."*)

### Węzeł `[31]`
Mówca: **Daria de Rava**
> ""With their limited power, we shouldn't face many obstacles when passing new legislation once they assume their roles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Daria de Rava: ""Until the new legislative building is complete, they’ll ..."*)

### Węzeł `[32]`
Mówca: **Daria de Rava**
> ""Given their primarily symbolic and advisory role, we don’t anticipate much interference in the legislative process once they assume their roles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Daria de Rava: ""Until the new legislative building is complete, they’ll ..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Legislative_HouseOfLords == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Manus Sazon: ""The House of Lords will begin its duties after the elect..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Legislative_HouseOfLords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Manus Sazon: ""The formation of the Regional Senate is well underway, w..."*)

### Węzeł `[36]`
Mówca: **Manus Sazon**
> ""The formation of the Regional Senate is well underway, with candidates actively campaigning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)

### Węzeł `[37]`
Mówca: **Daria de Rava**
> ""I must admit, I’m rather pleased with how Rizia has held on to its traditions -- particularly with the nobility’s continued role in the legislative process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Legislative_HouseOfLords == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Manus Sazon: ""On a personal note, I'm pleased to see the House of Lord..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Legislative_HouseOfLords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Manus Sazon: ""And on a personal note, I must say, I am pleased to see ..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Limited == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Daria de Rava: ""Even in a limited capacity, the essence of the king's co..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Limited == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Daria de Rava: ""Even if it's more of a ceremonial capacity, the essence ..."*)

### Węzeł `[44]`
Mówca: **Daria de Rava**
> ""Even in a limited capacity, the essence of the king's court endures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[45]`
Mówca: **Daria de Rava**
> ""Even if it's more of a ceremonial capacity, the essence of the king's court endures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Equal == true)"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Daria de Rava: ""Through them, the essence of the king's court endures.""*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Equal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)

### Węzeł `[49]`
Mówca: **Daria de Rava**
> ""Through them, the essence of the king's court endures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[50]`
Mówca: **Manus Sazon**
> ""And on a personal note, I must say, I am pleased to see such a strong push for regional representation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)

### Węzeł `[51]`
Mówca: **Manus Sazon**
> ""This is a key step in giving all provinces not only a voice, but a stake in the kingdom's future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Legislative_HouseOfLords == true)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Daria de Rava: ""The House of Lords will commence its duties after the el..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Legislative_HouseOfLords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Daria de Rava: ""The creation of the Regional Senate is progressing stead..."*)

### Węzeł `[55]`
Mówca: **Daria de Rava**
> ""The creation of the Regional Senate is progressing steadily, with candidates actively campaigning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Legislative_HouseOfLords == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Daria de Rava: ""I must admit, I’m rather pleased with how Rizia has held..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Legislative_HouseOfLords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Daria de Rava: ""I must admit, I’m pleased to see such strides toward bro..."*)

### Węzeł `[59]`
Mówca: **Manus Sazon**
> ""On a personal note, I'm pleased to see the House of Lords reflect the Crown's ability to adapt while preserving its core values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)

### Węzeł `[60]`
Mówca: **Daria de Rava**
> ""I must admit, I’m pleased to see such strides toward broader representation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Daria de Rava: ""Though for now, those with the wealth to campaign do ten..."*)

### Węzeł `[61]`
Mówca: **Daria de Rava**
> ""Though for now, those with the wealth to campaign do tend to come from noble backgrounds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[62]`
Mówca: **Adarfo Sotelato**
> ""With their rightful place as equals in the legislative process, we must brace for prolonged negotiations -- but that’s the cost of genuine democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Adarfo Sotelato: ""Until the new legislative building is complete, they’ll ..."*)

### Węzeł `[63]`
Mówca: **Adarfo Sotelato**
> ""Until the new legislative building is complete, they’ll convene in the Grand Hall of Palas Rezna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Equal == true)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Adarfo Sotelato: ""With their rightful place as equals in the legislative p..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Equal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Limited == true)"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Adarfo Sotelato: ""But with their hands tied from the start, the Senate wil..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Limited == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Adarfo Sotelato: ""But with no real authority, they'll just sit there -- vo..."*)

### Węzeł `[70]`
Mówca: **Adarfo Sotelato**
> ""But with their hands tied from the start, the Senate will struggle to have any influence on the Delegates' decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Adarfo Sotelato: ""Frankly, they'd save everyone time by skipping the elect..."*)

### Węzeł `[71]`
Mówca: **Adarfo Sotelato**
> ""But with no real authority, they'll just sit there -- voices drowned out by those who actually hold power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Adarfo Sotelato: ""Frankly, they'd save everyone time by skipping the elect..."*)

### Węzeł `[72]`
Mówca: **Adarfo Sotelato**
> ""The creation of the Regional Senate is progressing steadily, with candidates actively campaigning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)

### Węzeł `[73]`
Mówca: **Adarfo Sotelato**
> ""Frankly, they'd save everyone time by skipping the elections altogether and appointing actors to read from a script.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Adarfo Sotelato: ""At least then they wouldn't have to pretend this is anyt..."*)

### Węzeł `[74]`
Mówca: **Adarfo Sotelato**
> ""At least then they wouldn't have to pretend this is anything more than a farce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Adarfo Sotelato: ""Until the new legislative building is complete. the Gran..."*)

### Węzeł `[75]`
Mówca: **Adarfo Sotelato**
> ""Until the new legislative building is complete. the Grand Hall of Palas Rezna will serve as their stage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Manus Sazon: ""So is my mother, who's all but assured to be elected as ..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Manus Sazon: ""So is Leona, who's all but assured to be elected as a re..."*)

### Węzeł `[79]`
Mówca: **Manus Sazon**
> ""So is my mother, who's all but assured to be elected as a representative of Brenas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Manus Sazon: ""This is a key step in giving all provinces not only a vo..."*)

### Węzeł `[80]`
Mówca: **Manus Sazon**
> ""So is Leona, who's all but assured to be elected as a representative of Brenas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Manus Sazon: ""This is a key step in giving all provinces not only a vo..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Manus Sazon: ""So is my mother, who's all but assured to be elected as ..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Manus Sazon: ""So is Leona, who's all but assured to be elected as a re..."*)

### Węzeł `[84]`
Mówca: **Manus Sazon**
> ""So is my mother, who's all but assured to be elected as a representative of House Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[85]`
Mówca: **Manus Sazon**
> ""So is Leona, who's all but assured to be elected as a representative of House Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
