# Rizia/Peaceful Power Transition

- **ID konwersacji:** `430`
- **StoryPack:** `Rizia`
- **Tura:** `Epilogue (Peaceful Power Transition)`
- **Lokalizacja pliku:** `Rizia/Epilogue/430_Peaceful_Power_Transition.md`
- **Liczba węzłów dialogowych:** 694
- **Liczba wyborów gracza:** 178

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Ending_RumburgWarLost`
- `BaseGame.Ending_RumburgWarWin`
- `BaseGame.Ending_WorldWar`
- `RiziaDLC.Adarfo_AbdicationPath`
- `RiziaDLC.Adarfo_Arrested`
- `RiziaDLC.Adarfo_Executed`
- `RiziaDLC.AxelVina_Married_Official`
- `RiziaDLC.BirthdayGathering_Invited_Vina`
- `RiziaDLC.Birthday_Adarfo_Usurped`
- `RiziaDLC.Country_QuelledProtests`
- `RiziaDLC.Coup_Leader_Hugo`
- `RiziaDLC.Coup_Leader_Lucita`
- `RiziaDLC.Coup_Leader_Rico`
- `RiziaDLC.Coup_Leader_Taddeus`
- `RiziaDLC.Ending_Coup_Azaro`
- `RiziaDLC.Ending_Coup_Reform`
- `RiziaDLC.Ending_Coup_Sazon`
- `RiziaDLC.Ending_Coup_Toras`
- `RiziaDLC.Ending_Monarch_Hubertus`
- `RiziaDLC.Ending_Monarch_Hugo`
- `RiziaDLC.Ending_Monarch_Lucita`
- `RiziaDLC.Ending_Monarch_Rico`
- `RiziaDLC.Ending_Monarch_Vina`
- `RiziaDLC.Ending_Revolution`
- `RiziaDLC.Epilogue_Abdication_Speech`
- `RiziaDLC.Epilogue_Exile_HugoSendsToExile`
- `RiziaDLC.Epilogue_KingdomDissolves_Revolution`
- `RiziaDLC.Epilogue_PrimeMinister_Adarfo`
- `RiziaDLC.Epilogue_PrimeMinister_Daria`
- `RiziaDLC.Epilogue_PrimeMinister_Manus`
- `RiziaDLC.Epilogue_Prison_HugoSendsToPrison`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Manus_Arrested`
- `RiziaDLC.Manus_ConvinceToLeave`
- `RiziaDLC.Manus_Executed`
- `RiziaDLC.Manus_ThreatenToLeave`
- `RiziaDLC.NatDes_FinalDecision_Abdicate`
- `RiziaDLC.Pabel_RelationshipPublic`
- `RiziaDLC.Pales_Rizia_Unification`
- `RiziaDLC.Policy_Diplomacy_GRACEMember`
- `RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal`
- `RiziaDLC.Policy_RD_Welfare_RomusTorasUniversity_Completed`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Prologue_Studied`
- `RiziaDLC.Reform_Success`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Relations_Vina_Estranged`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Rico_Executed`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_FuneralHappened`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_MarriageDecision_Axel`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.Vina_MarriageDecision_Rico`
- `RiziaDLC.Vina_Wedding_Happened`
- `RiziaDLC.War_Outcome_NoPeace_KeepFighting`
- `RiziaDLC.ZilleReferendum_Independence`
- `RiziaDLC.ZilleReturn_Success`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.CoupWarning_Destination_Kyrute`
- `RiziaDLC.CoupWarning_Destination_Rumburg`
- `RiziaDLC.Epilogue_ExileTogether_Estela`
- `RiziaDLC.Epilogue_Exile_DecidedInEpilogue`
- `RiziaDLC.Epilogue_Exile_Rumburg`
- `RiziaDLCText.LenaTooltip`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[425] Rizia/Epilogue** (../Epilogue/425_Epilogue.md), Węzeł `[18]`
- Węzeł `[169]` -> **[426] Rizia/Exile** (../Epilogue/426_Exile.md), Węzeł `[346]`
- Węzeł `[170]` -> **[427] Rizia/Immediate Death** (../Epilogue/427_Immediate_Death.md), Węzeł `[79]`
- Węzeł `[642]` -> **[426] Rizia/Exile** (../Epilogue/426_Exile.md), Węzeł `[7]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 13
- **Węzły modyfikujące stan gry:** 41

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.CoupWarning_Destination_Kyrute`
- `RiziaDLC.CoupWarning_Destination_Rumburg`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[3]` (Paskal Beniwoll): `PlayLoopedMusic("R_Continuation","R_Continuation_Loop");`
- Węzeł `[174]` (Paskal Beniwoll): `Variable["RiziaDLC.Epilogue_Exile_Rumburg"] = true; Variable["RiziaDLC.Epilogue_Exile_DecidedInEp...`
- Węzeł `[177]` (Paskal Beniwoll): `Variable["RiziaDLC.Epilogue_Exile_Rumburg"] = false; Variable["RiziaDLC.Epilogue_Exile_DecidedInE...`
- Węzeł `[235]` (Paskal Beniwoll): `--;`
- Węzeł `[300]` (Paskal Beniwoll): `PlayLoopedMusic("R_Continuation","R_Continuation_Loop");`
- Węzeł `[301]` (Paskal Beniwoll): `PlayLoopedMusic("R_Continuation","R_Continuation_Loop");`
- Węzeł `[372]` (Paskal Beniwoll): `PrologueImage("pa_abdication1");`
- Węzeł `[373]` (Paskal Beniwoll): `PrologueImage("pe_newgovernment");`
- *...oraz 33 innych węzłów ze skryptami.*

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
  - -> `[553]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `425` (*Rizia/Epilogue*), Węzeł `[18]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Continuation", "R_Continuation_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Continuation","R_Continuation_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
**[WYBÓR GRACZA: "1957|Porte Drazon|A New Era"]** — Mówca: **Narrator**
> "You leaned over the balcony railing. Your knees felt weak.

'Was this it?', you asked. 'Was this the end of my reign?'. With these words in your mind, gone were the days of Romus the First.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[5]`
  - -> `[7]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...were furious with anger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...felt relieved from the burden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...felt lucky that you didn't die."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[8]`
Mówca: **Narrator**
> "People were cheering with a magnitude you had never seen before. They threw down their weapons and hugged each other.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[9]`
  - -> `[11]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...promised that you would get your revenge one day."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...thought that perhaps this was the best possible outcome."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wondered how your days would be from now on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Narrator**
> "The Rizian flag atop the palace unfurled strongly with the wind.

You thought that it was..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`
  - -> `[15]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...the most beautiful thing you ever saw."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...not worth dying for."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...just a piece of cloth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Abdication_Speech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Abdication_Speech == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Abdication_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Abdication_Speech == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Abdication_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Abdication Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Abdication Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Kingdom Dissolves Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Usurped Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Usurped Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "1958|Porte Drazon|A New Era"]** — Mówca: **Narrator**
> "Releasing the reins of power had been a challenge, both for you and for the nation. Yet, it was a threshold crossed, a door shut behind you. 

As one chapter ended, another began – not just for you, but for Rizia too. In the weeks that followed, the kingdom felt reborn, marked by new leadership and new attitudes. 

You felt..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`
  - -> `[196]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Then democracy arrived in the kingdom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "1958|Porte Drazon|A New Era"]** — Mówca: **Narrator**
> "Power had been a fragile thing, bestowed and then forcibly taken away. In the Citadel, days had turned into weeks. 

The same walls that had once confined many during your reign now held you captive.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[65]`
  - -> `[66]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...found bitter irony in this cruel twist of fate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_PrimeMinister_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_PrimeMinister_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_PrimeMinister_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_PrimeMinister_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_PrimeMinister_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Reform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Reform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Coup_Reform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Reform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true && RiziaDLC.Relations_Vina_Estranged == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true && RiziaDLC.Relations_Vina_Estranged == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true  and  Variable["RiziaDLC.Relations_Vina_Estranged"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.AxelVina_Married_Official == true && RiziaDLC.Relations_Vina_Estranged == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true  and  Variable["RiziaDLC.Relations_Vina_Estranged"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[49]`
Mówca: **Narrator**
> "Vina wasted no time visiting. She recounted how she and Axel had spent the days following the coup with their ears glued to the radio, anxiously waiting for news of your survival.

Now that you were free, she asked you to join her and her husband in Pales, away from the influence of the noble houses.

