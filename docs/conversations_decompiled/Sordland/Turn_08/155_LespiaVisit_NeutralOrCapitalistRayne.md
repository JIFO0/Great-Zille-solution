# Sordland/Turn08/LespiaVisit_NeutralOrCapitalistRayne

- **ID konwersacji:** `155`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/155_LespiaVisit_NeutralOrCapitalistRayne.md`
- **Liczba węzłów dialogowych:** 201
- **Liczba wyborów gracza:** 42

---

## 1. Uczestnicy Sceny

- **[3]** Patricio Alvarez
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn04_RegionalInvestment_Agnland`
- `BaseGame.Decision_Turn04_RegionalInvestment_Bergia`
- `BaseGame.Decision_Turn04_RegionalInvestment_Lorren`
- `BaseGame.Policy_Economy_EnergyProtectionAct_Removed`
- `BaseGame.Prologue_Studyplace_Deyr_History`
- `BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum`
- `BaseGame.Wehlen_DefendBorder`
- `BaseGame.Wehlen_JointOperation`
- `BaseGameIsolated.Turn08_FPnT_BrokenTeapot`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.GovernmentBudget`
- `BaseGame.Lespia_Alliance`
- `BaseGame.Lespia_SoldSordishPetroleum`
- `BaseGame.Lespia_TradeDeal`
- `BaseGameSupport.Journal_Turn08_LespiaVisit_Alliance`
- `BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDeal`
- `BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDealAndSold`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[154] Sordland/Turn08/FPnT_LespiaVisit** (../Turn_08/154_FPnT_LespiaVisit.md), Węzeł `[3]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 9

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.GovernmentBudget`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[93]` (Paskal Beniwoll): `Variable["BaseGame.Lespia_TradeDeal"] = true;`
- Węzeł `[94]` (Paskal Beniwoll): `Variable["BaseGame.Lespia_SoldSordishPetroleum"] = true;`
- Węzeł `[99]` (Paskal Beniwoll): `Variable["BaseGame.Lespia_TradeDeal"] = true;`
- Węzeł `[140]` (Paskal Beniwoll): `Variable["BaseGame.Lespia_Alliance"] = true; Variable["BaseGame.GovernmentBudget"] = Variable["Ba...`
- Węzeł `[176]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDeal"] = true;`
- Węzeł `[177]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDealAndSold"] = true;`
- Węzeł `[178]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn08_LespiaVisit_Alliance"] = true;`
- Węzeł `[179]` (Paskal Beniwoll): `UpdateCountryRelationship("Sordland_Country_Lespia","Allied");`
- *...oraz 1 innych węzłów ze skryptami.*

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
  - -> `[4]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `154` (*Sordland/Turn08/FPnT_LespiaVisit*), Węzeł `[3]`

### Węzeł `[3]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[4]`
Mówca: **Patricio Alvarez**
> "“President Rayne. Welcome to Perla.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
**[WYBÓR GRACZA: "“Thank you. It's good to be here, Mr. Alvarez.”"]** — Mówca: **Player**
> "“Thank you. It's good to be here, Mr. Alvarez.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[6]`
Mówca: **Patricio Alvarez**
> "“Good to have you here. I hear a lot about your successes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[5]`
  - -> `[8]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "“And I hear a lot about your successes as well, Mr. Alvarez.”"]** — Mówca: **Player**
> "“And I hear a lot about your successes as well, Mr. Alvarez.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Who doesn't?”"]** — Mówca: **Player**
> "“Who doesn't?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[9]`
Mówca: **Patricio Alvarez**
> "“I hope you had a nice trip.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[10]`
Mówca: **Patricio Alvarez**
> "“I try, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Patricio Alvarez**
> "“Confidence is a rare quality, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Narrator**
> "I smelled the strong odor of alcohol."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“Have you been drinking?”"]** — Mówca: **Player**
> "“Have you been drinking?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Italic**
> "I didn't say anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[15]`
Mówca: **Patricio Alvarez**
> "“A couple of glasses of the finest Lespian wine is the best way to start any meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Patricio Alvarez**
> "“Would you like some?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`
  - -> `[19]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "“No, thank you.”"]** — Mówca: **Player**
> "“No, thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Since you asked, why not?”"]** — Mówca: **Player**
> "“Since you asked, why not?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "“You are speaking to a President. Where is your professionalism?”"]** — Mówca: **Player**
> "“You are speaking to a President. Where is your professionalism?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Patricio Alvarez**
> "“Let's begin then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[21]`
Mówca: **Narrator**
> "He cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[22]`
Mówca: **Patricio Alvarez**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[23]`
Mówca: **Narrator**
> "He gestured to the assistants."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Patricio Alvarez**
> "“Two glasses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Narrator**
> "They came back very fast. We took a sip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Patricio Alvarez**
> "“Ah. Nothing like it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[27]`
Mówca: **Patricio Alvarez**
> "“So, you are here for the trade deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Patricio Alvarez**
> "“What was it about again? Can you remind me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[38]`

