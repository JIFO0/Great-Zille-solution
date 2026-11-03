# Sordland/Turn08/LespiaVisit_AntiCapitalistRayne

- **ID konwersacji:** `156`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/156_LespiaVisit_AntiCapitalistRayne.md`
- **Liczba węzłów dialogowych:** 176
- **Liczba wyborów gracza:** 43

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
- `BaseGame.Lespia_SoldSordishPetroleum`
- `BaseGame.Lespia_TradeDeal`
- `BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDeal`
- `BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDealAndSold`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[154] Sordland/Turn08/FPnT_LespiaVisit** (../Turn_08/154_FPnT_LespiaVisit.md), Węzeł `[3]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 5

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[96]` (Paskal Beniwoll): `Variable["BaseGame.Lespia_TradeDeal"] = true;`
- Węzeł `[110]` (Paskal Beniwoll): `Variable["BaseGame.Lespia_SoldSordishPetroleum"] = true;`
- Węzeł `[111]` (Paskal Beniwoll): `Variable["BaseGame.Lespia_TradeDeal"] = true;`
- Węzeł `[147]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDeal"] = true;`
- Węzeł `[148]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDealAndSold"] = true;`

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `154` (*Sordland/Turn08/FPnT_LespiaVisit*), Węzeł `[3]`

### Węzeł `[3]`
Mówca: **Patricio Alvarez**
> "“President Rayne. Welcome to Perla.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
**[WYBÓR GRACZA: "“Thank you. It's good to be here, Mr. Alvarez.”"]** — Mówca: **Player**
> "“Thank you. It's good to be here, Mr. Alvarez.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[5]`
Mówca: **Patricio Alvarez**
> "“Have a seat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[4]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "“I hear a lot about your successes, Mr. Alvarez.”"]** — Mówca: **Player**
> "“I hear a lot about your successes, Mr. Alvarez.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[7]`
Mówca: **Narrator**
> "He smiled and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[8]`
Mówca: **Patricio Alvarez**
> "“I hope you had a nice trip.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[9]`
Mówca: **Patricio Alvarez**
> "“Thank you, Mr. Rayne. That is very kind of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[10]`
Mówca: **Patricio Alvarez**
> "“You owe me a teapot.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[11]`
Mówca: **Narrator**
> "I smelled the strong odor of alcohol."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[12]`
Mówca: **Narrator**
> "On his way to the door, he suddenly turned around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Patricio Alvarez**
> "“Before I forget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Have you been drinking?”"]** — Mówca: **Player**
> "“Have you been drinking?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Italic**
> "I didn't say anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[19]`
Mówca: **Patricio Alvarez**
> "“Thank you for your visit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[129]`
  - -> `[128]`

### Węzeł `[20]`
Mówca: **Patricio Alvarez**
> "“A couple of glasses of the finest Lespian wine is the best way to start any meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "“I would recommend you not to badmouth Colonel Soll.”"]** — Mówca: **Player**
> "“I would recommend you not to badmouth Colonel Soll.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[22]`
Mówca: **Patricio Alvarez**
> "“Would you like some?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[25]`
  - -> `[27]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "“No, thank you.”"]** — Mówca: **Player**
> "“No, thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[24]`
Mówca: **Patricio Alvarez**
> "“I'm afraid I have to leave now to attend to other matters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "“Since you asked, why not?”"]** — Mówca: **Player**
> "“Since you asked, why not?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[26]`
Mówca: **Narrator**
> "He looked at the clock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“You are speaking to a President. Where is your professionalism?”"]** — Mówca: **Player**
> "“You are speaking to a President. Where is your professionalism?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Patricio Alvarez**
> "“Let's begin then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[29]`
Mówca: **Narrator**
> "He cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[30]`
Mówca: **Patricio Alvarez**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[31]`
Mówca: **Narrator**
> "He gestured to the assistants."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Patricio Alvarez**
> "“Two glasses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“And?”"]** — Mówca: **Player**
> "“And?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[34]`
Mówca: **Narrator**
> "They came back very fast. They must've been used to this. We took a sip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Patricio Alvarez**
> "“Ah. Nothing like it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[36]`
Mówca: **Narrator**
> "He turned around with a smile and opened his arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[37]`
Mówca: **Patricio Alvarez**
> "“I am overjoyed. This is a start to bring our countries closer than ever before.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[38]`
Mówca: **Patricio Alvarez**
> "“So, you are here for the trade deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Patricio Alvarez**
> "“What was it about again? Can you remind me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[52]`

