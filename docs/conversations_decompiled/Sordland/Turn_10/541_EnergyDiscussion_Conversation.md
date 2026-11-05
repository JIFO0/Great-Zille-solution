# Sordland/Turn10/EnergyDiscussion/EnergyDiscussion Conversation

- **ID konwersacji:** `541`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/541_EnergyDiscussion_Conversation.md`
- **Liczba węzłów dialogowych:** 311
- **Liczba wyborów gracza:** 72

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[29]** Ewald Alphonso
- **[48]** Tarquin Soll

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Confrontation_USP_EnergyAct_RevertedTo10`
- `BaseGame.Decision_Turn06_GasomStake_SellOneThird`
- `BaseGame.Decision_Turn06_GasomStake_SellTwoThird`
- `BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks`
- `BaseGame.Gasom_Booming`
- `BaseGame.Gasom_Default`
- `BaseGame.Policy_Economy_EnergyProtectionAct_10Percent`
- `BaseGame.Policy_Economy_EnergyProtectionAct_Removed`
- `BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment`
- `BaseGame.Relations_Ewald_PromiseNotHarsherEPA`
- `BaseGame.RumburgIncident_DeclareWar`
- `BaseGame.Turn03_Admin_EnergyProtectionAct_Removed`
- `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia`
- `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone`
- `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment`
- `BaseGame.Turn05_P_FCAnrica`
- `BaseGame.Turn05_P_Underhall`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Death`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Soll_Hates_Alphonso`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[222] Sordland/Turn10/Personal_FCAnricaDerby** (../Turn_10/222_Personal_FCAnricaDerby.md), Węzeł `[120]`
- Węzeł `[310]` -> **[222] Sordland/Turn10/Personal_FCAnricaDerby** (../Turn_10/222_Personal_FCAnricaDerby.md), Węzeł `[120]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[18]` | **""Colonel Soll is right about this. You did sell your shares to them and abandon So..."** | `[27]` **Tarquin Soll**: ""Don't make me laugh, Ewald. You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Ewald Alphonso**: ""Gentlemen, please. Neither of y..." |
| `[28]` | **""Honestly, I feel the same way. This was not what I had in mind when I removed the..."** | `[27]` **Tarquin Soll**: ""Don't make me laugh, Ewald. You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Ewald Alphonso**: ""Gentlemen, please. Neither of y..." |
| `[29]` | **""Yes, Mr. Alphonso. Why did you decide to move to the Federation of Anrakan Isles?""** | `[27]` **Tarquin Soll**: ""Don't make me laugh, Ewald. You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Tarquin Soll**: ""To live as a king, off of the b..." |
| `[30]` | **""A former Sordish president who chose to retire on an island. Sounds familiar.""** | `[27]` **Tarquin Soll**: ""Don't make me laugh, Ewald. You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Tarquin Soll**: ""I chose to remain in Sordland, ..." |
| `[37]` | **""Let me guess. You live on one of them.""** | `[22]` **Ewald Alphonso**: ""Did you know that the Anrakan F..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Ewald Alphonso**: ""I do, actually."" |
| `[38]` | **""That sounds impressive. Tell me more.""** | `[22]` **Ewald Alphonso**: ""Did you know that the Anrakan F..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Ewald Alphonso**: ""Imagine your very own miniature..." |
| `[39]` | **""Is that why you sold Gasom to them and abandoned Sordland for Anraka?""** | `[22]` **Ewald Alphonso**: ""Did you know that the Anrakan F..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Ewald Alphonso**: ""Mr. Rayne, please. You are not ..." |
| `[40]` | **""Why are you even here, Mr. Alphonso? You're not invested in the future of Sordlan..."** | `[22]` **Ewald Alphonso**: ""Did you know that the Anrakan F..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Ewald Alphonso**: ""Mr. Rayne, please. You are not ..." |
| `[45]` | **""I'd rather not discuss this any further, Mr. Alphonso.""** | `[44]` **Ewald Alphonso**: ""I'm getting old. Surely I've ea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Ewald Alphonso**: ""Suit yourself."" |
| `[46]` | **""You persuaded the Sordish state to invest in Gasom as a leap of faith -- and then..."** | `[44]` **Ewald Alphonso**: ""I'm getting old. Surely I've ea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Ewald Alphonso**: ""And now Gasom is booming. We've..."<br>`[227]` **Ewald Alphonso**: ""You recouped your investment, d..." |
| `[47]` | **""Don't try to blame me for your own selfishness.""** | `[44]` **Ewald Alphonso**: ""I'm getting old. Surely I've ea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Ewald Alphonso**: ""We've all benefited, just like ..." |
| `[52]` | **""That reminds me of another former president who lived on an island. Tarquin Soll.""** | `[50]` **Ewald Alphonso**: ""It's the perfect retirement. An..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Ewald Alphonso**: ""Oh, please."" |
| `[53]` | **""Isn't that all a bit much? No need to be such a show-off.""** | `[50]` **Ewald Alphonso**: ""It's the perfect retirement. An..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Ewald Alphonso**: ""Mr. Rayne, please. You are not ..." |
| `[54]` | **""Well... I find it disgusting.""** | `[50]` **Ewald Alphonso**: ""It's the perfect retirement. An..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Ewald Alphonso**: ""Mr. Rayne, please. You are not ..." |
| `[55]` | **""Good for you, I guess...""** | `[50]` **Ewald Alphonso**: ""It's the perfect retirement. An..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Ewald Alphonso**: ""Oh, it is, thank you."" |
| `[77]` | **""Soll is right about this. Rumburg should never have ended up with the largest sha..."** | `[76]` **Tarquin Soll**: ""Yet you did it anyway, knowing ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Ewald Alphonso**: ""Gentlemen, please. Neither of y..." |
| `[78]` | **""Ewald, I must remind you that you sold those shares before any diplomatic talks w..."** | `[76]` **Tarquin Soll**: ""Yet you did it anyway, knowing ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Ewald Alphonso**: ""Gentlemen, please. Neither of y..." |
| `[79]` | **""I don't begrudge Mr. Alphonso his decision. Especially since our relations with R..."** | `[76]` **Tarquin Soll**: ""Yet you did it anyway, knowing ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Ewald Alphonso**: ""Exactly. And you are doing an e..." |
| `[80]` | **""He has the freedom to sell his personal assets to anyone he chooses. Including Ru..."** | `[76]` **Tarquin Soll**: ""Yet you did it anyway, knowing ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Tarquin Soll**: ""Why don't you also go ahead and..."<br>`[98]` **Tarquin Soll**: ""Why don't you also go ahead and..."<br>*(oraz 1 innych odgałęzień)* |
| `[82]` | **""Same as ever? It's a foreign-owned company and Rumburg has the biggest stake.""** | `[81]` **Ewald Alphonso**: ""And Gasom is operating the same..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Ewald Alphonso**: ""I thought you'd be glad, Mr. Ra..." |
| `[83]` | **""That's good to hear. We can't risk any deterioration of relations with Rumburg.""** | `[81]` **Ewald Alphonso**: ""And Gasom is operating the same..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Ewald Alphonso**: ""Absolutely not. But now that th..." |
| `[84]` | **""I must remind you that you sold those shares before any diplomatic talks were bei..."** | `[81]` **Ewald Alphonso**: ""And Gasom is operating the same..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Ewald Alphonso**: ""Mr. Rayne, please. You are not ..." |
| `[85]` | **""How can you casually bring this up? You sold off Gasom, just to line your pockets..."** | `[81]` **Ewald Alphonso**: ""And Gasom is operating the same..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Ewald Alphonso**: ""Mr. Rayne, please. You are not ..." |
| `[106]` | **""You should have been able to fix Gasom on your own, not go begging for investment.""** | `[88]` **Ewald Alphonso**: ""Rumburg and Rizia were never my..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Ewald Alphonso**: ""I did everything I could do on ..." |
| `[107]` | **""Don't try to blame me for your own selfishness. I see now why Soll never trusted ..."** | `[88]` **Ewald Alphonso**: ""Rumburg and Rizia were never my..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Ewald Alphonso**: ""We're putting stock in the old ..." |
| `[119]` | **""Don't make me laugh. You always knew that Rumburg posed a threat. But you cared m..."** | `[115]` **Ewald Alphonso**: ""I had no idea our relations wou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Ewald Alphonso**: ""Please, let's not go there."" |
| `[120]` | **""This is my fault as much as it is yours. I never should have removed the Energy P..."** | `[115]` **Ewald Alphonso**: ""I had no idea our relations wou..."<br>`[57]` **Ewald Alphonso**: ""Don't even make that comparison.""<br>*(oraz 39 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Ewald Alphonso**: ""Thank you for your understanding."" |
| `[121]` | **""Sink this low? War is upon us, Ewald. And you betrayed our nation by handing our ..."** | `[115]` **Ewald Alphonso**: ""I had no idea our relations wou..." | `Variable["BaseGame.RumburgIncident_DeclareWar"] == true` | *Brak zmian stanu* | `[123]` **Ewald Alphonso**: ""I gave Sordland the first chanc..." |
| `[122]` | **""Don't expect me to sympathize with you. You sold off Gasom, just to line your poc..."** | `[115]` **Ewald Alphonso**: ""I had no idea our relations wou..." | `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false` | *Brak zmian stanu* | `[123]` **Ewald Alphonso**: ""I gave Sordland the first chanc..." |
| `[131]` | **""Colonel Soll is right. You are a traitor, Ewald.""** | `[118]` **Narrator**: "Ewald's upper lip curled." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Ewald Alphonso**: ""Gentlemen, please. Let's not go..." |
| `[132]` | **""What's done is done. Let's not start an argument.""** | `[118]` **Narrator**: "Ewald's upper lip curled." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Ewald Alphonso**: ""Thank you for your understanding."" |
| `[133]` | **""Don't expect anyone to sympathize with you. You sold off Gasom, just to line your..."** | `[118]` **Narrator**: "Ewald's upper lip curled." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Ewald Alphonso**: ""I gave Sordland every chance to..." |
| `[153]` | **""I was only trying to follow in your footsteps, Colonel.""** | `[152]` **Tarquin Soll**: ""When I passed the Energy Protec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Tarquin Soll**: ""My footsteps? If it were up to ..." |
| `[155]` | **""Mr. Soll is right. You are always looking for someone else to blame, Ewald.""** | `[154]` **Narrator**: "Ewald's upper lip curled." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Ewald Alphonso**: ""Gentlemen, please. Let's not go..." |
| `[156]` | **""What's done is done. Let's not start an argument now.""** | `[154]` **Narrator**: "Ewald's upper lip curled." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Ewald Alphonso**: ""You're right. Let's not dwell o..." |
| `[157]` | **""It wasn't my intention to revert it. The party forced me to do it. I had to compr..."** | `[154]` **Narrator**: "Ewald's upper lip curled." | `Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true` | *Brak zmian stanu* | `[163]` **Tarquin Soll**: ""You should never have tried to ..." |
| `[158]` | **""Don't be so harsh on him. I should have seen this coming.""** | `[154]` **Narrator**: "Ewald's upper lip curled." | `(Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true) == false` | *Brak zmian stanu* | `[162]` **Tarquin Soll**: ""No need to sympathize with him,..." |
| `[168]` | **""Justice for Soll's oppression has nothing to do with his energy policies, Ewald.""** | `[149]` **Ewald Alphonso**: ""Especially after you... brought..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Ewald Alphonso**: ""If you say so."" |
| `[169]` | **""What's done is done. Let's not start an argument now.""** | `[149]` **Ewald Alphonso**: ""Especially after you... brought..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Ewald Alphonso**: ""If you say so."" |
| `[170]` | **""The party forced me to revert your amendment to the EPA. I had to compromise.""** | `[149]` **Ewald Alphonso**: ""Especially after you... brought..." | `Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true` | *Brak zmian stanu* | `[177]` **Ewald Alphonso**: ""Of course you did."" |
| `[171]` | **""You may be right. I should have seen this coming.""** | `[149]` **Ewald Alphonso**: ""Especially after you... brought..." | `(Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true) == false` | *Brak zmian stanu* | `[178]` **Ewald Alphonso**: ""You should have. Because I warn..." |
| `[175]` | **""Don't try to pin your own failures on me.""** | `[149]` **Ewald Alphonso**: ""Especially after you... brought..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Ewald Alphonso**: ""If you say so."" |
| `[193]` | **""Thanks to the investment that *I* approved, you mean.""** | `[192]` **Ewald Alphonso**: ""Thanks to their joint investmen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Ewald Alphonso**: ""Of course, Mr. Rayne."" |
| `[194]` | **""It's good to see that the strategy we came up is paying off.""** | `[192]` **Ewald Alphonso**: ""Thanks to their joint investmen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Ewald Alphonso**: ""Truth be told, it was an incred..." |
| `[195]` | **""It's good to see the positive results of their investment.""** | `[191]` **Ewald Alphonso**: ""After all, thanks to them, Gaso..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Ewald Alphonso**: ""Truth be told, it was an incred..." |
| `[196]` | **""And what do you think about our Rizian partners?""** | `[191]` **Ewald Alphonso**: ""After all, thanks to them, Gaso..."<br>`[192]` **Ewald Alphonso**: ""Thanks to their joint investmen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Ewald Alphonso**: ""A curious bunch, but they do kn..." |
| `[197]` | **""Let's not forget, Ewald. Rizia isn't doing this for charity.""** | `[191]` **Ewald Alphonso**: ""After all, thanks to them, Gaso..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Ewald Alphonso**: ""I wouldn't have guessed."" |
| `[198]` | **""I still wouldn't rely on a kingdom -- one that has close ties with Queen Livingst..."** | `[191]` **Ewald Alphonso**: ""After all, thanks to them, Gaso..."<br>`[192]` **Ewald Alphonso**: ""Thanks to their joint investmen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Ewald Alphonso**: ""You are right to have your rese..." |
| `[203]` | **""Mr. Soll is not wrong. You are always looking for someone else to blame, Ewald.""** | `[202]` **Narrator**: "Ewald's upper lip curled." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Ewald Alphonso**: ""Gentlemen, please. Let's not go..." |
| `[204]` | **""What's done is done, Mr. Soll. Let's not start an argument now.""** | `[202]` **Narrator**: "Ewald's upper lip curled." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Ewald Alphonso**: ""You're right. Let's not dwell o..." |
| `[210]` | **""To be fair, it's good to see the positive results of our investment.""** | `[202]` **Narrator**: "Ewald's upper lip curled." | `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true` | *Brak zmian stanu* | `[220]` **Ewald Alphonso**: ""Truth be told, it was an incred..." |
| `[211]` | **""To be fair, it's good to see the positive results of their investment.""** | `[202]` **Narrator**: "Ewald's upper lip curled." | `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false` | *Brak zmian stanu* | `[220]` **Ewald Alphonso**: ""Truth be told, it was an incred..." |
| `[228]` | **""This isn't the fault of the free market. It's Mr. Alphonso's own selfishness.""** | `[223]` **Tarquin Soll**: ""Together, you are living proof ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[233]` **Ewald Alphonso**: ""If I may gently remind you, it ..." |
| `[229]` | **""You're right, Colonel. I see now that your energy protection laws were put in pla..."** | `[223]` **Tarquin Soll**: ""Together, you are living proof ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[234]` **Ewald Alphonso**: ""His laws as written would have ..." |
| `[230]` | **""'Dangers' would be overblown. Sordland and Gasom have both benefited from this de..."** | `[223]` **Tarquin Soll**: ""Together, you are living proof ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Ewald Alphonso**: ""Indeed. The value of Sordland's..." |
| `[242]` | **""No, I was naive enough to think all your talk about protecting your legacy meant ..."** | `[241]` **Ewald Alphonso**: ""And surely you knew this might ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Ewald Alphonso**: ""My legacy is my company, Mr. Ra..." |
| `[249]` | **""I'm glad about that. Our co-investment with Rizia was the right call in the end.""** | `[240]` **Ewald Alphonso**: ""Besides which, the value of Sor..."<br>`[247]` **Ewald Alphonso**: ""And the value of Sordland's own..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Ewald Alphonso**: ""As long as Rizia, Rumburg and S..." |
| `[250]` | **""All right. The next time you offer me a deal, I'll take it.""** | `[248]` **Ewald Alphonso**: ""I do wish you had taken me up o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[255]` **Ewald Alphonso**: ""Oh, I'm out of the deal-making ..." |
| `[251]` | **""I still don't feel entirely comfortable that Rumburg has so much leverage over us.""** | `[240]` **Ewald Alphonso**: ""Besides which, the value of Sor..."<br>`[247]` **Ewald Alphonso**: ""And the value of Sordland's own..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Ewald Alphonso**: ""To be honest, neither do I. Tha..." |
| `[253]` | **""I didn't count on Rumburg ending up with the largest stake in Gasom, no.""** | `[241]` **Ewald Alphonso**: ""And surely you knew this might ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Ewald Alphonso**: ""As long as Rizia, Rumburg and S..." |
| `[254]` | **""I still think not investing was the right call. It wasn't up to Sordland to fix G..."** | `[248]` **Ewald Alphonso**: ""I do wish you had taken me up o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Ewald Alphonso**: ""It doesn't make a difference to..." |
| `[263]` | **""This isn't the fault of the free market. It's Mr. Alphonso's own selfishness.""** | `[262]` **Tarquin Soll**: ""Together, you are living proof ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Ewald Alphonso**: ""I will say that I never advocat..." |
| `[264]` | **""You're right, Colonel. I see now that your energy protection laws were put in pla..."** | `[262]` **Tarquin Soll**: ""Together, you are living proof ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Ewald Alphonso**: ""I will say that I never advocat..." |
| `[266]` | **""Don't blame me for your own selfishness.""** | `[128]` **Ewald Alphonso**: ""When it was clear that Sordland..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[267]` | **""Let's not play the blame game. We have to focus on the here and now.""** | `[128]` **Ewald Alphonso**: ""When it was clear that Sordland..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[268]` | **""I removed the EPA as a favor to Gasom. And you returned that favor by selling you..."** | `[128]` **Ewald Alphonso**: ""When it was clear that Sordland..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[269]` **Ewald Alphonso**: ""I never asked for the removal o..." |
| `[270]` | **""This is my fault, Colonel. I never should have removed the Energy Protection Act.""** | `[118]` **Narrator**: "Ewald's upper lip curled." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Ewald Alphonso**: ""I did tell you not to raise the..." |
| `[284]` | **""It was never my intention to bankrupt Gasom. I made my decisions with the company..."** | `[152]` **Tarquin Soll**: ""When I passed the Energy Protec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[288]` **Ewald Alphonso**: ""Excuse me, but that's bullshit ..." |
| `[285]` | **""I was forced to revert the EPA to 10 percent foreign ownership. The USP made me d..."** | `[152]` **Tarquin Soll**: ""When I passed the Energy Protec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Tarquin Soll**: ""Blaming the USP for your own mi..." |
| `[292]` | **""It was never my intention to bankrupt Gasom. I made my decisions with the company..."** | `[279]` **Ewald Alphonso**: ""You're a snake, Rayne. Pure and..." | `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true` | *Brak zmian stanu* | `[297]` **Ewald Alphonso**: ""Excuse me, but that is bullshit..." |
| `[293]` | **""I was forced to revert the EPA to 10 percent foreign ownership. The USP made me d..."** | `[279]` **Ewald Alphonso**: ""You're a snake, Rayne. Pure and..." | `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true` | *Brak zmian stanu* | `[296]` **Ewald Alphonso**: ""Do not blame your own shortcomi..." |
| `[294]` | **""I'm sorry, Mr. Alphonso. But you got through it all unscathed, didn't you?""** | `[279]` **Ewald Alphonso**: ""You're a snake, Rayne. Pure and..." | `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true` | *Brak zmian stanu* | `[295]` **Ewald Alphonso**: ""Of course I did. But Gasom is a..." |

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
  - -> `[17]` (*Ewald Alphonso: ""You know...""*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: ""This is my fault as much as it is yours. I never should ..."*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == tr..."*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == ..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Ewald Alphonso: ""I flew in all the way from the Archipelago, just to be h..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == tr..."*)

### Węzeł `[6]`
Mówca: **Ewald Alphonso**
> ""I flew in all the way from the Archipelago, just to be here today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && (BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true || BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == tr..."*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == ..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && (BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true || BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  and  (Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true  or  Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks ==..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true && (BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true || BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  and  (Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true  or  Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == ..."*)

### Węzeł `[10]`
Mówca: **Ewald Alphonso**
> ""I'll be perfectly honest with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Ewald Alphonso: ""I've been starting to regret selling my Gasom shares to ..."*)

### Węzeł `[11]`
Mówca: **Ewald Alphonso**
> ""I was in Rumburg a few days ago to meet with several energy industry leaders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Ewald Alphonso: ""Believe it or not, the Rumburgians are now talking about..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true || BaseGame.Confrontation_USP_EnergyAct_RevertedTo10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == ..."*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_10Percent =..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true || BaseGame.Confrontation_USP_EnergyAct_RevertedTo10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true  or  Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true || BaseGame.Confrontation_USP_EnergyAct_RevertedTo10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true  or  Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true || ..."*)

