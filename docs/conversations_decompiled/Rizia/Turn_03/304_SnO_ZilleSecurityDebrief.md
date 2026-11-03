# Rizia/Turn 3/SnO_ZilleSecurityDebrief

- **ID konwersacji:** `304`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Rizia/Turn_03/304_SnO_ZilleSecurityDebrief.md`
- **Liczba węzłów dialogowych:** 510
- **Liczba wyborów gracza:** 127

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[70]** Laurento Esquibel
- **[73]** Lucita Azaro
- **[79]** Vina Toras
- **[81]** Titus Gordion
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded`
- `RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_JoinedSuOmina`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.SecurityTitus_SupportGoldenGuard`
- `RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel`
- `RiziaDLC.Turn01_ZilleVisit_HostileSpeech`
- `RiziaDLC.Turn02_SecurityTitus_DiscussPossibleMurder`
- `RiziaDLC.Vina_OnCouncil`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Army_Unit_GoldenGuard_Total`
- `RiziaDLC.Diplomacy_Wehlen_NegotiatingPower`
- `RiziaDLC.Enable_Policy_RD_Order_MaveNortusIntelHub`
- `RiziaDLC.InvestigatePoisoning_NoPabel`
- `RiziaDLC.PoisonInvestigator_Lucita`
- `RiziaDLC.PoisonInvestigator_Titus`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded`
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Lucita_Romance`
- `RiziaDLC.Relations_Titus`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Security_FundNone`
- `RiziaDLC.Security_GoldenGuard_InvestigateSO`
- `RiziaDLC.Situation_Order_KingsGuardForce_Limited`
- `RiziaDLC.Situation_Order_KingsGuardForce_Powerful`
- `RiziaDLC.Turn03_Security_LucitaLeadsInvestigation`
- `RiziaDLC.Turn03_Security_TitusLeadsInvestigation`
- `RiziaDLC.ZilleSecurityDebriefFinished`
- `RiziaDLCSupport.Journal_Turn03_Security_FundForeignIntelligence`
- `RiziaDLCSupport.Journal_Turn03_Security_FundGoldenGuard`
- `RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone`
- `RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel`
- `RiziaDLCSupport.Journal_Turn03_Security_TitusInvestigateMurderEveryone`
- `RiziaDLCSupport.Journal_Turn03_Security_TitusInvestigateMurderNoPabel`
- `RiziaDLCSupport.News_Turn03_RH_BeatriceVisit`
- `RiziaDLCSupport.Reports_Turn03_Bronaz_BeatriceVisit`
- `RiziaDLCSupport.Reports_Turn03_Jales_FriendshipDayVigil`
- `RiziaDLCText.GoldenGuardUpdate`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 35

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Lucita_Romance`
- `RiziaDLC.Relations_Titus`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.ZilleSecurityDebriefFinished`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[186]` (Paskal Beniwoll): `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] = true; Variable["RiziaDLC.T...`
- Węzeł `[187]` (Paskal Beniwoll): `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] = true; Variable["RiziaDLC.Turn03_Security...`
- Węzeł `[253]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Journal_Turn03_Security_TitusInvestigateMurderNoPabel"] = true; Variabl...`
- Węzeł `[256]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Journal_Turn03_Security_TitusInvestigateMurderEveryone"] = true;`
- Węzeł `[305]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- Węzeł `[306]` (Paskal Beniwoll): `PlayLoopedMusic("R_ImpasseLight","R_ImpasseLight_Loop");`
- Węzeł `[313]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 4; Variable["Rizi...`
- Węzeł `[314]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 4;`
- *...oraz 27 innych węzłów ze skryptami.*

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
  - -> `[509]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "A few weeks had passed since the attack in Zille."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Narrator**
> "I called Lucita, Hugo, Titus and Vina to my council chambers for a security update."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "I called Lucita, Hugo and Titus to my council chambers for a security update."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Titus insisted on sweeping the room before Vina and I sat down. Hugo was next to arrive, early as usual."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Narrator**
> "Titus insisted on sweeping the room before I sat down. Hugo was next to arrive, early as usual."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Hugo Toras**
> ""Your Majesty. How are you faring?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`
  - -> `[14]`
  - -> `[15]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still in shock. How was such an attack allowed to take place in the King's presence?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm just fine. It's the Wehzek victims of the bombing I'm concerned about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm doing all right. So is Mother, in case you cared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm worried about Wehlen's reaction. Smolak hasn't even made a public statement yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Hugo Toras**
> ""Perhaps no news is good news in this case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[17]`
Mówca: **Hugo Toras**
> ""I can only hope Duchess Azaro will enlighten us on that matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""It was God's will that you survived. Losing two kings within a year would have been catastrophic for this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""Of course the Queen Mother's safety is of the utmost importance to me. But losing two kings in a matter of months would have been catastrophic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""At ease, Duchess Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need a status report. Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're not all gentlemen. Do not forget the presence of the princess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for joining us, Duchess Azaro. Can you update us on the Zille situation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Lucita Azaro**
> ""Certainly, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[25]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Narrator**
> "Lucita sat and flipped open a dossier."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Narrator**
> "Still standing, she picked a dossier up off the table and flipped it open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Lucita Azaro**
> ""I'll reiterate what we already know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Lucita Azaro**
> ""At 1605 hours on December 8, 1950, an explosive object detonated in Smolak Square in the city of Zille. It had been planted beneath grandstands that were set up that morning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Lucita Azaro**
> ""Seated in those stands were a mix of civilians and political figures who had been invited to the Friendship Day event, all of Wehzek heritage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Lucita Azaro**
> ""The most recent casualty report states that three civilians were killed in the blast. Of the 14 injured, all are now in stable condition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[34]`
  - -> `[33]`
  - -> `[32]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't forget that right before the attack, someone screamed 'For the King.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, yes, we know all that. What's new?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was anyone important among the dead?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank God. From what I saw, it could have been much worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Lucita Azaro**
> ""No, the most prominent Wehzek attendees all made it out unharmed. Wehlen's guards saw to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[37]`
Mówca: **Lucita Azaro**
> ""It's not good for us regardless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[38]`
Mówca: **Lucita Azaro**
> ""I was getting to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Lucita Azaro**
> ""I haven't forgotten. Nor has Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Narrator**
> "She turned a page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Lucita Azaro**
> ""Based on the scant evidence available, Wehlen's intelligence agency suspects that the Rizian nationalist group Su Omina was behind the crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[42]`
Mówca: **Vina Toras**
> ""I don't understand why Cousin Rico would even support a group like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[46]`
  - -> `[57]`
  - -> `[58]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate the boy's efforts. But I wish he would coordinate them with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's true. National identity should be secondary to one's loyalty to the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's rubbish. The monarchy and the nation of Rizia cannot be separated from one another. I appreciate Rico's efforts to protect both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please don't change the subject, Vina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Rico has no right using the Toras name to serve his own xenophobic agenda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[51]`
Mówca: **Lucita Azaro**
> ""If I may, Your Grace, why have you never once thrown your own weight behind Su Omina if you support its ideals?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[52]`
Mówca: **Lucita Azaro**
> ""Agreed, Let's get back to the topic at hand. Although...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[53]`
Mówca: **Lucita Azaro**
> ""Future or not, we have no concrete proof Su Omina was behind the attack. All we have is Wehlen's word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`
  - -> `[69]`
  - -> `[59]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then what are your foreign intelligence agents good for? They didn't even predict this would happen!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And it's in Wehlen's interest to pin the blame for the bombing on Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rico has no right using the Toras name to support a xenophobic agenda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know the way these groups function. It's only a short leap from talk to bloodshed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Without them, Wehlen's criminals would be running roughshod all over our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What more do we need? It seems like a cut-and-dried case to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[60]`
Mówca: **Hugo Toras**
> ""That's part of the reason why I've been asking you to visit Iza. Obviously the King should be kept abreast of the group's activities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[61]`
Mówca: **Hugo Toras**
> ""Surely you don't truly feel that way, or you wouldn't have lent your support to the group.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[62]`
Mówca: **Narrator**
> "He smiled warmly at Vina. My daughter looked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""My son is as much of a Toras as you or Princess Vina. And frankly, he should be commended for his efforts to protect the country from miscreants.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""Do you really think the Wehzek miscreants streaming into this country are doing so out of loyalty to you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[65]`
Mówca: **Lucita Azaro**
> ""They've been doing the best they can with their limited resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[66]`
Mówca: **Lucita Azaro**
> ""Exactly. We still haven't ruled out the possibility that President Smolak himself ordered it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Hugo Toras**
> ""Have you not considered the possibility that the attack was staged by Wehlen itself? Or another party interested in weakening both of us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""Or another party interested in weakening the both of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why have we not looked into this ourselves?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Lucita Azaro**
> ""With an increased foreign intelligence budget, we could commission a full investigation into the Zille incident and take measures to prevent such an event from reoccurring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[161]`
  - -> `[163]`
  - -> `[165]`

### Węzeł `[71]`
Mówca: **Lucita Azaro**
> ""Our foreign intelligence agency is hamstrung by its limited resources, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[72]`
Mówca: **Titus Gordion**
> ""Pardon me, ma'am. Major. Duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Narrator**
> "All eyes turned towards the man in the gold blazer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Titus Gordion**
> ""May I point out that you weren't present on the day of the Zille incident. The King and I were.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Titus Gordion**
> ""Prior to His Majesty's arrival, my men and I attempted to clear the square of every conceivable danger. However, we could not be everywhere at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`
  - -> `[78]`
  - -> `[79]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's your point, Mr. Gordion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You missed a bomb. That counts as a massive lapse on the Golden Guard's part.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You helped save our lives back there. No need to make excuses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It shouldn't have been your job to find the bomb. It was Wehlen's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[80]`
Mówca: **Titus Gordion**
> ""It shouldn't have even come to that point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[81]`
Mówca: **Titus Gordion**
> ""Our job is to take every measure to protect the King of Rizia. In that respect, we failed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Titus Gordion**
> ""Our job is to take every measure to protect the King of Rizia. In that respect, we failed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Titus Gordion**
> ""This event has shown how vulnerable you and the royal family truly are, and how ill-equipped my men and I are to seek out and neutralize threats to your safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Titus Gordion**
> ""Therefore, it is my opinion that any emergency funding allocated in the wake of the Zille attack should go towards re-expanding the Golden Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[85]`
Mówca: **Narrator**
> "Lucita's jaw dropped. Hugo eyed Titus uneasily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[86]`
Mówca: **Titus Gordion**
> ""Ma'am, it's important to recognize the historical significance of the Golden Guard. Until quite recently, our role extended far beyond mere guardians of the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Titus Gordion**
> ""Previously, the Guard had the authority to conduct sensitive internal investigations without getting caught up in red tape. The Royal Family and Rizia were both more secure because of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good point. Before giving more funding to foreign intelligence, I need to make sure I'm safe within my own borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What kind of investigations did you have in mind, Captain?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can you not make more efficient use of the funding you already have. Captain?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We need to find out who's behind this bombing. Can the Golden Guard help with that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Titus Gordion**
> ""That's precisely what I'm suggesting. We need to recruit qualified individuals and equip them with the technology to carry out covert surveillance in Iza--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[93]`
Mówca: **Titus Gordion**
> ""Your Majesty, given the resources, we could recruit a number of qualified individuals and equip them with the technology to carry out covert surveillance in Iza--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[94]`
Mówca: **Titus Gordion**
> ""The type of investigation I'm proposing would require more, sir. We need to recruit qualified individuals and equip them with the technology to carry out covert surveillance in Iza--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[95]`
Mówca: **Titus Gordion**
> ""With respect, sir, we don't know whether it's a dead end. And investigating an organization with ties to the royal family is exactly the kind of sensitive mission the Golden Guard was built for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[96]`
Mówca: **Narrator**
> "She, Hugo and Titus glared at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[97]`
Mówca: **Laurento Esquibel**
> ""Excuse me, Your Majesty. My fellow councilors. These stairs never get easier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[100]`
  - -> `[101]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Take a moment, Mr. Esquibel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[99]`
Mówca: **Narrator**
> "The tension was broken by a knock on the door. Laurento came in, clearly out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't interrupt us. We're in the middle of an important security briefing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's going on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Laurento Esquibel**
> ""I understand, Your Majesty. But you're going to want to hear this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Narrator**
> "Laurento sat down. After catching his breath, he continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Laurento Esquibel**
> ""I've just received word from Wehlen's foreign minister. President Smolak plans to make it public that Rizian nationalists were involved in the Zille incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Narrator**
> "Lucita's hands closed into fists."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Laurento Esquibel**
> ""Furthermore, given the contents of the King's speech just prior to the attack, chances are that King Romus himself will come under fire for inciting the violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[110]`
Mówca: **Narrator**
> "He shook his head sadly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Laurento Esquibel**
> ""I did advise you to maintain an air of civility, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`
  - -> `[114]`
  - -> `[115]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Past is past. We have to focus on what we're going to do next.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not question my decisions, Mr. Esquibel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't incite anything. I merely told the truth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry. I must have gotten carried away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[116]`
Mówca: **Laurento Esquibel**
> ""Our relations with Wehlen have been cordial enough that Smolak will not immediately blame the crown. But he will be expecting a response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[117]`
Mówca: **Laurento Esquibel**
> ""My sincerest apologies. Let's focus on how we're going to respond.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[118]`
Mówca: **Laurento Esquibel**
> ""Correct. Wehlen will be expecting a response from us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[119]`
Mówca: **Laurento Esquibel**
> ""On their own, your words might not have been considered incendiary. But their timing was most unfortunate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Laurento Esquibel**
> ""What's done is done. But now Wehlen will be expecting a response from us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[121]`
Mówca: **Laurento Esquibel**
> ""Wehlen will be expecting a response from us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Lucita Azaro**
> ""He's just testing us. His government can't prove anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[127]`
  - -> `[128]`
  - -> `[129]`

### Węzeł `[123]`
Mówca: **Lucita Azaro**
> ""Smolak is just testing us. His government can't prove anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Hugo Toras**
> ""Still, an apology for your harsh language would be in order so as not to inflame relations further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[133]`
  - -> `[134]`
  - -> `[135]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How dare he insult us with these baseless accusations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An apology won't be enough. I have to point the finger somewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This makes me certain that Wehlen was behind the bombing. They're trying to weaken our claim on Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lack of proof never stopped Wehlen from waging war on the Bluds. The Wehzeks are irrational.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll do whatever I have to do to get President Smolak back on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Lucita Azaro**
> ""That's dangerous, Your Majesty. If we begin offering concessions, there are no limits to what Wehlen will demand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[131]`
Mówca: **Lucita Azaro**
> ""You see now why I want to launch an investigation? Imagine the reaction once it comes out that Smolak attacked his own people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[132]`
Mówca: **Hugo Toras**
> ""Yes, I can't imagine any response that would pacify that man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand the need to apologize. What I won't do is blame my own people for what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An apology would be an admission of guilt. I can't do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll do whatever I have to do to get the President back on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[136]`
Mówca: **Lucita Azaro**
> ""That's right. If we let Smolak believe we have something to apologize for, there are no limits to what he'll demand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[137]`
Mówca: **Laurento Esquibel**
> ""People are dead, Your Majesty. Someone must take the blame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[138]`
Mówca: **Lucita Azaro**
> ""That's dangerous, Your Majesty. If we begin offering concessions, there are no limits to what Wehlen will demand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[139]`
Mówca: **Hugo Toras**
> ""Quite right. There's no need to throw Rico to the Wehzek wolves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[140]`
Mówca: **Lucita Azaro**
> ""Then point it right back at Wehlen. Launch an investigation. Call Smolak's bluff.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Laurento Esquibel**
> ""May I ask what the five of you were discussing before I came in?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Laurento Esquibel**
> ""May I ask what the four of you were discussing before I came in?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Hugo Toras**
> ""A question of priorities. Duchess Azaro is requesting funding for a foreign intelligence expansion in order to investigate the Zille incident. Mr. Gordion would rather his Golden Guard be enlarged and given license to conduct its own investigations within Rizia's borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[149]`
  - -> `[157]`
  - -> `[155]`

### Węzeł `[147]`
Mówca: **Vina Toras**
> ""Our security response to the Zille incident. Duchess Azaro is requesting funds for an expansion of foreign intelligence to conduct an investigation in Wehlen, while Captain Gordion would prefer the Golden Guard be expanded and given license to investigate threats within Rizia's borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[149]`
  - -> `[157]`
  - -> `[148]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well summarized, Vina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, taking up Titus' offer to conduct a thorough investigation of Su Omina could help pacify Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I fund Duchess Azaro's investigation and it exposes Wehzek wrongdoing, Smolak won't have a leg to stand on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[151]`
Mówca: **Hugo Toras**
> ""At the expense of Rico's dignity, and thus the dignity of House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Titus Gordion**
> ""Rest assured that if the Duke of Iza has nothing to hide, his dignity will remain intact.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[153]`
Mówca: **Laurento Esquibel**
> ""A tricky needle to thread, Your Majesty. Pursuing such an investigation might lead the President to think you're undermining his authority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[154]`
Mówca: **Vina Toras**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the summary, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[156]`
Mówca: **Narrator**
> "Laurento raised an eyebrow at Titus, pleasantly surprised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To be honest, I'd rather not waste our budget on either of those.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Titus Gordion**
> ""A grave mistake, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How much would that cost us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Lucita Azaro**
> ""A significant portion of our emergency funds. But it'll be worth it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what if it turns out Rizian nationalists were responsible after all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Lucita Azaro**
> ""Then they'll be found and dealt with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More budget demands? This country is not made of money, Duchess Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Lucita Azaro**
> ""If the truth is not revealed, it will cost us even more dearly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like a good idea to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Lucita Azaro**
> ""Then you have better judgement than your father did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[167]`
Mówca: **Lucita Azaro**
> ""For once we agree, Captain. Going along with Wehlen's accusations without even trying to gather our own evidence would only give Smolak ammunition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[168]`
Mówca: **Lucita Azaro**
> ""If Wehlen has nothing to hide, they will welcome our assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[169]`
Mówca: **Laurento Esquibel**
> ""Showing Wehlen that you are serious about investigating the potential terrorists makes diplomatic sense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Lucita Azaro**
> ""Let's not forget His Majesty has a personal history with the organization. Uncovering any unsavory information could harm the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedSuOmina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Lucita Azaro**
> ""I agree it's dangerous to investigate an organization that His Majesty has blood ties to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Titus Gordion**
> ""But officially clearing Su Omina's name would be a boon for both the group and the Kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[176]`
Mówca: **Hugo Toras**
> ""Sending investigators to Zille would also shift the focus away from Su Omina and the royal family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[177]`
Mówca: **Hugo Toras**
> ""My pleasure. His Majesty already knows which course of action I'd prefer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[178]`
Mówca: **Laurento Esquibel**
> ""Interesting initiative, Mr. Gordion. Following up on Wehlen's leads with our own internal investigation would certainly make diplomatic sense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[179]`
Mówca: **Titus Gordion**
> ""Precisely. If it were up to me, I would recruit a number of qualified individuals and equip them with the technology to carry out covert surveillance in Iza--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[180]`
Mówca: **Laurento Esquibel**
> ""So, Your Majesty. Will the Crown be funding one of these proposed expansions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[181]`
**[WYBÓR GRACZA: ""Let's go with Lucita's proposal. Expand our intelligence force and send a team of investigators to Wehlen." [-4 Budget]"]** — Mówca: **Player_Romus**
> ""Let's go with Lucita's proposal. Expand our intelligence force and send a team of investigators to Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[182]`
**[WYBÓR GRACZA: ""Captain Gordion, I admire your initiative. I'll provide support to expand the Guard to a division-sized unit. With these extra resources, you'll conduct a full investigation into Su Omina's activities." [-4 Budget]"]** — Mówca: **Player_Romus**
> ""Captain Gordion, I admire your initiative. I'll provide support to expand the Guard to a division-sized unit. With these extra resources, you'll conduct a full investigation into Su Omina's activities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry to disappoint you both, but I've decided not to fund either of your investigations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[184]`
Mówca: **Titus Gordion**
> ""Thank you for your trust in the Golden Guard, sir. We won't fail you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[185]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty. I promise my department will get results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded = true; RiziaDLC.Turn03_Security_LucitaLeadsInvestigation = true;  RiziaDLCSupport.Journal_Turn03_Security_FundForeignIntelligence = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] = true;
Variable["RiziaDLC.Turn03_Security_LucitaLeadsInvestigation"] = true;
Variable["RiziaDLCSupport.Journal_Turn03_Security_FundForeignIntelligence"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded = true; RiziaDLC.Turn03_Security_TitusLeadsInvestigation = true;
RiziaDLC.Army_Unit_GoldenGuard_Total += 1;
RiziaDLC.Situation_Order_KingsGuardForce_Limited = false;
RiziaDLC.Situation_Order_KingsGuardForce_Powerful = true;
RiziaDLC.Security_GoldenGuard_InvestigateSO = true; RiziaDLCSupport.Journal_Turn03_Security_FundGoldenGuard = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] = true;
Variable["RiziaDLC.Turn03_Security_TitusLeadsInvestigation"] = true;
Variable["RiziaDLC.Army_Unit_GoldenGuard_Total"] = Variable["RiziaDLC.Army_Unit_GoldenGuard_Total"] + 1;
Variable["RiziaDLC.Situation_Order_KingsGuardForce_Limited"] = false;
Variable["RiziaDLC.Situation_Order_KingsGuardForce_Powerful"] = true;
Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] = true;
Variable["RiziaDLCSupport.Journal_Turn03_Security_FundGoldenGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[188]`
Mówca: **Laurento Esquibel**
> ""It seems the next steps are quite clear, or was there any other subject that needed discussion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Titus Gordion**
> ""Nothing more to discuss, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`
  - -> `[201]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[196]`
Mówca: **Lucita Azaro**
> ""I'm quite satisfied with our results today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`
  - -> `[201]`

### Węzeł `[197]`
Mówca: **Hugo Toras**
> ""I'll see you out. I have nothing more to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`
  - -> `[201]`

### Węzeł `[198]`
Mówca: **Vina Toras**
> ""I think that was everything, wasn't it, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`
  - -> `[201]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, you're all dismissed. Enjoy the rest of your day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're done when I say we're done. But yes, we are done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This meeting is adjourned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[205]`
Mówca: **Narrator**
> "The others began filing out of the room. Titus stayed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[206]`
Mówca: **Narrator**
> "The others began filing out of the room. Lucita stayed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[213]`
Mówca: **Narrator**
> "She took off her cap and looked me in the eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Lucita Azaro**
> ""Allow me to express my gratitude once more, Your Majesty. As a newcomer to this council, it means a lot that you would place your trust in me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`
  - -> `[223]`
  - -> `[393]`

### Węzeł `[215]`
Mówca: **Titus Gordion**
> ""Thank you once again, Your Majesty. You have the Golden Guard's undying loyalty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[233]`
  - -> `[241]`
  - -> `[234]`

### Węzeł `[216]`
Mówca: **Narrator**
> "He walked up to me and looked me in the eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I expect results, Duchess Azaro. Don't disappoint me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't mention it. Your counsel is far more valuable than that of our doddering elders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[219]`
**[WYBÓR GRACZA: ""Now that you have the funding, I'd like your help with an investigation of a more sensitive nature." [Investigate Poisoning]"]** — Mówca: **Player_Romus**
> ""Now that you have the funding, I'd like your help with an investigation of a more sensitive nature.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your father would be proud, Major.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[221]`
Mówca: **Lucita Azaro**
> ""I would be honored. What is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`
  - -> `[398]`

### Węzeł `[222]`
Mówca: **Lucita Azaro**
> ""I won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[226]`
Mówca: **Lucita Azaro**
> ""Thank you, Lieutenant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Lucita Azaro**
> ""Shh. They're just outside this door.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Narrator**
> "She reached out and gave me a handshake. Her hand lingered in mine for just a second longer than normal before she withdrew it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[229]`
Mówca: **Lucita Azaro**
> ""I'll update you soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Narrator**
> "She put her cap back on and hurriedly left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are the King's guard, Mr. Gordion. Your loyalty should not be contingent on funding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Titus Gordion**
> ""No. Of course not. I beg your pardon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I expect results, Titus. Don't disappoint me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[237]`
**[WYBÓR GRACZA: ""Good. Because there's one other investigation I'd like you to conduct for me." [Investigate Poisoning]"]** — Mówca: **Player_Romus**
> ""Good. Because there's one other investigation I'd like you to conduct for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[238]`
Mówca: **Titus Gordion**
> ""Is this in regard the murder investigation you previously alluded to?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[242]`
  - -> `[430]`

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. I'd like to know exactly how my father died.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[240]`
Mówca: **Titus Gordion**
> ""I swear on my life that I will not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You already demonstrated that loyalty back in Zille. This is the least I can do for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Precisely. It's imperative that I receive any and all information surrounding the circumstances of my father's death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Narrator**
> "Titus eyes grew wide. He lowered the volume of his voice so that only I could hear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Titus Gordion**
> ""I was also there that night, as you already know. Like you, I too find the circumstances suspicious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[245]`
Mówca: **Narrator**
> "Titus froze in place. He spoke in a low voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[246]`
Mówca: **Titus Gordion**
> ""Again, I was only fulfilling my duty. But much appreciated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[247]`
Mówca: **Narrator**
> "Titus gave a dutiful bow and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[248]`
Mówca: **Titus Gordion**
> ""As you know, I was there in the palace when it happened. And believe me, I have some questions of my own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[249]`
Mówca: **Titus Gordion**
> ""Should everyone who was present that night be considered a suspect?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Almost everyone. Leave my butler out of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Hugo, the Grand Wiseman, my mother, Lucita Azaro. And Pabel, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[252]`
Mówca: **Narrator**
> "The others filed out of the room. Hugo stayed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[258]`
  - -> `[301]`
  - -> `[262]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn03_Security_TitusInvestigateMurderNoPabel = true;
RiziaDLC.InvestigatePoisoning_NoPabel = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn03_Security_TitusInvestigateMurderNoPabel"] = true;
Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[254]`
Mówca: **Narrator**
> "Titus nodded seriously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[255]`
Mówca: **Titus Gordion**
> ""Consider it handled. Expect an update soon along with the progress on Su Omina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn03_Security_TitusInvestigateMurderEveryone = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn03_Security_TitusInvestigateMurderEveryone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is it, Your Grace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have anything against Rico personally. But Wehlen needs a scapegoat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whether or not Su Omina was involved in Zille, I want Rico to rein them in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[263]`
Mówca: **Hugo Toras**
> ""Come to Iza, Romus. Speak to your cousin. You're long overdue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Narrator**
> "Hugo slowly shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[265]`
Mówca: **Narrator**
> "Without waiting for an answer, he left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were right. It's about time I visited Rico in Iza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Narrator**
> "Hugo slowly nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
Mówca: **Hugo Toras**
> ""He'd be overjoyed. I'll arrange everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[269]`
Mówca: **Narrator**
> "Hugo was quiet for a moment, then looked me in the eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[270]`
Mówca: **Narrator**
> "My uncle looked me in the eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[271]`
Mówca: **Narrator**
> "He turned and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[272]`
Mówca: **Narrator**
> "She looked meaningfully at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`
  - -> `[273]`
  - -> `[274]`
  - -> `[280]`

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My days with that group are long over. We have to make it clear that they don't represent the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know Su Omina. They would never commit such a reprehensible act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedSuOmina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[278]`
Mówca: **Lucita Azaro**
> ""The continued involvement of one Rico Toras would suggest otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[279]`
Mówca: **Hugo Toras**
> ""I told you, Duchess Azaro, I've already spoken to Rico. He had absolutely nothing to do with what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[289]`
  - -> `[296]`
  - -> `[297]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What evidence are they basing this on? Anyone can scream 'For the King.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[281]`
Mówca: **Lucita Azaro**
> ""They've grown more extreme since your day. Rico Toras would know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[282]`
Mówca: **Narrator**
> "She looked meaningfully at Hugo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`
  - -> `[280]`
  - -> `[283]`
  - -> `[284]`

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The views of those extremists do not represent those of the throne. We have to make that clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What exactly has your son Rico been up to in Iza, Your Grace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Lucita Azaro**
> ""Unclear. This is all they've told us. The Duke of Iza might be able to clarify the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[286]`
Mówca: **Hugo Toras**
> ""I've already spoken to Rico. He had absolutely nothing to do with what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[289]`
  - -> `[296]`
  - -> `[297]`

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why was I not included in this conversation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Hugo Toras**
> ""Because it was superfluous. Su Omina promotes Rizian values. Terrorism is not part of their mission.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What were Su Omina's activities like in the months leading up to the attack?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Lucita Azaro**
> ""Nothing out of the ordinary. A few marches and a rally held at the Duke of Iza's mansion in protest of the new Dastnurist Grandsanctuary expansion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[294]`
Mówca: **Lucita Azaro**
> ""Nothing out of the ordinary. A few marches.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[295]`
Mówca: **Hugo Toras**
> ""All peaceful events held to promote Rizian values. Su Omina is not and has never been a violent organization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe him. This has Wehlen's fingerprints all over it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How can you trust him? Of course he wouldn't admit to being involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[298]`
Mówca: **Hugo Toras**
> ""I trust him because I trust the organization. Su Omina promotes Rizian values. Its aims are peaceful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Hugo Toras**
> ""A sight more likely than a peaceful group of Rizians suddenly taking up bomb making.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Lucita Azaro**
> ""I should clarify, the group's official activities have never been violent. But individual members have printed leaflets calling for a more... 'creative' solution to the Wehzek problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedSuOmina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know I will always support Su Omina. If I condemn them, I'm condemning myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_ImpasseLight", "R_ImpasseLight_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_ImpasseLight","R_ImpasseLight_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[309]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`
  - -> `[183]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget > 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[312]`

### Węzeł `[310]`
Mówca: **Narrator**
> "Lucita clasped her hands together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[311]`
Mówca: **Narrator**
> "Titus forcefully saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hate to disappoint both of you, but our treasury can't afford either investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 4;
RiziaDLC.Relations_Lucita_Romance -= 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 4;
Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 4;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[315]`
Mówca: **Titus Gordion**
> ""Rest assured this will not affect my own commitment to your family's security, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`
  - -> `[319]`

### Węzeł `[316]`
Mówca: **Narrator**
> "Titus bowed his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It had better not, Captain Gordion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's nothing personal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A true professional. I appreciate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[320]`
Mówca: **Narrator**
> "Lucita scowled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[321]`
Mówca: **Lucita Azaro**
> ""I'm expecting results, Mr. Gordion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[322]`
Mówca: **Hugo Toras**
> ""And I'm expecting tact and discretion, needless to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`
  - -> `[325]`

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't be afraid to get your hands dirty, Titus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As am I. House Toras must appear clean in all this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop hassling my guard. My trust in Titus should be enough reassurance for you both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[326]`
Mówca: **Narrator**
> "Lucita and Titus looked at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[327]`
Mówca: **Lucita Azaro**
> ""I see, Your Majesty. Thank you for considering my proposal nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
Mówca: **Titus Gordion**
> ""Rest assured I remain as devoted to your security as ever, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[329]`
Mówca: **Hugo Toras**
> ""Saving money is always prudent. We don't know what lies ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[330]`
Mówca: **Laurento Esquibel**
> ""You will, however, still have to draft a public response to Wehlen's statement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[332]`
  - -> `[333]`

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you have any suggestions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't dignify their accusations with a reply.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know exactly what to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[334]`
Mówca: **Laurento Esquibel**
> ""The international community will be anticipating it, Your Majesty. A lack of a response is also a response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`
  - -> `[353]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedSuOmina))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[338]`
Mówca: **Hugo Toras**
> ""The group is unfairly maligned. If more people actually attended their events, they'd see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[339]`
Mówca: **Hugo Toras**
> ""That's the message the public needs to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[340]`
Mówca: **Laurento Esquibel**
> ""There's still the matter of the King's public response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[332]`
  - -> `[333]`

### Węzeł `[341]`
Mówca: **Hugo Toras**
> ""Would it? Or would it cast unnecessary suspicions on the royal family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[342]`
Mówca: **Laurento Esquibel**
> ""If you wanted to go further, you could emphasize that Su Omina is a 'lone wolf' that does not represent the views of the crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`
  - -> `[345]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  or  Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  or  Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[346]`
Mówca: **Laurento Esquibel**
> ""I suggest you tell the truth. You take Wehlen's intelligence seriously and will be conducting your own investigation into the suspected perpetrators.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Laurento Esquibel**
> ""I trust you to make the diplomatically correct choice, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[348]`
Mówca: **Laurento Esquibel**
> ""Emphasizing, of course, that Su Omina is a 'lone wolf' that does not represent the views of the crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[349]`
Mówca: **Narrator**
> "Hugo sniffed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[350]`
Mówca: **Hugo Toras**
> ""Or express your confidence that the group is innocent. Which it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[351]`
Mówca: **Laurento Esquibel**
> ""I suggest a boilerplate statement, expressing Rizia's condolences for the Wehzek victims and our wishes that the perpetrators be brought to justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then help me out. What do I say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right. I'll draft the statement after this meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[354]`
Mówca: **Narrator**
> "Hugo sniffed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[355]`
Mówca: **Hugo Toras**
> ""Or express your confidence that the group is innocent. Which it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[356]`
Mówca: **Hugo Toras**
> ""That's the message the public needs to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[357]`
Mówca: **Narrator**
> "Hugo spread his hands wide."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[358]`
Mówca: **Hugo Toras**
> ""It would do the group no favors to have an old man like me in the spotlight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[359]`
Mówca: **Hugo Toras**
> ""They need youth, vitality. They are the future of Rizia, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`
  - -> `[362]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[363]`
Mówca: **Narrator**
> "Lucita nodded impatiently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
  - -> `[366]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Laurento Esquibel**
