# Sordland/Turn08/Other Cabinet Updates

- **ID konwersacji:** `177`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/177_Other_Cabinet_Updates.md`
- **Liczba węzłów dialogowych:** 389
- **Liczba wyborów gracza:** 82

---

## 1. Uczestnicy Sceny

- **[2]** Paskal Beniwoll
- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[21]** Deivid Wisci
- **[35]** Gus Manger
- **[51]** Symon Holl
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed`
- `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana`
- `BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum`
- `BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum`
- `BaseGame.GovernmentBudget`
- `BaseGame.Lespia_Alliance`
- `BaseGame.Policy_Diplomacy_EmbargoingRumburg`
- `BaseGame.Policy_Diplomacy_Lespia_Alliance`
- `BaseGame.Policy_Diplomacy_Valgsland_Alliance`
- `BaseGame.Policy_Economy_TourismAct`
- `BaseGame.Situation_Diplomacy_LespiaTradeTariffs`
- `BaseGame.Situation_Diplomacy_ValgslandTradeTariffs`
- `BaseGame.Situation_Economy_Gruni_LightTowerRegion`
- `BaseGame.Situation_Economy_Gruni_MaintainingGrowth`
- `BaseGame.Situation_Economy_Tourism_Average`
- `BaseGame.Situation_Economy_Tourism_Booming`
- `BaseGame.Situation_Order_BFF_ThreatAlarming`
- `BaseGame.Situation_Order_BFF_ThreatEliminated`
- `BaseGame.Turn08_SecondScandal_Detained_Livia`
- `BaseGame.Turn08_SecondScandal_LiviaTrialled`
- `BaseGame.Valgsland_Alliance`
- `BaseGame.Valgsland_HeljilandRecognised`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameSupport.News_Turn08_HP_SAFReady`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[176] Sordland/Turn08/PoliticsBillsBriefing** (../Turn_08/176_PoliticsBillsBriefing.md), Węzeł `[126]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
- **Węzły modyfikujące stan gry:** 10

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[5]` (Paskal Beniwoll): `AddConversant("Symon Holl"); ;`
- Węzeł `[85]` (Paskal Beniwoll): `AddConversant("Gus Manger"); ;`
- Węzeł `[173]` (Paskal Beniwoll): `AddConversant("Deivid Wisci"); ;`
- Węzeł `[200]` (Paskal Beniwoll): `RemoveConversant("Symon Holl"); RemoveConversant("Gus Manger"); ;`
- Węzeł `[285]` (Paskal Beniwoll): `AddConversant("Iosef Lancea"); ;`
- Węzeł `[314]` (Paskal Beniwoll): `RemoveConversant("Deivid Wisci"); ;`
- Węzeł `[340]` (Paskal Beniwoll): `RemoveConversant("Deivid Wisci"); RemoveConversant("Iosef Lancea");`
- Węzeł `[341]` (Paskal Beniwoll): `AddConversant("Paskal Beniwoll"); ;`
- *...oraz 2 innych węzłów ze skryptami.*

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
  - -> `[345]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `176` (*Sordland/Turn08/PoliticsBillsBriefing*), Węzeł `[126]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Symon came in shortly afterwards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Symon Holl**
> ""Mr. President. Where's the Vice President today?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`
  - -> `[8]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Symon Holl");)*
- **Efekt (`userScript`):** `AddConversant("Symon Holl");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He's thinking very hard about what he did wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't know. Have you seen him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's confidential, Mr. Holl.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[9]`
Mówca: **Symon Holl**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Symon Holl**
> ""Not lately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Narrator**
> "Symon's expression remained unchanged as he sat down to face me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Symon Holl**
> ""I just wanted to provide you with a few updates on the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Symon Holl**
> ""You may have noticed that the government budget is in need of a boost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget < 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget < 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[17]`
Mówca: **Symon Holl**
> ""My ministry is therefore working on a bill that will increase the tax on tobacco products from 10 to 30 percent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Symon Holl**
> ""A similar bill is being drafted to introduce a 20 percent tax on alcohol.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Very good. Those are nasty vices anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We can't tax people's booze and cigarettes. There'd be riots in the streets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Interesting initiatives. But would the income we'd receive be worth the harm to Sordish businesses?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Symon Holl**
> ""Your public opinion would suffer. There's no getting around that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Symon Holl**
> ""Good question. The tax wouldn't apply to products designated for export, which would mitigate the damage somewhat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Symon Holl**
> ""Ordinarily, I'd advise against this kind of thing. But with our budget dipping into the red, any measure that would reverse our deficit is worth considering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[25]`
Mówca: **Symon Holl**
> ""The government budget is currently healthy enough that we don't need to worry about introducing new tax measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[26]`
Mówca: **Symon Holl**
> ""Thankfully, tourism to Sordland is on the rise, so we can expect to see a healthy stream of income there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_Tourism_Booming == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_Tourism_Booming == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_Tourism_Booming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_Tourism_Booming == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_Tourism_Booming"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_Tourism_Average == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_Tourism_Average == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_Tourism_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_Tourism_Average == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_Tourism_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Symon Holl**
> ""Especially since the Sordish tourism industry has been stagnating.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[34]`
Mówca: **Symon Holl**
> ""Especially since our income from tourism is on the decline.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[35]`
Mówca: **Symon Holl**
> ""Especially since tourism to Sordland is on the rise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_Tourism_Booming == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_Tourism_Booming == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_Tourism_Booming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_Tourism_Booming == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_Tourism_Booming"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_Tourism_Average == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_Tourism_Average == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_Tourism_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_Tourism_Average == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_Tourism_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[42]`
Mówca: **Symon Holl**
> ""Although it might be a nice fallback considering that the Sordish tourism industry has recently been stagnating due to stability issues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[43]`
Mówca: **Symon Holl**
> ""Although it might be a nice fallback since our income from tourism is on the decline.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_TourismAct == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_TourismAct == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_TourismAct"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_TourismAct == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_TourismAct"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[56]`
  - -> `[71]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_TourismAct == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_TourismAct == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_TourismAct"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_TourismAct == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_TourismAct"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[69]`
  - -> `[53]`

