# Sordland/Turn05/FPnT_AgnoliaTradeVisit

- **ID konwersacji:** `77`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/077_FPnT_AgnoliaTradeVisit.md`
- **Liczba węzłów dialogowych:** 400
- **Liczba wyborów gracza:** 90

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[18]** Maartin Van Hoorten
- **[21]** Deivid Wisci
- **[51]** Symon Holl
- **[54]** Serge Wolkner

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.AgnoliaTradeDeal_Negotiation`
- `BaseGame.Agnolia_Alliance`
- `BaseGame.Agnolia_CheaperSteel`
- `BaseGame.Agnolia_HeljilandRecognised`
- `BaseGame.Agnolia_TradeDeal`
- `BaseGame.Country_Unrest`
- `BaseGame.Decision_Turn04_RegionalInvestment_Agnland`
- `BaseGame.Policy_Diplomacy_Agnolia_Trade`
- `BaseGame.Policy_Diplomacy_RelaxedImmigration`
- `BaseGame.Policy_Diplomacy_Wehlen_Trade`
- `BaseGame.Prologue_Studyplace_Deyr_History`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Relations_Serge_Friend`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase`
- `BaseGame.Turn05_FPnT_Immigration_Tight`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.AgnoliaTradeDeal_Negotiation`
- `BaseGame.Agnolia_Alliance`
- `BaseGame.Agnolia_CheaperSteel`
- `BaseGame.Agnolia_HeljilandRecognised`
- `BaseGame.Agnolia_TradeDeal`
- `BaseGame.Economy_Agnland`
- `BaseGame.GovernmentBudget`
- `BaseGame.Heljiland_Map_Layer`
- `BaseGame.Policy_Diplomacy_Agnolia_Alliance`
- `BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised`
- `BaseGame.Policy_Diplomacy_Agnolia_Trade`
- `BaseGame.Policy_Diplomacy_Neutrality`
- `BaseGame.Policy_Diplomacy_TradeInitiative`
- `BaseGame.Policy_Military_JointMilitaryExercises`
- `BaseGame.Public_Opinion`
- `BaseGame.Situation_Diplomacy_Agnolia_Agriculture_Market_Access`
- `BaseGame.Situation_Diplomacy_Agnolia_CheapSteelPrice`
- `BaseGame.Situation_Diplomacy_Agnolia_HighSteelPrice`
- `BaseGame.Situation_Diplomacy_FailedTradeNegotiation`
- `BaseGame.Situation_Diplomacy_LackOfAllies`
- `BaseGame.Situation_Economy_DecreasedTrade`
- `BaseGame.Situation_Economy_IncreasedTrade`
- `BaseGame.Situation_Economy_RecoveredTrade`
- `BaseGameSupport.CountryReport_Turn05_Valgsland_CondemnsHeljilandDeal`
- `BaseGameSupport.Journal_Turn05_Trade_AgnoliaFailed`
- `BaseGameSupport.Journal_Turn05_Trade_AgnoliaMilitarySigned`
- `BaseGameSupport.Journal_Turn05_Trade_AgnoliaSigned`
- `BaseGameSupport.News_Turn05_E_AgnoliaDeal_Worse`
- `BaseGameSupport.News_Turn05_G_VanHoortenNotRecognized`
- `BaseGameSupport.News_Turn05_G_VanHoortenRecognized`
- `BaseGameSupport.News_Turn05_HP_AgnoliaAlliance`
- `BaseGameSupport.News_Turn05_HP_AgnoliaDeal`
- `BaseGameSupport.News_Turn05_HP_JournalistArrestedRY`
- `BaseGameSupport.News_Turn05_R_DarknessDescendsRY`
- `BaseGameSupport.Report_Turn05_Lenkurg_Unrest`
- `BaseGameSupport.Report_Turn05_Ribel_BergianPoliceAmbushed`
- `GameCondition.Turn05_FPnT_AgnoliaTradeVisit`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 60

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy_Agnland`
- `BaseGame.GovernmentBudget`
- `BaseGame.Situation_Economy_DecreasedTrade`
- `BaseGame.Situation_Economy_IncreasedTrade`
- `BaseGame.Situation_Economy_RecoveredTrade`
- `BaseGameSupport.Report_Turn05_Lenkurg_Unrest`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[171]` (Serge Wolkner): `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiati...`
- Węzeł `[172]` (Serge Wolkner): `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiati...`
- Węzeł `[173]` (Serge Wolkner): `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiati...`
- Węzeł `[174]` (Serge Wolkner): `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiati...`
- Węzeł `[175]` (Serge Wolkner): `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiati...`
- Węzeł `[176]` (Serge Wolkner): `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiati...`
- Węzeł `[177]` (Serge Wolkner): `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiati...`
- Węzeł `[178]` (Serge Wolkner): `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiati...`
- *...oraz 52 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Serge Wolkner)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Sordland One's flight from Holsord to Staalport took three hours but went very smoothly. We were about to touch down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Deivid left his seat and came over while Symon was enjoying his newspaper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Deivid Wisci**
> "“Looks like we are about to land, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "I looked outside. I could see Heljiland, the island in between Valgsland and Agnolia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Deivid Wisci**
> "“So many conflicts over such a small piece of land. The island can barely sustain itself without outside help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`
  - -> `[8]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“I don't blame them. It is in a very strategic position.”"]** — Mówca: **Player**
> "“I don't blame them. It is in a very strategic position.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "“I know. I was just thinking the same thing.”"]** — Mówca: **Player**
> "“I know. I was just thinking the same thing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "“If I was in the shoes of the Agnolian Prime Minister, I would do anything to protect the motherland.”"]** — Mówca: **Player**
> "“If I was in the shoes of the Agnolian Prime Minister, I would do anything to protect the motherland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Deivid Wisci**
> "“Thousands of people died fighting for it. I wonder if it was worth it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[12]`
Mówca: **Deivid Wisci**
> "“Of course. But as I get older, I started to question more things.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Deivid Wisci**
> "“Certainly. If you have Heljiland, you are in control of the whole Valgos Channel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Deivid Wisci**
> "“I suspect it will be one of the topics that Mr. Van Hoorten will bring up as a bargaining chip. We must be careful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Deivid Wisci**
> "“Heljiland might be under the control of Agnolia, but the international community has yet to recognise it. For a good reason, too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Deivid Wisci**
> "“Nobody wants to make an enemy of Valgsland. Especially because of the support of United Contana and the CSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[17]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Me included. I wouldn't want do anything to injure our relationship with Valgsland.”"]** — Mówca: **Player**
> "“Me included. I wouldn't want do anything to injure our relationship with Valgsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“I don't care who we're up against. We will cross that bridge when we come to it.”"]** — Mówca: **Player**
> "“I don't care who we're up against. We will cross that bridge when we come to it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Symon Holl**
> "“Aside from the point of Heljiland, we need to be careful with the additional requests.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[20]`
Mówca: **Deivid Wisci**
> "“We should try to look at the bigger picture.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Deivid Wisci**
> "“I agree. We should try our best to stick to the middle ground.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Narrator**
> "Symon folded his newspaper, got up from his seat and sat right next to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[23]`
Mówca: **Symon Holl**
> "“According to the deal that was negotiated so far, they want to sell us their steel for a higher price and they are requesting easier access to our agricultural market.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Symon Holl**
> "“In return, they are promising cash flow and investments, especially in the Agnland region. It's not hard to guess why.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[25]`
Mówca: **Deivid Wisci**
> "“During the initial negotiations, they brought up the topic of immigration many times.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_FPnT_Immigration_Tight == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_FPnT_Immigration_Tight == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_FPnT_Immigration_Tight == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Deivid Wisci**
> "“The fact that we have relaxed our immigration laws will help tremendously.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Deivid Wisci**
> "“Our job will be harder because of our new tightened immigration laws.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Deivid Wisci**
> "“Let's see if we can shake hands on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Narrator**
> "The pilot made an announcement that the descent had started. Deivid and Symon went back to their seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Narrator**
> "I took another look outside the window. I could see Staalport, the capital city of Agnolia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Narrator**
> "The large dockyards of the city and the canals -- "Staal" in Agnolian -- appeared closer as our descent continued. Staalport was certainly a fitting name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[35]`
Mówca: **Narrator**
> "A couple of minutes later, we finally touched down. The plane parked. I took a final look out the window. The welcoming ceremony from Agnolia was waiting along the red carpet outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Narrator**
> "After the guards made their way out, I exited the plane."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "Wave at the crowd."]** — Mówca: **Player_Italic**
> "I waved at the crowd that gathered. There were many camera flashes. I started to make my way downstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "Proceed without a gesture."]** — Mówca: **Player_Italic**
> "I started to make my way downstairs. There were many camera flashes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Narrator**
> "Prime Minister Van Hoorten was nowhere in sight. Instead, I was greeted by the Foreign Minister."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Narrator**
> "After handshakes and a couple of photos, I moved to the car where Serge was waiting to drive me to the office of Prime Minister."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Serge Wolkner**
> "“Good day, sir. I hope the flight was comfortable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[42]`
  - -> `[44]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "“Let's go.”"]** — Mówca: **Player**
> "“Let's go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“Yes, it was. Thank you, Serge.”"]** — Mówca: **Player**
> "“Yes, it was. Thank you, Serge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Narrator**
> "I got in the car and we made our way through the foreign streets. Our convoy was protected by Sordish and Agnolian guards in their vehicles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Narrator**
> "We got on the highway beside the port and saw dozens of dockyards and ships anchored. Some of the boats and machinery looked old."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Narrator**
> "The city itself looked very grey and grim. The buildings had a touch of Rumburg's famous Monarkian architecture with a mixture of Sordish signature domes on the older ones."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Narrator**
> "We were now on the main road to the office of the Prime Minister."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Serge Wolkner**
> "“Looks like they are not too happy to see you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[50]`
Mówca: **Narrator**
> "Serge pointed at the crowd that gathered on both sides of the street. It was a protest. They were shouting and yelling at our convoy. Some of them held signs written in Sordish: 'Go Home Rayne', 'We Don't Want Autocrats In Agnolia.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Serge Wolkner**
> "“You know... I never knew Agnolians were so ungrateful. Not everyone sees a great leader like you everyday.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[52]`
  - -> `[54]`
  - -> `[266]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "“They can yell all they want.”"]** — Mówca: **Player**
> "“They can yell all they want.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "“You are absolutely right, Serge. So ungrateful.”"]** — Mówca: **Player**
> "“You are absolutely right, Serge. So ungrateful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "“There have been so many issues in Sordland. I don't know if I can call myself a great leader.”"]** — Mówca: **Player**
> "“There have been so many issues in Sordland. I don't know if I can call myself a great leader.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Serge Wolkner**
> ""I know what it is. They were always scared of Sordland's potential. And now they are afraid that a lion leads Sordland. They are afraid of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[56]`
Mówca: **Serge Wolkner**
> "“Sir, humility is important but not in this case. They were always scared of Sordland's potential. And now they are afraid that a lion leads Sordland. They are afraid of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Serge Wolkner**
> "“Not just that, but you are a man who is selfless enough to help your driver's children.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[58]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_Friend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_Friend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Serge_Friend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[60]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Serge_Friend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Serge_Friend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[61]`
Mówca: **Serge Wolkner**
> "“A true leader, I dare say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`
  - -> `[62]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Don't mention it.”"]** — Mówca: **Player**
> "“Don't mention it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "“How is little Anton doing?”"]** — Mówca: **Player**
> "“How is little Anton doing?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“I treat my people well.”"]** — Mówca: **Player**
> "“I treat my people well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Serge Wolkner**
> "“He is fine, sir. A strong boy. Takes after his namesake for sure!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[66]`
Mówca: **Serge Wolkner**
> "“I can attest to that myself. I am honored to be your driver. And very grateful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[67]`
Mówca: **Serge Wolkner**
> "“Very well, sir. I just want to say that I am honored to be your driver. And very grateful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Serge Wolkner**
> "“We have arrived, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Narrator**
> "The convoy started slowing down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[70]`
Mówca: **Narrator**
> "The car continued through the gates while the security vehicles went the other way. We finally came to a stop in front of the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Narrator**
> "Serge left the car and opened the car door. I exited and began walking to the door where dozens of press and the Prime Minister were waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Narrator**
> "I saw the PM much more clearly as I neared the door. He was shorter than I thought."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Maartin Van Hoorten**
> "“Mr. President. Welcome to Agnolia and to the beautiful city of Staalport.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[74]`
  - -> `[76]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "“Thank you so much for the warm welcome. It is great to be here.”"]** — Mówca: **Player**
> "“Thank you so much for the warm welcome. It is great to be here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Prime Minister.”"]** — Mówca: **Player**
> "“Prime Minister.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "“Good to see you, Maartin.”"]** — Mówca: **Player**
> "“Good to see you, Maartin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Narrator**
> "He reached out for a handshake. The press surrounding us had been waiting for this moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`
  - -> `[80]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "Overpower his handshake."]** — Mówca: **Player_Italic**
> "I overpowered his handshake and he got caught by surprise as the press took the picture of me having the upper hand. He smiled awkwardly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "Shake hands."]** — Mówca: **Player_Italic**
> "We shook hands and smiled at the cameras as the press took pictures."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "Shake hands and hug after."]** — Mówca: **Player_Italic**
> "We shook hands and I went for a hug which was received well by the Prime Minister. The press went wild and took more pictures."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Maartin Van Hoorten**
> "“This way, please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Narrator**
> "He gestured to the entrance of the two-hundred-year old Parliament building."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[83]`
Mówca: **Narrator**
> "We entered and the press followed us inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Maartin Van Hoorten**
> "“I would like to present you with a gift as a sign of friendship between our countries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Narrator**
> "An assistant showed up immediately with a large glass case in her hands. It contained a single sheet of parchment inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[86]`
Mówca: **Maartin Van Hoorten**
> "“This here is one of the first treaties written between Sordland and Agnolia. May it mark the renewal of our friendship today as well!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`
  - -> `[89]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "“I hope so, Mr. Van Hoorten.”"]** — Mówca: **Player**
> "“I hope so, Mr. Van Hoorten.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "“This is an amazing gift. Thank you.”"]** — Mówca: **Player**
> "“This is an amazing gift. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "“Very good.”"]** — Mówca: **Player**
> "“Very good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Narrator**
> "Our photos were taken again. I gestured at one of my retainers who was holding our gift to the PM."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[91]`
  - -> `[93]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "Gift a Sordish-bred puppy despite Maartin's known fear of dogs."]** — Mówca: **Player_Italic**
> "Our gift was a Sordish-bred puppy, despite Maartin's known fear of dogs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "Gift one of the original copies of the first constitution of Sordland."]** — Mówca: **Player_Italic**
> "Our gift was one of the original copies of the first constitution of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "Gift an ornamented ceremonial sword made with Sordish steel."]** — Mówca: **Player_Italic**
> "Our gift was an ornamented ceremonial sword made with Sordish steel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Maartin Van Hoorten**
> "“Ah! An excellent copy. I have always wondered what one of the originals looked like. Thank you for this excellent gift.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[95]`
Mówca: **Maartin Van Hoorten**
> "“Ah! An excellent specimen. This must be hundreds of years old. It looks like this is Sordish steel as well. Very fitting. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Narrator**
> "Maartin stepped backwards when the puppy howled. He very uncomfortably held the dog in his hands and tried to smile at the reporters before putting the dog down on the floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Narrator**
> "The cameras flashed once again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Maartin Van Hoorten**
> "“Let's go to my office. Follow me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Narrator**
> "I followed him and we entered the office of the Prime Minister. With its minimalist wooden decor, the room was far more modest than I expected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[100]`
Mówca: **Maartin Van Hoorten**
> "“Sheesh. I'm thankful to be done with the ceremonies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`
  - -> `[105]`

