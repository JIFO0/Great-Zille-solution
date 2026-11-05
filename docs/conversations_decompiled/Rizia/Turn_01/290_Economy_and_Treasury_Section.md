# Rizia/Turn 1/Economy and Treasury Section

- **ID konwersacji:** `290`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Rizia/Turn_01/290_Economy_and_Treasury_Section.md`
- **Liczba węzłów dialogowych:** 438
- **Liczba wyborów gracza:** 102

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[70]** Laurento Esquibel
- **[73]** Lucita Azaro
- **[79]** Vina Toras
- **[80]** Elena Werner
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax`
- `RiziaDLC.Prologue_Focus_ArmedForces`
- `RiziaDLC.Prologue_Focus_EnergyIndustry`
- `RiziaDLC.Prologue_Focus_TreasuryFinances`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Prologue_JoinedSuOmina`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Budget`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gas`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes`
- `RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.PersonalValue_Pacifist`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Relations_Vina`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Budget`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gas`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes`
- `RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[289] Rizia/Turn 1/EnT_CouncilBriefing** (../Turn_01/289_EnT_CouncilBriefing.md), Węzeł `[262]`
- Węzeł `[428]` -> **[289] Rizia/Turn 1/EnT_CouncilBriefing** (../Turn_01/289_EnT_CouncilBriefing.md), Węzeł `[284]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **""He had the right idea. If Rumburg and the other countries in GRACE stop importing..."** | `[85]` **Elena Werner**: ""Now, new gold mines are scarce,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Laurento Esquibel**: ""Why would Rumburg suddenly put ..." |
| `[9]` | **""How much of our revenue comes from taxes?""** | `[78]` **Elena Werner**: ""Where should I start?""<br>`[17]` **Elena Werner**: ""For now, are there any other qu..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes"] == false` | *Brak zmian stanu* | `[23]` **Elena Werner**: ""Historically, our resource-base..." |
| `[13]` | **""We don't know how much of Queen Beatrice's goodwill was due to my ties with her s..."** | `[7]` **Laurento Esquibel**: ""Why would Rumburg suddenly put ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Elena Werner**: ""As a fellow monarchy and a memb..." |
| `[14]` | **""I'm just speaking in hypotheticals.""** | `[7]` **Laurento Esquibel**: ""Why would Rumburg suddenly put ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Elena Werner**: ""It's always a good idea to envi..." |
| `[15]` | **""I trust Rumburg, but it's never wise for a country to rely too much on one tradin..."** | `[7]` **Laurento Esquibel**: ""Why would Rumburg suddenly put ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Laurento Esquibel**: ""Very astute, Your Majesty. I di..." |
| `[21]` | **""That's all the information I need for now.""** | `[78]` **Elena Werner**: ""Where should I start?""<br>`[17]` **Elena Werner**: ""For now, are there any other qu..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Budget"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold"] == true  or  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gas"] == true` | *Brak zmian stanu* | `[293]` **Elena Werner**: ""Perfect, Your Majesty."" |
| `[24]` | **""Watch your words, Ms. Werner. The nobility may not have an income, but we are the..."** | `[187]` **Elena Werner**: ""The central government does col..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Lucita Azaro**: ""Agreed, Your Majesty. Without m..." |
| `[25]` | **""That doesn't seem fair. Low-earning workers pay taxes while nobles don't?""** | `[187]` **Elena Werner**: ""The central government does col..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Elena Werner**: ""I didn't make the rules, Your M..." |
| `[28]` | **""Could we generate extra revenue by introducing estate or inheritance taxes?""** | `[187]` **Elena Werner**: ""The central government does col..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Elena Werner**: ""We definitely could, Your Majes..." |
| `[37]` | **""Not particularly. I'm the Party Prince, remember?""** | `[3]` **Elena Werner**: ""Surely His Majesty already has ..." | `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true` | *Brak zmian stanu* | `[49]` **Elena Werner**: ""I doubt anyone here has forgott..." |
| `[38]` | **""We've got gold, we've got energy. What else do I need to know?""** | `[3]` **Elena Werner**: ""Surely His Majesty already has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Elena Werner**: ""It's slightly more complicated ..." |
| `[39]` | **""I know the broad strokes. But I'm happy to get caught up on the details.""** | `[3]` **Elena Werner**: ""Surely His Majesty already has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Elena Werner**: ""Certainly, Your Majesty."" |
| `[43]` | **""Yes, but I'm sure my daughter would appreciate a refresher course.""** | `[3]` **Elena Werner**: ""Surely His Majesty already has ..." | `Variable["RiziaDLC.Vina_OnCouncil"] == true` | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[45]` **Narrator**: "Elena smiled at Vina." |
| `[54]` | **""Excuse me? What field would that be?""** | `[53]` **Laurento Esquibel**: ""Careful, Ms. Werner. One should..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Narrator**: "Elena looked at Laurento, then a..." |
| `[55]` | **""The south of Caleqabiz... wouldn't that put the field close to Pales?""** | `[53]` **Laurento Esquibel**: ""Careful, Ms. Werner. One should..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Narrator**: "Laurento gave me a significant l..." |
| `[56]` | **""You will quit squabbling and tell me about this new field at once.""** | `[53]` **Laurento Esquibel**: ""Careful, Ms. Werner. One should..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["Riz...` | `[299]` **Narrator**: "Laurento looked down at the table." |
| `[59]` | **""What are we waiting for? Let's get to drilling!""** | `[68]` **Elena Werner**: ""But we may have at least part o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Narrator**: "Elena suppressed a smile." |
| `[60]` | **""We should proceed very carefully with this. We don't want a gas dispute on our ha..."** | `[68]` **Elena Werner**: ""But we may have at least part o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Laurento Esquibel**: ""Wise words, Your Majesty."" |
| `[61]` | **""Perhaps we should let it go, in the interest of keeping the peace with Pales.""** | `[68]` **Elena Werner**: ""But we may have at least part o..." | `Variable["RiziaDLC.Prologue_HostileToPales"] == false` | *Brak zmian stanu* | `[303]` **Laurento Esquibel**: ""I agree that maintaining or eve..." |
| `[63]` | **""You're right, Vina. Duchess Azaro, save the military talk for your own briefing.""** | `[73]` **Vina Toras**: ""I don't know why we're even dis..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[182]` **Lucita Azaro**: ""Forgive me, Your Majesty. I tho..." |
| `[64]` | **""Don't interrupt my councilors, Vina. You will speak only when spoken to.""** | `[73]` **Vina Toras**: ""I don't know why we're even dis..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[181]` **Vina Toras**: ""Sorry, Father. I got overexcited."" |
| `[67]` | **""Time to grow up, my dear daughter. In real life, there's always a winner and a lo..."** | `[73]` **Vina Toras**: ""I don't know why we're even dis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Vina Toras**: ""Oh, but--"" |
| `[82]` | **""Tell me about our government budget.""** | `[78]` **Elena Werner**: ""Where should I start?""<br>`[17]` **Elena Werner**: ""For now, are there any other qu..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Budget"] == false` | *Brak zmian stanu* | `[4]` **Elena Werner**: ""It's healthy, Your Majesty."" |
| `[86]` | **""Do not slander the late King of Rizia. I'm sure my father had his reasons for suc..."** | `[85]` **Elena Werner**: ""Now, new gold mines are scarce,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Laurento Esquibel**: ""Elena meant no offense, Your Ma..." |
| `[89]` | **""Nonetheless, it's great to know that we're not going broke.""** | `[85]` **Elena Werner**: ""Now, new gold mines are scarce,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Lucita Azaro**: ""With that said, our budget will..." |
| `[90]` | **""No need to sugarcoat it. He was a miser.""** | `[85]` **Elena Werner**: ""Now, new gold mines are scarce,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Elena Werner**: ""He had his reasons, I'm sure. B..." |
| `[94]` | **""What's been going on with our gold industry?""** | `[78]` **Elena Werner**: ""Where should I start?""<br>`[17]` **Elena Werner**: ""For now, are there any other qu..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold"] == false` | *Brak zmian stanu* | `[397]` **Narrator**: "She smiled fondly."<br>`[134]` **Elena Werner**: ""Well, Your Majesty, gold is sti..." |
| `[98]` | **""Why wouldn't it be, Ms. Werner? Rizia continues to have many enemies, both foreig..."** | `[97]` **Elena Werner**: ""With all due respect, Duchess A..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["R...` | `[103]` **Lucita Azaro**: ""Very well said, Your Majesty. W..." |
| `[100]` | **""It most certainly is not. That money should be spent on the Rizian people, not we..."** | `[97]` **Elena Werner**: ""With all due respect, Duchess A..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["R...` | `[106]` **Laurento Esquibel**: ""I agree, Your Majesty. Think of..." |
| `[101]` | **""The last time Rizia had a strong military, its members mutinied against us.""** | `[97]` **Elena Werner**: ""With all due respect, Duchess A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Lucita Azaro**: ""That was many years ago, Your M..." |
| `[104]` | **""No, it isn't. If we invest our surplus in Rizian industries, we'll get back what ..."** | `[97]` **Elena Werner**: ""With all due respect, Duchess A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Elena Werner**: ""Very good thinking, Your Majesty."" |
| `[119]` | **""Shh. You're supposed to be a silent observer.""** | `[117]` **Vina Toras**: ""'True prosperity is not defined..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[127]` **Narrator**: "Vina blushed and lowered her eye..." |
| `[120]` | **""Truer words have never been spoken.""** | `[117]` **Vina Toras**: ""'True prosperity is not defined..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[129]` **Narrator**: "Vina beamed. Hugo nodded in agre..." |
| `[121]` | **""More pragmatically, a happy and well-fed populace is one that does not rise up ag..."** | `[117]` **Vina Toras**: ""'True prosperity is not defined..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[130]` **Narrator**: "Hugo nodded." |
| `[122]` | **""It's true that a happy and well-fed populace is one that does not rise up against..."** | `[332]` **Laurento Esquibel**: ""'True prosperity is not defined..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[130]` **Narrator**: "Hugo nodded." |
| `[123]` | **""On the other hand, there can be no welfare without security. What good is health ..."** | `[117]` **Vina Toras**: ""'True prosperity is not defined..."<br>`[332]` **Laurento Esquibel**: ""'True prosperity is not defined..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Narrator**: "Hugo put up a hand." |
| `[124]` | **""Indeed, Mr. Esquibel. If we focus on citizen welfare, we can set the standard not..."** | `[332]` **Laurento Esquibel**: ""'True prosperity is not defined..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Narrator**: "Hugo nodded." |
| `[136]` | **""Can't we increase our mining efforts within Rizia to make up for the loss?""** | `[295]` **Laurento Esquibel**: ""It was established shortly befo..." | `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] == false`<br>`(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] == true) == false` | *Brak zmian stanu* | `[135]` **Elena Werner**: ""We can try. There are a number ..." |
| `[140]` | **""How much say does the government have over operations in the MITZ?""** | `[295]` **Laurento Esquibel**: ""It was established shortly befo..." | `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs"] == false`<br>`(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] == true) == false` | *Brak zmian stanu* | `[141]` **Elena Werner**: ""A fair amount. Any changes to r..." |
| `[142]` | **""When we get Zille back, will we get its gold back as well?""** | `[295]` **Laurento Esquibel**: ""It was established shortly befo..." | `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille"] == false`<br>`(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] == true) == false` | *Brak zmian stanu* | `[143]` **Elena Werner**: ""I certainly hope so. Wehlen has..." |
| `[164]` | **""Let's talk about our energy holdings.""** | `[78]` **Elena Werner**: ""Where should I start?""<br>`[17]` **Elena Werner**: ""For now, are there any other qu..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gas"] == false` | *Brak zmian stanu* | `[165]` **Narrator**: "Elena rubbed her hands together." |
| `[192]` | **""Ten percent... that's low, isn't it?""** | `[187]` **Elena Werner**: ""The central government does col..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Elena Werner**: ""Compared to most of our neighbo..." |
| `[195]` | **""Actually, could we raise that rate?""** | `[196]` **Hugo Toras**: ""The commoners should consider t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Hugo Toras**: ""I don't think it would be wise...." |
| `[199]` | **""But nobles only got the money for those investments by siphoning it from hard-wor..."** | `[198]` **Lucita Azaro**: ""Yes, our families' investments ..."<br>`[205]` **Lucita Azaro**: ""And our family's investments po..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable...` | `[217]` **Narrator**: "Hugo looked at me strangely." |
| `[200]` | **""You have a point. We shouldn't disincentivize families like yours from supporting..."** | `[198]` **Lucita Azaro**: ""Yes, our families' investments ..."<br>`[205]` **Lucita Azaro**: ""And our family's investments po..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Hugo Toras**: ""Think of your own house, Your M..." |
| `[201]` | **""I'm still not convinced. But I'll drop the subject for now.""** | `[198]` **Lucita Azaro**: ""Yes, our families' investments ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Elena Werner**: ""Very well, Your Majesty. For th..." |
| `[202]` | **""I still think that rate could be higher. Imagine what we could do with the funding!""** | `[194]` **Hugo Toras**: ""This is by the House of Delegat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Elena Werner**: ""We already have a budget surplu..." |
| `[203]` | **""A wise idea. But it leaves us at the mercy of our resources and trade partners.""** | `[194]` **Hugo Toras**: ""This is by the House of Delegat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Elena Werner**: ""Not completely. But yes, if our..." |
| `[204]` | **""I understand. We certainly don't want another uprising.""** | `[194]` **Hugo Toras**: ""This is by the House of Delegat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Elena Werner**: ""At the moment, we have little r..." |
| `[207]` | **""It's no wonder there hasn't been another uprising when they're paying that little.""** | `[196]` **Hugo Toras**: ""The commoners should consider t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Hugo Toras**: ""Yes, this was the House of Dele..." |
| `[209]` | **""Why not get rid of income tax altogether, then?""** | `[194]` **Hugo Toras**: ""This is by the House of Delegat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Elena Werner**: ""That would be a risk, Your Maje..." |
| `[211]` | **""I do wonder if the nobility should contribute more. We can certainly afford to.""** | `[196]` **Hugo Toras**: ""The commoners should consider t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Hugo Toras**: ""If you'd like to retain the loy..." |
| `[226]` | **""Please explain it to me.""** | `[225]` **Laurento Esquibel**: ""Are you familiar with Rizia's t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Laurento Esquibel**: ""After the Wehlen Civil War, we ..." |
| `[227]` | **""Yes, I believe I am.""** | `[225]` **Laurento Esquibel**: ""Are you familiar with Rizia's t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Laurento Esquibel**: ""Granting 'labor hand' visas to ..." |
| `[233]` | **""They should have the same working rights as their Rizian counterparts. Especially..."** | `[230]` **Laurento Esquibel**: ""The program did wonders for the..."<br>`[232]` **Laurento Esquibel**: ""But as a result, Rizia now has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Hugo Toras**: ""Rizia offered Wehzeks asylum wh..." |
| `[234]` | **""If the system functions, I see no need to change it.""** | `[230]` **Laurento Esquibel**: ""The program did wonders for the..."<br>`[232]` **Laurento Esquibel**: ""But as a result, Rizia now has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Laurento Esquibel**: ""I wouldn't say it functions. Ba..." |
| `[235]` | **""Those visas were granted to temporary residents. They were supposed to go home at..."** | `[230]` **Laurento Esquibel**: ""The program did wonders for the..."<br>`[232]` **Laurento Esquibel**: ""But as a result, Rizia now has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Elena Werner**: ""That was the initial aim. But R..." |
| `[236]` | **""I see where you're going with this, but granting them full employment rights woul..."** | `[230]` **Laurento Esquibel**: ""The program did wonders for the..."<br>`[232]` **Laurento Esquibel**: ""But as a result, Rizia now has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[241]` **Laurento Esquibel**: ""I'm not sure about that. The si..." |
| `[246]` | **""I'm just being pragmatic. Expanding foreign workers' rights does seem like a conv..."** | `[245]` **Hugo Toras**: ""There was a time when you suppo..."<br>`[237]` **Hugo Toras**: ""Rizia offered Wehzeks asylum wh..." | `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false` | *Brak zmian stanu* | `[258]` **Lucita Azaro**: ""From a security standpoint, all..." |
| `[252]` | **""I was a different person back in those days. I no longer support Su Omina or the ..."** | `[245]` **Hugo Toras**: ""There was a time when you suppo..."<br>`[251]` **Hugo Toras**: ""I recall you once supported tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[264]` **Lucita Azaro**: ""I will add that from a security..." |
| `[253]` | **""I did and I still do. I'm all for diversity, but we Rizians cannot allow ourselve..."** | `[251]` **Hugo Toras**: ""I recall you once supported tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Lucita Azaro**: ""I will point out that from a se..." |
| `[254]` | **""Taking advantage of migrants' dire financial situation by forcing them to work fo..."** | `[245]` **Hugo Toras**: ""There was a time when you suppo..."<br>`[237]` **Hugo Toras**: ""Rizia offered Wehzeks asylum wh..." | `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false` | *Brak zmian stanu* | `[264]` **Lucita Azaro**: ""I will add that from a security..." |
| `[255]` | **""From a purely pragmatic point of view, expanding foreign workers' rights does see..."** | `[251]` **Hugo Toras**: ""I recall you once supported tha..."<br>`[247]` **Hugo Toras**: ""Rizia offered Wehzeks asylum wh..." | `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false` | *Brak zmian stanu* | `[260]` **Lucita Azaro**: ""And from a security standpoint,..." |
| `[256]` | **""Perhaps. But I do worry that having a growing army of disenfranchised laborers wi..."** | `[245]` **Hugo Toras**: ""There was a time when you suppo..."<br>`[237]` **Hugo Toras**: ""Rizia offered Wehzeks asylum wh..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false` | *Brak zmian stanu* | `[259]` **Lucita Azaro**: ""Very possible, Your Majesty. An..." |
| `[257]` | **""Exactly. I'm all for diversity, but we Rizians cannot allow ourselves to become o..."** | `[247]` **Hugo Toras**: ""Rizia offered Wehzeks asylum wh..." | `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false` | *Brak zmian stanu* | `[265]` **Lucita Azaro**: ""I will point out that from a se..." |
| `[266]` | **""Well put, Duchess. I can already tell you're going to be a brilliant addition to ..."** | `[263]` **Lucita Azaro**: ""Societies change, Your Grace. A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Lucita Azaro**: ""Thank you, Your Majesty."" |
| `[267]` | **""That's completely different. The Rumburgians are our blood relations.""** | `[263]` **Lucita Azaro**: ""Societies change, Your Grace. A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Hugo Toras**: ""There are also far fewer of them."" |
| `[268]` | **""To tell the truth, I'm not thrilled about any of those groups.""** | `[263]` **Lucita Azaro**: ""Societies change, Your Grace. A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Hugo Toras**: ""Nor am I. But the Rumburgians a..." |
| `[269]` | **""Rizia is a multicultural nation now, Hugo. Whether we like it or not.""** | `[263]` **Lucita Azaro**: ""Societies change, Your Grace. A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Hugo Toras**: ""We cannot let the events of the..." |
| `[279]` | **""You're right, Hugo. I'll take Duchess Azaro's suggestion seriously.""** | `[133]` **Hugo Toras**: ""However, those were different t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Lucita Azaro**: ""I'm honored, Your Majesty."" |
| `[280]` | **""Other countries might compete to have the biggest guns. Not Rizia.""** | `[133]` **Hugo Toras**: ""However, those were different t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[284]` **Lucita Azaro**: ""It's not about big guns, Your M..." |
| `[281]` | **""And there's the fact that we're sandwiched between the highly contentious regions..."** | `[133]` **Hugo Toras**: ""However, those were different t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Lucita Azaro**: ""Precisely, Your Majesty. We've ..." |
| `[282]` | **""If we cultivate our alliances well, we won't need that.""** | `[133]` **Hugo Toras**: ""However, those were different t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Lucita Azaro**: ""Allies can turn on us, Your Maj..." |
| `[307]` | **""Pales barely counts as a country. Of course we have a claim to the field.""** | `[68]` **Elena Werner**: ""But we may have at least part o..." | `(Variable["RiziaDLC.Prologue_HostileToPales"] == false) == false` | *Brak zmian stanu* | `[308]` **Narrator**: "Laurento looked uneasy." |
| `[313]` | **""Really, Duchess Azaro? Your family isn't itching for a rematch?""** | `[312]` **Lucita Azaro**: ""As we should. Nobody wants a re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Narrator**: "Lucita laughed uncomfortably." |
| `[314]` | **""If it *does* come down to that -- God forbid -- Rizia will win.""** | `[312]` **Lucita Azaro**: ""As we should. Nobody wants a re..." | `Variable["RiziaDLC.Prologue_HostileToPales"] == true` | *Brak zmian stanu* | `[323]` **Narrator**: "Lucita winced." |
| `[315]` | **""Indeed not. I will not practice the same mindless militarism as my father and Tad..."** | `[312]` **Lucita Azaro**: ""As we should. Nobody wants a re..." | `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false` | *Brak zmian stanu* | `[326]` **Narrator**: "Lucita's eyes narrowed." |
| `[319]` | **""If the Grand Duchy does not provoke us, we will not provoke them.""** | `[312]` **Lucita Azaro**: ""As we should. Nobody wants a re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Narrator**: "Lucita nodded." |
| `[337]` | **""Why do we have to talk about him? It's Rizian *Royal* Gold, after all.""** | `[336]` **Hugo Toras**: ""And unfortunately, we cannot ta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[342]` **Elena Werner**: ""That's the problem. It isn't ou..." |
| `[338]` | **""Why 'unfortunately', Your Grace?""** | `[336]` **Hugo Toras**: ""And unfortunately, we cannot ta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[343]` **Elena Werner**: ""Your uncle never could countena..." |
| `[339]` | **""We had better get that discussion over with.""** | `[336]` **Hugo Toras**: ""And unfortunately, we cannot ta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[344]` **Elena Werner**: ""For better or worse, our countr..." |
| `[340]` | **""Do not speak ill of our country's most vaunted businessman.""** | `[336]` **Hugo Toras**: ""And unfortunately, we cannot ta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[341]` **Hugo Toras**: ""My apologies, Your Majesty. Of ..." |
| `[345]` | **""I still cannot believe he was allowed to gain such a large majority.""** | `[347]` **Elena Werner**: ""Mr. Montoro -- excuse me, Rusty..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[350]` **Hugo Toras**: ""Nor can I, Your Majesty."" |
| `[348]` | **""That's fine by me. We all know that private enterprise can achieve what the gover..."** | `[347]` **Elena Werner**: ""Mr. Montoro -- excuse me, Rusty..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[353]` **Hugo Toras**: ""In some cases, perhaps. But aft..." |
| `[349]` | **""As much as I respect Rusty, I believe we royals should be in charge of our own go..."** | `[347]` **Elena Werner**: ""Mr. Montoro -- excuse me, Rusty..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Hugo Toras**: ""That will be difficult, Your Ma..." |
| `[355]` | **""I will not tolerate this. I want Rizia's original stake back.""** | `[346]` **Elena Werner**: ""After a *very* lengthy back-and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[361]` **Elena Werner**: ""Curry enough favor with Rusty, ..." |
| `[356]` | **""Rizia should not own 30 percent of RRG, or even 45 percent. The entire company sh..."** | `[346]` **Elena Werner**: ""After a *very* lengthy back-and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[360]` **Elena Werner**: ""It's not that simple."" |
| `[357]` | **""I don't see any problem with that. We shouldn't have so much of our money tied up..."** | `[346]` **Elena Werner**: ""After a *very* lengthy back-and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[358]` **Laurento Esquibel**: ""I beg your pardon, Your Majesty..." |
| `[370]` | **""I get the picture. Let's move on to other topics.""** | `[295]` **Laurento Esquibel**: ""It was established shortly befo..."<br>`[367]` **Narrator**: "I saw Hugo wince at that remark."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] == true) == false` | *Brak zmian stanu* | `[369]` **Elena Werner**: ""Yes, of course."" |
| `[384]` | **""I share your goals, Duchess. By the end of my reign, the Rizian Armed Forces shal..."** | `[383]` **Lucita Azaro**: ""I'm sure His Majesty will agree..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[385]` **Narrator**: "Lucita smiled." |
| `[387]` | **""Enhancing our army stockpiles will be good for Rizia's finances, Ms. Werner. If t..."** | `[383]` **Lucita Azaro**: ""I'm sure His Majesty will agree..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Elena Werner**: ""Hmm. You do have a point there."" |
| `[390]` | **""I chose to gave our military a much-needed upgrade before my coronation, yes. Tha..."** | `[383]` **Lucita Azaro**: ""I'm sure His Majesty will agree..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[391]` **Lucita Azaro**: ""Ah. Forgive me if I misundersto..." |
| `[408]` | **""I do, Ms. Werner. As a matter of fact, there's no need for today's briefing. Why ..."** | `[3]` **Elena Werner**: ""Surely His Majesty already has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[409]` **Narrator**: "My councilors glanced at each ot..." |
| `[411]` | **""I find I think best when I'm alone. Get me in my study with a fountain pen and a ..."** | `[415]` **Elena Werner**: ""Perhaps you're all caught up on..."<br>`[410]` **Elena Werner**: ""Are you sure, Your Majesty?"" | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[426]` **Narrator**: "She nodded slowly." |
| `[416]` | **""Very well. For Vina's sake, please proceed.""** | `[415]` **Elena Werner**: ""Perhaps you're all caught up on..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[45]` **Narrator**: "Elena smiled at Vina." |
| `[417]` | **""The Lord will guide me to make the right decisions, Elena. Your counsel is not ne..."** | `[415]` **Elena Werner**: ""Perhaps you're all caught up on..."<br>`[410]` **Elena Werner**: ""Are you sure, Your Majesty?"" | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[421]` **Narrator**: "Elena frowned, clearly hurt, bef..." |
| `[418]` | **""And learn she will. Vina, this is how a real king cuts through the blather and ge..."** | `[415]` **Elena Werner**: ""Perhaps you're all caught up on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[422]` **Narrator**: "Vina stared at me in confusion. ..." |
| `[419]` | **""You clearly worked hard to put today's briefing together. So please proceed.""** | `[410]` **Elena Werner**: ""Are you sure, Your Majesty?"" | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[47]` **Elena Werner**: ""Certainly, Your Majesty."" |
| `[424]` | **""Get some fresh air. Cut loose a little. It's not like you're getting any younger.""** | `[410]` **Elena Werner**: ""Are you sure, Your Majesty?"" | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[425]` **Narrator**: "A faint smile of amusement playe..." |
| `[431]` | **""I want to know what returns we’re getting through growth.""** | `[430]` **Hugo Toras**: ""It is the very structure of the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[436]` **Elena Werner**: ""Growth, trade, and indirect lev..." |
| `[432]` | **""Then let’s go over what each province contributes.""** | `[430]` **Hugo Toras**: ""It is the very structure of the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[435]` **Elena Werner**: ""Of course. Their profiles vary,..." |
| `[433]` | **""How are the provinces performing economically?""** | `[430]` **Hugo Toras**: ""It is the very structure of the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[434]` **Elena Werner**: ""There are key differences worth..." |

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
  - -> `[3]` (*Elena Werner: ""Surely His Majesty already has some awareness regarding ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Narrator: "She shrugged."*)

