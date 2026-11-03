# Sordland/Turn10/SnO_CoupNight

- **ID konwersacji:** `227`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/227_SnO_CoupNight.md`
- **Liczba węzłów dialogowych:** 212
- **Liczba wyborów gracza:** 30

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[20]** Deana
- **[42]** Valken Kruger
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Relations_Iosef_Enemy`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.Security_Unrest_Military`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Economy`
- `BaseGame.GovernmentBudget`
- `BaseGameSupport.Journal_Turn10_Coup_Iosef`
- `BaseGameSupport.Journal_Turn10_Coup_Valken`
- `GameCondition.Turn10_SnO_CoupNight`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 10

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy`
- `BaseGame.GovernmentBudget`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[3]` (Paskal Beniwoll): `Variable["GameCondition.Turn10_SnO_CoupNight"] = true;`
- Węzeł `[203]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn10_Coup_Iosef"] = true;`
- Węzeł `[204]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn10_Coup_Valken"] = true;`
- Węzeł `[205]` (Paskal Beniwoll): `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 2; Variable["BaseGame.GovernmentBud...`
- Węzeł `[206]` (Paskal Beniwoll): `UpdateCharacterTitle("Iosef Lancea","Defacto Head of State");`
- Węzeł `[207]` (Paskal Beniwoll): `UpdateCharacterTitle("Valken Kruger","Defacto Head of State");`
- Węzeł `[208]` (Paskal Beniwoll): `PlaySoundEffect("LoudKnockDoor");`
- Węzeł `[209]` (Paskal Beniwoll): `PlaySoundEffect("LouderKnockDoor"); ;`
- *...oraz 2 innych węzłów ze skryptami.*

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
  - -> `[208]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn10_SnO_CoupNight = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn10_SnO_CoupNight"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[4]`
Mówca: **Narrator**
> "I woke up to a loud knock on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[5]`
**[WYBÓR GRACZA: "“All right, all right. I'm coming.”"]** — Mówca: **Player**
> "“All right, all right. I'm coming.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[6]`
Mówca: **Iosef Lancea**
> "“We need to talk, Mr. President. This is urgent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[30]`

### Węzeł `[7]`
Mówca: **Narrator**
> "I managed to open my eyes and looked at the clock. It was 11:58 PM."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Who could it be at this hour?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Huffing and puffing, I put on my slippers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[13]`
Mówca: **Narrator**
> "Out of habit, I looked towards the other side of the bed. It was empty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[14]`
Mówca: **Narrator**
> "I looked at the other side of the bed. Monica was sleeping soundly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[15]`
Mówca: **Narrator**
> "I started walking downstairs. I heard another knock on the door, louder this time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[16]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "Keep walking towards the door."]** — Mówca: **Player_Italic**
> "I kept walking towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Narrator**
> "Another knock. This time, even louder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "Open the door."]** — Mówca: **Player_Italic**
> "I opened the door and looked outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "Look through the peephole."]** — Mówca: **Player_Italic**
> "I looked through the peephole."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Narrator**
> "I could see Iosef standing outside, accompanied by a few soldiers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Narrator**
> "I could see General Valken Kruger outside, accompanied by a couple of soldiers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[25]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "“What is going on? Why are you here at this hour? I won't open the door unless you answer.”"]** — Mówca: **Player**
> "“What is going on? Why are you here at this hour? I won't open the door unless you answer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Valken Kruger**
> "“We need to talk, Mr. President. This is urgent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[30]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Tell me what it's about first.”"]** — Mówca: **Player**
> "“Tell me what it's about first.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[31]`
Mówca: **Valken Kruger**
> "“Do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[32]`
Mówca: **Iosef Lancea**
> "“Do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[36]`
Mówca: **Narrator**
> "With a scary thud, the door shook on its hinges."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[40]`
Mówca: **Monica**
> "“Anton! What is going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[42]`
  - -> `[41]`

