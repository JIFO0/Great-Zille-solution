# Sordland/Turn03/Gus Intro Talk

- **ID konwersacji:** `42`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/042_Gus_Intro_Talk.md`
- **Liczba węzłów dialogowych:** 252
- **Liczba wyborów gracza:** 67

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[35]** Gus Manger

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn01_InfrastructureProject_Invest`
- `BaseGame.Decision_Turn01_PersonalInvestment_DontSpend`
- `BaseGame.Decision_Turn01_PersonalInvestment_Spend2`
- `BaseGame.Decision_Turn01_PersonalInvestment_Spend3`
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Prologue_Party_CampaignedForAlphonso`
- `BaseGame.Prologue_Party_Takeover_Backstab`
- `BaseGame.Prologue_Party_Takeover_Diplomatic`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn02_InT_Corporation_SordishState`
- `BaseGame.Turn02_InT_Corporation_TaurusHolding`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.RuralDevelopment_Interest`
- `BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention`
- `BaseGameIsolated.Turn03_EnT_Gasom_RespondedToInfraProject`
- `BaseGameIsolated.Turn03_EnT_Gasom_RespondedToPersonalInvestment`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[41] Sordland/Turn03/EnT_GasomProposal** (../Turn_03/041_EnT_GasomProposal.md), Węzeł `[21]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[9]` | **"“You still have to prove that you make returns on your deals. Our investment in Ar..."** | `[157]` **Gus Manger**: ""I have faith that you won't lea..." | `Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == false` | *Brak zmian stanu* | `[10]` **Gus Manger**: "“I never claim to see the future..." |
| `[11]` | **"“The discussions were lively during the highway contract award. I'm willing to hea..."** | `[157]` **Gus Manger**: ""I have faith that you won't lea..." | `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`<br>`Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true` | *Brak zmian stanu* | `[12]` **Gus Manger**: "“And I'm willing to present them..." |
| `[31]` | **"“The government has clear control over SSC's operations. We wouldn't get that with..."** | `[28]` **Gus Manger**: "“The corruption in that organiza..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Gus Manger**: "“It might seem like we have cont..." |
| `[32]` | **"“I have to take the safe option this early in the term, Mr. Manger.”"** | `[28]` **Gus Manger**: "“The corruption in that organiza..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Gus Manger**: "“Understandable. But we have to ..." |
| `[33]` | **"“I think it's time we let fresh -- and fast -- new faces have a shot.”"** | `[39]` **Gus Manger**: "“They need to walk before they c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Gus Manger**: "“Calculated risks, Mr. President..." |
| `[34]` | **"“Status quos are meant to be broken. I want to be the change maker during my term.”"** | `[39]` **Gus Manger**: "“They need to walk before they c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Gus Manger**: "“I respect that. Most of my life..." |
| `[35]` | **"“It seemed the least risky option. We need safe bets.”"** | `[30]` **Gus Manger**: "“I'm glad you contracted Underha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Gus Manger**: "“It's a pity you only had three ..." |
| `[36]` | **"“The workers need to be protected somehow. We can't ignore that problem.”"** | `[30]` **Gus Manger**: "“I'm glad you contracted Underha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Gus Manger**: "“We won't ignore it, Mr. Preside..." |
| `[42]` | **"“The SSC is one of our national treasures. It rebuilt most of Sordland in the '30s.”"** | `[28]` **Gus Manger**: "“The corruption in that organiza..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Gus Manger**: "“Yes, nobody can deny the SSC's ..." |
| `[52]` | **"“He must really care about Gasom.”"** | `[50]` **Gus Manger**: "“To be 100 percent honest, Mr. P..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Gus Manger**: "“It's one of Sordland's most sig..." |
| `[53]` | **"“Does the average working-class man in Narbel really give a damn about that?”"** | `[174]` **Gus Manger**: "“You make one wrong move, and th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Gus Manger**: "“They don't, but it affects them..." |
| `[54]` | **"“We won't know until they complete the project. There's no reason to be negative b..."** | `[39]` **Gus Manger**: "“They need to walk before they c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Gus Manger**: "“Time will tell. I also hope tha..." |
| `[57]` | **"“I still have my doubts, but I'll take your word for now.”"** | `[30]` **Gus Manger**: "“I'm glad you contracted Underha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Gus Manger**: "“Kris Schar and the company stil..." |
| `[64]` | **"“We worked closely in the past and are on friendly terms. I'm open to see what we ..."** | `[63]` **Gus Manger**: "“Admittedly, I'm biased. But I d..." | `Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true` | *Brak zmian stanu* | `[88]` **Gus Manger**: "“As you know, he and I go back a..." |
| `[66]` | **"“What's in the past shouldn't shape our future. Especially if a good deal can be t..."** | `[50]` **Gus Manger**: "“To be 100 percent honest, Mr. P..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Gus Manger**: "“Yes, and Sordland needs any dea..." |
| `[67]` | **"“The feeling is mutual. Both of us are only here because of you, Gus.”"** | `[50]` **Gus Manger**: "“To be 100 percent honest, Mr. P..." | `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == false` | *Brak zmian stanu* | `[70]` **Gus Manger**: "“I do my best. Got a close influ..." |
| `[76]` | **"“I wasn't against him early on. Quite the opposite.”"** | `[50]` **Gus Manger**: "“To be 100 percent honest, Mr. P..." | `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == false) == false` | *Brak zmian stanu* | `[77]` **Gus Manger**: ""I still remember the day the pa..." |
| `[79]` | **"“The fact that you managed to get Rizia entangled in this is surprising.”"** | `[157]` **Gus Manger**: ""I have faith that you won't lea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Gus Manger**: "“I hate to brag, but I was the o..." |
| `[80]` | **"“If he needs to be hands-on as chairman, then the business must not be doing well.”"** | `[63]` **Gus Manger**: "“Admittedly, I'm biased. But I d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Gus Manger**: "“It's true that it's seen a lack..." |
| `[81]` | **""What's so extraordinary about another corporation trying to make a hefty profit o..."** | `[63]` **Gus Manger**: "“Admittedly, I'm biased. But I d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Gus Manger**: "“Human greed is undeniable. I al..." |
| `[85]` | **"“I have no ill-will against Ewald Alphonso.”"** | `[63]` **Gus Manger**: "“Admittedly, I'm biased. But I d..." | `(Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false` | *Brak zmian stanu* | `[89]` **Gus Manger**: "“Why should you?”" |
| `[92]` | **""Not exactly the most pleasant location for a meeting, is it?""** | `[93]` **Gus Manger**: ""I trust Ministers Walda and Ben..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Gus Manger**: "“Sipping Borin wine at the Jewel..." |
| `[94]` | **"“Good to see you, Gus. I wanted to talk to you about what we can do to help the de..."** | `[93]` **Gus Manger**: ""I trust Ministers Walda and Ben..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Gus Manger**: "“Perfect. That's exactly what I ..." |
| `[95]` | **"“I would be surprised if there are no demands or expectations here today.”"** | `[93]` **Gus Manger**: ""I trust Ministers Walda and Ben..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Gus Manger**: "“No demands from me, President R..." |
| `[96]` | **""It's a relief to have a break from all that, even if just for a little while.""** | `[93]` **Gus Manger**: ""I trust Ministers Walda and Ben..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Gus Manger**: "“Petr Vectern isn't the only one..." |
| `[114]` | **"“Keep up with the times. Your knowledge will come in handy.”"** | `[192]` **Gus Manger**: "“What I do during my personal ti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Gus Manger**: "“We can discuss this later, Mr. ..." |
| `[115]` | **"“I'm still not sure how fattening your own wallet helps our rural populations.""** | `[192]` **Gus Manger**: "“What I do during my personal ti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Gus Manger**: "“We can discuss this later, Mr. ..." |
| `[116]` | **"“That's going to be me one day.”"** | `[195]` **Gus Manger**: "“Think of history. Leaders who t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Gus Manger**: "“We can discuss this later, Mr. ..." |
| `[117]` | **"“I don't care about the books. My worry is our duty and service.”"** | `[195]` **Gus Manger**: "“Think of history. Leaders who t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Gus Manger**: "“We can discuss this later, Mr. ..." |
| `[118]` | **"“Does it, though?”"** | `[194]` **Gus Manger**: "“Attract money, invest in the ri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Gus Manger**: "“We can discuss this later, Mr. ..." |
| `[119]` | **"“I see your point, but the economy is a complex beast.”"** | `[194]` **Gus Manger**: "“Attract money, invest in the ri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Gus Manger**: "“We can discuss this later, Mr. ..." |
| `[123]` | **"“I understand. Support the business, and we support the economy.”"** | `[174]` **Gus Manger**: "“You make one wrong move, and th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Gus Manger**: "“Our country needs steadiness an..." |
| `[129]` | **"“Why are there so many workers from abroad?”"** | `[48]` **Narrator**: "A stark contrast to the blue-col..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Gus Manger**: "“The best talent in Sordland was..." |
| `[130]` | **"“The whole complex feels very hands-on deck. I can tell an intricate operation whe..."** | `[48]` **Narrator**: "A stark contrast to the blue-col..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Gus Manger**: "“It took decades for Ewald -- an..." |
| `[134]` | **"“The white-collars seem to be having it good in here while the majority are workin..."** | `[48]` **Narrator**: "A stark contrast to the blue-col..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Gus Manger**: "“The equipment provided is high-..." |
| `[136]` | **"“Pat yourself on the back, Gus. You did well. I expect the same and more in my term.”"** | `[175]` **Gus Manger**: "“We made history with the 1950 a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Gus Manger**: "“It's a hundred percent with me...." |
| `[151]` | **"“A Qinali architect is an odd choice.”"** | `[48]` **Narrator**: "A stark contrast to the blue-col..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Gus Manger**: "“Some of Gasom's global hires ar..." |
| `[158]` | **"“After your convincing arguments about the railway project, I was curious what els..."** | `[157]` **Gus Manger**: ""I have faith that you won't lea..." | `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`<br>`Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true` | *Brak zmian stanu* | `[181]` **Gus Manger**: "“Ah! I'm flattered, Mr. Presiden..." |
| `[160]` | **"“For your sake and mine, I hope you're right.""** | `[186]` **Gus Manger**: ""As soon as the IPO kicks in on ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[197]` **Gus Manger**: "“Well a quarter of my net wealth..." |
| `[161]` | **"“Don't you think it's a little wrong that someone in your position is active in th..."** | `[186]` **Gus Manger**: ""As soon as the IPO kicks in on ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Gus Manger**: "“I don't think so. My job is to ..." |
| `[162]` | **"“A true capitalist knows how and when to play.”"** | `[186]` **Gus Manger**: ""As soon as the IPO kicks in on ..." | `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false` | *Brak zmian stanu* | `[196]` **Gus Manger**: "“Well said! The higher you rise,..." |
| `[168]` | **"“How a development minister came to lead such initiatives is beyond me.”"** | `[175]` **Gus Manger**: "“We made history with the 1950 a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Gus Manger**: "“That's what I liked about Ewald..." |
| `[169]` | **"“Alphonso was the one who nearly brought the depression on us in the first place.”"** | `[175]` **Gus Manger**: "“We made history with the 1950 a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Gus Manger**: "“It was more complicated than th..." |
| `[170]` | **"“We shouldn't act in a way that jeopardizes Gasom. But we should still do *somethi..."** | `[174]` **Gus Manger**: "“You make one wrong move, and th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Gus Manger**: "“I highly advise us to find a mi..." |
| `[171]` | **"“Sometimes we must destroy our rotten foundations to build something better.”"** | `[174]` **Gus Manger**: "“You make one wrong move, and th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Gus Manger**: "“Isn't that paraphrasing Malenye..." |
| `[172]` | **"“I doubt that a single regional power like Rizia had such an impact.”"** | `[175]` **Gus Manger**: "“We made history with the 1950 a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Gus Manger**: "“Of course it wasn't just Rizia...." |
| `[173]` | **"“Look at us, promoting a planned economy while playing our personal wealth for pro..."** | `[186]` **Gus Manger**: ""As soon as the IPO kicks in on ..." | `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true` | *Brak zmian stanu* | `[167]` **Gus Manger**: "“The offerings on the Lachaven S..." |
| `[182]` | **"“I haven't seen him since the inauguration. He really pulled back from public life.”"** | `[157]` **Gus Manger**: ""I have faith that you won't lea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Gus Manger**: "“Can you blame the guy? We went ..."<br>`[65]` **Gus Manger**: "“I think he is fully focused on ..." |
| `[183]` | **"“I'm here because something needs to be done about Narbel's living standards.”"** | `[157]` **Gus Manger**: ""I have faith that you won't lea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Gus Manger**: "“Of course. That's going to play..." |
| `[187]` | **"“Let's play, then.”"** | `[193]` **Gus Manger**: ""Anyway, Mr. President, when it ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Gus Manger**: "“We can discuss this later, Mr. ..." |
| `[188]` | **"“Time for Sordland to think outside of the box and break the game.”"** | `[193]` **Gus Manger**: ""Anyway, Mr. President, when it ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Gus Manger**: "“We can discuss this later, Mr. ..." |
| `[202]` | **""I have my doubts, Gus. But I'll give your plan some thought.""** | `[218]` **Gus Manger**: ""But I'm telling you, if we put ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[207]` **Gus Manger**: ""Sure, Mr. President, doubts are..." |
| `[203]` | **""It's a tough call, Gus. I need to weigh the environmental implications and the ec..."** | `[218]` **Gus Manger**: ""But I'm telling you, if we put ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Gus Manger**: ""That's all I'm asking for, Mr. ..." |
| `[204]` | **""Gus, I'm intrigued by your vision. I'll seriously consider your proposal.""** | `[218]` **Gus Manger**: ""But I'm telling you, if we put ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Gus Manger**: ""I appreciate you hearing me out..." |
| `[209]` | **""In my book, workers' rights aren't up for negotiation, no matter the economic cli..."** | `[216]` **Gus Manger**: ""The way I see it, short-term wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Gus Manger**: ""Mr. President, I respect your s..." |
| `[210]` | **""We've got to play this smart. We can't risk another economic blow.""** | `[216]` **Gus Manger**: ""The way I see it, short-term wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Gus Manger**: ""Mr. President, I'm glad you're ..." |
| `[211]` | **""Gus, I get what you're saying. But isn't it high time we put people before profits?""** | `[216]` **Gus Manger**: ""The way I see it, short-term wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Gus Manger**: ""I see where you're coming from,..." |
| `[221]` | **""An extravagant show of wealth, isn't it? Hardly seems necessary.""** | `[220]` **Narrator**: "On it was our next appointment, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[226]` **Gus Manger**: ""It's Alphonso's style, Mr. Pres..." |
| `[222]` | **""That kind of display plays well to investors... but terribly to farmers watching ..."** | `[220]` **Narrator**: "On it was our next appointment, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Gus Manger**: ""Exactly. The optics matter. We ..." |
| `[223]` | **""Alphonso sure knows how to make an entrance.""** | `[220]` **Narrator**: "On it was our next appointment, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Gus Manger**: ""The man loves his theatrics."" |
| `[232]` | **""I grew up around people like the ones this would help, Gus. If your plan’s solid,..."** | `[218]` **Gus Manger**: ""But I'm telling you, if we put ..." | `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true` | *Brak zmian stanu* | `[236]` **Gus Manger**: ""Then we’re on the same page, Mr..." |
| `[237]` | **""Is that a helicopter or just his ego with rotor blades?""** | `[220]` **Narrator**: "On it was our next appointment, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Gus Manger**: ""He calls it branding. I call it..." |
| `[242]` | **""Heard a worker from Estord on the radio. Said he's got rights on paper, but nothi..."** | `[216]` **Gus Manger**: ""The way I see it, short-term wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Gus Manger**: ""That kind of thing sticks with ..." |
| `[244]` | **""If we overload businesses now, they'll shrink or shut down. Workers lose more tha..."** | `[239]` **Gus Manger**: ""If we're all sinking, nobody's ..."<br>`[240]` **Gus Manger**: ""Timing and approach are everyth..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[248]` **Gus Manger**: ""Exactly. We can’t let good inte..." |
| `[245]` | **""Strong labor protections are the foundation of lasting growth. A secure worker is..."** | `[239]` **Gus Manger**: ""If we're all sinking, nobody's ..."<br>`[240]` **Gus Manger**: ""Timing and approach are everyth..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[249]` **Gus Manger**: ""Fair enough, but let’s roll it ..." |
| `[246]` | **""Let’s think of the option that signals progress without rattling the markets. We ..."** | `[239]` **Gus Manger**: ""If we're all sinking, nobody's ..."<br>`[240]` **Gus Manger**: ""Timing and approach are everyth..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[250]` **Gus Manger**: ""That’s the sweet spot. You brin..." |
| `[247]` | **""People don’t care about long-term strategy when their kids are hungry now. We fix..."** | `[239]` **Gus Manger**: ""If we're all sinking, nobody's ..."<br>`[240]` **Gus Manger**: ""Timing and approach are everyth..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[251]` **Gus Manger**: ""Hard to argue with that. Just m..." |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Gus Manger: ""I trust Ministers Walda and Beniwoll didn't overwhelm yo..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == t..."*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Railway == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Player: "“After your convincing arguments about the railway projec..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Railway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player: "“The discussions were lively during the highway contract ..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == ..."*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_PersonalInvestment_DontSpend =..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player: "“You still have to prove that you make returns on your de..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“You still have to prove that you make returns on your deals. Our investment in Armadine had better make a return.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == false`
- **Kontekst wejściowy (poprzednik):** `[157]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Gus Manger: "“I never claim to see the future, President Rayne. I mere..."*)

### Węzeł `[10]`
Mówca: **Gus Manger**
> "“I never claim to see the future, President Rayne. I merely find good opportunities and seize them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Gus Manger: "“Sometimes I do it for myself, other times I chase luck w..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The discussions were lively during the highway contract award. I'm willing to hear new offers from you.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false` AND `Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true`
- **Kontekst wejściowy (poprzednik):** `[157]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Gus Manger: "“And I'm willing to present them. Despite your unfortunat..."*)

### Węzeł `[12]`
Mówca: **Gus Manger**
> "“And I'm willing to present them. Despite your unfortunate choice of the H-3 over the L-1.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_SordishState == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Gus Manger: "“I admit I'm slightly frustrated that you contracted SSC...."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_SordishState == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_TaurusHolding == true"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_TaurusHolding == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_TaurusHolding == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_TaurusHolding == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_TaurusHolding == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Gus Manger: "“By the way, I still don't believe Taurus should be trust..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_TaurusHolding == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Gus Manger: "“I'm glad you contracted Underhall, by the way. You won't..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == t..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Gus Manger: "“I like the all-in 3000-share purchase you made. Shows th..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == t..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Gus Manger: ""You played it safe with 2000 shares, but you still stand..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Gus Manger: "“Your measly 1000 shares won't make you much profit. But ..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_RespondedToInfraProject = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_RespondedToInfraProject"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "He pushed open a door. We walked down yet another hallway..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_RespondedToPersonalInvestment = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_RespondedToPersonalInvestment"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "He pushed open a door. We walked down yet another hallway..."*)

### Węzeł `[27]`
Mówca: **Gus Manger**
> ""Please come this way. Ewald and I have some exciting news to share with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Gus Manger: ""I have faith that you won't leave us hanging.""*)

### Węzeł `[28]`
Mówca: **Gus Manger**
> "“The corruption in that organization is unfathomable. Makes the Lotherberg group look like saints.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: "“The government has clear control over SSC's operations. ..."*)
  - -> `[32]` (*Player: "“I have to take the safe option this early in the term, M..."*)
  - -> `[42]` (*Player: "“The SSC is one of our national treasures. It rebuilt mos..."*)

### Węzeł `[29]`
Mówca: **Gus Manger**
> "“By the way, I still don't believe Taurus should be trusted with such a monumental mega-project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Gus Manger: "“They need to walk before they can run. And I'm saying th..."*)

### Węzeł `[30]`
Mówca: **Gus Manger**
> "“I'm glad you contracted Underhall, by the way. You won't be disappointed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: "“It seemed the least risky option. We need safe bets.”"*)
  - -> `[57]` (*Player: "“I still have my doubts, but I'll take your word for now.”"*)
  - -> `[36]` (*Player: "“The workers need to be protected somehow. We can't ignor..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The government has clear control over SSC's operations. We wouldn't get that with a private corporation.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Gus Manger: "“It might seem like we have control, but those organizati..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I have to take the safe option this early in the term, Mr. Manger.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Gus Manger: "“Understandable. But we have to break the cycle at some p..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I think it's time we let fresh -- and fast -- new faces have a shot.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Gus Manger: "“Calculated risks, Mr. President. Taurus is not the right..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Status quos are meant to be broken. I want to be the change maker during my term.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Gus Manger: "“I respect that. Most of my life has been about changing ..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“It seemed the least risky option. We need safe bets.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Gus Manger: "“It's a pity you only had three choices, to be honest.”"*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The workers need to be protected somehow. We can't ignore that problem.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Gus Manger: "“We won't ignore it, Mr. President. But as I mentioned be..."*)

### Węzeł `[37]`
Mówca: **Gus Manger**
> "“It might seem like we have control, but those organizations are slow and inflexible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Gus Manger: "“The only difference between an SSC manager and a fossil ..."*)

### Węzeł `[38]`
Mówca: **Gus Manger**
> "“I admit I'm slightly frustrated that you contracted SSC. They've been leeching off the Sordish people for too long.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Gus Manger: "“The corruption in that organization is unfathomable. Mak..."*)

### Węzeł `[39]`
Mówca: **Gus Manger**
> "“They need to walk before they can run. And I'm saying this as a guy who actually almost likes Frens Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: "“I think it's time we let fresh -- and fast -- new faces ..."*)
  - -> `[34]` (*Player: "“Status quos are meant to be broken. I want to be the cha..."*)
  - -> `[54]` (*Player: "“We won't know until they complete the project. There's n..."*)

### Węzeł `[40]`
Mówca: **Gus Manger**
> "“Calculated risks, Mr. President. Taurus is not the right call. But don't mind me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Gus Manger: "“I'm just a civil servant who wants what's best for the S..."*)

### Węzeł `[41]`
Mówca: **Gus Manger**
> "“It's a pity you only had three choices, to be honest.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Gus Manger: "“Too few large corporations own too much power. Market ec..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The SSC is one of our national treasures. It rebuilt most of Sordland in the '30s.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Gus Manger: "“Yes, nobody can deny the SSC's great work for our people..."*)

### Węzeł `[43]`
Mówca: **Gus Manger**
> "“Understandable. But we have to break the cycle at some point if we want to stick around.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Gus Manger: "“Anyway, I digress. Let's get to the elevator.”"*)

### Węzeł `[44]`
Mówca: **Gus Manger**
> "“Yes, nobody can deny the SSC's great work for our people in the Restoration period. But those days are long gone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Gus Manger: "“The only difference between an SSC manager and a fossil ..."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "He pushed open a door. We walked down yet another hallway, seemingly in the direction we'd just come from."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Gus Manger: "“Like a maze, isn't it? That's Qinali architecture for you.""*)

### Węzeł `[46]`
Mówca: **Gus Manger**
> "“Like a maze, isn't it? That's Qinali architecture for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "The hallways were lined with doors. Glass panels in them ..."*)

### Węzeł `[47]`
Mówca: **Gus Manger**
> "“The only difference between an SSC manager and a fossil from the pre-Migration period is that the fossil might actually be worth something.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Gus Manger: "“Anyway, I digress. Let's get to the elevator.”"*)

### Węzeł `[48]`
Mówca: **Narrator**
> "A stark contrast to the blue-collar workers outside working with machinery, transportation, and maintenance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player: "“The whole complex feels very hands-on deck. I can tell a..."*)
  - -> `[129]` (*Player: "“Why are there so many workers from abroad?”"*)
  - -> `[134]` (*Player: "“The white-collars seem to be having it good in here whil..."*)
  - -> `[151]` (*Player: "“A Qinali architect is an odd choice.”"*)

### Węzeł `[49]`
Mówca: **Narrator**
> "The doors opened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Gus Manger: "“Here we are! Ewald, my friend.”"*)

### Węzeł `[50]`
Mówca: **Gus Manger**
> "“To be 100 percent honest, Mr. President, I doubted he even wanted to discuss this with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: "“He must really care about Gasom.”"*)
  - -> `[66]` (*Player: "“What's in the past shouldn't shape our future. Especiall..."*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == false"*)

### Węzeł `[51]`
Mówca: **Gus Manger**
> "“We do have to be delicate with Gasom, though. A corporation this big is like a house of cards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Gus Manger: "“You make one wrong move, and the whole thing falls apart.""*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“He must really care about Gasom.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Gus Manger: "“It's one of Sordland's most significant private corporat..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Does the average working-class man in Narbel really give a damn about that?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Gus Manger: "“They don't, but it affects them nonetheless.”"*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We won't know until they complete the project. There's no reason to be negative before then.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Gus Manger: "“Time will tell. I also hope that it will succeed, believ..."*)

### Węzeł `[55]`
Mówca: **Gus Manger**
> "“I respect that. Most of my life has been about changing the status quo in Gruni.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Gus Manger: "“But there's a time and a place to take risks. The stock ..."*)

### Węzeł `[56]`
Mówca: **Gus Manger**
> "“Time will tell. I also hope that it will succeed, believe me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Gus Manger: "“Anyway, I digress. Let's get to the elevator.”"*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I still have my doubts, but I'll take your word for now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Gus Manger: "“Kris Schar and the company still have many things they n..."*)

### Węzeł `[58]`
Mówca: **Gus Manger**
> "“I'm just a civil servant who wants what's best for the Sordish people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Gus Manger: "“Anyway, I digress. Let's get to the elevator.”"*)

### Węzeł `[59]`
Mówca: **Gus Manger**
> "“But there's a time and a place to take risks. The stock market, yes. National infrastructure, no.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Gus Manger: "“Anyway, I digress. Let's get to the elevator.”"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_Backstab == true)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Gus Manger: "“Can you blame the guy? We went full Dwight Walker on him..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_Backstab == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Gus Manger: "“I think he is fully focused on Gasom these days. His ent..."*)

### Węzeł `[63]`
Mówca: **Gus Manger**
> "“Admittedly, I'm biased. But I do think Gasom is extraordinary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: ""What's so extraordinary about another corporation trying..."*)
  - -> `[80]` (*Player: "“If he needs to be hands-on as chairman, then the busines..."*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Diplomatic == true && Ba..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We worked closely in the past and are on friendly terms. I'm open to see what we can do.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true`
- **Kontekst wejściowy (poprzednik):** `[63]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Gus Manger: "“As you know, he and I go back a long time. He isn't the ..."*)

### Węzeł `[65]`
Mówca: **Gus Manger**
> "“I think he is fully focused on Gasom these days. His entire reputation is bound to this corporation now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Gus Manger: "“Admittedly, I'm biased. But I do think Gasom is extraord..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“What's in the past shouldn't shape our future. Especially if a good deal can be talked through.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Gus Manger: "“Yes, and Sordland needs any deal it can get. Soon the te..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The feeling is mutual. Both of us are only here because of you, Gus.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == false`
- **Kontekst wejściowy (poprzednik):** `[50]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Gus Manger: "“I do my best. Got a close influential contact in Porte D..."*)

### Węzeł `[68]`
Mówca: **Gus Manger**
> "“It's one of Sordland's most significant private corporations. Ewald's reputation as chairman and ex-CEO rests on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Gus Manger: "“Moreover, we have an opportunity to make a larger econom..."*)

### Węzeł `[69]`
Mówca: **Gus Manger**
> "“Yes, and Sordland needs any deal it can get. Soon the term budget will be determined and expenditures won't recover the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Gus Manger: "“We can't provide services to our people without corporat..."*)

### Węzeł `[70]`
Mówca: **Gus Manger**
> "“I do my best. Got a close influential contact in Porte Drazon who opened a lot of doors a few years ago.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Gus Manger: "“Shall we?”"*)

### Węzeł `[71]`
Mówca: **Gus Manger**
> "“Moreover, we have an opportunity to make a larger economic impact on the people of Narbel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Gus Manger: "“Shall we?”"*)

### Węzeł `[72]`
Mówca: **Gus Manger**
> "“We can't provide services to our people without corporations like Gasom filling our coffers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Gus Manger: "“Shall we?”"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_CampaignedForAlphonso == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == false"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_CampaignedForAlphonso == false)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_CampaignedForAlphonso == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: "“The feeling is mutual. Both of us are only here because ..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_CampaignedForAlphonso == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: "“I wasn't against him early on. Quite the opposite.”"*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I wasn't against him early on. Quite the opposite.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[50]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Gus Manger: ""I still remember the day the party leadership changed fr..."*)

### Węzeł `[77]`
Mówca: **Gus Manger**
> ""I still remember the day the party leadership changed from Tarquin Soll. What a historic moment that was.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Gus Manger: "“Shall we?”"*)

### Węzeł `[78]`
Mówca: **Gus Manger**
> "“Shall we?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "He pushed open a door. We walked down yet another hallway..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The fact that you managed to get Rizia entangled in this is surprising.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Gus Manger: "“I hate to brag, but I was the one who opened the gates i..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“If he needs to be hands-on as chairman, then the business must not be doing well.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Gus Manger: "“It's true that it's seen a lack of consistent growth.”"*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's so extraordinary about another corporation trying to make a hefty profit off the back of the people?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Gus Manger: "“Human greed is undeniable. I always saw it as an asset t..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Diplomatic == true && BaseGame.Prologue_Party_CampaignedForAlphonso == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Diplomatic == true && Ba..."*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_Diplomatic == true && ..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Diplomatic == true && BaseGame.Prologue_Party_CampaignedForAlphonso == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: "“We worked closely in the past and are on friendly terms...."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_Diplomatic == true && BaseGame.Prologue_Party_CampaignedForAlphonso == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "“I have no ill-will against Ewald Alphonso.”"*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I have no ill-will against Ewald Alphonso.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[63]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Gus Manger: "“Why should you?”"*)

### Węzeł `[86]`
Mówca: **Gus Manger**
> "“Human greed is undeniable. I always saw it as an asset to move wealth our way, to Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Gus Manger: "“But Gasom is beyond that. Not many nations have such an ..."*)

### Węzeł `[87]`
Mówca: **Gus Manger**
> "“It's true that it's seen a lack of consistent growth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Gus Manger: "“But Gasom has the potential to rival global corporations..."*)

### Węzeł `[88]`
Mówca: **Gus Manger**
> "“As you know, he and I go back a long time. He isn't the sell-out some Sollists painted him to be.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Gus Manger: "“Shall we?”"*)

### Węzeł `[89]`
Mówca: **Gus Manger**
> "“Why should you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Gus Manger: "“As you know, he and I go back a long time. He isn't the ..."*)

### Węzeł `[90]`
Mówca: **Gus Manger**
> "“But Gasom is beyond that. Not many nations have such an influential and valuable asset. We ought to maximize its potential.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Gus Manger: "“Shall we?”"*)

### Węzeł `[91]`
Mówca: **Gus Manger**
> "“But Gasom has the potential to rival global corporations like Rizian Royal Gold. It could be *the* gas exporter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Gus Manger: "“Shall we?”"*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Not exactly the most pleasant location for a meeting, is it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Gus Manger: "“Sipping Borin wine at the Jewel beach resort in Benfi wo..."*)

### Węzeł `[93]`
Mówca: **Gus Manger**
> ""I trust Ministers Walda and Beniwoll didn't overwhelm you with their demands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player: ""It's a relief to have a break from all that, even if jus..."*)
  - -> `[95]` (*Player: "“I would be surprised if there are no demands or expectat..."*)
  - -> `[94]` (*Player: "“Good to see you, Gus. I wanted to talk to you about what..."*)
  - -> `[92]` (*Player: ""Not exactly the most pleasant location for a meeting, is..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Good to see you, Gus. I wanted to talk to you about what we can do to help the development here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Gus Manger: "“Perfect. That's exactly what I hope to accomplish during..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I would be surprised if there are no demands or expectations here today.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Gus Manger: "“No demands from me, President Rayne. I'm all about makin..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's a relief to have a break from all that, even if just for a little while.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Gus Manger: "“Petr Vectern isn't the only one you can have fun with, y..."*)

### Węzeł `[97]`
Mówca: **Gus Manger**
> "“Petr Vectern isn't the only one you can have fun with, you know! Jokes aside, you are the President, so do what you want!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Gus Manger: "“Except for running the country to the ground, please.”"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.RuralDevelopment_Interest += 1"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RuralDevelopment_Interest += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.RuralDevelopment_Interest"] = Variable["BaseGame.RuralDevelopment_Interest"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Gus Manger: ""Mr. President, I've been brainstorming a little somethin..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "He pushed open a door. We walked down yet another hallway..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RuralDevelopment_Interest += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.RuralDevelopment_Interest"] = Variable["BaseGame.RuralDevelopment_Interest"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention = true"*)

### Węzeł `[102]`
Mówca: **Gus Manger**
> "“No demands from me, President Rayne. I'm all about making deals and finding common ground.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Gus Manger: "“If there's one thing Gus Manger stands for, it's win-win..."*)

### Węzeł `[103]`
Mówca: **Gus Manger**
> "“Perfect. That's exactly what I hope to accomplish during today's discussions. My job is to improve the conditions of places like these.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention = true"*)

### Węzeł `[104]`
Mówca: **Gus Manger**
> "“Sipping Borin wine at the Jewel beach resort in Benfi would be better, yes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Gus Manger: ""But you know, as someone who has never experienced the w..."*)

### Węzeł `[105]`
Mówca: **Gus Manger**
> "“Except for running the country to the ground, please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Gus Manger: ""Mr. President, I've been brainstorming a little somethin..."*)

### Węzeł `[106]`
Mówca: **Gus Manger**
> "“If there's one thing Gus Manger stands for, it's win-win solutions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Gus Manger: ""Mr. President, I've been brainstorming a little somethin..."*)

### Węzeł `[107]`
Mówca: **Gus Manger**
> "“The methods for achieving better living standards can be discussed in detail when we talk terms.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention = true"*)

### Węzeł `[108]`
Mówca: **Gus Manger**
> ""But you know, as someone who has never experienced the working-class way of life, it's important for me to understand why my role holds such significance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Gus Manger: ""Mr. President, I've been brainstorming a little somethin..."*)

### Węzeł `[109]`
Mówca: **Gus Manger**
> "“Kris Schar and the company still have many things they need to figure out, but they are good at what they do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Gus Manger: "“If I had any extra time or resources left, I'd enter the..."*)

### Węzeł `[110]`
Mówca: **Gus Manger**
> "“We won't ignore it, Mr. President. But as I mentioned before, I don't think this new Assembly bill is the way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Gus Manger: "“Anyway, I digress. Let's get to the elevator.”"*)

### Węzeł `[111]`
Mówca: **Gus Manger**
> "“Too few large corporations own too much power. Market economics won't succeed with monopolies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Gus Manger: "“Anyway, I digress. Let's get to the elevator.”"*)

### Węzeł `[112]`
Mówca: **Gus Manger**
> "“If I had any extra time or resources left, I'd enter the construction business myself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Gus Manger: "“Anyway, I digress. Let's get to the elevator.”"*)

### Węzeł `[113]`
Mówca: **Gus Manger**
> "“Anyway, I digress. Let's get to the elevator.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_RespondedToInfraProject..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Keep up with the times. Your knowledge will come in handy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Gus Manger: "“We can discuss this later, Mr. Rayne. We shouldn't keep ..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I'm still not sure how fattening your own wallet helps our rural populations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Gus Manger: "“We can discuss this later, Mr. Rayne. We shouldn't keep ..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“That's going to be me one day.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Gus Manger: "“We can discuss this later, Mr. Rayne. We shouldn't keep ..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I don't care about the books. My worry is our duty and service.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Gus Manger: "“We can discuss this later, Mr. Rayne. We shouldn't keep ..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Does it, though?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Gus Manger: "“We can discuss this later, Mr. Rayne. We shouldn't keep ..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I see your point, but the economy is a complex beast.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Gus Manger: "“We can discuss this later, Mr. Rayne. We shouldn't keep ..."*)

### Węzeł `[120]`
Mówca: **Gus Manger**
> "“We can discuss this later, Mr. Rayne. We shouldn't keep our former president waiting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_RespondedToPersonalInve..."*)

### Węzeł `[121]`
Mówca: **Gus Manger**
> "“They don't, but it affects them nonetheless.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Gus Manger: "“Think of Gasom as a house of cards with an entire city b..."*)

### Węzeł `[122]`
Mówca: **Gus Manger**
> "“Of course it wasn't just Rizia. But their contribution led to interest from other nations like Qinal and Lespia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Gus Manger: "“I'm glad we have overcome the worst of those days. The e..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I understand. Support the business, and we support the economy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Gus Manger: "“Our country needs steadiness and stability more than eve..."*)

### Węzeł `[124]`
Mówca: **Gus Manger**
> "“I highly advise us to find a middle-ground. If the state can assist Gasom through these tough times, we'll all benefit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Gus Manger: "“Shall we?”"*)

### Węzeł `[125]`
Mówca: **Gus Manger**
> "“Isn't that paraphrasing Malenyev? Keep in mind we only have a single term to work with.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Gus Manger: "“And none of the average citizens here care about anythin..."*)

### Węzeł `[126]`
Mówca: **Gus Manger**
> "“Our country needs steadiness and stability more than ever. Yes, we need to fix inequality. But not at the expense of everything else.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Gus Manger: "“Shall we?”"*)

### Węzeł `[127]`
Mówca: **Gus Manger**
> "“Think of Gasom as a house of cards with an entire city built atop it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.RuralDevelopment_Interest += 1"*)

### Węzeł `[128]`
Mówca: **Gus Manger**
> "“And none of the average citizens here care about anything other than direct support.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.RuralDevelopment_Interest += 1"*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Why are there so many workers from abroad?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Gus Manger: "“The best talent in Sordland was snatched by the SSC in t..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The whole complex feels very hands-on deck. I can tell an intricate operation when I see one.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Gus Manger: "“It took decades for Ewald -- and the workers, of course ..."*)

### Węzeł `[131]`
Mówca: **Gus Manger**
> "“It took decades for Ewald -- and the workers, of course -- to create an enterprise of such global competitive potential.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Gus Manger: "“Ah, here's the elevator. Ewald ought to be up there alre..."*)

### Węzeł `[132]`
Mówca: **Gus Manger**
> "“The best talent in Sordland was snatched by the SSC in the 1930s. Most other corporations couldn't contend, so they had to look elsewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Gus Manger: "“Ah, here's the elevator. Ewald ought to be up there alre..."*)

### Węzeł `[133]`
Mówca: **Gus Manger**
> "“The equipment provided is high-standard. I've seen it for myself. Besides, there will always be differences between workers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Gus Manger: "“Ah, here's the elevator. Ewald ought to be up there alre..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The white-collars seem to be having it good in here while the majority are working out in the cold.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Gus Manger: "“The equipment provided is high-standard. I've seen it fo..."*)

### Węzeł `[135]`
Mówca: **Gus Manger**
> "“Ah, here's the elevator. Ewald ought to be up there already; there's a separate entrance by the helipad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "We stepped into the elevator. Gus punched a code and we b..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Pat yourself on the back, Gus. You did well. I expect the same and more in my term.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Gus Manger: "“It's a hundred percent with me. I have some new ideas I'..."*)

### Węzeł `[137]`
Mówca: **Gus Manger**
> "“That's what I liked about Ewald Alphonso. He didn't let titles or rules get in the way of results.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Gus Manger: "“Good leadership is allowing people to excel in what they..."*)

### Węzeł `[138]`
Mówca: **Gus Manger**
> "“It was more complicated than that. Obstructionists in the institutions halted critical policies that could have avoided us the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Gus Manger: "“Yes, the privatization and the cancellation of old polic..."*)

### Węzeł `[139]`
Mówca: **Gus Manger**
> "“It's a hundred percent with me. I have some new ideas I'm discussing with Mr. Holl.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Gus Manger: "“We'll brief you on those later.”"*)

### Węzeł `[140]`
Mówca: **Gus Manger**
> "“I'm glad we have overcome the worst of those days. The economy isn't great, but it is more stable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "He pushed open a door. We walked down yet another hallway..."*)

### Węzeł `[141]`
Mówca: **Gus Manger**
> "“Good leadership is allowing people to excel in what they are good at, not forcing them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "He pushed open a door. We walked down yet another hallway..."*)

### Węzeł `[142]`
Mówca: **Gus Manger**
> "“Yes, the privatization and the cancellation of old policies was too fast and radical, but that wasn't it. The geopolitical pressures on the market were significant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "He pushed open a door. We walked down yet another hallway..."*)

### Węzeł `[143]`
Mówca: **Gus Manger**
> "“We'll brief you on those later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "He pushed open a door. We walked down yet another hallway..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_Backstab == true)"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Gus Manger: "“Just remember. Past is past. We've got to look to the fu..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_Backstab == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Diplomatic == true && Ba..."*)

### Węzeł `[147]`
Mówca: **Gus Manger**
> "“Just remember. Past is past. We've got to look to the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "The doors opened."*)

### Węzeł `[148]`
Mówca: **Gus Manger**
> "“Let's do this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "The doors opened."*)

### Węzeł `[149]`
Mówca: **Narrator**
> "We stepped into the elevator. Gus punched a code and we began our ascent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)

### Węzeł `[150]`
Mówca: **Narrator**
> "The hallways were lined with doors. Glass panels in them revealed workers in suits and ties, many of foreign origin, busy in their pristine offices."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "A stark contrast to the blue-collar workers outside worki..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“A Qinali architect is an odd choice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Gus Manger: "“Some of Gasom's global hires are from the Republic of Qi..."*)

### Węzeł `[152]`
Mówca: **Gus Manger**
> "“Some of Gasom's global hires are from the Republic of Qinal. Once you get past the cultural differences, they're really quite gifted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Gus Manger: "“Ah, here's the elevator. Ewald ought to be up there alre..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Diplomatic == true && BaseGame.Prologue_Party_CampaignedForAlphonso == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Diplomatic == true && Ba..."*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_Diplomatic == true && ..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Diplomatic == true && BaseGame.Prologue_Party_CampaignedForAlphonso == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Gus Manger: "“Just remember. Alphonso's our friend. We've got the foun..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_Diplomatic == true && BaseGame.Prologue_Party_CampaignedForAlphonso == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Gus Manger: "“Let's do this.”"*)

### Węzeł `[156]`
Mówca: **Gus Manger**
> "“Just remember. Alphonso's our friend. We've got the foundation for a great deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "The doors opened."*)

### Węzeł `[157]`
Mówca: **Gus Manger**
> ""I have faith that you won't leave us hanging.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == ..."*)
  - -> `[182]` (*Player: "“I haven't seen him since the inauguration. He really pul..."*)
  - -> `[183]` (*Player: "“I'm here because something needs to be done about Narbel..."*)
  - -> `[79]` (*Player: "“The fact that you managed to get Rizia entangled in this..."*)

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“After your convincing arguments about the railway project, I was curious what else we could achieve.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true` AND `Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true`
- **Kontekst wejściowy (poprzednik):** `[157]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Gus Manger: "“Ah! I'm flattered, Mr. President. And glad that you made..."*)

### Węzeł `[159]`
Mówca: **Gus Manger**
> "“Sometimes I do it for myself, other times I chase luck with others.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true"*)

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“For your sake and mine, I hope you're right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Gus Manger: "“Well a quarter of my net wealth is on that stock now. Bu..."*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Don't you think it's a little wrong that someone in your position is active in the stock market?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Gus Manger: "“I don't think so. My job is to bring resources to long-f..."*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“A true capitalist knows how and when to play.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[186]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Gus Manger: "“Well said! The higher you rise, the less you can fall. W..."*)

### Węzeł `[163]`
Mówca: **Gus Manger**
> "“I like the all-in 3000-share purchase you made. Shows that you're a man of action, like me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Gus Manger: "“Me, I got 4000 shares thanks to a low-risk loan I levera..."*)

### Węzeł `[164]`
Mówca: **Gus Manger**
> ""You played it safe with 2000 shares, but you still stand to make some gains.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Gus Manger: "“Me, I got 4000 shares thanks to a low-risk loan I levera..."*)

### Węzeł `[165]`
Mówca: **Gus Manger**
> "“Your measly 1000 shares won't make you much profit. But you know, good to dip your feet in the water before taking a dive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Gus Manger: "“Me, I got 4000 shares thanks to a low-risk loan I levera..."*)

### Węzeł `[166]`
Mówca: **Gus Manger**
> "“Me, I got 4000 shares thanks to a low-risk loan I leveraged on an old logistics business of mine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Gus Manger: ""As soon as the IPO kicks in on the Ventrie City Stock Ex..."*)

### Węzeł `[167]`
Mówca: **Gus Manger**
> "“The offerings on the Lachaven Stock Exchange aren't bad either. Much better than anything in eastern Merkopa.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Gus Manger: "“Except the Perla exchange in Lespia, of course.""*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“How a development minister came to lead such initiatives is beyond me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Gus Manger: "“That's what I liked about Ewald Alphonso. He didn't let ..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Alphonso was the one who nearly brought the depression on us in the first place.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Gus Manger: "“It was more complicated than that. Obstructionists in th..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We shouldn't act in a way that jeopardizes Gasom. But we should still do *something*”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Gus Manger: "“I highly advise us to find a middle-ground. If the state..."*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Sometimes we must destroy our rotten foundations to build something better.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Gus Manger: "“Isn't that paraphrasing Malenyev? Keep in mind we only h..."*)

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I doubt that a single regional power like Rizia had such an impact.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Gus Manger: "“Of course it wasn't just Rizia. But their contribution l..."*)

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Look at us, promoting a planned economy while playing our personal wealth for profit in Arcasia.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Kontekst wejściowy (poprzednik):** `[186]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Gus Manger: "“The offerings on the Lachaven Stock Exchange aren't bad ..."*)

