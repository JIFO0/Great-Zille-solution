# Sordland/Turn03/EnT_GasomProposal

- **ID konwersacji:** `41`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/041_EnT_GasomProposal.md`
- **Liczba węzłów dialogowych:** 353
- **Liczba wyborów gracza:** 57

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[29]** Ewald Alphonso
- **[35]** Gus Manger
- **[54]** Serge Wolkner

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.PersonalWealth`
- `BaseGame.Policy_Economy_PromotePlanned`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Relations_Ewald_PromiseNotHarsherEPA`
- `BaseGame.Situation_Law_MediaBias`
- `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia`
- `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone`
- `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment`
- `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Decision_Turn04_FoundationDonation_SmallSum`
- `BaseGame.EconomyDirection_Scale`
- `BaseGame.GovernmentBudget`
- `BaseGame.PersonalWealth`
- `BaseGame.Policy_Economy_Gasom_LargeStateInvestment`
- `BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment`
- `BaseGame.Public_Opinion`
- `BaseGame.Relations_Ewald_Discontent`
- `BaseGame.Relations_Ewald_DonatedToFoundation`
- `BaseGame.Relations_Ewald_Friendly`
- `BaseGame.Relations_Ewald_Neutral`
- `BaseGame.Relations_Ewald_PromiseNotHarsherEPA`
- `BaseGame.RuralDevelopment_Interest`
- `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia`
- `BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention`
- `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone`
- `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment`
- `BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits`
- `BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages`
- `BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation`
- `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint`
- `BaseGameSupport.Codex_Organisations_Corporations_Gasom`
- `BaseGameSupport.Codex_Organisations_Corporations_Gasom_Invested`
- `BaseGameSupport.Journal_Turn03_AlphonsoFoundation_DonatedSmall`
- `BaseGameSupport.Journal_Turn03_GasomWelfare_EducationHealthHousing`
- `BaseGameSupport.Journal_Turn03_GasomWelfare_MoreBlueSalary`
- `BaseGameSupport.Journal_Turn03_GasomWelfare_NarbelCharity`
- `BaseGameSupport.Journal_Turn03_Gasom_CoInvestRizia`
- `BaseGameSupport.Journal_Turn03_Gasom_LargeSordlandInvest`
- `BaseGameSupport.Journal_Turn03_Gasom_RiziaAloneInvest`
- `BaseGameSupport.News_Turn03_HP_Gasom_CoInvestmentSkepticism`
- `BaseGameSupport.News_Turn03_HP_Gasom_LargeInvestmentPraise`
- `BaseGameSupport.News_Turn03_HP_Gasom_RiziaInvestmentCritique`
- `BaseGameSupport.News_Turn03_LT_Gasom_CoInvestmentPotential`
- `BaseGameSupport.News_Turn03_LT_Gasom_NoInvestmentDownside`
- `BaseGameSupport.News_Turn03_LT_Gasom_SordlandInvestmentPositive`
- `BaseGameSupport.News_Turn03_LT_PresidentAFDonation`
- `BaseGameSupport.News_Turn03_R_Gasom_LargeInvestmentCritique`
- `BaseGameSupport.News_Turn03_R_Gasom_NoInvestmentCritique`
- `BaseGameSupport.News_Turn03_R_PresidentAFDonation`
- `BaseGameSupport.News_Turn03_ST_Gasom_CoInvestmentCritique`
- `BaseGameSupport.News_Turn03_ST_Gasom_CoInvestmentPraise`
- `BaseGameSupport.News_Turn03_ST_Gasom_LargeInvestmentCritique`
- `BaseGameSupport.News_Turn03_ST_Gasom_LargeInvestmentPraise`
- `BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentCritique`
- `BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentPraise`
- `BaseGameSupport.Report_Turn03_Ribel_NewBFFLeadership`

### Skoki między-konwersacyjne:
- Węzeł `[24]` -> **[42] Sordland/Turn03/Gus Intro Talk** (../Turn_03/042_Gus_Intro_Talk.md), Węzeł `[1]`
- Węzeł `[36]` -> **[43] Sordland/Turn03/Ewald Alphonso Debate** (../Turn_03/043_Ewald_Alphonso_Debate.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[27]` | **"“President Alphonso. It's nice to see what you have built from the inside.”"** | `[26]` **Ewald Alphonso**: "“President Rayne. I hope you enj..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Ewald Alphonso**: "“It's fine. Nothing compared to ..." |
| `[28]` | **"“The facilities appear to be in much better shape than the city around them.”"** | `[26]` **Ewald Alphonso**: "“President Rayne. I hope you enj..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Ewald Alphonso**: ""You should have seen Narbel bef..." |
| `[29]` | **"“Greetings. I'm curious to find out more about where Gasom stands.”"** | `[26]` **Ewald Alphonso**: "“President Rayne. I hope you enj..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Ewald Alphonso**: ""The same sentiment applies to t..." |
| `[40]` | **""If we are to invest in Gasom, I want to make sure that the company is also commit..."** | `[39]` **Ewald Alphonso**: "“By significant, I mean that our..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.RuralDevelopment_Interest"] = Variable...` | `[45]` **Ewald Alphonso**: ""I wholeheartedly agree. The wel..." |
| `[41]` | **""Your projections sound impressive. However, we need to consider the international..."** | `[39]` **Ewald Alphonso**: "“By significant, I mean that our..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Ewald Alphonso**: ""We've got a strong strategy in ..." |
| `[46]` | **""An enticing proposition. However, I would like to know more about the risks invol..."** | `[39]` **Ewald Alphonso**: "“By significant, I mean that our..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Ewald Alphonso**: ""I understand your concern. The ..." |
| `[72]` | **""The Kingdom of Rizia's investment would reduce the risk for us. However, we need ..."** | `[70]` **Ewald Alphonso**: ""A government investment in our ..."<br>`[71]` **Ewald Alphonso**: ""With a government investment, w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Ewald Alphonso**: ""The partnership with Rizia is i..." |
| `[73]` | **""I'm heavily interested in the idea of Gasom investing in Narbel's development. Bu..."** | `[70]` **Ewald Alphonso**: ""A government investment in our ..."<br>`[71]` **Ewald Alphonso**: ""With a government investment, w..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.RuralDevelopment_Interest"] = Variable...` | `[77]` **Ewald Alphonso**: ""You're right to demand specific..." |
| `[74]` | **""I see the potential for us to drive Sordland's energy independence. But we need t..."** | `[70]` **Ewald Alphonso**: ""A government investment in our ..."<br>`[71]` **Ewald Alphonso**: ""With a government investment, w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Ewald Alphonso**: ""You bring up a valid point. We'..." |
| `[84]` | **""We'll co-invest with Rizia. We'll share the costs and stakes." [-1 Government Bud..."** | `[216]` **Ewald Alphonso**: ""Well, Mr. President? Will Gasom..." | `Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true` | `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] =...`<br>`Variable["BaseGameSupport.News_Turn03_HP_Gasom_CoInvestme...`<br>*(+2 skryptów)* | `[93]` **Ewald Alphonso**: ""A joint investment? A wise choi..." |
| `[85]` | **""We won't invest at this time. Let the Kingdom and other foreign investors contrib..."** | `[216]` **Ewald Alphonso**: ""Well, Mr. President? Will Gasom..." | `(Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true) == false` | `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"]...`<br>`Variable["BaseGameSupport.News_Turn03_HP_Gasom_RiziaInves...`<br>*(+2 skryptów)* | `[94]` **Ewald Alphonso**: ""I understand your reservations...." |
| `[86]` | **""We're investing alone. Sordland will provide the majority of funds, and Gus will ..."** | `[216]` **Ewald Alphonso**: ""Well, Mr. President? Will Gasom..." | `Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true` | `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestme...`<br>`Variable["BaseGameSupport.News_Turn03_HP_Gasom_LargeInves...`<br>*(+2 skryptów)* | `[92]` **Ewald Alphonso**: ""Your decision shows a commitmen..." |
| `[98]` | **""The wages of Gasom blue-collar workers need to be increased. They are the backbon..."** | `[275]` **Ewald Alphonso**: ""Do you have a proposal in mind,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Ewald Alphonso**: ""I fully agree that we must do m..."<br>`[124]` **Ewald Alphonso**: ""President Rayne, the welfare of..."<br>*(oraz 1 innych odgałęzień)* |
| `[99]` | **""I expect Gasom to contribute significantly to local charities, to aid in the city..."** | `[275]` **Ewald Alphonso**: ""Do you have a proposal in mind,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Ewald Alphonso**: ""I share your concerns about Nar..."<br>`[127]` **Ewald Alphonso**: ""President Rayne, I understand t..."<br>*(oraz 1 innych odgałęzień)* |
| `[100]` | **""The workers of Gasom need better housing, access to healthcare, and opportunities..."** | `[275]` **Ewald Alphonso**: ""Do you have a proposal in mind,..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.RuralDevelopment_Interest"] = Variable...` | `[104]` **Ewald Alphonso**: ""A good point. I see the potenti..."<br>`[102]` **Ewald Alphonso**: ""President Rayne, I appreciate y..."<br>*(oraz 1 innych odgałęzień)* |
| `[101]` | **""We've covered a lot today. I believe we can wrap up the meeting now.""** | `[274]` **Narrator**: "Alphonso nodded and looked at me."<br>`[275]` **Ewald Alphonso**: ""Do you have a proposal in mind,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[340]` **Ewald Alphonso**: ""Very well, Mr. President."" |
| `[136]` | **""That's reassuring to hear. I trust that you'll follow through on these commitments.""** | `[132]` **Ewald Alphonso**: ""I will personally oversee initi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Gus Manger**: ""Well, this is promising. Ewald'..." |
| `[137]` | **""These are significant steps. I look forward to seeing these changes implemented s..."** | `[132]` **Ewald Alphonso**: ""I will personally oversee initi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Gus Manger**: ""Ewald, your personal commitment..." |
| `[138]` | **""Agreed, Gus. Mr. Alphonso, we expect to see tangible improvements in this city.""** | `[130]` **Gus Manger**: ""Gentlemen, it's clear that we a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Ewald Alphonso**: ""Well, Mr. President, we're comm..." |
| `[139]` | **""Gus, all the talk in the world won't change the situation in Narbel. We need conc..."** | `[130]` **Gus Manger**: ""Gentlemen, it's clear that we a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Ewald Alphonso**: ""We understand the need for acti..." |
| `[153]` | **""Indeed Gus, we have to ensure that we don't jeopardize the economic stability of ..."** | `[150]` **Gus Manger**: ""Both of you make good points. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Ewald Alphonso**: ""As I mentioned before, we're al..." |
| `[154]` | **""It's a fine line indeed. But that doesn't absolve us, or Gasom, of our responsibi..."** | `[150]` **Gus Manger**: ""Both of you make good points. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Ewald Alphonso**: ""Mr. President, I assure you tha..." |
| `[155]` | **""That's true. And I hope that Gasom is ready to make some significant changes.""** | `[131]` **Gus Manger**: ""We're all in agreement that we ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Ewald Alphonso**: ""I understand, Anton. At Gasom, ..." |
| `[156]` | **""We're all in agreement, Gus. Now it's time to turn that agreement into action.""** | `[131]` **Gus Manger**: ""We're all in agreement that we ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Ewald Alphonso**: ""I agree, it's time for us to--"" |
| `[164]` | **""I'm relieved to hear that. A fair wage is the least we can provide for the hardwo..."** | `[133]` **Ewald Alphonso**: ""I will personally ensure that w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[163]` **Gus Manger**: ""We are all on the same page her..." |
| `[165]` | **""Promises are a start, Ewald. But the people need actions, not words. I look forwa..."** | `[133]` **Ewald Alphonso**: ""I will personally ensure that w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Gus Manger**: ""Ewald, your personal commitment..." |
| `[168]` | **""We need to do more than reduce harm. Our goal should be a better Narbel, not just..."** | `[135]` **Ewald Alphonso**: ""Personally, I am committed to s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Gus Manger**: ""This is still promising. Ewald'..." |
| `[169]` | **""Charitable donations are commendable. But we must address the source of the harm,..."** | `[135]` **Ewald Alphonso**: ""Personally, I am committed to s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Gus Manger**: ""I couldn't agree more. It's hig..." |
| `[188]` | **""That's a shame. I still believe there's potential for us to work together in some..."** | `[53]` **Ewald Alphonso**: ""Your attitude and choices as Pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Ewald Alphonso**: ""I appreciate your optimism, Mr...." |
| `[189]` | **""I understand, Mr. Alphonso. It's important that we each stay true to our principl..."** | `[53]` **Ewald Alphonso**: ""Your attitude and choices as Pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Ewald Alphonso**: ""Indeed, Mr. President. Our prin..." |
| `[190]` | **""Perhaps it's for the best, Mr. Alphonso. Your approach to business doesn't align ..."** | `[53]` **Ewald Alphonso**: ""Your attitude and choices as Pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Ewald Alphonso**: ""We each have our roles to play ..." |
| `[198]` | **""Gentlemen, after careful consideration, I've decided to step away from this deal...."** | `[197]` **Ewald Alphonso**: ""As a further gesture of goodwil..."<br>`[259]` **Ewald Alphonso**: ""Ready to make history together?..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealP...` | `[257]` **Gus Manger**: ""I understand, Mr. President."" |
| `[199]` | **""Alright, let's proceed with the deal. The EPA restrictions will remain as they ar..."** | `[197]` **Ewald Alphonso**: ""As a further gesture of goodwil..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame....` | `[272]` **Gus Manger**: ""Amazing! I knew you two could m..." |
| `[207]` | **""Gus, I respect you, but I can't trust your judgement in this matter. You seem to ..."** | `[206]` **Gus Manger**: ""However, for that to happen, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Gus Manger**: ""Fair enough, Mr. President. I g..." |
| `[208]` | **""I trust your advice. You've proven yourself a reliable ally and I believe we can ..."** | `[206]` **Gus Manger**: ""However, for that to happen, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Gus Manger**: ""Thank you, Mr. President. I pro..." |
| `[209]` | **""Your judgement has been questionable at times. But I'm willing to hear you out.""** | `[206]` **Gus Manger**: ""However, for that to happen, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Gus Manger**: ""Thank you, Mr. President. I pro..." |
| `[218]` | **""You've made a compelling case. Let's get this deal on the road. I can assure you ..."** | `[259]` **Ewald Alphonso**: ""Ready to make history together?..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"]...` | `[220]` **Gus Manger**: ""I'm glad you're on board, Mr. P..." |
| `[233]` | **""Don't you think there's a way we can ensure Gasom's growth without putting the go..."** | `[232]` **Ewald Alphonso**: ""Are you ready to make your gove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Ewald Alphonso**: ""Gus, would you like to answer t..." |
| `[234]` | **""What kind of assurances can you provide that this will pay off in the long term, ..."** | `[232]` **Ewald Alphonso**: ""Are you ready to make your gove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[240]` **Ewald Alphonso**: ""Mr. President, in business, the..." |
| `[235]` | **""I'm all for taking calculated risks. But we need to be sure that the benefits out..."** | `[232]` **Ewald Alphonso**: ""Are you ready to make your gove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Ewald Alphonso**: ""Of course, Mr. President. I wou..." |
| `[236]` | **""Mr. Alphonso, are you suggesting that we should risk the treasury of Sordland for..."** | `[232]` **Ewald Alphonso**: ""Are you ready to make your gove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Ewald Alphonso**: ""Not at all, Mr. President. I'm ..." |
| `[248]` | **""I understand your point. However, the stakes are too high for us to gamble on unc..."** | `[250]` **Ewald Alphonso**: ""That our greatest potential mig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Ewald Alphonso**: ""If the Sordish government choos..." |
| `[249]` | **""I have. And I believe that embracing uncertainty is a part of leadership. We must..."** | `[250]` **Ewald Alphonso**: ""That our greatest potential mig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Ewald Alphonso**: ""If the Sordish government choos..." |
| `[251]` | **""Liberalizing the energy market merely serves the interests of the wealthy elites...."** | `[70]` **Ewald Alphonso**: ""A government investment in our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Ewald Alphonso**: ""While I respect your perspectiv..." |
| `[254]` | **""A thriving market economy is the engine of prosperity and innovation. I believe i..."** | `[71]` **Ewald Alphonso**: ""With a government investment, w..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealP...` | `[255]` **Ewald Alphonso**: ""I'm glad we see eye to eye on t..." |
| `[261]` | **""A helicopter might be the safer option.""** | `[180]` **Ewald Alphonso**: ""I have a helicopter ready. We c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Ewald Alphonso**: ""I will give the order to ready ..." |
| `[262]` | **""I think we should face the crowd head-on.""** | `[180]` **Ewald Alphonso**: ""I have a helicopter ready. We c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[266]` **Ewald Alphonso**: ""That is your prerogative, Mr. P..." |
| `[263]` | **""Is there no other way out?""** | `[180]` **Ewald Alphonso**: ""I have a helicopter ready. We c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Ewald Alphonso**: ""Trust me, I know this place wel..." |
| `[327]` | **""I'm not here for your approval, Alphonso. My priority is Gus and, more importantl..."** | `[53]` **Ewald Alphonso**: ""Your attitude and choices as Pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[328]` **Ewald Alphonso**: ""That sounds eerily like what Mr..." |
| `[330]` | **""We must make decisions based on what is best for Sordland in the present moment.""** | `[250]` **Ewald Alphonso**: ""That our greatest potential mig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Ewald Alphonso**: ""If the Sordish government choos..." |
| `[331]` | **""Running the state is not like running your company Alphonso. You out of all peopl..."** | `[250]` **Ewald Alphonso**: ""That our greatest potential mig..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.RuralDevelopment_Interest"] = Variable...` | `[224]` **Ewald Alphonso**: ""If the Sordish government choos..." |
| `[336]` | **""We need to address these concerns; they could jeopardize the administration.""** | `[274]` **Narrator**: "Alphonso nodded and looked at me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[339]` **Ewald Alphonso**: ""Together, we might discover sol..." |
| `[337]` | **""Our duty is to listen and take action. That's the mandate granted to us by the pu..."** | `[274]` **Narrator**: "Alphonso nodded and looked at me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[343]` **Ewald Alphonso**: ""While sometimes people may not ..." |
| `[338]` | **""Gasom stands as a global energy powerhouse. It's only right they give back somewh..."** | `[274]` **Narrator**: "Alphonso nodded and looked at me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[344]` **Ewald Alphonso**: ""Let's mull it over."" |
| `[341]` | **""I've wasted enough time to this. Time to depart.""** | `[274]` **Narrator**: "Alphonso nodded and looked at me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[342]` **Ewald Alphonso**: ""It's regrettable you feel this ..." |
| `[346]` | **""Look, gentlemen. My time is valuable, so let’s cut to the chase.""** | `[26]` **Ewald Alphonso**: "“President Rayne. I hope you enj..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Ewald Alphonso**: ""Blunt. Must be the new way of d..." |
| `[348]` | **""Don’t forget, the state stands above you all. Nothing may happen today, or next w..."** | `[206]` **Gus Manger**: ""However, for that to happen, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[349]` **Ewald Alphonso**: ""I have served Sordland all my l..." |

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
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Visiting a large gas company to discuss ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Meanwhile, Gus Manger had invited me to visit the Gasom headquarters in Narbel. It was situated in Ornobel, a neighborhood on the city outskirts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Next to it was the Damenoy gas reserve, a prominent natur..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Next to it was the Damenoy gas reserve, a prominent natural gas source consisting of four large fields."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "As our motorcade made its way through the Ornobel distric..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "The roads were bumpy and marked by potholes, while the buildings surrounded us appeared run-down and dilapidated. The community had apparently endured a prolonged period of neglect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "We came to a halt at the entrance gates of the facility. ..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "We came to a halt at the entrance gates of the facility. A sizeable mural depicting the Gasom logo had been painted on a nearby wall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Adjacent to the mural, a group of individuals wearing blu..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "After a series of intense meetings with Ciara and Paskal, I decided to take some much-needed time to recharge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "I checked in with Lucian and Petr back at the capital. Th..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "I checked in with Lucian and Petr back at the capital. Th..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Path == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "I checked in with Lucian and Petr back at the capital. Th..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "I checked in with Lucian and Petr back at the capital. Th..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)

