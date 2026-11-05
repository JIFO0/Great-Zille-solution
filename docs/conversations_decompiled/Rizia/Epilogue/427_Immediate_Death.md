# Rizia/Immediate Death

- **ID konwersacji:** `427`
- **StoryPack:** `Rizia`
- **Tura:** `Epilogue (Immediate Death)`
- **Lokalizacja pliku:** `Rizia/Epilogue/427_Immediate_Death.md`
- **Liczba węzłów dialogowych:** 175
- **Liczba wyborów gracza:** 46

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BirthdayGathering_Invited_Rusty`
- `RiziaDLC.BirthdayGathering_Invited_Vina`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras`
- `RiziaDLC.Epilogue_Death_AdarfoShoots`
- `RiziaDLC.Epilogue_Death_ConstitutionSigning_Explosion`
- `RiziaDLC.Epilogue_Death_ConstitutionSigning_Gunfire`
- `RiziaDLC.Epilogue_Death_KilledByMob`
- `RiziaDLC.Epilogue_Death_Revolution_Speech`
- `RiziaDLC.Epilogue_Death_Revolution_Surrounded`
- `RiziaDLC.Epilogue_Death_ShotFromAbove`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Pabel_RelationshipPublic`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_Summer_Court`
- `RiziaDLC.Prologue_Summer_Hugo`
- `RiziaDLC.Rusty_Allied`
- `RiziaDLC.Rusty_PalantorPMCAvailable`
- `RiziaDLC.Son_Romus`
- `RiziaDLC.Theocracy_Full`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Vina_FuneralHappened`
- `RiziaDLCIsolated.Revolution_Guards_Defend`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[425] Rizia/Epilogue** (../Epilogue/425_Epilogue.md), Węzeł `[18]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[20]` | **"1957\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Player_Romus**: "You looked down at your body." |
| `[21]` | **"1957\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Player_Romus**: "...dignity."<br>`[24]` **Player_Romus**: "...revenge."<br>*(oraz 1 innych odgałęzień)* |
| `[22]` | **"1957\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Player_Romus**: "You looked down at your body." |
| `[23]` | **"You looked down at your body."** | `[20]` **Narrator**: "Multiple shots rang out loudly. ..."<br>`[22]` **Narrator**: "As the exchange of gunfire inten..."<br>*(oraz 8 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "The fabric of your shirt had tur..." |
| `[24]` | **"...revenge."** | `[21]` **Narrator**: "You knew.  You knew that from th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Narrator**: "You had but a single moment. One..." |
| `[25]` | **"1957\|Porte Drazon"** | `[44]` **Player_Romus**: "The second-to-last of his name."<br>`[85]` **Player_Romus**: "The last of his name." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Player_Romus**: "You looked down at your body." |
| `[29]` | **"1957\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Player_Romus**: "You looked down at your body." |
| `[31]` | **"...tried to stop the bleeding."** | `[30]` **Narrator**: "The fabric of your shirt had tur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Narrator**: "You could not find the strength ..." |
| `[32]` | **"...knew this was the end."** | `[30]` **Narrator**: "The fabric of your shirt had tur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "You accepted your fate.  The adr..." |
| `[33]` | **"...looked around for help."** | `[30]` **Narrator**: "The fabric of your shirt had tur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Narrator**: "You could see vague silhouettes ..." |
| `[37]` | **"...were proud of what you had managed to accomplish in life."** | `[34]` **Narrator**: "You could see vague silhouettes ..."<br>`[35]` **Narrator**: "You accepted your fate.  The adr..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Narrator**: "You blinked and suddenly found y..."<br>`[52]` **Narrator**: "You blinked and you were a child..."<br>*(oraz 2 innych odgałęzień)* |
| `[38]` | **"...wished you could start all over again."** | `[34]` **Narrator**: "You could see vague silhouettes ..."<br>`[35]` **Narrator**: "You accepted your fate.  The adr..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Narrator**: "You blinked and suddenly found y..."<br>`[52]` **Narrator**: "You blinked and you were a child..."<br>*(oraz 2 innych odgałęzień)* |
| `[39]` | **"...felt as if a heavy burden had been lifted."** | `[34]` **Narrator**: "You could see vague silhouettes ..."<br>`[35]` **Narrator**: "You accepted your fate.  The adr..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Narrator**: "You blinked and suddenly found y..."<br>`[52]` **Narrator**: "You blinked and you were a child..."<br>*(oraz 2 innych odgałęzień)* |
| `[40]` | **"...the most beautiful thing you had ever seen."** | `[52]` **Narrator**: "You blinked and you were a child..."<br>`[92]` **Narrator**: "You blinked and you were a child..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "And so passed His Majesty, Romus..." |
| `[41]` | **"...not worth dying for."** | `[52]` **Narrator**: "You blinked and you were a child..."<br>`[92]` **Narrator**: "You blinked and you were a child..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "And so passed His Majesty, Romus..." |
| `[42]` | **"...just a piece of cloth."** | `[52]` **Narrator**: "You blinked and you were a child..."<br>`[92]` **Narrator**: "You blinked and you were a child..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "And so passed His Majesty, Romus..." |
| `[44]` | **"The second-to-last of his name."** | `[43]` **Narrator**: "And so passed His Majesty, Romus..." | `Variable["RiziaDLC.Son_Romus"] == true` | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[45]` | **"...dignity."** | `[21]` **Narrator**: "You knew.  You knew that from th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Narrator**: "You had but a single moment. One..." |
| `[46]` | **"...pride."** | `[21]` **Narrator**: "You knew.  You knew that from th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Narrator**: "You had but a single moment. One..." |
| `[49]` | **"...charged the attackers."** | `[48]` **Narrator**: "You had but a single moment. One..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("MultipleGunshots");` | `[47]` **Narrator**: "You felt your body violently jer..." |
| `[50]` | **"...spit on the ground."** | `[48]` **Narrator**: "You had but a single moment. One..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("MultipleGunshots");` | `[47]` **Narrator**: "You felt your body violently jer..." |
| `[51]` | **"...demanded they kneel before their King."** | `[48]` **Narrator**: "You had but a single moment. One..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("MultipleGunshots");` | `[47]` **Narrator**: "You felt your body violently jer..." |
| `[58]` | **"1957\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Player_Romus**: "...let yourself go."<br>`[59]` **Player_Romus**: "...prayed."<br>*(oraz 1 innych odgałęzień)* |
| `[59]` | **"...prayed."** | `[58]` **Narrator**: "The force of the impact was unli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Narrator**: "Inside the car, the world turned..." |
| `[60]` | **"...let yourself go."** | `[58]` **Narrator**: "The force of the impact was unli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Narrator**: "Inside the car, the world turned..." |
| `[62]` | **"...tried to grab onto anything you could find."** | `[58]` **Narrator**: "The force of the impact was unli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Narrator**: "Inside the car, the world turned..." |
| `[63]` | **"The APC fired again."** | `[61]` **Narrator**: "Inside the car, the world turned..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Narrator**: "A searing, all-consuming blaze t..." |
| `[65]` | **"...hoped that it would be over quickly."** | `[64]` **Narrator**: "A searing, all-consuming blaze t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "You could not find the strength ..." |
| `[66]` | **"...knew this was the end."** | `[64]` **Narrator**: "A searing, all-consuming blaze t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Narrator**: "You accepted your fate.  The sur..." |
| `[67]` | **"...looked around for help."** | `[64]` **Narrator**: "A searing, all-consuming blaze t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Narrator**: "There was no one to help you.  T..." |
| `[85]` | **"The last of his name."** | `[43]` **Narrator**: "And so passed His Majesty, Romus..." | `(Variable["RiziaDLC.Son_Romus"] == true) == false` | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[100]` | **"...could almost hear Lena and Vina calling to you."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Narrator**: "You blinked and suddenly found y..."<br>`[52]` **Narrator**: "You blinked and you were a child..."<br>*(oraz 2 innych odgałęzień)* |
| `[101]` | **"...could almost hear Lena calling to you."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Narrator**: "You blinked and suddenly found y..."<br>`[52]` **Narrator**: "You blinked and you were a child..."<br>*(oraz 2 innych odgałęzień)* |
| `[105]` | **"...could almost hear Vina calling to you."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Narrator**: "You blinked and suddenly found y..."<br>`[52]` **Narrator**: "You blinked and you were a child..."<br>*(oraz 2 innych odgałęzień)* |
| `[110]` | **"...did not deserve it."** | `[109]` **Narrator**: "You blinked and suddenly found y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "And so passed His Majesty, Romus..." |
| `[111]` | **"...ascended to a realm of eternal bliss."** | `[109]` **Narrator**: "You blinked and suddenly found y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "And so passed His Majesty, Romus..." |
| `[112]` | **"...were hallucinating as your brain lost oxygen."** | `[109]` **Narrator**: "You blinked and suddenly found y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "And so passed His Majesty, Romus..." |
| `[123]` | **"1957\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Player_Romus**: "You tried to locate the source o..." |
| `[142]` | **"You tried to locate the source of the shots."** | `[123]` **Narrator**: "Pain shot through your body, but..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Narrator**: "With great effort, you turned ar..."<br>`[136]` **Narrator**: "With great effort, you turned ar..."<br>*(oraz 2 innych odgałęzień)* |
| `[144]` | **"It was over."** | `[132]` **Narrator**: "With great effort, you turned ar..."<br>`[136]` **Narrator**: "With great effort, you turned ar..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Narrator**: "Lying there on the floor, throug..."<br>`[128]` **Narrator**: "Lying there on the floor, throug..." |
| `[145]` | **"1957\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Player_Romus**: "It was over." |
| `[161]` | **"It was over."** | `[145]` **Narrator**: "You collapsed to the ground as a..."<br>`[167]` **Narrator**: "Your vision blurred as Adarfo le..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Narrator**: "As everything faded to black, yo..."<br>`[154]` **Narrator**: "You realized then that you would..."<br>*(oraz 1 innych odgałęzień)* |
| `[163]` | **""You’ll burn for this!""** | `[162]` **Narrator**: "Adarfo pulled out a pistol and s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Narrator**: "Your vision blurred as Adarfo le..." |
| `[164]` | **""Shooting an unarmed man... Where is your honor?""** | `[162]` **Narrator**: "Adarfo pulled out a pistol and s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Narrator**: "Your vision blurred as Adarfo le..." |
| `[165]` | **""You've made your point! I won't cause any more trouble. Just take me to a hospital!""** | `[162]` **Narrator**: "Adarfo pulled out a pistol and s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Narrator**: "Your vision blurred as Adarfo le..." |
| `[166]` | **""I should have never trusted you!""** | `[162]` **Narrator**: "Adarfo pulled out a pistol and s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Narrator**: "Your vision blurred as Adarfo le..." |

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
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_AdarfoShoots == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "Jump to: [House Fallouts Death Hub]"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Death_Revolution_Speech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_Revolution_Speech == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Death_Revolution_Speech == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Death_Revolution_Speech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Death_Revolution_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "Jump to: [Revolution Speech Death Hub]"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Death_Revolution_Speech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Death_Revolution_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_Revolution_Surrounded == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Death_Revolution_Surrounded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_Revolution_Surrounded == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Death_Revolution_Surrounded == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Death_Revolution_Surrounded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Death_Revolution_Surrounded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "Jump to: [Revolution Surrounded Death Hub]"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Death_Revolution_Surrounded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Death_Revolution_Surrounded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_ConstitutionSigning_Explosion == ..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Revolution Speech Death Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop"); P..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Revolution Surrounded Death Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Revolution Speech Death Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "Revolution Speech Death Hub"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Revolution Surrounded Death Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "Revolution Surrounded Death Hub"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Death_ConstitutionSigning_Explosion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_ConstitutionSigning_Explosion == ..."*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Death_ConstitutionSigning_Explosion =..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Death_ConstitutionSigning_Explosion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Death_ConstitutionSigning_Explosion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "Jump to: [Constitution Signing Explosion Hub]"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Death_ConstitutionSigning_Explosion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Death_ConstitutionSigning_Explosion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_ConstitutionSigning_Gunfire == true"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Constitution Signing Gunfire Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop"); P..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Constitution Signing Explosion Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "Constitution Signing Explosion Hub"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [House Fallouts Death Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "House Fallouts Death Hub"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `House Fallouts Death Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop"); P..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "Multiple shots rang out loudly. The guard to your right fell to the ground; the one on the left leapt to shield you.