### Węzeł `[50]`
Mówca: **Symon Holl**
> ""Our investment in cultural preservation failed to produce the intended effect, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[69]`
  - -> `[53]`

### Węzeł `[51]`
Mówca: **Symon Holl**
> ""Our investment in cultural preservation paid off, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[56]`
  - -> `[71]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh. I hope the increased threat of the BFF won't put a damper on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_BFF_ThreatAlarming == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_BFF_ThreatAlarming == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Order_BFF_ThreatAlarming == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_BFF_ThreatAlarming == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_BFF_ThreatAlarming == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Order_BFF_ThreatAlarming == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_BFF_ThreatEliminated == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_BFF_ThreatEliminated == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Order_BFF_ThreatEliminated == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_BFF_ThreatEliminated)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_BFF_ThreatEliminated)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Order_BFF_ThreatEliminated))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Wait until the world finds out we eliminated the BFF menace. They'll come in droves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh. I hope the increased threat of the BFF won't make matters worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Wait until the world finds out we've eliminated the BFF menace. They'll come in droves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's good news. Thanks for telling me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Who wouldn't want to visit Sordland? It's the best country in the world!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's disappointing to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why wouldn't tourism be skyrocketing? Sordland is the best country in the world!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[72]`
Mówca: **Symon Holl**
> ""We did? Congratulations, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[73]`
Mówca: **Symon Holl**
> ""The increased what!? I'd better have a talk with Lileas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[74]`
Mówca: **Symon Holl**
> ""To live in, perhaps. But have you seen Lespia's beaches?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Symon Holl**
> ""To be fair, I never understood why anyone would want to vacation in Sordland when Lespia is right there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Narrator**
> "There was a knock on the door. Gus Manger strolled in and grabbed a seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[77]`
Mówca: **Symon Holl**
> ""I never quite understood why anyone would want to vacation in Sordland when Lespia is right there. But I suppose our country has a certain charm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[78]`
Mówca: **Gus Manger**
> ""Mr. President. Symon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[79]`
Mówca: **Symon Holl**
> ""Understood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[80]`
Mówca: **Symon Holl**
> ""In addition to bringing in needed revenue, the new laws would curb excessive drinking and smoking in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`
  - -> `[21]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[84]`