### Węzeł `[41]`
**[WYBÓR GRACZA: "“Monica. Take Deana and hide somewhere.”"]** — Mówca: **Player**
> "“Monica. Take Deana and hide somewhere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "“We have to run. Now.”"]** — Mówca: **Player**
> "“We have to run. Now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“It's okay. I'll handle this.”"]** — Mówca: **Player**
> "“It's okay. I'll handle this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[44]`
Mówca: **Narrator**
> "Monica rushed down the stairs, still in her nightgown. Her voice was trembling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[45]`
Mówca: **Narrator**
> "I was met with 20 to 30 men waiting near personnel trucks, all in full combat gear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Narrator**
> "As I opened the door wider, they started moving towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[47]`
  - -> `[49]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "“What the hell is the meaning of this?”"]** — Mówca: **Player**
> "“What the hell is the meaning of this?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Explain yourselves! Immediately!”"]** — Mówca: **Player**
> "“Explain yourselves! Immediately!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "“You can't just barge into the house of the President! I will have you removed!”"]** — Mówca: **Player**
> "“You can't just barge into the house of the President! I will have you removed!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[50]`
Mówca: **Narrator**
> "Another thud and the door was cracked open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Monica**
> "“Anton!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Narrator**
> "Soldiers immediately stormed into my house."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Narrator**
> "No one replied. Instead, the soldiers stormed past me and into the house."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Narrator**
> "They entered and went through every room, checking for threats. Once they were done, they stood ready."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Narrator**
> "Iosef walked in. Soldiers saluted him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`
  - -> `[63]`

### Węzeł `[59]`
Mówca: **Narrator**
> "General Kruger walked in. Soldiers saluted him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`
  - -> `[63]`

### Węzeł `[60]`
Mówca: **Narrator**
> "Another thud and the door was cracked open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "“You! How dare you?”"]** — Mówca: **Player**
> "“You! How dare you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "“You will explain to me what the hell is going on. Right now!”"]** — Mówca: **Player**
> "“You will explain to me what the hell is going on. Right now!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "“Do you think you can just get away with this?”"]** — Mówca: **Player**
> "“Do you think you can just get away with this?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[67]`
Mówca: **Valken Kruger**
> "“I'm sorry, but your time is over, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[68]`
Mówca: **Iosef Lancea**
> "“I'm sorry, but your time is over, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Iosef Lancea**
> "“You are under arrest for your crimes against Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Iosef Lancea**
> "“Above all else, you have committed high treason and conspired against the will of your people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`
  - -> `[73]`

### Węzeł `[71]`
Mówca: **Valken Kruger**
> "“Above all else, you have committed high treason and conspired against the will of your people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Valken Kruger**
> "“You are under arrest for your crimes against Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "“You can take me, but please, don't hurt my family.”"]** — Mówca: **Player**
> "“You can take me, but please, don't hurt my family.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "“How long have you been planning this?”"]** — Mówca: **Player**
> "“How long have you been planning this?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“I have done nothing wrong. Please let me go at once!”"]** — Mówca: **Player**
> "“I have done nothing wrong. Please let me go at once!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[76]`
Mówca: **Valken Kruger**
> "“Since the day you betrayed your country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[80]`
Mówca: **Iosef Lancea**
> "“Since the day you betrayed your country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[81]`
Mówca: **Valken Kruger**
> "“I'm afraid that is impossible. We do not negotiate with traitors.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[85]`
Mówca: **Iosef Lancea**
> "“I'm afraid that is impossible. We do not negotiate with traitors.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[86]`
Mówca: **Valken Kruger**
> "“Rest assured. Your family will be under our watch and they will remain safe. That is, of course, if you cooperate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[90]`
Mówca: **Iosef Lancea**
> "“Rest assured. Your family will be under our watch and they will remain safe. That is, of course, if you cooperate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[91]`
Mówca: **Iosef Lancea**
> "“The military had no choice but to take over the government to ensure the well-being of Sordland and its people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[92]`
Mówca: **Valken Kruger**
> "“The military had no choice but to take over the government to ensure the well-being of Sordland and its people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[96]`
Mówca: **Iosef Lancea**
> "“The Grand National Assembly is hereby abolished along with the immunity of members of the parliament.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Iosef Lancea**
> "“In addition, a curfew is now in effect and all gatherings are banned until further notice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[98]`
Mówca: **Valken Kruger**
> "“The Grand National Assembly is hereby abolished along with the immunity of members of the parliament.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Valken Kruger**
> "“In addition, a curfew is now in effect and all gatherings are banned until further notice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Iosef Lancea**
> "“All government officials who are suspected of betraying their country will be tried in military court and made to answer for their crimes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Valken Kruger**
> "“All government officials who are suspected of betraying their country will be tried in military court and made to answer for their crimes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Iosef Lancea**
> "“That includes you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`
  - -> `[107]`

