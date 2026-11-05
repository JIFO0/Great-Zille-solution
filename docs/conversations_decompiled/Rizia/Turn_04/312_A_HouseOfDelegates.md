# Rizia/Turn 4/A_HouseOfDelegates

- **ID konwersacji:** `312`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Rizia/Turn_04/312_A_HouseOfDelegates.md`
- **Liczba węzłów dialogowych:** 551
- **Liczba wyborów gracza:** 87

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[89]** Russello Montoro
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Diplomacy_Pales_GasField_Cede`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Diplomacy_Wehlen_Scapegoats`
- `RiziaDLC.Economy_PromiseNoMiningRegs`
- `RiziaDLC.Enable_Policy_RD_Economy_QalusGoldMineProject`
- `RiziaDLC.Focus_Economy_Diversification`
- `RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed`
- `RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project`
- `RiziaDLC.Policy_RD_Welfare_FreePress`
- `RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized`
- `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining`
- `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries`
- `RiziaDLC.Relations_Manus_ConstitutionalMonarchy`
- `RiziaDLC.Relations_Manus_OverthrowMonarchy`
- `RiziaDLC.Relations_Manus_WorkWithRPP`
- `RiziaDLC.Relations_Vina_DancedWithManus`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo`
- `RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus`
- `RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Budget_Modifier_WorkRegulationCost`
- `RiziaDLC.Country_ProductionCapacity`
- `RiziaDLC.Country_PublicOpinion`
- `RiziaDLC.Diplomacy_Morella_NegotiatingPower`
- `RiziaDLC.Enable_Policy_RD_Welfare_WorkersRights`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.LeaningValue_ProBusiness`
- `RiziaDLC.PersonalValue_FunnyKing`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining`
- `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Rusty_TookMedallion`
- `RiziaDLC.Turn04_EnableRRGStakeChange`
- `RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo`
- `RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus`
- `RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty`
- `RiziaDLCSupport.Journal_Turn04_HouseOfDelegates_NoNewRegulations`
- `RiziaDLCSupport.Journal_Turn04_HouseOfDelegates_RegulationsMiningExemption`
- `RiziaDLCSupport.News_Turn04_RH_SafetyLaws`
- `RiziaDLCSupport.News_Turn04_V_SafetyLawsHalfPassed`
- `RiziaDLCSupport.News_Turn04_V_SafetyLawsNotPassed`
- `RiziaDLCSupport.Reports_Turn04_Argno_MiningPause`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[11]` | **""How are you, Hugo?""** | `[10]` **Hugo Toras**: ""Welcome, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Hugo Toras**: ""Busy as usual, Your Majesty."" |
| `[12]` | **""Good morning, Your Grace.""** | `[10]` **Hugo Toras**: ""Welcome, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Hugo Toras**: ""The delegates will be on their ..." |
| `[16]` | **""You said she's a loyalist.""** | `[65]` **Narrator**: "She had a brisk gait and impecca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Hugo Toras**: ""Quite right."" |
| `[17]` | **""Which house does she belong to again?""** | `[65]` **Narrator**: "She had a brisk gait and impecca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Hugo Toras**: ""The de Ravas aren't related to ..." |
| `[20]` | **""Remind me, how did she land this job?""** | `[65]` **Narrator**: "She had a brisk gait and impecca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Hugo Toras**: ""She performed superbly as the h..." |
| `[25]` | **"Wave back to him."** | `[24]` **Narrator**: "Next came Manus Sazon, clad in a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Narrator**: "Daria picked up a golden bell an..." |
| `[26]` | **"Don't wave."** | `[24]` **Narrator**: "Next came Manus Sazon, clad in a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Narrator**: "Daria picked up a golden bell an..." |
| `[39]` | **""It is an honor to be here, Madam Speaker.""** | `[30]` **Narrator**: "A few cries of "Long may he reig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Narrator**: "She smiled and continued." |
| `[40]` | **""Say that louder.""** | `[30]` **Narrator**: "A few cries of "Long may he reig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "The hall reverberated with full-..." |
| `[41]` | **""I am here to serve you, esteemed delegates. I look forward to your recommendations.""** | `[30]` **Narrator**: "A few cries of "Long may he reig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Narrator**: "She smiled and continued." |
| `[42]` | **"Don't say anything."** | `[30]` **Narrator**: "A few cries of "Long may he reig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Daria de Rava**: ""The Rizian People's Party has p..." |
| `[46]` | **""So Rusty was right. The RPP took up the workers' cause.""** | `[38]` **Narrator**: "I looked at Hugo." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Hugo Toras**: ""Mr. Montoro will be expecting y..."<br>`[73]` **Hugo Toras**: ""You're under no obligation to M..." |
| `[47]` | **""How does he expect us to pay for all this?""** | `[38]` **Narrator**: "I looked at Hugo." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Hugo Toras**: ""This is why I never brought the..." |
| `[48]` | **""It's hard to believe we had none of these measures in place before now.""** | `[38]` **Narrator**: "I looked at Hugo." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Hugo Toras**: ""And yet our industries flourish..." |
| `[54]` | **""Please go on. I didn't mean to interrupt.""** | `[53]` **Manus Sazon**: ""Shall I continue?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Narrator**: "Manus cleared his throat." |
| `[55]` | **""I've heard enough from the RPP. I'd like to know what Ms. de Rava thinks about th..."** | `[53]` **Manus Sazon**: ""Shall I continue?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Narrator**: "Manus stepped back from his podi..." |
| `[74]` | **""Mr. Sazon, I would like to know how Rizia is to pay for these policies.""** | `[53]` **Manus Sazon**: ""Shall I continue?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Narrator**: "He smiled patiently." |
| `[121]` | **""I want him out. Immediately.""** | `[120]` **Narrator**: "I turned towards Hugo again." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Narrator**: "Hugo stared in Rusty's direction." |
| `[122]` | **""You didn't tell me that a special guest would be joining us.""** | `[120]` **Narrator**: "I turned towards Hugo again." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Narrator**: "Hugo stared in Rusty's direction." |
| `[123]` | **""Look, your favorite person's here.""** | `[120]` **Narrator**: "I turned towards Hugo again." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...` | `[124]` **Narrator**: "Hugo stared in Rusty's direction." |
| `[138]` | **""I side with the delegate majority. The workplace safety proposal from the Rizian ..."** | `[326]` **Narrator**: "Everyone in the room went silent..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn04_HouseOfDelegates...` | `[141]` **Russello Montoro**: ""Damn straight, Your Majesty!"" |
| `[139]` | **""I overrule the recommendation. The safety measures suggested by the RPP will be i..."** | `[326]` **Narrator**: "Everyone in the room went silent..." | `Variable["RiziaDLC.Resources_Budget"] >= 3` | `EnactDecree("Welfare_Citizenship_WorkersRightsAllIndustri...` | `[155]` **Russello Montoro**: ""Son of a she-dog!""<br>`[158]` **Narrator**: "Rusty glared at me, but said not..." |
| `[140]` | **""After listening to compelling arguments from both Mr. Sazon and Mr. Montoro, I he..."** | `[326]` **Narrator**: "Everyone in the room went silent..." | `Variable["RiziaDLC.Resources_Budget"] >= 2` | `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExce...` | `[161]` **Russello Montoro**: ""All hail the king!"" |
| `[164]` | **""What can we expect today?""** | `[10]` **Hugo Toras**: ""Welcome, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Hugo Toras**: ""The usual."" |
| `[172]` | **""Good that I'm here. It's about time someone listened to that kid.""** | `[166]` **Hugo Toras**: ""The Sazon boy will try to pass ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Hugo Toras**: ""Someone besides your daughter, ..."<br>`[424]` **Hugo Toras**: ""He seemed to have caught your a..." |
| `[173]` | **""Sounds like a waste of time.""** | `[166]` **Hugo Toras**: ""The Sazon boy will try to pass ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Hugo Toras**: ""There's a reason the King doesn..." |
| `[176]` | **""Impractical? I'll be the judge of that.""** | `[166]` **Hugo Toras**: ""The Sazon boy will try to pass ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Hugo Toras**: ""I assure you that you'll agree ..." |
| `[179]` | **""Joke all you want, but it's about time someone listened to that kid.""** | `[178]` **Hugo Toras**: ""The Sazon boy might even keep h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Hugo Toras**: ""Someone besides your daughter, ..."<br>`[424]` **Hugo Toras**: ""He seemed to have caught your a..." |
| `[180]` | **""Based on what I saw in Sallabes, I doubt it.""** | `[178]` **Hugo Toras**: ""The Sazon boy might even keep h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Hugo Toras**: ""His speech there seemed to have..."<br>`[433]` **Hugo Toras**: ""They're a fool for rhetoric ove..." |
| `[181]` | **""You're not jealous of the attention he gets, are you?""** | `[178]` **Hugo Toras**: ""The Sazon boy might even keep h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Hugo Toras**: ""Ha. Far from it. Although I am ..."<br>`[174]` **Hugo Toras**: ""No. And you shouldn't be, either."" |
| `[185]` | **""It's not a standoff. Just insurance in case things go south at the AN.""** | `[168]` **Hugo Toras**: ""The Pales naval standoff has me..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Hugo Toras**: ""I trust Duchess Azaro is capabl..." |
| `[186]` | **""Trust me, I'll be glad when it's over.""** | `[168]` **Hugo Toras**: ""The Pales naval standoff has me..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Hugo Toras**: ""Will your war councilor, I wond..." |
| `[187]` | **""Relax. Lucita has everything under control.""** | `[168]` **Hugo Toras**: ""The Pales naval standoff has me..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Narrator**: "Hugo frowned pensively." |
| `[195]` | **""Me, too. I hope your son's gambit worked.""** | `[167]` **Hugo Toras**: ""The silence from Wehlen has me ..." | `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"]` | *Brak zmian stanu* | `[13]` **Narrator**: "The clock struck ten and the del..." |
| `[196]` | **""President Smolak will be at the next AN session. We can corner him there if we ne..."** | `[167]` **Hugo Toras**: ""The silence from Wehlen has me ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Narrator**: "The clock struck ten and the del..." |
| `[197]` | **""Nothing we can do about it now. Let's focus on today's meeting.""** | `[167]` **Hugo Toras**: ""The silence from Wehlen has me ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Narrator**: "The clock struck ten and the del..." |
| `[198]` | **""I hope the investigators haven't found anything damning.""** | `[167]` **Hugo Toras**: ""The silence from Wehlen has me ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Narrator**: "The clock struck ten and the del..." |
| `[214]` | **""Sorry, Rusty. I couldn't make it look like I was playing favorites.""** | `[210]` **Narrator**: "As the guards escorted me and Hu..." | `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true`<br>`Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true` | *Brak zmian stanu* | `[221]` **Russello Montoro**: ""Sure, Your Majesty. I hear you ..." |
| `[215]` | **""No hard feelings?""** | `[210]` **Narrator**: "As the guards escorted me and Hu..." | `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true`<br>`Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true` | *Brak zmian stanu* | `[222]` **Russello Montoro**: ""None, Your Majesty. We're all j..." |
| `[216]` | **""Well? I'm a man of my word, aren't I?""** | `[210]` **Narrator**: "As the guards escorted me and Hu..." | `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true`<br>`(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false` | *Brak zmian stanu* | `[218]` **Russello Montoro**: ""And I'm a man of mine, Your Maj..." |
| `[217]` | **""Don't make me regret listening to you.""** | `[210]` **Narrator**: "As the guards escorted me and Hu..." | `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true`<br>`(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false` | *Brak zmian stanu* | `[225]` **Russello Montoro**: ""Never, Your Majesty. In fact..."" |
| `[219]` | **""You never seriously thought I was going to give in to you, did you?""** | `[210]` **Narrator**: "As the guards escorted me and Hu..." | `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true`<br>`Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true` | *Brak zmian stanu* | `[220]` **Russello Montoro**: ""You're the king. It's your prer..." |
| `[223]` | **""No need to thank me. You and I wanted this equally.""** | `[465]` **Manus Sazon**: ""Your Majesty. Thank you so much..."<br>`[469]` **Manus Sazon**: ""Your Majesty. Thank you so much..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[521]` **Manus Sazon**: ""I hope that means you'll contin..." |
| `[232]` | **""There will be no bloviating in these chambers, *Rusty*.""** | `[231]` **Russello Montoro**: ""Now. The Rizian Standard Dictio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[236]` **Russello Montoro**: ""Fair enough, Your Majesty. Mr. ..." |
| `[233]` | **""Yes, we are all familiar with the substance in question.""** | `[231]` **Russello Montoro**: ""Now. The Rizian Standard Dictio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Russello Montoro**: ""But in Rizia, it's so much more..." |
| `[234]` | **"Let him talk."** | `[231]` **Russello Montoro**: ""Now. The Rizian Standard Dictio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Russello Montoro**: ""But in Rizia, it's so much more..." |
| `[251]` | **""Giving *some* of the workers what they want might divide them enough to head off ..."** | `[250]` **Manus Sazon**: ""Our proposal as it stands does ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Narrator**: "Daria frowned." |
| `[257]` | **""Your proposal was never going to be accepted in its entirety, Mr. Sazon. Compromi..."** | `[250]` **Manus Sazon**: ""Our proposal as it stands does ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[262]` **Manus Sazon**: ""My party will not compromise wh..." |
| `[258]` | **""I've witnessed Mr. Montoro's cavalier attitude towards employee safety. If any co..."** | `[250]` **Manus Sazon**: ""Our proposal as it stands does ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Russello Montoro**: ""Cavalier? Heck, Your Majesty, y..." |
| `[259]` | **""I don't agree with Mr. Montoro's arguments one bit. It doesn't make sense to regu..."** | `[250]` **Manus Sazon**: ""Our proposal as it stands does ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[263]` **Narrator**: "Daria nodded energetically." |
| `[270]` | **""Rusty, did you have any closing arguments?""** | `[300]` **Daria de Rava**: ""Will you accept or overrule the..."<br>`[318]` **Hugo Toras**: ""However, it would have a signif..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty"] == false` | *Brak zmian stanu* | `[327]` **Russello Montoro**: ""I surely do not, Your Majesty."" |
| `[271]` | **""I'd like to confer with my Grand Vizier.""** | `[300]` **Daria de Rava**: ""Will you accept or overrule the..."<br>`[318]` **Hugo Toras**: ""However, it would have a signif..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo"] == false` | *Brak zmian stanu* | `[282]` **Daria de Rava**: ""Of course."" |
| `[284]` | **""I told Manus I wanted to work closer with him. Would I be throwing away that chan..."** | `[283]` **Narrator**: "We turned away from the Delegate..." | `Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true` | *Brak zmian stanu* | `[306]` **Narrator**: "Hugo coughed." |
| `[288]` | **""I can't ignore the potential benefits of cooperating with RRG. Can I?""** | `[283]` **Narrator**: "We turned away from the Delegate..." | `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"]` | *Brak zmian stanu* | `[320]` **Hugo Toras**: ""Mr. Montoro did imply that stay..." |
| `[301]` | **""Would I lose face with the Delegates if I implemented a proposal they voted again..."** | `[283]` **Narrator**: "We turned away from the Delegate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[305]` **Hugo Toras**: ""It would be highly unusual, You..." |
| `[302]` | **""What do you think about Rusty's exception idea? Could I decide to exempt RRG from..."** | `[283]` **Narrator**: "We turned away from the Delegate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[309]` **Hugo Toras**: ""You're the king. Of course you ..." |
| `[314]` | **""Would I be making an enemy of Manus Sazon's party and his house if I shot down hi..."** | `[283]` **Narrator**: "We turned away from the Delegate..." | `(Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true) == false` | *Brak zmian stanu* | `[315]` **Narrator**: "Hugo coughed." |
| `[324]` | **""Have you said all that you wanted to say, Mr. Sazon?""** | `[300]` **Daria de Rava**: ""Will you accept or overrule the..."<br>`[318]` **Hugo Toras**: ""However, it would have a signif..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus"] == false` | *Brak zmian stanu* | `[273]` **Manus Sazon**: ""I've stated my case, Your Majes..." |
| `[325]` | **""Here's what I have decided.""** | `[300]` **Daria de Rava**: ""Will you accept or overrule the..."<br>`[318]` **Hugo Toras**: ""However, it would have a signif..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[326]` **Narrator**: "Everyone in the room went silent..." |
| `[337]` | **""What is it?""** | `[336]` **Russello Montoro**: ""My guys dug this up in the MITZ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[341]` **Russello Montoro**: ""Heck if I know. Looks pretty ol..." |
| `[338]` | **""Thank you, Rusty. I'll treasure it.""** | `[336]` **Russello Montoro**: ""My guys dug this up in the MITZ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[340]` **Russello Montoro**: ""Thought you'd like it, Your Maj..." |
| `[339]` | **""You've gotten what you wanted. No need for bribery.""** | `[336]` **Russello Montoro**: ""My guys dug this up in the MITZ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[342]` **Russello Montoro**: ""Who do you think I am? This is ..." |
| `[382]` | **""Is there something you'd like to say to me?""** | `[210]` **Narrator**: "As the guards escorted me and Hu..." | `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false` | *Brak zmian stanu* | `[395]` **Russello Montoro**: ""I just wanted to express my gra..." |
| `[383]` | **""You're welcome.""** | `[210]` **Narrator**: "As the guards escorted me and Hu..." | `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false` | *Brak zmian stanu* | `[394]` **Russello Montoro**: ""Your act of benevolence will no..." |
| `[384]` | **"Ignore him."** | `[210]` **Narrator**: "As the guards escorted me and Hu..." | `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false` | *Brak zmian stanu* | `[385]` **Russello Montoro**: ""One moment of your time, Your M..." |
| `[386]` | **""You've been hoarding this? It belongs to the Crown.""** | `[336]` **Russello Montoro**: ""My guys dug this up in the MITZ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[387]` **Russello Montoro**: ""Finders keepers, I always thoug..." |
| `[388]` | **"Ignore him."** | `[210]` **Narrator**: "As the guards escorted me and Hu..." | `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true` | *Brak zmian stanu* | `[389]` **Narrator**: "He eyed me coolly as Hugo and I ..." |
| `[391]` | **"Shake his hand."** | `[390]` **Narrator**: "He extended his hand for a hands..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[393]` **Narrator**: "I withdrew my hand and took a cl..." |
| `[392]` | **"Leave without acknowledging him."** | `[390]` **Narrator**: "He extended his hand for a hands..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Russello Montoro");`<br>`Variable["RiziaDLCSupport.Reports_Turn04_Argno_MiningPaus...`<br>*(+1 skryptów)* | `[505]` **Narrator**: "Hugo shook his head with disdain."<br>`[515]` **Hugo Toras**: ""I'm still curious how he found ..." |
| `[401]` | **""Thank you, but no. The Kingdom's share in RRG will stay the same.""** | `[400]` **Russello Montoro**: ""If you'll recall, I also mentio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[405]` **Russello Montoro**: ""No problem. Just thought I'd ask."" |
| `[402]` | **""Perhaps. I'd have to know more details first.""** | `[400]` **Russello Montoro**: ""If you'll recall, I also mentio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[404]` **Russello Montoro**: ""Your wish is my command. I'll h..." |
| `[403]` | **""I've given some thought to it and, yes, I would like to alter Rizia's share.""** | `[400]` **Russello Montoro**: ""If you'll recall, I also mentio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[404]` **Russello Montoro**: ""Your wish is my command. I'll h..." |
| `[408]` | **""What do you want?""** | `[210]` **Narrator**: "As the guards escorted me and Hu..." | `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false`<br>`Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true` | *Brak zmian stanu* | `[410]` **Russello Montoro**: ""Nothing, Your Majesty."" |
| `[409]` | **""For what it's worth, you made a good case.""** | `[210]` **Narrator**: "As the guards escorted me and Hu..." | `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false`<br>`Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true` | *Brak zmian stanu* | `[412]` **Russello Montoro**: ""Much obliged, Your Majesty. No ..." |
| `[419]` | **""While I sympathize with the RPP, our treasury is too strained for this proposal. ..."** | `[326]` **Narrator**: "Everyone in the room went silent..." | `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false` | `Variable["RiziaDLCSupport.Journal_Turn04_HouseOfDelegates...` | `[500]` **Russello Montoro**: ""Good enough for me, Your Majesty!"" |
| `[461]` | **"Shake his hand."** | `[516]` **Narrator**: "As we stepped outside the House ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[465]` **Manus Sazon**: ""Your Majesty. Thank you so much..."<br>`[469]` **Manus Sazon**: ""Your Majesty. Thank you so much..."<br>*(oraz 1 innych odgałęzień)* |
| `[474]` | **""Is this going to be a problem?""** | `[120]` **Narrator**: "I turned towards Hugo again." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[476]` **Hugo Toras**: ""I can't say I'm happy to see Mr..." |
| `[481]` | **""You're exaggerating.""** | `[483]` **Russello Montoro**: ""Your Majesty, esteemed Delegate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[488]` **Russello Montoro**: ""Hey, if you want to test my the..." |
| `[482]` | **""What about the miners who have been speaking out? We cannot ignore their complain..."** | `[483]` **Russello Montoro**: ""Your Majesty, esteemed Delegate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[487]` **Russello Montoro**: ""RRG takes care of our own, Your..." |
| `[484]` | **""You could easily afford such measures if you forewent a portion of your own salary.""** | `[483]` **Russello Montoro**: ""Your Majesty, esteemed Delegate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[485]` **Narrator**: "Rusty chuckled to himself." |
| `[489]` | **""That does seem much more complicated than Mr. Sazon made it out to be.""** | `[483]` **Russello Montoro**: ""Your Majesty, esteemed Delegate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[490]` **Russello Montoro**: ""Yes, well, he's a noble. Sooner..." |
| `[517]` | **""I'm happy to have gotten a look into the inner workings of the House of Delegates..."** | `[465]` **Manus Sazon**: ""Your Majesty. Thank you so much..."<br>`[469]` **Manus Sazon**: ""Your Majesty. Thank you so much..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[522]` **Manus Sazon**: ""You're welcome to attend as oft..." |
| `[518]` | **""My foremost concern is for the Rizian economy. I hope you understand.""** | `[469]` **Manus Sazon**: ""Your Majesty. Thank you so much..."<br>`[470]` **Manus Sazon**: ""Your Majesty. I cannot thank yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[525]` **Manus Sazon**: ""I understand completely. I'll m..." |
| `[519]` | **""You're most welcome. We shall have to meet soon to discuss the next steps.""** | `[465]` **Manus Sazon**: ""Your Majesty. Thank you so much..."<br>`[469]` **Manus Sazon**: ""Your Majesty. Thank you so much..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[523]` **Manus Sazon**: ""I'm looking forward to it."" |
| `[520]` | **""I hope you aren't too disappointed with the outcome.""** | `[470]` **Manus Sazon**: ""Your Majesty. I cannot thank yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[524]` **Manus Sazon**: ""Not at all. I see the merit in ..." |
| `[545]` | **""What do you want?""** | `[516]` **Narrator**: "As we stepped outside the House ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[465]` **Manus Sazon**: ""Your Majesty. Thank you so much..."<br>`[469]` **Manus Sazon**: ""Your Majesty. Thank you so much..."<br>*(oraz 1 innych odgałęzień)* |
| `[546]` | **""Ah. Just the man I wanted to see.""** | `[516]` **Narrator**: "As we stepped outside the House ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[465]` **Manus Sazon**: ""Your Majesty. Thank you so much..."<br>`[469]` **Manus Sazon**: ""Your Majesty. Thank you so much..."<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Listening to a proposal from the Rizian ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I walked down the palm-tree-lined path that connected Palas Rezna to the nearby House of Delegates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "In contrast to the ornate palace, the House was essential..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "In contrast to the ornate palace, the House was essentially a plain concrete box. Its stripped-down appearance reflected its hurried construction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "The only adornment was a phrase chiseled above the entran..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "The only adornment was a phrase chiseled above the entrance: "Ax Populat Rizati.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: ""To the Rizian People.""*)

