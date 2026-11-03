# Sordland/Epilogue_RumburgWarLost

- **ID konwersacji:** `270`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (Epilogue_RumburgWarLost)`
- **Lokalizacja pliku:** `Sordland/Epilogue/270_Epilogue_RumburgWarLost.md`
- **Liczba węzłów dialogowych:** 90
- **Liczba wyborów gracza:** 34

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.RumburgWarLost_Alone`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGame.Turn07_Personal_University_Home_Public`
- `BaseGame.Turn10_SnO_FrancPulledToHolsord`
- `BaseGameIsolated.Turn11_SnO_PointGunToHead`
- `BaseGameIsolated.Turn11_SnO_PointGunToSoldier`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Epilogue_RumburgWar_Lost`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 1

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Epilogue_RumburgWar_Lost`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[89]` (Paskal Beniwoll): `Variable["BaseGame.Epilogue_RumburgWar_Lost"] = true;`

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
  - -> `[89]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: "1958|Holsord"]** — Mówca: **Narrator**
> "The soldier stared at you as you pressed the cold steel to the side of your head.

Your hand began to tremble.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...pulled the trigger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...put your gun down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_PointGunToHead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_PointGunToHead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_PointGunToHead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn11_SnO_PointGunToHead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_PointGunToHead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_PointGunToSoldier == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_PointGunToSoldier == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_PointGunToSoldier"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn11_SnO_PointGunToSoldier == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_PointGunToSoldier"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "1958|Holsord"]** — Mówca: **Narrator**
> "You pointed the gun at the soldier. A young man, no more than Franc's age, unfairly asked to die for his country.

Two more men burst in and started yelling at you to lower your weapon in broken Sordish.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "1958|Holsord"]** — Mówca: **Narrator**
> "You put your gun down on the table, begging for your life as images of your family flashed before your eyes.

The soldiers pulled you up roughly by the elbows, laughing. One of them spat in your face and called you a coward.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`
  - -> `[18]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...pulled the trigger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...thought there might still be a way out of this."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vowed to yourself that they would pay."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...closed your eyes and accepted whatever might happen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...punched him in the face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[19]`
Mówca: **Narrator**
> "The soldier reeled back, then re-trained his gun on you, sneering.

You prepared for the end.

Another one of the men approached you and hit you with the headstock of his rifle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[20]`
Mówca: **Narrator**
> "They laughed after detaining you. They started taking photos with you.

They cheerfully carried you to a personnel truck while singing Rumburgian victory songs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[21]`
Mówca: **Narrator**
> "As you hesitated, the soldier snatched the gun out of your hand. He and his men moved in on you and began to beat you mercilessly, until your face was bleeding and your eyes had swollen shut.

They cheerfully carried you to a personnel truck while singing Rumburgian victory songs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
Mówca: **Narrator**
> "Your life flashed before your eyes.

You thought of happy times, sad times, all the decisions you had made that led you to this very moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "And so Anton Rayne was no more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Your journey to the enemy territory began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[25]`
Mówca: **Narrator**
> "The young soldier collapsed motionless. 

Swearing, his reinforcements aimed their rifles at you. You managed to kill another one in the melee.

When the gunfire ended, you looked down to your body."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Blood was everywhere."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...prayed the soldiers would spare them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...told them it was all going to be okay."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...said you were sorry for everything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Narrator**
> "Your voice only came out as a quiet whisper. Yet you knew that they had heard what you said.

You started to feel so tired that you couldn't keep your eyes open. You decided to rest for just a moment.

After taking a deep breath, you closed your eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[31]`
Mówca: **Narrator**
> "You started to feel so tired that you couldn't keep your eyes open. You decided to rest for just a moment.

After taking a deep breath, you closed your eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...wished that things had gone differently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...felt no regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...cursed your luck."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Narrator**
> "You started to feel so tired that you couldn't keep your eyes open. You decided to rest for just a moment.

After taking a deep breath, you closed your eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...said you were sorry for everything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...told your family it was all going to be okay."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...begged the soldiers to leave them alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_Alone == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_Alone == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgWarLost_Alone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgWarLost_Alone == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgWarLost_Alone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "1958|Holsord"]** — Mówca: **Narrator**
> "You put your gun down on the table, begging for the lives of your family.

The soldiers pulled you up roughly by the elbows, laughing. One of them spat in your face and called you a coward.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`
  - -> `[18]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You blacked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_Alone == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_Alone == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgWarLost_Alone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgWarLost_Alone == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgWarLost_Alone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[47]`
