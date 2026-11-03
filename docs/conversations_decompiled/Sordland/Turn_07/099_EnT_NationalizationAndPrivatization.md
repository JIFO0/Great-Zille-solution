# Sordland/Turn07/EnT_NationalizationAndPrivatization

- **ID konwersacji:** `99`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/099_EnT_NationalizationAndPrivatization.md`
- **Liczba węzłów dialogowych:** 280
- **Liczba wyborów gracza:** 45

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[13]** Mikail Aven
- **[25]** Edith Agnoc
- **[38]** Lucian Galade
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.EconomicDirection_Nationalization`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGameIsolated.Turn07_EnT_BergiaSteel_Full`
- `BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority`
- `BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority`
- `BaseGameIsolated.Turn07_EnT_HOS_Full`
- `BaseGameIsolated.Turn07_EnT_HOS_Majority`
- `BaseGameIsolated.Turn07_EnT_HOS_Minority`
- `BaseGameIsolated.Turn07_EnT_Nedam_Full`
- `BaseGameIsolated.Turn07_EnT_Nedam_Majority`
- `BaseGameIsolated.Turn07_EnT_Nedam_Minority`
- `BaseGameIsolated.Turn07_EnT_SSC_Full`
- `BaseGameIsolated.Turn07_EnT_SSC_Majority`
- `BaseGameIsolated.Turn07_EnT_SSC_Minority`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn07_EnT_BergiaSteel_Full`
- `BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority`
- `BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority`
- `BaseGameIsolated.Turn07_EnT_HOS_Full`
- `BaseGameIsolated.Turn07_EnT_HOS_Majority`
- `BaseGameIsolated.Turn07_EnT_HOS_Minority`
- `BaseGameIsolated.Turn07_EnT_Nedam_Full`
- `BaseGameIsolated.Turn07_EnT_Nedam_Majority`
- `BaseGameIsolated.Turn07_EnT_Nedam_Minority`
- `BaseGameIsolated.Turn07_EnT_SSC_Full`
- `BaseGameIsolated.Turn07_EnT_SSC_Majority`
- `BaseGameIsolated.Turn07_EnT_SSC_Minority`
- `GameCondition.Turn07_EnT_Intro_NationalizationPrivatization`