### Węzeł `[40]`
Mówca: **Patricio Alvarez**
> "“I want the only thing that anyone could possibly ever want out of Wehlen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[41]`
Mówca: **Patricio Alvarez**
> "“Don't you worry about my professionalism.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[42]`
Mówca: **Patricio Alvarez**
> "“Before you make your final decision, let me tell you about my offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“Mr. Alvarez. Are you making fun of me right now?”"]** — Mówca: **Player**
> "“Mr. Alvarez. Are you making fun of me right now?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“We want to provide Sordish fishing output in return for Lespian capital.”"]** — Mówca: **Player**
> "“We want to provide Sordish fishing output in return for Lespian capital.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[45]`
Mówca: **Patricio Alvarez**
> "“My apologies. I never took you for a Sollist.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[55]`
Mówca: **Patricio Alvarez**
> "“I am doing exactly that right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "“We want to provide Sordish wheat in return for Lespian capital.”"]** — Mówca: **Player**
> "“We want to provide Sordish wheat in return for Lespian capital.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "“We want to provide Sordish coal in return for Lespian capital.”"]** — Mówca: **Player**
> "“We want to provide Sordish coal in return for Lespian capital.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "“We want to provide Sordish tungsten in return for Lespian capital.”"]** — Mówca: **Player**
> "“We want to provide Sordish tungsten in return for Lespian capital.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[59]`
Mówca: **Patricio Alvarez**
> "“Not every hard decision is right, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[60]`
Mówca: **Patricio Alvarez**
> "“No. Absolutely not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Patricio Alvarez**
> "“I have just been very busy lately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[62]`
Mówca: **Patricio Alvarez**
> "“My favorite phrase in this world. 'I accept.'.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "“I had to make a hard decision, and this is the result of it.”"]** — Mówca: **Player**
> "“I had to make a hard decision, and this is the result of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[64]`
Mówca: **Patricio Alvarez**
> "“You know...being the Prime Minister makes you pretty busy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[65]`
Mówca: **Patricio Alvarez**
> "“Ah. Yes. Right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“Take care of your own country's issues first, Mr. Alvarez.”"]** — Mówca: **Player**
> "“Take care of your own country's issues first, Mr. Alvarez.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[67]`
Mówca: **Patricio Alvarez**
> "“Sorry. I have just been very busy lately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[68]`
Mówca: **Patricio Alvarez**
> "“Not to mention the humanitarian implications. We had to do our duty and send aid to those who were displaced as a result.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[69]`
Mówca: **Patricio Alvarez**
> "“We Eastern Merkopans should stand together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[70]`
Mówca: **Patricio Alvarez**
> "“So, I don't have any issues with this deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder == true || BaseGame.Wehlen_JointOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder == true || BaseGame.Wehlen_JointOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"] == true  or  Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_DefendBorder == true || BaseGame.Wehlen_JointOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"] == true  or  Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[74]`
Mówca: **Patricio Alvarez**
> "“I will sign the executive order.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[75]`
Mówca: **Patricio Alvarez**
> "“Except there is one problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[76]`
Mówca: **Patricio Alvarez**
> "“You know...being the Prime Minister makes you pretty busy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Narrator**
> "He pulled out a few documents from his briefcase and started inspecting them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[78]`
Mówca: **Patricio Alvarez**
> "“Wehlen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Narrator**
> "He smirked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_DefendBorder == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[83]`
Mówca: **Patricio Alvarez**
> "“Your decision to defend the border while Smolak committed war crimes diverted all those refugees here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Patricio Alvarez**
> "“Now we have a full-blown refugee crisis in Lespia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Patricio Alvarez**
> "“Which unfortunately means that the price has gone up, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[88]`
  - -> `[91]`