You decided..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`
  - -> `[51]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...to accept her offer and move to the province."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...to remain in Rizia, requesting for her to visit you soon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "1958|Pales|Court Life"]** — Mówca: **Narrator**
> "You, your mother and Lucita were given an exquisitely lavish set of rooms at the castle with Axel, Vina and the rest of the royal household.

It felt like the luxury of the old days, and spending time around Vina felt good. 

Axel came to you to ask for a favor. Your presence was requested at a party where Arcasian diplomats would be in attendance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You accepted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You rejected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...you didn't want family tying you down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[56]`
Mówca: **Narrator**
> "The ambassador Nicolas Rembrandteur and the Foreign Minister Louis Martell were present at the evening.

Axel introduced them to you and you charmed them with your..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[644]`
  - -> `[647]`
  - -> `[125]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...by the royal decree of King Hugo Toras, your life shall be spared, your honor reinstated, and your family granted clemency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "At least you fought for something greater, for a better world."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You couldn't help but wish you had crushed your enemies when you had the chance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Narrator**
> "Rumors seeped through the prison walls. The coupists had crushed Rizia's nascent democracy. 

The reform movement, once a beacon of hope, had become nothing but a stillborn dream."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`
  - -> `[67]`

### Węzeł `[64]`
Mówca: **Narrator**
> "The world outside had shifted and morphed, yet in many ways, it had remained achingly the same. 

Your release came as part of the Sovereign Transition and Clemency Act signed by the new monarch of Rizia.

On your way out you were handed a letter that read..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...felt nothing but the weight of time, indifferent and patient."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...counted each day, a silent rebellion against your fate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It seemed pointless now, worrying about what could have been."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...under the royal decree of King Rico Toras, your life is hereby preserved, your honor reclaimed, and the safety of your family assured."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...through the royal decree of King Taddeus Azaro, your life is spared, your honor restored, and your family's sanctity upheld."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...by the royal decree of Queen Lucita Azaro, your life is spared, your honor redeemed, and your family's well-being guaranteed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...by the royal decree of Queen Angelica Sazon, your existence is spared, your honor renewed, and your family's safety preserved."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Narrator**
> "Stepping out of the Citadel, the sight of new monuments and currency greeted you, your once-familiar kingly face absent from it all. 

Beyond the prison gates, there awaited your beloved..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Outcome_NoPeace_KeepFighting == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Outcome_NoPeace_KeepFighting == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Outcome_NoPeace_KeepFighting == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Narrator**
> "Settling into Estela's guest house in Porte Drazon for a few days provided a needed respite to gather your thoughts. 

Leafing through a newspaper, you discovered the war at the southern border with the Grand Duchy was still unrelenting.

It was a moment to ponder your next steps. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[80]`
  - -> `[79]`

### Węzeł `[77]`
Mówca: **Narrator**
> "Taking refuge in your mother's guest house in Porte Drazon, you allowed yourself a few days to reorient.

A glance at the newspaper revealed upcoming celebrations and festivities across Rizia, marking a time of national joy. 

It was a moment to ponder your next steps. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[80]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Narrator**
> "To circumvent any potential for political unrest in the capital, Queen Lucita moved your imprisonment to Iza, far from Porte Drazon. 

You were relocated to a slightly better jail cell with a view of the city skyline."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...moved to Iza for a taste of city life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...moved to a hut in Zpana's nature."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ".....settled seaside in Topes, near the ancient Rezenid sites."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [EpilogueIza])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EpilogueIza)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[84]`
Mówca: **Narrator**
> "You would never again wear the crown. But for the first time since your birth, choosing your destiny was truly in your hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[85]`
Mówca: **Narrator**
> "Vina wasted no time visiting. Life in Pales with Axel was flourishing, she said. She extended an invitation to join them and start anew together. 

You decided..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`
  - -> `[51]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wife, Lucita."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...by the royal decree of Queen Lucita Azaro, your sentence is to be extended by an additional 30 days."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...mother, Estela."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "A fresh start awaited."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Outcome_NoPeace_KeepFighting == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Outcome_NoPeace_KeepFighting == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Outcome_NoPeace_KeepFighting == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...life partner, Pabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Coup_Leader_Lucita == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Coup_Leader_Lucita == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Coup_Leader_Lucita == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[103]`
**[WYBÓR GRACZA: "1958|Topes|Seaside Life"]** — Mówca: **Narrator**
> "Lucita agreed with the plan. Together, you journeyed to the east coast of Valenqiris. 

A lovely house was chosen, graced with a sea view and proximity to historical sites.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`
  - -> `[259]`

### Węzeł `[104]`
**[WYBÓR GRACZA: "1958|Topes|Seaside Life"]** — Mówca: **Narrator**
> "Pabel immediately agreed to come with you to the east coast of Valenqiris.

You found a delightful house with a stunning sea view, nestled near historical landmarks.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`
  - -> `[259]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "1958|Topes|Seaside Life"]** — Mówca: **Narrator**
> "Estela welcomed the change and journeyed with you to the east coast of Valenqiris.

Once there, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`
  - -> `[259]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[109]`
Mówca: **Narrator**
> "After a long, intense wait, the moment arrived. Late at night, Lucita woke you up to tell you the baby was coming.

At 11:13 AM, your son opened his eyes to his first morning. In that instant..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`
  - -> `[114]`
  - -> `[115]`
  - -> `[116]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[113]`
Mówca: **Narrator**
> "Life with Pabel was fulfilling, despite the occasional odd looks from locals. When you were together, everything else seemed trivial. 

In this newfound contentment, you spent more time..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`
  - -> `[282]`
  - -> `[302]`
  - -> `[396]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...the joy of parenthood eclipsed all else."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...everything else faded, only this moment mattered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...all of life's complexities seemed trivial."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.AxelVina_Married_Official == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[120]`
Mówca: **Narrator**
> "A year later, Vina and Axel visited, bringing a delightful surprise – their baby daughter Lena, named after her grandmother.

In that moment of familial joy, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[121]`
Mówca: **Narrator**
> "Vina's whereabouts remained a mystery.

You wondered if you would ever see or hear from your daughter again.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`
  - -> `[404]`
  - -> `[309]`

### Węzeł `[122]`
Mówca: **Narrator**
> "You decided to explore the city of Pales instead. You had never truly gotten to know it before. Now, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[126]`
  - -> `[127]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "..legendary humor, regaling them with witty anecdotes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...outlandish tales from your Party Prince days."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...deep philosophical musings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "..enjoyed the beach scene, mingling incognito with locals and tourists."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...went out on the town, hunting for the best restaurants and bars."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[128]`
Mówca: **Narrator**
> "Months passed in Pales, and the Grand Duchy, under Vina and Axel's stewardship, flourished. 

Their happiness grew with the arrival of their baby daughter Lena, named after her grandmother. When Vina asked for your help in caring for her new child, it prompted a moment of reflection. 

You realized..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[55]`
  - -> `[272]`
  - -> `[273]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...you wanted nothing more than to be a caring grandfather."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "..wandered the historic streets, absorbing the city's heritage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_WorldWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_WorldWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_WorldWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_WorldWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_WorldWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarWin == true || BaseGame.Ending_RumburgWarLost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarWin == true || BaseGame.Ending_RumburgWarLost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarWin"] == true  or  Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_RumburgWarWin == true || BaseGame.Ending_RumburgWarLost == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarWin"] == true  or  Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[146]`
Mówca: **Narrator**
> "Lucita's discomfort with the Palesians deepened as her pregnancy advanced. You did your best to support her regardless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[271]`

### Węzeł `[147]`
Mówca: **Narrator**
> "Pabel reveled in the city's energy. You made no secret of your relationship, and though at first you were worried you wouldn't be accepted, the elite social circles seemed indifferent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[271]`

### Węzeł `[148]`
Mówca: **Narrator**
> "The sea air was a comfort to your aging mother, though she often yearned for Zille. 

She threw herself into helping Vina and Axel organize parties and gatherings for the Palesian elite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[271]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It was good to spend time with loved ones."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[153]`
Mówca: **Narrator**
> "After serving your month-long sentence, you emerged from Iza City Prison to a different world. New monuments had risen, and the currency circulated without the familiar imprint of your face. 

Clutching a newspaper, you learned the war at the southern border near the Grand Duchy was still raging. Its ramifications would last years, if not decades.