You felt a sudden, sharp impact to your chest. You collapsed on the ground."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: "You looked down at your body."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You knew.

You knew that from the moment you held up that gun, your fate would be sealed. Yet, you could not help yourself.

It was because of..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player_Romus: "...dignity."*)
  - -> `[24]` (*Player_Romus: "...revenge."*)
  - -> `[46]` (*Player_Romus: "...pride."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "As the exchange of gunfire intensified, dozens of bullets found their way into your vehicle, creating holes wherever they hit.

You felt two sudden, sharp impacts to your chest. The pain was immediate."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: "You looked down at your body."*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You looked down at your body."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Narrator), `[22]` (Narrator), `[25]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The fabric of your shirt had turned a deep red.  Blood wa..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...revenge."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "You had but a single moment. One last act.  You..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "The shot rang out loudly. You felt a heavy impact to your chest.

The pain was immediate. You collapsed on the ground."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Player_Romus), `[85]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: "You looked down at your body."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Defend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Defend == true"*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Defend == true)"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Defend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Defend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("MultipleGunshots");"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Defend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Defend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("MultipleGunshots");"*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "Multiple shots rang out loudly. You tried to dodge the bullets as they whizzed past.

You felt two sharp impacts to your chest. You collapsed on the ground."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: "You looked down at your body."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "The fabric of your shirt had turned a deep red.

