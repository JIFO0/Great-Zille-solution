# Sordland/Turn01/InT_Infrastructure

- **ID konwersacji:** `8`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Sordland/Turn_01/008_InT_Infrastructure.md`
- **Liczba węzłów dialogowych:** 144
- **Liczba wyborów gracza:** 33

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[35]** Gus Manger
- **[44]** Lileas Graf
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Prologue_Birthplace_Holsord_Middle`
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGameIsolated.Turn01_EnT_Listened_Highway`
- `BaseGameIsolated.Turn01_EnT_Listened_Railway`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGameIsolated.Turn01_EnT_Listened_Highway`
- `BaseGameIsolated.Turn01_EnT_Listened_Railway`
- `BaseGameSupport.Journal_Turn01_PickedHighway`
- `BaseGameSupport.Journal_Turn01_PickedRailway`
- `GameCondition.Turn01_InT_Infrastructure`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 23

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[37]` (Symon Holl): `Variable["BaseGame.Turn01_InT_Investment_Railway"] = true;`
- Węzeł `[47]` (Symon Holl): `Variable["BaseGameIsolated.Turn01_EnT_Listened_Railway"] = true;`
- Węzeł `[52]` (Symon Holl): `Variable["BaseGameIsolated.Turn01_EnT_Listened_Highway"] = true;`
- Węzeł `[57]` (Symon Holl): `Variable["GameCondition.Turn01_InT_Infrastructure"] = true;`
- Węzeł `[121]` (Symon Holl): `Variable["BaseGameSupport.Journal_Turn01_PickedHighway"] = true;`
- Węzeł `[122]` (Symon Holl): `Variable["BaseGameSupport.Journal_Turn01_PickedRailway"] = true;`
- Węzeł `[123]` (Symon Holl): `Variable["BaseGame.Turn01_InT_Investment_Highway"] = true;`
- Węzeł `[124]` (Symon Holl): `AddTokenStatus("Sordland_City_Lachaven","Progress_Highway"); -- Assigns given token status to the...`
- *...oraz 15 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Symon Holl)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Symon Holl**
> "“Mr. President, we need to focus on boosting the economy as quickly as possible. One of the fastest ways to achieve this is through infrastructure projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[42]`
  - -> `[58]`

### Węzeł `[4]`
Mówca: **Symon Holl**
> "“On the one hand, businessmen are complaining about the slow logistical rail network between Holsord and Lachaven.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[5]`
Mówca: **Lileas Graf**
> "“On the other hand, citizens are criticizing the lack of a proper highway connection between Lachaven and Arvory. The narrow roads by the seaside are not only dangerous but also difficult to traverse.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[61]`
  - -> `[62]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "“What can we focus on?”"]** — Mówca: **Player**
> "“What can we focus on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[7]`
Mówca: **Symon Holl**
> "“To that point, I defined two important projects for your attention. The H-3 Highway project and the L-1 High-speed railway project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“The H-3 highway project.”"]** — Mówca: **Player**
> "“The H-3 highway project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Symon Holl**
> "“The H-3 project aims to improve the abysmal state of the road network in the Agnland region bordering Agnolia. The area is home to several million Agno-Sordish and Sordish citizens, who currently feel neglected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[10]`
Mówca: **Symon Holl**
> "“Your predecessor Alphonso failed to deliver on this campaign promise. But now, we have the opportunity to start the construction of a groundbreaking railway project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "“The L-1 high-speed rail project.”"]** — Mówca: **Player**
> "“The L-1 high-speed rail project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[12]`
Mówca: **Symon Holl**
> "“There are no proper highway connections to and from Agnland. The mayor of Arvory, Eric Niel, has been asking for a bigger budget to develop the regional infrastructure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[13]`
**[WYBÓR GRACZA: ""We can't leave the request of Eric Niel -- a party member -- unanswered.""]** — Mówca: **Player**
> ""We can't leave the request of Eric Niel -- a party member -- unanswered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "“I agree. This could also hurt the local businesses.”"]** — Mówca: **Player**
> "“I agree. This could also hurt the local businesses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Agreed. The superpowers have led the way with their high-quality technology. We've got to keep up.”"]** — Mówca: **Player**
> "“Agreed. The superpowers have led the way with their high-quality technology. We've got to keep up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“This could also empower businesses and bring investments.”"]** — Mówca: **Player**
> "“This could also empower businesses and bring investments.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[17]`
Mówca: **Symon Holl**
> "“As you know, our current trains cannot meet the standards of today. As many other countries adopt new electric engine technology to power up their trains, we're falling behind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“That must be cumbersome for the citizens.""]** — Mówca: **Player**
> "“That must be cumbersome for the citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "“The major cities of Sordland need more infrastructure to support their growing populations.”"]** — Mówca: **Player**
> "“The major cities of Sordland need more infrastructure to support their growing populations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[20]`
Mówca: **Symon Holl**
> "“Let's take a more detailed look at the upgrade proposal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "Look at the map."]** — Mówca: **Player_Italic**
> "Lileas was pointing at Lachaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“I have decided on the H-3 highway project to improve the infrastructure in our poorer regions.”"]** — Mówca: **Player**
> "“I have decided on the H-3 highway project to improve the infrastructure in our poorer regions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "“I have decided on the L-1 high-speed rail project to improve the connection between our most productive cities.”"]** — Mówca: **Player**
> "“I have decided on the L-1 high-speed rail project to improve the connection between our most productive cities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[24]`
Mówca: **Gus Manger**
> "“News about the new electric trains in United Contana has piqued our businesses' interest. They too want to transport resources and material from Holsord to Lachaven with great speed and efficiency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`
  - -> `[19]`
  - -> `[102]`

