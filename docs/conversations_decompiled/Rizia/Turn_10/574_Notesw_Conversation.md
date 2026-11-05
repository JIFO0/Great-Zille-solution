# Rizia/Turn 10/HOUSES GATHER/Notesw/Notesw Conversation

- **ID konwersacji:** `574`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/574_Notesw_Conversation.md`
- **Liczba węzłów dialogowych:** 73
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[67]** Hubertus Toras
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[75]** Manus Sazon
- **[79]** Vina Toras
- **[91]** Rico Toras
- **[94]** Axel Reinhart
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Pabel_RelationshipPublic`
- `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan`
- `RiziaDLC.Vina_MarriageDecision_Axel`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.Vina_MarriageDecision_Rico`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

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
Mówca: **Estela Toras**
> ""I would've been just as happy doing something small.”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[4]`
Mówca: **Narrator**
> ""...and Manus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC...."*)

### Węzeł `[5]`
Mówca: **Narrator**
> ""...and Rico.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC...."*)

### Węzeł `[6]`
Mówca: **Narrator**
> ""...and Axel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC...."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC...."*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDL..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true )"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Vina Toras: "“I have to admit, the renovations turned out better than ..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Axel == true"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Axel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Axel == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Axel == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Axel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Vina Toras: "“It’s quite something, isn’t it?""*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Axel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true"*)

### Węzeł `[16]`
Mówca: **Vina Toras**
> "“I have to admit, the renovations turned out better than I expected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true || RiziaDLC.Pabel_Relatio..."*)

### Węzeł `[17]`
Mówca: **Vina Toras**
> "“It’s quite something, isn’t it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true || RiziaDLC.Pabel_Relatio..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Rico == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Vina Toras: "“I love what they've done with the place. It looks absolu..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Vina Toras: "“I think the renovations breathe new life into the space.”"*)

### Węzeł `[21]`
Mówca: **Vina Toras**
> "“I love what they've done with the place. It looks absolutely beautiful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true || RiziaDLC.Pabel_Relatio..."*)

### Węzeł `[22]`
Mówca: **Vina Toras**
> "“I think the renovations breathe new life into the space.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Estela Toras: ""I would've been just as happy doing something small.”"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true || RiziaDLC.Pabel_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true || RiziaDLC.Pabel_Relatio..."*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true || RiziaDLC.Pabel_Relat..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true || RiziaDLC.Pabel_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  or  Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Manus Sazon: "“The attention to detail is impeccable.""*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true || RiziaDLC.Pabel_RelationshipPublic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  or  Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Manus Sazon: "“The attention to detail is impeccable. It leaves quite t..."*)

### Węzeł `[26]`
Mówca: **Manus Sazon**
> "“The attention to detail is impeccable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lucita Azaro: ""It certainly makes quite an impression.""*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Pabel Adria: ""It does make quite the impression.""*)

### Węzeł `[30]`
Mówca: **Lucita Azaro**
> ""It certainly makes quite an impression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Estela Toras: ""I would've been just as happy doing something small.”"*)

### Węzeł `[31]`
Mówca: **Pabel Adria**
> ""It does make quite the impression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Estela Toras: ""I would've been just as happy doing something small.”"*)

### Węzeł `[32]`
Mówca: **Manus Sazon**
> "“The attention to detail is impeccable. It leaves quite the impression.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Estela Toras: ""I would've been just as happy doing something small.”"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true || RiziaDLC.Pabel_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true || RiziaDLC.Pabel_Relatio..."*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true || RiziaDLC.Pabel_Relat..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true || RiziaDLC.Pabel_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  or  Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Axel Reinhart: "“Indeed, a fitting tribute to your mother’s legacy.""*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true || RiziaDLC.Pabel_RelationshipPublic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  or  Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Axel Reinhart: "“Indeed, a fitting tribute to your mother’s legacy. It’s ..."*)

