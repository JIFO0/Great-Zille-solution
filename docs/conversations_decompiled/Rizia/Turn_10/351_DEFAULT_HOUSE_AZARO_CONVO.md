# Rizia/Turn 10/DEFAULT GATHERING SCENE/DEFAULT HOUSE AZARO CONVO

- **ID konwersacji:** `351`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/351_DEFAULT_HOUSE_AZARO_CONVO.md`
- **Liczba węzłów dialogowych:** 837
- **Liczba wyborów gracza:** 136

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[73]** Lucita Azaro
- **[83]** Taddeus Azaro
- **[88]** Carlos Robles Azaro
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Army_Unit_Azaro_Total`
- `RiziaDLC.BirthdayGathering_Invited_Carlos`
- `RiziaDLC.BirthdayGathering_Invited_Lucita`
- `RiziaDLC.Council_Security_Taddeus`
- `RiziaDLC.Ending_Coup_Azaro`
- `RiziaDLC.HouseOfDelegates_Abolished`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_DiscussedStratocracy`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.NatDes_UniteHousesAgainst_Sazon`
- `RiziaDLC.NatDes_UniteHousesAgainst_Toras`
- `RiziaDLC.Pabel_RelationshipPublic`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Path_Stratocracy`
- `RiziaDLC.PiplineNasDes_Taddeus_1926Uprising`
- `RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies`
- `RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Reform_Silent`
- `RiziaDLC.Reforms_DiscussedOnYacht`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Strong`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar`
- `RiziaDLC.Theocracy_Full`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn06_LucitaTalk_AzarosDissatisfied`
- `RiziaDLC.Turn09_TalkWithTitus_PortraitTalk_VisionMilitaristic`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_PromisedQueen`
- `RiziaDLC.War_Objective_Captured_Pales`
- `RiziaDLC.War_Pales_Operation1_Won`
- `RiziaDLC.War_RumburgCeasefireRequested`
- `RiziaDLC.War_WehlenJoined`
- `RiziaDLC.ZilleOwnership_RiziaImperii`
- `RiziaDLCIsolated.Birthday_Default_Azaro_General`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Health`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Partner`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Portrait`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Succession`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Unrest`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.NatDes_UniteHousesAgainst_Azaro`
- `RiziaDLC.Pales_PromisedToHouseAzaro`
- `RiziaDLC.Path_Stratocracy`
- `RiziaDLC.Promised_Succession_Son_RespectTradition`
- `RiziaDLC.Reform_Suspicion`
- `RiziaDLCIsolated.Birthday_Default_Azaro_General`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Health`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Partner`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Portrait`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Succession`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Unrest`
- `RiziaDLCIsolated.Turn10_Birthday_AzaroLevyPromise`
- `RiziaDLCIsolated.Turn10_Gathering_AzaroBoost`

### Skoki między-konwersacyjne:
- Węzeł `[333]` -> **[554] Rizia/Turn 10/DEFAULT GATHERING SCENE/DEFAULT GATHERING SCENE Conversation** (../Turn_10/554_DEFAULT_GATHERING_SCENE_Conversation.md), Węzeł `[5]`
- Węzeł `[803]` -> **[554] Rizia/Turn 10/DEFAULT GATHERING SCENE/DEFAULT GATHERING SCENE Conversation** (../Turn_10/554_DEFAULT_GATHERING_SCENE_Conversation.md), Węzeł `[5]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 17
- **Węzły modyfikujące stan gry:** 32

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Pales_PromisedToHouseAzaro`
- `RiziaDLCIsolated.Birthday_Default_Azaro_Unrest`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[43]` (Paskal Beniwoll): `Variable["RiziaDLC.Reform_Suspicion"] = Variable["RiziaDLC.Reform_Suspicion"] + 1;`
- Węzeł `[77]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gath...`
- Węzeł `[80]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gath...`
- Węzeł `[122]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gath...`
- Węzeł `[144]` (Paskal Beniwoll): `--;`
- Węzeł `[145]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Succession"] = true;`
- Węzeł `[223]` (Paskal Beniwoll): `--;`
- Węzeł `[251]` (Paskal Beniwoll): `--;`
- *...oraz 24 innych węzłów ze skryptami.*

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

### Węzeł `[3]`
Mówca: **Narrator**
> "The general turned his wheelchair around to face me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Taddeus Azaro**
> ""Congratulations on a successful evening, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't tell you how happy I am to see you back in good health, General.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You haven't said a word about my new partner. Do you approve?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[7]`
Mówca: **Narrator**
> "Taddeus smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Taddeus Azaro**
> ""The doctors are calling it a miracle recovery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == false && RiziaDLC.Pales_War == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == false && RiziaDLC.Pales_War == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == false  and  Variable["RiziaDLC.Pales_War"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == false && RiziaDLC.Pales_War == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == false  and  Variable["RiziaDLC.Pales_War"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you make of all the recent protests, General?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Default_Azaro_Unrest == false && RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Default_Azaro_Unrest == false && RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Unrest"] == false  and  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Default_Azaro_Unrest == false && RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Unrest"] == false  and  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You seem to be in good health these days, General.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How is everything in Cardesse-Montaklar?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[18]`
Mówca: **Taddeus Azaro**
> ""As both your security councilor and a high-ranking noble, I'm obviously concerned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Taddeus Azaro**
> ""I have to say I'm concerned, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]`

### Węzeł `[23]`
Mówca: **Taddeus Azaro**
> ""I recognize the feeling in the air. It was exactly the same in 1926.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe we can put an end to the unrest. But I will need House Azaro's support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That revolt could have ended peacefully had the Crown been willing to meet the protesters' demands for reform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand now why my father made that deal with Wehlen. Desperation can make a ruler contemplate the unthinkable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Taddeus Azaro**
> ""In fact, I would say I'm well enough to assume my prior position on the Royal Council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Theocracy_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Taddeus Azaro**
> ""With careful management, I could stay on the Royal Council for years to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Theocracy_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[41]`
Mówca: **Narrator**
> "His features hardened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[42]`
Mówca: **Taddeus Azaro**
> ""Very much so, Your Majesty. The doctors call it a miracle recovery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Suspicion += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Suspicion"] = Variable["RiziaDLC.Reform_Suspicion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[44]`
Mówca: **Taddeus Azaro**
> ""Have you forgotten that they killed my brother? That they almost killed you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Taddeus Azaro**
> ""These people can't be compromised with. They will be satisfied with nothing less than our blood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[46]`
Mówca: **Taddeus Azaro**
> ""And what are you thinking now, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`
  - -> `[58]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is a pity to be losing so many trusted advisors. But I am following the path of God now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[48]`
Mówca: **Taddeus Azaro**
> ""Except that the Royal Council is about to dissolve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[49]`
Mówca: **Taddeus Azaro**
> ""Except, of course, that you saw fit to replace my disgraced daughter with your bodyguard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`
  - -> `[76]`

### Węzeł `[50]`
Mówca: **Taddeus Azaro**
> ""Assuming my daughter allows it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[51]`
Mówca: **Taddeus Azaro**
> ""Except, of course, that the Royal Council is about to dissolve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[82]`
  - -> `[83]`
  - -> `[84]`

### Węzeł `[52]`
Mówca: **Taddeus Azaro**
> ""I don't want the traitors to win any more than you do, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Taddeus Azaro**
> ""But I must say, it won't be easy for us to help you without the ability to mobilize our own forces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[57]`
Mówca: **Taddeus Azaro**
> ""If His Majesty would have me, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will handle the riots and bring peace to the realm. Your province need not get involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[65]`
Mówca: **Lucita Azaro**
> ""I agree, Father. The time for peaceful compromise is long past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[130]`
  - -> `[184]`

### Węzeł `[66]`
Mówca: **Taddeus Azaro**
> ""We are already involved, Your Majesty. There are riots on our streets as well as yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[67]`
Mówca: **Carlos Robles Azaro**
> ""Enough with the false modesty, Taddeus. His Majesty is lucky to have you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[71]`
Mówca: **Lucita Azaro**
> ""I don't just allow it, I encourage it. I'll have my hands full raising our new heir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[86]`
  - -> `[87]`
  - -> `[88]`

### Węzeł `[72]`
Mówca: **Lucita Azaro**
> ""Of course, Father. I was only keeping your seat warm for you, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`
  - -> `[88]`