> ""I would also advise you to include an apology for your words in Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[368]`
Mówca: **Laurento Esquibel**
> ""I would advise you not to confirm or deny Su Omina's guilt at this time. Not until more is known.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[369]`
Mówca: **Laurento Esquibel**
> ""I find it unwise to confirm or deny Su Omina's innocence before more information is known. But I'll leave it to you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[373]`
Mówca: **Laurento Esquibel**
> ""And, well, do consider including an apology for your speech in Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[374]`
Mówca: **Narrator**
> "Hugo sniffed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[375]`
Mówca: **Narrator**
> "I picked up a pen and began drafting my response to Wehlen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");
AddConversant("Vina Toras");
AddConversant("Hugo Toras"); AddConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");
AddConversant("Vina Toras");
AddConversant("Hugo Toras");
AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");
AddConversant("Hugo Toras"); AddConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");
AddConversant("Hugo Toras");
AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[378]`
Mówca: **Lucita Azaro**
> ""Gentlemen!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[379]`
Mówca: **Narrator**
> "Everyone automatically fell silent as Lucita strode through the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[380]`
Mówca: **Narrator**
> "She was dressed in her army major's blazer, with two stars prominently displayed above her right breast pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Narrator**
> "Now that crisis had struck, her entire bearing had changed. She had a commanding air about her that recalled her father."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[386]`
  - -> `[21]`
  - -> `[20]`

### Węzeł `[385]`
Mówca: **Narrator**
> "Now that crisis had struck, her entire bearing had changed. She had a commanding air about her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`
  - -> `[21]`
  - -> `[20]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[389]`
