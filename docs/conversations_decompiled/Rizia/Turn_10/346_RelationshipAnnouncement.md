# Rizia/Turn 10/RelationshipAnnouncement

- **ID konwersacji:** `346`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/346_RelationshipAnnouncement.md`
- **Liczba węzłów dialogowych:** 606
- **Liczba wyborów gracza:** 114

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras`
- `RiziaDLC.BirthdayGathering_ViolentAction`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard`
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.BrunoDog_SleepsInBed`
- `RiziaDLC.Hugo_Arrested`
- `RiziaDLC.Hugo_Resigned`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Lucita_RelationshipPublic`
- `RiziaDLC.Pabel_Gone`
- `RiziaDLC.Pabel_Lord`
- `RiziaDLC.Pabel_RelationshipPublic`
- `RiziaDLC.Pabel_WeddingDate`
- `RiziaDLC.Pales_Rizia_Unification`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Diplomacy_Intermerkopum`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Prologue_Scar`
- `RiziaDLC.PromiseToAbdicate`
- `RiziaDLC.Reform_Diplomatic`
- `RiziaDLC.Reform_Legislative_HouseOfLords`
- `RiziaDLC.Reform_Monarch_Symbolic`
- `RiziaDLC.Reform_Monarch_Veto`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Rico_Deposed`
- `RiziaDLC.Rico_PoliceChief_PorteDrazon`
- `RiziaDLC.Sal_Arrested`
- `RiziaDLC.Situation_Law_Media_Censored`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Taddeus_Arrested`
- `RiziaDLC.Taddeus_Deranked`
- `RiziaDLC.Taddeus_Disgraced`
- `RiziaDLC.Taddeus_Executed`
- `RiziaDLC.Theocracy_Full`
- `RiziaDLC.Titus_Arrested`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Turn05_MurderInvest_SuspectEstela`
- `RiziaDLC.Unrest_NatDes_Happened`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_Wedding_Happened`
- `RiziaDLC.War_Pales_Won`
- `RiziaDLC.ZilleReferendum_ArmedResistance`
- `RiziaDLC.ZilleReferendum_Interfere_Army`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate`
- `RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro`
- `RiziaDLC.BirthdayGathering_ViolentAction`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians`
- `RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike`
- `RiziaDLC.Country_PublicOpinion`
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.FireRufusGragg`
- `RiziaDLC.Lucita_Pregnant`
- `RiziaDLC.Pabel_RelationshipPublic`
- `RiziaDLCSupport.Journal_Turn10_Lucita_Pregnant`
- `RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate`
- `RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic`
- `RiziaDLCSupport.News_Turn10_RH_Gossip_KingHomosexual_Butler`
- `RiziaDLCSupport.News_Turn10_RH_Gossip_KingHomosexual_Lord`
- `RiziaDLCSupport.News_Turn10_RH_Gossip_KingsNewChild`
- `RiziaDLCSupport.News_Turn10_RH_Gossip_KingsNewWifeAndChild`
- `RiziaDLCSupport.News_Turn10_RH_KingHomosexual_Butler`
- `RiziaDLCSupport.News_Turn10_RH_KingHomosexual_Lord`
- `RiziaDLCSupport.News_Turn10_V_KingOpenlyGay_Butler`
- `RiziaDLCSupport.News_Turn10_V_KingOpenlyGay_Lord`
- `RiziaDLCText.LucitaToPlayer`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 15
- **Węzły modyfikujące stan gry:** 34

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Pabel_RelationshipPublic`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[94]` (Paskal Beniwoll): `AddConversant("Titus Gordion");`
- Węzeł `[101]` (Paskal Beniwoll): `AddConversant("Pabel Adria");`
- Węzeł `[147]` (Paskal Beniwoll): `--;`
- Węzeł `[374]` (Paskal Beniwoll): `Variable["RiziaDLC.FireRufusGragg"] = true;`
- Węzeł `[376]` (Paskal Beniwoll): `Variable["RiziaDLC.Pabel_RelationshipPublic"] = true;`
- Węzeł `[377]` (Paskal Beniwoll): `RemoveConversant("Estela Toras");`
- Węzeł `[419]` (Paskal Beniwoll): `PlayLoopedMusic("R_Solitude","R_Solitude_Loop");`
- Węzeł `[428]` (Paskal Beniwoll): `RemoveConversant("Titus Gordion"); RemoveConversant("Pabel Adria");`
- *...oraz 26 innych węzłów ze skryptami.*

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
  - -> `[419]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The morning sun streamed through the windows of my chambers as I slowly opened my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[7]`
Mówca: **Narrator**
> "Lucita was standing by the bedside. She had an unusually intense expression on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`
  - -> `[8]`
  - -> `[9]`
  - -> `[11]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is something wrong, my wife?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't we sleep in a little longer? It's not like I have a government to run anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Monarch_Symbolic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Monarch_Symbolic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Monarch_Symbolic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Monarch_Symbolic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Monarch_Symbolic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't we sleep in a little longer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Narrator**
> "She hesitated nervously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Lucita Azaro**
> ""Your Maj-- Romus...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Lucita Azaro**
> ""There's something I need to tell you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Lucita Azaro**
> ""I...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Lucita Azaro**
> ""I think I'm pregnant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`
  - -> `[22]`
  - -> `[23]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean, you *think*? Haven't you been to the doctor yet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What?! Since when?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Praise the Lord!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is it a boy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Lucita Azaro**
> ""I don't know. I don't even know how far along I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[25]`
Mówca: **Lucita Azaro**
> ""We shouldn't celebrate yet. Nothing is certain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[26]`
Mówca: **Lucita Azaro**
> ""A month or two, maybe?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[27]`
Mówca: **Lucita Azaro**
> ""No, not yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[31]`
Mówca: **Lucita Azaro**
> ""And with everything that's happened to Her Highness-- Vina...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[32]`
Mówca: **Lucita Azaro**
> ""Time's been a blur since the war began. I thought I was throwing up from nerves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[36]`
Mówca: **Narrator**
> "She swallowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Lucita Azaro**
> ""I wasn't even sure how you would take the news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[41]`
Mówca: **Lucita Azaro**
> ""We've had so many security issues lately. I thought I was throwing up from nerves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true || RiziaDLC.Taddeus_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true || RiziaDLC.Taddeus_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true  or  Variable["RiziaDLC.Taddeus_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Executed == true || RiziaDLC.Taddeus_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true  or  Variable["RiziaDLC.Taddeus_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[45]`
Mówca: **Lucita Azaro**
> ""And then after everything with the General-- Father...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_ArmedResistance == true || RiziaDLC.ZilleReferendum_Interfere_Army == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_ArmedResistance == true || RiziaDLC.ZilleReferendum_Interfere_Army == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] == true  or  Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_ArmedResistance == true || RiziaDLC.ZilleReferendum_Interfere_Army == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] == true  or  Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[49]`
Mówca: **Lucita Azaro**
> ""Our overthrow in Zille was such a blur. I thought I was throwing up from nerves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[50]`
Mówca: **Lucita Azaro**
> ""We've both been so busy lately...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[514]`

