# Sordland/Turn05/Personal_PetrParty

- **ID konwersacji:** `66`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/066_Personal_PetrParty.md`
- **Liczba węzłów dialogowych:** 426
- **Liczba wyborów gracza:** 84

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[29]** Ewald Alphonso
- **[35]** Gus Manger

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Accepted_PersonalInvestment2`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses`
- `BaseGame.Decision_Turn04_GruniRuralDev_NoFunding`
- `BaseGame.Decision_Turn05_SPAid_AcceptArcasia`
- `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.PersonalWealth`
- `BaseGame.Policy_Economy_EnergyProtectionAct_10Percent`
- `BaseGame.Policy_Economy_PromotePlanned`
- `BaseGame.Prologue_Party_Takeover_Backstab`
- `BaseGame.Prologue_Party_Takeover_PublicBlame`
- `BaseGame.Promise_Diplomacy_East`
- `BaseGame.Promise_Diplomacy_West`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia`
- `BaseGame.Reform_EmergencyDecree_PoliceAuthority`
- `BaseGame.Reform_EmergencyDecree_SuspendedProtests`
- `BaseGame.Relations_Ewald_Discontent`
- `BaseGame.Relations_Ewald_PromiseNotHarsherEPA`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`
- `BaseGame.Situation_Law_MediaBias`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`
- `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia`
- `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone`
- `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment`
- `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations`
- `BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses`
- `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations`
- `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses`
- `BaseGame.Turn04_PSnW_Education_Privatization`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Accepted_PersonalInvestment2`
- `BaseGame.Economy`
- `BaseGame.PersonalWealth`
- `BaseGame.Turn05_P_FCAnrica`
- `BaseGame.Turn05_P_Underhall`
- `BaseGame.Turn05_P_Vineyard`
- `BaseGameSupport.Journal_Turn05_GusInvestment_FCAnrica`
- `BaseGameSupport.Journal_Turn05_GusInvestment_Underhall`
- `BaseGameSupport.Journal_Turn05_GusInvestment_Winery`
- `BaseGameSupport.News_Turn05_G_ArcasiaAid`
- `BaseGameSupport.News_Turn05_G_UCAid`
- `BaseGameSupport.News_Turn05_HP_BFFPropaganda`
- `BaseGameSupport.News_Turn05_R_StateWarYS`
- `BaseGameSupport.News_Turn05_ST_GruniRuralDev_BadInvestment`
- `BaseGameSupport.News_Turn05_ST_GruniRuralDev_BadNoInvestment`
- `BaseGameSupport.News_Turn05_ST_GruniRuralDev_GoodNoInvestment`
- `BaseGameSupport.News_Turn05_ST_GruniRuralDev_GreatInvestment`
- `BaseGameSupport.News_Turn05_ST_PetrParty_NoDeal`
- `BaseGameSupport.News_Turn05_ST_ReligionBill_Signed_Deal`
- `BaseGameSupport.News_Turn05_ST_ReligionBill_Signed_NoDeal`
- `BaseGameSupport.News_Turn05_ST_ReligionBill_Vetoed_Deal`
- `BaseGameSupport.Report_Turn05_Erzaren_PoliceReport`
- `BaseGameSupport.Report_Turn05_Holsord_FireInvestigationHold`
- `BaseGameSupport.Report_Turn05_Holsord_HPEditorSuspect`
- `BaseGameSupport.Report_Turn05_Lachaven_EducationPrivatizationResult`
- `BaseGameSupport.Report_Turn05_Sarna_BFFPropagandaInSchools`
- `BaseGameSupport.Report_Turn05_Uziren_BludishProtestBill`
- `BaseGameSupport.Report_Turn05_Uziren_BludishProtestBill_A`
- `GameCondition.Turn05_Personal_PetrParty`
- `GameCondition.Turn06_Personal_ReturnOfInvestment2`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **"“Thank you, Petr. What's next? A choir? A marching band?”"** | `[16]` **Narrator**: "I'd known him for long enough to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Petr Vectern**: "“No. I'm saving those for your f..." |
| `[6]` | **"Gesture at one of the waitresses to come over."** | `[54]` **Narrator**: "Cocktail waitresses were carryin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Narrator**: "She was in her mid-twenties, wea..." |
| `[17]` | **"“And I present to you, Petr Vectern. The first alcoholic Vice President of Sordland.”"** | `[16]` **Narrator**: "I'd known him for long enough to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Narrator**: "My joke didn't sit well with Pet..." |
| `[18]` | **"“Good evening.”"** | `[16]` **Narrator**: "I'd known him for long enough to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Narrator**: "Petr nodded at me and turned to ..." |
| `[30]` | **"“What's the story behind the chandelier?”"** | `[29]` **Petr Vectern**: "“That chandelier was made in the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Petr Vectern**: "“I don't know and I don't care. ..." |
| `[31]` | **"“How are you paying for all of this?”"** | `[29]` **Petr Vectern**: "“That chandelier was made in the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Petr Vectern**: "“I'll let you in on a secret. Gu..." |
| `[32]` | **"“An 18th-century chandelier? A hedge maze? A little much, isn't it?”"** | `[29]` **Petr Vectern**: "“That chandelier was made in the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Petr Vectern**: "“Ah, come on, Anton. You only li..." |
| `[38]` | **""What did you promise him in return?""** | `[37]` **Petr Vectern**: "“He'll also be here tonight, by ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Petr Vectern**: "“Only my money.”" |
| `[39]` | **"“Perfect. I've been looking for a chance to speak with him about investment opport..."** | `[37]` **Petr Vectern**: "“He'll also be here tonight, by ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Petr Vectern**: "“He'll have a once-in-a-lifetime..." |
| `[43]` | **"“Not bad. Not bad at all.”"** | `[42]` **Petr Vectern**: "“So, what do you think of my lit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Petr Vectern**: "“Thanks! You know that you, Moni..." |
| `[44]` | **"“Living in a lavish mansion while my country suffers is not for me.”"** | `[37]` **Petr Vectern**: "“He'll also be here tonight, by ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Petr Vectern**: "“I understand completely. That's..." |
| `[46]` | **"“Frankly, I find it disgusting.""** | `[42]` **Petr Vectern**: "“So, what do you think of my lit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Petr Vectern**: "“Jealous, are we? Like I said, y..." |
| `[47]` | **"“It's amazing, but I'd hardly call it a hideaway. More like a palace.”"** | `[42]` **Petr Vectern**: "“So, what do you think of my lit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Petr Vectern**: "“It definitely doesn't rival you..." |
| `[56]` | **"“I thought this was a *Gentlemen*'s Club.”"** | `[54]` **Narrator**: "Cocktail waitresses were carryin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Petr Vectern**: "“Would you rather get served by ..." |
| `[57]` | **"“So this is what you've been hiding from Evelyn.”"** | `[54]` **Narrator**: "Cocktail waitresses were carryin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Petr Vectern**: "“No one is hiding anything. She ..." |
| `[65]` | **"“Petr. I am warning you. Don't make a mistake.”"** | `[64]` **Petr Vectern**: "“Oh look, there's Gus. Why don't..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Petr Vectern**: "“Mistake? What are you talking a..." |
| `[66]` | **"“Where are you going?”"** | `[64]` **Petr Vectern**: "“Oh look, there's Gus. Why don't..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Petr Vectern**: ""Oh, just to the washroom. See y..." |
| `[72]` | **"“You don't seem at all surprised to see me here.”"** | `[71]` **Narrator**: "Gus and I clinked our glasses as..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Gus Manger**: "“That's because Petr told me you..." |
| `[73]` | **"“How long have you been a member?”"** | `[71]` **Narrator**: "Gus and I clinked our glasses as..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Gus Manger**: "“Since the beginning. It's a fun..." |
| `[74]` | **"“I heard this mansion is a result of your connections.”"** | `[71]` **Narrator**: "Gus and I clinked our glasses as..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Gus Manger**: "“That's right. I do have a wide ..." |
| `[80]` | **"“Only a little one?”"** | `[77]` **Petr Vectern**: "“I personally don't know any bet..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Narrator**: "A few people in the crowd chuckl..." |
| `[81]` | **"Raise your glass."** | `[77]` **Petr Vectern**: "“I personally don't know any bet..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Petr Vectern**: "“Now. The tradition dictates tha..." |
| `[82]` | **"“I'll drink to that!”"** | `[77]` **Petr Vectern**: "“I personally don't know any bet..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Narrator**: "People in the crowd laughed and ..." |
| `[85]` | **"Drain your glass."** | `[79]` **Narrator**: "Petr drank the whiskey in his gl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Petr Vectern**: "“Anton Rayne might have the powe..." |
| `[86]` | **"Sip your whiskey."** | `[79]` **Narrator**: "Petr drank the whiskey in his gl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Petr Vectern**: "“Anton Rayne might have the powe..." |
| `[95]` | **"Take the cigar."** | `[94]` **Narrator**: "We left the room and made our wa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Narrator**: "We went out to the balcony. All ..." |
| `[96]` | **"Refuse the cigar."** | `[94]` **Narrator**: "We left the room and made our wa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Narrator**: "We went out to the balcony. All ..." |
| `[109]` | **"“Why is that?”"** | `[107]` **Gus Manger**: "“I would have been delighted to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Gus Manger**: "“There have been some issues wit..."<br>`[243]` **Gus Manger**: "“There have been some issues wit..." |
| `[110]` | **"“I thought as much.”"** | `[107]` **Gus Manger**: "“I would have been delighted to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Gus Manger**: "“It's unfortunate.”" |
| `[112]` | **"“I understand.”"** | `[111]` **Gus Manger**: "“There have been some issues wit..."<br>`[243]` **Gus Manger**: "“There have been some issues wit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Narrator**: "He downed his whiskey." |
| `[113]` | **"“Think of it as an investment.”"** | `[111]` **Gus Manger**: "“There have been some issues wit..."<br>`[243]` **Gus Manger**: "“There have been some issues wit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Gus Manger**: "“I have already made my investme..." |
| `[118]` | **"“Thank you.”"** | `[108]` **Gus Manger**: "“The Gasom affair notwithstandin..."<br>`[274]` **Gus Manger**: "“Your willingness to invest in G..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Gus Manger**: "“No, Mr. President.”" |
| `[119]` | **"“I'm glad my investment decisions are paying off.”"** | `[108]` **Gus Manger**: "“The Gasom affair notwithstandin..."<br>`[274]` **Gus Manger**: "“Your willingness to invest in G..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Gus Manger**: "“Cheers to investments paying of..." |
| `[120]` | **"“I am not looking to make any investments at the moment.”"** | `[108]` **Gus Manger**: "“The Gasom affair notwithstandin..."<br>`[274]` **Gus Manger**: "“Your willingness to invest in G..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Gus Manger**: "“Real estate is the best investm..." |
| `[125]` | **"“No. That's my final answer.”"** | `[101]` **Gus Manger**: "“Is there any chance I can convi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Gus Manger**: "“Very well. I won't push further.”" |
| `[126]` | **"“All right. Let me see what you have available.”"** | `[101]` **Gus Manger**: "“Is there any chance I can convi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Gus Manger**: ""I knew you'd come around."" |
| `[131]` | **"“What's in it for you?”"** | `[108]` **Gus Manger**: "“The Gasom affair notwithstandin..."<br>`[274]` **Gus Manger**: "“Your willingness to invest in G..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Gus Manger**: "“Nothing, Mr. President. It's a ..." |
| `[139]` | **"“Football sounds exciting. I'll invest in FC Anrica.” [-2 Personal Wealth]"** | `[138]` **Gus Manger**: "“Give me the word, and I will st..." | `Variable["BaseGame.PersonalWealth"] > 1` | `Variable["BaseGame.Turn05_P_FCAnrica"] = true; Variable["...`<br>`Variable["BaseGame.PersonalWealth"] = Variable["BaseGame....` | `[147]` **Gus Manger**: "“Excellent. I will start the pro..." |
| `[140]` | **"“I'll invest in Underhall Construction.” [-2 Personal Wealth]"** | `[138]` **Gus Manger**: "“Give me the word, and I will st..." | `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true)  and  Variable["BaseGame.Faction_Oligarchs_Content"] == true`<br>`Variable["BaseGame.PersonalWealth"] > 1` | `Variable["BaseGame.Turn05_P_Underhall"] = true; Variable[...`<br>`Variable["BaseGame.PersonalWealth"] = Variable["BaseGame....` | `[147]` **Gus Manger**: "“Excellent. I will start the pro..." |
| `[141]` | **"“The vineyard in Erlory. I've always wanted to have my own wine. And it sounds pea..."** | `[138]` **Gus Manger**: "“Give me the word, and I will st..." | `Variable["BaseGame.PersonalWealth"] > 1` | `Variable["BaseGame.Turn05_P_Vineyard"] = true; Variable["...`<br>`Variable["BaseGame.PersonalWealth"] = Variable["BaseGame....` | `[147]` **Gus Manger**: "“Excellent. I will start the pro..." |
| `[142]` | **"“On second thought, I don't want to do this now.”"** | `[138]` **Gus Manger**: "“Give me the word, and I will st..." | *Brak (Dostępna bezwarunkowo)* | `Variable["GameCondition.Turn06_Personal_ReturnOfInvestmen...` | `[143]` **Gus Manger**: "“Very well. Do not blame me if t..." |
| `[168]` | **"“I'd like to make a similarly profitable arrangement myself.”"** | `[116]` **Gus Manger**: "“I know you're wondering about t..." | `((Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  or  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true)  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true) == false` | *Brak zmian stanu* | `[117]` **Gus Manger**: ""Let me be direct.”" |
| `[169]` | **"“That cheap, huh?”"** | `[116]` **Gus Manger**: "“I know you're wondering about t..." | `((Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  or  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true)  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true) == false` | *Brak zmian stanu* | `[262]` **Gus Manger**: ""You must know that the offered ..." |
| `[170]` | **""You're wrong. I wasn't wondering.""** | `[116]` **Gus Manger**: "“I know you're wondering about t..." | `((Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  or  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true)  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true) == false` | *Brak zmian stanu* | `[171]` **Gus Manger**: "“Very well, then.”" |
| `[172]` | **"“I don't think I can afford an investment right now.”"** | `[138]` **Gus Manger**: "“Give me the word, and I will st..." | `(Variable["BaseGame.PersonalWealth"] > 0) == false`<br>`(Variable["BaseGame.PersonalWealth"] > 1) == false` | *Brak zmian stanu* | `[173]` **Gus Manger**: "“Really?”" |
| `[219]` | **"“Really?”"** | `[45]` **Petr Vectern**: "“I understand completely. That's..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[221]` **Petr Vectern**: "“That's what it says on my tax f..." |
| `[220]` | **"“I don't believe you.”"** | `[45]` **Petr Vectern**: "“I understand completely. That's..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[221]` **Petr Vectern**: "“That's what it says on my tax f..." |
| `[226]` | **"“That's nice of you.”"** | `[45]` **Petr Vectern**: "“I understand completely. That's..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[221]` **Petr Vectern**: "“That's what it says on my tax f..." |
| `[269]` | **""Why am I not surprised? Gus the wheeler and dealer would be right at home at a pa..."** | `[37]` **Petr Vectern**: "“He'll also be here tonight, by ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Petr Vectern**: ""Hell, half of the guests here o..." |
| `[282]` | **""Mr. Alphonso. I didn't know you were a member of Petr's club.""** | `[277]` **Narrator**: "With a reluctant look in his eye..."<br>`[281]` **Narrator**: "With a smile, the former preside..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Ewald Alphonso**: ""I'm not. Gus and I were having ..." |
| `[283]` | **""Mr. President. Is that an empty glass I see in your hand?""** | `[277]` **Narrator**: "With a reluctant look in his eye..."<br>`[281]` **Narrator**: "With a smile, the former preside..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[289]` **Ewald Alphonso**: ""I'm trying to pace myself. Gus ..." |
| `[284]` | **""Isn't a party like this a little low-class for a man like you?""** | `[277]` **Narrator**: "With a reluctant look in his eye..."<br>`[281]` **Narrator**: "With a smile, the former preside..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Ewald Alphonso**: ""The surroundings are a little t..." |
| `[285]` | **""You know the rules. No politics.""** | `[277]` **Narrator**: "With a reluctant look in his eye..."<br>`[281]` **Narrator**: "With a smile, the former preside..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[290]` **Ewald Alphonso**: ""No politics. But plenty of side..." |
| `[294]` | **""That's right. He offered me some lucrative investment opportunities.""** | `[288]` **Ewald Alphonso**: ""I saw you speaking to Mr. Mange..." | `Variable["BaseGame.Accepted_PersonalInvestment2"] == true` | *Brak zmian stanu* | `[302]` **Ewald Alphonso**: ""Hmm. Interesting that you'd tak..."<br>`[303]` **Ewald Alphonso**: ""Why not? Seems like a natural p..." |
| `[295]` | **""Yes, he and I are going into business together.""** | `[288]` **Ewald Alphonso**: ""I saw you speaking to Mr. Mange..." | `Variable["BaseGame.Accepted_PersonalInvestment2"] == true` | *Brak zmian stanu* | `[302]` **Ewald Alphonso**: ""Hmm. Interesting that you'd tak..."<br>`[303]` **Ewald Alphonso**: ""Why not? Seems like a natural p..." |
| `[296]` | **""Just briefly. I wasn't interested in what he was offering.""** | `[288]` **Ewald Alphonso**: ""I saw you speaking to Mr. Mange..." | `(Variable["BaseGame.Accepted_PersonalInvestment2"] == true) == false` | *Brak zmian stanu* | `[325]` **Ewald Alphonso**: ""It figures. I don't know why he..."<br>`[326]` **Ewald Alphonso**: ""Interesting. I would have thoug..." |
| `[297]` | **""He seems used to making deals with sitting presidents. But he and I won't be goin..."** | `[288]` **Ewald Alphonso**: ""I saw you speaking to Mr. Mange..." | `(Variable["BaseGame.Accepted_PersonalInvestment2"] == true) == false` | *Brak zmian stanu* | `[325]` **Ewald Alphonso**: ""It figures. I don't know why he..."<br>`[326]` **Ewald Alphonso**: ""Interesting. I would have thoug..." |
| `[298]` | **""We talked, yes. It's always nice to get to know one's ministers outside of the Ma..."** | `[288]` **Ewald Alphonso**: ""I saw you speaking to Mr. Mange..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[327]` **Ewald Alphonso**: ""We had a good chat together bac..." |
| `[333]` | **""No politics, remember?""** | `[307]` **Ewald Alphonso**: ""Although your tightening of the..."<br>`[311]` **Ewald Alphonso**: ""Although your tightening of the..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[348]` **Narrator**: "He sighed." |
| `[334]` | **""Terrific. I'm looking forward to a big payoff.""** | `[321]` **Ewald Alphonso**: ""We're seeing growing interest f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[352]` **Ewald Alphonso**: ""I can't tell you for sure how b..." |
| `[335]` | **""I'm glad that Sordland could help your company thrive.""** | `[321]` **Ewald Alphonso**: ""We're seeing growing interest f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[351]` **Ewald Alphonso**: ""And vice versa."" |
| `[336]` | **""Enjoy our bailout, Mr. Alphonso. It'll be your only one.""** | `[321]` **Ewald Alphonso**: ""We're seeing growing interest f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[350]` **Ewald Alphonso**: ""As I've told you, this isn't a ..." |
| `[337]` | **""And you, of course.""** | `[320]` **Ewald Alphonso**: ""At any rate, it's doing fine wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[345]` **Ewald Alphonso**: ""That goes without saying."" |
| `[338]` | **""I still stand by my decision. There were better uses for that money.""** | `[320]` **Ewald Alphonso**: ""At any rate, it's doing fine wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[346]` **Ewald Alphonso**: ""Better uses, maybe. But not mor..." |
| `[339]` | **""Yes, perhaps Sordland should've invested. But it's too late for regrets.""** | `[320]` **Ewald Alphonso**: ""At any rate, it's doing fine wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Ewald Alphonso**: ""It's not too late to remember t..." |
| `[340]` | **""I'm sorry about that. My party forced me to do it.""** | `[307]` **Ewald Alphonso**: ""Although your tightening of the..."<br>`[311]` **Ewald Alphonso**: ""Although your tightening of the..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[342]` **Ewald Alphonso**: ""I know how much pressure the US..." |
| `[341]` | **""Unlike you, I know better than to mess with a successful Tarquin Soll policy.""** | `[307]` **Ewald Alphonso**: ""Although your tightening of the..."<br>`[311]` **Ewald Alphonso**: ""Although your tightening of the..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[344]` **Ewald Alphonso**: ""That policy put a chokehold on ..." |
| `[354]` | **""Petr. Behave yourself.""** | `[353]` **Petr Vectern**: ""Look at you two! Sordland's bri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[361]` **Petr Vectern**: ""Yes, Mr. President. Right away,..." |
| `[355]` | **""It's been an hour. Where were you?""** | `[353]` **Petr Vectern**: ""Look at you two! Sordland's bri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[358]` **Petr Vectern**: ""I told you. The washroom. Trust..." |
| `[356]` | **""My apologies, Mr. Alphonso. My vice president's had a bit too much to drink.""** | `[353]` **Petr Vectern**: ""Look at you two! Sordland's bri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[360]` **Petr Vectern**: ""Pardon me, Mr. President, but I..." |
| `[357]` | **""Another brilliant zinger, Petr.""** | `[353]` **Petr Vectern**: ""Look at you two! Sordland's bri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[359]` **Petr Vectern**: ""That's what I'm here for."" |
| `[366]` | **""He's here, too? What a party.""** | `[365]` **Ewald Alphonso**: ""If you'll excuse me, I'm going ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[369]` **Narrator**: "Alphonso gave a brusque wave and..." |
| `[367]` | **""Have fun mingling. It was good to see you.""** | `[365]` **Ewald Alphonso**: ""If you'll excuse me, I'm going ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[369]` **Narrator**: "Alphonso gave a brusque wave and..." |
| `[368]` | **""We'll talk soon.""** | `[365]` **Ewald Alphonso**: ""If you'll excuse me, I'm going ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[369]` **Narrator**: "Alphonso gave a brusque wave and..." |
| `[377]` | **""Was that you in the hedge maze, Petr?""** | `[375]` **Petr Vectern**: ""Nice guy. I almost feel bad abo..."<br>`[376]` **Petr Vectern**: ""Nice guy. A shitty president, b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[383]` **Petr Vectern**: ""What are you talking about?"" |
| `[378]` | **""Why didn't you tell me Ewald Alphonso was coming?""** | `[375]` **Petr Vectern**: ""Nice guy. I almost feel bad abo..."<br>`[376]` **Petr Vectern**: ""Nice guy. A shitty president, b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[380]` **Petr Vectern**: ""I didn't know! Gus brought him ..." |
| `[379]` | **""I will give you one more chance. Where were you?""** | `[375]` **Petr Vectern**: ""Nice guy. I almost feel bad abo..."<br>`[376]` **Petr Vectern**: ""Nice guy. A shitty president, b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[381]` **Narrator**: "Petr assumed a patient look." |
| `[384]` | **""While you were gone, I saw two people kissing in the hedge maze outside.""** | `[382]` **Petr Vectern**: ""Well, Mr. President, when too m..."<br>`[383]` **Petr Vectern**: ""What are you talking about?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[393]` **Petr Vectern**: ""Huh. Probably a couple of kitch..." |
| `[385]` | **""I'll be direct. Were you with the waitress?""** | `[382]` **Petr Vectern**: ""Well, Mr. President, when too m..."<br>`[383]` **Petr Vectern**: ""What are you talking about?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[392]` **Petr Vectern**: ""What? No, no. How could you eve..." |
| `[386]` | **""You know what? Never mind. Let's get another drink.""** | `[380]` **Petr Vectern**: ""I didn't know! Gus brought him ..."<br>`[382]` **Petr Vectern**: ""Well, Mr. President, when too m..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[390]` **Petr Vectern**: ""Now you're speaking my language."" |
| `[387]` | **""Next time, I want to be able to vet your guest list. You're risking a breach of n..."** | `[380]` **Petr Vectern**: ""I didn't know! Gus brought him ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[389]` **Petr Vectern**: ""Anton. Can't a man have some fu..." |
| `[388]` | **""It's fine. I was happy to see him. But it was definitely a surprise.""** | `[380]` **Petr Vectern**: ""I didn't know! Gus brought him ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[391]` **Petr Vectern**: ""That's what I'm aiming for with..." |
| `[394]` | **""All right. If you say so.""** | `[392]` **Petr Vectern**: ""What? No, no. How could you eve..."<br>`[393]` **Petr Vectern**: ""Huh. Probably a couple of kitch..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[401]` **Petr Vectern**: ""I do say so."" |
| `[395]` | **""Petr. You know you can tell me anything.""** | `[392]` **Petr Vectern**: ""What? No, no. How could you eve..."<br>`[393]` **Petr Vectern**: ""Huh. Probably a couple of kitch..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[399]` **Narrator**: "I thought I saw his cheerful exp..." |

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
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Sarna_BFFPropagandaInSchool..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Petr Vectern**
> "“Anton! Finally! Now the real party can start. Come on in!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "As soon as I entered, Petr closed the door and turned to ..."*)

### Węzeł `[4]`
**[WYBÓR GRACZA: "“Thank you, Petr. What's next? A choir? A marching band?”"]** — Mówca: **Player**
> "“Thank you, Petr. What's next? A choir? A marching band?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Petr Vectern: "“No. I'm saving those for your funeral.""*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Far from becoming accustomed to my workload as president, I only felt more and more snowed under as the weeks passed. It had been ages since I had any time to myself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "Gesture at one of the waitresses to come over."]** — Mówca: **Player_Italic**
> "I gestured at one of the waitresses to come over."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "She was in her mid-twenties, wearing red lipstick, her bl..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "I was starting to lose my focus, and my temper was growing increasingly thin. Petr was the first to realize I needed a break."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "After much cajoling, he finally persuaded me to come to a..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "After much cajoling, he finally persuaded me to come to a meeting of his new venture: Gentlemen's Club."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "For the past few months, he'd been hosting a salon of sor..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "For the past few months, he'd been hosting a salon of sorts, not just for politicians and businessmen but also for artists, entertainers -- people of taste, he told me with a smile on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "There was only one rule: no wives or girlfriends allowed...."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "There was only one rule: no wives or girlfriends allowed. Hence the name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("MansionParty");"*)

### Węzeł `[11]`
Mówca: **Narrator**
> "And so I found myself in front of his new luxury villa in Erlory. Very loud jazz music emanated from inside. I waited and waited. Finally Petr opened the door. I could smell the whiskey on his breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path"*)

### Węzeł `[12]`
Mówca: **Narrator**
> "We walked through the corridors of his mansion. Statues and paintings lined the stark white walls. An arched window provided a view of the neatly manicured grounds, complete with a swimming pool."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "A grand Lespian marble staircase led up to the second sto..."*)