### Węzeł `[25]`
Mówca: **Lileas Graf**
> "“He told us that even trucks are having a hard time travelling through the main roads. The increased traffic is causing trouble for people commuting in and out of the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[18]`
  - -> `[14]`
  - -> `[105]`

### Węzeł `[26]`
Mówca: **Gus Manger**
> "“From there, it will go to Anrica first...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[27]`
Mówca: **Symon Holl**
> "“Our plan is to upgrade the old L-1 line from Holsord to Lachaven. It will transform into a high-speed railway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "Look at the map."]** — Mówca: **Player_Italic**
> "Gus was pointing at Holsord while Symon was looking attentively."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[29]`
Mówca: **Symon Holl**
> "“The Ministry estimates that construction will be completed in two years if every step going forward is executed successfully.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Thank you all for your contributions and thoughts.”"]** — Mówca: **Player**
> "“Thank you all for your contributions and thoughts. Have a good day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Good. Is there anything else?”"]** — Mówca: **Player**
> "“Good. Is there anything else?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[32]`
Mówca: **Symon Holl**
> "“The negotiations will begin in the middle of this year. You will be able to award the contract to a corporation of your choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[33]`
Mówca: **Symon Holl**
> "“So, which one do you want to hear about first?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[11]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Mr. Holl repositioned himself on his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“We must prove our capabilities. The people must know that this administration can get things done.”"]** — Mówca: **Player**
> "“We must prove our capabilities. The people must know that this administration can get things done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“We must improve the economy of the nation and bring it out of recession.”"]** — Mówca: **Player**
> "“We must improve the economy of the nation and bring it out of recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[37]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[38]`
Mówca: **Symon Holl**
> "“This should be all, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Very interesting. But I still want to hear about the highway project.”"]** — Mówca: **Player**
> "“Very interesting. But I still want to hear about the highway project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "“Very interesting. But I still want to hear about the railway project.”"]** — Mówca: **Player**
> "“Very interesting. But I still want to hear about the railway project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[41]`
**[WYBÓR GRACZA: "“I have settled on a decision.”"]** — Mówca: **Player**
> "“I have settled on a decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[43]`
Mówca: **Lileas Graf**
> "“Thank God. I knew that you would see reason.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[44]`
Mówca: **Gus Manger**
> "“The right choice, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[45]`
Mówca: **Lileas Graf**
> "“See you soon, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Gus Manger**
> "“Have a nice day, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[95]`
  - -> `[89]`

### Węzeł `[47]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Railway = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Railway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[48]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Highway == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Highway == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Highway"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[39]`