As you stepped beyond the prison gates, there awaited..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Narrator**
> "With nothing but painful reminders of your past life awaiting in Porte Drazon, you chose to stay in Iza and turn over a new leaf.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[499]`
  - -> `[261]`
  - -> `[503]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...your mother, Estela."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...your life partner, Pabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false &&RiziaDLC.Coup_Leader_Lucita == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false &&RiziaDLC.Coup_Leader_Lucita == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and Variable["RiziaDLC.Coup_Leader_Lucita"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false &&RiziaDLC.Coup_Leader_Lucita == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and Variable["RiziaDLC.Coup_Leader_Lucita"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[166]`
**[WYBÓR GRACZA: "1958|Zpana|Rural Life"]** — Mówca: **Narrator**
> "Though skeptical at first, Lucita joined you in the wilderness. After a while, she began to appreciate the slower pace of life there.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`
  - -> `[260]`

### Węzeł `[167]`
**[WYBÓR GRACZA: "1958|Zpana|Rural Life"]** — Mówca: **Narrator**
> "Pabel, eager to get away from prying eyes, accompanied you to the serene hut nestled in Zpana's wilderness.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`
  - -> `[260]`

### Węzeł `[168]`
**[WYBÓR GRACZA: "1958|Zpana|Rural Life"]** — Mówca: **Narrator**
> "Your mother appreciated the serenity of Zpana's nature, endorsing the move to the peaceful hut.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`
  - -> `[260]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Jump From Kingdom Dissolves])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `426` (*Rizia/Exile*), Węzeł `[346]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Jump from Kingdom Dissolves to Death])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `427` (*Rizia/Immediate Death*), Węzeł `[79]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == false && RiziaDLC.Country_QuelledProtests <= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == false && RiziaDLC.Country_QuelledProtests <= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == false  and  Variable["RiziaDLC.Country_QuelledProtests"] <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == false && RiziaDLC.Country_QuelledProtests <= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == false  and  Variable["RiziaDLC.Country_QuelledProtests"] <= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Exile_Rumburg = true;
RiziaDLC.Epilogue_Exile_DecidedInEpilogue = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_Exile_Rumburg"] = true;
Variable["RiziaDLC.Epilogue_Exile_DecidedInEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Kyrute was the safest option."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Rumburg sounded nice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Exile_Rumburg = false; RiziaDLC.Epilogue_Exile_DecidedInEpilogue = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_Exile_Rumburg"] = false;
Variable["RiziaDLC.Epilogue_Exile_DecidedInEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Your life was an open door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[179]`
Mówca: **Narrator**
> "The first ever general election in Rizia was nothing short of a spectacle. With an impressive 80% turnout, the people demonstrated their hunger for change and voted overwhelmingly in favor of the RPP.

Adarfo Sotelato championed a sweeping reform agenda, far beyond what you had managed to achieve as king.

In his inaugural speech, he hailed a new era, while relegating your legacy to the past. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[186]`
  - -> `[184]`

### Węzeł `[180]`
Mówca: **Narrator**
> "Rizia's first general election was a remarkable event. Achieving a 60% turnout, Prime Minister Daria de Rava triumphed, resonating with the kingdom's nationalist pulse. 

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[187]`
  - -> `[225]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...didn't care and just wanted to move on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wrote her a letter congratulating her on her win."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wrote him a letter of congratulations."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wished for more radical change."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[188]`
Mówca: **Narrator**
> "Over time, the security threats diminished, granting you the freedom you'd longed for. 

You rekindled your bonds with friends and acquaintances you hadn't seen since taking the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[189]`
Mówca: **Narrator**
> "A chilling announcement halted the continent: a devastating nuclear exchange had ravaged Holsord and parts of Rumburg.

The AN's swift intervention brought a respite from the hostilities within 72 hours, though conventional conflicts in East Merkopa escalated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[190]`
Mówca: **Narrator**
> "An alarming broadcast interrupted your day: Rumburg was under invasion by the Republic of Sordland. 

The toll was already steep, with no end in sight. While Rumburg was distant, the war's impact was felt in Rizia, where Rumburgian refugees were reluctant to return to their ravaged homeland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...a sense of relief wash over you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...hopeful about the future unfolding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...a pang of regret for your past reign's shortcomings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Monarch_Vina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Monarch_Vina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Monarch_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Monarch_Vina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Monarch_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Monarch_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Monarch_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Monarch_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Monarch_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Monarch_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Monarch_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Monarch_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Monarch_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Monarch_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Monarch_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Monarch_Hubertus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Monarch_Hubertus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Monarch_Hubertus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Monarch_Hubertus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Monarch_Hubertus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Monarch_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Monarch_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Monarch_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Monarch_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Monarch_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[212]`
Mówca: **Narrator**
> "Queen Vina quickly endeared herself to the populace, earning the affectionate title of 'People's Queen.' 

Shortly after her coronation, she initiated a sweeping campaign to eradicate poverty that proved both popular and effective. 

In her speeches, she gratefully acknowledged your contributions to the nation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[213]`
Mówca: **Narrator**
> "King Hugo garnered respect from older citizens, who hailed him as 'The Protector King.' 

In his coronation address, he championed education and traditional values while paying homage to your legacy with respect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[214]`
Mówca: **Narrator**
> "King Rico Toras infused a newfound sense of nationalism and monarchism in Rizia. 

His first decree incorporated Su Omina into Rizia's national security forces.

Notably, he made no mention of you in his coronation address."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[215]`
Mówca: **Narrator**
> "Ascending monarch Hubertus Toras faced skepticism beyond Valenqiris, evidenced by the subdued response to his coronation. 

His first decree focused on boosting tourism with an amusement park in Valenqir. 

During his first address, he devoted a considerable time to lauding your tenure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[216]`
Mówca: **Narrator**
> "As Lucita Azaro ascended the throne as interim queen, you stood by her side as King Consort. Her popularity extended beyond Cardesse-Montaklar, overshadowing even your own legacy. 

In her first address, she acknowledged your past contributions with graciousness."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Long live the new Queen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Long live the new King."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Monarch_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Monarch_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Monarch_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Monarch_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Monarch_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...let the Palace staff do most of the work."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[223]`
Mówca: **Narrator**
> "Over time, the security threats diminished, granting you the freedom you'd longed for. 

You immediately sought out Pabel. At long last, the two of you could be together without fear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...felt a twinge of obsolescence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...felt reassured by her approach to maintain unity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...immersing yourself in study and knowledge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Narrator**
> "Queen Lucita Azaro arranged for your transfer to Palas Rezna, reflecting the country's return to tranquility and a smoother-than-anticipated transition. 

In the grandeur of the palace, you spent your days..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[230]`
  - -> `[226]`

### Węzeł `[228]`
Mówca: **Narrator**
> "But the serenity of your new life didn't last long. You were in your study when you received the news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Vina was expecting a child."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...tending to the gardens."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...aiding her in state matters as King Consort."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Lucita was in labor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[233]`
Mówca: **Narrator**
> "The birth of Queen Lucita's son {RiziaDLCText.KingsSon} sparked jubilation throughout the kingdom.

As a father for the second time, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[222]`
  - -> `[348]`

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...assumed childrearing duties while your wife held the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "A few weeks passed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Then democracy arrived in the kingdom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[244]`
Mówca: **Narrator**
> "At long last, the security threats diminished, granting you the freedom you'd longed for. 

You reunited with Lucita, grateful that you hadn't yet missed the birth of your son."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[248]`
Mówca: **Narrator**
> "The news of your grandchild-to-be -- and the new heir to the Palesian throne -- filled you with joy.

Axel and Vina's visit to Palas Rezna was a time of celebration, a gathering of generations. 

Then, just a week later, the Queen herself went into labor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Rizia's new prince was born."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Outcome_NoPeace_KeepFighting == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Outcome_NoPeace_KeepFighting == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Outcome_NoPeace_KeepFighting == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Took up hunting as a hobby."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Started farming, cultivating your own crops."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Managed the local tourism center, occasionally guiding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Took up fishing as a pastime."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...started writing poetry and joined art circles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...decided to try your hand at stand-up comedy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Relaxed and enjoyed your new downtime."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Relaxed and made new friends."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...reveled in your sudden free time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[262]`
**[WYBÓR GRACZA: "1958|Iza|City Life"]** — Mówca: **Narrator**
> "Lucita followed you to the Brenas capital. Together, you dove into the bustling urban culture there.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[499]`
  - -> `[261]`
  - -> `[503]`