### Węzeł `[73]`
Mówca: **Narrator**
> "There was reluctance in Lucita's voice as she answered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had my reasons for appointing Titus. The Azaros could not be trusted after what Lucita did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Captain Gordion is more than a mere bodyguard. His seat on my council is well deserved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were not yet fully recovered back then. Petition for the security councilor seat this year, and I will consider reinstating you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_Gathering_AzaroBoost += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Narrator**
> "He bowed his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Taddeus Azaro**
> ""I will gladly do so, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_Gathering_AzaroBoost -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[782]`

### Węzeł `[81]`
Mówca: **Taddeus Azaro**
> ""I do not question Gordion's competence. But I will point to my years of experience serving your father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I nonetheless thank you for your many years of service. You deserve a long, happy retirement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fear not, General. There will still be a place for you when Rizia is reborn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As is its destiny. All things must come to an end, Taddeus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Taddeus Azaro**
> ""Yes... I know. But I wish I could have served you for longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your daughter has gone above and beyond in her service to the Crown, Taddeus. You should be proud of her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With all due respect, the time of King Valero has passed. The Royal Council needs fresh blood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Petition for the council seat when the time comes, General. I will place you under special consideration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now, Lucita, I thought you were a modern woman. You can raise a child and have a career at the same time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Narrator**
> "She smiled wryly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[91]`
Mówca: **Taddeus Azaro**
> ""I am, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true && RiziaDLC.War_Objective_Captured_Pales == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true && RiziaDLC.War_Objective_Captured_Pales == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.War_Objective_Captured_Pales"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true && RiziaDLC.War_Objective_Captured_Pales == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.War_Objective_Captured_Pales"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[95]`
Mówca: **Taddeus Azaro**
> ""I will be once we win the war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[99]`
Mówca: **Carlos Robles Azaro**
> ""If it's fresh blood you're looking for, I could put myself forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[100]`
Mówca: **Lucita Azaro**
> ""I hadn't heard. But raising a child, fulfilling my duties as Queen Consort *and* serving on your council? It's too much, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[101]`
Mówca: **Taddeus Azaro**
> ""Thank you. You will be hearing from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[102]`
Mówca: **Narrator**
> "Lucita smiled gently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[103]`
Mówca: **Lucita Azaro**
> ""Don't discount my father's years of experience, both serving King Valero and leading our troops.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Azaro Default Convo Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`
  - -> `[13]`
  - -> `[393]`
  - -> `[424]`
  - -> `[811]`
  - -> `[423]`

### Węzeł `[105]`
Mówca: **Lucita Azaro**
> ""I don't think you have the temperament to sit through a lengthy council session, Carlos.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Carlos Robles Azaro**
> ""And you do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Lucita Azaro**
> ""With that said, if you did insist I continue my council duties, I could hardly refuse His Majesty's request.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Azaro Default Convo Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I made a royal decree to centralize our armed forces. I cannot simply reverse it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see what you're getting at, but it's not going to happen. I can't grant Rizia's royal houses the means to strike against me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Taddeus Azaro**
> ""You're so afraid of being usurped that you'd let the revolutionaries strike against us all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Taddeus Azaro**
> ""I didn't want to say this, but you sound just like your father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[203]`
  - -> `[204]`
  - -> `[213]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[116]`
Mówca: **Taddeus Azaro**
> ""And why not? You are the King -- for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[203]`
  - -> `[204]`
  - -> `[213]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I cannot authorize this. I command you to help the Crown against the revolutionaries with whatever other resources are at your disposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Narrator**
> "Taddeus frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Taddeus Azaro**
> ""We will try, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[120]`
Mówca: **Narrator**
> "Taddeus and Lucita looked at one another."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Lucita Azaro**
> ""In addition, we want your assurance that should my child be a boy, he will take his rightful place as successor to the Rizian throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_Gathering_AzaroBoost -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Narrator**
> "I saw Carlos' hands form fists."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Narrator**
> "I saw Lucita's hands form fists."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Taddeus Azaro**
> ""Your Majesty, I promise we will help you as best we can, under the circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[129]`
Mówca: **Taddeus Azaro**
> ""The unrest will come to all of us sooner or later. As it did back then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nonetheless, I'm reluctant to resort to violence. I'm holding out hope this can be resolved by other means.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[131]`
Mówca: **Taddeus Azaro**
> ""But with most of our house embroiled in the war, we don't have the resources to properly crack down on them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[135]`
Mówca: **Taddeus Azaro**
> ""House Azaro will help you..""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[139]`
Mówca: **Lucita Azaro**
> ""We want your assurance that should our child be a boy, he will take his rightful place in the Rizian line of succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Taddeus Azaro**
> ""This is not only what House Azaro wants. It will bring stability and strength back to the kingdom in the wake of the uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[141]`
Mówca: **Taddeus Azaro**
> ""The Azaro army will help you to the best of our ability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[142]`
Mówca: **Narrator**
> "Carlos saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Carlos Robles Azaro**
> ""Loud and clear, General. The rebellion doesn't stand a chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`
  - -> `[315]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`
  - -> `[201]`
  - -> `[202]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Default_Azaro_Succession = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Succession"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`
  - -> `[149]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, Lucita, but I can't guarantee that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course royal tradition will be respected. If we have a boy, he will inherit the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have no idea if Vina is even alive or dead. As far as I'm concerned, Lucita's child is my only heir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[152]`
Mówca: **Narrator**
> "My wife stepped backwards, shaken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Lucita Azaro**
> ""You can't?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[237]`
  - -> `[238]`

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I made a promise to Vina long ago. I can't break it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[155]`
Mówca: **Taddeus Azaro**
> ""But I think we should change the subject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may be right. Does that mean House Azaro will support the Crown in the fight against the revolutionaries?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Path == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My mother's portrait. Do you like it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_PortraitTalk_VisionMilitaristic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_PortraitTalk_VisionMilitaristic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_PortraitTalk_VisionMilitaristic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_PortraitTalk_VisionMilitaristic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_PortraitTalk_VisionMilitaristic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[164]`
Mówca: **Taddeus Azaro**
> ""The depiction you chose truly brought a tear to my eye, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Lucita Azaro**
> ""When we win Pales, it will become a reality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]`

### Węzeł `[169]`
Mówca: **Carlos Robles Azaro**
> ""Should Rizia find itself at war again, the Queen Mother will be one of our top recruits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]`

### Węzeł `[170]`
Mówca: **Taddeus Azaro**
> ""Ah... I'm no art critic, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Lucita Azaro**
> ""It was a beautiful tribute, Romus. Everyone here thinks so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]`

### Węzeł `[178]`
Mówca: **Carlos Robles Azaro**
> ""Nor am I. But it definitely looked like the Queen Mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Azaro Default Convo Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[180]`
Mówca: **Taddeus Azaro**
> ""But if you say the Crown has the situation under control, I will not challenge you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[181]`
Mówca: **Carlos Robles Azaro**
> ""Agreed. The time for peaceful compromise is long past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[130]`
  - -> `[184]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A willingness to compromise is what makes a truly great leader. I know the Crown and the protesters will see eye to eye in the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[183]`
