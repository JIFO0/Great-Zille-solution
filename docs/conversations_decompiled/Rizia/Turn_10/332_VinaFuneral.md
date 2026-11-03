# Rizia/Turn 10/VinaFuneral

- **ID konwersacji:** `332`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/332_VinaFuneral.md`
- **Liczba węzłów dialogowych:** 141
- **Liczba wyborów gracza:** 33

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[68]** Hugo Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BirthdayGathering_ViolentAction`
- `RiziaDLC.Council_GrandVizier_Hugo`
- `RiziaDLC.HouseToras_Conquered`
- `RiziaDLC.Hugo_Arrested`
- `RiziaDLC.Hugo_Executed`
- `RiziaDLC.Reform_Success`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Rico_Executed`
- `RiziaDLC.Trait_ReligiousKing`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Successor_Hubertus`
- `RiziaDLC.Successor_Hugo`
- `RiziaDLC.Successor_Rico`
- `RiziaDLC.Successor_Vina`
- `RiziaDLC.VinaFuneral_CoffinFarewell_JoinedMother`
- `RiziaDLC.VinaFuneral_CoffinFarewell_MotherHerself`
- `RiziaDLC.VinaFuneral_PromisedEstela_NotToDie`
- `RiziaDLC.Vina_FuneralHappened`
- `RiziaDLCSupport.Journal_Turn10_VinaFuneral_PromisedEstelaNotToDie`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 16

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[60]` (Paskal Beniwoll): `Variable["RiziaDLC.VinaFuneral_PromisedEstela_NotToDie"] = true; Variable["RiziaDLCSupport.Journa...`
- Węzeł `[61]` (Paskal Beniwoll): `Variable["RiziaDLC.VinaFuneral_CoffinFarewell_JoinedMother"] = true;`
- Węzeł `[62]` (Paskal Beniwoll): `Variable["RiziaDLC.VinaFuneral_CoffinFarewell_MotherHerself"] = true;`
- Węzeł `[67]` (Paskal Beniwoll): `AddConversant("Hugo Toras");`
- Węzeł `[68]` (Paskal Beniwoll): `RemoveConversant("Hugo Toras");`
- Węzeł `[69]` (Paskal Beniwoll): `AddConversant("Estela Toras");`
- Węzeł `[70]` (Paskal Beniwoll): `RemoveConversant("Estela Toras");`
- Węzeł `[72]` (Paskal Beniwoll): `RemoveConversant("Estela Toras");`
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
  - -> `[140]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I had done this countless times now. Far too often. My wife, my father, and so many others."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "But I had never expected that I would have to bury my own daughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[5]`
Mówca: **Hugo Toras**
> ""Make way. Make way for the Princess of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[6]`
Mówca: **Narrator**
> "As per tradition, Hugo was leading the cortège. Around us were thousands of people, crying for their Princess."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "We arrived at the entrance to the National Mausoleum. Hugo stopped and I moved over to the front."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "He knelt before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "A sword."]** — Mówca: **Player_Romus_Italic**
> "I handed him the sword."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[10]`
Mówca: **Hugo Toras**
> ""An offering for the Heiress's passage into Golconda, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[11]`
  - -> `[12]`
  - -> `[14]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "A rose."]** — Mówca: **Player_Romus_Italic**
> "I handed him the rose."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "A feather."]** — Mówca: **Player_Romus_Italic**
> "I handed him the feather."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[13]`
Mówca: **Hugo Toras**
> ""The sword is heavy. Sharp and strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "A gold coin."]** — Mówca: **Player_Romus_Italic**
> "I handed him the gold coin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[15]`
Mówca: **Hugo Toras**
> ""The rose has thorns. Beautiful and defiant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[16]`
Mówca: **Hugo Toras**
> ""The feather is light. Free and flowing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[17]`
Mówca: **Hugo Toras**
> ""The gold is heart. Generous and gracious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""And so, Vina passes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Narrator**
> "He turned to the crowd and held it high. Silence was deafening. His voice roared."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[20]`
Mówca: **Hugo Toras**
> ""The first of her name. Daughter of Romus I. Daughter of the late Princess Consort Lena. Princess of Rizia. Heir to Valenqiris and the lands of Rizia Imperii.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[21]`
Mówca: **Narrator**
> "To my left was my mother. Her eyes were still red from crying, but she held her head up high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are you holding up, Mother?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Romus_Italic**
> "I stayed silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[24]`
Mówca: **Estela Toras**
> ""Losing Lena, then Vina...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Estela Toras**
> ""The women of this family must be cursed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Estela Toras**
> ""Perhaps it really is my fault. A commoner tainting the Toras bloodline and dooming its heirs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[27]`
Mówca: **Estela Toras**
> ""You won't die too, will you, darling? I want you to promise me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[28]`
Mówca: **Narrator**
> "She turned to me with a serious look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I promise, mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "Do not answer."]** — Mówca: **Player_Romus_Italic**
> "I did not answer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Narrator**
> "A single tear fell down her cheek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Estela Toras**
> ""We must... pay our respects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Narrator**
> "Her voice broke off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Narrator**
> "She gripped my arm as the flag of Rizia was removed by ceremonial guardsmen, revealing Vina's serene face. There was an undeniable calmness about her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Estela Toras**
> ""Oh, my dearest Vina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Estela Toras**
> ""What did they do to you? How did we let this happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Narrator**
> "She stood and went toward Vina as her grief took over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[111]`
  - -> `[38]`
  - -> `[40]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "Let her go."]** — Mówca: **Player_Romus_Italic**
> "I let her go."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "Quietly gesture for her to return to her seat."]** — Mówca: **Player_Romus_Italic**
> "I quietly gestured for her to sit down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "Join her."]** — Mówca: **Player_Romus_Italic**
> "I joined her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[41]`
Mówca: **Estela Toras**
> ""Can't a grandmother say her farewells?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come back. That's an order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Narrator**
> "She reluctantly returned to her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[44]`
Mówca: **Narrator**
> "Her voice wavered. She didn't sound like her usual self."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[38]`
  - -> `[40]`

### Węzeł `[45]`
Mówca: **Estela Toras**
> ""I never said goodbye before she left for Pales. The last thing I told her was to watch her waistline...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[46]`
Mówca: **Narrator**
> "Several ceremonial guardsmen picked up the sarcophagus lid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[47]`
Mówca: **Narrator**
> "She went up alongside Vina's stone encasement and stood for a moment. After whispering a few words, she gripped its sides, as if reluctant to let go."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[48]`
Mówca: **Narrator**
> "Hugo allowed her some time before gently guiding her back to her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[49]`
Mówca: **Narrator**
> "She went up alongside Vina's stone encasement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Estela Toras**
> ""Oh, my darling girl. If I was harsh on you, it was because you were my favorite person in the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Estela Toras**
> ""Farewell, Your Highness. Your grandmother will love you forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "Say your final words to Vina."]** — Mówca: **Player_Romus_Italic**
> "I stepped forward, taking the place where my mother had been, to say my final words to Vina."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`
  - -> `[56]`
  - -> `[57]`
  - -> `[58]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "Return to seat."]** — Mówca: **Player_Romus_Italic**