Mówca: **Narrator**
> "Lucita greeted Vina with an impatient half-bow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[390]`
Mówca: **Lucita Azaro**
> ""A pleasure as usual, Your Highness. Now, let's not waste any more time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn03_Bronaz_BeatriceVisit = true; RiziaDLCSupport.Reports_Turn03_Jales_FriendshipDayVigil = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn03_Bronaz_BeatriceVisit"] = true;
Variable["RiziaDLCSupport.Reports_Turn03_Jales_FriendshipDayVigil"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn03_RH_BeatriceVisit = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn03_RH_BeatriceVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[395]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[396]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want to find out exactly how my father died.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[397]`
Mówca: **Narrator**
> "She shook my hand firmly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually... never mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[399]`
Mówca: **Narrator**
> "She gave me a puzzled look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[400]`
Mówca: **Lucita Azaro**
> ""Very well, Your Majesty. I hope you know you can come to me with any request. Or anything that's on your mind at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[401]`
Mówca: **Narrator**
> "She froze in place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[402]`
Mówca: **Lucita Azaro**
> ""It was a heart attack. He was an old man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`
  - -> `[407]`

### Węzeł `[403]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Hugo Toras");
RemoveConversant("Vina Toras");
RemoveConversant("Laurento Esquibel");
RemoveConversant("Titus Gordion");
// Removes the conversant with the character name in database)*
- **Efekt (`userScript`):** `RemoveConversant("Hugo Toras");
RemoveConversant("Vina Toras");
RemoveConversant("Laurento Esquibel");
RemoveConversant("Titus Gordion");
-- Removes the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Hugo Toras");
RemoveConversant("Vina Toras");
RemoveConversant("Laurento Esquibel");
RemoveConversant("Lucita Azaro");
// Removes the conversant with the character name in database)*
- **Efekt (`userScript`):** `RemoveConversant("Hugo Toras");
RemoveConversant("Vina Toras");
RemoveConversant("Laurento Esquibel");
RemoveConversant("Lucita Azaro");
-- Removes the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");
RemoveConversant("Vina Toras");
RemoveConversant("Laurento Esquibel");
RemoveConversant("Lucita Azaro");
// Removes the conversant with the character name in database)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");
RemoveConversant("Vina Toras");
RemoveConversant("Laurento Esquibel");
RemoveConversant("Lucita Azaro");
-- Removes the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[406]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have reason to believe the causes were less than natural.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[407]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't question me. Just open an investigation. Discreetly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[408]`
Mówca: **Lucita Azaro**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[409]`
Mówca: **Lucita Azaro**
> ""It won't be easy with the Golden Guard around, but I can commission a small team.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[410]`
Mówca: **Lucita Azaro**
> ""Sorry, Your Majesty. I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[411]`
Mówca: **Lucita Azaro**
> ""Am I to assume everyone who was in the Palace the day of his death is a suspect?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`
  - -> `[413]`

### Węzeł `[412]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Almost everyone. Leave my butler out of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Titus, Hugo, my mother and the Grand Wiseman. And Pabel, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel = true;
RiziaDLC.PoisonInvestigator_Lucita = true;
RiziaDLC.InvestigatePoisoning_NoPabel = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel"] = true;
Variable["RiziaDLC.PoisonInvestigator_Lucita"] = true;
Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[416]`
Mówca: **Narrator**
> "She nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[417]`
Mówca: **Lucita Azaro**
> ""I appreciate your trust in me. Consider it handled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[419]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Hugo -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[422]`
Mówca: **Vina Toras**
> ""Queen Lyza always said monarchy was incompatible with nationalism. 'The crown knows no borders.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[47]`
  - -> `[48]`
  - -> `[49]`

### Węzeł `[423]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[424]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course they would say that. It's clear that President Smolak was behind this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[425]`
Mówca: **Hugo Toras**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[426]`
Mówca: **Hugo Toras**
> ""Besides, I've already spoken to Rico. He had absolutely nothing to do with what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[289]`
  - -> `[296]`
  - -> `[297]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_SecurityTitus_DiscussPossibleMurder == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`
  - -> `[429]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_SecurityTitus_DiscussPossibleMurder == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn02_SecurityTitus_DiscussPossibleMurder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn02_SecurityTitus_DiscussPossibleMurder == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn02_SecurityTitus_DiscussPossibleMurder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[430]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Exactly. I believe that there's reason to suspect that the late king died under questionable circumstances. And I need you to dig up everything there is to know about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[431]`
Mówca: **Narrator**
> "Eyes wide, Titus hushed his voice, ensuring our conversation was confidential."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[432]`
Mówca: **Titus Gordion**
> ""If there's evidence of wrongdoing, should we regard everyone in the palace at the time as a potential suspect?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[433]`
Mówca: **Titus Gordion**
> ""You're not the only one troubled by your father's untimely death. As someone present on that fateful night, it's reassuring to know you've taken an interest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[434]`
Mówca: **Titus Gordion**
> ""In the event of incriminating evidence, do we need to treat anyone who was in the palace as a potential suspect?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[435]`
Mówca: **Titus Gordion**
> ""Yes, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`
  - -> `[437]`
  - -> `[438]`

### Węzeł `[436]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd like to know exactly how my father died. I have reason to believe that his death was no accident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd like you to initiate a murder inquiry, with a specific focus on the circumstances surrounding my father's demise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe that there's reason to suspect that the late king died under questionable circumstances. And I need you to dig up everything there is to know about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[439]`
Mówca: **Titus Gordion**
> ""In any case, expect an update soon on the progress on Su Omina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[440]`
Mówca: **Hugo Toras**
> ""Excuse me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[441]`
Mówca: **Hugo Toras**
> ""Captain Gordion. I am all for the expansion of the Golden Guard, but not if you insist on using it to chase a dead end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[442]`
Mówca: **Lucita Azaro**
> ""Perhaps so, Captain Gordion, but the attack took place in Wehlen. Any resources that go towards investigating it should be allocated there, not within Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleSecurityDebriefFinished = true;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 5)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleSecurityDebriefFinished"] = true;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[444]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The crown will not provide further assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_FundNone = true; 
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 1;
RiziaDLC.Relations_Lucita_Romance -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Security_FundNone"] = true;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 1;
Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[446]`
Mówca: **Titus Gordion**
> ""Your Majesty, you recently conveyed your wish to strengthen our ranks and allow us to assume additional duties. This incident would serve as an excellent opportunity to demonstrate our capabilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[447]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.SecurityTitus_SupportGoldenGuard == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`
  - -> `[449]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.SecurityTitus_SupportGoldenGuard == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.SecurityTitus_SupportGoldenGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.SecurityTitus_SupportGoldenGuard == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.SecurityTitus_SupportGoldenGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[450]`