### Węzeł `[13]`
Mówca: **Petr Vectern**
> "“Gentlemen! A minute of your time please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Petr Vectern: "“I now have the privilege to present to you... The man hi..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "As soon as I entered, Petr closed the door and turned to the small crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Petr Vectern: "“Gentlemen! A minute of your time please.”"*)

### Węzeł `[15]`
Mówca: **Petr Vectern**
> "“I now have the privilege to present to you... The man himself... The fourth President of Sordland, Mr. Anton Rayne!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "I'd known him for long enough to understand that he was m..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "I'd known him for long enough to understand that he was more than a little drunk. He made an elaborate mock-curtsy as I passed him and walked into the room. The music stopped, and I felt everyone's eyes on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "“Thank you, Petr. What's next? A choir? A marching band?”"*)
  - -> `[17]` (*Player: "“And I present to you, Petr Vectern. The first alcoholic ..."*)
  - -> `[18]` (*Player: "“Good evening.”"*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“And I present to you, Petr Vectern. The first alcoholic Vice President of Sordland.”"]** — Mówca: **Player**
> "“And I present to you, Petr Vectern. The first alcoholic Vice President of Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "My joke didn't sit well with Petr, nor the crowd. There w..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Good evening.”"]** — Mówca: **Player**
> "“Good evening.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "Petr nodded at me and turned to the attendees."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "My joke didn't sit well with Petr, nor the crowd. There was a short awkward silence before he continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Petr Vectern: "“Dear members, please give a warm welcome to our very spe..."*)

### Węzeł `[20]`
Mówca: **Petr Vectern**
> "“No. I'm saving those for your funeral.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Petr laughed very hard at his own grim joke before contin..."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "Petr laughed very hard at his own grim joke before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Petr Vectern: "“Dear members, please give a warm welcome to our very spe..."*)

### Węzeł `[22]`
Mówca: **Petr Vectern**
> "“Dear members, please give a warm welcome to our very special guest! If I may, Anton. Here, take this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "He handed me a glass of whiskey and put his hand on my sh..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "He handed me a glass of whiskey and put his hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Petr Vectern: "“We all know why we're gathered here tonight. To celebrat..."*)

### Węzeł `[24]`
Mówca: **Petr Vectern**
> "“Let me show you around.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "We walked through the corridors of his mansion. Statues a..."*)

### Węzeł `[25]`
Mówca: **Narrator**
> "Petr nodded at me and turned to the attendees."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Petr Vectern: "“Dear members, please give a warm welcome to our very spe..."*)

