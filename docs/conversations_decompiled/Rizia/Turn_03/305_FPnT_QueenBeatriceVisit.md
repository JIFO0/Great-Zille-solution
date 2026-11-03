# Rizia/Turn 3/FPnT_QueenBeatriceVisit

- **ID konwersacji:** `305`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Rizia/Turn_03/305_FPnT_QueenBeatriceVisit.md`
- **Liczba węzłów dialogowych:** 558
- **Liczba wyborów gracza:** 136

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[79]** Vina Toras
- **[92]** Beatrice Livingston (R)
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Coronation_Speech_AntiMonarchy`
- `RiziaDLC.Decision_Turn03_ZilleBombApology`
- `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO`
- `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded`
- `RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed`
- `RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project`
- `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw`
- `RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Completed`
- `RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project`
- `RiziaDLC.Prologue_HadAffairs`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport`
- `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport`
- `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal`
- `RiziaDLC.Situation_Diplomacy_Zille_ATAActive`
- `RiziaDLC.Situation_Economy_Sordland_ResortDeal`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed`
- `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount`
- `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics`
- `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse`
- `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Budget_Modifier_RumburgTrade`
- `RiziaDLC.Diplomacy_Rumburg_NegotiatingPower`
- `RiziaDLC.Diplomacy_Wehlen_NegotiatingPower`
- `RiziaDLC.Energy_Modifier_RumburgEnergyExport`
- `RiziaDLC.PersonalValue_FunnyKing`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport`
- `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport`
- `RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed`
- `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount`
- `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics`
- `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse`
- `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers`
- `RiziaDLCSupport.Journal_Turn03_Rumburg_GasPromise`
- `RiziaDLCSupport.News_Turn03_RH_BlameSO`
- `RiziaDLCSupport.News_Turn03_RH_DefendSO`
- `RiziaDLCSupport.News_Turn03_RH_NeutralTowardsSO`
- `RiziaDLCSupport.Reports_Turn03_FortAles_ValgishHeritageWeek`
- `RiziaDLCSupport.Reports_Turn03_Iza_GoldenGuardIntelligenceUpdate`
- `RiziaDLCSupport.Reports_Turn03_Monqiz_KorontiVisit`
- `RiziaDLCSupport.Reports_Turn03_Qalus_TuskVisit`
- `RiziaDLCSupport.Reports_Turn03_RumburgBuysLessOil`
- `RiziaDLCSupport.Reports_Turn03_RumburgOilEmbargo`
- `RiziaDLCSupport.Reports_Turn03_Zille_IntelligenceUpdate`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 13
- **Węzły modyfikujące stan gry:** 25

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Budget_Modifier_RumburgTrade`
- `RiziaDLC.Energy_Modifier_RumburgEnergyExport`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport`
- `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport`
- `RiziaDLCSupport.News_Turn03_RH_NeutralTowardsSO`
- `RiziaDLCSupport.Reports_Turn03_Zille_IntelligenceUpdate`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[136]` (Paskal Beniwoll): `AddConversant("Pabel Adria"); ;`
- Węzeł `[158]` (Paskal Beniwoll): `RemoveConversant("Estela Toras"); RemoveConversant("Vina Toras"); RemoveConversant("Pabel Adria"); ;`
- Węzeł `[165]` (Paskal Beniwoll): `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg"] = true; Variable["RiziaDLC.Energy_Modifie...`
- Węzeł `[409]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed"] = true;`
- Węzeł `[438]` (Paskal Beniwoll): `AddConversant("Beatrice Livingston (R)"); ;`
- Węzeł `[439]` (Paskal Beniwoll): `AddConversant("Estela Toras"); AddConversant("Vina Toras"); ;`
- Węzeł `[440]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn03_RH_BlameSO"] = true;`
- Węzeł `[447]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn03_RH_DefendSO"] = true;`
- *...oraz 17 innych węzłów ze skryptami.*

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
  - -> `[557]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Vina, Estela and I sat in Palas Rezna's most ornate stateroom, awaiting the arrival of Queen Beatrice Livingston."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[4]`
Mówca: **Pabel Adria**
> ""Announcing Her Excellency Beatrice Livingston, Queen of the Four Corners of Merkopa, Defender of Castle Tzarsbough, Conqueror of the Tranquil Sea, Stout Protector of the Ancient Lands of Rum, Descendant of the Most Honorable King Edward the First and the Ruler of Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Pabel came in through the stateroom door. He took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[6]`
Mówca: **Narrator**
> "He stepped aside and Queen Beatrice entered. She was wearing an emerald-green gown that matched her tiara."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "Vina, Estela and I rose to greet the queen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`
  - -> `[10]`
  - -> `[11]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "Kiss Beatrice on the cheek."]** — Mówca: **Player_Romus_Italic**
> "I kissed my sister-in-law on the cheek. She returned the gesture warmly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "Kiss her hand."]** — Mówca: **Player_Romus_Italic**
> "I took my sister-in-law's hand and kissed it. She looked me up and down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "Shake her hand."]** — Mówca: **Player_Romus_Italic**
> "I shook my sister-in-law's hand. She returned it with a firm grip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "Embrace her."]** — Mówca: **Player_Romus_Italic**
> "I gave my sister-in-law a hug. She returned it warmly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Beatrice Livingston (R)**
> ""What a pleasure it is to see you, Your Majesty. We barely had the chance to speak at the coronation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Beatrice Livingston (R)**
> ""And my dear niece!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Narrator**
> "She turned towards Vina."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Beatrice Livingston (R)**
> ""Why, you're looking more and more like your mother every day. I hope your father's proud of the lady you've become.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[138]`
  - -> `[150]`