### Węzeł `[6]`
Mówca: **Narrator**
> ""To the Rizian People.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I made my way down the hall to the meeting room."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "I made my way down the hall to the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "AddConversant("Hugo Toras");"*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Hugo rose to greet me as I entered the empty chamber. We took our seats atop the raised wooden platform in the center of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Directly below the platform were two podiums, one for eac..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Directly below the platform were two podiums, one for each speaker. Wooden benches for the delegates were arranged in a circle around us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Hugo Toras: ""Welcome, Your Majesty.""*)

### Węzeł `[10]`
Mówca: **Hugo Toras**
> ""Welcome, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player_Romus: ""Good morning, Your Grace.""*)
  - -> `[164]` (*Player_Romus: ""What can we expect today?""*)
  - -> `[11]` (*Player_Romus: ""How are you, Hugo?""*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are you, Hugo?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Hugo Toras: ""Busy as usual, Your Majesty.""*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good morning, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Hugo Toras: ""The delegates will be on their best behavior with you he..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "The clock struck ten and the delegates filed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Each wore a satin sash in the traditional color of his or..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "Each wore a satin sash in the traditional color of his or her province: red for Rizia Imperii, blue for Valenqiris, yellow for Cardesse-Montaklar and green for Brenas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "Next came the speakers. House Leader Daria de Rava walked..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "Next came the speakers. House Leader Daria de Rava walked out in a well-tailored crimson suit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "AddConversant("Daria de Rava");"*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You said she's a loyalist.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Hugo Toras: ""Quite right.""*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Which house does she belong to again?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Hugo Toras: ""The de Ravas aren't related to any of the royal houses. ..."*)

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""Quite right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Hugo Toras: ""In all of the sessions I've attended, she has never made..."*)

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""The de Ravas aren't related to any of the royal houses. They were granted their nobility status through service to our family after the War of Succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Hugo Toras: ""Technically, she's a Baroness. But she prefers the title..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remind me, how did she land this job?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Hugo Toras: ""She performed superbly as the head of the provincial cou..."*)

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""Technically, she's a Baroness. But she prefers the title of Madam Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "I noted the approving tone in his voice as he spoke of her."*)

### Węzeł `[22]`
Mówca: **Hugo Toras**
> ""She performed superbly as the head of the provincial council in Rizia Imperii.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""It's now her third term as speaker. I do not believe she..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "I noted the approving tone in his voice as he spoke of her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "AddConversant("Manus Sazon");"*)

### Węzeł `[24]`
Mówca: **Narrator**
> "Next came Manus Sazon, clad in a black suit with a forest-green silk tie. He waved to his fellow delegates, then to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus_Italic: "Wave back to him."*)
  - -> `[26]` (*Player_Romus_Italic: "Don't wave."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "Wave back to him."]** — Mówca: **Player_Romus_Italic**
> "I returned his wave. He smiled as he took his place."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Daria picked up a golden bell and rang it once."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "Don't wave."]** — Mówca: **Player_Romus_Italic**
> "I didn't move as he took his place."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Daria picked up a golden bell and rang it once."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "Daria picked up a golden bell and rang it once."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Daria de Rava: ""Ladies and gentlemen, it is my privilege to call this me..."*)

### Węzeł `[28]`
Mówca: **Daria de Rava**
> ""Ladies and gentlemen, it is my privilege to call this meeting of the House of Delegates to order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Daria de Rava: ""Today we are humbled by the presence of His Majesty King..."*)

### Węzeł `[29]`
Mówca: **Daria de Rava**
> ""Today we are humbled by the presence of His Majesty King Romus, long may he reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "A few cries of "Long may he reign!" echoed among the dele..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "A few cries of "Long may he reign!" echoed among the delegates, particularly those in red and blue sashes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player_Romus: ""It is an honor to be here, Madam Speaker.""*)
  - -> `[40]` (*Player_Romus: ""Say that louder.""*)
  - -> `[41]` (*Player_Romus: ""I am here to serve you, esteemed delegates. I look forwa..."*)
  - -> `[42]` (*Player_Romus_Italic: "Don't say anything."*)

### Węzeł `[31]`
Mówca: **Daria de Rava**
> ""The Rizian People's Party has prepared a proposal that Mr. Sazon will submit before the Delegates and His Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Daria de Rava: ""The Delegates will vote on whether to accept or reject i..."*)

### Węzeł `[32]`
Mówca: **Daria de Rava**
> ""Mr. Sazon, would you like to explain more?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Manus Sazon: ""Gladly, Madam Speaker.""*)

### Węzeł `[33]`
Mówca: **Manus Sazon**
> ""Gladly, Madam Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Manus Sazon: ""The past two decades have seen a marked increase in work..."*)