### Węzeł `[174]`
Mówca: **Gus Manger**
> "“You make one wrong move, and the whole thing falls apart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: "“Does the average working-class man in Narbel really give..."*)
  - -> `[170]` (*Player: "“We shouldn't act in a way that jeopardizes Gasom. But we..."*)
  - -> `[171]` (*Player: "“Sometimes we must destroy our rotten foundations to buil..."*)
  - -> `[123]` (*Player: "“I understand. Support the business, and we support the e..."*)

### Węzeł `[175]`
Mówca: **Gus Manger**
> "“We made history with the 1950 and 1953 deals. You might remember that the latter agreement prevented a depression just eight months before the elections.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player: "“I doubt that a single regional power like Rizia had such..."*)
  - -> `[168]` (*Player: "“How a development minister came to lead such initiatives..."*)
  - -> `[169]` (*Player: "“Alphonso was the one who nearly brought the depression o..."*)
  - -> `[136]` (*Player: "“Pat yourself on the back, Gus. You did well. I expect th..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player: "“Look at us, promoting a planned economy while playing ou..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player: "“A true capitalist knows how and when to play.”"*)

### Węzeł `[179]`
Mówca: **Gus Manger**
> "“I hate to brag, but I was the one who opened the gates in Porte Drazon after nearly 32 years of frozen Sordish-Rizia relations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Gus Manger: "“Rizia and Sordland were considering a full embargo until..."*)