### Węzeł `[17]`
Mówca: **Narrator**
> "I checked in with Lucian and Petr back at the capital. They were working hard to unite democratically leaning reformers for the crucial task of drafting a new constitution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Meanwhile, Gus Manger had invited me to visit the Gasom h..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "I checked in with Lucian and Petr back at the capital. They had devoted themselves to the challenging task of uniting pro-centralization factions behind the drafting of a new constitution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Meanwhile, Gus Manger had invited me to visit the Gasom h..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "I checked in with Lucian and Petr back at the capital. They were engaged in intense negotiations with the Old Guard in order to address their pressing national security concerns."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Meanwhile, Gus Manger had invited me to visit the Gasom h..."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "I checked in with Lucian and Petr back at the capital. They were working tirelessly, exploring all possibilities and avenues to advance the constitutional reform draft."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Meanwhile, Gus Manger had invited me to visit the Gasom h..."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "Ewald Alphonso stood up from his chair. He had on a perfectly tailored suit that he wore as casually as pajamas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Ewald Alphonso: "“Gus, you old devil.”"*)

### Węzeł `[22]`
Mówca: **Ewald Alphonso**
> "“Gus, you old devil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Gus Manger: "“It takes one to know one. As promised, I've brought our ..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "Adjacent to the mural, a group of individuals wearing blue work vests had assembled, holding what looked like protest signs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Serge skillfully parked the car, bringing our journey to ..."*)