### Węzeł `[29]`
Mówca: **Patricio Alvarez**
> "“Right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Mr. Alvarez. Are you making fun of me right now?”"]** — Mówca: **Player**
> "“Mr. Alvarez. Are you making fun of me right now?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“We want to provide Sordish fishing output in return for Lespian capital.”"]** — Mówca: **Player**
> "“We want to provide Sordish fishing output in return for Lespian capital.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[41]`
**[WYBÓR GRACZA: "“We want to provide Sordish wheat in return for Lespian capital.”"]** — Mówca: **Player**
> "“We want to provide Sordish wheat in return for Lespian capital.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "“We want to provide Sordish coal in return for Lespian capital.”"]** — Mówca: **Player**
> "“We want to provide Sordish coal in return for Lespian capital.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“We want to provide Sordish tungsten in return for Lespian capital.”"]** — Mówca: **Player**
> "“We want to provide Sordish tungsten in return for Lespian capital.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[44]`
Mówca: **Patricio Alvarez**
> "“No. Absolutely not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Patricio Alvarez**
> "“I have just been very busy lately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[46]`
Mówca: **Patricio Alvarez**
> "“You know...being the Prime Minister makes you pretty busy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[47]`
Mówca: **Patricio Alvarez**
> "“Ah. Yes. Right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Patricio Alvarez**
> "“Sorry. I have just been very busy lately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[49]`
Mówca: **Patricio Alvarez**
> "“So, I don't have any issues with this deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder == true || BaseGame.Wehlen_JointOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder == true || BaseGame.Wehlen_JointOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"] == true  or  Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_DefendBorder == true || BaseGame.Wehlen_JointOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"] == true  or  Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[53]`
Mówca: **Patricio Alvarez**
> "“Except there is one problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[54]`
Mówca: **Patricio Alvarez**
> "“You know...being the Prime Minister makes you pretty busy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Narrator**
> "He pulled out a few documents from his briefcase and started inspecting them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[56]`
Mówca: **Patricio Alvarez**
> "“Wehlen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Narrator**
> "He smirked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_DefendBorder == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[61]`
Mówca: **Patricio Alvarez**
> "“Your decision to defend the border while Smolak committed war crimes diverted all those refugees here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Patricio Alvarez**
> "“Now we have a full-blown refugee crisis in Lespia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Patricio Alvarez**
> "“Which unfortunately means that the price has gone up, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[66]`
  - -> `[68]`