Mówca: **Gus Manger**
> ""Some excitement around the Palace lately, I've heard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`
  - -> `[88]`
  - -> `[89]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Gus Manger");)*
- **Efekt (`userScript`):** `AddConversant("Gus Manger");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's how it is around here. A new adventure every day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry about it, Gus. Focus on your job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This should be a lesson to everyone. Double-cross me, and you'll pay the price.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The real excitement is yet to come, believe me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[90]`
Mówca: **Narrator**
> "Gus and Symon exchanged worried looks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[91]`
Mówca: **Gus Manger**
> ""I'm sure you're handling it very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[92]`
Mówca: **Gus Manger**
> ""You can say that again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Gus Manger**
> ""Consider my breath bated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Gus Manger**
> ""Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Gus Manger**
> ""You both know how revitalizing the Gruni region has always been my pet project of sorts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[96]`
Mówca: **Symon Holl**
> ""Thanks for joining us, Gus. I believe you wanted to update the President on the latest developments in the Gruni region?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Narrator**
> "Gus nodded vigorously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Gus Manger**
> ""Yes, you both know how revitalizing the region has always been my pet project of sorts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_Gruni_LightTowerRegion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_Gruni_LightTowerRegion == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_Gruni_LightTowerRegion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_Gruni_LightTowerRegion == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_Gruni_LightTowerRegion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Gus Manger**
> ""Well. Thanks to the efforts of my ministry and the wise allocation of funding on the President's part, it looks like the project has finally found success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_Gruni_MaintainingGrowth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_Gruni_MaintainingGrowth == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_Gruni_MaintainingGrowth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_Gruni_MaintainingGrowth == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_Gruni_MaintainingGrowth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[106]`
Mówca: **Gus Manger**
> ""Well. Thanks to the efforts of my ministry and the funding allocated by the President, Gruni is looking stable these days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Symon Holl**
> ""Stable? That's it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Narrator**
> "Gus shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[109]`
Mówca: **Gus Manger**
> ""Well. I'm saddened to say that despite my ministry's best efforts, we're going to have to close the books on this project.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Symon Holl**
> ""'Close the books', Mr. Manger? What does that mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Narrator**
> "Gus sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Gus Manger**
> ""It means that without a massive injection of funding, the economic growth I had hoped to see in the region is simply not going to happen during this term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[113]`
Mówca: **Gus Manger**
> ""It's far from the massive surge in economic growth that I had hoped to see. But I still believe the area has a wealth of untapped potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[114]`
Mówca: **Symon Holl**
> ""I've been keeping an eye on Gruni as well, of course. And it does seem to be experiencing a surge in economic growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Narrator**
> "Gus smiled proudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Gus Manger**
> ""Wine production, shipping, agriculture... the investments are pouring in. I'd call this turnaround a beacon of success for our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Gus Manger**
> ""This is everything I'd hoped to see at the start of our term and more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`
  - -> `[120]`
  - -> `[122]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well, don't celebrate too early. The term isn't over yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Congratulations, Gus. I know how much this project meant to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's fantastic news. It shows what can be accomplished when the president, cabinet and Assembly all work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It seems to me like my remaining time in office would be better spent focusing on other regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Terrific. Gruni is the breadbasket of Sordland. Its success will benefit us all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well, keep at it. I know how much Gruni means to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""All right. I'll see what I can do to help boost development there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You can't just give up. I know how much Gruni means to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I knew it from the beginning. It made no sense to try to turn Gruni into something it wasn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Perhaps this wouldn't be happening if you'd focused as much attention on Gruni as you have on your side ventures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Gus Manger**
> ""What could have been a beacon of success for Sordland is turning into a cesspool of crime, unemployment and homelessness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[125]`
  - -> `[126]`

