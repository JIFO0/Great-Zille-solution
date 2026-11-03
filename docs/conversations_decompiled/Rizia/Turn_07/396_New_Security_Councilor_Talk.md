# Rizia/Turn 7/New Security Councilor Talk

- **ID konwersacji:** `396`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/396_New_Security_Councilor_Talk.md`
- **Liczba węzłów dialogowych:** 124
- **Liczba wyborów gracza:** 31

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Country_HouseAzaro`
- `RiziaDLC.Lucita_RomanceHappened`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_Pales_AntiWar`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn05_MurderInvest_SuspectHugo`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[395] Rizia/Turn 7/A_HugoManusPrivateTalk** (../Turn_07/395_A_HugoManusPrivateTalk.md), Węzeł `[494]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 0

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `395` (*Rizia/Turn 7/A_HugoManusPrivateTalk*), Węzeł `[494]`

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""With Duchess Azaro now... indisposed, it is imperative that you choose a new security councilor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[6]`
  - -> `[7]`
  - -> `[8]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How is she faring in prison, by the way?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Hugo Toras**
> ""She's in a high-end women's facility within the Porte Drazon Citadel. I would not worry about her treatment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was going to ask you about that. Have you found any suitable candidates?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want a councilor who isn't a traitor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You mean a new war councilor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Hugo Toras**
> ""We have avoided a second Pales conflict. Lord willing, we will not be entering another war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[10]`
Mówca: **Hugo Toras**
> ""A perfectly reasonable expectation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[11]`
Mówca: **Hugo Toras**
> ""Two, in fact.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Hugo Toras**
> ""As to candidates for her successor...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Hugo Toras**
> ""Incredibly, it seems that General Taddeus Azaro is on track to make a full recovery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Hugo Toras**
> ""Give him another few months, and he will be ready to resume his former position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`
  - -> `[18]`
  - -> `[17]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He still wants to serve me after I jailed his daughter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why, that's excellent news. It'll be as if this whole unpleasantness with Lucita never occurred.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh. I must say that I dread that prospect, especially given the circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that so? I'm looking forward to working with him again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseAzaro < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Hugo Toras**
> ""The feeling may not be mutual. House Azaro had qualms about your reign even before you jailed their heiress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[26]`
Mówca: **Hugo Toras**
> ""The feeling is mutual, it seems. Even after the arrest of House Azaro's heiress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseAzaro < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Hugo Toras**
> ""I doubt that. House Azaro holds grudges for a long time, and General Taddeus is not one to forgive and forget.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[31]`
Mówca: **Hugo Toras**
> ""General Taddeus is not one to forgive and forget, Your Majesty. But you have been a friend to his house throughout your reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseAzaro < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Hugo Toras**
> ""Apparently. Which surprises me, given that General Taddeus is not one to forgive and forget.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[36]`
Mówca: **Hugo Toras**
> ""You have been a friend to House Azaro. Perhaps enough so that he is willing to overlook this incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[37]`
Mówca: **Hugo Toras**
> ""He has shown exceptional loyalty to the Crown in the past. But now? I confess I am not certain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[63]`
  - -> `[64]`
  - -> `[66]`