### Węzeł `[50]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn01_EnT_Listened_Highway == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Highway"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[51]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [Symon Holl: "“The H-3 project aims to improve th..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[52]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Highway = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Highway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[53]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Railway == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Railway == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Railway"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[55]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn01_EnT_Listened_Railway == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Railway"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[56]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [Symon Holl: "“Your predecessor Alphonso failed t..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[57]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: GameCondition.Turn01_InT_Infrastructure = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn01_InT_Infrastructure"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "“Agreed.”"]** — Mówca: **Player**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[59]`
Mówca: **Symon Holl**
> "“What really matters is that your first economic act accomplishes something tangible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[60]`
Mówca: **Gus Manger**
> "“The mayor of Anrica, Curtan Leste, also requested this project to be prioritized.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "“We need to pick the most profitable option for economic growth.”"]** — Mówca: **Player**
> "“We need to pick the most profitable option for economic growth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "“The citizens and their demands matter the most.”"]** — Mówca: **Player**
> "“The citizens and their demands matter the most.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "“We need to heed the calls of our businesses in these days of recession.”"]** — Mówca: **Player**
> "“We need to heed the calls of our businesses in these days of recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Lileas Graf**
> "“It is not businesspeople who are suffering now, but ordinary folk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[65]`
Mówca: **Gus Manger**
> "“Agreed. Improving the rail connection from Holsord to Lachaven would be much more beneficial to our economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[66]`
Mówca: **Gus Manger**
> "“Which is obviously connecting our two most economically powerful cities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "“Yes, we should link these rural areas in the middle with the major cities of Sordland.”"]** — Mówca: **Player**
> "“Yes, we should link these rural areas in the middle with the major cities of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "“I believe this would benefit Sordish businesses and Sordland as a whole.”"]** — Mówca: **Player**
> "“I believe this would benefit Sordish businesses and Sordland as a whole.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Investing in regions that are already developed makes little sense.”"]** — Mówca: **Player**
> "“Investing in regions that are already developed makes little sense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "“We should no longer neglect a key region for our trade with Agnolia.”"]** — Mówca: **Player**
> "“We should no longer neglect a key region for our trade with Agnolia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "“Our Agno-Sordish citizens should be respected as Sords like all of us.”"]** — Mówca: **Player**
> "“Our Agno-Sordish citizens should be respected as Sords like all of us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "“It makes little sense to put investments in such a remote region.”"]** — Mówca: **Player**
> "“It makes little sense to put investments in such a remote region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[73]`
Mówca: **Lileas Graf**
> "“As mayor, I saw the central government continuously neglect our country's Agno-Sordish-dominated regions. Is this administration going to continue that kind of negligence?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`
  - -> `[72]`