Mówca: **Taddeus Azaro**
> ""You have more faith in the commoners than I do... But perhaps you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what would House Azaro do in my place?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Taddeus Azaro**
> ""We wouldn't let the traitors win. That's for certain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[186]`
Mówca: **Lucita Azaro**
> ""That's not entirely true, Father. We could pull one of our units from the front and deploy them against the revolutionaries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Azaro_Total > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Azaro_Total > 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Azaro_Total"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Azaro_Total > 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Azaro_Total"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[190]`
Mówca: **Taddeus Azaro**
> ""Hm... We could.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[268]`
  - -> `[213]`

### Węzeł `[191]`
Mówca: **Taddeus Azaro**
> ""Under one condition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[192]`
Mówca: **Lucita Azaro**
> ""That's true, Your Majesty. We'd have to increase recruitment for our provincial army in order to get the necessary manpower.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[200]`
  - -> `[267]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[196]`
Mówca: **Lucita Azaro**
> ""Even then, most of our house is embroiled in the war. We'd need to institute a massive recruitment drive in order to get the necessary manpower.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[197]`
Mówca: **Narrator**
> "He and Lucita looked at one another."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excellent. I knew I could count on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's all I wanted to know. I've got to go mingle with the other guests now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's all I would have to do to get you on my side? Increase the size of our provincial armies?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's all I would have to do to get you on my side? Give the provinces back the ability to raise their own armies?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. I'll have to solve the problem on my own, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that your only condition for lending your support? That Rizia bring back our provincial levies?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough of this. I shall deal with the traitors on my own. Including your house, when the time comes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[208]`
Mówca: **Taddeus Azaro**
> ""Are you sure, Your Majesty? The riots greatly affect us in Cardesse-Montaklar as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[213]`
  - -> `[272]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[212]`
Mówca: **Lucita Azaro**
> ""You would also have to allow us to double our recruitment numbers, so that we don't have to pull troops from the front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was hoping for a solution that didn't involve the military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[214]`
Mówca: **Narrator**
> "Taddeus' brow furrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Taddeus Azaro**
> ""Your Majesty, I promise we will help you as best we can, under the circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Taddeus Azaro**
> ""I only hope it is not too little, too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[217]`
Mówca: **Narrator**
> "Taddeus folded his arms across his chest, making sure his medals were still visible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Taddeus Azaro**
> ""Your father and I learned this in 1926, Your Majesty. Brute force is the only language these animals speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Narrator**
> "Carlos nodded his assent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[225]`
  - -> `[228]`

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. So you're saying if I reinstate provincial levies, the Azaros will help us against the revolutionaries?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't believe that at all. I will not ask your house to get involved in this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Taddeus Azaro**
> ""We will try our best to avoid escalating the situation, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Taddeus Azaro**
> ""I wish you the best of luck with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have my own ways of applying brute force, if it comes down to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Taddeus Azaro**
> ""Then it sounds like you don't need us at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Taddeus Azaro**
> ""I wish you the best of luck with the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[231]`
Mówca: **Taddeus Azaro**
> ""Give us the capability and the resources, and we will do our part to crush the rebellion to a bloody pulp.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[232]`
**[WYBÓR GRACZA: ""Very well, General. By royal decree, I will bring back Rizia's provincial army system and increase levies to twice their original size." [Restore And Increase Provincial Levies]"]** — Mówca: **Player_Romus**
> ""Very well, General. By royal decree, I will bring back Rizia's provincial army system and increase levies to twice their original size.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_PromisedQueen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_PromisedQueen == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_PromisedQueen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_PromisedQueen == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_PromisedQueen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina wants to be queen more than anything. I can't take that away from her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For political reasons, I must name my daughter as successor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Succession law shouldn't favor sons. You have to admit it's a sexist policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[242]`
Mówca: **Lucita Azaro**
> ""But, Romus... we don't even know where Vina is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Lucita Azaro**
> ""And after the way she humiliated you, does she even deserve to be your heir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[257]`
  - -> `[259]`

### Węzeł `[247]`
Mówca: **Lucita Azaro**
> ""We're doing our best to coordinate her rescue, but realistically, she might not make it back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[257]`
  - -> `[259]`

### Węzeł `[248]`
Mówca: **Lucita Azaro**
> ""But, Romus... what about us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[249]`
Mówca: **Narrator**
> "My wife breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Lucita Azaro**
> ""Thank you, Romus. That means so much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[324]`

### Węzeł `[252]`
Mówca: **Lucita Azaro**
> ""Our child will represent the union of House Toras and House Azaro. A new way forward for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Narrator**
> "She looked at me with pleading eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[254]`
Mówca: **Lucita Azaro**
> ""I know how much you love Vina. But if she loves you too, she'll understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[257]`
  - -> `[259]`
  - -> `[285]`

### Węzeł `[255]`
Mówca: **Narrator**
> "My wife stroked my arm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Lucita Azaro**
> ""Vina will come back, Romus. And when she does, she'll understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we don't band together against the unrest, the protesters could kill us all. Are you seriously willing to put our unborn child's life at risk over this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes... you're right. *If* we have a son, he will take Vina's place as successor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't even know the sex of our child yet. I will make this decision when the time comes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[322]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[323]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
**[WYBÓR GRACZA: ""Very well, General. By royal decree, I will bring back Rizia's provincial army system." [Restore Provincial Levies]"]** — Mówca: **Player_Romus**
> ""Very well, General. By royal decree, I will bring back Rizia's provincial army system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. I'll have to tackle the problem on my own, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. So you're saying if I raise provincial levies, the Azaros will help us against the revolutionaries?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I'm sure. Let's change the subject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[273]`
Mówca: **Taddeus Azaro**
> ""We can offer a unit from our provincial army. With no wars on the horizon, our men and women have been looking for a fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[268]`
  - -> `[213]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true && RiziaDLC.Army_Unit_Azaro_Total < 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true && RiziaDLC.Army_Unit_Azaro_Total < 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.Army_Unit_Azaro_Total"] < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true && RiziaDLC.Army_Unit_Azaro_Total < 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.Army_Unit_Azaro_Total"] < 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. I request that you deploy your forces to quell the rebellion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[281]`
Mówca: **Lucita Azaro**
> ""Yes, I wish we could help. But even with provincial recruitment at a maximum, House Azaro can't spare the troops.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[282]`
  - -> `[283]`

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I command you to aid the Crown with whatever resources are at your disposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. I won't burden your house with this on top of the war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[284]`
Mówca: **Narrator**
> "She breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you truly love *me*, you'll understand why I have to put my daughter first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[286]`
Mówca: **Lucita Azaro**
> ""I...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[287]`
Mówca: **Narrator**
> "She looked at her father apologetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Lucita Azaro**
> ""I'm not. Father, we have to do something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false) || (RiziaDLC.Pales_War == true && RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false) || (RiziaDLC.Pales_War == true && RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false)  or  (Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false) || (RiziaDLC.Pales_War == true && RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == false)))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false)  or  (Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[292]`
Mówca: **Narrator**
> "Taddeus gave an unsatisfied grunt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Taddeus Azaro**
> ""That still depends, doesn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[294]`
Mówca: **Narrator**
> "Taddeus nodded reluctantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[295]`
Mówca: **Taddeus Azaro**
> ""We will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[296]`
Mówca: **Lucita Azaro**
> ""Father... if the revolution succeeds, there won't even be a throne for our child to inherit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Narrator**
> "Lucita sighed in frustration. She looked at her father apologetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[298]`
Mówca: **Lucita Azaro**
> ""We have to do something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false) || (RiziaDLC.Pales_War == true && RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false) || (RiziaDLC.Pales_War == true && RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false)  or  (Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false) || (RiziaDLC.Pales_War == true && RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == false)))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false)  or  (Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Taddeus Azaro**
> ""And as for our troops, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[303]`
Mówca: **Taddeus Azaro**
> ""In that case, Your Majesty, House Azaro is at your disposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[304]`
Mówca: **Taddeus Azaro**
> ""Did you hear that, Carlos? I want you to send word to Camp Domus about this immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[308]`
Mówca: **Lucita Azaro**
> ""I'll send the word to Camp Domus immediately. The rebellion doesn't stand a chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`
  - -> `[315]`

### Węzeł `[309]`
**[WYBÓR GRACZA: ""Very well, General. By royal decree, I will increase provincial levies, on the condition that House Azaro form a unit to deploy against the unrest." [Increase Provincial Levies]"]** — Mówca: **Player_Romus**
> ""Very well, General. By royal decree, I will increase provincial levies on the condition that House Azaro form a unit to deploy against the unrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]`

### Węzeł `[310]`
Mówca: **Taddeus Azaro**
> ""Thank you for your trust in us, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]`

### Węzeł `[311]`
Mówca: **Taddeus Azaro**
> ""Carlos, I want you to get word to Camp Domus about this immediately. There's no time to waste, understand?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[312]`
Mówca: **Taddeus Azaro**
> ""Thank you for your trust in us. We will not fail you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Promised_Succession_Son_RespectTradition = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Promised_Succession_Son_RespectTradition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_UniteHousesAgainst_Azaro = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.NatDes_UniteHousesAgainst_Azaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All three houses, defending the Crown together. This will be a triumph to remember.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[319]`
Mówca: **Taddeus Azaro**
> ""Understood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[320]`
Mówca: **Taddeus Azaro**
> ""Always.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[321]`
Mówca: **Taddeus Azaro**
> ""We will savor it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did away with provincial levies for a reason. I still think it's too risky for provinces like Cardesse-Montaklar to command their own armies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Azaro army is large enough already. You will help crack down on the traitors with the troops you currently have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My deepest apologies, but I cannot grant your request. It is not your house I distrust, but the others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[325]`
Mówca: **Taddeus Azaro**
> ""Then there is nothing we can do, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`
  - -> `[328]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Carlos Robles Azaro**