### Węzeł `[64]`
Mówca: **Patricio Alvarez**
> "“Your decision to join Smolak in his attack against the unfortunate Bludish population compromised a lot of the Lespian assets in the area.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[65]`
Mówca: **Patricio Alvarez**
> "“This has negatively affected Lespia. Our economy was indirectly hit due to the destruction of manufacturing sites. In particular the oil refineries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“No. The price will stay the same or there won't be any deal.”"]** — Mówca: **Player**
> "“No. The price will stay the same or there won't be any deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "“Tell me what you want, Mr. Alvarez.”"]** — Mówca: **Player**
> "“Tell me what you want, Mr. Alvarez.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "“Makes sense. I knew this was coming. So what is on the new price tag?”"]** — Mówca: **Player**
> "“Makes sense. I knew this was coming. So what is on the new price tag?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[69]`
Mówca: **Patricio Alvarez**
> "“It is your choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Patricio Alvarez**
> "“Just like it was your choice to leave Bludish people alone to fend for themselves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Patricio Alvarez**
> "“Reminds me of Soll in many ways. What was it? Ah yes. The Soll Dam Incident.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[150]`
  - -> `[152]`

### Węzeł `[72]`
Mówca: **Patricio Alvarez**
> "“Good intuition.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[73]`
Mówca: **Patricio Alvarez**
> "“The only thing anyone could possibly ever want out of Wehlen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Patricio Alvarez**
> "“I want their oil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[75]`
  - -> `[158]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“And how are you planning to get that?”"]** — Mówca: **Player**
> "“And how are you planning to get that?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "“I'm listening.”"]** — Mówca: **Player**
> "“I'm listening.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Patricio Alvarez**
> "“A lot of oil from Wehlen is passing through Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Patricio Alvarez**
> "“And Sordish Petroleum owns most of the oil trade in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Patricio Alvarez**
> "“Do you see where I am going with that?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "“Yes, I do.”"]** — Mówca: **Player**
> "“Yes, I do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "“Enlighten me.”"]** — Mówca: **Player**
> "“Enlighten me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Patricio Alvarez**
> "“I want you to sell me Sordish Petroleum or the deal is off.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[83]`
  - -> `[181]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "“There is no way I can do that.”"]** — Mówca: **Player**
> "“There is no way I can do that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "“Very well. I accept.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[85]`
**[WYBÓR GRACZA: "“You really are a shrewd man, Mr. Alvarez.”"]** — Mówca: **Player**
> "“You really are a shrewd man, Mr. Alvarez.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Patricio Alvarez**
> "“I will take that as a compliment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[83]`

### Węzeł `[87]`
Mówca: **Patricio Alvarez**
> "“Then thank you for coming this far to visit Perla.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Narrator**
> "He got up and started making his way to the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[192]`
  - -> `[95]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "“Wait. Fine. I accept.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Wait. Fine. I accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Narrator**
> "He turned around with a smile and opened his arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Patricio Alvarez**
> "“My favorite phrase in this world. 'I accept.'.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[92]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_TradeDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Lespia_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_SoldSordishPetroleum = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Lespia_SoldSordishPetroleum"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[95]`
**[WYBÓR GRACZA: "Let him go."]** — Mówca: **Player_Italic**
> "I let him go without saying anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[96]`
Mówca: **Patricio Alvarez**
> "“I think it will contribute nicely to the relationship between Lespia and Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[97]`
Mówca: **Patricio Alvarez**
> "“I do, however, believe that we can do much more than just trade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[98]`
Mówca: **Patricio Alvarez**
> "“We...by we, I mean ATO...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_TradeDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Lespia_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[100]`
Mówca: **Patricio Alvarez**
> "“...Would like to see Sordland in our sphere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Patricio Alvarez**
> "“What do you think, Mr. Rayne?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[103]`
  - -> `[102]`