### Węzeł `[103]`
Mówca: **Valken Kruger**
> "“That includes you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`
  - -> `[107]`

### Węzeł `[104]`
Mówca: **Narrator**
> "A soldier started approaching me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "“No. You can't do this! I won't let you. I am the President of Sordland!”"]** — Mówca: **Player**
> "“No. You can't do this! I won't let you. I am the President of Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[106]`
**[WYBÓR GRACZA: "“You are destroying our democracy!”"]** — Mówca: **Player**
> "“You are destroying our democracy!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[107]`
**[WYBÓR GRACZA: "“You will pay one day for your heinous actions! I swear on my name!”"]** — Mówca: **Player**
> "“You will pay one day for your heinous actions! I swear on my name!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[108]`
Mówca: **Valken Kruger**
> "“Not anymore.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[109]`
Mówca: **Iosef Lancea**
> "“Not anymore.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[113]`
Mówca: **Valken Kruger**
> "“No. We are protecting our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[114]`
Mówca: **Iosef Lancea**
> "“No. We are protecting our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[118]`
Mówca: **Valken Kruger**
> "“The only heinous actions in question are yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[119]`
Mówca: **Iosef Lancea**
> "“The only heinous actions in question are yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[123]`
Mówca: **Iosef Lancea**
> "“Take him away!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Valken Kruger**
> "“Take him away!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Iosef Lancea**
> "“I don't want to see his face.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Valken Kruger**
> "“I don't want to see his face.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Iosef Lancea**
> "“He will wait in a cell in Antel Rock Prison until his trial.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[128]`
Mówca: **Valken Kruger**
> "“He will wait in a cell in Antel Rock Prison until his trial.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[132]`
Mówca: **Monica**
> "“Anton! No! I won't let you take him!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Narrator**
> "Deana appeared at the top of the stairs. She rubbed her eyes in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Deana**
> "“Mama! Where are they taking him?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Narrator**
> "Monica pulled on my jacket. A soldier moved in and shoved her away forcefully. Tears welled up in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Monica**
> "“Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`
  - -> `[139]`

### Węzeł `[137]`
**[WYBÓR GRACZA: "“Everything will be fine, Monica. Take care of Deana.”"]** — Mówca: **Player**
> "“Everything will be fine, Monica. Take care of Deana.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[138]`
**[WYBÓR GRACZA: "“We will get through this. I promise.”"]** — Mówca: **Player**
> "“We will get through this. I promise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[139]`
**[WYBÓR GRACZA: "“I'm sorry for everything.”"]** — Mówca: **Player**
> "“I'm sorry for everything.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Narrator**
> "Another soldier pulled out handcuffs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[142]`
  - -> `[143]`

