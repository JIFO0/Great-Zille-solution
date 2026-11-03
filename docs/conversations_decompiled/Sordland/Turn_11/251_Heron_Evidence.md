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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 1

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[73]` (Paskal Beniwoll): `UpdateCharacterTitle("Heron Garaci","Former Justice");`

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
  - -> `[5]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `246` (*Sordland/Turn11/A_ImpeachmentTrial*), Węzeł `[48]`

### Węzeł `[3]`
Mówca: **Narrator**
> "The ex-Justice Heron Garaci entered, as confidently and comfortably as if he were walking into his own house."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[4]`
Mówca: **Orso Hawker**
> "“This court now summons Heron Garaci to present his evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[8]`
Mówca: **Ovid Grecer**
> "“This court now summons Heron Garaci to present his evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[9]`
Mówca: **Heron Garaci**
> "“Thank you, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Narrator**
> "Heron took his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[11]`
Mówca: **Narrator**
> "Heron stood up and smiled at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Ovid Grecer**
> "“I see that you are wearing your old garb, Mr. Garaci.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
Mówca: **Orso Hawker**
> "“I see that you are wearing your old garb, Mr. Garaci.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[17]`
Mówca: **Narrator**
> "I was surprised to see he was wearing his justice uniform."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`
  - -> `[24]`
  - -> `[26]`

### Węzeł `[18]`
Mówca: **Ovid Grecer**
> "“Do I have to remind you that it is illegal to wear the robes of a Justice when you no longer hold that position?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Orso Hawker**
> "“Do I have to remind you that it is illegal to wear the robes of a Justice when you no longer hold that position?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Heron Garaci**
> "“Let's just call it a habit, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "“Still trying to latch onto what you don't have?”"]** — Mówca: **Player**
> "“Still trying to latch onto what you don't have?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“Great. You made a clown out of yourself, Heron.”"]** — Mówca: **Player**
> "“Great. You made a clown out of yourself, Heron.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Heron Garaci**
> "“Laugh all you want, Mr. President. I will have the last laugh.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "“You motherfucker...”"]** — Mówca: **Player**
> "“You motherfucker...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Heron Garaci**
> "“Easy, Mr. President. You are in a court of law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "Refrain from making a comment."]** — Mówca: **Player_Italic**
> "I stayed silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[27]`
Mówca: **Ovid Grecer**
> "“Very well. I will permit it for the duration of this session. If you repeat this offense, you will be punished for it. Do you understand?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Orso Hawker**
> "“Very well. I will permit it for the duration of this session. If you repeat this offense, you will be punished for it. Do you understand?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Heron Garaci**
> "“Yes, your honor. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Ovid Grecer**
> "“Present your evidence then, Mr. Garaci.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[37]`
Mówca: **Orso Hawker**
> "“Present your evidence then, Mr. Garaci.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Narrator**
> "He pulled out a check and held it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Heron Garaci**
> "“I was wearing this exact outfit, a Justice's outfit, when Mr. Rayne approached me to give me this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[40]`
Mówca: **Heron Garaci**
> "“This man attempted to bribe a member of the Supreme Court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Heron Garaci**
> "“The check has his own signature on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Heron Garaci**
> "“I think there is not much else to say here, is there?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Heron Garaci**
> "“I leave the accused at the mercy of the court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Ovid Grecer**
> "“The court will take this evidence into consideration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`
  - -> `[51]`
  - -> `[52]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Orso Hawker**
> "“The court will take this evidence into consideration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`
  - -> `[51]`
  - -> `[52]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "“That fabricated piece of paper surely can't be evidence!”"]** — Mówca: **Player**
> "“That fabricated piece of paper surely can't be evidence!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "“I demand that the court investigate the authenticity of this check!”"]** — Mówca: **Player**
> "“I demand that the court investigate the authenticity of this check!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Heron! You are a dead man walking.”"]** — Mówca: **Player**
> "“Heron! You are a dead man walking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I stayed silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Ovid Grecer**
> "“I assure you that as the Supreme Court, we will exercise utmost caution when reviewing the evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[57]`
Mówca: **Orso Hawker**
> "“I assure you that as the Supreme Court, we will exercise utmost caution when reviewing the evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[58]`
Mówca: **Orso Hawker**
> "“I will not allow threats. This is a warning, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[62]`
Mówca: **Ovid Grecer**
> "“I will not allow threats. This is a warning, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Heron Garaci**
> "“That is all I have to present to the court, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Ovid Grecer**
> "“Very well. You may leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[68]`
Mówca: **Orso Hawker**
> "“Very well. You may leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[69]`
Mówca: **Heron Garaci**
> "“Good luck, Mr. President. Enjoy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "“Go to hell.”"]** — Mówca: **Player**
> "“Go to hell.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "“I will get even with you. I promise.”"]** — Mówca: **Player**
> "“I will get even with you. I promise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Narrator**
> "Heron left the courtroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Heron Garaci", "Former Justice");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Heron Garaci","Former Justice");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