### Węzeł `[102]`
**[WYBÓR GRACZA: "“Thank you for the offer but that is not one of our aims for now.”"]** — Mówca: **Player**
> "“Thank you for the offer but that is not one of our aims for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[103]`
**[WYBÓR GRACZA: "“Why would you do that for Sordland? What's in it for you?”"]** — Mówca: **Player**
> "“Why would you do that for Sordland? What's in it for you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[104]`
**[WYBÓR GRACZA: "“That sounds excellent. How do we begin?”"]** — Mówca: **Player**
> "“That sounds excellent. How do we begin?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Patricio Alvarez**
> "“Just the answer I wanted to hear!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[106]`
Mówca: **Patricio Alvarez**
> "“Prosperity in Eastern Merkopa!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Patricio Alvarez**
> "“Remedying old alliances!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Patricio Alvarez**
> "“And most importantly, forming a defensive pact against United Contana.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[109]`
Mówca: **Patricio Alvarez**
> "“For now...maybe.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Patricio Alvarez**
> "“But where will you stand when United Contana attacks Eastern Merkopa, as it surely will?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Patricio Alvarez**
> "“That is the real question.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[112]`
Mówca: **Patricio Alvarez**
> "“We need to form a defensive pact against United Contana in Eastern Merkopa before it's too late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Patricio Alvarez**
> "“They will attack eventually.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[114]`
Mówca: **Patricio Alvarez**
> "“Those damn communists!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Patricio Alvarez**
> "“We need to stop them before it's too late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Patricio Alvarez**
> "“Valgsland, those barbarians, are preparing to invade Heljiland on false accusations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Patricio Alvarez**
> "“If Agnolia is first, Sordland will be next.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Patricio Alvarez**
> "“I will be frank. Eastern Merkopa's only way to survival is through ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[119]`
Mówca: **Patricio Alvarez**
> "“Are you with us?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Patricio Alvarez**
> "“Will you defend our continent against the blight of communism?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`
  - -> `[123]`

