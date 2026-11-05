# Rizia/Turn 10/Zille_Reform_Branch/Zille_Reform_Branch Conversation

- **ID konwersacji:** `547`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/547_Zille_Reform_Branch_Conversation.md`
- **Liczba węzłów dialogowych:** 179
- **Liczba wyborów gracza:** 2

---

## 1. Uczestnicy Sceny

- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[95]** Player_Romus *(Gracz)*
- **[102]** Adarfo Sotelato

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Reform_PrimeMinister_Daria`
- `RiziaDLC.Reform_PrimeMinister_Manus`
- `RiziaDLC.Situation_Diplomacy_Zille_ATAActive`
- `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive`
- `RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal`
- `RiziaDLC.Situation_Law_WehlenRights_Full`
- `RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied`
- `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown`
- `RiziaDLC.ZilleOwnership_Brenas`
- `RiziaDLC.ZilleReferendum_Approved`
- `RiziaDLC.ZilleReferendum_Interfere_Agents_Success`
- `RiziaDLC.ZilleReferendum_Interfere_Army_Success`
- `RiziaDLC.ZilleReferendum_Won`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[348] Rizia/Turn 10/TalkWithPrimeMinister** (../Turn_10/348_TalkWithPrimeMinister.md), Węzeł `[679]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[149]` | **""How are election preparations going up there?""** | `[105]` **Manus Sazon**: ""The Ariana Toras Association ha..."<br>`[119]` **Daria de Rava**: ""The presence of the Ariana Tora..."<br>*(oraz 12 innych węzłów)* | `(Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true) == false`<br>`(Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`<br>`(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false` | *Brak zmian stanu* | `[3]` **Manus Sazon**: ""Because of the referendum, we a..."<br>`[5]` **Manus Sazon**: ""Zille's rapid reintegration has..."<br>*(oraz 4 innych odgałęzień)* |
| `[151]` | **""Which way do you think they'll lean at the polls?""** | `[105]` **Manus Sazon**: ""The Ariana Toras Association ha..."<br>`[119]` **Daria de Rava**: ""The presence of the Ariana Tora..."<br>*(oraz 12 innych węzłów)* | `(Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true) == false`<br>`(Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`<br>`(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false` | *Brak zmian stanu* | `[152]` **Manus Sazon**: ""First we have to see if they vo..."<br>`[159]` **Daria de Rava**: ""That depends on who can be coax..."<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[3]`
Mówca: **Manus Sazon**
> ""Because of the referendum, we already had an Electoral Commission and voter registration systems within Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Won == true"*)

### Węzeł `[4]`
Mówca: **Manus Sazon**
> ""While the referendum's infrastructure is beneficial, some perceive the electoral process as a top-down initiative, leading to concerns about fairness and transparency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army_Success == true |..."*)

### Węzeł `[5]`
Mówca: **Manus Sazon**
> ""Zille's rapid reintegration has streamlined the electoral process, resulting in unified voter registration and high participation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Manus Sazon: ""However, without a say in Zille's return to Rizia, many ..."*)

### Węzeł `[6]`
Mówca: **Manus Sazon**
> ""However, without a say in Zille's return to Rizia, many feel disconnected from the decision, leading to suspicions and resistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Won == true"*)

### Węzeł `[7]`
Mówca: **Adarfo Sotelato**
> ""The rapid reintegration of Zille has brought some improvements to the electoral process, with unified voter registration and high participation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Adarfo Sotelato: ""Yet, for those who had no say in Zille's return to Rizia..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Won == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Won == true)"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Manus Sazon: ""While the referendum's infrastructure is beneficial, som..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Daria de Rava: ""While the referendum's infrastructure is beneficial, som..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Adarfo Sotelato: ""While the referendum's infrastructure is beneficial, som..."*)

### Węzeł `[17]`
Mówca: **Adarfo Sotelato**
> ""While the referendum's infrastructure is beneficial, some perceive the electoral process as a top-down initiative, raising doubts about its true fairness and transparency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army_Success == true |..."*)