### Skoki między-konwersacyjne:
- Węzeł `[3]` -> **[100] Sordland/Turn07/Privatization and Nationalization Feedback** (../Turn_07/100_Privatization_and_Nationalization_Feedback.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 13
- **Węzły modyfikujące stan gry:** 16

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[3]` (Symon Holl): `Variable["GameCondition.Turn07_EnT_Intro_NationalizationPrivatization"] = true;`
- Węzeł `[121]` (Symon Holl): `Variable["BaseGameIsolated.Turn07_EnT_HOS_Full"] = true;`
- Węzeł `[122]` (Symon Holl): `Variable["BaseGameIsolated.Turn07_EnT_HOS_Minority"] = true;`
- Węzeł `[123]` (Symon Holl): `Variable["BaseGameIsolated.Turn07_EnT_HOS_Majority"] = true;`
- Węzeł `[136]` (Symon Holl): `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Full"] = true;`
- Węzeł `[140]` (Symon Holl): `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority"] = true;`
- Węzeł `[152]` (Symon Holl): `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority"] = true;`
- Węzeł `[204]` (Symon Holl): `Variable["BaseGameIsolated.Turn07_EnT_SSC_Full"] = true;`
- *...oraz 8 innych węzłów ze skryptami.*

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
  - -> `[5]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Symon Holl)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: GameCondition.Turn07_EnT_Intro_NationalizationPrivatization = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn07_EnT_Intro_NationalizationPrivatization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `100` (*Sordland/Turn07/Privatization and Nationalization Feedback*), Węzeł `[1]`

### Węzeł `[4]`
Mówca: **Lucian Galade**
> "“Ms. Agnoc. Don't forget whom you are speaking with.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Lucian and I arrived at the Ministry of Economy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "“Exactly. I will not be swayed.”"]** — Mówca: **Player**
> "“Exactly. I will not be swayed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[7]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[9]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_Nationalization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[10]`
Mówca: **Narrator**
> "Assistants took our coats and showed us into the meeting room where Symon, Edith, Gus and Mikail were waiting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Narrator**
> "As soon as I entered, their chatter stopped and they stood up. After a few pleasantries, everyone but Symon took their seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Narrator**
> "He opened his briefcase, produced a folder and proceeded to go over some of the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Symon Holl**
> "“Greetings, everyone. Welcome to the Ministry of Economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Symon Holl**
> "“Without further ado...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[15]`
Mówca: **Symon Holl**
> "“We are here today to discuss our economic move towards nationalization.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
Mówca: **Symon Holl**
> "“We are of course here today to discuss our economic shift towards privatization.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Narrator**
> "Mikail and Edith exchanged smiles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[18]`
Mówca: **Narrator**
> "Both Mikail and Edith had their arms crossed and frowns on their faces. They were listening intently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[19]`
Mówca: **Symon Holl**
> "“Before you arrived, certain individuals in this room were voicing their opinion against a nationalization plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[20]`
Mówca: **Symon Holl**
> "“But as I understand it, your decision has already been made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[6]`
  - -> `[23]`

### Węzeł `[21]`
Mówca: **Symon Holl**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“Which 'certain individuals' were those?”"]** — Mówca: **Player**
> "“Which 'certain individuals' were those?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "“Yes. And you will respect my decision whether you like it or not.”"]** — Mówca: **Player**
> "“Yes. And you will respect my decision whether you like it or not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[24]`
Mówca: **Mikail Aven**
> "“Me and Edith's, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Edith Agnoc**
> "“I am very much against a nationalization plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[26]`
  - -> `[30]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "“Too bad. Your opinion doesn't matter.”"]** — Mówca: **Player**
> "“Too bad. Your opinion doesn't matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“And why is that?”"]** — Mówca: **Player**
> "“And why is that?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[28]`
Mówca: **Edith Agnoc**
> "“But--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Narrator**
> "One look from Symon stopped her. Both she and Mikail were restless in their seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "“This is for the good of our country.”"]** — Mówca: **Player**
> "“This is for the good of our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[31]`
Mówca: **Edith Agnoc**
> "“It's simple, really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Edith Agnoc**
> "“Nationalization could provide an improvement in terms of our economic development in the next year or two.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Edith Agnoc**
> "“But in the long term, you are losing people's trust. Without trust, there can be little trade. Especially if the government excessively nationalizes entire industries. Besides, it will cost us a proportional amount of government budget to nationalize.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[34]`
  - -> `[37]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“And you personally won't be able to profit. Isn't that right, Ms. Agnoc?”"]** — Mówca: **Player**
> "“And you personally won't be able to profit. Isn't that right, Ms. Agnoc?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Edith Agnoc**
> "“No. That is not my point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Are you saying that the state of Sordland is untrustworthy?”"]** — Mówca: **Player**
> "“Are you saying that the state of Sordland is untrustworthy?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“I've heard enough. You will accept my decision regardless.”"]** — Mówca: **Player**
> "“I've heard enough. You will accept my decision regardless.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Edith Agnoc**
> "“No. Of course it is trustworthy. That is not my point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[39]`
Mówca: **Edith Agnoc**
> "“But, I-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[40]`
Mówca: **Lucian Galade**
> "“Let's not get ahead of ourselves, shall we?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Lucian Galade**
> "“Mr. Holl. Please continue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[42]`
Mówca: **Edith Agnoc**
> "“I don't think so.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[43]`
Mówca: **Symon Holl**
> "“Let's move on to how we can go about implementing a nationalization plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Symon Holl**
> "“Thank you, Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[45]`
Mówca: **Symon Holl**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Narrator**
> "He handed me and everyone else in the room two neat stacks of documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Symon Holl**
> "“Please turn to page 14.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "Turn to page 14."]** — Mówca: **Player_Italic**
> "I turned to page 14. The title was: Heart of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Symon Holl**
> "“As you can see on the document, the first corporation up for discussion is Heart of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Symon Holl**
> "“Led by fledgling CEO Marcel Koronti, HOS has recently observed a boost in their revenue. They control many media organisations across Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Symon Holl**
> "“It is possible to see their imprint everywhere from newspaper stands to convenience stores. In fact, they own more than half of the media products in the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Symon Holl**
> "“We all know how much of an effect media has on politics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[53]`
Mówca: **Symon Holl**
> "“I must add that I myself am against fully nationalizing any of these companies in principle.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[54]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: HOS Nationalization Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[62]`
  - -> `[65]`
  - -> `[68]`

### Węzeł `[55]`
Mówca: **Symon Holl**
> "“That is the reason I think if we are to nationalize any corporation, HOS should be our target.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[56]`
Mówca: **Symon Holl**
> "“However, we could partially move the ownership of HOS to the state, gaining access to their income to help end the recession and provide for our citizens.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Lucian Galade**
> "“I am inclined to agree with you from a political perspective. However...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Lucian Galade**
> "“If we are going to nationalize HOS, I think we should go all the way and fully move its ownership to the state.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[59]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_HOS_Full == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_HOS_Full == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_HOS_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[61]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_EnT_HOS_Full == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_HOS_Full"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_HOS_Minority == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_HOS_Minority == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_HOS_Minority"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[64]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_EnT_HOS_Minority == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_HOS_Minority"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[65]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_HOS_Majority == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_HOS_Majority == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_HOS_Majority"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[67]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_EnT_HOS_Majority == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_HOS_Majority"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[68]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_HOS_Full == true || BaseGameIsolated.Turn07_EnT_HOS_Majority == true || BaseGameIsolated.Turn07_EnT_HOS_Minority == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_HOS_Full == true || BaseGameIsolated.Turn07_EnT_HOS_Majority == true || BaseGameIsolated.Turn07_EnT_HOS_Minority == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_HOS_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_HOS_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_HOS_Minority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[70]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_EnT_HOS_Full == true || BaseGameIsolated.Turn07_EnT_HOS_Majority == true || BaseGameIsolated.Turn07_EnT_HOS_Minority == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_HOS_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_HOS_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_HOS_Minority"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "“What would the effects be if we fully nationalize Heart of Sordland?”"]** — Mówca: **Player**
> "“What would the effects be if we fully nationalize Heart of Sordland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "“What if we just assume minority ownership of HOS?”"]** — Mówca: **Player**
> "“What if we just assume minority ownership of HOS?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "“What about a majority share?”"]** — Mówca: **Player**
> "“What about a majority share?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "“I already know what to do. Let's move on to our next option.”"]** — Mówca: **Player**
> "“I already know what to do. Let's move on to our next option.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Let's move on to our next option.”"]** — Mówca: **Player**
> "“Let's move on to our next option.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Symon Holl**
> "“Very well. Please turn to page 37.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "Turn to page 37."]** — Mówca: **Player_Italic**
> "I turned to page 37. The title was: Bergia Steel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[78]`
Mówca: **Edith Agnoc**
> "“They'd be disastrous, is what they would be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Edith Agnoc**
> "“Thousands of assets belonging to Marcel Koronti would now belong to the state. This would scare off many investors and most likely stop new money from coming in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Mikail Aven**
> "“I am against fully nationalizing any company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Mikail Aven**
> "“But if you insist on nationalizing something regardless, I would pick HOS.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "“Why is that?”"]** — Mówca: **Player**
> "“Why is that?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "“I will think about it.”"]** — Mówca: **Player**
> "“I will think about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[84]`
Mówca: **Mikail Aven**
> "“Marcel Koronti is growing too powerful too fast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Mikail Aven**
> "“The next thing you know, he could even have control over the state newspapers!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[86]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [HOS Nationalization Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[87]`
Mówca: **Lucian Galade**
> "“At first glance, a minority share might make sense. However, I don't think it's a good idea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Lucian Galade**
> "“It would only serve to make Koronti angry at the state while retaining enough power to damage us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Symon Holl**
> "“In the case of HOS, I do agree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[90]`
Mówca: **Symon Holl**
> "“I believe this is the way to go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Symon Holl**
> "“We would have board control over HOS and supplementary funds for government projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Lucian Galade**
> "“Theoretically. But we would still be making an enemy out of Marcel Koronti. He wouldn't be as powerful, of course, but I believe it's safer to move him off the chess board entirely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[93]`
Mówca: **Symon Holl**
> "“It's a win-win situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[94]`
Mówca: **Symon Holl**
> "“Bergia Steel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Symon Holl**
> "“It is the largest fully private corporation among the Big Four and a dominant force in steel manufacturing for many years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Symon Holl**
> "“It is led by current CEO and Lotherberg spokesman Walter Tusk. I believe all of us in the room are familiar with him in one way or another.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Symon Holl**
> "“What can I say? They have been widely successful since their founding. They have achieved renown not only in Sordland, but worldwide.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Symon Holl**
> "“I believe we shouldn't attempt to break something that is already working. I am against the nationalization of Bergia Steel in any capacity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Mikail Aven**
> "“Not to mention any amount of nationalization would be disastrous for both Bergia Steel and Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Mikail Aven**
> "“Much of our steel trade is reliant on their manufacturing capabilities. Any sudden change there would be like throwing a screwdriver in a working engine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Edith Agnoc**
> "“No matter what, we should refrain from nationalizing them. It could result in an economic crisis.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Lucian Galade**
> "“I don't have so strong of an opinion. But I will say that nationalizing both Bergia Steel and HOS would be quite unwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[103]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_BergiaSteel_Full == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_BergiaSteel_Full == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_EnT_BergiaSteel_Full == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Full"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[106]`
**[WYBÓR GRACZA: "“What would the effects be if we fully nationalize Bergia Steel?”"]** — Mówca: **Player**
> "“What would the effects be if we fully nationalize Bergia Steel?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[107]`
**[WYBÓR GRACZA: "“What are your thoughts on a minority share?”"]** — Mówca: **Player**
> "“What are your thoughts on a minority share?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[108]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[110]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[111]`
**[WYBÓR GRACZA: "“I have already decided on what we need to do.”"]** — Mówca: **Player**
> "“I have already decided on what we need to do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[112]`
**[WYBÓR GRACZA: "“What would be the outcome of taking a majority share?”"]** — Mówca: **Player**
> "“What would be the outcome of taking a majority share?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[113]`
**[WYBÓR GRACZA: "“I am ready to make a decision.”"]** — Mówca: **Player**
> "“I am ready to make a decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[114]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[116]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[117]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_BergiaSteel_Full == true || BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority == true || BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_BergiaSteel_Full == true || BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority == true || BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[119]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_EnT_BergiaSteel_Full == true || BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority == true || BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[120]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Bergia Steel Nationalization Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[108]`
  - -> `[114]`
  - -> `[117]`