### Węzeł `[36]`
Mówca: **Vina Toras**
> ""Must you always find a way to ruin the mood?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[37]`
Mówca: **Narrator**
> "Rico glared at Pabel sharply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Estela Toras: ""I would've been just as happy doing something small.”"*)

### Węzeł `[38]`
Mówca: **Axel Reinhart**
> "“Indeed, a fitting tribute to your mother’s legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Lucita Azaro: ""It’s truly something to behold.""*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Pabel Adria: ""It’s really quite a sight.""*)

### Węzeł `[42]`
Mówca: **Lucita Azaro**
> ""It’s truly something to behold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Estela Toras: ""I would've been just as happy doing something small.”"*)

### Węzeł `[43]`
Mówca: **Pabel Adria**
> ""It’s really quite a sight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Estela Toras: ""I would've been just as happy doing something small.”"*)

### Węzeł `[44]`
Mówca: **Axel Reinhart**
> "“Indeed, a fitting tribute to your mother’s legacy. It’s truly something to behold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Estela Toras: ""I would've been just as happy doing something small.”"*)

### Węzeł `[45]`
Mówca: **Rico Toras**
> "“If you like wasting money on old books and dust. Sure, it’s fantastic.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Vina Toras: ""Must you always find a way to ruin the mood?""*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true || RiziaDLC.Pabel_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true || RiziaDLC.Pabel_Relatio..."*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true || RiziaDLC.Pabel_Relat..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true || RiziaDLC.Pabel_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  or  Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Rico Toras: "“If you like wasting money on old books and dust. Sure, i..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true || RiziaDLC.Pabel_RelationshipPublic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  or  Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Rico Toras: "“If you enjoy wasting money on old books and dust, then s..."*)

### Węzeł `[49]`
Mówca: **Rico Toras**
> "“If you enjoy wasting money on old books and dust, then sure. It’s fantastic.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Estela Toras: ""I would've been just as happy doing something small.”"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lucita Azaro: ""Sometimes it's better to just keep those thoughts to you..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Pabel Adria: ""I thought we were here to celebrate, not criticize.""*)

### Węzeł `[53]`
Mówca: **Lucita Azaro**
> ""Sometimes it's better to just keep those thoughts to yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Estela Toras: ""I would've been just as happy doing something small.”"*)

### Węzeł `[54]`
Mówca: **Pabel Adria**
> ""I thought we were here to celebrate, not criticize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Rico glared at Pabel sharply."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "Elegantly dressed, they walked down the hall flanked by golden guardsmen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[56]`
Mówca: **Narrator**
> "Hugo bowed first and the others followed suit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Hugo Toras: ""Your Majesty. Queen Mother, happy birthday.""*)

### Węzeł `[57]`
Mówca: **Hugo Toras**
> ""Your Majesty. Queen Mother, happy birthday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Rico Toras: ""Queen Mother, wishing you all the best.""*)

### Węzeł `[58]`
Mówca: **Rico Toras**
> ""Queen Mother, wishing you all the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Hubertus Toras: "“Many blessings on your birthday, Your Majesty.""*)

### Węzeł `[59]`
Mówca: **Hubertus Toras**
> "“Many blessings on your birthday, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Rico Toras: ""’Many blethingths on your birthday, Your Majesthty.’""*)

### Węzeł `[60]`
Mówca: **Rico Toras**
> ""’Many blethingths on your birthday, Your Majesthty.’""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "Hugo rolled his eyes at Rico’s mockery of Hubertus’ lisp,..."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "Hugo rolled his eyes at Rico’s mockery of Hubertus’ lisp, a trait that had afflicted him since childhood."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
Mówca: **Narrator**
> "Estela's expression tightened, her patience wearing thin at Rico's mockery of Hubertus’ childhood lisp."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Rico == true)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Rico Toras: ""’Many heartfelt blethingths on your birthday, Your Majes..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "Narrator: "...""*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Narrator: "..."`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[67]`
Mówca: **Rico Toras**
> ""’Many heartfelt blethingths on your birthday, Your Majesthty.’""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "Estela's expression tightened, her patience wearing thin ..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "Elegantly dressed, they walked down the hall flanked by Wruhec's Guardians."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[69]`
Mówca: **Hubertus Toras**
> ""Many heartfelt blessings on your birthday, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true"*)

### Węzeł `[70]`
Mówca: **Narrator**
> "Hugo bowed slightly. As he straightened, he shot me a subtle glance, eyes reflecting quiet readiness for the evening ahead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Hugo Toras: ""Your Majesty. Queen Mother, happy birthday.""*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Hugo bowed slightly. As he straightened, he shot me a sub..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "Hugo bowed first and the others followed suit."*)