> ""God help us all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[330]`
Mówca: **Taddeus Azaro**
> ""Best of luck to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[331]`
Mówca: **Taddeus Azaro**
> ""We will try, but I fear it will not be enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[332]`
Mówca: **Taddeus Azaro**
> ""If the noble houses can't trust each other after all this time, perhaps Rizia deserves to fall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [HOUSE GATHERING CONVERSATION HUB])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `554` (*Rizia/Turn 10/DEFAULT GATHERING SCENE/DEFAULT GATHERING SCENE Conversation*), Węzeł `[5]`

### Węzeł `[334]`
Mówca: **Narrator**
> "The Azaros bowed and walked to the far corner of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[836]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Azaro Default Convo Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Azaro Default Convo Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Default_Azaro_Unrest == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Default_Azaro_Unrest == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Unrest"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Default_Azaro_Unrest == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Unrest"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Default_Azaro_Health == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Default_Azaro_Health == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Health"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Default_Azaro_Health == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Health"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Default_Azaro_Health = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Health"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[344]`
Mówca: **Taddeus Azaro**
> ""Aside from the riots, you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Situation_Order_ViolentProtests_CardesseMontaklar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[348]`
Mówca: **Taddeus Azaro**
> ""To be honest, Your Majesty, the protests are beginning to worry me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`
  - -> `[351]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Default_Azaro_Unrest = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Unrest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`
  - -> `[26]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Carlos Robles Azaro**
> ""Yes, we are doing our best to contain what's happening in our province. But the fury with which people have taken to the streets is quite alarming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[359]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Theocracy_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[360]`
Mówca: **Taddeus Azaro**
> ""As well as can be, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[361]`
Mówca: **Taddeus Azaro**
> ""The announcement of Rizia's new theocratic direction threw many of us for a loop, myself included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[365]`
Mówca: **Lucita Azaro**
> ""It was a surprise to many of us in the capital as well, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[369]`
Mówca: **Carlos Robles Azaro**
> ""Don't get me wrong, I'm an observant Wruhecist. But the dissolution of the Royal Council? It will take some time to get used to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[370]`
Mówca: **Narrator**
> "She looked at me pointedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[371]`
Mówca: **Taddeus Azaro**
> ""I will tell you that some in our province are still outraged over Duchess Lucita's imprisonment, as justified as it may be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita, you told me some time ago that House Azaro had complaints about my reign. Is that still the case?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_RumburgCeasefireRequested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_RumburgCeasefireRequested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_RumburgCeasefireRequested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_RumburgCeasefireRequested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_RumburgCeasefireRequested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[376]`
Mówca: **Lucita Azaro**
> ""Father is being too diplomatic to tell you that Rumburg's sudden intervention in the Pales war was not well received.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_WehlenJoined == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`
  - -> `[379]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_WehlenJoined == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_WehlenJoined"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_WehlenJoined == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_WehlenJoined"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Lucita Azaro**
> ""Father is being too diplomatic to tell you that our decision to bring Wehlen into the Pales war was not particularly well received.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Pales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Pales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Pales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Objective_Captured_Pales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Pales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[384]`
Mówca: **Lucita Azaro**
> ""Father is too modest. You'll be rechristening the streets in the Palesian capital in no time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[385]`
Mówca: **Carlos Robles Azaro**
> ""We continue to watch our Palesian neighbors with caution. There are those who believe Reinhart's conciliatory attitude is all an act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[386]`
Mówca: **Carlos Robles Azaro**
> ""Not that I am one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[387]`
Mówca: **Lucita Azaro**
> ""But as long as Pales is restored to us, House Azaro will be happy to see an end to the fighting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[388]`
Mówca: **Lucita Azaro**
> ""But with time, our citizens will see the necessity of your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_LucitaTalk_AzarosDissatisfied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`
  - -> `[391]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_LucitaTalk_AzarosDissatisfied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn06_LucitaTalk_AzarosDissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn06_LucitaTalk_AzarosDissatisfied == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn06_LucitaTalk_AzarosDissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Default_Azaro_General = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_General"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[345]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Default_Azaro_General == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[395]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Default_Azaro_General == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_General"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Default_Azaro_General == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Default_Azaro_General"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true || RiziaDLC.War_WehlenJoined == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`
  - -> `[398]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true || RiziaDLC.War_WehlenJoined == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true  or  Variable["RiziaDLC.War_WehlenJoined"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true || RiziaDLC.War_WehlenJoined == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true  or  Variable["RiziaDLC.War_WehlenJoined"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[399]`
Mówca: **Taddeus Azaro**
> ""The war continues to strain resources, but our house remains optimistic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[400]`
Mówca: **Narrator**
> "Lucita shot him a troubled glance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`
  - -> `[403]`

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[403]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Operation1_Won == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[404]`
Mówca: **Narrator**
> "Lucita nodded in affirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[405]`
Mówca: **Lucita Azaro**
> ""We'll deliver a full report on Total Tranquility later. Now's not the time for war talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`
  - -> `[389]`
  - -> `[408]`
  - -> `[409]`

### Węzeł `[407]`
Mówca: **Lucita Azaro**
> ""We'll deliver a full report later. Now's not the time for war talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[408]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've caught me in a good mood. Is there anything your house requests of your King today?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[411]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Theocracy_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[412]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope that our holy kingdom can count on your continued support. We will need your military prowess for the many crusades ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`

### Węzeł `[413]`
Mówca: **Taddeus Azaro**
> ""Still, we are prepared to support the Crown through the transition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[414]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope I can count on the Azaros' continued support. You are among my family's oldest and most important allies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`

### Węzeł `[415]`
Mówca: **Narrator**
> "Taddeus glared at his daughter sternly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[416]`
Mówca: **Lucita Azaro**
> ""What? I was only being honest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the House of Delegates abolished and the royal houses of Toras and Azaro united once more, I've been thinking the military should play a greater role in how Rizia is governed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_DiscussedStratocracy == true && RiziaDLC.Lucita_Married == true && RiziaDLC.HouseOfDelegates_Abolished == true && RiziaDLC.Theocracy_Full == false && RiziaDLC.Reform_Path == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`
  - -> `[420]`

### Węzeł `[419]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_DiscussedStratocracy == true && RiziaDLC.Lucita_Married == true && RiziaDLC.HouseOfDelegates_Abolished == true && RiziaDLC.Theocracy_Full == false && RiziaDLC.Reform_Path == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_DiscussedStratocracy"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true  and  Variable["RiziaDLC.Theocracy_Full"] == false  and  Variable["RiziaDLC.Reform_Path"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_DiscussedStratocracy == true && RiziaDLC.Lucita_Married == true && RiziaDLC.HouseOfDelegates_Abolished == true && RiziaDLC.Theocracy_Full == false && RiziaDLC.Reform_Path == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_DiscussedStratocracy"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true  and  Variable["RiziaDLC.Theocracy_Full"] == false  and  Variable["RiziaDLC.Reform_Path"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[421]`
Mówca: **Narrator**
> "Lucita slipped her hand in mine and smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`

### Węzeł `[422]`
Mówca: **Taddeus Azaro**
> ""An interesting thought, both of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]`

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks to you and your house for joining us tonight. If you'll excuse me, I'm going to freshen up my drink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]`

### Węzeł `[424]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Default_Azaro_Partner == false && RiziaDLC.Pabel_RelationshipPublic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`
  - -> `[426]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Default_Azaro_Partner == false && RiziaDLC.Pabel_RelationshipPublic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Partner"] == false  and  Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Default_Azaro_Partner == false && RiziaDLC.Pabel_RelationshipPublic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Partner"] == false  and  Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Default_Azaro_Partner = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Partner"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[428]`
Mówca: **Taddeus Azaro**
> ""I can tell you now that the late King Valero always had his suspicions about your... leanings. But having seen you and Princess Lena together, I never would have guessed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`
  - -> `[431]`

### Węzeł `[430]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`
  - -> `[434]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[435]`
Mówca: **Lucita Azaro**
> ""To be honest, I wasn't surprised in the least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[436]`
Mówca: **Narrator**
> "She looked me in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[437]`
Mówca: **Lucita Azaro**
> ""My most heartfelt of congratulations to you and Mr. Adria. I mean it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`
  - -> `[456]`
  - -> `[459]`
  - -> `[460]`

### Węzeł `[438]`
Mówca: **Carlos Robles Azaro**
> ""It's an unusual predilection for a Rizian king. But you and Mr. Adria have my most heartfelt of congratulations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`
  - -> `[456]`
  - -> `[459]`
  - -> `[460]`

### Węzeł `[439]`
Mówca: **Taddeus Azaro**
> ""I... yes, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[440]`
Mówca: **Taddeus Azaro**
> ""I can tell you now that the late King Valero always had his suspicions about your... leanings. But having seen you in action in the military, I was shocked to hear the news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[441]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`
  - -> `[443]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[444]`
Mówca: **Taddeus Azaro**
> ""I can tell you now that the late King Valero always had his suspicions about your... leanings. I never would have guessed, myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`
  - -> `[447]`

### Węzeł `[446]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[447]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[448]`
Mówca: **Lucita Azaro**
> ""Father. Are you saying that one can't prefer the company of men and be a skilled soldier at the same time?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[449]`
Mówca: **Carlos Robles Azaro**
> ""Look at the Derdians, Taddeus. Hell, I'm beginning to think we should mandate homosexuality in basic training.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`
  - -> `[459]`
  - -> `[460]`
  - -> `[452]`

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your congratulations are accepted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mandatory homosexuality in the military... I feel a new decree coming on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[452]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`
  - -> `[454]`

### Węzeł `[453]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[454]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You had better mean it. Anyone who dares to challenge the legitimacy of the King's new partnership is a traitor to the realm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`
  - -> `[458]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[458]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[459]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What exactly did my father say about me, General Taddeus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[460]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope all of Cardesse-Montaklar shares your tolerance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[461]`