### Węzeł `[121]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_HOS_Full = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_HOS_Full"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[122]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_HOS_Minority = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_HOS_Minority"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[123]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_HOS_Majority = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_HOS_Majority"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[124]`
Mówca: **Mikail Aven**
> "“Where do I start?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Mikail Aven**
> "“They are quite literally the backbone of Sordland's private economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Mikail Aven**
> "“If you do this, you will anger many powerful people. Trust me, you don't want that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[129]`
  - -> `[127]`
  - -> `[130]`

### Węzeł `[127]`
**[WYBÓR GRACZA: "“Is that a threat, Mikail?”"]** — Mówca: **Player**
> "“Is that a threat, Mikail?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Mikail Aven**
> "“No, Mr. President. It's a fact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[129]`
**[WYBÓR GRACZA: "“I understand the predicament, but it is necessary.”"]** — Mówca: **Player**
> "“I understand the predicament, but it is necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "“Let them come. I am not afraid.”"]** — Mówca: **Player**
> "“Let them come. I am not afraid.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
**[WYBÓR GRACZA: "“You are right. I don't want more enemies.”"]** — Mówca: **Player**
> "“You are right. I don't want more enemies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[132]`
Mówca: **Edith Agnoc**
> "“I think you should be.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[133]`
Mówca: **Edith Agnoc**
> "“I don't see how this is *necessary*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Edith Agnoc**
> "“You can simply not do it and you will achieve peace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Edith Agnoc**
> "“I knew you would see reason.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_BergiaSteel_Full = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Full"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[137]`
Mówca: **Symon Holl**
> "“As I mentioned, I am against making changes to Bergia Steel's ownership.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Symon Holl**
> "“We should leave the company as it is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Lucian Galade**
> "“I tend to agree. But only because HOS is the weaker of the two and it is less risky to deal with them as opposed to a giant like Bergia Steel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[141]`
Mówca: **Symon Holl**
> "“This is of course a better option than full nationalization. But that doesn't mean you would not face adversity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Symon Holl**
> "“A majority share means Bergia Steel would experience a massive drop in status.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Symon Holl**
> "“This would surely anger a man like Walter Tusk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Symon Holl**
> "“And if I may make an understatement, he is not a forgiving man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[145]`
  - -> `[148]`