### Węzeł `[51]`
Mówca: **Narrator**
> "She hesitantly took my hand, resting the other on her abdomen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[57]`
  - -> `[58]`
  - -> `[70]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[471]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""From a purely pragmatic point of view, this is perfect. I need a new successor now that Vina is gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An heir and a spare. Just like I always wanted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You needn't have worried, my love. I'm the happiest man in the world right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have a challenging time ahead of us, that's for certain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A new heir for our holy kingdom. God has truly smiled upon us this day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[60]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[61]`
Mówca: **Narrator**
> "She smiled and wrapped her arms around me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[62]`
Mówca: **Narrator**
> "A puzzled frown formed on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Lucita Azaro**
> ""Who's the spare?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[64]`
Mówca: **Lucita Azaro**
> ""She's not gone, you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Lucita Azaro**
> ""Whatever happens, we'll remember her. But we're bringing new life into the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[66]`
Mówca: **Lucita Azaro**
> ""I love you, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`
  - -> `[74]`
  - -> `[75]`

### Węzeł `[67]`
Mówca: **Lucita Azaro**
> ""We'll get through it together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I love you, Queen Lucita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I cherish and respect you deeply.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Theocracy_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[73]`
Mówca: **Lucita Azaro**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you'd never, ever do anything to betray me, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Lucita Azaro**
> ""Will you come with me to the Palace doctors? I've put this off for long enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[90]`
  - -> `[86]`
  - -> `[492]`
  - -> `[489]`
  - -> `[361]`

### Węzeł `[80]`
Mówca: **Narrator**
> "She kissed me on the forehead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[81]`
Mówca: **Lucita Azaro**
> ""Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. I want to tell Pabel first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Gone == false && RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Gone == false && RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_Gone"] == false  and  Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_Gone == false && RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Gone"] == false  and  Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course. What are we waiting for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do I tell Vina? Her inheritance might be at stake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Lucita Azaro**
> ""It'll still be a while before we find out the sex. If it's a boy, I'm sure you'll find a way to let Her Highness down easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""First things first. Titus! Get in here! I'm going to be a father again!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false && RiziaDLC.Reform_Path == false && RiziaDLC.Theocracy_Full == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false && RiziaDLC.Reform_Path == false && RiziaDLC.Theocracy_Full == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false  and  Variable["RiziaDLC.Reform_Path"] == false  and  Variable["RiziaDLC.Theocracy_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false && RiziaDLC.Reform_Path == false && RiziaDLC.Theocracy_Full == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false  and  Variable["RiziaDLC.Reform_Path"] == false  and  Variable["RiziaDLC.Theocracy_Full"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[93]`
Mówca: **Narrator**
> "My bodyguard entered the room. He cast an eye over myself and Lucita, then reached out to shake my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[95]`
Mówca: **Titus Gordion**
> ""Congratulations, my king. You must be very proud.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[96]`
Mówca: **Narrator**
> "I summoned my butler. He cautiously regarded myself and Lucita as he stood in the doorway of my chambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel! I'm going to be a father again!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_RelationshipPublic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_RelationshipPublic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_RelationshipPublic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Pabel Adria");)*
- **Efekt (`userScript`):** `AddConversant("Pabel Adria");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita and I were married in secret, and now she's having my baby.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[103]`
Mówca: **Pabel Adria**
> ""What is it, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""From now on, you're going to be butlering for three. King, queen and unborn heir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duchess Azaro and I are with child. You shall congratulate us at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Narrator**
> "A series of emotions passed across his face as he absorbed this news. Finally, he reached out to shake my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Pabel Adria**
> ""Congratulations to you both. You must be very proud.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a gesture of gratitude for your friendship and service to the Crown, I want you to be the godfather.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No time for chit-chat. We've got to get Lucita to the doctor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a gesture of gratitude for your service to the Crown, I want you to be the godfather.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No time for chit-chat. We've got to get Lucita to the doctor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Titus Gordion**
> ""Right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[113]`
Mówca: **Narrator**
> "I saw doubt in Lucita's eyes. Titus knelt before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Titus Gordion**
> ""Nothing would honor me more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[115]`
Mówca: **Narrator**
> "There was a touch of sadness to his smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Pabel Adria**
> ""Nothing would honor me more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[117]`
Mówca: **Pabel Adria**
> ""I hope all goes well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[118]`
Mówca: **Narrator**
> "Titus trailed a short distance behind as we walked down palace corridors towards the medical wing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[119]`
Mówca: **Lucita Azaro**
> ""It's a good thing the Royal Council petition hearings are coming up soon. We can announce the pregnancy, then reinstate General Taddeus straight away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[130]`
  - -> `[126]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_RelationshipPublic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_RelationshipPublic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_RelationshipPublic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Lucita Azaro**
> ""It's a good thing the Royal Council petition hearings are coming up soon. We can announce the marriage and pregnancy, then reinstate General Taddeus straight away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[130]`
  - -> `[126]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want you as my security councilor, Lucita. You're the best we've got.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, good thinking. Your father will jump at the chance to serve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Disgraced == true || RiziaDLC.Taddeus_Deranked == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Disgraced == true || RiziaDLC.Taddeus_Deranked == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Disgraced"] == true  or  Variable["RiziaDLC.Taddeus_Deranked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Disgraced == true || RiziaDLC.Taddeus_Deranked == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Disgraced"] == true  or  Variable["RiziaDLC.Taddeus_Deranked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your father is a disgrace to your family, Lucita. He lost us Golden Shield.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't think that far into the future. Let's wait until we know more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[131]`