### Węzeł `[180]`
Mówca: **Gus Manger**
> "“Rizia and Sordland were considering a full embargo until Alphonso and I came along.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Gus Manger: "“We made history with the 1950 and 1953 deals. You might ..."*)

### Węzeł `[181]`
Mówca: **Gus Manger**
> "“Ah! I'm flattered, Mr. President. And glad that you made the right choice, of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I haven't seen him since the inauguration. He really pulled back from public life.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I'm here because something needs to be done about Narbel's living standards.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Gus Manger: "“Of course. That's going to play a big role in our discus..."*)

### Węzeł `[184]`
Mówca: **Gus Manger**
> "“Can you blame the guy? We went full Dwight Walker on him. At least we didn't resort to corporate assassinations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Gus Manger: "“To be 100 percent honest, Mr. President, I doubted he ev..."*)

### Węzeł `[185]`
Mówca: **Gus Manger**
> "“Of course. That's going to play a big role in our discussion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Gus Manger: "“We do have to be delicate with Gasom, though. A corporat..."*)

### Węzeł `[186]`
Mówca: **Gus Manger**
> ""As soon as the IPO kicks in on the Ventrie City Stock Exchange, we'll both be rolling in Ren.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[160]` (*Player: "“For your sake and mine, I hope you're right.""*)
  - -> `[161]` (*Player: "“Don't you think it's a little wrong that someone in your..."*)

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Let's play, then.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Gus Manger: "“We can discuss this later, Mr. Rayne. We shouldn't keep ..."*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Time for Sordland to think outside of the box and break the game.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Gus Manger: "“We can discuss this later, Mr. Rayne. We shouldn't keep ..."*)