### Węzeł `[145]`
**[WYBÓR GRACZA: "“No need to be afraid. If push comes to shove, I will handle it.”"]** — Mówca: **Player**
> "“No need to be afraid. If push comes to shove, I will handle it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[146]`
**[WYBÓR GRACZA: "“He is scary for sure. I would hate to make an enemy out of him.”"]** — Mówca: **Player**
> "“He is scary for sure. I would hate to make an enemy out of him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[147]`
Mówca: **Symon Holl**
> "“It's the administration I'm worried about. Not only you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[148]`
**[WYBÓR GRACZA: "“If that day comes, Walter Tusk will learn Anton Rayne is *also* not a forgiving man.”"]** — Mówca: **Player**
> "“If that day comes, Walter Tusk will learn Anton Rayne is *also* not a forgiving man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Lucian Galade**
> "“As you say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[150]`
Mówca: **Lucian Galade**
> "“He seems to hold everyone in his pocket.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Narrator**
> "Lucian looked pointedly at Mikail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [Bergia Steel Nationalization Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[154]`
Mówca: **Symon Holl**
> "“Sounds good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Symon Holl**
> "“Let's go over the document once again then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Narrator**
> "I read all of Symon's documents once more, then flipped to the last page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Narrator**
> "It was time to make some decisions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[158]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[161]`
Mówca: **Symon Holl**
> "“Especially since we were initially going down the path of a market economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[162]`
Mówca: **Symon Holl**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Symon Holl**
> "“Before you arrived, Mikail and Edith were expressing their delight at your decision to go down this path.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Mikail Aven**
> "“Wonderful news, I'd say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Edith Agnoc**
> "“This was certainly the right decision. It will boost our economy by providing the government much-needed funds right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[166]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Mikail Aven**
> "“I'm glad we're staying firmly on the path to a market economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[170]`
Mówca: **Mikail Aven**
> "“I know a market economy wasn't part of your original plans, but I'm happy you've seen the light.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[171]`
Mówca: **Edith Agnoc**
> "“We can then use these funds to increase development for the future. It's a win-win situation for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[172]`
  - -> `[175]`