Mówca: **Narrator**
> "She blushed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Lucita Azaro**
> ""If I am, it's because I learned from the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Theocracy_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Lucita Azaro**
> ""Now that you're forming the new Wruhecist Royal Council, we don't have a reason for secrecy any more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Diplomatic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Diplomatic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Diplomatic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Diplomatic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Diplomatic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_RelationshipPublic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_RelationshipPublic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_RelationshipPublic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[143]`
Mówca: **Lucita Azaro**
> ""I have to ask, Romus. Are you sure about these reforms?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[144]`
Mówca: **Lucita Azaro**
> ""We can announce the pregnancy right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[154]`
  - -> `[157]`

### Węzeł `[145]`
Mówca: **Lucita Azaro**
> ""We can announce the marriage and pregnancy right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[154]`
  - -> `[157]`

### Węzeł `[146]`
Mówca: **Lucita Azaro**
> ""A poor choice of words, given his condition. But you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[148]`
Mówca: **Lucita Azaro**
> ""It's not *that* far into the future, Romus. The months will pass in a heartbeat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Lucita Azaro**
> ""Give him a chance to prove himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Narrator**
> "In the medical wing, we were received immediately by a group of nurses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm glad you don't think poorly of the decision to dissolve the Council, by the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Narrator**
> "Her face scrunched up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Lucita Azaro**
> ""I am Queen Consort. I'm above the Council now anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't wait to spread the gospel of St. Wruhec with you by my side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Narrator**
> "She half-smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Lucita Azaro**
> ""Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Kingdom may be changing. But the Royal Family will be forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Narrator**
> "She squeezed my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[159]`
Mówca: **Narrator**
> "Lucita was rushed into a side room that contained Rizia's most state-of-the-art blood testing technology."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[160]`
Mówca: **Narrator**
> "After two interminable hours in the waiting room, the doctors called me in and told me the news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Narrator**
> "I was going to be a father again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Narrator**
> "By the end of the year, a new heir of Rizia would be born."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[163]`
Mówca: **Narrator**
> "Pabel was standing over my bed with the morning paper. He had an unusually intense expression on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[168]`
  - -> `[169]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_Lord))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't need to bring me the paper. You're not my butler anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Read the paper to me in bed. The King commands you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let me guess. More bad news?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't I sleep in a little longer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Pabel Adria**
> ""In a bit. Let me show you something first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[172]`
Mówca: **Pabel Adria**
> ""At once, sire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[173]`
Mówca: **Narrator**
> "Pabel pulled back the covers and joined me in bed. He opened the newspaper and gestured at an article."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Pabel Adria**
> ""Rufus Gragg is at it again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`
  - -> `[180]`
  - -> `[518]`

### Węzeł `[175]`
Mówca: **Pabel Adria**
> ""This is my copy of the Herald, thank you very much. But I wanted to show you something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[176]`
Mówca: **Narrator**
> "Pabel sat down at the edge of the bed. He opened the newspaper and gestured at an article."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[177]`
Mówca: **Pabel Adria**
> ""I was just perusing today's Herald when I saw this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nobody cares what that old queen has to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's he writing this time?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_Media_Censored == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_Media_Censored == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_Media_Censored == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remind me. Why haven't I fired him yet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""However bad he is, I'm sure the Voice is worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[185]`
Mówca: **Narrator**
> "Pabel cleared his throat and adopted an exaggerated Rumburgian accent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_Media_Censored == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_Media_Censored == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_Media_Censored == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Pabel Adria**
> ""He's the only gossip columnist in the country. You can't deny his influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[190]`
Mówca: **Pabel Adria**
> ""He doesn't wield as much influence as he used to now that the press has opened up. But still...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[191]`
Mówca: **Pabel Adria**
> ""His gossip has been harmless up to now. A useful distraction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[192]`
Mówca: **Pabel Adria**
> ""Actually, the Voice has intelligently recognized that there are more urgent things to worry about than the King's love life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[193]`
Mówca: **Pabel Adria**
> ""'Who *is* Lord Pabel Adria? From humble beginnings as a groundskeeper's son to head butler to the Royal Family, this man now commands both an estate in Rizia Imperii and the exclusive attention of the King himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_Lord == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[197]`
Mówca: **Pabel Adria**
> ""Since the Royal Wedding, Lord Adria has hardly strayed from His Majesty's side. They seem to share that rarest of treasures: a childhood friendship that has stretched well into middle age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_WeddingDate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_WeddingDate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_WeddingDate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_WeddingDate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_WeddingDate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Pabel Adria**
> ""Though he keeps a low profile, Lord Adria has been seen by His Majesty's side on numerous occasions. They seem to share that rarest of treasures: a childhood friendship that has stretched well into middle age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[202]`
Mówca: **Pabel Adria**
> ""'Who *is* Pabel Adria? From humble beginnings as a groundskeeper's son to head butler to the Royal Family, this man now commands the exclusive attention of the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Pabel Adria**
> ""His Majesty is hardly ever seen without Mr. Adria by his side. Not uncommon for a personal attendant, but these two seem to share that rarest of treasures: a childhood friendship that has stretched well into middle age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Pabel Adria**
> ""Perhaps it is the depth of that special bond which has kept our King from seeking out a new Queen Consort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Pabel Adria**
> ""Or could it be that he has already found one?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`
  - -> `[211]`
  - -> `[208]`

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm used to such speculations about me. But they should leave you out of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's as bad as it gets? Ha. It's not like they can arrest us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If only you could be my Queen Consort, Pabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[209]`
Mówca: **Pabel Adria**
> ""But this...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My daughter might die, dammit! Can't a King get any privacy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[214]`
Mówca: **Pabel Adria**
> ""No, they can't. Thanks to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[215]`
Mówca: **Narrator**
> "He sighed wistfully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[216]`
Mówca: **Pabel Adria**
> ""I got myself into this when I got myself into your trousers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[217]`
Mówca: **Pabel Adria**
> ""Apparently not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[218]`
Mówca: **Pabel Adria**
> ""What if we could just be out in the open about us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's true. My daughter's a prisoner. The worst thing that could ever happen to me has already happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true || RiziaDLC.PromiseToAbdicate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true || RiziaDLC.PromiseToAbdicate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.PromiseToAbdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Path == true || RiziaDLC.PromiseToAbdicate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.PromiseToAbdicate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Pabel Adria**
> ""You told me you're planning on letting go of your power. What's the worst that could happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[234]`
  - -> `[229]`

### Węzeł `[227]`
Mówca: **Pabel Adria**
> ""I mean it. What's the worst that could happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[234]`
  - -> `[229]`
  - -> `[228]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll be usurped. Laughed off the throne. Perhaps even from within my own family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. I am the king. If my subjects love me, they'll love you as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina's got her heart set on being queen. I don't want to do anything to jeopardize that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The entire world will know that the King of Rizia enjoys the company of men.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My daughter ran away. It's been one royal scandal after another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[236]`
