# Rizia/FREEPRESS/FREEPRESS Conversation

- **ID konwersacji:** `581`
- **StoryPack:** `Rizia`
- **Tura:** `Decree (FREEPRESS)`
- **Lokalizacja pliku:** `Rizia/Decrees/581_FREEPRESS_Conversation.md`
- **Liczba węzłów dialogowych:** 217
- **Liczba wyborów gracza:** 55

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_Arrested`
- `RiziaDLC.Adarfo_Executed`
- `RiziaDLC.BirthdayGathering_ReformTalks`
- `RiziaDLC.HouseOfDelegates_Abolished`
- `RiziaDLC.Hugo_DecreeCounsel_Happened`
- `RiziaDLC.Manus_Gone`
- `RiziaDLC.Policy_RD_Welfare_ElectoralReform`
- `RiziaDLC.Reform_DeclareIntention_Public`
- `RiziaDLC.Reform_DeclareIntention_WeakStatement`
- `RiziaDLC.Reform_Movement_Grows`
- `RiziaDLC.Reform_Movement_Leader_Adarfo`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Relations_VinaManus_Approve`
- `RiziaDLC.Relations_VinaManus_ApproveAfterPales`
- `RiziaDLC.Relations_Vina_DancedWithManus`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax`
- `RiziaDLCSetup.CurrentTurn`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Hugo_CounselIgnored`
- `RiziaDLC.PersonalValue_FunnyKing`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[356] Rizia/CouncilRoyalDecrees** (../Decrees/356_CouncilRoyalDecrees.md), Węzeł `[54]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 12
- **Węzły modyfikujące stan gry:** 7

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[34]` (Paskal Beniwoll): `--;`
- Węzeł `[38]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- Węzeł `[114]` (Paskal Beniwoll): `EnactDecree("Welfare_HumanRights_AllowFreePress"); ;`
- Węzeł `[146]` (Paskal Beniwoll): `--;`
- Węzeł `[157]` (Paskal Beniwoll): `--;`
- Węzeł `[213]` (Paskal Beniwoll): `--;`
- Węzeł `[216]` (Paskal Beniwoll): `Variable["RiziaDLC.Hugo_CounselIgnored"] = Variable["RiziaDLC.Hugo_CounselIgnored"] + 1;`

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `356` (*Rizia/CouncilRoyalDecrees*), Węzeł `[54]`

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""So... freedom of press...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Gone == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Gone == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Manus_Gone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Manus_Gone == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Manus_Gone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[7]`
Mówca: **Narrator**
> "He stepped forward but didn't sit. His hands were resting behind his back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseOfDelegates_Abolished == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[11]`
Mówca: **Hugo Toras**
> ""I assume this is Manus Sazon whispering in your ear again?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[34]`

### Węzeł `[12]`
Mówca: **Hugo Toras**
> ""I assume this is the Rizian People's Party whispering in your ear again?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[34]`

### Węzeł `[13]`
Mówca: **Hugo Toras**
> ""So this is the trade, then? Dismantle their so-called democracy with one hand and toss them a printing press with the other?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[148]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true || RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true || RiziaDLC.Reform_DeclareIntention_Public == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true || RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true || RiziaDLC.Reform_DeclareIntention_Public == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true  or  Variable["RiziaDLC.Relations_VinaManus_Approve"] == true  or  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true  or  Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_DancedWithManus == true || RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true || RiziaDLC.Reform_DeclareIntention_Public == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true  or  Variable["RiziaDLC.Relations_VinaManus_Approve"] == true  or  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true  or  Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[17]`
Mówca: **Hugo Toras**
> ""Don't tell me it's that radical Sotelato who's whispering in your ear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[34]`

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""I don't approve of this decree in principle...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""So, you shut their mouths in the Delegate chamber but let them reach a larger audience in the streets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You give them too much credit, Hugo. My decisions are my own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""So this is the trade, then? Get rid of their leaders with one hand and toss them a printing press with the other?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[149]`