### Węzeł `[26]`
Mówca: **Petr Vectern**
> "“Anton Rayne might have the power to make presidential decrees, but, I, Petr Vectern, the president of this club, now declare this party started! Music! Go!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "The band started up again."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "The band started up again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "After greeting the crowd around me, I felt a hand on my s..."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "After greeting the crowd around me, I felt a hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Petr Vectern: "“Let me show you around.”"*)

### Węzeł `[29]`
Mówca: **Petr Vectern**
> "“That chandelier was made in the 18th century. Can you believe it? There's even a hedge maze in the garden!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: "“What's the story behind the chandelier?”"*)
  - -> `[31]` (*Player: "“How are you paying for all of this?”"*)
  - -> `[32]` (*Player: "“An 18th-century chandelier? A hedge maze? A little much,..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "“What's the story behind the chandelier?”"]** — Mówca: **Player**
> "“What's the story behind the chandelier?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Petr Vectern: "“I don't know and I don't care. It just looks expensive a..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“How are you paying for all of this?”"]** — Mówca: **Player**
> "“How are you paying for all of this?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Petr Vectern: "“I'll let you in on a secret. Gus Manger has a lot of con..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "“An 18th-century chandelier? A hedge maze? A little much, isn't it?”"]** — Mówca: **Player**
> "“An 18th-century chandelier? A hedge maze? A little much, isn't it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Petr Vectern: "“Ah, come on, Anton. You only live once.”"*)

### Węzeł `[33]`
Mówca: **Narrator**
> "A grand Lespian marble staircase led up to the second story. Petr gestured at the massive crystal chandelier hanging overhead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Petr Vectern: "“That chandelier was made in the 18th century. Can you be..."*)

### Węzeł `[34]`
Mówca: **Petr Vectern**
> "“I don't know and I don't care. It just looks expensive and I like it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Petr Vectern: "“I'll let you in on a secret. Gus Manger has a lot of con..."*)

### Węzeł `[35]`
Mówca: **Petr Vectern**
> "“I'll let you in on a secret. Gus Manger has a lot of contacts in real estate. He brokered an amazing price for me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Petr Vectern: "“He'll also be here tonight, by the way.""*)

### Węzeł `[36]`
Mówca: **Petr Vectern**
> "“Ah, come on, Anton. You only live once.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Petr Vectern: "“I'll let you in on a secret. Gus Manger has a lot of con..."*)

### Węzeł `[37]`
Mówca: **Petr Vectern**
> "“He'll also be here tonight, by the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player: ""Why am I not surprised? Gus the wheeler and dealer would..."*)
  - -> `[39]` (*Player: "“Perfect. I've been looking for a chance to speak with hi..."*)
  - -> `[38]` (*Player: ""What did you promise him in return?""*)
  - -> `[44]` (*Player: "“Living in a lavish mansion while my country suffers is n..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""What did you promise him in return?""]** — Mówca: **Player**
> ""What did you promise him in return?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Petr Vectern: "“Only my money.”"*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Perfect. I've been looking for a chance to speak with him about investment opportunities.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Petr Vectern: "“He'll have a once-in-a-lifetime deal ready for you. He a..."*)

### Węzeł `[40]`
Mówca: **Petr Vectern**
> "“Only my money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "We continued walking until we circled back to where we ha..."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "We continued walking until we circled back to where we had started."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Petr Vectern: "“So, what do you think of my little hideaway?”"*)

### Węzeł `[42]`
Mówca: **Petr Vectern**
> "“So, what do you think of my little hideaway?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "“Not bad. Not bad at all.”"*)
  - -> `[47]` (*Player: "“It's amazing, but I'd hardly call it a hideaway. More li..."*)
  - -> `[46]` (*Player: "“Frankly, I find it disgusting.""*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“Not bad. Not bad at all.”"]** — Mówca: **Player**
> "“Not bad. Not bad at all.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Petr Vectern: "“Thanks! You know that you, Monica and the kids are alway..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Living in a lavish mansion while my country suffers is not for me.”"]** — Mówca: **Player**
> "“Living a lavish lifestyle while my country suffers is not for me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Petr Vectern: "“I understand completely. That's why I've donated 30 perc..."*)

### Węzeł `[45]`
Mówca: **Petr Vectern**
> "“I understand completely. That's why I've donated 30 percent of my vice presidential salary to charities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Player: "“Really?”"*)
  - -> `[220]` (*Player: "“I don't believe you.”"*)
  - -> `[226]` (*Player: "“That's nice of you.”"*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Frankly, I find it disgusting.""]** — Mówca: **Player**
> "“Frankly, I find it disgusting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Petr Vectern: "“Jealous, are we? Like I said, you could have a place jus..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "“It's amazing, but I'd hardly call it a hideaway. More like a palace.”"]** — Mówca: **Player**
> "“It's amazing, but I'd hardly call it a hideaway. More like a palace.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Petr Vectern: "“It definitely doesn't rival yours.”"*)

### Węzeł `[48]`
Mówca: **Petr Vectern**
> "“Jealous, are we? Like I said, you could have a place just like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Petr Vectern: "“Anyway, let's get back to the party.”"*)

### Węzeł `[49]`
Mówca: **Petr Vectern**
> "“It definitely doesn't rival yours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Petr Vectern: "“Anyway, let's get back to the party.”"*)