Mówca: **Pabel Adria**
> ""You'll be more famous than ever. But yes, not all of the attention will be positive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[237]`
Mówca: **Pabel Adria**
> ""I can't imagine how much pain you've been in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Pabel Adria**
> ""Whether us going public will ease or compound that pain... I don't know, Rom. It's up to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`
  - -> `[523]`
  - -> `[246]`

### Węzeł `[239]`
Mówca: **Pabel Adria**
> ""You being involved with a man won't disrupt the line of succession. It'd be worse if you married a woman and had a boy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Pabel Adria**
> ""It's up to you. But think of what a relief it would be to stop hiding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`
  - -> `[523]`
  - -> `[246]`

### Węzeł `[241]`
Mówca: **Pabel Adria**
> ""Well, precisely. What's one more?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[242]`
Mówca: **Pabel Adria**
> ""Let's be real. Not all of them will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[243]`
Mówca: **Pabel Adria**
> ""Is House Toras really so intolerant? Don't answer that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's test the waters first. We'll tell my mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is as out in the open as I'm willing to get, Pabel. We shall continue as we have been. For the rest of our lives, if we have to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_Media_Censored)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_Media_Censored)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_Media_Censored"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_Media_Censored))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_Media_Censored"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm having Rufus Gragg fired. My love life shall remain private, and no speculation about it shall make it into the papers ever again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[250]`
Mówca: **Pabel Adria**
> ""Why not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[251]`
Mówca: **Pabel Adria**
> ""All right. I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[252]`
Mówca: **Pabel Adria**
> ""But we can't go on forever like this. Sooner or later, the truth will out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[253]`
Mówca: **Narrator**
> "He got up and smoothed out his suit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_Lord == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Pabel Adria**
> ""If you'll excuse me, I have an estate that needs tending to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Pabel Adria**
> ""If you'll excuse me, I have chores that need tending to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[259]`
Mówca: **Narrator**
> "He bowed and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[260]`
Mówca: **Narrator**
> "He nodded his assent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Pabel_WeddingDate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[263]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Pabel_WeddingDate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Wedding_Happened"] == true  and  Variable["RiziaDLC.Pabel_WeddingDate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Pabel_WeddingDate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Wedding_Happened"] == true  and  Variable["RiziaDLC.Pabel_WeddingDate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Pabel Adria**
> ""After our conversation at Vina's wedding, Madam Estela definitely suspects something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[265]`
Mówca: **Pabel Adria**
> ""The Queen Mother doesn't miss a thing that goes on in this palace. She must suspect something already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[266]`
Mówca: **Narrator**
> "We left my chambers and crossed the hall. I knocked on my mother's door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Narrator**
> "She answered, still in her bathrobe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
Mówca: **Estela Toras**
> ""My goodness, son. What are you two doing here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`
  - -> `[271]`

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should sit down, Mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel and I have something to tell you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's go to the balcony. I could use a smoke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Narrator**
> "We entered the room and sat on opposite sofas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[273]`
Mówca: **Estela Toras**
> ""Starting early today, are we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Narrator**
> "We crossed the room and went onto the balcony. Mother lit a cigarette and handed it to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[275]`
Mówca: **Estela Toras**
> ""Now. What is so urgent that you'd disturb an old lady's birthday preparations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[277]`
  - -> `[278]`
  - -> `[282]`

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mother... I am a homosexual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel and I are in love. We have been for a long time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This might come as a shock, but I am attracted to men as well as women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I risk bringing shame upon this family by loving a member of the same sex.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Narrator**
> "My mother was very quiet for a long moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[284]`
Mówca: **Narrator**
> "Then she burst out laughing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[285]`
Mówca: **Estela Toras**
> ""Oh, darling. I know. I'm your mother, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Estela Toras**
> ""The question remains, though. What exactly do you plan to do about it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[291]`
  - -> `[290]`
  - -> `[546]`

### Węzeł `[287]`
Mówca: **Estela Toras**
> ""I've been waiting for this news since you rolled out the rainbow carpet to homosexuals across the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Narrator**
> "Pabel gave a smile of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want the world to know. We could set an example for millions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We haven't decided yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sooner or later, everyone will find out. I should control the narrative by making an announcement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[292]`
Mówca: **Narrator**
> "Her expression turned stern."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Estela Toras**
> ""Listen to me very carefully, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[294]`
Mówca: **Estela Toras**
> ""I didn't fully know what I was signing up for when I married into House Toras. But I know now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Estela Toras**
> ""A husband poisoned by a religious lunatic...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Sal_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[299]`
Mówca: **Estela Toras**
> ""A husband known eternally as 'The Frail'...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Estela Toras**
> ""A precious daughter-in-law taken before her time...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Arrested == true || (RiziaDLC.Rico_Deposed == true && RiziaDLC.Rico_PoliceChief_PorteDrazon == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Arrested == true || (RiziaDLC.Rico_Deposed == true && RiziaDLC.Rico_PoliceChief_PorteDrazon == false))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Arrested"] == true  or  (Variable["RiziaDLC.Rico_Deposed"] == true  and  Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Arrested == true || (RiziaDLC.Rico_Deposed == true && RiziaDLC.Rico_PoliceChief_PorteDrazon == false)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Arrested"] == true  or  (Variable["RiziaDLC.Rico_Deposed"] == true  and  Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[304]`
Mówca: **Estela Toras**
> ""A nephew ousted in disgrace...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Estela Toras**
> ""His father humiliated to the point of resignation...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Resigned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Resigned == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_Resigned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_Resigned == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Resigned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[312]`
Mówca: **Estela Toras**
> ""A granddaughter held hostage in a war that should never have happened in the first place...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[313]`
Mówca: **Estela Toras**
> ""A granddaughter made miserable to the point of self-exile...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[317]`
Mówca: **Narrator**
> "She pulled out a handkerchief and dabbed at her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[318]`
Mówca: **Estela Toras**
> ""I love you, darling. But you can't bring more shame to this family. Especially not right before my birthday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`
  - -> `[321]`
  - -> `[322]`
  - -> `[323]`
  - -> `[429]`

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm surprised at you, Mother. I thought you'd support me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Narrator**
> "Pabel nodded in agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am sorry. But none of this was my fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You started it! You seduced my father and brought our noble house to ruin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't. I promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[324]`
Mówca: **Estela Toras**
> ""Seduced? Don't delude yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[325]`
Mówca: **Estela Toras**
> ""That makes no difference. You carry the weight of your entire House on your shoulders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Estela Toras**
> ""This is for your own good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[327]`
Mówca: **Estela Toras**
> ""If you want to live openly with your charming companion here, by all means, do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Estela Toras**
> ""I do support you. This is for your own good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[329]`
Mówca: **Estela Toras**
> ""Just... not with the crown on your head. Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[330]`
Mówca: **Estela Toras**
> ""Abdicate and live your truth. Or stay in power and hide it. That's my advice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Narrator**
> "Pabel and I looked at each other, then at my mother once more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[333]`
  - -> `[547]`
  - -> `[334]`

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I have to leave the throne to be with the man I love, I will. My work as King is not yet over, but I will take your advice seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your true colors are showing. I refuse to give in to your bigotry. We will announce our love to the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have made your point. As long as I am king, this will be our secret.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[335]`
Mówca: **Narrator**
> "She nodded in approval."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[336]`
Mówca: **Estela Toras**
> ""Good boy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_Lord == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[340]`
Mówca: **Estela Toras**
> ""Now, Lord Adria. Don't you have an estate to attend to?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[341]`
Mówca: **Estela Toras**
> ""Now, Mr. Adria. Don't you have chores to attend to?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[342]`
Mówca: **Narrator**
> "Her jaw clenched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[343]`
Mówca: **Estela Toras**
> ""You're making a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Estela Toras**
> ""But I won't be the one to stop you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[345]`
Mówca: **Narrator**
> "Pabel nodded. He looked shaken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[346]`
Mówca: **Pabel Adria**
> ""Yes, madam. Sorry to trouble you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[347]`
Mówca: **Estela Toras**
> ""No problem at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[348]`
Mówca: **Narrator**
> "She swiftly ushered us both out the door and closed it without another word."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[349]`
Mówca: **Estela Toras**
> ""If you'll excuse me, I've got to put my face on before breakfast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[352]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReturn_Success == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[353]`
Mówca: **Estela Toras**
> ""To add insult to injury, we lost Zille. If I may say so, dear... you had one job!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[354]`
Mówca: **Narrator**
> "Pabel nodded. He looked shaken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[355]`
Mówca: **Pabel Adria**
> ""Sorry to trouble you, madam.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_SleepsInBed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`
  - -> `[358]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_SleepsInBed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_SleepsInBed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did Bruno kick you out of bed again? Sorry, he does that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One moment. Bruno! You're going to be a big brother!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`
  - -> `[363]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[364]`
Mówca: **Narrator**
> "My dog hopped on the bed and licked my face. Lucita scratched him behind the ears, then tugged my arm impatiently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[365]`
Mówca: **Lucita Azaro**
> ""Shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_RelationshipPublic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_RelationshipPublic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_RelationshipPublic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[369]`
Mówca: **Titus Gordion**
> ""This explains a lot. Congratulations, my king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[373]`
Mówca: **Narrator**
> "Bruno hopped on the bed and licked Pabel's face. He sighed wistfully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.FireRufusGragg = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.FireRufusGragg"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[375]`
Mówca: **Pabel Adria**
> ""So that's it? After everything, you would really step down for me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`
  - -> `[387]`
  - -> `[391]`
  - -> `[392]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_RelationshipPublic = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Estela Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`
  - -> `[147]`

### Węzeł `[378]`
Mówca: **Narrator**
> "Pabel and I stood facing each other in the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If my reforms succeed, my power will be symbolic. Why not live out the rest of my days in peace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've accomplished what I set out to do. Things can only go downhill from here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Won == true || RiziaDLC.Policy_Diplomacy_Intermerkopum == true || RiziaDLC.ZilleReturn_Success == true || RiziaDLC.Pales_Rizia_Unification == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Won == true || RiziaDLC.Policy_Diplomacy_Intermerkopum == true || RiziaDLC.ZilleReturn_Success == true || RiziaDLC.Pales_Rizia_Unification == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Won"] == true  or  Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true  or  Variable["RiziaDLC.ZilleReturn_Success"] == true  or  Variable["RiziaDLC.Pales_Rizia_Unification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Won == true || RiziaDLC.Policy_Diplomacy_Intermerkopum == true || RiziaDLC.ZilleReturn_Success == true || RiziaDLC.Pales_Rizia_Unification == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Won"] == true  or  Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true  or  Variable["RiziaDLC.ZilleReturn_Success"] == true  or  Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have failed my kingdom anyway. I don't deserve my crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It will be a relief, to be honest. Being king is hard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[392]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm thinking about it. No promises yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_RelationshipPublic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[395]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_RelationshipPublic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_RelationshipPublic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[396]`
Mówca: **Pabel Adria**
> ""So that's it? We're going public?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`
  - -> `[405]`
  - -> `[406]`
  - -> `[568]`

### Węzeł `[397]`
Mówca: **Pabel Adria**
> ""I guess that's it, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`
  - -> `[488]`
  - -> `[486]`
  - -> `[487]`