Mówca: **Taddeus Azaro**
> ""We will see to it that they do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[462]`
Mówca: **Narrator**
> "Horrified looks spread across the Azaros' faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[463]`
Mówca: **Carlos Robles Azaro**
> ""That was meant as a joke, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[464]`
Mówca: **Taddeus Azaro**
> ""Your Majesty... perhaps those opinions are best left buried with him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[465]`
Mówca: **Narrator**
> "He winced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[466]`
Mówca: **Narrator**
> "Taddeus hurriedly interjected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[467]`
Mówca: **Taddeus Azaro**
> ""We are all very happy for you, Your Majesty. We'll see to it that Cardesse-Montaklar celebrates your new love as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[468]`
Mówca: **Taddeus Azaro**
> ""It will take some time for the people of our province to accept this news. But we'll see to it that they do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[469]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Azaro Default Convo Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`
  - -> `[472]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reforms_DiscussedOnYacht == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[473]`
Mówca: **Taddeus Azaro**
> ""I wasn't very lucid at the time, but I do recall talk amongst our house that you had intentions to reform the monarchy against the nobility's will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[474]`
Mówca: **Taddeus Azaro**
> ""Fortunately, it seems we were mistaken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`
  - -> `[478]`
  - -> `[477]`
  - -> `[485]`

### Węzeł `[475]`
Mówca: **Taddeus Azaro**
> ""Your Majesty, I assure you that House Azaro does not harbor any ill will against the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[476]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who was spreading such rumors? Tell me, and I'll have them hanged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[477]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, you were. There will be no anti-nobility reforms on King Romus' watch, mark my words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Silent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`
  - -> `[480]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Silent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Silent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`
  - -> `[486]`

### Węzeł `[480]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Silent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Silent"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[481]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""*If* I were planning to reform the country, I would not do so against your house's will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[482]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`
  - -> `[484]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I allowed Manus Sazon to plead his case for reform, yes. But ultimately, I rejected his misguided ideas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]`

### Węzeł `[486]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Surely you don't believe that Rizia can stay the same forever. A kingdom must adapt to the changing times and the will of its people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[487]`
Mówca: **Narrator**
> "Taddeus paled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[488]`
Mówca: **Taddeus Azaro**
> ""Nobody in particular.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[489]`
Mówca: **Taddeus Azaro**
> ""That may be so. But such decisions must be made in consultation with provincial leaders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[791]`

### Węzeł `[490]`
Mówca: **Lucita Azaro**
> ""Good to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[491]`
Mówca: **Taddeus Azaro**
> ""Hmm. So you don't deny your intentions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]`

### Węzeł `[492]`
Mówca: **Taddeus Azaro**
> ""Especially not since one of our own is now a part of the Royal Family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[493]`
Mówca: **Taddeus Azaro**
> ""Especially not on the Queen Mother's birthday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[494]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`
  - -> `[496]`

### Węzeł `[495]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[497]`
Mówca: **Taddeus Azaro**
> ""If that is indeed the case, then I assure you House Azaro does not harbor any ill will towards the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[498]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Suspicion += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Suspicion"] = Variable["RiziaDLC.Reform_Suspicion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[499]`
Mówca: **Taddeus Azaro**
> ""In any case, Your Majesty, you must believe that House Azaro harbors no ill will against the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[500]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`
  - -> `[408]`
  - -> `[409]`

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true && RiziaDLC.War_Pales_Operation1_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`
  - -> `[503]`

### Węzeł `[502]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true && RiziaDLC.War_Pales_Operation1_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[503]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true && RiziaDLC.War_Pales_Operation1_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[504]`
Mówca: **Taddeus Azaro**
> ""Just one, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[505]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_WehlenJoined == true || RiziaDLC.War_Objective_Captured_Pales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`
  - -> `[507]`

### Węzeł `[506]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_WehlenJoined == true || RiziaDLC.War_Objective_Captured_Pales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_WehlenJoined"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Pales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[507]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_WehlenJoined == true || RiziaDLC.War_Objective_Captured_Pales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_WehlenJoined"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Pales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[508]`
Mówca: **Taddeus Azaro**
> ""Now that victory in Pales is all but a certainty, House Azaro humbly wishes to resume its governance of the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`
  - -> `[516]`
  - -> `[513]`
  - -> `[511]`

### Węzeł `[509]`
Mówca: **Taddeus Azaro**
> ""Should we achieve victory in Pales, House Azaro humbly wishes to resume its governance of the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`
  - -> `[516]`
  - -> `[513]`
  - -> `[511]`

### Węzeł `[510]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Resume? Pales hasn't even been a part of Rizia for over two centuries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[511]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course, General. For your service during this war and the one that preceded it, you deserve it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[512]`
Mówca: **Lucita Azaro**
> ""That may be true. But we Azaros have long memories.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`
  - -> `[539]`
  - -> `[522]`
  - -> `[528]`
  - -> `[533]`

### Węzeł `[513]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleOwnership_RiziaImperii == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`
  - -> `[515]`

### Węzeł `[514]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleOwnership_RiziaImperii == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[515]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleOwnership_RiziaImperii == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[516]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales will be in a state of instability after it is reconquered. It needs the full attention of the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[517]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We centralized Zille following its return. I was planning on doing the same with Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[518]`
Mówca: **Narrator**
> "Taddeus bowed so deeply he almost fell off his wheelchair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[519]`
Mówca: **Taddeus Azaro**
> ""You are too generous, my liege.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[520]`
Mówca: **Taddeus Azaro**
> ""We have fought the Palesians twice. Do you truly believe we can't handle a little instability?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`
  - -> `[539]`
  - -> `[522]`
  - -> `[528]`
  - -> `[533]`