### Węzeł `[24]`
Mówca: **Gus Manger**
> ""Good day, President Rayne. Welcome to Gasom's Narbel operations!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[25]`
Mówca: **Gus Manger**
> "“It takes one to know one. As promised, I've brought our guest of honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Ewald Alphonso: "“President Rayne. I hope you enjoyed seeing our facilitie..."*)

### Węzeł `[26]`
Mówca: **Ewald Alphonso**
> "“President Rayne. I hope you enjoyed seeing our facilities here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: "“President Alphonso. It's nice to see what you have built..."*)
  - -> `[28]` (*Player: "“The facilities appear to be in much better shape than th..."*)
  - -> `[29]` (*Player: "“Greetings. I'm curious to find out more about where Gaso..."*)
  - -> `[346]` (*Player: ""Look, gentlemen. My time is valuable, so let’s cut to th..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“President Alphonso. It's nice to see what you have built from the inside.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Ewald Alphonso: "“It's fine. Nothing compared to the Gasom HQ in Holsord, ..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The facilities appear to be in much better shape than the city around them.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Ewald Alphonso: ""You should have seen Narbel before Gasom came here. The ..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Greetings. I'm curious to find out more about where Gasom stands.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Ewald Alphonso: ""The same sentiment applies to the government's stance on..."*)

### Węzeł `[30]`
Mówca: **Ewald Alphonso**
> "“It's fine. Nothing compared to the Gasom HQ in Holsord, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Gus Manger: "“Still one of the standouts of the Maroon District.”"*)

### Węzeł `[31]`
Mówca: **Ewald Alphonso**
> ""You should have seen Narbel before Gasom came here. The jobs it generated have had a lasting positive effect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Gus Manger: ""It's true. Things here could be a lot worse.""*)

### Węzeł `[32]`
Mówca: **Ewald Alphonso**
> ""The same sentiment applies to the government's stance on our energy policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Gus Manger: "“Plenty of discussions we can have. We have the two new f..."*)

### Węzeł `[33]`
Mówca: **Gus Manger**
> "“Still one of the standouts of the Maroon District.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Ewald Alphonso: "“Please have a seat. Let's talk.”"*)

### Węzeł `[34]`
Mówca: **Gus Manger**
> ""It's true. Things here could be a lot worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Ewald Alphonso: "“Please have a seat. Let's talk.”"*)

### Węzeł `[35]`
Mówca: **Gus Manger**
> "“Plenty of discussions we can have. We have the two new faces of Sordland in one room. The old man is nowhere to be seen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Ewald Alphonso: "“Please have a seat. Let's talk.”"*)

### Węzeł `[36]`
Mówca: **Narrator**
> "We sat down. Some snacks and drinks were served. Multiple Gasom yearly financial reports were scattered on the table between us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[37]`
Mówca: **Ewald Alphonso**
> "“Please have a seat. Let's talk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "We sat down. Some snacks and drinks were served. Multiple..."*)

### Węzeł `[38]`
Mówca: **Ewald Alphonso**
> "“If we raise a minority investment, it would allow us to invest in further resource excavations in the gas fields, and turn the company back to significant profitability.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Ewald Alphonso: "“By significant, I mean that our projections show that we..."*)

### Węzeł `[39]`
Mówca: **Ewald Alphonso**
> "“By significant, I mean that our projections show that we would be able to cover eighty percent of Sordland's gas needs in three years, and we would achieve profits four times the value of our investment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""An enticing proposition. However, I would like to know m..."*)
  - -> `[40]` (*Player: ""If we are to invest in Gasom, I want to make sure that t..."*)
  - -> `[41]` (*Player: ""Your projections sound impressive. However, we need to c..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If we are to invest in Gasom, I want to make sure that the company is also committed to improving the socio-economic conditions in Narbel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.RuralDevelopment_Interest += 1"*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your projections sound impressive. However, we need to consider the international market as well. How do we plan to compete against nations like Anraka, Arcasia, United Contana?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Ewald Alphonso: ""We've got a strong strategy in place. Our competitive ed..."*)

### Węzeł `[42]`
Mówca: **Ewald Alphonso**
> ""I understand your concern. The risk is indeed there, but our experienced team of geologists and engineers have identified promising fields.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Ewald Alphonso: ""The odds are in our favor. And let's not forget the pote..."*)

### Węzeł `[43]`
Mówca: **Gus Manger**
> ""Ewald's got a point, Mr. President. Sure, there's some risk, but look at the upside -- Sordland could be energy resilient. I reckon that's a gamble worth taking, especially in these tough economic times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromotePlanned == true"*)

### Węzeł `[44]`
Mówca: **Narrator**
> "Ewald walked back over to the window. He stood there, silhouetted against the vast expanse of the gas fields."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "After a moment, he turned back to face us. His gaze was s..."*)

### Węzeł `[45]`
Mówca: **Ewald Alphonso**
> ""I wholeheartedly agree. The well-being of Narbel's citizens is a priority for Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Ewald Alphonso: ""With this investment, we could certainly allocate some f..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""An enticing proposition. However, I would like to know more about the risks involved. What if the excavations do not yield the expected results?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Ewald Alphonso: ""I understand your concern. The risk is indeed there, but..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Ewald Alphonso: ""Mr. Rayne, the foundation for a robust partnership is ri..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 0"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 0"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 0)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Ewald Alphonso: ""Mr. President, I believe we have the potential for a mut..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Ewald Alphonso: ""I appreciate your visit today, and despite our differenc..."*)