### Węzeł `[3]`
Mówca: **Elena Werner**
> ""Surely His Majesty already has some awareness regarding the state of Rizia's economy and resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[38]` (*Player_Romus: ""We've got gold, we've got energy. What else do I need to..."*)
  - -> `[39]` (*Player_Romus: ""I know the broad strokes. But I'm happy to get caught up..."*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[408]` (*Player_Romus: ""I do, Ms. Werner. As a matter of fact, there's no need f..."*)

### Węzeł `[4]`
Mówca: **Elena Werner**
> ""It's healthy, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Elena Werner: ""Since we began trading with Rumburg, we've been running ..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He had the right idea. If Rumburg and the other countries in GRACE stop importing from us, that surplus could disappear.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Laurento Esquibel: ""Why would Rumburg suddenly put an end to decades of peac..."*)

### Węzeł `[6]`
Mówca: **Elena Werner**
> ""Thanks to your own wise financial decisions over the past few years, that surplus is fairly high. But of course, there's always room for improvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Elena Werner: ""All glory to the late Valero, but he had a certain prude..."*)

### Węzeł `[7]`
Mówca: **Laurento Esquibel**
> ""Why would Rumburg suddenly put an end to decades of peaceful trade?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player_Romus: ""We don't know how much of Queen Beatrice's goodwill was ..."*)
  - -> `[14]` (*Player_Romus: ""I'm just speaking in hypotheticals.""*)
  - -> `[15]` (*Player_Romus: ""I trust Rumburg, but it's never wise for a country to re..."*)

### Węzeł `[8]`
Mówca: **Laurento Esquibel**
> ""A shortage of *Rizian* workers, Elena. Those vacancies could easily be filled with migrants from Wehlen and Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Hugo Toras: ""That is a slippery slope, Mr. Esquibel.""*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How much of our revenue comes from taxes?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes"] == false`
- **Kontekst wejściowy (poprzednik):** `[78]` (Elena Werner), `[17]` (Elena Werner), `[276]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Elena Werner: ""Historically, our resource-based economy has allowed us ..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes == false"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes == false)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus: ""How much of our revenue comes from taxes?""*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't know how much of Queen Beatrice's goodwill was due to my ties with her sister. With Lena gone, we can't take Rumburg's loyalty for granted.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Elena Werner: ""As a fellow monarchy and a member of the Guild of Royal ..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm just speaking in hypotheticals.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Elena Werner: ""It's always a good idea to envision all possible scenari..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust Rumburg, but it's never wise for a country to rely too much on one trading partner. We need to diversify.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Laurento Esquibel: ""Very astute, Your Majesty. I did have a number of altern..."*)

### Węzeł `[16]`
Mówca: **Laurento Esquibel**
> ""Very astute, Your Majesty. I did have a number of alternative candidates in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Elena Werner: ""Thank you, Mr. Esquibel. You'll get your chance to prese..."*)

### Węzeł `[17]`
Mówca: **Elena Werner**
> ""For now, are there any other questions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Gas = true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Budget == true ||RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes == true ||RiziaDLCIsolated.Turn01_Briefing_Econ_Gold == true || RiziaDLCIsolated.Turn01_Briefing_Econ_Gas == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Budget == true ||Ri..."*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Econ_Budget == true ||..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Budget == true ||RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes == true ||RiziaDLCIsolated.Turn01_Briefing_Econ_Gold == true || RiziaDLCIsolated.Turn01_Briefing_Econ_Gas == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Budget"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold"] == true  or  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""That's all the information I need for now.""*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Econ_Budget == true ||RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes == true ||RiziaDLCIsolated.Turn01_Briefing_Econ_Gold == true || RiziaDLCIsolated.Turn01_Briefing_Econ_Gas == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Budget"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold"] == true  or  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gas"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's all the information I need for now.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Budget"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold"] == true  or  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gas"] == true`
- **Kontekst wejściowy (poprzednik):** `[78]` (Elena Werner), `[17]` (Elena Werner), `[276]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Elena Werner: ""Perfect, Your Majesty.""*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Gas = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "Jump to: [Economy/Treasury Hub]"*)

### Węzeł `[23]`
Mówca: **Elena Werner**
> ""Historically, our resource-based economy has allowed us to have some of the lowest tax rates on the continent. It's been a real boon for businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Elena Werner: ""The central government does collect a flat income tax of..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Watch your words, Ms. Werner. The nobility may not have an income, but we are the foundation upon which Rizian society is built.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lucita Azaro: ""Agreed, Your Majesty. Without my family's manufacturing ..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That doesn't seem fair. Low-earning workers pay taxes while nobles don't?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Elena Werner: ""I didn't make the rules, Your Majesty. They were propose..."*)

### Węzeł `[26]`
Mówca: **Lucita Azaro**
> ""Agreed, Your Majesty. Without my family's manufacturing industry investments, for example, half of Cardesse-Montaklar would be out of a job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Hugo Toras: ""The commoners should consider themselves lucky. Ten perc..."*)

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""A ten percent tax is a low price for commoners to pay for the privilege of living and working in the best country in Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Lucita Azaro: ""And our family's investments power half of Rizia's busin..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Could we generate extra revenue by introducing estate or inheritance taxes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Elena Werner: ""We definitely could, Your Majesty.""*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Economy/Treasury Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "Economy/Treasury Hub"*)

### Węzeł `[30]`
Mówca: **Elena Werner**
> ""As a fellow monarchy and a member of the Guild of Royal Allies for Commercial Exchange, Rumburg has more than a familial interest in our partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Laurento Esquibel: ""With that said, your father was conservative when it cam..."*)

### Węzeł `[31]`
Mówca: **Elena Werner**
> ""Your House's province, Valenqiris, leads the realm in GDP... driven by its wine, gas, and tourism sectors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Elena Werner: ""Brenas is still suffering the effects of the loss of Iza..."*)

### Węzeł `[32]`
Mówca: **Elena Werner**
> ""The manufacturing concerns in Cardesse-Montaklar are doing very well, to the point that business councils are complaining about an imminent shortage of skilled workers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Laurento Esquibel: ""A shortage of *Rizian* workers, Elena. Those vacancies c..."*)

### Węzeł `[33]`
Mówca: **Elena Werner**
> ""Since we began trading with Rumburg, we've been running a surplus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 18"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player_Romus: ""Not particularly. I'm the Party Prince, remember?""*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not particularly. I'm the Party Prince, remember?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Elena Werner: ""I doubt anyone here has forgotten.""*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've got gold, we've got energy. What else do I need to know?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Elena Werner: ""It's slightly more complicated than that, Your Majesty.""*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know the broad strokes. But I'm happy to get caught up on the details.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Elena Werner: ""Certainly, Your Majesty.""*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player_Romus: ""Yes, but I'm sure my daughter would appreciate a refresh..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, but I'm sure my daughter would appreciate a refresher course.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "Elena smiled at Vina."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "Elena smiled at Vina."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Elena Werner: ""Certainly.""*)

### Węzeł `[46]`
Mówca: **Elena Werner**
> ""Certainly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "She smoothly adjusted her reading glasses before continuing."*)

### Węzeł `[47]`
Mówca: **Elena Werner**
> ""Certainly, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "She smoothly adjusted her reading glasses before continuing."*)

### Węzeł `[48]`
Mówca: **Elena Werner**
> ""It's slightly more complicated than that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "She smoothly adjusted her reading glasses before continuing."*)

### Węzeł `[49]`
Mówca: **Elena Werner**
> ""I doubt anyone here has forgotten.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "She smoothly adjusted her reading glasses before continuing."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "She smoothly adjusted her reading glasses before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Elena Werner: ""Until the 1940s, Rizia was historically one of the wealt..."*)

### Węzeł `[51]`
Mówca: **Elena Werner**
> ""Until the 1940s, Rizia was historically one of the wealthiest countries in South Merkopa. But His Majesty the late King Valero bequeathed us a number of challenges in that department.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Elena Werner: ""Where should I start?""*)

### Węzeł `[52]`
Mówca: **Elena Werner**
> ""Or we can spend our budget elsewhere as we wait for access to the new field south of Caleqabiz.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Laurento Esquibel: ""Careful, Ms. Werner. One shouldn't count one's pheasants..."*)

### Węzeł `[53]`
Mówca: **Laurento Esquibel**
> ""Careful, Ms. Werner. One shouldn't count one's pheasants before they've been bagged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player_Romus: ""Excuse me? What field would that be?""*)
  - -> `[56]` (*Player_Romus: ""You will quit squabbling and tell me about this new fiel..."*)
  - -> `[55]` (*Player_Romus: ""The south of Caleqabiz... wouldn't that put the field cl..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excuse me? What field would that be?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "Elena looked at Laurento, then at me."*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The south of Caleqabiz... wouldn't that put the field close to Pales?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "Laurento gave me a significant look."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will quit squabbling and tell me about this new field at once.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Tyrant += 1"*)

### Węzeł `[57]`
Mówca: **Narrator**
> "Elena looked at Laurento, then at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Elena Werner: ""Well... we're still in the extremely early stages.""*)

### Węzeł `[58]`
Mówca: **Elena Werner**
> ""Well... we're still in the extremely early stages.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Elena Werner: ""But we may have at least part of a claim to a substantia..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are we waiting for? Let's get to drilling!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "Elena suppressed a smile."*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We should proceed very carefully with this. We don't want a gas dispute on our hands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Laurento Esquibel: ""Wise words, Your Majesty.""*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps we should let it go, in the interest of keeping the peace with Pales.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_HostileToPales"] == false`
- **Kontekst wejściowy (poprzednik):** `[68]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Laurento Esquibel: ""I agree that maintaining or even improving our relations..."*)

### Węzeł `[62]`
Mówca: **Laurento Esquibel**
> ""Wise words, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Elena Werner: ""Our researchers have been investigating the field's size..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right, Vina. Duchess Azaro, save the military talk for your own briefing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't interrupt my councilors, Vina. You will speak only when spoken to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 1"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Lucita Azaro: ""Forgive me, Your Majesty. I thought you were asking for ..."*)

### Węzeł `[66]`
Mówca: **Elena Werner**
> ""We should save this discussion for if and when we know more about the gas field in question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Elena Werner: ""For now, are there any other questions?""*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Time to grow up, my dear daughter. In real life, there's always a winner and a loser.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Vina Toras: ""Oh, but--""*)

### Węzeł `[68]`
Mówca: **Elena Werner**
> ""But we may have at least part of a claim to a substantial reserve of natural gas between the port of Pales and the Rizian island of Caleqabiz.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player_Romus: ""What are we waiting for? Let's get to drilling!""*)
  - -> `[60]` (*Player_Romus: ""We should proceed very carefully with this. We don't wan..."*)
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == false"*)

### Węzeł `[69]`
Mówca: **Narrator**
> "Elena suppressed a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Elena Werner: ""I'd like nothing more, Your Majesty. But protocol must b..."*)

### Węzeł `[70]`
Mówca: **Elena Werner**
> ""Our researchers have been investigating the field's size and borders. Once those are known, it will be easy to determine ownership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Laurento Esquibel: ""Of course, we are liaising extremely closely with Pales ..."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "Laurento gave me a significant look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Laurento Esquibel: ""Exactly, Your Majesty. Ms. Werner, tell him.""*)

### Węzeł `[72]`
Mówca: **Laurento Esquibel**
> ""Exactly, Your Majesty. Ms. Werner, tell him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Elena Werner: ""Well... we're still in the extremely early stages.""*)

### Węzeł `[73]`
Mówca: **Vina Toras**
> ""I don't know why we're even discussing a military response. We'll surely be able to reach a compromise using proper diplomacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player_Romus: ""Don't interrupt my councilors, Vina. You will speak only..."*)
  - -> `[63]` (*Player_Romus: ""You're right, Vina. Duchess Azaro, save the military tal..."*)
  - -> `[67]` (*Player_Romus: ""Time to grow up, my dear daughter. In real life, there's..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "Vina tentatively raised her hand."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Elena gently cut in."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "Vina tentatively raised her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Vina Toras: ""I don't know why we're even discussing a military respon..."*)

### Węzeł `[78]`
Mówca: **Elena Werner**
> ""Where should I start?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "Economy/Treasury Hub"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Budget == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Budget == false"*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Econ_Budget == false)"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Budget == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Budget"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""Tell me about our government budget.""*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Econ_Budget == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Budget"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me about our government budget.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Budget"] == false`
- **Kontekst wejściowy (poprzednik):** `[78]` (Elena Werner), `[17]` (Elena Werner), `[276]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Elena Werner: ""It's healthy, Your Majesty.""*)

### Węzeł `[83]`
Mówca: **Elena Werner**
> ""It's always a good idea to envision all possible scenarios. But as a fellow monarchy and member of the Guild of Royal Allies for Commercial Exchange, it's against Rumburg's interests to disrupt our partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Laurento Esquibel: ""With that said, your father was conservative when it cam..."*)

### Węzeł `[84]`
Mówca: **Laurento Esquibel**
> ""With that said, your father was conservative when it came to our international trade. I have a number of alternative partners in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Elena Werner: ""Thank you, Mr. Esquibel. You'll get your chance to prese..."*)

### Węzeł `[85]`
Mówca: **Elena Werner**
> ""Now, new gold mines are scarce, our richest sources nearly depleted, and the Kingdom’s burdens have grown over the past decade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player_Romus: ""Do not slander the late King of Rizia. I'm sure my fathe..."*)
  - -> `[90]` (*Player_Romus: ""No need to sugarcoat it. He was a miser.""*)
  - -> `[89]` (*Player_Romus: ""Nonetheless, it's great to know that we're not going bro..."*)
  - -> `[5]` (*Player_Romus: ""He had the right idea. If Rumburg and the other countrie..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not slander the late King of Rizia. I'm sure my father had his reasons for such frugality.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Laurento Esquibel: ""Elena meant no offense, Your Majesty.""*)

### Węzeł `[87]`
Mówca: **Laurento Esquibel**
> ""Elena meant no offense, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Elena Werner: ""Indeed not. I'm just pointing out that the money is ther..."*)

### Węzeł `[88]`
Mówca: **Elena Werner**
> ""Indeed not. I'm just pointing out that the money is there, should you choose to spend it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Lucita Azaro: ""Great news, Ms. Werner. I already have a full slate of m..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nonetheless, it's great to know that we're not going broke.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Lucita Azaro: ""With that said, our budget will need more padding if we ..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to sugarcoat it. He was a miser.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Elena Werner: ""He had his reasons, I'm sure. But he did miss a number o..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Gold == false"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Econ_Gold == false)"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player_Romus: ""What's been going on with our gold industry?""*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Econ_Gold == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's been going on with our gold industry?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold"] == false`
- **Kontekst wejściowy (poprzednik):** `[78]` (Elena Werner), `[17]` (Elena Werner), `[276]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_TreasuryFinances == true"*)

### Węzeł `[95]`
Mówca: **Lucita Azaro**
> ""With that said, our budget will need more padding if we want to complete the slate of military modernization measures I have in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "Elena pursed her lips."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "Elena pursed her lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_ArmedForces == true"*)

### Węzeł `[97]`
Mówca: **Elena Werner**
> ""With all due respect, Duchess Azaro, I'm not sure the military is the King's number one focus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player_Romus: ""Why wouldn't it be, Ms. Werner? Rizia continues to have ..."*)
  - -> `[100]` (*Player_Romus: ""It most certainly is not. That money should be spent on ..."*)
  - -> `[101]` (*Player_Romus: ""The last time Rizia had a strong military, its members m..."*)
  - -> `[104]` (*Player_Romus: ""No, it isn't. If we invest our surplus in Rizian industr..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why wouldn't it be, Ms. Werner? Rizia continues to have many enemies, both foreign and internal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Pacifist -= 1"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Pacifist -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucita Azaro: ""Very well said, Your Majesty. We cannot rely on the like..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It most certainly is not. That money should be spent on the Rizian people, not weapons.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Pacifist += 1"*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The last time Rizia had a strong military, its members mutinied against us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Lucita Azaro: ""That was many years ago, Your Majesty. And the responsib..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Pacifist += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Laurento Esquibel: ""I agree, Your Majesty. Think of the advances we were abl..."*)

### Węzeł `[103]`
Mówca: **Lucita Azaro**
> ""Very well said, Your Majesty. We cannot rely on the likes of Wehlen or Rumburg to protect us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Laurento Esquibel: ""Ultimately, shouldn't that money be spent on the Rizian ..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, it isn't. If we invest our surplus in Rizian industries, we'll get back what we spent triplefold.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Elena Werner: ""Very good thinking, Your Majesty.""*)

### Węzeł `[105]`
Mówca: **Elena Werner**
> ""Very good thinking, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Laurento Esquibel: ""Ultimately, shouldn't that money be spent on the Rizian ..."*)

### Węzeł `[106]`
Mówca: **Laurento Esquibel**
> ""I agree, Your Majesty. Think of the advances we were able to make during the Lyza era due to the Queen's investments in citizen welfare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Laurento Esquibel: ""You'll recall her famous quote...""*)

### Węzeł `[107]`
Mówca: **Lucita Azaro**
> ""That was many years ago, Your Majesty. And the responsible parties have all been punished.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Laurento Esquibel: ""I do agree there are better uses for those funds. Think ..."*)

### Węzeł `[108]`
Mówca: **Lucita Azaro**
> ""Great news, Ms. Werner. I already have a full slate of military modernization measures I was hoping to propose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "Elena pursed her lips."*)

### Węzeł `[109]`
Mówca: **Elena Werner**
> ""He had his reasons, I'm sure. But he did miss a number of potentially lucrative investment opportunities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lucita Azaro: ""Including, of course, the opportunity to completely mode..."*)

### Węzeł `[110]`
Mówca: **Lucita Azaro**
> ""Including, of course, the opportunity to completely modernize the Rizian military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "Elena pursed her lips."*)

### Węzeł `[111]`
Mówca: **Elena Werner**
> ""Thank you, Mr. Esquibel. You'll get your chance to present those later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Elena Werner: ""For now, I will point out that holding on to that surplu..."*)

### Węzeł `[112]`
Mówca: **Elena Werner**
> ""For now, I will point out that holding on to that surplus has not done Rizia any favors. We have missed a number of potentially lucrative investment opportunities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lucita Azaro: ""Including, of course, the opportunity to completely mode..."*)

### Węzeł `[113]`
Mówca: **Laurento Esquibel**
> ""Ultimately, shouldn't that money be spent on the Rizian people? Think of the advances we were able to make during the Lyza era due to the Queen's investments in citizen welfare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Laurento Esquibel: ""You'll recall her famous quote...""*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Vina Toras: ""'True prosperity is not defined by the amount of gold in..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Laurento Esquibel: ""'True prosperity is not defined by the amount of gold in..."*)

### Węzeł `[117]`
Mówca: **Vina Toras**
> ""'True prosperity is not defined by the amount of gold in our coffers, but by the health and happiness of each soul within our borders.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player_Romus: ""Shh. You're supposed to be a silent observer.""*)
  - -> `[120]` (*Player_Romus: ""Truer words have never been spoken.""*)
  - -> `[121]` (*Player_Romus: ""More pragmatically, a happy and well-fed populace is one..."*)
  - -> `[123]` (*Player_Romus: ""On the other hand, there can be no welfare without secur..."*)

### Węzeł `[118]`
Mówca: **Laurento Esquibel**
> ""I do agree there are better uses for those funds. Think of the advances we were able to make during the Lyza era due to the Queen's investments in citizen welfare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Laurento Esquibel: ""You'll recall her famous quote...""*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shh. You're supposed to be a silent observer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 1"*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Truer words have never been spoken.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More pragmatically, a happy and well-fed populace is one that does not rise up against its leaders.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic -= 1"*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's true that a happy and well-fed populace is one that does not rise up against its leaders.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic -= 1"*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On the other hand, there can be no welfare without security. What good is health or happiness if we're unable to defend ourselves?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Vina Toras), `[332]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "Hugo put up a hand."*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed, Mr. Esquibel. If we focus on citizen welfare, we can set the standard not only for Merkopa, but for the world.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "Hugo nodded."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "Vina blushed and lowered her eyes. Hugo put up a hand."*)

### Węzeł `[126]`
Mówca: **Hugo Toras**
> ""If I may, the Princess has a point. Rizia's wealth, and my mother's judicious handling of it, was one of the factors that allowed us to survive the Century of Revolutions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Hugo Toras: ""However, those were different times. As a modern nation ..."*)

### Węzeł `[127]`
Mówca: **Narrator**
> "Vina blushed and lowered her eyes. Hugo put up a hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Hugo Toras: ""If I may, the Princess has a point. Rizia's wealth, and ..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "Vina beamed. Hugo nodded in agreement."*)

### Węzeł `[129]`
Mówca: **Narrator**
> "Vina beamed. Hugo nodded in agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Hugo Toras: ""I will point out that Rizia's wealth, and my mother's ju..."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "Hugo nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Hugo Toras: ""I will point out that Rizia's wealth, and my mother's ju..."*)

### Węzeł `[131]`
Mówca: **Hugo Toras**
> ""I will point out that Rizia's wealth, and my mother's judicious handling of it, was one of the factors that allowed us to survive the Century of Revolutions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Hugo Toras: ""However, those were different times. As a modern nation ..."*)

### Węzeł `[132]`
Mówca: **Narrator**
> "Hugo put up a hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Hugo Toras: ""I will point out that Rizia's wealth, and my mother's ju..."*)

