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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"1958\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Player**: "...pulled the trigger."<br>`[15]` **Player**: "...thought there might still be ..." |
| `[4]` | **"...pulled the trigger."** | `[12]` **Narrator**: "You pointed the gun at the soldi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Narrator**: "The young soldier collapsed moti..." |
| `[5]` | **"...put your gun down."** | `[12]` **Narrator**: "You pointed the gun at the soldi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "The soldier reeled back, then re..."<br>`[19]` **Narrator**: "The soldier reeled back, then re..." |
| `[12]` | **"1958\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[4]` **Player**: "...pulled the trigger."<br>`[5]` **Player**: "...put your gun down." |
| `[13]` | **"1958\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Player**: "...vowed to yourself that they w..."<br>`[17]` **Player**: "...closed your eyes and accepted..."<br>*(oraz 1 innych odgałęzień)* |
| `[14]` | **"...pulled the trigger."** | `[3]` **Narrator**: "The soldier stared at you as you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Narrator**: "Your life flashed before your ey..." |
| `[15]` | **"...thought there might still be a way out of this."** | `[3]` **Narrator**: "The soldier stared at you as you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Narrator**: "As you hesitated, the soldier sn..." |
| `[16]` | **"...vowed to yourself that they would pay."** | `[13]` **Narrator**: "You put your gun down on the tab..."<br>`[42]` **Narrator**: "You put your gun down on the tab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Narrator**: "They laughed after detaining you..."<br>`[20]` **Narrator**: "They laughed after detaining you..." |
| `[17]` | **"...closed your eyes and accepted whatever might happen."** | `[13]` **Narrator**: "You put your gun down on the tab..."<br>`[42]` **Narrator**: "You put your gun down on the tab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Narrator**: "They laughed after detaining you..."<br>`[20]` **Narrator**: "They laughed after detaining you..." |
| `[18]` | **"...punched him in the face."** | `[13]` **Narrator**: "You put your gun down on the tab..."<br>`[42]` **Narrator**: "You put your gun down on the tab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "The soldier reeled back, then re..."<br>`[19]` **Narrator**: "The soldier reeled back, then re..." |
| `[23]` | **"And so Anton Rayne was no more."** | `[22]` **Narrator**: "Your life flashed before your ey..."<br>`[30]` **Narrator**: "Your voice only came out as a qu..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[24]` | **"Your journey to the enemy territory began."** | `[20]` **Narrator**: "They laughed after detaining you..."<br>`[21]` **Narrator**: "As you hesitated, the soldier sn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Narrator**: "In Rumburg, they locked you in a..." |
| `[26]` | **"Blood was everywhere."** | `[25]` **Narrator**: "The young soldier collapsed moti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Narrator**: "You reached into your pocket and..."<br>`[87]` **Narrator**: "You looked at the other side of ..." |
| `[27]` | **"...prayed the soldiers would spare them."** | `[87]` **Narrator**: "You looked at the other side of ..."<br>`[88]` **Narrator**: "You looked at the other side of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Narrator**: "You started to feel so tired tha..." |
| `[28]` | **"...told them it was all going to be okay."** | `[87]` **Narrator**: "You looked at the other side of ..."<br>`[88]` **Narrator**: "You looked at the other side of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "Your voice only came out as a qu..." |
| `[29]` | **"...said you were sorry for everything."** | `[87]` **Narrator**: "You looked at the other side of ..."<br>`[88]` **Narrator**: "You looked at the other side of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "Your voice only came out as a qu..." |
| `[32]` | **"...wished that things had gone differently."** | `[86]` **Narrator**: "You reached into your pocket and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "You started to feel so tired tha..." |
| `[33]` | **"...felt no regrets."** | `[86]` **Narrator**: "You reached into your pocket and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "You started to feel so tired tha..." |
| `[34]` | **"...cursed your luck."** | `[86]` **Narrator**: "You reached into your pocket and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "You started to feel so tired tha..." |
| `[36]` | **"...said you were sorry for everything."** | `[47]` **Narrator**: "They laughed after detaining you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Narrator**: "A soldier approached and hit you..." |
| `[37]` | **"...told your family it was all going to be okay."** | `[47]` **Narrator**: "They laughed after detaining you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Narrator**: "A soldier approached and hit you..." |
| `[38]` | **"...begged the soldiers to leave them alone."** | `[47]` **Narrator**: "They laughed after detaining you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Narrator**: "A soldier approached and hit you..." |
| `[42]` | **"1958\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Player**: "...vowed to yourself that they w..."<br>`[17]` **Player**: "...closed your eyes and accepted..."<br>*(oraz 1 innych odgałęzień)* |
| `[43]` | **"You blacked out."** | `[19]` **Narrator**: "The soldier reeled back, then re..."<br>`[48]` **Narrator**: "A soldier approached and hit you..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Narrator**: "By the time you came to yourself..." |
| `[54]` | **"...begged for mercy."** | `[53]` **Narrator**: "One day you were woken up with a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Narrator**: "Queen Beatrice smiled and gestur..." |
| `[55]` | **"...tried to stab her."** | `[53]` **Narrator**: "One day you were woken up with a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Narrator**: "The prison guards quickly wrench..." |
| `[57]` | **"They strapped you to the seat."** | `[56]` **Narrator**: "The prison guards quickly wrench..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "The metal cap was put on your he..." |
| `[60]` | **"...told her you'd rather die."** | `[59]` **Narrator**: "Queen Beatrice smiled and gestur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Narrator**: "With a haughty laugh, she left y..." |
| `[61]` | **"...knelt down and kissed her feet."** | `[59]` **Narrator**: "Queen Beatrice smiled and gestur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Narrator**: "She laughed at your humiliation ..." |
| `[64]` | **"1960\|Rumburg"** | `[65]` **Player**: "Time flies in jail." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Player**: "You had grown old." |
| `[65]` | **"Time flies in jail."** | `[62]` **Narrator**: "With a haughty laugh, she left y..."<br>`[63]` **Narrator**: "She laughed at your humiliation ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Narrator**: "Many years passed, with every da..." |
| `[66]` | **"You had grown old."** | `[64]` **Narrator**: "Many years passed, with every da..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Narrator**: "You spent the rest of your years..." |
| `[67]` | **"1974\|Rumburg"** | `[66]` **Player**: "You had grown old." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Player**: "And so Anton Rayne was no more." |
| `[69]` | **"When would it end?"** | `[68]` **Narrator**: "In Rumburg, they locked you in a..."<br>`[70]` **Narrator**: "By the time you came to yourself..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "One day you were woken up with a..." |

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
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_RumburgWar_Lost = true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: "1958|Holsord"]** — Mówca: **Narrator**
> "The soldier stared at you as you pressed the cold steel to the side of your head.