### Węzeł `[53]`
Mówca: **Ewald Alphonso**
> ""Your attitude and choices as President has prompted me to reflect on the significant gap that exists between us. Regrettably, this divide could pose challenges to the feasibility of any prospective business collaboration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Player: ""I'm not here for your approval, Alphonso. My priority is..."*)
  - -> `[190]` (*Player: ""Perhaps it's for the best, Mr. Alphonso. Your approach t..."*)
  - -> `[188]` (*Player: ""That's a shame. I still believe there's potential for us..."*)
  - -> `[189]` (*Player: ""I understand, Mr. Alphonso. It's important that we each ..."*)

### Węzeł `[54]`
Mówca: **Ewald Alphonso**
> ""Mr. President, I believe we have the potential for a mutually beneficial partnership. However, we need to align our objectives and expectations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Gus Manger: ""You know, Mr. President, if we can get the government in..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn03_Ribel_NewBFFLeadership = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn03_Ribel_NewBFFLeadership"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "PlayMusic("Reflection");"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Friendly = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Ewald_Friendly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "He approached Alphonso and leaned in to whisper something..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Neutral = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Ewald_Neutral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "He approached Alphonso and leaned in to whisper something..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Discontent = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Ewald_Discontent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "He approached Alphonso and leaned in to whisper something..."*)

### Węzeł `[59]`
Mówca: **Ewald Alphonso**
> ""We've got a strong strategy in place. Our competitive edge lies in the quality and efficiency of our production.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Ewald Alphonso: ""With this investment, we can further enhance our technol..."*)

### Węzeł `[60]`
Mówca: **Ewald Alphonso**
> ""The odds are in our favor. And let's not forget the potential rewards are substantial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Gus Manger: ""Ewald's got a point, Mr. President. Sure, there's some r..."*)

### Węzeł `[61]`
Mówca: **Ewald Alphonso**
> ""With this investment, we could certainly allocate some funds to improve the local infrastructure and create more jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Gus Manger: ""Mr. President, I've been thinking -- what if we tie Gaso..."*)

### Węzeł `[62]`
Mówca: **Ewald Alphonso**
> ""With this investment, we can further enhance our technologies and stay ahead of the competition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Gus Manger: ""Ewald and his team have been doing a hell of a job. Give..."*)

### Węzeł `[63]`
Mówca: **Gus Manger**
> ""Mr. President, I've been thinking -- what if we tie Gasom's growth to Narbel's development? Get the company to invest in the community, you know? That way, everybody wins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromotePlanned == true"*)

### Węzeł `[64]`
Mówca: **Gus Manger**
> ""Ewald and his team have been doing a hell of a job. Give them the right backing, and I reckon Gasom could give the big boys a run for their money. We just need to have a little faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromotePlanned == true"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_PromotePlanned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromotePlanned == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_PromotePlanned == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_PromotePlanned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_PromotePlanned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Ewald Alphonso: ""Mr. President, your administration's focus on a planned ..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_PromotePlanned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_PromotePlanned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Ewald Alphonso: ""Mr. President, your administration's commitment to a mar..."*)

### Węzeł `[68]`
Mówca: **Ewald Alphonso**
> ""Mr. President, your administration's focus on a planned economy resonates with our strategic vision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Ewald Alphonso: ""A government investment in our company aligns perfectly ..."*)

### Węzeł `[69]`
Mówca: **Ewald Alphonso**
> ""Mr. President, your administration's commitment to a market economy aligns with our vision for a competitive corporation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Ewald Alphonso: ""With a government investment, we can further liberalize ..."*)

### Węzeł `[70]`
Mówca: **Ewald Alphonso**
> ""A government investment in our company aligns perfectly with this approach. It's about strengthening Sordland's economy and becoming self-sufficient in energy production.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: ""I see the potential for us to drive Sordland's energy in..."*)
  - -> `[72]` (*Player: ""The Kingdom of Rizia's investment would reduce the risk ..."*)
  - -> `[73]` (*Player: ""I'm heavily interested in the idea of Gasom investing in..."*)
  - -> `[251]` (*Player: ""Liberalizing the energy market merely serves the interes..."*)

### Węzeł `[71]`
Mówca: **Ewald Alphonso**
> ""With a government investment, we can further liberalize the energy market, enhance our technologies, and compete globally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Player: ""A thriving market economy is the engine of prosperity an..."*)
  - -> `[74]` (*Player: ""I see the potential for us to drive Sordland's energy in..."*)
  - -> `[72]` (*Player: ""The Kingdom of Rizia's investment would reduce the risk ..."*)
  - -> `[73]` (*Player: ""I'm heavily interested in the idea of Gasom investing in..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The Kingdom of Rizia's investment would reduce the risk for us. However, we need to carefully consider the implications of sharing control with a foreign entity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Ewald Alphonso), `[71]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Ewald Alphonso: ""The partnership with Rizia is indeed a new venture for u..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm heavily interested in the idea of Gasom investing in Narbel's development. But we need concrete actions, not just words.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Ewald Alphonso), `[71]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.RuralDevelopment_Interest += 1"*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I see the potential for us to drive Sordland's energy independence. But we need to make sure this is a sustainable solution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Ewald Alphonso), `[71]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Ewald Alphonso: ""You bring up a valid point. We're dedicated to responsib..."*)

### Węzeł `[75]`
Mówca: **Ewald Alphonso**
> ""You bring up a valid point. We're dedicated to responsible resource extraction and have allocated a portion of the proposed investment for environmental mitigation measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Ewald Alphonso: ""Sustainability is a key part of our strategy.""*)

### Węzeł `[76]`
Mówca: **Ewald Alphonso**
> ""The partnership with Rizia is indeed a new venture for us, as a company, Anton. However, they have a vested interest in a stable gas supply.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Ewald Alphonso: ""Our agreement would be focused on operations and profits..."*)

### Węzeł `[77]`
Mówca: **Ewald Alphonso**
> ""You're right to demand specifics. With this investment, we aim to improve the living conditions in Narbel by creating more jobs, providing better housing for our workers, and initiating educational programs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Ewald Alphonso: ""Gasom is as committed to Narbel as it is to Sordland.""*)

### Węzeł `[78]`
Mówca: **Ewald Alphonso**
> ""Sustainability is a key part of our strategy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Gus Manger: ""Couldn't agree more, Mr. President. We've got to keep th..."*)

### Węzeł `[79]`
Mówca: **Ewald Alphonso**
> ""Our agreement would be focused on operations and profits, but not policy – Gasom would remain under Sordish control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Gus Manger: ""Mr. President, I know the Rizians want the same thing we..."*)

### Węzeł `[80]`
Mówca: **Ewald Alphonso**
> ""Gasom is as committed to Narbel as it is to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Gus Manger: ""It's about time Narbel got a leg up. Ewald's plan sounds..."*)

### Węzeł `[81]`
Mówca: **Gus Manger**
> ""Couldn't agree more, Mr. President. We've got to keep the big picture in mind, and that includes our environment. I trust Ewald and his team to handle this responsibly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Ewald Alphonso: ""If the Sordish government chooses to invest, it would ga..."*)

### Węzeł `[82]`
Mówca: **Gus Manger**
> ""Mr. President, I know the Rizians want the same thing we do. And the more energy partners we have, the better off we'll be. Plus, we'll keep the reins on Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Ewald Alphonso: ""If the Sordish government chooses to invest, it would ga..."*)

### Węzeł `[83]`
Mówca: **Gus Manger**
> ""It's about time Narbel got a leg up. Ewald's plan sounds solid to me. More jobs, better living conditions – that's a step in the right direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Ewald Alphonso: ""If the Sordish government chooses to invest, it would ga..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: ""We'll co-invest with Rizia. We'll share the costs and stakes." [-1 Government Budget]"]** — Mówca: **Player**
> ""We'll co-invest with Rizia. We'll share the costs and stakes.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true`
- **Kontekst wejściowy (poprzednik):** `[216]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia = true; BaseG..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA: ""We won't invest at this time. Let the Kingdom and other foreign investors contribute.""]** — Mówca: **Player**
> ""We won't invest at this time. Let the Kingdom and other foreign investors contribute.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[216]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment = true; Bas..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""We're investing alone. Sordland will provide the majority of funds, and Gus will tell Rizia to back off." [-2 Government Budget]"]** — Mówca: **Player**
> ""We're investing alone. Sordland will provide the majority of funds, and Gus will tell Rizia to back off.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true`
- **Kontekst wejściowy (poprzednik):** `[216]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone = ..."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "After a moment, he turned back to face us. His gaze was steady, the expectation clear in his eyes. The time had come to make a decision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Ewald Alphonso: ""Well, Mr. President? Will Gasom and Sordland make histor..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone = true; 
BaseGame.Policy_Economy_Gasom_LargeStateInvestment = true;
BaseGameSupport.Journal_Turn03_Gasom_LargeSordlandInvest = true;
BaseGame.GovernmentBudget -= 2; BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 3;
BaseGame.Public_Opinion += 1;
BaseGame.EconomyDirection_Scale -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] = true;
Variable["BaseGame.Policy_Economy_Gasom_LargeStateInvestment"] = true;
Variable["BaseGameSupport.Journal_Turn03_Gasom_LargeSordlandInvest"] = true;
Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;
Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 3;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;
Variable["BaseGame.EconomyDirection_Scale"] = Variable["BaseGame.EconomyDirection_Scale"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Gasom_LargeInvestmentPrais..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia = true;
BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment = true; BaseGameSupport.Journal_Turn03_Gasom_CoInvestRizia = true;
BaseGame.GovernmentBudget -= 1; 
BaseGame.EconomyDirection_Scale -= 1;
BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] = true;
Variable["BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment"] = true;
Variable["BaseGameSupport.Journal_Turn03_Gasom_CoInvestRizia"] = true;
Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;
Variable["BaseGame.EconomyDirection_Scale"] = Variable["BaseGame.EconomyDirection_Scale"] - 1;
Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Gasom_CoInvestmentSkeptici..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment = true; BaseGameSupport.Journal_Turn03_Gasom_RiziaAloneInvest = true; BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 2;
BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] = true;
Variable["BaseGameSupport.Journal_Turn03_Gasom_RiziaAloneInvest"] = true;
Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 2;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Gasom_RiziaInvestmentCriti..."*)

### Węzeł `[91]`
Mówca: **Gus Manger**
> ""Before we dive into the celebrations, I've allocated time during this meeting for President Rayne to discuss any concerns regarding Gasom's treatment of its workers and its effects on Narbel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Gus Manger: ""The Labor Union, along with the Communist Party of Sordl..."*)

### Węzeł `[92]`
Mówca: **Ewald Alphonso**
> ""Your decision shows a commitment to Sordland's energy independence. We won't let you down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Gus Manger: ""That's a bold move, Mr. President. But I reckon it's the..."*)

### Węzeł `[93]`
Mówca: **Ewald Alphonso**
> ""A joint investment? A wise choice. It ensures steady funds for Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Gus Manger: ""I like the way you think, Mr. President. Sharing the cos..."*)

### Węzeł `[94]`
Mówca: **Ewald Alphonso**
> ""I understand your reservations. We'll continue to serve Sordland's energy needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Gus Manger: ""Well, Mr. President, you've always been one to play it s..."*)

### Węzeł `[95]`
Mówca: **Gus Manger**
> ""That's a bold move, Mr. President. But I reckon it's the right one. Gasom's success will be Sordland's success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Gus Manger: ""The worried workers will have no fears about job securit..."*)

### Węzeł `[96]`
Mówca: **Gus Manger**
> ""I like the way you think, Mr. President. Sharing the costs with Rizia reduces our risk and strengthens our ties. It's a smart move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Co-investing with a kingdom to fund a cr..."*)

### Węzeł `[97]`
Mówca: **Gus Manger**
> ""Well, Mr. President, you've always been one to play it safe. I guess we'll just have to make do and see how things turn out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Letting another nation buy a critical en..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The wages of Gasom blue-collar workers need to be increased. They are the backbone of your operations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[275]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3"*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I expect Gasom to contribute significantly to local charities, to aid in the city's recovery.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[275]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 2"*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The workers of Gasom need better housing, access to healthcare, and opportunities for education. As the leading industry there, Gasom can't ignore its responsibility.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[275]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.RuralDevelopment_Interest += 1"*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We've covered a lot today. I believe we can wrap up the meeting now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Narrator), `[275]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Ewald Alphonso: ""Very well, Mr. President.""*)

### Węzeł `[102]`
Mówca: **Ewald Alphonso**
> ""President Rayne, I appreciate your concerns about Narbel. Rest assured, we are constantly evaluating our impact on the community and are looking for ways to improve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Ewald Alphonso: ""We are not blind to the socio-economic conditions here. ..."*)

### Węzeł `[103]`
Mówca: **Ewald Alphonso**
> ""Mr. President, while I acknowledge your concerns, Gasom's primary responsibility is to its shareholders and the economic stability of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Ewald Alphonso: ""It's a challenging task to balance the needs of our shar..."*)

### Węzeł `[104]`
Mówca: **Ewald Alphonso**
> ""A good point. I see the potential for Gasom to play a larger role in supporting our workers and the community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBene..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3)"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Ewald Alphonso: ""I fully agree that we must do more for our workers. Thei..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 2"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 2"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 2)"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Ewald Alphonso: ""President Rayne, the welfare of our workers is certainly..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Ewald Alphonso: ""Mr. President, while I understand your concerns, we must..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 4"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 4)"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Ewald Alphonso: ""A good point. I see the potential for Gasom to play a la..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Ewald Alphonso: ""President Rayne, I appreciate your concerns about Narbel..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Ewald Alphonso: ""Mr. President, while I acknowledge your concerns, Gasom'..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 2"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 2)"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Ewald Alphonso: ""I share your concerns about Narbel. Gasom is committed t..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 1"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 1"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 1)"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Ewald Alphonso: ""President Rayne, I understand the role Gasom could play ..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Ewald Alphonso: ""Mr. President, Gasom already contributes significantly t..."*)

### Węzeł `[123]`
Mówca: **Gus Manger**
> ""It's been a long day. We've got a lot to think about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "Suddenly, the meeting was interrupted. The quiet murmur o..."*)

### Węzeł `[124]`
Mówca: **Ewald Alphonso**
> ""President Rayne, the welfare of our workers is certainly important. We'll continue to review their conditions and remuneration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Ewald Alphonso: ""We understand the importance of fair compensation. Discu..."*)

### Węzeł `[125]`
Mówca: **Ewald Alphonso**
> ""Mr. President, while I understand your concerns, we must consider the financial implications of such actions. I cannot really promise you anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Ewald Alphonso: ""We must indeed be mindful of the economic realities. We ..."*)

### Węzeł `[126]`
Mówca: **Ewald Alphonso**
> ""I fully agree that we must do more for our workers. Their welfare is a priority for Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages = tru..."*)

### Węzeł `[127]`
Mówca: **Ewald Alphonso**
> ""President Rayne, I understand the role Gasom could play in supporting local charities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Ewald Alphonso: ""Donating more is an interesting idea. It's something we ..."*)

### Węzeł `[128]`
Mówca: **Ewald Alphonso**
> ""Mr. President, Gasom already contributes significantly to Sordland's economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Ewald Alphonso: ""Our contributions to Sordland's economy are substantial...."*)

### Węzeł `[129]`
Mówca: **Gus Manger**
> ""Well, this is promising. Ewald's commitment to these initiatives should alleviate some of our concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[130]`
Mówca: **Gus Manger**
> ""Gentlemen, it's clear that we all share the goal of improving the situation in Narbel. Let's continue working together to make that happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player: ""Agreed, Gus. Mr. Alphonso, we expect to see tangible imp..."*)
  - -> `[139]` (*Player: ""Gus, all the talk in the world won't change the situatio..."*)

### Węzeł `[131]`
Mówca: **Gus Manger**
> ""We're all in agreement that we should do more for the local community. Let's move forward with that in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Player: ""That's true. And I hope that Gasom is ready to make some..."*)
  - -> `[156]` (*Player: ""We're all in agreement, Gus. Now it's time to turn that ..."*)

### Węzeł `[132]`
Mówca: **Ewald Alphonso**
> ""I will personally oversee initiatives to provide private housing, health, and education support for our blue-collar workers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player: ""That's reassuring to hear. I trust that you'll follow th..."*)
  - -> `[137]` (*Player: ""These are significant steps. I look forward to seeing th..."*)

### Węzeł `[133]`
Mówca: **Ewald Alphonso**
> ""I will personally ensure that we review their salaries and work towards providing them with competitive compensation immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player: ""I'm relieved to hear that. A fair wage is the least we c..."*)
  - -> `[165]` (*Player: ""Promises are a start, Ewald. But the people need actions..."*)

### Węzeł `[134]`
Mówca: **Ewald Alphonso**
> ""I share your concerns about Narbel. Gasom is committed to implementing sustainable practices that will lessen our impact on the environment and the community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation = true; B..."*)

### Węzeł `[135]`
Mówca: **Ewald Alphonso**
> ""Personally, I am committed to supporting local charities to enhance our community engagement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Player: ""We need to do more than reduce harm. Our goal should be ..."*)
  - -> `[169]` (*Player: ""Charitable donations are commendable. But we must addres..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's reassuring to hear. I trust that you'll follow through on these commitments.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Gus Manger: ""Well, this is promising. Ewald's commitment to these ini..."*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""These are significant steps. I look forward to seeing these changes implemented swiftly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Gus Manger: ""Ewald, your personal commitment to these initiatives spe..."*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Agreed, Gus. Mr. Alphonso, we expect to see tangible improvements in this city.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Ewald Alphonso: ""Well, Mr. President, we're committed to--""*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gus, all the talk in the world won't change the situation in Narbel. We need concrete action from Gasom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Ewald Alphonso: ""We understand the need for action, Mr. President, but al..."*)

### Węzeł `[140]`
Mówca: **Gus Manger**
> ""Ewald, your personal commitment to these initiatives speaks volumes. This could be a turning point for Gasom and for Narbel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[141]`
Mówca: **Narrator**
> "Suddenly, the meeting was interrupted. The quiet murmur of a conversation from outside the room grew louder, followed by the sound of hurried footsteps."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Narrator: "A member of the private security team entered the room, h..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation = true; BaseGameSupport.Journal_Turn03_GasomWelfare_NarbelCharity = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] = true;
Variable["BaseGameSupport.Journal_Turn03_GasomWelfare_NarbelCharity"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Ewald Alphonso: ""Personally, I am committed to supporting local charities..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages = true; BaseGameSupport.Journal_Turn03_GasomWelfare_MoreBlueSalary = true;
BaseGame.RuralDevelopment_Interest += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] = true;
Variable["BaseGameSupport.Journal_Turn03_GasomWelfare_MoreBlueSalary"] = true;
Variable["BaseGame.RuralDevelopment_Interest"] = Variable["BaseGame.RuralDevelopment_Interest"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Ewald Alphonso: ""I will personally ensure that we review their salaries a..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits = true; BaseGameSupport.Journal_Turn03_GasomWelfare_EducationHealthHousing = true;
BaseGame.RuralDevelopment_Interest += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] = true;
Variable["BaseGameSupport.Journal_Turn03_GasomWelfare_EducationHealthHousing"] = true;
Variable["BaseGame.RuralDevelopment_Interest"] = Variable["BaseGame.RuralDevelopment_Interest"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Ewald Alphonso: ""I will personally oversee initiatives to provide private..."*)

### Węzeł `[145]`
Mówca: **Ewald Alphonso**
> ""Gentlemen, it seems we have an unexpected situation outside. Some protestors from the Labor Union have blocked the main vehicular exits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Ewald Alphonso: ""Katarina Horten and Denis Stahler seem to be leading the..."*)

### Węzeł `[146]`
Mówca: **Ewald Alphonso**
> ""We are not blind to the socio-economic conditions here. We're deeply invested in this community and are committed to doing our part.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Gus Manger: ""Gentlemen, it's clear that we all share the goal of impr..."*)

### Węzeł `[147]`
Mówca: **Ewald Alphonso**
> ""It's a challenging task to balance the needs of our shareholders with our responsibilities. I cannot promise you anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Gus Manger: ""Gentlemen, it's clear that we all share the goal of impr..."*)

### Węzeł `[148]`
Mówca: **Ewald Alphonso**
> ""We understand the importance of fair compensation. Discussions are ongoing on how to best support our hardworking employees. That is all I can say for the time being.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Gus Manger: ""Both of you make good points. It's a fine line between f..."*)

### Węzeł `[149]`
Mówca: **Ewald Alphonso**
> ""We must indeed be mindful of the economic realities. We are striving to make decisions that are financially sound and sustainable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Gus Manger: ""Both of you make good points. It's a fine line between f..."*)

### Węzeł `[150]`
Mówca: **Gus Manger**
> ""Both of you make good points. It's a fine line between fulfilling our responsibilities and ensuring economic stability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player: ""Indeed Gus, we have to ensure that we don't jeopardize t..."*)
  - -> `[154]` (*Player: ""It's a fine line indeed. But that doesn't absolve us, or..."*)

### Węzeł `[151]`
Mówca: **Ewald Alphonso**
> ""Donating more is an interesting idea. It's something we will consider.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Gus Manger: ""We're all in agreement that we should do more for the lo..."*)

### Węzeł `[152]`
Mówca: **Ewald Alphonso**
> ""Our contributions to Sordland's economy are substantial. Our focus must remain on maintaining that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Gus Manger: ""We're all in agreement that we should do more for the lo..."*)

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Indeed Gus, we have to ensure that we don't jeopardize the economic stability of Sordland. But we also can't ignore the plight of Narbel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Ewald Alphonso: ""As I mentioned before, we're always considering how we c..."*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's a fine line indeed. But that doesn't absolve us, or Gasom, of our responsibilities towards the people of Narbel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Ewald Alphonso: ""Mr. President, I assure you that Gasom takes its respons..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's true. And I hope that Gasom is ready to make some significant changes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Ewald Alphonso: ""I understand, Anton. At Gasom, we are committed to reduc..."*)

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We're all in agreement, Gus. Now it's time to turn that agreement into action.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Ewald Alphonso: ""I agree, it's time for us to--""*)

### Węzeł `[157]`
Mówca: **Ewald Alphonso**
> ""Well, Mr. President, we're committed to--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention = true"*)

### Węzeł `[158]`
Mówca: **Ewald Alphonso**
> ""We understand the need for action, Mr. President, but also--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention = true"*)

### Węzeł `[159]`
Mówca: **Ewald Alphonso**
> ""As I mentioned before, we're always considering how we can--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[160]`
Mówca: **Ewald Alphonso**
> ""Mr. President, I assure you that Gasom takes its responsibilities--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[161]`
Mówca: **Ewald Alphonso**
> ""I understand, Anton. At Gasom, we are committed to reducing harm and contributing to the--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[162]`
Mówca: **Ewald Alphonso**
> ""I agree, it's time for us to--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[163]`
Mówca: **Gus Manger**
> ""We are all on the same page here. Let's not lose sight of that as we move forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm relieved to hear that. A fair wage is the least we can provide for the hardworking people of this country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Gus Manger: ""We are all on the same page here. Let's not lose sight o..."*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Promises are a start, Ewald. But the people need actions, not words. I look forward to seeing concrete changes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Gus Manger: ""Ewald, your personal commitment to these initiatives spe..."*)

### Węzeł `[166]`
Mówca: **Gus Manger**
> ""Ewald, your personal commitment to these initiatives speaks volumes. This could be a turning point for Gasom and for Narbel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[167]`
Mówca: **Gus Manger**
> ""This is still promising. Ewald's commitment to these initiatives should alleviate some of our concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Ewald Alphonso: ""Of course, we are fully committed to ensuring our operat..."*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We need to do more than reduce harm. Our goal should be a better Narbel, not just a less bad one.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Gus Manger: ""This is still promising. Ewald's commitment to these ini..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Charitable donations are commendable. But we must address the source of the harm, not just mitigate its effects.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Gus Manger: ""I couldn't agree more. It's high time we took our respon..."*)

### Węzeł `[170]`
Mówca: **Gus Manger**
> ""I couldn't agree more. It's high time we took our responsibilities to Narbel seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Ewald Alphonso: ""Of course, we are fully committed to ensuring our operat..."*)

### Węzeł `[171]`
Mówca: **Ewald Alphonso**
> ""Of course, we are fully committed to ensuring our operations are-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true) && BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone =..."*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true) && BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true  or  Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true)  and  Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly = true"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true) && BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true  or  Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true)  and  Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true || B..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true || BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true) && BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true || B..."*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true ||..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true || BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true) && BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 0`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true  or  Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true)  and  Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Neutral = true"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true || BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true) && BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true  or  Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true)  and  Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Discontent = true"*)

### Węzeł `[178]`
Mówca: **Narrator**
> "He approached Alphonso and leaned in to whisper something in his ear. Ewald nodded solemnly, his gaze meeting mine with a serious intensity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Ewald Alphonso: ""Gentlemen, it seems we have an unexpected situation outs..."*)

### Węzeł `[179]`
Mówca: **Gus Manger**
> ""Well, that's a pickle. What's our move, Ewald?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Ewald Alphonso: ""I have a helicopter ready. We can leave undetected and a..."*)

### Węzeł `[180]`
Mówca: **Ewald Alphonso**
> ""I have a helicopter ready. We can leave undetected and avoid the chaos and potential danger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Player: ""A helicopter might be the safer option.""*)
  - -> `[262]` (*Player: ""I think we should face the crowd head-on.""*)
  - -> `[263]` (*Player: ""Is there no other way out?""*)

### Węzeł `[181]`
Mówca: **Serge Wolkner**
> ""Mr. President, I have discussed the situation with the Presidential Guard and the police security. They are advising us not to go out the way we came in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Serge Wolkner: ""More police are on the way.""*)

### Węzeł `[182]`
Mówca: **Narrator**
> "Serge Wolkner rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Serge Wolkner: ""Mr. President, I have discussed the situation with the P..."*)