### Węzeł `[18]`
Mówca: **Daria de Rava**
> ""While the referendum's infrastructure is beneficial, some see the electoral process as imposed from above, fueling worries over fairness and transparency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army_Success == true |..."*)

### Węzeł `[19]`
Mówca: **Manus Sazon**
> ""Some citizens perceive the electoral process as a top-down initiative, leading to concerns about fairness and transparency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army_Success == true |..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Daria de Rava: ""Some citizens see the electoral process as imposed from ..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Adarfo Sotelato: ""Some citizens perceive the electoral process as a top-do..."*)

### Węzeł `[23]`
Mówca: **Daria de Rava**
> ""Some citizens see the electoral process as imposed from above, fueling worries over fairness and transparency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army_Success == true |..."*)

### Węzeł `[24]`
Mówca: **Adarfo Sotelato**
> ""Some citizens perceive the electoral process as a top-down initiative, raising doubts about its true fairness and transparency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army_Success == true |..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Manus Sazon: ""Some citizens perceive the electoral process as a top-do..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Manus Sazon: ""Because of the referendum, we already had an Electoral C..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Daria de Rava: ""As luck would have it, the referendum led to the creatio..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Adarfo Sotelato: ""Fortunately for us, the referendum led to the creation o..."*)

### Węzeł `[34]`
Mówca: **Daria de Rava**
> ""As luck would have it, the referendum led to the creation of an Electoral Commission and voter registration systems within Zille...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Won == true"*)

### Węzeł `[35]`
Mówca: **Adarfo Sotelato**
> ""Fortunately for us, the referendum led to the creation of an Electoral Commission and voter registration systems within Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Won == true"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Approved == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Approved == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Approved == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Approved == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Approved"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Approved == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Approved"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Manus Sazon: ""Zille's rapid reintegration has streamlined the electora..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[42]`
Mówca: **Daria de Rava**
> ""Zille's rapid reintegration has streamlined the electoral process, leading to unified voter registration and increased participation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Daria de Rava: ""However, many are frustrated by their lack of input in Z..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Daria de Rava: ""Zille's rapid reintegration has streamlined the electora..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Adarfo Sotelato: ""The rapid reintegration of Zille has brought some improv..."*)

### Węzeł `[46]`
Mówca: **Daria de Rava**
> ""However, many are frustrated by their lack of input in Zille's return to Rizia, and this has led to some resistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Won == true"*)

### Węzeł `[47]`
Mówca: **Adarfo Sotelato**
> ""Yet, for those who had no say in Zille's return to Rizia, the lack of involvement has created a sense of alienation, sowing mistrust and opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Won == true"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army_Success == true |..."*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Interfere_Army_Success == true..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Manus Sazon: ""These fears have only grown since the referendum, as acc..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[51]`
Mówca: **Manus Sazon**
> ""These fears have only grown since the referendum, as accusations of interference have fueled lingering distrust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[52]`
Mówca: **Daria de Rava**
> ""These fears have only intensified since the referendum, as accusations of interference have fueled lingering distrust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army_Success == true |..."*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Interfere_Army_Success == true..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Daria de Rava: ""These fears have only intensified since the referendum, ..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[56]`
Mówca: **Adarfo Sotelato**
> ""These fears have only intensified since the referendum, as accusations of interference have fueled lingering distrust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army_Success == true |..."*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Interfere_Army_Success == true..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Adarfo Sotelato: ""These fears have only intensified since the referendum, ..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_Brenas == true"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_Brenas == true"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Adarfo Sotelato: ""As for how they'll vote, it could go either way. After d..."*)