Mówca: **Lucita Azaro**
> ""I'm sorry, but why wasn't I privy to this discussion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[451]`
Mówca: **Lucita Azaro**
> ""The expansion of the Golden Guard is a security-related issue, which, as Councilor of War and Internal Security, falls under my purview.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`
  - -> `[454]`
  - -> `[453]`
  - -> `[452]`

### Węzeł `[452]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our discussion wasn't intentionally concealed from you, nor was it pre-planned. Forgive me for not informing you sooner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[453]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not your place to question whom I talk to and when. If there's information worth knowing, I'll ensure it's shared when I deem it appropriate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It slipped my mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus and I spoke about it recently. I've been meaning to bring it up with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[457]`
Mówca: **Narrator**
> "Lucita scowled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[458]`
Mówca: **Lucita Azaro**
> ""Uh-huh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.SecurityTitus_SupportGoldenGuard == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`
  - -> `[461]`

### Węzeł `[460]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.SecurityTitus_SupportGoldenGuard == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.SecurityTitus_SupportGoldenGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[461]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.SecurityTitus_SupportGoldenGuard == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.SecurityTitus_SupportGoldenGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[462]`
Mówca: **Titus Gordion**
> ""I must say... last we spoke, You Majesty, I was under the impression that the Golden Guard had your full support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[463]`
Mówca: **Titus Gordion**
> ""Our conversation left me with quite optimistic expectations, and it's disappointing that they won't be coming to fruition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[464]`
Mówca: **Titus Gordion**
> ""I hope this isn't indicative of future commitments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`
  - -> `[465]`
  - -> `[466]`
  - -> `[467]`