### Węzeł `[34]`
Mówca: **Manus Sazon**
> ""The past two decades have seen a marked increase in workplace accidents, particularly in the sectors of mining and manufacturing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Manus Sazon: ""The experts I've consulted with have pinpointed several ..."*)

### Węzeł `[35]`
Mówca: **Manus Sazon**
> ""Now a cross-industry coalition of employees has bravely approached the Rizian People's Party with a list of requests to convey to our fellow delegates as well as His Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Manus Sazon: ""Among these are standardized workplace safety protocols,..."*)

### Węzeł `[36]`
Mówca: **Manus Sazon**
> ""Among these are standardized workplace safety protocols, upgraded protective equipment, benefits for those injured on the job, and regular site inspections by state authorities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Manus Sazon: ""And of course, financial penalties for corporations that..."*)

### Węzeł `[37]`
Mówca: **Manus Sazon**
> ""Madam Speaker, Your Majesty, surely you agree on the urgency of this proposition. Rizia's great industries will not flourish as long as our workers are suffering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "I looked at Hugo."*)

### Węzeł `[38]`
Mówca: **Narrator**
> "I looked at Hugo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Romus: ""So Rusty was right. The RPP took up the workers' cause.""*)
  - -> `[47]` (*Player_Romus: ""How does he expect us to pay for all this?""*)
  - -> `[48]` (*Player_Romus: ""It's hard to believe we had none of these measures in pl..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is an honor to be here, Madam Speaker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "She smiled and continued."*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Say that louder.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "The hall reverberated with full-throated cries of "LONG M..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am here to serve you, esteemed delegates. I look forward to your recommendations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "She smiled and continued."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Romus_Italic**
> "I let her continue."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Daria de Rava: ""The Rizian People's Party has prepared a proposal that M..."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "The hall reverberated with full-throated cries of "LONG MAY HE REIGN!" Daria smiled and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Tyrant += 1"*)

### Węzeł `[44]`
Mówca: **Narrator**
> "She smiled and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Daria de Rava: ""The Rizian People's Party has prepared a proposal that M..."*)

### Węzeł `[45]`
Mówca: **Daria de Rava**
> ""The Delegates will vote on whether to accept or reject it, but this is a non-binding recommendation. The ultimate authority rests with the King and the Royal Council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "She flipped open a binder."*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So Rusty was right. The RPP took up the workers' cause.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs == true"*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How does he expect us to pay for all this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Hugo Toras: ""This is why I never brought these meetings to your atten..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's hard to believe we had none of these measures in place before now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Hugo Toras: ""And yet our industries flourished nonetheless.""*)

### Węzeł `[49]`
Mówca: **Hugo Toras**
> ""Mr. Montoro will be expecting you to make good on your assurance to him. But of course, you're under no obligation to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "I suddenly realized the hall had gone quiet."*)

### Węzeł `[50]`
Mówca: **Hugo Toras**
> ""This is why I never brought these meetings to your attention before. The proposals are impractical at best and ruinous at worst.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "I suddenly realized the hall had gone quiet."*)

### Węzeł `[51]`
Mówca: **Hugo Toras**
> ""And yet our industries flourished nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "I suddenly realized the hall had gone quiet."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "I suddenly realized the hall had gone quiet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Manus Sazon: ""Shall I continue?""*)

### Węzeł `[53]`
Mówca: **Manus Sazon**
> ""Shall I continue?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player_Romus: ""Please go on. I didn't mean to interrupt.""*)
  - -> `[55]` (*Player_Romus: ""I've heard enough from the RPP. I'd like to know what Ms..."*)
  - -> `[74]` (*Player_Romus: ""Mr. Sazon, I would like to know how Rizia is to pay for ..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please go on. I didn't mean to interrupt.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "Manus cleared his throat."*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've heard enough from the RPP. I'd like to know what Ms. de Rava thinks about the Workers' Protection Act.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Manus stepped back from his podium, trying to conceal his..."*)

### Węzeł `[56]`
Mówca: **Daria de Rava**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Daria de Rava: ""Of course my party believes that worker safety is paramo..."*)

### Węzeł `[57]`
Mówca: **Daria de Rava**
> ""Of course my party believes that worker safety is paramount. But the regulations that have been suggested today amount to overkill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Daria de Rava: ""The business owners in my circles, most of whose compani..."*)

### Węzeł `[58]`
Mówca: **Daria de Rava**
> ""Furthermore, they already see employee safety as their responsibility. Shifting that responsibility to the government will do nothing to protect those at risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Daria de Rava: ""It will, however, stifle our economic growth and decreas..."*)

### Węzeł `[59]`
Mówca: **Daria de Rava**
> ""It will, however, stifle our economic growth and decrease our viability in the global arena.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Daria de Rava: ""If our businesses are to remain competitive, it is wiser..."*)

### Węzeł `[60]`
Mówca: **Daria de Rava**
> ""My point stands. With tensions rising in both our north and south, we simply cannot afford an extravagance of the type Mr. Sazon is proposing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Daria de Rava: ""Our focus should be on achieving better diplomatic outco..."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "From near the front door came the sound of a single person applauding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "I looked towards the source. Rusty was standing in the ba..."*)

### Węzeł `[62]`
Mówca: **Daria de Rava**
> ""My point stands. Rizia's gold and gas income is far from guaranteed at this moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Daria de Rava: ""Our focus should be on bolstering our businesses, not me..."*)

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""Busy as usual, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""The delegates will be on their best behavior with you here today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Hugo Toras: ""The Sazon boy might even keep his speeches to under a ha..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "She had a brisk gait and impeccable posture. The other delegates practically held their breath as they waited for her to take her place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player_Romus: ""You said she's a loyalist.""*)
  - -> `[17]` (*Player_Romus: ""Which house does she belong to again?""*)
  - -> `[20]` (*Player_Romus: ""Remind me, how did she land this job?""*)

### Węzeł `[66]`
Mówca: **Hugo Toras**
> ""In all of the sessions I've attended, she has never made a decision that didn't align with the interests of the noble houses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "I noted the approving tone in his voice as he spoke of her."*)

### Węzeł `[67]`
Mówca: **Hugo Toras**
> ""It's now her third term as speaker. I do not believe she intends to vacate the position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "I noted the approving tone in his voice as he spoke of her."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "She flipped open a binder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Daria de Rava: ""Today's session is regarding the Rizian Workers' Protect..."*)

### Węzeł `[69]`
Mówca: **Daria de Rava**
> ""Today's session is regarding the Rizian Workers' Protection Act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Daria de Rava: ""Mr. Sazon, would you like to explain more?""*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Economy_PromiseNoMiningRegs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Economy_PromiseNoMiningRegs == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Economy_PromiseNoMiningRegs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Hugo Toras: ""Mr. Montoro will be expecting you to make good on your a..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Economy_PromiseNoMiningRegs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Hugo Toras: ""You're under no obligation to Mr. Montoro. But I would c..."*)

### Węzeł `[73]`
Mówca: **Hugo Toras**
> ""You're under no obligation to Mr. Montoro. But I would consider the costs of this proposal before saying yes to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "I suddenly realized the hall had gone quiet."*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Sazon, I would like to know how Rizia is to pay for these policies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "He smiled patiently."*)

### Węzeł `[75]`
Mówca: **Narrator**
> "He smiled patiently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Manus Sazon: ""They would be paid for in equal measure by the governmen..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 1"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget > 1)"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[79]`
Mówca: **Manus Sazon**
> ""The Aureus gas field is expected to generate considerable revenue once Rizian drilling operations begin. I see no harm in running a slight deficit until then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Manus Sazon: ""After all, in the end, this is a small price to pay for ..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Manus Sazon: ""The Aureus gas field is expected to generate considerabl..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[83]`
Mówca: **Manus Sazon**
> ""After all, in the end, this is a small price to pay for improving thousands of lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Manus Sazon: ""Besides, a healthy worker is a productive worker. This s..."*)

### Węzeł `[84]`
Mówca: **Manus Sazon**
> ""Assuming the upcoming arbitrations go our way, the Aureus gas field is expected to generate considerable revenue for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Manus Sazon: ""And in the end, this is a small price to pay for improvi..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Manus Sazon: ""Assuming the upcoming arbitrations go our way, the Aureu..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Manus Sazon: ""What is that wealth for, if not to improve the lives of ..."*)

### Węzeł `[88]`
Mówca: **Manus Sazon**
> ""And in the end, this is a small price to pay for improving thousands of lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Manus Sazon: ""Besides, a healthy worker is a productive worker. This s..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "Manus cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false"*)

### Węzeł `[90]`
Mówca: **Manus Sazon**
> ""As a wise man once said, 'A society is only truly prosperous if every one of its members is able to share in its wealth.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Manus Sazon: ""What we invest in these measures now will pay off tenfol..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == false)"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Manus Sazon: ""As a wise man once said, 'A society is only truly prospe..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Manus Sazon: ""As I was saying, my party and I believe that healthier w..."*)

### Węzeł `[94]`
Mówca: **Manus Sazon**
> ""As I was saying, my party and I believe that healthier workers will lead to a more prosperous society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Manus Sazon: ""What we invest in these measures now will pay off tenfol..."*)

### Węzeł `[95]`
Mówca: **Manus Sazon**
> ""What we invest in these measures now will pay off tenfold in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Daria sharply knocked on her podium. All eyes turned to her."*)

### Węzeł `[96]`
Mówca: **Manus Sazon**
> ""What we invest in these measures now will pay off tenfold in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Daria sharply knocked on her podium. All eyes turned to her."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "Manus stepped back from his podium, trying to conceal his disappointment. Daria eagerly approached hers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Daria de Rava: ""Thank you, Your Majesty.""*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true ..."*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == tru..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Daria de Rava: ""My point stands. With tensions rising in both our north ..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Cede == true"*)

### Węzeł `[101]`
Mówca: **Daria de Rava**
> ""Our focus should be on achieving better diplomatic outcomes with our neighbors, not meddling in the affairs of our corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "From near the front door came the sound of a single perso..."*)

### Węzeł `[102]`
Mówca: **Manus Sazon**
> ""Madam Speaker, you are on the board of a construction company yourself. Would you ever advise that it voluntarily undertake the measures we're describing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "Daria brushed off the comment."*)

### Węzeł `[103]`
Mówca: **Narrator**
> "Daria brushed off the comment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true ..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Cede == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Cede == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Cede == true)"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Cede == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Daria de Rava: ""My point stands. Rizia's gold and gas income is far from..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Cede == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Daria de Rava: ""My point stands. We should not be spending our wealth fr..."*)

### Węzeł `[107]`
Mówca: **Daria de Rava**
> ""Our focus should be on bolstering our businesses, not meddling in the affairs of our corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "From near the front door came the sound of a single perso..."*)

### Węzeł `[108]`
Mówca: **Daria de Rava**
> ""My point stands. We should not be spending our wealth from the Aureus gas field acquisition before we have even earned it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Daria de Rava: ""Our focus should be on bolstering our businesses, not me..."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "Daria sharply knocked on her podium. All eyes turned to her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Daria de Rava: ""Forgive me, Your Majesty, but I cannot let my opponent c..."*)

### Węzeł `[110]`
Mówca: **Daria de Rava**
> ""Forgive me, Your Majesty, but I cannot let my opponent continue with these lies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Manus reluctantly took a step back."*)

### Węzeł `[111]`
Mówca: **Narrator**
> "Manus reluctantly took a step back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Daria de Rava: ""Of course my party believes that worker safety is paramo..."*)

### Węzeł `[112]`
Mówca: **Manus Sazon**
> ""Our country still has a budget surplus, Your Majesty. One that will only increase once drilling on the Aureus gas field begins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Manus Sazon: ""What is that wealth for, if not to improve the lives of ..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Manus Sazon: ""Our country still has a budget surplus, Your Majesty. On..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Manus Sazon: ""Our country still has a budget surplus, Your Majesty.""*)

### Węzeł `[116]`
Mówca: **Manus Sazon**
> ""Our country still has a budget surplus, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Manus Sazon: ""What is that wealth for, if not to improve the lives of ..."*)

### Węzeł `[117]`
Mówca: **Manus Sazon**
> ""What is that wealth for, if not to improve the lives of our citizens?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Manus Sazon: ""Besides, a healthy worker is a productive worker. This s..."*)

### Węzeł `[118]`
Mówca: **Manus Sazon**
> ""Besides, a healthy worker is a productive worker. This small investment will pay off tenfold in the long term. For us and for our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Daria sharply knocked on her podium. All eyes turned to her."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "I looked towards the source. Rusty was standing in the back of the gallery, dressed in his usual plaid. He nodded at me as he kept clapping."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "AddConversant("Russello Montoro");"*)

### Węzeł `[120]`
Mówca: **Narrator**
> "I turned towards Hugo again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player_Romus: ""I want him out. Immediately.""*)
  - -> `[122]` (*Player_Romus: ""You didn't tell me that a special guest would be joining..."*)
  - -> `[123]` (*Player_Romus: ""Look, your favorite person's here.""*)
  - -> `[474]` (*Player_Romus: ""Is this going to be a problem?""*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want him out. Immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "Hugo stared in Rusty's direction."*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You didn't tell me that a special guest would be joining us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "Hugo stared in Rusty's direction."*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look, your favorite person's here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1"*)

### Węzeł `[124]`
Mówca: **Narrator**
> "Hugo stared in Rusty's direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Hugo Toras: ""I should have known he'd make an appearance.""*)

### Węzeł `[125]`
Mówca: **Narrator**
> "Hugo stared in Rusty's direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Hugo Toras: ""I was not informed. In fact, I'm not certain how Mr. Mon..."*)

### Węzeł `[126]`
Mówca: **Hugo Toras**
> ""I was not informed. In fact, I'm not certain how Mr. Montoro knew this discussion would be taking place today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Hugo Toras: ""But I presume he is on the side of the RNC. The most he'..."*)

### Węzeł `[127]`
Mówca: **Narrator**
> "Hugo stared in Rusty's direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Hugo Toras: ""Unfortunately, these sessions are open to the public.""*)

### Węzeł `[128]`
Mówca: **Hugo Toras**
> ""Unfortunately, these sessions are open to the public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Hugo Toras: ""We cannot ask him to leave without reason.""*)

### Węzeł `[129]`
Mówca: **Hugo Toras**
> ""We cannot ask him to leave without reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Hugo Toras: ""But I presume he is on the side of the RNC. The most he'..."*)

### Węzeł `[130]`
Mówca: **Hugo Toras**
> ""I should have known he'd make an appearance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Hugo Toras: ""But I presume he is on the side of the RNC. The most he'..."*)

### Węzeł `[131]`
Mówca: **Hugo Toras**
> ""But I presume he is on the side of the RNC. The most he'll do is further expound on the impracticalities of Mr. Sazon's proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "Rusty had stopped clapping now. He was scrutinizing me cl..."*)

### Węzeł `[132]`
Mówca: **Narrator**
> "Rusty had stopped clapping now. He was scrutinizing me closely, a gleam in his eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Daria de Rava: ""How nice of you to join us, Mr. Montoro. Do you have any..."*)

### Węzeł `[133]`
Mówca: **Daria de Rava**
> ""How nice of you to join us, Mr. Montoro. Do you have any words on the topic at hand?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Russello Montoro: ""Call me Rusty, Madam Speaker. And as a matter of fact, I..."*)

### Węzeł `[134]`
Mówca: **Russello Montoro**
> ""Call me Rusty, Madam Speaker. And as a matter of fact, I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "Rusty ambled down the aisle of the chamber. He came to a ..."*)

### Węzeł `[135]`
Mówca: **Russello Montoro**
> ""Now, I won't take up too much of your time. The Baroness of Qaleo summed things up pretty well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Russello Montoro: ""But I wanted to offer my point of view as a humble busin..."*)

### Węzeł `[136]`
Mówca: **Russello Montoro**
> ""But I wanted to offer my point of view as a humble business owner of common birth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs == true"*)

### Węzeł `[137]`
Mówca: **Narrator**
> "Rusty ambled down the aisle of the chamber. He came to a stop between the two speaker podiums."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Russello Montoro: ""Now, I won't take up too much of your time. The Baroness..."*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I side with the delegate majority. The workplace safety proposal from the Rizian People's Party shall not be undertaken.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[326]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn04_HouseOfDelegates_NoNewRegu..."*)

### Węzeł `[139]`
**[WYBÓR GRACZA: ""I overrule the recommendation. The safety measures suggested by the RPP will be implemented in all industries with no exceptions." [-3 Budget, -3 Budget Per Turn]"]** — Mówca: **Player_Romus**
> ""I overrule the recommendation. The safety measures suggested by the RPP will be implemented in all industries with no exceptions.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Kontekst wejściowy (poprzednik):** `[326]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "EnactDecree("Welfare_Citizenship_WorkersRightsAllIndustri..."*)