### Węzeł `[133]`
Mówca: **Hugo Toras**
> ""However, those were different times. As a modern nation in an era of increasing superpower influence, we are expected to have a certain standard of military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Player_Romus: ""You're right, Hugo. I'll take Duchess Azaro's suggestion..."*)
  - -> `[280]` (*Player_Romus: ""Other countries might compete to have the biggest guns. ..."*)
  - -> `[281]` (*Player_Romus: ""And there's the fact that we're sandwiched between the h..."*)
  - -> `[282]` (*Player_Romus: ""If we cultivate our alliances well, we won't need that.""*)

### Węzeł `[134]`
Mówca: **Elena Werner**
> ""Well, Your Majesty, gold is still the backbone of the Rizian economy. Though production has declined as our reserves begin to exhaust themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Elena Werner: ""We have a number of active mines within the country, ope..."*)

### Węzeł `[135]`
Mówca: **Elena Werner**
> ""We can try. There are a number of promising sites that have yet to be explored.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Elena Werner: ""We would just need to commission a survey to find them. ..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't we increase our mining efforts within Rizia to make up for the loss?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] == false` AND `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[295]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Elena Werner: ""We can try. There are a number of promising sites that h..."*)

### Węzeł `[137]`
Mówca: **Elena Werner**
> ""We have a number of active mines within the country, operated by the Rizian Royal Gold corporation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "She and Hugo exchanged glances."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "She unrolled a map on the table and pointed to a region in the east of Morella."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap = true"*)

### Węzeł `[139]`
Mówca: **Elena Werner**
> ""The double blow of losing our mines in Zille and 15 percent of our RRG stake has made us quite reliant on the gold from the MITZ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "Laurento stroked his mustache."*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How much say does the government have over operations in the MITZ?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs"] == false` AND `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[295]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Elena Werner: ""A fair amount. Any changes to regulations or profit shar..."*)

### Węzeł `[141]`
Mówca: **Elena Werner**
> ""A fair amount. Any changes to regulations or profit shares have to be agreed on by all four nations involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Elena Werner: ""RRG gets a percentage of the MITZ profits for the use of..."*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""When we get Zille back, will we get its gold back as well?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille"] == false` AND `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[295]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Elena Werner: ""I certainly hope so. Wehlen has been mining extensively ..."*)

### Węzeł `[143]`
Mówca: **Elena Werner**
> ""I certainly hope so. Wehlen has been mining extensively in the region since taking over in 1927.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Elena Werner: ""But as per the terms of our agreement, Zille and all of ..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia == false"*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia == false)"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player_Romus: ""Can't we increase our mining efforts within Rizia to mak..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille == false"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille == false)"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player_Romus: ""When we get Zille back, will we get its gold back as well?""*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs == false"*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs == false)"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player_Romus: ""How much say does the government have over operations in..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "Jump to: [Gold Qs]"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "Jump to: [Gold Qs]"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "Jump to: [Gold Qs]"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs == true && RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille == true && RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs == true &..."*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs == true..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs == true && RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille == true && RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Elena Werner: ""That's it for our discussion on gold. Shall we move on?""*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs == true && RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille == true && RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia == false"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille == false"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs == false"*)
  - -> `[370]` (*Player_Romus: ""I get the picture. Let's move on to other topics.""*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Gold Qs`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs == true &..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Gold Qs]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "Gold Qs"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Gas == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Gas == false"*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Econ_Gas == false)"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Gas == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gas"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player_Romus: ""Let's talk about our energy holdings.""*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Econ_Gas == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gas"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's talk about our energy holdings.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gas"] == false`
- **Kontekst wejściowy (poprzednik):** `[78]` (Elena Werner), `[17]` (Elena Werner), `[276]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "Elena rubbed her hands together."*)

