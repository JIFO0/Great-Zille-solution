# Sordland/Turn11/Karl Evidence Main

- **ID konwersacji:** `252`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Sordland/Turn_11/252_Karl_Evidence_Main.md`
- **Liczba węzłów dialogowych:** 140
- **Liczba wyborów gracza:** 3

---

## 1. Uczestnicy Sceny

- **[1]** Ovid Grecer
- **[5]** Player *(Gracz)*
- **[8]** Orso Hawker
- **[10]** Narrator
- **[36]** Heron Garaci
- **[56]** Karl Greiser

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.ChiefJustice_HeronGaraci`
- `BaseGame.ChiefJustice_OvidGrecer`
- `BaseGame.LeakedScandal_SecretState_DetainFrensRicter`
- `BaseGame.LeakedScandal_SecretState_DetainKesaroKibener`
- `BaseGame.LeakedScandal_SecretState_DetainPetrVectern`
- `BaseGame.LeakedScandal_SecretState_KillFrensRicter`
- `BaseGame.LeakedScandal_SecretState_KillKesaroKibener`
- `BaseGame.LeakedScandal_SecretState_KillLiviaSuno`
- `BaseGame.LeakedScandal_SecretState_KillOrsoHawker`
- `BaseGame.LeakedScandal_SecretState_KillPetrVectern`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[246] Sordland/Turn11/A_ImpeachmentTrial** (../Turn_11/246_A_ImpeachmentTrial.md), Węzeł `[122]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[120]` | **"“You can't even look me in the eye, can you?”"** | `[15]` **Narrator**: "As I glared at him, he looked do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Narrator**: "Karl said nothing." |
| `[121]` | **"“It's not your fault, Karl. I know you did your best.”"** | `[15]` **Narrator**: "As I glared at him, he looked do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Narrator**: "Karl said nothing." |
| `[122]` | **"“I can't believe that the man who saved me at the ball would also be my end.”"** | `[15]` **Narrator**: "As I glared at him, he looked do..."<br>`[119]` **Narrator**: "Karl put his hat back on and lef..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Narrator**: "Karl said nothing." |

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
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: "“I can't believe that the man who saved me at the ball wo..."*)

### Węzeł `[3]`
Mówca: **Narrator**
> "Karl Greiser walked in. He took off his hat, stuck it under his arm and gave a stiff bow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Karl Greiser: "“Thank you, your honor.”"*)

### Węzeł `[4]`
Mówca: **Orso Hawker**
> "“This court now summons Karl Greiser to present his evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Karl Greiser walked in. He took off his hat, stuck it und..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Ovid Grecer: "“This court now summons Karl Greiser to present his evide..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Orso Hawker: "“This court now summons Karl Greiser to present his evide..."*)

### Węzeł `[8]`
Mówca: **Heron Garaci**
> "“This court now summons Karl Greiser to present his evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Karl Greiser walked in. He took off his hat, stuck it und..."*)

### Węzeł `[9]`
Mówca: **Ovid Grecer**
> "“This court now summons Karl Greiser to present his evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Karl Greiser walked in. He took off his hat, stuck it und..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Heron Garaci: "“This court now summons Karl Greiser to present his evide..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[13]`
Mówca: **Karl Greiser**
> "“Thank you, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Karl took his seat."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "Karl took his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "As I glared at him, he looked down at the floor."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "As I glared at him, he looked down at the floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: "“You can't even look me in the eye, can you?”"*)
  - -> `[122]` (*Player: "“I can't believe that the man who saved me at the ball wo..."*)
  - -> `[121]` (*Player: "“It's not your fault, Karl. I know you did your best.”"*)

### Węzeł `[16]`
Mówca: **Ovid Grecer**
> "“Mr. Greiser. In the evidence provided to this court, there are very big claims.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Ovid Grecer: "“We will now ask you a few questions.”"*)

### Węzeł `[17]`
Mówca: **Orso Hawker**
> "“Mr. Greiser. In the evidence provided to this court, there are very big claims.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Orso Hawker: "“We will now ask you a few questions.”"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Ovid Grecer: "“Mr. Greiser. In the evidence provided to this court, the..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Orso Hawker: "“Mr. Greiser. In the evidence provided to this court, the..."*)

### Węzeł `[21]`
Mówca: **Heron Garaci**
> "“Mr. Greiser. In the evidence provided to this court, there are very big claims.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Heron Garaci: "“We will now ask you a few questions.”"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Heron Garaci: "“Mr. Greiser. In the evidence provided to this court, the..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[25]`
Mówca: **Heron Garaci**
> "“We will now ask you a few questions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Heron Garaci: "“Is it true that during the time this government has been..."*)

### Węzeł `[26]`
Mówca: **Ovid Grecer**
> "“We will now ask you a few questions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Ovid Grecer: "“Is it true that during the time this government has been..."*)

### Węzeł `[27]`
Mówca: **Orso Hawker**
> "“We will now ask you a few questions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Orso Hawker: "“Is it true that during the time this government has been..."*)