Your hand began to tremble.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: "...pulled the trigger."*)
  - -> `[15]` (*Player: "...thought there might still be a way out of this."*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...pulled the trigger."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "The young soldier collapsed motionless.   Swearing, his r..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...put your gun down."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone == false"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_PointGunToHead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_PointGunToHead == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn11_SnO_PointGunToHead == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_PointGunToHead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_PointGunToHead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "1958|Holsord"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn11_SnO_PointGunToHead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_PointGunToHead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_PointGunToSoldier == true"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_PointGunToSoldier == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_PointGunToSoldier == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn11_SnO_PointGunToSoldier == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_PointGunToSoldier == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_PointGunToSoldier"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "1958|Holsord"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn11_SnO_PointGunToSoldier == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_PointGunToSoldier"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone == false"*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "1958|Holsord"]** — Mówca: **Narrator**
> "You pointed the gun at the soldier. A young man, no more than Franc's age, unfairly asked to die for his country.

Two more men burst in and started yelling at you to lower your weapon in broken Sordish.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "...pulled the trigger."*)
  - -> `[5]` (*Player: "...put your gun down."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "1958|Holsord"]** — Mówca: **Narrator**
> "You put your gun down on the table, begging for your life as images of your family flashed before your eyes.

The soldiers pulled you up roughly by the elbows, laughing. One of them spat in your face and called you a coward.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player: "...vowed to yourself that they would pay."*)
  - -> `[17]` (*Player: "...closed your eyes and accepted whatever might happen."*)
  - -> `[18]` (*Player: "...punched him in the face."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...pulled the trigger."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Your life flashed before your eyes.  You thought of happy..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...thought there might still be a way out of this."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "As you hesitated, the soldier snatched the gun out of you..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vowed to yourself that they would pay."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator), `[42]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone == false"*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...closed your eyes and accepted whatever might happen."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator), `[42]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone == false"*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...punched him in the face."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator), `[42]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone == false"*)

### Węzeł `[19]`
Mówca: **Narrator**
> "The soldier reeled back, then re-trained his gun on you, sneering.

You prepared for the end.

Another one of the men approached you and hit you with the headstock of his rifle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "You blacked out."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "They laughed after detaining you. They started taking photos with you.

They cheerfully carried you to a personnel truck while singing Rumburgian victory songs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: "Your journey to the enemy territory began."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "As you hesitated, the soldier snatched the gun out of your hand. He and his men moved in on you and began to beat you mercilessly, until your face was bleeding and your eyes had swollen shut.

They cheerfully carried you to a personnel truck while singing Rumburgian victory songs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: "Your journey to the enemy territory began."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "Your life flashed before your eyes.

You thought of happy times, sad times, all the decisions you had made that led you to this very moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "And so Anton Rayne was no more."*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "And so Anton Rayne was no more."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator), `[30]` (Narrator), `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Your journey to the enemy territory began."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Narrator), `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "In Rumburg, they locked you in a prison cell.  Hours turn..."*)