### Węzeł `[86]`
Mówca: **Patricio Alvarez**
> "“Your decision to join Smolak in his attack against the unfortunate Bludish population compromised a lot of the Lespian assets in the area.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[87]`
Mówca: **Patricio Alvarez**
> "“This has negatively affected Lespia. Our economy was indirectly hit due to the destruction of manufacturing sites. In particular the oil refineries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "“No. The price will stay the same or there won't be any deal.”"]** — Mówca: **Player**
> "“No. The price will stay the same or there won't be any deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "“Tell me what you want, Mr. Alvarez.”"]** — Mówca: **Player**
> "“Tell me what you want, Mr. Alvarez.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[90]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "“Makes sense. I knew this was coming. So what is on the new price tag?”"]** — Mówca: **Player**
> "“Makes sense. I knew this was coming. So what is on the new price tag?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[92]`
Mówca: **Patricio Alvarez**
> "“It is your choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Patricio Alvarez**
> "“Just like it was your choice to leave Bludish people alone to fend for themselves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Patricio Alvarez**
> "“Reminds me of Soll in many ways. What was it? Ah yes. The Soll Dam Incident.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[66]`
  - -> `[63]`

### Węzeł `[95]`
Mówca: **Patricio Alvarez**
> "“Good intuition.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_TradeDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Lespia_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`
  - -> `[124]`

### Węzeł `[97]`
Mówca: **Patricio Alvarez**
> "“The only thing that anyone could possibly ever want out of Wehlen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Patricio Alvarez**
> "“I want their oil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[99]`
  - -> `[33]`

### Węzeł `[99]`
**[WYBÓR GRACZA: "“And how are you planning to get that?”"]** — Mówca: **Player**
> "“And how are you planning to get that?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
**[WYBÓR GRACZA: "“I'm listening.”"]** — Mówca: **Player**
> "“I'm listening.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Patricio Alvarez**
> "“A lot of oil from Wehlen is passing through Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Patricio Alvarez**
> "“I think this deal will contribute nicely to the relationship between Lespia and Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[103]`
Mówca: **Patricio Alvarez**
> "“And Sordish Petroleum owns most of the oil trade in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Patricio Alvarez**
> "“Excellent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[105]`
Mówca: **Patricio Alvarez**
> "“Do you see where I am going with that?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
**[WYBÓR GRACZA: "“Yes, I do.”"]** — Mówca: **Player**
> "“Yes, I do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[107]`
**[WYBÓR GRACZA: "“Enlighten me.”"]** — Mówca: **Player**
> "“Enlighten me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
**[WYBÓR GRACZA: "“You really are a shrewd man, Mr. Alvarez.”"]** — Mówca: **Player**
> "“You really are a shrewd man, Mr. Alvarez.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[109]`
Mówca: **Patricio Alvarez**
> "“I want you to sell me Sordish Petroleum or the deal is off.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[149]`
  - -> `[156]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_SoldSordishPetroleum = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Lespia_SoldSordishPetroleum"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_TradeDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Lespia_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[112]`
Mówca: **Patricio Alvarez**
> "“I wish I could say the same about you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[114]`
  - -> `[113]`
  - -> `[115]`