### Węzeł `[263]`
**[WYBÓR GRACZA: "1958|Iza|City Life"]** — Mówca: **Narrator**
> "Your mother, open to a change of scenery, relocated along with you.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[499]`
  - -> `[261]`
  - -> `[503]`

### Węzeł `[264]`
**[WYBÓR GRACZA: "1958|Iza|City Life"]** — Mówca: **Narrator**
> "Pabel was excited to move to the Brenas capital. Since homosexuality was decriminalized, nightlife in the cultural hub was more thrilling than ever.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[499]`
  - -> `[261]`
  - -> `[503]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Coup_Leader_Lucita == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Coup_Leader_Lucita == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Coup_Leader_Lucita == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Things could be much worse in life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...you could balance your time between helping with Lena and pursuing your own interests."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...guiding Lena's early years could become a significant part of your legacy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[274]`
Mówca: **Narrator**
> "Embracing grandfatherhood, you spent countless hours with Lena, witnessing her first steps, her first words. 

The bond you formed with her was irreplaceable, enriching your days with joy and laughter. 

As Lena grew, so did your role in her life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[275]`
Mówca: **Narrator**
> "You congratulated your daughter and her husband on their new child, but told them you couldn't be counted on to help out.

You spent the rest of your days pursuing your own interests, traveling the world and telling anyone who'd listen about the brief time you spent as King of Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[276]`
Mówca: **Narrator**
> "You became a guiding presence in Lena's life while not forgoing your interests. 

The arrangement brought depth to your days, blending family warmth with personal growth. 

As Lena grew older, your relationship evolved. The title of "King Romus" faded from your memory, replaced by the name "Grandfather"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Narrator**
> "In grandfatherhood, you found a sense of purpose. Your wisdom and experiences became the bedrock of her upbringing. 

As she grew, so did the impact of your teachings.

The path ahead gleamed with the promise of her blossoming under your tutelage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "And thus your story ended."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[279]`
Mówca: **Narrator**
> "Your mother, feeling homesick, told you she wanted to spend her last years at her old house in Zille.

You saw her off, promising to visit as often as you could.

Your focus turned to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`
  - -> `[282]`
  - -> `[396]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...immersing yourself in the local culture."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...pursuing hobbies and self-growth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...partaking in community social work."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...guided your granddaughter and new son with wisdom and care."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...dedicated yourself to raising your son wisely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...balanced your grandfatherly duties with personal time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...the psychology of warfare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[287]`
Mówca: **Narrator**
> "As you flipped through the typewritten pages, a spark reignited within you for politics. 

Motivated, you resolved to pen your own thesis, asking your old university professors for guidance.

As a scholar, you focused on..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`
  - -> `[286]`
  - -> `[289]`
  - -> `[288]`

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...the influence of the spiritual will in human societies."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...the wealth disparities in Rizia and the societal issues that arose from them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[290]`
**[WYBÓR GRACZA: "1966|Rizia|An Old Man"]** — Mówca: **Narrator**
> "Over the years, your societal prominence waned. The eight years you spent as king faded in your memory, crowded out by your many other life experiences. 

During a quiet day at home, you picked up..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`
  - -> `[314]`
  - -> `[516]`

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...the teachings of Prophet Hu, the founder of Zaranism."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...Miraclism theories and the principles of conservatism."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...totalism and the concept of enforced efficient change."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Narrator**
> "Though your paper resonated with those who knew you best, it received a lukewarm reception from academic circles. 

For you, at least, the endeavor marked a new, more thoughtful chapter in your life.

Those around you began referring to you affectionately as 'the Professor King'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[295]`
Mówca: **Narrator**
> "Time unfolded as you pursued this newfound passion for knowledge. 

Your intellectual exploration defined your later years, earning you the moniker 'the philosopher king'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Narrator**
> "As time marched on, you aged with the wisdom and contentment your choices brought. 

Throughout the years, the name 'Romus Toras' was spoken with fondness and respect by those you cared about."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It had a nice ring to it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "And there was finally peace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It had a nice ring to it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Continuation", "R_Continuation_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Continuation","R_Continuation_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Continuation", "R_Continuation_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Continuation","R_Continuation_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...partying with your old rich friends."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...decided to focus on yourself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[310]`
Mówca: **Narrator**
> "At long last, Rumburg and Sordland reached a ceasefire, leading to a lasting peace. 

The years had seen much loss, often for reasons that now seemed trivial. But the burden of these events was no longer yours to bear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`
  - -> `[313]`

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "War, war never changes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You worried about the future."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It felt good to be off the hook."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...a history book from your father's old collection."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[315]`
Mówca: **Narrator**
> "Engrossed, you delved into..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[292]`
  - -> `[293]`
  - -> `[317]`

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...a political thesis a friend had entrusted you to review."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...the immediatist movement, studying their drive for swift change."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...the healing effects of humor in society."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[325]`
Mówca: **Narrator**
> "Under Sotelato’s leadership, the revolutionary government solidified, elevating him to a Prime Minister with tangible authority. 

Despite his ascendancy, factions were getting more extreme."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Purges against the nobility began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Then, a loud bang."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[328]`
Mówca: **Narrator**
> "You decamped to one of your family guest houses near Porte Drazon.

After a few weeks in isolation, you couldn't take it anymore. You put on a disguise and went into the Old Town to get some air.

Suddenly, out of nowhere, you heard a shout. "YOU MONSTER! YOU TOOK HER AWAY FROM ME!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You took her advice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "In spite of her warnings, you chose to stay."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[334]`
Mówca: **Narrator**
> "As Lucita Azaro ascended the throne as interim queen, you stood by her side as King Consort. 

In her first address, she acknowledged your past contributions with graciousness."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[338]`
Mówca: **Narrator**
> "Ascending monarch Hubertus Toras faced skepticism beyond Valenqiris, evidenced by the subdued response to his coronation. 

During his first address, he devoted a considerable time to lauding your tenure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`
  - -> `[341]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[342]`
Mówca: **Narrator**
> "King Rico Toras infused a newfound sense of nationalism and monarchism in Rizia. 

Notably, he made no mention of you in his coronation address."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[343]`
Mówca: **Narrator**
> "You watched your successor's crowning from seclusion. Death threats had begun arriving shortly after your abdication, and security advised you to keep a low profile.

You and your mother absconded to a family estate on the outskirts of Porte Drazon, waiting for the news that you were safe at last."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.AxelVina_Married_Official == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[347]`
Mówca: **Narrator**
> "She and Manus visited Palas Rezna to celebrate. It was a time of joy, a gathering of generations.

Then, just a week later, the Queen herself went into labor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`
  - -> `[350]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...tried not to make the same mistakes you did with Vina."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[352]`
**[WYBÓR GRACZA: "1976|Porte Drazon|Long Live The King"]** — Mówca: **Narrator**
> "You lived out the rest of your days as King Emeritus of Rizia, commanding respect but little authority.

The day your son came of age, the golden Toras crown was placed upon his head.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[354]`
  - -> `[355]`

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...did not envy him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wished him the best of luck."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...were reassured by the knowledge that the reign of House Toras would continue -- with or without you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[356]`
Mówca: **Narrator**
> "You decamped to one of your family guest houses near Porte Drazon and waited for the air to clear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Security threats diminished)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Security threats diminished])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Days passed in uncertainty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`
  - -> `[362]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_FuneralHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_FuneralHappened == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_FuneralHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]`

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...your heartache from Vina's death diminished, though it never truly went away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Manus_Arrested == false && RiziaDLC.Manus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
  - -> `[366]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Manus_Arrested == false && RiziaDLC.Manus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  and  Variable["RiziaDLC.Manus_Arrested"] == false  and  Variable["RiziaDLC.Manus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Manus_Arrested == false && RiziaDLC.Manus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  and  Variable["RiziaDLC.Manus_Arrested"] == false  and  Variable["RiziaDLC.Manus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Narrator**
> "A year later, Vina and Manus visited, bringing a delightful surprise – their baby daughter Lena, named after her grandmother.

In that moment of familial joy, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`
  - -> `[309]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == true  and  Variable["RiziaDLC.Rico_Executed"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == true  and  Variable["RiziaDLC.Rico_Executed"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[371]`