### Węzeł `[16]`
Mówca: **Narrator**
> "Beatrice embraced her tightly before moving on to my mother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[17]`
Mówca: **Estela Toras**
> ""Queen Beatrice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Beatrice Livingston (R)**
> ""Queen Mother Estela.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Narrator**
> "She tilted her face upwards and gave a short sniff."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Beatrice Livingston (R)**
> ""The palace looks as magnificent as always, but I fear a chat with your housekeeper may be in order. Every time I visit, it smells just the faintest bit like trash.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[21]`
Mówca: **Estela Toras**
> ""Funny, I do seem to detect an unpleasant draft of hot air. But only since you walked in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`
  - -> `[24]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's be civil, ladies. We have important state issues to discuss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shall we be seated?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel, please look into these matters at once. The air quality in the palace may be compromised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Narrator**
> "Pabel bemusedly raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Pabel Adria**
> ""Right away, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Estela Toras**
> ""Then I shall take my leave. I have a terribly urgent appointment on the other side of the palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Estela Toras**
> ""If you'll excuse me, I shall take my leave. I have a terribly urgent appointment on the other side of the palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Beatrice Livingston (R)**
> ""By all means, Your Highness. Our chatter is far more boring than the sort of carousing you're used to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Beatrice Livingston (R)**
> ""Vina, why don't you run along as well? We'll catch up over supper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Narrator**
> "Vina reluctantly nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Vina Toras**
> ""Sure, Aunt Bea. Have the staff give my room a ring when you're done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[33]`
Mówca: **Narrator**
> "He filled two porcelain cups for us, then escorted Vina and my mother out the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Queen Mother Estela may have a common upbringing, but she's part of the royal family. Please respect her as such.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Beatrice Livingston (R)**
> ""Whatever do you mean, my love?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How is your own family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To what do we owe this pleasure, Your Excellency?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "Sip your tea."]** — Mówca: **Player_Romus_Italic**
> "I took a sip of Rumburgian tea. Lena had loved its earthy taste, but I never quite got used to it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[39]`
Mówca: **Beatrice Livingston (R)**
> ""First things first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[40]`
Mówca: **Beatrice Livingston (R)**
> ""Splendid. King Consort Boris sends his sincerest regrets. He had to oversee some air force exercises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[41]`
Mówca: **Beatrice Livingston (R)**
> ""Of course we are the same age, Your Majesty, but I've worn my crown for many years longer than you have yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Beatrice Livingston (R)**
> ""And I and my country are far more experienced at dealing with the Republic of Wehlen and their backers in the CSP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Beatrice Livingston (R)**
> ""Sending your own investigators to ferret out the bombing culprit is a good start. It shows President Smolak you are unwilling to play by his terms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[50]`
Mówca: **Beatrice Livingston (R)**
> ""By indicating that you regard your own countrymen as culpable for the bombing, you are putting yourself in a position of weakness from the start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[51]`
Mówca: **Beatrice Livingston (R)**
> ""By apologizing to President Smolak for a perfectly justified speech, you are putting yourself in a position of weakness from the start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[52]`
Mówca: **Beatrice Livingston (R)**
> ""But how do you plan to follow that up? What will you do if Mr. Smolak fails to relinquish his hold on Zille?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`
  - -> `[56]`
  - -> `[55]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That won't happen. President Smolak will respect the rule of law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If it comes down to it, I'm prepared to fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will exercise diplomacy until an agreement is reached.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know Rumburg has its own agenda when it comes to Wehlen. Rizia's path will be different.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Beatrice Livingston (R)**
> ""Our only agenda is neutralizing the threat that this unpredictable regime poses to its neighbors. Including you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Beatrice Livingston (R)**
> ""Then you will need Rumburg's help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[78]`
  - -> `[79]`
  - -> `[77]`

### Węzeł `[59]`
Mówca: **Beatrice Livingston (R)**
> ""To that end, Rumburg is prepared to provide assistance with the delicate situation in which you've found yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[78]`
  - -> `[79]`
  - -> `[77]`

### Węzeł `[60]`
Mówca: **Beatrice Livingston (R)**
> ""That sounds simply wonderful, Your Majesty. Until you arrive at the bargaining table and realize your pockets are empty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[61]`
Mówca: **Beatrice Livingston (R)**
> ""Have you thought about your next steps? What will you do if Mr. Smolak fails to relinquish his hold on Zille?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`
  - -> `[56]`
  - -> `[55]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_ZilleBombApology == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_ZilleBombApology == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_ZilleBombApology"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn03_ZilleBombApology == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_ZilleBombApology"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Beatrice Livingston (R)**
> ""You denied that your countrymen were culpable for the attack. But you must realize President Smolak will not take your words at face value.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[69]`
Mówca: **Beatrice Livingston (R)**
> ""You have expressed no opinion on the incident thus far. You must realize that President Smolak will see that as an admission of guilt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm already funding a Rizian cultural organization in Zille. That should get locals on my side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Beatrice Livingston (R)**
> ""A good monarch must anticipate every eventuality. No matter how unlikely he or she believes it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[75]`
Mówca: **Beatrice Livingston (R)**
> ""I see. A light touch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[76]`
Mówca: **Narrator**
> "Beatrice leaned forward and held my gaze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thought this was a family visit, Your Excellency. Can we save the politics for another time?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've helped us so much over the years. I would not ask more of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do go on, Queen Beatrice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[80]`
Mówca: **Beatrice Livingston (R)**
> ""You don't need to ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Narrator**
> "She shot me a piercing glance. I wondered how much Lena had told her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[85]`
Mówca: **Narrator**
> "She looked at me with what seemed like genuine compassion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[86]`
Mówca: **Beatrice Livingston (R)**
> ""Here's what I suggest, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[87]`
Mówca: **Pabel Adria**
> ""I'll see you two out. Just a moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Narrator**
> "Pabel walked Beatrice and myself over to a pair of velvet armchairs. Next to them was a table upon which a towering silver Rumburgian tea urn had been set up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[89]`
Mówca: **Beatrice Livingston (R)**
> ""How are the princess' marriage plans coming along?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[106]`
  - -> `[110]`
  - -> `[114]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why? Is your eldest son single?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't know. I told her I won't be arranging her marriage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[92]`
Mówca: **Beatrice Livingston (R)**
> ""Heavens, no. My Bradley is still betrothed to the Duchess of Thompsfort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Beatrice Livingston (R)**
> ""Much as I'd like to continue our tradition of royal intermarriage, this pairing is necessary to secure northwestern Rumburg's continued loyalty. Surely you understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`
  - -> `[96]`
  - -> `[101]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A shame. They would have made beautiful children.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. You made a wise arrangement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was joking. They're cousins, for Dast's sake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Beatrice Livingston (R)**
> ""That never stopped any of our noble ancestors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Beatrice Livingston (R)**
> ""We royals are an endangered breed, you know. We've got to tend to our lineages as we would a rose garden.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`
  - -> `[123]`
  - -> `[126]`