### Węzeł `[398]`
Mówca: **Pabel Adria**
> ""Madam Estela was right. I should be going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[399]`
Mówca: **Narrator**
> "He rapidly turned away from me and walked down the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Homosexuality is legal. You're a lord. There's nothing stopping us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`
  - -> `[403]`

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[403]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_Lord == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Homosexuality is legal. There's nothing stopping us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[405]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Screw what my mother says. I refuse to be ashamed of my identity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[406]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd rather not. But everyone will find out sooner or later. It's best to control the narrative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[407]`
Mówca: **Pabel Adria**
> ""You're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[408]`
Mówca: **Narrator**
> "He smirked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[409]`
Mówca: **Pabel Adria**
> ""That's the spirit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[410]`
Mówca: **Pabel Adria**
> ""Don't be so hard on yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[411]`
Mówca: **Pabel Adria**
> ""Why not, indeed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[412]`
Mówca: **Pabel Adria**
> ""Having served two of you, I won't argue with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[413]`
Mówca: **Pabel Adria**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[414]`
Mówca: **Pabel Adria**
> ""I still wish Rizia were ready to be ruled by a King and a King Consort. But realistically... your mother has a point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[415]`
Mówca: **Narrator**
> "He placed his hand in mine and we walked back down the hall together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[416]`
Mówca: **Narrator**
> "I thought about Mother's words. Perhaps the time would have to come for me to end my reign."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[417]`
Mówca: **Narrator**
> "But not just yet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[418]`
Mówca: **Pabel Adria**
> ""Shall we leak the news to Rufus Gragg? If anyone deserves the scoop, he does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`
  - -> `[440]`

### Węzeł `[419]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Solitude", "R_Solitude_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Solitude","R_Solitude_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_SleepsInBed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`
  - -> `[422]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_SleepsInBed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_SleepsInBed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[423]`
Mówca: **Narrator**
> "Bruno hopped off the bed as Pabel sat down. He opened the newspaper and gestured at an article."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[424]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_SleepsInBed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`
  - -> `[426]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_SleepsInBed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_SleepsInBed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[427]`