### Węzeł `[140]`
**[WYBÓR GRACZA: ""After listening to compelling arguments from both Mr. Sazon and Mr. Montoro, I hereby order the implementation of the RPP's proposal, with the addendum that the mining industry will be exempt from the new regulations." [-2 Budget To Implement, -1 Budget Per Turn]"]** — Mówca: **Player_Romus**
> ""After listening to compelling arguments from both Mr. Sazon and Mr. Montoro, I hereby order the implementation of the RPP's proposal, with the addendum that the mining industry will be exempt from the new regulations.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[326]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining =..."*)

### Węzeł `[141]`
Mówca: **Russello Montoro**
> ""Damn straight, Your Majesty!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "My uncle gave Rusty a withering look."*)

### Węzeł `[142]`
Mówca: **Hugo Toras**
> ""Silence, Mr. Montoro. Do not make His Majesty regret his decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Hugo Toras: ""Madam Speaker, let the record show that the King has ali..."*)

### Węzeł `[143]`
Mówca: **Manus Sazon**
> ""The experts I've consulted with have pinpointed several factors responsible for the rise, chief among them a shortage of skilled labor and growing pressure from our trading partners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Manus Sazon: ""Simply put, our corporations have been cutting corners, ..."*)

### Węzeł `[144]`
Mówca: **Manus Sazon**
> ""Simply put, our corporations have been cutting corners, at the expense of human health and safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true"*)

### Węzeł `[145]`
Mówca: **Manus Sazon**
> ""His Majesty's decree to grant full working permissions to guest workers has helped with the labor shortage, but these employees have been promoted in a rush, making conditions yet more hazardous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Manus Sazon: ""Now a cross-industry coalition of employees has bravely ..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true"*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true)"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Manus Sazon: ""His Majesty's decree to grant full working permissions t..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Manus Sazon: ""Our industries' continued reliance on guest workers, who..."*)

### Węzeł `[149]`
Mówca: **Manus Sazon**
> ""And of course, financial penalties for corporations that fail to meet these requirements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Manus Sazon: ""Madam Speaker, Your Majesty, surely you agree on the urg..."*)

### Węzeł `[150]`
Mówca: **Daria de Rava**
> ""If our businesses are to remain competitive, it is wiser to incentivize good safety practices than to punish their absence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Manus Sazon: ""Madam Speaker, you are on the board of a construction co..."*)

### Węzeł `[151]`
Mówca: **Narrator**
> "My uncle gave Rusty a withering look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Hugo Toras: ""Silence, Mr. Montoro. Do not make His Majesty regret his..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Economy_PromiseNoMiningRegs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs == true"*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Economy_PromiseNoMiningRegs == true)"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Economy_PromiseNoMiningRegs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Russello Montoro: ""Son of a she-dog!""*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Economy_PromiseNoMiningRegs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "Rusty glared at me, but said nothing."*)

### Węzeł `[155]`
Mówca: **Russello Montoro**
> ""Son of a she-dog!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "My uncle gave Rusty a withering look. Manus stepped back ..."*)

### Węzeł `[156]`
Mówca: **Narrator**
> "My uncle gave Rusty a withering look. Manus stepped back from the podium, his expression hard to read."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Hugo Toras: ""His Majesty has made his decision. Do not question it.""*)

### Węzeł `[157]`
Mówca: **Hugo Toras**
> ""His Majesty has made his decision. Do not question it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Hugo Toras: ""Madam Speaker, let the record show that the King has ove..."*)

### Węzeł `[158]`
Mówca: **Narrator**
> "Rusty glared at me, but said nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Hugo Toras: ""Madam Speaker, let the record show that the King has ove..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnactDecree("Welfare_Citizenship_WorkersRightsAllIndustries");
RiziaDLC.Resources_Authority += 2;
RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries = true;`
- **Efekt skryptowy (`userScript`):** `EnactDecree("Welfare_Citizenship_WorkersRightsAllIndustries");
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 2;
Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs == true"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining = true;  
RiziaDLC.Resources_Budget -= 2;
RiziaDLC.Budget_Modifier_WorkRegulationCost = -1;
RiziaDLCSupport.Journal_Turn04_HouseOfDelegates_RegulationsMiningExemption = true;
RiziaDLC.Country_ProductionCapacity -= 1;
RiziaDLC.LeaningValue_Democratic += 1;
RiziaDLC.LeaningValue_ProBusiness -= 1;
RiziaDLC.Country_PublicOpinion += 4;
RiziaDLC.Diplomacy_Morella_NegotiatingPower -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] = true;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;
Variable["RiziaDLC.Budget_Modifier_WorkRegulationCost"] = -1;
Variable["RiziaDLCSupport.Journal_Turn04_HouseOfDelegates_RegulationsMiningExemption"] = true;
Variable["RiziaDLC.Country_ProductionCapacity"] = Variable["RiziaDLC.Country_ProductionCapacity"] - 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;
Variable["RiziaDLC.LeaningValue_ProBusiness"] = Variable["RiziaDLC.LeaningValue_ProBusiness"] - 1;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] + 4;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Russello Montoro: ""All hail the king!""*)

### Węzeł `[161]`
Mówca: **Russello Montoro**
> ""All hail the king!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "My uncle gave Rusty a withering look. Manus stepped back ..."*)

### Węzeł `[162]`
Mówca: **Hugo Toras**
> ""Silence, Mr. Montoro. Do not make His Majesty regret his decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Hugo Toras: ""Madam Speaker, let the record show that the King has ove..."*)

### Węzeł `[163]`
Mówca: **Narrator**
> "My uncle gave Rusty a withering look. Manus stepped back from the podium, his face hard to read."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Hugo Toras: ""Silence, Mr. Montoro. Do not make His Majesty regret his..."*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What can we expect today?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Hugo Toras: ""The usual.""*)

### Węzeł `[165]`
Mówca: **Hugo Toras**
> ""The usual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Hugo Toras: ""The Sazon boy will try to pass his latest impractical pr..."*)

### Węzeł `[166]`
Mówca: **Hugo Toras**
> ""The Sazon boy will try to pass his latest impractical proposition, and the delegates will sensibly shoot it down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player_Romus: ""Good that I'm here. It's about time someone listened to ..."*)
  - -> `[173]` (*Player_Romus: ""Sounds like a waste of time.""*)
  - -> `[176]` (*Player_Romus: ""Impractical? I'll be the judge of that.""*)

### Węzeł `[167]`
Mówca: **Hugo Toras**
> ""The silence from Wehlen has me rather on edge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Scapegoats"*)
  - -> `[198]` (*Player_Romus: ""I hope the investigators haven't found anything damning.""*)
  - -> `[196]` (*Player_Romus: ""President Smolak will be at the next AN session. We can ..."*)
  - -> `[197]` (*Player_Romus: ""Nothing we can do about it now. Let's focus on today's m..."*)

### Węzeł `[168]`
Mówca: **Hugo Toras**
> ""The Pales naval standoff has me rather on edge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player_Romus: ""It's not a standoff. Just insurance in case things go so..."*)
  - -> `[186]` (*Player_Romus: ""Trust me, I'll be glad when it's over.""*)
  - -> `[187]` (*Player_Romus: ""Relax. Lucita has everything under control.""*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Hugo Toras: ""The Pales naval standoff has me rather on edge.""*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Hugo Toras: ""The silence from Wehlen has me rather on edge.""*)

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good that I'm here. It's about time someone listened to that kid.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like a waste of time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Hugo Toras: ""There's a reason the King doesn't traditionally attend t..."*)

### Węzeł `[174]`
Mówca: **Hugo Toras**
> ""No. And you shouldn't be, either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Hugo Toras: ""When you have enough power, attention is nothing but a h..."*)

### Węzeł `[175]`
Mówca: **Hugo Toras**
> ""There's a reason the King doesn't traditionally attend these sessions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "The clock struck ten and the delegates filed in."*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Impractical? I'll be the judge of that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Hugo Toras: ""I assure you that you'll agree with me once the argument..."*)

### Węzeł `[177]`
Mówca: **Hugo Toras**
> ""I assure you that you'll agree with me once the arguments are presented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "The clock struck ten and the delegates filed in."*)

### Węzeł `[178]`
Mówca: **Hugo Toras**
> ""The Sazon boy might even keep his speeches to under a half hour.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player_Romus: ""Joke all you want, but it's about time someone listened ..."*)
  - -> `[180]` (*Player_Romus: ""Based on what I saw in Sallabes, I doubt it.""*)
  - -> `[181]` (*Player_Romus: ""You're not jealous of the attention he gets, are you?""*)

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Joke all you want, but it's about time someone listened to that kid.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Based on what I saw in Sallabes, I doubt it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're not jealous of the attention he gets, are you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[182]`
Mówca: **Hugo Toras**
> ""Someone besides your daughter, you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Hugo Toras: ""Rebuilding relations with House Sazon is a sound strateg..."*)

### Węzeł `[183]`
Mówca: **Hugo Toras**
> ""Ha. Far from it. Although I am worried about the attention he's been getting from one Vina Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Hugo Toras: ""Rebuilding relations with House Sazon is a sound strateg..."*)

### Węzeł `[184]`
Mówca: **Hugo Toras**
> ""His speech there seemed to have done a number on your daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Hugo Toras: ""Rebuilding relations with House Sazon is a sound strateg..."*)

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not a standoff. Just insurance in case things go south at the AN.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Hugo Toras: ""I trust Duchess Azaro is capable of de-escalation if nec..."*)

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Trust me, I'll be glad when it's over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Hugo Toras: ""Will your war councilor, I wonder?""*)

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Relax. Lucita has everything under control.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "Hugo frowned pensively."*)

### Węzeł `[188]`
Mówca: **Hugo Toras**
> ""Duchess Azaro is 'Lucita' now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "The clock struck ten and the delegates filed in."*)

### Węzeł `[189]`
Mówca: **Narrator**
> "Hugo frowned pensively."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Hugo Toras: ""Duchess Azaro is 'Lucita' now?""*)

### Węzeł `[190]`
Mówca: **Hugo Toras**
> ""Will your war councilor, I wonder?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "The clock struck ten and the delegates filed in."*)

### Węzeł `[191]`
Mówca: **Hugo Toras**
> ""I trust Duchess Azaro is capable of de-escalation if necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "The clock struck ten and the delegates filed in."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_Scapegoats`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Scapegoats"*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_Scapegoats)"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_Scapegoats`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Player_Romus: ""Me, too. I hope your son's gambit worked.""*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_Scapegoats)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Me, too. I hope your son's gambit worked.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"]`
- **Kontekst wejściowy (poprzednik):** `[167]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "The clock struck ten and the delegates filed in."*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""President Smolak will be at the next AN session. We can corner him there if we need to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "The clock struck ten and the delegates filed in."*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing we can do about it now. Let's focus on today's meeting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "The clock struck ten and the delegates filed in."*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope the investigators haven't found anything damning.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "The clock struck ten and the delegates filed in."*)

### Węzeł `[199]`
Mówca: **Hugo Toras**
> ""Madam Speaker, let the record show that the King has aligned with the House majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Daria de Rava: ""Noted, Your Grace.""*)

### Węzeł `[200]`
Mówca: **Hugo Toras**
> ""Madam Speaker, let the record show that the King has overridden the House majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Daria de Rava: ""Noted, Your Grace.""*)

### Węzeł `[201]`
Mówca: **Daria de Rava**
> ""Noted, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "Daria made a note in her binder, then looked up at Hugo a..."*)

### Węzeł `[202]`
Mówca: **Narrator**
> "Daria made a note in her binder, then looked up at Hugo and myself. If she was bothered by my decision, her face didn't show it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Daria de Rava: ""Once again, I thank His Majesty for blessing us with his..."*)

### Węzeł `[203]`
Mówca: **Daria de Rava**
> ""Once again, I thank His Majesty for blessing us with his presence today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Daria de Rava: ""And Grand Vizier Hugo Toras for presiding over the sessi..."*)

### Węzeł `[204]`
Mówca: **Daria de Rava**
> ""And Grand Vizier Hugo Toras for presiding over the session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Hugo Toras: ""An honor as usual, Madam Speaker. ""*)

### Węzeł `[205]`
Mówca: **Daria de Rava**
> ""Noted, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Daria made a note in her binder, then looked up at me, sl..."*)

### Węzeł `[206]`
Mówca: **Narrator**
> "Daria made a note in her binder, then looked up at me, slightly smiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Daria de Rava: ""Once again, I thank His Majesty for blessing us with his..."*)

### Węzeł `[207]`
Mówca: **Hugo Toras**
> ""An honor as usual, Madam Speaker. ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Daria de Rava: ""My fellow delegates and esteemed guests, this meeting is..."*)

### Węzeł `[208]`
Mówca: **Daria de Rava**
> ""My fellow delegates and esteemed guests, this meeting is now adjourned. Any follow-up questions will be addressed in future sittings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "She rang the bell again, and the room began to empty out."*)

### Węzeł `[209]`
Mówca: **Narrator**
> "She rang the bell again, and the room began to empty out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Daria de Rava"); RemoveConversant("Manu..."*)

### Węzeł `[210]`
Mówca: **Narrator**
> "As the guards escorted me and Hugo towards the exit, I noticed Rusty still standing in the hall with his arms folded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries =..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs == true"*)
  - -> `[388]` (*Player_Romus_Italic: "Ignore him."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs == true"*)
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining =..."*)
  - -> `[383]` (*Player_Romus: ""You're welcome.""*)
  - -> `[384]` (*Player_Romus_Italic: "Ignore him."*)

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, Rusty. I couldn't make it look like I was playing favorites.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true` AND `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Kontekst wejściowy (poprzednik):** `[210]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Russello Montoro: ""Sure, Your Majesty. I hear you loud and clear.""*)

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No hard feelings?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true` AND `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Kontekst wejściowy (poprzednik):** `[210]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Russello Montoro: ""None, Your Majesty. We're all just playing games here.""*)

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well? I'm a man of my word, aren't I?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true` AND `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[210]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Russello Montoro: ""And I'm a man of mine, Your Majesty.""*)

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't make me regret listening to you.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true` AND `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[210]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Russello Montoro: ""Never, Your Majesty. In fact...""*)

### Węzeł `[218]`
Mówca: **Russello Montoro**
> ""And I'm a man of mine, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "He reached out to shake my hand. I suddenly felt the cool..."*)

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You never seriously thought I was going to give in to you, did you?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true` AND `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Kontekst wejściowy (poprzednik):** `[210]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Russello Montoro: ""You're the king. It's your prerogative to change your mi..."*)

### Węzeł `[220]`
Mówca: **Russello Montoro**
> ""You're the king. It's your prerogative to change your mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Russello Montoro: ""We'll get to work on those regulations straight away. Bu..."*)

### Węzeł `[221]`
Mówca: **Russello Montoro**
> ""Sure, Your Majesty. I hear you loud and clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Russello Montoro: ""We'll get to work on those regulations straight away. Bu..."*)

### Węzeł `[222]`
Mówca: **Russello Montoro**
> ""None, Your Majesty. We're all just playing games here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Russello Montoro: ""We'll get to work on those regulations straight away. Bu..."*)

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to thank me. You and I wanted this equally.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[465]` (Manus Sazon), `[469]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Manus Sazon: ""I hope that means you'll continue to consider our propos..."*)

### Węzeł `[224]`
Mówca: **Narrator**
> "He bowed to each of us in turn before hurrying back into the building."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)

### Węzeł `[225]`
Mówca: **Russello Montoro**
> ""Never, Your Majesty. In fact...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "He reached out to shake my hand. I suddenly felt the cool..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Hugo rose to greet me as I entered the empty chamber. We ..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Economy_PromiseNoMiningRegs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs == true"*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Economy_PromiseNoMiningRegs == true)"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Economy_PromiseNoMiningRegs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "He looked at me and winked."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Economy_PromiseNoMiningRegs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Russello Montoro: ""Now. The Rizian Standard Dictionary defines 'gold' as a ..."*)

### Węzeł `[230]`
Mówca: **Narrator**
> "He looked at me and winked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Russello Montoro: ""Now. The Rizian Standard Dictionary defines 'gold' as a ..."*)