Mówca: **Narrator**
> "Vina, freed of the burden of carrying the Toras lineage forward, filed for divorce against Rico.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[309]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pa_abdication1"))*
- **Efekt (`userScript`):** `PrologueImage("pa_abdication1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_newgovernment"))*
- **Efekt (`userScript`):** `PrologueImage("pe_newgovernment");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_continuedreign1"))*
- **Efekt (`userScript`):** `PrologueImage("pe_continuedreign1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_letter"))*
- **Efekt (`userScript`):** `PrologueImage("pe_letter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_relaxed"))*
- **Efekt (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_princebirth"))*
- **Efekt (`userScript`):** `PrologueImage("pe_princebirth");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_relaxed"))*
- **Efekt (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_palesvisit"))*
- **Efekt (`userScript`):** `PrologueImage("pe_palesvisit");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_plane"))*
- **Efekt (`userScript`):** `PrologueImage("pe_plane");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_relaxed"))*
- **Efekt (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_relaxed"))*
- **Efekt (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_relaxed"))*
- **Efekt (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_princebirth"))*
- **Efekt (`userScript`):** `PrologueImage("pe_princebirth");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_burning"))*
- **Efekt (`userScript`):** `PrologueImage("pe_burning");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_relaxed"))*
- **Efekt (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_continuedreign5"))*
- **Efekt (`userScript`):** `PrologueImage("pe_continuedreign5");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_letter"))*
- **Efekt (`userScript`):** `PrologueImage("pe_letter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_relaxed"))*
- **Efekt (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_continuedreign1"))*
- **Efekt (`userScript`):** `PrologueImage("pe_continuedreign1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_suitcase"))*
- **Efekt (`userScript`):** `PrologueImage("pe_suitcase");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_revolution"))*
- **Efekt (`userScript`):** `PrologueImage("pe_revolution");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[395]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`
  - -> `[398]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_PartyPrince == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[399]`
Mówca: **Narrator**
> "Vina visited you often. Now that you were no longer king, your bond felt stronger than ever.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[309]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`
  - -> `[402]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[403]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...threw yourself into raising your son."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...spent all your spare time trying to track her down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`
  - -> `[407]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[408]`
Mówca: **Narrator**
> "With stiff formality, she informed you she had been living in Kyrute under an assumed name.

After a year or so, she had tracked down Manus Sazon. The two of them now had a daughter, named after her late grandmother Lena.

She wished you the best.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`
  - -> `[430]`
  - -> `[431]`

### Węzeł `[409]`
Mówca: **Narrator**
> "In it, your daughter expressed her gratitude for everything you'd taught her.

She enclosed a portrait that Lena had drawn of you in art class."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "A crown was on your head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...a letter from Vina."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`
  - -> `[414]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Studied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_RomusTorasUniversity_Completed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`
  - -> `[417]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_RomusTorasUniversity_Completed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_RomusTorasUniversity_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_RomusTorasUniversity_Completed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_RomusTorasUniversity_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`

### Węzeł `[418]`
Mówca: **Narrator**
> "As you flipped through the typewritten pages, a spark reignited within you for politics. 

Motivated, you resolved to pen your own thesis, asking the professors at Romus Toras University for guidance.

As a scholar, you focused on..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[288]`

### Węzeł `[419]`
Mówca: **Narrator**
> "After the war ended, she had finally been allowed to leave Pales. 

She was on her way back to Rizia.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`
  - -> `[424]`
  - -> `[425]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`
  - -> `[422]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...welcomed her with open arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[424]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...urged her to go elsewhere, knowing she'd never truly be safe at home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[425]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...apologized for the way everything had turned out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_ConvinceToLeave == true || RiziaDLC.Manus_ThreatenToLeave == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`
  - -> `[428]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_ConvinceToLeave == true || RiziaDLC.Manus_ThreatenToLeave == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Manus_ConvinceToLeave"] == true  or  Variable["RiziaDLC.Manus_ThreatenToLeave"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Manus_ConvinceToLeave == true || RiziaDLC.Manus_ThreatenToLeave == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Manus_ConvinceToLeave"] == true  or  Variable["RiziaDLC.Manus_ThreatenToLeave"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[429]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...never answered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[430]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wrote back, apologizing for everything you'd put her through."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...burned the letter, knowing your daughter's family would be safer that way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[432]`
Mówca: **Narrator**
> "With stiff formality, she informed you she had been living in Kyrute under an assumed name.

She had married a commoner who knew nothing of her royal identity. The two of them now had a daughter, named after her late grandmother Lena. 

She wished you the best.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`
  - -> `[430]`
  - -> `[431]`

### Węzeł `[433]`
Mówca: **Narrator**
> "In it, your daughter expressed her gratitude for the way you had raised her.

She enclosed an old drawing she'd made as a child: you, her and Lena, with big golden crowns on your heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`
  - -> `[435]`

### Węzeł `[434]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You had it framed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[435]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You couldn't bear to look at it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[436]`
Mówca: **Narrator**
> "Eventually, you and Vina struck up a correspondence. You felt sorrow for all the years you'd missed, but gratitude that your daughter was back in your life.