### Węzeł `[521]`
Mówca: **Lucita Azaro**
> ""So you would give our house the same treatment as the Sazons? The traitors?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`
  - -> `[539]`
  - -> `[522]`
  - -> `[528]`
  - -> `[533]`

### Węzeł `[522]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Pales == false && RiziaDLC.War_WehlenJoined == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`
  - -> `[524]`

### Węzeł `[523]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Pales == false && RiziaDLC.War_WehlenJoined == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Pales"] == false  and  Variable["RiziaDLC.War_WehlenJoined"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[524]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Objective_Captured_Pales == false && RiziaDLC.War_WehlenJoined == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Pales"] == false  and  Variable["RiziaDLC.War_WehlenJoined"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[525]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't foresee a happy ending to this war. Chances are that no one in Rizia will end up governing Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[526]`
Mówca: **Taddeus Azaro**
> ""Don't count us out just yet, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[527]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If it truly means that much to you, I will consider your request. Once we win, that is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[528]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_WehlenJoined == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`
  - -> `[530]`

### Węzeł `[529]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_WehlenJoined == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_WehlenJoined"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_WehlenJoined == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_WehlenJoined"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[531]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With Wiktor Smolak now involved, the decision may be out of my hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[532]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By the time the war is over, the decision may be out of my hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Silent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`
  - -> `[535]`

### Węzeł `[534]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Silent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Silent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[535]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Silent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Silent"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[536]`
Mówca: **Narrator**
> "Both Azaros looked at me strangely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[537]`
Mówca: **Taddeus Azaro**
> ""What do you mean, out of your hands? You're the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[538]`
Mówca: **Taddeus Azaro**
> ""We cannot allow Wehlen to control us yet again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[539]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why do you want Pales so badly, anyway? It'll be a smoking ruin by the time our armies are done with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[540]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Suspicion += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Suspicion"] = Variable["RiziaDLC.Reform_Suspicion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[541]`
Mówca: **Taddeus Azaro**
> ""But very well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`

### Węzeł `[542]`
Mówca: **Taddeus Azaro**
> ""But it will give us the sea, Your Majesty. Something all the other provinces have that we in Cardesse-Montaklar lack.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[543]`
Mówca: **Lucita Azaro**
> ""We *will* win Pales. And when we do, I hope you will think of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`

### Węzeł `[544]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`
  - -> `[546]`

### Węzeł `[545]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[546]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`

### Węzeł `[547]`
Mówca: **Narrator**
> "Taddeus and Lucita looked at each other. Finally, Lucita spoke up gently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[548]`
Mówca: **Lucita Azaro**
> ""We do have one request.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[549]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, good. I'd hate to think that any of you were plotting against me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`

### Węzeł `[550]`
Mówca: **Taddeus Azaro**
> ""Your Majesty, I can't express how happy I am that you and my daughter are expecting a child.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[551]`
Mówca: **Taddeus Azaro**
> ""And my greatest hope is that if that child is male, he will take his rightful place as successor to the throne of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`
  - -> `[553]`
  - -> `[561]`

### Węzeł `[552]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, Taddeus, but I cannot guarantee that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[553]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course royal tradition will be respected. If we have a boy, he will inherit the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[554]`
Mówca: **Narrator**
> "My wife stepped backward, shaken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[555]`
Mówca: **Lucita Azaro**
> ""You can't?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`
  - -> `[585]`
  - -> `[586]`

### Węzeł `[556]`
Mówca: **Lucita Azaro**
> ""Our child will represent the union of House Toras and House Azaro. A new way forward for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[557]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`
  - -> `[559]`

### Węzeł `[558]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[559]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[560]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have no idea if Vina is even alive or dead. As far as I'm concerned, Lucita's child is my only heir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[561]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`
  - -> `[563]`

### Węzeł `[562]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[564]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I made a promise to Vina long ago. I can't break it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[565]`
Mówca: **Lucita Azaro**
> ""And after the way she humiliated you, does she even deserve to be your heir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`
  - -> `[576]`
  - -> `[571]`

### Węzeł `[566]`
Mówca: **Lucita Azaro**
> ""We're doing our best to coordinate her rescue, but realistically, she might not make it back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`
  - -> `[576]`
  - -> `[571]`

### Węzeł `[567]`
Mówca: **Lucita Azaro**
> ""Thank you, Romus. That means so much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[568]`
Mówca: **Narrator**
> "She looked at me with pleading eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[569]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes... you're right. *If* we have a son, he will take Vina's place as successor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[570]`
Mówca: **Narrator**
> "She looked at Taddeus apologetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[571]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't even know the sex of our child yet. I will make this decision when the time comes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[572]`
Mówca: **Narrator**
> "She breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[573]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you truly love *me*, you'll understand why I have to put my daughter first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[574]`
Mówca: **Lucita Azaro**
> ""No, of course I'm not!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[575]`
Mówca: **Lucita Azaro**
> ""I know how much you love Vina. But if she loves you too, she'll understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`
  - -> `[571]`
  - -> `[573]`

### Węzeł `[576]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you saying? Are you *hoping* my daughter never returns?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[577]`
Mówca: **Lucita Azaro**
> ""I am sure His Majesty will make the right decision when the time comes, Father. We shouldn't press the issue while Her Highness is still missing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[578]`
Mówca: **Narrator**
> "Taddeus sighed in frustration. Lucita looked at him apologetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[579]`
Mówca: **Lucita Azaro**
> ""He's right, Father. We're getting ahead of ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[580]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Promised_Succession_Son_RespectTradition = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Promised_Succession_Son_RespectTradition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[581]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_PromisedQueen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`
  - -> `[583]`

### Węzeł `[582]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_PromisedQueen == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_PromisedQueen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`

### Węzeł `[583]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_PromisedQueen == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_PromisedQueen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[584]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina wants to be queen more than anything. I can't take that away from her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[585]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For political reasons, I must name my daughter as successor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[586]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A male heir ought not to be favored over his female older sibling. I intend to change that sexist policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[587]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`
  - -> `[589]`

### Węzeł `[588]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[589]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`

### Węzeł `[590]`
Mówca: **Lucita Azaro**
> ""But, Romus... what about us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[591]`
Mówca: **Lucita Azaro**
> ""But, Romus... we don't even know where Vina is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[592]`
Mówca: **Narrator**
> "My wife breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[593]`
Mówca: **Narrator**
> "My wife stroked my arm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[594]`
Mówca: **Lucita Azaro**
> ""Vina will come back, Romus. And when she does, she'll understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[595]`
Mówca: **Taddeus Azaro**
> ""Yes, all right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[596]`
Mówca: **Narrator**
> "Taddeus sighed in frustration. Lucita looked at him apologetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[597]`
Mówca: **Lucita Azaro**
> ""I am sure His Majesty will make the right decision when the time comes, Father. We shouldn't press the issue now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[598]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Azaro Default Convo Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[599]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Azaro Default Convo Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[600]`
Mówca: **Taddeus Azaro**
> ""If you can't guarantee us Pales, I would hope you can promise this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[601]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`
  - -> `[603]`

### Węzeł `[602]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]`

### Węzeł `[603]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[604]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Default_Azaro_Succession == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`
  - -> `[606]`

### Węzeł `[605]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Default_Azaro_Succession == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Succession"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`

### Węzeł `[606]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Default_Azaro_Succession == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Succession"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[607]`
Mówca: **Narrator**
> "He and Lucita looked at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[608]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PromisedToHouseAzaro = true; RiziaDLCIsolated.Turn10_Gathering_AzaroBoost += 5)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pales_PromisedToHouseAzaro"] = true;
Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] + 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[609]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`
  - -> `[611]`

### Węzeł `[610]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[611]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`

### Węzeł `[612]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Azaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`
  - -> `[614]`

### Węzeł `[613]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Azaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Azaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`

### Węzeł `[614]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Coup_Azaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Azaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[615]`
Mówca: **Narrator**
> "Carlos smiled, showing all his teeth as he did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`

### Węzeł `[616]`
Mówca: **Carlos Robles Azaro**
> ""The alliance between our two houses is the bedrock on which Rizia stands, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[617]`
Mówca: **Taddeus Azaro**
> ""Well put, Carlos.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`

### Węzeł `[618]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`
  - -> `[620]`

### Węzeł `[619]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[620]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[621]`
Mówca: **Narrator**
> "Carlos removed his hat and smiled sincerely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`

### Węzeł `[622]`
Mówca: **Narrator**
> "Taddeus put a hand to his chest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`

### Węzeł `[623]`
Mówca: **Taddeus Azaro**
> ""The alliance between our two houses is the bedrock on which Rizia stands, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[624]`
Mówca: **Lucita Azaro**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`

### Węzeł `[625]`
Mówca: **Narrator**
> "I saw a hint of sorrow in Taddeus' eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`

### Węzeł `[626]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Azaro Default Convo Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[627]`
Mówca: **Carlos Robles Azaro**
> ""Never in a million years, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]`

### Węzeł `[628]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]`
  - -> `[630]`

### Węzeł `[629]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[630]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]`

### Węzeł `[631]`
Mówca: **Lucita Azaro**
> ""I swear you can count on my family's loyalty, {RiziaDLCText.LucitaToPlayer}.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]`

### Węzeł `[632]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still have to convince the other houses. But the Azaros are the most vital piece of the puzzle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`

### Węzeł `[633]`
Mówca: **Taddeus Azaro**
> ""Good luck.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[634]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`
  - -> `[636]`

### Węzeł `[635]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[636]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[637]`
Mówca: **Carlos Robles Azaro**
> ""Taddeus, the Viscount of Nelvisar has been waiting all night to congratulate you on your recovery. Shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[638]`
Mówca: **Lucita Azaro**
> ""Father, the Viscount of Nelvisar has been waiting all night to congratulate you on your recovery. Shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[639]`
Mówca: **Taddeus Azaro**
> ""Yes. Please excuse us, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[640]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true && RiziaDLC.Lucita_Arrested == true && RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`
  - -> `[642]`

### Węzeł `[641]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true && RiziaDLC.Lucita_Arrested == true && RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[642]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true && RiziaDLC.Lucita_Arrested == true && RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[643]`
Mówca: **Carlos Robles Azaro**
> ""I do have one wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[644]`
Mówca: **Narrator**
> "Taddeus raised an eyebrow in his direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`

### Węzeł `[645]`
Mówca: **Taddeus Azaro**
> ""Only that you enjoy the evening as much as we have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[646]`
Mówca: **Narrator**
> "Taddeus shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`

### Węzeł `[647]`
Mówca: **Carlos Robles Azaro**
> ""I have visited my cousin -- Lucita -- in prison. She swears she is innocent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]`
  - -> `[651]`
  - -> `[652]`
  - -> `[653]`

### Węzeł `[648]`
Mówca: **Taddeus Azaro**
> ""I hope there will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[649]`
Mówca: **Taddeus Azaro**
> ""You are most welcome, Your Majesty. But I do wish I could have served you for longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[650]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you saying that you know better than the international courts?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[651]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm truly sorry, but I cannot exonerate Lucita as long as Rizia remains allied with Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`

### Węzeł `[652]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course, she'll never admit to her guilt. I thought you were too smart to fall for her lies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[653]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It doesn't matter. By imprisoning her, we avoided a war that would have cost us thousands of lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`

### Węzeł `[654]`
Mówca: **Carlos Robles Azaro**
> ""No, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`

### Węzeł `[655]`
Mówca: **Carlos Robles Azaro**
> ""I understand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`

### Węzeł `[656]`
Mówca: **Carlos Robles Azaro**
> ""I know Lucita well, Your Majesty. I don't believe she's lying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`

### Węzeł `[657]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_Gathering_AzaroBoost -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`

### Węzeł `[658]`
Mówca: **Carlos Robles Azaro**
> ""I understand... I think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`

### Węzeł `[659]`
Mówca: **Narrator**
> "Taddeus put a hand on his cousin's shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`

### Węzeł `[660]`
Mówca: **Taddeus Azaro**
> ""Carlos. Do not question the Crown's justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`