### Węzeł `[99]`
Mówca: **Beatrice Livingston (R)**
> ""I'm sure you'll find just as suitable a match for my brilliant niece.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[100]`
Mówca: **Beatrice Livingston (R)**
> ""Indeed they would have. But you'll find another suitable a match for my brilliant niece, I'm sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It doesn't matter, anyway. I already told her she can marry whomever she wants.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Beatrice Livingston (R)**
> ""Did you? My word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm on the lookout for candidates. Someone from one of our other royal houses, perhaps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'll have to ask her yourself. We're not on the best terms these days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Honestly, I have too much on my mind to even start to think about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[115]`
Mówca: **Beatrice Livingston (R)**
> ""Very good. As you'll recall, I promised my Bradley to the Duchess of Thompsfort to secure the loyalty of our country's northwestern regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[116]`
Mówca: **Beatrice Livingston (R)**
> ""We royals are an endangered breed, you know. We've got to tend to our lineages as we would a rose garden.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[127]`
  - -> `[126]`

### Węzeł `[117]`
Mówca: **Beatrice Livingston (R)**
> ""Oh? I'm sorry to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Beatrice Livingston (R)**
> ""I lost my father at only 16, as you know. There were so many times over the years that I wished for his guidance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[119]`
Mówca: **Beatrice Livingston (R)**
> ""Well, don't dilly-dally much longer. An unmarried royal is catnip for the tabloids.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Beatrice Livingston (R)**
> ""They had quite the field day with my Bradley before I secured his betrothal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[351]`
  - -> `[346]`
  - -> `[347]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If that means inbreeding, perhaps it's best to let the garden die.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. But first cousins are too closely related for my comfort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't see the harm in allowing a few exotic plants to blossom here and there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Beatrice Livingston (R)**
> ""Choose the wrong ones, and the weeds will spread faster than you can pull them out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[125]`
Mówca: **Beatrice Livingston (R)**
> ""Better a cousin than a commoner, no?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fear not. The garden of House Toras shall remain in bloom for a long, long time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If that means forcing my daughter into an unhappy union, perhaps it's best to let the garden die.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[128]`
Mówca: **Beatrice Livingston (R)**
> ""We royals are an endangered breed, you know. We've got to tend to our lineages as we would a rose garden.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[126]`
  - -> `[129]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Precisely my thinking. It's good to speak with someone who understands these things.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Beatrice Livingston (R)**
> ""Anytime, my dear brother-in-law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[131]`
Mówca: **Beatrice Livingston (R)**
> ""You're lucky to have such a relationship in your life. Cherish it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[359]`
  - -> `[360]`

### Węzeł `[132]`
Mówca: **Beatrice Livingston (R)**
> ""With the help of House Livingston, it shall bloom on only the richest of soil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[133]`
Mówca: **Beatrice Livingston (R)**
> ""If the garden dies, your ties to House Livingston die with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Princess Marriage Talk)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[135]`
Mówca: **Narrator**
> "An informal supper with my sister-in-law was scheduled for the evening. But for now, the protocol for an official diplomatic visit had to be observed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Pabel Adria");)*
- **Efekt (`userScript`):** `AddConversant("Pabel Adria");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's on my council, you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's as stubborn as her mother was, that's for sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't call her a 'lady''. She's been neglecting her duties as princess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[143]`
Mówca: **Beatrice Livingston (R)**
> ""Oh, my. So young, and already preparing for the crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Vina Toras**
> ""You were younger than me when you got yours, weren't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[145]`
Mówca: **Beatrice Livingston (R)**
> ""Good girl. It's your royal obligation to give your father hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Narrator**
> "Vina laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Vina Toras**
> ""It's lovely to see you, Aunt Bea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[148]`
Mówca: **Narrator**
> "Queen Beatrice gave Vina a mock stern look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Beatrice Livingston (R)**
> ""It's your royal duty to give your father hell. And it seems you're performing it admirably.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am. And I know Lena would have been, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Narrator**
> "Vina beamed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[155]`
Mówca: **Narrator**
> "Vina managed a weak smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[156]`
Mówca: **Narrator**
> "The two women gave each other air kisses, then stood back and eyed each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[157]`
Mówca: **Estela Toras**
> ""Is that so, Your Excellency?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Estela Toras"); RemoveConversant("Vina Toras");
RemoveConversant("Pabel Adria");)*
- **Efekt (`userScript`):** `RemoveConversant("Estela Toras");
RemoveConversant("Vina Toras");
RemoveConversant("Pabel Adria");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Narrator**
> "Beatrice motioned for her own attendants to wait outside. We settled into our seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[37]`
  - -> `[36]`
  - -> `[38]`