### Węzeł `[101]`
Mówca: **Maartin Van Hoorten**
> "“Would you like a drink, Mr. Rayne?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[107]`
  - -> `[109]`

### Węzeł `[102]`
**[WYBÓR GRACZA: "“Are you not fond of these ceremonies?”"]** — Mówca: **Player**
> "“Are you not fond of these ceremonies?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[103]`
**[WYBÓR GRACZA: "“I was just about to say the same. I'm not fond of these either.”"]** — Mówca: **Player**
> "“I was just about to say the same. I'm not fond of these either.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[104]`
Mówca: **Narrator**
> "We sat down. He leaned back and made himself comfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Narrator**
> "He got up from his chair and moved over to the bar. There were many varieties of liquor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[107]`
**[WYBÓR GRACZA: "“I will have an Erlory Maroon 30-year-old.”"]** — Mówca: **Player**
> "“I will have an Erlory Maroon 30-year-old.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[108]`
**[WYBÓR GRACZA: "“I wouldn't mind some Agnolian vodka.”"]** — Mówca: **Player**
> "“I wouldn't mind some Agnolian vodka.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
**[WYBÓR GRACZA: "“Just water is fine.”"]** — Mówca: **Player**
> "“Just water is fine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[110]`
Mówca: **Maartin Van Hoorten**
> "“Ah, you know your drink!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[111]`
Mówca: **Maartin Van Hoorten**
> "“Ah, you're keeping it Sordish. A very good whiskey for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Maartin Van Hoorten**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Narrator**
> "He poured the drinks and gave mine to me before sitting down again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[381]`
  - -> `[114]`