### Węzeł `[129]`
Mówca: **Narrator**
> "Gus gritted his teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Gus Manger**
> ""If Gruni is failing, it is not for my lack of trying. You have no idea how much blood, sweat and tears I put into my development plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Gus Manger**
> ""I still believe it's brimming with untapped potential. It saddens me to no end to see that go to waste.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Symon Holl**
> ""Try to calm down, Gus. The President makes decisions on behalf of the entire country, not only your home region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[136]`
Mówca: **Symon Holl**
> ""In any case, I've heard that United Contana is preparing to offer us a substantial agricultural aid package.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Symon Holl**
> ""I'm suspicious, of course, but perhaps their funding can turn Gruni around where our efforts did not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[154]`
  - -> `[157]`
  - -> `[162]`

### Węzeł `[138]`
Mówca: **Gus Manger**
> ""Not just to me, Mr. President. It's the breadbasket of this nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[139]`
Mówca: **Gus Manger**
> ""That would be great, Mr. President. I only hope it's not too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[140]`
Mówca: **Narrator**
> "Gus gritted his teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Gus Manger**
> ""It's a self-fulfilling prophecy, Mr. President. If Gruni is neglected, of course it will fail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[142]`
Mówca: **Symon Holl**
> ""I'll be on the lookout for further opportunities to invest in the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[146]`
Mówca: **Symon Holl**
> ""Apropos, I've heard that United Contana is preparing to offer us a substantial agricultural aid package.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Symon Holl**
> ""I'm suspicious, of course, but accepting their offer could send development in Gruni through the roof.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[154]`
  - -> `[157]`