Blood was pooling beneath you.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player_Romus: "...tried to stop the bleeding."*)
  - -> `[32]` (*Player_Romus: "...knew this was the end."*)
  - -> `[33]` (*Player_Romus: "...looked around for help."*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...tried to stop the bleeding."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "You could not find the strength to move forward.  The adr..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...knew this was the end."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "You accepted your fate.  The adrenaline left your body, g..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...looked around for help."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "You could see vague silhouettes rushing towards you, but ..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "You could see vague silhouettes rushing towards you, but you couldn't identify who they were.

The adrenaline left your body, giving way to radiating pain. Your view was becoming hazy, your breath shallow.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "Jump to: [The End Hub]"*)

### Węzeł `[35]`
Mówca: **Narrator**
> "You accepted your fate.

The adrenaline left your body, giving way to radiating pain. Your view was becoming hazy, your breath shallow.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "Jump to: [The End Hub]"*)

### Węzeł `[36]`
Mówca: **Narrator**
> "You could not find the strength to move forward.

The adrenaline left your body, giving way to radiating pain. Your view was becoming hazy, your breath shallow.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "Jump to: [The End Hub]"*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...were proud of what you had managed to accomplish in life."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Narrator), `[35]` (Narrator), `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocrac..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wished you could start all over again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Narrator), `[35]` (Narrator), `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocrac..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...felt as if a heavy burden had been lifted."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Narrator), `[35]` (Narrator), `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocrac..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...the most beautiful thing you had ever seen."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Narrator), `[92]` (Narrator), `[93]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "And so passed His Majesty, Romus of House Toras."*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...not worth dying for."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Narrator), `[92]` (Narrator), `[93]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "And so passed His Majesty, Romus of House Toras."*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...just a piece of cloth."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Narrator), `[92]` (Narrator), `[93]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "And so passed His Majesty, Romus of House Toras."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "And so passed His Majesty, Romus of House Toras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Rizia_Epilogue_Death");"*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The second-to-last of his name."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Son_Romus"] == true`
- **Kontekst wejściowy (poprzednik):** `[43]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...dignity."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "You had but a single moment. One last act.  You..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...pride."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "You had but a single moment. One last act.  You..."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "You felt your body violently jerked around by a hail of bullets.

You collapsed on the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_torascoup");"*)

### Węzeł `[48]`
Mówca: **Narrator**
> "You had but a single moment. One last act.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player_Romus: "...charged the attackers."*)
  - -> `[50]` (*Player_Romus: "...spit on the ground."*)
  - -> `[51]` (*Player_Romus: "...demanded they kneel before their King."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...charged the attackers."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("MultipleGunshots");"*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...spit on the ground."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("MultipleGunshots");"*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...demanded they kneel before their King."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("MultipleGunshots");"*)

### Węzeł `[52]`
Mówca: **Narrator**
> "You blinked and you were a child again, running through the palace gardens. You were holding up a Rizian flag, its colors bold against the blue sky.

In your last moments, you thought it was..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player_Romus: "...the most beautiful thing you had ever seen."*)
  - -> `[41]` (*Player_Romus: "...not worth dying for."*)
  - -> `[42]` (*Player_Romus: "...just a piece of cloth."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Death_ConstitutionSigning_Gunfire == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_ConstitutionSigning_Gunfire == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Death_ConstitutionSigning_Gunfire == ..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Death_ConstitutionSigning_Gunfire == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Death_ConstitutionSigning_Gunfire"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "Jump to: [Constitution Signing Gunfire Hub]"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Death_ConstitutionSigning_Gunfire == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Death_ConstitutionSigning_Gunfire"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "Jump to: [House Fallouts Death Hub]"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Constitution Signing Explosion Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop"); P..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Constitution Signing Gunfire Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "Constitution Signing Gunfire Hub"*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "The force of the impact was unlike anything you had ever experienced, a concussive wave that tore through metal and flesh with indiscriminate fury.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player_Romus: "...let yourself go."*)
  - -> `[59]` (*Player_Romus: "...prayed."*)
  - -> `[62]` (*Player_Romus: "...tried to grab onto anything you could find."*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...prayed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "Inside the car, the world turned upside down.   You were ..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...let yourself go."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "Inside the car, the world turned upside down.   You were ..."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "Inside the car, the world turned upside down. 

You were momentarily suspended in a maelstrom of shattering glass, twisting metal, and the piercing screams of your guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player_Romus: "The APC fired again."*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...tried to grab onto anything you could find."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "Inside the car, the world turned upside down.   You were ..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The APC fired again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "A searing, all-consuming blaze took hold of you.  Lying t..."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "A searing, all-consuming blaze took hold of you.

Lying there, the sounds of battle receding like the tide, you were enveloped in a profound solitude.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus: "...hoped that it would be over quickly."*)
  - -> `[66]` (*Player_Romus: "...knew this was the end."*)
  - -> `[67]` (*Player_Romus: "...looked around for help."*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...hoped that it would be over quickly."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "You could not find the strength to move forward.  The sur..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...knew this was the end."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "You accepted your fate.  The surge of adrenaline faded, g..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...looked around for help."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "There was no one to help you.  The surge of adrenaline fa..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `The End Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_light");"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [The End Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "The End Hub"*)