### Węzeł `[465]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough with your baseless insinuations. Circumstances change, and I must make decisions in the best interests of Rizia, not those of the Golden Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[466]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I respect you as my guardsman, Captain, but this is an internationally sensitive incident. We've got to treat it with the seriousness it deserves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sometimes even the best-laid plans can take unexpected turns. I'll try to make it up to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you'll continue to have my full support. I simply agree with Duchess Azaro on the course of how this investigation should proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[469]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus -= 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.SecurityTitus_SupportGoldenGuard == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`
  - -> `[472]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.SecurityTitus_SupportGoldenGuard == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.SecurityTitus_SupportGoldenGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.SecurityTitus_SupportGoldenGuard == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.SecurityTitus_SupportGoldenGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[473]`
Mówca: **Titus Gordion**
> ""However, I must admit my disappointment, considering your previous expression of full support for the Golden Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`
  - -> `[474]`
  - -> `[475]`
  - -> `[476]`

### Węzeł `[474]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My support for the Golden Guard remains as steadfast as ever, and your insinuations are unfounded. Circumstances change, and decisions must be made in the best interest of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[475]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I must admit my disappointment in you, Captain. You, of all people, should know your place and respect the decisions made for the greater good of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[476]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Life has a way of throwing surprises into our best-laid plans. I'll try to make it up to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[477]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you'll continue to have my full support. It's just that I share Duchess Azaro's perspective on the way this investigation ought to move forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.SecurityTitus_SupportGoldenGuard == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`
  - -> `[481]`

### Węzeł `[480]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.SecurityTitus_SupportGoldenGuard == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.SecurityTitus_SupportGoldenGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[481]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.SecurityTitus_SupportGoldenGuard == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.SecurityTitus_SupportGoldenGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[482]`
Mówca: **Lucita Azaro**
> ""Very well. But in the future, please include me in confidential internal security meetings. I'd appreciate being a part of the conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`
  - -> `[484]`
  - -> `[483]`