### Węzeł `[160]`
Mówca: **Beatrice Livingston (R)**
> ""I find your mother ever so charming. I never believed those nasty rumors about her one bit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[161]`
Mówca: **Narrator**
> "Queen Beatrice extended her little finger and took a sip from her own cup. She smiled approvingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[162]`
Mówca: **Beatrice Livingston (R)**
> ""As you may know, Rumburg is currently a major importer of Wehzek oil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[163]`
Mówca: **Beatrice Livingston (R)**
> ""Our nations are bound by our shared love for my sister. Such a relationship goes beyond mere transaction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[164]`
Mówca: **Beatrice Livingston (R)**
> ""Should you wish for something a little less subtle, I have a suggestion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg = true;
RiziaDLC.Energy_Modifier_RumburgEnergyExport -= 1; 
RiziaDLC.Budget_Modifier_RumburgTrade += 1;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Rumburg_NegotiatingPower += 1;
RiziaDLC.Resources_Energy -= 2;
RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport = true;
RiziaDLCSupport.Reports_Turn03_RumburgBuysLessOil = true;
RiziaDLCSupport.Journal_Turn03_Rumburg_GasPromise = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg"] = true;
Variable["RiziaDLC.Energy_Modifier_RumburgEnergyExport"] = Variable["RiziaDLC.Energy_Modifier_RumburgEnergyExport"] - 1;
Variable["RiziaDLC.Budget_Modifier_RumburgTrade"] = Variable["RiziaDLC.Budget_Modifier_RumburgTrade"] + 1;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] + 1;
Variable["RiziaDLC.Resources_Energy"] = Variable["RiziaDLC.Resources_Energy"] - 2;
Variable["RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport"] = true;
Variable["RiziaDLCSupport.Reports_Turn03_RumburgBuysLessOil"] = true;
Variable["RiziaDLCSupport.Journal_Turn03_Rumburg_GasPromise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[166]`
Mówca: **Beatrice Livingston (R)**
> ""Of course, an immediate modernization of your Monqiz port would be required to handle the excess shipping traffic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[169]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We always try to stay ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I love it. You buy less oil from Wehlen, and we'll make up the difference with natural gas and other energy sources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's a lot to demand for a plan that may not even be useful or necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[170]`
Mówca: **Beatrice Livingston (R)**
> ""I'm quite sure some of the same ships that carry out our gold trade can be retrofitted to transport natural gas in its liquified form.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That can be arranged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To be honest, I'm satisfied with our countries' current trade relations. I don't want to complicate them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Interesting. But how would Rizian gas even reach Rumburg from here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would we have to replace all the oil you've been purchasing? What about only part of it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you believe Wehlen can't find another customer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is a serious promise. What happens if I can't keep up my end of the guarantee?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[177]`
Mówca: **Beatrice Livingston (R)**
> ""Rumburg would prefer to eliminate its energy dependence on Wehlen entirely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[178]`
Mówca: **Beatrice Livingston (R)**
> ""Believe it or not, Wiktor Smolak has managed to alienate Wehlen from most of its neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[179]`
Mówca: **Beatrice Livingston (R)**
> ""We'll have to find a more reliable trading partner. For energy as well as other materials.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[180]`
Mówca: **Beatrice Livingston (R)**
> ""And? What do you think of the idea?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`
  - -> `[181]`
  - -> `[172]`
  - -> `[338]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't promise you anything. Rizia is indeed expanding its energy horizons, but we have other potential buyers in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[182]`
Mówca: **Beatrice Livingston (R)**
> ""Thrilling. How much less oil shall we buy, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`
  - -> `[183]`
  - -> `[489]`

### Węzeł `[183]`
**[WYBÓR GRACZA: ""Can you halve your imports? We will provide some from our stockpiles now and more in the future." [-2 Energy, -1 Energy Per Turn, +1 Budget Per Turn]"]** — Mówca: **Player_Romus**
> ""Can you halve your imports? We will provide some from our stockpiles now and more in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[184]`
**[WYBÓR GRACZA: ""Screw it, Your Excellency. Cut off Wehlen completely." [-3 Energy, -2 Energy Per Turn, +2 Budget Per Turn]"]** — Mówca: **Player_Romus**
> ""Screw it, Your Excellency. Cut off Wehlen completely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Narrator**
> "Beatrice smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Beatrice Livingston (R)**
> ""Very bold of you. My sister didn't marry a man who takes half measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[187]`
Mówca: **Beatrice Livingston (R)**
> ""You would turn your back on family that easily?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[188]`
Mówca: **Beatrice Livingston (R)**
> ""Are you quite sure? Remember, bilateral relations always need maintaining.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`
  - -> `[519]`
  - -> `[504]`
  - -> `[516]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Princess Marriage Talk])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[190]`
Mówca: **Beatrice Livingston (R)**
> ""I can see. Good job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[191]`
Mówca: **Beatrice Livingston (R)**
> ""Even if you don't ship us gas, getting that port into tip-top shape would make our gold trade more efficient.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[192]`
Mówca: **Beatrice Livingston (R)**
> ""If we were to significantly reduce our imports, the financial pressure -- and thus your leverage over Wehlen -- would be considerable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`
  - -> `[213]`
  - -> `[197]`

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. How much oil are you importing from Wehlen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thought you hated Wehlen. But you're buying their oil?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Beatrice Livingston (R)**
> ""Don't look so shocked. It's a partnership of convenience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[196]`
Mówca: **Beatrice Livingston (R)**
> ""Enough to seriously make a dent in the country's economy were our purchase orders to diminish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't need leverage over Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Beatrice Livingston (R)**
> ""Leverage isn't the only thing I'm offering you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[199]`
Mówca: **Beatrice Livingston (R)**
> ""But in fact, my advisors and I have been speaking about forging new energy partnerships.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Beatrice Livingston (R)**
> ""And as it happens, Rizia is about to come into possession of quite a bit of natural gas, correct?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`
  - -> `[203]`
  - -> `[204]`

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, we've discovered a new gas field. It's very exciting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't know yet. Our scientists are still figuring out the details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""At least some of it belongs to Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia has enough natural gas already. We're not looking for more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Beatrice Livingston (R)**
> ""Hmm. Perhaps my intelligence was mistaken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Beatrice Livingston (R)**
> ""If you say so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Beatrice Livingston (R)**
> ""I was about to propose that Rumburg purchase Rizian energy in lieu of Wehzek oil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Beatrice Livingston (R)**
> ""We enrich your country and assist you with your Wehlen problem in one fell swoop.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`
  - -> `[218]`
  - -> `[226]`

### Węzeł `[209]`
Mówca: **Beatrice Livingston (R)**
> ""How grand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Beatrice Livingston (R)**
> ""My proposal, then, would be for Rumburg to purchase Rizian energy in lieu of Wehzek oil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[211]`
Mówca: **Beatrice Livingston (R)**
> ""I see. Very interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[212]`
Mówca: **Beatrice Livingston (R)**
> ""My advisors and I have been speaking about forging new energy partnerships.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'd deprive your own people of energy just to help Rizia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Beatrice Livingston (R)**
> ""I most certainly would not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Rumburg Gas Qs)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[327]`
  - -> `[324]`
  - -> `[321]`
  - -> `[333]`

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What kind of timeline are you thinking about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Generous, Your Excellency. But I can't guarantee that we'll be able to access that gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I promise you access to the gas from that field and you'll stop purchasing oil from Wehlen. I like the sound of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Beatrice Livingston (R)**
> ""It doesn't have to be that one particular gas field, to be honest. We'll accept other sources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Beatrice Livingston (R)**
> ""Grant us a small amount of energy to add to our stockpile now, and we can cut off Wehlen immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[221]`
Mówca: **Beatrice Livingston (R)**
> ""And I will be most displeased.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[222]`
Mówca: **Beatrice Livingston (R)**
> ""I know our partners in GRACE would surely follow suit and cut their own ties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[223]`
Mówca: **Beatrice Livingston (R)**
> ""But of course, we wouldn't want Rizia to make any overly rash promises. So yes, a partial embargo on our end is possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[224]`
Mówca: **Beatrice Livingston (R)**
> ""We can cut off our orders of Wehzek oil immediately, as long as you grant us a small amount of energy upfront to add to our stockpile.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[225]`
Mówca: **Beatrice Livingston (R)**
> ""We'd then give you a one-year grace period to make the transition. After which, I warn you, our needs will be quite substantial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, Your Excellency. I can already tell you I'm not interested.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Beatrice Livingston (R)**
> ""Ah, well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Narrator**
> "Her teacup made a soft clink as she placed it on her saucer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Beatrice Livingston (R)**
> ""It seemed most convenient to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Princess Marriage Talk])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[231]`
Mówca: **Narrator**
> "Queen Beatrice extended her little finger and raised her teacup to her lips. She smiled approvingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Beatrice Livingston (R)**
> ""Just like home. My compliments to your butler.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Beatrice Livingston (R)**
> ""Now. How are you faring a year into your reign? I know you had quite the scare in Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`
  - -> `[236]`
  - -> `[237]`
  - -> `[482]`

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was never scared. Rizians weren't the target, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Mother and I were lucky to get out with our lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm less scared by what happened than by the ramifications of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have good security. And everything's under control now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[238]`
Mówca: **Beatrice Livingston (R)**
> ""That is the correct manner of thinking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[239]`
Mówca: **Beatrice Livingston (R)**
> ""No Rizians were harmed at all, in fact. How curious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[240]`
Mówca: **Beatrice Livingston (R)**
> ""No, they weren't. How curious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Beatrice Livingston (R)**
> ""I do hope that's true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Beatrice Livingston (R)**
> ""Needless to say, Rumburg has been monitoring the fallout of the incident with great concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`
  - -> `[245]`

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your concern is much appreciated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why? How does what happened affect you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you came all the way to Porte Drazon to... express your concern?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[246]`
Mówca: **Narrator**
> "She nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Beatrice Livingston (R)**
> ""Aside from my worries about your personal safety, I foresee a scenario where Wehlen uses this tragedy to its own gain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[248]`
Mówca: **Beatrice Livingston (R)**
> ""I don't need an excuse to see my extended family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[249]`
Mówca: **Beatrice Livingston (R)**
> ""But aside from my worries about your personal safety, I foresee a scenario where Wehlen uses this tragedy to its own gain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[250]`
Mówca: **Beatrice Livingston (R)**
> ""Aside from my worries about your personal safety, you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[251]`
Mówca: **Beatrice Livingston (R)**
> ""I foresee a scenario where Wehlen uses this tragedy to its own gain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[252]`
Mówca: **Beatrice Livingston (R)**
> ""And Wehlen amassing more power is not in either of our interests, correct, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`
  - -> `[255]`
  - -> `[256]`

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not as long as they have our land.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. We've got to be very careful not to stir the pot further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If they try, they will face the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I only want peace with Wehlen. Our countries have a historical bond.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Beatrice Livingston (R)**
> ""Precisely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[258]`
Mówca: **Beatrice Livingston (R)**
> ""It's more important not to capitulate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[259]`
Mówca: **Beatrice Livingston (R)**
> ""You and I are royals, Romus. For us, family and politics are one and the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_AntiMonarchy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_AntiMonarchy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coronation_Speech_AntiMonarchy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HadAffairs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HadAffairs == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HadAffairs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HadAffairs == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HadAffairs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[266]`
Mówca: **Beatrice Livingston (R)**
> ""Or would you rather talk about how your coronation speech angered our partners in GRACE?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[267]`
Mówca: **Beatrice Livingston (R)**
> ""Or would you rather talk about how your affairs humiliated my sister until the day she died?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[299]`
  - -> `[272]`
  - -> `[273]`

### Węzeł `[268]`
Mówca: **Beatrice Livingston (R)**
> ""Or would you rather talk about how your daughter is nearly 20 and still not betrothed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[313]`

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's quite all right. Tell me your idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[270]`
Mówca: **Narrator**
> "Beatrice smiled fiercely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What was so controversial about it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm so sorry. It was never my intention to be unfaithful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She told you about that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Beatrice Livingston (R)**
> ""She told me everything, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about GRACE?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Beatrice Livingston (R)**
> ""Now, now. Don't play coy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Beatrice Livingston (R)**
> ""You are as crucial of a member as Rumburg, Your Majesty. Do not feign naivete.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Beatrice Livingston (R)**
> ""Just as the world's remaining monarchies pledge to enter an era of increased cooperation, you tell your entire country you intend on 'giving the people a voice'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[279]`
Mówca: **Beatrice Livingston (R)**
> ""What am I to make of that, Your Majesty? Or Nahrburk, or the Baronies of Soradis?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[281]`
  - -> `[280]`
  - -> `[284]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Giving people a voice doesn't mean giving up monarchy. Isn't your own country governed by a parliament?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I got carried away in the moment. I didn't really mean it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[282]`
Mówca: **Beatrice Livingston (R)**
> ""Technically, yes. But it has roughly as much power as your 'House of Delegates'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can all make of it what you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't realize that GRACE was so attuned to my actions as king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[285]`
Mówca: **Beatrice Livingston (R)**
> ""You are the unproven ruler of one of GRACE's linchpin countries. Don't be surprised that you are under scrutiny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Beatrice Livingston (R)**
> ""I hear your behavior as king has suggested otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[290]`
Mówca: **Beatrice Livingston (R)**
> ""It's an odd promise to simply blurt out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Beatrice Livingston (R)**
> ""I hardly think such a flippant answer is appropriate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[292]`
Mówca: **Beatrice Livingston (R)**
> ""You were lucky to escape the 1926 uprising with your head. To make such a public overture towards democracy is to tempt fate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[295]`
  - -> `[296]`

### Węzeł `[293]`
Mówca: **Beatrice Livingston (R)**
> ""Of course you are free to run your country the way you like. But without GRACE's backing, you will be at the mercy of ATO and the CSP like every other country on this continent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[295]`
  - -> `[296]`

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry, Your Excellency. The Rizian monarchy is not going anywhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for warning me. I shall keep your words in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know what I'm getting myself into.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Narrator**
> "She regarded me warily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[298]`
Mówca: **Beatrice Livingston (R)**
> ""Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What affairs?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Beatrice Livingston (R)**
> ""Oh, it's never anyone's intention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[301]`
Mówca: **Narrator**
> "She rolled her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[302]`
Mówca: **Beatrice Livingston (R)**
> ""Excuse my short breach of decorum, but don't bullshit me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
Mówca: **Beatrice Livingston (R)**
> ""Lena was able to put her personal resentments aside for the sake of the bond between our kingdoms. I have tried to do the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Beatrice Livingston (R)**
> ""But should that bond in any way falter, I cannot promise those resentments will not color my judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`
  - -> `[307]`

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand what you're getting at. Let's talk about Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Same here, Your Excellency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The bond will not falter. Don't forget there's also Vina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[308]`
Mówca: **Narrator**
> "Beatrice glared at me, then smiled insincerely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[309]`
Mówca: **Beatrice Livingston (R)**
> ""Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Princess Marriage Talk])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[311]`
Mówca: **Narrator**
> "Beatrice smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Beatrice Livingston (R)**
> ""Actually, I've been meaning to ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know what? Let's talk about that instead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[314]`
Mówca: **Beatrice Livingston (R)**
> ""Very well, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Natural Gas Talk)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Natural Gas Talk])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[317]`
Mówca: **Beatrice Livingston (R)**
> ""Moving on to equally important matters...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[318]`
Mówca: **Beatrice Livingston (R)**
> ""But let's move on to equally important matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[319]`
Mówca: **Beatrice Livingston (R)**
> ""I hope you shall do more than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[320]`
Mówca: **Beatrice Livingston (R)**
> ""Wehlen might beg to differ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse == true || RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers == true || RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount == true || RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse == true || RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers == true || RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount == true || RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse"] == true  or  Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers"] == true  or  Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount"] == true  or  Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse == true || RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers == true || RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount == true || RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse"] == true  or  Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers"] == true  or  Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount"] == true  or  Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay. I think I have a good grasp on the particulars of the deal you're suggesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Rumburg Gas Qs])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I just don't see it. Even if my goal was to put the squeeze on Wehlen, this is not the most efficient way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[339]`
Mówca: **Beatrice Livingston (R)**
> ""Suit yourself, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[340]`
Mówca: **Beatrice Livingston (R)**
> ""Are you sure you don't want to hear my proposal, by the way?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`
  - -> `[405]`