### Węzeł `[50]`
Mówca: **Petr Vectern**
> "“Thanks! You know that you, Monica and the kids are always welcome here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Petr Vectern: "“Anyway, let's get back to the party.”"*)

### Węzeł `[51]`
Mówca: **Petr Vectern**
> "“Anyway, let's get back to the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Petr Vectern: "“I arranged for some caviar to be brought in from Lespia...."*)

### Węzeł `[52]`
Mówca: **Petr Vectern**
> "“I arranged for some caviar to be brought in from Lespia. You're going to love it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "He opened the door to the main hall, and we rejoined the ..."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "He opened the door to the main hall, and we rejoined the other guests. The music was louder now, and the mood decidedly more inebriated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Cocktail waitresses were carrying around plates of canapé..."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "Cocktail waitresses were carrying around plates of canapés, wearing dresses that left little to the imagination."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: "“I thought this was a *Gentlemen*'s Club.”"*)
  - -> `[6]` (*Player_Italic: "Gesture at one of the waitresses to come over."*)
  - -> `[57]` (*Player: "“So this is what you've been hiding from Evelyn.”"*)

### Węzeł `[55]`
Mówca: **Narrator**
> "She was in her mid-twenties, wearing red lipstick, her blonde hair neatly tied into a ponytail. On her plate were toast points slathered in the Lespian caviar Petr had mentioned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "I took a bite. It was rich, salty, tasting of pure seasid..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "“I thought this was a *Gentlemen*'s Club.”"]** — Mówca: **Player**
> "“I thought this was a *Gentlemen*'s Club.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Petr Vectern: "“Would you rather get served by wrinkly old men? Sweethea..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "“So this is what you've been hiding from Evelyn.”"]** — Mówca: **Player**
> "“So this is what you've been hiding from Evelyn.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Petr Vectern: "“No one is hiding anything. She knows how important it is..."*)

### Węzeł `[58]`
Mówca: **Petr Vectern**
> "“Lespian caviar, best in the world! I'm telling you, Anton, there are few pleasures in life that are this...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "As the waitress left us to serve another attendee, she fl..."*)

### Węzeł `[59]`
Mówca: **Petr Vectern**
> "“No one is hiding anything. She knows how important it is for men like us to blow off steam once in a while.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "He averted his gaze for a second before calling over one ..."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "He averted his gaze for a second before calling over one of the waitresses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "She was in her mid-twenties, wearing red lipstick, her bl..."*)

### Węzeł `[61]`
Mówca: **Petr Vectern**
> "“Would you rather get served by wrinkly old men? Sweetheart! Over here!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "He waved at one of the waitresses, and she came over to us."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "He waved at one of the waitresses, and she came over to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "She was in her mid-twenties, wearing red lipstick, her bl..."*)

### Węzeł `[63]`
Mówca: **Narrator**
> "As the waitress left us to serve another attendee, she flashed a quick smile at Petr over her shoulder. He smiled back, a little too broadly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Petr Vectern: ""...Sensual.""*)

### Węzeł `[64]`
Mówca: **Petr Vectern**
> "“Oh look, there's Gus. Why don't you go talk to him? I'll be back in a minute.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: "“Petr. I am warning you. Don't make a mistake.”"*)
  - -> `[66]` (*Player: "“Where are you going?”"*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“Petr. I am warning you. Don't make a mistake.”"]** — Mówca: **Player**
> "“Petr. I am warning you. Don't make a mistake.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Petr Vectern: "“Mistake? What are you talking about? I'm just going to t..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“Where are you going?”"]** — Mówca: **Player**
> "“Where are you going?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Petr Vectern: ""Oh, just to the washroom. See you shortly.""*)

### Węzeł `[67]`
Mówca: **Petr Vectern**
> "“Mistake? What are you talking about? I'm just going to the... washroom. See you shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "He left the room and I headed over to Gus."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "He left the room and I headed over to Gus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "Gus Manger was standing next to a couple of men that I re..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "Gus Manger was standing next to a couple of men that I recognized as banking industry magnates. As I approached, all of them turned to me and bowed their heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Gus Manger: "“Mr. President. A toast to our new member, everyone!”"*)

### Węzeł `[70]`
Mówca: **Gus Manger**
> "“Mr. President. A toast to our new member, everyone!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "Gus and I clinked our glasses as the people around us rai..."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "Gus and I clinked our glasses as the people around us raised theirs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player: "“You don't seem at all surprised to see me here.”"*)
  - -> `[73]` (*Player: "“How long have you been a member?”"*)
  - -> `[74]` (*Player: "“I heard this mansion is a result of your connections.”"*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "“You don't seem at all surprised to see me here.”"]** — Mówca: **Player**
> "“You don't seem at all surprised to see me here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Gus Manger: "“That's because Petr told me you were going to come.”"*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "“How long have you been a member?”"]** — Mówca: **Player**
> "“How long have you been a member?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Gus Manger: "“Since the beginning. It's a fun gathering, and quite luc..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“I heard this mansion is a result of your connections.”"]** — Mówca: **Player**
> "“I heard this mansion is a result of your connections.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Gus Manger: "“That's right. I do have a wide network in real estate.”"*)

### Węzeł `[75]`
Mówca: **Gus Manger**
> "“That's right. I do have a wide network in real estate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Gus Manger: "“Petr told me a couple of weeks ago that you might be int..."*)

### Węzeł `[76]`
Mówca: **Petr Vectern**
> "“We all know why we're gathered here tonight. To celebrate life. To have a brief escape from our tumultuous professions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Petr Vectern: "“I personally don't know any better cure for stress than ..."*)

### Węzeł `[77]`
Mówca: **Petr Vectern**
> "“I personally don't know any better cure for stress than a little drink.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: "“Only a little one?”"*)
  - -> `[82]` (*Player: "“I'll drink to that!”"*)
  - -> `[81]` (*Player_Italic: "Raise your glass."*)

### Węzeł `[78]`
Mówca: **Petr Vectern**
> "“Now. The tradition dictates that as the club president, I have to remind you of our house rules. There are three. No politics. No wives. No one sober! Cheers!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "Petr drank the whiskey in his glass in one go."*)

### Węzeł `[79]`
Mówca: **Narrator**
> "Petr drank the whiskey in his glass in one go."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player_Italic: "Sip your whiskey."*)
  - -> `[85]` (*Player_Italic: "Drain your glass."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "“Only a little one?”"]** — Mówca: **Player**
> "“Only a little one?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "A few people in the crowd chuckled and some raised their ..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "Raise your glass."]** — Mówca: **Player_Italic**
> "I raised my glass and the rest of the crowd followed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Petr Vectern: "“Now. The tradition dictates that as the club president, ..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "“I'll drink to that!”"]** — Mówca: **Player**
> "“I'll drink to that!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "People in the crowd laughed and raised their glasses."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "A few people in the crowd chuckled and some raised their glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Petr Vectern: "“Now. The tradition dictates that as the club president, ..."*)

### Węzeł `[84]`
Mówca: **Narrator**
> "People in the crowd laughed and raised their glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Petr Vectern: "“Now. The tradition dictates that as the club president, ..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA: "Drain your glass."]** — Mówca: **Player_Italic**
> "I followed suit and drained my glass. It was immediately replenished."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Petr Vectern: "“Anton Rayne might have the power to make presidential de..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "Sip your whiskey."]** — Mówca: **Player_Italic**
> "I took a sip from my whiskey."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Petr Vectern: "“Anton Rayne might have the power to make presidential de..."*)

### Węzeł `[87]`
Mówca: **Gus Manger**
> "“Since the beginning. It's a fun gathering, and quite lucrative at times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Gus Manger: "“You might've heard from Petr that I arranged the deal fo..."*)

### Węzeł `[88]`
Mówca: **Gus Manger**
> "“That's because Petr told me you were going to come.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Gus Manger: "“He also told me that you might be interested in potentia..."*)

### Węzeł `[89]`
Mówca: **Gus Manger**
> "“He also told me that you might be interested in potential opportunities such as, well... this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "He opened his arms, gesturing at our opulent surroundings."*)

### Węzeł `[90]`
Mówca: **Narrator**
> "He opened his arms, gesturing at our opulent surroundings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Gus Manger: "“Let's take a walk. The balcony has an amazing view of Er..."*)

### Węzeł `[91]`
Mówca: **Gus Manger**
> "“You might've heard from Petr that I arranged the deal for this mansion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Gus Manger: "“He also told me that you might be interested in potentia..."*)

### Węzeł `[92]`
Mówca: **Gus Manger**
> "“Petr told me a couple of weeks ago that you might be interested in potential opportunities such as, well... this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "He opened his arms, gesturing at our opulent surroundings."*)

### Węzeł `[93]`
Mówca: **Gus Manger**
> "“Let's take a walk. The balcony has an amazing view of Erlory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "We left the room and made our way to the balcony. On the ..."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "We left the room and made our way to the balcony. On the way, he took out two cigars and held one out for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player_Italic: "Take the cigar."*)
  - -> `[96]` (*Player_Italic: "Refuse the cigar."*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "Take the cigar."]** — Mówca: **Player_Italic**
> "I took the cigar and started smoking it. Mixed with the taste of whiskey, it was delicious."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "We went out to the balcony. All of Erlory was at our feet..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA: "Refuse the cigar."]** — Mówca: **Player_Italic**
> "I turned the cigar down. Gus lit up his own and started smoking."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "We went out to the balcony. All of Erlory was at our feet..."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "We went out to the balcony. All of Erlory was at our feet. From this vantage point, I was able to see how expansive the building plot was. The swimming pool and the hedge maze were visible from here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "Leaning over the railing, I admired the view for a moment..."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "Leaning over the railing, I admired the view for a moment before Gus spoke up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Gus Manger: "“I know you're wondering about the deal Petr made. In a n..."*)

### Węzeł `[99]`
Mówca: **Gus Manger**
> "“Real estate is the best investment anyone can make. With the current economic situation, it only makes sense to put your money into such a tangible asset.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Gus Manger: "“But I also have a few other opportunities for you to mak..."*)

### Węzeł `[100]`
Mówca: **Gus Manger**
> "“But I also have a few other opportunities for you to make a side profit, if real estate doesn't interest you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Gus Manger: "“Is there any chance I can convince you?”"*)

### Węzeł `[101]`
Mówca: **Gus Manger**
> "“Is there any chance I can convince you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: "“No. That's my final answer.”"*)
  - -> `[126]` (*Player: "“All right. Let me see what you have available.”"*)

### Węzeł `[102]`
Mówca: **Gus Manger**
> "“I would be delighted to discuss a similar arrangement with you. In fact, I have prepared a document with my own personal favorite opportunities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ==..."*)

### Węzeł `[103]`
Mówca: **Petr Vectern**
> "“He'll have a once-in-a-lifetime deal ready for you. He always does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "We continued walking until we circled back to where we ha..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn01_InT_Investment_Railway == true || BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true) && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false || BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn01_InT_Investment_Railway == true || BaseGa..."*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Turn01_InT_Investment_Railway == true || Base..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn01_InT_Investment_Railway == true || BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true) && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false || BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  or  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true)  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Gus Manger: "“I would be delighted to discuss a similar arrangement wi..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Turn01_InT_Investment_Railway == true || BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true) && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false || BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  or  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true)  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Player: "“I'd like to make a similarly profitable arrangement myse..."*)
  - -> `[170]` (*Player: ""You're wrong. I wasn't wondering.""*)
  - -> `[169]` (*Player: "“That cheap, huh?”"*)

