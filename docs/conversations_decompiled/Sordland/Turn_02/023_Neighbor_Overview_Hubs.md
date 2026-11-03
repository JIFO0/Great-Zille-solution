# Sordland/Turn02/Neighbor Overview Hubs

- **ID konwersacji:** `23`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Sordland/Turn_02/023_Neighbor_Overview_Hubs.md`
- **Liczba węzłów dialogowych:** 158
- **Liczba wyborów gracza:** 33

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[21]** Deivid Wisci
- **[38]** Lucian Galade
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Prologue_Military_Order_Accomplished`
- `BaseGame.Promise_Immigration_Relaxed`
- `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia`
- `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia`
- `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg`
- `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland`
- `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia`
- `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia`
- `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg`
- `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland`
- `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen`
- `SharedSupport.Codex_History_ImportantEvents_AnnexationOfDome`
- `SharedSupport.Codex_History_ImportantEvents_GreatFireOfConriat`
- `SharedSupport.Codex_History_ImportantEvents_HeljiIslandInvasion`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[22] Sordland/Turn02/FPnT_DiplomacyOverview** (../Turn_02/022_FPnT_DiplomacyOverview.md), Węzeł `[69]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 8
- **Węzły modyfikujące stan gry:** 14

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[6]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia"] = true;`
- Węzeł `[12]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen"] = true;`
- Węzeł `[13]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland"] = true;`
- Węzeł `[48]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia"] = true;`
- Węzeł `[49]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg"] = true;`
- Węzeł `[106]` (Paskal Beniwoll): `Variable["SharedSupport.Codex_History_ImportantEvents_AnnexationOfDome"] = true;`
- Węzeł `[142]` (Paskal Beniwoll): `Variable["SharedSupport.Codex_History_ImportantEvents_HeljiIslandInvasion"] = true;`
- Węzeł `[143]` (Paskal Beniwoll): `Variable["SharedSupport.Codex_History_ImportantEvents_GreatFireOfConriat"] = true;`
- *...oraz 6 innych węzłów ze skryptami.*

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
  - -> `[5]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `22` (*Sordland/Turn02/FPnT_DiplomacyOverview*), Węzeł `[69]`

### Węzeł `[3]`
**[WYBÓR GRACZA: "“I was young and I made a mistake.”"]** — Mówca: **Player**
> "“I was young and I made a mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Overview Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[9]`
  - -> `[14]`
  - -> `[74]`

### Węzeł `[5]`
Mówca: **Deivid Wisci**
> "“I will start by providing a brief overview of our current status with our neighbours. What would you like to start with?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "“Let's move on.”"]** — Mówca: **Player**
> "“Let's move on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Overview Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[20]`
**[WYBÓR GRACZA: "“I'd like to hear about Agnolia.”"]** — Mówca: **Player**
> "“I'd like to hear about Agnolia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "“I want to know more about Valgsland.”"]** — Mówca: **Player**
> "“I want to know more about Valgsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“What's the latest situation in Wehlen?”"]** — Mówca: **Player**
> "“What's the latest situation in Wehlen?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[23]`
Mówca: **Deivid Wisci**
> "“Our *brotherly* nation to our north-east, Agnolia. They are still diplomatically non-aligned and probably has one of the most democratic systems between our neighbours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[24]`
Mówca: **Deivid Wisci**
> "“Our cousins of old across the Markian Sea wish to have good relations with us. As we all know, Valgsland is a socialist republic aligned with United Contana. They are an important regional player.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[25]`
Mówca: **Deivid Wisci**
> "“It is tumultuous in the south, as always. Wiktor Smolak is expanding his powers among protests from Wehzek people. However, he is quite positive about a normalisation of relationship between our countries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[26]`
Mówca: **Deivid Wisci**
> "“Additionally, the latest numbers indicate that currently, a million Agno-Sordish citizens live in the Agnland region of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[27]`
Mówca: **Iosef Lancea**
> "“They haven't been in good standing with us for the past two hundred years. Recently, they have also joined the Communist Contanan Security Pact, subjugating themselves to United Contana.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[28]`
Mówca: **Deivid Wisci**
> "“Our main goal should be to avoid a refugee crisis like the late 1920’s. That civil war had major security and economic repercussions on Sordish soil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[29]`
Mówca: **Iosef Lancea**
> "“In addition, a relaxed immigration policy was one of Agnolia's main requests. Which is unacceptable. Most of the migrants in our country haven't even assimilated into Sordish culture. Adding more won't help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[30]`
Mówca: **Lucian Galade**
> "“Unfortunately, billions of Sordish Ren worth of cargo is transported close to Valgslandian maritime borders on the Markian Sea and the Grey Strait.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[31]`
Mówca: **Deivid Wisci**
> "“Two important neighbouring countries remain. Lespia and Rumburg. Which would you like to hear about first?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Overview Hub 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[33]`
  - -> `[36]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[39]`