### Węzeł `[231]`
Mówca: **Russello Montoro**
> ""Now. The Rizian Standard Dictionary defines 'gold' as a yellow precious metal, used in jewelry and to guarantee the value of currencies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Player_Romus: ""There will be no bloviating in these chambers, *Rusty*.""*)
  - -> `[233]` (*Player_Romus: ""Yes, we are all familiar with the substance in question.""*)
  - -> `[234]` (*Player_Romus_Italic: "Let him talk."*)

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There will be no bloviating in these chambers, *Rusty*.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Russello Montoro: ""Fair enough, Your Majesty. Mr. Sazon over there has done..."*)

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, we are all familiar with the substance in question.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Russello Montoro: ""But in Rizia, it's so much more. Commoners who've never ..."*)

### Węzeł `[234]`
**[WYBÓR GRACZA: "Let him talk."]** — Mówca: **Player_Romus_Italic**
> "I stayed silent as he continued."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Russello Montoro: ""But in Rizia, it's so much more. Commoners who've never ..."*)

### Węzeł `[235]`
Mówca: **Russello Montoro**
> ""But in Rizia, it's so much more. Commoners who've never even touched a ducat still feel proud to live 'on shores of gold', as we sing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Russello Montoro: ""But our shores would never have been golden in the first..."*)

### Węzeł `[236]`
Mówca: **Russello Montoro**
> ""Fair enough, Your Majesty. Mr. Sazon over there has done enough bloviating for all of us put together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Narrator: "He gave Manus a brusque nod. The opposition speaker didn'..."*)

### Węzeł `[237]`
Mówca: **Russello Montoro**
> ""But our shores would never have been golden in the first place if our monarchs had listened to naysayers like Mr. Sazon here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Russello Montoro: ""Your Majesty, your predecessors knew that there can be n..."*)

### Węzeł `[238]`
Mówca: **Russello Montoro**
> ""Your Majesty, your predecessors knew that there can be no prosperity without hard work. Our grit and determination today fills the nation's coffers tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Russello Montoro: ""But where does that grit go when the government's got ou..."*)

### Węzeł `[239]`
Mówca: **Russello Montoro**
> ""But where does that grit go when the government's got our hands tied? How can we function as a company when you folks don't trust us to take care of our own people?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Manus Sazon: ""If I may ask, sir, how exactly would our proposal tie yo..."*)

### Węzeł `[240]`
Mówca: **Manus Sazon**
> ""If I may ask, sir, how exactly would our proposal tie your hands? What is so difficult about regulating safety in gold mines?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Russello Montoro: ""Don't play dumb, kid. You know each mining site in Rizia..."*)

### Węzeł `[241]`
Mówca: **Russello Montoro**
> ""Don't play dumb, kid. You know each mining site in Rizia is as unique as a birthmark on the Archpriest of Deyr's behind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Narrator: "Scandalized chatter broke out among the Delegates. Daria ..."*)

### Węzeł `[242]`
Mówca: **Manus Sazon**
> ""They would be paid for in equal measure by the government and the corporations in question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 1"*)

### Węzeł `[243]`
Mówca: **Daria de Rava**
> ""Mr. Montoro, I assume you are here as a representative of RRG as well as Rizia's business community as a whole. Is it safe to say your fellow executives share your opinion on the RPP's proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Narrator: "Rusty grinned toothily."*)

### Węzeł `[244]`
Mówca: **Narrator**
> "Rusty grinned toothily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Russello Montoro: ""Oh, it's very safe to say that. Although it does strike ..."*)

### Węzeł `[245]`
Mówca: **Russello Montoro**
> ""Oh, it's very safe to say that. Although it does strike me that your opponent's proposal could be implemented in, say, the construction industry without too much difficulty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "Daria's grip on her podium tightened. Rusty stroked his c..."*)

### Węzeł `[246]`
Mówca: **Narrator**
> "Daria's grip on her podium tightened. Rusty stroked his chin faux-thoughtfully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Russello Montoro: ""Come to think of it, I won't presume to speak up for the..."*)

### Węzeł `[247]`
Mówca: **Russello Montoro**
> ""Come to think of it, I won't presume to speak up for the people in Madam Speaker's high-and-mighty 'circles'. I'm the only one who cared enough to show up today, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Russello Montoro: ""So here's another thought. You regulate Rizian industry ..."*)

### Węzeł `[248]`
Mówca: **Russello Montoro**
> ""So here's another thought. You regulate Rizian industry however you want. But maybe, just maybe, you think about making an exception for old Rusty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs == true"*)

### Węzeł `[249]`
Mówca: **Narrator**
> "He winked at me again. Manus drew a hand across his brow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Manus Sazon: ""Our proposal as it stands does not allow for exceptions...."*)

### Węzeł `[250]`
Mówca: **Manus Sazon**
> ""Our proposal as it stands does not allow for exceptions. The King may alter it as he sees fit, but the RPP refuses to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Player_Romus: ""Giving *some* of the workers what they want might divide..."*)
  - -> `[257]` (*Player_Romus: ""Your proposal was never going to be accepted in its enti..."*)
  - -> `[258]` (*Player_Romus: ""I've witnessed Mr. Montoro's cavalier attitude towards e..."*)
  - -> `[259]` (*Player_Romus: ""I don't agree with Mr. Montoro's arguments one bit. It d..."*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Giving *some* of the workers what they want might divide them enough to head off organized dissent, right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[250]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Narrator: "Daria frowned."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Economy_PromiseNoMiningRegs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Economy_PromiseNoMiningRegs == true)"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Economy_PromiseNoMiningRegs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "He winked at me again. Manus drew a hand across his brow."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Economy_PromiseNoMiningRegs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Narrator: "Manus drew a hand across his brow."*)

### Węzeł `[255]`
Mówca: **Narrator**
> "Manus drew a hand across his brow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Manus Sazon: ""Our proposal as it stands does not allow for exceptions...."*)

### Węzeł `[256]`
Mówca: **Russello Montoro**
> ""But I'll just say this. There's no way we at RRG can keep filling your government's coffers if our hands are tied by unnecessary regulations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Manus Sazon: ""If I may ask, sir, how exactly would our proposal tie yo..."*)

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your proposal was never going to be accepted in its entirety, Mr. Sazon. Compromise is part of the political process.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[250]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Manus Sazon: ""My party will not compromise when human welfare is at st..."*)

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've witnessed Mr. Montoro's cavalier attitude towards employee safety. If any company needs to be regulated, it's RRG.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[250]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Russello Montoro: ""Cavalier? Heck, Your Majesty, you're the one who'd be pu..."*)

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't agree with Mr. Montoro's arguments one bit. It doesn't make sense to regulate some industries and not others.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[250]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "Daria nodded energetically."*)

### Węzeł `[260]`
Mówca: **Narrator**
> "Daria frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Daria de Rava: ""What it will do is hamper the majority of Rizian busines..."*)

### Węzeł `[261]`
Mówca: **Daria de Rava**
> ""What it will do is hamper the majority of Rizian businesses while giving miners an unfair advantage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Daria de Rava: ""Rizia's other major corporations -- run by families with..."*)

### Węzeł `[262]`
Mówca: **Manus Sazon**
> ""My party will not compromise when human welfare is at stake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Daria de Rava: ""The RNC is not willing to compromise, either.""*)

### Węzeł `[263]`
Mówca: **Narrator**
> "Daria nodded energetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Daria de Rava: ""No, it does not.""*)

### Węzeł `[264]`
Mówca: **Daria de Rava**
> ""No, it does not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Daria de Rava: ""Rizia's other major corporations -- run by families with..."*)

### Węzeł `[265]`
Mówca: **Russello Montoro**
> ""Cavalier? Heck, Your Majesty, you're the one who'd be putting men out of work with one decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Daria de Rava: ""Please do not forget in whose presence you're speaking, ..."*)

### Węzeł `[266]`
Mówca: **Narrator**
> "Hugo calmly spoke up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Hugo Toras: ""The time for a vote is drawing close. To be clear, Mr. S..."*)

### Węzeł `[267]`
Mówca: **Hugo Toras**
> ""The time for a vote is drawing close. To be clear, Mr. Sazon, you do not wish to amend your proposal to take into account Mr. Montoro's comments?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Manus Sazon: ""I do not, Your Grace. The King may choose to accept or i..."*)

### Węzeł `[268]`
Mówca: **Daria de Rava**
> ""Please do not forget in whose presence you're speaking, Mr. Montoro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Daria de Rava: ""Rizia's other major corporations -- run by families with..."*)

### Węzeł `[269]`
Mówca: **Manus Sazon**
> ""I do not, Your Grace. The King may choose to accept or ignore them at will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Hugo Toras: ""Then you have the floor, Madam Speaker.""*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rusty, did you have any closing arguments?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty"] == false`
- **Kontekst wejściowy (poprzednik):** `[300]` (Daria de Rava), `[318]` (Hugo Toras), `[440]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Russello Montoro: ""I surely do not, Your Majesty.""*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd like to confer with my Grand Vizier.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo"] == false`
- **Kontekst wejściowy (poprzednik):** `[300]` (Daria de Rava), `[318]` (Hugo Toras), `[440]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Daria de Rava: ""Of course.""*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Closing Arguments`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty == false"*)
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus == false"*)
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo ==..."*)
  - -> `[325]` (*Player_Romus: ""Here's what I have decided.""*)

### Węzeł `[273]`
Mówca: **Manus Sazon**
> ""I've stated my case, Your Majesty. But I will say this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_WorkWithRPP == true"*)

### Węzeł `[274]`
Mówca: **Manus Sazon**
> ""This proposal would fail without you in this room. So I'd like to believe you've joined us for a reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Manus Sazon: ""The majority of delegates in this room support noble int..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_WorkWithRPP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_WorkWithRPP == true"*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Manus_WorkWithRPP == true)"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_WorkWithRPP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Manus Sazon: ""This proposal would fail without you in this room. So I'..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Manus_WorkWithRPP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Manus Sazon: ""I'm glad you joined us in this room today. Perhaps now y..."*)

### Węzeł `[278]`
Mówca: **Manus Sazon**
> ""I'm glad you joined us in this room today. Perhaps now you have a better sense of how His Majesty Valero's system was designed to function.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Manus Sazon: ""The majority of delegates in this room support noble int..."*)

### Węzeł `[279]`
Mówca: **Manus Sazon**
> ""The majority of delegates in this room support noble interests. Not those of the subjects they claim to represent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Manus Sazon: ""As long as that is true, it is the King's responsibility..."*)

### Węzeł `[280]`
Mówca: **Manus Sazon**
> ""As long as that is true, it is the King's responsibility to see past the lies and make the decision that best serves ordinary citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Manus Sazon: ""Thank you for listening.""*)

### Węzeł `[281]`
Mówca: **Manus Sazon**
> ""Thank you for listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus = true"*)

### Węzeł `[282]`
Mówca: **Daria de Rava**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "We turned away from the Delegates and spoke in low voices."*)