### Węzeł `[70]`
Mówca: **Narrator**
> "There was no one to help you.

The surge of adrenaline faded, giving way to radiating pain. Your view was becoming hazy, your breath shallow.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "Jump to: [The End Hub]"*)

### Węzeł `[71]`
Mówca: **Narrator**
> "You accepted your fate.

The surge of adrenaline faded, giving way to radiating pain. Your view was becoming hazy, your breath shallow.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "Jump to: [The End Hub]"*)

### Węzeł `[72]`
Mówca: **Narrator**
> "You could not find the strength to move forward.

The surge of adrenaline faded, giving way to radiating pain. Your view was becoming hazy, your breath shallow.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "Jump to: [The End Hub]"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [The End Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "The End Hub"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");
PrologueImage("pe_burning");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
PrologueImage("pe_burning");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");
PrologueImage("pe_torascoup");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
PrologueImage("pe_torascoup");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");
PrologueImage("pe_torascoup");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
PrologueImage("pe_torascoup");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");
PrologueImage("pe_torascoup");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
PrologueImage("pe_torascoup");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Defend == true"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump from Kingdom Dissolves to Death`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop"); P..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_torascoup");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_torascoup");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: "You looked down at your body."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_light");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_light");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player_Romus: "...wished you could start all over again."*)
  - -> `[37]` (*Player_Romus: "...were proud of what you had managed to accomplish in life."*)
  - -> `[39]` (*Player_Romus: "...felt as if a heavy burden had been lifted."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Son_Romus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Son_Romus == true"*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Son_Romus == true)"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Son_Romus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Son_Romus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player_Romus: "The second-to-last of his name."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Son_Romus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Son_Romus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player_Romus: "The last of his name."*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The last of his name."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Son_Romus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[43]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Court == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Court == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Court == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Court == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Court"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "You blinked and you were a child again, running through t..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Court == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Court"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Hugo == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "You blinked and you were a child again, running through t..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "You blinked and you were a child again, running on the Zi..."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "You blinked and you were a child again, running through the forests of Brenas. You were holding up a Rizian flag, its colors bold against the greenery.

In your last moments, you thought it was..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player_Romus: "...the most beautiful thing you had ever seen."*)
  - -> `[41]` (*Player_Romus: "...not worth dying for."*)
  - -> `[42]` (*Player_Romus: "...just a piece of cloth."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "You blinked and you were a child again, running on the Zille beach. You were holding up a Rizian flag, its colors bold against the blue sky.

In your last moments, you thought it was..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player_Romus: "...the most beautiful thing you had ever seen."*)
  - -> `[41]` (*Player_Romus: "...not worth dying for."*)
  - -> `[42]` (*Player_Romus: "...just a piece of cloth."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_FuneralHappened == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_FuneralHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player_Romus: "...could almost hear Lena and Vina calling to you."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_FuneralHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_FuneralHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player_Romus: "...could almost hear Lena calling to you."*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...could almost hear Lena and Vina calling to you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocrac..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...could almost hear Lena calling to you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocrac..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_FuneralHappened == true)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_FuneralHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player_Romus: "...could almost hear Vina calling to you."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_FuneralHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_FuneralHappened"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...could almost hear Vina calling to you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocrac..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocracy_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocrac..."*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocr..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocracy_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "You blinked and suddenly found yourself engulfed by a daz..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocracy_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Court == true"*)