Mówca: **Narrator**
> "Pabel gently shoved Bruno aside, pulled back the covers and joined me in bed. He opened the newspaper and gestured at an article."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");
RemoveConversant("Pabel Adria");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");
RemoveConversant("Pabel Adria");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectEstela == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`
  - -> `[431]`

### Węzeł `[430]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectEstela == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_SuspectEstela == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know your religion despises homosexuality. But can't you make an exception for your son?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[433]`
Mówca: **Narrator**
> "She glanced around her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[434]`
Mówca: **Estela Toras**
> ""My religion -- whatever it may be -- has nothing to do with what I'm saying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[435]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suspect my reign won't last much longer anyway. Might as well go out with a bang.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Unrest_NatDes_Happened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`
  - -> `[438]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Unrest_NatDes_Happened == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Unrest_NatDes_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Unrest_NatDes_Happened == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Unrest_NatDes_Happened"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[439]`
Mówca: **Pabel Adria**
> ""I don't know what you're thinking, but I draw the line at doing *that* in public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[440]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_Media_Censored == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`
  - -> `[442]`

### Węzeł `[441]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_Media_Censored == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_Media_Censored == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[443]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. In fact, I want him fired for smearing my good name. Let's tell the main staff at the Herald.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[444]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, let's give this to the Voice. That'll teach him for being such a busybody.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, let's. We'll make his career.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[446]`
Mówca: **Pabel Adria**
> ""As you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[447]`
Mówca: **Pabel Adria**
> ""If we're lucky, it'll make the front page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[448]`
Mówca: **Narrator**
> "He placed his hand in mine. We walked back down the hall together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`
  - -> `[451]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_Lord == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[452]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`
  - -> `[454]`