As time marched on, you aged with the wisdom and contentment your choices brought."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CoupWarning_Destination_Rumburg = false;
RiziaDLC.CoupWarning_Destination_Kyrute = false;
RiziaDLC.Epilogue_ExileTogether_Estela = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.CoupWarning_Destination_Rumburg"] = false;
Variable["RiziaDLC.CoupWarning_Destination_Kyrute"] = false;
Variable["RiziaDLC.Epilogue_ExileTogether_Estela"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_Unification == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`
  - -> `[440]`

### Węzeł `[439]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_Unification == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_Unification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[440]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Rizia_Unification == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...to accept her offer and move to the Grand Duchy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`
  - -> `[444]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[445]`
**[WYBÓR GRACZA: "1958|Pales|Court Life"]** — Mówca: **Narrator**
> "You, your mother and Pabel were given an exquisitely lavish set of rooms at the castle with Axel, Vina and the rest of the royal household.

It felt like the luxury of the old days, and spending time around Vina felt good. 

Axel came to you to ask for a favor. Your presence was requested at a party where Arcasian diplomats would be in attendance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[446]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`
  - -> `[448]`

### Węzeł `[447]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[449]`
**[WYBÓR GRACZA: "1958|Pales|Court Life"]** — Mówca: **Narrator**
> "You and your mother were given an exquisitely lavish set of rooms at the castle with Axel, Vina and the rest of the royal household.

It felt like the luxury of the old days, and spending time around Vina felt good. 

Axel came to you to ask for a favor. Your presence was requested at a party where Arcasian diplomats would be in attendance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[450]`
Mówca: **Narrator**
> "At long last, Rumburg and Sordland reached a ceasefire, though your former sister-in-law's kingdom had suffered heavy losses.

The years had seen much loss, often for reasons that now seemed trivial. But the burden of these events was no longer yours to bear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`
  - -> `[313]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_continuedreign5"))*
- **Efekt (`userScript`):** `PrologueImage("pe_continuedreign5");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[452]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarWin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`
  - -> `[454]`

### Węzeł `[453]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarWin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[454]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_RumburgWarWin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[455]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_continuedreign5"))*
- **Efekt (`userScript`):** `PrologueImage("pe_continuedreign5");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[456]`
Mówca: **Narrator**
> "At long last, Rumburg and Sordland reached a ceasefire, with your former sister-in-law's kingdom claiming a decisive victory.

The years had seen much loss, often for reasons that now seemed trivial. But the burden of these events was no longer yours to bear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`
  - -> `[313]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true && RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`
  - -> `[459]`

### Węzeł `[458]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true && RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true  and  Variable["RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReturn_Success == true && RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true  and  Variable["RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[460]`
Mówca: **Narrator**
> "Your mother, feeling homesick, told you she wanted to spend her last years in her old village in Zille.

You saw her off, promising to visit as often as you could.

Your focus turned to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`
  - -> `[282]`

### Węzeł `[461]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`
  - -> `[463]`

### Węzeł `[462]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[463]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReturn_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[464]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Independence == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`
  - -> `[466]`

### Węzeł `[465]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Independence == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Independence"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[466]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Independence == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Independence"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[467]`
Mówca: **Narrator**
> "Your mother, feeling homesick, petitioned the government of {RiziaDLCText.IndependentZille} to allow her to spend her remaining years in her old village.

You saw her off, promising to visit as often as you could.

Your focus turned to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`
  - -> `[282]`
  - -> `[396]`

### Węzeł `[468]`
Mówca: **Narrator**
> "Your mother, feeling homesick, petitioned the Wehzek government to allow her to spend her remaining years in her old village in Zille.

You saw her off, promising to visit as often as you could.

Your focus turned to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`
  - -> `[282]`
  - -> `[396]`

### Węzeł `[469]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Azaro == true || RiziaDLC.Ending_Coup_Reform == true || RiziaDLC.Ending_Coup_Sazon == true || RiziaDLC.Ending_Coup_Toras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`
  - -> `[471]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Azaro == true || RiziaDLC.Ending_Coup_Reform == true || RiziaDLC.Ending_Coup_Sazon == true || RiziaDLC.Ending_Coup_Toras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Azaro"] == true  or  Variable["RiziaDLC.Ending_Coup_Reform"] == true  or  Variable["RiziaDLC.Ending_Coup_Sazon"] == true  or  Variable["RiziaDLC.Ending_Coup_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Coup_Azaro == true || RiziaDLC.Ending_Coup_Reform == true || RiziaDLC.Ending_Coup_Sazon == true || RiziaDLC.Ending_Coup_Toras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Azaro"] == true  or  Variable["RiziaDLC.Ending_Coup_Reform"] == true  or  Variable["RiziaDLC.Ending_Coup_Sazon"] == true  or  Variable["RiziaDLC.Ending_Coup_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]`

### Węzeł `[472]`
Mówca: **Narrator**
> "Vina wasted no time visiting. She recounted how she and Axel had spent the days following the revolution with their ears glued to the radio, anxiously waiting for news of your survival.

Meanwhile, they had negotiated a tenuous deal with the Sotelato government. Pales and Rizia were to stay on amicable terms, their trade agreements untouched.

She extended an invitation for you to join her in the Grand Duchy.

You decided..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`
  - -> `[51]`

### Węzeł `[473]`
Mówca: **Narrator**
> "One day, you opened your morning paper and saw the headlines. Queen Lucita had given birth to an heir, {RiziaDLCText.KingsSon}. Your son."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[474]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You sent her a letter of congratulations."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[475]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You begged her to be able to visit your child."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[476]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You ignored the news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[477]`
Mówca: **Narrator**
> "The Queen sent her regrets, telling you she wanted the prince to grow up without your influence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`
  - -> `[480]`

### Węzeł `[478]`
Mówca: **Narrator**
> "The Queen didn't respond to your letter. You had no way of knowing if she even received it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`
  - -> `[480]`

### Węzeł `[479]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You wondered how it came to this."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[480]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You tried to move on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[481]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_princebirth"))*
- **Efekt (`userScript`):** `PrologueImage("pe_princebirth");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`
  - -> `[475]`
  - -> `[476]`

### Węzeł `[482]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Coup_Leader_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`
  - -> `[484]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Coup_Leader_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Coup_Leader_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[485]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[486]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`
  - -> `[488]`

### Węzeł `[487]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Toras"] == true  or  Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[488]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Toras"] == true  or  Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[489]`
Mówca: **Narrator**
> "He explained to you that the new Toras regime had re-criminalized homosexuality almost immediately. 

As part of your clemency, you and he had received a special dispensation to be together. But you would still have to keep a low profile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`
  - -> `[491]`

### Węzeł `[490]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You cursed your family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[491]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It was better than living in fear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[492]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Toras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`
  - -> `[494]`

### Węzeł `[493]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Toras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[494]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Coup_Toras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[495]`
**[WYBÓR GRACZA: "1958|Topes|Seaside Life"]** — Mówca: **Narrator**
> "Though reluctant to move into the heart of Toras territory, Pabel eventually agreed with the plan.

You found a delightful house with a stunning sea view, nestled near historical landmarks.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`
  - -> `[259]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Epilogue_Exile_HugoSendsToExile == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`
  - -> `[498]`

### Węzeł `[497]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Epilogue_Exile_HugoSendsToExile == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Toras"] == true  or  Variable["RiziaDLC.Epilogue_Exile_HugoSendsToExile"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[498]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Epilogue_Exile_HugoSendsToExile == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Toras"] == true  or  Variable["RiziaDLC.Epilogue_Exile_HugoSendsToExile"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[499]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`
  - -> `[501]`

### Węzeł `[500]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[502]`
Mówca: **Narrator**
> "After serving your month-long sentence, you emerged from Iza City Prison to a different world. New monuments had risen, and the currency circulated without the familiar imprint of your face. 

As you stepped beyond the prison gates, there awaited..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[503]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...tried to relax, but couldn't stop following the news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[504]`
**[WYBÓR GRACZA: "1958|Iza|City Life"]** — Mówca: **Narrator**
> "Pabel was excited to move to the Brenas capital. It was the one place in Rizia where an underground gay scene still thrived, despite the government's ban.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[499]`
  - -> `[261]`
  - -> `[503]`

### Węzeł `[505]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCText.LenaTooltip = "Your granddaughter.")*
- **Efekt (`userScript`):** `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[506]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCText.LenaTooltip = "Your granddaughter.")*
- **Efekt (`userScript`):** `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[507]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCText.LenaTooltip = "Your granddaughter.")*
- **Efekt (`userScript`):** `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[508]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_GRACEMember == true && RiziaDLC.Birthday_Adarfo_Usurped == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`
  - -> `[510]`

### Węzeł `[509]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_GRACEMember == true && RiziaDLC.Birthday_Adarfo_Usurped == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true  and  Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[510]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_GRACEMember == true && RiziaDLC.Birthday_Adarfo_Usurped == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true  and  Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[511]`
Mówca: **Narrator**
> "Your mother reminded you that she'd been putting aside funds for a beachside villa in Kyrute."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[512]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You left as soon as you could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[513]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`
  - -> `[515]`

### Węzeł `[514]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_FuneralHappened"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[515]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_FuneralHappened == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_FuneralHappened"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[516]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`
  - -> `[518]`

### Węzeł `[517]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_FuneralHappened"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[518]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_FuneralHappened == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_FuneralHappened"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[519]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Ending_Revolution == true || RiziaDLC.Ending_Coup_Azaro == true || RiziaDLC.Ending_Coup_Reform == true || RiziaDLC.Ending_Coup_Sazon == true || RiziaDLC.Ending_Coup_Toras == true) && RiziaDLC.Reform_Success == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`
  - -> `[521]`

### Węzeł `[520]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Ending_Revolution == true || RiziaDLC.Ending_Coup_Azaro == true || RiziaDLC.Ending_Coup_Reform == true || RiziaDLC.Ending_Coup_Sazon == true || RiziaDLC.Ending_Coup_Toras == true) && RiziaDLC.Reform_Success == false)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Revolution"] == true  or  Variable["RiziaDLC.Ending_Coup_Azaro"] == true  or  Variable["RiziaDLC.Ending_Coup_Reform"] == true  or  Variable["RiziaDLC.Ending_Coup_Sazon"] == true  or  Variable["RiziaDLC.Ending_Coup_Toras"] == true)  and  Variable["RiziaDLC.Reform_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[521]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Ending_Revolution == true || RiziaDLC.Ending_Coup_Azaro == true || RiziaDLC.Ending_Coup_Reform == true || RiziaDLC.Ending_Coup_Sazon == true || RiziaDLC.Ending_Coup_Toras == true) && RiziaDLC.Reform_Success == false))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Ending_Revolution"] == true  or  Variable["RiziaDLC.Ending_Coup_Azaro"] == true  or  Variable["RiziaDLC.Ending_Coup_Reform"] == true  or  Variable["RiziaDLC.Ending_Coup_Sazon"] == true  or  Variable["RiziaDLC.Ending_Coup_Toras"] == true)  and  Variable["RiziaDLC.Reform_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[522]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_Unification == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`
  - -> `[524]`

### Węzeł `[523]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_Unification == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_Unification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[524]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Rizia_Unification == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[525]`
Mówca: **Narrator**
> "Vina wasted no time visiting. Life in Pales with Axel was flourishing, she said. Now that she had been crowned queen, talk of reunification was flowing once more. She extended an invitation to join her family and start anew together. 

You decided..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[526]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Monarch_Vina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`
  - -> `[528]`

### Węzeł `[527]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Monarch_Vina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Monarch_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[528]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Monarch_Vina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Monarch_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[529]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Abdication_Speech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`
  - -> `[531]`

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Abdication_Speech == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Abdication_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Abdication_Speech == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Abdication_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`
  - -> `[534]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[534]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_Estranged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[535]`
Mówca: **Narrator**
> "Vina rarely visited you. Now that you were no longer king, your bond felt weaker than ever.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[536]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`
  - -> `[538]`

### Węzeł `[537]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[538]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`
  - -> `[541]`