### Węzeł `[189]`
Mówca: **Gus Manger**
> "“Except the Perla exchange in Lespia, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Gus Manger: ""Anyway, Mr. President, when it comes to money, we either..."*)

### Węzeł `[190]`
Mówca: **Gus Manger**
> "“Not all of the market economy believers are *capitalist pigs*. Look at me, and how many jobs I've brought to this country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Gus Manger: "“Attract money, invest in the right solutions, increase w..."*)

### Węzeł `[191]`
Mówca: **Gus Manger**
> "“I don't think so. My job is to bring resources to long-forgotten areas of Sordland and keep our rural areas vitalized.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Gus Manger: "“What I do during my personal time doesn't affect that. I..."*)

### Węzeł `[192]`
Mówca: **Gus Manger**
> "“What I do during my personal time doesn't affect that. If anything, keeping up with market trends will help me benefit our local economies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player: "“Keep up with the times. Your knowledge will come in handy.”"*)
  - -> `[115]` (*Player: "“I'm still not sure how fattening your own wallet helps o..."*)

### Węzeł `[193]`
Mówca: **Gus Manger**
> ""Anyway, Mr. President, when it comes to money, we either play the game or the game plays us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Player: "“Let's play, then.”"*)
  - -> `[188]` (*Player: "“Time for Sordland to think outside of the box and break ..."*)