### Węzeł `[148]`
Mówca: **Gus Manger**
> ""That's true. But it's safe to say we're on the right track.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[149]`
Mówca: **Gus Manger**
> ""Not just to me, Mr. President. To all of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[150]`
Mówca: **Gus Manger**
> ""We've managed to do what Soll and Alphonso couldn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[151]`
Mówca: **Gus Manger**
> ""Exactly. Thank you for believing in its potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm suspicious as well. I'm sure they'll want something in exchange.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Ah. Our alliance with Valgsland is already paying off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It worked out well when we accepted their help before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It was a mistake accepting aid from them before. I won't do so again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It gladdens my heart that our comrades are willing to lend a helping hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Symon Holl**
> ""Very good work, both of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[164]`
Mówca: **Gus Manger**
> ""First you accept Contanan aid, next they spark an uprising against hardworking landowners like my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[165]`
Mówca: **Gus Manger**
> ""If we seize every possible opportunity to invest in Gruni now, we could still see positive results within our term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[123]`
  - -> `[124]`

### Węzeł `[166]`
Mówca: **Gus Manger**
> ""Not just to me, Mr. President. It's the breadbasket of this nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[167]`
Mówca: **Gus Manger**
> ""Gruni is the green heart of this nation, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_Gruni_LightTowerRegion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_Gruni_LightTowerRegion == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_Gruni_LightTowerRegion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_Gruni_LightTowerRegion == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_Gruni_LightTowerRegion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Gus Manger**
> ""I won't deny Gruni needs the money. But there's got to be another way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Narrator**
> "The door to the White Room opened slowly, and Deivid made his way in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Deivid Wisci");)*
- **Efekt (`userScript`):** `AddConversant("Deivid Wisci");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Deivid Wisci**
> ""Oh, hello, gentlemen. I'm early again, aren't I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Symon Holl**
> ""Not to worry, Mr. Wisci. We've just about wrapped things up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_LespiaTradeTariffs == true || BaseGame.Situation_Diplomacy_ValgslandTradeTariffs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_LespiaTradeTariffs == true || BaseGame.Situation_Diplomacy_ValgslandTradeTariffs == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_LespiaTradeTariffs"] == true  or  Variable["BaseGame.Situation_Diplomacy_ValgslandTradeTariffs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Diplomacy_LespiaTradeTariffs == true || BaseGame.Situation_Diplomacy_ValgslandTradeTariffs == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_LespiaTradeTariffs"] == true  or  Variable["BaseGame.Situation_Diplomacy_ValgslandTradeTariffs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[179]`
Mówca: **Symon Holl**
> ""While we're both here, we may as well talk about the economic impact of our recent alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Deivid Wisci**
> ""A wise idea, Mr. Holl. Our new partnership is not without its consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_Alliance == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[184]`
Mówca: **Deivid Wisci**
> ""As you may recall, almost immediately after we sealed our alliance with Lespia, Valgsland imposed strict tariffs on us in retaliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Symon Holl**
> ""The fallout won't impact our economy right away, but I do expect a significant hit before the end of the term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Deivid Wisci**
> ""As you may recall, almost immediately after we sealed our alliance with Valgsland, Lespia imposed strict tariffs on us in retaliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[187]`
Mówca: **Deivid Wisci**
> ""Fortunately, I believe any short-term economic harm imparted by these tariffs will be offset by the alliance's long-term benefits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`
  - -> `[190]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I trust your wisdom, Deivid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I wouldn't have agreed to the alliance if I didn't believe that as well. I'm looking at the big picture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What if I break off the alliance? Will the tariffs end?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Narrator**
> "Symon raised an eyebrow. He gestured for Deivid to answer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Deivid Wisci**
> ""The diplomatic chaos caused by ending our alliance would dent our economy far more than these tariffs will, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Lespia_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Lespia_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Lespia_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Symon Holl**
> ""I fully expect our partnership with Lespia to pay off. Arcasia has already taken notice and is planning on sending us a generous aid offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Symon Holl**
> ""I'm not fully convinced the Valgsland partnership will pay off. Although the aid offer from United Contana is a head start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[198]`
Mówca: **Deivid Wisci**
> ""Although I've heard that aid will be military in nature, which raises questions about their real motivations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[199]`
Mówca: **Narrator**
> "Symon and Gus rose from their seats and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Symon Holl");
RemoveConversant("Gus Manger");)*
- **Efekt (`userScript`):** `RemoveConversant("Symon Holl");
RemoveConversant("Gus Manger");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[201]`
Mówca: **Deivid Wisci**
> ""Yes, and a sign of possible greater interest from the CSP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Narrator**
> "Symon grimaced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Symon Holl**
> ""Hooray.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Symon Holl**
> ""They're clearly gauging our interests in joining ATO. Which, from a purely financial standpoint, would be a great move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Symon Holl**
> ""We'll leave you to your meeting, gentlemen. My regards to Mr. Vectern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`
  - -> `[208]`

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Symon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll pass them on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Have a good afternoon, both of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[209]`
Mówca: **Narrator**
> "After the door closed, Deivid regarded me for a second. His blue eyes seemed to see right through me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_Detained_Livia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_Detained_Livia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_Detained_Livia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[213]`
Mówca: **Deivid Wisci**
> ""My ministry was notified about the Rumburgian infiltrator.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Deivid Wisci**
> ""This is a very delicate situation, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`
  - -> `[217]`

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's delicate about it? They sent us a sex spy. They'll have to answer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand. Our relations with Rumburg were precarious enough before this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You don't have to tell me that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[218]`
Mówca: **Deivid Wisci**
> ""How are you, Anton? You look as if you haven't slept in ages.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`
  - -> `[221]`
  - -> `[222]`

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's been a rough few days, Deivid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sleeplessness comes part and parcel with this job. You know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're better off not knowing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Can I ask you a personal question? Were you ever unfaithful to Cathrin?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Narrator**
> "He blinked, slightly taken aback."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Deivid Wisci**
> ""I've met many a beautiful woman in the course of my travels. But no, even in my younger days, I was never tempted to stray.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[225]`
Mówca: **Deivid Wisci**
> ""My deep love for my wife -- as well as the need to protect my reputation as a statesman -- prevented me from doing so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Deivid Wisci**
> ""Why? Have you broken your vows with Monica, Anton?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[229]`
  - -> `[230]`
  - -> `[228]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This isn't about me. This is about Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Forget I asked. Let's talk diplomacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No. Although God knows I've thought about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Never. I love my wife more than anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[231]`