### Węzeł `[540]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[541]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[542]`
Mówca: **Narrator**
> "In the following days, Adarfo and his revolutionaries seized all governmental institutions in Porte Drazon and declared the end of the monarchy.

He praised your peaceful abdication as a defining moment in history."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[543]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The Kingdom was no more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[544]`
Mówca: **Narrator**
> "In the following days, the revolutionaries seized all governmental institutions in Porte Drazon and released Adarfo Sotelato from prison. 

After taking the leadership of the movement, he declared the official end of the monarchy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[545]`
Mówca: **Narrator**
> "In the following days, the revolutionaries seized all governmental institutions in Porte Drazon and declared the official end of the monarchy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The Kingdom was no more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[547]`
Mówca: **Narrator**
> "Without a clear leadership, the revolutionary government succumbed to infighting. 

The factions were getting more extreme."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[548]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Purges against the nobility began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[549]`
Mówca: **Narrator**
> "Amid this uncertainty, your mother implored you to flee, fearing for your safety in a country teetering on the edge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`
  - -> `[329]`

### Węzeł `[550]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "In spite of her warnings, you chose to stay."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[551]`
Mówca: **Narrator**
> "You decamped to one of your family guest houses near Porte Drazon.

After a few weeks in isolation, you couldn't take it anymore. You put on a disguise and went into the Old Town to get some air.

Suddenly, out of nowhere, you heard a shout: "We finally found you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[552]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: JumpFromPrison)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[553]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_KingdomDissolves_Revolution == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`
  - -> `[555]`

### Węzeł `[554]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_KingdomDissolves_Revolution == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_KingdomDissolves_Revolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[555]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_KingdomDissolves_Revolution == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_KingdomDissolves_Revolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[556]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Kingdom Dissolves Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[557]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Revolution == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`
  - -> `[559]`

### Węzeł `[558]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Revolution == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Revolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[559]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Revolution == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Revolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[560]`
Mówca: **Narrator**
> "People from all walks of life were applauding, crying, hugging each other.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`
  - -> `[561]`

### Węzeł `[561]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wished you could partake in their joy with them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[562]`
Mówca: **Narrator**
> "In the following days, Adarfo and his revolutionaries seized all governmental institutions in Porte Drazon and declared the end of the monarchy.

They arrested the members of the RNC and started preparing a new constitution with the help of a revolutionary committee."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_AbdicationPath == true || RiziaDLC.NatDes_FinalDecision_Abdicate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`
  - -> `[565]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_AbdicationPath == true || RiziaDLC.NatDes_FinalDecision_Abdicate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true  or  Variable["RiziaDLC.NatDes_FinalDecision_Abdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[565]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_AbdicationPath == true || RiziaDLC.NatDes_FinalDecision_Abdicate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true  or  Variable["RiziaDLC.NatDes_FinalDecision_Abdicate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[566]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Birthday_Adarfo_Usurped == true && RiziaDLC.Adarfo_AbdicationPath == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`
  - -> `[568]`

### Węzeł `[567]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Birthday_Adarfo_Usurped == true && RiziaDLC.Adarfo_AbdicationPath == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  and  Variable["RiziaDLC.Adarfo_AbdicationPath"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[568]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Birthday_Adarfo_Usurped == true && RiziaDLC.Adarfo_AbdicationPath == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  and  Variable["RiziaDLC.Adarfo_AbdicationPath"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[569]`
Mówca: **Narrator**
> "In the following days, Adarfo and his revolutionaries seized all governmental institutions in Porte Drazon and declared the end of the monarchy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[570]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_FinalDecision_Abdicate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`
  - -> `[572]`

### Węzeł `[571]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_FinalDecision_Abdicate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.NatDes_FinalDecision_Abdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`

### Węzeł `[572]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.NatDes_FinalDecision_Abdicate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.NatDes_FinalDecision_Abdicate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[573]`
Mówca: **Narrator**
> "In a surprising act of mercy, Sotelato held back the hardline revolutionaries, shielding you from extremist threats. 

Amid this uncertainty, your mother implored you and Lucita to join her in exile, fearing for your family's safety in a country teetering on the edge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[574]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Birthday_Adarfo_Usurped == true || RiziaDLC.NatDes_FinalDecision_Abdicate == true || RiziaDLC.Adarfo_AbdicationPath == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`
  - -> `[576]`

### Węzeł `[575]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Birthday_Adarfo_Usurped == true || RiziaDLC.NatDes_FinalDecision_Abdicate == true || RiziaDLC.Adarfo_AbdicationPath == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  or  Variable["RiziaDLC.NatDes_FinalDecision_Abdicate"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[576]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Birthday_Adarfo_Usurped == true || RiziaDLC.NatDes_FinalDecision_Abdicate == true || RiziaDLC.Adarfo_AbdicationPath == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  or  Variable["RiziaDLC.NatDes_FinalDecision_Abdicate"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[577]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Birthday_Adarfo_Usurped == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`
  - -> `[579]`

### Węzeł `[578]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Birthday_Adarfo_Usurped == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[579]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Birthday_Adarfo_Usurped == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[580]`
Mówca: **Narrator**
> "Sotelato held back the hardline revolutionaries, shielding you from the worst of the threats. 

While Hugo and the most prominent noble house members remained in detention, your mother and Vina were released. 

On seeing them, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`
  - -> `[585]`
  - -> `[587]`
  - -> `[590]`
  - -> `[622]`

### Węzeł `[581]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`
  - -> `[583]`

### Węzeł `[582]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[583]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Vina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`

### Węzeł `[584]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...begged for forgiveness."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[585]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...cried with relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[586]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...missed Lucita more than ever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[587]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`
  - -> `[589]`

### Węzeł `[588]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[589]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[590]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wondered if your family would ever be truly safe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[591]`
Mówca: **Narrator**
> "Estela still didn't understand why you had collaborated with the revolutionaries behind her back. It would take time to heal the mistrust between you.

But for now, she feared for your life above all else. She urged you to flee the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[329]`

### Węzeł `[592]`
Mówca: **Narrator**
> "Sotelato held back the hardline revolutionaries, shielding you from the worst of the threats. 

While Hugo and the most prominent noble house members remained in detention, your mother was released. 

On seeing her, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`
  - -> `[585]`
  - -> `[587]`
  - -> `[590]`
  - -> `[622]`

### Węzeł `[593]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_GRACEMember == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`
  - -> `[595]`

### Węzeł `[594]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_GRACEMember == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]`

### Węzeł `[595]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_GRACEMember == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`

### Węzeł `[596]`
Mówca: **Narrator**
> "Estela was staying at a hotel in Kyrute. She told you that she had enough funds squirreled away to buy a beachside villa in the area."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[597]`
Mówca: **Narrator**
> "Estela and Vina were staying at a hotel in Kyrute. Your mother told you that she had enough funds squirreled away to buy a beachside villa in the area. 

On the other hand, Queen Beatrice had offered you and your family a safe haven in Rumburg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[175]`

### Węzeł `[598]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`
  - -> `[600]`

### Węzeł `[599]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`

### Węzeł `[600]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[601]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Then democracy arrived in the kingdom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`

### Węzeł `[602]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_newgovernment"))*
- **Efekt (`userScript`):** `PrologueImage("pe_newgovernment");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`

### Węzeł `[603]`
Mówca: **Narrator**
> "The first ever general election in Rizia was nothing short of a spectacle. With an impressive 70% turnout, the people demonstrated their hunger for change and voted overwhelmingly in favor of the RPP.

Manus Sazon promoted new laws aimed at raising living standards and positioning Rizia at the forefront of global innovation.

In his inaugural speech, he hailed a new era while praising the Royal Family and its legacy.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[186]`
  - -> `[184]`

### Węzeł `[604]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Birthday_Adarfo_Usurped == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`
  - -> `[606]`

### Węzeł `[605]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Birthday_Adarfo_Usurped == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[606]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Birthday_Adarfo_Usurped == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[607]`
Mówca: **Narrator**
> "In the meantime, Vina had gone back to Pales.

She and Axel had negotiated a tenuous deal with the Sotelato government. Pales and Rizia were to stay on amicable terms, their trade agreements untouched.

Despite everything that had happened, they extended an invitation for you to join them.

You decided..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`
  - -> `[51]`

### Węzeł `[608]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`
  - -> `[610]`

### Węzeł `[609]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[610]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`