### Węzeł `[28]`
Mówca: **Karl Greiser**
> "“Yes, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[29]`
Mówca: **Heron Garaci**
> "“Is it true that during the time this government has been serving, a new police force has been created?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Karl Greiser: "“Yes, your honor.”"*)

### Węzeł `[30]`
Mówca: **Ovid Grecer**
> "“Is it true that during the time this government has been serving, a new police force has been created?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Karl Greiser: "“Yes, your honor.”"*)

### Węzeł `[31]`
Mówca: **Orso Hawker**
> "“Is it true that during the time this government has been serving, a new police force has been created?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Karl Greiser: "“Yes, your honor.”"*)

### Węzeł `[32]`
Mówca: **Ovid Grecer**
> "“Were you the head of this new police force?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Karl Greiser: "“Yes, your honor.”"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Ovid Grecer: "“Were you the head of this new police force?”"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Orso Hawker: "“Were you the head of this new police force?”"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Heron Garaci: "“Were you the head of this new police force?”"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[39]`
Mówca: **Heron Garaci**
> "“Were you the head of this new police force?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Karl Greiser: "“Yes, your honor.”"*)

### Węzeł `[40]`
Mówca: **Orso Hawker**
> "“Were you the head of this new police force?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Karl Greiser: "“Yes, your honor.”"*)

### Węzeł `[41]`
Mówca: **Karl Greiser**
> "“Yes, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Heron Garaci: "“Could you tell this court the name of this organization?”"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Ovid Grecer: "“Could you tell this court the name of this organization?”"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Orso Hawker: "“Could you tell this court the name of this organization?”"*)

### Węzeł `[48]`
Mówca: **Ovid Grecer**
> "“Could you tell this court the name of this organization?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Karl Greiser: "“It is called the Secret State Police, your honor.”"*)

### Węzeł `[49]`
Mówca: **Heron Garaci**
> "“Could you tell this court the name of this organization?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Karl Greiser: "“It is called the Secret State Police, your honor.”"*)

### Węzeł `[50]`
Mówca: **Orso Hawker**
> "“Could you tell this court the name of this organization?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Karl Greiser: "“It is called the Secret State Police, your honor.”"*)

### Węzeł `[51]`
Mówca: **Karl Greiser**
> "“It is called the Secret State Police, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[52]`
Mówca: **Heron Garaci**
> "“Who ordered the creation of this Secret State Police?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Karl Greiser: "“Mr. President did, your honor.""*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Heron Garaci: "“Who ordered the creation of this Secret State Police?”"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Ovid Grecer: "“Who ordered the creation of this Secret State Police?”"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Orso Hawker: "“Who ordered the creation of this Secret State Police?”"*)

### Węzeł `[59]`
Mówca: **Ovid Grecer**
> "“Who ordered the creation of this Secret State Police?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Karl Greiser: "“Mr. President did, your honor.""*)

### Węzeł `[60]`
Mówca: **Orso Hawker**
> "“Who ordered the creation of this Secret State Police?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Karl Greiser: "“Mr. President did, your honor.""*)

### Węzeł `[61]`
Mówca: **Karl Greiser**
> "“Mr. President did, your honor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[62]`
Mówca: **Heron Garaci**
> "“And what were some of the responsibilities of this Secret State Police?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Karl Greiser: "“Fabrication of evidence. Kidnappings. Assassinations. De..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Heron Garaci: "“And what were some of the responsibilities of this Secre..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Ovid Grecer: "“And what were some of the responsibilities of this Secre..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Orso Hawker: "“And what were some of the responsibilities of this Secre..."*)

### Węzeł `[69]`
Mówca: **Orso Hawker**
> "“And what were some of the responsibilities of this Secret State Police?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Karl Greiser: "“Fabrication of evidence. Kidnappings. Assassinations. De..."*)

### Węzeł `[70]`
Mówca: **Ovid Grecer**
> "“And what were some of the responsibilities of this Secret State Police?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Karl Greiser: "“Fabrication of evidence. Kidnappings. Assassinations. De..."*)

### Węzeł `[71]`
Mówca: **Karl Greiser**
> "“Fabrication of evidence. Kidnappings. Assassinations. Death threats.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[72]`
Mówca: **Orso Hawker**
> "“Are these responsibilities in line with the Sordish constitution, Mr. Greiser?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Karl Greiser: ""I-- no, your honor.”"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Ovid Grecer: "“Are these responsibilities in line with the Sordish cons..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Orso Hawker: "“Are these responsibilities in line with the Sordish cons..."*)

### Węzeł `[76]`
Mówca: **Ovid Grecer**
> "“Are these responsibilities in line with the Sordish constitution, Mr. Greiser?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Karl Greiser: ""I-- no, your honor.”"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Heron Garaci: "“Are these responsibilities in line with the Sordish cons..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[80]`
Mówca: **Heron Garaci**
> "“Are these responsibilities in line with the Sordish constitution, Mr. Greiser?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Karl Greiser: ""I-- no, your honor.”"*)