### Węzeł `[183]`
Mówca: **Narrator**
> "Ewald looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3"*)

### Węzeł `[184]`
Mówca: **Serge Wolkner**
> ""You must make a decision, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "Everyone waited. The tense silence of the room stood in s..."*)

### Węzeł `[185]`
Mówca: **Narrator**
> "As our motorcade made its way through the Ornobel district, I noted the neighborhood's state of disrepair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "The roads were bumpy and marked by potholes, while the bu..."*)

### Węzeł `[186]`
Mówca: **Narrator**
> "Serge skillfully parked the car, bringing our journey to a smooth and elegant conclusion. Gus greeted us warmly as we stepped out of the vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Gus Manger: ""Good day, President Rayne. Welcome to Gasom's Narbel ope..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RuralDevelopment_Interest += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.RuralDevelopment_Interest"] = Variable["BaseGame.RuralDevelopment_Interest"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 4"*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's a shame. I still believe there's potential for us to work together in some capacity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Ewald Alphonso: ""I appreciate your optimism, Mr. President. While this pa..."*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand, Mr. Alphonso. It's important that we each stay true to our principles.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Ewald Alphonso: ""Indeed, Mr. President. Our principles are what guide us.""*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Perhaps it's for the best, Mr. Alphonso. Your approach to business doesn't align with my vision for Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Ewald Alphonso: ""We each have our roles to play for Sordland. Let us each..."*)

### Węzeł `[191]`
Mówca: **Ewald Alphonso**
> ""We each have our roles to play for Sordland. Let us each do what we believe is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Gus Manger: ""Hold on, gentlemen.""*)