### Węzeł `[107]`
Mówca: **Gus Manger**
> "“I would have been delighted to work with you, but unfortunately a deal won't be possible at this time. Not from me or my contacts at least.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: "“Why is that?”"*)
  - -> `[110]` (*Player: "“I thought as much.”"*)

### Węzeł `[108]`
Mówca: **Gus Manger**
> "“The Gasom affair notwithstanding, you've shown plenty of generosity to Sordish businesses. You deserve a chance to profit personally from their gains.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: "“I am not looking to make any investments at the moment.”"*)
  - -> `[131]` (*Player: "“What's in it for you?”"*)
  - -> `[119]` (*Player: "“I'm glad my investment decisions are paying off.”"*)
  - -> `[118]` (*Player: "“Thank you.”"*)

### Węzeł `[109]`
**[WYBÓR GRACZA: "“Why is that?”"]** — Mówca: **Player**
> "“Why is that?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == false"*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "“I thought as much.”"]** — Mówca: **Player**
> "“I thought as much.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Gus Manger: "“It's unfortunate.”"*)

### Węzeł `[111]`
Mówca: **Gus Manger**
> "“There have been some issues with my business, Mr. Rayne. Nothing life-or-death. But the hard work I put on the cancelled railway took up so much of my time that I've had to postpone some projects. I'm sure you understand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: "“I understand.”"*)
  - -> `[113]` (*Player: "“Think of it as an investment.”"*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "“I understand.”"]** — Mówca: **Player**
> "“I understand.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Gus Manger), `[243]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "He downed his whiskey."*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "“Think of it as an investment.”"]** — Mówca: **Player**
> "“Think of it as an investment.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Gus Manger), `[243]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Gus Manger: "“I have already made my investment. Unfortunately, I have..."*)

### Węzeł `[114]`
Mówca: **Gus Manger**
> "“It's unfortunate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "He downed his whiskey."*)

### Węzeł `[115]`
Mówca: **Gus Manger**
> "“I have already made my investment. Unfortunately, I have yet to see a return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "He downed his whiskey."*)

### Węzeł `[116]`
Mówca: **Gus Manger**
> "“I know you're wondering about the deal Petr made. In a nutshell, thanks to my network he was able to procure this house for half the asking price, which would've been impossible under any other circumstances.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn01_InT_Investment_Railway == true || BaseGa..."*)

### Węzeł `[117]`
Mówca: **Gus Manger**
> ""Let me be direct.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Gus Manger: "“I would have been delighted to work with you, but unfort..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Gus Manger), `[274]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Gus Manger: "“No, Mr. President.”"*)

### Węzeł `[119]`
**[WYBÓR GRACZA: "“I'm glad my investment decisions are paying off.”"]** — Mówca: **Player**
> "“I'm glad my investment decisions are paying off.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Gus Manger), `[274]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Gus Manger: "“Cheers to investments paying off, then.”"*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "“I am not looking to make any investments at the moment.”"]** — Mówca: **Player**
> "“I am not looking to make any investments at the moment.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Gus Manger), `[274]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Gus Manger: "“Real estate is the best investment anyone can make. With..."*)

### Węzeł `[121]`
Mówca: **Gus Manger**
> "“Cheers to investments paying off, then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "He downed his whiskey."*)

### Węzeł `[122]`
Mówca: **Narrator**
> "He downed his whiskey."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Gus Manger: "“Let's talk about the details, then.”"*)

### Węzeł `[123]`
Mówca: **Gus Manger**
> "“No, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Gus Manger: "“Thank you.”"*)

### Węzeł `[124]`
Mówca: **Gus Manger**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Gus Manger: "“Let's talk about the details, then.”"*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "“No. That's my final answer.”"]** — Mówca: **Player**
> "“No. That's my final answer.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Gus Manger: "“Very well. I won't push further.”"*)

### Węzeł `[126]`
**[WYBÓR GRACZA: "“All right. Let me see what you have available.”"]** — Mówca: **Player**
> "“All right. Let me see what you have available.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Gus Manger: ""I knew you'd come around.""*)

### Węzeł `[127]`
Mówca: **Gus Manger**
> "“Very well. I won't push further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Gus Manger: "“If you'll excuse me, I'm going to refresh my drink. See ..."*)

### Węzeł `[128]`
Mówca: **Gus Manger**
> "“Let's talk about the details, then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "Gus opened his briefcase and pulled out a thin dossier. H..."*)

### Węzeł `[129]`
Mówca: **Narrator**
> "He downed his whiskey."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Gus Manger: "“If you'll excuse me now, I will go refresh my drink. See..."*)

### Węzeł `[130]`
Mówca: **Gus Manger**
> "“If you'll excuse me now, I will go refresh my drink. See you around.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_Personal_ReturnOfInvestment2 = true"*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "“What's in it for you?”"]** — Mówca: **Player**
> "“What's in it for you?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Gus Manger), `[274]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Gus Manger: "“Nothing, Mr. President. It's a simple thank you for supp..."*)

### Węzeł `[132]`
Mówca: **Gus Manger**
> "“Nothing, Mr. President. It's a simple thank you for supporting me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "He downed his whiskey."*)

### Węzeł `[133]`
Mówca: **Gus Manger**
> "“If you'll excuse me, I'm going to refresh my drink. See you around.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_Personal_ReturnOfInvestment2 = true"*)

### Węzeł `[134]`
Mówca: **Narrator**
> "Gus opened his briefcase and pulled out a thin dossier. He showed it to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Gus Manger: ""My first offer is, of course, real estate. There is a vi..."*)

### Węzeł `[135]`
Mówca: **Gus Manger**
> ""There's also the option of a football partnership. I already own a large portion of FC Anrica, and I'm doing my best to make them champions. Buying in would be more expensive than the vineyard, but this season will bring a lot of returns, I'm quite positive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn02_InT_Corporation_UnderhallConstruction ==..."*)

### Węzeł `[136]`
Mówca: **Gus Manger**
> "“My biggest opportunity, though, is the possibility to buy shares in Underhall Construction. My connections ensured me that this would not be open to the public and would benefit you greatly. As you know, they are the biggest construction company in Sordland...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Gus Manger: "“Give me the word, and I will start the procurement proce..."*)

### Węzeł `[137]`
Mówca: **Gus Manger**
> ""My first offer is, of course, real estate. There is a vineyard close to Erlory, about a one-hour drive from here, that also includes a very large villa. A beautiful plot, but rather neglected, so there would be a fair amount of renovation costs. On the bright side, you would be able to produce your own wine. The previous owner was Giralt of Ribery, a world-renowned vintner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Gus Manger: ""There's also the option of a football partnership. I alr..."*)

### Węzeł `[138]`
Mówca: **Gus Manger**
> "“Give me the word, and I will start the procurement process. But we must act quickly as these options might soon disappear off the market.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 1"*)
  - -> `[142]` (*Player: "“On second thought, I don't want to do this now.”"*)

### Węzeł `[139]`
**[WYBÓR GRACZA: "“Football sounds exciting. I'll invest in FC Anrica.” [-2 Personal Wealth]"]** — Mówca: **Player**
> "“Football sounds exciting. I'll invest in FC Anrica.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Kontekst wejściowy (poprzednik):** `[138]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica = true; BaseGameSupport.Journa..."*)

### Węzeł `[140]`
**[WYBÓR GRACZA: "“I'll invest in Underhall Construction.” [-2 Personal Wealth]"]** — Mówca: **Player**
> "“I'll invest in Underhall Construction.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true)  and  Variable["BaseGame.Faction_Oligarchs_Content"] == true` AND `Variable["BaseGame.PersonalWealth"] > 1`
- **Kontekst wejściowy (poprzednik):** `[138]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Underhall = true; BaseGameSupport.Journ..."*)

### Węzeł `[141]`
**[WYBÓR GRACZA: "“The vineyard in Erlory. I've always wanted to have my own wine. And it sounds peaceful and quiet.” [-1 Personal Wealth]"]** — Mówca: **Player**
> "“The vineyard in Erlory. I've always wanted to have my own wine. And it sounds peaceful and quiet.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Kontekst wejściowy (poprzednik):** `[138]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Vineyard = true; BaseGameSupport.Journa..."*)

### Węzeł `[142]`
**[WYBÓR GRACZA: "“On second thought, I don't want to do this now.”"]** — Mówca: **Player**
> "“On a second thought, I don't want to do this now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_Personal_ReturnOfInvestment2 = true"*)

### Węzeł `[143]`
Mówca: **Gus Manger**
> "“Very well. Do not blame me if they are not available at a later date.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Gus Manger: "“If you'll excuse me, I'm going to refresh my drink. See ..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Underhall = true; BaseGameSupport.Journal_Turn05_GusInvestment_Underhall = true; BaseGame.Accepted_PersonalInvestment2 = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn05_P_Underhall"] = true;
Variable["BaseGameSupport.Journal_Turn05_GusInvestment_Underhall"] = true;
Variable["BaseGame.Accepted_PersonalInvestment2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth -= 2"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica = true; BaseGameSupport.Journal_Turn05_GusInvestment_FCAnrica = true; BaseGame.Accepted_PersonalInvestment2 = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn05_P_FCAnrica"] = true;
Variable["BaseGameSupport.Journal_Turn05_GusInvestment_FCAnrica"] = true;
Variable["BaseGame.Accepted_PersonalInvestment2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth -= 2"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Vineyard = true; BaseGameSupport.Journal_Turn05_GusInvestment_Winery = true; BaseGame.Accepted_PersonalInvestment2 = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn05_P_Vineyard"] = true;
Variable["BaseGameSupport.Journal_Turn05_GusInvestment_Winery"] = true;
Variable["BaseGame.Accepted_PersonalInvestment2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth -= 1"*)

### Węzeł `[147]`
Mówca: **Gus Manger**
> "“Excellent. I will start the process right away. Now if you'll excuse me, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "He left to rejoin the party. Alone on the balcony, I look..."*)

### Węzeł `[148]`
Mówca: **Gus Manger**
> "“If you'll excuse me, I'm going to refresh my drink. See you around.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "He left to rejoin the party. Alone on the balcony, I look..."*)

### Węzeł `[149]`
Mówca: **Narrator**
> "He left to rejoin the party. Alone on the balcony, I looked out over Erlory."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "Suddenly, I heard a rustling from the hedge maze below."*)

### Węzeł `[150]`
Mówca: **Narrator**
> "Suddenly, I heard a rustling from the hedge maze below."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "I looked down and saw a silhouette. Two silhouettes, actu..."*)

### Węzeł `[151]`
Mówca: **Narrator**
> "I looked down and saw a silhouette. Two silhouettes, actually, so close together they seemed to be entangled. I squinted and tried to get a better look. It was definitely two people kissing, but I couldn't see either of their faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "I returned to the party and spent some time mingling with..."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "I returned to the party and spent some time mingling with the other guests, engaging them in small talk about their businesses, their children, their relationships."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "I realized it had been a while since Petr left. I looked ..."*)

### Węzeł `[153]`
Mówca: **Narrator**
> "Just then, Petr came up from behind us and threw an arm around each of our shoulders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Petr Vectern: ""Look at you two! Sordland's bright future and its ancien..."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "He poured us two large glasses of whiskey, and we drank them in one go. Throughout the party, we drank and drank. Just like old times."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "I woke up the next day with a pounding headache and more ..."*)

### Węzeł `[155]`
Mówca: **Narrator**
> "I woke up the next day with a pounding headache and more than a few regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "My recollections of the evening were hazy, but there was ..."*)

### Węzeł `[156]`
Mówca: **Narrator**
> "My recollections of the evening were hazy, but there was one important detail that kept coming back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "The red lipstick on Petr's collar."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "The red lipstick on Petr's collar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "But maybe my memory was playing tricks on me."*)