### Węzeł `[341]`
Mówca: **Beatrice Livingston (R)**
> ""Now, are you sure you don't want to hear my proposal regarding Wehlen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`
  - -> `[405]`

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You do seem quite keen on it. I would be remiss not to hear you out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[343]`
Mówca: **Narrator**
> "Beatrice smiled fiercely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Natural Gas Talk])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina's a modest girl. She won't do anything worth gossiping about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good point. I'll start thinking about candidates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[347]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remind me, who is your son betrothed to again?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[348]`
Mówca: **Beatrice Livingston (R)**
> ""Why, the Duchess of Thompsfort, of course. Her family controls most of northwestern Rumburg. And she's got good birthing hips.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[349]`
Mówca: **Beatrice Livingston (R)**
> ""It's high time you do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[350]`
Mówca: **Beatrice Livingston (R)**
> ""Never underestimate the ability of the international press to manufacture royal scandals from thin air.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`
  - -> `[353]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the Rizian tabloids try something like that, I'll shut them down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[355]`
Mówca: **Beatrice Livingston (R)**
> ""It's not only Rizia who's paying attention, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[356]`
Mówca: **Beatrice Livingston (R)**
> ""Don't forget the rest of GRACE is invested in the Toras line of succession as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[357]`
Mówca: **Beatrice Livingston (R)**
> ""As you can see, I put some careful thought into the decision. And so should you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell that to Vina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My daughter doesn't want my guidance anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will try.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[361]`
Mówca: **Beatrice Livingston (R)**
> ""But she may need it. Especially when it comes to her marriage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[362]`
Mówca: **Beatrice Livingston (R)**
> ""Perhaps I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[363]`
Mówca: **Beatrice Livingston (R)**
> ""See that you do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[364]`
Mówca: **Beatrice Livingston (R)**
> ""And don't forget that the rest of GRACE is invested in the Toras line of succession as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`
  - -> `[367]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_AntiMonarchy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_AntiMonarchy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coronation_Speech_AntiMonarchy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[371]`