### Węzeł `[38]`
Mówca: **Hugo Toras**
> ""I have no doubt of his loyalty to the Crown. As long as you keep his daughter alive, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[52]`
  - -> `[51]`
  - -> `[57]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[42]`
Mówca: **Hugo Toras**
> ""However, with the threat of the Duchess' execution hanging over his head, I have no doubt he will be loyal to the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[52]`
  - -> `[51]`
  - -> `[57]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Hugo Toras**
> ""He has shown exceptional loyalty to the Crown in the past. I have faith he will now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[76]`
  - -> `[81]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't kill her? I was looking forward to a good old-fashioned beheading.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The death penalty is standard for traitors to our kingdom. I'm afraid I can't make an exception.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_RomanceHappened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_RomanceHappened == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_RomanceHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_RomanceHappened == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_RomanceHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would never execute Duchess Azaro. I still harbor fond feelings for her, you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would never execute Duchess Azaro. All of Cardesse-Montaklar would turn on me in an instant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Palesians will be expecting an execution, won't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Hugo Toras**
> ""As long as treason to Rizia is punishable by death, then yes, they will take umbrage if you make an exception.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[59]`
Mówca: **Hugo Toras**
> ""If that is what you insist, then I suggest you keep General Taddeus far from these halls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
Mówca: **Hugo Toras**
> ""Yes, ordering the death of such a prominent noble is bound to have repercussions. Even if her father is not restored to his former position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Hugo Toras**
> ""I suspected the two of you were close. It's for the best that nothing came of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Hugo Toras**
> ""I do have one other qualified candidate in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So what you're saying is that I should throw him in jail as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The man's a patriot. He knows that Rizia's security comes before his petty familial concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He got us into an unnecessary war. I'm not chomping at the bit to have him back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Pales_AntiWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Pales_AntiWar == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Pales_AntiWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Pales_AntiWar == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Pales_AntiWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseAzaro < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Hugo Toras**
> ""Is that so, Your Majesty? The General may not be one to forgive and forget, but you have secured House Azaro's favor up to this point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[73]`
Mówca: **Hugo Toras**
> ""I don't blame you. House Azaro had qualms about your reign even before you jailed their heiress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The man's a patriot. He knows that Rizia's security comes before his petty familial concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On the other hand... he got us into an unnecessary war. I'm not chomping at the bit to have him back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Pales_AntiWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Pales_AntiWar == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Pales_AntiWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Pales_AntiWar == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Pales_AntiWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On the other hand... the uprising was his fault. I'm not chomping at the bit to have him back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Aside from that, the uprising was his fault. I'm not chomping at the bit to have him back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what repercussions can I expect from the Azaros if I don't give him his council seat back?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[82]`
Mówca: **Hugo Toras**
> ""One would hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[83]`
Mówca: **Hugo Toras**
> ""He was instrumental in restoring stability after the conflict. Two decades without a major incident is nothing to sniff at.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[84]`
Mówca: **Hugo Toras**
> ""The uprising had many causes. And the General was instrumental in restoring stability afterwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[85]`
Mówca: **Hugo Toras**
> ""Obviously, they would prefer it if the council seat went to their house. But they will understand if you have lingering concerns about the General's health.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[86]`
Mówca: **Narrator**
> "He smiled darkly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Hugo Toras**
> ""Not unless you want all of Cardesse-Montaklar rioting in the streets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[88]`
Mówca: **Hugo Toras**
> ""It is more complicated than that. House Azaro and national security have been synonymous for many years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus already commands his own security detail. Naming him councilor would only be natural.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus already has an important assignment. I don't want to dilute his focus by putting him on the council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[94]`
Mówca: **Narrator**
> "He nodded towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[97]`
  - -> `[98]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That meathead, in charge of security? I want him taking bullets for me, not commanding our armies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know Titus is still sore I never expanded the Golden Guard. Naming him security councilor would more than make up for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A security councilor with no house and no agenda to push... It could be a refreshing change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus? Really? What makes you think he can be trusted?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Hugo Toras**
> ""He has been by your side since your coronation. And his conduct has been beyond reproach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Hugo Toras**
> ""Such loyalty should not go unrewarded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[101]`
Mówca: **Hugo Toras**
> ""Perhaps his unconventional background will give him an edge in devising national security strategies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[102]`
Mówca: **Hugo Toras**
> ""Captain Gordion is a professional. He would not resent you for a decision you made so early on in your reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[103]`
Mówca: **Hugo Toras**
> ""His services have been indispensable in keeping the Royal Family safe. And what is Rizia, if not one extended royal family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[104]`
Mówca: **Hugo Toras**
> ""On the other hand, concentrating that much power in the hands of one man could prove dangerous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[105]`
Mówca: **Hugo Toras**
> ""His conduct as head of the Golden Guard has been beyond reproach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[106]`
Mówca: **Hugo Toras**
> ""With Rizia's national security apparatus at his disposal, he could easily handle both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[107]`
Mówca: **Hugo Toras**
> ""I am confident he would make as trustworthy a councilor as he has a bodyguard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[108]`
Mówca: **Hugo Toras**
> ""It's true that he has no experience with military operations. But then again, we are not at war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[109]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Hugo Toras**
> ""At any rate, I will leave the decision up to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[111]`
Mówca: **Hugo Toras**
> ""You may not know this, but Captain Gordion petitioned King Valero about the interim security councilor position after General Azaro fell ill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[114]`
  - -> `[116]`
  - -> `[119]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's interesting. What'd my father say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Hugo Toras**
> ""He appeared interested. However, he signed the order for Duchess Azaro to fill the position without so much as interviewing the Captain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father should have said yes. Look what happened with Lucita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Hugo Toras**
> ""He couldn't have known. None of us did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That power-grubber. My father never even expanded the Golden Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Hugo Toras**
> ""Perhaps he would have, had he lived.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But my father didn't think he was ready yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectHugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectHugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_SuspectHugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[122]`
Mówca: **Narrator**
> "Hugo frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Hugo Toras**
> ""He said no such thing. He told me he was considering the possibility, in fact. But House Azaro took precedence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