### Węzeł `[74]`
Mówca: **Lileas Graf**
> "“We are talking about the wealthiest regions and forgetting about Agnland, which needs the investment far more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[75]`
Mówca: **Lileas Graf**
> "“For the wealthy and middle-class citizens of these regions, but not for the poor dears who wouldn't be able to afford the increased ticket prices.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[76]`
Mówca: **Lileas Graf**
> "“I completely agree. Our attentions must be diverted to the needy. The H-3 is a much more logical plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[77]`
Mówca: **Gus Manger**
> "“Sure. But most goods flow to Lachaven and Holsord, which means we should give more importance to logistics there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[78]`
Mówca: **Gus Manger**
> "“Yes, there should be no preference or separation among Sordish citizens. Meaning we should think about what's best for the country overall.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[79]`
Mówca: **Gus Manger**
> "“That is why we should initiate the L-1 project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[80]`
Mówca: **Narrator**
> "Evening settled on the beautiful coastline of Lachaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[81]`
Mówca: **Symon Holl**
> "“The ministry can only support one project at a time with our current capacity and budget. Let's move on to the details of each.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[82]`
Mówca: **Narrator**
> "Lileas started talking as soon as Symon took a breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[83]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Railway == true && BaseGameIsolated.Turn01_EnT_Listened_Highway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Railway == true && BaseGameIsolated.Turn01_EnT_Listened_Highway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Railway"] == true  and  Variable["BaseGameIsolated.Turn01_EnT_Listened_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[85]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn01_EnT_Listened_Railway == true && BaseGameIsolated.Turn01_EnT_Listened_Highway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Railway"] == true  and  Variable["BaseGameIsolated.Turn01_EnT_Listened_Highway"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[86]`
Mówca: **Narrator**
> "Evening settled on the beautiful coastline of Lachaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[87]`
Mówca: **Narrator**
> "Evening settled on the beautiful coastline of Lachaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[88]`
Mówca: **Narrator**
> "Evening settled on the beautiful coastline of Lachaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[89]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[91]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Lachaven_Rich == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[92]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[94]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Deyr_Poor == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[95]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Holsord_Middle == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Holsord_Middle == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[97]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Holsord_Middle == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[98]`
Mówca: **Narrator**
> "But enjoying the luxurious mansion wasn't the main reason of our visit. We gathered the economic team here to discuss the new infrastructure investment project."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[99]`
Mówca: **Narrator**
> "The view towards the Markian Sea from Lachaven was nothing short of exquisite. The seaside state residence fittingly named the Blue Mansion was large, fine and accommodating."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[100]`
Mówca: **Lileas Graf**
> "“Their demands are just. The dire situation of the road infrastructure between Lachaven and Arvory can't be neglected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Gus Manger**
> "“But the return in investment will be low. Our concern should be economic growth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[102]`
**[WYBÓR GRACZA: ""I'm not fully convinced yet. Please explain further.""]** — Mówca: **Player**
> ""I'm not fully convinced yet. Please explain further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[103]`
Mówca: **Lileas Graf**
> "“I know him personally and can vouch that he is a trustworthy member of our party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[104]`
Mówca: **Lileas Graf**
> "“It is, bless their souls. I'm happy we're thinking alike on the matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "“I'm not sure if this region should be a priority for us right now.”"]** — Mówca: **Player**
> "“I'm not sure if this region should be a priority for us right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[106]`
Mówca: **Symon Holl**
> "“Businessmen in the region will be very content, which in turn will increase investments and employment. Therefore I will recommend the L-1 high-speed rail project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[107]`
Mówca: **Lileas Graf**
> "“Our citizens will be quite pleased if we successfully accomplish this. Besides, if we enter trade talks with Agnolia, they will see the investment as a positive sign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[108]`
Mówca: **Lileas Graf**
> "“I have to disagree. it will increase the speed of transportation throughout the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[109]`
Mówca: **Gus Manger**
> "“Only technological advancement will give us an edge in the international arena.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[110]`
Mówca: **Gus Manger**
> "“This should be our priority, growth and development optimization.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[111]`
Mówca: **Narrator**
> "Half an hour had already passed since the start of the meeting. Unfortunately I did not even have the chance to have my usual afternoon coffee."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Narrator**
> "Looking at the view from the windows, I let my mind drift for a couple of seconds. Symon's voice brought me back into the ongoing discussion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[113]`
Mówca: **Symon Holl**
> "“Excellent. What will your final choice be, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[114]`
Mówca: **Gus Manger**
> "“...and then connect to Gelsord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[115]`
Mówca: **Gus Manger**
> "“After which it will reach Lachaven, our economic powerhouse.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[116]`
Mówca: **Gus Manger**
> "“The L-1 will significantly boost the economies of the newly linked cities and even the rural areas in between. Lachaven is our primary port, so the goods unloaded there will be transported to Holsord much faster.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`
  - -> `[69]`

### Węzeł `[117]`
Mówca: **Lileas Graf**
> "“...from there it goes all the way to Arvory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Lileas Graf**
> "“As a result, the road network towards the Agnolian capital Staalport will also improve substantially.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Symon Holl**
> "“It has to be pointed out that the highway would be less beneficial in the short term.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[120]`
Mówca: **Narrator**
> "She paused and leaned forward in her chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[121]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn01_PickedHighway = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_PickedHighway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[122]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn01_PickedRailway = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_PickedRailway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[123]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[124]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Lachaven", "Progress_Highway");

// Assigns given token status to the given city)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Lachaven","Progress_Highway");
-- Assigns given token status to the given city;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[125]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Holsord", "Progress_Railway");

// Assigns given token status to the given city)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Holsord","Progress_Railway");
-- Assigns given token status to the given city;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[126]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: LookAt("Sordland_City_Lachaven");)*
- **Efekt (`userScript`):** `LookAt("Sordland_City_Lachaven");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[127]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: LookAtModeOff();)*
- **Efekt (`userScript`):** `LookAtModeOff();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[128]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: LookAt("Sordland_City_Lenkurg");)*
- **Efekt (`userScript`):** `LookAt("Sordland_City_Lenkurg");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[129]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: LookAt("Sordland_City_Arvory");)*
- **Efekt (`userScript`):** `LookAt("Sordland_City_Arvory");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[130]`
Mówca: **Lileas Graf**
> "“The H-3 highway route starts here in Lachaven...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[131]`
Mówca: **Lileas Graf**
> ""...and from there it leads to Lenkurg...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[132]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: LookAt("Sordland_City_Holsord");)*
- **Efekt (`userScript`):** `LookAt("Sordland_City_Holsord");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Gus Manger**
> "“The planned construction starts right here at the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: LookAt("Sordland_City_Anrica");)*
- **Efekt (`userScript`):** `LookAt("Sordland_City_Anrica");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[135]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: LookAt("Sordland_City_Gelsord");)*
- **Efekt (`userScript`):** `LookAt("Sordland_City_Gelsord");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[136]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: LookAt("Sordland_City_Lachaven");)*
- **Efekt (`userScript`):** `LookAt("Sordland_City_Lachaven");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[137]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: LookAtModeOff();)*
- **Efekt (`userScript`):** `LookAtModeOff();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[138]`
Mówca: **Narrator**
> "He leaned forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[139]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: LookAtModeOff();)*
- **Efekt (`userScript`):** `LookAtModeOff();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[140]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: LookAt("Sordland_City_Lachaven");)*
- **Efekt (`userScript`):** `LookAt("Sordland_City_Lachaven");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[141]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: LookAt("Sordland_City_Arvory");)*
- **Efekt (`userScript`):** `LookAt("Sordland_City_Arvory");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[142]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: LookAt("Sordland_City_Holsord");)*
- **Efekt (`userScript`):** `LookAt("Sordland_City_Holsord");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[143]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