### Węzeł `[192]`
Mówca: **Ewald Alphonso**
> ""I appreciate your optimism, Mr. President. While this particular deal may not have worked out, I remain open to future collaborations that could benefit both our interests and Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Gus Manger: ""You're right, Mr. President. There's always potential fo..."*)

### Węzeł `[193]`
Mówca: **Ewald Alphonso**
> ""Indeed, Mr. President. Our principles are what guide us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Ewald Alphonso: ""If they don't point us in the same direction, then it's ..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 1"*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth >= 1)"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Ewald Alphonso: ""As a further gesture of goodwill, would you consider mak..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Ewald Alphonso: ""Ready to make history together? Set our differences asid..."*)

### Węzeł `[197]`
Mówca: **Ewald Alphonso**
> ""As a further gesture of goodwill, would you consider making a personal donation to the Alphonso Foundation? It's a cause close to my heart, focusing on providing shelter for the homeless in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player: ""Alright, let's proceed with the deal. The EPA restrictio..."*)
  - -> `[198]` (*Player: ""Gentlemen, after careful consideration, I've decided to ..."*)

### Węzeł `[198]`
**[WYBÓR GRACZA: ""Gentlemen, after careful consideration, I've decided to step away from this deal." [No Deal Path]"]** — Mówca: **Player**
> ""Gentlemen, after careful consideration, I've decided to step away from this deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[197]` (Ewald Alphonso), `[259]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[199]`
**[WYBÓR GRACZA: ""Alright, let's proceed with the deal. The EPA restrictions will remain as they are, and I'll personally contribute to your cause for the homeless." [Deal Path, -1 Personal Wealth]"]** — Mówca: **Player**
> ""Alright, let's proceed with the deal. The EPA restrictions will remain as they are, and I'll personally contribute to your cause for the homeless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[197]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth -= 1; BaseGame.Relations_Ewald_Do..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth -= 1;
BaseGame.Relations_Ewald_DonatedToFoundation = true;
BaseGame.Relations_Ewald_PromiseNotHarsherEPA = true;
BaseGame.Decision_Turn04_FoundationDonation_SmallSum = true;
BaseGameSupport.Journal_Turn03_AlphonsoFoundation_DonatedSmall = true;
BaseGameSupport.News_Turn03_LT_PresidentAFDonation = true;
BaseGameSupport.News_Turn03_R_PresidentAFDonation = true;
BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;
Variable["BaseGame.Relations_Ewald_DonatedToFoundation"] = true;
Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] = true;
Variable["BaseGame.Decision_Turn04_FoundationDonation_SmallSum"] = true;
Variable["BaseGameSupport.Journal_Turn03_AlphonsoFoundation_DonatedSmall"] = true;
Variable["BaseGameSupport.News_Turn03_LT_PresidentAFDonation"] = true;
Variable["BaseGameSupport.News_Turn03_R_PresidentAFDonation"] = true;
Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Gus Manger: ""Amazing! I knew you two could make it work.""*)

### Węzeł `[201]`
Mówca: **Ewald Alphonso**
> ""If they don't point us in the same direction, then it's best we part ways here. I wish you all the best in your endeavors for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Gus Manger: ""Wait. Gentlemen, let's not let a single disagreement def..."*)

### Węzeł `[202]`
Mówca: **Gus Manger**
> ""Hold on, gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Gus Manger: ""I understand that tensions are high right now. But I hav..."*)

### Węzeł `[203]`
Mówca: **Gus Manger**
> ""You're right, Mr. President. There's always potential for collaboration. Let's not close the door just yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Gus Manger: ""I understand that tensions are high right now. But I hav..."*)

### Węzeł `[204]`
Mówca: **Gus Manger**
> ""Wait. Gentlemen, let's not let a single disagreement define our relationship. There's a bigger picture here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Gus Manger: ""I understand that tensions are high right now. But I hav..."*)

### Węzeł `[205]`
Mówca: **Gus Manger**
> ""I understand that tensions are high right now. But I have faith that we can find a solution that benefits everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Gus Manger: ""However, for that to happen, I need to know: Mr. Preside..."*)