### Węzeł `[165]`
Mówca: **Narrator**
> "Elena rubbed her hands together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_EnergyIndustry == true"*)

### Węzeł `[166]`
Mówca: **Elena Werner**
> ""Very gladly, Your Majesty. This is a new area for us compared to gold, but the financial possibilities are intriguing indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap == true"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap == true"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap == true)"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "She pointed again at the map on the table, this time dire..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "She unrolled a map on the table and pointed to a region i..."*)

### Węzeł `[170]`
Mówca: **Narrator**
> "She pointed again at the map on the table, this time directing our attention to the east of Morella."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Elena Werner: ""The double blow of losing our mines in Zille and 15 perc..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Elena Werner: ""The double blow of losing our mines in Zille and 15 perc..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Elena Werner: ""Though our state energy company is called Rizian Oil and..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap == true"*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap == true)"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "She pointed at the map in front of her, this time directi..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "She unrolled a map on the table and pointed to the southe..."*)

### Węzeł `[176]`
Mówca: **Narrator**
> "She pointed at the map in front of her, this time directing our attention to the southern coast of Valenqiris."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Elena Werner: ""Though our state energy company is called Rizian Oil and..."*)

### Węzeł `[177]`
Mówca: **Narrator**
> "She unrolled a map on the table and pointed to the southern coast of Valenqiris."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap = true"*)