### Węzeł `[22]`
Mówca: **Hugo Toras**
> ""I assume this is Manus Sazon whispering in your ear?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[34]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_DeclareIntention_Public == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_DeclareIntention_Public == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_DeclareIntention_Public == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true  and  Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true  and  Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You give him too much credit, Hugo. My decisions are my own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And if it were? Does that make the idea wrong, or are you just opposed to it because of who supports it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Hugo, they've infiltrated the palace and now control my every move. I suspect they're hiding under my desk as we speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If giving the people something they want prevents greater unrest, then does it matter whose idea it was first?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is about modernizing Rizia, ensuring our people have access to information beyond what the state allows.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[30]`
  - -> `[35]`
  - -> `[39]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true || RiziaDLCSetup.CurrentTurn < 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true || RiziaDLCSetup.CurrentTurn < 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true || RiziaDLCSetup.CurrentTurn < 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] < 5) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Grows == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you not seen the growing reform movement? This is what the people are demanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you not seen the unrest on the streets? We have to listen to the people to calm the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[50]`
Mówca: **Hugo Toras**
> ""Or access to manipulation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Hugo Toras**
> ""Tell me, Your Majesty, what do you think happens the moment you allow 'free press' to operate unchecked?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[65]`
  - -> `[181]`
  - -> `[184]`
  - -> `[183]`