### Węzeł `[172]`
**[WYBÓR GRACZA: "“You are saying this only because you will have a stake in it.”"]** — Mówca: **Player**
> "“You are saying this only because you will have a stake in it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[173]`
**[WYBÓR GRACZA: "“I am glad we are on the same page.”"]** — Mówca: **Player**
> "“I am glad we are on the same page.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Edith Agnoc**
> "“Certainly!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[175]`
**[WYBÓR GRACZA: "“Enough with the flattery.”"]** — Mówca: **Player**
> "“Enough with the flattery.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[176]`
Mówca: **Edith Agnoc**
> "“Of course not! I am saying this because all along I knew you would make the right choice for Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Edith Agnoc**
> "“It's because I trusted you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[178]`
Mówca: **Edith Agnoc**
> "“I have to give credit when it's due.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Symon Holl**
> "“Let's move on to how we can go about implementing a privatization plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Narrator**
> "Symon handed me and everyone else in the room two neat stacks of documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[181]`
Mówca: **Symon Holl**
> "“Please turn to page 6.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
**[WYBÓR GRACZA: "Turn to page 6."]** — Mówca: **Player_Italic**
> "I turned to page 6. The title was: Sordish State Corporation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Symon Holl**
> "“As you can see on the document, the first company up for discussion is the Sordish State Corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Symon Holl**
> "“The Sordish State Corporation, or SSC for short, has been around for over half a century. Most recently they have been handling a wide range of state construction projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Symon Holl**
> "“In their portfolio they have government buildings, various infrastructure projects, state libraries, embassies. Basically anything government-related.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Symon Holl**
> "“Privatizing a company like this would certainly increase the government's budget. That, of course, would result in lots of opportunities for us to provide for our citizens.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Lucian Galade**
> "“The funds could also be used to boost our popularity. Especially with the elections approaching.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Lucian Galade**
> "“Not to mention the various other areas in which we can and should spend money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Lucian Galade**
> "“However, there is one catch.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Lucian Galade**
> "“The conservative majority of the USP would not like this decision. At all. For them, these state companies are part and parcel of Sordish identity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Lucian Galade**
> "“If we privatize these companies entirely and sell too many shares in them, it will have consequences for us in the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[192]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_SSC_Full == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_SSC_Full == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_SSC_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[194]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_EnT_SSC_Full == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_SSC_Full"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[195]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [SSC Privatization Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[196]`
**[WYBÓR GRACZA: "“What would the effects be if we fully privatize the Sordish State Corporation?”"]** — Mówca: **Player**
> "“What would the effects be if we fully privatize the Sordish State Corporation?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[197]`
**[WYBÓR GRACZA: "“What if we sell a minority share of SSC?”"]** — Mówca: **Player**
> "“What if we sell a minority share of SSC?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[198]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_SSC_Full == true || BaseGameIsolated.Turn07_EnT_SSC_Majority == true || BaseGameIsolated.Turn07_EnT_SSC_Minority == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_SSC_Full == true || BaseGameIsolated.Turn07_EnT_SSC_Majority == true || BaseGameIsolated.Turn07_EnT_SSC_Minority == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_SSC_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_SSC_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_SSC_Minority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[200]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_EnT_SSC_Full == true || BaseGameIsolated.Turn07_EnT_SSC_Majority == true || BaseGameIsolated.Turn07_EnT_SSC_Minority == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_SSC_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_SSC_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_SSC_Minority"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[201]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_SSC_Minority == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_SSC_Minority == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_SSC_Minority"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[203]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_EnT_SSC_Minority == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_SSC_Minority"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[204]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_SSC_Full = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_SSC_Full"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[205]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_SSC_Majority = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_SSC_Majority"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[206]`
**[WYBÓR GRACZA: "Turn to page 26."]** — Mówca: **Player_Italic**
> "I turned to page 26. The title was: Nedam Mining Group."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[207]`
Mówca: **Symon Holl**
> "“Very well. Please turn to page 26.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[208]`
**[WYBÓR GRACZA: "“What about selling a majority share?”"]** — Mówca: **Player**
> "“What about selling a majority share?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[209]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_SSC_Majority == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_SSC_Majority == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_SSC_Majority"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[211]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_EnT_SSC_Majority == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_SSC_Majority"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[212]`
**[WYBÓR GRACZA: "“I already know what to do. Let's move on to the next option.”"]** — Mówca: **Player**
> "“I already know what to do. Let's move on to the next option.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[213]`
**[WYBÓR GRACZA: "“Let's move on to the next option.”"]** — Mówca: **Player**
> "“Let's move on to the next option.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[214]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_SSC_Minority = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_SSC_Minority"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[215]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: SSC Privatization Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[201]`
  - -> `[209]`
  - -> `[198]`

### Węzeł `[216]`
Mówca: **Symon Holl**
> "“We would gain tremendous amounts of money for the government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Symon Holl**
> "“We can invest that money in future government projects which would popularise our administration, increasing the chances for our re-election.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Lucian Galade**
> "“That popularity might not make up for losing the lion's share of the conservative vote.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Lucian Galade**
> "“Conservatives comprise the majority of the Assembly. If we hurt their national pride, they'll turn on us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Lucian Galade**
> "“I am against full privatization. We shouldn't make enemies at this stage.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[221]`
Mówca: **Edith Agnoc**
> "“It would be better than nothing, but why stop there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[222]`
Mówca: **Edith Agnoc**
> "“A minority stake won't help our government as much.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Edith Agnoc**
> "“We need to be decisive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Lucian Galade**
> "“On the other hand, a minority share would create less friction. This would be my preference.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[225]`
Mówca: **Mikail Aven**
> "“This is certainly a very good option.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Mikail Aven**
> "“The state would keep some of SSC's operations under control, and the government would have lots of gains.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Symon Holl**
> "“I am leaning towards this option myself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Symon Holl**
> "“Retaining control while increasing our budget -- I don't see a downside.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[229]`
Mówca: **Symon Holl**
> "“Nedam Mining Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Symon Holl**
> "“It is one of the largest mining corporations in Eastern Merkopa, let alone Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Symon Holl**
> "“They call themselves the leaders of the world in coal. They certainly have enough evidence to back that up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Symon Holl**
> "“Perhaps they are not as large as SSC, but we still have a lot to gain if Nedam Mining Group is privatised.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Symon Holl**
> "“I fully support privatization of this company to any extent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[234]`
Mówca: **Symon Holl**
> "“Certainly a good option to gain enough capital to end the recession once and for all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Edith Agnoc**
> "“I have contacts in Nedam. It is one of the most valuable corporations of the last decade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Mikail Aven**
> "“I can vouch for that. I have personal experience with the company myself. It would be a great addition to any portfolio.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[237]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_Nedam_Full == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_Nedam_Full == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_EnT_Nedam_Full == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_Nedam_Full"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[240]`
**[WYBÓR GRACZA: "“What would the effects be if we fully privatize Nedam Mining Group?”"]** — Mówca: **Player**
> "“What would the effects be if we fully privatize Nedam Mining Group?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[241]`
**[WYBÓR GRACZA: "“What are your thoughts on selling a minority share?”"]** — Mówca: **Player**
> "“What are your thoughts on selling a minority share?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[242]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_Nedam_Minority == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_Nedam_Minority == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Minority"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[244]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_EnT_Nedam_Minority == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_Nedam_Minority"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[245]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [Nedam Privatization Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[246]`
Mówca: **Symon Holl**
> "“Sounds good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[247]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_Nedam_Majority = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Majority"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[248]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_Nedam_Full = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Full"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[249]`
**[WYBÓR GRACZA: "“What about selling a majority share?”"]** — Mówca: **Player**
> "“What about selling a majority share?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[250]`
**[WYBÓR GRACZA: "“I am ready to make a decision.”"]** — Mówca: **Player**
> "“I am ready to make a decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[251]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_Nedam_Majority == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_Nedam_Majority == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Majority"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[253]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_EnT_Nedam_Majority == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_Nedam_Majority"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[254]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_Nedam_Full == true || BaseGameIsolated.Turn07_EnT_Nedam_Majority == true || BaseGameIsolated.Turn07_EnT_Nedam_Minority == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_Nedam_Full == true || BaseGameIsolated.Turn07_EnT_Nedam_Majority == true || BaseGameIsolated.Turn07_EnT_Nedam_Minority == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_Nedam_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_Nedam_Minority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[256]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_EnT_Nedam_Full == true || BaseGameIsolated.Turn07_EnT_Nedam_Majority == true || BaseGameIsolated.Turn07_EnT_Nedam_Minority == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_Nedam_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_Nedam_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_Nedam_Minority"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
**[WYBÓR GRACZA: "“I have already decided what we need to do.”"]** — Mówca: **Player**
> "“I have already decided what we need to do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[258]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Nedam Privatization Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[242]`
  - -> `[251]`
  - -> `[254]`

### Węzeł `[259]`
Mówca: **Symon Holl**
> "“Let's go over the document once again then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[260]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_EnT_Nedam_Minority = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Minority"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[261]`
Mówca: **Mikail Aven**
> "“It would be a very profitable sell.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Edith Agnoc**
> "“I know many people who would kill to have a portion of that company.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[263]`
Mówca: **Symon Holl**
> "“I do think this is a good option.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Symon Holl**
> "“We could simply fully privatize Nedam along with SSC to bring in a large influx of money to the government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[265]`
Mówca: **Lucian Galade**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
Mówca: **Lucian Galade**
> "“I hate to repeat myself, but fully privatizing one state-owned company -- let alone two -- will anger our conservative voter base.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Lucian Galade**
> "“All the budget in the world won't matter if you aren't re-elected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[268]`
Mówca: **Lucian Galade**
> "“Coupled with a minority share of SSC, that is the way to go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Symon Holl**
> "“It would, however, be a lost opportunity. I think we should sell a majority share instead.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[270]`
Mówca: **Edith Agnoc**
> "“Definitely not a bad idea at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[271]`
Mówca: **Symon Holl**
> "“My preference is selling a majority share of both SSC and Nedam.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Symon Holl**
> "“It would give us the most value. I think we should go with this choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Lucian Galade**
> "“This might still generate a backlash from the Assembly and the general public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Lucian Galade**
> "“We should go for a minority share instead.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[275]`
Mówca: **Narrator**
> "I read all of Symon's documents once more, then flipped to the last page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[276]`
Mówca: **Narrator**
> "It was time to make some decisions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: ShowPagedDecisionsPanel("Panel_Privatization");

// Shows Paged Decisions Panel with the name in database)*
- **Efekt (`userScript`):** `ShowPagedDecisionsPanel("Panel_Privatization");
-- Shows Paged Decisions Panel with the name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[278]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: ShowPagedDecisionsPanel("Panel_Nationalization");

// Shows Paged Decisions Panel with the name in database)*
- **Efekt (`userScript`):** `ShowPagedDecisionsPanel("Panel_Nationalization");
-- Shows Paged Decisions Panel with the name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[279]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