### Węzeł `[66]`
Mówca: **Manus Sazon**
> ""But with House Sazon in charge of governance, it does seem like voters are primed to go for the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[67]`
Mówca: **Daria de Rava**
> ""As for my party, we've all but given up on campaigning in Zille. House Sazon has them primed to vote for the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleOwnership_Brenas == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_Brenas == true"*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleOwnership_Brenas == true)"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleOwnership_Brenas == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleOwnership_Brenas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Manus Sazon: ""But with House Sazon in charge of governance, it does se..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleOwnership_Brenas == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleOwnership_Brenas"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Manus Sazon: ""And since House Sazon has no influence over the province..."*)

### Węzeł `[71]`
Mówca: **Adarfo Sotelato**
> ""As for how they'll vote, it could go either way. After decades of instability, they may decide my version of the RPP is too radical for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[72]`
Mówca: **Manus Sazon**
> ""And since House Sazon has no influence over the province, I can't be sure voters will go for the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleOwnership_Brenas == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_Brenas == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleOwnership_Brenas == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleOwnership_Brenas == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleOwnership_Brenas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Daria de Rava: ""As for my party, we've all but given up on campaigning i..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleOwnership_Brenas == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleOwnership_Brenas"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Daria de Rava: ""On the bright side, I believe Zilleans can be convinced ..."*)

### Węzeł `[76]`
Mówca: **Daria de Rava**
> ""On the bright side, I believe Zilleans can be convinced to align with the RNC. They want peace after years of upheaval.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_WehlenRights_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_WehlenRights_Full == true)"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_WehlenRights_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_WehlenRights_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied..."*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal == false"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Daria de Rava: ""It's no cakewalk, Your Majesty.""*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Adarfo Sotelato: ""Reincorpating Zille into Rizia has not been easy.""*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Manus Sazon: ""It's complicated, as you can imagine.""*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[87]`
Mówca: **Manus Sazon**
> ""It's complicated, as you can imagine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)

### Węzeł `[88]`
Mówca: **Manus Sazon**
> ""Though Zilleans have enjoyed freedom of movement since the Amendment to the Zille Agreement, many families separated by the region's transfer to Wehzek control are only now reuniting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Manus Sazon: ""The mood is happy, but concerns about their future in Ri..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_WehlenRights_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_WehlenRights_Full == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_WehlenRights_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_WehlenRights_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal == false"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_WehlenRights_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_WehlenRights_Full == true)"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_WehlenRights_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Manus Sazon: ""Though Zilleans have enjoyed freedom of movement since t..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_WehlenRights_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Manus Sazon: ""After 30 years, the families separated by Zille's transf..."*)

### Węzeł `[95]`
Mówca: **Manus Sazon**
> ""The mood is happy, but concerns about their future in Rizia remain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||..."*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Manus Sazon: ""To make matter worse, some Su Omina members have taken m..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)

### Węzeł `[99]`
Mówca: **Manus Sazon**
> ""To make matter worse, some Su Omina members have taken matters into their own hands, violently evicting Wehzek families from their homes, claiming the land belongs to 'real' Rizians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Manus Sazon: ""We’ve worked swiftly to curb these incidents, but they h..."*)

### Węzeł `[100]`
Mówca: **Manus Sazon**
> ""But your treaty with Wehlen, granting Wehzek citizens full rights as Rizians, has helped smooth the transition for those who remained behind, ensuring they receive legal protections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied..."*)

### Węzeł `[101]`
Mówca: **Manus Sazon**
> ""We’ve worked swiftly to curb these incidents, but they have only deepened the fears of those hesitant about reintegration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true || RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||..."*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true || RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true  or  Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Manus Sazon: ""But your treaty with Wehlen, granting Wehzek citizens fu..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true || RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true  or  Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Manus Sazon: ""Meanwhile, your treaty with Wehlen, granting Wehzek citi..."*)