### Węzeł `[141]`
Mówca: **Monica**
> "“No! You can't take him away! Please! This is unconstitutional!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[142]`
**[WYBÓR GRACZA: "Resist the arrest."]** — Mówca: **Player_Italic**
> "I pushed the soldier away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[143]`
**[WYBÓR GRACZA: "Let the soldier handcuff you."]** — Mówca: **Player_Italic**
> "I let the soldier handcuff me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[144]`
Mówca: **Narrator**
> "The soldier angrily pulled out his rifle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Narrator**
> "He hit me in the head with the gunstock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Narrator**
> "My eyes closed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[147]`
Mówca: **Narrator**
> "He escorted me to the truck. I realized I still had my slippers on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Narrator**
> "They roughly shoved me into the back of the vehicle, as they would a common criminal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[149]`
**[WYBÓR GRACZA: "“There is no need for handcuffs. I know when I have no way out.”"]** — Mówca: **Player**
> "“There is no need for handcuffs. I know when I have no way out.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Narrator**
> "The soldier stopped in his tracks and looked at Iosef for confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Narrator**
> "The soldier stopped in his tracks and looked at General Kruger for confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Narrator**
> "His men escorted me to the truck. I realized I still had my slippers on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Narrator**
> "They roughly shoved me into the back of the vehicle, as they would a common criminal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Military == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Military == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Security_Unrest_Military == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[161]`
Mówca: **Iosef Lancea**
> "“You have given us an order to protect this country from threats. We are doing exactly that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Military == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Military == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Security_Unrest_Military == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[165]`
Mówca: **Valken Kruger**
> "“You have given us an order to protect this country from threats. We are doing exactly that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[166]`
Mówca: **Narrator**
> "Out of habit, I looked towards the other side of the bed. It was empty. Monica and Deana were at the main house on the other side of the complex."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_DivorceAfterElection == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_DivorceAfterElection == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[173]`
Mówca: **Narrator**
> "Another thud, and the door was cracked open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Narrator**
> "Soldiers immediately stormed into the guesthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_DivorceAfterElection == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[178]`
Mówca: **Narrator**
> "No one replied. Instead, the soldiers stormed past me and into the guesthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[182]`
Mówca: **Iosef Lancea**
> ""Your wife and daughter have been taken into military custody. Rest assured, they will remain safe as long as you cooperate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[186]`
Mówca: **Valken Kruger**
> ""Your wife and daughter have been taken into military custody. Rest assured, they will remain safe as long as you cooperate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_DivorceAfterElection == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[190]`
Mówca: **Narrator**
> "Suddenly, Monica came running across the courtyard, tailed closely by two military men."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Monica**
> ""Anton!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`
  - -> `[194]`

### Węzeł `[192]`
**[WYBÓR GRACZA: ""It's okay, Monica. I'll be fine.""]** — Mówca: **Player**
> ""It's okay, Monica. I'll be fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[193]`
**[WYBÓR GRACZA: ""I'm sorry for everything, Monica.""]** — Mówca: **Player**
> ""I'm sorry for everything, Monica.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
**[WYBÓR GRACZA: ""I love you, Monica.""]** — Mówca: **Player**
> ""I love you, Monica.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Monica**
> ""I just wanted to say...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Monica**
> ""Do everything they tell you. Everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Monica**
> ""If they so much as lay a finger on Deana... I'll kill you myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[198]`
Mówca: **Narrator**
> "The engine rumbled to life and the truck started moving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Narrator**
> "The engine rumbled to life and the truck started moving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_Coup_Iosef = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_Coup_Iosef"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_Coup_Valken = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_Coup_Valken"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy -= 2; BaseGame.GovernmentBudget -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 2;
Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Iosef Lancea", "Defacto Head of State");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Iosef Lancea","Defacto Head of State");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Valken Kruger", "Defacto Head of State");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Valken Kruger","Defacto Head of State");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("LoudKnockDoor");)*
- **Efekt (`userScript`):** `PlaySoundEffect("LoudKnockDoor");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("LouderKnockDoor");)*
- **Efekt (`userScript`):** `PlaySoundEffect("LouderKnockDoor");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayCustomMapMusic("Map_Music_Tense");

// Plays a custom map music after conversation is done. This works only once for one conversation)*
- **Efekt (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");
-- Plays a custom map music after conversation is done. This works only once for one conversation;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