### Węzeł `[114]`
**[WYBÓR GRACZA: "“What was with that protest outside? Can't you control them?”"]** — Mówca: **Player**
> "“What was with that protest outside? Can't you control them?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Maartin Van Hoorten**
> "“Lashing out at me before we even start discussing the trade deal? Please look at your own country first before indulging yourself with Agnolian matters, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "“Let's go straight to business.”"]** — Mówca: **Player**
> "“Let's go straight to business.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Maartin Van Hoorten**
> "“Let's.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[118]`
Mówca: **Maartin Van Hoorten**
> "“First of all, if we shake hands on it, this agreement is going to be extremely beneficial for both of us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Maartin Van Hoorten**
> "“You should be able to solve your recession in no time with the investment and money flow coming from us. This is, as you know, on top of the reduced tariffs for trade between our countries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Maartin Van Hoorten**
> "“Of course in return, as discussed between my people and your people before, you will allow us privileged access to your agricultural market.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[121]`
Mówca: **Maartin Van Hoorten**
> "“First of all, I would like to say that I have been watching your recent immigration policy changes. I am glad that you have decided to keep it relaxed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[122]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_RelaxedImmigration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_RelaxedImmigration == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[124]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_RelaxedImmigration == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[125]`
Mówca: **Maartin Van Hoorten**
> "“First of all, I would like to say that I have been watching your recent immigration policy changes. We have worries about the new and tighter immigration laws.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Maartin Van Hoorten**
> "“Immigrants are very important for beneficial economical development. We believe that very much in Agnolia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[127]`
Mówca: **Maartin Van Hoorten**
> "“Immigrants are very important for beneficial economical development. We believe that very much in Agnolia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Maartin Van Hoorten**
> "“I would definitely prefer Sordland to be welcoming to Agnolian citizens and vice versa.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[129]`
  - -> `[131]`