### Węzeł `[158]`
Mówca: **Narrator**
> "But maybe my memory was playing tricks on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == true"*)

### Węzeł `[159]`
Mówca: **Narrator**
> "I took a bite. It was rich, salty, tasting of pure seaside. I could almost hear the sound of waves and seagulls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Petr Vectern: "“Lespian caviar, best in the world! I'm telling you, Anto..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn05_Personal_PetrParty = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn05_Personal_PetrParty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 1"*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 1)"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player: "“The vineyard in Erlory. I've always wanted to have my ow..."*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn02_InT_Corporation_UnderhallConstruction ==..."*)
  - -> `[139]` (*Player: "“Football sounds exciting. I'll invest in FC Anrica.” [-2..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path"*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path)"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Petr Vectern: "“Anton! Finally! Come in, relax, take a break from this c..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Petr Vectern: "“Anton! Finally! Now the real party can start. Come on in!”"*)

### Węzeł `[167]`
Mówca: **Petr Vectern**
> "“Anton! Finally! Come in, relax, take a break from this crisis!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "As soon as I entered, Petr closed the door and turned to ..."*)

### Węzeł `[168]`
**[WYBÓR GRACZA: "“I'd like to make a similarly profitable arrangement myself.”"]** — Mówca: **Player**
> "“I'd like to make a similarly profitable arrangement myself.”"
- **Wymagania odblokowania (kod gry):** `((Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  or  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true)  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[116]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Gus Manger: ""Let me be direct.”"*)

### Węzeł `[169]`
**[WYBÓR GRACZA: "“That cheap, huh?”"]** — Mówca: **Player**
> "“That cheap, huh?”"
- **Wymagania odblokowania (kod gry):** `((Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  or  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true)  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[116]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Gus Manger: ""You must know that the offered price is not suitable for..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA: ""You're wrong. I wasn't wondering.""]** — Mówca: **Player**
> ""You're wrong. I wasn't wondering.""
- **Wymagania odblokowania (kod gry):** `((Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  or  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true)  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[116]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Gus Manger: "“Very well, then.”"*)

### Węzeł `[171]`
Mówca: **Gus Manger**
> "“Very well, then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "He downed his whiskey."*)

### Węzeł `[172]`
**[WYBÓR GRACZA: "“I don't think I can afford an investment right now.”"]** — Mówca: **Player**
> "“I don't think I can afford an investment right now.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.PersonalWealth"] > 0) == false` AND `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Kontekst wejściowy (poprzednik):** `[138]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Gus Manger: "“Really?”"*)

### Węzeł `[173]`
Mówca: **Gus Manger**
> "“Really?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_Personal_ReturnOfInvestment2 = true"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true || BaseGame.Media_SordlandToday_Bias == true) && BaseGame.Faction_Oligarchs_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn02_InT_Corporation_UnderhallConstruction ==..."*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Turn02_InT_Corporation_UnderhallConstruction ..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true || BaseGame.Media_SordlandToday_Bias == true) && BaseGame.Faction_Oligarchs_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true)  and  Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Gus Manger: "“My biggest opportunity, though, is the possibility to bu..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true || BaseGame.Media_SordlandToday_Bias == true) && BaseGame.Faction_Oligarchs_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true)  and  Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Gus Manger: "“Give me the word, and I will start the procurement proce..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true || BaseGame.Media_SordlandToday_Bias == true) && BaseGame.Faction_Oligarchs_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn02_InT_Corporation_UnderhallConstruction ==..."*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Turn02_InT_Corporation_UnderhallConstruction ..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true || BaseGame.Media_SordlandToday_Bias == true) && BaseGame.Faction_Oligarchs_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true)  and  Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player: "“I'll invest in Underhall Construction.” [-2 Personal Wea..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true || BaseGame.Media_SordlandToday_Bias == true) && BaseGame.Faction_Oligarchs_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true)  and  Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Uziren_BludishProtestBill_A..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Uziren_BludishProtestBill =..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Uziren_BludishProtestBill_A = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Uziren_BludishProtestBill_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Signed a bill which restricts religious ..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Uziren_BludishProtestBill = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Uziren_BludishProtestBill"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Signed a bill which restricts religious ..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Holsord_HPEditorSuspect = t..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Holsord_HPEditorSuspect = true;
BaseGameSupport.News_Turn05_R_StateWarYS = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_HPEditorSuspect"] = true;
Variable["BaseGameSupport.News_Turn05_R_StateWarYS"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_PoliceAuthority == true || BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true |..."*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_PoliceAuthority == true || BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Erzaren_PoliceReport = true"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true || BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Erzaren_PoliceReport = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Erzaren_PoliceReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_ReligionBill_Signed_Deal =..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_ReligionBill_Vetoed_Deal =..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_ReligionBill_Signed_Deal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_ReligionBill_Signed_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I was starting to lose my focus, and my temper was growin..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_ReligionBill_Signed_NoDeal..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I was starting to lose my focus, and my temper was growin..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_ReligionBill_Vetoed_Deal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_ReligionBill_Vetoed_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I was starting to lose my focus, and my temper was growin..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_ReligionBill_Signed_NoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_ReligionBill_Signed_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I was starting to lose my focus, and my temper was growin..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_PetrParty_NoDeal = true"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_PetrParty_NoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_PetrParty_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn06_Personal_ReturnOfInvestment2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn06_Personal_ReturnOfInvestment2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Gus Manger: "“Very well. Do not blame me if they are not available at ..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Gus Manger: "“Excellent. I will start the process right away. Now if y..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Gus Manger: "“Excellent. I will start the process right away. Now if y..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Gus Manger: "“Excellent. I will start the process right away. Now if y..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 0)"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player: "“The vineyard in Erlory. I've always wanted to have my ow..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player: "“I don't think I can afford an investment right now.”"*)

### Węzeł `[219]`
**[WYBÓR GRACZA: "“Really?”"]** — Mówca: **Player**
> "“Really?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Petr Vectern: "“That's what it says on my tax forms, at least.”"*)

### Węzeł `[220]`
**[WYBÓR GRACZA: "“I don't believe you.”"]** — Mówca: **Player**
> "“I don't believe you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Petr Vectern: "“That's what it says on my tax forms, at least.”"*)

### Węzeł `[221]`
Mówca: **Petr Vectern**
> "“That's what it says on my tax forms, at least.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "We continued walking until we circled back to where we ha..."*)

### Węzeł `[222]`
Mówca: **Petr Vectern**
> ""...Sensual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Narrator: "His eyes were still fixed on her, with an expression I re..."*)

### Węzeł `[223]`
Mówca: **Narrator**
> "His eyes were still fixed on her, with an expression I remembered from our many nights out together as students."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Petr Vectern: "“Oh look, there's Gus. Why don't you go talk to him? I'll..."*)

### Węzeł `[224]`
Mówca: **Petr Vectern**
> ""Oh, just to the washroom. See you shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "He left the room and I headed over to Gus."*)

### Węzeł `[225]`
Mówca: **Gus Manger**
> ""I knew you'd come around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "Gus opened his briefcase and pulled out a thin dossier. H..."*)

### Węzeł `[226]`
**[WYBÓR GRACZA: "“That's nice of you.”"]** — Mówca: **Player**
> "“That's nice of you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Petr Vectern: "“That's what it says on my tax forms, at least.”"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_G_ArcasiaAid = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_G_ArcasiaAid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true |..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_G_UCAid = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_G_UCAid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true |..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true && BaseGame.Promise_Diplomacy_West == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true && B..."*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true &&..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true && BaseGame.Promise_Diplomacy_West == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true  and  Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_G_ArcasiaAid = true"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true && BaseGame.Promise_Diplomacy_West == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true  and  Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == tru..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true && BaseGame.Promise_Diplomacy_East == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == tru..."*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == t..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true && BaseGame.Promise_Diplomacy_East == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  and  Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_G_UCAid = true"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true && BaseGame.Promise_Diplomacy_East == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  and  Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true |..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Privatization == true)"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Lachaven_EducationPrivatiza..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Holsord_FireInvestigationHo..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Lachaven_EducationPrivatizationResult = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Lachaven_EducationPrivatizationResult"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Holsord_FireInvestigationHo..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn06_Personal_ReturnOfInvestment2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn06_Personal_ReturnOfInvestment2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "He left to rejoin the party. Alone on the balcony, I look..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == false"*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Railway == false)"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Gus Manger: "“There have been some issues with my business, Mr. Rayne...."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Railway == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Gus Manger: "“There have been some issues with my business, Mr. Rayne...."*)

### Węzeł `[243]`
Mówca: **Gus Manger**
> "“There have been some issues with my business, Mr. Rayne. Nothing life-or-death. But I've been putting so much work into advancing rural development that I've had to postpone some projects. I'm sure you understand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: "“I understand.”"*)
  - -> `[113]` (*Player: "“Think of it as an investment.”"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true"*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromotePlanned == true"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses =..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy -= 1;"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy -= 1;"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true"*)
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == t..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromotePlanned == true"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Far from becoming accustomed to my workload as president,..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn06_Personal_ReturnOfInvestment2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn06_Personal_ReturnOfInvestment2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "He left to rejoin the party. Alone on the balcony, I look..."*)

### Węzeł `[262]`
Mówca: **Gus Manger**
> ""You must know that the offered price is not suitable for every client.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Gus Manger: "“I would have been delighted to work with you, but unfort..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Holsord_FireInvestigationHold = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_FireInvestigationHold"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Personal_PetrParty = true"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("MansionParty");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("MansionParty");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "And so I found myself in front of his new luxury villa in..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Sarna_BFFPropagandaInSchools = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Sarna_BFFPropagandaInSchools"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_HP_BFFPropaganda = true"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_HP_BFFPropaganda = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_BFFPropaganda"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Signed a bill which restricts religious freedoms", "Maroon Palace", "Holsord");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Signed a bill which restricts religious freedoms","Maroon Palace","Holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why am I not surprised? Gus the wheeler and dealer would be right at home at a party like this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Petr Vectern: ""Hell, half of the guests here owe their considerable ric..."*)

### Węzeł `[270]`
Mówca: **Petr Vectern**
> ""Hell, half of the guests here owe their considerable riches to him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "We continued walking until we circled back to where we ha..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ==..."*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true  or  Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Gus Manger: "“Your willingness to invest in Gasom showed you were a ma..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true  or  Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Gus Manger: "“The Gasom affair notwithstanding, you've shown plenty of..."*)

### Węzeł `[274]`
Mówca: **Gus Manger**
> "“Your willingness to invest in Gasom showed you were a man after my own heart. I'd love to talk about how my network can benefit you personally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: "“I am not looking to make any investments at the moment.”"*)
  - -> `[131]` (*Player: "“What's in it for you?”"*)
  - -> `[119]` (*Player: "“I'm glad my investment decisions are paying off.”"*)
  - -> `[118]` (*Player: "“Thank you.”"*)

### Węzeł `[275]`
Mówca: **Narrator**
> "I realized it had been a while since Petr left. I looked around, but couldn't find him. Instead, my eyes landed on Ewald Alphonso."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "AddConversant("Ewald Alphonso");"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Ewald Alphonso");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Ewald Alphonso");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Discontent == true"*)

