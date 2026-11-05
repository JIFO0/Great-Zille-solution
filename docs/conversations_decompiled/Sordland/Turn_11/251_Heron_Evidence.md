# Sordland/Turn11/Heron Evidence

- **ID konwersacji:** `251`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Sordland/Turn_11/251_Heron_Evidence.md`
- **Liczba węzłów dialogowych:** 74
- **Liczba wyborów gracza:** 10

---

## 1. Uczestnicy Sceny

- **[1]** Ovid Grecer
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[8]** Orso Hawker
- **[10]** Narrator
- **[36]** Heron Garaci

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.ChiefJustice_OvidGrecer`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[246] Sordland/Turn11/A_ImpeachmentTrial** (../Turn_11/246_A_ImpeachmentTrial.md), Węzeł `[48]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[21]` | **"“Still trying to latch onto what you don't have?”"** | `[17]` **Narrator**: "I was surprised to see he was we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Heron Garaci**: "“Laugh all you want, Mr. Preside..." |
| `[22]` | **"“Great. You made a clown out of yourself, Heron.”"** | `[17]` **Narrator**: "I was surprised to see he was we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Heron Garaci**: "“Laugh all you want, Mr. Preside..." |
| `[24]` | **"“You motherfucker...”"** | `[17]` **Narrator**: "I was surprised to see he was we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Heron Garaci**: "“Easy, Mr. President. You are in..." |
| `[26]` | **"Refrain from making a comment."** | `[17]` **Narrator**: "I was surprised to see he was we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Ovid Grecer**: "“I see that you are wearing your..."<br>`[16]` **Orso Hawker**: "“I see that you are wearing your..." |
| `[49]` | **"“That fabricated piece of paper surely can't be evidence!”"** | `[44]` **Ovid Grecer**: "“The court will take this eviden..."<br>`[48]` **Orso Hawker**: "“The court will take this eviden..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Ovid Grecer**: "“I assure you that as the Suprem..."<br>`[57]` **Orso Hawker**: "“I assure you that as the Suprem..." |
| `[50]` | **"“I demand that the court investigate the authenticity of this check!”"** | `[44]` **Ovid Grecer**: "“The court will take this eviden..."<br>`[48]` **Orso Hawker**: "“The court will take this eviden..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Ovid Grecer**: "“I assure you that as the Suprem..."<br>`[57]` **Orso Hawker**: "“I assure you that as the Suprem..." |
| `[51]` | **"“Heron! You are a dead man walking.”"** | `[44]` **Ovid Grecer**: "“The court will take this eviden..."<br>`[48]` **Orso Hawker**: "“The court will take this eviden..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Ovid Grecer**: "“I will not allow threats. This ..."<br>`[58]` **Orso Hawker**: "“I will not allow threats. This ..." |
| `[52]` | **"Stay silent."** | `[44]` **Ovid Grecer**: "“The court will take this eviden..."<br>`[48]` **Orso Hawker**: "“The court will take this eviden..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Heron Garaci**: "“That is all I have to present t..." |
| `[70]` | **"“Go to hell.”"** | `[69]` **Heron Garaci**: "“Good luck, Mr. President. Enjoy.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "Heron left the courtroom." |
| `[71]` | **"“I will get even with you. I promise.”"** | `[69]` **Heron Garaci**: "“Good luck, Mr. President. Enjoy.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "Heron left the courtroom." |

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
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Orso Hawker: "“The court will take this evidence into consideration.”"*)

### Węzeł `[3]`
Mówca: **Narrator**
> "The ex-Justice Heron Garaci entered, as confidently and comfortably as if he were walking into his own house."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Heron Garaci: "“Thank you, your honor.”"*)

### Węzeł `[4]`
Mówca: **Orso Hawker**
> "“This court now summons Heron Garaci to present his evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Heron Garaci", "Former Justice");"*)

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
  - -> `[8]` (*Ovid Grecer: "“This court now summons Heron Garaci to present his evide..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Orso Hawker: "“This court now summons Heron Garaci to present his evide..."*)

### Węzeł `[8]`
Mówca: **Ovid Grecer**
> "“This court now summons Heron Garaci to present his evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Heron Garaci", "Former Justice");"*)

### Węzeł `[9]`
Mówca: **Heron Garaci**
> "“Thank you, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Heron took his seat."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "Heron took his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "I was surprised to see he was wearing his justice uniform."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "Heron stood up and smiled at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Heron Garaci: "“Good luck, Mr. President. Enjoy.”"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Ovid Grecer: "“I see that you are wearing your old garb, Mr. Garaci.”"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Orso Hawker: "“I see that you are wearing your old garb, Mr. Garaci.”"*)