### Węzeł `[661]`
Mówca: **Carlos Robles Azaro**
> ""I am not asking that Lucita be exonerated. Only that her life be spared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`
  - -> `[663]`
  - -> `[664]`
  - -> `[665]`

### Węzeł `[662]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What kind of monster do you think I am, General? I would never execute Duchess Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[663]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The punishment for those who betray the Crown is death. Are you implying the Duchess is above the law?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[664]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your love for your cousin moves me. I will honor your request and spare her from execution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`

### Węzeł `[665]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why stop there? Why shouldn't Rizia do away with the death penalty entirely?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[666]`
Mówca: **Narrator**
> "Carlos bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`

### Węzeł `[667]`
Mówca: **Carlos Robles Azaro**
> ""That is all I ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`

### Węzeł `[668]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]`
  - -> `[670]`

### Węzeł `[669]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[670]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]`

### Węzeł `[671]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right, Carlos. Death is too good for Lucita. Your traitorous cousin should be tortured for the rest of her miserable life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]`

### Węzeł `[672]`
Mówca: **Carlos Robles Azaro**
> ""No! That's not what I meant...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[673]`
Mówca: **Narrator**
> "Carlos bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[674]`
Mówca: **Carlos Robles Azaro**
> ""That's most merciful of you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`

### Węzeł `[675]`
Mówca: **Carlos Robles Azaro**
> ""No... Only that if there is even a slim possibility she is innocent, she should be given the benefit of the doubt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]`

### Węzeł `[676]`
Mówca: **Carlos Robles Azaro**
> ""Your Majesty, I still believe that the evildoers of Rizia should be punished to the full extent of the law. But my cousin is not among them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`
  - -> `[678]`
  - -> `[681]`

### Węzeł `[677]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Everybody is somebody's cousin, aren't they? All criminals should similarly be given the benefit of the doubt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]`

### Węzeł `[678]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was speaking rhetorically. If I spare Lucita, I'll get flooded with requests to spare everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`

### Węzeł `[679]`
Mówca: **Narrator**
> "Carlos and Taddeus both gave me looks of offense."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`

### Węzeł `[680]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was joking, Carlos. You know how much I love a good beheading.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`

### Węzeł `[681]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]`
  - -> `[683]`

### Węzeł `[682]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[683]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[684]`
Mówca: **Carlos Robles Azaro**
> ""Oh... Very funny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`
  - -> `[691]`
  - -> `[692]`

### Węzeł `[685]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Other countries have stopped using this barbaric form of punishment. Perhaps we really should consider it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]`

### Węzeł `[686]`
Mówca: **Taddeus Azaro**
> ""That is a discussion for another time, I think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]`
  - -> `[690]`
  - -> `[691]`
  - -> `[692]`

### Węzeł `[687]`
Mówca: **Carlos Robles Azaro**
> ""I am speaking on behalf of House Azaro. One of the oldest and most powerful noble families in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`
  - -> `[691]`
  - -> `[692]`

### Węzeł `[688]`
Mówca: **Carlos Robles Azaro**
> ""I am not asking for a removal of the death penalty. I am asking for an exception, because this is an exceptional circumstance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]`
  - -> `[690]`
  - -> `[691]`
  - -> `[692]`

### Węzeł `[689]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita will live. And I will rethink Rizia's policy of killing criminals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]`

### Węzeł `[690]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. As long as I am King, your cousin will not be executed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[691]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as the death penalty still exists, every Rizian who has committed a serious enough felony will be subject to it. Without exception.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]`

### Węzeł `[692]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will consider your house's request. That is all I can promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`

### Węzeł `[693]`
Mówca: **Carlos Robles Azaro**
> ""I... thank you, Your Majesty. You are most merciful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[694]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_Gathering_AzaroBoost += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[695]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_Gathering_AzaroBoost += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[696]`
Mówca: **Carlos Robles Azaro**
> ""Please consider our request. That is all I ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[697]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_Gathering_AzaroBoost -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]`

### Węzeł `[698]`
Mówca: **Taddeus Azaro**
> ""Carlos. Your Majesty. Perhaps we should leave this be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[699]`
Mówca: **Narrator**
> "His face hardened into a scowl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[700]`
Mówca: **Carlos Robles Azaro**
> ""Your Majesty. I truly beg you to reconsider.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[701]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]`
  - -> `[703]`

### Węzeł `[702]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`

### Węzeł `[703]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`

### Węzeł `[704]`
Mówca: **Taddeus Azaro**
> ""I have certainly appreciated your commitment to strengthening the Rizian armed forces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`

### Węzeł `[705]`
Mówca: **Taddeus Azaro**
> ""Rizia's armed forces are currently too weak to be put in such a position, but with more investment, it could work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`

### Węzeł `[706]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]`
  - -> `[708]`

### Węzeł `[707]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]`

### Węzeł `[708]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]`

### Węzeł `[709]`
Mówca: **Taddeus Azaro**
> ""If our troops achieve victory in Pales, the public will not only accept the change, but celebrate it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[710]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]`
  - -> `[712]`

### Węzeł `[711]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]`

### Węzeł `[712]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[713]`
Mówca: **Taddeus Azaro**
> ""If we can overcome the current unrest, I'm sure the public will accept the change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[714]`
Mówca: **Taddeus Azaro**
> ""With my daughter in place as Queen Consort, I would ask that you appoint me to my old seat on the Royal Council to help plan the transition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]`
  - -> `[719]`
  - -> `[720]`
  - -> `[721]`

### Węzeł `[715]`
Mówca: **Lucita Azaro**
> ""Realizing Ana Azaro's vision of a monarcho-military alliance. We spoke of this while you were still convalescing, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[716]`
Mówca: **Taddeus Azaro**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`

### Węzeł `[717]`
Mówca: **Narrator**
> "He and Lucita looked at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]`

### Węzeł `[718]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Done. There are no other suitable candidates, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[719]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you confident you have the health and stamina to resume the position?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[720]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's it? This will be easier than I thought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`

### Węzeł `[721]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was hoping to reward Captain Gordion with the position. But I will consider you instead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]`

### Węzeł `[722]`
Mówca: **Taddeus Azaro**
> ""I do have one more request.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[723]`
Mówca: **Taddeus Azaro**
> ""As I served His Majesty Valero, so would I pledge to serve you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`

### Węzeł `[724]`
Mówca: **Taddeus Azaro**
> ""If this alliance is to work, the union of Azaro and Toras must last for generations to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]`

### Węzeł `[725]`
Mówca: **Taddeus Azaro**
> ""It is therefore my hope that if your child is male, he will take his rightful place as successor to the throne of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]`
  - -> `[727]`
  - -> `[735]`

### Węzeł `[726]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, Taddeus, but I cannot guarantee that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`

### Węzeł `[727]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course royal tradition will be respected. If we have a boy, he will inherit the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]`

### Węzeł `[728]`
Mówca: **Narrator**
> "My wife stepped backward, shaken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]`

### Węzeł `[729]`
Mówca: **Lucita Azaro**
> ""You can't?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[753]`
  - -> `[757]`
  - -> `[758]`

### Węzeł `[730]`
Mówca: **Lucita Azaro**
> ""Our child will represent the union of House Toras and House Azaro. A new way forward for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]`

### Węzeł `[731]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]`
  - -> `[733]`

### Węzeł `[732]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]`

### Węzeł `[733]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]`

### Węzeł `[734]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have no idea if Vina is even alive or dead. As far as I'm concerned, Lucita's child is my only heir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]`

### Węzeł `[735]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]`
  - -> `[737]`

### Węzeł `[736]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]`

### Węzeł `[737]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[738]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I made a promise to Vina long ago. I can't break it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`

### Węzeł `[739]`
Mówca: **Lucita Azaro**
> ""And after the way she humiliated you, does she even deserve to be your heir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`
  - -> `[743]`
  - -> `[745]`

### Węzeł `[740]`
Mówca: **Lucita Azaro**
> ""We're doing our best to coordinate her rescue, but realistically, she might not make it back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`
  - -> `[743]`
  - -> `[745]`

### Węzeł `[741]`
Mówca: **Lucita Azaro**
> ""Thank you, Romus. That means so much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]`

### Węzeł `[742]`
Mówca: **Narrator**
> "She looked at me with pleading eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]`

### Węzeł `[743]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes... you're right. *If* we have a son, he will take Vina's place as successor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[746]`

### Węzeł `[744]`
Mówca: **Narrator**
> "She looked at Taddeus apologetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]`

### Węzeł `[745]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't even know the sex of our child yet. I will make this decision when the time comes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]`

### Węzeł `[746]`
Mówca: **Narrator**
> "She breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]`

### Węzeł `[747]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you truly love *me*, you'll understand why I have to put my daughter first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]`

### Węzeł `[748]`
Mówca: **Lucita Azaro**
> ""No, of course I'm not!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]`

### Węzeł `[749]`
Mówca: **Lucita Azaro**
> ""I know how much you love Vina. But if she loves you too, she'll understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]`
  - -> `[745]`
  - -> `[747]`

### Węzeł `[750]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you saying? Are you *hoping* my daughter never returns?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[748]`