### Węzeł `[81]`
Mówca: **Karl Greiser**
> ""I-- no, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[82]`
Mówca: **Orso Hawker**
> "“What is the largest task this Secret State Police has handled by the order of the President of Sordland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillPetrVectern == true"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Ovid Grecer: "“What is the largest task this Secret State Police has ha..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Orso Hawker: "“What is the largest task this Secret State Police has ha..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Heron Garaci: "“What is the largest task this Secret State Police has ha..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[89]`
Mówca: **Heron Garaci**
> "“What is the largest task this Secret State Police has handled by the order of the President of Sordland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillPetrVectern == true"*)

### Węzeł `[90]`
Mówca: **Ovid Grecer**
> "“What is the largest task this Secret State Police has handled by the order of the President of Sordland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillPetrVectern == true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillKesaroKibener ==..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Karl Greiser: "“It was the assassination of Kesaro Kibener.”"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter ==..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Karl Greiser: "“It was the detainment of Frens Ricter.”"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Karl Greiser: "“It was the detainment of Livia Suno.”"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ==..."*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Karl Greiser: "“It was the detainment of Kesaro Kibener.”"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillFrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillFrensRicter == true"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillFrensRicter == t..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillFrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Karl Greiser: "“It was the assassination of Frens Ricter.”"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillFrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true"*)

### Węzeł `[103]`
Mówca: **Karl Greiser**
> "“It was the detainment of Frens Ricter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "I heard audible gasps behind me."*)

### Węzeł `[104]`
Mówca: **Karl Greiser**
> "“It was the assassination of Orso Hawker.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "I heard audible gasps behind me."*)

### Węzeł `[105]`
Mówca: **Karl Greiser**
> "“It was the assassination of Kesaro Kibener.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "I heard audible gasps behind me."*)

### Węzeł `[106]`
Mówca: **Karl Greiser**
> "“It was the assassination of Frens Ricter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "I heard audible gasps behind me."*)

### Węzeł `[107]`
Mówca: **Karl Greiser**
> "“It was the detainment of Kesaro Kibener.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "I heard audible gasps behind me."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "I heard audible gasps behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[109]`
Mówca: **Orso Hawker**
> "“Those were all the questions I had. Thank you, Mr. Greiser. You may leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Karl Greiser: "“Thank you, your honor.”"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Ovid Grecer: "“Those were all the questions I had. Thank you, Mr. Greis..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Orso Hawker: "“Those were all the questions I had. Thank you, Mr. Greis..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Heron Garaci: "“Those were all the questions I had. Thank you, Mr. Greis..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[116]`
Mówca: **Ovid Grecer**
> "“Those were all the questions I had. Thank you, Mr. Greiser. You may leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Karl Greiser: "“Thank you, your honor.”"*)

### Węzeł `[117]`
Mówca: **Heron Garaci**
> "“Those were all the questions I had. Thank you, Mr. Greiser. You may leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Karl Greiser: "“Thank you, your honor.”"*)

### Węzeł `[118]`
Mówca: **Karl Greiser**
> "“Thank you, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "Karl put his hat back on and left the courtroom."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "Karl put his hat back on and left the courtroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "“You can't even look me in the eye, can you?”"]** — Mówca: **Player**
> "“You can't even look me in the eye, can you?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "Karl said nothing."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: "“It's not your fault, Karl. I know you did your best.”"]** — Mówca: **Player**
> "“It's not your fault, Karl. I know you did your best.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "Karl said nothing."*)

### Węzeł `[122]`
**[WYBÓR GRACZA: "“I can't believe that the man who saved me at the ball would also be my end.”"]** — Mówca: **Player**
> "“I can't believe that the man who saved me at the ball would also be my end.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Narrator), `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "Karl said nothing."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "Karl said nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillPetrVectern == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillPetrVectern == t..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Karl Greiser: "“It was the assassination of Petr Vectern.”"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainPetrVectern ==..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Karl Greiser: "“It was the detainment of Petr Vectern.”"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ==..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Karl Greiser: "“It was the assassination of Orso Hawker.”"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillFrensRicter == true"*)

### Węzeł `[133]`
Mówca: **Karl Greiser**
> "“It was the assassination of Petr Vectern.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "I heard audible gasps behind me."*)

### Węzeł `[134]`
Mówca: **Karl Greiser**
> "“It was the detainment of Petr Vectern.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "I heard audible gasps behind me."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Karl Greiser: "“It was the assassination of Livia Suno.”"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true"*)

### Węzeł `[138]`
Mówca: **Karl Greiser**
> "“It was the assassination of Livia Suno.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "I heard audible gasps behind me."*)

### Węzeł `[139]`
Mówca: **Karl Greiser**
> "“It was the detainment of Livia Suno.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "I heard audible gasps behind me."*)