### Węzeł `[129]`
**[WYBÓR GRACZA: "“Before I start caring about Agnolian citizens, I must care about my own people.”"]** — Mówca: **Player**
> "“Before I start caring about Agnolian citizens, I must care about my own people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "“The decision has already been made.”"]** — Mówca: **Player**
> "“The decision has already been made.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[131]`
**[WYBÓR GRACZA: "“Why don't you deal with the problems in your own country first?”"]** — Mówca: **Player**
> "“Why don't you deal with the problems in your own country first?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Maartin Van Hoorten**
> "“Unfortunately, because we share a direct border, I can't simply ignore the problems of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[133]`
Mówca: **Maartin Van Hoorten**
> "“A valid point, but you are not giving me much incentive to work with.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[134]`
Mówca: **Maartin Van Hoorten**
> "“It is reassuring to see Sordland move in a more modern direction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[135]`

### Węzeł `[135]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[136]`
**[WYBÓR GRACZA: "“Are you implying we haven't been modern?”"]** — Mówca: **Player**
> "“Are you implying we haven't been modern?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Maartin Van Hoorten**
> "“Well, certainly not under Tarquin Soll. What did you call him? Corporal Soll? General Soll?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[141]`
  - -> `[142]`

### Węzeł `[138]`
**[WYBÓR GRACZA: "“*Colonel* Soll and you will learn to respect him.”"]** — Mówca: **Player**
> "“*Colonel* Soll and you will learn to respect him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Maartin Van Hoorten**
> "“No need to get angry because of our differing opinions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Narrator**
> "He took a sip from his vodka."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[141]`
**[WYBÓR GRACZA: "“He is irrelevant now.”"]** — Mówca: **Player**
> "“He is irrelevant now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[142]`
**[WYBÓR GRACZA: "“I see you did your homework. We think alike. Don't you worry. I will modernize the country.”"]** — Mówca: **Player**
> "“I see you did your homework. We think alike. Don't you worry. I will modernize the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Maartin Van Hoorten**
> "“Exactly. Now is the time of Anton Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[144]`
Mówca: **Maartin Van Hoorten**
> "“That is...actually very good and refreshing to hear. I hope you can do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[145]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[147]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Maartin Van Hoorten**
> "“I know that you have declared a state of emergency. So early into your presidency, too. So, tell me. How is that going?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[151]`
  - -> `[152]`

### Węzeł `[149]`
Mówca: **Maartin Van Hoorten**
> "“So tell me, Mr. Rayne. Is Sordland a reliable trading partner to Agnolia?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`
  - -> `[159]`

### Węzeł `[150]`
Mówca: **Maartin Van Hoorten**
> "“But it is precisely my business. I need to know if Sordland is a reliable trading partner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[151]`
**[WYBÓR GRACZA: "“I had no choice but to deal with our issues in Sordland.”"]** — Mówca: **Player**
> "“I had no choice but to deal with our issues in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[152]`
**[WYBÓR GRACZA: "“That is none of your business.”"]** — Mówca: **Player**
> "“That is none of your business.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[153]`
Mówca: **Maartin Van Hoorten**
> "“It is worrying that a state of emergency was declared right next to our borders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[154]`
Mówca: **Maartin Van Hoorten**
> "“Sometimes we leaders have to make tough choices. But you need to understand that I need trustworthy trading partners.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[155]`
**[WYBÓR GRACZA: "“It is going well. We are eliminating the threats one by one. Internal *and* external.”"]** — Mówca: **Player**
> "“It is going well. We are eliminating the threats one by one. Internal *and* external.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[156]`
Mówca: **Maartin Van Hoorten**
> "“The reason I am asking these questions is because I need to know if Sordland is a reliable trading partner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[157]`
**[WYBÓR GRACZA: "“Not if you keep acting like *you* have the upper hand.”"]** — Mówca: **Player**
> "“Not if you keep acting like *you* have the upper hand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[158]`
**[WYBÓR GRACZA: "“As long as Agnolia is a reliable trading partner.”"]** — Mówca: **Player**
> "“As long as Agnolia is a reliable trading partner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
**[WYBÓR GRACZA: "“Of course, Mr. Van Hoorten. You can trust Sordland.”"]** — Mówca: **Player**
> "“Of course, Mr. Van Hoorten. You can trust Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[160]`
Mówca: **Maartin Van Hoorten**
> "“I can assure you. We are.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[161]`
Mówca: **Maartin Van Hoorten**
> "“Then you see, we might have a problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Maartin Van Hoorten**
> "“Very good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[165]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Highway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[166]`
Mówca: **Maartin Van Hoorten**
> "“It was a good move to start building that highway. Overall, this will positively affect our trade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Maartin Van Hoorten**
> "“Well done, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[258]`
  - -> `[259]`

### Węzeł `[168]`
Mówca: **Narrator**
> "Van Hoorten leaned back further in contemplation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[382]`
  - -> `[170]`

### Węzeł `[169]`
**[WYBÓR GRACZA: "“So, what's it going to be?”"]** — Mówca: **Player**
> "“So, what's it going to be?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[170]`
**[WYBÓR GRACZA: "“Are you going to talk all day about past deeds or are we going to sign this deal?”"]** — Mówca: **Player**
> "“Are you going to talk all day about past deeds or are we going to sign this deal?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[171]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.AgnoliaTradeDeal_Negotiation -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[172]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.AgnoliaTradeDeal_Negotiation -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[173]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.AgnoliaTradeDeal_Negotiation += 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[174]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.AgnoliaTradeDeal_Negotiation -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[175]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.AgnoliaTradeDeal_Negotiation -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[176]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.AgnoliaTradeDeal_Negotiation -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[177]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.AgnoliaTradeDeal_Negotiation += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[178]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.AgnoliaTradeDeal_Negotiation += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[179]`
Mówca: **Maartin Van Hoorten**
> "“You will be buying steel from us for a higher price, which is a small price to pay really. That is the deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[180]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.AgnoliaTradeDeal_Negotiation >= 2 || BaseGame.Prologue_Studyplace_Deyr_History == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.AgnoliaTradeDeal_Negotiation >= 2 || BaseGame.Prologue_Studyplace_Deyr_History == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] >= 2  or  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[182]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.AgnoliaTradeDeal_Negotiation >= 2 || BaseGame.Prologue_Studyplace_Deyr_History == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] >= 2  or  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Maartin Van Hoorten**
> "“I'm afraid with all your actions so far, I am not convinced that Sordland is the right partner for Agnolia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[184]`
Mówca: **Maartin Van Hoorten**
> "“What do you say, Mr. Rayne?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[268]`
  - -> `[186]`