> "I returned to my seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I love you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Say hello to your mother for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will never forgive myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will avenge you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Narrator**
> "I kissed her on the forehead and went back to my throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.VinaFuneral_PromisedEstela_NotToDie = true; RiziaDLCSupport.Journal_Turn10_VinaFuneral_PromisedEstelaNotToDie = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.VinaFuneral_PromisedEstela_NotToDie"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_VinaFuneral_PromisedEstelaNotToDie"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.VinaFuneral_CoffinFarewell_JoinedMother = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.VinaFuneral_CoffinFarewell_JoinedMother"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.VinaFuneral_CoffinFarewell_MotherHerself = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.VinaFuneral_CoffinFarewell_MotherHerself"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[63]`
Mówca: **Narrator**
> "A vessel filled with molten gold was presented to me by a guardsman. I was handed protective gloves, allowing me to grip it without harm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "Pour gold over Vina's coffin."]** — Mówca: **Player_Romus_Italic**
> "Together, we poured the molten gold over Vina's stone coffin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Narrator**
> "As I watched the gold solidify, I felt weak. Frail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Narrator**
> "Just like my father."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `AddConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Estela Toras");)*
- **Efekt (`userScript`):** `AddConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Estela Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Narrator**
> "They walked it toward Vina and carefully lowered it onto its final resting place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Estela Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Estela Toras");)*
- **Efekt (`userScript`):** `AddConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Successor_Hugo = true;
RiziaDLC.Vina_FuneralHappened = true;
EnableCodexEntry("Characters_Family_VinaToras_DiedInWar");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Successor_Hugo"] = true;
Variable["RiziaDLC.Vina_FuneralHappened"] = true;
EnableCodexEntry("Characters_Family_VinaToras_DiedInWar");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Still", "R_Still_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Still","R_Still_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[80]`
Mówca: **Narrator**
> "Despite his resignation as Grand Vizier, Hugo had agreed to lead the cortège. Around us were thousands of people, crying for their Princess."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[84]`
Mówca: **Narrator**
> "It was customary for me, as both her father and the King of Rizia, to present an offering for the Heiress's passage into Golconda."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`
  - -> `[87]`
  - -> `[88]`