Mówca: **Beatrice Livingston (R)**
> ""Our partners will be looking for reassurance after your coronation speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`
  - -> `[373]`
  - -> `[372]`

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What was so controversial about it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[373]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Which partners do you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Beatrice Livingston (R)**
> ""Now, now. Don't play coy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Beatrice Livingston (R)**
> ""All of them, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[376]`
Mówca: **Beatrice Livingston (R)**
> ""Just as the world's remaining monarchies pledge to enter an era of increased cooperation, you tell your entire country you intend on 'giving the people a voice'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[377]`
Mówca: **Beatrice Livingston (R)**
> ""What am I to make of that, Your Majesty? Or Nahrburk, or the Baronies of Soradis?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`
  - -> `[379]`
  - -> `[378]`
  - -> `[382]`

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Giving people a voice doesn't mean giving up monarchy. Isn't your own country governed by a parliament?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I got carried away in the moment. I didn't really mean it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[380]`
Mówca: **Beatrice Livingston (R)**
> ""Technically, yes. But it has roughly as much power as your 'House of Delegates'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[381]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can all make of it what you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't realize that GRACE was so attuned to my actions as king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[383]`
Mówca: **Beatrice Livingston (R)**
> ""You are the unproven ruler of one of GRACE's linchpin countries. Don't be surprised that you are under scrutiny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Beatrice Livingston (R)**
> ""I hear your behavior as king has suggested otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[388]`
Mówca: **Beatrice Livingston (R)**
> ""It's an odd promise to simply blurt out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[389]`
Mówca: **Beatrice Livingston (R)**
> ""I hardly think such a flippant answer is appropriate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[390]`
Mówca: **Beatrice Livingston (R)**
> ""You were lucky to escape the 1926 uprising with your head. To make such a public overture towards democracy is to tempt fate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`
  - -> `[394]`
  - -> `[393]`

### Węzeł `[391]`
Mówca: **Beatrice Livingston (R)**
> ""Of course you are free to run your country the way you like. But without GRACE's backing, you will be at the mercy of ATO and the CSP like every other country on this continent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`
  - -> `[394]`
  - -> `[393]`

### Węzeł `[392]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry, Your Excellency. The Rizian monarchy is not going anywhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know what I'm getting myself into.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for warning me. I shall keep your words in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[395]`
Mówca: **Beatrice Livingston (R)**
> ""Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[396]`
Mówca: **Beatrice Livingston (R)**
> ""Wehlen might beg to differ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[397]`
Mówca: **Beatrice Livingston (R)**
> ""I hope you shall do more than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[398]`
Mówca: **Narrator**
> "She regarded me warily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[399]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`
  - -> `[401]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[402]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[403]`
Mówca: **Beatrice Livingston (R)**
> ""But we'll show them, won't we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[404]`
Mówca: **Narrator**
> "She rose to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[405]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure, Your Excellency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[406]`
Mówca: **Beatrice Livingston (R)**
> ""A pity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[407]`
Mówca: **Narrator**
> "She folded her hands in her lap."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Princess Marriage Talk])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[275]`
  - -> `[271]`