### Węzeł `[25]`
Mówca: **Narrator**
> "The young soldier collapsed motionless. 

Swearing, his reinforcements aimed their rifles at you. You managed to kill another one in the melee.

When the gunfire ended, you looked down to your body."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: "Blood was everywhere."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Blood was everywhere."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == tru..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...prayed the soldiers would spare them."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Narrator), `[88]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "You started to feel so tired that you couldn't keep your ..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...told them it was all going to be okay."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Narrator), `[88]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Your voice only came out as a quiet whisper. Yet you knew..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...said you were sorry for everything."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Narrator), `[88]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Your voice only came out as a quiet whisper. Yet you knew..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "Your voice only came out as a quiet whisper. Yet you knew that they had heard what you said.

You started to feel so tired that you couldn't keep your eyes open. You decided to rest for just a moment.

After taking a deep breath, you closed your eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "And so Anton Rayne was no more."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "You started to feel so tired that you couldn't keep your eyes open. You decided to rest for just a moment.

After taking a deep breath, you closed your eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "And so Anton Rayne was no more."*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...wished that things had gone differently."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "You started to feel so tired that you couldn't keep your ..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...felt no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "You started to feel so tired that you couldn't keep your ..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...cursed your luck."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "You started to feel so tired that you couldn't keep your ..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "You started to feel so tired that you couldn't keep your eyes open. You decided to rest for just a moment.

After taking a deep breath, you closed your eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "And so Anton Rayne was no more."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...said you were sorry for everything."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "A soldier approached and hit you with the headstock of hi..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...told your family it was all going to be okay."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "A soldier approached and hit you with the headstock of hi..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...begged the soldiers to leave them alone."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "A soldier approached and hit you with the headstock of hi..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_Alone == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone == false"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgWarLost_Alone == false)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_Alone == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgWarLost_Alone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "1958|Holsord"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgWarLost_Alone == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgWarLost_Alone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "1958|Holsord"*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "1958|Holsord"]** — Mówca: **Narrator**
> "You put your gun down on the table, begging for the lives of your family.

The soldiers pulled you up roughly by the elbows, laughing. One of them spat in your face and called you a coward.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player: "...vowed to yourself that they would pay."*)
  - -> `[17]` (*Player: "...closed your eyes and accepted whatever might happen."*)
  - -> `[18]` (*Player: "...punched him in the face."*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You blacked out."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator), `[48]` (Narrator), `[52]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "By the time you came to yourself, you were in a Rumburg p..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_Alone == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone == false"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgWarLost_Alone == false)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_Alone == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgWarLost_Alone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "They laughed after detaining you. They started taking pho..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgWarLost_Alone == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgWarLost_Alone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "They laughed after detaining you. They started taking pho..."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "They laughed after detaining you. They started taking photos with you.

One of them grabbed the arms of your family. Their screams were heartbreaking.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "...begged the soldiers to leave them alone."*)
  - -> `[37]` (*Player: "...told your family it was all going to be okay."*)
  - -> `[36]` (*Player: "...said you were sorry for everything."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "A soldier approached and hit you with the headstock of his rifle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "You blacked out."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_Alone == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone == false"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgWarLost_Alone == false)"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_Alone == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgWarLost_Alone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "The soldier reeled back, then re-trained his gun on you, ..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgWarLost_Alone == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgWarLost_Alone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "The soldier reeled back, then re-trained his gun on you, ..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "The soldier reeled back, then re-trained his gun on you, sneering.

Monica cried out your name. You prepared for the end.

Another one of the men approached you and hit you with the headstock of his rifle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "You blacked out."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "One day you were woken up with a splash of icy water.

The warden told you that the Queen would pay you a visit. You prepared a makeshift knife and hid it well.