### Węzeł `[15]`
Mówca: **Ovid Grecer**
> "“I see that you are wearing your old garb, Mr. Garaci.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Ovid Grecer: "“Do I have to remind you that it is illegal to wear the r..."*)

### Węzeł `[16]`
Mówca: **Orso Hawker**
> "“I see that you are wearing your old garb, Mr. Garaci.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Orso Hawker: "“Do I have to remind you that it is illegal to wear the r..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "I was surprised to see he was wearing his justice uniform."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: "“Still trying to latch onto what you don't have?”"*)
  - -> `[22]` (*Player: "“Great. You made a clown out of yourself, Heron.”"*)
  - -> `[24]` (*Player: "“You motherfucker...”"*)
  - -> `[26]` (*Player_Italic: "Refrain from making a comment."*)

### Węzeł `[18]`
Mówca: **Ovid Grecer**
> "“Do I have to remind you that it is illegal to wear the robes of a Justice when you no longer hold that position?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Heron Garaci: "“Let's just call it a habit, your honor.”"*)

### Węzeł `[19]`
Mówca: **Orso Hawker**
> "“Do I have to remind you that it is illegal to wear the robes of a Justice when you no longer hold that position?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Heron Garaci: "“Let's just call it a habit, your honor.”"*)

### Węzeł `[20]`
Mówca: **Heron Garaci**
> "“Let's just call it a habit, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“Still trying to latch onto what you don't have?”"]** — Mówca: **Player**
> "“Still trying to latch onto what you don't have?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Heron Garaci: "“Laugh all you want, Mr. President. I will have the last ..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“Great. You made a clown out of yourself, Heron.”"]** — Mówca: **Player**
> "“Great. You made a clown out of yourself, Heron.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Heron Garaci: "“Laugh all you want, Mr. President. I will have the last ..."*)

### Węzeł `[23]`
Mówca: **Heron Garaci**
> "“Laugh all you want, Mr. President. I will have the last laugh.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“You motherfucker...”"]** — Mówca: **Player**
> "“You motherfucker...”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Heron Garaci: "“Easy, Mr. President. You are in a court of law.""*)

### Węzeł `[25]`
Mówca: **Heron Garaci**
> "“Easy, Mr. President. You are in a court of law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "Refrain from making a comment."]** — Mówca: **Player_Italic**
> "I stayed silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[27]`
Mówca: **Ovid Grecer**
> "“Very well. I will permit it for the duration of this session. If you repeat this offense, you will be punished for it. Do you understand?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Heron Garaci: "“Yes, your honor. Thank you.”"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Ovid Grecer: "“Very well. I will permit it for the duration of this ses..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Orso Hawker: "“Very well. I will permit it for the duration of this ses..."*)

### Węzeł `[31]`
Mówca: **Orso Hawker**
> "“Very well. I will permit it for the duration of this session. If you repeat this offense, you will be punished for it. Do you understand?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Heron Garaci: "“Yes, your honor. Thank you.”"*)

### Węzeł `[32]`
Mówca: **Heron Garaci**
> "“Yes, your honor. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

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
  - -> `[36]` (*Ovid Grecer: "“Present your evidence then, Mr. Garaci.”"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Orso Hawker: "“Present your evidence then, Mr. Garaci.”"*)

### Węzeł `[36]`
Mówca: **Ovid Grecer**
> "“Present your evidence then, Mr. Garaci.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Heron Garaci: "“I was wearing this exact outfit, a Justice's outfit, whe..."*)

### Węzeł `[37]`
Mówca: **Orso Hawker**
> "“Present your evidence then, Mr. Garaci.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Heron Garaci: "“I was wearing this exact outfit, a Justice's outfit, whe..."*)

### Węzeł `[38]`
Mówca: **Narrator**
> "He pulled out a check and held it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Heron Garaci: "“This man attempted to bribe a member of the Supreme Court.”"*)

### Węzeł `[39]`
Mówca: **Heron Garaci**
> "“I was wearing this exact outfit, a Justice's outfit, when Mr. Rayne approached me to give me this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "He pulled out a check and held it up."*)

### Węzeł `[40]`
Mówca: **Heron Garaci**
> "“This man attempted to bribe a member of the Supreme Court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Heron Garaci: "“The check has his own signature on it.”"*)