### Węzeł `[206]`
Mówca: **Gus Manger**
> ""However, for that to happen, I need to know: Mr. President, do you trust my judgement?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Player: ""I trust your advice. You've proven yourself a reliable a..."*)
  - -> `[209]` (*Player: ""Your judgement has been questionable at times. But I'm w..."*)
  - -> `[207]` (*Player: ""Gus, I respect you, but I can't trust your judgement in ..."*)
  - -> `[348]` (*Player: ""Don’t forget, the state stands above you all. Nothing ma..."*)

### Węzeł `[207]`
**[WYBÓR GRACZA: ""Gus, I respect you, but I can't trust your judgement in this matter. You seem to have a fundamental bias on this." [Reject Deal]"]** — Mówca: **Player**
> ""Gus, I respect you, but I can't trust your judgement in this matter. You seem to have a fundamental bias on this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[206]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Gus Manger: ""Fair enough, Mr. President. I gave it my all.""*)

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I trust your advice. You've proven yourself a reliable ally and I believe we can find a way forward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[206]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Gus Manger: ""Thank you, Mr. President. I propose a compromise.""*)

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your judgement has been questionable at times. But I'm willing to hear you out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[206]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Gus Manger: ""Thank you, Mr. President. I propose a compromise.""*)

### Węzeł `[210]`
Mówca: **Gus Manger**
> ""Thank you, Mr. President. I propose a compromise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Gus Manger: ""If you promise not to tighten the current restrictions o..."*)

### Węzeł `[211]`
Mówca: **Gus Manger**
> ""If you promise not to tighten the current restrictions of the Energy Protection Act, we can reconsider our stance and keep the deal on the table.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Ewald Alphonso: ""Mr. President, I'm giving you a chance to prove your com..."*)

### Węzeł `[212]`
Mówca: **Ewald Alphonso**
> ""Mr. President, I'm giving you a chance to prove your commitment to the people of Sordland and to our shared future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Ewald Alphonso: ""I hope you'll consider our offer carefully. This could b..."*)

### Węzeł `[213]`
Mówca: **Ewald Alphonso**
> ""I hope you'll consider our offer carefully. This could be the beginning of a fruitful partnership, or the end of a potential alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 1"*)

### Węzeł `[214]`
Mówca: **Gus Manger**
> ""Fair enough, Mr. President. I gave it my all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Ewald Alphonso: ""We both tried, it seems. Still, I appreciate the discuss..."*)

### Węzeł `[215]`
Mówca: **Ewald Alphonso**
> ""We both tried, it seems. Still, I appreciate the discussion, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Gus Manger: ""I'll leverage my Rizian contacts to finalize the deal.""*)

### Węzeł `[216]`
Mówca: **Ewald Alphonso**
> ""Well, Mr. President? Will Gasom and Sordland make history or not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true"*)

### Węzeł `[217]`
Mówca: **Ewald Alphonso**
> ""Mr. Rayne, the foundation for a robust partnership is right here. It's high time we shift our focus towards sealing this deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Ewald Alphonso: "“If we raise a minority investment, it would allow us to ..."*)

### Węzeł `[218]`
**[WYBÓR GRACZA: ""You've made a compelling case. Let's get this deal on the road. I can assure you that the EPA restrictions won't get any stricter." [Deal Path]"]** — Mówca: **Player**
> ""You've made a compelling case. Let's get this deal on the road. I can assure you that the EPA restrictions won't get any stricter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_PromiseNotHarsherEPA = true; Bas..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_PromiseNotHarsherEPA = true;
BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] = true;
Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Gus Manger: ""I'm glad you're on board, Mr. President.""*)

### Węzeł `[220]`
Mówca: **Gus Manger**
> ""I'm glad you're on board, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Ewald Alphonso: ""Mr. President, your assurances on the EPA front are much..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true"*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true)"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: ""We're investing alone. Sordland will provide the majorit..."*)
  - -> `[84]` (*Player: ""We'll co-invest with Rizia. We'll share the costs and st..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: ""We're investing alone. Sordland will provide the majorit..."*)
  - -> `[84]` (*Player: ""We'll co-invest with Rizia. We'll share the costs and st..."*)
  - -> `[85]` (*Player: ""We won't invest at this time. Let the Kingdom and other ..."*)

### Węzeł `[224]`
Mówca: **Ewald Alphonso**
> ""If the Sordish government chooses to invest, it would gain a voice in the broader company decisions, even as a minority stakeholder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Ewald Alphonso: ""The government could either liquidate its shares at a fu..."*)

### Węzeł `[225]`
Mówca: **Ewald Alphonso**
> ""The government could either liquidate its shares at a future date or continue to reap the long-term profits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Gus Manger: ""A beneficial arrangement for all parties.""*)

### Węzeł `[226]`
Mówca: **Gus Manger**
> ""A beneficial arrangement for all parties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "Ewald walked back over to the window. He stood there, sil..."*)

### Węzeł `[227]`
Mówca: **Ewald Alphonso**
> ""Excellent, Mr. President! Your support for the homeless cause is commendable. Together, we will ensure a promising future for Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Ewald Alphonso: ""If the Sordish government chooses to invest, it would ga..."*)

### Węzeł `[228]`
Mówca: **Ewald Alphonso**
> ""Mr. President, your assurances on the EPA front are much appreciated. This partnership is going to bring great benefits for all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Ewald Alphonso: ""If the Sordish government chooses to invest, it would ga..."*)

### Węzeł `[229]`
Mówca: **Gus Manger**
> ""You know, Mr. President, if we can get the government in on this, it's a win-win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Gus Manger: ""Not only does Gasom continue to operate and grow, but it..."*)

### Węzeł `[230]`
Mówca: **Gus Manger**
> ""Not only does Gasom continue to operate and grow, but it also strengthens the state's energy security and economic power. We just need a little risk appetite, that's all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Ewald Alphonso: ""Are you ready, Mr. President, to take on the risks that ..."*)

### Węzeł `[231]`
Mówca: **Ewald Alphonso**
> ""Are you ready, Mr. President, to take on the risks that come with ensuring one of Sordland's most valuable energy companies continues to operate and grow?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Ewald Alphonso: ""Are you ready to make your government stronger?""*)

### Węzeł `[232]`
Mówca: **Ewald Alphonso**
> ""Are you ready to make your government stronger?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Player: ""Mr. Alphonso, are you suggesting that we should risk the..."*)
  - -> `[235]` (*Player: ""I'm all for taking calculated risks. But we need to be s..."*)
  - -> `[233]` (*Player: ""Don't you think there's a way we can ensure Gasom's grow..."*)
  - -> `[234]` (*Player: ""What kind of assurances can you provide that this will p..."*)

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't you think there's a way we can ensure Gasom's growth without putting the government at risk?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Ewald Alphonso: ""Gus, would you like to answer that?""*)

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What kind of assurances can you provide that this will pay off in the long term, President Alphonso?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Ewald Alphonso: ""Mr. President, in business, there are no guarantees. But..."*)

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm all for taking calculated risks. But we need to be sure that the benefits outweigh the potential losses.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Ewald Alphonso: ""Of course, Mr. President. I wouldn't propose a strategy ..."*)

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Alphonso, are you suggesting that we should risk the treasury of Sordland for the growth of a single company?"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Ewald Alphonso: ""Not at all, Mr. President. I'm suggesting that supportin..."*)

### Węzeł `[237]`
Mówca: **Ewald Alphonso**
> ""Not at all, Mr. President. I'm suggesting that supporting Gasom's growth could significantly contribute to Sordland's overall economic stability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Gus Manger: ""Ewald is right. We're not talking about risking the econ..."*)

### Węzeł `[238]`
Mówca: **Ewald Alphonso**
> ""Of course, Mr. President. I wouldn't propose a strategy that I didn't believe would be beneficial for both Gasom and Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Gus Manger: ""As someone who's been in the energy business for decades..."*)

### Węzeł `[239]`
Mówca: **Ewald Alphonso**
> ""Gus, would you like to answer that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Gus Manger: ""Absolutely. I believe that by working together with Rizi..."*)

### Węzeł `[240]`
Mówca: **Ewald Alphonso**
> ""Mr. President, in business, there are no guarantees. But I can assure you that we at Gasom are committed to doing everything in our power to ensure this deal pays off for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Gus Manger: ""I can't give you a guarantee. But I can tell you that I ..."*)

### Węzeł `[241]`
Mówca: **Gus Manger**
> ""Ewald is right. We're not talking about risking the economy. We're discussing an investment that has the potential to pay significant dividends for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Ewald Alphonso: ""Mr. President, have you ever considered that the future ..."*)

### Węzeł `[242]`
Mówca: **Gus Manger**
> ""As someone who's been in the energy business for decades, I can tell you that this deal is solid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Ewald Alphonso: ""Mr. President, have you ever considered that the future ..."*)

### Węzeł `[243]`
Mówca: **Gus Manger**
> ""Absolutely. I believe that by working together with Rizia, we can find a shared investment solution that promotes Gasom's growth while minimizing any potential risk to the government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Ewald Alphonso: ""Mr. President, have you ever considered that the future ..."*)

### Węzeł `[244]`
Mówca: **Gus Manger**
> ""I can't give you a guarantee. But I can tell you that I trust President Alphonso, and I believe in this deal. Sometimes, you have to take a leap of faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Ewald Alphonso: ""Mr. President, have you ever considered that the future ..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RuralDevelopment_Interest += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.RuralDevelopment_Interest"] = Variable["BaseGame.RuralDevelopment_Interest"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Ewald Alphonso: ""I wholeheartedly agree. The well-being of Narbel's citiz..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RuralDevelopment_Interest += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.RuralDevelopment_Interest"] = Variable["BaseGame.RuralDevelopment_Interest"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Ewald Alphonso: ""You're right to demand specifics. With this investment, ..."*)

### Węzeł `[247]`
Mówca: **Ewald Alphonso**
> ""Mr. President, have you ever considered that the future of Sordland might rest not on avoiding risks, but about embracing them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Ewald Alphonso: ""That our greatest potential might lie not in the safety ..."*)

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand your point. However, the stakes are too high for us to gamble on uncertainty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[250]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Ewald Alphonso: ""If the Sordish government chooses to invest, it would ga..."*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I have. And I believe that embracing uncertainty is a part of leadership. We must be bold in our decisions for the future of Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[250]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Ewald Alphonso: ""If the Sordish government chooses to invest, it would ga..."*)

### Węzeł `[250]`
Mówca: **Ewald Alphonso**
> ""That our greatest potential might lie not in the safety of what we know, but in the uncertainty of what we might discover?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Player: ""Running the state is not like running your company Alpho..."*)
  - -> `[249]` (*Player: ""I have. And I believe that embracing uncertainty is a pa..."*)
  - -> `[248]` (*Player: ""I understand your point. However, the stakes are too hig..."*)
  - -> `[330]` (*Player: ""We must make decisions based on what is best for Sordlan..."*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Liberalizing the energy market merely serves the interests of the wealthy elites. What we need is a comprehensive nationalization of the energy sector to ensure it serves the people, not profit.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Ewald Alphonso: ""While I respect your perspective, Mr. President, I firml..."*)

### Węzeł `[252]`
Mówca: **Ewald Alphonso**
> ""While I respect your perspective, Mr. President, I firmly believe that the power of the free market, coupled with appropriate regulation, can drive both progress and equity. It's not an 'us versus them' situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Gus Manger: ""We must also consider the economic realities and global ..."*)

### Węzeł `[253]`
Mówca: **Gus Manger**
> ""We must also consider the economic realities and global competitiveness. A balance between public ownership and market forces could be the key.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Ewald Alphonso: ""If the Sordish government chooses to invest, it would ga..."*)

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A thriving market economy is the engine of prosperity and innovation. I believe in Gasom's potential to compete and succeed under these principles.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[255]`
Mówca: **Ewald Alphonso**
> ""I'm glad we see eye to eye on this. With your support, I am confident that Gasom will be able to chart a prosperous future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Gus Manger: ""Your words are reassuring, Mr. President. Let's harness ..."*)

### Węzeł `[256]`
Mówca: **Gus Manger**
> ""Your words are reassuring, Mr. President. Let's harness the power of the free market to elevate Gasom and, in turn, the entire Sordish economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Ewald Alphonso: ""If the Sordish government chooses to invest, it would ga..."*)

### Węzeł `[257]`
Mówca: **Gus Manger**
> ""I understand, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Ewald Alphonso: ""It's unfortunate we couldn't bridge our differences. Non..."*)

### Węzeł `[258]`
Mówca: **Ewald Alphonso**
> ""It's unfortunate we couldn't bridge our differences. Nonetheless, we respect your stance and value the time spent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Gus Manger: ""I'll leverage my Rizian contacts to finalize the deal.""*)

### Węzeł `[259]`
Mówca: **Ewald Alphonso**
> ""Ready to make history together? Set our differences aside and work together for the energy independence of our nation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player: ""You've made a compelling case. Let's get this deal on th..."*)
  - -> `[198]` (*Player: ""Gentlemen, after careful consideration, I've decided to ..."*)

### Węzeł `[260]`
Mówca: **Ewald Alphonso**
> ""Katarina Horten and Denis Stahler seem to be leading the group. It would be difficult to leave the way we came without causing trouble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Gus Manger: ""Well, that's a pickle. What's our move, Ewald?""*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A helicopter might be the safer option.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Ewald Alphonso: ""I will give the order to ready it. We can fly to the Blu..."*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I think we should face the crowd head-on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Ewald Alphonso: ""That is your prerogative, Mr. President. Following the v..."*)

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is there no other way out?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Ewald Alphonso: ""Trust me, I know this place well. The only other way out..."*)

### Węzeł `[264]`
Mówca: **Gus Manger**
> ""Mr. President, I advise you to leave via helicopter just in case. I can stay back and update the crowd on the discussions today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "Serge Wolkner rushed in."*)

### Węzeł `[265]`
Mówca: **Ewald Alphonso**
> ""I will give the order to ready it. We can fly to the Blue Mansion in Lachaven.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Gus Manger: ""Mr. President, I advise you to leave via helicopter just..."*)

### Węzeł `[266]`
Mówca: **Ewald Alphonso**
> ""That is your prerogative, Mr. President. Following the violent events of late, I heavily recommend against facing any crowd.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Gus Manger: ""Mr. President, I advise you to leave via helicopter just..."*)

### Węzeł `[267]`
Mówca: **Ewald Alphonso**
> ""Trust me, I know this place well. The only other way out is through a dangerous hilly terrain or the sewers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Gus Manger: ""Mr. President, I advise you to leave via helicopter just..."*)

### Węzeł `[268]`
Mówca: **Serge Wolkner**
> ""More police are on the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Serge Wolkner: ""You must make a decision, Mr. President.""*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "Suddenly, the meeting was interrupted. The quiet murmur o..."*)

### Węzeł `[270]`
Mówca: **Narrator**
> "Everyone waited. The tense silence of the room stood in stark contrast to the buzz of the ever-growing crowd outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayMusic("Reflection");`
- **Efekt skryptowy (`userScript`):** `PlayMusic("Reflection");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "After a series of intense meetings with Ciara and Paskal,..."*)

### Węzeł `[272]`
Mówca: **Gus Manger**
> ""Amazing! I knew you two could make it work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Ewald Alphonso: ""Excellent, Mr. President! Your support for the homeless ..."*)

### Węzeł `[273]`
Mówca: **Gus Manger**
> ""Before we conclude, Ewald, I've set aside time during this meeting for President Rayne to discuss concerns about Gasom's treatment of workers and its repercussions on Narbel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Gus Manger: ""The Labor Union and the Communist Party of Sordland have..."*)

### Węzeł `[274]`
Mówca: **Narrator**
> "Alphonso nodded and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Player: ""We need to address these concerns; they could jeopardize..."*)
  - -> `[337]` (*Player: ""Our duty is to listen and take action. That's the mandat..."*)
  - -> `[338]` (*Player: ""Gasom stands as a global energy powerhouse. It's only ri..."*)
  - -> `[101]` (*Player: ""We've covered a lot today. I believe we can wrap up the ..."*)
  - -> `[341]` (*Player: ""I've wasted enough time to this. Time to depart.""*)

### Węzeł `[275]`
Mówca: **Ewald Alphonso**
> ""Do you have a proposal in mind, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player: ""The workers of Gasom need better housing, access to heal..."*)
  - -> `[98]` (*Player: ""The wages of Gasom blue-collar workers need to be increa..."*)
  - -> `[99]` (*Player: ""I expect Gasom to contribute significantly to local char..."*)
  - -> `[101]` (*Player: ""We've covered a lot today. I believe we can wrap up the ..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Gasom_RiziaInvestmentCritique = true;
BaseGameSupport.News_Turn03_LT_Gasom_NoInvestmentDownside = true;
BaseGameSupport.News_Turn03_R_Gasom_NoInvestmentCritique = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Gasom_RiziaInvestmentCritique"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Gasom_NoInvestmentDownside"] = true;
Variable["BaseGameSupport.News_Turn03_R_Gasom_NoInvestmentCritique"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == false"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Gasom_CoInvestmentSkepticism = true;
BaseGameSupport.News_Turn03_LT_Gasom_CoInvestmentPotential = true;
BaseGameSupport.Codex_Organisations_Corporations_Gasom = false;
BaseGameSupport.Codex_Organisations_Corporations_Gasom_Invested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Gasom_CoInvestmentSkepticism"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Gasom_CoInvestmentPotential"] = true;
Variable["BaseGameSupport.Codex_Organisations_Corporations_Gasom"] = false;
Variable["BaseGameSupport.Codex_Organisations_Corporations_Gasom_Invested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == false"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Gasom_LargeInvestmentPraise = true; BaseGameSupport.News_Turn03_LT_Gasom_SordlandInvestmentPositive = true;
BaseGameSupport.News_Turn03_R_Gasom_LargeInvestmentCritique = true;
BaseGameSupport.Codex_Organisations_Corporations_Gasom = false;
BaseGameSupport.Codex_Organisations_Corporations_Gasom_Invested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Gasom_LargeInvestmentPraise"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Gasom_SordlandInvestmentPositive"] = true;
Variable["BaseGameSupport.News_Turn03_R_Gasom_LargeInvestmentCritique"] = true;
Variable["BaseGameSupport.Codex_Organisations_Corporations_Gasom"] = false;
Variable["BaseGameSupport.Codex_Organisations_Corporations_Gasom_Invested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == false"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Gasom_RiziaInvestmentCritique = true;
BaseGameSupport.News_Turn03_LT_Gasom_NoInvestmentDownside = true;
BaseGameSupport.News_Turn03_R_Gasom_NoInvestmentCritique = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Gasom_RiziaInvestmentCritique"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Gasom_NoInvestmentDownside"] = true;
Variable["BaseGameSupport.News_Turn03_R_Gasom_NoInvestmentCritique"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == false"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment = true; BaseGameSupport.Journal_Turn03_Gasom_RiziaAloneInvest = true; BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1;
BaseGame.Public_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] = true;
Variable["BaseGameSupport.Journal_Turn03_Gasom_RiziaAloneInvest"] = true;
Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Gasom_RiziaInvestmentCriti..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == false"*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaBias == false)"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentCritique..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentPraise =..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentCritique = true;
BaseGame.Public_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentCritique"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Ewald Alphonso: ""I understand your reservations. We'll continue to serve ..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == false"*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaBias == false)"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_Gasom_CoInvestmentCritique..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_Gasom_CoInvestmentPraise =..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == false"*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaBias == false)"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_Gasom_LargeInvestmentCriti..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_Gasom_LargeInvestmentPrais..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_Gasom_CoInvestmentCritique = true;
BaseGame.Public_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Gasom_CoInvestmentCritique"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Ewald Alphonso: ""A joint investment? A wise choice. It ensures steady fun..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_Gasom_CoInvestmentPraise = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Gasom_CoInvestmentPraise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Ewald Alphonso: ""A joint investment? A wise choice. It ensures steady fun..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentPraise = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentPraise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Ewald Alphonso: ""I understand your reservations. We'll continue to serve ..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_Gasom_LargeInvestmentCritique = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Gasom_LargeInvestmentCritique"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Ewald Alphonso: ""Your decision shows a commitment to Sordland's energy in..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_Gasom_LargeInvestmentPraise = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Gasom_LargeInvestmentPraise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Ewald Alphonso: ""Your decision shows a commitment to Sordland's energy in..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == false"*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaBias == false)"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentCritique..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentPraise =..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentCritique = true;
BaseGame.Public_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentCritique"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Letting another nation buy a critical en..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentPraise = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentPraise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Letting another nation buy a critical en..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaBias == true)"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 2"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 1"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Securing better conditions for the worke..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Securing better conditions for the worke..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaBias == true)"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 1"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Securing better conditions for the worke..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Securing better conditions for the worke..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaBias == true)"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 2"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention = true"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention = true"*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Visiting a large gas company to discuss a potential deal", "Ornobel District", "Narbel");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Visiting a large gas company to discuss a potential deal","Ornobel District","Narbel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn03_Ribel_NewBFFLeadership = true"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Heavily investing to enrich a critical energy company", "Gasom Branch", "Narbel");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Heavily investing to enrich a critical energy company","Gasom Branch","Narbel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Gus Manger: ""Before we dive into the celebrations, I've allocated tim..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Co-investing with a kingdom to fund a critical energy company", "Gasom Branch", "Narbel");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Co-investing with a kingdom to fund a critical energy company","Gasom Branch","Narbel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Gus Manger: ""Before we dive into the celebrations, I've allocated tim..."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Letting another nation buy a critical energy company", "Gasom Branch", "Narbel");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Letting another nation buy a critical energy company","Gasom Branch","Narbel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Gus Manger: ""Before we conclude, Ewald, I've set aside time during th..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Securing better conditions for the workers of big gas", "Gasom Branch", "Narbel");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Securing better conditions for the workers of big gas","Gasom Branch","Narbel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Ewald Alphonso: ""Well, Mr. President, we're committed to--""*)

### Węzeł `[321]`
Mówca: **Ewald Alphonso**
> ""I appreciate your visit today, and despite our differences, your willingness to meet with me is noted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Ewald Alphonso: ""Throughout my journey, I've held faith in collaborating ..."*)

### Węzeł `[322]`
Mówca: **Ewald Alphonso**
> ""Throughout my journey, I've held faith in collaborating with individuals who genuinely share my vision. The presence of the right allies amplifies our potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Ewald Alphonso: ""Your attitude and choices as President has prompted me t..."*)

### Węzeł `[323]`
Mówca: **Gus Manger**
> ""I'll leverage my Rizian contacts to finalize the deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Ewald Alphonso: ""Our allies in the Golden Kingdom will step in where Sord..."*)

### Węzeł `[324]`
Mówca: **Ewald Alphonso**
> ""Our allies in the Golden Kingdom will step in where Sordland couldn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment = true; Bas..."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Ewald Alphonso: ""I'm glad we see eye to eye on this. With your support, I..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Gus Manger: ""I understand, Mr. President.""*)

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not here for your approval, Alphonso. My priority is Gus and, more importantly, the workers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Ewald Alphonso: ""That sounds eerily like what Mr. Soll would say when thi..."*)

### Węzeł `[328]`
Mówca: **Ewald Alphonso**
> ""That sounds eerily like what Mr. Soll would say when things didn't go his way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Gus Manger: ""Let's not get heated.""*)

### Węzeł `[329]`
Mówca: **Gus Manger**
> ""Let's not get heated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Gus Manger: ""I understand that tensions are high right now. But I hav..."*)

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We must make decisions based on what is best for Sordland in the present moment.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[250]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Ewald Alphonso: ""If the Sordish government chooses to invest, it would ga..."*)

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Running the state is not like running your company Alphonso. You out of all people should know this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[250]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.RuralDevelopment_Interest -= 1"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RuralDevelopment_Interest -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.RuralDevelopment_Interest"] = Variable["BaseGame.RuralDevelopment_Interest"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Ewald Alphonso: ""If the Sordish government chooses to invest, it would ga..."*)

### Węzeł `[333]`
Mówca: **Gus Manger**
> ""The Labor Union and the Communist Party of Sordland have garnered significant support, capitalizing on the anxieties of the many Gasom workers concerned about their job security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Narrator: "Alphonso nodded and looked at me."*)

### Węzeł `[334]`
Mówca: **Gus Manger**
> ""The worried workers will have no fears about job security thanks to this state intervention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Heavily investing to enrich a critical e..."*)

### Węzeł `[335]`
Mówca: **Gus Manger**
> ""The Labor Union, along with the Communist Party of Sordland, has rallied substantial support from Gasom workers in Narbel, advocating for improved local conditions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Narrator: "Alphonso nodded and looked at me."*)

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We need to address these concerns; they could jeopardize the administration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Ewald Alphonso: ""Together, we might discover solutions beneficial to both..."*)

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Our duty is to listen and take action. That's the mandate granted to us by the public.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Ewald Alphonso: ""While sometimes people may not always recognize what's i..."*)

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gasom stands as a global energy powerhouse. It's only right they give back somewhat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Ewald Alphonso: ""Let's mull it over.""*)

### Węzeł `[339]`
Mówca: **Ewald Alphonso**
> ""Together, we might discover solutions beneficial to both parties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Ewald Alphonso: ""Do you have a proposal in mind, Mr. President?""*)

### Węzeł `[340]`
Mówca: **Ewald Alphonso**
> ""Very well, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Gus Manger: ""It's been a long day. We've got a lot to think about.""*)

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I've wasted enough time to this. Time to depart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Ewald Alphonso: ""It's regrettable you feel this way, Mr. President.""*)

### Węzeł `[342]`
Mówca: **Ewald Alphonso**
> ""It's regrettable you feel this way, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Gus Manger: ""It's been a long day. We've got a lot to think about.""*)

### Węzeł `[343]`
Mówca: **Ewald Alphonso**
> ""While sometimes people may not always recognize what's in their best interest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Ewald Alphonso: ""Do you have a proposal in mind, Mr. President?""*)

### Węzeł `[344]`
Mówca: **Ewald Alphonso**
> ""Let's mull it over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Ewald Alphonso: ""Do you have a proposal in mind, Mr. President?""*)

### Węzeł `[345]`
Mówca: **Narrator**
> "A member of the private security team entered the room, his face taut with urgency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone =..."*)

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Look, gentlemen. My time is valuable, so let’s cut to the chase.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Ewald Alphonso: ""Blunt. Must be the new way of doing things.""*)

### Węzeł `[347]`
Mówca: **Ewald Alphonso**
> ""Blunt. Must be the new way of doing things.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Ewald Alphonso: ""Throughout my journey, I've held faith in collaborating ..."*)

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don’t forget, the state stands above you all. Nothing may happen today, or next week, but the future is never certain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[206]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Ewald Alphonso: ""I have served Sordland all my life. It’s the people who ..."*)

### Węzeł `[349]`
Mówca: **Ewald Alphonso**
> ""I have served Sordland all my life. It’s the people who voted for me, just like they did for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Gus Manger: ""We’re all civil servants here.""*)

### Węzeł `[350]`
Mówca: **Gus Manger**
> ""We’re all civil servants here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Gus Manger: ""Thank you for making the trip and setting aside the time.""*)

### Węzeł `[351]`
Mówca: **Ewald Alphonso**
> ""I think it's time to call Mr. Montoro, Gus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Ewald Alphonso: ""Our allies in the Golden Kingdom will step in where Sord..."*)

### Węzeł `[352]`
Mówca: **Gus Manger**
> ""Thank you for making the trip and setting aside the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Ewald Alphonso: ""I think it's time to call Mr. Montoro, Gus.""*)