### Węzeł `[15]`
Mówca: **Ewald Alphonso**
> ""When you promised me you wouldn't tighten the Energy Protection Act, I had the feeling you wouldn't keep your word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true..."*)

### Węzeł `[16]`
Mówca: **Ewald Alphonso**
> ""I was in Rizia a few days ago to meet with our energy partners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Ewald Alphonso: ""I was happy to find out that the royals over there appea..."*)

### Węzeł `[17]`
Mówca: **Ewald Alphonso**
> ""You know...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == tr..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Colonel Soll is right about this. You did sell your shares to them and abandon Sordland to go live in their country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Ewald Alphonso: ""Gentlemen, please. Neither of you can judge me.""*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Ewald Alphonso: ""Did you know that the Anrakan Federation is building isl..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Tarquin Soll: ""You shouldn't have. You don't live in Sordland anymore.""*)

### Węzeł `[22]`
Mówca: **Ewald Alphonso**
> ""Did you know that the Anrakan Federation is building islands in the middle of the ocean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: ""Let me guess. You live on one of them.""*)
  - -> `[38]` (*Player: ""That sounds impressive. Tell me more.""*)
  - -> `[39]` (*Player: ""Is that why you sold Gasom to them and abandoned Sordlan..."*)
  - -> `[40]` (*Player: ""Why are you even here, Mr. Alphonso? You're not invested..."*)

### Węzeł `[23]`
Mówca: **Tarquin Soll**
> ""You shouldn't have. You don't live in Sordland anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Tarquin Soll: ""I thought you couldn't sink any deeper when you handed t..."*)

### Węzeł `[24]`
Mówca: **Ewald Alphonso**
> ""I thought you would be happy to see an old friend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Tarquin Soll: ""Don't make me laugh, Ewald. You traded Sordland for damn..."*)

### Węzeł `[25]`
Mówca: **Narrator**
> "Ewald's upper lip curled, but he quickly turned it into a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Ewald Alphonso: ""I thought you would be happy to see an old friend.""*)

### Węzeł `[26]`
Mówca: **Tarquin Soll**
> ""I thought you couldn't sink any deeper when you handed the Anrakans the keys to our energy. But moving there was an all-time low, even for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "Ewald's upper lip curled, but he quickly turned it into a..."*)

### Węzeł `[27]`
Mówca: **Tarquin Soll**
> ""Don't make me laugh, Ewald. You traded Sordland for damn Anraka.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: ""Colonel Soll is right about this. You did sell your shar..."*)
  - -> `[28]` (*Player: ""Honestly, I feel the same way. This was not what I had i..."*)
  - -> `[29]` (*Player: ""Yes, Mr. Alphonso. Why did you decide to move to the Fed..."*)
  - -> `[30]` (*Player: ""A former Sordish president who chose to retire on an isl..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, I feel the same way. This was not what I had in mind when I removed the Energy Protection Act.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Ewald Alphonso: ""Gentlemen, please. Neither of you can judge me.""*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, Mr. Alphonso. Why did you decide to move to the Federation of Anrakan Isles?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Tarquin Soll: ""To live as a king, off of the backs of hard-working Sords.""*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A former Sordish president who chose to retire on an island. Sounds familiar.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Tarquin Soll: ""I chose to remain in Sordland, Mr. Rayne. My homeland. N..."*)

### Węzeł `[31]`
Mówca: **Tarquin Soll**
> ""I chose to remain in Sordland, Mr. Rayne. My homeland. Not to sell myself off to the highest bidder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Ewald Alphonso: ""Mr. Soll, please. You are not in a position to judge us.""*)

### Węzeł `[32]`
Mówca: **Ewald Alphonso**
> ""Gentlemen, please. Neither of you can judge me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Ewald Alphonso: ""Mr. President, the state's investment in Gasom helped th..."*)

### Węzeł `[33]`
Mówca: **Tarquin Soll**
> ""To live as a king, off of the backs of hard-working Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Ewald Alphonso: ""Mr. Soll, please. You are not in a position to judge me.""*)

### Węzeł `[34]`
Mówca: **Ewald Alphonso**
> ""Mr. Soll, please. You are not in a position to judge me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Ewald Alphonso: ""If you had your way and the EPA remained unchanged, Gaso..."*)

### Węzeł `[35]`
Mówca: **Ewald Alphonso**
> ""Mr. President, the state's investment in Gasom helped the company get back on its feet. I'll always appreciate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Ewald Alphonso: ""But after you removed the EPA, the Anrakans made me the ..."*)

### Węzeł `[36]`
Mówca: **Ewald Alphonso**
> ""But after you removed the EPA, the Anrakans made me the deal of a lifetime. I couldn't exactly refuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Ewald Alphonso: ""I'm getting old, gentlemen. Surely I've earned the right..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let me guess. You live on one of them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Ewald Alphonso: ""I do, actually.""*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That sounds impressive. Tell me more.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Ewald Alphonso: ""Imagine your very own miniature paradise, with its topog..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is that why you sold Gasom to them and abandoned Sordland for Anraka?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Ewald Alphonso: ""Mr. Rayne, please. You are not in a position to judge me.""*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why are you even here, Mr. Alphonso? You're not invested in the future of Sordland, so I can't imagine you're invested in Sordish football.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Ewald Alphonso: ""Mr. Rayne, please. You are not in a position to judge me.""*)

### Węzeł `[41]`
Mówca: **Ewald Alphonso**
> ""Mr. Rayne, please. You are not in a position to judge me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Ewald Alphonso: ""Your hefty investment in Gasom helped the company get ba..."*)

### Węzeł `[42]`
Mówca: **Ewald Alphonso**
> ""Your hefty investment in Gasom helped the company get back on its feet. I'll always appreciate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Ewald Alphonso: ""But after you removed the Energy Protection Act, the Anr..."*)

### Węzeł `[43]`
Mówca: **Ewald Alphonso**
> ""But after you removed the Energy Protection Act, the Anrakans made me the deal of a lifetime. I couldn't exactly refuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Ewald Alphonso: ""I'm getting old. Surely I've earned the right to a comfo..."*)

### Węzeł `[44]`
Mówca: **Ewald Alphonso**
> ""I'm getting old. Surely I've earned the right to a comfortable retirement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player: ""I'd rather not discuss this any further, Mr. Alphonso.""*)
  - -> `[46]` (*Player: ""You persuaded the Sordish state to invest in Gasom as a ..."*)
  - -> `[47]` (*Player: ""Don't try to blame me for your own selfishness.""*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'd rather not discuss this any further, Mr. Alphonso.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Ewald Alphonso: ""Suit yourself.""*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You persuaded the Sordish state to invest in Gasom as a leap of faith -- and then you turned around and sold your own shares.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Booming == true"*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't try to blame me for your own selfishness.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Ewald Alphonso: ""We've all benefited, just like I said. You, me, Gasom an..."*)

### Węzeł `[48]`
Mówca: **Ewald Alphonso**
> ""Mr. Soll, please. You are not in a position to judge us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Ewald Alphonso: ""If you had your way and the EPA remained unchanged, Gaso..."*)

### Węzeł `[49]`
Mówca: **Ewald Alphonso**
> ""I do, actually.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Ewald Alphonso: ""It's the perfect retirement. An entire island just for m..."*)

### Węzeł `[50]`
Mówca: **Ewald Alphonso**
> ""It's the perfect retirement. An entire island just for myself and my loved ones. And it's not even that expensive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: ""Good for you, I guess...""*)
  - -> `[52]` (*Player: ""That reminds me of another former president who lived on..."*)
  - -> `[53]` (*Player: ""Isn't that all a bit much? No need to be such a show-off.""*)
  - -> `[54]` (*Player: ""Well... I find it disgusting.""*)

### Węzeł `[51]`
Mówca: **Ewald Alphonso**
> ""Imagine your very own miniature paradise, with its topography custom-designed to suit your needs. Well, I don't need to imagine it -- I own one now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Ewald Alphonso: ""It's the perfect retirement. An entire island just for m..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That reminds me of another former president who lived on an island. Tarquin Soll.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Ewald Alphonso: ""Oh, please.""*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Isn't that all a bit much? No need to be such a show-off.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Ewald Alphonso: ""Mr. Rayne, please. You are not in a position to judge me.""*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well... I find it disgusting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Ewald Alphonso: ""Mr. Rayne, please. You are not in a position to judge me.""*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good for you, I guess...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Ewald Alphonso: ""Oh, it is, thank you.""*)

### Węzeł `[56]`
Mówca: **Ewald Alphonso**
> ""Oh, please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Ewald Alphonso: ""Don't even make that comparison.""*)

### Węzeł `[57]`
Mówca: **Ewald Alphonso**
> ""Don't even make that comparison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[58]`
Mówca: **Ewald Alphonso**
> ""Oh, it is, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[59]`
Mówca: **Ewald Alphonso**
> ""Suit yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[60]`
Mówca: **Ewald Alphonso**
> ""And now Gasom is booming. We've all won.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[61]`
Mówca: **Ewald Alphonso**
> ""We've all benefited, just like I said. You, me, Gasom and Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks ==..."*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks ..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Ewald Alphonso: ""I was in Rumburg a few days ago to meet with several ene..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Ewald Alphonso: ""I'll be perfectly honest with you.""*)

### Węzeł `[66]`
Mówca: **Ewald Alphonso**
> ""Believe it or not, the Rumburgians are now talking about pursuing a friendlier relationship with Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Ewald Alphonso: ""Selling my Gasom shares to Rumburg surely must have aide..."*)

### Węzeł `[67]`
Mówca: **Ewald Alphonso**
> ""Selling my Gasom shares to Rumburg surely must have aided with this diplomatic achievement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Ewald Alphonso: ""And Gasom is operating the same as ever. You don't even ..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Tarquin Soll: ""How dare you, son. If we avoided war with Rumburg, it wa..."*)

### Węzeł `[71]`
Mówca: **Tarquin Soll**
> ""How dare you, son. If we avoided war with Rumburg, it was by the skin of our teeth, not because you handed the Queen the key to our energy grid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Tarquin Soll: ""And now you're even boasting about how you climbed into ..."*)

### Węzeł `[72]`
Mówca: **Ewald Alphonso**
> ""Thanks to President Rayne, Sordland and Rumburg are set to become allies and business partners. Old enemies can still be future friends, Mr. Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Tarquin Soll: ""Don't speak like an idiot, Ewald. You made this deal lon..."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "Ewald's upper lip curled, but he quickly turned it into a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Ewald Alphonso: ""Thanks to President Rayne, Sordland and Rumburg are set ..."*)

### Węzeł `[74]`
Mówca: **Tarquin Soll**
> ""And now you're even boasting about how you climbed into bed with our enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "Ewald's upper lip curled, but he quickly turned it into a..."*)

### Węzeł `[75]`
Mówca: **Tarquin Soll**
> ""Don't speak like an idiot, Ewald. You made this deal long before diplomacy with Rumburg was in the cards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Tarquin Soll: ""Yet you did it anyway, knowing that war might be on the ..."*)

### Węzeł `[76]`
Mówca: **Tarquin Soll**
> ""Yet you did it anyway, knowing that war might be on the horizon. Just to line your pockets with Rumburgian crowns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: ""Soll is right about this. Rumburg should never have ende..."*)
  - -> `[78]` (*Player: ""Ewald, I must remind you that you sold those shares befo..."*)
  - -> `[79]` (*Player: ""I don't begrudge Mr. Alphonso his decision. Especially s..."*)
  - -> `[80]` (*Player: ""He has the freedom to sell his personal assets to anyone..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Soll is right about this. Rumburg should never have ended up with the largest share in Gasom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Ewald Alphonso: ""Gentlemen, please. Neither of you can judge me.""*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Ewald, I must remind you that you sold those shares before any diplomatic talks were being discussed. Don't use that as an excuse.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Ewald Alphonso: ""Gentlemen, please. Neither of you can judge me.""*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't begrudge Mr. Alphonso his decision. Especially since our relations with Rumburg have improved so much.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Ewald Alphonso: ""Exactly. And you are doing an extraordinary job on that ..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He has the freedom to sell his personal assets to anyone he chooses. Including Rumburg.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[81]`
Mówca: **Ewald Alphonso**
> ""And Gasom is operating the same as ever. You don't even notice the difference in ownership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: ""Same as ever? It's a foreign-owned company and Rumburg h..."*)
  - -> `[83]` (*Player: ""That's good to hear. We can't risk any deterioration of ..."*)
  - -> `[84]` (*Player: ""I must remind you that you sold those shares before any ..."*)
  - -> `[85]` (*Player: ""How can you casually bring this up? You sold off Gasom, ..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Same as ever? It's a foreign-owned company and Rumburg has the biggest stake.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Ewald Alphonso: ""I thought you'd be glad, Mr. Rayne. If your goal is to a..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's good to hear. We can't risk any deterioration of relations with Rumburg.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Ewald Alphonso: ""Absolutely not. But now that they own such a large stake..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I must remind you that you sold those shares before any diplomatic talks were being discussed. You handed our largest rival the keys to our energy grid.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Ewald Alphonso: ""Mr. Rayne, please. You are not in a position to judge me.""*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""How can you casually bring this up? You sold off Gasom, just to line your pockets with Rumburgian crowns.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Ewald Alphonso: ""Mr. Rayne, please. You are not in a position to judge me.""*)

### Węzeł `[86]`
Mówca: **Ewald Alphonso**
> ""Mr. Rayne, please. You are not in a position to judge me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Ewald Alphonso: ""You didn't invest enough to help keep my company afloat,..."*)

### Węzeł `[87]`
Mówca: **Ewald Alphonso**
> ""You didn't invest enough to help keep my company afloat, while opening the door to foreigners who were willing to do exactly that. What did you think would happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Ewald Alphonso: ""Rumburg and Rizia were never my first choices. But they ..."*)

### Węzeł `[88]`
Mówca: **Ewald Alphonso**
> ""Rumburg and Rizia were never my first choices. But they came to Gasom's rescue when Sordland would not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player: ""You should have been able to fix Gasom on your own, not ..."*)
  - -> `[107]` (*Player: ""Don't try to blame me for your own selfishness. I see no..."*)

### Węzeł `[89]`
Mówca: **Ewald Alphonso**
> ""I thought you'd be glad, Mr. Rayne. If your goal is to avoid conflict with Rumburg, a stake in Gasom is one hell of a peace offering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment == true"*)

### Węzeł `[90]`
Mówca: **Ewald Alphonso**
> ""Gentlemen, please. Neither of you can judge me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Ewald Alphonso: ""President Rayne, you didn't invest enough to help keep m..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Tarquin Soll: ""Why don't you also go ahead and sell FC Anrica to Queen ..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Underhall == true"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Underhall == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Underhall == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_Underhall == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Underhall == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_Underhall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Tarquin Soll: ""Why don't you also go ahead and sell your shares of Unde..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_Underhall == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Underhall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Tarquin Soll: ""I can't believe the two of you. You join my party and th..."*)

### Węzeł `[97]`
Mówca: **Tarquin Soll**
> ""Why don't you also go ahead and sell FC Anrica to Queen Beatrice?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Ewald Alphonso: ""Mr. Soll, please. You are in no position to judge us.""*)

### Węzeł `[98]`
Mówca: **Tarquin Soll**
> ""Why don't you also go ahead and sell your shares of Underhall Construction to Queen Beatrice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Ewald Alphonso: ""Mr. Soll, please. You are in no position to judge us.""*)

### Węzeł `[99]`
Mówca: **Tarquin Soll**
> ""I can't believe the two of you. You join my party and then undermine everything it stands for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Ewald Alphonso: ""Mr. Soll, please. You are in no position to judge us.""*)

### Węzeł `[100]`
Mówca: **Ewald Alphonso**
> ""Exactly. And you are doing an extraordinary job on that front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Tarquin Soll: ""You cannot trust a monarchy, gentlemen. Rizia and Rumbur..."*)

### Węzeł `[101]`
Mówca: **Ewald Alphonso**
> ""Mr. Soll, please. You are in no position to judge us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Tarquin Soll: ""No, but history will judge you. And I suspect it will fi..."*)

### Węzeł `[102]`
Mówca: **Tarquin Soll**
> ""No, but history will judge you. And I suspect it will find you wanting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[104]`
Mówca: **Tarquin Soll**
> ""You cannot trust a monarchy, gentlemen. Rizia and Rumburg will never be our friends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You should have been able to fix Gasom on your own, not go begging for investment.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Ewald Alphonso: ""I did everything I could do on my own. But a company nee..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't try to blame me for your own selfishness. I see now why Soll never trusted you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Ewald Alphonso: ""We're putting stock in the old man's opinion now?""*)

### Węzeł `[108]`
Mówca: **Ewald Alphonso**
> ""I did everything I could do on my own. But a company needs investors to truly thrive. Look at how it's been booming with Rumburg's involvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[109]`
Mówca: **Ewald Alphonso**
> ""We're putting stock in the old man's opinion now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[110]`
Mówca: **Ewald Alphonso**
> ""I've been starting to regret selling my Gasom shares to Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Ewald Alphonso: ""I had no idea our relations would sink this low.""*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Soll_Hates_Alphonso = true"*)

### Węzeł `[114]`
Mówca: **Tarquin Soll**
> ""Relations? We are on the verge of war, Mr. Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Tarquin Soll: ""You handed our enemies the keys to our energy. And now y..."*)

### Węzeł `[115]`
Mówca: **Ewald Alphonso**
> ""I had no idea our relations would sink this low.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: ""Don't make me laugh. You always knew that Rumburg posed ..."*)
  - -> `[120]` (*Player: ""This is my fault as much as it is yours. I never should ..."*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[116]`
Mówca: **Tarquin Soll**
> ""You handed our enemies the keys to our energy. And now you're acting as if you had no idea Rumburg posed a threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Tarquin Soll: ""You are a traitor. It's that simple.""*)

### Węzeł `[117]`
Mówca: **Tarquin Soll**
> ""You are a traitor. It's that simple.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "Ewald's upper lip curled."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "Ewald's upper lip curled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: ""Colonel Soll is right. You are a traitor, Ewald.""*)
  - -> `[132]` (*Player: ""What's done is done. Let's not start an argument.""*)
  - -> `[270]` (*Player: ""This is my fault, Colonel. I never should have removed t..."*)
  - -> `[133]` (*Player: ""Don't expect anyone to sympathize with you. You sold off..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't make me laugh. You always knew that Rumburg posed a threat. But you cared more about your precious free market than national security.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Ewald Alphonso: ""Please, let's not go there.""*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is my fault as much as it is yours. I never should have removed the Energy Protection Act.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Ewald Alphonso), `[57]` (Ewald Alphonso), `[58]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Ewald Alphonso: ""Thank you for your understanding.""*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sink this low? War is upon us, Ewald. And you betrayed our nation by handing our enemies the keys to our energy.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Kontekst wejściowy (poprzednik):** `[115]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Ewald Alphonso: ""I gave Sordland the first chance at a large investment. ..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't expect me to sympathize with you. You sold off Gasom, just to line your pockets with Rumburgian crowns.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[115]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Ewald Alphonso: ""I gave Sordland the first chance at a large investment. ..."*)

### Węzeł `[123]`
Mówca: **Ewald Alphonso**
> ""I gave Sordland the first chance at a large investment. I told you that completely removing the Energy Protection Act might compromise our interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[124]`
Mówca: **Ewald Alphonso**
> ""Please, let's not go there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Ewald Alphonso: ""I gave Sordland the first chance at a large investment. ..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: ""Sink this low? War is upon us, Ewald. And you betrayed o..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: ""Don't expect me to sympathize with you. You sold off Gas..."*)

### Węzeł `[128]`
Mówca: **Ewald Alphonso**
> ""When it was clear that Sordland wouldn't help Gasom, I had to look elsewhere. But I didn't hand Rumburg the key to Sordish energy, Mr. President. You did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Player: ""Don't blame me for your own selfishness.""*)
  - -> `[267]` (*Player: ""Let's not play the blame game. We have to focus on the h..."*)
  - -> `[268]` (*Player: ""I removed the EPA as a favor to Gasom. And you returned ..."*)

### Węzeł `[129]`
Mówca: **Ewald Alphonso**
> ""Thank you for your understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[130]`
Mówca: **Ewald Alphonso**
> ""I didn't know our relations would sink this low.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Tarquin Soll: ""Relations? We are on the verge of war, Mr. Alphonso.""*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Colonel Soll is right. You are a traitor, Ewald.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Ewald Alphonso: ""Gentlemen, please. Let's not go that far.""*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's done is done. Let's not start an argument.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Ewald Alphonso: ""Thank you for your understanding.""*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't expect anyone to sympathize with you. You sold off Gasom, just to line your pockets with Rumburgian crowns.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Ewald Alphonso: ""I gave Sordland every chance to invest, didn't I? When y..."*)

### Węzeł `[134]`
Mówca: **Ewald Alphonso**
> ""Thank you for your understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Soll_Hates_Alphonso = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Soll_Hates_Alphonso"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Ewald Alphonso: ""I didn't know our relations would sink this low.""*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[137]`
Mówca: **Ewald Alphonso**
> ""Gentlemen, please. Let's not go that far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[138]`
Mówca: **Ewald Alphonso**
> ""I did tell you not to raise the cap on foreign ownership over 49 percent, didn't I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Ewald Alphonso: ""But please let's not dwell on this any longer. I just wa..."*)

### Węzeł `[139]`
Mówca: **Ewald Alphonso**
> ""But please let's not dwell on this any longer. I just wanted to be open with you about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[140]`
Mówca: **Ewald Alphonso**
> ""I gave Sordland every chance to invest, didn't I? When you wouldn't help keep Gasom afloat, I had to look elsewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Ewald Alphonso: ""But please let's not dwell on this any longer. I just wa..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Ewald Alphonso: ""You ignored both of those pieces of advice, and went on ..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Ewald Alphonso: ""When it was clear that Sordland wouldn't help Gasom, I h..."*)

### Węzeł `[144]`
Mówca: **Ewald Alphonso**
> ""You ignored both of those pieces of advice, and went on to declare war on Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Ewald Alphonso: ""When it was clear that Sordland wouldn't help Gasom, I h..."*)

### Węzeł `[145]`
Mówca: **Ewald Alphonso**
> ""I can't believe you would attempt to follow in Soll's footsteps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Ewald Alphonso: ""Especially after you... brought him down like that.""*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Player: ""It was never my intention to bankrupt Gasom. I made my d..."*)
  - -> `[293]` (*Player: ""I was forced to revert the EPA to 10 percent foreign own..."*)
  - -> `[294]` (*Player: ""I'm sorry, Mr. Alphonso. But you got through it all unsc..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "Soll looked at me sharply."*)

### Węzeł `[149]`
Mówca: **Ewald Alphonso**
> ""Especially after you... brought him down like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Player: ""Don't try to pin your own failures on me.""*)
  - -> `[168]` (*Player: ""Justice for Soll's oppression has nothing to do with his..."*)
  - -> `[169]` (*Player: ""What's done is done. Let's not start an argument now.""*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true"*)

### Węzeł `[150]`
Mówca: **Narrator**
> "Soll looked at me sharply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Tarquin Soll: ""Is that true, boy?""*)

### Węzeł `[151]`
Mówca: **Tarquin Soll**
> ""Is that true, boy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Tarquin Soll: ""When I passed the Energy Protection Act, my intention wa..."*)

### Węzeł `[152]`
Mówca: **Tarquin Soll**
> ""When I passed the Energy Protection Act, my intention was to protect the Sordish state from nefarious interests. Not for the Sordish state to become one of those interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player: ""I was only trying to follow in your footsteps, Colonel.""*)
  - -> `[284]` (*Player: ""It was never my intention to bankrupt Gasom. I made my d..."*)
  - -> `[285]` (*Player: ""I was forced to revert the EPA to 10 percent foreign own..."*)

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I was only trying to follow in your footsteps, Colonel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Tarquin Soll: ""My footsteps? If it were up to me, Gasom would have been..."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "Ewald's upper lip curled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Player: ""Mr. Soll is right. You are always looking for someone el..."*)
  - -> `[156]` (*Player: ""What's done is done. Let's not start an argument now.""*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true"*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Soll is right. You are always looking for someone else to blame, Ewald.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Ewald Alphonso: ""Gentlemen, please. Let's not go that far.""*)

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's done is done. Let's not start an argument now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Ewald Alphonso: ""You're right. Let's not dwell on this.""*)

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It wasn't my intention to revert it. The party forced me to do it. I had to compromise.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true`
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Tarquin Soll: ""You should never have tried to go against the USP in the..."*)

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't be so harsh on him. I should have seen this coming.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Tarquin Soll: ""No need to sympathize with him, Mr. Rayne."""*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true"*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true)"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Player: ""It wasn't my intention to revert it. The party forced me..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Player: ""Don't be so harsh on him. I should have seen this coming.""*)

### Węzeł `[162]`
Mówca: **Tarquin Soll**
> ""No need to sympathize with him, Mr. Rayne."""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Ewald Alphonso: ""Okay, gentlemen. Let's not ponder over this any longer. ..."*)

### Węzeł `[163]`
Mówca: **Tarquin Soll**
> ""You should never have tried to go against the USP in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Ewald Alphonso: ""Okay, gentlemen. Let's not ponder over this any longer. ..."*)

### Węzeł `[164]`
Mówca: **Ewald Alphonso**
> ""You're right. Let's not dwell on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[165]`
Mówca: **Ewald Alphonso**
> ""Gentlemen, please. Let's not go that far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[167]`
Mówca: **Ewald Alphonso**
> ""Okay, gentlemen. Let's not ponder over this any longer. My intention was not to start an argument.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Justice for Soll's oppression has nothing to do with his energy policies, Ewald.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Ewald Alphonso: ""If you say so.""*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's done is done. Let's not start an argument now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Ewald Alphonso: ""If you say so.""*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The party forced me to revert your amendment to the EPA. I had to compromise.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true`
- **Kontekst wejściowy (poprzednik):** `[149]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Ewald Alphonso: ""Of course you did.""*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You may be right. I should have seen this coming.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[149]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Ewald Alphonso: ""You should have. Because I warned you.""*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true"*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true)"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player: ""The party forced me to revert your amendment to the EPA...."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player: ""You may be right. I should have seen this coming.""*)

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't try to pin your own failures on me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Ewald Alphonso: ""If you say so.""*)

### Węzeł `[176]`
Mówca: **Ewald Alphonso**
> ""If you say so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Ewald Alphonso: "Anyway... Let's not dwell on this any longer. My intentio..."*)

### Węzeł `[177]`
Mówca: **Ewald Alphonso**
> ""Of course you did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Ewald Alphonso: "Anyway... Let's not dwell on this any longer. My intentio..."*)

### Węzeł `[178]`
Mówca: **Ewald Alphonso**
> ""You should have. Because I warned you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Ewald Alphonso: "Anyway... Let's not dwell on this any longer. My intentio..."*)

### Węzeł `[179]`
Mówca: **Ewald Alphonso**
> "Anyway... Let's not dwell on this any longer. My intention was not to start an argument.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[181]`
Mówca: **Ewald Alphonso**
> ""I was happy to find out that the royals over there appear to be in favor of pursuing friendlier relations with Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Ewald Alphonso: ""I still don't think they will do anything to harm their ..."*)

### Węzeł `[182]`
Mówca: **Ewald Alphonso**
> ""I still don't think they will do anything to harm their connection with Rumburg, but cooperating with them was the right call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Tarquin Soll: ""You're fond of the monarchists now, Ewald? They must be ..."*)

### Węzeł `[186]`
Mówca: **Tarquin Soll**
> ""You're fond of the monarchists now, Ewald? They must be filling your pockets with Rizian gold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Ewald Alphonso: ""For Dast's sake, Mr. Soll, try to see the positive in wh..."*)

### Węzeł `[187]`
Mówca: **Ewald Alphonso**
> ""For Dast's sake, Mr. Soll, try to see the positive in what I do. For once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Tarquin Soll: ""How about you claim responsibility for once? It is your ..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true"*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Ewald Alphonso: ""Thanks to their joint investment with our government, Ga..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Ewald Alphonso: ""After all, thanks to them, Gasom is still up and running.""*)

### Węzeł `[191]`
Mówca: **Ewald Alphonso**
> ""After all, thanks to them, Gasom is still up and running.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player: ""And what do you think about our Rizian partners?""*)
  - -> `[195]` (*Player: ""It's good to see the positive results of their investment.""*)
  - -> `[197]` (*Player: ""Let's not forget, Ewald. Rizia isn't doing this for char..."*)
  - -> `[198]` (*Player: ""I still wouldn't rely on a kingdom -- one that has close..."*)

### Węzeł `[192]`
Mówca: **Ewald Alphonso**
> ""Thanks to their joint investment with our government, Gasom is still up and running.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Player: ""Thanks to the investment that *I* approved, you mean.""*)
  - -> `[194]` (*Player: ""It's good to see that the strategy we came up is paying ..."*)
  - -> `[196]` (*Player: ""And what do you think about our Rizian partners?""*)
  - -> `[198]` (*Player: ""I still wouldn't rely on a kingdom -- one that has close..."*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thanks to the investment that *I* approved, you mean.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Ewald Alphonso: ""Of course, Mr. Rayne.""*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's good to see that the strategy we came up is paying off.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Ewald Alphonso: ""Truth be told, it was an incredible help.""*)

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's good to see the positive results of their investment.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Ewald Alphonso: ""Truth be told, it was an incredible help.""*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And what do you think about our Rizian partners?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Ewald Alphonso), `[192]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Ewald Alphonso: ""A curious bunch, but they do know the gas business.""*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's not forget, Ewald. Rizia isn't doing this for charity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Ewald Alphonso: ""I wouldn't have guessed.""*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I still wouldn't rely on a kingdom -- one that has close ties with Queen Livingston especially.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Ewald Alphonso), `[192]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Ewald Alphonso: ""You are right to have your reservations but they are rel..."*)

### Węzeł `[199]`
Mówca: **Tarquin Soll**
> ""How about you claim responsibility for once? It is your fault that a giant like Gasom was brought to the brink of collapse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Ewald Alphonso: ""I've done ever-"*)

### Węzeł `[200]`
Mówca: **Tarquin Soll**
> ""Admit it. It was too much of a responsibility for you. A man with your profit-focused mentality should have never been given the keys to such a vital sector.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "Ewald's upper lip curled."*)

### Węzeł `[201]`
Mówca: **Ewald Alphonso**
> ""I've done ever-"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Tarquin Soll: ""Admit it. It was too much of a responsibility for you. A..."*)

### Węzeł `[202]`
Mówca: **Narrator**
> "Ewald's upper lip curled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Player: ""Mr. Soll is not wrong. You are always looking for someon..."*)
  - -> `[204]` (*Player: ""What's done is done, Mr. Soll. Let's not start an argume..."*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true"*)

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Soll is not wrong. You are always looking for someone else to blame, Ewald.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Ewald Alphonso: ""Gentlemen, please. Let's not go that far.""*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's done is done, Mr. Soll. Let's not start an argument now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Ewald Alphonso: ""You're right. Let's not dwell on this.""*)

### Węzeł `[205]`
Mówca: **Ewald Alphonso**
> ""You're right. Let's not dwell on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[206]`
Mówca: **Ewald Alphonso**
> ""Gentlemen, please. Let's not go that far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Player: ""To be fair, it's good to see the positive results of our..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Player: ""To be fair, it's good to see the positive results of the..."*)

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""To be fair, it's good to see the positive results of our investment.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`
- **Kontekst wejściowy (poprzednik):** `[202]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Ewald Alphonso: ""Truth be told, it was an incredible help.""*)

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""To be fair, it's good to see the positive results of their investment.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[202]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Ewald Alphonso: ""Truth be told, it was an incredible help.""*)

### Węzeł `[212]`
Mówca: **Ewald Alphonso**
> ""A curious bunch, but they do know the gas business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Ewald Alphonso: ""They are an important regional player, Mr. Rayne. One th..."*)

### Węzeł `[213]`
Mówca: **Ewald Alphonso**
> ""They are an important regional player, Mr. Rayne. One that we should keep close to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Ewald Alphonso: ""Oh. And they have great food and wine. Spend some time t..."*)

### Węzeł `[214]`
Mówca: **Ewald Alphonso**
> ""Oh. And they have great food and wine. Spend some time there and you'll realize how overrated Lespian cuisine is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[215]`
Mówca: **Ewald Alphonso**
> ""Truth be told, it was an incredible help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[216]`
Mówca: **Ewald Alphonso**
> ""I wouldn't have guessed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[217]`
Mówca: **Ewald Alphonso**
> ""You are right to have your reservations but they are reliable business partners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[218]`
Mówca: **Ewald Alphonso**
> ""Of course, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Ewald Alphonso: ""We can't thank you enough.""*)

### Węzeł `[219]`
Mówca: **Ewald Alphonso**
> ""We can't thank you enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[220]`
Mówca: **Ewald Alphonso**
> ""Truth be told, it was an incredible help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[221]`
Mówca: **Ewald Alphonso**
> ""I'm getting old, gentlemen. Surely I've earned the right to a comfortable retirement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Tarquin Soll: ""You and Mr. Rayne have earned nothing but my disdain.""*)

### Węzeł `[222]`
Mówca: **Tarquin Soll**
> ""You and Mr. Rayne have earned nothing but my disdain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Tarquin Soll: ""Together, you are living proof of the dangers of Alphons..."*)

### Węzeł `[223]`
Mówca: **Tarquin Soll**
> ""Together, you are living proof of the dangers of Alphonsonomics and the free market.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Player: ""This isn't the fault of the free market. It's Mr. Alphon..."*)
  - -> `[229]` (*Player: ""You're right, Colonel. I see now that your energy protec..."*)
  - -> `[230]` (*Player: ""'Dangers' would be overblown. Sordland and Gasom have bo..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Booming == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Booming == true"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Gasom_Booming == true)"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Booming == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Gasom_Booming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Ewald Alphonso: ""And now Gasom is booming. We've all won.""*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Gasom_Booming == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Gasom_Booming"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Ewald Alphonso: ""You recouped your investment, didn't you? The leap of fa..."*)

### Węzeł `[227]`
Mówca: **Ewald Alphonso**
> ""You recouped your investment, didn't you? The leap of faith was justified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This isn't the fault of the free market. It's Mr. Alphonso's own selfishness.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Ewald Alphonso: ""If I may gently remind you, it was never my intention to..."*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're right, Colonel. I see now that your energy protection laws were put in place for a reason.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Ewald Alphonso: ""His laws as written would have choked the life out of Ga..."*)

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""'Dangers' would be overblown. Sordland and Gasom have both benefited from this deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Ewald Alphonso: ""Indeed. The value of Sordland's investment has only gone..."*)

### Węzeł `[231]`
Mówca: **Ewald Alphonso**
> ""If you had your way and the EPA remained unchanged, Gasom would have gone bankrupt and thousands of good Sordish men and women would be out of work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Tarquin Soll: ""You're the one who ran Gasom into the ground, Mr. Alphon..."*)

### Węzeł `[232]`
Mówca: **Tarquin Soll**
> ""You're the one who ran Gasom into the ground, Mr. Alphonso. You should not have had to ask for foreign assistance in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Tarquin Soll: ""And you, Mr. Rayne. By overturning my Energy Protection ..."*)

### Węzeł `[233]`
Mówca: **Ewald Alphonso**
> ""If I may gently remind you, it was never my intention to do away with the EPA altogether. That was a pure Anton Rayne touch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[234]`
Mówca: **Ewald Alphonso**
> ""His laws as written would have choked the life out of Gasom. But I did see the wisdom in putting a cap on foreign ownership. You're the one who wanted to do away with it entirely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[235]`
Mówca: **Ewald Alphonso**
> ""Indeed. The value of Sordland's investment has only gone up since the Anraka purchase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[236]`
Mówca: **Tarquin Soll**
> ""And you, Mr. Rayne. By overturning my Energy Protection Act, you set the stage for exactly this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Tarquin Soll: ""Together, you are living proof of the dangers of Alphons..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment == true"*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment ==..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Ewald Alphonso: ""Besides which, the value of Sordland's own shares in Gas..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Ewald Alphonso: ""And surely you knew this might happen when you removed t..."*)

### Węzeł `[240]`
Mówca: **Ewald Alphonso**
> ""Besides which, the value of Sordland's own shares in Gasom has never been higher.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Player: ""I still don't feel entirely comfortable that Rumburg has..."*)
  - -> `[249]` (*Player: ""I'm glad about that. Our co-investment with Rizia was th..."*)

### Węzeł `[241]`
Mówca: **Ewald Alphonso**
> ""And surely you knew this might happen when you removed the Energy Protection Act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Player: ""No, I was naive enough to think all your talk about prot..."*)
  - -> `[253]` (*Player: ""I didn't count on Rumburg ending up with the largest sta..."*)

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, I was naive enough to think all your talk about protecting your legacy meant you'd hold on to your shares.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[241]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Ewald Alphonso: ""My legacy is my company, Mr. Rayne. My shares are meanin..."*)

### Węzeł `[243]`
Mówca: **Ewald Alphonso**
> ""Absolutely not. But now that they own such a large stake in Gasom, they would never damage its value by provoking conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment == true"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment == true"*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment ==..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Ewald Alphonso: ""And the value of Sordland's own shares in Gasom has neve..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Ewald Alphonso: ""I do wish you had taken me up on my offer. Sordland woul..."*)

### Węzeł `[247]`
Mówca: **Ewald Alphonso**
> ""And the value of Sordland's own shares in Gasom has never been higher. This is truly a win-win solution for everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Player: ""I still don't feel entirely comfortable that Rumburg has..."*)
  - -> `[249]` (*Player: ""I'm glad about that. Our co-investment with Rizia was th..."*)

### Węzeł `[248]`
Mówca: **Ewald Alphonso**
> ""I do wish you had taken me up on my offer. Sordland would have more than recouped its investment by now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player: ""All right. The next time you offer me a deal, I'll take ..."*)
  - -> `[254]` (*Player: ""I still think not investing was the right call. It wasn'..."*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm glad about that. Our co-investment with Rizia was the right call in the end.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Ewald Alphonso), `[247]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Ewald Alphonso: ""As long as Rizia, Rumburg and Sordland all remain on fri..."*)

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""All right. The next time you offer me a deal, I'll take it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[248]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Ewald Alphonso: ""Oh, I'm out of the deal-making business these days. You'..."*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I still don't feel entirely comfortable that Rumburg has so much leverage over us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Ewald Alphonso), `[247]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Ewald Alphonso: ""To be honest, neither do I. That's why I never advocated..."*)

### Węzeł `[252]`
Mówca: **Ewald Alphonso**
> ""To be honest, neither do I. That's why I never advocated for the complete removal of the Energy Protection Act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I didn't count on Rumburg ending up with the largest stake in Gasom, no.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[241]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Ewald Alphonso: ""As long as Rizia, Rumburg and Sordland all remain on fri..."*)

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I still think not investing was the right call. It wasn't up to Sordland to fix Gasom's mess.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[248]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Ewald Alphonso: ""It doesn't make a difference to me. Just pointing out th..."*)

### Węzeł `[255]`
Mówca: **Ewald Alphonso**
> ""Oh, I'm out of the deal-making business these days. You're better off asking Gus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[256]`
Mówca: **Ewald Alphonso**
> ""It doesn't make a difference to me. Just pointing out that we both could have struck it rich.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[257]`
Mówca: **Ewald Alphonso**
> ""As long as Rizia, Rumburg and Sordland all remain on friendly terms, it'll be smooth sailing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[258]`
Mówca: **Ewald Alphonso**
> ""My legacy is my company, Mr. Rayne. My shares are meaningless if the company stagnates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[259]`
Mówca: **Ewald Alphonso**
> ""President Rayne, you didn't invest enough to help keep my company afloat, while opening the door to foreigners who were willing to do exactly that. What did you think would happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Ewald Alphonso: ""Rumburg and Rizia were never my first choices. But they ..."*)

### Węzeł `[260]`
Mówca: **Ewald Alphonso**
> ""Rumburg and Rizia were never my first choices. But they came to Gasom's rescue when Sordland would not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Tarquin Soll: ""They would not even have had that opportunity if you two..."*)

### Węzeł `[261]`
Mówca: **Tarquin Soll**
> ""They would not even have had that opportunity if you two hadn't begun meddling with the Energy Protection Act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Tarquin Soll: ""Together, you are living proof of the dangers of Alphons..."*)

### Węzeł `[262]`
Mówca: **Tarquin Soll**
> ""Together, you are living proof of the dangers of Alphonsonomics and the free market.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Player: ""This isn't the fault of the free market. It's Mr. Alphon..."*)
  - -> `[264]` (*Player: ""You're right, Colonel. I see now that your energy protec..."*)

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This isn't the fault of the free market. It's Mr. Alphonso's own selfishness.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Ewald Alphonso: ""I will say that I never advocated for the complete remov..."*)

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're right, Colonel. I see now that your energy protection laws were put in place for a reason.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Ewald Alphonso: ""I will say that I never advocated for the complete remov..."*)

### Węzeł `[265]`
Mówca: **Ewald Alphonso**
> ""I will say that I never advocated for the complete removal of the EPA. That was purely Anton Rayne's decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't blame me for your own selfishness.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's not play the blame game. We have to focus on the here and now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I removed the EPA as a favor to Gasom. And you returned that favor by selling your shares to our enemy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Ewald Alphonso: ""I never asked for the removal of the EPA. I wanted to pu..."*)

### Węzeł `[269]`
Mówca: **Ewald Alphonso**
> ""I never asked for the removal of the EPA. I wanted to put Sordish interests first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is my fault, Colonel. I never should have removed the Energy Protection Act.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Ewald Alphonso: ""I did tell you not to raise the cap on foreign ownership..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true)"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Ewald Alphonso: ""When you promised me you wouldn't tighten the Energy Pro..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Ewald Alphonso: ""I had a feeling that despite all of our conversations, y..."*)

### Węzeł `[274]`
Mówca: **Ewald Alphonso**
> ""I had a feeling that despite all of our conversations, you never truly grasped how much Gasom meant to me or Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true && BaseGame.Turn03_Admin_EnergyProtectionAct_Removed == true && (BaseGame.Decision_Turn06_GasomStake_SellTwoThird == true || BaseGame.Decision_Turn06_GasomStake_SellOneThird == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true..."*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == tr..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true && BaseGame.Turn03_Admin_EnergyProtectionAct_Removed == true && (BaseGame.Decision_Turn06_GasomStake_SellTwoThird == true || BaseGame.Decision_Turn06_GasomStake_SellOneThird == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true  and  Variable["BaseGame.Turn03_Admin_EnergyProtectionAct_Removed"] == true  and  (Variable["BaseGame.Decision_Turn06_GasomStake_SellTwoThird"] == true  or  Variable["BaseGame.Decision_Turn06_GasomStake_SellOneThird"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Ewald Alphonso: ""But removing the EPA for just long enough to maximize th..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true && BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true && BaseGame.Turn03_Admin_EnergyProtectionAct_Removed == true && (BaseGame.Decision_Turn06_GasomStake_SellTwoThird == true || BaseGame.Decision_Turn06_GasomStake_SellOneThird == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true  and  Variable["BaseGame.Turn03_Admin_EnergyProtectionAct_Removed"] == true  and  (Variable["BaseGame.Decision_Turn06_GasomStake_SellTwoThird"] == true  or  Variable["BaseGame.Decision_Turn06_GasomStake_SellOneThird"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Ewald Alphonso: ""But I hope you see now how much damage you've done to ou..."*)

### Węzeł `[278]`
Mówca: **Ewald Alphonso**
> ""But removing the EPA for just long enough to maximize the value of your investment, then selling your shares before forcing our foreign investors to sell theirs and bankrupting our company?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Ewald Alphonso: ""You're a snake, Rayne. Pure and simple.""*)

### Węzeł `[279]`
Mówca: **Ewald Alphonso**
> ""You're a snake, Rayne. Pure and simple.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[280]`
Mówca: **Ewald Alphonso**
> ""But I hope you see now how much damage you've done to our country's energy industry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Ewald Alphonso: ""I can't believe you would attempt to follow in Soll's fo..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Default == true"*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It was never my intention to bankrupt Gasom. I made my decisions with the company's interests at heart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Ewald Alphonso: ""Excuse me, but that's bullshit and you know it.""*)

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I was forced to revert the EPA to 10 percent foreign ownership. The USP made me do it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Tarquin Soll: ""Blaming the USP for your own mistakes. That's an Ewald A..."*)

### Węzeł `[286]`
Mówca: **Tarquin Soll**
> ""Blaming the USP for your own mistakes. That's an Ewald Alphonso move if I ever heard of one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Ewald Alphonso: ""Leave me out of this. I've only ever tried to do what's ..."*)

### Węzeł `[287]`
Mówca: **Tarquin Soll**
> ""My footsteps? If it were up to me, Gasom would have been nationalized long ago to prevent exactly this from happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Ewald Alphonso: ""All you had to do was leave your investment and the EPA ..."*)

### Węzeł `[288]`
Mówca: **Ewald Alphonso**
> ""Excuse me, but that's bullshit and you know it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Ewald Alphonso: ""All you had to do was leave your investment and the EPA ..."*)

### Węzeł `[289]`
Mówca: **Ewald Alphonso**
> ""Leave me out of this. I've only ever tried to do what's right for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Narrator: "The three of us glared at each other."*)

### Węzeł `[290]`
Mówca: **Ewald Alphonso**
> ""All you had to do was leave your investment and the EPA untouched, Mr. Rayne. But that somehow proved too difficult for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Narrator: "The three of us glared at each other."*)

### Węzeł `[291]`
Mówca: **Narrator**
> "The three of us glared at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It was never my intention to bankrupt Gasom. I made my decisions with the company's interests at heart.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Kontekst wejściowy (poprzednik):** `[279]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Ewald Alphonso: ""Excuse me, but that is bullshit and you know it.""*)

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I was forced to revert the EPA to 10 percent foreign ownership. The USP made me do it.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Kontekst wejściowy (poprzednik):** `[279]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Ewald Alphonso: ""Do not blame your own shortcomings on your party, Mr. Pr..."*)

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sorry, Mr. Alphonso. But you got through it all unscathed, didn't you?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Kontekst wejściowy (poprzednik):** `[279]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Ewald Alphonso: ""Of course I did. But Gasom is as much a part of my legac..."*)

### Węzeł `[295]`
Mówca: **Ewald Alphonso**
> ""Of course I did. But Gasom is as much a part of my legacy as my presidency. And now it's been tainted forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Narrator: "We glared at each other."*)

### Węzeł `[296]`
Mówca: **Ewald Alphonso**
> ""Do not blame your own shortcomings on your party, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Narrator: "We glared at each other."*)

### Węzeł `[297]`
Mówca: **Ewald Alphonso**
> ""Excuse me, but that is bullshit and you know it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Narrator: "We glared at each other."*)

### Węzeł `[298]`
Mówca: **Narrator**
> "We glared at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Default == true"*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Gasom_Default == true)"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Gasom_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Tarquin Soll: ""What are you talking about, Alphonso? I've read the repo..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Gasom_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Gasom_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Tarquin Soll: ""You cannot lay your own failures at the feet of the stat..."*)

### Węzeł `[302]`
Mówca: **Tarquin Soll**
> ""What are you talking about, Alphonso? I've read the reports. Your Gasom is doing fine without foreign investment propping it up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Ewald Alphonso: ""We are barely turning a profit. All it would take is a b..."*)

### Węzeł `[303]`
Mówca: **Ewald Alphonso**
> ""We are barely turning a profit. All it would take is a bad few months for it all to come crashing down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Tarquin Soll: ""Then that is your fault. Not the Sordish state's.""*)

### Węzeł `[304]`
Mówca: **Tarquin Soll**
> ""You cannot lay your own failures at the feet of the state, Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Tarquin Soll: ""Admit it. A man with your profit-focused mentality shoul..."*)

### Węzeł `[305]`
Mówca: **Tarquin Soll**
> ""Admit it. A man with your profit-focused mentality should have never been given the keys to such a vital sector, let alone the presidency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "Ewald's upper lip curled."*)

### Węzeł `[306]`
Mówca: **Tarquin Soll**
> ""Then that is your fault. Not the Sordish state's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "Ewald's upper lip curled."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true || ..."*)
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true |..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true  or  Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Ewald Alphonso: ""I was in Rizia a few days ago to meet with our energy pa..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true  or  Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "Just then, FC Anrica's star midfiel...."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "Just then, FC Anrica's star midfiel..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: ""This is my fault as much as it is yours. I never should ..."*)