Mówca: **Deivid Wisci**
> "“Our southern neighbour is aligning itself more and more with Arcasia. Lespia is currently led by Prime Minister Patricio Alvarez.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[40]`
Mówca: **Iosef Lancea**
> "“You paid the price for your mistake so it doesn't matter anymore.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[41]`
Mówca: **Deivid Wisci**
> "“Now to the most troublesome nation; Rumburg. A constitutional monarchy led by Queen Beatrice Livingston.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "“What about Lespia?”"]** — Mówca: **Player**
> "“What about Lespia?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“What is the situation with Rumburg?”"]** — Mówca: **Player**
> "“What is the situation with Rumburg?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[44]`
Mówca: **Lucian Galade**
> "“There are hundreds of very privileged oligarchs who invest inside and outside of Lespia. Some made significant business investments in the cities of Benfi and Valgen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[45]`
Mówca: **Deivid Wisci**
> "“I am certain that the recession has a lot to do with their retraction of investments. Once they see that money isn't in the picture they vanish rather quickly because they are capitalists.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[46]`
Mówca: **Lucian Galade**
> "“We could use their aggressive attitude against them by convincing the international community.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[47]`
Mówca: **Iosef Lancea**
> "“While Thornbourgh openly denies such claims, their past and current actions make it clear that they want to destabilize us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Overview Hub 2])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[51]`
Mówca: **Deivid Wisci**
> "“This covers the overview of the current situation. We will move on to our trade choice and the response to Rumburg's diplomatic escalation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[52]`
Mówca: **Deivid Wisci**
> "“Our past relations have been great but during the last decade, their investments to Sordland dwindled due to our instability.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[70]`
  - -> `[71]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia == true && BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia == true && BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia"] == true  and  Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia == true && BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia"] == true  and  Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[56]`
Mówca: **Deivid Wisci**
> "“Unsurprisingly, the Agnolian Prime Minister Maartin Van Hoorten is expecting better cooperation through a new, fairer trade deal with us. It was one of his election mandates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`
  - -> `[118]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "“We'll think about his request. The matter is still on the table.”"]** — Mówca: **Player**
> "“We'll think about his request. The matter is still on the table.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "“A more comprehensive trade deal sounds beneficial to all sides.”"]** — Mówca: **Player**
> "“A more comprehensive trade deal sounds beneficial to all sides.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[59]`
Mówca: **Deivid Wisci**
> "“Recently, the relationship has warmed up thanks to Emmerich Hegel. As a result, diplomatic talks can be conducted in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`
  - -> `[135]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“It's not easy to forget about the Great Fire of Conriat. Thousands of lives were lost that day.”"]** — Mówca: **Player**
> "“It's not easy to forget about the Great Fire of Conriat. Thousands of lives were lost that day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "“Breaking the ice with Valgsland could be good, if we are to rise diplomatically.”"]** — Mówca: **Player**
> "“Breaking the ice with Valgsland could be good, if we are to rise diplomatically.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[62]`
Mówca: **Narrator**
> "Lucian looked slightly worried."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[63]`
Mówca: **Lucian Galade**
> "“This causes significant risks to our imports and exports in the case of a deterioration in relations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[139]`