### Węzeł `[483]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'll be included in such meetings if I deem it necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll consider it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Next time I'll be sure you're included. This was an isolated incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[486]`
Mówca: **Narrator**
> "Lucita released an exasperated sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[487]`
Mówca: **Lucita Azaro**
> ""Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[488]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty. In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[489]`
Mówca: **Narrator**
> "Lucita let out a sigh of exasperation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[490]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[491]`
Mówca: **Lucita Azaro**
> ""Nevertheless...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[492]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Enable_Policy_RD_Order_MaveNortusIntelHub = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Enable_Policy_RD_Order_MaveNortusIntelHub"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[493]`
Mówca: **Narrator**
> "Lucita gritted her teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[494]`
Mówca: **Lucita Azaro**
> ""What you call 'red tape,' I call accountability. You are asking for permission to act outside the law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[495]`
Mówca: **Titus Gordion**
> ""I am asking for permission to become a more agile, flexible arm of the law than any division currently in operation. This will benefit us both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`
  - -> `[90]`
  - -> `[91]`

### Węzeł `[496]`
Mówca: **Titus Gordion**
> ""With a full-fledged division under my command, I could also easily send a team to Iza to confirm or rule out Su Omina's involvement in what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[497]`
Mówca: **Lucita Azaro**
> ""All well and good, Your Majesty, but the fact remains that national security is not Captain Gordion's area of expertise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[498]`
Mówca: **Lucita Azaro**
> ""Now that the subject has been broached, I will gently point out that national security is not Captain Gordion's area of expertise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[499]`
Mówca: **Titus Gordion**
> ""Your Majesty, you recently conveyed your apprehension over re-expanding the Golden Guard's ranks and duties. But this incident would serve as an excellent opportunity for us to demonstrate our capabilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[500]`
Mówca: **Narrator**
> "Lucita spoke up sweetly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`
  - -> `[503]`

### Węzeł `[502]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[503]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[504]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCText.GoldenGuardUpdate = "Under the reign of King Romus Toras, the Golden Guard was enlarged into a division-sized unit and given expanded duties.")*
- **Efekt (`userScript`):** `Variable["RiziaDLCText.GoldenGuardUpdate"] ="Under the reign of King Romus Toras, the Golden Guard was enlarged into a division-sized unit and given expanded duties.";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[505]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Laurento Esquibel");)*
- **Efekt (`userScript`):** `AddConversant("Laurento Esquibel");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[506]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[507]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Titus = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PoisonInvestigator_Titus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[508]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[509]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Getting an emergency briefing after a bombing attack", "Council Chambers", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Getting an emergency briefing after a bombing attack","Council Chambers","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