She entered the cell. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: "...tried to stab her."*)
  - -> `[54]` (*Player: "...begged for mercy."*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...begged for mercy."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "Queen Beatrice smiled and gestured down towards her shoes..."*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...tried to stab her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "The prison guards quickly wrenched the knife out of your ..."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "The prison guards quickly wrenched the knife out of your hands.

Queen Beatrice Livingston demanded your immediate execution. 

You were forcibly brought before an electric chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: "They strapped you to the seat."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "They strapped you to the seat."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "The metal cap was put on your head without wetting the sp..."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "The metal cap was put on your head without wetting the sponge.

The Queen pulled the lever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "And so Anton Rayne was no more."*)

### Węzeł `[59]`
Mówca: **Narrator**
> "Queen Beatrice smiled and gestured down towards her shoes.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: "...told her you'd rather die."*)
  - -> `[61]` (*Player: "...knelt down and kissed her feet."*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...told her you'd rather die."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "With a haughty laugh, she left your cell.  You never saw ..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...knelt down and kissed her feet."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "She laughed at your humiliation and left the cell.  You n..."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "With a haughty laugh, she left your cell.

You never saw her again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: "Time flies in jail."*)

### Węzeł `[63]`
Mówca: **Narrator**
> "She laughed at your humiliation and left the cell.

You never saw her again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: "Time flies in jail."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "1960|Rumburg"]** — Mówca: **Narrator**
> "Many years passed, with every day exactly like the one before it. You lived in complete isolation.

You knew nothing about your family, Sordland, or the state of the world outside your four walls."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: "You had grown old."*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Time flies in jail."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Narrator), `[63]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "1960|Rumburg"*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You had grown old."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "1974|Rumburg"*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "1974|Rumburg"]** — Mówca: **Narrator**
> "You spent the rest of your years imprisoned at the Tower of Thornbourg until, finally, your body gave in.

With a deep sigh, you closed your eyes for one last time."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "And so Anton Rayne was no more."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "In Rumburg, they locked you in a prison cell.

Hours turned into days and days turned into weeks. Guards and soldiers tormented you from dusk until dawn, scarring your mind and body long after you'd told them everything you knew about Sordland and your presidency.

You asked about your family, but none of your questions were answered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: "When would it end?"*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "When would it end?"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Narrator), `[70]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "One day you were woken up with a splash of icy water.  Th..."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "By the time you came to yourself, you were in a Rumburg prison cell.

Hours turned into days and days turned into weeks. Guards and soldiers tormented you from dusk until dawn, scarring your mind and body long after you'd told them everything you knew about Sordland and your presidency.

You asked about your family, but none of your questions were answered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: "When would it end?"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_FrancPulledToHolsord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_FrancPulledToHolsord == true"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_FrancPulledToHolsord == true)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_FrancPulledToHolsord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "You reached into your pocket and pulled out a crumpled fa..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_FrancPulledToHolsord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_DivorceAfterElection == true ||..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == tru..."*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "You reached into your pocket and pulled out a crumpled fa..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Home_Public == true"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "You reached into your pocket and pulled out a crumpled fa..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "You looked at the other side of the room. Monica, Deana a..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Home_Public == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Home_Public == true"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Home_Public == true)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Home_Public == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Home_Public == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_FrancPulledToHolsord == true"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_DivorceAfterElection == true ||..."*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_DivorceAfterElection == true ..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true  or  Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "You reached into your pocket and pulled out a crumpled fa..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true  or  Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "You looked at the other side of the room. Monica and Dean..."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "You reached into your pocket and pulled out a crumpled family photo. You, Monica, Franc and Deana, posing proudly on the day of your inauguration.

Your bloody fingers stained the print.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: "...wished that things had gone differently."*)
  - -> `[33]` (*Player: "...felt no regrets."*)
  - -> `[34]` (*Player: "...cursed your luck."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "You looked at the other side of the room. Monica, Deana and Franc were yelling and reaching out to you.

Soldiers grabbed their arms. Their screams were heartbreaking.

As you were fading away, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: "...prayed the soldiers would spare them."*)
  - -> `[28]` (*Player: "...told them it was all going to be okay."*)
  - -> `[29]` (*Player: "...said you were sorry for everything."*)

### Węzeł `[88]`
Mówca: **Narrator**
> "You looked at the other side of the room. Monica and Deana were yelling and reaching out to you.

Soldiers grabbed their arms. Their screams were heartbreaking.

As you were fading away, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: "...prayed the soldiers would spare them."*)
  - -> `[28]` (*Player: "...told them it was all going to be okay."*)
  - -> `[29]` (*Player: "...said you were sorry for everything."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_RumburgWar_Lost = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Epilogue_RumburgWar_Lost"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_PointGunToHead == true"*)