### Węzeł `[52]`
Mówca: **Hugo Toras**
> ""I oppose it because I know what will follow it. Permit the media to criticize you, and the RPP will only be the first to jump at the opportunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""Mock all you like, but it won't be so funny when their words start carrying more weight than ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[54]`
Mówca: **Hugo Toras**
> ""I've also seen what happens when rulers mistake concessions for control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[55]`
Mówca: **Hugo Toras**
> ""It matters if the *gift* you're giving them will one day be used to tear down the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[56]`
Mówca: **Hugo Toras**
> ""Of course they are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Change, Hugo. The kind we can guide, or the kind that will happen without us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_DeclareIntention_Public == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_DeclareIntention_Public == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_DeclareIntention_Public == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[61]`
Mówca: **Hugo Toras**
> ""But I can't help but notice that this decree was first proposed by the Rizian People's Party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == false || RiziaDLC.Reform_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == false || RiziaDLC.Reform_Path == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == false  or  Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == false || RiziaDLC.Reform_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == false  or  Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The same thing that happens when it's kept under a lock and key. People will find a way to speak. At least this way, I can see what they're saying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[66]`
Mówca: **Hugo Toras**
> ""I am worried, Romus. You've already thrown your weight behind the reform movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[67]`
Mówca: **Narrator**
> "He raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""Tell me, Romus, will that really make them easier to control?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[85]`
  - -> `[191]`
  - -> `[199]`
  - -> `[198]`
  - -> `[194]`

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""So, you shut down their leadership but let them reach a larger audience in the streets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[70]`
Mówca: **Hugo Toras**
> ""Or maybe it would be like giving your enemies a megaphone. An invitation to the radicals and demagogues to undermine you in broad daylight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Hugo Toras**
> ""And for what? The illusion of transparency? The satisfaction of appeasing the RPP?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[72]`
Mówca: **Hugo Toras**
> ""May I speak freely on this subject?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[99]`
  - -> `[96]`
  - -> `[209]`
  - -> `[210]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseOfDelegates_Abolished == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[76]`
Mówca: **Hugo Toras**
> ""I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Hugo Toras**
> ""However, I understand your intentions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Gone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Gone == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Manus_Gone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[84]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Manus_Gone == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Manus_Gone"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[81]`
Mówca: **Hugo Toras**
> ""It is an enormous risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[98]`
  - -> `[97]`
  - -> `[103]`

### Węzeł `[82]`
Mówca: **Narrator**
> "He exhaled slowly, as if holding back his immediate thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[83]`
Mówca: **Hugo Toras**
> ""But I suspect that after your move against the opposition, giving them the means to reach a larger audience may backfire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were the one who advised me to move against Manus, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == true  or  Variable["RiziaDLC.Adarfo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == true  or  Variable["RiziaDLC.Adarfo_Executed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[91]`
Mówca: **Hugo Toras**
> ""This is an invitation to the radicals and demagogues to undermine you in broad daylight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_DeclareIntention_WeakStatement == true && RiziaDLC.BirthdayGathering_ReformTalks == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_DeclareIntention_WeakStatement == true && RiziaDLC.BirthdayGathering_ReformTalks == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_DeclareIntention_WeakStatement"] == true  and  Variable["RiziaDLC.BirthdayGathering_ReformTalks"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_DeclareIntention_WeakStatement == true && RiziaDLC.BirthdayGathering_ReformTalks == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_DeclareIntention_WeakStatement"] == true  and  Variable["RiziaDLC.BirthdayGathering_ReformTalks"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just to be clear. I did not declare my full support. It was a strategic decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course you may, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let them undermine us, Hugo. The people who shout out their opinions are far less dangerous than the ones who whisper behind our backs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe you're right. I'm prepared to hold off on this decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you must...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_DeclareIntention_Public == true && RiziaDLC.Reform_DeclareIntention_WeakStatement == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_DeclareIntention_Public == true && RiziaDLC.Reform_DeclareIntention_WeakStatement == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true  and  Variable["RiziaDLC.Reform_DeclareIntention_WeakStatement"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_DeclareIntention_Public == true && RiziaDLC.Reform_DeclareIntention_WeakStatement == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true  and  Variable["RiziaDLC.Reform_DeclareIntention_WeakStatement"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not everyone is a radical or demagogue, Hugo. But if we silence them completely, it will only grow the radicalism more. Let's listen instead of suppressing them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A King who cannot face criticism is no King at all. I must take the risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Hugo Toras**
> ""This is a dangerous game, Romus. But one you seem eager to play.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Narrator**
> "He shook his head slightly. After a brief pause, he nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[107]`
Mówca: **Hugo Toras**
> ""If that's the path you're set on, then so be it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[108]`
Mówca: **Hugo Toras**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Hugo Toras**
> ""And now you're pushing this proposal...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[110]`
Mówca: **Hugo Toras**
> ""Even if that's the case, your words offered them hope, and made the nobility uneasy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[111]`
Mówca: **Hugo Toras**
> ""You didn't just support the movement, but validated it. The nobility is very concerned about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[112]`
Mówca: **Hugo Toras**
> ""I am worried that this will antagonize our fellow Houses against you -- and what you're trying to do...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[113]`
Mówca: **Narrator**
> "He bowed and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnactDecree("Welfare_HumanRights_AllowFreePress");)*
- **Efekt (`userScript`):** `EnactDecree("Welfare_HumanRights_AllowFreePress");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[115]`
Mówca: **Narrator**
> "I took a look at the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[119]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "Sign the decree."]** — Mówca: **Player_Romus_Italic**
> "I signed the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[117]`
Mówca: **Hugo Toras**
> ""Very well... I truly hope you're ready for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Hugo Toras**
> ""Goodbye for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've given me a lot to consider. I'll hold off on the decree for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Hugo Toras**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[121]`
Mówca: **Narrator**
> "I gave him the unsigned decree and ended our meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[122]`
Mówca: **Hugo Toras**
> ""So tell me, if I am to stand beside you in what comes next…""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Hugo Toras**
> ""Are you really prepared to face that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[124]`
  - -> `[128]`
  - -> `[186]`
  - -> `[132]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't rise to this throne to be ruled by them. I will not be the one to kneel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[125]`
Mówca: **Hugo Toras**
> ""This is for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[126]`
Mówca: **Narrator**
> "He looked at me with expecting eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're bringing up the other Houses again to warn me? Enough of this, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_DecreeCounsel_Happened > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_DecreeCounsel_Happened > 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_DecreeCounsel_Happened > 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] > 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am. And I'd be grateful to have my Grand Vizier standing behind me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thought you wanted to speak freely, Hugo. Don't play mind games with me. Just say it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Hugo Toras**
> ""Well, you know what I think, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Hugo Toras**
> ""I am against this decree. And I am against working with the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Hugo Toras**
> ""But I will speak of this no more. I will support you in whatever you decide to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[137]`
  - -> `[136]`
  - -> `[138]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Finally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe you're right. I'm prepared to hold off on this decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm warning you, Hugo. I hope you're not thinking of anything rash.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[140]`
Mówca: **Hugo Toras**
> ""Fine. I will speak of this no more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[141]`
Mówca: **Hugo Toras**
> ""This decree is an invitation to the radicals and demagogues to undermine you in broad daylight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[142]`
Mówca: **Hugo Toras**
> ""Rash? I am the Grand Vizier, Romus. Your uncle. If I cannot question your path, then who can?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Narrator**
> "I ignored him and took a look at the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[119]`

### Węzeł `[144]`
Mówca: **Hugo Toras**
> ""I serve this House and this throne, as I always have. I do not need to prove that to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[145]`
Mówca: **Hugo Toras**
> ""It is not just the Houses, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[162]`
  - -> `[163]`
  - -> `[164]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You make it sound like charity. I prefer to think of it as balance. Let them vent, let them shout. It's easier to rule those who believe they still have choices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Their democracy was a shadow play. I simply turned on the lights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I just removed a liability. Now the people can truly speak their minds, not just repeat the words of their puppetmasters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's precisely the plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So, you approve of it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So, this time you're not here to warn me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_DecreeCounsel_Happened > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_DecreeCounsel_Happened > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_DecreeCounsel_Happened > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Illusions can be useful, Hugo. Let them believe they have a voice. It costs me nothing, and it keeps them from demanding more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[150]`
  - -> `[151]`
  - -> `[153]`
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Power has never been about volume. They can shout all they want in the papers, as long as they remember by whose grace they are printed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Exactly. And what is your opinion on this matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what would you have me do instead, Hugo? Silence them entirely?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Grows == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you not seen the growing reform movement? We have to give something back to the people to calm the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you not seen the unrest on the streets? We have to give something back to the people to calm the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Hugo Toras**
> ""It's a bold move indeed. But I disagree that we *have to*."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Hugo Toras**
> ""It's a bold move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseOfDelegates_Abolished == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[177]`
Mówca: **Hugo Toras**
> ""No. I think it's a bold move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[178]`
Mówca: **Hugo Toras**
> ""A bold move, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[179]`
Mówca: **Hugo Toras**
> ""They lose their loudest voices, but gain some in the papers. You're giving them the illusion of power, while keeping it away from them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[180]`
Mówca: **Hugo Toras**
> ""They lose their voice in government, but gain some in the papers. You're giving them the illusion of power, while keeping it away from them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A little chaos, perhaps. A few angry columns, a few smug intellectuals thinking they've won something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Hugo Toras**
> ""Perhaps so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let me guess. You believe the streets will rise and the monarchy will crumble overnight. Or, perhaps, people will just read the news over breakfast and carry on with their lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What happens? We let people speak. That's all. Not every decision is a step toward revolution, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Illusions can be useful in times of growing radicalism. Let them believe they have a voice. It costs me nothing, and it hopefully keeps them from demanding more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course they'll be antagonized. They were antagonized the moment I was crowned and refused to be their puppet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You didn't protest when I got rid of Mr. Sotelato, now, did you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The movement grew radical because I followed your advice to get rid of Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are long past that stage. We're already losing control over the streets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The House of Delegates is already abolished, Hugo. This isn't helpful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseOfDelegates_Abolished == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see your point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Neither is truly controllable, Hugo. But I can still guide what's happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Giving them a platform to rant instead of going out to the streets *is* control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Hugo Toras**
> ""Perhaps so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[201]`
Mówca: **Hugo Toras**
> ""You are right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[202]`
Mówca: **Hugo Toras**
> ""I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Hugo Toras**
> ""Yes. I...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Hugo Toras**
> ""Just think about it. This would be an invitation to radicals and demagogues to undermine you in broad daylight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[206]`
Mówca: **Hugo Toras**
> ""But I didn't think you'd now give them the chance to reveal to everyone how the Crown moved against their leader.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[207]`
Mówca: **Hugo Toras**
> ""A bold idea. But...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[208]`
Mówca: **Hugo Toras**
> ""But I still think this will be an invitation to the radicals and demagogues to undermine you in broad daylight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As if I could keep you from doing so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ironically, no. I don't want to hear your opinion on this subject. I've already made up my mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On the contrary, this is about giving citizens the illusion of power while keeping them under our control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[212]`
Mówca: **Hugo Toras**
> ""Your words in public were... careful. But you offered them hope, and made the nobility uneasy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Hugo Toras**
> ""You're too young to remember the Voice of Rizia. But I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Hugo Toras**
> ""Its writers didn't only attack the King's policies. They went after his personal life... even his family members.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_CounselIgnored += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Hugo_CounselIgnored"] = Variable["RiziaDLC.Hugo_CounselIgnored"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