### Węzeł `[277]`
Mówca: **Narrator**
> "With a reluctant look in his eyes, the former president walked over to meet me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Player: ""Mr. Alphonso. I didn't know you were a member of Petr's ..."*)
  - -> `[284]` (*Player: ""Isn't a party like this a little low-class for a man lik..."*)
  - -> `[285]` (*Player: ""You know the rules. No politics.""*)
  - -> `[283]` (*Player: ""Mr. President. Is that an empty glass I see in your hand?""*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Discontent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Discontent == true"*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_Discontent == true)"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Discontent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Discontent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "With a reluctant look in his eyes, the former president w..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_Discontent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Discontent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "With a smile, the former president walked over to meet me."*)

### Węzeł `[281]`
Mówca: **Narrator**
> "With a smile, the former president walked over to meet me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Player: ""Mr. Alphonso. I didn't know you were a member of Petr's ..."*)
  - -> `[284]` (*Player: ""Isn't a party like this a little low-class for a man lik..."*)
  - -> `[285]` (*Player: ""You know the rules. No politics.""*)
  - -> `[283]` (*Player: ""Mr. President. Is that an empty glass I see in your hand?""*)

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Alphonso. I didn't know you were a member of Petr's club.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Narrator), `[281]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Ewald Alphonso: ""I'm not. Gus and I were having a business dinner, and he..."*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. President. Is that an empty glass I see in your hand?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Narrator), `[281]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Ewald Alphonso: ""I'm trying to pace myself. Gus and I split a bottle of R..."*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Isn't a party like this a little low-class for a man like you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Narrator), `[281]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Ewald Alphonso: ""The surroundings are a little tacky, I admit. But Gus co..."*)

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know the rules. No politics.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Narrator), `[281]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Ewald Alphonso: ""No politics. But plenty of side deals, it seems.""*)

### Węzeł `[286]`
Mówca: **Ewald Alphonso**
> ""I'm not. Gus and I were having a business dinner, and he convinced me to come along afterwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Ewald Alphonso: ""I saw you speaking to Mr. Manger earlier.""*)

### Węzeł `[287]`
Mówca: **Ewald Alphonso**
> ""The surroundings are a little tacky, I admit. But Gus convinced me the networking opportunities would be unparalleled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Ewald Alphonso: ""I saw you speaking to Mr. Manger earlier.""*)

### Węzeł `[288]`
Mówca: **Ewald Alphonso**
> ""I saw you speaking to Mr. Manger earlier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_PersonalInvestment2 == true"*)
  - -> `[298]` (*Player: ""We talked, yes. It's always nice to get to know one's mi..."*)

### Węzeł `[289]`
Mówca: **Ewald Alphonso**
> ""I'm trying to pace myself. Gus and I split a bottle of Rizian wine over dinner before heading here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Ewald Alphonso: ""I saw you speaking to Mr. Manger earlier.""*)

### Węzeł `[290]`
Mówca: **Ewald Alphonso**
> ""No politics. But plenty of side deals, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Ewald Alphonso: ""I saw you speaking to Mr. Manger earlier.""*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_PersonalInvestment2 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_PersonalInvestment2 == true"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_PersonalInvestment2 == true)"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_PersonalInvestment2 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_PersonalInvestment2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Player: ""That's right. He offered me some lucrative investment op..."*)
  - -> `[295]` (*Player: ""Yes, he and I are going into business together.""*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_PersonalInvestment2 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_PersonalInvestment2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Player: ""Just briefly. I wasn't interested in what he was offering.""*)
  - -> `[297]` (*Player: ""He seems used to making deals with sitting presidents. B..."*)

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's right. He offered me some lucrative investment opportunities.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Accepted_PersonalInvestment2"] == true`
- **Kontekst wejściowy (poprzednik):** `[288]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, he and I are going into business together.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Accepted_PersonalInvestment2"] == true`
- **Kontekst wejściowy (poprzednik):** `[288]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Just briefly. I wasn't interested in what he was offering.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Accepted_PersonalInvestment2"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[288]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He seems used to making deals with sitting presidents. But he and I won't be going into business.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Accepted_PersonalInvestment2"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[288]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We talked, yes. It's always nice to get to know one's ministers outside of the Maroon Palace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Ewald Alphonso: ""We had a good chat together back in Narbel, as I recall.""*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Ewald Alphonso: ""Hmm. Interesting that you'd take him up on that while ig..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Ewald Alphonso: ""Why not? Seems like a natural progression after our Gaso..."*)

### Węzeł `[302]`
Mówca: **Ewald Alphonso**
> ""Hmm. Interesting that you'd take him up on that while ignoring the far more lucrative opportunity to invest in Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == ..."*)

### Węzeł `[303]`
Mówca: **Ewald Alphonso**
> ""Why not? Seems like a natural progression after our Gasom deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == ..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == ..."*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_10Percent =..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Ewald Alphonso: ""We're seeing growing interest from international investo..."*)

### Węzeł `[307]`
Mówca: **Ewald Alphonso**
> ""Although your tightening of the Energy Protection Act shows your carelessness with that particular investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Player: ""No politics, remember?""*)
  - -> `[340]` (*Player: ""I'm sorry about that. My party forced me to do it.""*)
  - -> `[341]` (*Player: ""Unlike you, I know better than to mess with a successful..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true"*)
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true)"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Ewald Alphonso: ""Although your tightening of the Energy Protection Act --..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Ewald Alphonso: ""Although your tightening of the Energy Protection Act sh..."*)

### Węzeł `[311]`
Mówca: **Ewald Alphonso**
> ""Although your tightening of the Energy Protection Act -- despite your promise to me -- shows your carelessness with that particular investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Player: ""No politics, remember?""*)
  - -> `[340]` (*Player: ""I'm sorry about that. My party forced me to do it.""*)
  - -> `[341]` (*Player: ""Unlike you, I know better than to mess with a successful..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == ..."*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_10Percent =..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Ewald Alphonso: ""At any rate, it's doing fine without Sordland's input. A..."*)

### Węzeł `[315]`
Mówca: **Ewald Alphonso**
> ""Although your tightening of the Energy Protection Act proves that a profitable Gasom was never your goal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Player: ""No politics, remember?""*)
  - -> `[340]` (*Player: ""I'm sorry about that. My party forced me to do it.""*)
  - -> `[341]` (*Player: ""Unlike you, I know better than to mess with a successful..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true"*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true)"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Ewald Alphonso: ""Although your tightening of the Energy Protection Act --..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Ewald Alphonso: ""Although your tightening of the Energy Protection Act pr..."*)

### Węzeł `[319]`
Mówca: **Ewald Alphonso**
> ""Although your tightening of the Energy Protection Act -- despite your promise to me -- proves that a profitable Gasom was never your goal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Player: ""No politics, remember?""*)
  - -> `[340]` (*Player: ""I'm sorry about that. My party forced me to do it.""*)
  - -> `[341]` (*Player: ""Unlike you, I know better than to mess with a successful..."*)

### Węzeł `[320]`
Mówca: **Ewald Alphonso**
> ""At any rate, it's doing fine without Sordland's input. A shame that only its international investors will benefit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Player: ""And you, of course.""*)
  - -> `[338]` (*Player: ""I still stand by my decision. There were better uses for..."*)
  - -> `[339]` (*Player: ""Yes, perhaps Sordland should've invested. But it's too l..."*)

### Węzeł `[321]`
Mówca: **Ewald Alphonso**
> ""We're seeing growing interest from international investors, by the way. I'm optimistic about the results of Sordland's investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Player: ""Terrific. I'm looking forward to a big payoff.""*)
  - -> `[335]` (*Player: ""I'm glad that Sordland could help your company thrive.""*)
  - -> `[336]` (*Player: ""Enjoy our bailout, Mr. Alphonso. It'll be your only one.""*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Ewald Alphonso: ""It figures. I don't know why he thought you'd be interes..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Ewald Alphonso: ""Interesting. I would have thought you'd be interested in..."*)

### Węzeł `[325]`
Mówca: **Ewald Alphonso**
> ""It figures. I don't know why he thought you'd be interested in other investments after you passed on the Gasom opportunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == ..."*)

### Węzeł `[326]`
Mówca: **Ewald Alphonso**
> ""Interesting. I would have thought you'd be interested in other opportunities after investing in Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == ..."*)

### Węzeł `[327]`
Mówca: **Ewald Alphonso**
> ""We had a good chat together back in Narbel, as I recall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Ewald Alphonso: ""Before you turned down the opportunity to invest in Gaso..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Ewald Alphonso: ""Resulting in your very wise decision to invest Sordish m..."*)

### Węzeł `[331]`
Mówca: **Ewald Alphonso**
> ""Before you turned down the opportunity to invest in Gasom, that is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == ..."*)

### Węzeł `[332]`
Mówca: **Ewald Alphonso**
> ""Resulting in your very wise decision to invest Sordish money in Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == ..."*)

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No politics, remember?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Ewald Alphonso), `[311]` (Ewald Alphonso), `[315]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Narrator: "He sighed."*)

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Terrific. I'm looking forward to a big payoff.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Ewald Alphonso: ""I can't tell you for sure how big it will be. But our pr..."*)

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm glad that Sordland could help your company thrive.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Ewald Alphonso: ""And vice versa.""*)

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Enjoy our bailout, Mr. Alphonso. It'll be your only one.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Ewald Alphonso: ""As I've told you, this isn't a bailout. You'll get your ..."*)

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And you, of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Ewald Alphonso: ""That goes without saying.""*)

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I still stand by my decision. There were better uses for that money.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Ewald Alphonso: ""Better uses, maybe. But not more profitable ones.""*)

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, perhaps Sordland should've invested. But it's too late for regrets.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Ewald Alphonso: ""It's not too late to remember to take more risks in the ..."*)

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sorry about that. My party forced me to do it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Ewald Alphonso), `[311]` (Ewald Alphonso), `[315]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Ewald Alphonso: ""I know how much pressure the USP can exert. But I also k..."*)

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Unlike you, I know better than to mess with a successful Tarquin Soll policy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Ewald Alphonso), `[311]` (Ewald Alphonso), `[315]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Ewald Alphonso: ""That policy put a chokehold on Sordish businesses. Thank..."*)

### Węzeł `[342]`
Mówca: **Ewald Alphonso**
> ""I know how much pressure the USP can exert. But I also know that with a little courage, resistance is possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Ewald Alphonso: ""It seems your courage failed you. And you, in turn, have..."*)

### Węzeł `[343]`
Mówca: **Ewald Alphonso**
> ""It seems your courage failed you. And you, in turn, have failed Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "Just then, Petr came up from behind us and threw an arm a..."*)

### Węzeł `[344]`
Mówca: **Ewald Alphonso**
> ""That policy put a chokehold on Sordish businesses. Thanks to you, it is doing so again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "Just then, Petr came up from behind us and threw an arm a..."*)

### Węzeł `[345]`
Mówca: **Ewald Alphonso**
> ""That goes without saying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "Just then, Petr came up from behind us and threw an arm a..."*)

### Węzeł `[346]`
Mówca: **Ewald Alphonso**
> ""Better uses, maybe. But not more profitable ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "Just then, Petr came up from behind us and threw an arm a..."*)

### Węzeł `[347]`
Mówca: **Ewald Alphonso**
> ""It's not too late to remember to take more risks in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "Just then, Petr came up from behind us and threw an arm a..."*)

### Węzeł `[348]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)

### Węzeł `[349]`
Mówca: **Ewald Alphonso**
> ""No politics. But this conversation is not over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "Just then, Petr came up from behind us and threw an arm a..."*)

### Węzeł `[350]`
Mówca: **Ewald Alphonso**
> ""As I've told you, this isn't a bailout. You'll get your money back and then some.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "Just then, Petr came up from behind us and threw an arm a..."*)

### Węzeł `[351]`
Mówca: **Ewald Alphonso**
> ""And vice versa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "Just then, Petr came up from behind us and threw an arm a..."*)

### Węzeł `[352]`
Mówca: **Ewald Alphonso**
> ""I can't tell you for sure how big it will be. But our projections are looking good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "Just then, Petr came up from behind us and threw an arm a..."*)