### Węzeł `[751]`
Mówca: **Narrator**
> "Taddeus sighed in frustration. Lucita looked at him apologetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]`

### Węzeł `[752]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Promised_Succession_Son_RespectTradition = true; RiziaDLC.Path_Stratocracy = true; RiziaDLCIsolated.Turn10_Gathering_AzaroBoost += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Promised_Succession_Son_RespectTradition"] = true;
Variable["RiziaDLC.Path_Stratocracy"] = true;
Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]`

### Węzeł `[753]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_PromisedQueen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`
  - -> `[755]`

### Węzeł `[754]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_PromisedQueen == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_PromisedQueen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[755]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_PromisedQueen == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_PromisedQueen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]`

### Węzeł `[756]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina wants to be queen more than anything. I can't take that away from her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`

### Węzeł `[757]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For political reasons, I must name my daughter as successor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`

### Węzeł `[758]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A male heir ought not to be favored over his female older sibling. I intend to change that sexist policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`

### Węzeł `[759]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]`
  - -> `[761]`

### Węzeł `[760]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]`

### Węzeł `[761]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]`

### Węzeł `[762]`
Mówca: **Lucita Azaro**
> ""But, Romus... what about us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]`

### Węzeł `[763]`
Mówca: **Lucita Azaro**
> ""But, Romus... we don't even know where Vina is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]`

### Węzeł `[764]`
Mówca: **Narrator**
> "My wife breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]`

### Węzeł `[765]`
Mówca: **Narrator**
> "My wife stroked my arm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]`

### Węzeł `[766]`
Mówca: **Lucita Azaro**
> ""Vina will come back, Romus. And when she does, she'll understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]`

### Węzeł `[767]`
Mówca: **Narrator**
> "Taddeus sighed in frustration. Lucita looked at him apologetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]`

### Węzeł `[768]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Azaro Default Convo Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[769]`
Mówca: **Taddeus Azaro**
> ""Your Majesty, if you cannot even commit to follow royal tradition, than I don't see how we can work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]`

### Węzeł `[770]`
Mówca: **Taddeus Azaro**
> ""But of course, the Rizian military is still at your disposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]`

### Węzeł `[771]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_Gathering_AzaroBoost -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] = Variable["RiziaDLCIsolated.Turn10_Gathering_AzaroBoost"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]`

### Węzeł `[772]`
Mówca: **Carlos Robles Azaro**
> ""So what's going to happen now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]`

### Węzeł `[773]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]`
  - -> `[775]`

### Węzeł `[774]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[772]`

### Węzeł `[775]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]`

### Węzeł `[776]`
Mówca: **Narrator**
> "Taddeus smiled proudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]`

### Węzeł `[777]`
Mówca: **Taddeus Azaro**
> ""History will remember this day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[773]`

### Węzeł `[778]`
Mówca: **Lucita Azaro**
> ""Our next step should be to establish a headquarters for the military in Porte Drazon. Ideally in or near Palas Rezna...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[779]`
Mówca: **Taddeus Azaro**
> ""But we are getting ahead of ourselves. For now, let's enjoy this evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]`

### Węzeł `[780]`
Mówca: **Taddeus Azaro**
> ""I will submit my petition regardless. I place my fate in your hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[781]`
Mówca: **Taddeus Azaro**
> ""I was as saddened by my daughter's betrayal as you were. She certainly does not represent all of the Azaros.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]`

### Węzeł `[782]`
Mówca: **Narrator**
> "Taddeus' expression turned mournful."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[781]`

### Węzeł `[783]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]`
  - -> `[408]`
  - -> `[599]`
  - -> `[409]`

### Węzeł `[784]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have members of House Azaro expressed any dissatisfaction about my reign?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]`

### Węzeł `[785]`
Mówca: **Narrator**
> "Taddeus shook his head hurriedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]`

### Węzeł `[786]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[787]`
  - -> `[788]`

### Węzeł `[787]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]`

### Węzeł `[788]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reforms_DiscussedOnYacht == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[789]`
Mówca: **Taddeus Azaro**
> ""At some point during my recovery, I did hear talk amongst our house that you had intentions to reform the monarchy against the nobility's will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`
  - -> `[478]`
  - -> `[477]`
  - -> `[485]`

### Węzeł `[790]`
Mówca: **Taddeus Azaro**
> ""No. Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[789]`

### Węzeł `[791]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]`
  - -> `[793]`

### Węzeł `[792]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]`

### Węzeł `[793]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[794]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[795]`
  - -> `[796]`

### Węzeł `[795]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[796]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[797]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Because if you *were* plotting against me, I would find out. And I would crush your so-called noble house into a million bloody pieces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]`

### Węzeł `[798]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`
  - -> `[800]`

### Węzeł `[799]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[797]`

### Węzeł `[800]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]`

### Węzeł `[801]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do value honesty among my subjects. If I did find out that any member of House Azaro was planning to challenge the throne, the consequences would be *extremely* dire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]`

### Węzeł `[802]`
Mówca: **Taddeus Azaro**
> ""Please, Your Majesty. The Crown has our fealty now and forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[803]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [HOUSE GATHERING CONVERSATION HUB])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `554` (*Rizia/Turn 10/DEFAULT GATHERING SCENE/DEFAULT GATHERING SCENE Conversation*), Węzeł `[5]`

### Węzeł `[804]`
Mówca: **Taddeus Azaro**
> ""It was a pleasure speaking with you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]`

### Węzeł `[805]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]`
  - -> `[807]`

### Węzeł `[806]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]`

### Węzeł `[807]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[809]`

### Węzeł `[808]`
Mówca: **Narrator**
> "He saluted once more as Carlos rolled his wheelchair away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]`

### Węzeł `[809]`
Mówca: **Narrator**
> "He saluted once more as Lucita rolled his wheelchair away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]`

### Węzeł `[810]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Default_Azaro_Portrait = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Portrait"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[811]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Default_Azaro_Portrait == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]`
  - -> `[813]`

### Węzeł `[812]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Default_Azaro_Portrait == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Portrait"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[813]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Default_Azaro_Portrait == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Default_Azaro_Portrait"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[814]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Path_Stratocracy == true || RiziaDLC.Lucita_DiscussedStratocracy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]`
  - -> `[816]`

### Węzeł `[815]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Path_Stratocracy == true || RiziaDLC.Lucita_DiscussedStratocracy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Path_Stratocracy"] == true  or  Variable["RiziaDLC.Lucita_DiscussedStratocracy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]`

### Węzeł `[816]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Path_Stratocracy == true || RiziaDLC.Lucita_DiscussedStratocracy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Path_Stratocracy"] == true  or  Variable["RiziaDLC.Lucita_DiscussedStratocracy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[817]`
Mówca: **Lucita Azaro**
> ""The Rizian royal family endowed with the strength of the military. A vision of what's to come, perhaps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]`

### Węzeł `[818]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_Birthday_AzaroLevyPromise = true;
RiziaDLC.NatDes_UniteHousesAgainst_Azaro = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_Birthday_AzaroLevyPromise"] = true;
Variable["RiziaDLC.NatDes_UniteHousesAgainst_Azaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[819]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_Birthday_AzaroLevyPromise = true; RiziaDLC.NatDes_UniteHousesAgainst_Azaro = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_Birthday_AzaroLevyPromise"] = true;
Variable["RiziaDLC.NatDes_UniteHousesAgainst_Azaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[820]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[821]`
  - -> `[822]`

### Węzeł `[821]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[822]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[823]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]`
  - -> `[825]`

### Węzeł `[824]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[825]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[826]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PiplineNasDes_Taddeus_1926Uprising == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[827]`
  - -> `[828]`

### Węzeł `[827]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PiplineNasDes_Taddeus_1926Uprising == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PiplineNasDes_Taddeus_1926Uprising"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[829]`

### Węzeł `[828]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PiplineNasDes_Taddeus_1926Uprising == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PiplineNasDes_Taddeus_1926Uprising"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[829]`
Mówca: **Taddeus Azaro**
> ""As I've mentioned before, the current atmosphere mirrors that of 1926.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[830]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]`
  - -> `[832]`

### Węzeł `[831]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]`

### Węzeł `[832]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[835]`

### Węzeł `[833]`
Mówca: **Lucita Azaro**
> ""And the Royal Council, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[834]`
Mówca: **Lucita Azaro**
> ""Father. He's made himself clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[835]`
Mówca: **Carlos Robles Azaro**
> ""His Majesty's made himself clear, my cousin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[836]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Taddeus Azaro");
RemoveConversant("Lucita Azaro");
RemoveConversant("Carlos Robles Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Taddeus Azaro");
RemoveConversant("Lucita Azaro");
RemoveConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[837]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Taddeus Azaro");
RemoveConversant("Lucita Azaro");
RemoveConversant("Carlos Robles Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Taddeus Azaro");
RemoveConversant("Lucita Azaro");
RemoveConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]`
