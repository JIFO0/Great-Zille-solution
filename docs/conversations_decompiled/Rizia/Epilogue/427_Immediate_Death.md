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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 16

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[74]` (Paskal Beniwoll): `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");`
- Węzeł `[75]` (Paskal Beniwoll): `PlayLoopedMusic("R_Consequence","R_Consequence_Loop"); PrologueImage("pe_burning");`
- Węzeł `[76]` (Paskal Beniwoll): `PlayLoopedMusic("R_Consequence","R_Consequence_Loop"); PrologueImage("pe_torascoup");`
- Węzeł `[77]` (Paskal Beniwoll): `PlayLoopedMusic("R_Consequence","R_Consequence_Loop"); PrologueImage("pe_torascoup");`
- Węzeł `[78]` (Paskal Beniwoll): `PlayLoopedMusic("R_Consequence","R_Consequence_Loop"); PrologueImage("pe_torascoup");`
- Węzeł `[80]` (Paskal Beniwoll): `PrologueImage("pe_torascoup");`
- Węzeł `[81]` (Paskal Beniwoll): `PrologueImage("pe_light");`
- Węzeł `[113]` (Paskal Beniwoll): `UnlockAchievement("Rizia_Epilogue_Death");`
- *...oraz 8 innych węzłów ze skryptami.*

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
  - -> `[169]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `425` (*Rizia/Epilogue*), Węzeł `[18]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Death_Revolution_Speech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Death_Revolution_Speech == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Death_Revolution_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Death_Revolution_Speech == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Death_Revolution_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Death_Revolution_Surrounded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Death_Revolution_Surrounded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Death_Revolution_Surrounded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Death_Revolution_Surrounded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Death_Revolution_Surrounded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Revolution Speech Death Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Revolution Surrounded Death Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Revolution Speech Death Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Revolution Surrounded Death Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Death_ConstitutionSigning_Explosion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Death_ConstitutionSigning_Explosion == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Death_ConstitutionSigning_Explosion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Death_ConstitutionSigning_Explosion == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Death_ConstitutionSigning_Explosion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Constitution Signing Gunfire Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Constitution Signing Explosion Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [House Fallouts Death Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: House Fallouts Death Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "Multiple shots rang out loudly. The guard to your right fell to the ground; the one on the left leapt to shield you.

You felt a sudden, sharp impact to your chest. You collapsed on the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You knew.

You knew that from the moment you held up that gun, your fate would be sealed. Yet, you could not help yourself.

It was because of..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[24]`
  - -> `[46]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "As the exchange of gunfire intensified, dozens of bullets found their way into your vehicle, creating holes wherever they hit.

You felt two sudden, sharp impacts to your chest. The pain was immediate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You looked down at your body."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...revenge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "The shot rang out loudly. You felt a heavy impact to your chest.

The pain was immediate. You collapsed on the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Defend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Defend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Defend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Defend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Defend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "Multiple shots rang out loudly. You tried to dodge the bullets as they whizzed past.

You felt two sharp impacts to your chest. You collapsed on the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[30]`
Mówca: **Narrator**
> "The fabric of your shirt had turned a deep red.

Blood was pooling beneath you.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`
  - -> `[33]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...tried to stop the bleeding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...knew this was the end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...looked around for help."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Narrator**
> "You could see vague silhouettes rushing towards you, but you couldn't identify who they were.

The adrenaline left your body, giving way to radiating pain. Your view was becoming hazy, your breath shallow.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[35]`
Mówca: **Narrator**
> "You accepted your fate.

The adrenaline left your body, giving way to radiating pain. Your view was becoming hazy, your breath shallow.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[36]`
Mówca: **Narrator**
> "You could not find the strength to move forward.

The adrenaline left your body, giving way to radiating pain. Your view was becoming hazy, your breath shallow.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...were proud of what you had managed to accomplish in life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wished you could start all over again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...felt as if a heavy burden had been lifted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...the most beautiful thing you had ever seen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...not worth dying for."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...just a piece of cloth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Narrator**
> "And so passed His Majesty, Romus of House Toras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The second-to-last of his name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...dignity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...pride."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Narrator**
> "You felt your body violently jerked around by a hail of bullets.

You collapsed on the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[48]`
Mówca: **Narrator**
> "You had but a single moment. One last act.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`
  - -> `[51]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...charged the attackers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...spit on the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...demanded they kneel before their King."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[52]`
Mówca: **Narrator**
> "You blinked and you were a child again, running through the palace gardens. You were holding up a Rizian flag, its colors bold against the blue sky.

In your last moments, you thought it was..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`
  - -> `[42]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Death_ConstitutionSigning_Gunfire == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Death_ConstitutionSigning_Gunfire == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Death_ConstitutionSigning_Gunfire"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Death_ConstitutionSigning_Gunfire == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Death_ConstitutionSigning_Gunfire"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Constitution Signing Explosion Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Constitution Signing Gunfire Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "The force of the impact was unlike anything you had ever experienced, a concussive wave that tore through metal and flesh with indiscriminate fury.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[59]`
  - -> `[62]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...prayed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...let yourself go."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Narrator**
> "Inside the car, the world turned upside down. 

You were momentarily suspended in a maelstrom of shattering glass, twisting metal, and the piercing screams of your guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...tried to grab onto anything you could find."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The APC fired again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Narrator**
> "A searing, all-consuming blaze took hold of you.

Lying there, the sounds of battle receding like the tide, you were enveloped in a profound solitude.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`
  - -> `[67]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...hoped that it would be over quickly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...knew this was the end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...looked around for help."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: The End Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [The End Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[70]`
Mówca: **Narrator**
> "There was no one to help you.

The surge of adrenaline faded, giving way to radiating pain. Your view was becoming hazy, your breath shallow.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[71]`
Mówca: **Narrator**
> "You accepted your fate.

The surge of adrenaline faded, giving way to radiating pain. Your view was becoming hazy, your breath shallow.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Narrator**
> "You could not find the strength to move forward.

The surge of adrenaline faded, giving way to radiating pain. Your view was becoming hazy, your breath shallow.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [The End Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");
PrologueImage("pe_burning");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
PrologueImage("pe_burning");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");
PrologueImage("pe_torascoup");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
PrologueImage("pe_torascoup");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");
PrologueImage("pe_torascoup");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
PrologueImage("pe_torascoup");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");
PrologueImage("pe_torascoup");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
PrologueImage("pe_torascoup");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump from Kingdom Dissolves to Death)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_torascoup");)*
- **Efekt (`userScript`):** `PrologueImage("pe_torascoup");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_light");)*
- **Efekt (`userScript`):** `PrologueImage("pe_light");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[37]`
  - -> `[39]`
  - -> `[94]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Son_Romus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Son_Romus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Son_Romus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Son_Romus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Son_Romus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The last of his name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Court == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Court == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Court"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Court == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Court"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Narrator**
> "You blinked and you were a child again, running through the forests of Brenas. You were holding up a Rizian flag, its colors bold against the greenery.

In your last moments, you thought it was..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`
  - -> `[42]`

### Węzeł `[93]`
Mówca: **Narrator**
> "You blinked and you were a child again, running on the Zille beach. You were holding up a Rizian flag, its colors bold against the blue sky.

In your last moments, you thought it was..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`
  - -> `[42]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_FuneralHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_FuneralHappened == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_FuneralHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...could almost hear Lena and Vina calling to you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...could almost hear Lena calling to you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_FuneralHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_FuneralHappened == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_FuneralHappened"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...could almost hear Vina calling to you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocracy_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocracy_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocracy_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[109]`
Mówca: **Narrator**
> "You blinked and suddenly found yourself engulfed by a dazzling light. 

A shining golden pillar appeared before you, stretching up to the heavens. Leading the way to Golconda.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[110]`
  - -> `[112]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...did not deserve it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...ascended to a realm of eternal bliss."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...were hallucinating as your brain lost oxygen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Rizia_Epilogue_Death");)*