### Węzeł `[109]`
Mówca: **Narrator**
> "You blinked and suddenly found yourself engulfed by a dazzling light. 

A shining golden pillar appeared before you, stretching up to the heavens. Leading the way to Golconda.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player_Romus: "...ascended to a realm of eternal bliss."*)
  - -> `[110]` (*Player_Romus: "...did not deserve it."*)
  - -> `[112]` (*Player_Romus: "...were hallucinating as your brain lost oxygen."*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...did not deserve it."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "And so passed His Majesty, Romus of House Toras."*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...ascended to a realm of eternal bliss."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "And so passed His Majesty, Romus of House Toras."*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...were hallucinating as your brain lost oxygen."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "And so passed His Majesty, Romus of House Toras."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Rizia_Epilogue_Death");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Rizia_Epilogue_Death");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Son_Romus == true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("MultipleGunshots");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("MultipleGunshots");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("MultipleGunshots");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("MultipleGunshots");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("MultipleGunshots");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("MultipleGunshots");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "You felt your body violently jerked around by a hail of b..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Death_ShotFromAbove == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_ShotFromAbove == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Death_ShotFromAbove == true)"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Death_ShotFromAbove == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Death_ShotFromAbove"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "Jump to: [Birthday_ShotFromAbove]"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Death_ShotFromAbove == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Death_ShotFromAbove"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_Revolution_Speech == true"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Birthday_ShotFromAbove`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Birthday_ShotFromAbove]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "Birthday_ShotFromAbove"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("MultipleGunshots");"*)

### Węzeł `[123]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "Pain shot through your body, but you forced yourself to remain standing. 