### Węzeł `[283]`
Mówca: **Narrator**
> "We turned away from the Delegates and spoke in low voices."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs"*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_WorkWithRPP == true || RiziaDLC...."*)
  - -> `[301]` (*Player_Romus: ""Would I lose face with the Delegates if I implemented a ..."*)
  - -> `[302]` (*Player_Romus: ""What do you think about Rusty's exception idea? Could I ..."*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I told Manus I wanted to work closer with him. Would I be throwing away that chance if I shot down his proposal?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true`
- **Kontekst wejściowy (poprzednik):** `[283]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "Hugo coughed."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Economy_PromiseNoMiningRegs`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs"*)
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Economy_PromiseNoMiningRegs)"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Economy_PromiseNoMiningRegs`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Player_Romus: ""I can't ignore the potential benefits of cooperating wit..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Economy_PromiseNoMiningRegs)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't ignore the potential benefits of cooperating with RRG. Can I?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"]`
- **Kontekst wejściowy (poprzednik):** `[283]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Hugo Toras: ""Mr. Montoro did imply that staying on good terms with hi..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_WorkWithRPP == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_WorkWithRPP == true || RiziaDLC...."*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Manus_WorkWithRPP == true || RiziaDL..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_WorkWithRPP == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Player_Romus: ""I told Manus I wanted to work closer with him. Would I b..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Manus_WorkWithRPP == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Player_Romus: ""Would I be making an enemy of Manus Sazon's party and hi..."*)

### Węzeł `[292]`
Mówca: **Daria de Rava**
> ""All those in favor of the RPP's worker safety proposal, raise your hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Narrator: "About a quarter of the delegates, mostly those with green..."*)

### Węzeł `[293]`
Mówca: **Narrator**
> "About a quarter of the delegates, mostly those with green sashes, put a hand in the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Daria de Rava: ""Those in favor of encouraging Rizian businesses -- *all*..."*)

### Węzeł `[294]`
Mówca: **Daria de Rava**
> ""Those in favor of encouraging Rizian businesses -- *all* businesses -- to develop and enforce their own safety protocols on a voluntary basis?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "The rest of the delegates -- an overwhelming majority -- ..."*)

### Węzeł `[295]`
Mówca: **Narrator**
> "The rest of the delegates -- an overwhelming majority -- raised their hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Daria de Rava: ""The Delegates have an official recommendation. Rather th..."*)

### Węzeł `[296]`
Mówca: **Daria de Rava**
> ""The Delegates have an official recommendation. Rather than introduce sweeping and expensive labor reforms, Rizia should entrust the matter of safety to its business owners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "Hugo nodded."*)

### Węzeł `[297]`
Mówca: **Narrator**
> "Hugo nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Hugo Toras: ""Thank you, Madam Speaker.""*)

### Węzeł `[298]`
Mówca: **Hugo Toras**
> ""Thank you, Madam Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Daria de Rava: ""The final decision is now in the hands of His Majesty Ki..."*)

### Węzeł `[299]`
Mówca: **Daria de Rava**
> ""The final decision is now in the hands of His Majesty King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Daria de Rava: ""Will you accept or overrule the Delegates' recommendation?""*)

### Węzeł `[300]`
Mówca: **Daria de Rava**
> ""Will you accept or overrule the Delegates' recommendation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "Closing Arguments"*)

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would I lose face with the Delegates if I implemented a proposal they voted against?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[283]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Hugo Toras: ""It would be highly unusual, Your Majesty.""*)

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think about Rusty's exception idea? Could I decide to exempt RRG from the new regulations?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[283]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Hugo Toras: ""You're the king. Of course you can.""*)

### Węzeł `[303]`
Mówca: **Hugo Toras**
> ""Then you have the floor, Madam Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Daria de Rava: ""Thank you, Your Grace. As a reminder to you and His Maje..."*)

### Węzeł `[304]`
Mówca: **Daria de Rava**
> ""Thank you, Your Grace. As a reminder to you and His Majesty, this vote serves to demonstrate the opinion of the Rizian populace, and is a non-binding recommendation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Daria de Rava: ""All those in favor of the RPP's worker safety proposal, ..."*)

### Węzeł `[305]`
Mówca: **Hugo Toras**
> ""It would be highly unusual, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Hugo Toras: ""Valero never rejected a recommendation in all his years ..."*)

### Węzeł `[306]`
Mówca: **Narrator**
> "Hugo coughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Hugo Toras: ""Why would you-- Well. I'm sure you had a good reason.""*)

### Węzeł `[307]`
Mówca: **Hugo Toras**
> ""Why would you-- Well. I'm sure you had a good reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[308]`
Mówca: **Hugo Toras**
> ""Valero never rejected a recommendation in all his years as king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Hugo Toras: ""In this case, accepting the RPP's proposal would be dele..."*)

### Węzeł `[309]`
Mówca: **Hugo Toras**
> ""You're the king. Of course you can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Hugo Toras: ""It would save the kingdom money, it would send Mr. Monto..."*)

### Węzeł `[310]`
Mówca: **Hugo Toras**
> ""The young man does seem desperate to have you in his corner. I suspect the princess has something to do with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Hugo Toras: ""But I urge you to make the decision that benefits Rizia,..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_DancedWithManus == true)"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Hugo Toras: ""The young man does seem desperate to have you in his cor..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_DancedWithManus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Hugo Toras: ""The young man does seem desperate to have you in his cor..."*)

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would I be making an enemy of Manus Sazon's party and his house if I shot down his proposal?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[283]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Narrator: "Hugo coughed."*)

### Węzeł `[315]`
Mówca: **Narrator**
> "Hugo coughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Hugo Toras: ""His party is the enemy already. Granting them your favor..."*)

### Węzeł `[316]`
Mówca: **Hugo Toras**
> ""His party is the enemy already. Granting them your favor will strengthen their chances in the next election, and commensurately weaken the monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Hugo Toras: ""As for his family, I don't believe House Sazon had a han..."*)

### Węzeł `[317]`
Mówca: **Hugo Toras**
> ""It would save the kingdom money, it would send Mr. Montoro over the moon and it would partly placate the complainers in the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Hugo Toras: ""However, it would have a significant effect on Rizia's o..."*)

### Węzeł `[318]`
Mówca: **Hugo Toras**
> ""However, it would have a significant effect on Rizia's other corporations, many of which are owned by nobles such as Baroness de Rava and her constituents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo = ..."*)

### Węzeł `[319]`
Mówca: **Hugo Toras**
> ""In this case, accepting the RPP's proposal would be deleterious to the economies of the provinces the Delegates represent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Hugo Toras: ""Passing a version that exempts RRG makes practical sense..."*)

### Węzeł `[320]`
Mówca: **Hugo Toras**
> ""Mr. Montoro did imply that staying on good terms with his company would earn you the right to buy back the former royal stake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Economy_Diversification == true"*)

### Węzeł `[321]`
Mówca: **Hugo Toras**
> ""If we want to continue as a resource-based economy, owning more of RG would be advisable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Hugo Toras: ""And if we are to increase our stake, it would behoove us..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "Jump to: [Closing Arguments]"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Closing Arguments]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "Closing Arguments"*)

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you said all that you wanted to say, Mr. Sazon?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus"] == false`
- **Kontekst wejściowy (poprzednik):** `[300]` (Daria de Rava), `[318]` (Hugo Toras), `[440]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Manus Sazon: ""I've stated my case, Your Majesty. But I will say this.""*)

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Here's what I have decided.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Daria de Rava), `[318]` (Hugo Toras), `[440]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "Everyone in the room went silent as they awaited my next ..."*)

### Węzeł `[326]`
Mówca: **Narrator**
> "Everyone in the room went silent as they awaited my next words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player_Romus: ""I side with the delegate majority. The workplace safety ..."*)
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 3"*)
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)

### Węzeł `[327]`
Mówca: **Russello Montoro**
> ""I surely do not, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Russello Montoro: ""It seems to me like the decision you have to make is no ..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "Jump to: [Closing Arguments]"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Closing Arguments]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "Closing Arguments"*)

### Węzeł `[330]`
Mówca: **Russello Montoro**
> ""It seems to me like the decision you have to make is no decision at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Russello Montoro: ""You could even walk out of this room right now and let y..."*)

### Węzeł `[331]`
Mówca: **Russello Montoro**
> ""You could even walk out of this room right now and let your legislative system do the rest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Russello Montoro: ""But you're a man of action. I know you want the final sa..."*)

### Węzeł `[332]`
Mówca: **Russello Montoro**
> ""But you're a man of action. I know you want the final say. So by all means, go on and say it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty = true"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "Jump to: [Closing Arguments]"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Closing Arguments]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "Closing Arguments"*)

### Węzeł `[335]`
Mówca: **Narrator**
> "He reached out to shake my hand. I suddenly felt the cool of metal against my palm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Narrator: "I withdrew my hand and took a closer look at the object h..."*)

### Węzeł `[336]`
Mówca: **Russello Montoro**
> ""My guys dug this up in the MITZ a while back. Consider it a token of my appreciation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Player_Romus: ""You've been hoarding this? It belongs to the Crown.""*)
  - -> `[337]` (*Player_Romus: ""What is it?""*)
  - -> `[338]` (*Player_Romus: ""Thank you, Rusty. I'll treasure it.""*)
  - -> `[339]` (*Player_Romus: ""You've gotten what you wanted. No need for bribery.""*)

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[336]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Russello Montoro: ""Heck if I know. Looks pretty old, though, doesn't it?""*)

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Rusty. I'll treasure it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[336]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Russello Montoro: ""Thought you'd like it, Your Majesty.""*)

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've gotten what you wanted. No need for bribery.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[336]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Russello Montoro: ""Who do you think I am? This is out of the goodness of my..."*)

### Węzeł `[340]`
Mówca: **Russello Montoro**
> ""Thought you'd like it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs == true"*)

### Węzeł `[341]`
Mówca: **Russello Montoro**
> ""Heck if I know. Looks pretty old, though, doesn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs == true"*)

### Węzeł `[342]`
Mówca: **Russello Montoro**
> ""Who do you think I am? This is out of the goodness of my heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs == true"*)

### Węzeł `[343]`
Mówca: **Russello Montoro**
> ""As for those revisions to the RRG shareholder contract... my lawyers will be in touch with the paperwork.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Russello Montoro: ""Raising the stake won't be free, naturally. But I'll giv..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Daria de Rava");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Daria de Rava");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "She had a brisk gait and impeccable posture. The other de..."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Manus Sazon");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Manus Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Next came Manus Sazon, clad in a black suit with a forest..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn04_Argno_MiningPause = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn04_Argno_MiningPause"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn04_V_SafetyLawsHalfPassed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn04_V_SafetyLawsHalfPassed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining =..."*)
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn04_RH_SafetyLaws = true;"*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn04_V_SafetyLawsNotPassed = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn04_V_SafetyLawsNotPassed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries =..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn04_Argno_MiningPause = true"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining =..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty == false"*)
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty == false)"*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Player_Romus: ""Rusty, did you have any closing arguments?""*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus == false"*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus == false)"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Player_Romus: ""Have you said all that you wanted to say, Mr. Sazon?""*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo ==..."*)
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo ..."*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player_Romus: ""I'd like to confer with my Grand Vizier.""*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[365]`
Mówca: **Manus Sazon**
> ""Now a cross-industry coalition of employees and guest workers has bravely approached the Rizian People's Party with a list of requests to convey to our fellow delegates as well as His Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Manus Sazon: ""Among these are standardized workplace safety protocols,..."*)

### Węzeł `[366]`
Mówca: **Manus Sazon**
> ""Our industries' continued reliance on guest workers, who are paid and trained less than their native Rizian counterparts, is exacerbating the problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Manus Sazon: ""Now a cross-industry coalition of employees and guest wo..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Coalition", "R_Coalition_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Coalition","R_Coalition_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "I walked down the palm-tree-lined path that connected Pal..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_FreePress == true)"*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn04_V_SafetyLawsNotPassed = true"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_FreePress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_FreePress == true)"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn04_V_SafetyLawsHalfPassed = true;"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_FreePress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn04_RH_SafetyLaws = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn04_RH_SafetyLaws"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn04_HouseOfDelegates_NoNewRegulations = true;
RiziaDLC.Enable_Policy_RD_Welfare_WorkersRights = true;
RiziaDLC.PersonalValue_Malenyevist -= 1;
RiziaDLC.LeaningValue_Democratic -= 1;
RiziaDLC.LeaningValue_ProBusiness += 2;
RiziaDLC.Diplomacy_Morella_NegotiatingPower -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn04_HouseOfDelegates_NoNewRegulations"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Welfare_WorkersRights"] = true;
Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] - 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
Variable["RiziaDLC.LeaningValue_ProBusiness"] = Variable["RiziaDLC.LeaningValue_ProBusiness"] + 2;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Russello Montoro: ""Damn straight, Your Majesty!""*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Economy_PromiseNoMiningRegs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs == true"*)
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Economy_PromiseNoMiningRegs == true)"*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Economy_PromiseNoMiningRegs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Player_Romus: ""Sorry, Rusty. I couldn't make it look like I was playing..."*)
  - -> `[215]` (*Player_Romus: ""No hard feelings?""*)
  - -> `[219]` (*Player_Romus: ""You never seriously thought I was going to give in to yo..."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Economy_PromiseNoMiningRegs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Player_Romus: ""What do you want?""*)
  - -> `[409]` (*Player_Romus: ""For what it's worth, you made a good case.""*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Economy_PromiseNoMiningRegs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs == true"*)
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Economy_PromiseNoMiningRegs == true)"*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Economy_PromiseNoMiningRegs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Player_Romus: ""Well? I'm a man of my word, aren't I?""*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Economy_PromiseNoMiningRegs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Player_Romus: ""Is there something you'd like to say to me?""*)

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is there something you'd like to say to me?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[210]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Russello Montoro: ""I just wanted to express my gratitude, Your Majesty.""*)

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're welcome.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[210]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Russello Montoro: ""Your act of benevolence will not be forgotten, Your Maje..."*)

### Węzeł `[384]`
**[WYBÓR GRACZA: "Ignore him."]** — Mówca: **Player_Romus_Italic**
> "I kept walking towards the door."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[210]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Russello Montoro: ""One moment of your time, Your Majesty.""*)