### Węzeł `[178]`
Mówca: **Elena Werner**
> ""Though our state energy company is called Rizian Oil and Gas, production of the former has slowed over the years, and is threatening to come to a complete halt. The latter, however, shows immense potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Elena Werner: ""Our most productive gas field is Esqiris, off the coast ..."*)

### Węzeł `[179]`
Mówca: **Elena Werner**
> ""Our most productive gas field is Esqiris, off the coast of Topes. Assuming enough money is invested into its expansion, we can expect it to fuel our kingdom for years to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Elena Werner: ""Or we can spend our budget elsewhere as we wait for acce..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Vina Toras: ""Sorry, Father. I got overexcited.""*)

### Węzeł `[181]`
Mówca: **Vina Toras**
> ""Sorry, Father. I got overexcited.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Elena gently cut in."*)

### Węzeł `[182]`
Mówca: **Lucita Azaro**
> ""Forgive me, Your Majesty. I thought you were asking for my input.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Elena gently cut in."*)

### Węzeł `[183]`
Mówca: **Vina Toras**
> ""Oh, but--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Elena gently cut in."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "Elena gently cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Elena Werner: ""We should save this discussion for if and when we know m..."*)

### Węzeł `[185]`
Mówca: **Elena Werner**
> ""That's it for our discussion on gold. Shall we move on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Gold = true"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Economy/Treasury Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Budget == false"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Gold == false"*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Gas == false"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes == false"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Budget == true ||Ri..."*)