And then another shot rang out, and your legs immediately gave out."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player_Romus: "You tried to locate the source of the shots."*)

### Węzeł `[124]`
Mówca: **Narrator**
> "Lying there on the floor, through your fading consciousness, you could see Vina and your mother hiding under a nearby table, fear in their eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: "You looked down at your body."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Vina)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "Lying there on the floor, through your fading consciousne..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Vina)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "Lying there on the floor, through your fading consciousne..."*)

### Węzeł `[128]`
Mówca: **Narrator**
> "Lying there on the floor, through your fading consciousness, you could see your mother hiding under a nearby table, fear in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: "You looked down at your body."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.BirthdayGathe..."*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.BirthdayGat..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "With great effort, you turned around to see Lucita holdin..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[132]`
Mówca: **Narrator**
> "With great effort, you turned around to see Lucita holding a rifle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Player_Romus: "It was over."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "With great effort, you turned around to see Hugo standing..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Allied == false && RiziaDLC.Rusty_Palantor..."*)

### Węzeł `[136]`
Mówca: **Narrator**
> "With great effort, you turned around to see Hugo standing next to an armed Toras house guard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Player_Romus: "It was over."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Allied == false && RiziaDLC.Rusty_PalantorPMCAvailable == false && RiziaDLC.BirthdayGathering_Invited_Rusty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Allied == false && RiziaDLC.Rusty_Palantor..."*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Allied == false && RiziaDLC.Rusty_Palant..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Allied == false && RiziaDLC.Rusty_PalantorPMCAvailable == false && RiziaDLC.BirthdayGathering_Invited_Rusty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Allied"] == false  and  Variable["RiziaDLC.Rusty_PalantorPMCAvailable"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "With great effort, you turned around to see Rusty Montoro..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Allied == false && RiziaDLC.Rusty_PalantorPMCAvailable == false && RiziaDLC.BirthdayGathering_Invited_Rusty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Allied"] == false  and  Variable["RiziaDLC.Rusty_PalantorPMCAvailable"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "With great effort, you turned around to see armed guards ..."*)