### Węzeł `[113]`
**[WYBÓR GRACZA: "“Don't take my kindness for granted.”"]** — Mówca: **Player**
> "“Don't take my kindness for granted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[114]`
**[WYBÓR GRACZA: "“What the hell does that mean?”"]** — Mówca: **Player**
> "“What the hell does that mean?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "“No need to argue, right? We have just met.”"]** — Mówca: **Player**
> "“No need to argue, right? We have just met.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[116]`
Mówca: **Patricio Alvarez**
> "“Ah, Mr. Rayne. You know what you have done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Patricio Alvarez**
> "“Your actions speak for themselves. It almost seems like you are on a mission to ideologically oppose us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[118]`
Mówca: **Patricio Alvarez**
> "“And don't take my straightforwardness for granted, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[119]`
Mówca: **Patricio Alvarez**
> "“Exactly. We don't need to waste any time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[120]`
Mówca: **Patricio Alvarez**
> "“By us, I mean Lespia and ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[121]`
Mówca: **Patricio Alvarez**
> "“Despite a lack of ideological alignments.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[122]`
**[WYBÓR GRACZA: "“When did ideology ever stop deals from happening?”"]** — Mówca: **Player**
> "“When did ideology ever stop deals from happening?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[123]`
**[WYBÓR GRACZA: "“That is excellent news.”"]** — Mówca: **Player**
> "“That is excellent news.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[124]`
**[WYBÓR GRACZA: "“Very good. We are done then.”"]** — Mówca: **Player**
> "“Very good. We are done then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Patricio Alvarez**
> "“Yes. We are done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[126]`
Mówca: **Patricio Alvarez**
> "“I could count at least a few dozen instances, but let's not go into that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[127]`
Mówca: **Patricio Alvarez**
> "“I'm glad we are on the same page.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[128]`
**[WYBÓR GRACZA: "“I'm glad this was quick. The less time I spend here, the better.”"]** — Mówca: **Player**
> "“I'm glad this was quick. The less time I spend here, the better.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[129]`
**[WYBÓR GRACZA: "“Perhaps we could advance this deal. What are your thoughts about an alliance?”"]** — Mówca: **Player**
> "“Perhaps we could advance this deal. What are your thoughts about an alliance?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "“Thank you for having me.”"]** — Mówca: **Player**
> "“Thank you for having me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[131]`
Mówca: **Patricio Alvarez**
> "“Mr. Rayne, Mr. Rayne, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Patricio Alvarez**
> "“I don't think so.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Patricio Alvarez**
> "“You should be glad that I am a lenient man. That's the only reason we were able to achieve a deal today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Patricio Alvarez**
> "“I wouldn't push it if I were you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Patricio Alvarez**
> "“Have a good day, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[136]`
Mówca: **Patricio Alvarez**
> "“If I were you I would reconsider my decision on who my friends and foes are.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[137]`
**[WYBÓR GRACZA: "“I thought the Prime Minister of Lespia would have at least some amount of social aptitude.”"]** — Mówca: **Player**
> "“I thought the Prime Minister of Lespia would have at least some amount of social aptitude.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Patricio Alvarez**
> "“I can assure you, I do, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Patricio Alvarez**
> "“And it is reserved only for my friends.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[140]`
Mówca: **Narrator**
> "On his way to the door, he suddenly turned around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Patricio Alvarez**
> "“Before I forget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Patricio Alvarez**
> "“You owe me a teapot.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Narrator**
> "He left the room and an assistant arrived to escort me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDealAndSold = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDealAndSold"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[149]`
**[WYBÓR GRACZA: "“There is no way I can do that.”"]** — Mówca: **Player**
> "“There is no way I can do that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
**[WYBÓR GRACZA: "“Wait. Fine. I accept.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Wait. Fine. I accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[151]`
Mówca: **Patricio Alvarez**
> "“Then thank you for coming this far to visit Perla.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Narrator**
> "He got up and started making his way to the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[164]`
  - -> `[155]`

### Węzeł `[153]`
**[WYBÓR GRACZA: "“Very well. I accept.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[154]`
Mówca: **Patricio Alvarez**
> "“I will take that as a compliment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[149]`

### Węzeł `[155]`
**[WYBÓR GRACZA: "Let him go."]** — Mówca: **Player_Italic**
> "I let him go without saying anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[159]`
**[WYBÓR GRACZA: "“Shrewd but not investigative enough. The Energy Protection Act doesn't allow such a transaction.”"]** — Mówca: **Player**
> "“Shrewd but not investigative enough. The Energy Protection Act doesn't allow such a transaction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[163]`
**[WYBÓR GRACZA: "“Our energy protection laws don't allow such actions. I can't comply Mr. Alvarez.”"]** — Mówca: **Player**
> "“Our energy protection laws don't allow such actions. I can't comply Mr. Alvarez.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[164]`
**[WYBÓR GRACZA: "“Goodbye.”"]** — Mówca: **Player**
> "“Goodbye.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[171]`
**[WYBÓR GRACZA: "“Very well. I accept.”"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[172]`
**[WYBÓR GRACZA: "“Very well. I accept.”"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