Mówca: **Narrator**
> "He looked at me sternly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Deivid Wisci**
> ""Some thoughts are better off not translated into actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[233]`
Mówca: **Narrator**
> "He looked relieved."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[234]`
Mówca: **Deivid Wisci**
> ""Some men go their entire lives without finding what you and I have. Best not to mess it up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[235]`
Mówca: **Narrator**
> "He looked at me sadly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Deivid Wisci**
> ""Men of our stature are granted a certain power in society. Some know how to wield it responsibly, and others do not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Deivid Wisci**
> ""I see that Mr. Vectern wants to do right by his wife and his position. I hope someday he finds the strength to face his demons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[238]`
Mówca: **Deivid Wisci**
> ""Yes, we should leave this topic for another day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Deivid Wisci**
> ""I'll be very brief. Perhaps we can even carve out some time for you to rest your eyes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[240]`
Mówca: **Deivid Wisci**
> ""But let's have this conversation over tea, not during a cabinet meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[241]`
Mówca: **Deivid Wisci**
> ""I'm very glad to report that our diplomatic efforts with Rumburg have been met with an equally diplomatic response from the Kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[242]`
Mówca: **Deivid Wisci**
> ""Please understand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Deivid Wisci**
> ""We may even be able to enter peace talks with the Queen very soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[247]`
Mówca: **Deivid Wisci**
> ""Regretfully, tensions are continuing to mount between Sordland and Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Deivid Wisci**
> ""As you might imagine, our decision to grant asylum to their whistleblower Mr. Hailstone did not sit well with the Kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[252]`
Mówca: **Deivid Wisci**
> ""As you might imagine, the embargo we decreed has not been sitting well with the Kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_EmbargoingRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_EmbargoingRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_EmbargoingRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Deivid Wisci**
> ""Nor did the embargo we decreed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
Mówca: **Deivid Wisci**
> ""We must exercise caution. The slightest provocation on either side could cost us our chance at reconciliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[276]`
  - -> `[277]`

### Węzeł `[258]`
Mówca: **Deivid Wisci**
> ""The tensions between Sordland and Rumburg have not eased. Quite the contrary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Deivid Wisci**
> ""As you might imagine, our decision to grant asylum to their whistleblower Mr. Hailstone did not sit well with the Kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[263]`
Mówca: **Deivid Wisci**
> ""As you might imagine, the embargo we decreed has not been sitting well with the Kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_EmbargoingRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_EmbargoingRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_EmbargoingRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[267]`
Mówca: **Deivid Wisci**
> ""Nor did the embargo we decreed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
Mówca: **Deivid Wisci**
> ""An incident such as this might serve as a tipping point. Place too much blame on Rumburg, and we may lose our chance at reconciliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[276]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[272]`
Mówca: **Deivid Wisci**
> ""Prior to this revelation, our diplomatic efforts with Rumburg had been met with an equally diplomatic response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Deivid Wisci**
> ""In fact, there were indications that the Kingdom would soon be ready to begin peace talks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Bringing Rumburg to justice for what it's done is far more important than reconciliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[275]`
Mówca: **Deivid Wisci**
> ""But we must exercise caution. The slightest provocation on either side could cost us our chance at reconciliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[276]`
  - -> `[277]`

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're right as usual. The last thing we want is a war on our hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't even know if peace is possible after so many years of animosity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Deivid Wisci**
> ""There is always hope for peace. No matter what.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[279]`
Mówca: **Deivid Wisci**
> ""The quest for 'justice' has blinded many a leader over the centuries. Don't let it cloud your eyes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[280]`
Mówca: **Deivid Wisci**
> ""A compromise in the name of the greater good may spare countless lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[281]`
Mówca: **Narrator**
> "A pair of loud, precise raps came on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Iosef Lancea");)*
- **Efekt (`userScript`):** `AddConversant("Iosef Lancea");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[286]`
Mówca: **Iosef Lancea**
> ""Mr. President. Mr. Wisci.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[287]`
Mówca: **Iosef Lancea**
> ""For better or for worse, we are now in a military alliance with the Republic of Valgsland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[288]`
Mówca: **Deivid Wisci**
> ""That would be General Lancea with a further update on the Valgsland alliance. If you don't mind, I'll stay for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[290]`
  - -> `[291]`

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Of course, Deivid. It's always valuable having you around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A military update on Valgsland? I think I have an idea what this could be about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm already starting to wonder whether that alliance was a good idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[292]`
Mówca: **Narrator**
> "Iosef brusquely entered and took a seat facing me. He and Deivid nodded at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[293]`
Mówca: **Narrator**
> "He paused, as if he couldn't bring himself to go on. Finally, he continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[294]`
Mówca: **Iosef Lancea**
> ""As I expected, the commies -- Valgslandians -- began asking for our assistance practically as soon as the ink was dry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[295]`
Mówca: **Iosef Lancea**
> ""Sordland's recognition of Heljiland as Valgish territory has emboldened the Republic to begin planning its invasion of the island.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Iosef Lancea**
> ""Their war minister has informed me that it will commence in the coming months.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[298]`
  - -> `[299]`
  - -> `[300]`
  - -> `[375]`

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And? What role is Sordland expected to play in this invasion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Time for our armies to practice shooting Agnolians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I hope they're not planning anything too drastic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good. I'm happy to help our brothers-in-arms claim their rightful land.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[301]`
Mówca: **Iosef Lancea**
> ""Not an active one, thankfully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[302]`
Mówca: **Iosef Lancea**
> ""There'll be no need for that, thankfully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[303]`
Mówca: **Iosef Lancea**
> ""If they are, they're leaving us out of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Iosef Lancea**
> ""Thankfully, they're not asking us to play an active role.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[305]`
Mówca: **Iosef Lancea**
> ""We are readying our forces for assistance with aerial reconnaissance and a naval blockade. But our troops will not set foot on the island itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Deivid Wisci**
> ""I too expected that allying with Valgsland would necessitate our involvement in the Heljiland situation. I'm grateful that's as far as it goes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Iosef Lancea**
> ""The Valgs had better not back down if it comes to war between Sordland and Rumburg, that's for sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`
  - -> `[315]`
  - -> `[316]`
  - -> `[317]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Our Valgish comrades will surely come to our aid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[309]`