### Węzeł `[194]`
Mówca: **Gus Manger**
> "“Attract money, invest in the right solutions, increase wealth and living standards. It all trickles down.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: "“Does it, though?”"*)
  - -> `[119]` (*Player: "“I see your point, but the economy is a complex beast.”"*)

### Węzeł `[195]`
Mówca: **Gus Manger**
> "“Think of history. Leaders who took big leaps were written in the books.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player: "“That's going to be me one day.”"*)
  - -> `[117]` (*Player: "“I don't care about the books. My worry is our duty and s..."*)

### Węzeł `[196]`
Mówca: **Gus Manger**
> "“Well said! The higher you rise, the less you can fall. Why not pick good people up along the way?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Gus Manger: "“Not all of the market economy believers are *capitalist ..."*)

### Węzeł `[197]`
Mówca: **Gus Manger**
> "“Well a quarter of my net wealth is on that stock now. But hey, you've got to play big to win big.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Gus Manger: "“Think of history. Leaders who took big leaps were writte..."*)

### Węzeł `[198]`
Mówca: **Gus Manger**
> "“Here we are! Ewald, my friend.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[199]`
Mówca: **Gus Manger**
> ""Mr. President, I've been brainstorming a little something. The Gruni Rural Investment Plan. I reckon it's got the potential to breathe new life into our rural communities out in Gruni.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Gus Manger: ""We could consider a few things. For starters, we could g..."*)