### Węzeł `[187]`
Mówca: **Elena Werner**
> ""The central government does collect a flat income tax of ten percent. This is mostly paid by workers, since nobles have no income to speak of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player_Romus: ""Watch your words, Ms. Werner. The nobility may not have ..."*)
  - -> `[192]` (*Player_Romus: ""Ten percent... that's low, isn't it?""*)
  - -> `[25]` (*Player_Romus: ""That doesn't seem fair. Low-earning workers pay taxes wh..."*)
  - -> `[28]` (*Player_Romus: ""Could we generate extra revenue by introducing estate or..."*)

### Węzeł `[188]`
Mówca: **Elena Werner**
> ""I didn't make the rules, Your Majesty. They were proposed by the House of Delegates and agreed on by your father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Hugo Toras: ""A ten percent tax is a low price for commoners to pay fo..."*)

### Węzeł `[189]`
Mówca: **Elena Werner**
> ""We definitely could, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Elena Werner: ""I do happen to think that taxing wealthy nobles makes mo..."*)

### Węzeł `[190]`
Mówca: **Elena Werner**
> ""I do happen to think that taxing wealthy nobles makes more sense than taxing the workers who generate said wealth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Elena Werner: ""On the other hand, the current tax code was proposed by ..."*)

### Węzeł `[191]`
Mówca: **Elena Werner**
> ""On the other hand, the current tax code was proposed by the House of Delegates and agreed on by your father. It might not be easy to change it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Hugo Toras: ""Nor should we. Taxing nobles would be an attack on the v..."*)

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ten percent... that's low, isn't it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Elena Werner: ""Compared to most of our neighbors, yes. We do provide a ..."*)

### Węzeł `[193]`
Mówca: **Elena Werner**
> ""Compared to most of our neighbors, yes. We do provide a high standard of social services to our people, but it's mostly financed with trade income.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Hugo Toras: ""This is by the House of Delegates' design, Your Majesty...."*)

### Węzeł `[194]`
Mówca: **Hugo Toras**
> ""This is by the House of Delegates' design, Your Majesty. Lowering the tax burden on citizens leads to higher satisfaction with the government and less likelihood of rebellion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Player_Romus: ""I understand. We certainly don't want another uprising.""*)
  - -> `[203]` (*Player_Romus: ""A wise idea. But it leaves us at the mercy of our resour..."*)
  - -> `[202]` (*Player_Romus: ""I still think that rate could be higher. Imagine what we..."*)
  - -> `[209]` (*Player_Romus: ""Why not get rid of income tax altogether, then?""*)

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, could we raise that rate?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Hugo Toras: ""I don't think it would be wise. The House of Delegates d..."*)

### Węzeł `[196]`
Mówca: **Hugo Toras**
> ""The commoners should consider themselves lucky. Ten percent is far lower than elsewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Player_Romus: ""Actually, could we raise that rate?""*)
  - -> `[207]` (*Player_Romus: ""It's no wonder there hasn't been another uprising when t..."*)
  - -> `[211]` (*Player_Romus: ""I do wonder if the nobility should contribute more. We c..."*)

### Węzeł `[197]`
Mówca: **Hugo Toras**
> ""Nor should we. Taxing nobles would be an attack on the very backbone of Rizian society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Lucita Azaro: ""Yes, our families' investments power half the businesses..."*)

### Węzeł `[198]`
Mówca: **Lucita Azaro**
> ""Yes, our families' investments power half the businesses in this country. Why should we be forced to pay double?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player_Romus: ""But nobles only got the money for those investments by s..."*)
  - -> `[200]` (*Player_Romus: ""You have a point. We shouldn't disincentivize families l..."*)
  - -> `[201]` (*Player_Romus: ""I'm still not convinced. But I'll drop the subject for n..."*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But nobles only got the money for those investments by siphoning it from hard-working commoners. Isn't it our responsibility to break the cycle somehow?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Lucita Azaro), `[205]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist += 1"*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have a point. We shouldn't disincentivize families like yours from supporting Rizia's economy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Lucita Azaro), `[205]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Hugo Toras: ""Think of your own house, Your Majesty. Would the Rizian ..."*)

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still not convinced. But I'll drop the subject for now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Elena Werner: ""Very well, Your Majesty. For the record, I'm not convinc..."*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still think that rate could be higher. Imagine what we could do with the funding!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Elena Werner: ""We already have a budget surplus, Your Majesty. I see no..."*)

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A wise idea. But it leaves us at the mercy of our resources and trade partners.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Elena Werner: ""Not completely. But yes, if our international trade were..."*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. We certainly don't want another uprising.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Elena Werner: ""At the moment, we have little risk of that.""*)

### Węzeł `[205]`
Mówca: **Lucita Azaro**
> ""And our family's investments power half of Rizia's businesses anyway. Why ask us to pay double?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player_Romus: ""But nobles only got the money for those investments by s..."*)
  - -> `[200]` (*Player_Romus: ""You have a point. We shouldn't disincentivize families l..."*)

### Węzeł `[206]`
Mówca: **Hugo Toras**
> ""I don't think it would be wise. The House of Delegates determined that lowering the tax burden on citizens leads to higher satisfaction with the government and less likelihood of rebellion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Elena Werner: ""In terms of our provinces' individual contributions... t..."*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's no wonder there hasn't been another uprising when they're paying that little.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Hugo Toras: ""Yes, this was the House of Delegates' intention. Lowerin..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "Hugo looked at me strangely."*)

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why not get rid of income tax altogether, then?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Elena Werner: ""That would be a risk, Your Majesty. Without any other re..."*)

### Węzeł `[210]`
Mówca: **Hugo Toras**
> ""Yes, this was the House of Delegates' intention. Lowering the tax burden on citizens leads to higher satisfaction with the government and less likelihood of rebellion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Elena Werner: ""In terms of our provinces' individual contributions... t..."*)

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do wonder if the nobility should contribute more. We can certainly afford to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Hugo Toras: ""If you'd like to retain the loyalty of the House of Dele..."*)

### Węzeł `[212]`
Mówca: **Hugo Toras**
> ""If you'd like to retain the loyalty of the House of Delegates, I would suggest keeping our tax laws the way they are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Lucita Azaro: ""Yes, our families' investments power half the businesses..."*)

### Węzeł `[213]`
Mówca: **Elena Werner**
> ""That would be a risk, Your Majesty. Without any other revenue-generating measure to replace that tax, it would leave us completely reliant on our natural resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Elena Werner: ""In terms of our provinces' individual contributions... t..."*)

### Węzeł `[214]`
Mówca: **Elena Werner**
> ""We already have a budget surplus, Your Majesty. I see no need to raise taxes unless it's absolutely necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Elena Werner: ""In terms of our provinces' individual contributions... t..."*)

### Węzeł `[215]`
Mówca: **Elena Werner**
> ""Not completely. But yes, if our international trade were to be disrupted, we would have to abandon this system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Elena Werner: ""In terms of our provinces' individual contributions... t..."*)

### Węzeł `[216]`
Mówca: **Elena Werner**
> ""At the moment, we have little risk of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Elena Werner: ""In terms of our provinces' individual contributions... t..."*)

### Węzeł `[217]`
Mówca: **Narrator**
> "Hugo looked at me strangely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Hugo Toras: ""It is our responsibility to make wise choices with the m..."*)

### Węzeł `[218]`
Mówca: **Hugo Toras**
> ""It is our responsibility to make wise choices with the money we have. Dwelling on how we came to have it accomplishes nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Elena Werner: ""In terms of our provinces' individual contributions... t..."*)

### Węzeł `[219]`
Mówca: **Hugo Toras**
> ""Think of your own house, Your Majesty. Would the Rizian wine industry be where it is without our backing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Elena Werner: ""In terms of our provinces' individual contributions... t..."*)

### Węzeł `[220]`
Mówca: **Elena Werner**
> ""Very well, Your Majesty. For the record, I'm not convinced either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Elena Werner: ""In terms of our provinces' individual contributions... t..."*)

### Węzeł `[221]`
Mówca: **Elena Werner**
> ""In terms of our provinces' individual contributions... they pay less than three percent directly to the Crown, which mostly goes towards administrative costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Elena Werner: ""The arrangement dates back to agreements made after the ..."*)

### Węzeł `[222]`
Mówca: **Elena Werner**
> ""Brenas is still suffering the effects of the loss of Iza and Zille. However, it's made advances in shipping and agriculture, alongside its gold mines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Elena Werner: ""The manufacturing concerns in Cardesse-Montaklar are doi..."*)

### Węzeł `[223]`
Mówca: **Hugo Toras**
> ""That is a slippery slope, Mr. Esquibel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Laurento Esquibel: ""Are you familiar with Rizia's two-tier employment system..."*)

### Węzeł `[224]`
Mówca: **Laurento Esquibel**
> ""After the Wehlen Civil War, we began granting 'labor hand' visas to Wehzek migrants and a smaller number of Derdians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Elena Werner: ""Labor hands may accept employment by Rizian industries, ..."*)

### Węzeł `[225]`
Mówca: **Laurento Esquibel**
> ""Are you familiar with Rizia's two-tier employment system, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player_Romus: ""Please explain it to me.""*)
  - -> `[227]` (*Player_Romus: ""Yes, I believe I am.""*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please explain it to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Laurento Esquibel: ""After the Wehlen Civil War, we began granting 'labor han..."*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I believe I am.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Laurento Esquibel: ""Granting 'labor hand' visas to Wehzeks and Derdians did ..."*)

### Węzeł `[228]`
Mówca: **Elena Werner**
> ""Labor hands may accept employment by Rizian industries, but they don't have the right to social security or other benefits. And there is a cap on how much they are allowed to earn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Elena Werner: ""They now make up most of our blue-collar workforce, with..."*)

### Węzeł `[229]`
Mówca: **Elena Werner**
> ""They now make up most of our blue-collar workforce, with higher-paid jobs held by native Rizians as well as smaller numbers of Lespians, Valgslandians and Rumburgians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Laurento Esquibel: ""The program did wonders for the economy when King Valero..."*)

### Węzeł `[230]`
Mówca: **Laurento Esquibel**
> ""The program did wonders for the economy when King Valero initiated it. But as a result, we now have millions of workers in this country who are being treated like second-class citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Player_Romus: ""They should have the same working rights as their Rizian..."*)
  - -> `[234]` (*Player_Romus: ""If the system functions, I see no need to change it.""*)
  - -> `[235]` (*Player_Romus: ""Those visas were granted to temporary residents. They we..."*)
  - -> `[236]` (*Player_Romus: ""I see where you're going with this, but granting them fu..."*)

### Węzeł `[231]`
Mówca: **Laurento Esquibel**
> ""Granting 'labor hand' visas to Wehzeks and Derdians did wonders for our economy in the 1930s and 40s.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Laurento Esquibel: ""But as a result, Rizia now has a millions-strong workfor..."*)

### Węzeł `[232]`
Mówca: **Laurento Esquibel**
> ""But as a result, Rizia now has a millions-strong workforce that is essentially treated like second-class citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Player_Romus: ""They should have the same working rights as their Rizian..."*)
  - -> `[234]` (*Player_Romus: ""If the system functions, I see no need to change it.""*)
  - -> `[235]` (*Player_Romus: ""Those visas were granted to temporary residents. They we..."*)
  - -> `[236]` (*Player_Romus: ""I see where you're going with this, but granting them fu..."*)

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They should have the same working rights as their Rizian counterparts. Especially if they're paying taxes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Laurento Esquibel), `[232]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Hugo Toras: ""Rizia offered Wehzeks asylum where other countries did n..."*)

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the system functions, I see no need to change it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Laurento Esquibel), `[232]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Laurento Esquibel: ""I wouldn't say it functions. Barring these people from u..."*)

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those visas were granted to temporary residents. They were supposed to go home at some point.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Laurento Esquibel), `[232]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Elena Werner: ""That was the initial aim. But Rizia's current-day econom..."*)

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see where you're going with this, but granting them full employment rights would lead to a flood of uncontrolled migration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Laurento Esquibel), `[232]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Laurento Esquibel: ""I'm not sure about that. The situation in Wehlen has sta..."*)

### Węzeł `[237]`
Mówca: **Hugo Toras**
> ""Rizia offered Wehzeks asylum where other countries did not. There must be some limit to our generosity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)

### Węzeł `[238]`
Mówca: **Laurento Esquibel**
> ""I wouldn't say it functions. Barring these people from upward mobility will have consequences in the long term. The worker shortage Elena mentioned is just one of those.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Hugo Toras: ""Rizia offered Wehzeks asylum where other countries did n..."*)

### Węzeł `[239]`
Mówca: **Elena Werner**
> ""That was the initial aim. But Rizia's current-day economy now relies on these workers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Laurento Esquibel: ""All the more reason why they deserve an upgrade in status.""*)

### Węzeł `[240]`
Mówca: **Laurento Esquibel**
> ""All the more reason why they deserve an upgrade in status.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Hugo Toras: ""Rizia offered Wehzeks asylum where other countries did n..."*)

### Węzeł `[241]`
Mówca: **Laurento Esquibel**
> ""I'm not sure about that. The situation in Wehlen has stabilized since the Civil War.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Hugo Toras: ""Rizia offered Wehzeks asylum where other countries did n..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedSuOmina == true)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Hugo Toras: ""There was a time when you supported that stance, Your Ma..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedSuOmina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player_Romus: ""I'm just being pragmatic. Expanding foreign workers' rig..."*)
  - -> `[254]` (*Player_Romus: ""Taking advantage of migrants' dire financial situation b..."*)
  - -> `[256]` (*Player_Romus: ""Perhaps. But I do worry that having a growing army of di..."*)

### Węzeł `[245]`
Mówca: **Hugo Toras**
> ""There was a time when you supported that stance, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player_Romus: ""I'm just being pragmatic. Expanding foreign workers' rig..."*)
  - -> `[254]` (*Player_Romus: ""Taking advantage of migrants' dire financial situation b..."*)
  - -> `[256]` (*Player_Romus: ""Perhaps. But I do worry that having a growing army of di..."*)
  - -> `[252]` (*Player_Romus: ""I was a different person back in those days. I no longer..."*)

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm just being pragmatic. Expanding foreign workers' rights does seem like a convenient solution to the shortage Elena mentioned.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[245]` (Hugo Toras), `[237]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Lucita Azaro: ""From a security standpoint, allowing migrants to earn mo..."*)

### Węzeł `[247]`
Mówca: **Hugo Toras**
> ""Rizia offered Wehzeks asylum where other countries did not. There must be some limit to our generosity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedSuOmina == true)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Hugo Toras: ""I recall you once supported that stance as well, Your Ma..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedSuOmina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Player_Romus: ""Perhaps. But I do worry that having a growing army of di..."*)
  - -> `[255]` (*Player_Romus: ""From a purely pragmatic point of view, expanding foreign..."*)
  - -> `[257]` (*Player_Romus: ""Exactly. I'm all for diversity, but we Rizians cannot al..."*)

### Węzeł `[251]`
Mówca: **Hugo Toras**
> ""I recall you once supported that stance as well, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Player_Romus: ""I was a different person back in those days. I no longer..."*)
  - -> `[253]` (*Player_Romus: ""I did and I still do. I'm all for diversity, but we Rizi..."*)
  - -> `[255]` (*Player_Romus: ""From a purely pragmatic point of view, expanding foreign..."*)

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was a different person back in those days. I no longer support Su Omina or the values it stands for.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[245]` (Hugo Toras), `[251]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Lucita Azaro: ""I will add that from a security standpoint, allowing mig..."*)

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did and I still do. I'm all for diversity, but we Rizians cannot allow ourselves to become outnumbered.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Lucita Azaro: ""I will point out that from a security standpoint, allowi..."*)

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Taking advantage of migrants' dire financial situation by forcing them to work for low wages is hardly 'generosity.'""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[245]` (Hugo Toras), `[237]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Lucita Azaro: ""I will add that from a security standpoint, allowing mig..."*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""From a purely pragmatic point of view, expanding foreign workers' rights does seem like a convenient solution to the shortage Elena mentioned.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[251]` (Hugo Toras), `[247]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Lucita Azaro: ""And from a security standpoint, allowing migrants to ear..."*)

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps. But I do worry that having a growing army of disenfranchised laborers will lead to unrest down the line.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[245]` (Hugo Toras), `[237]` (Hugo Toras), `[247]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Lucita Azaro: ""Very possible, Your Majesty. And allowing migrants to ea..."*)

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Exactly. I'm all for diversity, but we Rizians cannot allow ourselves to become outnumbered.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[247]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Lucita Azaro: ""I will point out that from a security standpoint, allowi..."*)

### Węzeł `[258]`
Mówca: **Lucita Azaro**
> ""From a security standpoint, allowing migrants to earn more money would curb the kind of black-market activities that have been taking place in cities like Iza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Hugo Toras: ""Do you not fear the dilution of Rizian culture and value..."*)

### Węzeł `[259]`
Mówca: **Lucita Azaro**
> ""Very possible, Your Majesty. And allowing migrants to earn more money would curb the kind of black-market activities that have been taking place in cities like Iza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Hugo Toras: ""Do you not fear the dilution of Rizian culture and value..."*)

### Węzeł `[260]`
Mówca: **Lucita Azaro**
> ""And from a security standpoint, allowing migrants to earn more money would curb the kind of black-market activities that have been taking place in cities like Iza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Hugo Toras: ""Do you not fear the dilution of Rizian culture and value..."*)

### Węzeł `[261]`
Mówca: **Hugo Toras**
> ""Do you not fear the dilution of Rizian culture and values, Duchess Azaro? Or the infiltration of Dastnurists and Golcondists into our Wruhecist society?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Narrator: "She shrugged."*)

### Węzeł `[262]`
Mówca: **Narrator**
> "She shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Lucita Azaro: ""Societies change, Your Grace. And I don't recall these c..."*)

### Węzeł `[263]`
Mówca: **Lucita Azaro**
> ""Societies change, Your Grace. And I don't recall these concerns being raised about the Rumburgians who moved here after our alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Player_Romus: ""Well put, Duchess. I can already tell you're going to be..."*)
  - -> `[267]` (*Player_Romus: ""That's completely different. The Rumburgians are our blo..."*)
  - -> `[268]` (*Player_Romus: ""To tell the truth, I'm not thrilled about any of those g..."*)
  - -> `[269]` (*Player_Romus: ""Rizia is a multicultural nation now, Hugo. Whether we li..."*)

### Węzeł `[264]`
Mówca: **Lucita Azaro**
> ""I will add that from a security standpoint, allowing migrants to earn more money would curb the kind of black-market activities that have been taking place in cities like Iza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Hugo Toras: ""Do you not fear the dilution of Rizian culture and value..."*)

### Węzeł `[265]`
Mówca: **Lucita Azaro**
> ""I will point out that from a security standpoint, allowing migrants to earn more money would curb the kind of black-market activities that have been taking place in cities like Iza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Hugo Toras: ""Do you not fear the dilution of Rizian culture and value..."*)

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well put, Duchess. I can already tell you're going to be a brilliant addition to this council.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Lucita Azaro: ""Thank you, Your Majesty.""*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's completely different. The Rumburgians are our blood relations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Hugo Toras: ""There are also far fewer of them.""*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To tell the truth, I'm not thrilled about any of those groups.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Hugo Toras: ""Nor am I. But the Rumburgians are a small minority compa..."*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia is a multicultural nation now, Hugo. Whether we like it or not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Hugo Toras: ""We cannot let the events of the last two decades destroy..."*)

### Węzeł `[270]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "I saw a smile play across her lips. Hugo stayed silent."*)

### Węzeł `[271]`
Mówca: **Narrator**
> "I saw a smile play across her lips. Hugo stayed silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "Elena looked uneasily at the three of us. She tapped a pe..."*)

### Węzeł `[272]`
Mówca: **Hugo Toras**
> ""There are also far fewer of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Hugo Toras: ""The people of this country will accept diversity up to a..."*)

### Węzeł `[273]`
Mówca: **Hugo Toras**
> ""Nor am I. But the Rumburgians are a small minority compared to the Wehzeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Hugo Toras: ""The people of this country will accept diversity up to a..."*)

### Węzeł `[274]`
Mówca: **Hugo Toras**
> ""We cannot let the events of the last two decades destroy what it has taken over a thousand years to build.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Hugo Toras: ""The people of this country will accept diversity up to a..."*)

### Węzeł `[275]`
Mówca: **Narrator**
> "Hugo fixed Lucita with a defiant stare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "Elena looked uneasily at the three of us. She tapped a pe..."*)

### Węzeł `[276]`
Mówca: **Elena Werner**
> ""We seem to have veered off track. Can we get back to your questions about the economy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes = true"*)

### Węzeł `[277]`
Mówca: **Narrator**
> "Elena looked uneasily at the three of us. She tapped a pencil on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Elena Werner: ""We seem to have veered off track. Can we get back to you..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "Jump to: [Economy/Treasury Hub]"*)

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right, Hugo. I'll take Duchess Azaro's suggestion seriously.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Lucita Azaro: ""I'm honored, Your Majesty.""*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Other countries might compete to have the biggest guns. Not Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Lucita Azaro: ""It's not about big guns, Your Majesty. It's about being ..."*)

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And there's the fact that we're sandwiched between the highly contentious regions of Zille and Pales.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Lucita Azaro: ""Precisely, Your Majesty. We've got to be prepared for th..."*)

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we cultivate our alliances well, we won't need that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Lucita Azaro: ""Allies can turn on us, Your Majesty. A loyal, well-funde..."*)

### Węzeł `[283]`
Mówca: **Lucita Azaro**
> ""I'm honored, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Pacifist -= 1"*)

### Węzeł `[284]`
Mówca: **Lucita Azaro**
> ""It's not about big guns, Your Majesty. It's about being prepared for any eventuality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Pacifist += 1"*)

### Węzeł `[285]`
Mówca: **Lucita Azaro**
> ""Precisely, Your Majesty. We've got to be prepared for the worst-case scenario, even if it doesn't happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Elena Werner: ""Your enthusiasm is heartening, Duchess Azaro. I'm sure y..."*)

### Węzeł `[286]`
Mówca: **Lucita Azaro**
> ""Allies can turn on us, Your Majesty. A loyal, well-funded military is worth its weight in gold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Elena Werner: ""Your enthusiasm is heartening, Duchess Azaro. I'm sure y..."*)

### Węzeł `[287]`
Mówca: **Elena Werner**
> ""Your enthusiasm is heartening, Duchess Azaro. I'm sure you'll have much more advice to share during your own briefing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Elena Werner: ""Any further questions, Your Majesty?""*)

### Węzeł `[288]`
Mówca: **Elena Werner**
> ""Any further questions, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Budget = true"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Pacifist -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Elena Werner: ""Your enthusiasm is heartening, Duchess Azaro. I'm sure y..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Pacifist += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Elena Werner: ""Your enthusiasm is heartening, Duchess Azaro. I'm sure y..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "Jump to: [Economy/Treasury Hub]"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Econ_Budget = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Budget"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "Jump to: [Economy/Treasury Hub]"*)

### Węzeł `[293]`
Mówca: **Elena Werner**
> ""Perfect, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[294]`
Mówca: **Narrator**
> "Laurento stroked his mustache."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Laurento Esquibel: ""It was established shortly before you joined the Royal C..."*)

### Węzeł `[295]`
Mówca: **Laurento Esquibel**
> ""It was established shortly before you joined the Royal Council, was it not, Elena? I heard the negotiations between Rizia, Valgsland, Lespia and Morella took over a year.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "Gold Qs"*)

### Węzeł `[296]`
Mówca: **Elena Werner**
> ""We would just need to commission a survey to find them. Keeping in mind that any mining site near noble-owned estates might lead to a devaluation of those properties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Narrator: "I saw Hugo wince at that remark."*)

### Węzeł `[297]`
Mówca: **Elena Werner**
> ""But as per the terms of our agreement, Zille and all of the resources therein will return to Rizian ownership in 1952.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Elena Werner: ""And at the time of our last survey, there was much more ..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Tyrant += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Narrator: "Laurento looked down at the table."*)

### Węzeł `[299]`
Mówca: **Narrator**
> "Laurento looked down at the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Laurento Esquibel: ""Forgive me, Your Majesty. I will let the treasurer speak.""*)

### Węzeł `[300]`
Mówca: **Laurento Esquibel**
> ""Forgive me, Your Majesty. I will let the treasurer speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Elena Werner: ""Well... we're still in the extremely early stages.""*)

### Węzeł `[301]`
Mówca: **Elena Werner**
> ""I'd like nothing more, Your Majesty. But protocol must be followed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Elena Werner: ""Our researchers have been investigating the field's size..."*)

### Węzeł `[302]`
Mówca: **Laurento Esquibel**
> ""Of course, we are liaising extremely closely with Pales to avoid misunderstandings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Lucita Azaro: ""As we should. Nobody wants a repeat of the last conflict.""*)

### Węzeł `[303]`
Mówca: **Laurento Esquibel**
> ""I agree that maintaining or even improving our relations with Pales should be our number-one goal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Elena Werner: ""With that said, if there's even a chance we have a claim..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == false"*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == false)"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player_Romus: ""Perhaps we should let it go, in the interest of keeping ..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Player_Romus: ""Pales barely counts as a country. Of course we have a cl..."*)

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales barely counts as a country. Of course we have a claim to the field.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[68]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Narrator: "Laurento looked uneasy."*)

### Węzeł `[308]`
Mówca: **Narrator**
> "Laurento looked uneasy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Laurento Esquibel: ""Whatever our feelings about Palesian sovereignty, we are..."*)

### Węzeł `[309]`
Mówca: **Laurento Esquibel**
> ""Whatever our feelings about Palesian sovereignty, we are bound to respect protocol.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Elena Werner: ""We have teamed up with Palesian researchers to investiga..."*)

### Węzeł `[310]`
Mówca: **Elena Werner**
> ""We have teamed up with Palesian researchers to investigate the field's size and borders. Once those are known, it will be easier to determine ownership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Laurento Esquibel: ""Of course, we are liaising extremely closely with Pales ..."*)

### Węzeł `[311]`
Mówca: **Elena Werner**
> ""With that said, if there's even a chance we have a claim to that gas, we really ought to take it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Elena Werner: ""Our researchers have been investigating the field's size..."*)

### Węzeł `[312]`
Mówca: **Lucita Azaro**
> ""As we should. Nobody wants a repeat of the last conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Player_Romus: ""Really, Duchess Azaro? Your family isn't itching for a r..."*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[319]` (*Player_Romus: ""If the Grand Duchy does not provoke us, we will not prov..."*)

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Really, Duchess Azaro? Your family isn't itching for a rematch?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[312]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "Lucita laughed uncomfortably."*)

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If it *does* come down to that -- God forbid -- Rizia will win.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Kontekst wejściowy (poprzednik):** `[312]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "Lucita winced."*)

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed not. I will not practice the same mindless militarism as my father and Taddeus Azaro.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[312]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "Lucita's eyes narrowed."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true)"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Player_Romus: ""If it *does* come down to that -- God forbid -- Rizia wi..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Player_Romus: ""Indeed not. I will not practice the same mindless milita..."*)

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the Grand Duchy does not provoke us, we will not provoke them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[312]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Narrator: "Lucita nodded."*)

### Węzeł `[320]`
Mówca: **Narrator**
> "Lucita laughed uncomfortably."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Lucita Azaro: ""Just because the Azaros are demanding the reclamation of..."*)

### Węzeł `[321]`
Mówca: **Lucita Azaro**
> ""Just because the Azaros are demanding the reclamation of Pales doesn't mean it's a good idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Lucita Azaro: ""Of course, if Pales shows hostility towards us, we will ..."*)

### Węzeł `[322]`
Mówca: **Lucita Azaro**
> ""Of course, if Pales shows hostility towards us, we will react in kind. But Rizia should not be the first to resort to aggression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[323]`
Mówca: **Narrator**
> "Lucita winced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Lucita Azaro: ""Not with our military in its current state.""*)

### Węzeł `[324]`
Mówca: **Lucita Azaro**
> ""Not with our military in its current state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Lucita Azaro: ""As much as my family is clamoring for a repeat of the Pa..."*)

### Węzeł `[325]`
Mówca: **Lucita Azaro**
> ""As much as my family is clamoring for a repeat of the Pales campaign, I think it's best to ignore them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[326]`
Mówca: **Narrator**
> "Lucita's eyes narrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Lucita Azaro: ""The attack on Pales in the '20s was not 'mindless', Your..."*)

### Węzeł `[327]`
Mówca: **Lucita Azaro**
> ""The attack on Pales in the '20s was not 'mindless', Your Majesty. It was driven by demand from the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Lucita Azaro: ""But some people don't know what's best for them. Especia..."*)

### Węzeł `[328]`
Mówca: **Lucita Azaro**
> ""But some people don't know what's best for them. Especially my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[329]`
Mówca: **Narrator**
> "Lucita nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Lucita Azaro: ""As much as my family is clamoring for a repeat of the Pa..."*)

### Węzeł `[330]`
Mówca: **Lucita Azaro**
> ""As much as my family is clamoring for a repeat of the Pales campaign, I think it's best to ignore them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Lucita Azaro: ""Of course, if Pales shows hostility towards us, we will ..."*)

### Węzeł `[331]`
Mówca: **Laurento Esquibel**
> ""You'll recall her famous quote...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[332]`
Mówca: **Laurento Esquibel**
> ""'True prosperity is not defined by the amount of gold in our coffers, but by the health and happiness of each soul within our borders.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player_Romus: ""It's true that a happy and well-fed populace is one that..."*)
  - -> `[123]` (*Player_Romus: ""On the other hand, there can be no welfare without secur..."*)
  - -> `[124]` (*Player_Romus: ""Indeed, Mr. Esquibel. If we focus on citizen welfare, we..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "Hugo nodded."*)

### Węzeł `[334]`
Mówca: **Hugo Toras**
> ""The people of this country will accept diversity up to a certain point, Your Majesty. But if they begin to feel their national identity is under threat, there will be consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true"*)

### Węzeł `[335]`
Mówca: **Narrator**
> "She and Hugo exchanged glances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Hugo Toras: ""And unfortunately, we cannot talk about Rizian Royal Gol..."*)

### Węzeł `[336]`
Mówca: **Hugo Toras**
> ""And unfortunately, we cannot talk about Rizian Royal Gold without talking about its CEO.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Player_Romus: ""Why do we have to talk about him? It's Rizian *Royal* Go..."*)
  - -> `[338]` (*Player_Romus: ""Why 'unfortunately', Your Grace?""*)
  - -> `[339]` (*Player_Romus: ""We had better get that discussion over with.""*)
  - -> `[340]` (*Player_Romus: ""Do not speak ill of our country's most vaunted businessm..."*)

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why do we have to talk about him? It's Rizian *Royal* Gold, after all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[336]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Elena Werner: ""That's the problem. It isn't ours. Since 1935, it's been..."*)

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why 'unfortunately', Your Grace?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[336]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Elena Werner: ""Your uncle never could countenance the presence of Russe..."*)

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We had better get that discussion over with.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[336]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Elena Werner: ""For better or worse, our country's gold stores rely on R..."*)

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not speak ill of our country's most vaunted businessman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[336]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Hugo Toras: ""My apologies, Your Majesty. Of course I do not mean to c..."*)

### Węzeł `[341]`
Mówca: **Hugo Toras**
> ""My apologies, Your Majesty. Of course I do not mean to call Russello Montoro's acumen into question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Elena Werner: ""Mr. Montoro -- excuse me, Rusty -- currently owns 70 per..."*)

### Węzeł `[342]`
Mówca: **Elena Werner**
> ""That's the problem. It isn't ours. Since 1935, it's been under the control of Russello Montoro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Elena Werner: ""Mr. Montoro -- excuse me, Rusty -- currently owns 70 per..."*)

### Węzeł `[343]`
Mówca: **Elena Werner**
> ""Your uncle never could countenance the presence of Russello Montoro. But we can't mine gold in this country without him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Elena Werner: ""Mr. Montoro -- excuse me, Rusty -- currently owns 70 per..."*)

### Węzeł `[344]`
Mówca: **Elena Werner**
> ""For better or worse, our country's gold stores rely on Russello Montoro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Elena Werner: ""Mr. Montoro -- excuse me, Rusty -- currently owns 70 per..."*)

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still cannot believe he was allowed to gain such a large majority.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[347]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Hugo Toras: ""Nor can I, Your Majesty.""*)

### Węzeł `[346]`
Mówca: **Elena Werner**
> ""After a *very* lengthy back-and-forth, it was agreed that the Kingdom's share in RRG be decreased from 45 to 30 percent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Player_Romus: ""I will not tolerate this. I want Rizia's original stake ..."*)
  - -> `[356]` (*Player_Romus: ""Rizia should not own 30 percent of RRG, or even 45 perce..."*)
  - -> `[357]` (*Player_Romus: ""I don't see any problem with that. We shouldn't have so ..."*)

### Węzeł `[347]`
Mówca: **Elena Werner**
> ""Mr. Montoro -- excuse me, Rusty -- currently owns 70 percent of Rizian Royal Gold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Player_Romus: ""I still cannot believe he was allowed to gain such a lar..."*)
  - -> `[348]` (*Player_Romus: ""That's fine by me. We all know that private enterprise c..."*)
  - -> `[349]` (*Player_Romus: ""As much as I respect Rusty, I believe we royals should b..."*)

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's fine by me. We all know that private enterprise can achieve what the government cannot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[347]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Hugo Toras: ""In some cases, perhaps. But after what this man did...""*)

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As much as I respect Rusty, I believe we royals should be in charge of our own gold mines.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[347]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Hugo Toras: ""That will be difficult, Your Majesty.""*)

### Węzeł `[350]`
Mówca: **Hugo Toras**
> ""Nor can I, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Narrator: "He looked at Elena."*)

### Węzeł `[351]`
Mówca: **Narrator**
> "He looked at Elena."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Elena Werner: ""Rusty's first move after taking over the company was to ..."*)

### Węzeł `[352]`
Mówca: **Elena Werner**
> ""Rusty's first move after taking over the company was to sue your father's government for loss of revenue connected to the Zille handover.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Elena Werner: ""After a *very* lengthy back-and-forth, it was agreed tha..."*)

### Węzeł `[353]`
Mówca: **Hugo Toras**
> ""In some cases, perhaps. But after what this man did...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Narrator: "He looked at Elena."*)

### Węzeł `[354]`
Mówca: **Hugo Toras**
> ""That will be difficult, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Narrator: "He looked at Elena."*)

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will not tolerate this. I want Rizia's original stake back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[346]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Elena Werner: ""Curry enough favor with Rusty, and it should be possible..."*)

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia should not own 30 percent of RRG, or even 45 percent. The entire company should be nationalized.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[346]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Elena Werner: ""It's not that simple.""*)

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't see any problem with that. We shouldn't have so much of our money tied up in an outdated resource.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[346]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Laurento Esquibel: ""I beg your pardon, Your Majesty, but healthy gold stocks..."*)

### Węzeł `[358]`
Mówca: **Laurento Esquibel**
> ""I beg your pardon, Your Majesty, but healthy gold stocks are crucial to Rizia's reputation on the international stage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Elena Werner: ""Rumburg is buying our gold for technological uses. And s..."*)

### Węzeł `[359]`
Mówca: **Elena Werner**
> ""Rumburg is buying our gold for technological uses. And some of our neighbors have shown interest in using it to shore up their unstable currencies, as we did here after the '26 uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Narrator: "She adjusted her glasses before continuing."*)

### Węzeł `[360]`
Mówca: **Elena Werner**
> ""It's not that simple.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Laurento Esquibel: ""The patent for RRG's proprietary mining technology was f..."*)

### Węzeł `[361]`
Mówca: **Elena Werner**
> ""Curry enough favor with Rusty, and it should be possible. But any more than 45 percent will be difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Laurento Esquibel: ""The patent for RRG's proprietary mining technology was f..."*)

### Węzeł `[362]`
Mówca: **Laurento Esquibel**
> ""The patent for RRG's proprietary mining technology was filed in Ventrie City, Arcasia. And most of its financial assets are kept in Kyrute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Elena Werner: ""In other words, attempting to nationalize the company wi..."*)

### Węzeł `[363]`
Mówca: **Elena Werner**
> ""In other words, attempting to nationalize the company without Mr. Montoro's express approval would strip it of its value.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Narrator: "She adjusted her glasses before continuing."*)

### Węzeł `[364]`
Mówca: **Narrator**
> "She adjusted her glasses before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Elena Werner: ""While RRG controls mining within Rizia, the royal govern..."*)

### Węzeł `[365]`
Mówca: **Elena Werner**
> ""While RRG controls mining within Rizia, the royal government is a direct stakeholder in the Meftiem International Trade Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap == true"*)

### Węzeł `[366]`
Mówca: **Elena Werner**
> ""And at the time of our last survey, there was much more than 30 years' worth of gold in the ground there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille = true"*)

### Węzeł `[367]`
Mówca: **Narrator**
> "I saw Hugo wince at that remark."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia = true"*)

### Węzeł `[368]`
Mówca: **Elena Werner**
> ""RRG gets a percentage of the MITZ profits for the use of its technology, but we can make decisions without Mr. Montoro's input.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs = true"*)

### Węzeł `[369]`
Mówca: **Elena Werner**
> ""Yes, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Econ_Gold = true"*)

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I get the picture. Let's move on to other topics.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[295]` (Laurento Esquibel), `[367]` (Narrator), `[366]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Elena Werner: ""Yes, of course.""*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true"*)
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == ..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Hugo Toras: ""Which, by the way, is why I wholeheartedly support your ..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Hugo Toras: ""Which, by the way, is why I wholeheartedly support the R..."*)

### Węzeł `[374]`
Mówca: **Hugo Toras**
> ""Which, by the way, is why I wholeheartedly support your decision to impose a tax on non-Wruhecists so early into your reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "Hugo fixed Lucita with a defiant stare."*)

### Węzeł `[375]`
Mówca: **Hugo Toras**
> ""Which, by the way, is why I wholeheartedly support the Rizian National Coalition's suggestion to impose a tax on non-Wruhecists. Filling our coffers and rewarding the native Rizian faithful in one go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "Hugo fixed Lucita with a defiant stare."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_TreasuryFinances == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_TreasuryFinances == true"*)
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Focus_TreasuryFinances == true)"*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_TreasuryFinances == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Focus_TreasuryFinances"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Elena Werner: ""Thanks to your own wise financial decisions over the pas..."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Focus_TreasuryFinances == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Focus_TreasuryFinances"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Elena Werner: ""It's not as high as it used to be. But I think we should..."*)

### Węzeł `[379]`
Mówca: **Elena Werner**
> ""It's not as high as it used to be. But I think we should put it to work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Elena Werner: ""All glory to the late Valero, but he had a certain prude..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_ArmedForces == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_ArmedForces == true"*)
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Focus_ArmedForces == true)"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_ArmedForces == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Focus_ArmedForces"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Lucita Azaro: ""I'm sure His Majesty will agree with me.""*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Focus_ArmedForces == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Focus_ArmedForces"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Elena Werner: ""With all due respect, Duchess Azaro, I'm not sure the mi..."*)

### Węzeł `[383]`
Mówca: **Lucita Azaro**
> ""I'm sure His Majesty will agree with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Player_Romus: ""I share your goals, Duchess. By the end of my reign, the..."*)
  - -> `[387]` (*Player_Romus: ""Enhancing our army stockpiles will be good for Rizia's f..."*)
  - -> `[390]` (*Player_Romus: ""I chose to gave our military a much-needed upgrade befor..."*)

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I share your goals, Duchess. By the end of my reign, the Rizian Armed Forces shall be known and feared throughout the continent.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[383]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Narrator: "Lucita smiled."*)

### Węzeł `[385]`
Mówca: **Narrator**
> "Lucita smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Lucita Azaro: ""I've planned a separate meeting to discuss national secu..."*)

### Węzeł `[386]`
Mówca: **Lucita Azaro**
> ""I've planned a separate meeting to discuss national security. We'll go over it all then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Laurento Esquibel: ""Not that I disagree with King Romus, but I personally be..."*)

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enhancing our army stockpiles will be good for Rizia's finances, Ms. Werner. If there's one thing there's always a market for, it's weapons.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[383]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Elena Werner: ""Hmm. You do have a point there.""*)

### Węzeł `[388]`
Mówca: **Elena Werner**
> ""Hmm. You do have a point there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Lucita Azaro: ""As long as we've got enough left over to fight with if n..."*)

### Węzeł `[389]`
Mówca: **Lucita Azaro**
> ""As long as we've got enough left over to fight with if need be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Laurento Esquibel: ""Not that I disagree with King Romus, but I personally be..."*)

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I chose to gave our military a much-needed upgrade before my coronation, yes. That doesn't mean it will be a major focus during my reign.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[383]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Lucita Azaro: ""Ah. Forgive me if I misunderstood.""*)

### Węzeł `[391]`
Mówca: **Lucita Azaro**
> ""Ah. Forgive me if I misunderstood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Laurento Esquibel: ""Not that I disagree with King Romus, but I personally be..."*)

### Węzeł `[392]`
Mówca: **Laurento Esquibel**
> ""Not that I disagree with King Romus, but I personally believe that more financial attention should be paid to our citizens' welfare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Laurento Esquibel: ""Doing so would vastly improve our global image. You'll r..."*)

### Węzeł `[393]`
Mówca: **Laurento Esquibel**
> ""Doing so would vastly improve our global image. You'll remember Queen Lyza's famous quote...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_TreasuryFinances == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_TreasuryFinances == true"*)
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Focus_TreasuryFinances == true)"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_TreasuryFinances == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Focus_TreasuryFinances"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Narrator: "She smiled fondly."*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Focus_TreasuryFinances == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Focus_TreasuryFinances"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Elena Werner: ""Well, Your Majesty, gold is still the backbone of the Ri..."*)

### Węzeł `[397]`
Mówca: **Narrator**
> "She smiled fondly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Elena Werner: ""I believe you know the answer, Your Majesty.""*)

### Węzeł `[398]`
Mówca: **Elena Werner**
> ""I believe you know the answer, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Elena Werner: ""Your past efforts have certainly helped bolster our rese..."*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_EnergyIndustry == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_EnergyIndustry == true"*)
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Focus_EnergyIndustry == true)"*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_EnergyIndustry == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Focus_EnergyIndustry"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Elena Werner: ""Very gladly, Your Majesty. I know this is your area of e..."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Focus_EnergyIndustry == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Focus_EnergyIndustry"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Elena Werner: ""Very gladly, Your Majesty. This is a new area for us com..."*)

### Węzeł `[402]`
Mówca: **Elena Werner**
> ""Your past efforts have certainly helped bolster our reserves. However, the amount of gold in the ground is finite, and extraction has plateaued.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Elena Werner: ""We have a number of active mines within the country, ope..."*)

### Węzeł `[403]`
Mówca: **Elena Werner**
> ""Very gladly, Your Majesty. I know this is your area of expertise, but there have been a few new developments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap == true"*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 18`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 18"*)
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget > 18)"*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 18`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 18`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Elena Werner: ""Said surplus is... unusually large, compared to your fat..."*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget > 18)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 18) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_TreasuryFinances == true"*)