### Węzeł `[453]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[454]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_Lord == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[455]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`
  - -> `[457]`

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_Lord == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[458]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn10_V_KingOpenlyGay_Butler = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_V_KingOpenlyGay_Butler"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn10_V_KingOpenlyGay_Lord = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_V_KingOpenlyGay_Lord"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[460]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn10_RH_KingHomosexual_Butler = true; RiziaDLC.FireRufusGragg = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_KingHomosexual_Butler"] = true;
Variable["RiziaDLC.FireRufusGragg"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[461]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn10_RH_KingHomosexual_Lord = true; RiziaDLC.FireRufusGragg = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_KingHomosexual_Lord"] = true;
Variable["RiziaDLC.FireRufusGragg"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[462]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn10_RH_Gossip_KingHomosexual_Butler = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_Gossip_KingHomosexual_Butler"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[463]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn10_RH_Gossip_KingHomosexual_Lord = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_Gossip_KingHomosexual_Lord"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[464]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion -= 3;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[465]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion -= 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[466]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`
  - -> `[468]`

### Węzeł `[467]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[468]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_Lord == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[469]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Lucita_Pregnant = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Lucita_Pregnant"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[471]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is still no word about Vina. I may have to make the call at one point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[473]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_RelationshipPublic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`
  - -> `[475]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_RelationshipPublic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_RelationshipPublic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[476]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Rizia_OutOfCloset");)*
- **Efekt (`userScript`):** `UnlockAchievement("Rizia_OutOfCloset");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[477]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`
  - -> `[479]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[480]`
Mówca: **Estela Toras**
> ""His father found guilty of poisoning his own brother -- my husband...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[481]`
Mówca: **Estela Toras**
> ""A brother-in-law capable of fratricide...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[482]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`
  - -> `[484]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I love you, Pabel. But I love being king more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[486]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just give it a few more years. The public will be ready for us someday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[487]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You shouldn't be with me anymore, Pabel. Go meet someone else. Be free.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[488]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You heard my mother. My family has been through enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[489]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_Hostage == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`
  - -> `[491]`

### Węzeł `[490]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_Hostage == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[491]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_Hostage == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you sure you don't want to wait until after Mother's birthday?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[493]`
Mówca: **Narrator**
> "She scoffed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[494]`
Mówca: **Lucita Azaro**
> ""That's what you're concerned about? Come on, let's go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[495]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Wedding_Happened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`
  - -> `[497]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Wedding_Happened == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Wedding_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[497]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Wedding_Happened == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Wedding_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[498]`
Mówca: **Lucita Azaro**
> ""...And her husband, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[499]`
Mówca: **Lucita Azaro**
> ""My family is reluctant enough to give up our power. If they know they've got a potential heir on the throne...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`
  - -> `[504]`
  - -> `[505]`
  - -> `[509]`

### Węzeł `[500]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The monarchy's barely changing under the new constitution. The Azaros and everyone else have nothing to worry about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Monarch_Veto == true || RiziaDLC.Reform_Legislative_HouseOfLords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`
  - -> `[503]`

### Węzeł `[502]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Monarch_Veto == true || RiziaDLC.Reform_Legislative_HouseOfLords == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Monarch_Veto"] == true  or  Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[503]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Monarch_Veto == true || RiziaDLC.Reform_Legislative_HouseOfLords == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Monarch_Veto"] == true  or  Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[504]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But you'll convince them reform is the right way to go. Yes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[505]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The royal baby will be a Toras, anyway. Not an Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[506]`
Mówca: **Lucita Azaro**
> ""In name only. I'll teach him to swordfight before he can even walk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[507]`
Mówca: **Lucita Azaro**
> ""I'll try my best. But not if the reforms go directly against their interests. You have to understand that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[508]`
Mówca: **Lucita Azaro**
> ""My father will have to be the judge of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[509]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If they're truly concerned for the safety of their unborn heir, they'll agree to these changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[510]`
Mówca: **Narrator**
> "She swallowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[511]`
Mówca: **Lucita Azaro**
> ""All right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[512]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Rizian Royal Family shall still reign, my dear. The Azaros will be lucky to be part of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[513]`
Mówca: **Lucita Azaro**
> ""My father's going to want more than that. And I'm not sure he can be convinced otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[514]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true && RiziaDLC.Reform_Diplomatic == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`
  - -> `[516]`

### Węzeł `[515]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true && RiziaDLC.Reform_Diplomatic == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true  and  Variable["RiziaDLC.Reform_Diplomatic"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[516]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Path == true && RiziaDLC.Reform_Diplomatic == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true  and  Variable["RiziaDLC.Reform_Diplomatic"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[517]`
Mówca: **Lucita Azaro**
> ""And you've been disappearing off God knows where...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[518]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`
  - -> `[520]`

### Węzeł `[519]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[520]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[521]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With everything that's been going on, you'd think he'd give it a rest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[522]`
Mówca: **Pabel Adria**
> ""Gossip is a welcome distraction from times of turmoil. I get it. But listen...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[523]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It gladdens my heart that so many Rizians like us are now able to live freely. But it's never going to be us, Pabel. Not as long as I am King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[524]`
Mówca: **Narrator**
> "He looked at me for a moment, crestfallen, then embraced me tightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[525]`
Mówca: **Pabel Adria**
> ""I always thought, maybe someday...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[526]`
Mówca: **Pabel Adria**
> ""But you're right. You're a royal. Your life is not entirely yours to lead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`
  - -> `[528]`
  - -> `[530]`
  - -> `[533]`

### Węzeł `[527]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It isn't. But I still want to share it with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[528]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I may not rule Rizia forever. 'Someday' could come sooner than you think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[529]`
Mówca: **Pabel Adria**
> ""Rom. I could never ask you to give up the throne for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[530]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is. I'm just a coward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[531]`
Mówca: **Pabel Adria**
> ""You're my coward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[532]`
Mówca: **Pabel Adria**
> ""Bi mare volu, un oxit solu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[533]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about your life? You deserve to be with someone who can show you off like the jewel you are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[534]`
Mówca: **Pabel Adria**
> ""Touching, Rom. But I can't give you up that easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[535]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Scar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`
  - -> `[537]`

### Węzeł `[536]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Scar == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Scar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[537]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Scar == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Scar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[538]`
Mówca: **Narrator**
> "He pulled back and traced the scar on my chest with his fingers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[539]`
Mówca: **Narrator**
> "He pulled back and traced my bare collarbone with his fingers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[540]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`
  - -> `[542]`

### Węzeł `[541]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[542]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_Lord == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[543]`
Mówca: **Pabel Adria**
> ""I'll see you at the Queen Mother's birthday. As an esteemed guest, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[544]`
Mówca: **Pabel Adria**
> ""I should get going. Lots to do before the Queen Mother's birthday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[545]`
Mówca: **Narrator**
> "He kissed me, bowed and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think we should do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[547]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, Mother. But I can't keep hiding who I am. The birthday party will be our debut as a couple.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[548]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_RelationshipPublic = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[549]`
Mówca: **Narrator**
> "He smiled sadly and kissed me on the cheek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[550]`
Mówca: **Pabel Adria**
> ""I've waited this long. A few more years won't hurt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[551]`
Mówca: **Narrator**
> "He smiled sadly and kissed me on the cheek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[552]`
Mówca: **Pabel Adria**
> ""You say that as if loving you were a choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[553]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`
  - -> `[555]`

### Węzeł `[554]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[555]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_Lord == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[556]`
Mówca: **Pabel Adria**
> ""I'll see you at the Queen Mother's birthday. As an esteemed guest, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[557]`
Mówca: **Pabel Adria**
> ""I should get going. Lots to do before the Queen Mother's birthday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[558]`
Mówca: **Narrator**
> "He kissed me again, bowed and walked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[559]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn10_RH_Gossip_KingsNewWifeAndChild = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_Gossip_KingsNewWifeAndChild"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`

### Węzeł `[560]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_RelationshipPublic == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`
  - -> `[562]`

### Węzeł `[561]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_RelationshipPublic == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_RelationshipPublic"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[562]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_RelationshipPublic == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_RelationshipPublic"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn10_RH_Gossip_KingsNewChild = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_Gossip_KingsNewChild"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Pregnant = true;
RiziaDLCText.LucitaToPlayer = "Romus";
EnableCodexEntry("Characters_Council_LucitaAzaro_Married");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Lucita_Pregnant"] = true;
Variable["RiziaDLCText.LucitaToPlayer"] ="Romus";
EnableCodexEntry("Characters_Council_LucitaAzaro_Married");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[565]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Bruno");)*
- **Efekt (`userScript`):** `AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[566]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Bruno");)*
- **Efekt (`userScript`):** `AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[567]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[568]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`
  - -> `[570]`

### Węzeł `[569]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`

### Węzeł `[570]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[571]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Trust me. After my mother's birthday party, nobody will be talking about our relationship anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[572]`
Mówca: **Pabel Adria**
> ""I don't know if I like the sound of that... But all right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[573]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Bruno");)*
- **Efekt (`userScript`):** `RemoveConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[574]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Bruno");)*
- **Efekt (`userScript`):** `AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[575]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true || (RiziaDLC.Reform_Path == true && RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true ))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`
  - -> `[577]`

### Węzeł `[576]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true || (RiziaDLC.Reform_Path == true && RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true ))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  or  (Variable["RiziaDLC.Reform_Path"] == true  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard"] == true )`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[577]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true || (RiziaDLC.Reform_Path == true && RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true )))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  or  (Variable["RiziaDLC.Reform_Path"] == true  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard"] == true )) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[578]`
Mówca: **Narrator**
> "As I was waiting for her to re-emerge, Titus whispered in my ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[579]`
Mówca: **Titus Gordion**
> ""Your Majesty, do you still want to go through with the plans we talked about? As it stands, you would be putting the Queen Consort -- and your own unborn child -- in great danger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`
  - -> `[585]`
  - -> `[582]`

### Węzeł `[580]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know, but I have no choice. We're doing this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[581]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. We won't strike against House Azaro that night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`

### Węzeł `[582]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`
  - -> `[584]`

### Węzeł `[583]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[584]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[585]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will make sure nothing happens to either of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`

### Węzeł `[586]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. Let's call off the plan. It's too risky.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[587]`
Mówca: **Narrator**
> "Titus gave a grim nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[588]`
Mówca: **Titus Gordion**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[589]`
Mówca: **Titus Gordion**
> ""I suppose even in her condition, Lucita is more than capable of protecting herself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[590]`
Mówca: **Narrator**
> "Titus nodded quickly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[591]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro = false)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[592]`
Mówca: **Narrator**
> "Titus gave a furtive sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[593]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB = false; RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard = false; RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians = false;
RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC = false)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] = false;
Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard"] = false;
Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] = false;
Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[594]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction = false;
RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike = false;
RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction"] = false;
Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] = false;
Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[595]`
Mówca: **Narrator**
> "Bruno trailed a short distance behind as we walked down palace corridors towards the medical wing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[596]`
Mówca: **Narrator**
> "Pabel trailed a short distance behind as we walked down palace corridors towards the medical wing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[597]`
Mówca: **Narrator**
> "We walked down palace corridors towards the medical wing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[598]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic == true && RiziaDLC.Pabel_Lord == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`
  - -> `[600]`

### Węzeł `[599]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic == true && RiziaDLC.Pabel_Lord == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic"] == true  and  Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`

### Węzeł `[600]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic == true && RiziaDLC.Pabel_Lord == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic"] == true  and  Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`

### Węzeł `[601]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[602]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic == true && RiziaDLC.Pabel_Lord == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`
  - -> `[604]`

### Węzeł `[603]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic == true && RiziaDLC.Pabel_Lord == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic"] == true  and  Variable["RiziaDLC.Pabel_Lord"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[604]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic == true && RiziaDLC.Pabel_Lord == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic"] == true  and  Variable["RiziaDLC.Pabel_Lord"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[605]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`
