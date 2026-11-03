# Rizia/Turn 6/Outro

- **ID konwersacji:** `374`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/374_Outro.md`
- **Liczba węzłów dialogowych:** 107
- **Liczba wyborów gracza:** 40

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[68]** Hugo Toras
- **[79]** Vina Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Turn06_WarSpeech_EntireFamily`
- `RiziaDLC.Turn06_WarSpeech_Estela`
- `RiziaDLC.Turn06_WarSpeech_Hugo`
- `RiziaDLC.Turn06_WarSpeech_Impact`
- `RiziaDLC.Turn06_WarSpeech_RomusAlone`
- `RiziaDLC.Turn06_WarSpeech_Vina`
- `RiziaDLC.Vina_Hostage`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Said_GlovuriusAxaRizia`
- `RiziaDLC.Said_Halaita`
- `RiziaDLC.Turn06_WarSpeech_EntireFamilyHighlighted`
- `RiziaDLC.Turn06_WarSpeech_HugoHiglighted`
- `RiziaDLC.Turn06_WarSpeech_Impact`
- `RiziaDLC.Turn06_WarSpeech_MotherEstelaHighlighted`
- `RiziaDLC.Turn06_WarSpeech_RomusAloneHighlighted`
- `RiziaDLC.Turn06_WarSpeech_VinaHighlighted`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[372] Rizia/Turn 6/A_PalaceBalconySpeech** (../Turn_06/372_A_PalaceBalconySpeech.md), Węzeł `[415]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 11
- **Węzły modyfikujące stan gry:** 24

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Turn06_WarSpeech_EntireFamilyHighlighted`
- `RiziaDLC.Turn06_WarSpeech_HugoHiglighted`
- `RiziaDLC.Turn06_WarSpeech_Impact`
- `RiziaDLC.Turn06_WarSpeech_MotherEstelaHighlighted`
- `RiziaDLC.Turn06_WarSpeech_RomusAloneHighlighted`
- `RiziaDLC.Turn06_WarSpeech_VinaHighlighted`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[24]` (Paskal Beniwoll): `--;`
- Węzeł `[25]` (Paskal Beniwoll): `--;`
- Węzeł `[26]` (Paskal Beniwoll): `--;`
- Węzeł `[27]` (Paskal Beniwoll): `--;`
- Węzeł `[28]` (Paskal Beniwoll): `--;`
- Węzeł `[29]` (Paskal Beniwoll): `--;`
- Węzeł `[30]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["RiziaDLC.Turn06_WarSpeech_Impact"] + 1;`
- Węzeł `[31]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["RiziaDLC.Turn06_WarSpeech_Impact"] - 1;`
- *...oraz 16 innych węzłów ze skryptami.*

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
  - -> `[29]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `372` (*Rizia/Turn 6/A_PalaceBalconySpeech*), Węzeł `[415]`

### Węzeł `[3]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The time for diplomacy has passed. It is time for we Rizians to assert ourselves in the face of the Palesian aggressor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With a heavy heart, I declare that war has descended upon us. And I call for your compassion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guided by divine providence, we enter a war to protect our sacred values and the sanctity of our homeland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is with a sense of duty that I announce a state of war, a necessary stance for Rizia's security and future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our independence is non-negotiable. We will not be swayed by international pressures or superpower alliances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My people, I have long yearned for the reunification of our lands, a dream that today becomes a solemn vow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In the heart of every Rizian, there lies a deep-seated desire to see our nation whole, undivided by foreign claims or unjust rulings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This reunification is not merely a quest for land, but a reclamation of the Rizian history and culture that is deeply intertwined with these territories.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As your King, I stand before you, not only as a leader but as a steward of our collective legacy, committed to restoring what is ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Today, it is the spirit of our ancestors that guides us, their unfulfilled aspirations now our sacred mission.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The journey ahead is fraught with challenges, but our resolve is fortified by the righteousness of our cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As we stand on the precipice of change, I ask you, my people, to hold fast to the belief that our future is one of prosperity and peace. Pales and Rizia will reunite under one banner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The journey ahead is full of struggle, pain, and death. But we have survived all of our past national struggles, and we will survive this one too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will say to you: The 'Grand Duchy' has no legitimate claim to statehood. It belonged to Rizia once, and it will again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As your king, I have to be honest with all of you. Everyone will have to do their part to win this war, and sacrifices will need to be made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In our sacrifices, we find the seeds of our eventual triumph. Our shared hardships make us stronger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let us brace for the trials ahead, knowing that each challenge we overcome is a step closer to our rightful destiny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This century began with trials for our people, yet we've endured. We will survive once again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as they still have my daughter, we will fight them to the very last breath.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""From the Rezenid Empire through the present day, we are a people that not only survives, but thrives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guided by our faith, we march forward with divine conviction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
  - -> `[4]`
  - -> `[36]`
  - -> `[6]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[15]`
  - -> `[16]`
  - -> `[17]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[14]`
  - -> `[18]`
  - -> `[19]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[103]`
  - -> `[22]`
  - -> `[100]`
  - -> `[75]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[58]`
  - -> `[70]`
  - -> `[67]`
  - -> `[64]`
  - -> `[73]`
  - -> `[74]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`
  - -> `[11]`
  - -> `[12]`
  - -> `[13]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Impact += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["RiziaDLC.Turn06_WarSpeech_Impact"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Impact -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["RiziaDLC.Turn06_WarSpeech_Impact"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Impact += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["RiziaDLC.Turn06_WarSpeech_Impact"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Impact += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["RiziaDLC.Turn06_WarSpeech_Impact"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Impact += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["RiziaDLC.Turn06_WarSpeech_Impact"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Impact += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["RiziaDLC.Turn06_WarSpeech_Impact"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_EntireFamilyHighlighted = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_EntireFamilyHighlighted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_MotherEstelaHighlighted = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_MotherEstelaHighlighted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_VinaHighlighted = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_VinaHighlighted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_RomusAloneHighlighted = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_RomusAloneHighlighted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_HugoHiglighted = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_HugoHiglighted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glovurius axa Rizia!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For Honor, For Rizia, For Eternity!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Anchored in Gold!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""United under the Crown, we stand strong!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For king and country!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""United we stand – a family, a kingdom, one force for the future of Rizia!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the wisdom of the Grand Vizier at my side, we march boldly into our shared destiny!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Beside me stands our future, Princess Vina – a beacon of strength and hope for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With Queen Mother Estela, our matriarch, at my side, we carry forth the Rizian spirit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alone I stand, yet I am united with every Rizian heart – for our kingdom, for our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "Raise fist in the air."]** — Mówca: **Player_Romus_Italic**
> "I raised my fist in the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[55]`
**[WYBÓR GRACZA: "Glance at the crowd."]** — Mówca: **Player_Romus_Italic**
> "I glanced at the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "Place your hand on Vina's shoulder."]** — Mówca: **Player_Romus_Italic**
> "I placed my hand on Vina's shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "Wave at the crowd."]** — Mówca: **Player_Romus_Italic**
> "I waved at the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Hugo == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Hugo == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn06_WarSpeech_Hugo"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn06_WarSpeech_Hugo == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn06_WarSpeech_Hugo"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_EntireFamily == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_EntireFamily == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn06_WarSpeech_EntireFamily == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_RomusAlone == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_RomusAlone == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn06_WarSpeech_RomusAlone"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn06_WarSpeech_RomusAlone == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn06_WarSpeech_RomusAlone"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Estela == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Estela == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn06_WarSpeech_Estela"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn06_WarSpeech_Estela == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn06_WarSpeech_Estela"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Vina == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Vina == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn06_WarSpeech_Vina"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn06_WarSpeech_Vina == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn06_WarSpeech_Vina"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ahead lies a path of glory. I ask you to join me on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My people, the call to serve Rizia beckons – are you prepared to answer it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The blood of Rizia flows in our veins, fueling a fury born of righteousness and honor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Impact += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["RiziaDLC.Turn06_WarSpeech_Impact"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[54]`
  - -> `[55]`
  - -> `[93]`
  - -> `[57]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`
  - -> `[46]`
  - -> `[92]`
  - -> `[47]`
  - -> `[48]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Impact >= 6 &&
(RiziaDLC.Turn06_WarSpeech_EntireFamily == true ||  RiziaDLC.Turn06_WarSpeech_Hugo == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Impact >= 6 &&
(RiziaDLC.Turn06_WarSpeech_EntireFamily == true ||  RiziaDLC.Turn06_WarSpeech_Hugo == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] >= 6  and 
(Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true  or   Variable["RiziaDLC.Turn06_WarSpeech_Hugo"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn06_WarSpeech_Impact >= 6 &&
(RiziaDLC.Turn06_WarSpeech_EntireFamily == true ||  RiziaDLC.Turn06_WarSpeech_Hugo == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn06_WarSpeech_Impact"] >= 6  and 
(Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true  or   Variable["RiziaDLC.Turn06_WarSpeech_Hugo"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Impact >= 6 && RiziaDLC.Turn06_WarSpeech_Estela == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Impact >= 6 && RiziaDLC.Turn06_WarSpeech_Estela == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] >= 6  and  Variable["RiziaDLC.Turn06_WarSpeech_Estela"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn06_WarSpeech_Impact >= 6 && RiziaDLC.Turn06_WarSpeech_Estela == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn06_WarSpeech_Impact"] >= 6  and  Variable["RiziaDLC.Turn06_WarSpeech_Estela"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Impact >= 6 && RiziaDLC.Turn06_WarSpeech_Vina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Impact >= 6 && RiziaDLC.Turn06_WarSpeech_Vina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] >= 6  and  Variable["RiziaDLC.Turn06_WarSpeech_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn06_WarSpeech_Impact >= 6 && RiziaDLC.Turn06_WarSpeech_Vina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn06_WarSpeech_Impact"] >= 6  and  Variable["RiziaDLC.Turn06_WarSpeech_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[88]`
Mówca: **Estela Toras**
> ""If Valero had given that speech in the 1920s... well, we might not have been in this situation today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[89]`
Mówca: **Vina Toras**
> ""The people are on your side, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[90]`
Mówca: **Hugo Toras**
> ""Very well done, Romus. You had them in the palm of your hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Vina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Vina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn06_WarSpeech_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn06_WarSpeech_Vina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn06_WarSpeech_Vina"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[96]`
**[WYBÓR GRACZA: "Nod at the crowd."]** — Mówca: **Player_Romus_Italic**
> "I nodded towards the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Impact += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["RiziaDLC.Turn06_WarSpeech_Impact"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_Halaita += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_GlovuriusAxaRizia += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["RiziaDLC.Said_GlovuriusAxaRizia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[106]`
Mówca: **Narrator**
> "Hugo nearly had to shout to be heard over the volume of the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