### Węzeł `[410]`
Mówca: **Beatrice Livingston (R)**
> ""I shall see you at supper, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true || RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`
  - -> `[413]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true || RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true || RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[414]`
Mówca: **Beatrice Livingston (R)**
> ""Congratulations on your recent trade deal, by the way. Although I wouldn't trust the Sords any further than I could throw them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "She rose to leave."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[416]`
Mówca: **Beatrice Livingston (R)**
> ""Rizia is one of its linchpin nations, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`
  - -> `[417]`
  - -> `[419]`

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about GRACE?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[418]`
Mówca: **Beatrice Livingston (R)**
> ""Do not discount the importance of our economic pact, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't realize our fellow kingdoms were keeping such a close eye on me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[420]`
Mówca: **Beatrice Livingston (R)**
> ""You are the unproven ruler of a country that possesses fabulous wealth. Don't be surprised you're under scrutiny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[421]`
Mówca: **Beatrice Livingston (R)**
> ""Our fellow monarchies want to see a stable Rizia. Especially after the summit at which we all promised closer cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`
  - -> `[424]`
  - -> `[425]`

### Węzeł `[422]`
Mówca: **Beatrice Livingston (R)**
> ""GRACE wants to see a stable Rizia. Especially after the summit at which we all promised closer cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`
  - -> `[424]`
  - -> `[425]`

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll keep that in mind. We monarchies have to stick together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[424]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still not sure of the utility of such an organization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[425]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Believe me, I want to see a stable Rizia as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`
  - -> `[428]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[429]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[430]`
Mówca: **Beatrice Livingston (R)**
> ""Together, we will ensure your lasting legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[431]`
Mówca: **Beatrice Livingston (R)**
> ""In case you haven't noticed, it's quite dangerous to be a monarch nowadays.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[432]`
Mówca: **Beatrice Livingston (R)**
> ""Rumburg will do its best to aid you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "She rose to leave."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[434]`
Mówca: **Beatrice Livingston (R)**
> ""There is safety in numbers. Even for those of us with well-equipped militaries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[435]`
Mówca: **Narrator**
> "She paused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[436]`
Mówca: **Narrator**
> "She walked out with her gown trailing behind her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[437]`
Mówca: **Narrator**
> "The Queen gave the door a swift knock. Her attendants opened it, bowing as they did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Beatrice Livingston (R)" );)*
- **Efekt (`userScript`):** `AddConversant("Beatrice Livingston (R)");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[439]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Estela Toras"); AddConversant("Vina Toras");)*
- **Efekt (`userScript`):** `AddConversant("Estela Toras");
AddConversant("Vina Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[440]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn03_RH_BlameSO = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn03_RH_BlameSO"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[441]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`
  - -> `[443]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`
  - -> `[446]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[446]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[447]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn03_RH_DefendSO = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn03_RH_DefendSO"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn03_RH_NeutralTowardsSO = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn03_RH_NeutralTowardsSO"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn03_Iza_GoldenGuardIntelligenceUpdate = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn03_Iza_GoldenGuardIntelligenceUpdate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`
  - -> `[452]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[452]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[453]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn03_Zille_IntelligenceUpdate = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn03_Zille_IntelligenceUpdate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[454]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`
  - -> `[456]`

### Węzeł `[455]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg = true;
RiziaDLC.Energy_Modifier_RumburgEnergyExport -= 2;
RiziaDLC.Budget_Modifier_RumburgTrade += 2;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 2;
RiziaDLC.Diplomacy_Rumburg_NegotiatingPower += 2;
RiziaDLC.Resources_Energy -= 3;
RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport = true;      
RiziaDLCSupport.Reports_Turn03_RumburgOilEmbargo = true;
RiziaDLCSupport.Journal_Turn03_Rumburg_GasPromise = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg"] = true;
Variable["RiziaDLC.Energy_Modifier_RumburgEnergyExport"] = Variable["RiziaDLC.Energy_Modifier_RumburgEnergyExport"] - 2;
Variable["RiziaDLC.Budget_Modifier_RumburgTrade"] = Variable["RiziaDLC.Budget_Modifier_RumburgTrade"] + 2;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 2;
Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] + 2;
Variable["RiziaDLC.Resources_Energy"] = Variable["RiziaDLC.Resources_Energy"] - 3;
Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] = true;
Variable["RiziaDLCSupport.Reports_Turn03_RumburgOilEmbargo"] = true;
Variable["RiziaDLCSupport.Journal_Turn03_Rumburg_GasPromise"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[458]`
Mówca: **Beatrice Livingston (R)**
> ""I feel obliged to ask once more: Are you positive you'll be able to deliver on Rizia's end of the bargain?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`
  - -> `[468]`
  - -> `[469]`
  - -> `[472]`

### Węzeł `[459]`
Mówca: **Beatrice Livingston (R)**
> ""We'd then give you a one-year grace period to make the transition. After which, I warn you, our needs will be quite substantial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[460]`
Mówca: **Beatrice Livingston (R)**
> ""This will all need to be formalized by my parliament and your government, of course. A verbal agreement between in-laws is hardly sufficient.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`
  - -> `[462]`
  - -> `[463]`

### Węzeł `[461]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree completely. My councilors and your foreign ministers can iron out the small print.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[462]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How long have we known each other, sweet Beatrice? My word is as good as gold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[463]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is still quite the leap of faith, though, isn't it? Is your sisterly affection for me that strong?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[464]`
Mówca: **Beatrice Livingston (R)**
> ""Precisely. We handle the big picture while the underlings take care of the particularities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[465]`
Mówca: **Beatrice Livingston (R)**
> ""I believe your intentions are nothing but pure, dear Romus. But we are a vast nation with freezing winters. I cannot stake my people's fate on an informal agreement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[466]`
Mówca: **Beatrice Livingston (R)**
> ""Our mutual love for Lena has indeed bound us tightly. But I confess we are also facing pressure to shift our energy purchases away from CSP and CSP-aligned countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[467]`
Mówca: **Beatrice Livingston (R)**
> ""And given our numerous existing trade agreements, Rizia makes sense as a replacement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[468]`
**[WYBÓR GRACZA: ""With whom do you think you're speaking? King Romus always keeps a promise." [-3 Energy, -2 Energy Per Turn, +2 Budget Per Turn]"]** — Mówca: **Player_Romus**
> ""With whom do you think you're speaking? King Romus always keeps a promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[469]`
**[WYBÓR GRACZA: ""Well... you do have quite a large country. Perhaps you should halve your orders instead." [-2 Energy, -1 Energy Per Turn, +1 Budget Per Turn]"]** — Mówca: **Player_Romus**
> ""Well... you do have quite a large country. Perhaps you should halve your orders instead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[470]`
Mówca: **Beatrice Livingston (R)**
> ""Certainly, Your Majesty. It's important to be realistic about these matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[471]`
Mówca: **Beatrice Livingston (R)**
> ""What a delightful little rhyme.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[472]`
**[WYBÓR GRACZA: ""If the Queen of Rumburg demands it, so it shall be." [-3 Energy, -2 Energy Per Turn, +2 Budget Per Turn]"]** — Mówca: **Player_Romus**
> ""If the Queen of Rumburg demands it, so it shall be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[473]`
Mówca: **Beatrice Livingston (R)**
> ""Very good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[474]`
Mówca: **Beatrice Livingston (R)**
> ""Certainly. It may not have as much of an impact as you were hoping, but it also won't be as much of a leap of faith on our part.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[476]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[477]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[480]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_ByThePeople","R_ByThePeople_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[481]`
Mówca: **Narrator**
> "My mother feigned a puzzled look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[482]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you had nothing to do with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[483]`
Mówca: **Beatrice Livingston (R)**
> ""You must be joking...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My speech?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[486]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`
  - -> `[488]`

### Węzeł `[487]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[488]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Energy >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] >= 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[489]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`
  - -> `[491]`

### Węzeł `[490]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[491]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Energy >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] >= 3) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[492]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project == true || RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`
  - -> `[494]`

### Węzeł `[493]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project == true || RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[494]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project == true || RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[495]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn03_FortAles_ValgishHeritageWeek = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn03_FortAles_ValgishHeritageWeek"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`
  - -> `[498]`