### Węzeł `[105]`
Mówca: **Manus Sazon**
> ""The Ariana Toras Association has been instrumental to reintegration efforts, expanding its cultural and language initiatives in Zille to help our new citizens feel at home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true )"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Manus Sazon: ""The Ariana Toras Association has been instrumental to re..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[109]`
Mówca: **Daria de Rava**
> ""It's no cakewalk, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||..."*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Daria de Rava: ""There have also been isolated incidents of Su Omina memb..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)

### Węzeł `[113]`
Mówca: **Adarfo Sotelato**
> ""Reincorpating Zille into Rizia has not been easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Adarfo Sotelato: ""But you needn’t trouble yourself with such matters -- se..."*)

### Węzeł `[114]`
Mówca: **Daria de Rava**
> ""There have also been isolated incidents of Su Omina members forcibly removing Wehzek families from their homes, claiming the land belongs to ‘true’ Rizians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Daria de Rava: ""We've acted quickly to contain these incidents, but they..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true || RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||..."*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true || RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true  or  Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Daria de Rava: ""However, your treaty with Wehlen, which grants Wehzek ci..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true || RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true  or  Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Daria de Rava: ""Meanwhile, your treaty with Wehlen, granting Wehzek citi..."*)

### Węzeł `[118]`
Mówca: **Daria de Rava**
> ""However, your treaty with Wehlen, which grants Wehzek citizens full Rizian rights, has helped ease the transition for those who chose to remain, ensuring their legal protections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied..."*)

### Węzeł `[119]`
Mówca: **Daria de Rava**
> ""The presence of the Ariana Toras Association has definitely had a positive effect. It's expanded its cultural and language initiatives in Zille to help new citizens integrate more smoothly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true )"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Daria de Rava: ""The presence of the Ariana Toras Association has definit..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[123]`
Mówca: **Daria de Rava**
> ""While Zilleans have had freedom of movement since the Amendment to the Zille Agreement, many families split by the region's transfer to Wehzek control are just now reuniting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Daria de Rava: ""The mood is celebratory, yet uncertainties about their f..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_WehlenRights_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_WehlenRights_Full == true)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_WehlenRights_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Daria de Rava: ""While Zilleans have had freedom of movement since the Am..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_WehlenRights_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Daria de Rava: ""After 30 years, the families separated by Zille's transf..."*)

### Węzeł `[127]`
Mówca: **Daria de Rava**
> ""The mood is celebratory, yet uncertainties about their future in Rizia persist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||..."*)

### Węzeł `[128]`
Mówca: **Daria de Rava**
> ""We've acted quickly to contain these incidents, but they have only heightened the anxieties of those wary of reintegration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)

### Węzeł `[129]`
Mówca: **Adarfo Sotelato**
> ""But you needn’t trouble yourself with such matters -- seeing how this is no longer within your purview.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Adarfo Sotelato: ""Ultimately, these are issues for the people to resolve.""*)

### Węzeł `[130]`
Mówca: **Manus Sazon**
> ""Meanwhile, your treaty with Wehlen, granting Wehzek citizens full rights as Rizians, has helped ease the transition for those who opted to stay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied..."*)

### Węzeł `[131]`
Mówca: **Daria de Rava**
> ""Meanwhile, your treaty with Wehlen, granting Wehzek citizens full rights as Rizians, has helped ease the transition for those who opted to stay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied..."*)

### Węzeł `[132]`
Mówca: **Adarfo Sotelato**
> ""Ultimately, these are issues for the people to resolve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == false"*)

### Węzeł `[133]`
Mówca: **Manus Sazon**
> ""After 30 years, the families separated by Zille's transfer to Wehzek control have finally begun reuniting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Manus Sazon: ""The mood is happy, but concerns about their future in Ri..."*)

### Węzeł `[134]`
Mówca: **Daria de Rava**
> ""After 30 years, the families separated by Zille's transfer to Wehzek control have finally begun reuniting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Daria de Rava: ""The mood is celebratory, yet uncertainties about their f..."*)

