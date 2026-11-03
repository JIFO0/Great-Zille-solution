# Sordland/Turn03/PSnW_Overview

- **ID konwersacji:** `28`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/028_PSnW_Overview.md`
- **Liczba węzłów dialogowych:** 345
- **Liczba wyborów gracza:** 78

---

## 1. Uczestnicy Sceny

- **[2]** Paskal Beniwoll
- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[40]** Ciara Walda

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn02_EconomicRelief_BailedPeople`
- `BaseGame.Decision_Turn02_StatusReaction_BoostPolice`
- `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors`
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Prologue_Birthplace_Holsord_Middle`
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGame.Prologue_University_Political_Socialist`
- `BaseGame.Promise_TermFocus_Education`
- `BaseGame.Promise_TermFocus_Health`
- `BaseGame.Reform_Autocrat_Abandon`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan`
- `BaseGameIsolated.Turn03_PSnW_Listened_Education`
- `BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy`
- `BaseGameIsolated.Turn03_PSnW_Listened_Education_Students`
- `BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural`
- `BaseGameIsolated.Turn03_PSnW_Listened_Health`
- `BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds`
- `BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses`
- `BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality`
- `BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan`
- `BaseGameIsolated.Turn03_PSnW_Listened_Education`
- `BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy`
- `BaseGameIsolated.Turn03_PSnW_Listened_Education_Students`
- `BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural`
- `BaseGameIsolated.Turn03_PSnW_Listened_Health`
- `BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds`
- `BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses`
- `BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality`
- `BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan`
- `BaseGameSupport.CountryReport_Turn03_Lespia_ArcasianMilitaryBase`
- `BaseGameSupport.FactionReport_Turn03_CSP_SummitForHelji`
- `BaseGameSupport.News_Turn03_HP_EPA_RepealFails`
- `BaseGameSupport.News_Turn03_R_Protest_CalledProtestersTraitors`
- `BaseGameSupport.News_Turn03_R_Protest_ExpandedPolice`
- `BaseGameSupport.Report_Turn03_Estord_YSFoundDead`
- `BaseGameSupport.Report_Turn03_Holsord_EPARepealFails`
- `BaseGameSupport.Report_Turn03_Holsord_NFPReport`
- `BaseGameSupport.Report_Turn03_Holsord_WorkersRightsPrep`
- `BaseGameSupport.Report_Turn03_Morbel_MineDisaster`
- `BaseGameSupport.Report_Turn03_Narbel_CPSLUSOrganize`
- `BaseGameSupport.Report_Turn03_Narbel_LaborStrike`
- `BaseGameSupport.Report_Turn03_Valgen_CalledProtestersTraitors`
- `GameCondition.Turn03_A_LateBriefing`
- `GameCondition.Turn03_Decision_StabilityOrder`
- `GameCondition.Turn03_PSnW_Overview`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 17
- **Węzły modyfikujące stan gry:** 18

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[13]` (Ciara Walda): `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education"] = true;`
- Węzeł `[52]` (Ciara Walda): `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses"] = true;`
- Węzeł `[62]` (Ciara Walda): `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds"] = true;`
- Węzeł `[68]` (Ciara Walda): `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality"] = true;`
- Węzeł `[72]` (Ciara Walda): `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Students"] = true;`
- Węzeł `[78]` (Ciara Walda): `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy"] = true;`
- Węzeł `[82]` (Ciara Walda): `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural"] = true;`
- Węzeł `[83]` (Ciara Walda): `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health"] = true;`
- *...oraz 10 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Ciara Walda)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
> "“Such a spectacular view.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Ciara Walda, the Minister of Education, joined us on the balcony, dressed in a sky-blue pantsuit. Her preference for trousers over dresses had made her the subject of much Palace gossip, but it didn't seem to bother her in the slightest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[5]`
Mówca: **Narrator**
> "While I was mesmerized by the scenery, Paskal Beniwoll walked up to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[6]`
Mówca: **Ciara Walda**
> "“Hopelessness and a lack of opportunities can drive people to extreme solutions. We're seeing increased crime, domestic violence, and yes, rising inequality between men and women...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`
  - -> `[120]`
  - -> `[180]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
> "“There is another subject I want to mention. I have been working on improving the rights of workers in our country and have proposed a draft bill that is currently being reviewed by our party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[8]`
Mówca: **Narrator**
> "We headed back inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Narrator**
> "The meeting room was already prepared for state business. Small gifts for each of us had been placed on the table by the municipality. We took our seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`
  - -> `[343]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "“Let's start with your health overview, Paskal.”"]** — Mówca: **Player**
> "“Let's start with your health overview, Paskal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "“Tell me more about your plans, Ciara.”"]** — Mówca: **Player**
> "“Tell me more about your plans, Ciara.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[12]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: Jump to: [Paskal Beniwoll: "“As you wish, Mr. President.”"])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[13]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Education = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[14]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: Healthcare Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[22]`
  - -> `[25]`
  - -> `[58]`