Mówca: **Deivid Wisci**
> ""I'll leave you to it, Anton. I know you've got a lot on your plate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[311]`
  - -> `[312]`

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's always a pleasure, Deivid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thanks for your brevity. Have a good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We'll talk soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Narrator**
> "Deivid left the White Room, gently closing the door behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Deivid Wisci");)*
- **Efekt (`userScript`):** `RemoveConversant("Deivid Wisci");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I hope you will not let your personal feelings about the Republic of Valgsland undermine this alliance, General.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This alliance was not my first choice either. But I do trust Valgsland to provide assistance if we're in need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""May it never come to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[318]`
Mówca: **Deivid Wisci**
> ""Agreed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_ComradeRayne))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[322]`
Mówca: **Narrator**
> "Iosef raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Iosef Lancea**
> ""Comrades, eh? You're starting to sound like them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[324]`
Mówca: **Iosef Lancea**
> ""Of course not, Mr. President. Sordland's allies are my own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[325]`
Mówca: **Deivid Wisci**
> ""They could prove to be a formidable ally indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Narrator**
> "He glanced at Iosef."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[327]`
Mówca: **Deivid Wisci**
> ""If that's all, Mr. Lancea, I suggest we leave President Rayne to it. It's been a long morning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Narrator**
> "Deivid glanced at him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[329]`
Mówca: **Iosef Lancea**
> ""All right, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[330]`
Mówca: **Narrator**
> "He and Deivid stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_Detained_Livia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_Detained_Livia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_Detained_Livia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[335]`
  - -> `[338]`