### Węzeł `[611]`
Mówca: **Narrator**
> "In a surprising act of mercy, Sotelato held back the hardline revolutionaries, shielding you from extremist threats. 

Amid this uncertainty, your mother implored you and Pabel to join her in exile, fearing for your family's safety in a country teetering on the edge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[612]`
Mówca: **Narrator**
> "Sotelato held back the hardline revolutionaries, shielding you from extremist threats. 

Amid this uncertainty, your mother implored you flee the country, fearing for your safety in a country teetering on the edge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[613]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[329]`

### Węzeł `[614]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`
  - -> `[616]`

### Węzeł `[615]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[616]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[617]`
Mówca: **Narrator**
> "In a surprising act of mercy, Sotelato held back the hardline revolutionaries, shielding you from extremist threats. 

Amid this uncertainty, your mother implored you to join her in exile, fearing for your family's safety in a country teetering on the edge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[618]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`
  - -> `[620]`

### Węzeł `[619]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[620]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[621]`
Mówca: **Narrator**
> "Sotelato held back the hardline revolutionaries, shielding you from the worst of the threats. 

While Hugo and the most prominent noble house members remained in detention, your mother, Vina and Pabel were released. 

On seeing them, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`
  - -> `[585]`
  - -> `[590]`
  - -> `[622]`

### Węzeł `[622]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...tried to explain your side of the story."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[623]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_RelationshipPublic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`
  - -> `[625]`

### Węzeł `[624]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_RelationshipPublic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`

### Węzeł `[625]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_RelationshipPublic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[626]`
Mówca: **Narrator**
> "Sotelato held back the hardline revolutionaries, shielding you from the worst of the threats. 

While Hugo and the most prominent noble house members remained in detention, your mother and Pabel were released.

On seeing them, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`
  - -> `[585]`
  - -> `[590]`
  - -> `[622]`

### Węzeł `[627]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == false && RiziaDLC.BirthdayGathering_Invited_Vina == false && RiziaDLC.Relations_Pabel_Together == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`
  - -> `[629]`

### Węzeł `[628]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == false && RiziaDLC.BirthdayGathering_Invited_Vina == false && RiziaDLC.Relations_Pabel_Together == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == false  and  Variable["RiziaDLC.Relations_Pabel_Together"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[629]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == false && RiziaDLC.BirthdayGathering_Invited_Vina == false && RiziaDLC.Relations_Pabel_Together == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == false  and  Variable["RiziaDLC.Relations_Pabel_Together"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`

### Węzeł `[630]`
Mówca: **Narrator**
> "Your loved ones still didn't understand why you had collaborated with the revolutionaries behind their back. It would take time to heal the mistrust between you.

But for now, Estela feared for your life above all else. She urged you to flee the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[329]`

### Węzeł `[631]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Vina_MarriageDecision_Axel == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`
  - -> `[633]`

### Węzeł `[632]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Vina_MarriageDecision_Axel == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[633]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Vina_MarriageDecision_Axel == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[634]`
Mówca: **Narrator**
> "Estela was staying at a hotel in Kyrute. She told you that she had enough funds squirreled away to buy a beachside villa in the area. 

On the other hand, Queen Beatrice had offered you and your family a safe haven in Rumburg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[175]`

### Węzeł `[635]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Vina_MarriageDecision_Axel == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`
  - -> `[637]`

### Węzeł `[636]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Vina_MarriageDecision_Axel == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[637]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Vina_MarriageDecision_Axel == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[638]`
Mówca: **Narrator**
> "Estela and Vina were staying at a hotel in Kyrute. Your mother told you that she had enough funds squirreled away to buy a beachside villa in the area."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[639]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Revolution == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`
  - -> `[641]`

### Węzeł `[640]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Revolution == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Revolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[641]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Revolution == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Revolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[642]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Decided In Epilogue Exile Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `426` (*Rizia/Exile*), Węzeł `[7]`

### Węzeł `[643]`
Mówca: **Narrator**
> "Your mother reminded you that she'd been putting aside funds for a beachside villa in Kyrute.

Alternately, Queen Beatrice had offered you a safe haven in Rumburg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[175]`

### Węzeł `[644]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`
  - -> `[646]`

### Węzeł `[645]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[646]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_PartyPrince == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[647]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...insights gleaned from your time as Rizia's monarch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[648]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == true || RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`
  - -> `[650]`

### Węzeł `[649]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == true || RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]`

### Węzeł `[650]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_Estranged == true || RiziaDLC.Vina_Escapes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[651]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...you swore you'd be a better father the second time around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[652]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]`
  - -> `[654]`

### Węzeł `[653]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]`

### Węzeł `[654]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_Estranged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[655]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Monarch_Vina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`
  - -> `[657]`

### Węzeł `[656]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Monarch_Vina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Monarch_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`

### Węzeł `[657]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Monarch_Vina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Monarch_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[658]`
Mówca: **Narrator**
> "Queen Vina visited with her new baby daughter, Lena. She looked nothing like Rico, but nobody said anything.

In that moment of familial joy, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`
  - -> `[309]`

### Węzeł `[659]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCText.LenaTooltip = "Your granddaughter.")*
- **Efekt (`userScript`):** `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`

### Węzeł `[660]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Manus_Arrested == false && RiziaDLC.Manus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`
  - -> `[662]`

### Węzeł `[661]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Manus_Arrested == false && RiziaDLC.Manus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  and  Variable["RiziaDLC.Manus_Arrested"] == false  and  Variable["RiziaDLC.Manus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[662]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Manus_Arrested == false && RiziaDLC.Manus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  and  Variable["RiziaDLC.Manus_Arrested"] == false  and  Variable["RiziaDLC.Manus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`

### Węzeł `[663]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`
  - -> `[665]`

### Węzeł `[664]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[665]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.AxelVina_Married_Official == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`

### Węzeł `[666]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`
  - -> `[668]`

### Węzeł `[667]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == true  and  Variable["RiziaDLC.Rico_Executed"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[668]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == true  and  Variable["RiziaDLC.Rico_Executed"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[669]`
Mówca: **Narrator**
> "Through the grapevine, you heard that Vina and Axel had a child now: Lena, named after her grandmother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`
  - -> `[676]`
  - -> `[677]`

### Węzeł `[670]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCText.LenaTooltip = "Your granddaughter.")*
- **Efekt (`userScript`):** `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]`

### Węzeł `[671]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCText.LenaTooltip = "Your granddaughter.")*
- **Efekt (`userScript`):** `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]`

### Węzeł `[672]`
Mówca: **Narrator**
> "Through the grapevine, you heard that Vina and Manus had a child now: Lena, named after her grandmother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`
  - -> `[676]`
  - -> `[677]`

### Węzeł `[673]`
Mówca: **Narrator**
> "Through the grapevine, you heard that Vina, free from the burden of carrying the Toras name forward, had filed for divorce from Rico."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`
  - -> `[676]`
  - -> `[677]`

### Węzeł `[674]`
Mówca: **Narrator**
> "Through the grapevine, you heard that Vina, free from the burden of carrying the Toras name forward, had embarked on a journey around the world."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`
  - -> `[676]`
  - -> `[677]`

### Węzeł `[675]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You were happy for her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[676]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Her absence stung."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[677]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]`
  - -> `[679]`

### Węzeł `[678]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[679]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[680]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You were too wrapped up in fatherhood to care."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[681]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You ached to feel important again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[682]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`
  - -> `[684]`

### Węzeł `[683]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]`

### Węzeł `[684]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_Estranged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[685]`
Mówca: **Narrator**
> "In a short note, your daughter expressed her regret for the way things had turned out.

She enclosed a self-portrait Lena had drawn in art class."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]`

### Węzeł `[686]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`
  - -> `[688]`

### Węzeł `[687]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[688]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`

### Węzeł `[689]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "A crown was on her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[690]`
Mówca: **Narrator**
> "In a short note, your daughter expressed her regret for the way things had turned out.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`
  - -> `[430]`

### Węzeł `[691]`
Mówca: **Narrator**
> "As you flipped through the typewritten pages, a spark reignited within you for politics. 

Motivated, you resolved to pen your own thesis, asking the Iza University professors for guidance.

As a scholar, you focused on..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`
  - -> `[286]`
  - -> `[289]`
  - -> `[288]`

### Węzeł `[692]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "A long month passed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[693]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Rizia_Sotelato");)*
- **Efekt (`userScript`):** `UnlockAchievement("Rizia_Sotelato");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