### Węzeł `[200]`
Mówca: **Gus Manger**
> ""We could consider a few things. For starters, we could give the farming business a boost with some subsidies. Or, we could steer towards modernizing existing farms with machinery and tech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Gus Manger: ""Or here's another thought - we could pour resources into..."*)

### Węzeł `[201]`
Mówca: **Gus Manger**
> ""Mr. President, I get the appeal of that GREEN bill that's been making the rounds in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Gus Manger: ""But I'm telling you, if we put the brakes on that and fu..."*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I have my doubts, Gus. But I'll give your plan some thought.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Gus Manger: ""Sure, Mr. President, doubts are part of the game. I trus..."*)

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's a tough call, Gus. I need to weigh the environmental implications and the economic benefits.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Gus Manger: ""That's all I'm asking for, Mr. President. Just give this..."*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gus, I'm intrigued by your vision. I'll seriously consider your proposal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Gus Manger: ""I appreciate you hearing me out, Mr. President. I genuin..."*)

### Węzeł `[205]`
Mówca: **Gus Manger**
> ""I appreciate you hearing me out, Mr. President. I genuinely believe this plan could work wonders for our rural folks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "Our talk was interrupted by a noise coming from outside t..."*)

### Węzeł `[206]`
Mówca: **Gus Manger**
> ""That's all I'm asking for, Mr. President. Just give this plan a fair shake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "Our talk was interrupted by a noise coming from outside t..."*)