### Węzeł `[334]`
Mówca: **Iosef Lancea**
> ""Hope you tear those Rumburgians a new one for installing a damn spy in your office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[337]`
  - -> `[335]`

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Have a good afternoon, gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They'll get what's coming to them. Don't worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you both for the updates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We'll speak again soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Narrator**
> "My ministers left. Deivid gently closed the door behind them, allowing me a moment of quiet once more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Deivid Wisci");
RemoveConversant("Iosef Lancea");)*
- **Efekt (`userScript`):** `RemoveConversant("Deivid Wisci");
RemoveConversant("Iosef Lancea");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Paskal Beniwoll");)*
- **Efekt (`userScript`):** `AddConversant("Paskal Beniwoll");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[342]`
Mówca: **Narrator**
> "Paskal walked in next. He didn't bother taking a seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
> ""Mr. President. Only a brief update from me today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
> ""My ministry has been working on a pair of bills that will soon go to the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
> ""The first is a measure to provide state benefits to all citizens who are forced to miss work due to long-term illness or disability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`
  - -> `[350]`
  - -> `[351]`
  - -> `[352]`

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's a good idea, Paskal. Those people have enough to worry about without fearing for their financial security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Aren't you afraid that will lead to more workers going on indefinite 'sick leave' for made-up reasons?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It should be up to companies to pay those workers' salaries. Not the government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""All right. What's the other one?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
> ""Ideally, perhaps, but not all companies -- especially small businesses -- can afford such generosity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
> ""This measure would ensure every sick or disabled employee has access to equal benefits without disincentivizing businesses from hiring those employees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
> ""This doesn't seem to have happened in other countries that introduced such measures, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
> ""Exactly, Mr. President. Receiving these benefits may even help them recover and get back to work faster.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
> ""The second is called the Children for Future Act. It would provide direct financial support for low-income families with children, while ensuring that the children of unemployed parents have access to education and healthcare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[359]`
  - -> `[360]`

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Very good. Children are indeed our future, even if they are not born into wealth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So you're advocating we *pay* our poorest citizens to reproduce. What could go wrong with that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""These seem like quite lavish expenditures, Paskal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
> ""The aim is for all children to have a chance to thrive, regardless of their background.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
> ""Yes, every child deserves a chance to thrive, regardless of background.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
> ""For a Sordland where every child is given a chance to thrive regardless of background, it will be worth it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
> ""Look for these measures to cross your desk soon. Assuming they're approved by the Assembly, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
> ""We will discuss everything else in more detail during our upcoming annual health report.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`
  - -> `[367]`
  - -> `[368]`

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm looking forward to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Paskal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Have a great day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[369]`
Mówca: **Narrator**
> "Paskal nodded and exited the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Paskal Beniwoll");)*
- **Efekt (`userScript`):** `RemoveConversant("Paskal Beniwoll");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_HeljilandRecognised == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_HeljilandRecognised == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Valgsland_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Valgsland_HeljilandRecognised == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Valgsland_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[374]`
Mówca: **Iosef Lancea**
> ""Our military alliance has emboldened the Republic to begin planning its invasion of the island.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I never promised to support their invasion. Tell them we will provide no support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[376]`
Mówca: **Iosef Lancea**
> ""Of course not. Thankfully, they're not asking us to play an active role.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`
  - -> `[379]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[380]`
Mówca: **Symon Holl**
> ""Although it might be a nice fallback since our tourism income is on the decline, due to our lack of investment earlier in the term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_HP_SAFReady = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_SAFReady"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Lespia_Alliance == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Lespia_Alliance == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == true  or  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Lespia_Alliance == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == true  or  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[385]`
Mówca: **Symon Holl**
> ""I have some thoughts regarding the wider consequences of our diplomatic actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Lespia_Alliance == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Lespia_Alliance == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == true  or  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Lespia_Alliance == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == true  or  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