### Węzeł `[353]`
Mówca: **Petr Vectern**
> ""Look at you two! Sordland's bright future and its ancient, ancient past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Player: ""Petr. Behave yourself.""*)
  - -> `[355]` (*Player: ""It's been an hour. Where were you?""*)
  - -> `[356]` (*Player: ""My apologies, Mr. Alphonso. My vice president's had a bi..."*)
  - -> `[357]` (*Player: ""Another brilliant zinger, Petr.""*)

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Petr. Behave yourself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[353]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Petr Vectern: ""Yes, Mr. President. Right away, Mr. President.""*)

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's been an hour. Where were you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[353]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Petr Vectern: ""I told you. The washroom. Trust me, you'd rather not kno..."*)

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My apologies, Mr. Alphonso. My vice president's had a bit too much to drink.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[353]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Petr Vectern: ""Pardon me, Mr. President, but I've had exactly enough.""*)

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Another brilliant zinger, Petr.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[353]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Petr Vectern: ""That's what I'm here for.""*)

### Węzeł `[358]`
Mówca: **Petr Vectern**
> ""I told you. The washroom. Trust me, you'd rather not know the details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Petr Vectern: ""Well, Mr. Alphonso? Have you been enjoying my hospitality?""*)

### Węzeł `[359]`
Mówca: **Petr Vectern**
> ""That's what I'm here for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Petr Vectern: ""Well, Mr. Alphonso? Have you been enjoying my hospitality?""*)

### Węzeł `[360]`
Mówca: **Petr Vectern**
> ""Pardon me, Mr. President, but I've had exactly enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Petr Vectern: ""Well, Mr. Alphonso? Have you been enjoying my hospitality?""*)

### Węzeł `[361]`
Mówca: **Petr Vectern**
> ""Yes, Mr. President. Right away, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Petr Vectern: ""Well, Mr. Alphonso? Have you been enjoying my hospitality?""*)

### Węzeł `[362]`
Mówca: **Petr Vectern**
> ""Well, Mr. Alphonso? Have you been enjoying my hospitality?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Narrator: "Alphonso smiled politely."*)

### Węzeł `[363]`
Mówca: **Narrator**
> "Alphonso smiled politely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Ewald Alphonso: ""Indeed I have, Mr. Vectern. You've put together one hell..."*)

### Węzeł `[364]`
Mówca: **Ewald Alphonso**
> ""Indeed I have, Mr. Vectern. You've put together one hell of a gathering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Ewald Alphonso: ""If you'll excuse me, I'm going to have a quick word with..."*)

### Węzeł `[365]`
Mówca: **Ewald Alphonso**
> ""If you'll excuse me, I'm going to have a quick word with the CEO of Sordish Petroleum.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Player: ""He's here, too? What a party.""*)
  - -> `[367]` (*Player: ""Have fun mingling. It was good to see you.""*)
  - -> `[368]` (*Player: ""We'll talk soon.""*)

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He's here, too? What a party.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "Alphonso gave a brusque wave and walked off."*)

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Have fun mingling. It was good to see you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "Alphonso gave a brusque wave and walked off."*)

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We'll talk soon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "Alphonso gave a brusque wave and walked off."*)

### Węzeł `[369]`
Mówca: **Narrator**
> "Alphonso gave a brusque wave and walked off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Ewald Alphonso");"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Ewald Alphonso");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Ewald Alphonso");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "Petr shifted his weight unsteadily."*)

### Węzeł `[371]`
Mówca: **Narrator**
> "Petr shifted his weight unsteadily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true || Base..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true || BaseGame.Prologue_Party_Takeover_PublicBlame == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true || Base..."*)
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_Backstab == true || Ba..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true || BaseGame.Prologue_Party_Takeover_PublicBlame == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true  or  Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Petr Vectern: ""Nice guy. I almost feel bad about the way we took him do..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_Backstab == true || BaseGame.Prologue_Party_Takeover_PublicBlame == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true  or  Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Petr Vectern: ""Nice guy. A shitty president, but a nice guy.""*)

### Węzeł `[375]`
Mówca: **Petr Vectern**
> ""Nice guy. I almost feel bad about the way we took him down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Player: ""Was that you in the hedge maze, Petr?""*)
  - -> `[379]` (*Player: ""I will give you one more chance. Where were you?""*)
  - -> `[378]` (*Player: ""Why didn't you tell me Ewald Alphonso was coming?""*)

### Węzeł `[376]`
Mówca: **Petr Vectern**
> ""Nice guy. A shitty president, but a nice guy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Player: ""Was that you in the hedge maze, Petr?""*)
  - -> `[379]` (*Player: ""I will give you one more chance. Where were you?""*)
  - -> `[378]` (*Player: ""Why didn't you tell me Ewald Alphonso was coming?""*)

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Was that you in the hedge maze, Petr?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[375]` (Petr Vectern), `[376]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Petr Vectern: ""What are you talking about?""*)

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why didn't you tell me Ewald Alphonso was coming?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[375]` (Petr Vectern), `[376]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Petr Vectern: ""I didn't know! Gus brought him along. And when a former ..."*)

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I will give you one more chance. Where were you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[375]` (Petr Vectern), `[376]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Narrator: "Petr assumed a patient look."*)

### Węzeł `[380]`
Mówca: **Petr Vectern**
> ""I didn't know! Gus brought him along. And when a former president of Sordland knocks on your door, you can't exactly turn him away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Player: ""You know what? Never mind. Let's get another drink.""*)
  - -> `[387]` (*Player: ""Next time, I want to be able to vet your guest list. You..."*)
  - -> `[388]` (*Player: ""It's fine. I was happy to see him. But it was definitely..."*)

### Węzeł `[381]`
Mówca: **Narrator**
> "Petr assumed a patient look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Petr Vectern: ""Well, Mr. President, when too much Sordish whiskey meets..."*)

### Węzeł `[382]`
Mówca: **Petr Vectern**
> ""Well, Mr. President, when too much Sordish whiskey meets too much Lespian caviar, it can lead to a gastrointestinal imbroglio the likes of which the world has never seen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Player: ""While you were gone, I saw two people kissing in the hed..."*)
  - -> `[385]` (*Player: ""I'll be direct. Were you with the waitress?""*)
  - -> `[386]` (*Player: ""You know what? Never mind. Let's get another drink.""*)

### Węzeł `[383]`
Mówca: **Petr Vectern**
> ""What are you talking about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Player: ""While you were gone, I saw two people kissing in the hed..."*)
  - -> `[385]` (*Player: ""I'll be direct. Were you with the waitress?""*)
  - -> `[386]` (*Player: ""You know what? Never mind. Let's get another drink.""*)

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""While you were gone, I saw two people kissing in the hedge maze outside.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[382]` (Petr Vectern), `[383]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Petr Vectern: ""Huh. Probably a couple of kitchen staff getting frisky w..."*)

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll be direct. Were you with the waitress?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[382]` (Petr Vectern), `[383]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Petr Vectern: ""What? No, no. How could you even think that? I'm a marri..."*)

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know what? Never mind. Let's get another drink.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[380]` (Petr Vectern), `[382]` (Petr Vectern), `[383]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Petr Vectern: ""Now you're speaking my language.""*)

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Next time, I want to be able to vet your guest list. You're risking a breach of national security with these parties.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[380]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Petr Vectern: ""Anton. Can't a man have some fun outside of work?""*)

### Węzeł `[388]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's fine. I was happy to see him. But it was definitely a surprise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[380]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Petr Vectern: ""That's what I'm aiming for with these parties. All kinds..."*)

### Węzeł `[389]`
Mówca: **Petr Vectern**
> ""Anton. Can't a man have some fun outside of work?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Petr Vectern: ""But sure. If it'll make you happy, I'll tighten my villa..."*)

### Węzeł `[390]`
Mówca: **Petr Vectern**
> ""Now you're speaking my language.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "He poured us two large glasses of whiskey, and we drank t..."*)

### Węzeł `[391]`
Mówca: **Petr Vectern**
> ""That's what I'm aiming for with these parties. All kinds of unexpected, stimulating encounters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Narrator: "He contorted the side of his face in an attempt at a wink."*)

### Węzeł `[392]`
Mówca: **Petr Vectern**
> ""What? No, no. How could you even think that? I'm a married man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Player: ""All right. If you say so.""*)
  - -> `[395]` (*Player: ""Petr. You know you can tell me anything.""*)

### Węzeł `[393]`
Mówca: **Petr Vectern**
> ""Huh. Probably a couple of kitchen staff getting frisky with each other. What do I even pay them for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Player: ""All right. If you say so.""*)
  - -> `[395]` (*Player: ""Petr. You know you can tell me anything.""*)

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""All right. If you say so.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[392]` (Petr Vectern), `[393]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Petr Vectern: ""I do say so.""*)

### Węzeł `[395]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Petr. You know you can tell me anything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[392]` (Petr Vectern), `[393]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Narrator: "I thought I saw his cheerful expression slip for a moment."*)

### Węzeł `[396]`
Mówca: **Petr Vectern**
> ""But sure. If it'll make you happy, I'll tighten my villa's border control policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Petr Vectern: ""Now who wants a drink? Besides me, of course.""*)

### Węzeł `[397]`
Mówca: **Narrator**
> "He contorted the side of his face in an attempt at a wink."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Petr Vectern: ""Now who wants a drink? Besides me, of course.""*)

### Węzeł `[398]`
Mówca: **Petr Vectern**
> ""Now who wants a drink? Besides me, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "He poured us two large glasses of whiskey, and we drank t..."*)

### Węzeł `[399]`
Mówca: **Narrator**
> "I thought I saw his cheerful expression slip for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Petr Vectern: ""Yeah. I know. Trust me, it's nothing.""*)

### Węzeł `[400]`
Mówca: **Petr Vectern**
> ""Yeah. I know. Trust me, it's nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Petr Vectern: ""Now who wants a drink? Besides me, of course.""*)

### Węzeł `[401]`
Mówca: **Petr Vectern**
> ""I do say so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Petr Vectern: ""Now who wants a drink? Besides me, of course.""*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)"*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Ewald Alphonso: ""No politics. But this conversation is not over.""*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Ewald Alphonso: ""No politics. But your returns are not looking good, to s..."*)

### Węzeł `[405]`
Mówca: **Ewald Alphonso**
> ""No politics. But your returns are not looking good, to say the least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "Just then, Petr came up from behind us and threw an arm a..."*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == true"*)
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == true)"*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_GruniRuralDev_NoFunding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_GruniRuralDev_NoFunding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_GruniRuralDev_GoodNoInvestment = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_GruniRuralDev_GoodNoInvestment"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true && B..."*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaBias == true)"*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_GruniRuralDev_GoodNoInvest..."*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_GruniRuralDev_BadNoInvestm..."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaBias == true)"*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_GruniRuralDev_GreatInvestm..."*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_GruniRuralDev_BadInvestmen..."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_GruniRuralDev_BadNoInvestment = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_GruniRuralDev_BadNoInvestment"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true && B..."*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_GruniRuralDev_GreatInvestment = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_GruniRuralDev_GreatInvestment"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true && B..."*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_GruniRuralDev_BadInvestment = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_GruniRuralDev_BadInvestment"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true && B..."*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_PromotePlanned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromotePlanned == true"*)
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_PromotePlanned == true)"*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_PromotePlanned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_PromotePlanned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy += 1;"*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_PromotePlanned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_PromotePlanned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy += 2;"*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_PromotePlanned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromotePlanned == true"*)
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_PromotePlanned == true)"*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_PromotePlanned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_PromotePlanned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_PromotePlanned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_PromotePlanned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy += 1;"*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true"*)