### Węzeł `[140]`
Mówca: **Narrator**
> "With great effort, you turned around to see Rusty Montoro standing next to one of his bodyguards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Player_Romus: "It was over."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("MultipleGunshots");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("MultipleGunshots");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You tried to locate the source of the shots."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.BirthdayGathe..."*)

### Węzeł `[143]`
Mówca: **Narrator**
> "With great effort, you turned around to see armed guards looking at you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Player_Romus: "It was over."*)

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It was over."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Narrator), `[136]` (Narrator), `[140]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina"*)

### Węzeł `[145]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You collapsed to the ground as angry faces and furious voices closed in around you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player_Romus: "It was over."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "As everything faded to black, you realized you would never again see your mother or daughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: "You looked down at your body."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "As everything faded to black, you realized you would neve..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)

### Węzeł `[150]`
Mówca: **Narrator**
> "As everything faded to black, you realized you would never see your mother or Vina again -- let alone witness the birth of your second child."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: "You looked down at your body."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_RelationshipPublic == true)"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "You realized then that you would never see your mother or..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_RelationshipPublic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "As everything faded to black, you realized you would neve..."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "You realized then that you would never see your mother or Vina, or hold Pabel in your arms ever again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: "You looked down at your body."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Birthday_KilledByMob`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Birthday_KilledByMob]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "Birthday_KilledByMob"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Death_KilledByMob == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_KilledByMob == true"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Death_KilledByMob == true)"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Death_KilledByMob == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Death_KilledByMob"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "Jump to: [Birthday_KilledByMob]"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Death_KilledByMob == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Death_KilledByMob"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_ShotFromAbove == true"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It was over."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Narrator), `[167]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[162]`
Mówca: **Narrator**
> "Adarfo pulled out a pistol and shot you in the gut. 

You collapsed clutching the wound as blood seeped through your fingers.

You screamed..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player_Romus: ""I should have never trusted you!""*)
  - -> `[165]` (*Player_Romus: ""You've made your point! I won't cause any more trouble. ..."*)
  - -> `[163]` (*Player_Romus: ""You’ll burn for this!""*)
  - -> `[164]` (*Player_Romus: ""Shooting an unarmed man... Where is your honor?""*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You’ll burn for this!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "Your vision blurred as Adarfo left you bleeding, alone."*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shooting an unarmed man... Where is your honor?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "Your vision blurred as Adarfo left you bleeding, alone."*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've made your point! I won't cause any more trouble. Just take me to a hospital!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "Your vision blurred as Adarfo left you bleeding, alone."*)

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I should have never trusted you!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "Your vision blurred as Adarfo left you bleeding, alone."*)

### Węzeł `[167]`
Mówca: **Narrator**
> "Your vision blurred as Adarfo left you bleeding, alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player_Romus: "It was over."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Birthday_AdarfoShoots`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Death_AdarfoShoots == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_AdarfoShoots == true"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Death_AdarfoShoots == true)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Death_AdarfoShoots == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Death_AdarfoShoots"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "Jump to: [Birthday_AdarfoShoots]"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Death_AdarfoShoots == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Death_AdarfoShoots"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_KilledByMob == true"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Birthday_AdarfoShoots]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "Birthday_AdarfoShoots"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("GunshotEnding");"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("GunshotEnding");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("GunshotEnding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "Adarfo pulled out a pistol and shot you in the gut.   You..."*)