### Węzeł `[41]`
Mówca: **Heron Garaci**
> "“The check has his own signature on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Heron Garaci: "“I think there is not much else to say here, is there?”"*)

### Węzeł `[42]`
Mówca: **Heron Garaci**
> "“I think there is not much else to say here, is there?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Heron Garaci: "“I leave the accused at the mercy of the court.”"*)

### Węzeł `[43]`
Mówca: **Heron Garaci**
> "“I leave the accused at the mercy of the court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[44]`
Mówca: **Ovid Grecer**
> "“The court will take this evidence into consideration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player: "“That fabricated piece of paper surely can't be evidence!”"*)
  - -> `[50]` (*Player: "“I demand that the court investigate the authenticity of ..."*)
  - -> `[51]` (*Player: "“Heron! You are a dead man walking.”"*)
  - -> `[52]` (*Player_Italic: "Stay silent."*)

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
  - -> `[44]` (*Ovid Grecer: "“The court will take this evidence into consideration.”"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Orso Hawker: "“The court will take this evidence into consideration.”"*)

### Węzeł `[48]`
Mówca: **Orso Hawker**
> "“The court will take this evidence into consideration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player: "“That fabricated piece of paper surely can't be evidence!”"*)
  - -> `[50]` (*Player: "“I demand that the court investigate the authenticity of ..."*)
  - -> `[51]` (*Player: "“Heron! You are a dead man walking.”"*)
  - -> `[52]` (*Player_Italic: "Stay silent."*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "“That fabricated piece of paper surely can't be evidence!”"]** — Mówca: **Player**
> "“That fabricated piece of paper surely can't be evidence!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Ovid Grecer), `[48]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "“I demand that the court investigate the authenticity of this check!”"]** — Mówca: **Player**
> "“I demand that the court investigate the authenticity of this check!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Ovid Grecer), `[48]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Heron! You are a dead man walking.”"]** — Mówca: **Player**
> "“Heron! You are a dead man walking.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Ovid Grecer), `[48]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I stayed silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Ovid Grecer), `[48]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Heron Garaci: "“That is all I have to present to the court, your honor.”"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Ovid Grecer: "“I assure you that as the Supreme Court, we will exercise..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Orso Hawker: "“I assure you that as the Supreme Court, we will exercise..."*)

### Węzeł `[56]`
Mówca: **Ovid Grecer**
> "“I assure you that as the Supreme Court, we will exercise utmost caution when reviewing the evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Heron Garaci: "“That is all I have to present to the court, your honor.”"*)

### Węzeł `[57]`
Mówca: **Orso Hawker**
> "“I assure you that as the Supreme Court, we will exercise utmost caution when reviewing the evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Heron Garaci: "“That is all I have to present to the court, your honor.”"*)

### Węzeł `[58]`
Mówca: **Orso Hawker**
> "“I will not allow threats. This is a warning, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Heron Garaci: "“That is all I have to present to the court, your honor.”"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Ovid Grecer: "“I will not allow threats. This is a warning, Mr. Preside..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Orso Hawker: "“I will not allow threats. This is a warning, Mr. Preside..."*)

### Węzeł `[62]`
Mówca: **Ovid Grecer**
> "“I will not allow threats. This is a warning, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Heron Garaci: "“That is all I have to present to the court, your honor.”"*)

### Węzeł `[63]`
Mówca: **Heron Garaci**
> "“That is all I have to present to the court, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Ovid Grecer: "“Very well. You may leave.”"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Orso Hawker: "“Very well. You may leave.”"*)

### Węzeł `[67]`
Mówca: **Ovid Grecer**
> "“Very well. You may leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Heron stood up and smiled at me."*)

### Węzeł `[68]`
Mówca: **Orso Hawker**
> "“Very well. You may leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Heron stood up and smiled at me."*)

### Węzeł `[69]`
Mówca: **Heron Garaci**
> "“Good luck, Mr. President. Enjoy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player: "“Go to hell.”"*)
  - -> `[71]` (*Player: "“I will get even with you. I promise.”"*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "“Go to hell.”"]** — Mówca: **Player**
> "“Go to hell.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Heron left the courtroom."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "“I will get even with you. I promise.”"]** — Mówca: **Player**
> "“I will get even with you. I promise.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Heron left the courtroom."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "Heron left the courtroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Heron Garaci", "Former Justice");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Heron Garaci","Former Justice");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The ex-Justice Heron Garaci entered, as confidently and c..."*)