### Węzeł `[135]`
Mówca: **Adarfo Sotelato**
> ""All you need to know is that we're working hard towards achieving parity between the Wehzek and Rizian parts of the population. If they don't have equal rights, this whole reunification project is pointless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_WehlenRights_Full == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == false"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_WehlenRights_Full == false)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_WehlenRights_Full == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Adarfo Sotelato: ""All you need to know is that we're working hard towards ..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_WehlenRights_Full == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Adarfo Sotelato: ""I will tell you that your laws have helped smooth tensio..."*)

### Węzeł `[139]`
Mówca: **Adarfo Sotelato**
> ""There's been some trouble with Dastnurists fleeing to Wehlen out of concern for their religious freedoms. I'm not that bothered, to be honest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied..."*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfi..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Adarfo Sotelato: ""There's been some trouble with Dastnurists fleeing to We..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||..."*)

### Węzeł `[143]`
Mówca: **Adarfo Sotelato**
> ""I will tell you that your laws have helped smooth tensions. Granting Wehzeks and Rizians the same rights ahead of the transfer was a smart idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied..."*)

### Węzeł `[144]`
Mówca: **Adarfo Sotelato**
> ""Oh, and we've had to deal with Su Omina members forcibly removing Wehzek families from their homes, claiming the land belongs to ‘true’ Rizians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Adarfo Sotelato: ""We've acted quickly to contain these incidents, but they..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||..."*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Adarfo Sotelato: ""Oh, and we've had to deal with Su Omina members forcibly..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[148]`
Mówca: **Adarfo Sotelato**
> ""We've acted quickly to contain these incidents, but they've only heightened the anxieties of those wary of reintegration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are election preparations going up there?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true) == false` AND `(Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false` AND `(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[105]` (Manus Sazon), `[119]` (Daria de Rava), `[148]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Approved == true"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
  - -> `[149]` (*Player_Romus: ""How are election preparations going up there?""*)
  - -> `[151]` (*Player_Romus: ""Which way do you think they'll lean at the polls?""*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Which way do you think they'll lean at the polls?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true) == false` AND `(Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false` AND `(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[105]` (Manus Sazon), `[119]` (Daria de Rava), `[148]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[152]`
Mówca: **Manus Sazon**
> ""First we have to see if they vote at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Manus Sazon: ""First we have to see if they vote at all.""*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Daria de Rava: ""That depends on who can be coaxed out to vote.""*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Adarfo Sotelato: ""We'll be lucky if they make it to the polls at all.""*)

### Węzeł `[159]`
Mówca: **Daria de Rava**
> ""That depends on who can be coaxed out to vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[160]`
Mówca: **Adarfo Sotelato**
> ""We'll be lucky if they make it to the polls at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Approved == true"*)

### Węzeł `[162]`
Mówca: **Manus Sazon**
> ""Protests continue in some areas, particularly among Zilleans with Wehzek citizenship, who fear being treated as second-class citizens due to their limited legal protections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal == false"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal == f..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Manus Sazon: ""Protests continue in some areas, particularly among Zill..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied..."*)

### Węzeł `[166]`
Mówca: **Manus Sazon**
> ""We've had to work hard to assuage fears among Dastnurists, many of whom have fled to Wehlen anticipating restrictions on their religious practices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied..."*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfi..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Manus Sazon: ""We've had to work hard to assuage fears among Dastnurist..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true"*)

### Węzeł `[170]`
Mówca: **Daria de Rava**
> ""Among the most outspoken critics are Zilleans who hold Wehzek citizenship, fearing they will be treated as second-class citizens due to limited legal protections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal == false"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal == f..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Daria de Rava: ""Among the most outspoken critics are Zilleans who hold W..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied..."*)

### Węzeł `[174]`
Mówca: **Daria de Rava**
> ""There's been a flood of Dastnurists leaving Zille for Wehlen, worried that the Rizian government will restrict their religious freedoms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied..."*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfi..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Daria de Rava: ""There's been a flood of Dastnurists leaving Zille for We..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