### Węzeł `[385]`
Mówca: **Russello Montoro**
> ""One moment of your time, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Narrator: "He extended his hand for a handshake."*)

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've been hoarding this? It belongs to the Crown.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[336]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Russello Montoro: ""Finders keepers, I always thought. But hey, it's yours n..."*)

### Węzeł `[387]`
Mówca: **Russello Montoro**
> ""Finders keepers, I always thought. But hey, it's yours now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs == true"*)

### Węzeł `[388]`
**[WYBÓR GRACZA: "Ignore him."]** — Mówca: **Player_Romus_Italic**
> "I ignored him and kept walking towards the door."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Kontekst wejściowy (poprzednik):** `[210]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Narrator: "He eyed me coolly as Hugo and I passed him and walked out."*)

### Węzeł `[389]`
Mówca: **Narrator**
> "He eyed me coolly as Hugo and I passed him and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Russello Montoro");"*)

### Węzeł `[390]`
Mówca: **Narrator**
> "He extended his hand for a handshake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Player_Romus_Italic: "Shake his hand."*)
  - -> `[392]` (*Player_Romus_Italic: "Leave without acknowledging him."*)

### Węzeł `[391]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Romus_Italic**
> "As I shook his hand, I suddenly felt the cool of metal against my palm."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[390]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Narrator: "I withdrew my hand and took a closer look at the object h..."*)

### Węzeł `[392]`
**[WYBÓR GRACZA: "Leave without acknowledging him."]** — Mówca: **Player_Romus_Italic**
> "I motioned to Hugo, and we left without acknowledging him. I saw an amused look on his face as I walked out."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[390]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Russello Montoro");"*)

### Węzeł `[393]`
Mówca: **Narrator**
> "I withdrew my hand and took a closer look at the object he'd given me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_WruhecistMedallion");"*)

### Węzeł `[394]`
Mówca: **Russello Montoro**
> ""Your act of benevolence will not be forgotten, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "He reached out to shake my hand. I suddenly felt the cool..."*)

### Węzeł `[395]`
Mówca: **Russello Montoro**
> ""I just wanted to express my gratitude, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "He reached out to shake my hand. I suddenly felt the cool..."*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Economy_PromiseNoMiningRegs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs == true"*)
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Economy_PromiseNoMiningRegs == true)"*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Economy_PromiseNoMiningRegs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Russello Montoro: ""As for those revisions to the RRG shareholder contract....."*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Economy_PromiseNoMiningRegs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Russello Montoro: ""If you'll recall, I also mentioned the possibility of re..."*)

### Węzeł `[399]`
Mówca: **Russello Montoro**
> ""See you real soon, Your Majesty. Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Narrator: "He bowed, then began whistling jauntily as he walked past..."*)

### Węzeł `[400]`
Mówca: **Russello Montoro**
> ""If you'll recall, I also mentioned the possibility of revising the RRG shareholder contract. You interested?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Player_Romus: ""Thank you, but no. The Kingdom's share in RRG will stay ..."*)
  - -> `[402]` (*Player_Romus: ""Perhaps. I'd have to know more details first.""*)
  - -> `[403]` (*Player_Romus: ""I've given some thought to it and, yes, I would like to ..."*)

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, but no. The Kingdom's share in RRG will stay the same.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[400]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Russello Montoro: ""No problem. Just thought I'd ask.""*)

### Węzeł `[402]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps. I'd have to know more details first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[400]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Russello Montoro: ""Your wish is my command. I'll have my lawyers get in tou..."*)

### Węzeł `[403]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've given some thought to it and, yes, I would like to alter Rizia's share.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[400]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Russello Montoro: ""Your wish is my command. I'll have my lawyers get in tou..."*)

### Węzeł `[404]`
Mówca: **Russello Montoro**
> ""Your wish is my command. I'll have my lawyers get in touch with the paperwork.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Russello Montoro: ""Raising the stake won't be free, naturally. But I'll giv..."*)

### Węzeł `[405]`
Mówca: **Russello Montoro**
> ""No problem. Just thought I'd ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Russello Montoro: ""See you real soon, Your Majesty. Your Grace.""*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_WruhecistMedallion");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_WruhecistMedallion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_TookMedallion = true"*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn04_EnableRRGStakeChange = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn04_EnableRRGStakeChange"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Russello Montoro: ""See you real soon, Your Majesty. Your Grace.""*)

### Węzeł `[408]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you want?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false` AND `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Kontekst wejściowy (poprzednik):** `[210]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Russello Montoro: ""Nothing, Your Majesty.""*)

### Węzeł `[409]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For what it's worth, you made a good case.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false` AND `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Kontekst wejściowy (poprzednik):** `[210]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Russello Montoro: ""Much obliged, Your Majesty. No hard feelings.""*)

### Węzeł `[410]`
Mówca: **Russello Montoro**
> ""Nothing, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Russello Montoro: ""We'll get to work on those regulations straight away. Bu..."*)

### Węzeł `[411]`
Mówca: **Russello Montoro**
> ""We'll get to work on those regulations straight away. But I wasn't kidding about our gold output suffering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == tru..."*)

### Węzeł `[412]`
Mówca: **Russello Montoro**
> ""Much obliged, Your Majesty. No hard feelings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Russello Montoro: ""We'll get to work on those regulations straight away. Bu..."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 3"*)
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 3)"*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: ""I overrule the recommendation. The safety measures sugge..."*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 2)"*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player_Romus: ""After listening to compelling arguments from both Mr. Sa..."*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Player_Romus: ""While I sympathize with the RPP, our treasury is too str..."*)

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""While I sympathize with the RPP, our treasury is too strained for this proposal. It will not be implemented at this time.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Kontekst wejściowy (poprzednik):** `[326]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn04_HouseOfDelegates_NoNewRegu..."*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_TookMedallion = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Rusty_TookMedallion"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Russello Montoro: ""My guys dug this up in the MITZ a while back. Consider i..."*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_DancedWithManus == true)"*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Hugo Toras: ""Someone besides your daughter, you mean?""*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_DancedWithManus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Hugo Toras: ""He seemed to have caught your attention in Sallabes.""*)

### Węzeł `[424]`
Mówca: **Hugo Toras**
> ""He seemed to have caught your attention in Sallabes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Hugo Toras: ""Rebuilding relations with House Sazon is a sound strateg..."*)

### Węzeł `[425]`
Mówca: **Hugo Toras**
> ""Rebuilding relations with House Sazon is a sound strategy. But we mustn't allow them to get too close to the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "The clock struck ten and the delegates filed in."*)

### Węzeł `[426]`
Mówca: **Hugo Toras**
> ""Rebuilding relations with House Sazon is a sound strategy. As long as you don't buy into their nonsense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "The clock struck ten and the delegates filed in."*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_DancedWithManus == true)"*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Hugo Toras: ""Ha. Far from it. Although I am worried about the attenti..."*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_DancedWithManus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Hugo Toras: ""No. And you shouldn't be, either.""*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_DancedWithManus == true)"*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Hugo Toras: ""His speech there seemed to have done a number on your da..."*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_DancedWithManus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Hugo Toras: ""They're a fool for rhetoric over in Brenas. We mustn't a..."*)

### Węzeł `[433]`
Mówca: **Hugo Toras**
> ""They're a fool for rhetoric over in Brenas. We mustn't allow ourselves to be so easily suckered in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "The clock struck ten and the delegates filed in."*)

### Węzeł `[434]`
Mówca: **Hugo Toras**
> ""When you have enough power, attention is nothing but a hindrance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "The clock struck ten and the delegates filed in."*)

### Węzeł `[435]`
Mówca: **Russello Montoro**
> ""Raising the stake won't be free, naturally. But I'll give you a royal discount.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn04_EnableRRGStakeChange = true"*)

### Węzeł `[436]`
Mówca: **Daria de Rava**
> ""The RNC is not willing to compromise, either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Daria de Rava: ""Rizia's other major corporations -- run by families with..."*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Economy_Diversification == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Economy_Diversification == true"*)
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Economy_Diversification == true)"*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Economy_Diversification == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Economy_Diversification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Hugo Toras: ""However, if the goal is to diversify our economy away fr..."*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Economy_Diversification == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Economy_Diversification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Hugo Toras: ""If we want to continue as a resource-based economy, owni..."*)

### Węzeł `[440]`
Mówca: **Hugo Toras**
> ""However, if the goal is to diversify our economy away from resources, that 15 percent barely matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo = ..."*)

### Węzeł `[441]`
Mówca: **Daria de Rava**
> ""Rizia's other major corporations -- run by families with much longer and illustrious histories than that of Mr. Montoro here -- should not be punished simply because they do not happen to produce gold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Narrator: "I heard whispers of agreement from several other RNC memb..."*)

### Węzeł `[442]`
Mówca: **Narrator**
> "I heard whispers of agreement from several other RNC members."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Manus Sazon: ""That you would refer to these perfectly reasonable sugge..."*)

### Węzeł `[443]`
Mówca: **Manus Sazon**
> ""That you would refer to these perfectly reasonable suggestions as a 'punishment' is indicative of where your loyalties lie, Madam Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "Hugo calmly spoke up."*)

### Węzeł `[444]`
Mówca: **Russello Montoro**
> ""I've got to head out and spread the bad news. See you real soon, Your Majesty. Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Narrator: "He bowed to me, then jauntily straightened up and walked ..."*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining =..."*)
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining..."*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player_Romus: ""Don't make me regret listening to you.""*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[448]`
Mówca: **Russello Montoro**
> ""It might be time to think about finding new gold sources. Just to keep us in the black.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Russello Montoro: ""I've got to head out and spread the bad news. See you re..."*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == tru..."*)
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == t..."*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Russello Montoro: ""At least the new mine in Qalus will keep us in the black..."*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Enable_Policy_RD_Economy_QalusGoldMineProject ==..."*)

### Węzeł `[452]`
Mówca: **Russello Montoro**
> ""At least the new mine in Qalus will keep us in the black. Just about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Russello Montoro: ""I've got to head out and spread the bad news. See you re..."*)

### Węzeł `[453]`
Mówca: **Russello Montoro**
> ""You might want to think about digging under your relations' estates in Valenqiris after all. Just to keep us in the black.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Russello Montoro: ""I've got to head out and spread the bad news. See you re..."*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Enable_Policy_RD_Economy_QalusGoldMineProject == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Enable_Policy_RD_Economy_QalusGoldMineProject ==..."*)
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Enable_Policy_RD_Economy_QalusGoldMineProject ..."*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Enable_Policy_RD_Economy_QalusGoldMineProject == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Enable_Policy_RD_Economy_QalusGoldMineProject"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Russello Montoro: ""You might want to think about digging under your relatio..."*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Enable_Policy_RD_Economy_QalusGoldMineProject == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Enable_Policy_RD_Economy_QalusGoldMineProject"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Russello Montoro: ""It might be time to think about finding new gold sources..."*)

### Węzeł `[457]`
Mówca: **Narrator**
> "He bowed to me, then jauntily straightened up and walked out the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Russello Montoro");"*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_WorkWithRPP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true |..."*)
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true..."*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_WorkWithRPP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Hugo Toras: ""I'm still curious how he found out that today's session ..."*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_WorkWithRPP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)

### Węzeł `[461]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Romus_Italic**
> "I extended my hand. He hesitated for a moment, then shook it eagerly."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[516]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries =..."*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Manus Sazon: ""Your Majesty. Thank you so much for attending today's se..."*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining =..."*)