### Węzeł `[207]`
Mówca: **Gus Manger**
> ""Sure, Mr. President, doubts are part of the game. I trust you'll play the cards right for all of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "Our talk was interrupted by a noise coming from outside t..."*)

### Węzeł `[208]`
Mówca: **Gus Manger**
> ""This Workers' Rights Bill... Look, I'm all for giving hard-working folks what they deserve. But, isn't it a bit hasty to push this while we're still stuck in a recession?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Gus Manger: ""The way I see it, short-term wins might end up costing u..."*)

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""In my book, workers' rights aren't up for negotiation, no matter the economic climate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Gus Manger: ""Mr. President, I respect your stance. But let's not forg..."*)

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We've got to play this smart. We can't risk another economic blow.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Gus Manger: ""Mr. President, I'm glad you're thinking about the big pi..."*)

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gus, I get what you're saying. But isn't it high time we put people before profits?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Gus Manger: ""I see where you're coming from, Mr. President. But a pro..."*)

### Węzeł `[212]`
Mówca: **Gus Manger**
> ""I see where you're coming from, Mr. President. But a prosperous economy helps everyone - the workers included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Gus Manger: ""If we're all sinking, nobody's winning.""*)

### Węzeł `[213]`
Mówca: **Gus Manger**
> ""Mr. President, I'm glad you're thinking about the big picture. We've got to strike a balance to protect our economy and our workers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Gus Manger: ""Timing and approach are everything.""*)

### Węzeł `[214]`
Mówca: **Gus Manger**
> ""Mr. President, I respect your stance. But let's not forget about the potential fallout.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Gus Manger: ""There's got to be a way to improve workers' rights witho..."*)

### Węzeł `[215]`
Mówca: **Gus Manger**
> ""Or here's another thought - we could pour resources into developing crop breeds tailor-made for Gruni conditions. If it works out, we could roll this out across Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "He kept talking as he guided me into the Gasom building."*)