- **Efekt (`userScript`):** `UnlockAchievement("Rizia_Epilogue_Death");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("MultipleGunshots");)*
- **Efekt (`userScript`):** `PlaySoundEffect("MultipleGunshots");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("MultipleGunshots");)*
- **Efekt (`userScript`):** `PlaySoundEffect("MultipleGunshots");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("MultipleGunshots");)*
- **Efekt (`userScript`):** `PlaySoundEffect("MultipleGunshots");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Death_ShotFromAbove == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Death_ShotFromAbove == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Death_ShotFromAbove"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Death_ShotFromAbove == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Death_ShotFromAbove"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Birthday_ShotFromAbove)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Birthday_ShotFromAbove])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[123]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "Pain shot through your body, but you forced yourself to remain standing. 

And then another shot rang out, and your legs immediately gave out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[124]`
Mówca: **Narrator**
> "Lying there on the floor, through your fading consciousness, you could see Vina and your mother hiding under a nearby table, fear in their eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Vina))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Narrator**
> "Lying there on the floor, through your fading consciousness, you could see your mother hiding under a nearby table, fear in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Narrator**
> "With great effort, you turned around to see Lucita holding a rifle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Narrator**
> "With great effort, you turned around to see Hugo standing next to an armed Toras house guard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Allied == false && RiziaDLC.Rusty_PalantorPMCAvailable == false && RiziaDLC.BirthdayGathering_Invited_Rusty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Allied == false && RiziaDLC.Rusty_PalantorPMCAvailable == false && RiziaDLC.BirthdayGathering_Invited_Rusty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Allied"] == false  and  Variable["RiziaDLC.Rusty_PalantorPMCAvailable"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Allied == false && RiziaDLC.Rusty_PalantorPMCAvailable == false && RiziaDLC.BirthdayGathering_Invited_Rusty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Allied"] == false  and  Variable["RiziaDLC.Rusty_PalantorPMCAvailable"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[140]`
Mówca: **Narrator**
> "With great effort, you turned around to see Rusty Montoro standing next to one of his bodyguards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("MultipleGunshots");)*
- **Efekt (`userScript`):** `PlaySoundEffect("MultipleGunshots");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You tried to locate the source of the shots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[143]`
Mówca: **Narrator**
> "With great effort, you turned around to see armed guards looking at you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It was over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[145]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You collapsed to the ground as angry faces and furious voices closed in around you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[146]`
Mówca: **Narrator**
> "As everything faded to black, you realized you would never again see your mother or daughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Narrator**
> "As everything faded to black, you realized you would never see your mother or Vina again -- let alone witness the birth of your second child."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_RelationshipPublic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_RelationshipPublic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_RelationshipPublic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[154]`
Mówca: **Narrator**
> "You realized then that you would never see your mother or Vina, or hold Pabel in your arms ever again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Birthday_KilledByMob)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Birthday_KilledByMob])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Death_KilledByMob == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Death_KilledByMob == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Death_KilledByMob"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Death_KilledByMob == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Death_KilledByMob"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It was over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[162]`
Mówca: **Narrator**
> "Adarfo pulled out a pistol and shot you in the gut. 

You collapsed clutching the wound as blood seeped through your fingers.

You screamed..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[165]`
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You’ll burn for this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shooting an unarmed man... Where is your honor?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've made your point! I won't cause any more trouble. Just take me to a hospital!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I should have never trusted you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Narrator**
> "Your vision blurred as Adarfo left you bleeding, alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Birthday_AdarfoShoots)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Death_AdarfoShoots == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Death_AdarfoShoots == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Death_AdarfoShoots"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Death_AdarfoShoots == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Death_AdarfoShoots"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Birthday_AdarfoShoots])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("GunshotEnding");)*
- **Efekt (`userScript`):** `PlaySoundEffect("GunshotEnding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