### Węzeł `[64]`
Mówca: **Deivid Wisci**
> "“But if we want to help them, we must not treat refugees like we did in the '30s. I still can’t stomach the inhumanity those people suffered.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`
  - -> `[133]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“A trade agreement with them would improve stability and increase mutual trade.”"]** — Mówca: **Player**
> "“A trade agreement with them would improve stability and increase mutual trade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“Why help such a disorganized state? Not sure about what we can do to help them.”"]** — Mówca: **Player**
> "“Why help such a disorganized state? I'm not even sure what we can do to help them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[67]`
Mówca: **Deivid Wisci**
> "“They are strong and have the motivation, as well as the means, to damage us. We shouldn't give them any reasons to pursue aggression.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`
  - -> `[92]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "“I will take your advice in consideration.”"]** — Mówca: **Player**
> "“I will take your advice in consideration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Rumburg is and always will be a rogue like state. Nothing can be done about them.”"]** — Mówca: **Player**
> "“Rumburg is and always will be a rogue-like state. Nothing can be done about them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "“Lespia is a sleeping giant. We should not awake them.”"]** — Mówca: **Player**
> "“Lespia is a sleeping giant. We should not awake them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "“They keep turning a blind eye towards the region. Thinking that Lespia is above it all.”"]** — Mówca: **Player**
> "“They keep turning a blind eye towards the region, thinking that Lespia is above it all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[72]`
Mówca: **Iosef Lancea**
> "“They have shown a selfish attitude during the Wehlen Civil War by closing their borders and funnelling refugees to cross into Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Narrator**
> "Lucian cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[104]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia == true  || BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland == true || BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia == true  || BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland == true || BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia"] == true   or  Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland"] == true  or  Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia == true  || BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland == true || BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia"] == true   or  Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland"] == true  or  Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[77]`
Mówca: **Iosef Lancea**
> "“The weapons caches found by our intelligence agency clearly shows what their goals are. Our military must be steadfast and our diplomacy valiant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[78]`
Mówca: **Deivid Wisci**
> "“It is in our national interest to prevent the formation of a failed state on our western border.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[79]`
Mówca: **Lucian Galade**
> "“They are the jewel of the continent and the second largest economy in Eastern Merkopa. Though wealthy, Lespia suffers from excessive economic inequality.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[80]`
Mówca: **Iosef Lancea**
> "“I highly advise caution and calculated action against Rumburg. Our military must be prepared, the threat is real.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "“I did what was right.”"]** — Mówca: **Player**
> "“I did what was right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Iosef Lancea**
> "“Soldiers do not decide on what is right. Soldiers do what they are told to do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[83]`
Mówca: **Iosef Lancea**
> "“We are actively monitoring the sea routes and cargo ships. For now, there is no immediate threat. But we don't know what can happen in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[84]`
Mówca: **Lucian Galade**
> "“Wehlen has been increasingly aligning itself towards the communist alliance, another point to analyse.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[85]`
Mówca: **Deivid Wisci**
> "“Our focus should be on the current matters. The Bludish minority is very large inside Wehlen too, which is a factor to consider.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[86]`
Mówca: **Narrator**
> "He opened his mouth to say something but Deivid cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[87]`
Mówca: **Deivid Wisci**
> "“They surely are a powerful nation. Despite that, they don't tend to meddle in the region and haven't for a long time, with the exception of Wehlen. Let's not antagonize them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[88]`
Mówca: **Deivid Wisci**
> "“The Lespian mentality is influenced by a certain aura of heroism and specialism. Their moral compass is different from ours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[89]`
Mówca: **Deivid Wisci**
> "“These types of nations will always try to make up a casus belli, a reason to declare war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[90]`
Mówca: **Deivid Wisci**
> "“We can act in our limits and make sure we are prepared for anything. Sword rattling is not advised in my opinion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[91]`
Mówca: **Deivid Wisci**
> "“They have shown similar behaviour to their neighbouring countries before but we must be cautious.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "“We must prevent them from interfering in our affairs.”"]** — Mówca: **Player**
> "“We must prevent them from interfering in our affairs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[93]`
Mówca: **Deivid Wisci**
> "“It could be but it would also mean that we would draw closer to the Arcasia block and near the Arcasian Treaty Organisation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[94]`
**[WYBÓR GRACZA: "“Allying with the richest regional nation could be beneficial.”"]** — Mówca: **Player**
> "“Allying with the richest regional nation could be beneficial.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[95]`
Mówca: **Narrator**
> "Iosef looked stern and full of resolve."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[100]`

### Węzeł `[96]`
Mówca: **Deivid Wisci**
> "“We are always in dialogue with our Rumburg ambassador to make sure a channel is open to solve disputes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[97]`
**[WYBÓR GRACZA: "“The Rumburg threat is one of our top priorities. You can be assured of that.”"]** — Mówca: **Player**
> "“The Rumburg threat is one of our top priorities. You can be assured of that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[98]`
Mówca: **Lucian Galade**
> "“Either way, treading carefully with them would be the safest bet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[99]`
Mówca: **Deivid Wisci**
> "“I agree, some in our government are taking the issue out of proportion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[100]`
**[WYBÓR GRACZA: "“I think the threat is far too overblown.”"]** — Mówca: **Player**
> "“I think the threat is far too overblown.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[101]`
Mówca: **Deivid Wisci**
> "“I completely agree. Lespia has for a long time benefited from us through our old tariffs. They are after exploitation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[102]`
**[WYBÓR GRACZA: "“Our values are too different with Lespia. It will be hard to see eye to eye.”"]** — Mówca: **Player**
> "“Our values are too different with Lespia. It will be hard to see eye to eye.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[103]`
Mówca: **Deivid Wisci**
> "“Everything comes at a cost. In Lespia the cost is wealth inequality but business people are getting richer and richer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[104]`
**[WYBÓR GRACZA: "“The Capitalism of Lespia is inspirational to me. Look at their economic power.”"]** — Mówca: **Player**
> "“The Capitalism of Lespia is inspirational to me. Look at their economic power.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[105]`
Mówca: **Lucian Galade**
> "“Their abrupt announcement about the closure of the Rumburg consulate in Lachaven is yet another step in their escalation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SharedSupport.Codex_History_ImportantEvents_AnnexationOfDome = true)*
- **Efekt (`userScript`):** `Variable["SharedSupport.Codex_History_ImportantEvents_AnnexationOfDome"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[107]`
Mówca: **Narrator**
> "Lucian grabbed the Lachaven Times newspaper and put his finger on the article about the latest diplomatic incident."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[108]`
Mówca: **Iosef Lancea**
> "“In fact, there had been a similar refugee situation in the past. Even Mr. President himself chose to disobey direct orders from his commanding officer at the time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
  - -> `[110]`
  - -> `[111]`
  - -> `[81]`

### Węzeł `[109]`
Mówca: **Narrator**
> "He was right, I did remember that winter. I remembered the despair in the refugees' eyes when we forcefully escorted them back to the Wehlen border."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "“Past is past. Let's move on.”"]** — Mówca: **Player**
> "“Past is past. Let's move on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[111]`
**[WYBÓR GRACZA: "“And you made me sleep in a prison cell for it. I will never forget that.”"]** — Mówca: **Player**
> "“And you made me sleep in a prison cell for it. I will never forget that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Narrator**
> "He opened his mouth to continue but Deivid cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[113]`
Mówca: **Iosef Lancea**
> "“That is the point of disciplinary action.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[114]`
Mówca: **Lucian Galade**
> "“Which creates a link between foreign policy and our internal affairs. These people have suffered socio-economically, which led them to crime and other problems.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[115]`
Mówca: **Lucian Galade**
> "“Economic stagnation is a worry for them. Their primary issue is their heavy reliance on foreign investment from us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[116]`
Mówca: **Deivid Wisci**
> "“It's also the most significant sea power in almost all of Merkopa. It is the only country that can rival the superpowers with their navy. We had hostile relations with them after several wars in the 19th century, which we wouldn't want to experience again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[117]`
Mówca: **Deivid Wisci**
> "“Despite purging the Wehzek communists, reports indicate that they have been warming up to Contanan international aid. As you know, Wehlen’s stability was always a concern for the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[118]`
**[WYBÓR GRACZA: "“We should maintain the existing agreement. We can't lose our advantage.”"]** — Mówca: **Player**
> "“We should maintain the existing agreement. We can't lose our advantage.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[119]`
Mówca: **Deivid Wisci**
> "“We could secure them as allies if we make concessions in a new agreement. Rumburg is our common threat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Military_Order_Accomplished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Military_Order_Accomplished == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Military_Order_Accomplished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Military_Order_Accomplished == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Military_Order_Accomplished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[123]`
Mówca: **Iosef Lancea**
> "“On top of that, territorial issues have been flaring up between Agnolia and Valgsland because of the Heljiland Island. The Sordish Navy is very concerned with this volatile situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[124]`
Mówca: **Deivid Wisci**
> "“Both sides could gain from it but Agnolia has more to win than us. They want to protect their weaker industries which we are profiting from selling our goods to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[125]`
Mówca: **Deivid Wisci**
> "“That would be the most pragmatic choice. Our export tariffs to Agnolia are incredibly low under the current agreement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[126]`
Mówca: **Deivid Wisci**
> "“Holding grudges about the past wouldn't be a logical strategy if we are focusing on pragmatic foreign policy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[127]`
Mówca: **Deivid Wisci**
> "“There would be many bargaining chips discussed, but Wehlen could be a new partner in the region. We would also invest in stability there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[128]`
Mówca: **Iosef Lancea**
> "“You should be. We have already witnessed several society shifting waves of migration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[129]`
Mówca: **Iosef Lancea**
> "“I would re-think the matter seriously because it has great influence on our society and values.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "“I'm sceptical about relaxed immigration.”"]** — Mówca: **Player**
> "“I'm sceptical about relaxed immigration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[131]`
**[WYBÓR GRACZA: "“I'm supportive of relaxed immigration.”"]** — Mówca: **Player**
> "“I'm supportive of relaxed immigration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[132]`
Mówca: **Deivid Wisci**
> "“And when we had our civil war, they were there for us. That is how refugee rights work internationally.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[133]`
**[WYBÓR GRACZA: "“Sordland paid enough by housing millions of refugees during the Wehlen Civil War. No more.”"]** — Mówca: **Player**
> "“Sordland paid enough by housing millions of refugees during the Wehlen Civil War. No more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[134]`
Mówca: **Deivid Wisci**
> "“It does pose many risks, but we could ensure that we have more influence in the region by increasing our trade and border security.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[135]`
**[WYBÓR GRACZA: "“We shouldn't take any sides between the regional powers.”"]** — Mówca: **Player**
> "“We shouldn't take any sides between the regional powers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[136]`
Mówca: **Deivid Wisci**
> "“I agree they could be potential allies in my opinion. The situation in the region necessitates that we find allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[137]`
**[WYBÓR GRACZA: "“The strait is of high strategic value to us.”"]** — Mówca: **Player**
> "“The strait is of high strategic value to us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[138]`
Mówca: **Deivid Wisci**
> "“It could lead us to be squeezed between the two with no protection. It's a potential situation to be considered.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[139]`
**[WYBÓR GRACZA: "“We can't expect the worst.”"]** — Mówca: **Player**
> "“We can't expect the worst.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Lucian Galade**
> "“Iosef, the Navy is keeping an eye on the situation from a distance, right?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[141]`
Mówca: **Lucian Galade**
> "“We should remember that we promised to tighten our immigration laws in the election campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SharedSupport.Codex_History_ImportantEvents_HeljiIslandInvasion = true)*
- **Efekt (`userScript`):** `Variable["SharedSupport.Codex_History_ImportantEvents_HeljiIslandInvasion"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SharedSupport.Codex_History_ImportantEvents_GreatFireOfConriat = true)*
- **Efekt (`userScript`):** `Variable["SharedSupport.Codex_History_ImportantEvents_GreatFireOfConriat"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[144]`
Mówca: **Lucian Galade**
> "“We should remember that we promised to keep our immigration laws relaxed in the election campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[145]`
Mówca: **Deivid Wisci**
> "“Agnolia is our most friendly neighbour. We have been allies for the longest time after Rumburg's actions in the region. This fact needs to be a part of the equation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[146]`
Mówca: **Iosef Lancea**
> "“One of the demands of President Smolak was to tighten our immigration laws, so the political refugees don't escape to Sordland. There has been a recent purge that pushed many Bludish to flee to Bergia. It is definitely troubling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Immigration_Relaxed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Immigration_Relaxed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Immigration_Relaxed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Immigration_Relaxed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Immigration_Relaxed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[150]`
Mówca: **Narrator**
> "He was right, I did remember that winter. I remembered how cold it was when I let the refugees slip through. I was discharged of my duties as a result, by Major Iosef Lancea, no less, spending the rest of my service cleaning toilets and sleeping in a cell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[151]`
Mówca: **Iosef Lancea**
> "“Gumren Outpost has regained its importance due to this. I'm sure you would remember that winter at the border outpost, Mr. President...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: LookAt("Sordland_Country_Agnolia");)*
- **Efekt (`userScript`):** `LookAt("Sordland_Country_Agnolia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: LookAtModeOff();

// Turns off look at mode)*
- **Efekt (`userScript`):** `LookAtModeOff();
-- Turns off look at mode;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: LookAt("Sordland_Country_Valgsland");)*
- **Efekt (`userScript`):** `LookAt("Sordland_Country_Valgsland");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: LookAt("Sordland_Country_Wehlen");)*
- **Efekt (`userScript`):** `LookAt("Sordland_Country_Wehlen");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: LookAt("Sordland_Country_Lespia");)*
- **Efekt (`userScript`):** `LookAt("Sordland_Country_Lespia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: LookAt("Sordland_Country_Rumburg");)*
- **Efekt (`userScript`):** `LookAt("Sordland_Country_Rumburg");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
