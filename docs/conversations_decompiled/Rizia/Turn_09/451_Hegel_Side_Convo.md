# Rizia/Turn 9/Hegel Side Convo

- **ID konwersacji:** `451`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/451_Hegel_Side_Convo.md`
- **Liczba węzłów dialogowych:** 268
- **Liczba wyborów gracza:** 50

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[78]** Emmerich Hegel (R)
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Valgsland_Alliance`
- `RiziaDLC.CountryRelation_Valgsland_Unfriendly`
- `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf`
- `RiziaDLC.Hegel_OpenToRevolution`
- `RiziaDLC.HouseOfDelegates_Abolished`
- `RiziaDLC.MITZ_LespiaScrewedOverRizia`
- `RiziaDLC.MITZ_Renegotiation_Failed`
- `RiziaDLC.Morella_Sabotage_Plans_Discovered`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO`
- `RiziaDLC.Reform_Movement_Grows`
- `RiziaDLC.Reform_Movement_Leader_Adarfo`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Reform_TalkToAdarfo_AskedManus`
- `RiziaDLC.Situation_Diplomacy_GlobalImage_Bad`
- `RiziaDLC.ToldAboutComradeVina`
- `RiziaDLC.Trait_CommieKing`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Turn05_ITZVote_Nationalization`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_MarriageDecision_Axel`
- `RiziaDLC.Vina_MarriageDecision_Rico`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Lespia_NegotiatingPower`
- `RiziaDLC.Diplomacy_Valgsland_NegotiatingPower`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP`
- `RiziaDLC.Resources_Budget`
- `RiziaDLCSupport.FactionReports_Turn09_ATO_CondemnsCSPCaleqabiz`
- `RiziaDLCSupport.FactionReports_Turn09_GRACE_CondemnsCSPCaleqabiz`
- `RiziaDLCSupport.Journal_Turn09_MITZ_CaleqebizToValgsland`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[450] Rizia/Turn 9/FPnT_MITZ_BoardMeeting** (../Turn_09/450_FPnT_MITZ_BoardMeeting.md), Węzeł `[347]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 12
- **Węzły modyfikujące stan gry:** 4

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Resources_Budget`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[173]` (Paskal Beniwoll): `Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP"] = true; Variable["RiziaDLC.Resources...`
- Węzeł `[191]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Journal_Turn09_MITZ_CaleqebizToValgsland"] = true;`
- Węzeł `[192]` (Paskal Beniwoll): `RemoveConversant("Elena Werner");`
- Węzeł `[266]` (Paskal Beniwoll): `AddTokenStatusImmediately("Rizia_City_Qabiz","Rizia_City_ValgslandPort");`

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
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `450` (*Rizia/Turn 9/FPnT_MITZ_BoardMeeting*), Węzeł `[347]`

### Węzeł `[3]`
Mówca: **Narrator**
> "The aides quickly readied a side room for us. We stepped in and sat across from one another."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_LespiaScrewedOverRizia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_LespiaScrewedOverRizia == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_LespiaScrewedOverRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[19]`
  - -> `[24]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_LespiaScrewedOverRizia == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_LespiaScrewedOverRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will be direct. Are you going to support Lespia stealing our share in the MITZ?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Hegel barked out a laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_ITZVote_Nationalization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_ITZVote_Nationalization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_ITZVote_Nationalization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[12]`
Mówca: **Emmerich Hegel (R)**
> ""I warned you that the Lespians were a menace to the Trade Zone. You didn't listen to me, and this is your reward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[13]`
Mówca: **Emmerich Hegel (R)**
> ""In the end, it is Morella's decision, not mine. I am obligated to support any nationalization plan that Saltana puts forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Emmerich Hegel (R)**
> ""And even if I wasn't... your kingdom is arguably a greater threat than Lespia at this point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[66]`
  - -> `[59]`

