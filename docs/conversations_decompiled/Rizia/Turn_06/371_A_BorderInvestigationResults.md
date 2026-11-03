# Rizia/Turn 6/A_BorderInvestigationResults

- **ID konwersacji:** `371`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/371_A_BorderInvestigationResults.md`
- **Liczba węzłów dialogowych:** 232
- **Liczba wyborów gracza:** 50

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[70]** Laurento Esquibel
- **[94]** Axel Reinhart
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Incident_Border_KillSoldiers`
- `RiziaDLC.Relations_Lucita_PromisedDate`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Taddeus_Arrested`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn05_MurderInvest_InvestigateLucita`
- `RiziaDLC.Vina_Hostage`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Faction_HouseAzaro_Carlos`
- `RiziaDLC.Faction_HouseAzaro_Lucita`
- `RiziaDLC.Faction_HouseAzaro_Taddeus`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Pales_PostIncident_Peace_Deal`
- `RiziaDLC.Pales_PostIncident_Peace_NoDeal`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PoisonInvestigator_Lucita`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Pales`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLCSupport.FactionReports_Turn06_ATO_ArrestLucita`
- `RiziaDLCSupport.FactionReports_Turn06_ATO_CondemsIgnoringInvestigation`
- `RiziaDLCSupport.Journal_Turn06_BorderInvestigation_ArrestLucita`
- `RiziaDLCSupport.Journal_Turn06_BorderInvestigation_DontArrestLucita`
- `RiziaDLCSupport.News_Turn06_G_BorderIncidentHandled`
- `RiziaDLCSupport.News_Turn06_G_LucitaExoneratedNoWar`
- `RiziaDLCSupport.News_Turn06_G_LucitaExoneratedWar`
- `RiziaDLCSupport.News_Turn06_RH_GeneralAzaroOnWar`
- `RiziaDLCSupport.News_Turn06_RH_LucitaArrested`
- `RiziaDLCSupport.News_Turn06_RH_LucitaExoneratedNoWar`
- `RiziaDLCSupport.News_Turn06_RH_LucitaExoneratedWar`
- `RiziaDLCSupport.Reports_Turn06_Pales_VinaKeptHostage`
- `RiziaDLCSupport.Reports_Turn06_PorteDrazon_LucitaArrested`
- `RiziaDLCSupport.Reports_Turn06_PorteDrazon_LucitaBehindIncident`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 18

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Pales_PostIncident_Peace_Deal`
- `RiziaDLC.Pales_PostIncident_Peace_NoDeal`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Pales`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLCSupport.News_Turn06_G_LucitaExoneratedNoWar`
- `RiziaDLCSupport.News_Turn06_G_LucitaExoneratedWar`
- `RiziaDLCSupport.News_Turn06_RH_GeneralAzaroOnWar`
- `RiziaDLCSupport.News_Turn06_RH_LucitaExoneratedNoWar`
- `RiziaDLCSupport.News_Turn06_RH_LucitaExoneratedWar`
- *...oraz 1 innych wskaźników.*

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[164]` (Paskal Beniwoll): `Variable["RiziaDLC.Pales_War"] = true; Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] = false...`
- Węzeł `[165]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] = false; Variable["RiziaDLC.Policy_Diplomacy_Tr...`
- Węzeł `[204]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Journal_Turn06_BorderInvestigation_ArrestLucita"] = true; Variable["Riz...`
- Węzeł `[205]` (Paskal Beniwoll): `AddConversant("Hugo Toras"); AddConversant("Laurento Esquibel"); ;`
- Węzeł `[206]` (Paskal Beniwoll): `AddConversant("Axel Reinhart");`
- Węzeł `[207]` (Paskal Beniwoll): `RemoveConversant("Axel Reinhart"); ;`
- Węzeł `[208]` (Paskal Beniwoll): `RemoveConversant("Axel Reinhart"); ;`
- Węzeł `[209]` (Paskal Beniwoll): `RemoveConversant("Axel Reinhart"); ;`
- *...oraz 10 innych węzłów ze skryptami.*

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
  - -> `[213]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It was early in the morning. Lucita and I were about to depart for a royal visit to Terador Air Force Base when I got an urgent summons from Hugo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "I walked through the council chamber doors to find my uncle and my foreign affairs councilor waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Esquibel, Your Grace. To what do I owe this interruption?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please tell me there's good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope this is quick, gentlemen. Duchess Azaro and I are on a tight schedule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "The two men glanced at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Laurento Esquibel**
> ""Your Majesty... we have received the results from the joint investigation into the Palesian border incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Laurento Esquibel**
> ""Quite simply, our earlier hypotheses that the attack was incited by Pales or staged by a third party were not borne out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Laurento Esquibel**
> ""Instead, all evidence seemed to indicate an inside job, one masterminded by...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Narrator**
> "He took a deep breath. He couldn't bring himself to go on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`
  - -> `[15]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By whom? Spit it out, man!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come on, Mr. Esquibel. If there's a traitor in our midst, I need to know who it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[16]`
Mówca: **Hugo Toras**
> ""The named culprit was Lucita Azaro, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`
  - -> `[19]`
  - -> `[21]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How certain are they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What?! They'll pay for soiling the name of a capable councilor and esteemed noblewoman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Azaros have been working against me this whole time?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know Duchess Azaro well. She'd never do a thing like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[24]`
Mówca: **Narrator**
> "Laurento frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Laurento Esquibel**
> ""I'd like to believe the same. But you have to consider the possibility that the Duchess entered into your confidence precisely so that you'd take her side in the case of such an incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[26]`
Mówca: **Narrator**
> "Laurento frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Laurento Esquibel**
> ""We don't know the precise details. The Duchess could have been acting in cooperation with her house, or alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[28]`
Mówca: **Hugo Toras**
> ""That was my first thought as well. I don't believe Duchess Azaro would commit such an act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Laurento Esquibel**
> ""I am unsure what to think. Honestly, this investigation has muddied more waters than it has cleared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[30]`
Mówca: **Narrator**
> "Laurento frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Laurento Esquibel**
> ""The report they sent seems to heavily indicate Duchess Azaro's involvement in what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Laurento Esquibel**
> ""The investigators secured a testimony from the commanding officer at the Fort Ales garrison. Apparently he told his men to fire on the Palesians on Duchess Azaro's orders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Laurento Esquibel**
> ""He was then coerced into altering the reports of the incident to suggest that was Pales who shot first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`
  - -> `[36]`
  - -> `[41]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita would have to be an idiot to think that she could get away with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And we trust this officer? What if he's the one who organized everything?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I always did suspect Duchess Azaro of being disingenuous in her pacifism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How could she do this while my daughter was still in Pales? She must have known there was a risk Vina would get caught up in it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[38]`
Mówca: **Hugo Toras**
> ""It does seem rather obvious for a military officer of her caliber.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[39]`
Mówca: **Hugo Toras**
> ""The man's record is spotless. But we cannot rule out that possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[40]`
Mówca: **Hugo Toras**
> ""If she was suspicious of the Palesians, it was for a reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Hugo Toras**
> ""Yes. She is not her father's daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why would she plan such a thing? She always cautioned me to be diplomatic with the Grand Duchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[46]`
Mówca: **Narrator**
> "Hugo sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Hugo Toras**
> ""To me, these results don't add up. It is far more likely that Pales -- or someone else -- is trying to paint Rizia as an aggressor to sabotage our gas deal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Laurento Esquibel**
> ""I agree that this is far from a clear-cut case. Lespia had officials on the investigation committee, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[49]`
Mówca: **Laurento Esquibel**
> ""May I remind you of her suggestion to send a naval blockade to Aureus? Had we agreed to that, we would be in far more trouble than we are right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[50]`
Mówca: **Laurento Esquibel**
> ""She may have been counting on Rizia to invade Pales first and ask questions later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[51]`
Mówca: **Hugo Toras**
> ""Which gives more credence to the theory that the Duchess is innocent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Laurento Esquibel**
> ""Or acting under extreme pressure from her own family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[53]`
Mówca: **Laurento Esquibel**
> ""But we still have a chance to salvage our gas deal and our diplomatic relationship with Pales. We just have to ensure the blame for the border attack falls fully on Duchess Azaro's shoulders, not ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`
  - -> `[61]`
  - -> `[68]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you suggesting we turn in a woman who may be innocent just to avoid conflict?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's obvious to me that Lespia played a role. Most likely hoping that Pales would use the investigation results as grounds to cancel our gas deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales wants us to take our best military strategist off the chessboard. Rather suspicious, that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[57]`
Mówca: **Laurento Esquibel**
> ""But if that's true, then denying Duchess Azaro's involvement is playing right into Lespia's hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[58]`
Mówca: **Laurento Esquibel**
> ""I don't see another way out of it, unfortunately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Laurento Esquibel**
> ""Arrest Duchess Azaro now, and we can claim the incident was the work of a sole actor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Reinhart demanded reparations, and I paid them. Now he wants our best military strategist?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Border_KillSoldiers == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""It could well be the case that Pales and Lespia were in cahoots all along. They may never have truly intended to sell us the gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Hugo Toras**
> ""Only if Pales is serious about honoring the terms of our deal. Which it may not be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Laurento Esquibel**
> ""Pales promised to honor the deal if Rizia's name was cleared. If we name Duchess Azaro as the sole actor responsible for the incident, Duke Reinhart will have to go through with the sale.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Laurento Esquibel**
> ""Defend her, on the other hand, and Pales as well as the entire international community will believe the Rizian government was behind the border operation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's great news. The Azaro traitor will face justice, and our deal can proceed as planned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""If she is innocent -- or even if she is not -- the fallout from House Azaro will be disastrous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Laurento Esquibel**
> ""Not as disastrous as that from the international community should we fail to acknowledge the results of the investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Narrator**
> "An aide rushed into the chambers with the blue telephone. Duke Reinhart was calling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Narrator**
> "Hugo and Laurento stayed silent in the background as I picked up the receiver."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[73]`
Mówca: **Axel Reinhart**
> ""King Romus. I'm assuming you received the same report that I did?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`
  - -> `[76]`
  - -> `[77]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I received it. I'm still deciding what to make of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. I can't believe my own war councilor would betray me like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me, Your Grace. Did Pales or Lespia have a hand in these investigation results?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm hoping I didn't. Because this one is blaming an innocent woman for what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[78]`
Mówca: **Axel Reinhart**
> ""Were you really so surprised, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[79]`
Mówca: **Axel Reinhart**
> ""What is there to decide, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Axel Reinhart**
> ""Are you trying to deflect the blame, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Narrator**
> "The volume of his voice rose."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Axel Reinhart**
> ""Your war councilor's father got us into this entanglement to begin with. With this gas deal, you were about to acknowledge my country's sovereignty and take the possibility of a second invasion completely off the table. Obviously she wouldn't stand for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[89]`
  - -> `[92]`
  - -> `[91]`

### Węzeł `[83]`
Mówca: **Axel Reinhart**
> ""Innocent? Are you serious?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Think about it for a second. Isn't it more likely that Lespia was behind the incident?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Border_KillSoldiers == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[88]`
Mówca: **Axel Reinhart**
> ""Lespia didn't kill my soldiers. That was all Rizia's doing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our fathers do not determine our destiny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[90]`
Mówca: **Axel Reinhart**
> ""Are you suggesting we accuse an ATO member state of falsifying investigation results?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whatever she did, she acted alone. Neither I nor my other councilors had any knowledge of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Admit it. You don't *want* Rizia to acknowledge Palesian sovereignty. It's far more convenient for you to play the victim.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[93]`
Mówca: **Axel Reinhart**
> ""Please, Your Majesty. Make this easy for us both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Axel Reinhart**
> ""Arrest the Azaro woman, and we can get on with this deal and our lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`
  - -> `[100]`
  - -> `[101]`

### Węzeł `[95]`
Mówca: **Axel Reinhart**
> ""That's very dangerous ground you're treading.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[96]`
Mówca: **Axel Reinhart**
> ""In this case, they do. The evidence is right in front of our faces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[97]`
Mówca: **Axel Reinhart**
> ""I believe you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still have my suspicions about the legitimacy of these findings. But for the sake of lasting peace between our nations, Duchess Azaro will face justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rest assured that my war councilor will be punished for her treasonous act. I will personally make sure she is shown no mercy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, Your Grace, but I cannot acknowledge the investigation results. I fully believe that my councilor is innocent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Your Grand Duchy has double-crossed me for the last time. I don't know what scheme you're trying to pull, but I won't go along with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Narrator**
> "There was a long silence on the other end. Laurento and Hugo sat by with bated breath as I awaited the Duke's response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Axel Reinhart**
> ""I am sorry you see it that way, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Axel Reinhart**
> ""You have left me with no choice. The Aureus deal is off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Narrator**
> "Laurento shook his head anxiously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Axel Reinhart**
> ""The gas pipeline from the field to Rizia will be dismantled at once. All Rizian vessels in the vicinity will be ordered to leave, and Rizian access to the field will be blocked indefinitely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`
  - -> `[127]`
  - -> `[123]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This was your plan all along, wasn't it? Take our money, then steal back your gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who will buy the exploration rights from you, then? Lespia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[109]`
Mówca: **Narrator**
> "There was a long silence on the other end. Laurento and Hugo sat by with bated breath as I awaited the Duke's response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Axel Reinhart**
> ""Very good, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Axel Reinhart**
> ""I'm glad we were able to resolve this little hiccup in a civil manner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[114]`
  - -> `[120]`
  - -> `[115]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Arresting the heir to one of Rizia's most important noble families is far from a 'little hiccup', Duke Reinhart. I hope you appreciate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Axel Reinhart**
> ""I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So am I. I am certain this unpleasant affair won't even make it into the history books.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now, will you send my daughter back home?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Axel Reinhart**
> ""Yes, yes, of course. Though I confess I've grown rather fond of having her around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So our gas deal is still on? Exactly as before?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Axel Reinhart**
> ""Exactly as before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[122]`
Mówca: **Axel Reinhart**
> ""It is nothing compared to the magnitude of what we are about to accomplish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And Vina? What about her?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, Your Grace. Surely we can still reach some sort of compromise?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Axel Reinhart**
> ""Arresting Duchess Azaro *was* the compromise, I'm afraid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[129]`
Mówca: **Axel Reinhart**
> ""Assuming you respect our decision to cancel our deal, I shall send her back immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Axel Reinhart**
> ""Although I confess I've grown rather fond of having her around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[134]`
Mówca: **Axel Reinhart**
> ""Needless to say, Princess Vina shall be returned home at once. Although I confess I've grown rather fond of having her around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[135]`
Mówca: **Axel Reinhart**
> ""The fact that you could even think that is proof your kingdom never wanted to reconcile with Pales in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Axel Reinhart**
> ""That is confidential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Axel Reinhart**
> ""I will send your daughter back immediately, assuming you respect our decision to cancel the deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Axel Reinhart**
> ""Now. Do we have an understanding?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[144]`
  - -> `[149]`
  - -> `[148]`

### Węzeł `[142]`
**[WYBÓR GRACZA: ""No. You signed the rights to the Aureus field over to Rizia. If we must take it by force, we will." [Declare War]"]** — Mówca: **Player_Romus**
> ""No. You signed the rights to the Aureus field over to Rizia. If we must take it by force, we will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[143]`
**[WYBÓR GRACZA: ""Listen here, you brat. Do you know what happens when you try to back a bull into a corner? It charges." [Declare War]"]** — Mówca: **Player_Romus**
> ""Listen here, you brat. Do you know what happens when you try to back a bull into a corner? It charges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[147]`
Mówca: **Narrator**
> "Laurento looked stricken. Hugo's expression had turned determined."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. We will forfeit our right to the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are making a mistake. But I will not challenge your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Narrator**
> "Laurento looked defeated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[151]`
Mówca: **Axel Reinhart**
> ""I suppose it was always going to come to this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Axel Reinhart**
> ""We defended ourselves against Rizia once. We are ready to do so again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Axel Reinhart**
> ""And this time, we have a very comely young bargaining chip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[157]`
Mówca: **Axel Reinhart**
> ""But are *you* ready, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Narrator**
> "He hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[159]`
Mówca: **Narrator**
> "I looked at the clock. It was time for our visit to Terador."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[160]`
Mówca: **Axel Reinhart**
> ""That's very wise of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Axel Reinhart**
> ""Of course, I will make sure every nation in Merkopa is aware that Rizia sheltered a known criminal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Axel Reinhart**
> ""But other than that... no hard feelings, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Narrator**
> "He hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War = true;
RiziaDLC.Pales_PostIncident_Peace_Deal = false;
RiziaDLC.Diplomacy_Pales_NegotiatingPower = -100;
RiziaDLC.Policy_Diplomacy_TradeDeal_Pales = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pales_War"] = true;
Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] = false;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = -100;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Pales"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy = false;
RiziaDLC.Policy_Diplomacy_TradeDeal_Pales = false;
RiziaDLC.Vina_Hostage = false; RiziaDLC.Pales_PostIncident_Peace_NoDeal = true; RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] = false;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Pales"] = false;
Variable["RiziaDLC.Vina_Hostage"] = false;
Variable["RiziaDLC.Pales_PostIncident_Peace_NoDeal"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[166]`
Mówca: **Axel Reinhart**
> ""Thank you for seeing reason, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`
  - -> `[170]`

### Węzeł `[167]`
Mówca: **Narrator**
> "Laurento let out a long exhale of relief. Hugo's expression didn't change."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll speak soon. For now, I have an arrest to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll see you at the deal signing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I apologize for all this trouble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Narrator**
> "We hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[172]`
Mówca: **Narrator**
> "Laurento, Hugo and I looked at each other. Nobody spoke for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Hugo Toras**
> ""Well. As the Rizia Imperii police are under Ms. Azaro's command, I'll order the Golden Guard to detain the Duchess until a proper arrest can be made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`
  - -> `[176]`

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell them to tell her I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell them to use as much force as they need to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I control the Golden Guard. I will give the orders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[177]`
Mówca: **Hugo Toras**
> ""Yes... Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Narrator**
> "He looked at me with sorrow in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Hugo Toras**
> ""I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[183]`
Mówca: **Narrator**
> "He bowed his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Hugo Toras**
> ""Yes, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Narrator**
> "I called Titus in and told him he had work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_PromisedDate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_PromisedDate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_PromisedDate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_PromisedDate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_PromisedDate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[192]`
Mówca: **Narrator**
> "I thought about the night Lucita and I had spent in Qalus and all the moments we'd stolen since then. Images of what could have been flashed through my mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[193]`
Mówca: **Narrator**
> "I thought about the way Lucita had looked at me back in Qalus. I had told her I'd take her on a date someday. We'd never get that chance now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[194]`
Mówca: **Narrator**
> "I thought about the night Lucita and I had spent in Qalus and all the moments we'd stolen since then. Images of what could have been flashed through my mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[195]`
Mówca: **Narrator**
> "I thought about the way Lucita had looked at me back in Qalus. I had told her I'd take her on a date someday. We'd never get that chance now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_PromisedDate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_PromisedDate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_PromisedDate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_PromisedDate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_PromisedDate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Narrator**
> "Still lost in my thoughts, I watched as Hugo called Titus into the room and told him he had work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[203]`
Mówca: **Narrator**
> "I thought about the conversation I'd had with Lucita in Montaklar. If House Toras and House Azaro ever were truly allied, they weren't now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn06_BorderInvestigation_ArrestLucita = true; RiziaDLCSupport.News_Turn06_RH_LucitaArrested = true;
RiziaDLC.Pales_PostIncident_Peace_Deal = true;
RiziaDLCSupport.News_Turn06_G_BorderIncidentHandled = true;
RiziaDLCSupport.Reports_Turn06_PorteDrazon_LucitaArrested = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn06_BorderInvestigation_ArrestLucita"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_LucitaArrested"] = true;
Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] = true;
Variable["RiziaDLCSupport.News_Turn06_G_BorderIncidentHandled"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_PorteDrazon_LucitaArrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Hugo Toras");
AddConversant("Laurento Esquibel");)*
- **Efekt (`userScript`):** `AddConversant("Hugo Toras");
AddConversant("Laurento Esquibel");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`
  - -> `[7]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Axel Reinhart");)*
- **Efekt (`userScript`):** `AddConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Axel Reinhart");)*
- **Efekt (`userScript`):** `RemoveConversant("Axel Reinhart");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Axel Reinhart");)*
- **Efekt (`userScript`):** `RemoveConversant("Axel Reinhart");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Axel Reinhart");)*
- **Efekt (`userScript`):** `RemoveConversant("Axel Reinhart");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn06_BorderInvestigation_DontArrestLucita = true;
RiziaDLCSupport.FactionReports_Turn06_ATO_CondemsIgnoringInvestigation = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn06_BorderInvestigation_DontArrestLucita"] = true;
Variable["RiziaDLCSupport.FactionReports_Turn06_ATO_CondemsIgnoringInvestigation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn06_G_LucitaExoneratedNoWar = true; RiziaDLCSupport.News_Turn06_RH_LucitaExoneratedNoWar = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_G_LucitaExoneratedNoWar"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_LucitaExoneratedNoWar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn06_G_LucitaExoneratedWar = true; RiziaDLCSupport.News_Turn06_RH_LucitaExoneratedWar = true; RiziaDLCSupport.News_Turn06_RH_GeneralAzaroOnWar = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_G_LucitaExoneratedWar"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_LucitaExoneratedWar"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_GeneralAzaroOnWar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Gridlock", "R_Gridlock_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Gridlock","R_Gridlock_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn06_PorteDrazon_LucitaBehindIncident = true;
RiziaDLCSupport.FactionReports_Turn06_ATO_ArrestLucita = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_PorteDrazon_LucitaBehindIncident"] = true;
Variable["RiziaDLCSupport.FactionReports_Turn06_ATO_ArrestLucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested = true;
RiziaDLC.Council_Security_Lucita = false; 
RiziaDLC.PoisonInvestigator_Lucita = false;
RiziaDLC.Relations_Lucita_Together = false;
EnableCodexEntry("Characters_Council_LucitaAzaro_Arrested"); RiziaDLC.Vina_Hostage = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Lucita_Arrested"] = true;
Variable["RiziaDLC.Council_Security_Lucita"] = false;
Variable["RiziaDLC.PoisonInvestigator_Lucita"] = false;
Variable["RiziaDLC.Relations_Lucita_Together"] = false;
EnableCodexEntry("Characters_Council_LucitaAzaro_Arrested");
Variable["RiziaDLC.Vina_Hostage"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Faction_HouseAzaro_Lucita = false;
RiziaDLC.Faction_HouseAzaro_Taddeus = true;
RiziaDLC.Faction_HouseAzaro_Carlos = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Faction_HouseAzaro_Lucita"] = false;
Variable["RiziaDLC.Faction_HouseAzaro_Taddeus"] = true;
Variable["RiziaDLC.Faction_HouseAzaro_Carlos"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Faction_HouseAzaro_Lucita = false;
RiziaDLC.Faction_HouseAzaro_Taddeus = false;
RiziaDLC.Faction_HouseAzaro_Carlos = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Faction_HouseAzaro_Lucita"] = false;
Variable["RiziaDLC.Faction_HouseAzaro_Taddeus"] = false;
Variable["RiziaDLC.Faction_HouseAzaro_Carlos"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[225]`
Mówca: **Narrator**
> "As for what role, if any, she had played in my father's death... I would probably never know."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[229]`
Mówca: **Narrator**
> "As for what role, if any, she had played in my father's death... I would probably never know."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[230]`
Mówca: **Narrator**
> "I thought about the conversation I'd had with Lucita in Montaklar. If House Toras and House Azaro ever were truly allied, they weren't now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn06_Pales_VinaKeptHostage = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_Pales_VinaKeptHostage"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