### Węzeł `[121]`
**[WYBÓR GRACZA: "“Down with the communists. I am willing to do whatever it takes to protect Sordland.”"]** — Mówca: **Player**
> "“Down with the communists. I am willing to do whatever it takes to protect Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[122]`
**[WYBÓR GRACZA: "“I think you are exaggerating the threat. I have my doubts about this.”"]** — Mówca: **Player**
> "“I think you are exaggerating the threat. I have my doubts about this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[123]`
**[WYBÓR GRACZA: "“I can't decide without knowing what is in it for me.”"]** — Mówca: **Player**
> "“I can't decide without knowing what is in it for me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Patricio Alvarez**
> "“I see that you possess the mind of a man who understands business.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Patricio Alvarez**
> "“I offer you an alliance. It will come with a special aid package from me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Patricio Alvarez**
> "“Together we will shield the continent against Malenyev's evil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Patricio Alvarez**
> "“Not to mention that you will have Arcasia's full backing. The most powerful ally you can have in this era.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[128]`
Mówca: **Patricio Alvarez**
> "“I am giving you this option for your country's own good, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[129]`
Mówca: **Patricio Alvarez**
> "“Well said! First, Hegel will fall. Then Malenyev!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "“I accept. Sordland will be allied to Lespia.” [+2 Government Budget]"]** — Mówca: **Player**
> "“I accept. Sordland will be allied to Lespia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[131]`
**[WYBÓR GRACZA: "“I have to refuse. I will not drag Sordland into an international conflict.”"]** — Mówca: **Player**
> "“I have to refuse. I will not drag Sordland into an international conflict.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[132]`
Mówca: **Patricio Alvarez**
> "“I am overjoyed. This is a start to bring our countries closer than ever before.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Patricio Alvarez**
> "“We Eastern Merkopans should stand together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[134]`
Mówca: **Patricio Alvarez**
> "“Speaking of standing together...I want to talk to you about something.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[135]`
Mówca: **Narrator**
> "He clenched his fist and slammed it on the coffee table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[136]`
Mówca: **Patricio Alvarez**
> "“And we need the support of one of the largest players in Eastern Merkopa. Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Patricio Alvarez**
> "“The beautiful country of Sordland is the key to all of this. We need you, Mr. Rayne. We need Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[138]`
Mówca: **Patricio Alvarez**
> "“You think you are evading the conflict by trying to stay neutral.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Patricio Alvarez**
> "“Remember my words when the conflict is at your doorstep, ringing your doorbell, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance = true;
BaseGame.GovernmentBudget += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Lespia_Alliance"] = true;
Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[141]`
Mówca: **Patricio Alvarez**
> "“Perfect! Brilliant!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Patricio Alvarez**
> "“You don't know how valuable you are, Mr. Rayne!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Patricio Alvarez**
> "“You just saved your country from its demise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Patricio Alvarez**
> "“I will personally talk to Mr. Walker to let him know of this achievement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Narrator**
> "We shook hands and he went in for a hug. I could smell the alcohol on his breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[146]`
Mówca: **Patricio Alvarez**
> "“Don't forget that I gave you a choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Patricio Alvarez**
> "“I can just say that I hope Sordland doesn't fall into a bad position because of your decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[148]`
Mówca: **Patricio Alvarez**
> "“I will sign the executive order.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[149]`
Mówca: **Patricio Alvarez**
> "“Not to mention the humanitarian implications. We had to do our duty and send aid to those who were displaced as a result.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[150]`
**[WYBÓR GRACZA: "“Take care of your own country's issues first, Mr. Alvarez.”"]** — Mówca: **Player**
> "“Take care of your own country's issues first, Mr. Alvarez.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[151]`
**[WYBÓR GRACZA: "“I would recommend you not to badmouth Colonel Soll.”"]** — Mówca: **Player**
> "“I would recommend you not to badmouth Colonel Soll.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[152]`
**[WYBÓR GRACZA: "“I had to make a hard decision and this is the result of it.”"]** — Mówca: **Player**
> "“I had to make a hard decision and this is the result of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Patricio Alvarez**
> "“Not every hard decision is right, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[154]`
Mówca: **Patricio Alvarez**
> "“I am doing exactly that right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Patricio Alvarez**
> "“My apologies. I never took you for a Sollist.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Patricio Alvarez**
> "“Before you make your final decision, let me tell you about my offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Patricio Alvarez**
> "“I want the only thing that anyone could possibly ever want out of Wehlen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[158]`
**[WYBÓR GRACZA: "“And?”"]** — Mówca: **Player**
> "“And?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[159]`
Mówca: **Narrator**
> "He looked at the clock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Patricio Alvarez**
> "“I'm afraid I have to leave now to attend to other matters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Patricio Alvarez**
> "“Thank you for your visit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[165]`
Mówca: **Patricio Alvarez**
> "“Before I forget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Narrator**
> "On his way to the door, he suddenly turned around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[167]`
Mówca: **Patricio Alvarez**
> "“You owe me a teapot.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Narrator**
> "He smiled and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[172]`
Mówca: **Narrator**
> "On his way to the door, he suddenly turned around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Patricio Alvarez**
> "“Before I forget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Narrator**
> "He left the room and an assistant arrived to escort me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[175]`
Mówca: **Patricio Alvarez**
> "“You owe me a teapot.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDealAndSold = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDealAndSold"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_LespiaVisit_Alliance = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_LespiaVisit_Alliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateCountryRelationship("Sordland_Country_Lespia", "Allied");)*
- **Efekt (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Lespia","Allied");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateCountryRelationship("Sordland_Country_Valgsland", "Unfriendly");)*
- **Efekt (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Valgsland","Unfriendly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
**[WYBÓR GRACZA: "“Our energy protection laws don't allow such actions. I can't comply Mr. Alvarez.”"]** — Mówca: **Player**
> "“Our energy protection laws don't allow such actions. I can't comply Mr. Alvarez.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[185]`
**[WYBÓR GRACZA: "“Shrewd but not investigative enough. The Energy Protection Act doesn't allow such a transaction.”"]** — Mówca: **Player**
> "“Shrewd but not investigative enough. The Energy Protection Act doesn't allow such a transaction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[192]`
**[WYBÓR GRACZA: "“Goodbye.”"]** — Mówca: **Player**
> "“Goodbye.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[196]`
**[WYBÓR GRACZA: "“Very well. I accept.”"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[197]`
**[WYBÓR GRACZA: "“Very well. I accept.”"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