### Węzeł `[185]`
**[WYBÓR GRACZA: "“I accept.” [-1 Government Budget]"]** — Mówca: **Player**
> "“I accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[186]`
**[WYBÓR GRACZA: "“This is not a beneficial deal for Sordland.”"]** — Mówca: **Player**
> "“This is not a beneficial deal for Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Maartin Van Hoorten**
> "“You went through all this effort to come and say no to me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[188]`
Mówca: **Maartin Van Hoorten**
> "“Excellent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Maartin Van Hoorten**
> "“I'm sorry that you've come all this way for this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[214]`
  - -> `[215]`

### Węzeł `[190]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_TradeDeal = true; BaseGameSupport.Journal_Turn05_Trade_AgnoliaSigned = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Agnolia_TradeDeal"] = true;
Variable["BaseGameSupport.Journal_Turn05_Trade_AgnoliaSigned"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[191]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn05_Trade_AgnoliaFailed = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn05_Trade_AgnoliaFailed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[192]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[193]`
Mówca: **Maartin Van Hoorten**
> "“Before we dive into the paperwork for the trade deal, I want to offer you another possibility.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Maartin Van Hoorten**
> "“I would like to expand on our new partnership. We have regional forces like Rumburg that have been imposing danger on both of our countries. I am of the mind that we must unite. So...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Maartin Van Hoorten**
> "“By the powers bestowed upon me as the Prime Minister of Agnolia, I am offering a military alliance between Sordland and Agnolia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[196]`
**[WYBÓR GRACZA: "“Very well. I accept.”"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[197]`
**[WYBÓR GRACZA: "“Sordland is not ready to go that far with Agnolia.”"]** — Mówca: **Player**
> "“Sordland is not ready to go that far with Agnolia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Maartin Van Hoorten**
> "“What do you think?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[199]`
Mówca: **Maartin Van Hoorten**
> "“That is unfortunate. It would've been beneficial against the Rumburg threat. However, Agnolia can stand by itself against any threat just fine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[200]`
Mówca: **Maartin Van Hoorten**
> "“That is excellent to hear. Our ministers will go over the details later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[201]`
Mówca: **Maartin Van Hoorten**
> "“Now that we have gone this far and are willing to enter an alliance, there is another topic that I would like to bring up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Maartin Van Hoorten**
> "“As you know, Heljiland has been long contested between Agnolia and Valgsland. Those warmongers want to take back the island.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Maartin Van Hoorten**
> "“You know how the international community does not recognise our rightful claim on the island. *Including Sordland*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Maartin Van Hoorten**
> "“What better act to cement our alliance than announcing to the world that Sordland recognises Heljiland to be Agnolian territory?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`

### Węzeł `[205]`
**[WYBÓR GRACZA: "“You are asking too much.”"]** — Mówca: **Player**
> "“You are asking too much.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[206]`
**[WYBÓR GRACZA: "“Another sensible deal. I accept again.”"]** — Mówca: **Player**
> "“Another sensible deal. I accept again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Maartin Van Hoorten**
> "“Most excellent!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[208]`
Mówca: **Maartin Van Hoorten**
> "“It is a reasonable request, but I won't push too far on the matter. We have achieved enough for today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[209]`
Mówca: **Deivid Wisci**
> "“Precisely. Agnolian immigrants in our Agnland region make up a good chunk of the area's economy now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[210]`
Mówca: **Maartin Van Hoorten**
> "“I think they are a waste of time, but alas, that is one of our jobs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[211]`
Mówca: **Maartin Van Hoorten**
> "“It's one of the tougher parts of our job.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[212]`
Mówca: **Maartin Van Hoorten**
> "“You are throwing many months of work down the drain. This is a mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`
  - -> `[271]`

### Węzeł `[213]`
Mówca: **Maartin Van Hoorten**
> "“I took you for someone you were not, I suppose. But you are no different than your predecessors.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`
  - -> `[223]`

### Węzeł `[214]`
**[WYBÓR GRACZA: "“You are making a grave mistake.”"]** — Mówca: **Player**
> "“You are making a grave mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[215]`
**[WYBÓR GRACZA: "“Wait. Can't we work something out?”"]** — Mówca: **Player**
> "“Wait. Can't we work something out?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[216]`
Mówca: **Maartin Van Hoorten**
> "“Today is a historic day!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Maartin Van Hoorten**
> "“Congratulations, Mr. Rayne, for making all the right decisions today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[218]`
Mówca: **Narrator**
> "He stood up from his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Maartin Van Hoorten**
> "“We must continue the official program. As you know, we will pay a visit to our founder's grave for another ceremony. Afterwards, we will move on to the state dinner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[220]`
Mówca: **Maartin Van Hoorten**
> "“Well then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[221]`
**[WYBÓR GRACZA: "“Be careful with your words, Mr. Van Hoorten.”"]** — Mówca: **Player**
> "“Be careful with your words, Mr. Van Hoorten.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[222]`
**[WYBÓR GRACZA: "“You are in no position to judge me. I have made my decision.”"]** — Mówca: **Player**
> "“You are in no position to judge me. I have made my decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[223]`
**[WYBÓR GRACZA: "“There is nothing else to talk about. We are done here.”"]** — Mówca: **Player**
> "“There is nothing else to talk about. We are done here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Maartin Van Hoorten**
> "“I thought this could be the start of a new era, but apparently not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[225]`
Mówca: **Maartin Van Hoorten**
> "“My apologies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[226]`
**[WYBÓR GRACZA: "“Did you bring me here to ridicule me?”"]** — Mówca: **Player**
> "“Did you bring me here to ridicule me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Maartin Van Hoorten**
> "“Of course not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[228]`
Mówca: **Maartin Van Hoorten**
> "“Solve your own problems first before you threaten me, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[229]`
Mówca: **Maartin Van Hoorten**
> "“It is difficult...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[230]`
**[WYBÓR GRACZA: "“I won't be joining. It's time we were on our way back home.”"]** — Mówca: **Player**
> "“I won't be joining. It's time we were on our way back home.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[231]`
**[WYBÓR GRACZA: "“After you.”"]** — Mówca: **Player**
> "“After you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[232]`
Mówca: **Maartin Van Hoorten**
> "“But this is customary. Every Sordish president before you has done this. This won't sit well with us. I must insist we follow the protocol.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[233]`
Mówca: **Narrator**
> "His eyes widened in surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[234]`
**[WYBÓR GRACZA: "“I won't say it twice.”"]** — Mówca: **Player**
> "“I won't say it twice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[235]`
**[WYBÓR GRACZA: "“When you put it like that...sure.”"]** — Mówca: **Player**
> "“When you put it like that...sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[236]`
Mówca: **Maartin Van Hoorten**
> "“This is outrageous. You are not giving confidence to the people of Agnolia right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Maartin Van Hoorten**
> "“But it is your decision, after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Maartin Van Hoorten**
> "“Very well. I will let them know that you are heading out.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Maartin Van Hoorten**
> "“See you later, Mr. President. We will be in touch.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Narrator**
> "I got up from my chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[241]`
  - -> `[243]`

### Węzeł `[241]`
**[WYBÓR GRACZA: "“You are very welcome to come visit Sordland.”"]** — Mówca: **Player**
> "“You are very welcome to come visit Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[242]`
**[WYBÓR GRACZA: "“Take care, Maartin.”"]** — Mówca: **Player**
> "“Take care, Maartin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[243]`
**[WYBÓR GRACZA: "Leave without a word."]** — Mówca: **Player_Italic**
> "I left without a word."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[244]`
Mówca: **Maartin Van Hoorten**
> "“You as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Maartin Van Hoorten**
> "“Surely we can arrange something.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[246]`
Mówca: **Narrator**
> "Outside, Serge was waiting for me. I got in the car and we started driving back to the airport."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Narrator**
> "I briefed Symon and Deivid. The trip back was mostly silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Narrator**
> "I couldn't help but let out a sigh of relief when we touched down in Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[249]`
Mówca: **Narrator**
> "As soon as we left the office, I briefed Symon and Deivid on the outcome of the meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Narrator**
> "The rest of our state trip was full of fake smiles, handshakes, incredibly long ceremonies and even longer meetings between our ministers and their counterparts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[251]`
Mówca: **Narrator**
> "When we came to the end of the trip, the way back was mostly silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[252]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: GameCondition.Turn05_FPnT_AgnoliaTradeVisit = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn05_FPnT_AgnoliaTradeVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[253]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised = true;
BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] = true;
Variable["BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[254]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_Alliance = true; 
BaseGameSupport.Journal_Turn05_Trade_AgnoliaMilitarySigned = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Agnolia_Alliance"] = true;
Variable["BaseGameSupport.Journal_Turn05_Trade_AgnoliaMilitarySigned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[255]`
Mówca: **Maartin Van Hoorten**
> "“We were willing at first, but the situation has changed. We do not have confidence in your state anymore.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[256]`
Mówca: **Narrator**
> "He paused for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[257]`
**[WYBÓR GRACZA: "“Thank you. You are very kind.”"]** — Mówca: **Player**
> "“Thank you. You are very kind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[258]`
**[WYBÓR GRACZA: "“I didn't do it for Agnolia. I did it for the people of Sordland.”"]** — Mówca: **Player**
> "“I didn't do it for Agnolia. I did it for the people of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[259]`
**[WYBÓR GRACZA: "“No need for flattery.”"]** — Mówca: **Player**
> "“No need for flattery.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Maartin Van Hoorten**
> "“Of course. Everything we do is for our people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[261]`
Mówca: **Maartin Van Hoorten**
> "“I give credit when it's necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[262]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[264]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[265]`
Mówca: **Narrator**
> "Serge pointed at the crowd that gathered on both sides of the street. It was a protest. They were shouting and yelling at our convoy. Some of them held signs written in Sordish: 'Sordland Must Pay Its Debts To Agnolia'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[266]`
**[WYBÓR GRACZA: "“I wonder what propaganda their state is feeding them...""]** — Mówca: **Player**
> "“I wonder what propaganda their state is feeding them...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Serge Wolkner**
> ""They are afraid of you, sir. They are scared that Sordland will reach its potential. They don't want you to be seen as the great hero you are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[268]`
**[WYBÓR GRACZA: "“I'm sorry, but I can't agree to this.""]** — Mówca: **Player**
> "“I'm sorry, but I can't agree to this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[269]`
**[WYBÓR GRACZA: "“I can't agree to the higher prices. We prefer to continue with the current steel deal.”"]** — Mówca: **Player**
> "“I can't agree to the higher prices. We prefer to continue with the current steel deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[270]`
**[WYBÓR GRACZA: "“Agnolian steel isn't worth that much, Mr. Van Hoorten.”"]** — Mówca: **Player**
> "“Agnolian steel isn't worth that much, Mr. Van Hoorten.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[271]`
**[WYBÓR GRACZA: "“I'm sorry but my answer is no.”"]** — Mówca: **Player**
> "“I'm sorry but my answer is no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[272]`
Mówca: **Maartin Van Hoorten**
> "“Is that so? You'd rather import it from Rumburg then?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`
  - -> `[271]`

### Węzeł `[273]`
Mówca: **Maartin Van Hoorten**
> "“We believe that Sordland has been given an unfair advantage for too long because of the previous agreements. We can no longer accept this, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Maartin Van Hoorten**
> "“Our people believe that we have long been overshadowed by Sordland. I am here to fix that. With a beneficial trade for both us, nonetheless.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`
  - -> `[277]`

### Węzeł `[275]`
**[WYBÓR GRACZA: "“Is there no room for discussion?”"]** — Mówca: **Player**
> "“Is there no room for discussion?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[276]`
**[WYBÓR GRACZA: "“Then I will accept, Mr. Van Hoorten. We don't want to lose such an important partner as Agnolia.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Then I will accept, Mr. Van Hoorten. We don't want to lose such an important partner as Agnolia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[277]`
**[WYBÓR GRACZA: "“I'm sorry but my answer is no.”"]** — Mówca: **Player**
> "“I'm sorry but my answer is no.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[278]`
**[WYBÓR GRACZA: "“Look, Mr. Van Hoorten. Let's discuss if lower prices are possible.”"]** — Mówca: **Player**
> "“Look, Mr. Van Hoorten. Let's discuss if lower prices are possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[279]`
**[WYBÓR GRACZA: "“No, but that does not change the fact that the prices are too high.”"]** — Mówca: **Player**
> "“No, but that does not change the fact that the prices are too high.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[280]`
Mówca: **Maartin Van Hoorten**
> "“We don't want to lose our cooperation with Sordland. Maybe I can agree with the old prices. I will offer an alternative for the sake of our history together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[281]`
**[WYBÓR GRACZA: "“I agree. Sordland will recognize the island.”"]** — Mówca: **Player**
> "“I agree. Sordland will recognize the island.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[282]`
Mówca: **Maartin Van Hoorten**
> "“Wouldn't it be fitting for Sordland to finally announce the recognition of Heljiland as Agnolian territory? If you do that, we'll have a deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[285]`

### Węzeł `[283]`
Mówca: **Maartin Van Hoorten**
> "“You know how the international community does not recognise our rightful claim on the island. *Including Sordland*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[284]`
Mówca: **Maartin Van Hoorten**
> "“As you know, Heljiland has been long contested between Agnolia and Valgsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[285]`
**[WYBÓR GRACZA: "“You are asking too much.”"]** — Mówca: **Player**
> "“You are asking too much.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Maartin Van Hoorten**
> "“Sordland is rejecting a trade deal that rights the wrongs of the past, and doesn't recognize its partners' territories... Yet we are the ones asking for too much?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[287]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised = true;
BaseGame.Agnolia_CheaperSteel = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] = true;
Variable["BaseGame.Agnolia_CheaperSteel"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[288]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[290]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_HeljilandRecognised == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[291]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[293]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_HeljilandRecognised == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[294]`
Mówca: **Maartin Van Hoorten**
> "“But there is another topic I would like to bring up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[295]`
Mówca: **Maartin Van Hoorten**
> "“As you know, Heljiland has been long contested between Agnolia and Valgsland. Those warmongers want to take back the island.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Maartin Van Hoorten**
> "“You know how the international community does not recognise our rightful claim on the island. *Including Sordland*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Maartin Van Hoorten**
> "“Wouldn't it be fitting for Sordland to finally announce the recognition of Heljiland as Agnolian territory?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`

### Węzeł `[298]`
Mówca: **Maartin Van Hoorten**
> "“But I will still offer an alternative for the sake of our history together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[299]`
Mówca: **Maartin Van Hoorten**
> "“As you know, Heljiland has been long contested between Agnolia and Valgsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Maartin Van Hoorten**
> "“We can only agree to this deal if Sordland finally announces the recognition of Heljiland as Agnolian territory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`
  - -> `[305]`

### Węzeł `[301]`
Mówca: **Maartin Van Hoorten**
> "“You know how the international community does not recognise our rightful claim on the island. *Including Sordland*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[302]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised = true;
BaseGame.Agnolia_TradeDeal = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] = true;
Variable["BaseGame.Agnolia_TradeDeal"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[303]`
**[WYBÓR GRACZA: "“Fair enough. Sordland will recognise the island and Agnolia's other conditions.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Fair enough. Sordland will recognise the island and accept Agnolia's other conditions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[304]`
Mówca: **Maartin Van Hoorten**
> "“We are asking too much?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[305]`
**[WYBÓR GRACZA: "“You are asking too much.”"]** — Mówca: **Player**
> "“You are asking too much.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[306]`
Mówca: **Maartin Van Hoorten**
> "“And you will buy steel from us for a higher price that rights the wrongs of the past.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Maartin Van Hoorten**
> "“First, you will allow us privileged access to your agricultural market.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[308]`
Mówca: **Maartin Van Hoorten**
> "“And there is this issue...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[309]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Agnolia_Agriculture_Market_Access = true;
BaseGame.Situation_Diplomacy_Agnolia_HighSteelPrice = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Agnolia_Agriculture_Market_Access"] = true;
Variable["BaseGame.Situation_Diplomacy_Agnolia_HighSteelPrice"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[310]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn05_Trade_AgnoliaSigned = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn05_Trade_AgnoliaSigned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[311]`
Mówca: **Maartin Van Hoorten**
> "“Excellent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[312]`
Mówca: **Maartin Van Hoorten**
> "“Unfortunate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[313]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[315]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_HeljilandRecognised == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[316]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.CountryReport_Turn05_Valgsland_CondemnsHeljilandDeal = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn05_Valgsland_CondemnsHeljilandDeal"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[317]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Country_Unrest > 0 && (BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true || BaseGame.Reform_Autocrat_Path == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Country_Unrest > 0 && (BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true || BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Country_Unrest"] > 0  and  (Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true  or  Variable["BaseGame.Reform_Autocrat_Path"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[319]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Country_Unrest > 0 && (BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true || BaseGame.Reform_Autocrat_Path == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Country_Unrest"] > 0  and  (Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true  or  Variable["BaseGame.Reform_Autocrat_Path"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[320]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Lenkurg_Unrest = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Lenkurg_Unrest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[321]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[323]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_HP_AgnoliaAlliance = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_AgnoliaAlliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[325]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[327]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[328]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_HP_AgnoliaDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_AgnoliaDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_CheaperSteel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[331]`

### Węzeł `[330]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_CheaperSteel == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_CheaperSteel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[331]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_CheaperSteel == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_CheaperSteel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[332]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_E_AgnoliaDeal_Worse = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_E_AgnoliaDeal_Worse"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[333]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[336]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_R_DarknessDescendsRY = true;
BaseGameSupport.News_Turn05_HP_JournalistArrestedRY = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_R_DarknessDescendsRY"] = true;
Variable["BaseGameSupport.News_Turn05_HP_JournalistArrestedRY"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[337]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[340]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.AgnoliaTradeDeal_Negotiation += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[341]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[343]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[344]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_CheaperSteel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_CheaperSteel == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_CheaperSteel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[346]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_CheaperSteel == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_CheaperSteel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[347]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[348]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[349]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 2;
BaseGame.GovernmentBudget -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;
Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[350]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[352]`

### Węzeł `[351]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[352]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_HeljilandRecognised == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[353]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_G_VanHoortenNotRecognized = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_G_VanHoortenNotRecognized"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[354]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_G_VanHoortenRecognized = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_G_VanHoortenRecognized"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[355]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Agnolia_Trade = true;
BaseGame.Policy_Diplomacy_TradeInitiative = true;
BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised = true;
BaseGame.Policy_Diplomacy_Neutrality = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] = true;
Variable["BaseGame.Policy_Diplomacy_TradeInitiative"] = true;
Variable["BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised"] = true;
Variable["BaseGame.Policy_Diplomacy_Neutrality"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[356]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Agnolia_Trade = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[357]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Agnolia_Trade = true;
BaseGame.Policy_Diplomacy_TradeInitiative = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] = true;
Variable["BaseGame.Policy_Diplomacy_TradeInitiative"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[358]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Agnolia_Agriculture_Market_Access = true;
BaseGame.Situation_Diplomacy_Agnolia_HighSteelPrice = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Agnolia_Agriculture_Market_Access"] = true;
Variable["BaseGame.Situation_Diplomacy_Agnolia_HighSteelPrice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[359]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Agnolia_Agriculture_Market_Access = true;
BaseGame.Situation_Diplomacy_Agnolia_CheapSteelPrice = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Agnolia_Agriculture_Market_Access"] = true;
Variable["BaseGame.Situation_Diplomacy_Agnolia_CheapSteelPrice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[360]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised = true;
BaseGame.Policy_Diplomacy_Neutrality = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised"] = true;
Variable["BaseGame.Policy_Diplomacy_Neutrality"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[361]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Agnolia_Alliance = true;
BaseGame.Policy_Military_JointMilitaryExercises = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] = true;
Variable["BaseGame.Policy_Military_JointMilitaryExercises"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[362]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_Trade == true && BaseGame.Policy_Diplomacy_Agnolia_Trade == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_Trade == true && BaseGame.Policy_Diplomacy_Agnolia_Trade == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] == true  and  Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[364]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Wehlen_Trade == true && BaseGame.Policy_Diplomacy_Agnolia_Trade == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] == true  and  Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[365]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_Trade == true || BaseGame.Policy_Diplomacy_Agnolia_Trade == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`
  - -> `[367]`

### Węzeł `[366]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_Trade == true || BaseGame.Policy_Diplomacy_Agnolia_Trade == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] == true  or  Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[367]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Wehlen_Trade == true || BaseGame.Policy_Diplomacy_Agnolia_Trade == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] == true  or  Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[368]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_IncreasedTrade = false;
BaseGame.Situation_Economy_RecoveredTrade = true;
BaseGame.Situation_Economy_DecreasedTrade = false;
BaseGame.Situation_Diplomacy_FailedTradeNegotiation = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_IncreasedTrade"] = false;
Variable["BaseGame.Situation_Economy_RecoveredTrade"] = true;
Variable["BaseGame.Situation_Economy_DecreasedTrade"] = false;
Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[369]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_IncreasedTrade = true;
BaseGame.Situation_Economy_RecoveredTrade = false;
BaseGame.Situation_Economy_DecreasedTrade = false;
BaseGame.Situation_Diplomacy_FailedTradeNegotiation = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_IncreasedTrade"] = true;
Variable["BaseGame.Situation_Economy_RecoveredTrade"] = false;
Variable["BaseGame.Situation_Economy_DecreasedTrade"] = false;
Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[370]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_RecoveredTrade = false;
BaseGame.Situation_Economy_IncreasedTrade = false;
BaseGame.Situation_Economy_DecreasedTrade = true;
BaseGame.Situation_Diplomacy_FailedTradeNegotiation = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_RecoveredTrade"] = false;
Variable["BaseGame.Situation_Economy_IncreasedTrade"] = false;
Variable["BaseGame.Situation_Economy_DecreasedTrade"] = true;
Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[371]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[372]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_LackOfAllies = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_LackOfAllies"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[373]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Agnland += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy_Agnland"] = Variable["BaseGame.Economy_Agnland"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[374]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Deyr_History == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Deyr_History == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[376]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Studyplace_Deyr_History == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[377]`
Mówca: **Maartin Van Hoorten**
> "“This here is one of the first treaties written between Sordland and Agnolia. Just like the one you prepared with Mr. Wisci before my term. May it mark the renewal of our friendship today as well!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`
  - -> `[89]`

### Węzeł `[378]`
Mówca: **Maartin Van Hoorten**
> "“Sordland is simply too volatile. Elected politicians are getting killed in your country left and right. Not to mention the subsequent protests in between...well...the left and right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[379]`
Mówca: **Narrator**
> "It was time to discuss the good news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[380]`
Mówca: **Maartin Van Hoorten**
> "“This is how we do things in Agnolia, Mr. Rayne. I appreciate the kind words, but flattery alone won't sway me this day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[381]`
**[WYBÓR GRACZA: "“A true gentleman. I can respect that about you, Mr. Hoorten.”"]** — Mówca: **Player**
> "“A true gentleman. I can respect that about you, Mr. Hoorten.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[382]`
**[WYBÓR GRACZA: "“Let's change the course of our nations.”"]** — Mówca: **Player**
> "“Let's change the course of our nations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[383]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: PlaySoundEffect("PlaneLandingSmoothly");)*
- **Efekt (`userScript`):** `PlaySoundEffect("PlaneLandingSmoothly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[384]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: UpdateCountryRelationship("Sordland_Country_Agnolia", "Neutral");)*
- **Efekt (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Agnolia","Neutral");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[385]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Ribel_BergianPoliceAmbushed = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Ribel_BergianPoliceAmbushed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[386]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[387]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Heljiland_Map_Layer = 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Heljiland_Map_Layer"] = 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[388]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_Country_Agnolia", "Country_Agnolia_CheapSteel");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_Country_Agnolia","Country_Agnolia_CheapSteel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[389]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_Country_Agnolia", "Country_Agnolia_CheapSteel");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_Country_Agnolia","Country_Agnolia_CheapSteel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[390]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_Country_Agnolia", "Country_Agnolia_Alliance");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_Country_Agnolia","Country_Agnolia_Alliance");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[391]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_Country_Agnolia", "Country_Agnolia_Trade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_Country_Agnolia","Country_Agnolia_Trade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[392]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: AddPlayerCountryStatus("Country_Sordland_Recognition_HeljilandAgnolia");)*
- **Efekt (`userScript`):** `AddPlayerCountryStatus("Country_Sordland_Recognition_HeljilandAgnolia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[393]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: AddPlayerCountryStatus("Country_Sordland_Recognition_HeljilandAgnolia");)*
- **Efekt (`userScript`):** `AddPlayerCountryStatus("Country_Sordland_Recognition_HeljilandAgnolia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[394]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: AddPlayerCountryStatus("Country_Sordland_Recognition_HeljilandAgnolia");)*
- **Efekt (`userScript`):** `AddPlayerCountryStatus("Country_Sordland_Recognition_HeljilandAgnolia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[395]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_Country_Agnolia", "Progress_DiplomaticMission_Agnolia");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_Country_Agnolia","Progress_DiplomaticMission_Agnolia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[396]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: EnableNews("G_AgnoliaAlliance");)*
- **Efekt (`userScript`):** `EnableNews("G_AgnoliaAlliance");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[397]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: EnableNews("G_HeljilandRecognized"))*
- **Efekt (`userScript`):** `EnableNews("G_HeljilandRecognized");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[398]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_Country_Agnolia", "Country_Agnolia_Trade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_Country_Agnolia","Country_Agnolia_Trade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[399]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: EnableNews("G_AgnoliaAlliance");)*
- **Efekt (`userScript`):** `EnableNews("G_AgnoliaAlliance");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`