### Węzeł `[407]`
Mówca: **Elena Werner**
> ""Said surplus is... unusually large, compared to your father's regime. It's almost as if you've been able to conjure up money out of nowhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Elena Werner: ""All glory to the late Valero, but he had a certain prude..."*)

### Węzeł `[408]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do, Ms. Werner. As a matter of fact, there's no need for today's briefing. Why don't you all take the rest of the day off?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Narrator: "My councilors glanced at each other in surprise."*)

### Węzeł `[409]`
Mówca: **Narrator**
> "My councilors glanced at each other in surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Elena Werner: ""Are you sure, Your Majesty?""*)

### Węzeł `[410]`
Mówca: **Elena Werner**
> ""Are you sure, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I find I think best when I'm alone. Get me in my study with a fountain pen and a stack of decrees, and I'll handle the rest.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[415]` (Elena Werner), `[410]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Narrator: "She nodded slowly."*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Elena Werner: ""Perhaps you're all caught up on our economic situation, ..."*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Player_Romus: ""I find I think best when I'm alone. Get me in my study w..."*)
  - -> `[417]` (*Player_Romus: ""The Lord will guide me to make the right decisions, Elen..."*)
  - -> `[419]` (*Player_Romus: ""You clearly worked hard to put today's briefing together..."*)
  - -> `[424]` (*Player_Romus: ""Get some fresh air. Cut loose a little. It's not like yo..."*)

### Węzeł `[415]`
Mówca: **Elena Werner**
> ""Perhaps you're all caught up on our economic situation, but Her Highness still has much to learn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Player_Romus: ""I find I think best when I'm alone. Get me in my study w..."*)
  - -> `[416]` (*Player_Romus: ""Very well. For Vina's sake, please proceed.""*)
  - -> `[417]` (*Player_Romus: ""The Lord will guide me to make the right decisions, Elen..."*)
  - -> `[418]` (*Player_Romus: ""And learn she will. Vina, this is how a real king cuts t..."*)

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. For Vina's sake, please proceed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[415]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Lord will guide me to make the right decisions, Elena. Your counsel is not necessary.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[415]` (Elena Werner), `[410]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1;"*)

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And learn she will. Vina, this is how a real king cuts through the blather and gets down to business.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[415]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Narrator: "Vina stared at me in confusion. A faint smile of amusemen..."*)

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You clearly worked hard to put today's briefing together. So please proceed.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[410]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Elena Werner: ""Certainly, Your Majesty.""*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "Elena frowned, clearly hurt, before straightening up and ..."*)

### Węzeł `[421]`
Mówca: **Narrator**
> "Elena frowned, clearly hurt, before straightening up and snapping her ledger shut."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "Jump to: [Briefing Skipped]"*)

### Węzeł `[422]`
Mówca: **Narrator**
> "Vina stared at me in confusion. A faint smile of amusement played on Lucita's lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 1"*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "Elena frowned, clearly hurt, before straightening up and ..."*)

### Węzeł `[424]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Get some fresh air. Cut loose a little. It's not like you're getting any younger.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[410]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Narrator: "A faint smile of amusement played on Lucita's lips."*)

### Węzeł `[425]`
Mówca: **Narrator**
> "A faint smile of amusement played on Lucita's lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "Elena frowned, clearly hurt, before straightening up and ..."*)

### Węzeł `[426]`
Mówca: **Narrator**
> "She nodded slowly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Elena Werner: ""I understand. I won't get in your way, then.""*)

### Węzeł `[427]`
Mówca: **Elena Werner**
> ""I understand. I won't get in your way, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "Jump to: [Briefing Skipped]"*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Briefing Skipped]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Lucita Azaro: ""It's not about big guns, Your Majesty. It's about being ..."*)

### Węzeł `[429]`
Mówca: **Elena Werner**
> ""The arrangement dates back to agreements made after the War of Rizian Succession. After four years of civil war, the Crown granted broad fiscal autonomy to the provinces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Hugo Toras: ""It is the very structure of the realm, our code of agree..."*)

### Węzeł `[430]`
Mówca: **Hugo Toras**
> ""It is the very structure of the realm, our code of agreements, one that has endured for centuries. The provinces remain the backbone of the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Player_Romus: ""How are the provinces performing economically?""*)
  - -> `[432]` (*Player_Romus: ""Then let’s go over what each province contributes.""*)
  - -> `[431]` (*Player_Romus: ""I want to know what returns we’re getting through growth.""*)

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want to know what returns we’re getting through growth.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[430]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Elena Werner: ""Growth, trade, and indirect levies offer us some leverag..."*)

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then let’s go over what each province contributes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[430]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Elena Werner: ""Of course. Their profiles vary, but each plays a big role.""*)

### Węzeł `[433]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are the provinces performing economically?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[430]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Elena Werner: ""There are key differences worth your attention. Let me w..."*)

### Węzeł `[434]`
Mówca: **Elena Werner**
> ""There are key differences worth your attention. Let me walk you through them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Elena Werner: ""Your House's province, Valenqiris, leads the realm in GD..."*)

### Węzeł `[435]`
Mówca: **Elena Werner**
> ""Of course. Their profiles vary, but each plays a big role.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Elena Werner: ""Your House's province, Valenqiris, leads the realm in GD..."*)

### Węzeł `[436]`
Mówca: **Elena Werner**
> ""Growth, trade, and indirect levies offer us some leverage. Let me break it down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Elena Werner: ""Your House's province, Valenqiris, leads the realm in GD..."*)

### Węzeł `[437]`
Mówca: **Elena Werner**
> ""All glory to the late Valero, but he had a certain prudence about spending government funds, even when it might have made Rizia richer today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Elena Werner: ""Now, new gold mines are scarce, our richest sources near..."*)