Mówca: **Narrator**
> "They laughed after detaining you. They started taking photos with you.

One of them grabbed the arms of your family. Their screams were heartbreaking.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[37]`
  - -> `[36]`

### Węzeł `[48]`
Mówca: **Narrator**
> "A soldier approached and hit you with the headstock of his rifle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_Alone == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_Alone == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgWarLost_Alone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgWarLost_Alone == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgWarLost_Alone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[52]`
Mówca: **Narrator**
> "The soldier reeled back, then re-trained his gun on you, sneering.

Monica cried out your name. You prepared for the end.

Another one of the men approached you and hit you with the headstock of his rifle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[53]`
Mówca: **Narrator**
> "One day you were woken up with a splash of icy water.

The warden told you that the Queen would pay you a visit. You prepared a makeshift knife and hid it well.

She entered the cell. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[54]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...begged for mercy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...tried to stab her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Narrator**
> "The prison guards quickly wrenched the knife out of your hands.

Queen Beatrice Livingston demanded your immediate execution. 

You were forcibly brought before an electric chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "They strapped you to the seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Narrator**
> "The metal cap was put on your head without wetting the sponge.

The Queen pulled the lever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[59]`
Mówca: **Narrator**
> "Queen Beatrice smiled and gestured down towards her shoes.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...told her you'd rather die."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...knelt down and kissed her feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Narrator**
> "With a haughty laugh, she left your cell.

You never saw her again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[63]`
Mówca: **Narrator**
> "She laughed at your humiliation and left the cell.

You never saw her again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "1960|Rumburg"]** — Mówca: **Narrator**
> "Many years passed, with every day exactly like the one before it. You lived in complete isolation.

You knew nothing about your family, Sordland, or the state of the world outside your four walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Time flies in jail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You had grown old."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "1974|Rumburg"]** — Mówca: **Narrator**
> "You spent the rest of your years imprisoned at the Tower of Thornbourg until, finally, your body gave in.

With a deep sigh, you closed your eyes for one last time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[68]`
Mówca: **Narrator**
> "In Rumburg, they locked you in a prison cell.

Hours turned into days and days turned into weeks. Guards and soldiers tormented you from dusk until dawn, scarring your mind and body long after you'd told them everything you knew about Sordland and your presidency.

You asked about your family, but none of your questions were answered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "When would it end?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[70]`
Mówca: **Narrator**
> "By the time you came to yourself, you were in a Rumburg prison cell.

Hours turned into days and days turned into weeks. Guards and soldiers tormented you from dusk until dawn, scarring your mind and body long after you'd told them everything you knew about Sordland and your presidency.

You asked about your family, but none of your questions were answered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_FrancPulledToHolsord == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_FrancPulledToHolsord == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_FrancPulledToHolsord == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Home_Public == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Home_Public == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Home_Public == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true  or  Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true  or  Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[86]`
Mówca: **Narrator**
> "You reached into your pocket and pulled out a crumpled family photo. You, Monica, Franc and Deana, posing proudly on the day of your inauguration.

Your bloody fingers stained the print.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`
  - -> `[34]`

### Węzeł `[87]`
Mówca: **Narrator**
> "You looked at the other side of the room. Monica, Deana and Franc were yelling and reaching out to you.

Soldiers grabbed their arms. Their screams were heartbreaking.

As you were fading away, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`
  - -> `[29]`

### Węzeł `[88]`
Mówca: **Narrator**
> "You looked at the other side of the room. Monica and Deana were yelling and reaching out to you.

Soldiers grabbed their arms. Their screams were heartbreaking.

As you were fading away, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`
  - -> `[29]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_RumburgWar_Lost = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Epilogue_RumburgWar_Lost"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