### Węzeł `[85]`
**[WYBÓR GRACZA: "A sword."]** — Mówca: **Player_Romus_Italic**
> "I presented a sword."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[86]`
**[WYBÓR GRACZA: "A rose."]** — Mówca: **Player_Romus_Italic**
> "I presented a rose."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "A feather."]** — Mówca: **Player_Romus_Italic**
> "I presented a feather."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "A gold coin."]** — Mówca: **Player_Romus_Italic**
> "I presented a gold coin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[89]`
Mówca: **Narrator**
> "Around me were thousands of people, crying for their Princess."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[90]`
Mówca: **Narrator**
> "It wasn't long before we entered the tomb, where Vina's sarcophagus, draped in the Rizian flag, had been placed next to her mother's. The lid was laid off to the side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The sword is heavy. Sharp and strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The rose has thorns. Beautiful and defiant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The feather is light. Free and flowing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The gold is heart. Generous and gracious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Narrator**
> "Her resting place, like that of all royals, had been prepared early on in life, a precaution for when the inevitable came."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[96]`
Mówca: **Narrator**
> "I held it up for all to see."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[102]`
  - -> `[99]`
  - -> `[103]`

### Węzeł `[97]`
Mówca: **Narrator**
> "Only a select few were permitted to enter -- immediate family, close relatives, and high-ranking nobility. The rest of the crowd remained outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Narrator**
> "As we moved through the corridor, a hushed reverence fell over the smaller group, a stark contrast to the swelling voices from beyond the stone walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And so, Vina passes. The first of her name. Daughter of Romus I. Daughter of late Queen Lena. Princess of Rizia. Heir to the lands of Rizia Imperii.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Narrator**
> "The crowd began to collectively pray and chant her name as I went inside the mausoleum."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[101]`
Mówca: **Narrator**
> "With overcast skies above and a light drizzle falling, I arrived at the entrance to the National Mausoleum."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May this offering guide her to the realms beyond, where her ancestors await. ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina, your journey has ended too soon. May this gift be a token of my love, to accompany you as you cross into the afterlife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By the grace of God, may this offering guide you into the next world, where your spirit will rest beside those who came before you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[108]`
Mówca: **Narrator**
> "I was glad Lena had not lived to see this day. I knew it would have destroyed her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Narrator**
> "The crowd began to collectively pray and chant her name as we turned and went inside the mausoleum."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[110]`
Mówca: **Narrator**
> "I sat in one of the empty seats set out for the royal family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait! You must follow protocol.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Narrator**
> "The ceremonial guardsmen gave her some time before gently guiding her back to her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Narrator**
> "The ceremonial guardsmen gave her some time before gently guiding her back to her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[120]`
Mówca: **Narrator**
> "Hugo allowed her some time before gently guiding her back to her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[121]`
Mówca: **Narrator**
> "She gripped the sides of the sarcophagus, as if reluctant to let go."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[122]`
Mówca: **Narrator**
> "Other ceremonial guardsmen, each carrying their own vessels, stood in formation around me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened = true;
RiziaDLC.Successor_Vina = false;
RiziaDLC.Successor_Rico = true;
EnableCodexEntry("Characters_Family_VinaToras_DiedInWar");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Vina_FuneralHappened"] = true;
Variable["RiziaDLC.Successor_Vina"] = false;
Variable["RiziaDLC.Successor_Rico"] = true;
EnableCodexEntry("Characters_Family_VinaToras_DiedInWar");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Executed"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrested == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Executed"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened = true;
RiziaDLC.Successor_Vina = false;
EnableCodexEntry("Characters_Family_VinaToras_DiedInWar");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Vina_FuneralHappened"] = true;
Variable["RiziaDLC.Successor_Vina"] = false;
EnableCodexEntry("Characters_Family_VinaToras_DiedInWar");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened = true;
RiziaDLC.Successor_Vina = false;
RiziaDLC.Successor_Hubertus = true;
EnableCodexEntry("Characters_Family_VinaToras_DiedInWar");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Vina_FuneralHappened"] = true;
Variable["RiziaDLC.Successor_Vina"] = false;
Variable["RiziaDLC.Successor_Hubertus"] = true;
EnableCodexEntry("Characters_Family_VinaToras_DiedInWar");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_Arrested"] == true  or  Variable["RiziaDLC.Hugo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Arrested"] == true  or  Variable["RiziaDLC.Hugo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[135]`
Mówca: **Estela Toras**
> ""And with even Hugo gone... Our house has turned to dust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true || (RiziaDLC.Reform_Success == true && RiziaDLC.BirthdayGathering_ViolentAction == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true || (RiziaDLC.Reform_Success == true && RiziaDLC.BirthdayGathering_ViolentAction == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true  or  (Variable["RiziaDLC.Reform_Success"] == true  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseToras_Conquered == true || (RiziaDLC.Reform_Success == true && RiziaDLC.BirthdayGathering_ViolentAction == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true  or  (Variable["RiziaDLC.Reform_Success"] == true  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[139]`
Mówca: **Narrator**
> "Despite everything I'd done, Hugo had agreed to lead the cortège out of love for his great-niece. Around us were thousands of people, crying for their Princess."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Burying their daughter after a lost war", "Palace Rezna", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Burying their daughter after a lost war","Palace Rezna","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