### Węzeł `[497]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[498]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[499]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`
  - -> `[501]`

### Węzeł `[500]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[502]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn03_Qalus_TuskVisit = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn03_Qalus_TuskVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[503]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn03_Monqiz_KorontiVisit = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn03_Monqiz_KorontiVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[504]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Rumburg_NegotiatingPower -= 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] - 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[505]`
Mówca: **Beatrice Livingston (R)**
> ""I have been notified of your expansion of the Monqiz port and dockyard facilities. This will easily handle the excess shipping traffic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`
  - -> `[167]`
  - -> `[507]`

### Węzeł `[506]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. I ordered that expansion with foreign trade in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[507]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's almost as if I knew this deal was coming. Just call me Romus the Prescient.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[508]`
Mówca: **Beatrice Livingston (R)**
> ""I'd rather not. But I appreciate your forward thinking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[509]`
Mówca: **Beatrice Livingston (R)**
> ""Even if you don't agree to sell us gas, our gold trade will be much more efficient. Well done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[510]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[511]`
Mówca: **Beatrice Livingston (R)**
> ""Remember who got you into GRACE, Your Majesty. And on whose grace Rizia's trade depends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`
  - -> `[519]`
  - -> `[516]`

### Węzeł `[512]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I'm sure. Shall we change the subject?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[513]`
Mówca: **Beatrice Livingston (R)**
> ""Very well. Let's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[514]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I remember just fine. Shall we change the subject?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[515]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On second thought, this embargo could be quite useful. Let's go through with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[516]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`
  - -> `[518]`

### Węzeł `[517]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[518]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Energy >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] >= 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[519]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I treasure our alliance, Beatrice. I just don't believe this deal is in Rizia's best interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[520]`
Mówca: **Beatrice Livingston (R)**
> ""Hm. Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[521]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, I'm beginning to have second thoughts. Let's keep our trade relationship as it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[522]`
Mówca: **Narrator**
> "She gave me a disappointed frown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[523]`
Mówca: **Beatrice Livingston (R)**
> ""How cruel of you to get my hopes up like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[524]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Rumburg_NegotiatingPower -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[525]`
Mówca: **Beatrice Livingston (R)**
> ""We Rumburgians do agree with Wehlen on one thing. The right of Dastnurists to practice their religion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[526]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true || RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Completed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`
  - -> `[528]`

### Węzeł `[527]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true || RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Completed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true  or  Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[528]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true || RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Completed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true  or  Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[529]`
Mówca: **Beatrice Livingston (R)**
> ""So I was quite pleased to hear you granted the Dastnurists of Sallabes their long-overdue sanctuary expansion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`
  - -> `[533]`
  - -> `[531]`

### Węzeł `[530]`
Mówca: **Beatrice Livingston (R)**
> ""I know Dastnurity is a minority religion over here. But it would be ever so kind of you to accommodate the community's needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`
  - -> `[531]`
  - -> `[532]`
  - -> `[534]`

### Węzeł `[531]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Be honest with me. Do you really care about religion that much?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[532]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will try. But it's not at the top of my list of priorities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[533]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course. The Kingdom of Rizia welcomes all denominations of Nurity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[534]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why should I accept them when they don't accept the sacred scripture of St. Wruhec?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[535]`
Mówca: **Beatrice Livingston (R)**
> ""For heaven's sake, Romus. Golcondists are hardly Wruhecists, and you accept them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[536]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`
  - -> `[538]`

### Węzeł `[537]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[538]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[539]`
Mówca: **Beatrice Livingston (R)**
> ""Yes, you proved that, didn't you? An interesting decision, revoking your blasphemy law. One that will surely get Wehlen's attention...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[540]`
Mówca: **Beatrice Livingston (R)**
> ""Except Golcondists, it seems. One could only imagine Wehlen's wrath if you began tolerating them...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[541]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`
  - -> `[543]`

### Węzeł `[542]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[543]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[544]`
Mówca: **Beatrice Livingston (R)**
> ""That's no attitude to take towards a small but significant part of your population.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[545]`
Mówca: **Beatrice Livingston (R)**
> ""Keep your kingdom's faithful happy, and they will be your strongest supporters. Your so-called Wiseman should have told you that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[546]`
Mówca: **Beatrice Livingston (R)**
> ""Our personal beliefs don't factor into this, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[547]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was the least I could do. I still regret that Lena was forced to convert.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[548]`
Mówca: **Beatrice Livingston (R)**
> ""Past is past. I don't believe she ever truly accepted St. Wruhec's writings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[549]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`
  - -> `[551]`

### Węzeł `[550]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[551]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[552]`
Mówca: **Beatrice Livingston (R)**
> ""She forgave you. Though I don't believe she ever truly accepted St. Wruhec's writings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[553]`
Mówca: **Beatrice Livingston (R)**
> ""Speaking of wives...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[554]`
Mówca: **Beatrice Livingston (R)**
> ""But I'm getting ahead of myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[555]`
Mówca: **Beatrice Livingston (R)**
> ""I suggest you rearrange that list, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[556]`
Mówca: **Beatrice Livingston (R)**
> ""And speaking of happiness...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[557]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Welcoming Queen Beatrice of Rumburg to the Palace", "Palace Rezna", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Welcoming Queen Beatrice of Rumburg to the Palace","Palace Rezna","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`