### Węzeł `[15]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: Education Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[30]`
  - -> `[34]`
  - -> `[55]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“How many doctors and nurses are employed?”"]** — Mówca: **Player**
> "“How many doctors and nurses are employed?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "“How many hospital beds are there per ten thousand citizens?”"]** — Mówca: **Player**
> "“How many hospital beds are there per ten thousand citizens?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“What's the life expectancy and mortality rates?”"]** — Mówca: **Player**
> "“What's the life expectancy and mortality rates?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[19]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[21]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[22]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[24]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[25]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[27]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[28]`
**[WYBÓR GRACZA: "“Tell me about the difference between urban and rural education.”"]** — Mówca: **Player**
> "“Tell me about the difference between urban and rural education.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "“What is the literacy rate of Sordland?”"]** — Mówca: **Player**
> "“What is the literacy rate of Sordland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[30]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[32]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[33]`
**[WYBÓR GRACZA: "“How many students and teachers do we have?”"]** — Mówca: **Player**
> "“How many students and teachers do we have?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[34]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[36]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Education_Students == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Education_Students == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Students"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[39]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_PSnW_Listened_Education_Students == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Students"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
> "“We have 31,594 doctors and 73,680 nurses working for the Ministry of Health. This is a high number. What I think is--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
> "“There are ten beds per ten thousand citizens. Compared to most of our neighbors, this is a very good number.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
> "“Our life expectancy is 65 years. The infant mortality rate is a worrying 121 per one thousand births, while our maternal mortality is at 5 per thousand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[43]`
Mówca: **Ciara Walda**
> "“Currently there are about five million students. Three million in primary education, one million in secondary and one million in tertiary. There are 155,316 teachers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[44]`
Mówca: **Ciara Walda**
> "“The literacy rate of Sordland is at eighty percent. This is a very good indicator for future growth, but it needs to increase. It's also far lower among girls than boys.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[45]`
Mówca: **Ciara Walda**
> "“Urban areas have three times the number of schools per ten thousand people compared to rural areas. Rural areas also suffer from a lack of teachers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
> "“I am doing my best to ensure that citizens of all ages receive the best healthcare they can. I also personally want to solve our high infant and maternal mortality problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[47]`
Mówca: **Ciara Walda**
> "“I don't want to be rude, but out of those numbers. how many are in urban and in rural areas?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Good point, Ciara. Paskal?”"]** — Mówca: **Player**
> "“Good point, Ciara. Paskal?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "“Let's not interrupt each other.”"]** — Mówca: **Player**
> "“Let's not interrupt each other, please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
> "“That's not a problem. The number of doctors per ten thousand citizens is far lower in rural areas compared to urban areas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
> "“The data shows that per ten thousand people in urban areas there are about eleven doctors, while in rural areas there are only three.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[52]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: Jump to: [Healthcare Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "“I want to hear about the healthcare system.”"]** — Mówca: **Player**
> "“I want to hear about the healthcare system.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[55]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Education_Students == true || BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy == true || BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Education_Students == true || BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy == true || BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Students"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[57]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_PSnW_Listened_Education_Students == true || BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy == true || BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Students"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[58]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses == true || BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds == true || BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses == true || BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds == true || BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[60]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses == true || BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds == true || BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
> "“Our amount of beds is higher than the countries of Agnolia and Wehlen, but we obviously can't match Lespia or Valgsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[62]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
> "“I assure you that we are doing everything we can to save mothers and their newborns.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“I expect nothing but your best efforts to improve the situation.”"]** — Mówca: **Player**
> "“I expect nothing but your best efforts to improve the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[65]`
Mówca: **Ciara Walda**
> "“Those numbers are saddening indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[64]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“I agree. We must do everything we can.”"]** — Mówca: **Player**
> "“I agree. We must do everything we can.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
> "“We are working very hard on improving the quality of the services.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[69]`
Mówca: **Narrator**
> "Ciara stood up and moved towards the window. She took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[70]`
Mówca: **Ciara Walda**
> "“My highest priority is to get enough funding to be able to build schools in rural areas while I cleanse our educational system of its nationalistic indoctrination and sexist teachings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[71]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: Jump to: [Education Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[72]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Education_Students = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Students"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
> "“Sordland is full of young and bright minds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "“We should keep striving to make education available for all.”"]** — Mówca: **Player**
> "“We should keep striving to make education available for all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Our country is indeed full of potential.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
> "“If I remember correctly, the most illiterate areas are Bergia and Agnland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Ciara Walda**
> "“That is correct. Although Lachaven skews the statistics for the Nargis region, which also has a vast number of illiterate citizens. This underlines my point about the lack of access to education.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "“I can imagine teachers not preferring desolate areas.”"]** — Mówca: **Player**
> "“I can imagine teachers not preferring desolate areas for work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "“That's not a very good ratio.”"]** — Mówca: **Player**
> "“That's not a very good ratio. The situation is worse than expected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Ciara Walda**
> "“This is one of the most important problems we face, if not the most important. A huge part of the population is forgotten in terms of welfare.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[83]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Health = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "“I want to hear about the education system.”"]** — Mówca: **Player**
> "“I want to hear about the education system.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: Jump to: [Ciara Walda: "“With pleasure.”"])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[86]`
**[WYBÓR GRACZA: "“What is it, Ciara?”"]** — Mówca: **Player**
> "“What is it, Ciara?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "“I hope both of you are preparing your reform plans for improvement.”"]** — Mówca: **Player**
> "“I hope both of you are preparing your reform plans for improvement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Ciara Walda**
> "“Look at this impoverished city. The streets full of potholes, the hospital barely functioning, the school half open.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Narrator**
> "She ignored my statement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[90]`
Mówca: **Ciara Walda**
> "“This is not just about Soll or even Alphonso failing. This decay in Sordland's forgotten regions has been going on for many decades due to structural corruption, which is fueled by capitalism.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[183]`
  - -> `[92]`
  - -> `[91]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "“Paskal, what do you think?”"]** — Mówca: **Player**
> "“Paskal, what do you think?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "“We are here to change that trend and to provide for the people.”"]** — Mówca: **Player**
> "“We are here to change that trend and to provide for the people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "“Tarquin Soll did more for the country than any of us.”"]** — Mówca: **Player**
> "“Tarquin Soll did more for the country than any of us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
> "“There is not much to be said, sir. I agree with Ciara, but it is also Gus Manger's job to improve these areas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Ciara Walda**
> "“It's the responsibility of each and every one of us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[96]`
Mówca: **Ciara Walda**
> "“That remains to be seen. I'm working on the new education system, and your support would be welcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[97]`
Mówca: **Ciara Walda**
> "“Really? I must agree to disagree then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[98]`
Mówca: **Ciara Walda**
> "“Did we cover all the necessary subjects?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[99]`
Mówca: **Ciara Walda**
> "“I do hope we won't repeat the same mistakes again and again. Have a good day, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Narrator**
> "The ministers left, and I prepared to leave for other official business in the city. The Gasom meeting was just one of the many events I was scheduled to attend over the next few days."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[101]`
Mówca: **Narrator**
> "By looking at the citizens’ attire, it was easy to understand the current state of Narbel. Some people were wearing clothes a few sizes too large. Some kids did not even have shoes. Yet there was hope in their eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[102]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_PSnW_Overview = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_PSnW_Overview"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[103]`
Mówca: **Ciara Walda**
> "“My plans require an increase in the government budget. I aim to solve the problems we highlighted with the allocated money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Ciara Walda**
> "“By building schools in these less fortunate rural areas and through fundamental changes to the education system, I will unlock the potential of all our children. Boys and girls alike.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[214]`
  - -> `[105]`

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Interesting. I thought our problem was with the quality of education in Sordland as a whole.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[106]`
**[WYBÓR GRACZA: "“Improving the situation in rural areas is indeed a good idea.”"]** — Mówca: **Player**
> "“Improving the situation in rural areas is indeed a good idea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Ciara Walda**
> "“It's an investment in the future of Sordland. Imagine unlocking the full, untapped potential of our youth. The knowledge and wealth they will generate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Ciara Walda**
> "“Our statistics show the disparity between urban and rural education. We can either do something about it, or wait until things get worse.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
> "“Wouldn't a promotion of private education help create additional funds?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Ciara Walda**
> "“Yes, but at what cost? I'm not a supporter of the private sector in education. At the end of the day, they are focused on profit first.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[111]`
**[WYBÓR GRACZA: "“What are you working towards, Paskal?”"]** — Mówca: **Player**
> "“What are you working towards, Paskal?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
> "“I personally want to improve the low quality of healthcare in the rural areas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
> "“I can do more with an increased budget. Additionally, a privatization plan to promote private investments in the healthcare system could allocate extra funds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Isn't access to healthcare in rural areas an issue?”"]** — Mówca: **Player**
> "“Isn't access to healthcare in rural areas an issue?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Improving the quality of healthcare in less fortunate areas should be our highest priority.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
> "“Access is an issue, but not as critical as improving the quality in these areas. The lack of experienced personnel and equipment causes poor treatment, resulting in many deaths.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
> "“Exactly. It would directly diminish our depressingly high infant and maternal mortality situation. Besides, such a push would also have economic benefits.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[118]`
**[WYBÓR GRACZA: "“Lileas Graf will take care of crime. She's an expert on the subject.""]** — Mówca: **Player**
> "“Lileas Graf will take care of crime. She's an expert on the subject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[119]`
**[WYBÓR GRACZA: "“Those issues must be tackled from different directions. We need to engage it holistically.”"]** — Mówca: **Player**
> "“Those issues must be tackled from different directions. We need to engage it holistically.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "“If only we could stop the recession, create jobs and growth...”"]** — Mówca: **Player**
> "“If only we could stop the recession, create jobs and growth...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
> "“I'm planning to help by using an increased budget to improve the quality of healthcare.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
> "“She is certainly a proven administrator. From what I heard she reduced crime in Arvory by 40% during her mayoral term.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
> "“The economic situation does play a huge role in living standards. Our urban and rural disparities are stark, and the recession hit the weakest harder.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[124]`
Mówca: **Ciara Walda**
> "“I don't think brute force will get us anywhere. Look at where the tight grip of Tarquin Soll got us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[125]`
Mówca: **Ciara Walda**
> ""That could prove useful, but we need to be doing a lot more. Education has similar issues.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[126]`
Mówca: **Ciara Walda**
> "“We can't fix the economy by ourselves. We have to educate the people and let them create new opportunities too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[127]`
Mówca: **Ciara Walda**
> "“Agnolia and Wehlen should hardly be used as a standard, but it is good to know we aren't in a massive health crisis. Yet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[128]`
Mówca: **Ciara Walda**
> "“I think there needs to be a change in what is being taught. We should help children to ask questions and educate themselves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[129]`
Mówca: **Narrator**
> "Ciara sat back down and sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Ciara Walda**
> "“One way or another, we need change in Sordland. Greed and unchecked capitalism will not magically provide for the people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[131]`
**[WYBÓR GRACZA: "“Tell me more about your plans, Ciara.”"]** — Mówca: **Player**
> "“Tell me more about your plans, Ciara.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[132]`
Mówca: **Ciara Walda**
> "“My expectation from our government is that we understand and focus on the needs of the people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[192]`
  - -> `[193]`
  - -> `[238]`

### Węzeł `[133]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[135]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[136]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[138]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[139]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[140]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: Plans Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[143]`
  - -> `[136]`

### Węzeł `[142]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: Jump to: [Plans Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[143]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan == true && BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan == true && BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan"] == true  and  Variable["BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[145]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan == true && BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan"] == true  and  Variable["BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[146]`
Mówca: **Ciara Walda**
> "“With pleasure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Ciara Walda**
> "“Sordish education is free, but we have a very outdated system that I want to reform. The other important issue is the lack of access to education in rural areas, especially for young girls. Your administration has the power to solve both problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
> "“Sordland has a free healthcare system, except for a few private hospitals operating under it. Most of the populace receives adequate treatment. Health issues primarily appear in rural areas due to a lack of quality services.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
> "“As you wish, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
> "“I do hope to create competition and increase the quality of healthcare with the privatization effort.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Ciara Walda**
> "“But you must realize that privatizing our health care system would increase the price of treatment and make access worse for the average citizen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[152]`
Mówca: **Ciara Walda**
> "“Salaries for teachers are very low here. We need to increase their pay to give them more incentive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
> "“So, I created draft plans to increase the salary of doctors and to upgrade the equipment of the hospitals.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[154]`
Mówca: **Ciara Walda**
> "“I am glad we see eye to eye on the issue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[155]`
**[WYBÓR GRACZA: "“My intention is to help the working class.”"]** — Mówca: **Player**
> "“My intention is to help the working class.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[156]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Deyr_Poor == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
> "“Well put, Ms. Walda. I don't need to tell you about my own experiences with poverty. And you've been through similar hardships yourself, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[176]`

### Węzeł `[160]`
Mówca: **Ciara Walda**
> "“If you look past the view, you can see the real problems.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
> "“Well put, Ms. Walda. I don't need to tell you about my own experiences with poverty. I'm sure you have similar stories, am I right, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[162]`
  - -> `[165]`

### Węzeł `[162]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Holsord_Middle == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Holsord_Middle == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[164]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Holsord_Middle == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[165]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[167]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Lachaven_Rich == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[168]`
**[WYBÓR GRACZA: "“We knew less fortunate families, even though we belonged to the middle class ourselves.”"]** — Mówca: **Player**
> "“We knew less fortunate families, even though we belonged to the middle class ourselves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[169]`
**[WYBÓR GRACZA: ""Thankfully, we never had any problems with money.”"]** — Mówca: **Player**
> "“Thankfully, we never had any problems with money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
> "“So, you could at least sympathize with the plight of these people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Ciara Walda**
> "“You don't have to have been born poor to sympathize with the plight of the impoverished. Much as you don't have to have been born a woman to recognize Sordland's need for parity among the sexes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
> "“You know the saying; you don't know what you have until it is taken from you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
> "“Exactly. It feels as if there is no way out.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[174]`
**[WYBÓR GRACZA: "“It feels like the cards are stacked against you.”"]** — Mówca: **Player**
> "“It feels like the cards are stacked against you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
> "“True but some lives are more difficult than others. Like ours was, and still is for hundreds of thousands in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[176]`
**[WYBÓR GRACZA: "“We have all gone through difficult times.”"]** — Mówca: **Player**
> "“We have all gone through difficult times.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[177]`
Mówca: **Ciara Walda**
> "“As I was saying -- isn't it about time Holsord addressed this country's real issues? Rather than bowing to the wishes of the hawks and fearmongerers in the establishment, and diverting yet more resources to the military and law enforcement?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Ciara Walda**
> "“Our welfare, healthcare and education systems have been decaying since the recession. Sordland's poorer communities are losing hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[179]`
Mówca: **Ciara Walda**
> "“Sordland needs more schools full of children instead of barracks full of soldiers, more hospitals instead of police stations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[180]`
**[WYBÓR GRACZA: "“The capital must be prioritised towards the resources that matter the most.”"]** — Mówca: **Player**
> "“The capital must be prioritised towards the resources that matter the most.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[181]`
Mówca: **Ciara Walda**
> "“In other words, rural citizens with medical emergencies have to wait an embarassingly long time before they are treated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[182]`
Mówca: **Ciara Walda**
> "“One cannot be separated from the other, Mr. Rayne. The issues stem from the ideology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Let's not get into an ideological debate. We need to focus on the issues.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[184]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Ciara Walda**
> "“Besides, it wouldn't fit into the planned economy President Rayne has decided to promote.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[188]`
Mówca: **Ciara Walda**
> "“The decision not to promote more state control would cost the Sordish people dearly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[189]`
Mówca: **Ciara Walda**
> "“I don't want to sound cynical, but almost all governments keep making the same promises. We must show we are different through our actions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[190]`
Mówca: **Ciara Walda**
> "“It is the same play and the same book. The security complex in the country keeps driving the agenda as usual.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[191]`
**[WYBÓR GRACZA: "“We are elected representatives of our people and we will prioritize their needs.”"]** — Mówca: **Player**
> "“We are elected representatives of our people and we will prioritize their needs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[192]`
**[WYBÓR GRACZA: "“There are other significant issues that we need to focus on, like security.”"]** — Mówca: **Player**
> "“There are other significant issues that we need to focus on, like security.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[193]`
**[WYBÓR GRACZA: "“I appreciate your briefings and plans. We will re-convene at the budget meeting.”"]** — Mówca: **Player**
> "“I appreciate your briefings and plans. We will re-convene at the budget meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
> "“That's reassuring to hear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
> "“There have been a lot of negative developments lately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
> "“It was a pleasure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Ciara Walda**
> "“See you at the meeting. I hope to see a change in direction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[198]`
Mówca: **Ciara Walda**
> "“Spectacular indeed. But if you look in the opposite direction, you will see what Soll's decades of neglect did to the city.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[199]`
Mówca: **Narrator**
> "I arrived at the meeting room for my talk with Ciara and Paskal. Before beginning, I took a moment to appreciate the view from the balcony. The mountains of Narbel were completely covered with snow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[200]`
**[WYBÓR GRACZA: "“Whatever. I'd much rather be in Holsord right now.”"]** — Mówca: **Player**
> "“Whatever. I'd much rather be in Holsord right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Ciara Walda**
> "“Our presence here will show that we still remember Narbel and other forgotten areas of our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Ciara Walda**
> "“Most of the people living in Narbel are workers, farmers and their wives and children. They're breaking their backs for close to no pay, all thanks to greedy corporations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[200]`
  - -> `[205]`

### Węzeł `[203]`
Mówca: **Ciara Walda**
> "“It is important for the people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[204]`
Mówca: **Ciara Walda**
> "“Real problems like poverty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[205]`
**[WYBÓR GRACZA: "“We can't really blame the companies. That's just how they work.”"]** — Mówca: **Player**
> "“We can't really blame the companies. That's just how they work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Ciara Walda**
> "“Yes we can. Similar companies are doing much better for their workers in United Contana and Arcasia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[207]`
Mówca: **Narrator**
> "As I made my way out, the weather was noticeably cold, but it didn’t keep a group of USP supporters from coming out to cheer us on the streets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[208]`
Mówca: **Narrator**
> "They were excited to see their president in their city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[209]`
**[WYBÓR GRACZA: "“I personally promised that our health systems were to be improved in our term. I fully support you Paskal.”"]** — Mówca: **Player**
> "“I personally promised that our health systems were to be improved in our term. I fully support you, Paskal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[210]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[212]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Health == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
> "“This is one of the reasons I'm optimistic about the upcoming budget debates. With enough funds, we can build new hospitals and expand the quality of our services.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[214]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Education == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Education == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Education == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Education"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Our election mandate was to improve education. We will deliver on this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Ciara Walda**
> "“This brings hope to the table, which needs to be followed by action. There is much to be done, but if we're given the budget, we can implement policies that push education to the next level.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[219]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Education == true && BaseGame.Promise_TermFocus_Health == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Education == true && BaseGame.Promise_TermFocus_Health == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Education"] == true  and  Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Education == true && BaseGame.Promise_TermFocus_Health == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Education"] == true  and  Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[222]`
**[WYBÓR GRACZA: "“Welfare is my top priority. Both education and health will be improved significantly under this administration.”"]** — Mówca: **Player**
> "“Welfare is my top priority. Both education and health will be improved significantly under this administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Ciara Walda**
> "“Exactly. Increasing law enforcement isn't something that reflects nicely on society, in comparison to services that people use every day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
> "“The people will rejoice if they see grand improvements in welfare. Our public opinion ratings will increase drastically.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
> "“It's getting a little cold out here. Shall we continue our discussion indoors?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[226]`
**[WYBÓR GRACZA: "“I agree. We need to improve the standards for our workers.”"]** — Mówca: **Player**
> "“I agree. We need to improve the standards for our workers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
> "“Mr. Clavin has already backed me and given his support. Sordland has fallen behind most countries on this subject and it is my responsibility to ensure this is not the case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[228]`
  - -> `[229]`
  - -> `[254]`

### Węzeł `[228]`
**[WYBÓR GRACZA: "“There is always room for improvement and it is good to hear that you are pushing for it.”"]** — Mówca: **Player**
> "“There is always room for improvement and it is good to hear that you are pushing for it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[229]`
**[WYBÓR GRACZA: "“We shouldn't upset the businesses who are already struggling to stay afloat in the crisis.”"]** — Mówca: **Player**
> "“We shouldn't upset the businesses who are already struggling to stay afloat in the crisis.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[230]`
Mówca: **Ciara Walda**
> "“It also is a matter of life and death. Every decade we hear of some horrific accident due to employers' disregard for their workers' safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
> "“Exactly. Sordland must provide for its own people to move forward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
> "“Appreciate the kind words, Mr. President. I will not let you down.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[233]`
Mówca: **Ciara Walda**
> "“Why would you turn away from the pro-labor cause when you yourself supported the Red Youth during your university years?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[256]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
> "“This wouldn't alter the balance of operational companies drastically. It would just punish them if they are treating their workers unfairly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[237]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Socialist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[238]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[240]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[241]`
Mówca: **Ciara Walda**
> "“It has shown your dedication, but there are many years ahead of us. This is just the beginning of the journey.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
> "“No matter how small a step, it still is progress.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[243]`
**[WYBÓR GRACZA: "“Minister Walda, I have bailed out people in need instead of businesses. Trust me, my priorities are correct.”"]** — Mówca: **Player**
> "“Minister Walda, I have bailed out people in need instead of businesses. Trust me, my priorities are correct.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
> "“So, will you back the bill when it arrives on your desk, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[247]`
  - -> `[262]`

### Węzeł `[245]`
**[WYBÓR GRACZA: "“I would be very interested in supporting it once it is finished.”"]** — Mówca: **Player**
> "“I would be very interested in supporting it once it is finished.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
> "“I'm relieved to hear that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“To make a decision, I would need to evaluate the contents in detail.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
> "“Understandable. You will receive all the sections in an outline.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
> "“It is obvious that the military has been overfunded for a long time. Perhaps it is time to change this trend.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
> "“It is obvious that the military has been overfunded for a long time and you have promised to change this trend.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[251]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == true || BaseGame.Promise_TermFocus_Education == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == true || BaseGame.Promise_TermFocus_Education == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == true  or  Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[253]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Health == true || BaseGame.Promise_TermFocus_Education == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true  or  Variable["BaseGame.Promise_TermFocus_Education"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[254]`
**[WYBÓR GRACZA: "“Sounds like a costly bill for such a low-priority issue.""]** — Mówca: **Player**
> "“Sounds like a costly bill for such a low-priority issue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
> "“If the very lives of our workers aren't a priority, than what is? Our administration should be able to set a budget aside for these types of improvements.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[256]`
**[WYBÓR GRACZA: "“I am not necessarily opposed to it. I'm sceptical.”"]** — Mówca: **Player**
> "“I am not necessarily opposed to it. I'm skeptical.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[257]`
**[WYBÓR GRACZA: "“Times have changed.”"]** — Mówca: **Player**
> "“Times have changed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Ciara Walda**
> "“This is worth considering, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[259]`
Mówca: **Ciara Walda**
> "“One would hope ideals haven't changed as drastically.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[260]`
Mówca: **Ciara Walda**
> "“We shouldn't miss opportunities like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
> "“Maybe by the time the bill is done, you will have changed your mind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I don't think this is the time for such a change. We have bigger issues to fix.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[263]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[264]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[265]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[267]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[268]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[271]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_R_Protest_CalledProtestersTraitors = true; BaseGameSupport.Report_Turn03_Valgen_CalledProtestersTraitors = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_R_Protest_CalledProtestersTraitors"] = true;
Variable["BaseGameSupport.Report_Turn03_Valgen_CalledProtestersTraitors"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_R_Protest_ExpandedPolice = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_R_Protest_ExpandedPolice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn03_Morbel_MineDisaster = true;
BaseGameSupport.Report_Turn03_Estord_YSFoundDead = true;
BaseGameSupport.Report_Turn03_Holsord_NFPReport = true; BaseGameSupport.Report_Turn03_Holsord_WorkersRightsPrep = true; BaseGameSupport.Report_Turn03_Holsord_EPARepealFails = true;
BaseGameSupport.FactionReport_Turn03_CSP_SummitForHelji = true;
BaseGameSupport.News_Turn03_HP_EPA_RepealFails = true;
BaseGameSupport.Report_Turn03_Narbel_CPSLUSOrganize = true;
BaseGameSupport.Report_Turn03_Narbel_LaborStrike = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn03_Morbel_MineDisaster"] = true;
Variable["BaseGameSupport.Report_Turn03_Estord_YSFoundDead"] = true;
Variable["BaseGameSupport.Report_Turn03_Holsord_NFPReport"] = true;
Variable["BaseGameSupport.Report_Turn03_Holsord_WorkersRightsPrep"] = true;
Variable["BaseGameSupport.Report_Turn03_Holsord_EPARepealFails"] = true;
Variable["BaseGameSupport.FactionReport_Turn03_CSP_SummitForHelji"] = true;
Variable["BaseGameSupport.News_Turn03_HP_EPA_RepealFails"] = true;
Variable["BaseGameSupport.Report_Turn03_Narbel_CPSLUSOrganize"] = true;
Variable["BaseGameSupport.Report_Turn03_Narbel_LaborStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[274]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_Decision_StabilityOrder = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_Decision_StabilityOrder"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Abandon == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Abandon == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Abandon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Abandon == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Abandon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[281]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_A_LateBriefing = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_A_LateBriefing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[282]`
Mówca: **Narrator**
> "Paskal nodded gravely. This was a subject he knew quite a bit about himself. His best-known books were about the plight of Sordland's less fortunate, drawing from his own past growing up in squalor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[283]`
Mówca: **Narrator**
> "My Minister of Health was, ironically, somewhat portly, having gained a few pounds since his breakthrough as a best-selling writer. But his authority on social affairs could not be questioned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[284]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Health == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Health == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[286]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_PSnW_Listened_Health == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[287]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: Briefing Done)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[288]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: Jump to: [Briefing Done])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[289]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Education == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_PSnW_Listened_Education == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[291]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_PSnW_Listened_Education == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[292]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: Jump to: [Briefing Done])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[293]`
**[WYBÓR GRACZA: "“I believe that is everything.”"]** — Mówca: **Player**
> "“I believe that is everything.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[294]`
**[WYBÓR GRACZA: "“I believe that is everything.”"]** — Mówca: **Player**
> "“I believe that is everything.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[295]`
**[WYBÓR GRACZA: "“Thank you, Paskal. Your in-depth briefing is much appreciated.”"]** — Mówca: **Player**
> "“Thank you, Paskal. Your in-depth briefing is much appreciated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[296]`
**[WYBÓR GRACZA: "“Thank you, Ciara. I can fill in the blanks from here.”"]** — Mówca: **Player**
> "“Thank you, Ciara. I can fill in the blanks from here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
> "“Parity among the sexes shouldn't be our first priority. Look at how many high-ranking female politicians our country has.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[298]`
Mówca: **Ciara Walda**
> ""Appearances can be deceiving, Paskal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[299]`
Mówca: **Narrator**
> "Her voice sounded bitter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Ciara Walda**
> ""Think about how Lileas Graf got to her current position. I don't necessarily believe the rumors about her and Soll, but she never could have risen so high if she didn't parrot his cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[301]`
Mówca: **Ciara Walda**
> ""Gloria Tory -- is it an accident that the first female Assembly speaker is such a staunch conservative?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[302]`
Mówca: **Ciara Walda**
> ""And then there was Alphonso's habit of promoting women to prominent positions to give Sordland a progressive sheen while accomplishing nothing in reality...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
Mówca: **Ciara Walda**
> ""While women in places like Narbel are denied any opportunity to advance, the government can use a handful of female politicians from wealthy families -- myself included -- to pretend their only obstacle to success is their own lack of initiative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Ciara Walda**
> ""Meanwhile, those of us who don't use our clout to help powerful men stay in power are denigrated as angry spinsters... I ask you, Mr. President, does anyone care that your strategist Mr. Galade doesn't have a wife?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`
  - -> `[307]`
  - -> `[308]`

### Węzeł `[305]`
**[WYBÓR GRACZA: ""I've been wondering about that, actually.""]** — Mówca: **Player**
> ""I've been wondering about that, actually.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[306]`
**[WYBÓR GRACZA: ""Leave Lucian out of this.""]** — Mówca: **Player**
> ""Leave Lucian out of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[307]`
**[WYBÓR GRACZA: ""You've veered off-topic, Ms. Walda.""]** — Mówca: **Player**
> ""You've veered off-topic, Ms. Walda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[308]`
**[WYBÓR GRACZA: ""I agree with you completely. Sordland's women deserve better.""]** — Mówca: **Player**
> ""I agree with you completely. Sordland's women deserve better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[309]`
Mówca: **Ciara Walda**
> ""Mr. Beniwoll asked. I answered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
> ""All right, Ciara. You've made your point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[311]`
Mówca: **Ciara Walda**
> ""I'm glad to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[312]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.CountryReport_Turn03_Lespia_ArcasianMilitaryBase = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn03_Lespia_ArcasianMilitaryBase"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[313]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
> ""Nevertheless, it's worth acknowledging the corporation's significant contribution to job creation in Narbel and other poverty-stricken regions. Persuading the chairman to make concessions might prove to be a formidable task.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[317]`
  - -> `[318]`
  - -> `[319]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
> ""One more thing. I wish to raise my concerns about your scheduled meeting with the Gasom chairman and former President, Mr. Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[316]`
Mówca: **Ciara Walda**
> ""What is there to negotiate, Paskal? The standards for Gasom workers are already at rock bottom. President Rayne can and must demand better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What good is job creation if the workers are treated poorly? Of course I'll demand better from Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I know how slippery Alphonso can be. Bringing this up with him will indeed be a challenge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If we do this right, we can find a solution that advances both the economy and the interests of laborers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
> ""I covered this topic extensively in one of my books. Confrontation, if not handled prudently, could exacerbate the challenges these workers face.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
> ""Try a diplomatic approach. Deep down, I believe he wants what is best for the workers as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
> ""That would be quite the impressive feat. You'd make headlines for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
> "“This matter is close to my heart. I would personally be grateful if you are able to resolve the concerns raised by Katarina Horten and her fellow labor representatives.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[324]`
Mówca: **Ciara Walda**
> "“It would be difficult to imagine a CEO like Alphonso giving benefits to workers without him personally gaining from it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[325]`
  - -> `[326]`
  - -> `[327]`

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""In this world, nothing is truly free. I wouldn't anticipate anything less.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gasom relies on us just as we rely on them. We can find a path to compromise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gasom has profited from the labor of workers for far too long. It's time for them to give back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[328]`
Mówca: **Ciara Walda**
> "“We must be cautious about these seemingly generous offers. They usually come with hidden costs that further tip the scales in favor of the privileged few.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[329]`
Mówca: **Ciara Walda**
> "“The middle way often sways perilously close to the status quo. We must ensure that any negotiations genuinely benefit the people and not just uphold the interests of corporate giants.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[330]`
Mówca: **Ciara Walda**
> "“We shouldn't settle for anything less than a complete overhaul of the exploitative structures Gasom and its fellow corporations have built.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
> ""Thank you for your input, Ciara. But I will stress to President Rayne how important it is that the door to dialogue remain open.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
> ""Ideology should never get in the way of bringing about tangible, lasting change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`
  - -> `[339]`
  - -> `[342]`
  - -> `[340]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
> ""By negotiating with Alphonso and his company, you have an opportunity to secure better labor conditions for blue-collar Gasom employees. This could be a triumph for all of Narbel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My foremost priorities lie in improving the economy. Once that is achieved, upward mobility will naturally follow suit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
> ""Economic improvements don't always automatically translate into greater happiness and well-being, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Considering our need for greater energy security, we might find ourselves forced to collaborate with him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Ciara Walda**
> ""Remember, these 'collaborations' usually come with strings attached. Often, they disproportionately favor corporations while placing the burden on the common people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
> "“We shall keep you no longer. Thank you both for the discussions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm encouraged by the willingness of Mr. Manger and Mr. Alphonso to meet with me. It's a step forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I disagree. Only by holding firm to my convictions can I bring about the change Sordland needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm skeptical that these discussions with Gasom will lead to any meaningful change. We've seen empty promises before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I can't promise anything to either of you. I've got to get a grasp of the situation at Gasom first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[343]`
**[WYBÓR GRACZA: ""No need for the briefing, I'm up to speed.""]** — Mówca: **Player**
> ""No need for the briefing, I'm up to speed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Ciara Walda**
> "“Oh, okay.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