### Węzeł `[216]`
Mówca: **Gus Manger**
> ""The way I see it, short-term wins might end up costing us big time in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Player: ""Gus, I get what you're saying. But isn't it high time we..."*)
  - -> `[210]` (*Player: ""We've got to play this smart. We can't risk another econ..."*)
  - -> `[209]` (*Player: ""In my book, workers' rights aren't up for negotiation, n..."*)
  - -> `[242]` (*Player: ""Heard a worker from Estord on the radio. Said he's got r..."*)

### Węzeł `[217]`
Mówca: **Narrator**
> "Our talk was interrupted by a noise coming from outside the building. We looked out the nearest window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Narrator: "A sleek helicopter was cutting through the sky, sunlight ..."*)

### Węzeł `[218]`
Mówca: **Gus Manger**
> ""But I'm telling you, if we put the brakes on that and funnel those funds into the Gruni plan instead, we could make some real strides without spooking any potential investors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)
  - -> `[204]` (*Player: ""Gus, I'm intrigued by your vision. I'll seriously consid..."*)
  - -> `[203]` (*Player: ""It's a tough call, Gus. I need to weigh the environmenta..."*)
  - -> `[202]` (*Player: ""I have my doubts, Gus. But I'll give your plan some thou..."*)

### Węzeł `[219]`
Mówca: **Gus Manger**
> ""Spectacle aside… before we sit down with him, there's one more Assembly matter I wanted to raise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Gus Manger: ""This Workers' Rights Bill... Look, I'm all for giving ha..."*)

### Węzeł `[220]`
Mówca: **Narrator**
> "On it was our next appointment, Ewald Alphonso."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Player: ""Is that a helicopter or just his ego with rotor blades?""*)
  - -> `[223]` (*Player: ""Alphonso sure knows how to make an entrance.""*)
  - -> `[221]` (*Player: ""An extravagant show of wealth, isn't it? Hardly seems ne..."*)
  - -> `[222]` (*Player: ""That kind of display plays well to investors... but terr..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""An extravagant show of wealth, isn't it? Hardly seems necessary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Gus Manger: ""It's Alphonso's style, Mr. President. He's always enjoye..."*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That kind of display plays well to investors... but terribly to farmers watching on state TV.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Gus Manger: ""Exactly. The optics matter. We just have to decide who w..."*)

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Alphonso sure knows how to make an entrance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Gus Manger: ""The man loves his theatrics.""*)

### Węzeł `[224]`
Mówca: **Gus Manger**
> ""The man loves his theatrics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Gus Manger: ""Spectacle aside… before we sit down with him, there's on..."*)

### Węzeł `[225]`
Mówca: **Gus Manger**
> ""Exactly. The optics matter. We just have to decide who we’re trying to impress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Gus Manger: ""Spectacle aside… before we sit down with him, there's on..."*)

### Węzeł `[226]`
Mówca: **Gus Manger**
> ""It's Alphonso's style, Mr. President. He's always enjoyed his toys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Gus Manger: ""Spectacle aside… before we sit down with him, there's on..."*)

### Węzeł `[227]`
Mówca: **Narrator**
> "A sleek helicopter was cutting through the sky, sunlight glinting off its polished surface as it descended towards us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "On it was our next appointment, Ewald Alphonso."*)

### Węzeł `[228]`
Mówca: **Narrator**
> "He kept talking as he guided me into the Gasom building."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Gus Manger: ""Mr. President, I get the appeal of that GREEN bill that'..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_InfrastructureProject_Invest =..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_InfrastructureProject_Invest == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I grew up around people like the ones this would help, Gus. If your plan’s solid, I want it to work.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Kontekst wejściowy (poprzednik):** `[218]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Gus Manger: ""Then we’re on the same page, Mr. President. Let’s make s..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Player: ""I grew up around people like the ones this would help, G..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[236]`
Mówca: **Gus Manger**
> ""Then we’re on the same page, Mr. President. Let’s make sure they feel seen for once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "Our talk was interrupted by a noise coming from outside t..."*)

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is that a helicopter or just his ego with rotor blades?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Gus Manger: ""He calls it branding. I call it a fuel bill with sound e..."*)

### Węzeł `[238]`
Mówca: **Gus Manger**
> ""He calls it branding. I call it a fuel bill with sound effects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Gus Manger: ""Spectacle aside… before we sit down with him, there's on..."*)

### Węzeł `[239]`
Mówca: **Gus Manger**
> ""If we're all sinking, nobody's winning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player: ""If we overload businesses now, they'll shrink or shut do..."*)
  - -> `[245]` (*Player: ""Strong labor protections are the foundation of lasting g..."*)
  - -> `[246]` (*Player: ""Let’s think of the option that signals progress without ..."*)
  - -> `[247]` (*Player: ""People don’t care about long-term strategy when their ki..."*)

### Węzeł `[240]`
Mówca: **Gus Manger**
> ""Timing and approach are everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player: ""If we overload businesses now, they'll shrink or shut do..."*)
  - -> `[245]` (*Player: ""Strong labor protections are the foundation of lasting g..."*)
  - -> `[246]` (*Player: ""Let’s think of the option that signals progress without ..."*)
  - -> `[247]` (*Player: ""People don’t care about long-term strategy when their ki..."*)

### Węzeł `[241]`
Mówca: **Gus Manger**
> ""There's got to be a way to improve workers' rights without rocking the economic boat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player: ""If we overload businesses now, they'll shrink or shut do..."*)
  - -> `[245]` (*Player: ""Strong labor protections are the foundation of lasting g..."*)
  - -> `[246]` (*Player: ""Let’s think of the option that signals progress without ..."*)
  - -> `[247]` (*Player: ""People don’t care about long-term strategy when their ki..."*)

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Heard a worker from Estord on the radio. Said he's got rights on paper, but nothing in his fridge.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Gus Manger: ""That kind of thing sticks with you. Still, we’ve got to ..."*)

### Węzeł `[243]`
Mówca: **Gus Manger**
> ""That kind of thing sticks with you. Still, we’ve got to make sure the fixes don’t break something bigger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player: ""If we overload businesses now, they'll shrink or shut do..."*)
  - -> `[245]` (*Player: ""Strong labor protections are the foundation of lasting g..."*)
  - -> `[246]` (*Player: ""Let’s think of the option that signals progress without ..."*)
  - -> `[247]` (*Player: ""People don’t care about long-term strategy when their ki..."*)

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If we overload businesses now, they'll shrink or shut down. Workers lose more than just rights, they lose jobs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[239]` (Gus Manger), `[240]` (Gus Manger), `[241]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Gus Manger: ""Exactly. We can’t let good intentions gut the economy.""*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Strong labor protections are the foundation of lasting growth. A secure worker is a productive one.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[239]` (Gus Manger), `[240]` (Gus Manger), `[241]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Gus Manger: ""Fair enough, but let’s roll it out in stages. Rushing it..."*)

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let’s think of the option that signals progress without rattling the markets. We need both stability and reform.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[239]` (Gus Manger), `[240]` (Gus Manger), `[241]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Gus Manger: ""That’s the sweet spot. You bring the idealism, I’ll help..."*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""People don’t care about long-term strategy when their kids are hungry now. We fix this for them, or we lose them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[239]` (Gus Manger), `[240]` (Gus Manger), `[241]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Gus Manger: ""Hard to argue with that. Just make sure we don’t promise..."*)

### Węzeł `[248]`
Mówca: **Gus Manger**
> ""Exactly. We can’t let good intentions gut the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Gus Manger: ""Please come this way. Ewald and I have some exciting new..."*)

### Węzeł `[249]`
Mówca: **Gus Manger**
> ""Fair enough, but let’s roll it out in stages. Rushing it could backfire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Gus Manger: ""Please come this way. Ewald and I have some exciting new..."*)

### Węzeł `[250]`
Mówca: **Gus Manger**
> ""That’s the sweet spot. You bring the idealism, I’ll help shape the rollout.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Gus Manger: ""Please come this way. Ewald and I have some exciting new..."*)

### Węzeł `[251]`
Mówca: **Gus Manger**
> ""Hard to argue with that. Just make sure we don’t promise more than the treasury can carry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Gus Manger: ""Please come this way. Ewald and I have some exciting new..."*)