### Węzeł `[465]`
Mówca: **Manus Sazon**
> ""Your Majesty. Thank you so much for attending today's session. And for implementing our proposal, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Player_Romus: ""No need to thank me. You and I wanted this equally.""*)
  - -> `[517]` (*Player_Romus: ""I'm happy to have gotten a look into the inner workings ..."*)
  - -> `[519]` (*Player_Romus: ""You're most welcome. We shall have to meet soon to discu..."*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining =..."*)
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining..."*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Manus Sazon: ""Your Majesty. Thank you so much for attending today's se..."*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Manus Sazon: ""Your Majesty. I cannot thank you enough for attending to..."*)

### Węzeł `[469]`
Mówca: **Manus Sazon**
> ""Your Majesty. Thank you so much for attending today's session. Implementing even part of our proposal was more than we could have hoped for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Player_Romus: ""No need to thank me. You and I wanted this equally.""*)
  - -> `[517]` (*Player_Romus: ""I'm happy to have gotten a look into the inner workings ..."*)
  - -> `[519]` (*Player_Romus: ""You're most welcome. We shall have to meet soon to discu..."*)
  - -> `[518]` (*Player_Romus: ""My foremost concern is for the Rizian economy. I hope yo..."*)

### Węzeł `[470]`
Mówca: **Manus Sazon**
> ""Your Majesty. I cannot thank you enough for attending today's session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Player_Romus: ""I'm happy to have gotten a look into the inner workings ..."*)
  - -> `[520]` (*Player_Romus: ""I hope you aren't too disappointed with the outcome.""*)
  - -> `[518]` (*Player_Romus: ""My foremost concern is for the Rizian economy. I hope yo..."*)

### Węzeł `[471]`
Mówca: **Narrator**
> "Manus' eyes traveled involuntarily to the street, where one of Rusty's guards was helping the gold magnate into a shiny black Kadilla."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Narrator: "A look seemed to pass between the two of them. What it me..."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Russello Montoro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Russello Montoro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Narrator: "Behind him, leaning against the wall, were two of the Arc..."*)

### Węzeł `[473]`
Mówca: **Narrator**
> "Behind him, leaning against the wall, were two of the Arcasian guards I'd seen in Bronaz."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "I turned towards Hugo again."*)

### Węzeł `[474]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is this going to be a problem?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Hugo Toras: ""I can't say I'm happy to see Mr. Montoro in these halls.""*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "Hugo stared in Rusty's direction."*)

### Węzeł `[476]`
Mówca: **Hugo Toras**
> ""I can't say I'm happy to see Mr. Montoro in these halls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Hugo Toras: ""But I presume he is on the side of the RNC. The most he'..."*)

### Węzeł `[477]`
Mówca: **Narrator**
> "He gave Manus a brusque nod. The opposition speaker didn't acknowledge it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Russello Montoro: ""But I'll just say this. There's no way we at RRG can kee..."*)

### Węzeł `[478]`
Mówca: **Narrator**
> "Scandalized chatter broke out among the Delegates. Daria banged her gavel for silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Russello Montoro: ""Point is, there's no one-size-fits-all protocol for regu..."*)

### Węzeł `[479]`
Mówca: **Russello Montoro**
> ""Point is, there's no one-size-fits-all protocol for regulating what we do. The environment, the ore density, the tech being used -- it all varies, even within parts of the same mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Russello Montoro: ""We're doing our best to keep our workers safe on the job..."*)

### Węzeł `[480]`
Mówca: **Russello Montoro**
> ""We're doing our best to keep our workers safe on the job. But we also want them to go home with healthy paychecks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Russello Montoro: ""Your Majesty, esteemed Delegates -- if we're forced to d..."*)

### Węzeł `[481]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're exaggerating.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[483]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Russello Montoro: ""Hey, if you want to test my theory, you're more than wel..."*)

### Węzeł `[482]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about the miners who have been speaking out? We cannot ignore their complaints.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[483]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Russello Montoro: ""RRG takes care of our own, Your Majesty. We'll solve thi..."*)

### Węzeł `[483]`
Mówca: **Russello Montoro**
> ""Your Majesty, esteemed Delegates -- if we're forced to develop specialized protocols for every single nook and cranny of our business, we'll end up millions in the hole. Who even knows if anyone will be safer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Player_Romus: ""You're exaggerating.""*)
  - -> `[482]` (*Player_Romus: ""What about the miners who have been speaking out? We can..."*)
  - -> `[484]` (*Player_Romus: ""You could easily afford such measures if you forewent a ..."*)
  - -> `[489]` (*Player_Romus: ""That does seem much more complicated than Mr. Sazon made..."*)

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You could easily afford such measures if you forewent a portion of your own salary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[483]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Narrator: "Rusty chuckled to himself."*)

### Węzeł `[485]`
Mówca: **Narrator**
> "Rusty chuckled to himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Russello Montoro: ""I beg your pardon, but half the people in this room are ..."*)

### Węzeł `[486]`
Mówca: **Russello Montoro**
> ""I beg your pardon, but half the people in this room are sitting on fortunes just because they happen to have the right last name. Asking a hard-working commoner to give up the money he spent his life scraping for -- it doesn't sit right with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Daria de Rava: ""The subject of noble wealth is hardly germane to this di..."*)

### Węzeł `[487]`
Mówca: **Russello Montoro**
> ""RRG takes care of our own, Your Majesty. We'll solve this within our company, like we always have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Narrator: "Daria cleared her throat."*)

### Węzeł `[488]`
Mówca: **Russello Montoro**
> ""Hey, if you want to test my theory, you're more than welcome to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Narrator: "Daria cleared her throat."*)

### Węzeł `[489]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That does seem much more complicated than Mr. Sazon made it out to be.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[483]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Russello Montoro: ""Yes, well, he's a noble. Sooner or later, he's got to bu..."*)

### Węzeł `[490]`
Mówca: **Russello Montoro**
> ""Yes, well, he's a noble. Sooner or later, he's got to butt heads with the way the world really works.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Daria de Rava: ""The views of the nobility are hardly germane to this dis..."*)

### Węzeł `[491]`
Mówca: **Narrator**
> "A quiet look of annoyance flashed across Daria's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Daria de Rava: ""Mr. Montoro, I assume you are here as a representative o..."*)

### Węzeł `[492]`
Mówca: **Narrator**
> "Daria cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Daria de Rava: ""Mr. Montoro, I assume you are here as a representative o..."*)

### Węzeł `[493]`
Mówca: **Daria de Rava**
> ""The subject of noble wealth is hardly germane to this discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Narrator: "A quiet look of annoyance flashed across Daria's face."*)

### Węzeł `[494]`
Mówca: **Hugo Toras**
> ""And if we are to increase our stake, it would behoove us not to damage RRG's profitability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo = ..."*)

### Węzeł `[495]`
Mówca: **Hugo Toras**
> ""Passing a version that exempts RRG makes practical sense, but would surely anger the nobles whose investments are affected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo = ..."*)

### Węzeł `[496]`
Mówca: **Hugo Toras**
> ""As for his family, I don't believe House Sazon had a hand in this proposal at all. They have as much to lose from it as the Azaros or Torases.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo = ..."*)

### Węzeł `[497]`
Mówca: **Hugo Toras**
> ""But I urge you to make the decision that benefits Rizia, not Mr. Sazon or his party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo = ..."*)

### Węzeł `[498]`
Mówca: **Hugo Toras**
> ""The young man does seem desperate to have you in his corner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Hugo Toras: ""But I urge you to make the decision that benefits Rizia,..."*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn04_HouseOfDelegates_NoNewRegulations = true;
RiziaDLC.Enable_Policy_RD_Welfare_WorkersRights = true;
RiziaDLC.LeaningValue_ProBusiness += 1;
RiziaDLC.Diplomacy_Morella_NegotiatingPower -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn04_HouseOfDelegates_NoNewRegulations"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Welfare_WorkersRights"] = true;
Variable["RiziaDLC.LeaningValue_ProBusiness"] = Variable["RiziaDLC.LeaningValue_ProBusiness"] + 1;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Russello Montoro: ""Good enough for me, Your Majesty!""*)

### Węzeł `[500]`
Mówca: **Russello Montoro**
> ""Good enough for me, Your Majesty!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "My uncle gave Rusty a withering look."*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Russello Montoro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Russello Montoro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Narrator: "Hugo shook his head with disdain."*)
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true |..."*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Manus Sazon");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Manus Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Player_Romus_Italic: "Shake his hand."*)
  - -> `[545]` (*Player_Romus: ""What do you want?""*)
  - -> `[546]` (*Player_Romus: ""Ah. Just the man I wanted to see.""*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Daria de Rava");
RemoveConversant("Manus Sazon");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Daria de Rava");
RemoveConversant("Manus Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "As the guards escorted me and Hugo towards the exit, I no..."*)

### Węzeł `[504]`
Mówca: **Narrator**
> "He bowed, then began whistling jauntily as he walked past me and out the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Russello Montoro");"*)

### Węzeł `[505]`
Mówca: **Narrator**
> "Hugo shook his head with disdain."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)

### Węzeł `[506]`
Mówca: **Hugo Toras**
> ""You were right not to grant him an exception. That man's ego does not need any further inflation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true |..."*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries =..."*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Hugo Toras: ""You were right not to grant him an exception. That man's..."*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining =..."*)

### Węzeł `[510]`
Mówca: **Hugo Toras**
> ""Exempting RRG from the new regulations was a logical compromise, but I do hope it won't inflate that man's ego any further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true |..."*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining =..."*)
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining..."*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Hugo Toras: ""Exempting RRG from the new regulations was a logical com..."*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Hugo Toras: ""You were right to side with the RNC. The more of Rizian ..."*)

### Węzeł `[514]`
Mówca: **Hugo Toras**
> ""You were right to side with the RNC. The more of Rizian Royal Gold we can snatch back from that man's hands, the better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true |..."*)

### Węzeł `[515]`
Mówca: **Hugo Toras**
> ""I'm still curious how he found out that today's session was taking place. It would be most unlike Speaker de Rava to inform him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Narrator: "As we stepped outside the House of Delegates, I saw Manus..."*)

### Węzeł `[516]`
Mówca: **Narrator**
> "As we stepped outside the House of Delegates, I saw Manus Sazon waiting to greet us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "AddConversant("Manus Sazon");"*)

### Węzeł `[517]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm happy to have gotten a look into the inner workings of the House of Delegates. It was very enlightening indeed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[465]` (Manus Sazon), `[469]` (Manus Sazon), `[470]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Manus Sazon: ""You're welcome to attend as often as you'd like.""*)

### Węzeł `[518]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My foremost concern is for the Rizian economy. I hope you understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[469]` (Manus Sazon), `[470]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Manus Sazon: ""I understand completely. I'll make sure our future propo..."*)

### Węzeł `[519]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're most welcome. We shall have to meet soon to discuss the next steps.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[465]` (Manus Sazon), `[469]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Manus Sazon: ""I'm looking forward to it.""*)

### Węzeł `[520]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you aren't too disappointed with the outcome.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[470]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Manus Sazon: ""Not at all. I see the merit in my opponents' arguments, ..."*)

### Węzeł `[521]`
Mówca: **Manus Sazon**
> ""I hope that means you'll continue to consider our proposals going forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Narrator: "Hugo gave him a thin-lipped smile."*)

### Węzeł `[522]`
Mówca: **Manus Sazon**
> ""You're welcome to attend as often as you'd like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Narrator: "Hugo gave him a thin-lipped smile."*)

### Węzeł `[523]`
Mówca: **Manus Sazon**
> ""I'm looking forward to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Narrator: "Hugo gave him a thin-lipped smile."*)

### Węzeł `[524]`
Mówca: **Manus Sazon**
> ""Not at all. I see the merit in my opponents' arguments, and I understand your decision completely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Narrator: "Hugo gave him a thin-lipped smile."*)

### Węzeł `[525]`
Mówca: **Manus Sazon**
> ""I understand completely. I'll make sure our future proposals are more economically feasible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Narrator: "Hugo gave him a thin-lipped smile."*)

### Węzeł `[526]`
Mówca: **Narrator**
> "Hugo gave him a thin-lipped smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)

### Węzeł `[527]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries =..."*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Hugo Toras: ""Congratulations, Mr. Sazon. I'm sure you and your party ..."*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining =..."*)

### Węzeł `[530]`
Mówca: **Hugo Toras**
> ""Congratulations, Mr. Sazon. I'm sure you and your party will be celebrating today's triumph.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Narrator: "Manus' eyes traveled involuntarily to the street, where o..."*)

### Węzeł `[531]`
Mówca: **Manus Sazon**
> ""Indeed, Your Grace. His Majesty's ruling was... much more than I ever could have hoped for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Manus Sazon: ""I won't trouble either of you any longer. Thanks once mo..."*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining =..."*)
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining..."*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Hugo Toras: ""Congratulations, Mr. Sazon. I hope your party isn't terr..."*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Hugo Toras: ""You did well today, Mr. Sazon. I hope you and your party..."*)

### Węzeł `[535]`
Mówca: **Hugo Toras**
> ""Congratulations, Mr. Sazon. I hope your party isn't terribly disappointed about the exemption for Mr. Montoro's corporation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Narrator: "Manus' eyes traveled involuntarily to the street, where o..."*)

### Węzeł `[536]`
Mówca: **Narrator**
> "Manus' eyes traveled involuntarily to the street, where one of Rusty's guards was helping the gold magnate into a shiny black Kadilla."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Narrator: "A look seemed to pass between the two of them. What it me..."*)

### Węzeł `[537]`
Mówca: **Narrator**
> "A look seemed to pass between the two of them. What it meant, I wasn't certain."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Manus Sazon: ""Of course many of my colleagues wanted more... But in my..."*)

### Węzeł `[538]`
Mówca: **Manus Sazon**
> ""Of course many of my colleagues wanted more... But in my opinion, His Majesty's ruling is still cause for celebration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Manus Sazon: ""I won't trouble either of you any longer. Thanks once mo..."*)

### Węzeł `[539]`
Mówca: **Hugo Toras**
> ""You did well today, Mr. Sazon. I hope you and your party aren't too disappointed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Narrator: "Manus' eyes traveled involuntarily to the street, where o..."*)

### Węzeł `[540]`
Mówca: **Narrator**
> "Manus' eyes traveled involuntarily to the street, where one of Rusty's guards was helping the gold magnate into a shiny black Kadilla."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Narrator: "A look seemed to pass between the two of them. What it me..."*)

### Węzeł `[541]`
Mówca: **Narrator**
> "A look seemed to pass between the two of them. What it meant, I wasn't certain."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Manus Sazon: ""A temporary setback, Your Grace. We'll continue to push ..."*)

### Węzeł `[542]`
Mówca: **Narrator**
> "A look seemed to pass between the two of them. What it meant, I wasn't certain."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Manus Sazon: ""Indeed, Your Grace. His Majesty's ruling was... much mor..."*)

### Węzeł `[543]`
Mówca: **Manus Sazon**
> ""A temporary setback, Your Grace. We'll continue to push for the well-being of all Rizians, to the extent that our limited forum allows.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Manus Sazon: ""I won't trouble either of you any longer. Thanks once mo..."*)

### Węzeł `[544]`
Mówca: **Manus Sazon**
> ""I won't trouble either of you any longer. Thanks once more and good afternoon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "He bowed to each of us in turn before hurrying back into ..."*)

### Węzeł `[545]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you want?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[516]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah. Just the man I wanted to see.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[516]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == ..."*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Tyrant += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Daria de Rava: ""The Rizian People's Party has prepared a proposal that M..."*)

### Węzeł `[548]`
Mówca: **Daria de Rava**
> ""The business owners in my circles, most of whose companies span generations, cannot simply transform their practices at the whim of the government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Daria de Rava: ""Furthermore, they already see employee safety as their r..."*)

### Węzeł `[549]`
Mówca: **Daria de Rava**
> ""The views of the nobility are hardly germane to this discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Narrator: "A quiet look of annoyance flashed across Daria's face."*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Listening to a proposal from the Rizian People’s Party", "House of Delegates", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Listening to a proposal from the Rizian People’s Party","House of Delegates","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Coalition", "R_Coalition_Loop");"*)