### Węzeł `[18]`
Mówca: **Emmerich Hegel (R)**
> ""I am sorry. But that's the way it has to be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Chancellor Hegel, I must insist that you do not vote for the latest proposal. It was amended without Rizia's knowledge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true && RiziaDLC.ToldAboutComradeVina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true && RiziaDLC.ToldAboutComradeVina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true  and  Variable["RiziaDLC.ToldAboutComradeVina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true && RiziaDLC.ToldAboutComradeVina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true  and  Variable["RiziaDLC.ToldAboutComradeVina"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[23]`
Mówca: **Emmerich Hegel (R)**
> ""Obviously, I am against Alvarez and his cronies snapping up a bigger share of South Merkopa's largest gold resource.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just out of curiosity, how are you planning on voting today?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know you are helping Saltana stoke internal rebellion in my kingdom. I just wanted to tell you that I don't care.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[26]`
Mówca: **Emmerich Hegel (R)**
> ""If I knew where she was, why the hell would I tell you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[27]`
Mówca: **Emmerich Hegel (R)**
> ""From what I have heard, Vina Toras fled Rizia to escape the archaic marriage bond being forced upon her by her father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Emmerich Hegel (R)**
> ""Don't worry. The chances of the new proposal passing are roughly that of a snowball in hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[67]`
  - -> `[68]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you know where my daughter is?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[33]`
Mówca: **Emmerich Hegel (R)**
> ""But you, Mr. Toras, are arguably a greater threat than Alvarez at this point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[59]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[37]`
Mówca: **Narrator**
> "He laughed without mirth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_Failed == true && RiziaDLC.Reform_Movement_Grows == true && RiziaDLC.Morella_Sabotage_Plans_Discovered == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_Failed == true && RiziaDLC.Reform_Movement_Grows == true && RiziaDLC.Morella_Sabotage_Plans_Discovered == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true  and  Variable["RiziaDLC.Reform_Movement_Grows"] == true  and  Variable["RiziaDLC.Morella_Sabotage_Plans_Discovered"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[42]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_Renegotiation_Failed == true && RiziaDLC.Reform_Movement_Grows == true && RiziaDLC.Morella_Sabotage_Plans_Discovered == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true  and  Variable["RiziaDLC.Reform_Movement_Grows"] == true  and  Variable["RiziaDLC.Morella_Sabotage_Plans_Discovered"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[41]`
Mówca: **Emmerich Hegel (R)**
> ""From what I have heard, Vina Toras was being kept in a golden cage -- allowed neither power nor the ability to choose her own husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You and the Morellan prime minister must cease your provocations at once. The last thing any of us wants is bloodshed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're still planning on voting the same way, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Narrator**
> "He looked at me sternly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Emmerich Hegel (R)**
> ""Why are you asking me? You'll find out in five minutes, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`
  - -> `[56]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Emmerich Hegel (R)**
> ""Don't worry, Mr. Toras. Everything will go exactly as planned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`
  - -> `[53]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How's everything back home?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Exactly as *who* planned?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. That's all I wanted to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What will it take for you to give me some extra reassurance?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good point. Let's head to the vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If your mind has changed... what will it take to change it back?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not disrespect the King of Rizia, Chancellor. I am warning you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please. There must be something Rizia can offer you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is there anything I can do in exchange for a little extra reassurance?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How can you say that? I thought the West was your greatest nemesis.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Emmerich Hegel (R)**
> ""It is not the West that we in Valgsland are fighting, Mr. Toras. It is the boot on the necks of the oppressed everywhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Emmerich Hegel (R)**
> ""And with your insistence on waging an unjust war, Rizia is wearing the biggest boot of all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[78]`
  - -> `[81]`
  - -> `[82]`
  - -> `[94]`

### Węzeł `[65]`
Mówca: **Emmerich Hegel (R)**
> ""And with your violent actions in Zille, Rizia is wearing the biggest boot of all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[81]`
  - -> `[82]`
  - -> `[94]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A pity. But I understand. I will not try to change your mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's great to know. Let's head to the vote, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you're saying there's no chance. Zero.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[69]`
Mówca: **Narrator**
> "He gave a curt nod. We left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, if the shoe fits...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[2]`

### Węzeł `[71]`
Mówca: **Narrator**
> "He folded his arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[72]`
Mówca: **Emmerich Hegel (R)**
> ""That's very wise of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Emmerich Hegel (R)**
> ""Shall we get this over with?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Narrator**
> "He gestured to the door, and we left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[75]`
Mówca: **Narrator**
> "He continued to wear an inscrutable expression."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Emmerich Hegel (R)**
> ""Let's get this over with, shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Narrator**
> "We left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't understand. There have been extenuating circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you? How much damage have you caused by encouraging societies to rip each other apart in the name of your 'revolution'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Narrator**
> "He rolled his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[84]`
Mówca: **Emmerich Hegel (R)**
> ""A muscle must tear before it can grow stronger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Emmerich Hegel (R)**
> ""You'll find that out for yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please. Isn't there anything my kingdom can do to sway your vote?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[87]`
Mówca: **Emmerich Hegel (R)**
> ""Mr. Toras, I have no idea what you're talking about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[88]`
Mówca: **Emmerich Hegel (R)**
> ""Mr. Toras, I have no idea what you're talking about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Emmerich Hegel (R)**
> ""With your campaign of terror, you are sowing the seeds for your kingdom's own demise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Emmerich Hegel (R)**
> ""But I am glad that you have accepted the inevitability of revolution. All kingdoms must, in time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's all in the service of reforms that will transform Rizia. You'll see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Emmerich Hegel (R)**
> ""All I see is a deranged bull, charging at the people in the stands instead of the man waving the flag.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[99]`
Mówca: **Emmerich Hegel (R)**
> ""Your monarchy has sown the seeds of its own revolution. They did not need our help to sprout.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[100]`
  - -> `[116]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop lying. You've been plotting the downfall of Rizia since you lost Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Help me quell this threat, and we will defeat the West together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Emmerich Hegel (R)**
> ""You, King Romus Toras, want to defeat the West?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[109]`
Mówca: **Emmerich Hegel (R)**
> ""You expect me to believe that after you sold your island to ATO?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Emmerich Hegel (R)**
> ""I see no use in speaking to you further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[111]`
Mówca: **Narrator**
> "He folded his arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Emmerich Hegel (R)**
> ""If you are serious about that, there is precisely one thing you can offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[113]`
Mówca: **Emmerich Hegel (R)**
> ""There is precisely one thing you can offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[114]`
Mówca: **Emmerich Hegel (R)**
> ""Your island, Caleqabiz. Allow Valgsland and the CSP to use it as a base of operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[115]`
Mówca: **Emmerich Hegel (R)**
> ""You have a very vivid imagination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are a pragmatic man, Mr. Hegel. You know that world leaders do not have to agree on everything to help each other out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[120]`
Mówca: **Emmerich Hegel (R)**
> ""You and I do not even agree on what constitutes basic decency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[121]`
Mówca: **Emmerich Hegel (R)**
> ""We will suffer through today. And then our paths will not cross again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[125]`
Mówca: **Emmerich Hegel (R)**
> ""You have sold your kingdom out to Lespia and ATO. No offer under the sun would convince me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[129]`
Mówca: **Emmerich Hegel (R)**
> ""Good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[130]`
Mówca: **Narrator**
> "He huffed impatiently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Emmerich Hegel (R)**
> ""Good, as it happens. Valgsland gained a new ally recently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[135]`
Mówca: **Emmerich Hegel (R)**
> ""I didn't come here for small talk, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[136]`
Mówca: **Emmerich Hegel (R)**
> ""Now you want to make a deal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[137]`
Mówca: **Emmerich Hegel (R)**
> ""You and your crown of stolen gold... They are coming for it, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[138]`
Mówca: **Emmerich Hegel (R)**
> ""You don't need it. You can rely on my cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Emmerich Hegel (R)**
> ""But if it's a closer bond with Valgsland you want, I do have one offer for you...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[143]`
Mówca: **Narrator**
> "He smiled mysteriously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Emmerich Hegel (R)**
> ""You sold your own island to Lespia and ATO. No offer under the sun would convince me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[148]`
Mówca: **Emmerich Hegel (R)**
> ""Entirely out of the goodness of your heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[153]`
  - -> `[154]`
  - -> `[155]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Emmerich Hegel (R)**
> ""You'll be compensated fairly, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[159]`
  - -> `[163]`
  - -> `[155]`

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're insane. No amount of money is worth that much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[154]`
**[WYBÓR GRACZA: ""Fine. If that's what it will take, Caleqabiz will be yours." [+4 Budget]"]** — Mówca: **Player_Romus**
> ""Fine. If that's what it will take, Caleqabiz will be yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My kingdom's claim to the Aureus gas field rests on the resource's proximity to Caleqabiz. I will not weaken it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[159]`
**[WYBÓR GRACZA: ""Our kingdom could use the extra income. Why not? Let's make a deal." [+4 Budget]"]** — Mówca: **Player_Romus**
> ""Our kingdom could use the extra income. Why not? Let's make a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The CSP already has its hooks in Morella. Now you want to position yourselves on our other side? Never.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[161]`
**[WYBÓR GRACZA: ""Only if you call me 'Comrade Romus'." [+4 Budget]"]** — Mówca: **Player_Romus**
> ""Only if you call me 'Comrade Romus'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Narrator**
> "He snorted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[166]`
Mówca: **Emmerich Hegel (R)**
> ""We have a deal, comrade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[167]`
Mówca: **Emmerich Hegel (R)**
> ""Suit yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[168]`
Mówca: **Emmerich Hegel (R)**
> ""A pleasure cooperating with you, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[169]`
Mówca: **Narrator**
> "He reached out and shook my hand firmly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Emmerich Hegel (R)**
> ""Then my vote is yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[171]`
Mówca: **Narrator**
> "He reached out and shook my hand firmly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[172]`
Mówca: **Emmerich Hegel (R)**
> ""I assume we're done here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`
  - -> `[190]`
  - -> `[179]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP = true; 
RiziaDLC.Resources_Budget += 4; 
RiziaDLC.PersonalValue_Malenyevist += 3;
RiziaDLC.Diplomacy_Valgsland_NegotiatingPower += 3; RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 3;
RiziaDLCSupport.FactionReports_Turn09_ATO_CondemnsCSPCaleqabiz = true;
RiziaDLCSupport.FactionReports_Turn09_GRACE_CondemnsCSPCaleqabiz = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP"] = true;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 4;
Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 3;
Variable["RiziaDLC.Diplomacy_Valgsland_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Valgsland_NegotiatingPower"] + 3;
Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] - 3;
Variable["RiziaDLCSupport.FactionReports_Turn09_ATO_CondemnsCSPCaleqabiz"] = true;
Variable["RiziaDLCSupport.FactionReports_Turn09_GRACE_CondemnsCSPCaleqabiz"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[174]`
Mówca: **Narrator**
> "He shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Emmerich Hegel (R)**
> ""That was my idea. I don't have any others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This had better be worth it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, let's get this over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[178]`
Mówca: **Emmerich Hegel (R)**
> ""That's not for me to judge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true && RiziaDLC.ToldAboutComradeVina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true && RiziaDLC.ToldAboutComradeVina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true  and  Variable["RiziaDLC.ToldAboutComradeVina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true && RiziaDLC.ToldAboutComradeVina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true  and  Variable["RiziaDLC.ToldAboutComradeVina"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you know where my daughter is?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[183]`
Mówca: **Emmerich Hegel (R)**
> ""If I knew where she was, why the hell would I tell you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[184]`
Mówca: **Emmerich Hegel (R)**
> ""From what I have heard, Vina Toras fled Rizia to escape the archaic marriage bond being forced upon her by her father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Emmerich Hegel (R)**
> ""From what I have heard, Vina Toras was being kept in a golden cage -- allowed neither the ability to advance her career nor choose her own life partner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[189]`
Mówca: **Narrator**
> "He laughed without mirth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your flexibility, Chancellor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn09_MITZ_CaleqebizToValgsland = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn09_MITZ_CaleqebizToValgsland"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Elena Werner"))*
- **Efekt (`userScript`):** `RemoveConversant("Elena Werner");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[193]`
  - -> `[20]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[43]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want the truth. Is Valgsland aiding the new revolutionary movement in Rizia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Narrator**
> "He spoke calmly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Emmerich Hegel (R)**
> ""Revolutions cannot be started from the outside, Mr. Toras. Your people planted the seeds of their own liberation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[203]`
  - -> `[222]`
  - -> `[205]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hegel_OpenToRevolution == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hegel_OpenToRevolution == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hegel_OpenToRevolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hegel_OpenToRevolution == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hegel_OpenToRevolution"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We discussed this. You yourself said the time would be right someday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Seeds don't grow without nourishment. You've been watering them from afar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want those seeds to sprout as much as you do. I am working with this movement, not against it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true || RiziaDLC.Reform_TalkToAdarfo_AskedManus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true || RiziaDLC.Reform_TalkToAdarfo_AskedManus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.Reform_TalkToAdarfo_AskedManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Path == true || RiziaDLC.Reform_TalkToAdarfo_AskedManus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.Reform_TalkToAdarfo_AskedManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[208]`
Mówca: **Emmerich Hegel (R)**
> ""I am skeptical that even an 'enlightened' monarch such as yourself would be willing to hand the reins of government to the working class.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Emmerich Hegel (R)**
> ""But I'm ready to be positively surprised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Narrator**
> "He smiled conspiratorially."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[214]`
Mówca: **Emmerich Hegel (R)**
> ""Did I? I don't recall. It was very late at night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Emmerich Hegel (R)**
> ""But I am happy to see that your politician -- Sotelato, was it? -- has finally put the Rizian working class on a path to self-determination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseOfDelegates_Abolished == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If your government is meddling with my kingdom's affairs in any way, you will pay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Emmerich Hegel (R)**
> ""Duly noted. Is that all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[227]`

### Węzeł `[221]`
Mówca: **Emmerich Hegel (R)**
> ""But if the time were ever right for revolution in your country, it would be now, after you dissolved your father's sad attempt at a parliament.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Drop the high-and-mighty act, Chancellor. The CSP would love a bigger foothold in South Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_LespiaScrewedOverRizia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_LespiaScrewedOverRizia == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_LespiaScrewedOverRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_LespiaScrewedOverRizia == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_LespiaScrewedOverRizia"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I heard you might be changing your vote today?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Let's get this board vote over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[228]`
Mówca: **Emmerich Hegel (R)**
> ""As have you, from what I gather.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[232]`
Mówca: **Emmerich Hegel (R)**
> ""Rizia would have much to gain from that as well, you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true || RiziaDLC.Trait_CommieKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true || RiziaDLC.Trait_CommieKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.Trait_CommieKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Path == true || RiziaDLC.Trait_CommieKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.Trait_CommieKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Emmerich Hegel (R)**
> ""I don't have the time or inclination to listen to your accusations. We've got a vote to sit through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[237]`
Mówca: **Emmerich Hegel (R)**
> ""I only hope that whenever your new government comes to fruition, it has the sense to reverse that decision. Until then, I don't have a thing to say to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We once spoke of big changes coming to Rizia. I believe the time is now right for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hegel_OpenToRevolution == true && (RiziaDLC.Reform_Path == true || RiziaDLC.Reform_TalkToAdarfo_AskedManus == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hegel_OpenToRevolution == true && (RiziaDLC.Reform_Path == true || RiziaDLC.Reform_TalkToAdarfo_AskedManus == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hegel_OpenToRevolution"] == true  and  (Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.Reform_TalkToAdarfo_AskedManus"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hegel_OpenToRevolution == true && (RiziaDLC.Reform_Path == true || RiziaDLC.Reform_TalkToAdarfo_AskedManus == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hegel_OpenToRevolution"] == true  and  (Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.Reform_TalkToAdarfo_AskedManus"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[242]`
Mówca: **Narrator**
> "The hint of a smile appeared on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Emmerich Hegel (R)**
> ""Yes. I believe so as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[247]`
Mówca: **Emmerich Hegel (R)**
> ""It's heartening to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Emmerich Hegel (R)**
> ""Although I am worried that without the workers' movement leading the charge, the 'new' Rizia will suspiciously resemble the old one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`
  - -> `[251]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't need to worry about that. Just know that we'll be open to closer ties with Valgsland going forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I assure you these changes are being made with the working class in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That is the least of my concerns. I'll be lucky to pass even a bare-bones version of reform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[252]`
Mówca: **Emmerich Hegel (R)**
> ""If it's closer ties with Valgsland you want, there is something I can offer you right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[256]`
Mówca: **Emmerich Hegel (R)**
> ""I should hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[257]`
Mówca: **Emmerich Hegel (R)**
> ""You are the monarch, are you not? Exercise your power while you still can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[258]`
Mówca: **Emmerich Hegel (R)**
> ""How can you say that when your most strategic island has been leased to our ideological rival?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Caleqabiz Valgsland Sale)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Caleqabiz Valgsland Sale])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Caleqabiz Valgsland Sale])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "Hegel barked out a laugh."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[263]`
Mówca: **Emmerich Hegel (R)**
> ""Indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[264]`
Mówca: **Emmerich Hegel (R)**
> ""While you are still monarch of Rizia, there is one thing I would ask of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Caleqabiz Valgsland Sale])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatusImmediately("Rizia_City_Qabiz", "Rizia_City_ValgslandPort");)*
- **Efekt (`userScript`):** `AddTokenStatusImmediately("Rizia_City_Qabiz","Rizia_City_ValgslandPort");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[267]`
Mówca: **Emmerich Hegel (R)**
> ""I would take you to task for leasing your most strategic island to our direct rivals in Lespia. But I'll save that conversation for your predecessor, whoever he or she may be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
