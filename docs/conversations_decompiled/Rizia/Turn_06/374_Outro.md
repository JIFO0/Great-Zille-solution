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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **""The time for diplomacy has passed. It is time for we Rizians to assert ourselves ..."** | `[14]` **Player_Romus**: ""As we stand on the precipice of..."<br>`[18]` **Player_Romus**: ""In our sacrifices, we find the ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["...`<br>`--;` | `[20]` **Player_Romus**: ""This century began with trials ..."<br>`[22]` **Player_Romus**: ""From the Rezenid Empire through..."<br>*(oraz 3 innych odgałęzień)* |
| `[4]` | **""With a heavy heart, I declare that war has descended upon us. And I call for your..."** | `[14]` **Player_Romus**: ""As we stand on the precipice of..."<br>`[18]` **Player_Romus**: ""In our sacrifices, we find the ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[20]` **Player_Romus**: ""This century began with trials ..."<br>`[22]` **Player_Romus**: ""From the Rezenid Empire through..."<br>*(oraz 3 innych odgałęzień)* |
| `[5]` | **""Guided by divine providence, we enter a war to protect our sacred values and the ..."** | `[14]` **Player_Romus**: ""As we stand on the precipice of..."<br>`[18]` **Player_Romus**: ""In our sacrifices, we find the ..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | `--;` | `[20]` **Player_Romus**: ""This century began with trials ..."<br>`[22]` **Player_Romus**: ""From the Rezenid Empire through..."<br>*(oraz 3 innych odgałęzień)* |
| `[6]` | **""It is with a sense of duty that I announce a state of war, a necessary stance for..."** | `[14]` **Player_Romus**: ""As we stand on the precipice of..."<br>`[18]` **Player_Romus**: ""In our sacrifices, we find the ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[20]` **Player_Romus**: ""This century began with trials ..."<br>`[22]` **Player_Romus**: ""From the Rezenid Empire through..."<br>*(oraz 3 innych odgałęzień)* |
| `[7]` | **""Our independence is non-negotiable. We will not be swayed by international pressu..."** | `[16]` **Player_Romus**: ""I will say to you: The 'Grand D..."<br>`[17]` **Player_Romus**: ""As your king, I have to be hone..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["...`<br>`--;` | `[3]` **Player_Romus**: ""The time for diplomacy has pass..."<br>`[4]` **Player_Romus**: ""With a heavy heart, I declare t..."<br>*(oraz 2 innych odgałęzień)* |
| `[8]` | **""My people, I have long yearned for the reunification of our lands, a dream that t..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[10]` **Player_Romus**: ""This reunification is not merel..."<br>`[15]` **Player_Romus**: ""The journey ahead is full of st..."<br>*(oraz 2 innych odgałęzień)* |
| `[9]` | **""In the heart of every Rizian, there lies a deep-seated desire to see our nation w..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["...`<br>`--;` | `[10]` **Player_Romus**: ""This reunification is not merel..."<br>`[15]` **Player_Romus**: ""The journey ahead is full of st..."<br>*(oraz 2 innych odgałęzień)* |
| `[10]` | **""This reunification is not merely a quest for land, but a reclamation of the Rizia..."** | `[8]` **Player_Romus**: ""My people, I have long yearned ..."<br>`[11]` **Player_Romus**: ""As your King, I stand before yo..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["...`<br>`--;` | `[7]` **Player_Romus**: ""Our independence is non-negotia..."<br>`[14]` **Player_Romus**: ""As we stand on the precipice of..."<br>*(oraz 2 innych odgałęzień)* |
| `[11]` | **""As your King, I stand before you, not only as a leader but as a steward of our co..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[10]` **Player_Romus**: ""This reunification is not merel..."<br>`[15]` **Player_Romus**: ""The journey ahead is full of st..."<br>*(oraz 2 innych odgałęzień)* |
| `[12]` | **""Today, it is the spirit of our ancestors that guides us, their unfulfilled aspira..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[10]` **Player_Romus**: ""This reunification is not merel..."<br>`[15]` **Player_Romus**: ""The journey ahead is full of st..."<br>*(oraz 2 innych odgałęzień)* |
| `[13]` | **""The journey ahead is fraught with challenges, but our resolve is fortified by the..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[10]` **Player_Romus**: ""This reunification is not merel..."<br>`[15]` **Player_Romus**: ""The journey ahead is full of st..."<br>*(oraz 2 innych odgałęzień)* |
| `[14]` | **""As we stand on the precipice of change, I ask you, my people, to hold fast to the..."** | `[16]` **Player_Romus**: ""I will say to you: The 'Grand D..."<br>`[17]` **Player_Romus**: ""As your king, I have to be hone..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[3]` **Player_Romus**: ""The time for diplomacy has pass..."<br>`[4]` **Player_Romus**: ""With a heavy heart, I declare t..."<br>*(oraz 2 innych odgałęzień)* |
| `[15]` | **""The journey ahead is full of struggle, pain, and death. But we have survived all ..."** | `[8]` **Player_Romus**: ""My people, I have long yearned ..."<br>`[11]` **Player_Romus**: ""As your King, I stand before yo..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["...`<br>`--;` | `[7]` **Player_Romus**: ""Our independence is non-negotia..."<br>`[14]` **Player_Romus**: ""As we stand on the precipice of..."<br>*(oraz 2 innych odgałęzień)* |
| `[16]` | **""I will say to you: The 'Grand Duchy' has no legitimate claim to statehood. It bel..."** | `[8]` **Player_Romus**: ""My people, I have long yearned ..."<br>`[11]` **Player_Romus**: ""As your King, I stand before yo..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[7]` **Player_Romus**: ""Our independence is non-negotia..."<br>`[14]` **Player_Romus**: ""As we stand on the precipice of..."<br>*(oraz 2 innych odgałęzień)* |
| `[17]` | **""As your king, I have to be honest with all of you. Everyone will have to do their..."** | `[8]` **Player_Romus**: ""My people, I have long yearned ..."<br>`[11]` **Player_Romus**: ""As your King, I stand before yo..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[7]` **Player_Romus**: ""Our independence is non-negotia..."<br>`[14]` **Player_Romus**: ""As we stand on the precipice of..."<br>*(oraz 2 innych odgałęzień)* |
| `[18]` | **""In our sacrifices, we find the seeds of our eventual triumph. Our shared hardship..."** | `[16]` **Player_Romus**: ""I will say to you: The 'Grand D..."<br>`[17]` **Player_Romus**: ""As your king, I have to be hone..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[3]` **Player_Romus**: ""The time for diplomacy has pass..."<br>`[4]` **Player_Romus**: ""With a heavy heart, I declare t..."<br>*(oraz 2 innych odgałęzień)* |
| `[19]` | **""Let us brace for the trials ahead, knowing that each challenge we overcome is a s..."** | `[16]` **Player_Romus**: ""I will say to you: The 'Grand D..."<br>`[17]` **Player_Romus**: ""As your king, I have to be hone..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[3]` **Player_Romus**: ""The time for diplomacy has pass..."<br>`[4]` **Player_Romus**: ""With a heavy heart, I declare t..."<br>*(oraz 2 innych odgałęzień)* |
| `[20]` | **""This century began with trials for our people, yet we've endured. We will survive..."** | `[4]` **Player_Romus**: ""With a heavy heart, I declare t..."<br>`[5]` **Player_Romus**: ""Guided by divine providence, we..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[73]` **Player_Romus**: ""Ahead lies a path of glory. I a..."<br>`[74]` **Player_Romus**: ""My people, the call to serve Ri..."<br>*(oraz 5 innych odgałęzień)* |
| `[21]` | **""As long as they still have my daughter, we will fight them to the very last breath.""** | `[4]` **Player_Romus**: ""With a heavy heart, I declare t..."<br>`[5]` **Player_Romus**: ""Guided by divine providence, we..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Vina_Hostage"] == true` | `--;` | `[73]` **Player_Romus**: ""Ahead lies a path of glory. I a..."<br>`[74]` **Player_Romus**: ""My people, the call to serve Ri..."<br>*(oraz 5 innych odgałęzień)* |
| `[22]` | **""From the Rezenid Empire through the present day, we are a people that not only su..."** | `[4]` **Player_Romus**: ""With a heavy heart, I declare t..."<br>`[5]` **Player_Romus**: ""Guided by divine providence, we..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[73]` **Player_Romus**: ""Ahead lies a path of glory. I a..."<br>`[74]` **Player_Romus**: ""My people, the call to serve Ri..."<br>*(oraz 5 innych odgałęzień)* |
| `[23]` | **""Guided by our faith, we march forward with divine conviction.""** | `[4]` **Player_Romus**: ""With a heavy heart, I declare t..."<br>`[5]` **Player_Romus**: ""Guided by divine providence, we..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | `--;` | `[73]` **Player_Romus**: ""Ahead lies a path of glory. I a..."<br>`[74]` **Player_Romus**: ""My people, the call to serve Ri..."<br>*(oraz 5 innych odgałęzień)* |
| `[44]` | **""Glovurius axa Rizia!""** | `[55]` **Player_Romus_Italic**: "I glanced at the crowd."<br>`[56]` **Player_Romus_Italic**: "I placed my hand on Vina's shoul..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["R...`<br>`--;` | `[106]` **Narrator**: "Hugo nearly had to shout to be h..."<br>`[89]` **Vina Toras**: ""The people are on your side, Fa..." |
| `[45]` | **""For Honor, For Rizia, For Eternity!""** | `[55]` **Player_Romus_Italic**: "I glanced at the crowd."<br>`[56]` **Player_Romus_Italic**: "I placed my hand on Vina's shoul..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[106]` **Narrator**: "Hugo nearly had to shout to be h..."<br>`[89]` **Vina Toras**: ""The people are on your side, Fa..." |
| `[46]` | **""Anchored in Gold!""** | `[55]` **Player_Romus_Italic**: "I glanced at the crowd."<br>`[56]` **Player_Romus_Italic**: "I placed my hand on Vina's shoul..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[106]` **Narrator**: "Hugo nearly had to shout to be h..."<br>`[89]` **Vina Toras**: ""The people are on your side, Fa..." |
| `[47]` | **""United under the Crown, we stand strong!""** | `[55]` **Player_Romus_Italic**: "I glanced at the crowd."<br>`[56]` **Player_Romus_Italic**: "I placed my hand on Vina's shoul..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[106]` **Narrator**: "Hugo nearly had to shout to be h..."<br>`[89]` **Vina Toras**: ""The people are on your side, Fa..." |
| `[48]` | **""For king and country!""** | `[55]` **Player_Romus_Italic**: "I glanced at the crowd."<br>`[56]` **Player_Romus_Italic**: "I placed my hand on Vina's shoul..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[106]` **Narrator**: "Hugo nearly had to shout to be h..."<br>`[89]` **Vina Toras**: ""The people are on your side, Fa..." |
| `[49]` | **""United we stand – a family, a kingdom, one force for the future of Rizia!""** | `[20]` **Player_Romus**: ""This century began with trials ..."<br>`[21]` **Player_Romus**: ""As long as they still have my d..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true` | `Variable["RiziaDLC.Turn06_WarSpeech_EntireFamilyHighlight...`<br>`--;` | `[96]` **Player_Romus_Italic**: "I nodded towards the crowd."<br>`[54]` **Player_Romus_Italic**: "I raised my fist in the air."<br>*(oraz 3 innych odgałęzień)* |
| `[50]` | **""With the wisdom of the Grand Vizier at my side, we march boldly into our shared d..."** | `[20]` **Player_Romus**: ""This century began with trials ..."<br>`[21]` **Player_Romus**: ""As long as they still have my d..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Turn06_WarSpeech_Hugo"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true` | `Variable["RiziaDLC.Turn06_WarSpeech_HugoHiglighted"] = true;`<br>`--;` | `[96]` **Player_Romus_Italic**: "I nodded towards the crowd."<br>`[54]` **Player_Romus_Italic**: "I raised my fist in the air."<br>*(oraz 3 innych odgałęzień)* |
| `[51]` | **""Beside me stands our future, Princess Vina – a beacon of strength and hope for Ri..."** | `[20]` **Player_Romus**: ""This century began with trials ..."<br>`[21]` **Player_Romus**: ""As long as they still have my d..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Turn06_WarSpeech_Vina"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true` | `Variable["RiziaDLC.Turn06_WarSpeech_VinaHighlighted"] = t...`<br>`--;` | `[96]` **Player_Romus_Italic**: "I nodded towards the crowd."<br>`[54]` **Player_Romus_Italic**: "I raised my fist in the air."<br>*(oraz 3 innych odgałęzień)* |
| `[52]` | **""With Queen Mother Estela, our matriarch, at my side, we carry forth the Rizian sp..."** | `[20]` **Player_Romus**: ""This century began with trials ..."<br>`[21]` **Player_Romus**: ""As long as they still have my d..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Turn06_WarSpeech_Estela"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true` | `Variable["RiziaDLC.Turn06_WarSpeech_MotherEstelaHighlight...`<br>`--;` | `[96]` **Player_Romus_Italic**: "I nodded towards the crowd."<br>`[54]` **Player_Romus_Italic**: "I raised my fist in the air."<br>*(oraz 3 innych odgałęzień)* |
| `[53]` | **""Alone I stand, yet I am united with every Rizian heart – for our kingdom, for our..."** | `[20]` **Player_Romus**: ""This century began with trials ..."<br>`[21]` **Player_Romus**: ""As long as they still have my d..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Turn06_WarSpeech_RomusAlone"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true` | `Variable["RiziaDLC.Turn06_WarSpeech_RomusAloneHighlighted...`<br>`--;` | `[96]` **Player_Romus_Italic**: "I nodded towards the crowd."<br>`[54]` **Player_Romus_Italic**: "I raised my fist in the air."<br>*(oraz 3 innych odgałęzień)* |
| `[54]` | **"Raise fist in the air."** | `[73]` **Player_Romus**: ""Ahead lies a path of glory. I a..."<br>`[49]` **Player_Romus**: ""United we stand – a family, a k..."<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["...`<br>`--;` | `[44]` **Player_Romus**: ""Glovurius axa Rizia!""<br>`[45]` **Player_Romus**: ""For Honor, For Rizia, For Etern..."<br>*(oraz 4 innych odgałęzień)* |
| `[55]` | **"Glance at the crowd."** | `[73]` **Player_Romus**: ""Ahead lies a path of glory. I a..."<br>`[49]` **Player_Romus**: ""United we stand – a family, a k..."<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[44]` **Player_Romus**: ""Glovurius axa Rizia!""<br>`[45]` **Player_Romus**: ""For Honor, For Rizia, For Etern..."<br>*(oraz 4 innych odgałęzień)* |
| `[56]` | **"Place your hand on Vina's shoulder."** | `[73]` **Player_Romus**: ""Ahead lies a path of glory. I a..."<br>`[49]` **Player_Romus**: ""United we stand – a family, a k..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLC.Turn06_WarSpeech_Vina"] == true` | `--;` | `[44]` **Player_Romus**: ""Glovurius axa Rizia!""<br>`[45]` **Player_Romus**: ""For Honor, For Rizia, For Etern..."<br>*(oraz 4 innych odgałęzień)* |
| `[57]` | **"Wave at the crowd."** | `[73]` **Player_Romus**: ""Ahead lies a path of glory. I a..."<br>`[49]` **Player_Romus**: ""United we stand – a family, a k..."<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["...`<br>`--;` | `[44]` **Player_Romus**: ""Glovurius axa Rizia!""<br>`[45]` **Player_Romus**: ""For Honor, For Rizia, For Etern..."<br>*(oraz 4 innych odgałęzień)* |
| `[73]` | **""Ahead lies a path of glory. I ask you to join me on it.""** | `[20]` **Player_Romus**: ""This century began with trials ..."<br>`[21]` **Player_Romus**: ""As long as they still have my d..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[96]` **Player_Romus_Italic**: "I nodded towards the crowd."<br>`[54]` **Player_Romus_Italic**: "I raised my fist in the air."<br>*(oraz 3 innych odgałęzień)* |
| `[74]` | **""My people, the call to serve Rizia beckons – are you prepared to answer it?""** | `[20]` **Player_Romus**: ""This century began with trials ..."<br>`[21]` **Player_Romus**: ""As long as they still have my d..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["...`<br>`--;` | `[96]` **Player_Romus_Italic**: "I nodded towards the crowd."<br>`[54]` **Player_Romus_Italic**: "I raised my fist in the air."<br>*(oraz 3 innych odgałęzień)* |
| `[75]` | **""The blood of Rizia flows in our veins, fueling a fury born of righteousness and h..."** | `[4]` **Player_Romus**: ""With a heavy heart, I declare t..."<br>`[5]` **Player_Romus**: ""Guided by divine providence, we..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["...`<br>`--;` | `[73]` **Player_Romus**: ""Ahead lies a path of glory. I a..."<br>`[74]` **Player_Romus**: ""My people, the call to serve Ri..."<br>*(oraz 5 innych odgałęzień)* |
| `[92]` | **""Halaita!""** | `[55]` **Player_Romus_Italic**: "I glanced at the crowd."<br>`[56]` **Player_Romus_Italic**: "I placed my hand on Vina's shoul..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Sa...`<br>`--;` | `[106]` **Narrator**: "Hugo nearly had to shout to be h..."<br>`[89]` **Vina Toras**: ""The people are on your side, Fa..." |
| `[96]` | **"Nod at the crowd."** | `[73]` **Player_Romus**: ""Ahead lies a path of glory. I a..."<br>`[49]` **Player_Romus**: ""United we stand – a family, a k..."<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[44]` **Player_Romus**: ""Glovurius axa Rizia!""<br>`[45]` **Player_Romus**: ""For Honor, For Rizia, For Etern..."<br>*(oraz 4 innych odgałęzień)* |

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
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[3]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The time for diplomacy has passed. It is time for we Rizians to assert ourselves in the face of the Palesian aggressor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Player_Romus), `[18]` (Player_Romus), `[19]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Impact += 1;"*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With a heavy heart, I declare that war has descended upon us. And I call for your compassion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Player_Romus), `[18]` (Player_Romus), `[19]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guided by divine providence, we enter a war to protect our sacred values and the sanctity of our homeland.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[14]` (Player_Romus), `[18]` (Player_Romus), `[19]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is with a sense of duty that I announce a state of war, a necessary stance for Rizia's security and future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Player_Romus), `[18]` (Player_Romus), `[19]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our independence is non-negotiable. We will not be swayed by international pressures or superpower alliances.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Player_Romus), `[17]` (Player_Romus), `[15]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Impact += 1;"*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My people, I have long yearned for the reunification of our lands, a dream that today becomes a solemn vow.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In the heart of every Rizian, there lies a deep-seated desire to see our nation whole, undivided by foreign claims or unjust rulings.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Impact += 1;"*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This reunification is not merely a quest for land, but a reclamation of the Rizian history and culture that is deeply intertwined with these territories.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Player_Romus), `[11]` (Player_Romus), `[12]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Impact += 1;"*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As your King, I stand before you, not only as a leader but as a steward of our collective legacy, committed to restoring what is ours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Today, it is the spirit of our ancestors that guides us, their unfulfilled aspirations now our sacred mission.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The journey ahead is fraught with challenges, but our resolve is fortified by the righteousness of our cause.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As we stand on the precipice of change, I ask you, my people, to hold fast to the belief that our future is one of prosperity and peace. Pales and Rizia will reunite under one banner.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Player_Romus), `[17]` (Player_Romus), `[15]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The journey ahead is full of struggle, pain, and death. But we have survived all of our past national struggles, and we will survive this one too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Player_Romus), `[11]` (Player_Romus), `[12]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Impact -= 1;"*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will say to you: The 'Grand Duchy' has no legitimate claim to statehood. It belonged to Rizia once, and it will again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Player_Romus), `[11]` (Player_Romus), `[12]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As your king, I have to be honest with all of you. Everyone will have to do their part to win this war, and sacrifices will need to be made.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Player_Romus), `[11]` (Player_Romus), `[12]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In our sacrifices, we find the seeds of our eventual triumph. Our shared hardships make us stronger.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Player_Romus), `[17]` (Player_Romus), `[15]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let us brace for the trials ahead, knowing that each challenge we overcome is a step closer to our rightful destiny.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Player_Romus), `[17]` (Player_Romus), `[15]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This century began with trials for our people, yet we've endured. We will survive once again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Player_Romus), `[5]` (Player_Romus), `[6]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as they still have my daughter, we will fight them to the very last breath.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[4]` (Player_Romus), `[5]` (Player_Romus), `[6]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""From the Rezenid Empire through the present day, we are a people that not only survives, but thrives.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Player_Romus), `[5]` (Player_Romus), `[6]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guided by our faith, we march forward with divine conviction.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[4]` (Player_Romus), `[5]` (Player_Romus), `[6]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player_Romus: ""The time for diplomacy has passed. It is time for we Riz..."*)
  - -> `[4]` (*Player_Romus: ""With a heavy heart, I declare that war has descended upo..."*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[6]` (*Player_Romus: ""It is with a sense of duty that I announce a state of wa..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Romus: ""This reunification is not merely a quest for land, but a..."*)
  - -> `[15]` (*Player_Romus: ""The journey ahead is full of struggle, pain, and death. ..."*)
  - -> `[16]` (*Player_Romus: ""I will say to you: The 'Grand Duchy' has no legitimate c..."*)
  - -> `[17]` (*Player_Romus: ""As your king, I have to be honest with all of you. Every..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Romus: ""Our independence is non-negotiable. We will not be swaye..."*)
  - -> `[14]` (*Player_Romus: ""As we stand on the precipice of change, I ask you, my pe..."*)
  - -> `[18]` (*Player_Romus: ""In our sacrifices, we find the seeds of our eventual tri..."*)
  - -> `[19]` (*Player_Romus: ""Let us brace for the trials ahead, knowing that each cha..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: ""This century began with trials for our people, yet we've..."*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[22]` (*Player_Romus: ""From the Rezenid Empire through the present day, we are ..."*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[75]` (*Player_Romus: ""The blood of Rizia flows in our veins, fueling a fury bo..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_EntireFamily == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Hugo == true || RiziaDLC.Turn06..."*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Vina == true || RiziaDLC.Turn06..."*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Estela == true || RiziaDLC.Turn..."*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_RomusAlone == true || RiziaDLC...."*)
  - -> `[73]` (*Player_Romus: ""Ahead lies a path of glory. I ask you to join me on it.""*)
  - -> `[74]` (*Player_Romus: ""My people, the call to serve Rizia beckons – are you pre..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player_Romus: ""My people, I have long yearned for the reunification of ..."*)
  - -> `[9]` (*Player_Romus: ""In the heart of every Rizian, there lies a deep-seated d..."*)
  - -> `[11]` (*Player_Romus: ""As your King, I stand before you, not only as a leader b..."*)
  - -> `[12]` (*Player_Romus: ""Today, it is the spirit of our ancestors that guides us,..."*)
  - -> `[13]` (*Player_Romus: ""The journey ahead is fraught with challenges, but our re..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Impact += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["RiziaDLC.Turn06_WarSpeech_Impact"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Impact -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["RiziaDLC.Turn06_WarSpeech_Impact"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Impact += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["RiziaDLC.Turn06_WarSpeech_Impact"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Impact += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["RiziaDLC.Turn06_WarSpeech_Impact"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Impact += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["RiziaDLC.Turn06_WarSpeech_Impact"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Impact += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["RiziaDLC.Turn06_WarSpeech_Impact"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player_Romus: ""Guided by divine providence, we enter a war to protect o..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_EntireFamilyHighlighted = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_EntireFamilyHighlighted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_MotherEstelaHighlighted = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_MotherEstelaHighlighted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_VinaHighlighted = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_VinaHighlighted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_RomusAloneHighlighted = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_RomusAloneHighlighted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_HugoHiglighted = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_HugoHiglighted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glovurius axa Rizia!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Player_Romus_Italic), `[56]` (Player_Romus_Italic), `[96]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_GlovuriusAxaRizia += 1"*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For Honor, For Rizia, For Eternity!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Player_Romus_Italic), `[56]` (Player_Romus_Italic), `[96]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Anchored in Gold!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Player_Romus_Italic), `[56]` (Player_Romus_Italic), `[96]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""United under the Crown, we stand strong!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Player_Romus_Italic), `[56]` (Player_Romus_Italic), `[96]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For king and country!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Player_Romus_Italic), `[56]` (Player_Romus_Italic), `[96]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""United we stand – a family, a kingdom, one force for the future of Rizia!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true`
- **Kontekst wejściowy (poprzednik):** `[20]` (Player_Romus), `[21]` (Player_Romus), `[22]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_EntireFamilyHighlighted = true"*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the wisdom of the Grand Vizier at my side, we march boldly into our shared destiny!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn06_WarSpeech_Hugo"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true`
- **Kontekst wejściowy (poprzednik):** `[20]` (Player_Romus), `[21]` (Player_Romus), `[22]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_HugoHiglighted = true"*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Beside me stands our future, Princess Vina – a beacon of strength and hope for Rizia.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn06_WarSpeech_Vina"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true`
- **Kontekst wejściowy (poprzednik):** `[20]` (Player_Romus), `[21]` (Player_Romus), `[22]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_VinaHighlighted = true"*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With Queen Mother Estela, our matriarch, at my side, we carry forth the Rizian spirit.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn06_WarSpeech_Estela"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true`
- **Kontekst wejściowy (poprzednik):** `[20]` (Player_Romus), `[21]` (Player_Romus), `[22]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_MotherEstelaHighlighted = true"*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alone I stand, yet I am united with every Rizian heart – for our kingdom, for our people.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn06_WarSpeech_RomusAlone"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true`
- **Kontekst wejściowy (poprzednik):** `[20]` (Player_Romus), `[21]` (Player_Romus), `[22]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_RomusAloneHighlighted = true"*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "Raise fist in the air."]** — Mówca: **Player_Romus_Italic**
> "I raised my fist in the air."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Player_Romus), `[49]` (Player_Romus), `[52]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Impact += 1;"*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "Glance at the crowd."]** — Mówca: **Player_Romus_Italic**
> "I glanced at the crowd."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Player_Romus), `[49]` (Player_Romus), `[52]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "Place your hand on Vina's shoulder."]** — Mówca: **Player_Romus_Italic**
> "I placed my hand on Vina's shoulder."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn06_WarSpeech_Vina"] == true`
- **Kontekst wejściowy (poprzednik):** `[73]` (Player_Romus), `[49]` (Player_Romus), `[52]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "Wave at the crowd."]** — Mówca: **Player_Romus_Italic**
> "I waved at the crowd."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Player_Romus), `[49]` (Player_Romus), `[52]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Impact += 1;"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Hugo == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Hugo == true || RiziaDLC.Turn06..."*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn06_WarSpeech_Hugo == true || RiziaDLC.Turn..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Hugo == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn06_WarSpeech_Hugo"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player_Romus: ""With the wisdom of the Grand Vizier at my side, we march..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn06_WarSpeech_Hugo == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn06_WarSpeech_Hugo"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_EntireFamily == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_EntireFamily == true"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn06_WarSpeech_EntireFamily == true)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_EntireFamily == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player_Romus: ""United we stand – a family, a kingdom, one force for the..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn06_WarSpeech_EntireFamily == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_RomusAlone == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_RomusAlone == true || RiziaDLC...."*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn06_WarSpeech_RomusAlone == true || RiziaDL..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_RomusAlone == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn06_WarSpeech_RomusAlone"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: ""Alone I stand, yet I am united with every Rizian heart –..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn06_WarSpeech_RomusAlone == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn06_WarSpeech_RomusAlone"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Estela == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Estela == true || RiziaDLC.Turn..."*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn06_WarSpeech_Estela == true || RiziaDLC.Tu..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Estela == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn06_WarSpeech_Estela"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player_Romus: ""With Queen Mother Estela, our matriarch, at my side, we ..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn06_WarSpeech_Estela == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn06_WarSpeech_Estela"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Vina == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Vina == true || RiziaDLC.Turn06..."*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn06_WarSpeech_Vina == true || RiziaDLC.Turn..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Vina == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn06_WarSpeech_Vina"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player_Romus: ""Beside me stands our future, Princess Vina – a beacon of..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn06_WarSpeech_Vina == true || RiziaDLC.Turn06_WarSpeech_EntireFamily == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn06_WarSpeech_Vina"] == true  or  Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ahead lies a path of glory. I ask you to join me on it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Player_Romus), `[21]` (Player_Romus), `[22]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My people, the call to serve Rizia beckons – are you prepared to answer it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Player_Romus), `[21]` (Player_Romus), `[22]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Impact += 1;"*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The blood of Rizia flows in our veins, fueling a fury born of righteousness and honor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Player_Romus), `[5]` (Player_Romus), `[6]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Impact += 1;"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Impact += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["RiziaDLC.Turn06_WarSpeech_Impact"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Romus_Italic: "Nod at the crowd."*)
  - -> `[54]` (*Player_Romus_Italic: "Raise fist in the air."*)
  - -> `[55]` (*Player_Romus_Italic: "Glance at the crowd."*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Vina == true"*)
  - -> `[57]` (*Player_Romus_Italic: "Wave at the crowd."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player_Romus: ""Glovurius axa Rizia!""*)
  - -> `[45]` (*Player_Romus: ""For Honor, For Rizia, For Eternity!""*)
  - -> `[46]` (*Player_Romus: ""Anchored in Gold!""*)
  - -> `[92]` (*Player_Romus: ""Halaita!""*)
  - -> `[47]` (*Player_Romus: ""United under the Crown, we stand strong!""*)
  - -> `[48]` (*Player_Romus: ""For king and country!""*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Impact >= 6 &&
(RiziaDLC.Turn06_WarSpeech_EntireFamily == true ||  RiziaDLC.Turn06_WarSpeech_Hugo == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Impact >= 6 && (RiziaDLC.Turn06..."*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn06_WarSpeech_Impact >= 6 && (RiziaDLC.Turn..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Impact >= 6 &&
(RiziaDLC.Turn06_WarSpeech_EntireFamily == true ||  RiziaDLC.Turn06_WarSpeech_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] >= 6  and 
(Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true  or   Variable["RiziaDLC.Turn06_WarSpeech_Hugo"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "Hugo nearly had to shout to be heard over the volume of t..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn06_WarSpeech_Impact >= 6 &&
(RiziaDLC.Turn06_WarSpeech_EntireFamily == true ||  RiziaDLC.Turn06_WarSpeech_Hugo == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn06_WarSpeech_Impact"] >= 6  and 
(Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] == true  or   Variable["RiziaDLC.Turn06_WarSpeech_Hugo"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Impact >= 6 && RiziaDLC.Turn06_..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Impact >= 6 && RiziaDLC.Turn06_WarSpeech_Estela == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Impact >= 6 && RiziaDLC.Turn06_..."*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn06_WarSpeech_Impact >= 6 && RiziaDLC.Turn0..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Impact >= 6 && RiziaDLC.Turn06_WarSpeech_Estela == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] >= 6  and  Variable["RiziaDLC.Turn06_WarSpeech_Estela"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Estela Toras: ""If Valero had given that speech in the 1920s... well, we..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn06_WarSpeech_Impact >= 6 && RiziaDLC.Turn06_WarSpeech_Estela == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn06_WarSpeech_Impact"] >= 6  and  Variable["RiziaDLC.Turn06_WarSpeech_Estela"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Impact >= 6 && RiziaDLC.Turn06_WarSpeech_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Impact >= 6 && RiziaDLC.Turn06_..."*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn06_WarSpeech_Impact >= 6 && RiziaDLC.Turn0..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Impact >= 6 && RiziaDLC.Turn06_WarSpeech_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] >= 6  and  Variable["RiziaDLC.Turn06_WarSpeech_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Vina Toras: ""The people are on your side, Father.""*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn06_WarSpeech_Impact >= 6 && RiziaDLC.Turn06_WarSpeech_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn06_WarSpeech_Impact"] >= 6  and  Variable["RiziaDLC.Turn06_WarSpeech_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Impact >= 6 && RiziaDLC.Turn06_..."*)

### Węzeł `[88]`
Mówca: **Estela Toras**
> ""If Valero had given that speech in the 1920s... well, we might not have been in this situation today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[89]`
Mówca: **Vina Toras**
> ""The people are on your side, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Impact >= 6 && RiziaDLC.Turn06_..."*)

### Węzeł `[90]`
Mówca: **Hugo Toras**
> ""Very well done, Romus. You had them in the palm of your hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Impact >= 6 && RiziaDLC.Turn06_..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Impact >= 6 && (RiziaDLC.Turn06..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Player_Romus_Italic), `[56]` (Player_Romus_Italic), `[96]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_Halaita += 1"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Vina == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn06_WarSpeech_Vina == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn06_WarSpeech_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus_Italic: "Place your hand on Vina's shoulder."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn06_WarSpeech_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn06_WarSpeech_Vina"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[96]`
**[WYBÓR GRACZA: "Nod at the crowd."]** — Mówca: **Player_Romus_Italic**
> "I nodded towards the crowd."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Player_Romus), `[49]` (Player_Romus), `[52]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Impact += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Impact"] = Variable["RiziaDLC.Turn06_WarSpeech_Impact"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_Halaita += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_GlovuriusAxaRizia += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["RiziaDLC.Said_GlovuriusAxaRizia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: ""Guided by our faith, we march forward with divine convic..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""As long as they still have my daughter, we will fight th..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[106]`
Mówca: **Narrator**
> "Hugo nearly had to shout to be heard over the volume of the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Hugo Toras: ""Very well done, Romus. You had them in the palm of your ..."*)
